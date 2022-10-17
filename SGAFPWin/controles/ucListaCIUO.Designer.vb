<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaCIUO
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
        Me.ListaCIUOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaCIUODataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxCIUO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDESCRIPCION_NACIONAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaCIUOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCIUODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaCIUOBindingSource
        '
        Me.ListaCIUOBindingSource.DataSource = GetType(SGAFP.EL.CIUO)
        '
        'ListaCIUODataGridView
        '
        Me.ListaCIUODataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaCIUODataGridView.AutoGenerateColumns = False
        Me.ListaCIUODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxCIUO, Me.DataGridViewTextBoxDESCRIPCION, Me.DataGridViewTextBoxDESCRIPCION_NACIONAL, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE})
        Me.ListaCIUODataGridView.DataSource = Me.ListaCIUOBindingSource
        Me.ListaCIUODataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaCIUODataGridView.Name = "ListaCIUODataGridView"
        Me.ListaCIUODataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaCIUODataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxCIUO
        '
        Me.DataGridViewTextBoxCIUO.DataPropertyName = "CIUO"
        Me.DataGridViewTextBoxCIUO.HeaderText = "Ciuo"
        Me.DataGridViewTextBoxCIUO.Name = "DataGridViewTextBoxCIUO"
        '
        'DataGridViewTextBoxDESCRIPCION
        '
        Me.DataGridViewTextBoxDESCRIPCION.DataPropertyName = "DESCRIPCION"
        Me.DataGridViewTextBoxDESCRIPCION.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxDESCRIPCION.Name = "DataGridViewTextBoxDESCRIPCION"
        '
        'DataGridViewTextBoxDESCRIPCION_NACIONAL
        '
        Me.DataGridViewTextBoxDESCRIPCION_NACIONAL.DataPropertyName = "DESCRIPCION_NACIONAL"
        Me.DataGridViewTextBoxDESCRIPCION_NACIONAL.HeaderText = "Descripcion nacional"
        Me.DataGridViewTextBoxDESCRIPCION_NACIONAL.Name = "DataGridViewTextBoxDESCRIPCION_NACIONAL"
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
        'ucListaCIUO
        '
        Me.Controls.Add(Me.ListaCIUODataGridView)
        Me.Name = "ucListaCIUO"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaCIUODataGridView, 0)
        CType(Me.ListaCIUOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCIUODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCIUOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaCIUODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxCIUO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDESCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDESCRIPCION_NACIONAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
