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
        Me.lblResults = New System.Windows.Forms.Label()
        Me.txtRightValue = New System.Windows.Forms.TextBox()
        Me.txtLeftValue = New System.Windows.Forms.TextBox()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.txtRoundingDigits = New System.Windows.Forms.TextBox()
        Me.lblRoundTo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(12, 206)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(0, 63)
        Me.lblResults.TabIndex = 2
        '
        'txtRightValue
        '
        Me.txtRightValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRightValue.Location = New System.Drawing.Point(201, 12)
        Me.txtRightValue.Name = "txtRightValue"
        Me.txtRightValue.Size = New System.Drawing.Size(161, 68)
        Me.txtRightValue.TabIndex = 3
        '
        'txtLeftValue
        '
        Me.txtLeftValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLeftValue.Location = New System.Drawing.Point(12, 12)
        Me.txtLeftValue.Name = "txtLeftValue"
        Me.txtLeftValue.Size = New System.Drawing.Size(161, 68)
        Me.txtLeftValue.TabIndex = 4
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(12, 108)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(200, 75)
        Me.btnDivide.TabIndex = 5
        Me.btnDivide.Text = "Divide"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'txtRoundingDigits
        '
        Me.txtRoundingDigits.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoundingDigits.Location = New System.Drawing.Point(665, 12)
        Me.txtRoundingDigits.Name = "txtRoundingDigits"
        Me.txtRoundingDigits.Size = New System.Drawing.Size(100, 68)
        Me.txtRoundingDigits.TabIndex = 6
        '
        'lblRoundTo
        '
        Me.lblRoundTo.AutoSize = True
        Me.lblRoundTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoundTo.Location = New System.Drawing.Point(381, 15)
        Me.lblRoundTo.Name = "lblRoundTo"
        Me.lblRoundTo.Size = New System.Drawing.Size(278, 63)
        Me.lblRoundTo.TabIndex = 7
        Me.lblRoundTo.Text = "Round To:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblRoundTo)
        Me.Controls.Add(Me.txtRoundingDigits)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.txtLeftValue)
        Me.Controls.Add(Me.txtRightValue)
        Me.Controls.Add(Me.lblResults)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResults As Label
    Friend WithEvents txtRightValue As TextBox
    Friend WithEvents txtLeftValue As TextBox
    Friend WithEvents btnDivide As Button
    Friend WithEvents txtRoundingDigits As TextBox
    Friend WithEvents lblRoundTo As Label
End Class
