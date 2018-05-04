Public Class frmDirectoryAssistance

  Dim employees() As String = IO.File.ReadAllLines("Employees.txt")

  Private Sub DisplayNames()
    Dim query = From line In employees
                Let lastName As String = line.Split(","c)(0)
                Let firstName As String = line.Split(","c)(1)
                Let extension As String = line.Split(","c)(2)
                Let code As String = GetCode(lastName, firstName)
                Where code = txtCode.Text
                Select firstName, lastName, extension

    If query.Count() = 0 Then
      lstOutput.Items.Add("The name was not found")
    Else 
      For Each employee In query
        lstOutput.Items.Add(employee.firstName + ", " + employee.lastName + " ext:" + employee.extension)
      Next
    End If
  End Sub

  Private Function GetCode(last As String, first As String) As String
    Dim word, code As String
    word = (last.Substring(0,3) & first.Substring(0,1)).ToUpper()
    For i As Integer = 0 To 3
      code += Translate(word.Substring(i,1)).ToString()
    Next

    Return code
  End Function

  Private Function Translate(letter As String) As Integer
    Select Case letter
      Case "A", "B", "C"
        Return 1
      Case "D", "E", "F"
        Return 2
      Case "G", "H", "I"
        Return 3
      Case "J", "K", "L"
        Return 4
      Case "M", "N", "O"
        Return 5
      Case "P", "Q", "R", "S"
        Return 6
      Case "T", "U", "V"
        Return 7
      Case "W", "X", "Y", "Z"
        Return 8
    End Select
  End Function

  Private Sub frmDirectoryAssistance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

  End Sub

  Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
    If txtCode.Text.Length < 4 Then
      txtCode.Text += "1"
      If txtCode.Text.Length = 4 Then
        DisplayNames()
      End If
    End If
  End Sub

  Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
    If txtCode.Text.Length < 4 Then
      txtCode.Text += "2"
      If txtCode.Text.Length = 4 Then
        DisplayNames()
      End If
    End If
  End Sub

  Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
    If txtCode.Text.Length < 4 Then
      txtCode.Text += "3"
      If txtCode.Text.Length = 4 Then
        DisplayNames()
      End If
    End If
  End Sub

  Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
    If txtCode.Text.Length < 4 Then
      txtCode.Text += "4"
      If txtCode.Text.Length = 4 Then
        DisplayNames()
      End If
    End If
  End Sub

  Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
    If txtCode.Text.Length < 4 Then
      txtCode.Text += "5"
      If txtCode.Text.Length = 4 Then
        DisplayNames()
      End If
    End If
  End Sub

  Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
    If txtCode.Text.Length < 4 Then
      txtCode.Text += "6"
      If txtCode.Text.Length = 4 Then
        DisplayNames()
      End If
    End If
  End Sub

  Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
    If txtCode.Text.Length < 4 Then
      txtCode.Text += "7"
      If txtCode.Text.Length = 4 Then
        DisplayNames()
      End If
    End If
  End Sub

  Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
    If txtCode.Text.Length < 4 Then
      txtCode.Text += "8"
      If txtCode.Text.Length = 4 Then
        DisplayNames()
      End If
    End If
  End Sub

  Private Sub btnAnother_Click(sender As Object, e As EventArgs) Handles btnAnother.Click
    lstOutput.Items.Clear()
    txtCode.Text = ""
  End Sub
End Class
