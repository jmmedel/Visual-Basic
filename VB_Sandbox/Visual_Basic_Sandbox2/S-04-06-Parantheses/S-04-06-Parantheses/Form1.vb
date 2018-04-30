Public Class frmParantheses
  Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
    Dim sentence As String = txtSentence.Text
    Dim startString, endString as Integer

    If sentence.Contains("(") And sentence.Contains(")") Then
      For i as Integer = 0 To sentence.Length -1
        If sentence.Substring(i,1) = "(" Then
          startString = i
        ElseIf sentence.Substring(i,1) = ")" Then
          endString = i
        End If
      Next

      txtOutput.Text = sentence.Substring(0,startString) & sentence.Substring(endString + 1)
    Else
      MessageBox.Show("The sentence does not contain () characters","Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub
End Class
