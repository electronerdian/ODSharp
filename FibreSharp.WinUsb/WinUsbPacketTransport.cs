using MadWizard.WinUSBNet;

namespace FibreSharp.WinUsb;

public class WinUsbPacketTransport : IPacketTransport
{
    private readonly USBPipe _inPipe;
    private readonly USBPipe _usbInterfaceOutPipe;

    public WinUsbPacketTransport(USBInterface usbInterface) : this(usbInterface.InPipe, usbInterface.OutPipe)
    {

    }
    public WinUsbPacketTransport(USBPipe inPipe, USBPipe outPipe)
    {
        _inPipe = inPipe;
        _usbInterfaceOutPipe = outPipe;
    }

    public async Task<int> ReceivePacketAsync(byte[] buffer, int offset, int count)
    {
        //Console.WriteLine("Rec");
        var result = await Task.Factory.FromAsync(_inPipe.BeginRead, _inPipe.EndRead, buffer, offset, count, null);
        //Console.WriteLine($"Rec {Convert.ToHexString(buffer[offset..(offset + result)])}");
        return result;
    }
    public async Task SendPacketAsync(byte[] buffer, int offset, int count)
    {
        //Console.WriteLine($"{GetHashCode()} Send {Convert.ToHexString(buffer[offset..(offset + count)])}");
        await Task.Factory.FromAsync(_usbInterfaceOutPipe.BeginWrite, _usbInterfaceOutPipe.EndWrite, buffer, offset, count, null);
        //Console.WriteLine("Sent");
    }
}