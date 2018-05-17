
'VB.Net -TreeView Control
'The TreeView control Is used To display hierarchical representations Of items similar To the ways the files And folders are displayed In the left pane Of the Windows Explorer. Each node may contain one Or more child nodes.

'Let's click on a TreeView control from the Toolbox and place it on the form.

'Properties of the TreeView Control
'The following are some Of the commonly used properties Of the TreeView control

'S.N  Property	Description
'1   BackColor	Gets Or sets the background color for the control.
'2   BackgroundImage	Gets Or set the background image for the TreeView control.
'3   BackgroundImageLayout	Gets Or sets the layout of the background image for the TreeView control.
'4   BorderStyle	Gets Or sets the border style of the tree view control.
'5   CheckBoxes	Gets Or sets a value indicating whether check boxes are displayed next to the tree nodes in the tree view control.
'6   DataBindings	Gets the data bindings for the control.
'7   Font	Gets Or sets the font of the text displayed by the control.
'8   FontHeight	Gets Or sets the height of the font of the control.
'9   ForeColor	The current foreground color for this control, which Is the color the control uses to draw its text.
'10  ItemHeight	Gets Or sets the height of each tree node in the tree view control.
'11  Nodes	Gets the collection of tree nodes that are assigned to the tree view control.
'12  PathSeparator	Gets Or sets the delimiter string that the tree node path uses.
'13  RightToLeftLayout	Gets Or sets a value that indicates whether the TreeView should be laid out from right-to-left.
'14  Scrollable	Gets Or sets a value indicating whether the tree view control displays scroll bars when they are needed.
'15  SelectedImageIndex	Gets Or sets the image list index value of the image that Is displayed when a tree node Is selected.
'16  SelectedImageKey	Gets Or sets the key of the default image shown when a TreeNode Is in a selected state.
'17  SelectedNode	Gets Or sets the tree node that Is currently selected in the tree view control.
'18  ShowLines	Gets Or sets a value indicating whether lines are drawn between tree nodes in the tree view control.
'19  ShowNodeToolTips	Gets Or sets a value indicating ToolTips are shown when the mouse pointer hovers over a TreeNode.
'20  ShowPlusMinus	Gets Or sets a value indicating whether plus-sign (+) And minus-sign (-) buttons are displayed next to tree nodes that contain child tree nodes.
'21  ShowRootLines	Gets Or sets a value indicating whether lines are drawn between the tree nodes that are at the root of the tree view.
'22  Sorted	Gets Or sets a value indicating whether the tree nodes in the tree view are sorted.
'23  StateImageList	Gets Or sets the image list that Is used to indicate the state of the TreeView And its nodes.
'24  Text	Gets Or sets the text of the TreeView.
'25  TopNode	Gets Or sets the first fully-visible tree node in the tree view control.
'26  TreeViewNodeSorter	Gets Or sets the implementation of IComparer to perform a custom sort of the TreeView nodes.
'27  VisibleCount	Gets the number of tree nodes that can be fully visible in the tree view control.
'Methods of the TreeView Control
'The following are some Of the commonly used methods Of the TreeView control

'S.N  Method Name & Description
'1   
'CollapseAll

'Collapses all the nodes including all child nodes In the tree view control.

'2   
'ExpandAll

'Expands all the nodes.

'3   
'GetNodeAt

'Gets the node at the specified location.

'4   
'GetNodeCount

'Gets the number Of tree nodes.

'5   
'Sort

'Sorts all the items In the tree view control.

'6   
'ToString

'Returns a String containing the name Of the control.

'Events of the TreeView Control
'The following are some Of the commonly used events Of the TreeView control

'S.N  Event	Description
'1   AfterCheck	Occurs after the tree node check box Is checked.
'2   AfterCollapse	Occurs after the tree node Is collapsed.
'3   AfterExpand	Occurs after the tree node Is expanded.
'4   AfterSelect	Occurs after the tree node Is selected.
'5   BeforeCheck	Occurs before the tree node check box Is checked.
'6   BeforeCollapse	Occurs before the tree node Is collapsed.
'7   BeforeExpand	Occurs before the tree node Is expanded.
'8   BeforeLabelEdit	Occurs before the tree node label text Is edited.
'9   BeforeSelect	Occurs before the tree node Is selected.
'10  ItemDrag	Occurs when the user begins dragging a node.
'11  NodeMouseClick	Occurs when the user clicks a TreeNode with the mouse.
'12  NodeMouseDoubleClick	Occurs when the user double-clicks a TreeNode with the mouse.
'13  NodeMouseHover	Occurs when the mouse hovers over a TreeNode.
'14  PaddingChanged	Occurs when the value of the Padding property changes.
'15  Paint	Occurs when the TreeView Is drawn.
'16  RightToLeftLayoutChanged	Occurs when the value of the RightToLeftLayout property changes.
'17  TextChanged	Occurs when the Text property changes.
'The TreeNode Class
'The TreeNode Class represents a node Of a TreeView. Each node In a TreeView control Is an Object Of the TreeNode Class. To be able To use a TreeView control we need To have a look at some commonly used properties And methods Of the TreeNode Class.

