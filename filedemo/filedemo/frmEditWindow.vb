' Module:       frmEditWindow.vb

Option Explicit On

Public Class frmEditWindow

    Private Sub mnuEditWindow_Close_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuEditWindow_Close.Click
        '
        'Close the window
        '
        Me.Close()
    End Sub

    Private Sub EditWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '
        'Save the edited file
        '
        FileOpen(1, CurDir() & "\" & gstrSequentialFile, OpenMode.Output)
        PrintLine(1, Me.txtEdit.Text)
        FileClose(1)
        '
        'Dispose the window
        '
        Me.Dispose()
    End Sub

End Class