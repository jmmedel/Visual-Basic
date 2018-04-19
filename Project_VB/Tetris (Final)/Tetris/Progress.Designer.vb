<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Progress
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Progress))
        Me.Back = New System.Windows.Forms.Button()
        Me.UnlockNameLabel = New System.Windows.Forms.Label()
        Me.NextUnlock = New System.Windows.Forms.Label()
        Me.LeaderboardTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Name5 = New System.Windows.Forms.Label()
        Me.HighScoreLabel = New System.Windows.Forms.Label()
        Me.PlayerNameLabel = New System.Windows.Forms.Label()
        Me.HighScore1 = New System.Windows.Forms.Label()
        Me.HighScore2 = New System.Windows.Forms.Label()
        Me.HighScore3 = New System.Windows.Forms.Label()
        Me.HighScore4 = New System.Windows.Forms.Label()
        Me.HighScore5 = New System.Windows.Forms.Label()
        Me.Name1 = New System.Windows.Forms.Label()
        Me.Name2 = New System.Windows.Forms.Label()
        Me.Name3 = New System.Windows.Forms.Label()
        Me.Name4 = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.CurrentScoreBar = New System.Windows.Forms.ProgressBar()
        Me.DashLabel2 = New System.Windows.Forms.Label()
        Me.DashLabel1 = New System.Windows.Forms.Label()
        Me.MaxScoreLabel = New System.Windows.Forms.Label()
        Me.MinScoreLabel = New System.Windows.Forms.Label()
        Me.CurrentScoreLabel = New System.Windows.Forms.Label()
        Me.LeaderboardTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Back.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(37, 392)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(78, 32)
        Me.Back.TabIndex = 0
        Me.Back.Text = "← Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'UnlockNameLabel
        '
        Me.UnlockNameLabel.AutoSize = True
        Me.UnlockNameLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnlockNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UnlockNameLabel.Location = New System.Drawing.Point(237, 145)
        Me.UnlockNameLabel.Name = "UnlockNameLabel"
        Me.UnlockNameLabel.Size = New System.Drawing.Size(86, 26)
        Me.UnlockNameLabel.TabIndex = 23
        Me.UnlockNameLabel.Text = "(Unlock)"
        '
        'NextUnlock
        '
        Me.NextUnlock.AutoSize = True
        Me.NextUnlock.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextUnlock.Location = New System.Drawing.Point(98, 145)
        Me.NextUnlock.Name = "NextUnlock"
        Me.NextUnlock.Size = New System.Drawing.Size(120, 26)
        Me.NextUnlock.TabIndex = 22
        Me.NextUnlock.Text = "Next unlock:"
        '
        'LeaderboardTable
        '
        Me.LeaderboardTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.LeaderboardTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.LeaderboardTable.ColumnCount = 2
        Me.LeaderboardTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LeaderboardTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LeaderboardTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.LeaderboardTable.Controls.Add(Me.Name5, 0, 5)
        Me.LeaderboardTable.Controls.Add(Me.HighScoreLabel, 1, 0)
        Me.LeaderboardTable.Controls.Add(Me.PlayerNameLabel, 0, 0)
        Me.LeaderboardTable.Controls.Add(Me.HighScore1, 1, 1)
        Me.LeaderboardTable.Controls.Add(Me.HighScore2, 1, 2)
        Me.LeaderboardTable.Controls.Add(Me.HighScore3, 1, 3)
        Me.LeaderboardTable.Controls.Add(Me.HighScore4, 1, 4)
        Me.LeaderboardTable.Controls.Add(Me.HighScore5, 1, 5)
        Me.LeaderboardTable.Controls.Add(Me.Name1, 0, 1)
        Me.LeaderboardTable.Controls.Add(Me.Name2, 0, 2)
        Me.LeaderboardTable.Controls.Add(Me.Name3, 0, 3)
        Me.LeaderboardTable.Controls.Add(Me.Name4, 0, 4)
        Me.LeaderboardTable.Location = New System.Drawing.Point(34, 209)
        Me.LeaderboardTable.Name = "LeaderboardTable"
        Me.LeaderboardTable.RowCount = 6
        Me.LeaderboardTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.9434!))
        Me.LeaderboardTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.0566!))
        Me.LeaderboardTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.LeaderboardTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.LeaderboardTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.LeaderboardTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.LeaderboardTable.Size = New System.Drawing.Size(348, 161)
        Me.LeaderboardTable.TabIndex = 21
        '
        'Name5
        '
        Me.Name5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name5.Location = New System.Drawing.Point(4, 132)
        Me.Name5.Name = "Name5"
        Me.Name5.Size = New System.Drawing.Size(166, 23)
        Me.Name5.TabIndex = 34
        Me.Name5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HighScoreLabel
        '
        Me.HighScoreLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighScoreLabel.Location = New System.Drawing.Point(177, 1)
        Me.HighScoreLabel.Name = "HighScoreLabel"
        Me.HighScoreLabel.Size = New System.Drawing.Size(166, 23)
        Me.HighScoreLabel.TabIndex = 16
        Me.HighScoreLabel.Text = "High Score"
        Me.HighScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayerNameLabel
        '
        Me.PlayerNameLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerNameLabel.Location = New System.Drawing.Point(4, 1)
        Me.PlayerNameLabel.Name = "PlayerNameLabel"
        Me.PlayerNameLabel.Size = New System.Drawing.Size(166, 23)
        Me.PlayerNameLabel.TabIndex = 17
        Me.PlayerNameLabel.Text = "Name"
        Me.PlayerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HighScore1
        '
        Me.HighScore1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighScore1.Location = New System.Drawing.Point(177, 25)
        Me.HighScore1.Name = "HighScore1"
        Me.HighScore1.Size = New System.Drawing.Size(166, 23)
        Me.HighScore1.TabIndex = 25
        Me.HighScore1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HighScore2
        '
        Me.HighScore2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighScore2.Location = New System.Drawing.Point(177, 49)
        Me.HighScore2.Name = "HighScore2"
        Me.HighScore2.Size = New System.Drawing.Size(166, 23)
        Me.HighScore2.TabIndex = 26
        Me.HighScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HighScore3
        '
        Me.HighScore3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighScore3.Location = New System.Drawing.Point(177, 77)
        Me.HighScore3.Name = "HighScore3"
        Me.HighScore3.Size = New System.Drawing.Size(166, 23)
        Me.HighScore3.TabIndex = 27
        Me.HighScore3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HighScore4
        '
        Me.HighScore4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighScore4.Location = New System.Drawing.Point(177, 104)
        Me.HighScore4.Name = "HighScore4"
        Me.HighScore4.Size = New System.Drawing.Size(166, 23)
        Me.HighScore4.TabIndex = 28
        Me.HighScore4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HighScore5
        '
        Me.HighScore5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighScore5.Location = New System.Drawing.Point(177, 132)
        Me.HighScore5.Name = "HighScore5"
        Me.HighScore5.Size = New System.Drawing.Size(166, 23)
        Me.HighScore5.TabIndex = 29
        Me.HighScore5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Name1
        '
        Me.Name1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name1.Location = New System.Drawing.Point(4, 25)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(166, 23)
        Me.Name1.TabIndex = 30
        Me.Name1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Name2
        '
        Me.Name2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name2.Location = New System.Drawing.Point(4, 49)
        Me.Name2.Name = "Name2"
        Me.Name2.Size = New System.Drawing.Size(166, 23)
        Me.Name2.TabIndex = 31
        Me.Name2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Name3
        '
        Me.Name3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name3.Location = New System.Drawing.Point(4, 77)
        Me.Name3.Name = "Name3"
        Me.Name3.Size = New System.Drawing.Size(166, 23)
        Me.Name3.TabIndex = 32
        Me.Name3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Name4
        '
        Me.Name4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name4.Location = New System.Drawing.Point(4, 104)
        Me.Name4.Name = "Name4"
        Me.Name4.Size = New System.Drawing.Size(166, 23)
        Me.Name4.TabIndex = 33
        Me.Name4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(58, 13)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(302, 26)
        Me.TitleLabel.TabIndex = 20
        Me.TitleLabel.Text = "High score needed for next unlock"
        '
        'CurrentScoreBar
        '
        Me.CurrentScoreBar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CurrentScoreBar.Location = New System.Drawing.Point(34, 53)
        Me.CurrentScoreBar.Maximum = 10000
        Me.CurrentScoreBar.Name = "CurrentScoreBar"
        Me.CurrentScoreBar.Size = New System.Drawing.Size(348, 39)
        Me.CurrentScoreBar.TabIndex = 19
        Me.CurrentScoreBar.Value = 3000
        '
        'DashLabel2
        '
        Me.DashLabel2.AutoSize = True
        Me.DashLabel2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashLabel2.Location = New System.Drawing.Point(373, 85)
        Me.DashLabel2.Name = "DashLabel2"
        Me.DashLabel2.Size = New System.Drawing.Size(16, 19)
        Me.DashLabel2.TabIndex = 18
        Me.DashLabel2.Text = "|"
        '
        'DashLabel1
        '
        Me.DashLabel1.AutoSize = True
        Me.DashLabel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashLabel1.Location = New System.Drawing.Point(28, 86)
        Me.DashLabel1.Name = "DashLabel1"
        Me.DashLabel1.Size = New System.Drawing.Size(16, 19)
        Me.DashLabel1.TabIndex = 17
        Me.DashLabel1.Text = "|"
        '
        'MaxScoreLabel
        '
        Me.MaxScoreLabel.AutoSize = True
        Me.MaxScoreLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxScoreLabel.Location = New System.Drawing.Point(363, 106)
        Me.MaxScoreLabel.Name = "MaxScoreLabel"
        Me.MaxScoreLabel.Size = New System.Drawing.Size(41, 19)
        Me.MaxScoreLabel.TabIndex = 16
        Me.MaxScoreLabel.Text = "1000"
        '
        'MinScoreLabel
        '
        Me.MinScoreLabel.AutoSize = True
        Me.MinScoreLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinScoreLabel.Location = New System.Drawing.Point(28, 106)
        Me.MinScoreLabel.Name = "MinScoreLabel"
        Me.MinScoreLabel.Size = New System.Drawing.Size(17, 19)
        Me.MinScoreLabel.TabIndex = 15
        Me.MinScoreLabel.Text = "0"
        '
        'CurrentScoreLabel
        '
        Me.CurrentScoreLabel.AutoSize = True
        Me.CurrentScoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.CurrentScoreLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentScoreLabel.Location = New System.Drawing.Point(84, 118)
        Me.CurrentScoreLabel.Name = "CurrentScoreLabel"
        Me.CurrentScoreLabel.Size = New System.Drawing.Size(194, 26)
        Me.CurrentScoreLabel.TabIndex = 24
        Me.CurrentScoreLabel.Text = "You are currently on: "
        Me.CurrentScoreLabel.Visible = False
        '
        'Progress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(424, 446)
        Me.Controls.Add(Me.CurrentScoreLabel)
        Me.Controls.Add(Me.UnlockNameLabel)
        Me.Controls.Add(Me.NextUnlock)
        Me.Controls.Add(Me.LeaderboardTable)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.CurrentScoreBar)
        Me.Controls.Add(Me.DashLabel2)
        Me.Controls.Add(Me.DashLabel1)
        Me.Controls.Add(Me.MaxScoreLabel)
        Me.Controls.Add(Me.MinScoreLabel)
        Me.Controls.Add(Me.Back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Progress"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Progress"
        Me.LeaderboardTable.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents UnlockNameLabel As System.Windows.Forms.Label
    Friend WithEvents NextUnlock As System.Windows.Forms.Label
    Friend WithEvents LeaderboardTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents HighScoreLabel As System.Windows.Forms.Label
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents CurrentScoreBar As System.Windows.Forms.ProgressBar
    Friend WithEvents DashLabel2 As System.Windows.Forms.Label
    Friend WithEvents DashLabel1 As System.Windows.Forms.Label
    Friend WithEvents MaxScoreLabel As System.Windows.Forms.Label
    Friend WithEvents MinScoreLabel As System.Windows.Forms.Label
    Friend WithEvents PlayerNameLabel As System.Windows.Forms.Label
    Friend WithEvents HighScore1 As System.Windows.Forms.Label
    Friend WithEvents HighScore3 As System.Windows.Forms.Label
    Friend WithEvents HighScore4 As System.Windows.Forms.Label
    Friend WithEvents HighScore5 As System.Windows.Forms.Label
    Friend WithEvents HighScore2 As System.Windows.Forms.Label
    Friend WithEvents Name5 As System.Windows.Forms.Label
    Friend WithEvents Name1 As System.Windows.Forms.Label
    Friend WithEvents Name2 As System.Windows.Forms.Label
    Friend WithEvents Name3 As System.Windows.Forms.Label
    Friend WithEvents Name4 As System.Windows.Forms.Label
    Friend WithEvents CurrentScoreLabel As System.Windows.Forms.Label
End Class
