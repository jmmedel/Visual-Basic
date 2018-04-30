<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUPC
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
    Me.mtbUPC = New System.Windows.Forms.MaskedTextBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lstReceipt = New System.Windows.Forms.ListBox()
    Me.btnDisplayReceipt = New System.Windows.Forms.Button()
    Me.btnAdd = New System.Windows.Forms.Button()
    Me.btnCustomer = New System.Windows.Forms.Button()
    Me.SuspendLayout
    '
    'mtbUPC
    '
    Me.mtbUPC.Location = New System.Drawing.Point(57, 82)
    Me.mtbUPC.Mask = "000000000000"
    Me.mtbUPC.Name = "mtbUPC"
    Me.mtbUPC.Size = New System.Drawing.Size(109, 20)
    Me.mtbUPC.TabIndex = 5
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(22, 87)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(29, 13)
    Me.Label1.TabIndex = 10
    Me.Label1.Text = "UPC"
    '
    'lstReceipt
    '
    Me.lstReceipt.FormattingEnabled = true
    Me.lstReceipt.Location = New System.Drawing.Point(25, 115)
    Me.lstReceipt.Name = "lstReceipt"
    Me.lstReceipt.Size = New System.Drawing.Size(325, 121)
    Me.lstReceipt.TabIndex = 8
    Me.lstReceipt.TabStop = false
    '
    'btnDisplayReceipt
    '
    Me.btnDisplayReceipt.Location = New System.Drawing.Point(209, 60)
    Me.btnDisplayReceipt.Name = "btnDisplayReceipt"
    Me.btnDisplayReceipt.Size = New System.Drawing.Size(141, 40)
    Me.btnDisplayReceipt.TabIndex = 7
    Me.btnDisplayReceipt.Text = "Display Receipt"
    Me.btnDisplayReceipt.UseVisualStyleBackColor = true
    '
    'btnAdd
    '
    Me.btnAdd.Location = New System.Drawing.Point(209, 7)
    Me.btnAdd.Name = "btnAdd"
    Me.btnAdd.Size = New System.Drawing.Size(141, 44)
    Me.btnAdd.TabIndex = 6
    Me.btnAdd.Text = "Add to Receipt"
    Me.btnAdd.UseVisualStyleBackColor = true
    '
    'btnCustomer
    '
    Me.btnCustomer.Location = New System.Drawing.Point(25, 12)
    Me.btnCustomer.Name = "btnCustomer"
    Me.btnCustomer.Size = New System.Drawing.Size(141, 40)
    Me.btnCustomer.TabIndex = 9
    Me.btnCustomer.Text = "New Customer"
    Me.btnCustomer.UseVisualStyleBackColor = true
    '
    'frmUPC
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(372, 258)
    Me.Controls.Add(Me.mtbUPC)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lstReceipt)
    Me.Controls.Add(Me.btnDisplayReceipt)
    Me.Controls.Add(Me.btnAdd)
    Me.Controls.Add(Me.btnCustomer)
    Me.Name = "frmUPC"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "UPC"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents mtbUPC As MaskedTextBox
  Friend WithEvents Label1 As Label
  Friend WithEvents lstReceipt As ListBox
  Friend WithEvents btnDisplayReceipt As Button
  Friend WithEvents btnAdd As Button
  Friend WithEvents btnCustomer As Button
End Class
