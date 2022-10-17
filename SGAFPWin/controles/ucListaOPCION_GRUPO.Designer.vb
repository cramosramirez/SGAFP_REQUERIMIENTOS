<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaOPCION_GRUPO
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
        Me.ListaOPCION_GRUPOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaOPCION_GRUPODataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_OPCION_GRUPO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_OPCION_MENU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_GRUPO_USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_INGRESO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaOPCION_GRUPOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaOPCION_GRUPODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaOPCION_GRUPOBindingSource
        '
        Me.ListaOPCION_GRUPOBindingSource.DataSource = GetType(SGAFP.EL.OPCION_GRUPO)
        '
        'ListaOPCION_GRUPODataGridView
        '
        Me.ListaOPCION_GRUPODataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaOPCION_GRUPODataGridView.AutoGenerateColumns = False
        Me.ListaOPCION_GRUPODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_OPCION_GRUPO, Me.DataGridViewTextBoxID_OPCION_MENU, Me.DataGridViewTextBoxID_GRUPO_USUARIO, Me.DataGridViewTextBoxFECHA_INGRESO, Me.DataGridViewTextBoxESTADO, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE})
        Me.ListaOPCION_GRUPODataGridView.DataSource = Me.ListaOPCION_GRUPOBindingSource
        Me.ListaOPCION_GRUPODataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaOPCION_GRUPODataGridView.Name = "ListaOPCION_GRUPODataGridView"
        Me.ListaOPCION_GRUPODataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaOPCION_GRUPODataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_OPCION_GRUPO
        '
        Me.DataGridViewTextBoxID_OPCION_GRUPO.DataPropertyName = "ID_OPCION_GRUPO"
        Me.DataGridViewTextBoxID_OPCION_GRUPO.HeaderText = "Id opcion grupo"
        Me.DataGridViewTextBoxID_OPCION_GRUPO.Name = "DataGridViewTextBoxID_OPCION_GRUPO"
        '
        'DataGridViewTextBoxID_OPCION_MENU
        '
        Me.DataGridViewTextBoxID_OPCION_MENU.DataPropertyName = "ID_OPCION_MENU"
        Me.DataGridViewTextBoxID_OPCION_MENU.HeaderText = "Id opcion menu"
        Me.DataGridViewTextBoxID_OPCION_MENU.Name = "DataGridViewTextBoxID_OPCION_MENU"
        '
        'DataGridViewTextBoxID_GRUPO_USUARIO
        '
        Me.DataGridViewTextBoxID_GRUPO_USUARIO.DataPropertyName = "ID_GRUPO_USUARIO"
        Me.DataGridViewTextBoxID_GRUPO_USUARIO.HeaderText = "Id grupo usuario"
        Me.DataGridViewTextBoxID_GRUPO_USUARIO.Name = "DataGridViewTextBoxID_GRUPO_USUARIO"
        '
        'DataGridViewTextBoxFECHA_INGRESO
        '
        Me.DataGridViewTextBoxFECHA_INGRESO.DataPropertyName = "FECHA_INGRESO"
        Me.DataGridViewTextBoxFECHA_INGRESO.HeaderText = "Fecha ingreso"
        Me.DataGridViewTextBoxFECHA_INGRESO.Name = "DataGridViewTextBoxFECHA_INGRESO"
        '
        'DataGridViewTextBoxESTADO
        '
        Me.DataGridViewTextBoxESTADO.DataPropertyName = "ESTADO"
        Me.DataGridViewTextBoxESTADO.HeaderText = "Estado"
        Me.DataGridViewTextBoxESTADO.Name = "DataGridViewTextBoxESTADO"
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
        'ucListaOPCION_GRUPO
        '
        Me.Controls.Add(Me.ListaOPCION_GRUPODataGridView)
        Me.Name = "ucListaOPCION_GRUPO"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaOPCION_GRUPODataGridView, 0)
        CType(Me.ListaOPCION_GRUPOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaOPCION_GRUPODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaOPCION_GRUPOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaOPCION_GRUPODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_OPCION_GRUPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_OPCION_MENU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_GRUPO_USUARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_INGRESO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
