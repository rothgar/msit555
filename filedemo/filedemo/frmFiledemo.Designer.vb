<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFiledemo
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
        Me.mnuMainMenu = New System.Windows.Forms.MenuStrip()
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFile_Sequential = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFile_Random = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFile_Binary = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFile_S1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFile_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMainMenu.Name = "mnuMainMenu"
        Me.mnuMainMenu.Size = New System.Drawing.Size(284, 24)
        Me.mnuMainMenu.TabIndex = 1
        Me.mnuMainMenu.Text = "Main Menu"
        '
        'dlgOpenFile
        '
        Me.dlgOpenFile.FileName = "OpenFileDialog1"
        Me.dlgOpenFile.Title = "Open File Dialog"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile_Sequential, Me.mnuFile_Random, Me.mnuFile_Binary, Me.mnuFile_S1, Me.mnuFile_Exit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFile_Sequential
        '
        Me.mnuFile_Sequential.Name = "mnuFile_Sequential"
        Me.mnuFile_Sequential.Size = New System.Drawing.Size(152, 22)
        Me.mnuFile_Sequential.Text = "&Sequential"
        '
        'mnuFile_Random
        '
        Me.mnuFile_Random.Name = "mnuFile_Random"
        Me.mnuFile_Random.Size = New System.Drawing.Size(152, 22)
        Me.mnuFile_Random.Text = "&Random"
        '
        'mnuFile_Binary
        '
        Me.mnuFile_Binary.Name = "mnuFile_Binary"
        Me.mnuFile_Binary.Size = New System.Drawing.Size(152, 22)
        Me.mnuFile_Binary.Text = "&Binary"
        '
        'mnuFile_S1
        '
        Me.mnuFile_S1.Name = "mnuFile_S1"
        Me.mnuFile_S1.Size = New System.Drawing.Size(149, 6)
        '
        'mnuFile_Exit
        '
        Me.mnuFile_Exit.Name = "mnuFile_Exit"
        Me.mnuFile_Exit.Size = New System.Drawing.Size(152, 22)
        Me.mnuFile_Exit.Text = "E&xit"
        '
        'frmFiledemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.mnuMainMenu)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMainMenu
        Me.Name = "frmFiledemo"
        Me.Text = "File Demo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuMainMenu.ResumeLayout(False)
        Me.mnuMainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile_Sequential As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile_Random As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile_Binary As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile_S1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFile_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgOpenFile As System.Windows.Forms.OpenFileDialog

End Class
