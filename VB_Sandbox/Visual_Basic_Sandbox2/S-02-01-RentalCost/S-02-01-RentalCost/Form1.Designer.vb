<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRentalCost
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
    Me.btnDisplayRates = New System.Windows.Forms.Button()
    Me.btnDisplayBill = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.txtItem = New System.Windows.Forms.TextBox()
    Me.txtDuration = New System.Windows.Forms.TextBox()
    Me.lstRentalRates = New System.Windows.Forms.ListBox()
    Me.lstBill = New System.Windows.Forms.ListBox()
    Me.SuspendLayout
    '
    'btnDisplayRates
    '
    Me.btnDisplayRates.Location = New System.Drawing.Point(19, 33)
    Me.btnDisplayRates.Name = "btnDisplayRates"
    Me.btnDisplayRates.Size = New System.Drawing.Size(152, 53)
    Me.btnDisplayRates.TabIndex = 0
    Me.btnDisplayRates.Text = "Display Rental Rates"
    Me.btnDisplayRates.UseVisualStyleBackColor = true
    '
    'btnDisplayBill
    '
    Me.btnDisplayBill.Location = New System.Drawing.Point(19, 187)
    Me.btnDisplayBill.Name = "btnDisplayBill"
    Me.btnDisplayBill.Size = New System.Drawing.Size(152, 53)
    Me.btnDisplayBill.TabIndex = 3
    Me.btnDisplayBill.Text = "Display Customer Bill"
    Me.btnDisplayBill.UseVisualStyleBackColor = true
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(26, 110)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(111, 13)
    Me.Label1.TabIndex = 2
    Me.Label1.Text = "Select Item (1, 2, or 3)"
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(16, 152)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(121, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Select Duration (H, or F)"
    '
    'txtItem
    '
    Me.txtItem.Location = New System.Drawing.Point(143, 107)
    Me.txtItem.Name = "txtItem"
    Me.txtItem.Size = New System.Drawing.Size(28, 20)
    Me.txtItem.TabIndex = 1
    '
    'txtDuration
    '
    Me.txtDuration.Location = New System.Drawing.Point(143, 145)
    Me.txtDuration.Name = "txtDuration"
    Me.txtDuration.Size = New System.Drawing.Size(28, 20)
    Me.txtDuration.TabIndex = 2
    '
    'lstRentalRates
    '
    Me.lstRentalRates.FormattingEnabled = true
    Me.lstRentalRates.Location = New System.Drawing.Point(187, 33)
    Me.lstRentalRates.Name = "lstRentalRates"
    Me.lstRentalRates.Size = New System.Drawing.Size(281, 95)
    Me.lstRentalRates.TabIndex = 6
    Me.lstRentalRates.TabStop = false
    '
    'lstBill
    '
    Me.lstBill.FormattingEnabled = true
    Me.lstBill.Location = New System.Drawing.Point(187, 145)
    Me.lstBill.Name = "lstBill"
    Me.lstBill.Size = New System.Drawing.Size(281, 95)
    Me.lstBill.TabIndex = 7
    Me.lstBill.TabStop = false
    '
    'FrmRentalCost
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(496, 276)
    Me.Controls.Add(Me.lstBill)
    Me.Controls.Add(Me.lstRentalRates)
    Me.Controls.Add(Me.txtDuration)
    Me.Controls.Add(Me.txtItem)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnDisplayBill)
    Me.Controls.Add(Me.btnDisplayRates)
    Me.Name = "FrmRentalCost"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Rental Cost"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents btnDisplayRates As Button
  Friend WithEvents btnDisplayBill As Button
  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents txtItem As TextBox
  Friend WithEvents txtDuration As TextBox
  Friend WithEvents lstRentalRates As ListBox
  Friend WithEvents lstBill As ListBox
End Class
