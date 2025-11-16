<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Group
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New CS_Component.TextBox()
        Me.DataGridView1 = New CS_Component.DataGridView()
        Me.lnk_Users = New System.Windows.Forms.LinkLabel()
        Me.DataSet1 = New VB_Component.DataSet1()
        Me.SecGroupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sec_GroupTableAdapter = New VB_Component.DataSet1TableAdapters.sec_GroupTableAdapter()
        Me.SrlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessDeniedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.JoinBlockedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.gbx_GridViewList.SuspendLayout()
        Me.gbx_Controls.SuspendLayout()
        Me.gbx_Btn.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecGroupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Cancel
        '
        Me.btn_Cancel.ImageVerticalAlign = CS_Component.Btn.VerticalAlign.Top
        '
        'btn_Delete
        '
        Me.btn_Delete.ImageVerticalAlign = CS_Component.Btn.VerticalAlign.Top
        Me.btn_Delete.Location = New System.Drawing.Point(238, 19)
        Me.btn_Delete.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        '
        'btn_new
        '
        Me.btn_new.ImageVerticalAlign = CS_Component.Btn.VerticalAlign.Top
        Me.btn_new.Location = New System.Drawing.Point(516, 19)
        Me.btn_new.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        '
        'btn_Edit
        '
        Me.btn_Edit.ImageVerticalAlign = CS_Component.Btn.VerticalAlign.Top
        Me.btn_Edit.Location = New System.Drawing.Point(377, 19)
        Me.btn_Edit.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        '
        'gbx_GridViewList
        '
        Me.gbx_GridViewList.Controls.Add(Me.lnk_Users)
        Me.gbx_GridViewList.Controls.Add(Me.TextBox1)
        Me.gbx_GridViewList.Controls.Add(Me.CheckBox2)
        Me.gbx_GridViewList.Controls.Add(Me.CheckBox1)
        Me.gbx_GridViewList.Controls.Add(Me.Label1)
        Me.gbx_GridViewList.Margin = New System.Windows.Forms.Padding(5)
        Me.gbx_GridViewList.Padding = New System.Windows.Forms.Padding(5)
        Me.gbx_GridViewList.Size = New System.Drawing.Size(654, 119)
        Me.gbx_GridViewList.TabIndex = 0
        '
        'gbx_Controls
        '
        Me.gbx_Controls.Controls.Add(Me.DataGridView1)
        Me.gbx_Controls.Location = New System.Drawing.Point(15, 239)
        Me.gbx_Controls.Margin = New System.Windows.Forms.Padding(5)
        Me.gbx_Controls.Padding = New System.Windows.Forms.Padding(5)
        Me.gbx_Controls.Size = New System.Drawing.Size(654, 252)
        '
        'gbx_Btn
        '
        Me.gbx_Btn.Location = New System.Drawing.Point(15, 169)
        Me.gbx_Btn.Margin = New System.Windows.Forms.Padding(5)
        Me.gbx_Btn.Padding = New System.Windows.Forms.Padding(5)
        Me.gbx_Btn.Size = New System.Drawing.Size(654, 63)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Group Title :"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 85)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(434, 25)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Tag = "JoinBlocked"
        Me.CheckBox1.Text = "Prevent users of this group from accessing the system"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(13, 54)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(305, 25)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Tag = "UsersBlocked"
        Me.CheckBox2.Text = "Prevent users from joining this group"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.CheckExistValueInDb = False
        Me.TextBox1.ColorOnFocus = System.Drawing.Color.Yellow
        Me.TextBox1.CurrencyUnit = "ریال"
        Me.TextBox1.DefaultValue = ""
        Me.TextBox1.FillWithMaxInDb = False
        Me.TextBox1.IsRequired = False
        Me.TextBox1.Location = New System.Drawing.Point(112, 19)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.MaxDecimalLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(535, 27)
        Me.TextBox1.SpellControl = Nothing
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Tag = "GroupName"
        Me.TextBox1.Title = Nothing
        Me.TextBox1.TypeOfContains = CS_Component.TypeOfValues.PersianText
        Me.TextBox1.UseForData = True
        Me.TextBox1.ValidateCheckExistOnEdit = False
        Me.TextBox1.Value = ""
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SrlDataGridViewTextBoxColumn, Me.GroupNameDataGridViewTextBoxColumn, Me.AccessDeniedDataGridViewCheckBoxColumn, Me.JoinBlockedDataGridViewCheckBoxColumn})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.DataSource = Me.SecGroupBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.Location = New System.Drawing.Point(8, 19)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.RowHeadersWidth = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(639, 226)
        Me.DataGridView1.TabIndex = 0
        '
        'lnk_Users
        '
        Me.lnk_Users.AutoSize = True
        Me.lnk_Users.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnk_Users.Location = New System.Drawing.Point(499, 87)
        Me.lnk_Users.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lnk_Users.Name = "lnk_Users"
        Me.lnk_Users.Size = New System.Drawing.Size(146, 21)
        Me.lnk_Users.TabIndex = 3
        Me.lnk_Users.TabStop = True
        Me.lnk_Users.Text = "Show Group Users"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SecGroupBindingSource
        '
        Me.SecGroupBindingSource.DataMember = "sec_Group"
        Me.SecGroupBindingSource.DataSource = Me.DataSet1
        '
        'Sec_GroupTableAdapter
        '
        Me.Sec_GroupTableAdapter.ClearBeforeFill = True
        '
        'SrlDataGridViewTextBoxColumn
        '
        Me.SrlDataGridViewTextBoxColumn.DataPropertyName = "Srl"
        Me.SrlDataGridViewTextBoxColumn.HeaderText = "Srl"
        Me.SrlDataGridViewTextBoxColumn.Name = "SrlDataGridViewTextBoxColumn"
        Me.SrlDataGridViewTextBoxColumn.ReadOnly = True
        Me.SrlDataGridViewTextBoxColumn.Visible = False
        '
        'GroupNameDataGridViewTextBoxColumn
        '
        Me.GroupNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GroupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName"
        Me.GroupNameDataGridViewTextBoxColumn.HeaderText = "GroupName"
        Me.GroupNameDataGridViewTextBoxColumn.Name = "GroupNameDataGridViewTextBoxColumn"
        Me.GroupNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccessDeniedDataGridViewCheckBoxColumn
        '
        Me.AccessDeniedDataGridViewCheckBoxColumn.DataPropertyName = "AccessDenied"
        Me.AccessDeniedDataGridViewCheckBoxColumn.HeaderText = "AccessDenied"
        Me.AccessDeniedDataGridViewCheckBoxColumn.Name = "AccessDeniedDataGridViewCheckBoxColumn"
        Me.AccessDeniedDataGridViewCheckBoxColumn.ReadOnly = True
        Me.AccessDeniedDataGridViewCheckBoxColumn.Width = 120
        '
        'JoinBlockedDataGridViewCheckBoxColumn
        '
        Me.JoinBlockedDataGridViewCheckBoxColumn.DataPropertyName = "JoinBlocked"
        Me.JoinBlockedDataGridViewCheckBoxColumn.HeaderText = "JoinBlocked"
        Me.JoinBlockedDataGridViewCheckBoxColumn.Name = "JoinBlockedDataGridViewCheckBoxColumn"
        Me.JoinBlockedDataGridViewCheckBoxColumn.ReadOnly = True
        Me.JoinBlockedDataGridViewCheckBoxColumn.Width = 120
        '
        'frm_Group
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 533)
        Me.DataGridView = Me.DataGridView1
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frm_Group"
        Me.TableName = "sec_Group"
        Me.Text = "Define User Groups"
        Me.gbx_GridViewList.ResumeLayout(False)
        Me.gbx_GridViewList.PerformLayout()
        Me.gbx_Controls.ResumeLayout(False)
        Me.gbx_Btn.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecGroupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As CS_Component.TextBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As CS_Component.DataGridView
    Friend WithEvents lnk_Users As System.Windows.Forms.LinkLabel
    Friend WithEvents عنوانگروهDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ممنوعیتورودکاربرانDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ممنوعیتعضویتکاربرانDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents SecGroupBindingSource As BindingSource
    Friend WithEvents Sec_GroupTableAdapter As DataSet1TableAdapters.sec_GroupTableAdapter
    Friend WithEvents SrlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccessDeniedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents JoinBlockedDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
