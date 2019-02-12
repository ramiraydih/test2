Imports System.Data.OleDb

Public Class Importer
    Public Sub newimporter()
        Code_Importers()
        ImporterAddress.Text = ""
        ImporterBalance.Text = 0
        ImporterDate.Value = Now.Date
        ImporterID.Text = mynewIDImporters
        ImporterName.Text = ""
        ImporterPhone.Text = ""
        ImporterTime.Value = Now
        ImporterType.Text = ""
        ImporterUser.Text = ""
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub ImportersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Importer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Importers()
        DataGridView1.DataSource = (ImportersDT)
        newimporter()

       
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        newimporter()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ImportersDT.Rows.Add()

        Dim last As Integer = ImportersDT.Rows.Count - 1

        Dim save As New OleDbCommandBuilder(ImportersDA)
        ImportersDT.Rows(last).Item("ImporterAddress") = ImporterAddress.Text
        ImportersDT.Rows(last).Item("ImporterBalance") = ImporterBalance.Text
        ImportersDT.Rows(last).Item("ImporterDate") = ImporterDate.Value
        ImportersDT.Rows(last).Item("ImporterID") = ImporterID.Text
        ImportersDT.Rows(last).Item("ImporterName") = ImporterName.Text
        ImportersDT.Rows(last).Item("ImporterPhone") = ImporterPhone.Text
        ImportersDT.Rows(last).Item("ImporterTime") = ImporterTime.Value
        ImportersDT.Rows(last).Item("ImporterType") = ImporterType.Text
        ImportersDT.Rows(last).Item("ImporterUser") = ImporterUser.Text
        ImportersDA.Update(ImportersDT)
        ImportersDT.AcceptChanges()
        MsgBox("تم حفظ البيانات بنجاح ")
        Load_Importers()







        newimporter()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pos As Integer = BindingContext(ImportersDT).Position
        ImportersDT.Rows(pos).Item("ImporterAddress") = ImporterAddress.Text
        ImportersDT.Rows(pos).Item("ImporterBalance") = ImporterBalance.Text
        ImportersDT.Rows(pos).Item("ImporterDate") = ImporterDate.Value
        ImportersDT.Rows(pos).Item("ImporterID") = ImporterID.Text
        ImportersDT.Rows(pos).Item("ImporterName") = ImporterName.Text
        ImportersDT.Rows(pos).Item("ImporterPhone") = ImporterPhone.Text
        ImportersDT.Rows(pos).Item("ImporterTime") = ImporterTime.Value
        ImportersDT.Rows(pos).Item("ImporterType") = ImporterType.Text
        ImportersDT.Rows(pos).Item("ImporterUser") = ImporterUser.Text
         Dim save As New OleDbCommandBuilder(ImportersDA)
        ImportersDA.Update(ImportersDT)
        ImportersDT.AcceptChanges()
        MsgBox("تم تعديل البيانات بنجاح ")
        Load_Importers()



    End Sub

   
    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try
            Dim pos As Integer = BindingContext(ImportersDT).Position
            ImporterAddress.Text = ImportersDT.Rows(pos).Item("ImporterAddress")
            ImporterBalance.Text = ImportersDT.Rows(pos).Item("ImporterBalance")
            ImporterDate.Value = ImportersDT.Rows(pos).Item("ImporterDate")
            ImporterID.Text = ImportersDT.Rows(pos).Item("ImporterID")
            ImporterName.Text = ImportersDT.Rows(pos).Item("ImporterName")
            ImporterPhone.Text = ImportersDT.Rows(pos).Item("ImporterPhone")
            ImporterTime.Value = ImportersDT.Rows(pos).Item("ImporterTime")
            ImporterType.Text = ImportersDT.Rows(pos).Item("ImporterType")
            ImporterUser.Text = ImportersDT.Rows(pos).Item("ImporterUser")



        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MsgBox(" هل تريد حذف الموضف ", MsgBoxStyle.OkCancel, "تاكيد الحذف ") Then
            Dim pos As Integer = BindingContext(ImportersDT).Position
            ImportersDT.Rows(pos).Delete()
            Dim save As New OleDbCommandBuilder(ImportersDA)
            ImportersDA.Update(ImportersDT)
            ImportersDT.AcceptChanges()
            MsgBox("تم الحذف بنجاح ")
            Load_Importers()
        Else
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ImportersDT.Clear()
        ImportersDA = New OleDbDataAdapter("select * from Importers where ImporterName like '%" & TextBox1.Text & "%'   ", con)
        ImportersDA.Fill(ImportersDT)

    End Sub

    Private Sub ImportersBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ImportersBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub ImportersBindingNavigatorSaveItem_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
End Class