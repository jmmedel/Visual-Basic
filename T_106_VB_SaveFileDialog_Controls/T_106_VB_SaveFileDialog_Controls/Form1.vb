
'VB.Net -SaveFileDialog Control
'The SaveFileDialog control prompts the user To Select a location For saving a file And allows the user To specify the name Of the file To save data. The SaveFileDialog control Class Inherits from the abstract Class FileDialog.

'Following Is the Save File dialog box

'Properties of the SaveFileDialog Control
'The following are some Of the commonly used properties Of the SaveFileDialog control

'S.N  Property	Description
'1   AddExtension	Gets Or sets a value indicating whether the dialog box automatically adds an extension to a file name if the user omits the extension.
'2   CheckFileExists	Gets Or sets a value indicating whether the dialog box displays a warning if the user specifies a file name that does Not exist.
'3   CheckPathExists	Gets Or sets a value indicating whether the dialog box displays a warning if the user specifies a path that does Not exist.
'4   CreatePrompt	Gets Or sets a value indicating whether the dialog box prompts the user for permission to create a file if the user specifies a file that does Not exist.
'5   DefaultExt	Gets Or sets the default file name extension.
'6   DereferenceLinks	Gets Or sets a value indicating whether the dialog box returns the location of the file referenced by the shortcut Or whether it returns the location of the shortcut (.lnk).
'7   FileName	Gets Or sets a string containing the file name selected in the file dialog box.
'8   FileNames	Gets the file names of all selected files in the dialog box.
'9   Filter	Gets Or sets the current file name filter string, which determines the choices that appear in the "Save as file type" Or "Files of type" box in the dialog box.
'10  FilterIndex	Gets Or sets the index of the filter currently selected in the file dialog box.
'11  InitialDirectory	Gets Or sets the initial directory displayed by the file dialog box.
'12  OverwritePrompt	Gets Or sets a value indicating whether the Save As dialog box displays a warning if the user specifies a file name that already exists.
'13  RestoreDirectory	Gets Or sets a value indicating whether the dialog box restores the current directory before closing.
'14  ShowHelp	Gets Or sets a value indicating whether the Help button Is displayed in the file dialog box.
'15  SupportMultiDottedExtensions	Gets Or sets whether the dialog box supports displaying And saving files that have multiple file name extensions.
'16  Title	Gets Or sets the file dialog box title.
'17  ValidateNames	Gets Or sets a value indicating whether the dialog box accepts only valid Win32 file names.
'Methods of the SaveFileDialog Control
'The following are some Of the commonly used methods Of the SaveFileDialog control

'S.N  Method Name & Description
'1   
'OpenFile

'Opens the file With read/write permission.

'2   
'Reset

'Resets all dialog box options To their Default values.

'Example
'In this example, let's save the text entered into a rich text box by the user using the save file dialog box. Take the following steps:

'Drag And drop a Label control, a RichTextBox control, a Button control And a SaveFileDialog control on the form.

'Set the Text Property Of the label And the button control To 'We appreciate your comments' and 'Save Comments', respectively.

'Double-click the Save Comments button And modify the code of the Click event as shown

Public Class Form1

End Class
