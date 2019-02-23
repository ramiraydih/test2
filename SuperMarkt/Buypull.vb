Imports System.Data.OleDb

Public Class Buypull
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
        '============================================================================
        'load buyQ tabl 
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter
        dt.Clear()
        da = New OleDbDataAdapter("SELECT Operations.OperID, Operations.BuyID, Operations.OperItem, Items.Itemplace, Items.ItemPrice, Items.ItemQyt, Operations.BuyQyt, Operations.BuyTotalG, Operations.BuyDiscound, Operations.BuyUnitPrice, Operations.BuyTotalB, Operations.BuyEarn, Operations.OperDate, Operations.OperTime, Operations.OperUser FROM Items INNER JOIN Operations ON Items.ItemName = Operations.OperItem;", con)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        '=======================================================================================

        newpill()


        'اخفاءتفاصيل(المورد)
        GroupBox1.Visible = False

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
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        save_Buypill()
        MsgBox("تم حفظ البيانات  بنجاح")
        load_Buypll()


        newpill()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Item_Search.ShowDialog()

    End Sub
End Class