' Module:       frmMenudemo.vb
' Author:       Justin Garrison
' Organization: Azusa Pacific University
' Application:  MSIT555 – Graphical User Interfaces, menudemo programming project
' Prepared for: Dr. Richard Eckhart
' Description:  Form module for the Menudemo application
'
' Initial Coding:    2014-09-29

Option Explicit On

Public Class frmMenudemo

    'Initialize public variables
    Public gintFileListIndex As Integer = 1
    Public gstrFileName As String = ""
    Public garrFileName As New ArrayList()
    Public garrFileNamePos As New ArrayList()

    'Initialize local variables
    Dim strTemp As String

    Private Sub mnuFile_Open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_Open.Click

        Dim intTemp As Integer
        intTemp = mnuFile.DropDownItems.IndexOf(mnuFile_Open)
        'Set the OpenFileDialog box filter
        Me.dlgOpenFile.Filter = "VB module files only (*.VB)|*.vb|VB resource files only (*.RESX)|*.resx|VB solution files only (*.SLN)|*.sln|Executable files only (*.EXE)|*exe|All files (*.*)|*.*"

        'Setup the code for handling the "Cancel" button on the OpenFileDialog box
        Dim DialogStatus As Integer
        DialogStatus = Me.dlgOpenFile.ShowDialog

        'Show the OpenFileDialog box
        Select Case DialogStatus
            Case DialogResult.Cancel

                'Return message if "Cancel" button is pushed
                MsgBox("Cancel Button selected.", 0, "Open Dialog")
            Case DialogResult.OK

                'Set the filename selected from the dialogbox
                gstrFileName = Me.dlgOpenFile.FileName

                'Add the filename
                Call AddFileName()
            Case Else

                'Return message if there is some sort of other error in the dialogbox
                strTemp = ""
                strTemp = strTemp & DialogStatus
                MsgBox(strTemp, 0, "Open Dialog")
        End Select

    End Sub

    Private Sub mnuFile_SaveAs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFile_SaveAs.Click

        If Trim(gstrFileName) <> "" Then
            'Setup the code for handling the "Cancel" button on the SaveAsDialog box
            Dim DialogStatus As Integer
            Me.dlgSaveAs.FileName = gstrFileName
            DialogStatus = Me.dlgSaveAs.ShowDialog

            'Show the OpenFileDialog box
            Select Case DialogStatus
                Case DialogResult.Cancel

                    'Return message if "Cancel" button is pushed

                Case DialogResult.OK

                    'Check the filename specified in the dialogbox
                    strTemp = Me.dlgSaveAs.FileName
                    If Trim(strTemp) <> Trim(gstrFileName) Then
                        gstrFileName = Me.dlgSaveAs.FileName

                        'Add the filename to the menu list

                    End If
                    'Set the filename selected from the dialogbox
                    gstrFileName = Me.dlgSaveAs.FileName

                    'Add the filename
                    Call AddFileName()
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

    Private Sub mnuFile_Exit_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFile_Exit.Click

        'Exit the program
        End

    End Sub

    '*** General Subroutines
    Sub AddFileName()

        Dim intTemp As Integer
        Dim intI As Integer
        Dim menuitemlist As New ArrayList
        'Process only if there is a value in the filename string
        If gstrFileName <> "" Then

            'Inserts/adds new file names in the File menu item
            mnuFile.DropDownItems.Add(gstrFileName)
            intTemp = mnuFile.DropDownItems.Count

            'Display the file window
            Call DisplayForm()
        End If

    End Sub

    Private Sub DisplayForm()

        'Display the file window
        Dim frmDisplay As New frmDisplay()

        'Set MDI values
        frmDisplay.MdiParent = Me

        'Set the filename display text
        frmDisplay.txtFileName.Text = gstrFileName

        'Show the form
        frmDisplay.Show()

    End Sub

End Class
