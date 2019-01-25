Imports System.IO
Imports System.Text

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Using SR As New StreamReader(My.Resources.Resource1._28HYOGO, Encoding.GetEncoding("shift_jis"))
            TextBox2.Text = SR.Read
        End Using

    End Sub


End Class
