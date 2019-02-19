Public Class Importer_Search

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Importer_Search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Importers()
        DataGridView1.DataSource = ImportersDT

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub DataGridView1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.SelectionChanged
        Try
            'اضهار اسم المورد
            Buypull.BuyImporters.Text = DataGridView1(1, DataGridView1.CurrentRow.Index).Value
            'اضهار تلفون المورد 
            Buypull.Label4.Text = DataGridView1(2, DataGridView1.CurrentRow.Index).Value
            'اضهار الرصيد الحالي للمو رد 
            Buypull.Label5.Text = DataGridView1(5, DataGridView1.CurrentRow.Index).Value



        Catch ex As Exception

        End Try

    End Sub
End Class