' Module:       frmPrintdemo.vb

Option Explicit On

Imports System.Drawing.Printing

Public Class frmPrintdemo

    Inherits System.Windows.Forms.Form

    '
    'Module-level declarations
    '
    Private strStringToPrint As String
    Private prnFont As New Font("Arial", 20)

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        '
        'Terminate the program
        '
    End Sub

    Private Sub btnPrinttext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPrinttext.Click
        '
        'This procedure prints the contents of a text box
        'outlined by a rectancgle that delimits the page's
        'printable area.
        '
        'Local declarations
        '
        Dim intCopies As Integer
        Dim intI As Integer
        Try
            '
            'Check if there is any text in the text box to print
            '
            If Trim(Me.txtPrinttext.Text) <> "" Then
                '
                'Set properties of the print dialog
                '
                Me.dlgPrint.AllowPrintToFile = False
                Me.dlgPrint.AllowSelection = False
                Me.dlgPrint.AllowSomePages = False
                Me.dlgPrint.PrinterSettings = New System.Drawing.Printing.PrinterSettings
                '
                'Set the page properties
                '
                Me.dlgPageSetup.PageSettings = Me.docPrint.DefaultPageSettings
                If Me.dlgPageSetup.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Me.docPrint.DefaultPageSettings = Me.dlgPageSetup.PageSettings
                    '
                    'Set the print document property
                    '
                    Me.dlgPrint.Document = Me.docPrint
                    '
                    'Print the page(s)?
                    '
                    If Me.dlgPrint.ShowDialog = Windows.Forms.DialogResult.OK Then
                        '
                        'Get the number of copies to print
                        '
                        intCopies = Me.dlgPrint.PrinterSettings.Copies
                        '
                        'Print the page(s)
                        '
                        For intI = 1 To intCopies
                            Me.docPrint.Print()
                        Next intI
                    End If
                End If
            Else
                MsgBox("Nothing to print", MsgBoxStyle.OkOnly, "Print the Text Box")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly, "Error...")
        End Try
    End Sub

    Private Sub docPrint_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles docPrint.BeginPrint
        '
        'Initialize the string to print at the start of printing
        '
        strStringToPrint = Me.txtPrinttext.Text
    End Sub

    Private Sub docPrint_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles docPrint.PrintPage
        '
        'This procedure sets up the page to be printed
        '
        'Local declarations
        '
        Dim intLmargin As Integer  'Left margin of the page
        Dim intRmargin As Integer  'Right margin of the page
        Dim intTmargin As Integer  'Top margin of the page
        Dim intBmargin As Integer  'Bottom margin of the page
        Dim intPageWidth As Integer  'Width of the page
        Dim intPageHeight As Integer  'Height of the page
        Dim intPrintWidth As Integer  'Width of the page print area
        Dim intPrintHeight As Integer  'Height of the page print area
        Dim intNumberOfChars As Integer
        Dim intNumberOfLines As Integer
        Dim strStringForPage As String  'String to print on one page
        Dim strFormat As New StringFormat()
        '
        'Get the page margins
        '
        With Me.docPrint.DefaultPageSettings.Margins
            intLmargin = .Left
            intRmargin = .Right
            intTmargin = .Top
            intBmargin = .Bottom
        End With
        '
        'Get the page dimensions
        '
        With Me.docPrint.DefaultPageSettings.PaperSize
            If Me.docPrint.DefaultPageSettings.Landscape Then
                intPageWidth = .Height
                intPageHeight = .Width
            Else
                intPageWidth = .Width
                intPageHeight = .Height
            End If
        End With
        '
        'Set the area for printing a page
        '
        intPrintWidth = intPageWidth - intLmargin - intRmargin
        intPrintHeight = intPageHeight - intTmargin - intBmargin
        '
        'Get the size of the printable area
        '
        Dim sizeMeasure As New SizeF(intPrintWidth, intPrintHeight - prnFont.GetHeight(e.Graphics))
        '
        'When drawing long strings, break between words
        '
        strFormat.Trimming = StringTrimming.Word
        '
        'Compute how many characters and lines can fit in the print area
        '
        e.Graphics.MeasureString(strStringToPrint, prnFont, sizeMeasure, strFormat, intNumberOfChars, intNumberOfLines)
        '
        'Get the string that will fit on the page
        '
        strStringForPage = strStringToPrint.Substring(0, intNumberOfChars)
        '
        'Draw the rectangle outlining the print area on the page
        '
        Dim rectArea As New RectangleF(intLmargin, intTmargin, intPrintWidth, intPrintHeight)
        e.Graphics.DrawRectangle(Pens.Black, intLmargin, intTmargin, intPrintWidth, intPrintHeight)
        '
        'Print the text within the rectangle
        '
        e.Graphics.DrawString(strStringForPage, prnFont, Brushes.Black, rectArea, strFormat)
        '
        'Check if all characters/lines have been printed
        '
        If intNumberOfChars < strStringToPrint.Length Then
            strStringToPrint = strStringToPrint.Substring(intNumberOfChars)
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

End Class
