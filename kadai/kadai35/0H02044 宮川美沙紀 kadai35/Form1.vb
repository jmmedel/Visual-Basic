Imports System.IO
Imports System.Text

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Sr As New StreamReader("C:\KIC\2018\Visual Basic\VBkadai\0H02044 宮川美沙紀 kadai35\0H02044 宮川美沙紀 kadai35\bin\Debug\kadai35r.txt", Encoding.GetEncoding("shift_jis"))
        TextBox1.Text = Sr.ReadToEnd
        Sr.Close()
    End Sub
End Class
