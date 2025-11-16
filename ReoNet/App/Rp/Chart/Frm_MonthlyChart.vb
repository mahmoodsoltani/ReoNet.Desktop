Imports System.Windows.Forms.DataVisualization.Charting
Public Class Frm_MonthlyChart
    Dim Srl_Pm_Tajhiz_ForSave As Integer = -1
    Private Sub Frm_RpEibForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Ds_Order1.reonet_MonthlyChart' table. You can move, or remove it, as needed.
        Me.Reonet_MonthlyChartTableAdapter.Fill(Me.Ds_Order1.reonet_MonthlyChart)
        Dim dt As DataTable = Ds_Order1.reonet_MonthlyChart

        ' ----------------------------
        ' 2. تعیین لیست مشتری‌ها (Distinct)
        ' ----------------------------
        Dim allMonths As String() = {"January", "February", "March", "April", "May", "June",
                             "July", "August", "September", "October", "November", "December"}
        Dim currentMonth As Integer = DateTime.Now.Month
        Dim monthsToShow = allMonths.Take(currentMonth).ToArray()

        Chart1.Series.Clear()
        Chart1.ChartAreas(0).AxisX.Interval = 1
        Chart1.ChartAreas(0).AxisX.MajorGrid.Enabled = False
        Chart1.ChartAreas(0).AxisX.Title = "Month"
        Chart1.ChartAreas(0).AxisY.Title = "Total Price"

        ' مشتری‌ها
        Dim customers = dt.AsEnumerable() _
                  .Select(Function(r) r.Field(Of String)("companyname")) _
                  .Where(Function(c) Not String.IsNullOrEmpty(c)) _
                  .Distinct()

        ' رسم ستون‌ها و نمایش مقدار روی ستون
        For Each cust In customers
            Dim series As New Series(cust)
            series.ChartType = SeriesChartType.Column
            Chart1.Series.Add(series)

            For Each MonthNames In monthsToShow
                Dim row = dt.AsEnumerable().FirstOrDefault(Function(r) r.Field(Of String)("companyname") = cust AndAlso
                                                                 r.Field(Of String)("MonthName") = MonthNames)
                Dim price As Decimal = 0D
                If row IsNot Nothing Then
                    price = If(IsDBNull(row("TotalPrice")), 0D, Convert.ToDecimal(row("TotalPrice")))
                End If
                series.Points.AddXY(MonthNames, price)
            Next
        Next

        Chart1.Titles.Clear()
        Chart1.Titles.Add("Monthly Sales by Customer (Vertical Labels)")
    End Sub




    Private Sub btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Save.Click

    End Sub

    Private Sub txt_Barcode_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub
End Class