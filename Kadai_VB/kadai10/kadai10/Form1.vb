Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim age As Integer = TextBox1.Text

        Select Case age
            Case 1 To 24
                Label2.Text = "D"
                MsgBox(Label2.Text)
            Case 25 To 49
                Label2.Text = "C"
                MsgBox(Label2.Text)
            Case 50 To 74
                Label2.Text = "B"
                MsgBox(Label2.Text)
            Case 75 To 100
                Label2.Text = "A"
                MsgBox(Label2.Text)
            Case Else
                Label2.Text = "エラです"

        End Select


    End Sub
End Class
