Public Class frm_RoleGroup

    Private Sub frm_RoleGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.sec_Role' table. You can move, or remove it, as needed.
        Me.Sec_RoleTableAdapter.Fill(Me.DataSet1.sec_Role)
        Me.Sec_RoleTableAdapter.Fill(Me.DataSet1.sec_Role)
        Me.Sec_GroupTableAdapter.Fill(Me.DataSet1.sec_Group)
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub btn_AddGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Remove.Click
        If (DataGridView1.CurrentRow Is Nothing) Then Return
        For Each R As DataGridViewRow In DataGridView2.Rows
            If (R.Cells(1).Value = DataGridView1.CurrentRow.Cells(0).Value) Then Return
        Next
        Dim dr As DataRow = VB_Component.BaseDataObject.DataAccess.NewRow("sec_RoleGroup")
        dr("Srl_Role") = DataGridView1.CurrentRow.Cells(0).Value
        dr("Srl_Group") = ComboBox1.SelectedValue
        VB_Component.BaseDataObject.DataAccess.Insert(dr, False)
        Me.Sec_RoleGroupTableAdapter.Fill(DataSet1.sec_RoleGroup, ComboBox1.SelectedValue)
    End Sub

    Private Sub btn_Remove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AddGroup.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Sec_RoleGroupTableAdapter.Fill(DataSet1.sec_RoleGroup, CType(ComboBox1.SelectedValue, Integer))
    End Sub
End Class