<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaEVALUACION_AF
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
        Me.ListaEVALUACION_AFBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaEVALUACION_AFDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_EVALUACION_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_EVALUACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTEMA_EVALUACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxEVALUADOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTIPO_EVALUACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPORC_APROBACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPORC_REPROBADOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaEVALUACION_AFBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaEVALUACION_AFDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaEVALUACION_AFBindingSource
        '
        Me.ListaEVALUACION_AFBindingSource.DataSource = GetType(SGAFP.EL.EVALUACION_AF)
        '
        'ListaEVALUACION_AFDataGridView
        '
        Me.ListaEVALUACION_AFDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaEVALUACION_AFDataGridView.AutoGenerateColumns = False
        Me.ListaEVALUACION_AFDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_EVALUACION_AF, Me.DataGridViewTextBoxID_ACCION_FORMATIVA, Me.DataGridViewTextBoxFECHA_EVALUACION, Me.DataGridViewTextBoxTEMA_EVALUACION, Me.DataGridViewTextBoxNOTAS, Me.DataGridViewTextBoxEVALUADOR, Me.DataGridViewTextBoxTIPO_EVALUACION, Me.DataGridViewTextBoxPORC_APROBACION, Me.DataGridViewTextBoxPORC_REPROBADOS})
        Me.ListaEVALUACION_AFDataGridView.DataSource = Me.ListaEVALUACION_AFBindingSource
        Me.ListaEVALUACION_AFDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaEVALUACION_AFDataGridView.Name = "ListaEVALUACION_AFDataGridView"
        Me.ListaEVALUACION_AFDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaEVALUACION_AFDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_EVALUACION_AF
        '
        Me.DataGridViewTextBoxID_EVALUACION_AF.DataPropertyName = "ID_EVALUACION_AF"
        Me.DataGridViewTextBoxID_EVALUACION_AF.HeaderText = "Id evaluacion af"
        Me.DataGridViewTextBoxID_EVALUACION_AF.Name = "DataGridViewTextBoxID_EVALUACION_AF"
        '
        'DataGridViewTextBoxID_ACCION_FORMATIVA
        '
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.DataPropertyName = "ID_ACCION_FORMATIVA"
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.HeaderText = "Id accion formativa"
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.Name = "DataGridViewTextBoxID_ACCION_FORMATIVA"
        '
        'DataGridViewTextBoxFECHA_EVALUACION
        '
        Me.DataGridViewTextBoxFECHA_EVALUACION.DataPropertyName = "FECHA_EVALUACION"
        Me.DataGridViewTextBoxFECHA_EVALUACION.HeaderText = "Fecha evaluacion"
        Me.DataGridViewTextBoxFECHA_EVALUACION.Name = "DataGridViewTextBoxFECHA_EVALUACION"
        '
        'DataGridViewTextBoxTEMA_EVALUACION
        '
        Me.DataGridViewTextBoxTEMA_EVALUACION.DataPropertyName = "TEMA_EVALUACION"
        Me.DataGridViewTextBoxTEMA_EVALUACION.HeaderText = "Tema evaluacion"
        Me.DataGridViewTextBoxTEMA_EVALUACION.Name = "DataGridViewTextBoxTEMA_EVALUACION"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'DataGridViewTextBoxEVALUADOR
        '
        Me.DataGridViewTextBoxEVALUADOR.DataPropertyName = "EVALUADOR"
        Me.DataGridViewTextBoxEVALUADOR.HeaderText = "Evaluador"
        Me.DataGridViewTextBoxEVALUADOR.Name = "DataGridViewTextBoxEVALUADOR"
        '
        'DataGridViewTextBoxTIPO_EVALUACION
        '
        Me.DataGridViewTextBoxTIPO_EVALUACION.DataPropertyName = "TIPO_EVALUACION"
        Me.DataGridViewTextBoxTIPO_EVALUACION.HeaderText = "Tipo evaluacion"
        Me.DataGridViewTextBoxTIPO_EVALUACION.Name = "DataGridViewTextBoxTIPO_EVALUACION"
        '
        'DataGridViewTextBoxPORC_APROBACION
        '
        Me.DataGridViewTextBoxPORC_APROBACION.DataPropertyName = "PORC_APROBACION"
        Me.DataGridViewTextBoxPORC_APROBACION.HeaderText = "Porc aprobacion"
        Me.DataGridViewTextBoxPORC_APROBACION.Name = "DataGridViewTextBoxPORC_APROBACION"
        '
        'DataGridViewTextBoxPORC_REPROBADOS
        '
        Me.DataGridViewTextBoxPORC_REPROBADOS.DataPropertyName = "PORC_REPROBADOS"
        Me.DataGridViewTextBoxPORC_REPROBADOS.HeaderText = "Porc reprobados"
        Me.DataGridViewTextBoxPORC_REPROBADOS.Name = "DataGridViewTextBoxPORC_REPROBADOS"
        '
        'ucListaEVALUACION_AF
        '
        Me.Controls.Add(Me.ListaEVALUACION_AFDataGridView)
        Me.Name = "ucListaEVALUACION_AF"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaEVALUACION_AFDataGridView, 0)
        CType(Me.ListaEVALUACION_AFBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaEVALUACION_AFDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaEVALUACION_AFBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaEVALUACION_AFDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_EVALUACION_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_ACCION_FORMATIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_EVALUACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTEMA_EVALUACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxEVALUADOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTIPO_EVALUACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPORC_APROBACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPORC_REPROBADOS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
