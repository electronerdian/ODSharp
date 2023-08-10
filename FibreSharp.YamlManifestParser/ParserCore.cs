using System;
using System.Collections.Immutable;
using FibreSharp.YamlManifestParser.Raw;
using YamlDotNet.Core.Tokens;

namespace FibreSharp.YamlManifestParser;

internal class ParserCore
{
    private static readonly IImmutableDictionary<QualifiedName, PrimitiveFibreType> PrimitiveTypes =
        ImmutableDictionary.CreateRange(
            new[] { "int8", "uint8", "int16", "uint16", "int32", "uint32", "int64", "uint64", "float32", "float64", "bool", "endpoint_ref" }
                .Select(x => new QualifiedName(x))
                .Select(x => KeyValuePair.Create(x, new PrimitiveFibreType(x))));

    private readonly HashSet<QualifiedName> _startedTypes = new();
    private readonly Dictionary<QualifiedName, FibreType> _knownTypes = new();
    private readonly RawFibreYamlManifest _raw;

    public ParserCore(RawFibreYamlManifest raw)
    {
        _raw = raw;
    }

    public IReadOnlyDictionary<QualifiedName, FibreType> ParseCore()
    {
        foreach (var type in _raw.Interfaces.Keys.Concat(_raw.Valuetypes.Keys))
        {
            GetType(QualifiedName.Parse(type), QualifiedName.Root);
        }

        return _knownTypes;
    }

    private FibreType GetType(QualifiedName name, QualifiedName namespaceContext)
    {

        foreach (var ns in namespaceContext.EnumerateSelfAndAncestors())
        {
            var fqname = ns / name;
            var fqnameString = fqname.ToString();
            Console.WriteLine($"{name} -- {namespaceContext} -- {ns} -- {fqnameString}");

            if (_knownTypes.TryGetValue(fqname, out var type))
            {
                return type;
            }

            if (_startedTypes.Contains(fqname))
            {
                throw new InvalidOperationException($"Circular dependency involving {fqname}");
            }

            if (_raw.Interfaces.TryGetValue(fqnameString, out var interfaceType))
            {
                _startedTypes.Add(fqname);
                return ParseFibreType(fqname, interfaceType);
            }

            if (_raw.Valuetypes.TryGetValue(fqnameString, out var valueType))
            {
                _startedTypes.Add(fqname);
                return ParseFibreValueType(fqname, valueType);
            }
        }

        if (PrimitiveTypes.TryGetValue(name, out var primitiveType))
        {
            _knownTypes.Add(name, primitiveType);
            return primitiveType;
        }

        throw new Exception($"Unknown type {name}");
    }

    private PrimitiveFibreType MakePrimitiveFibreType(QualifiedName name)
    {
        var newType =  new PrimitiveFibreType(name);
        _knownTypes.Add(name, newType);
        return newType;
    }

    private FibreType ParseFibreValueType(QualifiedName name, RawFibreValueType valueType)
    {
        if (valueType.Flags is not null)
        {
            if (valueType.Values is not null)
            {
                throw new Exception("value type can have flags or values but not both");
            }

            var values = ImmutableArray.CreateBuilder<EnumValue>(
                valueType.NullFlag is null ? valueType.Flags.Count : valueType.Flags.Count + 1);

            if (valueType.NullFlag is not null)
            {
                values.Add(new EnumValue(name / valueType.NullFlag, null, null, 0));
            }

            var bit = 0;
            foreach (var (valueName, valueObj) in valueType.Flags)
            {
                if (valueObj?.Bit is not null)
                {
                    bit = valueObj.Bit.Value;
                }

                values.Add(new EnumValue(name / valueName, valueObj?.Brief, valueObj?.Doc, 1 << bit));
                ++bit;
            }

            return MakeEnumFibreType(name, valueType.Brief, valueType.Doc, true, values.MoveToImmutable());
        }

        if (valueType.Values is not null)
        {
            if (valueType.Flags is not null || valueType.NullFlag is not null)
            {
                throw new Exception("Cannot have both flags and values in value type");
            }

            var values = ImmutableArray.CreateBuilder<EnumValue>(valueType.Values.Count);

            var num = 0;
            foreach (var (valueName, valueObj) in valueType.Values)
            {
                if (valueObj?.Value is not null)
                {
                    num = valueObj.Value.Value;
                }

                values.Add(new EnumValue(name / valueName, valueObj?.Brief, valueObj?.Doc, num));
                ++num;
            }

            return MakeEnumFibreType(name, valueType.Brief, valueType.Doc, true, values.MoveToImmutable());
        }

        throw new Exception("value type with no values or flags?");
    }

