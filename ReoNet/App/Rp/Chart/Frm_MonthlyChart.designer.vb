<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_MonthlyChart
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.ReonetcompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_BaseInfo = New ReoNet.Ds_BaseInfo()
        Me.Reonet_companyTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_companyTableAdapter()
        Me.Ds_Order = New ReoNet.Ds_Order()
        Me.OrderDetilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderDetilTableAdapter = New ReoNet.Ds_OrderTableAdapters.OrderDetilTableAdapter()
        Me.ReonetservicecategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reonet_servicecategoryTableAdapter = New ReoNet.Ds_BaseInfoTableAdapters.reonet_servicecategoryTableAdapter()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Ds_Order1 = New ReoNet.Ds_Order()
        Me.ReonetMonthlyChartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Reonet_MonthlyChartTableAdapter = New ReoNet.Ds_OrderTableAdapters.reonet_MonthlyChartTableAdapter()
        Me.gbx_Buttons.SuspendLayout()
        Me.gbx_Fields.SuspendLayout()
        CType(Me.ReonetcompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDetilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetservicecategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_Order1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReonetMonthlyChartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Buttons
        '
        Me.gbx_Buttons.Location = New System.Drawing.Point(14, 444)
        Me.gbx_Buttons.Size = New System.Drawing.Size(1212, 56)
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(11, 19)
        Me.btn_Cancel.Size = New System.Drawing.Size(91, 29)
        '
        'btn_Save
        '
        Me.btn_Save.HeaderText = "Print"
        Me.btn_Save.Location = New System.Drawing.Point(1108, 19)
        Me.btn_Save.Size = New System.Drawing.Size(91, 29)
        '
        'gbx_Fields
        '
        Me.gbx_Fields.Controls.Add(Me.Chart1)
        Me.gbx_Fields.Location = New System.Drawing.Point(14, 40)
        Me.gbx_Fields.Size = New System.Drawing.Size(1213, 407)
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
        'ReonetservicecategoryBindingSource
        '
        Me.ReonetservicecategoryBindingSource.DataMember = "reonet_servicecategory"
        Me.ReonetservicecategoryBindingSource.DataSource = Me.Ds_BaseInfo
        '
        'Reonet_servicecategoryTableAdapter
        '
        Me.Reonet_servicecategoryTableAdapter.ClearBeforeFill = True
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(3, 21)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(1207, 383)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Ds_Order1
        '
        Me.Ds_Order1.DataSetName = "Ds_Order"
        Me.Ds_Order1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReonetMonthlyChartBindingSource
        '
        Me.ReonetMonthlyChartBindingSource.DataMember = "reonet_MonthlyChart"
        Me.ReonetMonthlyChartBindingSource.DataSource = Me.Ds_Order1
        '
        'Reonet_MonthlyChartTableAdapter
        '
        Me.Reonet_MonthlyChartTableAdapter.ClearBeforeFill = True
        '
        'Frm_MonthlyChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1239, 532)
        Me.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Name = "Frm_MonthlyChart"
        Me.Text = "Carpet Tag Print"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbx_Buttons.ResumeLayout(False)
        Me.gbx_Fields.ResumeLayout(False)
        CType(Me.ReonetcompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_BaseInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDetilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetservicecategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_Order1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReonetMonthlyChartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ReonetservicecategoryBindingSource As BindingSource
    Friend WithEvents Reonet_servicecategoryTableAdapter As Ds_BaseInfoTableAdapters.reonet_servicecategoryTableAdapter
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Ds_Order1 As Ds_Order
    Friend WithEvents ReonetMonthlyChartBindingSource As BindingSource
    Friend WithEvents Reonet_MonthlyChartTableAdapter As Ds_OrderTableAdapters.reonet_MonthlyChartTableAdapter
End Class
