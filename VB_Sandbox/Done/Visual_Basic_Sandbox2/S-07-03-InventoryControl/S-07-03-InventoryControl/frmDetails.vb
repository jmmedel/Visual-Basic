Public Class frmDetails
  Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
    If txtTitle.Text = "" Or txtAuthor.Text = "" Or txtStock.Text = "" Or txtPrice.Text = "" Then
      MessageBox.Show("You must enter the title, author, stock and price.")
    Else 
      If frmBooks.flagNewBook Then
        ReDim Preserve frmBooks.books(frmBooks.numOfBooks)
        frmBooks.books(frmBooks.numOfBooks).title = txtTitle.Text
        frmBooks.books(frmBooks.numOfBooks).author = txtAuthor.Text
        frmBooks.books(frmBooks.numOfBooks).stock = CInt(txtStock.Text)
        frmBooks.books(frmBooks.numOfBooks).price = CDbl(txtPrice.Text)
        If radFiction.Checked Then
          frmBooks.books(frmBooks.numOfBooks).category = "F"
        Else 
          frmBooks.books(frmBooks.numOfBooks).category = "N"
        End If
        frmBooks.numOfBooks += 1
      Else
        frmBooks.books(frmBooks.n).title = txtTitle.Text
        frmBooks.books(frmBooks.n).author = txtAuthor.Text
        frmBooks.books(frmBooks.n).stock = CInt(txtStock.Text)
        frmBooks.books(frmBooks.n).price = CDbl(txtPrice.Text)
        If radFiction.Checked Then
          frmBooks.books(frmBooks.n).category = "F"
        Else 
          frmBooks.books(frmBooks.n).category = "N"
        End If
      End If
    End If

    Close()
  End Sub
End Class