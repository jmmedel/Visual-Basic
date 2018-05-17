
'VB.Net -ListView Control
'The ListView control Is 
'    To display a list Of items. Along With the TreeView control, it allows you To create a Windows Explorer Like Interface.

'Let's click on a ListView control from the Toolbox and place it on the form.

'The ListView control displays a list Of items along With icons. The Item Property Of the ListView control allows you To add And remove items from it. The SelectedItem Property contains a collection Of the selected items. The MultiSelect Property allows you To Set Select more than one item In the list view. The CheckBoxes Property allows you To Set check boxes Next To the items.

'Properties of the ListView Control
'The following are some Of the commonly used properties Of the ListView control

'S.N  Property	Description
'1   Alignment	Gets Or sets the alignment of items in the control.
'2   AutoArrange	Gets Or sets whether icons are automatically kept arranged.
'3   BackColor	Gets Or sets the background color.
'4   CheckBoxes	Gets Or sets a value indicating whether a check box appears next to each item in the control.
'5   CheckedIndices	Gets the indexes of the currently checked items in the control.
'6   CheckedItems	Gets the currently checked items in the control.
'7   Columns	Gets the collection of all column headers that appear in the control.
'8   GridLines	Gets Or sets a value indicating whether grid lines appear between the rows And columns containing the items And subitems in the control.
'9   HeaderStyle	Gets Or sets the column header style.
'10  HideSelection	Gets Or sets a value indicating whether the selected item in the control remains highlighted when the control loses focus.
'11  HotTracking	Gets Or sets a value indicating whether the text of an item Or subitem has the appearance of a hyperlink when the mouse pointer passes over it.
'12  HoverSelection	Gets Or sets a value indicating whether an item Is automatically selected when the mouse pointer remains over the item for a few seconds.
'13  InsertionMark	Gets an object used to indicate the expected drop location when an item Is dragged within a ListView control.
'14  Items	Gets a collection containing all items in the control.
'15  LabelWrap	Gets Or sets a value indicating whether item labels wrap when items are displayed in the control as icons.
'16  LargeImageList	Gets Or sets the ImageList to use when displaying items as large icons in the control.
'17  MultiSelect	Gets Or sets a value indicating whether multiple items can be selected.
'18  RightToLeftLayout	Gets Or sets a value indicating whether the control Is laid out from right to left.
'19  Scrollable	Gets Or sets a value indicating whether a scroll bar Is added to the control when there Is Not enough room to display all items.
'20  SelectedIndices	Gets the indexes of the selected items in the control.
'21  SelectedItems	Gets the items that are selected in the control.
'22  ShowGroups	Gets Or sets a value indicating whether items are displayed in groups.
'23  ShowItemToolTips	Gets Or sets a value indicating whether ToolTips are shown for the ListViewItem objects contained in theListView.
'24  SmallImageList	Gets Or sets the ImageList to use when displaying items as small icons in the control.
'25  Sorting	Gets Or sets the sort order for items in the control.
'26  StateImageList	Gets Or sets the ImageList associated with application-defined states in the control.
'27  TopItem	Gets Or sets the first visible item in the control.
'28  View	Gets Or sets how items are displayed in the control. This property has the following values:
'LargeIcon -displays large items with a large 32 x 32 pixels icon.
'SmallIcon -displays items with a small 16 x 16 pixels icon
'List -displays small icons always in one column
'Details -displays items in multiple columns with column headers And fields
'Tile -displays items as full-size icons with item labels And sub-item information.
'29  VirtualListSize	Gets Or sets the number of ListViewItem objects contained in the list when in virtual mode.
'30  VirtualMode	Gets Or sets a value indicating whether you have provided your own data-management operations for the ListView control.
'Methods of the ListView Control
'The following are some Of the commonly used methods Of the ListView control

'S.N  Method Name & Description
'1   
'Clear

'Removes all items from the ListView control.

'1   



'Returns a String containing the String representation Of the control.

'Events of the ListView Control
'The following are some Of the commonly used events Of the ListView control

'S.N  Event	Description
'1   ColumnClick	Occurs when a column header Is clicked.
'2   ItemCheck	Occurs when an item in the control Is checked Or unchecked.
'3   SelectedIndexChanged	Occurs when the selected index Is changed.
'4   TextChanged	Occurs when the Text property Is changed.
'Example
'In this example, let us create a list view at runtime. Let's double click on the Form and put the follow code in the opened window.

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'create a new ListView
        Dim ListView1 As ListView
        ListView1 = New ListView()
        ListView1.Location = New Point(10, 10)
        ListView1.Size = New Size(150, 150)
        Me.Controls.Add(ListView1)
        'Creating the list items
        Dim ListItem1 As ListViewItem
        ListItem1 = ListView1.Items.Add("Item 1")
        Dim ListItem2 As ListViewItem
        ListItem2 = ListView1.Items.Add("Item 2")
        Dim ListItem3 As ListViewItem
        ListItem3 = ListView1.Items.Add("Item 3")
        Dim ListItem4 As ListViewItem
        ListItem4 = ListView1.Items.Add("Item 4")
        'set the view property
        ListView1.View = View.SmallIcon
        ' Set the caption bar text of the form.  
        Me.Text = "tutorialspoint.com"
    End Sub
End Class
