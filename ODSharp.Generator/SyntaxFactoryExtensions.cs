using System.Net;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ODSharp.GeneratorCore;

public static class SyntaxFactoryExtensions
{
    public static ObjectCreationExpressionSyntax WithArgumentList(
        this ObjectCreationExpressionSyntax that,
        params ArgumentSyntax[] arguments)
    {
        return that.WithArgumentList((IEnumerable<ArgumentSyntax>)arguments);
    }

    public static ObjectCreationExpressionSyntax WithArgumentList(
        this ObjectCreationExpressionSyntax that,
        IEnumerable<ArgumentSyntax> arguments)
    {
        return that.WithArgumentList(SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList(arguments)));
    }

    public static InvocationExpressionSyntax WithArgumentList(
        this InvocationExpressionSyntax that,
        params ArgumentSyntax[] arguments)
    {
        return that.WithArgumentList((IEnumerable<ArgumentSyntax>)arguments);
    }

    public static InvocationExpressionSyntax WithArgumentList(
        this InvocationExpressionSyntax that,
        IEnumerable<ArgumentSyntax> arguments)
    {
        return that.WithArgumentList(SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList(arguments)));
    }

    public static QualifiedNameSyntax QualifiedName(IEnumerable<SimpleNameSyntax> parts)
    {
        var parts2 = parts.ToArray();
        if (parts2.Length < 2)
        {
            throw new ArgumentException("must have at least 2 partw");
        }

        return Assemble(parts2);

        static QualifiedNameSyntax Assemble(Span<SimpleNameSyntax> remainingParts)
        {
            return remainingParts.Length == 2
                ? SyntaxFactory.QualifiedName(remainingParts[0], remainingParts[1])
                : SyntaxFactory.QualifiedName(Assemble(remainingParts[..^1]), remainingParts[^1]);
        }
    }

    public static QualifiedNameSyntax QualifiedName(params SimpleNameSyntax[] parts)
    {
        return QualifiedName((IEnumerable<SimpleNameSyntax>)parts);
    }

    public static GenericNameSyntax GenericName(SyntaxToken identifier, params TypeSyntax[] typeArguments)
    {
        return GenericName(identifier, (IEnumerable<TypeSyntax>)typeArguments);
    }

    public static GenericNameSyntax GenericName(SyntaxToken identifier, IEnumerable<TypeSyntax> typeArguments)
    {
        return SyntaxFactory.GenericName(identifier)
            .WithTypeArgumentList(
                SyntaxFactory.TypeArgumentList(
                    SyntaxFactory.SeparatedList(typeArguments)));
    }

    public static LiteralExpressionSyntax StringLiteral(string s)
    {
        return SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(s));
    }

    public static ClassDeclarationSyntax AddMembers(
        this ClassDeclarationSyntax that,
        IEnumerable<MemberDeclarationSyntax> items)
    {
        return that.WithMembers(that.Members.AddRange(items));
    }

    public static ConstructorDeclarationSyntax AddParameterListParameters(
        this ConstructorDeclarationSyntax that,
        IEnumerable<ParameterSyntax> items)
    {
        return that.WithParameterList(
            that.ParameterList.WithParameters(
                that.ParameterList.Parameters.AddRange(items)));
    }

    public static MethodDeclarationSyntax AddParameterListParameters(
        this MethodDeclarationSyntax that,
        IEnumerable<ParameterSyntax> items)
    {
        return that.WithParameterList(
            that.ParameterList.WithParameters(
                that.ParameterList.Parameters.AddRange(items)));
    }

    public static MethodDeclarationSyntax AddBodyStatements(
        this MethodDeclarationSyntax that,
        IEnumerable<StatementSyntax> items)
    {
        var existingBody = that.Body ?? SyntaxFactory.Block();
        return that.WithBody(existingBody.WithStatements(existingBody.Statements.AddRange(items)));
    }

    public static ConstructorDeclarationSyntax AddBodyStatements(
        this ConstructorDeclarationSyntax that,
        IEnumerable<StatementSyntax> items)
    {
        var existingBody = that.Body ?? SyntaxFactory.Block();
        return that.WithBody(existingBody.WithStatements(existingBody.Statements.AddRange(items)));
    }

    public static ObjectCreationExpressionSyntax AddArgumentListArguments(
        this ObjectCreationExpressionSyntax that,
        IEnumerable<ArgumentSyntax> items)
    {
        var argumentListSyntax = that.ArgumentList ?? SyntaxFactory.ArgumentList();
        return that.WithArgumentList(argumentListSyntax.WithArguments(argumentListSyntax.Arguments.AddRange(items)));
    }

    public static FileScopedNamespaceDeclarationSyntax AddMembers(
        this FileScopedNamespaceDeclarationSyntax that,
        IEnumerable<MemberDeclarationSyntax> items)
    {
        return that.WithMembers(that.Members.AddRange(items));
    }

    public static EnumDeclarationSyntax AddMembers(
        this EnumDeclarationSyntax that,
        IEnumerable<EnumMemberDeclarationSyntax> items)
    {
        return that.WithMembers(that.Members.AddRange(items));
    }

    public static EnumDeclarationSyntax AddAttributeList(
        this EnumDeclarationSyntax that,
        params AttributeSyntax[] items)
    {
        return that.AddAttributeLists(SyntaxFactory.AttributeList(SyntaxFactory.SeparatedList(items)));
    }

    public static LiteralExpressionSyntax HexLiteralExpression(long value)
    {
        return SyntaxFactory.LiteralExpression(
            SyntaxKind.NumericLiteralExpression,
            SyntaxFactory.Literal($"0x{value:X}", value));
    }
}