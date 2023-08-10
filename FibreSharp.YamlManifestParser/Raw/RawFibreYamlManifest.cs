namespace FibreSharp.YamlManifestParser.Raw;

internal class RawFibreYamlManifest
{
    public Dictionary<string, RawFibreType> Interfaces { get; init; } = new();

    public Dictionary<string, RawFibreValueType> Valuetypes { get; init; } = new();
}