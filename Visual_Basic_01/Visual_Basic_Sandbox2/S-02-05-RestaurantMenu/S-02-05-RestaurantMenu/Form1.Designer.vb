<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestaurantMenu
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
    Me.grpDrinks = New System.Windows.Forms.GroupBox()
    Me.radWater = New System.Windows.Forms.RadioButton()
    Me.radSoda = New System.Windows.Forms.RadioButton()
    Me.grpFries = New System.Windows.Forms.GroupBox()
    Me.radLarge = New System.Windows.Forms.RadioButton()
    Me.radMedium = New System.Windows.Forms.RadioButton()
    Me.radSmall = New System.Windows.Forms.RadioButton()
    Me.grpBurgers = New System.Windows.Forms.GroupBox()
    Me.radCheeseBacon = New System.Windows.Forms.RadioButton()
    Me.radBacon = New System.Windows.Forms.RadioButton()
    Me.radCheese = New System.Windows.Forms.RadioButton()
    Me.radRegular = New System.Windows.Forms.RadioButton()
    Me.chkDrinks = New System.Windows.Forms.CheckBox()
    Me.chkFries = New System.Windows.Forms.CheckBox()
    Me.chkBurgers = New System.Windows.Forms.CheckBox()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.txtCost = New System.Windows.Forms.TextBox()
    Me.btnCalculate = New System.Windows.Forms.Button()
    Me.grpDrinks.SuspendLayout
    Me.grpFries.SuspendLayout
    Me.grpBurgers.SuspendLayout
    Me.SuspendLayout
    '
    'grpDrinks
    '
    Me.grpDrinks.Controls.Add(Me.radWater)
    Me.grpDrinks.Controls.Add(Me.radSoda)
    Me.grpDrinks.Location = New System.Drawing.Point(88, 285)
    Me.grpDrinks.Name = "grpDrinks"
    Me.grpDrinks.Size = New System.Drawing.Size(200, 82)
    Me.grpDrinks.TabIndex = 13
    Me.grpDrinks.TabStop = false
    Me.grpDrinks.Text = "Choices for Drinks"
    Me.grpDrinks.Visible = false
    '
    'radWater
    '
    Me.radWater.AutoSize = true
    Me.radWater.Location = New System.Drawing.Point(6, 50)
    Me.radWater.Name = "radWater"
    Me.radWater.Size = New System.Drawing.Size(126, 17)
    Me.radWater.TabIndex = 1
    Me.radWater.TabStop = true
    Me.radWater.Text = "Bottled Water ($1.49)"
    Me.radWater.UseVisualStyleBackColor = true
    '
    'radSoda
    '
    Me.radSoda.AutoSize = true
    Me.radSoda.Location = New System.Drawing.Point(6, 27)
    Me.radSoda.Name = "radSoda"
    Me.radSoda.Size = New System.Drawing.Size(86, 17)
    Me.radSoda.TabIndex = 0
    Me.radSoda.TabStop = true
    Me.radSoda.Text = "Soda ($1.69)"
    Me.radSoda.UseVisualStyleBackColor = true
    '
    'grpFries
    '
    Me.grpFries.Controls.Add(Me.radLarge)
    Me.grpFries.Controls.Add(Me.radMedium)
    Me.grpFries.Controls.Add(Me.radSmall)
    Me.grpFries.Location = New System.Drawing.Point(90, 164)
    Me.grpFries.Name = "grpFries"
    Me.grpFries.Size = New System.Drawing.Size(200, 100)
    Me.grpFries.TabIndex = 17
    Me.grpFries.TabStop = false
    Me.grpFries.Text = "Choices for Fries"
    Me.grpFries.Visible = false
    '
    'radLarge
    '
    Me.radLarge.AutoSize = true
    Me.radLarge.Location = New System.Drawing.Point(8, 68)
    Me.radLarge.Name = "radLarge"
    Me.radLarge.Size = New System.Drawing.Size(88, 17)
    Me.radLarge.TabIndex = 2
    Me.radLarge.TabStop = true
    Me.radLarge.Text = "Large ($4.99)"
    Me.radLarge.UseVisualStyleBackColor = true
    '
    'radMedium
    '
    Me.radMedium.AutoSize = true
    Me.radMedium.Location = New System.Drawing.Point(8, 45)
    Me.radMedium.Name = "radMedium"
    Me.radMedium.Size = New System.Drawing.Size(98, 17)
    Me.radMedium.TabIndex = 1
    Me.radMedium.TabStop = true
    Me.radMedium.Text = "Medium ($3.09)"
    Me.radMedium.UseVisualStyleBackColor = true
    '
    'radSmall
    '
    Me.radSmall.AutoSize = true
    Me.radSmall.Location = New System.Drawing.Point(8, 22)
    Me.radSmall.Name = "radSmall"
    Me.radSmall.Size = New System.Drawing.Size(86, 17)
    Me.radSmall.TabIndex = 0
    Me.radSmall.TabStop = true
    Me.radSmall.Text = "Small ($2.39)"
    Me.radSmall.UseVisualStyleBackColor = true
    '
    'grpBurgers
    '
    Me.grpBurgers.Controls.Add(Me.radCheeseBacon)
    Me.grpBurgers.Controls.Add(Me.radBacon)
    Me.grpBurgers.Controls.Add(Me.radCheese)
    Me.grpBurgers.Controls.Add(Me.radRegular)
    Me.grpBurgers.Location = New System.Drawing.Point(90, 24)
    Me.grpBurgers.Name = "grpBurgers"
    Me.grpBurgers.Size = New System.Drawing.Size(198, 123)
    Me.grpBurgers.TabIndex = 16
    Me.grpBurgers.TabStop = false
    Me.grpBurgers.Text = "Choices for Burgers"
    Me.grpBurgers.Visible = false
    '
    'radCheeseBacon
    '
    Me.radCheeseBacon.AutoSize = true
    Me.radCheeseBacon.Location = New System.Drawing.Point(6, 93)
    Me.radCheeseBacon.Name = "radCheeseBacon"
    Me.radCheeseBacon.Size = New System.Drawing.Size(166, 17)
    Me.radCheeseBacon.TabIndex = 3
    Me.radCheeseBacon.TabStop = true
    Me.radCheeseBacon.Text = "w/ bacon and cheese ($5.39)"
    Me.radCheeseBacon.UseVisualStyleBackColor = true
    '
    'radBacon
    '
    Me.radBacon.AutoSize = true
    Me.radBacon.Location = New System.Drawing.Point(6, 70)
    Me.radBacon.Name = "radBacon"
    Me.radBacon.Size = New System.Drawing.Size(107, 17)
    Me.radBacon.TabIndex = 2
    Me.radBacon.TabStop = true
    Me.radBacon.Text = "w/ bacon ($4.79)"
    Me.radBacon.UseVisualStyleBackColor = true
    '
    'radCheese
    '
    Me.radCheese.AutoSize = true
    Me.radCheese.Location = New System.Drawing.Point(6, 47)
    Me.radCheese.Name = "radCheese"
    Me.radCheese.Size = New System.Drawing.Size(112, 17)
    Me.radCheese.TabIndex = 1
    Me.radCheese.TabStop = true
    Me.radCheese.Text = "w/ cheese ($4.79)"
    Me.radCheese.UseVisualStyleBackColor = true
    '
    'radRegular
    '
    Me.radRegular.AutoSize = true
    Me.radRegular.Location = New System.Drawing.Point(6, 24)
    Me.radRegular.Name = "radRegular"
    Me.radRegular.Size = New System.Drawing.Size(98, 17)
    Me.radRegular.TabIndex = 0
    Me.radRegular.TabStop = true
    Me.radRegular.Text = "Regular ($4.19)"
    Me.radRegular.UseVisualStyleBackColor = true
    '
    'chkDrinks
    '
    Me.chkDrinks.AutoSize = true
    Me.chkDrinks.Location = New System.Drawing.Point(14, 285)
    Me.chkDrinks.Name = "chkDrinks"
    Me.chkDrinks.Size = New System.Drawing.Size(56, 17)
    Me.chkDrinks.TabIndex = 15
    Me.chkDrinks.Text = "Drinks"
    Me.chkDrinks.UseVisualStyleBackColor = true
    '
    'chkFries
    '
    Me.chkFries.AutoSize = true
    Me.chkFries.Location = New System.Drawing.Point(22, 164)
    Me.chkFries.Name = "chkFries"
    Me.chkFries.Size = New System.Drawing.Size(48, 17)
    Me.chkFries.TabIndex = 14
    Me.chkFries.Text = "Fries"
    Me.chkFries.UseVisualStyleBackColor = true
    '
    'chkBurgers
    '
    Me.chkBurgers.AutoSize = true
    Me.chkBurgers.Location = New System.Drawing.Point(22, 24)
    Me.chkBurgers.Name = "chkBurgers"
    Me.chkBurgers.Size = New System.Drawing.Size(62, 17)
    Me.chkBurgers.TabIndex = 11
    Me.chkBurgers.Text = "Burgers"
    Me.chkBurgers.UseVisualStyleBackColor = true
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
    Me.Label1.Location = New System.Drawing.Point(305, 350)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(117, 13)
    Me.Label1.TabIndex = 10
    Me.Label1.Text = "Cost of the Meal is:"
    '
    'txtCost
    '
    Me.txtCost.Location = New System.Drawing.Point(428, 347)
    Me.txtCost.Name = "txtCost"
    Me.txtCost.ReadOnly = true
    Me.txtCost.Size = New System.Drawing.Size(64, 20)
    Me.txtCost.TabIndex = 9
    Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'btnCalculate
    '
    Me.btnCalculate.Location = New System.Drawing.Point(308, 281)
    Me.btnCalculate.Name = "btnCalculate"
    Me.btnCalculate.Size = New System.Drawing.Size(184, 44)
    Me.btnCalculate.TabIndex = 8
    Me.btnCalculate.Text = "Calculate Cost of the Meal"
    Me.btnCalculate.UseVisualStyleBackColor = true
    '
    'frmRestaurantMenu
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(517, 402)
    Me.Controls.Add(Me.grpDrinks)
    Me.Controls.Add(Me.grpFries)
    Me.Controls.Add(Me.grpBurgers)
    Me.Controls.Add(Me.chkDrinks)
    Me.Controls.Add(Me.chkFries)
    Me.Controls.Add(Me.chkBurgers)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.txtCost)
    Me.Controls.Add(Me.btnCalculate)
    Me.Name = "frmRestaurantMenu"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Restaurant Menu"
    Me.grpDrinks.ResumeLayout(false)
    Me.grpDrinks.PerformLayout
    Me.grpFries.ResumeLayout(false)
    Me.grpFries.PerformLayout
    Me.grpBurgers.ResumeLayout(false)
    Me.grpBurgers.PerformLayout
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub
  Friend WithEvents grpDrinks As GroupBox
  Friend WithEvents radWater As RadioButton
  Friend WithEvents radSoda As RadioButton
  Friend WithEvents grpFries As GroupBox
  Friend WithEvents radLarge As RadioButton
  Friend WithEvents radMedium As RadioButton
  Friend WithEvents radSmall As RadioButton
  Friend WithEvents grpBurgers As GroupBox
  Friend WithEvents radCheeseBacon As RadioButton
  Friend WithEvents radBacon As RadioButton
  Friend WithEvents radCheese As RadioButton
  Friend WithEvents radRegular As RadioButton
  Friend WithEvents chkDrinks As CheckBox
  Friend WithEvents chkFries As CheckBox
  Friend WithEvents chkBurgers As CheckBox
  Friend WithEvents Label1 As Label
  Friend WithEvents txtCost As TextBox
  Friend WithEvents btnCalculate As Button
End Class
