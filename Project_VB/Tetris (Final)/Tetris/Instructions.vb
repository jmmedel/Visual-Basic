Public Class Instructions

    Public InstructionsFromMainMenu As Boolean = True

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click

        If InstructionsFromMainMenu = True Then
            MainMenu.Show()
        End If

        Me.Close()

    End Sub

    Private Sub Instructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each Component In Controls
            Component.ForeColor = MainMenu.FontColour
        Next

        Me.BackColor = MainMenu.BackColour
        Back.BackColor = MainMenu.ButtonColour
        Back.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        Back.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour

        InstrText.BackColor = MainMenu.InstructionsColour
        PowerUpsText.BackColor = MainMenu.InstructionsColour
        MathsQnsText.BackColor = MainMenu.InstructionsColour
        ControlsTable.BackColor = MainMenu.InstructionsColour
        ArrowKeyLabel.BackColor = MainMenu.InstructionsColour
        LeftLabel.BackColor = MainMenu.InstructionsColour
        RightLabel.BackColor = MainMenu.InstructionsColour
        DownLabel.BackColor = MainMenu.InstructionsColour
        UpLabel.BackColor = MainMenu.InstructionsColour
        ActionLabel.BackColor = MainMenu.InstructionsColour
        LeftActLabel.BackColor = MainMenu.InstructionsColour
        RightActLabel.BackColor = MainMenu.InstructionsColour
        UpActLabel.BackColor = MainMenu.InstructionsColour
        DownActLabel.BackColor = MainMenu.InstructionsColour
    End Sub
End Class