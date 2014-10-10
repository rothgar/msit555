' Module:       frmFiledemo.vb

Option Explicit On

Public Class frmFiledemo

    Private Sub mnuFile_Sequential_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_Sequential.Click
        '
        'Sequential file access demo
        '
        'Local declarations
        '
        Dim strMsg As String  'a message string
        Dim intReply As Integer
        Dim strTxt As String  'a character string
        '
        'Initialize
        '
        strMsg = ""
        strMsg = strMsg & "This demonstration lets you open an existing text" & Chr(13) & Chr(10)
        strMsg = strMsg & "file (e.g., a Visual Basic form or code module)" & Chr(13) & Chr(10)
        strMsg = strMsg & "for editing in a window.  When you close the window," & Chr(13) & Chr(10)
        strMsg = strMsg & "the edited file is saved in file " & gstrSequentialFile & "." & Chr(13) & Chr(10)
        strMsg = strMsg & "The original file is not changed." & Chr(13) & Chr(10)
        intReply = MsgBox(strMsg, MsgBoxStyle.OkCancel, "Sequential Access Demo")
        If intReply = 1 Then
            'OK button selected
            If dlgOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Get the name of the file to open
                gstrUserFileName = dlgOpenFile.FileName
                If Trim(gstrUserFileName) <> "" Then
                    'Read the file and display it in the edit window.
                    FileOpen(1, gstrUserFileName, OpenMode.Input)
                    strTxt = ""
                    Do While Not EOF(1)
                        strTxt = strTxt & LineInput(1) & Chr(13) & Chr(10)
                    Loop
                    FileClose(1)
                    EditWindow = New frmEditWindow
                    EditWindow.MdiParent = Me
                    EditWindow.txtEdit.Text = strTxt
                    EditWindow.Text = gstrUserFileName
                    EditWindow.Show()
                End If
            End If
        End If
    End Sub

    Private Sub mnuFile_Random_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_Random.Click
        '
        'Random file access demo
        '
        'Local declarations
        '
        Dim strMsg As String  'a message string
        Dim intReply As Integer
        '
        'Initialize
        '
        strMsg = ""
        strMsg = strMsg & "This routine demonstrates random file access." & Chr(13) & Chr(10)
        strMsg = strMsg & "You can enter names and addresses and save them in" & Chr(13) & Chr(10)
        strMsg = strMsg & "a file.  You can also browse through existing" & Chr(13) & Chr(10)
        strMsg = strMsg & "entries in the file." & Chr(13) & Chr(10)
        strMsg = strMsg & "The data are saved in file " & gstrRandomFile & "." & Chr(13) & Chr(10)
        strMsg = strMsg & "Click on Next and Back to browse through records." & Chr(13) & Chr(10)
        strMsg = strMsg & "Click on New to enter a new record." & Chr(13) & Chr(10)
        strMsg = strMsg & "Click on Save to save the displayed record to disk." & Chr(13) & Chr(10)
        intReply = MsgBox(strMsg, MsgBoxStyle.OkCancel, "Random Access Demo")
        If intReply = 1 Then
            'OK button selected
            Address = New frmAddress
            Address.MdiParent = Me
            Address.Show()
        ElseIf intReply = 2 Then
            'Cancel button selected
            Exit Sub
        End If
    End Sub

    Private Sub mnuFile_Binary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_Binary.Click
        '
        'Binary file access demo
        '
        'Local declarations
        '
        Dim strChar As New String(" ", 1) 'a single character string
        Dim lngCharCount As Long  'character count as long integer
        Dim lngI As Long
        Dim strMsg As String  'a message string
        Dim intReply As Integer
        '
        'Initialize
        '
        lngCharCount = 0
        strMsg = ""
        strMsg = strMsg & "This demonstration lets you select an existing text" & Chr(13) & Chr(10)
        strMsg = strMsg & "file and then create a new file that is identical" & Chr(13) & Chr(10)
        strMsg = strMsg & "except that all lowercase letters have been converted" & Chr(13) & Chr(10)
        strMsg = strMsg & "to uppercase.  The new file is named " & gstrBinaryFile & "." & Chr(13) & Chr(10)
        strMsg = strMsg & "The original file is not changed." & Chr(13) & Chr(10)
        intReply = MsgBox(strMsg, MsgBoxStyle.OkCancel, "Binary Access Demo")
        If intReply = 1 Then
            'OK button selected
            If dlgOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Get the name of the file to open
                gstrUserFileName = dlgOpenFile.FileName
                If Trim(gstrUserFileName) <> "" Then
                    'Read the file, convert lowercase to uppercase,
                    'and write the new file.
                    FileOpen(1, gstrUserFileName, OpenMode.Binary)
                    FileOpen(2, CurDir() & "\" & gstrBinaryFile, OpenMode.Binary)
                    For lngI = 1 To LOF(1)
                        'Get a single character from the input file
                        'If it's a lower case letter,
                        'convert it to upper case and write it to
                        'the output file.  Otherwise, do not change it.
                        FileGet(1, strChar)
                        If Asc(strChar) > 96 And Asc(strChar) < 123 Then
                            strChar = Chr(Asc(strChar) - 32)
                        End If
                        FilePut(2, strChar)
                        lngCharCount = lngCharCount + 1
                    Next lngI
                    FileClose(1)
                    FileClose(2)
                    'Display the number of characters converted
                    strMsg = Str(lngCharCount) & " characters transferred."
                    MsgBox(strMsg, 0, "Binary Access Demo")
                End If
            End If
        ElseIf intReply = 2 Then
            'Cancel button selected
            Exit Sub
        End If
    End Sub

    Private Sub Filedemo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '
        'Name the files that the program will create.
        'If your folder has files with these names, change the
        'filenames here to avoid overwriting existing files.
        '
        gstrBinaryFile = "xxxxxxxx.dat"
        gstrSequentialFile = "yyyyyyyy.dat"
        gstrRandomFile = "zzzzzzzz.dat"

    End Sub

    Private Sub mnuFile_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFile_Exit.Click
        Me.Close()

    End Sub
End Class