Imports System.Data.OleDb

Public Class UsesCome
    Public Sub newtime()
        Code_hooder_Ensraf()
        HEDate.Value = Now.Date
        HEID.Text = mynewIDhooder_Ensraf
        HETime.Value = Now
        HECome.Text = ""
        HENote.Text = ""
        HEUser.Text = ""
        HEUsers.Text = ""


    End Sub

    Private Sub HoodorenserafBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub UsesCome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_Users()
        HEUsers.DataSource = UsersDT
        HEUsers.DisplayMember = "UserfullName"
        HEUsers.ValueMember = "UserID"
        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        load_hooder_Ensraf()
        DataGridView1.DataSource = hooder_EnsrafdtDT

        newtime()
    End Sub

    Private Sub HoodorenserafBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        HECome.Text = Now
        hooder_EnsrafdtDT.Rows.Add()
        Dim last As Integer = hooder_EnsrafdtDT.Rows.Count - 1
        hooder_EnsrafdtDT.Rows(last).Item("HEDate") = HEDate.Value
        hooder_EnsrafdtDT.Rows(last).Item("HECome") = HECome.Text
        hooder_EnsrafdtDT.Rows(last).Item("HEID") = HEID.Text
        hooder_EnsrafdtDT.Rows(last).Item("HENote") = HENote.Text
        hooder_EnsrafdtDT.Rows(last).Item("HEUser") = HEUser.Text
        hooder_EnsrafdtDT.Rows(last).Item("HEUsers") = HEUsers.Text
        hooder_EnsrafdtDT.Rows(last).Item("HETime") = HETime.Value
        Dim save As New OleDbCommandBuilder(hooder_EnsrafdtDA)
        hooder_EnsrafdtDA.Update(hooder_EnsrafdtDT)
        hooder_EnsrafdtDT.AcceptChanges()
        MsgBox("تم تسجيل الحضور للموظف" & HEUsers.Text)
        load_hooder_Ensraf()
        newtime()



    End Sub
End Class