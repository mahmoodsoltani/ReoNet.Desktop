<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_OrderItemVw
    Inherits BaseForm_View
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_OrderItemVw))
        Me.DataGridView1 = New CS_Component.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SrlordermasterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SrlsubserviceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SrlcustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommissionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ReonetorderstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_BaseInfo = New ReoNet.Ds_BaseInfo()
        Me.Print = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReonetOrderDetailVwBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Order = New ReoNet.Ds_Order()
        Me.ReonetservicecategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_private = New System.Windows.Forms.RadioButton()
        Me.rb_company = New System.Windows.Forms.RadioButton()
        Me.rb_AllCustomer = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_invoice = New System.Windows.Forms.RadioButton()
        Me.rb_cash = New System.Windows.Forms.RadioButton()
        Me.rb_all = New System.Windows.Forms.RadioButton()
        Me.cmb_ServiceCategory = New VB_Component.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_CustomerMobile = New CS_Component.TextBox()
        Me.txt_customerCode = New CS_Component.TextBox()
        Me.txt_End = New System.Windows.Forms.DateTimePicker()
        Me.txt_Start = New System.Windows.Forms.DateTimePicker()
        Me.lbl_customerName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Reonet_OrderDetailVwTableAdapter = New ReoNet.Ds_OrderTableAdapters.Reonet_OrderDetailVwTableAdapter()
        Me.OrderDetilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderDetilTableAdapter = New ReoNet.Ds_OrderTableAdapters.OrderDetilTableAdapter()
        Me.Reonet_servicecategoryTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_servicecategoryTableAdapter()
        Me.Reonet_orderstatusTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_orderstatusTableAdapter()
        Me.lb_totalSum = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetorderstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetOrderDetailVwBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetservicecategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(14, 646)
        Me.GroupBox1.Size = New System.Drawing.Size(1171, 53)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(16, 16)
        Me.btn_Cancel.Size = New System.Drawing.Size(99, 29)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(845, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(101, 29)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(953, 17)
        Me.btn_Edit.Size = New System.Drawing.Size(101, 29)
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(1060, 17)
        Me.btn_New.Size = New System.Drawing.Size(101, 29)
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.lb_totalSum)
        Me.gbx_DataGridView.Controls.Add(Me.Panel2)
        Me.gbx_DataGridView.Controls.Add(Me.DataGridView1)
        Me.gbx_DataGridView.Location = New System.Drawing.Point(14, 40)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(1171, 603)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.CodeDataGridViewTextBoxColumn, Me.CustomerDataGridViewTextBoxColumn, Me.OrderdateDataGridViewTextBoxColumn, Me.SrlordermasterDataGridViewTextBoxColumn, Me.SrlsubserviceDataGridViewTextBoxColumn, Me.ServiceDataGridViewTextBoxColumn, Me.CountDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.AreaDataGridViewTextBoxColumn, Me.TotalpriceDataGridViewTextBoxColumn, Me.WidthDataGridViewTextBoxColumn, Me.LengthDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.SrlcustomerDataGridViewTextBoxColumn, Me.CommissionDataGridViewTextBoxColumn, Me.Status, Me.Print, Me.Edit, Me.discount})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.ReonetOrderDetailVwBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(3, 143)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1165, 419)
        Me.DataGridView1.TabIndex = 0
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
        '
        'CustomerDataGridViewTextBoxColumn
        '
        Me.CustomerDataGridViewTextBoxColumn.DataPropertyName = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.Name = "CustomerDataGridViewTextBoxColumn"
        Me.CustomerDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerDataGridViewTextBoxColumn.Width = 170
        '
        'OrderdateDataGridViewTextBoxColumn
        '
        Me.OrderdateDataGridViewTextBoxColumn.DataPropertyName = "orderdate"
        Me.OrderdateDataGridViewTextBoxColumn.HeaderText = "orderdate"
        Me.OrderdateDataGridViewTextBoxColumn.Name = "OrderdateDataGridViewTextBoxColumn"
        '
        'SrlordermasterDataGridViewTextBoxColumn
        '
        Me.SrlordermasterDataGridViewTextBoxColumn.DataPropertyName = "srl_ordermaster"
        Me.SrlordermasterDataGridViewTextBoxColumn.HeaderText = "srl_ordermaster"
        Me.SrlordermasterDataGridViewTextBoxColumn.Name = "SrlordermasterDataGridViewTextBoxColumn"
        Me.SrlordermasterDataGridViewTextBoxColumn.Visible = False
        '
        'SrlsubserviceDataGridViewTextBoxColumn
        '
        Me.SrlsubserviceDataGridViewTextBoxColumn.DataPropertyName = "Srl_subservice"
        Me.SrlsubserviceDataGridViewTextBoxColumn.HeaderText = "Srl_subservice"
        Me.SrlsubserviceDataGridViewTextBoxColumn.Name = "SrlsubserviceDataGridViewTextBoxColumn"
        Me.SrlsubserviceDataGridViewTextBoxColumn.Visible = False
        '
        'ServiceDataGridViewTextBoxColumn
        '
        Me.ServiceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ServiceDataGridViewTextBoxColumn.DataPropertyName = "service"
        Me.ServiceDataGridViewTextBoxColumn.HeaderText = "service"
        Me.ServiceDataGridViewTextBoxColumn.Name = "ServiceDataGridViewTextBoxColumn"
        '
        'CountDataGridViewTextBoxColumn
        '
        Me.CountDataGridViewTextBoxColumn.DataPropertyName = "count"
        Me.CountDataGridViewTextBoxColumn.HeaderText = "count"
        Me.CountDataGridViewTextBoxColumn.Name = "CountDataGridViewTextBoxColumn"
        Me.CountDataGridViewTextBoxColumn.Width = 50
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.Width = 50
        '
        'AreaDataGridViewTextBoxColumn
        '
        Me.AreaDataGridViewTextBoxColumn.DataPropertyName = "area"
        Me.AreaDataGridViewTextBoxColumn.HeaderText = "area"
        Me.AreaDataGridViewTextBoxColumn.Name = "AreaDataGridViewTextBoxColumn"
        Me.AreaDataGridViewTextBoxColumn.Width = 50
        '
        'TotalpriceDataGridViewTextBoxColumn
        '
        Me.TotalpriceDataGridViewTextBoxColumn.DataPropertyName = "totalprice"
        Me.TotalpriceDataGridViewTextBoxColumn.HeaderText = "totalprice"
        Me.TotalpriceDataGridViewTextBoxColumn.Name = "TotalpriceDataGridViewTextBoxColumn"
        '
        'WidthDataGridViewTextBoxColumn
        '
        Me.WidthDataGridViewTextBoxColumn.DataPropertyName = "width"
        Me.WidthDataGridViewTextBoxColumn.HeaderText = "width"
        Me.WidthDataGridViewTextBoxColumn.Name = "WidthDataGridViewTextBoxColumn"
        Me.WidthDataGridViewTextBoxColumn.Visible = False
        '
        'LengthDataGridViewTextBoxColumn
        '
        Me.LengthDataGridViewTextBoxColumn.DataPropertyName = "length"
        Me.LengthDataGridViewTextBoxColumn.HeaderText = "length"
        Me.LengthDataGridViewTextBoxColumn.Name = "LengthDataGridViewTextBoxColumn"
        Me.LengthDataGridViewTextBoxColumn.Visible = False
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Visible = False
        '
        'SrlcustomerDataGridViewTextBoxColumn
        '
        Me.SrlcustomerDataGridViewTextBoxColumn.DataPropertyName = "srl_customer"
        Me.SrlcustomerDataGridViewTextBoxColumn.HeaderText = "srl_customer"
        Me.SrlcustomerDataGridViewTextBoxColumn.Name = "SrlcustomerDataGridViewTextBoxColumn"
        Me.SrlcustomerDataGridViewTextBoxColumn.Visible = False
        '
        'CommissionDataGridViewTextBoxColumn
        '
        Me.CommissionDataGridViewTextBoxColumn.DataPropertyName = "Commission"
        Me.CommissionDataGridViewTextBoxColumn.HeaderText = "Commission"
        Me.CommissionDataGridViewTextBoxColumn.Name = "CommissionDataGridViewTextBoxColumn"
        Me.CommissionDataGridViewTextBoxColumn.ReadOnly = True
        Me.CommissionDataGridViewTextBoxColumn.Visible = False
        '
        'Status
        '
        Me.Status.DataPropertyName = "srl_orderstatus"
        Me.Status.DataSource = Me.ReonetorderstatusBindingSource
        Me.Status.DisplayMember = "title"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ValueMember = "srl"
        Me.Status.Width = 200
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
        'Print
        '
        Me.Print.HeaderText = ""
        Me.Print.Name = "Print"
        Me.Print.Width = 27
        '
        'Edit
        '
        Me.Edit.HeaderText = ""
        Me.Edit.Name = "Edit"
        Me.Edit.Width = 27
        '
        'discount
        '
        Me.discount.DataPropertyName = "discount"
        Me.discount.HeaderText = "discount"
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = True
        Me.discount.Visible = False
        '
        'ReonetOrderDetailVwBindingSource
        '
        Me.ReonetOrderDetailVwBindingSource.DataMember = "Reonet_OrderDetailVw"
        Me.ReonetOrderDetailVwBindingSource.DataSource = Me.Ds_Order
        '
        'Ds_Order
        '
        Me.Ds_Order.DataSetName = "Ds_Order"
        Me.Ds_Order.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReonetservicecategoryBindingSource
        '
        Me.ReonetservicecategoryBindingSource.DataMember = "reonet_servicecategory"
        Me.ReonetservicecategoryBindingSource.DataSource = Me.Ds_BaseInfo
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.cmb_ServiceCategory)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txt_CustomerMobile)
        Me.Panel2.Controls.Add(Me.txt_customerCode)
        Me.Panel2.Controls.Add(Me.txt_End)
        Me.Panel2.Controls.Add(Me.txt_Start)
        Me.Panel2.Controls.Add(Me.lbl_customerName)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(16, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1152, 106)
        Me.Panel2.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label4.Location = New System.Drawing.Point(769, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 18)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "Category"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_private)
        Me.GroupBox3.Controls.Add(Me.rb_company)
        Me.GroupBox3.Controls.Add(Me.rb_AllCustomer)
        Me.GroupBox3.Location = New System.Drawing.Point(391, 47)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(371, 50)
        Me.GroupBox3.TabIndex = 158
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Type"
        '
        'rb_private
        '
        Me.rb_private.AutoSize = True
        Me.rb_private.Checked = True
        Me.rb_private.Location = New System.Drawing.Point(289, 24)
        Me.rb_private.Name = "rb_private"
        Me.rb_private.Size = New System.Drawing.Size(70, 22)
        Me.rb_private.TabIndex = 0
        Me.rb_private.TabStop = True
        Me.rb_private.Text = "Private"
        Me.rb_private.UseVisualStyleBackColor = True
        '
        'rb_company
        '
        Me.rb_company.AutoSize = True
        Me.rb_company.Location = New System.Drawing.Point(161, 24)
        Me.rb_company.Name = "rb_company"
        Me.rb_company.Size = New System.Drawing.Size(88, 22)
        Me.rb_company.TabIndex = 0
        Me.rb_company.Text = "Company"
        Me.rb_company.UseVisualStyleBackColor = True
        '
        'rb_AllCustomer
        '
        Me.rb_AllCustomer.AutoSize = True
        Me.rb_AllCustomer.Location = New System.Drawing.Point(37, 24)
        Me.rb_AllCustomer.Name = "rb_AllCustomer"
        Me.rb_AllCustomer.Size = New System.Drawing.Size(39, 22)
        Me.rb_AllCustomer.TabIndex = 0
        Me.rb_AllCustomer.Text = "All"
        Me.rb_AllCustomer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_invoice)
        Me.GroupBox2.Controls.Add(Me.rb_cash)
        Me.GroupBox2.Controls.Add(Me.rb_all)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(371, 50)
        Me.GroupBox2.TabIndex = 158
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Type"
        '
        'rb_invoice
        '
        Me.rb_invoice.AutoSize = True
        Me.rb_invoice.Checked = True
        Me.rb_invoice.Location = New System.Drawing.Point(289, 24)
        Me.rb_invoice.Name = "rb_invoice"
        Me.rb_invoice.Size = New System.Drawing.Size(73, 22)
        Me.rb_invoice.TabIndex = 0
        Me.rb_invoice.TabStop = True
        Me.rb_invoice.Text = "Invoice"
        Me.rb_invoice.UseVisualStyleBackColor = True
        '
        'rb_cash
        '
        Me.rb_cash.AutoSize = True
        Me.rb_cash.Location = New System.Drawing.Point(161, 24)
        Me.rb_cash.Name = "rb_cash"
        Me.rb_cash.Size = New System.Drawing.Size(58, 22)
        Me.rb_cash.TabIndex = 0
        Me.rb_cash.Text = "Cash"
        Me.rb_cash.UseVisualStyleBackColor = True
        '
        'rb_all
        '
        Me.rb_all.AutoSize = True
        Me.rb_all.Location = New System.Drawing.Point(37, 24)
        Me.rb_all.Name = "rb_all"
        Me.rb_all.Size = New System.Drawing.Size(39, 22)
        Me.rb_all.TabIndex = 0
        Me.rb_all.Text = "All"
        Me.rb_all.UseVisualStyleBackColor = True
        '
        'cmb_ServiceCategory
        '
        Me.cmb_ServiceCategory.AllowDrop = True
        Me.cmb_ServiceCategory.AutoComplete = True
        Me.cmb_ServiceCategory.DataSource = Me.ReonetservicecategoryBindingSource
        Me.cmb_ServiceCategory.DisplayMember = "title"
        Me.cmb_ServiceCategory.EnterStop = True
        Me.cmb_ServiceCategory.FormattingEnabled = True
        Me.cmb_ServiceCategory.IsRequired = False
        Me.cmb_ServiceCategory.LimitedToList = False
        Me.cmb_ServiceCategory.Location = New System.Drawing.Point(859, 63)
        Me.cmb_ServiceCategory.Name = "cmb_ServiceCategory"
        Me.cmb_ServiceCategory.OpenOnFoucus = False
        Me.cmb_ServiceCategory.Size = New System.Drawing.Size(270, 26)
        Me.cmb_ServiceCategory.TabIndex = 156
        Me.cmb_ServiceCategory.ValueMember = "Srl"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1110, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 129
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(654, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 18)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Mobile:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(487, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(397, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 127
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
        Me.txt_CustomerMobile.Location = New System.Drawing.Point(710, 10)
        Me.txt_CustomerMobile.MaxDecimalLength = 2
        Me.txt_CustomerMobile.Name = "txt_CustomerMobile"
        Me.txt_CustomerMobile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_CustomerMobile.Size = New System.Drawing.Size(104, 26)
        Me.txt_CustomerMobile.SpellControl = Nothing
        Me.txt_CustomerMobile.TabIndex = 124
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
        Me.txt_customerCode.Location = New System.Drawing.Point(537, 10)
        Me.txt_customerCode.MaxDecimalLength = 2
        Me.txt_customerCode.Name = "txt_customerCode"
        Me.txt_customerCode.Size = New System.Drawing.Size(104, 26)
        Me.txt_customerCode.SpellControl = Nothing
        Me.txt_customerCode.TabIndex = 123
        Me.txt_customerCode.Tag = ""
        Me.txt_customerCode.Text = "0"
        Me.txt_customerCode.Title = Nothing
        Me.txt_customerCode.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_customerCode.UseForData = True
        Me.txt_customerCode.ValidateCheckExistOnEdit = False
        Me.txt_customerCode.Value = 0
        '
        'txt_End
        '
        Me.txt_End.CustomFormat = "yyyy/MM/dd"
        Me.txt_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_End.Location = New System.Drawing.Point(279, 10)
        Me.txt_End.Name = "txt_End"
        Me.txt_End.Size = New System.Drawing.Size(97, 26)
        Me.txt_End.TabIndex = 122
        '
        'txt_Start
        '
        Me.txt_Start.CustomFormat = "yyyy/MM/dd"
        Me.txt_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_Start.Location = New System.Drawing.Point(129, 10)
        Me.txt_Start.Name = "txt_Start"
        Me.txt_Start.Size = New System.Drawing.Size(97, 26)
        Me.txt_Start.TabIndex = 122
        '
        'lbl_customerName
        '
        Me.lbl_customerName.AutoSize = True
        Me.lbl_customerName.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_customerName.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbl_customerName.Location = New System.Drawing.Point(825, 17)
        Me.lbl_customerName.Name = "lbl_customerName"
        Me.lbl_customerName.Size = New System.Drawing.Size(0, 18)
        Me.lbl_customerName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(239, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "To"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Ordre Date : "
        '
        'Reonet_OrderDetailVwTableAdapter
        '
        Me.Reonet_OrderDetailVwTableAdapter.ClearBeforeFill = True
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
        'Reonet_servicecategoryTableAdapter
        '
        Me.Reonet_servicecategoryTableAdapter.ClearBeforeFill = True
        '
        'Reonet_orderstatusTableAdapter
        '
        Me.Reonet_orderstatusTableAdapter.ClearBeforeFill = True
        '
        'lb_totalSum
        '
        Me.lb_totalSum.AutoSize = True
        Me.lb_totalSum.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lb_totalSum.Location = New System.Drawing.Point(278, 576)
        Me.lb_totalSum.Name = "lb_totalSum"
        Me.lb_totalSum.Size = New System.Drawing.Size(0, 18)
        Me.lb_totalSum.TabIndex = 160
        '
        'Frm_OrderItemVw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1198, 739)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_OrderItemVw"
        Me.Text = "Order View"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        Me.gbx_DataGridView.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetorderstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetOrderDetailVwBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetservicecategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents شمارهفرمکارDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدهزینهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents تاریخDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents واحدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامگروهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents پستDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ثبتکنندهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_customerName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_End As DateTimePicker
    Friend WithEvents txt_Start As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_CustomerMobile As CS_Component.TextBox
    Friend WithEvents txt_customerCode As CS_Component.TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ReonetOrderDetailVwBindingSource As BindingSource
    Friend WithEvents Ds_Order As Ds_Order
    Friend WithEvents Reonet_OrderDetailVwTableAdapter As Ds_OrderTableAdapters.Reonet_OrderDetailVwTableAdapter
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb_invoice As RadioButton
    Friend WithEvents rb_cash As RadioButton
    Friend WithEvents rb_all As RadioButton
    Friend WithEvents cmb_ServiceCategory As VB_Component.ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rb_private As RadioButton
    Friend WithEvents rb_company As RadioButton
    Friend WithEvents rb_AllCustomer As RadioButton
    Friend WithEvents OrderDetilBindingSource As BindingSource
    Friend WithEvents OrderDetilTableAdapter As Ds_OrderTableAdapters.OrderDetilTableAdapter
    Friend WithEvents Ds_BaseInfo As Ds_BaseInfo
    Friend WithEvents ReonetservicecategoryBindingSource As BindingSource
    Friend WithEvents Reonet_servicecategoryTableAdapter As Ds_BaseInfoTableAdapters.reonet_servicecategoryTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents ReonetorderstatusBindingSource As BindingSource
    Friend WithEvents Reonet_orderstatusTableAdapter As Ds_BaseInfoTableAdapters.reonet_orderstatusTableAdapter
    Friend WithEvents lb_totalSum As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SrlordermasterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SrlsubserviceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WidthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LengthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SrlcustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommissionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewComboBoxColumn
    Friend WithEvents Print As DataGridViewButtonColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents discount As DataGridViewTextBoxColumn
End Class
