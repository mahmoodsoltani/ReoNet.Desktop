Imports System.Drawing.Drawing2D
Imports System.IO.Ports
Imports VB_Component
Imports System.Data.SqlClient


Public Class Frm_Main
    Dim FirstX As Integer
    Dim FirstY As Integer
    Dim DoDrag As Boolean = False
    Dim FormBtnState As BtnState = BtnState.Non
    Dim _Left As Integer = 0
    Dim _Speed As Integer = 10

    Enum BtnState
        Non
        BaseInfo
        Action
        Report
        Setting
    End Enum
  
    Private Sub Frm_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            Setting.ConnectionString = VB_Component.DataBase.getConnection(, )
            VB_Component.Windows.ChangeConnectionString(Setting.ConnectionString, )
            Application.DoEvents()
            BaseDataObject.DataAccess = New CS_Component.DataAccess(Setting.ConnectionString, True)
            If BaseDataObject.DataAccess.CloseOnAttach Then
                End
            End If

        Catch ex As Exception
            MessageBoxFa.Show("Error in load Connection String")
            End
        End Try

        'Updater.CheckForUpdate()
        Management.ConnectionString = Setting.ConnectionString
re:
        Dim ls As LoginStatus = Security.Login()
        Select Case ls
            Case LoginStatus.Abort
                End
                Return
            Case LoginStatus.GroupIsBlocked
                VB_Component.MessageBoxFa.Show("Access Denied!")
                GoTo re
            Case LoginStatus.UserIsDisabled
                VB_Component.MessageBoxFa.Show("Your Account is Inactive!.")
                GoTo re
            Case LoginStatus.UsernameOrPasswordIsInvalid
                VB_Component.MessageBoxFa.Show("Incorrect USername or Password!.")
                GoTo re
        End Select

        Setting.Srl_User = Security.LoggedInUser("srl")
        Setting.UserName = Security.LoggedInUser("Username")

        Dim s As New SplashScreen1
        s.ShowDialog()
        Security.ApplyPermission(Me)
        Application.DoEvents()

        ToolStripManager.Renderer = New CS_Component.Office2007Renderer()
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Size = New Drawing.Size(SystemInformation.WorkingArea.Width, SystemInformation.WorkingArea.Height)
        Me.BringToFront()
        Application.DoEvents()
        FormBtnState = BtnState.BaseInfo
        InitPanels()
        pic_Azaraksh_Click(Nothing, Nothing)

        De3DAll()
        VAC.Location = New Point(Me.Location.X + Me.Width - 170, Me.Location.Y + 30)
        TaskPane_Action.UseCustomTheme("Alfa.dll")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Main))
       
    End Sub
   
  

    Private Sub btn_Minimiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Minimiz.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        End
    End Sub

    Sub InitPanels()
        UnvisiblePAnels()

        Panel_Act.Location = New System.Drawing.Point(Panel1.Location.X + 40, Panel1.Location.Y - 482)
        Panel_Setting.Location = New System.Drawing.Point(Panel1.Location.X + 40, Panel1.Location.Y - 482)
        Panel_Report.Location = New System.Drawing.Point(Panel1.Location.X + 40, Panel1.Location.Y - 482)
        Panel_BaseInfo.Location = New System.Drawing.Point(Panel1.Location.X + 40, Panel1.Location.Y - 482)

        Panel_Act.Size = New Size(772, 482)
        Panel_Setting.Size = New Size(772, 482)
        Panel_Report.Size = New Size(772, 482)
        Panel_BaseInfo.Size = New Size(772, 482)

        Select Case FormBtnState
            Case BtnState.BaseInfo
                Panel_BaseInfo.Visible = True
            Case BtnState.Setting
                Panel_Setting.Visible = True
            Case BtnState.Action
                Panel_Act.Visible = True
            Case BtnState.Report
                Panel_Report.Visible = True
        End Select

        If Panel_BaseInfo.Visible = True Or Panel_Setting.Visible = True Or Panel_Act.Visible = True Or Panel_Report.Visible = True Then
            pic_Azaraksh.Location = New System.Drawing.Point(10, 30)
            pic_Azaraksh.Size = New Size(130, 100)
        End If
    End Sub

    Sub De3DAll()
        btn_BaseInfo.BorderStyle = BorderStyle.None
        btn_Action.BorderStyle = BorderStyle.None
        btn_Report.BorderStyle = BorderStyle.None
        Btn_Setting.BorderStyle = BorderStyle.None
    End Sub

    Private Sub btn_BaseInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BaseInfo.Click
        FormBtnState = BtnState.BaseInfo
        InitPanels()
        De3DAll()
        btn_BaseInfo.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub btn_Action_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Action.Click
        FormBtnState = BtnState.Action
        InitPanels()
        De3DAll()
        btn_Action.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub btn_Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Report.Click
        FormBtnState = BtnState.Report
        InitPanels()
        De3DAll()
        btn_Report.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub Btn_Setting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Setting.Click
        FormBtnState = BtnState.Setting
        InitPanels()
        De3DAll()
        Btn_Setting.BorderStyle = BorderStyle.Fixed3D
    End Sub

  

    Private Sub btn_User_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_User.Click
        Security.Users(Me)
    End Sub

    Private Sub btn_GroupUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GroupUser.Click
        Security.Groups(Me)
    End Sub

    Private Sub btn_LimitTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LimitTitle.Click
        Security.Roles(Me)
    End Sub

    Private Sub btn_GroupLimit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GroupLimit.Click
        Security.RoleGroups(Me)
    End Sub

    Private Sub btn_FormLimits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FormLimits.Click
        Security.Permission(Me, System.Reflection.Assembly.GetExecutingAssembly)
    End Sub

    

 

    Private Sub btn_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exit.Click
        If MessageBox.Show("Are you sure you want to exit the application?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Sub UnvisiblePAnels()
        Panel_Act.Visible = False
        Panel_Setting.Visible = False
        Panel_Report.Visible = False
        Panel_BaseInfo.Visible = False

    End Sub

    Private Sub pic_Azaraksh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic_Azaraksh.Click
        UnvisiblePAnels()
        pic_Azaraksh.Location = New System.Drawing.Point(Panel1.Location.X, Panel1.Location.Y - 520)
        pic_Azaraksh.Size = New Size(850, 520)
    End Sub

    Private Sub VAC_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VAC.MouseDown
        FirstX = e.Location.X
        FirstY = e.Location.Y
        DoDrag = True
    End Sub

    Private Sub VAC_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VAC.MouseUp
        DoDrag = False
    End Sub

    Private Sub VAC_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles VAC.MouseMove
        If DoDrag Then
            VAC.Location = New Point(VAC.Location.X + e.Location.X - FirstX, VAC.Location.Y + e.Location.Y - FirstY)
        End If
    End Sub

  

  


    Private Sub btn_Backup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Backup.Click
        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.Cancel Then
            Return
        End If

        Dim bl As New VB_Component.BackgroundLoading(AddressOf DoBackUp, "The system is backing up the database ")
        bl.Start()
        Me.BringToFront()
    End Sub

    Private Sub DoBackUp()
        Dim path As String = FolderBrowserDialog1.SelectedPath
        If path.Trim() = "" Then
            Return
        End If
        path = path + "\\" + Setting.TarikheJary.Replace("/", "") + "_Nama_PM.bak"
        DataBase.BackUp(Setting.ConnectionString, "Nama_MIS", path)
    End Sub

    Private Sub VistaButton2_Click(sender As Object, e As EventArgs) Handles VistaButton2.Click
        Dim Frm_Customer As Frm_Customer = New Frm_Customer()
        Frm_Customer.ShowDialog()
    End Sub

    Private Sub VistaButton3_Click(sender As Object, e As EventArgs)
        Dim Frm_Service As Frm_ServiceCategory = New Frm_ServiceCategory()
        Frm_Service.ShowDialog()
    End Sub


    Private Sub VistaButton5_Click(sender As Object, e As EventArgs) Handles VistaButton5.Click
        Dim Frm_Order As Frm_Order = New Frm_Order(-1)
        Frm_Order.ShowDialog()
    End Sub

    Private Sub VistaButton6_Click(sender As Object, e As EventArgs) Handles VistaButton3.Click
        Dim Frm_Ordervw As Frm_OrderVw = New Frm_OrderVw()
        Frm_Ordervw.ShowDialog()
    End Sub

    Private Sub v(sender As Object, e As EventArgs)

    End Sub

    Private Sub VistaButton7_Click(sender As Object, e As EventArgs) Handles VistaButton7.Click
        Dim Frm_Services As Frm_Services = New Frm_Services()
        Frm_Services.ShowDialog()
    End Sub

    Private Sub btn_MonthluReport_Click(sender As Object, e As EventArgs) Handles btn_MonthluReport.Click
        Dim frm As Frm_MonthlyReport = New Frm_MonthlyReport()
        frm.ShowDialog()
    End Sub

    Private Sub VistaButton4_Click_1(sender As Object, e As EventArgs) Handles VistaButton4.Click
        Dim frm As Frm_ServiceCategory = New Frm_ServiceCategory()
        frm.ShowDialog()
    End Sub

    Private Sub VistaButton6_Click_1(sender As Object, e As EventArgs) Handles VistaButton6.Click
        Dim frm As Frm_OrderStatus = New Frm_OrderStatus()
        frm.ShowDialog()
    End Sub

    Private Sub VistaButton9_Click(sender As Object, e As EventArgs) Handles VistaButton9.Click
        Dim frm As Frm_OrderItemVw = New Frm_OrderItemVw()
        frm.ShowDialog()
    End Sub

    Private Sub btn_PrintCarpetLable_Click(sender As Object, e As EventArgs)
        Dim frm As Frm_CarpetTagPrint = New Frm_CarpetTagPrint()
        frm.ShowDialog()
    End Sub

    Private Sub VistaButton13_Click(sender As Object, e As EventArgs) Handles VistaButton13.Click
        Dim frm As Frm_MonthlyChart = New Frm_MonthlyChart()
        frm.ShowDialog()
    End Sub

    Private Sub btn_printLable_Click(sender As Object, e As EventArgs) Handles btn_printLable.Click
        Dim frm As Frm_CarpetTagPrint = New Frm_CarpetTagPrint()
        frm.ShowDialog()
    End Sub

    Private Sub VistaButton14_Click(sender As Object, e As EventArgs) Handles VistaButton14.Click
        Dim frm As Frm_ChangeStatus = New Frm_ChangeStatus()
        frm.Show()
    End Sub
End Class
