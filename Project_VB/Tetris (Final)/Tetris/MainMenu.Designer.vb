<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ExitProgram = New System.Windows.Forms.Button()
        Me.SignOutButton = New System.Windows.Forms.Button()
        Me.InstructionsButton = New System.Windows.Forms.Button()
        Me.ProgressButton = New System.Windows.Forms.Button()
        Me.CustomizationButton = New System.Windows.Forms.Button()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.SpeakerButton = New System.Windows.Forms.Button()
        Me.RandSongButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'ExitProgram
        '
        Me.ExitProgram.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExitProgram.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ExitProgram.FlatAppearance.BorderSize = 2
        Me.ExitProgram.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.ExitProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.ExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitProgram.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.ExitProgram.Location = New System.Drawing.Point(177, 584)
        Me.ExitProgram.Name = "ExitProgram"
        Me.ExitProgram.Size = New System.Drawing.Size(200, 50)
        Me.ExitProgram.TabIndex = 19
        Me.ExitProgram.Text = "Exit"
        Me.ExitProgram.UseVisualStyleBackColor = False
        '
        'SignOutButton
        '
        Me.SignOutButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SignOutButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SignOutButton.FlatAppearance.BorderSize = 2
        Me.SignOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.SignOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.SignOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignOutButton.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.SignOutButton.Location = New System.Drawing.Point(177, 494)
        Me.SignOutButton.Name = "SignOutButton"
        Me.SignOutButton.Size = New System.Drawing.Size(200, 50)
        Me.SignOutButton.TabIndex = 18
        Me.SignOutButton.Text = "Sign Out"
        Me.SignOutButton.UseVisualStyleBackColor = False
        '
        'InstructionsButton
        '
        Me.InstructionsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InstructionsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.InstructionsButton.FlatAppearance.BorderSize = 2
        Me.InstructionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.InstructionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.InstructionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InstructionsButton.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.InstructionsButton.Location = New System.Drawing.Point(177, 314)
        Me.InstructionsButton.Name = "InstructionsButton"
        Me.InstructionsButton.Size = New System.Drawing.Size(200, 50)
        Me.InstructionsButton.TabIndex = 17
        Me.InstructionsButton.Text = "Instructions"
        Me.InstructionsButton.UseVisualStyleBackColor = False
        '
        'ProgressButton
        '
        Me.ProgressButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressButton.Cursor = System.Windows.Forms.Cursors.Default
        Me.ProgressButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ProgressButton.FlatAppearance.BorderSize = 2
        Me.ProgressButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.ProgressButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.ProgressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProgressButton.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.ProgressButton.Location = New System.Drawing.Point(177, 224)
        Me.ProgressButton.Name = "ProgressButton"
        Me.ProgressButton.Size = New System.Drawing.Size(200, 50)
        Me.ProgressButton.TabIndex = 16
        Me.ProgressButton.Text = "Progress"
        Me.ProgressButton.UseVisualStyleBackColor = False
        '
        'CustomizationButton
        '
        Me.CustomizationButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CustomizationButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.CustomizationButton.FlatAppearance.BorderSize = 2
        Me.CustomizationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.CustomizationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.CustomizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomizationButton.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.CustomizationButton.Location = New System.Drawing.Point(177, 134)
        Me.CustomizationButton.Name = "CustomizationButton"
        Me.CustomizationButton.Size = New System.Drawing.Size(200, 50)
        Me.CustomizationButton.TabIndex = 15
        Me.CustomizationButton.Text = "Customization"
        Me.CustomizationButton.UseVisualStyleBackColor = False
        '
        'PlayButton
        '
        Me.PlayButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PlayButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.PlayButton.FlatAppearance.BorderSize = 2
        Me.PlayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.PlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayButton.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.PlayButton.Location = New System.Drawing.Point(177, 44)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(200, 50)
        Me.PlayButton.TabIndex = 14
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = False
        '
        'SpeakerButton
        '
        Me.SpeakerButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SpeakerButton.BackgroundImage = CType(resources.GetObject("SpeakerButton.BackgroundImage"), System.Drawing.Image)
        Me.SpeakerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SpeakerButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SpeakerButton.FlatAppearance.BorderSize = 2
        Me.SpeakerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.SpeakerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.SpeakerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpeakerButton.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.SpeakerButton.Location = New System.Drawing.Point(319, 404)
        Me.SpeakerButton.Name = "SpeakerButton"
        Me.SpeakerButton.Size = New System.Drawing.Size(58, 50)
        Me.SpeakerButton.TabIndex = 20
        Me.SpeakerButton.UseVisualStyleBackColor = False
        '
        'RandSongButton
        '
        Me.RandSongButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RandSongButton.BackgroundImage = CType(resources.GetObject("RandSongButton.BackgroundImage"), System.Drawing.Image)
        Me.RandSongButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RandSongButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RandSongButton.FlatAppearance.BorderSize = 2
        Me.RandSongButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.RandSongButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.RandSongButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RandSongButton.Font = New System.Drawing.Font("Calibri", 16.0!)
        Me.RandSongButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RandSongButton.Location = New System.Drawing.Point(177, 404)
        Me.RandSongButton.Name = "RandSongButton"
        Me.RandSongButton.Size = New System.Drawing.Size(136, 50)
        Me.RandSongButton.TabIndex = 21
        Me.RandSongButton.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(554, 676)
        Me.Controls.Add(Me.RandSongButton)
        Me.Controls.Add(Me.SpeakerButton)
        Me.Controls.Add(Me.ExitProgram)
        Me.Controls.Add(Me.SignOutButton)
        Me.Controls.Add(Me.InstructionsButton)
        Me.Controls.Add(Me.ProgressButton)
        Me.Controls.Add(Me.CustomizationButton)
        Me.Controls.Add(Me.PlayButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ExitProgram As System.Windows.Forms.Button
    Friend WithEvents SignOutButton As System.Windows.Forms.Button
    Friend WithEvents InstructionsButton As System.Windows.Forms.Button
    Friend WithEvents ProgressButton As System.Windows.Forms.Button
    Friend WithEvents CustomizationButton As System.Windows.Forms.Button
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents SpeakerButton As System.Windows.Forms.Button
    Friend WithEvents RandSongButton As System.Windows.Forms.Button
End Class
