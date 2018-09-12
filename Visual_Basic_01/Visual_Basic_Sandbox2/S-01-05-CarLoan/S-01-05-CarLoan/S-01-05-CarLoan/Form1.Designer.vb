<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarLoan
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
    Me.txtPayments = New System.Windows.Forms.MaskedTextBox()
    Me.txtYears = New System.Windows.Forms.MaskedTextBox()
    Me.txtInterest = New System.Windows.Forms.MaskedTextBox()
    Me.lblError = New System.Windows.Forms.Label()
    Me.btnCalculate = New System.Windows.Forms.Button()
    Me.txtAmount = New System.Windows.Forms.TextBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout
    '
    'txtPayments
    '
    Me.txtPayments.Location = New System.Drawing.Point(139, 199)
    Me.txtPayments.Name = "txtPayments"
    Me.txtPayments.ReadOnly = true
    Me.txtPayments.Size = New System.Drawing.Size(100, 20)
    Me.txtPayments.TabIndex = 24
    Me.txtPayments.TabStop = false
    '
    'txtYears
    '
    Me.txtYears.Location = New System.Drawing.Point(139, 98)
    Me.txtYears.Name = "txtYears"
    Me.txtYears.Size = New System.Drawing.Size(100, 20)
    Me.txtYears.TabIndex = 25
    '
    'txtInterest
    '
    Me.txtInterest.Location = New System.Drawing.Point(139, 63)
    Me.txtInterest.Name = "txtInterest"
    Me.txtInterest.Size = New System.Drawing.Size(100, 20)
    Me.txtInterest.TabIndex = 23
    '
    'lblError
    '
    Me.lblError.AutoEllipsis = true
    Me.lblError.AutoSize = true
    Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblError.ForeColor = System.Drawing.Color.DarkRed
    Me.lblError.Location = New System.Drawing.Point(136, 134)
    Me.lblError.Name = "lblError"
    Me.lblError.Size = New System.Drawing.Size(0, 16)
    Me.lblError.TabIndex = 28
    Me.lblError.Visible = false
    '
    'btnCalculate
    '
    Me.btnCalculate.Location = New System.Drawing.Point(48, 134)
    Me.btnCalculate.Name = "btnCalculate"
    Me.btnCalculate.Size = New System.Drawing.Size(191, 39)
    Me.btnCalculate.TabIndex = 27
    Me.btnCalculate.Text = "Calculate Monthly Payments"
    Me.btnCalculate.UseVisualStyleBackColor = true
    '
    'txtAmount
    '
    Me.txtAmount.Location = New System.Drawing.Point(139, 28)
    Me.txtAmount.Name = "txtAmount"
    Me.txtAmount.Size = New System.Drawing.Size(100, 20)
    Me.txtAmount.TabIndex = 22
    '
    'Label4
    '
    Me.Label4.AutoSize = true
    Me.Label4.Location = New System.Drawing.Point(48, 202)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(88, 13)
    Me.Label4.TabIndex = 20
    Me.Label4.Text = "Monthly Payment"
    '
    'Label3
    '
    Me.Label3.AutoSize = true
    Me.Label3.Location = New System.Drawing.Point(45, 101)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(88, 13)
    Me.Label3.TabIndex = 21
    Me.Label3.Text = "Number Of Years"
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(54, 66)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(79, 13)
    Me.Label2.TabIndex = 19
    Me.Label2.Text = "Interst Rate (%)"
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(49, 31)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(84, 13)
    Me.Label1.TabIndex = 18
    Me.Label1.Text = "Amount Of Loan"
    '
    'frmCarLoan
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(277, 241)
    Me.Controls.Add(Me.txtPayments)
    Me.Controls.Add(Me.txtYears)
    Me.Controls.Add(Me.txtInterest)
    Me.Controls.Add(Me.lblError)
    Me.Controls.Add(Me.btnCalculate)
    Me.Controls.Add(Me.txtAmount)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmCarLoan"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Car Loan"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents txtPayments As MaskedTextBox
  Friend WithEvents txtYears As MaskedTextBox
  Friend WithEvents txtInterest As MaskedTextBox
  Friend WithEvents lblError As Label
  Friend WithEvents btnCalculate As Button
  Friend WithEvents txtAmount As TextBox
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
End Class
