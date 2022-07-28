using System.Buffers;

namespace FibreSharp;

public interface ILegacyFibreChannel
{
    Task SendAndWaitAsync(
        ushort endpointId,
        ushort crc);

    Task SendAndWaitAsync<TPayloadArg>(
        ushort endpointId,
        ushort crc,
        ushort payloadLength,
        SpanAction<byte, TPayloadArg> payloadAction,
        TPayloadArg payloadArg);

    Task<TResult> SendAndReceiveAsync<TResult>(
        ushort endpointId,
        ushort crc,
        ushort responseLength,
        ByteSpanConvertFunc<TResult> responseConvertFunc);

    Task<TResult> SendAndReceiveAsync<TResult, TPayloadArg>(
        ushort endpointId,
        ushort crc,
        ushort payloadLength,
        SpanAction<byte, TPayloadArg> payloadAction,
        TPayloadArg payloadArg,
        ushort responseLength,
        ByteSpanConvertFunc<TResult> responseConvertFunc);

    Task SendAndForgetAsync<TPayloadArg>(
        ushort endpointId,
        ushort crc,
        ushort payloadLength,
        SpanAction<byte, TPayloadArg> payloadAction,
        TPayloadArg payloadArg);

    Task SendAndForgetAsync(
        ushort endpointId,
        ushort crc);
}