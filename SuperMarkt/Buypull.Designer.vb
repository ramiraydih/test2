<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Buypull
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
        Dim BuyIDLabel As System.Windows.Forms.Label
        Dim BuyDateLabel As System.Windows.Forms.Label
        Dim BuyTimeLabel As System.Windows.Forms.Label
        Dim BuyInvoiceNOLabel As System.Windows.Forms.Label
        Dim BuyImportersLabel As System.Windows.Forms.Label
        Dim BuyCashLabel As System.Windows.Forms.Label
        Dim BuyPostponeLabel As System.Windows.Forms.Label
        Dim BuyUserLabel As System.Windows.Forms.Label
        Dim BuyTotalGLabel As System.Windows.Forms.Label
        Dim BuyTotalBLabel As System.Windows.Forms.Label
        Dim BuyEarnLabel As System.Windows.Forms.Label
        Dim BuyEarnPercentLabel As System.Windows.Forms.Label
        Dim BuyItemCountLabel As System.Windows.Forms.Label
        Dim BuyAddLabel As System.Windows.Forms.Label
        Dim BuyMinusLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BuyID = New System.Windows.Forms.TextBox()
        Me.BuyDate = New System.Windows.Forms.DateTimePicker()
        Me.BuyTime = New System.Windows.Forms.DateTimePicker()
        Me.BuyInvoiceNO = New System.Windows.Forms.TextBox()
        Me.BuyImporters = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BuyCash = New System.Windows.Forms.CheckBox()
        Me.BuyPostpone = New System.Windows.Forms.CheckBox()
        Me.BuyUser = New System.Windows.Forms.TextBox()
        Me.BuyTotalG = New System.Windows.Forms.TextBox()
        Me.BuyTotalB = New System.Windows.Forms.TextBox()
        Me.BuyEarn = New System.Windows.Forms.TextBox()
        Me.BuyEarnPercent = New System.Windows.Forms.TextBox()
        Me.BuyItemCount = New System.Windows.Forms.TextBox()
        Me.BuyAdd = New System.Windows.Forms.TextBox()
        Me.BuyMinus = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        BuyIDLabel = New System.Windows.Forms.Label()
        BuyDateLabel = New System.Windows.Forms.Label()
        BuyTimeLabel = New System.Windows.Forms.Label()
        BuyInvoiceNOLabel = New System.Windows.Forms.Label()
        BuyImportersLabel = New System.Windows.Forms.Label()
        BuyCashLabel = New System.Windows.Forms.Label()
        BuyPostponeLabel = New System.Windows.Forms.Label()
        BuyUserLabel = New System.Windows.Forms.Label()
        BuyTotalGLabel = New System.Windows.Forms.Label()
        BuyTotalBLabel = New System.Windows.Forms.Label()
        BuyEarnLabel = New System.Windows.Forms.Label()
        BuyEarnPercentLabel = New System.Windows.Forms.Label()
        BuyItemCountLabel = New System.Windows.Forms.Label()
        BuyAddLabel = New System.Windows.Forms.Label()
        BuyMinusLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BuyIDLabel
        '
        BuyIDLabel.AutoSize = True
        BuyIDLabel.Location = New System.Drawing.Point(16, 80)
        BuyIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BuyIDLabel.Name = "BuyIDLabel"
        BuyIDLabel.Size = New System.Drawing.Size(47, 17)
        BuyIDLabel.TabIndex = 2
        BuyIDLabel.Text = "التسلسل:"
        '
        'BuyDateLabel
        '
        BuyDateLabel.AutoSize = True
        BuyDateLabel.Location = New System.Drawing.Point(33, 116)
        BuyDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BuyDateLabel.Name = "BuyDateLabel"
        BuyDateLabel.Size = New System.Drawing.Size(42, 17)
        BuyDateLabel.TabIndex = 4
        BuyDateLabel.Text = "التاريخ:"
        AddHandler BuyDateLabel.Click, AddressOf Me.BuyDateLabel_Click
        '
        'BuyTimeLabel
        '
        BuyTimeLabel.AutoSize = True
        BuyTimeLabel.Location = New System.Drawing.Point(36, 148)
        BuyTimeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BuyTimeLabel.Name = "BuyTimeLabel"
        BuyTimeLabel.Size = New System.Drawing.Size(38, 17)
        BuyTimeLabel.TabIndex = 6
        BuyTimeLabel.Text = "الوقت:"
        '
        'BuyInvoiceNOLabel
        '
        BuyInvoiceNOLabel.AutoSize = True
        BuyInvoiceNOLabel.Location = New System.Drawing.Point(4, 178)
        BuyInvoiceNOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BuyInvoiceNOLabel.Name = "BuyInvoiceNOLabel"
        BuyInvoiceNOLabel.Size = New System.Drawing.Size(69, 17)
        BuyInvoiceNOLabel.TabIndex = 8
        BuyInvoiceNOLabel.Text = "رقم الفاتوره :"
        AddHandler BuyInvoiceNOLabel.Click, AddressOf Me.BuyInvoiceNOLabel_Click
        '
        'BuyImportersLabel
        '
        BuyImportersLabel.AutoSize = True
        BuyImportersLabel.Location = New System.Drawing.Point(380, 87)
        BuyImportersLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BuyImportersLabel.Name = "BuyImportersLabel"
        BuyImportersLabel.Size = New System.Drawing.Size(37, 17)
        BuyImportersLabel.TabIndex = 10
        BuyImportersLabel.Text = "المورد"
        '
        'BuyCashLabel
        '
        BuyCashLabel.AutoSize = True
        BuyCashLabel.Location = New System.Drawing.Point(197, 32)
        BuyCashLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BuyCashLabel.Name = "BuyCashLabel"
        BuyCashLabel.Size = New System.Drawing.Size(29, 17)
        BuyCashLabel.TabIndex = 14
        BuyCashLabel.Text = "كاش"
        '
        'BuyPostponeLabel
        '
        BuyPostponeLabel.AutoSize = True
        BuyPostponeLabel.Location = New System.Drawing.Point(12, 32)
        BuyPostponeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BuyPostponeLabel.Name = "BuyPostponeLabel"
        BuyPostponeLabel.Size = New System.Drawing.Size(23, 17)
        BuyPostponeLabel.TabIndex = 16
        BuyPostponeLabel.Text = "دين"
        '
        'BuyUserLabel
        '
        BuyUserLabel.AutoSize = True
        BuyUserLabel.Location = New System.Drawing.Point(1104, 79)
        BuyUserLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BuyUserLabel.Name = "BuyUserLabel"
        BuyUserLabel.Size = New System.Drawing.Size(52, 17)
        BuyUserLabel.TabIndex = 18
        BuyUserLabel.Text = "المستخدم:"
        '
        'BuyTotalGLabel
        '
        BuyTotalGLabel.AutoSize = True
        BuyTotalGLabel.Location = New System.Drawing.Point(36, 496)
        BuyTotalGLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BuyTotalGLabel.Name = "BuyTotalGLabel"
        BuyTotalGLabel.Size = New System.Drawing.Size(87, 17)
        BuyTotalGLabel.TabIndex = 20
        BuyTotalGLabel.Text = "اجمالي الجمهور :"
        '
        'BuyTotalBLabel
        '
        BuyTotalBLabel.AutoSize = True
        BuyTotalBLabel.Location = New System.Drawing.Point(47, 530)
        BuyTotalBLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BuyTotalBLabel.Name = "BuyTotalBLabel"
        BuyTotalBLabel.Size = New System.Drawing.Size(76, 17)
        BuyTotalBLabel.TabIndex = 22
        BuyTotalBLabel.Text = "اجمالي الشراء:"
        AddHandler BuyTotalBLabel.Click, AddressOf Me.BuyTotalBLabel_Click
        '
        'BuyEarnLabel
        '
        BuyEarnLabel.AutoSize = True
        BuyEarnLabel.Location = New System.Drawing.Point(65, 564)
        BuyEarnLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BuyEarnLabel.Name = "BuyEarnLabel"
        BuyEarnLabel.Size = New System.Drawing.Size(71, 17)
        BuyEarnLabel.TabIndex = 24
        BuyEarnLabel.Text = "ربح الفاتوره :"
        '
        'BuyEarnPercentLabel
        '
        BuyEarnPercentLabel.AutoSize = True
        BuyEarnPercentLabel.Location = New System.Drawing.Point(25, 596)
        BuyEarnPercentLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BuyEarnPercentLabel.Name = "BuyEarnPercentLabel"
        BuyEarnPercentLabel.Size = New System.Drawing.Size(75, 17)
        BuyEarnPercentLabel.TabIndex = 26
        BuyEarnPercentLabel.Text = "اجمالي النسبه :"
        '
        'BuyItemCountLabel
        '
        BuyItemCountLabel.AutoSize = True
        BuyItemCountLabel.Location = New System.Drawing.Point(1045, 511)
        BuyItemCountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BuyItemCountLabel.Name = "BuyItemCountLabel"
        BuyItemCountLabel.Size = New System.Drawing.Size(74, 17)
        BuyItemCountLabel.TabIndex = 28
        BuyItemCountLabel.Text = "عدد الاصناف:"
        '
        'BuyAddLabel
        '
        BuyAddLabel.AutoSize = True
        BuyAddLabel.Location = New System.Drawing.Point(1023, 560)
        BuyAddLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BuyAddLabel.Name = "BuyAddLabel"
        BuyAddLabel.Size = New System.Drawing.Size(94, 17)
        BuyAddLabel.TabIndex = 30
        BuyAddLabel.Text = "اضافة مصروفات :"
        AddHandler BuyAddLabel.Click, AddressOf Me.BuyAddLabel_Click
        '
        'BuyMinusLabel
        '
        BuyMinusLabel.AutoSize = True
        BuyMinusLabel.Location = New System.Drawing.Point(1089, 601)
        BuyMinusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BuyMinusLabel.Name = "BuyMinusLabel"
        BuyMinusLabel.Size = New System.Drawing.Size(37, 17)
        BuyMinusLabel.TabIndex = 32
        BuyMinusLabel.Text = "خصم:"
        AddHandler BuyMinusLabel.Click, AddressOf Me.BuyMinusLabel_Click
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(643, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "فاتورة الشراء"
        '
        'BuyID
        '
        Me.BuyID.Location = New System.Drawing.Point(93, 76)
        Me.BuyID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyID.Name = "BuyID"
        Me.BuyID.Size = New System.Drawing.Size(171, 22)
        Me.BuyID.TabIndex = 3
        '
        'BuyDate
        '
        Me.BuyDate.CustomFormat = "yyyy/MM/dd"
        Me.BuyDate.Location = New System.Drawing.Point(93, 108)
        Me.BuyDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyDate.Name = "BuyDate"
        Me.BuyDate.Size = New System.Drawing.Size(171, 22)
        Me.BuyDate.TabIndex = 5
        '
        'BuyTime
        '
        Me.BuyTime.CustomFormat = "yyyy/MM/dd   ss:mm:hh tt"
        Me.BuyTime.Location = New System.Drawing.Point(93, 140)
        Me.BuyTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyTime.Name = "BuyTime"
        Me.BuyTime.Size = New System.Drawing.Size(171, 22)
        Me.BuyTime.TabIndex = 7
        Me.BuyTime.Value = New Date(2019, 2, 19, 9, 25, 0, 0)
        '
        'BuyInvoiceNO
        '
        Me.BuyInvoiceNO.Location = New System.Drawing.Point(93, 175)
        Me.BuyInvoiceNO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyInvoiceNO.Name = "BuyInvoiceNO"
        Me.BuyInvoiceNO.Size = New System.Drawing.Size(171, 22)
        Me.BuyInvoiceNO.TabIndex = 9
        '
        'BuyImporters
        '
        Me.BuyImporters.Location = New System.Drawing.Point(493, 84)
        Me.BuyImporters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyImporters.Name = "BuyImporters"
        Me.BuyImporters.Size = New System.Drawing.Size(164, 22)
        Me.BuyImporters.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(751, 80)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(267, 123)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "تفاصيل المورد"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 85)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 47)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "الرصيد الحالي "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "التلفون "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 217)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1323, 268)
        Me.DataGridView1.TabIndex = 13
        '
        'BuyCash
        '
        Me.BuyCash.Location = New System.Drawing.Point(243, 26)
        Me.BuyCash.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyCash.Name = "BuyCash"
        Me.BuyCash.Size = New System.Drawing.Size(139, 30)
        Me.BuyCash.TabIndex = 15
        Me.BuyCash.UseVisualStyleBackColor = True
        '
        'BuyPostpone
        '
        Me.BuyPostpone.Location = New System.Drawing.Point(51, 26)
        Me.BuyPostpone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyPostpone.Name = "BuyPostpone"
        Me.BuyPostpone.Size = New System.Drawing.Size(139, 30)
        Me.BuyPostpone.TabIndex = 17
        Me.BuyPostpone.UseVisualStyleBackColor = True
        '
        'BuyUser
        '
        Me.BuyUser.Location = New System.Drawing.Point(1184, 75)
        Me.BuyUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyUser.Name = "BuyUser"
        Me.BuyUser.Size = New System.Drawing.Size(173, 22)
        Me.BuyUser.TabIndex = 19
        '
        'BuyTotalG
        '
        Me.BuyTotalG.Location = New System.Drawing.Point(159, 492)
        Me.BuyTotalG.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyTotalG.Name = "BuyTotalG"
        Me.BuyTotalG.Size = New System.Drawing.Size(180, 22)
        Me.BuyTotalG.TabIndex = 21
        '
        'BuyTotalB
        '
        Me.BuyTotalB.Location = New System.Drawing.Point(159, 530)
        Me.BuyTotalB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyTotalB.Name = "BuyTotalB"
        Me.BuyTotalB.Size = New System.Drawing.Size(180, 22)
        Me.BuyTotalB.TabIndex = 23
        '
        'BuyEarn
        '
        Me.BuyEarn.Location = New System.Drawing.Point(159, 560)
        Me.BuyEarn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyEarn.Name = "BuyEarn"
        Me.BuyEarn.Size = New System.Drawing.Size(180, 22)
        Me.BuyEarn.TabIndex = 25
        '
        'BuyEarnPercent
        '
        Me.BuyEarnPercent.Location = New System.Drawing.Point(159, 592)
        Me.BuyEarnPercent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyEarnPercent.Name = "BuyEarnPercent"
        Me.BuyEarnPercent.Size = New System.Drawing.Size(180, 22)
        Me.BuyEarnPercent.TabIndex = 27
        '
        'BuyItemCount
        '
        Me.BuyItemCount.Location = New System.Drawing.Point(1144, 507)
        Me.BuyItemCount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyItemCount.Name = "BuyItemCount"
        Me.BuyItemCount.Size = New System.Drawing.Size(160, 22)
        Me.BuyItemCount.TabIndex = 29
        '
        'BuyAdd
        '
        Me.BuyAdd.Location = New System.Drawing.Point(1144, 556)
        Me.BuyAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyAdd.Name = "BuyAdd"
        Me.BuyAdd.Size = New System.Drawing.Size(160, 22)
        Me.BuyAdd.TabIndex = 31
        '
        'BuyMinus
        '
        Me.BuyMinus.Location = New System.Drawing.Point(1144, 596)
        Me.BuyMinus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BuyMinus.Name = "BuyMinus"
        Me.BuyMinus.Size = New System.Drawing.Size(160, 22)
        Me.BuyMinus.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(435, 80)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 28)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "...."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.Location = New System.Drawing.Point(1444, 116)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 28)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "حفظ الفاتوره "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button3.Location = New System.Drawing.Point(1444, 181)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 28)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "فاتور جديده"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Yellow
        Me.Button4.Location = New System.Drawing.Point(8, 39)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(57, 57)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "اضافة صنف "
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Location = New System.Drawing.Point(1371, 217)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(73, 268)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Yellow
        Me.Button5.Location = New System.Drawing.Point(8, 103)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(59, 66)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "حذف صنف "
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(346, 589)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 25)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "الربح الموتوقع بل نسبه المئويه للفاتوره "
        '
        'Buypull
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1545, 657)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(BuyMinusLabel)
        Me.Controls.Add(Me.BuyMinus)
        Me.Controls.Add(BuyAddLabel)
        Me.Controls.Add(Me.BuyAdd)
        Me.Controls.Add(BuyItemCountLabel)
        Me.Controls.Add(Me.BuyItemCount)
        Me.Controls.Add(BuyEarnPercentLabel)
        Me.Controls.Add(Me.BuyEarnPercent)
        Me.Controls.Add(BuyEarnLabel)
        Me.Controls.Add(Me.BuyEarn)
        Me.Controls.Add(BuyTotalBLabel)
        Me.Controls.Add(Me.BuyTotalB)
        Me.Controls.Add(BuyTotalGLabel)
        Me.Controls.Add(Me.BuyTotalG)
        Me.Controls.Add(BuyUserLabel)
        Me.Controls.Add(Me.BuyUser)
        Me.Controls.Add(BuyPostponeLabel)
        Me.Controls.Add(Me.BuyPostpone)
        Me.Controls.Add(BuyCashLabel)
        Me.Controls.Add(Me.BuyCash)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(BuyImportersLabel)
        Me.Controls.Add(Me.BuyImporters)
        Me.Controls.Add(BuyInvoiceNOLabel)
        Me.Controls.Add(Me.BuyInvoiceNO)
        Me.Controls.Add(BuyTimeLabel)
        Me.Controls.Add(Me.BuyTime)
        Me.Controls.Add(BuyDateLabel)
        Me.Controls.Add(Me.BuyDate)
        Me.Controls.Add(BuyIDLabel)
        Me.Controls.Add(Me.BuyID)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Buypull"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BuyID As System.Windows.Forms.TextBox
    Friend WithEvents BuyDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents BuyTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents BuyInvoiceNO As System.Windows.Forms.TextBox
    Friend WithEvents BuyImporters As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BuyCash As System.Windows.Forms.CheckBox
    Friend WithEvents BuyPostpone As System.Windows.Forms.CheckBox
    Friend WithEvents BuyUser As System.Windows.Forms.TextBox
    Friend WithEvents BuyTotalG As System.Windows.Forms.TextBox
    Friend WithEvents BuyTotalB As System.Windows.Forms.TextBox
    Friend WithEvents BuyEarn As System.Windows.Forms.TextBox
    Friend WithEvents BuyEarnPercent As System.Windows.Forms.TextBox
    Friend WithEvents BuyItemCount As System.Windows.Forms.TextBox
    Friend WithEvents BuyAdd As System.Windows.Forms.TextBox
    Friend WithEvents BuyMinus As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
