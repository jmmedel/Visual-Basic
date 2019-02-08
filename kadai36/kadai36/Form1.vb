Imports System.IO
Imports System.Text

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Using SR As New StreamReader(My.Resources.Resource1._28HYOGO, Encoding.GetEncoding("shift_jis"))
            Dim Items() As String
            Dim Line As String = SR.ReadLine
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
                Line = SR.ReadLine
            Loop

            SR.Close()
        End Using

    End Sub


End Class
