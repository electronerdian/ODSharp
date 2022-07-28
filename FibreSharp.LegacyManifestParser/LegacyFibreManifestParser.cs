using System.Collections.Immutable;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using JetBrains.Annotations;

namespace FibreSharp.LegacyManifestParser;

public class LegacyFibreManifestParser
{
    public static ObjectEndpoint Parse(ReadOnlySpan<byte> manifestBytes)
    {
        var endpoints = JsonSerializer.Deserialize<RawEndpoint[]>(manifestBytes)!;

        return BuildRootEndpoint(endpoints);
    }
    
    public static ObjectEndpoint Parse(ReadOnlySpan<char> manifestString)
    {
        var endpoints = JsonSerializer.Deserialize<RawEndpoint[]>(manifestString)!;
        
        return BuildRootEndpoint(endpoints);
    }

    private static ObjectEndpoint BuildRootEndpoint(IReadOnlyList<RawEndpoint> endpoints)
    {
        return BuildObjectEndpoint("", ImmutableList<string>.Empty, endpoints);
    }

    [UsedImplicitly]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "<Pending>")]
    private record RawEndpoint(
        string name,
        ushort id,
        string type,
        string access,
        IReadOnlyList<RawEndpoint> members,
        IReadOnlyList<RawEndpoint> inputs,
        IReadOnlyList<RawEndpoint> outputs);
    
    private static FunctionEndpoint BuildFunctionEndpoint(RawEndpoint raw, IImmutableList<string> parentPath)
    {
        var thisPath = parentPath.Add(raw.name);

        return new FunctionEndpoint(raw.name,
            BuildQualifiedName(thisPath),
            raw.id,
            raw.inputs.Select(x => BuildScalarEndpoint(x, thisPath, Access.Write)).ToImmutableArray(),
            raw.outputs.Select(x => BuildScalarEndpoint(x, thisPath, Access.Read)).ToImmutableArray());
    }

    private static string BuildQualifiedName(IImmutableList<string> thisPath)
    {
        return string.Join(".", thisPath);
    }

    private static ScalarEndpoint BuildScalarEndpoint(RawEndpoint raw, IImmutableList<string> parentPath, Access? accessOverride = default)
    {
        if (raw.type is "function" or "object")
        {
            throw new InvalidOperationException();
        }

        var thisPath = parentPath.Add(raw.name);

        return new ScalarEndpoint(
            raw.name,
            BuildQualifiedName(thisPath),
            raw.id,
            DetermineType(raw.type),
            accessOverride ?? DetermineAccess(raw.access));
    }

    private static ObjectEndpoint BuildObjectEndpoint(
        RawEndpoint raw,
        IImmutableList<string> parentPath)
    {
        return BuildObjectEndpoint(raw.name, parentPath.Add(raw.name), raw.members);
    }

    private static ObjectEndpoint BuildObjectEndpoint(
        string name,
        IImmutableList<string> thisPath,
        IReadOnlyList<RawEndpoint> members)
    {
        // two passes to avoid extra allocations
        var scalarCount = 0;
        var functionCount = 0;
        var objectCount = 0;
        foreach (var member in members)
        {
            switch (member.type)
            {
                case "function":
                    functionCount++;
                    break;

                case "object":
                    objectCount++;
                    break;

                default:
                    scalarCount++;
                    break;
            }
        }

        var scalarBuilder = ImmutableArray.CreateBuilder<ScalarEndpoint>(scalarCount);
        var functionBuilder = ImmutableArray.CreateBuilder<FunctionEndpoint>(functionCount);
        var objectBuilder = ImmutableArray.CreateBuilder<ObjectEndpoint>(objectCount);

        foreach (var member in members)
        {
            switch (member.type)
            {
                case "function":
                    functionBuilder.Add(BuildFunctionEndpoint(member, thisPath));
                    break;

                case "object":
                    objectBuilder.Add(BuildObjectEndpoint(member, thisPath));
                    break;

                default:
                    scalarBuilder.Add(BuildScalarEndpoint(member, thisPath));
                    break;
            }
        }


        return new ObjectEndpoint(
            name,
            BuildQualifiedName(thisPath),
            scalarBuilder.ToImmutable(),
            functionBuilder.ToImmutable(),
            objectBuilder.ToImmutable());
    }

    private static Access DetermineAccess(string rawAccess) =>
        rawAccess switch
        {
            "r" => Access.Read,
            "w" => Access.Write,
            "rw" => Access.Read | Access.Write,
            _ => throw new ArgumentOutOfRangeException(nameof(rawAccess), rawAccess, null)
        };

    private static Type DetermineType(string rawType) =>
        rawType switch
        {
            "bool" => typeof(bool),
            "int8" => typeof(sbyte),
            "uint8" => typeof(byte),
            "int16" => typeof(short),
            "uint16" => typeof(ushort),
            "int32" => typeof(int),
            "uint32" => typeof(uint),
            "int64" => typeof(long),
            "uint64" => typeof(ulong),
            "float" => typeof(float),
            "double" => typeof(double),
            "json" => typeof(object),
            "endpoint_ref" => typeof(EndpointRef),
            _ => throw new ArgumentOutOfRangeException(nameof(rawType), rawType, null)
        };
}