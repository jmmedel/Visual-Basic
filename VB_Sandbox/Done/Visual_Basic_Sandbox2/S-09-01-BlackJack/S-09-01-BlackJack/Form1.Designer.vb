<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlackJack
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
    Me.txtDealer = New System.Windows.Forms.TextBox()
    Me.txtPlayer = New System.Windows.Forms.TextBox()
    Me.lblDealer = New System.Windows.Forms.Label()
    Me.lblPlayer = New System.Windows.Forms.Label()
    Me.btnNewHand = New System.Windows.Forms.Button()
    Me.btnHold = New System.Windows.Forms.Button()
    Me.btnHit = New System.Windows.Forms.Button()
    Me.lstDealer = New System.Windows.Forms.ListBox()
    Me.lstPlayer = New System.Windows.Forms.ListBox()
    Me.txtOutput = New System.Windows.Forms.TextBox()
    Me.SuspendLayout
    '
    'txtDealer
    '
    Me.txtDealer.Location = New System.Drawing.Point(262, 95)
    Me.txtDealer.Name = "txtDealer"
    Me.txtDealer.ReadOnly = true
    Me.txtDealer.Size = New System.Drawing.Size(39, 20)
    Me.txtDealer.TabIndex = 15
    Me.txtDealer.TabStop = false
    Me.txtDealer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtPlayer
    '
    Me.txtPlayer.Location = New System.Drawing.Point(87, 93)
    Me.txtPlayer.Name = "txtPlayer"
    Me.txtPlayer.ReadOnly = true
    Me.txtPlayer.Size = New System.Drawing.Size(39, 20)
    Me.txtPlayer.TabIndex = 14
    Me.txtPlayer.TabStop = false
    Me.txtPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblDealer
    '
    Me.lblDealer.AutoSize = true
    Me.lblDealer.Location = New System.Drawing.Point(186, 97)
    Me.lblDealer.Name = "lblDealer"
    Me.lblDealer.Size = New System.Drawing.Size(68, 13)
    Me.lblDealer.TabIndex = 6
    Me.lblDealer.Text = "Dealer Total:"
    '
    'lblPlayer
    '
    Me.lblPlayer.AutoSize = true
    Me.lblPlayer.Location = New System.Drawing.Point(12, 95)
    Me.lblPlayer.Name = "lblPlayer"
    Me.lblPlayer.Size = New System.Drawing.Size(66, 13)
    Me.lblPlayer.TabIndex = 7
    Me.lblPlayer.Text = "Player Total:"
    '
    'btnNewHand
    '
    Me.btnNewHand.Location = New System.Drawing.Point(108, 118)
    Me.btnNewHand.Name = "btnNewHand"
    Me.btnNewHand.Size = New System.Drawing.Size(105, 29)
    Me.btnNewHand.TabIndex = 11
    Me.btnNewHand.Text = "New Hand"
    '
    'btnHold
    '
    Me.btnHold.Location = New System.Drawing.Point(234, 118)
    Me.btnHold.Name = "btnHold"
    Me.btnHold.Size = New System.Drawing.Size(67, 29)
    Me.btnHold.TabIndex = 13
    Me.btnHold.Text = "Hold"
    '
    'btnHit
    '
    Me.btnHit.Location = New System.Drawing.Point(12, 118)
    Me.btnHit.Name = "btnHit"
    Me.btnHit.Size = New System.Drawing.Size(77, 29)
    Me.btnHit.TabIndex = 12
    Me.btnHit.Text = "Hit Me"
    '
    'lstDealer
    '
    Me.lstDealer.FormattingEnabled = true
    Me.lstDealer.Location = New System.Drawing.Point(166, 12)
    Me.lstDealer.Name = "lstDealer"
    Me.lstDealer.Size = New System.Drawing.Size(135, 69)
    Me.lstDealer.TabIndex = 8
    Me.lstDealer.TabStop = false
    '
    'lstPlayer
    '
    Me.lstPlayer.FormattingEnabled = true
    Me.lstPlayer.Location = New System.Drawing.Point(12, 12)
    Me.lstPlayer.Name = "lstPlayer"
    Me.lstPlayer.Size = New System.Drawing.Size(135, 69)
    Me.lstPlayer.TabIndex = 9
    Me.lstPlayer.TabStop = false
    '
    'txtOutput
    '
    Me.txtOutput.Location = New System.Drawing.Point(12, 152)
    Me.txtOutput.Name = "txtOutput"
    Me.txtOutput.ReadOnly = true
    Me.txtOutput.Size = New System.Drawing.Size(289, 20)
    Me.txtOutput.TabIndex = 10
    Me.txtOutput.TabStop = false
    Me.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'frmBlackJack
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(311, 187)
    Me.Controls.Add(Me.txtDealer)
    Me.Controls.Add(Me.txtPlayer)
    Me.Controls.Add(Me.lblDealer)
    Me.Controls.Add(Me.lblPlayer)
    Me.Controls.Add(Me.btnNewHand)
    Me.Controls.Add(Me.btnHold)
    Me.Controls.Add(Me.btnHit)
    Me.Controls.Add(Me.lstDealer)
    Me.Controls.Add(Me.lstPlayer)
    Me.Controls.Add(Me.txtOutput)
    Me.Name = "frmBlackJack"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Black Jack"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents txtDealer As TextBox
  Friend WithEvents txtPlayer As TextBox
  Friend WithEvents lblDealer As Label
  Friend WithEvents lblPlayer As Label
  Friend WithEvents btnNewHand As Button
  Friend WithEvents btnHold As Button
  Friend WithEvents btnHit As Button
  Friend WithEvents lstDealer As ListBox
  Friend WithEvents lstPlayer As ListBox
  Friend WithEvents txtOutput As TextBox
End Class
