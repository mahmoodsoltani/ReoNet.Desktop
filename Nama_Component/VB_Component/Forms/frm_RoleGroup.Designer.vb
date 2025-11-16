<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RoleGroup
    Inherits VB_Component.BaseForm

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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RoleGroup))
        Me.ComboBox1 = New VB_Component.ComboBox()
        Me.SecGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New VB_Component.DataSet1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Sec_GroupTableAdapter = New VB_Component.DataSet1TableAdapters.sec_GroupTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New CS_Component.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New CS_Component.DataGridView()
        Me.RoleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SrlDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SrlRoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecRoleGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_AddGroup = New System.Windows.Forms.Button()
        Me.btn_Remove = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Sec_RoleGroupTableAdapter = New VB_Component.DataSet1TableAdapters.sec_RoleGroupTableAdapter()
        Me.SecRoleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sec_RoleTableAdapter = New VB_Component.DataSet1TableAdapters.sec_RoleTableAdapter()
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SecGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecRoleGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecRoleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoComplete = True
        Me.ComboBox1.DataSource = Me.SecGroupBindingSource
        Me.ComboBox1.DisplayMember = "GroupName"
        Me.ComboBox1.EnterStop = True
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.IsRequired = False
        Me.ComboBox1.LimitedToList = True
        Me.ComboBox1.Location = New System.Drawing.Point(125, 52)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.OpenOnFoucus = False
        Me.ComboBox1.Size = New System.Drawing.Size(562, 27)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.ValueMember = "Srl"
        '
        'SecGroupBindingSource
        '
        Me.SecGroupBindingSource.DataMember = "sec_Group"
        Me.SecGroupBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Group Name:"
        '
        'Sec_GroupTableAdapter
        '
        Me.Sec_GroupTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 98)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(283, 343)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Restrictive List:"
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
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
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
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(4, 24)
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
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(275, 315)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(400, 98)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(283, 343)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Group's Restrictive:"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoleNameDataGridViewTextBoxColumn, Me.SrlDataGridViewTextBoxColumn1, Me.SrlRoleDataGridViewTextBoxColumn})
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView2.DataSource = Me.SecRoleGroupBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(4, 24)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 30
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(275, 315)
        Me.DataGridView2.TabIndex = 0
        '
        'RoleNameDataGridViewTextBoxColumn
        '
        Me.RoleNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RoleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName"
        Me.RoleNameDataGridViewTextBoxColumn.HeaderText = "RoleName"
        Me.RoleNameDataGridViewTextBoxColumn.Name = "RoleNameDataGridViewTextBoxColumn"
        Me.RoleNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SrlDataGridViewTextBoxColumn1
        '
        Me.SrlDataGridViewTextBoxColumn1.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn1.Name = "SrlDataGridViewTextBoxColumn1"
        Me.SrlDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn1.Visible = False
        '
        'SrlRoleDataGridViewTextBoxColumn
        '
        Me.SrlRoleDataGridViewTextBoxColumn.DataPropertyName = "Srl_Role"
        Me.SrlRoleDataGridViewTextBoxColumn.HeaderText = "Srl_Role"
        Me.SrlRoleDataGridViewTextBoxColumn.Name = "SrlRoleDataGridViewTextBoxColumn"
        Me.SrlRoleDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlRoleDataGridViewTextBoxColumn.Visible = False
        '
        'SecRoleGroupBindingSource
        '
        Me.SecRoleGroupBindingSource.DataMember = "sec_RoleGroup"
        Me.SecRoleGroupBindingSource.DataSource = Me.DataSet1
        '
        'btn_AddGroup
        '
        Me.btn_AddGroup.Image = CType(resources.GetObject("btn_AddGroup.Image"), System.Drawing.Image)
        Me.btn_AddGroup.Location = New System.Drawing.Point(320, 291)
        Me.btn_AddGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_AddGroup.Name = "btn_AddGroup"
        Me.btn_AddGroup.Size = New System.Drawing.Size(72, 62)
        Me.btn_AddGroup.TabIndex = 8
        Me.btn_AddGroup.UseVisualStyleBackColor = True
        '
        'btn_Remove
        '
        Me.btn_Remove.Image = CType(resources.GetObject("btn_Remove.Image"), System.Drawing.Image)
        Me.btn_Remove.Location = New System.Drawing.Point(320, 162)
        Me.btn_Remove.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Remove.Name = "btn_Remove"
        Me.btn_Remove.Size = New System.Drawing.Size(72, 62)
        Me.btn_Remove.TabIndex = 9
        Me.btn_Remove.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(338, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ADD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label3.Location = New System.Drawing.Point(325, 269)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "DELETE"
        '
        'Sec_RoleGroupTableAdapter
        '
        Me.Sec_RoleGroupTableAdapter.ClearBeforeFill = True
        '
        'SecRoleBindingSource
        '
        Me.SecRoleBindingSource.DataMember = "sec_Role"
        Me.SecRoleBindingSource.DataSource = Me.DataSet1
        '
        'Sec_RoleTableAdapter
        '
        Me.Sec_RoleTableAdapter.ClearBeforeFill = True
        '
        'SrlDataGridViewTextBoxColumn
        '
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
        'frm_RoleGroup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 482)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_Remove)
        Me.Controls.Add(Me.btn_AddGroup)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_RoleGroup"
        Me.Text = "Restrictive"
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.btn_AddGroup, 0)
        Me.Controls.SetChildIndex(Me.btn_Remove, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        CType(Me.SecGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecRoleGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecRoleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As VB_Component.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents SecGroupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Sec_GroupTableAdapter As DataSet1TableAdapters.sec_GroupTableAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_AddGroup As System.Windows.Forms.Button
    Friend WithEvents btn_Remove As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents عنوانبازدارندهDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As CS_Component.DataGridView
    Friend WithEvents RoleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SrlDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SrlRoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SecRoleGroupBindingSource As BindingSource
    Friend WithEvents Sec_RoleGroupTableAdapter As DataSet1TableAdapters.sec_RoleGroupTableAdapter
    Friend WithEvents SecRoleBindingSource As BindingSource
    Friend WithEvents Sec_RoleTableAdapter As DataSet1TableAdapters.sec_RoleTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoleTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
