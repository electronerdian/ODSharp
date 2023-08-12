using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using FibreSharp;
using FibreSharp.LibUsb;
using LibUsbDotNet;
using LibUsbDotNet.LibUsb;
using LibUsbDotNet.Main;
using ODSharp;
using ODSharp.Generated;

#if WINDOWS
using MadWizard.WinUSBNet;
using FibreSharp.WinUsb;
#endif

// I had to do a workaround of a bug in the USB descriptors, so this GUID won't be correct for you
enum Mode
{
    Reconfigure,
    Tune,
    Run
}
static class Program
{
    public static async Task Main(string[] args)
    {
        var mode = Mode.Run;


        switch (mode)
        {
            case Mode.Reconfigure:
                await Reconfigure();
                break;

            case Mode.Tune:
                await Tune();
                break;

            case Mode.Run:
                await Run();
                break;
        }
    }

    private static async Task Run()
    {
        var leftDrive = await Init();
        var rightDrive = await Init();

        
    }

    private static async Task Tune()
    {
        var driveContext = await Init();
        await driveContext.Root.clear_errors.InvokeAsync();
        driveContext.Root.axis0.config.enable_watchdog.Value = false;
        driveContext.Root.axis0.requested_state.Value = (byte)AxisState.IDLE;
        while (driveContext.Root.axis0.is_armed.Value)
        {
            Console.WriteLine("Waiting for axis disarm");
        }

        Console.WriteLine("Disarmed");
        await driveContext.Root.clear_errors.InvokeAsync();

        if (driveContext.Root.HasErrors())
        {
            driveContext.Root.DumpErrors();
            return;
        }


        Console.WriteLine("Set gains to defaults");
        driveContext.Root.axis0.controller.config.vel_gain.Value = 0.16f;
        driveContext.Root.axis0.controller.config.pos_gain.Value = 20.0f;
        driveContext.Root.axis0.controller.config.vel_integrator_gain.Value = 0.32f;

        Console.WriteLine("Set up for position control");
        driveContext.Root.axis0.controller.config.control_mode.Value = (byte)ControlMode.POSITION_CONTROL;
        await driveContext.Root.axis0.set_abs_pos.InvokeAsync(0.0f);
        driveContext.Root.axis0.controller.config.absolute_setpoints.Value = true;
        driveContext.Root.axis0.controller.input_pos.Value = 0.0f;

        Console.WriteLine("Arming");
        driveContext.Root.axis0.requested_state.Value = (byte)AxisState.CLOSED_LOOP_CONTROL;
        while (driveContext.Root.axis0.current_state.Value != (byte)AxisState.CLOSED_LOOP_CONTROL)
        {
            Console.WriteLine("Waiting for axis to arm");
            if (driveContext.Root.HasErrors())
            {
                driveContext.Root.DumpErrors();
                return;
            }
        }

        Console.WriteLine("-----------------------------------------------");

        Console.WriteLine("Set vel_integrator_gain gain to 0");
        driveContext.Root.axis0.controller.config.vel_integrator_gain.Value = 0.0f;

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
            MoveTo(driveContext.Root, 0.25f, positionTolerance);

            MoveTo(driveContext.Root, 0.0f, positionTolerance);
            MoveTo(driveContext.Root, 0.25f, positionTolerance);

            MoveTo(driveContext.Root, 0.0f, positionTolerance);
            MoveTo(driveContext.Root, 0.25f, positionTolerance);

            MoveTo(driveContext.Root, 0.0f, positionTolerance);
        }

        Wiggle();
        
        Console.WriteLine("Increase vel_gain by around 30 % per iteration until the motor exhibits some vibration.");

