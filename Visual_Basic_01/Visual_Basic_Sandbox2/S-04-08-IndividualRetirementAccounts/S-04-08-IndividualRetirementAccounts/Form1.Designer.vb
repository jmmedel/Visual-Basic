<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIRA
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
    Me.txtLarryTotalIRA = New System.Windows.Forms.TextBox()
    Me.txtEarlTotalIRA = New System.Windows.Forms.TextBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.txtLarryTotalDeposits = New System.Windows.Forms.TextBox()
    Me.txtEarlTotalDeposits = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.btnCalculate = New System.Windows.Forms.Button()
    Me.SuspendLayout
    '
    'txtLarryTotalIRA
    '
    Me.txtLarryTotalIRA.Location = New System.Drawing.Point(236, 148)
    Me.txtLarryTotalIRA.Name = "txtLarryTotalIRA"
    Me.txtLarryTotalIRA.ReadOnly = true
    Me.txtLarryTotalIRA.Size = New System.Drawing.Size(100, 20)
    Me.txtLarryTotalIRA.TabIndex = 21
    '
    'txtEarlTotalIRA
    '
    Me.txtEarlTotalIRA.Location = New System.Drawing.Point(44, 151)
    Me.txtEarlTotalIRA.Name = "txtEarlTotalIRA"
    Me.txtEarlTotalIRA.ReadOnly = true
    Me.txtEarlTotalIRA.Size = New System.Drawing.Size(100, 20)
    Me.txtEarlTotalIRA.TabIndex = 20
    '
    'Label5
    '
    Me.Label5.AutoSize = true
    Me.Label5.Location = New System.Drawing.Point(188, 148)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(30, 13)
    Me.Label5.TabIndex = 19
    Me.Label5.Text = "Larry"
    '
    'Label6
    '
    Me.Label6.AutoSize = true
    Me.Label6.Location = New System.Drawing.Point(13, 151)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(25, 13)
    Me.Label6.TabIndex = 18
    Me.Label6.Text = "Earl"
    '
    'txtLarryTotalDeposits
    '
    Me.txtLarryTotalDeposits.Location = New System.Drawing.Point(236, 54)
    Me.txtLarryTotalDeposits.Name = "txtLarryTotalDeposits"
    Me.txtLarryTotalDeposits.ReadOnly = true
    Me.txtLarryTotalDeposits.Size = New System.Drawing.Size(100, 20)
    Me.txtLarryTotalDeposits.TabIndex = 17
    '
    'txtEarlTotalDeposits
    '
    Me.txtEarlTotalDeposits.Location = New System.Drawing.Point(42, 54)
    Me.txtEarlTotalDeposits.Name = "txtEarlTotalDeposits"
    Me.txtEarlTotalDeposits.ReadOnly = true
    Me.txtEarlTotalDeposits.Size = New System.Drawing.Size(100, 20)
    Me.txtEarlTotalDeposits.TabIndex = 16
    '
    'Label4
    '
    Me.Label4.AutoSize = true
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.Label4.Location = New System.Drawing.Point(114, 112)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(156, 13)
    Me.Label4.TabIndex = 15
    Me.Label4.Text = "Amounts in IRA upon retirement"
    '
    'Label3
    '
    Me.Label3.AutoSize = true
    Me.Label3.Location = New System.Drawing.Point(188, 54)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(30, 13)
    Me.Label3.TabIndex = 14
    Me.Label3.Text = "Larry"
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(11, 54)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(25, 13)
    Me.Label2.TabIndex = 13
    Me.Label2.Text = "Earl"
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.Label1.Location = New System.Drawing.Point(138, 25)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(99, 13)
    Me.Label1.TabIndex = 12
    Me.Label1.Text = "Amounts Deposited"
    '
    'btnCalculate
    '
    Me.btnCalculate.Location = New System.Drawing.Point(117, 196)
    Me.btnCalculate.Name = "btnCalculate"
    Me.btnCalculate.Size = New System.Drawing.Size(133, 45)
    Me.btnCalculate.TabIndex = 11
    Me.btnCalculate.Text = "Calculate Amounts"
    Me.btnCalculate.UseVisualStyleBackColor = true
    '
    'frmIRA
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(369, 262)
    Me.Controls.Add(Me.txtLarryTotalIRA)
    Me.Controls.Add(Me.txtEarlTotalIRA)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.txtLarryTotalDeposits)
    Me.Controls.Add(Me.txtEarlTotalDeposits)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btnCalculate)
    Me.Name = "frmIRA"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "IRA"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents txtLarryTotalIRA As TextBox
  Friend WithEvents txtEarlTotalIRA As TextBox
  Friend WithEvents Label5 As Label
  Friend WithEvents Label6 As Label
  Friend WithEvents txtLarryTotalDeposits As TextBox
  Friend WithEvents txtEarlTotalDeposits As TextBox
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents btnCalculate As Button
End Class
