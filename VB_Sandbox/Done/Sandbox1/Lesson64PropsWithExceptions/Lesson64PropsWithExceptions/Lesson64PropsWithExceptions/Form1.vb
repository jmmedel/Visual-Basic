Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'wrap in try/catch to prevent crashes of code
        Try
            TrackBar1.Value = Integer.Parse(TextBox1.Text)
        Catch ex As Exception
            'you can display a message here using a label
        End Try
    End Sub
End Class
