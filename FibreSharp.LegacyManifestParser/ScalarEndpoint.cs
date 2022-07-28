namespace FibreSharp.LegacyManifestParser;

public record ScalarEndpoint(string Name, string QualifiedName, ushort Id, Type Type, Access Access) : Endpoint(Name, QualifiedName)
{
    public override string ToString()
    {
        return $"{nameof(ScalarEndpoint)}: {Type.Name} {Id} = {Name},  {Access})"; 
    }
}