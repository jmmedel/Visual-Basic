Public Class Form1
    Private WithEvents Tmr As New Timer With {.Interval = 50}
    Private StartLocation As Integer = 20

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Button1.Text = "Start"
        Label1.Text = "神戸電子専門学校"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Tmr.Enabled Then

            Tmr.Stop()
                Button1.Text = "Start"
            Label1.Text = "神戸電子専門学校"
        Else

            Button1.Text = "Stop"
                Using g As Graphics = Label1.CreateGraphics
                StartLocation = -CInt(g.MeasureString(Label1.Text, Label1.Font).Width)
            End Using
            Label1.Text = "神戸電子専門学校"
            Label1.Left = StartLocation
                Tmr.Start()
            End If

    End Sub

    Private Sub Tmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Tmr.Tick
        Label1.Left += 3

        If Label1.Left > Me.ClientSize.Width Then Label1.Left = StartLocation
    End Sub
End Class