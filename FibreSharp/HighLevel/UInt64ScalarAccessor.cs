using FibreSharp.LegacyManifestParser;

namespace FibreSharp.HighLevel;

public class UInt64ScalarAccessor : ScalarAccessorBase<ulong>
{
    public UInt64ScalarAccessor(ILegacyFibreClient comm, ScalarEndpoint endpoint)
        : base(comm, endpoint)
    {
    }

    protected override async Task SetAsyncCore(ulong value)
    {
        await Comm.WriteUInt64(Endpoint.Id, value);
    }

    protected override async Task<ulong> GetAsyncCore()
    {
        return await Comm.ReadUInt64(Endpoint.Id);
    }
}