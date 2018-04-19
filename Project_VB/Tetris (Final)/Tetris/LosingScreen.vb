Public Class LosingScreen

    Dim Timer1Count As Integer
    Public FromMainMenu As Boolean = True
    Public UsersPrevHighScore As Integer = 700

    Private Sub MainMenuButton_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        MainMenu.Timer1.Enabled = True
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If GameOverLabel.Visible = True Then
            GameOverLabel.Visible = False
        Else
            GameOverLabel.Visible = True
        End If

        If UnlocksComboBox.SelectedItem = ("Landscape") Then
            If UnlocksComboBox.Items.Contains("Space") Then
                UnlocksComboBox.SelectedItem = ("Space")
            Else
                UnlocksComboBox.SelectedItem = ("Landscape")
            End If
        ElseIf UnlocksComboBox.SelectedItem = ("Space") Then
            If UnlocksComboBox.Items.Contains("Tetris") Then
                UnlocksComboBox.SelectedItem = ("Tetris")
            ElseIf UnlocksComboBox.Items.Contains("Landscape") Then
                UnlocksComboBox.SelectedItem = ("Landscape")
            Else
                UnlocksComboBox.SelectedItem = ("Space")
            End If
        ElseIf UnlocksComboBox.SelectedItem = ("Tetris") Then
            If UnlocksComboBox.Items.Contains("Landscape") Then
                UnlocksComboBox.SelectedItem = ("Landscape")
            ElseIf UnlocksComboBox.Items.Contains("Space") Then
                UnlocksComboBox.SelectedItem = ("Space")
            Else
                UnlocksComboBox.SelectedItem = ("Tetris")
            End If
        End If

    End Sub

    Private Sub LosingScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If FinalScoreLabel.Text > 999 And UsersPrevHighScore < 1000 Then
            UnlocksComboBox.Items.Add("Landscape")
            UnlocksComboBox.SelectedItem = ("Landscape")
        End If

        If FinalScoreLabel.Text > 4999 And UsersPrevHighScore < 5000 Then
            UnlocksComboBox.Items.Add("Space")
            UnlocksComboBox.SelectedItem = ("Space")
        End If

        If FinalScoreLabel.Text > 9999 And UsersPrevHighScore < 10000 Then
            UnlocksComboBox.Items.Add("Tetris")
            UnlocksComboBox.SelectedItem = ("Tetris")
        End If


        For Each Component In Controls
            Component.ForeColor = MainMenu.FontColour
        Next

        Me.BackColor = MainMenu.BackColour
        MainMenuButton.BackColor = MainMenu.ButtonColour
        MainMenuButton.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        MainMenuButton.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour

        If MainMenu.Male = True Then
            RowsLabel.ForeColor = MainMenu.ButtonColour
            PowerUpsUsedLabel.ForeColor = MainMenu.ButtonColour
            FinalScoreLabel.ForeColor = MainMenu.ButtonColour
            HighScoreLabel.ForeColor = MainMenu.ButtonColour
            GameOverLabel.ForeColor = MainMenu.ButtonColour
            QuestionsCorrectLabel.ForeColor = MainMenu.ButtonColour
        Else
            RowsLabel.ForeColor = Color.Lime
            PowerUpsUsedLabel.ForeColor = Color.Lime
            FinalScoreLabel.ForeColor = Color.Lime
            HighScoreLabel.ForeColor = Color.Lime
            GameOverLabel.ForeColor = Color.Lime
            QuestionsCorrectLabel.ForeColor = Color.Lime
        End If


    End Sub

End Class