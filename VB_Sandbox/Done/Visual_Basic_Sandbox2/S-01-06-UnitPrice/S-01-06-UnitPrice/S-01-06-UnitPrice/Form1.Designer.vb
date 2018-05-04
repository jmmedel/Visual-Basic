<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnitPrice
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
    Me.txtPricePerOunce = New System.Windows.Forms.MaskedTextBox()
    Me.txtPounds = New System.Windows.Forms.MaskedTextBox()
    Me.lblError = New System.Windows.Forms.Label()
    Me.btnDetermine = New System.Windows.Forms.Button()
    Me.txtPriceOfItem = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtOunces = New System.Windows.Forms.MaskedTextBox()
    Me.SuspendLayout
    '
    'txtPricePerOunce
    '
    Me.txtPricePerOunce.Location = New System.Drawing.Point(138, 209)
    Me.txtPricePerOunce.Name = "txtPricePerOunce"
    Me.txtPricePerOunce.ReadOnly = true
    Me.txtPricePerOunce.Size = New System.Drawing.Size(100, 20)
    Me.txtPricePerOunce.TabIndex = 35
    Me.txtPricePerOunce.TabStop = false
    '
    'txtPounds
    '
    Me.txtPounds.Location = New System.Drawing.Point(81, 93)
    Me.txtPounds.Name = "txtPounds"
    Me.txtPounds.Size = New System.Drawing.Size(48, 20)
    Me.txtPounds.TabIndex = 1
    '
    'lblError
    '
    Me.lblError.AutoEllipsis = true
    Me.lblError.AutoSize = true
    Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblError.ForeColor = System.Drawing.Color.DarkRed
    Me.lblError.Location = New System.Drawing.Point(129, 164)
    Me.lblError.Name = "lblError"
    Me.lblError.Size = New System.Drawing.Size(0, 16)
    Me.lblError.TabIndex = 38
    Me.lblError.Visible = false
    '
    'btnDetermine
    '
    Me.btnDetermine.Location = New System.Drawing.Point(47, 141)
    Me.btnDetermine.Name = "btnDetermine"
    Me.btnDetermine.Size = New System.Drawing.Size(191, 39)
    Me.btnDetermine.TabIndex = 3
    Me.btnDetermine.Text = "Determine Unit Price"
    Me.btnDetermine.UseVisualStyleBackColor = true
    '
    'txtPriceOfItem
    '
    Me.txtPriceOfItem.Location = New System.Drawing.Point(128, 19)
    Me.txtPriceOfItem.Name = "txtPriceOfItem"
    Me.txtPriceOfItem.Size = New System.Drawing.Size(100, 20)
    Me.txtPriceOfItem.TabIndex = 0
    '
    'Label4
    '
    Me.Label4.AutoSize = true
    Me.Label4.Location = New System.Drawing.Point(47, 212)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(85, 13)
    Me.Label4.TabIndex = 31
    Me.Label4.Text = "Price Per Ounce"
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(32, 96)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(43, 13)
    Me.Label2.TabIndex = 30
    Me.Label2.Text = "Pounds"
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(56, 22)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(66, 13)
    Me.Label1.TabIndex = 29
    Me.Label1.Text = "Price of Item"
    '
    'Label5
    '
    Me.Label5.AutoSize = true
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.Label5.Location = New System.Drawing.Point(110, 57)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(65, 20)
    Me.Label5.TabIndex = 39
    Me.Label5.Text = "Weight"
    '
    'Label6
    '
    Me.Label6.AutoSize = true
    Me.Label6.Location = New System.Drawing.Point(155, 96)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(44, 13)
    Me.Label6.TabIndex = 30
    Me.Label6.Text = "Ounces"
    '
    'txtOunces
    '
    Me.txtOunces.Location = New System.Drawing.Point(204, 93)
    Me.txtOunces.Name = "txtOunces"
    Me.txtOunces.Size = New System.Drawing.Size(48, 20)
    Me.txtOunces.TabIndex = 2
    '
    'frmUnitPrice
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 261)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.txtPricePerOunce)
    Me.Controls.Add(Me.txtOunces)
    Me.Controls.Add(Me.txtPounds)
    Me.Controls.Add(Me.lblError)
    Me.Controls.Add(Me.btnDetermine)
    Me.Controls.Add(Me.txtPriceOfItem)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmUnitPrice"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Unit Price"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents txtPricePerOunce As MaskedTextBox
  Friend WithEvents txtPounds As MaskedTextBox
  Friend WithEvents lblError As Label
  Friend WithEvents btnDetermine As Button
  Friend WithEvents txtPriceOfItem As TextBox
  Friend WithEvents Label4 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents Label5 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents txtOunces As MaskedTextBox
End Class
