<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_OrderVw
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_OrderVw))
        Me.DataGridView1 = New CS_Component.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdernumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliverydateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliverypriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemcountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Print = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ReonetordermasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_Order = New ReoNet.Ds_Order()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_CustomerMobile = New CS_Component.TextBox()
        Me.txt_customerCode = New CS_Component.TextBox()
        Me.txt_End = New System.Windows.Forms.DateTimePicker()
        Me.txt_Start = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.lbl_customerName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Reonet_ordermasterTableAdapter = New ReoNet.Ds_OrderTableAdapters.reonet_ordermasterTableAdapter()
        Me.OrderDetilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderDetilTableAdapter = New ReoNet.Ds_OrderTableAdapters.OrderDetilTableAdapter()
        Me.Ds_BaseInfo = New ReoNet.Ds_BaseInfo()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.gbx_DataGridView.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetordermasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 646)
        Me.GroupBox1.Size = New System.Drawing.Size(1327, 53)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_New, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_Edit, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_Delete, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.btn_Cancel, 0)
        Me.GroupBox1.Controls.SetChildIndex(Me.PictureBox2, 0)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(16, 16)
        Me.btn_Cancel.Size = New System.Drawing.Size(99, 29)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(1001, 17)
        Me.btn_Delete.Size = New System.Drawing.Size(101, 29)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(1109, 17)
        Me.btn_Edit.Size = New System.Drawing.Size(101, 29)
        '
        'btn_New
        '
        Me.btn_New.Location = New System.Drawing.Point(1216, 17)
        Me.btn_New.Size = New System.Drawing.Size(101, 29)
        '
        'gbx_DataGridView
        '
        Me.gbx_DataGridView.Controls.Add(Me.Panel2)
        Me.gbx_DataGridView.Controls.Add(Me.DataGridView1)
        Me.gbx_DataGridView.Location = New System.Drawing.Point(14, 40)
        Me.gbx_DataGridView.Size = New System.Drawing.Size(1327, 603)
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.CustomerDataGridViewTextBoxColumn, Me.OrdernumberDataGridViewTextBoxColumn, Me.OrderdateDataGridViewTextBoxColumn, Me.DeliverydateDataGridViewTextBoxColumn, Me.DeliverypriceDataGridViewTextBoxColumn, Me.TotalpriceDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.ItemcountDataGridViewTextBoxColumn, Me.Edit, Me.Delete, Me.Print})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.ReonetordermasterBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1321, 520)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Srl"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Srl"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'CustomerDataGridViewTextBoxColumn
        '
        Me.CustomerDataGridViewTextBoxColumn.DataPropertyName = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.CustomerDataGridViewTextBoxColumn.Name = "CustomerDataGridViewTextBoxColumn"
        Me.CustomerDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustomerDataGridViewTextBoxColumn.Width = 200
        '
        'OrdernumberDataGridViewTextBoxColumn
        '
        Me.OrdernumberDataGridViewTextBoxColumn.DataPropertyName = "ordernumber"
        Me.OrdernumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber"
        Me.OrdernumberDataGridViewTextBoxColumn.Name = "OrdernumberDataGridViewTextBoxColumn"
        Me.OrdernumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrdernumberDataGridViewTextBoxColumn.Width = 150
        '
        'OrderdateDataGridViewTextBoxColumn
        '
        Me.OrderdateDataGridViewTextBoxColumn.DataPropertyName = "orderdate"
        Me.OrderdateDataGridViewTextBoxColumn.HeaderText = "OrderDate"
        Me.OrderdateDataGridViewTextBoxColumn.Name = "OrderdateDataGridViewTextBoxColumn"
        Me.OrderdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeliverydateDataGridViewTextBoxColumn
        '
        Me.DeliverydateDataGridViewTextBoxColumn.DataPropertyName = "deliverydate"
        Me.DeliverydateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate"
        Me.DeliverydateDataGridViewTextBoxColumn.Name = "DeliverydateDataGridViewTextBoxColumn"
        Me.DeliverydateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DeliverypriceDataGridViewTextBoxColumn
        '
        Me.DeliverypriceDataGridViewTextBoxColumn.DataPropertyName = "deliveryprice"
        Me.DeliverypriceDataGridViewTextBoxColumn.HeaderText = "DeliveryPrice"
        Me.DeliverypriceDataGridViewTextBoxColumn.Name = "DeliverypriceDataGridViewTextBoxColumn"
        Me.DeliverypriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.DeliverypriceDataGridViewTextBoxColumn.Visible = False
        '
        'TotalpriceDataGridViewTextBoxColumn
        '
        Me.TotalpriceDataGridViewTextBoxColumn.DataPropertyName = "totalprice"
        Me.TotalpriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.TotalpriceDataGridViewTextBoxColumn.Name = "TotalpriceDataGridViewTextBoxColumn"
        Me.TotalpriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemcountDataGridViewTextBoxColumn
        '
        Me.ItemcountDataGridViewTextBoxColumn.DataPropertyName = "Itemcount"
        Me.ItemcountDataGridViewTextBoxColumn.HeaderText = "Items"
        Me.ItemcountDataGridViewTextBoxColumn.Name = "ItemcountDataGridViewTextBoxColumn"
        Me.ItemcountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Edit
        '
        Me.Edit.HeaderText = ""
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.ToolTipText = "Edit"
        Me.Edit.Width = 23
        '
        'Delete
        '
        Me.Delete.HeaderText = ""
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.ToolTipText = "Delete"
        Me.Delete.Width = 23
        '
        'Print
        '
        Me.Print.HeaderText = ""
        Me.Print.Name = "Print"
        Me.Print.ReadOnly = True
        Me.Print.ToolTipText = "Print"
        Me.Print.Width = 23
        '
        'ReonetordermasterBindingSource
        '
        Me.ReonetordermasterBindingSource.DataMember = "reonet_ordermaster"
        Me.ReonetordermasterBindingSource.DataSource = Me.Ds_Order
        '
        'Ds_Order
        '
        Me.Ds_Order.DataSetName = "Ds_Order"
        Me.Ds_Order.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txt_CustomerMobile)
        Me.Panel2.Controls.Add(Me.txt_customerCode)
        Me.Panel2.Controls.Add(Me.txt_End)
        Me.Panel2.Controls.Add(Me.txt_Start)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.lbl_customerName)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(16, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1286, 40)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1239, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 129
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(784, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 18)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Mobile:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(601, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(511, 11)
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
        Me.txt_CustomerMobile.Location = New System.Drawing.Point(840, 6)
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
        Me.txt_customerCode.Location = New System.Drawing.Point(651, 6)
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
        Me.txt_End.Location = New System.Drawing.Point(355, 6)
        Me.txt_End.Name = "txt_End"
        Me.txt_End.Size = New System.Drawing.Size(97, 26)
        Me.txt_End.TabIndex = 122
        '
        'txt_Start
        '
        Me.txt_Start.CustomFormat = "yyyy/MM/dd"
        Me.txt_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_Start.Location = New System.Drawing.Point(205, 6)
        Me.txt_Start.Name = "txt_Start"
        Me.txt_Start.Size = New System.Drawing.Size(97, 26)
        Me.txt_Start.TabIndex = 122
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(14, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(57, 22)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Filter"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'lbl_customerName
        '
        Me.lbl_customerName.AutoSize = True
        Me.lbl_customerName.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.lbl_customerName.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbl_customerName.Location = New System.Drawing.Point(981, 11)
        Me.lbl_customerName.Name = "lbl_customerName"
        Me.lbl_customerName.Size = New System.Drawing.Size(0, 18)
        Me.lbl_customerName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(315, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "To"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(93, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Ordre Date : "
        '
        'Reonet_ordermasterTableAdapter
        '
        Me.Reonet_ordermasterTableAdapter.ClearBeforeFill = True
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
        'Ds_BaseInfo
        '
        Me.Ds_BaseInfo.DataSetName = "Ds_BaseInfo"
        Me.Ds_BaseInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = Global.ReoNet.My.Resources.Resources.printer
        Me.PictureBox2.Location = New System.Drawing.Point(948, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 130
        Me.PictureBox2.TabStop = False
        '
        'Frm_OrderVw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1354, 739)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_OrderVw"
        Me.Text = "Order View"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbx_DataGridView.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetordermasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ReonetordermasterBindingSource As BindingSource
    Friend WithEvents Ds_Order As Ds_Order
    Friend WithEvents Reonet_ordermasterTableAdapter As Ds_OrderTableAdapters.reonet_ordermasterTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CheckBox1 As CheckBox
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
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CustomerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrdernumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeliverydateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeliverypriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemcountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewButtonColumn
    Friend WithEvents Delete As DataGridViewButtonColumn
    Friend WithEvents Print As DataGridViewButtonColumn
    Friend WithEvents OrderDetilBindingSource As BindingSource
    Friend WithEvents OrderDetilTableAdapter As Ds_OrderTableAdapters.OrderDetilTableAdapter
    Friend WithEvents Ds_BaseInfo As Ds_BaseInfo
    Friend WithEvents PictureBox2 As PictureBox
End Class
