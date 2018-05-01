
'VB.Net -CheckBox Control
'The CheckBox control allows the user To Set True/False Or yes/no type options. The user can Select Or deselect it. When a check box Is selected it has the value True, And When it Is cleared, it holds the value False.

'Let's create two check boxes by dragging CheckBox controls from the Toolbox and dropping on the form.
'The CheckBox control has three states, checked, unchecked And indeterminate. In the indeterminate state, the check box Is grayed out. To enable the indeterminate state, the ThreeState Property Of the check box Is Set To be True.

'Properties of the CheckBox Control
'The following are some Of the commonly used properties Of the CheckBox control

'S.N  Property	Description
'1   Appearance	Gets Or sets a value determining the appearance of the check box.
'2   AutoCheck	Gets Or sets a value indicating whether the Checked Or CheckedState value And the appearance of the control automatically change when the check box Is selected.
'3   CheckAlign	Gets Or sets the horizontal And vertical alignment of the check mark on the check box.
'4   Checked	Gets Or sets a value indicating whether the check box Is selected.
'5   CheckState	Gets Or sets the state of a check box.
'6   Text	Gets Or sets the caption of a check box.
'7   ThreeState	Gets Or sets a value indicating whether Or Not a check box should allow three check states rather than two.
'Methods of the CheckBox Control
'The following are some Of the commonly used methods Of the CheckBox control

'S.N  Method Name & Description
'1   
'OnCheckedChanged

'Raises the CheckedChanged Event.

'2   
'OnCheckStateChanged

'Raises the CheckStateChanged Event.

'3   
'OnClick

'Raises the OnClick Event.

'Events of the CheckBox Control
'The following are some Of the commonly used events Of the CheckBox control

'S.N  Event	Description
'1   AppearanceChanged	Occurs when the value of the Appearance property of the check box Is changed.
'2   CheckedChanged	Occurs when the value of the Checked property of the CheckBox control Is changed.
'3   CheckStateChanged	Occurs when the value of the CheckState property of the CheckBox control Is changed.
'Consult Microsoft documentation For detailed list Of properties, methods And events Of the CheckBox control.

'Example
'In this example, let us add four check boxes in a group box. The check boxes will allow the users to choose the source from which they came to know about the organization. If the user chooses the check box with text "others", then the user Is asked to specify And a text box Is provided to give input. When the user clicks the Submit button, he/she gets an appropriate message.

'The form In design view

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) _
       Handles MyBase.Load
        ' Set the caption bar text of the form.  
        Me.Text = "tutorialspoint.com"
        Label1.Visible = False
        TextBox1.Visible = False
        TextBox1.Multiline = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
      Handles Button1.Click
        Dim str As String
        str = " "
        If CheckBox1.Checked = True Then
            str &= CheckBox1.Text
            str &= " "
        End If
        If CheckBox2.Checked = True Then
            str &= CheckBox2.Text
            str &= " "
        End If
        If CheckBox3.Checked = True Then
            str &= CheckBox3.Text
            str &= " "
        End If
        If CheckBox4.Checked = True Then
            str &= TextBox1.Text
            str &= " "
        End If
        If str <> Nothing Then
            MsgBox(str + vbLf + "Thank you")
        End If

    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object,
      e As EventArgs) Handles CheckBox4.CheckedChanged
        Label1.Visible = True
        TextBox1.Visible = True
    End Sub
End Class
