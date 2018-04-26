Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text >= 70 Or TextBox1.Text >= 65 Then
            Label2.Text = "合格"
        Else
            Label2.Text = "不合格"
        End If

    End Sub
End Class
