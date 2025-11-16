<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_OrderStatus
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New CS_Component.DataGridView()
        Me.PmSherkatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New CS_Component.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Code = New CS_Component.TextBox()
        Me.cmb_city = New VB_Component.ComboBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReonetorderstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_BaseInfo = New ReoNet.Ds_BaseInfo()
        Me.Reonet_orderstatusTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_orderstatusTableAdapter()
        Me.ReonetservicecategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reonet_servicecategoryTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_servicecategoryTableAdapter()
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PmSherkatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetorderstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetservicecategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(7, 17)
        Me.btn_Cancel.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Delete
        '
        Me.btn_Delete.Location = New System.Drawing.Point(134, 18)
        Me.btn_Delete.Size = New System.Drawing.Size(117, 32)
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(381, 18)
        Me.btn_new.Size = New System.Drawing.Size(117, 32)
        '
        'btn_Edit
        '
        Me.btn_Edit.Location = New System.Drawing.Point(258, 18)
        Me.btn_Edit.Size = New System.Drawing.Size(117, 32)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.DataGridView1)
        Me.gbx_GridViewList.Location = New System.Drawing.Point(14, 40)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(504, 356)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.cmb_city)
        Me.gbx_Controls.Controls.Add(Me.TextBox1)
        Me.gbx_Controls.Controls.Add(Me.txt_Code)
        Me.gbx_Controls.Controls.Add(Me.Label11)
        Me.gbx_Controls.Controls.Add(Me.Label1)
        Me.gbx_Controls.Controls.Add(Me.Label2)
        Me.gbx_Controls.Location = New System.Drawing.Point(14, 457)
        Me.gbx_Controls.Size = New System.Drawing.Size(504, 100)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(14, 402)
        Me.gbx_Btn.Size = New System.Drawing.Size(504, 60)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.CodeDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.ReonetorderstatusBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 11.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 11.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(498, 332)
        Me.DataGridView1.TabIndex = 1
        '
        'PmSherkatBindingSource
        '
        Me.PmSherkatBindingSource.DataMember = "Pm_Sherkat"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Title:"
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
        Me.TextBox1.Location = New System.Drawing.Point(256, 24)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(187, 25)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Tag = "title"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = ""
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(55, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 18)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Service Category:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Code:"
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
        Me.txt_Code.Location = New System.Drawing.Point(108, 24)
        Me.txt_Code.MaxDecimalLength = 2
        Me.txt_Code.Name = "txt_Code"
        Me.txt_Code.ReadOnly = True
        Me.txt_Code.Size = New System.Drawing.Size(80, 25)
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
        'cmb_city
        '
        Me.cmb_city.AutoComplete = True
        Me.cmb_city.DataSource = Me.ReonetservicecategoryBindingSource
        Me.cmb_city.DisplayMember = "title"
        Me.cmb_city.EnterStop = True
        Me.cmb_city.FormattingEnabled = True
        Me.cmb_city.IsRequired = False
        Me.cmb_city.LimitedToList = True
        Me.cmb_city.Location = New System.Drawing.Point(197, 62)
        Me.cmb_city.Name = "cmb_city"
        Me.cmb_city.OpenOnFoucus = False
        Me.cmb_city.Size = New System.Drawing.Size(246, 26)
        Me.cmb_city.TabIndex = 21
        Me.cmb_city.Tag = "srl_servicecategory"
        Me.cmb_city.ValueMember = "Srl"
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
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        Me.CodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.ReadOnly = True
        Me.TitleDataGridViewTextBoxColumn.Width = 200
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
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
        'Reonet_orderstatusTableAdapter
        '
        Me.Reonet_orderstatusTableAdapter.ClearBeforeFill = True
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
        'Frm_OrderStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(532, 598)
        Me.DataGridView = Me.DataGridView1
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.Name = "Frm_OrderStatus"
        Me.TableName = "reonet_orderstatus"
        Me.Text = "Order Status"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Controls.PerformLayout()
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PmSherkatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetorderstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetservicecategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents SrlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents کدDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents نامDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PmSherkatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_Code As CS_Component.TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_city As VB_Component.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReonetorderstatusBindingSource As BindingSource
    Friend WithEvents Ds_BaseInfo As Ds_BaseInfo
    Friend WithEvents Reonet_orderstatusTableAdapter As Ds_BaseInfoTableAdapters.reonet_orderstatusTableAdapter
    Friend WithEvents ReonetservicecategoryBindingSource As BindingSource
    Friend WithEvents Reonet_servicecategoryTableAdapter As Ds_BaseInfoTableAdapters.reonet_servicecategoryTableAdapter
End Class
