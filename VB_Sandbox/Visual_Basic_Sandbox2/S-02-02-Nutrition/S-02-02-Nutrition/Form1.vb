Public Class FrmNutrition
  Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
    Const fatCaloriesPerGram = 9
    Dim food as String = txtNameOfFood.Text
    Dim AHAapproved as String
    Dim caloriesPerServing, gramsOfFatPerServing, totalCaloriesFromFat as Integer
    Dim percentCaloriesFromFat as Double

    If food <> "" And Integer.TryParse(txtCaloriesPerServing.Text, caloriesPerServing) And Integer.TryParse(txtGramsOfFat.Text,gramsOfFatPerServing)

      totalCaloriesFromFat = gramsOfFatPerServing * fatCaloriesPerGram
      percentCaloriesFromFat = totalCaloriesFromFat / caloriesPerServing

      If percentCaloriesFromFat < 0.3
        AHAapproved = "AHA Approved"
      Else 
        AHAapproved = "NOT AHA Approved"
      End If

      txtDisplay.Text = food & " contains " & FormatPercent(percentCaloriesFromFat,2) & " calories from fat." & vbNewLine &
        "It is " & AHAapproved & "."

    Else 
      MessageBox.Show("Please enter valid input", "Invalid Input",MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End If
  End Sub
End Class
