Public Class frmBachelorDegrees

  Dim input() as String = IO.File.ReadAllLines("Degrees.txt")
  Private Sub btnTable1_Click(sender As Object, e As EventArgs) Handles btnTable1.Click
    
    '-------------------------------------------------------
    'DISPLAY FORMATTED DATA IN GRID VIEW ORDERED BY FIELD OF STUDY
    '-------------------------------------------------------

    Dim query = From record In input
                Let field as String = record.Split(","c)(0)
                Let year81 as String = record.Split(","c)(1)
                Let year10 as String = record.Split(","c)(2)
                Order By field
                Select field, year81, year10

    dgvOutput.DataSource = query.ToList()
    dgvOutput.Columns(0).HeaderText = "Field of Study"
    dgvOutput.Columns(1).HeaderText = "Year 1981"
    dgvOutput.Columns(2).HeaderText = "Year 2010"

  End Sub

    '-------------------------------------------------------
    'DISPLAY FORMATTED DATA IN GRID VIEW. 
    'CALCULATE PERCENTAGE CHANGE
    'DATA IS DISPLAYED BY PERCENTAGE CHANGE IN DESC. ORDER
    '-------------------------------------------------------
  Private Sub btnTable2_Click(sender As Object, e As EventArgs) Handles btnTable2.Click
    Dim query = From record In input
                Let field as String = record.Split(","c)(0)
                Let year81 as Integer = CInt(record.Split(","c)(1))
                Let year10 as Integer = CInt(record.Split(","c)(2))
                Let change As Double = (year10 - year81) / year81
                Let changeOut as String = FormatPercent(change,2)
                Order By change Descending
                Select field, changeOut

    dgvOutput.DataSource = query.ToList()
    dgvOutput.Columns(0).HeaderText = "Field of Study"
    dgvOutput.Columns(1).HeaderText = "% of change"
  End Sub

  Private Function GetChart(year10 As Integer) As String
    Dim output as String
    Dim numOfDots as Integer = 0
    Dim dots as String

    numOfDots = Cint(Math.Round(year10,0) / 10000)

    For i as Integer = 1 to numOfDots
      dots += "."
    Next

    output = dots & "  " & year10.ToString("N0")
    return output
  End Function

  Private Sub btnTable3_Click(sender As Object, e As EventArgs) Handles btnTable3.Click
    Dim query = From record In input
                Let field as String = record.Split(","c)(0)
                Let year10 as Integer = CInt(record.Split(","c)(2))
                Let chart as String = GetChart(year10)
                Order By year10 Ascending
                Select field, chart

    dgvOutput.DataSource = query.ToList()
    dgvOutput.Columns(0).HeaderText = "Field of Study"
    dgvOutput.Columns(1).HeaderText = "Number of Degrees in 2010"
  End Sub

  Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
    End
  End Sub
End Class
