using System.Collections.Immutable;
using FibreSharp.LegacyManifestParser;

namespace FibreSharp.HighLevel;

public static class HighLevelHelper
{
    public static ICallInvoker GetCaller(ILegacyFibreClient comm, string path)
    {
        var endpoint = comm.Manifest.ResolvePath(path);
        if (endpoint is not FunctionEndpoint functionEndpoint)
        {
            return new MissingEndpointCallInvoker();
        }

        return new CallInvoker(comm, functionEndpoint);
    }

    public static IReadWriteScalarAccessor<T> GetAccessor<T>(ILegacyFibreClient comm, string path)
    {
        var endpoint = comm.Manifest.ResolvePath(path);
        if (endpoint is not ScalarEndpoint scalarEndpoint)
        {
            return new MissingEndpointScalarAccessor<T>();
        }

        return GetAccessor<T>(comm, scalarEndpoint);
    }

    private static IReadWriteScalarAccessor<T> GetAccessor<T>(ILegacyFibreClient comm, ScalarEndpoint scalarEndpoint)
    {
        if (Factories.TryGetValue(typeof(T), out var factory))
        {
            return (IReadWriteScalarAccessor<T>)factory.Create(comm, scalarEndpoint);
        }

        return new MissingEndpointScalarAccessor<T>();
    }

    private static readonly ImmutableDictionary<Type, IAccessorFactory> Factories =
        new[]
        {
            CreateAccessorFactory((comm, endpoint) => new SingleScalarAccessor(comm, endpoint)),
            CreateAccessorFactory((comm, endpoint) => new UInt8ScalarAccessor(comm, endpoint)),
            CreateAccessorFactory((comm, endpoint) => new UInt32ScalarAccessor(comm, endpoint)),
            CreateAccessorFactory((comm, endpoint) => new UInt64ScalarAccessor(comm, endpoint)),
            CreateAccessorFactory((comm, endpoint) => new Int64ScalarAccessor(comm, endpoint)),
            CreateAccessorFactory((comm, endpoint) => new BooleanScalarAccessor(comm, endpoint))
        }.ToImmutableDictionary(x => x.Type);

    private interface IAccessorFactory
    {
        Type Type { get; }
        IScalarAccessor Create(ILegacyFibreClient comm, ScalarEndpoint endpoint);
    }

    private class AccessorFactory<T> : IAccessorFactory
    {
        private readonly Func<ILegacyFibreClient, ScalarEndpoint, IReadWriteScalarAccessor<T>> createFunc;

        public AccessorFactory(Func<ILegacyFibreClient, ScalarEndpoint, IReadWriteScalarAccessor<T>> createFunc)
        {
            this.createFunc = createFunc;
        }

        public Type Type => typeof(T);
        public IScalarAccessor Create(ILegacyFibreClient comm, ScalarEndpoint endpoint)
        {
            return createFunc(comm, endpoint);
        }
    }

    private static IAccessorFactory CreateAccessorFactory<T>(
        Func<ILegacyFibreClient, ScalarEndpoint, IReadWriteScalarAccessor<T>> createFunc)
    {
        return new AccessorFactory<T>(createFunc);
    }
}