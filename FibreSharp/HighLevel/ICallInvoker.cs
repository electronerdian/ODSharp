using FibreSharp.LegacyManifestParser;

namespace FibreSharp.HighLevel;

public interface ICallInvoker
{
    FunctionEndpoint Endpoint { get; }
    Task CallAsync();
}