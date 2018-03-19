Public Class Form1

    'Private Field '
    Private myNum As Integer = 10

    'Public Field '
    Public Mypublicnum As Integer = 32

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Globalbtm.Click
        MessageBox.Show(myNum)
        mySub()
        MessageBox.Show(myNum.ToString())
        MessageBox.Show(Mypublicnum.ToString())
    End Sub

    Public Sub mySub()
        myNum = 14
        Mypublicnum = 23
    End Sub


End Class
