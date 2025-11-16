Public Class Frm_Customer

    Dim customer_Mobile As String = ""
    Private Sub Frm_Sherkatha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_BaseInfo.reonet_customer' table. You can move, or remove it, as needed.
        Me.Reonet_customerTableAdapter.Fill(Me.Ds_BaseInfo.reonet_customer)
        'TODO: This line of code loads data into the 'Ds_BaseInfo.reonet_city' table. You can move, or remove it, as needed.
        Me.Reonet_cityTableAdapter.Fill(Me.Ds_BaseInfo.reonet_city)
        'TODO: This line of code loads data into the 'Ds_BaseInfo.reonet_gender' table. You can move, or remove it, as needed.
        Me.Reonet_genderTableAdapter.Fill(Me.Ds_BaseInfo.reonet_gender)
        txt_Code.Value = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(MAX(CAST(Code AS int)), - 1) + 1 AS MaxSrl FROM reonet_customer ")
        If txt_Code.Value = 0 Then
            txt_Code.Value = 1000
        End If
        If customer_Mobile <> "" Then
            txt_Mobile.Text = customer_Mobile
        End If
        txt_postcode.Text = ""
    End Sub
    Public Sub New()
        InitializeComponent()

    End Sub
    Public Sub New(ByVal customer_Mobile As String)
        InitializeComponent()
        If customer_Mobile <> "" Then
            Me.customer_Mobile = customer_Mobile
        End If
    End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        MyBase.DataObject.DataRow("createuser") = Setting.Srl_User
        MyBase.DataObject.DataRow("createdate") = Setting.Now
        Dim result As Boolean = MyBase.Save(DoClearForm)
        If customer_Mobile <> "" Then
            Me.Close()
        End If
        ' Me.Reonet_customerTableAdapter.Fill(Me.Ds_BaseInfo.reonet_customer)
        Return result
    End Function

    Public Overrides Sub ClearForm()
        MyBase.ClearForm()
        txt_Code.Value = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(MAX(CAST(Code AS int)), - 1) + 1 AS MaxSrl FROM reonet_customer ")

    End Sub

    Public Overrides Sub LoadDataGridView()
        txt_Code.Value = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(MAX(CAST(Code AS int)), - 1) + 1 AS MaxSrl FROM reonet_customer ")
        MyBase.LoadDataGridView()
        Me.Reonet_customerTableAdapter.Fill(Me.Ds_BaseInfo.reonet_customer)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label3.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged, TextBox6.TextChanged, TextBox7.TextChanged

    End Sub

    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles txt_postcode.Leave
        'Try
        '    Dim srl As String = BaseDataObject.DataAccess.ExecScalar("select srl_city from reonet_postcode where code = '" + txt_postcode.Text.Trim() + "' ").ToString()
        '    If Not (srl Is Nothing) And srl <> "" Then
        '        cmb_city.SelectedValue = Convert.ToInt32(srl)
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Incorert Post code")
        '    txt_postcode.Focus()

        'End Try

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_isCompany.CheckedChanged
        pl_Company.Visible = chk_isCompany.Checked
        If Not chk_isCompany.Checked Then
            txt_companyname.Text = ""
            txt_commission.Text = ""
        End If
    End Sub
End Class