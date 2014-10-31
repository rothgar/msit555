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
        Me.components = New System.ComponentModel.Container()
        Me.btnBoxes = New System.Windows.Forms.Button()
        Me.btnLines = New System.Windows.Forms.Button()
        Me.btnCircles = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.boxButterfly1 = New System.Windows.Forms.PictureBox()
        Me.tmrButterfly = New System.Windows.Forms.Timer(Me.components)
        CType(Me.boxButterfly1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(128, 41)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(114, 23)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start Animation"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(128, 86)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(114, 23)
        Me.btnStop.TabIndex = 6
        Me.btnStop.Text = "Stop Animation"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'boxButterfly1
        '
        Me.boxButterfly1.Image = Global.graphics.My.Resources.Resources.BFLY1
        Me.boxButterfly1.Location = New System.Drawing.Point(128, 156)
        Me.boxButterfly1.Name = "boxButterfly1"
        Me.boxButterfly1.Size = New System.Drawing.Size(77, 77)
        Me.boxButterfly1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.boxButterfly1.TabIndex = 7
        Me.boxButterfly1.TabStop = False
        '
        'frmGraphics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 342)
        Me.Controls.Add(Me.boxButterfly1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCircles)
        Me.Controls.Add(Me.btnLines)
        Me.Controls.Add(Me.btnBoxes)
        Me.Name = "frmGraphics"
        Me.Text = "Graphics Demonstration"
        CType(Me.boxButterfly1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBoxes As System.Windows.Forms.Button
    Friend WithEvents btnLines As System.Windows.Forms.Button
    Friend WithEvents btnCircles As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents boxButterfly1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrButterfly As System.Windows.Forms.Timer

End Class
