<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsesCome
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
        Dim HEIDLabel As System.Windows.Forms.Label
        Dim HEDateLabel As System.Windows.Forms.Label
        Dim HETimeLabel As System.Windows.Forms.Label
        Dim HENoteLabel As System.Windows.Forms.Label
        Dim HEUserLabel As System.Windows.Forms.Label
        Dim HEComeLabel1 As System.Windows.Forms.Label
        Dim HEUsersLabel1 As System.Windows.Forms.Label
        Me.HEID = New System.Windows.Forms.TextBox()
        Me.HEDate = New System.Windows.Forms.DateTimePicker()
        Me.HETime = New System.Windows.Forms.DateTimePicker()
        Me.HENote = New System.Windows.Forms.TextBox()
        Me.HEUser = New System.Windows.Forms.TextBox()
        Me.HECome = New System.Windows.Forms.TextBox()
        Me.HEUsers = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        HEIDLabel = New System.Windows.Forms.Label()
        HEDateLabel = New System.Windows.Forms.Label()
        HETimeLabel = New System.Windows.Forms.Label()
        HENoteLabel = New System.Windows.Forms.Label()
        HEUserLabel = New System.Windows.Forms.Label()
        HEComeLabel1 = New System.Windows.Forms.Label()
        HEUsersLabel1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HEIDLabel
        '
        HEIDLabel.AutoSize = True
        HEIDLabel.Location = New System.Drawing.Point(55, 62)
        HEIDLabel.Name = "HEIDLabel"
        HEIDLabel.Size = New System.Drawing.Size(35, 13)
        HEIDLabel.TabIndex = 1
        HEIDLabel.Text = "HEID:"
        '
        'HEDateLabel
        '
        HEDateLabel.AutoSize = True
        HEDateLabel.Location = New System.Drawing.Point(39, 97)
        HEDateLabel.Name = "HEDateLabel"
        HEDateLabel.Size = New System.Drawing.Size(47, 13)
        HEDateLabel.TabIndex = 3
        HEDateLabel.Text = "HEDate:"
        '
        'HETimeLabel
        '
        HETimeLabel.AutoSize = True
        HETimeLabel.Location = New System.Drawing.Point(41, 138)
        HETimeLabel.Name = "HETimeLabel"
        HETimeLabel.Size = New System.Drawing.Size(46, 13)
        HETimeLabel.TabIndex = 5
        HETimeLabel.Text = "HETime:"
        '
        'HENoteLabel
        '
        HENoteLabel.AutoSize = True
        HENoteLabel.Location = New System.Drawing.Point(38, 249)
        HENoteLabel.Name = "HENoteLabel"
        HENoteLabel.Size = New System.Drawing.Size(47, 13)
        HENoteLabel.TabIndex = 15
        HENoteLabel.Text = "HENote:"
        '
        'HEUserLabel
        '
        HEUserLabel.AutoSize = True
        HEUserLabel.Location = New System.Drawing.Point(43, 282)
        HEUserLabel.Name = "HEUserLabel"
        HEUserLabel.Size = New System.Drawing.Size(46, 13)
        HEUserLabel.TabIndex = 17
        HEUserLabel.Text = "HEUser:"
        '
        'HEComeLabel1
        '
        HEComeLabel1.AutoSize = True
        HEComeLabel1.Location = New System.Drawing.Point(36, 209)
        HEComeLabel1.Name = "HEComeLabel1"
        HEComeLabel1.Size = New System.Drawing.Size(51, 13)
        HEComeLabel1.TabIndex = 19
        HEComeLabel1.Text = "HECome:"
        '
        'HEUsersLabel1
        '
        HEUsersLabel1.AutoSize = True
        HEUsersLabel1.Location = New System.Drawing.Point(35, 173)
        HEUsersLabel1.Name = "HEUsersLabel1"
        HEUsersLabel1.Size = New System.Drawing.Size(51, 13)
        HEUsersLabel1.TabIndex = 21
        HEUsersLabel1.Text = "HEUsers:"
        '
        'HEID
        '
        Me.HEID.Location = New System.Drawing.Point(93, 59)
        Me.HEID.Name = "HEID"
        Me.HEID.Size = New System.Drawing.Size(199, 20)
        Me.HEID.TabIndex = 2
        '
        'HEDate
        '
        Me.HEDate.Location = New System.Drawing.Point(93, 95)
        Me.HEDate.Name = "HEDate"
        Me.HEDate.Size = New System.Drawing.Size(200, 20)
        Me.HEDate.TabIndex = 4
        Me.HEDate.Value = New Date(2019, 1, 31, 0, 0, 0, 0)
        '
        'HETime
        '
        Me.HETime.Location = New System.Drawing.Point(93, 134)
        Me.HETime.Name = "HETime"
        Me.HETime.Size = New System.Drawing.Size(200, 20)
        Me.HETime.TabIndex = 6
        '
        'HENote
        '
        Me.HENote.Location = New System.Drawing.Point(91, 246)
        Me.HENote.Name = "HENote"
        Me.HENote.Size = New System.Drawing.Size(201, 20)
        Me.HENote.TabIndex = 16
        '
        'HEUser
        '
        Me.HEUser.Location = New System.Drawing.Point(89, 279)
        Me.HEUser.Name = "HEUser"
        Me.HEUser.Size = New System.Drawing.Size(202, 20)
        Me.HEUser.TabIndex = 18
        '
        'HECome
        '
        Me.HECome.Location = New System.Drawing.Point(93, 206)
        Me.HECome.Name = "HECome"
        Me.HECome.Size = New System.Drawing.Size(199, 20)
        Me.HECome.TabIndex = 20
        '
        'HEUsers
        '
        Me.HEUsers.FormattingEnabled = True
        Me.HEUsers.Location = New System.Drawing.Point(92, 170)
        Me.HEUsers.Name = "HEUsers"
        Me.HEUsers.Size = New System.Drawing.Size(201, 21)
        Me.HEUsers.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(391, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(534, 240)
        Me.DataGridView1.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(691, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 30)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "حضور "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(553, 343)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 30)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "الغاء"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(518, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 23)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "شاشة الحضور"
        '
        'UsesCome
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 397)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(HEUsersLabel1)
        Me.Controls.Add(Me.HEUsers)
        Me.Controls.Add(HEComeLabel1)
        Me.Controls.Add(Me.HECome)
        Me.Controls.Add(HEUserLabel)
        Me.Controls.Add(Me.HEUser)
        Me.Controls.Add(HENoteLabel)
        Me.Controls.Add(Me.HENote)
        Me.Controls.Add(HETimeLabel)
        Me.Controls.Add(Me.HETime)
        Me.Controls.Add(HEDateLabel)
        Me.Controls.Add(Me.HEDate)
        Me.Controls.Add(HEIDLabel)
        Me.Controls.Add(Me.HEID)
        Me.Name = "UsesCome"
        Me.Text = "UsesCome"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HEID As System.Windows.Forms.TextBox
    Friend WithEvents HEDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents HETime As System.Windows.Forms.DateTimePicker
    Friend WithEvents HENote As System.Windows.Forms.TextBox
    Friend WithEvents HEUser As System.Windows.Forms.TextBox
    Friend WithEvents HECome As System.Windows.Forms.TextBox
    Friend WithEvents HEUsers As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
