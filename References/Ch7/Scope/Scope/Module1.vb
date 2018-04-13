Module Module1

    Sub Main()

    End Sub

End Module

'The class is visible to other
'external assemblies.
Public Class ScopeDemo

    'This field is visible only
    'within the class
    Private counter As Integer

    'Visible within this assembly, this class,
    'derived classes, other assemblies: no restrictions
    Public Property FirstName As String
    Public Property LastName As String

    'Only within this class and derived classes
    Protected Property Age As Integer

    'Within this assembly
    Friend Property ReservedInformation As String

    'Within this assembly, this class and derived classes
    Protected Friend Function ReturnSomeInformation() As String
        Return FirstName & " " & LastName
    End Function

End Class

Public Class InheritedScopeDemo
    Inherits ScopeDemo


End Class