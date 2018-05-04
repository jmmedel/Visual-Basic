<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDirectoryAssistance
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
    Me.txtCode = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.lstOutput = New System.Windows.Forms.ListBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btn8 = New System.Windows.Forms.Button()
    Me.btn7 = New System.Windows.Forms.Button()
    Me.btn6 = New System.Windows.Forms.Button()
    Me.btn5 = New System.Windows.Forms.Button()
    Me.btn4 = New System.Windows.Forms.Button()
    Me.btn3 = New System.Windows.Forms.Button()
    Me.btn2 = New System.Windows.Forms.Button()
    Me.btn1 = New System.Windows.Forms.Button()
    Me.btnAnother = New System.Windows.Forms.Button()
    Me.SuspendLayout
    '
    'txtCode
    '
    Me.txtCode.Location = New System.Drawing.Point(170, 123)
    Me.txtCode.Name = "txtCode"
    Me.txtCode.ReadOnly = true
    Me.txtCode.Size = New System.Drawing.Size(100, 20)
    Me.txtCode.TabIndex = 26
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(58, 126)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(94, 13)
    Me.Label2.TabIndex = 25
    Me.Label2.Text = "Push-button code:"
    '
    'lstOutput
    '
    Me.lstOutput.FormattingEnabled = true
    Me.lstOutput.Location = New System.Drawing.Point(317, 48)
    Me.lstOutput.Name = "lstOutput"
    Me.lstOutput.Size = New System.Drawing.Size(215, 95)
    Me.lstOutput.TabIndex = 24
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(86, 26)
    Me.Label1.TabIndex = 23
    Me.Label1.Text = "Click the buttons"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"to select letters"
    '
    'btn8
    '
    Me.btn8.Location = New System.Drawing.Point(195, 86)
    Me.btn8.Name = "btn8"
    Me.btn8.Size = New System.Drawing.Size(75, 23)
    Me.btn8.TabIndex = 21
    Me.btn8.Tag = "8"
    Me.btn8.Text = "8  WXYZ"
    Me.btn8.UseVisualStyleBackColor = true
    '
    'btn7
    '
    Me.btn7.Location = New System.Drawing.Point(104, 86)
    Me.btn7.Name = "btn7"
    Me.btn7.Size = New System.Drawing.Size(75, 23)
    Me.btn7.TabIndex = 20
    Me.btn7.Tag = "7"
    Me.btn7.Text = "7  TUV"
    Me.btn7.UseVisualStyleBackColor = true
    '
    'btn6
    '
    Me.btn6.Location = New System.Drawing.Point(15, 86)
    Me.btn6.Name = "btn6"
    Me.btn6.Size = New System.Drawing.Size(75, 23)
    Me.btn6.TabIndex = 19
    Me.btn6.Tag = "6"
    Me.btn6.Text = "6  PQRS"
    Me.btn6.UseVisualStyleBackColor = true
    '
    'btn5
    '
    Me.btn5.Location = New System.Drawing.Point(195, 48)
    Me.btn5.Name = "btn5"
    Me.btn5.Size = New System.Drawing.Size(75, 23)
    Me.btn5.TabIndex = 18
    Me.btn5.Tag = "5"
    Me.btn5.Text = "5  MNO"
    Me.btn5.UseVisualStyleBackColor = true
    '
    'btn4
    '
    Me.btn4.Location = New System.Drawing.Point(104, 48)
    Me.btn4.Name = "btn4"
    Me.btn4.Size = New System.Drawing.Size(75, 23)
    Me.btn4.TabIndex = 17
    Me.btn4.Tag = "4"
    Me.btn4.Text = "4  JKL"
    Me.btn4.UseVisualStyleBackColor = true
    '
    'btn3
    '
    Me.btn3.Location = New System.Drawing.Point(15, 48)
    Me.btn3.Name = "btn3"
    Me.btn3.Size = New System.Drawing.Size(75, 23)
    Me.btn3.TabIndex = 16
    Me.btn3.Tag = "3"
    Me.btn3.Text = "3  GHI"
    Me.btn3.UseVisualStyleBackColor = true
    '
    'btn2
    '
    Me.btn2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
    Me.btn2.Location = New System.Drawing.Point(195, 9)
    Me.btn2.Name = "btn2"
    Me.btn2.Size = New System.Drawing.Size(75, 23)
    Me.btn2.TabIndex = 15
    Me.btn2.Tag = "2"
    Me.btn2.Text = "2  DEF"
    Me.btn2.UseVisualStyleBackColor = true
    '
    'btn1
    '
    Me.btn1.Location = New System.Drawing.Point(104, 9)
    Me.btn1.Name = "btn1"
    Me.btn1.Size = New System.Drawing.Size(75, 23)
    Me.btn1.TabIndex = 14
    Me.btn1.Tag = "1"
    Me.btn1.Text = "1  ABC"
    Me.btn1.UseVisualStyleBackColor = true
    '
    'btnAnother
    '
    Me.btnAnother.Location = New System.Drawing.Point(317, 9)
    Me.btnAnother.Name = "btnAnother"
    Me.btnAnother.Size = New System.Drawing.Size(215, 23)
    Me.btnAnother.TabIndex = 22
    Me.btnAnother.Text = "Look Up Another Person"
    Me.btnAnother.UseVisualStyleBackColor = true
    '
    'frmDirectoryAssistance
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(559, 166)
    Me.Controls.Add(Me.txtCode)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.lstOutput)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btn8)
    Me.Controls.Add(Me.btn7)
    Me.Controls.Add(Me.btn6)
    Me.Controls.Add(Me.btn5)
    Me.Controls.Add(Me.btn4)
    Me.Controls.Add(Me.btn3)
    Me.Controls.Add(Me.btn2)
    Me.Controls.Add(Me.btn1)
    Me.Controls.Add(Me.btnAnother)
    Me.Name = "frmDirectoryAssistance"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Directory Assistance"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents txtCode As TextBox
  Friend WithEvents Label2 As Label
  Friend WithEvents lstOutput As ListBox
  Friend WithEvents Label1 As Label
  Friend WithEvents btn8 As Button
  Friend WithEvents btn7 As Button
  Friend WithEvents btn6 As Button
  Friend WithEvents btn5 As Button
  Friend WithEvents btn4 As Button
  Friend WithEvents btn3 As Button
  Friend WithEvents btn2 As Button
  Friend WithEvents btn1 As Button
  Friend WithEvents btnAnother As Button
End Class
