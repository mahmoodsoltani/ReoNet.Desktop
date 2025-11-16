Public Class frm_Group

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        DataObject.DataRow("UsersBlocked") = CheckBox1.Checked
        DataObject.DataRow("JoinBlocked") = CheckBox2.Checked
        Return MyBase.Save(DoClearForm)
    End Function

    Public Overrides Function Edit() As Boolean
        Dim bol_Result = MyBase.Edit
        CheckBox1.Checked = DataObject.DataRow("UsersBlocked")
        CheckBox2.Checked = DataObject.DataRow("JoinBlocked")
        Return bol_Result
    End Function

    Public Overrides Sub LoadDataGridView()
        Me.Sec_GroupTableAdapter.Fill(Me.DataSet1.sec_Group)
        MyBase.LoadDataGridView()
    End Sub

    Public Overrides Sub ClearForm()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        MyBase.ClearForm()
    End Sub

    Private Sub frm_Group_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.sec_Group' table. You can move, or remove it, as needed.
        Me.Sec_GroupTableAdapter.Fill(Me.DataSet1.sec_Group)
        'TODO: This line of code loads data into the 'DataSet1.sec_Group' table. You can move, or remove it, as needed.
        Me.Sec_GroupTableAdapter.Fill(Me.DataSet1.sec_Group)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class