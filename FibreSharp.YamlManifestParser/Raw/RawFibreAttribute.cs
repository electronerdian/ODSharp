namespace FibreSharp.YamlManifestParser.Raw;

internal class RawFibreAttribute : RawFibreType
{
    public string? CGetter { get; init; }
    public string? Unit { get; init; }
    public StringOrObject<RawFibreType>? Type { get; init; }
}