using FibreSharp;
using FibreSharp.WinUsb;
using MadWizard.WinUSBNet;
using ODSharp.Generated;

// I had to do a workaround of a bug in the USB descriptors, so this GUID won't be correct for you
var singleDevice = USBDevice.GetSingleDevice("ab2341e7-f25f-413d-bd4e-60eade8cb46c");

var packetChannel = new WinUsbPacketTransport(singleDevice.Interfaces[2]);
var lowLevel = new LegacyFibreChannel(packetChannel);
lowLevel.Start();

var commFactory = new LegacyFibreClientFactory();
var midLevel = await commFactory.Get(lowLevel);

var root = C_.Construct(midLevel);
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

Console.WriteLine();