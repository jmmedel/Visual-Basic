Imports System.IO
Imports System.Text

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Using SR As New StreamReader(My.Resources.Resource1._28HYOGO, Encoding.GetEncoding("shift_jis"))
            If (TextBox2.Text = SR.Peek) Then
                TextBox2.Text = SR.Peek
            End If
        End Using

    End Sub


End Class
