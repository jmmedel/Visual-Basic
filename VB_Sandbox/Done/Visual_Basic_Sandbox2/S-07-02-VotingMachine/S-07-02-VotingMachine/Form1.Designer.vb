<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVotingMachine
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
    Me.lblVotes = New System.Windows.Forms.Label()
    Me.btnNominate = New System.Windows.Forms.Button()
    Me.btnVote = New System.Windows.Forms.Button()
    Me.btnTally = New System.Windows.Forms.Button()
    Me.lstVotes = New System.Windows.Forms.ListBox()
    Me.lstCandidates = New System.Windows.Forms.ListBox()
    Me.lblInstructions = New System.Windows.Forms.Label()
    Me.SuspendLayout
    '
    'lblVotes
    '
    Me.lblVotes.AutoSize = true
    Me.lblVotes.Location = New System.Drawing.Point(215, 41)
    Me.lblVotes.Name = "lblVotes"
    Me.lblVotes.Size = New System.Drawing.Size(55, 13)
    Me.lblVotes.TabIndex = 13
    Me.lblVotes.Text = "# of votes"
    Me.lblVotes.Visible = false
    '
    'btnNominate
    '
    Me.btnNominate.Location = New System.Drawing.Point(15, 186)
    Me.btnNominate.Name = "btnNominate"
    Me.btnNominate.Size = New System.Drawing.Size(75, 63)
    Me.btnNominate.TabIndex = 12
    Me.btnNominate.Text = "Nominate Candidate"
    Me.btnNominate.UseVisualStyleBackColor = true
    '
    'btnVote
    '
    Me.btnVote.Location = New System.Drawing.Point(106, 186)
    Me.btnVote.Name = "btnVote"
    Me.btnVote.Size = New System.Drawing.Size(75, 63)
    Me.btnVote.TabIndex = 11
    Me.btnVote.Text = "Start Voting"
    Me.btnVote.UseVisualStyleBackColor = true
    '
    'btnTally
    '
    Me.btnTally.Location = New System.Drawing.Point(200, 186)
    Me.btnTally.Name = "btnTally"
    Me.btnTally.Size = New System.Drawing.Size(75, 63)
    Me.btnTally.TabIndex = 10
    Me.btnTally.Text = "Tally Votes"
    Me.btnTally.UseVisualStyleBackColor = true
    '
    'lstVotes
    '
    Me.lstVotes.FormattingEnabled = true
    Me.lstVotes.Location = New System.Drawing.Point(209, 57)
    Me.lstVotes.Name = "lstVotes"
    Me.lstVotes.Size = New System.Drawing.Size(66, 108)
    Me.lstVotes.TabIndex = 9
    Me.lstVotes.Visible = false
    '
    'lstCandidates
    '
    Me.lstCandidates.FormattingEnabled = true
    Me.lstCandidates.Location = New System.Drawing.Point(15, 57)
    Me.lstCandidates.Name = "lstCandidates"
    Me.lstCandidates.Size = New System.Drawing.Size(164, 108)
    Me.lstCandidates.TabIndex = 8
    '
    'lblInstructions
    '
    Me.lblInstructions.Location = New System.Drawing.Point(12, 9)
    Me.lblInstructions.Name = "lblInstructions"
    Me.lblInstructions.Size = New System.Drawing.Size(263, 46)
    Me.lblInstructions.TabIndex = 7
    Me.lblInstructions.Text = "Click ""Nominate Candidate"" to enter a candidate, or ""Start Voting"" to end nominat"& _ 
    "ions and start the voting."
    '
    'frmVotingMachine
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(298, 269)
    Me.Controls.Add(Me.lblVotes)
    Me.Controls.Add(Me.btnNominate)
    Me.Controls.Add(Me.btnVote)
    Me.Controls.Add(Me.btnTally)
    Me.Controls.Add(Me.lstVotes)
    Me.Controls.Add(Me.lstCandidates)
    Me.Controls.Add(Me.lblInstructions)
    Me.Name = "frmVotingMachine"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Voting Machine"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub

  Friend WithEvents lblVotes As Label
  Friend WithEvents btnNominate As Button
  Friend WithEvents btnVote As Button
  Friend WithEvents btnTally As Button
  Friend WithEvents lstVotes As ListBox
  Friend WithEvents lstCandidates As ListBox
  Friend WithEvents lblInstructions As Label
End Class
