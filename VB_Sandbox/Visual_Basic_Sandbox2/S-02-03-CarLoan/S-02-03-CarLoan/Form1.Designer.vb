<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCarLoan
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
    Me.txtInterestPaid = New System.Windows.Forms.TextBox()
    Me.txtMonthlyPayments = New System.Windows.Forms.TextBox()
    Me.txtDuration = New System.Windows.Forms.TextBox()
    Me.txtInterestRate = New System.Windows.Forms.TextBox()
    Me.txtLoanAmount = New System.Windows.Forms.TextBox()
    Me.btnAnalyze = New System.Windows.Forms.Button()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout
    '
    'txtInterestPaid
    '
    Me.txtInterestPaid.Enabled = false
    Me.txtInterestPaid.Location = New System.Drawing.Point(129, 228)
    Me.txtInterestPaid.Name = "txtInterestPaid"
    Me.txtInterestPaid.ReadOnly = true
    Me.txtInterestPaid.Size = New System.Drawing.Size(100, 20)
    Me.txtInterestPaid.TabIndex = 21
    '
    'txtMonthlyPayments
    '
    Me.txtMonthlyPayments.Enabled = false
    Me.txtMonthlyPayments.Location = New System.Drawing.Point(129, 190)
    Me.txtMonthlyPayments.Name = "txtMonthlyPayments"
    Me.txtMonthlyPayments.ReadOnly = true
    Me.txtMonthlyPayments.Size = New System.Drawing.Size(100, 20)
    Me.txtMonthlyPayments.TabIndex = 20
    '
    'txtDuration
    '
    Me.txtDuration.Location = New System.Drawing.Point(129, 82)
    Me.txtDuration.Name = "txtDuration"
    Me.txtDuration.Size = New System.Drawing.Size(100, 20)
    Me.txtDuration.TabIndex = 16
    '
    'txtInterestRate
    '
    Me.txtInterestRate.Location = New System.Drawing.Point(129, 49)
    Me.txtInterestRate.Name = "txtInterestRate"
    Me.txtInterestRate.Size = New System.Drawing.Size(100, 20)
    Me.txtInterestRate.TabIndex = 14
    '
    'txtLoanAmount
    '
    Me.txtLoanAmount.Location = New System.Drawing.Point(129, 16)
    Me.txtLoanAmount.Name = "txtLoanAmount"
    Me.txtLoanAmount.Size = New System.Drawing.Size(100, 20)
    Me.txtLoanAmount.TabIndex = 12
    '
    'btnAnalyze
    '
    Me.btnAnalyze.Location = New System.Drawing.Point(90, 119)
    Me.btnAnalyze.Name = "btnAnalyze"
    Me.btnAnalyze.Size = New System.Drawing.Size(171, 48)
    Me.btnAnalyze.TabIndex = 18
    Me.btnAnalyze.Text = "Analyze"
    Me.btnAnalyze.UseVisualStyleBackColor = true
    '
    'Label5
    '
    Me.Label5.AutoSize = true
    Me.Label5.Location = New System.Drawing.Point(24, 231)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(91, 13)
    Me.Label5.TabIndex = 19
    Me.Label5.Text = "Total interest paid"
    '
    'Label4
    '
    Me.Label4.AutoSize = true
    Me.Label4.Location = New System.Drawing.Point(24, 193)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(93, 13)
    Me.Label4.TabIndex = 17
    Me.Label4.Text = "Monthly Payments"
    '
    'Label3
    '
    Me.Label3.AutoSize = true
    Me.Label3.Location = New System.Drawing.Point(25, 85)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(92, 13)
    Me.Label3.TabIndex = 15
    Me.Label3.Text = "Duation in months"
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(49, 52)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(68, 13)
    Me.Label2.TabIndex = 13
    Me.Label2.Text = "Interest Rate"
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(35, 19)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(82, 13)
    Me.Label1.TabIndex = 11
    Me.Label1.Text = "Amount of Loan"
    '
    'FrmCarLoan
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(297, 277)
    Me.Controls.Add(Me.txtInterestPaid)
    Me.Controls.Add(Me.txtMonthlyPayments)
    Me.Controls.Add(Me.txtDuration)
    Me.Controls.Add(Me.txtInterestRate)
    Me.Controls.Add(Me.txtLoanAmount)
    Me.Controls.Add(Me.btnAnalyze)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "FrmCarLoan"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Car Loan"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents txtInterestPaid As TextBox
  Friend WithEvents txtMonthlyPayments As TextBox
  Friend WithEvents txtDuration As TextBox
  Friend WithEvents txtInterestRate As TextBox
  Friend WithEvents txtLoanAmount As TextBox
  Friend WithEvents btnAnalyze As Button
  Friend WithEvents Label5 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
End Class
