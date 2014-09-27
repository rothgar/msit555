' Module:       frmMortgage.vb

Option Explicit On

Public Class frmMortgage

    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        '
        'Retrieve principal and interest rate amounts from form's text boxes
        'Use Val function to convert text to values
        'Divide interest rate by 1200 to get monthly interest rate
        '
        Dim gsngPrincipal = Val(Me.txtAmount.Text)
        Dim gsngInterestRate = Val(Me.txtRate.Text) / 1200.0
        Dim gsngPayment As Decimal
        'MsgBox(gsngPrincipal * (gsngInterestRate / (1.0 - (gsngInterestRate + 1) ^ -gintYears)))
        '
        'If either amount is 0 or less, display error message,
        'clear input text boxes, and exit procedure to start over.
        '
        If gsngPrincipal <= 0.0 Then
            MsgBox("Principal amount value is invalid.", 0, "Input Error!")
            Call btnClear_Click(sender, e)
            Exit Sub
        ElseIf gsngInterestRate <= 0.0 Then
            MsgBox("Interest rate value is invalid.", 0, "Input Error!")
            Call btnClear_Click(sender, e)
            Exit Sub
        Else
            '
            'Calculate payment and display it
            '
            gsngPayment = (gsngPrincipal * (gsngInterestRate / (1.0 - (gsngInterestRate + 1) ^ -gintYears)))
            Me.txtPayment.Text = Format(gsngPayment, "#####.##")
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        '
        'Clear all text boxes and set focus to Amount text box
        '
        Me.txtAmount.Clear()
        Me.txtPayment.Clear()
        Me.txtRate.Clear()

        Me.ActiveControl = Me.txtAmount
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        '
        ' Exit the program
        '
        End
    End Sub

End Class
