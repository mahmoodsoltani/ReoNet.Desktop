Imports System.Data.SqlClient
Imports GsmComm.GsmCommunication
Imports System.IO.Ports
Imports System.Threading
Imports VB_Component

Imports Microsoft.Office.Interop

Public Class PublicFunction
    Public Shared Function ExportToExcel(ByVal a_sFilename As String, ByVal a_sData As DataTable , ByVal a_sFileTitle As String, ByRef a_sErrorMessage As String) As Boolean
        a_sErrorMessage = String.Empty
        Dim bRetVal As Boolean = False
        Dim dsDataSet As DataTable = Nothing
        Try
            dsDataSet = a_sData

            Dim xlObject As Excel.Application = Nothing
            Dim xlWB As Excel.Workbook = Nothing
            Dim xlSh As Excel.Worksheet = Nothing
            Dim rg As Excel.Range = Nothing
            Try
                xlObject = New Excel.Application()
                xlObject.AlertBeforeOverwriting = False
                xlObject.DisplayAlerts = False

                ''This Adds a new woorkbook, you could open the workbook from file also
                xlWB = xlObject.Workbooks.Add(Type.Missing)
                xlWB.SaveAs(a_sFilename, 56, Nothing, Nothing, Nothing, Nothing, _
                Excel.XlSaveAsAccessMode.xlNoChange, Nothing, Nothing, Nothing, Nothing)

                xlSh = DirectCast(xlObject.ActiveWorkbook.ActiveSheet, Excel.Worksheet)

                'Dim sUpperRange As String = "A1"
                'Dim sLastCol As String = "AQ"
                'Dim sLowerRange As String = sLastCol + (dsDataSet.Tables(0).Rows.Count + 1).ToString()

                For j = 0 To dsDataSet.Columns.Count - 1
                    xlSh.Cells(1, j + 1) = _
                        dsDataSet.Columns(j).ToString()
                    xlSh.Cells(1, j + 1).Font.Bold = True
                Next

                For i = 1 To dsDataSet.Rows.Count
                    For j = 0 To dsDataSet.Columns.Count - 1
                        xlSh.Cells(i + 1, j + 1) = _
                            dsDataSet.Rows(i - 1)(j).ToString()
                    Next
                Next
                xlSh.Columns.AutoFit()
                'rg = xlSh.Range(sUpperRange, sLowerRange)
                'rg.Value2 = GetData(dsDataSet.Tables(0))

                'xlSh.Range("A1", sLastCol & "1").Font.Bold = True
                'xlSh.Range("A1", sLastCol & "1").HorizontalAlignment = XlHAlign.xlHAlignCenter
                'xlSh.Range(sUpperRange, sLowerRange).EntireColumn.AutoFit()

                If String.IsNullOrEmpty(a_sFileTitle) Then
                    xlObject.Caption = "untitled"
                Else
                    xlObject.Caption = a_sFileTitle
                End If

                xlWB.Save()
                bRetVal = True
            Catch ex As System.Runtime.InteropServices.COMException
                If ex.ErrorCode = -2147221164 Then
                    a_sErrorMessage = "Error in export: Please install Microsoft Office (Excel) to use the Export to Excel feature."
                ElseIf ex.ErrorCode = -2146827284 Then
                    a_sErrorMessage = "Error in export: Excel allows only 65,536 maximum rows in a sheet."
                Else
                    a_sErrorMessage = (("Error in export: " & ex.Message) + Environment.NewLine & " Error: ") + ex.ErrorCode
                End If
            Catch ex As Exception
                a_sErrorMessage = "Error in export: " & ex.Message
            Finally
                Try
                    If xlWB IsNot Nothing Then
                        xlWB.Close(Nothing, Nothing, Nothing)
                    End If
                    xlObject.Workbooks.Close()
                    xlObject.Quit()
                Catch
                End Try
                xlSh = Nothing
                xlWB = Nothing
                xlObject = Nothing
                ' force final cleanup!
                GC.Collect()
                GC.WaitForPendingFinalizers()
            End Try
        Catch ex As Exception
            a_sErrorMessage = "Error in export: " & ex.Message
        End Try

        Return bRetVal
    End Function
    Public Shared Function DayOFWeek(ByVal daye As Date) As String
        Select Case daye.DayOfWeek
            Case System.DayOfWeek.Saturday
                Return "شنبه"
            Case System.DayOfWeek.Sunday
                Return "یکشنبه"
            Case System.DayOfWeek.Monday
                Return "دوشنبه"
            Case System.DayOfWeek.Tuesday
                Return "سه شنبه"
            Case System.DayOfWeek.Wednesday
                Return "چهار شنبه"
            Case System.DayOfWeek.Thursday
                Return "پنج شنبه"
            Case System.DayOfWeek.Friday
                Return "جمعه"
        End Select
        Return ""
    End Function
    Public Shared Function MonthOfYear(ByVal i As Integer) As String
        Select Case i
            Case 1
                Return "فروردین"
            Case 2
                Return "اردیبهشت"
            Case 3
                Return "خرداد"
            Case 4
                Return "تیر"
            Case 5
                Return "مرداد"
            Case 6
                Return "شهریور"
            Case 7
                Return "مهر"
            Case 8
                Return "آبان"
            Case 9
                Return "آذر"
            Case 10
                Return "دی"
            Case 11
                Return "بهمن"
            Case 12
                Return "اسفند"
        End Select
        Return ""
    End Function
    Public Shared Function GetYear(ByVal Tarikh As String) As String
        Return Tarikh.Remove(4, Tarikh.Length - 4)
    End Function
    Public Shared Function GetMonth(ByVal Tarikh As String) As String
        Return Tarikh.Remove(0, 5).Remove(2, 3)
    End Function
    Public Shared Function ExecGSMCommand(ByVal command As String) As String
        If Setting.Signal > 0 Then
            Dim sp As New SerialPort(Setting.PortName, 115200)
            sp.DtrEnable = True
            sp.RtsEnable = True
            sp.Open()
            sp.Write(command & Convert.ToString(sp.NewLine))
            Dim temp As String = ""
            For i As Integer = 0 To 50
                Thread.Sleep(100)
                temp += sp.ReadExisting()
                If temp.IndexOf("ok") >= 0 Then
                    Return temp
                End If
            Next
            Return ""
        Else
            Return ""
        End If
    End Function
    '0:Matn       1:Mobile          2:Srl_EibForm         3:Srl_Shakhs_Recieve
  
    Public Shared Function GetDey(ByVal Tarikh As String) As String
        Return Tarikh.Remove(0, 8)
    End Function

    Public Shared Function GetDAte(ByVal Tarikh As String) As DateTime
        Try
            Dim y As Integer
            Dim m As Integer
            Dim d As Integer
            Try
                y = GetYear(Tarikh)
                m = GetMonth(Tarikh)
                d = GetDey(Tarikh)
            Catch ex As Exception
                Return "خطا !!"
            End Try
            Dim s As New FarsiDateFun(y, m, d)
            Return FarsiDateFun.F2E(s)
        Catch ex As Exception
        End Try
    End Function

    Public Shared Function GetDeyOfWeek(ByVal Tarikh As String) As String
        Try
            Dim y As Integer
            Dim m As Integer
            Dim d As Integer
            Try
                y = GetYear(Tarikh)
                m = GetMonth(Tarikh)
                d = GetDey(Tarikh)
            Catch ex As Exception
                Return "خطا !!"
            End Try
            Dim s As New FarsiDateFun(y, m, d)
            Return DayOFWeek(FarsiDateFun.F2E(s))
        Catch ex As Exception
        End Try
        Return ""
    End Function

    Public Shared Function GetMonthOfYear(ByVal Tarikh As String) As String
        Try
            Dim m As Integer
            Try
                m = GetMonth(Tarikh)
                Return MonthOfYear(m)
            Catch ex As Exception
                Return "خطا !!"
            End Try
        Catch ex As Exception
        End Try
        Return ""
    End Function

    Public Shared Function InsertKalaPrice(ByVal Srl_Stg_Kala As Integer, ByVal Srl_FactorMaster As Integer _
                                       , ByVal Srl_FactorDetail As Integer, ByVal DefaultPrice As Integer) As Boolean
        Dim dr_KalaPrice As DataRow = BaseDataObject.DataAccess.NewRow("Stg_KalaPrice")

        dr_KalaPrice("Srl_Stg_Kala") = Srl_Stg_Kala
        dr_KalaPrice("Srl_Stg_FactorMaster") = Srl_FactorMaster.ToString
        dr_KalaPrice("Srl_Stg_FactorDetails") = Srl_FactorDetail.ToString

        If DefaultPrice = -1 Then
            Dim dr_gheimat As DataRow = BaseDataObject.DataAccess.GetRow("SELECT     Srl, ISNULL(FroshPrice, 0) AS froshprice " & _
        " FROM Stg_KalaPrice   WHERE     (Active = 1) AND (Srl_Stg_Kala = " + Srl_Stg_Kala.ToString + ")")

            If dr_gheimat Is Nothing Then
                dr_KalaPrice("FroshPrice") = 0
            Else
                dr_KalaPrice("FroshPrice") = dr_gheimat(1)
            End If
        Else
            dr_KalaPrice("FroshPrice") = DefaultPrice
        End If

        dr_KalaPrice("TarikhSabt") = Setting.TarikheJary
        dr_KalaPrice("Active") = 1
        dr_KalaPrice("Srl_SubmitUser") = Setting.Srl_User
        dr_KalaPrice("SubmitDate") = Setting.Now
        If Not dr_KalaPrice("FroshPrice") Is DBNull.Value Then
            If Not BaseDataObject.DataAccess.ExecQuery("update Stg_KalaPrice set active =0 where Srl_Stg_Kala=" + Srl_Stg_Kala.ToString) Then
                Return False
            End If
        End If
        If Not BaseDataObject.DataAccess.Insert(dr_KalaPrice, False) Then
            Return False
        End If
        Return True
    End Function

    Public Shared Function GetMaxOfFactorNoInThisFactorType(ByVal Factor_Type As Setting.FactorTypes) As Integer
        Dim max As Integer = BaseDataObject.DataAccess.FindMax("Stg_FactorMaster", "FactorNo", "Srl_Stg_FacType=" _
            + CType(Factor_Type, Integer).ToString)
        '+ CType(Factor_Type, Integer).ToString + " and Srl_Company=" + Setting.CompanyInfo.Srl.ToString())
        If max = 0 Then
            Return 1
        Else
            Return max
        End If
        Return -1
    End Function

    Public Shared Function GetKalaGroup() As DataTable
        Return BaseDataObject.DataAccess.GetDataTable("SELECT Srl,Srl_Parent,Code,Name,Dis FROM Stg_KalaGroup ")
    End Function

    Public Shared Function BeginTransaction() As Boolean
        If Not BaseDataObject.DataAccess.BeginTransaction Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function GetAnbar() As DataTable
        Return BaseDataObject.DataAccess.GetDataTable("SELECT Srl,Srl_Parent,Adress,Tel,Name,Dis,Code FROM Stg_Anbar ")
    End Function

    Public Shared Function GetSettingTable(Optional ByVal Srl_User As String = Nothing _
                                           , Optional ByVal Srl_Group As String = Nothing _
                                           , Optional ByVal FormName As String = Nothing _
                                           , Optional ByVal ObjectName As String = Nothing _
                                           , Optional ByVal PropName As String = Nothing _
                                           , Optional ByVal PropValue As String = Nothing _
                                           , Optional ByVal PropImage As Byte() = Nothing _
                                           , Optional ByVal Dis As String = Nothing _
                                           , Optional ByVal Visible As Boolean = True _
                                           , Optional ByVal Active As Boolean = True _
                                           ) As DataTable
        Dim sqlcm As SqlCommand = BaseDataObject.DataAccess.CreateCommand

        sqlcm.CommandText = "SELECT     dbo.Sec_Setting.srl, dbo.Sec_Setting.Srl_Sec_From, dbo.Sec_Setting.Srl_Sec_Groups, dbo.Sec_Setting.Srl_Sec_Users, dbo.Sec_Setting.ObjectName, " & _
  "      dbo.Sec_Setting.ObjectType, dbo.Sec_Setting.PropName, dbo.Sec_Setting.PropValue,dbo.Sec_Setting.Dis, dbo.Sec_Setting.Visible, dbo.Sec_Setting.Active " & _
