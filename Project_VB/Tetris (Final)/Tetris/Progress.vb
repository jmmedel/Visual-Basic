Imports System.IO

Public Class Progress

    Dim NoOfScores As Integer = 0
    Dim NoOfNames As Integer = 0
    Dim FileName As String = ""
    Dim FileScore As Integer = 0
    Dim HighScore As Integer = 0

    Dim ScoreList As New Dictionary(Of Integer, Integer)
    Dim NameList As New Dictionary(Of Integer, String)

    Dim Swap As Boolean = False
    Dim Temp As Integer = 0
    Dim TempName As String = ""

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Close()
        MainMenu.Show()
    End Sub

    Private Sub Progress_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim SR As New StreamReader(MainMenu.Locations & "UserData.txt")

        While Not SR.EndOfStream
            FileName = SR.ReadLine

            NameList.Add(NoOfNames, FileName)
            NoOfNames += 1

            SR.ReadLine()

            FileScore = SR.ReadLine

            ScoreList.Add(NoOfScores, FileScore)
            NoOfScores += 1

            If FileName = MainMenu.UserName Then
                HighScore = FileScore
            End If

        End While

        If NoOfNames < 5 Then
            For x = 1 To 5 - NoOfNames
                NameList.Add(NoOfNames, "")
                NoOfNames += 1
            Next
            For x = 1 To 5 - NoOfScores
                ScoreList.Add(NoOfScores, 0)
                NoOfScores += 1
            Next
        End If

        SR.Close()
        SR.Dispose()

        Select Case HighScore
            Case Is < 1000
                MinScoreLabel.Text = 0
                MaxScoreLabel.Text = 1000
                CurrentScoreBar.Minimum = 0
                CurrentScoreBar.Maximum = 1000
                UnlockNameLabel.Text = "UnderGround"
            Case Is < 5000 And HighScore >= 1000
                MinScoreLabel.Text = 1000
                MaxScoreLabel.Text = 5000
                CurrentScoreBar.Minimum = 1000
                CurrentScoreBar.Maximum = 5000
                UnlockNameLabel.Text = "Space"
            Case Is < 10000 And HighScore >= 5000
                MinScoreLabel.Text = 5000
                MaxScoreLabel.Text = 10000
                CurrentScoreBar.Minimum = 5000
                CurrentScoreBar.Maximum = 10000
                UnlockNameLabel.Text = "Tetris"
            Case Is >= 10000
                MinScoreLabel.Text = 0
                MaxScoreLabel.Text = 10000
                CurrentScoreBar.Minimum = 0
                CurrentScoreBar.Maximum = 10000
                UnlockNameLabel.Visible = False
                NextUnlock.Text = "You are at the maximum level"
                CurrentScoreBar.Value = 10000
                CurrentScoreLabel.Visible = False
        End Select

        If HighScore < 10000 Then
            CurrentScoreBar.Value = HighScore
            CurrentScoreLabel.Text = CurrentScoreLabel.Text & HighScore
        End If


        For Each Component In Controls
            Component.ForeColor = MainMenu.FontColour
        Next
        Me.BackColor = MainMenu.BackColour
        Back.BackColor = MainMenu.ButtonColour
        Back.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        Back.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour
        LeaderboardTable.BackColor = MainMenu.InstructionsColour
        PlayerNameLabel.BackColor = MainMenu.InstructionsColour
        Name1.BackColor = MainMenu.InstructionsColour
        Name2.BackColor = MainMenu.InstructionsColour
        Name3.BackColor = MainMenu.InstructionsColour
        Name4.BackColor = MainMenu.InstructionsColour
        Name5.BackColor = MainMenu.InstructionsColour
        HighScore1.BackColor = MainMenu.InstructionsColour
        HighScore2.BackColor = MainMenu.InstructionsColour
        HighScore3.BackColor = MainMenu.InstructionsColour
        HighScore4.BackColor = MainMenu.InstructionsColour
        HighScore5.BackColor = MainMenu.InstructionsColour

        Do
            Swap = False
            For x = 0 To NoOfNames - 2
                If ScoreList(x) < ScoreList(x + 1) Then

                    Temp = ScoreList(x)
                    TempName = NameList(x)

                    ScoreList(x) = ScoreList(x + 1)
                    NameList(x) = NameList(x + 1)

                    ScoreList(x + 1) = Temp
                    NameList(x + 1) = TempName

                    Swap = True

                End If
            Next
        Loop Until Swap = False

        HighScore1.Text = ScoreList.Item(0)
        HighScore2.Text = ScoreList.Item(1)
        HighScore3.Text = ScoreList.Item(2)
        HighScore4.Text = ScoreList.Item(3)
        HighScore5.Text = ScoreList.Item(4)

        Name1.Text = NameList.Item(0)
        Name2.Text = NameList.Item(1)
        Name3.Text = NameList.Item(2)
        Name4.Text = NameList.Item(3)
        Name5.Text = NameList.Item(4)

    End Sub

End Class