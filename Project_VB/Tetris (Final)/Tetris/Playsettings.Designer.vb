<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Playsettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Playsettings))
        Me.DifficultyTrackBar = New System.Windows.Forms.TrackBar()
        Me.Start = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SelectADifficultyLabel = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SelectedDifficulty = New System.Windows.Forms.Label()
        Me.Difficulty = New System.Windows.Forms.Label()
        Me.CustomizationButton = New System.Windows.Forms.Button()
        Me.MathsQnsChkBox = New System.Windows.Forms.CheckBox()
        CType(Me.DifficultyTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DifficultyTrackBar
        '
        Me.DifficultyTrackBar.Location = New System.Drawing.Point(35, 42)
        Me.DifficultyTrackBar.Maximum = 5
        Me.DifficultyTrackBar.Minimum = 1
        Me.DifficultyTrackBar.Name = "DifficultyTrackBar"
        Me.DifficultyTrackBar.Size = New System.Drawing.Size(220, 45)
        Me.DifficultyTrackBar.TabIndex = 0
        Me.DifficultyTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.DifficultyTrackBar.Value = 3
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Start.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start.Location = New System.Drawing.Point(27, 234)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(229, 55)
        Me.Start.TabIndex = 1
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(139, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(187, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(234, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "5"
        '
        'SelectADifficultyLabel
        '
        Me.SelectADifficultyLabel.AutoSize = True
        Me.SelectADifficultyLabel.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectADifficultyLabel.Location = New System.Drawing.Point(60, 14)
        Me.SelectADifficultyLabel.Name = "SelectADifficultyLabel"
        Me.SelectADifficultyLabel.Size = New System.Drawing.Size(162, 26)
        Me.SelectADifficultyLabel.TabIndex = 8
        Me.SelectADifficultyLabel.Text = "Select A Difficulty"
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Back.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(27, 304)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(78, 30)
        Me.Back.TabIndex = 12
        Me.Back.Text = "← Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 32)
        Me.Label6.TabIndex = 13
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SelectedDifficulty
        '
        Me.SelectedDifficulty.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SelectedDifficulty.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SelectedDifficulty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SelectedDifficulty.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectedDifficulty.Location = New System.Drawing.Point(131, 108)
        Me.SelectedDifficulty.Name = "SelectedDifficulty"
        Me.SelectedDifficulty.Size = New System.Drawing.Size(113, 23)
        Me.SelectedDifficulty.TabIndex = 15
        Me.SelectedDifficulty.Text = "SelectedDifficulty"
        Me.SelectedDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Difficulty
        '
        Me.Difficulty.AutoSize = True
        Me.Difficulty.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Difficulty.Location = New System.Drawing.Point(39, 107)
        Me.Difficulty.Name = "Difficulty"
        Me.Difficulty.Size = New System.Drawing.Size(89, 26)
        Me.Difficulty.TabIndex = 14
        Me.Difficulty.Text = "Difficulty"
        '
        'CustomizationButton
        '
        Me.CustomizationButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CustomizationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CustomizationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.CustomizationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.CustomizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomizationButton.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.CustomizationButton.Location = New System.Drawing.Point(27, 185)
        Me.CustomizationButton.Name = "CustomizationButton"
        Me.CustomizationButton.Size = New System.Drawing.Size(227, 38)
        Me.CustomizationButton.TabIndex = 16
        Me.CustomizationButton.Text = "Customization"
        Me.CustomizationButton.UseVisualStyleBackColor = False
        '
        'MathsQnsChkBox
        '
        Me.MathsQnsChkBox.AutoSize = True
        Me.MathsQnsChkBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.MathsQnsChkBox.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MathsQnsChkBox.Location = New System.Drawing.Point(59, 150)
        Me.MathsQnsChkBox.Name = "MathsQnsChkBox"
        Me.MathsQnsChkBox.Size = New System.Drawing.Size(161, 27)
        Me.MathsQnsChkBox.TabIndex = 17
        Me.MathsQnsChkBox.Text = "Maths Questions"
        Me.MathsQnsChkBox.UseVisualStyleBackColor = True
        '
        'Playsettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 356)
        Me.Controls.Add(Me.MathsQnsChkBox)
        Me.Controls.Add(Me.CustomizationButton)
        Me.Controls.Add(Me.SelectedDifficulty)
        Me.Controls.Add(Me.Difficulty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.SelectADifficultyLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.DifficultyTrackBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Playsettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Play Settings"
        CType(Me.DifficultyTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DifficultyTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SelectADifficultyLabel As System.Windows.Forms.Label
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SelectedDifficulty As System.Windows.Forms.Label
    Friend WithEvents Difficulty As System.Windows.Forms.Label
    Friend WithEvents CustomizationButton As System.Windows.Forms.Button
    Friend WithEvents MathsQnsChkBox As System.Windows.Forms.CheckBox
End Class
