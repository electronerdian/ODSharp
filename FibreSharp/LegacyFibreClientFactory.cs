using Crc;
using FibreSharp.LegacyManifestParser;

namespace FibreSharp;

public class LegacyFibreClientFactory
{
    private static Crc16Base Crc16() => new(
        polynomial: 0x3d65,
        initialValue: 0x0001,
        finalXorValue: 0,
        reflectInput: false,
        reflectOutput: false);

    public async Task<ILegacyFibreClient> Get(ILegacyFibreChannel lowLevel)
    {
        var manifestBytes = await GetManifestJsonBytes(lowLevel);
        var root = LegacyFibreManifestParser.Parse(manifestBytes);
        var manifestCrc = BitConverter.ToUInt16(Crc16().ComputeHash(manifestBytes));
        return new LegacyFibreClient(
            lowLevel,
            new FibreManifest(
                manifestBytes,
                manifestCrc,
                root));
    }


    private static async Task<byte[]> GetManifestJsonBytes(ILegacyFibreChannel lowLevel)
    {
        var parts = new List<byte[]>();
        var offset = 0;
        while (true)
        {
            var part = await GetManifestJsonPart(lowLevel, offset);
            if (part.Length == 0)
            {
                break;
            }

            parts.Add(part);
            offset += part.Length;
        }

        var bytes = new byte[offset];
        offset = 0;
        foreach (var part in parts)
        {
            part.CopyTo(bytes, offset);
            offset += part.Length;
        }

        return bytes;
    }

    private static async Task<byte[]> GetManifestJsonPart(ILegacyFibreChannel channel, int offset)
    {
        return await channel.SendAndReceiveAsync(
            endpointId: 0,
            crc: 1,
            payloadLength: 4,
            (span, v) => BitConverter.TryWriteBytes(span, v),
            offset,
            responseLength: 127,
            span => span.ToArray());
    }

}