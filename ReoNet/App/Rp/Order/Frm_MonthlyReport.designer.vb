<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_MonthlyReport
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
        Me.ReonetcompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_BaseInfo = New ReoNet.Ds_BaseInfo()
        Me.Reonet_companyTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_companyTableAdapter()
        Me.Ds_Order = New ReoNet.Ds_Order()
        Me.OrderDetilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderDetilTableAdapter = New ReoNet.Ds_OrderTableAdapters.OrderDetilTableAdapter()
        Me.txt_ToDate = New System.Windows.Forms.DateTimePicker()
        Me.txt_FromDate = New System.Windows.Forms.DateTimePicker()
        Me.cmb_Company = New VB_Component.ComboBox()
        Me.chk_AllCompany = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_all = New System.Windows.Forms.RadioButton()
        Me.rb_cash = New System.Windows.Forms.RadioButton()
        Me.rb_invoice = New System.Windows.Forms.RadioButton()
        Me.chk_AllService = New System.Windows.Forms.CheckBox()
        Me.cmb_Service = New VB_Component.ComboBox()
        Me.ReonetservicecategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reonet_servicecategoryTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_servicecategoryTableAdapter()
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.ReonetcompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ReonetservicecategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 223)
        Me.gbx_Buttons.Size = New System.Drawing.Size(421, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "Report"
        Me.btn_Save.Location = New System.Drawing.Point(317, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.GroupBox1)
        Me.gbx_Fields.Controls.Add(Me.txt_ToDate)
        Me.gbx_Fields.Controls.Add(Me.txt_FromDate)
        Me.gbx_Fields.Controls.Add(Me.cmb_Service)
        Me.gbx_Fields.Controls.Add(Me.cmb_Company)
        Me.gbx_Fields.Controls.Add(Me.chk_AllService)
        Me.gbx_Fields.Controls.Add(Me.chk_AllCompany)
        Me.gbx_Fields.Controls.Add(Me.Label10)
        Me.gbx_Fields.Controls.Add(Me.Label9)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(422, 186)
        '
        'ReonetcompanyBindingSource
        '
        Me.ReonetcompanyBindingSource.DataMember = "reonet_company"
        Me.ReonetcompanyBindingSource.DataSource = Me.Ds_BaseInfo
        '
        'Ds_BaseInfo
        '
        Me.Ds_BaseInfo.DataSetName = "Ds_BaseInfo"
        Me.Ds_BaseInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Reonet_companyTableAdapter
        '
        Me.Reonet_companyTableAdapter.ClearBeforeFill = True
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
        'txt_ToDate
        '
        Me.txt_ToDate.CustomFormat = "yyyy/MM/dd"
        Me.txt_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_ToDate.Location = New System.Drawing.Point(284, 29)
        Me.txt_ToDate.Name = "txt_ToDate"
        Me.txt_ToDate.Size = New System.Drawing.Size(117, 25)
        Me.txt_ToDate.TabIndex = 154
        '
        'txt_FromDate
        '
        Me.txt_FromDate.CustomFormat = "yyyy/MM/dd"
        Me.txt_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txt_FromDate.Location = New System.Drawing.Point(131, 29)
        Me.txt_FromDate.Name = "txt_FromDate"
        Me.txt_FromDate.Size = New System.Drawing.Size(116, 25)
        Me.txt_FromDate.TabIndex = 153
        '
        'cmb_Company
        '
        Me.cmb_Company.AllowDrop = True
        Me.cmb_Company.AutoComplete = True
        Me.cmb_Company.DataSource = Me.ReonetcompanyBindingSource
        Me.cmb_Company.DisplayMember = "companyname"
        Me.cmb_Company.EnterStop = True
        Me.cmb_Company.FormattingEnabled = True
        Me.cmb_Company.IsRequired = False
        Me.cmb_Company.LimitedToList = False
        Me.cmb_Company.Location = New System.Drawing.Point(131, 60)
        Me.cmb_Company.Name = "cmb_Company"
        Me.cmb_Company.OpenOnFoucus = False
        Me.cmb_Company.Size = New System.Drawing.Size(270, 26)
        Me.cmb_Company.TabIndex = 149
        Me.cmb_Company.ValueMember = "Srl"
        '
        'chk_AllCompany
        '
        Me.chk_AllCompany.AutoSize = True
        Me.chk_AllCompany.Location = New System.Drawing.Point(24, 64)
        Me.chk_AllCompany.Name = "chk_AllCompany"
        Me.chk_AllCompany.Size = New System.Drawing.Size(107, 22)
        Me.chk_AllCompany.TabIndex = 152
        Me.chk_AllCompany.Text = "All Company"
        Me.chk_AllCompany.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(252, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 18)
        Me.Label10.TabIndex = 150
        Me.Label10.Text = "To"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 18)
        Me.Label9.TabIndex = 151
        Me.Label9.Text = "Date: From"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_invoice)
        Me.GroupBox1.Controls.Add(Me.rb_cash)
        Me.GroupBox1.Controls.Add(Me.rb_all)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 47)
        Me.GroupBox1.TabIndex = 155
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Type"
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
        'chk_AllService
        '
        Me.chk_AllService.AutoSize = True
        Me.chk_AllService.Location = New System.Drawing.Point(24, 101)
        Me.chk_AllService.Name = "chk_AllService"
        Me.chk_AllService.Size = New System.Drawing.Size(91, 22)
        Me.chk_AllService.TabIndex = 152
        Me.chk_AllService.Text = "All Service"
        Me.chk_AllService.UseVisualStyleBackColor = True
        '
        'cmb_Service
        '
        Me.cmb_Service.AllowDrop = True
        Me.cmb_Service.AutoComplete = True
        Me.cmb_Service.DataSource = Me.ReonetservicecategoryBindingSource
        Me.cmb_Service.DisplayMember = "title"
        Me.cmb_Service.EnterStop = True
        Me.cmb_Service.FormattingEnabled = True
        Me.cmb_Service.IsRequired = False
        Me.cmb_Service.LimitedToList = False
        Me.cmb_Service.Location = New System.Drawing.Point(131, 97)
        Me.cmb_Service.Name = "cmb_Service"
        Me.cmb_Service.OpenOnFoucus = False
        Me.cmb_Service.Size = New System.Drawing.Size(270, 26)
        Me.cmb_Service.TabIndex = 149
        Me.cmb_Service.ValueMember = "Srl"
        '
        'ReonetservicecategoryBindingSource
        '
        Me.ReonetservicecategoryBindingSource.DataMember = "reonet_servicecategory"
        Me.ReonetservicecategoryBindingSource.DataSource = Me.Ds_BaseInfo
        '
        'Reonet_servicecategoryTableAdapter
        '
        Me.Reonet_servicecategoryTableAdapter.ClearBeforeFill = True
        '
        'Frm_MonthlyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(448, 311)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_MonthlyReport"
        Me.Text = "Company Orders Report"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.ReonetcompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ReonetservicecategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Ds_BaseInfo As Ds_BaseInfo
    Friend WithEvents ReonetcompanyBindingSource As BindingSource
    Friend WithEvents Reonet_companyTableAdapter As Ds_BaseInfoTableAdapters.reonet_companyTableAdapter
    Friend WithEvents Ds_Order As Ds_Order
    Friend WithEvents OrderDetilBindingSource As BindingSource
    Friend WithEvents OrderDetilTableAdapter As Ds_OrderTableAdapters.OrderDetilTableAdapter
    Friend WithEvents txt_ToDate As DateTimePicker
    Friend WithEvents txt_FromDate As DateTimePicker
    Friend WithEvents cmb_Company As VB_Component.ComboBox
    Friend WithEvents chk_AllCompany As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_invoice As RadioButton
    Friend WithEvents rb_cash As RadioButton
    Friend WithEvents rb_all As RadioButton
    Friend WithEvents cmb_Service As VB_Component.ComboBox
    Friend WithEvents chk_AllService As CheckBox
    Friend WithEvents ReonetservicecategoryBindingSource As BindingSource
    Friend WithEvents Reonet_servicecategoryTableAdapter As Ds_BaseInfoTableAdapters.reonet_servicecategoryTableAdapter
End Class
