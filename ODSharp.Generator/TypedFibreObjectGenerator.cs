using FibreSharp.LegacyManifestParser;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using static ODSharp.GeneratorCore.SyntaxFactoryExtensions;

namespace ODSharp.GeneratorCore;

public static class TypedFibreObjectGenerator
{
    public static ClassDeclarationSyntax Generate(ObjectEndpoint parsedManifest)
    {
        var classSyntax = MakeClassForObject(parsedManifest);


        return classSyntax;
    }

    private static ClassDeclarationSyntax MakeClassForObject(ObjectEndpoint obj)
    {
        var scalars = obj.Scalars.Where(x => x.Id != 0).ToArray();
        var objects = obj.Objects;
        var functions = obj.Functions;

        var classNameForObject = GetClassNameForObject(obj);

        var classSyntax = ClassDeclaration(classNameForObject)
            .AddModifiers(
                Token(SyntaxKind.PublicKeyword),
                Token(SyntaxKind.PartialKeyword))
            .AddMembers(MakeConstructor(classNameForObject, scalars, objects, functions))
            .AddMembers(scalars.Select(MakeScalarEndpointPropertyDeclaration))
            .AddMembers(objects.Select(MakeObjectEndpointPropertyDeclaration))
            .AddMembers(functions.Select(MakeFunctionEndpointPropertyDeclaration))
            .AddMembers(MakeObjectFactoryMethod(classNameForObject, scalars, objects, functions))
            .AddMembers(objects.Select(MakeClassForObject))
            .AddMembers(functions.Select(MakeClassForFunction));
        return classSyntax;
    }

    private static ClassDeclarationSyntax MakeClassForFunction(FunctionEndpoint endpoint)
    {
        var returnType = endpoint.Outputs switch
        {
            { Count: 0 } => MakeTaskType(),
            { Count: 1 } => MakeTaskType(ParseTypeName(endpoint.Outputs.First().Type.FullName)),
            { Count: > 1 } => MakeTaskType(
                TupleType(
                    SeparatedList(
                        endpoint.Outputs.Select(
                            x => TupleElement(ParseTypeName(x.Type.FullName), Identifier(x.Name)))))),
            _ => throw new ArgumentOutOfRangeException()
        };


        var className = GetClassNameForFunction(endpoint);
        var constructorDeclaration = ConstructorDeclaration(Identifier(className))
            .AddParameterListParameters(endpoint.Inputs.Select(MakeScalarEndpointAccessorParameter))
            .AddParameterListParameters(endpoint.Outputs.Select(MakeScalarEndpointAccessorParameter))
            .AddParameterListParameters(
                Parameter(Identifier("_invoker")).WithType(
                    QualifiedName(
                        IdentifierName("FibreSharp"),
                        IdentifierName("HighLevel"),
                        IdentifierName("ICallInvoker"))))
            .AddBodyStatements(endpoint.Inputs.Select(MakeEndpointAccessorAssignmentStatement))
            .AddBodyStatements(endpoint.Outputs.Select(MakeEndpointAccessorAssignmentStatement))
            .AddBodyStatements(ExpressionStatement(
                AssignmentExpression(
                    SyntaxKind.SimpleAssignmentExpression,
                    MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        ThisExpression(),
                        IdentifierName("_invoker")),
                    IdentifierName("_invoker"))));

