using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace FibreSharp.YamlManifestParser.Raw;

public class StringOrObjectConverter<T> : IYamlTypeConverter
{
    public bool Accepts(Type type)
    {
        return type == typeof(StringOrObject<T>);
    }

    public object? ReadYaml(IParser parser, Type type)
    {
        if (parser.TryConsume<Scalar>(out var scalar))
        {
            return new StringOrObject<T>.String(scalar.Value);
        }
        else
        {
            //parser.Current.Dump();
            return new StringOrObject<T>.Object(RawYamlFibreManifestParser.Deserializer.Deserialize<T>(parser));
        }
    }

    public void WriteYaml(IEmitter emitter, object? value, Type type)
    {
        throw new NotImplementedException();
    }
}