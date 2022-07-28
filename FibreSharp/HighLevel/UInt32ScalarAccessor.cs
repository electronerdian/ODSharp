using FibreSharp.LegacyManifestParser;

namespace FibreSharp.HighLevel;

public class UInt32ScalarAccessor: ScalarAccessorBase<uint>
{
    public UInt32ScalarAccessor(ILegacyFibreClient comm, ScalarEndpoint endpoint)
        : base(comm, endpoint)
    {
    }

    protected override async Task SetAsyncCore(uint value)
    {
        await Comm.WriteUInt32(Endpoint.Id, value);
    }

    protected override async Task<uint> GetAsyncCore()
    {
        return await Comm.ReadUInt32(Endpoint.Id);
    }
}