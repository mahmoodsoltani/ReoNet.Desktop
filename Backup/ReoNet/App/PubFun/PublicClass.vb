
Imports VB_Component

Public Class SettingNode
    Public ObjectName As String = ""
    Public ObjectType As String = ""
    Public PropName As String = ""
    Public PropValue As Object
    Public Dis As String = ""
    Public PropImage As Byte()

    Public Srl_In_Setting As Integer = -1
    Public Srl_Sec_From As Integer = -1
    Public Srl_Sec_Groups As Integer = -1
    Public Srl_Sec_Users As Integer = -1

    Public Visible As Boolean = True
    Public Active As Boolean = True

    Public Sub UpdateSetting(ByVal values As String)
        PropValue = values
        BaseDataObject.DataAccess.ExecQuery("update sec_setting set PropValue='" + values + _
                                            "' where srl=" + Srl_In_Setting.ToString)
    End Sub

    Public Sub UpdateSetting(ByVal values As Byte())
        Try
            Dim dr As DataRow = BaseDataObject.DataAccess.GetRow("sec_setting", Srl_In_Setting)
            dr("propImage") = values
            BaseDataObject.DataAccess.Update(dr, 0)
        Catch
        End Try
    End Sub
End Class
