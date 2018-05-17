
'VB.Net -ColorDialog Control
'The ColorDialog control Class represents a common dialog box that displays available colors along With controls that enable the user To define custom colors. It lets the user Select a color.

'The main Property Of the ColorDialog control Is Color, which returns a Color Object.

'Following Is the Color dialog box
'    Properties of the ColorDialog Control
'The following are some Of the commonly used properties Of the ColorDialog control

'S.N  Property	Description
'1   AllowFullOpen	Gets Or sets a value indicating whether the user can use the dialog box to define custom colors.
'2   AnyColor	Gets Or sets a value indicating whether the dialog box displays all available colors in the set of basic colors.
'3   CanRaiseEvents	Gets a value indicating whether the component can raise an event.
'4   Color	Gets Or sets the color selected by the user.
'5   CustomColors	Gets Or sets the set of custom colors shown in the dialog box.
'6   FullOpen	Gets Or sets a value indicating whether the controls used to create custom colors are visible when the dialog box Is opened
'7   ShowHelp	Gets Or sets a value indicating whether a Help button appears in the color dialog box.
'8   SolidColorOnly	Gets Or sets a value indicating whether the dialog box will restrict users to selecting solid colors only.
'Methods of the ColorDialog Control
'The following are some Of the commonly used methods Of the ColorDialog control

'S.N  Method Name & Description
'1   
'Reset

'Resets all options To their Default values, the last selected color To black, And the custom colors To their Default values.

'2   
'RunDialog

'When overridden in a derived class, specifies a common dialog box.

'3   
'ShowDialog

'Runs a common dialog box With a Default owner.

'Events of the ColorDialog Control
'The following are some Of the commonly used events Of the ColorDialog control

'S.N  Event	Description
'1   HelpRequest	Occurs when the user clicks the Help button on a common dialog box.
'Example
'In this example, let's change the forecolor of a label control using the color dialog box. Take the following steps:

'Drag And drop a label control, a button control And a ColorDialog control on the form.

'Set the Text Property Of the label And the button control To 'Give me a new Color' and 'Change Color', respectively.

'Change the font Of the label As per your likings.

'Double-click the Change Color button And modify the code of the Click event.


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Label1.ForeColor = ColorDialog1.Color
        End If
    End Sub
End Class
