using System.Buffers;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace FibreSharp;

public class LegacyFibreChannel : ILegacyFibreChannel
{
    private object _lock = new object();
    private bool closed = false;
    private const int BufferSize = 256;
    private readonly ArrayPool<byte> _arrayPool = ArrayPool<byte>.Shared;
    private readonly IPacketTransport _packetTransport;
    private ConcurrentDictionary<ushort, IReceiver> _pendingMessages = new();
    private readonly SequenceCounter _sequenceCounter = new();

    public LegacyFibreChannel(IPacketTransport packetTransport)
    {
        _packetTransport = packetTransport;
    }

    private async ValueTask SendPacketAsync<TArg>(
        ushort sequenceNumber,
        ushort endpointId,
        bool responseExpected,
        ushort responseLength,
        ushort crc,
        ushort payloadLength,
        SpanAction<byte, TArg> payloadAction,
        TArg payloadArg)
    {
        ArgChecker.Range(sequenceNumber, 0, 0x7FFF);
        ArgChecker.Range(endpointId, 0, 0x7FFF);

        //Console.WriteLine($"Sending {sequenceNumber:x} to {endpointId:x}");

        var packetLength = payloadLength + 8;

        var buffer = _arrayPool.Rent(packetLength);
        BitConverter.TryWriteBytes(buffer.AsSpan(0), sequenceNumber);
        BitConverter.TryWriteBytes(buffer.AsSpan(2), responseExpected ? endpointId | 0x8000 : endpointId);
        BitConverter.TryWriteBytes(buffer.AsSpan(4), responseLength);
        payloadAction(buffer.AsSpan(6, payloadLength), payloadArg);
        BitConverter.TryWriteBytes(buffer.AsSpan(6 + payloadLength), crc);
        //Debug.Print(Convert.ToHexString(buffer[..packetLength]));
        await _packetTransport.SendPacketAsync(buffer, 0, packetLength);

        //Console.WriteLine($"Sent {sequenceNumber}");
    }

    public async Task SendAndWaitAsync(
        ushort endpointId,
        ushort crc)
    {
        await SendAndWaitAsync(
            endpointId,
            crc,
            payloadLength: 0,
            payloadAction: (_, _) => { },
            payloadArg: 0);
    }

    public async Task SendAndWaitAsync<TPayloadArg>(
        ushort endpointId,
        ushort crc,
        ushort payloadLength,
        SpanAction<byte, TPayloadArg> payloadAction,
        TPayloadArg payloadArg)
    {
        var sequenceNumber = _sequenceCounter.Next();
        var responseTask = WaitForResponseAsync(sequenceNumber);
        await SendPacketAsync(
            sequenceNumber,
            endpointId,
            responseExpected: true,
            responseLength: 0,
            crc,
            payloadLength,
            payloadAction,
            payloadArg);

        await responseTask;
    }
    public async Task<TResult> SendAndReceiveAsync<TResult>(
        ushort endpointId,
        ushort crc,
        ushort responseLength,
        ByteSpanConvertFunc<TResult> responseConvertFunc)
    {
        return await SendAndReceiveAsync(
            endpointId,
            crc,
            payloadLength: 0,
            payloadAction: (_, _) => { },
            payloadArg: 0,
            responseLength,
            responseConvertFunc);
    }

    public async Task<TResult> SendAndReceiveAsync<TResult, TPayloadArg>(
        ushort endpointId,
        ushort crc,
        ushort payloadLength,
        SpanAction<byte, TPayloadArg> payloadAction,
        TPayloadArg payloadArg,
        ushort responseLength,
        ByteSpanConvertFunc<TResult> responseConvertFunc)
    {
        var sequenceNumber = _sequenceCounter.Next();
        var responseTask = WaitForResponseAsync(sequenceNumber, responseConvertFunc);
        await SendPacketAsync(
            sequenceNumber,
            endpointId,
            responseExpected: true,
            responseLength,
            crc,
            payloadLength,
            payloadAction,
            payloadArg);

        return await responseTask;
    }

    public async Task SendAndForgetAsync<TPayloadArg>(
        ushort endpointId,
        ushort crc,
        ushort payloadLength,
        SpanAction<byte, TPayloadArg> payloadAction,
        TPayloadArg payloadArg)
    {
        var sequenceNumber = _sequenceCounter.Next();
        await SendPacketAsync(
            sequenceNumber,
            endpointId,
            responseExpected: false,
            responseLength: 0,
            crc,
            payloadLength,
            payloadAction,
            payloadArg);
    }

