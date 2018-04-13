Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.CurrentThread.CurrentCulture = New Globalization.CultureInfo("it")
        Threading.Thread.CurrentThread.CurrentUICulture = New Globalization.CultureInfo("it")
        Me.Button1.Text = My.Resources.LocalizedButton
        Me.Label1.Text = My.Resources.LocalizedLabel
    End Sub
End Class
