Public Class Playsettings

    Public DifficultyValue As Integer
    Dim MathsQuestions As Boolean

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        LosingScreen.FromMainMenu = False
        Tetris.Show()
        Tetris.ShowMathsQuestions = MathsQuestions
        Me.Hide()
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        MainMenu.Timer1.Enabled = True
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub CustomizationButton_Click(sender As Object, e As EventArgs) Handles CustomizationButton.Click
        MainMenu.ComeFromPlaySettings = True
        Me.Close()
        Customization.Show()
    End Sub

    Private Sub Playsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each Component In Controls
            Component.ForeColor = MainMenu.FontColour
        Next

        Me.BackColor = MainMenu.BackColour
        Back.BackColor = MainMenu.ButtonColour
        Back.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        Back.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour
        Start.BackColor = MainMenu.ButtonColour
        Start.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        Start.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour
        CustomizationButton.BackColor = MainMenu.ButtonColour
        CustomizationButton.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        CustomizationButton.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour
        SelectedDifficulty.BackColor = MainMenu.ButtonColour

        SelectedDifficulty.Text = "Normal"

    End Sub

    Private Sub MathsQnsChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles MathsQnsChkBox.CheckedChanged

        If MathsQuestions = True Then
            MathsQuestions = False
        Else
            MathsQuestions = True
        End If

    End Sub

    Private Sub DifficultyTrackBar_Scroll(sender As Object, e As EventArgs) Handles DifficultyTrackBar.Scroll

        DifficultyValue = DifficultyTrackBar.Value

        Select Case DifficultyValue
            Case 1
                SelectedDifficulty.Text = "Very Easy"
            Case 2
                SelectedDifficulty.Text = "Easy"
            Case 3
                SelectedDifficulty.Text = "Normal"
            Case 4
                SelectedDifficulty.Text = "Hard"
            Case 5
                SelectedDifficulty.Text = "Very Hard"
        End Select

    End Sub
End Class