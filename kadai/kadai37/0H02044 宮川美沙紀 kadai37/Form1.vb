Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Sw As New StreamWriter("C:\KIC\2018\Visual Basic\VBkadai\0H02044 宮川美沙紀 kadai37\0H02044 宮川美沙紀 kadai37\bin\Debug\kadai37.txt")
        Sw.WriteLine(TextBox1.Text)
        Sw.Close()
    End Sub

End Class
