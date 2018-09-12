<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBankAccount
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
    Me.dgvTransactions = New System.Windows.Forms.DataGridView()
    Me.grpCheck = New System.Windows.Forms.GroupBox()
    Me.txtCheckTo = New System.Windows.Forms.TextBox()
    Me.txtCheck = New System.Windows.Forms.TextBox()
    Me.btnCheck = New System.Windows.Forms.Button()
    Me.lblCheckDollar = New System.Windows.Forms.Label()
    Me.lblCheckTo = New System.Windows.Forms.Label()
    Me.lblCheck = New System.Windows.Forms.Label()
    Me.grpWithdrawal = New System.Windows.Forms.GroupBox()
    Me.txtWithdrawal = New System.Windows.Forms.TextBox()
    Me.btnWithdrawal = New System.Windows.Forms.Button()
    Me.lblWithdrawalDollar = New System.Windows.Forms.Label()
    Me.grpTransfer = New System.Windows.Forms.GroupBox()
    Me.txtTransfer = New System.Windows.Forms.TextBox()
    Me.btnTransfer = New System.Windows.Forms.Button()
    Me.lblTransDollar = New System.Windows.Forms.Label()
    Me.lblTransferTo = New System.Windows.Forms.Label()
    Me.lblTransfer = New System.Windows.Forms.Label()
    Me.cboTransfer = New System.Windows.Forms.ComboBox()
    Me.grpCredit = New System.Windows.Forms.GroupBox()
    Me.txtDeposit = New System.Windows.Forms.TextBox()
    Me.btnDeposit = New System.Windows.Forms.Button()
    Me.lblDepositDollar = New System.Windows.Forms.Label()
    Me.grpAccount = New System.Windows.Forms.GroupBox()
    Me.txtDate = New System.Windows.Forms.TextBox()
    Me.lblDate = New System.Windows.Forms.Label()
    Me.txtBalance = New System.Windows.Forms.TextBox()
    Me.lblBalance = New System.Windows.Forms.Label()
    Me.lblAccount = New System.Windows.Forms.Label()
    Me.cboAccount = New System.Windows.Forms.ComboBox()
    CType(Me.dgvTransactions,System.ComponentModel.ISupportInitialize).BeginInit
    Me.grpCheck.SuspendLayout
    Me.grpWithdrawal.SuspendLayout
    Me.grpTransfer.SuspendLayout
    Me.grpCredit.SuspendLayout
    Me.grpAccount.SuspendLayout
    Me.SuspendLayout
    '
    'dgvTransactions
    '
    Me.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
    Me.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvTransactions.Location = New System.Drawing.Point(180, 237)
    Me.dgvTransactions.Name = "dgvTransactions"
    Me.dgvTransactions.RowHeadersVisible = false
    Me.dgvTransactions.Size = New System.Drawing.Size(338, 132)
    Me.dgvTransactions.TabIndex = 13
    '
    'grpCheck
    '
    Me.grpCheck.Controls.Add(Me.txtCheckTo)
    Me.grpCheck.Controls.Add(Me.txtCheck)
    Me.grpCheck.Controls.Add(Me.btnCheck)
    Me.grpCheck.Controls.Add(Me.lblCheckDollar)
    Me.grpCheck.Controls.Add(Me.lblCheckTo)
    Me.grpCheck.Controls.Add(Me.lblCheck)
    Me.grpCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.grpCheck.Location = New System.Drawing.Point(472, 84)
    Me.grpCheck.Name = "grpCheck"
    Me.grpCheck.Size = New System.Drawing.Size(209, 136)
    Me.grpCheck.TabIndex = 11
    Me.grpCheck.TabStop = false
    Me.grpCheck.Text = "Check"
    '
    'txtCheckTo
    '
    Me.txtCheckTo.Location = New System.Drawing.Point(94, 49)
    Me.txtCheckTo.Name = "txtCheckTo"
    Me.txtCheckTo.Size = New System.Drawing.Size(102, 20)
    Me.txtCheckTo.TabIndex = 4
    '
    'txtCheck
    '
    Me.txtCheck.Location = New System.Drawing.Point(132, 18)
    Me.txtCheck.Name = "txtCheck"
    Me.txtCheck.Size = New System.Drawing.Size(64, 20)
    Me.txtCheck.TabIndex = 2
    '
    'btnCheck
    '
    Me.btnCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnCheck.Location = New System.Drawing.Point(100, 84)
    Me.btnCheck.Name = "btnCheck"
    Me.btnCheck.Size = New System.Drawing.Size(96, 29)
    Me.btnCheck.TabIndex = 5
    Me.btnCheck.Text = "Sign Check"
    '
    'lblCheckDollar
    '
    Me.lblCheckDollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblCheckDollar.Location = New System.Drawing.Point(111, 18)
    Me.lblCheckDollar.Name = "lblCheckDollar"
    Me.lblCheckDollar.Size = New System.Drawing.Size(20, 23)
    Me.lblCheckDollar.TabIndex = 1
    Me.lblCheckDollar.Text = "$"
    Me.lblCheckDollar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblCheckTo
    '
    Me.lblCheckTo.AutoSize = true
    Me.lblCheckTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblCheckTo.Location = New System.Drawing.Point(19, 52)
    Me.lblCheckTo.Name = "lblCheckTo"
    Me.lblCheckTo.Size = New System.Drawing.Size(73, 13)
    Me.lblCheckTo.TabIndex = 3
    Me.lblCheckTo.Text = "to the order of"
    Me.lblCheckTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblCheck
    '
    Me.lblCheck.AutoSize = true
    Me.lblCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblCheck.Location = New System.Drawing.Point(19, 21)
    Me.lblCheck.Name = "lblCheck"
    Me.lblCheck.Size = New System.Drawing.Size(82, 13)
    Me.lblCheck.TabIndex = 0
    Me.lblCheck.Text = "Pay this amount"
    Me.lblCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'grpWithdrawal
    '
    Me.grpWithdrawal.Controls.Add(Me.txtWithdrawal)
    Me.grpWithdrawal.Controls.Add(Me.btnWithdrawal)
    Me.grpWithdrawal.Controls.Add(Me.lblWithdrawalDollar)
    Me.grpWithdrawal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.grpWithdrawal.Location = New System.Drawing.Point(17, 156)
    Me.grpWithdrawal.Name = "grpWithdrawal"
    Me.grpWithdrawal.Size = New System.Drawing.Size(242, 64)
    Me.grpWithdrawal.TabIndex = 12
    Me.grpWithdrawal.TabStop = false
    Me.grpWithdrawal.Text = "Withdrawal"
    '
    'txtWithdrawal
    '
    Me.txtWithdrawal.Location = New System.Drawing.Point(44, 21)
    Me.txtWithdrawal.Name = "txtWithdrawal"
    Me.txtWithdrawal.Size = New System.Drawing.Size(81, 20)
    Me.txtWithdrawal.TabIndex = 1
    '
    'btnWithdrawal
    '
    Me.btnWithdrawal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnWithdrawal.Location = New System.Drawing.Point(143, 17)
    Me.btnWithdrawal.Name = "btnWithdrawal"
    Me.btnWithdrawal.Size = New System.Drawing.Size(87, 29)
    Me.btnWithdrawal.TabIndex = 2
    Me.btnWithdrawal.Text = "Withdrawal"
    '
    'lblWithdrawalDollar
    '
    Me.lblWithdrawalDollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblWithdrawalDollar.Location = New System.Drawing.Point(19, 19)
    Me.lblWithdrawalDollar.Name = "lblWithdrawalDollar"
    Me.lblWithdrawalDollar.Size = New System.Drawing.Size(20, 23)
    Me.lblWithdrawalDollar.TabIndex = 0
    Me.lblWithdrawalDollar.Text = "$"
    Me.lblWithdrawalDollar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'grpTransfer
    '
    Me.grpTransfer.Controls.Add(Me.txtTransfer)
    Me.grpTransfer.Controls.Add(Me.btnTransfer)
    Me.grpTransfer.Controls.Add(Me.lblTransDollar)
    Me.grpTransfer.Controls.Add(Me.lblTransferTo)
    Me.grpTransfer.Controls.Add(Me.lblTransfer)
    Me.grpTransfer.Controls.Add(Me.cboTransfer)
    Me.grpTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.grpTransfer.Location = New System.Drawing.Point(268, 84)
    Me.grpTransfer.Name = "grpTransfer"
    Me.grpTransfer.Size = New System.Drawing.Size(189, 136)
    Me.grpTransfer.TabIndex = 10
    Me.grpTransfer.TabStop = false
    Me.grpTransfer.Text = "Transfer"
    '
    'txtTransfer
    '
    Me.txtTransfer.Location = New System.Drawing.Point(95, 54)
    Me.txtTransfer.Name = "txtTransfer"
    Me.txtTransfer.Size = New System.Drawing.Size(78, 20)
    Me.txtTransfer.TabIndex = 4
    '
    'btnTransfer
    '
    Me.btnTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnTransfer.Location = New System.Drawing.Point(86, 84)
    Me.btnTransfer.Name = "btnTransfer"
    Me.btnTransfer.Size = New System.Drawing.Size(87, 29)
    Me.btnTransfer.TabIndex = 5
    Me.btnTransfer.Text = "Transfer"
    '
    'lblTransDollar
    '
    Me.lblTransDollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTransDollar.Location = New System.Drawing.Point(77, 50)
    Me.lblTransDollar.Name = "lblTransDollar"
    Me.lblTransDollar.Size = New System.Drawing.Size(19, 23)
    Me.lblTransDollar.TabIndex = 3
    Me.lblTransDollar.Text = "$"
    Me.lblTransDollar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblTransferTo
    '
    Me.lblTransferTo.AutoSize = true
    Me.lblTransferTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTransferTo.Location = New System.Drawing.Point(19, 58)
    Me.lblTransferTo.Name = "lblTransferTo"
    Me.lblTransferTo.Size = New System.Drawing.Size(16, 13)
    Me.lblTransferTo.TabIndex = 2
    Me.lblTransferTo.Text = "to"
    Me.lblTransferTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblTransfer
    '
    Me.lblTransfer.AutoSize = true
    Me.lblTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblTransfer.Location = New System.Drawing.Point(19, 23)
    Me.lblTransfer.Name = "lblTransfer"
    Me.lblTransfer.Size = New System.Drawing.Size(69, 13)
    Me.lblTransfer.TabIndex = 0
    Me.lblTransfer.Text = "Transfer from"
    Me.lblTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'cboTransfer
    '
    Me.cboTransfer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboTransfer.FormattingEnabled = true
    Me.cboTransfer.Items.AddRange(New Object() {"Checking", "Savings"})
    Me.cboTransfer.Location = New System.Drawing.Point(95, 19)
    Me.cboTransfer.MaxDropDownItems = 2
    Me.cboTransfer.Name = "cboTransfer"
    Me.cboTransfer.Size = New System.Drawing.Size(78, 21)
    Me.cboTransfer.TabIndex = 1
    '
    'grpCredit
    '
    Me.grpCredit.Controls.Add(Me.txtDeposit)
    Me.grpCredit.Controls.Add(Me.btnDeposit)
    Me.grpCredit.Controls.Add(Me.lblDepositDollar)
    Me.grpCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.grpCredit.Location = New System.Drawing.Point(17, 84)
    Me.grpCredit.Name = "grpCredit"
    Me.grpCredit.Size = New System.Drawing.Size(242, 64)
    Me.grpCredit.TabIndex = 9
    Me.grpCredit.TabStop = false
    Me.grpCredit.Text = "Deposit"
    '
    'txtDeposit
    '
    Me.txtDeposit.Location = New System.Drawing.Point(42, 21)
    Me.txtDeposit.Name = "txtDeposit"
    Me.txtDeposit.Size = New System.Drawing.Size(83, 20)
    Me.txtDeposit.TabIndex = 0
    '
    'btnDeposit
    '
    Me.btnDeposit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnDeposit.Location = New System.Drawing.Point(143, 19)
    Me.btnDeposit.Name = "btnDeposit"
    Me.btnDeposit.Size = New System.Drawing.Size(87, 29)
    Me.btnDeposit.TabIndex = 1
    Me.btnDeposit.Text = "Deposit"
    '
    'lblDepositDollar
    '
    Me.lblDepositDollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.lblDepositDollar.Location = New System.Drawing.Point(19, 19)
    Me.lblDepositDollar.Name = "lblDepositDollar"
    Me.lblDepositDollar.Size = New System.Drawing.Size(20, 23)
    Me.lblDepositDollar.TabIndex = 9
    Me.lblDepositDollar.Text = "$"
    Me.lblDepositDollar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'grpAccount
    '
    Me.grpAccount.Controls.Add(Me.txtDate)
    Me.grpAccount.Controls.Add(Me.lblDate)
    Me.grpAccount.Controls.Add(Me.txtBalance)
    Me.grpAccount.Controls.Add(Me.lblBalance)
    Me.grpAccount.Controls.Add(Me.lblAccount)
    Me.grpAccount.Controls.Add(Me.cboAccount)
    Me.grpAccount.Location = New System.Drawing.Point(23, 12)
    Me.grpAccount.Name = "grpAccount"
    Me.grpAccount.Size = New System.Drawing.Size(658, 66)
    Me.grpAccount.TabIndex = 8
    Me.grpAccount.TabStop = false
    '
    'txtDate
    '
    Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.txtDate.Location = New System.Drawing.Point(567, 20)
    Me.txtDate.Name = "txtDate"
    Me.txtDate.ReadOnly = true
    Me.txtDate.Size = New System.Drawing.Size(77, 20)
    Me.txtDate.TabIndex = 6
    '
    'lblDate
    '
    Me.lblDate.AutoSize = true
    Me.lblDate.Location = New System.Drawing.Point(487, 24)
    Me.lblDate.Name = "lblDate"
    Me.lblDate.Size = New System.Drawing.Size(73, 13)
    Me.lblDate.TabIndex = 5
    Me.lblDate.Text = "Today's Date:"
    Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'txtBalance
    '
    Me.txtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
    Me.txtBalance.Location = New System.Drawing.Point(298, 16)
    Me.txtBalance.Name = "txtBalance"
    Me.txtBalance.ReadOnly = true
    Me.txtBalance.Size = New System.Drawing.Size(113, 20)
    Me.txtBalance.TabIndex = 3
    Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'lblBalance
    '
    Me.lblBalance.AutoSize = true
    Me.lblBalance.Location = New System.Drawing.Point(242, 24)
    Me.lblBalance.Name = "lblBalance"
    Me.lblBalance.Size = New System.Drawing.Size(49, 13)
    Me.lblBalance.TabIndex = 2
    Me.lblBalance.Text = "Balance:"
    Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'lblAccount
    '
    Me.lblAccount.AutoSize = true
    Me.lblAccount.Location = New System.Drawing.Point(28, 22)
    Me.lblAccount.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
    Me.lblAccount.Name = "lblAccount"
    Me.lblAccount.Size = New System.Drawing.Size(50, 13)
    Me.lblAccount.TabIndex = 0
    Me.lblAccount.Text = "Account:"
    Me.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
    '
    'cboAccount
    '
    Me.cboAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    Me.cboAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.cboAccount.FormattingEnabled = true
    Me.cboAccount.Items.AddRange(New Object() {"Checking", "Savings"})
    Me.cboAccount.Location = New System.Drawing.Point(80, 19)
    Me.cboAccount.Margin = New System.Windows.Forms.Padding(1, 3, 3, 3)
    Me.cboAccount.MaxDropDownItems = 2
    Me.cboAccount.Name = "cboAccount"
    Me.cboAccount.Size = New System.Drawing.Size(78, 21)
    Me.cboAccount.TabIndex = 1
    '
    'frmBankAccount
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(704, 398)
    Me.Controls.Add(Me.dgvTransactions)
    Me.Controls.Add(Me.grpCheck)
    Me.Controls.Add(Me.grpWithdrawal)
    Me.Controls.Add(Me.grpTransfer)
    Me.Controls.Add(Me.grpCredit)
    Me.Controls.Add(Me.grpAccount)
    Me.Name = "frmBankAccount"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Bank Account"
    CType(Me.dgvTransactions,System.ComponentModel.ISupportInitialize).EndInit
    Me.grpCheck.ResumeLayout(false)
    Me.grpCheck.PerformLayout
    Me.grpWithdrawal.ResumeLayout(false)
    Me.grpWithdrawal.PerformLayout
    Me.grpTransfer.ResumeLayout(false)
    Me.grpTransfer.PerformLayout
    Me.grpCredit.ResumeLayout(false)
    Me.grpCredit.PerformLayout
    Me.grpAccount.ResumeLayout(false)
    Me.grpAccount.PerformLayout
    Me.ResumeLayout(false)

