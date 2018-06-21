Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Font = New Font("MS Gothic", 12)
        Label1.ForeColor = Color.Red
        Label1.Text &= Environment.NewLine

    End Sub
End Class
