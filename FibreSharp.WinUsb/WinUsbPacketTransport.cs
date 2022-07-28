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

    public Task<int> ReceivePacketAsync(byte[] buffer, int offset, int count)
    {
        return Task.Factory.FromAsync(_inPipe.BeginRead, _inPipe.EndRead, buffer, offset, count, null);
    }
    public Task SendPacketAsync(byte[] buffer, int offset, int count)
    {
        return Task.Factory.FromAsync(_usbInterfaceOutPipe.BeginWrite, _usbInterfaceOutPipe.EndWrite, buffer, offset, count, null);
    }
}