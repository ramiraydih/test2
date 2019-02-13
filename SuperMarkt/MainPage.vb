Public Class MainPage

    Private Sub موظفجديدToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles موظفجديدToolStripMenuItem.Click
        Users.MdiParent = Me
        Users.WindowState = FormWindowState.Maximized
        Users.Show()

    End Sub

    Private Sub موردجديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles موردجديدToolStripMenuItem.Click
        Importer.MdiParent = Me
        Importer.Show()
        Importer.WindowState = FormWindowState.Maximized


    End Sub


    Private Sub عميلجديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles عميلجديدToolStripMenuItem.Click
        Customer.MdiParent = Me
        Customer.Show()

        Customer.WindowState = FormWindowState.Maximized





    End Sub

    Private Sub صنفجديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles صنفجديدToolStripMenuItem.Click
        Items.MdiParent = Me
        Items.Show()
        Items.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub MainPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub مجموعةجديدهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مجموعةجديدهToolStripMenuItem.Click
        ItemGroups.MdiParent = Me
        ItemGroups.Show()
        'ItemGroups.WindowState = FormWindowState.Maximized


    End Sub

    Private Sub شركةجديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles شركةجديدToolStripMenuItem.Click
        ItemCompanies.MdiParent = Me
        ItemCompanies.Show()


    End Sub

    Private Sub مكاناورفجديدToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مكاناورفجديدToolStripMenuItem.Click
        Itemplaces.MdiParent = Me
        Itemplaces.Show()

    End Sub

    Private Sub اToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اToolStripMenuItem.Click

    End Sub

    Private Sub الاToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الاToolStripMenuItem.Click
        UsersGO.MdiParent = Me
        UsersGO.Show()
        UsersGO.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub الحضورToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الحضورToolStripMenuItem.Click
        UsesCome.MdiParent = Me
        UsesCome.Show()
        UsesCome.WindowState = FormWindowState.Maximized
    End Sub
End Class