<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplay
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
        Me.mnuCloseStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCloseStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuCloseStrip
        '
        Me.mnuCloseStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose})
        Me.mnuCloseStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuCloseStrip.Name = "mnuCloseStrip"
        Me.mnuCloseStrip.Size = New System.Drawing.Size(284, 24)
        Me.mnuCloseStrip.TabIndex = 0
        Me.mnuCloseStrip.Text = "MenuStrip1"
        '
        'mnuClose
        '
        Me.mnuClose.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(48, 20)
        Me.mnuClose.Text = "&Close"
        '
        'txtFileName
        '
        Me.txtFileName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileName.Location = New System.Drawing.Point(0, 28)
        Me.txtFileName.Multiline = True
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(284, 230)
        Me.txtFileName.TabIndex = 1
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'frmDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.mnuCloseStrip)
        Me.MainMenuStrip = Me.mnuCloseStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDisplay"
        Me.Text = "File Name Display"
        Me.mnuCloseStrip.ResumeLayout(False)
        Me.mnuCloseStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuCloseStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
End Class
