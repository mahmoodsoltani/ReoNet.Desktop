Public Class Frm_Services

    Private IRTCopy As Boolean = False

    Private Sub Frm_Hadese_Device_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_BaseInfo.reonet_services' table. You can move, or remove it, as needed.

        'Me.Pm_PostTableAdapter.Fill(Me.Ds_Pm.Pm_Post)
        Me.Reonet_servicesTableAdapter.Fill(Me.Ds_BaseInfo.reonet_services)
        Tree_Vw1.LoadTreeView(BaseDataObject.DataAccess, Me.Ds_BaseInfo.reonet_services, MyBase.TableName)
        UpdateTreeview()
    End Sub

    Private Sub UpdateTreeview()
        Me.Reonet_servicesTableAdapter.Fill(Me.Ds_BaseInfo.reonet_services)
        Tree_Vw1.Fill(Ds_BaseInfo.reonet_services)

    End Sub


    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click
        Dim ChangeNode As VB_Component.TreeNode

        If Tree_Vw1.TreeView1.SelectedNode Is Nothing Then
            MessageBox.Show("Select a node!")
            Return
        End If
        Dim s As New Frm_AddService(Tree_Vw1.TreeView1.SelectedNode, False)
        s.ShowDialog()
        UpdateTreeview()
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        If Tree_Vw1.TreeView1.SelectedNode Is Nothing Then
            MessageBox.Show("Select a node!")
            Return
        End If
        Dim s As New Frm_AddService(Tree_Vw1.TreeView1.SelectedNode, True)
        s.ShowDialog()
        UpdateTreeview()
    End Sub

    Private Sub Del(ByVal Srl As Integer)
        Dim ds As DataSet = BaseDataObject.DataAccess.FillDataSet("select * from reonet_services where srl_parent=" + Srl.ToString())
        If Not ds Is Nothing And ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Del(ds.Tables(0).Rows(i)("srl"))
            Next
        End If
        BaseDataObject.DataAccess.ExecQuery("delete from reonet_services where  srl_parent != 0 And srl=" + Srl.ToString())

    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If Tree_Vw1.SelectedNode Is Nothing Then
            MessageBox.Show("Select a Node!")
            Return
        End If
        If Tree_Vw1.SelectedNode.Nodes.Count > 0 Then
            If (MessageBox.Show("This service has subgroups. Deleting it will also delete all of its subgroups. Are you sure you want to continue?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
                Del(Tree_Vw1.SelectedNode.Srl)
            End If
        ElseIf (MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            BaseDataObject.DataAccess.ExecQuery("delete from reonet_services where  srl_parent != 0 And srl=" + Tree_Vw1.SelectedNode.Srl.ToString())
            MessageBox.Show("Service(s)? was successfully deleted!")
        End If
        UpdateTreeview()


    End Sub



    Function GetAddress(ByVal Srl As Integer) As String
        Return BaseDataObject.DataAccess.ExecScalar("select dbo.Fn_TraceTreeName_Down(" + Srl.ToString + ")")
    End Function

    Private Sub Tree_Vw1_SelectedChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tree_Vw1.SelectedChange

    End Sub

    Private Sub Btn_pishnahad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btn_WorkForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Btn_EibForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub







    Private Sub حذفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حذفToolStripMenuItem.Click
        btn_Delete_Click(Nothing, Nothing)
    End Sub



    Private Sub NewTajhiz(ByVal type As Integer)
        If Tree_Vw1.SelectedNode Is Nothing Then
            MessageBoxFa.Show("Select a node!")
            Return
        End If


        btn_New_Click(Nothing, Nothing)

    End Sub





    Private Sub ویرایشToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ویرایشToolStripMenuItem.Click
        btn_Edit_Click(Nothing, Nothing)
    End Sub

    Private Sub Tree_Vw1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tree_Vw1.Click

    End Sub

    Private Sub Rb_Cable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

End Class

