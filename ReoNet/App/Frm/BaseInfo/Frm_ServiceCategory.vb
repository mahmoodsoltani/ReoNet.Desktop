Public Class Frm_ServiceCategory
    Private Sub Frm_Sherkatha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_BaseInfo.reonet_servicecategory' table. You can move, or remove it, as needed.
        Me.Reonet_servicecategoryTableAdapter.Fill(Me.Ds_BaseInfo.reonet_servicecategory)
        txt_Code.Value = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(MAX(CAST(Code AS int)), - 1) + 1 AS MaxSrl FROM reonet_servicecategory ")
        If txt_Code.Value = 0 Then
            txt_Code.Value = 1000
        End If

    End Sub

    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        MyBase.DataObject.DataRow("createuser") = Setting.Srl_User
        MyBase.DataObject.DataRow("createdate") = Setting.Now
        Return MyBase.Save(DoClearForm)

    End Function

    Public Overrides Sub ClearForm()
        MyBase.ClearForm()
        txt_Code.Value = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(MAX(CAST(Code AS int)), - 1) + 1 AS MaxSrl FROM reonet_servicecategory ")

    End Sub

    Public Overrides Sub LoadDataGridView()
        txt_Code.Value = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(MAX(CAST(Code AS int)), - 1) + 1 AS MaxSrl FROM reonet_servicecategory ")
        MyBase.LoadDataGridView()
        Me.Reonet_servicecategoryTableAdapter.Fill(Me.Ds_BaseInfo.reonet_servicecategory)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub


End Class