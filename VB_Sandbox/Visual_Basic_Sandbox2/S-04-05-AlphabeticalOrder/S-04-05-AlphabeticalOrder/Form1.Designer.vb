<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlphabeticalOrder
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
    Me.txtWord = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnDetermine = New System.Windows.Forms.Button()
    Me.SuspendLayout
    '
    'txtOutput
    '
    Me.txtOutput.Location = New System.Drawing.Point(86, 143)
    Me.txtOutput.Name = "txtOutput"
    Me.txtOutput.ReadOnly = true
    Me.txtOutput.Size = New System.Drawing.Size(100, 20)
    Me.txtOutput.TabIndex = 8
    '
    'txtWord
    '
    Me.txtWord.Location = New System.Drawing.Point(51, 21)
    Me.txtWord.Name = "txtWord"
    Me.txtWord.Size = New System.Drawing.Size(199, 20)
    Me.txtWord.TabIndex = 7
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(12, 24)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(33, 13)
    Me.Label1.TabIndex = 6
    Me.Label1.Text = "Word"
    '
    'btnDetermine
    '
    Me.btnDetermine.Location = New System.Drawing.Point(15, 58)
    Me.btnDetermine.Name = "btnDetermine"
    Me.btnDetermine.Size = New System.Drawing.Size(235, 65)
    Me.btnDetermine.TabIndex = 5
    Me.btnDetermine.Text = "Determine if the Word contains three consecutive letters in consecutive alphabeti"& _ 
    "cal order"
    Me.btnDetermine.UseVisualStyleBackColor = true
    '
    'frmAlphabeticalOrder
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(272, 182)
    Me.Controls.Add(Me.txtOutput)
    Me.Controls.Add(Me.txtWord)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnDetermine)
    Me.Name = "frmAlphabeticalOrder"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Alphabetical Order"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents txtOutput As TextBox
  Friend WithEvents txtWord As TextBox
  Friend WithEvents Label1 As Label
  Friend WithEvents btnDetermine As Button
End Class