        var invokeDeclaration = MethodDeclaration(
                returnType,
                "InvokeAsync")
            .AddModifiers(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.AsyncKeyword))
            .AddParameterListParameters(
                endpoint.Inputs.Select(
                    x => Parameter(Identifier(x.Name)).WithType(ParseTypeName(x.Type.FullName))))
            .AddBodyStatements(
                endpoint.Inputs.Select(
                    x => ExpressionStatement(
                        AwaitExpression(
                            InvocationExpression(
                                MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    MemberAccessExpression(
                                        SyntaxKind.SimpleMemberAccessExpression,
                                        ThisExpression(),
                                        IdentifierName(x.Name)),
                                    IdentifierName("SetAsync")),
                                ArgumentList(
                                    SingletonSeparatedList(
                                        Argument(
                                            IdentifierName(x.Name)))))))))
            .AddBodyStatements(
                ExpressionStatement(
                    AwaitExpression(
                        InvocationExpression(
                            MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    ThisExpression(),
                                    IdentifierName("_invoker")),
                                IdentifierName("CallAsync"))))));

        switch (endpoint.Outputs.Count)
        {
            case 1:
                invokeDeclaration =
                    invokeDeclaration.AddBodyStatements(ReturnStatement(MakeGetExpression(endpoint.Outputs.Single())));
                break;

            case > 1:
                invokeDeclaration = invokeDeclaration.AddBodyStatements(ReturnStatement(
                    TupleExpression(
                        SeparatedList(endpoint.Outputs.Select(x => Argument(MakeGetExpression(x)))))));
                break;
        }

        var classDeclaration = ClassDeclaration(className)
            .AddModifiers(Token(SyntaxKind.PublicKeyword))
            .AddMembers(endpoint.Inputs.Select(MakeScalarEndpointPropertyDeclaration))
            .AddMembers(endpoint.Outputs.Select(MakeScalarEndpointPropertyDeclaration))
            .AddMembers(
                FieldDeclaration(
                        VariableDeclaration(
                                QualifiedName(
                                    IdentifierName("FibreSharp"),
                                    IdentifierName("HighLevel"),
                                    IdentifierName("ICallInvoker")))
                            .AddVariables(VariableDeclarator("_invoker")))
                    .AddModifiers(Token(SyntaxKind.PrivateKeyword), Token(SyntaxKind.ReadOnlyKeyword)))
            .AddMembers(
                PropertyDeclaration(
                        QualifiedName(
                            IdentifierName("FibreSharp"),
                            IdentifierName("LegacyManifestParser"),
                            IdentifierName("FunctionEndpoint")),
                        "Endpoint")
                    .WithExpressionBody(
                        ArrowExpressionClause(
                            MemberAccessExpression(
                                SyntaxKind.SimpleMemberAccessExpression,
                                MemberAccessExpression(
                                    SyntaxKind.SimpleMemberAccessExpression,
                                    ThisExpression(),
                                    IdentifierName("_invoker")),
                                IdentifierName("Endpoint"))))
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)))
            .AddMembers(invokeDeclaration)
            .AddMembers(constructorDeclaration)
            .AddMembers(MakeFunctionFactoryMethod(endpoint));

        return classDeclaration;

        AwaitExpressionSyntax MakeGetExpression(ScalarEndpoint outputEndpoint)
        {
            return AwaitExpression(
                InvocationExpression(
                    MemberAccessExpression(
                        SyntaxKind.SimpleMemberAccessExpression,
                        MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            ThisExpression(),
                            IdentifierName(outputEndpoint.Name)),
                        IdentifierName("GetAsync"))));
        }
    }

    private static string GetClassNameForFunction(FunctionEndpoint endpoint)
    {
        return $"F_{endpoint.Name}";
    }

    private static QualifiedNameSyntax MakeTaskType(TypeSyntax returnType)
    {
        return QualifiedName(
            IdentifierName("System"),
            IdentifierName("Threading"),
            IdentifierName("Tasks"),
            GenericName(Identifier("Task"), returnType));
    }

    private static QualifiedNameSyntax MakeTaskType()
    {
        return QualifiedName(
            IdentifierName("System"),
            IdentifierName("Threading"),
            IdentifierName("Tasks"),
            IdentifierName("Task"));
    }

    private static PropertyDeclarationSyntax MakeObjectEndpointPropertyDeclaration(ObjectEndpoint objectEndpoint)
    {
        return PropertyDeclaration(
                IdentifierName(GetClassNameForObject(objectEndpoint)),
                Identifier(objectEndpoint.Name))
            .AddModifiers(Token(SyntaxKind.PublicKeyword))
            .AddAccessorListAccessors(
                AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)));
    }
    private static PropertyDeclarationSyntax MakeFunctionEndpointPropertyDeclaration(FunctionEndpoint functionEndpoint)
    {
        return PropertyDeclaration(
                IdentifierName(GetClassNameForFunction(functionEndpoint)),
                Identifier(functionEndpoint.Name))
            .AddModifiers(Token(SyntaxKind.PublicKeyword))
            .AddAccessorListAccessors(
                AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)));
    }

    private static MethodDeclarationSyntax MakeFunctionFactoryMethod(FunctionEndpoint functionEndpoint)
    {
        var classNameForObject = GetClassNameForFunction(functionEndpoint);

        var outputArgs = functionEndpoint.Outputs.Select(
            x => Argument(MakeAccessorConstructorCall(x)));
        var inputArgs = functionEndpoint.Inputs.Select(
            x => Argument(MakeAccessorConstructorCall(x)));


        return MethodDeclaration(IdentifierName(classNameForObject), "Construct")
            .AddModifiers(
                Token(SyntaxKind.PublicKeyword),
                Token(SyntaxKind.StaticKeyword))
            .AddParameterListParameters(
                Parameter(Identifier("_comm")).WithType(
                    QualifiedName(
                        IdentifierName("FibreSharp"),
                        IdentifierName("ILegacyFibreClient"))))
            .AddBodyStatements(
                ReturnStatement(
                    ObjectCreationExpression(IdentifierName(classNameForObject))
                        .AddArgumentListArguments(inputArgs)
                        .AddArgumentListArguments(outputArgs)
                        .AddArgumentListArguments(Argument(MakeCallerConstructorCall(functionEndpoint)))));
    }

    private static MethodDeclarationSyntax MakeObjectFactoryMethod(
        string classNameForObject,
        IEnumerable<ScalarEndpoint> scalarEndpoints,
        IEnumerable<ObjectEndpoint> objectEndpoints,
        IEnumerable<FunctionEndpoint> functionEndpoints)
    {
        var scalarArgs = scalarEndpoints.Select(
            x => Argument(MakeAccessorConstructorCall(x)));
        var objectArgs = objectEndpoints.Select(
            x => Argument(MakeObjectFactoryCall(x)));
        var functionArgs = functionEndpoints.Select(
            x => Argument(MakeFunctionFactoryCall(x)));


        return MethodDeclaration(IdentifierName(classNameForObject), "Construct")
            .AddModifiers(
                Token(SyntaxKind.PublicKeyword),
                Token(SyntaxKind.StaticKeyword))
            .AddParameterListParameters(
                Parameter(Identifier("_comm")).WithType(
                    QualifiedName(
                        IdentifierName("FibreSharp"),
                        IdentifierName("ILegacyFibreClient"))))
            .AddBodyStatements(
                ReturnStatement(
                    ObjectCreationExpression(IdentifierName(classNameForObject))
                        .AddArgumentListArguments(scalarArgs)
                        .AddArgumentListArguments(objectArgs)
                        .AddArgumentListArguments(functionArgs)));
    }

    private static ExpressionSyntax MakeAccessorConstructorCall(ScalarEndpoint endpoint)
    {
        return InvocationExpression(
                QualifiedName(
                    IdentifierName("FibreSharp"),
                    IdentifierName("HighLevel"),
                    IdentifierName("HighLevelHelper"),
                    GenericName(
                        Identifier("GetAccessor"),
                        ParseTypeName(endpoint.Type.FullName!))))
            .WithArgumentList(
                Argument(IdentifierName("_comm")),
                Argument(StringLiteral(endpoint.QualifiedName)));
    }

    private static ExpressionSyntax MakeCallerConstructorCall(FunctionEndpoint endpoint)
    {
        return InvocationExpression(
                QualifiedName(
                    IdentifierName("FibreSharp"),
                    IdentifierName("HighLevel"),
                    IdentifierName("HighLevelHelper"),
                    IdentifierName("GetCaller")))
            .WithArgumentList(
                Argument(IdentifierName("_comm")),
                Argument(StringLiteral(endpoint.QualifiedName)));
    }

    private static ExpressionSyntax MakeObjectFactoryCall(ObjectEndpoint endpoint)
    {
        return InvocationExpression(
                QualifiedName(
                    IdentifierName(GetClassNameForObject(endpoint)),
                    IdentifierName("Construct")))
            .AddArgumentListArguments(
                Argument(IdentifierName("_comm")));
    }
    private static ExpressionSyntax MakeFunctionFactoryCall(FunctionEndpoint endpoint)
    {
        return InvocationExpression(
                QualifiedName(
                    IdentifierName(GetClassNameForFunction(endpoint)),
                    IdentifierName("Construct")))
            .AddArgumentListArguments(
                Argument(IdentifierName("_comm")));
    }

    private static string GetClassNameForObject(ObjectEndpoint obj)
    {
        return $"C_{obj.Name}";
    }

    private static TypeSyntax MakeScalarAccessorInterfaceType(ScalarEndpoint scalarEndpoint)
    {
        var intfType = scalarEndpoint.Access switch
        {
            Access.Read => "IReadScalarAccessor",
            Access.Write => "IWriteScalarAccessor",
            Access.Read | Access.Write => "IReadWriteScalarAccessor",
            _ => throw new ArgumentOutOfRangeException("scalarEndpoint.Access", scalarEndpoint.Access, "unknown value")
        };

        return QualifiedName(
            IdentifierName("FibreSharp"),
            IdentifierName("HighLevel"),
            GenericName(
                Identifier(intfType),
                ParseTypeName(scalarEndpoint.Type.FullName!)));
    }

    private static PropertyDeclarationSyntax MakeScalarEndpointPropertyDeclaration(ScalarEndpoint scalarEndpoint)
    {
        return PropertyDeclaration(
                MakeScalarAccessorInterfaceType(scalarEndpoint),
                Identifier(scalarEndpoint.Name))
            .AddModifiers(Token(SyntaxKind.PublicKeyword))
            .AddAccessorListAccessors(
                AccessorDeclaration(SyntaxKind.GetAccessorDeclaration)
                    .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)));
    }

    private static ConstructorDeclarationSyntax MakeConstructor(
        string className,
        IReadOnlyList<ScalarEndpoint> scalarEndpoints,
        IReadOnlyList<ObjectEndpoint> objectEndpoints,
        IReadOnlyList<FunctionEndpoint> functionEndpoints)
    {
        return ConstructorDeclaration(Identifier(className))
            .AddModifiers(
                Token(SyntaxKind.PublicKeyword))
            .AddParameterListParameters(
                scalarEndpoints.Select(MakeScalarEndpointAccessorParameter))
            .AddParameterListParameters(
                objectEndpoints.Select(MakeObjectEndpointAccessorParameter))
            .AddParameterListParameters(
                functionEndpoints.Select(MakeFunctionEndpointAccessorParameter))
            .AddBodyStatements(
                scalarEndpoints.Select(MakeEndpointAccessorAssignmentStatement))
            .AddBodyStatements(
                objectEndpoints.Select(MakeEndpointAccessorAssignmentStatement))
            .AddBodyStatements(
                functionEndpoints.Select(MakeEndpointAccessorAssignmentStatement));
    }

    private static ParameterSyntax MakeObjectEndpointAccessorParameter(ObjectEndpoint objectEndpoint)
    {
        return Parameter(Identifier(objectEndpoint.Name))
            .WithType(IdentifierName(GetClassNameForObject(objectEndpoint)));
    }
    private static ParameterSyntax MakeFunctionEndpointAccessorParameter(FunctionEndpoint functionEndpoint)
    {
        return Parameter(Identifier(functionEndpoint.Name))
            .WithType(IdentifierName(GetClassNameForFunction(functionEndpoint)));
    }

    private static ParameterSyntax MakeScalarEndpointAccessorParameter(ScalarEndpoint endpoint)
    {
        return Parameter(
                Identifier(BuildEndpointAccessorVariableName(endpoint)))
            .WithType(
                MakeScalarAccessorInterfaceType(endpoint));
    }

    private static ExpressionStatementSyntax MakeEndpointAccessorAssignmentStatement(Endpoint endpoint)
    {
        var variableName = BuildEndpointAccessorVariableName(endpoint);
        return ExpressionStatement(
            AssignmentExpression(
                SyntaxKind.SimpleAssignmentExpression,
                MemberAccessExpression(
                    SyntaxKind.SimpleMemberAccessExpression,
                    ThisExpression(),
                    IdentifierName(variableName)),
                IdentifierName(variableName)));
    }

    private static string BuildEndpointAccessorVariableName(Endpoint endpoint)
    {
        return $"{endpoint.Name}";
    }
}