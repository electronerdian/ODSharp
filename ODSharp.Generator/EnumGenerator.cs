using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using static ODSharp.GeneratorCore.SyntaxFactoryExtensions;

namespace ODSharp.GeneratorCore;

public record EnumInfo(bool Flag, IReadOnlyDictionary<string, long> Values);

public static class EnumGenerator
{
    public static IEnumerable<EnumDeclarationSyntax> Generate(IReadOnlyDictionary<string, EnumInfo> enums)
    {
        return enums.Select(enumInFile => CreateEnum(enumInFile.Key, enumInFile.Value));
    }

    private static EnumDeclarationSyntax CreateEnum(string name, EnumInfo enumInfo)
    {
        static EnumMemberDeclarationSyntax MakeMember(string memberName, long value) =>
            EnumMemberDeclaration(memberName)
                .WithEqualsValue(
                    EqualsValueClause(HexLiteralExpression(value)));

        var enumDeclarationSyntax = EnumDeclaration(name)
            .AddModifiers(Token(SyntaxKind.PublicKeyword))
            .AddMembers(
                enumInfo.Values.Select(
                    member => MakeMember(member.Key, member.Value)));

        if (enumInfo.Flag) 
        {
            enumDeclarationSyntax = enumDeclarationSyntax.AddAttributeList(
                Attribute(QualifiedName(IdentifierName("System"), IdentifierName("FlagsAttribute"))));
        }

        if (enumInfo.Values.Values.Max() > int.MaxValue)
        {
            enumDeclarationSyntax = enumDeclarationSyntax.WithBaseList(
                BaseList(SingletonSeparatedList<BaseTypeSyntax>(SimpleBaseType(PredefinedType(Token(SyntaxKind.ULongKeyword))))));
        }

        return enumDeclarationSyntax;
    }
}