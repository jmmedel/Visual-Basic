Imports System.IO

Public Class SignIn

    Dim UpperCase, LowerCase, Number As Boolean
    Dim Password As String = ""
    Dim FileName As String
    Dim SameUserName As Boolean = False
    Dim InvalidPasswordLength As Boolean = False
    Dim NameLength As Integer = 0
    Dim InvalidNameLength As Boolean = False
    Dim BoxesNotFull As Boolean = True
    Dim DoneNumber As Boolean = False
    Dim DoneUpperCase As Boolean = False
    Dim DoneLowerCase As Boolean = False
    Dim ValidChar As Boolean = False
    Dim ValidData As Boolean = False
    Dim ColourConverter As New ColorConverter
    Dim Colour As Color = ColourConverter.ConvertFromString("73, 73, 73")
    Dim PasswordStrength As Integer = 0

    Public Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer
    Public musicAlias As String = "myAudio"
    Public musicPath As String = MainMenu.Locations & "Row Sound.wav"

    Private Sub SignInButton_Click(sender As Object, e As EventArgs) Handles SignInButton.Click

        If FemaleRadioButton.Checked = True Then
            MainMenu.Male = False
        Else
            MainMenu.Male = True
        End If


        NameLength = 0
        ValidData = True

        If SignInButton.Text = "Done" Then

            MessageLabel2.Text = ""
            MessageLabel2.Visible = False
            SameUserName = False

            If Password.Length < 5 Or Password.Length > 10 Then
                MessageLabel2.Text = "Invalid Password Length"
                MessageLabel2.Visible = True
                ValidData = False
            End If

            If UserNameBox.Text = "" Or PassBox.Text = "" Or ReEnterPassBox.Text = "" Then
                MessageLabel2.Visible = True
                MessageLabel2.Text = "Please fill all boxes"
                ValidData = False
            End If

            For Each Letter As Char In UserNameBox.Text
                If Asc(Letter) > 47 And Asc(Letter) < 58 Or Asc(Letter) > 64 And Asc(Letter) < 91 Or Asc(Letter) > 96 And Asc(Letter) < 123 Then
                Else
                    ValidData = False
                    MessageLabel2.Visible = True
                    MessageLabel2.Text = "Username characters not valid"
                End If
                NameLength += 1
            Next

            For Each Letter As Char In PassBox.Text
                If Asc(Letter) > 47 And Asc(Letter) < 58 Or Asc(Letter) > 64 And Asc(Letter) < 91 Or Asc(Letter) > 96 And Asc(Letter) < 123 Then
                Else
                    ValidData = False
                    MessageLabel2.Visible = True
                    MessageLabel2.Text = "Password characters not valid"
                End If
            Next

            If NameLength < 3 Or NameLength > 10 Then
                ValidData = False
                MessageLabel2.Visible = True
                MessageLabel2.Text = "Invalid name length"
            End If

            If PassBox.Text <> ReEnterPassBox.Text Then
                MessageLabel2.Visible = True
                MessageLabel2.Text = "Passwords don't match"
                ValidData = False
            End If

            If ValidData = True Then

                Dim SR As New StreamReader(MainMenu.Locations & "UserData.txt")

                While Not SR.EndOfStream
                    FileName = SR.ReadLine
                    If FileName = UserNameBox.Text Then
                        SameUserName = True
                    End If
                    SR.ReadLine()
                    SR.ReadLine()
                End While

                SR.Close()
                SR.Dispose()

                If SameUserName = False Then
                    Dim SW As New StreamWriter(MainMenu.Locations & "UserData.txt", True)
                    SW.WriteLine(UserNameBox.Text)
                    SW.WriteLine(PassBox.Text)
                    SW.WriteLine(0)
                    SW.Close()
                    SW.Dispose()
                    SignInButton.Text = "Sign In"
                    UserNameBox.Text = ""
                    PassBox.Text = ""
                    ReEnterPassBox.Text = ""
                    RegisterButton.Visible = True
                    ReEnterPass.Visible = False
                    ReEnterPassBox.Visible = False
                    PassBox.BackColor = Colour
                    RegisterButton.Text = "Register"

                    MessageLabel.Visible = False
                    MessageLabel2.Visible = False
                Else
                    MessageLabel2.Visible = True
                    MessageLabel2.Text = "Username already taken"
                End If
            End If
        Else
            Timer1.Stop()
            Dim SR As New StreamReader(MainMenu.Locations & "UserData.txt")

            While Not SR.EndOfStream
                If UserNameBox.Text = SR.ReadLine And PassBox.Text = SR.ReadLine Then
                    MainMenu.Show()
                    MainMenu.UserName = UserNameBox.Text
                    Me.Hide()
                End If
                SR.ReadLine()
            End While
            SR.Close()
            SR.Dispose()

        End If
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click

        If RegisterButton.Text = "Register" Then
            ReEnterPass.Visible = True
            ReEnterPassBox.Visible = True
            If SignInButton.Text = "Sign In" Then
                Timer1.Start()
                SignInButton.Text = "Done"
                UserNameBox.Text = ""
                PassBox.Text = ""
                ReEnterPassBox.Text = ""
            Else
                SignInButton.Text = "Sign In"
            End If
            RegisterButton.Text = "Cancel"
        Else
            PassBox.BackColor = Colour
            RegisterButton.Text = "Register"
            ReEnterPass.Visible = False
            ReEnterPassBox.Visible = False

            SignInButton.Text = "Sign In"
            UserNameBox.Text = ""
            PassBox.Text = ""
            ReEnterPassBox.Text = ""
        End If
    End Sub

    Sub CheckPassword()

        Password = PassBox.Text

        PasswordStrength = 0
        Number = False
        UpperCase = False
        LowerCase = False

        For Each x As Char In Password
            If Asc(x) > 47 And Asc(x) < 58 Then
                Number = True
            End If
            If Asc(x) > 64 And Asc(x) < 91 Then
                UpperCase = True
            End If
            If Asc(x) > 96 And Asc(x) < 123 Then
                LowerCase = True
            End If
        Next

        If Number = True Then PasswordStrength += 1
        If UpperCase = True Then PasswordStrength += 1
        If LowerCase = True Then PasswordStrength += 1

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If SignInButton.Text = "Done" Then
            CheckPassword()

            Select Case PasswordStrength
                Case 1
                    MessageLabel.Visible = True
                    MessageLabel.Text = "Weak password"
                    PassBox.BackColor = Color.IndianRed
                Case 2
                    MessageLabel.Visible = True
                    MessageLabel.Text = "Medium password"
                    PassBox.BackColor = Color.Yellow
                Case 3
                    MessageLabel.Visible = True
                    MessageLabel.Text = "Strong password"
                    PassBox.BackColor = Color.Green
            End Select
        End If

    End Sub

    Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each Component In Controls
            Component.ForeColor = MainMenu.FontColour
        Next
        Me.BackColor = MainMenu.BackColour
        SignInButton.BackColor = MainMenu.ButtonColour
        SignInButton.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        SignInButton.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour

        RegisterButton.BackColor = MainMenu.ButtonColour
        RegisterButton.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        RegisterButton.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour

    End Sub

End Class