<DiagnosticAnalyzer(LanguageNames.VisualBasic)>
Public Class RegexAnalyzerAnalyzer
    Inherits DiagnosticAnalyzer

    Public Const DiagnosticId = "RX001"
    Friend Shared ReadOnly Title As String = "Regex error parsing string argument"
    Friend Shared ReadOnly MessageFormat As String = "Regex error: {0}"
    Friend Shared ReadOnly Description As String = "Checks for non-matching regular expressions"
    Friend Const Category = "Syntax"

    Friend Shared Rule As New DiagnosticDescriptor(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Error, isEnabledByDefault:=True, description:=Description)

    Public Overrides ReadOnly Property SupportedDiagnostics As ImmutableArray(Of DiagnosticDescriptor)
        Get
            Return ImmutableArray.Create(Rule)
        End Get
    End Property

    Public Overrides Sub Initialize(context As AnalysisContext)
        context.RegisterSyntaxNodeAction(AddressOf AnalyzeNode,
                                         SyntaxKind.InvocationExpression)

    End Sub

    Public Sub AnalyzeNode(context As SyntaxNodeAnalysisContext)
        Dim invocationExpr = TryCast(context.Node,
            InvocationExpressionSyntax)
        If TypeOf (invocationExpr.Expression) _
            IsNot MemberAccessExpressionSyntax Then Return

        Dim memberAccessExpr = DirectCast(invocationExpr.Expression,
            MemberAccessExpressionSyntax)
        Dim check1 = memberAccessExpr?.Name.ToString
        If memberAccessExpr?.Name.ToString <> "IsMatch" Then Return
        Dim memberSymbol = DirectCast(context.SemanticModel.
            GetSymbolInfo(memberAccessExpr).Symbol, IMethodSymbol)
        Dim result = memberSymbol.ToString

        If Not memberSymbol?.ReturnType.ToString = "Boolean" Then Return
        Dim argumentList = invocationExpr.ArgumentList
        If argumentList?.Arguments.Count < 2 Then Return

        Dim exprLiteral = DirectCast(argumentList.Arguments(0).GetExpression,
            LiteralExpressionSyntax)
        If exprLiteral Is Nothing Then Return
        Dim exprLiteralOpt = context.SemanticModel.GetConstantValue(exprLiteral)
        Dim stringLiteral = DirectCast(exprLiteralOpt.Value, String)
        If stringLiteral Is Nothing Then Return

        Dim regexLiteral = DirectCast(argumentList.Arguments(1).GetExpression,
            LiteralExpressionSyntax)
        If regexLiteral Is Nothing Then Return
        Dim regexOpt = context.SemanticModel.GetConstantValue(regexLiteral)
        Dim patternLiteral = DirectCast(regexOpt.Value, String)
        If patternLiteral Is Nothing Then Return

        If System.Text.RegularExpressions.Regex.IsMatch(stringLiteral, patternLiteral) = False Then
            Dim diagn = Diagnostic.Create(Rule, exprLiteral.GetLocation,
                          "The specified string does not match the regular expression")
            context.ReportDiagnostic(diagn)
        End If

    End Sub

End Class