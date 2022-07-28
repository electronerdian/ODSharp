using System.Buffers;
using System.Runtime.InteropServices;

namespace FibreSharp;

public class LegacyFibreClient : ILegacyFibreClient
{
    public FibreManifest Manifest { get; }

    public LegacyFibreClient(ILegacyFibreChannel lowLevelComm, FibreManifest manifest)
    {
        Manifest = manifest;
        _lowLevel = lowLevelComm;
    }


    public async Task<float> ReadFloat(ushort endpoint)
    {
        return await ReadAsync(endpoint, BitConverter.ToSingle);
    }
    
    /// <summary>Write a float to the ODrive</summary>
    /// <returns>The old value</returns>
    public async Task<float> WriteFloat(ushort endpoint, float value)
    {
        return await WriteAsync(
            endpoint,
            value,
            static (span, v) => BitConverter.TryWriteBytes(span, v),
            static (span) => BitConverter.ToSingle(span));
    }
    public async Task<byte> WriteUInt8(ushort endpoint, byte value)
    {
        return await WriteAsync(
            endpoint,
            value,
            static (span, v) => span[0] = v,
            static (span) => span[0]);
    }

    public async Task<byte> ReadUInt8(ushort endpoint)
    {
        return await ReadAsync(endpoint, span => span[0]);
    }

    public async Task<uint> WriteUInt32(ushort endpoint, uint value)
    {
        return await WriteAsync(
            endpoint,
            value,
            static (span, v) => BitConverter.TryWriteBytes(span, v),
            static (span) => BitConverter.ToUInt32(span));
    }

    public async Task<uint> ReadUInt32(ushort endpoint)
    {
        return await ReadAsync(endpoint, BitConverter.ToUInt32);
    }

    public async Task<bool> WriteBoolean(ushort endpoint, bool value)
    {
        var result = await WriteUInt8(endpoint, (byte)(value ? 1 : 0));
        return result != 0;
    }

    public async Task<bool> ReadBoolean(ushort endpoint)
    {
        var result = await ReadUInt8(endpoint);
        return result != 0;
    }

    public async Task CallAsync(ushort endpoint)
    {
        await _lowLevel.SendAndWaitAsync(endpoint, Manifest.Crc);
    }

    public async Task<ulong> WriteUInt64(ushort endpoint, ulong value)
    {
        return await WriteAsync(
            endpoint,
            value,
            static (span, v) => BitConverter.TryWriteBytes(span, v),
            static (span) => BitConverter.ToUInt64(span));
    }

    public async Task<ulong> ReadUInt64(ushort endpoint)
    {
        return await ReadAsync(endpoint, BitConverter.ToUInt64);
    }


    public async Task<long> WriteInt64(ushort endpoint, long value)
    {
        return await WriteAsync(
            endpoint,
            value,
            static (span, v) => BitConverter.TryWriteBytes(span, v),
            static (span) => BitConverter.ToInt64(span));
    }


    public async Task<long> ReadInt64(ushort endpoint)
    {
        return await ReadAsync(endpoint, BitConverter.ToInt64);
    }


    private readonly ILegacyFibreChannel _lowLevel;

    private async Task<T> ReadAsync<T>(ushort endpoint, ByteSpanConvertFunc<T> responseConvertFunc)
        where T : unmanaged
    {
        return await _lowLevel.SendAndReceiveAsync(
            endpoint,
            Manifest.Crc,
            responseLength: (ushort)Marshal.SizeOf<T>(),
            responseConvertFunc);
    }


    private async Task<T> WriteAsync<T>(
        ushort endpoint,
        T value,
        SpanAction<byte, T> payloadAction,
        ByteSpanConvertFunc<T> byteSpanConvertFunc)
        where T : unmanaged
    {
        return await _lowLevel.SendAndReceiveAsync(
            endpoint,
            Manifest.Crc,
            (ushort)Marshal.SizeOf<T>(),
            payloadAction,
            value,
            (ushort)Marshal.SizeOf<T>(),
            byteSpanConvertFunc);
    }
}