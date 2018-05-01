
'VB.Net -TextBox Control
'Text box controls allow entering text On a form at runtime. By Default, it takes a Single line Of text, however, you can make it accept multiple texts And even add scroll bars To it.

'Let's create a text box by dragging a Text Box control from the Toolbox and dropping it on the form.


'The Properties Of the TextBox Control
'The following are some Of the commonly used properties Of the TextBox control

'S.N  Property	Description
'1   AcceptsReturn	Gets Or sets a value indicating whether pressing ENTER in a multiline TextBox control creates a New line of text in the control Or activates the default button for the form.
'2   AutoCompleteCustomSource	Gets Or sets a custom System.Collections.Specialized.StringCollection to use when the AutoCompleteSourceproperty Is set to CustomSource.
'3   AutoCompleteMode	Gets Or sets an option that controls how automatic completion works for the TextBox.
'4   AutoCompleteSource	Gets Or sets a value specifying the source of complete strings used for automatic completion.
'5   CharacterCasing	Gets Or sets whether the TextBox control modifies the case of characters as they are typed.
'6   Font	Gets Or sets the font of the text displayed by the control.
'7   FontHeight	Gets Or sets the height of the font of the control.
'8   ForeColor	Gets Or sets the foreground color of the control.
'9   Lines	Gets Or sets the lines of text in a text box control.
'10  Multiline	Gets Or sets a value indicating whether this Is a multiline TextBox control.
'11  PasswordChar	Gets Or sets the character used to mask characters of a password in a single-line TextBox control.
'12  ReadOnly	Gets Or sets a value indicating whether text in the text box Is read-only.
'13  ScrollBars	Gets Or sets which scroll bars should appear in a multiline TextBox control. This property has values:
'None
'Horizontal
'Vertical
'Both
'14  TabIndex	Gets Or sets the tab order of the control within its container.
'15  Text	Gets Or sets the current text in the TextBox.
'16  TextAlign	Gets Or sets how text Is aligned in a TextBox control. This property has values:
'Left
'Right
'Center
'17  TextLength	Gets the length of text in the control.
'18  WordWrap	Indicates whether a multiline text box control automatically wraps words to the beginning of the next line when necessary.
'The Methods Of the TextBox Control
'The following are some Of the commonly used methods Of the TextBox control

'S.N  Method Name & Description
'1   
'AppendText

'Appends text To the current text Of a text box.

'2   
'Clear

'Clears all text from the text box control.

'3   
'Copy

'Copies the current selection In the text box To the Clipboard.

'4   
'Cut

'Moves the current selection In the text box To the Clipboard.

'5   
'Paste

'Replaces the current selection In the text box With the contents Of the Clipboard.

'6   
'Paste(Of String)

'Sets the selected text To the specified text without clearing the undo buffer.

'7   
'ResetText

'Resets the Text Property To its Default value.

'8   
'ToString

'Returns a String that represents the TextBoxBase control.

'9   
'Undo

'Undoes the last edit operation In the text box.

'Events of the TextBox Control
'The following are some Of the commonly used events Of the Text control

'S.N  Event	Description
'1   Click	Occurs when the control Is clicked.
'2   DoubleClick	Occurs when the control Is double-clicked.
'3   TextAlignChanged	Occurs when the TextAlign property value changes.
'Example
'In this example, we create three text boxes And use the Click event of a button to display the entered text using a message box. Take the following steps

'Drag And drop three Label controls And three TextBox controls on the form.

'Change the texts On the labels To: Name, Organization And Comments, respectively.

'Change the names Of the text boxes To txtName, txtOrg And txtComment, respectively.

'Drag And drop a button control on the form. Set its name to btnMessage And its text property to 'Send Message'.

'Click the button To add the Click Event In the code window And add the following code.

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) _
       Handles MyBase.Load
        ' Set the caption bar text of the form.  
        Me.Text = "tutorialspont.com"
    End Sub


End Class
