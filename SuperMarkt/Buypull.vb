Imports System.Data.OleDb

Public Class Buypull

    Public operationsCMD As New OleDbCommand
    Public operationsDT As New DataTable
    Public operationsDA As New OleDbDataAdapter

    Public itemsCMD As New OleDbCommand

    Public importersCMD As New OleDbCommand




    Public Sub loadbuyQ()
        Try
            '========================================================================  'load buyQ tabl 
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter
            dt.Clear()
            '-----------------------------------------(0)-----------------(1)---------------(2)-------------(3)-----------(4)--------------(5)--------------(6)----------------(7)---------------(8)-------------------(9)------------------------(10)--------------------(11)-----------------(12)-----------------(13)-----------------(14)----------------(15)
            da = New OleDbDataAdapter("SELECT Operations.OperID, Operations.BuyID, Operations.OperItem,operItemExp, Items.Itemplace, Items.ItemPrice, Items.ItemQyt, Operations.BuyQyt, Operations.BuyTotalG, Operations.BuyDiscound, Operations.BuyUnitPrice, Operations.BuyTotalB, Operations.BuyEarn, Operations.OperDate, Operations.OperTime, Operations.OperUser FROM Items,Operations where Items.ItemName = Operations.OperItem  ", con)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub buycalc()
        'اجمالي الجمهور 
        'total=qty*price
        '8=7*4
        DataGridView1(8, DataGridView1.CurrentRow.Index).Value = Val(DataGridView1(7, DataGridView1.CurrentRow.Index).Value) * Val(DataGridView1(5, DataGridView1.CurrentRow.Index).Value)
        'اجمالي الشراء 
        'totalb=total-(total*discound)
        DataGridView1(11, DataGridView1.CurrentRow.Index).Value = Val(DataGridView1(8, DataGridView1.CurrentRow.Index).Value) - (Val(DataGridView1(8, DataGridView1.CurrentRow.Index).Value) * (Val(DataGridView1(9, DataGridView1.CurrentRow.Index).Value) / 100))

        'سعر الشراء 
        DataGridView1(10, DataGridView1.CurrentRow.Index).Value = Val(DataGridView1(11, DataGridView1.CurrentRow.Index).Value) / Val(DataGridView1(7, DataGridView1.CurrentRow.Index).Value)
        'الربح
        DataGridView1(12, DataGridView1.CurrentRow.Index).Value = Val(DataGridView1(8, DataGridView1.CurrentRow.Index).Value) - Val(DataGridView1(11, DataGridView1.CurrentRow.Index).Value)


        Dim total, totalb, count, earn, perc As Double

        For i As Integer = 0 To DataGridView1.Rows.Count - 1

            total = total + Val(DataGridView1(8, DataGridView1.Rows(i).Index).Value)
            totalb = totalb + Val(DataGridView1(11, DataGridView1.Rows(i).Index).Value)
            count = DataGridView1.Rows.Count
            earn = total - totalb
            perc = (1 - (totalb / total)) * 100

        Next
        BuyTotalG.Text = total
        BuyTotalB.Text = totalb
        BuyItemCount.Text = count
        BuyEarn.Text = earn
        'نسبة الربح المتوقع بل نسبه المئويه 
        BuyEarnPercent.Text = Math.Round(perc, 2)







    End Sub
    Public Sub newpill()
        Code_Buypll()
        BuyAdd.Text = 0
        BuyCash.Checked = True
        BuyDate.Value = Now.Date
        BuyEarn.Text = 0
        BuyEarnPercent.Text = 0
        BuyID.Text = mynewIDBuypll
        BuyImporters.Text = ""
        BuyInvoiceNO.Text = ""
        BuyItemCount.Text = 0
        BuyMinus.Text = 0
        BuyPostpone.Checked = False
        BuyTime.Value = Now
        BuyTotalB.Text = 0
        BuyTotalG.Text = 0
        BuyUser.Text = ""

    End Sub
    Public Sub save_Buypill()
        BuypllDT.Rows.Add()
        Dim last As Integer = BuypllDT.Rows.Count - 1
        BuypllDT.Rows(last).Item("BuyAdd") = BuyAdd.Text
        BuypllDT.Rows(last).Item("BuyCash") = BuyCash.Checked
        BuypllDT.Rows(last).Item("BuyDate") = BuyDate.Value
        BuypllDT.Rows(last).Item("BuyEarn") = BuyEarn.Text
        BuypllDT.Rows(last).Item("BuyEarnPercent") = BuyEarnPercent.Text
        BuypllDT.Rows(last).Item("BuyID") = BuyID.Text
        BuypllDT.Rows(last).Item("BuyImporters") = BuyImporters.Text
        BuypllDT.Rows(last).Item("BuyInvoiceNO") = BuyInvoiceNO.Text
        BuypllDT.Rows(last).Item("BuyItemCount") = BuyItemCount.Text
        BuypllDT.Rows(last).Item("BuyMinus") = BuyMinus.Text
        BuypllDT.Rows(last).Item("BuyPostpone") = BuyPostpone.Checked
        BuypllDT.Rows(last).Item("BuyTime") = BuyTime.Value
        BuypllDT.Rows(last).Item("BuyTotalG") = BuyTotalG.Text
        BuypllDT.Rows(last).Item("BuyTotalB") = BuyTotalB.Text
        BuypllDT.Rows(last).Item("BuyUser") = BuyUser.Text
        Dim save As New OleDbCommandBuilder(BuypllDA)
        BuypllDA.Update(BuypllDT)
        BuypllDT.AcceptChanges()





    End Sub




    Private Sub BuypllBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Buypull_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'loading by bill table
        load_Buypll()
        'load buyQ tabl 


        newpill()

        'اخفاءتفاصيل(المورد)
        GroupBox1.Visible = False

        loadbuyQ()
        '=========================================================
        Try
            DataGridView1.Columns(2).DefaultCellStyle.BackColor = Color.Yellow

            '=====================
            buycalc()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BuyDateLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BuyInvoiceNOLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BuyImportersTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyImporters.TextChanged
        'اخفاء واظهار تفاصيل المورد

        If BuyImporters.Text <> Nothing Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()

    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BuyTotalBLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_5(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_6(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_7(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_8(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_9(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BuyMinusLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BuyAddLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Importer_Search.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        newpill()
        loadbuyQ()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If BuyInvoiceNO.Text = Nothing Then

            MsgBox("ادخل رقم الفاتوره ")
        ElseIf BuyImporters.Text = Nothing Then
            MsgBox("الرجاء ادخال اسم المورد ")
            BuyImporters.Focus()
        ElseIf BuyCash.Checked = False And BuyPostpone.Checked = False Then
            MsgBox("الرجاء اختيار نوع الفاتوره دين او نقدي ")
            BuyCash.Focus()
        ElseIf DataGridView1.Rows.Count = 0 Then
            MsgBox("ادخل الصنف المطلوب ")

        Else
            buycalc()


            '=============================================================
            'UPDAT baypll detalis
            'For i As Integer = 0 To DataGridView1.Rows.Count - 1
            '    operationsCMD = New OleDbCommand("UPDATE Operations SET BuyDiscound = " & DataGridView1(9, DataGridView1.Rows(i).Index).Value & ",BuyEarn= " & DataGridView1(12, DataGridView1.Rows(i).Index).Value & " ,BuyQyt= " & DataGridView1(7, DataGridView1.Rows(i).Index).Value & ",BuyTotalB=" & DataGridView1(11, DataGridView1.Rows(i).Index).Value & ", BuyTotalG=" & DataGridView1(8, DataGridView1.Rows(i).Index).Value & ",BuyUnitPrice=" & DataGridView1(10, DataGridView1.Rows(i).Index).Value & ",operItemExp=#" & DataGridView1(3, DataGridView1.Rows(i).Index).Value & "# where OperID=" & DataGridView1(0, DataGridView1.Rows(i).Index).Value & "", con)

            '    con.Open()
            '    operationsCMD.ExecuteNonQuery()
            '    con.Close()
            'Next
            '=====================================
            'updata qty in item  table 
            
            'For z As Integer = 0 To DataGridView1.Rows.Count - 1
            '    Dim newqty As Double
            '    newqty = DataGridView1(7, DataGridView1.Rows(z).Index).Value + DataGridView1(6, DataGridView1.Rows(z).Index).Value
            '    itemsCMD = New OleDbCommand("update items SET ItemQyt= " & newqty & " where ItemName= '" & DataGridView1(2, DataGridView1.Rows(z).Index).Value & "' ", con)
            '    con.Open()
            '    itemsCMD.ExecuteNonQuery()
            '    con.Close()

            'Next
            'If BuyPostpone.Checked = True Then
            '    Dim newbalance As Double
            '    newbalance = Val(BuyTotalB.Text) + Val(Label5.Text)

            '    importersCMD = New OleDbCommand("Update Importers SET ImporterBalance = " & newbalance & " where ImporterName= '" & BuyImporters.Text & "'", con)
            '    con.Open()
            '    importersCMD.ExecuteNonQuery()
            '    con.Close()
            'End If





            save_Buypill()
            MsgBox("تم حفظ البيانات  بنجاح")
            newpill()
            load_Buypll()
            loadbuyQ()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Item_Search.ShowDialog()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
       
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim dt As New DataTable
        Dim cmd As New OleDbCommand
        dt.Clear()
        cmd = New OleDbCommand("Delete from  Operations where OperID = " & DataGridView1(0, DataGridView1.CurrentRow.Index).Value & "", con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        'load buyQ tabl 
        loadbuyQ()

      
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim qty, discound As Double
        Dim exp As Date
        qty = DataGridView1(6, DataGridView1.CurrentRow.Index).Value
        discound = DataGridView1(9, DataGridView1.CurrentRow.Index).Value
        exp = DataGridView1(3, DataGridView1.CurrentRow.Index).Value
        Dim dt As New DataTable
        Dim cmd As New OleDbCommand
        dt.Clear()
        cmd = New OleDbCommand("UPDATE Operations SET BuyQyt = '" & qty & "', BuyDiscound = '" & discound & "'operItemExp= #" & exp & "# where OperID=" & DataGridView1(0, DataGridView1.CurrentRow.Index).Value & " ", con)
        con.Open()
        cmd.ExecuteNonQuery()
        'con.Close()
        '=====================================================================================
        buycalc()


    End Sub

    Private Function BuyQyt() As Object
        Throw New NotImplementedException
    End Function

    Private Function newqt() As String
        Throw New NotImplementedException
    End Function

End Class




