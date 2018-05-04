<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeatingChart
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
    Me.lstDisplay = New System.Windows.Forms.ListBox()
    Me.txtF = New System.Windows.Forms.TextBox()
    Me.txtE = New System.Windows.Forms.TextBox()
    Me.txtD = New System.Windows.Forms.TextBox()
    Me.txtC = New System.Windows.Forms.TextBox()
    Me.txtA = New System.Windows.Forms.TextBox()
    Me.txtB = New System.Windows.Forms.TextBox()
    Me.lblF = New System.Windows.Forms.Label()
    Me.lblE = New System.Windows.Forms.Label()
    Me.lblD = New System.Windows.Forms.Label()
    Me.lblC = New System.Windows.Forms.Label()
    Me.lblB = New System.Windows.Forms.Label()
    Me.lblA = New System.Windows.Forms.Label()
    Me.btnDisplay = New System.Windows.Forms.Button()
    Me.lblRow = New System.Windows.Forms.Label()
    Me.txtRow = New System.Windows.Forms.TextBox()
    Me.lstRows = New System.Windows.Forms.ListBox()
    Me.SuspendLayout
    '
    'lstDisplay
    '
    Me.lstDisplay.Font = New System.Drawing.Font("Courier New", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lstDisplay.FormattingEnabled = true
    Me.lstDisplay.ItemHeight = 15
    Me.lstDisplay.Location = New System.Drawing.Point(42, 172)
    Me.lstDisplay.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.lstDisplay.Name = "lstDisplay"
    Me.lstDisplay.Size = New System.Drawing.Size(185, 64)
    Me.lstDisplay.TabIndex = 34
    '
    'txtF
    '
    Me.txtF.Font = New System.Drawing.Font("Courier New", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.txtF.Location = New System.Drawing.Point(372, 414)
    Me.txtF.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtF.Name = "txtF"
    Me.txtF.ReadOnly = true
    Me.txtF.Size = New System.Drawing.Size(39, 35)
    Me.txtF.TabIndex = 33
    Me.txtF.TabStop = false
    Me.txtF.Text = "."
    Me.txtF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtE
    '
    Me.txtE.Font = New System.Drawing.Font("Courier New", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.txtE.Location = New System.Drawing.Point(318, 414)
    Me.txtE.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtE.Name = "txtE"
    Me.txtE.ReadOnly = true
    Me.txtE.Size = New System.Drawing.Size(40, 35)
    Me.txtE.TabIndex = 32
    Me.txtE.TabStop = false
    Me.txtE.Text = "."
    Me.txtE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtD
    '
    Me.txtD.Font = New System.Drawing.Font("Courier New", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.txtD.Location = New System.Drawing.Point(264, 414)
    Me.txtD.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtD.Name = "txtD"
    Me.txtD.ReadOnly = true
    Me.txtD.Size = New System.Drawing.Size(40, 35)
    Me.txtD.TabIndex = 31
    Me.txtD.TabStop = false
    Me.txtD.Text = "."
    Me.txtD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtC
    '
    Me.txtC.Font = New System.Drawing.Font("Courier New", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.txtC.Location = New System.Drawing.Point(190, 414)
    Me.txtC.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtC.Name = "txtC"
    Me.txtC.ReadOnly = true
    Me.txtC.Size = New System.Drawing.Size(39, 35)
    Me.txtC.TabIndex = 30
    Me.txtC.TabStop = false
    Me.txtC.Text = "."
    Me.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtA
    '
    Me.txtA.Font = New System.Drawing.Font("Courier New", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.txtA.Location = New System.Drawing.Point(82, 414)
    Me.txtA.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtA.Name = "txtA"
    Me.txtA.ReadOnly = true
    Me.txtA.Size = New System.Drawing.Size(40, 35)
    Me.txtA.TabIndex = 29
    Me.txtA.TabStop = false
    Me.txtA.Text = "."
    Me.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtB
    '
    Me.txtB.Font = New System.Drawing.Font("Courier New", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.txtB.Location = New System.Drawing.Point(136, 414)
    Me.txtB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtB.Name = "txtB"
    Me.txtB.ReadOnly = true
    Me.txtB.Size = New System.Drawing.Size(40, 35)
    Me.txtB.TabIndex = 28
    Me.txtB.TabStop = false
    Me.txtB.Text = "."
    Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblF
    '
    Me.lblF.AutoSize = true
    Me.lblF.Font = New System.Drawing.Font("Courier New", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblF.Location = New System.Drawing.Point(381, 387)
    Me.lblF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblF.Name = "lblF"
    Me.lblF.Size = New System.Drawing.Size(26, 27)
    Me.lblF.TabIndex = 27
    Me.lblF.Text = "F"
    '
    'lblE
    '
    Me.lblE.AutoSize = true
    Me.lblE.Font = New System.Drawing.Font("Courier New", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblE.Location = New System.Drawing.Point(327, 387)
    Me.lblE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblE.Name = "lblE"
    Me.lblE.Size = New System.Drawing.Size(26, 27)
    Me.lblE.TabIndex = 26
    Me.lblE.Text = "E"
    '
    'lblD
    '
    Me.lblD.AutoSize = true
    Me.lblD.Font = New System.Drawing.Font("Courier New", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblD.Location = New System.Drawing.Point(273, 387)
    Me.lblD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblD.Name = "lblD"
    Me.lblD.Size = New System.Drawing.Size(26, 27)
    Me.lblD.TabIndex = 25
    Me.lblD.Text = "D"
    '
    'lblC
    '
    Me.lblC.AutoSize = true
    Me.lblC.Font = New System.Drawing.Font("Courier New", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblC.Location = New System.Drawing.Point(199, 387)
    Me.lblC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblC.Name = "lblC"
    Me.lblC.Size = New System.Drawing.Size(26, 27)
    Me.lblC.TabIndex = 24
    Me.lblC.Text = "C"
    '
    'lblB
    '
    Me.lblB.AutoSize = true
    Me.lblB.Font = New System.Drawing.Font("Courier New", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblB.Location = New System.Drawing.Point(145, 387)
    Me.lblB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblB.Name = "lblB"
    Me.lblB.Size = New System.Drawing.Size(26, 27)
    Me.lblB.TabIndex = 23
    Me.lblB.Text = "B"
    '
    'lblA
    '
    Me.lblA.AutoSize = true
    Me.lblA.Font = New System.Drawing.Font("Courier New", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblA.Location = New System.Drawing.Point(91, 387)
    Me.lblA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblA.Name = "lblA"
    Me.lblA.Size = New System.Drawing.Size(26, 27)
    Me.lblA.TabIndex = 22
    Me.lblA.Text = "A"
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(42, 123)
    Me.btnDisplay.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(185, 29)
    Me.btnDisplay.TabIndex = 21
    Me.btnDisplay.Text = "Display Statistics"
    '
    'lblRow
    '
    Me.lblRow.Font = New System.Drawing.Font("Courier New", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblRow.Location = New System.Drawing.Point(17, 391)
    Me.lblRow.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblRow.Name = "lblRow"
    Me.lblRow.Size = New System.Drawing.Size(53, 19)
    Me.lblRow.TabIndex = 20
    Me.lblRow.Text = "Row #"
    '
    'txtRow
    '
    Me.txtRow.Font = New System.Drawing.Font("Courier New", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.txtRow.Location = New System.Drawing.Point(23, 414)
    Me.txtRow.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtRow.Name = "txtRow"
    Me.txtRow.ReadOnly = true
    Me.txtRow.Size = New System.Drawing.Size(47, 35)
    Me.txtRow.TabIndex = 19
    Me.txtRow.TabStop = false
    '
    'lstRows
    '
    Me.lstRows.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lstRows.FormattingEnabled = true
    Me.lstRows.ItemHeight = 21
    Me.lstRows.Location = New System.Drawing.Point(273, 27)
    Me.lstRows.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.lstRows.Name = "lstRows"
    Me.lstRows.Size = New System.Drawing.Size(134, 340)
    Me.lstRows.TabIndex = 18
    '
    'frmSeatingChart
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(434, 476)
    Me.Controls.Add(Me.lstDisplay)
    Me.Controls.Add(Me.txtF)
    Me.Controls.Add(Me.txtE)
    Me.Controls.Add(Me.txtD)
    Me.Controls.Add(Me.txtC)
    Me.Controls.Add(Me.txtA)
    Me.Controls.Add(Me.txtB)
    Me.Controls.Add(Me.lblF)
    Me.Controls.Add(Me.lblE)
    Me.Controls.Add(Me.lblD)
    Me.Controls.Add(Me.lblC)
    Me.Controls.Add(Me.lblB)
    Me.Controls.Add(Me.lblA)
    Me.Controls.Add(Me.btnDisplay)
    Me.Controls.Add(Me.lblRow)
    Me.Controls.Add(Me.txtRow)
    Me.Controls.Add(Me.lstRows)
    Me.Name = "frmSeatingChart"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Seating chart"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents lstDisplay As ListBox
  Friend WithEvents txtF As TextBox
  Friend WithEvents txtE As TextBox
  Friend WithEvents txtD As TextBox
  Friend WithEvents txtC As TextBox
  Friend WithEvents txtA As TextBox
  Friend WithEvents txtB As TextBox
  Friend WithEvents lblF As Label
  Friend WithEvents lblE As Label
  Friend WithEvents lblD As Label
  Friend WithEvents lblC As Label
  Friend WithEvents lblB As Label
  Friend WithEvents lblA As Label
  Friend WithEvents btnDisplay As Button
  Friend WithEvents lblRow As Label
  Friend WithEvents txtRow As TextBox
  Friend WithEvents lstRows As ListBox
End Class
