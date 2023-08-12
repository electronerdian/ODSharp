using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using FibreSharp;
using FibreSharp.LibUsb;
using LibUsbDotNet;
using LibUsbDotNet.LibUsb;
using LibUsbDotNet.LudnMonoLibUsb;
using LibUsbDotNet.Main;
using ODSharp.Generated;

#if WINDOWS
using MadWizard.WinUSBNet;
using FibreSharp.WinUsb;
#endif

// I had to do a workaround of a bug in the USB descriptors, so this GUID won't be correct for you
enum Mode
{
    Reconfigure,
    Tune
}
static class Program
{
    public static async Task Main(string[] args)
    {
        var mode = Mode.Reconfigure;


        switch (mode)
        {
            case Mode.Reconfigure:
                await Reconfigure();
                break;

            case Mode.Tune:
                await Tune();
                break;
        }
    }

    private static async Task Tune()
    {
        var root = await Init();
        await root.clear_errors.InvokeAsync();
        root.axis0.config.enable_watchdog.Value = false;
        root.axis0.requested_state.Value = (byte)AxisState.IDLE;
        while (root.axis0.is_armed.Value)
        {
            Console.WriteLine("Waiting for axis disarm");
        }

        Console.WriteLine("Disarmed");
        await root.clear_errors.InvokeAsync();

        if (root.HasErrors())
        {
            root.DumpErrors();
            return;
        }


        Console.WriteLine("Set gains to defaults");
        root.axis0.controller.config.vel_gain.Value = 0.16f;
        root.axis0.controller.config.pos_gain.Value = 20.0f;
        root.axis0.controller.config.vel_integrator_gain.Value = 0.32f;

        Console.WriteLine("Set up for position control");
        root.axis0.controller.config.control_mode.Value = (byte)ControlMode.POSITION_CONTROL;
        await root.axis0.set_abs_pos.InvokeAsync(0.0f);
        root.axis0.controller.config.absolute_setpoints.Value = true;
        root.axis0.controller.input_pos.Value = 0.0f;

        Console.WriteLine("Arming");
        root.axis0.requested_state.Value = (byte)AxisState.CLOSED_LOOP_CONTROL;
        while (root.axis0.current_state.Value != (byte)AxisState.CLOSED_LOOP_CONTROL)
        {
            Console.WriteLine("Waiting for axis to arm");
            if (root.HasErrors())
            {
                root.DumpErrors();
                return;
            }
        }

        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("Set vel_integrator_gain gain to 0");
        root.axis0.controller.config.vel_integrator_gain.Value = 0.0f;

        Console.WriteLine("Make sure you have a stable system.If it is not, decrease all gains until you have one.");

        void MoveTo(C_ c, float target, float tolerance)
        {
            c.axis0.controller.input_pos.Value = target;
            while (true)
            {
                var distanceToGo = MathF.Abs(target - c.axis0.pos_vel_mapper.pos_abs.Value);
                Console.WriteLine(distanceToGo);
                if (distanceToGo < tolerance)
                {
                    break;
                }
            }
        }

        var positionTolerance = 0.02f;

        void Wiggle()
        {
            MoveTo(root, 0.25f, positionTolerance);

            MoveTo(root, 0.0f, positionTolerance);
            MoveTo(root, 0.25f, positionTolerance);

            MoveTo(root, 0.0f, positionTolerance);
            MoveTo(root, 0.25f, positionTolerance);

            MoveTo(root, 0.0f, positionTolerance);
        }

        Wiggle();
        
        Console.WriteLine("Increase vel_gain by around 30 % per iteration until the motor exhibits some vibration.");

        while (true)
        {
            var curGain = root.axis0.controller.config.vel_gain.Value;
            var newGain = curGain * 1.3f;
            Console.WriteLine($"{curGain} => {newGain}");

            var line = Console.ReadLine();
            if (line == "q")
            {
                return;
            }
            else if (line == "n")
            {
                break;
            }
            else if (line == "k")
            {
                root.axis0.controller.config.vel_gain.Value = newGain;
            }
        }

        Console.WriteLine("Back down vel_gain to 50 % of the vibrating value.");
        root.axis0.controller.config.vel_gain.Value *= 0.5f;

        //Increase pos_gain by around 30 % per iteration until you see some overshoot.

        //Back down pos_gain until you do not have overshoot anymore.

        //The integrator can be set to 0.5 * bandwidth * vel_gain, where bandwidth is the overall resulting tracking bandwidth of your system. Say your tuning made it track commands with a settling time of 100ms(the time from when the setpoint changes to when the system arrives at the new setpoint); this means the bandwidth was 


        //. In this case you should set

        //vel_integrator_gain = 0.5 * 10 * < vel_gain >
        //The liveplotter tool can be immensely helpful in dialing in these values. To display a graph that plots the position setpoint vs the measured position value run the following in the ODrive tool:

        //        start_liveplotter(lambda:[odrv0.axis0.pos_vel_mapper.pos_rel, odrv0.axis0.controller.pos_setpoint])

        while (true)
        {
            if (root.HasErrors())
            {
                root.DumpErrors();
                return;
            }

            Console.WriteLine($"input_pos: {root.axis0.controller.input_pos.Value}");
            Console.WriteLine($"Current pos: {root.axis0.pos_vel_mapper.pos_abs.Value} / {root.axis0.pos_vel_mapper.pos_rel.Value}");
            Console.WriteLine();

            await Task.Delay(500);
        }
    }

