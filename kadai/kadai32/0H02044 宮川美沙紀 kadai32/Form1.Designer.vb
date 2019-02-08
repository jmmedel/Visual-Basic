<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.塗りつぶし色ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.赤ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.緑ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.黒ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.紫ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.終了ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(47, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(423, 274)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("UD デジタル 教科書体 NK-R", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.Location = New System.Drawing.Point(187, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "消去"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("UD デジタル 教科書体 NK-R", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.塗りつぶし色ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(521, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '塗りつぶし色ToolStripMenuItem
        '
        Me.塗りつぶし色ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.赤ToolStripMenuItem, Me.緑ToolStripMenuItem, Me.黒ToolStripMenuItem, Me.紫ToolStripMenuItem, Me.ToolStripSeparator1, Me.終了ToolStripMenuItem})
        Me.塗りつぶし色ToolStripMenuItem.Name = "塗りつぶし色ToolStripMenuItem"
        Me.塗りつぶし色ToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.塗りつぶし色ToolStripMenuItem.Text = "塗りつぶし色"
        '
        '赤ToolStripMenuItem
        '
        Me.赤ToolStripMenuItem.Name = "赤ToolStripMenuItem"
        Me.赤ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.赤ToolStripMenuItem.Text = "赤"
        '
        '緑ToolStripMenuItem
        '
        Me.緑ToolStripMenuItem.Name = "緑ToolStripMenuItem"
        Me.緑ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.緑ToolStripMenuItem.Text = "緑"
        '
        '黒ToolStripMenuItem
        '
        Me.黒ToolStripMenuItem.Name = "黒ToolStripMenuItem"
        Me.黒ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.黒ToolStripMenuItem.Text = "黒"
        '
        '紫ToolStripMenuItem
        '
        Me.紫ToolStripMenuItem.Name = "紫ToolStripMenuItem"
        Me.紫ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.紫ToolStripMenuItem.Text = "紫"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
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
        Me.ClientSize = New System.Drawing.Size(521, 449)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "メニュー"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 塗りつぶし色ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 赤ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 緑ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 黒ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 紫ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 終了ToolStripMenuItem As ToolStripMenuItem
End Class
