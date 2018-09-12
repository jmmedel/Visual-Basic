<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirlineReservation
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
    Me.mtbSeatCol = New System.Windows.Forms.MaskedTextBox()
    Me.mtbSeatRow = New System.Windows.Forms.MaskedTextBox()
    Me.lstWaitingList = New System.Windows.Forms.ListBox()
    Me.lstOutput = New System.Windows.Forms.ListBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.txtName = New System.Windows.Forms.TextBox()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.btnQuit = New System.Windows.Forms.Button()
    Me.btnDelete = New System.Windows.Forms.Button()
    Me.btnAdd = New System.Windows.Forms.Button()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout
    '
    'mtbSeatCol
    '
    Me.mtbSeatCol.Location = New System.Drawing.Point(285, 15)
    Me.mtbSeatCol.Mask = "L"
    Me.mtbSeatCol.Name = "mtbSeatCol"
    Me.mtbSeatCol.Size = New System.Drawing.Size(20, 20)
    Me.mtbSeatCol.TabIndex = 15
    '
    'mtbSeatRow
    '
    Me.mtbSeatRow.Location = New System.Drawing.Point(258, 15)
    Me.mtbSeatRow.Mask = "##"
    Me.mtbSeatRow.Name = "mtbSeatRow"
    Me.mtbSeatRow.Size = New System.Drawing.Size(21, 20)
    Me.mtbSeatRow.TabIndex = 13
    '
    'lstWaitingList
    '
    Me.lstWaitingList.Enabled = false
    Me.lstWaitingList.FormattingEnabled = true
    Me.lstWaitingList.Location = New System.Drawing.Point(57, 149)
    Me.lstWaitingList.Name = "lstWaitingList"
    Me.lstWaitingList.Size = New System.Drawing.Size(120, 69)
    Me.lstWaitingList.TabIndex = 22
    '
    'lstOutput
    '
    Me.lstOutput.FormattingEnabled = true
    Me.lstOutput.Location = New System.Drawing.Point(212, 71)
    Me.lstOutput.Name = "lstOutput"
    Me.lstOutput.Size = New System.Drawing.Size(93, 147)
    Me.lstOutput.TabIndex = 21
    '
    'Label4
    '
    Me.Label4.AutoSize = true
    Me.Label4.Location = New System.Drawing.Point(189, 44)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(134, 13)
    Me.Label4.TabIndex = 20
    Me.Label4.Text = "(1A, 1B, 1C, 2A, 2B,...10D)"
    '
    'txtName
    '
    Me.txtName.Location = New System.Drawing.Point(60, 12)
    Me.txtName.Name = "txtName"
    Me.txtName.Size = New System.Drawing.Size(100, 20)
    Me.txtName.TabIndex = 11
    '
    'Label3
    '
    Me.Label3.AutoSize = true
    Me.Label3.Location = New System.Drawing.Point(75, 133)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(62, 13)
    Me.Label3.TabIndex = 18
    Me.Label3.Text = "Waiting List"
    '
    'btnQuit
    '
    Me.btnQuit.Location = New System.Drawing.Point(57, 100)
    Me.btnQuit.Name = "btnQuit"
    Me.btnQuit.Size = New System.Drawing.Size(105, 23)
    Me.btnQuit.TabIndex = 19
    Me.btnQuit.Text = "Quit"
    Me.btnQuit.UseVisualStyleBackColor = true
    '
    'btnDelete
    '
    Me.btnDelete.Location = New System.Drawing.Point(57, 71)
    Me.btnDelete.Name = "btnDelete"
    Me.btnDelete.Size = New System.Drawing.Size(105, 23)
    Me.btnDelete.TabIndex = 17
    Me.btnDelete.Text = "Delete Passenger"
    Me.btnDelete.UseVisualStyleBackColor = true
    '
    'btnAdd
    '
    Me.btnAdd.Location = New System.Drawing.Point(57, 42)
    Me.btnAdd.Name = "btnAdd"
    Me.btnAdd.Size = New System.Drawing.Size(105, 23)
    Me.btnAdd.TabIndex = 16
    Me.btnAdd.Text = "Add Passenger"
    Me.btnAdd.UseVisualStyleBackColor = true
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(220, 18)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(32, 13)
    Me.Label2.TabIndex = 14
    Me.Label2.Text = "Seat:"
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(15, 15)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(38, 13)
    Me.Label1.TabIndex = 12
    Me.Label1.Text = "Name:"
    '
    'frmAirlineReservation
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(360, 246)
    Me.Controls.Add(Me.mtbSeatCol)
    Me.Controls.Add(Me.mtbSeatRow)
    Me.Controls.Add(Me.lstWaitingList)
    Me.Controls.Add(Me.lstOutput)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.txtName)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.btnQuit)
    Me.Controls.Add(Me.btnDelete)
    Me.Controls.Add(Me.btnAdd)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "frmAirlineReservation"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "AirlineReservation"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents mtbSeatCol As MaskedTextBox
  Friend WithEvents mtbSeatRow As MaskedTextBox
  Friend WithEvents lstWaitingList As ListBox
  Friend WithEvents lstOutput As ListBox
  Friend WithEvents Label4 As Label
  Friend WithEvents txtName As TextBox
  Friend WithEvents Label3 As Label
  Friend WithEvents btnQuit As Button
  Friend WithEvents btnDelete As Button
  Friend WithEvents btnAdd As Button
  Friend WithEvents Label2 As Label
  Friend WithEvents Label1 As Label
End Class