'Properties of the TreeNode Class
'The following are some Of the commonly used properties Of the TreeNode Class

'S.N  Property	Description
'1   BackColor	Gets Or sets the background color of the tree node.
'2   Checked	Gets Or sets a value indicating whether the tree node Is in a checked state.
'3   ContextMenu	Gets the shortcut menu that Is associated with this tree node.
'4   ContextMenuStrip	Gets Or sets the shortcut menu associated with this tree node.
'5   FirstNode	Gets the first child tree node in the tree node collection.
'6   FullPath	Gets the path from the root tree node to the current tree node.
'7   Index	Gets the position of the tree node in the tree node collection.
'8   IsEditing	Gets a value indicating whether the tree node Is in an editable state.
'9   IsExpanded	Gets a value indicating whether the tree node Is in the expanded state.
'10  IsSelected	Gets a value indicating whether the tree node Is in the selected state.
'11  IsVisible	Gets a value indicating whether the tree node Is visible Or partially visible.
'12  LastNode	Gets the last child tree node.
'13  Level	Gets the zero-based depth of the tree node in the TreeView control.
'14  Name	Gets Or sets the name of the tree node.
'15  NextNode	Gets the next sibling tree node.
'16  Nodes	Gets the collection of TreeNode objects assigned to the current tree node.
'17  Parent	Gets the parent tree node of the current tree node.
'18  PrevNode	Gets the previous sibling tree node.
'19  PrevVisibleNode	Gets the previous visible tree node.
'20  Tag	Gets Or sets the object that contains data about the tree node.
'21  Text	Gets Or sets the text displayed in the label of the tree node.
'22  ToolTipText	Gets Or sets the text that appears when the mouse pointer hovers over a TreeNode.
'23  TreeView	Gets the parent tree view that the tree node Is assigned to.
'Methods of the TreeNode Class
'The following are some Of the commonly used methods Of the TreeNode Class

'S.N  Method Name & Description
'1   
'Collapse

'Collapses the tree node.

'2   
'Expand

'Expands the tree node.

'3   
'ExpandAll

'Expands all the child tree nodes.

'4   
'GetNodeCount

'Returns the number Of child tree nodes.

'5   
'Remove

'Removes the current tree node from the tree view control.

'6   
'Toggle

'Toggles the tree node To either the expanded Or collapsed state.

'7   
'ToString

'Returns a String that represents the current Object.

'Example
'In this example, let us create a tree view at runtime. Let's double click on the Form and put the follow code in the opened window.

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'create a new TreeView
        Dim TreeView1 As TreeView
        TreeView1 = New TreeView()
        TreeView1.Location = New Point(10, 10)
        TreeView1.Size = New Size(150, 150)
        Me.Controls.Add(TreeView1)
        TreeView1.Nodes.Clear()
        'Creating the root node
        Dim root = New TreeNode("Application")
        TreeView1.Nodes.Add(root)
        TreeView1.Nodes(0).Nodes.Add(New TreeNode("Project 1"))
        'Creating child nodes under the first child
        For loopindex As Integer = 1 To 4
            TreeView1.Nodes(0).Nodes(0).Nodes.Add(New _
                TreeNode("Sub Project" & Str(loopindex)))
        Next loopindex
        ' creating child nodes under the root
        TreeView1.Nodes(0).Nodes.Add(New TreeNode("Project 6"))
        'creating child nodes under the created child node
        For loopindex As Integer = 1 To 3
            TreeView1.Nodes(0).Nodes(1).Nodes.Add(New _
                TreeNode("Project File" & Str(loopindex)))
        Next loopindex
        ' Set the caption bar text of the form.  
        Me.Text = "tutorialspoint.com"
    End Sub

End Class
