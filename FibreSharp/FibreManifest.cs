using FibreSharp.LegacyManifestParser;

namespace FibreSharp;

public class FibreManifest
{
    public ReadOnlyMemory<byte> Bytes { get; }
    public ushort Crc { get; }
    public ObjectEndpoint Root { get; }

    public FibreManifest(ReadOnlyMemory<byte> bytes, ushort crc, ObjectEndpoint root)
    {
        Bytes = bytes;
        Crc = crc;
        Root = root;
    }

    public Endpoint? ResolvePath(string path)
    {
        var parts = path.Split(".");
        Endpoint currentNode = Root;

        foreach (var part in parts)
        {
            var candidates = currentNode switch
            {
                ObjectEndpoint obj => obj.AllMembers,
                FunctionEndpoint func => func.Inputs.Concat(func.Outputs),
                _ => Array.Empty<Endpoint>(),
            };

            var nextNode = candidates.FirstOrDefault(x => x.Name == part);
            if (nextNode is null)
            {
                return null;
            }

            currentNode = nextNode;
        }

        return currentNode;
    }
}