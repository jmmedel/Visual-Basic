<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPoker
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
    Me.mtbSuit5 = New System.Windows.Forms.MaskedTextBox()
    Me.mtbSuit4 = New System.Windows.Forms.MaskedTextBox()
    Me.mtbSuit3 = New System.Windows.Forms.MaskedTextBox()
    Me.mtbSuit2 = New System.Windows.Forms.MaskedTextBox()
    Me.mtbSuit1 = New System.Windows.Forms.MaskedTextBox()
    Me.txtOutput = New System.Windows.Forms.TextBox()
    Me.lblSuit = New System.Windows.Forms.Label()
    Me.txtDenomination5 = New System.Windows.Forms.TextBox()
    Me.lblDenomination5 = New System.Windows.Forms.Label()
    Me.txtDenomination4 = New System.Windows.Forms.TextBox()
    Me.lblDenomination4 = New System.Windows.Forms.Label()
    Me.txtDenomination3 = New System.Windows.Forms.TextBox()
    Me.lblDenomination3 = New System.Windows.Forms.Label()
    Me.txtDenomination2 = New System.Windows.Forms.TextBox()
    Me.lblDenomination2 = New System.Windows.Forms.Label()
    Me.lblDenomination = New System.Windows.Forms.Label()
    Me.btnDisplay = New System.Windows.Forms.Button()
    Me.txtDenomination1 = New System.Windows.Forms.TextBox()
    Me.lblDenomination1 = New System.Windows.Forms.Label()
    Me.SuspendLayout
    '
    'mtbSuit5
    '
    Me.mtbSuit5.Location = New System.Drawing.Point(169, 165)
    Me.mtbSuit5.Mask = "L"
    Me.mtbSuit5.Name = "mtbSuit5"
    Me.mtbSuit5.Size = New System.Drawing.Size(14, 20)
    Me.mtbSuit5.TabIndex = 35
    '
    'mtbSuit4
    '
    Me.mtbSuit4.Location = New System.Drawing.Point(169, 138)
    Me.mtbSuit4.Mask = "L"
    Me.mtbSuit4.Name = "mtbSuit4"
    Me.mtbSuit4.Size = New System.Drawing.Size(14, 20)
    Me.mtbSuit4.TabIndex = 32
    '
    'mtbSuit3
    '
    Me.mtbSuit3.Location = New System.Drawing.Point(169, 114)
    Me.mtbSuit3.Mask = "L"
    Me.mtbSuit3.Name = "mtbSuit3"
    Me.mtbSuit3.Size = New System.Drawing.Size(14, 20)
    Me.mtbSuit3.TabIndex = 29
    '
    'mtbSuit2
    '
    Me.mtbSuit2.Location = New System.Drawing.Point(169, 90)
    Me.mtbSuit2.Mask = "L"
    Me.mtbSuit2.Name = "mtbSuit2"
    Me.mtbSuit2.Size = New System.Drawing.Size(14, 20)
    Me.mtbSuit2.TabIndex = 26
    '
    'mtbSuit1
    '
    Me.mtbSuit1.Location = New System.Drawing.Point(169, 67)
    Me.mtbSuit1.Mask = "L"
    Me.mtbSuit1.Name = "mtbSuit1"
    Me.mtbSuit1.Size = New System.Drawing.Size(14, 20)
    Me.mtbSuit1.TabIndex = 23
    '
    'txtOutput
    '
    Me.txtOutput.Location = New System.Drawing.Point(39, 230)
    Me.txtOutput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtOutput.MaxLength = 1
    Me.txtOutput.Name = "txtOutput"
    Me.txtOutput.ReadOnly = true
    Me.txtOutput.Size = New System.Drawing.Size(162, 20)
    Me.txtOutput.TabIndex = 37
    Me.txtOutput.TabStop = false
    '
    'lblSuit
    '
    Me.lblSuit.Location = New System.Drawing.Point(122, 21)
    Me.lblSuit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblSuit.Name = "lblSuit"
    Me.lblSuit.Size = New System.Drawing.Size(116, 41)
    Me.lblSuit.TabIndex = 20
    Me.lblSuit.Text = "Suit:  Diamonds=D, Hearts=H, Clubs=C, Spades=S"
    '
    'txtDenomination5
    '
    Me.txtDenomination5.Location = New System.Drawing.Point(78, 166)
    Me.txtDenomination5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtDenomination5.MaxLength = 2
    Me.txtDenomination5.Name = "txtDenomination5"
    Me.txtDenomination5.Size = New System.Drawing.Size(38, 20)
    Me.txtDenomination5.TabIndex = 34
    '
    'lblDenomination5
    '
    Me.lblDenomination5.AutoSize = true
    Me.lblDenomination5.Location = New System.Drawing.Point(27, 166)
    Me.lblDenomination5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblDenomination5.Name = "lblDenomination5"
    Me.lblDenomination5.Size = New System.Drawing.Size(48, 13)
    Me.lblDenomination5.TabIndex = 33
    Me.lblDenomination5.Text = "Card #5:"
    Me.lblDenomination5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'txtDenomination4
    '
    Me.txtDenomination4.Location = New System.Drawing.Point(78, 139)
    Me.txtDenomination4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtDenomination4.MaxLength = 2
    Me.txtDenomination4.Name = "txtDenomination4"
    Me.txtDenomination4.Size = New System.Drawing.Size(38, 20)
    Me.txtDenomination4.TabIndex = 31
    '
    'lblDenomination4
    '
    Me.lblDenomination4.AutoSize = true
    Me.lblDenomination4.Location = New System.Drawing.Point(27, 142)
    Me.lblDenomination4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblDenomination4.Name = "lblDenomination4"
    Me.lblDenomination4.Size = New System.Drawing.Size(48, 13)
    Me.lblDenomination4.TabIndex = 30
    Me.lblDenomination4.Text = "Card #4:"
    Me.lblDenomination4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'txtDenomination3
    '
    Me.txtDenomination3.Location = New System.Drawing.Point(78, 116)
    Me.txtDenomination3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtDenomination3.MaxLength = 2
    Me.txtDenomination3.Name = "txtDenomination3"
    Me.txtDenomination3.Size = New System.Drawing.Size(38, 20)
    Me.txtDenomination3.TabIndex = 28
    '
    'lblDenomination3
    '
    Me.lblDenomination3.AutoSize = true
    Me.lblDenomination3.Location = New System.Drawing.Point(27, 118)
    Me.lblDenomination3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblDenomination3.Name = "lblDenomination3"
    Me.lblDenomination3.Size = New System.Drawing.Size(48, 13)
    Me.lblDenomination3.TabIndex = 27
    Me.lblDenomination3.Text = "Card #3:"
    Me.lblDenomination3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'txtDenomination2
    '
    Me.txtDenomination2.Location = New System.Drawing.Point(78, 91)
    Me.txtDenomination2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtDenomination2.MaxLength = 2
    Me.txtDenomination2.Name = "txtDenomination2"
    Me.txtDenomination2.Size = New System.Drawing.Size(38, 20)
    Me.txtDenomination2.TabIndex = 25
    '
    'lblDenomination2
    '
    Me.lblDenomination2.AutoSize = true
    Me.lblDenomination2.Location = New System.Drawing.Point(27, 94)
    Me.lblDenomination2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblDenomination2.Name = "lblDenomination2"
    Me.lblDenomination2.Size = New System.Drawing.Size(48, 13)
    Me.lblDenomination2.TabIndex = 24
    Me.lblDenomination2.Text = "Card #2:"
    Me.lblDenomination2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'lblDenomination
    '
    Me.lblDenomination.Location = New System.Drawing.Point(13, 21)
    Me.lblDenomination.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblDenomination.Name = "lblDenomination"
    Me.lblDenomination.Size = New System.Drawing.Size(106, 41)
    Me.lblDenomination.TabIndex = 19
    Me.lblDenomination.Text = "Denomination: Ace=1, Jack=11, Queen=12, King=13"
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(39, 195)
    Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(160, 29)
    Me.btnDisplay.TabIndex = 36
    Me.btnDisplay.Text = "Display Type of Hand"
    '
    'txtDenomination1
    '
    Me.txtDenomination1.Location = New System.Drawing.Point(78, 67)
    Me.txtDenomination1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtDenomination1.MaxLength = 2
    Me.txtDenomination1.Name = "txtDenomination1"
    Me.txtDenomination1.Size = New System.Drawing.Size(38, 20)
    Me.txtDenomination1.TabIndex = 22
    '
    'lblDenomination1
    '
    Me.lblDenomination1.AutoSize = true
    Me.lblDenomination1.Location = New System.Drawing.Point(27, 70)
    Me.lblDenomination1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblDenomination1.Name = "lblDenomination1"
    Me.lblDenomination1.Size = New System.Drawing.Size(48, 13)
    Me.lblDenomination1.TabIndex = 21
    Me.lblDenomination1.Text = "Card #1:"
    Me.lblDenomination1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
    '
    'frmPoker
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(251, 258)
    Me.Controls.Add(Me.mtbSuit5)
    Me.Controls.Add(Me.mtbSuit4)
    Me.Controls.Add(Me.mtbSuit3)
    Me.Controls.Add(Me.mtbSuit2)
    Me.Controls.Add(Me.mtbSuit1)
    Me.Controls.Add(Me.txtOutput)
    Me.Controls.Add(Me.lblSuit)
    Me.Controls.Add(Me.txtDenomination5)
    Me.Controls.Add(Me.lblDenomination5)
    Me.Controls.Add(Me.txtDenomination4)
    Me.Controls.Add(Me.lblDenomination4)
    Me.Controls.Add(Me.txtDenomination3)
    Me.Controls.Add(Me.lblDenomination3)
    Me.Controls.Add(Me.txtDenomination2)
    Me.Controls.Add(Me.lblDenomination2)
    Me.Controls.Add(Me.lblDenomination)
    Me.Controls.Add(Me.btnDisplay)
    Me.Controls.Add(Me.txtDenomination1)
    Me.Controls.Add(Me.lblDenomination1)
    Me.Name = "frmPoker"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Poker"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents mtbSuit5 As MaskedTextBox
  Friend WithEvents mtbSuit4 As MaskedTextBox
  Friend WithEvents mtbSuit3 As MaskedTextBox
  Friend WithEvents mtbSuit2 As MaskedTextBox
  Friend WithEvents mtbSuit1 As MaskedTextBox
  Friend WithEvents txtOutput As TextBox
  Friend WithEvents lblSuit As Label
  Friend WithEvents txtDenomination5 As TextBox
  Friend WithEvents lblDenomination5 As Label
  Friend WithEvents txtDenomination4 As TextBox
  Friend WithEvents lblDenomination4 As Label
  Friend WithEvents txtDenomination3 As TextBox
  Friend WithEvents lblDenomination3 As Label
  Friend WithEvents txtDenomination2 As TextBox
  Friend WithEvents lblDenomination2 As Label
  Friend WithEvents lblDenomination As Label
  Friend WithEvents btnDisplay As Button
  Friend WithEvents txtDenomination1 As TextBox
  Friend WithEvents lblDenomination1 As Label
End Class
