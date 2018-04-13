Imports System.Text.RegularExpressions

Public Class Contact

    Public Property FirstName As String
    Public Property LastName As String
    Public Property EmailAddress As String

    Public Sub New(ByVal Name As String, ByVal LastName As String, ByVal Email As String)
        Me.FirstName = Name
        Me.LastName = LastName
        Me.EmailAddress = Email
    End Sub

    Partial Private Sub Validate(ByVal Email As String)
    End Sub

End Class

Partial Public Class Contact

    Private Sub Validate(ByVal Email As String)

        Dim validateMail As String =
        "^([\w-\.]+)@((\[[0-9]{1,3}\." &
        "[0-9]{1,3}\.)|(([\w-]+\.)+))" &
        "([a-zA-z]{2,4}|[0-9]{1,3})(\]?)$"

        If Text.RegularExpressions.
            Regex.IsMatch(Email, validateMail) _
            = False Then
            Throw New _
            InvalidOperationException("The specified mail address is not valid")
        End If
    End Sub
End Class