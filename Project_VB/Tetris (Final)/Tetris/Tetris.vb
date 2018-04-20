Imports System.IO

Public Class Tetris

    Public FallingBlocks, NonFallingBlocks, AllBlocks, TempList, FlashList As New List(Of PictureBox)
    Public NewBlock As New PictureBox
    Public TopLoc, LeftLoc, NoOfBlocks, NumberOfFullRows, PrevHighScore, QuestionsCorrect, Timer1Counter, Score As Integer
    Public IsShapeFalling, PowerUp, DifficultyX2, ShowMathsQuestions As Boolean
    Public HighestRight, CentreLeft, CentreTop, HighestLeft As Double
    Public Difficulty As Integer = 45
    Public AnsweredQuestion As Boolean = False
    Public EasyQns(65) As String
    Public NormalQns(65) As String
    Public HardQns(65) As String
    Public VeryHardQns(36) As String
    Public VHardQn As Boolean = False

    Dim RotateBlocks, OldBlocks As New List(Of PictureBox)
    Dim NewBlockRotated As New PictureBox
    Dim Count As Integer = 19
    Dim DifficultyValue, SlowShapesValue, PowerUpsUsed, BlocksNotMoved, Timer3Counter, PowerUpRandom, RandomNumber, Row(20), PrevRandom, NewRandom, RowTopPosition, Rows, LeftPos, TopPos, CurrentShapeNumber, temp, Timer2Counter, TempHighScore, TotalHighScore As Integer
    Dim MagnetMoveLeft, Paused, CanMoveDown, Delete, MoveDown, CanRotate, AddPowerUp, ClickBlocksPowerup, RemoveRowsLabelClick As Boolean
    Dim MoveShapeRight = True, MoveShapeLeft As Boolean = True
    Dim Points1000 As Integer = 1000
    Dim Shape As String
    Dim R As New Random

    Dim Delete8Rows As Boolean = False
    'Timmer2'
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Timer2Counter += 1
        Select Case Timer2Counter
            Case 2
                If MainMenu.SoundPaused = False Then
                    MainMenu.mciSendString("close " & MainMenu.RowMusicAlias, CStr(0), 0, 0)
                    MainMenu.mciSendString("Open " & Chr(34) & MainMenu.RowMusicPath & Chr(34) & " alias " & MainMenu.RowMusicAlias, CStr(0), 0, 0)
                    MainMenu.mciSendString("play " & MainMenu.RowMusicAlias, CStr(0), 0, 0)
                End If
            Case 8
                For Each Block As PictureBox In FlashList
                    Controls.Remove(Block)
                Next
                Panel1.SendToBack()
            Case 16
                For Each Block As PictureBox In FlashList
                    Controls.Add(Block)
                Next
                Panel1.SendToBack()
            Case 24
                For Each Block As PictureBox In FlashList
                    Controls.Remove(Block)
                Next
                Panel1.SendToBack()
            Case 32
                For Each Block As PictureBox In FlashList
                    Controls.Add(Block)
                Next
                Panel1.SendToBack()
            Case 40
                If RemoveRowsLabelClick = True Then
                    RemoveRowsPowerUp()
                End If
                If Delete8Rows = True Then
                    Remove8Rows()
                End If
                Panel1.SendToBack()
        End Select

    End Sub

    'Timer1'
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        LosingScreen.FromMainMenu = False

        If MoveDown = True Then
            If temp = 0 Then
                temp = Timer1Counter
            End If
            If Timer1Counter - temp > 2 Then

                CanMoveDown = True

                For Each FallingBlock As PictureBox In FallingBlocks
                    ' i change the value to get the falling block to change > 759 '
                    If FallingBlock.Top > 759 Then CanMoveDown = False
                    For Each NonFallingBlock As PictureBox In NonFallingBlocks
                        If FallingBlock.Top + 40 = NonFallingBlock.Top And FallingBlock.Left = NonFallingBlock.Left Then CanMoveDown = False
                    Next
                Next

                If CanMoveDown = True Then
                    MoveShapeDown()
                End If

                temp = 0
            End If
        End If

        Timer1Counter += 1

        If IsShapeFalling = False Then
            CheckIfFullRow()
            EditLists()
            CurrentShapeNumber = PrevRandom
            GetNewShape()
            Panel1.SendToBack()
            GetRandomNumber()
        End If

        CanShapeMove()

        CheckIfEndOfGame()

        If IsShapeFalling = True And Timer1Counter Mod Difficulty = 0 Then
            TimerMoveShapeDown()
        End If

        If Delete = True Then
            MoveDown = False

            Timer2.Enabled = True
            Delete = False

            If ShowMathsQuestions = True Then
                VHardQn = False
                MathsQuestions.Show()
                Timer1.Enabled = False
                Timer2.Enabled = False
            End If

        End If

        If Timer2Counter > 40 Then
            DeleteRow()
        End If

    End Sub

    'This is how to get the high score'
    Sub GetHighScore()

        Dim SR As New StreamReader(MainMenu.Locations & "UserData.txt")
        Dim FileName As String
        Dim FileScore As Integer

        While Not SR.EndOfStream
            FileName = SR.ReadLine
            SR.ReadLine()
            FileScore = SR.ReadLine

            If FileName = MainMenu.UserName Then
                TotalHighScore = FileScore
            End If

        End While

        PrevHighScore = TotalHighScore

        SR.Close()
        SR.Dispose()

    End Sub

    'Gameload'
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If MainMenu.SoundPaused = False Then
            Speaker.BackgroundImage = Image.FromFile(MainMenu.Locations & "Speaker.png")
        Else
            Speaker.BackgroundImage = Image.FromFile(MainMenu.Locations & "SpeakerMute.png")
        End If

        Me.BackColor = MainMenu.TetrisBackColour

        For Each Component In Controls
            Component.ForeColor = MainMenu.FontColour
        Next

        HighScoreLabel.BackColor = MainMenu.TetrisComponentBackColour
        ScoreLabel.BackColor = MainMenu.TetrisComponentBackColour
        RowsLabel.BackColor = MainMenu.TetrisComponentBackColour
        NextShapeLabel.BackColor = MainMenu.TetrisComponentBackColour
        Panel1.BackColor = MainMenu.TetrisComponentBackColour
        NextShape.BackColor = MainMenu.TetrisComponentBackColour

        Difficulty1.BackColor = MainMenu.ButtonColour
        Difficulty2.BackColor = MainMenu.ButtonColour
        Difficulty3.BackColor = MainMenu.ButtonColour
        Difficulty4.BackColor = MainMenu.ButtonColour
        Difficulty5.BackColor = MainMenu.ButtonColour

        GamePaused.BackColor = MainMenu.ButtonColour
        SlowBlocks.BackColor = MainMenu.ButtonColour
        RemoveRows.BackColor = MainMenu.ButtonColour
        Magnet.BackColor = MainMenu.ButtonColour
        Speaker.BackColor = MainMenu.ButtonColour
        QuestionMark.BackColor = MainMenu.ButtonColour
        ExitLabel.BackColor = MainMenu.ButtonColour
        Label1.BackColor = MainMenu.ButtonColour
        Label2.BackColor = MainMenu.ButtonColour
        Label3.BackColor = MainMenu.ButtonColour

        If MainMenu.BackgroundImageLoc <> "" Then
            Me.BackgroundImage = Image.FromFile(MainMenu.BackgroundImageLoc)
            If MainMenu.BackgroundImageLoc = MainMenu.Locations & "TetrisTheme.png" Then
                NextShape.BorderStyle = BorderStyle.None
                RowsLabel.BorderStyle = BorderStyle.None
                ScoreLabel.BorderStyle = BorderStyle.None
                HighScoreLabel.BorderStyle = BorderStyle.None
            End If
        End If

        TotalHighScore = 0
        GetHighScore()
        HighScoreLabel.Text = "Hi-Score: " & TotalHighScore

        LosingScreen.FromMainMenu = False

        Dim FileLineNo As Integer = 0

        Dim SREasy As New StreamReader(MainMenu.Locations & "Maths Questions\Easy.txt")
        While Not SREasy.EndOfStream
            EasyQns(FileLineNo) = SREasy.ReadLine
            FileLineNo += 1
        End While
        SREasy.Close()
        SREasy.Dispose()
        FileLineNo = 0

        Dim SRNormal As New StreamReader(MainMenu.Locations & "Maths Questions\Normal.txt")
        While Not SRNormal.EndOfStream
            NormalQns(FileLineNo) = SRNormal.ReadLine
            FileLineNo += 1
        End While
        SRNormal.Close()
        SRNormal.Dispose()
        FileLineNo = 0

        Dim SRHard As New StreamReader(MainMenu.Locations & "Maths Questions\Hard.txt")
        While Not SRHard.EndOfStream
            HardQns(FileLineNo) = SRHard.ReadLine
            FileLineNo += 1
        End While
        SRHard.Close()
        SRHard.Dispose()
        FileLineNo = 0

        Dim SRVeryHard As New StreamReader(MainMenu.Locations & "Maths Questions\Very Hard.txt")
        While Not SRVeryHard.EndOfStream
            VeryHardQns(FileLineNo) = SRVeryHard.ReadLine
            FileLineNo += 1
        End While
        SRVeryHard.Close()
        SRVeryHard.Dispose()
        FileLineNo = 0

        DifficultyValue = Playsettings.DifficultyValue

        Select Case DifficultyValue
            Case 1
                Difficulty = 75
            Case 2
                Difficulty = 60
            Case 3
                Difficulty = 45
            Case 4
                Difficulty = 30
            Case 5
                Difficulty = 15
            Case Else
        End Select

        PrevRandom = R.Next(1, 14)
        NewRandom = R.Next(1, 14)
        GetShapeImage()

        DoubleBuffered = True
    End Sub

    'This is how to get new shape'
    Sub GetNewShape()

        Do Until NewRandom <> PrevRandom
            'I change it to get it test the default is 14'
            NewRandom = R.Next(1, 7)
        Loop

        Select Case PrevRandom
            Case 1
                ShapeJ()
            Case 2
                ShapeL()
            Case 3
                ShapeI()
            Case 4
                ShapeS()
            Case 5
                ShapeZ()
            Case 6
                ShapeT()
            Case 7
                ShapeO()
            'This is the easy mode '
            Case 8
                ShapeX()
            Case 9
                ShapeW()
            Case 10
                ShapeY()
            Case 11
                ShapeYF()
            Case 12
                Shaper()
            Case 13
                ShaperF()
        End Select

        GetShapeImage()

        PrevRandom = NewRandom
    End Sub
    ' this is where is the falling shape to go down '
    Sub CanShapeMove()
        For Each FallingBlock As PictureBox In FallingBlocks
            'The default is 759'
            If FallingBlock.Top > 560 Then IsShapeFalling = False
            For Each NonFallingBlock As PictureBox In NonFallingBlocks
                If FallingBlock.Top = NonFallingBlock.Top And FallingBlock.Left + 40 = NonFallingBlock.Left Then MoveShapeRight = False
                If FallingBlock.Top = NonFallingBlock.Top And FallingBlock.Left = NonFallingBlock.Left + 40 Then MoveShapeLeft = False
                If FallingBlock.Top + 40 = NonFallingBlock.Top And FallingBlock.Left = NonFallingBlock.Left Then IsShapeFalling = False
            Next
        Next
    End Sub
    'Endgame'
    Sub EndGame()
        Timer1.Stop()

        If Score > TotalHighScore Then
            Dim FileName As String
            Dim FileScore As Integer
            Dim FilePassword As String
            Dim SR As New StreamReader(MainMenu.Locations & "UserData.txt")
            Dim SW As New StreamWriter(MainMenu.Locations & "TempUserData.txt", True)

            While Not SR.EndOfStream

                FileName = SR.ReadLine()
                FilePassword = SR.ReadLine()
                FileScore = SR.ReadLine()

                SW.WriteLine(FileName)
                SW.WriteLine(FilePassword)
                If MainMenu.UserName <> FileName Then
                    SW.WriteLine(FileScore)
                Else
                    SW.WriteLine(Score)
                End If

            End While

            SW.Close()
            SR.Close()

            File.Delete(MainMenu.Locations & "UserData.txt")
            File.Copy(MainMenu.Locations & "TempUserData.txt", MainMenu.Locations & "UserData.txt")
            File.Delete(MainMenu.Locations & "TempUserData.txt")

            SW.Dispose()
            SW.Dispose()
        End If

        LosingScreen.UsersPrevHighScore = PrevHighScore
        LosingScreen.HighScoreLabel.Text = TotalHighScore
        LosingScreen.FinalScoreLabel.Text = Score
        LosingScreen.RowsLabel.Text = Rows
        LosingScreen.PowerUpsUsedLabel.Text = PowerUpsUsed
        LosingScreen.QuestionsCorrectLabel.Text = QuestionsCorrect
        LosingScreen.Show()
        Me.Close()
    End Sub

    Sub Remove8Rows()

        Delete8Rows = False
        Timer2Counter = 0

        For x = 0 To 8
            Row(x) = 0
        Next

        For Each Block As PictureBox In NonFallingBlocks
            If Block.Top < 320 Then
                Block.Dispose()
            End If
        Next
        For Each Block As PictureBox In AllBlocks
            If Block.Top < 320 Then
                FlashList.Remove(Block)
                NonFallingBlocks.Remove(Block)
            End If
        Next

        Timer2.Stop()
        Timer2.Enabled = False

        Timer1.Enabled = True
    End Sub

    Sub Add8RowsToFlashList()
        If MainMenu.SoundPaused = False Then
            MainMenu.mciSendString("close " & MainMenu.RowMusicAlias, CStr(0), 0, 0)
            MainMenu.mciSendString("Open " & Chr(34) & MainMenu.RowMusicPath & Chr(34) & " alias " & MainMenu.RowMusicAlias, CStr(0), 0, 0)
            MainMenu.mciSendString("play " & MainMenu.RowMusicAlias, CStr(0), 0, 0)
        End If

        Delete8Rows = True
        EditLists()
        For Each Block As PictureBox In NonFallingBlocks
            'Block default is 320'
            If Block.Top < 320 Then FlashList.Add(Block)
        Next
        Timer2Counter = 0
        Timer2.Start()
        Timer2.Enabled = True
    End Sub

    'CheckofnendofGame'
    Sub CheckIfEndOfGame()
        For Each Block As PictureBox In NonFallingBlocks
            If Block.Top < 1 And IsShapeFalling = False Then
                If ShowMathsQuestions = True Then
                    VHardQn = True
                    MoveDown = False
                    MathsQuestions.Show()
                Else
                    EndGame()
                End If
                Timer1.Enabled = False
                Timer2.Enabled = False
            End If
        Next
    End Sub

    Sub EditLists()
        For Each Block As PictureBox In FallingBlocks
            NonFallingBlocks.Add(Block)
        Next

        FallingBlocks.Clear()
    End Sub

    Sub TimerMoveShapeDown()
        For Each Block As PictureBox In FallingBlocks
            Block.Top = Block.Top + 40
        Next
        CentreTop += 40
    End Sub

    Private Sub UnControlShapes(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.Down
                MoveDown = False
        End Select
    End Sub

    Private Sub ControlShapes(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.P Then TogglePauseGame()

        If Paused = False Then
            Select Case e.KeyCode
                Case Keys.Right
                    If HighestRight < 399 And MoveShapeRight = True Then
                        HighestRight += 40
                        HighestLeft += 40
                        CentreLeft += 40
                        For Each Block As PictureBox In FallingBlocks
                            Block.Left += 40
                        Next
                    End If
                Case Keys.Left
                    If HighestLeft > 40 And MoveShapeLeft = True Then
                        HighestLeft -= 40
                        HighestRight -= 40
                        CentreLeft -= 40
                        For Each Block As PictureBox In FallingBlocks
                            Block.Left -= 40
                        Next
                    End If
                Case Keys.Down
                    MoveDown = True
                Case Keys.Up
                    If CurrentShapeNumber <> 7 And CurrentShapeNumber <> 8 Then
                        CanRotate = True

                        For Each FallingBlock As PictureBox In FallingBlocks
                            NewBlockRotated = New PictureBox
                            NewBlockRotated.Width = 40
                            NewBlockRotated.Height = 40
                            NewBlockRotated.Top = FallingBlock.Top
                            NewBlockRotated.Left = FallingBlock.Left
                            Controls.Add(NewBlockRotated)
                            RotateBlocks.Add(NewBlockRotated)
                        Next

                        For Each Block As PictureBox In RotateBlocks
                            LeftPos = (Block.Left - CentreLeft) / 40
                            TopPos = (Block.Top - CentreTop) / 40

                            For x = 1 To FallingBlocks.Count
                                Block.Left = -TopPos * 40 + CentreLeft
                                Block.Top = LeftPos * 40 + CentreTop
                            Next
                        Next

                        For Each Block As PictureBox In RotateBlocks
                            For Each NonFallingBlock As PictureBox In NonFallingBlocks
                                If Block.Top = NonFallingBlock.Top And Block.Left = NonFallingBlock.Left Then CanRotate = False
                            Next

                            If Block.Left > 400 Or Block.Left < 40 Then
                                CanRotate = False
                            End If

                            OldBlocks.Add(Block)
                        Next

                        For Each Block As PictureBox In OldBlocks
                            RotateBlocks.Remove(Block)
                            Block.Dispose()
                        Next

                        If CanRotate = True Then
                            HighestRight = 0
                            HighestLeft = 500
                            For Each Block As PictureBox In FallingBlocks

                                LeftPos = (Block.Left - CentreLeft) / 40
                                TopPos = (Block.Top - CentreTop) / 40

                                For x = 1 To FallingBlocks.Count
                                    Block.Left = -TopPos * 40 + CentreLeft
                                    Block.Top = LeftPos * 40 + CentreTop
                                Next

                                If Block.Left > HighestRight Then HighestRight = Block.Left
                                If Block.Left < HighestLeft Then HighestLeft = Block.Left
                            Next
                        End If
                    End If

                Case Keys.Escape
                    SignIn.Close()
                    Me.Close()
            End Select
        End If
        MoveShapeRight = True
        MoveShapeLeft = True
    End Sub

    Sub MoveShapeDown()
        For Each Block As PictureBox In FallingBlocks
            If Block.Top < 760 And IsShapeFalling = True Then
                Block.Top = Block.Top + 40
            End If
        Next
        CentreTop += 40
    End Sub

    Sub CheckIfFullRow()

        For Each Block As PictureBox In FallingBlocks
            If Block.Top > -1 Then
                Row((Block.Top + 40) / 40) += 1
                If Row((Block.Top + 40) / 40) > 9 Then
                    Delete = True
                End If
            End If
        Next

        For x = 1 To 20
            If Row(x) > 9 Then
                For Each Block As PictureBox In AllBlocks
                    If Block.Top = (x * 40) - 40 Then
                        FlashList.Add(Block)
                    End If
                Next
            End If
        Next

    End Sub

    Sub DeleteRow()

        For x = 1 To 20
            If Row(x) > 9 Then
                NumberOfFullRows += 1
                Rows += 1
                For Each Block As PictureBox In NonFallingBlocks
                    If Block.Top = (x * 40) - 40 Then
                        RowTopPosition = Block.Top
                        TempList.Add(Block)
                    End If
                    If Block.ImageLocation = MainMenu.Locations & "PowerUp.png" And Block.Top = RowTopPosition Then
                        AddPowerUp = True
                    End If
                Next

                If AddPowerUp = True Then
                    PowerUpRandom = R.Next(1, 4)
                    Select Case PowerUpRandom
                        Case 1
                            If Timer3Counter = 0 Then
                                Label1.Text += 1
                            Else
                                SlowShapesValue += 1
                            End If
                        Case 2
                            Label2.Text += 1
                        Case 3
                            Label3.Text += 1
                    End Select
                    AddPowerUp = False
                End If

                For Each Block As PictureBox In NonFallingBlocks
                    If Block.Top < RowTopPosition Then Block.Top += 40
                Next
                Count = ((RowTopPosition + 40) / 40) - 1
                Do Until Count = 0
                    Row(Count + 1) = Row(Count)
                    Count -= 1
                Loop
            End If
        Next

        For Each Block As PictureBox In TempList
            Block.Top = 1000
            AllBlocks.Remove(Block)
            NonFallingBlocks.Remove(Block)
            FlashList.Remove(Block)
            Block.Dispose()
        Next
        TempList.Clear()
        FlashList.Clear()

        Delete = False
        Timer2.Enabled = False
        Timer2.Stop()
        Timer2Counter = 0
        Score += NumberOfFullRows ^ 2 * 100

        If Score > Points1000 Then
            Points1000 += 1000
            PowerUpRandom = R.Next(1, 4)
            Select Case PowerUpRandom
                Case 1
                    If Timer3Counter = 0 Then
                        Label1.Text += 1
                    Else
                        SlowShapesValue += 1
                    End If
                Case 2
                    Label2.Text += 1
                Case 3
                    Label3.Text += 1
            End Select
            AddPowerUp = False
        End If

        If Score > TotalHighScore Then
            HighScoreLabel.Text = "Hi-Score: " & Score
        End If

        ScoreLabel.Text = "Score:      " & Score
        NumberOfFullRows = 0
        RowsLabel.Text = "Rows:      " & Rows

    End Sub

    Private Sub RemoveRows_Click(sender As Object, e As EventArgs) Handles RemoveRows.Click

        If Label2.Text > 0 Then
            PowerUpsUsed += 1
            RemoveRowsLabelClick = True
            Label2.Text -= 1
            For Each Block As PictureBox In AllBlocks
                If Block.Top > 719 Then FlashList.Add(Block)
            Next
            Timer2Counter = 0
            Timer2.Start()
            Timer2.Enabled = True
        End If

    End Sub
    'Manetclick'
    Private Sub Magnet_Click(sender As Object, e As EventArgs) Handles Magnet.Click

        If Label3.Text > 0 Then
            If MainMenu.SoundPaused = False Then
                MainMenu.mciSendString("close " & MainMenu.MagnetAlias, CStr(0), 0, 0)
                MainMenu.mciSendString("Open " & Chr(34) & MainMenu.MagnetPath & Chr(34) & " alias " & MainMenu.MagnetAlias, CStr(0), 0, 0)
                MainMenu.mciSendString("play " & MainMenu.MagnetAlias, CStr(0), 0, 0)
            End If
            Label3.Text -= 1
            PowerUpsUsed += 1

            If AllBlocks.Count > 0 Then
                Do Until BlocksNotMoved = NonFallingBlocks.Count + FallingBlocks.Count

                    BlocksNotMoved = 0

                    For Each Block As PictureBox In AllBlocks
                        MagnetMoveLeft = True
                        If Block.Left = 40 Then
                            MagnetMoveLeft = False
                        Else
                            For Each NonFallingBlock As PictureBox In NonFallingBlocks
                                If Block.Left - 40 = NonFallingBlock.Left And Block.Top = NonFallingBlock.Top Then
                                    MagnetMoveLeft = False
                                End If
                            Next
                            For Each FallingBlock As PictureBox In FallingBlocks
                                If Block.Top = FallingBlock.Top And Block.Left - 40 = FallingBlock.Left Then
                                    MagnetMoveLeft = False
                                End If
                            Next

                        End If

                        If MagnetMoveLeft = True Then
                            Block.Left -= 2
                        Else
                            BlocksNotMoved += 1
                        End If
                    Next

                Loop

                Do
                    CanMoveDown = True
                    For Each FallingBlock As PictureBox In FallingBlocks
                        If FallingBlock.Top > 759 Then CanMoveDown = False
                        For Each NonFallingBlock As PictureBox In NonFallingBlocks
                            If FallingBlock.Top + 40 = NonFallingBlock.Top And FallingBlock.Left = NonFallingBlock.Left Then CanMoveDown = False
                        Next
                    Next
                    If CanMoveDown = True Then
                        For Each Block As PictureBox In FallingBlocks
                            Block.Top = Block.Top + 40
                        Next
                        CentreTop += 40
                    End If
                Loop Until CanMoveDown = False

            End If
        End If

    End Sub
    'SlowBlocks'
    Private Sub SlowBlocks_Click(sender As Object, e As EventArgs) Handles SlowBlocks.Click

        If Label1.Text > 0 And Timer3Counter = 0 Then
            If MainMenu.SoundPaused = False Then
                MainMenu.mciSendString("close " & MainMenu.SlowingDownAlias, CStr(0), 0, 0)
                MainMenu.mciSendString("Open " & Chr(34) & MainMenu.SlowingDownPath & Chr(34) & " alias " & MainMenu.SlowingDownAlias, CStr(0), 0, 0)
                MainMenu.mciSendString("play " & MainMenu.SlowingDownAlias, CStr(0), 0, 0)
            End If
            DifficultyX2 = True
            Timer3Counter = 1
            Label1.Text -= 1
            PowerUpsUsed += 1
            SlowShapesValue = Label1.Text
            Timer3.Start()
            Timer3.Enabled = True
            Difficulty = Difficulty * 2
            Label1.Text = 20
        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3Counter += 1
        Label1.Text -= 1

        If Timer3Counter = 21 Then
            If MainMenu.SoundPaused = False Then
                MainMenu.mciSendString("close " & MainMenu.SpeedingUpAlias, CStr(0), 0, 0)
                MainMenu.mciSendString("Open " & Chr(34) & MainMenu.SpeedingUpPath & Chr(34) & " alias " & MainMenu.SpeedingUpAlias, CStr(0), 0, 0)
                MainMenu.mciSendString("play " & MainMenu.SpeedingUpAlias, CStr(0), 0, 0)
            End If
            DifficultyX2 = False
            Timer3.Stop()
            Timer3.Enabled = False
            Difficulty = Difficulty / 2
            Timer3Counter = 0
            Label1.Text = SlowShapesValue
        End If
    End Sub

    Sub RemoveRowsPowerUp()

        Dim TempBList As New List(Of PictureBox)
        RemoveRowsLabelClick = False
        Timer2Counter = 0
        Count = ((760 + 40) / 40) - 1
        Do Until Count = 0
            Row(Count + 1) = Row(Count)
            Count -= 1
        Loop
        Count = ((760 + 40) / 40) - 1
        Do Until Count = 0
            Row(Count + 1) = Row(Count)
            Count -= 1
        Loop

        For Each Block As PictureBox In AllBlocks
            If Block.Top > 719 Then
                FlashList.Remove(Block)
                NonFallingBlocks.Remove(Block)
                Block.Dispose()
                TempBList.Add(Block)
            End If
        Next
        For Each Block As PictureBox In TempBList
            AllBlocks.Remove(Block)
        Next
        TempBList.Clear()

        For Each Block As PictureBox In NonFallingBlocks
            If Block.Top < 720 Then Block.Top += 80
        Next
        Timer2.Stop()
        Timer2.Enabled = False

    End Sub

    'Pause the game '
    Sub TogglePauseGame()
        If Paused = False Then
            Paused = True
            Timer1.Enabled = False
            GamePaused.Visible = True
            MainMenu.mciSendString("pause " & MainMenu.musicAlias, CStr(0), 0, 0)
        Else
            Paused = False
            Timer1.Enabled = True
            GamePaused.Visible = False
            If MainMenu.SoundPaused = False Then
                MainMenu.mciSendString("play " & MainMenu.musicAlias, CStr(0), 0, 0)
            End If
        End If
    End Sub

    Sub ShapeT()
        Do Until NoOfBlocks = 4
            NoOfBlocks += 1
            NewBlock = New ShapeT
        Loop

        NoOfBlocks = 0
        PowerUp = False

        CentreTop = -40
        CentreLeft = 200
    End Sub

    Sub ShapeO()
        Do Until NoOfBlocks = 4
            NoOfBlocks += 1
            NewBlock = New ShapeO
        Loop

        NoOfBlocks = 0
        PowerUp = False
    End Sub

    Sub ShapeS()
        Do Until NoOfBlocks = 4
            NoOfBlocks += 1
            NewBlock = New ShapeS
        Loop

        NoOfBlocks = 0
        PowerUp = False

        CentreTop = -40
        CentreLeft = 240
    End Sub

    Sub ShapeZ()
        Do Until NoOfBlocks = 4
            NoOfBlocks += 1
            NewBlock = New ShapeZ
        Loop

        NoOfBlocks = 0
        PowerUp = False

        CentreTop = -40
        CentreLeft = 240
    End Sub

    Sub ShapeJ()
        Do Until NoOfBlocks = 4
            NoOfBlocks += 1
            NewBlock = New ShapeJ
        Loop

        NoOfBlocks = 0
        PowerUp = False

        CentreTop = -40
        CentreLeft = 240
    End Sub

    Sub ShapeL()
        Do Until NoOfBlocks = 4
            NoOfBlocks += 1
            NewBlock = New ShapeL
        Loop

        NoOfBlocks = 0
        PowerUp = False

        CentreTop = -40
        CentreLeft = 240
    End Sub

    Sub ShapeI()
        Do Until NoOfBlocks = 4
            NoOfBlocks += 1
            NewBlock = New ShapeI
        Loop

        NoOfBlocks = 0
        PowerUp = False

        CentreTop = -40
        CentreLeft = 200
    End Sub

    Sub ShapeX()
        Do Until NoOfBlocks = 5
            NoOfBlocks += 1
            NewBlock = New ShapeX
        Loop

        NoOfBlocks = 0
        PowerUp = False
    End Sub

    Sub ShapeW()
        Do Until NoOfBlocks = 5
            NoOfBlocks += 1
            NewBlock = New ShapeW
        Loop

        NoOfBlocks = 0
        PowerUp = False

        CentreTop = -80
        CentreLeft = 240
    End Sub

    Sub ShapeY()
        Do Until NoOfBlocks = 5
            NoOfBlocks += 1
            NewBlock = New ShapeY
        Loop

        NoOfBlocks = 0
        PowerUp = False

        CentreTop = -80
        CentreLeft = 240
    End Sub

    Sub ShapeYF()
        Do Until NoOfBlocks = 5
            NoOfBlocks += 1
            NewBlock = New ShapeYF
        Loop

        NoOfBlocks = 0
        PowerUp = False

        CentreTop = -80
        CentreLeft = 240
    End Sub

    Sub Shaper()
        Do Until NoOfBlocks = 3
            NoOfBlocks += 1
            NewBlock = New Shaper
        Loop

        NoOfBlocks = 0
        PowerUp = False

        CentreTop = -80
        CentreLeft = 240
    End Sub

    Sub ShaperF()
        Do Until NoOfBlocks = 3
            NoOfBlocks += 1
            NewBlock = New ShaperF
        Loop

        NoOfBlocks = 0
        PowerUp = False

        CentreTop = -80
        CentreLeft = 240
    End Sub
    'This is how to get the shape random you can customize it here'
    Sub GetRandomNumber()
        RandomNumber = R.Next(1, 20)
        If RandomNumber = 1 Then PowerUp = True
    End Sub

    Sub GetShapeImage()

        Select Case NewRandom
            Case 1
                NextShape.ImageLocation = MainMenu.Locations & "ShapeJ.png"
            Case 2
                NextShape.ImageLocation = MainMenu.Locations & "ShapeL.png"
            Case 3
                NextShape.ImageLocation = MainMenu.Locations & "ShapeI.png"
            Case 4
                NextShape.ImageLocation = MainMenu.Locations & "ShapeS.png"
            Case 5
                NextShape.ImageLocation = MainMenu.Locations & "ShapeZ.png"
            Case 6
                NextShape.ImageLocation = MainMenu.Locations & "ShapeT.png"
            Case 7
                NextShape.ImageLocation = MainMenu.Locations & "ShapeO.png"
            'Easy mode only 7 is the default mode to be made'
            Case 8
                NextShape.ImageLocation = MainMenu.Locations & "ShapeX.png"
            Case 9
                NextShape.ImageLocation = MainMenu.Locations & "ShapeW.png"
            Case 10
                NextShape.ImageLocation = MainMenu.Locations & "ShapeY.png"
            Case 11
                NextShape.ImageLocation = MainMenu.Locations & "ShapeYF.png"
            Case 12
                NextShape.ImageLocation = MainMenu.Locations & "Shaper.png"
            Case 13
                NextShape.ImageLocation = MainMenu.Locations & "ShaperF.png"
        End Select

    End Sub

    Private Sub ExitLabel_Click(sender As Object, e As EventArgs) Handles ExitLabel.Click
        LosingScreen.FromMainMenu = True
        MainMenu.Timer1.Enabled = True

        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub SlowBlocks_MouseOver(sender As Object, e As EventArgs) Handles SlowBlocks.MouseHover
        SlowBlocks.BackColor = MainMenu.ButtonOverColour
    End Sub

    Private Sub SlowBlocks_MouseNotOver(sender As Object, e As EventArgs) Handles SlowBlocks.MouseLeave
        SlowBlocks.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub SlowBlocks_MouseDown(sender As Object, e As EventArgs) Handles SlowBlocks.MouseDown
        SlowBlocks.BackColor = MainMenu.ButtonDownColour
    End Sub

    Private Sub SlowBlocks_MouseNotDown(sender As Object, e As EventArgs) Handles SlowBlocks.MouseUp
        SlowBlocks.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub RemoveRows_MouseOver(sender As Object, e As EventArgs) Handles RemoveRows.MouseHover
        RemoveRows.BackColor = MainMenu.ButtonOverColour
    End Sub

    Private Sub RemoveRows_MouseNotOver(sender As Object, e As EventArgs) Handles RemoveRows.MouseLeave
        RemoveRows.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub RemoveRows_MouseDown(sender As Object, e As EventArgs) Handles RemoveRows.MouseDown
        RemoveRows.BackColor = MainMenu.ButtonDownColour
    End Sub

    Private Sub RemoveRows_MouseNotDown(sender As Object, e As EventArgs) Handles RemoveRows.MouseUp
        RemoveRows.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub ClickBlocks_MouseOver(sender As Object, e As EventArgs) Handles Magnet.MouseHover
        Magnet.BackColor = MainMenu.ButtonOverColour
    End Sub

    Private Sub ClickBlocks_MouseNotOver(sender As Object, e As EventArgs) Handles Magnet.MouseLeave
        Magnet.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub ClickBlocks_MouseDown(sender As Object, e As EventArgs) Handles Magnet.MouseDown
        Magnet.BackColor = MainMenu.ButtonDownColour
    End Sub

    Private Sub ClickBlocks_MouseNotDown(sender As Object, e As EventArgs) Handles Magnet.MouseUp
        Magnet.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub ExitLabel_MouseOver(sender As Object, e As EventArgs) Handles ExitLabel.MouseHover
        ExitLabel.BackColor = MainMenu.ButtonOverColour
    End Sub

    Private Sub ExitLabel_MouseNotOver(sender As Object, e As EventArgs) Handles ExitLabel.MouseLeave
        ExitLabel.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub ExitLabel_MouseDown(sender As Object, e As EventArgs) Handles ExitLabel.MouseDown
        ExitLabel.BackColor = MainMenu.ButtonDownColour
    End Sub

    Private Sub ExitLabel_MouseNotDown(sender As Object, e As EventArgs) Handles ExitLabel.MouseUp
        ExitLabel.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub Speaker_MouseOver(sender As Object, a As EventArgs) Handles Speaker.MouseHover
        Speaker.BackColor = MainMenu.ButtonOverColour
    End Sub

    Private Sub Speaker_MouseNotOver(sender As Object, a As EventArgs) Handles Speaker.MouseLeave
        Speaker.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub Speaker_MouseDown(sender As Object, a As EventArgs) Handles Speaker.MouseDown
        Speaker.BackColor = MainMenu.ButtonDownColour
    End Sub

    Private Sub Speaker_MouseNotDown(sender As Object, a As EventArgs) Handles Speaker.MouseUp
        Speaker.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub QuestionMark_MouseOver(sender As Object, e As EventArgs) Handles QuestionMark.MouseHover
        QuestionMark.BackColor = MainMenu.ButtonOverColour
    End Sub

    Private Sub QuestionMark_MouseNotOver(sender As Object, e As EventArgs) Handles QuestionMark.MouseLeave
        QuestionMark.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub QuestionMark_MouseDown(sender As Object, e As EventArgs) Handles QuestionMark.MouseDown
        QuestionMark.BackColor = MainMenu.ButtonDownColour
    End Sub

    Private Sub QuestionMark_MouseNotDown(sender As Object, e As EventArgs) Handles QuestionMark.MouseUp
        QuestionMark.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub QuestionMark_Click(sender As Object, e As EventArgs) Handles QuestionMark.Click

        If Paused = False Then TogglePauseGame()

        Instructions.InstructionsFromMainMenu = False
        Instructions.Show()
    End Sub

    Private Sub Difficulty1_MouseOver(sender As Object, e As EventArgs) Handles Difficulty1.MouseHover
        Difficulty1.BackColor = MainMenu.ButtonOverColour
    End Sub

    Private Sub Difficulty1_MouseNotOver(sender As Object, e As EventArgs) Handles Difficulty1.MouseLeave
        Difficulty1.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub Difficulty1_MouseDown(sender As Object, e As EventArgs) Handles Difficulty1.MouseDown
        Difficulty1.BackColor = MainMenu.ButtonDownColour
    End Sub

    Private Sub Difficulty1_MouseNotDown(sender As Object, e As EventArgs) Handles Difficulty1.MouseUp
        Difficulty1.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub Difficulty2_MouseOver(sender As Object, e As EventArgs) Handles Difficulty2.MouseHover
        Difficulty2.BackColor = MainMenu.ButtonOverColour
    End Sub

    Private Sub Difficulty2_MouseNotOver(sender As Object, e As EventArgs) Handles Difficulty2.MouseLeave
        Difficulty2.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub Difficulty2_MouseDown(sender As Object, e As EventArgs) Handles Difficulty2.MouseDown
        Difficulty2.BackColor = MainMenu.ButtonDownColour
    End Sub

    Private Sub Difficulty2_MouseNotDown(sender As Object, e As EventArgs) Handles Difficulty2.MouseUp
        Difficulty2.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub Difficulty3_MouseOver(sender As Object, e As EventArgs) Handles Difficulty3.MouseHover
        Difficulty3.BackColor = MainMenu.ButtonOverColour
    End Sub

    Private Sub Difficulty3_MouseNotOver(sender As Object, e As EventArgs) Handles Difficulty3.MouseLeave
        Difficulty3.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub Difficulty3_MouseDown(sender As Object, e As EventArgs) Handles Difficulty3.MouseDown
        Difficulty3.BackColor = MainMenu.ButtonDownColour
    End Sub

    Private Sub Difficulty3_MouseNotDown(sender As Object, e As EventArgs) Handles Difficulty3.MouseUp
        Difficulty3.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub Difficulty4_MouseOver(sender As Object, e As EventArgs) Handles Difficulty4.MouseHover
        Difficulty4.BackColor = MainMenu.ButtonOverColour
    End Sub

    Private Sub Difficulty4_MouseNotOver(sender As Object, e As EventArgs) Handles Difficulty4.MouseLeave
        Difficulty4.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub Difficulty4_MouseDown(sender As Object, e As EventArgs) Handles Difficulty4.MouseDown
        Difficulty4.BackColor = MainMenu.ButtonDownColour
    End Sub

    Private Sub Difficulty4_MouseNotDown(sender As Object, e As EventArgs) Handles Difficulty4.MouseUp
        Difficulty4.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub Difficulty5_MouseOver(sender As Object, e As EventArgs) Handles Difficulty5.MouseHover
        Difficulty5.BackColor = MainMenu.ButtonOverColour
    End Sub

    Private Sub Difficulty5_MouseNotOver(sender As Object, e As EventArgs) Handles Difficulty5.MouseLeave
        Difficulty5.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub Difficulty5_MouseDown(sender As Object, e As EventArgs) Handles Difficulty5.MouseDown
        Difficulty5.BackColor = MainMenu.ButtonDownColour
    End Sub

    Private Sub Difficulty5_MouseNotDown(sender As Object, e As EventArgs) Handles Difficulty5.MouseUp
        Difficulty5.BackColor = MainMenu.ButtonColour
    End Sub

    Private Sub Difficulty1_Click(sender As Object, e As EventArgs) Handles Difficulty1.Click
        If DifficultyX2 = False Then
            Difficulty = 75
        Else
            Difficulty = 150
        End If
    End Sub

    Private Sub Difficulty2_Click(sender As Object, e As EventArgs) Handles Difficulty2.Click
        If DifficultyX2 = False Then
            Difficulty = 60
        Else
            Difficulty = 120
        End If
    End Sub

    Private Sub Difficulty3_Click(sender As Object, e As EventArgs) Handles Difficulty3.Click
        If DifficultyX2 = False Then
            Difficulty = 45
        Else
            Difficulty = 90
        End If
    End Sub

    Private Sub Difficulty4_Click(sender As Object, e As EventArgs) Handles Difficulty4.Click
        If DifficultyX2 = False Then
            Difficulty = 30
        Else
            Difficulty = 60
        End If
    End Sub

    Private Sub Difficulty5_Click(sender As Object, e As EventArgs) Handles Difficulty5.Click
        If DifficultyX2 = False Then
            Difficulty = 10
        Else
            Difficulty = 20
        End If
    End Sub

    Private Sub GamePaused_Click(sender As Object, e As EventArgs) Handles GamePaused.Click
        GamePaused.Visible = False
        TogglePauseGame()
    End Sub

    Private Sub Speaker_Click(sender As Object, e As EventArgs) Handles Speaker.Click

        If MainMenu.SoundPaused = True Then
            Speaker.BackgroundImage = Image.FromFile(MainMenu.Locations & "Speaker.png")
            MainMenu.SpeakerButton.BackgroundImage = Image.FromFile(MainMenu.Locations & "Speaker.png")
            MainMenu.SoundPaused = False
            MainMenu.mciSendString("play " & MainMenu.musicAlias, CStr(0), 0, 0)
        Else
            Speaker.BackgroundImage = Image.FromFile(MainMenu.Locations & "SpeakerMute.png")
            MainMenu.SpeakerButton.BackgroundImage = Image.FromFile(MainMenu.Locations & "SpeakerMute.png")
            MainMenu.SoundPaused = True
            MainMenu.mciSendString("pause " & MainMenu.musicAlias, CStr(0), 0, 0)
        End If

    End Sub

End Class