<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParantheses
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
    Me.txtOutput = New System.Windows.Forms.TextBox()
    Me.btnRemove = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtSentence = New System.Windows.Forms.TextBox()
    Me.SuspendLayout
    '
    'txtOutput
    '
    Me.txtOutput.Location = New System.Drawing.Point(15, 147)
    Me.txtOutput.Name = "txtOutput"
    Me.txtOutput.ReadOnly = true
    Me.txtOutput.Size = New System.Drawing.Size(335, 20)
    Me.txtOutput.TabIndex = 7
    '
    'btnRemove
    '
    Me.btnRemove.Location = New System.Drawing.Point(15, 82)
    Me.btnRemove.Name = "btnRemove"
    Me.btnRemove.Size = New System.Drawing.Size(335, 45)
    Me.btnRemove.TabIndex = 6
    Me.btnRemove.Text = "Remove Parantheses"
    Me.btnRemove.UseVisualStyleBackColor = true
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(53, 13)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "Sentence"
    '
    'txtSentence
    '
    Me.txtSentence.Location = New System.Drawing.Point(15, 40)
    Me.txtSentence.Name = "txtSentence"
    Me.txtSentence.Size = New System.Drawing.Size(335, 20)
    Me.txtSentence.TabIndex = 4
    '
    'frmParantheses
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(372, 193)
    Me.Controls.Add(Me.txtOutput)
    Me.Controls.Add(Me.btnRemove)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtSentence)
    Me.Name = "frmParantheses"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Parantheses"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents txtOutput As TextBox
  Friend WithEvents btnRemove As Button
  Friend WithEvents Label1 As Label
  Friend WithEvents txtSentence As TextBox
End Class
