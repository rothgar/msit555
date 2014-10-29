<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraphics
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBoxes = New System.Windows.Forms.Button()
        Me.btnLines = New System.Windows.Forms.Button()
        Me.btnCircles = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBoxes
        '
        Me.btnBoxes.Location = New System.Drawing.Point(12, 41)
        Me.btnBoxes.Name = "btnBoxes"
        Me.btnBoxes.Size = New System.Drawing.Size(75, 23)
        Me.btnBoxes.TabIndex = 1
        Me.btnBoxes.Text = "&Boxes"
        Me.btnBoxes.UseVisualStyleBackColor = True
        '
        'btnLines
        '
        Me.btnLines.Location = New System.Drawing.Point(12, 87)
        Me.btnLines.Name = "btnLines"
        Me.btnLines.Size = New System.Drawing.Size(75, 23)
        Me.btnLines.TabIndex = 2
        Me.btnLines.Text = "&Lines"
        Me.btnLines.UseVisualStyleBackColor = True
        '
        'btnCircles
        '
        Me.btnCircles.Location = New System.Drawing.Point(12, 132)
        Me.btnCircles.Name = "btnCircles"
        Me.btnCircles.Size = New System.Drawing.Size(75, 23)
        Me.btnCircles.TabIndex = 3
        Me.btnCircles.Text = "&Circles"
        Me.btnCircles.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 172)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(12, 216)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmGraphics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCircles)
        Me.Controls.Add(Me.btnLines)
        Me.Controls.Add(Me.btnBoxes)
        Me.Name = "frmGraphics"
        Me.Text = "Graphics Demonstration"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBoxes As System.Windows.Forms.Button
    Friend WithEvents btnLines As System.Windows.Forms.Button
    Friend WithEvents btnCircles As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
