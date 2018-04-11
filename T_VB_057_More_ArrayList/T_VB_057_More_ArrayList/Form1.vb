Public Class Form1

    Private myarraylist As New ArrayList




    'This is form load this is where its load'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        myarraylist.Add(10)
        myarraylist.Add("Heeloo")
        myarraylist.Add(1.34)

    End Sub



    'This is where it click '
    Private Sub Show_Array_Click(sender As Object, e As EventArgs) Handles Show_Array.Click

        For Each item As String In myarraylist
            ListBox1.Items.Add(item.ToString())
        Next

    End Sub
End Class
