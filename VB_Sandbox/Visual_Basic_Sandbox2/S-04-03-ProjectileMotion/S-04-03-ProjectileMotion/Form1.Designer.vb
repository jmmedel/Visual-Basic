<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectileMotion
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
    Me.txtInitialVelocity = New System.Windows.Forms.TextBox()
    Me.txtInitialHeight = New System.Windows.Forms.TextBox()
    Me.lblInitialVelocity = New System.Windows.Forms.Label()
    Me.lblInitialHeight = New System.Windows.Forms.Label()
    Me.btnQuit = New System.Windows.Forms.Button()
    Me.btnApproxTime = New System.Windows.Forms.Button()
    Me.btnTable = New System.Windows.Forms.Button()
    Me.lstOutput = New System.Windows.Forms.ListBox()
    Me.btnMaxHeight = New System.Windows.Forms.Button()
    Me.SuspendLayout
    '
    'txtInitialVelocity
    '
    Me.txtInitialVelocity.Location = New System.Drawing.Point(207, 11)
    Me.txtInitialVelocity.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtInitialVelocity.Name = "txtInitialVelocity"
    Me.txtInitialVelocity.Size = New System.Drawing.Size(25, 20)
    Me.txtInitialVelocity.TabIndex = 10
    '
    'txtInitialHeight
    '
    Me.txtInitialHeight.Location = New System.Drawing.Point(82, 13)
    Me.txtInitialHeight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.txtInitialHeight.Name = "txtInitialHeight"
    Me.txtInitialHeight.Size = New System.Drawing.Size(26, 20)
    Me.txtInitialHeight.TabIndex = 9
    '
    'lblInitialVelocity
    '
    Me.lblInitialVelocity.Location = New System.Drawing.Point(123, 5)
    Me.lblInitialVelocity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblInitialVelocity.Name = "lblInitialVelocity"
    Me.lblInitialVelocity.Size = New System.Drawing.Size(75, 32)
    Me.lblInitialVelocity.TabIndex = 16
    Me.lblInitialVelocity.Text = "Initial Velocity: (feet / second)"
    '
    'lblInitialHeight
    '
    Me.lblInitialHeight.Location = New System.Drawing.Point(13, 9)
    Me.lblInitialHeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
    Me.lblInitialHeight.Name = "lblInitialHeight"
    Me.lblInitialHeight.Size = New System.Drawing.Size(67, 28)
    Me.lblInitialHeight.TabIndex = 15
    Me.lblInitialHeight.Text = "Initial Height: (feet)"
    '
    'btnQuit
    '
    Me.btnQuit.Location = New System.Drawing.Point(174, 88)
    Me.btnQuit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.btnQuit.Name = "btnQuit"
    Me.btnQuit.Size = New System.Drawing.Size(58, 34)
    Me.btnQuit.TabIndex = 14
    Me.btnQuit.Text = "Quit"
    '
    'btnApproxTime
    '
    Me.btnApproxTime.Location = New System.Drawing.Point(15, 88)
    Me.btnApproxTime.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.btnApproxTime.Name = "btnApproxTime"
    Me.btnApproxTime.Size = New System.Drawing.Size(151, 34)
    Me.btnApproxTime.TabIndex = 12
    Me.btnApproxTime.Text = "Determine Approximate Time until Ball Hits the Ground"
    '
    'btnTable
    '
    Me.btnTable.Location = New System.Drawing.Point(176, 48)
    Me.btnTable.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.btnTable.Name = "btnTable"
    Me.btnTable.Size = New System.Drawing.Size(57, 34)
    Me.btnTable.TabIndex = 13
    Me.btnTable.Text = "Display Table"
    '
    'lstOutput
    '
    Me.lstOutput.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lstOutput.ItemHeight = 14
    Me.lstOutput.Location = New System.Drawing.Point(16, 134)
    Me.lstOutput.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.lstOutput.Name = "lstOutput"
    Me.lstOutput.Size = New System.Drawing.Size(216, 144)
    Me.lstOutput.TabIndex = 17
    '
    'btnMaxHeight
    '
    Me.btnMaxHeight.Location = New System.Drawing.Point(15, 48)
    Me.btnMaxHeight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
    Me.btnMaxHeight.Name = "btnMaxHeight"
    Me.btnMaxHeight.Size = New System.Drawing.Size(151, 34)
    Me.btnMaxHeight.TabIndex = 11
    Me.btnMaxHeight.Text = "Determine Maximum Height"
    '
    'frmProjectileMotion
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(256, 298)
    Me.Controls.Add(Me.txtInitialVelocity)
    Me.Controls.Add(Me.txtInitialHeight)
    Me.Controls.Add(Me.lblInitialVelocity)
    Me.Controls.Add(Me.lblInitialHeight)
    Me.Controls.Add(Me.btnQuit)
    Me.Controls.Add(Me.btnApproxTime)
    Me.Controls.Add(Me.btnTable)
    Me.Controls.Add(Me.lstOutput)
    Me.Controls.Add(Me.btnMaxHeight)
    Me.Name = "frmProjectileMotion"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Projectile Motion"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents txtInitialVelocity As TextBox
  Friend WithEvents txtInitialHeight As TextBox
  Friend WithEvents lblInitialVelocity As Label
  Friend WithEvents lblInitialHeight As Label
  Friend WithEvents btnQuit As Button
  Friend WithEvents btnApproxTime As Button
  Friend WithEvents btnTable As Button
  Friend WithEvents lstOutput As ListBox
  Friend WithEvents btnMaxHeight As Button
End Class
