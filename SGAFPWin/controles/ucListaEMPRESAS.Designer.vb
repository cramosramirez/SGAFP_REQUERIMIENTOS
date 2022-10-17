<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucListaEMPRESAS
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
        Me.ListaEMPRESASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaEMPRESASDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxNUMERO_PATRONAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNIT_EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCIUU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxSECTOR_PRODUCTIVO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_ASESOR = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_MUNICIPIO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCODIGO_REGION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNOMBRE_EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTIPO_EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCONTACTO_EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTELEFONO_CONTACTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCARGO_CONTACTO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxDIRECCION_EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTELEFONO_EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFAX_EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxEMAIL_EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxESPECIALIDAD_EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTOTAL_PERSONA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTOTAL_PLANILLA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxREPRESENTANTE_LEGAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFECHA_REGISTRO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTOTAL_TRABAJADORES = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxFEMENINOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxMASCULINOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTAMANO_EMPRESA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCON_MANDO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxSIN_MANDO = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxADMINISTRATIVOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxMANDOS_MEDIOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxOPERATIVOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxGERENCIAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxSIGLAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxUSERID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxLASTUPDATE = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxOBSERVACION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNUM_PAT_ISSS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxTIPOPERSON = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxNUM = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxREPRESENTANTE_PROFESION = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxCONTACTO_EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxAPORTE_INSAFORP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxZONA = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.ListaEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaEMPRESASDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListaEMPRESASBindingSource
        '
        Me.ListaEMPRESASBindingSource.DataSource = GetType(SGAFP.EL.EMPRESAS)
        '
        'ListaEMPRESASDataGridView
        '
        Me.ListaEMPRESASDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListaEMPRESASDataGridView.AutoGenerateColumns = False
        Me.ListaEMPRESASDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxNUMERO_PATRONAL, Me.DataGridViewTextBoxNIT_EMPRESA, Me.DataGridViewTextBoxCIUU, Me.DataGridViewTextBoxSECTOR_PRODUCTIVO, Me.DataGridViewTextBoxCODIGO_ASESOR, Me.DataGridViewTextBoxCODIGO_MUNICIPIO, Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO, Me.DataGridViewTextBoxCODIGO_REGION, Me.DataGridViewTextBoxNOMBRE_EMPRESA, Me.DataGridViewTextBoxTIPO_EMPRESA, Me.DataGridViewTextBoxCONTACTO_EMPRESA, Me.DataGridViewTextBoxTELEFONO_CONTACTO, Me.DataGridViewTextBoxCARGO_CONTACTO, Me.DataGridViewTextBoxDIRECCION_EMPRESA, Me.DataGridViewTextBoxTELEFONO_EMPRESA, Me.DataGridViewTextBoxFAX_EMPRESA, Me.DataGridViewTextBoxEMAIL_EMPRESA, Me.DataGridViewTextBoxESPECIALIDAD_EMPRESA, Me.DataGridViewTextBoxTOTAL_PERSONA, Me.DataGridViewTextBoxTOTAL_PLANILLA, Me.DataGridViewTextBoxREPRESENTANTE_LEGAL, Me.DataGridViewTextBoxFECHA_REGISTRO, Me.DataGridViewTextBoxTOTAL_TRABAJADORES, Me.DataGridViewTextBoxFEMENINOS, Me.DataGridViewTextBoxMASCULINOS, Me.DataGridViewTextBoxTAMANO_EMPRESA, Me.DataGridViewTextBoxCON_MANDO, Me.DataGridViewTextBoxSIN_MANDO, Me.DataGridViewTextBoxADMINISTRATIVOS, Me.DataGridViewTextBoxMANDOS_MEDIOS, Me.DataGridViewTextBoxOPERATIVOS, Me.DataGridViewTextBoxGERENCIAL, Me.DataGridViewTextBoxSIGLAS, Me.DataGridViewTextBoxUSERID, Me.DataGridViewTextBoxLASTUPDATE, Me.DataGridViewTextBoxOBSERVACION, Me.DataGridViewTextBoxNUM_PAT_ISSS, Me.DataGridViewTextBoxTIPOPERSON, Me.DataGridViewTextBoxNUM, Me.DataGridViewTextBoxREPRESENTANTE_PROFESION, Me.DataGridViewTextBoxCONTACTO_EMAIL, Me.DataGridViewTextBoxAPORTE_INSAFORP, Me.DataGridViewTextBoxZONA})
        Me.ListaEMPRESASDataGridView.DataSource = Me.ListaEMPRESASBindingSource
        Me.ListaEMPRESASDataGridView.Location = New System.Drawing.Point(3, 28)
        Me.ListaEMPRESASDataGridView.Name = "ListaEMPRESASDataGridView"
        Me.ListaEMPRESASDataGridView.Size = New System.Drawing.Size(523, 323)
        Me.ListaEMPRESASDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxNUMERO_PATRONAL
        '
        Me.DataGridViewTextBoxNUMERO_PATRONAL.DataPropertyName = "NUMERO_PATRONAL"
        Me.DataGridViewTextBoxNUMERO_PATRONAL.HeaderText = "Numero patronal"
        Me.DataGridViewTextBoxNUMERO_PATRONAL.Name = "DataGridViewTextBoxNUMERO_PATRONAL"
        '
        'DataGridViewTextBoxNIT_EMPRESA
        '
        Me.DataGridViewTextBoxNIT_EMPRESA.DataPropertyName = "NIT_EMPRESA"
        Me.DataGridViewTextBoxNIT_EMPRESA.HeaderText = "Nit empresa"
        Me.DataGridViewTextBoxNIT_EMPRESA.Name = "DataGridViewTextBoxNIT_EMPRESA"
        '
        'DataGridViewTextBoxCIUU
        '
        Me.DataGridViewTextBoxCIUU.DataPropertyName = "CIUU"
        Me.DataGridViewTextBoxCIUU.HeaderText = "Ciuu"
        Me.DataGridViewTextBoxCIUU.Name = "DataGridViewTextBoxCIUU"
        '
        'DataGridViewTextBoxSECTOR_PRODUCTIVO
        '
        Me.DataGridViewTextBoxSECTOR_PRODUCTIVO.DataPropertyName = "SECTOR_PRODUCTIVO"
        Me.DataGridViewTextBoxSECTOR_PRODUCTIVO.HeaderText = "Sector productivo"
        Me.DataGridViewTextBoxSECTOR_PRODUCTIVO.Name = "DataGridViewTextBoxSECTOR_PRODUCTIVO"
        '
        'DataGridViewTextBoxCODIGO_ASESOR
        '
        Me.DataGridViewTextBoxCODIGO_ASESOR.DataPropertyName = "CODIGO_ASESOR"
        Me.DataGridViewTextBoxCODIGO_ASESOR.HeaderText = "Codigo asesor"
        Me.DataGridViewTextBoxCODIGO_ASESOR.Name = "DataGridViewTextBoxCODIGO_ASESOR"
        '
        'DataGridViewTextBoxCODIGO_MUNICIPIO
        '
        Me.DataGridViewTextBoxCODIGO_MUNICIPIO.DataPropertyName = "CODIGO_MUNICIPIO"
        Me.DataGridViewTextBoxCODIGO_MUNICIPIO.HeaderText = "Codigo municipio"
        Me.DataGridViewTextBoxCODIGO_MUNICIPIO.Name = "DataGridViewTextBoxCODIGO_MUNICIPIO"
        '
        'DataGridViewTextBoxCODIGO_DEPARTAMENTO
        '
        Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO.DataPropertyName = "CODIGO_DEPARTAMENTO"
        Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO.HeaderText = "Codigo departamento"
        Me.DataGridViewTextBoxCODIGO_DEPARTAMENTO.Name = "DataGridViewTextBoxCODIGO_DEPARTAMENTO"
        '
        'DataGridViewTextBoxCODIGO_REGION
        '
        Me.DataGridViewTextBoxCODIGO_REGION.DataPropertyName = "CODIGO_REGION"
        Me.DataGridViewTextBoxCODIGO_REGION.HeaderText = "Codigo region"
        Me.DataGridViewTextBoxCODIGO_REGION.Name = "DataGridViewTextBoxCODIGO_REGION"
        '
        'DataGridViewTextBoxNOMBRE_EMPRESA
        '
        Me.DataGridViewTextBoxNOMBRE_EMPRESA.DataPropertyName = "NOMBRE_EMPRESA"
        Me.DataGridViewTextBoxNOMBRE_EMPRESA.HeaderText = "Nombre empresa"
        Me.DataGridViewTextBoxNOMBRE_EMPRESA.Name = "DataGridViewTextBoxNOMBRE_EMPRESA"
        '
        'DataGridViewTextBoxTIPO_EMPRESA
        '
        Me.DataGridViewTextBoxTIPO_EMPRESA.DataPropertyName = "TIPO_EMPRESA"
        Me.DataGridViewTextBoxTIPO_EMPRESA.HeaderText = "Tipo empresa"
        Me.DataGridViewTextBoxTIPO_EMPRESA.Name = "DataGridViewTextBoxTIPO_EMPRESA"
        '
        'DataGridViewTextBoxCONTACTO_EMPRESA
        '
        Me.DataGridViewTextBoxCONTACTO_EMPRESA.DataPropertyName = "CONTACTO_EMPRESA"
        Me.DataGridViewTextBoxCONTACTO_EMPRESA.HeaderText = "Contacto empresa"
        Me.DataGridViewTextBoxCONTACTO_EMPRESA.Name = "DataGridViewTextBoxCONTACTO_EMPRESA"
        '
        'DataGridViewTextBoxTELEFONO_CONTACTO
        '
        Me.DataGridViewTextBoxTELEFONO_CONTACTO.DataPropertyName = "TELEFONO_CONTACTO"
        Me.DataGridViewTextBoxTELEFONO_CONTACTO.HeaderText = "Telefono contacto"
        Me.DataGridViewTextBoxTELEFONO_CONTACTO.Name = "DataGridViewTextBoxTELEFONO_CONTACTO"
        '
        'DataGridViewTextBoxCARGO_CONTACTO
        '
        Me.DataGridViewTextBoxCARGO_CONTACTO.DataPropertyName = "CARGO_CONTACTO"
        Me.DataGridViewTextBoxCARGO_CONTACTO.HeaderText = "Cargo contacto"
        Me.DataGridViewTextBoxCARGO_CONTACTO.Name = "DataGridViewTextBoxCARGO_CONTACTO"
        '
        'DataGridViewTextBoxDIRECCION_EMPRESA
        '
        Me.DataGridViewTextBoxDIRECCION_EMPRESA.DataPropertyName = "DIRECCION_EMPRESA"
        Me.DataGridViewTextBoxDIRECCION_EMPRESA.HeaderText = "Direccion empresa"
        Me.DataGridViewTextBoxDIRECCION_EMPRESA.Name = "DataGridViewTextBoxDIRECCION_EMPRESA"
        '
        'DataGridViewTextBoxTELEFONO_EMPRESA
        '
        Me.DataGridViewTextBoxTELEFONO_EMPRESA.DataPropertyName = "TELEFONO_EMPRESA"
        Me.DataGridViewTextBoxTELEFONO_EMPRESA.HeaderText = "Telefono empresa"
        Me.DataGridViewTextBoxTELEFONO_EMPRESA.Name = "DataGridViewTextBoxTELEFONO_EMPRESA"
        '
        'DataGridViewTextBoxFAX_EMPRESA
        '
        Me.DataGridViewTextBoxFAX_EMPRESA.DataPropertyName = "FAX_EMPRESA"
        Me.DataGridViewTextBoxFAX_EMPRESA.HeaderText = "Fax empresa"
        Me.DataGridViewTextBoxFAX_EMPRESA.Name = "DataGridViewTextBoxFAX_EMPRESA"
        '
        'DataGridViewTextBoxEMAIL_EMPRESA
        '
        Me.DataGridViewTextBoxEMAIL_EMPRESA.DataPropertyName = "EMAIL_EMPRESA"
        Me.DataGridViewTextBoxEMAIL_EMPRESA.HeaderText = "Email empresa"
        Me.DataGridViewTextBoxEMAIL_EMPRESA.Name = "DataGridViewTextBoxEMAIL_EMPRESA"
        '
        'DataGridViewTextBoxESPECIALIDAD_EMPRESA
        '
        Me.DataGridViewTextBoxESPECIALIDAD_EMPRESA.DataPropertyName = "ESPECIALIDAD_EMPRESA"
        Me.DataGridViewTextBoxESPECIALIDAD_EMPRESA.HeaderText = "Especialidad empresa"
        Me.DataGridViewTextBoxESPECIALIDAD_EMPRESA.Name = "DataGridViewTextBoxESPECIALIDAD_EMPRESA"
        '
        'DataGridViewTextBoxTOTAL_PERSONA
        '
        Me.DataGridViewTextBoxTOTAL_PERSONA.DataPropertyName = "TOTAL_PERSONA"
        Me.DataGridViewTextBoxTOTAL_PERSONA.HeaderText = "Total persona"
        Me.DataGridViewTextBoxTOTAL_PERSONA.Name = "DataGridViewTextBoxTOTAL_PERSONA"
        '
        'DataGridViewTextBoxTOTAL_PLANILLA
        '
        Me.DataGridViewTextBoxTOTAL_PLANILLA.DataPropertyName = "TOTAL_PLANILLA"
        Me.DataGridViewTextBoxTOTAL_PLANILLA.HeaderText = "Total planilla"
        Me.DataGridViewTextBoxTOTAL_PLANILLA.Name = "DataGridViewTextBoxTOTAL_PLANILLA"
        '
        'DataGridViewTextBoxREPRESENTANTE_LEGAL
        '
        Me.DataGridViewTextBoxREPRESENTANTE_LEGAL.DataPropertyName = "REPRESENTANTE_LEGAL"
        Me.DataGridViewTextBoxREPRESENTANTE_LEGAL.HeaderText = "Representante legal"
        Me.DataGridViewTextBoxREPRESENTANTE_LEGAL.Name = "DataGridViewTextBoxREPRESENTANTE_LEGAL"
        '
        'DataGridViewTextBoxFECHA_REGISTRO
        '
        Me.DataGridViewTextBoxFECHA_REGISTRO.DataPropertyName = "FECHA_REGISTRO"
        Me.DataGridViewTextBoxFECHA_REGISTRO.HeaderText = "Fecha registro"
        Me.DataGridViewTextBoxFECHA_REGISTRO.Name = "DataGridViewTextBoxFECHA_REGISTRO"
        '
        'DataGridViewTextBoxTOTAL_TRABAJADORES
        '
        Me.DataGridViewTextBoxTOTAL_TRABAJADORES.DataPropertyName = "TOTAL_TRABAJADORES"
        Me.DataGridViewTextBoxTOTAL_TRABAJADORES.HeaderText = "Total trabajadores"
        Me.DataGridViewTextBoxTOTAL_TRABAJADORES.Name = "DataGridViewTextBoxTOTAL_TRABAJADORES"
        '
        'DataGridViewTextBoxFEMENINOS
        '
        Me.DataGridViewTextBoxFEMENINOS.DataPropertyName = "FEMENINOS"
        Me.DataGridViewTextBoxFEMENINOS.HeaderText = "Femeninos"
        Me.DataGridViewTextBoxFEMENINOS.Name = "DataGridViewTextBoxFEMENINOS"
        '
        'DataGridViewTextBoxMASCULINOS
        '
        Me.DataGridViewTextBoxMASCULINOS.DataPropertyName = "MASCULINOS"
        Me.DataGridViewTextBoxMASCULINOS.HeaderText = "Masculinos"
        Me.DataGridViewTextBoxMASCULINOS.Name = "DataGridViewTextBoxMASCULINOS"
        '
        'DataGridViewTextBoxTAMANO_EMPRESA
        '
        Me.DataGridViewTextBoxTAMANO_EMPRESA.DataPropertyName = "TAMANO_EMPRESA"
        Me.DataGridViewTextBoxTAMANO_EMPRESA.HeaderText = "Tamano empresa"
        Me.DataGridViewTextBoxTAMANO_EMPRESA.Name = "DataGridViewTextBoxTAMANO_EMPRESA"
        '
        'DataGridViewTextBoxCON_MANDO
        '
        Me.DataGridViewTextBoxCON_MANDO.DataPropertyName = "CON_MANDO"
        Me.DataGridViewTextBoxCON_MANDO.HeaderText = "Con mando"
        Me.DataGridViewTextBoxCON_MANDO.Name = "DataGridViewTextBoxCON_MANDO"
        '
        'DataGridViewTextBoxSIN_MANDO
        '
        Me.DataGridViewTextBoxSIN_MANDO.DataPropertyName = "SIN_MANDO"
        Me.DataGridViewTextBoxSIN_MANDO.HeaderText = "Sin mando"
        Me.DataGridViewTextBoxSIN_MANDO.Name = "DataGridViewTextBoxSIN_MANDO"
        '
        'DataGridViewTextBoxADMINISTRATIVOS
        '
        Me.DataGridViewTextBoxADMINISTRATIVOS.DataPropertyName = "ADMINISTRATIVOS"
        Me.DataGridViewTextBoxADMINISTRATIVOS.HeaderText = "Administrativos"
        Me.DataGridViewTextBoxADMINISTRATIVOS.Name = "DataGridViewTextBoxADMINISTRATIVOS"
        '
        'DataGridViewTextBoxMANDOS_MEDIOS
        '
        Me.DataGridViewTextBoxMANDOS_MEDIOS.DataPropertyName = "MANDOS_MEDIOS"
        Me.DataGridViewTextBoxMANDOS_MEDIOS.HeaderText = "Mandos medios"
        Me.DataGridViewTextBoxMANDOS_MEDIOS.Name = "DataGridViewTextBoxMANDOS_MEDIOS"
        '
        'DataGridViewTextBoxOPERATIVOS
        '
        Me.DataGridViewTextBoxOPERATIVOS.DataPropertyName = "OPERATIVOS"
        Me.DataGridViewTextBoxOPERATIVOS.HeaderText = "Operativos"
        Me.DataGridViewTextBoxOPERATIVOS.Name = "DataGridViewTextBoxOPERATIVOS"
        '
        'DataGridViewTextBoxGERENCIAL
        '
        Me.DataGridViewTextBoxGERENCIAL.DataPropertyName = "GERENCIAL"
        Me.DataGridViewTextBoxGERENCIAL.HeaderText = "Gerencial"
        Me.DataGridViewTextBoxGERENCIAL.Name = "DataGridViewTextBoxGERENCIAL"
        '
        'DataGridViewTextBoxSIGLAS
        '
        Me.DataGridViewTextBoxSIGLAS.DataPropertyName = "SIGLAS"
        Me.DataGridViewTextBoxSIGLAS.HeaderText = "Siglas"
        Me.DataGridViewTextBoxSIGLAS.Name = "DataGridViewTextBoxSIGLAS"
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
        'DataGridViewTextBoxOBSERVACION
        '
        Me.DataGridViewTextBoxOBSERVACION.DataPropertyName = "OBSERVACION"
        Me.DataGridViewTextBoxOBSERVACION.HeaderText = "Observacion"
        Me.DataGridViewTextBoxOBSERVACION.Name = "DataGridViewTextBoxOBSERVACION"
        '
        'DataGridViewTextBoxNUM_PAT_ISSS
        '
        Me.DataGridViewTextBoxNUM_PAT_ISSS.DataPropertyName = "NUM_PAT_ISSS"
        Me.DataGridViewTextBoxNUM_PAT_ISSS.HeaderText = "Num pat isss"
        Me.DataGridViewTextBoxNUM_PAT_ISSS.Name = "DataGridViewTextBoxNUM_PAT_ISSS"
        '
        'DataGridViewTextBoxTIPOPERSON
        '
        Me.DataGridViewTextBoxTIPOPERSON.DataPropertyName = "TIPOPERSON"
        Me.DataGridViewTextBoxTIPOPERSON.HeaderText = "Tipoperson"
        Me.DataGridViewTextBoxTIPOPERSON.Name = "DataGridViewTextBoxTIPOPERSON"
        '
        'DataGridViewTextBoxNUM
        '
        Me.DataGridViewTextBoxNUM.DataPropertyName = "NUM"
        Me.DataGridViewTextBoxNUM.HeaderText = "Num"
        Me.DataGridViewTextBoxNUM.Name = "DataGridViewTextBoxNUM"
        '
        'DataGridViewTextBoxREPRESENTANTE_PROFESION
        '
        Me.DataGridViewTextBoxREPRESENTANTE_PROFESION.DataPropertyName = "REPRESENTANTE_PROFESION"
        Me.DataGridViewTextBoxREPRESENTANTE_PROFESION.HeaderText = "Representante profesion"
        Me.DataGridViewTextBoxREPRESENTANTE_PROFESION.Name = "DataGridViewTextBoxREPRESENTANTE_PROFESION"
        '
        'DataGridViewTextBoxCONTACTO_EMAIL
        '
        Me.DataGridViewTextBoxCONTACTO_EMAIL.DataPropertyName = "CONTACTO_EMAIL"
        Me.DataGridViewTextBoxCONTACTO_EMAIL.HeaderText = "Contacto email"
        Me.DataGridViewTextBoxCONTACTO_EMAIL.Name = "DataGridViewTextBoxCONTACTO_EMAIL"
        '
        'DataGridViewTextBoxAPORTE_INSAFORP
        '
        Me.DataGridViewTextBoxAPORTE_INSAFORP.DataPropertyName = "APORTE_INSAFORP"
        Me.DataGridViewTextBoxAPORTE_INSAFORP.HeaderText = "Aporte insaforp"
        Me.DataGridViewTextBoxAPORTE_INSAFORP.Name = "DataGridViewTextBoxAPORTE_INSAFORP"
        '
        'DataGridViewTextBoxZONA
        '
        Me.DataGridViewTextBoxZONA.DataPropertyName = "ZONA"
        Me.DataGridViewTextBoxZONA.HeaderText = "Zona"
        Me.DataGridViewTextBoxZONA.Name = "DataGridViewTextBoxZONA"
        '
        'ucListaEMPRESAS
        '
        Me.Controls.Add(Me.ListaEMPRESASDataGridView)
        Me.Name = "ucListaEMPRESAS"
        Me.Size = New System.Drawing.Size(529, 354)
        Me.Controls.SetChildIndex(Me.ListaEMPRESASDataGridView, 0)
        CType(Me.ListaEMPRESASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaEMPRESASDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListaEMPRESASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListaEMPRESASDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxNUMERO_PATRONAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNIT_EMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCIUU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxSECTOR_PRODUCTIVO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_ASESOR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_MUNICIPIO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_DEPARTAMENTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCODIGO_REGION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNOMBRE_EMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTIPO_EMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCONTACTO_EMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTELEFONO_CONTACTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCARGO_CONTACTO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxDIRECCION_EMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTELEFONO_EMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFAX_EMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxEMAIL_EMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxESPECIALIDAD_EMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTOTAL_PERSONA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTOTAL_PLANILLA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxREPRESENTANTE_LEGAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFECHA_REGISTRO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTOTAL_TRABAJADORES As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxFEMENINOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxMASCULINOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTAMANO_EMPRESA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCON_MANDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxSIN_MANDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxADMINISTRATIVOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxMANDOS_MEDIOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxOPERATIVOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxGERENCIAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxSIGLAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxUSERID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxLASTUPDATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxOBSERVACION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNUM_PAT_ISSS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxTIPOPERSON As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxNUM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxREPRESENTANTE_PROFESION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxCONTACTO_EMAIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxAPORTE_INSAFORP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxZONA As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
