Imports System.Text.RegularExpressions

Class Page1
    Private Sub Button1_Click(ByVal sender As System.Object,
                          ByVal e As System.Windows.RoutedEventArgs) _
                          Handles Button1.Click

        If String.IsNullOrEmpty(Me.MailTextBox.Text) = True Then Exit Sub

        MessageBox.Show("Is a valid address: " & IsValidEMail(Me.MailTextBox.Text))

    End Sub

    Function IsValidEMail(ByVal EMailAddress As String) _
                  As Boolean
        Dim validateMail As String = _
        "^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.)" & _
        "|(([\w-]+\.)+))([a-zA-z]{2,4}|[0-9]{1,3})(\]?)$"

        Return Regex.IsMatch(EMailAddress, _
                              validateMail)

    End Function
End Class
