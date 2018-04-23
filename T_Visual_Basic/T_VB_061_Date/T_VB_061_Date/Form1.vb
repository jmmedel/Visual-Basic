Public Class Form1
    '87'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim currentDate As Date
        currentDate = Now

        MessageBox.Show(currentDate.ToString(), "Date Application")
        MsgBox(currentDate.ToLongDateString())


    End Sub

End Class