End Sub

  Friend WithEvents dgvTransactions As DataGridView
  Friend WithEvents grpCheck As GroupBox
  Friend WithEvents txtCheckTo As TextBox
  Friend WithEvents txtCheck As TextBox
  Friend WithEvents btnCheck As Button
  Friend WithEvents lblCheckDollar As Label
  Friend WithEvents lblCheckTo As Label
  Friend WithEvents lblCheck As Label
  Friend WithEvents grpWithdrawal As GroupBox
  Friend WithEvents txtWithdrawal As TextBox
  Friend WithEvents btnWithdrawal As Button
  Friend WithEvents lblWithdrawalDollar As Label
  Friend WithEvents grpTransfer As GroupBox
  Friend WithEvents txtTransfer As TextBox
  Friend WithEvents btnTransfer As Button
  Friend WithEvents lblTransDollar As Label
  Friend WithEvents lblTransferTo As Label
  Friend WithEvents lblTransfer As Label
  Friend WithEvents cboTransfer As ComboBox
  Friend WithEvents grpCredit As GroupBox
  Friend WithEvents txtDeposit As TextBox
  Friend WithEvents btnDeposit As Button
  Friend WithEvents lblDepositDollar As Label
  Friend WithEvents grpAccount As GroupBox
  Friend WithEvents txtDate As TextBox
  Friend WithEvents lblDate As Label
  Friend WithEvents txtBalance As TextBox
  Friend WithEvents lblBalance As Label
  Friend WithEvents lblAccount As Label
  Friend WithEvents cboAccount As ComboBox
End Class
