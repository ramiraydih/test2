Public Class Buypull
    Public Sub newpill()
        Code_Buypll()
        BuyAdd.Text = ""
        BuyCash.Text = ""
        BuyDate.Value = Now.Date
        BuyEarn.Text = ""
        BuyEarnPercent.Text = ""
        BuyID.Text = ""
        BuyImporters.Text = ""
        BuyInvoiceNO.Text = ""
        BuyItemCount.Text = ""
        BuyMinus.Text = ""
        BuyPostpone.Text = ""





    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Buypull_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'loading by bill table
        load_Buypll()

        DataGridView1.DataSource = BuypllDT
        'اخفاءتفاصيل(المورد)
        GroupBox1.Visible = False

    End Sub

    Private Sub BuyDateLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BuyInvoiceNOLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BuyImportersTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuyImporters.TextChanged
        'اخفاء واظهار تفاصيل المورد

        If BuyImporters.Text <> Nothing Then
            GroupBox1.Visible = True
        Else
            GroupBox1.Visible = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()

    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BuyTotalBLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_5(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_6(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_7(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_8(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BuypllBindingNavigatorSaveItem_Click_9(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BuyMinusLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BuyAddLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Importer_Search.ShowDialog()
    End Sub
End Class