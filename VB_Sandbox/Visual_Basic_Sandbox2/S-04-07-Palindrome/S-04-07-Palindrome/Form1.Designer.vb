<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPalindrome
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
    Me.btnAnalyze = New System.Windows.Forms.Button()
    Me.txtWord = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout
    '
    'txtOutput
    '
    Me.txtOutput.Location = New System.Drawing.Point(109, 136)
    Me.txtOutput.Name = "txtOutput"
    Me.txtOutput.ReadOnly = true
    Me.txtOutput.Size = New System.Drawing.Size(100, 20)
    Me.txtOutput.TabIndex = 7
    '
    'btnAnalyze
    '
    Me.btnAnalyze.Location = New System.Drawing.Point(39, 74)
    Me.btnAnalyze.Name = "btnAnalyze"
    Me.btnAnalyze.Size = New System.Drawing.Size(236, 41)
    Me.btnAnalyze.TabIndex = 6
    Me.btnAnalyze.Text = "Determine if Palindrome"
    Me.btnAnalyze.UseVisualStyleBackColor = true
    '
    'txtWord
    '
    Me.txtWord.Location = New System.Drawing.Point(15, 36)
    Me.txtWord.Name = "txtWord"
    Me.txtWord.Size = New System.Drawing.Size(286, 20)
    Me.txtWord.TabIndex = 5
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(127, 13)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Enter the Word or Phrase"
    '
    'frmPalindrome
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(321, 175)
    Me.Controls.Add(Me.txtOutput)
    Me.Controls.Add(Me.btnAnalyze)
    Me.Controls.Add(Me.txtWord)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmPalindrome"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Palindrome"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents txtOutput As TextBox
  Friend WithEvents btnAnalyze As Button
  Friend WithEvents txtWord As TextBox
  Friend WithEvents Label1 As Label
End Class
