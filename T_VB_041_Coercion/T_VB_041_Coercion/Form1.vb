Public Class Form1

    Private Sub btmCoercion_Click(sender As Object, e As EventArgs) Handles btmCoercion.Click

        Dim mynum As Double = 23.4
        Dim mynum1 As Integer = 31
        showDatatype(mynum)
        Showdatatype(mynum1)
    End Sub

    Private Sub Showdatatype(ByVal num As Integer)
        MessageBox.Show("This is an inter")

    End Sub

    Private Sub showDatatype(ByVal num As Double)
        MessageBox.Show("This is a double")

    End Sub

End Class
