<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
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
    Me.txtFirst = New System.Windows.Forms.TextBox()
    Me.txtSecond = New System.Windows.Forms.TextBox()
    Me.txtResults = New System.Windows.Forms.TextBox()
    Me.lblSecond = New System.Windows.Forms.Label()
    Me.lblFirst = New System.Windows.Forms.Label()
    Me.btnMultiply = New System.Windows.Forms.Button()
    Me.btnMinus = New System.Windows.Forms.Button()
    Me.btnPlus = New System.Windows.Forms.Button()
    Me.SuspendLayout()
    '
    'txtFirst
    '
    Me.txtFirst.Location = New System.Drawing.Point(28, 90)
    Me.txtFirst.Name = "txtFirst"
    Me.txtFirst.Size = New System.Drawing.Size(48, 20)
    Me.txtFirst.TabIndex = 6
    '
    'txtSecond
    '
    Me.txtSecond.Location = New System.Drawing.Point(212, 90)
    Me.txtSecond.Name = "txtSecond"
    Me.txtSecond.Size = New System.Drawing.Size(48, 20)
    Me.txtSecond.TabIndex = 7
    '
    'txtResults
    '
    Me.txtResults.Location = New System.Drawing.Point(28, 222)
    Me.txtResults.Name = "txtResults"
    Me.txtResults.ReadOnly = True
    Me.txtResults.Size = New System.Drawing.Size(220, 20)
    Me.txtResults.TabIndex = 13
    '
    'lblSecond
    '
    Me.lblSecond.AutoSize = True
    Me.lblSecond.Location = New System.Drawing.Point(216, 61)
    Me.lblSecond.Name = "lblSecond"
    Me.lblSecond.Size = New System.Drawing.Size(44, 26)
    Me.lblSecond.TabIndex = 11
    Me.lblSecond.Text = "Second" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number"
    '
    'lblFirst
    '
    Me.lblFirst.AutoSize = True
    Me.lblFirst.Location = New System.Drawing.Point(25, 61)
    Me.lblFirst.Name = "lblFirst"
    Me.lblFirst.Size = New System.Drawing.Size(44, 26)
    Me.lblFirst.TabIndex = 9
    Me.lblFirst.Text = "First" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number"
    '
    'btnMultiply
    '
    Me.btnMultiply.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
    Me.btnMultiply.Location = New System.Drawing.Point(110, 134)
    Me.btnMultiply.Name = "btnMultiply"
    Me.btnMultiply.Size = New System.Drawing.Size(71, 51)
    Me.btnMultiply.TabIndex = 12
    Me.btnMultiply.Text = "x"
    Me.btnMultiply.UseVisualStyleBackColor = False
    '
    'btnMinus
    '
    Me.btnMinus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
    Me.btnMinus.Location = New System.Drawing.Point(110, 77)
    Me.btnMinus.Name = "btnMinus"
    Me.btnMinus.Size = New System.Drawing.Size(71, 51)
    Me.btnMinus.TabIndex = 10
    Me.btnMinus.Text = "-"
    Me.btnMinus.UseVisualStyleBackColor = False
    '
    'btnPlus
    '
    Me.btnPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
    Me.btnPlus.Location = New System.Drawing.Point(110, 18)
    Me.btnPlus.Name = "btnPlus"
    Me.btnPlus.Size = New System.Drawing.Size(71, 51)
    Me.btnPlus.TabIndex = 8
    Me.btnPlus.Text = "+"
    Me.btnPlus.UseVisualStyleBackColor = False
    '
    'frmCalculator
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 261)
    Me.Controls.Add(Me.txtFirst)
    Me.Controls.Add(Me.txtSecond)
    Me.Controls.Add(Me.txtResults)
    Me.Controls.Add(Me.lblSecond)
    Me.Controls.Add(Me.lblFirst)
    Me.Controls.Add(Me.btnMultiply)
    Me.Controls.Add(Me.btnMinus)
    Me.Controls.Add(Me.btnPlus)
    Me.Name = "frmCalculator"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Calculator"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents txtFirst As TextBox
  Friend WithEvents txtSecond As TextBox
  Friend WithEvents txtResults As TextBox
  Friend WithEvents lblSecond As Label
  Friend WithEvents lblFirst As Label
  Friend WithEvents btnMultiply As Button
  Friend WithEvents btnMinus As Button
  Friend WithEvents btnPlus As Button
End Class
