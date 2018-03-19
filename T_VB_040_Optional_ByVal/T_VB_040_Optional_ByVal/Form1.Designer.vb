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
        Me.txttiitle = New System.Windows.Forms.TextBox()
        Me.textmesg = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txttiitle
        '
        Me.txttiitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txttiitle.Location = New System.Drawing.Point(0, 0)
        Me.txttiitle.Name = "txttiitle"
        Me.txttiitle.Size = New System.Drawing.Size(284, 19)
        Me.txttiitle.TabIndex = 0
        '
        'textmesg
        '
        Me.textmesg.Location = New System.Drawing.Point(0, 26)
        Me.textmesg.Name = "textmesg"
        Me.textmesg.Size = New System.Drawing.Size(284, 19)
        Me.textmesg.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(86, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Show_Mesage"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 180)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textmesg)
        Me.Controls.Add(Me.txttiitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txttiitle As TextBox
    Friend WithEvents textmesg As TextBox
    Friend WithEvents Button1 As Button
End Class
