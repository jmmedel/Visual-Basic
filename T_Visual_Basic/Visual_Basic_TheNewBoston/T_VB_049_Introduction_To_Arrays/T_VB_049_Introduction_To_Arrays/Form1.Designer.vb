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
        Me.btmArray = New System.Windows.Forms.Button()
        Me.listArray = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btmArray
        '
        Me.btmArray.Location = New System.Drawing.Point(173, 16)
        Me.btmArray.Name = "btmArray"
        Me.btmArray.Size = New System.Drawing.Size(75, 23)
        Me.btmArray.TabIndex = 0
        Me.btmArray.Text = "AddArray"
        Me.btmArray.UseVisualStyleBackColor = True
        '
        'listArray
        '
        Me.listArray.FormattingEnabled = True
        Me.listArray.ItemHeight = 12
        Me.listArray.Location = New System.Drawing.Point(13, 16)
        Me.listArray.Name = "listArray"
        Me.listArray.Size = New System.Drawing.Size(141, 136)
        Me.listArray.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 160)
        Me.Controls.Add(Me.listArray)
        Me.Controls.Add(Me.btmArray)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btmArray As Button
    Friend WithEvents listArray As ListBox
End Class
