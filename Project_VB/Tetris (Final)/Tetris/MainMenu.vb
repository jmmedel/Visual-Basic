Public Class MainMenu
    'All File need to add more item '
    'This is the default file need to change first'

    'Public Locations As String = "C:\Program Files\Tetris (Final)\Resources\"'

    Public Locations As String = "C:\Users\kagaya john\Desktop\Visual-Basic\Project_VB\Tetris (Final)\Resources\"

    Public MMFallingBlocks As New List(Of PictureBox)
    Public MMNewBlock As New PictureBox
    Public MMNoOfBlocks, TopLoc, LeftLoc As Integer
    Public RandomPos As Integer = 250
    Public ComeFromPlaySettings As Boolean = False
    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Public musicAlias As String = "myAudio"
    Public musicPath As String = Locations & "Epic Remix.wav"
    Public RowMusicPath As String = Locations & "Row Sound.wav"
    Public RowMusicAlias As String = "myAudio1"
    Public SlowingDownPath As String = Locations & "SlowingDown.wav"
    Public SlowingDownAlias As String = "myAudio2"
    Public SpeedingUpPath As String = Locations & "SpeedingUp.wav"
    Public SpeedingUpAlias As String = "myAudio3"
    Public MagnetPath As String = Locations & "Magnet.wav"
    Public MagnetAlias As String = "myAudio4"
    Public Male As Boolean = True
    Public ColourConvert As New ColorConverter
    Public ButtonColour As Color = ColourConvert.ConvertFromString("180, 0, 0")
    Public ButtonOverColour As Color = Color.DarkRed
    Public ButtonDownColour As Color = Color.Firebrick
    Public BackColour As Color = ColourConvert.ConvertFromString("64, 64, 64")
    Public TetrisComponentBackColour As Color = ColourConvert.ConvertFromString("64, 64, 64")
    Public TetrisBackColour As Color = ColourConvert.ConvertFromString("55, 55, 55")
    Public InstructionsColour As Color = ColourConvert.ConvertFromString("73, 73, 73")
    Public FontColour As Color = Color.Black
    Public UserName As String = "tom"
    Public BackgroundImageLoc As String = ""
    Public SoundPaused As Boolean = False

    Dim MMPrevRandom As Integer
    Dim MMRandomBlock As Integer
    Dim R As New Random
    Dim RandomSong As Integer = 0
    Dim MMTimer1Counter As Integer = 0
    Dim Song As Integer = 0
    Dim PrevSong As Integer = 0
    Dim PrevRamdomPos As Integer

    Private Sub Play_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Timer1.Enabled = False
        ComeFromPlaySettings = True
        Me.Hide()
        Playsettings.Show()
    End Sub

    Private Sub ProgressButton_Click(sender As Object, e As EventArgs) Handles ProgressButton.Click
        Progress.Show()
    End Sub

    Private Sub InstructionsButton_Click(sender As Object, e As EventArgs) Handles InstructionsButton.Click
        Instructions.InstructionsFromMainMenu = True
        Instructions.Show()
    End Sub

    Private Sub ExitProgram_Click(sender As Object, e As EventArgs) Handles ExitProgram.Click
        Me.Close()
        SignIn.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If MMTimer1Counter Mod 80 = 0 Then
            Do Until MMPrevRandom <> MMRandomBlock
                MMRandomBlock = R.Next(1, 14)
            Loop
            MMPrevRandom = MMRandomBlock

            Do Until RandomPos > PrevRamdomPos + 160 Or RandomPos < PrevRamdomPos - 160
                RandomPos = R.Next(45, 465)
            Loop

            PrevRamdomPos = RandomPos

            Select Case MMRandomBlock
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
        End If

        MMTimer1Counter += 1

        For Each Block As PictureBox In MMFallingBlocks
            Block.Top = Block.Top + 1
            If Block.Top > Me.Height + 40 Then
                Block.Dispose()
            End If
        Next

    End Sub

    Sub ShapeT()
        Do Until MMNoOfBlocks = 4
            MMNoOfBlocks += 1
            MMNewBlock = New ShapeT
        Loop
        MMNoOfBlocks = 0
    End Sub

    Sub ShapeO()
        Do Until MMNoOfBlocks = 4
            MMNoOfBlocks += 1
            MMNewBlock = New ShapeO
        Loop
        MMNoOfBlocks = 0
    End Sub

    Sub ShapeS()
        Do Until MMNoOfBlocks = 4
            MMNoOfBlocks += 1
            MMNewBlock = New ShapeS
        Loop
        MMNoOfBlocks = 0
    End Sub

    Sub ShapeZ()
        Do Until MMNoOfBlocks = 4
            MMNoOfBlocks += 1
            MMNewBlock = New ShapeZ
        Loop
        MMNoOfBlocks = 0
    End Sub

    Sub ShapeJ()
        Do Until MMNoOfBlocks = 4
            MMNoOfBlocks += 1
            MMNewBlock = New ShapeJ
        Loop
        MMNoOfBlocks = 0
    End Sub

    Sub ShapeL()
        Do Until MMNoOfBlocks = 4
            MMNoOfBlocks += 1
            MMNewBlock = New ShapeL
        Loop
        MMNoOfBlocks = 0
    End Sub

    Sub ShapeI()
        Do Until MMNoOfBlocks = 4
            MMNoOfBlocks += 1
            MMNewBlock = New ShapeI
        Loop
        MMNoOfBlocks = 0
    End Sub

    Sub ShapeX()
        Do Until MMNoOfBlocks = 5
            MMNoOfBlocks += 1
            MMNewBlock = New ShapeX
        Loop
        MMNoOfBlocks = 0
    End Sub

    Sub ShapeW()
        Do Until MMNoOfBlocks = 5
            MMNoOfBlocks += 1
            MMNewBlock = New ShapeW
        Loop
        MMNoOfBlocks = 0
    End Sub

    Sub ShapeY()
        Do Until MMNoOfBlocks = 5
            MMNoOfBlocks += 1
            MMNewBlock = New ShapeY
        Loop
        MMNoOfBlocks = 0
    End Sub

    Sub ShapeYF()
        Do Until MMNoOfBlocks = 5
            MMNoOfBlocks += 1
            MMNewBlock = New ShapeYF
        Loop
        MMNoOfBlocks = 0
    End Sub

    Sub Shaper()
        Do Until MMNoOfBlocks = 3
            MMNoOfBlocks += 1
            MMNewBlock = New Shaper
        Loop
        MMNoOfBlocks = 0
    End Sub

    Sub ShaperF()
        Do Until MMNoOfBlocks = 3
            MMNoOfBlocks += 1
            MMNewBlock = New ShaperF
        Loop
        MMNoOfBlocks = 0
    End Sub

    Private Sub CustomizationButton_Click(sender As Object, e As EventArgs) Handles CustomizationButton.Click
        ComeFromPlaySettings = False
        Customization.Show()
    End Sub

    Private Sub SignOut_Click(sender As Object, e As EventArgs) Handles SignOutButton.Click
        MainMenu.mciSendString("stop " & musicAlias, CStr(0), 0, 0)
        MainMenu.mciSendString("close " & musicAlias, CStr(0), 0, 0)
        SignIn.UserNameBox.Text = ""
        SignIn.PassBox.Text = ""
        SignIn.ReEnterPassBox.Text = ""

        Me.Close()
        SignIn.Show()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LosingScreen.FromMainMenu = True

        Select Case R.Next(1, 5)
            Case 1
                musicPath = Locations & "Approaching Nirvana Remix.wav"
                PrevSong = 1
            Case 2
                musicPath = Locations & "Dubstep Remix.wav"
                PrevSong = 2
            Case 3
                musicPath = Locations & "Epic Remix.wav"
                PrevSong = 3
            Case 4
                musicPath = Locations & "Heavy Metal Remix.wav"
                PrevSong = 4
        End Select
        RandomSong = PrevSong

        If Male = True Then
            ButtonColour = ColourConvert.ConvertFromString("180, 0, 0")
            ButtonOverColour = Color.DarkRed
            ButtonDownColour = Color.Firebrick
            BackColour = ColourConvert.ConvertFromString("64, 64, 64")
            TetrisBackColour = ColourConvert.ConvertFromString("55, 55, 55")
            InstructionsColour = ColourConvert.ConvertFromString("73, 73, 73")
        Else
            ButtonColour = Color.LightGreen
            ButtonOverColour = Color.LawnGreen
            ButtonDownColour = Color.LimeGreen
            BackColour = Color.PowderBlue
            InstructionsColour = Color.MediumTurquoise
            TetrisBackColour = Color.PowderBlue
            TetrisComponentBackColour = Color.MediumTurquoise
        End If

        For Each Component In Controls
            Component.ForeColor = FontColour
        Next

        Me.BackColor = BackColour
        PlayButton.BackColor = ButtonColour
        PlayButton.FlatAppearance.MouseOverBackColor = ButtonOverColour
        PlayButton.FlatAppearance.MouseDownBackColor = ButtonDownColour

        CustomizationButton.BackColor = ButtonColour
        CustomizationButton.FlatAppearance.MouseOverBackColor = ButtonOverColour
        CustomizationButton.FlatAppearance.MouseDownBackColor = ButtonDownColour

        ProgressButton.BackColor = ButtonColour
        ProgressButton.FlatAppearance.MouseOverBackColor = ButtonOverColour
        ProgressButton.FlatAppearance.MouseDownBackColor = ButtonDownColour

        InstructionsButton.BackColor = ButtonColour
        InstructionsButton.FlatAppearance.MouseOverBackColor = ButtonOverColour
        InstructionsButton.FlatAppearance.MouseDownBackColor = ButtonDownColour

        SpeakerButton.BackColor = ButtonColour
        SpeakerButton.FlatAppearance.MouseOverBackColor = ButtonOverColour
        SpeakerButton.FlatAppearance.MouseDownBackColor = ButtonDownColour

        RandSongButton.BackColor = ButtonColour
        RandSongButton.FlatAppearance.MouseOverBackColor = ButtonOverColour
        RandSongButton.FlatAppearance.MouseDownBackColor = ButtonDownColour

        SignOutButton.BackColor = ButtonColour
        SignOutButton.FlatAppearance.MouseOverBackColor = ButtonOverColour
        SignOutButton.FlatAppearance.MouseDownBackColor = ButtonDownColour

        ExitProgram.BackColor = ButtonColour
        ExitProgram.FlatAppearance.MouseOverBackColor = ButtonOverColour
        ExitProgram.FlatAppearance.MouseDownBackColor = ButtonDownColour

        mciSendString("Open " & Chr(34) & musicPath & Chr(34) & " alias " & musicAlias, CStr(0), 0, 0)
        mciSendString("play " & musicAlias, CStr(0), 0, 0)

        DoubleBuffered = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SpeakerButton.Click

        If SoundPaused = True Then
            SpeakerButton.BackgroundImage = Image.FromFile(Locations & "Speaker.png")
            SoundPaused = False
            MainMenu.mciSendString("play " & musicAlias, CStr(0), 0, 0)
        Else
            SpeakerButton.BackgroundImage = Image.FromFile(Locations & "SpeakerMute.png")
            SoundPaused = True
            MainMenu.mciSendString("pause " & musicAlias, CStr(0), 0, 0)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RandSongButton.Click

        MainMenu.mciSendString("stop " & musicAlias, CStr(0), 0, 0)
        MainMenu.mciSendString("close " & musicAlias, CStr(0), 0, 0)

        Do Until RandomSong <> PrevSong
            RandomSong = R.Next(1, 5)
        Loop

        PrevSong = RandomSong

        Select Case RandomSong
            Case 1
                musicPath = Locations & "Approaching Nirvana Remix.wav"
            Case 2
                musicPath = Locations & "Dubstep Remix.wav"
            Case 3
                musicPath = Locations & "Epic Remix.wav"
            Case 4
                musicPath = Locations & "Heavy Metal Remix.wav"
        End Select

        mciSendString("Open " & Chr(34) & musicPath & Chr(34) & " alias " & musicAlias, CStr(0), 0, 0)
        mciSendString("play " & musicAlias, CStr(0), 0, 0)

    End Sub
End Class