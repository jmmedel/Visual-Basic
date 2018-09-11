'VB.Net -StripMenuItem Control
'Advertisements
' Previous Page Next Page  
'The ToolStripMenuItem Class supports the menus And menu items In a menu system. You handle these menu items through the click events In a menu system.

'Properties of the ToolStripMenuItem Control
'The following are some Of the commonly used properties Of the ToolStripMenuItem control −

'Sr.No.Property & Description
'1   
'Checked

'Gets Or sets a value indicating whether the ToolStripMenuItem Is checked.

'2   
'CheckOnClick

'Gets Or sets a value indicating whether the ToolStripMenuItem should automatically appear checked And unchecked when clicked.

'3   
'CheckState

'Gets Or sets a value indicating whether a ToolStripMenuItem Is In the checked, unchecked, Or indeterminate state.

'4   
'Enabled

'Gets Or sets a value indicating whether the control Is enabled.

'5   
'IsMdiWindowListEntry

'Gets a value indicating whether the ToolStripMenuItem appears On a multiple document Interface (MDI) window list.

'6   
'ShortcutKeyDisplayString

'Gets Or sets the shortcut key text.

'7   
'ShortcutKeys

'Gets Or sets the shortcut keys associated with the ToolStripMenuItem.

'8   
'ShowShortcutKeys

'Gets Or sets a value indicating whether the shortcut keys that are associated with the ToolStripMenuItem are displayed next to the ToolStripMenuItem.

'Events of the ToolStripMenuItem Control
'The following are some Of the commonly used events Of the ToolStripMenuItem control −

'Sr.No.Event & Description
'1   
'CheckedChanged

'Occurs when the value of the Checked property changes.

'2   
'CheckStateChanged

'Occurs when the value of the CheckState property changes.

'Example
'In this example, let us continue with the example from the chapter 'VB.Net - MenuStrip control'. Let us −

'Hide And display menu items.
'Disable And enable menu items.
'Set access keys For menu items
'Set shortcut keys For menu items.
'Hide And Display Menu Items

'The Visible Property Of the ToolStripMenuItem Class allows you To hide Or show a menu item. Let us hide the Project Menu On the menu bar.

'Add the following code snippet To the Form1_Load Event −

'Private Sub Form1_Load(sender As Object, e As EventArgs) _
'Handles MyBase.Load
'    ' Hide the project menu
'    ProjectToolStripMenuItem1.Visible = False
'    ' Set the caption bar text of the form.
'    Me.Text = "tutorialspoint.com"
'End Sub
'Add a button control On the form With text 'Show Project'.

'Add the following code snippet To the Button1_Click Event −

'Private Sub Button1_Click(sender As Object, e As EventArgs) _
'Handles Button1.Click
'    ProjectToolStripMenuItem1.Visible = True
'End Sub
'When the above code Is executed And run using Start button available at the Microsoft Visual Studio tool bar, it will show the following window

'VB.Net ToolStripMenuItem Example
'Clicking on the Show Project button displays the project menu −

'VB.Net ToolStripMenuItem Example
'Disable And Enable Menu Items

'The Enabled Property allows you To disable Or gray out a menu item. Let us disable the Project Menu On the menu bar.

'Add the following code snippet To the Form1_Load Event −

'Private Sub Form1_Load(sender As Object, e As EventArgs) _
'Handles MyBase.Load
'    ' Disable the project menu
'    ProjectToolStripMenuItem1.Enabled = False
'    ' Set the caption bar text of the form.
'    Me.Text = "tutorialspoint.com"
'End Sub
'Add a button control On the form With text 'Enable Project'.

'Add the following code snippet To the Button1_Click Event −

'Private Sub Button1_Click(sender As Object, e As EventArgs) _
'Handles Button1.Click
'    ProjectToolStripMenuItem1.Enabled = True
'End Sub
'When the above code Is executed And run using Start button available at the Microsoft Visual Studio tool bar, it will show the following window −

'VB.Net ToolStripMenuItem Example
'Clicking on the Enable Project button enables the project menu −

'VB.Net ToolStripMenuItem Example
'Set Access Keys For Menu Items

'Setting access keys For a menu allows a user To Select it from the keyboard by Using the ALT key.

'For example, if you want To set an access key ALT + F for the file menu, change its Text with an added & (ampersand) preceding the access key letter. In other words, you change the text property of the file menu to &File.

'VB.Net ToolStripMenuItem ExampleVB.Net ToolStripMenuItem Example
'Set Shortcut Keys For Menu Items

'When you set a shortcut key for a menu item, user can press the shortcut from the keyboard And it would result in occurrence of the Click event of the menu.

'A shortcut key Is Set For a menu item Using the ShortcutKeys Property. For example, To Set a shortcut key CTRL + E, For the Edit menu −

'Select Case the Edit menu item And Select its ShortcutKeys Property In the properties window.

'Click the drop down button Next To it.

'Select Case Ctrl As Modifier And E As the key.



Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
