Public Class Person

    Public Property FirstName As String
    Public Property LastName As String

    'A simplified implementation
    Public Overridable Function FullName() As String
        If FirstName = "" And LastName = "" Then
            Throw New InvalidOperationException("Both FirstName and LastName are empty")
        Else
            Return String.Concat(FirstName, " ", LastName)
        End If
    End Function

End Class