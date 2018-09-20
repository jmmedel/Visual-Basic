<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.red_radio_btn = New System.Windows.Forms.RadioButton()
        Me.white_radio_btn = New System.Windows.Forms.RadioButton()
        Me.green_radio_btn = New System.Windows.Forms.RadioButton()
        Me.english_radiobtn = New System.Windows.Forms.RadioButton()
        Me.france_radio_btn = New System.Windows.Forms.RadioButton()
        Me.spain_radio_btn = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.green_radio_btn)
        Me.GroupBox1.Controls.Add(Me.white_radio_btn)
        Me.GroupBox1.Controls.Add(Me.red_radio_btn)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(100, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "色"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.spain_radio_btn)
        Me.GroupBox2.Controls.Add(Me.france_radio_btn)
        Me.GroupBox2.Controls.Add(Me.english_radiobtn)
        Me.GroupBox2.Location = New System.Drawing.Point(215, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(100, 154)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "言国"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(42, 278)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(147, 19)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "変数"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'red_radio_btn
        '
        Me.red_radio_btn.AutoSize = True
        Me.red_radio_btn.Location = New System.Drawing.Point(2, 47)
        Me.red_radio_btn.Name = "red_radio_btn"
        Me.red_radio_btn.Size = New System.Drawing.Size(47, 16)
        Me.red_radio_btn.TabIndex = 0
        Me.red_radio_btn.TabStop = True
        Me.red_radio_btn.Text = "赤色"
        Me.red_radio_btn.UseVisualStyleBackColor = True
        '
        'white_radio_btn
        '
        Me.white_radio_btn.AutoSize = True
        Me.white_radio_btn.Location = New System.Drawing.Point(0, 69)
        Me.white_radio_btn.Name = "white_radio_btn"
        Me.white_radio_btn.Size = New System.Drawing.Size(47, 16)
        Me.white_radio_btn.TabIndex = 1
        Me.white_radio_btn.TabStop = True
        Me.white_radio_btn.Text = "白色"
        Me.white_radio_btn.UseVisualStyleBackColor = True
        '
        'green_radio_btn
        '
        Me.green_radio_btn.AutoSize = True
        Me.green_radio_btn.Location = New System.Drawing.Point(2, 91)
        Me.green_radio_btn.Name = "green_radio_btn"
        Me.green_radio_btn.Size = New System.Drawing.Size(47, 16)
        Me.green_radio_btn.TabIndex = 2
        Me.green_radio_btn.TabStop = True
        Me.green_radio_btn.Text = "緑色"
        Me.green_radio_btn.UseVisualStyleBackColor = True
        '
        'english_radiobtn
        '
        Me.english_radiobtn.AutoSize = True
        Me.english_radiobtn.Location = New System.Drawing.Point(2, 47)
        Me.english_radiobtn.Name = "english_radiobtn"
        Me.english_radiobtn.Size = New System.Drawing.Size(47, 16)
        Me.english_radiobtn.TabIndex = 1
        Me.english_radiobtn.TabStop = True
        Me.english_radiobtn.Text = "英語"
        Me.english_radiobtn.UseVisualStyleBackColor = True
        '
        'france_radio_btn
        '
        Me.france_radio_btn.AutoSize = True
        Me.france_radio_btn.Location = New System.Drawing.Point(0, 69)
        Me.france_radio_btn.Name = "france_radio_btn"
        Me.france_radio_btn.Size = New System.Drawing.Size(69, 16)
        Me.france_radio_btn.TabIndex = 2
        Me.france_radio_btn.TabStop = True
        Me.france_radio_btn.Text = "フランス語"
        Me.france_radio_btn.UseVisualStyleBackColor = True
        '
        'spain_radio_btn
        '
        Me.spain_radio_btn.AutoSize = True
        Me.spain_radio_btn.Location = New System.Drawing.Point(2, 91)
        Me.spain_radio_btn.Name = "spain_radio_btn"
        Me.spain_radio_btn.Size = New System.Drawing.Size(72, 16)
        Me.spain_radio_btn.TabIndex = 3
        Me.spain_radio_btn.TabStop = True
        Me.spain_radio_btn.Text = "スペイン語"
        Me.spain_radio_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "0H01007"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents green_radio_btn As RadioButton
    Friend WithEvents white_radio_btn As RadioButton
    Friend WithEvents red_radio_btn As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents spain_radio_btn As RadioButton
    Friend WithEvents france_radio_btn As RadioButton
    Friend WithEvents english_radiobtn As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
