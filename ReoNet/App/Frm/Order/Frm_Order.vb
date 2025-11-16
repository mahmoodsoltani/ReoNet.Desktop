Imports System.Threading
Imports ZXing
Imports ZXing.Common
Imports ZXing.Rendering
Public Class Frm_Order
    Private lastKeyTime As DateTime = DateTime.Now
    Private scannedText As String = ""
    Private isScanning As Boolean = False

    Dim srl_customer As Integer = -1
    Dim Edit_CurrentIndex As Integer = -1
    Dim Srl_Order As Integer = -1
    Dim LoadAfterSave As Boolean = False
    Dim InsertedSRL As Integer = -1
    Dim Srl_Pm_Tajhiz_ForSave As Integer
    Dim Mobile As String = ""
    Dim SMS As String = ""
    Dim Srl_Sarparast As String = ""
    Dim SendSms As Boolean = False
    Dim Sarparast As String = ""
    Dim srl_Service As Integer = -1


    Public Sub New(ByVal Srl_Order As Integer)
        InitializeComponent()
        If Srl_Order <> -1 Then
            Me.Srl_Order = Srl_Order
        End If
    End Sub
    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)

        If DataGridView1.Rows.Count > 0 Then
            Dim result = MessageBox.Show("You have unsaved changes. If you close the form now, your data will be lost. Are you sure you want to close the form?",
                                     "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then
                e.Cancel = True   ' Cancel the closing
                btn_Save.Focus()
            End If
        End If
    End Sub
    Protected Overrides Sub OnKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F6 Then
            Btn_Add_Click(Nothing, Nothing)

        ElseIf e.KeyCode = Keys.F2 Then
            btn_Save_Click(Nothing, Nothing)
        Else
            MyBase.OnKeyDown(e)
        End If
    End Sub

    Private Sub Frm_FixEibForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Reonet_customerTableAdapter.Fill(Me.Ds_BaseInfo.reonet_customer)
        Me.Reonet_servicesTableAdapter.Fill(Me.Ds_BaseInfo.reonet_services)
        txt_Area.Text = ""
        txt_Length.Text = ""
        txt_width.Text = ""
        txt_Price.Text = ""
        txt_RawPrice.Text = ""
        txt_customerCode.Focus()

        txt_Service.Text = ""
        srl_Service = -1
        txt_customerCode.Text = ""
        txt_ordernumber.Value = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(MAX(CAST(ordernumber AS int)), - 1) + 1 AS MaxSrl FROM reonet_ordermaster ")
        If txt_ordernumber.Value = 0 Then
            txt_ordernumber.Value = 1000
        End If
        MyBase.StatusStrip1.Items.Add("F2 Save")


        If Srl_Order <> -1 Then

            Dim dr_master As DataRow = BaseDataObject.DataAccess.GetRow("reonet_ordermaster", "srl=" + Srl_Order.ToString)
            If (dr_master Is Nothing) Then
                Return
                Me.Close()
            End If
            txt_OrderDate.Value = dr_master("orderdate")
            txt_ordernumber.Value = dr_master("ordernumber")
            txt_DeliveryDate.Value = dr_master("deliverydate")
            txt_Description.Value = dr_master("description")
            txt_OrderTotalPrice.Value = dr_master("totalprice")
            txt_DeliveryPrice.Value = dr_master("deliveryprice")
            'Cmb_Service.SelectedValue = dr_master("srl_customer")
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("reonet_customer", CInt(dr_master("srl_customer")))
            txt_customerCode.Text = dr("code")
            txt_CustomerMobile.Text = dr("tell1")
            lbl_customerName.Text = IIf(dr("is_company"), dr("Companyname"), dr("name") + " " + dr("family"))
            srl_customer = CInt(dr("srl"))
            Me.Reonet_orderdetailTableAdapter.Fill(Me.Ds_Order.reonet_orderdetail, Srl_Order)

            UpdateOrderSum()
        Else
            txt_OrderDate.Value = Date.Now()
        End If

    End Sub

    Private Sub Btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add.Click
        If Edit_CurrentIndex = -1 Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells(6).Value = txt_Barcode.Text Then
                    MessageBox.Show("The barcode is dublicated!")
                    txt_Barcode.Focus()
                    Return
                End If
            Next
            If Not BaseDataObject.DataAccess.ExecScalar("select srl from reonet_orderdetail where  barcode ='" + txt_Barcode.Text + "'") Is Nothing Then
                MessageBox.Show("This barcode is registered!")
                txt_Barcode.Focus()
                Return
            End If
        End If

        If txt_Barcode.Text = "" Or txt_Barcode.Text = "0" Then
            MessageBox.Show("Barcode is required!")
            txt_Barcode.Focus()
            Return
        End If
        If srl_Service = -1 Then
            MessageBox.Show("Select a service!")
            btn_SelectService.Focus()
            Return
        End If

        If Edit_CurrentIndex <> -1 Then
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("srl_subservice") = srl_Service
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("srl_orderstatus") = IIf(cmb_orderStatus.SelectedValue Is Nothing, DBNull.Value, cmb_orderStatus.SelectedValue)
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("code") = txt_Barcode.Text

            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("width") = txt_width.Text
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("service") = txt_Service.Text
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("count") = txt_Count.Text
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("length") = IIf(txt_Length.Text = "", DBNull.Value, txt_Length.Text)
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("price") = txt_Price.Text
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("area") = txt_Area.Text
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("description") = txt_Description.Text
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("iscash") = chk_cash.Checked
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("discount") = txt_Discount.Text

            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("totalprice") = txt_RawPrice.Text

            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List _
            , DataView).Table.Rows(Edit_CurrentIndex).Item("deliverydate") = txt_itemDeliveryDate.Text
            Btn_Add.HeaderText = "Add"
            DataGridView1.Enabled = True
            Edit_CurrentIndex = -1
        Else
            Dim dr As DataRow = DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.NewRow
            dr("srl_subservice") = srl_Service
            dr("srl_orderstatus") = cmb_orderStatus.SelectedValue
            dr("service") = txt_Service.Text
            dr("code") = txt_Barcode.Text
            'dr("width") = Iff(txt_width.Text = "", 0, txt_width.Text)
            dr("count") = txt_Count.Text
            dr("length") = IIf(txt_Length.Text = "", DBNull.Value, txt_Length.Text)
            dr("area") = txt_Area.Text
            dr("width") = IIf(txt_width.Text = "", DBNull.Value, txt_width.Text)
            dr("price") = txt_Price.Text
            dr("discount") = IIf(txt_Discount.Text = "", 0, txt_Discount.Text)
            dr("iscash") = chk_cash.Checked
            dr("totalprice") = txt_RawPrice.Text
            dr("srl_ordermaster") = -1
            dr("description") = txt_Description.Text
            dr("deliverydate") = txt_itemDeliveryDate.Text
            DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table.Rows.Add(dr)
        End If
        txt_Barcode.Text = ""
        txt_width.Text = ""
        txt_Price.Text = ""
        txt_Length.Text = ""
        txt_Count.Text = ""
        txt_Area.Text = ""
        txt_RawPrice.Text = ""
        txt_Description.Text = ""
        txt_Barcode.Focus()
        srl_Service = -1
        chk_cash.Checked = False
        txt_Service.Text = ""
        txt_Discount.Text = "0"
        txt_itemDeliveryDate.Value = Date.Now
        PictureBox1.Image = Nothing
        txt_totalPrice.Text = ""

        Me.Reonet_orderstatusTableAdapter.Fill(Me.Ds_BaseInfo.reonet_orderstatus, -2)
        UpdateOrderSum()
    End Sub

    Private Sub Btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If DataGridView1.CurrentRow Is Nothing Then
            Return
        End If
        Edit_CurrentIndex = DataGridView1.CurrentRow.Index

        srl_Service = DataGridView1.CurrentRow.Cells(3).Value
        Dim dr = BaseDataObject.DataAccess.GetRow("reonet_Services", srl_Service)
        Me.Reonet_orderstatusTableAdapter.Fill(Me.Ds_BaseInfo.reonet_orderstatus, CInt(dr("srl_servicecategory")))
        cmb_orderStatus.SelectedValue = DataGridView1.CurrentRow.Cells(12).Value
        txt_Service.Text = dr("name").ToString()

        txt_Barcode.Text = DataGridView1.CurrentRow.Cells(1).Value
        txt_Barcode_Leave_1(Nothing, Nothing)
        txt_width.Text = DataGridView1.CurrentRow.Cells(7).Value
        If DataGridView1.CurrentRow.Cells(8).Value Is DBNull.Value Then
            chk_circle.Checked = True
        Else
            txt_Length.Text = DataGridView1.CurrentRow.Cells(8).Value
            chk_circle.Checked = False
        End If
        txt_Price.Text = DataGridView1.CurrentRow.Cells(6).Value
        'txt_totalprice.Text = DataGridView1.CurrentRow.Cells(11).Value
        txt_Area.Text = DataGridView1.CurrentRow.Cells(9).Value
        txt_Count.Text = DataGridView1.CurrentRow.Cells(5).Value
        txt_Description.Text = DataGridView1.CurrentRow.Cells(11).Value
        txt_Discount.Text = DataGridView1.CurrentRow.Cells(14).Value
        txt_itemDeliveryDate.Text = DataGridView1.CurrentRow.Cells(15).Value
        chk_cash.Checked = DataGridView1.CurrentRow.Cells(13).Value

        Btn_Add.HeaderText = "Apply"
        DataGridView1.Enabled = False
        txt_Barcode.Focus()
    End Sub

    Private Sub Btn_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If DataGridView1.CurrentRow Is Nothing Then
            Return
        End If
        If MessageBox.Show("Are you Sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Return
        End If
        DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Delete(
        DataGridView1.CurrentRow.Index)
        Edit_CurrentIndex = -1
        UpdateOrderSum()
    End Sub



    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        If Edit_CurrentIndex <> -1 Then
            MessageBox.Show("You are editing an item. First Complete it!")
            Return
        End If
        If srl_customer < 1 Then
            MessageBox.Show("Select the customer!")
            txt_customerCode.Focus()
            Return
        End If
        Dim tr As Thread = Nothing


        Dim Srl As Integer = -1
        Dim dt_detail As DataTable = DirectCast(DirectCast(DataGridView1.DataSource, BindingSource).List, DataView).Table
        Dim dr As DataRow = BaseDataObject.DataAccess.NewRow("reonet_ordermaster")
        If dr Is Nothing Then
            MessageBoxFa.Show("error in save data")
            Return
        End If



        dr("Ordernumber") = txt_ordernumber.Value
        dr("orderdate") = PublicFunction.FormatDateToStandard(txt_OrderDate.Text)
        dr("deliverydate") = PublicFunction.FormatDateToStandard(txt_DeliveryDate.Text)


        dr("deliveryprice") = txt_DeliveryPrice.Text
        dr("description") = txt_OrderDescription.Text
        dr("totalprice") = txt_OrderTotalPrice.Text

        dr("srl_customer") = srl_customer

        dr("createuser") = Setting.Srl_User
        'dr("createdate") = Setting.Now

        If Srl_Order <> -1 Then
            dr("Srl") = Srl_Order
            BaseDataObject.DataAccess.BeginTransaction()
            If BaseDataObject.DataAccess.Update(dr, 0) Then
                BaseDataObject.DataAccess.ExecQuery("DELETE FROM reonet_orderdetail where srl_ordermaster=" + Srl_Order.ToString)

                Dim dr_orderdetail As DataRow = BaseDataObject.DataAccess.NewRow("reonet_orderdetail")
                Dim dr_det As DataRow = dt_detail.NewRow
                dr_orderdetail("srl_ordermaster") = Srl_Order
                'dr_orderdetail("createuser") = Setting.Srl_User
                'dr_orderdetail("createdate") = Setting.Now



                For Each dr_det In dt_detail.Rows
                    Try
                        dr_orderdetail("srl_subservice") = dr_det("srl_subservice")
                        dr_orderdetail("barcode") = dr_det("code")
                        dr_orderdetail("width") = dr_det("width")
                        dr_orderdetail("itemcount") = dr_det("count")
                        dr_orderdetail("length") = dr_det("length")
                        dr_orderdetail("area") = dr_det("area")
                        dr_orderdetail("price") = dr_det("price")
                        dr_orderdetail("totalprice") = dr_det("totalprice")
                        dr_orderdetail("srl_orderstatus") = dr_det("srl_orderstatus")
                        dr_orderdetail("description") = dr_det("description")
                        dr_orderdetail("iscash") = dr_det("iscash")
                        dr_orderdetail("discount") = dr_det("discount")
                        dr_orderdetail("deliverydate") = dr_det("deliverydate")
                        BaseDataObject.DataAccess.Insert(dr_orderdetail, False)



                    Catch
                    End Try
                Next

            End If

        Else
            BaseDataObject.DataAccess.BeginTransaction()
            Srl = BaseDataObject.DataAccess.InsertWithLastId(dr, False)
            If Srl = -1 Then
                MessageBoxFa.Show("error in save data")
                BaseDataObject.DataAccess.RollBack()
                Return
            Else
                Dim dr_orderdetail As DataRow = BaseDataObject.DataAccess.NewRow("reonet_orderdetail")

                Dim dr_det As DataRow = dt_detail.NewRow
                dr_orderdetail("srl_ordermaster") = Srl
                'dr_orderdetail("createuser") = Setting.Srl_User
                'dr_orderdetail("createdate") = Setting.Now

                For Each dr_det In dt_detail.Rows
                    Try
                        dr_orderdetail("srl_subservice") = dr_det("srl_subservice")
                        dr_orderdetail("barcode") = dr_det("code")
                        dr_orderdetail("width") = dr_det("width")
                        dr_orderdetail("itemcount") = dr_det("count")
                        dr_orderdetail("length") = dr_det("length")
                        dr_orderdetail("area") = dr_det("area")
                        dr_orderdetail("price") = dr_det("price")
                        dr_orderdetail("totalprice") = dr_det("totalprice")
                        dr_orderdetail("srl_orderstatus") = dr_det("srl_orderstatus")
                        dr_orderdetail("iscash") = dr_det("iscash")
                        dr_orderdetail("discount") = dr_det("discount")
                        dr_orderdetail("deliverydate") = dr_det("deliverydate")
                        dr_orderdetail("description") = dr_det("description")
                        BaseDataObject.DataAccess.Insert(dr_orderdetail, False)
                    Catch
                        MessageBoxFa.Show("error in save data")
                        BaseDataObject.DataAccess.RollBack()
                        Return
                    End Try
                Next
            End If
            InsertedSRL = Srl
        End If

        If Not BaseDataObject.DataAccess.Commit Then
            MessageBoxFa.Show("error in save data")
            BaseDataObject.DataAccess.RollBack()
            Return
        ElseIf Srl_Order <> -1 Then

            MessageBox.Show("Order was successfully Edited!", "Informatin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BaseDataObject.DataAccess.Commit()
            Me.Close()

        Else

            MessageBox.Show("Order was successfully Added!", "Informatin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BaseDataObject.DataAccess.Commit()

        End If
        Clear()
    End Sub

    Private Sub Clear()
        txt_ordernumber.Value = BaseDataObject.DataAccess.ExecScalar("SELECT ISNULL(MAX(CAST(ordernumber AS int)), - 1) + 1 AS MaxSrl FROM reonet_ordermaster ")
        If txt_ordernumber.Value = 0 Then
            txt_ordernumber.Value = 1000
        End If
        txt_OrderDate.Value = Date.Now
        txt_customerCode.Text = ""
        txt_CustomerMobile.Text = ""
        txt_Barcode.Text = ""
        txt_Price.Text = ""
        txt_width.Text = ""
        txt_Length.Text = ""
        txt_RawPrice.Text = ""
        txt_Description.Text = ""
        txt_OrderDescription.Text = ""
        txt_OrderTotalPrice.Text = ""
        txt_sum.Text = ""
        txt_Discount.Text = ""
        txt_totalPrice.Text = ""
        txt_itemDeliveryDate.Value = Date.Now
        txt_DeliveryDate.Value = Date.Now
        txt_DeliveryPrice.Text = ""
        lbl_customerName.Text = ""
        chk_cash.Checked = False
        chk_circle.Checked = False
        PictureBox1.Image = Nothing
        While DataGridView1.Rows.Count > 0
            DataGridView1.Rows.RemoveAt(0) ' حذف اولین سطر
        End While
        txt_customerCode.Focus()

    End Sub

    Public Sub UpdateOrderSum()
        Dim total As Decimal = 0
        Dim totalDiscount As Decimal = 0
        For Each row As DataGridViewRow In DataGridView1.Rows

            Dim value As Object = row.Cells(10).Value
            If value IsNot Nothing AndAlso IsNumeric(value) Then
                total += Convert.ToDecimal(value)
            End If
            Dim value1 As Object = row.Cells(14).Value
            If value1 IsNot Nothing AndAlso IsNumeric(value) Then
                totalDiscount += Convert.ToDecimal(value1)
            End If
        Next
        txt_sum.Text = total.ToString("N2")
        txt_totalDiscount.Text = totalDiscount.ToString("N2")
        txt_OrderTotalPrice.Text = PublicFunction.RoundToNearest05(Math.Round(CDbl(IIf(txt_sum.Text <> "", txt_sum.Text, 0)) + CDbl(IIf(txt_DeliveryPrice.Text <> "", txt_DeliveryPrice.Text, 0)) - CDbl(IIf(txt_totalDiscount.Text <> "", txt_totalDiscount.Text, 0)), 2).ToString("N2"))

    End Sub
    Private Sub txt_customerCode_Leave(sender As Object, e As EventArgs) Handles txt_customerCode.Leave
        Try
            If txt_customerCode.Value > 0 Then
                Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("reonet_customer", "code =  " + txt_customerCode.Value.ToString())
                If Not dr Is Nothing Then
                    lbl_customerName.Text = IIf(dr("is_company"), dr("Companyname"), dr("name") + " " + dr("family"))
                    srl_customer = CInt(dr("Srl"))
                    txt_CustomerMobile.Text = dr("tell1")
                    txt_Barcode.Focus()
                    cmb_customer.SelectedValue = dr("srl")
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
            If txt_CustomerMobile.Text <> "" Then
                Dim dr As DataRow = PublicFunction.SearchByTell(txt_CustomerMobile.Text)
                If dr Is Nothing Then
                    If MessageBox.Show("No customer was found. Would you like to create one using this mobile number?", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        Dim Frm_Customer = New Frm_Customer(txt_CustomerMobile.Text)
                        Frm_Customer.ShowDialog()
                        dr = BaseDataObject.DataAccess.GetRow("reonet_Customer", "tell1 =  '" + txt_CustomerMobile.Text + "'")
                    Else
                        txt_CustomerMobile.Focus()
                        Return
                    End If
                End If
                lbl_customerName.Text = IIf(dr("is_company"), dr("Companyname"), dr("name") + " " + dr("family"))
                srl_customer = CInt(dr("Srl"))
                txt_customerCode.Text = dr("code")
                txt_Barcode.Focus()
                cmb_customer.SelectedValue = dr("srl")

            Else
                srl_customer = -1
                txt_customerCode.Text = ""
                lbl_customerName.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cmb_Service_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If Cmb_Service.SelectedValue > 0 Then
        '    txt_Price.Text = BaseDataObject.DataAccess.ExecScalar("select price from reonet_subservice where srl = " + Cmb_Service.SelectedValue.ToString())
        'End If
    End Sub

    Private Sub Change_dimention(sender As Object, e As EventArgs) Handles txt_width.TextChanged, txt_Length.TextChanged
        Calculate_Area()
        'Calculate_ServicePrice()
    End Sub
    Private Sub Calculate_Area()
        Try
            If chk_circle.Checked Then
                txt_Area.Text = PublicFunction.RoundToNearest05(Math.Round(3.14 * Math.Pow((CInt(txt_width.Text) / 200), 2), 2))
            Else
                txt_Area.Text = PublicFunction.RoundToNearest05(Math.Round(CInt(txt_width.Text) * CInt(txt_Length.Text) / 10000, 2)).ToString()
            End If
        Catch ex As Exception
            txt_Area.Text = "0"
        End Try
    End Sub
    Private Sub Calculate_ServicePrice()
        Try
            If pl_SquareMeter.Visible Then
                txt_RawPrice.Text = PublicFunction.RoundToNearest05(Math.Round(IIf(CDbl(txt_Area.Text) < 1, 1, CDbl(txt_Area.Text)) * CInt(txt_Count.Text) * CDbl(txt_Price.Text), 2))
            Else
                txt_RawPrice.Text = PublicFunction.RoundToNearest05(Math.Round(CInt(txt_Count.Text) * CDbl(txt_Price.Text), 2))

            End If
            txt_totalPrice.Text = CDbl(txt_RawPrice.Text) - CDbl(IIf(txt_Discount.Text = "0" Or txt_Discount.Text = "", 0, txt_Discount.Text))

        Catch ex As Exception

        End Try

    End Sub
    Private Sub UpdateTotalPrice(sender As Object, e As EventArgs) Handles txt_Price.TextChanged, txt_Count.TextChanged, txt_Area.TextChanged, txt_Discount.TextChanged
        Calculate_ServicePrice()
    End Sub
    Private Sub UpdateOrderPrice(sender As Object, e As EventArgs) Handles txt_Count.TextChanged, txt_Price.TextChanged, txt_Area.TextChanged, txt_sum.TextChanged, txt_DeliveryPrice.TextChanged

    End Sub

    Private Sub txt_Barcode_Leave(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_SelectService.Click
        Dim frm As New VB_Component.Tree_Vw_Select(Me.Ds_BaseInfo.reonet_services)
        frm.Tree_Vw1.TreeView1.CollapseAll()
        For Each rootNode As VB_Component.TreeNode In frm.Tree_Vw1.TreeView1.Nodes
            rootNode.Expand()
        Next
        'Dim Frm_serviceSelect As New Frm_ServiceSelect()
        If frm.ShowDialog() = DialogResult.OK Then
            Dim dr = BaseDataObject.DataAccess.GetRow("reonet_Services", frm.Result.Srl)
            If Not dr Is Nothing Then
                txt_Service.Text = dr("name")
                srl_Service = frm.Result.Srl
                If Not dr("price") Is DBNull.Value Then

                    txt_Price.Text = dr("price")
                Else
                    txt_Price.Text = 0
                End If
                pl_SquareMeter.Visible = IIf(CInt(dr("Srl_unit")) <> 2, False, True)

                lbl_count_Weight.Text = IIf(CInt(dr("Srl_unit")) = 1, "Weight", "Count")
                txt_RawPrice.Text = IIf(CInt(dr("Srl_unit")) <> 2, PublicFunction.RoundToNearest05(Math.Round(CDbl(txt_Price.Text) * CDbl(txt_Count.Text), 2)), "")

                If Not dr("srl_servicecategory") Is DBNull.Value Then
                    Me.Reonet_orderstatusTableAdapter.Fill(Me.Ds_BaseInfo.reonet_orderstatus, CInt(dr("srl_servicecategory")))
                End If
                UpdateTotalPrice(Nothing, Nothing)
                txt_width.Focus()
            End If

        End If

    End Sub

    Private Sub chk_circle_CheckedChanged(sender As Object, e As EventArgs) Handles chk_circle.CheckedChanged
        lbl_width.Text = IIf(chk_circle.Checked, "Diameter", "Width")
        txt_Length.Visible = Not chk_circle.Checked
        lbl_Length.Visible = Not chk_circle.Checked
        txt_Length.Text = ""
        Calculate_Area()
        Calculate_ServicePrice()
    End Sub

    Private Sub txt_Barcode_Leave_1(sender As Object, e As EventArgs) Handles txt_Barcode.Leave
        Try
            Dim writer As New BarcodeWriter() With {
    .Format = BarcodeFormat.CODE_128,
    .Options = New EncodingOptions With {
        .Width = 200,
        .Height = 100,
        .Margin = 2
    },
    .Renderer = New BitmapRenderer()
}

            Dim img As Bitmap = writer.Write(txt_Barcode.Text)
            PictureBox1.Image = img


        Catch ex As Exception
        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        MessageBox.Show(txt_ordernumber.Value)
        MessageBox.Show(PublicFunction.FormatDateToStandard(txt_OrderDate.Text))
    End Sub
    Private barcodeBuffer As String = ""
    ' This stores the last key press time to measure speed
    Private lastKeyPressTime As DateTime = DateTime.Now

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_customer.SelectedIndexChanged
        Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("reonet_customer", cmb_customer.SelectedValue)
        If Not dr Is Nothing Then
            txt_customerCode.Text = dr("code")
            txt_CustomerMobile.Text = dr("tell1")
            srl_customer = dr("srl")
            lbl_customerName.Text = IIf(dr("is_company"), dr("Companyname"), dr("name") + " " + dr("family"))

        End If
    End Sub

    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        If e.ColumnIndex = Me.DataGridView1.Columns(16).Index AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All And Not DataGridViewPaintParts.ContentBackground)
            Dim myImage As Image = My.Resources.edit
            If myImage IsNot Nothing Then
                Dim drawRect As Rectangle = e.CellBounds
                drawRect.Inflate(-2, -2)
                e.Graphics.DrawImage(myImage, drawRect)
            End If
            e.Handled = True
        ElseIf e.ColumnIndex = Me.DataGridView1.Columns(17).Index AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All And Not DataGridViewPaintParts.ContentBackground)
            Dim myImage As Image = My.Resources.delete
            If myImage IsNot Nothing Then
                Dim drawRect As Rectangle = e.CellBounds
                drawRect.Inflate(-2, -2)
                e.Graphics.DrawImage(myImage, drawRect)
            End If
            e.Handled = True
        ElseIf e.ColumnIndex = Me.DataGridView1.Columns(18).Index AndAlso e.RowIndex >= 0 Then
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

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        Dim cell As DataGridViewCell = DataGridView1.Rows(e.RowIndex).Cells(e.ColumnIndex)
        If e.ColumnIndex = 16 Then
            cell.ToolTipText = "Edit"
        ElseIf e.ColumnIndex = 17 Then
            cell.ToolTipText = "Delete"
        ElseIf e.ColumnIndex = 18 Then
            cell.ToolTipText = "Print"
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim senderGrid = DirectCast(sender, CS_Component.DataGridView)

            If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.RowIndex >= 0 Then
                If e.ColumnIndex = 16 Then
                    Btn_Edit_Click(Nothing, Nothing)
                ElseIf e.ColumnIndex = 17 Then
                    Btn_Del_Click(Nothing, Nothing)
                ElseIf e.ColumnIndex = 11 Then
                    'printOrder(srl_order)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class
