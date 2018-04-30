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
    Me.Button1 = New System.Windows.Forms.Button()
    Me.SuspendLayout
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(12, 12)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(248, 105)
    Me.Button1.TabIndex = 1
    Me.Button1.Text = "Create File"
    Me.Button1.UseVisualStyleBackColor = true
    '
    'frmBaseball
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 129)
    Me.Controls.Add(Me.Button1)
    Me.Name = "frmBaseball"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Baseball"
    Me.ResumeLayout(false)

End Sub

  Friend WithEvents Button1 As Button
End Class
