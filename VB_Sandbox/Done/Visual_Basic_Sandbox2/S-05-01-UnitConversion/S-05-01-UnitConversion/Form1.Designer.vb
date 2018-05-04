<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnitConversion
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
    Me.txtDesired = New System.Windows.Forms.TextBox()
    Me.txtOriginal = New System.Windows.Forms.TextBox()
    Me.txtLength = New System.Windows.Forms.TextBox()
    Me.btnConvert = New System.Windows.Forms.Button()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lstUnits = New System.Windows.Forms.ListBox()
    Me.SuspendLayout
    '
    'txtOutput
    '
    Me.txtOutput.Location = New System.Drawing.Point(248, 171)
    Me.txtOutput.Name = "txtOutput"
    Me.txtOutput.ReadOnly = true
    Me.txtOutput.Size = New System.Drawing.Size(97, 20)
    Me.txtOutput.TabIndex = 19
    Me.txtOutput.TabStop = false
    '
    'txtDesired
    '
    Me.txtDesired.Location = New System.Drawing.Point(248, 87)
    Me.txtDesired.Name = "txtDesired"
    Me.txtDesired.ReadOnly = true
    Me.txtDesired.Size = New System.Drawing.Size(100, 20)
    Me.txtDesired.TabIndex = 14
    '
    'txtOriginal
    '
    Me.txtOriginal.Location = New System.Drawing.Point(248, 47)
    Me.txtOriginal.Name = "txtOriginal"
    Me.txtOriginal.ReadOnly = true
    Me.txtOriginal.Size = New System.Drawing.Size(100, 20)
    Me.txtOriginal.TabIndex = 12
    '
    'txtLength
    '
    Me.txtLength.Location = New System.Drawing.Point(248, 12)
    Me.txtLength.Name = "txtLength"
    Me.txtLength.Size = New System.Drawing.Size(100, 20)
    Me.txtLength.TabIndex = 10
    '
    'btnConvert
    '
    Me.btnConvert.Location = New System.Drawing.Point(151, 117)
    Me.btnConvert.Name = "btnConvert"
    Me.btnConvert.Size = New System.Drawing.Size(197, 29)
    Me.btnConvert.TabIndex = 16
    Me.btnConvert.Text = "Convert"
    Me.btnConvert.UseVisualStyleBackColor = true
    '
    'Label4
    '
    Me.Label4.AutoSize = true
    Me.Label4.Location = New System.Drawing.Point(148, 174)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(79, 13)
    Me.Label4.TabIndex = 18
    Me.Label4.Text = "Desired Length"
    '
    'Label3
    '
    Me.Label3.AutoSize = true
    Me.Label3.Location = New System.Drawing.Point(147, 90)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(94, 13)
    Me.Label3.TabIndex = 17
    Me.Label3.Text = "Desired Units (1-9)"
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(148, 50)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(93, 13)
    Me.Label2.TabIndex = 15
    Me.Label2.Text = "Original Units (1-9)"
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(148, 12)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(92, 13)
    Me.Label1.TabIndex = 13
    Me.Label1.Text = "Length to Convert"
    '
    'lstUnits
    '
    Me.lstUnits.FormattingEnabled = true
    Me.lstUnits.Items.AddRange(New Object() {"1. inch", "2. fathom", "3. foot", "4. furlong", "5. kilometer", "6. meter", "7. mile", "8. rod", "9. yard"})
    Me.lstUnits.Location = New System.Drawing.Point(12, 12)
    Me.lstUnits.Name = "lstUnits"
    Me.lstUnits.Size = New System.Drawing.Size(120, 134)
    Me.lstUnits.TabIndex = 11
    Me.lstUnits.TabStop = false
    '
    'frmUnitConversion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(373, 219)
    Me.Controls.Add(Me.txtOutput)
    Me.Controls.Add(Me.txtDesired)
    Me.Controls.Add(Me.txtOriginal)
    Me.Controls.Add(Me.txtLength)
    Me.Controls.Add(Me.btnConvert)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lstUnits)
    Me.Name = "frmUnitConversion"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Unit Conversion"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents txtOutput As TextBox
  Friend WithEvents txtDesired As TextBox
  Friend WithEvents txtOriginal As TextBox
  Friend WithEvents txtLength As TextBox
  Friend WithEvents btnConvert As Button
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents lstUnits As ListBox
End Class
