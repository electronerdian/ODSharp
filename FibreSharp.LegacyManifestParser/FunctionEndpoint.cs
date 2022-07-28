using System.Collections.Immutable;

namespace FibreSharp.LegacyManifestParser;

public record FunctionEndpoint(
    string Name,
    string QualifiedName,
    ushort Id,
    IImmutableList<ScalarEndpoint> Inputs,
    IImmutableList<ScalarEndpoint> Outputs) 
    : Endpoint(Name, QualifiedName);