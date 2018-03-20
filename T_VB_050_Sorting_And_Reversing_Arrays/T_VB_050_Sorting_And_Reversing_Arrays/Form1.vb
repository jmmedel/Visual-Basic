Public Class Form1

    Private stringclasses(5) As String
    Private Sub SubclearList()
        listArray.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SubclearList()


        stringclasses(0) = "Web Design"
        stringclasses(1) = "Spanish"
        stringclasses(2) = "English"
        stringclasses(3) = "Chemistry"
        stringclasses(4) = "History"
        stringclasses(5) = "Calculus"

        For index As Integer = 0 To stringclasses.Length - 1
            listArray.Items.Add(stringclasses(index))
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SubclearList()

        Array.Sort(stringclasses)
        For num As Integer = 0 To stringclasses.Length - 1
            listArray.Items.Add(stringclasses(num))
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SubclearList()
        Array.Reverse(stringclasses)
        For num As Integer = 0 To stringclasses.Length - 1
            listArray.Items.Add(stringclasses(num))
        Next
    End Sub
End Class
