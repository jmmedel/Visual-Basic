<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProverbs
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
    Me.btnDisplay = New System.Windows.Forms.Button()
    Me.txtAnswer = New System.Windows.Forms.TextBox()
    Me.lblAnswer = New System.Windows.Forms.Label()
    Me.lblProverb = New System.Windows.Forms.Label()
    Me.btnAnswer = New System.Windows.Forms.Button()
    Me.SuspendLayout
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(15, 95)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(102, 35)
    Me.btnDisplay.TabIndex = 4
    Me.btnDisplay.Text = "Display Proverb"
    Me.btnDisplay.UseVisualStyleBackColor = true
    '
    'txtAnswer
    '
    Me.txtAnswer.Enabled = false
    Me.txtAnswer.Location = New System.Drawing.Point(144, 56)
    Me.txtAnswer.MaxLength = 1
    Me.txtAnswer.Name = "txtAnswer"
    Me.txtAnswer.Size = New System.Drawing.Size(35, 20)
    Me.txtAnswer.TabIndex = 6
    '
    'lblAnswer
    '
    Me.lblAnswer.AutoSize = true
    Me.lblAnswer.Location = New System.Drawing.Point(38, 59)
    Me.lblAnswer.Name = "lblAnswer"
    Me.lblAnswer.Size = New System.Drawing.Size(100, 13)
    Me.lblAnswer.TabIndex = 5
    Me.lblAnswer.Text = "True (T) or False (F)"
    '
    'lblProverb
    '
    Me.lblProverb.Location = New System.Drawing.Point(12, 9)
    Me.lblProverb.Name = "lblProverb"
    Me.lblProverb.Size = New System.Drawing.Size(208, 23)
    Me.lblProverb.TabIndex = 7
    '
    'btnAnswer
    '
    Me.btnAnswer.Enabled = false
    Me.btnAnswer.Location = New System.Drawing.Point(123, 95)
    Me.btnAnswer.Name = "btnAnswer"
    Me.btnAnswer.Size = New System.Drawing.Size(102, 35)
    Me.btnAnswer.TabIndex = 8
    Me.btnAnswer.Text = "Record Answer"
    Me.btnAnswer.UseVisualStyleBackColor = true
    '
    'frmProverbs
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(232, 159)
    Me.Controls.Add(Me.btnAnswer)
    Me.Controls.Add(Me.lblProverb)
    Me.Controls.Add(Me.btnDisplay)
    Me.Controls.Add(Me.txtAnswer)
    Me.Controls.Add(Me.lblAnswer)
    Me.Name = "frmProverbs"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Proverbs"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub
  Friend WithEvents btnDisplay As Button
  Friend WithEvents txtAnswer As TextBox
  Friend WithEvents lblAnswer As Label
  Friend WithEvents lblProverb As Label
  Friend WithEvents btnAnswer As Button
End Class
