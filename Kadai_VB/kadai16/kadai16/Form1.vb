Imports System.String

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Visible = True
        Dim frstloop As Integer
        Dim scndloop As Integer
        For frstloop = 0 To 9
            For scndloop = 1 To frstloop
                TextBox1.Text += "*"
            Next
            TextBox1.Text += "*" & vbNewLine & ""
            TextBox1.TextAlign = HorizontalAlignment.Center
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Visible = False
    End Sub
End Class
