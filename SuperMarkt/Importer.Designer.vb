<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Importer
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
        Dim ImporterIDLabel As System.Windows.Forms.Label
        Dim ImporterNameLabel As System.Windows.Forms.Label
        Dim ImporterPhoneLabel As System.Windows.Forms.Label
        Dim ImporterAddressLabel As System.Windows.Forms.Label
        Dim ImporterBalanceLabel As System.Windows.Forms.Label
        Dim ImporterDateLabel As System.Windows.Forms.Label
        Dim ImporterTimeLabel As System.Windows.Forms.Label
        Dim ImporterUserLabel As System.Windows.Forms.Label
        Dim ImporterTypeLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ImporterUser = New System.Windows.Forms.TextBox()
        Me.ImporterTime = New System.Windows.Forms.DateTimePicker()
        Me.ImporterDate = New System.Windows.Forms.DateTimePicker()
        Me.ImporterBalance = New System.Windows.Forms.TextBox()
        Me.ImporterAddress = New System.Windows.Forms.TextBox()
        Me.ImporterPhone = New System.Windows.Forms.TextBox()
        Me.ImporterName = New System.Windows.Forms.TextBox()
        Me.ImporterID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ImporterType = New System.Windows.Forms.TextBox()
        ImporterIDLabel = New System.Windows.Forms.Label()
        ImporterNameLabel = New System.Windows.Forms.Label()
        ImporterPhoneLabel = New System.Windows.Forms.Label()
        ImporterAddressLabel = New System.Windows.Forms.Label()
        ImporterBalanceLabel = New System.Windows.Forms.Label()
        ImporterDateLabel = New System.Windows.Forms.Label()
        ImporterTimeLabel = New System.Windows.Forms.Label()
        ImporterUserLabel = New System.Windows.Forms.Label()
        ImporterTypeLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImporterIDLabel
        '
        ImporterIDLabel.AutoSize = True
        ImporterIDLabel.Location = New System.Drawing.Point(78, 36)
        ImporterIDLabel.Name = "ImporterIDLabel"
        ImporterIDLabel.Size = New System.Drawing.Size(67, 13)
        ImporterIDLabel.TabIndex = 0
        ImporterIDLabel.Text = "Importer ID:"
        '
        'ImporterNameLabel
        '
        ImporterNameLabel.AutoSize = True
        ImporterNameLabel.Location = New System.Drawing.Point(62, 62)
        ImporterNameLabel.Name = "ImporterNameLabel"
        ImporterNameLabel.Size = New System.Drawing.Size(83, 13)
        ImporterNameLabel.TabIndex = 2
        ImporterNameLabel.Text = "Importer Name:"
        '
        'ImporterPhoneLabel
        '
        ImporterPhoneLabel.AutoSize = True
        ImporterPhoneLabel.Location = New System.Drawing.Point(59, 88)
        ImporterPhoneLabel.Name = "ImporterPhoneLabel"
        ImporterPhoneLabel.Size = New System.Drawing.Size(86, 13)
        ImporterPhoneLabel.TabIndex = 4
        ImporterPhoneLabel.Text = "Importer Phone:"
        '
        'ImporterAddressLabel
        '
        ImporterAddressLabel.AutoSize = True
        ImporterAddressLabel.Location = New System.Drawing.Point(532, 32)
        ImporterAddressLabel.Name = "ImporterAddressLabel"
        ImporterAddressLabel.Size = New System.Drawing.Size(95, 13)
        ImporterAddressLabel.TabIndex = 8
        ImporterAddressLabel.Text = "Importer Address:"
        '
        'ImporterBalanceLabel
        '
        ImporterBalanceLabel.AutoSize = True
        ImporterBalanceLabel.Location = New System.Drawing.Point(540, 62)
        ImporterBalanceLabel.Name = "ImporterBalanceLabel"
        ImporterBalanceLabel.Size = New System.Drawing.Size(93, 13)
        ImporterBalanceLabel.TabIndex = 10
        ImporterBalanceLabel.Text = "Importer Balance:"
        '
        'ImporterDateLabel
        '
        ImporterDateLabel.AutoSize = True
        ImporterDateLabel.Location = New System.Drawing.Point(539, 89)
        ImporterDateLabel.Name = "ImporterDateLabel"
        ImporterDateLabel.Size = New System.Drawing.Size(79, 13)
        ImporterDateLabel.TabIndex = 12
        ImporterDateLabel.Text = "Importer Date:"
        '
        'ImporterTimeLabel
        '
        ImporterTimeLabel.AutoSize = True
        ImporterTimeLabel.Location = New System.Drawing.Point(538, 122)
        ImporterTimeLabel.Name = "ImporterTimeLabel"
        ImporterTimeLabel.Size = New System.Drawing.Size(78, 13)
        ImporterTimeLabel.TabIndex = 14
        ImporterTimeLabel.Text = "Importer Time:"
        '
        'ImporterUserLabel
        '
        ImporterUserLabel.AutoSize = True
        ImporterUserLabel.Location = New System.Drawing.Point(538, 156)
        ImporterUserLabel.Name = "ImporterUserLabel"
        ImporterUserLabel.Size = New System.Drawing.Size(78, 13)
        ImporterUserLabel.TabIndex = 16
        ImporterUserLabel.Text = "Importer User:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(ImporterTypeLabel)
        Me.GroupBox1.Controls.Add(Me.ImporterType)
        Me.GroupBox1.Controls.Add(ImporterUserLabel)
        Me.GroupBox1.Controls.Add(Me.ImporterUser)
        Me.GroupBox1.Controls.Add(ImporterTimeLabel)
        Me.GroupBox1.Controls.Add(Me.ImporterTime)
        Me.GroupBox1.Controls.Add(ImporterDateLabel)
        Me.GroupBox1.Controls.Add(Me.ImporterDate)
        Me.GroupBox1.Controls.Add(ImporterBalanceLabel)
        Me.GroupBox1.Controls.Add(Me.ImporterBalance)
        Me.GroupBox1.Controls.Add(ImporterAddressLabel)
        Me.GroupBox1.Controls.Add(Me.ImporterAddress)
        Me.GroupBox1.Controls.Add(ImporterPhoneLabel)
        Me.GroupBox1.Controls.Add(Me.ImporterPhone)
        Me.GroupBox1.Controls.Add(ImporterNameLabel)
        Me.GroupBox1.Controls.Add(Me.ImporterName)
        Me.GroupBox1.Controls.Add(ImporterIDLabel)
        Me.GroupBox1.Controls.Add(Me.ImporterID)
        Me.GroupBox1.Location = New System.Drawing.Point(82, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1019, 198)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البيانات الاساسيه "
        '
        'ImporterUser
        '
        Me.ImporterUser.Location = New System.Drawing.Point(639, 156)
        Me.ImporterUser.Name = "ImporterUser"
        Me.ImporterUser.Size = New System.Drawing.Size(150, 20)
        Me.ImporterUser.TabIndex = 17
        '
        'ImporterTime
        '
        Me.ImporterTime.Location = New System.Drawing.Point(639, 118)
        Me.ImporterTime.Name = "ImporterTime"
        Me.ImporterTime.Size = New System.Drawing.Size(150, 20)
        Me.ImporterTime.TabIndex = 15
        '
        'ImporterDate
        '
        Me.ImporterDate.Location = New System.Drawing.Point(639, 85)
        Me.ImporterDate.Name = "ImporterDate"
        Me.ImporterDate.Size = New System.Drawing.Size(150, 20)
        Me.ImporterDate.TabIndex = 13
        '
        'ImporterBalance
        '
        Me.ImporterBalance.Location = New System.Drawing.Point(639, 59)
        Me.ImporterBalance.Name = "ImporterBalance"
        Me.ImporterBalance.Size = New System.Drawing.Size(150, 20)
        Me.ImporterBalance.TabIndex = 11
        '
        'ImporterAddress
        '
        Me.ImporterAddress.Location = New System.Drawing.Point(639, 29)
        Me.ImporterAddress.Name = "ImporterAddress"
        Me.ImporterAddress.Size = New System.Drawing.Size(150, 20)
        Me.ImporterAddress.TabIndex = 9
        '
        'ImporterPhone
        '
        Me.ImporterPhone.Location = New System.Drawing.Point(151, 85)
        Me.ImporterPhone.Name = "ImporterPhone"
        Me.ImporterPhone.Size = New System.Drawing.Size(153, 20)
        Me.ImporterPhone.TabIndex = 5
        '
        'ImporterName
        '
        Me.ImporterName.Location = New System.Drawing.Point(151, 59)
        Me.ImporterName.Name = "ImporterName"
        Me.ImporterName.Size = New System.Drawing.Size(153, 20)
        Me.ImporterName.TabIndex = 3
        '
        'ImporterID
        '
        Me.ImporterID.Location = New System.Drawing.Point(151, 33)
        Me.ImporterID.Name = "ImporterID"
        Me.ImporterID.Size = New System.Drawing.Size(153, 20)
        Me.ImporterID.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(977, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(93, 204)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "الازرار"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 146)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "حذف"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 104)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "تعديل"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "حفظ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "اضافة"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(446, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "مورد جديد"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(64, 309)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1006, 179)
        Me.DataGridView1.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(738, 263)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(203, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(640, 260)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "بحث"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ImporterTypeLabel
        '
        ImporterTypeLabel.AutoSize = True
        ImporterTypeLabel.Location = New System.Drawing.Point(65, 125)
        ImporterTypeLabel.Name = "ImporterTypeLabel"
        ImporterTypeLabel.Size = New System.Drawing.Size(80, 13)
        ImporterTypeLabel.TabIndex = 17
        ImporterTypeLabel.Text = "Importer Type:"
        '
        'ImporterType
        '
        Me.ImporterType.Location = New System.Drawing.Point(151, 122)
        Me.ImporterType.Name = "ImporterType"
        Me.ImporterType.Size = New System.Drawing.Size(153, 20)
        Me.ImporterType.TabIndex = 18
        '
        'Importer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 500)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Importer"
        Me.Text = "Importer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ImporterID As System.Windows.Forms.TextBox
    Friend WithEvents ImporterTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImporterDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ImporterBalance As System.Windows.Forms.TextBox
    Friend WithEvents ImporterAddress As System.Windows.Forms.TextBox
    Friend WithEvents ImporterPhone As System.Windows.Forms.TextBox
    Friend WithEvents ImporterName As System.Windows.Forms.TextBox
    Friend WithEvents ImporterUser As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ImporterType As System.Windows.Forms.TextBox
End Class
