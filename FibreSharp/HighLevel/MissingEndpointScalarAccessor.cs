using FibreSharp.LegacyManifestParser;

namespace FibreSharp.HighLevel;

public class MissingEndpointScalarAccessor<T> : IReadWriteScalarAccessor<T>
{
    public ScalarEndpoint Endpoint => throw new NotImplementedException();

    public T Value
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public Task SetAsync(T value)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetAsync()
    {
        throw new NotImplementedException();
    }
}