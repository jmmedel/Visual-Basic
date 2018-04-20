<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tetris
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tetris))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NextShape = New System.Windows.Forms.PictureBox()
        Me.RowsLabel = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.HighScoreLabel = New System.Windows.Forms.Label()
        Me.Speaker = New System.Windows.Forms.PictureBox()
        Me.QuestionMark = New System.Windows.Forms.PictureBox()
        Me.ExitLabel = New System.Windows.Forms.Label()
        Me.DifficultyOptions = New System.Windows.Forms.Label()
        Me.Difficulty1 = New System.Windows.Forms.Label()
        Me.Difficulty2 = New System.Windows.Forms.Label()
        Me.Difficulty3 = New System.Windows.Forms.Label()
        Me.Difficulty4 = New System.Windows.Forms.Label()
        Me.Difficulty5 = New System.Windows.Forms.Label()
        Me.NextShapeLabel = New System.Windows.Forms.Label()
        Me.PowerUpsLabel = New System.Windows.Forms.Label()
        Me.SlowBlocks = New System.Windows.Forms.Label()
        Me.RemoveRows = New System.Windows.Forms.Label()
        Me.Magnet = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GamePaused = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.NextShape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Speaker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionMark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'NextShape
        '
        Me.NextShape.BackColor = System.Drawing.Color.Transparent
        Me.NextShape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.NextShape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NextShape.ErrorImage = Nothing
        Me.NextShape.InitialImage = Nothing
        Me.NextShape.Location = New System.Drawing.Point(704, 41)
        Me.NextShape.Name = "NextShape"
        Me.NextShape.Size = New System.Drawing.Size(209, 185)
        Me.NextShape.TabIndex = 22
        Me.NextShape.TabStop = False
        '
        'RowsLabel
        '
        Me.RowsLabel.BackColor = System.Drawing.Color.Transparent
        Me.RowsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RowsLabel.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RowsLabel.Location = New System.Drawing.Point(489, 224)
        Me.RowsLabel.Name = "RowsLabel"
        Me.RowsLabel.Size = New System.Drawing.Size(209, 65)
        Me.RowsLabel.TabIndex = 26
        Me.RowsLabel.Text = "Rows:      0"
        Me.RowsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ScoreLabel
        '
        Me.ScoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.ScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ScoreLabel.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLabel.Location = New System.Drawing.Point(489, 153)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(209, 65)
        Me.ScoreLabel.TabIndex = 27
        Me.ScoreLabel.Text = "Score:      0"
        Me.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HighScoreLabel
        '
        Me.HighScoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.HighScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HighScoreLabel.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighScoreLabel.Location = New System.Drawing.Point(489, 81)
        Me.HighScoreLabel.Name = "HighScoreLabel"
        Me.HighScoreLabel.Size = New System.Drawing.Size(209, 65)
        Me.HighScoreLabel.TabIndex = 28
        Me.HighScoreLabel.Text = "Hi-Score: 0"
        Me.HighScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Speaker
        '
        Me.Speaker.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Speaker.BackgroundImage = CType(resources.GetObject("Speaker.BackgroundImage"), System.Drawing.Image)
        Me.Speaker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Speaker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Speaker.Location = New System.Drawing.Point(716, 342)
        Me.Speaker.Name = "Speaker"
        Me.Speaker.Size = New System.Drawing.Size(94, 65)
        Me.Speaker.TabIndex = 29
        Me.Speaker.TabStop = False
        '
        'QuestionMark
        '
        Me.QuestionMark.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.QuestionMark.BackgroundImage = CType(resources.GetObject("QuestionMark.BackgroundImage"), System.Drawing.Image)
        Me.QuestionMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.QuestionMark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QuestionMark.Location = New System.Drawing.Point(819, 342)
        Me.QuestionMark.Name = "QuestionMark"
        Me.QuestionMark.Size = New System.Drawing.Size(94, 65)
        Me.QuestionMark.TabIndex = 30
        Me.QuestionMark.TabStop = False
        '
        'ExitLabel
        '
        Me.ExitLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExitLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ExitLabel.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitLabel.Location = New System.Drawing.Point(704, 279)
        Me.ExitLabel.Name = "ExitLabel"
        Me.ExitLabel.Size = New System.Drawing.Size(209, 44)
        Me.ExitLabel.TabIndex = 31
        Me.ExitLabel.Text = "Exit"
        Me.ExitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DifficultyOptions
        '
        Me.DifficultyOptions.BackColor = System.Drawing.Color.Transparent
        Me.DifficultyOptions.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DifficultyOptions.Location = New System.Drawing.Point(540, 2)
        Me.DifficultyOptions.Name = "DifficultyOptions"
        Me.DifficultyOptions.Size = New System.Drawing.Size(113, 33)
        Me.DifficultyOptions.TabIndex = 32
        Me.DifficultyOptions.Text = "Difficulty"
        Me.DifficultyOptions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Difficulty1
        '
        Me.Difficulty1.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Difficulty1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Difficulty1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Difficulty1.Location = New System.Drawing.Point(489, 41)
        Me.Difficulty1.Name = "Difficulty1"
        Me.Difficulty1.Size = New System.Drawing.Size(37, 34)
        Me.Difficulty1.TabIndex = 33
        Me.Difficulty1.Text = "1"
        Me.Difficulty1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Difficulty2
        '
        Me.Difficulty2.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Difficulty2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Difficulty2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Difficulty2.Location = New System.Drawing.Point(532, 41)
        Me.Difficulty2.Name = "Difficulty2"
        Me.Difficulty2.Size = New System.Drawing.Size(37, 34)
        Me.Difficulty2.TabIndex = 34
        Me.Difficulty2.Text = "2"
        Me.Difficulty2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Difficulty3
        '
        Me.Difficulty3.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Difficulty3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Difficulty3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Difficulty3.Location = New System.Drawing.Point(575, 41)
        Me.Difficulty3.Name = "Difficulty3"
        Me.Difficulty3.Size = New System.Drawing.Size(37, 34)
        Me.Difficulty3.TabIndex = 35
        Me.Difficulty3.Text = "3"
        Me.Difficulty3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Difficulty4
        '
        Me.Difficulty4.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Difficulty4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Difficulty4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Difficulty4.Location = New System.Drawing.Point(618, 41)
        Me.Difficulty4.Name = "Difficulty4"
        Me.Difficulty4.Size = New System.Drawing.Size(37, 34)
        Me.Difficulty4.TabIndex = 36
        Me.Difficulty4.Text = "4"
        Me.Difficulty4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Difficulty5
        '
        Me.Difficulty5.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Difficulty5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Difficulty5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Difficulty5.Location = New System.Drawing.Point(661, 41)
        Me.Difficulty5.Name = "Difficulty5"
        Me.Difficulty5.Size = New System.Drawing.Size(37, 34)
        Me.Difficulty5.TabIndex = 37
        Me.Difficulty5.Text = "5"
        Me.Difficulty5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NextShapeLabel
        '
        Me.NextShapeLabel.BackColor = System.Drawing.Color.Transparent
        Me.NextShapeLabel.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextShapeLabel.Location = New System.Drawing.Point(734, 46)
        Me.NextShapeLabel.Name = "NextShapeLabel"
        Me.NextShapeLabel.Size = New System.Drawing.Size(156, 29)
        Me.NextShapeLabel.TabIndex = 38
        Me.NextShapeLabel.Text = "Next Shape"
        Me.NextShapeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PowerUpsLabel
        '
        Me.PowerUpsLabel.AutoSize = True
        Me.PowerUpsLabel.BackColor = System.Drawing.Color.Transparent
        Me.PowerUpsLabel.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PowerUpsLabel.Location = New System.Drawing.Point(531, 289)
        Me.PowerUpsLabel.Name = "PowerUpsLabel"
        Me.PowerUpsLabel.Size = New System.Drawing.Size(118, 29)
        Me.PowerUpsLabel.TabIndex = 40
        Me.PowerUpsLabel.Text = "Power-Ups"
        '
        'SlowBlocks
        '
        Me.SlowBlocks.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SlowBlocks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SlowBlocks.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SlowBlocks.Location = New System.Drawing.Point(488, 317)
        Me.SlowBlocks.Name = "SlowBlocks"
        Me.SlowBlocks.Size = New System.Drawing.Size(210, 25)
        Me.SlowBlocks.TabIndex = 41
        Me.SlowBlocks.Text = "Slow Shapes"
        Me.SlowBlocks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RemoveRows
        '
        Me.RemoveRows.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RemoveRows.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RemoveRows.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveRows.Location = New System.Drawing.Point(488, 350)
        Me.RemoveRows.Name = "RemoveRows"
        Me.RemoveRows.Size = New System.Drawing.Size(210, 25)
        Me.RemoveRows.TabIndex = 42
        Me.RemoveRows.Text = "Remove Rows"
        Me.RemoveRows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Magnet
        '
        Me.Magnet.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Magnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Magnet.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Magnet.Location = New System.Drawing.Point(488, 382)
        Me.Magnet.Name = "Magnet"
        Me.Magnet.Size = New System.Drawing.Size(210, 25)
        Me.Magnet.TabIndex = 43
        Me.Magnet.Text = "Magnet"
        Me.Magnet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(671, 317)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 25)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(671, 350)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 25)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(671, 382)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 25)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "0"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GamePaused
        '
        Me.GamePaused.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GamePaused.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GamePaused.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GamePaused.Location = New System.Drawing.Point(97, 266)
        Me.GamePaused.Name = "GamePaused"
        Me.GamePaused.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GamePaused.Size = New System.Drawing.Size(288, 149)
        Me.GamePaused.TabIndex = 48
        Me.GamePaused.Text = "                                                                       Game Pause" &
    "d                                                               Press 'P' or cli" &
    "ck this message to continue playing."
        Me.GamePaused.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.GamePaused.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(37, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(405, 607)
        Me.Panel1.TabIndex = 49
        '
        'Tetris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(925, 643)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GamePaused)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Magnet)
        Me.Controls.Add(Me.RemoveRows)
        Me.Controls.Add(Me.SlowBlocks)
        Me.Controls.Add(Me.PowerUpsLabel)
        Me.Controls.Add(Me.NextShapeLabel)
        Me.Controls.Add(Me.Difficulty5)
        Me.Controls.Add(Me.Difficulty4)
        Me.Controls.Add(Me.Difficulty3)
        Me.Controls.Add(Me.Difficulty2)
        Me.Controls.Add(Me.Difficulty1)
        Me.Controls.Add(Me.DifficultyOptions)
        Me.Controls.Add(Me.ExitLabel)
        Me.Controls.Add(Me.QuestionMark)
        Me.Controls.Add(Me.Speaker)
        Me.Controls.Add(Me.HighScoreLabel)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.RowsLabel)
        Me.Controls.Add(Me.NextShape)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Tetris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tetris"
        CType(Me.NextShape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Speaker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionMark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents NextShape As System.Windows.Forms.PictureBox
    Friend WithEvents RowsLabel As System.Windows.Forms.Label
    Friend WithEvents ScoreLabel As System.Windows.Forms.Label
    Friend WithEvents HighScoreLabel As System.Windows.Forms.Label
    Friend WithEvents Speaker As System.Windows.Forms.PictureBox
    Friend WithEvents QuestionMark As System.Windows.Forms.PictureBox
    Friend WithEvents ExitLabel As System.Windows.Forms.Label
    Friend WithEvents DifficultyOptions As System.Windows.Forms.Label
    Friend WithEvents Difficulty1 As System.Windows.Forms.Label
    Friend WithEvents Difficulty2 As System.Windows.Forms.Label
    Friend WithEvents Difficulty3 As System.Windows.Forms.Label
    Friend WithEvents Difficulty4 As System.Windows.Forms.Label
    Friend WithEvents Difficulty5 As System.Windows.Forms.Label
    Friend WithEvents NextShapeLabel As System.Windows.Forms.Label
    Friend WithEvents PowerUpsLabel As System.Windows.Forms.Label
    Friend WithEvents SlowBlocks As System.Windows.Forms.Label
    Friend WithEvents RemoveRows As System.Windows.Forms.Label
    Friend WithEvents Magnet As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GamePaused As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
