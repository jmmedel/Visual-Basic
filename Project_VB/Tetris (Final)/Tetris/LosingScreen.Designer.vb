<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LosingScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LosingScreen))
        Me.GameOverLabel = New System.Windows.Forms.Label()
        Me.GameOverLabel2 = New System.Windows.Forms.Label()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.YouUnlockedLabel = New System.Windows.Forms.Label()
        Me.UnlocksComboBox = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FinalScoreLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RowsLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PowerUpsUsedLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HighScoreLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.QuestionsCorrectLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GameOverLabel
        '
        Me.GameOverLabel.AutoSize = True
        Me.GameOverLabel.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameOverLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GameOverLabel.Location = New System.Drawing.Point(71, 14)
        Me.GameOverLabel.Name = "GameOverLabel"
        Me.GameOverLabel.Size = New System.Drawing.Size(193, 42)
        Me.GameOverLabel.TabIndex = 0
        Me.GameOverLabel.Text = "Game Over!"
        Me.GameOverLabel.Visible = False
        '
        'GameOverLabel2
        '
        Me.GameOverLabel2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameOverLabel2.Location = New System.Drawing.Point(29, 69)
        Me.GameOverLabel2.Name = "GameOverLabel2"
        Me.GameOverLabel2.Size = New System.Drawing.Size(270, 55)
        Me.GameOverLabel2.TabIndex = 1
        Me.GameOverLabel2.Text = "The blocks reached the top of the screen!"
        Me.GameOverLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainMenuButton
        '
        Me.MainMenuButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MainMenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.MainMenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.MainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MainMenuButton.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuButton.Location = New System.Drawing.Point(80, 484)
        Me.MainMenuButton.Name = "MainMenuButton"
        Me.MainMenuButton.Size = New System.Drawing.Size(176, 55)
        Me.MainMenuButton.TabIndex = 2
        Me.MainMenuButton.Text = "Main Menu"
        Me.MainMenuButton.UseVisualStyleBackColor = False
        '
        'YouUnlockedLabel
        '
        Me.YouUnlockedLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YouUnlockedLabel.Location = New System.Drawing.Point(43, 427)
        Me.YouUnlockedLabel.Name = "YouUnlockedLabel"
        Me.YouUnlockedLabel.Size = New System.Drawing.Size(123, 26)
        Me.YouUnlockedLabel.TabIndex = 3
        Me.YouUnlockedLabel.Text = "You unlocked:"
        Me.YouUnlockedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UnlocksComboBox
        '
        Me.UnlocksComboBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnlocksComboBox.FormattingEnabled = True
        Me.UnlocksComboBox.Location = New System.Drawing.Point(187, 429)
        Me.UnlocksComboBox.Name = "UnlocksComboBox"
        Me.UnlocksComboBox.Size = New System.Drawing.Size(112, 27)
        Me.UnlocksComboBox.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'FinalScoreLabel
        '
        Me.FinalScoreLabel.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalScoreLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FinalScoreLabel.Location = New System.Drawing.Point(80, 345)
        Me.FinalScoreLabel.Name = "FinalScoreLabel"
        Me.FinalScoreLabel.Size = New System.Drawing.Size(176, 59)
        Me.FinalScoreLabel.TabIndex = 10
        Me.FinalScoreLabel.Text = "20000"
        Me.FinalScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(294, 30)
        Me.Label4.TabIndex = 13
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RowsLabel
        '
        Me.RowsLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RowsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RowsLabel.Location = New System.Drawing.Point(192, 137)
        Me.RowsLabel.Name = "RowsLabel"
        Me.RowsLabel.Size = New System.Drawing.Size(109, 26)
        Me.RowsLabel.TabIndex = 17
        Me.RowsLabel.Text = "0"
        Me.RowsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(94, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 36)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Final Score"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 26)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Rows:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(294, 30)
        Me.Label6.TabIndex = 21
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(294, 30)
        Me.Label7.TabIndex = 22
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PowerUpsUsedLabel
        '
        Me.PowerUpsUsedLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PowerUpsUsedLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PowerUpsUsedLabel.Location = New System.Drawing.Point(192, 178)
        Me.PowerUpsUsedLabel.Name = "PowerUpsUsedLabel"
        Me.PowerUpsUsedLabel.Size = New System.Drawing.Size(109, 26)
        Me.PowerUpsUsedLabel.TabIndex = 24
        Me.PowerUpsUsedLabel.Text = "0"
        Me.PowerUpsUsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 26)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Power Ups Used:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HighScoreLabel
        '
        Me.HighScoreLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighScoreLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HighScoreLabel.Location = New System.Drawing.Point(192, 265)
        Me.HighScoreLabel.Name = "HighScoreLabel"
        Me.HighScoreLabel.Size = New System.Drawing.Size(109, 26)
        Me.HighScoreLabel.TabIndex = 26
        Me.HighScoreLabel.Text = "0"
        Me.HighScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 26)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "High Score:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'QuestionsCorrectLabel
        '
        Me.QuestionsCorrectLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionsCorrectLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.QuestionsCorrectLabel.Location = New System.Drawing.Point(192, 221)
        Me.QuestionsCorrectLabel.Name = "QuestionsCorrectLabel"
        Me.QuestionsCorrectLabel.Size = New System.Drawing.Size(109, 26)
        Me.QuestionsCorrectLabel.TabIndex = 29
        Me.QuestionsCorrectLabel.Text = "0"
        Me.QuestionsCorrectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 26)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Questions Correct:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(294, 30)
        Me.Label10.TabIndex = 27
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LosingScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(346, 570)
        Me.Controls.Add(Me.QuestionsCorrectLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.HighScoreLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PowerUpsUsedLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RowsLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FinalScoreLabel)
        Me.Controls.Add(Me.UnlocksComboBox)
        Me.Controls.Add(Me.YouUnlockedLabel)
        Me.Controls.Add(Me.MainMenuButton)
        Me.Controls.Add(Me.GameOverLabel2)
        Me.Controls.Add(Me.GameOverLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LosingScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Losing Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GameOverLabel As System.Windows.Forms.Label
    Friend WithEvents GameOverLabel2 As System.Windows.Forms.Label
    Friend WithEvents MainMenuButton As System.Windows.Forms.Button
    Friend WithEvents YouUnlockedLabel As System.Windows.Forms.Label
    Friend WithEvents UnlocksComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents FinalScoreLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RowsLabel As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PowerUpsUsedLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HighScoreLabel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents QuestionsCorrectLabel As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
