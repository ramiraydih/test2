Imports System.Data.OleDb

Public Class Items
    Public Sub ClearItems()
        Code_Items()
        ItemBarcode.Text = ""
        ItemCompany.Text = ""
        ItemDate.Value = Now.Date
        ItemEran.Text = 0
        ItemGrop.Text = ""
        ItemID.Text = mynewIDItems
        ItemLimit.Text = 0
        ItemMaxDiscaound.Text = 0
        ItemName.Text = ""
        ItemPrice.Text = 0
        Itemplace.Text = ""
        ItemQyt.Text = 0
        ItemTime.Value = Now
        ItemUser.Text = ""


    End Sub


    Private Sub ItemsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Items_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_Gruop()
        ItemGrop.DataSource = GroupDT
        ItemGrop.DisplayMember = "GroupName"
        ItemGrop.ValueMember = "GroupID"
        '==================================================
        Load_Items()
        DataGridView1.DataSource = ItemsDT
        ClearItems()
        '===================================================
        load_Compinys()
        ItemCompany.DataSource = CompinyDT
        ItemCompany.DisplayMember = "CompanyName"
        ItemCompany.ValueMember = "CompanyID"
        '====================================================
        load_place()
        Itemplace.DataSource = placeDt
        Itemplace.DisplayMember = "PlacesName"
        Itemplace.ValueMember = "PlacesID"

    End Sub

    Private Sub ItemIDLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ItemsDT.Rows.Add()
        Dim last As Integer = ItemsDT.Rows.Count - 1
        ItemsDT.Rows(last).Item("ItemBarcode") = ItemBarcode.Text
        ItemsDT.Rows(last).Item("ItemCompany") = ItemCompany.Text
        ItemsDT.Rows(last).Item("ItemDate") = ItemDate.Value
        ItemsDT.Rows(last).Item("ItemEran") = ItemEran.Text
        ItemsDT.Rows(last).Item("ItemGrop") = ItemGrop.Text
        ItemsDT.Rows(last).Item("ItemID") = ItemID.Text
        ItemsDT.Rows(last).Item("ItemLimit") = ItemLimit.Text
        ItemsDT.Rows(last).Item("ItemMaxDiscaound") = ItemMaxDiscaound.Text
        ItemsDT.Rows(last).Item("ItemName") = ItemName.Text
        ItemsDT.Rows(last).Item("Itemplace") = Itemplace.Text
        ItemsDT.Rows(last).Item("ItemPrice") = ItemPrice.Text
        ItemsDT.Rows(last).Item("ItemQyt") = ItemQyt.Text
        ItemsDT.Rows(last).Item("ItemTime") = ItemTime.Value
        ItemsDT.Rows(last).Item("ItemUser") = ItemUser.Text
        Dim save As New OleDbCommandBuilder(ItemsDA)
        ItemsDA.Update(ItemsDT)
        ItemsDT.AcceptChanges()
        MsgBox("تم الحفظ بنجاح")
        Load_Items()
        ClearItems()
















        ClearItems()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ClearItems()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pos As Integer = BindingContext(ItemsDT).Position
        ItemsDT.Rows(pos).Item("ItemBarcode") = ItemBarcode.Text
        ItemsDT.Rows(pos).Item("ItemCompany") = ItemCompany.Text
        ItemsDT.Rows(pos).Item("ItemDate") = ItemDate.Value
        ItemsDT.Rows(pos).Item("ItemEran") = ItemEran.Text
        ItemsDT.Rows(pos).Item("ItemGrop") = ItemGrop.Text
        ItemsDT.Rows(pos).Item("ItemID") = ItemID.Text
        ItemsDT.Rows(pos).Item("ItemLimit") = ItemLimit.Text
        ItemsDT.Rows(pos).Item("ItemMaxDiscaound") = ItemMaxDiscaound.Text
        ItemsDT.Rows(pos).Item("ItemName") = ItemName.Text
        ItemsDT.Rows(pos).Item("Itemplace") = Itemplace.Text
        ItemsDT.Rows(pos).Item("ItemPrice") = ItemPrice.Text
        ItemsDT.Rows(pos).Item("ItemQyt") = ItemQyt.Text
        ItemsDT.Rows(pos).Item("ItemTime") = ItemTime.Value
        ItemsDT.Rows(pos).Item("ItemUser") = ItemUser.Text
        Dim save As New OleDbCommandBuilder(ItemsDA)
        ItemsDA.Update(ItemsDT)
        ItemsDT.AcceptChanges()
        MsgBox("تم التعديل بنجاح")
        Load_Items()


    End Sub

   

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try

            Dim pos As Integer = BindingContext(ItemsDT).Position
            ItemBarcode.Text = ItemsDT.Rows(pos).Item("ItemBarcode")
            ItemCompany.Text = ItemsDT.Rows(pos).Item("ItemCompany")
            ItemDate.Value = ItemsDT.Rows(pos).Item("ItemDate")
            ItemEran.Text = ItemsDT.Rows(pos).Item("ItemEran")
            ItemGrop.Text = ItemsDT.Rows(pos).Item("ItemGrop")
            ItemID.Text = ItemsDT.Rows(pos).Item("ItemID")
            ItemLimit.Text = ItemsDT.Rows(pos).Item("ItemLimit")
            ItemMaxDiscaound.Text = ItemsDT.Rows(pos).Item("ItemMaxDiscaound")
            ItemName.Text = ItemsDT.Rows(pos).Item("ItemName")
            Itemplace.Text = ItemsDT.Rows(pos).Item("Itemplace")
            ItemPrice.Text = ItemsDT.Rows(pos).Item("ItemPrice")
            ItemQyt.Text = ItemsDT.Rows(pos).Item("ItemQyt")
            ItemTime.Value = ItemsDT.Rows(pos).Item("ItemTime")
            ItemUser.Text = ItemsDT.Rows(pos).Item("ItemUser")

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox("هل تريد حذف العميل", MsgBoxStyle.OkCancel, "تاكيد الحذف ") Then
            Dim pos As Integer = BindingContext(ItemsDT).Position
            ItemsDT.Rows(pos).Delete()
            Dim save As New OleDbCommandBuilder(ItemsDA)
            ItemsDA.Update(ItemsDT)
            ItemsDT.AcceptChanges()
            MsgBox("تم حذف البانات ")
            Load_Items()
        Else



        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        ItemsDT.Clear()
        ItemsDA = New OleDbDataAdapter("Select* from Items where ItemName like '%" & TextBox1.Text & "%'", con)
        ItemsDA.Fill(ItemsDT)
    End Sub

    Private Sub ItemGrop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemGrop.SelectedIndexChanged

    End Sub
End Class