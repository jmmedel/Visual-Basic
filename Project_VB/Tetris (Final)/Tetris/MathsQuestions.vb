Imports System.IO

Public Class MathsQuestions

    Dim MathsTimerCounter As Integer = 10
    Dim Answer As String
    Dim MathsQnsDifficulty As String = "Easy.txt"
    Dim UserAnswer As Double = 0
    Dim R As New Random
    Dim RandomNo As Integer = 100
    Dim AnswerCorrectOrWrong As String = ""
    Dim Answered As Boolean = False

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        MathsTimerCounter -= 1

        If MathsTimerCounter < 0 Then
            If Tetris.VHardQn = True Then
                If AnswerCorrectOrWrong = "Correct!" Then
                    Tetris.Add8RowsToFlashList()
                    Tetris.Timer2.Enabled = True
                Else
                    Tetris.EndGame()
                End If
            Else
                Tetris.Timer1.Enabled = True
                Tetris.Timer2.Enabled = True
            End If
            Me.Close()
        End If

        If Answered = False Then
            Label2.Text = MathsTimerCounter
            If MathsTimerCounter = 0 Then
                AnswerCorrectOrWrong = "Incorrect"
                FinQnLabel.ForeColor = Color.Red
                AnsweredQuestion()
                Answered = True
            End If

        End If

    End Sub

    Sub AnsweredQuestion()

        MathsTimerCounter = 0

        For Each Component In Controls
            Component.Visible = False
        Next

        FinQnLabel.Text = AnswerCorrectOrWrong

        FinQnLabel.Visible = True

    End Sub

    Private Sub MathsQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MathsTimerCounter = 10
        Label2.Text = 10
        Answered = False
        UserAnswer = 0

        For Each Component In Controls
            Component.ForeColor = MainMenu.FontColour
        Next

        Me.BackColor = MainMenu.BackColour
        Label2.BackColor = MainMenu.ButtonColour
        OkButton.BackColor = MainMenu.ButtonColour
        OkButton.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        OkButton.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour

        If Tetris.VHardQn = False Then
            RandomNo = R.Next(0, 10) * 6
            If Tetris.DifficultyX2 = False Then
                Select Case Tetris.Difficulty
                    Case 10
                        HardQns()
                    Case 30
                        NormalQns()
                    Case 45
                        NormalQns()
                    Case 60
                        EasyQns()
                    Case 75
                        EasyQns()
                End Select
            Else
                Select Case Tetris.Difficulty
                    Case 20
                        HardQns()
                    Case 60
                        NormalQns()
                    Case 90
                        NormalQns()
                    Case 120
                        EasyQns()
                    Case 150
                        EasyQns()
                End Select
            End If



        Else
            RandomNo = R.Next(0, 5) * 6
            VeryHardQns()
        End If
    End Sub

    Sub EasyQns()
        QuestionLabel.Text = Tetris.EasyQns(RandomNo)
        Answer = Tetris.EasyQns(RandomNo + 1)
        Answer1.Text = Tetris.EasyQns(RandomNo + 2)
        Answer2.Text = Tetris.EasyQns(RandomNo + 3)
        Answer3.Text = Tetris.EasyQns(RandomNo + 4)
        Answer4.Text = Tetris.EasyQns(RandomNo + 5)
    End Sub

    Sub NormalQns()
        QuestionLabel.Text = Tetris.NormalQns(RandomNo)
        Answer = Tetris.NormalQns(RandomNo + 1)
        Answer1.Text = Tetris.NormalQns(RandomNo + 2)
        Answer2.Text = Tetris.NormalQns(RandomNo + 3)
        Answer3.Text = Tetris.NormalQns(RandomNo + 4)
        Answer4.Text = Tetris.NormalQns(RandomNo + 5)
    End Sub

    Sub HardQns()
        QuestionLabel.Text = Tetris.HardQns(RandomNo)
        Answer = Tetris.HardQns(RandomNo + 1)
        Answer1.Text = Tetris.HardQns(RandomNo + 2)
        Answer2.Text = Tetris.HardQns(RandomNo + 3)
        Answer3.Text = Tetris.HardQns(RandomNo + 4)
        Answer4.Text = Tetris.HardQns(RandomNo + 5)
    End Sub

    Sub VeryHardQns()
        QuestionLabel.Text = Tetris.VeryHardQns(RandomNo)
        Answer = Tetris.VeryHardQns(RandomNo + 1)
        Answer1.Text = Tetris.VeryHardQns(RandomNo + 2)
        Answer2.Text = Tetris.VeryHardQns(RandomNo + 3)
        Answer3.Text = Tetris.VeryHardQns(RandomNo + 4)
        Answer4.Text = Tetris.VeryHardQns(RandomNo + 5)
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click

        If Answer = UserAnswer Then
            If Tetris.VHardQn = False Then
                Tetris.Score += 50
            End If
            Answered = True
            Tetris.QuestionsCorrect += 1
            AnswerCorrectOrWrong = "Correct!"
            FinQnLabel.ForeColor = Color.Green
            AnsweredQuestion()

        Else
            Answered = True
            AnswerCorrectOrWrong = "Incorrect!"
            FinQnLabel.ForeColor = Color.Red
            AnsweredQuestion()
        End If

    End Sub

    Private Sub Answer1_CheckedChanged(sender As Object, e As EventArgs) Handles Answer1.CheckedChanged
        UserAnswer = Answer1.Text
    End Sub

    Private Sub Answer2_CheckedChanged(sender As Object, e As EventArgs) Handles Answer2.CheckedChanged
        UserAnswer = Answer2.Text
    End Sub

    Private Sub Answer3_CheckedChanged(sender As Object, e As EventArgs) Handles Answer3.CheckedChanged
        UserAnswer = Answer3.Text
    End Sub

    Private Sub Answer4_CheckedChanged(sender As Object, e As EventArgs) Handles Answer4.CheckedChanged
        UserAnswer = Answer4.Text
    End Sub

End Class
