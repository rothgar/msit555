' Module:       basGlobal.vb
' Author:       Justin Garrison
' Organization: Azusa Pacific University
' Application:  MSIT555 – Graphical User Interfaces, filedemo programming project
' Prepared for: Dr. Richard Eckhart
' Description:  Code module for the Filedemo application
'
' Initial Coding:    2014-10-07 - JLG
' Revisions:

Option Explicit On

Module basGlobal

    'Public declarations
    Public gstrBinaryFile As String
    Public gstrSequentialFile As String
    Public gstrRandomFile As String
    Public EditWindow As frmEditWindow
    Public Address As btnPrevious
    Public gstrUserFileName As String

    'Structure of random file access demo records
    Structure gusrAddress
        <VBFixedString(15)> Public LastName As String
        <VBFixedString(15)> Public FirstName As String
        <VBFixedString(20)> Public Address As String
        <VBFixedString(15)> Public City As String
        <VBFixedString(2)> Public State As String
        <VBFixedString(5)> Public Zip As String
    End Structure

    'Data about addresses
    Public usrInfo As gusrAddress
    Public lngMaxrec As Long
    Public lngCurrentrec As Long

End Module