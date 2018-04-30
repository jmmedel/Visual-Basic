Public Class Form1
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Dim last = lblResults.Text
        Try
            Dim leftValue = Double.Parse(txtLeftValue.Text)
            Dim rightValue = Double.Parse(txtRightValue.Text)
            Dim roundingDigits = Integer.Parse(txtRoundingDigits.Text)
            Dim rawResult As Double
            Dim roundedResult As Double
            If rightValue = 0 Then
                Throw New DivideByZeroException()
            Else
                rawResult = leftValue / rightValue
                roundedResult = Math.Round(rawResult, roundingDigits)
                lblResults.Text = $"{leftValue}/{rightValue}={roundedResult}"
            End If
        Catch ex As Exception
            lblResults.Text = ex.Message
        End Try
        lblResults.Text += vbCr + last
    End Sub
End Class