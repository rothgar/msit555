' Module:       basGlobal.vb
' Author:       Richard A. Eckhart
' Organization: Azusa Pacific University
' Application:  MSIT555 – Graphical User Interfaces, multform programming project
' Prepared for: Dr. Richard Eckhart
' Description:  Code module for the Multform application
'
' Initial Coding:    1-8-2013 - RAE
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