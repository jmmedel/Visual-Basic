<DiagnosticAnalyzer(LanguageNames.VisualBasic)>
Public Class ObservableCollectionAnalyzerAnalyzer
    Inherits DiagnosticAnalyzer

    Public Const DiagnosticId = "WPF001"
    Friend Shared ReadOnly Title As String = "List(Of T) in WPF"
    Friend Shared ReadOnly MessageFormat As String = "WPF warning: {0}"
    Friend Shared ReadOnly Description As String = "Detects invalid usages of List(Of T) in a WPF app"
    Friend Const Category = "Syntax"


    Friend Shared Rule As New DiagnosticDescriptor(DiagnosticId, Title, MessageFormat, Category, DiagnosticSeverity.Warning, isEnabledByDefault:=True, description:=Description)

    Public Overrides ReadOnly Property SupportedDiagnostics As ImmutableArray(Of DiagnosticDescriptor)
        Get
            Return ImmutableArray.Create(Rule)
        End Get
    End Property

    Public Overrides Sub Initialize(context As AnalysisContext)
        context.RegisterSyntaxNodeAction(AddressOf AnalyzeCollection,
                                         SyntaxKind.ObjectCreationExpression)

    End Sub

    Public Sub AnalyzeCollection(context As SyntaxNodeAnalysisContext)
        If context.SemanticModel.Compilation.GetTypeByMetadataName("System.Windows.Navigation.JournalEntry") Is Nothing Then Return

        Dim creationExpression = TryCast(context.Node, ObjectCreationExpressionSyntax)
        If creationExpression Is Nothing Then Return

        If creationExpression?.Type.ToString.StartsWith("List(Of") = False Then
            Return
        Else
            Dim diagn = Diagnostic.Create(Rule, creationExpression.GetLocation,
                                  "Consider using ObservableCollection instead of List")
            context.ReportDiagnostic(diagn)
        End If


    End Sub


End Class