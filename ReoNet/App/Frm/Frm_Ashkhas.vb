Public Class Frm_Ashkhas

    Public Overrides Sub LoadDataGridView()
        Try
            Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_AShkhas.Acc_Ashkhas)
            txt_Code.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
            If txt_Code.Value = 0 Then
                txt_Code.Value = 1
            End If
            MyBase.LoadDataGridView()
        Catch ex As Exception
        End Try
    End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        MyBase.DataObject.DataRow("Srl_SubmitUser") = Setting.Srl_User
        MyBase.DataObject.DataRow("SubmitDate") = Setting.Now
        Try
            Dim i As Double = CDbl(txt_weight.Value)
        Catch
            MessageBoxFa.Show("مقدار شاخص صحیح نمی باشد")
            txt_weight.Focus()
            Return False
        End Try

        'If Pic_Getter.Image Is Nothing Then
        '    MessageBoxFa.Show("لطفا عکس را انتخاب کنيد")
        '    Return False
        'End If

        If Not TextBox9.Value = "" Then
            If BaseDataObject.DataAccess.Exist("Pm_Ashkhas", "CodeMelli='" + TextBox9.Value + "' and srl!=" + DataGridView1.SelectedRows(0).Cells(0).Value.ToString()) Then
                MessageBoxFa.Show("کد ملي تکراريست!")
                TextBox9.Focus()
                Return False
            End If
            '    Else
            '    MessageBoxFa.Show("کد ملي را وارد کنيد")
            '    TextBox9.Focus()
            '    Return False
        End If
        MyBase.Save(DoClearForm)
        TextBox2.Focus()
        chb_Active.Checked = True
        Return True
    End Function

    Private Sub Frm_Ashkhas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_AshkhasType' table. You can move, or remove it, as needed.
        Me.Pm_AshkhasTypeTableAdapter.Fill(Me.Ds_Pm.Pm_AshkhasType)
        'TODO: This line of code loads data into the 'Ds_Edu.Pm_Edu_JobTitle' table. You can move, or remove it, as needed.
        Me.Pm_Edu_JobTitleTableAdapter.Fill(Me.Ds_Edu.Pm_Edu_JobTitle)
        'TODO: This line of code loads data into the 'Ds_Pm.Pm_Vahed' table. You can move, or remove it, as needed.
        Me.Pm_VahedTableAdapter.Fill(Me.Ds_Pm.Pm_Vahed)
        'TODO: This line of code loads data into the 'Ds_Ashkhas.Pm_Status' table. You can move, or remove it, as needed.
        Me.Pm_StatusTableAdapter.Fill(Me.Ds_Ashkhas.Pm_Status)
        'TODO: This line of code loads data into the 'Ds_Ashkhas.Pm_Company' table. You can move, or remove it, as needed.
        Me.Pm_CompanyTableAdapter.Fill(Me.Ds_Ashkhas.Pm_Company)
        'TODO: This line of code loads data into the 'Ds_Ashkhas.Acc_Ashkhas' table. You can move, or remove it, as needed.
        Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Acc_Ashkhas)
        'TODO: This line of code loads data into the 'Ds_Ashkhas.Pm_AshkhasNew' table. You can move, or remove it, as needed.
        Me.Pm_AshkhasNewTableAdapter.Fill(Me.Ds_Ashkhas.Pm_AshkhasNew)
        Me.Acc_AshkhasTableAdapter.Fill(Me.Ds_Ashkhas.Acc_Ashkhas)
        txt_Code.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
        txt_name.Focus()
        chb_Active.Checked = True
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Ashkhas))
        Pic_Getter.Image = CType(resources.GetObject("PictureBox1.Image"), Byte())
    End Sub

    Public Overrides Sub ClearForm()
        MyBase.ClearForm()
        txt_Code.Value = BaseDataObject.DataAccess.FirstEmptyFeild(DataGridView1, 1, 0)
        txt_name.Focus()
        Me.Pm_AshkhasNewTableAdapter.Fill(Me.Ds_Ashkhas.Pm_AshkhasNew)
    End Sub


End Class