    public async Task SendAndForgetAsync(
        ushort endpointId,
        ushort crc)
    {
        var sequenceNumber = _sequenceCounter.Next();
        await SendPacketAsync(
            sequenceNumber,
            endpointId,
            responseExpected: false,
            responseLength: 0,
            crc,
            payloadLength: 0,
            payloadAction: (_, _) => { },
            payloadArg: 0);
    }

    private interface IReceiver
    {
        void Receive(ReadOnlySpan<byte> payload);
        void Fault(Exception exception);
    }

    private class Receiver<T> : IReceiver
    {
        private readonly ByteSpanConvertFunc<T> _convertFunc;
        private readonly TaskCompletionSource<T> _tcs;
        public Task<T> Task => _tcs.Task;

        public Receiver(ByteSpanConvertFunc<T> convertFunc)
        {
            _convertFunc = convertFunc;
            _tcs = new TaskCompletionSource<T>(TaskCreationOptions.RunContinuationsAsynchronously);
        }

        public void Receive(ReadOnlySpan<byte> payload)
        {
            _tcs.SetResult(_convertFunc(payload));
        }

        public void Fault(Exception exception)
        {
            _tcs.SetException(exception);
        }
    }

    private class Receiver : IReceiver
    {
        private readonly TaskCompletionSource _tcs;
        public Task Task => _tcs.Task;

        public Receiver()
        {
            _tcs = new TaskCompletionSource(TaskCreationOptions.RunContinuationsAsynchronously);
        }

        public void Receive(ReadOnlySpan<byte> payload)
        {
            _tcs.SetResult();
        }

        public void Fault(Exception exception)
        {
            _tcs.SetException(exception);
        }
    }

    private Task WaitForResponseAsync(ushort sequenceNumber)
    {
        lock (_lock)
        {
            if (closed)
            {
                throw new FibreChannelException(new Exception("Closed"));
            }

            //Console.WriteLine($"Adding waiter for {sequenceNumber}");
            var receiver = new Receiver();

            if (!_pendingMessages.TryAdd(sequenceNumber, receiver))
            {
                throw new InvalidOperationException(
                    $"Could not add receiver for seq {sequenceNumber} because there is already a receiver for that seq");
            }
            //Console.WriteLine($"Added waiter for {sequenceNumber}");
            return receiver.Task;
        }

    }

    private Task<T> WaitForResponseAsync<T>(ushort sequenceNumber, ByteSpanConvertFunc<T> responseConvertFunc)
    {
        lock (_lock)
        {
            if (closed)
            {
                throw new FibreChannelException(new Exception("Closed"));
            }

            //Console.WriteLine($"Adding waiter<{typeof(T).Name}> for {sequenceNumber}");
            var receiver = new Receiver<T>(responseConvertFunc);
            if (!_pendingMessages.TryAdd(sequenceNumber, receiver))
            {
                throw new InvalidOperationException(
                    $"Could not add receiver for seq {sequenceNumber} because there is already a receiver for that seq");
            }

            //Console.WriteLine($"Added waiter for {sequenceNumber}");
            return receiver.Task;
        }
    }

    public void Start()
    {
        _ = Task.Run(ReceiveLoop);
    }

    private async Task ReceiveLoop()
    {
        //Console.WriteLine($"In {nameof(ReceiveLoop)}");
        while (true)
        {
            var buffer = _arrayPool.Rent(BufferSize);
            try
            {
                //Console.WriteLine("Waiting to receive");
                int len;
                try
                {
                    len = await _packetTransport.ReceivePacketAsync(buffer, 0, buffer.Length);
                }
                catch (Exception ex)
                {
                    lock (_lock)
                    {
                        closed = true;
                        foreach (var (_, receiver) in _pendingMessages)
                        {
                            receiver.Fault(new FibreChannelException(ex));
                        }
                    }

                    return;
                }

                //Console.WriteLine("Receiving");

                var sequenceNumber = (ushort)(BitConverter.ToUInt16(buffer.AsSpan(0, 2)) & 0x7FFF);


                bool waiterExists;
                IReceiver? waiter;
                lock (_lock)
                {
                    waiterExists = _pendingMessages.TryRemove(sequenceNumber, out waiter);
                }

                if (waiterExists)
                {
                    //Console.WriteLine($"Waking waiter");
                    waiter!.Receive(buffer.AsSpan(2, len - 2));
                    //Console.WriteLine("Returned from waiter");
                }
                else
                {
                    //Console.WriteLine("No waiters");
                }
            }
            finally

            {
                _arrayPool.Return(buffer);
            }
        }
    }
}

public class FibreChannelException : Exception
{
    public FibreChannelException(Exception innerException) : base("Channel closed", innerException) { }
}