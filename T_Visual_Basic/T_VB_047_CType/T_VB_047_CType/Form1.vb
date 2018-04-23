Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim rawVariable As String = TextBox1.Text
        Dim finaldouble As Double
        finaldouble = CType(rawVariable, Double)
        MessageBox.Show(finaldouble)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rawVariable As String = TextBox1.Text
        Dim finalint As Integer
        finalint = CType(rawVariable, Integer)
        MessageBox.Show(finalint)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim rawVariable As String = TextBox1.Text
        Dim finalbool As Boolean
        finalbool = CType(rawVariable, Boolean)
        MessageBox.Show(finalbool)
    End Sub

End Class
