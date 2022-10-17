<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaGRUPO_USUARIO
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
        Me.ListaGRUPO_USUARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaGRUPO_USUARIODataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_GRUPO_USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxROL_USUARIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNIVEL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaGRUPO_USUARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaGRUPO_USUARIODataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaGRUPO_USUARIOBindingSource
        '
        Me.ListaGRUPO_USUARIOBindingSource.DataSource = GetType(SGAFP.EL.GRUPO_USUARIO)
        '
        'ListaGRUPO_USUARIODataGridView
        '
        Me.ListaGRUPO_USUARIODataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaGRUPO_USUARIODataGridView.AutoGenerateColumns = False
        Me.ListaGRUPO_USUARIODataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_GRUPO_USUARIO, Me.DataGridViewTextBoxROL_USUARIO, Me.DataGridViewTextBoxNIVEL, Me.DataGridViewTextBoxNOTAS})
        Me.ListaGRUPO_USUARIODataGridView.DataSource = Me.ListaGRUPO_USUARIOBindingSource
        Me.ListaGRUPO_USUARIODataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaGRUPO_USUARIODataGridView.Name = "ListaGRUPO_USUARIODataGridView"
        Me.ListaGRUPO_USUARIODataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaGRUPO_USUARIODataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_GRUPO_USUARIO
        '
        Me.DataGridViewTextBoxID_GRUPO_USUARIO.DataPropertyName = "ID_GRUPO_USUARIO"
        Me.DataGridViewTextBoxID_GRUPO_USUARIO.HeaderText = "Id grupo usuario"
        Me.DataGridViewTextBoxID_GRUPO_USUARIO.Name = "DataGridViewTextBoxID_GRUPO_USUARIO"
        '
        'DataGridViewTextBoxROL_USUARIO
        '
        Me.DataGridViewTextBoxROL_USUARIO.DataPropertyName = "ROL_USUARIO"
        Me.DataGridViewTextBoxROL_USUARIO.HeaderText = "Rol usuario"
        Me.DataGridViewTextBoxROL_USUARIO.Name = "DataGridViewTextBoxROL_USUARIO"
        '
        'DataGridViewTextBoxNIVEL
        '
        Me.DataGridViewTextBoxNIVEL.DataPropertyName = "NIVEL"
        Me.DataGridViewTextBoxNIVEL.HeaderText = "Nivel"
        Me.DataGridViewTextBoxNIVEL.Name = "DataGridViewTextBoxNIVEL"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'ucListaGRUPO_USUARIO
        '
        Me.Controls.Add(Me.ListaGRUPO_USUARIODataGridView)
        Me.Name = "ucListaGRUPO_USUARIO"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaGRUPO_USUARIODataGridView, 0)
        CType(Me.ListaGRUPO_USUARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaGRUPO_USUARIODataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaGRUPO_USUARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaGRUPO_USUARIODataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_GRUPO_USUARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxROL_USUARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNIVEL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
