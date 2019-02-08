Imports System.IO
Imports System.Text

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Sr As New StreamReader("C:\KIC\2018\Visual Basic\VBkadai\0H02044 宮川美沙紀 kadai36\0H02044 宮川美沙紀 kadai36\bin\Debug\28HYOGO.CSV", Encoding.GetEncoding("shift_jis"))
        Dim Items() As String
        Dim Line As String = Sr.ReadLine
        Dim PostalCode As String
        Dim Address As String

        Do Until IsNothing(Line)
            Items = Line.Split(", ")
            PostalCode = Items(2)
            PostalCode = PostalCode.Replace("""", "")
            If PostalCode = TextBox1.Text Then
                Address = Items(6) + Items(7) + Items(8)
                Address = Address.Replace("""", "")
                Label2.Text = Address
            End If
            Line = Sr.ReadLine
        Loop

        Sr.Close()
    End Sub
End Class
