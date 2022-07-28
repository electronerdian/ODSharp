using FibreSharp.LegacyManifestParser;

namespace FibreSharp.HighLevel;

public abstract class ScalarAccessorBase<T> : IReadWriteScalarAccessor<T>
{
    protected readonly ILegacyFibreClient Comm;

    protected ScalarAccessorBase(ILegacyFibreClient comm, ScalarEndpoint endpoint)
    {
        this.Comm = comm;
        Endpoint = endpoint;

        if (endpoint.Type != typeof(T))
        {
            throw new ArgumentException(
                $"Cannot use {GetType().Name} to access endpoint of type {endpoint.Type.Name} (expected {typeof(T).Name}).");
        }
    }

    public T Value
    {
        get => GetAsync().GetAwaiter().GetResult();
        set => SetAsync(value).GetAwaiter().GetResult();
    }

    public ScalarEndpoint Endpoint { get; }

    public async Task SetAsync(T value)
    {
        if ((Endpoint.Access & Access.Write) == 0)
        {
            throw new InvalidOperationException($"Endpoint {Endpoint.QualifiedName} ({Endpoint.Id}) not writable");
        }

        await SetAsyncCore(value);
    }

    protected abstract Task SetAsyncCore(T value);

    public async Task<T> GetAsync()
    {
        if ((Endpoint.Access & Access.Read) == 0)
        {
            throw new InvalidOperationException($"Endpoint {Endpoint.QualifiedName} ({Endpoint.Id}) not readable");
        }

        return await GetAsyncCore();
    }

    protected abstract Task<T> GetAsyncCore();
}