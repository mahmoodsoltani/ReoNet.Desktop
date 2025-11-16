<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Role
    Inherits VB_Component.BaseForm_Layer

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New CS_Component.TextBox()
        Me.DataGridView1 = New CS_Component.DataGridView()
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecRoleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New VB_Component.DataSet1()
        Me.Sec_RoleTableAdapter = New VB_Component.DataSet1TableAdapters.sec_RoleTableAdapter()
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecRoleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.ImageVerticalAlign = CS_Component.Btn.VerticalAlign.Top
        '
        'btn_Delete
        '
        Me.btn_Delete.ImageVerticalAlign = CS_Component.Btn.VerticalAlign.Top
        Me.btn_Delete.Location = New System.Drawing.Point(147, 19)
        Me.btn_Delete.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        '
        'btn_new
        '
        Me.btn_new.ImageVerticalAlign = CS_Component.Btn.VerticalAlign.Top
        Me.btn_new.Location = New System.Drawing.Point(424, 19)
        Me.btn_new.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        '
        'btn_Edit
        '
        Me.btn_Edit.ImageVerticalAlign = CS_Component.Btn.VerticalAlign.Top
        Me.btn_Edit.Location = New System.Drawing.Point(285, 19)
        Me.btn_Edit.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.TextBox1)
        Me.gbx_GridViewList.Controls.Add(Me.Label1)
        Me.gbx_GridViewList.Margin = New System.Windows.Forms.Padding(5)
        Me.gbx_GridViewList.Padding = New System.Windows.Forms.Padding(5)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(563, 64)
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.DataGridView1)
        Me.gbx_Controls.Location = New System.Drawing.Point(15, 175)
        Me.gbx_Controls.Margin = New System.Windows.Forms.Padding(5)
        Me.gbx_Controls.Padding = New System.Windows.Forms.Padding(5)
        Me.gbx_Controls.Size = New System.Drawing.Size(563, 248)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(15, 114)
        Me.gbx_Btn.Margin = New System.Windows.Forms.Padding(5)
        Me.gbx_Btn.Padding = New System.Windows.Forms.Padding(5)
        Me.gbx_Btn.Size = New System.Drawing.Size(563, 63)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Restrictive Title:"
        '
        'TextBox1
        '
        Me.TextBox1.CheckExistValueInDb = False
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = ""
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = False
        Me.TextBox1.Location = New System.Drawing.Point(143, 26)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(412, 27)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Tag = "RoleName"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.EnglishText
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = ""
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.RoleTitleDataGridViewTextBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.SecRoleBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(8, 26)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(548, 215)
        Me.DataGridView1.TabIndex = 0
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'RoleTitleDataGridViewTextBoxColumn
        '
        Me.RoleTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RoleTitleDataGridViewTextBoxColumn.DataPropertyName = "RoleTitle"
        Me.RoleTitleDataGridViewTextBoxColumn.HeaderText = "RoleTitle"
        Me.RoleTitleDataGridViewTextBoxColumn.Name = "RoleTitleDataGridViewTextBoxColumn"
        Me.RoleTitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SecRoleBindingSource
        '
        Me.SecRoleBindingSource.DataMember = "sec_Role"
        Me.SecRoleBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sec_RoleTableAdapter
        '
        Me.Sec_RoleTableAdapter.ClearBeforeFill = True
        '
        'frm_Role
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 466)
        Me.DataGridView = Me.DataGridView1
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frm_Role"
        Me.TableName = "sec_Role"
        Me.Text = "Restrictive Title"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_GridViewList.PerformLayout()
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecRoleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents عنوانبازدارندهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents SecRoleBindingSource As BindingSource
    Friend WithEvents Sec_RoleTableAdapter As DataSet1TableAdapters.sec_RoleTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoleTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
