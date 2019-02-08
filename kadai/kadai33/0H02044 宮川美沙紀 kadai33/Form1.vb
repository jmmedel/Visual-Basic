Public Class Form1
    Dim list As List(Of Double) = New List(Of Double)
    Dim a, i, mid, cnt As Integer

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        If Integer.TryParse(ComboBox1.Text, a) Then
            Label4.Text = ""
            Button1.Enabled = True
        Else
            Label4.Text = "数値を入力してください"
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        i = 0
        Do Until i > list.Count - 1 OrElse list(i) > a
            i += 1
        Loop

        list.Insert(i, a)
        ComboBox1.Items.Insert(i, a)
        cnt = list.Count
        If cnt Mod 2 = 1 Then
            mid = list((cnt + 1) / 2 - 1)
        Else
            mid = (list(cnt / 2 - 1) + list(cnt / 2)) / 2
        End If

        Label2.Text = "データ数は" & list.Count & "個です。"
        Label3.Text = "中央値は" & mid & "です。"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        list.Clear()
        ComboBox1.Items.Clear()
        Label2.Text = "データ数は"
        Label3.Text = "中央値は"
    End Sub

End Class
