namespace FibreSharp.YamlManifestParser.Raw;

internal class RawFibreValueType : RawFibreMember
{
    public List<KeyValuePair<string, RawFibreValueTypeValue>>? Values { get; init; }
    public Dictionary<string, RawFibreValueTypeFlag>? Flags { get; init; }
    public string? NullFlag { get; init; }
}