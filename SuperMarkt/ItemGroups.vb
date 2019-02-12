Imports System.Data.OleDb

Public Class ItemGroups
    Public Sub cleargroup()
        Code_Groups()
        GroupName.Text = ""
        GroupDate.Value = Now.Date
        GroupID.Text = mynewIDGroups
        GroupTime.Value = Now
        GroupUser.Text = ""

    End Sub


    Private Sub GroupsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ItemGroups_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_Gruop()
        DataGridView1.DataSource = GroupDT
        cleargroup()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupDT.Rows.Add()
        Dim last As Integer = GroupDT.Rows.Count - 1
        GroupDT.Rows(last).Item("GroupDate") = GroupDate.Value
        GroupDT.Rows(last).Item("GroupName") = GroupName.Text
        GroupDT.Rows(last).Item("GroupTime") = GroupTime.Value
        GroupDT.Rows(last).Item("GroupUser") = GroupUser.Text
        GroupDT.Rows(last).Item("GroupID") = GroupID.Text
        Dim save As New OleDbCommandBuilder(GroupDA)
        GroupDA.Update(GroupDT)
        GroupDT.AcceptChanges()
        load_Gruop()
        cleargroup()



    End Sub
End Class