<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuadraticEquation
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.txtA = New System.Windows.Forms.TextBox()
    Me.txtB = New System.Windows.Forms.TextBox()
    Me.txtC = New System.Windows.Forms.TextBox()
    Me.btnFindSolution = New System.Windows.Forms.Button()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtSolutions = New System.Windows.Forms.TextBox()
    Me.SuspendLayout
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(12, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(13, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "a"
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(119, 15)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(13, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "b"
    '
    'Label3
    '
    Me.Label3.AutoSize = true
    Me.Label3.Location = New System.Drawing.Point(229, 15)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(13, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "c"
    '
    'txtA
    '
    Me.txtA.Location = New System.Drawing.Point(28, 12)
    Me.txtA.Name = "txtA"
    Me.txtA.Size = New System.Drawing.Size(57, 20)
    Me.txtA.TabIndex = 0
    '
    'txtB
    '
    Me.txtB.Location = New System.Drawing.Point(138, 12)
    Me.txtB.Name = "txtB"
    Me.txtB.Size = New System.Drawing.Size(57, 20)
    Me.txtB.TabIndex = 1
    '
    'txtC
    '
    Me.txtC.Location = New System.Drawing.Point(248, 12)
    Me.txtC.Name = "txtC"
    Me.txtC.Size = New System.Drawing.Size(57, 20)
    Me.txtC.TabIndex = 2
    '
    'btnFindSolution
    '
    Me.btnFindSolution.BackColor = System.Drawing.SystemColors.AppWorkspace
    Me.btnFindSolution.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnFindSolution.Location = New System.Drawing.Point(15, 53)
    Me.btnFindSolution.Name = "btnFindSolution"
    Me.btnFindSolution.Size = New System.Drawing.Size(290, 62)
    Me.btnFindSolution.TabIndex = 3
    Me.btnFindSolution.Text = "Find Solution"
    Me.btnFindSolution.UseVisualStyleBackColor = false
    '
    'Label4
    '
    Me.Label4.AutoSize = true
    Me.Label4.Location = New System.Drawing.Point(24, 144)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(50, 13)
    Me.Label4.TabIndex = 4
    Me.Label4.Text = "Solutions"
    '
    'txtSolutions
    '
    Me.txtSolutions.Location = New System.Drawing.Point(80, 141)
    Me.txtSolutions.Name = "txtSolutions"
    Me.txtSolutions.ReadOnly = true
    Me.txtSolutions.Size = New System.Drawing.Size(225, 20)
    Me.txtSolutions.TabIndex = 5
    Me.txtSolutions.TabStop = false
    '
    'frmQuadraticEquation
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(323, 173)
    Me.Controls.Add(Me.txtSolutions)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.btnFindSolution)
    Me.Controls.Add(Me.txtC)
    Me.Controls.Add(Me.txtB)
    Me.Controls.Add(Me.txtA)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmQuadraticEquation"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Quadratic Equation"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents txtA As TextBox
  Friend WithEvents txtB As TextBox
  Friend WithEvents txtC As TextBox
  Friend WithEvents btnFindSolution As Button
  Friend WithEvents Label4 As Label
  Friend WithEvents txtSolutions As TextBox
End Class
