Public Class frmCalculator
  Dim firstNum, secondNum, result As Double

  Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click

    If txtFirst.Text <> "" And txtSecond.Text <> "" Then
      firstNum = CDbl(txtFirst.Text)
      secondNum = CDbl(txtSecond.Text)

      result = firstNum + secondNum
      txtResults.Text = "The result of " & firstNum & " + " & secondNum & " = " & result
    Else
      MessageBox.Show("Please enter both numbers")
    End If

    btnPlus.BackColor = Color.Aqua
    btnMinus.BackColor = Color.FromArgb(224, 224, 224)
    btnMultiply.BackColor = Color.FromArgb(224, 224, 224)
  End Sub

  Private Sub txtFirst_TextChanged(sender As Object, e As EventArgs) Handles txtFirst.TextChanged
    txtResults.Clear()
  End Sub

  Private Sub txtSecond_TextChanged(sender As Object, e As EventArgs) Handles txtSecond.TextChanged
    txtResults.Clear()
  End Sub

  Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click


    If txtFirst.Text <> "" And txtSecond.Text <> "" Then
      firstNum = CDbl(txtFirst.Text)
      secondNum = CDbl(txtSecond.Text)

      result = firstNum - secondNum
      txtResults.Text = "The result of " & firstNum & " - " & secondNum & " = " & result
    Else
      MessageBox.Show("Please enter both numbers")
    End If

    btnPlus.BackColor = Color.FromArgb(224, 224, 224)
    btnMinus.BackColor = Color.Aqua
    btnMultiply.BackColor = Color.FromArgb(224, 224, 224)
  End Sub

  Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click

    If txtFirst.Text <> "" And txtSecond.Text <> "" Then
      firstNum = CDbl(txtFirst.Text)
      secondNum = CDbl(txtSecond.Text)

      result = firstNum * secondNum
      txtResults.Text = "The result of " & firstNum & " * " & secondNum & " = " & result
    Else
      MessageBox.Show("Please enter both numbers")
    End If

    btnPlus.BackColor = Color.FromArgb(224, 224, 224)
    btnMinus.BackColor = Color.FromArgb(224, 224, 224)
    btnMultiply.BackColor = Color.Aqua
  End Sub


End Class
