Public Class Frm_ChangeStatus

    Dim srl_customer As Integer = -1
    Private Sub Frm_ChangeStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_BaseInfo.reonet_servicecategory' table. You can move, or remove it, as needed.
        Me.Reonet_servicecategoryTableAdapter.Fill(Me.Ds_BaseInfo.reonet_servicecategory)
        Me.Reonet_orderstatusTableAdapter.Fill(Me.Ds_BaseInfo.reonet_orderstatus, cmb_ServiceCategory.SelectedValue)
        txt_Start.Value = New Date(Now.Year, Now.Month, 1)

        UpdateDatagridData()
    End Sub
    Private Sub UpdateDatagridData()
        If cmb_ServiceCategory.SelectedValue Is Nothing Then

            Return
        End If


        Dim StartDate As String = PublicFunction.FormatDateToStandard(txt_Start.Text)
        Dim EndDate As String = PublicFunction.FormatDateToStandard(txt_End.Text)

        Dim iscash As Integer = -1
        Dim iscompany As Integer = -1
        Dim srl_serviceCategory As Integer = -1
        srl_serviceCategory = cmb_ServiceCategory.SelectedValue

        Dim srl_orderStatus As Integer = -1
        srl_orderStatus = cmb_Status.SelectedValue
        Me.Reonet_OrderDetailVwTableAdapter.Fill(Me.Ds_Order.Reonet_OrderDetailVw, -1, -1, StartDate, EndDate, srl_customer, iscompany, iscash, srl_serviceCategory, srl_orderStatus)

    End Sub
    Private Sub cmb_ServiceCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ServiceCategory.SelectedIndexChanged
        Me.Reonet_orderstatusTableAdapter.Fill(Me.Ds_BaseInfo.reonet_orderstatus, cmb_ServiceCategory.SelectedValue)
    End Sub
    Private Sub txt_customerCode_Leave(sender As Object, e As EventArgs) Handles txt_customerCode.Leave
        Try
            If txt_customerCode.Value > 0 Then
                Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("reonet_customer", "code =  " + txt_customerCode.Value.ToString())
                If Not dr Is Nothing Then
                    lbl_customerName.Text = IIf(dr("is_company"), dr("Companyname"), dr("name") + " " + dr("family"))
                    srl_customer = CInt(dr("Srl"))
                    txt_CustomerMobile.Text = dr("tell1")
                    PictureBox1.Focus()
                Else
                    MessageBox.Show("No customer was found.")
                    txt_CustomerMobile.Text = ""
                    txt_CustomerMobile.Focus()
                End If

            Else
                srl_customer = -1
                txt_CustomerMobile.Text = ""
                lbl_customerName.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_CustomerMobile_Leave(sender As Object, e As EventArgs) Handles txt_CustomerMobile.Leave
        Try
            If txt_CustomerMobile.Text.Trim() <> "" Then
                Dim dr As DataRow = PublicFunction.SearchByTell(txt_CustomerMobile.Text)
                If Not dr Is Nothing Then
                    lbl_customerName.Text = IIf(dr("is_company"), dr("Companyname"), dr("name") + " " + dr("family"))
                    srl_customer = CInt(dr("Srl"))
                    txt_customerCode.Text = dr("code")
                    PictureBox1.Focus()
                Else
                    MessageBox.Show("No customer was found.")
                    txt_CustomerMobile.Text = ""
                    txt_CustomerMobile.Focus()
                End If
            Else
                srl_customer = -1
                txt_customerCode.Text = ""
                lbl_customerName.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Status.SelectedIndexChanged
        UpdateDatagridData()
    End Sub
    Private Sub btn_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_new.Click

    End Sub

    Private Sub cmb_Changestatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Changestatus.SelectedIndexChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If cmb_Changestatus.SelectedValue = cmb_Status.SelectedValue Then
            Exit Sub
        End If

        ' بررسی اینکه حداقل یک ردیف انتخاب شده باشه
        If DataGridView1.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select atleast one row.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim ids As New List(Of Integer)
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            If Not row.IsNewRow Then
                ids.Add(Convert.ToInt32(row.Cells(0).Value))
            End If
        Next

        If ids.Count = 0 Then Exit Sub
        BaseDataObject.DataAccess.ExecQuery("Update reonet_orderdetail set srl_orderstatus = " + cmb_Changestatus.SelectedValue.ToString() + " where srl in (" + String.Join(",", ids) + ")")
        UpdateDatagridData()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        UpdateDatagridData()
    End Sub
End Class