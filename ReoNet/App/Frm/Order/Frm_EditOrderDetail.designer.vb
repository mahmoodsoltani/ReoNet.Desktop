<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_EditOrderDetail
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
        Me.txt_rawprice = New CS_Component.TextBox()
        Me.txt_Price = New CS_Component.TextBox()
        Me.txt_Count = New CS_Component.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_count_Weight = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Description = New CS_Component.TextBox()
        Me.txt_Service = New CS_Component.TextBox()
        Me.txt_barcode = New CS_Component.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Discount = New CS_Component.TextBox()
        Me.Reonet_orderstatusTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_orderstatusTableAdapter()
        Me.Ds_Order = New ReoNet.Ds_Order()
        Me.OrderDetilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderDetilTableAdapter = New ReoNet.Ds_OrderTableAdapters.OrderDetilTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReonetservicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reonet_servicesTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_servicesTableAdapter()
        Me.txt_FinlaPrice = New CS_Component.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_deliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.ReonetorderstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pl_SquareMeter.SuspendLayout()
        CType(Me.Ds_Order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetservicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 253)
        Me.gbx_Buttons.Size = New System.Drawing.Size(890, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "Edit"
        Me.btn_Save.Location = New System.Drawing.Point(772, 19)
        Me.btn_Save.Size = New System.Drawing.Size(105, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.Label17)
        Me.gbx_Fields.Controls.Add(Me.txt_deliveryDate)
        Me.gbx_Fields.Controls.Add(Me.Label4)
        Me.gbx_Fields.Controls.Add(Me.chk_cash)
        Me.gbx_Fields.Controls.Add(Me.cmb_orderStatus)
        Me.gbx_Fields.Controls.Add(Me.PictureBox1)
        Me.gbx_Fields.Controls.Add(Me.pl_SquareMeter)
        Me.gbx_Fields.Controls.Add(Me.Button1)
        Me.gbx_Fields.Controls.Add(Me.btn_SelectService)
        Me.gbx_Fields.Controls.Add(Me.txt_FinlaPrice)
        Me.gbx_Fields.Controls.Add(Me.txt_Discount)
        Me.gbx_Fields.Controls.Add(Me.txt_rawprice)
        Me.gbx_Fields.Controls.Add(Me.txt_Price)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.txt_Count)
        Me.gbx_Fields.Controls.Add(Me.Label12)
        Me.gbx_Fields.Controls.Add(Me.lbl_count_Weight)
        Me.gbx_Fields.Controls.Add(Me.Label5)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Controls.Add(Me.txt_Description)
        Me.gbx_Fields.Controls.Add(Me.txt_Service)
        Me.gbx_Fields.Controls.Add(Me.txt_barcode)
        Me.gbx_Fields.Controls.Add(Me.Label11)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.Label20)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(891, 214)
        '
        'chk_cash
        '
        Me.chk_cash.AutoSize = True
        Me.chk_cash.Location = New System.Drawing.Point(20, 136)
        Me.chk_cash.Name = "chk_cash"
        Me.chk_cash.Size = New System.Drawing.Size(78, 22)
        Me.chk_cash.TabIndex = 1023
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
        Me.cmb_orderStatus.Location = New System.Drawing.Point(106, 164)
        Me.cmb_orderStatus.Name = "cmb_orderStatus"
        Me.cmb_orderStatus.OpenOnFoucus = False
        Me.cmb_orderStatus.Size = New System.Drawing.Size(164, 26)
        Me.cmb_orderStatus.TabIndex = 1022
        Me.cmb_orderStatus.Tag = "srl_service"
        Me.cmb_orderStatus.ValueMember = "srl"
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
        Me.PictureBox1.Location = New System.Drawing.Point(223, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 30)
        Me.PictureBox1.TabIndex = 1011
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
        Me.pl_SquareMeter.Location = New System.Drawing.Point(5, 62)
        Me.pl_SquareMeter.Name = "pl_SquareMeter"
        Me.pl_SquareMeter.Size = New System.Drawing.Size(556, 40)
        Me.pl_SquareMeter.TabIndex = 1009
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
        Me.btn_SelectService.Location = New System.Drawing.Point(436, 24)
        Me.btn_SelectService.Name = "btn_SelectService"
        Me.btn_SelectService.Size = New System.Drawing.Size(33, 33)
        Me.btn_SelectService.TabIndex = 1008
        Me.btn_SelectService.Text = "..."
        Me.btn_SelectService.UseVisualStyleBackColor = False
        '
        'txt_rawprice
        '
        Me.txt_rawprice.CheckExistValueInDb = False
        Me.txt_rawprice.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_rawprice.CurrencyUnit = "ریال"
        Me.txt_rawprice.DefaultValue = ""
        Me.txt_rawprice.FillWithMaxInDb = False
        Me.txt_rawprice.IsRequired = False
        Me.txt_rawprice.Location = New System.Drawing.Point(772, 70)
        Me.txt_rawprice.MaxDecimalLength = 2
        Me.txt_rawprice.Name = "txt_rawprice"
        Me.txt_rawprice.Size = New System.Drawing.Size(71, 25)
        Me.txt_rawprice.SpellControl = Nothing
        Me.txt_rawprice.TabIndex = 1014
        Me.txt_rawprice.Tag = ""
        Me.txt_rawprice.Text = "0"
        Me.txt_rawprice.Title = Nothing
        Me.txt_rawprice.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_rawprice.UseForData = True
        Me.txt_rawprice.ValidateCheckExistOnEdit = False
        Me.txt_rawprice.Value = 0
        '
        'txt_Price
        '
        Me.txt_Price.CheckExistValueInDb = False
        Me.txt_Price.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Price.CurrencyUnit = "ریال"
        Me.txt_Price.DefaultValue = ""
        Me.txt_Price.FillWithMaxInDb = False
        Me.txt_Price.IsRequired = False
        Me.txt_Price.Location = New System.Drawing.Point(772, 29)
        Me.txt_Price.MaxDecimalLength = 2
        Me.txt_Price.Name = "txt_Price"
        Me.txt_Price.Size = New System.Drawing.Size(71, 25)
        Me.txt_Price.SpellControl = Nothing
        Me.txt_Price.TabIndex = 1013
        Me.txt_Price.Tag = ""
        Me.txt_Price.Text = "0"
        Me.txt_Price.Title = Nothing
        Me.txt_Price.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_Price.UseForData = True
        Me.txt_Price.ValidateCheckExistOnEdit = False
        Me.txt_Price.Value = 0
        '
        'txt_Count
        '
        Me.txt_Count.CheckExistValueInDb = False
        Me.txt_Count.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Count.CurrencyUnit = "ریال"
        Me.txt_Count.DefaultValue = "1"
        Me.txt_Count.FillWithMaxInDb = False
        Me.txt_Count.IsRequired = False
        Me.txt_Count.Location = New System.Drawing.Point(612, 70)
        Me.txt_Count.MaxDecimalLength = 2
        Me.txt_Count.Name = "txt_Count"
        Me.txt_Count.Size = New System.Drawing.Size(45, 25)
        Me.txt_Count.SpellControl = Nothing
        Me.txt_Count.TabIndex = 1010
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
        Me.Label12.Location = New System.Drawing.Point(700, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 18)
        Me.Label12.TabIndex = 1015
        Me.Label12.Text = "Discount:"
        '
        'lbl_count_Weight
        '
        Me.lbl_count_Weight.AutoSize = True
        Me.lbl_count_Weight.Location = New System.Drawing.Point(565, 74)
        Me.lbl_count_Weight.Name = "lbl_count_Weight"
        Me.lbl_count_Weight.Size = New System.Drawing.Size(51, 18)
        Me.lbl_count_Weight.TabIndex = 1019
        Me.lbl_count_Weight.Text = "Count:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 18)
        Me.Label5.TabIndex = 1018
        Me.Label5.Text = "Status:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(725, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 18)
        Me.Label1.TabIndex = 1021
        Me.Label1.Text = "Price:"
        '
        'txt_Description
        '
        Me.txt_Description.CheckExistValueInDb = False
        Me.txt_Description.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Description.CurrencyUnit = "ریال"
        Me.txt_Description.DefaultValue = ""
        Me.txt_Description.FillWithMaxInDb = False
        Me.txt_Description.IsRequired = False
        Me.txt_Description.Location = New System.Drawing.Point(106, 108)
        Me.txt_Description.MaxDecimalLength = 2
        Me.txt_Description.Multiline = True
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Description.Size = New System.Drawing.Size(445, 50)
        Me.txt_Description.SpellControl = Nothing
        Me.txt_Description.TabIndex = 1012
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
        Me.txt_Service.Location = New System.Drawing.Point(474, 26)
        Me.txt_Service.MaxDecimalLength = 2
        Me.txt_Service.Name = "txt_Service"
        Me.txt_Service.ReadOnly = True
        Me.txt_Service.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Service.Size = New System.Drawing.Size(215, 25)
        Me.txt_Service.SpellControl = Nothing
        Me.txt_Service.TabIndex = 1007
        Me.txt_Service.Tag = ""
        Me.txt_Service.Title = Nothing
        Me.txt_Service.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_Service.UseForData = True
        Me.txt_Service.ValidateCheckExistOnEdit = False
        Me.txt_Service.Value = ""
        '
        'txt_barcode
        '
        Me.txt_barcode.CheckExistValueInDb = False
        Me.txt_barcode.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_barcode.CurrencyUnit = "ریال"
        Me.txt_barcode.DefaultValue = ""
        Me.txt_barcode.FillWithMaxInDb = False
        Me.txt_barcode.IsRequired = False
        Me.txt_barcode.Location = New System.Drawing.Point(84, 28)
        Me.txt_barcode.MaxDecimalLength = 2
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_barcode.Size = New System.Drawing.Size(133, 25)
        Me.txt_barcode.SpellControl = Nothing
        Me.txt_barcode.TabIndex = 1006
        Me.txt_barcode.Tag = ""
        Me.txt_barcode.Text = "0"
        Me.txt_barcode.Title = Nothing
        Me.txt_barcode.TypeOfContains = CS_Component.TypeOfValues.StringNumber
        Me.txt_barcode.UseForData = True
        Me.txt_barcode.ValidateCheckExistOnEdit = False
        Me.txt_barcode.Value = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 18)
        Me.Label11.TabIndex = 1016
        Me.Label11.Text = "Description : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 1020
        Me.Label2.Text = "Barcode:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(371, 31)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 18)
        Me.Label20.TabIndex = 1017
        Me.Label20.Text = "Service:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(693, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 1015
        Me.Label3.Text = "Raw Price:"
        '
        'txt_Discount
        '
        Me.txt_Discount.CheckExistValueInDb = False
        Me.txt_Discount.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Discount.CurrencyUnit = "ریال"
        Me.txt_Discount.DefaultValue = ""
        Me.txt_Discount.FillWithMaxInDb = False
        Me.txt_Discount.IsRequired = False
        Me.txt_Discount.Location = New System.Drawing.Point(772, 101)
        Me.txt_Discount.MaxDecimalLength = 2
        Me.txt_Discount.Name = "txt_Discount"
        Me.txt_Discount.Size = New System.Drawing.Size(71, 25)
        Me.txt_Discount.SpellControl = Nothing
        Me.txt_Discount.TabIndex = 1014
        Me.txt_Discount.Tag = ""
        Me.txt_Discount.Text = "0"
        Me.txt_Discount.Title = Nothing
        Me.txt_Discount.TypeOfContains = CS_Component.TypeOfValues.FloatNumber
        Me.txt_Discount.UseForData = True
        Me.txt_Discount.ValidateCheckExistOnEdit = False
        Me.txt_Discount.Value = 0!
        '
        'Reonet_orderstatusTableAdapter
        '
        Me.Reonet_orderstatusTableAdapter.ClearBeforeFill = True
        '
        'Ds_Order
        '
        Me.Ds_Order.DataSetName = "Ds_Order"
        Me.Ds_Order.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderDetilBindingSource
        '
        Me.OrderDetilBindingSource.DataMember = "OrderDetil"
        Me.OrderDetilBindingSource.DataSource = Me.Ds_Order
        '
        'OrderDetilTableAdapter
        '
        Me.OrderDetilTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(-92, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 33)
        Me.Button1.TabIndex = 1008
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = False
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
        'txt_FinlaPrice
        '
        Me.txt_FinlaPrice.CheckExistValueInDb = False
        Me.txt_FinlaPrice.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_FinlaPrice.CurrencyUnit = "ریال"
        Me.txt_FinlaPrice.DefaultValue = ""
        Me.txt_FinlaPrice.FillWithMaxInDb = False
        Me.txt_FinlaPrice.IsRequired = False
        Me.txt_FinlaPrice.Location = New System.Drawing.Point(772, 133)
        Me.txt_FinlaPrice.MaxDecimalLength = 2
        Me.txt_FinlaPrice.Name = "txt_FinlaPrice"
        Me.txt_FinlaPrice.Size = New System.Drawing.Size(71, 25)
        Me.txt_FinlaPrice.SpellControl = Nothing
        Me.txt_FinlaPrice.TabIndex = 1014
        Me.txt_FinlaPrice.Tag = ""
        Me.txt_FinlaPrice.Text = "0"
        Me.txt_FinlaPrice.Title = Nothing
        Me.txt_FinlaPrice.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_FinlaPrice.UseForData = True
        Me.txt_FinlaPrice.ValidateCheckExistOnEdit = False
        Me.txt_FinlaPrice.Value = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(687, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 18)
        Me.Label4.TabIndex = 1024
        Me.Label4.Text = "Total Price:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(345, 169)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 18)
        Me.Label17.TabIndex = 1026
        Me.Label17.Text = "Delivery Date:"
        '
        'txt_deliveryDate
        '
        Me.txt_deliveryDate.CustomFormat = "yyyy/MM/dd"
        Me.txt_deliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_deliveryDate.Location = New System.Drawing.Point(451, 166)
        Me.txt_deliveryDate.Name = "txt_deliveryDate"
        Me.txt_deliveryDate.Size = New System.Drawing.Size(100, 25)
        Me.txt_deliveryDate.TabIndex = 1025
        '
        'Frm_EditOrderDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(917, 341)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_EditOrderDetail"
        Me.Text = "Edit Order Item"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.ReonetorderstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pl_SquareMeter.ResumeLayout(False)
        Me.pl_SquareMeter.PerformLayout()
        CType(Me.Ds_Order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetservicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Names As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMPostBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmEibTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents PmEibFormMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmEibFormMasterBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PmVahedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PmGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RpEibformBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents chk_cash As CheckBox
    Friend WithEvents cmb_orderStatus As VB_Component.ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pl_SquareMeter As Panel
    Friend WithEvents chk_circle As CheckBox
    Friend WithEvents txt_Area As CS_Component.TextBox
    Friend WithEvents lbl_width As Label
    Friend WithEvents lbl_Length As Label
    Friend WithEvents lbl_area As Label
    Friend WithEvents txt_width As CS_Component.TextBox
    Friend WithEvents txt_Length As CS_Component.TextBox
    Friend WithEvents btn_SelectService As Button
    Friend WithEvents txt_Discount As CS_Component.TextBox
    Friend WithEvents txt_rawprice As CS_Component.TextBox
    Friend WithEvents txt_Price As CS_Component.TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Count As CS_Component.TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_count_Weight As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Description As CS_Component.TextBox
    Friend WithEvents txt_Service As CS_Component.TextBox
    Friend WithEvents txt_barcode As CS_Component.TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents ReonetorderstatusBindingSource As BindingSource
    Friend WithEvents Ds_BaseInfo As Ds_BaseInfo
    Friend WithEvents Reonet_orderstatusTableAdapter As Ds_BaseInfoTableAdapters.reonet_orderstatusTableAdapter
    Friend WithEvents Ds_Order As Ds_Order
    Friend WithEvents OrderDetilBindingSource As BindingSource
    Friend WithEvents OrderDetilTableAdapter As Ds_OrderTableAdapters.OrderDetilTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents ReonetservicesBindingSource As BindingSource
    Friend WithEvents Reonet_servicesTableAdapter As Ds_BaseInfoTableAdapters.reonet_servicesTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_FinlaPrice As CS_Component.TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_deliveryDate As DateTimePicker
End Class
