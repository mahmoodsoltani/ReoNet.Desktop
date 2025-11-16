Public Class Frm_RpVw

    Public Sub New(ByVal obj As Object, ByVal dt As DataTable)
        InitializeComponent()
        CrystalReportViewer1.ReportSource = obj
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub Frm_RpVw_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.P And e.Control Then
            'CrystalReportViewer1.btn_Print_Click(Nothing, Nothing)
        End If
    End Sub
End Class