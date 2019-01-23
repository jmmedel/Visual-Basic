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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.なわとび犬ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.拍手犬ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.マラカス犬ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.太鼓犬ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ジャンプ犬ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.終了ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(338, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.なわとび犬ToolStripMenuItem, Me.拍手犬ToolStripMenuItem, Me.マラカス犬ToolStripMenuItem, Me.太鼓犬ToolStripMenuItem, Me.ジャンプ犬ToolStripMenuItem, Me.終了ToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "ToolStripDropDownButton1"
        '
        'なわとび犬ToolStripMenuItem
        '
        Me.なわとび犬ToolStripMenuItem.Name = "なわとび犬ToolStripMenuItem"
        Me.なわとび犬ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.なわとび犬ToolStripMenuItem.Text = "なわとび犬"
        '
        '拍手犬ToolStripMenuItem
        '
        Me.拍手犬ToolStripMenuItem.Name = "拍手犬ToolStripMenuItem"
        Me.拍手犬ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.拍手犬ToolStripMenuItem.Text = "拍手犬"
        '
        'マラカス犬ToolStripMenuItem
        '
        Me.マラカス犬ToolStripMenuItem.Name = "マラカス犬ToolStripMenuItem"
        Me.マラカス犬ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.マラカス犬ToolStripMenuItem.Text = "マラカス犬"
        '
        '太鼓犬ToolStripMenuItem
        '
        Me.太鼓犬ToolStripMenuItem.Name = "太鼓犬ToolStripMenuItem"
        Me.太鼓犬ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.太鼓犬ToolStripMenuItem.Text = "太鼓犬"
        '
        'ジャンプ犬ToolStripMenuItem
        '
        Me.ジャンプ犬ToolStripMenuItem.Name = "ジャンプ犬ToolStripMenuItem"
        Me.ジャンプ犬ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ジャンプ犬ToolStripMenuItem.Text = "ジャンプ犬"
        '
        '終了ToolStripMenuItem
        '
        Me.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem"
        Me.終了ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.終了ToolStripMenuItem.Text = "終了"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form1"
        Me.Text = "0H01007　加賀屋　ジャンメデル"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents なわとび犬ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 拍手犬ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents マラカス犬ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 太鼓犬ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ジャンプ犬ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 終了ToolStripMenuItem As ToolStripMenuItem
End Class
