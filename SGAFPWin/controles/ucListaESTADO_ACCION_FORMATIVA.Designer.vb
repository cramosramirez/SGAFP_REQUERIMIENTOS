<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaESTADO_ACCION_FORMATIVA
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
        Me.ListaESTADO_ACCION_FORMATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaESTADO_ACCION_FORMATIVADataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxCODIGO_ESTADO_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOMBRE_ESTADO_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxESTADO_INICIAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPERMITE_INSCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxESTADO_FINAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaESTADO_ACCION_FORMATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaESTADO_ACCION_FORMATIVADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaESTADO_ACCION_FORMATIVABindingSource
        '
        Me.ListaESTADO_ACCION_FORMATIVABindingSource.DataSource = GetType(SGAFP.EL.ESTADO_ACCION_FORMATIVA)
        '
        'ListaESTADO_ACCION_FORMATIVADataGridView
        '
        Me.ListaESTADO_ACCION_FORMATIVADataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaESTADO_ACCION_FORMATIVADataGridView.AutoGenerateColumns = False
        Me.ListaESTADO_ACCION_FORMATIVADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxCODIGO_ESTADO_AF, Me.DataGridViewTextBoxNOMBRE_ESTADO_AF, Me.DataGridViewTextBoxESTADO_INICIAL, Me.DataGridViewTextBoxPERMITE_INSCRIPCION, Me.DataGridViewTextBoxESTADO_FINAL, Me.DataGridViewTextBoxNOTAS})
        Me.ListaESTADO_ACCION_FORMATIVADataGridView.DataSource = Me.ListaESTADO_ACCION_FORMATIVABindingSource
        Me.ListaESTADO_ACCION_FORMATIVADataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaESTADO_ACCION_FORMATIVADataGridView.Name = "ListaESTADO_ACCION_FORMATIVADataGridView"
        Me.ListaESTADO_ACCION_FORMATIVADataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaESTADO_ACCION_FORMATIVADataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxCODIGO_ESTADO_AF
        '
        Me.DataGridViewTextBoxCODIGO_ESTADO_AF.DataPropertyName = "CODIGO_ESTADO_AF"
        Me.DataGridViewTextBoxCODIGO_ESTADO_AF.HeaderText = "Codigo estado af"
        Me.DataGridViewTextBoxCODIGO_ESTADO_AF.Name = "DataGridViewTextBoxCODIGO_ESTADO_AF"
        '
        'DataGridViewTextBoxNOMBRE_ESTADO_AF
        '
        Me.DataGridViewTextBoxNOMBRE_ESTADO_AF.DataPropertyName = "NOMBRE_ESTADO_AF"
        Me.DataGridViewTextBoxNOMBRE_ESTADO_AF.HeaderText = "Nombre estado af"
        Me.DataGridViewTextBoxNOMBRE_ESTADO_AF.Name = "DataGridViewTextBoxNOMBRE_ESTADO_AF"
        '
        'DataGridViewTextBoxESTADO_INICIAL
        '
        Me.DataGridViewTextBoxESTADO_INICIAL.DataPropertyName = "ESTADO_INICIAL"
        Me.DataGridViewTextBoxESTADO_INICIAL.HeaderText = "Estado inicial"
        Me.DataGridViewTextBoxESTADO_INICIAL.Name = "DataGridViewTextBoxESTADO_INICIAL"
        '
        'DataGridViewTextBoxPERMITE_INSCRIPCION
        '
        Me.DataGridViewTextBoxPERMITE_INSCRIPCION.DataPropertyName = "PERMITE_INSCRIPCION"
        Me.DataGridViewTextBoxPERMITE_INSCRIPCION.HeaderText = "Permite inscripcion"
        Me.DataGridViewTextBoxPERMITE_INSCRIPCION.Name = "DataGridViewTextBoxPERMITE_INSCRIPCION"
        '
        'DataGridViewTextBoxESTADO_FINAL
        '
        Me.DataGridViewTextBoxESTADO_FINAL.DataPropertyName = "ESTADO_FINAL"
        Me.DataGridViewTextBoxESTADO_FINAL.HeaderText = "Estado final"
        Me.DataGridViewTextBoxESTADO_FINAL.Name = "DataGridViewTextBoxESTADO_FINAL"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'ucListaESTADO_ACCION_FORMATIVA
        '
        Me.Controls.Add(Me.ListaESTADO_ACCION_FORMATIVADataGridView)
        Me.Name = "ucListaESTADO_ACCION_FORMATIVA"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaESTADO_ACCION_FORMATIVADataGridView, 0)
        CType(Me.ListaESTADO_ACCION_FORMATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaESTADO_ACCION_FORMATIVADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaESTADO_ACCION_FORMATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaESTADO_ACCION_FORMATIVADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxCODIGO_ESTADO_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOMBRE_ESTADO_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxESTADO_INICIAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPERMITE_INSCRIPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxESTADO_FINAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