    private static async Task Reconfigure()
    {
        var root = await Init();
        DumpIDs(root);
        await root.axis0.watchdog_feed.InvokeAsync();
        if (root.HasErrors())
        {
            Console.WriteLine("Errors detected:");
            root.DumpErrors();

            Console.WriteLine("Clearing");
            await root.clear_errors.InvokeAsync();
            await Task.Delay(TimeSpan.FromSeconds(1));

            if (root.HasErrors())
            {
                Console.WriteLine("Still have errors, exiting:");
                root.DumpErrors();
                return;
            }
        }

        Console.WriteLine("Erasing config");
        root = await root.EraseConfiguration();

        Console.WriteLine("Setting battery config");
        var batNCells = 6; // # number of cells in series
        var batCapacity = 6.000f; //# capacity of the battery in Ah
        root.config.dc_bus_undervoltage_trip_level.Value = 3.3f * batNCells;
        root.config.dc_bus_overvoltage_trip_level.Value = 4.25f * batNCells;
        root.config.dc_max_positive_current.Value = batCapacity * 10;
        root.config.dc_max_negative_current.Value = -batCapacity * 1;

        Console.WriteLine("Setting motor config");
        root.axis0.config.motor.motor_type.Value = (byte)MotorType.HIGH_CURRENT;
        root.axis0.config.motor.pole_pairs.Value = 7;
        root.axis0.config.motor.torque_constant.Value = 8.27f / 270;

        Console.WriteLine("Setting encoder config");
        root.amt21_encoder_group0.config.enable.Value = true;
        root.axis0.config.load_encoder.Value = (byte)EncoderId.AMT21_ENCODER0;
        root.axis0.config.commutation_encoder.Value = (byte)EncoderId.AMT21_ENCODER0;

        Console.WriteLine("Setting UART config");
        root.config.enable_uart_a.Value = true;
        root.config.gpio12_mode.Value = (byte)GpioMode.UART_A;
        root.config.gpio13_mode.Value = (byte)GpioMode.UART_A;
        root.config.uart0_protocol.Value = (byte)StreamProtocolType.ASCII;

        Console.WriteLine("Setting watchdog config");
        root.axis0.config.watchdog_timeout.Value = 5.0f;
        root.axis0.config.enable_watchdog.Value = false;

        Console.WriteLine("Setting misc config");
        root.axis0.config.motor.calibration_current.Value = 20.0f;
        root.axis0.config.motor.current_soft_max.Value = 50.0f;
        root.axis0.config.motor.current_hard_max.Value = 60.0f;

        root = await root.SaveConfiguration();

        Console.WriteLine("Waiting for initialization");
        while ((((ODriveError)root.axis0.active_errors.Value) & ODriveError.INITIALIZING) != 0)
        {
            Console.WriteLine("ODrive is still initializing");
            await Task.Delay(TimeSpan.FromSeconds(1));
        }

        Console.WriteLine("Calibrating");
        root.axis0.requested_state.Value = (byte)AxisState.FULL_CALIBRATION_SEQUENCE;
        await Task.Delay(TimeSpan.FromSeconds(0.5));
        while (root.axis0.current_state.Value != (byte)AxisState.IDLE)
        {
            Console.WriteLine("Waiting for idle");
            await Task.Delay(TimeSpan.FromSeconds(1));
        }

        if (root.HasErrors())
        {
            Console.WriteLine("Errors detected:");
            root.DumpErrors();
            return;
        }

        Console.WriteLine("Enabling watchdog");
        root.axis0.config.enable_watchdog.Value = true;

        Console.WriteLine("Saving config");
        root = await root.SaveConfiguration();

        Console.WriteLine();
    }

    private static void DumpIDs(C_ root)
    {
        Console.WriteLine(
            $"HW: {root.hw_version_major.Value}.{root.hw_version_minor.Value}-{root.hw_version_variant.Value}");
        Console.WriteLine(
            $"FW: {root.fw_version_major.Value}.{root.fw_version_minor.Value}.{root.fw_version_revision.Value} [{root.commit_hash.Value:X8}] {(root.fw_version_unreleased.Value != 0 ? "(unreleased)" : "")}");
        Console.WriteLine($"Serial: {root.serial_number.Value:X16}");
    }

    private static void DumpErrors(this C_ root)
    {
        Console.WriteLine($"Active errors: {(ODriveError)root.axis0.active_errors.Value}");
        Console.WriteLine($"Disarm reason: {(ODriveError)root.axis0.disarm_reason.Value}");
        Console.WriteLine($"Procedure result: {(ProcedureResult)root.axis0.procedure_result.Value}");
        Console.WriteLine($"DRV fault: {root.axis0.last_drv_fault.Value}");
    }

