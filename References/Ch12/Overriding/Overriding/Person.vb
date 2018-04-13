Public Class Person

    Public Property FirstName As String
    Public Property LastName As String

    'Simplified version, with no validation
    Public Overridable Function FullName() As String
        Return String.Concat(LastName, " ",
                             FirstName)
    End Function

End Class