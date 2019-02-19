Imports System.Data.OleDb

Public Class UsersGO

    'Private Property hooder_EnsrafCMD As OleDb

    Private Sub UsersGO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_hooder_Ensraf()
        DataGridView1.DataSource = hooder_EnsrafdtDT
        'Users load combox
        load_Users()
        ComboBox1.DataSource = UsersDT
        ComboBox1.DisplayMember = "UserfullName"
        ComboBox1.ValueMember = "UserID"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        hooder_EnsrafdtDT.Clear()
        hooder_EnsrafdtDA = New OleDbDataAdapter("select*from Hoodorenseraf where HEDate=#" & Now.Date.ToString("yyyy/MM/dd") & "# and HEUsers = '" & ComboBox1.Text & "' ", con)
        hooder_EnsrafdtDA.Fill(hooder_EnsrafdtDT)
    End Sub
    'تسجيل وقت الانصراف 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1(5, DataGridView1.CurrentRow.Index).Value = Now

        'حساب الفرق بل ساعات بين الحضور والانصراف 
        DataGridView1(6, DataGridView1.CurrentRow.Index).Value = DateDiff(DateInterval.Minute, DataGridView1(4, DataGridView1.CurrentRow.Index).Value, DataGridView1(5, DataGridView1.CurrentRow.Index).Value) / 60
        '===================================================
        'hooder_EnsrafCMD = New OleDbCommand With
        '                   ("Update  Hoodorenseraf  SET HEDifference ="& DataGridView1(6, DataGridView1.CurrentRow.Index).Value &", HEGo='"& DataGridView1(5, DataGridView1.CurrentRow.Index).value & "',HENote='"&DataGridView1(7, DataGridView1.CurrentRow.Index).Value &"' where HEID=" DataGridView1(0, DataGridView1.CurrentRow.Index).Value"",con)

        'con.Open()
        'hooder_EnsrafCMD.ExecuteNonQuery()
        'con.Close()


    End Sub
End Class