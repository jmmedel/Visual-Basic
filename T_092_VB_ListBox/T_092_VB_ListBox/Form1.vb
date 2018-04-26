
'VB.Net -ListBox Control
'The ListBox represents a Windows control To display a list Of items To a user. A user can Select an item from the list. It allows the programmer To add items at design time by Using the properties window Or at the runtime.

'Let's create a list box by dragging a ListBox control from the Toolbox and dropping it on the form.
'You can populate the list box items either from the properties window Or at runtime. To add items To a ListBox, Select the ListBox control And Get To the properties window, For the properties Of this control. Click the ellipses (...) button Next To the Items Property. This opens the String Collection Editor dialog box, where you can enter the values one at a line.

'Properties of the ListBox Control
'The following are some Of the commonly used properties Of the ListBox control

'S.N  Property	Description
'1   AllowSelection	Gets a value indicating whether the ListBox currently enables selection of list items.
'2   BorderStyle	Gets Or sets the type of border drawn around the list box.
'3   ColumnWidth	Gets of sets the width of columns in a multicolumn list box.
'4   HorizontalExtent	Gets Or sets the horizontal scrolling area of a list box.
'5   HorizontalScrollBar	Gets Or sets the value indicating whether a horizontal scrollbar Is displayed in the list box.
'6   ItemHeight	Gets Or sets the height of an item in the list box.
'7   Items	Gets the items of the list box.
'8   MultiColumn	Gets Or sets a value indicating whether the list box supports multiple columns.
'9   ScrollAlwaysVisible	Gets Or sets a value indicating whether the vertical scroll bar Is shown at all times.
'10  SelectedIndex	Gets Or sets the zero-based index of the currently selected item in a list box.
'11  SelectedIndices	Gets a collection that contains the zero-based indexes of all currently selected items in the list box.
'12  SelectedItem	Gets Or sets the currently selected item in the list box.
'13  SelectedItems	Gets a collection containing the currently selected items in the list box.
'14  SelectedValue	Gets Or sets the value of the member property specified by the ValueMember property.
'15  SelectionMode	Gets Or sets the method in which items are selected in the list box. This property has values:
'None
'One
'MultiSimple
'MultiExtended
'16  Sorted	Gets Or sets a value indicating whether the items in the list box are sorted alphabetically.
'17  Text	Gets Or searches for the text of the currently selected item in the list box.
'18  TopIndex	Gets Or sets the index of the first visible item of a list box.
'Methods of the ListBox Control
'The following are some Of the commonly used methods Of the ListBox control

'S.N  Method Name & Description
'1   BeginUpdate 
'Prevents the control from drawing until the EndUpdate method Is called, While items are added To the ListBox one at a time.
'2   
'ClearSelected

'Unselects all items In the ListBox.

'3   
'EndUpdate

'Resumes drawing Of a list box after it was turned off by the BeginUpdate method.

'4   
'FindString

'Finds the first item In the ListBox that starts With the String specified As an argument.

'5   
'FindStringExact

'Finds the first item In the ListBox that exactly matches the specified String.

'6   
'GetSelected

'Returns a value indicating whether the specified item Is selected.

'7   
'SetSelected

'Selects Or clears the selection for the specified item in a ListBox.

'8   
'OnSelectedIndexChanged

'Raises the SelectedIndexChanged Event.

'8   
'OnSelectedValueChanged

'Raises the SelectedValueChanged Event.

'Events of the ListBox Control
'The following are some Of the commonly used events Of the ListBox control

'S.N  Event	Description
'1   Click	Occurs when a list box Is selected.
'2   SelectedIndexChanged	Occurs when the SelectedIndex property of a list box Is changed.
'Consult Microsoft documentation For detailed list Of properties, methods And events Of the ListBox control.

'Example 1
'In the following example, let us add a list box at design time And add items on it at runtime.

'Take the following steps

'Drag And drop two labels, a button And a ListBox control on the form.

'Set the Text Property Of the first label To provide the caption "Choose your favourite destination for higher studies".

'Set the Text Property Of the second label To provide the caption "Destination". The text On this label will change at runtime When the user selects an item On the list.

'Click the listbox And the button controls To add the following codes In the code editor.

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the caption bar text of the form.  
        Me.Text = "Listbox.com"
        ListBox1.Items.Add("Canada")
        ListBox1.Items.Add("USA")
        ListBox1.Items.Add("UK")
        ListBox1.Items.Add("Japan")
        ListBox1.Items.Add("Russia")
        ListBox1.Items.Add("China")
        ListBox1.Items.Add("India")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("You have selected " + ListBox1.SelectedItem.ToString())
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Label2.Text = ListBox1.SelectedItem.ToString()

    End Sub
End Class
