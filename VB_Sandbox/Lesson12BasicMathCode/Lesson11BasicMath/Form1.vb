Public Class Form1
    Private Sub btnSummarize_Click(sender As Object, e As EventArgs) Handles btnSummarize.Click
        ' "10" is NOT the same as 10 without double quotes
        Dim leftValue = Double.Parse(txtLeftValue.Text)
        Dim rightValue = Double.Parse(txtRightValue.Text)
        Dim sum = leftValue + rightValue
        lblSummary.Text = $"Sum: {sum}" + vbCr + $"Average:{sum / 2}"
        'average =sum/2
    End Sub
End Class