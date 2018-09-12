<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNutrition
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
    Me.txtNameOfFood = New System.Windows.Forms.TextBox()
    Me.txtCaloriesPerServing = New System.Windows.Forms.TextBox()
    Me.txtGramsOfFat = New System.Windows.Forms.TextBox()
    Me.btnCalculate = New System.Windows.Forms.Button()
    Me.txtDisplay = New System.Windows.Forms.TextBox()
    Me.SuspendLayout
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(8, 19)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(76, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Name Of Food"
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(33, 48)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(102, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Calories Per Serving"
    '
    'Label3
    '
    Me.Label3.AutoSize = true
    Me.Label3.Location = New System.Drawing.Point(8, 77)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(127, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Grams Of Fat Per Serving"
    '
    'txtNameOfFood
    '
    Me.txtNameOfFood.Location = New System.Drawing.Point(90, 16)
    Me.txtNameOfFood.Name = "txtNameOfFood"
    Me.txtNameOfFood.Size = New System.Drawing.Size(131, 20)
    Me.txtNameOfFood.TabIndex = 0
    '
    'txtCaloriesPerServing
    '
    Me.txtCaloriesPerServing.Location = New System.Drawing.Point(141, 45)
    Me.txtCaloriesPerServing.Name = "txtCaloriesPerServing"
    Me.txtCaloriesPerServing.Size = New System.Drawing.Size(80, 20)
    Me.txtCaloriesPerServing.TabIndex = 1
    '
    'txtGramsOfFat
    '
    Me.txtGramsOfFat.Location = New System.Drawing.Point(141, 74)
    Me.txtGramsOfFat.Name = "txtGramsOfFat"
    Me.txtGramsOfFat.Size = New System.Drawing.Size(80, 20)
    Me.txtGramsOfFat.TabIndex = 2
    '
    'btnCalculate
    '
    Me.btnCalculate.BackColor = System.Drawing.SystemColors.AppWorkspace
    Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.btnCalculate.Location = New System.Drawing.Point(9, 110)
    Me.btnCalculate.Name = "btnCalculate"
    Me.btnCalculate.Size = New System.Drawing.Size(212, 46)
    Me.btnCalculate.TabIndex = 3
    Me.btnCalculate.Text = "Calculate % Calories From Fat"
    Me.btnCalculate.UseVisualStyleBackColor = false
    '
    'txtDisplay
    '
    Me.txtDisplay.Location = New System.Drawing.Point(9, 176)
    Me.txtDisplay.Multiline = true
    Me.txtDisplay.Name = "txtDisplay"
    Me.txtDisplay.ReadOnly = true
    Me.txtDisplay.Size = New System.Drawing.Size(209, 58)
    Me.txtDisplay.TabIndex = 4
    Me.txtDisplay.TabStop = false
    '
    'frmNutrition
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(228, 241)
    Me.Controls.Add(Me.txtDisplay)
    Me.Controls.Add(Me.btnCalculate)
    Me.Controls.Add(Me.txtGramsOfFat)
    Me.Controls.Add(Me.txtCaloriesPerServing)
    Me.Controls.Add(Me.txtNameOfFood)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmNutrition"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Nutrition"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents Label1 As Label
  Friend WithEvents Label2 As Label
  Friend WithEvents Label3 As Label
  Friend WithEvents txtNameOfFood As TextBox
  Friend WithEvents txtCaloriesPerServing As TextBox
  Friend WithEvents txtGramsOfFat As TextBox
  Friend WithEvents btnCalculate As Button
  Friend WithEvents txtDisplay As TextBox
End Class
