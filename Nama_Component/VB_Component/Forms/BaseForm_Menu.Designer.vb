<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaseForm_Menu
    Inherits BaseForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TaskPane1 = New XPExplorerBar.TaskPane()
        Me.Expando1 = New XPExplorerBar.Expando()
        CType(Me.TaskPane1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TaskPane1.SuspendLayout()
        CType(Me.Expando1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TaskPane1
        '
        Me.TaskPane1.AutoScrollMargin = New System.Drawing.Size(12, 12)
        Me.TaskPane1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TaskPane1.Expandos.AddRange(New XPExplorerBar.Expando() {Me.Expando1})
        Me.TaskPane1.Location = New System.Drawing.Point(6, 57)
        Me.TaskPane1.Name = "TaskPane1"
        Me.TaskPane1.Size = New System.Drawing.Size(264, 307)
        Me.TaskPane1.TabIndex = 0
        Me.TaskPane1.Text = "TaskPane1"
        '
        'Expando1
        '
        Me.Expando1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Expando1.Animate = True
        Me.Expando1.AutoLayout = True
        Me.Expando1.ExpandedHeight = 46
        Me.Expando1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Expando1.Location = New System.Drawing.Point(12, 12)
        Me.Expando1.Name = "Expando1"
        Me.Expando1.Size = New System.Drawing.Size(240, 46)
        Me.Expando1.TabIndex = 0
        Me.Expando1.Text = "Information"
        '
        'BaseForm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(277, 393)
        Me.Controls.Add(Me.TaskPane1)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MinimizeBox = False
        Me.Name = "BaseForm_Menu"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Controls.SetChildIndex(Me.TaskPane1, 0)
        CType(Me.TaskPane1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TaskPane1.ResumeLayout(False)
        CType(Me.Expando1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents TaskPane1 As XPExplorerBar.TaskPane
    Public WithEvents Expando1 As XPExplorerBar.Expando

End Class
