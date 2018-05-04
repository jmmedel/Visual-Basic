<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLengthConversion
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
    Me.txtFeet = New System.Windows.Forms.MaskedTextBox()
    Me.txtYards = New System.Windows.Forms.MaskedTextBox()
    Me.lblError = New System.Windows.Forms.Label()
    Me.btnConvert = New System.Windows.Forms.Button()
    Me.lstMetric = New System.Windows.Forms.ListBox()
    Me.txtMiles = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtInches = New System.Windows.Forms.MaskedTextBox()
    Me.SuspendLayout
    '
    'txtFeet
    '
    Me.txtFeet.Location = New System.Drawing.Point(74, 92)
    Me.txtFeet.Name = "txtFeet"
    Me.txtFeet.Size = New System.Drawing.Size(100, 20)
    Me.txtFeet.TabIndex = 2
    '
    'txtYards
    '
    Me.txtYards.Location = New System.Drawing.Point(74, 57)
    Me.txtYards.Name = "txtYards"
    Me.txtYards.Size = New System.Drawing.Size(100, 20)
    Me.txtYards.TabIndex = 1
    '
    'lblError
    '
    Me.lblError.AutoEllipsis = true
    Me.lblError.AutoSize = true
    Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblError.ForeColor = System.Drawing.Color.DarkRed
    Me.lblError.Location = New System.Drawing.Point(71, 128)
    Me.lblError.Name = "lblError"
    Me.lblError.Size = New System.Drawing.Size(0, 16)
    Me.lblError.TabIndex = 17
    Me.lblError.Visible = false
    '
    'btnConvert
    '
    Me.btnConvert.Location = New System.Drawing.Point(205, 22)
    Me.btnConvert.Name = "btnConvert"
    Me.btnConvert.Size = New System.Drawing.Size(143, 39)
    Me.btnConvert.TabIndex = 4
    Me.btnConvert.Text = "Convert To Metric"
    Me.btnConvert.UseVisualStyleBackColor = true
    '
    'lstMetric
    '
    Me.lstMetric.FormattingEnabled = true
    Me.lstMetric.Location = New System.Drawing.Point(205, 77)
    Me.lstMetric.Name = "lstMetric"
    Me.lstMetric.Size = New System.Drawing.Size(143, 69)
    Me.lstMetric.TabIndex = 15
    Me.lstMetric.TabStop = false
    '
    'txtMiles
    '
    Me.txtMiles.Location = New System.Drawing.Point(74, 22)
    Me.txtMiles.Name = "txtMiles"
    Me.txtMiles.Size = New System.Drawing.Size(100, 20)
    Me.txtMiles.TabIndex = 0
    '
    'Label3
    '
    Me.Label3.AutoSize = true
    Me.Label3.Location = New System.Drawing.Point(40, 95)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(28, 13)
    Me.Label3.TabIndex = 11
    Me.Label3.Text = "Feet"
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(34, 60)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(34, 13)
    Me.Label2.TabIndex = 10
    Me.Label2.Text = "Yards"
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(37, 25)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(31, 13)
    Me.Label1.TabIndex = 9
    Me.Label1.Text = "Miles"
    '
    'Label4
    '
    Me.Label4.AutoSize = true
    Me.Label4.Location = New System.Drawing.Point(26, 130)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(39, 13)
    Me.Label4.TabIndex = 11
    Me.Label4.Text = "Inches"
    '
    'txtInches
    '
    Me.txtInches.Location = New System.Drawing.Point(74, 127)
    Me.txtInches.Name = "txtInches"
    Me.txtInches.Size = New System.Drawing.Size(100, 20)
    Me.txtInches.TabIndex = 3
    '
    'FrmLengthConversion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(380, 182)
    Me.Controls.Add(Me.txtInches)
    Me.Controls.Add(Me.txtFeet)
    Me.Controls.Add(Me.txtYards)
    Me.Controls.Add(Me.lblError)
    Me.Controls.Add(Me.btnConvert)
    Me.Controls.Add(Me.lstMetric)
    Me.Controls.Add(Me.txtMiles)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "FrmLengthConversion"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Length Conversion"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents txtFeet As MaskedTextBox
  Friend WithEvents txtYards As MaskedTextBox
  Friend WithEvents lblError As Label
  Friend WithEvents btnConvert As Button
  Friend WithEvents lstMetric As ListBox
  Friend WithEvents txtMiles As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents txtInches As MaskedTextBox
End Class
