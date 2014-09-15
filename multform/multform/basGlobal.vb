' Module:       basGlobal.vb
' Author:       Justin Garrison
' Organization: Azusa Pacific University
' Application:  MSIT555 – Graphical User Interfaces, multform programming project
' Prepared for: Dr. Richard Eckhart
' Description:  Code module for the Multform application
'
' Initial Coding:    2014-09-14 - JLG
' Revisions:

Option Explicit On

Module basGlobal

    Public frmMain As frmMultform
    Public frmFormA As frmMultA
    Public frmFormB As frmMultB

    Sub main()
        frmMain = New frmMultform()
        frmFormA = Nothing
        frmFormB = Nothing
        Application.Run(frmMain)
    End Sub

End Module