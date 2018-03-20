Public Class Form1
    Private Sub btmadd_Click(sender As Object, e As EventArgs) Handles btmadd.Click
        If TextBox1.Text.Length <> 0 And TextBox2.Text.Length <> 0 Then
            Dim asnwer = add(CType(TextBox1.Text, Double), CType(TextBox2.Text, Double))
            TextBox3.Text = asnwer
            TextBox1.ReadOnly = True
        Else
            MessageBox.Show("PLease enter the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btmsubtract_Click(sender As Object, e As EventArgs) Handles btmsubtract.Click
        Dim asnwer = subtract(CType(TextBox1.Text, Double), CType(TextBox2.Text, Double))
        TextBox3.Text = asnwer
    End Sub

    Private Sub btmdivide_Click(sender As Object, e As EventArgs) Handles btmdivide.Click
        Dim answer = divide(CType(TextBox1.Text, Double), CType(TextBox2.Text, Double))
        TextBox3.Text = answer
    End Sub

    Private Sub btmmultiply_Click(sender As Object, e As EventArgs) Handles btmmultiply.Click
        Dim answer = multiply(CType(TextBox1.Text, Double), CType(TextBox2.Text, Double))
        TextBox3.Text = answer
    End Sub

    Private Sub btmModules_Click(sender As Object, e As EventArgs) Handles btmModules.Click
        Dim answer = Modulust(CType(TextBox1.Text, Integer), CType(TextBox2.Text, Integer))
        TextBox3.Text = answer
    End Sub

    Private Sub btmPI_Click(sender As Object, e As EventArgs) Handles btmPI.Click
        Dim answer = Pi(CType(TextBox1.Text, Double))
        TextBox3.Text = answer
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function add(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 + num2
    End Function

    Private Function subtract(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 - num2
    End Function

    Private Function divide(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 / num2
    End Function

    Private Function multiply(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 * num2
    End Function

    Private Function Modulust(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Return num1 Mod num2
    End Function

    Private Function Pi(ByVal num1 As Double) As Double
        Return num1 * Math.PI
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.ReadOnly = False
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

    End Sub

End Class
