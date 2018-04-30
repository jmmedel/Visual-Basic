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
        Me.txtLeftValue = New System.Windows.Forms.TextBox()
        Me.txtRightValue = New System.Windows.Forms.TextBox()
        Me.btnSummarize = New System.Windows.Forms.Button()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtLeftValue
        '
        Me.txtLeftValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.txtLeftValue.Location = New System.Drawing.Point(74, 13)
        Me.txtLeftValue.Name = "txtLeftValue"
        Me.txtLeftValue.Size = New System.Drawing.Size(100, 68)
        Me.txtLeftValue.TabIndex = 0
        '
        'txtRightValue
        '
        Me.txtRightValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.txtRightValue.Location = New System.Drawing.Point(431, 13)
        Me.txtRightValue.Name = "txtRightValue"
        Me.txtRightValue.Size = New System.Drawing.Size(100, 68)
        Me.txtRightValue.TabIndex = 1
        '
        'btnSummarize
        '
        Me.btnSummarize.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.btnSummarize.Location = New System.Drawing.Point(144, 126)
        Me.btnSummarize.Name = "btnSummarize"
        Me.btnSummarize.Size = New System.Drawing.Size(317, 126)
        Me.btnSummarize.TabIndex = 2
        Me.btnSummarize.Text = "Summarize"
        Me.btnSummarize.UseVisualStyleBackColor = True
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.lblSummary.Location = New System.Drawing.Point(27, 293)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(0, 63)
        Me.lblSummary.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 629)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.btnSummarize)
        Me.Controls.Add(Me.txtRightValue)
        Me.Controls.Add(Me.txtLeftValue)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLeftValue As TextBox
    Friend WithEvents txtRightValue As TextBox
    Friend WithEvents btnSummarize As Button
    Friend WithEvents lblSummary As Label
End Class
