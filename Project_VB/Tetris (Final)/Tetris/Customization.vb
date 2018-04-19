Imports System.IO

Public Class Customization

    Dim HighScore As Integer = 0
    Dim FileName As String
    Dim FileScore As Integer

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click

        If MainMenu.ComeFromPlaySettings = True Then
            Playsettings.Show()
        Else
            MainMenu.Show()
        End If

        Me.Close()

    End Sub

    Private Sub Customization_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each Component In Controls
            Component.ForeColor = MainMenu.FontColour
        Next

        Colours()

        ColourPictureBox1.BackColor = MainMenu.BackColour
        ColourPictureBox2.BackColor = MainMenu.ButtonColour
        ColourPictureBox3.BackColor = MainMenu.FontColour

        If MainMenu.Male = True Then
            DefaultThemeBox.BackColor = MainMenu.ColourConvert.ConvertFromString("64, 64, 64")
        Else
            DefaultThemeBox.BackColor = Color.PowderBlue
        End If

        Dim SR As New StreamReader(MainMenu.Locations & "UserData.txt")

        While Not SR.EndOfStream
            FileName = SR.ReadLine
            SR.ReadLine()
            FileScore = SR.ReadLine

            If FileName = MainMenu.UserName Then
                HighScore = FileScore
            End If

        End While

        SR.Close()
        SR.Dispose()

        If HighScore > 1000 Then LandscapeTheme.Enabled = True
        If HighScore > 5000 Then SpaceTheme.Enabled = True
        If HighScore > 10000 Then TetrisTheme.Enabled = True
        'need to check all 3 so no select case

    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        Playsettings.Close()
        If BackColourBox.Text = "DarkGray" Then
            MainMenu.BackColour = MainMenu.ColourConvert.ConvertFromString("64, 64, 64")
            MainMenu.TetrisComponentBackColour = MainMenu.ColourConvert.ConvertFromString("64, 64, 64")
        ElseIf BackColourBox.Text <> "" Then
            MainMenu.BackColour = MainMenu.ColourConvert.ConvertFromString(BackColourBox.Text)
            MainMenu.TetrisComponentBackColour = MainMenu.ColourConvert.ConvertFromString(BackColourBox.Text)
        End If

        Select Case BackColourBox.Text
            Case "Black"
                MainMenu.TetrisBackColour = MainMenu.ColourConvert.ConvertFromString("64, 64, 64")
                MainMenu.InstructionsColour = MainMenu.ColourConvert.ConvertFromString("64, 64, 64")
            Case "Blue"
                MainMenu.TetrisBackColour = Color.DarkBlue
                MainMenu.InstructionsColour = Color.RoyalBlue
            Case "DarkGray"
                MainMenu.TetrisBackColour = MainMenu.ColourConvert.ConvertFromString("55, 55, 55")
                MainMenu.InstructionsColour = MainMenu.ColourConvert.ConvertFromString("73, 73, 73")
            Case "Gray"
                MainMenu.TetrisBackColour = Color.DimGray
                MainMenu.InstructionsColour = Color.DarkGray
            Case "Green"
                MainMenu.TetrisBackColour = Color.DarkGreen
                MainMenu.InstructionsColour = Color.Lime
            Case "LightGreen"
                MainMenu.TetrisBackColour = Color.Lime
                MainMenu.InstructionsColour = Color.LawnGreen
            Case "Orange"
                MainMenu.TetrisBackColour = Color.DarkOrange
                MainMenu.InstructionsColour = Color.DarkOrange
            Case "Pink"
                MainMenu.TetrisBackColour = Color.PaleVioletRed
                MainMenu.InstructionsColour = Color.PaleVioletRed
            Case "PowderBlue"
                MainMenu.TetrisBackColour = Color.MediumTurquoise
                MainMenu.InstructionsColour = Color.SkyBlue
            Case "Purple"
                MainMenu.TetrisBackColour = Color.Indigo
                MainMenu.InstructionsColour = Color.Magenta
            Case "Red"
                MainMenu.TetrisBackColour = Color.DarkRed
                MainMenu.InstructionsColour = Color.DarkRed
            Case "White"
                MainMenu.TetrisBackColour = Color.Silver
                MainMenu.InstructionsColour = Color.Silver
            Case "Yellow"
                MainMenu.TetrisBackColour = Color.Khaki
                MainMenu.InstructionsColour = Color.Khaki
        End Select



        If ButtonColourBox.Text = "DarkGray" Then
            MainMenu.ButtonColour = MainMenu.ColourConvert.ConvertFromString("64, 64, 64")
        ElseIf ButtonColourBox.Text <> "" Then
            MainMenu.ButtonColour = MainMenu.ColourConvert.ConvertFromString(ButtonColourBox.Text)
        End If

        Select Case ButtonColourBox.Text
            Case "Black"
                MainMenu.ButtonOverColour = Color.Gray
                MainMenu.ButtonDownColour = Color.DimGray
            Case "Blue"
                MainMenu.ButtonOverColour = Color.CornflowerBlue
                MainMenu.ButtonDownColour = Color.DarkBlue
            Case "DarkGray"
                MainMenu.ButtonOverColour = Color.DimGray
                MainMenu.ButtonDownColour = Color.Black
            Case "Gray"
                MainMenu.ButtonOverColour = Color.WhiteSmoke
                MainMenu.ButtonDownColour = Color.Gray
            Case "Green"
                MainMenu.ButtonOverColour = Color.LimeGreen
                MainMenu.ButtonDownColour = Color.ForestGreen
            Case "LightGreen"
                MainMenu.ButtonOverColour = Color.LawnGreen
                MainMenu.ButtonDownColour = Color.LimeGreen
            Case "Orange"
                MainMenu.ButtonOverColour = Color.DarkOrange
                MainMenu.ButtonDownColour = Color.NavajoWhite
            Case "Pink"
                MainMenu.ButtonOverColour = Color.PaleVioletRed
                MainMenu.ButtonDownColour = Color.LightPink
            Case "PowderBlue"
                MainMenu.ButtonOverColour = Color.DeepSkyBlue
                MainMenu.ButtonDownColour = Color.SkyBlue
            Case "Purple"
                MainMenu.ButtonOverColour = Color.Magenta
                MainMenu.ButtonDownColour = Color.DarkMagenta
            Case "Red"
                MainMenu.ButtonOverColour = Color.DarkRed
                MainMenu.ButtonDownColour = Color.Firebrick
            Case "White"
                MainMenu.ButtonOverColour = Color.DarkGray
                MainMenu.ButtonDownColour = Color.LightGray
            Case "Yellow"
                MainMenu.ButtonOverColour = Color.DarkKhaki
                MainMenu.ButtonDownColour = Color.LightGoldenrodYellow
        End Select



        MainMenu.FontColour = MainMenu.ColourConvert.ConvertFromString(FontColourBox.Text)

        For Each Component In Controls
            Component.ForeColor = MainMenu.ColourConvert.ConvertFromString(FontColourBox.Text)
        Next

        For Each Component In MainMenu.Controls
            Component.ForeColor = MainMenu.ColourConvert.ConvertFromString(FontColourBox.Text)
        Next

        For Each Component In Playsettings.Controls
            Component.ForeColor = MainMenu.ColourConvert.ConvertFromString(FontColourBox.Text)
        Next


        If DefaultTheme.Checked = True Then
            MainMenu.BackgroundImageLoc = ""
            If MainMenu.Male = True Then
                MainMenu.BackColour = MainMenu.ColourConvert.ConvertFromString("64, 64, 64")
                MainMenu.TetrisComponentBackColour = MainMenu.ColourConvert.ConvertFromString("64, 64, 64")
                MainMenu.TetrisBackColour = MainMenu.ColourConvert.ConvertFromString("55, 55, 55")
                MainMenu.FontColour = Color.Black
                For Each Component In Controls
                    Component.ForeColor = Color.Black
                Next
                For Each Component In MainMenu.Controls
                    Component.ForeColor = Color.Black
                Next
                For Each Component In Playsettings.Controls
                    Component.ForeColor = Color.Black
                Next
                MainMenu.ButtonColour = MainMenu.ColourConvert.ConvertFromString("180, 0, 0")
                MainMenu.ButtonOverColour = Color.DarkRed
                MainMenu.ButtonDownColour = Color.Firebrick
            Else
                MainMenu.BackColour = Color.PowderBlue
                MainMenu.TetrisComponentBackColour = Color.MediumTurquoise
                MainMenu.TetrisBackColour = Color.PowderBlue
                MainMenu.FontColour = Color.Black
                For Each Component In Controls
                    Component.ForeColor = Color.Black
                Next
                For Each Component In MainMenu.Controls
                    Component.ForeColor = Color.Black
                Next
                For Each Component In Playsettings.Controls
                    Component.ForeColor = Color.Black
                Next
                MainMenu.ButtonColour = Color.LightGreen
                MainMenu.ButtonOverColour = Color.LawnGreen
                MainMenu.ButtonDownColour = Color.LimeGreen
            End If
        End If

        If LandscapeTheme.Checked = True Then
            MainMenu.FontColour = Color.White
            For Each Component In Controls
                Component.ForeColor = Color.White
            Next
            For Each Component In MainMenu.Controls
                Component.ForeColor = Color.White
            Next
            For Each Component In Playsettings.Controls
                Component.ForeColor = Color.White
            Next

            MainMenu.ButtonColour = Color.LightGreen
            MainMenu.ButtonOverColour = Color.LawnGreen
            MainMenu.ButtonDownColour = Color.LimeGreen

            MainMenu.TetrisComponentBackColour = Color.Transparent
            MainMenu.BackgroundImage = Image.FromFile(MainMenu.Locations & "Landscape.jpg")
            MainMenu.BackgroundImageLayout = ImageLayout.Stretch
            MainMenu.BackgroundImageLoc = MainMenu.Locations & "Landscape.jpg"
        End If

        If SpaceTheme.Checked = True Then
            MainMenu.FontColour = Color.White
            For Each Component In Controls
                Component.ForeColor = Color.White
            Next
            For Each Component In MainMenu.Controls
                Component.ForeColor = Color.White
            Next
            For Each Component In Playsettings.Controls
                Component.ForeColor = Color.White
            Next

            MainMenu.ButtonColour = Color.Blue
            MainMenu.ButtonOverColour = Color.CornflowerBlue
            MainMenu.ButtonDownColour = Color.DarkBlue
            MainMenu.TetrisComponentBackColour = Color.Transparent
            MainMenu.BackgroundImage = Image.FromFile(MainMenu.Locations & "Space.jpg")
            MainMenu.BackgroundImageLoc = MainMenu.Locations & "Space.jpg"
            MainMenu.BackgroundImageLayout = ImageLayout.None
        End If

        If TetrisTheme.Checked = True Then
            MainMenu.FontColour = Color.White
            For Each Component In Controls
                Component.ForeColor = Color.White
            Next
            For Each Component In MainMenu.Controls
                Component.ForeColor = Color.White
            Next
            For Each Component In Playsettings.Controls
                Component.ForeColor = Color.White
            Next

            MainMenu.TetrisComponentBackColour = Color.Transparent
            MainMenu.BackgroundImage = Image.FromFile(MainMenu.Locations & "MainMenuTetrisTheme.jpg")
            MainMenu.BackgroundImageLoc = MainMenu.Locations & "TetrisTheme.png"
            MainMenu.BackgroundImageLayout = ImageLayout.Stretch
        End If

        MainMenu.BackColor = MainMenu.BackColour
        MainMenu.PlayButton.BackColor = MainMenu.ButtonColour
        MainMenu.CustomizationButton.BackColor = MainMenu.ButtonColour
        MainMenu.ProgressButton.BackColor = MainMenu.ButtonColour
        MainMenu.InstructionsButton.BackColor = MainMenu.ButtonColour
        MainMenu.SpeakerButton.BackColor = MainMenu.ButtonColour
        MainMenu.RandSongButton.BackColor = MainMenu.ButtonColour
        MainMenu.SignOutButton.BackColor = MainMenu.ButtonColour
        MainMenu.ExitProgram.BackColor = MainMenu.ButtonColour

        MainMenu.PlayButton.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        MainMenu.CustomizationButton.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        MainMenu.ProgressButton.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        MainMenu.InstructionsButton.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        MainMenu.RandSongButton.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        MainMenu.SpeakerButton.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        MainMenu.SignOutButton.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        MainMenu.ExitProgram.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour

        MainMenu.PlayButton.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour
        MainMenu.CustomizationButton.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour
        MainMenu.ProgressButton.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour
        MainMenu.InstructionsButton.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour
        MainMenu.RandSongButton.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour
        MainMenu.SpeakerButton.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour
        MainMenu.SignOutButton.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour
        MainMenu.ExitProgram.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour

        Colours()

        If MainMenu.FontColour = Color.White Or MainMenu.FontColour = Color.Pink Or MainMenu.FontColour = Color.Yellow Then
            BackColourBox.BackColor = Color.Black
            ButtonColourBox.BackColor = Color.Black
            FontColourBox.BackColor = Color.Black
        Else
            BackColourBox.BackColor = Color.White
            ButtonColourBox.BackColor = Color.White
            FontColourBox.BackColor = Color.White
        End If

    End Sub

    Sub Colours()

        Me.BackColor = MainMenu.BackColour
        Save.BackColor = MainMenu.ButtonColour
        Save.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        Save.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour

        Back.BackColor = MainMenu.ButtonColour
        Back.FlatAppearance.MouseOverBackColor = MainMenu.ButtonOverColour
        Back.FlatAppearance.MouseDownBackColor = MainMenu.ButtonDownColour

        For Each Component In MainMenu.Controls
            Component.ForeColor = MainMenu.FontColour
        Next
    End Sub

    Private Sub BackColourBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BackColourBox.SelectedIndexChanged
        If BackColourBox.Text = "DarkGray" Then
            ColourPictureBox1.BackColor = MainMenu.ColourConvert.ConvertFromString("64, 64, 64")
        Else
            ColourPictureBox1.BackColor = MainMenu.ColourConvert.ConvertFromString(BackColourBox.Text)
        End If
    End Sub

    Private Sub ButtonColourBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ButtonColourBox.SelectedIndexChanged
        If ButtonColourBox.Text = "DarkGray" Then
            ColourPictureBox2.BackColor = MainMenu.ColourConvert.ConvertFromString("64, 64, 64")
        Else
            ColourPictureBox2.BackColor = MainMenu.ColourConvert.ConvertFromString(ButtonColourBox.Text)
        End If
    End Sub

    Private Sub FontColourBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FontColourBox.SelectedIndexChanged
        ColourPictureBox3.BackColor = MainMenu.ColourConvert.ConvertFromString(FontColourBox.Text)
    End Sub

End Class