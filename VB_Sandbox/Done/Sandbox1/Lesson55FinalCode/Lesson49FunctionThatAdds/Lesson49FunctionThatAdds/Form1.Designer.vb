<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.cmbOperations = New System.Windows.Forms.ComboBox()
        Me.txtLeftValue = New System.Windows.Forms.TextBox()
        Me.txtRightValue = New System.Windows.Forms.TextBox()
        Me.chkSaveOutput = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(12, 165)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 42)
        Me.lblResult.TabIndex = 4
        '
        'cmbOperations
        '
        Me.cmbOperations.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOperations.FormattingEnabled = True
        Me.cmbOperations.Items.AddRange(New Object() {"Add", "Multiply", "Divide", "Subtract"})
        Me.cmbOperations.Location = New System.Drawing.Point(13, 80)
        Me.cmbOperations.Name = "cmbOperations"
        Me.cmbOperations.Size = New System.Drawing.Size(380, 50)
        Me.cmbOperations.TabIndex = 2
        '
        'txtLeftValue
        '
        Me.txtLeftValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeftValue.Location = New System.Drawing.Point(13, 13)
        Me.txtLeftValue.Name = "txtLeftValue"
        Me.txtLeftValue.Size = New System.Drawing.Size(380, 49)
        Me.txtLeftValue.TabIndex = 0
        '
        'txtRightValue
        '
        Me.txtRightValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRightValue.Location = New System.Drawing.Point(399, 13)
        Me.txtRightValue.Name = "txtRightValue"
        Me.txtRightValue.Size = New System.Drawing.Size(389, 49)
        Me.txtRightValue.TabIndex = 1
        '
        'chkSaveOutput
        '
        Me.chkSaveOutput.AutoSize = True
        Me.chkSaveOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.chkSaveOutput.Location = New System.Drawing.Point(400, 86)
        Me.chkSaveOutput.Name = "chkSaveOutput"
        Me.chkSaveOutput.Size = New System.Drawing.Size(224, 43)
        Me.chkSaveOutput.TabIndex = 3
        Me.chkSaveOutput.Text = "Save Output"
        Me.chkSaveOutput.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.chkSaveOutput)
        Me.Controls.Add(Me.txtRightValue)
        Me.Controls.Add(Me.txtLeftValue)
        Me.Controls.Add(Me.cmbOperations)
        Me.Controls.Add(Me.lblResult)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResult As Label
    Friend WithEvents cmbOperations As ComboBox
    Friend WithEvents txtLeftValue As TextBox
    Friend WithEvents txtRightValue As TextBox
    Friend WithEvents chkSaveOutput As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
