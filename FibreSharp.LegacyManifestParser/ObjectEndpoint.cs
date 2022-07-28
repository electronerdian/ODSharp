using System.Collections.Immutable;

namespace FibreSharp.LegacyManifestParser;

public record ObjectEndpoint(
        string Name,
        string QualifiedName,
        IImmutableList<ScalarEndpoint> Scalars,
        IImmutableList<FunctionEndpoint> Functions,
        IImmutableList<ObjectEndpoint> Objects)
    : Endpoint(Name, QualifiedName)
{
    public IEnumerable<Endpoint> AllMembers => ((IEnumerable<Endpoint>)Scalars).Concat(Functions).Concat(Objects);

    public Endpoint this[string name] => AllMembers.First(x => x.Name == name);
}