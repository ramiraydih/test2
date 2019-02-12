<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim CustomerNameLabel As System.Windows.Forms.Label
        Dim CustomerGenderLabel As System.Windows.Forms.Label
        Dim CustomerPhoneLabel As System.Windows.Forms.Label
        Dim CustomerAddressLabel As System.Windows.Forms.Label
        Dim CustomerBalanceLabel As System.Windows.Forms.Label
        Dim CustomerDateLabel As System.Windows.Forms.Label
        Dim CustomerTimeLabel As System.Windows.Forms.Label
        Dim CustomerUserLabel As System.Windows.Forms.Label
        Dim CustomerTypeLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CustomerType = New System.Windows.Forms.ComboBox()
        Me.CustomerUser = New System.Windows.Forms.TextBox()
        Me.CustomerTime = New System.Windows.Forms.DateTimePicker()
        Me.CustomerDate = New System.Windows.Forms.DateTimePicker()
        Me.CustomerBalance = New System.Windows.Forms.TextBox()
        Me.CustomerAddress = New System.Windows.Forms.TextBox()
        Me.CustomerPhone = New System.Windows.Forms.TextBox()
        Me.CustomerGender = New System.Windows.Forms.ComboBox()
        Me.CustomerName = New System.Windows.Forms.TextBox()
        Me.CustomerID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        CustomerIDLabel = New System.Windows.Forms.Label()
        CustomerNameLabel = New System.Windows.Forms.Label()
        CustomerGenderLabel = New System.Windows.Forms.Label()
        CustomerPhoneLabel = New System.Windows.Forms.Label()
        CustomerAddressLabel = New System.Windows.Forms.Label()
        CustomerBalanceLabel = New System.Windows.Forms.Label()
        CustomerDateLabel = New System.Windows.Forms.Label()
        CustomerTimeLabel = New System.Windows.Forms.Label()
        CustomerUserLabel = New System.Windows.Forms.Label()
        CustomerTypeLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(117, 38)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(71, 13)
        CustomerIDLabel.TabIndex = 0
        CustomerIDLabel.Text = "Customer ID:"
        '
        'CustomerNameLabel
        '
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Location = New System.Drawing.Point(101, 64)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New System.Drawing.Size(87, 13)
        CustomerNameLabel.TabIndex = 2
        CustomerNameLabel.Text = "Customer Name:"
        '
        'CustomerGenderLabel
        '
        CustomerGenderLabel.AutoSize = True
        CustomerGenderLabel.Location = New System.Drawing.Point(101, 96)
        CustomerGenderLabel.Name = "CustomerGenderLabel"
        CustomerGenderLabel.Size = New System.Drawing.Size(95, 13)
        CustomerGenderLabel.TabIndex = 4
        CustomerGenderLabel.Text = "Customer Gender:"
        '
        'CustomerPhoneLabel
        '
        CustomerPhoneLabel.AutoSize = True
        CustomerPhoneLabel.Location = New System.Drawing.Point(98, 123)
        CustomerPhoneLabel.Name = "CustomerPhoneLabel"
        CustomerPhoneLabel.Size = New System.Drawing.Size(90, 13)
        CustomerPhoneLabel.TabIndex = 6
        CustomerPhoneLabel.Text = "Customer Phone:"
        '
        'CustomerAddressLabel
        '
        CustomerAddressLabel.AutoSize = True
        CustomerAddressLabel.Location = New System.Drawing.Point(538, 35)
        CustomerAddressLabel.Name = "CustomerAddressLabel"
        CustomerAddressLabel.Size = New System.Drawing.Size(99, 13)
        CustomerAddressLabel.TabIndex = 10
        CustomerAddressLabel.Text = "Customer Address:"
        '
        'CustomerBalanceLabel
        '
        CustomerBalanceLabel.AutoSize = True
        CustomerBalanceLabel.Location = New System.Drawing.Point(540, 72)
        CustomerBalanceLabel.Name = "CustomerBalanceLabel"
        CustomerBalanceLabel.Size = New System.Drawing.Size(97, 13)
        CustomerBalanceLabel.TabIndex = 12
        CustomerBalanceLabel.Text = "Customer Balance:"
        '
        'CustomerDateLabel
        '
        CustomerDateLabel.AutoSize = True
        CustomerDateLabel.Location = New System.Drawing.Point(540, 101)
        CustomerDateLabel.Name = "CustomerDateLabel"
        CustomerDateLabel.Size = New System.Drawing.Size(83, 13)
        CustomerDateLabel.TabIndex = 14
        CustomerDateLabel.Text = "Customer Date:"
        '
        'CustomerTimeLabel
        '
        CustomerTimeLabel.AutoSize = True
        CustomerTimeLabel.Location = New System.Drawing.Point(541, 140)
        CustomerTimeLabel.Name = "CustomerTimeLabel"
        CustomerTimeLabel.Size = New System.Drawing.Size(82, 13)
        CustomerTimeLabel.TabIndex = 16
        CustomerTimeLabel.Text = "Customer Time:"
        '
        'CustomerUserLabel
        '
        CustomerUserLabel.AutoSize = True
        CustomerUserLabel.Location = New System.Drawing.Point(541, 179)
        CustomerUserLabel.Name = "CustomerUserLabel"
        CustomerUserLabel.Size = New System.Drawing.Size(82, 13)
        CustomerUserLabel.TabIndex = 18
        CustomerUserLabel.Text = "Customer User:"
        '
        'CustomerTypeLabel
        '
        CustomerTypeLabel.AutoSize = True
        CustomerTypeLabel.Location = New System.Drawing.Point(104, 155)
        CustomerTypeLabel.Name = "CustomerTypeLabel"
        CustomerTypeLabel.Size = New System.Drawing.Size(84, 13)
        CustomerTypeLabel.TabIndex = 19
        CustomerTypeLabel.Text = "Customer Type:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(CustomerTypeLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerType)
        Me.GroupBox1.Controls.Add(CustomerUserLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerUser)
        Me.GroupBox1.Controls.Add(CustomerTimeLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerTime)
        Me.GroupBox1.Controls.Add(CustomerDateLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerDate)
        Me.GroupBox1.Controls.Add(CustomerBalanceLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerBalance)
        Me.GroupBox1.Controls.Add(CustomerAddressLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerAddress)
        Me.GroupBox1.Controls.Add(CustomerPhoneLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerPhone)
        Me.GroupBox1.Controls.Add(CustomerGenderLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerGender)
        Me.GroupBox1.Controls.Add(CustomerNameLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerName)
        Me.GroupBox1.Controls.Add(CustomerIDLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerID)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(889, 236)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البيانات الاسايه "
        '
        'CustomerType
        '
        Me.CustomerType.FormattingEnabled = True
        Me.CustomerType.Items.AddRange(New Object() {"نقدي", "دين "})
        Me.CustomerType.Location = New System.Drawing.Point(194, 152)
        Me.CustomerType.Name = "CustomerType"
        Me.CustomerType.Size = New System.Drawing.Size(148, 21)
        Me.CustomerType.TabIndex = 20
        '
        'CustomerUser
        '
        Me.CustomerUser.Location = New System.Drawing.Point(643, 176)
        Me.CustomerUser.Name = "CustomerUser"
        Me.CustomerUser.Size = New System.Drawing.Size(151, 20)
        Me.CustomerUser.TabIndex = 19
        '
        'CustomerTime
        '
        Me.CustomerTime.Location = New System.Drawing.Point(643, 136)
        Me.CustomerTime.Name = "CustomerTime"
        Me.CustomerTime.Size = New System.Drawing.Size(160, 20)
        Me.CustomerTime.TabIndex = 17
        '
        'CustomerDate
        '
        Me.CustomerDate.Location = New System.Drawing.Point(643, 97)
        Me.CustomerDate.Name = "CustomerDate"
        Me.CustomerDate.Size = New System.Drawing.Size(151, 20)
        Me.CustomerDate.TabIndex = 15
        '
        'CustomerBalance
        '
        Me.CustomerBalance.Location = New System.Drawing.Point(643, 69)
        Me.CustomerBalance.Name = "CustomerBalance"
        Me.CustomerBalance.Size = New System.Drawing.Size(151, 20)
        Me.CustomerBalance.TabIndex = 13
        '
        'CustomerAddress
        '
        Me.CustomerAddress.Location = New System.Drawing.Point(643, 35)
        Me.CustomerAddress.Name = "CustomerAddress"
        Me.CustomerAddress.Size = New System.Drawing.Size(151, 20)
        Me.CustomerAddress.TabIndex = 11
        '
        'CustomerPhone
        '
        Me.CustomerPhone.Location = New System.Drawing.Point(194, 120)
        Me.CustomerPhone.Name = "CustomerPhone"
        Me.CustomerPhone.Size = New System.Drawing.Size(148, 20)
        Me.CustomerPhone.TabIndex = 7
        '
        'CustomerGender
        '
        Me.CustomerGender.FormattingEnabled = True
        Me.CustomerGender.Items.AddRange(New Object() {"ذكر", "أنثى"})
        Me.CustomerGender.Location = New System.Drawing.Point(194, 93)
        Me.CustomerGender.Name = "CustomerGender"
        Me.CustomerGender.Size = New System.Drawing.Size(148, 21)
        Me.CustomerGender.TabIndex = 5
        '
        'CustomerName
        '
        Me.CustomerName.Location = New System.Drawing.Point(194, 61)
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(148, 20)
        Me.CustomerName.TabIndex = 3
        '
        'CustomerID
        '
        Me.CustomerID.Location = New System.Drawing.Point(194, 35)
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.Size = New System.Drawing.Size(148, 20)
        Me.CustomerID.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(928, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(103, 246)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "الازرار الاساسيه "
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(15, 189)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 37)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "حذف"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 37)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "حفظ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(15, 136)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(69, 37)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "تعديل"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "اضافة "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(26, 297)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1034, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(730, 261)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(188, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(655, 252)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(69, 37)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "بحث"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1087, 459)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Customer"
        Me.Text = "Customer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CustomerUser As System.Windows.Forms.TextBox
    Friend WithEvents CustomerTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents CustomerDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CustomerBalance As System.Windows.Forms.TextBox
    Friend WithEvents CustomerAddress As System.Windows.Forms.TextBox
    Friend WithEvents CustomerPhone As System.Windows.Forms.TextBox
    Friend WithEvents CustomerGender As System.Windows.Forms.ComboBox
    Friend WithEvents CustomerName As System.Windows.Forms.TextBox
    Friend WithEvents CustomerID As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CustomerType As System.Windows.Forms.ComboBox
End Class
