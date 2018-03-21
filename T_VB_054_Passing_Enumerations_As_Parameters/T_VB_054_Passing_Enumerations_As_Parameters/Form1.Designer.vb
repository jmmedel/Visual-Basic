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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.listEnumValue = New System.Windows.Forms.ListBox()
        Me.list_Enum_Name = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"baseball", "basketball", "football"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(247, 20)
        Me.ComboBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(98, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Analaynza"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'listEnumValue
        '
        Me.listEnumValue.FormattingEnabled = True
        Me.listEnumValue.ItemHeight = 12
        Me.listEnumValue.Location = New System.Drawing.Point(12, 103)
        Me.listEnumValue.Name = "listEnumValue"
        Me.listEnumValue.Size = New System.Drawing.Size(120, 124)
        Me.listEnumValue.TabIndex = 2
        '
        'list_Enum_Name
        '
        Me.list_Enum_Name.FormattingEnabled = True
        Me.list_Enum_Name.ItemHeight = 12
        Me.list_Enum_Name.Location = New System.Drawing.Point(139, 103)
        Me.list_Enum_Name.Name = "list_Enum_Name"
        Me.list_Enum_Name.Size = New System.Drawing.Size(120, 124)
        Me.list_Enum_Name.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 269)
        Me.Controls.Add(Me.list_Enum_Name)
        Me.Controls.Add(Me.listEnumValue)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents listEnumValue As ListBox
    Friend WithEvents list_Enum_Name As ListBox
End Class
