

'VB.Net -ComboBox Control
'The ComboBox control Is used To display a drop-down list Of various items. It Is a combination Of a text box In which the user enters an item And a drop-down list from which the user selects an item.

'Let's create a combo box by dragging a ComboBox control from the Toolbox and dropping it on the form.

'You can populate the list box items either from the properties window Or at runtime. To add items To a ComboBox, Select the ComboBox control And go To the properties window For the properties Of this control. Click the ellipses (...) button Next To the Items Property. This opens the String Collection Editor dialog box, where you can enter the values one at a line.

'Properties of the ComboBox Control
'The following are some Of the commonly used properties Of the ComboBox control

'S.N  Property	Description
'1   AllowSelection	Gets a value indicating whether the list enables selection of list items.
'2   AutoCompleteCustomSource	Gets Or sets a custom System.Collections .Specialized.StringCollection to use when the AutoCompleteSourceproperty Is set to CustomSource.
'3   AutoCompleteMode	Gets Or sets an option that controls how automatic completion works for the ComboBox.
'4   AutoCompleteSource	Gets Or sets a value specifying the source of complete strings used for automatic completion.
'5   DataBindings	Gets the data bindings for the control.
'6   DataManager	Gets the CurrencyManager associated with this control.
'7   DataSource	Gets Or sets the data source for this ComboBox.
'8   DropDownHeight	Gets Or sets the height in pixels of the drop-down portion of the ComboBox.
'9   DropDownStyle	Gets Or sets a value specifying the style of the combo box.
'10  DropDownWidth	Gets Or sets the width of the of the drop-down portion of a combo box.
'11  DroppedDown	Gets Or sets a value indicating whether the combo box Is displaying its drop-down portion.
'12  FlatStyle	Gets Or sets the appearance of the ComboBox.
'13  ItemHeight	Gets Or sets the height of an item in the combo box.
'14  Items	Gets an object representing the collection of the items contained in this ComboBox.
'15  MaxDropDownItems	Gets Or sets the maximum number of items to be displayed in the drop-down part of the combo box.
'16  MaxLength	Gets Or sets the maximum number of characters a user can enter in the editable area of the combo box.
'17  SelectedIndex	Gets Or sets the index specifying the currently selected item.
'18  SelectedItem	Gets Or sets currently selected item in the ComboBox.
'19  SelectedText	Gets Or sets the text that Is selected in the editable portion of a ComboBox.
'20  SelectedValue	Gets Or sets the value of the member property specified by the ValueMember property.
'21  SelectionLength	Gets Or sets the number of characters selected in the editable portion of the combo box.
'22  SelectionStart	Gets Or sets the starting index of text selected in the combo box.
'23  Sorted	Gets Or sets a value indicating whether the items in the combo box are sorted.
'24  Text	Gets Or sets the text associated with this control.
'Methods of the ComboBox Control
'The following are some Of the commonly used methods Of the ComboBox control

'S.N  Method Name & Description
'1   
'BeginUpdate

'Prevents the control from drawing until the EndUpdate method Is called, While items are added To the combo box one at a time.

'2   
'EndUpdate

'Resumes drawing Of a combo box, after it was turned off by the BeginUpdate method.

'3   
'FindString

'Finds the first item In the combo box that starts With the String specified As an argument.

'4   
'FindStringExact

'Finds the first item In the combo box that exactly matches the specified String.

'5   
'SelectAll

'Selects all the text In the editable area Of the combo box.

'Events of the ComboBox Control
'The following are some Of the commonly used events Of the ComboBox control

'S.N  Event	Description
'1   DropDown	Occurs when the drop-down portion of a combo box Is displayed.
'2   DropDownClosed	Occurs when the drop-down portion of a combo box Is no longer visible.
'3   DropDownStyleChanged	Occurs when the DropDownStyle property of the ComboBox has changed.
'4   SelectedIndexChanged	Occurs when the SelectedIndex property of a ComboBox control has changed.
'5   SelectionChangeCommitted	Occurs when the selected item has changed And the change appears in the combo box.
'Example
'In this example, let us fill a combo box with various items, get the selected items in the combo box And show them in a list box And sort the items.

'Drag And drop a combo box To store the items, a list box To display the selected items, four button controls To add To the list box With selected items, to fill the combo box, to sort the items And to clear the combo box list, respectively.

'Add a label control that would display the selected item.

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the caption bar text of the form.  
        Me.Text = "tutorialspont.com"
    End Sub
    'sends the selected items to the list box
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex > -1 Then
            Dim sindex As Integer
            sindex = ComboBox1.SelectedIndex
            Dim sitem As Object
            sitem = ComboBox1.SelectedItem
            ListBox1.Items.Add(sitem)
        End If
    End Sub
    'populates the list
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Safety")
        ComboBox1.Items.Add("Security")
        ComboBox1.Items.Add("Governance")
        ComboBox1.Items.Add("Good Music")
        ComboBox1.Items.Add("Good Movies")
        ComboBox1.Items.Add("Good Books")
        ComboBox1.Items.Add("Education")
        ComboBox1.Items.Add("Roads")
        ComboBox1.Items.Add("Health")
        ComboBox1.Items.Add("Food for all")
        ComboBox1.Items.Add("Shelter for all")
        ComboBox1.Items.Add("Industrialisation")
        ComboBox1.Items.Add("Peace")
        ComboBox1.Items.Add("Liberty")
        ComboBox1.Items.Add("Freedom of Speech")
        ComboBox1.Text = "Select from..."
    End Sub
    'sorting the list
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        ComboBox1.Sorted = True
    End Sub
    'clears the list
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        ComboBox1.Items.Clear()
    End Sub
    'displaying the selected item on the label
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) _
     Handles ListBox1.SelectedIndexChanged
        Label1.Text = ComboBox1.SelectedItem.ToString()
    End Sub
End Class
