<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStickGame
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
    Me.lblPlayer = New System.Windows.Forms.Label()
    Me.btnQuit = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtPileStatus = New System.Windows.Forms.TextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnThree = New System.Windows.Forms.Button()
    Me.btnTwo = New System.Windows.Forms.Button()
    Me.btnOne = New System.Windows.Forms.Button()
    Me.btnStart = New System.Windows.Forms.Button()
    Me.SuspendLayout
    '
    'lblPlayer
    '
    Me.lblPlayer.AutoSize = true
    Me.lblPlayer.Location = New System.Drawing.Point(40, 25)
    Me.lblPlayer.Name = "lblPlayer"
    Me.lblPlayer.Size = New System.Drawing.Size(0, 13)
    Me.lblPlayer.TabIndex = 18
    '
    'btnQuit
    '
    Me.btnQuit.Location = New System.Drawing.Point(370, 25)
    Me.btnQuit.Name = "btnQuit"
    Me.btnQuit.Size = New System.Drawing.Size(48, 38)
    Me.btnQuit.TabIndex = 17
    Me.btnQuit.Text = "Quit"
    Me.btnQuit.UseVisualStyleBackColor = true
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(17, 128)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(89, 26)
    Me.Label2.TabIndex = 16
    Me.Label2.Text = "Current Status of "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"the Pile"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtPileStatus
    '
    Me.txtPileStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.txtPileStatus.Location = New System.Drawing.Point(112, 128)
    Me.txtPileStatus.Name = "txtPileStatus"
    Me.txtPileStatus.ReadOnly = true
    Me.txtPileStatus.Size = New System.Drawing.Size(306, 26)
    Me.txtPileStatus.TabIndex = 15
    Me.txtPileStatus.TabStop = false
    Me.txtPileStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(17, 75)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(123, 26)
    Me.Label1.TabIndex = 14
    Me.Label1.Text = "How Many Sticks "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Would You Like To Pick"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'btnThree
    '
    Me.btnThree.Location = New System.Drawing.Point(341, 78)
    Me.btnThree.Name = "btnThree"
    Me.btnThree.Size = New System.Drawing.Size(75, 23)
    Me.btnThree.TabIndex = 13
    Me.btnThree.Text = "Three Sticks"
    Me.btnThree.UseVisualStyleBackColor = true
    '
    'btnTwo
    '
    Me.btnTwo.Location = New System.Drawing.Point(260, 78)
    Me.btnTwo.Name = "btnTwo"
    Me.btnTwo.Size = New System.Drawing.Size(75, 23)
    Me.btnTwo.TabIndex = 12
    Me.btnTwo.Text = "Two Sticks"
    Me.btnTwo.UseVisualStyleBackColor = true
    '
    'btnOne
    '
    Me.btnOne.Location = New System.Drawing.Point(179, 78)
    Me.btnOne.Name = "btnOne"
    Me.btnOne.Size = New System.Drawing.Size(75, 23)
    Me.btnOne.TabIndex = 11
    Me.btnOne.Text = "One Stick"
    Me.btnOne.UseVisualStyleBackColor = true
    '
    'btnStart
    '
    Me.btnStart.Location = New System.Drawing.Point(242, 25)
    Me.btnStart.Name = "btnStart"
    Me.btnStart.Size = New System.Drawing.Size(101, 38)
    Me.btnStart.TabIndex = 10
    Me.btnStart.Text = "Start New Game"
    Me.btnStart.UseVisualStyleBackColor = true
    '
    'frmStickGame
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(438, 179)
    Me.Controls.Add(Me.lblPlayer)
    Me.Controls.Add(Me.btnQuit)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.txtPileStatus)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnThree)
    Me.Controls.Add(Me.btnTwo)
    Me.Controls.Add(Me.btnOne)
    Me.Controls.Add(Me.btnStart)
    Me.Name = "frmStickGame"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Stick Game"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents lblPlayer As Label
  Friend WithEvents btnQuit As Button
  Friend WithEvents Label2 As Label
  Friend WithEvents txtPileStatus As TextBox
  Friend WithEvents Label1 As Label
  Friend WithEvents btnThree As Button
  Friend WithEvents btnTwo As Button
  Friend WithEvents btnOne As Button
  Friend WithEvents btnStart As Button
End Class
