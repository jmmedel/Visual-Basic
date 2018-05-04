<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestaurantBill
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
    Me.lstDisplay = New System.Windows.Forms.ListBox()
    Me.btnCalculate = New System.Windows.Forms.Button()
    Me.txtDrinks = New System.Windows.Forms.TextBox()
    Me.txtFries = New System.Windows.Forms.TextBox()
    Me.txtPizza = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout
    '
    'lstDisplay
    '
    Me.lstDisplay.Enabled = false
    Me.lstDisplay.FormattingEnabled = true
    Me.lstDisplay.Location = New System.Drawing.Point(20, 112)
    Me.lstDisplay.Name = "lstDisplay"
    Me.lstDisplay.Size = New System.Drawing.Size(250, 147)
    Me.lstDisplay.TabIndex = 13
    '
    'btnCalculate
    '
    Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnCalculate.Location = New System.Drawing.Point(189, 22)
    Me.btnCalculate.Name = "btnCalculate"
    Me.btnCalculate.Size = New System.Drawing.Size(81, 72)
    Me.btnCalculate.TabIndex = 12
    Me.btnCalculate.Text = "Calculate Total Cost"
    Me.btnCalculate.UseVisualStyleBackColor = true
    '
    'txtDrinks
    '
    Me.txtDrinks.Location = New System.Drawing.Point(136, 74)
    Me.txtDrinks.Name = "txtDrinks"
    Me.txtDrinks.Size = New System.Drawing.Size(33, 20)
    Me.txtDrinks.TabIndex = 11
    '
    'txtFries
    '
    Me.txtFries.Location = New System.Drawing.Point(136, 48)
    Me.txtFries.Name = "txtFries"
    Me.txtFries.Size = New System.Drawing.Size(33, 20)
    Me.txtFries.TabIndex = 9
    '
    'txtPizza
    '
    Me.txtPizza.Location = New System.Drawing.Point(136, 22)
    Me.txtPizza.Name = "txtPizza"
    Me.txtPizza.Size = New System.Drawing.Size(33, 20)
    Me.txtPizza.TabIndex = 7
    '
    'Label3
    '
    Me.Label3.AutoSize = true
    Me.Label3.Location = New System.Drawing.Point(22, 77)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(108, 13)
    Me.Label3.TabIndex = 10
    Me.Label3.Text = "How many soft drinks"
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(51, 51)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(79, 13)
    Me.Label2.TabIndex = 8
    Me.Label2.Text = "How many fries"
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(17, 25)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(113, 13)
    Me.Label1.TabIndex = 6
    Me.Label1.Text = "How many pizza slices"
    '
    'frmRestaurantBill
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(297, 274)
    Me.Controls.Add(Me.lstDisplay)
    Me.Controls.Add(Me.btnCalculate)
    Me.Controls.Add(Me.txtDrinks)
    Me.Controls.Add(Me.txtFries)
    Me.Controls.Add(Me.txtPizza)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmRestaurantBill"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Restaurant Bill"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents lstDisplay As ListBox
  Friend WithEvents btnCalculate As Button
  Friend WithEvents txtDrinks As TextBox
  Friend WithEvents txtFries As TextBox
  Friend WithEvents txtPizza As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
End Class
