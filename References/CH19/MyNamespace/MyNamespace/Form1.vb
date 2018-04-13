Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PictureBox1 is a Windows Forms "PictureBox" control
        'MyCustomImage is the name of the new custom image
        Me.PictureBox1.Image = My.Resources.MyCustomImage
    End Sub
End Class