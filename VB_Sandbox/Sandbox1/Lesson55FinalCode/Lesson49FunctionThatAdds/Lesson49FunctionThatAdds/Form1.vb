Imports MyClasses.Math
Public Class Form1
    Private Sub CmbOperations_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOperations.SelectedIndexChanged
        Dim last As String = lblResult.Text
        Try
            Dim leftValue = Double.Parse(txtLeftValue.Text)
            Dim rightValue = Double.Parse(txtRightValue.Text)
            Select Case cmbOperations.SelectedItem
                Case "Add"
                    lblResult.Text = $"Sum: {Add(leftValue, rightValue)}"
                Case "Subtract"
                    lblResult.Text = $"Difference: {Subtract(leftValue, rightValue)}"
                Case "Multiply"
                    lblResult.Text = $"Product: {Multiply(leftValue, rightValue)}"
                Case "Divide"
                    lblResult.Text = $"Quotient: {Divide(leftValue, rightValue)}"
            End Select
        Catch ex As Exception
            lblResult.Text = ex.StackTrace
        End Try
        If chkSaveOutput.Checked Then
            lblResult.Text += vbCr + last
        End If
    End Sub

    Private Sub TxtLeftValue_Enter(sender As Object, e As EventArgs) Handles txtLeftValue.Enter
        txtLeftValue.BackColor = Color.Yellow
    End Sub
    Private Sub TxtLeftValue_Leave(sender As Object, e As EventArgs) Handles txtLeftValue.Leave
        txtLeftValue.BackColor = Color.White
    End Sub

    Private Sub TxtRightValue_Enter(sender As Object, e As EventArgs) Handles txtRightValue.Enter
        txtRightValue.BackColor = Color.Yellow
    End Sub

    Private Sub TxtRightValue_Leave(sender As Object, e As EventArgs) Handles txtRightValue.Leave
        txtRightValue.BackColor = Color.White
    End Sub

    Private Sub CmbOperations_Enter(sender As Object, e As EventArgs) Handles cmbOperations.Enter
        cmbOperations.BackColor = Color.Yellow
    End Sub

    Private Sub CmbOperations_Leave(sender As Object, e As EventArgs) Handles cmbOperations.Leave
        cmbOperations.BackColor = Color.White
    End Sub

    Private Sub ChkSaveOutput_MouseEnter(sender As Object, e As EventArgs) Handles chkSaveOutput.MouseEnter
        ToolTip1.SetToolTip(chkSaveOutput, "Check to accumulate output. Uncheck to clear output.")
    End Sub
End Class