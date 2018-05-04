<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepreciation
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
    Me.lstOutput = New System.Windows.Forms.ListBox()
    Me.txtNumYears = New System.Windows.Forms.TextBox()
    Me.lblnumYears = New System.Windows.Forms.Label()
    Me.txtCost = New System.Windows.Forms.TextBox()
    Me.lblCost = New System.Windows.Forms.Label()
    Me.txtYear = New System.Windows.Forms.TextBox()
    Me.txtDesc = New System.Windows.Forms.TextBox()
    Me.lblYear = New System.Windows.Forms.Label()
    Me.lblDesc = New System.Windows.Forms.Label()
    Me.btnDouble = New System.Windows.Forms.Button()
    Me.btnStraight = New System.Windows.Forms.Button()
    Me.SuspendLayout
    '
    'lstOutput
    '
    Me.lstOutput.FormattingEnabled = true
    Me.lstOutput.Location = New System.Drawing.Point(27, 139)
    Me.lstOutput.Name = "lstOutput"
    Me.lstOutput.Size = New System.Drawing.Size(259, 173)
    Me.lstOutput.TabIndex = 24
    '
    'txtNumYears
    '
    Me.txtNumYears.Location = New System.Drawing.Point(247, 42)
    Me.txtNumYears.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtNumYears.Name = "txtNumYears"
    Me.txtNumYears.Size = New System.Drawing.Size(21, 20)
    Me.txtNumYears.TabIndex = 23
    '
    'lblnumYears
    '
    Me.lblnumYears.Location = New System.Drawing.Point(151, 34)
    Me.lblnumYears.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.lblnumYears.Name = "lblnumYears"
    Me.lblnumYears.Size = New System.Drawing.Size(88, 32)
    Me.lblnumYears.TabIndex = 22
    Me.lblnumYears.Text = "Estimated life of item (years): "
    '
    'txtCost
    '
    Me.txtCost.Location = New System.Drawing.Point(218, 12)
    Me.txtCost.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtCost.Name = "txtCost"
    Me.txtCost.Size = New System.Drawing.Size(50, 20)
    Me.txtCost.TabIndex = 21
    '
    'lblCost
    '
    Me.lblCost.AutoSize = true
    Me.lblCost.Location = New System.Drawing.Point(179, 15)
    Me.lblCost.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.lblCost.Name = "lblCost"
    Me.lblCost.Size = New System.Drawing.Size(31, 13)
    Me.lblCost.TabIndex = 20
    Me.lblCost.Text = "Cost:"
    '
    'txtYear
    '
    Me.txtYear.Location = New System.Drawing.Point(108, 42)
    Me.txtYear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtYear.Name = "txtYear"
    Me.txtYear.Size = New System.Drawing.Size(30, 20)
    Me.txtYear.TabIndex = 15
    '
    'txtDesc
    '
    Me.txtDesc.Location = New System.Drawing.Point(81, 12)
    Me.txtDesc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtDesc.Name = "txtDesc"
    Me.txtDesc.Size = New System.Drawing.Size(78, 20)
    Me.txtDesc.TabIndex = 14
    '
    'lblYear
    '
    Me.lblYear.Location = New System.Drawing.Point(51, 35)
    Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.lblYear.Name = "lblYear"
    Me.lblYear.Size = New System.Drawing.Size(56, 32)
    Me.lblYear.TabIndex = 19
    Me.lblYear.Text = "Year of purchase:"
    '
    'lblDesc
    '
    Me.lblDesc.Location = New System.Drawing.Point(41, 15)
    Me.lblDesc.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.lblDesc.Name = "lblDesc"
    Me.lblDesc.Size = New System.Drawing.Size(32, 19)
    Me.lblDesc.TabIndex = 18
    Me.lblDesc.Text = "Item:"
    '
    'btnDouble
    '
    Me.btnDouble.Location = New System.Drawing.Point(75, 104)
    Me.btnDouble.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.btnDouble.Name = "btnDouble"
    Me.btnDouble.Size = New System.Drawing.Size(177, 29)
    Me.btnDouble.TabIndex = 17
    Me.btnDouble.Text = "Double-Declining-Balance Method"
    '
    'btnStraight
    '
    Me.btnStraight.Location = New System.Drawing.Point(75, 68)
    Me.btnStraight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.btnStraight.Name = "btnStraight"
    Me.btnStraight.Size = New System.Drawing.Size(177, 29)
    Me.btnStraight.TabIndex = 16
    Me.btnStraight.Text = "Straight-Line Method"
    '
    'frmDepreciation
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(317, 337)
    Me.Controls.Add(Me.lstOutput)
    Me.Controls.Add(Me.txtNumYears)
    Me.Controls.Add(Me.lblnumYears)
    Me.Controls.Add(Me.txtCost)
    Me.Controls.Add(Me.lblCost)
    Me.Controls.Add(Me.txtYear)
    Me.Controls.Add(Me.txtDesc)
    Me.Controls.Add(Me.lblYear)
    Me.Controls.Add(Me.lblDesc)
    Me.Controls.Add(Me.btnDouble)
    Me.Controls.Add(Me.btnStraight)
    Me.Name = "frmDepreciation"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Depreciation"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents lstOutput As ListBox
  Friend WithEvents txtNumYears As TextBox
  Friend WithEvents lblnumYears As Label
  Friend WithEvents txtCost As TextBox
  Friend WithEvents lblCost As Label
  Friend WithEvents txtYear As TextBox
  Friend WithEvents txtDesc As TextBox
  Friend WithEvents lblYear As Label
  Friend WithEvents lblDesc As Label
  Friend WithEvents btnDouble As Button
  Friend WithEvents btnStraight As Button
End Class
