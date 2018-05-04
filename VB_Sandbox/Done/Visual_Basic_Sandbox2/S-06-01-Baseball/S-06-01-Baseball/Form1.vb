Public Class frmBaseball
  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Dim newFile as IO.StreamWriter = IO.File.CreateText("ALE2.txt")

    Dim query = From data In IO.File.ReadAllLines("ALE.txt")
                Let team As String = data.ToString().Split(","c)(0)
                Let wins as Integer = CInt(data.ToString().Split(","c)(1))
                Let loses as Integer = CInt(data.ToString().Split(","c)(2))
                Let percentage as Double = Cdbl(wins / (wins + loses))
                Order By percentage Descending
                Select team & "," & wins & "," & loses & "," & FormatNumber(percentage.ToString(),3)

    For i as Integer = 0 To query.Count - 1
      newFile.WriteLine(query(i))
    Next

    newFile.Close()
  End Sub
End Class
