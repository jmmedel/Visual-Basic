<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameOfLife
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
    Me.btnNew = New System.Windows.Forms.Button()
    Me.lblIndividuals = New System.Windows.Forms.Label()
    Me.lstGeneration = New System.Windows.Forms.ListBox()
    Me.txtIndividuals = New System.Windows.Forms.TextBox()
    Me.btnGeneration = New System.Windows.Forms.Button()
    Me.SuspendLayout
    '
    'btnNew
    '
    Me.btnNew.Location = New System.Drawing.Point(216, 24)
    Me.btnNew.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.btnNew.Name = "btnNew"
    Me.btnNew.Size = New System.Drawing.Size(96, 29)
    Me.btnNew.TabIndex = 9
    Me.btnNew.Text = "New Game"
    '
    'lblIndividuals
    '
    Me.lblIndividuals.AutoSize = true
    Me.lblIndividuals.Location = New System.Drawing.Point(219, 102)
    Me.lblIndividuals.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblIndividuals.Name = "lblIndividuals"
    Me.lblIndividuals.Size = New System.Drawing.Size(60, 13)
    Me.lblIndividuals.TabIndex = 8
    Me.lblIndividuals.Text = "Individuals:"
    Me.lblIndividuals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lstGeneration
    '
    Me.lstGeneration.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lstGeneration.FormattingEnabled = true
    Me.lstGeneration.ItemHeight = 16
    Me.lstGeneration.Location = New System.Drawing.Point(13, 24)
    Me.lstGeneration.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.lstGeneration.Name = "lstGeneration"
    Me.lstGeneration.Size = New System.Drawing.Size(177, 180)
    Me.lstGeneration.TabIndex = 7
    '
    'txtIndividuals
    '
    Me.txtIndividuals.Location = New System.Drawing.Point(283, 99)
    Me.txtIndividuals.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtIndividuals.Name = "txtIndividuals"
    Me.txtIndividuals.ReadOnly = true
    Me.txtIndividuals.Size = New System.Drawing.Size(38, 20)
    Me.txtIndividuals.TabIndex = 6
    '
    'btnGeneration
    '
    Me.btnGeneration.Location = New System.Drawing.Point(205, 61)
    Me.btnGeneration.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.btnGeneration.Name = "btnGeneration"
    Me.btnGeneration.Size = New System.Drawing.Size(115, 29)
    Me.btnGeneration.TabIndex = 5
    Me.btnGeneration.Text = "Generation #1"
    '
    'frmGameOfLife
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(361, 233)
    Me.Controls.Add(Me.btnNew)
    Me.Controls.Add(Me.lblIndividuals)
    Me.Controls.Add(Me.lstGeneration)
    Me.Controls.Add(Me.txtIndividuals)
    Me.Controls.Add(Me.btnGeneration)
    Me.Name = "frmGameOfLife"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Game Of Life"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents btnNew As Button
  Friend WithEvents lblIndividuals As Label
  Friend WithEvents lstGeneration As ListBox
  Friend WithEvents txtIndividuals As TextBox
  Friend WithEvents btnGeneration As Button
End Class
