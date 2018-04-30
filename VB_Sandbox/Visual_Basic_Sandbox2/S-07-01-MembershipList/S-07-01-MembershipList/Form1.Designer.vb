<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMembershipList
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.mtbPhone = New System.Windows.Forms.MaskedTextBox()
    Me.txtName = New System.Windows.Forms.TextBox()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.lstMembers = New System.Windows.Forms.ListBox()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuModify = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
    Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
    Me.MenuStrip1.SuspendLayout
    Me.SuspendLayout
    '
    'mtbPhone
    '
    Me.mtbPhone.Location = New System.Drawing.Point(77, 243)
    Me.mtbPhone.Mask = "000-0000"
    Me.mtbPhone.Name = "mtbPhone"
    Me.mtbPhone.Size = New System.Drawing.Size(61, 20)
    Me.mtbPhone.TabIndex = 10
    '
    'txtName
    '
    Me.txtName.Location = New System.Drawing.Point(75, 205)
    Me.txtName.Name = "txtName"
    Me.txtName.Size = New System.Drawing.Size(148, 20)
    Me.txtName.TabIndex = 9
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(30, 246)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(41, 13)
    Me.Label2.TabIndex = 8
    Me.Label2.Text = "Phone:"
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(30, 208)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(38, 13)
    Me.Label1.TabIndex = 7
    Me.Label1.Text = "Name:"
    '
    'lstMembers
    '
    Me.lstMembers.FormattingEnabled = true
    Me.lstMembers.Location = New System.Drawing.Point(33, 43)
    Me.lstMembers.Name = "lstMembers"
    Me.lstMembers.Size = New System.Drawing.Size(190, 134)
    Me.lstMembers.TabIndex = 6
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.mnuExit})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(266, 24)
    Me.MenuStrip1.TabIndex = 11
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'UpdateToolStripMenuItem
    '
    Me.UpdateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModify, Me.mnuAdd, Me.mnuDelete})
    Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
    Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
    Me.UpdateToolStripMenuItem.Text = "Update"
    '
    'mnuModify
    '
    Me.mnuModify.Name = "mnuModify"
    Me.mnuModify.ShortcutKeys = System.Windows.Forms.Keys.F1
    Me.mnuModify.Size = New System.Drawing.Size(152, 22)
    Me.mnuModify.Text = "Modify"
    '
    'mnuAdd
    '
    Me.mnuAdd.Name = "mnuAdd"
    Me.mnuAdd.ShortcutKeys = System.Windows.Forms.Keys.F2
    Me.mnuAdd.Size = New System.Drawing.Size(152, 22)
    Me.mnuAdd.Text = "Add"
    '
    'mnuDelete
    '
    Me.mnuDelete.Name = "mnuDelete"
    Me.mnuDelete.ShortcutKeys = System.Windows.Forms.Keys.F3
    Me.mnuDelete.Size = New System.Drawing.Size(152, 22)
    Me.mnuDelete.Text = "Delete"
    '
    'mnuExit
    '
    Me.mnuExit.Name = "mnuExit"
    Me.mnuExit.Size = New System.Drawing.Size(37, 20)
    Me.mnuExit.Text = "Exit"
    '
    'frmMembershipList
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(266, 287)
    Me.Controls.Add(Me.mtbPhone)
    Me.Controls.Add(Me.txtName)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.lstMembers)
    Me.Controls.Add(Me.MenuStrip1)
    Me.Name = "frmMembershipList"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Membership List"
    Me.MenuStrip1.ResumeLayout(false)
    Me.MenuStrip1.PerformLayout
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents mtbPhone As MaskedTextBox
  Friend WithEvents txtName As TextBox
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
  Friend WithEvents lstMembers As ListBox
  Friend WithEvents MenuStrip1 As MenuStrip
  Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
  Friend WithEvents mnuModify As ToolStripMenuItem
  Friend WithEvents mnuAdd As ToolStripMenuItem
  Friend WithEvents mnuDelete As ToolStripMenuItem
  Friend WithEvents mnuExit As ToolStripMenuItem
End Class
