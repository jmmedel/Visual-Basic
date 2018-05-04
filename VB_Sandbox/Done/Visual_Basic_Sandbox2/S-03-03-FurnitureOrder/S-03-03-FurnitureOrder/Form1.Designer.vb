<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFurnitureOrder
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
    Me.txtSofas = New System.Windows.Forms.TextBox()
    Me.txtChairs = New System.Windows.Forms.TextBox()
    Me.txtCity = New System.Windows.Forms.TextBox()
    Me.txtAddress = New System.Windows.Forms.TextBox()
    Me.txtName = New System.Windows.Forms.TextBox()
    Me.btnQuit = New System.Windows.Forms.Button()
    Me.btnClear = New System.Windows.Forms.Button()
    Me.btnProcessOrder = New System.Windows.Forms.Button()
    Me.lstDisplay = New System.Windows.Forms.ListBox()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout
    '
    'txtSofas
    '
    Me.txtSofas.Location = New System.Drawing.Point(182, 173)
    Me.txtSofas.Name = "txtSofas"
    Me.txtSofas.Size = New System.Drawing.Size(55, 20)
    Me.txtSofas.TabIndex = 18
    Me.txtSofas.Tag = "text"
    '
    'txtChairs
    '
    Me.txtChairs.Location = New System.Drawing.Point(182, 133)
    Me.txtChairs.Name = "txtChairs"
    Me.txtChairs.Size = New System.Drawing.Size(55, 20)
    Me.txtChairs.TabIndex = 16
    Me.txtChairs.Tag = "text"
    '
    'txtCity
    '
    Me.txtCity.Location = New System.Drawing.Point(182, 96)
    Me.txtCity.Name = "txtCity"
    Me.txtCity.Size = New System.Drawing.Size(218, 20)
    Me.txtCity.TabIndex = 14
    Me.txtCity.Tag = "text"
    '
    'txtAddress
    '
    Me.txtAddress.Location = New System.Drawing.Point(182, 57)
    Me.txtAddress.Name = "txtAddress"
    Me.txtAddress.Size = New System.Drawing.Size(218, 20)
    Me.txtAddress.TabIndex = 12
    Me.txtAddress.Tag = "text"
    '
    'txtName
    '
    Me.txtName.Location = New System.Drawing.Point(182, 19)
    Me.txtName.Name = "txtName"
    Me.txtName.Size = New System.Drawing.Size(218, 20)
    Me.txtName.TabIndex = 10
    Me.txtName.Tag = "text"
    '
    'btnQuit
    '
    Me.btnQuit.Location = New System.Drawing.Point(490, 239)
    Me.btnQuit.Name = "btnQuit"
    Me.btnQuit.Size = New System.Drawing.Size(184, 30)
    Me.btnQuit.TabIndex = 22
    Me.btnQuit.Text = "Quit"
    Me.btnQuit.UseVisualStyleBackColor = true
    '
    'btnClear
    '
    Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnClear.Location = New System.Drawing.Point(253, 238)
    Me.btnClear.Name = "btnClear"
    Me.btnClear.Size = New System.Drawing.Size(184, 30)
    Me.btnClear.TabIndex = 21
    Me.btnClear.Text = "Clear Order Form"
    Me.btnClear.UseVisualStyleBackColor = true
    '
    'btnProcessOrder
    '
    Me.btnProcessOrder.BackColor = System.Drawing.SystemColors.Control
    Me.btnProcessOrder.Location = New System.Drawing.Point(25, 239)
    Me.btnProcessOrder.Name = "btnProcessOrder"
    Me.btnProcessOrder.Size = New System.Drawing.Size(184, 29)
    Me.btnProcessOrder.TabIndex = 20
    Me.btnProcessOrder.Text = "Process Order"
    Me.btnProcessOrder.UseVisualStyleBackColor = false
    '
    'lstDisplay
    '
    Me.lstDisplay.Enabled = false
    Me.lstDisplay.FormattingEnabled = true
    Me.lstDisplay.Location = New System.Drawing.Point(433, 19)
    Me.lstDisplay.Name = "lstDisplay"
    Me.lstDisplay.Size = New System.Drawing.Size(241, 173)
    Me.lstDisplay.TabIndex = 19
    '
    'Label5
    '
    Me.Label5.AutoSize = true
    Me.Label5.Location = New System.Drawing.Point(31, 176)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(127, 13)
    Me.Label5.TabIndex = 17
    Me.Label5.Text = "Number of Sofas Ordered"
    '
    'Label4
    '
    Me.Label4.AutoSize = true
    Me.Label4.Location = New System.Drawing.Point(31, 136)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(129, 13)
    Me.Label4.TabIndex = 15
    Me.Label4.Text = "Number of Chairs Ordered"
    '
    'Label3
    '
    Me.Label3.AutoSize = true
    Me.Label3.Location = New System.Drawing.Point(80, 99)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(78, 13)
    Me.Label3.TabIndex = 13
    Me.Label3.Text = "City, State, ZIP"
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(123, 60)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(35, 13)
    Me.Label2.TabIndex = 11
    Me.Label2.Text = "Street"
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(22, 22)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(136, 13)
    Me.Label1.TabIndex = 9
    Me.Label1.Text = "Customer Name (Last, First)"
    '
    'frmFurnitureOrder
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(695, 286)
    Me.Controls.Add(Me.txtSofas)
    Me.Controls.Add(Me.txtChairs)
    Me.Controls.Add(Me.txtCity)
    Me.Controls.Add(Me.txtAddress)
    Me.Controls.Add(Me.txtName)
    Me.Controls.Add(Me.btnQuit)
    Me.Controls.Add(Me.btnClear)
    Me.Controls.Add(Me.btnProcessOrder)
    Me.Controls.Add(Me.lstDisplay)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmFurnitureOrder"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Furniture Order"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents txtSofas As TextBox
  Friend WithEvents txtChairs As TextBox
  Friend WithEvents txtCity As TextBox
  Friend WithEvents txtAddress As TextBox
  Friend WithEvents txtName As TextBox
  Friend WithEvents btnQuit As Button
  Friend WithEvents btnClear As Button
  Friend WithEvents btnProcessOrder As Button
  Friend WithEvents lstDisplay As ListBox
  Friend WithEvents Label5 As Label
  Friend WithEvents Label4 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
End Class