    private  EnumFibreType MakeEnumFibreType(
        QualifiedName name,
        string? brief,
        string? doc,
        bool isFlag,
        IImmutableList<EnumValue> values)
    {
        var newType = new EnumFibreType(name, brief, doc, isFlag, values);
        _knownTypes.Add(name, newType);
        return newType;
    }

    private ComplexFibreType ParseFibreType(QualifiedName name, RawFibreType rawType)
    {
        var attributes = rawType.Attributes
            ?.Select(pair =>
            {
                string attributeName = pair.Key;
                return ParseAttribute(pair.Value, name / attributeName);
            })
            .ToImmutableArray();
        
        var functions = rawType.Functions
            ?.Select(pair =>
            {
                string functionName = pair.Key;
                return ParseFunction(name / functionName, pair.Value);
            })
            .ToImmutableArray();

        return MakeComplexFibreType(
            name,
            rawType.Brief,
            rawType.Doc,
            attributes ?? ImmutableArray<FibreAttribute>.Empty,
            functions ?? ImmutableArray<FibreFunction>.Empty);
    }

    private ComplexFibreType MakeComplexFibreType(
        QualifiedName name,
        string? brief,
        string? doc,
        IImmutableList<FibreAttribute> attributes,
        IImmutableList<FibreFunction> functions)
    {
        var newType = new ComplexFibreType(
            name,
            brief,
            doc,
            attributes,
            functions);
        _knownTypes.Add(name, newType);
        return newType;
    }

    private (bool IsReadonly, FibreType Type) ParseFibreTypeString(string name, QualifiedName namespaceContext)
    {
        var parts = name.Split(' ');

        return parts.Length switch
        {
            1 => (false, GetType(QualifiedName.Parse(parts[0]), namespaceContext)),
            2 when parts[0] != "readonly" => throw new Exception("expected first word of type string to be 'readonly'"),
            2 => (true, GetType(QualifiedName.Parse(parts[1]), namespaceContext)),
            _ => throw new Exception("too many words in type string")
        };
    }

    private (bool IsReadonly, FibreType Type) ParseFibreTypeStringOrObject(
        QualifiedName nameIfNew,
        StringOrObject<RawFibreType> rawType)
    {
        return rawType switch
        {
            StringOrObject<RawFibreType>.Object(var obj) => (false, ParseFibreType(nameIfNew, obj)),
            StringOrObject<RawFibreType>.String(var str) => ParseFibreTypeString(str, nameIfNew.Parent),
            _ => throw new Exception("?!?")
        };
    }
    private FibreFunction ParseFunction(QualifiedName name, RawFibreFunction? rawFunction)
    {
        if (rawFunction is null)
        {
            return new FibreFunction(
                name,
                null,
                null,
                ImmutableArray<FibreFunctionParameter>.Empty,
                ImmutableArray<FibreFunctionParameter>.Empty);
        }

        var inParams = rawFunction.In
            ?.Select(
                x => new FibreFunctionParameter(
                    x.Key,
                    ParseFibreTypeStringOrObject(name / $"in_{x.Key}", x.Value).Type))
            .ToImmutableArray();

        var outParams = rawFunction.In
            ?.Select(
                x => new FibreFunctionParameter(
                    x.Key,
                    ParseFibreTypeStringOrObject(name / $"out_{x.Key}", x.Value).Type))
            .ToImmutableArray();

        return new FibreFunction(
            name,
            rawFunction.Brief,
            rawFunction.Doc,
            inParams ?? ImmutableArray<FibreFunctionParameter>.Empty,
            outParams ?? ImmutableArray<FibreFunctionParameter>.Empty);
    }

    private FibreAttribute ParseAttribute(StringOrObject<RawFibreAttribute> rawAttribute, QualifiedName name)
    {
        switch (rawAttribute)
        {
            case StringOrObject<RawFibreAttribute>.String(var str):
            {
                var (isReadonly, attrType) = ParseFibreTypeString(str, name.Parent);
                return new FibreAttribute(name, null, null, attrType, isReadonly);
            }

            case StringOrObject<RawFibreAttribute>.Object(var obj):
            {
                if (obj.Type is not null)
                {
                    if (obj.Attributes is not null || obj.Functions is not null)
                    {
                        throw new Exception("Cant have both type and attributes/functions in attribute");
                    }

                    var (isReadonly, attrType) = ParseFibreTypeStringOrObject(
                        name,
                        obj.Type);
                    return new FibreAttribute(name, obj.Brief, obj.Doc, attrType, isReadonly);
                }
                else
                {
                    return new FibreAttribute(
                        name,
                        obj.Brief,
                        obj.Doc,
                        ParseFibreType(name, obj),
                        false);
                }
            }

            default:
                throw new Exception("Unexpected!");
        }
    }
}