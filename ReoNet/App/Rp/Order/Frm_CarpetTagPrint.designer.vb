<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_CarpetTagPrint
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ReonetservicecategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reonet_servicecategoryTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_servicecategoryTableAdapter()
        Me.txt_Barcode = New CS_Component.TextBox()
        Me.Ds_Order = New ReoNet.Ds_Order()
        Me.OrderDetilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderDetilTableAdapter = New ReoNet.Ds_OrderTableAdapters.OrderDetilTableAdapter()
        Me.OrderDetailBarcodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderDetail_BarcodeTableAdapter = New ReoNet.Ds_OrderTableAdapters.OrderDetail_BarcodeTableAdapter()
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.ReonetcompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetservicecategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetailBarcodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 176)
        Me.gbx_Buttons.Size = New System.Drawing.Size(473, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "Print"
        Me.btn_Save.Location = New System.Drawing.Point(369, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.txt_Barcode)
        Me.gbx_Fields.Controls.Add(Me.Label9)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(474, 139)
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
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 23)
        Me.Label9.TabIndex = 151
        Me.Label9.Text = "Barcode:"
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
        'txt_Barcode
        '
        Me.txt_Barcode.CheckExistValueInDb = False
        Me.txt_Barcode.ColorOnFocus = System.Drawing.Color.Yellow
        Me.txt_Barcode.CurrencyUnit = "ریال"
        Me.txt_Barcode.DefaultValue = ""
        Me.txt_Barcode.FillWithMaxInDb = False
        Me.txt_Barcode.IsRequired = False
        Me.txt_Barcode.Location = New System.Drawing.Point(93, 30)
        Me.txt_Barcode.MaxDecimalLength = 2
        Me.txt_Barcode.Multiline = True
        Me.txt_Barcode.Name = "txt_Barcode"
        Me.txt_Barcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Barcode.Size = New System.Drawing.Size(381, 102)
        Me.txt_Barcode.SpellControl = Nothing
        Me.txt_Barcode.TabIndex = 152
        Me.txt_Barcode.Tag = ""
        Me.txt_Barcode.Text = "0"
        Me.txt_Barcode.Title = Nothing
        Me.txt_Barcode.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.txt_Barcode.UseForData = True
        Me.txt_Barcode.ValidateCheckExistOnEdit = False
        Me.txt_Barcode.Value = "0"
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
        'OrderDetailBarcodeBindingSource
        '
        Me.OrderDetailBarcodeBindingSource.DataMember = "OrderDetail_Barcode"
        Me.OrderDetailBarcodeBindingSource.DataSource = Me.Ds_Order
        '
        'OrderDetail_BarcodeTableAdapter
        '
        Me.OrderDetail_BarcodeTableAdapter.ClearBeforeFill = True
        '
        'Frm_CarpetTagPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(500, 264)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_CarpetTagPrint"
        Me.Text = "Carpet Tag Print"
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        Me.gbx_Fields.PerformLayout()
        CType(Me.ReonetcompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetservicecategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetailBarcodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label9 As Label
    Friend WithEvents ReonetservicecategoryBindingSource As BindingSource
    Friend WithEvents Reonet_servicecategoryTableAdapter As Ds_BaseInfoTableAdapters.reonet_servicecategoryTableAdapter
    Friend WithEvents txt_Barcode As CS_Component.TextBox
    Friend WithEvents OrderDetailBarcodeBindingSource As BindingSource
    Friend WithEvents OrderDetail_BarcodeTableAdapter As Ds_OrderTableAdapters.OrderDetail_BarcodeTableAdapter
End Class
