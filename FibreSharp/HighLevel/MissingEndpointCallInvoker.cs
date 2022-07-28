using FibreSharp.LegacyManifestParser;

namespace FibreSharp.HighLevel;

public class MissingEndpointCallInvoker : ICallInvoker
{
    public FunctionEndpoint Endpoint => throw new NotImplementedException();
    public Task CallAsync()
    {
        throw new NotImplementedException();
    }
}