Public Class frmCollegeAdmissions
  Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
    Dim gpa, sum1, sum2 As Double

    If Double.TryParse(txtGPAScore.Text, gpa) Then
      If gpa >= 2 And gpa <= 4 Then

        For Each rad In grpSAT.Controls.OfType(Of RadioButton)
          If rad.Checked
            sum1 += CInt(rad.Tag)
          End If
        Next

        For Each rad In grpHighSchool.Controls.OfType(Of RadioButton)
          If rad.Checked
            sum1 += CInt(rad.Tag)
          End If
        Next

        For Each rad In grpCurriculum.Controls.OfType(Of RadioButton)
          If rad.Checked
            sum1 += CInt(rad.Tag)
          End If
        Next

        For Each rad In grpEssay.Controls.OfType(Of RadioButton)
          If rad.Checked
            sum2 += CInt(rad.Tag)
          End If
        Next

        For Each rad In grpMisc.Controls.OfType(Of RadioButton)
          If rad.Checked
            sum2 += CInt(rad.Tag)
          End If
        Next

        For Each chk In grpGeography.Controls.OfType(Of CheckBox)
          If chk.Checked
            sum2 += CInt(chk.Tag)
          End If
        Next

        For Each chk In grpAlumni.Controls.OfType(Of CheckBox)
          If chk.Checked
            sum2 += CInt(chk.Tag)
          End If
        Next

        For Each chk In grpLeadership.Controls.OfType(Of CheckBox)
          If chk.Checked
            sum2 += CInt(chk.Tag)
          End If
        Next

        If sum2 > 40
          sum2 = 40
        End If

        Dim totalScore = sum1 + sum2 + (gpa * 20)
        Dim admitted as String

        if totalScore < 100
          admitted = "Not admitted"
          else
          admitted = "Admitted"
        End If
        
        txtOutput.Text = "Total Score: " & totalScore & vbNewLine & "Student is " & admitted

      Else
        MessageBox.Show("Invalid GPA", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
      End If
    Else
      MessageBox.Show("GPA must be in numberic format", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub
End Class
