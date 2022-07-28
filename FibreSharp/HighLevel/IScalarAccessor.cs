using FibreSharp.LegacyManifestParser;

namespace FibreSharp.HighLevel;

public interface IScalarAccessor
{
    ScalarEndpoint Endpoint { get; }
}