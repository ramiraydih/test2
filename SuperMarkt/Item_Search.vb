Imports System.Data.OleDb

Public Class Item_Search

    Public Sub Buycalculations()
        Try
            Dim item As String
            Dim qty, disCound, Price, unitPrice, total, totalB, earn As Double
            item = DataGridView1(2, DataGridView1.CurrentRow.Index).Value
            qty = Val(qtyin.Text)
            disCound = Val(disCoundin.Text) / 100
            Price = DataGridView1(6, DataGridView1.CurrentRow.Index).Value
            '=============================================================================
            'حساب اجمالي الجمهور 
            total = qty * Price
            'حساب اجمالي الشراء 
            totalB = total - (total * disCound)
            'حساب سعر الشراء 
            unitPrice = totalB / qty
            'حساب الربح الموتوقع 
            earn = total - totalB
            '-------------------------------------------------------------------------------
            Label8.Text = total
            Label9.Text = totalB
            Label11.Text = unitPrice
            Label1.Text = earn


        Catch ex As Exception

        End Try
      











    End Sub

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
        '======================================
        RadioButton3.Checked = True
        '===========================================
        Buycalculations()





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
        If qtyin.Text = 0 Then
            MsgBox("ادخل الكمية المناسبه رجاء ")
            qtyin.Focus()
        ElseIf disCoundin.Text = 0 Then
            MsgBox("ادخل الخصم المناسب رجاء")
            disCoundin.Focus()
        ElseIf exp.Value = Now.Date Then
            MsgBox("ادحل  تاريخ صلاحية اكبر من صلاحية اليوم ")
            exp.Focus()

        Else
            Dim itemname As String = DataGridView1(2, DataGridView1.CurrentRow.Index).Value
            Dim dt As New DataTable
            Dim cmd As New OleDbCommand
            dt.Clear()
            cmd = New OleDbCommand("insert into Operations (BuyID,OperItem,BuyQyt,BuyDiscound,BuyNotes,operItemExp,BuyTotalG,BuyTotalB,BuyUnitPrice,BuyEarn) values (" & Buypull.BuyID.Text & ",'" & itemname & "'," & qtyin.Text & "," & disCoundin.Text & ",'" & note.Text & "',#" & exp.Value & "#," & Val(Label8.Text) & "," & Val(Label9.Text) & "," & Val(Label11.Text) & "," & Val(Label1.Text) & ")", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Buypull.loadbuyQ()
            newitem()
        End If

    End Sub

    Private Sub qtyin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qtyin.TextChanged
        Buycalculations()

    End Sub

    Private Sub disCoundin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disCoundin.TextChanged
        Buycalculations()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Buycalculations()
    End Sub
End Class
