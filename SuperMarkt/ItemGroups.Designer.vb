<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemGroups
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
        Dim GroupIDLabel As System.Windows.Forms.Label
        Dim GroupNameLabel As System.Windows.Forms.Label
        Dim GroupDateLabel As System.Windows.Forms.Label
        Dim GroupTimeLabel As System.Windows.Forms.Label
        Dim GroupUserLabel As System.Windows.Forms.Label
        Me.GroupID = New System.Windows.Forms.TextBox()
        Me.GroupName = New System.Windows.Forms.TextBox()
        Me.GroupDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupTime = New System.Windows.Forms.DateTimePicker()
        Me.GroupUser = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        GroupIDLabel = New System.Windows.Forms.Label()
        GroupNameLabel = New System.Windows.Forms.Label()
        GroupDateLabel = New System.Windows.Forms.Label()
        GroupTimeLabel = New System.Windows.Forms.Label()
        GroupUserLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupIDLabel
        '
        GroupIDLabel.AutoSize = True
        GroupIDLabel.Location = New System.Drawing.Point(81, 122)
        GroupIDLabel.Name = "GroupIDLabel"
        GroupIDLabel.Size = New System.Drawing.Size(54, 13)
        GroupIDLabel.TabIndex = 1
        GroupIDLabel.Text = "Group ID:"
        '
        'GroupID
        '
        Me.GroupID.Location = New System.Drawing.Point(141, 122)
        Me.GroupID.Name = "GroupID"
        Me.GroupID.Size = New System.Drawing.Size(152, 20)
        Me.GroupID.TabIndex = 2
        '
        'GroupNameLabel
        '
        GroupNameLabel.AutoSize = True
        GroupNameLabel.Location = New System.Drawing.Point(65, 160)
        GroupNameLabel.Name = "GroupNameLabel"
        GroupNameLabel.Size = New System.Drawing.Size(70, 13)
        GroupNameLabel.TabIndex = 3
        GroupNameLabel.Text = "Group Name:"
        '
        'GroupName
        '
        Me.GroupName.Location = New System.Drawing.Point(141, 157)
        Me.GroupName.Name = "GroupName"
        Me.GroupName.Size = New System.Drawing.Size(152, 20)
        Me.GroupName.TabIndex = 4
        '
        'GroupDateLabel
        '
        GroupDateLabel.AutoSize = True
        GroupDateLabel.Location = New System.Drawing.Point(69, 202)
        GroupDateLabel.Name = "GroupDateLabel"
        GroupDateLabel.Size = New System.Drawing.Size(66, 13)
        GroupDateLabel.TabIndex = 5
        GroupDateLabel.Text = "Group Date:"
        '
        'GroupDate
        '
        Me.GroupDate.Location = New System.Drawing.Point(141, 198)
        Me.GroupDate.Name = "GroupDate"
        Me.GroupDate.Size = New System.Drawing.Size(152, 20)
        Me.GroupDate.TabIndex = 6
        '
        'GroupTimeLabel
        '
        GroupTimeLabel.AutoSize = True
        GroupTimeLabel.Location = New System.Drawing.Point(70, 250)
        GroupTimeLabel.Name = "GroupTimeLabel"
        GroupTimeLabel.Size = New System.Drawing.Size(65, 13)
        GroupTimeLabel.TabIndex = 7
        GroupTimeLabel.Text = "Group Time:"
        '
        'GroupTime
        '
        Me.GroupTime.Location = New System.Drawing.Point(141, 246)
        Me.GroupTime.Name = "GroupTime"
        Me.GroupTime.Size = New System.Drawing.Size(152, 20)
        Me.GroupTime.TabIndex = 8
        '
        'GroupUserLabel
        '
        GroupUserLabel.AutoSize = True
        GroupUserLabel.Location = New System.Drawing.Point(70, 291)
        GroupUserLabel.Name = "GroupUserLabel"
        GroupUserLabel.Size = New System.Drawing.Size(65, 13)
        GroupUserLabel.TabIndex = 9
        GroupUserLabel.Text = "Group User:"
        '
        'GroupUser
        '
        Me.GroupUser.Location = New System.Drawing.Point(141, 288)
        Me.GroupUser.Name = "GroupUser"
        Me.GroupUser.Size = New System.Drawing.Size(152, 20)
        Me.GroupUser.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(379, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(538, 285)
        Me.DataGridView1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(637, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "حفظ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(477, 390)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "الغاء"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ItemGroups
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 440)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(GroupUserLabel)
        Me.Controls.Add(Me.GroupUser)
        Me.Controls.Add(GroupTimeLabel)
        Me.Controls.Add(Me.GroupTime)
        Me.Controls.Add(GroupDateLabel)
        Me.Controls.Add(Me.GroupDate)
        Me.Controls.Add(GroupNameLabel)
        Me.Controls.Add(Me.GroupName)
        Me.Controls.Add(GroupIDLabel)
        Me.Controls.Add(Me.GroupID)
        Me.Name = "ItemGroups"
        Me.Text = "ItemGroups"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupID As System.Windows.Forms.TextBox
    Friend WithEvents GroupName As System.Windows.Forms.TextBox
    Friend WithEvents GroupDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupUser As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
