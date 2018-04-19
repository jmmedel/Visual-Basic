<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathsQuestions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MathsQuestions))
        Me.QuestionLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Answer1 = New System.Windows.Forms.RadioButton()
        Me.Answer2 = New System.Windows.Forms.RadioButton()
        Me.Answer3 = New System.Windows.Forms.RadioButton()
        Me.Answer4 = New System.Windows.Forms.RadioButton()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.FinQnLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'QuestionLabel
        '
        Me.QuestionLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionLabel.Location = New System.Drawing.Point(6, 9)
        Me.QuestionLabel.Name = "QuestionLabel"
        Me.QuestionLabel.Size = New System.Drawing.Size(307, 48)
        Me.QuestionLabel.TabIndex = 0
        Me.QuestionLabel.Text = "What number is 20 lower than 6?"
        Me.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(320, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 50)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "10"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(309, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Time Left"
        '
        'Answer1
        '
        Me.Answer1.AutoSize = True
        Me.Answer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Answer1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer1.Location = New System.Drawing.Point(33, 72)
        Me.Answer1.Name = "Answer1"
        Me.Answer1.Size = New System.Drawing.Size(72, 30)
        Me.Answer1.TabIndex = 7
        Me.Answer1.Text = "Num"
        Me.Answer1.UseVisualStyleBackColor = True
        '
        'Answer2
        '
        Me.Answer2.AutoSize = True
        Me.Answer2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer2.Location = New System.Drawing.Point(175, 72)
        Me.Answer2.Name = "Answer2"
        Me.Answer2.Size = New System.Drawing.Size(72, 30)
        Me.Answer2.TabIndex = 8
        Me.Answer2.Text = "Num"
        Me.Answer2.UseVisualStyleBackColor = True
        '
        'Answer3
        '
        Me.Answer3.AutoSize = True
        Me.Answer3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer3.Location = New System.Drawing.Point(33, 140)
        Me.Answer3.Name = "Answer3"
        Me.Answer3.Size = New System.Drawing.Size(72, 30)
        Me.Answer3.TabIndex = 9
        Me.Answer3.Text = "Num"
        Me.Answer3.UseVisualStyleBackColor = True
        '
        'Answer4
        '
        Me.Answer4.AutoSize = True
        Me.Answer4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Answer4.Location = New System.Drawing.Point(175, 140)
        Me.Answer4.Name = "Answer4"
        Me.Answer4.Size = New System.Drawing.Size(72, 30)
        Me.Answer4.TabIndex = 10
        Me.Answer4.Text = "Num"
        Me.Answer4.UseVisualStyleBackColor = True
        '
        'OkButton
        '
        Me.OkButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OkButton.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.OkButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.OkButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.OkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OkButton.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkButton.Location = New System.Drawing.Point(43, 193)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(225, 48)
        Me.OkButton.TabIndex = 12
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = False
        '
        'FinQnLabel
        '
        Me.FinQnLabel.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinQnLabel.Location = New System.Drawing.Point(12, 66)
        Me.FinQnLabel.Name = "FinQnLabel"
        Me.FinQnLabel.Size = New System.Drawing.Size(393, 102)
        Me.FinQnLabel.TabIndex = 13
        Me.FinQnLabel.Text = "Correct!"
        Me.FinQnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.FinQnLabel.Visible = False
        '
        'MathsQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(417, 273)
        Me.Controls.Add(Me.FinQnLabel)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.Answer4)
        Me.Controls.Add(Me.Answer3)
        Me.Controls.Add(Me.Answer2)
        Me.Controls.Add(Me.Answer1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.QuestionLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MathsQuestions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maths Question"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QuestionLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Answer1 As System.Windows.Forms.RadioButton
    Friend WithEvents Answer2 As System.Windows.Forms.RadioButton
    Friend WithEvents Answer3 As System.Windows.Forms.RadioButton
    Friend WithEvents Answer4 As System.Windows.Forms.RadioButton
    Friend WithEvents OkButton As System.Windows.Forms.Button
    Friend WithEvents FinQnLabel As System.Windows.Forms.Label
End Class
