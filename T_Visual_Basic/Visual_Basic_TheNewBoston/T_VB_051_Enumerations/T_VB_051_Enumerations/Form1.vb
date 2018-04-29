Public Class Form1

    Private Enum DayAction As Integer
        Awake = 0
        Asleep = 1
        coding = 2
    End Enum

    Private action As DayAction = DayAction.Asleep

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(action.ToString())

    End Sub

End Class
