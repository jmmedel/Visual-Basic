Public Class Form1
    '82'
    Private myarraylist As New ArrayList
    Private myarrat() As String = {"Sam", "kagaya", "Youtube"}
    Private index As Integer


    'This is form load this is where its load'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myarraylist.TrimToSize()
        myarraylist.Capacity = 5
        myarraylist.Add(10)
        myarraylist.Add("Heeloo")
        myarraylist.Add(1.34)
        myarraylist.Add(20)
        myarraylist.Add("Bye")
        myarraylist.Add(True)
        myarraylist.Add(True)
    End Sub



    'This is where it click '
    Private Sub Show_Array_Click(sender As Object, e As EventArgs) Handles Show_Array.Click

        myarraylist.Remove(True)
        myarraylist.RemoveAt(1)
        'join array '
        myarraylist.AddRange(myarrat)
        For Each item As String In myarraylist
            ListBox1.Items.Add(item.ToString())

        Next
        MsgBox(myarraylist.Count.ToString())
        index = myarraylist.BinarySearch("Kagaya")

    End Sub

End Class
