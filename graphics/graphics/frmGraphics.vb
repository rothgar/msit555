' Module:       frmGrahics.vb
' Author:       Justin Garrison
' Organization: Azusa Pacific University
' Application:  MSIT555 – Graphical User Interfaces, graphics programming project
' Prepared for: Dr. Richard Eckhart
' Description:  Form module for the Graphics application
'
' Initial Coding:    2014-10-28
' Revisions:

Option Explicit On

Public Class frmGraphics

    Private Sub btnBoxes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBoxes.Click
        '
        'Draws 10 random filled boxes on the form
        '
        'Local declarations
        '
        'Drawing objects
        Dim objGraphics As System.Drawing.Graphics
        Dim objBrush As System.Drawing.SolidBrush
        'Color variables
        Dim intAlpha As Integer
        Dim intBlue As Integer
        Dim intGreen As Integer
        Dim intRed As Integer
        'Box properties variables
        Dim intHeight As Integer
        Dim intWidth As Integer
        Dim intX As Integer
        Dim intY As Integer
        'Loop index
        Dim intI As Integer
        '
        'Hide the button controls
        '
        Me.btnLines.Visible = False
        Me.btnCircles.Visible = False
        Me.btnBoxes.Visible = False
        Me.btnClear.Visible = False
        Me.btnExit.Visible = False
        '
        'Draw the boxes
        '
        objGraphics = Me.CreateGraphics()
        objGraphics.Clear(System.Drawing.Color.White)
        For intI = 1 To 10
            '
            'Random color selection for the pen
            '
            intAlpha = 255 * Rnd()
            intBlue = 255 * Rnd()
            intGreen = 255 * Rnd()
            intRed = 255 * Rnd()
            objBrush = New System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(intAlpha, intBlue, intGreen, intRed))
            '
            'Random box properties
            '
            intHeight = Rnd() * Me.Height
            If intHeight <= 0 Then
                intHeight = 0.5 * Me.Height
            End If
            intWidth = Rnd() * Me.Width
            If intWidth <= 0 Then
                intWidth = 0.5 * Me.Width
            End If
            intX = Rnd() * (Me.Width - intWidth)
            intY = Rnd() * (Me.Height - intHeight)
            '
            'Draw a box
            '
            objGraphics.FillRectangle(objBrush, intX, intY, intWidth, intHeight)
            objBrush.Dispose()
        Next intI
        '
        'Unhide the button controls
        '
        Me.btnLines.Visible = True
        Me.btnCircles.Visible = True
        Me.btnBoxes.Visible = True
        Me.btnClear.Visible = True
        Me.btnExit.Visible = True
        objGraphics.Dispose()
    End Sub

    Private Sub btnCircles_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCircles.Click
        '
        'Draws 100 random circles on the form
        '
        'Local declarations
        '
        'Drawing objects
        Dim objGraphics As System.Drawing.Graphics
        Dim objPen As System.Drawing.Pen
        'Color variables
        Dim intAlpha As Integer
        Dim intBlue As Integer
        Dim intGreen As Integer
        Dim intRed As Integer
        'Circle properties variables
        Dim intDiameter As Integer
        Dim intX As Integer
        Dim intY As Integer
        'Loop index
        Dim intI As Integer
        '
        'Hide the button controls
        '
        Me.btnLines.Visible = False
        Me.btnCircles.Visible = False
        Me.btnBoxes.Visible = False
        Me.btnClear.Visible = False
        Me.btnExit.Visible = False
        '
        'Draw the circles
        '
        objGraphics = Me.CreateGraphics()
        objGraphics.Clear(System.Drawing.Color.White)
        For intI = 1 To 100
            '
            'Random color selection for the pen
            '
            intAlpha = 255 * Rnd()
            intBlue = 255 * Rnd()
            intGreen = 255 * Rnd()
            intRed = 255 * Rnd()
            objPen = New System.Drawing.Pen(System.Drawing.Color.FromArgb(intAlpha, intBlue, intGreen, intRed))
            objPen.Width = 2
            '
            'Random circle properties
            '
            intDiameter = Rnd() * Me.Height
            If intDiameter <= 0 Then
                intDiameter = 0.5 * Me.Height
            End If
            intX = Rnd() * (Me.Width - intDiameter)
            intY = Rnd() * (Me.Height - intDiameter)
            '
            'Draw a circle
            '
            objGraphics.DrawArc(objPen, intX, intY, intDiameter, intDiameter, 0, 360)
            objPen.Dispose()
        Next intI
        '
        'Unhide the button controls
        '
        Me.btnLines.Visible = True
        Me.btnCircles.Visible = True
        Me.btnBoxes.Visible = True
        Me.btnClear.Visible = True
        Me.btnExit.Visible = True
        objGraphics.Dispose()
    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        '
        'Clears the drawing surface
        '
        'Local declarations
        '
        Dim objGraphics As System.Drawing.Graphics
        objGraphics = Me.CreateGraphics()
        objGraphics.Clear(System.Drawing.Color.White)
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        '
        'Terminate the program
        '
        End
    End Sub

    Private Sub btnLines_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLines.Click
        '
        'Draws 500 random lines on the form
        '
        'Local declarations
        '
        'Drawing objects
        Dim objGraphics As System.Drawing.Graphics
        Dim objPen As System.Drawing.Pen
        'Color variables
        Dim intAlpha As Integer
        Dim intBlue As Integer
        Dim intGreen As Integer
        Dim intRed As Integer
        'Line properties variables
        Dim intX1 As Integer
        Dim intY1 As Integer
        Dim intX2 As Integer
        Dim intY2 As Integer
        'Loop index
        Dim intI As Integer
        '
        'Hide the button controls
        '
        Me.btnLines.Visible = False
        Me.btnCircles.Visible = False
        Me.btnBoxes.Visible = False
        Me.btnClear.Visible = False
        Me.btnExit.Visible = False
        '
        'Draw the lines
        '
        objGraphics = Me.CreateGraphics()
        objGraphics.Clear(System.Drawing.Color.White)
        For intI = 1 To 500
            '
            'Random color selection for the pen
            '
            intAlpha = 255 * Rnd()
            intBlue = 255 * Rnd()
            intGreen = 255 * Rnd()
            intRed = 255 * Rnd()
            objPen = New System.Drawing.Pen(System.Drawing.Color.FromArgb(intAlpha, intBlue, intGreen, intRed))
            objPen.Width = 2
            '
            'Random line properties
            '
            intX1 = Rnd() * Me.Width
            intY1 = Rnd() * Me.Height
            intX2 = Rnd() * Me.Width
            intY2 = Rnd() * Me.Height
            '
            'Draw a line
            '
            objGraphics.DrawLine(objPen, intX1, intY1, intX2, intY2)
            objPen.Dispose()
        Next intI
        '
        'Unhide the button controls
        '
        Me.btnLines.Visible = True
        Me.btnCircles.Visible = True
        Me.btnBoxes.Visible = True
        Me.btnClear.Visible = True
        Me.btnExit.Visible = True
        objGraphics.Dispose()
    End Sub
End Class
