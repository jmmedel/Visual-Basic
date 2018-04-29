

Public Class Form1
    Dim key As Integer
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As System.Windows.Forms.Keys) As Short
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For i = 1 To 255
            key = 0
            key = GetAsyncKeyState(i)
            If key = -32767 Then
                TextBox1.Text &= Chr(i)
            End If
        Next i
    End Sub
End Class