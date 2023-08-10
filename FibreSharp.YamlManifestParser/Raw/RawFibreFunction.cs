namespace FibreSharp.YamlManifestParser.Raw;

internal class RawFibreFunction : RawFibreMember
{
    public Dictionary<string, StringOrObject<RawFibreType>>? In { get; init; }
    public Dictionary<string, StringOrObject<RawFibreType>>? Out { get; init; }
}