
'VB.Net -MenuStrip Control
'Advertisements
' Previous Page Next Page  
'The MenuStrip control represents the container For the menu Structure.

'The MenuStrip control works As the top-level container For the menu Structure. The ToolStripMenuItem Class And the ToolStripDropDownMenu Class provide the functionalities To create menu items, Sub menus And drop-down menus.

'The following diagram shows adding a MenuStrip control On the form −

'VB.Net MenuStrip Control
'Properties of the MenuStrip Control
'The following are some Of the commonly used properties Of the MenuStrip control −

'Sr.No.Property & Description
'1   
'CanOverflow

'Gets Or sets a value indicating whether the MenuStrip supports overflow functionality.

'2   
'GripStyle

'Gets Or sets the visibility of the grip used to reposition the control.

'3   
'MdiWindowListItem

'Gets Or sets the ToolStripMenuItem that Is used to display a list of Multiple-document interface (MDI) child forms.

'4   
'ShowItemToolTips

'Gets Or sets a value indicating whether ToolTips are shown for the MenuStrip.

'5   
'Stretch

'Gets Or sets a value indicating whether the MenuStrip stretches from end to end in its container.

'Events of the MenuStrip Control
'The following are some Of the commonly used events Of the MenuStrip control −

'Sr.No.Event & Description
'1   
'MenuActivate

'Occurs when the user accesses the menu with the keyboard Or mouse.

'2   
'MenuDeactivate

'Occurs when the MenuStrip Is deactivated.

'Example
'In this example, let us add menu And sub-menu items.

'Take the following steps −

'Drag And drop Or Double click On a MenuStrip control, to add it to the form.

'Click the Type Here text To open a text box And enter the names Of the menu items Or Sub-menu items you want. When you add a Sub-menu, another text box With 'Type Here' text opens below it.

'Complete the menu Structure shown In the diagram above.

'Add a Sub menu Exit under the File menu.

'VB.Net MenuStrip Example
'Double-Click the Exit menu created And add the following code to the Click event of ExitToolStripMenuItem −

'Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) _
'   Handles ExitToolStripMenuItem.Click
'    End
'End Sub
'When the above code Is executed And run using Start button available at the Microsoft Visual Studio tool bar, it will show the following window

'VB.Net MenuStrip Example
'Click on the File -> Exit to exit from the application −


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
