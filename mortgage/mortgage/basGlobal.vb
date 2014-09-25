' Module:       basGlobal.vb

Option Explicit Off

Module basGlobal
    '
    'Module level code for the Mortgage project
    '
    'Module name: basGlobal.vb
    '
    Public Const gintYears As Integer = 30

    Sub main()
        Application.Run(frmMortgage)
    End Sub

    Public Function payment() As Single
        '
        'Returns monthly payment on mortgage or other loan
        'Loan term defined by Public Constant gintYears
        '
        'gsngPrincipal = loan principal
        'gsngInterestRate = monthly interest rate
        '
        Return gsngPrincipal * (gsngInterestRate / (1.0 - (gsngInterestRate + 1) ^ -intTerm))
    End Function

End Module