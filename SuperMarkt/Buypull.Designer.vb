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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
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
        Me.SuspendLayout()
        '
        'BuyIDLabel
        '
        BuyIDLabel.AutoSize = True
        BuyIDLabel.Location = New System.Drawing.Point(12, 65)
        BuyIDLabel.Name = "BuyIDLabel"
        BuyIDLabel.Size = New System.Drawing.Size(57, 13)
        BuyIDLabel.TabIndex = 2
        BuyIDLabel.Text = "التسلسل:"
        '
        'BuyDateLabel
        '
        BuyDateLabel.AutoSize = True
        BuyDateLabel.Location = New System.Drawing.Point(25, 94)
        BuyDateLabel.Name = "BuyDateLabel"
        BuyDateLabel.Size = New System.Drawing.Size(39, 13)
        BuyDateLabel.TabIndex = 4
        BuyDateLabel.Text = "التاريخ:"
        AddHandler BuyDateLabel.Click, AddressOf Me.BuyDateLabel_Click
        '
        'BuyTimeLabel
        '
        BuyTimeLabel.AutoSize = True
        BuyTimeLabel.Location = New System.Drawing.Point(27, 120)
        BuyTimeLabel.Name = "BuyTimeLabel"
        BuyTimeLabel.Size = New System.Drawing.Size(37, 13)
        BuyTimeLabel.TabIndex = 6
        BuyTimeLabel.Text = "الوقت:"
        '
        'BuyInvoiceNOLabel
        '
        BuyInvoiceNOLabel.AutoSize = True
        BuyInvoiceNOLabel.Location = New System.Drawing.Point(3, 145)
        BuyInvoiceNOLabel.Name = "BuyInvoiceNOLabel"
        BuyInvoiceNOLabel.Size = New System.Drawing.Size(66, 13)
        BuyInvoiceNOLabel.TabIndex = 8
        BuyInvoiceNOLabel.Text = "رقم الفاتوره :"
        AddHandler BuyInvoiceNOLabel.Click, AddressOf Me.BuyInvoiceNOLabel_Click
        '
        'BuyImportersLabel
        '
        BuyImportersLabel.AutoSize = True
        BuyImportersLabel.Location = New System.Drawing.Point(285, 71)
        BuyImportersLabel.Name = "BuyImportersLabel"
        BuyImportersLabel.Size = New System.Drawing.Size(34, 13)
        BuyImportersLabel.TabIndex = 10
        BuyImportersLabel.Text = "المورد"
        '
        'BuyCashLabel
        '
        BuyCashLabel.AutoSize = True
        BuyCashLabel.Location = New System.Drawing.Point(148, 26)
        BuyCashLabel.Name = "BuyCashLabel"
        BuyCashLabel.Size = New System.Drawing.Size(28, 13)
        BuyCashLabel.TabIndex = 14
        BuyCashLabel.Text = "كاش"
        '
        'BuyPostponeLabel
        '
        BuyPostponeLabel.AutoSize = True
        BuyPostponeLabel.Location = New System.Drawing.Point(9, 26)
        BuyPostponeLabel.Name = "BuyPostponeLabel"
        BuyPostponeLabel.Size = New System.Drawing.Size(23, 13)
        BuyPostponeLabel.TabIndex = 16
        BuyPostponeLabel.Text = "دين"
        '
        'BuyUserLabel
        '
        BuyUserLabel.AutoSize = True
        BuyUserLabel.Location = New System.Drawing.Point(828, 64)
        BuyUserLabel.Name = "BuyUserLabel"
        BuyUserLabel.Size = New System.Drawing.Size(60, 13)
        BuyUserLabel.TabIndex = 18
        BuyUserLabel.Text = "المستخدم:"
        '
        'BuyTotalGLabel
        '
        BuyTotalGLabel.AutoSize = True
        BuyTotalGLabel.Location = New System.Drawing.Point(27, 403)
        BuyTotalGLabel.Name = "BuyTotalGLabel"
        BuyTotalGLabel.Size = New System.Drawing.Size(86, 13)
        BuyTotalGLabel.TabIndex = 20
        BuyTotalGLabel.Text = "اجمالي الجمهور :"
        '
        'BuyTotalBLabel
        '
        BuyTotalBLabel.AutoSize = True
        BuyTotalBLabel.Location = New System.Drawing.Point(35, 431)
        BuyTotalBLabel.Name = "BuyTotalBLabel"
        BuyTotalBLabel.Size = New System.Drawing.Size(78, 13)
        BuyTotalBLabel.TabIndex = 22
        BuyTotalBLabel.Text = "اجمالي الشراء:"
        AddHandler BuyTotalBLabel.Click, AddressOf Me.BuyTotalBLabel_Click
        '
        'BuyEarnLabel
        '
        BuyEarnLabel.AutoSize = True
        BuyEarnLabel.Location = New System.Drawing.Point(49, 458)
        BuyEarnLabel.Name = "BuyEarnLabel"
        BuyEarnLabel.Size = New System.Drawing.Size(64, 13)
        BuyEarnLabel.TabIndex = 24
        BuyEarnLabel.Text = "ربح الفاتوره :"
        '
        'BuyEarnPercentLabel
        '
        BuyEarnPercentLabel.AutoSize = True
        BuyEarnPercentLabel.Location = New System.Drawing.Point(19, 484)
        BuyEarnPercentLabel.Name = "BuyEarnPercentLabel"
        BuyEarnPercentLabel.Size = New System.Drawing.Size(83, 13)
        BuyEarnPercentLabel.TabIndex = 26
        BuyEarnPercentLabel.Text = "اجمالي النسبه :"
        '
        'BuyItemCountLabel
        '
        BuyItemCountLabel.AutoSize = True
        BuyItemCountLabel.Location = New System.Drawing.Point(784, 415)
        BuyItemCountLabel.Name = "BuyItemCountLabel"
        BuyItemCountLabel.Size = New System.Drawing.Size(68, 13)
        BuyItemCountLabel.TabIndex = 28
        BuyItemCountLabel.Text = "عدد الاصناف:"
        '
        'BuyAddLabel
        '
        BuyAddLabel.AutoSize = True
        BuyAddLabel.Location = New System.Drawing.Point(767, 455)
        BuyAddLabel.Name = "BuyAddLabel"
        BuyAddLabel.Size = New System.Drawing.Size(85, 13)
        BuyAddLabel.TabIndex = 30
        BuyAddLabel.Text = "اضافة مصروفات :"
        AddHandler BuyAddLabel.Click, AddressOf Me.BuyAddLabel_Click
        '
        'BuyMinusLabel
        '
        BuyMinusLabel.AutoSize = True
        BuyMinusLabel.Location = New System.Drawing.Point(817, 488)
        BuyMinusLabel.Name = "BuyMinusLabel"
        BuyMinusLabel.Size = New System.Drawing.Size(35, 13)
        BuyMinusLabel.TabIndex = 32
        BuyMinusLabel.Text = "خصم:"
        AddHandler BuyMinusLabel.Click, AddressOf Me.BuyMinusLabel_Click
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(482, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "فاتورة الشراء"
        '
        'BuyID
        '
        Me.BuyID.Location = New System.Drawing.Point(70, 62)
        Me.BuyID.Name = "BuyID"
        Me.BuyID.Size = New System.Drawing.Size(129, 20)
        Me.BuyID.TabIndex = 3
        '
        'BuyDate
        '
        Me.BuyDate.CustomFormat = "yyyy/MM/dd"
        Me.BuyDate.Location = New System.Drawing.Point(70, 88)
        Me.BuyDate.Name = "BuyDate"
        Me.BuyDate.Size = New System.Drawing.Size(129, 20)
        Me.BuyDate.TabIndex = 5
        '
        'BuyTime
        '
        Me.BuyTime.CustomFormat = "yyyy/MM/dd   ss:mm:hh tt"
        Me.BuyTime.Location = New System.Drawing.Point(70, 114)
        Me.BuyTime.Name = "BuyTime"
        Me.BuyTime.Size = New System.Drawing.Size(129, 20)
        Me.BuyTime.TabIndex = 7
        Me.BuyTime.Value = New Date(2019, 2, 19, 9, 25, 0, 0)
        '
        'BuyInvoiceNO
        '
        Me.BuyInvoiceNO.Location = New System.Drawing.Point(70, 142)
        Me.BuyInvoiceNO.Name = "BuyInvoiceNO"
        Me.BuyInvoiceNO.Size = New System.Drawing.Size(129, 20)
        Me.BuyInvoiceNO.TabIndex = 9
        '
        'BuyImporters
        '
        Me.BuyImporters.Location = New System.Drawing.Point(370, 68)
        Me.BuyImporters.Name = "BuyImporters"
        Me.BuyImporters.Size = New System.Drawing.Size(124, 20)
        Me.BuyImporters.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(563, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "تفاصيل المورد"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(52, 176)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(992, 218)
        Me.DataGridView1.TabIndex = 13
        '
        'BuyCash
        '
        Me.BuyCash.Location = New System.Drawing.Point(182, 21)
        Me.BuyCash.Name = "BuyCash"
        Me.BuyCash.Size = New System.Drawing.Size(104, 24)
        Me.BuyCash.TabIndex = 15
        Me.BuyCash.UseVisualStyleBackColor = True
        '
        'BuyPostpone
        '
        Me.BuyPostpone.Location = New System.Drawing.Point(38, 21)
        Me.BuyPostpone.Name = "BuyPostpone"
        Me.BuyPostpone.Size = New System.Drawing.Size(104, 24)
        Me.BuyPostpone.TabIndex = 17
        Me.BuyPostpone.UseVisualStyleBackColor = True
        '
        'BuyUser
        '
        Me.BuyUser.Location = New System.Drawing.Point(888, 61)
        Me.BuyUser.Name = "BuyUser"
        Me.BuyUser.Size = New System.Drawing.Size(131, 20)
        Me.BuyUser.TabIndex = 19
        '
        'BuyTotalG
        '
        Me.BuyTotalG.Location = New System.Drawing.Point(119, 400)
        Me.BuyTotalG.Name = "BuyTotalG"
        Me.BuyTotalG.Size = New System.Drawing.Size(136, 20)
        Me.BuyTotalG.TabIndex = 21
        '
        'BuyTotalB
        '
        Me.BuyTotalB.Location = New System.Drawing.Point(119, 431)
        Me.BuyTotalB.Name = "BuyTotalB"
        Me.BuyTotalB.Size = New System.Drawing.Size(136, 20)
        Me.BuyTotalB.TabIndex = 23
        '
        'BuyEarn
        '
        Me.BuyEarn.Location = New System.Drawing.Point(119, 455)
        Me.BuyEarn.Name = "BuyEarn"
        Me.BuyEarn.Size = New System.Drawing.Size(136, 20)
        Me.BuyEarn.TabIndex = 25
        '
        'BuyEarnPercent
        '
        Me.BuyEarnPercent.Location = New System.Drawing.Point(119, 481)
        Me.BuyEarnPercent.Name = "BuyEarnPercent"
        Me.BuyEarnPercent.Size = New System.Drawing.Size(136, 20)
        Me.BuyEarnPercent.TabIndex = 27
        '
        'BuyItemCount
        '
        Me.BuyItemCount.Location = New System.Drawing.Point(858, 412)
        Me.BuyItemCount.Name = "BuyItemCount"
        Me.BuyItemCount.Size = New System.Drawing.Size(121, 20)
        Me.BuyItemCount.TabIndex = 29
        '
        'BuyAdd
        '
        Me.BuyAdd.Location = New System.Drawing.Point(858, 452)
        Me.BuyAdd.Name = "BuyAdd"
        Me.BuyAdd.Size = New System.Drawing.Size(121, 20)
        Me.BuyAdd.TabIndex = 31
        '
        'BuyMinus
        '
        Me.BuyMinus.Location = New System.Drawing.Point(858, 484)
        Me.BuyMinus.Name = "BuyMinus"
        Me.BuyMinus.Size = New System.Drawing.Size(121, 20)
        Me.BuyMinus.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(326, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "...."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "التلفون "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "الرصيد الحالي "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "0"
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button2.Location = New System.Drawing.Point(986, 94)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "حفظ الفاتوره "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button3.Location = New System.Drawing.Point(986, 147)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "فاتور جديده"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Buypull
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1111, 534)
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
        Me.Name = "Buypull"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
