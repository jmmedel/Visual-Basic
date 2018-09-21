Public Class Form1
    Dim total As Integer = 0
    Dim lunch As Integer = 850
    Dim cake As Integer = 500
    Dim coffe As Integer = 300
    Dim cakeset As Integer = 650

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        CheckBox3.Enabled = True



        Label1.Text = "合計金額は" & total
        total = 0

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False

    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        PictureBox1.Visible = True
        CheckBox1.Enabled = True
        total += lunch
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        PictureBox2.Visible = True
        CheckBox2.Enabled = False
        If (CheckBox1.Checked) Then
            total += cake - 200
        ElseIf (CheckBox3.Checked) Then
            total += cakeset
        Else
            total += cake
        End If


    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        PictureBox3.Visible = True
        CheckBox3.Enabled = False
        If (CheckBox1.Checked) Then
            total += coffe - 200

        End If

        If (CheckBox2.Checked) Then

        End If
        total += coffe

    End Sub


End Class
