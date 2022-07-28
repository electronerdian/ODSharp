namespace FibreSharp;

public interface ILegacyFibreClient
{
    FibreManifest Manifest { get; }
    
    Task<float> ReadFloat(ushort endpoint);
    Task<float> WriteFloat(ushort endpoint, float value);

    Task<byte> WriteUInt8(ushort endpoint, byte value);
    Task<byte> ReadUInt8(ushort endpoint);

    Task<ulong> WriteUInt64(ushort endpoint, ulong value);
    Task<ulong> ReadUInt64(ushort endpoint);

    Task<long> WriteInt64(ushort endpoint, long value);
    Task<long> ReadInt64(ushort endpoint);

    Task<uint> WriteUInt32(ushort endpoint, uint value);
    Task<uint> ReadUInt32(ushort endpoint);

    Task<bool> WriteBoolean(ushort endpoint, bool value);
    Task<bool> ReadBoolean(ushort endpoint);

    Task CallAsync(ushort endpoint);
}