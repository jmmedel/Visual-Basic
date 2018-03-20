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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btmadd = New System.Windows.Forms.Button()
        Me.btmsubtract = New System.Windows.Forms.Button()
        Me.btmdivide = New System.Windows.Forms.Button()
        Me.btmmultiply = New System.Windows.Forms.Button()
        Me.btmModules = New System.Windows.Forms.Button()
        Me.btmPI = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(193, 19)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 94)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(193, 19)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 140)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(193, 19)
        Me.TextBox3.TabIndex = 2
        '
        'btmadd
        '
        Me.btmadd.Location = New System.Drawing.Point(28, 194)
        Me.btmadd.Name = "btmadd"
        Me.btmadd.Size = New System.Drawing.Size(75, 23)
        Me.btmadd.TabIndex = 3
        Me.btmadd.Text = "Add"
        Me.btmadd.UseVisualStyleBackColor = True
        '
        'btmsubtract
        '
        Me.btmsubtract.Location = New System.Drawing.Point(126, 194)
        Me.btmsubtract.Name = "btmsubtract"
        Me.btmsubtract.Size = New System.Drawing.Size(75, 23)
        Me.btmsubtract.TabIndex = 4
        Me.btmsubtract.Text = "Subtract"
        Me.btmsubtract.UseVisualStyleBackColor = True
        '
        'btmdivide
        '
        Me.btmdivide.Location = New System.Drawing.Point(28, 239)
        Me.btmdivide.Name = "btmdivide"
        Me.btmdivide.Size = New System.Drawing.Size(75, 23)
        Me.btmdivide.TabIndex = 5
        Me.btmdivide.Text = "Divide"
        Me.btmdivide.UseVisualStyleBackColor = True
        '
        'btmmultiply
        '
        Me.btmmultiply.Location = New System.Drawing.Point(126, 239)
        Me.btmmultiply.Name = "btmmultiply"
        Me.btmmultiply.Size = New System.Drawing.Size(75, 23)
        Me.btmmultiply.TabIndex = 6
        Me.btmmultiply.Text = "Multply"
        Me.btmmultiply.UseVisualStyleBackColor = True
        '
        'btmModules
        '
        Me.btmModules.Location = New System.Drawing.Point(28, 281)
        Me.btmModules.Name = "btmModules"
        Me.btmModules.Size = New System.Drawing.Size(75, 23)
        Me.btmModules.TabIndex = 7
        Me.btmModules.Text = "Modulus"
        Me.btmModules.UseVisualStyleBackColor = True
        '
        'btmPI
        '
        Me.btmPI.Location = New System.Drawing.Point(126, 281)
        Me.btmPI.Name = "btmPI"
        Me.btmPI.Size = New System.Drawing.Size(75, 23)
        Me.btmPI.TabIndex = 8
        Me.btmPI.Text = "PI"
        Me.btmPI.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "First_Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 12)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Second_number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 12)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Answer"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 316)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btmPI)
        Me.Controls.Add(Me.btmModules)
        Me.Controls.Add(Me.btmmultiply)
        Me.Controls.Add(Me.btmdivide)
        Me.Controls.Add(Me.btmsubtract)
        Me.Controls.Add(Me.btmadd)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btmadd As Button
    Friend WithEvents btmsubtract As Button
    Friend WithEvents btmdivide As Button
    Friend WithEvents btmmultiply As Button
    Friend WithEvents btmModules As Button
    Friend WithEvents btmPI As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
