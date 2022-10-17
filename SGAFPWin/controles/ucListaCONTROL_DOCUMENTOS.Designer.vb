<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaCONTROL_DOCUMENTOS
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
        Me.ListaCONTROL_DOCUMENTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaCONTROL_DOCUMENTOSDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxNUMERO_DOCUMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNUMERO_PATRONAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNUMERO_FOLIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_TIPO_SOLICITUD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_ETAPA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_PROCESO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxID_ESTADO_SOLICITUD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNIT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPRESENTADO_POR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_RECEPCION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxRESPONSABLE_ACTUAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxRESPONSABLE_ANTERIOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxPRIORIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNO_DOCUMENTO_ORIGEN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNO_DOCUMENTO_PADRE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_REQUERIDA_FIN = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOTAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaCONTROL_DOCUMENTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaCONTROL_DOCUMENTOSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaCONTROL_DOCUMENTOSBindingSource
        '
        Me.ListaCONTROL_DOCUMENTOSBindingSource.DataSource = GetType(SGAFP.EL.CONTROL_DOCUMENTOS)
        '
        'ListaCONTROL_DOCUMENTOSDataGridView
        '
        Me.ListaCONTROL_DOCUMENTOSDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaCONTROL_DOCUMENTOSDataGridView.AutoGenerateColumns = False
        Me.ListaCONTROL_DOCUMENTOSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxNUMERO_DOCUMENTO, Me.DataGridViewTextBoxNUMERO_PATRONAL, Me.DataGridViewTextBoxNUMERO_FOLIO, Me.DataGridViewTextBoxID_TIPO_SOLICITUD, Me.DataGridViewTextBoxCODIGO_ETAPA, Me.DataGridViewTextBoxCODIGO_PROCESO, Me.DataGridViewTextBoxID_ESTADO_SOLICITUD, Me.DataGridViewTextBoxNIT, Me.DataGridViewTextBoxPRESENTADO_POR, Me.DataGridViewTextBoxFECHA_RECEPCION, Me.DataGridViewTextBoxRESPONSABLE_ACTUAL, Me.DataGridViewTextBoxRESPONSABLE_ANTERIOR, Me.DataGridViewTextBoxPRIORIDAD, Me.DataGridViewTextBoxNO_DOCUMENTO_ORIGEN, Me.DataGridViewTextBoxNO_DOCUMENTO_PADRE, Me.DataGridViewTextBoxFECHA_REQUERIDA_FIN, Me.DataGridViewTextBoxNOTAS, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE})
        Me.ListaCONTROL_DOCUMENTOSDataGridView.DataSource = Me.ListaCONTROL_DOCUMENTOSBindingSource
        Me.ListaCONTROL_DOCUMENTOSDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaCONTROL_DOCUMENTOSDataGridView.Name = "ListaCONTROL_DOCUMENTOSDataGridView"
        Me.ListaCONTROL_DOCUMENTOSDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaCONTROL_DOCUMENTOSDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxNUMERO_DOCUMENTO
        '
        Me.DataGridViewTextBoxNUMERO_DOCUMENTO.DataPropertyName = "NUMERO_DOCUMENTO"
        Me.DataGridViewTextBoxNUMERO_DOCUMENTO.HeaderText = "Numero documento"
        Me.DataGridViewTextBoxNUMERO_DOCUMENTO.Name = "DataGridViewTextBoxNUMERO_DOCUMENTO"
        '
        'DataGridViewTextBoxNUMERO_PATRONAL
        '
        Me.DataGridViewTextBoxNUMERO_PATRONAL.DataPropertyName = "NUMERO_PATRONAL"
        Me.DataGridViewTextBoxNUMERO_PATRONAL.HeaderText = "Numero patronal"
        Me.DataGridViewTextBoxNUMERO_PATRONAL.Name = "DataGridViewTextBoxNUMERO_PATRONAL"
        '
        'DataGridViewTextBoxNUMERO_FOLIO
        '
        Me.DataGridViewTextBoxNUMERO_FOLIO.DataPropertyName = "NUMERO_FOLIO"
        Me.DataGridViewTextBoxNUMERO_FOLIO.HeaderText = "Numero folio"
        Me.DataGridViewTextBoxNUMERO_FOLIO.Name = "DataGridViewTextBoxNUMERO_FOLIO"
        '
        'DataGridViewTextBoxID_TIPO_SOLICITUD
        '
        Me.DataGridViewTextBoxID_TIPO_SOLICITUD.DataPropertyName = "ID_TIPO_SOLICITUD"
        Me.DataGridViewTextBoxID_TIPO_SOLICITUD.HeaderText = "Id tipo solicitud"
        Me.DataGridViewTextBoxID_TIPO_SOLICITUD.Name = "DataGridViewTextBoxID_TIPO_SOLICITUD"
        '
        'DataGridViewTextBoxCODIGO_ETAPA
        '
        Me.DataGridViewTextBoxCODIGO_ETAPA.DataPropertyName = "CODIGO_ETAPA"
        Me.DataGridViewTextBoxCODIGO_ETAPA.HeaderText = "Codigo etapa"
        Me.DataGridViewTextBoxCODIGO_ETAPA.Name = "DataGridViewTextBoxCODIGO_ETAPA"
        '
        'DataGridViewTextBoxCODIGO_PROCESO
        '
        Me.DataGridViewTextBoxCODIGO_PROCESO.DataPropertyName = "CODIGO_PROCESO"
        Me.DataGridViewTextBoxCODIGO_PROCESO.HeaderText = "Codigo proceso"
        Me.DataGridViewTextBoxCODIGO_PROCESO.Name = "DataGridViewTextBoxCODIGO_PROCESO"
        '
        'DataGridViewTextBoxID_ESTADO_SOLICITUD
        '
        Me.DataGridViewTextBoxID_ESTADO_SOLICITUD.DataPropertyName = "ID_ESTADO_SOLICITUD"
        Me.DataGridViewTextBoxID_ESTADO_SOLICITUD.HeaderText = "Id estado solicitud"
        Me.DataGridViewTextBoxID_ESTADO_SOLICITUD.Name = "DataGridViewTextBoxID_ESTADO_SOLICITUD"
        '
        'DataGridViewTextBoxNIT
        '
        Me.DataGridViewTextBoxNIT.DataPropertyName = "NIT"
        Me.DataGridViewTextBoxNIT.HeaderText = "Nit"
        Me.DataGridViewTextBoxNIT.Name = "DataGridViewTextBoxNIT"
        '
        'DataGridViewTextBoxPRESENTADO_POR
        '
        Me.DataGridViewTextBoxPRESENTADO_POR.DataPropertyName = "PRESENTADO_POR"
        Me.DataGridViewTextBoxPRESENTADO_POR.HeaderText = "Presentado por"
        Me.DataGridViewTextBoxPRESENTADO_POR.Name = "DataGridViewTextBoxPRESENTADO_POR"
        '
        'DataGridViewTextBoxFECHA_RECEPCION
        '
        Me.DataGridViewTextBoxFECHA_RECEPCION.DataPropertyName = "FECHA_RECEPCION"
        Me.DataGridViewTextBoxFECHA_RECEPCION.HeaderText = "Fecha recepcion"
        Me.DataGridViewTextBoxFECHA_RECEPCION.Name = "DataGridViewTextBoxFECHA_RECEPCION"
        '
        'DataGridViewTextBoxRESPONSABLE_ACTUAL
        '
        Me.DataGridViewTextBoxRESPONSABLE_ACTUAL.DataPropertyName = "RESPONSABLE_ACTUAL"
        Me.DataGridViewTextBoxRESPONSABLE_ACTUAL.HeaderText = "Responsable actual"
        Me.DataGridViewTextBoxRESPONSABLE_ACTUAL.Name = "DataGridViewTextBoxRESPONSABLE_ACTUAL"
        '
        'DataGridViewTextBoxRESPONSABLE_ANTERIOR
        '
        Me.DataGridViewTextBoxRESPONSABLE_ANTERIOR.DataPropertyName = "RESPONSABLE_ANTERIOR"
        Me.DataGridViewTextBoxRESPONSABLE_ANTERIOR.HeaderText = "Responsable anterior"
        Me.DataGridViewTextBoxRESPONSABLE_ANTERIOR.Name = "DataGridViewTextBoxRESPONSABLE_ANTERIOR"
        '
        'DataGridViewTextBoxPRIORIDAD
        '
        Me.DataGridViewTextBoxPRIORIDAD.DataPropertyName = "PRIORIDAD"
        Me.DataGridViewTextBoxPRIORIDAD.HeaderText = "Prioridad"
        Me.DataGridViewTextBoxPRIORIDAD.Name = "DataGridViewTextBoxPRIORIDAD"
        '
        'DataGridViewTextBoxNO_DOCUMENTO_ORIGEN
        '
        Me.DataGridViewTextBoxNO_DOCUMENTO_ORIGEN.DataPropertyName = "NO_DOCUMENTO_ORIGEN"
        Me.DataGridViewTextBoxNO_DOCUMENTO_ORIGEN.HeaderText = "No documento origen"
        Me.DataGridViewTextBoxNO_DOCUMENTO_ORIGEN.Name = "DataGridViewTextBoxNO_DOCUMENTO_ORIGEN"
        '
        'DataGridViewTextBoxNO_DOCUMENTO_PADRE
        '
        Me.DataGridViewTextBoxNO_DOCUMENTO_PADRE.DataPropertyName = "NO_DOCUMENTO_PADRE"
        Me.DataGridViewTextBoxNO_DOCUMENTO_PADRE.HeaderText = "No documento padre"
        Me.DataGridViewTextBoxNO_DOCUMENTO_PADRE.Name = "DataGridViewTextBoxNO_DOCUMENTO_PADRE"
        '
        'DataGridViewTextBoxFECHA_REQUERIDA_FIN
        '
        Me.DataGridViewTextBoxFECHA_REQUERIDA_FIN.DataPropertyName = "FECHA_REQUERIDA_FIN"
        Me.DataGridViewTextBoxFECHA_REQUERIDA_FIN.HeaderText = "Fecha requerida fin"
        Me.DataGridViewTextBoxFECHA_REQUERIDA_FIN.Name = "DataGridViewTextBoxFECHA_REQUERIDA_FIN"
        '
        'DataGridViewTextBoxNOTAS
        '
        Me.DataGridViewTextBoxNOTAS.DataPropertyName = "NOTAS"
        Me.DataGridViewTextBoxNOTAS.HeaderText = "Notas"
        Me.DataGridViewTextBoxNOTAS.Name = "DataGridViewTextBoxNOTAS"
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
        'ucListaCONTROL_DOCUMENTOS
        '
        Me.Controls.Add(Me.ListaCONTROL_DOCUMENTOSDataGridView)
        Me.Name = "ucListaCONTROL_DOCUMENTOS"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaCONTROL_DOCUMENTOSDataGridView, 0)
        CType(Me.ListaCONTROL_DOCUMENTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaCONTROL_DOCUMENTOSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaCONTROL_DOCUMENTOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaCONTROL_DOCUMENTOSDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxNUMERO_DOCUMENTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNUMERO_PATRONAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNUMERO_FOLIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_TIPO_SOLICITUD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_ETAPA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_PROCESO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxID_ESTADO_SOLICITUD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNIT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPRESENTADO_POR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_RECEPCION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxRESPONSABLE_ACTUAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxRESPONSABLE_ANTERIOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxPRIORIDAD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNO_DOCUMENTO_ORIGEN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNO_DOCUMENTO_PADRE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_REQUERIDA_FIN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOTAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
