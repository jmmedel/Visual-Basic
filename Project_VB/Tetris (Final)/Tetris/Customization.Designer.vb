<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customization
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customization))
        Me.Back = New System.Windows.Forms.Button()
        Me.ColourLabel1 = New System.Windows.Forms.Label()
        Me.TetrisThemeBox = New System.Windows.Forms.PictureBox()
        Me.SpaceThemeBox = New System.Windows.Forms.PictureBox()
        Me.ThemePictureBox2a = New System.Windows.Forms.PictureBox()
        Me.DefaultThemeBox = New System.Windows.Forms.PictureBox()
        Me.BackColourBox = New System.Windows.Forms.ComboBox()
        Me.ColourPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ButtonColourBox = New System.Windows.Forms.ComboBox()
        Me.ColourLabel2 = New System.Windows.Forms.Label()
        Me.ColourPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ColourPictureBox3 = New System.Windows.Forms.PictureBox()
        Me.FontColourBox = New System.Windows.Forms.ComboBox()
        Me.ColourLabel3 = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.DefaultTheme = New System.Windows.Forms.RadioButton()
        Me.LandscapeTheme = New System.Windows.Forms.RadioButton()
        Me.SpaceTheme = New System.Windows.Forms.RadioButton()
        Me.TetrisTheme = New System.Windows.Forms.RadioButton()
        Me.NoThemeLabel = New System.Windows.Forms.RadioButton()
        CType(Me.TetrisThemeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaceThemeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ThemePictureBox2a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefaultThemeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColourPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColourPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColourPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Back.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(45, 484)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(78, 32)
        Me.Back.TabIndex = 1
        Me.Back.Text = "← Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'ColourLabel1
        '
        Me.ColourLabel1.AutoSize = True
        Me.ColourLabel1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColourLabel1.Location = New System.Drawing.Point(41, 43)
        Me.ColourLabel1.Name = "ColourLabel1"
        Me.ColourLabel1.Size = New System.Drawing.Size(160, 23)
        Me.ColourLabel1.TabIndex = 2
        Me.ColourLabel1.Text = "Background colour:"
        '
        'TetrisThemeBox
        '
        Me.TetrisThemeBox.BackgroundImage = CType(resources.GetObject("TetrisThemeBox.BackgroundImage"), System.Drawing.Image)
        Me.TetrisThemeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TetrisThemeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TetrisThemeBox.Location = New System.Drawing.Point(180, 414)
        Me.TetrisThemeBox.Name = "TetrisThemeBox"
        Me.TetrisThemeBox.Size = New System.Drawing.Size(182, 52)
        Me.TetrisThemeBox.TabIndex = 33
        Me.TetrisThemeBox.TabStop = False
        '
        'SpaceThemeBox
        '
        Me.SpaceThemeBox.BackgroundImage = CType(resources.GetObject("SpaceThemeBox.BackgroundImage"), System.Drawing.Image)
        Me.SpaceThemeBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SpaceThemeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SpaceThemeBox.Location = New System.Drawing.Point(180, 356)
        Me.SpaceThemeBox.Name = "SpaceThemeBox"
        Me.SpaceThemeBox.Size = New System.Drawing.Size(182, 52)
        Me.SpaceThemeBox.TabIndex = 32
        Me.SpaceThemeBox.TabStop = False
        '
        'ThemePictureBox2a
        '
        Me.ThemePictureBox2a.BackgroundImage = CType(resources.GetObject("ThemePictureBox2a.BackgroundImage"), System.Drawing.Image)
        Me.ThemePictureBox2a.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ThemePictureBox2a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ThemePictureBox2a.Location = New System.Drawing.Point(180, 298)
        Me.ThemePictureBox2a.Name = "ThemePictureBox2a"
        Me.ThemePictureBox2a.Size = New System.Drawing.Size(182, 52)
        Me.ThemePictureBox2a.TabIndex = 31
        Me.ThemePictureBox2a.TabStop = False
        '
        'DefaultThemeBox
        '
        Me.DefaultThemeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DefaultThemeBox.Location = New System.Drawing.Point(180, 240)
        Me.DefaultThemeBox.Name = "DefaultThemeBox"
        Me.DefaultThemeBox.Size = New System.Drawing.Size(182, 52)
        Me.DefaultThemeBox.TabIndex = 30
        Me.DefaultThemeBox.TabStop = False
        '
        'BackColourBox
        '
        Me.BackColourBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.BackColourBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BackColourBox.BackColor = System.Drawing.Color.White
        Me.BackColourBox.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.BackColourBox.FormattingEnabled = True
        Me.BackColourBox.Items.AddRange(New Object() {"Black", "Blue", "DarkGray", "Gray", "Green", "LightGreen", "Orange", "Pink", "PowderBlue", "Purple", "Red", "White", "Yellow"})
        Me.BackColourBox.Location = New System.Drawing.Point(214, 43)
        Me.BackColourBox.Name = "BackColourBox"
        Me.BackColourBox.Size = New System.Drawing.Size(94, 27)
        Me.BackColourBox.Sorted = True
        Me.BackColourBox.TabIndex = 42
        '
        'ColourPictureBox2
        '
        Me.ColourPictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ColourPictureBox2.Location = New System.Drawing.Point(334, 91)
        Me.ColourPictureBox2.Name = "ColourPictureBox2"
        Me.ColourPictureBox2.Size = New System.Drawing.Size(52, 52)
        Me.ColourPictureBox2.TabIndex = 48
        Me.ColourPictureBox2.TabStop = False
        '
        'ButtonColourBox
        '
        Me.ButtonColourBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ButtonColourBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ButtonColourBox.BackColor = System.Drawing.Color.White
        Me.ButtonColourBox.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.ButtonColourBox.FormattingEnabled = True
        Me.ButtonColourBox.Items.AddRange(New Object() {"Black", "Blue", "DarkGray", "Gray", "Green", "LightGreen", "Orange", "Pink", "PowderBlue", "Purple", "Red", "White", "Yellow"})
        Me.ButtonColourBox.Location = New System.Drawing.Point(214, 101)
        Me.ButtonColourBox.Name = "ButtonColourBox"
        Me.ButtonColourBox.Size = New System.Drawing.Size(94, 27)
        Me.ButtonColourBox.Sorted = True
        Me.ButtonColourBox.TabIndex = 47
        '
        'ColourLabel2
        '
        Me.ColourLabel2.AutoSize = True
        Me.ColourLabel2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColourLabel2.Location = New System.Drawing.Point(41, 101)
        Me.ColourLabel2.Name = "ColourLabel2"
        Me.ColourLabel2.Size = New System.Drawing.Size(120, 23)
        Me.ColourLabel2.TabIndex = 46
        Me.ColourLabel2.Text = "Button colour:"
        '
        'ColourPictureBox1
        '
        Me.ColourPictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ColourPictureBox1.Location = New System.Drawing.Point(334, 33)
        Me.ColourPictureBox1.Name = "ColourPictureBox1"
        Me.ColourPictureBox1.Size = New System.Drawing.Size(52, 52)
        Me.ColourPictureBox1.TabIndex = 49
        Me.ColourPictureBox1.TabStop = False
        '
        'ColourPictureBox3
        '
        Me.ColourPictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ColourPictureBox3.Location = New System.Drawing.Point(334, 149)
        Me.ColourPictureBox3.Name = "ColourPictureBox3"
        Me.ColourPictureBox3.Size = New System.Drawing.Size(52, 52)
        Me.ColourPictureBox3.TabIndex = 52
        Me.ColourPictureBox3.TabStop = False
        '
        'FontColourBox
        '
        Me.FontColourBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.FontColourBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FontColourBox.BackColor = System.Drawing.Color.White
        Me.FontColourBox.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.FontColourBox.FormattingEnabled = True
        Me.FontColourBox.Items.AddRange(New Object() {"Black", "Blue", "DarkGray", "Gray", "Green", "LightGreen", "Orange", "Pink", "PowderBlue", "Purple", "Red", "White", "Yellow"})
        Me.FontColourBox.Location = New System.Drawing.Point(214, 159)
        Me.FontColourBox.Name = "FontColourBox"
        Me.FontColourBox.Size = New System.Drawing.Size(94, 27)
        Me.FontColourBox.Sorted = True
        Me.FontColourBox.TabIndex = 51
        '
        'ColourLabel3
        '
        Me.ColourLabel3.AutoSize = True
        Me.ColourLabel3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColourLabel3.Location = New System.Drawing.Point(41, 159)
        Me.ColourLabel3.Name = "ColourLabel3"
        Me.ColourLabel3.Size = New System.Drawing.Size(103, 23)
        Me.ColourLabel3.TabIndex = 50
        Me.ColourLabel3.Text = "Font colour:"
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Save.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(308, 484)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(78, 32)
        Me.Save.TabIndex = 53
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = False
        '
        'DefaultTheme
        '
        Me.DefaultTheme.AutoSize = True
        Me.DefaultTheme.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DefaultTheme.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DefaultTheme.Location = New System.Drawing.Point(77, 254)
        Me.DefaultTheme.Name = "DefaultTheme"
        Me.DefaultTheme.Size = New System.Drawing.Size(84, 27)
        Me.DefaultTheme.TabIndex = 54
        Me.DefaultTheme.Text = "Default"
        Me.DefaultTheme.UseVisualStyleBackColor = True
        '
        'LandscapeTheme
        '
        Me.LandscapeTheme.AutoSize = True
        Me.LandscapeTheme.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LandscapeTheme.Enabled = False
        Me.LandscapeTheme.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LandscapeTheme.Location = New System.Drawing.Point(52, 311)
        Me.LandscapeTheme.Name = "LandscapeTheme"
        Me.LandscapeTheme.Size = New System.Drawing.Size(109, 27)
        Me.LandscapeTheme.TabIndex = 55
        Me.LandscapeTheme.Text = "Landscape"
        Me.LandscapeTheme.UseVisualStyleBackColor = True
        '
        'SpaceTheme
        '
        Me.SpaceTheme.AutoSize = True
        Me.SpaceTheme.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SpaceTheme.Enabled = False
        Me.SpaceTheme.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpaceTheme.Location = New System.Drawing.Point(88, 370)
        Me.SpaceTheme.Name = "SpaceTheme"
        Me.SpaceTheme.Size = New System.Drawing.Size(73, 27)
        Me.SpaceTheme.TabIndex = 56
        Me.SpaceTheme.Text = "Space"
        Me.SpaceTheme.UseVisualStyleBackColor = True
        '
        'TetrisTheme
        '
        Me.TetrisTheme.AutoSize = True
        Me.TetrisTheme.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TetrisTheme.Enabled = False
        Me.TetrisTheme.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TetrisTheme.Location = New System.Drawing.Point(92, 427)
        Me.TetrisTheme.Name = "TetrisTheme"
        Me.TetrisTheme.Size = New System.Drawing.Size(69, 27)
        Me.TetrisTheme.TabIndex = 57
        Me.TetrisTheme.Text = "Tetris"
        Me.TetrisTheme.UseVisualStyleBackColor = True
        '
        'NoThemeLabel
        '
        Me.NoThemeLabel.AutoSize = True
        Me.NoThemeLabel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NoThemeLabel.Checked = True
        Me.NoThemeLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoThemeLabel.Location = New System.Drawing.Point(55, 204)
        Me.NoThemeLabel.Name = "NoThemeLabel"
        Me.NoThemeLabel.Size = New System.Drawing.Size(106, 27)
        Me.NoThemeLabel.TabIndex = 58
        Me.NoThemeLabel.TabStop = True
        Me.NoThemeLabel.Text = "No Theme"
        Me.NoThemeLabel.UseVisualStyleBackColor = True
        '
        'Customization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(428, 539)
        Me.Controls.Add(Me.NoThemeLabel)
        Me.Controls.Add(Me.TetrisTheme)
        Me.Controls.Add(Me.SpaceTheme)
        Me.Controls.Add(Me.LandscapeTheme)
        Me.Controls.Add(Me.DefaultTheme)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.ColourPictureBox3)
        Me.Controls.Add(Me.FontColourBox)
        Me.Controls.Add(Me.ColourLabel3)
        Me.Controls.Add(Me.ColourPictureBox1)
        Me.Controls.Add(Me.ColourPictureBox2)
        Me.Controls.Add(Me.ButtonColourBox)
        Me.Controls.Add(Me.ColourLabel2)
        Me.Controls.Add(Me.BackColourBox)
        Me.Controls.Add(Me.TetrisThemeBox)
        Me.Controls.Add(Me.SpaceThemeBox)
        Me.Controls.Add(Me.ThemePictureBox2a)
        Me.Controls.Add(Me.DefaultThemeBox)
        Me.Controls.Add(Me.ColourLabel1)
        Me.Controls.Add(Me.Back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Customization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customization"
        CType(Me.TetrisThemeBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaceThemeBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ThemePictureBox2a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefaultThemeBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColourPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColourPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColourPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents ColourLabel1 As System.Windows.Forms.Label
    Friend WithEvents TetrisThemeBox As System.Windows.Forms.PictureBox
    Friend WithEvents SpaceThemeBox As System.Windows.Forms.PictureBox
    Friend WithEvents ThemePictureBox2a As System.Windows.Forms.PictureBox
    Friend WithEvents DefaultThemeBox As System.Windows.Forms.PictureBox
    Friend WithEvents BackColourBox As System.Windows.Forms.ComboBox
    Friend WithEvents ColourPictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonColourBox As System.Windows.Forms.ComboBox
    Friend WithEvents ColourLabel2 As System.Windows.Forms.Label
    Friend WithEvents ColourPictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ColourPictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents FontColourBox As System.Windows.Forms.ComboBox
    Friend WithEvents ColourLabel3 As System.Windows.Forms.Label
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents DefaultTheme As System.Windows.Forms.RadioButton
    Friend WithEvents LandscapeTheme As System.Windows.Forms.RadioButton
    Friend WithEvents SpaceTheme As System.Windows.Forms.RadioButton
    Friend WithEvents TetrisTheme As System.Windows.Forms.RadioButton
    Friend WithEvents NoThemeLabel As System.Windows.Forms.RadioButton
End Class
