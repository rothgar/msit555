' Module:       frmAddress.vb

Option Explicit On

Public Class frmAddress

    Private Sub mnuAddressClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuAddressClose.Click
        '
        'Close the window
        '
        Me.Close()
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        '
        'Move to the next record, if any
        '
        'If at the last record already, beep
        'Otherwise, increment record pointer
        'and get and display next record
        If lngCurrentrec >= lngMaxrec Then
            Beep()  'Sound a tone
        Else
            lngCurrentrec = lngCurrentrec + 1
            FileGet(1, usrInfo, lngCurrentrec)
            Me.txtFname.Text = usrInfo.FirstName
            Me.txtLname.Text = usrInfo.LastName
            Me.txtAddress.Text = usrInfo.Address
        End If

    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        '
        'Move to the previous record, if any
        '
        'If at the first record already, beep
        'Otherwise, decrement record pointer
        'and get and display previous record
        If lngCurrentrec <= 1 Then
            Beep()  'Sound a tone
        Else
            lngCurrentrec = lngCurrentrec - 1
            FileGet(1, usrInfo, lngCurrentrec)
            Me.txtFname.Text = usrInfo.FirstName
            Me.txtLname.Text = usrInfo.LastName
            Me.txtAddress.Text = usrInfo.Address
        End If

    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNew.Click
        '
        'Create a new record
        '
        'Point at the record past the last one
        'Clear all the displayed fields
        lngCurrentrec = lngMaxrec + 1
        Me.txtFname.Text = ""
        Me.txtLname.Text = ""
        Me.txtAddress.Text = ""
        Me.txtFname.Focus()

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        '
        'Save the current record
        '
        'Point at the record past the last one
        'Save all the displayed fields
        If lngCurrentrec <= lngMaxrec Then
            lngCurrentrec = lngMaxrec + 1
        End If
        usrInfo.FirstName = Me.txtFname.Text
        usrInfo.LastName = Me.txtLname.Text
        usrInfo.Address = Me.txtAddress.Text
        FilePut(1, usrInfo, lngCurrentrec)
        If lngCurrentrec = lngMaxrec + 1 Then
            lngMaxrec = lngMaxrec + 1
        End If

    End Sub

    Private Sub Address_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '
        'Open the random access file and initialize the display
        '
        FileOpen(1, CurDir() & "\" & gstrRandomFile, OpenMode.Random, , , Len(usrInfo))
        lngMaxrec = LOF(1) / Len(usrInfo)
        'If the file is not empty, show the first record
        'Otherwise, blank all the displayed fields
        If lngMaxrec > 0 Then
            lngCurrentrec = 1
            FileGet(1, usrInfo, 1)
            Me.txtFname.Text = usrInfo.FirstName
            Me.txtLname.Text = usrInfo.LastName
            Me.txtZip.Text = usrInfo.Zip
        Else
            lngCurrentrec = 0
            Me.txtFname.Text = ""
            Me.txtLname.Text = ""
            Me.txtAddress.Text = ""
        End If
    End Sub

    Private Sub Address_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        '
        'Close the file
        '
        FileClose(1)
        '
        'Dispose the window
        '
        Me.Dispose()
    End Sub

End Class
