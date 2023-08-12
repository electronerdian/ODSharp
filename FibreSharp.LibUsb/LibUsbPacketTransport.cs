using LibUsbDotNet;
using LibUsbDotNet.LibUsb;
using LibUsbDotNet.Main;
using System.Threading;

namespace FibreSharp.LibUsb
{
    public class LibUsbPacketTransport : IPacketTransport
    {
        private readonly UsbEndpointReader _reader;
        private readonly UsbEndpointWriter _writer;

        public LibUsbPacketTransport(UsbEndpointReader reader, UsbEndpointWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }
        public Task<int> ReceivePacketAsync(byte[] buffer, int offset, int count)
        {
            _reader.Read(buffer, offset, count, timeout: 0, out var transferLength).ThrowOnError();
            return Task.FromResult(transferLength);

        }

        public Task SendPacketAsync(byte[] buffer, int offset, int count)
        {
            _writer.Write(buffer, offset, count, timeout: 0, out _).ThrowOnError();
            return Task.CompletedTask;
        }
    }
}