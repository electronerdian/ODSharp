using FibreSharp.LegacyManifestParser;

namespace FibreSharp.HighLevel;

public class BooleanScalarAccessor : ScalarAccessorBase<bool>
{
    public BooleanScalarAccessor(ILegacyFibreClient comm, ScalarEndpoint endpoint)
        : base(comm, endpoint)
    {
    }

    protected override async Task SetAsyncCore(bool value)
    {
        await Comm.WriteBoolean(Endpoint.Id, value);
    }

    protected override async Task<bool> GetAsyncCore()
    {
        return await Comm.ReadBoolean(Endpoint.Id);
    }
}