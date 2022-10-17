<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaINFORME_FINAL_DET
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
        Me.ListaINFORME_FINAL_DETBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaINFORME_FINAL_DETDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_INFORME_FINAL_DET = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_INFORME_FINAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_PARTICIPANTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTA_OBTENIDA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPORC_ASISTENCIA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxMONTO_SOLICITADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxMONTO_APROBADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaINFORME_FINAL_DETBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaINFORME_FINAL_DETDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaINFORME_FINAL_DETBindingSource
        '
        Me.ListaINFORME_FINAL_DETBindingSource.DataSource = GetType(SGAFP.EL.INFORME_FINAL_DET)
        '
        'ListaINFORME_FINAL_DETDataGridView
        '
        Me.ListaINFORME_FINAL_DETDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaINFORME_FINAL_DETDataGridView.AutoGenerateColumns = False
        Me.ListaINFORME_FINAL_DETDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_INFORME_FINAL_DET, Me.DataGridViewTextBoxID_INFORME_FINAL, Me.DataGridViewTextBoxID_PARTICIPANTE, Me.DataGridViewTextBoxID_ACCION_FORMATIVA, Me.DataGridViewTextBoxNOTA_OBTENIDA, Me.DataGridViewTextBoxPORC_ASISTENCIA, Me.DataGridViewTextBoxMONTO_SOLICITADO, Me.DataGridViewTextBoxMONTO_APROBADO, Me.DataGridViewTextBoxESTADO, Me.DataGridViewTextBoxNOTAS})
        Me.ListaINFORME_FINAL_DETDataGridView.DataSource = Me.ListaINFORME_FINAL_DETBindingSource
        Me.ListaINFORME_FINAL_DETDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaINFORME_FINAL_DETDataGridView.Name = "ListaINFORME_FINAL_DETDataGridView"
        Me.ListaINFORME_FINAL_DETDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaINFORME_FINAL_DETDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_INFORME_FINAL_DET
        '
        Me.DataGridViewTextBoxID_INFORME_FINAL_DET.DataPropertyName = "ID_INFORME_FINAL_DET"
        Me.DataGridViewTextBoxID_INFORME_FINAL_DET.HeaderText = "Id informe final det"
        Me.DataGridViewTextBoxID_INFORME_FINAL_DET.Name = "DataGridViewTextBoxID_INFORME_FINAL_DET"
        '
        'DataGridViewTextBoxID_INFORME_FINAL
        '
        Me.DataGridViewTextBoxID_INFORME_FINAL.DataPropertyName = "ID_INFORME_FINAL"
        Me.DataGridViewTextBoxID_INFORME_FINAL.HeaderText = "Id informe final"
        Me.DataGridViewTextBoxID_INFORME_FINAL.Name = "DataGridViewTextBoxID_INFORME_FINAL"
        '
        'DataGridViewTextBoxID_PARTICIPANTE
        '
        Me.DataGridViewTextBoxID_PARTICIPANTE.DataPropertyName = "ID_PARTICIPANTE"
        Me.DataGridViewTextBoxID_PARTICIPANTE.HeaderText = "Id participante"
        Me.DataGridViewTextBoxID_PARTICIPANTE.Name = "DataGridViewTextBoxID_PARTICIPANTE"
        '
        'DataGridViewTextBoxID_ACCION_FORMATIVA
        '
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.DataPropertyName = "ID_ACCION_FORMATIVA"
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.HeaderText = "Id accion formativa"
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.Name = "DataGridViewTextBoxID_ACCION_FORMATIVA"
        '
        'DataGridViewTextBoxNOTA_OBTENIDA
        '
        Me.DataGridViewTextBoxNOTA_OBTENIDA.DataPropertyName = "NOTA_OBTENIDA"
        Me.DataGridViewTextBoxNOTA_OBTENIDA.HeaderText = "Nota obtenida"
        Me.DataGridViewTextBoxNOTA_OBTENIDA.Name = "DataGridViewTextBoxNOTA_OBTENIDA"
        '
        'DataGridViewTextBoxPORC_ASISTENCIA
        '
        Me.DataGridViewTextBoxPORC_ASISTENCIA.DataPropertyName = "PORC_ASISTENCIA"
        Me.DataGridViewTextBoxPORC_ASISTENCIA.HeaderText = "Porc asistencia"
        Me.DataGridViewTextBoxPORC_ASISTENCIA.Name = "DataGridViewTextBoxPORC_ASISTENCIA"
        '
        'DataGridViewTextBoxMONTO_SOLICITADO
        '
        Me.DataGridViewTextBoxMONTO_SOLICITADO.DataPropertyName = "MONTO_SOLICITADO"
        Me.DataGridViewTextBoxMONTO_SOLICITADO.HeaderText = "Monto solicitado"
        Me.DataGridViewTextBoxMONTO_SOLICITADO.Name = "DataGridViewTextBoxMONTO_SOLICITADO"
        '
        'DataGridViewTextBoxMONTO_APROBADO
        '
        Me.DataGridViewTextBoxMONTO_APROBADO.DataPropertyName = "MONTO_APROBADO"
        Me.DataGridViewTextBoxMONTO_APROBADO.HeaderText = "Monto aprobado"
        Me.DataGridViewTextBoxMONTO_APROBADO.Name = "DataGridViewTextBoxMONTO_APROBADO"
        '
        'DataGridViewTextBoxESTADO
        '
        Me.DataGridViewTextBoxESTADO.DataPropertyName = "ESTADO"
        Me.DataGridViewTextBoxESTADO.HeaderText = "Estado"
        Me.DataGridViewTextBoxESTADO.Name = "DataGridViewTextBoxESTADO"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'ucListaINFORME_FINAL_DET
        '
        Me.Controls.Add(Me.ListaINFORME_FINAL_DETDataGridView)
        Me.Name = "ucListaINFORME_FINAL_DET"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaINFORME_FINAL_DETDataGridView, 0)
        CType(Me.ListaINFORME_FINAL_DETBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaINFORME_FINAL_DETDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaINFORME_FINAL_DETBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaINFORME_FINAL_DETDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_INFORME_FINAL_DET As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_INFORME_FINAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_PARTICIPANTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_ACCION_FORMATIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTA_OBTENIDA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPORC_ASISTENCIA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxMONTO_SOLICITADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxMONTO_APROBADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
