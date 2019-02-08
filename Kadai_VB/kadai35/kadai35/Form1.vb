Imports System.IO
Imports System.IO.StreamReader
Imports System.Text

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Using SR As New StreamReader(ofd.FileName, Encoding.GetEncoding("shift_jis"))
                Dim read As String = SR.ReadToEnd

                TextBox1.Text = read
            End Using 'closes file
        End If
    End Sub

    Private Function StreamReader(ofd As OpenFileDialog, Optional p As Object = Nothing) As String
        Throw New NotImplementedException()
    End Function
End Class
