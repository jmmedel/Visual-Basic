'VB.Net -OpenFileDialog Control
'The OpenFileDialog control prompts the user To open a file And allows the user To Select a file To open. The user can check If the file exists And Then open it. The OpenFileDialog control Class Inherits from the abstract Class FileDialog.

'If the ShowReadOnly Property Is Set To True, Then a read-only check box appears In the dialog box. You can also Set the ReadOnlyChecked Property To True, so that the read-only check box appears checked.

'Following Is the Open File dialog box

'Properties of the OpenFileDialog Control
'The following are some Of the commonly used properties Of the OpenFileDialog control

'S.N  Property	Description
'1   AddExtension	Gets Or sets a value indicating whether the dialog box automatically adds an extension to a file name if the user omits the extension.
'2   AutoUpgradeEnabled	Gets Or sets a value indicating whether this FileDialog instance should automatically upgrade appearance And behavior when running on Windows Vista.
'3   CheckFileExists	Gets Or sets a value indicating whether the dialog box displays a warning if the user specifies a file name that does Not exist.
'4   CheckPathExists	Gets Or sets a value indicating whether the dialog box displays a warning if the user specifies a path that does Not exist.
'5   CustomPlaces	Gets the custom places collection for this FileDialog instance.
'6   DefaultExt	Gets Or sets the default file name extension.
'7   DereferenceLinks	Gets Or sets a value indicating whether the dialog box returns the location of the file referenced by the shortcut Or whether it returns the location of the shortcut (.lnk).
'8   FileName	Gets Or sets a string containing the file name selected in the file dialog box.
'9   FileNames	Gets the file names of all selected files in the dialog box.
'10  Filter	Gets Or sets the current file name filter string, which determines the choices that appear in the "Save as file type" Or "Files of type" box in the dialog box.
'11  FilterIndex	Gets Or sets the index of the filter currently selected in the file dialog box.
'12  InitialDirectory	Gets Or sets the initial directory displayed by the file dialog box.
'13  Multiselect	Gets Or sets a value indicating whether the dialog box allows multiple files to be selected.
'14  ReadOnlyChecked	Gets Or sets a value indicating whether the read-only check box Is selected.
'15  RestoreDirectory	Gets Or sets a value indicating whether the dialog box restores the current directory before closing.
'16  SafeFileName	Gets the file name And extension for the file selected in the dialog box. The file name does Not include the path.
'17  SafeFileNames	Gets an array of file names And extensions for all the selected files in the dialog box. The file names do Not include the path.
'18  ShowHelp	Gets Or sets a value indicating whether the Help button Is displayed in the file dialog box.
'19  ShowReadOnly	Gets Or sets a value indicating whether the dialog box contains a read-only check box.
'20  SupportMultiDottedExtensions	Gets Or sets whether the dialog box supports displaying And saving files that have multiple file name extensions.
'21  Title	Gets Or sets the file dialog box title.
'22  ValidateNames	Gets Or sets a value indicating whether the dialog box accepts only valid Win32 file names.
'Methods of the OpenFileDialog Control
'The following are some Of the commonly used methods Of the OpenFileDialog control

'S.N  Method Name & Description
'1   
'OpenFile

'Opens the file selected by the user, With read-only permission. The file Is specified by the FileName Property.

'2   
'Reset

'Resets all options To their Default value.

'Example
'In this example, let's load an image file in a picture box, using the open file dialog box. Take the following steps:

'Drag And drop a PictureBox control, a Button control And a OpenFileDialog control on the form.

'Set the Text Property Of the button control To 'Load Image File'.

'Double-click the Load Image File button And modify the code of the Click event


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class
