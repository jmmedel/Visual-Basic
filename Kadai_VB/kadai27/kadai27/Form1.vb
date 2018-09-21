Public Class Form1
    Dim total As Double = 0
    Dim hoteltotal As Integer = 0
    Dim optionaltotal As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RadioButton1.Checked) Then
            total += 125000
        ElseIf (RadioButton2.Checked) Then
            total += 130000
        ElseIf (RadioButton3.Checked) Then
            total += 135000
        ElseIf (RadioButton4.Checked) Then
            total += 140000
        End If

        If (RadioButton5.Checked) Then

        ElseIf (RadioButton6.Checked) Then

            hoteltotal += 25000
        End If


        If (CheckBox1.Checked) Then
            optionaltotal += 25000
        ElseIf (CheckBox2.Checked) Then
            optionaltotal += 6000
        ElseIf (CheckBox3.Checked) Then
            optionaltotal += 10000
        ElseIf (CheckBox4.Checked) Then
            optionaltotal += 15000

        End If
        total += optionaltotal + hoteltotal
        MsgBox("合計" & total)
        total = 0
        optionaltotal = 0
        hoteltotal = 0


    End Sub



End Class
