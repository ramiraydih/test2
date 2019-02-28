Imports System.Data.OleDb

Public Class Item_Search



    Public Sub newitem()

        qtyin.Text = 0
        disCoundin.Text = 0
        exp.Value = Now.Date
        note.Text = Nothing




    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Item_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Items()
        DataGridView1.DataSource = ItemsDT
        newitem()
        'focusing on search text 
        TextBox1.Text = Nothing
        TextBox1.Focus()



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If RadioButton1.Checked = True Then
            Try
                If TextBox1.Text <> Nothing Then
                    ItemsDT.Clear()
                    ItemsDA = New OleDbDataAdapter("Select* from Items where ItemID = " & TextBox1.Text & "", con)
                    ItemsDA.Fill(ItemsDT)
                Else
                    Load_Items()

                End If

            Catch ex As Exception

            End Try
        End If


        If RadioButton2.Checked = True Then
            Try
                If TextBox1.Text <> Nothing Then
                    ItemsDT.Clear()
                    ItemsDA = New OleDbDataAdapter("Select* from Items where ItemBarcode = '" & TextBox1.Text & "'", con)
                    ItemsDA.Fill(ItemsDT)
                Else
                    Load_Items()

                End If

            Catch ex As Exception

            End Try
        End If



        If RadioButton3.Checked = True Then
            Try
                If TextBox1.Text <> Nothing Then
                    ItemsDT.Clear()
                    ItemsDA = New OleDbDataAdapter("Select* from Items where ItemName like '%" & TextBox1.Text & "%'", con)
                    ItemsDA.Fill(ItemsDT)
                Else
                    Load_Items()

                End If

            Catch ex As Exception

            End Try
        End If





        'ItemsDT.Clear()
        'ItemsDA = New OleDbDataAdapter("Select* from Items where ItemName like '%" & TextBox1.Text & "%' or ItemBarcode = '" & TextBox1.Text & "' or ItemID = " & TextBox1.Text & "", con)
        'ItemsDA.Fill(ItemsDT)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim itemname As String = DataGridView1(2, DataGridView1.CurrentRow.Index).Value
        Dim dt As New DataTable
        Dim cmd As New OleDbCommand
        dt.Clear()
        cmd = New OleDbCommand("insert into Operations (BuyID,OperItem,BuyQyt,BuyDiscound,BuyNotes,operItemExp) values (" & Buypull.BuyID.Text & ",'" & itemname & "'," & qtyin.Text & "," & disCoundin.Text & ",'" & note.Text & "',#" & exp.Value & "#)", con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        Buypull.loadbuyQ()



        newitem()
    End Sub
End Class
