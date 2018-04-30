Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Form1
    Dim formatter As IFormatter = New BinaryFormatter()
    Dim file = "c:\data\datetime.dat"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s = New FileStream(file, FileMode.Create)
        Dim dt = Size
        formatter.Serialize(s, dt)
        s.Dispose()
        Process.Start("notepad.exe", file)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim s = New FileStream(file, FileMode.Open)
        Dim dt = DirectCast(formatter.Deserialize(s), Size)
        Label1.Text = dt.ToString()
        s.Dispose()
    End Sub
End Class
