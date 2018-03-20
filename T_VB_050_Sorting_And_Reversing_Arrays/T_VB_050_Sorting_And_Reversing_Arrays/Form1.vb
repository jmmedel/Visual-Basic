Public Class Form1

    Private stringclasses(5) As String
    Private Sub SubclearList()
        listArray.Items.Clear()
    End Sub

    Private Sub AdditemtoList(ByVal argArray() As String)
        'Enumerate Array'
        For Each item As String In argArray
            listArray.Items.Add(item)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SubclearList()
        AdditemtoList(stringclasses)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SubclearList()

        Array.Sort(stringclasses)
        AdditemtoList(stringclasses)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SubclearList()
        Array.Reverse(stringclasses)
        AdditemtoList(stringclasses)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stringclasses(0) = "Web Design"
        stringclasses(1) = "Spanish"
        stringclasses(2) = "English"
        stringclasses(3) = "Chemistry"
        stringclasses(4) = "History"
        stringclasses(5) = "Calculus"
    End Sub
End Class
