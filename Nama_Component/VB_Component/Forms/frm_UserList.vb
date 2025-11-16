Public Class frm_UserList
    Public Overrides Sub LoadDataGridView()
        MyBase.LoadDataGridView()
        Me.Sec_UserTableAdapter.Fill(Me.DataSet1.sec_User)
    End Sub

    Private Sub frm_UserList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.sec_User' table. You can move, or remove it, as needed.
        Me.Sec_UserTableAdapter.Fill(Me.DataSet1.sec_User)
        Me.InfoForm = New frm_User()
    End Sub
    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click

        Me.Sec_UserTableAdapter.Fill(Me.DataSet1.sec_User)

    End Sub
    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click

        Me.Sec_UserTableAdapter.Fill(Me.DataSet1.sec_User)

    End Sub
    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click

        Me.Sec_UserTableAdapter.Fill(Me.DataSet1.sec_User)

    End Sub
End Class