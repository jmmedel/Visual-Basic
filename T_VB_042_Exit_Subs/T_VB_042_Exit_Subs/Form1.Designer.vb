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
        Me.btmExit = New System.Windows.Forms.Button()
        Me.ListNumber = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btmExit
        '
        Me.btmExit.Location = New System.Drawing.Point(87, 12)
        Me.btmExit.Name = "btmExit"
        Me.btmExit.Size = New System.Drawing.Size(101, 23)
        Me.btmExit.TabIndex = 0
        Me.btmExit.Text = "Exsit sub Demo"
        Me.btmExit.UseVisualStyleBackColor = True
        '
        'ListNumber
        '
        Me.ListNumber.FormattingEnabled = True
        Me.ListNumber.ItemHeight = 12
        Me.ListNumber.Location = New System.Drawing.Point(12, 44)
        Me.ListNumber.Name = "ListNumber"
        Me.ListNumber.Size = New System.Drawing.Size(260, 172)
        Me.ListNumber.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 235)
        Me.Controls.Add(Me.ListNumber)
        Me.Controls.Add(Me.btmExit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btmExit As Button
    Friend WithEvents ListNumber As ListBox
End Class
