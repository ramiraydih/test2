<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items
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
        Dim ItemIDLabel As System.Windows.Forms.Label
        Dim ItemBarcodeLabel As System.Windows.Forms.Label
        Dim ItemNameLabel As System.Windows.Forms.Label
        Dim ItemGropLabel As System.Windows.Forms.Label
        Dim ItemCompanyLabel As System.Windows.Forms.Label
        Dim ItemplaceLabel As System.Windows.Forms.Label
        Dim ItemPriceLabel As System.Windows.Forms.Label
        Dim ItemQytLabel As System.Windows.Forms.Label
        Dim ItemLimitLabel As System.Windows.Forms.Label
        Dim ItemMaxDiscaoundLabel As System.Windows.Forms.Label
        Dim ItemEranLabel As System.Windows.Forms.Label
        Dim ItemDateLabel As System.Windows.Forms.Label
        Dim ItemTimeLabel As System.Windows.Forms.Label
        Dim ItemUserLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ItemUser = New System.Windows.Forms.TextBox()
        Me.ItemTime = New System.Windows.Forms.DateTimePicker()
        Me.ItemDate = New System.Windows.Forms.DateTimePicker()
        Me.ItemEran = New System.Windows.Forms.TextBox()
        Me.ItemMaxDiscaound = New System.Windows.Forms.TextBox()
        Me.ItemLimit = New System.Windows.Forms.TextBox()
        Me.ItemQyt = New System.Windows.Forms.TextBox()
        Me.ItemPrice = New System.Windows.Forms.TextBox()
        Me.Itemplace = New System.Windows.Forms.ComboBox()
        Me.ItemCompany = New System.Windows.Forms.ComboBox()
        Me.ItemGrop = New System.Windows.Forms.ComboBox()
        Me.ItemName = New System.Windows.Forms.TextBox()
        Me.ItemBarcode = New System.Windows.Forms.TextBox()
        Me.ItemID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        ItemIDLabel = New System.Windows.Forms.Label()
        ItemBarcodeLabel = New System.Windows.Forms.Label()
        ItemNameLabel = New System.Windows.Forms.Label()
        ItemGropLabel = New System.Windows.Forms.Label()
        ItemCompanyLabel = New System.Windows.Forms.Label()
        ItemplaceLabel = New System.Windows.Forms.Label()
        ItemPriceLabel = New System.Windows.Forms.Label()
        ItemQytLabel = New System.Windows.Forms.Label()
        ItemLimitLabel = New System.Windows.Forms.Label()
        ItemMaxDiscaoundLabel = New System.Windows.Forms.Label()
        ItemEranLabel = New System.Windows.Forms.Label()
        ItemDateLabel = New System.Windows.Forms.Label()
        ItemTimeLabel = New System.Windows.Forms.Label()
        ItemUserLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemIDLabel
        '
        ItemIDLabel.AutoSize = True
        ItemIDLabel.Location = New System.Drawing.Point(66, 23)
        ItemIDLabel.Name = "ItemIDLabel"
        ItemIDLabel.Size = New System.Drawing.Size(47, 13)
        ItemIDLabel.TabIndex = 1
        ItemIDLabel.Text = "Item ID:"
        AddHandler ItemIDLabel.Click, AddressOf Me.ItemIDLabel_Click
        '
        'ItemBarcodeLabel
        '
        ItemBarcodeLabel.AutoSize = True
        ItemBarcodeLabel.Location = New System.Drawing.Point(38, 49)
        ItemBarcodeLabel.Name = "ItemBarcodeLabel"
        ItemBarcodeLabel.Size = New System.Drawing.Size(75, 13)
        ItemBarcodeLabel.TabIndex = 3
        ItemBarcodeLabel.Text = "Item Barcode:"
        '
        'ItemNameLabel
        '
        ItemNameLabel.AutoSize = True
        ItemNameLabel.Location = New System.Drawing.Point(50, 78)
        ItemNameLabel.Name = "ItemNameLabel"
        ItemNameLabel.Size = New System.Drawing.Size(63, 13)
        ItemNameLabel.TabIndex = 5
        ItemNameLabel.Text = "Item Name:"
        '
        'ItemGropLabel
        '
        ItemGropLabel.AutoSize = True
        ItemGropLabel.Location = New System.Drawing.Point(50, 110)
        ItemGropLabel.Name = "ItemGropLabel"
        ItemGropLabel.Size = New System.Drawing.Size(59, 13)
        ItemGropLabel.TabIndex = 7
        ItemGropLabel.Text = "Item Grop:"
        '
        'ItemCompanyLabel
        '
        ItemCompanyLabel.AutoSize = True
        ItemCompanyLabel.Location = New System.Drawing.Point(32, 137)
        ItemCompanyLabel.Name = "ItemCompanyLabel"
        ItemCompanyLabel.Size = New System.Drawing.Size(81, 13)
        ItemCompanyLabel.TabIndex = 9
        ItemCompanyLabel.Text = "Item Company:"
        '
        'ItemplaceLabel
        '
        ItemplaceLabel.AutoSize = True
        ItemplaceLabel.Location = New System.Drawing.Point(51, 166)
        ItemplaceLabel.Name = "ItemplaceLabel"
        ItemplaceLabel.Size = New System.Drawing.Size(58, 13)
        ItemplaceLabel.TabIndex = 11
        ItemplaceLabel.Text = "Itemplace:"
        '
        'ItemPriceLabel
        '
        ItemPriceLabel.AutoSize = True
        ItemPriceLabel.Location = New System.Drawing.Point(54, 193)
        ItemPriceLabel.Name = "ItemPriceLabel"
        ItemPriceLabel.Size = New System.Drawing.Size(59, 13)
        ItemPriceLabel.TabIndex = 13
        ItemPriceLabel.Text = "Item Price:"
        '
        'ItemQytLabel
        '
        ItemQytLabel.AutoSize = True
        ItemQytLabel.Location = New System.Drawing.Point(59, 222)
        ItemQytLabel.Name = "ItemQytLabel"
        ItemQytLabel.Size = New System.Drawing.Size(54, 13)
        ItemQytLabel.TabIndex = 15
        ItemQytLabel.Text = "Item Qyt:"
        '
        'ItemLimitLabel
        '
        ItemLimitLabel.AutoSize = True
        ItemLimitLabel.Location = New System.Drawing.Point(676, 42)
        ItemLimitLabel.Name = "ItemLimitLabel"
        ItemLimitLabel.Size = New System.Drawing.Size(57, 13)
        ItemLimitLabel.TabIndex = 17
        ItemLimitLabel.Text = "Item Limit:"
        '
        'ItemMaxDiscaoundLabel
        '
        ItemMaxDiscaoundLabel.AutoSize = True
        ItemMaxDiscaoundLabel.Location = New System.Drawing.Point(625, 68)
        ItemMaxDiscaoundLabel.Name = "ItemMaxDiscaoundLabel"
        ItemMaxDiscaoundLabel.Size = New System.Drawing.Size(108, 13)
        ItemMaxDiscaoundLabel.TabIndex = 19
        ItemMaxDiscaoundLabel.Text = "Item Max Discaound:"
        '
        'ItemEranLabel
        '
        ItemEranLabel.AutoSize = True
        ItemEranLabel.Location = New System.Drawing.Point(675, 94)
        ItemEranLabel.Name = "ItemEranLabel"
        ItemEranLabel.Size = New System.Drawing.Size(58, 13)
        ItemEranLabel.TabIndex = 21
        ItemEranLabel.Text = "Item Eran:"
        '
        'ItemDateLabel
        '
        ItemDateLabel.AutoSize = True
        ItemDateLabel.Location = New System.Drawing.Point(674, 121)
        ItemDateLabel.Name = "ItemDateLabel"
        ItemDateLabel.Size = New System.Drawing.Size(59, 13)
        ItemDateLabel.TabIndex = 23
        ItemDateLabel.Text = "Item Date:"
        '
        'ItemTimeLabel
        '
        ItemTimeLabel.AutoSize = True
        ItemTimeLabel.Location = New System.Drawing.Point(675, 154)
        ItemTimeLabel.Name = "ItemTimeLabel"
        ItemTimeLabel.Size = New System.Drawing.Size(58, 13)
        ItemTimeLabel.TabIndex = 25
        ItemTimeLabel.Text = "Item Time:"
        '
        'ItemUserLabel
        '
        ItemUserLabel.AutoSize = True
        ItemUserLabel.Location = New System.Drawing.Point(675, 185)
        ItemUserLabel.Name = "ItemUserLabel"
        ItemUserLabel.Size = New System.Drawing.Size(58, 13)
        ItemUserLabel.TabIndex = 27
        ItemUserLabel.Text = "Item User:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(ItemUserLabel)
        Me.GroupBox1.Controls.Add(Me.ItemUser)
        Me.GroupBox1.Controls.Add(ItemTimeLabel)
        Me.GroupBox1.Controls.Add(Me.ItemTime)
        Me.GroupBox1.Controls.Add(ItemDateLabel)
        Me.GroupBox1.Controls.Add(Me.ItemDate)
        Me.GroupBox1.Controls.Add(ItemEranLabel)
        Me.GroupBox1.Controls.Add(Me.ItemEran)
        Me.GroupBox1.Controls.Add(ItemMaxDiscaoundLabel)
        Me.GroupBox1.Controls.Add(Me.ItemMaxDiscaound)
        Me.GroupBox1.Controls.Add(ItemLimitLabel)
        Me.GroupBox1.Controls.Add(Me.ItemLimit)
        Me.GroupBox1.Controls.Add(ItemQytLabel)
        Me.GroupBox1.Controls.Add(Me.ItemQyt)
        Me.GroupBox1.Controls.Add(ItemPriceLabel)
        Me.GroupBox1.Controls.Add(Me.ItemPrice)
        Me.GroupBox1.Controls.Add(ItemplaceLabel)
        Me.GroupBox1.Controls.Add(Me.Itemplace)
        Me.GroupBox1.Controls.Add(ItemCompanyLabel)
        Me.GroupBox1.Controls.Add(Me.ItemCompany)
        Me.GroupBox1.Controls.Add(ItemGropLabel)
        Me.GroupBox1.Controls.Add(Me.ItemGrop)
        Me.GroupBox1.Controls.Add(ItemNameLabel)
        Me.GroupBox1.Controls.Add(Me.ItemName)
        Me.GroupBox1.Controls.Add(ItemBarcodeLabel)
        Me.GroupBox1.Controls.Add(Me.ItemBarcode)
        Me.GroupBox1.Controls.Add(ItemIDLabel)
        Me.GroupBox1.Controls.Add(Me.ItemID)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(924, 252)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ItemUser
        '
        Me.ItemUser.Location = New System.Drawing.Point(739, 182)
        Me.ItemUser.Name = "ItemUser"
        Me.ItemUser.Size = New System.Drawing.Size(149, 20)
        Me.ItemUser.TabIndex = 28
        '
        'ItemTime
        '
        Me.ItemTime.Location = New System.Drawing.Point(739, 150)
        Me.ItemTime.Name = "ItemTime"
        Me.ItemTime.Size = New System.Drawing.Size(149, 20)
        Me.ItemTime.TabIndex = 26
        '
        'ItemDate
        '
        Me.ItemDate.Location = New System.Drawing.Point(739, 117)
        Me.ItemDate.Name = "ItemDate"
        Me.ItemDate.Size = New System.Drawing.Size(149, 20)
        Me.ItemDate.TabIndex = 24
        '
        'ItemEran
        '
        Me.ItemEran.Location = New System.Drawing.Point(739, 91)
        Me.ItemEran.Name = "ItemEran"
        Me.ItemEran.Size = New System.Drawing.Size(149, 20)
        Me.ItemEran.TabIndex = 22
        '
        'ItemMaxDiscaound
        '
        Me.ItemMaxDiscaound.Location = New System.Drawing.Point(739, 65)
        Me.ItemMaxDiscaound.Name = "ItemMaxDiscaound"
        Me.ItemMaxDiscaound.Size = New System.Drawing.Size(149, 20)
        Me.ItemMaxDiscaound.TabIndex = 20
        '
        'ItemLimit
        '
        Me.ItemLimit.Location = New System.Drawing.Point(739, 39)
        Me.ItemLimit.Name = "ItemLimit"
        Me.ItemLimit.Size = New System.Drawing.Size(149, 20)
        Me.ItemLimit.TabIndex = 18
        '
        'ItemQyt
        '
        Me.ItemQyt.Location = New System.Drawing.Point(119, 219)
        Me.ItemQyt.Name = "ItemQyt"
        Me.ItemQyt.Size = New System.Drawing.Size(155, 20)
        Me.ItemQyt.TabIndex = 16
        '
        'ItemPrice
        '
        Me.ItemPrice.Location = New System.Drawing.Point(119, 190)
        Me.ItemPrice.Name = "ItemPrice"
        Me.ItemPrice.Size = New System.Drawing.Size(155, 20)
        Me.ItemPrice.TabIndex = 14
        '
        'Itemplace
        '
        Me.Itemplace.FormattingEnabled = True
        Me.Itemplace.Location = New System.Drawing.Point(119, 163)
        Me.Itemplace.Name = "Itemplace"
        Me.Itemplace.Size = New System.Drawing.Size(155, 21)
        Me.Itemplace.TabIndex = 12
        '
        'ItemCompany
        '
        Me.ItemCompany.FormattingEnabled = True
        Me.ItemCompany.Location = New System.Drawing.Point(119, 134)
        Me.ItemCompany.Name = "ItemCompany"
        Me.ItemCompany.Size = New System.Drawing.Size(155, 21)
        Me.ItemCompany.TabIndex = 10
        '
        'ItemGrop
        '
        Me.ItemGrop.FormattingEnabled = True
        Me.ItemGrop.Location = New System.Drawing.Point(119, 107)
        Me.ItemGrop.Name = "ItemGrop"
        Me.ItemGrop.Size = New System.Drawing.Size(155, 21)
        Me.ItemGrop.TabIndex = 8
        '
        'ItemName
        '
        Me.ItemName.Location = New System.Drawing.Point(119, 75)
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Size = New System.Drawing.Size(155, 20)
        Me.ItemName.TabIndex = 6
        '
        'ItemBarcode
        '
        Me.ItemBarcode.Location = New System.Drawing.Point(119, 46)
        Me.ItemBarcode.Name = "ItemBarcode"
        Me.ItemBarcode.Size = New System.Drawing.Size(155, 20)
        Me.ItemBarcode.TabIndex = 4
        '
        'ItemID
        '
        Me.ItemID.Location = New System.Drawing.Point(119, 20)
        Me.ItemID.Name = "ItemID"
        Me.ItemID.Size = New System.Drawing.Size(155, 20)
        Me.ItemID.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Yellow
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(983, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(85, 252)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 172)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "حذف"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(4, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "اضافة"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(4, 127)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "تعديل"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(4, 84)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "حفظ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(67, 333)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(932, 156)
        Me.DataGridView1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(750, 297)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(669, 295)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "بحث"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 501)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Items"
        Me.Text = "Items"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ItemID As System.Windows.Forms.TextBox
    Friend WithEvents ItemMaxDiscaound As System.Windows.Forms.TextBox
    Friend WithEvents ItemLimit As System.Windows.Forms.TextBox
    Friend WithEvents ItemQyt As System.Windows.Forms.TextBox
    Friend WithEvents ItemPrice As System.Windows.Forms.TextBox
    Friend WithEvents Itemplace As System.Windows.Forms.ComboBox
    Friend WithEvents ItemCompany As System.Windows.Forms.ComboBox
    Friend WithEvents ItemGrop As System.Windows.Forms.ComboBox
    Friend WithEvents ItemName As System.Windows.Forms.TextBox
    Friend WithEvents ItemBarcode As System.Windows.Forms.TextBox
    Friend WithEvents ItemUser As System.Windows.Forms.TextBox
    Friend WithEvents ItemTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents ItemDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ItemEran As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
