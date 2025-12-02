Imports ZXing
Imports ZXing.Common
Imports ZXing.Rendering
Imports System.Drawing.Imaging
Public Class Frm_CarpetTagPrint
    Dim Srl_Pm_Tajhiz_ForSave As Integer = -1
    Private Sub Frm_RpEibForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub




    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click
        Dim input As String = txt_Barcode.Text.Trim()
        If String.IsNullOrEmpty(input) Then
            MessageBox.Show("Please enter at least one code.")
            txt_Barcode.Focus()
            Exit Sub
        End If
        Dim items() As String = input.Split(","c)
        Dim cleanedItems As New List(Of String)
        For Each item As String In items
            Dim code As String = item.Trim()
            If code <> "" Then
                If Not IsNumeric(code) Then
                    MessageBox.Show("Invalid format: " & code)
                    Exit Sub
                End If
                cleanedItems.Add("'" & code & "'")
                For i As Integer = 1 To 3
                    Dim paddedCode As String = code.PadLeft(code.Length + i, "0"c)
                    cleanedItems.Add("'" & paddedCode & "'")
                Next
            End If
        Next
        Dim distinctItems = cleanedItems.Distinct().ToList()

        Dim dt As DataTable = BaseDataObject.DataAccess.GetDataTable($"Select reonet_orderdetail.srl, barcode as Code,srl_ordermaster, Srl_subservice , reonet_services.name as service, itemcount as count ,reonet_orderdetail . price,
 reonet_orderdetail.totalprice ,width,length,area, reonet_orderdetail .description ,
 isnull(companyname,'') as companyName, srl_customer, orderdate,isnull(Commission,0) as Commission, reonet_customer.name+' '+reonet_customer.family as CustomerNamme
,reonet_orderdetail.discount
, case when discount is null or discount=0 then
cast(reonet_orderdetail.totalprice as varchar) 
else
cast(reonet_orderdetail.totalprice- reonet_orderdetail.discount as varchar) +' ('+ cast(reonet_orderdetail.totalprice as varchar)+')'
end as ShowPrice
from reonet_orderdetail join reonet_services
on reonet_services.srl = reonet_orderdetail.Srl_subservice
 join reonet_ordermaster on 
reonet_ordermaster.srl = reonet_orderdetail.srl_ordermaster join reonet_customer on 
reonet_customer.srl = srl_customer  where 
barcode	in (" + String.Join(",", distinctItems) + ")")
        If dt Is Nothing Or dt.Rows.Count = 0 Then
            MessageBox.Show("Invalid Code(s)!")
            txt_Barcode.Focus()
            Return
        End If
        Dim rp As New Rp_CarpetPrint
        Dim writer As New BarcodeWriter() With {
                   .Format = BarcodeFormat.CODE_128,
                   .Options = New EncodingOptions With {
                       .Width = 250,
                       .Height = 125,
                       .Margin = 2
                   }
               }
        If Not dt.Columns.Contains("Barcode") Then
            dt.Columns.Add("Barcode", GetType(Byte()))
        End If
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
            rp.SetParameterValue("ShowModa", True)
            rp.SetParameterValue("ShowReonet", False)
            rp.SetParameterValue("ShowHomora", False)
        ElseIf dt.Rows(0)("srl_customer") = 876
            rp.SetParameterValue("Link", "www.homora.fi")
            rp.SetParameterValue("ShowModa", False)
            rp.SetParameterValue("ShowReonet", False)
            rp.SetParameterValue("ShowHomora", True)
        Else
            rp.SetParameterValue("Link", "www.reonet.fi")
            rp.SetParameterValue("ShowModa", False)
            rp.SetParameterValue("ShowReonet", True)
            rp.SetParameterValue("ShowHomora", False)

        End If
        Dim frm_rp As New Frm_RpVw(rp, dt)
        frm_rp.Show()
    End Sub

    Private Sub txt_Barcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Barcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_Save_Click(Nothing, Nothing)
        End If
    End Sub
End Class