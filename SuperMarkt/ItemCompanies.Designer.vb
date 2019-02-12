<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemCompanies
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
        Dim CompanyIDLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim CompanyDateLabel As System.Windows.Forms.Label
        Dim CompanyTimeLabel As System.Windows.Forms.Label
        Dim CompanyUserLabel As System.Windows.Forms.Label
        Me.CompanyID = New System.Windows.Forms.TextBox()
        Me.CompanyName = New System.Windows.Forms.TextBox()
        Me.CompanyDate = New System.Windows.Forms.DateTimePicker()
        Me.CompanyTime = New System.Windows.Forms.DateTimePicker()
        Me.CompanyUser = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CompanyIDLabel = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        CompanyDateLabel = New System.Windows.Forms.Label()
        CompanyTimeLabel = New System.Windows.Forms.Label()
        CompanyUserLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CompanyIDLabel
        '
        CompanyIDLabel.AutoSize = True
        CompanyIDLabel.Location = New System.Drawing.Point(41, 84)
        CompanyIDLabel.Name = "CompanyIDLabel"
        CompanyIDLabel.Size = New System.Drawing.Size(70, 13)
        CompanyIDLabel.TabIndex = 1
        CompanyIDLabel.Text = "Company ID:"
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Location = New System.Drawing.Point(25, 119)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(86, 13)
        CompanyNameLabel.TabIndex = 3
        CompanyNameLabel.Text = "Company Name:"
        '
        'CompanyDateLabel
        '
        CompanyDateLabel.AutoSize = True
        CompanyDateLabel.Location = New System.Drawing.Point(29, 155)
        CompanyDateLabel.Name = "CompanyDateLabel"
        CompanyDateLabel.Size = New System.Drawing.Size(82, 13)
        CompanyDateLabel.TabIndex = 5
        CompanyDateLabel.Text = "Company Date:"
        '
        'CompanyTimeLabel
        '
        CompanyTimeLabel.AutoSize = True
        CompanyTimeLabel.Location = New System.Drawing.Point(30, 191)
        CompanyTimeLabel.Name = "CompanyTimeLabel"
        CompanyTimeLabel.Size = New System.Drawing.Size(81, 13)
        CompanyTimeLabel.TabIndex = 7
        CompanyTimeLabel.Text = "Company Time:"
        '
        'CompanyUserLabel
        '
        CompanyUserLabel.AutoSize = True
        CompanyUserLabel.Location = New System.Drawing.Point(30, 216)
        CompanyUserLabel.Name = "CompanyUserLabel"
        CompanyUserLabel.Size = New System.Drawing.Size(81, 13)
        CompanyUserLabel.TabIndex = 9
        CompanyUserLabel.Text = "Company User:"
        '
        'CompanyID
        '
        Me.CompanyID.Location = New System.Drawing.Point(117, 81)
        Me.CompanyID.Name = "CompanyID"
        Me.CompanyID.Size = New System.Drawing.Size(141, 20)
        Me.CompanyID.TabIndex = 2
        '
        'CompanyName
        '
        Me.CompanyName.Location = New System.Drawing.Point(117, 116)
        Me.CompanyName.Name = "CompanyName"
        Me.CompanyName.Size = New System.Drawing.Size(141, 20)
        Me.CompanyName.TabIndex = 4
        '
        'CompanyDate
        '
        Me.CompanyDate.Location = New System.Drawing.Point(118, 151)
        Me.CompanyDate.Name = "CompanyDate"
        Me.CompanyDate.Size = New System.Drawing.Size(141, 20)
        Me.CompanyDate.TabIndex = 6
        '
        'CompanyTime
        '
        Me.CompanyTime.Location = New System.Drawing.Point(122, 187)
        Me.CompanyTime.Name = "CompanyTime"
        Me.CompanyTime.Size = New System.Drawing.Size(141, 20)
        Me.CompanyTime.TabIndex = 8
        '
        'CompanyUser
        '
        Me.CompanyUser.Location = New System.Drawing.Point(117, 213)
        Me.CompanyUser.Name = "CompanyUser"
        Me.CompanyUser.Size = New System.Drawing.Size(146, 20)
        Me.CompanyUser.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(335, 79)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(410, 182)
        Me.DataGridView1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(499, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "حفظ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(321, 308)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 33)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "الغاء"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ItemCompanies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 394)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(CompanyUserLabel)
        Me.Controls.Add(Me.CompanyUser)
        Me.Controls.Add(CompanyTimeLabel)
        Me.Controls.Add(Me.CompanyTime)
        Me.Controls.Add(CompanyDateLabel)
        Me.Controls.Add(Me.CompanyDate)
        Me.Controls.Add(CompanyNameLabel)
        Me.Controls.Add(Me.CompanyName)
        Me.Controls.Add(CompanyIDLabel)
        Me.Controls.Add(Me.CompanyID)
        Me.Name = "ItemCompanies"
        Me.Text = "ItemCompanies"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CompanyID As System.Windows.Forms.TextBox
    Friend WithEvents CompanyName As System.Windows.Forms.TextBox
    Friend WithEvents CompanyDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CompanyTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents CompanyUser As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
