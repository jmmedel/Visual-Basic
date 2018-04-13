Public Class Styles

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dim buttonStyle As New Style
        buttonStyle.TargetType = GetType(Button)
        buttonStyle.Setters.Add(New Setter With {.Property = Button.WidthProperty,
                                                 .Value = "100"})

        'Button1.Style = buttonStyle
    End Sub
End Class
