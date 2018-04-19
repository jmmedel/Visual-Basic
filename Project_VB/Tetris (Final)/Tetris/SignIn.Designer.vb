<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignIn))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PassBox = New System.Windows.Forms.TextBox()
        Me.UserNameBox = New System.Windows.Forms.TextBox()
        Me.Pass = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.Label()
        Me.SignInButton = New System.Windows.Forms.Button()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.ReEnterPassBox = New System.Windows.Forms.TextBox()
        Me.ReEnterPass = New System.Windows.Forms.Label()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MessageLabel2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(215, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 95)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(38, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 36)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Welcome To"
        '
        'PassBox
        '
        Me.PassBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.PassBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PassBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PassBox.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PassBox.Location = New System.Drawing.Point(233, 178)
        Me.PassBox.Name = "PassBox"
        Me.PassBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassBox.Size = New System.Drawing.Size(100, 33)
        Me.PassBox.TabIndex = 9
        '
        'UserNameBox
        '
        Me.UserNameBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.UserNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserNameBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UserNameBox.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserNameBox.Location = New System.Drawing.Point(233, 123)
        Me.UserNameBox.Name = "UserNameBox"
        Me.UserNameBox.Size = New System.Drawing.Size(100, 33)
        Me.UserNameBox.TabIndex = 8
        '
        'Pass
        '
        Me.Pass.AutoSize = True
        Me.Pass.BackColor = System.Drawing.Color.Transparent
        Me.Pass.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass.ForeColor = System.Drawing.Color.Black
        Me.Pass.Location = New System.Drawing.Point(120, 181)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(93, 26)
        Me.Pass.TabIndex = 7
        Me.Pass.Text = "Password"
        '
        'UserName
        '
        Me.UserName.AutoSize = True
        Me.UserName.BackColor = System.Drawing.Color.Transparent
        Me.UserName.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName.ForeColor = System.Drawing.Color.Black
        Me.UserName.Location = New System.Drawing.Point(110, 126)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(103, 26)
        Me.UserName.TabIndex = 6
        Me.UserName.Text = "User name"
        '
        'SignInButton
        '
        Me.SignInButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SignInButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.SignInButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.SignInButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignInButton.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignInButton.Location = New System.Drawing.Point(233, 359)
        Me.SignInButton.Name = "SignInButton"
        Me.SignInButton.Size = New System.Drawing.Size(128, 37)
        Me.SignInButton.TabIndex = 12
        Me.SignInButton.Text = "Sign In"
        Me.SignInButton.UseVisualStyleBackColor = False
        '
        'RegisterButton
        '
        Me.RegisterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.RegisterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.RegisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RegisterButton.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterButton.Location = New System.Drawing.Point(30, 359)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(128, 37)
        Me.RegisterButton.TabIndex = 13
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = False
        '
        'ReEnterPassBox
        '
        Me.ReEnterPassBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ReEnterPassBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReEnterPassBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ReEnterPassBox.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReEnterPassBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ReEnterPassBox.Location = New System.Drawing.Point(233, 232)
        Me.ReEnterPassBox.Name = "ReEnterPassBox"
        Me.ReEnterPassBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ReEnterPassBox.Size = New System.Drawing.Size(100, 33)
        Me.ReEnterPassBox.TabIndex = 15
        Me.ReEnterPassBox.Visible = False
        '
        'ReEnterPass
        '
        Me.ReEnterPass.AutoSize = True
        Me.ReEnterPass.BackColor = System.Drawing.Color.Transparent
        Me.ReEnterPass.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReEnterPass.ForeColor = System.Drawing.Color.Black
        Me.ReEnterPass.Location = New System.Drawing.Point(43, 235)
        Me.ReEnterPass.Name = "ReEnterPass"
        Me.ReEnterPass.Size = New System.Drawing.Size(170, 26)
        Me.ReEnterPass.TabIndex = 14
        Me.ReEnterPass.Text = "Re-enter password"
        Me.ReEnterPass.Visible = False
        '
        'MessageLabel
        '
        Me.MessageLabel.BackColor = System.Drawing.Color.Transparent
        Me.MessageLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.ForeColor = System.Drawing.Color.Black
        Me.MessageLabel.Location = New System.Drawing.Point(93, 278)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(222, 19)
        Me.MessageLabel.TabIndex = 16
        Me.MessageLabel.Text = "Please fill in all boxes"
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MessageLabel.Visible = False
        '
        'MaleRadioButton
        '
        Me.MaleRadioButton.AutoSize = True
        Me.MaleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.MaleRadioButton.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaleRadioButton.Location = New System.Drawing.Point(93, 323)
        Me.MaleRadioButton.Name = "MaleRadioButton"
        Me.MaleRadioButton.Size = New System.Drawing.Size(65, 27)
        Me.MaleRadioButton.TabIndex = 18
        Me.MaleRadioButton.TabStop = True
        Me.MaleRadioButton.Text = "Male"
        Me.MaleRadioButton.UseVisualStyleBackColor = False
        '
        'FemaleRadioButton
        '
        Me.FemaleRadioButton.AutoSize = True
        Me.FemaleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.FemaleRadioButton.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FemaleRadioButton.Location = New System.Drawing.Point(233, 323)
        Me.FemaleRadioButton.Name = "FemaleRadioButton"
        Me.FemaleRadioButton.Size = New System.Drawing.Size(82, 27)
        Me.FemaleRadioButton.TabIndex = 19
        Me.FemaleRadioButton.TabStop = True
        Me.FemaleRadioButton.Text = "Female"
        Me.FemaleRadioButton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'MessageLabel2
        '
        Me.MessageLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MessageLabel2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel2.ForeColor = System.Drawing.Color.Black
        Me.MessageLabel2.Location = New System.Drawing.Point(48, 302)
        Me.MessageLabel2.Name = "MessageLabel2"
        Me.MessageLabel2.Size = New System.Drawing.Size(313, 19)
        Me.MessageLabel2.TabIndex = 20
        Me.MessageLabel2.Text = "Please fill in all boxes"
        Me.MessageLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MessageLabel2.Visible = False
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(391, 418)
        Me.Controls.Add(Me.MessageLabel2)
        Me.Controls.Add(Me.FemaleRadioButton)
        Me.Controls.Add(Me.MaleRadioButton)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.ReEnterPassBox)
        Me.Controls.Add(Me.ReEnterPass)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.SignInButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PassBox)
        Me.Controls.Add(Me.UserNameBox)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign In"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PassBox As System.Windows.Forms.TextBox
    Friend WithEvents UserNameBox As System.Windows.Forms.TextBox
    Friend WithEvents Pass As System.Windows.Forms.Label
    Friend WithEvents UserName As System.Windows.Forms.Label
    Friend WithEvents SignInButton As System.Windows.Forms.Button
    Friend WithEvents RegisterButton As System.Windows.Forms.Button
    Friend WithEvents ReEnterPassBox As System.Windows.Forms.TextBox
    Friend WithEvents ReEnterPass As System.Windows.Forms.Label
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents MaleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents FemaleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MessageLabel2 As System.Windows.Forms.Label
End Class
