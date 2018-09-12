<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileOfNames
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
    Me.btnInsert = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtName = New System.Windows.Forms.TextBox()
    Me.SuspendLayout
    '
    'btnInsert
    '
    Me.btnInsert.Location = New System.Drawing.Point(24, 64)
    Me.btnInsert.Name = "btnInsert"
    Me.btnInsert.Size = New System.Drawing.Size(246, 52)
    Me.btnInsert.TabIndex = 6
    Me.btnInsert.Text = "Insert Name"
    Me.btnInsert.UseVisualStyleBackColor = true
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(12, 28)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(79, 13)
    Me.Label1.TabIndex = 5
    Me.Label1.Text = "Name to Insert:"
    '
    'txtName
    '
    Me.txtName.Location = New System.Drawing.Point(97, 25)
    Me.txtName.Name = "txtName"
    Me.txtName.Size = New System.Drawing.Size(173, 20)
    Me.txtName.TabIndex = 4
    '
    'frmFileOfNames
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(284, 146)
    Me.Controls.Add(Me.btnInsert)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtName)
    Me.Name = "frmFileOfNames"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "File of Names"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub
  Friend WithEvents btnInsert As Button
  Friend WithEvents Label1 As Label
  Friend WithEvents txtName As TextBox
End Class
