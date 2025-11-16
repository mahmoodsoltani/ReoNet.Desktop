Public Class Frm_OrderStatus

    Dim customer_Mobile As String = ""
    Private Sub Frm_Sherkatha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_BaseInfo.reonet_servicecategory' table. You can move, or remove it, as needed.
        Me.Reonet_servicecategoryTableAdapter.Fill(Me.Ds_BaseInfo.reonet_servicecategory)
        Me.Reonet_orderstatusTableAdapter.Fill(Me.Ds_BaseInfo.reonet_orderstatus, -1)
        txt_Code.Value = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(MAX(CAST(Code AS int)), - 1) + 1 AS MaxSrl FROM reonet_orderstatus ")
        If txt_Code.Value = 0 Then
            txt_Code.Value = 1000
        End If
    End Sub
    Public Sub New()
        InitializeComponent()

    End Sub
    Public Overrides Function Save(ByVal DoClearForm As Boolean) As Boolean
        'MyBase.DataObject.DataRow("createuser") = Setting.Srl_User
        'MyBase.DataObject.DataRow("createdate") = Setting.Now
        Dim result As Boolean = MyBase.Save(DoClearForm)

        Return result
    End Function

    Public Overrides Sub ClearForm()
        MyBase.ClearForm()
        txt_Code.Value = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(MAX(CAST(Code AS int)), - 1) + 1 AS MaxSrl FROM reonet_orderstatus ")

    End Sub

    Public Overrides Sub LoadDataGridView()
        txt_Code.Value = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(MAX(CAST(Code AS int)), - 1) + 1 AS MaxSrl FROM reonet_orderstatus ")
        MyBase.LoadDataGridView()
        Me.Reonet_orderstatusTableAdapter.Fill(Me.Ds_BaseInfo.reonet_orderstatus, -1)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

End Class