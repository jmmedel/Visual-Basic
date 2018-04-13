Imports System.Collections.Immutable
Imports Microsoft.CodeAnalysis.Editing
Imports Microsoft.CodeAnalysis.Rename

<ExportCodeFixProvider(LanguageNames.VisualBasic, Name:=NameOf(ObservableCollectionAnalyzerCodeFixProvider)), [Shared]>
Public Class ObservableCollectionAnalyzerCodeFixProvider
    Inherits CodeFixProvider

    Public NotOverridable Overrides ReadOnly Property FixableDiagnosticIds As ImmutableArray(Of String)
        Get
            Return ImmutableArray.Create(ObservableCollectionAnalyzerAnalyzer.DiagnosticId)
        End Get
    End Property

    Public NotOverridable Overrides Function GetFixAllProvider() As FixAllProvider
        Return WellKnownFixAllProviders.BatchFixer
    End Function

    Public NotOverridable Overrides Async Function RegisterCodeFixesAsync(context As CodeFixContext) As Task
        'Get the root syntax node for the current document
        Dim root = Await context.Document.
            GetSyntaxRootAsync(context.CancellationToken).ConfigureAwait(False)

        'Get a reference to the diagnostic (warning squiggle) to fix
        Dim diagnostic = context.Diagnostics.First()
        'Get the location for the diagnostic
        Dim diagnosticSpan = diagnostic.Location.SourceSpan

        'Find the syntax node on the squiggle span
        Dim node = root.FindNode(context.Span)

        ' Register a code action that will invoke the fix.
        context.RegisterCodeFix(
            CodeAction.Create("Replace List(Of T) with ObservableCollection(Of T)",
                              Function(c) ReplaceListAsync(context.
                              Document, node, c)), diagnostic)

    End Function

    Private Async Function MakeUppercaseAsync(document As Document, typeStmt As TypeStatementSyntax, cancellationToken As CancellationToken) As Task(Of Solution)
        ' Compute new uppercase name.
        Dim identifierToken = typeStmt.Identifier
        Dim newName = identifierToken.Text.ToUpperInvariant()

        ' Get the symbol representing the type to be renamed.
        Dim semanticModel = Await document.GetSemanticModelAsync(cancellationToken)
        Dim typeSymbol = semanticModel.GetDeclaredSymbol(typeStmt, cancellationToken)

        ' Produce a new solution that has all references to that type renamed, including the declaration.
        Dim originalSolution = document.Project.Solution
        Dim optionSet = originalSolution.Workspace.Options
        Dim newSolution = Await Renamer.RenameSymbolAsync(document.Project.Solution, typeSymbol, newName, optionSet, cancellationToken).ConfigureAwait(False)

        ' Return the new solution with the now-uppercase type name.
        Return newSolution
    End Function

    Private Async Function ReplaceListAsync(document As Document,
                                            node As SyntaxNode,
                                            cancellationToken As CancellationToken) _
                                            As Task(Of Document)
        Dim root = Await document.GetSyntaxRootAsync
        Dim objectCreationNode = CType(node, ObjectCreationExpressionSyntax)

        'Get the GenericNameSyntax
        Dim nodes = objectCreationNode.DescendantNodes(node.Span)
        Dim genericNameNode = CType(nodes.First, GenericNameSyntax)
        Dim newGenericNameNode = SyntaxFactory.GenericName("ObservableCollection",
                                                   genericNameNode.TypeArgumentList)

        Dim generator = SyntaxGenerator.GetGenerator(document)

        Dim boundNode = generator.
                        QualifiedName(generator.
                        DottedName("System.Collections.ObjectModel"),
                        newGenericNameNode)

        Dim newRoot = root.ReplaceNode(genericNameNode, boundNode)
        Dim newDocument = document.WithSyntaxRoot(newRoot)
        Return newDocument

    End Function


End Class