Imports DevExpress.Web.ASPxEditors
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SGAFP.DL.DS_DL
Imports SGAFP.DL.DS_DLTableAdapters
Imports DevExpress.Web.ASPxClasses

Partial Class controles_ucVistaDetalleSOLICITUD_INSCRIPCION_AF2
    Inherits ucBase

    Private mComponente As New cSOLICITUD_INSCRIPCION_AF
    Private mEntidad As SOLICITUD_INSCRIPCION_AF
    Private _nuevo As Boolean = False
    Public Event ErrorEvent(ByVal errorMessage As String)

    Private _CODIGO_ERROR As Integer
    Public ReadOnly Property CODIGO_ERROR() As Integer
        Get
            Return _CODIGO_ERROR
        End Get
    End Property

    Public Property ID_PARTICIPANTE() As Decimal
        Get
            If Me.ID_PARTICIPANTEtxt.Text.Trim = "" Then
                Return 0
            Else
                Return CDec(Me.ID_PARTICIPANTEtxt.Text.Trim)
            End If
        End Get
        Set(ByVal value As Decimal)
            Me.ID_PARTICIPANTEtxt.Text = value
        End Set
    End Property

    Public Property FECHA_NACIMIENTO() As Date
        Get
            Return Me.FECHA_NACIMIENTODateEdit.Date
        End Get
        Set(ByVal value As Date)
            Me.FECHA_NACIMIENTODateEdit.Date = value
        End Set
    End Property

    Public Property APELLIDOS() As String
        Get
            Return Me.APELLIDOStxt.Text
        End Get
        Set(ByVal value As String)
            Me.APELLIDOStxt.Text = value
        End Set
    End Property

    Public Property NOMBRES() As String
        Get
            Return Me.NOMBREStxt.Text
        End Get
        Set(ByVal value As String)
            Me.NOMBREStxt.Text = value
        End Set
    End Property

    Public Property DUI() As String
        Get
            Return Me.DUItxt.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.DUItxt.Text = value
        End Set
    End Property

    Public Property NIT() As String
        Get
            Return Me.NITtxt.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.NITtxt.Text = value
        End Set
    End Property

    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            If Me.ID_ACCION_FORMATIVAtxt.Text <> "" Then Return Me.ID_ACCION_FORMATIVAtxt.Text
            Return -1
        End Get
        Set(ByVal value As Decimal)
            Me.ID_ACCION_FORMATIVAtxt.Text = value
        End Set
    End Property

    Private _ID_SOLICITUD As Decimal
    Public Property ID_SOLICITUD() As Decimal
        Get
            Return Me.ID_SOLICITUDtxt.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_SOLICITUD = Value
            Me.ID_SOLICITUDtxt.Text = CStr(Value)
            If Me._ID_SOLICITUD > 0 Then
                Me.CargarDatos()
            Else
                Me.Nuevo()
            End If
        End Set
    End Property

    Private Sub CargarDepartamentos(ByVal cmbDepartamento As ASPxComboBox)
        cmbDepartamento.DataBind()
    End Sub

    Private Sub CargarPaises()
        Me.ID_PAIScbx.DataBind()
    End Sub

    Private Sub CargarMunicipios(ByVal odsMunicipio As ObjectDataSource, ByVal cmbMunicipio As ASPxComboBox, ByVal CODIGO_DEPARTAMENTO As String)
        odsMunicipio.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = CODIGO_DEPARTAMENTO
        cmbMunicipio.DataBind()
    End Sub

    Private Sub CargarParentesco()
        Me.ID_PARENTESCOcbx.DataBind()
    End Sub

    Private Sub CargarCursosRecibidos(ByVal ID_PARTICIPANTE As Decimal, ByVal ID_EJERCICIO As String)
        'Me.odsCursosRecibidos.SelectParameters("ID_PARTICIPANTE").DefaultValue = ID_PARTICIPANTE
        'Me.odsCursosRecibidos.SelectParameters("ID_EJERCICIO").DefaultValue = ID_EJERCICIO
        'Me.gridCursos.DataBind()

        'Me.odsCursosRecibidosPorCentro.SelectParameters("ID_PARTICIPANTE").DefaultValue = ID_PARTICIPANTE
        'Me.odsCursosRecibidosPorCentro.SelectParameters("ID_EJERCICIO").DefaultValue = ID_EJERCICIO
        'Me.gridCentroFormacion.DataBind()
    End Sub
   
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsCallback Then
            Me.CargarPaises()
            Me.CargarDepartamentos(DEPARTAMENTO_NACcbx)
            Me.CargarDepartamentos(CODIGO_DEPARTAMENTOcbx)
            Me.CargarDepartamentos(CODIGO_DEPARTAMENTO_FAMcbx)
            Me.CargarParentesco()
        End If
        Habilitar()
    End Sub

    Public Sub Habilitar(Optional ByVal valor As Boolean = True)
        Dim Condicion As Boolean

        BuscarNombresbtn.ClientEnabled = valor
        BuscarDUIbtn.ClientEnabled = valor
        BuscarNITbtn.ClientEnabled = valor
        CopiarDomiciliobtn.ClientEnabled = valor

        ID_ACCION_FORMATIVAtxt.ClientVisible = False
        ID_TIPO_SOLICITUDtxt.ClientVisible = False
        ID_ESTADO_SOLICITUDtxt.ClientVisible = False
        FECHA_PRESENTACIONDateEdit.ClientEnabled = valor
        NOMBREStxt.ClientEnabled = valor
        APELLIDOStxt.ClientEnabled = valor
        DUItxt.ClientEnabled = IIf(Me.ID_SOLICITUDtxt.Text <> "", False, valor)
        NITtxt.ClientEnabled = IIf(Me.ID_SOLICITUDtxt.Text <> "", False, valor)
        CARNET_MINORIDADtxt.ClientEnabled = valor
        ISSStxt.ClientEnabled = valor
        PASAPORTEtxt.ClientEnabled = valor
        NUM_DOCTOtxt.ClientEnabled = valor

        NACIONALIDADRadioButtonList.ClientEnabled = valor
        ID_PAIScbx.ClientEnabled = (NACIONALIDADRadioButtonList.Value = 2 AndAlso valor)
        DEPARTAMENTO_NACcbx.ClientEnabled = (NACIONALIDADRadioButtonList.Value = 1 AndAlso valor)
        MUNICIPIO_NACcbx.ClientEnabled = (NACIONALIDADRadioButtonList.Value = 1 AndAlso valor)
        FECHA_NACIMIENTODateEdit.ClientEnabled = valor

        GENERORadioButtonList.ClientEnabled = valor
        MIEMBROS_GRUPO_FAMILIAspn.ClientEnabled = valor
        ESTADO_CIVILRadioButtonList.ClientEnabled = valor
        ES_JEFE_HOGARRadioButotonList.ClientEnabled = valor
        TIENE_HIJOSRadioButtonList.ClientEnabled = valor
        NO_DE_HIJOStxt.ClientEnabled = (TIENE_HIJOSRadioButtonList.Value = 1 AndAlso valor)
        PROFESION_OFICIORadioButtonList.ClientEnabled = valor
        PROFESION_OFICIOtxt.ClientEnabled = (PROFESION_OFICIORadioButtonList.Value = 1 AndAlso valor)
        DIRECCIONtxt.ClientEnabled = valor
        CODIGO_DEPARTAMENTOcbx.ClientEnabled = valor
        CODIGO_MUNICIPIOcbx.ClientEnabled = valor
        TELEFONOtxt.ClientEnabled = valor
        MOVILtxt.ClientEnabled = valor
        EMAILtxt.ClientEnabled = valor

        CON_DISCAPACIDADRadioButtonList.ClientEnabled = valor
        Condicion = (CON_DISCAPACIDADRadioButtonList.Value = 1 AndAlso valor)
        DISC_MOVERSE_CAMINARchk.ClientEnabled = Condicion
        DISC_BRAZOS_MANOSchk.ClientEnabled = Condicion
        DISC_VERchk.ClientEnabled = Condicion
        DISC_OIRchk.ClientEnabled = Condicion
        DISC_HABLARchk.ClientEnabled = Condicion
        DISC_RETRASOchk.ClientEnabled = Condicion
        DISC_BAN_VESTIR_ALIMchk.ClientEnabled = Condicion
        DISC_OTRAchk.ClientEnabled = Condicion
        DISC_OTRAtxt.ClientEnabled = DISC_OTRAchk.Checked AndAlso valor

        SABE_LEER_ESCRIBIRRadioButtonList.ClientEnabled = valor
        SOLO_LEE_ESCRIBERadioButtonList.ClientEnabled = (SABE_LEER_ESCRIBIRRadioButtonList.Value = 2 AndAlso valor)
        EDUCACION_FORMAL_SOLO_FIRMAchk.ClientEnabled = (SABE_LEER_ESCRIBIRRadioButtonList.Value = 2 AndAlso valor)

        EDUCACION_BASICArdb.ClientEnabled = valor
        EDUCACION_BASICARadioButtonList.ClientEnabled = (EDUCACION_BASICArdb.Value AndAlso valor)
        BACHILLERATOrdb.ClientEnabled = valor
        BACHILLERATORadioButtonList.ClientEnabled = (BACHILLERATOrdb.Value AndAlso valor)
        TECNOLOGICArdb.ClientEnabled = valor
        TECNOLOGICARadioButtonList.ClientEnabled = (TECNOLOGICArdb.Value AndAlso valor)
        UNIVERSITARIArdb.ClientEnabled = valor
        UNIVERSITARIARadioButtonList.ClientEnabled = (UNIVERSITARIArdb.Value AndAlso valor)
        OTRA_EDUCACION_FORMALchk.ClientEnabled = valor
        OTRA_EDUCACION_FORMALtxt.ClientEnabled = (OTRA_EDUCACION_FORMALchk.Checked AndAlso valor)
        TITULO_CERTIFICADO_OBTENIDOchk.ClientEnabled = valor
        TITULO_CERTIFICADO_OBTENIDOtxt.ClientEnabled = (TITULO_CERTIFICADO_OBTENIDOchk.Checked AndAlso valor)

        ESTUDIA_ACTUALMENTERadioButtonlist.ClientEnabled = valor
        TIEMPO_DEJO_ESTUDIARRadioButtonList.ClientEnabled = (ESTUDIA_ACTUALMENTERadioButtonlist.Value = 2 AndAlso valor)

        RECIBIO_CURSO_ANTERIORRadioButtonList.ClientEnabled = valor
        Condicion = (RECIBIO_CURSO_ANTERIORRadioButtonList.Value = 1 AndAlso valor)
        CURSO1txt.ClientEnabled = RECIBIO_CURSO_ANTERIORRadioButtonList.Value = 1 AndAlso valor
        CURSO2txt.ClientEnabled = Condicion
        CURSO3txt.ClientEnabled = Condicion
        IMPARTIO_INSAFORP1ButtonList.ClientEnabled = Condicion
        IMPARTIO_INSAFORP2ButtonList.ClientEnabled = Condicion
        IMPARTIO_INSAFORP3ButtonList.ClientEnabled = Condicion
        ANIO1txt.ClientEnabled = Condicion
        ANIO2txt.ClientEnabled = Condicion
        ANIO3txt.ClientEnabled = Condicion
        CURSO_DIO_BENEFICIOS1ButtonList.ClientEnabled = Condicion
        CURSO_DIO_BENEFICIOS2ButtonList.ClientEnabled = Condicion
        CURSO_DIO_BENEFICIOS3ButtonList.ClientEnabled = Condicion

        Condicion = (CURSO_DIO_BENEFICIOS1ButtonList.Value = 1 OrElse _
                     CURSO_DIO_BENEFICIOS2ButtonList.Value = 1 OrElse _
                     CURSO_DIO_BENEFICIOS3ButtonList.Value = 1) AndAlso valor
        BENEF_OBT_EMPLEOchk.ClientEnabled = Condicion
        BENEF_TRAB_CTA_PROPIAchk.ClientEnabled = Condicion
        BENEF_PROM_EMP_ACTchk.ClientEnabled = Condicion
        BENEF_CAMB_EMP_X_CURSOchk.ClientEnabled = Condicion
        BENEF_ING_EXTRAchk.ClientEnabled = Condicion
        BENEF_OTROchk.ClientEnabled = Condicion
        BENEF_OTROtxt.ClientEnabled = (BENEF_OTROchk.Checked AndAlso valor)

        Condicion = (CURSO_DIO_BENEFICIOS1ButtonList.Value = 2 OrElse _
                     CURSO_DIO_BENEFICIOS2ButtonList.Value = 2 OrElse _
                     CURSO_DIO_BENEFICIOS3ButtonList.Value = 2) AndAlso valor
        RAZON_NO_BENEFICIOtxt.ClientEnabled = Condicion


        OCUACT_ESTUDIAchk.ClientEnabled = valor
        OCUACT_OFICIO_HOGARchk.ClientEnabled = valor
        OCUACT_TRABAJAchk.ClientEnabled = valor
        OCUACT_BUSCA_TRABAJOchk.ClientEnabled = valor
        OCUACT_OTRAchk.ClientEnabled = valor
        OCUACT_OTRAtxt.ClientEnabled = (OCUACT_OTRAchk.Checked AndAlso valor)

        TIPO_EMPLEORadioButtonList.ClientEnabled = (OCUACT_TRABAJAchk.Checked AndAlso valor)
        TIEMP_OTROtxt.ClientEnabled = (TIPO_EMPLEORadioButtonList.Value = 7 AndAlso TIPO_EMPLEORadioButtonList.ClientEnabled)

        Condicion = (TIPO_EMPLEORadioButtonList.ClientEnabled AndAlso valor AndAlso _
                        (TIPO_EMPLEORadioButtonList.Value = 1 Or TIPO_EMPLEORadioButtonList.Value = 2 Or TIPO_EMPLEORadioButtonList.Value = 3))
        SECTOR_EMPLEORadioButtonList.ClientEnabled = Condicion

        TRABAJO_ANTERIORRadioButtonList.ClientEnabled = (Not OCUACT_TRABAJAchk.Checked AndAlso valor)
        Condicion = (Not OCUACT_TRABAJAchk.Checked AndAlso TRABAJO_ANTERIORRadioButtonList.Value = "S" AndAlso valor)
        TIEMPO_NO_TRABAJARadioButtonList1.ClientEnabled = Condicion

        RECIBE_INGRESOSRadioButtonList.ClientEnabled = valor
        Condicion = (RECIBE_INGRESOSRadioButtonList.Value = 1 AndAlso valor)
        MANERA_OBT_ING_TRABAJOchk.ClientEnabled = Condicion
        MANERA_OBT_ING_PENSIONchk.ClientEnabled = Condicion
        MANERA_OBT_ING_REMESAchk.ClientEnabled = Condicion
        MANERA_OBT_ING_AYUDA_FAMchk.ClientEnabled = Condicion
        MANERA_OBT_ING_OTRAchk.ClientEnabled = Condicion
        MANERA_OBT_ING_OTRAtxt.ClientEnabled = (MANERA_OBT_ING_OTRAchk.Checked AndAlso Condicion)

        EXPFOR_NINGUNOchk.ClientEnabled = valor
        Condicion = (Not EXPFOR_NINGUNOchk.Checked AndAlso valor)
        EXPFOR_PROMOCION_EMPLEOchk.ClientEnabled = Condicion
        EXPFOR_INGRESOS_EXTRAchk.ClientEnabled = Condicion
        EXPFOR_RELACION_EMPLEOchk.ClientEnabled = Condicion
        EXPFOR_OBTENER_EMPLEOchk.ClientEnabled = Condicion
        EXPFOR_TRABAJAR_CTA_PROPIAchk.ClientEnabled = Condicion
        EXPFOR_OTROchk.ClientEnabled = Condicion
        EXPFOR_OTROtxt.ClientEnabled = (EXPFOR_OTROchk.Checked AndAlso valor)

        CURSO_REL_TRABRadioButtonList.ClientEnabled = valor

        NOMBRE_FAMILIARtxt.ClientEnabled = valor
        ID_PARENTESCOcbx.ClientEnabled = valor
        DIRECCION_FAMILIARtxt.ClientEnabled = valor
        CODIGO_DEPARTAMENTO_FAMcbx.ClientEnabled = valor
        CODIGO_MUNICIPIO_FAMcbx.ClientEnabled = valor
        TELEFONO_FAMILIARtxt.ClientEnabled = valor
        MOVIL_FAMILIARtxt.ClientEnabled = valor
        EMAIL_FAMILIARtxt.ClientEnabled = valor
        SUGERENCIASMemo.ClientEnabled = valor
    End Sub

    Public Sub Nuevo()
        TabSolicitud.ActiveTabIndex = 0
        ID_SOLICITUDtxt.Text = ""
        ID_TIPO_SOLICITUDtxt.Text = ""
        ID_ESTADO_SOLICITUDtxt.Text = Enumeradores.EstadoSolicitud.EnEsperaDeAprobacion
        FECHA_PRESENTACIONDateEdit.Text = ""
        ID_PARTICIPANTEtxt.Text = ""
        NOMBREStxt.Text = ""
        APELLIDOStxt.Text = ""
        DUItxt.Text = ""
        NITtxt.Text = ""
        CARNET_MINORIDADtxt.Text = ""
        ISSStxt.Text = ""
        PASAPORTEtxt.Text = ""
        NUM_DOCTOtxt.Text = ""
        ASPxEdit.ClearEditorsInContainer(NACIONALIDADRadioButtonList)
        If ID_PAIScbx.Items.FindByValue(57) IsNot Nothing Then ID_PAIScbx.Items.FindByValue(57).Selected = True
        DEPARTAMENTO_NACcbx.SelectedIndex = -1
        MUNICIPIO_NACcbx.SelectedIndex = -1
        FECHA_NACIMIENTODateEdit.Text = ""
        ASPxEdit.ClearEditorsInContainer(GENERORadioButtonList)
        EDADtxt.Text = ""
        MIEMBROS_GRUPO_FAMILIAspn.Value = ""
        ASPxEdit.ClearEditorsInContainer(ESTADO_CIVILRadioButtonList)
        ASPxEdit.ClearEditorsInContainer(ES_JEFE_HOGARRadioButotonList)
        ASPxEdit.ClearEditorsInContainer(TIENE_HIJOSRadioButtonList)
        NO_DE_HIJOStxt.Text = ""
        ASPxEdit.ClearEditorsInContainer(PROFESION_OFICIORadioButtonList)
        PROFESION_OFICIOtxt.Text = ""
        DIRECCIONtxt.Text = ""
        CODIGO_DEPARTAMENTOcbx.SelectedIndex = -1
        CODIGO_MUNICIPIOcbx.SelectedIndex = -1
        TELEFONOtxt.Text = ""
        MOVILtxt.Text = ""
        EMAILtxt.Text = ""
        ASPxEdit.ClearEditorsInContainer(CON_DISCAPACIDADRadioButtonList)
        DISC_MOVERSE_CAMINARchk.Value = False
        DISC_BRAZOS_MANOSchk.Value = False
        DISC_VERchk.Value = False
        DISC_OIRchk.Value = False
        DISC_HABLARchk.Value = False
        DISC_RETRASOchk.Value = False
        DISC_BAN_VESTIR_ALIMchk.Value = False
        DISC_OTRAchk.Value = False
        DISC_OTRAtxt.Text = ""
        ASPxEdit.ClearEditorsInContainer(SABE_LEER_ESCRIBIRRadioButtonList)
        ASPxEdit.ClearEditorsInContainer(SOLO_LEE_ESCRIBERadioButtonList)

        EDUCACION_BASICArdb.Value = False
        ASPxEdit.ClearEditorsInContainer(EDUCACION_BASICARadioButtonList)
        BACHILLERATOrdb.Value = False
        ASPxEdit.ClearEditorsInContainer(BACHILLERATORadioButtonList)
        TECNOLOGICArdb.Value = False
        ASPxEdit.ClearEditorsInContainer(TECNOLOGICARadioButtonList)
        UNIVERSITARIArdb.Value = False
        ASPxEdit.ClearEditorsInContainer(UNIVERSITARIARadioButtonList)
        OTRA_EDUCACION_FORMALchk.Value = False
        OTRA_EDUCACION_FORMALtxt.Text = ""
        TITULO_CERTIFICADO_OBTENIDOchk.Value = False
        TITULO_CERTIFICADO_OBTENIDOtxt.Text = ""
        ASPxEdit.ClearEditorsInContainer(ESTUDIA_ACTUALMENTERadioButtonlist)
        ASPxEdit.ClearEditorsInContainer(TIEMPO_DEJO_ESTUDIARRadioButtonList)
        ASPxEdit.ClearEditorsInContainer(RECIBIO_CURSO_ANTERIORRadioButtonList)

        CURSO1txt.Text = ""
        CURSO2txt.Text = ""
        CURSO3txt.Text = ""
        ASPxEdit.ClearEditorsInContainer(IMPARTIO_INSAFORP1ButtonList)
        ASPxEdit.ClearEditorsInContainer(IMPARTIO_INSAFORP2ButtonList)
        ASPxEdit.ClearEditorsInContainer(IMPARTIO_INSAFORP3ButtonList)
        ANIO1txt.Text = ""
        ANIO2txt.Text = ""
        ANIO3txt.Text = ""
        ASPxEdit.ClearEditorsInContainer(CURSO_DIO_BENEFICIOS1ButtonList)
        ASPxEdit.ClearEditorsInContainer(CURSO_DIO_BENEFICIOS2ButtonList)
        ASPxEdit.ClearEditorsInContainer(CURSO_DIO_BENEFICIOS3ButtonList)

        BENEF_OBT_EMPLEOchk.Value = False
        BENEF_TRAB_CTA_PROPIAchk.Value = False
        BENEF_PROM_EMP_ACTchk.Value = False
        BENEF_CAMB_EMP_X_CURSOchk.Value = False
        BENEF_ING_EXTRAchk.Value = False
        BENEF_OTROchk.Value = False
        BENEF_OTROtxt.Text = ""
        RAZON_NO_BENEFICIOtxt.Text = ""
        OCUACT_ESTUDIAchk.Value = False
        OCUACT_OFICIO_HOGARchk.Value = False
        OCUACT_TRABAJAchk.Value = False
        OCUACT_BUSCA_TRABAJOchk.Value = False
        OCUACT_OTRAchk.Value = False
        OCUACT_OTRAtxt.Text = ""
        ASPxEdit.ClearEditorsInContainer(TIPO_EMPLEORadioButtonList)
        TIEMP_OTROtxt.Text = ""

        ASPxEdit.ClearEditorsInContainer(SECTOR_EMPLEORadioButtonList)
        ASPxEdit.ClearEditorsInContainer(TRABAJO_ANTERIORRadioButtonList)
        ASPxEdit.ClearEditorsInContainer(TIEMPO_NO_TRABAJARadioButtonList1)

        ASPxEdit.ClearEditorsInContainer(RECIBE_INGRESOSRadioButtonList)
        MANERA_OBT_ING_TRABAJOchk.Value = False
        MANERA_OBT_ING_PENSIONchk.Value = False
        MANERA_OBT_ING_REMESAchk.Value = False
        MANERA_OBT_ING_AYUDA_FAMchk.Value = False
        MANERA_OBT_ING_OTRAchk.Value = False
        MANERA_OBT_ING_OTRAtxt.Text = ""

        EXPFOR_PROMOCION_EMPLEOchk.Value = False
        EXPFOR_RELACION_EMPLEOchk.Value = False
        EXPFOR_OBTENER_EMPLEOchk.Value = False
        EXPFOR_TRABAJAR_CTA_PROPIAchk.Value = False
        EXPFOR_INGRESOS_EXTRAchk.Value = False
        EXPFOR_OTROchk.Value = False
        EXPFOR_OTROtxt.Text = ""
        EXPFOR_NINGUNOchk.Value = False

        ASPxEdit.ClearEditorsInContainer(CURSO_REL_TRABRadioButtonList)

        NOMBRE_FAMILIARtxt.Text = ""
        ID_PARENTESCOcbx.SelectedIndex = -1
        DIRECCION_FAMILIARtxt.Text = ""
        CODIGO_DEPARTAMENTO_FAMcbx.SelectedIndex = -1
        CODIGO_MUNICIPIO_FAMcbx.SelectedIndex = -1
        TELEFONO_FAMILIARtxt.Text = ""
        MOVIL_FAMILIARtxt.Text = ""
        EMAIL_FAMILIARtxt.Text = ""
        SUGERENCIASMemo.Text = ""
    End Sub

    Protected Sub MUNICIPIO_NACcbx_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles MUNICIPIO_NACcbx.Callback
        CargarMunicipios(Me.odsMUNICIPIO_NACcbx, sender, e.Parameter)
    End Sub

    Protected Sub CODIGO_MUNICIPIOcbx_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles CODIGO_MUNICIPIOcbx.Callback
        CargarMunicipios(Me.odsCODIGO_MUNICIPIOcbx, sender, e.Parameter)
    End Sub

    Protected Sub CODIGO_MUNICIPIO_FAMcbx_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles CODIGO_MUNICIPIO_FAMcbx.Callback
        CargarMunicipios(Me.odsCODIGO_MUNICIPIO_FAMcbx, sender, e.Parameter)
    End Sub

    Function CalcularEdad(ByVal fechaNacimiento As DateTime) As Integer
        Dim años As Integer = Now.Year - fechaNacimiento.Year
        If Now.Month < fechaNacimiento.Month Or (Now.Month = fechaNacimiento.Month And Now.Day < fechaNacimiento.Day) Then años -= 1
        Return años
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla PARTICIPANTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosParticipante() As String
        Dim bParticipante As New cPARTICIPANTE
        Dim eParticipante As New PARTICIPANTE
        Dim item As New DevExpress.Web.ASPxEditors.ListEditItem


        eParticipante.ID_PARTICIPANTE = Me.ID_PARTICIPANTE
        If bParticipante.ObtenerPARTICIPANTE(eParticipante) <> 1 Then
            Return "Error al Obtener registro de Participante."
        End If
        With eParticipante
            NOMBREStxt.Text = .NOMBRES
            APELLIDOStxt.Text = .APELLIDOS
            DUItxt.Text = .DUI
            NITtxt.Text = .NIT
            ISSStxt.Text = .ISSS
            PASAPORTEtxt.Text = ""
            NUM_DOCTOtxt.Text = ""
            CARNET_MINORIDADtxt.Text = ""
            Select Case .TIPO_DOCTO
                Case 1
                    CARNET_MINORIDADtxt.Text = .NUM_DOCTO
                Case 2
                    PASAPORTEtxt.Text = .NUM_DOCTO
                Case 3
                    NUM_DOCTOtxt.Text = .NUM_DOCTO
            End Select
            Me.CargarPaises()
            Me.CargarDepartamentos(DEPARTAMENTO_NACcbx)
            If .ID_PAIS = 57 Then
                NACIONALIDADRadioButtonList.Value = 1
                Me.ID_PAIScbx.Value = 57
                ID_PAIScbx.ClientEnabled = False
                DEPARTAMENTO_NACcbx.ClientEnabled = True
                MUNICIPIO_NACcbx.ClientEnabled = True
                Me.CargarDepartamentos(DEPARTAMENTO_NACcbx)
                DEPARTAMENTO_NACcbx.Value = .DEPARTAMENTO_NAC
                Me.CargarMunicipios(odsMUNICIPIO_NACcbx, MUNICIPIO_NACcbx, .DEPARTAMENTO_NAC)
                MUNICIPIO_NACcbx.Value = .MUNICIPIO_NAC
                SeleccionarElemento(MUNICIPIO_NACcbx, .MUNICIPIO_NAC)
            Else
                Me.ID_PAIScbx.Value = CInt(.ID_PAIS)
                NACIONALIDADRadioButtonList.Value = 2
                ID_PAIScbx.ClientEnabled = True
                DEPARTAMENTO_NACcbx.ClientEnabled = False
                MUNICIPIO_NACcbx.ClientEnabled = False
            End If
            FECHA_NACIMIENTODateEdit.Value = .FECHA_NACIMIENTO
            If .GENERO = "M" Then GENERORadioButtonList.Value = 1 Else GENERORadioButtonList.Value = 2
            EDADtxt.Text = CalcularEdad(.FECHA_NACIMIENTO)
            ESTADO_CIVILRadioButtonList.Value = CInt(.ID_ESTADO_CIVIL)
            If .PROFESION_OFICIO <> "" Then PROFESION_OFICIORadioButtonList.Value = 1 Else PROFESION_OFICIORadioButtonList.Value = 2
            DIRECCIONtxt.Text = .DIRECCION
            Me.CargarDepartamentos(CODIGO_DEPARTAMENTOcbx)
            CODIGO_DEPARTAMENTOcbx.Value = .CODIGO_DEPARTAMENTO
            Me.CargarMunicipios(odsCODIGO_MUNICIPIOcbx, CODIGO_MUNICIPIOcbx, .CODIGO_DEPARTAMENTO)
            CODIGO_MUNICIPIOcbx.Value = .CODIGO_MUNICIPIO
            TELEFONOtxt.Text = .TELEFONO
            MOVILtxt.Text = .MOVIL
            EMAILtxt.Text = .EMAIL
            CON_DISCAPACIDADRadioButtonList.Value = CInt(.CON_DISCAPACIDAD)
            'Mostrar discapacidades
            Dim ListaDiscapacidades As New listaDISCA_POR_PARTICIPANTE
            ListaDiscapacidades = (New cDISCA_POR_PARTICIPANTE).ObtenerListaPorPARTICIPANTE(Me.ID_PARTICIPANTE)
            Me.DISC_MOVERSE_CAMINARchk.Checked = False
            Me.DISC_BRAZOS_MANOSchk.Checked = False
            Me.DISC_VERchk.Checked = False
            Me.DISC_OIRchk.Checked = False
            Me.DISC_HABLARchk.Checked = False
            Me.DISC_RETRASOchk.Checked = False
            Me.DISC_BAN_VESTIR_ALIMchk.Checked = False
            Me.DISC_OTRAchk.Checked = False
            For Each _Discapacidad As DISCA_POR_PARTICIPANTE In ListaDiscapacidades
                Select Case CInt(_Discapacidad.ID_DISCAPACIDAD)
                    Case 1
                        Me.DISC_MOVERSE_CAMINARchk.Checked = True
                    Case 2
                        Me.DISC_BRAZOS_MANOSchk.Checked = True
                    Case 3
                        Me.DISC_VERchk.Checked = True
                    Case 4
                        Me.DISC_OIRchk.Checked = True
                    Case 5
                        Me.DISC_HABLARchk.Checked = True
                    Case 6
                        Me.DISC_RETRASOchk.Checked = True
                    Case 7
                        Me.DISC_BAN_VESTIR_ALIMchk.Checked = True
                    Case 8
                        Me.DISC_OTRAchk.Checked = True
                End Select
            Next
            Me.DISC_OTRAtxt.Text = .DISC_OTRA
            Select Case .ID_NIVEL_ACADEMICO
                Case 9 To 17
                    Me.EDUCACION_BASICArdb.Value = True
                    EDUCACION_BASICARadioButtonList.Value = CInt(.ID_NIVEL_ACADEMICO)
                Case 18 To 19
                    Me.BACHILLERATOrdb.Value = True
                    BACHILLERATORadioButtonList.Value = CInt(.ID_NIVEL_ACADEMICO)
                Case 20 To 21
                    Me.TECNOLOGICArdb.Value = True
                    TECNOLOGICARadioButtonList.Value = CInt(.ID_NIVEL_ACADEMICO)
                Case 22 To 23
                    Me.UNIVERSITARIArdb.Value = True
                    UNIVERSITARIARadioButtonList.Value = CInt(.ID_NIVEL_ACADEMICO)
            End Select
            Me.OTRA_EDUCACION_FORMALchk.Checked = (.OTRA_EDUCACION_FORMAL <> "")
            Me.OTRA_EDUCACION_FORMALtxt.Text = .OTRA_EDUCACION_FORMAL
            If .PROFESION_OFICIO <> "" Then PROFESION_OFICIORadioButtonList.Value = 1 Else PROFESION_OFICIORadioButtonList.Value = 2
            Me.PROFESION_OFICIOtxt.Text = .PROFESION_OFICIO
        End With
        Return ""
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/02/2010	Created
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
        With mEntidad
            Me.ID_SOLICITUDtxt.Text = .ID_SOLICITUD
            Me.FECHA_PRESENTACIONDateEdit.Date = .FECHA_PRESENTACION
            Me.ID_ACCION_FORMATIVAtxt.Text = .ID_ACCION_FORMATIVA
            Me.ID_TIPO_SOLICITUDtxt.Text = .ID_TIPO_SOLICITUD
            Me.ID_ESTADO_SOLICITUDtxt.Text = .ID_ESTADO_SOLICITUD
            Me.ID_PARTICIPANTEtxt.Text = .ID_PARTICIPANTE
            Me.NOMBREStxt.Text = .NOMBRES
            Me.APELLIDOStxt.Text = .APELLIDOS
            Me.DUItxt.Text = .DUI
            Me.NITtxt.Text = .NIT
            Me.ISSStxt.Text = .ISSS
            Me.PASAPORTEtxt.Text = ""
            Me.NUM_DOCTOtxt.Text = ""
            Me.CARNET_MINORIDADtxt.Text = ""
            Select Case .TIPO_DOCTO
                Case 1
                    Me.CARNET_MINORIDADtxt.Text = .NUM_DOCTO
                Case 2
                    Me.PASAPORTEtxt.Text = .NUM_DOCTO
                Case 3
                    Me.NUM_DOCTOtxt.Text = .NUM_DOCTO
            End Select

            Me.CargarPaises()
            Me.CargarDepartamentos(DEPARTAMENTO_NACcbx)
            If .ID_PAIS = 57 Then
                Me.NACIONALIDADRadioButtonList.Value = 1
                Me.ID_PAIScbx.Value = 57
                Me.ID_PAIScbx.ClientEnabled = False
                Me.DEPARTAMENTO_NACcbx.ClientEnabled = True
                Me.MUNICIPIO_NACcbx.ClientEnabled = True
                Me.CargarDepartamentos(DEPARTAMENTO_NACcbx)
                Me.DEPARTAMENTO_NACcbx.Value = .DEPARTAMENTO_NAC
                Me.CargarMunicipios(odsMUNICIPIO_NACcbx, MUNICIPIO_NACcbx, .DEPARTAMENTO_NAC)
                Me.MUNICIPIO_NACcbx.Value = .MUNICIPIO_NAC
                SeleccionarElemento(MUNICIPIO_NACcbx, .MUNICIPIO_NAC)
            Else
                Me.ID_PAIScbx.Value = CInt(.ID_PAIS)
                Me.NACIONALIDADRadioButtonList.Value = 2
                Me.ID_PAIScbx.ClientEnabled = True
                Me.DEPARTAMENTO_NACcbx.ClientEnabled = False
                Me.MUNICIPIO_NACcbx.ClientEnabled = False
            End If
            Me.FECHA_NACIMIENTODateEdit.Value = .FECHA_NACIMIENTO
            If .GENERO = "M" Then Me.GENERORadioButtonList.Value = 1 Else Me.GENERORadioButtonList.Value = 2
            Me.EDADtxt.Text = CalcularEdad(.FECHA_NACIMIENTO)
            Me.MIEMBROS_GRUPO_FAMILIAspn.Value = CInt(.MIEMBROS_GRUPO_FAMILIAR)
            Me.ESTADO_CIVILRadioButtonList.Value = CInt(.ID_ESTADO_CIVIL)
            If .ES_JEFE_HOGAR <> -1 Then Me.ES_JEFE_HOGARRadioButotonList.Value = CInt(.ES_JEFE_HOGAR)

            If .TIENE_HIJOS = 1 Then
                Me.TIENE_HIJOSRadioButtonList.Value = 1
                Me.NO_DE_HIJOStxt.Text = .NO_DE_HIJOS
            ElseIf .TIENE_HIJOS = 2 Then
                Me.TIENE_HIJOSRadioButtonList.Value = 2
                Me.NO_DE_HIJOStxt.Text = ""
            End If

            If .PROFESION_OFICIO <> "" Then
                Me.PROFESION_OFICIORadioButtonList.Value = 1
                Me.PROFESION_OFICIOtxt.Text = .PROFESION_OFICIO
            Else
                Me.PROFESION_OFICIORadioButtonList.Value = 2
                Me.PROFESION_OFICIOtxt.Text = ""
            End If
            Me.DIRECCIONtxt.Text = .DIRECCION
            Me.CargarDepartamentos(CODIGO_DEPARTAMENTOcbx)
            Me.CODIGO_DEPARTAMENTOcbx.Value = .CODIGO_DEPARTAMENTO
            Me.CargarMunicipios(odsCODIGO_MUNICIPIOcbx, CODIGO_MUNICIPIOcbx, .CODIGO_DEPARTAMENTO)
            Me.CODIGO_MUNICIPIOcbx.Value = .CODIGO_MUNICIPIO
            Me.TELEFONOtxt.Text = .TELEFONO
            Me.MOVILtxt.Text = .MOVIL
            Me.EMAILtxt.Text = .EMAIL
            Me.CON_DISCAPACIDADRadioButtonList.Value = CInt(.CON_DISCAPACIDAD)

            'Mostrar discapacidades
            Dim ListaDiscapacidades As New listaDISCA_POR_SOLICITUD
            ListaDiscapacidades = (New cDISCA_POR_SOLICITUD).ObtenerListaPorSOLICITUD_INSCRIPCION_AF(.ID_SOLICITUD)
            Me.DISC_MOVERSE_CAMINARchk.Checked = False
            Me.DISC_BRAZOS_MANOSchk.Checked = False
            Me.DISC_VERchk.Checked = False
            Me.DISC_OIRchk.Checked = False
            Me.DISC_HABLARchk.Checked = False
            Me.DISC_RETRASOchk.Checked = False
            Me.DISC_BAN_VESTIR_ALIMchk.Checked = False
            Me.DISC_OTRAchk.Checked = False
            For Each _Discapacidad As DISCA_POR_SOLICITUD In ListaDiscapacidades
                Select Case _Discapacidad.ID_DISCAPACIDAD
                    Case 1
                        Me.DISC_MOVERSE_CAMINARchk.Checked = True
                    Case 2
                        Me.DISC_BRAZOS_MANOSchk.Checked = True
                    Case 3
                        Me.DISC_VERchk.Checked = True
                    Case 4
                        Me.DISC_OIRchk.Checked = True
                    Case 5
                        Me.DISC_HABLARchk.Checked = True
                    Case 6
                        Me.DISC_RETRASOchk.Checked = True
                    Case 7
                        Me.DISC_BAN_VESTIR_ALIMchk.Checked = True
                    Case 8
                        Me.DISC_OTRAchk.Checked = True
                End Select
            Next
            Me.DISC_OTRAtxt.Text = .DISC_OTRA

            Select Case .ID_LEE_ESCRIBE
                Case 1
                    Me.SABE_LEER_ESCRIBIRRadioButtonList.Value = 1
                Case 2
                    Me.SABE_LEER_ESCRIBIRRadioButtonList.Value = 2
                    Me.SOLO_LEE_ESCRIBERadioButtonList.Value = 1
                Case 3
                    Me.SABE_LEER_ESCRIBIRRadioButtonList.Value = 2
                    Me.SOLO_LEE_ESCRIBERadioButtonList.Value = 2
                Case 4
                    Me.EDUCACION_FORMAL_SOLO_FIRMAchk.Checked = True
                Case 5
                    Me.SABE_LEER_ESCRIBIRRadioButtonList.Value = 2
                    Me.SOLO_LEE_ESCRIBERadioButtonList.Value = 1
                    Me.EDUCACION_FORMAL_SOLO_FIRMAchk.Checked = True
                Case 6
                    Me.SABE_LEER_ESCRIBIRRadioButtonList.Value = 2
                    Me.SOLO_LEE_ESCRIBERadioButtonList.Value = 2
                    Me.EDUCACION_FORMAL_SOLO_FIRMAchk.Checked = True
            End Select
         
            Select Case .ID_NIVEL_ACADEMICO
                Case 9 To 17
                    Me.EDUCACION_BASICArdb.Value = True
                    Me.EDUCACION_BASICARadioButtonList.Value = CInt(.ID_NIVEL_ACADEMICO)
                Case 18 To 19
                    Me.BACHILLERATOrdb.Value = True
                    Me.BACHILLERATORadioButtonList.Value = CInt(.ID_NIVEL_ACADEMICO)
                Case 20 To 21
                    Me.TECNOLOGICArdb.Value = True
                    Me.TECNOLOGICARadioButtonList.Value = CInt(.ID_NIVEL_ACADEMICO)
                Case 22 To 23
                    Me.UNIVERSITARIArdb.Value = True
                    Me.UNIVERSITARIARadioButtonList.Value = CInt(.ID_NIVEL_ACADEMICO)
            End Select
            Me.OTRA_EDUCACION_FORMALchk.Checked = (.OTRA_EDUCACION_FORMAL <> "")
            Me.OTRA_EDUCACION_FORMALtxt.Text = .OTRA_EDUCACION_FORMAL

            Me.TITULO_CERTIFICADO_OBTENIDOchk.Checked = (.TITULO_CERTIFICADO_OBTENIDO <> "")
            Me.TITULO_CERTIFICADO_OBTENIDOtxt.Text = .TITULO_CERTIFICADO_OBTENIDO

            If .ESTUDIA_ACTUALMENTE <> -1 Then
                Me.ESTUDIA_ACTUALMENTERadioButtonlist.Value = CInt(.ESTUDIA_ACTUALMENTE)
                If CInt(.ESTUDIA_ACTUALMENTE) = 2 Then
                    Me.TIEMPO_DEJO_ESTUDIARRadioButtonList.Value = CInt(.ID_TIEMPO_DEJO_ESTUDIAR)
                End If
            End If

            If .RECIBIO_CURSO_ANTERIOR = "1" Then
                RECIBIO_CURSO_ANTERIORRadioButtonList.Value = 1
                'Mostrar cursos recibidos
                Dim listaCursos As New listaSOLIC_CURSOS_RECIBIDOS
                listaCursos = (New cSOLIC_CURSOS_RECIBIDOS).ObtenerListaPorSOLICITUD_INSCRIPCION_AF(.ID_SOLICITUD)

                If listaCursos IsNot Nothing Then
                    Dim conta As Integer = 1
                    For Each _Curso As SOLIC_CURSOS_RECIBIDOS In listaCursos
                        Select Case conta
                            Case 1
                                CURSO1txt.Text = _Curso.NOMBRE_CURSO
                                IMPARTIO_INSAFORP1ButtonList.Value = CInt(_Curso.APOYO_INSAFORP)
                                ANIO1txt.Text = _Curso.ANIO
                                CURSO_DIO_BENEFICIOS1ButtonList.Value = CInt(_Curso.BENEFICIO_CURSO)
                            Case 2
                                CURSO2txt.Text = _Curso.NOMBRE_CURSO
                                IMPARTIO_INSAFORP2ButtonList.Value = CInt(_Curso.APOYO_INSAFORP)
                                ANIO2txt.Text = _Curso.ANIO
                                CURSO_DIO_BENEFICIOS2ButtonList.Value = CInt(_Curso.BENEFICIO_CURSO)
                            Case 3
                                CURSO3txt.Text = _Curso.NOMBRE_CURSO
                                IMPARTIO_INSAFORP3ButtonList.Value = CInt(_Curso.APOYO_INSAFORP)
                                ANIO3txt.Text = _Curso.ANIO
                                CURSO_DIO_BENEFICIOS3ButtonList.Value = CInt(_Curso.BENEFICIO_CURSO)
                        End Select
                    Next
                End If
            Else
                RECIBIO_CURSO_ANTERIORRadioButtonList.Value = 2
            End If

            If .BENEF_OBT_EMPLEO = 1 Then BENEF_OBT_EMPLEOchk.Checked = True
            If .BENEF_CAMB_EMP_X_CURSO = 1 Then BENEF_CAMB_EMP_X_CURSOchk.Checked = True
            If .BENEF_TRAB_CTA_PROPIA = 1 Then BENEF_TRAB_CTA_PROPIAchk.Checked = True
            If .BENEF_OBT_ING_EXTRA = 1 Then BENEF_ING_EXTRAchk.Checked = True
            If .BENEF_PROM_EMP_ACT = 1 Then BENEF_PROM_EMP_ACTchk.Checked = True
            If .BENEF_OTRO <> "" Then BENEF_OTROchk.Checked = True
            Me.RAZON_NO_BENEFICIOtxt.Text = .RAZON_NO_BENEFICIO

            If .OCUACT_ESTUDIA = 1 Then OCUACT_ESTUDIAchk.Checked = True
            If .OCUACT_OFICIO_HOGAR = 1 Then OCUACT_OFICIO_HOGARchk.Checked = True
            If .OCUACT_TRABAJA = 1 Then OCUACT_TRABAJAchk.Checked = True
            If .OCUACT_BUSCA_TRABAJO = 1 Then OCUACT_BUSCA_TRABAJOchk.Checked = True
            If .OCUACT_OTRA <> "" Then OCUACT_OTRAchk.Checked = True
            Me.OCUACT_OTRAtxt.Text = .OCUACT_OTRA

            If .ID_TIPO_EMPLEO <> -1 Then
                Me.TIPO_EMPLEORadioButtonList.Value = CInt(.ID_TIPO_EMPLEO)
            End If
            Me.TIEMP_OTROtxt.Text = .TIPO_EMPLEO_OTRO
            If .SECTOR_EMPLEO <> -1 Then
                Me.SECTOR_EMPLEORadioButtonList.Value = CInt(.SECTOR_EMPLEO)
            End If

            If .TRABAJO_ANTERIOR <> "" Then
                TRABAJO_ANTERIORRadioButtonList.Value = .TRABAJO_ANTERIOR
                If .TRABAJO_ANTERIOR = "S" Then
                    'Cargar información del trabajo anterior
                    Dim listaTrabAnt As New listaSOLIC_EMPLEO_ANTERIOR
                    listaTrabAnt = (New cSOLIC_EMPLEO_ANTERIOR).ObtenerListaPorSOLICITUD_INSCRIPCION_AF(.ID_SOLICITUD)
                    If listaTrabAnt IsNot Nothing AndAlso listaTrabAnt.Count > 0 Then
                        Me.TIEMPO_NO_TRABAJARadioButtonList1.Value = CInt(listaTrabAnt(0).TIEMPO_NO_TRABAJA)
                    End If
                End If
            End If

            If .RECIBE_INGRESOS = 1 Then
                Me.RECIBE_INGRESOSRadioButtonList.Value = 1
            ElseIf .RECIBE_INGRESOS = 2 Then
                Me.RECIBE_INGRESOSRadioButtonList.Value = 2
            End If

            Me.MANERA_OBT_ING_TRABAJOchk.Checked = (.MANERA_OBT_ING_TRABAJO = 1)
            Me.MANERA_OBT_ING_PENSIONchk.Checked = (.MANERA_OBT_ING_PENSION = 1)
            Me.MANERA_OBT_ING_REMESAchk.Checked = (.MANERA_OBT_ING_REMESA = 1)
            Me.MANERA_OBT_ING_OTRAchk.Checked = (.MANERA_OBT_ING_OTRO <> "")
            Me.MANERA_OBT_ING_OTRAtxt.Text = .MANERA_OBT_ING_OTRO
            Me.MANERA_OBT_ING_AYUDA_FAMchk.Checked = (.MANERA_OBT_ING_AYUDA_FAM = 1)

            Me.EXPFOR_PROMOCION_EMPLEOchk.Checked = (.EXPFOR_PROMOCION_EMPLEO = 1)
            Me.EXPFOR_INGRESOS_EXTRAchk.Checked = (.EXPFOR_INGRESOS_EXTRAS = 1)
            Me.EXPFOR_RELACION_EMPLEOchk.Checked = (.EXPFOR_CAMBIAR_EMPLEO = 1)
            Me.EXPFOR_OTROchk.Checked = (.EXPFOR_OTRO <> "")
            Me.EXPFOR_OBTENER_EMPLEOchk.Checked = (.EXPFOR_OBTENER_EMPLEO = 1)
            Me.EXPFOR_NINGUNOchk.Checked = (.EXPFOR_NINGUNO = 1)
            Me.EXPFOR_TRABAJAR_CTA_PROPIAchk.Checked = (.EXPFOR_TRABAJAR_CTA_PROPIA = 1)
            Me.EXPFOR_OTROtxt.Text = .EXPFOR_OTRO

            If .CURSO_REL_TRAB_ACTUAL = 1 Then
                Me.CURSO_REL_TRABRadioButtonList.Value = 1
            ElseIf .CURSO_REL_TRAB_NUEVO = 1 Then
                Me.CURSO_REL_TRABRadioButtonList.Value = 2
            End If

            Me.NOMBRE_FAMILIARtxt.Text = .NOMBRE_REFERENCIA
            Me.CargarParentesco()
            Me.SeleccionarElemento(Me.ID_PARENTESCOcbx, CInt(.ID_REFERENCIA))
            Me.DIRECCION_FAMILIARtxt.Text = .DIRECCION_REFERENCIA
            Me.CargarDepartamentos(CODIGO_DEPARTAMENTO_FAMcbx)
            Me.CODIGO_DEPARTAMENTO_FAMcbx.Value = .DEPARTAMENTO_REFERENCIA
            Me.CargarMunicipios(Me.odsCODIGO_MUNICIPIO_FAMcbx, CODIGO_MUNICIPIO_FAMcbx, .DEPARTAMENTO_REFERENCIA)
            Me.CODIGO_MUNICIPIO_FAMcbx.Value = .MUNICIPIO_REFERENCIA
            SeleccionarElemento(CODIGO_MUNICIPIO_FAMcbx, .MUNICIPIO_REFERENCIA)
            Me.TELEFONO_FAMILIARtxt.Text = .TELEFONO_REFERENCIA
            Me.MOVIL_FAMILIARtxt.Text = .MOVIL_REFERENCIA
            Me.EMAIL_FAMILIARtxt.Text = .EMAIL_REFERENCIA
            Me.SUGERENCIASMemo.Text = .SUGERENCIAS
        End With
        Me.Habilitar()
    End Sub

    Private Sub SeleccionarElemento(ByRef lista As DevExpress.Web.ASPxEditors.ASPxComboBox, ByVal valor As Object)
        Dim indice As Integer = lista.Items.IndexOfValue(valor)
        lista.SelectedIndex = indice
    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <returns>2
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	02/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        mEntidad = New SOLICITUD_INSCRIPCION_AF

        Dim sResumeError As New StringBuilder
        Dim sError As New StringBuilder
        If Me.ID_PARTICIPANTEtxt.Text <> "" Then
            'Se ha seleccionado un participante, verificar que si ya tenía DUI/NIT estos no se hayan cambiado, ni tampoco los Nombres y Apellidos
            Dim lEntidadPart As PARTICIPANTE = (New cPARTICIPANTE).ObtenerPARTICIPANTE(CDec(Me.ID_PARTICIPANTEtxt.Text))
            If lEntidadPart IsNot Nothing Then
                If lEntidadPart.DUI <> String.Empty AndAlso lEntidadPart.DUI <> Me.DUItxt.Text Then
                    sError.Append("* No se puede cambiar el DUI de un participante que ya existe.") : sError.Append("<br>")
                End If
                If lEntidadPart.NIT <> String.Empty AndAlso lEntidadPart.NIT <> Me.NITtxt.Text Then
                    sError.Append("* No se puede cambiar el NIT de un participante que ya existe.") : sError.Append("<br>")
                End If
            End If
        End If
        If Me.NOMBREStxt.Text.Trim = "" Or Me.APELLIDOStxt.Text.Trim = "" Then
            sError.Append("* Nombres y Apellidos son requeridos.") : sError.Append("<br>")
        End If
        If Me.NACIONALIDADRadioButtonList.Value Is Nothing Then
            sError.Append("* Nacionalidad es requerido.") : sError.Append("<br>")
        End If
        If Me.NACIONALIDADRadioButtonList.Value = 2 And ID_PAIScbx.Value Is Nothing Then
            sError.Append("* País es requerido.") : sError.Append("<br>")
        ElseIf Me.NACIONALIDADRadioButtonList.Value = 2 And ID_PAIScbx.Value = 57 Then
            sError.Append("* Seleccione otro País si es extranjero.") : sError.Append("<br>")
        End If
        If Me.DUItxt.Text.Length > 0 And Me.DUItxt.Text.Length < 9 Then
            sError.Append("* DUI no válido.") : sError.Append("<br>")
        End If
        If Me.NITtxt.Text.Length > 0 And Me.NITtxt.Text.Length < 14 Then
            sError.Append("* NIT no válido.") : sError.Append("<br>")
        End If
        If Me.NACIONALIDADRadioButtonList.Value IsNot Nothing AndAlso _
           Me.NACIONALIDADRadioButtonList.Value = 2 AndAlso _
           Me.DUItxt.Text.Trim = "" AndAlso Me.NITtxt.Text.Trim = "" AndAlso _
           Me.PASAPORTEtxt.Text.Trim = "" AndAlso Me.NUM_DOCTOtxt.Text.Trim = "" Then
            sError.Append("* DUI, NIT, Pasaporte u otro documento son requeridos.") : sError.Append("<br>")
        End If
        If Me.NACIONALIDADRadioButtonList.Value IsNot Nothing AndAlso _
           Me.NACIONALIDADRadioButtonList.Value = 1 AndAlso Me.DEPARTAMENTO_NACcbx.Value Is Nothing Then
            sError.Append("* Departamento de nacimiento es requerido.") : sError.Append("<br>")
        End If
        If Me.NACIONALIDADRadioButtonList.Value IsNot Nothing AndAlso _
           Me.NACIONALIDADRadioButtonList.Value = 1 AndAlso MUNICIPIO_NACcbx.Value = "" Then
            sError.Append("* Municipio de nacimiento es requerido.") : sError.Append("<br>")
        End If
        If Not IsDate(Me.FECHA_NACIMIENTODateEdit.Date) Then
            sError.Append("* Fecha de nacimiento no válida.") : sError.Append("<br>")
        End If
        If Me.GENERORadioButtonList.Value Is Nothing Then
            sError.Append("* Sexo es requerido.") : sError.Append("<br>")
        End If
        If IsNumeric(Me.EDADtxt.Text.Trim) AndAlso (Decimal.Parse(Me.EDADtxt.Text) < 10 Or Decimal.Parse(Me.EDADtxt.Text) > 100) Then
            sError.Append("* Fecha de nacimiento no válida.") : sError.Append("<br>")
        End If
        If Me.MIEMBROS_GRUPO_FAMILIAspn.Value Is Nothing OrElse CInt(Me.MIEMBROS_GRUPO_FAMILIAspn.Value) <= 0 Then
            sError.Append("* Cantidad de personas del grupo familiar es requerido.") : sError.Append("<br>")
        End If
        If Me.ESTADO_CIVILRadioButtonList.Value Is Nothing Then
            sError.Append("* Estado familiar es requerido.") : sError.Append("<br>")
        End If
        If Me.ES_JEFE_HOGARRadioButotonList.Value Is Nothing Then
            sError.Append("* Jefe(a) de hogar es requerido.") : sError.Append("<br>")
        End If
        If Me.TIENE_HIJOSRadioButtonList.Value Is Nothing Then
            sError.Append("* Tiene hijos es requerido.") : sError.Append("<br>")
        ElseIf Me.TIENE_HIJOSRadioButtonList.Value = 1 AndAlso _
           Me.NO_DE_HIJOStxt.Text = "" Then
            sError.Append("* N° de hijos es requerido.") : sError.Append("<br>")
        End If
        If PROFESION_OFICIORadioButtonList.Value IsNot Nothing AndAlso _
           PROFESION_OFICIORadioButtonList.Value = 1 AndAlso _
           PROFESION_OFICIOtxt.Text.Trim = "" Then
            sError.Append("* Profesión u oficio es requerido.") : sError.Append("<br>")
        End If
        If DIRECCIONtxt.Text.Trim = "" Then
            sError.Append("* Dirección de domicilio es requerido.") : sError.Append("<br>")
        End If
        If CODIGO_DEPARTAMENTOcbx.Value Is Nothing Then
            sError.Append("* Departamento de domicilio es requerido.") : sError.Append("<br>")
        End If
        If Me.TELEFONOtxt.Text.Trim = "" AndAlso Me.MOVILtxt.Text.Trim = "" Then
            sError.Append("* Teléfono fijo o móvil es requerido.") : sError.Append("<br>")
        End If
        If CODIGO_MUNICIPIOcbx.Value Is Nothing Then
            sError.Append("* Municipio de domicilio es requerido.") : sError.Append("<br>")
        End If
        If CON_DISCAPACIDADRadioButtonList.Value Is Nothing Then
            sError.Append("* Si es discapacitado o no es requerido.") : sError.Append("<br>")
        ElseIf CON_DISCAPACIDADRadioButtonList.Value = 1 AndAlso _
            Not (DISC_MOVERSE_CAMINARchk.Checked Or DISC_HABLARchk.Checked Or DISC_BRAZOS_MANOSchk.Checked Or DISC_RETRASOchk.Checked Or _
             DISC_VERchk.Checked Or DISC_BAN_VESTIR_ALIMchk.Checked Or DISC_OIRchk.Checked Or DISC_OTRAchk.Checked) Then
            sError.Append("* Alguna discapacidad es requerida.") : sError.Append("<br>")
        End If
        If DISC_OTRAchk.Checked AndAlso DISC_OTRAtxt.Text.Trim = "" Then
            sError.Append("* Otro tipo de discapacidad es requerido.") : sError.Append("<br>")
        End If

        If sError.Length > 0 Then
            sError.Insert(0, "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>SECCION 1. DATOS DE IDENTIFICACION</b><br>", 1)
            sError.Append("<div>")
            sError.Insert(0, "<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;"">LOS SIGUIENTES CAMPOS SON REQUERIDOS:</div><br>")
        End If


        sResumeError.Append(sError)
        sError = New StringBuilder

        If SABE_LEER_ESCRIBIRRadioButtonList.Value Is Nothing Then
            sError.Append("* Si sabe leer y escribir es requerido.") : sError.Append("<br>")
        ElseIf SABE_LEER_ESCRIBIRRadioButtonList.Value = 2 AndAlso SOLO_LEE_ESCRIBERadioButtonList.Value Is Nothing AndAlso Not EDUCACION_FORMAL_SOLO_FIRMAchk.Checked Then
            sError.Append("* Sólo lee/Sólo escribe/Solo Firma es requerido.") : sError.Append("<br>")
        End If
        If Not (EDUCACION_BASICArdb.Value Or BACHILLERATOrdb.Value Or TECNOLOGICArdb.Value Or UNIVERSITARIArdb.Value) Then
            sError.Append("* Último grado de estudio finalizado es requerido.") : sError.Append("<br>")
        Else
            Select Case True
                Case EDUCACION_BASICArdb.Value
                    If EDUCACION_BASICARadioButtonList.Value Is Nothing Then sError.Append("* Grado de Educación Básica es requerido.") : sError.Append("<br>")
                Case BACHILLERATOrdb.Value
                    If BACHILLERATORadioButtonList.Value Is Nothing Then sError.Append("* Bachillerato completa/incompleta es requerido.") : sError.Append("<br>")
                Case TECNOLOGICArdb.Value
                    If TECNOLOGICARadioButtonList.Value Is Nothing Then sError.Append("* Tecnologica completa/incompleta es requerido.") : sError.Append("<br>")
                Case UNIVERSITARIArdb.Value
                    If UNIVERSITARIARadioButtonList.Value Is Nothing Then sError.Append("* Universitaria completa/incompleta es requerido.") : sError.Append("<br>")
            End Select
        End If
        If OTRA_EDUCACION_FORMALchk.Checked AndAlso OTRA_EDUCACION_FORMALtxt.Text.Trim = "" Then
            sError.Append("* Otra educación formal es requerida.") : sError.Append("<br>")
        End If
        If TITULO_CERTIFICADO_OBTENIDOchk.Checked AndAlso TITULO_CERTIFICADO_OBTENIDOtxt.Text.Trim = "" Then
            sError.Append("* Título o Certificado obtenido es requerido.") : sError.Append("<br>")
        End If
        If ESTUDIA_ACTUALMENTERadioButtonlist.Value Is Nothing Then
            sError.Append("* Estudia actualmente es requerido.") : sError.Append("<br>")
        ElseIf ESTUDIA_ACTUALMENTERadioButtonlist.Value = 2 AndAlso TIEMPO_DEJO_ESTUDIARRadioButtonList.Value Is Nothing Then
            sError.Append("* Hace cuánto tiempo dejó de estudiar es requerido.") : sError.Append("<br>")
        End If
        If RECIBIO_CURSO_ANTERIORRadioButtonList.Value Is Nothing Then
            sError.Append("* Recibió antes algún(os) curso(s) de capacitación es requerido.") : sError.Append("<br>")
        ElseIf RECIBIO_CURSO_ANTERIORRadioButtonList.Value = 1 Then
            If CURSO1txt.Text.Trim = "" AndAlso CURSO2txt.Text.Trim = "" AndAlso CURSO3txt.Text.Trim = "" AndAlso _
               IMPARTIO_INSAFORP1ButtonList.Value Is Nothing AndAlso IMPARTIO_INSAFORP2ButtonList.Value Is Nothing AndAlso IMPARTIO_INSAFORP3ButtonList.Value Is Nothing AndAlso _
               ANIO1txt.Text.Trim = "" AndAlso ANIO2txt.Text.Trim = "" AndAlso ANIO3txt.Text.Trim = "" AndAlso _
               CURSO_DIO_BENEFICIOS1ButtonList.Value Is Nothing AndAlso CURSO_DIO_BENEFICIOS2ButtonList.Value Is Nothing AndAlso CURSO_DIO_BENEFICIOS3ButtonList.Value Is Nothing Then
                sError.Append("* Al menos un curso recibido es requerido.") : sError.Append("<br>")
            Else
                'Validar el curso uno si se ha ingresado información debe estar completa
                If (CURSO1txt.Text.Trim <> "" Or _
                    IMPARTIO_INSAFORP1ButtonList.Value IsNot Nothing Or _
                    ANIO1txt.Text.Trim <> "" Or _
                    CURSO_DIO_BENEFICIOS1ButtonList.Value IsNot Nothing) AndAlso _
                    (CURSO1txt.Text.Trim = "" Or _
                    IMPARTIO_INSAFORP1ButtonList.Value Is Nothing Or _
                    ANIO1txt.Text.Trim = "" Or _
                    CURSO_DIO_BENEFICIOS1ButtonList.Value Is Nothing) Then
                    sError.Append("* La información del primer curso recibido está incompleta.") : sError.Append("<br>")
                End If
                'Validar el curso dos si se ha ingresado información debe estar completa
                If (CURSO2txt.Text.Trim <> "" Or _
                    IMPARTIO_INSAFORP2ButtonList.Value IsNot Nothing Or _
                    ANIO2txt.Text.Trim <> "" Or _
                    CURSO_DIO_BENEFICIOS2ButtonList.Value IsNot Nothing) AndAlso _
                    (CURSO2txt.Text.Trim = "" Or _
                    IMPARTIO_INSAFORP2ButtonList.Value Is Nothing Or _
                    ANIO2txt.Text.Trim = "" Or _
                    CURSO_DIO_BENEFICIOS2ButtonList.Value Is Nothing) Then
                    sError.Append("* La información del segundo curso recibido está incompleta.") : sError.Append("<br>")
                End If
                'Validar el curso tres si se ha ingresado información debe estar completa
                If (CURSO3txt.Text.Trim <> "" Or _
                    IMPARTIO_INSAFORP3ButtonList.Value IsNot Nothing Or _
                    ANIO3txt.Text.Trim <> "" Or _
                    CURSO_DIO_BENEFICIOS3ButtonList.Value IsNot Nothing) AndAlso _
                    (CURSO3txt.Text.Trim = "" Or _
                    IMPARTIO_INSAFORP3ButtonList.Value Is Nothing Or _
                    ANIO3txt.Text.Trim = "" Or _
                    CURSO_DIO_BENEFICIOS3ButtonList.Value Is Nothing) Then
                    sError.Append("* La información del tercer curso recibido está incompleta.") : sError.Append("<br>")
                End If

                If (CURSO_DIO_BENEFICIOS1ButtonList.Value = 1 OrElse _
                   CURSO_DIO_BENEFICIOS2ButtonList.Value = 1 OrElse _
                   CURSO_DIO_BENEFICIOS3ButtonList.Value = 1) AndAlso _
                   (Not BENEF_OBT_EMPLEOchk.Checked AndAlso _
                    Not BENEF_CAMB_EMP_X_CURSOchk.Checked AndAlso _
                    Not BENEF_TRAB_CTA_PROPIAchk.Checked AndAlso _
                    Not BENEF_ING_EXTRAchk.Checked AndAlso _
                    Not BENEF_PROM_EMP_ACTchk.Checked AndAlso _
                    Not BENEF_OTROchk.Checked) Then
                    sError.Append("* Para que sirvió la(s) capacitación(es) que recibió es requerido.") : sError.Append("<br>")
                End If

                If BENEF_OTROchk.Checked AndAlso BENEF_OTROtxt.Text.Trim = "" Then
                    sError.Append("* Otra razón de para que sirvió(eron) la(s) capacitación(es) es requerido.") : sError.Append("<br>")
                End If

                If (CURSO_DIO_BENEFICIOS1ButtonList.Value = 2 OrElse _
                   CURSO_DIO_BENEFICIOS2ButtonList.Value = 2 OrElse _
                   CURSO_DIO_BENEFICIOS3ButtonList.Value = 2) AndAlso _
                   (RAZON_NO_BENEFICIOtxt.Text.Trim = "") Then
                    sError.Append("* Por qué cree que no recibió beneficio de la(s) capacitación(es) que recibió es requerido.") : sError.Append("<br>")
                End If
            End If
        End If

        If sResumeError.Length > 0 AndAlso sError.Length > 0 Then
            sError.Insert(0, "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>SECCION 2. EDUCACIÓN FORMAL Y FORMACIÓN OCUPACIONAL</b><br>", 1)
            sError.Append("<div>")
        ElseIf sError.Length > 0 Then
            sError.Insert(0, "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>SECCION 2. EDUCACIÓN FORMAL Y FORMACIÓN OCUPACIONAL</b><br>", 1)
            sError.Append("<div>")
            sError.Insert(0, "<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;"">LOS SIGUIENTES CAMPOS SON REQUERIDOS:</div><br>")
        End If

        sResumeError.Append(sError)
        sError = New StringBuilder

        If Not OCUACT_BUSCA_TRABAJOchk.Checked AndAlso Not OCUACT_ESTUDIAchk.Checked AndAlso _
           Not OCUACT_OFICIO_HOGARchk.Checked AndAlso Not OCUACT_OTRAchk.Checked AndAlso _
           Not OCUACT_TRABAJAchk.Checked Then
            sError.Append("* A que actividad se dedica actualmente es requerido.") : sError.Append("<br>")
        ElseIf OCUACT_OTRAchk.Checked AndAlso OCUACT_OTRAtxt.Text.Trim = "" Then
            sError.Append("* Ingrese otra actividad a la que se dedica actualmente.") : sError.Append("<br>")
        End If

        If OCUACT_TRABAJAchk.Checked AndAlso TIPO_EMPLEORadioButtonList.Value Is Nothing Then
            sError.Append("* Tipo de trabajo que tiene es requerido.") : sError.Append("<br>")
        End If
        If TIPO_EMPLEORadioButtonList.Value = 7 AndAlso Me.TIEMP_OTROtxt.Text.Trim = "" Then
            sError.Append("* Otro tipo de empleo es requerido.") : sError.Append("<br>")
        End If
        If (TIPO_EMPLEORadioButtonList.Value = 1 OrElse TIPO_EMPLEORadioButtonList.Value = 2 OrElse TIPO_EMPLEORadioButtonList.Value = 3) AndAlso SECTOR_EMPLEORadioButtonList.Value Is Nothing Then
            sError.Append("* En qué Sector trabaja es requerido.") : sError.Append("<br>")
        End If
        If TRABAJO_ANTERIORRadioButtonList.Value Is Nothing AndAlso Not OCUACT_TRABAJAchk.Checked Then
            sError.Append("* Si ha trabajado antes es requerido.") : sError.Append("<br>")
        ElseIf TRABAJO_ANTERIORRadioButtonList.Value = "S" AndAlso TIEMPO_NO_TRABAJARadioButtonList1.Value Is Nothing Then
            sError.Append("* Cuanto tiempo hace que no trabaja es requerido.") : sError.Append("<br>")
        End If

        If sResumeError.Length > 0 AndAlso sError.Length > 0 Then
            sError.Insert(0, "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>SECCION 3. INFORMACIÓN SOBRE SU SITUACIÓN LABORAL</b><br>", 1)
            sError.Append("<div>")
        ElseIf sError.Length > 0 Then
            sError.Insert(0, "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>SECCION 3. INFORMACIÓN SOBRE SU SITUACIÓN LABORAL</b><br>", 1)
            sError.Append("<div>")
            sError.Insert(0, "<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;"">LOS SIGUIENTES CAMPOS SON REQUERIDOS:</div><br>")
        End If

        sResumeError.Append(sError)
        sError = New StringBuilder

        If RECIBE_INGRESOSRadioButtonList.Value Is Nothing Then
            sError.Append("* Usted recibe ingresos es requerido.") : sError.Append("<br>")
        ElseIf RECIBE_INGRESOSRadioButtonList.Value = 1 AndAlso _
            (Not MANERA_OBT_ING_TRABAJOchk.Checked AndAlso Not MANERA_OBT_ING_PENSIONchk.Checked AndAlso Not MANERA_OBT_ING_REMESAchk.Checked AndAlso _
             Not MANERA_OBT_ING_OTRAchk.Checked AndAlso Not MANERA_OBT_ING_AYUDA_FAMchk.Checked) Then
            sError.Append("* Manera en que obtiene el ingreso es requerido.") : sError.Append("<br>")
        End If
        If MANERA_OBT_ING_OTRAchk.Checked And MANERA_OBT_ING_OTRAtxt.Text.Trim = "" Then
            sError.Append("* Ingrese otra manera en que obtiene el ingreso.") : sError.Append("<br>")
        End If

        If sResumeError.Length > 0 AndAlso sError.Length > 0 Then
            sError.Insert(0, "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>SECCION 4. INFORMACIÓN SOBRE LOS INGRESOS</b><br>", 1)
            sError.Append("<div>")
        ElseIf sError.Length > 0 Then
            sError.Insert(0, "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>SECCION 4. INFORMACIÓN SOBRE LOS INGRESOS</b><br>", 1)
            sError.Append("<div>")
            sError.Insert(0, "<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;"">LOS SIGUIENTES CAMPOS SON REQUERIDOS:</div><br>")
        End If

        sResumeError.Append(sError)
        sError = New StringBuilder

        If Not EXPFOR_PROMOCION_EMPLEOchk.Checked AndAlso _
            Not EXPFOR_INGRESOS_EXTRAchk.Checked AndAlso _
            Not EXPFOR_RELACION_EMPLEOchk.Checked AndAlso _
            Not EXPFOR_OTROchk.Checked AndAlso _
            Not EXPFOR_OBTENER_EMPLEOchk.Checked AndAlso _
            Not EXPFOR_NINGUNOchk.Checked AndAlso _
            Not EXPFOR_TRABAJAR_CTA_PROPIAchk.Checked Then
            sError.Append("* Qué espera lograr con la capacitación a recibir es requerido.") : sError.Append("<br>")
        End If
        If CURSO_REL_TRABRadioButtonList.Value Is Nothing Then
            sError.Append("* Pertinencia del curso con su ocupación actual es requerido.") : sError.Append("<br>")
        End If

        If sResumeError.Length > 0 AndAlso sError.Length > 0 Then
            sError.Insert(0, "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>SECCION 5. EXPECTATIVA Y PERTINENCIA DE LA FORMACIÓN</b><br>", 1)
            sError.Append("<div>")
        ElseIf sError.Length > 0 Then
            sError.Insert(0, "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>SECCION 5. EXPECTATIVA Y PERTINENCIA DE LA FORMACIÓN</b><br>", 1)
            sError.Append("<div>")
            sError.Insert(0, "<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;"">LOS SIGUIENTES CAMPOS SON REQUERIDOS:</div><br>")
        End If

        sResumeError.Append(sError)
        sError = New StringBuilder

        If TELEFONO_FAMILIARtxt.Text.Trim = "" AndAlso MOVIL_FAMILIARtxt.Text.Trim = "" Then
            sError.Append("* Teléfono fijo o móvil del familiar/amigo es requerido.") : sError.Append("<br>")
        End If
        If sResumeError.Length > 0 AndAlso sError.Length > 0 Then
            sError.Insert(0, "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>SECCION 6. SEGUIMIENTO</b><br>", 1)
            sError.Append("<div>")
        ElseIf sError.Length > 0 Then
            sError.Insert(0, "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>SECCION 6. SEGUIMIENTO</b><br>", 1)
            sError.Append("<div>")
            sError.Insert(0, "<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;"">LOS SIGUIENTES CAMPOS SON REQUERIDOS:</div><br>")
        End If

        sResumeError.Append(sError)
        sError = New StringBuilder

        If sResumeError.Length > 0 Then Return sResumeError.ToString



        '   Seteando la Entidad
        If ID_SOLICITUDtxt.Text <> "" Then
            mEntidad.ID_SOLICITUD = Decimal.Parse(ID_SOLICITUDtxt.Text)
            mEntidad.ID_TIPO_SOLICITUD = Decimal.Parse(Me.ID_TIPO_SOLICITUDtxt.Text)
            mEntidad.ID_ESTADO_SOLICITUD = Decimal.Parse(Me.ID_ESTADO_SOLICITUDtxt.Text)
        Else
            mEntidad.ID_SOLICITUD = 0
            Dim lEntidadAFDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(Decimal.Parse(Me.ID_ACCION_FORMATIVAtxt.Text))
            mEntidad.ID_TIPO_SOLICITUD = Utilerias.ObtenerTipoSolicitudPorProgramaFormacion(CInt(lEntidadAFDetalle.ID_PROGRAMA_FORMACION))
            mEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.EnEsperaDeAprobacion
        End If
        With mEntidad
            .FECHA_PRESENTACION = FECHA_PRESENTACIONDateEdit.Date
            .ID_ACCION_FORMATIVA = Decimal.Parse(Me.ID_ACCION_FORMATIVAtxt.Text)

            If Me.ID_PARTICIPANTEtxt.Text <> "" Then .ID_PARTICIPANTE = CDec(Me.ID_PARTICIPANTEtxt.Text)

            '   ***     SECCIÓN 1. DATOS DE IDENTIFICACIÓN
            .NOMBRES = NOMBREStxt.Text.Trim.ToUpper
            .APELLIDOS = APELLIDOStxt.Text.Trim.ToUpper
            .DUI = DUItxt.Text
            .NIT = NITtxt.Text
            .ISSS = ISSStxt.Text.Trim.ToUpper
            If Me.CARNET_MINORIDADtxt.Text <> "" Then
                .NUM_DOCTO = CARNET_MINORIDADtxt.Text.Trim.ToUpper
                .TIPO_DOCTO = 1
            ElseIf PASAPORTEtxt.Text <> "" Then
                .NUM_DOCTO = PASAPORTEtxt.Text.Trim.ToUpper
                .TIPO_DOCTO = 2
            ElseIf NUM_DOCTOtxt.Text <> "" Then
                .NUM_DOCTO = NUM_DOCTOtxt.Text.Trim.ToUpper
                .TIPO_DOCTO = 3
            Else
                .TIPO_DOCTO = -1
            End If
            .ID_PAIS = ID_PAIScbx.Value
            If Me.NACIONALIDADRadioButtonList.Value = 1 Then
                .DEPARTAMENTO_NAC = DEPARTAMENTO_NACcbx.Value
                .MUNICIPIO_NAC = (New cMUNICIPIO).ObtenerMUNICIPIO(DEPARTAMENTO_NACcbx.Value, MUNICIPIO_NACcbx.Value).CODIGO_MUNICIPIO
            Else
                .DEPARTAMENTO_NAC = ""
                .MUNICIPIO_NAC = ""
            End If
            .FECHA_NACIMIENTO = FECHA_NACIMIENTODateEdit.Date
            If GENERORadioButtonList.Value = 1 Then
                .GENERO = "M"
            Else
                .GENERO = "F"
            End If
            .EDAD = Decimal.Parse(EDADtxt.Text)
            .MIEMBROS_GRUPO_FAMILIAR = CDec(MIEMBROS_GRUPO_FAMILIAspn.Value)
            .ID_ESTADO_CIVIL = ESTADO_CIVILRadioButtonList.Value
            .ES_JEFE_HOGAR = ES_JEFE_HOGARRadioButotonList.Value
            .TIENE_HIJOS = TIENE_HIJOSRadioButtonList.Value
            If .TIENE_HIJOS = 1 Then .NO_DE_HIJOS = Decimal.Parse(NO_DE_HIJOStxt.Text.Trim) Else .NO_DE_HIJOS = -1
            If PROFESION_OFICIORadioButtonList.Value Is Nothing Then .SE_DEDICA_ALGUNA_PROFESION = -1 Else .SE_DEDICA_ALGUNA_PROFESION = PROFESION_OFICIORadioButtonList.Value
            .PROFESION_OFICIO = PROFESION_OFICIOtxt.Text.Trim.ToUpper
            .DIRECCION = DIRECCIONtxt.Text.Trim.ToUpper
            .CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTOcbx.Value
            .CODIGO_MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(CODIGO_DEPARTAMENTOcbx.Value, CODIGO_MUNICIPIOcbx.Value).CODIGO_MUNICIPIO
            .TELEFONO = TELEFONOtxt.Text.Trim
            .MOVIL = MOVILtxt.Text.Trim
            .EMAIL = EMAILtxt.Text.Trim.ToLower
            .CON_DISCAPACIDAD = CON_DISCAPACIDADRadioButtonList.Value
            .DISCA_POR_SOLICITUDSOLICITUD_INSCRIPCION_AF = AsignarDiscapacidadesSeleccionadas()
            .DISC_OTRA = DISC_OTRAtxt.Text.Trim.ToUpper

            '   ***     SECCIÓN 2. EDUCACIÓN FORMAL Y FORMACIÓN OCUPACIONAL
            If SABE_LEER_ESCRIBIRRadioButtonList.Value = 1 Then
                .ID_LEE_ESCRIBE = 1
            ElseIf SOLO_LEE_ESCRIBERadioButtonList.Value = 1 Then
                If EDUCACION_FORMAL_SOLO_FIRMAchk.Checked Then .ID_LEE_ESCRIBE = 5 Else .ID_LEE_ESCRIBE = 2
            ElseIf SOLO_LEE_ESCRIBERadioButtonList.Value = 2 Then
                If EDUCACION_FORMAL_SOLO_FIRMAchk.Checked Then .ID_LEE_ESCRIBE = 6 Else .ID_LEE_ESCRIBE = 3
            ElseIf EDUCACION_FORMAL_SOLO_FIRMAchk.Checked Then
                .ID_LEE_ESCRIBE = 4
            End If

            Select Case True
                Case EDUCACION_BASICArdb.Checked
                    .ID_NIVEL_ACADEMICO = EDUCACION_BASICARadioButtonList.Value
                Case BACHILLERATOrdb.Checked
                    .ID_NIVEL_ACADEMICO = BACHILLERATORadioButtonList.Value
                Case TECNOLOGICArdb.Checked
                    .ID_NIVEL_ACADEMICO = TECNOLOGICARadioButtonList.Value
                Case UNIVERSITARIArdb.Checked
                    .ID_NIVEL_ACADEMICO = UNIVERSITARIARadioButtonList.Value
            End Select

            .OTRA_EDUCACION_FORMAL = OTRA_EDUCACION_FORMALtxt.Text.Trim.ToUpper
            .TITULO_CERTIFICADO_OBTENIDO = TITULO_CERTIFICADO_OBTENIDOtxt.Text.Trim.ToUpper
            .ESTUDIA_ACTUALMENTE = ESTUDIA_ACTUALMENTERadioButtonlist.Value
            If ESTUDIA_ACTUALMENTERadioButtonlist.Value = 1 Then
                .ID_TIEMPO_DEJO_ESTUDIAR = -1
            Else
                If TIEMPO_DEJO_ESTUDIARRadioButtonList.Value Is Nothing Then .ID_TIEMPO_DEJO_ESTUDIAR = -1 Else .ID_TIEMPO_DEJO_ESTUDIAR = TIEMPO_DEJO_ESTUDIARRadioButtonList.Value
            End If
            .RECIBIO_CURSO_ANTERIOR = RECIBIO_CURSO_ANTERIORRadioButtonList.Value
            If BENEF_OBT_EMPLEOchk.Checked Then .BENEF_OBT_EMPLEO = 1 Else .BENEF_OBT_EMPLEO = 0
            If BENEF_TRAB_CTA_PROPIAchk.Checked Then .BENEF_TRAB_CTA_PROPIA = 1 Else .BENEF_TRAB_CTA_PROPIA = 0
            If BENEF_PROM_EMP_ACTchk.Checked Then .BENEF_PROM_EMP_ACT = 1 Else .BENEF_PROM_EMP_ACT = 0
            If BENEF_CAMB_EMP_X_CURSOchk.Checked Then .BENEF_CAMB_EMP_X_CURSO = 1 Else .BENEF_CAMB_EMP_X_CURSO = 0
            If BENEF_ING_EXTRAchk.Checked Then .BENEF_OBT_ING_EXTRA = 1 Else .BENEF_OBT_ING_EXTRA = 0
            .RAZON_NO_BENEFICIO = RAZON_NO_BENEFICIOtxt.Text.Trim.ToUpper


            '   ***     SECCIÓN 3. INFORMACIÓN SOBRE SU SITUACIÓN LABORAL
            If OCUACT_ESTUDIAchk.Checked Then .OCUACT_ESTUDIA = 1 Else .OCUACT_ESTUDIA = 0
            If OCUACT_OFICIO_HOGARchk.Checked Then .OCUACT_OFICIO_HOGAR = 1 Else .OCUACT_OFICIO_HOGAR = 0
            If OCUACT_TRABAJAchk.Checked Then .OCUACT_TRABAJA = 1 Else .OCUACT_TRABAJA = 0
            If OCUACT_BUSCA_TRABAJOchk.Checked Then .OCUACT_BUSCA_TRABAJO = 1 Else .OCUACT_BUSCA_TRABAJO = 0
            .OCUACT_OTRA = Me.OCUACT_OTRAtxt.Text.Trim.ToUpper

            If TIPO_EMPLEORadioButtonList.Value Is Nothing Then .ID_TIPO_EMPLEO = -1 Else .ID_TIPO_EMPLEO = TIPO_EMPLEORadioButtonList.Value
            .TIPO_EMPLEO_OTRO = Me.TIEMP_OTROtxt.Text.Trim.ToUpper
            If SECTOR_EMPLEORadioButtonList.Value Is Nothing Then .SECTOR_EMPLEO = -1 Else .SECTOR_EMPLEO = SECTOR_EMPLEORadioButtonList.Value

            If TRABAJO_ANTERIORRadioButtonList.Value IsNot Nothing Then .TRABAJO_ANTERIOR = TRABAJO_ANTERIORRadioButtonList.Value


            '   ***     SECCIÓN 4. INFORMACIÓN SOBRE LOS INGRESOS
            .RECIBE_INGRESOS = RECIBE_INGRESOSRadioButtonList.Value
            If Me.MANERA_OBT_ING_AYUDA_FAMchk.Checked Then .MANERA_OBT_ING_AYUDA_FAM = 1 Else .MANERA_OBT_ING_AYUDA_FAM = 0
            If Me.MANERA_OBT_ING_PENSIONchk.Checked Then .MANERA_OBT_ING_PENSION = 1 Else .MANERA_OBT_ING_PENSION = 0
            If Me.MANERA_OBT_ING_REMESAchk.Checked Then .MANERA_OBT_ING_REMESA = 1 Else .MANERA_OBT_ING_REMESA = 0
            If Me.MANERA_OBT_ING_TRABAJOchk.Checked Then .MANERA_OBT_ING_TRABAJO = 1 Else .MANERA_OBT_ING_TRABAJO = 0
            .MANERA_OBT_ING_OTRO = Me.MANERA_OBT_ING_OTRAtxt.Text.Trim.ToUpper

            '   ***     SECCIÓN 5. EXPECTATIVAS RESPECTO A LA FORMACIÓN - EXPECTATIVAS LABORALES
            If Me.EXPFOR_PROMOCION_EMPLEOchk.Checked Then .EXPFOR_PROMOCION_EMPLEO = 1 Else .EXPFOR_PROMOCION_EMPLEO = 0
            If Me.EXPFOR_RELACION_EMPLEOchk.Checked Then .EXPFOR_CAMBIAR_EMPLEO = 1 Else .EXPFOR_CAMBIAR_EMPLEO = 0
            If Me.EXPFOR_OBTENER_EMPLEOchk.Checked Then .EXPFOR_OBTENER_EMPLEO = 1 Else .EXPFOR_OBTENER_EMPLEO = 0
            If Me.EXPFOR_TRABAJAR_CTA_PROPIAchk.Checked Then .EXPFOR_TRABAJAR_CTA_PROPIA = 1 Else .EXPFOR_TRABAJAR_CTA_PROPIA = 0
            If Me.EXPFOR_INGRESOS_EXTRAchk.Checked Then .EXPFOR_INGRESOS_EXTRAS = 1 Else .EXPFOR_INGRESOS_EXTRAS = 0
            If Me.EXPFOR_NINGUNOchk.Checked Then .EXPFOR_NINGUNO = 1 Else .EXPFOR_NINGUNO = 0
            .EXPFOR_OTRO = Me.EXPFOR_OTROtxt.Text.Trim.ToUpper

            If Me.CURSO_REL_TRABRadioButtonList.Value = 1 Then
                .CURSO_REL_TRAB_ACTUAL = 1
            ElseIf Me.CURSO_REL_TRABRadioButtonList.Value = 2 Then
                .CURSO_REL_TRAB_NUEVO = 1
            End If

            '   ***     SECCIÓN 6. SEGUIMIENTO
            .NOMBRE_REFERENCIA = NOMBRE_FAMILIARtxt.Text.Trim.ToUpper
            .ID_REFERENCIA = ID_PARENTESCOcbx.SelectedItem.Value
            .DIRECCION_REFERENCIA = DIRECCION_FAMILIARtxt.Text.Trim.ToUpper
            .DEPARTAMENTO_REFERENCIA = CODIGO_DEPARTAMENTO_FAMcbx.SelectedItem.Value
            .MUNICIPIO_REFERENCIA = (New cMUNICIPIO).ObtenerMUNICIPIO(CODIGO_DEPARTAMENTO_FAMcbx.Value, CODIGO_MUNICIPIO_FAMcbx.Value).CODIGO_MUNICIPIO
            .TELEFONO_REFERENCIA = TELEFONO_FAMILIARtxt.Text.Trim
            .MOVIL_REFERENCIA = MOVIL_FAMILIARtxt.Text.Trim
            .EMAIL_REFERENCIA = EMAIL_FAMILIARtxt.Text.Trim.ToLower
            .SUGERENCIAS = SUGERENCIASMemo.Text.Trim.ToUpper
            .USERID = ObtenerUsuario()
            .LASTUPDATE = Now

            Me._CODIGO_ERROR = mComponente.ActualizarSOLICITUD_INSCRIPCION_AF(mEntidad, TipoConcurrencia.Pesimistica, Me.SUGERENCIASMemo.Text)
            If Me._CODIGO_ERROR <> 1 Then
                ExceptionManager.Publish(New Exception(mComponente.sError + vbCrLf + mComponente.sErrorTecnico))
                Return "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><center><b>Error al Guardar Solicitud.</b></center><br>" + _
                        mComponente.sError + "</div>"
            End If

            '       Discapacidades
            GuardarDiscapacidades()

            '       Cursos de capacitación recibidos
            GuardarCursoRecibidos()

            '       Empleo Anterior
            GuardarEmpleoAnterior()
        End With

        Return ""
    End Function

    Private Sub GuardarEmpleoAnterior()
        Dim bEmpleoAnterior As New cSOLIC_EMPLEO_ANTERIOR
        Dim eEmpleoAnterior As SOLIC_EMPLEO_ANTERIOR
        Dim listaEmpleoAnterior As listaSOLIC_EMPLEO_ANTERIOR = bEmpleoAnterior.ObtenerListaPorSOLICITUD_INSCRIPCION_AF(mEntidad.ID_SOLICITUD)


        If TRABAJO_ANTERIORRadioButtonList.Value IsNot Nothing AndAlso TRABAJO_ANTERIORRadioButtonList.SelectedItem.Value = "S" Then
            eEmpleoAnterior = New SOLIC_EMPLEO_ANTERIOR
            If listaEmpleoAnterior IsNot Nothing AndAlso listaEmpleoAnterior.Count > 0 Then
                eEmpleoAnterior = listaEmpleoAnterior(0)
            Else
                eEmpleoAnterior.ID_SOLICITUD = mEntidad.ID_SOLICITUD
                eEmpleoAnterior.ID_EMPLEO_ANT = 0
            End If
            eEmpleoAnterior.TIEMPO_NO_TRABAJA = TIEMPO_NO_TRABAJARadioButtonList1.SelectedItem.Value

            If bEmpleoAnterior.ActualizarSOLIC_EMPLEO_ANTERIOR(eEmpleoAnterior) <> 1 Then
                ExceptionManager.Publish(New Exception(mComponente.sError + vbCrLf + mComponente.sErrorTecnico))
                Me.AsignarMensaje("Error al Guardar Empleo Anterior. " + vbCrLf + mComponente.sError, True, True)
            End If
        Else
            If listaEmpleoAnterior IsNot Nothing Then
                For Each _EmpleoActual As SOLIC_EMPLEO_ANTERIOR In listaEmpleoAnterior
                    bEmpleoAnterior.EliminarSOLIC_EMPLEO_ANTERIOR(_EmpleoActual.ID_EMPLEO_ANT)
                Next
            End If
        End If
    End Sub

    Private Sub GuardarCursoRecibidos()
        Dim bCursos As New cSOLIC_CURSOS_RECIBIDOS
        Dim eCurso As SOLIC_CURSOS_RECIBIDOS
        Dim listaCursos As listaSOLIC_CURSOS_RECIBIDOS = bCursos.ObtenerListaPorSOLICITUD_INSCRIPCION_AF(mEntidad.ID_SOLICITUD)

        If listaCursos Is Nothing Then listaCursos = New listaSOLIC_CURSOS_RECIBIDOS
        If RECIBIO_CURSO_ANTERIORRadioButtonList.SelectedItem.Value Then
            If CURSO1txt.Text <> "" Then
                eCurso = New SOLIC_CURSOS_RECIBIDOS
                eCurso.ID_SOLICITUD = mEntidad.ID_SOLICITUD
                eCurso.NOMBRE_CURSO = CURSO1txt.Text.Trim.ToUpper
                eCurso.APOYO_INSAFORP = IMPARTIO_INSAFORP1ButtonList.SelectedItem.Value
                eCurso.ANIO = Decimal.Parse(ANIO1txt.Text)
                eCurso.BENEFICIO_CURSO = CURSO_DIO_BENEFICIOS1ButtonList.SelectedItem.Value
                If listaCursos.Count >= 1 Then
                    eCurso.ID_CURSO_RECIBIDO = listaCursos(0).ID_CURSO_RECIBIDO
                    listaCursos(0) = eCurso
                Else
                    listaCursos.Add(eCurso)
                End If
                If bCursos.ActualizarSOLIC_CURSOS_RECIBIDOS(listaCursos(0)) <> 1 Then
                    ExceptionManager.Publish(New Exception(mComponente.sError + vbCrLf + mComponente.sErrorTecnico))
                    Me.AsignarMensaje("Error al Guardar Curso Recibido. " + vbCrLf + mComponente.sError, True, True)
                End If
            Else
                If listaCursos.Count >= 1 Then bCursos.EliminarSOLIC_CURSOS_RECIBIDOS(listaCursos(0).ID_CURSO_RECIBIDO)
            End If
            If CURSO2txt.Text <> "" Then
                eCurso = New SOLIC_CURSOS_RECIBIDOS
                eCurso.ID_SOLICITUD = mEntidad.ID_SOLICITUD
                eCurso.NOMBRE_CURSO = CURSO2txt.Text.Trim.ToUpper
                eCurso.APOYO_INSAFORP = IMPARTIO_INSAFORP2ButtonList.SelectedItem.Value
                eCurso.ANIO = Decimal.Parse(ANIO2txt.Text)
                eCurso.BENEFICIO_CURSO = CURSO_DIO_BENEFICIOS2ButtonList.SelectedItem.Value
                If listaCursos.Count >= 2 Then
                    eCurso.ID_CURSO_RECIBIDO = listaCursos(1).ID_CURSO_RECIBIDO
                    listaCursos(1) = eCurso
                Else
                    listaCursos.Add(eCurso)
                End If
                If bCursos.ActualizarSOLIC_CURSOS_RECIBIDOS(listaCursos(1)) <> 1 Then
                    ExceptionManager.Publish(New Exception(mComponente.sError + vbCrLf + mComponente.sErrorTecnico))
                    Me.AsignarMensaje("Error al Guardar Curso Recibido. " + vbCrLf + mComponente.sError, True, True)
                End If
            Else
                If listaCursos.Count >= 2 Then bCursos.EliminarSOLIC_CURSOS_RECIBIDOS(listaCursos(1).ID_CURSO_RECIBIDO)
            End If
            If CURSO3txt.Text <> "" Then
                eCurso = New SOLIC_CURSOS_RECIBIDOS
                eCurso.ID_SOLICITUD = mEntidad.ID_SOLICITUD
                eCurso.NOMBRE_CURSO = CURSO3txt.Text.Trim.ToUpper
                eCurso.APOYO_INSAFORP = IMPARTIO_INSAFORP3ButtonList.SelectedItem.Value
                eCurso.ANIO = Decimal.Parse(ANIO3txt.Text)
                eCurso.BENEFICIO_CURSO = CURSO_DIO_BENEFICIOS3ButtonList.SelectedItem.Value
                If listaCursos.Count >= 3 Then
                    eCurso.ID_CURSO_RECIBIDO = listaCursos(2).ID_CURSO_RECIBIDO
                    listaCursos(2) = eCurso
                Else
                    listaCursos.Add(eCurso)
                End If
                If bCursos.ActualizarSOLIC_CURSOS_RECIBIDOS(listaCursos(2)) <> 1 Then
                    ExceptionManager.Publish(New Exception(mComponente.sError + vbCrLf + mComponente.sErrorTecnico))
                    Me.AsignarMensaje("Error al Guardar Curso Recibido. " + vbCrLf + mComponente.sError, True, True)
                End If
            Else
                If listaCursos.Count >= 3 Then bCursos.EliminarSOLIC_CURSOS_RECIBIDOS(listaCursos(2).ID_CURSO_RECIBIDO)
            End If

        Else
            For Each _Curso As SOLIC_CURSOS_RECIBIDOS In listaCursos
                If bCursos.EliminarSOLIC_CURSOS_RECIBIDOS(_Curso.ID_CURSO_RECIBIDO) <> 1 Then
                    ExceptionManager.Publish(New Exception(mComponente.sError + vbCrLf + mComponente.sErrorTecnico))
                    Me.AsignarMensaje("Error al Eliminar Curso Recibido. " + vbCrLf + mComponente.sError, True, True)
                End If
            Next
        End If
    End Sub

    Private Function AsignarDiscapacidadesSeleccionadas() As listaDISCA_POR_SOLICITUD
        Dim listaDiscapacidades As New listaDISCA_POR_SOLICITUD
        Dim DiscSeleccionada As Boolean

        For IdDiscap As Integer = 1 To 8
            Select Case IdDiscap
                Case 1
                    DiscSeleccionada = Me.DISC_MOVERSE_CAMINARchk.Checked
                Case 2
                    DiscSeleccionada = Me.DISC_BRAZOS_MANOSchk.Checked
                Case 3
                    DiscSeleccionada = Me.DISC_VERchk.Checked
                Case 4
                    DiscSeleccionada = Me.DISC_OIRchk.Checked
                Case 5
                    DiscSeleccionada = Me.DISC_HABLARchk.Checked
                Case 6
                    DiscSeleccionada = Me.DISC_RETRASOchk.Checked
                Case 7
                    DiscSeleccionada = Me.DISC_BAN_VESTIR_ALIMchk.Checked
                Case 8
                    DiscSeleccionada = Me.DISC_OTRAchk.Checked
                Case Else
                    DiscSeleccionada = False
            End Select

            If DiscSeleccionada Then
                Dim DiscapSolic As New DISCA_POR_SOLICITUD
                DiscapSolic.ID_SOLICITUD = mEntidad.ID_SOLICITUD
                DiscapSolic.ID_DISCAPACIDAD = IdDiscap

                listaDiscapacidades.Add(DiscapSolic)
            End If
        Next

        Return listaDiscapacidades
    End Function

    Private Sub GuardarDiscapacidades()
        Dim bDiscapacidadSolic As New cDISCA_POR_SOLICITUD

        'Setear el ID_SOLICITUD
        For Each _disca As DISCA_POR_SOLICITUD In mEntidad.DISCA_POR_SOLICITUDSOLICITUD_INSCRIPCION_AF
            _disca.ID_SOLICITUD = mEntidad.ID_SOLICITUD
        Next

        For IdDiscap As Integer = 1 To 8
            Dim eDiscapacidadSolic As New DISCA_POR_SOLICITUD
            eDiscapacidadSolic = mEntidad.DISCA_POR_SOLICITUDSOLICITUD_INSCRIPCION_AF.BuscarPorId(IdDiscap, mEntidad.ID_SOLICITUD)

            If eDiscapacidadSolic IsNot Nothing Then
                'Discapacidad seleccionada
                If bDiscapacidadSolic.ObtenerDISCA_POR_SOLICITUD(eDiscapacidadSolic) <> 1 Then
                    If bDiscapacidadSolic.AgregarDISCA_POR_SOLICITUD(eDiscapacidadSolic) <> 1 Then
                        ExceptionManager.Publish(New Exception(mComponente.sError + vbCrLf + mComponente.sErrorTecnico))
                        Me.AsignarMensaje("Error al Guardar Discapacidad. " + vbCrLf + mComponente.sError, True, True)
                    End If
                Else
                    If bDiscapacidadSolic.ActualizarDISCA_POR_SOLICITUD(eDiscapacidadSolic) <> 1 Then
                        ExceptionManager.Publish(New Exception(mComponente.sError + vbCrLf + mComponente.sErrorTecnico))
                        Me.AsignarMensaje("Error al Guardar Discapacidad. " + vbCrLf + mComponente.sError, True, True)
                    End If
                End If
            Else
                'Discapacidad no seleccionada, eliminarla si se encuentra asignada
                eDiscapacidadSolic = New DISCA_POR_SOLICITUD
                eDiscapacidadSolic.ID_DISCAPACIDAD = IdDiscap
                eDiscapacidadSolic.ID_SOLICITUD = mEntidad.ID_SOLICITUD
                If bDiscapacidadSolic.ObtenerDISCA_POR_SOLICITUD(eDiscapacidadSolic) = 1 Then
                    bDiscapacidadSolic.EliminarDISCA_POR_SOLICITUD(IdDiscap, mEntidad.ID_SOLICITUD)
                End If
            End If
        Next
    End Sub

    Public Sub CopiarDatosDomicilioParticipante()
        DIRECCION_FAMILIARtxt.Text = Left(DIRECCIONtxt.Text.Trim, 100)
        If CODIGO_DEPARTAMENTOcbx.Value IsNot Nothing Then
            CODIGO_DEPARTAMENTO_FAMcbx.Value = CODIGO_DEPARTAMENTOcbx.Value
            If CODIGO_MUNICIPIOcbx.Value IsNot Nothing Then
                CargarMunicipios(odsCODIGO_MUNICIPIO_FAMcbx, CODIGO_MUNICIPIO_FAMcbx, CODIGO_DEPARTAMENTOcbx.Value)
                CODIGO_MUNICIPIO_FAMcbx.Value = (New cMUNICIPIO).ObtenerMUNICIPIO(CODIGO_DEPARTAMENTO_FAMcbx.Value, CODIGO_MUNICIPIOcbx.Value).CODIGO_MUNICIPIO
                SeleccionarElemento(CODIGO_MUNICIPIO_FAMcbx, CODIGO_MUNICIPIO_FAMcbx.Value)
            End If
        End If
        Me.TELEFONO_FAMILIARtxt.Text = Left(Me.TELEFONOtxt.Text.Trim, 8)
    End Sub

