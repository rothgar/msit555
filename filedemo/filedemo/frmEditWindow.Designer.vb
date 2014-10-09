<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditWindow
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
        Me.mnuEditWindow = New System.Windows.Forms.MenuStrip()
        Me.mnuEditWindow_Close = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtEdit = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuEditWindow1_Close = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtEdit1 = New System.Windows.Forms.TextBox()
        Me.mnuEditWindow.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuEditWindow
        '
        Me.mnuEditWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditWindow_Close})
        Me.mnuEditWindow.Location = New System.Drawing.Point(0, 0)
        Me.mnuEditWindow.Name = "mnuEditWindow"
        Me.mnuEditWindow.Size = New System.Drawing.Size(284, 24)
        Me.mnuEditWindow.TabIndex = 0
        Me.mnuEditWindow.Text = "Edit Window Menu"
        '
        'mnuEditWindow_Close
        '
        Me.mnuEditWindow_Close.Name = "mnuEditWindow_Close"
        Me.mnuEditWindow_Close.Size = New System.Drawing.Size(12, 20)
        '
        'txtEdit
        '
        Me.txtEdit.Location = New System.Drawing.Point(0, 0)
        Me.txtEdit.Name = "txtEdit"
        Me.txtEdit.Size = New System.Drawing.Size(100, 20)
        Me.txtEdit.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditWindow1_Close})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuEditWindow1_Close
        '
        Me.mnuEditWindow1_Close.Name = "mnuEditWindow1_Close"
        Me.mnuEditWindow1_Close.Size = New System.Drawing.Size(48, 20)
        Me.mnuEditWindow1_Close.Text = "&Close"
        '
        'txtEdit1
        '
        Me.txtEdit1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEdit1.Location = New System.Drawing.Point(12, 27)
        Me.txtEdit1.Multiline = True
        Me.txtEdit1.Name = "txtEdit1"
        Me.txtEdit1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEdit1.Size = New System.Drawing.Size(260, 223)
        Me.txtEdit1.TabIndex = 1
        '
        'frmEditWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtEdit1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmEditWindow"
        Me.Text = "Edit Window"
        Me.mnuEditWindow.ResumeLayout(False)
        Me.mnuEditWindow.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuEditWindow As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuEditWindow_Close As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtEdit As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuEditWindow1_Close As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtEdit1 As System.Windows.Forms.TextBox
End Class
