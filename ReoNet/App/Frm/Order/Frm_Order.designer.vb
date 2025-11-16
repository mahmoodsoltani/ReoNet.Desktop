<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Order
    Inherits BaseForm_Info_Single

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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_itemDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.chk_cash = New System.Windows.Forms.CheckBox()
        Me.cmb_orderStatus = New VB_Component.ComboBox()
        Me.ReonetorderstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_BaseInfo = New ReoNet.Ds_BaseInfo()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pl_SquareMeter = New System.Windows.Forms.Panel()
        Me.chk_circle = New System.Windows.Forms.CheckBox()
        Me.txt_Area = New CS_Component.TextBox()
        Me.lbl_width = New System.Windows.Forms.Label()
        Me.lbl_Length = New System.Windows.Forms.Label()
        Me.lbl_area = New System.Windows.Forms.Label()
        Me.txt_width = New CS_Component.TextBox()
        Me.txt_Length = New CS_Component.TextBox()
        Me.btn_SelectService = New System.Windows.Forms.Button()
        Me.txt_totalPrice = New CS_Component.TextBox()
        Me.txt_Discount = New CS_Component.TextBox()
        Me.txt_RawPrice = New CS_Component.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_Price = New CS_Component.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_Count = New CS_Component.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_count_Weight = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_Description = New CS_Component.TextBox()
        Me.txt_Service = New CS_Component.TextBox()
        Me.txt_Barcode = New CS_Component.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Btn_Add = New CS_Component.Btn()
        Me.DataGridView1 = New CS_Component.DataGridView()
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SrlordermasterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SrlsubserviceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SrlorderstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IscashDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deliverydate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Print = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReonetorderdetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Order = New ReoNet.Ds_Order()
        Me.lbl_customerName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_CustomerMobile = New CS_Component.TextBox()
        Me.txt_customerCode = New CS_Component.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmb_customer = New VB_Component.ComboBox()
        Me.ReonetcustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_OrderDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ordernumber = New CS_Component.TextBox()
        Me.ReonetcustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_BaseInfo1 = New ReoNet.Ds_BaseInfo()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txt_DeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_OrderTotalPrice = New CS_Component.TextBox()
        Me.txt_DeliveryPrice = New CS_Component.TextBox()
        Me.txt_sum = New CS_Component.TextBox()
        Me.txt_OrderDescription = New CS_Component.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox1 = New CS_Component.TextBox()
        Me.ReonetservicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reonet_servicesTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_servicesTableAdapter()
        Me.Reonet_orderstatusTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_orderstatusTableAdapter()
        Me.Reonet_customerTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_customerTableAdapter()
        Me.Reonet_orderdetailTableAdapter = New ReoNet.Ds_OrderTableAdapters.reonet_orderdetailTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txt_totalDiscount = New CS_Component.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ReonetorderstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pl_SquareMeter.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetorderdetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.ReonetcustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetcustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_BaseInfo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.ReonetservicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 720)
        Me.gbx_Buttons.Size = New System.Drawing.Size(923, 56)
        Me.gbx_Buttons.TabIndex = 4
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(819, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.Panel6)
        Me.gbx_Fields.Controls.Add(Me.Panel4)
        Me.gbx_Fields.Controls.Add(Me.Panel1)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(923, 677)
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txt_itemDeliveryDate)
        Me.Panel1.Controls.Add(Me.chk_cash)
        Me.Panel1.Controls.Add(Me.cmb_orderStatus)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.pl_SquareMeter)
        Me.Panel1.Controls.Add(Me.btn_SelectService)
        Me.Panel1.Controls.Add(Me.txt_totalPrice)
        Me.Panel1.Controls.Add(Me.txt_Discount)
        Me.Panel1.Controls.Add(Me.txt_RawPrice)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txt_Price)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txt_Count)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.lbl_count_Weight)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txt_Description)
        Me.Panel1.Controls.Add(Me.txt_Service)
        Me.Panel1.Controls.Add(Me.txt_Barcode)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Btn_Add)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(3, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(914, 447)
        Me.Panel1.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(358, 149)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 18)
        Me.Label17.TabIndex = 1007
        Me.Label17.Text = "Delivery Date:"
        '
        'txt_itemDeliveryDate
        '
        Me.txt_itemDeliveryDate.CustomFormat = "yyyy/MM/dd"
        Me.txt_itemDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_itemDeliveryDate.Location = New System.Drawing.Point(467, 144)
        Me.txt_itemDeliveryDate.Name = "txt_itemDeliveryDate"
        Me.txt_itemDeliveryDate.Size = New System.Drawing.Size(100, 25)
        Me.txt_itemDeliveryDate.TabIndex = 1006
        '
        'chk_cash
        '
        Me.chk_cash.AutoSize = True
        Me.chk_cash.Location = New System.Drawing.Point(32, 111)
        Me.chk_cash.Name = "chk_cash"
        Me.chk_cash.Size = New System.Drawing.Size(78, 22)
        Me.chk_cash.TabIndex = 1005
        Me.chk_cash.TabStop = False
        Me.chk_cash.Text = "In Cash"
        Me.chk_cash.UseVisualStyleBackColor = True
        '
        'cmb_orderStatus
        '
        Me.cmb_orderStatus.AutoComplete = True
        Me.cmb_orderStatus.DataSource = Me.ReonetorderstatusBindingSource
        Me.cmb_orderStatus.DisplayMember = "title"
        Me.cmb_orderStatus.EnterStop = True
        Me.cmb_orderStatus.FormattingEnabled = True
        Me.cmb_orderStatus.IsRequired = False
        Me.cmb_orderStatus.LimitedToList = True
        Me.cmb_orderStatus.Location = New System.Drawing.Point(112, 146)
        Me.cmb_orderStatus.Name = "cmb_orderStatus"
        Me.cmb_orderStatus.OpenOnFoucus = False
        Me.cmb_orderStatus.Size = New System.Drawing.Size(164, 26)
        Me.cmb_orderStatus.TabIndex = 1004
        Me.cmb_orderStatus.Tag = "srl_service"
        Me.cmb_orderStatus.ValueMember = "Srl"
        '
        'ReonetorderstatusBindingSource
        '
        Me.ReonetorderstatusBindingSource.DataMember = "reonet_orderstatus"
        Me.ReonetorderstatusBindingSource.DataSource = Me.Ds_BaseInfo
        '
        'Ds_BaseInfo
        '
        Me.Ds_BaseInfo.DataSetName = "Ds_BaseInfo"
        Me.Ds_BaseInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(222, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 30)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'pl_SquareMeter
        '
        Me.pl_SquareMeter.Controls.Add(Me.chk_circle)
        Me.pl_SquareMeter.Controls.Add(Me.txt_Area)
        Me.pl_SquareMeter.Controls.Add(Me.lbl_width)
        Me.pl_SquareMeter.Controls.Add(Me.lbl_Length)
        Me.pl_SquareMeter.Controls.Add(Me.lbl_area)
        Me.pl_SquareMeter.Controls.Add(Me.txt_width)
        Me.pl_SquareMeter.Controls.Add(Me.txt_Length)
        Me.pl_SquareMeter.Location = New System.Drawing.Point(20, 39)
        Me.pl_SquareMeter.Name = "pl_SquareMeter"
        Me.pl_SquareMeter.Size = New System.Drawing.Size(556, 40)
        Me.pl_SquareMeter.TabIndex = 2
        '
        'chk_circle
        '
        Me.chk_circle.AutoSize = True
        Me.chk_circle.Location = New System.Drawing.Point(12, 11)
        Me.chk_circle.Name = "chk_circle"
        Me.chk_circle.Size = New System.Drawing.Size(60, 22)
        Me.chk_circle.TabIndex = 1004
        Me.chk_circle.TabStop = False
        Me.chk_circle.Text = "Circle"
        Me.chk_circle.UseVisualStyleBackColor = True
        '
        'txt_Area
        '
        Me.txt_Area.CheckExistValueInDb = False
        Me.txt_Area.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Area.CurrencyUnit = "ریال"
        Me.txt_Area.DefaultValue = ""
        Me.txt_Area.FillWithMaxInDb = False
        Me.txt_Area.IsRequired = False
        Me.txt_Area.Location = New System.Drawing.Point(475, 9)
        Me.txt_Area.MaxDecimalLength = 2
        Me.txt_Area.Name = "txt_Area"
        Me.txt_Area.Size = New System.Drawing.Size(71, 25)
        Me.txt_Area.SpellControl = Nothing
        Me.txt_Area.TabIndex = 200
        Me.txt_Area.Tag = ""
        Me.txt_Area.Text = "0"
        Me.txt_Area.Title = Nothing
        Me.txt_Area.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_Area.UseForData = True
        Me.txt_Area.ValidateCheckExistOnEdit = False
        Me.txt_Area.Value = 0
        '
        'lbl_width
        '
        Me.lbl_width.AutoSize = True
        Me.lbl_width.Location = New System.Drawing.Point(90, 11)
        Me.lbl_width.Name = "lbl_width"
        Me.lbl_width.Size = New System.Drawing.Size(50, 18)
        Me.lbl_width.TabIndex = 1003
        Me.lbl_width.Text = "Width:"
        '
        'lbl_Length
        '
        Me.lbl_Length.AutoSize = True
        Me.lbl_Length.Location = New System.Drawing.Point(264, 13)
        Me.lbl_Length.Name = "lbl_Length"
        Me.lbl_Length.Size = New System.Drawing.Size(57, 18)
        Me.lbl_Length.TabIndex = 1003
        Me.lbl_Length.Text = "Length:"
        '
        'lbl_area
        '
        Me.lbl_area.AutoSize = True
        Me.lbl_area.Location = New System.Drawing.Point(431, 13)
        Me.lbl_area.Name = "lbl_area"
        Me.lbl_area.Size = New System.Drawing.Size(43, 18)
        Me.lbl_area.TabIndex = 1003
        Me.lbl_area.Text = "Area:"
        '
        'txt_width
        '
        Me.txt_width.CheckExistValueInDb = False
        Me.txt_width.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_width.CurrencyUnit = "ریال"
        Me.txt_width.DefaultValue = ""
        Me.txt_width.FillWithMaxInDb = False
        Me.txt_width.IsRequired = False
        Me.txt_width.Location = New System.Drawing.Point(162, 7)
        Me.txt_width.MaxDecimalLength = 2
        Me.txt_width.Name = "txt_width"
        Me.txt_width.Size = New System.Drawing.Size(65, 25)
        Me.txt_width.SpellControl = Nothing
        Me.txt_width.TabIndex = 0
        Me.txt_width.Tag = ""
        Me.txt_width.Text = "0"
        Me.txt_width.Title = Nothing
        Me.txt_width.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_width.UseForData = True
        Me.txt_width.ValidateCheckExistOnEdit = False
        Me.txt_width.Value = 0
        '
        'txt_Length
        '
        Me.txt_Length.CheckExistValueInDb = False
        Me.txt_Length.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Length.CurrencyUnit = "ریال"
        Me.txt_Length.DefaultValue = ""
        Me.txt_Length.FillWithMaxInDb = False
        Me.txt_Length.IsRequired = False
        Me.txt_Length.Location = New System.Drawing.Point(330, 9)
        Me.txt_Length.MaxDecimalLength = 2
        Me.txt_Length.Name = "txt_Length"
        Me.txt_Length.Size = New System.Drawing.Size(65, 25)
        Me.txt_Length.SpellControl = Nothing
        Me.txt_Length.TabIndex = 1
        Me.txt_Length.Tag = ""
        Me.txt_Length.Text = "0"
        Me.txt_Length.Title = Nothing
        Me.txt_Length.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_Length.UseForData = True
        Me.txt_Length.ValidateCheckExistOnEdit = False
        Me.txt_Length.Value = 0
        '
        'btn_SelectService
        '
        Me.btn_SelectService.AutoSize = True
        Me.btn_SelectService.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_SelectService.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_SelectService.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SelectService.Location = New System.Drawing.Point(432, 10)
        Me.btn_SelectService.Name = "btn_SelectService"
        Me.btn_SelectService.Size = New System.Drawing.Size(35, 29)
        Me.btn_SelectService.TabIndex = 1
        Me.btn_SelectService.Text = "..."
        Me.btn_SelectService.UseVisualStyleBackColor = False
        '
        'txt_totalPrice
        '
        Me.txt_totalPrice.CheckExistValueInDb = False
        Me.txt_totalPrice.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_totalPrice.CurrencyUnit = "ریال"
        Me.txt_totalPrice.DefaultValue = ""
        Me.txt_totalPrice.FillWithMaxInDb = False
        Me.txt_totalPrice.IsRequired = False
        Me.txt_totalPrice.Location = New System.Drawing.Point(769, 108)
        Me.txt_totalPrice.MaxDecimalLength = 2
        Me.txt_totalPrice.Name = "txt_totalPrice"
        Me.txt_totalPrice.Size = New System.Drawing.Size(71, 25)
        Me.txt_totalPrice.SpellControl = Nothing
        Me.txt_totalPrice.TabIndex = 100
        Me.txt_totalPrice.Tag = ""
        Me.txt_totalPrice.Text = "0"
        Me.txt_totalPrice.Title = Nothing
        Me.txt_totalPrice.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_totalPrice.UseForData = True
        Me.txt_totalPrice.ValidateCheckExistOnEdit = False
        Me.txt_totalPrice.Value = 0!
        '
        'txt_Discount
        '
        Me.txt_Discount.CheckExistValueInDb = False
        Me.txt_Discount.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Discount.CurrencyUnit = "ریال"
        Me.txt_Discount.DefaultValue = ""
        Me.txt_Discount.FillWithMaxInDb = False
        Me.txt_Discount.IsRequired = False
        Me.txt_Discount.Location = New System.Drawing.Point(769, 77)
        Me.txt_Discount.MaxDecimalLength = 2
        Me.txt_Discount.Name = "txt_Discount"
        Me.txt_Discount.Size = New System.Drawing.Size(71, 25)
        Me.txt_Discount.SpellControl = Nothing
        Me.txt_Discount.TabIndex = 100
        Me.txt_Discount.Tag = ""
        Me.txt_Discount.Text = "0"
        Me.txt_Discount.Title = Nothing
        Me.txt_Discount.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_Discount.UseForData = True
        Me.txt_Discount.ValidateCheckExistOnEdit = False
        Me.txt_Discount.Value = 0!
        '
        'txt_RawPrice
        '
        Me.txt_RawPrice.CheckExistValueInDb = False
        Me.txt_RawPrice.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_RawPrice.CurrencyUnit = "ریال"
        Me.txt_RawPrice.DefaultValue = ""
        Me.txt_RawPrice.FillWithMaxInDb = False
        Me.txt_RawPrice.IsRequired = False
        Me.txt_RawPrice.Location = New System.Drawing.Point(769, 47)
        Me.txt_RawPrice.MaxDecimalLength = 2
        Me.txt_RawPrice.Name = "txt_RawPrice"
        Me.txt_RawPrice.Size = New System.Drawing.Size(71, 25)
        Me.txt_RawPrice.SpellControl = Nothing
        Me.txt_RawPrice.TabIndex = 100
        Me.txt_RawPrice.Tag = ""
        Me.txt_RawPrice.Text = "0"
        Me.txt_RawPrice.Title = Nothing
        Me.txt_RawPrice.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_RawPrice.UseForData = True
        Me.txt_RawPrice.ValidateCheckExistOnEdit = False
        Me.txt_RawPrice.Value = 0!
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(687, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 18)
        Me.Label10.TabIndex = 1003
        Me.Label10.Text = "Total Price:"
        '
        'txt_Price
        '
        Me.txt_Price.CheckExistValueInDb = False
        Me.txt_Price.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Price.CurrencyUnit = "ریال"
        Me.txt_Price.DefaultValue = ""
        Me.txt_Price.FillWithMaxInDb = False
        Me.txt_Price.IsRequired = False
        Me.txt_Price.Location = New System.Drawing.Point(769, 16)
        Me.txt_Price.MaxDecimalLength = 2
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.Size = New System.Drawing.Size(71, 25)
        Me.txt_Price.SpellControl = Nothing
        Me.txt_Price.TabIndex = 8
        Me.txt_Price.Tag = ""
        Me.txt_Price.Text = "0"
        Me.txt_Price.Title = Nothing
        Me.txt_Price.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_Price.UseForData = True
        Me.txt_Price.ValidateCheckExistOnEdit = False
        Me.txt_Price.Value = 0!
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(700, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 1003
        Me.Label8.Text = "Discount:"
        '
        'txt_Count
        '
        Me.txt_Count.CheckExistValueInDb = False
        Me.txt_Count.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Count.CurrencyUnit = "ریال"
        Me.txt_Count.DefaultValue = "1"
        Me.txt_Count.FillWithMaxInDb = False
        Me.txt_Count.IsRequired = False
        Me.txt_Count.Location = New System.Drawing.Point(627, 47)
        Me.txt_Count.MaxDecimalLength = 2
        Me.txt_Count.Name = "txt_Count"
        Me.txt_Count.Size = New System.Drawing.Size(45, 25)
        Me.txt_Count.SpellControl = Nothing
        Me.txt_Count.TabIndex = 3
        Me.txt_Count.Tag = ""
        Me.txt_Count.Text = "1"
        Me.txt_Count.Title = Nothing
        Me.txt_Count.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_Count.UseForData = True
        Me.txt_Count.ValidateCheckExistOnEdit = False
        Me.txt_Count.Value = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(693, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 18)
        Me.Label12.TabIndex = 1003
        Me.Label12.Text = "Raw Price:"
        '
        'lbl_count_Weight
        '
        Me.lbl_count_Weight.AutoSize = True
        Me.lbl_count_Weight.Location = New System.Drawing.Point(580, 51)
        Me.lbl_count_Weight.Name = "lbl_count_Weight"
        Me.lbl_count_Weight.Size = New System.Drawing.Size(51, 18)
        Me.lbl_count_Weight.TabIndex = 1003
        Me.lbl_count_Weight.Text = "Count:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 1003
        Me.Label5.Text = "Status:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(725, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 18)
        Me.Label9.TabIndex = 1003
        Me.Label9.Text = "Price:"
        '
        'txt_Description
        '
        Me.txt_Description.CheckExistValueInDb = False
        Me.txt_Description.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Description.CurrencyUnit = "ریال"
        Me.txt_Description.DefaultValue = ""
        Me.txt_Description.FillWithMaxInDb = False
        Me.txt_Description.IsRequired = False
        Me.txt_Description.Location = New System.Drawing.Point(112, 81)
        Me.txt_Description.MaxDecimalLength = 2
        Me.txt_Description.Multiline = True
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Description.Size = New System.Drawing.Size(455, 52)
        Me.txt_Description.SpellControl = Nothing
        Me.txt_Description.TabIndex = 5
        Me.txt_Description.Tag = ""
        Me.txt_Description.Title = Nothing
        Me.txt_Description.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_Description.UseForData = True
        Me.txt_Description.ValidateCheckExistOnEdit = False
        Me.txt_Description.Value = ""
        '
        'txt_Service
        '
        Me.txt_Service.CheckExistValueInDb = False
        Me.txt_Service.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Service.CurrencyUnit = "ریال"
        Me.txt_Service.DefaultValue = ""
        Me.txt_Service.FillWithMaxInDb = False
        Me.txt_Service.IsRequired = False
        Me.txt_Service.Location = New System.Drawing.Point(470, 12)
        Me.txt_Service.MaxDecimalLength = 2
        Me.txt_Service.Name = "txt_Service"
        Me.txt_Service.ReadOnly = True
        Me.txt_Service.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Service.Size = New System.Drawing.Size(241, 25)
        Me.txt_Service.SpellControl = Nothing
        Me.txt_Service.TabIndex = 0
        Me.txt_Service.Tag = ""
        Me.txt_Service.Title = Nothing
        Me.txt_Service.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_Service.UseForData = True
        Me.txt_Service.ValidateCheckExistOnEdit = False
        Me.txt_Service.Value = ""
        '
        'txt_Barcode
        '
        Me.txt_Barcode.CheckExistValueInDb = False
        Me.txt_Barcode.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Barcode.CurrencyUnit = "ریال"
        Me.txt_Barcode.DefaultValue = ""
        Me.txt_Barcode.FillWithMaxInDb = False
        Me.txt_Barcode.IsRequired = False
        Me.txt_Barcode.Location = New System.Drawing.Point(83, 10)
        Me.txt_Barcode.MaxDecimalLength = 2
        Me.txt_Barcode.Name = "txt_Barcode"
        Me.txt_Barcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Barcode.Size = New System.Drawing.Size(133, 25)
        Me.txt_Barcode.SpellControl = Nothing
        Me.txt_Barcode.TabIndex = 0
        Me.txt_Barcode.Tag = ""
        Me.txt_Barcode.Text = "0"
        Me.txt_Barcode.Title = Nothing
        Me.txt_Barcode.TypeOfContains = CS_Component.TypeOfValues.StringNumber
        Me.txt_Barcode.UseForData = True
        Me.txt_Barcode.ValidateCheckExistOnEdit = False
        Me.txt_Barcode.Value = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 84)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 18)
        Me.Label11.TabIndex = 1003
        Me.Label11.Text = "Description : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 1003
        Me.Label1.Text = "Barcode:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(360, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 18)
        Me.Label20.TabIndex = 1003
        Me.Label20.Text = "Service:"
        '
        'Btn_Add
        '
        Me.Btn_Add.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Add.HeaderText = "Add"
        Me.Btn_Add.Location = New System.Drawing.Point(763, 149)
        Me.Btn_Add.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(77, 24)
        Me.Btn_Add.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.CodeDataGridViewTextBoxColumn, Me.SrlordermasterDataGridViewTextBoxColumn, Me.SrlsubserviceDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.WidthDataGridViewTextBoxColumn, Me.LengthDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn4, Me.TotalpriceDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.SrlorderstatusDataGridViewTextBoxColumn, Me.IscashDataGridViewCheckBoxColumn, Me.discount, Me.deliverydate, Me.Edit, Me.Delete, Me.Print})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.ReonetorderdetailBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 187)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(912, 258)
        Me.DataGridView1.TabIndex = 5
        Me.DataGridView1.TabStop = False
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SrlordermasterDataGridViewTextBoxColumn
        '
        Me.SrlordermasterDataGridViewTextBoxColumn.DataPropertyName = "srl_ordermaster"
        Me.SrlordermasterDataGridViewTextBoxColumn.HeaderText = "srl_ordermaster"
        Me.SrlordermasterDataGridViewTextBoxColumn.Name = "SrlordermasterDataGridViewTextBoxColumn"
        Me.SrlordermasterDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlordermasterDataGridViewTextBoxColumn.Visible = False
        '
        'SrlsubserviceDataGridViewTextBoxColumn
        '
        Me.SrlsubserviceDataGridViewTextBoxColumn.DataPropertyName = "Srl_subservice"
        Me.SrlsubserviceDataGridViewTextBoxColumn.HeaderText = "Srl_subservice"
        Me.SrlsubserviceDataGridViewTextBoxColumn.Name = "SrlsubserviceDataGridViewTextBoxColumn"
        Me.SrlsubserviceDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlsubserviceDataGridViewTextBoxColumn.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "service"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Service"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "count"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Count"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'WidthDataGridViewTextBoxColumn
        '
        Me.WidthDataGridViewTextBoxColumn.DataPropertyName = "width"
        Me.WidthDataGridViewTextBoxColumn.HeaderText = "width"
        Me.WidthDataGridViewTextBoxColumn.Name = "WidthDataGridViewTextBoxColumn"
        Me.WidthDataGridViewTextBoxColumn.ReadOnly = True
        Me.WidthDataGridViewTextBoxColumn.Visible = False
        '
        'LengthDataGridViewTextBoxColumn
        '
        Me.LengthDataGridViewTextBoxColumn.DataPropertyName = "length"
        Me.LengthDataGridViewTextBoxColumn.HeaderText = "length"
        Me.LengthDataGridViewTextBoxColumn.Name = "LengthDataGridViewTextBoxColumn"
        Me.LengthDataGridViewTextBoxColumn.ReadOnly = True
        Me.LengthDataGridViewTextBoxColumn.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "area"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Area"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'TotalpriceDataGridViewTextBoxColumn
        '
        Me.TotalpriceDataGridViewTextBoxColumn.DataPropertyName = "totalprice"
        Me.TotalpriceDataGridViewTextBoxColumn.HeaderText = "Total Price "
        Me.TotalpriceDataGridViewTextBoxColumn.Name = "TotalpriceDataGridViewTextBoxColumn"
        Me.TotalpriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Visible = False
        '
        'SrlorderstatusDataGridViewTextBoxColumn
        '
        Me.SrlorderstatusDataGridViewTextBoxColumn.DataPropertyName = "Srl_orderstatus"
        Me.SrlorderstatusDataGridViewTextBoxColumn.HeaderText = "Srl_orderstatus"
        Me.SrlorderstatusDataGridViewTextBoxColumn.Name = "SrlorderstatusDataGridViewTextBoxColumn"
        Me.SrlorderstatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlorderstatusDataGridViewTextBoxColumn.Visible = False
        '
        'IscashDataGridViewCheckBoxColumn
        '
        Me.IscashDataGridViewCheckBoxColumn.DataPropertyName = "iscash"
        Me.IscashDataGridViewCheckBoxColumn.HeaderText = "iscash"
        Me.IscashDataGridViewCheckBoxColumn.Name = "IscashDataGridViewCheckBoxColumn"
        Me.IscashDataGridViewCheckBoxColumn.ReadOnly = True
        Me.IscashDataGridViewCheckBoxColumn.Visible = False
        '
        'discount
        '
        Me.discount.DataPropertyName = "discount"
        Me.discount.HeaderText = "Dis"
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = True
        '
        'deliverydate
        '
        Me.deliverydate.DataPropertyName = "deliverydate"
        Me.deliverydate.HeaderText = "deliverydate"
        Me.deliverydate.Name = "deliverydate"
        Me.deliverydate.ReadOnly = True
        Me.deliverydate.Visible = False
        '
        'Edit
        '
        Me.Edit.HeaderText = ""
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Width = 27
        '
        'Delete
        '
        Me.Delete.HeaderText = ""
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Width = 27
        '
        'Print
        '
        Me.Print.DataPropertyName = "srl"
        Me.Print.HeaderText = ""
        Me.Print.Name = "Print"
        Me.Print.ReadOnly = True
        Me.Print.Width = 27
        '
        'ReonetorderdetailBindingSource
        '
        Me.ReonetorderdetailBindingSource.DataMember = "reonet_orderdetail"
        Me.ReonetorderdetailBindingSource.DataSource = Me.Ds_Order
        '
        'Ds_Order
        '
        Me.Ds_Order.DataSetName = "Ds_Order"
        Me.Ds_Order.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbl_customerName
        '
        Me.lbl_customerName.AutoSize = True
        Me.lbl_customerName.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_customerName.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbl_customerName.Location = New System.Drawing.Point(611, 46)
        Me.lbl_customerName.Name = "lbl_customerName"
        Me.lbl_customerName.Size = New System.Drawing.Size(0, 18)
        Me.lbl_customerName.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(406, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 18)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Mobile:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(264, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Customer:"
        '
        'txt_CustomerMobile
        '
        Me.txt_CustomerMobile.CheckExistValueInDb = True
        Me.txt_CustomerMobile.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_CustomerMobile.CurrencyUnit = "ریال"
        Me.txt_CustomerMobile.DefaultValue = ""
        Me.txt_CustomerMobile.FillWithMaxInDb = False
        Me.txt_CustomerMobile.IsRequired = True
        Me.txt_CustomerMobile.Location = New System.Drawing.Point(461, 43)
        Me.txt_CustomerMobile.MaxDecimalLength = 2
        Me.txt_CustomerMobile.Name = "txt_CustomerMobile"
        Me.txt_CustomerMobile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_CustomerMobile.Size = New System.Drawing.Size(104, 25)
        Me.txt_CustomerMobile.SpellControl = Nothing
        Me.txt_CustomerMobile.TabIndex = 2
        Me.txt_CustomerMobile.Tag = ""
        Me.txt_CustomerMobile.Title = Nothing
        Me.txt_CustomerMobile.TypeOfContains = CS_Component.TypeOfValues.StringNumber
        Me.txt_CustomerMobile.UseForData = True
        Me.txt_CustomerMobile.ValidateCheckExistOnEdit = False
        Me.txt_CustomerMobile.Value = ""
        '
        'txt_customerCode
        '
        Me.txt_customerCode.CheckExistValueInDb = True
        Me.txt_customerCode.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_customerCode.CurrencyUnit = "ریال"
        Me.txt_customerCode.DefaultValue = ""
        Me.txt_customerCode.FillWithMaxInDb = False
        Me.txt_customerCode.IsRequired = True
        Me.txt_customerCode.Location = New System.Drawing.Point(313, 42)
        Me.txt_customerCode.MaxDecimalLength = 2
        Me.txt_customerCode.Name = "txt_customerCode"
        Me.txt_customerCode.Size = New System.Drawing.Size(83, 25)
        Me.txt_customerCode.SpellControl = Nothing
        Me.txt_customerCode.TabIndex = 1
        Me.txt_customerCode.Tag = ""
        Me.txt_customerCode.Text = "0"
        Me.txt_customerCode.Title = Nothing
        Me.txt_customerCode.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_customerCode.UseForData = True
        Me.txt_customerCode.ValidateCheckExistOnEdit = False
        Me.txt_customerCode.Value = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.cmb_customer)
        Me.Panel4.Controls.Add(Me.txt_OrderDate)
        Me.Panel4.Controls.Add(Me.lbl_customerName)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txt_ordernumber)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txt_CustomerMobile)
        Me.Panel4.Controls.Add(Me.txt_customerCode)
        Me.Panel4.Location = New System.Drawing.Point(3, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(913, 78)
        Me.Panel4.TabIndex = 115
        '
        'cmb_customer
        '
        Me.cmb_customer.AutoComplete = True
        Me.cmb_customer.DataSource = Me.ReonetcustomerBindingSource1
        Me.cmb_customer.DisplayMember = "fullname"
        Me.cmb_customer.EnterStop = True
        Me.cmb_customer.FormattingEnabled = True
        Me.cmb_customer.IsRequired = False
        Me.cmb_customer.LimitedToList = True
        Me.cmb_customer.Location = New System.Drawing.Point(92, 43)
        Me.cmb_customer.Name = "cmb_customer"
        Me.cmb_customer.OpenOnFoucus = False
        Me.cmb_customer.Size = New System.Drawing.Size(164, 26)
        Me.cmb_customer.TabIndex = 1006
        Me.cmb_customer.Tag = "srl_service"
        Me.cmb_customer.ValueMember = "Srl"
        '
        'ReonetcustomerBindingSource1
        '
        Me.ReonetcustomerBindingSource1.DataMember = "reonet_customer"
        Me.ReonetcustomerBindingSource1.DataSource = Me.Ds_BaseInfo
        '
        'txt_OrderDate
        '
        Me.txt_OrderDate.CustomFormat = "yyyy/MM/dd"
        Me.txt_OrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_OrderDate.Location = New System.Drawing.Point(313, 7)
        Me.txt_OrderDate.Name = "txt_OrderDate"
        Me.txt_OrderDate.Size = New System.Drawing.Size(100, 25)
        Me.txt_OrderDate.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Order Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(227, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Order Date:"
        '
        'txt_ordernumber
        '
        Me.txt_ordernumber.CheckExistValueInDb = True
        Me.txt_ordernumber.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_ordernumber.CurrencyUnit = "ریال"
        Me.txt_ordernumber.DefaultValue = ""
        Me.txt_ordernumber.FillWithMaxInDb = False
        Me.txt_ordernumber.IsRequired = True
        Me.txt_ordernumber.Location = New System.Drawing.Point(132, 7)
        Me.txt_ordernumber.MaxDecimalLength = 2
        Me.txt_ordernumber.Name = "txt_ordernumber"
        Me.txt_ordernumber.ReadOnly = True
        Me.txt_ordernumber.Size = New System.Drawing.Size(83, 25)
        Me.txt_ordernumber.SpellControl = Nothing
        Me.txt_ordernumber.TabIndex = 0
        Me.txt_ordernumber.Tag = "ordernumber"
        Me.txt_ordernumber.Text = "0"
        Me.txt_ordernumber.Title = Nothing
        Me.txt_ordernumber.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_ordernumber.UseForData = True
        Me.txt_ordernumber.ValidateCheckExistOnEdit = False
        Me.txt_ordernumber.Value = 0
        '
        'ReonetcustomerBindingSource
        '
        Me.ReonetcustomerBindingSource.DataMember = "reonet_customer"
        Me.ReonetcustomerBindingSource.DataSource = Me.Ds_BaseInfo1
        '
        'Ds_BaseInfo1
        '
        Me.Ds_BaseInfo1.DataSetName = "Ds_BaseInfo"
        Me.Ds_BaseInfo1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.txt_DeliveryDate)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.Label18)
        Me.Panel6.Controls.Add(Me.txt_totalDiscount)
        Me.Panel6.Controls.Add(Me.txt_OrderTotalPrice)
        Me.Panel6.Controls.Add(Me.txt_DeliveryPrice)
        Me.Panel6.Controls.Add(Me.txt_sum)
        Me.Panel6.Controls.Add(Me.txt_OrderDescription)
        Me.Panel6.Controls.Add(Me.Label16)
        Me.Panel6.Controls.Add(Me.TextBox1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(3, 550)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(917, 124)
        Me.Panel6.TabIndex = 5
        '
        'txt_DeliveryDate
        '
        Me.txt_DeliveryDate.CustomFormat = "yyyy/MM/dd"
        Me.txt_DeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_DeliveryDate.Location = New System.Drawing.Point(123, 85)
        Me.txt_DeliveryDate.Name = "txt_DeliveryDate"
        Me.txt_DeliveryDate.Size = New System.Drawing.Size(97, 25)
        Me.txt_DeliveryDate.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(672, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 18)
        Me.Label14.TabIndex = 122
        Me.Label14.Text = "Sum:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(633, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 18)
        Me.Label15.TabIndex = 122
        Me.Label15.Text = "Total Price:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 18)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Delivery Date:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(650, 40)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 18)
        Me.Label18.TabIndex = 122
        Me.Label18.Text = "Delivery:"
        '
        'txt_OrderTotalPrice
        '
        Me.txt_OrderTotalPrice.CheckExistValueInDb = True
        Me.txt_OrderTotalPrice.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_OrderTotalPrice.CurrencyUnit = "ریال"
        Me.txt_OrderTotalPrice.DefaultValue = "0"
        Me.txt_OrderTotalPrice.FillWithMaxInDb = False
        Me.txt_OrderTotalPrice.IsRequired = True
        Me.txt_OrderTotalPrice.Location = New System.Drawing.Point(745, 94)
        Me.txt_OrderTotalPrice.MaxDecimalLength = 2
        Me.txt_OrderTotalPrice.Name = "txt_OrderTotalPrice"
        Me.txt_OrderTotalPrice.ReadOnly = True
        Me.txt_OrderTotalPrice.Size = New System.Drawing.Size(95, 25)
        Me.txt_OrderTotalPrice.SpellControl = Nothing
        Me.txt_OrderTotalPrice.TabIndex = 2
        Me.txt_OrderTotalPrice.Tag = "Name"
        Me.txt_OrderTotalPrice.Text = "0"
        Me.txt_OrderTotalPrice.Title = Nothing
        Me.txt_OrderTotalPrice.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_OrderTotalPrice.UseForData = True
        Me.txt_OrderTotalPrice.ValidateCheckExistOnEdit = False
        Me.txt_OrderTotalPrice.Value = 0
        '
        'txt_DeliveryPrice
        '
        Me.txt_DeliveryPrice.CheckExistValueInDb = True
        Me.txt_DeliveryPrice.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_DeliveryPrice.CurrencyUnit = "ریال"
        Me.txt_DeliveryPrice.DefaultValue = "0"
        Me.txt_DeliveryPrice.FillWithMaxInDb = False
        Me.txt_DeliveryPrice.IsRequired = True
        Me.txt_DeliveryPrice.Location = New System.Drawing.Point(745, 37)
        Me.txt_DeliveryPrice.MaxDecimalLength = 2
        Me.txt_DeliveryPrice.Name = "txt_DeliveryPrice"
        Me.txt_DeliveryPrice.Size = New System.Drawing.Size(95, 25)
        Me.txt_DeliveryPrice.SpellControl = Nothing
        Me.txt_DeliveryPrice.TabIndex = 2
        Me.txt_DeliveryPrice.Tag = "Name"
        Me.txt_DeliveryPrice.Text = "0"
        Me.txt_DeliveryPrice.Title = Nothing
        Me.txt_DeliveryPrice.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_DeliveryPrice.UseForData = True
        Me.txt_DeliveryPrice.ValidateCheckExistOnEdit = False
        Me.txt_DeliveryPrice.Value = 0
        '
        'txt_sum
        '
        Me.txt_sum.CheckExistValueInDb = True
        Me.txt_sum.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_sum.CurrencyUnit = "ریال"
        Me.txt_sum.DefaultValue = "0"
        Me.txt_sum.FillWithMaxInDb = False
        Me.txt_sum.IsRequired = True
        Me.txt_sum.Location = New System.Drawing.Point(745, 7)
        Me.txt_sum.MaxDecimalLength = 2
        Me.txt_sum.Name = "txt_sum"
        Me.txt_sum.ReadOnly = True
        Me.txt_sum.Size = New System.Drawing.Size(95, 25)
        Me.txt_sum.SpellControl = Nothing
        Me.txt_sum.TabIndex = 2
        Me.txt_sum.Tag = "Name"
        Me.txt_sum.Text = "0"
        Me.txt_sum.Title = Nothing
        Me.txt_sum.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_sum.UseForData = True
        Me.txt_sum.ValidateCheckExistOnEdit = False
        Me.txt_sum.Value = 0
        '
        'txt_OrderDescription
        '
        Me.txt_OrderDescription.CheckExistValueInDb = False
        Me.txt_OrderDescription.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_OrderDescription.CurrencyUnit = "ریال"
        Me.txt_OrderDescription.DefaultValue = ""
        Me.txt_OrderDescription.FillWithMaxInDb = False
        Me.txt_OrderDescription.IsRequired = False
        Me.txt_OrderDescription.Location = New System.Drawing.Point(123, 11)
        Me.txt_OrderDescription.MaxDecimalLength = 2
        Me.txt_OrderDescription.Multiline = True
        Me.txt_OrderDescription.Name = "txt_OrderDescription"
        Me.txt_OrderDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_OrderDescription.Size = New System.Drawing.Size(427, 55)
        Me.txt_OrderDescription.SpellControl = Nothing
        Me.txt_OrderDescription.TabIndex = 0
        Me.txt_OrderDescription.Tag = ""
        Me.txt_OrderDescription.Title = Nothing
        Me.txt_OrderDescription.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_OrderDescription.UseForData = True
        Me.txt_OrderDescription.ValidateCheckExistOnEdit = False
        Me.txt_OrderDescription.Value = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(24, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 18)
        Me.Label16.TabIndex = 1003
        Me.Label16.Text = "Description : "
        '
        'TextBox1
        '
        Me.TextBox1.CheckExistValueInDb = False
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = ""
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = False
        Me.TextBox1.Location = New System.Drawing.Point(96, -252)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(427, 55)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Tag = ""
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = ""
        '
        'ReonetservicesBindingSource
        '
        Me.ReonetservicesBindingSource.DataMember = "reonet_services"
        Me.ReonetservicesBindingSource.DataSource = Me.Ds_BaseInfo
        '
        'Reonet_servicesTableAdapter
        '
        Me.Reonet_servicesTableAdapter.ClearBeforeFill = True
        '
        'Reonet_orderstatusTableAdapter
        '
        Me.Reonet_orderstatusTableAdapter.ClearBeforeFill = True
        '
        'Reonet_customerTableAdapter
        '
        Me.Reonet_customerTableAdapter.ClearBeforeFill = True
        '
        'Reonet_orderdetailTableAdapter
        '
        Me.Reonet_orderdetailTableAdapter.ClearBeforeFill = True
        '
        'txt_totalDiscount
        '
        Me.txt_totalDiscount.CheckExistValueInDb = True
        Me.txt_totalDiscount.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_totalDiscount.CurrencyUnit = "ریال"
        Me.txt_totalDiscount.DefaultValue = "0"
        Me.txt_totalDiscount.FillWithMaxInDb = False
        Me.txt_totalDiscount.IsRequired = True
        Me.txt_totalDiscount.Location = New System.Drawing.Point(745, 65)
        Me.txt_totalDiscount.MaxDecimalLength = 2
        Me.txt_totalDiscount.Name = "txt_totalDiscount"
        Me.txt_totalDiscount.ReadOnly = True
        Me.txt_totalDiscount.Size = New System.Drawing.Size(95, 25)
        Me.txt_totalDiscount.SpellControl = Nothing
        Me.txt_totalDiscount.TabIndex = 2
        Me.txt_totalDiscount.Tag = "Name"
        Me.txt_totalDiscount.Text = "0"
        Me.txt_totalDiscount.Title = Nothing
        Me.txt_totalDiscount.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_totalDiscount.UseForData = True
        Me.txt_totalDiscount.ValidateCheckExistOnEdit = False
        Me.txt_totalDiscount.Value = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(608, 68)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 18)
        Me.Label19.TabIndex = 122
        Me.Label19.Text = "Total Discount:"
        '
        'Frm_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(950, 816)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_Order"
        Me.Text = "Order"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ReonetorderstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pl_SquareMeter.ResumeLayout(False)
        Me.pl_SquareMeter.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetorderdetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.ReonetcustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetcustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_BaseInfo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.ReonetservicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_ordernumber As CS_Component.TextBox
    Friend WithEvents Btn_Add As CS_Component.Btn
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents PmEibFormPeiroBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents SrlDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفرمعیبDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخفرمعیبDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlPmEibFormMasterDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txt_Barcode As CS_Component.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents SrlPmEibFormMasterDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SrlEibTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نوععیبDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents توضیحاتDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_OrderDate As DateTimePicker
    Friend WithEvents lbl_customerName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_CustomerMobile As CS_Component.TextBox
    Friend WithEvents txt_customerCode As CS_Component.TextBox
    Friend WithEvents Ds_BaseInfo As Ds_BaseInfo
    Friend WithEvents txt_Price As CS_Component.TextBox
    Friend WithEvents txt_Count As CS_Component.TextBox
    Friend WithEvents txt_Length As CS_Component.TextBox
    Friend WithEvents txt_width As CS_Component.TextBox
    Friend WithEvents lbl_count_Weight As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_Length As Label
    Friend WithEvents lbl_width As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_RawPrice As CS_Component.TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_Description As CS_Component.TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_DeliveryDate As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_OrderTotalPrice As CS_Component.TextBox
    Friend WithEvents txt_DeliveryPrice As CS_Component.TextBox
    Friend WithEvents txt_sum As CS_Component.TextBox
    Friend WithEvents txt_OrderDescription As CS_Component.TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents txt_Area As CS_Component.TextBox
    Friend WithEvents lbl_area As Label
    Friend WithEvents btn_SelectService As Button
    Friend WithEvents txt_Service As CS_Component.TextBox
    Friend WithEvents ReonetservicesBindingSource As BindingSource
    Friend WithEvents Reonet_servicesTableAdapter As Ds_BaseInfoTableAdapters.reonet_servicesTableAdapter
    Friend WithEvents pl_SquareMeter As Panel
    Friend WithEvents chk_circle As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_orderStatus As VB_Component.ComboBox
    Friend WithEvents ReonetorderstatusBindingSource As BindingSource
    Friend WithEvents Reonet_orderstatusTableAdapter As Ds_BaseInfoTableAdapters.reonet_orderstatusTableAdapter
    Friend WithEvents ServiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Ds_BaseInfo1 As Ds_BaseInfo
    Friend WithEvents ReonetcustomerBindingSource As BindingSource
    Friend WithEvents Reonet_customerTableAdapter As Ds_BaseInfoTableAdapters.reonet_customerTableAdapter
    Friend WithEvents ReonetorderdetailBindingSource As BindingSource
    Friend WithEvents Ds_Order As Ds_Order
    Friend WithEvents Reonet_orderdetailTableAdapter As Ds_OrderTableAdapters.reonet_orderdetailTableAdapter
    Friend WithEvents chk_cash As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cmb_customer As VB_Component.ComboBox
    Friend WithEvents ReonetcustomerBindingSource1 As BindingSource
    Friend WithEvents txt_totalPrice As CS_Component.TextBox
    Friend WithEvents txt_Discount As CS_Component.TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_itemDeliveryDate As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SrlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SrlordermasterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SrlsubserviceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents WidthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LengthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents TotalpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SrlorderstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IscashDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents discount As DataGridViewTextBoxColumn
    Friend WithEvents deliverydate As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents Print As DataGridViewTextBoxColumn
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_totalDiscount As CS_Component.TextBox
End Class
