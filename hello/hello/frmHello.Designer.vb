﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHello
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radEnglish = New System.Windows.Forms.RadioButton()
        Me.radItalian = New System.Windows.Forms.RadioButton()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.txtHello_World = New System.Windows.Forms.TextBox()
        Me.radSpanish = New System.Windows.Forms.RadioButton()
        Me.radGerman = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(80, 159)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'radEnglish
        '
        Me.radEnglish.AutoSize = True
        Me.radEnglish.Checked = True
        Me.radEnglish.Location = New System.Drawing.Point(32, 65)
        Me.radEnglish.Name = "radEnglish"
        Me.radEnglish.Size = New System.Drawing.Size(59, 17)
        Me.radEnglish.TabIndex = 2
        Me.radEnglish.TabStop = True
        Me.radEnglish.Text = "English"
        Me.radEnglish.UseVisualStyleBackColor = True
        '
        'radItalian
        '
        Me.radItalian.AutoSize = True
        Me.radItalian.Location = New System.Drawing.Point(32, 97)
        Me.radItalian.Name = "radItalian"
        Me.radItalian.Size = New System.Drawing.Size(53, 17)
        Me.radItalian.TabIndex = 4
        Me.radItalian.TabStop = True
        Me.radItalian.Text = "Italian"
        Me.radItalian.UseVisualStyleBackColor = True
        '
        'radFrench
        '
        Me.radFrench.AutoSize = True
        Me.radFrench.Location = New System.Drawing.Point(156, 65)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(58, 17)
        Me.radFrench.TabIndex = 3
        Me.radFrench.TabStop = True
        Me.radFrench.Text = "French"
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'txtHello_World
        '
        Me.txtHello_World.Location = New System.Drawing.Point(32, 22)
        Me.txtHello_World.Name = "txtHello_World"
        Me.txtHello_World.Size = New System.Drawing.Size(182, 20)
        Me.txtHello_World.TabIndex = 1
        Me.txtHello_World.TabStop = False
        Me.txtHello_World.Text = "Hello, World!"
        '
        'radSpanish
        '
        Me.radSpanish.AutoSize = True
        Me.radSpanish.Location = New System.Drawing.Point(156, 97)
        Me.radSpanish.Name = "radSpanish"
        Me.radSpanish.Size = New System.Drawing.Size(63, 17)
        Me.radSpanish.TabIndex = 5
        Me.radSpanish.TabStop = True
        Me.radSpanish.Text = "Spanish"
        Me.radSpanish.UseVisualStyleBackColor = True
        '
        'radGerman
        '
        Me.radGerman.AutoSize = True
        Me.radGerman.Location = New System.Drawing.Point(91, 125)
        Me.radGerman.Name = "radGerman"
        Me.radGerman.Size = New System.Drawing.Size(62, 17)
        Me.radGerman.TabIndex = 6
        Me.radGerman.TabStop = True
        Me.radGerman.Text = "German"
        Me.radGerman.UseVisualStyleBackColor = True
        '
        'frmHello
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 203)
        Me.Controls.Add(Me.radGerman)
        Me.Controls.Add(Me.radSpanish)
        Me.Controls.Add(Me.txtHello_World)
        Me.Controls.Add(Me.radFrench)
        Me.Controls.Add(Me.radItalian)
        Me.Controls.Add(Me.radEnglish)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmHello"
        Me.Text = "Hello, World!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents radEnglish As System.Windows.Forms.RadioButton
    Friend WithEvents radItalian As System.Windows.Forms.RadioButton
    Friend WithEvents radFrench As System.Windows.Forms.RadioButton
    Friend WithEvents txtHello_World As System.Windows.Forms.TextBox
    Friend WithEvents radSpanish As System.Windows.Forms.RadioButton
    Friend WithEvents radGerman As System.Windows.Forms.RadioButton

End Class
