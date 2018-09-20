Imports System.Threading
Imports System.Threading.Tasks



Public Class Form1
    Private myTimer As System.Threading.Timer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label1.Text = myTimer

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myCallback As New System.Threading.TimerCallback(AddressOf Task1)

        myTimer = New System.Threading.Timer(myCallback, Nothing, 100, 10000)

    End Sub


    Private Sub Task1(ByVal state As Object)

        Try

            Label1.Left -= 1

            If Label1.Right <= Me.Left Then

                Label1.Left = Me.Right

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

End Class
