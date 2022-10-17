Imports SGAFP.BL
Imports SGAFP.EL
Imports System.Collections.Generic
Imports Microsoft.ApplicationBlocks.ExceptionManagement

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleSOLICITUD_INSCRIPCION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SOLICITUD_INSCRIPCION_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSOLICITUD_INSCRIPCION_AF
    Inherits ucBase

#Region "Propiedades"

    Public Property ID_PROVEEDOR() As Decimal
        Get
            If Me.ID_PROVEEDORTextBox.Text <> "" Then Return Me.ID_PROVEEDORTextBox.Text
            Return -1
        End Get
        Set(ByVal value As Decimal)
            Me.ID_PROVEEDORTextBox.Text = value
        End Set
    End Property

    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            If Me.ID_ACCION_FORMATIVATextBox.Text <> "" Then Return Me.ID_ACCION_FORMATIVATextBox.Text
            Return -1
        End Get
        Set(ByVal value As Decimal)
            Me.ID_ACCION_FORMATIVATextBox.Text = value
        End Set
    End Property

    Private _ID_SOLICITUD As Decimal
    Public Property ID_SOLICITUD() As Decimal
        Get
            Return Me.txtID_SOLICITUD.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_SOLICITUD = Value
            Me.txtID_SOLICITUD.Text = CStr(Value)
            If Me._ID_SOLICITUD > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cSOLICITUD_INSCRIPCION_AF
    Private mEntidad As SOLICITUD_INSCRIPCION_AF
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
        If Not IsPostBack Then
            If Not Session("listaCursosRecibidos") Is Nothing Then Session("listaCursosRecibidos") = Nothing
        End If
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_SOLICITUD") Is Nothing Then Me._ID_SOLICITUD = Me.ViewState("ID_SOLICITUD")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New SOLICITUD_INSCRIPCION_AF
        mEntidad.ID_SOLICITUD = ID_SOLICITUD

        If mComponente.ObtenerSOLICITUD_INSCRIPCION_AF(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_SOLICITUD.Text = mEntidad.ID_SOLICITUD.ToString()
        Me.txtFECHA_PRESENTACION.Text = IIf(Not mEntidad.FECHA_PRESENTACION = Nothing, Format(mEntidad.FECHA_PRESENTACION, "dd/MM/yyyy"), "")
        Me.txtID_PARTICIPANTE.Text = mEntidad.ID_PARTICIPANTE.ToString()
        Me.txtID_PARTICIPANTE.Enabled = False
        Me.ID_ACCION_FORMATIVATextBox.Text = mEntidad.ID_ACCION_FORMATIVA
        Me.ID_ESTADO_SOLICITUDTextBox.Text = mEntidad.ID_ESTADO_SOLICITUD
        'Me.NUMERO_DOCUMENTOTextBox.Text = mEntidad.NUMERO_DOCUMENTO
        Me.ID_TIPO_SOLICITUDTextBox.Text = mEntidad.ID_TIPO_SOLICITUD
        'Me.txtNIT_EMPRESA.Text = mEntidad.NIT_EMPRESA
        'Me.txtNOMBRE_EMPRESA.Text = mEntidad.NOMBRE_EMPRESA
        'Me.txtCARGO.Text = mEntidad.CARGO
        'Me.ddlEMPRESAS1.Recuperar()
        'Me.ddlEMPRESAS1.SelectedValue = mEntidad.NUMERO_PATRONAL
        Me.NOMBRESTextBox.Text = mEntidad.NOMBRES
        Me.APELLIDOSTextBox.Text = mEntidad.APELLIDOS
        'Me.LUGAR_NACIMIENTOTextBox.Text = mEntidad.LUGAR_NACIMIENTO

        Me.CODIGO_DEPARTAMENTODropDownList_CascadingDropDown.SelectedValue = mEntidad.CODIGO_DEPARTAMENTO
        Me.CODIGO_DEPARTAMENTODropDownList.DataBind()
        Me.CODIGO_MUNICIPIODropDownList_CascadingDropDown.SelectedValue = mEntidad.CODIGO_MUNICIPIO
        Me.CODIGO_MUNICIPIODropDownList.DataBind()

        'Me.ZONARadioButtonList.SelectedValue = mEntidad.ZONA
        Me.TELEFONOTextBox.Text = mEntidad.TELEFONO
        Me.MOVILTextBox.Text = mEntidad.MOVIL
        'Me.FAXTextBox.Text = mEntidad.FAX
        Me.EMAILTextBox.Text = mEntidad.EMAIL
        Me.NITTextBox.Text = mEntidad.NIT
        Me.ISSSTextBox.Text = mEntidad.ISSS
        'Me.CIUODropDownList.Recuperar()
        Me.CIUODropDownList.DataBind()
        'Me.CIUODropDownList.SelectedValue = mEntidad.CIUO
        Me.EDADTextBox.Text = mEntidad.EDAD
        Me.DEPARTAMENTO_NACDropDownListCascadingDropDown.SelectedValue = mEntidad.DEPARTAMENTO_NAC
        Me.DEPARTAMENTO_NACDropDownList.DataBind()
        Me.MUNICIPIO_NACDropDownListCascadingDropDown.SelectedValue = mEntidad.MUNICIPIO_NAC
        Me.MUNICIPIO_NACDropDownList.DataBind()

        Me.FECHA_NACIMIENTOTextBox.Text = IIf(Not mEntidad.FECHA_NACIMIENTO = Nothing, Format(mEntidad.FECHA_NACIMIENTO, "dd/MM/yyyy"), "")
        Me.DUITextBox.Text = mEntidad.DUI
        Me.GENERORadioButtonList.SelectedValue = mEntidad.GENERO
        Me.DIRECCIONTextBox.Text = mEntidad.DIRECCION
        Me.PROFESION_OFICIOTextBox.Text = mEntidad.PROFESION_OFICIO
        'Me.ESTADO_CIVILRadioButtonList.SelectedValue = mEntidad.ESTADO_CIVIL
        'Me.NOMBRE_FAMILIARTextBox.Text = mEntidad.NOMBRE_FAMILIAR
        'Me.PARENTESCOTextBox.Text = mEntidad.PARENTESCO
        'Me.DIRECCION_FAMILIARTextBox.Text = mEntidad.DIRECCION_FAMILIAR
        'Me.TELEFONO_FAMILIARTextBox.Text = mEntidad.TELEFONO_FAMILIAR

        Me.OCUACT_TRABAJACheckBox.Checked = mEntidad.OCUACT_TRABAJA
        Me.OCUACT_ESTUDIACheckBox.Checked = mEntidad.OCUACT_ESTUDIA
        Me.OCUACT_DESOCUPADOCheckBox.Checked = mEntidad.OCUACT_DESOCUPADO
        Me.OCUACT_OFICIO_HOGARCheckBox.Checked = mEntidad.OCUACT_OFICIO_HOGAR

        'Me.TIPTRA_EMPLEADO_EMPRESACheckBox.Checked = mEntidad.TIPTRA_EMPLEADO_EMPRESA
        'Me.TIPTRA_EMPRESA_PROPIACheckBox.Checked = mEntidad.TIPTRA_EMPRESA_PROPIA
        'Me.TIPTRA_EVENTUALCheckBox.Checked = mEntidad.TIPTRA_EVENTUAL
        'Me.TIPTRA_MEDIO_TIEMPOCheckBox.Checked = mEntidad.TIPTRA_MEDIO_TIEMPO
        'Me.TIPTRA_INDEPENDIENTECheckBox.Checked = mEntidad.TIPTRA_INDEPENDIENTE

        'Me.RTC_OCUPACION_EMPRESACheckBox.Checked = mEntidad.RTC_OCUPACION_EMPRESA
        'Me.RTC_EMPRESA_PROPIACheckBox.Checked = mEntidad.RTC_PROPIA_EMPRESA
        'Me.RTC_EVENTUALCheckBox.Checked = mEntidad.RTC_TRABAJO_EVENTUAL
        'Me.RTC_TRABAJO_MEDIO_TIEMPOCheckBox.Checked = mEntidad.RTC_TRABAJO_MEDIO_TIEMPO
        'Me.RTC_INDEPENDIENTECheckBox.Checked = mEntidad.RTC_INDEPENDIENTE

        'Me.RTC_NO_OCUPACION_EMPRESACheckBox.Checked = mEntidad.RTC_NO_OCUPACION_EMPRESA
        'Me.RTC_NO_PROPIA_EMPRESACheckBox.Checked = mEntidad.RTC_NO_PROPIA_EMPRESA
        'Me.RTC_NO_TRABAJO_EVENTUALCheckBox.Checked = mEntidad.RTC_NO_TRABAJO_EVENTUAL
        'Me.RTC_NO_TRABAJO_MEDIO_TIEMPOCheckBox.Checked = mEntidad.RTC_NO_TRABAJO_MEDIO_TIEMPO
        'Me.RTC_NO_INDEPENDIENTECheckBox.Checked = mEntidad.RTC_NO_INDEPENDIENTE

        'Me.NIVEL_ACADEMICORadioButtonList.SelectedValue = mEntidad.NIVEL_ACADEMICO

        Me.TITULO_CERTIFICADO_OBTENIDOTextBox.Text = mEntidad.TITULO_CERTIFICADO_OBTENIDO
        'Me.TIEMPO_DEJO_ESTUDIARRadioButtonList1.SelectedValue = mEntidad.TIEMPO_DEJO_ESTUDIAR

        Me.RECIBIO_CURSO_ANTERIORRadioButtonList.SelectedValue = mEntidad.RECIBIO_CURSO_ANTERIOR
        If mEntidad.RECIBIO_CURSO_ANTERIOR = "S" Then
            'Me.ucListaSOLIC_CURSOS_RECIBIDOS1.CargarDatosPorSOLICITUD_INSCRIPCION_AF(mEntidad.ID_SOLICITUD)
            Me.CargarCursosRecibidos()
            Me.gvCursosRecibidos.Visible = True
        Else
            Me.gvCursosRecibidos.Visible = False
        End If

        'Me.OBTUVO_BENEFICIO_CURSORadioButtonList.SelectedValue = mEntidad.OBTUVO_BENEFICIOS_CURSO

        Me.BENEF_PROM_EMP_ACTCheckBox.Checked = mEntidad.BENEF_PROM_EMP_ACT
        Me.BENEF_OBT_EMPCheckBox.Checked = mEntidad.BENEF_OBT_EMPLEO
        Me.BENEF_OBT_ING_EXTCheckBox.Checked = mEntidad.BENEF_OBT_ING_EXTRA
        Me.BENEF_CAMB_EMP_X_CURSOCheckBox2.Checked = mEntidad.BENEF_CAMB_EMP_X_CURSO
        Me.BENEF_TRAB_CTA_PROPIACheckBox.Checked = mEntidad.BENEF_TRAB_CTA_PROPIA
        Me.BENEF_OTROTextBox.Text = mEntidad.BENEF_OTRO
        Me.RAZON_NO_BENEFICIOTextBox.Text = mEntidad.RAZON_NO_BENEFICIO
        'Me.TRABAJA_ACTUALMENTERadioButtonList.SelectedValue = mEntidad.TRABAJA_ACTUALMENTE

        'If mEntidad.TRABAJA_ACTUALMENTE = "S" Then
        '    Me.trTrabajoActual.Visible = True
        '    Me.ucVistaDetalleSOLIC_EMPLEO_ACTUAL1.ID_SOLICITUD = mEntidad.ID_SOLICITUD
        '    Dim listSOLIC_EMPLEO_ACTUAL As listaSOLIC_EMPLEO_ACTUAL = (New cSOLIC_EMPLEO_ACTUAL).ObtenerListaPorSOLICITUD_INSCRIPCION_AF(mEntidad.ID_SOLICITUD)
        '    If listSOLIC_EMPLEO_ACTUAL.Count = 0 Then
        '        'No se ha guardado el Empleo Actual, pero se ha puesto que si trabaja actualmente
        '        Me.ucVistaDetalleSOLIC_EMPLEO_ACTUAL1.ID_EMPLEO_ACTUAL = 0
        '    Else
        '        'Recuperar Empleo Actual
        '        Me.ucVistaDetalleSOLIC_EMPLEO_ACTUAL1.ID_EMPLEO_ACTUAL = listSOLIC_EMPLEO_ACTUAL(0).ID_EMPLEO_ACTUAL
        '    End If
        'Else
        '    Me.trTrabajoActual.Visible = False
        '    Me.ucVistaDetalleSOLIC_EMPLEO_ACTUAL1.ID_EMPLEO_ACTUAL = 0
        'End If

        Me.TRABAJO_ANTERIORRadioButtonList.SelectedValue = mEntidad.TRABAJO_ANTERIOR

        If mEntidad.TRABAJO_ANTERIOR = "S" Then
            Me.trTrabajoAnterior.Visible = True
            Me.ucVistaDetalleSOLIC_EMPLEO_ANTERIOR1.ID_SOLICITUD = mEntidad.ID_SOLICITUD
            Dim listSOLIC_EMPLEO_ANTERIOR As listaSOLIC_EMPLEO_ANTERIOR = (New cSOLIC_EMPLEO_ANTERIOR).ObtenerListaPorSOLICITUD_INSCRIPCION_AF(mEntidad.ID_SOLICITUD)
            If listSOLIC_EMPLEO_ANTERIOR.Count = 0 Then
                'No se ha guardado el Empleo Acterior, pero se ha puesto que si trabajo anteriormente
                Me.ucVistaDetalleSOLIC_EMPLEO_ANTERIOR1.ID_EMPLEO_ANT = 0
            Else
                'Recuperar Empleo Anterior
                Me.ucVistaDetalleSOLIC_EMPLEO_ANTERIOR1.ID_EMPLEO_ANT = listSOLIC_EMPLEO_ANTERIOR(0).ID_EMPLEO_ANT
            End If
        Else
            Me.trTrabajoAnterior.Visible = False
            Me.ucVistaDetalleSOLIC_EMPLEO_ANTERIOR1.ID_EMPLEO_ANT = 0
        End If

        Me.EXPFOR_PROMOCION_EMPLEOCheckBox.Checked = mEntidad.EXPFOR_PROMOCION_EMPLEO
        Me.EXPFOR_CAMBIAR_EMPLEOCheckBox.Checked = mEntidad.EXPFOR_CAMBIAR_EMPLEO
        Me.EXPFOR_OBTENER_EMPLEOCheckBox.Checked = mEntidad.EXPFOR_OBTENER_EMPLEO
        Me.EXPFOR_TRABAJAR_CTA_PROPIACheckBox.Checked = mEntidad.EXPFOR_TRABAJAR_CTA_PROPIA
        Me.EXPFOR_INGRESOS_EXTRASCheckBox.Checked = mEntidad.EXPFOR_INGRESOS_EXTRAS
        Me.EXPFOR_OTROTextBox.Text = mEntidad.EXPFOR_OTRO
        'Me.INGRESO_MENSUAL_INDIVIDUALRadioButtonList.SelectedValue = mEntidad.INGRESO_MENSUAL_INDIVIDUAL
        'Me.INGRESO_MENSUAL_FAMILIARRadioButtonList.SelectedValue = mEntidad.INGRESO_MENSUAL_FAMILIAR
        Me.MIEMBROS_GRUPO_FAMILIARTextBox.Text = mEntidad.MIEMBROS_GRUPO_FAMILIAR
        Me.SUGERENCIASTextBox.Text = mEntidad.SUGERENCIAS
        'Me.LUGAR_PRESENTACIONTextBox.Text = mEntidad.LUGAR_PRESENTACION
        'Me.ID_PROVEEDORTextBox.Text = mEntidad.ID_PROVEEDOR_AF

        Me.ibtnBuscarParticipante.Visible = False

        Me.CollapsiblePanelExtenderSeccion1.Collapsed = False
        Me.CollapsiblePanelExtenderSeccion2.Collapsed = False
        Me.CollapsiblePanelExtenderSeccion3.Collapsed = False
        Me.CollapsiblePanelExtenderSeccion4.Collapsed = False
        Me.CollapsiblePanelExtenderSeccion5.Collapsed = False
        Me.CollapsiblePanelExtenderSeccion6.Collapsed = False

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        'Me.txtID_PARTICIPANTE.Enabled = edicion
        'Me.ddlACCION_FORMATIVA1.Enabled = edicion
        'Me.ddlESTADO_SOLICITUD1.Enabled = edicion
        'Me.ddlCONTROL_DOCUMENTOS1.Enabled = edicion
        'Me.ddlTIPO_SOLICITUD1.Enabled = edicion
        'Me.ddlEMPRESAS1.Enabled = edicion
        Me.CODIGO_DEPARTAMENTODropDownList.Enabled = edicion
        'Me.CODIGO_DEPARTAMENTODropDownList_CascadingDropDown.Enabled = edicion
        Me.CODIGO_MUNICIPIODropDownList.Enabled = edicion
        'Me.CODIGO_MUNICIPIODropDownList_CascadingDropDown.Enabled = edicion
        'Me.ddlREGION1.Enabled = edicion
        Me.CIUODropDownList.Enabled = edicion
        Me.NIVEL_ACADEMICORadioButtonList.Enabled = edicion
        'Me.ID_PROVEEDORTextBox.Enabled = edicion
        Me.txtFECHA_PRESENTACION.Enabled = edicion
        Me.ibtnCalendarFECHA_PRESENTACION.Visible = edicion
        'Me.NIT_EMPRESA.Enabled = edicion
        'Me.NOMBRE_EMPRESA.Enabled = edicion
        'Me.CARGO.Enabled = edicion
        Me.NOMBRESTextBox.Enabled = edicion
        Me.APELLIDOSTextBox.Enabled = edicion
        Me.LUGAR_NACIMIENTOTextBox.Enabled = edicion
        Me.ZONARadioButtonList.Enabled = edicion
        Me.TELEFONOTextBox.Enabled = edicion
        Me.MOVILTextBox.Enabled = edicion
        Me.FAXTextBox.Enabled = edicion
        Me.EMAILTextBox.Enabled = edicion
        Me.NITTextBox.Enabled = edicion
        Me.ISSSTextBox.Enabled = edicion
        'Me.EDADTextBox.Enabled = edicion
        Me.DEPARTAMENTO_NACDropDownList.Enabled = edicion
        'Me.DEPARTAMENTO_NACDropDownListCascadingDropDown.Enabled = edicion
        Me.MUNICIPIO_NACDropDownList.Enabled = edicion
        'Me.MUNICIPIO_NACDropDownListCascadingDropDown.Enabled = edicion
        Me.FECHA_NACIMIENTOTextBox.Enabled = edicion
        Me.ibtnCalendarFECHA_NACIMIENTO.Visible = edicion

        Me.DUITextBox.Enabled = edicion
        Me.GENERORadioButtonList.Enabled = edicion
        Me.DIRECCIONTextBox.Enabled = edicion
        Me.PROFESION_OFICIOTextBox.Enabled = edicion
        Me.ESTADO_CIVILRadioButtonList.Enabled = edicion
        Me.NOMBRE_FAMILIARTextBox.Enabled = edicion
        Me.PARENTESCOTextBox.Enabled = edicion
        Me.DIRECCION_FAMILIARTextBox.Enabled = edicion
        Me.TELEFONO_FAMILIARTextBox.Enabled = edicion
        Me.OCUACT_TRABAJACheckBox.Enabled = edicion
        Me.OCUACT_ESTUDIACheckBox.Enabled = edicion
        Me.OCUACT_DESOCUPADOCheckBox.Enabled = edicion
        Me.OCUACT_OFICIO_HOGARCheckBox.Enabled = edicion
        Me.TIPTRA_EMPLEADO_EMPRESACheckBox.Enabled = edicion
        Me.TIPTRA_EMPRESA_PROPIACheckBox.Enabled = edicion
        Me.TIPTRA_EVENTUALCheckBox.Enabled = edicion
        Me.TIPTRA_MEDIO_TIEMPOCheckBox.Enabled = edicion
        Me.TIPTRA_INDEPENDIENTECheckBox.Enabled = edicion
        Me.RTC_OCUPACION_EMPRESACheckBox.Enabled = edicion
        Me.RTC_EMPRESA_PROPIACheckBox.Enabled = edicion
        Me.RTC_EVENTUALCheckBox.Enabled = edicion
        Me.RTC_TRABAJO_MEDIO_TIEMPOCheckBox.Enabled = edicion
        Me.RTC_INDEPENDIENTECheckBox.Enabled = edicion
        Me.RTC_NO_OCUPACION_EMPRESACheckBox.Enabled = edicion
        Me.RTC_NO_PROPIA_EMPRESACheckBox.Enabled = edicion
        Me.RTC_NO_TRABAJO_EVENTUALCheckBox.Enabled = edicion
        Me.RTC_NO_TRABAJO_MEDIO_TIEMPOCheckBox.Enabled = edicion
        Me.RTC_NO_INDEPENDIENTECheckBox.Enabled = edicion
        Me.TITULO_CERTIFICADO_OBTENIDOTextBox.Enabled = edicion
        Me.TIEMPO_DEJO_ESTUDIARRadioButtonList1.Enabled = edicion

        Me.RECIBIO_CURSO_ANTERIORRadioButtonList.Enabled = edicion
        Me.gvCursosRecibidos.Enabled = edicion

        Me.OBTUVO_BENEFICIO_CURSORadioButtonList.Enabled = edicion
        Me.BENEF_PROM_EMP_ACTCheckBox.Enabled = edicion
        Me.BENEF_OBT_EMPCheckBox.Enabled = edicion
        Me.BENEF_OBT_ING_EXTCheckBox.Enabled = edicion
        Me.BENEF_CAMB_EMP_X_CURSOCheckBox2.Enabled = edicion
        Me.BENEF_TRAB_CTA_PROPIACheckBox.Enabled = edicion
        Me.BENEF_OTROTextBox.Enabled = edicion
        Me.RAZON_NO_BENEFICIOTextBox.Enabled = edicion
        Me.TRABAJA_ACTUALMENTERadioButtonList.Enabled = edicion
        Me.TRABAJO_ANTERIORRadioButtonList.Enabled = edicion
        Me.EXPFOR_PROMOCION_EMPLEOCheckBox.Enabled = edicion
        Me.EXPFOR_CAMBIAR_EMPLEOCheckBox.Enabled = edicion
        Me.EXPFOR_OBTENER_EMPLEOCheckBox.Enabled = edicion
        Me.EXPFOR_TRABAJAR_CTA_PROPIACheckBox.Enabled = edicion
        Me.EXPFOR_INGRESOS_EXTRASCheckBox.Enabled = edicion
        Me.EXPFOR_OTROTextBox.Enabled = edicion
        Me.INGRESO_MENSUAL_INDIVIDUALRadioButtonList.Enabled = edicion
        Me.INGRESO_MENSUAL_FAMILIARRadioButtonList.Enabled = edicion
        Me.MIEMBROS_GRUPO_FAMILIARTextBox.Enabled = edicion
        Me.SUGERENCIASTextBox.Enabled = edicion
        Me.LUGAR_PRESENTACIONTextBox.Enabled = edicion

        Me.ucVistaDetalleSOLIC_EMPLEO_ACTUAL1.Enabled = edicion
        Me.ucVistaDetalleSOLIC_EMPLEO_ANTERIOR1.Enabled = edicion

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtID_PARTICIPANTE.Text = ""
        Me.txtID_PARTICIPANTE.Enabled = True
        Me.ID_ESTADO_SOLICITUDTextBox.Text = SGAFP.EL.Enumeradores.EstadoSolicitud.EnEsperaDeAprobacion
        Me.NUMERO_DOCUMENTOTextBox.Text = "-1"
        'Me.ID_TIPO_SOLICITUDTextBox.Text = SGAFP.EL.Enumeradores.TipoSolicitud.HabilTecnicoPermanente
        'TODO Quitar comentario
        Me.CODIGO_DEPARTAMENTODropDownList_CascadingDropDown.SelectedValue = "15"
        Me.CODIGO_DEPARTAMENTODropDownList.DataBind()
        Me.CODIGO_MUNICIPIODropDownList_CascadingDropDown.SelectedValue = "1"
        Me.CODIGO_MUNICIPIODropDownList.DataBind()
        Me.CIUODropDownList.DataBind()
        Me.NIVEL_ACADEMICORadioButtonList.DataBind()
        Me.txtFECHA_PRESENTACION.Text = Now.ToString("dd/MM/yyyy")
        Me.NOMBRESTextBox.Text = ""
        Me.APELLIDOSTextBox.Text = ""
        Me.LUGAR_NACIMIENTOTextBox.Text = ""
        Me.ZONARadioButtonList.SelectedIndex = -1
        Me.TELEFONO_FAMILIARTextBox.Text = ""
        Me.MOVILTextBox.Text = ""
        Me.FAXTextBox.Text = ""
        Me.EMAILTextBox.Text = ""
        Me.NIVEL_ACADEMICORadioButtonList.SelectedIndex = -1
        Me.ISSSTextBox.Text = ""
        Me.EDADTextBox.Text = ""
        Me.DEPARTAMENTO_NACDropDownList.SelectedIndex = -1
        Me.MUNICIPIO_NACDropDownList.SelectedIndex = -1
        Me.FECHA_NACIMIENTOTextBox.Text = ""
        Me.DUITextBox.Text = ""
        Me.GENERORadioButtonList.SelectedIndex = -1
        Me.DIRECCION_FAMILIARTextBox.Text = ""
        Me.PROFESION_OFICIOTextBox.Text = ""
        Me.ESTADO_CIVILRadioButtonList.SelectedIndex = -1
        Me.NOMBRE_FAMILIARTextBox.Text = ""
        Me.PARENTESCOTextBox.Text = ""
        Me.DIRECCION_FAMILIARTextBox.Text = ""
        Me.TELEFONO_FAMILIARTextBox.Text = ""
        Me.OCUACT_TRABAJACheckBox.Checked = False
        Me.OCUACT_ESTUDIACheckBox.Checked = False
        Me.OCUACT_DESOCUPADOCheckBox.Checked = False
        Me.OCUACT_OFICIO_HOGARCheckBox.Checked = False
        Me.TIPTRA_EMPLEADO_EMPRESACheckBox.Checked = False
        Me.TIPTRA_EMPRESA_PROPIACheckBox.Checked = False
        Me.TIPTRA_EVENTUALCheckBox.Checked = False
        Me.TIPTRA_MEDIO_TIEMPOCheckBox.Checked = False
        Me.TIPTRA_INDEPENDIENTECheckBox.Checked = False
        Me.RTC_OCUPACION_EMPRESACheckBox.Checked = False
        Me.RTC_EMPRESA_PROPIACheckBox.Checked = False
        Me.RTC_EVENTUALCheckBox.Checked = False
        Me.RTC_TRABAJO_MEDIO_TIEMPOCheckBox.Checked = False
        Me.RTC_INDEPENDIENTECheckBox.Checked = False
        Me.RTC_NO_OCUPACION_EMPRESACheckBox.Checked = False
        Me.RTC_NO_PROPIA_EMPRESACheckBox.Checked = False
        Me.RTC_NO_TRABAJO_EVENTUALCheckBox.Checked = False
        Me.RTC_NO_TRABAJO_MEDIO_TIEMPOCheckBox.Checked = False
        Me.RTC_NO_INDEPENDIENTECheckBox.Checked = False
        Me.TITULO_CERTIFICADO_OBTENIDOTextBox.Text = ""

        Me.TIEMPO_DEJO_ESTUDIARRadioButtonList1.SelectedValue = 0

        Me.RECIBIO_CURSO_ANTERIORRadioButtonList.SelectedIndex = -1

        Me.gvCursosRecibidos.Visible = False

        Me.OBTUVO_BENEFICIO_CURSORadioButtonList.SelectedIndex = -1
        Me.BENEF_PROM_EMP_ACTCheckBox.Checked = False
        Me.BENEF_OBT_EMPCheckBox.Checked = False
        Me.BENEF_OBT_ING_EXTCheckBox.Checked = False
        Me.BENEF_CAMB_EMP_X_CURSOCheckBox2.Checked = False
        Me.BENEF_TRAB_CTA_PROPIACheckBox.Checked = False
        Me.BENEF_OTROTextBox.Text = ""
        Me.RAZON_NO_BENEFICIOTextBox.Text = ""
        Me.TRABAJA_ACTUALMENTERadioButtonList.SelectedIndex = -1
        Me.TRABAJO_ANTERIORRadioButtonList.SelectedIndex = -1
        Me.EXPFOR_PROMOCION_EMPLEOCheckBox.Checked = False
        Me.EXPFOR_CAMBIAR_EMPLEOCheckBox.Checked = False
        Me.EXPFOR_OBTENER_EMPLEOCheckBox.Checked = False
        Me.EXPFOR_TRABAJAR_CTA_PROPIACheckBox.Checked = False
        Me.EXPFOR_INGRESOS_EXTRASCheckBox.Checked = False
        Me.EXPFOR_OTROTextBox.Text = ""
        Me.INGRESO_MENSUAL_INDIVIDUALRadioButtonList.SelectedIndex = -1
        Me.INGRESO_MENSUAL_FAMILIARRadioButtonList.SelectedIndex = -1
        Me.MIEMBROS_GRUPO_FAMILIARTextBox.Text = ""
        Me.SUGERENCIASTextBox.Text = ""
        Me.LUGAR_PRESENTACIONTextBox.Text = ""
        Me.ibtnBuscarParticipante.Visible = True
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String

        Dim sError As New String("")

        If Me.DUITextBox.Text.Length = 0 And Me.NITTextBox.Text.Length = 0 Then
            sError = "Debe de ingresar DUI o NIT para ingresar la Solicitud. Por favor verifique."
            Me.AsignarMensaje(sError, True)
            Return sError
        End If

        If Me.DUITextBox.Text.Length > 0 And Me.DUITextBox.Text.Length < 9 Then
            sError = "DUI no válido. Por favor verifique."
            Me.AsignarMensaje(sError, True)
            Return sError
        End If

        If Me.NITTextBox.Text.Length > 0 And Me.NITTextBox.Text.Length < 14 Then
            sError = "NIT no válido. Por favor verifique."
            Me.AsignarMensaje(sError, True)
            Return sError
        End If

        If Me.CODIGO_DEPARTAMENTODropDownList.SelectedValue = -1 Then
            sError = "Departamento de Residencia es Requerido. Por favor verifique."
            Me.AsignarMensaje(sError, True)
            Return sError
        End If

        If Me.CODIGO_MUNICIPIODropDownList.SelectedValue = -1 Then
            sError = "Municipio de Residencia es Requerido. Por favor verifique."
            Me.AsignarMensaje(sError, True)
            Return sError
        End If

        If Not Me.EXPFOR_CAMBIAR_EMPLEOCheckBox.Checked _
            And Not Me.EXPFOR_INGRESOS_EXTRASCheckBox.Checked _
            And Not Me.EXPFOR_OBTENER_EMPLEOCheckBox.Checked _
            And Not Me.EXPFOR_PROMOCION_EMPLEOCheckBox.Checked _
            And Not Me.EXPFOR_TRABAJAR_CTA_PROPIACheckBox.Checked _
            And Me.EXPFOR_OTROTextBox.Text = "" Then
            sError = "Expectativas de Formacion es Requerido. Por favor verifique."
            Me.AsignarMensaje(sError, True)
            Return sError
        End If

        Dim alDatos As New ArrayList
        mEntidad = New SOLICITUD_INSCRIPCION_AF
        If Me._nuevo Then
            mEntidad.ID_SOLICITUD = 0
        Else
            mEntidad.ID_SOLICITUD = CInt(Me.txtID_SOLICITUD.Text)
        End If
        If Me.txtFECHA_PRESENTACION.Text <> "" Then mEntidad.FECHA_PRESENTACION = System.DateTime.Parse(Me.txtFECHA_PRESENTACION.Text, New System.Globalization.CultureInfo("fr-FR", True), _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        If Me.txtID_PARTICIPANTE.Text <> "" Then
            mEntidad.ID_PARTICIPANTE = Val(Me.txtID_PARTICIPANTE.Text)
        End If

        mEntidad.ID_ACCION_FORMATIVA = Me.ID_ACCION_FORMATIVA
        mEntidad.ID_ESTADO_SOLICITUD = Val(Me.ID_ESTADO_SOLICITUDTextBox.Text)
        'mEntidad.NUMERO_DOCUMENTO = Val(Me.NUMERO_DOCUMENTOTextBox.Text)
        mEntidad.ID_TIPO_SOLICITUD = Val(Me.ID_TIPO_SOLICITUDTextBox.Text)
        'mEntidad.NIT_EMPRESA = Me.NITTextBox.Text
        'mEntidad.NOMBRE_EMPRESA = Me.txtNOMBRE_EMPRES.Text
        'mEntidad.CARGO = Me.txtCARGO.Text
        'mEntidad.NUMERO_PATRONAL = Me.ddlEMPRESAS1.SelectedValue
        mEntidad.NOMBRES = Utilerias.QuitarAcentos(Me.NOMBRESTextBox.Text.ToUpper)
        mEntidad.APELLIDOS = Utilerias.QuitarAcentos(Me.APELLIDOSTextBox.Text.ToUpper)
        'mEntidad.LUGAR_NACIMIENTO = Me.LUGAR_NACIMIENTOTextBox.Text.ToUpper
        mEntidad.CODIGO_DEPARTAMENTO = Me.CODIGO_DEPARTAMENTODropDownList.SelectedValue
        mEntidad.CODIGO_MUNICIPIO = Me.CODIGO_MUNICIPIODropDownList.SelectedValue
        'mEntidad.CODIGO_REGION = "01"
        'mEntidad.ZONA = Me.ZONARadioButtonList.SelectedValue
        mEntidad.TELEFONO = Me.TELEFONOTextBox.Text
        mEntidad.MOVIL = Me.MOVILTextBox.Text
        'mEntidad.FAX = Me.FAXTextBox.Text
        mEntidad.EMAIL = Me.EMAILTextBox.Text
        mEntidad.NIT = Me.NITTextBox.Text
        mEntidad.ISSS = Me.ISSSTextBox.Text
        'mEntidad.CIUO = Me.CIUODropDownList.SelectedValue
        mEntidad.EDAD = Val(Me.EDADTextBox.Text)
        mEntidad.DEPARTAMENTO_NAC = Me.DEPARTAMENTO_NACDropDownList.SelectedValue
        mEntidad.MUNICIPIO_NAC = Me.MUNICIPIO_NACDropDownList.SelectedValue
        If Me.FECHA_NACIMIENTOTextBox.Text <> "" Then mEntidad.FECHA_NACIMIENTO = System.DateTime.Parse(Me.FECHA_NACIMIENTOTextBox.Text, New System.Globalization.CultureInfo("fr-FR", True), _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If mEntidad.FECHA_NACIMIENTO > Now Then
            sError = "Fecha de Nacimiento inválida. Por favor verifique."
            Me.AsignarMensaje(sError, True)
            Return sError
        End If

        mEntidad.DUI = Me.DUITextBox.Text
        mEntidad.GENERO = Me.GENERORadioButtonList.SelectedValue
        mEntidad.DIRECCION = Me.DIRECCIONTextBox.Text.ToUpper
        mEntidad.PROFESION_OFICIO = Me.PROFESION_OFICIOTextBox.Text.ToUpper
        'mEntidad.ESTADO_CIVIL = Me.ESTADO_CIVILRadioButtonList.SelectedValue

        'mEntidad.NOMBRE_FAMILIAR = Me.NOMBRE_FAMILIARTextBox.Text.ToUpper
        'mEntidad.PARENTESCO = Me.PARENTESCOTextBox.Text.ToUpper
        'mEntidad.DIRECCION_FAMILIAR = Me.DIRECCION_FAMILIARTextBox.Text.ToUpper
        'mEntidad.TELEFONO_FAMILIAR = Me.TELEFONO_FAMILIARTextBox.Text

        mEntidad.OCUACT_TRABAJA = IIf(Me.OCUACT_TRABAJACheckBox.Checked, 1, 0)
        mEntidad.OCUACT_ESTUDIA = IIf(Me.OCUACT_ESTUDIACheckBox.Checked, 1, 0)
        mEntidad.OCUACT_DESOCUPADO = IIf(Me.OCUACT_DESOCUPADOCheckBox.Checked, 1, 0)
        mEntidad.OCUACT_OFICIO_HOGAR = IIf(Me.OCUACT_OFICIO_HOGARCheckBox.Checked, 1, 0)

        'mEntidad.TIPTRA_EMPLEADO_EMPRESA = IIf(Me.TIPTRA_EMPLEADO_EMPRESACheckBox.Checked, 1, 0)
        'mEntidad.TIPTRA_EMPRESA_PROPIA = IIf(Me.TIPTRA_EMPRESA_PROPIACheckBox.Checked, 1, 0)
        'mEntidad.TIPTRA_EVENTUAL = IIf(Me.TIPTRA_EVENTUALCheckBox.Checked, 1, 0)
        'mEntidad.TIPTRA_MEDIO_TIEMPO = IIf(Me.TIPTRA_MEDIO_TIEMPOCheckBox.Checked, 1, 0)
        'mEntidad.TIPTRA_INDEPENDIENTE = IIf(Me.TIPTRA_INDEPENDIENTECheckBox.Checked, 1, 0)
        'mEntidad.RTC_OCUPACION_EMPRESA = IIf(Me.RTC_OCUPACION_EMPRESACheckBox.Checked, 1, 0)
        'mEntidad.RTC_PROPIA_EMPRESA = IIf(Me.RTC_EMPRESA_PROPIACheckBox.Checked, 1, 0)
        'mEntidad.RTC_TRABAJO_EVENTUAL = IIf(Me.RTC_EVENTUALCheckBox.Checked, 1, 0)
        'mEntidad.RTC_TRABAJO_MEDIO_TIEMPO = IIf(Me.RTC_TRABAJO_MEDIO_TIEMPOCheckBox.Checked, 1, 0)
        'mEntidad.RTC_INDEPENDIENTE = IIf(Me.RTC_INDEPENDIENTECheckBox.Checked, 1, 0)
        'mEntidad.RTC_NO_OCUPACION_EMPRESA = IIf(Me.RTC_NO_OCUPACION_EMPRESACheckBox.Checked, 1, 0)
        'mEntidad.RTC_NO_PROPIA_EMPRESA = IIf(Me.RTC_NO_PROPIA_EMPRESACheckBox.Checked, 1, 0)
        'mEntidad.RTC_NO_TRABAJO_EVENTUAL = IIf(Me.RTC_NO_TRABAJO_EVENTUALCheckBox.Checked, 1, 0)
        'mEntidad.RTC_NO_TRABAJO_MEDIO_TIEMPO = IIf(Me.RTC_NO_TRABAJO_MEDIO_TIEMPOCheckBox.Checked, 1, 0)
        'mEntidad.RTC_NO_INDEPENDIENTE = IIf(Me.RTC_NO_INDEPENDIENTECheckBox.Checked, 1, 0)

        'mEntidad.NIVEL_ACADEMICO = Me.NIVEL_ACADEMICORadioButtonList.SelectedValue
        mEntidad.TITULO_CERTIFICADO_OBTENIDO = Me.TITULO_CERTIFICADO_OBTENIDOTextBox.Text.ToUpper
        'mEntidad.TIEMPO_DEJO_ESTUDIAR = Me.TIEMPO_DEJO_ESTUDIARRadioButtonList1.SelectedValue
        mEntidad.RECIBIO_CURSO_ANTERIOR = Me.RECIBIO_CURSO_ANTERIORRadioButtonList.SelectedValue
        'mEntidad.OBTUVO_BENEFICIOS_CURSO = Me.OBTUVO_BENEFICIO_CURSORadioButtonList.SelectedValue

        mEntidad.BENEF_PROM_EMP_ACT = IIf(Me.BENEF_PROM_EMP_ACTCheckBox.Checked, 1, 0)
        mEntidad.BENEF_OBT_EMPLEO = IIf(Me.BENEF_OBT_EMPCheckBox.Checked, 1, 0)
        mEntidad.BENEF_OBT_ING_EXTRA = IIf(Me.BENEF_OBT_ING_EXTCheckBox.Checked, 1, 0)
        mEntidad.BENEF_CAMB_EMP_X_CURSO = IIf(Me.BENEF_CAMB_EMP_X_CURSOCheckBox2.Checked, 1, 0)
        mEntidad.BENEF_TRAB_CTA_PROPIA = IIf(Me.BENEF_TRAB_CTA_PROPIACheckBox.Checked, 1, 0)

        mEntidad.BENEF_OTRO = Me.BENEF_OTROTextBox.Text
        mEntidad.RAZON_NO_BENEFICIO = Me.RAZON_NO_BENEFICIOTextBox.Text.ToUpper
        'mEntidad.TRABAJA_ACTUALMENTE = Me.TRABAJA_ACTUALMENTERadioButtonList.SelectedValue
        mEntidad.TRABAJO_ANTERIOR = Me.TRABAJO_ANTERIORRadioButtonList.SelectedValue

        mEntidad.EXPFOR_PROMOCION_EMPLEO = IIf(Me.EXPFOR_PROMOCION_EMPLEOCheckBox.Checked, 1, 0)
        mEntidad.EXPFOR_CAMBIAR_EMPLEO = IIf(Me.EXPFOR_CAMBIAR_EMPLEOCheckBox.Checked, 1, 0)
        mEntidad.EXPFOR_OBTENER_EMPLEO = IIf(Me.EXPFOR_OBTENER_EMPLEOCheckBox.Checked, 1, 0)
        mEntidad.EXPFOR_TRABAJAR_CTA_PROPIA = IIf(Me.EXPFOR_TRABAJAR_CTA_PROPIACheckBox.Checked, 1, 0)
        mEntidad.EXPFOR_INGRESOS_EXTRAS = IIf(Me.EXPFOR_INGRESOS_EXTRASCheckBox.Checked, 1, 0)

        mEntidad.EXPFOR_OTRO = Me.EXPFOR_OTROTextBox.Text.ToUpper
        'mEntidad.INGRESO_MENSUAL_INDIVIDUAL = Me.INGRESO_MENSUAL_INDIVIDUALRadioButtonList.SelectedValue
        'mEntidad.INGRESO_MENSUAL_FAMILIAR = Me.INGRESO_MENSUAL_FAMILIARRadioButtonList.SelectedValue
        mEntidad.MIEMBROS_GRUPO_FAMILIAR = Val(Me.MIEMBROS_GRUPO_FAMILIARTextBox.Text)
        mEntidad.SUGERENCIAS = Me.SUGERENCIASTextBox.Text.ToUpper
        'mEntidad.LUGAR_PRESENTACION = Me.LUGAR_PRESENTACIONTextBox.Text.ToUpper
        'mEntidad.ID_PROVEEDOR_AF = Me.ID_PROVEEDOR

        If mComponente.ActualizarSOLICITUD_INSCRIPCION_AF(mEntidad) <> 1 Then
            ExceptionManager.Publish(New Exception(mComponente.sError + vbCrLf + mComponente.sErrorTecnico))
            Me.AsignarMensaje("Error al Guardar registro." + vbCrLf + mComponente.sError, True, True)
            If Me.txtID_PARTICIPANTE.Text <> "" Then
                'Me.txtID_PARTICIPANTE.Text = ""
                Me.DUITextBox.Enabled = False
                Me.NITTextBox.Enabled = False
                Me.NOMBRESTextBox.Enabled = False
                Me.APELLIDOSTextBox.Enabled = False
                Me.DIRECCIONTextBox.Enabled = False
                Me.CODIGO_DEPARTAMENTODropDownList.Enabled = False
                Me.CODIGO_MUNICIPIODropDownList.Enabled = False
                Me.ibtnBuscarParticipante.Enabled = False
            End If
            Return "Error al Guardar registro."
        End If
        Me.txtID_SOLICITUD.Text = mEntidad.ID_SOLICITUD.ToString()
        Me.txtID_PARTICIPANTE.Text = mEntidad.ID_PARTICIPANTE.ToString()
        Me.EDADTextBox.Text = mEntidad.EDAD.ToString()
        Me.txtID_PARTICIPANTE.Enabled = False
        Me.RECIBIO_CURSO_ANTERIORRadioButtonList.SelectedValue = mEntidad.RECIBIO_CURSO_ANTERIOR

        If mEntidad.RECIBIO_CURSO_ANTERIOR = "S" Then
            If Me.GuardarCursosRecibidos() < 1 Then
                Return "Error al Guardar Cursos Recibidos."
            End If
            Me.CargarCursosRecibidos()
            Me.gvCursosRecibidos.Visible = True
        Else
            Dim listaCursos As listaSOLIC_CURSOS_RECIBIDOS = (New cSOLIC_CURSOS_RECIBIDOS).ObtenerListaPorSOLICITUD_INSCRIPCION_AF(mEntidad.ID_SOLICITUD)
            If Not listaCursos Is Nothing AndAlso listaCursos.Count > 0 Then
                For Each lCursoRecibido As SOLIC_CURSOS_RECIBIDOS In listaCursos
                    If (New cSOLIC_CURSOS_RECIBIDOS).EliminarSOLIC_CURSOS_RECIBIDOS(lCursoRecibido, TipoConcurrencia.Pesimistica) < 0 Then

                    End If
                Next
            End If
            Me.gvCursosRecibidos.Visible = False
        End If

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        'If mEntidad.TRABAJA_ACTUALMENTE = "S" Then
        '    Me.ucVistaDetalleSOLIC_EMPLEO_ACTUAL1.ID_SOLICITUD = mEntidad.ID_SOLICITUD
        '    Me.ucVistaDetalleSOLIC_EMPLEO_ACTUAL1.Actualizar()
        'Else
        '    Dim listaEmpleoActual As listaSOLIC_EMPLEO_ACTUAL = (New cSOLIC_EMPLEO_ACTUAL).ObtenerListaPorSOLICITUD_INSCRIPCION_AF(mEntidad.ID_SOLICITUD)
        '    If Not listaEmpleoActual Is Nothing AndAlso listaEmpleoActual.Count > 0 Then
        '        For Each lEmpleoActual As SOLIC_EMPLEO_ACTUAL In listaEmpleoActual
        '            If (New cSOLIC_EMPLEO_ACTUAL).EliminarSOLIC_EMPLEO_ACTUAL(lEmpleoActual, TipoConcurrencia.Pesimistica) < 0 Then

        '            End If
        '        Next
        '    End If
        'End If

        If mEntidad.TRABAJO_ANTERIOR = "S" Then
            Me.ucVistaDetalleSOLIC_EMPLEO_ANTERIOR1.ID_SOLICITUD = mEntidad.ID_SOLICITUD
            Me.ucVistaDetalleSOLIC_EMPLEO_ANTERIOR1.Actualizar()
        Else
            Dim listaEmpleoAnterior As listaSOLIC_EMPLEO_ANTERIOR = (New cSOLIC_EMPLEO_ANTERIOR).ObtenerListaPorSOLICITUD_INSCRIPCION_AF(mEntidad.ID_SOLICITUD)
            If Not listaEmpleoAnterior Is Nothing AndAlso listaEmpleoAnterior.Count > 0 Then
                For Each lEmpleoAnterior As SOLIC_EMPLEO_ANTERIOR In listaEmpleoAnterior
                    If (New cSOLIC_EMPLEO_ANTERIOR).EliminarSOLIC_EMPLEO_ANTERIOR(lEmpleoAnterior, TipoConcurrencia.Pesimistica) < 0 Then

                    End If
                Next
            End If
        End If


        Return ""
    End Function

    Protected Sub txtID_PARTICIPANTE_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtID_PARTICIPANTE.TextChanged
        If Me.txtID_PARTICIPANTE.Text = "" Then Return
        'Evento a ser invocado cuando se ingrese el ID DEL PARTICIPANTE DE LA SOLICITUD
        Me.ObtenerDatosParticipante(Convert.ToDecimal(Me.txtID_PARTICIPANTE.Text))
    End Sub

    Protected Sub ibtnBuscarParticipante_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibtnBuscarParticipante.Click
        Me.BuscarParticipante()
    End Sub

    Private Sub ObtenerDatosParticipante(ByVal idParticipante As Decimal)
        Dim lParticipante As PARTICIPANTE = (New cPARTICIPANTE).ObtenerPARTICIPANTE(idParticipante)
        If lParticipante Is Nothing Then
            Me.AsignarMensaje("Debe de Ingresar un ID de participante Válido", True, True)
            Return
        End If

        Me.txtID_PARTICIPANTE.Text = lParticipante.ID_PARTICIPANTE.ToString()
        NOMBRESTextBox.Text = lParticipante.NOMBRES
        APELLIDOSTextBox.Text = lParticipante.APELLIDOS
        FECHA_NACIMIENTOTextBox.Text = lParticipante.FECHA_NACIMIENTO.ToString("dd/MM/yyyy")
        DIRECCIONTextBox.Text = lParticipante.DIRECCION
        MunicipioTextBox.Text = lParticipante.CODIGO_MUNICIPIO
        MunicipioNacTextBox.Text = lParticipante.MUNICIPIO_NAC
        'ZONARadioButtonList.SelectedValue = lParticipante.ZONA
        TELEFONOTextBox.Text = lParticipante.TELEFONO
        MOVILTextBox.Text = lParticipante.MOVIL
        'FAXTextBox.Text = lParticipante.FAX
        EMAILTextBox.Text = lParticipante.EMAIL
        DUITextBox.Text = lParticipante.DUI
        ISSSTextBox.Text = lParticipante.ISSS
        NITTextBox.Text = lParticipante.NIT
        'LUGAR_NACIMIENTOTextBox.Text = lParticipante.LUGAR_NACIMIENTO
        GENERORadioButtonList.SelectedValue = lParticipante.GENERO
        PROFESION_OFICIOTextBox.Text = lParticipante.PROFESION_OFICIO
        'ESTADO_CIVILRadioButtonList.SelectedValue = lParticipante.ESTADO_CIVIL

        TITULO_CERTIFICADO_OBTENIDOTextBox.Text = lParticipante.TITULO_CERTIFICADO_OBTENIDO

        CODIGO_DEPARTAMENTODropDownList_CascadingDropDown.SelectedValue = lParticipante.CODIGO_DEPARTAMENTO
        CODIGO_MUNICIPIODropDownList_CascadingDropDown.SelectedValue = lParticipante.CODIGO_MUNICIPIO
        DEPARTAMENTO_NACDropDownListCascadingDropDown.SelectedValue = lParticipante.DEPARTAMENTO_NAC
        MUNICIPIO_NACDropDownListCascadingDropDown.SelectedValue = lParticipante.MUNICIPIO_NAC

        NOMBRE_FAMILIARTextBox.Focus()

    End Sub

    Protected Sub gvParticipantes_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvParticipantes.PageIndexChanging
        Me.gvParticipantes.PageIndex = e.NewPageIndex
        Me.BuscarParticipante()
    End Sub

    Protected Sub gvParticipantes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvParticipantes.SelectedIndexChanged
        Dim idParticipante As Decimal = Decimal.Parse(Me.gvParticipantes.Rows(Me.gvParticipantes.SelectedIndex).Cells(1).Text)
        Me.ObtenerDatosParticipante(idParticipante)
    End Sub

    Private Sub BuscarParticipante()

        If NOMBRESTextBox.Text <> "" OrElse APELLIDOSTextBox.Text <> "" OrElse DUITextBox.Text <> "" OrElse NITTextBox.Text <> "" Then
            Dim listaCriterios As New List(Of Criteria)
            If Me.NOMBRESTextBox.Text <> "" Then
                listaCriterios.Add(New Criteria("NOMBRES", "%*%", NOMBRESTextBox.Text.ToUpper(), "AND"))
            End If
            If Me.APELLIDOSTextBox.Text <> "" Then
                listaCriterios.Add(New Criteria("APELLIDOS", "%*%", APELLIDOSTextBox.Text.ToUpper(), "AND"))
            End If
            If Me.DUITextBox.Text <> "" Then
                listaCriterios.Add(New Criteria("DUI", "=", DUITextBox.Text, "AND"))
            End If
            If Me.NITTextBox.Text <> "" Then
                listaCriterios.Add(New Criteria("NIT", "=", NITTextBox.Text, "AND"))
            End If
            Dim listaPart As New listaPARTICIPANTE
            listaPart = (New cPARTICIPANTE).ObtenerListaPorBusqueda(New PARTICIPANTE, listaCriterios.ToArray(), "NOMBRES", "ASC")
            If listaPart.Count = 0 Then
                Me.AsignarMensaje("No existen datos con ese criterio", True, True)
                Return
            End If
            Me.gvParticipantes.SelectedIndex = -1
            Me.gvParticipantes.DataSource = listaPart
            Me.gvParticipantes.DataBind()
            Me.pmpParticipantes.Show()
        End If

    End Sub

    Protected Sub TRABAJA_ACTUALMENTERadioButtonList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TRABAJA_ACTUALMENTERadioButtonList.SelectedIndexChanged
        Me.trTrabajoActual.Visible = TRABAJA_ACTUALMENTERadioButtonList.SelectedValue = "S"
        Me.ucVistaDetalleSOLIC_EMPLEO_ACTUAL1.ID_SOLICITUD = Me.ID_SOLICITUD
        Dim listSOLIC_EMPLEO_ACTUAL As listaSOLIC_EMPLEO_ACTUAL = (New cSOLIC_EMPLEO_ACTUAL).ObtenerListaPorSOLICITUD_INSCRIPCION_AF(Me.ID_SOLICITUD)
        If listSOLIC_EMPLEO_ACTUAL.Count = 0 Then
            'No se ha guardado el Empleo Actual, pero se ha puesto que si trabaja actualmente
            Me.ucVistaDetalleSOLIC_EMPLEO_ACTUAL1.ID_EMPLEO_ACTUAL = 0
        Else
            'Recuperar Empleo Actual
            Me.ucVistaDetalleSOLIC_EMPLEO_ACTUAL1.ID_EMPLEO_ACTUAL = listSOLIC_EMPLEO_ACTUAL(0).ID_EMPLEO_ACTUAL
        End If
        If TRABAJA_ACTUALMENTERadioButtonList.SelectedValue = "S" Then
            'Me.ucVistaDetalleSOLIC_EMPLEO_ACTUAL1.SetearFocoControlInicial()
        Else
            Me.TRABAJA_ACTUALMENTERadioButtonList.Focus()
        End If

    End Sub

    Protected Sub TRABAJO_ANTERIORRadioButtonList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TRABAJO_ANTERIORRadioButtonList.SelectedIndexChanged
        Me.trTrabajoAnterior.Visible = TRABAJO_ANTERIORRadioButtonList.SelectedValue = "S"
        Me.ucVistaDetalleSOLIC_EMPLEO_ANTERIOR1.ID_SOLICITUD = Me.ID_SOLICITUD
        Dim listSOLIC_EMPLEO_ANTERIOR As listaSOLIC_EMPLEO_ANTERIOR = (New cSOLIC_EMPLEO_ANTERIOR).ObtenerListaPorSOLICITUD_INSCRIPCION_AF(Me.ID_SOLICITUD)
        If listSOLIC_EMPLEO_ANTERIOR.Count = 0 Then
            'No se ha guardado el Empleo Acterior, pero se ha puesto que si trabajo anteriormente
            Me.ucVistaDetalleSOLIC_EMPLEO_ANTERIOR1.ID_EMPLEO_ANT = 0
        Else
            'Recuperar Empleo Anterior
            Me.ucVistaDetalleSOLIC_EMPLEO_ANTERIOR1.ID_EMPLEO_ANT = listSOLIC_EMPLEO_ANTERIOR(0).ID_EMPLEO_ANT
        End If

        If TRABAJO_ANTERIORRadioButtonList.SelectedValue = "S" Then
            'Me.ucVistaDetalleSOLIC_EMPLEO_ANTERIOR1.SetearFocoControlInicial()
        Else
            Me.TRABAJO_ANTERIORRadioButtonList.Focus()
        End If

    End Sub

    'Protected Sub ucListaSOLIC_CURSOS_RECIBIDOS1_Editar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucListaSOLIC_CURSOS_RECIBIDOS1.Editar
    '    Me.ucListaSOLIC_CURSOS_RECIBIDOS1.CargarDatosPorSOLICITUD_INSCRIPCION_AF(Me.ID_SOLICITUD)
    'End Sub

    Protected Sub RECIBIO_CURSO_ANTERIORRadioButtonList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RECIBIO_CURSO_ANTERIORRadioButtonList.SelectedIndexChanged

        If RECIBIO_CURSO_ANTERIORRadioButtonList.SelectedValue = "S" Then
            Me.CargarCursosRecibidos()
            Me.gvCursosRecibidos.Visible = True
        Else
            Me.gvCursosRecibidos.Visible = False
        End If
    End Sub

    Private listaCursosRecibidos As listaSOLIC_CURSOS_RECIBIDOS = Nothing

    Private Sub CargarCursosRecibidos()
        listaCursosRecibidos = Me.Session("listaCursosRecibidos")
        Dim lCursosRecibidos As listaSOLIC_CURSOS_RECIBIDOS
        lCursosRecibidos = (New cSOLIC_CURSOS_RECIBIDOS).ObtenerListaPorSOLICITUD_INSCRIPCION_AF(Me.ID_SOLICITUD)
        If Not listaCursosRecibidos Is Nothing AndAlso listaCursosRecibidos.Count > 0 Then
            lCursosRecibidos.AddRange(listaCursosRecibidos)
        End If

        If lCursosRecibidos.Count = 0 Then
            lCursosRecibidos.Add(New SOLIC_CURSOS_RECIBIDOS)
            CursosRecibidosEmpty = True
        Else
            CursosRecibidosEmpty = False
        End If

        Me.gvCursosRecibidos.DataSource = lCursosRecibidos
        Me.gvCursosRecibidos.DataBind()
    End Sub

    Protected Sub gvCursosRecibidos_RowCancelingEdit(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCancelEditEventArgs) Handles gvCursosRecibidos.RowCancelingEdit
        Me.gvCursosRecibidos.EditIndex = -1
        Me.CargarCursosRecibidos()
    End Sub

    Protected Sub gvCursosRecibidos_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvCursosRecibidos.RowCommand
        If e.CommandName = "Agregar" Then
            AgregarCursoRecibido()
        End If
    End Sub

    Private Property CursosRecibidosEmpty() As Boolean
        Get
            If ViewState("CursosRecibidosEmpty") Is Nothing Then Return False
            Return ViewState("CursosRecibidosEmpty")
        End Get
        Set(ByVal value As Boolean)
            ViewState("CursosRecibidosEmpty") = value
        End Set
    End Property

    Protected Sub gvCursosRecibidos_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvCursosRecibidos.RowCreated
        If CursosRecibidosEmpty And e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Visible = False
            e.Row.Controls.Clear()
        End If
    End Sub

    Protected Sub gvCursosRecibidos_RowDeleting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles gvCursosRecibidos.RowDeleting
        If Me.EliminarCursoRecibido(e.RowIndex) <> -1 Then
            Me.CargarCursosRecibidos()
        End If
    End Sub

    Protected Sub gvCursosRecibidos_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles gvCursosRecibidos.RowEditing
        Me.gvCursosRecibidos.EditIndex = e.NewEditIndex
        Me.CargarCursosRecibidos()
    End Sub

    Protected Sub gvCursosRecibidos_RowUpdating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewUpdateEventArgs) Handles gvCursosRecibidos.RowUpdating
        If Me.ActualizarCursoRecibido(e.RowIndex) <> -1 Then
            Me.CargarCursosRecibidos()
        End If
    End Sub

    Private Function ActualizarCursoRecibido(ByVal RowIndex As Integer) As Integer
        Page.Validate("CursosRecibidos")
        If Not Page.IsValid Then Return -1

        listaCursosRecibidos = Me.Session("listaCursosRecibidos")

        Dim ID_CURSO_RECIBIDO As String = CType(gvCursosRecibidos.Rows(RowIndex).FindControl("Label_ID_CURSO_RECIBIDO"), Label).Text
        Dim NOMBRE_CURSO As String = CType(gvCursosRecibidos.Rows(RowIndex).FindControl("TextBox_NOMBRE_CURSO1"), TextBox).Text
        Dim INSTITUCION_CURSO As String = CType(gvCursosRecibidos.Rows(RowIndex).FindControl("TextBox_INSTITUCION_CURSO1"), TextBox).Text
        Dim ANIO As String = CType(gvCursosRecibidos.Rows(RowIndex).FindControl("TextBox_ANIO1"), TextBox).Text
        Dim APOYO_INSAFORP As String = CType(gvCursosRecibidos.Rows(RowIndex).FindControl("ddlAPOYO_INSAFORP2"), DropDownList).SelectedValue.ToString()

        If Me.ID_SOLICITUD <> 0 Then
            Dim lCursoRecibido As New SOLIC_CURSOS_RECIBIDOS
            lCursoRecibido.ID_CURSO_RECIBIDO = ID_CURSO_RECIBIDO
            lCursoRecibido.ID_SOLICITUD = Me.ID_SOLICITUD
            lCursoRecibido.ANIO = ANIO
            'lCursoRecibido.INSTITUCION_CURSO = INSTITUCION_CURSO
            lCursoRecibido.NOMBRE_CURSO = NOMBRE_CURSO
            lCursoRecibido.APOYO_INSAFORP = APOYO_INSAFORP
            If (New cSOLIC_CURSOS_RECIBIDOS).ActualizarSOLIC_CURSOS_RECIBIDOS(lCursoRecibido) < 1 Then

            End If
        Else
            Dim lCursoRecibido As New SOLIC_CURSOS_RECIBIDOS
            lCursoRecibido = listaCursosRecibidos(RowIndex)
            lCursoRecibido.ANIO = ANIO
            'lCursoRecibido.INSTITUCION_CURSO = INSTITUCION_CURSO
            lCursoRecibido.NOMBRE_CURSO = NOMBRE_CURSO
            lCursoRecibido.APOYO_INSAFORP = APOYO_INSAFORP

            Me.Session("listaCursosRecibidos") = listaCursosRecibidos

        End If

        Me.gvCursosRecibidos.EditIndex = -1

        Return 1

    End Function

    Private Function AgregarCursoRecibido() As Integer
        Page.Validate("AgregarCursoRecibido")
        If Not Page.IsValid Then Return -1

        listaCursosRecibidos = Me.Session("listaCursosRecibidos")

        Dim NOMBRE_CURSO As String = CType(gvCursosRecibidos.FooterRow.FindControl("NOMBRE_CURSOTextBox"), TextBox).Text
        Dim INSTITUCION_CURSO As String = CType(gvCursosRecibidos.FooterRow.FindControl("INSTITUCION_CURSOTextBox"), TextBox).Text
        Dim ANIO As String = CType(gvCursosRecibidos.FooterRow.FindControl("ANIOTextBox"), TextBox).Text
        Dim APOYO_INSAFORP As String = CType(gvCursosRecibidos.FooterRow.FindControl("APOYO_INSAFORPDropDownList"), DropDownList).SelectedValue.ToString()

        If Me.ID_SOLICITUD <> 0 Then
            If (New cSOLIC_CURSOS_RECIBIDOS).AgregarSOLIC_CURSOS_RECIBIDOS(0, Me.ID_SOLICITUD, NOMBRE_CURSO, INSTITUCION_CURSO, APOYO_INSAFORP, ANIO) < 1 Then

            End If
        Else
            Dim lCursoRecibido As New SOLIC_CURSOS_RECIBIDOS
            lCursoRecibido.ANIO = ANIO
            lCursoRecibido.NOMBRE_CURSO = NOMBRE_CURSO
            lCursoRecibido.APOYO_INSAFORP = APOYO_INSAFORP

            If listaCursosRecibidos Is Nothing Then
                listaCursosRecibidos = New listaSOLIC_CURSOS_RECIBIDOS
            End If

            listaCursosRecibidos.Add(lCursoRecibido)

            Me.Session("listaCursosRecibidos") = listaCursosRecibidos

        End If

        Me.CargarCursosRecibidos()

        Return 1

    End Function

    Private Function GuardarCursosRecibidos() As Integer
        Me.listaCursosRecibidos = Me.Session("listaCursosRecibidos")
        If Me.listaCursosRecibidos Is Nothing Then Return 1
        For Each lCursoRecibido As SOLIC_CURSOS_RECIBIDOS In listaCursosRecibidos
            If lCursoRecibido.ID_SOLICITUD = 0 Then
                lCursoRecibido.ID_SOLICITUD = Me.ID_SOLICITUD
            End If
            If (New cSOLIC_CURSOS_RECIBIDOS).ActualizarSOLIC_CURSOS_RECIBIDOS(lCursoRecibido) < 1 Then

            End If
        Next
        Me.listaCursosRecibidos.Clear()
        Me.Session("listaCursosRecibidos") = Me.listaCursosRecibidos
        Return 1
        'Me.CargarCursosRecibidos()
    End Function

    Private Function EliminarCursoRecibido(ByVal RowIndex As Integer) As Integer
        listaCursosRecibidos = Me.Session("listaCursosRecibidos")

        If Me.ID_SOLICITUD <> 0 Then
            Dim ID_CURSO_RECIBIDO As String = CType(gvCursosRecibidos.Rows(RowIndex).FindControl("Label_ID_CURSO_RECIBIDO"), Label).Text

            If (New cSOLIC_CURSOS_RECIBIDOS).EliminarSOLIC_CURSOS_RECIBIDOS(ID_CURSO_RECIBIDO) < 1 Then

            End If
        Else

            If listaCursosRecibidos Is Nothing Then
                listaCursosRecibidos = New listaSOLIC_CURSOS_RECIBIDOS
            End If

            listaCursosRecibidos.RemoveAt(RowIndex)

            Me.Session("listaCursosRecibidos") = listaCursosRecibidos

        End If

        Return 1
    End Function
End Class
