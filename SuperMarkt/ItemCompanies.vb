Imports System.Data.OleDb

Public Class ItemCompanies
    Public Sub ClearCompanies()
        CompanyDate.Value = Now.Date
        CompanyTime.Value = Now
        CompanyName.Text = ""
        CompanyUser.Text = ""
        CompanyID.Text = mynewIDCompiny

    End Sub


    Private Sub CompaniesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      


    End Sub

    Private Sub ItemCompanies_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_Compinys()
        DataGridView1.DataSource = CompinyDT
        ClearCompanies()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CompinyDT.Rows.Add()
        Dim last As Integer = CompinyDT.Rows.Count - 1
        CompinyDT.Rows(last).Item("CompanyDate") = CompanyDate.Value
        CompinyDT.Rows(last).Item("CompanyName") = CompanyName.Text
        CompinyDT.Rows(last).Item("CompanyID") = CompanyID.Text
        CompinyDT.Rows(last).Item("CompanyUser") = CompanyUser.Text
        CompinyDT.Rows(last).Item("CompanyTime") = CompanyTime.Value
        Dim save As New OleDbCommandBuilder(CompinyDA)
        CompinyDA.Update(CompinyDT)
        CompinyDT.AcceptChanges()
        load_Compinys()
        ClearCompanies()





    End Sub

    Private Sub CompanyName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyName.TextChanged

    End Sub
End Class