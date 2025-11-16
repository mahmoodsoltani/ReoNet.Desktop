Imports ZXing
Imports ZXing.Common
Imports ZXing.Rendering
Imports System.Drawing.Imaging
Public Class Frm_OrderVw

    Private srl_customer As Integer
    Private StartDate As String
    Private EndDate As String


    Public Sub New()
        InitializeComponent()
        srl_customer = -1
        StartDate = "-1"
        EndDate = "-1"
        CheckBox1.Checked = True
        'Me.WorkForm_MasterTableAdapter.FillByPost(Me.Ds_Pm.WorkForm_Master, Srl_Post)
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        Dim s As New Frm_Order(-1)
        s.ShowDialog()
        'Me.WorkForm_MasterTableAdapter.Fill(Me.Ds_Pm.WorkForm_Master)
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        If srl = -1 Then
            Return
        End If
        Dim s As New Frm_Order(srl)
        s.ShowDialog()
        UpdateDataGidView()

    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If MessageBox.Show("Are you sure?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then
            Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
            If srl = -1 Then
                Return
            End If
            If BaseDataObject.DataAccess.BeginTransaction() Then
                BaseDataObject.DataAccess.Delete("reonet_orderdetail", " srl_ordermaster=" + srl.ToString())
                BaseDataObject.DataAccess.Delete("reonet_ordermaster", srl)

                If BaseDataObject.DataAccess.Commit() Then
                    MessageBox.Show("Order was succesfully deleted")
                    UpdateDataGidView()
                    Return
                End If
            End If
            MessageBox.Show("Failed to delete data!")
            Return
        End If
    End Sub

    Private Sub Frm_WorkFormVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_BaseInfo.reonet_servicecategory' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Ds_Pm.WorkForm_Master' table. You can move, or remove it, as needed.
        'Me.WorkForm_MasterTableAdapter.Fill(Me.Ds_Pm.WorkForm_Master)
        Dim firstDayOfMonth As Date = New Date(Now.Year, Now.Month, 1)

        txt_Start.Value = firstDayOfMonth
        UpdateDataGidView()
        CheckBox1.Checked = True


    End Sub
    Private Sub UpdateDataGidView()
        StartDate = PublicFunction.FormatDateToStandard(txt_Start.Text)
        EndDate = PublicFunction.FormatDateToStandard(txt_End.Text)
        If CheckBox1.Checked Then
            Me.Reonet_ordermasterTableAdapter.Fill(Me.Ds_Order.reonet_ordermaster, StartDate, EndDate, srl_customer)
        Else
            Me.Reonet_ordermasterTableAdapter.Fill(Me.Ds_Order.reonet_ordermaster, "-1", "-1", -1)

        End If

    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, CS_Component.DataGridView)
            Dim srl_order As Integer = -1
            srl_order = DirectCast(senderGrid.Rows(e.RowIndex).Cells(0).Value, Integer)
            If srl_order < 1 Then
                Return
            End If
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                If e.ColumnIndex = 9 Then
                    Dim frm As New Frm_Order(srl_order)
                    frm.ShowDialog()
                ElseIf e.ColumnIndex = 10 Then
                    btn_Delete_Click(Nothing, Nothing)
                ElseIf e.ColumnIndex = 11 Then
                    printOrder(srl_order)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub printOrder(srl_order As Integer)
        Me.OrderDetilTableAdapter.Fill(Me.Ds_Order.OrderDetil, srl_order, -1, "-1", "-1", -1, -1, -1)
        Dim rp As New Rp_CarpetPrint
        Dim dt As DataTable = Me.Ds_Order.OrderDetil
        Dim writer As New BarcodeWriter() With {
           .Format = BarcodeFormat.CODE_128,
           .Options = New EncodingOptions With {
               .Width = 250,
               .Height = 125,
               .Margin = 2
           }
       }

        For Each row As DataRow In dt.Rows
            Dim codeValue As String = row("Code").ToString()
            Dim bitmap As Bitmap = writer.Write(codeValue)
            Dim MS As New System.IO.MemoryStream()
            bitmap.Save(ms, ImageFormat.Png)
                row("Barcode") = ms.ToArray()

        Next
        rp.SetDataSource(dt)

        If dt.Rows(0)("srl_customer") = 860 Then
            rp.SetParameterValue("Link", "www.ompelimomoda.fi")
            rp.SetParameterValue("ShowLogo", False)
        Else
            rp.SetParameterValue("Link", "www.reonet.fi")
            rp.SetParameterValue("ShowLogo", True)
        End If
        Dim frm_rp As New Frm_RpVw(rp, dt)
        frm_rp.ShowDialog()
    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Dim cell As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
        If e.ColumnIndex = 9 Then
            cell.ToolTipText = "Edit"
        ElseIf e.ColumnIndex = 10 Then
            cell.ToolTipText = "Delete"
        ElseIf e.ColumnIndex = 11 Then
            cell.ToolTipText = "Print"
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label1.Click

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



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        UpdateDataGidView()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        UpdateDataGidView()

    End Sub

    Private Sub dgvData_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If e.ColumnIndex = Me.DataGridView1.Columns(9).Index AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All And Not DataGridViewPaintParts.ContentBackground)
            Dim myImage As Image = My.Resources.edit
            If myImage IsNot Nothing Then
                Dim drawRect As Rectangle = e.CellBounds
                drawRect.Inflate(-2, -2)
                e.Graphics.DrawImage(myImage, drawRect)
            End If
            e.Handled = True
        ElseIf e.ColumnIndex = Me.DataGridView1.Columns(10).Index AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All And Not DataGridViewPaintParts.ContentBackground)
            Dim myImage As Image = My.Resources.delete
            If myImage IsNot Nothing Then
                Dim drawRect As Rectangle = e.CellBounds
                drawRect.Inflate(-2, -2)
                e.Graphics.DrawImage(myImage, drawRect)
            End If
            e.Handled = True
        ElseIf e.ColumnIndex = Me.DataGridView1.Columns(11).Index AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All And Not DataGridViewPaintParts.ContentBackground)
            Dim myImage As Image = My.Resources.printer
            If myImage IsNot Nothing Then
                Dim drawRect As Rectangle = e.CellBounds
                drawRect.Inflate(-2, -2)
                e.Graphics.DrawImage(myImage, drawRect)
            End If
            e.Handled = True

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.OrderDetilTableAdapter.Fill(Me.Ds_Order.OrderDetil, DirectCast(DataGridView1.SelectedRows(0).Cells(0).Value, Integer), -1, "-1", "-1", -1, -1, -1)
        Dim rp As New Rp_Kuitti
        Dim dt As DataTable = Me.Ds_Order.OrderDetil

        rp.SetDataSource(dt)

        Dim frm_rp As New Frm_RpVw(rp, dt)
        frm_rp.Show()
    End Sub
End Class