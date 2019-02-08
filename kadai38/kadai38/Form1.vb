Imports System.IO
Imports System.Text


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using SR As New StreamReader(My.Resources.Resource1.kadai38, Encoding.GetEncoding("shift_jis"))
            Label1.Text = SR.Peek

        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
