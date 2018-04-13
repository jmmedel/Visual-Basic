Public Class Person

    Public Property FirstName As String
    Public Property LastName As String

    Public Function FullName() As String

        If String.IsNullOrEmpty(Me.LastName) Then
            Throw New MissingLastNameException("Last name not specified")
        Else
            Return String.Concat(LastName, " ", FirstName)
        End If
    End Function
End Class