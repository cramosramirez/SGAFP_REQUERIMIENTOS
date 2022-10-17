Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleSOLIC_INSCRIPCION_AF_HIST
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SOLIC_INSCRIPCION_AF_HIST
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/02/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSOLIC_INSCRIPCION_AF_HIST
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_SOLICITUD_HIST As Decimal
    Public Property ID_SOLICITUD_HIST() As Decimal
        Get
            Return Me.txtID_SOLICITUD_HIST.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_SOLICITUD_HIST = Value
            Me.txtID_SOLICITUD_HIST.Text = CStr(Value)
            If Me._ID_SOLICITUD_HIST > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_SOLICITUD() As Decimal
        Get
            Return Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.Items.FindByValue(value) Is Nothing Then
                Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.SelectedValue = value
            End If
        End Set
    End Property

    Public Property FECHA_PRESENTACION() As DateTime
        Get
            Return Me.deFECHA_PRESENTACION.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_PRESENTACION.Value = value
        End Set
    End Property

    Public Property ID_PARTICIPANTE() As Decimal
        Get
            Return Me.ddlPARTICIPANTEID_PARTICIPANTE.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlPARTICIPANTEID_PARTICIPANTE.Items.FindByValue(value) Is Nothing Then
                Me.ddlPARTICIPANTEID_PARTICIPANTE.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            Return Me.ddlACCION_FORMATIVAID_ACCION_FORMATIVA.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlACCION_FORMATIVAID_ACCION_FORMATIVA.Items.FindByValue(value) Is Nothing Then
                Me.ddlACCION_FORMATIVAID_ACCION_FORMATIVA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_ESTADO_SOLICITUD() As Decimal
        Get
            Return Me.ddlESTADO_SOLICITUDID_ESTADO_SOLICITUD.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlESTADO_SOLICITUDID_ESTADO_SOLICITUD.Items.FindByValue(value) Is Nothing Then
                Me.ddlESTADO_SOLICITUDID_ESTADO_SOLICITUD.SelectedValue = value
            End If
        End Set
    End Property

    Public Property NOMBRES() As String
        Get
            Return Me.txtNOMBRES.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRES.Text = value.ToString()
        End Set
    End Property

    Public Property APELLIDOS() As String
        Get
            Return Me.txtAPELLIDOS.Text
        End Get
        Set(ByVal value As String)
            Me.txtAPELLIDOS.Text = value.ToString()
        End Set
    End Property

    Public Property DUI() As String
        Get
            Return Me.txtDUI.Text
        End Get
        Set(ByVal value As String)
            Me.txtDUI.Text = value.ToString()
        End Set
    End Property

    Public Property TIPO_DOCTO() As Decimal
        Get
            If Me.txtTIPO_DOCTO.Value Is Nothing Then Return -1
            Return Me.txtTIPO_DOCTO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTIPO_DOCTO.Value = value
        End Set
    End Property

    Public Property NUM_DOCTO() As String
        Get
            Return Me.txtNUM_DOCTO.Text
        End Get
        Set(ByVal value As String)
            Me.txtNUM_DOCTO.Text = value.ToString()
        End Set
    End Property

    Public Property NIT() As String
        Get
            Return Me.txtNIT.Text
        End Get
        Set(ByVal value As String)
            Me.txtNIT.Text = value.ToString()
        End Set
    End Property

    Public Property ISSS() As String
        Get
            Return Me.txtISSS.Text
        End Get
        Set(ByVal value As String)
            Me.txtISSS.Text = value.ToString()
        End Set
    End Property

    Public Property ID_TIPO_SOLICITUD() As Decimal
        Get
            Return Me.ddlTIPO_SOLICITUDID_TIPO_SOLICITUD.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlTIPO_SOLICITUDID_TIPO_SOLICITUD.Items.FindByValue(value) Is Nothing Then
                Me.ddlTIPO_SOLICITUDID_TIPO_SOLICITUD.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_PAIS() As Decimal
        Get
            Return Me.ddlPAISID_PAIS.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlPAISID_PAIS.Items.FindByValue(value) Is Nothing Then
                Me.ddlPAISID_PAIS.SelectedValue = value
            End If
        End Set
    End Property

    Public Property DEPARTAMENTO_NAC() As String
        Get
            Return Me.txtDEPARTAMENTO_NAC.Text
        End Get
        Set(ByVal value As String)
            Me.txtDEPARTAMENTO_NAC.Text = value.ToString()
        End Set
    End Property

    Public Property MUNICIPIO_NAC() As String
        Get
            Return Me.txtMUNICIPIO_NAC.Text
        End Get
        Set(ByVal value As String)
            Me.txtMUNICIPIO_NAC.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_NACIMIENTO() As DateTime
        Get
            Return Me.deFECHA_NACIMIENTO.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_NACIMIENTO.Value = value
        End Set
    End Property

    Public Property GENERO() As String
        Get
            Return Me.txtGENERO.Text
        End Get
        Set(ByVal value As String)
            Me.txtGENERO.Text = value.ToString()
        End Set
    End Property

    Public Property EDAD() As Decimal
        Get
            If Me.txtEDAD.Value Is Nothing Then Return -1
            Return Me.txtEDAD.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtEDAD.Value = value
        End Set
    End Property

    Public Property MIEMBROS_GRUPO_FAMILIAR() As Decimal
        Get
            If Me.txtMIEMBROS_GRUPO_FAMILIAR.Value Is Nothing Then Return -1
            Return Me.txtMIEMBROS_GRUPO_FAMILIAR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMIEMBROS_GRUPO_FAMILIAR.Value = value
        End Set
    End Property

    Public Property ID_ESTADO_CIVIL() As Decimal
        Get
            Return Me.ddlESTADO_CIVILID_ESTADO_CIVIL.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlESTADO_CIVILID_ESTADO_CIVIL.Items.FindByValue(value) Is Nothing Then
                Me.ddlESTADO_CIVILID_ESTADO_CIVIL.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ES_JEFE_HOGAR() As Decimal
        Get
            If Me.txtES_JEFE_HOGAR.Value Is Nothing Then Return -1
            Return Me.txtES_JEFE_HOGAR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtES_JEFE_HOGAR.Value = value
        End Set
    End Property

    Public Property TIENE_HIJOS() As Decimal
        Get
            If Me.txtTIENE_HIJOS.Value Is Nothing Then Return -1
            Return Me.txtTIENE_HIJOS.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTIENE_HIJOS.Value = value
        End Set
    End Property

    Public Property NO_DE_HIJOS() As Decimal
        Get
            If Me.txtNO_DE_HIJOS.Value Is Nothing Then Return -1
            Return Me.txtNO_DE_HIJOS.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtNO_DE_HIJOS.Value = value
        End Set
    End Property

    Public Property SE_DEDICA_ALGUNA_PROFESION() As Decimal
        Get
            If Me.txtSE_DEDICA_ALGUNA_PROFESION.Value Is Nothing Then Return -1
            Return Me.txtSE_DEDICA_ALGUNA_PROFESION.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtSE_DEDICA_ALGUNA_PROFESION.Value = value
        End Set
    End Property

    Public Property PROFESION_OFICIO() As String
        Get
            Return Me.txtPROFESION_OFICIO.Text
        End Get
        Set(ByVal value As String)
            Me.txtPROFESION_OFICIO.Text = value.ToString()
        End Set
    End Property

    Public Property DIRECCION() As String
        Get
            Return Me.txtDIRECCION.Text
        End Get
        Set(ByVal value As String)
            Me.txtDIRECCION.Text = value.ToString()
        End Set
    End Property

    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Items.FindByValue(value) Is Nothing Then
                Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property CODIGO_MUNICIPIO() As String
        Get
            Return Me.ddlMUNICIPIOCODIGO_MUNICIPIO.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Items.FindByValue(value) Is Nothing Then
                Me.ddlMUNICIPIOCODIGO_MUNICIPIO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property TELEFONO() As String
        Get
            Return Me.txtTELEFONO.Text
        End Get
        Set(ByVal value As String)
            Me.txtTELEFONO.Text = value.ToString()
        End Set
    End Property

    Public Property MOVIL() As String
        Get
            Return Me.txtMOVIL.Text
        End Get
        Set(ByVal value As String)
            Me.txtMOVIL.Text = value.ToString()
        End Set
    End Property

    Public Property EMAIL() As String
        Get
            Return Me.txtEMAIL.Text
        End Get
        Set(ByVal value As String)
            Me.txtEMAIL.Text = value.ToString()
        End Set
    End Property

    Public Property CON_DISCAPACIDAD() As Decimal
        Get
            If Me.txtCON_DISCAPACIDAD.Value Is Nothing Then Return -1
            Return Me.txtCON_DISCAPACIDAD.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtCON_DISCAPACIDAD.Value = value
        End Set
    End Property

    Public Property DISC_OTRA() As String
        Get
            Return Me.txtDISC_OTRA.Text
        End Get
        Set(ByVal value As String)
            Me.txtDISC_OTRA.Text = value.ToString()
        End Set
    End Property

    Public Property ID_LEE_ESCRIBE() As Decimal
        Get
            Return Me.ddlEDUC_LEE_ESCRIBEID_LEE_ESCRIBE.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlEDUC_LEE_ESCRIBEID_LEE_ESCRIBE.Items.FindByValue(value) Is Nothing Then
                Me.ddlEDUC_LEE_ESCRIBEID_LEE_ESCRIBE.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_NIVEL_ACADEMICO() As Decimal
        Get
            Return Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.Items.FindByValue(value) Is Nothing Then
                Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property OTRA_EDUCACION_FORMAL() As String
        Get
            Return Me.txtOTRA_EDUCACION_FORMAL.Text
        End Get
        Set(ByVal value As String)
            Me.txtOTRA_EDUCACION_FORMAL.Text = value.ToString()
        End Set
    End Property

    Public Property TITULO_CERTIFICADO_OBTENIDO() As String
        Get
            Return Me.txtTITULO_CERTIFICADO_OBTENIDO.Text
        End Get
        Set(ByVal value As String)
            Me.txtTITULO_CERTIFICADO_OBTENIDO.Text = value.ToString()
        End Set
    End Property

    Public Property ESTUDIA_ACTUALMENTE() As Decimal
        Get
            If Me.txtESTUDIA_ACTUALMENTE.Value Is Nothing Then Return -1
            Return Me.txtESTUDIA_ACTUALMENTE.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtESTUDIA_ACTUALMENTE.Value = value
        End Set
    End Property

    Public Property ID_TIEMPO_DEJO_ESTUDIAR() As Decimal
        Get
            Return Me.ddlTIEMPO_DEJO_ESTUDIARID_TIEMPO_DEJO_ESTUDIAR.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlTIEMPO_DEJO_ESTUDIARID_TIEMPO_DEJO_ESTUDIAR.Items.FindByValue(value) Is Nothing Then
                Me.ddlTIEMPO_DEJO_ESTUDIARID_TIEMPO_DEJO_ESTUDIAR.SelectedValue = value
            End If
        End Set
    End Property

    Public Property RECIBIO_CURSO_ANTERIOR() As String
        Get
            Return Me.txtRECIBIO_CURSO_ANTERIOR.Text
        End Get
        Set(ByVal value As String)
            Me.txtRECIBIO_CURSO_ANTERIOR.Text = value.ToString()
        End Set
    End Property

    Public Property BENEF_PROM_EMP_ACT() As Decimal
        Get
            If Me.txtBENEF_PROM_EMP_ACT.Value Is Nothing Then Return -1
            Return Me.txtBENEF_PROM_EMP_ACT.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtBENEF_PROM_EMP_ACT.Value = value
        End Set
    End Property

    Public Property BENEF_OBT_EMPLEO() As Decimal
        Get
            If Me.txtBENEF_OBT_EMPLEO.Value Is Nothing Then Return -1
            Return Me.txtBENEF_OBT_EMPLEO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtBENEF_OBT_EMPLEO.Value = value
        End Set
    End Property

    Public Property BENEF_OBT_ING_EXTRA() As Decimal
        Get
            If Me.txtBENEF_OBT_ING_EXTRA.Value Is Nothing Then Return -1
            Return Me.txtBENEF_OBT_ING_EXTRA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtBENEF_OBT_ING_EXTRA.Value = value
        End Set
    End Property

    Public Property BENEF_CAMB_EMP_X_CURSO() As Decimal
        Get
            If Me.txtBENEF_CAMB_EMP_X_CURSO.Value Is Nothing Then Return -1
            Return Me.txtBENEF_CAMB_EMP_X_CURSO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtBENEF_CAMB_EMP_X_CURSO.Value = value
        End Set
    End Property

    Public Property BENEF_TRAB_CTA_PROPIA() As Decimal
        Get
            If Me.txtBENEF_TRAB_CTA_PROPIA.Value Is Nothing Then Return -1
            Return Me.txtBENEF_TRAB_CTA_PROPIA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtBENEF_TRAB_CTA_PROPIA.Value = value
        End Set
    End Property

    Public Property BENEF_OTRO() As String
        Get
            Return Me.txtBENEF_OTRO.Text
        End Get
        Set(ByVal value As String)
            Me.txtBENEF_OTRO.Text = value.ToString()
        End Set
    End Property

    Public Property RAZON_NO_BENEFICIO() As String
        Get
            Return Me.txtRAZON_NO_BENEFICIO.Text
        End Get
        Set(ByVal value As String)
            Me.txtRAZON_NO_BENEFICIO.Text = value.ToString()
        End Set
    End Property

    Public Property OCUACT_TRABAJA() As Decimal
        Get
            If Me.txtOCUACT_TRABAJA.Value Is Nothing Then Return -1
            Return Me.txtOCUACT_TRABAJA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtOCUACT_TRABAJA.Value = value
        End Set
    End Property

    Public Property OCUACT_ESTUDIA() As Decimal
        Get
            If Me.txtOCUACT_ESTUDIA.Value Is Nothing Then Return -1
            Return Me.txtOCUACT_ESTUDIA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtOCUACT_ESTUDIA.Value = value
        End Set
    End Property

    Public Property OCUACT_DESOCUPADO() As Decimal
        Get
            If Me.txtOCUACT_DESOCUPADO.Value Is Nothing Then Return -1
            Return Me.txtOCUACT_DESOCUPADO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtOCUACT_DESOCUPADO.Value = value
        End Set
    End Property

    Public Property OCUACT_OFICIO_HOGAR() As Decimal
        Get
            If Me.txtOCUACT_OFICIO_HOGAR.Value Is Nothing Then Return -1
            Return Me.txtOCUACT_OFICIO_HOGAR.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtOCUACT_OFICIO_HOGAR.Value = value
        End Set
    End Property

    Public Property OCUACT_BUSCA_TRABAJO() As Decimal
        Get
            If Me.txtOCUACT_BUSCA_TRABAJO.Value Is Nothing Then Return -1
            Return Me.txtOCUACT_BUSCA_TRABAJO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtOCUACT_BUSCA_TRABAJO.Value = value
        End Set
    End Property

    Public Property OCUACT_OTRA() As String
        Get
            Return Me.txtOCUACT_OTRA.Text
        End Get
        Set(ByVal value As String)
            Me.txtOCUACT_OTRA.Text = value.ToString()
        End Set
    End Property

    Public Property ID_TIPO_EMPLEO() As Decimal
        Get
            Return Me.ddlTIPO_EMPLEOID_TIPO_EMPLEO.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlTIPO_EMPLEOID_TIPO_EMPLEO.Items.FindByValue(value) Is Nothing Then
                Me.ddlTIPO_EMPLEOID_TIPO_EMPLEO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property SECTOR_EMPLEO() As Decimal
        Get
            If Me.txtSECTOR_EMPLEO.Value Is Nothing Then Return -1
            Return Me.txtSECTOR_EMPLEO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtSECTOR_EMPLEO.Value = value
        End Set
    End Property

    Public Property TRABAJO_ANTERIOR() As String
        Get
            Return Me.txtTRABAJO_ANTERIOR.Text
        End Get
        Set(ByVal value As String)
            Me.txtTRABAJO_ANTERIOR.Text = value.ToString()
        End Set
    End Property

    Public Property RECIBE_INGRESOS() As Decimal
        Get
            If Me.txtRECIBE_INGRESOS.Value Is Nothing Then Return -1
            Return Me.txtRECIBE_INGRESOS.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtRECIBE_INGRESOS.Value = value
        End Set
    End Property

    Public Property MANERA_OBT_ING_TRABAJO() As Decimal
        Get
            If Me.txtMANERA_OBT_ING_TRABAJO.Value Is Nothing Then Return -1
            Return Me.txtMANERA_OBT_ING_TRABAJO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMANERA_OBT_ING_TRABAJO.Value = value
        End Set
    End Property

    Public Property MANERA_OBT_ING_AYUDA_FAM() As Decimal
        Get
            If Me.txtMANERA_OBT_ING_AYUDA_FAM.Value Is Nothing Then Return -1
            Return Me.txtMANERA_OBT_ING_AYUDA_FAM.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMANERA_OBT_ING_AYUDA_FAM.Value = value
        End Set
    End Property

    Public Property MANERA_OBT_ING_REMESA() As Decimal
        Get
            If Me.txtMANERA_OBT_ING_REMESA.Value Is Nothing Then Return -1
            Return Me.txtMANERA_OBT_ING_REMESA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMANERA_OBT_ING_REMESA.Value = value
        End Set
    End Property

    Public Property MANERA_OBT_ING_PENSION() As Decimal
        Get
            If Me.txtMANERA_OBT_ING_PENSION.Value Is Nothing Then Return -1
            Return Me.txtMANERA_OBT_ING_PENSION.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMANERA_OBT_ING_PENSION.Value = value
        End Set
    End Property

    Public Property MANERA_OBT_ING_OTRO() As String
        Get
            Return Me.txtMANERA_OBT_ING_OTRO.Text
        End Get
        Set(ByVal value As String)
            Me.txtMANERA_OBT_ING_OTRO.Text = value.ToString()
        End Set
    End Property

    Public Property EXPFOR_PROMOCION_EMPLEO() As Decimal
        Get
            If Me.txtEXPFOR_PROMOCION_EMPLEO.Value Is Nothing Then Return -1
            Return Me.txtEXPFOR_PROMOCION_EMPLEO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtEXPFOR_PROMOCION_EMPLEO.Value = value
        End Set
    End Property

    Public Property EXPFOR_CAMBIAR_EMPLEO() As Decimal
        Get
            If Me.txtEXPFOR_CAMBIAR_EMPLEO.Value Is Nothing Then Return -1
            Return Me.txtEXPFOR_CAMBIAR_EMPLEO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtEXPFOR_CAMBIAR_EMPLEO.Value = value
        End Set
    End Property

    Public Property EXPFOR_OBTENER_EMPLEO() As Decimal
        Get
            If Me.txtEXPFOR_OBTENER_EMPLEO.Value Is Nothing Then Return -1
            Return Me.txtEXPFOR_OBTENER_EMPLEO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtEXPFOR_OBTENER_EMPLEO.Value = value
        End Set
    End Property

    Public Property EXPFOR_TRABAJAR_CTA_PROPIA() As Decimal
        Get
            If Me.txtEXPFOR_TRABAJAR_CTA_PROPIA.Value Is Nothing Then Return -1
            Return Me.txtEXPFOR_TRABAJAR_CTA_PROPIA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtEXPFOR_TRABAJAR_CTA_PROPIA.Value = value
        End Set
    End Property

    Public Property EXPFOR_INGRESOS_EXTRAS() As Decimal
        Get
            If Me.txtEXPFOR_INGRESOS_EXTRAS.Value Is Nothing Then Return -1
            Return Me.txtEXPFOR_INGRESOS_EXTRAS.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtEXPFOR_INGRESOS_EXTRAS.Value = value
        End Set
    End Property

    Public Property EXPFOR_NINGUNO() As Decimal
        Get
            If Me.txtEXPFOR_NINGUNO.Value Is Nothing Then Return -1
            Return Me.txtEXPFOR_NINGUNO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtEXPFOR_NINGUNO.Value = value
        End Set
    End Property

    Public Property EXPFOR_OTRO() As String
        Get
            Return Me.txtEXPFOR_OTRO.Text
        End Get
        Set(ByVal value As String)
            Me.txtEXPFOR_OTRO.Text = value.ToString()
        End Set
    End Property

    Public Property CURSO_REL_TRAB_ACTUAL() As Decimal
        Get
            If Me.txtCURSO_REL_TRAB_ACTUAL.Value Is Nothing Then Return -1
            Return Me.txtCURSO_REL_TRAB_ACTUAL.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtCURSO_REL_TRAB_ACTUAL.Value = value
        End Set
    End Property

    Public Property CURSO_REL_TRAB_NUEVO() As Decimal
        Get
            If Me.txtCURSO_REL_TRAB_NUEVO.Value Is Nothing Then Return -1
            Return Me.txtCURSO_REL_TRAB_NUEVO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtCURSO_REL_TRAB_NUEVO.Value = value
        End Set
    End Property

    Public Property NOMBRE_REFERENCIA() As String
        Get
            Return Me.txtNOMBRE_REFERENCIA.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_REFERENCIA.Text = value.ToString()
        End Set
    End Property

    Public Property ID_REFERENCIA() As Decimal
        Get
            Return Me.ddlREFERENCIAID_REFERENCIA.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlREFERENCIAID_REFERENCIA.Items.FindByValue(value) Is Nothing Then
                Me.ddlREFERENCIAID_REFERENCIA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property DIRECCION_REFERENCIA() As String
        Get
            Return Me.txtDIRECCION_REFERENCIA.Text
        End Get
        Set(ByVal value As String)
            Me.txtDIRECCION_REFERENCIA.Text = value.ToString()
        End Set
    End Property

    Public Property DEPARTAMENTO_REFERENCIA() As String
        Get
            Return Me.txtDEPARTAMENTO_REFERENCIA.Text
        End Get
        Set(ByVal value As String)
            Me.txtDEPARTAMENTO_REFERENCIA.Text = value.ToString()
        End Set
    End Property

    Public Property MUNICIPIO_REFERENCIA() As String
        Get
            Return Me.txtMUNICIPIO_REFERENCIA.Text
        End Get
        Set(ByVal value As String)
            Me.txtMUNICIPIO_REFERENCIA.Text = value.ToString()
        End Set
    End Property

    Public Property TELEFONO_REFERENCIA() As String
        Get
            Return Me.txtTELEFONO_REFERENCIA.Text
        End Get
        Set(ByVal value As String)
            Me.txtTELEFONO_REFERENCIA.Text = value.ToString()
        End Set
    End Property

    Public Property MOVIL_REFERENCIA() As String
        Get
            Return Me.txtMOVIL_REFERENCIA.Text
        End Get
        Set(ByVal value As String)
            Me.txtMOVIL_REFERENCIA.Text = value.ToString()
        End Set
    End Property

    Public Property EMAIL_REFERENCIA() As String
        Get
            Return Me.txtEMAIL_REFERENCIA.Text
        End Get
        Set(ByVal value As String)
            Me.txtEMAIL_REFERENCIA.Text = value.ToString()
        End Set
    End Property

    Public Property SUGERENCIAS() As String
        Get
            Return Me.txtSUGERENCIAS.Text
        End Get
        Set(ByVal value As String)
            Me.txtSUGERENCIAS.Text = value.ToString()
        End Set
    End Property

    Public Property USERID() As String
        Get
            Return Me.txtUSERID.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSERID.Text = value.ToString()
        End Set
    End Property

    Public Property LASTUPDATE() As DateTime
        Get
            Return Me.deLASTUPDATE.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deLASTUPDATE.Value = value
        End Set
    End Property

    Public Property VerID_SOLICITUD_HIST() As Boolean
        Get
            Return Me.trID_SOLICITUD_HIST.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_SOLICITUD_HIST.Visible = value
        End Set
    End Property

    Public Property VerID_SOLICITUD() As Boolean
        Get
            Return Me.trID_SOLICITUD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_SOLICITUD.Visible = value
        End Set
    End Property

    Public Property VerFECHA_PRESENTACION() As Boolean
        Get
            Return Me.trFECHA_PRESENTACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_PRESENTACION.Visible = value
        End Set
    End Property

    Public Property VerID_PARTICIPANTE() As Boolean
        Get
            Return Me.trID_PARTICIPANTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PARTICIPANTE.Visible = value
        End Set
    End Property

    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me.trID_ACCION_FORMATIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Public Property VerID_ESTADO_SOLICITUD() As Boolean
        Get
            Return Me.trID_ESTADO_SOLICITUD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ESTADO_SOLICITUD.Visible = value
        End Set
    End Property

    Public Property VerNOMBRES() As Boolean
        Get
            Return Me.trNOMBRES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRES.Visible = value
        End Set
    End Property

    Public Property VerAPELLIDOS() As Boolean
        Get
            Return Me.trAPELLIDOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAPELLIDOS.Visible = value
        End Set
    End Property

    Public Property VerDUI() As Boolean
        Get
            Return Me.trDUI.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDUI.Visible = value
        End Set
    End Property

    Public Property VerTIPO_DOCTO() As Boolean
        Get
            Return Me.trTIPO_DOCTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_DOCTO.Visible = value
        End Set
    End Property

    Public Property VerNUM_DOCTO() As Boolean
        Get
            Return Me.trNUM_DOCTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNUM_DOCTO.Visible = value
        End Set
    End Property

    Public Property VerNIT() As Boolean
        Get
            Return Me.trNIT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNIT.Visible = value
        End Set
    End Property

    Public Property VerISSS() As Boolean
        Get
            Return Me.trISSS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trISSS.Visible = value
        End Set
    End Property

    Public Property VerID_TIPO_SOLICITUD() As Boolean
        Get
            Return Me.trID_TIPO_SOLICITUD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIPO_SOLICITUD.Visible = value
        End Set
    End Property

    Public Property VerID_PAIS() As Boolean
        Get
            Return Me.trID_PAIS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PAIS.Visible = value
        End Set
    End Property

    Public Property VerDEPARTAMENTO_NAC() As Boolean
        Get
            Return Me.trDEPARTAMENTO_NAC.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDEPARTAMENTO_NAC.Visible = value
        End Set
    End Property

    Public Property VerMUNICIPIO_NAC() As Boolean
        Get
            Return Me.trMUNICIPIO_NAC.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMUNICIPIO_NAC.Visible = value
        End Set
    End Property

    Public Property VerFECHA_NACIMIENTO() As Boolean
        Get
            Return Me.trFECHA_NACIMIENTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_NACIMIENTO.Visible = value
        End Set
    End Property

    Public Property VerGENERO() As Boolean
        Get
            Return Me.trGENERO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trGENERO.Visible = value
        End Set
    End Property

    Public Property VerEDAD() As Boolean
        Get
            Return Me.trEDAD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEDAD.Visible = value
        End Set
    End Property

    Public Property VerMIEMBROS_GRUPO_FAMILIAR() As Boolean
        Get
            Return Me.trMIEMBROS_GRUPO_FAMILIAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMIEMBROS_GRUPO_FAMILIAR.Visible = value
        End Set
    End Property

    Public Property VerID_ESTADO_CIVIL() As Boolean
        Get
            Return Me.trID_ESTADO_CIVIL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ESTADO_CIVIL.Visible = value
        End Set
    End Property

    Public Property VerES_JEFE_HOGAR() As Boolean
        Get
            Return Me.trES_JEFE_HOGAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trES_JEFE_HOGAR.Visible = value
        End Set
    End Property

    Public Property VerTIENE_HIJOS() As Boolean
        Get
            Return Me.trTIENE_HIJOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIENE_HIJOS.Visible = value
        End Set
    End Property

    Public Property VerNO_DE_HIJOS() As Boolean
        Get
            Return Me.trNO_DE_HIJOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNO_DE_HIJOS.Visible = value
        End Set
    End Property

    Public Property VerSE_DEDICA_ALGUNA_PROFESION() As Boolean
        Get
            Return Me.trSE_DEDICA_ALGUNA_PROFESION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSE_DEDICA_ALGUNA_PROFESION.Visible = value
        End Set
    End Property

    Public Property VerPROFESION_OFICIO() As Boolean
        Get
            Return Me.trPROFESION_OFICIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPROFESION_OFICIO.Visible = value
        End Set
    End Property

    Public Property VerDIRECCION() As Boolean
        Get
            Return Me.trDIRECCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDIRECCION.Visible = value
        End Set
    End Property

    Public Property VerCODIGO_DEPARTAMENTO() As Boolean
        Get
            Return Me.trCODIGO_DEPARTAMENTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_DEPARTAMENTO.Visible = value
        End Set
    End Property

    Public Property VerCODIGO_MUNICIPIO() As Boolean
        Get
            Return Me.trCODIGO_MUNICIPIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_MUNICIPIO.Visible = value
        End Set
    End Property

    Public Property VerTELEFONO() As Boolean
        Get
            Return Me.trTELEFONO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTELEFONO.Visible = value
        End Set
    End Property

    Public Property VerMOVIL() As Boolean
        Get
            Return Me.trMOVIL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMOVIL.Visible = value
        End Set
    End Property

    Public Property VerEMAIL() As Boolean
        Get
            Return Me.trEMAIL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEMAIL.Visible = value
        End Set
    End Property

    Public Property VerCON_DISCAPACIDAD() As Boolean
        Get
            Return Me.trCON_DISCAPACIDAD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCON_DISCAPACIDAD.Visible = value
        End Set
    End Property

    Public Property VerDISC_OTRA() As Boolean
        Get
            Return Me.trDISC_OTRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDISC_OTRA.Visible = value
        End Set
    End Property

    Public Property VerID_LEE_ESCRIBE() As Boolean
        Get
            Return Me.trID_LEE_ESCRIBE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_LEE_ESCRIBE.Visible = value
        End Set
    End Property

    Public Property VerID_NIVEL_ACADEMICO() As Boolean
        Get
            Return Me.trID_NIVEL_ACADEMICO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_NIVEL_ACADEMICO.Visible = value
        End Set
    End Property

    Public Property VerOTRA_EDUCACION_FORMAL() As Boolean
        Get
            Return Me.trOTRA_EDUCACION_FORMAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOTRA_EDUCACION_FORMAL.Visible = value
        End Set
    End Property

    Public Property VerTITULO_CERTIFICADO_OBTENIDO() As Boolean
        Get
            Return Me.trTITULO_CERTIFICADO_OBTENIDO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTITULO_CERTIFICADO_OBTENIDO.Visible = value
        End Set
    End Property

    Public Property VerESTUDIA_ACTUALMENTE() As Boolean
        Get
            Return Me.trESTUDIA_ACTUALMENTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trESTUDIA_ACTUALMENTE.Visible = value
        End Set
    End Property

    Public Property VerID_TIEMPO_DEJO_ESTUDIAR() As Boolean
        Get
            Return Me.trID_TIEMPO_DEJO_ESTUDIAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIEMPO_DEJO_ESTUDIAR.Visible = value
        End Set
    End Property

    Public Property VerRECIBIO_CURSO_ANTERIOR() As Boolean
        Get
            Return Me.trRECIBIO_CURSO_ANTERIOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trRECIBIO_CURSO_ANTERIOR.Visible = value
        End Set
    End Property

    Public Property VerBENEF_PROM_EMP_ACT() As Boolean
        Get
            Return Me.trBENEF_PROM_EMP_ACT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trBENEF_PROM_EMP_ACT.Visible = value
        End Set
    End Property

    Public Property VerBENEF_OBT_EMPLEO() As Boolean
        Get
            Return Me.trBENEF_OBT_EMPLEO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trBENEF_OBT_EMPLEO.Visible = value
        End Set
    End Property

    Public Property VerBENEF_OBT_ING_EXTRA() As Boolean
        Get
            Return Me.trBENEF_OBT_ING_EXTRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trBENEF_OBT_ING_EXTRA.Visible = value
        End Set
    End Property

    Public Property VerBENEF_CAMB_EMP_X_CURSO() As Boolean
        Get
            Return Me.trBENEF_CAMB_EMP_X_CURSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trBENEF_CAMB_EMP_X_CURSO.Visible = value
        End Set
    End Property

    Public Property VerBENEF_TRAB_CTA_PROPIA() As Boolean
        Get
            Return Me.trBENEF_TRAB_CTA_PROPIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trBENEF_TRAB_CTA_PROPIA.Visible = value
        End Set
    End Property

    Public Property VerBENEF_OTRO() As Boolean
        Get
            Return Me.trBENEF_OTRO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trBENEF_OTRO.Visible = value
        End Set
    End Property

    Public Property VerRAZON_NO_BENEFICIO() As Boolean
        Get
            Return Me.trRAZON_NO_BENEFICIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trRAZON_NO_BENEFICIO.Visible = value
        End Set
    End Property

    Public Property VerOCUACT_TRABAJA() As Boolean
        Get
            Return Me.trOCUACT_TRABAJA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOCUACT_TRABAJA.Visible = value
        End Set
    End Property

    Public Property VerOCUACT_ESTUDIA() As Boolean
        Get
            Return Me.trOCUACT_ESTUDIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOCUACT_ESTUDIA.Visible = value
        End Set
    End Property

    Public Property VerOCUACT_DESOCUPADO() As Boolean
        Get
            Return Me.trOCUACT_DESOCUPADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOCUACT_DESOCUPADO.Visible = value
        End Set
    End Property

    Public Property VerOCUACT_OFICIO_HOGAR() As Boolean
        Get
            Return Me.trOCUACT_OFICIO_HOGAR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOCUACT_OFICIO_HOGAR.Visible = value
        End Set
    End Property

    Public Property VerOCUACT_BUSCA_TRABAJO() As Boolean
        Get
            Return Me.trOCUACT_BUSCA_TRABAJO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOCUACT_BUSCA_TRABAJO.Visible = value
        End Set
    End Property

    Public Property VerOCUACT_OTRA() As Boolean
        Get
            Return Me.trOCUACT_OTRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOCUACT_OTRA.Visible = value
        End Set
    End Property

    Public Property VerID_TIPO_EMPLEO() As Boolean
        Get
            Return Me.trID_TIPO_EMPLEO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIPO_EMPLEO.Visible = value
        End Set
    End Property

    Public Property VerSECTOR_EMPLEO() As Boolean
        Get
            Return Me.trSECTOR_EMPLEO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSECTOR_EMPLEO.Visible = value
        End Set
    End Property

    Public Property VerTRABAJO_ANTERIOR() As Boolean
        Get
            Return Me.trTRABAJO_ANTERIOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTRABAJO_ANTERIOR.Visible = value
        End Set
    End Property

    Public Property VerRECIBE_INGRESOS() As Boolean
        Get
            Return Me.trRECIBE_INGRESOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trRECIBE_INGRESOS.Visible = value
        End Set
    End Property

    Public Property VerMANERA_OBT_ING_TRABAJO() As Boolean
        Get
            Return Me.trMANERA_OBT_ING_TRABAJO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMANERA_OBT_ING_TRABAJO.Visible = value
        End Set
    End Property

    Public Property VerMANERA_OBT_ING_AYUDA_FAM() As Boolean
        Get
            Return Me.trMANERA_OBT_ING_AYUDA_FAM.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMANERA_OBT_ING_AYUDA_FAM.Visible = value
        End Set
    End Property

    Public Property VerMANERA_OBT_ING_REMESA() As Boolean
        Get
            Return Me.trMANERA_OBT_ING_REMESA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMANERA_OBT_ING_REMESA.Visible = value
        End Set
    End Property

    Public Property VerMANERA_OBT_ING_PENSION() As Boolean
        Get
            Return Me.trMANERA_OBT_ING_PENSION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMANERA_OBT_ING_PENSION.Visible = value
        End Set
    End Property

    Public Property VerMANERA_OBT_ING_OTRO() As Boolean
        Get
            Return Me.trMANERA_OBT_ING_OTRO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMANERA_OBT_ING_OTRO.Visible = value
        End Set
    End Property

    Public Property VerEXPFOR_PROMOCION_EMPLEO() As Boolean
        Get
            Return Me.trEXPFOR_PROMOCION_EMPLEO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEXPFOR_PROMOCION_EMPLEO.Visible = value
        End Set
    End Property

    Public Property VerEXPFOR_CAMBIAR_EMPLEO() As Boolean
        Get
            Return Me.trEXPFOR_CAMBIAR_EMPLEO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEXPFOR_CAMBIAR_EMPLEO.Visible = value
        End Set
    End Property

    Public Property VerEXPFOR_OBTENER_EMPLEO() As Boolean
        Get
            Return Me.trEXPFOR_OBTENER_EMPLEO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEXPFOR_OBTENER_EMPLEO.Visible = value
        End Set
    End Property

    Public Property VerEXPFOR_TRABAJAR_CTA_PROPIA() As Boolean
        Get
            Return Me.trEXPFOR_TRABAJAR_CTA_PROPIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEXPFOR_TRABAJAR_CTA_PROPIA.Visible = value
        End Set
    End Property

    Public Property VerEXPFOR_INGRESOS_EXTRAS() As Boolean
        Get
            Return Me.trEXPFOR_INGRESOS_EXTRAS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEXPFOR_INGRESOS_EXTRAS.Visible = value
        End Set
    End Property

    Public Property VerEXPFOR_NINGUNO() As Boolean
        Get
            Return Me.trEXPFOR_NINGUNO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEXPFOR_NINGUNO.Visible = value
        End Set
    End Property

    Public Property VerEXPFOR_OTRO() As Boolean
        Get
            Return Me.trEXPFOR_OTRO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEXPFOR_OTRO.Visible = value
        End Set
    End Property

    Public Property VerCURSO_REL_TRAB_ACTUAL() As Boolean
        Get
            Return Me.trCURSO_REL_TRAB_ACTUAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCURSO_REL_TRAB_ACTUAL.Visible = value
        End Set
    End Property

    Public Property VerCURSO_REL_TRAB_NUEVO() As Boolean
        Get
            Return Me.trCURSO_REL_TRAB_NUEVO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCURSO_REL_TRAB_NUEVO.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_REFERENCIA() As Boolean
        Get
            Return Me.trNOMBRE_REFERENCIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_REFERENCIA.Visible = value
        End Set
    End Property

    Public Property VerID_REFERENCIA() As Boolean
        Get
            Return Me.trID_REFERENCIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_REFERENCIA.Visible = value
        End Set
    End Property

    Public Property VerDIRECCION_REFERENCIA() As Boolean
        Get
            Return Me.trDIRECCION_REFERENCIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDIRECCION_REFERENCIA.Visible = value
        End Set
    End Property

    Public Property VerDEPARTAMENTO_REFERENCIA() As Boolean
        Get
            Return Me.trDEPARTAMENTO_REFERENCIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDEPARTAMENTO_REFERENCIA.Visible = value
        End Set
    End Property

    Public Property VerMUNICIPIO_REFERENCIA() As Boolean
        Get
            Return Me.trMUNICIPIO_REFERENCIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMUNICIPIO_REFERENCIA.Visible = value
        End Set
    End Property

    Public Property VerTELEFONO_REFERENCIA() As Boolean
        Get
            Return Me.trTELEFONO_REFERENCIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTELEFONO_REFERENCIA.Visible = value
        End Set
    End Property

    Public Property VerMOVIL_REFERENCIA() As Boolean
        Get
            Return Me.trMOVIL_REFERENCIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMOVIL_REFERENCIA.Visible = value
        End Set
    End Property

    Public Property VerEMAIL_REFERENCIA() As Boolean
        Get
            Return Me.trEMAIL_REFERENCIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEMAIL_REFERENCIA.Visible = value
        End Set
    End Property

    Public Property VerSUGERENCIAS() As Boolean
        Get
            Return Me.trSUGERENCIAS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSUGERENCIAS.Visible = value
        End Set
    End Property

    Public Property VerUSERID() As Boolean
        Get
            Return Me.trUSERID.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSERID.Visible = value
        End Set
    End Property

    Public Property VerLASTUPDATE() As Boolean
        Get
            Return Me.trLASTUPDATE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLASTUPDATE.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cSOLIC_INSCRIPCION_AF_HIST
    Private mEntidad As SOLIC_INSCRIPCION_AF_HIST
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property
 
    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_SOLICITUD_HIST") Is Nothing Then Me._ID_SOLICITUD_HIST = Me.ViewState("ID_SOLICITUD_HIST")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla SOLIC_INSCRIPCION_AF_HIST
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New SOLIC_INSCRIPCION_AF_HIST
        mEntidad.ID_SOLICITUD_HIST = ID_SOLICITUD_HIST
 
        If mComponente.ObtenerSOLIC_INSCRIPCION_AF_HIST(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_SOLICITUD_HIST.Text = mEntidad.ID_SOLICITUD_HIST.ToString()
        Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.Recuperar()
        Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.SelectedValue = mEntidad.ID_SOLICITUD
        Me.deFECHA_PRESENTACION.Value = mEntidad.FECHA_PRESENTACION
        Me.ddlPARTICIPANTEID_PARTICIPANTE.Recuperar()
        Me.ddlPARTICIPANTEID_PARTICIPANTE.SelectedValue = mEntidad.ID_PARTICIPANTE
        Me.ddlACCION_FORMATIVAID_ACCION_FORMATIVA.Recuperar()
        Me.ddlACCION_FORMATIVAID_ACCION_FORMATIVA.SelectedValue = mEntidad.ID_ACCION_FORMATIVA
        Me.ddlESTADO_SOLICITUDID_ESTADO_SOLICITUD.Recuperar()
        Me.ddlESTADO_SOLICITUDID_ESTADO_SOLICITUD.SelectedValue = mEntidad.ID_ESTADO_SOLICITUD
        Me.txtNOMBRES.Text = mEntidad.NOMBRES
        Me.txtAPELLIDOS.Text = mEntidad.APELLIDOS
        Me.txtDUI.Text = mEntidad.DUI
        Me.txtTIPO_DOCTO.Value = mEntidad.TIPO_DOCTO
        Me.txtNUM_DOCTO.Text = mEntidad.NUM_DOCTO
        Me.txtNIT.Text = mEntidad.NIT
        Me.txtISSS.Text = mEntidad.ISSS
        Me.ddlTIPO_SOLICITUDID_TIPO_SOLICITUD.Recuperar()
        Me.ddlTIPO_SOLICITUDID_TIPO_SOLICITUD.SelectedValue = mEntidad.ID_TIPO_SOLICITUD
        Me.ddlPAISID_PAIS.Recuperar()
        Me.ddlPAISID_PAIS.SelectedValue = mEntidad.ID_PAIS
        Me.txtDEPARTAMENTO_NAC.Text = mEntidad.DEPARTAMENTO_NAC
        Me.txtMUNICIPIO_NAC.Text = mEntidad.MUNICIPIO_NAC
        Me.deFECHA_NACIMIENTO.Value = mEntidad.FECHA_NACIMIENTO
        Me.txtGENERO.Text = mEntidad.GENERO
        Me.txtEDAD.Value = mEntidad.EDAD
        Me.txtMIEMBROS_GRUPO_FAMILIAR.Value = mEntidad.MIEMBROS_GRUPO_FAMILIAR
        Me.ddlESTADO_CIVILID_ESTADO_CIVIL.Recuperar()
        Me.ddlESTADO_CIVILID_ESTADO_CIVIL.SelectedValue = mEntidad.ID_ESTADO_CIVIL
        Me.txtES_JEFE_HOGAR.Value = mEntidad.ES_JEFE_HOGAR
        Me.txtTIENE_HIJOS.Value = mEntidad.TIENE_HIJOS
        Me.txtNO_DE_HIJOS.Value = mEntidad.NO_DE_HIJOS
        Me.txtSE_DEDICA_ALGUNA_PROFESION.Value = mEntidad.SE_DEDICA_ALGUNA_PROFESION
        Me.txtPROFESION_OFICIO.Text = mEntidad.PROFESION_OFICIO
        Me.txtDIRECCION.Text = mEntidad.DIRECCION
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Recuperar()
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue = mEntidad.CODIGO_DEPARTAMENTO
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Recuperar(Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue)
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.SelectedValue = mEntidad.CODIGO_MUNICIPIO
        Me.txtTELEFONO.Text = mEntidad.TELEFONO
        Me.txtMOVIL.Text = mEntidad.MOVIL
        Me.txtEMAIL.Text = mEntidad.EMAIL
        Me.txtCON_DISCAPACIDAD.Value = mEntidad.CON_DISCAPACIDAD
        Me.txtDISC_OTRA.Text = mEntidad.DISC_OTRA
        Me.ddlEDUC_LEE_ESCRIBEID_LEE_ESCRIBE.Recuperar()
        Me.ddlEDUC_LEE_ESCRIBEID_LEE_ESCRIBE.SelectedValue = mEntidad.ID_LEE_ESCRIBE
        Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.Recuperar()
        Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.SelectedValue = mEntidad.ID_NIVEL_ACADEMICO
        Me.txtOTRA_EDUCACION_FORMAL.Text = mEntidad.OTRA_EDUCACION_FORMAL
        Me.txtTITULO_CERTIFICADO_OBTENIDO.Text = mEntidad.TITULO_CERTIFICADO_OBTENIDO
        Me.txtESTUDIA_ACTUALMENTE.Value = mEntidad.ESTUDIA_ACTUALMENTE
        Me.ddlTIEMPO_DEJO_ESTUDIARID_TIEMPO_DEJO_ESTUDIAR.Recuperar()
        Me.ddlTIEMPO_DEJO_ESTUDIARID_TIEMPO_DEJO_ESTUDIAR.SelectedValue = mEntidad.ID_TIEMPO_DEJO_ESTUDIAR
        Me.txtRECIBIO_CURSO_ANTERIOR.Text = mEntidad.RECIBIO_CURSO_ANTERIOR
        Me.txtBENEF_PROM_EMP_ACT.Value = mEntidad.BENEF_PROM_EMP_ACT
        Me.txtBENEF_OBT_EMPLEO.Value = mEntidad.BENEF_OBT_EMPLEO
        Me.txtBENEF_OBT_ING_EXTRA.Value = mEntidad.BENEF_OBT_ING_EXTRA
        Me.txtBENEF_CAMB_EMP_X_CURSO.Value = mEntidad.BENEF_CAMB_EMP_X_CURSO
        Me.txtBENEF_TRAB_CTA_PROPIA.Value = mEntidad.BENEF_TRAB_CTA_PROPIA
        Me.txtBENEF_OTRO.Text = mEntidad.BENEF_OTRO
        Me.txtRAZON_NO_BENEFICIO.Text = mEntidad.RAZON_NO_BENEFICIO
        Me.txtOCUACT_TRABAJA.Value = mEntidad.OCUACT_TRABAJA
        Me.txtOCUACT_ESTUDIA.Value = mEntidad.OCUACT_ESTUDIA
        Me.txtOCUACT_DESOCUPADO.Value = mEntidad.OCUACT_DESOCUPADO
        Me.txtOCUACT_OFICIO_HOGAR.Value = mEntidad.OCUACT_OFICIO_HOGAR
        Me.txtOCUACT_BUSCA_TRABAJO.Value = mEntidad.OCUACT_BUSCA_TRABAJO
        Me.txtOCUACT_OTRA.Text = mEntidad.OCUACT_OTRA
        Me.ddlTIPO_EMPLEOID_TIPO_EMPLEO.Recuperar()
        Me.ddlTIPO_EMPLEOID_TIPO_EMPLEO.SelectedValue = mEntidad.ID_TIPO_EMPLEO
        Me.txtSECTOR_EMPLEO.Value = mEntidad.SECTOR_EMPLEO
        Me.txtTRABAJO_ANTERIOR.Text = mEntidad.TRABAJO_ANTERIOR
        Me.txtRECIBE_INGRESOS.Value = mEntidad.RECIBE_INGRESOS
        Me.txtMANERA_OBT_ING_TRABAJO.Value = mEntidad.MANERA_OBT_ING_TRABAJO
        Me.txtMANERA_OBT_ING_AYUDA_FAM.Value = mEntidad.MANERA_OBT_ING_AYUDA_FAM
        Me.txtMANERA_OBT_ING_REMESA.Value = mEntidad.MANERA_OBT_ING_REMESA
        Me.txtMANERA_OBT_ING_PENSION.Value = mEntidad.MANERA_OBT_ING_PENSION
        Me.txtMANERA_OBT_ING_OTRO.Text = mEntidad.MANERA_OBT_ING_OTRO
        Me.txtEXPFOR_PROMOCION_EMPLEO.Value = mEntidad.EXPFOR_PROMOCION_EMPLEO
        Me.txtEXPFOR_CAMBIAR_EMPLEO.Value = mEntidad.EXPFOR_CAMBIAR_EMPLEO
        Me.txtEXPFOR_OBTENER_EMPLEO.Value = mEntidad.EXPFOR_OBTENER_EMPLEO
        Me.txtEXPFOR_TRABAJAR_CTA_PROPIA.Value = mEntidad.EXPFOR_TRABAJAR_CTA_PROPIA
        Me.txtEXPFOR_INGRESOS_EXTRAS.Value = mEntidad.EXPFOR_INGRESOS_EXTRAS
        Me.txtEXPFOR_NINGUNO.Value = mEntidad.EXPFOR_NINGUNO
        Me.txtEXPFOR_OTRO.Text = mEntidad.EXPFOR_OTRO
        Me.txtCURSO_REL_TRAB_ACTUAL.Value = mEntidad.CURSO_REL_TRAB_ACTUAL
        Me.txtCURSO_REL_TRAB_NUEVO.Value = mEntidad.CURSO_REL_TRAB_NUEVO
        Me.txtNOMBRE_REFERENCIA.Text = mEntidad.NOMBRE_REFERENCIA
        Me.ddlREFERENCIAID_REFERENCIA.Recuperar()
        Me.ddlREFERENCIAID_REFERENCIA.SelectedValue = mEntidad.ID_REFERENCIA
        Me.txtDIRECCION_REFERENCIA.Text = mEntidad.DIRECCION_REFERENCIA
        Me.txtDEPARTAMENTO_REFERENCIA.Text = mEntidad.DEPARTAMENTO_REFERENCIA
        Me.txtMUNICIPIO_REFERENCIA.Text = mEntidad.MUNICIPIO_REFERENCIA
        Me.txtTELEFONO_REFERENCIA.Text = mEntidad.TELEFONO_REFERENCIA
        Me.txtMOVIL_REFERENCIA.Text = mEntidad.MOVIL_REFERENCIA
        Me.txtEMAIL_REFERENCIA.Text = mEntidad.EMAIL_REFERENCIA
        Me.txtSUGERENCIAS.Text = mEntidad.SUGERENCIAS
        Me.txtUSERID.Text = mEntidad.USERID
        Me.deLASTUPDATE.Value = mEntidad.LASTUPDATE
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.Enabled = edicion
        Me.ddlPARTICIPANTEID_PARTICIPANTE.Enabled = edicion
        Me.ddlACCION_FORMATIVAID_ACCION_FORMATIVA.Enabled = edicion
        Me.ddlESTADO_SOLICITUDID_ESTADO_SOLICITUD.Enabled = edicion
        Me.ddlTIPO_SOLICITUDID_TIPO_SOLICITUD.Enabled = edicion
        Me.ddlPAISID_PAIS.Enabled = edicion
        Me.ddlESTADO_CIVILID_ESTADO_CIVIL.Enabled = edicion
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Enabled = edicion
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Enabled = edicion
        Me.ddlEDUC_LEE_ESCRIBEID_LEE_ESCRIBE.Enabled = edicion
        Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.Enabled = edicion
        Me.ddlTIEMPO_DEJO_ESTUDIARID_TIEMPO_DEJO_ESTUDIAR.Enabled = edicion
        Me.ddlTIPO_EMPLEOID_TIPO_EMPLEO.Enabled = edicion
        Me.ddlREFERENCIAID_REFERENCIA.Enabled = edicion
        Me.deFECHA_PRESENTACION.Enabled = edicion
        Me.txtNOMBRES.Enabled = edicion
        Me.txtAPELLIDOS.Enabled = edicion
        Me.txtDUI.Enabled = edicion
        Me.txtTIPO_DOCTO.Enabled = edicion
        Me.txtNUM_DOCTO.Enabled = edicion
        Me.txtNIT.Enabled = edicion
        Me.txtISSS.Enabled = edicion
        Me.txtDEPARTAMENTO_NAC.Enabled = edicion
        Me.txtMUNICIPIO_NAC.Enabled = edicion
        Me.deFECHA_NACIMIENTO.Enabled = edicion
        Me.txtGENERO.Enabled = edicion
        Me.txtEDAD.Enabled = edicion
        Me.txtMIEMBROS_GRUPO_FAMILIAR.Enabled = edicion
        Me.txtES_JEFE_HOGAR.Enabled = edicion
        Me.txtTIENE_HIJOS.Enabled = edicion
        Me.txtNO_DE_HIJOS.Enabled = edicion
        Me.txtSE_DEDICA_ALGUNA_PROFESION.Enabled = edicion
        Me.txtPROFESION_OFICIO.Enabled = edicion
        Me.txtDIRECCION.Enabled = edicion
        Me.txtTELEFONO.Enabled = edicion
        Me.txtMOVIL.Enabled = edicion
        Me.txtEMAIL.Enabled = edicion
        Me.txtCON_DISCAPACIDAD.Enabled = edicion
        Me.txtDISC_OTRA.Enabled = edicion
        Me.txtOTRA_EDUCACION_FORMAL.Enabled = edicion
        Me.txtTITULO_CERTIFICADO_OBTENIDO.Enabled = edicion
        Me.txtESTUDIA_ACTUALMENTE.Enabled = edicion
        Me.txtRECIBIO_CURSO_ANTERIOR.Enabled = edicion
        Me.txtBENEF_PROM_EMP_ACT.Enabled = edicion
        Me.txtBENEF_OBT_EMPLEO.Enabled = edicion
        Me.txtBENEF_OBT_ING_EXTRA.Enabled = edicion
        Me.txtBENEF_CAMB_EMP_X_CURSO.Enabled = edicion
        Me.txtBENEF_TRAB_CTA_PROPIA.Enabled = edicion
        Me.txtBENEF_OTRO.Enabled = edicion
        Me.txtRAZON_NO_BENEFICIO.Enabled = edicion
        Me.txtOCUACT_TRABAJA.Enabled = edicion
        Me.txtOCUACT_ESTUDIA.Enabled = edicion
        Me.txtOCUACT_DESOCUPADO.Enabled = edicion
        Me.txtOCUACT_OFICIO_HOGAR.Enabled = edicion
        Me.txtOCUACT_BUSCA_TRABAJO.Enabled = edicion
        Me.txtOCUACT_OTRA.Enabled = edicion
        Me.txtSECTOR_EMPLEO.Enabled = edicion
        Me.txtTRABAJO_ANTERIOR.Enabled = edicion
        Me.txtRECIBE_INGRESOS.Enabled = edicion
        Me.txtMANERA_OBT_ING_TRABAJO.Enabled = edicion
        Me.txtMANERA_OBT_ING_AYUDA_FAM.Enabled = edicion
        Me.txtMANERA_OBT_ING_REMESA.Enabled = edicion
        Me.txtMANERA_OBT_ING_PENSION.Enabled = edicion
        Me.txtMANERA_OBT_ING_OTRO.Enabled = edicion
        Me.txtEXPFOR_PROMOCION_EMPLEO.Enabled = edicion
        Me.txtEXPFOR_CAMBIAR_EMPLEO.Enabled = edicion
        Me.txtEXPFOR_OBTENER_EMPLEO.Enabled = edicion
        Me.txtEXPFOR_TRABAJAR_CTA_PROPIA.Enabled = edicion
        Me.txtEXPFOR_INGRESOS_EXTRAS.Enabled = edicion
        Me.txtEXPFOR_NINGUNO.Enabled = edicion
        Me.txtEXPFOR_OTRO.Enabled = edicion
        Me.txtCURSO_REL_TRAB_ACTUAL.Enabled = edicion
        Me.txtCURSO_REL_TRAB_NUEVO.Enabled = edicion
        Me.txtNOMBRE_REFERENCIA.Enabled = edicion
        Me.txtDIRECCION_REFERENCIA.Enabled = edicion
        Me.txtDEPARTAMENTO_REFERENCIA.Enabled = edicion
        Me.txtMUNICIPIO_REFERENCIA.Enabled = edicion
        Me.txtTELEFONO_REFERENCIA.Enabled = edicion
        Me.txtMOVIL_REFERENCIA.Enabled = edicion
        Me.txtEMAIL_REFERENCIA.Enabled = edicion
        Me.txtSUGERENCIAS.Enabled = edicion
        Me.txtUSERID.Enabled = edicion
        Me.deLASTUPDATE.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.Recuperar()
        Me.ddlPARTICIPANTEID_PARTICIPANTE.Recuperar()
        Me.ddlACCION_FORMATIVAID_ACCION_FORMATIVA.Recuperar()
        Me.ddlESTADO_SOLICITUDID_ESTADO_SOLICITUD.Recuperar()
        Me.ddlTIPO_SOLICITUDID_TIPO_SOLICITUD.Recuperar()
        Me.ddlPAISID_PAIS.Recuperar()
        Me.ddlESTADO_CIVILID_ESTADO_CIVIL.Recuperar()
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Recuperar()
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Recuperar(Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue)
        Me.ddlEDUC_LEE_ESCRIBEID_LEE_ESCRIBE.Recuperar()
        Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.Recuperar()
        Me.ddlTIEMPO_DEJO_ESTUDIARID_TIEMPO_DEJO_ESTUDIAR.Recuperar()
        Me.ddlTIPO_EMPLEOID_TIPO_EMPLEO.Recuperar()
        Me.ddlREFERENCIAID_REFERENCIA.Recuperar()
        Me.deFECHA_PRESENTACION.Value = Nothing
        Me.txtNOMBRES.Text = ""
        Me.txtAPELLIDOS.Text = ""
        Me.txtDUI.Text = ""
        Me.txtTIPO_DOCTO.Value = Nothing
        Me.txtNUM_DOCTO.Text = ""
        Me.txtNIT.Text = ""
        Me.txtISSS.Text = ""
        Me.txtDEPARTAMENTO_NAC.Text = ""
        Me.txtMUNICIPIO_NAC.Text = ""
        Me.deFECHA_NACIMIENTO.Value = Nothing
        Me.txtGENERO.Text = ""
        Me.txtEDAD.Value = Nothing
        Me.txtMIEMBROS_GRUPO_FAMILIAR.Value = Nothing
        Me.txtES_JEFE_HOGAR.Value = Nothing
        Me.txtTIENE_HIJOS.Value = Nothing
        Me.txtNO_DE_HIJOS.Value = Nothing
        Me.txtSE_DEDICA_ALGUNA_PROFESION.Value = Nothing
        Me.txtPROFESION_OFICIO.Text = ""
        Me.txtDIRECCION.Text = ""
        Me.txtTELEFONO.Text = ""
        Me.txtMOVIL.Text = ""
        Me.txtEMAIL.Text = ""
        Me.txtCON_DISCAPACIDAD.Value = Nothing
        Me.txtDISC_OTRA.Text = ""
        Me.txtOTRA_EDUCACION_FORMAL.Text = ""
        Me.txtTITULO_CERTIFICADO_OBTENIDO.Text = ""
        Me.txtESTUDIA_ACTUALMENTE.Value = Nothing
        Me.txtRECIBIO_CURSO_ANTERIOR.Text = ""
        Me.txtBENEF_PROM_EMP_ACT.Value = Nothing
        Me.txtBENEF_OBT_EMPLEO.Value = Nothing
        Me.txtBENEF_OBT_ING_EXTRA.Value = Nothing
        Me.txtBENEF_CAMB_EMP_X_CURSO.Value = Nothing
        Me.txtBENEF_TRAB_CTA_PROPIA.Value = Nothing
        Me.txtBENEF_OTRO.Text = ""
        Me.txtRAZON_NO_BENEFICIO.Text = ""
        Me.txtOCUACT_TRABAJA.Value = Nothing
        Me.txtOCUACT_ESTUDIA.Value = Nothing
        Me.txtOCUACT_DESOCUPADO.Value = Nothing
        Me.txtOCUACT_OFICIO_HOGAR.Value = Nothing
        Me.txtOCUACT_BUSCA_TRABAJO.Value = Nothing
        Me.txtOCUACT_OTRA.Text = ""
        Me.txtSECTOR_EMPLEO.Value = Nothing
        Me.txtTRABAJO_ANTERIOR.Text = ""
        Me.txtRECIBE_INGRESOS.Value = Nothing
        Me.txtMANERA_OBT_ING_TRABAJO.Value = Nothing
        Me.txtMANERA_OBT_ING_AYUDA_FAM.Value = Nothing
        Me.txtMANERA_OBT_ING_REMESA.Value = Nothing
        Me.txtMANERA_OBT_ING_PENSION.Value = Nothing
        Me.txtMANERA_OBT_ING_OTRO.Text = ""
        Me.txtEXPFOR_PROMOCION_EMPLEO.Value = Nothing
        Me.txtEXPFOR_CAMBIAR_EMPLEO.Value = Nothing
        Me.txtEXPFOR_OBTENER_EMPLEO.Value = Nothing
        Me.txtEXPFOR_TRABAJAR_CTA_PROPIA.Value = Nothing
        Me.txtEXPFOR_INGRESOS_EXTRAS.Value = Nothing
        Me.txtEXPFOR_NINGUNO.Value = Nothing
        Me.txtEXPFOR_OTRO.Text = ""
        Me.txtCURSO_REL_TRAB_ACTUAL.Value = Nothing
        Me.txtCURSO_REL_TRAB_NUEVO.Value = Nothing
        Me.txtNOMBRE_REFERENCIA.Text = ""
        Me.txtDIRECCION_REFERENCIA.Text = ""
        Me.txtDEPARTAMENTO_REFERENCIA.Text = ""
        Me.txtMUNICIPIO_REFERENCIA.Text = ""
        Me.txtTELEFONO_REFERENCIA.Text = ""
        Me.txtMOVIL_REFERENCIA.Text = ""
        Me.txtEMAIL_REFERENCIA.Text = ""
        Me.txtSUGERENCIAS.Text = ""
        Me.txtUSERID.Text = ""
        Me.deLASTUPDATE.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla SOLIC_INSCRIPCION_AF_HIST
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New SOLIC_INSCRIPCION_AF_HIST
        If Me._nuevo Then
            mEntidad.ID_SOLICITUD_HIST = 0
        Else
            mEntidad.ID_SOLICITUD_HIST = CInt(Me.txtID_SOLICITUD_HIST.Text)
        End If
        mEntidad.ID_SOLICITUD = Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.SelectedValue
        mEntidad.FECHA_PRESENTACION = Me.deFECHA_PRESENTACION.Value
        mEntidad.ID_PARTICIPANTE = Me.ddlPARTICIPANTEID_PARTICIPANTE.SelectedValue
        mEntidad.ID_ACCION_FORMATIVA = Me.ddlACCION_FORMATIVAID_ACCION_FORMATIVA.SelectedValue
        mEntidad.ID_ESTADO_SOLICITUD = Me.ddlESTADO_SOLICITUDID_ESTADO_SOLICITUD.SelectedValue
        mEntidad.NOMBRES = Me.txtNOMBRES.Text
        mEntidad.APELLIDOS = Me.txtAPELLIDOS.Text
        mEntidad.DUI = Me.txtDUI.Text
        mEntidad.TIPO_DOCTO = Me.txtTIPO_DOCTO.Value
        mEntidad.NUM_DOCTO = Me.txtNUM_DOCTO.Text
        mEntidad.NIT = Me.txtNIT.Text
        mEntidad.ISSS = Me.txtISSS.Text
        mEntidad.ID_TIPO_SOLICITUD = Me.ddlTIPO_SOLICITUDID_TIPO_SOLICITUD.SelectedValue
        mEntidad.ID_PAIS = Me.ddlPAISID_PAIS.SelectedValue
        mEntidad.DEPARTAMENTO_NAC = Me.txtDEPARTAMENTO_NAC.Text
        mEntidad.MUNICIPIO_NAC = Me.txtMUNICIPIO_NAC.Text
        mEntidad.FECHA_NACIMIENTO = Me.deFECHA_NACIMIENTO.Value
        mEntidad.GENERO = Me.txtGENERO.Text
        mEntidad.EDAD = Me.txtEDAD.Value
        mEntidad.MIEMBROS_GRUPO_FAMILIAR = Me.txtMIEMBROS_GRUPO_FAMILIAR.Value
        mEntidad.ID_ESTADO_CIVIL = Me.ddlESTADO_CIVILID_ESTADO_CIVIL.SelectedValue
        mEntidad.ES_JEFE_HOGAR = Me.txtES_JEFE_HOGAR.Value
        mEntidad.TIENE_HIJOS = Me.txtTIENE_HIJOS.Value
        mEntidad.NO_DE_HIJOS = Me.txtNO_DE_HIJOS.Value
        mEntidad.SE_DEDICA_ALGUNA_PROFESION = Me.txtSE_DEDICA_ALGUNA_PROFESION.Value
        mEntidad.PROFESION_OFICIO = Me.txtPROFESION_OFICIO.Text
        mEntidad.DIRECCION = Me.txtDIRECCION.Text
        mEntidad.CODIGO_DEPARTAMENTO = Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue
        mEntidad.CODIGO_MUNICIPIO = Me.ddlMUNICIPIOCODIGO_MUNICIPIO.SelectedValue
        mEntidad.TELEFONO = Me.txtTELEFONO.Text
        mEntidad.MOVIL = Me.txtMOVIL.Text
        mEntidad.EMAIL = Me.txtEMAIL.Text
        mEntidad.CON_DISCAPACIDAD = Me.txtCON_DISCAPACIDAD.Value
        mEntidad.DISC_OTRA = Me.txtDISC_OTRA.Text
        mEntidad.ID_LEE_ESCRIBE = Me.ddlEDUC_LEE_ESCRIBEID_LEE_ESCRIBE.SelectedValue
        mEntidad.ID_NIVEL_ACADEMICO = Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.SelectedValue
        mEntidad.OTRA_EDUCACION_FORMAL = Me.txtOTRA_EDUCACION_FORMAL.Text
        mEntidad.TITULO_CERTIFICADO_OBTENIDO = Me.txtTITULO_CERTIFICADO_OBTENIDO.Text
        mEntidad.ESTUDIA_ACTUALMENTE = Me.txtESTUDIA_ACTUALMENTE.Value
        mEntidad.ID_TIEMPO_DEJO_ESTUDIAR = Me.ddlTIEMPO_DEJO_ESTUDIARID_TIEMPO_DEJO_ESTUDIAR.SelectedValue
        mEntidad.RECIBIO_CURSO_ANTERIOR = Me.txtRECIBIO_CURSO_ANTERIOR.Text
        mEntidad.BENEF_PROM_EMP_ACT = Me.txtBENEF_PROM_EMP_ACT.Value
        mEntidad.BENEF_OBT_EMPLEO = Me.txtBENEF_OBT_EMPLEO.Value
        mEntidad.BENEF_OBT_ING_EXTRA = Me.txtBENEF_OBT_ING_EXTRA.Value
        mEntidad.BENEF_CAMB_EMP_X_CURSO = Me.txtBENEF_CAMB_EMP_X_CURSO.Value
        mEntidad.BENEF_TRAB_CTA_PROPIA = Me.txtBENEF_TRAB_CTA_PROPIA.Value
        mEntidad.BENEF_OTRO = Me.txtBENEF_OTRO.Text
        mEntidad.RAZON_NO_BENEFICIO = Me.txtRAZON_NO_BENEFICIO.Text
        mEntidad.OCUACT_TRABAJA = Me.txtOCUACT_TRABAJA.Value
        mEntidad.OCUACT_ESTUDIA = Me.txtOCUACT_ESTUDIA.Value
        mEntidad.OCUACT_DESOCUPADO = Me.txtOCUACT_DESOCUPADO.Value
        mEntidad.OCUACT_OFICIO_HOGAR = Me.txtOCUACT_OFICIO_HOGAR.Value
        mEntidad.OCUACT_BUSCA_TRABAJO = Me.txtOCUACT_BUSCA_TRABAJO.Value
        mEntidad.OCUACT_OTRA = Me.txtOCUACT_OTRA.Text
        mEntidad.ID_TIPO_EMPLEO = Me.ddlTIPO_EMPLEOID_TIPO_EMPLEO.SelectedValue
        mEntidad.SECTOR_EMPLEO = Me.txtSECTOR_EMPLEO.Value
        mEntidad.TRABAJO_ANTERIOR = Me.txtTRABAJO_ANTERIOR.Text
        mEntidad.RECIBE_INGRESOS = Me.txtRECIBE_INGRESOS.Value
        mEntidad.MANERA_OBT_ING_TRABAJO = Me.txtMANERA_OBT_ING_TRABAJO.Value
        mEntidad.MANERA_OBT_ING_AYUDA_FAM = Me.txtMANERA_OBT_ING_AYUDA_FAM.Value
        mEntidad.MANERA_OBT_ING_REMESA = Me.txtMANERA_OBT_ING_REMESA.Value
        mEntidad.MANERA_OBT_ING_PENSION = Me.txtMANERA_OBT_ING_PENSION.Value
        mEntidad.MANERA_OBT_ING_OTRO = Me.txtMANERA_OBT_ING_OTRO.Text
        mEntidad.EXPFOR_PROMOCION_EMPLEO = Me.txtEXPFOR_PROMOCION_EMPLEO.Value
        mEntidad.EXPFOR_CAMBIAR_EMPLEO = Me.txtEXPFOR_CAMBIAR_EMPLEO.Value
        mEntidad.EXPFOR_OBTENER_EMPLEO = Me.txtEXPFOR_OBTENER_EMPLEO.Value
        mEntidad.EXPFOR_TRABAJAR_CTA_PROPIA = Me.txtEXPFOR_TRABAJAR_CTA_PROPIA.Value
        mEntidad.EXPFOR_INGRESOS_EXTRAS = Me.txtEXPFOR_INGRESOS_EXTRAS.Value
        mEntidad.EXPFOR_NINGUNO = Me.txtEXPFOR_NINGUNO.Value
        mEntidad.EXPFOR_OTRO = Me.txtEXPFOR_OTRO.Text
        mEntidad.CURSO_REL_TRAB_ACTUAL = Me.txtCURSO_REL_TRAB_ACTUAL.Value
        mEntidad.CURSO_REL_TRAB_NUEVO = Me.txtCURSO_REL_TRAB_NUEVO.Value
        mEntidad.NOMBRE_REFERENCIA = Me.txtNOMBRE_REFERENCIA.Text
        mEntidad.ID_REFERENCIA = Me.ddlREFERENCIAID_REFERENCIA.SelectedValue
        mEntidad.DIRECCION_REFERENCIA = Me.txtDIRECCION_REFERENCIA.Text
        mEntidad.DEPARTAMENTO_REFERENCIA = Me.txtDEPARTAMENTO_REFERENCIA.Text
        mEntidad.MUNICIPIO_REFERENCIA = Me.txtMUNICIPIO_REFERENCIA.Text
        mEntidad.TELEFONO_REFERENCIA = Me.txtTELEFONO_REFERENCIA.Text
        mEntidad.MOVIL_REFERENCIA = Me.txtMOVIL_REFERENCIA.Text
        mEntidad.EMAIL_REFERENCIA = Me.txtEMAIL_REFERENCIA.Text
        mEntidad.SUGERENCIAS = Me.txtSUGERENCIAS.Text
        mEntidad.USERID = Me.txtUSERID.Text
        mEntidad.LASTUPDATE = Me.deLASTUPDATE.Value

        If mComponente.ActualizarSOLIC_INSCRIPCION_AF_HIST(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_SOLICITUD_HIST.Text = mEntidad.ID_SOLICITUD_HIST.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
