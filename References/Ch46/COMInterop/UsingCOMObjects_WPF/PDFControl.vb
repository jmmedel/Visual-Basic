Public Class PDFControl


    Private Sub PDFControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.AxAcroPDF1.LoadFile("C:\Users\Alessandro\Documents\VisualStudioThemeUpdate.pdf")
    End Sub

    Private Sub AxAcroPDF1_OnError(sender As Object, e As EventArgs) Handles AxAcroPDF1.OnError
        MessageBox.Show("An error has occurred while loading the document")
    End Sub
End Class
