Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim b As Integer = TextBox1.Text


        Select Case b
            Case 3 To 5
                Label2.Text = "春です"
            Case 6 To 8
                Label2.Text = "夏です"
            Case 9 To 11
                Label2.Text = "秋です"
            Case 12, 1, 2
                Label2.Text = "冬です"
            Case Else
                Label2.Text = "エラです"

        End Select

    End Sub

End Class
