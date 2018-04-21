Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = ""
        For Each item In CheckedListBox1.CheckedItems
            Label1.Text += item + vbCr
        Next
    End Sub

    Private Sub btnWriteToFile_Click(sender As Object, e As EventArgs) Handles btnWriteToFile.Click
        Dim s As StreamWriter = New StreamWriter("c:\data\test20.txt")
        For index = 0 To CheckedListBox1.CheckedIndices.Count - 1
            s.WriteLine(CheckedListBox1.CheckedItems(index))
        Next
        s.Close()
        Process.Start("notepad.exe", "c:\data\test20.txt")
    End Sub
End Class
