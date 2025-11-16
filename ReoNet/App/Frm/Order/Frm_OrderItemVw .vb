Imports ZXing
Imports ZXing.Common
Imports ZXing.Rendering
Imports System.Drawing.Imaging
Public Class Frm_OrderItemVw

    Private srl_customer As Integer
    Private StartDate As String
    Private EndDate As String


    Public Sub New()
        InitializeComponent()
        srl_customer = -1
        StartDate = "-1"
        EndDate = "-1"
        'Me.WorkForm_MasterTableAdapter.FillByPost(Me.Ds_Pm.WorkForm_Master, Srl_Post)
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        Dim s As New Frm_Order(-1)
        s.ShowDialog()
        'Me.WorkForm_MasterTableAdapter.Fill(Me.Ds_Pm.WorkForm_Master)
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
        Dim srl_ordermaster = BaseDataObject.DataAccess.ExecScalar("select srl_ordermaster from reonet_orderdetail where srl = " + srl.ToString())
        If srl_ordermaster = -1 Then
            Return
        End If
        Dim s As New Frm_Order(srl_ordermaster)
        s.ShowDialog()
        UpdateDataGidView()

    End Sub

    Private Sub btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete.Click
        If MessageBox.Show("Are you sure?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = System.Windows.Forms.DialogResult.Yes Then

            Dim srl As Integer = FindSrl(DataGridView1, FindSerialPromtType.Edit, True)
            If srl = -1 Then
                Return
            End If
            BaseDataObject.DataAccess.Delete("reonet_orderdetail", srl)

            UpdateDataGidView()
            Return
        End If
    End Sub

    Private Sub Frm_WorkFormVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_BaseInfo.reonet_servicecategory' table. You can move, or remove it, as needed.
        Me.Reonet_servicecategoryTableAdapter.Fill(Me.Ds_BaseInfo.reonet_servicecategory)
        'TODO: This line of code loads data into the 'Ds_BaseInfo.reonet_servicecategory' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'Ds_Pm.WorkForm_Master' table. You can move, or remove it, as needed.
        'Me.WorkForm_MasterTableAdapter.Fill(Me.Ds_Pm.WorkForm_Master)
        Dim firstDayOfMonth As Date = New Date(Now.Year, Now.Month, 1)

        txt_Start.Value = firstDayOfMonth
        rb_all.Checked = True
        rb_AllCustomer.Checked = True
        UpdateDataGidView()


    End Sub

    Private Sub UpdateDataGidView()
        If cmb_ServiceCategory.SelectedValue Is Nothing Then
            MessageBox.Show("Select the service category!")
            cmb_ServiceCategory.Focus()
            Return
        End If


        StartDate = PublicFunction.FormatDateToStandard(txt_Start.Text)
        EndDate = PublicFunction.FormatDateToStandard(txt_End.Text)

        Dim iscash As Integer = -1
        If rb_cash.Checked Then
            iscash = 1
        ElseIf rb_invoice.Checked Then
            iscash = 0
        End If

        Dim iscompany As Integer = -1
        If rb_company.Checked Then
            iscompany = 1
        ElseIf rb_private.Checked Then
            iscompany = 0
        End If
        Dim srl_serviceCategory As Integer = -1
        srl_serviceCategory = cmb_ServiceCategory.SelectedValue

        Dim srl_orderStatus As Integer = -1

        Me.Reonet_OrderDetailVwTableAdapter.Fill(Me.Ds_Order.Reonet_OrderDetailVw, -1, -1, StartDate, EndDate, srl_customer, iscompany, iscash, srl_serviceCategory, srl_orderStatus)
        Me.Reonet_orderstatusTableAdapter.Fill(Me.Ds_BaseInfo.reonet_orderstatus, cmb_ServiceCategory.SelectedValue)

        CalcTotalSum()

    End Sub
    Private Sub CalcTotalSum()
        Dim total As Decimal = 0
        Dim totalArea As Decimal = 0
        Dim totalPrice As Decimal = 0
        Dim totalDiscount As Decimal = 0
        Dim count As Integer = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                total += Convert.ToDecimal(row.Cells(10).Value)
                totalArea += Convert.ToDecimal(row.Cells(9).Value)
                totalPrice += Convert.ToDecimal(row.Cells(8).Value)
                totalDiscount += Convert.ToDecimal(row.Cells(19).Value)
                count += 1
            End If
        Next
        lb_totalSum.Text = "Price Average:" + Math.Round(totalPrice / IIf(count, count, 1), 2).ToString() + "    Total Area: " + totalArea.ToString() + "      Total Discount:" + totalDiscount.ToString() + "      Total Price:" + total.ToString()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, CS_Component.DataGridView)
            Dim srl_orderdetail As Integer = -1
            srl_orderdetail = DirectCast(senderGrid.Rows(e.RowIndex).Cells(0).Value, Integer)
            If srl_orderdetail < 1 Then
                Return
            End If
            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                If e.ColumnIndex = 18 Then
                    Dim frm As New Frm_EditOrderDetail(srl_orderdetail)
                    frm.ShowDialog()
                    PictureBox1_Click(Nothing, Nothing)
                    'ElseIf e.ColumnIndex = 10 Then
                    '    btn_Delete_Click(Nothing, Nothing)
                ElseIf e.ColumnIndex = 17 Then
                    printOrder(srl_orderdetail)
                    End If
                End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub printOrder(srl_orderdetail As Integer)
        Me.OrderDetilTableAdapter.Fill(Me.Ds_Order.OrderDetil, -1, srl_orderdetail, "-1", "-1", -1, -1, -1)
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
            bitmap.Save(MS, ImageFormat.Png)
            row("Barcode") = MS.ToArray()

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
        frm_rp.Show()
    End Sub
    Private Sub DataGridView1_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Dim cell As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
        If e.ColumnIndex = 18 Then
            cell.ToolTipText = "Edit"

        ElseIf e.ColumnIndex = 17 Then
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
    'Private Sub DataGridView1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
    '    Dim dgv As CS_Component.DataGridView = CType(sender, CS_Component.DataGridView)

    '    dgv.RowHeadersWidth = 50

    '    ' شماره سطر
    '    Dim rowIdx As String = (e.RowIndex + 1).ToString()

    '    ' موقعیت نوشتن عدد
    '    Dim headerBounds As New Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgv.RowHeadersWidth, e.RowBounds.Height)

    '    ' فونت و تراز عمودی/افقی
    '    Dim centerFormat As New StringFormat()
    '    centerFormat.Alignment = StringAlignment.Center   ' افقی وسط
    '    centerFormat.LineAlignment = StringAlignment.Center   ' عمودی وسط

    '    ' متن رو یک مقدار بالا ببر تا روی خط مرزی نیاد
    '    headerBounds.Y += 2

    '    ' رسم عدد
    '    e.Graphics.DrawString(rowIdx, dgv.Font, SystemBrushes.ControlText, headerBounds, centerFormat)
    'End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        UpdateDataGidView()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        UpdateDataGidView()

    End Sub

    Private Sub dgvData_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If e.ColumnIndex = Me.DataGridView1.Columns(17).Index AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All And Not DataGridViewPaintParts.ContentBackground)
            Dim myImage As Image = My.Resources.printer
            If myImage IsNot Nothing Then
                Dim drawRect As Rectangle = e.CellBounds
                drawRect.Inflate(-2, -2)
                e.Graphics.DrawImage(myImage, drawRect)
            End If
            e.Handled = True

        End If
        If e.ColumnIndex = Me.DataGridView1.Columns(18).Index AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All And Not DataGridViewPaintParts.ContentBackground)
            Dim myImage As Image = My.Resources.edit
            If myImage IsNot Nothing Then
                Dim drawRect As Rectangle = e.CellBounds
                drawRect.Inflate(-2, -2)
                e.Graphics.DrawImage(myImage, drawRect)
            End If
            e.Handled = True

        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        If DataGridView1.CurrentCell.ColumnIndex = 16 AndAlso TypeOf e.Control Is System.Windows.Forms.ComboBox Then
            Dim cb As System.Windows.Forms.ComboBox = CType(e.Control, System.Windows.Forms.ComboBox)
            'Dim dv As New DataView(Me.Ds_BaseInfo.reonet_orderstatus)
            'dv.RowFilter = "srl_servicecategory = " & BaseDataObject.DataAccess.ExecScalar("Select Case srl_servicecategory from reonet_services where srl = " + DataGridView1.CurrentRow.Cells("srl_subservice").Value)
            'cb.DataSource = dv
            RemoveHandler cb.SelectionChangeCommitted, AddressOf ComboBox_SelectionChangeCommitted
            AddHandler cb.SelectionChangeCommitted, AddressOf ComboBox_SelectionChangeCommitted
        End If
    End Sub
    Private Sub ComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs)
        Dim combo As System.Windows.Forms.ComboBox = CType(sender, System.Windows.Forms.ComboBox)
        Dim rowIndex As Integer = DataGridView1.CurrentCell.RowIndex
        Dim newValue As Object = combo.SelectedValue
        Dim srl As Object = DataGridView1.Rows(rowIndex).Cells(0).Value
        BaseDataObject.DataAccess.ExecQuery("Update reonet_orderdetail set srl_orderstatus=" + newValue.ToString() + " where srl=" + srl.ToString())
    End Sub


End Class