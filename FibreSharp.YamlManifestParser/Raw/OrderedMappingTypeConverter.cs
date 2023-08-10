using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;

namespace FibreSharp.YamlManifestParser.Raw;

internal class OrderedMappingTypeConverter<T> : IYamlTypeConverter
{
    public bool Accepts(Type type)
    {
        return type.IsAssignableFrom(typeof(List<KeyValuePair<string, T>>));
    }

    public object? ReadYaml(IParser parser, Type type)
    {
        parser.Consume<MappingStart>();

        var list = new List<KeyValuePair<string, T>>();
        while (!parser.TryConsume<MappingEnd>(out _))
        {
            var key = parser.Consume<Scalar>();
            var value = RawYamlFibreManifestParser.Deserializer.Deserialize<T>(parser);
            list.Add(KeyValuePair.Create(key.Value, value));
        }

        return list;
    }

    public void WriteYaml(IEmitter emitter, object? value, Type type)
    {
        throw new NotImplementedException();
    }
}