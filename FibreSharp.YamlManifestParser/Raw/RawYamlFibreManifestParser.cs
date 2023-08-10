using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace FibreSharp.YamlManifestParser.Raw;

internal static class RawYamlFibreManifestParser
{
    public static RawFibreYamlManifest Parse(TextReader file)
    {
        return Deserializer.Deserialize<RawFibreYamlManifest>(file);
    }

    public static IDeserializer Deserializer { get; } = new DeserializerBuilder()
        .WithNamingConvention(UnderscoredNamingConvention.Instance)
        .IgnoreUnmatchedProperties()
        .WithTypeConverter(new StringOrObjectConverter<RawFibreAttribute>())
        .WithTypeConverter(new StringOrObjectConverter<RawFibreType>())
        .WithTypeConverter(new OrderedMappingTypeConverter<RawFibreValueTypeFlag>())
        .WithTypeConverter(new OrderedMappingTypeConverter<RawFibreValueTypeValue>())
        .Build();
}