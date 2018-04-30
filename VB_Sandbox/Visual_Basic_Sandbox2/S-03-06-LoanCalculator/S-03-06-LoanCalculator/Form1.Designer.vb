<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanCalculator
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
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.radMonthlyPayment = New System.Windows.Forms.RadioButton()
    Me.radDurationOfLoan = New System.Windows.Forms.RadioButton()
    Me.radInterestRate = New System.Windows.Forms.RadioButton()
    Me.radAmountOfLoan = New System.Windows.Forms.RadioButton()
    Me.txtAmount = New System.Windows.Forms.TextBox()
    Me.txtInterestRate = New System.Windows.Forms.TextBox()
    Me.txtDuration = New System.Windows.Forms.TextBox()
    Me.txtMonthlyPayment = New System.Windows.Forms.TextBox()
    Me.btnCalculate = New System.Windows.Forms.Button()
    Me.btnClear = New System.Windows.Forms.Button()
    Me.GroupBox1.SuspendLayout
    Me.SuspendLayout
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.radMonthlyPayment)
    Me.GroupBox1.Controls.Add(Me.radDurationOfLoan)
    Me.GroupBox1.Controls.Add(Me.radInterestRate)
    Me.GroupBox1.Controls.Add(Me.radAmountOfLoan)
    Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(148, 166)
    Me.GroupBox1.TabIndex = 0
    Me.GroupBox1.TabStop = false
    Me.GroupBox1.Text = "Check Value To Calculate"
    '
    'radMonthlyPayment
    '
    Me.radMonthlyPayment.AutoSize = true
    Me.radMonthlyPayment.Location = New System.Drawing.Point(10, 131)
    Me.radMonthlyPayment.Name = "radMonthlyPayment"
    Me.radMonthlyPayment.Size = New System.Drawing.Size(106, 17)
    Me.radMonthlyPayment.TabIndex = 3
    Me.radMonthlyPayment.TabStop = true
    Me.radMonthlyPayment.Text = "Monthly Payment"
    Me.radMonthlyPayment.UseVisualStyleBackColor = true
    '
    'radDurationOfLoan
    '
    Me.radDurationOfLoan.AutoSize = true
    Me.radDurationOfLoan.Location = New System.Drawing.Point(10, 97)
    Me.radDurationOfLoan.Name = "radDurationOfLoan"
    Me.radDurationOfLoan.Size = New System.Drawing.Size(106, 17)
    Me.radDurationOfLoan.TabIndex = 2
    Me.radDurationOfLoan.TabStop = true
    Me.radDurationOfLoan.Text = "Duration Of Loan"
    Me.radDurationOfLoan.UseVisualStyleBackColor = true
    '
    'radInterestRate
    '
    Me.radInterestRate.AutoSize = true
    Me.radInterestRate.Location = New System.Drawing.Point(10, 63)
    Me.radInterestRate.Name = "radInterestRate"
    Me.radInterestRate.Size = New System.Drawing.Size(86, 17)
    Me.radInterestRate.TabIndex = 1
    Me.radInterestRate.TabStop = true
    Me.radInterestRate.Text = "Interest Rate"
    Me.radInterestRate.UseVisualStyleBackColor = true
    '
    'radAmountOfLoan
    '
    Me.radAmountOfLoan.AutoSize = true
    Me.radAmountOfLoan.Location = New System.Drawing.Point(10, 29)
    Me.radAmountOfLoan.Name = "radAmountOfLoan"
    Me.radAmountOfLoan.Size = New System.Drawing.Size(102, 17)
    Me.radAmountOfLoan.TabIndex = 0
    Me.radAmountOfLoan.TabStop = true
    Me.radAmountOfLoan.Text = "Amount Of Loan"
    Me.radAmountOfLoan.UseVisualStyleBackColor = true
    '
    'txtAmount
    '
    Me.txtAmount.Location = New System.Drawing.Point(181, 40)
    Me.txtAmount.Name = "txtAmount"
    Me.txtAmount.Size = New System.Drawing.Size(100, 20)
    Me.txtAmount.TabIndex = 1
    '
    'txtInterestRate
    '
    Me.txtInterestRate.Location = New System.Drawing.Point(181, 74)
    Me.txtInterestRate.Name = "txtInterestRate"
    Me.txtInterestRate.Size = New System.Drawing.Size(100, 20)
    Me.txtInterestRate.TabIndex = 2
    '
    'txtDuration
    '
    Me.txtDuration.Location = New System.Drawing.Point(181, 108)
    Me.txtDuration.Name = "txtDuration"
    Me.txtDuration.Size = New System.Drawing.Size(100, 20)
    Me.txtDuration.TabIndex = 3
    '
    'txtMonthlyPayment
    '
    Me.txtMonthlyPayment.Location = New System.Drawing.Point(181, 142)
    Me.txtMonthlyPayment.Name = "txtMonthlyPayment"
    Me.txtMonthlyPayment.Size = New System.Drawing.Size(100, 20)
    Me.txtMonthlyPayment.TabIndex = 4
    '
    'btnCalculate
    '
    Me.btnCalculate.Location = New System.Drawing.Point(97, 202)
    Me.btnCalculate.Name = "btnCalculate"
    Me.btnCalculate.Size = New System.Drawing.Size(115, 23)
    Me.btnCalculate.TabIndex = 5
    Me.btnCalculate.Text = "Calculate Value"
    Me.btnCalculate.UseVisualStyleBackColor = true
    '
    'btnClear
    '
    Me.btnClear.Location = New System.Drawing.Point(97, 243)
    Me.btnClear.Name = "btnClear"
    Me.btnClear.Size = New System.Drawing.Size(115, 23)
    Me.btnClear.TabIndex = 6
    Me.btnClear.Text = "Clear All Values"
    Me.btnClear.UseVisualStyleBackColor = true
    '
    'frmLoanCalculator
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(308, 280)
    Me.Controls.Add(Me.btnClear)
    Me.Controls.Add(Me.btnCalculate)
    Me.Controls.Add(Me.txtMonthlyPayment)
    Me.Controls.Add(Me.txtDuration)
    Me.Controls.Add(Me.txtInterestRate)
    Me.Controls.Add(Me.txtAmount)
    Me.Controls.Add(Me.GroupBox1)
    Me.Name = "frmLoanCalculator"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Loan Calculator"
    Me.GroupBox1.ResumeLayout(false)
    Me.GroupBox1.PerformLayout
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents GroupBox1 As GroupBox
  Friend WithEvents radMonthlyPayment As RadioButton
  Friend WithEvents radDurationOfLoan As RadioButton
  Friend WithEvents radInterestRate As RadioButton
  Friend WithEvents radAmountOfLoan As RadioButton
  Friend WithEvents txtAmount As TextBox
  Friend WithEvents txtInterestRate As TextBox
  Friend WithEvents txtDuration As TextBox
  Friend WithEvents txtMonthlyPayment As TextBox
  Friend WithEvents btnCalculate As Button
  Friend WithEvents btnClear As Button
End Class
