<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRudimentaryTranslator
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
    Me.txtGerman = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtFrench = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.btnTranslate = New System.Windows.Forms.Button()
    Me.txtEnglish = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout
    '
    'txtGerman
    '
    Me.txtGerman.Location = New System.Drawing.Point(129, 164)
    Me.txtGerman.Name = "txtGerman"
    Me.txtGerman.ReadOnly = true
    Me.txtGerman.Size = New System.Drawing.Size(350, 20)
    Me.txtGerman.TabIndex = 13
    '
    'Label3
    '
    Me.Label3.AutoSize = true
    Me.Label3.Location = New System.Drawing.Point(12, 167)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(93, 13)
    Me.Label3.TabIndex = 12
    Me.Label3.Text = "German Sentence"
    '
    'txtFrench
    '
    Me.txtFrench.Location = New System.Drawing.Point(129, 125)
    Me.txtFrench.Name = "txtFrench"
    Me.txtFrench.ReadOnly = true
    Me.txtFrench.Size = New System.Drawing.Size(350, 20)
    Me.txtFrench.TabIndex = 11
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(12, 128)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(89, 13)
    Me.Label2.TabIndex = 10
    Me.Label2.Text = "French Sentence"
    '
    'btnTranslate
    '
    Me.btnTranslate.Location = New System.Drawing.Point(155, 60)
    Me.btnTranslate.Name = "btnTranslate"
    Me.btnTranslate.Size = New System.Drawing.Size(296, 32)
    Me.btnTranslate.TabIndex = 9
    Me.btnTranslate.Text = "Translate Sentence"
    Me.btnTranslate.UseVisualStyleBackColor = true
    '
    'txtEnglish
    '
    Me.txtEnglish.Location = New System.Drawing.Point(129, 18)
    Me.txtEnglish.Name = "txtEnglish"
    Me.txtEnglish.Size = New System.Drawing.Size(350, 20)
    Me.txtEnglish.TabIndex = 8
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(12, 21)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(90, 13)
    Me.Label1.TabIndex = 7
    Me.Label1.Text = "English Sentence"
    '
    'frmRudimentaryTranslator
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(503, 210)
    Me.Controls.Add(Me.txtGerman)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.txtFrench)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.btnTranslate)
    Me.Controls.Add(Me.txtEnglish)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmRudimentaryTranslator"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Rudimentary Translator"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents txtGerman As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents txtFrench As TextBox
  Friend WithEvents Label2 As Label
  Friend WithEvents btnTranslate As Button
  Friend WithEvents txtEnglish As TextBox
  Friend WithEvents Label1 As Label
End Class
