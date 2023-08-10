using JetBrains.Annotations;

namespace FibreSharp.YamlManifestParser.Raw;

[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
internal class RawFibreType : RawFibreMember
{
    public bool? CIsClass { get; init; }
    public Dictionary<string, StringOrObject<RawFibreAttribute>>? Attributes { get; init; }
    public Dictionary<string, RawFibreFunction?>? Functions { get; init; }
}