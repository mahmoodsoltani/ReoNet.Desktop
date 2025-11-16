Imports System.Drawing.Drawing2D
Imports System.IO.Ports
Imports VB_Component


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
                VB_Component.MessageBoxFa.Show("ورود گروه شما به سیستم مجاز نیست.")
                GoTo re
            Case LoginStatus.UserIsDisabled
                VB_Component.MessageBoxFa.Show("حساب کاربری شما غیر فعال می باشد.")
                GoTo re
            Case LoginStatus.UsernameOrPasswordIsInvalid
                VB_Component.MessageBoxFa.Show("نام کاربری یا رمز عبور صحیح نیست.")
                GoTo re
        End Select
        If Security.LoggedInUser("Srl_Acc_Ashkhas") Is DBNull.Value Then
            MessageBoxFa.Show("این کاربر جزء پرسنل نمی باشد. لطفا به مدیر سیستم مراجعه نمائید.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GoTo re
        End If
        Setting.Srl_User = Security.LoggedInUser("Srl_Acc_Ashkhas")
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
        pic_Azaraksh_Click(Nothing, Nothing)
        VAC.Location = New Point(Me.Location.X + Me.Width - 170, Me.Location.Y + 30)
        ScrollingText1.Size = New Size(850, ScrollingText1.Size.Height)
        ScrollingText1.Location = New Point(Panel1.Location.X + 0, ScrollingText1.Location.Y)
        TaskPane_Report.UseCustomTheme("Alfa.dll")
        TaskPane_BaeInfo.UseCustomTheme("Alfa.dll")
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

        Panel_Action.Location = New System.Drawing.Point(Panel1.Location.X + 40, Panel1.Location.Y - 482)
        Panel_Setting.Location = New System.Drawing.Point(Panel1.Location.X + 40, Panel1.Location.Y - 482)
        Panel_Report.Location = New System.Drawing.Point(Panel1.Location.X + 40, Panel1.Location.Y - 482)
        Panel_BaseInfo.Location = New System.Drawing.Point(Panel1.Location.X + 40, Panel1.Location.Y - 482)


        Panel_Action.Size = New Size(772, 482)
        Panel_Setting.Size = New Size(772, 482)
        Panel_Report.Size = New Size(772, 482)
        Panel_BaseInfo.Size = New Size(772, 482)

        Select Case FormBtnState
            Case BtnState.BaseInfo
                Panel_BaseInfo.Visible = True
            Case BtnState.Setting
                Panel_Setting.Visible = True
            Case BtnState.Action
                Panel_Action.Visible = True
            Case BtnState.Report
                Panel_Report.Visible = True
        End Select

        If Panel_BaseInfo.Visible = True Or Panel_Setting.Visible = True Or Panel_Action.Visible = True Or Panel_Report.Visible = True Then
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
        If MessageBoxFa.Show("مايل به خروج از نرم افزار هستيد؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Sub UnvisiblePAnels()
        Panel_Action.Visible = False
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

        Dim bl As New VB_Component.BackgroundLoading(AddressOf DoBackUp, "سیستم در حال پشتیبان گیری از پایگاه داده ")
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

   
  



End Class
