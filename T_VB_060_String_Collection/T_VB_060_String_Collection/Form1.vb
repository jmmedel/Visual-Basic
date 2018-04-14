Imports System.Collections.Specialized

Public Class Form1


    Private stringcol As New StringCollection
    Private myArray() As String = {"Joe", "Kagaya", "john"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stringcol.Add("kagaya")
        'Add aray'
        stringcol.AddRange(myArray)
        stringcol.Remove("john")
        stringcol.RemoveAt(0)
        Dim isthere As Boolean = stringcol.Contains("john")
        For Each item As String In stringcol
            ListBox1.Items.Add(item)

        Next
        MsgBox(isthere.ToString())
    End Sub


End Class
