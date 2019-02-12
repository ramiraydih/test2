Public Class Itemplaces
    Public Sub clearplaces()
        PlacesDate.Value = Now.Date
        PlacesName.Text = ""
        PlacesTime.Value = Now
        PlacesID.Text = mynewIDplace
        PlacesUser.Text = ""


    End Sub



    Private Sub PlacesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Itemplaces_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_place()
        DataGridView1.DataSource = placeDt
        clearplaces()



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        placeDt.Rows.Add()
        Dim last As Integer = placeDt.Rows.Count - 1
        placeDt.Rows(last).Item("PlacesDate") = PlacesDate.Value
        placeDt.Rows(last).Item("PlacesName") = PlacesName.Text
        placeDt.Rows(last).Item("PlacesUser") = PlacesUser.Text
        placeDt.Rows(last).Item("PlacesID") = PlacesID.Text
        placeDt.Rows(last).Item("PlacesTime") = PlacesTime.Value
        Dim SAVE As New OleDb.OleDbCommandBuilder(placeDA)
        placeDA.Update(placeDt)
        placeDt.AcceptChanges()
        load_place()
        clearplaces()




    End Sub
End Class