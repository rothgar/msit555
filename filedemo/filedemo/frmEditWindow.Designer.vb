﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.mnuEditWindow_SaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtEdit = New System.Windows.Forms.TextBox()
        Me.dlgSaveAs_Edit = New System.Windows.Forms.SaveFileDialog()
        Me.mnuEditWindow.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuEditWindow
        '
        Me.mnuEditWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditWindow_Close, Me.mnuEditWindow_SaveAs})
        Me.mnuEditWindow.Location = New System.Drawing.Point(0, 0)
        Me.mnuEditWindow.Name = "mnuEditWindow"
        Me.mnuEditWindow.Size = New System.Drawing.Size(284, 24)
        Me.mnuEditWindow.TabIndex = 0
        Me.mnuEditWindow.Text = "Edit Window Menu"
        '
        'mnuEditWindow_Close
        '
        Me.mnuEditWindow_Close.Name = "mnuEditWindow_Close"
        Me.mnuEditWindow_Close.Size = New System.Drawing.Size(48, 20)
        Me.mnuEditWindow_Close.Text = "&Close"
        '
        'mnuEditWindow_SaveAs
        '
        Me.mnuEditWindow_SaveAs.Name = "mnuEditWindow_SaveAs"
        Me.mnuEditWindow_SaveAs.Size = New System.Drawing.Size(59, 20)
        Me.mnuEditWindow_SaveAs.Text = "Save &As"
        '
        'txtEdit
        '
        Me.txtEdit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEdit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEdit.Location = New System.Drawing.Point(0, 24)
        Me.txtEdit.Multiline = True
        Me.txtEdit.Name = "txtEdit"
        Me.txtEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtEdit.Size = New System.Drawing.Size(284, 238)
        Me.txtEdit.TabIndex = 1
        '
        'frmEditWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtEdit)
        Me.Controls.Add(Me.mnuEditWindow)
        Me.MainMenuStrip = Me.mnuEditWindow
        Me.Name = "frmEditWindow"
        Me.Text = "Edit Window"
        Me.mnuEditWindow.ResumeLayout(False)
        Me.mnuEditWindow.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuEditWindow As System.Windows.Forms.MenuStrip
    Friend WithEvents txtEdit As System.Windows.Forms.TextBox
    Friend WithEvents mnuEditWindow_Close As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dlgSaveAs_Edit As System.Windows.Forms.SaveFileDialog
    Friend WithEvents mnuEditWindow_SaveAs As System.Windows.Forms.ToolStripMenuItem
End Class
