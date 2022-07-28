using System.Text;
using FibreSharp.LegacyManifestParser;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace ODSharp.GeneratorCore;

public static class GenerateAll
{
    public static SyntaxTree Generate(ObjectEndpoint parsedManifest, IReadOnlyDictionary<string, EnumInfo> enums)
    {

        var compilationUnitSyntax = SyntaxFactory.CompilationUnit()
            .AddMembers(
                SyntaxFactory.FileScopedNamespaceDeclaration(SyntaxFactory.IdentifierName("ODSharp.Generated"))
                    .AddMembers(TypedFibreObjectGenerator.Generate(parsedManifest))
                    .AddMembers(EnumGenerator.Generate(enums)))
            .NormalizeWhitespace();


        return SyntaxFactory.SyntaxTree(compilationUnitSyntax, encoding: Encoding.UTF8);
    }
}