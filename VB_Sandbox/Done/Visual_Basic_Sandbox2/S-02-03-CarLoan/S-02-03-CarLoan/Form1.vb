Public Class FrmCarLoan

  Private Sub btnAnalyze_Click(sender As Object, e As EventArgs) Handles btnAnalyze.Click
    Dim loanAmount, months as Integer
    Dim interestRate, monthlyPayments, totalInterestPaid as Double

    If Integer.TryParse(txtLoanAmount.Text,loanAmount) And Integer.TryParse(txtDuration.Text,months) And 
        Double.TryParse(txtInterestRate.Text,interestRate)
    
      Dim r as Double = (interestRate / 100) / 12

      monthlyPayments = (loanAmount * r) / (1 - Math.Pow(1 + r,months * -1))
      totalInterestPaid = months * monthlyPayments - loanAmount

      txtMonthlyPayments.Text = FormatCurrency(monthlyPayments,2)
      txtInterestPaid.Text = FormatCurrency(totalInterestPaid,2)
    Else 
      MessageBox.Show("Please correct your input", "Invalid Input",MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End If
  End Sub
End Class
