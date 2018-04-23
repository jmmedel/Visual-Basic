Public Class Form1
    Private Sub btmArray_Click(sender As Object, e As EventArgs) Handles btmArray.Click
        SubclearList()
        Dim stringclasses(5) As String

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
    Private Sub SubclearList()
        listArray.Items.Clear()
    End Sub


End Class