" FROM         dbo.Sec_Setting INNER JOIN " & _
               "       dbo.Sec_FormName ON dbo.Sec_Setting.Srl_Sec_From = dbo.Sec_FormName.Srl"
        '" WHERE     (dbo.Sec_Setting.Srl_SherkatName = " + Setting.CompanyInfo.Srl.ToString + ")"

        Dim ds As New DataSet
        Try
            Dim da As New SqlDataAdapter(sqlcm)
            da.Fill(ds)
        Catch ex As Exception
            MessageBoxFa.Show(ex.Message)
        End Try

        Return ds.Tables(0)
    End Function

    Public Shared Function GetSaat(ByVal t As TimeSpan) As String
        'Dim temp As Integer
        'If t.ToString().Contains(".") Then
        '    temp = CInt(t.ToString.Substring(0, t.ToString.IndexOf("."))) * 24
        'End If
        'Dim temp2 As Integer = CInt(t.TotalHours())
        'Dim H As String = t.ToString.Substring(0, t.ToString.IndexOf(":"))
        'Dim M As String = t.ToString.Substring(t.ToString.IndexOf(":") + 1, 2)
        'Return H + ":" + M
        If Convert.ToInt32(t.TotalHours) > t.TotalHours Then
            Return (Convert.ToInt32(t.TotalHours) - 1).ToString() + ":" + t.Minutes.ToString()
        Else
            Return Convert.ToInt32(t.TotalHours).ToString() + ":" + t.Minutes.ToString()
        End If
    End Function

    Public Shared Function GetHour(ByVal t As String) As String
        Dim H As String = t.ToString.Substring(0, t.ToString.IndexOf(":"))
        Return H
    End Function

    Public Shared Function GetMin(ByVal t As String) As String
        Try
            Dim M As String = t.ToString.Substring(t.ToString.IndexOf(":") + 1, 2)
            Return M
        Catch
            Dim M As String = t.ToString.Substring(t.ToString.IndexOf(":") + 1, 1)
            Return M
        End Try
    End Function
    Public Shared Function IsHoliday(ByVal _date As String, ByVal type As Integer) As Boolean
        Dim dt As DataTable = BaseDataObject.DataAccess.GetDataTable("select * from pm_taghvim where tarikh='" + _date + "' and type=" + type.ToString())
        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If


    End Function
End Class
