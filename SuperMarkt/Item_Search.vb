Imports System.Data.OleDb

Public Class Item_Search

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Item_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Items()
        DataGridView1.DataSource = ItemsDT

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If RadioButton1.Checked = True Then
            Try
                If TextBox1.Text <> Nothing Then

                End If
            End Try
            ItemsDT.Clear()
            ItemsDA = New OleDbDataAdapter("Select* from Items where ItemID = " & TextBox1.Text & "", con)
            ItemsDA.Fill(ItemsDT)
        Else
            Load_Items()


        End If
            Catch ex As Exception

            End Try
            
       

        ItemsDT.Clear()
        ItemsDA = New OleDbDataAdapter("Select* from Items where ItemName like '%" & TextBox1.Text & "%' or ItemBarcode = '" & TextBox1.Text & "' or ItemID = " & TextBox1.Text & "", con)
        ItemsDA.Fill(ItemsDT)



    End Sub
End Class
