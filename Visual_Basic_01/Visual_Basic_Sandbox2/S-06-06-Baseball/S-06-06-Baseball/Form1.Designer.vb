<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBaseball
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
    Me.Label2 = New System.Windows.Forms.Label()
    Me.dgvOutput = New System.Windows.Forms.DataGridView()
    Me.lstTeams = New System.Windows.Forms.ListBox()
    Me.Label1 = New System.Windows.Forms.Label()
    CType(Me.dgvOutput,System.ComponentModel.ISupportInitialize).BeginInit
    Me.SuspendLayout
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(219, 9)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(236, 13)
    Me.Label2.TabIndex = 7
    Me.Label2.Text = "Show Players with Greater Avg than Team's Avg"
    '
    'dgvOutput
    '
    Me.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvOutput.Location = New System.Drawing.Point(187, 38)
    Me.dgvOutput.Name = "dgvOutput"
    Me.dgvOutput.RowHeadersVisible = false
    Me.dgvOutput.Size = New System.Drawing.Size(306, 121)
    Me.dgvOutput.TabIndex = 6
    '
    'lstTeams
    '
    Me.lstTeams.FormattingEnabled = true
    Me.lstTeams.Location = New System.Drawing.Point(13, 38)
    Me.lstTeams.Name = "lstTeams"
    Me.lstTeams.Size = New System.Drawing.Size(150, 121)
    Me.lstTeams.TabIndex = 5
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(34, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(93, 13)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Click on the Team"
    '
    'frmBaseball
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(509, 176)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.dgvOutput)
    Me.Controls.Add(Me.lstTeams)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmBaseball"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Baseball"
    CType(Me.dgvOutput,System.ComponentModel.ISupportInitialize).EndInit
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents Label2 As Label
  Friend WithEvents dgvOutput As DataGridView
  Friend WithEvents lstTeams As ListBox
  Friend WithEvents Label1 As Label
End Class
