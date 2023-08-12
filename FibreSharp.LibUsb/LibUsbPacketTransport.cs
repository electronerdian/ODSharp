using LibUsbDotNet;
using LibUsbDotNet.LibUsb;
using LibUsbDotNet.Main;
using System.Threading;

namespace FibreSharp.LibUsb
{
    public class LibUsbException : Exception
    {
        public LibUsbException(ErrorCode errorCode)
            : base($"LibUsb error: {errorCode}")
        {
            ErrorCode = errorCode;
        }

        public ErrorCode ErrorCode { get; }
    }
    public class LibUsbPacketTransport : IPacketTransport
    {
        private readonly UsbEndpointReader _reader;
        private readonly UsbEndpointWriter _writer;

        public LibUsbPacketTransport(IUsbDevice device)
            : this(device .OpenEndpointReader(ReadEndpointID.Ep03), device.OpenEndpointWriter(WriteEndpointID.Ep03))
        {
        }

        public LibUsbPacketTransport(UsbEndpointReader reader, UsbEndpointWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }
        public async Task<int> ReceivePacketAsync(byte[] buffer, int offset, int count)
        {
            return await _reader.TransferAsync(buffer, offset, count, 0);

        }

        public async Task SendPacketAsync(byte[] buffer, int offset, int count)
        {
            await _writer.TransferAsync(buffer, offset, count, 0);
        }
    }

    internal static class Extensions
    {
        public static async Task WaitOneAsync(this WaitHandle waitHandle)
        {
            TaskCompletionSource tcs = new();
            var rwh = ThreadPool.RegisterWaitForSingleObject(
                waitHandle,
                static (tcs, _) => ((TaskCompletionSource)tcs!).SetResult(),
                tcs,
                Timeout.InfiniteTimeSpan,
                executeOnlyOnce: true);
            await tcs.Task.ConfigureAwait(false);
            rwh.Unregister(null);
            
        }

        public static async Task<int> TransferAsync(this UsbEndpointBase endpointBase, byte[] buffer, int offset, int count, int timeout)
        {
            using var transfer = endpointBase.NewAsyncTransfer();

            transfer.Fill(buffer, offset, count, timeout);
            transfer.Submit().ThrowIfFailed();
                
            await transfer.AsyncWaitHandle.WaitOneAsync();

            transfer.Wait(out var transferredCount).ThrowIfFailed();
            
            return transferredCount;
        }

        public static void ThrowIfFailed(this ErrorCode ec)
        {
            if (ec != ErrorCode.None)
            {
                throw new LibUsbException(ec);
            }
        }
    }
}