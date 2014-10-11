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

    Private Sub mnuEditWindow_SaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEditWindow_SaveAs.Click
        gstrFileName = gstrUserFileName
        If Trim(gstrFileName) <> "" Then
            'Setup the code for handling the "Cancel" button on the SaveAsDialog box
            Dim DialogStatus As Integer
            Me.dlgSaveAs_Edit.FileName = gstrFileName
            DialogStatus = Me.dlgSaveAs_Edit.ShowDialog

            'Show the OpenFileDialog box
            Select Case DialogStatus
                Case DialogResult.Cancel

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
                Case DialogResult.OK

                    'Check the filename specified in the dialogbox
                    strTemp = Me.dlgSaveAs_Edit.FileName
                    If Trim(strTemp) <> Trim(gstrFileName) Then
                        gstrFileName = Me.dlgSaveAs_Edit.FileName

                        'Add the filename to the menu list

                    End If
                    'Set the filename selected from the dialogbox
                    gstrFileName = Me.dlgSaveAs_Edit.FileName

                    '
                    'Save the edited file
                    '
                    FileOpen(1, strTemp, OpenMode.Output)
                    PrintLine(1, Me.txtEdit.Text)
                    FileClose(1)
                    '
                    'Dispose the window
                    '
                    Me.Dispose()
                Case Else

                    'Return message if there is some sort of other error in the dialogbox
                    strTemp = ""
                    strTemp = strTemp & DialogStatus
                    MsgBox(strTemp, 0, "Save As... Dialog")
            End Select

        Else

            'No current file named to Save As...
            MsgBox("No current file name to Save As...", 0, "Save As...")

        End If

    End Sub
End Class