Public Class Frm_ServiceSelect

    Private IRTCopy As Boolean = False

    Public srl_service As Integer
    Public service_title As String

    Private Sub Frm_Hadese_Device_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Reonet_servicesTableAdapter.Fill(Me.Ds_BaseInfo.reonet_services)
        Tree_Vw1.LoadTreeView(BaseDataObject.DataAccess, Me.Ds_BaseInfo.reonet_services, MyBase.TableName)
        UpdateTreeview()
    End Sub

    Private Sub UpdateTreeview()
        Me.Reonet_servicesTableAdapter.Fill(Me.Ds_BaseInfo.reonet_services)
        Tree_Vw1.Fill(Ds_BaseInfo.reonet_services)
        Tree_Vw1.TreeView1.CollapseAll()
        For Each rootNode As VB_Component.TreeNode In Tree_Vw1.TreeView1.Nodes
            rootNode.Expand()
        Next
    End Sub


    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click

        If Tree_Vw1.TreeView1.SelectedNode Is Nothing Then
            MessageBox.Show("Select a node!")
            Return
        End If
        Me.srl_service = Tree_Vw1.SelectedNode.Srl
        Me.service_title = Tree_Vw1.SelectedNode.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub Tree_Vw1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Tree_Vw1.MouseDoubleClick
        If Tree_Vw1.TreeView1.SelectedNode Is Nothing Then
            MessageBox.Show("Select a node!")
            Return
        End If
        Me.srl_service = Tree_Vw1.SelectedNode.Srl
        Me.service_title = Tree_Vw1.SelectedNode.Text
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
End Class

