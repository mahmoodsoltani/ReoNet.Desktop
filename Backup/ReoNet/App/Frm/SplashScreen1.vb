Imports System.Threading
Imports System.Reflection
Imports System.ComponentModel
Imports VB_Component

Public NotInheritable Class SplashScreen1

    Public Delegate Sub Loading()
    Private Delegate Sub ChangeProgressBarHandler(ByVal percentage As Integer)

#Region "applocation event count"
    Dim Count_Set_GetConnection As Integer = 2
    Dim Count_Set_ChangeConnection As Integer = 4
    Dim Count_Set_newDataAcces As Integer = 6
    Dim Count_Set_changLangugeToFarsi As Integer = 8
    Dim Count_Set_LevelOfForm As Integer = 6
#End Region

#Region "Funcion"
    Public Shared Sub Load_Setting()
        Try
            Dim dt As DataTable = PublicFunction.GetSettingTable(Setting.Srl_User, _
                                                             , "ApplicationSetting", , , , , , )
            For Each Row As DataRow In dt.Rows
                Dim t As New ReoNet.Setting()
               If Row("ObjectType").Equals("GenralValue") Then
                    Dim SNode As SettingNode = DirectCast(DirectCast(DirectCast(t.GetType().GetField _
                    (Row("ObjectName").ToString).GetValue(t), System.Object), ReoNet.SettingNode) _
                    , ReoNet.SettingNode)
                    CallByName(SNode, "ObjectName", CallType.Set, Row("ObjectName").ToString)
                    CallByName(SNode, "ObjectType", CallType.Set, Row("ObjectType").ToString)
                    CallByName(SNode, "PropName", CallType.Set, Row("PropName").ToString)
                    CallByName(SNode, "PropValue", CallType.Set, Row("PropValue").ToString)
                    CallByName(SNode, "Srl_In_Setting", CallType.Set, Integer.Parse(Row("Srl").ToString))
                    CallByName(SNode, "Srl_Sec_From", CallType.Set, Integer.Parse(Row("Srl_Sec_From").ToString))
                    CallByName(SNode, "Srl_Sec_Groups", CallType.Set, Integer.Parse(Row("Srl_Sec_Groups").ToString))
                    CallByName(SNode, "Srl_Sec_Users", CallType.Set, (Row("Srl_Sec_Users").ToString))
                    CallByName(SNode, "Visible", CallType.Set, Boolean.Parse(Row("Visible").ToString))
                    CallByName(SNode, "Active", CallType.Set, Boolean.Parse(Row("Active").ToString))
                    CallByName(SNode, "Dis", CallType.Set, Row("Dis").ToString)
                End If
            Next
        Catch ex As Exception
            MessageBoxFa.Show(ex.Message + vbNewLine + "Error on loading setting ,application can not work correctly until setting completed")
            End
        End Try
    End Sub

    Sub DoProgress(ByVal Value As Integer)
        For i As Integer = 0 To Value
            BackgroundWorker1.ReportProgress(ProgressBar1.Value + i)
            System.Threading.Thread.Sleep(0)
        Next
    End Sub
    Sub General()
        Try
            Try
                Setting.ClientIpAddress = VB_Component.Windows.GetStationIp(1)
            Catch ex As Exception
                Setting.ClientIpAddress = VB_Component.Windows.GetStationIp(0)
            End Try
            Setting.TarikheJary = VB_Component.FarsiDateFun.Now
            Dim sqlcninfo As New SqlClient.SqlConnectionStringBuilder(Setting.ConnectionString)
            Setting.ServerName = sqlcninfo.DataSource
            Application.DoEvents()
            VB_Component.Windows.ChangeLangToFarsi(True)
            BackgroundWorker1.ReportProgress(Count_Set_changLangugeToFarsi)
            BackgroundWorker_LoadSetting.RunWorkerAsync()
            Application.DoEvents()
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
           
    
            'Setting.Frm_Distance_obj = New Frm_Distance
            'DoProgress(Count_Set_LevelOfForm)
            'Application.DoEvents()
           
            'Delete edit mode table with client IP address
            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            BaseDataObject.DataAccess.Delete("EditMode", "userIp='" + Setting.ClientIpAddress + "'")
            BackgroundWorker1.ReportProgress(100)
            Application.DoEvents()
            BaseDataObject.DataAccess.ClearPool()
        Catch ex As Exception
            MessageBoxFa.Show("Error on load project" + vbNewLine + ex.Message)
            End
        End Try
    End Sub

#End Region

#Region "BackGroundWorking"
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As System.Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        Invoke(New ChangeProgressBarHandler(AddressOf ChangeProgressBar), e.ProgressPercentage)
    End Sub

    Private Sub ChangeProgressBar(ByVal percentage As Integer)
        ProgressBar1.Value = percentage
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Close()
    End Sub
#End Region

#Region "DoWork"
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Invoke(New Loading(AddressOf Me.General))
        Catch obj1 As Exception
            MessageBox.Show(obj1.Message)
            Return
        End Try
    End Sub

    Private Sub BackgroundWorker_LoadSetting_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_LoadSetting.DoWork
        Try
            Invoke(New Loading(AddressOf Load_Setting))
        Catch obj1 As Exception
            MessageBox.Show(obj1.Message)
            Return
        End Try
    End Sub
#End Region

End Class
