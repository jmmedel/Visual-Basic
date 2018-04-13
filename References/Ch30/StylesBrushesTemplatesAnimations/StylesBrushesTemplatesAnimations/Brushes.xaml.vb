Imports System.Windows.Media
Class MainWindow

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub BrushesInCode()

        Dim rect As New Rectangle

        Dim scb As New SolidColorBrush(Colors.Red)
        rect.Fill = scb


        Dim lgb As New LinearGradientBrush
        lgb.GradientStops.Add(New GradientStop With {.Offset = 0,
                                                     .Color = Colors.Red})
        lgb.GradientStops.Add(New GradientStop With {.Offset = 0,
                                                     .Color = Colors.Yellow})
        lgb.GradientStops.Add(New GradientStop With {.Offset = 0,
                                                     .Color = Colors.Orange})
        'rect is a Rectangle instance
        rect.Fill = lgb

        Dim ragb As New RadialGradientBrush
        ragb.GradientStops.Add(New GradientStop With {.Offset = 0,
                                                      .Color = Colors.Red})
        ragb.GradientStops.Add(New GradientStop With {.Offset = 0,
                                                      .Color = Colors.Yellow})
        ragb.GradientStops.Add(New GradientStop With {.Offset = 0,
                                                      .Color = Colors.Orange})
        rect.Fill = ragb

        Dim myButton As New Button
        Dim imgb As New ImageBrush
        imgb.ImageSource = New BitmapImage(New Uri("/StylesBrushesTemplatesAnimations;component/Images/Avatar.jpg",
                                                   UriKind.Relative))
        myButton.Background = imgb
    End Sub
End Class
