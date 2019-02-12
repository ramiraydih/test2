Imports System.Data.OleDb

Public Class Customer
    Public Sub newCustomers()
        Code_Customers()
        CustomerAddress.Text = ""
        CustomerBalance.Text = 0
        CustomerDate.Value = Now.Date
        CustomerGender.Text = ""
        CustomerID.Text = mynewIDCustomers
        CustomerName.Text = ""
        CustomerPhone.Text = ""
        CustomerTime.Value = Now
        CustomerType.Text = ""
        CustomerUser.Text = ""





    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Customers()
        DataGridView1.DataSource = (CustomersDT)
        newCustomers()


    End Sub

    Private Sub CustomerDateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerDate.ValueChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        CustomersDT.Clear()
        CustomersDA = New OleDbDataAdapter("select * from Customers where CustomerName like '%" & TextBox1.Text & "%'   ", con)
        CustomersDA.Fill(CustomersDT)






    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        newCustomers()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CustomersDT.Rows.Add()
        Dim last As Integer = CustomersDT.Rows.Count - 1
        CustomersDT.Rows(last).Item("CustomerAddress") = CustomerAddress.Text
        CustomersDT.Rows(last).Item("CustomerBalance") = CustomerBalance.Text
        CustomersDT.Rows(last).Item("CustomerDate") = CustomerDate.Value
        CustomersDT.Rows(last).Item("CustomerGender") = CustomerGender.Text
        CustomersDT.Rows(last).Item("CustomerID") = CustomerID.Text
        CustomersDT.Rows(last).Item("CustomerName") = CustomerName.Text
        CustomersDT.Rows(last).Item("Customerphone") = CustomerPhone.Text
        CustomersDT.Rows(last).Item("CustomerTime") = CustomerTime.Value
        CustomersDT.Rows(last).Item("CustomerType") = CustomerType.Text
        CustomersDT.Rows(last).Item("CustomerUser") = CustomerUser.Text
        Dim save As New OleDbCommandBuilder(CustomersDA)
        CustomersDA.Update(CustomersDT)
        CustomersDT.AcceptChanges()
        MsgBox("تم حفظ البيانات بنجاح")
        Load_Customers()
        newCustomers()





        newCustomers()
    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try
            Dim pos As Integer = BindingContext(CustomersDT).Position
            CustomerAddress.Text = CustomersDT.Rows(pos).Item("CustomerAddress")
            CustomerBalance.Text = CustomersDT.Rows(pos).Item("CustomerBalance")
            CustomerDate.Value = CustomersDT.Rows(pos).Item("CustomerDate")
            CustomerGender.Text = CustomersDT.Rows(pos).Item("CustomerGender")
            CustomerID.Text = CustomersDT.Rows(pos).Item("CustomerID")
            CustomerName.Text = CustomersDT.Rows(pos).Item("CustomerName")
            CustomerPhone.Text = CustomersDT.Rows(pos).Item("Customerphone")
            CustomerTime.Value = CustomersDT.Rows(pos).Item("CustomerTime")
            CustomerType.Text = CustomersDT.Rows(pos).Item("CustomerType")
            CustomerUser.Text = CustomersDT.Rows(pos).Item("CustomerUser")


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim pos As Integer = BindingContext(CustomersDT).Position
        CustomersDT.Rows(pos).Item("CustomerAddress") = CustomerAddress.Text
        CustomersDT.Rows(pos).Item("CustomerBalance") = CustomerBalance.Text
        CustomersDT.Rows(pos).Item("CustomerDate") = CustomerDate.Value
        CustomersDT.Rows(pos).Item("CustomerGender") = CustomerGender.Text
        CustomersDT.Rows(pos).Item("CustomerID") = CustomerID.Text
        CustomersDT.Rows(pos).Item("CustomerName") = CustomerName.Text
        CustomersDT.Rows(pos).Item("CustomerPhone") = CustomerPhone.Text
        CustomersDT.Rows(pos).Item("CustomerTime") = CustomerTime.Value
        CustomersDT.Rows(pos).Item("CustomerType") = CustomerType.Text
        CustomersDT.Rows(pos).Item("CustomerUser") = CustomerUser.Text
        Dim save As New OleDbCommandBuilder(CustomersDA)
        CustomersDA.Update(CustomersDT)
        CustomersDT.AcceptChanges()
        MsgBox("تم تعديل البيانات بنجاح ")
        Load_Customers()




    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If MsgBox(" هل تريد حذف العميل ", MsgBoxStyle.OkCancel, "تاكيد الحذف ") Then
            Dim pos As Integer = BindingContext(CustomersDT).Position
            CustomersDT.Rows(pos).Delete()
            Dim save As New OleDbCommandBuilder(CustomersDA)
            CustomersDA.Update(CustomersDT)
            CustomersDT.AcceptChanges()
            MsgBox("تم الحذف بنجاح ")
            Load_Customers()
        Else
        End If

    End Sub
End Class