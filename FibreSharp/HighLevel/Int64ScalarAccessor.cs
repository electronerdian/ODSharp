using FibreSharp.LegacyManifestParser;

namespace FibreSharp.HighLevel;

public class Int64ScalarAccessor : ScalarAccessorBase<long>
{
    public Int64ScalarAccessor(ILegacyFibreClient comm, ScalarEndpoint endpoint)
        : base(comm, endpoint)
    {
    }

    protected override async Task SetAsyncCore(long value)
    {
        await Comm.WriteInt64(Endpoint.Id, value);
    }

    protected override async Task<long> GetAsyncCore()
    {
        return await Comm.ReadInt64(Endpoint.Id);
    }
}