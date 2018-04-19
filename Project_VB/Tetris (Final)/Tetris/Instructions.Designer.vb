<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Instructions))
        Me.Back = New System.Windows.Forms.Button()
        Me.InstrText = New System.Windows.Forms.Label()
        Me.ControlsTable = New System.Windows.Forms.TableLayoutPanel()
        Me.GenInstrLabel = New System.Windows.Forms.Label()
        Me.MathsQnsLabel = New System.Windows.Forms.Label()
        Me.MathsQnsText = New System.Windows.Forms.Label()
        Me.PowerUpsLabel = New System.Windows.Forms.Label()
        Me.PowerUpsText = New System.Windows.Forms.Label()
        Me.ControlsLabel = New System.Windows.Forms.Label()
        Me.UpActLabel = New System.Windows.Forms.Label()
        Me.DownActLabel = New System.Windows.Forms.Label()
        Me.RightActLabel = New System.Windows.Forms.Label()
        Me.RightLabel = New System.Windows.Forms.Label()
        Me.LeftActLabel = New System.Windows.Forms.Label()
        Me.LeftLabel = New System.Windows.Forms.Label()
        Me.DownLabel = New System.Windows.Forms.Label()
        Me.UpLabel = New System.Windows.Forms.Label()
        Me.ActionLabel = New System.Windows.Forms.Label()
        Me.ArrowKeyLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed
        Me.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Back.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(37, 513)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(78, 32)
        Me.Back.TabIndex = 0
        Me.Back.Text = "← Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'InstrText
        '
        Me.InstrText.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.InstrText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InstrText.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstrText.Location = New System.Drawing.Point(37, 41)
        Me.InstrText.Name = "InstrText"
        Me.InstrText.Size = New System.Drawing.Size(506, 83)
        Me.InstrText.TabIndex = 2
        Me.InstrText.Text = resources.GetString("InstrText.Text")
        Me.InstrText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ControlsTable
        '
        Me.ControlsTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ControlsTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ControlsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.ControlsTable.ColumnCount = 2
        Me.ControlsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.7193!))
        Me.ControlsTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.2807!))
        Me.ControlsTable.Location = New System.Drawing.Point(115, 366)
        Me.ControlsTable.Name = "ControlsTable"
        Me.ControlsTable.RowCount = 5
        Me.ControlsTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.91667!))
        Me.ControlsTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.08333!))
        Me.ControlsTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.ControlsTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.ControlsTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.ControlsTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.ControlsTable.Size = New System.Drawing.Size(343, 124)
        Me.ControlsTable.TabIndex = 3
        '
        'GenInstrLabel
        '
        Me.GenInstrLabel.AutoSize = True
        Me.GenInstrLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenInstrLabel.Location = New System.Drawing.Point(208, 12)
        Me.GenInstrLabel.Name = "GenInstrLabel"
        Me.GenInstrLabel.Size = New System.Drawing.Size(168, 23)
        Me.GenInstrLabel.TabIndex = 4
        Me.GenInstrLabel.Text = "General Instructions"
        '
        'MathsQnsLabel
        '
        Me.MathsQnsLabel.AutoSize = True
        Me.MathsQnsLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MathsQnsLabel.Location = New System.Drawing.Point(223, 132)
        Me.MathsQnsLabel.Name = "MathsQnsLabel"
        Me.MathsQnsLabel.Size = New System.Drawing.Size(142, 23)
        Me.MathsQnsLabel.TabIndex = 5
        Me.MathsQnsLabel.Text = "Maths Questions"
        '
        'MathsQnsText
        '
        Me.MathsQnsText.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.MathsQnsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MathsQnsText.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MathsQnsText.Location = New System.Drawing.Point(37, 164)
        Me.MathsQnsText.Name = "MathsQnsText"
        Me.MathsQnsText.Size = New System.Drawing.Size(506, 40)
        Me.MathsQnsText.TabIndex = 6
        Me.MathsQnsText.Text = "A Maths question will appear every time you get a row. By answering it correctly " & _
    "you will get an extra 50 points so you could get up to 150 points per row!"
        Me.MathsQnsText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PowerUpsLabel
        '
        Me.PowerUpsLabel.AutoSize = True
        Me.PowerUpsLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PowerUpsLabel.Location = New System.Drawing.Point(247, 213)
        Me.PowerUpsLabel.Name = "PowerUpsLabel"
        Me.PowerUpsLabel.Size = New System.Drawing.Size(95, 23)
        Me.PowerUpsLabel.TabIndex = 7
        Me.PowerUpsLabel.Text = "Power-Ups"
        '
        'PowerUpsText
        '
        Me.PowerUpsText.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.PowerUpsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PowerUpsText.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PowerUpsText.Location = New System.Drawing.Point(37, 244)
        Me.PowerUpsText.Name = "PowerUpsText"
        Me.PowerUpsText.Size = New System.Drawing.Size(506, 84)
        Me.PowerUpsText.TabIndex = 8
        Me.PowerUpsText.Text = resources.GetString("PowerUpsText.Text")
        Me.PowerUpsText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ControlsLabel
        '
        Me.ControlsLabel.AutoSize = True
        Me.ControlsLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlsLabel.Location = New System.Drawing.Point(252, 339)
        Me.ControlsLabel.Name = "ControlsLabel"
        Me.ControlsLabel.Size = New System.Drawing.Size(75, 23)
        Me.ControlsLabel.TabIndex = 9
        Me.ControlsLabel.Text = "Controls"
        '
        'UpActLabel
        '
        Me.UpActLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.UpActLabel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.UpActLabel.Location = New System.Drawing.Point(247, 464)
        Me.UpActLabel.Name = "UpActLabel"
        Me.UpActLabel.Size = New System.Drawing.Size(206, 22)
        Me.UpActLabel.TabIndex = 23
        Me.UpActLabel.Text = "Shape rotates"
        Me.UpActLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DownActLabel
        '
        Me.DownActLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DownActLabel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.DownActLabel.Location = New System.Drawing.Point(247, 438)
        Me.DownActLabel.Name = "DownActLabel"
        Me.DownActLabel.Size = New System.Drawing.Size(206, 22)
        Me.DownActLabel.TabIndex = 22
        Me.DownActLabel.Text = "Shape moves 1 block down"
        Me.DownActLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RightActLabel
        '
        Me.RightActLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.RightActLabel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.RightActLabel.Location = New System.Drawing.Point(247, 415)
        Me.RightActLabel.Name = "RightActLabel"
        Me.RightActLabel.Size = New System.Drawing.Size(206, 22)
        Me.RightActLabel.TabIndex = 21
        Me.RightActLabel.Text = "Shape moves 1 block right"
        Me.RightActLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RightLabel
        '
        Me.RightLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.RightLabel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.RightLabel.Location = New System.Drawing.Point(118, 415)
        Me.RightLabel.Name = "RightLabel"
        Me.RightLabel.Size = New System.Drawing.Size(122, 22)
        Me.RightLabel.TabIndex = 18
        Me.RightLabel.Text = "Right"
        Me.RightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LeftActLabel
        '
        Me.LeftActLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.LeftActLabel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LeftActLabel.Location = New System.Drawing.Point(247, 390)
        Me.LeftActLabel.Name = "LeftActLabel"
        Me.LeftActLabel.Size = New System.Drawing.Size(206, 22)
        Me.LeftActLabel.TabIndex = 17
        Me.LeftActLabel.Text = "Shape moves 1 block left"
        Me.LeftActLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LeftLabel
        '
        Me.LeftLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.LeftLabel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.LeftLabel.Location = New System.Drawing.Point(118, 390)
        Me.LeftLabel.Name = "LeftLabel"
        Me.LeftLabel.Size = New System.Drawing.Size(122, 22)
        Me.LeftLabel.TabIndex = 16
        Me.LeftLabel.Text = "Left"
        Me.LeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DownLabel
        '
        Me.DownLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.DownLabel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.DownLabel.Location = New System.Drawing.Point(118, 438)
        Me.DownLabel.Name = "DownLabel"
        Me.DownLabel.Size = New System.Drawing.Size(122, 22)
        Me.DownLabel.TabIndex = 19
        Me.DownLabel.Text = "Down"
        Me.DownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UpLabel
        '
        Me.UpLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.UpLabel.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.UpLabel.Location = New System.Drawing.Point(118, 464)
        Me.UpLabel.Name = "UpLabel"
        Me.UpLabel.Size = New System.Drawing.Size(122, 22)
        Me.UpLabel.TabIndex = 20
        Me.UpLabel.Text = "Up"
        Me.UpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActionLabel
        '
        Me.ActionLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ActionLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActionLabel.Location = New System.Drawing.Point(247, 367)
        Me.ActionLabel.Name = "ActionLabel"
        Me.ActionLabel.Size = New System.Drawing.Size(206, 22)
        Me.ActionLabel.TabIndex = 15
        Me.ActionLabel.Text = "Action"
        Me.ActionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ArrowKeyLabel
        '
        Me.ArrowKeyLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.ArrowKeyLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArrowKeyLabel.Location = New System.Drawing.Point(118, 367)
        Me.ArrowKeyLabel.Name = "ArrowKeyLabel"
        Me.ArrowKeyLabel.Size = New System.Drawing.Size(122, 22)
        Me.ArrowKeyLabel.TabIndex = 14
        Me.ArrowKeyLabel.Text = "Arrow Key"
        Me.ArrowKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Instructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(587, 578)
        Me.Controls.Add(Me.UpActLabel)
        Me.Controls.Add(Me.DownActLabel)
        Me.Controls.Add(Me.RightActLabel)
        Me.Controls.Add(Me.RightLabel)
        Me.Controls.Add(Me.LeftActLabel)
        Me.Controls.Add(Me.LeftLabel)
        Me.Controls.Add(Me.DownLabel)
        Me.Controls.Add(Me.UpLabel)
        Me.Controls.Add(Me.ActionLabel)
        Me.Controls.Add(Me.ArrowKeyLabel)
        Me.Controls.Add(Me.ControlsLabel)
        Me.Controls.Add(Me.PowerUpsText)
        Me.Controls.Add(Me.PowerUpsLabel)
        Me.Controls.Add(Me.MathsQnsText)
        Me.Controls.Add(Me.MathsQnsLabel)
        Me.Controls.Add(Me.GenInstrLabel)
        Me.Controls.Add(Me.ControlsTable)
        Me.Controls.Add(Me.InstrText)
        Me.Controls.Add(Me.Back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Instructions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instructions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents InstrText As System.Windows.Forms.Label
    Friend WithEvents ControlsTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GenInstrLabel As System.Windows.Forms.Label
    Friend WithEvents MathsQnsLabel As System.Windows.Forms.Label
    Friend WithEvents MathsQnsText As System.Windows.Forms.Label
    Friend WithEvents PowerUpsLabel As System.Windows.Forms.Label
    Friend WithEvents PowerUpsText As System.Windows.Forms.Label
    Friend WithEvents ControlsLabel As System.Windows.Forms.Label
    Friend WithEvents UpActLabel As System.Windows.Forms.Label
    Friend WithEvents DownActLabel As System.Windows.Forms.Label
    Friend WithEvents RightActLabel As System.Windows.Forms.Label
    Friend WithEvents RightLabel As System.Windows.Forms.Label
    Friend WithEvents LeftActLabel As System.Windows.Forms.Label
    Friend WithEvents LeftLabel As System.Windows.Forms.Label
    Friend WithEvents DownLabel As System.Windows.Forms.Label
    Friend WithEvents UpLabel As System.Windows.Forms.Label
    Friend WithEvents ActionLabel As System.Windows.Forms.Label
    Friend WithEvents ArrowKeyLabel As System.Windows.Forms.Label
End Class
