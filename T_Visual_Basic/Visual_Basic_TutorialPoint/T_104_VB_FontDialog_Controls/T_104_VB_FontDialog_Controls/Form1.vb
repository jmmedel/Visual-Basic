'VB.Net -FontDialog Control
'It prompts the user To choose a font from among those installed On the local computer And lets the user Select the font, font size, And color. It returns the Font And Color objects.

'Following Is the Font dialog box

'By Default, the Color ComboBox Is Not shown on the Font dialog box. You should set the ShowColor property of the FontDialog control to be True.

'Properties of the FontDialog Control
'The following are some Of the commonly used properties Of the FontDialog control

'S.N  Property	Description
'1   AllowSimulations	Gets Or sets a value indicating whether the dialog box allows graphics device interface (GDI) font simulations.
'2   AllowVectorFonts	Gets Or sets a value indicating whether the dialog box allows vector font selections.
'3   AllowVerticalFonts	Gets Or sets a value indicating whether the dialog box displays both vertical And horizontal fonts, Or only horizontal fonts.
'4   Color	Gets Or sets the selected font color.
'5   FixedPitchOnly	Gets Or sets a value indicating whether the dialog box allows only the selection of fixed-pitch fonts.
'6   Font	Gets Or sets the selected font.
'7   FontMustExist	Gets Or sets a value indicating whether the dialog box specifies an error condition if the user attempts to select a font Or style that does Not exist.
'8   MaxSize	Gets Or sets the maximum point size a user can select.
'9   MinSize	Gets Or sets the minimum point size a user can select.
'10  ScriptsOnly	Gets Or sets a value indicating whether the dialog box allows selection of fonts for all non-OEM And Symbol character sets, as well as the ANSI character set.
'11  ShowApply	Gets Or sets a value indicating whether the dialog box contains an Apply button.
'12  ShowColor	Gets Or sets a value indicating whether the dialog box displays the color choice.
'13  ShowEffects	Gets Or sets a value indicating whether the dialog box contains controls that allow the user to specify strikethrough, underline, And text color options.
'14  ShowHelp	Gets Or sets a value indicating whether the dialog box displays a Help button.
'Methods of the FontDialog Control
'The following are some Of the commonly used methods Of the FontDialog control

'S.N  Method Name & Description
'1   
'Reset

'Resets all options To their Default values.

'2   
'RunDialog

'When overridden in a derived class, specifies a common dialog box.

'3   
'ShowDialog

'Runs a common dialog box With a Default owner.

'Events of the FontDialog Control
'The following are some Of the commonly used events Of the FontDialog control

'S.N  Event	Description
'1   Apply	Occurs when the Apply button on the font dialog box Is clicked.
'Example
'In this example, let's change the font and color of the text from a rich text control using the Font dialog box. Take the following steps:

'Drag And drop a RichTextBox control, a Button control And a FontDialog control on the form.

'Set the Text Property Of the button control To 'Change Font'.

'Set the ShowColor Property Of the FontDialog control To True.

'Double-click the Change Color button And modify the code of the Click event


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FontDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            RichTextBox1.ForeColor = FontDialog1.Color
            RichTextBox1.Font = FontDialog1.Font
        End If

    End Sub
End Class
