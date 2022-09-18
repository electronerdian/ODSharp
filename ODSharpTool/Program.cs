using System.Diagnostics;
using System.Runtime.CompilerServices;
using FibreSharp;
using FibreSharp.WinUsb;
using MadWizard.WinUSBNet;
using ODSharp.Generated;

// I had to do a workaround of a bug in the USB descriptors, so this GUID won't be correct for you

var f = new F(
    async () =>
    {
        var singleDevice = USBDevice.GetSingleDevice("ab2341e7-f25f-413d-bd4e-60eade8cb46c");

        var packetChannel = new WinUsbPacketTransport(singleDevice.Interfaces[2]);
        var lowLevel = new LegacyFibreChannel(packetChannel);
        lowLevel.Start();

        var commFactory = new LegacyFibreClientFactory();
        var midLevel = await commFactory.Get(lowLevel);

        return C_.Construct(midLevel);
    });

/*
Console.WriteLine($"iBus = {root.ibus.Value}");
Console.WriteLine($"ODrive hw version {root.hw_version_major.Value}.{root.hw_version_minor.Value}, serial {root.serial_number.Value:X12}");
Console.WriteLine($"ODrive fw version {root.fw_version_major.Value}.{root.fw_version_minor.Value}.{root.fw_version_revision.Value}, commit hash {root.commit_hash.Value:X8}");

Console.WriteLine($"Current state = {(AxisState)root.axis0.current_state.Value}");
Console.WriteLine($"Error = {(AxisError)root.axis0.active_errors.Value}");

Console.WriteLine($"input_pos = {root.axis0.controller.input_pos}");

Console.WriteLine($"ADC = {await root.get_adc_voltage.InvokeAsync(16)}");

await root.clear_errors.InvokeAsync();

root.axis0.requested_state.Value = (byte)AxisState.CLOSED_LOOP_CONTROL;
while ((AxisState)root.axis0.current_state.Value != AxisState.CLOSED_LOOP_CONTROL)
{
    var activeErrors = (AxisError)root.axis0.active_errors.Value;
    if (activeErrors != AxisError.NONE)
    {
        throw new Exception(activeErrors.ToString());
    }
}

await root.axis0.controller.move_incremental.InvokeAsync(displacement: 1.5f, from_input_pos: false);
await Task.Delay(TimeSpan.FromSeconds(1.5));
await root.axis0.controller.move_incremental.InvokeAsync(displacement: -0.3f, from_input_pos: false);
*/

//await root.erase_configuration.InvokeAsync();
root.axis0.config.enable_watchdog.Value = false;

var batNCells = 6;// # number of cells in series
var batCapacity = 6.000f; //# capacity of the battery in Ah
root.config.dc_bus_undervoltage_trip_level.Value = 3.3f * batNCells;
root.config.dc_bus_overvoltage_trip_level.Value = 4.25f * batNCells;
root.config.dc_max_positive_current.Value = batCapacity * 10;
root.config.dc_max_negative_current.Value = -batCapacity * 1;

//await root.save_configuration.InvokeAsync();

root.axis0.config.motor.motor_type.Value = (byte)MotorType.HIGH_CURRENT;
root.axis0.config.motor.pole_pairs.Value = 7;
root.axis0.config.motor.torque_constant.Value = 8.27f / 270;

//await root.save_configuration.InvokeAsync();

root.amt21_encoder_group0.config.enable.Value = true;
root.axis0.config.load_encoder.Value = (byte)EncoderId.AMT21_ENCODER0;
root.axis0.config.commutation_encoder.Value = (byte)EncoderId.AMT21_ENCODER0;

//await root.save_configuration.InvokeAsync();

root.config.enable_uart_a.Value = true;
root.config.gpio12_mode.Value = (byte)GpioMode.UART_A;
root.config.gpio13_mode.Value = (byte)GpioMode.UART_A;
root.config.uart0_protocol.Value = (byte)StreamProtocolType.ASCII;

root.axis0.config.watchdog_timeout.Value = 5.0f;
root.axis0.config.enable_watchdog.Value = false;

root.axis0.requested_state.Value = (byte)AxisState.FULL_CALIBRATION_SEQUENCE;
while (root.axis0.current_state.Value != (byte)AxisState.IDLE)
{
    Console.WriteLine("Waiting for idle");
    await Task.Delay(TimeSpan.FromSeconds(1));
}

root.axis0.config.enable_watchdog.Value = true;
//await root.save_configuration.InvokeAsync();


Console.WriteLine();

class F
{
    private readonly Func<Task<C_>> _factory;
    private C_? _root;
    private static readonly TimeSpan Timeout = TimeSpan.FromMinutes(1);

    public F(Func<Task<C_>> factory)
    {
        this._factory = factory;
    }
    
    public async Task<T> Invoke<T>(Func<C_, Task<T>> func, [CallerArgumentExpression("func")] string expression = "(unknown)")
    {
        return await InvokeCore(func, expression);
    }

    private async Task InvokeCore<T>(Func<C_, Task<T>> func, string expression)
    {
        var s = Stopwatch.StartNew();
        while (s.Elapsed < Timeout)
        {
            await EnsureConnected(s);
            return await func(_root);
        }

        throw new TimeoutException($"Ran out of time to invoke {expression} after {s.Elapsed}");
    }

    public async Task<T> Invoke<T>(Func<C_, T> func, [CallerArgumentExpression("func")] string expression = "(unknown)")
    {
        return await Invoke(
            r => Task.FromResult(func(r)),
            expression);
    }


    public async Task Invoke(Action<C_> action)
    {
        await Invoke(
            r =>
            {
                action(r);
                return 0;
            });
    }

    public async Task Invoke(Func<C_, Task> action)
    {
        await Invoke(
            async r =>
            {
                await action(r);
                return 0;
            });
    }
    
    private async Task EnsureConnected(Stopwatch stopwatch)
    {
        while (stopwatch.Elapsed < Timeout)
        {
            _root = await _factory();
            return;
        }
    }
}