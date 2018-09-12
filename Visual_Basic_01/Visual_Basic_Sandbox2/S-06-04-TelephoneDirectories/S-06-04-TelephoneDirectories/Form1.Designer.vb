<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhoneDirectories
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
    Me.dgvOutput = New System.Windows.Forms.DataGridView()
    Me.btnRemove = New System.Windows.Forms.Button()
    Me.btnAddListing = New System.Windows.Forms.Button()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtName = New System.Windows.Forms.TextBox()
    Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
    Me.txtCurrentDirectory = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.lstPhoneDirectories = New System.Windows.Forms.ListBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.btnNewDirectory = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    CType(Me.dgvOutput,System.ComponentModel.ISupportInitialize).BeginInit
    Me.SuspendLayout
    '
    'dgvOutput
    '
    Me.dgvOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
    Me.dgvOutput.Location = New System.Drawing.Point(123, 246)
    Me.dgvOutput.Name = "dgvOutput"
    Me.dgvOutput.RowHeadersVisible = false
    Me.dgvOutput.Size = New System.Drawing.Size(272, 120)
    Me.dgvOutput.TabIndex = 28
    '
    'btnRemove
    '
    Me.btnRemove.Location = New System.Drawing.Point(314, 182)
    Me.btnRemove.Name = "btnRemove"
    Me.btnRemove.Size = New System.Drawing.Size(131, 47)
    Me.btnRemove.TabIndex = 27
    Me.btnRemove.Text = "Remove a Listing from"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"the Current Directory"
    Me.btnRemove.UseVisualStyleBackColor = true
    '
    'btnAddListing
    '
    Me.btnAddListing.Location = New System.Drawing.Point(99, 182)
    Me.btnAddListing.Name = "btnAddListing"
    Me.btnAddListing.Size = New System.Drawing.Size(131, 47)
    Me.btnAddListing.TabIndex = 26
    Me.btnAddListing.Text = "Add a Listing to the"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Current Directory"
    Me.btnAddListing.UseVisualStyleBackColor = true
    '
    'Label5
    '
    Me.Label5.AutoSize = true
    Me.Label5.Location = New System.Drawing.Point(294, 144)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(78, 13)
    Me.Label5.TabIndex = 25
    Me.Label5.Text = "Phone Number"
    '
    'Label4
    '
    Me.Label4.AutoSize = true
    Me.Label4.Location = New System.Drawing.Point(337, 106)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(35, 13)
    Me.Label4.TabIndex = 24
    Me.Label4.Text = "Name"
    '
    'txtName
    '
    Me.txtName.Location = New System.Drawing.Point(378, 103)
    Me.txtName.Name = "txtName"
    Me.txtName.Size = New System.Drawing.Size(135, 20)
    Me.txtName.TabIndex = 23
    '
    'txtPhoneNumber
    '
    Me.txtPhoneNumber.Location = New System.Drawing.Point(378, 141)
    Me.txtPhoneNumber.Name = "txtPhoneNumber"
    Me.txtPhoneNumber.Size = New System.Drawing.Size(135, 20)
    Me.txtPhoneNumber.TabIndex = 22
    '
    'txtCurrentDirectory
    '
    Me.txtCurrentDirectory.Location = New System.Drawing.Point(378, 63)
    Me.txtCurrentDirectory.Name = "txtCurrentDirectory"
    Me.txtCurrentDirectory.ReadOnly = true
    Me.txtCurrentDirectory.Size = New System.Drawing.Size(135, 20)
    Me.txtCurrentDirectory.TabIndex = 21
    '
    'Label3
    '
    Me.Label3.AutoSize = true
    Me.Label3.Location = New System.Drawing.Point(252, 66)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(120, 13)
    Me.Label3.TabIndex = 20
    Me.Label3.Text = "Current Phone Directory"
    '
    'lstPhoneDirectories
    '
    Me.lstPhoneDirectories.FormattingEnabled = true
    Me.lstPhoneDirectories.Location = New System.Drawing.Point(15, 66)
    Me.lstPhoneDirectories.Name = "lstPhoneDirectories"
    Me.lstPhoneDirectories.Size = New System.Drawing.Size(215, 95)
    Me.lstPhoneDirectories.TabIndex = 19
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.Label2.Location = New System.Drawing.Point(44, 47)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(132, 16)
    Me.Label2.TabIndex = 18
    Me.Label2.Text = "Phone Directories"
    '
    'btnNewDirectory
    '
    Me.btnNewDirectory.Location = New System.Drawing.Point(299, 9)
    Me.btnNewDirectory.Name = "btnNewDirectory"
    Me.btnNewDirectory.Size = New System.Drawing.Size(214, 37)
    Me.btnNewDirectory.TabIndex = 17
    Me.btnNewDirectory.Text = "Create a New Phone Directory"
    Me.btnNewDirectory.UseVisualStyleBackColor = true
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(12, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(218, 26)
    Me.Label1.TabIndex = 16
    Me.Label1.Text = "Click on one of the existing phone directories"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"below to make it the current phon"& _ 
    "e directory"
    '
    'frmPhoneDirectories
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(531, 385)
    Me.Controls.Add(Me.dgvOutput)
    Me.Controls.Add(Me.btnRemove)
    Me.Controls.Add(Me.btnAddListing)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.txtName)
    Me.Controls.Add(Me.txtPhoneNumber)
    Me.Controls.Add(Me.txtCurrentDirectory)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.lstPhoneDirectories)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.btnNewDirectory)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmPhoneDirectories"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Telephone Directories"
    CType(Me.dgvOutput,System.ComponentModel.ISupportInitialize).EndInit
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents dgvOutput As DataGridView
  Friend WithEvents btnRemove As Button
  Friend WithEvents btnAddListing As Button
  Friend WithEvents Label5 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents txtName As TextBox
  Friend WithEvents txtPhoneNumber As TextBox
  Friend WithEvents txtCurrentDirectory As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents lstPhoneDirectories As ListBox
  Friend WithEvents Label2 As Label
  Friend WithEvents btnNewDirectory As Button
  Friend WithEvents Label1 As Label
End Class
