<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaOFERTA_FORMATIVA
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
        Me.ListaOFERTA_FORMATIVADataGridView = New System.Windows.Forms.DataGridView
        Me.ListaOFERTA_FORMATIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxID_OFERTA_FORMATIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_EJERCICIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_TEMA_CURSO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_PROVEEDOR_AF = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOMBRE_PROVEEDOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TEMA_CURSO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDURACION_HORAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCOSTO_X_PARTICIPANTE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_INICIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_FIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_APROBACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSUARIO_APROBACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaOFERTA_FORMATIVADataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaOFERTA_FORMATIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaOFERTA_FORMATIVADataGridView
        '
        Me.ListaOFERTA_FORMATIVADataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaOFERTA_FORMATIVADataGridView.AutoGenerateColumns = False
        Me.ListaOFERTA_FORMATIVADataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxID_OFERTA_FORMATIVA, Me.DataGridViewTextBoxID_EJERCICIO, Me.DataGridViewTextBoxID_TEMA_CURSO, Me.DataGridViewTextBoxID_PROVEEDOR_AF, Me.NOMBRE_PROVEEDOR, Me.TEMA_CURSO, Me.DataGridViewTextBoxDURACION_HORAS, Me.DataGridViewTextBoxCOSTO_X_PARTICIPANTE, Me.DataGridViewTextBoxFECHA_INICIO, Me.DataGridViewTextBoxFECHA_FIN, Me.DataGridViewTextBoxNOTAS, Me.DataGridViewTextBoxESTADO, Me.DataGridViewTextBoxFECHA_APROBACION, Me.DataGridViewTextBoxUSUARIO_APROBACION, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE})
        Me.ListaOFERTA_FORMATIVADataGridView.DataSource = Me.ListaOFERTA_FORMATIVABindingSource
        Me.ListaOFERTA_FORMATIVADataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaOFERTA_FORMATIVADataGridView.Name = "ListaOFERTA_FORMATIVADataGridView"
        Me.ListaOFERTA_FORMATIVADataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaOFERTA_FORMATIVADataGridView.TabIndex = 1
        '
        'ListaOFERTA_FORMATIVABindingSource
        '
        Me.ListaOFERTA_FORMATIVABindingSource.DataSource = GetType(SGAFP.EL.OFERTA_FORMATIVA)
        '
        'DataGridViewTextBoxID_OFERTA_FORMATIVA
        '
        Me.DataGridViewTextBoxID_OFERTA_FORMATIVA.DataPropertyName = "ID_OFERTA_FORMATIVA"
        Me.DataGridViewTextBoxID_OFERTA_FORMATIVA.HeaderText = "Id oferta formativa"
        Me.DataGridViewTextBoxID_OFERTA_FORMATIVA.Name = "DataGridViewTextBoxID_OFERTA_FORMATIVA"
        '
        'DataGridViewTextBoxID_EJERCICIO
        '
        Me.DataGridViewTextBoxID_EJERCICIO.DataPropertyName = "ID_EJERCICIO"
        Me.DataGridViewTextBoxID_EJERCICIO.HeaderText = "Id ejercicio"
        Me.DataGridViewTextBoxID_EJERCICIO.Name = "DataGridViewTextBoxID_EJERCICIO"
        '
        'DataGridViewTextBoxID_TEMA_CURSO
        '
        Me.DataGridViewTextBoxID_TEMA_CURSO.DataPropertyName = "ID_TEMA_CURSO"
        Me.DataGridViewTextBoxID_TEMA_CURSO.HeaderText = "Id tema curso"
        Me.DataGridViewTextBoxID_TEMA_CURSO.Name = "DataGridViewTextBoxID_TEMA_CURSO"
        '
        'DataGridViewTextBoxID_PROVEEDOR_AF
        '
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.DataPropertyName = "ID_PROVEEDOR_AF"
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.HeaderText = "Id proveedor af"
        Me.DataGridViewTextBoxID_PROVEEDOR_AF.Name = "DataGridViewTextBoxID_PROVEEDOR_AF"
        '
        'NOMBRE_PROVEEDOR
        '
        Me.NOMBRE_PROVEEDOR.DataPropertyName = "NOMBRE_PROVEEDOR"
        Me.NOMBRE_PROVEEDOR.HeaderText = "Nombre Proveedor"
        Me.NOMBRE_PROVEEDOR.Name = "NOMBRE_PROVEEDOR"
        Me.NOMBRE_PROVEEDOR.ReadOnly = True
        '
        'TEMA_CURSO
        '
        Me.TEMA_CURSO.DataPropertyName = "TEMA_CURSO"
        Me.TEMA_CURSO.HeaderText = "Nombre Oferta Formativa"
        Me.TEMA_CURSO.Name = "TEMA_CURSO"
        Me.TEMA_CURSO.ReadOnly = True
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
        'DataGridViewTextBoxFECHA_INICIO
        '
        Me.DataGridViewTextBoxFECHA_INICIO.DataPropertyName = "FECHA_INICIO"
        Me.DataGridViewTextBoxFECHA_INICIO.HeaderText = "Fecha inicio"
        Me.DataGridViewTextBoxFECHA_INICIO.Name = "DataGridViewTextBoxFECHA_INICIO"
        '
        'DataGridViewTextBoxFECHA_FIN
        '
        Me.DataGridViewTextBoxFECHA_FIN.DataPropertyName = "FECHA_FIN"
        Me.DataGridViewTextBoxFECHA_FIN.HeaderText = "Fecha fin"
        Me.DataGridViewTextBoxFECHA_FIN.Name = "DataGridViewTextBoxFECHA_FIN"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
        '
        'DataGridViewTextBoxESTADO
        '
        Me.DataGridViewTextBoxESTADO.DataPropertyName = "ESTADO"
        Me.DataGridViewTextBoxESTADO.HeaderText = "Estado"
        Me.DataGridViewTextBoxESTADO.Name = "DataGridViewTextBoxESTADO"
        '
        'DataGridViewTextBoxFECHA_APROBACION
        '
        Me.DataGridViewTextBoxFECHA_APROBACION.DataPropertyName = "FECHA_APROBACION"
        Me.DataGridViewTextBoxFECHA_APROBACION.HeaderText = "Fecha aprobacion"
        Me.DataGridViewTextBoxFECHA_APROBACION.Name = "DataGridViewTextBoxFECHA_APROBACION"
        '
        'DataGridViewTextBoxUSUARIO_APROBACION
        '
        Me.DataGridViewTextBoxUSUARIO_APROBACION.DataPropertyName = "USUARIO_APROBACION"
        Me.DataGridViewTextBoxUSUARIO_APROBACION.HeaderText = "Usuario aprobacion"
        Me.DataGridViewTextBoxUSUARIO_APROBACION.Name = "DataGridViewTextBoxUSUARIO_APROBACION"
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
        'ucListaOFERTA_FORMATIVA
        '
        Me.Controls.Add(Me.ListaOFERTA_FORMATIVADataGridView)
        Me.Name = "ucListaOFERTA_FORMATIVA"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaOFERTA_FORMATIVADataGridView, 0)
        CType(Me.ListaOFERTA_FORMATIVADataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaOFERTA_FORMATIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaOFERTA_FORMATIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaOFERTA_FORMATIVADataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxID_OFERTA_FORMATIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_EJERCICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_TEMA_CURSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_PROVEEDOR_AF As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_PROVEEDOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TEMA_CURSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDURACION_HORAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCOSTO_X_PARTICIPANTE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_INICIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_FIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxESTADO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_APROBACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSUARIO_APROBACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
