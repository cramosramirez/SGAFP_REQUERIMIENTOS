<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaACCION_FORMATIVA
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
        Me.ListaACCION_FORMATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaACCION_FORMATIVADataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_OFERTA_FORMATIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_SITIO_CAPACITACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_PROVEEDOR_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_TEMA_CURSO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_EJERCICIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOMBRE_ACCION_FORMATIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_GRUPO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNUMERO_PARTICIPANTES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_INICIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_FIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxHORARIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_ESTADO_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDURACION_HORAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCOSTO_X_PARTICIPANTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaACCION_FORMATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaACCION_FORMATIVADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaACCION_FORMATIVABindingSource
        '
        Me.ListaACCION_FORMATIVABindingSource.DataSource = GetType(SGAFP.EL.ACCION_FORMATIVA)
        '
        'ListaACCION_FORMATIVADataGridView
        '
        Me.ListaACCION_FORMATIVADataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaACCION_FORMATIVADataGridView.AutoGenerateColumns = False
        Me.ListaACCION_FORMATIVADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_ACCION_FORMATIVA, Me.DataGridViewTextBoxID_OFERTA_FORMATIVA, Me.DataGridViewTextBoxID_SITIO_CAPACITACION, Me.DataGridViewTextBoxID_PROVEEDOR_AF, Me.DataGridViewTextBoxID_TEMA_CURSO, Me.DataGridViewTextBoxID_EJERCICIO, Me.DataGridViewTextBoxNOMBRE_ACCION_FORMATIVA, Me.DataGridViewTextBoxCODIGO_GRUPO, Me.DataGridViewTextBoxNUMERO_PARTICIPANTES, Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS, Me.DataGridViewTextBoxFECHA_INICIO, Me.DataGridViewTextBoxFECHA_FIN, Me.DataGridViewTextBoxHORARIO, Me.DataGridViewTextBoxNOTAS, Me.DataGridViewTextBoxCODIGO_ESTADO_AF, Me.DataGridViewTextBoxDURACION_HORAS, Me.DataGridViewTextBoxCOSTO_X_PARTICIPANTE, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE})
        Me.ListaACCION_FORMATIVADataGridView.DataSource = Me.ListaACCION_FORMATIVABindingSource
        Me.ListaACCION_FORMATIVADataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaACCION_FORMATIVADataGridView.Name = "ListaACCION_FORMATIVADataGridView"
        Me.ListaACCION_FORMATIVADataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaACCION_FORMATIVADataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxID_ACCION_FORMATIVA
        '
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.DataPropertyName = "ID_ACCION_FORMATIVA"
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.HeaderText = "Id accion formativa"
        Me.DataGridViewTextBoxID_ACCION_FORMATIVA.Name = "DataGridViewTextBoxID_ACCION_FORMATIVA"
        '
        'DataGridViewTextBoxID_OFERTA_FORMATIVA
        '
        Me.DataGridViewTextBoxID_OFERTA_FORMATIVA.DataPropertyName = "ID_OFERTA_FORMATIVA"
        Me.DataGridViewTextBoxID_OFERTA_FORMATIVA.HeaderText = "Id oferta formativa"
        Me.DataGridViewTextBoxID_OFERTA_FORMATIVA.Name = "DataGridViewTextBoxID_OFERTA_FORMATIVA"
        '
        'DataGridViewTextBoxID_SITIO_CAPACITACION
        '
        Me.DataGridViewTextBoxID_SITIO_CAPACITACION.DataPropertyName = "ID_SITIO_CAPACITACION"
        Me.DataGridViewTextBoxID_SITIO_CAPACITACION.HeaderText = "Id sitio capacitacion"
        Me.DataGridViewTextBoxID_SITIO_CAPACITACION.Name = "DataGridViewTextBoxID_SITIO_CAPACITACION"
        '
        'DataGridViewTextBoxID_PROVEEDOR_AF
        '
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.DataPropertyName = "ID_PROVEEDOR_AF"
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.HeaderText = "Id proveedor af"
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.Name = "DataGridViewTextBoxID_PROVEEDOR_AF"
        '
        'DataGridViewTextBoxID_TEMA_CURSO
        '
        Me.DataGridViewTextBoxID_TEMA_CURSO.DataPropertyName = "ID_TEMA_CURSO"
        Me.DataGridViewTextBoxID_TEMA_CURSO.HeaderText = "Id tema curso"
        Me.DataGridViewTextBoxID_TEMA_CURSO.Name = "DataGridViewTextBoxID_TEMA_CURSO"
        '
        'DataGridViewTextBoxID_EJERCICIO
        '
        Me.DataGridViewTextBoxID_EJERCICIO.DataPropertyName = "ID_EJERCICIO"
        Me.DataGridViewTextBoxID_EJERCICIO.HeaderText = "Id ejercicio"
        Me.DataGridViewTextBoxID_EJERCICIO.Name = "DataGridViewTextBoxID_EJERCICIO"
        '
        'DataGridViewTextBoxNOMBRE_ACCION_FORMATIVA
        '
        Me.DataGridViewTextBoxNOMBRE_ACCION_FORMATIVA.DataPropertyName = "NOMBRE_ACCION_FORMATIVA"
        Me.DataGridViewTextBoxNOMBRE_ACCION_FORMATIVA.HeaderText = "Nombre accion formativa"
        Me.DataGridViewTextBoxNOMBRE_ACCION_FORMATIVA.Name = "DataGridViewTextBoxNOMBRE_ACCION_FORMATIVA"
        '
        'DataGridViewTextBoxCODIGO_GRUPO
        '
        Me.DataGridViewTextBoxCODIGO_GRUPO.DataPropertyName = "CODIGO_GRUPO"
        Me.DataGridViewTextBoxCODIGO_GRUPO.HeaderText = "Codigo grupo"
        Me.DataGridViewTextBoxCODIGO_GRUPO.Name = "DataGridViewTextBoxCODIGO_GRUPO"
        '
        'DataGridViewTextBoxNUMERO_PARTICIPANTES
        '
        Me.DataGridViewTextBoxNUMERO_PARTICIPANTES.DataPropertyName = "NUMERO_PARTICIPANTES"
        Me.DataGridViewTextBoxNUMERO_PARTICIPANTES.HeaderText = "Cupo"
        Me.DataGridViewTextBoxNUMERO_PARTICIPANTES.Name = "DataGridViewTextBoxNUMERO_PARTICIPANTES"
        '
        'DataGridViewTextBoxPARTICIPANTES_INSCRITOS
        '
        Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS.DataPropertyName = "PARTICIPANTES_INSCRITOS"
        Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS.HeaderText = "Participantes inscritos"
        Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS.Name = "DataGridViewTextBoxPARTICIPANTES_INSCRITOS"
        Me.DataGridViewTextBoxPARTICIPANTES_INSCRITOS.Width = 150
        '
        'DataGridViewTextBoxFECHA_INICIO
        '
        Me.DataGridViewTextBoxFECHA_INICIO.DataPropertyName = "FECHA_INICIO_REAL"
        Me.DataGridViewTextBoxFECHA_INICIO.HeaderText = "Fecha inicio"
        Me.DataGridViewTextBoxFECHA_INICIO.Name = "DataGridViewTextBoxFECHA_INICIO"
        '
        'DataGridViewTextBoxFECHA_FIN
        '
        Me.DataGridViewTextBoxFECHA_FIN.DataPropertyName = "FECHA_FIN_REAL"
        Me.DataGridViewTextBoxFECHA_FIN.HeaderText = "Fecha fin"
        Me.DataGridViewTextBoxFECHA_FIN.Name = "DataGridViewTextBoxFECHA_FIN"
        '
        'DataGridViewTextBoxHORARIO
        '
        Me.DataGridViewTextBoxHORARIO.DataPropertyName = "HORARIO"
        Me.DataGridViewTextBoxHORARIO.HeaderText = "Horario"
        Me.DataGridViewTextBoxHORARIO.Name = "DataGridViewTextBoxHORARIO"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'DataGridViewTextBoxCODIGO_ESTADO_AF
        '
        Me.DataGridViewTextBoxCODIGO_ESTADO_AF.DataPropertyName = "CODIGO_ESTADO_AF"
        Me.DataGridViewTextBoxCODIGO_ESTADO_AF.HeaderText = "Codigo estado af"
        Me.DataGridViewTextBoxCODIGO_ESTADO_AF.Name = "DataGridViewTextBoxCODIGO_ESTADO_AF"
        '
        'DataGridViewTextBoxDURACION_HORAS
        '
        Me.DataGridViewTextBoxDURACION_HORAS.DataPropertyName = "DURACION_HORAS"
        Me.DataGridViewTextBoxDURACION_HORAS.HeaderText = "Duracion horas"
        Me.DataGridViewTextBoxDURACION_HORAS.Name = "DataGridViewTextBoxDURACION_HORAS"
        '
        'DataGridViewTextBoxCOSTO_X_PARTICIPANTE
        '
        Me.DataGridViewTextBoxCOSTO_X_PARTICIPANTE.DataPropertyName = "COSTO_X_PARTICIPANTE"
        Me.DataGridViewTextBoxCOSTO_X_PARTICIPANTE.HeaderText = "Costo x participante"
        Me.DataGridViewTextBoxCOSTO_X_PARTICIPANTE.Name = "DataGridViewTextBoxCOSTO_X_PARTICIPANTE"
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
        'ucListaACCION_FORMATIVA
        '
        Me.Controls.Add(Me.ListaACCION_FORMATIVADataGridView)
        Me.Name = "ucListaACCION_FORMATIVA"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaACCION_FORMATIVADataGridView, 0)
        CType(Me.ListaACCION_FORMATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaACCION_FORMATIVADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaACCION_FORMATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaACCION_FORMATIVADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_ACCION_FORMATIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_OFERTA_FORMATIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_SITIO_CAPACITACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_PROVEEDOR_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_TEMA_CURSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_EJERCICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOMBRE_ACCION_FORMATIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_GRUPO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNUMERO_PARTICIPANTES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPARTICIPANTES_INSCRITOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_INICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_FIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxHORARIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_ESTADO_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDURACION_HORAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCOSTO_X_PARTICIPANTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
