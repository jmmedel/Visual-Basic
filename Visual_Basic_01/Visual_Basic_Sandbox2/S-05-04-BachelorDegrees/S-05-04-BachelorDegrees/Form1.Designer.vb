<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBachelorDegrees
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
    Me.btnQuit = New System.Windows.Forms.Button()
    Me.dgvOutput = New System.Windows.Forms.DataGridView()
    Me.btnTable3 = New System.Windows.Forms.Button()
    Me.btnTable2 = New System.Windows.Forms.Button()
    Me.btnTable1 = New System.Windows.Forms.Button()
    CType(Me.dgvOutput,System.ComponentModel.ISupportInitialize).BeginInit
    Me.SuspendLayout
    '
    'btnQuit
    '
    Me.btnQuit.Location = New System.Drawing.Point(141, 179)
    Me.btnQuit.Name = "btnQuit"
    Me.btnQuit.Size = New System.Drawing.Size(192, 40)
    Me.btnQuit.TabIndex = 9
    Me.btnQuit.Text = "Quit"
    Me.btnQuit.UseVisualStyleBackColor = true
    '
    'dgvOutput
    '
    Me.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvOutput.Location = New System.Drawing.Point(12, 254)
    Me.dgvOutput.Name = "dgvOutput"
    Me.dgvOutput.RowHeadersVisible = false
    Me.dgvOutput.Size = New System.Drawing.Size(462, 191)
    Me.dgvOutput.TabIndex = 8
    '
    'btnTable3
    '
    Me.btnTable3.Location = New System.Drawing.Point(141, 104)
    Me.btnTable3.Name = "btnTable3"
    Me.btnTable3.Size = New System.Drawing.Size(192, 40)
    Me.btnTable3.TabIndex = 7
    Me.btnTable3.Text = "Bachelor Degrees Conferred in 2010 in Certain Fields"
    Me.btnTable3.UseVisualStyleBackColor = true
    '
    'btnTable2
    '
    Me.btnTable2.Location = New System.Drawing.Point(141, 58)
    Me.btnTable2.Name = "btnTable2"
    Me.btnTable2.Size = New System.Drawing.Size(192, 40)
    Me.btnTable2.TabIndex = 6
    Me.btnTable2.Text = "Percentage Change in Bachelor Degrees Conferred"
    Me.btnTable2.UseVisualStyleBackColor = true
    '
    'btnTable1
    '
    Me.btnTable1.Location = New System.Drawing.Point(141, 10)
    Me.btnTable1.Name = "btnTable1"
    Me.btnTable1.Size = New System.Drawing.Size(192, 42)
    Me.btnTable1.TabIndex = 5
    Me.btnTable1.Text = "Bachelor Degrees Conferred in Certain Fields"
    Me.btnTable1.UseVisualStyleBackColor = true
    '
    'frmBachelorDegrees
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(495, 464)
    Me.Controls.Add(Me.btnQuit)
    Me.Controls.Add(Me.dgvOutput)
    Me.Controls.Add(Me.btnTable3)
    Me.Controls.Add(Me.btnTable2)
    Me.Controls.Add(Me.btnTable1)
    Me.Name = "frmBachelorDegrees"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Bachelor Degrees"
    CType(Me.dgvOutput,System.ComponentModel.ISupportInitialize).EndInit
    Me.ResumeLayout(false)

End Sub

  Friend WithEvents btnQuit As Button
  Friend WithEvents dgvOutput As DataGridView
  Friend WithEvents btnTable3 As Button
  Friend WithEvents btnTable2 As Button
  Friend WithEvents btnTable1 As Button
End Class
