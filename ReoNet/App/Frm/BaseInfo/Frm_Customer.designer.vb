<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Customer
    Inherits BaseForm_Layer

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New CS_Component.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FamilyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReonetcustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_BaseInfo = New ReoNet.Ds_BaseInfo()
        Me.PmSherkatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_Code = New CS_Component.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_isActive = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New CS_Component.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New VB_Component.ComboBox()
        Me.ReonetgenderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reonet_genderTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_genderTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Mobile = New CS_Component.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Mobile1 = New CS_Component.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New CS_Component.TextBox()
        Me.txt_postcode = New CS_Component.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New CS_Component.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_city = New VB_Component.ComboBox()
        Me.ReonetcityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reonet_cityTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_cityTableAdapter()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox7 = New CS_Component.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox5 = New CS_Component.TextBox()
        Me.Reonet_customerTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_customerTableAdapter()
        Me.chk_isCompany = New System.Windows.Forms.CheckBox()
        Me.lbl_companyname = New System.Windows.Forms.Label()
        Me.txt_companyname = New CS_Component.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_commission = New CS_Component.TextBox()
        Me.pl_Company = New System.Windows.Forms.Panel()
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetcustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmSherkatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetgenderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetcityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pl_Company.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(625, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(872, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(749, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(995, 398)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.pl_Company)
        Me.gbx_Controls.Controls.Add(Me.txt_postcode)
        Me.gbx_Controls.Controls.Add(Me.Label9)
        Me.gbx_Controls.Controls.Add(Me.Label7)
        Me.gbx_Controls.Controls.Add(Me.cmb_city)
        Me.gbx_Controls.Controls.Add(Me.ComboBox1)
        Me.gbx_Controls.Controls.Add(Me.chk_isCompany)
        Me.gbx_Controls.Controls.Add(Me.chk_isActive)
        Me.gbx_Controls.Controls.Add(Me.txt_Mobile1)
        Me.gbx_Controls.Controls.Add(Me.txt_Mobile)
        Me.gbx_Controls.Controls.Add(Me.TextBox7)
        Me.gbx_Controls.Controls.Add(Me.TextBox6)
        Me.gbx_Controls.Controls.Add(Me.TextBox4)
        Me.gbx_Controls.Controls.Add(Me.TextBox5)
        Me.gbx_Controls.Controls.Add(Me.TextBox1)
        Me.gbx_Controls.Controls.Add(Me.Label5)
        Me.gbx_Controls.Controls.Add(Me.txt_Code)
        Me.gbx_Controls.Controls.Add(Me.Label4)
        Me.gbx_Controls.Controls.Add(Me.Label10)
        Me.gbx_Controls.Controls.Add(Me.Label8)
        Me.gbx_Controls.Controls.Add(Me.Label11)
        Me.gbx_Controls.Controls.Add(Me.Label6)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Controls.Add(Me.Label3)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 504)
        Me.gbx_Controls.Size = New System.Drawing.Size(995, 256)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(18, 444)
        Me.gbx_Btn.Size = New System.Drawing.Size(995, 60)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.CodeDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.FamilyDataGridViewTextBoxColumn, Me.MobileDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.ReonetcustomerBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(989, 374)
        Me.DataGridView1.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "srl"
        Me.DataGridViewTextBoxColumn1.HeaderText = "srl"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 150
        '
        'FamilyDataGridViewTextBoxColumn
        '
        Me.FamilyDataGridViewTextBoxColumn.DataPropertyName = "Family"
        Me.FamilyDataGridViewTextBoxColumn.HeaderText = "Family"
        Me.FamilyDataGridViewTextBoxColumn.Name = "FamilyDataGridViewTextBoxColumn"
        Me.FamilyDataGridViewTextBoxColumn.ReadOnly = True
        Me.FamilyDataGridViewTextBoxColumn.Width = 150
        '
        'MobileDataGridViewTextBoxColumn
        '
        Me.MobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile"
        Me.MobileDataGridViewTextBoxColumn.HeaderText = "Mobile"
        Me.MobileDataGridViewTextBoxColumn.Name = "MobileDataGridViewTextBoxColumn"
        Me.MobileDataGridViewTextBoxColumn.ReadOnly = True
        Me.MobileDataGridViewTextBoxColumn.Width = 150
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReonetcustomerBindingSource
        '
        Me.ReonetcustomerBindingSource.DataMember = "reonet_customer"
        Me.ReonetcustomerBindingSource.DataSource = Me.Ds_BaseInfo
        '
        'Ds_BaseInfo
        '
        Me.Ds_BaseInfo.DataSetName = "Ds_BaseInfo"
        Me.Ds_BaseInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PmSherkatBindingSource
        '
        Me.PmSherkatBindingSource.DataMember = "Pm_Sherkat"
        '
        'txt_Code
        '
        Me.txt_Code.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Code.CheckExistValueInDb = False
        Me.txt_Code.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Code.CurrencyUnit = "ریال"
        Me.txt_Code.DefaultValue = ""
        Me.txt_Code.FillWithMaxInDb = False
        Me.txt_Code.IsRequired = True
        Me.txt_Code.Location = New System.Drawing.Point(100, 25)
        Me.txt_Code.MaxDecimalLength = 2
        Me.txt_Code.Name = "txt_Code"
        Me.txt_Code.ReadOnly = True
        Me.txt_Code.Size = New System.Drawing.Size(100, 25)
        Me.txt_Code.SpellControl = Nothing
        Me.txt_Code.TabIndex = 0
        Me.txt_Code.Tag = "Code"
        Me.txt_Code.Text = "0"
        Me.txt_Code.Title = Nothing
        Me.txt_Code.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_Code.UseForData = True
        Me.txt_Code.ValidateCheckExistOnEdit = False
        Me.txt_Code.Value = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Code:"
        '
        'chk_isActive
        '
        Me.chk_isActive.AutoSize = True
        Me.chk_isActive.Checked = True
        Me.chk_isActive.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_isActive.Location = New System.Drawing.Point(900, 26)
        Me.chk_isActive.Name = "chk_isActive"
        Me.chk_isActive.Size = New System.Drawing.Size(84, 22)
        Me.chk_isActive.TabIndex = 10
        Me.chk_isActive.Tag = "isactive"
        Me.chk_isActive.Text = "Is Active"
        Me.chk_isActive.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(231, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Name:"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.CheckExistValueInDb = False
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = ""
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = False
        Me.TextBox1.Location = New System.Drawing.Point(287, 25)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(148, 25)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Tag = "name"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = ""
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(699, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Gender:"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoComplete = True
        Me.ComboBox1.DataSource = Me.ReonetgenderBindingSource
        Me.ComboBox1.DisplayMember = "name"
        Me.ComboBox1.EnterStop = True
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IsRequired = False
        Me.ComboBox1.LimitedToList = True
        Me.ComboBox1.Location = New System.Drawing.Point(762, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.OpenOnFoucus = False
        Me.ComboBox1.Size = New System.Drawing.Size(120, 26)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Tag = "srl_gender"
        Me.ComboBox1.ValueMember = "Srl"
        '
        'ReonetgenderBindingSource
        '
        Me.ReonetgenderBindingSource.DataMember = "reonet_gender"
        Me.ReonetgenderBindingSource.DataSource = Me.Ds_BaseInfo
        '
        'Reonet_genderTableAdapter
        '
        Me.Reonet_genderTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(478, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Mobile:"
        '
        'txt_Mobile
        '
        Me.txt_Mobile.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Mobile.CheckExistValueInDb = False
        Me.txt_Mobile.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Mobile.CurrencyUnit = "ریال"
        Me.txt_Mobile.DefaultValue = ""
        Me.txt_Mobile.FillWithMaxInDb = False
        Me.txt_Mobile.IsRequired = True
        Me.txt_Mobile.Location = New System.Drawing.Point(535, 93)
        Me.txt_Mobile.MaxDecimalLength = 2
        Me.txt_Mobile.Name = "txt_Mobile"
        Me.txt_Mobile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Mobile.Size = New System.Drawing.Size(148, 25)
        Me.txt_Mobile.SpellControl = Nothing
        Me.txt_Mobile.TabIndex = 4
        Me.txt_Mobile.Tag = "tell1"
        Me.txt_Mobile.Title = Nothing
        Me.txt_Mobile.TypeOfContains = CS_Component.TypeOfValues.StringNumber
        Me.txt_Mobile.UseForData = True
        Me.txt_Mobile.ValidateCheckExistOnEdit = False
        Me.txt_Mobile.Value = ""
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(724, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Tell:"
        '
        'txt_Mobile1
        '
        Me.txt_Mobile1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Mobile1.CheckExistValueInDb = False
        Me.txt_Mobile1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Mobile1.CurrencyUnit = "ریال"
        Me.txt_Mobile1.DefaultValue = ""
        Me.txt_Mobile1.FillWithMaxInDb = False
        Me.txt_Mobile1.IsRequired = False
        Me.txt_Mobile1.Location = New System.Drawing.Point(762, 93)
        Me.txt_Mobile1.MaxDecimalLength = 2
        Me.txt_Mobile1.Name = "txt_Mobile1"
        Me.txt_Mobile1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Mobile1.Size = New System.Drawing.Size(120, 25)
        Me.txt_Mobile1.SpellControl = Nothing
        Me.txt_Mobile1.TabIndex = 5
        Me.txt_Mobile1.Tag = "tell2"
        Me.txt_Mobile1.Title = Nothing
        Me.txt_Mobile1.TypeOfContains = CS_Component.TypeOfValues.StringNumber
        Me.txt_Mobile1.UseForData = True
        Me.txt_Mobile1.ValidateCheckExistOnEdit = False
        Me.txt_Mobile1.Value = ""
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(466, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 18)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Address:"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox4.CheckExistValueInDb = False
        Me.TextBox4.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox4.CurrencyUnit = "ریال"
        Me.TextBox4.DefaultValue = ""
        Me.TextBox4.FillWithMaxInDb = False
        Me.TextBox4.IsRequired = False
        Me.TextBox4.Location = New System.Drawing.Point(535, 129)
        Me.TextBox4.MaxDecimalLength = 2
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox4.Size = New System.Drawing.Size(449, 25)
        Me.TextBox4.SpellControl = Nothing
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.Tag = "address"
        Me.TextBox4.Title = Nothing
        Me.TextBox4.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.TextBox4.UseForData = True
        Me.TextBox4.ValidateCheckExistOnEdit = False
        Me.TextBox4.Value = ""
        '
        'txt_postcode
        '
        Me.txt_postcode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_postcode.CheckExistValueInDb = False
        Me.txt_postcode.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_postcode.CurrencyUnit = "ریال"
        Me.txt_postcode.DefaultValue = ""
        Me.txt_postcode.FillWithMaxInDb = False
        Me.txt_postcode.IsRequired = False
        Me.txt_postcode.Location = New System.Drawing.Point(100, 129)
        Me.txt_postcode.MaxDecimalLength = 2
        Me.txt_postcode.Name = "txt_postcode"
        Me.txt_postcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_postcode.Size = New System.Drawing.Size(100, 25)
        Me.txt_postcode.SpellControl = Nothing
        Me.txt_postcode.TabIndex = 6
        Me.txt_postcode.Tag = "postcode"
        Me.txt_postcode.Text = "0"
        Me.txt_postcode.Title = Nothing
        Me.txt_postcode.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_postcode.UseForData = True
        Me.txt_postcode.ValidateCheckExistOnEdit = False
        Me.txt_postcode.Value = 0
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 18)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "PostCode:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Email:"
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox6.CheckExistValueInDb = False
        Me.TextBox6.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox6.CurrencyUnit = "ریال"
        Me.TextBox6.DefaultValue = ""
        Me.TextBox6.FillWithMaxInDb = False
        Me.TextBox6.IsRequired = False
        Me.TextBox6.Location = New System.Drawing.Point(100, 93)
        Me.TextBox6.MaxDecimalLength = 2
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox6.Size = New System.Drawing.Size(335, 25)
        Me.TextBox6.SpellControl = Nothing
        Me.TextBox6.TabIndex = 3
        Me.TextBox6.Tag = "email"
        Me.TextBox6.Title = Nothing
        Me.TextBox6.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.TextBox6.UseForData = True
        Me.TextBox6.ValidateCheckExistOnEdit = False
        Me.TextBox6.Value = ""
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(246, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 18)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "City:"
        '
        'cmb_city
        '
        Me.cmb_city.AutoComplete = True
        Me.cmb_city.DataSource = Me.ReonetcityBindingSource
        Me.cmb_city.DisplayMember = "name"
        Me.cmb_city.EnterStop = True
        Me.cmb_city.FormattingEnabled = True
        Me.cmb_city.IsRequired = False
        Me.cmb_city.LimitedToList = True
        Me.cmb_city.Location = New System.Drawing.Point(287, 128)
        Me.cmb_city.Name = "cmb_city"
        Me.cmb_city.OpenOnFoucus = False
        Me.cmb_city.Size = New System.Drawing.Size(148, 26)
        Me.cmb_city.TabIndex = 7
        Me.cmb_city.Tag = "srl_city"
        Me.cmb_city.ValueMember = "Srl"
        '
        'ReonetcityBindingSource
        '
        Me.ReonetcityBindingSource.DataMember = "reonet_city"
        Me.ReonetcityBindingSource.DataSource = Me.Ds_BaseInfo
        '
        'Reonet_cityTableAdapter
        '
        Me.Reonet_cityTableAdapter.ClearBeforeFill = True
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 18)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Description:"
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox7.CheckExistValueInDb = False
        Me.TextBox7.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox7.CurrencyUnit = "ریال"
        Me.TextBox7.DefaultValue = ""
        Me.TextBox7.FillWithMaxInDb = False
        Me.TextBox7.IsRequired = False
        Me.TextBox7.Location = New System.Drawing.Point(100, 161)
        Me.TextBox7.MaxDecimalLength = 2
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox7.Size = New System.Drawing.Size(884, 75)
        Me.TextBox7.SpellControl = Nothing
        Me.TextBox7.TabIndex = 9
        Me.TextBox7.Tag = "description"
        Me.TextBox7.Title = Nothing
        Me.TextBox7.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.TextBox7.UseForData = True
        Me.TextBox7.ValidateCheckExistOnEdit = False
        Me.TextBox7.Value = ""
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(477, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 18)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Family:"
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox5.CheckExistValueInDb = False
        Me.TextBox5.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox5.CurrencyUnit = "ریال"
        Me.TextBox5.DefaultValue = ""
        Me.TextBox5.FillWithMaxInDb = False
        Me.TextBox5.IsRequired = False
        Me.TextBox5.Location = New System.Drawing.Point(535, 25)
        Me.TextBox5.MaxDecimalLength = 2
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox5.Size = New System.Drawing.Size(148, 25)
        Me.TextBox5.SpellControl = Nothing
        Me.TextBox5.TabIndex = 1
        Me.TextBox5.Tag = "family"
        Me.TextBox5.Title = Nothing
        Me.TextBox5.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.TextBox5.UseForData = True
        Me.TextBox5.ValidateCheckExistOnEdit = False
        Me.TextBox5.Value = ""
        '
        'Reonet_customerTableAdapter
        '
        Me.Reonet_customerTableAdapter.ClearBeforeFill = True
        '
        'chk_isCompany
        '
        Me.chk_isCompany.AutoSize = True
        Me.chk_isCompany.Location = New System.Drawing.Point(47, 65)
        Me.chk_isCompany.Name = "chk_isCompany"
        Me.chk_isCompany.Size = New System.Drawing.Size(89, 22)
        Me.chk_isCompany.TabIndex = 10
        Me.chk_isCompany.Tag = "is_company"
        Me.chk_isCompany.Text = "Company"
        Me.chk_isCompany.UseVisualStyleBackColor = True
        '
        'lbl_companyname
        '
        Me.lbl_companyname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_companyname.AutoSize = True
        Me.lbl_companyname.Location = New System.Drawing.Point(28, 10)
        Me.lbl_companyname.Name = "lbl_companyname"
        Me.lbl_companyname.Size = New System.Drawing.Size(119, 18)
        Me.lbl_companyname.TabIndex = 20
        Me.lbl_companyname.Text = "Company Name:"
        '
        'txt_companyname
        '
        Me.txt_companyname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_companyname.CheckExistValueInDb = False
        Me.txt_companyname.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_companyname.CurrencyUnit = "ریال"
        Me.txt_companyname.DefaultValue = ""
        Me.txt_companyname.FillWithMaxInDb = False
        Me.txt_companyname.IsRequired = False
        Me.txt_companyname.Location = New System.Drawing.Point(151, 3)
        Me.txt_companyname.MaxDecimalLength = 2
        Me.txt_companyname.Name = "txt_companyname"
        Me.txt_companyname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_companyname.Size = New System.Drawing.Size(148, 25)
        Me.txt_companyname.SpellControl = Nothing
        Me.txt_companyname.TabIndex = 0
        Me.txt_companyname.Tag = "companyname"
        Me.txt_companyname.Title = Nothing
        Me.txt_companyname.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_companyname.UseForData = True
        Me.txt_companyname.ValidateCheckExistOnEdit = False
        Me.txt_companyname.Value = ""
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(305, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 18)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "Commission:"
        '
        'txt_commission
        '
        Me.txt_commission.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_commission.CheckExistValueInDb = False
        Me.txt_commission.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_commission.CurrencyUnit = "ریال"
        Me.txt_commission.DefaultValue = ""
        Me.txt_commission.FillWithMaxInDb = False
        Me.txt_commission.IsRequired = False
        Me.txt_commission.Location = New System.Drawing.Point(399, 3)
        Me.txt_commission.MaxDecimalLength = 2
        Me.txt_commission.Name = "txt_commission"
        Me.txt_commission.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_commission.Size = New System.Drawing.Size(148, 25)
        Me.txt_commission.SpellControl = Nothing
        Me.txt_commission.TabIndex = 6
        Me.txt_commission.Tag = "commission"
        Me.txt_commission.Text = "0"
        Me.txt_commission.Title = Nothing
        Me.txt_commission.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_commission.UseForData = True
        Me.txt_commission.ValidateCheckExistOnEdit = False
        Me.txt_commission.Value = 0
        '
        'pl_Company
        '
        Me.pl_Company.Controls.Add(Me.txt_companyname)
        Me.pl_Company.Controls.Add(Me.txt_commission)
        Me.pl_Company.Controls.Add(Me.lbl_companyname)
        Me.pl_Company.Controls.Add(Me.Label12)
        Me.pl_Company.Location = New System.Drawing.Point(136, 57)
        Me.pl_Company.Name = "pl_Company"
        Me.pl_Company.Size = New System.Drawing.Size(554, 33)
        Me.pl_Company.TabIndex = 44
        Me.pl_Company.Visible = False
        '
        'Frm_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1023, 801)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Name = "Frm_Customer"
        Me.TableName = "reonet_customer"
        Me.Text = "Customers"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetcustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmSherkatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetgenderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetcityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pl_Company.ResumeLayout(False)
        Me.pl_Company.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents txt_Code As CS_Component.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_isActive As System.Windows.Forms.CheckBox
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmSherkatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As VB_Component.ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Ds_BaseInfo As Ds_BaseInfo
    Friend WithEvents ReonetgenderBindingSource As BindingSource
    Friend WithEvents Reonet_genderTableAdapter As Ds_BaseInfoTableAdapters.reonet_genderTableAdapter
    Friend WithEvents txt_postcode As CS_Component.TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_Mobile1 As CS_Component.TextBox
    Friend WithEvents txt_Mobile As CS_Component.TextBox
    Friend WithEvents TextBox4 As CS_Component.TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As CS_Component.TextBox
    Friend WithEvents cmb_city As VB_Component.ComboBox
    Friend WithEvents ReonetcityBindingSource As BindingSource
    Friend WithEvents Reonet_cityTableAdapter As Ds_BaseInfoTableAdapters.reonet_cityTableAdapter
    Friend WithEvents TextBox7 As CS_Component.TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox5 As CS_Component.TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ReonetcustomerBindingSource As BindingSource
    Friend WithEvents Reonet_customerTableAdapter As Ds_BaseInfoTableAdapters.reonet_customerTableAdapter
    Friend WithEvents chk_isCompany As CheckBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FamilyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MobileDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txt_companyname As CS_Component.TextBox
    Friend WithEvents lbl_companyname As Label
    Friend WithEvents pl_Company As Panel
    Friend WithEvents txt_commission As CS_Component.TextBox
    Friend WithEvents Label12 As Label
End Class
