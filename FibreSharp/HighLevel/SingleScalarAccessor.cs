using FibreSharp.LegacyManifestParser;

namespace FibreSharp.HighLevel;

public class SingleScalarAccessor: ScalarAccessorBase<float>
{
    public SingleScalarAccessor(ILegacyFibreClient comm, ScalarEndpoint endpoint)
    :base(comm, endpoint)
    {
    }

    protected override async Task SetAsyncCore(float value)
    {
        await Comm.WriteFloat(Endpoint.Id, value);
    }

    protected override async Task<float> GetAsyncCore()
    {
        return await Comm.ReadFloat(Endpoint.Id);
    }
}