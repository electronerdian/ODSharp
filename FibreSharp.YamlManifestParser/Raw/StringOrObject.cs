namespace FibreSharp.YamlManifestParser.Raw;

internal abstract record StringOrObject<T>
{
    private StringOrObject() { }

    public record String(string StringValue) : StringOrObject<T>;
    public record Object(T objectValue) : StringOrObject<T>;
}