    private static bool HasErrors(this C_ root)
    {
        return (ODriveError)root.axis0.active_errors.Value != ODriveError.NONE
               || (ODriveError)root.axis0.disarm_reason.Value != ODriveError.NONE
               || (ProcedureResult)root.axis0.procedure_result.Value != ProcedureResult.SUCCESS
            ; //|| root.axis0.last_drv_fault.Value != 0;
    }

    private static async Task<C_> EraseConfiguration(this C_ c1)
    {
        return await c1.ExpectReboot(async () => await c1.erase_configuration.InvokeAsync());
    }
    private static async Task<C_> SaveConfiguration(this C_ c1)
    {
        return await c1.ExpectReboot(async () => await c1.save_configuration.InvokeAsync());
    }

    private static async Task<C_> ExpectReboot(this C_ root, Func<Task> func)
    {
        try
        {
            await func();
            return root;
        }
        catch (FibreChannelException ex)
        {
            Debug.Print($"Expected channel close exception: {ex}");
            await Task.Delay(TimeSpan.FromMilliseconds(1000));
            return await Init();
        }
    }

    private static async Task<C_> Init()
    {
#if WINDOWS
        USBDevice? singleDevice = null;
        while (singleDevice == null)
        {
            singleDevice = USBDevice.GetSingleDevice("EA0BD5C3-50F3-4888-84B4-74E50E1649DB");
        }

        var winUsbPacketTransport = new WinUsbPacketTransport(singleDevice.Interfaces[2]);
#else

        foreach (var device in MonoUsbDevice.MonoUsbDeviceList)
        {
            device.Open();
            Console.WriteLine($"{device.DevicePath}");
            Console.WriteLine(device.Info.Descriptor.VendorID);
            Console.WriteLine($"{JsonSerializer.Serialize(device.Info)}");
            device.Close();
        }

       // using var openUsbDevice = UsbDevice.OpenUsbDevice(new UsbDeviceFinder(new Guid("EA0BD5C3-50F3-4888-84B4-74E50E1649DB")));
       using var openUsbDevice = MonoUsbDevice.MonoUsbDeviceList.Single(x => x.Info.Descriptor.ProductID == 0x0d32);

        var winUsbPacketTransport = new LibUsbPacketTransport((IUsbDevice)openUsbDevice);

#endif
        var lowLevel = new LegacyFibreChannel(winUsbPacketTransport);
        lowLevel.Start();

        var commFactory = new LegacyFibreClientFactory();
        var midLevel = await commFactory.Get(lowLevel);

        return C_.Construct(midLevel);
    }
}

class G : IPacketTransport
{
    private F<IPacketTransport> innerTransport;

    public G(F<IPacketTransport> innerTransport)
    {
        this.innerTransport = innerTransport;
    }

    public async Task<int> ReceivePacketAsync(byte[] buffer, int offset, int count)
    {
        return await innerTransport.Invoke(i => i.ReceivePacketAsync(buffer, offset, count));
    }

    public async Task SendPacketAsync(byte[] buffer, int offset, int count)
    {
        await innerTransport.Invoke(i => i.SendPacketAsync(buffer, offset, count));
    }
}

class F<U>
{
    private readonly Func<Task<U>> _factory;
    private U? _root;
    private static readonly TimeSpan Timeout = TimeSpan.FromMinutes(1);

    public F(Func<Task<U>> factory)
    {
        this._factory = factory;
    }
    
    public async Task<T> Invoke<T>(Func<U, Task<T>> func, [CallerArgumentExpression("func")] string expression = "(unknown)")
    {
        return await InvokeCore(func, expression);
    }

    public async Task<T> Invoke<T>(Func<U, T> func, [CallerArgumentExpression("func")] string expression = "(unknown)")
    {
        return await InvokeCore(
            r => Task.FromResult(func(r)),
            expression);
    }


    public async Task Invoke(Action<U> action, [CallerArgumentExpression("action")] string expression = "(unknown)")
    {
        await InvokeCore(
            r =>
            {
                action(r);
                return Task.FromResult(0);
            },
            expression);
    }

    public async Task Invoke(Func<U, Task> action, [CallerArgumentExpression("action")] string expression = "(unknown)")
    {
        await InvokeCore(
            async r =>
            {
                await action(r);
                return Task.FromResult(0);
            },
            expression);
    }
    
    private async Task<T> InvokeCore<T>(Func<U, Task<T>> func, string expression)
    {
        var s = Stopwatch.StartNew();
        while (s.Elapsed < Timeout)
        {
            Debug.Print($"Trying {expression} after {s.Elapsed}");
            await EnsureConnected(s);
            return await func(_root);
        }

        throw new TimeoutException($"Ran out of time to invoke {expression} after {s.Elapsed}");
    }

    private async Task EnsureConnected(Stopwatch stopwatch)
    {
        if (_root is not null) return;

        while (stopwatch.Elapsed < Timeout)
        {
            _root = await _factory();
            return;
        }
    }
}