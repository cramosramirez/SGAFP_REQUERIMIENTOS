<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaCIUU
    Inherits SGAFP.ucBaseLista

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ListaCIUUBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaCIUUDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxCIUU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDESCRIPCION_CIIU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaCIUUBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCIUUDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaCIUUBindingSource
        '
        Me.ListaCIUUBindingSource.DataSource = GetType(SGAFP.EL.CIUU)
        '
        'ListaCIUUDataGridView
        '
        Me.ListaCIUUDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaCIUUDataGridView.AutoGenerateColumns = False
        Me.ListaCIUUDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxCIUU, Me.DataGridViewTextBoxDESCRIPCION_CIIU, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE})
        Me.ListaCIUUDataGridView.DataSource = Me.ListaCIUUBindingSource
        Me.ListaCIUUDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaCIUUDataGridView.Name = "ListaCIUUDataGridView"
        Me.ListaCIUUDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaCIUUDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxCIUU
        '
        Me.DataGridViewTextBoxCIUU.DataPropertyName = "CIUU"
        Me.DataGridViewTextBoxCIUU.HeaderText = "Ciuu"
        Me.DataGridViewTextBoxCIUU.Name = "DataGridViewTextBoxCIUU"
        '
        'DataGridViewTextBoxDESCRIPCION_CIIU
        '
        Me.DataGridViewTextBoxDESCRIPCION_CIIU.DataPropertyName = "DESCRIPCION_CIIU"
        Me.DataGridViewTextBoxDESCRIPCION_CIIU.HeaderText = "Descripcion ciiu"
        Me.DataGridViewTextBoxDESCRIPCION_CIIU.Name = "DataGridViewTextBoxDESCRIPCION_CIIU"
        '
        'DataGridViewTextBoxUSERID
        '
        Me.DataGridViewTextBoxUSERID.DataPropertyName = "USERID"
        Me.DataGridViewTextBoxUSERID.HeaderText = "Userid"
        Me.DataGridViewTextBoxUSERID.Name = "DataGridViewTextBoxUSERID"
        '
        'DataGridViewTextBoxLASTUPDATE
        '
        Me.DataGridViewTextBoxLASTUPDATE.DataPropertyName = "LASTUPDATE"
        Me.DataGridViewTextBoxLASTUPDATE.HeaderText = "Lastupdate"
        Me.DataGridViewTextBoxLASTUPDATE.Name = "DataGridViewTextBoxLASTUPDATE"
        '
        'ucListaCIUU
        '
        Me.Controls.Add(Me.ListaCIUUDataGridView)
        Me.Name = "ucListaCIUU"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaCIUUDataGridView, 0)
        CType(Me.ListaCIUUBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCIUUDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCIUUBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaCIUUDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxCIUU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDESCRIPCION_CIIU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
