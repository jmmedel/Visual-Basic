<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoccerLeague
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
    Me.btnDisplay = New System.Windows.Forms.Button()
    CType(Me.dgvOutput,System.ComponentModel.ISupportInitialize).BeginInit
    Me.SuspendLayout
    '
    'dgvOutput
    '
    Me.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvOutput.Location = New System.Drawing.Point(12, 73)
    Me.dgvOutput.Name = "dgvOutput"
    Me.dgvOutput.RowHeadersVisible = false
    Me.dgvOutput.Size = New System.Drawing.Size(211, 173)
    Me.dgvOutput.TabIndex = 3
    '
    'btnDisplay
    '
    Me.btnDisplay.Location = New System.Drawing.Point(12, 12)
    Me.btnDisplay.Name = "btnDisplay"
    Me.btnDisplay.Size = New System.Drawing.Size(211, 41)
    Me.btnDisplay.TabIndex = 2
    Me.btnDisplay.Text = "Display Standings"
    Me.btnDisplay.UseVisualStyleBackColor = true
    '
    'frmSoccerLeague
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(245, 274)
    Me.Controls.Add(Me.dgvOutput)
    Me.Controls.Add(Me.btnDisplay)
    Me.Name = "frmSoccerLeague"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Soccer League"
    CType(Me.dgvOutput,System.ComponentModel.ISupportInitialize).EndInit
    Me.ResumeLayout(false)

End Sub

  Friend WithEvents dgvOutput As DataGridView
  Friend WithEvents btnDisplay As Button
End Class
