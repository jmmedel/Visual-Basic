Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Select Case ComboBox1.SelectedItem
            Case "One"
                Label2.Text = "単語はoneです"
                Label3.Text = "読み方はフォームは　ワン"
            Case "Two"
                Label2.Text = "単語はtwoです"
                Label3.Text = "読み方はフォームは　トゥー"
            Case "Three"
                Label2.Text = "単語はthreeです"
                Label3.Text = "読み方はフォームは　スリー"
            Case "Four"
                Label2.Text = "単語はfourです"
                Label3.Text = "読み方はフォームは　フォー"
            Case "Five"
                Label2.Text = "単語はfiveです"
                Label3.Text = "読み方はフォームは　ファイブ"
            Case "Six"
                Label2.Text = "単語はsixです"
                Label3.Text = "読み方はフォームは　シックス"
            Case "Seven"
                Label2.Text = "単語はsevenです"
                Label3.Text = "読み方はフォームは　セブン"
            Case "Eight"
                Label2.Text = "単語はeightです"
                Label3.Text = "読み方はフォームは　エィト"
            Case "Nine"
                Label2.Text = "単語はnineです"
                Label3.Text = "読み方はフォームは　ナイン"

            Case "Ten"
                Label2.Text = "単語はtenです"
                Label3.Text = "読み方はフォームは　テン"
        End Select








    End Sub
End Class
