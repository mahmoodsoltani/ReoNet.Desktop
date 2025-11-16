Imports ZXing
Imports ZXing.Common
Imports ZXing.Rendering
Imports System.Drawing.Imaging
Public Class Frm_EditOrderDetail
    Dim Srl_Service As Integer = -1
    Dim Srl_OrderDetail As Integer = -1
    Public Sub New(ByVal srl_Detail As Integer)

        InitializeComponent()
        Srl_OrderDetail = srl_Detail

    End Sub
    Private Sub Frm_RpEibForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Reonet_servicesTableAdapter.Fill(Me.Ds_BaseInfo.reonet_services)
        Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("reonet_orderdetail", Srl_OrderDetail)
        If dr Is Nothing Then
            Me.Close()
        End If
        Srl_Service = dr("srl_subservice")
        Dim dr1 = BaseDataObject.DataAccess.GetRow("reonet_Services", Srl_Service)
        Me.Reonet_orderstatusTableAdapter.Fill(Me.Ds_BaseInfo.reonet_orderstatus, CInt(dr1("srl_servicecategory")))
        cmb_orderStatus.SelectedValue = IIf(dr("srl_orderstatus") Is DBNull.Value, 0, dr("srl_orderstatus"))
        txt_Service.Text = dr1("name").ToString()

        txt_barcode.Text = dr("barcode")
        'txt_Barcode_Leave_1(Nothing, Nothing)
        txt_width.Text = dr("width")
        If dr("length") Is DBNull.Value Or dr("length") = 0 Then
            chk_circle.Checked = True
        Else
            txt_Length.Text = dr("length")
            chk_circle.Checked = False
        End If
        txt_Price.Text = dr("price")
        txt_Discount.Text = dr("discount")
        'txt_totalprice.Text = DataGridView1.CurrentRow.Cells(11).Value
        txt_Area.Text = dr("area")
        txt_Count.Text = dr("itemcount")
        txt_Description.Text = dr("description")
        chk_cash.Checked = dr("iscash")
        txt_deliveryDate.Text = dr("deliverydate")
    End Sub




    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim dr_orderdetail As DataRow = BaseDataObject.DataAccess.GetRow("reonet_orderdetail", Srl_OrderDetail)
        If dr_orderdetail Is Nothing Then
            Me.Close()
        End If
        dr_orderdetail("srl_subservice") = Srl_Service
        dr_orderdetail("barcode") = txt_barcode.Text
        dr_orderdetail("width") = txt_width.Text
        dr_orderdetail("itemcount") = txt_Count.Text
        dr_orderdetail("length") = IIf(txt_Length.Text = "", 0, txt_Length.Text)
        dr_orderdetail("area") = txt_Area.Text
        dr_orderdetail("price") = txt_Price.Text
        dr_orderdetail("totalprice") = txt_rawprice.Text
        dr_orderdetail("srl_orderstatus") = cmb_orderStatus.SelectedValue
        dr_orderdetail("description") = txt_Description.Text
        dr_orderdetail("discount") = txt_Discount.Text
        dr_orderdetail("iscash") = chk_cash.Checked
        dr_orderdetail("deliverydate") = PublicFunction.FormatDateToStandard(txt_deliveryDate.Text)

        If BaseDataObject.DataAccess.Update(dr_orderdetail, dr_orderdetail.Table.Columns.IndexOf(dr_orderdetail.Table.Columns("srl")), False) Then
            BaseDataObject.DataAccess.ExecQuery("update reonet_ordermaster set totalprice = (select sum(totalprice) from reonet_orderdetail where srl_ordermaster = reonet_ordermaster.srl) where srl=" + dr_orderdetail("srl_orderMaster").ToString())
            Me.Close()
        Else
            MessageBox.Show("Error in Editting the information!")
            txt_barcode.Focus()
        End If

    End Sub

    Private Sub txt_Barcode_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            btn_Save_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btn_SelectService_Click(sender As Object, e As EventArgs) Handles btn_SelectService.Click, Button1.Click
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
                Srl_Service = frm.Result.Srl
                If Not dr("price") Is DBNull.Value Then

                    txt_Price.Text = dr("price")
                Else
                    txt_Price.Text = 0
                End If
                pl_SquareMeter.Visible = IIf(CInt(dr("Srl_unit")) <> 2, False, True)

                lbl_count_Weight.Text = IIf(CInt(dr("Srl_unit")) = 1, "Weight", "Count")
                txt_rawprice.Text = IIf(CInt(dr("Srl_unit")) <> 2, PublicFunction.RoundToNearest05(Math.Round(CDbl(txt_Price.Text) * CDbl(txt_Count.Text), 2)), "")

                If Not dr("srl_servicecategory") Is DBNull.Value Then
                    Me.Reonet_orderstatusTableAdapter.Fill(Me.Ds_BaseInfo.reonet_orderstatus, CInt(dr("srl_servicecategory")))
                End If
                UpdateTotalPrice(Nothing, Nothing)
                txt_width.Focus()
            End If

        End If
    End Sub

    Private Sub txt_width_Leave(sender As Object, e As EventArgs) Handles txt_width.Leave, txt_Length.Leave

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
                txt_rawprice.Text = PublicFunction.RoundToNearest05(Math.Round(IIf(CDbl(txt_Area.Text) < 1, 1, CDbl(txt_Area.Text)) * CInt(txt_Count.Text) * CDbl(txt_Price.Text), 2))
            Else
                txt_rawprice.Text = PublicFunction.RoundToNearest05(Math.Round(CInt(txt_Count.Text) * CDbl(txt_Price.Text), 2))
            End If
            txt_FinlaPrice.Text = CDbl(txt_rawprice.Text) - CDbl(IIf(txt_Discount.Text = "0" Or txt_Discount.Text = "", 0, txt_Discount.Text))
        Catch ex As Exception

        End Try

    End Sub
    Private Sub UpdateTotalPrice(sender As Object, e As EventArgs) Handles txt_Price.TextChanged, txt_Count.TextChanged, txt_Area.TextChanged, txt_Discount.TextChanged, txt_FinlaPrice.TextChanged
        Calculate_ServicePrice()
    End Sub

    Private Sub chk_circle_CheckedChanged(sender As Object, e As EventArgs) Handles chk_circle.CheckedChanged
        lbl_width.Text = IIf(chk_circle.Checked, "Diameter", "Width")
        txt_Length.Visible = Not chk_circle.Checked
        lbl_Length.Visible = Not chk_circle.Checked
        txt_Length.Text = ""
        Calculate_Area()
        Calculate_ServicePrice()
    End Sub

    Private Sub txt_width_TextChanged(sender As Object, e As EventArgs) Handles txt_width.TextChanged, txt_Length.TextChanged
        Calculate_Area()
        Calculate_ServicePrice()
    End Sub
End Class