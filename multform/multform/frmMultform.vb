' Module:       frmMultform.vb

Option Explicit On

Public Class frmMultform

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnFormA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFormA.Click
        If frmFormA Is Nothing Then
            frmFormA = New frmMultA()
            frmFormA.Show()
        Else
            frmFormA.Visible = True
        End If
        Me.Visible = False
    End Sub

    Private Sub btnFormB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnFormB.Click
        If frmFormB Is Nothing Then
            frmFormB = New frmMultB()
            frmFormB.Show()
        Else
            If frmFormA IsNot Nothing Then
                frmFormA.Visible = False
                frmFormA = Nothing
            End If
            frmFormB.Visible = True
        End If
    End Sub

End Class
