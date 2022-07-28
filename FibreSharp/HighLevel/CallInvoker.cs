using FibreSharp.LegacyManifestParser;

namespace FibreSharp.HighLevel;

public class CallInvoker : ICallInvoker
{
    private readonly ILegacyFibreClient _client;
    public FunctionEndpoint Endpoint { get; }

    public CallInvoker(ILegacyFibreClient client, FunctionEndpoint endpoint)
    {
        _client = client;
        Endpoint = endpoint;
    }

    public async Task CallAsync()
    {
        await _client.CallAsync(Endpoint.Id);
    }
}