' Module:       frmDbdemo.vb
' Author:       Justin Garrison
' Organization: Azusa Pacific University
' Application:  MSIT555 – Graphical User Interfaces, dbdemo programming project
' Prepared for: Dr. Richard Eckhart
' Description:  Form module for the Dbdemo application
'
' Initial Coding:    2014-10-21 - JLG
' Revisions:

Option Explicit On

Public Class frmDbdemo

    Private Sub frmDbdemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SampleDataSet.Friends' table. You can move, or remove it, as needed.
        Me.FriendsTableAdapter.Fill(Me.SampleDataSet.Friends)
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        '
        'Terminate the program
        '
        End
    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        '
        'Move to the first record
        '
        Me.FriendsBindingSource.MoveFirst()
    End Sub

    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLast.Click
        '
        'Move to the last record
        '
        Me.FriendsBindingSource.MoveLast()
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        '
        'Move to the next record
        '
        Me.FriendsBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        '
        'Move to the previous record
        '
        Me.FriendsBindingSource.MovePrevious()
    End Sub

    Private Sub btnShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnShow.Click
        '
        'Show the current database properties
        '
        'Local declarations
        '
        Dim strMessage As String
        Dim intI As Integer
        Dim intTableCount As Integer
        Dim strName As String
        Dim intRowCount As Integer
        Dim intColumnCount As Integer

        '
        'Set the initial overall message
        '
        strMessage = ""
        'strMessage = strMessage & "Database Connection String: " & sampleConnectionString & Chr(10) & Chr(13) & Chr(10) & Chr(13)
        'strMessage = strMessage & "Database Provider: " & cnnFriends.Provider & Chr(10) & Chr(13) & Chr(10) & Chr(13)
        strMessage = strMessage & "Database Data Member: " & Me.FriendsBindingSource.DataMember & Chr(10) & Chr(13) & Chr(10) & Chr(13)
        '
        'Get the number of tables
        '
        intTableCount = SampleDataSet.Tables.Count
        strMessage = strMessage & "Number of Tables: " & Str(intTableCount) & Chr(10) & Chr(13)
        '
        'Show the properties of each table
        '
        For intI = 0 To intTableCount - 1
            strName = "(" & SampleDataSet.Tables(intI).TableName & ")"
            intRowCount = SampleDataSet.Tables(intI).Rows.Count
            intColumnCount = SampleDataSet.Tables(intI).Columns.Count
            strMessage = strMessage & "  Table " & Str(intI + 1) & " " & strName & " has " & Str(intRowCount) & " rows/records in " & Str(intColumnCount) & " columns/fields" & Chr(10) & Chr(13)
            For intJ = 0 To intColumnCount - 1
                strName = SampleDataSet.Tables(intI).Columns(intJ).ColumnName
                strMessage = strMessage & "    Column/Field " & Str(intJ + 1) & " - " & strName & Chr(10) & Chr(13)
            Next intJ
        Next intI
        MsgBox(strMessage, MsgBoxStyle.OkOnly, "Database Properties")
    End Sub
End Class
