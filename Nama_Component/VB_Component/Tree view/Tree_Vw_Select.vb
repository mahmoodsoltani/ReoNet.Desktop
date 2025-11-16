Public Class Tree_Vw_Select
    Public Result As TreeNode

    Public Sub New(ByVal dataTable As DataTable)
        InitializeComponent()
        Me.Tree_Vw1.Fill(dataTable)
        Tree_Vw1.TreeView1.CollapseAll()
        For Each rootNode As VB_Component.TreeNode In Tree_Vw1.TreeView1.Nodes
            rootNode.Expand()
        Next
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        If Tree_Vw1.SelectedNode Is Nothing Then
            MessageBoxFa.Show("Select a service ")
            Return
        Else
            If Not CBool(BaseDataObject.DataAccess.ExecScalar("select isnull(is_service,0) from reonet_Services where srl = " + Tree_Vw1.SelectedNode.Srl.ToString())) Then
                MessageBox.Show("You cannot select this item!")
                Return
            End If
            Me.Result = Tree_Vw1.SelectedNode
        End If
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btn_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancel.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub Tree_Vw_Select_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_Save_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Tree_Vw_Select_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class