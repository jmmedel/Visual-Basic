
'VB.Net -Dialog Boxes
'There are many built-In dialog boxes To be used In Windows forms For various tasks Like opening And saving files, printing a page, providing choices For colors, fonts, page setup, etc., To the user Of an application. These built-In dialog boxes reduce the developer's time and workload.

'All of these dialog box control classes inherit from the CommonDialog class And override the RunDialog() function of the base class to create the specific dialog box.

'The RunDialog() Function Is automatically invoked When a user Of a dialog box calls its ShowDialog() Function.

'The ShowDialog method Is used To display all the dialog box controls at run-time. It returns a value Of the type Of DialogResult enumeration. The values Of DialogResult enumeration are

'Abort -returns DialogResult.Abort value, when user clicks an Abort button.

'Cancel-returns DialogResult.Cancel, when user clicks a Cancel button.

'Ignore -returns DialogResult.Ignore, when user clicks an Ignore button.

'No -returns DialogResult.No, when user clicks a No button.

'None -returns nothing And the dialog box continues running.

'OK -returns DialogResult.OK, when user clicks an OK button

'Retry -returns DialogResult.Retry , when user clicks an Retry button

'Yes -returns DialogResult.Yes, when user clicks an Yes button

'The following diagram shows the common dialog Class inheritance

'All these above-mentioned classes have corresponding controls that could be added from the Toolbox during design time. You can include relevant functionality Of these classes To your application, either by instantiating the Class programmatically Or by Using relevant controls.

'When you double click any of the dialog controls in the toolbox Or drag the control onto the form, it appears in the Component tray at the bottom of the Windows Forms Designer, they do Not directly show up on the form.

'The following table lists the commonly used dialog box controls. Click the following links To check their detail

'S.N.Control & Description
'1   
'ColorDialog

'It represents a common dialog box that displays available colors along With controls that enable the user To define custom colors.

'2   
'FontDialog

'It prompts the user To choose a font from among those installed On the local computer And lets the user Select the font, font size, And color.

'3   
'OpenFileDialog

'It prompts the user To open a file And allows the user To Select a file To open.

'4   
'SaveFileDialog

'It prompts the user To Select a location For saving a file And allows the user To specify the name Of the file To save data.

'5   
'PrintDialog

'It lets the user To print documents by selecting a printer And choosing which sections Of the document To print from a Windows Forms application.



Public Class Form1

End Class
