Public Class frmRestaurantBill
  Const pizzaPrice as Double = 1.75
  Const friesPrice as Double = 2.0
  Const drinkPrice as Double = 1.25

  Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lstDisplay.Items.Clear()
        Dim pizza, fries, drinks As Integer
        Dim total as Double

    If Integer.TryParse(txtPizza.Text, pizza) And Integer.TryParse(txtFries.Text, fries) And Integer.TryParse(txtDrinks.Text, drinks)
      total = Calculate(pizza, fries, drinks)
      displayBill(pizza, fries, drinks, total)
    Else 
      MessageBox.Show("Please correct your input","Invalid input",MessageBoxButtons.OK, MessageBoxIcon.Error)
    End If
  End Sub

  Function Calculate(pizza As Integer, fries As Integer, drinks As Integer) As Double
    dim total as Double

    total = (pizza * pizzaPrice) + (fries * friesPrice) + (drinks * drinkPrice)

    return total
  End Function

  Private Sub displayBill(pizza As Integer, fries As Integer, drinks As Integer, total As Double)
    lstDisplay.Items.Add("ITEM" + vbTab + "     QUANTITY" + vbTab + "PRICE")

    If pizza > 0
      lstDisplay.Items.Add("Pizza" + vbTab + vbTab + pizza.ToString() + vbTab + FormatCurrency(pizza * pizzaPrice))
    End If

    If fries > 0
      lstDisplay.Items.Add("Fries" + vbTab + vbTab + fries.ToString() + vbTab + FormatCurrency(fries * friesPrice))
    End If

    If drinks > 0
      lstDisplay.Items.Add("Drinks" + vbTab + vbTab + drinks.ToString() + vbTab + FormatCurrency(drinks * drinkPrice))
    End If

    lstDisplay.Items.Add("TOTAL: " +vbTab + FormatCurrency(total))
  End Sub
End Class