#Region "Propiedades adicionales CallbackPanel"
    Dim _Tipo As String
    Public Property Tipo() As String
        Get
            Return _Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property

    Dim _Criterio As String
    Public Property Criterio() As String
        Get
            Return _Criterio
        End Get
        Set(ByVal value As String)
            _Criterio = value
        End Set
    End Property

    Protected Sub cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF.Callback
        Dim parametros() As String = e.Parameter.Split(";")
        Dim sResult As String = ""

        Select Case parametros(0)
            Case 0  'Inicializar campos del Formulario
                Me.Nuevo()

                'Case 1  'Guardar registro e Inicializar              
                '    sResult = Me.Actualizar()
                '    cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF.JSProperties("cpResultCallback") = sResult
                '    If sResult = "" Then
                '        Me.Nuevo()
                '        Me.Habilitar()
                '    End If

                'Case 2  'Guardar registro y seleccionar otro curso
                '    sResult = Me.Actualizar()
                '    cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF.JSProperties("cpResultCallback") = sResult
                '    If sResult = "" Then ASPxWebControl.RedirectOnCallback("wfConsultarDisponibilidadCursos.aspx")


                'Case 3  'Cargar datos del participante
                '    Me.ID_PARTICIPANTE = parametros(1)

                '    'Verificar si la cuota de capacitación del participante ha sobrepasado para el ejercicio actual
                '    Dim eAccionFormativa As ACCION_FORMATIVA
                '    eAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(Me.ID_ACCION_FORMATIVA)

                '    If eAccionFormativa.ID_ACCION_FORMATIVA > 0 Then
                '        Dim dt As New CursosRecibidosParticipanteDataTable
                '        Dim adapter As New CursosRecibidosParticipanteTableAdapter

                '        adapter.FillPorIDParticipanteEjercicio(dt, Me.ID_PARTICIPANTE, eAccionFormativa.ID_EJERCICIO)
                '        Dim inversionTotal As Object = dt.Compute("SUM(COSTO_X_PARTICIPANTE)", "COSTO_X_PARTICIPANTE>0")
                '        If Not IsDBNull(inversionTotal) Then
                '            If (Convert.ToDecimal(inversionTotal) + eAccionFormativa.COSTO_X_PARTICIPANTE) >= 450 Then
                '                cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF.JSProperties("cpResultCallback") = "MostrarCursosRecibidosPorParticipante"
                '                cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF.JSProperties("cpIdParticipante") = ID_PARTICIPANTE.ToString
                '                cbpucVistaDetalleSOLICITUD_INSCRIPCION_AF.JSProperties("cpIdEjercicio") = eAccionFormativa.ID_EJERCICIO
                '                Return
                '            End If
                '        End If
                '    End If
                '    Me.CargarDatosParticipante()
                '    Me.Habilitar()

        End Select
    End Sub

#End Region
  
End Class
