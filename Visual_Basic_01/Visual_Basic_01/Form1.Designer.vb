<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAddVal1 = New System.Windows.Forms.TextBox()
        Me.btnAddValues = New System.Windows.Forms.Button()
        Me.txtAddVal2 = New System.Windows.Forms.TextBox()
        Me.lblAddEqual = New System.Windows.Forms.Label()
        Me.txtSumAnswer = New System.Windows.Forms.TextBox()
        Me.txtDivisionAnswer = New System.Windows.Forms.TextBox()
        Me.lblDivideEqual = New System.Windows.Forms.Label()
        Me.txtDivideVal2 = New System.Windows.Forms.TextBox()
        Me.btnDivideValues = New System.Windows.Forms.Button()
        Me.txtDivideVal1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(29, 42)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(34, 12)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(69, 39)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 19)
        Me.txtName.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 89)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnMessage
        '
        Me.btnMessage.Location = New System.Drawing.Point(102, 89)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(75, 23)
        Me.btnMessage.TabIndex = 3
        Me.btnMessage.Text = "&Message"
        Me.btnMessage.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 89)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAddVal1
        '
        Me.txtAddVal1.Location = New System.Drawing.Point(20, 130)
        Me.txtAddVal1.Name = "txtAddVal1"
        Me.txtAddVal1.Size = New System.Drawing.Size(47, 19)
        Me.txtAddVal1.TabIndex = 5
        '
        'btnAddValues
        '
        Me.btnAddValues.Location = New System.Drawing.Point(73, 128)
        Me.btnAddValues.Name = "btnAddValues"
        Me.btnAddValues.Size = New System.Drawing.Size(31, 23)
        Me.btnAddValues.TabIndex = 6
        Me.btnAddValues.Text = "+"
        Me.btnAddValues.UseVisualStyleBackColor = True
        '
        'txtAddVal2
        '
        Me.txtAddVal2.Location = New System.Drawing.Point(110, 130)
        Me.txtAddVal2.Name = "txtAddVal2"
        Me.txtAddVal2.Size = New System.Drawing.Size(47, 19)
        Me.txtAddVal2.TabIndex = 7
        '
        'lblAddEqual
        '
        Me.lblAddEqual.AutoSize = True
        Me.lblAddEqual.Location = New System.Drawing.Point(163, 133)
        Me.lblAddEqual.Name = "lblAddEqual"
        Me.lblAddEqual.Size = New System.Drawing.Size(11, 12)
        Me.lblAddEqual.TabIndex = 8
        Me.lblAddEqual.Text = "="
        '
        'txtSumAnswer
        '
        Me.txtSumAnswer.Location = New System.Drawing.Point(207, 133)
        Me.txtSumAnswer.Name = "txtSumAnswer"
        Me.txtSumAnswer.Size = New System.Drawing.Size(47, 19)
        Me.txtSumAnswer.TabIndex = 9
        '
        'txtDivisionAnswer
        '
        Me.txtDivisionAnswer.Location = New System.Drawing.Point(207, 180)
        Me.txtDivisionAnswer.Name = "txtDivisionAnswer"
        Me.txtDivisionAnswer.Size = New System.Drawing.Size(47, 19)
        Me.txtDivisionAnswer.TabIndex = 14
        '
        'lblDivideEqual
        '
        Me.lblDivideEqual.AutoSize = True
        Me.lblDivideEqual.Location = New System.Drawing.Point(163, 180)
        Me.lblDivideEqual.Name = "lblDivideEqual"
        Me.lblDivideEqual.Size = New System.Drawing.Size(11, 12)
        Me.lblDivideEqual.TabIndex = 13
        Me.lblDivideEqual.Text = "="
        '
        'txtDivideVal2
        '
        Me.txtDivideVal2.Location = New System.Drawing.Point(110, 177)
        Me.txtDivideVal2.Name = "txtDivideVal2"
        Me.txtDivideVal2.Size = New System.Drawing.Size(47, 19)
        Me.txtDivideVal2.TabIndex = 12
        '
        'btnDivideValues
        '
        Me.btnDivideValues.Location = New System.Drawing.Point(73, 175)
        Me.btnDivideValues.Name = "btnDivideValues"
        Me.btnDivideValues.Size = New System.Drawing.Size(31, 23)
        Me.btnDivideValues.TabIndex = 11
        Me.btnDivideValues.Text = "/"
        Me.btnDivideValues.UseVisualStyleBackColor = True
        '
        'txtDivideVal1
        '
        Me.txtDivideVal1.Location = New System.Drawing.Point(20, 177)
        Me.txtDivideVal1.Name = "txtDivideVal1"
        Me.txtDivideVal1.Size = New System.Drawing.Size(47, 19)
        Me.txtDivideVal1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtDivisionAnswer)
        Me.Controls.Add(Me.lblDivideEqual)
        Me.Controls.Add(Me.txtDivideVal2)
        Me.Controls.Add(Me.btnDivideValues)
        Me.Controls.Add(Me.txtDivideVal1)
        Me.Controls.Add(Me.txtSumAnswer)
        Me.Controls.Add(Me.lblAddEqual)
        Me.Controls.Add(Me.txtAddVal2)
        Me.Controls.Add(Me.btnAddValues)
        Me.Controls.Add(Me.txtAddVal1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMessage)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnMessage As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAddVal1 As TextBox
    Friend WithEvents btnAddValues As Button
    Friend WithEvents txtAddVal2 As TextBox
    Friend WithEvents lblAddEqual As Label
    Friend WithEvents txtSumAnswer As TextBox
    Friend WithEvents txtDivisionAnswer As TextBox
    Friend WithEvents lblDivideEqual As Label
    Friend WithEvents txtDivideVal2 As TextBox
    Friend WithEvents btnDivideValues As Button
    Friend WithEvents txtDivideVal1 As TextBox
End Class
