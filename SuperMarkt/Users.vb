Imports System.Data.OleDb

Public Class Users
    Public Sub newuser()
        code_Users()
        
        UserAddress.Text = ""
        UserDate.Value = Now.Date
        UserTime.Value = Now
        UserForProgramm.Checked = False
        UserfullName.Text = ""
        UserJob.Text = ""
        UserGender.Text = ""
        UserJob.Text = ""
        UserID.Text = mynewIDUsers
        UserPhone.Text = ""
        UserName.Text = ""
        UserPassword.Text = ""
        UserUser.Text = ""

    End Sub

    Private Sub Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GroupBox2.Visible = False
        load_Users()
        DataGridView1.DataSource = UsersDT
        code_Users()
        UserID.Text = mynewIDUsers

        newuser()


    End Sub



    Private Sub UserForProgrammCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserForProgramm.CheckedChanged
        If UserForProgramm.Checked = True Then
            GroupBox2.Visible = True
        Else
            GroupBox2.Visible = False



        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        UsersDT.Rows.Add()
        Dim last As Integer = UsersDT.Rows.Count - 1

        UsersDT.Rows(last).Item("UserAddress") = UserAddress.Text
        UsersDT.Rows(last).Item("UserForProgramm") = UserForProgramm.Checked
        UsersDT.Rows(last).Item("UserfullName") = UserfullName.Text
        UsersDT.Rows(last).Item("UserGender") = UserGender.Text
        UsersDT.Rows(last).Item("UserID") = UserID.Text
        UsersDT.Rows(last).Item("UserJob") = UserJob.Text
        UsersDT.Rows(last).Item("UserName") = UserName.Text
        UsersDT.Rows(last).Item("UserPassword") = UserPassword.Text
        UsersDT.Rows(last).Item("UserPhone") = UserPhone.Text
        UsersDT.Rows(last).Item("UserUser") = UserUser.Text
        UsersDT.Rows(last).Item("UserTime") = UserTime.Value
        UsersDT.Rows(last).Item("UserDate") = UserDate.Value
        Dim save As New OleDbCommandBuilder(UsersDA)
        UsersDA.Update(UsersDT)
        UsersDT.AcceptChanges()
        MsgBox("تم حفظ البيانات بنجاح ")
        load_Users()
        newuser()







    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    'Private Function UserTime() As Object
    '    Throw New NotImplementedException
    'End Function

    'Private Function UserDate() As Object
    '    Throw New NotImplementedException
    'End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        newuser()
    End Sub

   

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged

        Try
            Dim pos As Integer = BindingContext(UsersDT).Position
            UserAddress.Text = UsersDT.Rows(pos).Item("UserAddress")
            UserDate.Value = UsersDT.Rows(pos).Item("UserDate")
            UserForProgramm.Checked = UsersDT.Rows(pos).Item("UserForProgramm")
            UserfullName.Text = UsersDT.Rows(pos).Item("UserfullName")
            UserGender.Text = UsersDT.Rows(pos).Item("UserGender")
            UserID.Text = UsersDT.Rows(pos).Item("UserID")
            UserJob.Text = UsersDT.Rows(pos).Item("UserJob")
            UserName.Text = UsersDT.Rows(pos).Item("UserName")
            UserPassword.Text = UsersDT.Rows(pos).Item("UserPassword")
            UserPhone.Text = UsersDT.Rows(pos).Item("UserPhone")
            UserTime.Value = UsersDT.Rows(pos).Item("UserTime")
            UserUser.Text = UsersDT.Rows(pos).Item("UserUser")



        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pos As Integer = BindingContext(UsersDT).Position
        UsersDT.Rows(pos).Item("UserAddress") = UserAddress.Text
        UsersDT.Rows(pos).Item("UserForProgramm") = UserForProgramm.Checked
        UsersDT.Rows(pos).Item("UserfullName") = UserfullName.Text
        UsersDT.Rows(pos).Item("UserGender") = UserGender.Text
        UsersDT.Rows(pos).Item("UserID") = UserID.Text
        UsersDT.Rows(pos).Item("UserJob") = UserJob.Text
        UsersDT.Rows(pos).Item("UserName") = UserName.Text
        UsersDT.Rows(pos).Item("UserPassword") = UserPassword.Text
        UsersDT.Rows(pos).Item("UserPhone") = UserPhone.Text
        UsersDT.Rows(pos).Item("UserUser") = UserUser.Text
        UsersDT.Rows(pos).Item("UserTime") = UserTime.Value
        UsersDT.Rows(pos).Item("UserDate") = UserDate.Value
        Dim save As New OleDbCommandBuilder(UsersDA)
        UsersDA.Update(UsersDT)
        UsersDT.AcceptChanges()
        MsgBox("تم تعديل البانات بنجاح  ")
        load_Users()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If MsgBox(" هل تريد حذف الموضف ", MsgBoxStyle.OkCancel, "تاكيد الحذف ") Then
            Dim pos As Integer = BindingContext(UsersDT).Position
            UsersDT.Rows(pos).Delete()
            Dim save As New OleDbCommandBuilder(UsersDA)
            UsersDA.Update(UsersDT)
            UsersDT.AcceptChanges()
            MsgBox("تم الحذف بنجاح ")
            load_Users()
        Else
        End If
       


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        UsersDT.Clear()
        UsersDA = New OleDbDataAdapter("select*from Users where UserfullName like '%" & TextBox1.Text & "%' ", con)



        UsersDA.Fill(UsersDT)
    End Sub
End Class