        while (true)
        {
            var curGain = driveContext.Root.axis0.controller.config.vel_gain.Value;
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
                driveContext.Root.axis0.controller.config.vel_gain.Value = newGain;
            }
        }

        Console.WriteLine("Back down vel_gain to 50 % of the vibrating value.");
        driveContext.Root.axis0.controller.config.vel_gain.Value *= 0.5f;

        //Increase pos_gain by around 30 % per iteration until you see some overshoot.

        //Back down pos_gain until you do not have overshoot anymore.

        //The integrator can be set to 0.5 * bandwidth * vel_gain, where bandwidth is the overall resulting tracking bandwidth of your system. Say your tuning made it track commands with a settling time of 100ms(the time from when the setpoint changes to when the system arrives at the new setpoint); this means the bandwidth was 


        //. In this case you should set

        //vel_integrator_gain = 0.5 * 10 * < vel_gain >
        //The liveplotter tool can be immensely helpful in dialing in these values. To display a graph that plots the position setpoint vs the measured position value run the following in the ODrive tool:

        //        start_liveplotter(lambda:[odrv0.axis0.pos_vel_mapper.pos_rel, odrv0.axis0.controller.pos_setpoint])

        while (true)
        {
            if (driveContext.Root.HasErrors())
            {
                driveContext.Root.DumpErrors();
                return;
            }

            Console.WriteLine($"input_pos: {driveContext.Root.axis0.controller.input_pos.Value}");
            Console.WriteLine($"Current pos: {driveContext.Root.axis0.pos_vel_mapper.pos_abs.Value} / {driveContext.Root.axis0.pos_vel_mapper.pos_rel.Value}");
            Console.WriteLine();

            await Task.Delay(500);
        }
    }

    private static async Task Reconfigure()
    {
        var driveContext = await Init();
        DumpIDs(driveContext.Root);
        await driveContext.Root.axis0.watchdog_feed.InvokeAsync();
        if (driveContext.Root.HasErrors())
        {
            Console.WriteLine("Errors detected:");
            driveContext.Root.DumpErrors();

            Console.WriteLine("Clearing");
            await driveContext.Root.clear_errors.InvokeAsync();
            await Task.Delay(TimeSpan.FromSeconds(1));

            if (driveContext.Root.HasErrors())
            {
                Console.WriteLine("Still have errors, exiting:");
                driveContext.Root.DumpErrors();
                return;
            }
        }

        Console.WriteLine("Erasing config");
        driveContext = await driveContext.EraseConfiguration();

        Console.WriteLine("Setting battery config");
        var batNCells = 6; // # number of cells in series
        var batCapacity = 6.000f; //# capacity of the battery in Ah
        driveContext.Root.config.dc_bus_undervoltage_trip_level.Value = 3.3f * batNCells;
        driveContext.Root.config.dc_bus_overvoltage_trip_level.Value = 4.25f * batNCells;
        driveContext.Root.config.dc_max_positive_current.Value = batCapacity * 10;
        driveContext.Root.config.dc_max_negative_current.Value = -batCapacity * 1;

        Console.WriteLine("Setting motor config");
        driveContext.Root.axis0.config.motor.motor_type.Value = (byte)MotorType.HIGH_CURRENT;
        driveContext.Root.axis0.config.motor.pole_pairs.Value = 7;
        driveContext.Root.axis0.config.motor.torque_constant.Value = 8.27f / 270;

        Console.WriteLine("Setting encoder config");
        driveContext.Root.amt21_encoder_group0.config.enable.Value = true;
        driveContext.Root.axis0.config.load_encoder.Value = (byte)EncoderId.AMT21_ENCODER0;
        driveContext.Root.axis0.config.commutation_encoder.Value = (byte)EncoderId.AMT21_ENCODER0;

        Console.WriteLine("Setting UART config");
        driveContext.Root.config.enable_uart_a.Value = true;
        driveContext.Root.config.gpio12_mode.Value = (byte)GpioMode.UART_A;
        driveContext.Root.config.gpio13_mode.Value = (byte)GpioMode.UART_A;
        driveContext.Root.config.uart0_protocol.Value = (byte)StreamProtocolType.ASCII;

        Console.WriteLine("Setting watchdog config");
        driveContext.Root.axis0.config.watchdog_timeout.Value = 5.0f;
        driveContext.Root.axis0.config.enable_watchdog.Value = false;

        Console.WriteLine("Setting misc config");
        driveContext.Root.axis0.config.motor.calibration_current.Value = 20.0f;
        driveContext.Root.axis0.config.motor.current_soft_max.Value = 50.0f;
        driveContext.Root.axis0.config.motor.current_hard_max.Value = 60.0f;

        driveContext = await driveContext.SaveConfiguration();

        Console.WriteLine("Waiting for initialization");
        while ((((ODriveError)driveContext.Root.axis0.active_errors.Value) & ODriveError.INITIALIZING) != 0)
        {
            Console.WriteLine("ODrive is still initializing");
            await Task.Delay(TimeSpan.FromSeconds(1));
        }

        Console.WriteLine("Calibrating");
        driveContext.Root.axis0.requested_state.Value = (byte)AxisState.FULL_CALIBRATION_SEQUENCE;
        await Task.Delay(TimeSpan.FromSeconds(0.5));
        while (driveContext.Root.axis0.current_state.Value != (byte)AxisState.IDLE)
        {
            Console.WriteLine("Waiting for idle");
            await Task.Delay(TimeSpan.FromSeconds(1));
        }

        if (driveContext.Root.HasErrors())
        {
            Console.WriteLine("Errors detected:");
            driveContext.Root.DumpErrors();
            return;
        }

        Console.WriteLine("Enabling watchdog");
        driveContext.Root.axis0.config.enable_watchdog.Value = true;

        Console.WriteLine("Saving config");
        driveContext = await driveContext.SaveConfiguration();

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

    private static async Task<DriveContext> EraseConfiguration(this DriveContext context)
    {
        return await context.ExpectReboot(async () => await context.Root.erase_configuration.InvokeAsync());
    }
    private static async Task<DriveContext> SaveConfiguration(this DriveContext context)
    {
        return await context.ExpectReboot(async () => await context.Root.save_configuration.InvokeAsync());
    }

    private static async Task<DriveContext> ExpectReboot(this DriveContext context, Func<Task> func)
    {
        try
        {
            await func();
        }
        catch (FibreChannelException ex)
        {
            Debug.Print($"Expected exception after channel close: {ex}");
        }

        await Task.Delay(TimeSpan.FromMilliseconds(1000));
        context.Dispose();

        return await Init();
    }

        static readonly IUsbContext UsbContext = new UsbContext();

        private static async Task<DriveContext> Init()
    {
#if WINDOWS
        USBDevice? usbDevice = null;
        while (usbDevice == null)
        {
            usbDevice = USBDevice.GetSingleDevice("EA0BD5C3-50F3-4888-84B4-74E50E1649DB");
        }

        var winUsbPacketTransport = new WinUsbPacketTransport(usbDevice.Interfaces[2]);
#else
        UsbContext.SetDebugLevel(LogLevel.Warning | LogLevel.Error);
#if WAIT_FOR_DEBUGGER
        while (!Debugger.IsAttached)
        {
            Console.WriteLine("Waiting for debugger");
            Thread.Sleep(1000);
        }
        Debugger.Break();
#endif
        foreach (var device in UsbContext.List())
        {
            Console.WriteLine($"{device.Info.Usb:d3} {device.Info.VendorId:x4}/{device.Info.ProductId:x4} {device.Info.Manufacturer} {device.Info.Product}");
        }

       // using var openUsbDevice = UsbDevice.OpenUsbDevice(new UsbDeviceFinder(new Guid("EA0BD5C3-50F3-4888-84B4-74E50E1649DB")));
       var usbDevice = UsbContext.Find(new UsbDeviceFinder(0x1209,  0x0d32));
       
       usbDevice.Open();
       if (!usbDevice.ClaimInterface(2))
       {
           throw new Exception("Failed to claim interface");
       }

       var winUsbPacketTransport = new LibUsbPacketTransport(
           usbDevice.OpenEndpointReader(ReadEndpointID.Ep03),
           usbDevice.OpenEndpointWriter(WriteEndpointID.Ep03));

#endif
        var lowLevel = new LegacyFibreChannel(winUsbPacketTransport);
        lowLevel.Start();

        var commFactory = new LegacyFibreClientFactory();
        var midLevel = await commFactory.Get(lowLevel);

        return new DriveContext(C_.Construct(midLevel), usbDevice);
    }
}