#nullable enable

using System.Collections.Immutable;
using System;
using System.Data;
using FibreSharp.YamlManifestParser.Raw;

namespace FibreSharp.YamlManifestParser;

public class YamlFibreManifestParser
{
    public IReadOnlyDictionary<QualifiedName, FibreType> Parse(TextReader file)
    {
        var raw = RawYamlFibreManifestParser.Parse(file);

        return new ParserCore(raw).ParseCore();
    }
}

public interface IDocumentedElement
{
    QualifiedName Name { get; }
    string? Brief { get; }
    string? Doc { get; }
}

public abstract record FibreType(QualifiedName Name);

public record PrimitiveFibreType(QualifiedName Name) : FibreType(Name);

public record ComplexFibreType(
        QualifiedName Name,
    string? Brief,
    string? Doc,
    IImmutableList<FibreAttribute> Attributes,
    IImmutableList<FibreFunction> Functions)
    : FibreType(Name), IDocumentedElement;

public record EnumFibreType(
        QualifiedName Name,
    string? Brief,
    string? Doc,
    bool IsFlag,
    IImmutableList<EnumValue> Values)
    : FibreType(Name), IDocumentedElement;

public record FibreAttribute(
        QualifiedName Name,
    string? Brief,
    string? Doc,
    FibreType Type,
    bool IsReadonly)
    : IDocumentedElement;

public record FibreFunction(
        QualifiedName Name,
    string? Brief,
    string? Doc,
    IImmutableList<FibreFunctionParameter> In,
    IImmutableList<FibreFunctionParameter> Out)
    : IDocumentedElement;

public record FibreFunctionParameter(string Name, FibreType Type);
public record EnumValue(
        QualifiedName Name, 
    string? Brief,
    string? Doc, 
    int Value) 
    : IDocumentedElement;