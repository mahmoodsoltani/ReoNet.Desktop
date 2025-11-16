Public Class Frm_MonthlyReport
    Dim Srl_Pm_Tajhiz_ForSave As Integer = -1
    Private Sub Frm_RpEibForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_BaseInfo.reonet_servicecategory' table. You can move, or remove it, as needed.
        Me.Reonet_servicecategoryTableAdapter.Fill(Me.Ds_BaseInfo.reonet_servicecategory)
        Me.Reonet_companyTableAdapter.Fill(Me.Ds_BaseInfo.reonet_company)
        Dim firstDayOfMonth As Date = New Date(Now.Year, Now.Month, 1)
        txt_FromDate.Value = firstDayOfMonth
    End Sub




    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        If txt_FromDate.Text > txt_ToDate.Text Then
            MessageBox.Show("The start date should be before the end date.")
            txt_FromDate.Focus()
            Return
        End If
        Dim Srl_Company As Integer = -1
        Dim Srl_ServiceCategory As Integer = -1
        Dim Is_Cash As Integer = -1
        If rb_cash.Checked Then
            Is_Cash = 1
        ElseIf rb_invoice.Checked Then
            Is_Cash = 0
        End If
        If Not chk_AllCompany.Checked Then
            Srl_Company = cmb_Company.SelectedValue
        End If
        If Not chk_AllService.Checked Then
            Srl_ServiceCategory = cmb_Service.SelectedValue
        End If
        Me.OrderDetilTableAdapter.Fill(Me.Ds_Order.OrderDetil, -1, -1, txt_FromDate.Text, txt_ToDate.Text, Srl_Company, Is_Cash, Srl_ServiceCategory)

        Dim rp As New Rp_MonthlyReport

        Dim dt As DataTable = Ds_Order.OrderDetil
        rp.SetDataSource(dt)
        rp.SetParameterValue("FromDate", txt_FromDate.Text)
        rp.SetParameterValue("ToDate", txt_ToDate.Text)
        rp.SetParameterValue("ToDate", txt_ToDate.Text)
        Dim frm_rp As New Frm_RpVw(rp, dt)
        frm_rp.ShowDialog()
        ''rp.SetParameterValue(rp.Parameter_Vahed.ParameterFieldName, IIf(Vahed = -1, "-", cmb_Vahed.Text))
        ''rp.SetParameterValue(rp.Parameter_Group.ParameterFieldName, IIf(Group = -1, "-", cmb_Group.Text))
        ''If Post.Split(",").Length <> 2 Then
        ''    rp.SetParameterValue(rp.Parameter_Post.ParameterFieldName, "-")
        ''Else
        ''    rp.SetParameterValue(rp.Parameter_Post.ParameterFieldName, DGV_Post.Rows(0).Cells(1).Value)
        ''End If
        ''If EibType.Split(",").Length <> 2 Then
        ''    rp.SetParameterValue(rp.Parameter_EibType.ParameterFieldName, "-")
        ''Else
        ''    rp.SetParameterValue(rp.Parameter_EibType.ParameterFieldName, DGV_EibType.Rows(0).Cells(1).Value)
        ''End If
        ''Dim Fixed As Integer
        ''Dim All As Integer

        'Distinctcount(dt, Fixed, All)
        'Dim frm_rp As New Frm_RpVw(rp, dt)
        'rp.SetParameterValue(rp.Parameter_Fiexed.ParameterFieldName, Fixed)
        'rp.SetParameterValue(rp.Parameter_All.ParameterFieldName, All)
        'rp.SetParameterValue(rp.Parameter_NotFixed.ParameterFieldName, All - Fixed)
        'If t.IsAlive Then
        '    t.Abort()
        'End If
        'frm_rp.ShowDialog()

    End Sub
    Private Sub IsExpire(ByRef dt As DataTable)
        Dim FixDate As String = ""
        Dim RegDate As String = ""
        Dim Fixed As FarsiDateFun
        Dim Reged As FarsiDateFun



        Dim dif As Integer
        For Each dr As DataRow In dt.Rows
            'If Not dr(7) Is DBNull.Value Then
            '    enddate = dr(7).ToString()
            'Else
            '    Continue For
            'End If
            If Not dr(9) Is DBNull.Value Then
                FixDate = dr(9).ToString()
            End If
            If Not dr(7) Is DBNull.Value Then
                RegDate = dr(7).ToString()
            Else
                Continue For
            End If
            If Not FixDate Is DBNull.Value Then
                If FixDate <> "" Then
                    Fixed = New FarsiDateFun(FixDate.Substring(0, 4), FixDate.Substring(5, 2), FixDate.Substring(8))
                Else
                    Fixed = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))
                End If
            Else
                Fixed = New FarsiDateFun(Setting.TarikheJary.Substring(0, 4), Setting.TarikheJary.Substring(5, 2), Setting.TarikheJary.Substring(8))
            End If
            Reged = New FarsiDateFun(RegDate.Substring(0, 4), RegDate.Substring(5, 2), RegDate.Substring(8))
            dif = DateDiff(DateInterval.Day, VB_Component.FarsiDateFun.F2E(Reged), VB_Component.FarsiDateFun.F2E(Fixed))
            If Not dr(20) Is DBNull.Value Then
                If Not dr(20).ToString() = "" And dr(7) <> "" Then
                    'dr(19) = dr(19).ToString() + "*" + (dif - dr(20)).ToString()
                    'If dif > dr(20).ToString() Then
                    dr(20) = dr(20).ToString() - dif
                    'Else
                    '  dr(20) = 0
                    ' End If
                Else
                    dr(20) = 0
                End If


            End If
        Next
    End Sub
    Private Sub Distinctcount(ByVal dt As DataTable, ByRef Fixed As Integer, ByRef All As Integer)
        Dim Allarray As New ArrayList()
        Fixed = 0
        For Each dr As DataRow In dt.Rows
            If Not Allarray.Contains(dr(0)) Then
                Allarray.Add(dr(0))
                If Not dr(21) Is DBNull.Value Then
                    If (dr(9).ToString() <> "" And Not dr(9) Is DBNull.Value) Or dr(21) = 1 Then
                        Fixed = Fixed + 1
                    End If
                Else
                    If (dr(9).ToString() <> "" And Not dr(9) Is DBNull.Value) Then
                        Fixed = Fixed + 1
                    End If
                End If

            End If

        Next
        All = Allarray.Count
    End Sub

    Private Sub chk_AllPost_CheckedChanged(sender As Object, e As EventArgs)
        cmb_Company.Enabled = Not chk_AllCompany.Checked
    End Sub

    Private Sub chk_AllCompany_CheckedChanged(sender As Object, e As EventArgs) Handles chk_AllCompany.CheckedChanged
        cmb_Company.Enabled = Not chk_AllCompany.Checked

    End Sub

    Private Sub chk_AllService_CheckedChanged(sender As Object, e As EventArgs) Handles chk_AllService.CheckedChanged
        cmb_Service.Enabled = Not chk_AllService.Checked

    End Sub
End Class