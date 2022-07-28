using FibreSharp.LegacyManifestParser;

namespace FibreSharp.HighLevel;

public class UInt8ScalarAccessor : ScalarAccessorBase<byte>
{
    public UInt8ScalarAccessor(ILegacyFibreClient comm, ScalarEndpoint endpoint)
        : base(comm, endpoint)
    {
    }

    protected override async Task SetAsyncCore(byte value)
    {
        await Comm.WriteUInt8(Endpoint.Id, value);
    }

    protected override async Task<byte> GetAsyncCore()
    {
        return await Comm.ReadUInt8(Endpoint.Id);
    }
}