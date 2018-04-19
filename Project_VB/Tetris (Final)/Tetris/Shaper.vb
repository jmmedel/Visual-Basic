Public Class Shaper

    Inherits ShapeProperties

    Sub New()
        If LosingScreen.FromMainMenu = False Then
            Select Case Tetris.NoOfBlocks
                Case 1
                    Tetris.TopLoc = -80
                    Tetris.LeftLoc = 280
                Case 2
                    Tetris.TopLoc = -80
                    Tetris.LeftLoc = 240
                Case 3
                    Tetris.TopLoc = -40
                    Tetris.LeftLoc = 240
            End Select

            If Tetris.PowerUp = True Then
                Tetris.NewBlock = New ShapeProperties
                Tetris.NewBlock.ImageLocation = MainMenu.Locations & "PowerUp.png"
            Else
                Tetris.NewBlock = New ShapeProperties
                Tetris.NewBlock.BackColor = Color.Silver
            End If

            Tetris.NewBlock.Top = Tetris.TopLoc
            Tetris.NewBlock.Left = Tetris.LeftLoc
            Tetris.Controls.Add(Tetris.NewBlock)
            Tetris.FallingBlocks.Add(Tetris.NewBlock)
            Tetris.AllBlocks.Add(Tetris.NewBlock)
            Tetris.IsShapeFalling = True
            Tetris.HighestRight = 280
            Tetris.HighestLeft = 240
        Else
            Select Case MainMenu.MMNoOfBlocks
                Case 1
                    MainMenu.TopLoc = -80
                    MainMenu.LeftLoc = MainMenu.RandomPos + 40
                Case 2
                    MainMenu.TopLoc = -80
                    MainMenu.LeftLoc = MainMenu.RandomPos
                Case 3
                    MainMenu.TopLoc = -40
                    MainMenu.LeftLoc = MainMenu.RandomPos
            End Select
            MainMenu.MMNewBlock = New ShapeProperties
            MainMenu.MMNewBlock.BackColor = Color.Silver
            MainMenu.MMNewBlock.Top = MainMenu.TopLoc
            MainMenu.MMNewBlock.Left = MainMenu.LeftLoc
            MainMenu.Controls.Add(MainMenu.MMNewBlock)
            MainMenu.MMFallingBlocks.Add(MainMenu.MMNewBlock)
        End If

    End Sub

End Class
