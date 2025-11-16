<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_User
    Inherits VB_Component.BaseForm_Info

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chk_Enabled = New System.Windows.Forms.CheckBox()
        Me.txt_Name = New CS_Component.TextBox()
        Me.txt_Family = New CS_Component.TextBox()
        Me.txt_Username = New CS_Component.TextBox()
        Me.txt_Password = New CS_Component.TextBox()
        Me.txt_DupPassword = New CS_Component.TextBox()
        Me.clb_Groups = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(15, 272)
        Me.gbx_Buttons.Margin = New System.Windows.Forms.Padding(5)
        Me.gbx_Buttons.Padding = New System.Windows.Forms.Padding(5)
        Me.gbx_Buttons.Size = New System.Drawing.Size(620, 59)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.ImageVerticalAlign = CS_Component.Btn.VerticalAlign.Top
        '
        'btn_Save
        '
        Me.btn_Save.ImageVerticalAlign = CS_Component.Btn.VerticalAlign.Top
        Me.btn_Save.Location = New System.Drawing.Point(503, 20)
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(6)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.CheckBox2)
        Me.gbx_Fields.Controls.Add(Me.CheckBox1)
        Me.gbx_Fields.Controls.Add(Me.Label4)
        Me.gbx_Fields.Controls.Add(Me.clb_Groups)
        Me.gbx_Fields.Controls.Add(Me.txt_DupPassword)
        Me.gbx_Fields.Controls.Add(Me.txt_Password)
        Me.gbx_Fields.Controls.Add(Me.txt_Username)
        Me.gbx_Fields.Controls.Add(Me.txt_Family)
        Me.gbx_Fields.Controls.Add(Me.txt_Name)
        Me.gbx_Fields.Controls.Add(Me.chk_Enabled)
        Me.gbx_Fields.Controls.Add(Me.Label6)
        Me.gbx_Fields.Controls.Add(Me.Label5)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Margin = New System.Windows.Forms.Padding(5)
        Me.gbx_Fields.Padding = New System.Windows.Forms.Padding(5)
        Me.gbx_Fields.Size = New System.Drawing.Size(620, 227)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(294, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Family"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "UserName"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(294, 123)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(294, 157)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Confirmation"
        '
        'chk_Enabled
        '
        Me.chk_Enabled.AutoSize = True
        Me.chk_Enabled.Checked = True
        Me.chk_Enabled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Enabled.Location = New System.Drawing.Point(334, 191)
        Me.chk_Enabled.Margin = New System.Windows.Forms.Padding(4)
        Me.chk_Enabled.Name = "chk_Enabled"
        Me.chk_Enabled.Size = New System.Drawing.Size(110, 25)
        Me.chk_Enabled.TabIndex = 6
        Me.chk_Enabled.Tag = "Enabled"
        Me.chk_Enabled.Text = "Is Enabled"
        Me.chk_Enabled.UseVisualStyleBackColor = True
        '
        'txt_Name
        '
        Me.txt_Name.CheckExistValueInDb = False
        Me.txt_Name.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Name.CurrencyUnit = "ریال"
        Me.txt_Name.DefaultValue = ""
        Me.txt_Name.FillWithMaxInDb = False
        Me.txt_Name.IsRequired = False
        Me.txt_Name.Location = New System.Drawing.Point(412, 17)
        Me.txt_Name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Name.MaxDecimalLength = 2
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Name.Size = New System.Drawing.Size(185, 27)
        Me.txt_Name.SpellControl = Nothing
        Me.txt_Name.TabIndex = 7
        Me.txt_Name.Tag = "FirstName"
        Me.txt_Name.Title = Nothing
        Me.txt_Name.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_Name.UseForData = True
        Me.txt_Name.ValidateCheckExistOnEdit = False
        Me.txt_Name.Value = ""
        '
        'txt_Family
        '
        Me.txt_Family.CheckExistValueInDb = False
        Me.txt_Family.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Family.CurrencyUnit = "ریال"
        Me.txt_Family.DefaultValue = ""
        Me.txt_Family.FillWithMaxInDb = False
        Me.txt_Family.IsRequired = False
        Me.txt_Family.Location = New System.Drawing.Point(412, 51)
        Me.txt_Family.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Family.MaxDecimalLength = 2
        Me.txt_Family.Name = "txt_Family"
        Me.txt_Family.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Family.Size = New System.Drawing.Size(185, 27)
        Me.txt_Family.SpellControl = Nothing
        Me.txt_Family.TabIndex = 8
        Me.txt_Family.Tag = "LastName"
        Me.txt_Family.Title = Nothing
        Me.txt_Family.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_Family.UseForData = True
        Me.txt_Family.ValidateCheckExistOnEdit = False
        Me.txt_Family.Value = ""
        '
        'txt_Username
        '
        Me.txt_Username.CheckExistValueInDb = False
        Me.txt_Username.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Username.CurrencyUnit = "ریال"
        Me.txt_Username.DefaultValue = ""
        Me.txt_Username.FillWithMaxInDb = False
        Me.txt_Username.IsRequired = False
        Me.txt_Username.Location = New System.Drawing.Point(412, 86)
        Me.txt_Username.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Username.MaxDecimalLength = 2
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Username.Size = New System.Drawing.Size(185, 27)
        Me.txt_Username.SpellControl = Nothing
        Me.txt_Username.TabIndex = 9
        Me.txt_Username.Tag = "Username"
        Me.txt_Username.Title = Nothing
        Me.txt_Username.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_Username.UseForData = True
        Me.txt_Username.ValidateCheckExistOnEdit = False
        Me.txt_Username.Value = ""
        '
        'txt_Password
        '
        Me.txt_Password.CheckExistValueInDb = False
        Me.txt_Password.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Password.CurrencyUnit = "ریال"
        Me.txt_Password.DefaultValue = ""
        Me.txt_Password.FillWithMaxInDb = False
        Me.txt_Password.IsRequired = False
        Me.txt_Password.Location = New System.Drawing.Point(441, 120)
        Me.txt_Password.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Password.MaxDecimalLength = 2
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Password.Size = New System.Drawing.Size(157, 27)
        Me.txt_Password.SpellControl = Nothing
        Me.txt_Password.TabIndex = 10
        Me.txt_Password.Tag = ""
        Me.txt_Password.Title = Nothing
        Me.txt_Password.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_Password.UseForData = True
        Me.txt_Password.UseSystemPasswordChar = True
        Me.txt_Password.ValidateCheckExistOnEdit = False
        Me.txt_Password.Value = ""
        '
        'txt_DupPassword
        '
        Me.txt_DupPassword.CheckExistValueInDb = False
        Me.txt_DupPassword.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_DupPassword.CurrencyUnit = "ریال"
        Me.txt_DupPassword.DefaultValue = ""
        Me.txt_DupPassword.FillWithMaxInDb = False
        Me.txt_DupPassword.IsRequired = False
        Me.txt_DupPassword.Location = New System.Drawing.Point(441, 155)
        Me.txt_DupPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_DupPassword.MaxDecimalLength = 2
        Me.txt_DupPassword.Name = "txt_DupPassword"
        Me.txt_DupPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_DupPassword.Size = New System.Drawing.Size(157, 27)
        Me.txt_DupPassword.SpellControl = Nothing
        Me.txt_DupPassword.TabIndex = 11
        Me.txt_DupPassword.Title = Nothing
        Me.txt_DupPassword.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_DupPassword.UseForData = True
        Me.txt_DupPassword.UseSystemPasswordChar = True
        Me.txt_DupPassword.ValidateCheckExistOnEdit = False
        Me.txt_DupPassword.Value = ""
        '
        'clb_Groups
        '
        Me.clb_Groups.FormattingEnabled = True
        Me.clb_Groups.Location = New System.Drawing.Point(13, 40)
        Me.clb_Groups.Margin = New System.Windows.Forms.Padding(4)
        Me.clb_Groups.Name = "clb_Groups"
        Me.clb_Groups.Size = New System.Drawing.Size(273, 158)
        Me.clb_Groups.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 19)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(274, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Groups"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(296, 128)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox1.TabIndex = 14
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(296, 163)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox2.TabIndex = 15
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'frm_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 374)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frm_User"
        Me.TableName = "sec_User"
        Me.Text = "Register User"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_Enabled As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents clb_Groups As System.Windows.Forms.CheckedListBox
    Friend WithEvents txt_DupPassword As CS_Component.TextBox
    Friend WithEvents txt_Password As CS_Component.TextBox
    Friend WithEvents txt_Username As CS_Component.TextBox
    Friend WithEvents txt_Family As CS_Component.TextBox
    Friend WithEvents txt_Name As CS_Component.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
