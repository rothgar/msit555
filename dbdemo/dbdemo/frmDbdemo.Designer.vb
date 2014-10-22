<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDbdemo
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
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFriendName = New System.Windows.Forms.Label()
        Me.lblFriendPhone = New System.Windows.Forms.Label()
        Me.txtFriendName = New System.Windows.Forms.TextBox()
        Me.txtFriendPhone = New System.Windows.Forms.TextBox()
        Me.SampleDataSet = New dbdemo.sampleDataSet()
        Me.FriendsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FriendsTableAdapter = New dbdemo.sampleDataSetTableAdapters.FriendsTableAdapter()
        CType(Me.SampleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FriendsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(293, 54)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Text = "&First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(293, 107)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "&Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(293, 161)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(293, 209)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 3
        Me.btnLast.Text = "&Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(411, 76)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(100, 54)
        Me.btnShow.TabIndex = 4
        Me.btnShow.Text = "&Show Database Properties"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(423, 161)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFriendName
        '
        Me.lblFriendName.AutoSize = True
        Me.lblFriendName.Location = New System.Drawing.Point(24, 91)
        Me.lblFriendName.Name = "lblFriendName"
        Me.lblFriendName.Size = New System.Drawing.Size(70, 13)
        Me.lblFriendName.TabIndex = 6
        Me.lblFriendName.Text = "Friend Name:"
        '
        'lblFriendPhone
        '
        Me.lblFriendPhone.AutoSize = True
        Me.lblFriendPhone.Location = New System.Drawing.Point(21, 171)
        Me.lblFriendPhone.Name = "lblFriendPhone"
        Me.lblFriendPhone.Size = New System.Drawing.Size(73, 13)
        Me.lblFriendPhone.TabIndex = 7
        Me.lblFriendPhone.Text = "Friend Phone:"
        '
        'txtFriendName
        '
        Me.txtFriendName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FriendsBindingSource, "FriendName", True))
        Me.txtFriendName.Location = New System.Drawing.Point(113, 88)
        Me.txtFriendName.Name = "txtFriendName"
        Me.txtFriendName.Size = New System.Drawing.Size(161, 20)
        Me.txtFriendName.TabIndex = 8
        '
        'txtFriendPhone
        '
        Me.txtFriendPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FriendsBindingSource, "FriendPhone", True))
        Me.txtFriendPhone.Location = New System.Drawing.Point(113, 168)
        Me.txtFriendPhone.Name = "txtFriendPhone"
        Me.txtFriendPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtFriendPhone.TabIndex = 9
        '
        'SampleDataSet
        '
        Me.SampleDataSet.DataSetName = "sampleDataSet"
        Me.SampleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FriendsBindingSource
        '
        Me.FriendsBindingSource.DataMember = "Friends"
        Me.FriendsBindingSource.DataSource = Me.SampleDataSet
        '
        'FriendsTableAdapter
        '
        Me.FriendsTableAdapter.ClearBeforeFill = True
        '
        'frmDbdemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 268)
        Me.Controls.Add(Me.txtFriendPhone)
        Me.Controls.Add(Me.txtFriendName)
        Me.Controls.Add(Me.lblFriendPhone)
        Me.Controls.Add(Me.lblFriendName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Name = "frmDbdemo"
        Me.Text = "Database Access Demo with Bound Controls"
        CType(Me.SampleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FriendsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblFriendName As System.Windows.Forms.Label
    Friend WithEvents lblFriendPhone As System.Windows.Forms.Label
    Friend WithEvents txtFriendName As System.Windows.Forms.TextBox
    Friend WithEvents txtFriendPhone As System.Windows.Forms.TextBox
    Friend WithEvents SampleDataSet As dbdemo.sampleDataSet
    Friend WithEvents FriendsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FriendsTableAdapter As dbdemo.sampleDataSetTableAdapters.FriendsTableAdapter

End Class
