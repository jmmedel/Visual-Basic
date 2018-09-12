Public Class FrmQuadraticEquation
  Private Sub btnFindSolution_Click(sender As Object, e As EventArgs) Handles btnFindSolution.Click
    Dim a, b, c as Double

    If Double.TryParse(txtA.Text, a) And Double.TryParse(txtB.Text, b) And Double.TryParse(txtC.Text, c)
      
    if a = 0
      MessageBox.Show("Please enter non-zero value","Invalid input for 'a'",MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
      txtA.Clear()
    Else 
      Dim determinant as Double = b ^ 2 - 4 * a * c
      Select Case determinant
          Case < 0
            txtSolutions.Text = "There are no solutions"
          Case = 0
            txtSolutions.Text = "The solution is: " & ((-b) / (2 * a)).ToString("N")
          Case else
            txtSolutions.Text = "Solution 1: " & ((-b + Math.Sqrt(determinant)) / (2 * a)).ToString("N") &
                                " Solution 2: " & ((-b - Math.Sqrt(determinant)) / (2 * a)).ToString("N")
      End Select
    End If
    Else 
      MessageBox.Show("Please correct your input", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub
End Class
