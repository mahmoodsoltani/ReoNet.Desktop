Public Class Frm_AddService

    Dim TreeToUpdate As VB_Component.TreeNode
    Dim UpdateMode As Boolean
    Dim srl_post As Integer
    Dim ReturnTreeNode As VB_Component.TreeNode
    Public Overloads Function ShowDialog(ByVal temp As String) As VB_Component.TreeNode
        ReturnTreeNode = New VB_Component.TreeNode("")
        Me.ShowDialog()
        Return ReturnTreeNode
    End Function
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F2 Then
            btn_Save_Click(Nothing, Nothing)
        Else
            MyBase.OnKeyDown(e)
        End If
    End Sub
    Public Sub New(ByVal TreeToUpdate As VB_Component.TreeNode, ByVal UpdateMode As Boolean)
        InitializeComponent()

        Me.TreeToUpdate = TreeToUpdate
        Me.UpdateMode = UpdateMode
        Me.srl_post = srl_post
        If UpdateMode Then
            FormState = FormStates.Edit
            Dim dr_load As DataRow = BaseDataObject.DataAccess.GetRow("reonet_services", TreeToUpdate.Srl)

        End If
    End Sub

    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click

        If txt_name.Text = "" Then
            MessageBoxFa.Show("Insert Titel!")
            txt_name.Focus()
            Return
        End If
        Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("reonet_services")
        dr("Name") = txt_name.Value
        dr("price") = txt_price.Value
        dr("isactive") = chk_active.Checked
        dr("description") = txt_description.Text
        dr("code") = txt_Code.Value
        dr("srl_servicecategory") = cmb_ServiceCategory.SelectedValue
        dr("is_service") = chk_isService.Checked
        dr("srl_parent") = TreeToUpdate.Srl
        dr("srl_unit") = cmb_serviceunit.SelectedValue



        If UpdateMode Then
            dr("srl") = TreeToUpdate.Srl
            dr("Srl_Parent") = TreeToUpdate.Srl_Parent
            ReturnTreeNode = TreeToUpdate
            ReturnTreeNode.Text = txt_name.Value
            If BaseDataObject.DataAccess.Update(dr, 0) Then
                MessageBox.Show("The service was successfully edited")
            Else
                MessageBox.Show("Error in editing information")
            End If
        Else
            dr("Srl_Parent") = TreeToUpdate.Srl
            Dim Srl As Integer = BaseDataObject.DataAccess.InsertWithLastId(dr, False)

            If Not Srl = -1 Then
                MessageBox.Show("The services was successfully added")
            Else
                MessageBox.Show("Error in editing information")
            End If
        End If
        Close()
    End Sub

    Private Sub Frm_Device_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_BaseInfo.reonet_servicecategory' table. You can move, or remove it, as needed.
        Me.Reonet_servicecategoryTableAdapter.Fill(Me.Ds_BaseInfo.reonet_servicecategory)
        'TODO: This line of code loads data into the 'Ds_BaseInfo.reonet_servicetype' table. You can move, or remove it, as needed.

        Me.Reonet_servicetypeTableAdapter.Fill(Me.Ds_BaseInfo.reonet_servicetype)
        MyBase.StatusStrip1.Items.Add("F2  Save ")
        If Not UpdateMode Then
            txt_Code.Value = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(MAX(CAST(Code AS int)), - 1) + 1 AS MaxSrl FROM reonet_subservice ")
            If txt_Code.Value = 0 Then
                txt_Code.Value = 1000
            End If
        Else
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("reonet_services", TreeToUpdate.Srl)
            txt_name.Value = dr("Name")
            txt_price.Value = dr("price")
            chk_active.Checked = CBool(dr("isactive"))
            chk_isService.Checked = CBool(dr("is_service"))
            txt_description.Text = dr("description")
            txt_Code.Value = dr("code")
            cmb_serviceunit.SelectedValue = dr("srl_unit")
            cmb_ServiceCategory.SelectedValue = dr("srl_servicecategory")
        End If
    End Sub


End Class