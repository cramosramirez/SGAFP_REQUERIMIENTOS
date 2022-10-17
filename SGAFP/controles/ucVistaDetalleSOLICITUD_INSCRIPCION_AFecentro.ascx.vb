Imports DevExpress.Web.ASPxEditors
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SGAFP.DL.DS_DL
Imports SGAFP.DL.DS_DLTableAdapters
Imports DevExpress.Web.ASPxClasses

Partial Class controles_ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro
    Inherits ucBase

    Private mComponente As New cSOLICITUD_PRESELECCION_EC
    Private mEntidad As SOLICITUD_PRESELECCION_EC
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

    Public Property ID_GRUPO_SELEC() As Decimal
        Get
            If ID_GRUPO_SELECtxt.Text <> "" Then Return ID_GRUPO_SELECtxt.Text
            Return -1
        End Get
        Set(ByVal value As Decimal)
            ID_GRUPO_SELECtxt.Text = value
            Dim lGrupo As GRUPO_SELECCION = (New cGRUPO_SELECCION).ObtenerGRUPO_SELECCION(value)
            If lGrupo IsNot Nothing Then
                Dim lAccion As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(lGrupo.ID_ACCION_CONTRATADA)
                If lAccion IsNot Nothing Then
                    Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lAccion.ID_CONTRATO)
                    Dim lPrograma As SIFP.EL.Programas = (New SIFP.BL.cProgramas).ObtenerProgramas(lAccion.CODIGO_PROGRAMA)

                    If lContrato IsNot Nothing Then
                        Me.lblCARRERA.Text = "Contrato:" + lContrato.NUM_CONTRATO + "   Carrera:" + lPrograma.nombre_programa + "   Grupo #" + lGrupo.NO_GRUPO.ToString
                    End If
                End If
            End If
        End Set
    End Property

    Private _ID_SOLIC_PRESELEC As Decimal
    Public Property ID_SOLIC_PRESELEC() As Decimal
        Get
            Return Me.ID_SOLIC_PRESELECtxt.Text
        End Get
        Set(ByVal Value As Decimal)
            Me.Nuevo()
            Me._ID_SOLIC_PRESELEC = Value
            Me.ID_SOLIC_PRESELECtxt.Text = CStr(Value)
            If Me._ID_SOLIC_PRESELEC > 0 Then
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

    Private Sub CargarMunicipiosNacionalidad()
        MUNICIPIO_NACcbx.SelectedIndex = -1
        odsMUNICIPIO_NACcbx.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = Me.DEPARTAMENTO_NACcbx.Value
        MUNICIPIO_NACcbx.DataBind()
    End Sub

    Private Sub CargarMunicipiosDomicilio()
        CODIGO_MUNICIPIOcbx.SelectedIndex = -1
        odsCODIGO_MUNICIPIOcbx.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = Me.CODIGO_DEPARTAMENTOcbx.Value
        CODIGO_MUNICIPIOcbx.DataBind()
    End Sub

    Private Sub CargarMunicipiosFamilia()
        CODIGO_MUNICIPIO_FAMcbx.SelectedIndex = -1
        odsCODIGO_MUNICIPIO_FAMcbx.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = Me.CODIGO_DEPARTAMENTO_FAMcbx.Value
        CODIGO_MUNICIPIO_FAMcbx.DataBind()
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
        If Not Page.IsPostBack Then
            Me.CargarPaises()
            Me.CargarParentesco()
        End If
    End Sub

    Public Sub Habilitar(Optional ByVal valor As Boolean = True)
        Dim Condicion As Boolean

        BuscarNombresbtn.ClientEnabled = valor
        BuscarDUIbtn.ClientEnabled = valor
        BuscarNITbtn.ClientEnabled = valor
        CopiarDomiciliobtn.ClientEnabled = valor

        ID_GRUPO_SELECtxt.ClientVisible = False
        ID_TIPO_SOLICITUDtxt.ClientVisible = False
        ID_ESTADO_SOLICITUDtxt.ClientVisible = False
        FECHA_PRESENTACIONDateEdit.ClientEnabled = valor
        NOMBREStxt.ClientEnabled = valor AndAlso Me.ID_PARTICIPANTEtxt.Text = ""
        APELLIDOStxt.ClientEnabled = valor AndAlso Me.ID_PARTICIPANTEtxt.Text = ""
        DUItxt.ClientEnabled = valor AndAlso Me.ID_PARTICIPANTEtxt.Text = ""
        NITtxt.ClientEnabled = valor AndAlso Me.ID_PARTICIPANTEtxt.Text = ""
        CARNET_MINORIDADtxt.ClientEnabled = valor
        ISSStxt.ClientEnabled = valor
        PASAPORTEtxt.ClientEnabled = valor
        NUM_DOCTOtxt.ClientEnabled = valor

        NACIONALIDADRadioButtonList.ClientEnabled = valor
        ID_PAIScbx.ClientEnabled = (NACIONALIDADRadioButtonList.Value = 2 AndAlso valor)
        DEPARTAMENTO_NACcbx.ClientEnabled = (NACIONALIDADRadioButtonList.Value = 1 AndAlso valor)
        MUNICIPIO_NACcbx.ClientEnabled = (NACIONALIDADRadioButtonList.Value = 1 AndAlso valor)
        FECHA_NACIMIENTODateEdit.ClientEnabled = valor AndAlso Me.ID_PARTICIPANTEtxt.Text = ""

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

        EDUCACION_BASICArdb.ClientEnabled = valor
        EDUCACION_BASICARadioButtonList.ClientEnabled = (EDUCACION_BASICArdb.Value AndAlso valor)
        BACHILLERATOrdb.ClientEnabled = valor
        BACHILLERATORadioButtonList.ClientEnabled = (BACHILLERATOrdb.Value AndAlso valor)
        TECNOLOGICArdb.ClientEnabled = valor
        TECNOLOGICARadioButtonList.ClientEnabled = (TECNOLOGICArdb.Value AndAlso valor)
        UNIVERSITARIArdb.ClientEnabled = valor
        UNIVERSITARIARadioButtonList.ClientEnabled = (UNIVERSITARIArdb.Value AndAlso valor)
        TITULO_CERTIFICADO_OBTENIDOchk.ClientEnabled = valor
        TITULO_CERTIFICADO_OBTENIDOtxt.ClientEnabled = (TITULO_CERTIFICADO_OBTENIDOchk.Checked AndAlso valor)

        ESTUDIA_ACTUALMENTERadioButtonlist.ClientEnabled = valor
        TIEMPO_DEJO_ESTUDIARRadioButtonList.ClientEnabled = (ESTUDIA_ACTUALMENTERadioButtonlist.Value = 2 AndAlso valor)
        MOTIVO_DEJO_ESTUDIARRadioButtonList.ClientEnabled = (ESTUDIA_ACTUALMENTERadioButtonlist.Value = 2 AndAlso valor)

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

        OCUACT_ESTUDIAchk.ClientEnabled = valor
        OCUACT_TRABAJAchk.ClientEnabled = valor
        OCUACT_BUSCA_TRABAJOchk.ClientEnabled = valor
        OCUACT_OTRAchk.ClientEnabled = valor
        OCUACT_OTRAtxt.ClientEnabled = (OCUACT_OTRAchk.Checked AndAlso valor)

        'TIPO_EMPLEORadioButtonList.ClientEnabled = (OCUACT_TRABAJAchk.Checked AndAlso valor)
        TIEMP_OTROtxt.ClientEnabled = (TIPO_EMPLEORadioButtonList.Value = 7 AndAlso TIPO_EMPLEORadioButtonList.ClientEnabled)

        Condicion = (TIPO_EMPLEORadioButtonList.ClientEnabled AndAlso valor AndAlso _
                        (TIPO_EMPLEORadioButtonList.Value = 1 Or TIPO_EMPLEORadioButtonList.Value = 2 Or TIPO_EMPLEORadioButtonList.Value = 3))

        TRABAJO_ANTERIORRadioButtonList.ClientEnabled = valor
        Condicion = (TRABAJO_ANTERIORRadioButtonList.Value = "S" AndAlso valor)
        TIEMPO_NO_TRABAJARadioButtonList1.ClientEnabled = Condicion AndAlso valor
        NOMBRE_EMPRESA1txt.ClientEnabled = Condicion AndAlso valor
        NOMBRE_EMPRESA2txt.ClientEnabled = Condicion AndAlso valor
        NOMBRE_EMPRESA3txt.ClientEnabled = Condicion AndAlso valor
        CARGO1txt.ClientEnabled = Condicion AndAlso valor
        CARGO2txt.ClientEnabled = Condicion AndAlso valor
        CARGO3txt.ClientEnabled = Condicion AndAlso valor
        FUNCIONES1txt.ClientEnabled = Condicion AndAlso valor
        FUNCIONES2txt.ClientEnabled = Condicion AndAlso valor
        FUNCIONES3txt.ClientEnabled = Condicion AndAlso valor
        DESDE_HASTA1txt.ClientEnabled = Condicion AndAlso valor
        DESDE_HASTA2txt.ClientEnabled = Condicion AndAlso valor
        DESDE_HASTA3txt.ClientEnabled = Condicion AndAlso valor
        ACTI_ECONOMICAcbx.ClientEnabled = Condicion AndAlso valor
        AREA_EMPRESAcbx.ClientEnabled = Condicion AndAlso valor
        PUESTO_DESEMPENOtxt.ClientEnabled = Condicion AndAlso valor
        MOTIVO_DEJO_TRABcbx.ClientEnabled = Condicion AndAlso valor
        ULT_SALARIO_MEScbx.ClientEnabled = Condicion AndAlso valor

        RECIBE_INGRESOSRadioButtonList.ClientEnabled = valor
        Condicion = (RECIBE_INGRESOSRadioButtonList.Value = 1 AndAlso valor)
        
        EXPFOR_OTROtxt.ClientEnabled = (EXPFOR_OTROchk.Checked AndAlso valor)

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
        ID_SOLIC_PRESELECtxt.Text = ""
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
        
        EDUCACION_BASICArdb.Value = False
        ASPxEdit.ClearEditorsInContainer(EDUCACION_BASICARadioButtonList)
        BACHILLERATOrdb.Value = False
        ASPxEdit.ClearEditorsInContainer(BACHILLERATORadioButtonList)
        TECNOLOGICArdb.Value = False
        ASPxEdit.ClearEditorsInContainer(TECNOLOGICARadioButtonList)
        UNIVERSITARIArdb.Value = False
        ASPxEdit.ClearEditorsInContainer(UNIVERSITARIARadioButtonList)
       
        TITULO_CERTIFICADO_OBTENIDOchk.Value = False
        TITULO_CERTIFICADO_OBTENIDOtxt.Text = ""
        ASPxEdit.ClearEditorsInContainer(ESTUDIA_ACTUALMENTERadioButtonlist)
        ASPxEdit.ClearEditorsInContainer(TIEMPO_DEJO_ESTUDIARRadioButtonList)
        ASPxEdit.ClearEditorsInContainer(RECIBIO_CURSO_ANTERIORRadioButtonList)

        INGRESO_MEScbx.SelectedIndex = -1
        CURSO1txt.Text = ""
        CURSO2txt.Text = ""
        CURSO3txt.Text = ""
        ASPxEdit.ClearEditorsInContainer(IMPARTIO_INSAFORP1ButtonList)
        ASPxEdit.ClearEditorsInContainer(IMPARTIO_INSAFORP2ButtonList)
        ASPxEdit.ClearEditorsInContainer(IMPARTIO_INSAFORP3ButtonList)
        ANIO1txt.Text = ""
        ANIO2txt.Text = ""
        ANIO3txt.Text = ""
        
        OCUACT_ESTUDIAchk.Value = False
        OCUACT_TRABAJAchk.Value = False
        OCUACT_BUSCA_TRABAJOchk.Value = False
        OCUACT_OTRAchk.Value = False
        OCUACT_OTRAtxt.Text = ""
        ASPxEdit.ClearEditorsInContainer(TIPO_EMPLEORadioButtonList)
        TIEMP_OTROtxt.Text = ""

        NOMBRE_EMPRESA1txt.Text = ""
        CARGO1txt.Text = ""
        FUNCIONES1txt.Text = ""
        DESDE_HASTA1txt.Text = ""
        NOMBRE_EMPRESA2txt.Text = ""
        CARGO2txt.Text = ""
        FUNCIONES2txt.Text = ""
        DESDE_HASTA2txt.Text = ""
        NOMBRE_EMPRESA3txt.Text = ""
        CARGO3txt.Text = ""
        FUNCIONES3txt.Text = ""
        DESDE_HASTA3txt.Text = ""

        ACTI_ECONOMICAcbx.SelectedIndex = -1
        PUESTO_DESEMPENOtxt.Text = ""
        AREA_EMPRESAcbx.SelectedIndex = -1
        MOTIVO_DEJO_TRABcbx.SelectedIndex = -1
        ULT_SALARIO_MEScbx.SelectedIndex = -1

        ASPxEdit.ClearEditorsInContainer(TRABAJO_ANTERIORRadioButtonList)
        ASPxEdit.ClearEditorsInContainer(TIEMPO_NO_TRABAJARadioButtonList1)

        ASPxEdit.ClearEditorsInContainer(RECIBE_INGRESOSRadioButtonList)
       

        EXPFOR_OBTENER_EMPLEOchk.Value = False
        EXPFOR_TRABAJAR_CTA_PROPIAchk.Value = False
        EXPFOR_INGRESOS_EXTRAchk.Value = False
        EXPFOR_OTROchk.Value = False
        EXPFOR_OTROtxt.Text = ""
        MOTIVO_ELIGIO_CARRERAtxt.Text = ""
        
        NOMBRE_FAMILIARtxt.Text = ""
        ID_PARENTESCOcbx.SelectedIndex = -1
        DIRECCION_FAMILIARtxt.Text = ""
        CODIGO_DEPARTAMENTO_FAMcbx.SelectedIndex = -1
        CODIGO_MUNICIPIO_FAMcbx.SelectedIndex = -1
        TELEFONO_FAMILIARtxt.Text = ""
        MOVIL_FAMILIARtxt.Text = ""
        EMAIL_FAMILIARtxt.Text = ""
        SUGERENCIASMemo.Text = ""
        Habilitar()
    End Sub

    Function CalcularEdad(ByVal fechaNacimiento As DateTime) As Integer
        Dim lFechaCalc As Date
        If Me.FECHA_PRESENTACIONDateEdit.Value IsNot Nothing Then
            lFechaCalc = Me.FECHA_PRESENTACIONDateEdit.Date
        Else
            lFechaCalc = Today
        End If
        Return Utilerias.CalcularEdad(fechaNacimiento, lFechaCalc)
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
        mEntidad = New SOLICITUD_PRESELECCION_EC
        mEntidad.ID_SOLIC_PRESELEC = ID_SOLIC_PRESELEC

        If mComponente.ObtenerSOLICITUD_PRESELECCION_EC(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.TabSolicitud.ActiveTabIndex = 0
        With mEntidad
            Me.ID_SOLIC_PRESELECtxt.Text = .ID_SOLIC_PRESELEC
            Me.TIPO_SELECCcbx.Value = CInt(.ID_TIPO_SELECC)
            Me.FECHA_PRESENTACIONDateEdit.Date = .FECHA_PRESENTACION
            Me.ID_GRUPO_SELECtxt.Text = .ID_GRUPO_SELEC
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
                Me.CargarMunicipiosNacionalidad()
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
            Me.CargarMunicipiosDomicilio()
            Me.CODIGO_MUNICIPIOcbx.Value = .CODIGO_MUNICIPIO
            Me.TELEFONOtxt.Text = .TELEFONO
            Me.MOVILtxt.Text = .MOVIL
            Me.EMAILtxt.Text = .EMAIL
            Me.CON_DISCAPACIDADRadioButtonList.Value = CInt(.CON_DISCAPACIDAD)

            'Mostrar discapacidades
            Dim ListaDiscapacidades As New listaDISCA_SOLIC_PRESELE
            ListaDiscapacidades = (New cDISCA_SOLIC_PRESELE).ObtenerListaPorSOLICITUD_PRESELECCION_EC(.ID_SOLIC_PRESELEC)
            Me.DISC_MOVERSE_CAMINARchk.Checked = False
            Me.DISC_BRAZOS_MANOSchk.Checked = False
            Me.DISC_VERchk.Checked = False
            Me.DISC_OIRchk.Checked = False
            Me.DISC_HABLARchk.Checked = False
            Me.DISC_RETRASOchk.Checked = False
            Me.DISC_BAN_VESTIR_ALIMchk.Checked = False
            Me.DISC_OTRAchk.Checked = False
            For Each _Discapacidad As DISCA_SOLIC_PRESELE In ListaDiscapacidades
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
          
            Me.TITULO_CERTIFICADO_OBTENIDOchk.Checked = (.TITULO_CERTIFICADO_OBTENIDO <> "")
            Me.TITULO_CERTIFICADO_OBTENIDOtxt.Text = .TITULO_CERTIFICADO_OBTENIDO

            If .ESTUDIA_ACTUALMENTE <> -1 Then
                Me.ESTUDIA_ACTUALMENTERadioButtonlist.Value = CInt(.ESTUDIA_ACTUALMENTE)
                If CInt(.ESTUDIA_ACTUALMENTE) = 2 Then
                    Me.TIEMPO_DEJO_ESTUDIARRadioButtonList.Value = CInt(.ID_TIEMPO_DEJO_ESTUDIAR)
                    Me.MOTIVO_DEJO_ESTUDIARRadioButtonList.Value = CInt(.ID_MOTIVO_DEJO_ESTU)
                    ESTUDIA_ACTUALMENTERadioButtonlist_ValueChanged(Me.ESTUDIA_ACTUALMENTERadioButtonlist, New System.EventArgs)
                End If
            End If

            If .RECIBIO_CURSO_ANTERIOR = "1" Then
                RECIBIO_CURSO_ANTERIORRadioButtonList.Value = 1
                'Mostrar cursos recibidos
                Dim listaCursos As New listaSOLIC_PRESELE_CURREC
                listaCursos = (New cSOLIC_PRESELE_CURREC).ObtenerListaPorSOLICITUD_PRESELECCION_EC(.ID_SOLIC_PRESELEC)

                If listaCursos IsNot Nothing Then
                    Dim conta As Integer = 1
                    For Each _Curso As SOLIC_PRESELE_CURREC In listaCursos
                        Select Case conta
                            Case 1
                                CURSO1txt.Text = _Curso.NOMBRE_CURSO
                                IMPARTIO_INSAFORP1ButtonList.Value = CInt(_Curso.APOYO_INSAFORP)
                                ANIO1txt.Text = _Curso.ANIO
                            Case 2
                                CURSO2txt.Text = _Curso.NOMBRE_CURSO
                                IMPARTIO_INSAFORP2ButtonList.Value = CInt(_Curso.APOYO_INSAFORP)
                                ANIO2txt.Text = _Curso.ANIO
                            Case 3
                                CURSO3txt.Text = _Curso.NOMBRE_CURSO
                                IMPARTIO_INSAFORP3ButtonList.Value = CInt(_Curso.APOYO_INSAFORP)
                                ANIO3txt.Text = _Curso.ANIO
                        End Select
                        conta += 1
                    Next
                End If
            Else
                RECIBIO_CURSO_ANTERIORRadioButtonList.Value = 2
            End If

            If .OCUACT_ESTUDIA = 1 Then OCUACT_ESTUDIAchk.Checked = True
            If .OCUACT_OFICIO_HOGAR = 1 Then OCUACT_OFICIOS_HOGARchk.Checked = True
            If .OCUACT_TRABAJA = 1 Then OCUACT_TRABAJAchk.Checked = True
            If .OCUACT_BUSCA_TRAB = 1 Then OCUACT_BUSCA_TRABAJOchk.Checked = True
            If .OCUACT_OTRA <> "" Then OCUACT_OTRAchk.Checked = True
            Me.OCUACT_OTRAtxt.Text = .OCUACT_OTRA



            If .RECIBE_INGRESOS = 1 Then
                Me.RECIBE_INGRESOSRadioButtonList.Value = 1
            ElseIf .RECIBE_INGRESOS = 2 Then
                Me.RECIBE_INGRESOSRadioButtonList.Value = 2
            End If

            If .MANERA_OBT_ING_TRABAJO = 1 Then
                TIPO_EMPLEORadioButtonList.Value = 1
            End If
            If .MANERA_OBT_ING_BECA = 1 Then
                TIPO_EMPLEORadioButtonList.Value = 2
            End If
            If .MANERA_OBT_ING_AYUDA_FAM = 1 Then
                TIPO_EMPLEORadioButtonList.Value = 3
            End If
            If .MANERA_OBT_ING_REMESA = 1 Then
                TIPO_EMPLEORadioButtonList.Value = 4
            End If
            If .MANERA_OBT_ING_OTRO <> "" Then
                TIPO_EMPLEORadioButtonList.Value = 5
            End If
            If .MANERA_OBT_ING_OTRO <> "" Then Me.TIEMP_OTROtxt.Text = .MANERA_OBT_ING_OTRO
            Me.INGRESO_MEScbx.Value = CInt(.ID_INGRESO_MES)

            Me.EXPFOR_INGRESOS_EXTRAchk.Checked = (.EXPFOR_INGRESOS_EXTRAS = 1)
            Me.EXPFOR_OTROchk.Checked = (.EXPFOR_OTRO <> "")
            Me.EXPFOR_OBTENER_EMPLEOchk.Checked = (.EXPFOR_OBTENER_EMPLEO = 1)
            Me.EXPFOR_TRABAJAR_CTA_PROPIAchk.Checked = (.EXPFOR_TRABAJAR_CTA_PROPIA = 1)
            Me.EXPFOR_OTROtxt.Text = .EXPFOR_OTRO

            Me.TRABAJO_ANTERIORRadioButtonList.Value = .TRABAJO_ANTERIOR
            Me.TIEMPO_NO_TRABAJARadioButtonList1.Value = CInt(.ID_TIEMPO_NOTRAB)
            Dim listaEmpresas As listaSOLIC_PRESELE_EMPRE = (New cSOLIC_PRESELE_EMPRE).ObtenerListaPorSOLICITUD_PRESELECCION_EC(.ID_SOLIC_PRESELEC)
            If listaEmpresas IsNot Nothing AndAlso listaEmpresas.Count > 0 Then
                For i As Integer = 0 To listaEmpresas.Count - 1
                    If i = 0 Then
                        Me.NOMBRE_EMPRESA1txt.Text = listaEmpresas(i).NOMBRE_EMPRESA
                        Me.CARGO1txt.Text = listaEmpresas(i).CARGO
                        Me.FUNCIONES1txt.Text = listaEmpresas(i).FUNCIONES
                        Me.DESDE_HASTA1txt.Text = listaEmpresas(i).DESDE_HASTA
                    ElseIf i = 1 Then
                        Me.NOMBRE_EMPRESA2txt.Text = listaEmpresas(i).NOMBRE_EMPRESA
                        Me.CARGO2txt.Text = listaEmpresas(i).CARGO
                        Me.FUNCIONES2txt.Text = listaEmpresas(i).FUNCIONES
                        Me.DESDE_HASTA2txt.Text = listaEmpresas(i).DESDE_HASTA
                    ElseIf i = 2 Then
                        Me.NOMBRE_EMPRESA3txt.Text = listaEmpresas(i).NOMBRE_EMPRESA
                        Me.CARGO3txt.Text = listaEmpresas(i).CARGO
                        Me.FUNCIONES3txt.Text = listaEmpresas(i).FUNCIONES
                        Me.DESDE_HASTA3txt.Text = listaEmpresas(i).DESDE_HASTA
                    End If
                Next
            End If
            If .ID_ACTI_ECONOMICA > 0 Then
                Me.ACTI_ECONOMICAcbx.Value = CInt(.ID_ACTI_ECONOMICA)
            Else
                Me.ACTI_ECONOMICAcbx.SelectedIndex = -1
            End If
            If .ID_AREA_EMPRESA > 0 Then
                Me.AREA_EMPRESAcbx.Value = CInt(.ID_AREA_EMPRESA)
            Else
                Me.AREA_EMPRESAcbx.SelectedIndex = -1
            End If
            If .ID_MOTIVO_DEJO_TRAB > 0 Then
                Me.MOTIVO_DEJO_TRABcbx.Value = CInt(.ID_MOTIVO_DEJO_TRAB)
            Else
                Me.MOTIVO_DEJO_TRABcbx.SelectedIndex = -1
            End If
            If .ID_ULT_SALARIO_MES > 0 Then
                Me.ULT_SALARIO_MEScbx.Value = CInt(.ID_ULT_SALARIO_MES)
            Else
                Me.ULT_SALARIO_MEScbx.SelectedIndex = -1
            End If
            Me.PUESTO_DESEMPENOtxt.Text = .PUESTO_DESEMPENO
           

            Me.MOTIVO_ELIGIO_CARRERAtxt.Text = .MOTIVO_ELIGIO_CARRERA
            Me.NOMBRE_FAMILIARtxt.Text = .NOMBRE_REFERENCIA
            Me.CargarParentesco()
            Me.SeleccionarElemento(Me.ID_PARENTESCOcbx, CInt(.ID_REFERENCIA))
            Me.DIRECCION_FAMILIARtxt.Text = .DIRECCION_REFERENCIA
            Me.CargarDepartamentos(CODIGO_DEPARTAMENTO_FAMcbx)
            Me.CODIGO_DEPARTAMENTO_FAMcbx.Value = .DEPARTAMENTO_REFERENCIA
            Me.CargarMunicipiosFamilia()
            Me.CODIGO_MUNICIPIO_FAMcbx.Value = .MUNICIPIO_REFERENCIA
            SeleccionarElemento(CODIGO_MUNICIPIO_FAMcbx, .MUNICIPIO_REFERENCIA)
            Me.TELEFONO_FAMILIARtxt.Text = .TELEFONO_REFERENCIA
            Me.MOVIL_FAMILIARtxt.Text = .MOVIL_REFERENCIA
            Me.EMAIL_FAMILIARtxt.Text = .EMAIL_REFERENCIA
            Me.SUGERENCIASMemo.Text = .SUGERENCIAS
        End With
        Me.Habilitar(True)
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
        mEntidad = New SOLICITUD_PRESELECCION_EC

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
        If Me.FECHA_PRESENTACIONDateEdit.Value = Nothing Then
            sError.Append("* Fecha de presentacion.") : sError.Append("<br>")
        End If
        If Me.TIPO_SELECCcbx.Value = Nothing Then
            sError.Append("* Tipo de aspirante.") : sError.Append("<br>")
        End If
        If Me.NOMBREStxt.Text.Trim = "" Or Me.APELLIDOStxt.Text.Trim = "" Then
            sError.Append("* Nombres y Apellidos son requeridos.") : sError.Append("<br>")
        End If
        If Me.NACIONALIDADRadioButtonList.Value = Nothing Then
            sError.Append("* Nacionalidad es requerido.") : sError.Append("<br>")
        End If
        If Me.NACIONALIDADRadioButtonList.Value = 2 And ID_PAIScbx.Value = Nothing Then
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
           Me.NACIONALIDADRadioButtonList.Value = 1 AndAlso Me.DEPARTAMENTO_NACcbx.Value = Nothing Then
            sError.Append("* Departamento de nacimiento es requerido.") : sError.Append("<br>")
        End If
        If Me.NACIONALIDADRadioButtonList.Value IsNot Nothing AndAlso _
           Me.NACIONALIDADRadioButtonList.Value = 1 AndAlso MUNICIPIO_NACcbx.Value = Nothing Then
            sError.Append("* Municipio de nacimiento es requerido.") : sError.Append("<br>")
        End If
        If Not IsDate(Me.FECHA_NACIMIENTODateEdit.Date) Then
            sError.Append("* Fecha de nacimiento no válida.") : sError.Append("<br>")
        End If
        If Me.GENERORadioButtonList.Value = Nothing Then
            sError.Append("* Sexo es requerido.") : sError.Append("<br>")
        End If
        If IsNumeric(Me.EDADtxt.Text.Trim) AndAlso (Decimal.Parse(Me.EDADtxt.Text) < 10 Or Decimal.Parse(Me.EDADtxt.Text) > 100) Then
            sError.Append("* Fecha de nacimiento no válida.") : sError.Append("<br>")
        End If
        If Me.MIEMBROS_GRUPO_FAMILIAspn.Value = Nothing OrElse CInt(Me.MIEMBROS_GRUPO_FAMILIAspn.Value) <= 0 Then
            sError.Append("* Cantidad de personas del grupo familiar es requerido.") : sError.Append("<br>")
        End If
        If Me.ESTADO_CIVILRadioButtonList.Value = Nothing Then
            sError.Append("* Estado familiar es requerido.") : sError.Append("<br>")
        End If
        If Me.ES_JEFE_HOGARRadioButotonList.Value = Nothing Then
            sError.Append("* Jefe(a) de hogar es requerido.") : sError.Append("<br>")
        End If
        If Me.TIENE_HIJOSRadioButtonList.Value = Nothing Then
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
        If CODIGO_DEPARTAMENTOcbx.Value = Nothing Then
            sError.Append("* Departamento de domicilio es requerido.") : sError.Append("<br>")
        End If
        If Me.TELEFONOtxt.Text.Trim = "" AndAlso Me.MOVILtxt.Text.Trim = "" Then
            sError.Append("* Teléfono fijo o móvil es requerido.") : sError.Append("<br>")
        End If
        If CODIGO_MUNICIPIOcbx.Value = Nothing Then
            sError.Append("* Municipio de domicilio es requerido.") : sError.Append("<br>")
        End If
        If CON_DISCAPACIDADRadioButtonList.Value = Nothing Then
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

        If Not (EDUCACION_BASICArdb.Value Or BACHILLERATOrdb.Value Or TECNOLOGICArdb.Value Or UNIVERSITARIArdb.Value) Then
            sError.Append("* Último grado de estudio finalizado es requerido.") : sError.Append("<br>")
        Else
            Select Case True
                Case EDUCACION_BASICArdb.Value
                    If EDUCACION_BASICARadioButtonList.Value = Nothing Then sError.Append("* Grado de Educación Básica es requerido.") : sError.Append("<br>")
                Case BACHILLERATOrdb.Value
                    If BACHILLERATORadioButtonList.Value = Nothing Then sError.Append("* Bachillerato completa/incompleta es requerido.") : sError.Append("<br>")
                Case TECNOLOGICArdb.Value
                    If TECNOLOGICARadioButtonList.Value = Nothing Then sError.Append("* Tecnologica completa/incompleta es requerido.") : sError.Append("<br>")
                Case UNIVERSITARIArdb.Value
                    If UNIVERSITARIARadioButtonList.Value = Nothing Then sError.Append("* Universitaria completa/incompleta es requerido.") : sError.Append("<br>")
            End Select
        End If
        If TITULO_CERTIFICADO_OBTENIDOchk.Checked AndAlso TITULO_CERTIFICADO_OBTENIDOtxt.Text.Trim = "" Then
            sError.Append("* Título o Certificado obtenido es requerido.") : sError.Append("<br>")
        End If
        If ESTUDIA_ACTUALMENTERadioButtonlist.Value = Nothing Then
            sError.Append("* Ha dejado de estudiar es requerido.") : sError.Append("<br>")
        ElseIf ESTUDIA_ACTUALMENTERadioButtonlist.Value = 2 AndAlso TIEMPO_DEJO_ESTUDIARRadioButtonList.Value = Nothing Then
            sError.Append("* Hace cuánto tiempo dejó de estudiar es requerido.") : sError.Append("<br>")
        ElseIf ESTUDIA_ACTUALMENTERadioButtonlist.Value = 2 AndAlso MOTIVO_DEJO_ESTUDIARRadioButtonList.Value = Nothing Then
            sError.Append("* Motivo por el que dejó de estudiar es requerido.") : sError.Append("<br>")
        End If
        If RECIBIO_CURSO_ANTERIORRadioButtonList.Value = Nothing Then
            sError.Append("* Recibió antes algún(os) curso(s) de capacitación es requerido.") : sError.Append("<br>")
        ElseIf RECIBIO_CURSO_ANTERIORRadioButtonList.Value = 1 Then
            If CURSO1txt.Text.Trim = "" AndAlso CURSO2txt.Text.Trim = "" AndAlso CURSO3txt.Text.Trim = "" AndAlso _
               IMPARTIO_INSAFORP1ButtonList.Value = Nothing AndAlso IMPARTIO_INSAFORP2ButtonList.Value = Nothing AndAlso IMPARTIO_INSAFORP3ButtonList.Value = Nothing AndAlso _
               ANIO1txt.Text.Trim = "" AndAlso ANIO2txt.Text.Trim = "" AndAlso ANIO3txt.Text.Trim = "" Then
                sError.Append("* Al menos un curso recibido es requerido.") : sError.Append("<br>")
            Else
                'Validar el curso uno si se ha ingresado información debe estar completa
                If (CURSO1txt.Text.Trim <> "" Or _
                    IMPARTIO_INSAFORP1ButtonList.Value IsNot Nothing Or _
                    ANIO1txt.Text.Trim <> "") AndAlso _
                    (CURSO1txt.Text.Trim = "" Or _
                    IMPARTIO_INSAFORP1ButtonList.Value = Nothing Or _
                    ANIO1txt.Text.Trim = "") Then
                    sError.Append("* La información del primer curso recibido está incompleta.") : sError.Append("<br>")
                End If
                'Validar el curso dos si se ha ingresado información debe estar completa
                If (CURSO2txt.Text.Trim <> "" Or _
                    IMPARTIO_INSAFORP2ButtonList.Value IsNot Nothing Or _
                    ANIO2txt.Text.Trim <> "") AndAlso _
                    (CURSO2txt.Text.Trim = "" Or _
                    IMPARTIO_INSAFORP2ButtonList.Value = Nothing Or _
                    ANIO2txt.Text.Trim = "") Then
                    sError.Append("* La información del segundo curso recibido está incompleta.") : sError.Append("<br>")
                End If
                'Validar el curso tres si se ha ingresado información debe estar completa
                If (CURSO3txt.Text.Trim <> "" Or _
                    IMPARTIO_INSAFORP3ButtonList.Value IsNot Nothing Or _
                    ANIO3txt.Text.Trim <> "") AndAlso _
                    (CURSO3txt.Text.Trim = "" Or _
                    IMPARTIO_INSAFORP3ButtonList.Value = Nothing Or _
                    ANIO3txt.Text.Trim = "") Then
                    sError.Append("* La información del tercer curso recibido está incompleta.") : sError.Append("<br>")
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
           Not OCUACT_OFICIOS_HOGARchk.Checked AndAlso Not OCUACT_OTRAchk.Checked AndAlso _
           Not OCUACT_TRABAJAchk.Checked Then
            sError.Append("* A que actividad se dedica actualmente es requerido.") : sError.Append("<br>")
        ElseIf OCUACT_OTRAchk.Checked AndAlso OCUACT_OTRAtxt.Text.Trim = "" Then
            sError.Append("* Ingrese otra actividad a la que se dedica actualmente.") : sError.Append("<br>")
        End If

        If RECIBE_INGRESOSRadioButtonList.Value = Nothing Then
            sError.Append("* Alguna de esas actividades le genera ingresos economicos es requerido.") : sError.Append("<br>")
        End If
        If TIPO_EMPLEORadioButtonList.Value = Nothing Then
            sError.Append("* El ingreso para su sostenimiento lo obtiene por medio de es requerido.") : sError.Append("<br>")
        ElseIf TIPO_EMPLEORadioButtonList.Value = 5 AndAlso Me.TIEMP_OTROtxt.Text.Trim = "" Then
            sError.Append("* Otro ingreso para su sostenimiento es requerido.") : sError.Append("<br>")
        End If

        If INGRESO_MEScbx.Value = Nothing Then
            sError.Append("* El ingreso mensual es requerido.") : sError.Append("<br>")
        End If

        If TRABAJO_ANTERIORRadioButtonList.Value = Nothing AndAlso Not OCUACT_TRABAJAchk.Checked Then
            sError.Append("* Si ha trabajado antes es requerido.") : sError.Append("<br>")
        ElseIf TRABAJO_ANTERIORRadioButtonList.Value = "S" AndAlso TIEMPO_NO_TRABAJARadioButtonList1.Value = Nothing Then
            sError.Append("* Cuanto tiempo hace que no trabaja es requerido.") : sError.Append("<br>")
        ElseIf TRABAJO_ANTERIORRadioButtonList.Value = "S" AndAlso ACTI_ECONOMICAcbx.Value = Nothing Then
            sError.Append("* A cual rama de la actividad económica se dedica la empresa en la que usted trabajó más tiempo es requerido.") : sError.Append("<br>")
        ElseIf TRABAJO_ANTERIORRadioButtonList.Value = "S" AndAlso PUESTO_DESEMPENOtxt.Text.Trim = "" Then
            sError.Append("* Puesto que desempeño en esa empresa es requerido.") : sError.Append("<br>")
        ElseIf TRABAJO_ANTERIORRadioButtonList.Value = "S" AndAlso AREA_EMPRESAcbx.Value = Nothing Then
            sError.Append("* En cual área de la empresa trabajaba usted es requerido.") : sError.Append("<br>")
        ElseIf TRABAJO_ANTERIORRadioButtonList.Value = "S" AndAlso MOTIVO_DEJO_TRABcbx.Value = Nothing Then
            sError.Append("* Motivo por el que dejo de trabajar es requerido.") : sError.Append("<br>")
        ElseIf TRABAJO_ANTERIORRadioButtonList.Value = "S" AndAlso ULT_SALARIO_MEScbx.Value = Nothing Then
            sError.Append("* De cuanto fue su ultimo salario mensual es requerido.") : sError.Append("<br>")
        End If
        If TRABAJO_ANTERIORRadioButtonList.Value = Nothing Then
            sError.Append("* Ha trabajado antes es requerido.") : sError.Append("<br>")
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

        If Not EXPFOR_OBTENER_EMPLEOchk.Checked AndAlso Not EXPFOR_INGRESOS_EXTRAchk.Checked AndAlso Not EXPFOR_TRABAJAR_CTA_PROPIAchk.Checked AndAlso _
            Not EXPFOR_OTROchk.Checked Then
            sError.Append("* Beneficio que espera recibir como producto de la carrera es requerido.") : sError.Append("<br>")
        End If
        If EXPFOR_OTROchk.Checked AndAlso EXPFOR_OTROtxt.Text.Trim = "" Then
            sError.Append("* Otro beneficio es requerido.") : sError.Append("<br>")
        End If
        If MOTIVO_ELIGIO_CARRERAtxt.Text.Trim = "" Then
            sError.Append("* Por que eligio esta carrera es requerido.") : sError.Append("<br>")
        End If

        If sResumeError.Length > 0 AndAlso sError.Length > 0 Then
            sError.Insert(0, "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>SECCION 4. EXPECTATIVAS RESPECTO A LA FORMACIÓN QUE ESPERA RECIBIR</b><br>", 1)
            sError.Append("<div>")
        ElseIf sError.Length > 0 Then
            sError.Insert(0, "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>SECCION 4. EXPECTATIVAS RESPECTO A LA FORMACIÓN QUE ESPERA RECIBIR</b><br>", 1)
            sError.Append("<div>")
            sError.Insert(0, "<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;"">LOS SIGUIENTES CAMPOS SON REQUERIDOS:</div><br>")
        End If

        sResumeError.Append(sError)
        sError = New StringBuilder

        If NOMBRE_FAMILIARtxt.Text.Trim = "" Then
            sError.Append("* Nombre de familiar es requerido.") : sError.Append("<br>")
        End If
        If ID_PARENTESCOcbx.Value = Nothing Then
            sError.Append("* Parentesco de familiar es requerido.") : sError.Append("<br>")
        End If
        If DIRECCION_FAMILIARtxt.Text.Trim = "" Then
            sError.Append("* Direccion de familiar es requerido.") : sError.Append("<br>")
        End If
        If TELEFONO_FAMILIARtxt.Text.Trim = "" AndAlso MOVIL_FAMILIARtxt.Text.Trim = "" Then
            sError.Append("* Teléfono fijo o móvil del familiar/amigo es requerido.") : sError.Append("<br>")
        End If
        If sResumeError.Length > 0 AndAlso sError.Length > 0 Then
            sError.Insert(0, "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>SECCION 5. SEGUIMIENTO</b><br>", 1)
            sError.Append("<div>")
        ElseIf sError.Length > 0 Then
            sError.Insert(0, "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><b>SECCION 5. SEGUIMIENTO</b><br>", 1)
            sError.Append("<div>")
            sError.Insert(0, "<div style=""text-align:center; font-family:Verdana,Arial; font-size:xx-small;"">LOS SIGUIENTES CAMPOS SON REQUERIDOS:</div><br>")
        End If

        sResumeError.Append(sError)
        sError = New StringBuilder

        If sResumeError.Length > 0 Then Return sResumeError.ToString



        '   Seteando la Entidad
        If ID_SOLIC_PRESELECtxt.Text <> "" Then
            mEntidad = (New cSOLICITUD_PRESELECCION_EC).ObtenerSOLICITUD_PRESELECCION_EC(Decimal.Parse(ID_SOLIC_PRESELECtxt.Text))
        Else
            mEntidad.ID_SOLIC_PRESELEC = 0
            mEntidad.ID_TIPO_SELECC = Me.TIPO_SELECCcbx.Value
            mEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Aprobada
            mEntidad.USUARIO_CREA = Me.ObtenerUsuario
            mEntidad.FECHA_CREACION = Now
        End If
        With mEntidad
            .FECHA_PRESENTACION = FECHA_PRESENTACIONDateEdit.Date
            .ID_GRUPO_SELEC = Me.ID_GRUPO_SELEC

            If Me.ID_PARTICIPANTEtxt.Text <> "" Then .ID_PARTICIPANTE = CDec(Me.ID_PARTICIPANTEtxt.Text)

            '   ***     SECCIÓN 1. DATOS DE IDENTIFICACIÓN
            .NOMBRES = Utilerias.QuitarAcentos(NOMBREStxt.Text.Trim.ToUpper)
            .APELLIDOS = Utilerias.QuitarAcentos(APELLIDOStxt.Text.Trim.ToUpper)
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
            If PROFESION_OFICIORadioButtonList.Value = Nothing Then .SE_DEDICA_ALGUNA_PROFESION = -1 Else .SE_DEDICA_ALGUNA_PROFESION = PROFESION_OFICIORadioButtonList.Value
            .PROFESION_OFICIO = PROFESION_OFICIOtxt.Text.Trim.ToUpper
            .DIRECCION = DIRECCIONtxt.Text.Trim.ToUpper
            .CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTOcbx.Value
            .CODIGO_MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(CODIGO_DEPARTAMENTOcbx.Value, CODIGO_MUNICIPIOcbx.Value).CODIGO_MUNICIPIO
            .TELEFONO = TELEFONOtxt.Text.Trim
            .MOVIL = MOVILtxt.Text.Trim
            .EMAIL = EMAILtxt.Text.Trim.ToLower
            .CON_DISCAPACIDAD = CON_DISCAPACIDADRadioButtonList.Value
            .DISC_OTRA = DISC_OTRAtxt.Text.Trim.ToUpper

            '   ***     SECCIÓN 2. EDUCACIÓN FORMAL Y FORMACIÓN OCUPACIONAL           
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

            .TITULO_CERTIFICADO_OBTENIDO = TITULO_CERTIFICADO_OBTENIDOtxt.Text.Trim.ToUpper
            .ESTUDIA_ACTUALMENTE = ESTUDIA_ACTUALMENTERadioButtonlist.Value
            If ESTUDIA_ACTUALMENTERadioButtonlist.Value = 1 Then
                If TIEMPO_DEJO_ESTUDIARRadioButtonList.Value = Nothing Then .ID_TIEMPO_DEJO_ESTUDIAR = -1 Else .ID_TIEMPO_DEJO_ESTUDIAR = TIEMPO_DEJO_ESTUDIARRadioButtonList.Value
                If MOTIVO_DEJO_ESTUDIARRadioButtonList.Value = Nothing Then .ID_MOTIVO_DEJO_ESTU = -1 Else .ID_MOTIVO_DEJO_ESTU = MOTIVO_DEJO_ESTUDIARRadioButtonList.Value
            Else
                .ID_TIEMPO_DEJO_ESTUDIAR = -1
                .ID_MOTIVO_DEJO_ESTU = -1
            End If
            .RECIBIO_CURSO_ANTERIOR = RECIBIO_CURSO_ANTERIORRadioButtonList.Value

            '   ***     SECCIÓN 3. INFORMACIÓN SOBRE SU SITUACIÓN LABORAL
            If OCUACT_ESTUDIAchk.Checked Then .OCUACT_ESTUDIA = 1 Else .OCUACT_ESTUDIA = 0
            If OCUACT_OFICIOS_HOGARchk.Checked Then .OCUACT_OFICIO_HOGAR = 1 Else .OCUACT_OFICIO_HOGAR = 0
            If OCUACT_TRABAJAchk.Checked Then .OCUACT_TRABAJA = 1 Else .OCUACT_TRABAJA = 0
            If OCUACT_BUSCA_TRABAJOchk.Checked Then .OCUACT_BUSCA_TRAB = 1 Else .OCUACT_BUSCA_TRAB = 0
            .OCUACT_OTRA = Me.OCUACT_OTRAtxt.Text.Trim.ToUpper
            .TIPO_EMPLEO_OTRO = Me.TIEMP_OTROtxt.Text.Trim.ToUpper

            '   ***     SECCIÓN 4. INFORMACIÓN SOBRE LOS INGRESOS
            .RECIBE_INGRESOS = RECIBE_INGRESOSRadioButtonList.Value

            .MANERA_OBT_ING_TRABAJO = If(TIPO_EMPLEORadioButtonList.Value = 1, 1, 0)
            .MANERA_OBT_ING_BECA = If(TIPO_EMPLEORadioButtonList.Value = 2, 1, 0)
            .MANERA_OBT_ING_AYUDA_FAM = If(TIPO_EMPLEORadioButtonList.Value = 3, 1, 0)
            .MANERA_OBT_ING_REMESA = If(TIPO_EMPLEORadioButtonList.Value = 4, 1, 0)
            If TIPO_EMPLEORadioButtonList.Value = 5 Then .MANERA_OBT_ING_OTRO = Me.TIEMP_OTROtxt.Text.Trim.ToUpper
            .ID_INGRESO_MES = Me.INGRESO_MEScbx.Value
            .TRABAJO_ANTERIOR = TRABAJO_ANTERIORRadioButtonList.Value

            If TRABAJO_ANTERIORRadioButtonList.Value = "S" Then
                .ID_TIEMPO_NOTRAB = TIEMPO_NO_TRABAJARadioButtonList1.Value
                .ID_ACTI_ECONOMICA = ACTI_ECONOMICAcbx.Value
                .PUESTO_DESEMPENO = PUESTO_DESEMPENOtxt.Text.Trim.ToUpper
                .ID_AREA_EMPRESA = AREA_EMPRESAcbx.Value
                .ID_MOTIVO_DEJO_TRAB = MOTIVO_DEJO_TRABcbx.Value
                .ID_ULT_SALARIO_MES = ULT_SALARIO_MEScbx.Value
            Else
                .ID_TIEMPO_NOTRAB = -1
                .ID_ACTI_ECONOMICA = -1
                .PUESTO_DESEMPENO = ""
                .ID_AREA_EMPRESA = -1
                .ID_MOTIVO_DEJO_TRAB = -1
                .ID_ULT_SALARIO_MES = -1
            End If

            ' ***************************************************************************
            'Si aún no se ha generado el informe de preseleccion es reclutamiento inicial
            Dim lstInformePre As listaINFORME_PRESELECCION_EC = (New cINFORME_PRESELECCION_EC).ObtenerListaPorGRUPO_SELECCION(Me.ID_GRUPO_SELEC)
            If lstInformePre IsNot Nothing AndAlso lstInformePre.Count > 0 Then
                'Si no ha pasado el primer mes de ejecución permitir la inscripción
                .ES_RECLUTA_INICIAL = 0
                .ES_RECLUTA_EXTRA = 1
            Else
                .ES_RECLUTA_INICIAL = 1
                .ES_RECLUTA_EXTRA = 0
            End If
            ' ***************************************************************************
            'Si la edad no esta entre 18 y 25 años entonces se requerira autorizacion para inscribirlo
            If .EDAD < 18 OrElse .EDAD > 25 Then
                .REQUI_AUTORIZACION = 1
                .OBSERVACION_AURIZACION = "EL ASPIRANTE NO CUMPLE CON LA EDAD DE 18 A 25 AÑOS, SE REQUIERE AUTORIZACION POR TECNICO."
            Else
                .REQUI_AUTORIZACION = 0
                .OBSERVACION_AURIZACION = ""
            End If

            If Me.TIPO_SELECCcbx.Value = Enumeradores.TipoSeleccionEC.Titular OrElse Me.TIPO_SELECCcbx.Value = Enumeradores.TipoSeleccionEC.Suplente AndAlso _
                .REQUI_AUTORIZACION = 0 Then
                .AUTORIZADO = 1
            Else
                .AUTORIZADO = 0
            End If

            '   ***     SECCIÓN 5. EXPECTATIVAS RESPECTO A LA FORMACIÓN - EXPECTATIVAS LABORALES
            If Me.EXPFOR_OBTENER_EMPLEOchk.Checked Then .EXPFOR_OBTENER_EMPLEO = 1 Else .EXPFOR_OBTENER_EMPLEO = 0
            If Me.EXPFOR_TRABAJAR_CTA_PROPIAchk.Checked Then .EXPFOR_TRABAJAR_CTA_PROPIA = 1 Else .EXPFOR_TRABAJAR_CTA_PROPIA = 0
            If Me.EXPFOR_INGRESOS_EXTRAchk.Checked Then .EXPFOR_INGRESOS_EXTRAS = 1 Else .EXPFOR_INGRESOS_EXTRAS = 0
            .EXPFOR_OTRO = Me.EXPFOR_OTROtxt.Text.Trim.ToUpper
            .MOTIVO_ELIGIO_CARRERA = Me.MOTIVO_ELIGIO_CARRERAtxt.Text.Trim.ToUpper

            '   ***     SECCIÓN 6. SEGUIMIENTO
            .NOMBRE_REFERENCIA = NOMBRE_FAMILIARtxt.Text.Trim.ToUpper
            .ID_REFERENCIA = ID_PARENTESCOcbx.SelectedItem.Value
            .DIRECCION_REFERENCIA = DIRECCION_FAMILIARtxt.Text.Trim.ToUpper
            .DEPARTAMENTO_REFERENCIA = CODIGO_DEPARTAMENTO_FAMcbx.SelectedItem.Value
            .MUNICIPIO_REFERENCIA = CODIGO_MUNICIPIO_FAMcbx.Value
            .TELEFONO_REFERENCIA = TELEFONO_FAMILIARtxt.Text.Trim
            .MOVIL_REFERENCIA = MOVIL_FAMILIARtxt.Text.Trim
            .EMAIL_REFERENCIA = EMAIL_FAMILIARtxt.Text.Trim.ToLower
            .SUGERENCIAS = SUGERENCIASMemo.Text.Trim.ToUpper
            .USUARIO_ACT = ObtenerUsuario()
            .FECHA_ACT = Now

            Me._CODIGO_ERROR = mComponente.ActualizarSOLICITUD_PRESELECCION_EC(mEntidad)
            If Me._CODIGO_ERROR <> 1 Then
                ExceptionManager.Publish(New Exception(mComponente.sError + vbCrLf + mComponente.sErrorTecnico))
                Return "<div style=""text-align:left; font-family:Verdana,Arial; font-size:xx-small;""><center><b>Error al Guardar Solicitud.</b></center><br>" + _
                        mComponente.sError + "</div>"
            End If

            '   Empresas en las que trabajo
            GuardarEmpresasTrabajo(mEntidad.ID_SOLIC_PRESELEC)

            '       Discapacidades
            GuardarDiscapacidades(mEntidad.ID_SOLIC_PRESELEC)

            '       Cursos de capacitación recibidos
            GuardarCursoRecibidos(mEntidad.ID_SOLIC_PRESELEC)

            If .REQUI_AUTORIZACION = 1 Then
                RaiseEvent ErrorEvent(.OBSERVACION_AURIZACION)
            End If

        End With

        Return ""
    End Function

    Private Sub GuardarEmpresasTrabajo(ByVal idSolic As Decimal)
        Dim bNegocio As New cSOLIC_PRESELE_EMPRE
        Dim lEntidad As SOLIC_PRESELE_EMPRE

        bNegocio.EliminarPorSolicitud(idSolic)

        If NOMBRE_EMPRESA1txt.Text <> "" Then
            lEntidad = New SOLIC_PRESELE_EMPRE
            lEntidad.ID_EMPRESA = 0
            lEntidad.ID_SOLIC_PRESELEC = idSolic
            lEntidad.NOMBRE_EMPRESA = NOMBRE_EMPRESA1txt.Text.Trim.ToUpper
            lEntidad.CARGO = CARGO1txt.Text.Trim.ToUpper
            lEntidad.FUNCIONES = FUNCIONES1txt.Text.Trim.ToUpper
            lEntidad.DESDE_HASTA = DESDE_HASTA1txt.Text.Trim.ToUpper
            bNegocio.ActualizarSOLIC_PRESELE_EMPRE(lEntidad)
        End If
        If NOMBRE_EMPRESA2txt.Text <> "" Then
            lEntidad = New SOLIC_PRESELE_EMPRE
            lEntidad.ID_EMPRESA = 0
            lEntidad.ID_SOLIC_PRESELEC = idSolic
            lEntidad.NOMBRE_EMPRESA = NOMBRE_EMPRESA2txt.Text.Trim.ToUpper
            lEntidad.CARGO = CARGO2txt.Text.Trim.ToUpper
            lEntidad.FUNCIONES = FUNCIONES2txt.Text.Trim.ToUpper
            lEntidad.DESDE_HASTA = DESDE_HASTA2txt.Text.Trim.ToUpper
            bNegocio.ActualizarSOLIC_PRESELE_EMPRE(lEntidad)
        End If
        If NOMBRE_EMPRESA3txt.Text <> "" Then
            lEntidad = New SOLIC_PRESELE_EMPRE
            lEntidad.ID_EMPRESA = 0
            lEntidad.ID_SOLIC_PRESELEC = idSolic
            lEntidad.NOMBRE_EMPRESA = NOMBRE_EMPRESA3txt.Text.Trim.ToUpper
            lEntidad.CARGO = CARGO3txt.Text.Trim.ToUpper
            lEntidad.FUNCIONES = FUNCIONES3txt.Text.Trim.ToUpper
            lEntidad.DESDE_HASTA = DESDE_HASTA3txt.Text.Trim.ToUpper
            bNegocio.ActualizarSOLIC_PRESELE_EMPRE(lEntidad)
        End If
    End Sub

    Private Sub GuardarCursoRecibidos(ByVal idSolic As Decimal)
        Dim bNegocio As New cSOLIC_PRESELE_CURREC
        Dim lEntidad As SOLIC_PRESELE_CURREC

        bNegocio.EliminarPorSolicitud(idSolic)

        If CURSO1txt.Text <> "" Then
            lEntidad = New SOLIC_PRESELE_CURREC
            lEntidad.ID_PRESELE_CURREC = 0
            lEntidad.ID_SOLIC_PRESELEC = idSolic
            lEntidad.NOMBRE_CURSO = CURSO1txt.Text.Trim.ToUpper
            lEntidad.ANIO = ANIO1txt.Text.Trim.ToUpper
            lEntidad.APOYO_INSAFORP = IMPARTIO_INSAFORP1ButtonList.Value
            bNegocio.ActualizarSOLIC_PRESELE_CURREC(lEntidad)
        End If
        If CURSO2txt.Text <> "" Then
            lEntidad = New SOLIC_PRESELE_CURREC
            lEntidad.ID_PRESELE_CURREC = 0
            lEntidad.ID_SOLIC_PRESELEC = idSolic
            lEntidad.NOMBRE_CURSO = CURSO2txt.Text.Trim.ToUpper
            lEntidad.ANIO = ANIO2txt.Text.Trim.ToUpper
            lEntidad.APOYO_INSAFORP = IMPARTIO_INSAFORP2ButtonList.Value
            bNegocio.ActualizarSOLIC_PRESELE_CURREC(lEntidad)
        End If
        If CURSO3txt.Text <> "" Then
            lEntidad = New SOLIC_PRESELE_CURREC
            lEntidad.ID_PRESELE_CURREC = 0
            lEntidad.ID_SOLIC_PRESELEC = idSolic
            lEntidad.NOMBRE_CURSO = CURSO3txt.Text.Trim.ToUpper
            lEntidad.ANIO = ANIO3txt.Text.Trim.ToUpper
            lEntidad.APOYO_INSAFORP = IMPARTIO_INSAFORP3ButtonList.Value
            bNegocio.ActualizarSOLIC_PRESELE_CURREC(lEntidad)
        End If
    End Sub



    Private Sub GuardarDiscapacidades(ByVal idSolic As Decimal)
        Dim bNegocio As New cDISCA_SOLIC_PRESELE
        Dim lEntidad As DISCA_SOLIC_PRESELE
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
                lEntidad = New DISCA_SOLIC_PRESELE
                lEntidad.ID_DISCA_SOLIC = 0
                lEntidad.ID_SOLIC_PRESELEC = idSolic
                lEntidad.ID_DISCAPACIDAD = IdDiscap

                bNegocio.ActualizarDISCA_SOLIC_PRESELE(lEntidad)
            End If
        Next

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

   

#End Region

   

    Protected Sub NACIONALIDADRadioButtonList_ValueChanged(sender As Object, e As EventArgs) Handles NACIONALIDADRadioButtonList.ValueChanged
        If NACIONALIDADRadioButtonList.Value = 1 Then
            ID_PAIScbx.Value = 57
            ID_PAIScbx.ClientEnabled = False
            DEPARTAMENTO_NACcbx.ClientEnabled = True
            MUNICIPIO_NACcbx.ClientEnabled = True
        Else
            ID_PAIScbx.Value = Nothing
            ID_PAIScbx.ClientEnabled = True
            DEPARTAMENTO_NACcbx.Value = Nothing
            DEPARTAMENTO_NACcbx.ClientEnabled = False
            MUNICIPIO_NACcbx.Value = Nothing
            MUNICIPIO_NACcbx.ClientEnabled = False
        End If
    End Sub

    Protected Sub DEPARTAMENTO_NACcbx_ValueChanged(sender As Object, e As EventArgs) Handles DEPARTAMENTO_NACcbx.ValueChanged
        CargarMunicipiosNacionalidad()
    End Sub

    Protected Sub CODIGO_DEPARTAMENTOcbx_ValueChanged(sender As Object, e As EventArgs) Handles CODIGO_DEPARTAMENTOcbx.ValueChanged
        CargarMunicipiosDomicilio()
    End Sub

    Protected Sub CODIGO_DEPARTAMENTO_FAMcbx_ValueChanged(sender As Object, e As EventArgs) Handles CODIGO_DEPARTAMENTO_FAMcbx.ValueChanged
        CargarMunicipiosFamilia()
    End Sub

    Protected Sub TIENE_HIJOSRadioButtonList_ValueChanged(sender As Object, e As EventArgs) Handles TIENE_HIJOSRadioButtonList.ValueChanged
        If TIENE_HIJOSRadioButtonList.Value = 1 Then
            NO_DE_HIJOStxt.ClientEnabled = True
        Else
            NO_DE_HIJOStxt.ClientEnabled = False
            NO_DE_HIJOStxt.Text = ""
        End If
    End Sub

    Protected Sub PROFESION_OFICIORadioButtonList_ValueChanged(sender As Object, e As EventArgs) Handles PROFESION_OFICIORadioButtonList.ValueChanged
        If PROFESION_OFICIORadioButtonList.Value = 1 Then
            PROFESION_OFICIOtxt.ClientEnabled = True
        Else
            PROFESION_OFICIOtxt.ClientEnabled = False
            PROFESION_OFICIOtxt.Text = ""
        End If
    End Sub

    Protected Sub CON_DISCAPACIDADRadioButtonList_ValueChanged(sender As Object, e As EventArgs) Handles CON_DISCAPACIDADRadioButtonList.ValueChanged
        If CON_DISCAPACIDADRadioButtonList.Value = 1 Then
            DISC_MOVERSE_CAMINARchk.ClientEnabled = True
            DISC_HABLARchk.ClientEnabled = True
            DISC_BRAZOS_MANOSchk.ClientEnabled = True
            DISC_RETRASOchk.ClientEnabled = True
            DISC_VERchk.ClientEnabled = True
            DISC_BAN_VESTIR_ALIMchk.ClientEnabled = True
            DISC_OIRchk.ClientEnabled = True
            DISC_OTRAchk.ClientEnabled = True
            DISC_OTRAtxt.ClientEnabled = False
        Else
            DISC_MOVERSE_CAMINARchk.Checked = False
            DISC_HABLARchk.Checked = False
            DISC_BRAZOS_MANOSchk.Checked = False
            DISC_RETRASOchk.Checked = False
            DISC_VERchk.Checked = False
            DISC_BAN_VESTIR_ALIMchk.Checked = False
            DISC_OIRchk.Checked = False
            DISC_OTRAchk.Checked = False

            DISC_MOVERSE_CAMINARchk.ClientEnabled = False
            DISC_HABLARchk.ClientEnabled = False
            DISC_BRAZOS_MANOSchk.ClientEnabled = False
            DISC_RETRASOchk.ClientEnabled = False
            DISC_VERchk.ClientEnabled = False
            DISC_BAN_VESTIR_ALIMchk.ClientEnabled = False
            DISC_OIRchk.ClientEnabled = False
            DISC_OTRAchk.ClientEnabled = False
            DISC_OTRAtxt.ClientEnabled = False
            DISC_OTRAtxt.Text = ""
        End If
    End Sub

    Protected Sub DISC_OTRAchk_ValueChanged(sender As Object, e As EventArgs) Handles DISC_OTRAchk.ValueChanged
        If DISC_OTRAchk.Checked Then
            DISC_OTRAtxt.ClientEnabled = True
        Else
            DISC_OTRAtxt.ClientEnabled = False
            DISC_OTRAtxt.Text = ""
        End If
    End Sub

    Protected Sub BuscarDUIbtn_Click(sender As Object, e As EventArgs) Handles BuscarDUIbtn.Click
        If Me.DUItxt.Text.Trim = "" Then
            Me.AsignarMensaje("Ingrese un numero de DUI", False, True)
            Return
        End If
        Me.ucListaPARTICIPANTE1.CargarDatosPorDUI(Me.DUItxt.Text)
        Me.popupParticipantes.ShowOnPageLoad = True
    End Sub

    Protected Sub BuscarNITbtn_Click(sender As Object, e As EventArgs) Handles BuscarNITbtn.Click
        If Me.NITtxt.Text.Trim = "" Then
            Me.AsignarMensaje("Ingrese un numero de NIT", False, True)
            Return
        End If
        Me.ucListaPARTICIPANTE1.CargarDatosPorNIT(Me.NITtxt.Text)
        Me.popupParticipantes.ShowOnPageLoad = True
    End Sub

    Protected Sub BuscarNombresbtn_Click(sender As Object, e As EventArgs) Handles BuscarNombresbtn.Click
        If Me.NOMBREStxt.Text.Trim = "" AndAlso Me.APELLIDOStxt.Text.Trim = "" Then
            Me.AsignarMensaje("Ingrese al menos un nombre o apellido", False, True)
        End If
        Me.ucListaPARTICIPANTE1.CargarDatosPorNOMBRES_APELLIDOS(Me.NOMBREStxt.Text + " " + Me.APELLIDOStxt.Text)
        Me.popupParticipantes.ShowOnPageLoad = True
    End Sub

    Protected Sub ucListaPARTICIPANTE1_Seleccionado(ID_PARTICIPANTE As Decimal) Handles ucListaPARTICIPANTE1.Seleccionado
        Me.popupParticipantes.ShowOnPageLoad = False

        'Cargar datos del participante
        Me.ID_PARTICIPANTE = ID_PARTICIPANTE
        Me.CargarDatosParticipante()
    End Sub

    Public Function CargarDatosParticipante() As String
        Dim bParticipante As New cPARTICIPANTE
        Dim eParticipante As New PARTICIPANTE
        Dim item As New DevExpress.Web.ASPxEditors.ListEditItem


        eParticipante.ID_PARTICIPANTE = Me.ID_PARTICIPANTE
        If bParticipante.ObtenerPARTICIPANTE(eParticipante) <> 1 Then
            AsignarMensaje("No se encontro al participante", False, False)
            Return ""
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
                Me.CargarMunicipiosNacionalidad()
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
            Me.CargarMunicipiosDomicilio()
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
                    EDUCACION_BASICArdb_ValueChanged(EDUCACION_BASICArdb, New System.EventArgs)
                Case 18 To 19
                    Me.BACHILLERATOrdb.Value = True
                    BACHILLERATORadioButtonList.Value = CInt(.ID_NIVEL_ACADEMICO)
                    BACHILLERATOrdb_ValueChanged(BACHILLERATOrdb, New System.EventArgs)
                Case 20 To 21
                    Me.TECNOLOGICArdb.Value = True
                    TECNOLOGICARadioButtonList.Value = CInt(.ID_NIVEL_ACADEMICO)
                    TECNOLOGICArdb_ValueChanged(TECNOLOGICArdb, New System.EventArgs)
                Case 22 To 23
                    Me.UNIVERSITARIArdb.Value = True
                    UNIVERSITARIARadioButtonList.Value = CInt(.ID_NIVEL_ACADEMICO)
                    UNIVERSITARIArdb_ValueChanged(UNIVERSITARIArdb, New System.EventArgs)
            End Select
            If .PROFESION_OFICIO <> "" Then PROFESION_OFICIORadioButtonList.Value = 1 Else PROFESION_OFICIORadioButtonList.Value = 2
            Me.PROFESION_OFICIOtxt.Text = .PROFESION_OFICIO

            PROFESION_OFICIORadioButtonList_ValueChanged(Me.PROFESION_OFICIOtxt, New System.EventArgs)
            CON_DISCAPACIDADRadioButtonList_ValueChanged(Me.CON_DISCAPACIDADRadioButtonList, New System.EventArgs)
            Me.NOMBREStxt.ClientEnabled = False
            Me.APELLIDOStxt.ClientEnabled = False
            If .DUI <> "" Then DUItxt.ClientEnabled = False
            If .NIT <> "" Then NITtxt.ClientEnabled = False
            Me.FECHA_NACIMIENTODateEdit.ClientEnabled = False
        End With

        Return ""
    End Function

    Protected Sub FECHA_NACIMIENTODateEdit_ValueChanged(sender As Object, e As EventArgs) Handles FECHA_NACIMIENTODateEdit.ValueChanged, FECHA_PRESENTACIONDateEdit.ValueChanged
        If FECHA_NACIMIENTODateEdit.Value IsNot Nothing Then
            Me.EDADtxt.Text = CalcularEdad(FECHA_NACIMIENTODateEdit.Date)
        Else
            Me.EDADtxt.Text = ""
        End If
    End Sub

    Protected Sub EDUCACION_BASICArdb_ValueChanged(sender As Object, e As EventArgs) Handles EDUCACION_BASICArdb.ValueChanged
        If EDUCACION_BASICArdb.Checked Then
            Me.EDUCACION_BASICARadioButtonList.ClientEnabled = True
        Else
            Me.EDUCACION_BASICARadioButtonList.Value = Nothing
            Me.EDUCACION_BASICARadioButtonList.ClientEnabled = False
        End If
    End Sub

    Protected Sub BACHILLERATOrdb_ValueChanged(sender As Object, e As EventArgs) Handles BACHILLERATOrdb.ValueChanged
        If BACHILLERATOrdb.Checked Then
            Me.BACHILLERATORadioButtonList.ClientEnabled = True
        Else
            Me.BACHILLERATORadioButtonList.Value = Nothing
            Me.BACHILLERATORadioButtonList.ClientEnabled = False
        End If
    End Sub

    Protected Sub TECNOLOGICArdb_ValueChanged(sender As Object, e As EventArgs) Handles TECNOLOGICArdb.ValueChanged
        If TECNOLOGICArdb.Checked Then
            Me.TECNOLOGICARadioButtonList.ClientEnabled = True
        Else
            Me.TECNOLOGICARadioButtonList.Value = Nothing
            Me.TECNOLOGICARadioButtonList.ClientEnabled = False
        End If
    End Sub

    Protected Sub UNIVERSITARIArdb_ValueChanged(sender As Object, e As EventArgs) Handles UNIVERSITARIArdb.ValueChanged
        If UNIVERSITARIArdb.Checked Then
            Me.UNIVERSITARIARadioButtonList.ClientEnabled = True
        Else
            Me.UNIVERSITARIARadioButtonList.Value = Nothing
            Me.UNIVERSITARIARadioButtonList.ClientEnabled = False
        End If
    End Sub

    Protected Sub ESTUDIA_ACTUALMENTERadioButtonlist_ValueChanged(sender As Object, e As EventArgs) Handles ESTUDIA_ACTUALMENTERadioButtonlist.ValueChanged
        If ESTUDIA_ACTUALMENTERadioButtonlist.Value = 2 Then
            Me.TIEMPO_DEJO_ESTUDIARRadioButtonList.ClientEnabled = True
            Me.MOTIVO_DEJO_ESTUDIARRadioButtonList.ClientEnabled = True
        Else
            Me.TIEMPO_DEJO_ESTUDIARRadioButtonList.Value = Nothing
            Me.TIEMPO_DEJO_ESTUDIARRadioButtonList.ClientEnabled = False
            Me.MOTIVO_DEJO_ESTUDIARRadioButtonList.Value = Nothing
            Me.MOTIVO_DEJO_ESTUDIARRadioButtonList.ClientEnabled = False
        End If
    End Sub

    Protected Sub RECIBIO_CURSO_ANTERIORRadioButtonList_ValueChanged(sender As Object, e As EventArgs) Handles RECIBIO_CURSO_ANTERIORRadioButtonList.ValueChanged
        If RECIBIO_CURSO_ANTERIORRadioButtonList.Value = 1 Then
            Me.CURSO1txt.ClientEnabled = True
            Me.CURSO2txt.ClientEnabled = True
            Me.CURSO3txt.ClientEnabled = True
            Me.IMPARTIO_INSAFORP1ButtonList.ClientEnabled = True
            Me.IMPARTIO_INSAFORP2ButtonList.ClientEnabled = True
            Me.IMPARTIO_INSAFORP3ButtonList.ClientEnabled = True
            Me.ANIO1txt.ClientEnabled = True
            Me.ANIO2txt.ClientEnabled = True
            Me.ANIO3txt.ClientEnabled = True
        Else
            Me.CURSO1txt.ClientEnabled = False
            Me.CURSO2txt.ClientEnabled = False
            Me.CURSO3txt.ClientEnabled = False
            Me.IMPARTIO_INSAFORP1ButtonList.ClientEnabled = False
            Me.IMPARTIO_INSAFORP2ButtonList.ClientEnabled = False
            Me.IMPARTIO_INSAFORP3ButtonList.ClientEnabled = False
            Me.ANIO1txt.ClientEnabled = False
            Me.ANIO2txt.ClientEnabled = False
            Me.ANIO3txt.ClientEnabled = False

            Me.CURSO1txt.Text = ""
            Me.CURSO2txt.Text = ""
            Me.CURSO3txt.Text = ""
            Me.IMPARTIO_INSAFORP1ButtonList.Value = Nothing
            Me.IMPARTIO_INSAFORP2ButtonList.Value = Nothing
            Me.IMPARTIO_INSAFORP3ButtonList.Value = Nothing
            Me.ANIO1txt.Text = ""
            Me.ANIO2txt.Text = ""
            Me.ANIO3txt.Text = ""
        End If
    End Sub

    Protected Sub OCUACT_OTRAchk_ValueChanged(sender As Object, e As EventArgs) Handles OCUACT_OTRAchk.ValueChanged
        If OCUACT_OTRAchk.Checked Then
            OCUACT_OTRAtxt.ClientEnabled = True
        Else
            OCUACT_OTRAtxt.ClientEnabled = False
            OCUACT_OTRAtxt.Text = ""
        End If
    End Sub

    Protected Sub TIPO_EMPLEORadioButtonList_ValueChanged(sender As Object, e As EventArgs) Handles TIPO_EMPLEORadioButtonList.ValueChanged
        If TIPO_EMPLEORadioButtonList.Value = 5 Then
            Me.TIEMP_OTROtxt.ClientEnabled = True
        Else
            Me.TIEMP_OTROtxt.ClientEnabled = False
            Me.TIEMP_OTROtxt.Text = ""
        End If
    End Sub

    Protected Sub TRABAJO_ANTERIORRadioButtonList_ValueChanged(sender As Object, e As EventArgs) Handles TRABAJO_ANTERIORRadioButtonList.ValueChanged
        If Me.TRABAJO_ANTERIORRadioButtonList.Value = "S" Then
            Me.TIEMPO_NO_TRABAJARadioButtonList1.ClientEnabled = True
            Me.NOMBRE_EMPRESA1txt.ClientEnabled = True
            Me.NOMBRE_EMPRESA2txt.ClientEnabled = True
            Me.NOMBRE_EMPRESA3txt.ClientEnabled = True
            Me.CARGO1txt.ClientEnabled = True
            Me.CARGO2txt.ClientEnabled = True
            Me.CARGO3txt.ClientEnabled = True
            Me.FUNCIONES1txt.ClientEnabled = True
            Me.FUNCIONES2txt.ClientEnabled = True
            Me.FUNCIONES3txt.ClientEnabled = True
            Me.DESDE_HASTA1txt.ClientEnabled = True
            Me.DESDE_HASTA2txt.ClientEnabled = True
            Me.DESDE_HASTA3txt.ClientEnabled = True
            Me.ACTI_ECONOMICAcbx.ClientEnabled = True
            Me.PUESTO_DESEMPENOtxt.ClientEnabled = True
            Me.AREA_EMPRESAcbx.ClientEnabled = True
            Me.MOTIVO_DEJO_TRABcbx.ClientEnabled = True
            Me.ULT_SALARIO_MEScbx.ClientEnabled = True
        Else
            Me.TIEMPO_NO_TRABAJARadioButtonList1.ClientEnabled = False
            Me.NOMBRE_EMPRESA1txt.ClientEnabled = False
            Me.NOMBRE_EMPRESA2txt.ClientEnabled = False
            Me.NOMBRE_EMPRESA3txt.ClientEnabled = False
            Me.CARGO1txt.ClientEnabled = False
            Me.CARGO2txt.ClientEnabled = False
            Me.CARGO3txt.ClientEnabled = False
            Me.FUNCIONES1txt.ClientEnabled = False
            Me.FUNCIONES2txt.ClientEnabled = False
            Me.FUNCIONES3txt.ClientEnabled = False
            Me.DESDE_HASTA1txt.ClientEnabled = False
            Me.DESDE_HASTA2txt.ClientEnabled = False
            Me.DESDE_HASTA3txt.ClientEnabled = False
            Me.ACTI_ECONOMICAcbx.ClientEnabled = False
            Me.PUESTO_DESEMPENOtxt.ClientEnabled = False
            Me.AREA_EMPRESAcbx.ClientEnabled = False
            Me.MOTIVO_DEJO_TRABcbx.ClientEnabled = False
            Me.ULT_SALARIO_MEScbx.ClientEnabled = False

            Me.TIEMPO_NO_TRABAJARadioButtonList1.Value = Nothing
            Me.NOMBRE_EMPRESA1txt.Text = ""
            Me.NOMBRE_EMPRESA2txt.Text = ""
            Me.NOMBRE_EMPRESA3txt.Text = ""
            Me.CARGO1txt.Text = ""
            Me.CARGO2txt.Text = ""
            Me.CARGO3txt.Text = ""
            Me.FUNCIONES1txt.Text = ""
            Me.FUNCIONES2txt.Text = ""
            Me.FUNCIONES3txt.Text = ""
            Me.DESDE_HASTA1txt.Text = ""
            Me.DESDE_HASTA2txt.Text = ""
            Me.DESDE_HASTA3txt.Text = ""
            Me.ACTI_ECONOMICAcbx.Value = Nothing
            Me.PUESTO_DESEMPENOtxt.Text = ""
            Me.AREA_EMPRESAcbx.Value = Nothing
            Me.MOTIVO_DEJO_TRABcbx.Value = Nothing
            Me.ULT_SALARIO_MEScbx.Value = Nothing
        End If
    End Sub

    Protected Sub EXPFOR_OTROchk_ValueChanged(sender As Object, e As EventArgs) Handles EXPFOR_OTROchk.ValueChanged
        If Me.EXPFOR_OTROchk.Checked Then
            Me.EXPFOR_OTROtxt.ClientEnabled = True
        Else
            Me.EXPFOR_OTROtxt.ClientEnabled = False
            Me.EXPFOR_OTROtxt.Text = ""
        End If
    End Sub

    Protected Sub CopiarDomiciliobtn_Click(sender As Object, e As EventArgs) Handles CopiarDomiciliobtn.Click
        DIRECCION_FAMILIARtxt.Text = Left(DIRECCIONtxt.Text.Trim, 100)
        If CODIGO_DEPARTAMENTOcbx.Value IsNot Nothing Then
            CODIGO_DEPARTAMENTO_FAMcbx.Value = CODIGO_DEPARTAMENTOcbx.Value
            If CODIGO_MUNICIPIOcbx.Value IsNot Nothing Then
                CargarMunicipiosFamilia()
                CODIGO_MUNICIPIO_FAMcbx.Value = CODIGO_MUNICIPIOcbx.Value
            End If
        End If
        Me.TELEFONO_FAMILIARtxt.Text = Left(Me.TELEFONOtxt.Text.Trim, 8)
    End Sub

    Protected Sub TITULO_CERTIFICADO_OBTENIDOchk_ValueChanged(sender As Object, e As EventArgs) Handles TITULO_CERTIFICADO_OBTENIDOchk.ValueChanged
        If TITULO_CERTIFICADO_OBTENIDOchk.Checked Then
            TITULO_CERTIFICADO_OBTENIDOtxt.ClientEnabled = True
        Else
            TITULO_CERTIFICADO_OBTENIDOtxt.ClientEnabled = False
            TITULO_CERTIFICADO_OBTENIDOtxt.Text = ""
        End If
    End Sub
End Class
