<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_ChangeStatus
    Inherits VB_Component.BaseForm_Layer


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ChangeStatus))
        Me.DataGridView1 = New CS_Component.DataGridView()
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SrlordermasterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SrlsubserviceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SrlcustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommissionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SrlorderstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiscountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReonetOrderDetailVwBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Order = New ReoNet.Ds_Order()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmb_Status = New VB_Component.ComboBox()
        Me.ReonetorderstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_BaseInfo = New ReoNet.Ds_BaseInfo()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmb_ServiceCategory = New VB_Component.ComboBox()
        Me.ReonetservicecategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Start = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_End = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_CustomerMobile = New CS_Component.TextBox()
        Me.txt_customerCode = New CS_Component.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_customerName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Reonet_OrderDetailVwTableAdapter = New ReoNet.Ds_OrderTableAdapters.Reonet_OrderDetailVwTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_Changestatus = New VB_Component.ComboBox()
        Me.ReonetorderstatusBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reonet_orderstatusTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_orderstatusTableAdapter()
        Me.Reonet_servicecategoryTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_servicecategoryTableAdapter()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetOrderDetailVwBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ReonetorderstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ReonetservicecategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetorderstatusBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Visible = False
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(708, 16)
        Me.btn_Delete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Delete.Visible = False
        '
        'btn_new
        '
        Me.btn_new.HeaderText = "Change"
        Me.btn_new.Location = New System.Drawing.Point(924, 16)
        Me.btn_new.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_new.Visible = False
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(816, 16)
        Me.btn_Edit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_Edit.Visible = False
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.Panel2)
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.gbx_GridViewList.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(1032, 676)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Location = New System.Drawing.Point(12, 770)
        Me.gbx_Controls.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.gbx_Controls.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.gbx_Controls.Size = New System.Drawing.Size(1032, 10)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Controls.Add(Me.PictureBox2)
        Me.gbx_Btn.Controls.Add(Me.cmb_Changestatus)
        Me.gbx_Btn.Controls.Add(Me.Label4)
        Me.gbx_Btn.Location = New System.Drawing.Point(12, 718)
        Me.gbx_Btn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.gbx_Btn.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.gbx_Btn.Size = New System.Drawing.Size(1032, 62)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Edit, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_new, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Delete, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.btn_Cancel, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.Label4, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.cmb_Changestatus, 0)
        Me.gbx_Btn.Controls.SetChildIndex(Me.PictureBox2, 0)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.CodeDataGridViewTextBoxColumn, Me.OrderdateDataGridViewTextBoxColumn, Me.SrlordermasterDataGridViewTextBoxColumn, Me.SrlsubserviceDataGridViewTextBoxColumn, Me.CustomerDataGridViewTextBoxColumn, Me.ServiceDataGridViewTextBoxColumn, Me.CountDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.TotalpriceDataGridViewTextBoxColumn, Me.WidthDataGridViewTextBoxColumn, Me.LengthDataGridViewTextBoxColumn, Me.AreaDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.SrlcustomerDataGridViewTextBoxColumn, Me.CommissionDataGridViewTextBoxColumn, Me.SrlorderstatusDataGridViewTextBoxColumn, Me.DiscountDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.ReonetOrderDetailVwBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(2, 129)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1028, 544)
        Me.DataGridView1.TabIndex = 1
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
        'CustomerDataGridViewTextBoxColumn
        '
        Me.CustomerDataGridViewTextBoxColumn.DataPropertyName = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.Name = "CustomerDataGridViewTextBoxColumn"
        Me.CustomerDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerDataGridViewTextBoxColumn.Width = 200
        '
        'ServiceDataGridViewTextBoxColumn
        '
        Me.ServiceDataGridViewTextBoxColumn.DataPropertyName = "service"
        Me.ServiceDataGridViewTextBoxColumn.HeaderText = "service"
        Me.ServiceDataGridViewTextBoxColumn.Name = "ServiceDataGridViewTextBoxColumn"
        '
        'CountDataGridViewTextBoxColumn
        '
        Me.CountDataGridViewTextBoxColumn.DataPropertyName = "count"
        Me.CountDataGridViewTextBoxColumn.HeaderText = "count"
        Me.CountDataGridViewTextBoxColumn.Name = "CountDataGridViewTextBoxColumn"
        Me.CountDataGridViewTextBoxColumn.Visible = False
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.Visible = False
        '
        'TotalpriceDataGridViewTextBoxColumn
        '
        Me.TotalpriceDataGridViewTextBoxColumn.DataPropertyName = "totalprice"
        Me.TotalpriceDataGridViewTextBoxColumn.HeaderText = "totalprice"
        Me.TotalpriceDataGridViewTextBoxColumn.Name = "TotalpriceDataGridViewTextBoxColumn"
        Me.TotalpriceDataGridViewTextBoxColumn.Visible = False
        '
        'WidthDataGridViewTextBoxColumn
        '
        Me.WidthDataGridViewTextBoxColumn.DataPropertyName = "width"
        Me.WidthDataGridViewTextBoxColumn.HeaderText = "width"
        Me.WidthDataGridViewTextBoxColumn.Name = "WidthDataGridViewTextBoxColumn"
        '
        'LengthDataGridViewTextBoxColumn
        '
        Me.LengthDataGridViewTextBoxColumn.DataPropertyName = "length"
        Me.LengthDataGridViewTextBoxColumn.HeaderText = "length"
        Me.LengthDataGridViewTextBoxColumn.Name = "LengthDataGridViewTextBoxColumn"
        '
        'AreaDataGridViewTextBoxColumn
        '
        Me.AreaDataGridViewTextBoxColumn.DataPropertyName = "area"
        Me.AreaDataGridViewTextBoxColumn.HeaderText = "area"
        Me.AreaDataGridViewTextBoxColumn.Name = "AreaDataGridViewTextBoxColumn"
        Me.AreaDataGridViewTextBoxColumn.Visible = False
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
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
        'SrlorderstatusDataGridViewTextBoxColumn
        '
        Me.SrlorderstatusDataGridViewTextBoxColumn.DataPropertyName = "srl_orderstatus"
        Me.SrlorderstatusDataGridViewTextBoxColumn.HeaderText = "srl_orderstatus"
        Me.SrlorderstatusDataGridViewTextBoxColumn.Name = "SrlorderstatusDataGridViewTextBoxColumn"
        Me.SrlorderstatusDataGridViewTextBoxColumn.Visible = False
        '
        'DiscountDataGridViewTextBoxColumn
        '
        Me.DiscountDataGridViewTextBoxColumn.DataPropertyName = "discount"
        Me.DiscountDataGridViewTextBoxColumn.HeaderText = "discount"
        Me.DiscountDataGridViewTextBoxColumn.Name = "DiscountDataGridViewTextBoxColumn"
        Me.DiscountDataGridViewTextBoxColumn.ReadOnly = True
        Me.DiscountDataGridViewTextBoxColumn.Visible = False
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
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(14, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1012, 105)
        Me.Panel2.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmb_Status)
        Me.GroupBox3.Location = New System.Drawing.Point(307, 51)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(282, 48)
        Me.GroupBox3.TabIndex = 163
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Status"
        '
        'cmb_Status
        '
        Me.cmb_Status.AllowDrop = True
        Me.cmb_Status.AutoComplete = True
        Me.cmb_Status.DataSource = Me.ReonetorderstatusBindingSource
        Me.cmb_Status.DisplayMember = "title"
        Me.cmb_Status.EnterStop = True
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.IsRequired = False
        Me.cmb_Status.LimitedToList = False
        Me.cmb_Status.Location = New System.Drawing.Point(6, 20)
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.OpenOnFoucus = False
        Me.cmb_Status.Size = New System.Drawing.Size(262, 24)
        Me.cmb_Status.TabIndex = 156
        Me.cmb_Status.ValueMember = "Srl"
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmb_ServiceCategory)
        Me.GroupBox4.Location = New System.Drawing.Point(19, 51)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(282, 48)
        Me.GroupBox4.TabIndex = 162
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Category"
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
        Me.cmb_ServiceCategory.Location = New System.Drawing.Point(6, 20)
        Me.cmb_ServiceCategory.Name = "cmb_ServiceCategory"
        Me.cmb_ServiceCategory.OpenOnFoucus = False
        Me.cmb_ServiceCategory.Size = New System.Drawing.Size(262, 24)
        Me.cmb_ServiceCategory.TabIndex = 156
        Me.cmb_ServiceCategory.ValueMember = "Srl"
        '
        'ReonetservicecategoryBindingSource
        '
        Me.ReonetservicecategoryBindingSource.DataMember = "reonet_servicecategory"
        Me.ReonetservicecategoryBindingSource.DataSource = Me.Ds_BaseInfo
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_Start)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_End)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(282, 43)
        Me.GroupBox2.TabIndex = 161
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "From"
        '
        'txt_Start
        '
        Me.txt_Start.CustomFormat = "yyyy/MM/dd"
        Me.txt_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_Start.Location = New System.Drawing.Point(47, 15)
        Me.txt_Start.Name = "txt_Start"
        Me.txt_Start.Size = New System.Drawing.Size(97, 23)
        Me.txt_Start.TabIndex = 122
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "To"
        '
        'txt_End
        '
        Me.txt_End.CustomFormat = "yyyy/MM/dd"
        Me.txt_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_End.Location = New System.Drawing.Point(171, 15)
        Me.txt_End.Name = "txt_End"
        Me.txt_End.Size = New System.Drawing.Size(97, 23)
        Me.txt_End.TabIndex = 122
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_CustomerMobile)
        Me.GroupBox1.Controls.Add(Me.txt_customerCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbl_customerName)
        Me.GroupBox1.Location = New System.Drawing.Point(307, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(570, 43)
        Me.GroupBox1.TabIndex = 160
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer"
        '
        'txt_CustomerMobile
        '
        Me.txt_CustomerMobile.CheckExistValueInDb = True
        Me.txt_CustomerMobile.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_CustomerMobile.CurrencyUnit = "ریال"
        Me.txt_CustomerMobile.DefaultValue = ""
        Me.txt_CustomerMobile.FillWithMaxInDb = False
        Me.txt_CustomerMobile.IsRequired = True
        Me.txt_CustomerMobile.Location = New System.Drawing.Point(207, 14)
        Me.txt_CustomerMobile.MaxDecimalLength = 2
        Me.txt_CustomerMobile.Name = "txt_CustomerMobile"
        Me.txt_CustomerMobile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_CustomerMobile.Size = New System.Drawing.Size(104, 23)
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
        Me.txt_customerCode.Location = New System.Drawing.Point(46, 14)
        Me.txt_customerCode.MaxDecimalLength = 2
        Me.txt_customerCode.Name = "txt_customerCode"
        Me.txt_customerCode.Size = New System.Drawing.Size(104, 23)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Code:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(154, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 16)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Mobile:"
        '
        'lbl_customerName
        '
        Me.lbl_customerName.AutoSize = True
        Me.lbl_customerName.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_customerName.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbl_customerName.Location = New System.Drawing.Point(326, 16)
        Me.lbl_customerName.Name = "lbl_customerName"
        Me.lbl_customerName.Size = New System.Drawing.Size(0, 18)
        Me.lbl_customerName.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(895, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 129
        Me.PictureBox1.TabStop = False
        '
        'Reonet_OrderDetailVwTableAdapter
        '
        Me.Reonet_OrderDetailVwTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Change status of the selected rows to:"
        '
        'cmb_Changestatus
        '
        Me.cmb_Changestatus.AllowDrop = True
        Me.cmb_Changestatus.AutoComplete = True
        Me.cmb_Changestatus.DataSource = Me.ReonetorderstatusBindingSource1
        Me.cmb_Changestatus.DisplayMember = "title"
        Me.cmb_Changestatus.EnterStop = True
        Me.cmb_Changestatus.FormattingEnabled = True
        Me.cmb_Changestatus.IsRequired = False
        Me.cmb_Changestatus.LimitedToList = False
        Me.cmb_Changestatus.Location = New System.Drawing.Point(478, 25)
        Me.cmb_Changestatus.Name = "cmb_Changestatus"
        Me.cmb_Changestatus.OpenOnFoucus = False
        Me.cmb_Changestatus.Size = New System.Drawing.Size(262, 24)
        Me.cmb_Changestatus.TabIndex = 156
        Me.cmb_Changestatus.ValueMember = "Srl"
        '
        'ReonetorderstatusBindingSource1
        '
        Me.ReonetorderstatusBindingSource1.DataMember = "reonet_orderstatus"
        Me.ReonetorderstatusBindingSource1.DataSource = Me.Ds_BaseInfo
        '
        'Reonet_orderstatusTableAdapter
        '
        Me.Reonet_orderstatusTableAdapter.ClearBeforeFill = True
        '
        'Reonet_servicecategoryTableAdapter
        '
        Me.Reonet_servicecategoryTableAdapter.ClearBeforeFill = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(756, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 164
        Me.PictureBox2.TabStop = False
        '
        'Frm_ChangeStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1056, 814)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Frm_ChangeStatus"
        Me.TableName = "reonet_orderdetail"
        Me.Text = "ChangeStatus"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Btn.ResumeLayout(False)
        Me.gbx_Btn.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetOrderDetailVwBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.ReonetorderstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ReonetservicecategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetorderstatusBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmb_Status As VB_Component.ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmb_ServiceCategory As VB_Component.ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Start As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_End As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_CustomerMobile As CS_Component.TextBox
    Friend WithEvents txt_customerCode As CS_Component.TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_customerName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ReonetorderstatusBindingSource As BindingSource
    Friend WithEvents Ds_BaseInfo As Ds_BaseInfo
    Friend WithEvents SrlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SrlordermasterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SrlsubserviceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WidthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LengthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AreaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SrlcustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommissionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SrlorderstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiscountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReonetOrderDetailVwBindingSource As BindingSource
    Friend WithEvents Ds_Order As Ds_Order
    Friend WithEvents cmb_Changestatus As VB_Component.ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Reonet_OrderDetailVwTableAdapter As Ds_OrderTableAdapters.Reonet_OrderDetailVwTableAdapter
    Friend WithEvents Reonet_orderstatusTableAdapter As Ds_BaseInfoTableAdapters.reonet_orderstatusTableAdapter
    Friend WithEvents ReonetservicecategoryBindingSource As BindingSource
    Friend WithEvents Reonet_servicecategoryTableAdapter As Ds_BaseInfoTableAdapters.reonet_servicecategoryTableAdapter
    Friend WithEvents ReonetorderstatusBindingSource1 As BindingSource
    Friend WithEvents PictureBox2 As PictureBox
End Class
