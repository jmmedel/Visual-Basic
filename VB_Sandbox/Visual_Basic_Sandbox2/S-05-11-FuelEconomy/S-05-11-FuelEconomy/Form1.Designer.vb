<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuelEconomy
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
    Me.dgvOutput = New System.Windows.Forms.DataGridView()
    Me.btnCompute = New System.Windows.Forms.Button()
    CType(Me.dgvOutput,System.ComponentModel.ISupportInitialize).BeginInit
    Me.SuspendLayout
    '
    'dgvOutput
    '
    Me.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvOutput.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
    Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvOutput.ColumnHeadersVisible = false
    Me.dgvOutput.Location = New System.Drawing.Point(46, 89)
    Me.dgvOutput.Name = "dgvOutput"
    Me.dgvOutput.RowHeadersVisible = false
    Me.dgvOutput.Size = New System.Drawing.Size(169, 135)
    Me.dgvOutput.TabIndex = 3
    '
    'btnCompute
    '
    Me.btnCompute.Location = New System.Drawing.Point(46, 34)
    Me.btnCompute.Name = "btnCompute"
    Me.btnCompute.Size = New System.Drawing.Size(169, 37)
    Me.btnCompute.TabIndex = 2
    Me.btnCompute.Text = "Compute MPG"
    Me.btnCompute.UseVisualStyleBackColor = true
    '
    'frmFuelEconomy
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 261)
    Me.Controls.Add(Me.dgvOutput)
    Me.Controls.Add(Me.btnCompute)
    Me.Name = "frmFuelEconomy"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Fuel Economy"
    CType(Me.dgvOutput,System.ComponentModel.ISupportInitialize).EndInit
    Me.ResumeLayout(false)

End Sub

  Friend WithEvents dgvOutput As DataGridView
  Friend WithEvents btnCompute As Button
End Class
