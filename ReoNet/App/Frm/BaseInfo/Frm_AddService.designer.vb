<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_AddService
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
        Me.cmb_serviceunit = New VB_Component.ComboBox()
        Me.ReonetservicetypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_BaseInfo = New ReoNet.Ds_BaseInfo()
        Me.txt_description = New CS_Component.TextBox()
        Me.txt_price = New CS_Component.TextBox()
        Me.txt_name = New CS_Component.TextBox()
        Me.txt_Code = New CS_Component.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Reonet_servicetypeTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_servicetypeTableAdapter()
        Me.chk_active = New System.Windows.Forms.CheckBox()
        Me.chk_isService = New System.Windows.Forms.CheckBox()
        Me.cmb_ServiceCategory = New VB_Component.ComboBox()
        Me.ReonetservicecategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Reonet_servicecategoryTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_servicecategoryTableAdapter()
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.ReonetservicetypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetservicecategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 222)
        Me.gbx_Buttons.Size = New System.Drawing.Size(728, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(624, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.chk_isService)
        Me.gbx_Fields.Controls.Add(Me.chk_active)
        Me.gbx_Fields.Controls.Add(Me.cmb_ServiceCategory)
        Me.gbx_Fields.Controls.Add(Me.cmb_serviceunit)
        Me.gbx_Fields.Controls.Add(Me.txt_description)
        Me.gbx_Fields.Controls.Add(Me.txt_price)
        Me.gbx_Fields.Controls.Add(Me.txt_name)
        Me.gbx_Fields.Controls.Add(Me.txt_Code)
        Me.gbx_Fields.Controls.Add(Me.Label10)
        Me.gbx_Fields.Controls.Add(Me.Label4)
        Me.gbx_Fields.Controls.Add(Me.Label3)
        Me.gbx_Fields.Controls.Add(Me.Label11)
        Me.gbx_Fields.Controls.Add(Me.Label2)
        Me.gbx_Fields.Controls.Add(Me.Label1)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(728, 179)
        '
        'cmb_serviceunit
        '
        Me.cmb_serviceunit.AutoComplete = True
        Me.cmb_serviceunit.DataSource = Me.ReonetservicetypeBindingSource
        Me.cmb_serviceunit.DisplayMember = "name"
        Me.cmb_serviceunit.EnterStop = True
        Me.cmb_serviceunit.FormattingEnabled = True
        Me.cmb_serviceunit.IsRequired = False
        Me.cmb_serviceunit.LimitedToList = True
        Me.cmb_serviceunit.Location = New System.Drawing.Point(341, 65)
        Me.cmb_serviceunit.Name = "cmb_serviceunit"
        Me.cmb_serviceunit.OpenOnFoucus = False
        Me.cmb_serviceunit.Size = New System.Drawing.Size(131, 31)
        Me.cmb_serviceunit.TabIndex = 24
        Me.cmb_serviceunit.Tag = "srl_servicetype"
        Me.cmb_serviceunit.ValueMember = "Srl"
        '
        'ReonetservicetypeBindingSource
        '
        Me.ReonetservicetypeBindingSource.DataMember = "reonet_servicetype"
        Me.ReonetservicetypeBindingSource.DataSource = Me.Ds_BaseInfo
        '
        'Ds_BaseInfo
        '
        Me.Ds_BaseInfo.DataSetName = "Ds_BaseInfo"
        Me.Ds_BaseInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_description
        '
        Me.txt_description.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_description.CheckExistValueInDb = False
        Me.txt_description.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_description.CurrencyUnit = "ریال"
        Me.txt_description.DefaultValue = ""
        Me.txt_description.FillWithMaxInDb = False
        Me.txt_description.IsRequired = False
        Me.txt_description.Location = New System.Drawing.Point(104, 97)
        Me.txt_description.MaxDecimalLength = 2
        Me.txt_description.Multiline = True
        Me.txt_description.Name = "txt_description"
        Me.txt_description.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_description.Size = New System.Drawing.Size(581, 63)
        Me.txt_description.SpellControl = Nothing
        Me.txt_description.TabIndex = 26
        Me.txt_description.Tag = "description"
        Me.txt_description.Title = Nothing
        Me.txt_description.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_description.UseForData = True
        Me.txt_description.ValidateCheckExistOnEdit = False
        Me.txt_description.Value = ""
        '
        'txt_price
        '
        Me.txt_price.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_price.CheckExistValueInDb = False
        Me.txt_price.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_price.CurrencyUnit = "ریال"
        Me.txt_price.DefaultValue = ""
        Me.txt_price.FillWithMaxInDb = False
        Me.txt_price.IsRequired = False
        Me.txt_price.Location = New System.Drawing.Point(555, 65)
        Me.txt_price.MaxDecimalLength = 2
        Me.txt_price.Name = "txt_price"
        Me.txt_price.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_price.Size = New System.Drawing.Size(129, 30)
        Me.txt_price.SpellControl = Nothing
        Me.txt_price.TabIndex = 25
        Me.txt_price.Tag = "price"
        Me.txt_price.Text = "0"
        Me.txt_price.Title = Nothing
        Me.txt_price.TypeOfContains = CS_Component.TypeOfValues.Currency
        Me.txt_price.UseForData = True
        Me.txt_price.ValidateCheckExistOnEdit = False
        Me.txt_price.Value = 0R
        '
        'txt_name
        '
        Me.txt_name.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_name.CheckExistValueInDb = False
        Me.txt_name.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_name.CurrencyUnit = "ریال"
        Me.txt_name.DefaultValue = ""
        Me.txt_name.FillWithMaxInDb = False
        Me.txt_name.IsRequired = False
        Me.txt_name.Location = New System.Drawing.Point(103, 65)
        Me.txt_name.MaxDecimalLength = 2
        Me.txt_name.Name = "txt_name"
        Me.txt_name.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_name.Size = New System.Drawing.Size(148, 30)
        Me.txt_name.SpellControl = Nothing
        Me.txt_name.TabIndex = 23
        Me.txt_name.Tag = "title"
        Me.txt_name.Title = Nothing
        Me.txt_name.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_name.UseForData = True
        Me.txt_name.ValidateCheckExistOnEdit = False
        Me.txt_name.Value = ""
        '
        'txt_Code
        '
        Me.txt_Code.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Code.CheckExistValueInDb = True
        Me.txt_Code.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Code.CurrencyUnit = "ریال"
        Me.txt_Code.DefaultValue = ""
        Me.txt_Code.FillWithMaxInDb = False
        Me.txt_Code.IsRequired = True
        Me.txt_Code.Location = New System.Drawing.Point(103, 31)
        Me.txt_Code.MaxDecimalLength = 2
        Me.txt_Code.Name = "txt_Code"
        Me.txt_Code.ReadOnly = True
        Me.txt_Code.Size = New System.Drawing.Size(100, 30)
        Me.txt_Code.SpellControl = Nothing
        Me.txt_Code.TabIndex = 22
        Me.txt_Code.Tag = "Code"
        Me.txt_Code.Text = "0"
        Me.txt_Code.Title = Nothing
        Me.txt_Code.TypeOfContains = CS_Component.TypeOfValues.Number
        Me.txt_Code.UseForData = True
        Me.txt_Code.ValidateCheckExistOnEdit = False
        Me.txt_Code.Value = 0
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 23)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Description:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(498, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 23)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Price:"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(263, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 23)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Type:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 23)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Title:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 23)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Code:"
        '
        'Reonet_servicetypeTableAdapter
        '
        Me.Reonet_servicetypeTableAdapter.ClearBeforeFill = True
        '
        'chk_active
        '
        Me.chk_active.AutoSize = True
        Me.chk_active.Checked = True
        Me.chk_active.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_active.Location = New System.Drawing.Point(593, 39)
        Me.chk_active.Name = "chk_active"
        Me.chk_active.Size = New System.Drawing.Size(102, 27)
        Me.chk_active.TabIndex = 33
        Me.chk_active.Tag = "isactive"
        Me.chk_active.Text = "Is Active"
        Me.chk_active.UseVisualStyleBackColor = True
        '
        'chk_isService
        '
        Me.chk_isService.AutoSize = True
        Me.chk_isService.Checked = True
        Me.chk_isService.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_isService.Location = New System.Drawing.Point(593, 20)
        Me.chk_isService.Name = "chk_isService"
        Me.chk_isService.Size = New System.Drawing.Size(113, 27)
        Me.chk_isService.TabIndex = 33
        Me.chk_isService.Tag = "is_service"
        Me.chk_isService.Text = "Is Service"
        Me.chk_isService.UseVisualStyleBackColor = True
        '
        'cmb_ServiceCategory
        '
        Me.cmb_ServiceCategory.AutoComplete = True
        Me.cmb_ServiceCategory.DataSource = Me.ReonetservicecategoryBindingSource
        Me.cmb_ServiceCategory.DisplayMember = "title"
        Me.cmb_ServiceCategory.EnterStop = True
        Me.cmb_ServiceCategory.FormattingEnabled = True
        Me.cmb_ServiceCategory.IsRequired = False
        Me.cmb_ServiceCategory.LimitedToList = True
        Me.cmb_ServiceCategory.Location = New System.Drawing.Point(341, 31)
        Me.cmb_ServiceCategory.Name = "cmb_ServiceCategory"
        Me.cmb_ServiceCategory.OpenOnFoucus = False
        Me.cmb_ServiceCategory.Size = New System.Drawing.Size(214, 31)
        Me.cmb_ServiceCategory.TabIndex = 24
        Me.cmb_ServiceCategory.Tag = "srl_servicecategory"
        Me.cmb_ServiceCategory.ValueMember = "Srl"
        '
        'ReonetservicecategoryBindingSource
        '
        Me.ReonetservicecategoryBindingSource.DataMember = "reonet_servicecategory"
        Me.ReonetservicecategoryBindingSource.DataSource = Me.Ds_BaseInfo
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 23)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Category:"
        '
        'Reonet_servicecategoryTableAdapter
        '
        Me.Reonet_servicecategoryTableAdapter.ClearBeforeFill = True
        '
        'Frm_AddService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(755, 318)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_AddService"
        Me.Text = "Add Or Edit service"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.ReonetservicetypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetservicecategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_serviceunit As VB_Component.ComboBox
    Friend WithEvents txt_description As CS_Component.TextBox
    Friend WithEvents txt_price As CS_Component.TextBox
    Friend WithEvents txt_name As CS_Component.TextBox
    Friend WithEvents txt_Code As CS_Component.TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Ds_BaseInfo As Ds_BaseInfo
    Friend WithEvents ReonetservicetypeBindingSource As BindingSource
    Friend WithEvents Reonet_servicetypeTableAdapter As Ds_BaseInfoTableAdapters.reonet_servicetypeTableAdapter
    Friend WithEvents chk_active As CheckBox
    Friend WithEvents chk_isService As CheckBox
    Friend WithEvents cmb_ServiceCategory As VB_Component.ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ReonetservicecategoryBindingSource As BindingSource
    Friend WithEvents Reonet_servicecategoryTableAdapter As Ds_BaseInfoTableAdapters.reonet_servicecategoryTableAdapter
End Class
