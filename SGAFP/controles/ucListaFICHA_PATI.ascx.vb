Imports PATI.BL
Imports PATI.EL
Imports System.Collections.Generic
''' -----------------------------------------------------------------------------
''' Project	 : PATI
''' Class	 : ucListaFICHA_PATI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla FICHA_PATI
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaFICHA_PATI
    Inherits ucListaBase
 
    Private mComponente As New cFICHA_PATI
    Public Event Seleccionado(ByVal NUME_FICH As Decimal) 
    Public Event Editando(ByVal NUME_FICH As Decimal) 

#Region"Propiedades"

    Private _ID_ACCION_FORMATIVA As Decimal
    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            If hf.Contains("ID_ACCION_FORMATIVA") Then Return hf("ID_ACCION_FORMATIVA") Else Return 0
        End Get
        Set(ByVal value As Decimal)
            If hf.Contains("ID_ACCION_FORMATIVA") Then hf("ID_ACCION_FORMATIVA") = value Else hf.Add("ID_ACCION_FORMATIVA", value)
        End Set
    End Property

    Public Property TamanoFuente() As System.Web.UI.WebControls.FontUnit
        Get
            Return Me.dxgvLista.Font.Size
        End Get
        Set(ByVal value As System.Web.UI.WebControls.FontUnit)
            Me.dxgvLista.Font.Size = value
        End Set
    End Property

    Public Property TamanoPagina() As Decimal
        Get
            Return Me.dxgvLista.SettingsPager.PageSize
        End Get
        Set(ByVal value As Decimal)
            Me.dxgvLista.SettingsPager.PageSize = value
        End Set
    End Property

    Public Property MostrarFooter() As Boolean
        Get
            Return Me.dxgvLista.SettingsPager.Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.SettingsPager.Visible = Value
        End Set
    End Property

    Public Property PermitirPaginacion() As Boolean
        Get
            If Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.ASPxGridView.GridViewPagerMode.ShowPager Then
                Return True
            End If
            Return False
        End Get
        Set(ByVal Value As Boolean)
            If Value Then
                Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.ASPxGridView.GridViewPagerMode.ShowPager
            Else
                Me.dxgvLista.SettingsPager.Mode = DevExpress.Web.ASPxGridView.GridViewPagerMode.ShowAllRecords
            End If
        End Set
    End Property

    Private _PermitirEditar As Boolean = True
    Public Property PermitirEditar() As Boolean
        Get
            Return _PermitirEditar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirEditar = Value
            If Not Me.ViewState("PermitirEditar") Is Nothing Then Me.ViewState.Remove("PermitirEditar")
            Me.ViewState.Add("PermitirEditar", Value)
        End Set
    End Property

    Private _PermitirSeleccionar As Boolean = False
    Public Property PermitirSeleccionar() As Boolean
        Get
            Return _PermitirSeleccionar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirSeleccionar = Value
            If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me.ViewState.Remove("PermitirSeleccionar")
            Me.ViewState.Add("PermitirSeleccionar", Value)
        End Set
    End Property

    Public Property PermitirEliminar() As Boolean
        Get
            Return Me.dxgvLista.Columns("Eliminar").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("Eliminar").Visible = Value
        End Set
    End Property

    Public Property PermitirAgrupar() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowGroupPanel
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Settings.ShowGroupPanel = Value
        End Set
    End Property

    Public Property PermitirFilaDeFiltro() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowFilterRow
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Settings.ShowFilterRow = value
        End Set
    End Property

    Public Property PermitirFiltroEnEncabezado() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowHeaderFilterButton
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Settings.ShowHeaderFilterButton = value
        End Set
    End Property

    Public Property PermitirEditarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEdicionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEdicionInline") = value
        End Set
    End Property

    Public Property PermitirEliminarInline() As Boolean
        Get
            Return Me.ViewState("PermitirEliminacionInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirEliminacionInline") = value
        End Set
    End Property

    Public Property PermitirAgregarInline() As Boolean
        Get
            Return Me.ViewState("PermitirAgregarInline")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirAgregarInline") = value
        End Set
    End Property

    Public Property PermitirRowHotTrack() As Boolean
        Get
            Return Me.dxgvLista.SettingsBehavior.EnableRowHotTrack
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.SettingsBehavior.EnableRowHotTrack = value
        End Set
    End Property

    Public Property PermitirFocoEnFilas() As Boolean
        Get
            Return Me.dxgvLista.SettingsBehavior.AllowFocusedRow
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.SettingsBehavior.AllowFocusedRow = value
        End Set
    End Property

    Public Property PermitirSeleccionParaCombo() As Boolean
        Get
            Return Me.ViewState("PermitirSeleccionParaCombo")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("PermitirSeleccionParaCombo") = value
        End Set
    End Property

    Public Property NombreComboCliente() As String
        Get
            Return Me.ViewState("NombreComboCliente")
        End Get
        Set(ByVal value As String)
            Me.ViewState("NombreComboCliente") = value
        End Set
    End Property

    Private _TextoSeleccionar As String = "Seleccionar"
    Public Property TextoSeleccionar() As String
        Get
            Return _TextoSeleccionar
        End Get
        Set(ByVal Value As String)
            _TextoSeleccionar = Value
            If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me.ViewState.Remove("TextoSeleccionar")
            Me.ViewState.Add("TextoSeleccionar", Value)
        End Set
    End Property

    Private _ComandoSeleccionar As String = "Select"
    Public Property ComandoSeleccionar() As String
        Get
            Return _ComandoSeleccionar
        End Get
        Set(ByVal Value As String)
            _ComandoSeleccionar = Value
            If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me.ViewState.Remove("ComandoSeleccionar")
            Me.ViewState.Add("ComandoSeleccionar", Value)
        End Set
    End Property

    Public Property TextoHeaderSeleccionar() As String
        Get
            Return Me.dxgvLista.Columns("Seleccionar").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("Seleccionar").Caption = Value
        End Set
    End Property

    Public Property NombreGridCliente() As String
        Get
            Return dxgvLista.ClientInstanceName
        End Get
        Set(ByVal value As String)
            dxgvLista.ClientInstanceName = value
        End Set
    End Property

    Public Property VerNUME_FICH() As Boolean
        Get
            Return Me.dxgvLista.Columns("NUME_FICH").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NUME_FICH").Visible = Value
        End Set
    End Property

    Public Property VerID_ENTREVISTADOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ENTREVISTADOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ENTREVISTADOR").Visible = Value
        End Set
    End Property

    Public Property VerNOMB_CASERIO_AUP() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMB_CASERIO_AUP").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMB_CASERIO_AUP").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_ING_FICHA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_ING_FICHA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_ING_FICHA").Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_PROYECTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIGO_PROYECTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIGO_PROYECTO").Visible = Value
        End Set
    End Property

    Public Property VerPRIMER_NOMBRE() As Boolean
        Get
            Return Me.dxgvLista.Columns("PRIMER_NOMBRE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PRIMER_NOMBRE").Visible = Value
        End Set
    End Property

    Public Property VerSEGUNDO_NOMBRE() As Boolean
        Get
            Return Me.dxgvLista.Columns("SEGUNDO_NOMBRE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SEGUNDO_NOMBRE").Visible = Value
        End Set
    End Property

    Public Property VerTERCER_NOMBRE() As Boolean
        Get
            Return Me.dxgvLista.Columns("TERCER_NOMBRE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TERCER_NOMBRE").Visible = Value
        End Set
    End Property

    Public Property VerPRIMER_APELLIDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("PRIMER_APELLIDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PRIMER_APELLIDO").Visible = Value
        End Set
    End Property

    Public Property VerSEGUNDO_APELLIDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("SEGUNDO_APELLIDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SEGUNDO_APELLIDO").Visible = Value
        End Set
    End Property

    Public Property VerTERCER_APELLIDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TERCER_APELLIDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TERCER_APELLIDO").Visible = Value
        End Set
    End Property

    Public Property VerES_SALVADORENO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ES_SALVADORENO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ES_SALVADORENO").Visible = Value
        End Set
    End Property

    Public Property VerPAIS() As Boolean
        Get
            Return Me.dxgvLista.Columns("PAIS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PAIS").Visible = Value
        End Set
    End Property

    Public Property VerDUI() As Boolean
        Get
            Return Me.dxgvLista.Columns("DUI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DUI").Visible = Value
        End Set
    End Property

    Public Property VerCEDULA_IDENTIDAD() As Boolean
        Get
            Return Me.dxgvLista.Columns("CEDULA_IDENTIDAD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CEDULA_IDENTIDAD").Visible = Value
        End Set
    End Property

    Public Property VerCARNET_MINORIDAD() As Boolean
        Get
            Return Me.dxgvLista.Columns("CARNET_MINORIDAD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CARNET_MINORIDAD").Visible = Value
        End Set
    End Property

    Public Property VerPASAPORTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("PASAPORTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PASAPORTE").Visible = Value
        End Set
    End Property

    Public Property VerDEPARTAMENTO_NACIMIENTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("DEPARTAMENTO_NACIMIENTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DEPARTAMENTO_NACIMIENTO").Visible = Value
        End Set
    End Property

    Public Property VerMUNICIPIO_NACIMIENTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MUNICIPIO_NACIMIENTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MUNICIPIO_NACIMIENTO").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_NACIMIENTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_NACIMIENTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_NACIMIENTO").Visible = Value
        End Set
    End Property

    Public Property VerSEXO() As Boolean
        Get
            Return Me.dxgvLista.Columns("SEXO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SEXO").Visible = Value
        End Set
    End Property

    Public Property VerEDAD() As Boolean
        Get
            Return Me.dxgvLista.Columns("EDAD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EDAD").Visible = Value
        End Set
    End Property

    Public Property VerES_JEFE_DE_HOGAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("ES_JEFE_DE_HOGAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ES_JEFE_DE_HOGAR").Visible = Value
        End Set
    End Property

    Public Property VerESTADO_FAMILIAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("ESTADO_FAMILIAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ESTADO_FAMILIAR").Visible = Value
        End Set
    End Property

    Public Property VerTIENE_HIJOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIENE_HIJOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIENE_HIJOS").Visible = Value
        End Set
    End Property

    Public Property VerNO_DE_HIJOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_DE_HIJOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_DE_HIJOS").Visible = Value
        End Set
    End Property

    Public Property VerPERSONAS_GRUPO_FAMILIAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("PERSONAS_GRUPO_FAMILIAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PERSONAS_GRUPO_FAMILIAR").Visible = Value
        End Set
    End Property

    Public Property VerSE_DEDICA_ALGUNA_PROFESION() As Boolean
        Get
            Return Me.dxgvLista.Columns("SE_DEDICA_ALGUNA_PROFESION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SE_DEDICA_ALGUNA_PROFESION").Visible = Value
        End Set
    End Property

    Public Property VerPROFESION_SE_DEDICA() As Boolean
        Get
            Return Me.dxgvLista.Columns("PROFESION_SE_DEDICA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PROFESION_SE_DEDICA").Visible = Value
        End Set
    End Property

    Public Property VerDIRECCION() As Boolean
        Get
            Return Me.dxgvLista.Columns("DIRECCION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DIRECCION").Visible = Value
        End Set
    End Property

    Public Property VerDEPARTAMENTO_RESIDENCIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("DEPARTAMENTO_RESIDENCIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DEPARTAMENTO_RESIDENCIA").Visible = Value
        End Set
    End Property

    Public Property VerMUNICIPIO_RESIDENCIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("MUNICIPIO_RESIDENCIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MUNICIPIO_RESIDENCIA").Visible = Value
        End Set
    End Property

    Public Property VerTELEFONO_FIJO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TELEFONO_FIJO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TELEFONO_FIJO").Visible = Value
        End Set
    End Property

    Public Property VerTELEFONO_MOVIL() As Boolean
        Get
            Return Me.dxgvLista.Columns("TELEFONO_MOVIL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TELEFONO_MOVIL").Visible = Value
        End Set
    End Property

    Public Property VerCORREO_ELECTRONICO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CORREO_ELECTRONICO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CORREO_ELECTRONICO").Visible = Value
        End Set
    End Property

    Public Property VerDISCAPACITADO_PERMANENTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("DISCAPACITADO_PERMANENTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DISCAPACITADO_PERMANENTE").Visible = Value
        End Set
    End Property

    Public Property VerDISCAP_MOVERSE_CAMINAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("DISCAP_MOVERSE_CAMINAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DISCAP_MOVERSE_CAMINAR").Visible = Value
        End Set
    End Property

    Public Property VerDISCAP_USAR_BRAZOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("DISCAP_USAR_BRAZOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DISCAP_USAR_BRAZOS").Visible = Value
        End Set
    End Property

    Public Property VerDISCAP_VER() As Boolean
        Get
            Return Me.dxgvLista.Columns("DISCAP_VER").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DISCAP_VER").Visible = Value
        End Set
    End Property

    Public Property VerDISCAP_OIR() As Boolean
        Get
            Return Me.dxgvLista.Columns("DISCAP_OIR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DISCAP_OIR").Visible = Value
        End Set
    End Property

    Public Property VerDISCAP_HABLAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("DISCAP_HABLAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DISCAP_HABLAR").Visible = Value
        End Set
    End Property

    Public Property VerDISCAP_RETRASO() As Boolean
        Get
            Return Me.dxgvLista.Columns("DISCAP_RETRASO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DISCAP_RETRASO").Visible = Value
        End Set
    End Property

    Public Property VerDISCAP_BANARSE() As Boolean
        Get
            Return Me.dxgvLista.Columns("DISCAP_BANARSE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DISCAP_BANARSE").Visible = Value
        End Set
    End Property

    Public Property VerDISCAP_EXPLIQUE() As Boolean
        Get
            Return Me.dxgvLista.Columns("DISCAP_EXPLIQUE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DISCAP_EXPLIQUE").Visible = Value
        End Set
    End Property

    Public Property VerSABE_LEER_ESCRIBIR() As Boolean
        Get
            Return Me.dxgvLista.Columns("SABE_LEER_ESCRIBIR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SABE_LEER_ESCRIBIR").Visible = Value
        End Set
    End Property

    Public Property VerSOLO_LEE() As Boolean
        Get
            Return Me.dxgvLista.Columns("SOLO_LEE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SOLO_LEE").Visible = Value
        End Set
    End Property

    Public Property VerSOLO_ESCRIBE() As Boolean
        Get
            Return Me.dxgvLista.Columns("SOLO_ESCRIBE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SOLO_ESCRIBE").Visible = Value
        End Set
    End Property

    Public Property VerSOLO_FIRMA() As Boolean
        Get
            Return Me.dxgvLista.Columns("SOLO_FIRMA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SOLO_FIRMA").Visible = Value
        End Set
    End Property

    Public Property VerEDUCACION_BASICA() As Boolean
        Get
            Return Me.dxgvLista.Columns("EDUCACION_BASICA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EDUCACION_BASICA").Visible = Value
        End Set
    End Property

    Public Property VerBACHILLERATO() As Boolean
        Get
            Return Me.dxgvLista.Columns("BACHILLERATO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("BACHILLERATO").Visible = Value
        End Set
    End Property

    Public Property VerTECNOLOGICA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TECNOLOGICA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TECNOLOGICA").Visible = Value
        End Set
    End Property

    Public Property VerUNIVERSITARIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("UNIVERSITARIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("UNIVERSITARIA").Visible = Value
        End Set
    End Property

    Public Property VerOTRA_EDUCACION_FORMAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("OTRA_EDUCACION_FORMAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OTRA_EDUCACION_FORMAL").Visible = Value
        End Set
    End Property

    Public Property VerTITULO_OBTENIDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TITULO_OBTENIDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TITULO_OBTENIDO").Visible = Value
        End Set
    End Property

    Public Property VerHA_DEJADO_DE_ESTUDIAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("HA_DEJADO_DE_ESTUDIAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("HA_DEJADO_DE_ESTUDIAR").Visible = Value
        End Set
    End Property

    Public Property VerTIEMPO_DEJO_ESTUDIAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIEMPO_DEJO_ESTUDIAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIEMPO_DEJO_ESTUDIAR").Visible = Value
        End Set
    End Property

    Public Property VerHA_RECIBIDO_CURSOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("HA_RECIBIDO_CURSOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("HA_RECIBIDO_CURSOS").Visible = Value
        End Set
    End Property

    Public Property VerCURSO_1() As Boolean
        Get
            Return Me.dxgvLista.Columns("CURSO_1").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CURSO_1").Visible = Value
        End Set
    End Property

    Public Property VerCURSO_2() As Boolean
        Get
            Return Me.dxgvLista.Columns("CURSO_2").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CURSO_2").Visible = Value
        End Set
    End Property

    Public Property VerCURSO_3() As Boolean
        Get
            Return Me.dxgvLista.Columns("CURSO_3").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CURSO_3").Visible = Value
        End Set
    End Property

    Public Property VerIMPARTIO_INSAFORP_CURSO_1() As Boolean
        Get
            Return Me.dxgvLista.Columns("IMPARTIO_INSAFORP_CURSO_1").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("IMPARTIO_INSAFORP_CURSO_1").Visible = Value
        End Set
    End Property

    Public Property VerIMPARTIO_INSAFORP_CURSO_2() As Boolean
        Get
            Return Me.dxgvLista.Columns("IMPARTIO_INSAFORP_CURSO_2").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("IMPARTIO_INSAFORP_CURSO_2").Visible = Value
        End Set
    End Property

    Public Property VerIMPARTIO_INSAFORP_CURSO_3() As Boolean
        Get
            Return Me.dxgvLista.Columns("IMPARTIO_INSAFORP_CURSO_3").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("IMPARTIO_INSAFORP_CURSO_3").Visible = Value
        End Set
    End Property

    Public Property VerANO_CURSO_1() As Boolean
        Get
            Return Me.dxgvLista.Columns("ANO_CURSO_1").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ANO_CURSO_1").Visible = Value
        End Set
    End Property

    Public Property VerANO_CURSO_2() As Boolean
        Get
            Return Me.dxgvLista.Columns("ANO_CURSO_2").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ANO_CURSO_2").Visible = Value
        End Set
    End Property

    Public Property VerANO_CURSO_3() As Boolean
        Get
            Return Me.dxgvLista.Columns("ANO_CURSO_3").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ANO_CURSO_3").Visible = Value
        End Set
    End Property

    Public Property VerCURSO_LE_DIO_BENEFICIOS_1() As Boolean
        Get
            Return Me.dxgvLista.Columns("CURSO_LE_DIO_BENEFICIOS_1").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CURSO_LE_DIO_BENEFICIOS_1").Visible = Value
        End Set
    End Property

    Public Property VerCURSO_LE_DIO_BENEFICIOS_2() As Boolean
        Get
            Return Me.dxgvLista.Columns("CURSO_LE_DIO_BENEFICIOS_2").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CURSO_LE_DIO_BENEFICIOS_2").Visible = Value
        End Set
    End Property

    Public Property VerCURSO_LE_DIO_BENEFICIOS_3() As Boolean
        Get
            Return Me.dxgvLista.Columns("CURSO_LE_DIO_BENEFICIOS_3").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CURSO_LE_DIO_BENEFICIOS_3").Visible = Value
        End Set
    End Property

    Public Property VerSIRVIO_CAPAC_OBTENER_EMPLEO() As Boolean
        Get
            Return Me.dxgvLista.Columns("SIRVIO_CAPAC_OBTENER_EMPLEO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SIRVIO_CAPAC_OBTENER_EMPLEO").Visible = Value
        End Set
    End Property

    Public Property VerSIRVIO_CAPAC_CAMBIAR_EMPLEO() As Boolean
        Get
            Return Me.dxgvLista.Columns("SIRVIO_CAPAC_CAMBIAR_EMPLEO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SIRVIO_CAPAC_CAMBIAR_EMPLEO").Visible = Value
        End Set
    End Property

    Public Property VerSIRVIO_CAPAC_TRAB_CTA_PROPIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("SIRVIO_CAPAC_TRAB_CTA_PROPIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SIRVIO_CAPAC_TRAB_CTA_PROPIA").Visible = Value
        End Set
    End Property

    Public Property VerSIRVIO_CAPAC_OTROS_INGRESOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("SIRVIO_CAPAC_OTROS_INGRESOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SIRVIO_CAPAC_OTROS_INGRESOS").Visible = Value
        End Set
    End Property

    Public Property VerSIRVIO_CAPAC_PROMOCION() As Boolean
        Get
            Return Me.dxgvLista.Columns("SIRVIO_CAPAC_PROMOCION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SIRVIO_CAPAC_PROMOCION").Visible = Value
        End Set
    End Property

    Public Property VerSIRVIO_CAPAC_OTRO() As Boolean
        Get
            Return Me.dxgvLista.Columns("SIRVIO_CAPAC_OTRO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SIRVIO_CAPAC_OTRO").Visible = Value
        End Set
    End Property

    Public Property VerPORQUE_NO_RECIB_BENEFICIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("PORQUE_NO_RECIB_BENEFICIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PORQUE_NO_RECIB_BENEFICIO").Visible = Value
        End Set
    End Property

    Public Property VerREALIZA_ACTIVIDAD_INGRESOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("REALIZA_ACTIVIDAD_INGRESOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("REALIZA_ACTIVIDAD_INGRESOS").Visible = Value
        End Set
    End Property

    Public Property VerMEDIO_DE_INGRESO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MEDIO_DE_INGRESO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MEDIO_DE_INGRESO").Visible = Value
        End Set
    End Property

    Public Property VerACT_INGRESOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("ACT_INGRESOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ACT_INGRESOS").Visible = Value
        End Set
    End Property

    Public Property VerAPELLIDOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("APELLIDOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("APELLIDOS").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRES() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRES").Visible = Value
        End Set
    End Property

    Public Property VerOTRA_ACTIVIDAD_ESTUDIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("OTRA_ACTIVIDAD_ESTUDIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OTRA_ACTIVIDAD_ESTUDIA").Visible = Value
        End Set
    End Property

    Public Property VerOTRA_ACTIVIDAD_OFICIOS_HOGAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("OTRA_ACTIVIDAD_OFICIOS_HOGAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OTRA_ACTIVIDAD_OFICIOS_HOGAR").Visible = Value
        End Set
    End Property

    Public Property VerOTRA_ACTIVIDAD_BUSCA_TRABAJO() As Boolean
        Get
            Return Me.dxgvLista.Columns("OTRA_ACTIVIDAD_BUSCA_TRABAJO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OTRA_ACTIVIDAD_BUSCA_TRABAJO").Visible = Value
        End Set
    End Property

    Public Property VerOTRA_ACTIVIDAD_OTRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("OTRA_ACTIVIDAD_OTRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OTRA_ACTIVIDAD_OTRA").Visible = Value
        End Set
    End Property

    Public Property VerTIPO_DE_EMPLEO_TIEMPO_COMP() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO_DE_EMPLEO_TIEMPO_COMP").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO_DE_EMPLEO_TIEMPO_COMP").Visible = Value
        End Set
    End Property

    Public Property VerTIPO_DE_EMPLEO_NEG_FAMILIAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO_DE_EMPLEO_NEG_FAMILIAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO_DE_EMPLEO_NEG_FAMILIAR").Visible = Value
        End Set
    End Property

    Public Property VerTIPO_DE_EMPLEO_MEDIO_TIEMPO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO_DE_EMPLEO_MEDIO_TIEMPO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO_DE_EMPLEO_MEDIO_TIEMPO").Visible = Value
        End Set
    End Property

    Public Property VerTIPO_DE_EMPLEO_CTA_PROPIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO_DE_EMPLEO_CTA_PROPIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO_DE_EMPLEO_CTA_PROPIA").Visible = Value
        End Set
    End Property

    Public Property VerTIPO_DE_EMPLEO_POR_HORAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO_DE_EMPLEO_POR_HORAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO_DE_EMPLEO_POR_HORAS").Visible = Value
        End Set
    End Property

    Public Property VerTIPO_DE_EMPLEO_TEMPORAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO_DE_EMPLEO_TEMPORAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO_DE_EMPLEO_TEMPORAL").Visible = Value
        End Set
    End Property

    Public Property VerTIPO_DE_EMPLEO_OTRO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIPO_DE_EMPLEO_OTRO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIPO_DE_EMPLEO_OTRO").Visible = Value
        End Set
    End Property

    Public Property VerHA_TRABAJADO_ANTES() As Boolean
        Get
            Return Me.dxgvLista.Columns("HA_TRABAJADO_ANTES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("HA_TRABAJADO_ANTES").Visible = Value
        End Set
    End Property

    Public Property VerTIEMPO_QUE_NO_TRABAJA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIEMPO_QUE_NO_TRABAJA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIEMPO_QUE_NO_TRABAJA").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_EMPRESA_ANTERIOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_EMPRESA_ANTERIOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_EMPRESA_ANTERIOR").Visible = Value
        End Set
    End Property

    Public Property VerDEDICACION_EMPRESA() As Boolean
        Get
            Return Me.dxgvLista.Columns("DEDICACION_EMPRESA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DEDICACION_EMPRESA").Visible = Value
        End Set
    End Property

    'Public Property VerMOTIVO_SALIDA_EMPRESA() As Boolean
    '    Get
    '        Return Me.dxgvLista.Columns("MOTIVO_SALIDA_EMPRESA").Visible
    '    End Get
    '    Set(ByVal Value As Boolean)
    '        Me.dxgvLista.Columns("MOTIVO_SALIDA_EMPRESA").Visible = Value
    '    End Set
    'End Property

    Public Property VerMOTIVO_SALIDA_EMPRESA_OTRAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("MOTIVO_SALIDA_EMPRESA_OTRAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MOTIVO_SALIDA_EMPRESA_OTRAS").Visible = Value
        End Set
    End Property

    Public Property VerPUESTO_EMPRESA() As Boolean
        Get
            Return Me.dxgvLista.Columns("PUESTO_EMPRESA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PUESTO_EMPRESA").Visible = Value
        End Set
    End Property

    Public Property VerTIEMPO_TRABAJO_EMPRESA() As Boolean
        Get
            Return Me.dxgvLista.Columns("TIEMPO_TRABAJO_EMPRESA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TIEMPO_TRABAJO_EMPRESA").Visible = Value
        End Set
    End Property

    Public Property VerRECIBE_INGRESOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("RECIBE_INGRESOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("RECIBE_INGRESOS").Visible = Value
        End Set
    End Property

    Public Property VerMAN_OBTIENE_ING_TRAB_ACT() As Boolean
        Get
            Return Me.dxgvLista.Columns("MAN_OBTIENE_ING_TRAB_ACT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MAN_OBTIENE_ING_TRAB_ACT").Visible = Value
        End Set
    End Property

    Public Property VerMAN_OBTIENE_ING_AYUDA_FAM() As Boolean
        Get
            Return Me.dxgvLista.Columns("MAN_OBTIENE_ING_AYUDA_FAM").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MAN_OBTIENE_ING_AYUDA_FAM").Visible = Value
        End Set
    End Property

    Public Property VerMAN_OBTIENE_ING_REMESA() As Boolean
        Get
            Return Me.dxgvLista.Columns("MAN_OBTIENE_ING_REMESA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MAN_OBTIENE_ING_REMESA").Visible = Value
        End Set
    End Property

    Public Property VerMAN_OBTIENE_ING_PENSION() As Boolean
        Get
            Return Me.dxgvLista.Columns("MAN_OBTIENE_ING_PENSION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MAN_OBTIENE_ING_PENSION").Visible = Value
        End Set
    End Property

    Public Property VerMAN_OBTIENE_ING_TRAB_ACT_REM() As Boolean
        Get
            Return Me.dxgvLista.Columns("MAN_OBTIENE_ING_TRAB_ACT_REM").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MAN_OBTIENE_ING_TRAB_ACT_REM").Visible = Value
        End Set
    End Property

    Public Property VerMAN_OBTIENE_ING_OTRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("MAN_OBTIENE_ING_OTRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MAN_OBTIENE_ING_OTRA").Visible = Value
        End Set
    End Property

    Public Property VerINGRESO_PERSONAL_MENSUAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("INGRESO_PERSONAL_MENSUAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("INGRESO_PERSONAL_MENSUAL").Visible = Value
        End Set
    End Property

    Public Property VerINGRESO_PERSONAL_DIARIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("INGRESO_PERSONAL_DIARIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("INGRESO_PERSONAL_DIARIO").Visible = Value
        End Set
    End Property

    Public Property VerQUE_GUSTARIA_APRENDER_1() As Boolean
        Get
            Return Me.dxgvLista.Columns("QUE_GUSTARIA_APRENDER_1").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("QUE_GUSTARIA_APRENDER_1").Visible = Value
        End Set
    End Property

    Public Property VerQUE_GUSTARIA_APRENDER_2() As Boolean
        Get
            Return Me.dxgvLista.Columns("QUE_GUSTARIA_APRENDER_2").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("QUE_GUSTARIA_APRENDER_2").Visible = Value
        End Set
    End Property

    Public Property VerQUE_GUSTARIA_APRENDER_3() As Boolean
        Get
            Return Me.dxgvLista.Columns("QUE_GUSTARIA_APRENDER_3").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("QUE_GUSTARIA_APRENDER_3").Visible = Value
        End Set
    End Property

    Public Property VerLOGROS_ESPERADOS_EMPLEO_FORMAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("LOGROS_ESPERADOS_EMPLEO_FORMAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LOGROS_ESPERADOS_EMPLEO_FORMAL").Visible = Value
        End Set
    End Property

    Public Property VerLOGROS_ESPERADOS_CUENTA_PROPIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("LOGROS_ESPERADOS_CUENTA_PROPIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LOGROS_ESPERADOS_CUENTA_PROPIA").Visible = Value
        End Set
    End Property

    Public Property VerLOGROS_ESPERADOS_OTRO() As Boolean
        Get
            Return Me.dxgvLista.Columns("LOGROS_ESPERADOS_OTRO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LOGROS_ESPERADOS_OTRO").Visible = Value
        End Set
    End Property

    Public Property VerGUSTO_UBICACION_TRABAJO() As Boolean
        Get
            Return Me.dxgvLista.Columns("GUSTO_UBICACION_TRABAJO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("GUSTO_UBICACION_TRABAJO").Visible = Value
        End Set
    End Property

    Public Property VerEN_QUE_OCUP_DINERO_AYUDAR() As Boolean
        Get
            Return Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_AYUDAR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_AYUDAR").Visible = Value
        End Set
    End Property

    Public Property VerEN_QUE_OCUP_DINERO_INDEPEND() As Boolean
        Get
            Return Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_INDEPEND").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_INDEPEND").Visible = Value
        End Set
    End Property

    Public Property VerEN_QUE_OCUP_DINERO_MANT_HIJOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_MANT_HIJOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_MANT_HIJOS").Visible = Value
        End Set
    End Property

    Public Property VerEN_QUE_OCUP_DINERO_MANT_PADRES() As Boolean
        Get
            Return Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_MANT_PADRES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_MANT_PADRES").Visible = Value
        End Set
    End Property

    Public Property VerEN_QUE_OCUP_DINERO_PAGAR_ESTUD() As Boolean
        Get
            Return Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_PAGAR_ESTUD").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_PAGAR_ESTUD").Visible = Value
        End Set
    End Property

    Public Property VerEN_QUE_OCUP_DINERO_OTRO() As Boolean
        Get
            Return Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_OTRO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_OTRO").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRES_CONOCIDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRES_CONOCIDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRES_CONOCIDO").Visible = Value
        End Set
    End Property

    Public Property VerPARENTESCO() As Boolean
        Get
            Return Me.dxgvLista.Columns("PARENTESCO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PARENTESCO").Visible = Value
        End Set
    End Property

    Public Property VerDIRECCION_CONOCIDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("DIRECCION_CONOCIDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DIRECCION_CONOCIDO").Visible = Value
        End Set
    End Property

    Public Property VerDEPARTAMENTO_CONOCIDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("DEPARTAMENTO_CONOCIDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DEPARTAMENTO_CONOCIDO").Visible = Value
        End Set
    End Property

    Public Property VerMUNICIPIO_CONOCIDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MUNICIPIO_CONOCIDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MUNICIPIO_CONOCIDO").Visible = Value
        End Set
    End Property

    Public Property VerTELEFONO_FIJO_CONOCIDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TELEFONO_FIJO_CONOCIDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TELEFONO_FIJO_CONOCIDO").Visible = Value
        End Set
    End Property

    Public Property VerTELEFONO_MOVIL_CONOCIDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TELEFONO_MOVIL_CONOCIDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TELEFONO_MOVIL_CONOCIDO").Visible = Value
        End Set
    End Property

    Public Property VerEMAIL_CONOCIDO() As Boolean
        Get
            Return Me.dxgvLista.Columns("EMAIL_CONOCIDO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EMAIL_CONOCIDO").Visible = Value
        End Set
    End Property

    Public Property VerOBSERVACIONES_SUGERENCIAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("OBSERVACIONES_SUGERENCIAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OBSERVACIONES_SUGERENCIAS").Visible = Value
        End Set
    End Property

    Public Property VerUSERID() As Boolean
        Get
            Return Me.dxgvLista.Columns("USERID").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USERID").Visible = Value
        End Set
    End Property

    Public Property VerLASTUPDATE() As Boolean
        Get
            Return Me.dxgvLista.Columns("LASTUPDATE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LASTUPDATE").Visible = Value
        End Set
    End Property

    Public Property HeaderNUME_FICH() As String
        Get
            Return Me.dxgvLista.Columns("NUME_FICH").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NUME_FICH").Caption = Value
        End Set
    End Property

    Public Property HeaderID_ENTREVISTADOR() As String
        Get
            Return Me.dxgvLista.Columns("ID_ENTREVISTADOR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ENTREVISTADOR").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMB_CASERIO_AUP() As String
        Get
            Return Me.dxgvLista.Columns("NOMB_CASERIO_AUP").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMB_CASERIO_AUP").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_ING_FICHA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_ING_FICHA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_ING_FICHA").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIGO_PROYECTO() As String
        Get
            Return Me.dxgvLista.Columns("CODIGO_PROYECTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIGO_PROYECTO").Caption = Value
        End Set
    End Property

    Public Property HeaderPRIMER_NOMBRE() As String
        Get
            Return Me.dxgvLista.Columns("PRIMER_NOMBRE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PRIMER_NOMBRE").Caption = Value
        End Set
    End Property

    Public Property HeaderSEGUNDO_NOMBRE() As String
        Get
            Return Me.dxgvLista.Columns("SEGUNDO_NOMBRE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SEGUNDO_NOMBRE").Caption = Value
        End Set
    End Property

    Public Property HeaderTERCER_NOMBRE() As String
        Get
            Return Me.dxgvLista.Columns("TERCER_NOMBRE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TERCER_NOMBRE").Caption = Value
        End Set
    End Property

    Public Property HeaderPRIMER_APELLIDO() As String
        Get
            Return Me.dxgvLista.Columns("PRIMER_APELLIDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PRIMER_APELLIDO").Caption = Value
        End Set
    End Property

    Public Property HeaderSEGUNDO_APELLIDO() As String
        Get
            Return Me.dxgvLista.Columns("SEGUNDO_APELLIDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SEGUNDO_APELLIDO").Caption = Value
        End Set
    End Property

    Public Property HeaderTERCER_APELLIDO() As String
        Get
            Return Me.dxgvLista.Columns("TERCER_APELLIDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TERCER_APELLIDO").Caption = Value
        End Set
    End Property

    Public Property HeaderES_SALVADORENO() As String
        Get
            Return Me.dxgvLista.Columns("ES_SALVADORENO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ES_SALVADORENO").Caption = Value
        End Set
    End Property

    Public Property HeaderPAIS() As String
        Get
            Return Me.dxgvLista.Columns("PAIS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PAIS").Caption = Value
        End Set
    End Property

    Public Property HeaderDUI() As String
        Get
            Return Me.dxgvLista.Columns("DUI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DUI").Caption = Value
        End Set
    End Property

    Public Property HeaderCEDULA_IDENTIDAD() As String
        Get
            Return Me.dxgvLista.Columns("CEDULA_IDENTIDAD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CEDULA_IDENTIDAD").Caption = Value
        End Set
    End Property

    Public Property HeaderCARNET_MINORIDAD() As String
        Get
            Return Me.dxgvLista.Columns("CARNET_MINORIDAD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CARNET_MINORIDAD").Caption = Value
        End Set
    End Property

    Public Property HeaderPASAPORTE() As String
        Get
            Return Me.dxgvLista.Columns("PASAPORTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PASAPORTE").Caption = Value
        End Set
    End Property

    Public Property HeaderDEPARTAMENTO_NACIMIENTO() As String
        Get
            Return Me.dxgvLista.Columns("DEPARTAMENTO_NACIMIENTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DEPARTAMENTO_NACIMIENTO").Caption = Value
        End Set
    End Property

    Public Property HeaderMUNICIPIO_NACIMIENTO() As String
        Get
            Return Me.dxgvLista.Columns("MUNICIPIO_NACIMIENTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MUNICIPIO_NACIMIENTO").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_NACIMIENTO() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_NACIMIENTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_NACIMIENTO").Caption = Value
        End Set
    End Property

    Public Property HeaderSEXO() As String
        Get
            Return Me.dxgvLista.Columns("SEXO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SEXO").Caption = Value
        End Set
    End Property

    Public Property HeaderEDAD() As String
        Get
            Return Me.dxgvLista.Columns("EDAD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EDAD").Caption = Value
        End Set
    End Property

    Public Property HeaderES_JEFE_DE_HOGAR() As String
        Get
            Return Me.dxgvLista.Columns("ES_JEFE_DE_HOGAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ES_JEFE_DE_HOGAR").Caption = Value
        End Set
    End Property

    Public Property HeaderESTADO_FAMILIAR() As String
        Get
            Return Me.dxgvLista.Columns("ESTADO_FAMILIAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ESTADO_FAMILIAR").Caption = Value
        End Set
    End Property

    Public Property HeaderTIENE_HIJOS() As String
        Get
            Return Me.dxgvLista.Columns("TIENE_HIJOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TIENE_HIJOS").Caption = Value
        End Set
    End Property

    Public Property HeaderNO_DE_HIJOS() As String
        Get
            Return Me.dxgvLista.Columns("NO_DE_HIJOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_DE_HIJOS").Caption = Value
        End Set
    End Property

    Public Property HeaderPERSONAS_GRUPO_FAMILIAR() As String
        Get
            Return Me.dxgvLista.Columns("PERSONAS_GRUPO_FAMILIAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PERSONAS_GRUPO_FAMILIAR").Caption = Value
        End Set
    End Property

    Public Property HeaderSE_DEDICA_ALGUNA_PROFESION() As String
        Get
            Return Me.dxgvLista.Columns("SE_DEDICA_ALGUNA_PROFESION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SE_DEDICA_ALGUNA_PROFESION").Caption = Value
        End Set
    End Property

    Public Property HeaderPROFESION_SE_DEDICA() As String
        Get
            Return Me.dxgvLista.Columns("PROFESION_SE_DEDICA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PROFESION_SE_DEDICA").Caption = Value
        End Set
    End Property

    Public Property HeaderDIRECCION() As String
        Get
            Return Me.dxgvLista.Columns("DIRECCION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DIRECCION").Caption = Value
        End Set
    End Property

    Public Property HeaderDEPARTAMENTO_RESIDENCIA() As String
        Get
            Return Me.dxgvLista.Columns("DEPARTAMENTO_RESIDENCIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DEPARTAMENTO_RESIDENCIA").Caption = Value
        End Set
    End Property

    Public Property HeaderMUNICIPIO_RESIDENCIA() As String
        Get
            Return Me.dxgvLista.Columns("MUNICIPIO_RESIDENCIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MUNICIPIO_RESIDENCIA").Caption = Value
        End Set
    End Property

    Public Property HeaderTELEFONO_FIJO() As String
        Get
            Return Me.dxgvLista.Columns("TELEFONO_FIJO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TELEFONO_FIJO").Caption = Value
        End Set
    End Property

    Public Property HeaderTELEFONO_MOVIL() As String
        Get
            Return Me.dxgvLista.Columns("TELEFONO_MOVIL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TELEFONO_MOVIL").Caption = Value
        End Set
    End Property

    Public Property HeaderCORREO_ELECTRONICO() As String
        Get
            Return Me.dxgvLista.Columns("CORREO_ELECTRONICO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CORREO_ELECTRONICO").Caption = Value
        End Set
    End Property

    Public Property HeaderDISCAPACITADO_PERMANENTE() As String
        Get
            Return Me.dxgvLista.Columns("DISCAPACITADO_PERMANENTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DISCAPACITADO_PERMANENTE").Caption = Value
        End Set
    End Property

    Public Property HeaderDISCAP_MOVERSE_CAMINAR() As String
        Get
            Return Me.dxgvLista.Columns("DISCAP_MOVERSE_CAMINAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DISCAP_MOVERSE_CAMINAR").Caption = Value
        End Set
    End Property

    Public Property HeaderDISCAP_USAR_BRAZOS() As String
        Get
            Return Me.dxgvLista.Columns("DISCAP_USAR_BRAZOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DISCAP_USAR_BRAZOS").Caption = Value
        End Set
    End Property

    Public Property HeaderDISCAP_VER() As String
        Get
            Return Me.dxgvLista.Columns("DISCAP_VER").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DISCAP_VER").Caption = Value
        End Set
    End Property

    Public Property HeaderDISCAP_OIR() As String
        Get
            Return Me.dxgvLista.Columns("DISCAP_OIR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DISCAP_OIR").Caption = Value
        End Set
    End Property

    Public Property HeaderDISCAP_HABLAR() As String
        Get
            Return Me.dxgvLista.Columns("DISCAP_HABLAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DISCAP_HABLAR").Caption = Value
        End Set
    End Property

    Public Property HeaderDISCAP_RETRASO() As String
        Get
            Return Me.dxgvLista.Columns("DISCAP_RETRASO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DISCAP_RETRASO").Caption = Value
        End Set
    End Property

    Public Property HeaderDISCAP_BANARSE() As String
        Get
            Return Me.dxgvLista.Columns("DISCAP_BANARSE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DISCAP_BANARSE").Caption = Value
        End Set
    End Property

    Public Property HeaderDISCAP_EXPLIQUE() As String
        Get
            Return Me.dxgvLista.Columns("DISCAP_EXPLIQUE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DISCAP_EXPLIQUE").Caption = Value
        End Set
    End Property

    Public Property HeaderSABE_LEER_ESCRIBIR() As String
        Get
            Return Me.dxgvLista.Columns("SABE_LEER_ESCRIBIR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SABE_LEER_ESCRIBIR").Caption = Value
        End Set
    End Property

    Public Property HeaderSOLO_LEE() As String
        Get
            Return Me.dxgvLista.Columns("SOLO_LEE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SOLO_LEE").Caption = Value
        End Set
    End Property

    Public Property HeaderSOLO_ESCRIBE() As String
        Get
            Return Me.dxgvLista.Columns("SOLO_ESCRIBE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SOLO_ESCRIBE").Caption = Value
        End Set
    End Property

    Public Property HeaderSOLO_FIRMA() As String
        Get
            Return Me.dxgvLista.Columns("SOLO_FIRMA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SOLO_FIRMA").Caption = Value
        End Set
    End Property

    Public Property HeaderEDUCACION_BASICA() As String
        Get
            Return Me.dxgvLista.Columns("EDUCACION_BASICA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EDUCACION_BASICA").Caption = Value
        End Set
    End Property

    Public Property HeaderBACHILLERATO() As String
        Get
            Return Me.dxgvLista.Columns("BACHILLERATO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("BACHILLERATO").Caption = Value
        End Set
    End Property

    Public Property HeaderTECNOLOGICA() As String
        Get
            Return Me.dxgvLista.Columns("TECNOLOGICA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TECNOLOGICA").Caption = Value
        End Set
    End Property

    Public Property HeaderUNIVERSITARIA() As String
        Get
            Return Me.dxgvLista.Columns("UNIVERSITARIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("UNIVERSITARIA").Caption = Value
        End Set
    End Property

    Public Property HeaderOTRA_EDUCACION_FORMAL() As String
        Get
            Return Me.dxgvLista.Columns("OTRA_EDUCACION_FORMAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OTRA_EDUCACION_FORMAL").Caption = Value
        End Set
    End Property

    Public Property HeaderTITULO_OBTENIDO() As String
        Get
            Return Me.dxgvLista.Columns("TITULO_OBTENIDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TITULO_OBTENIDO").Caption = Value
        End Set
    End Property

    Public Property HeaderHA_DEJADO_DE_ESTUDIAR() As String
        Get
            Return Me.dxgvLista.Columns("HA_DEJADO_DE_ESTUDIAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("HA_DEJADO_DE_ESTUDIAR").Caption = Value
        End Set
    End Property

    Public Property HeaderTIEMPO_DEJO_ESTUDIAR() As String
        Get
            Return Me.dxgvLista.Columns("TIEMPO_DEJO_ESTUDIAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TIEMPO_DEJO_ESTUDIAR").Caption = Value
        End Set
    End Property

    Public Property HeaderHA_RECIBIDO_CURSOS() As String
        Get
            Return Me.dxgvLista.Columns("HA_RECIBIDO_CURSOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("HA_RECIBIDO_CURSOS").Caption = Value
        End Set
    End Property

    Public Property HeaderCURSO_1() As String
        Get
            Return Me.dxgvLista.Columns("CURSO_1").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CURSO_1").Caption = Value
        End Set
    End Property

    Public Property HeaderCURSO_2() As String
        Get
            Return Me.dxgvLista.Columns("CURSO_2").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CURSO_2").Caption = Value
        End Set
    End Property

    Public Property HeaderCURSO_3() As String
        Get
            Return Me.dxgvLista.Columns("CURSO_3").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CURSO_3").Caption = Value
        End Set
    End Property

    Public Property HeaderIMPARTIO_INSAFORP_CURSO_1() As String
        Get
            Return Me.dxgvLista.Columns("IMPARTIO_INSAFORP_CURSO_1").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("IMPARTIO_INSAFORP_CURSO_1").Caption = Value
        End Set
    End Property

    Public Property HeaderIMPARTIO_INSAFORP_CURSO_2() As String
        Get
            Return Me.dxgvLista.Columns("IMPARTIO_INSAFORP_CURSO_2").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("IMPARTIO_INSAFORP_CURSO_2").Caption = Value
        End Set
    End Property

    Public Property HeaderIMPARTIO_INSAFORP_CURSO_3() As String
        Get
            Return Me.dxgvLista.Columns("IMPARTIO_INSAFORP_CURSO_3").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("IMPARTIO_INSAFORP_CURSO_3").Caption = Value
        End Set
    End Property

    Public Property HeaderANO_CURSO_1() As String
        Get
            Return Me.dxgvLista.Columns("ANO_CURSO_1").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ANO_CURSO_1").Caption = Value
        End Set
    End Property

    Public Property HeaderANO_CURSO_2() As String
        Get
            Return Me.dxgvLista.Columns("ANO_CURSO_2").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ANO_CURSO_2").Caption = Value
        End Set
    End Property

    Public Property HeaderANO_CURSO_3() As String
        Get
            Return Me.dxgvLista.Columns("ANO_CURSO_3").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ANO_CURSO_3").Caption = Value
        End Set
    End Property

    Public Property HeaderCURSO_LE_DIO_BENEFICIOS_1() As String
        Get
            Return Me.dxgvLista.Columns("CURSO_LE_DIO_BENEFICIOS_1").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CURSO_LE_DIO_BENEFICIOS_1").Caption = Value
        End Set
    End Property

    Public Property HeaderCURSO_LE_DIO_BENEFICIOS_2() As String
        Get
            Return Me.dxgvLista.Columns("CURSO_LE_DIO_BENEFICIOS_2").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CURSO_LE_DIO_BENEFICIOS_2").Caption = Value
        End Set
    End Property

    Public Property HeaderCURSO_LE_DIO_BENEFICIOS_3() As String
        Get
            Return Me.dxgvLista.Columns("CURSO_LE_DIO_BENEFICIOS_3").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CURSO_LE_DIO_BENEFICIOS_3").Caption = Value
        End Set
    End Property

    Public Property HeaderSIRVIO_CAPAC_OBTENER_EMPLEO() As String
        Get
            Return Me.dxgvLista.Columns("SIRVIO_CAPAC_OBTENER_EMPLEO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SIRVIO_CAPAC_OBTENER_EMPLEO").Caption = Value
        End Set
    End Property

    Public Property HeaderSIRVIO_CAPAC_CAMBIAR_EMPLEO() As String
        Get
            Return Me.dxgvLista.Columns("SIRVIO_CAPAC_CAMBIAR_EMPLEO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SIRVIO_CAPAC_CAMBIAR_EMPLEO").Caption = Value
        End Set
    End Property

    Public Property HeaderSIRVIO_CAPAC_TRAB_CTA_PROPIA() As String
        Get
            Return Me.dxgvLista.Columns("SIRVIO_CAPAC_TRAB_CTA_PROPIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SIRVIO_CAPAC_TRAB_CTA_PROPIA").Caption = Value
        End Set
    End Property

    Public Property HeaderSIRVIO_CAPAC_OTROS_INGRESOS() As String
        Get
            Return Me.dxgvLista.Columns("SIRVIO_CAPAC_OTROS_INGRESOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SIRVIO_CAPAC_OTROS_INGRESOS").Caption = Value
        End Set
    End Property

    Public Property HeaderSIRVIO_CAPAC_PROMOCION() As String
        Get
            Return Me.dxgvLista.Columns("SIRVIO_CAPAC_PROMOCION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SIRVIO_CAPAC_PROMOCION").Caption = Value
        End Set
    End Property

    Public Property HeaderSIRVIO_CAPAC_OTRO() As String
        Get
            Return Me.dxgvLista.Columns("SIRVIO_CAPAC_OTRO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("SIRVIO_CAPAC_OTRO").Caption = Value
        End Set
    End Property

    Public Property HeaderPORQUE_NO_RECIB_BENEFICIO() As String
        Get
            Return Me.dxgvLista.Columns("PORQUE_NO_RECIB_BENEFICIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PORQUE_NO_RECIB_BENEFICIO").Caption = Value
        End Set
    End Property

    Public Property HeaderREALIZA_ACTIVIDAD_INGRESOS() As String
        Get
            Return Me.dxgvLista.Columns("REALIZA_ACTIVIDAD_INGRESOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("REALIZA_ACTIVIDAD_INGRESOS").Caption = Value
        End Set
    End Property

    Public Property HeaderMEDIO_DE_INGRESO() As String
        Get
            Return Me.dxgvLista.Columns("MEDIO_DE_INGRESO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MEDIO_DE_INGRESO").Caption = Value
        End Set
    End Property

    Public Property HeaderACT_INGRESOS() As String
        Get
            Return Me.dxgvLista.Columns("ACT_INGRESOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ACT_INGRESOS").Caption = Value
        End Set
    End Property

    Public Property HeaderOTRA_ACTIVIDAD_ESTUDIA() As String
        Get
            Return Me.dxgvLista.Columns("OTRA_ACTIVIDAD_ESTUDIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OTRA_ACTIVIDAD_ESTUDIA").Caption = Value
        End Set
    End Property

    Public Property HeaderOTRA_ACTIVIDAD_OFICIOS_HOGAR() As String
        Get
            Return Me.dxgvLista.Columns("OTRA_ACTIVIDAD_OFICIOS_HOGAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OTRA_ACTIVIDAD_OFICIOS_HOGAR").Caption = Value
        End Set
    End Property

    Public Property HeaderOTRA_ACTIVIDAD_BUSCA_TRABAJO() As String
        Get
            Return Me.dxgvLista.Columns("OTRA_ACTIVIDAD_BUSCA_TRABAJO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OTRA_ACTIVIDAD_BUSCA_TRABAJO").Caption = Value
        End Set
    End Property

    Public Property HeaderOTRA_ACTIVIDAD_OTRA() As String
        Get
            Return Me.dxgvLista.Columns("OTRA_ACTIVIDAD_OTRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OTRA_ACTIVIDAD_OTRA").Caption = Value
        End Set
    End Property

    Public Property HeaderTIPO_DE_EMPLEO_TIEMPO_COMP() As String
        Get
            Return Me.dxgvLista.Columns("TIPO_DE_EMPLEO_TIEMPO_COMP").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TIPO_DE_EMPLEO_TIEMPO_COMP").Caption = Value
        End Set
    End Property

    Public Property HeaderTIPO_DE_EMPLEO_NEG_FAMILIAR() As String
        Get
            Return Me.dxgvLista.Columns("TIPO_DE_EMPLEO_NEG_FAMILIAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TIPO_DE_EMPLEO_NEG_FAMILIAR").Caption = Value
        End Set
    End Property

    Public Property HeaderTIPO_DE_EMPLEO_MEDIO_TIEMPO() As String
        Get
            Return Me.dxgvLista.Columns("TIPO_DE_EMPLEO_MEDIO_TIEMPO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TIPO_DE_EMPLEO_MEDIO_TIEMPO").Caption = Value
        End Set
    End Property

    Public Property HeaderTIPO_DE_EMPLEO_CTA_PROPIA() As String
        Get
            Return Me.dxgvLista.Columns("TIPO_DE_EMPLEO_CTA_PROPIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TIPO_DE_EMPLEO_CTA_PROPIA").Caption = Value
        End Set
    End Property

    Public Property HeaderTIPO_DE_EMPLEO_POR_HORAS() As String
        Get
            Return Me.dxgvLista.Columns("TIPO_DE_EMPLEO_POR_HORAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TIPO_DE_EMPLEO_POR_HORAS").Caption = Value
        End Set
    End Property

    Public Property HeaderTIPO_DE_EMPLEO_TEMPORAL() As String
        Get
            Return Me.dxgvLista.Columns("TIPO_DE_EMPLEO_TEMPORAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TIPO_DE_EMPLEO_TEMPORAL").Caption = Value
        End Set
    End Property

    Public Property HeaderTIPO_DE_EMPLEO_OTRO() As String
        Get
            Return Me.dxgvLista.Columns("TIPO_DE_EMPLEO_OTRO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TIPO_DE_EMPLEO_OTRO").Caption = Value
        End Set
    End Property

    Public Property HeaderHA_TRABAJADO_ANTES() As String
        Get
            Return Me.dxgvLista.Columns("HA_TRABAJADO_ANTES").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("HA_TRABAJADO_ANTES").Caption = Value
        End Set
    End Property

    Public Property HeaderTIEMPO_QUE_NO_TRABAJA() As String
        Get
            Return Me.dxgvLista.Columns("TIEMPO_QUE_NO_TRABAJA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TIEMPO_QUE_NO_TRABAJA").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRE_EMPRESA_ANTERIOR() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRE_EMPRESA_ANTERIOR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRE_EMPRESA_ANTERIOR").Caption = Value
        End Set
    End Property

    Public Property HeaderDEDICACION_EMPRESA() As String
        Get
            Return Me.dxgvLista.Columns("DEDICACION_EMPRESA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DEDICACION_EMPRESA").Caption = Value
        End Set
    End Property

    'Public Property HeaderMOTIVO_SALIDA_EMPRESA() As String
    '    Get
    '        Return Me.dxgvLista.Columns("MOTIVO_SALIDA_EMPRESA").Caption
    '    End Get
    '    Set(ByVal Value As String)
    '        Me.dxgvLista.Columns("MOTIVO_SALIDA_EMPRESA").Caption = Value
    '    End Set
    'End Property

    Public Property HeaderMOTIVO_SALIDA_EMPRESA_OTRAS() As String
        Get
            Return Me.dxgvLista.Columns("MOTIVO_SALIDA_EMPRESA_OTRAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MOTIVO_SALIDA_EMPRESA_OTRAS").Caption = Value
        End Set
    End Property

    Public Property HeaderPUESTO_EMPRESA() As String
        Get
            Return Me.dxgvLista.Columns("PUESTO_EMPRESA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PUESTO_EMPRESA").Caption = Value
        End Set
    End Property

    Public Property HeaderTIEMPO_TRABAJO_EMPRESA() As String
        Get
            Return Me.dxgvLista.Columns("TIEMPO_TRABAJO_EMPRESA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TIEMPO_TRABAJO_EMPRESA").Caption = Value
        End Set
    End Property

    Public Property HeaderRECIBE_INGRESOS() As String
        Get
            Return Me.dxgvLista.Columns("RECIBE_INGRESOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("RECIBE_INGRESOS").Caption = Value
        End Set
    End Property

    Public Property HeaderMAN_OBTIENE_ING_TRAB_ACT() As String
        Get
            Return Me.dxgvLista.Columns("MAN_OBTIENE_ING_TRAB_ACT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MAN_OBTIENE_ING_TRAB_ACT").Caption = Value
        End Set
    End Property

    Public Property HeaderMAN_OBTIENE_ING_AYUDA_FAM() As String
        Get
            Return Me.dxgvLista.Columns("MAN_OBTIENE_ING_AYUDA_FAM").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MAN_OBTIENE_ING_AYUDA_FAM").Caption = Value
        End Set
    End Property

    Public Property HeaderMAN_OBTIENE_ING_REMESA() As String
        Get
            Return Me.dxgvLista.Columns("MAN_OBTIENE_ING_REMESA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MAN_OBTIENE_ING_REMESA").Caption = Value
        End Set
    End Property

    Public Property HeaderMAN_OBTIENE_ING_PENSION() As String
        Get
            Return Me.dxgvLista.Columns("MAN_OBTIENE_ING_PENSION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MAN_OBTIENE_ING_PENSION").Caption = Value
        End Set
    End Property

    Public Property HeaderMAN_OBTIENE_ING_TRAB_ACT_REM() As String
        Get
            Return Me.dxgvLista.Columns("MAN_OBTIENE_ING_TRAB_ACT_REM").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MAN_OBTIENE_ING_TRAB_ACT_REM").Caption = Value
        End Set
    End Property

    Public Property HeaderMAN_OBTIENE_ING_OTRA() As String
        Get
            Return Me.dxgvLista.Columns("MAN_OBTIENE_ING_OTRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MAN_OBTIENE_ING_OTRA").Caption = Value
        End Set
    End Property

    Public Property HeaderINGRESO_PERSONAL_MENSUAL() As String
        Get
            Return Me.dxgvLista.Columns("INGRESO_PERSONAL_MENSUAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("INGRESO_PERSONAL_MENSUAL").Caption = Value
        End Set
    End Property

    Public Property HeaderINGRESO_PERSONAL_DIARIO() As String
        Get
            Return Me.dxgvLista.Columns("INGRESO_PERSONAL_DIARIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("INGRESO_PERSONAL_DIARIO").Caption = Value
        End Set
    End Property

    Public Property HeaderQUE_GUSTARIA_APRENDER_1() As String
        Get
            Return Me.dxgvLista.Columns("QUE_GUSTARIA_APRENDER_1").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("QUE_GUSTARIA_APRENDER_1").Caption = Value
        End Set
    End Property

    Public Property HeaderQUE_GUSTARIA_APRENDER_2() As String
        Get
            Return Me.dxgvLista.Columns("QUE_GUSTARIA_APRENDER_2").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("QUE_GUSTARIA_APRENDER_2").Caption = Value
        End Set
    End Property

    Public Property HeaderQUE_GUSTARIA_APRENDER_3() As String
        Get
            Return Me.dxgvLista.Columns("QUE_GUSTARIA_APRENDER_3").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("QUE_GUSTARIA_APRENDER_3").Caption = Value
        End Set
    End Property

    Public Property HeaderLOGROS_ESPERADOS_EMPLEO_FORMAL() As String
        Get
            Return Me.dxgvLista.Columns("LOGROS_ESPERADOS_EMPLEO_FORMAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LOGROS_ESPERADOS_EMPLEO_FORMAL").Caption = Value
        End Set
    End Property

    Public Property HeaderLOGROS_ESPERADOS_CUENTA_PROPIA() As String
        Get
            Return Me.dxgvLista.Columns("LOGROS_ESPERADOS_CUENTA_PROPIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LOGROS_ESPERADOS_CUENTA_PROPIA").Caption = Value
        End Set
    End Property

    Public Property HeaderLOGROS_ESPERADOS_OTRO() As String
        Get
            Return Me.dxgvLista.Columns("LOGROS_ESPERADOS_OTRO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LOGROS_ESPERADOS_OTRO").Caption = Value
        End Set
    End Property

    Public Property HeaderGUSTO_UBICACION_TRABAJO() As String
        Get
            Return Me.dxgvLista.Columns("GUSTO_UBICACION_TRABAJO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("GUSTO_UBICACION_TRABAJO").Caption = Value
        End Set
    End Property

    Public Property HeaderEN_QUE_OCUP_DINERO_AYUDAR() As String
        Get
            Return Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_AYUDAR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_AYUDAR").Caption = Value
        End Set
    End Property

    Public Property HeaderEN_QUE_OCUP_DINERO_INDEPEND() As String
        Get
            Return Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_INDEPEND").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_INDEPEND").Caption = Value
        End Set
    End Property

    Public Property HeaderEN_QUE_OCUP_DINERO_MANT_HIJOS() As String
        Get
            Return Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_MANT_HIJOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_MANT_HIJOS").Caption = Value
        End Set
    End Property

    Public Property HeaderEN_QUE_OCUP_DINERO_MANT_PADRES() As String
        Get
            Return Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_MANT_PADRES").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_MANT_PADRES").Caption = Value
        End Set
    End Property

    Public Property HeaderEN_QUE_OCUP_DINERO_PAGAR_ESTUD() As String
        Get
            Return Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_PAGAR_ESTUD").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_PAGAR_ESTUD").Caption = Value
        End Set
    End Property

    Public Property HeaderEN_QUE_OCUP_DINERO_OTRO() As String
        Get
            Return Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_OTRO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EN_QUE_OCUP_DINERO_OTRO").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRES_CONOCIDO() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRES_CONOCIDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRES_CONOCIDO").Caption = Value
        End Set
    End Property

    Public Property HeaderPARENTESCO() As String
        Get
            Return Me.dxgvLista.Columns("PARENTESCO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PARENTESCO").Caption = Value
        End Set
    End Property

    Public Property HeaderDIRECCION_CONOCIDO() As String
        Get
            Return Me.dxgvLista.Columns("DIRECCION_CONOCIDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DIRECCION_CONOCIDO").Caption = Value
        End Set
    End Property

    Public Property HeaderDEPARTAMENTO_CONOCIDO() As String
        Get
            Return Me.dxgvLista.Columns("DEPARTAMENTO_CONOCIDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DEPARTAMENTO_CONOCIDO").Caption = Value
        End Set
    End Property

    Public Property HeaderMUNICIPIO_CONOCIDO() As String
        Get
            Return Me.dxgvLista.Columns("MUNICIPIO_CONOCIDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MUNICIPIO_CONOCIDO").Caption = Value
        End Set
    End Property

    Public Property HeaderTELEFONO_FIJO_CONOCIDO() As String
        Get
            Return Me.dxgvLista.Columns("TELEFONO_FIJO_CONOCIDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TELEFONO_FIJO_CONOCIDO").Caption = Value
        End Set
    End Property

    Public Property HeaderTELEFONO_MOVIL_CONOCIDO() As String
        Get
            Return Me.dxgvLista.Columns("TELEFONO_MOVIL_CONOCIDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TELEFONO_MOVIL_CONOCIDO").Caption = Value
        End Set
    End Property

    Public Property HeaderEMAIL_CONOCIDO() As String
        Get
            Return Me.dxgvLista.Columns("EMAIL_CONOCIDO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EMAIL_CONOCIDO").Caption = Value
        End Set
    End Property

    Public Property HeaderOBSERVACIONES_SUGERENCIAS() As String
        Get
            Return Me.dxgvLista.Columns("OBSERVACIONES_SUGERENCIAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OBSERVACIONES_SUGERENCIAS").Caption = Value
        End Set
    End Property

    Public Property HeaderUSERID() As String
        Get
            Return Me.dxgvLista.Columns("USERID").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USERID").Caption = Value
        End Set
    End Property

    Public Property HeaderLASTUPDATE() As String
        Get
            Return Me.dxgvLista.Columns("LASTUPDATE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("LASTUPDATE").Caption = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla FICHA_PATI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsLista.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsLista.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsLista.DataBind()
        Me.dxgvLista.DataSourceID = "odsLista"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla FICHA_PATI
    ''' filtrado por la tabla ENCA_FICH_PATI
    ''' </summary>
    ''' <param name="NUME_FICH"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorENCA_FICH_PATI(ByVal NUME_FICH As Decimal) As Integer
        Me.odsListaPorENCA_FICH_PATI.SelectParameters("NUME_FICH").DefaultValue = NUME_FICH.ToString()
        Me.odsListaPorENCA_FICH_PATI.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorENCA_FICH_PATI.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorENCA_FICH_PATI.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorENCA_FICH_PATI.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorENCA_FICH_PATI"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla FICHA_PATI
    ''' filtrado por la tabla ENTREVISTADORES_PATI
    ''' </summary>
    ''' <param name="ID_ENTREVISTADOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorENTREVISTADORES_PATI(ByVal ID_ENTREVISTADOR As Decimal) As Integer
        Me.odsListaPorENTREVISTADORES_PATI.SelectParameters("ID_ENTREVISTADOR").DefaultValue = ID_ENTREVISTADOR.ToString()
        Me.odsListaPorENTREVISTADORES_PATI.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorENTREVISTADORES_PATI.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorENTREVISTADORES_PATI.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorENTREVISTADORES_PATI.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorENTREVISTADORES_PATI"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Function CargarDatosPorMunicipioResidencia(ByVal codDepa As String, ByVal codMUNIC As String) As Integer
        Me.odsListaPorMunicipioResidencia.SelectParameters("DEPARTAMENTO_RESIDENCIA").DefaultValue = codDepa
        Me.odsListaPorMunicipioResidencia.SelectParameters("MUNICIPIO_RESIDENCIA").DefaultValue = codMUNIC
        Me.odsListaPorMunicipioResidencia.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorMunicipioResidencia.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorMunicipioResidencia.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorMunicipioResidencia.DataBind()
        Me.Session("codDepa") = codDepa
        Me.Session("codMUNIC") = codMUNIC
        Me.dxgvLista.DataSourceID = "odsListaPorMunicipioResidencia"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	17/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriterios(ByVal NumCovenio As Decimal, ByVal NumeFich As Decimal, ByVal Nombres As String, ByVal Apellidos As String, ByVal NumeroDui As String, ByVal FechaNacimiento As String) As Integer
        Me.odsListaPorCriterios.SelectParameters("NumConvenio").DefaultValue = NumCovenio
        Me.odsListaPorCriterios.SelectParameters("NumeFich").DefaultValue = NumeFich
        Me.odsListaPorCriterios.SelectParameters("Nombres").DefaultValue = Nombres.ToUpper
        Me.odsListaPorCriterios.SelectParameters("Apellidos").DefaultValue = Apellidos.ToUpper
        Me.odsListaPorCriterios.SelectParameters("NumeroDui").DefaultValue = NumeroDui
        If FechaNacimiento <> "" Then
            Me.odsListaPorCriterios.SelectParameters("FechaNacimiento").DefaultValue = System.DateTime.Parse(FechaNacimiento, New System.Globalization.CultureInfo("fr-FR", True), _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        End If
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Sub Limpiar()
        Me.dxgvLista.DataSourceID = ""
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.DataBind()
    End Sub

    Protected Sub Page_Init1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Init
        If Not Me.Session("codDepa") Is Nothing Then
            Me.CargarDatosPorMunicipioResidencia(Me.Session("codDepa"), Me.Session("codMUNIC"))
        End If
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.Page.IsPostBack And Not Me.Page.IsCallback Then
            hf.Clear()
            Me.Session("codDepa") = Nothing
            Me.Session("codMUNIC") = Nothing
        End If
        ActualizarCargarDatosCallback()

        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub

    Protected Sub dxgvLista_CustomCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomCallbackEventArgs) Handles dxgvLista.CustomCallback
        If Not e.Parameters Is Nothing Then
            Dim parametros() As String = e.Parameters.Split(";")
            CargarDatosPorMunicipioResidencia(parametros(0), parametros(1))
        End If
    End Sub


    Protected Sub dxgvLista_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewClientJSPropertiesEventArgs) Handles dxgvLista.CustomJSProperties
        If Me.PermitirSeleccionParaCombo Then
            Dim grid As DevExpress.Web.ASPxGridView.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView.ASPxGridView)
            Dim keyNames(grid.VisibleRowCount - 1) As Object
            Dim keyValues(grid.VisibleRowCount - 1) As Object
            For i As Integer = 0 To grid.VisibleRowCount - 1
                keyValues(i) = grid.GetRowValues(i, "NUME_FICH")
                keyNames(i) = grid.GetRowValues(i, "ID_ENTREVISTADOR")
            Next i
            e.Properties("cpKeyValues") = keyValues
            e.Properties("cpKeyNames") = keyNames
            e.Properties("cpNombreComboCliente") = Me.NombreComboCliente
        End If
    End Sub

    Protected Sub dxgvLista_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles dxgvLista.Init
        If Me.PermitirSeleccionar And Me.ComandoSeleccionar = "Check" Then
            Me.dxgvLista.Columns("Seleccionar").Visible = True
            CType(Me.dxgvLista.Columns("Seleccionar"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).ShowSelectCheckbox = True
        Else
            Me.dxgvLista.Columns("Seleccionar").Visible = False
        End If
        Me.dxgvLista.Columns("Edicion").Visible = True
        CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregarInline
        CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).EditButton.Visible = Me.PermitirEditarInline
        CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).DeleteButton.Visible = Me.PermitirEliminarInline
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
    End Sub

    Protected Sub dxgvLista_RowCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Select" And ComandoSeleccionar <> "Check" Then
            Me.dxgvLista.Selection.UnselectAll()
            Me.dxgvLista.Selection.SelectRow(e.VisibleIndex)
            RaiseEvent Seleccionado(e.CommandArgs.CommandArgument)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.CommandArgs.CommandArgument)
        End If
    End Sub

    Protected Sub dxgvLista_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowCreated
        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.EditForm Then
            Dim btnGuardar As DevExpress.Web.ASPxEditors.ASPxButton
            Dim btnCancelar As DevExpress.Web.ASPxEditors.ASPxButton
            btnGuardar = Me.dxgvLista.FindEditFormTemplateControl("btnGuardar")
            btnCancelar = Me.dxgvLista.FindEditFormTemplateControl("btnCancelar")
            btnGuardar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            btnCancelar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        End If
        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.EmptyDataRow Then
            Dim btnAgregar As DevExpress.Web.ASPxEditors.ASPxButton
            btnAgregar = Me.dxgvLista.FindEmptyDataRowTemplateControl("btnAgregar")
            btnAgregar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            btnAgregar.Visible = Me.PermitirAgregarInline
            Dim lblEmptyDataRow As DevExpress.Web.ASPxEditors.ASPxLabel
            lblEmptyDataRow = Me.dxgvLista.FindEmptyDataRowTemplateControl("lblEmptyDataRow")
            lblEmptyDataRow.Text = Me.dxgvLista.SettingsText.EmptyDataRow
        End If
        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Data Then
            If Not Me.PermitirEditar Then
                Dim lbDetalle As LinkButton
                lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                If lbDetalle IsNot Nothing Then lbDetalle.Visible = False
            End If
            If Me.PermitirEditar Then
                Dim lbDetalle As LinkButton
                lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                If lbDetalle IsNot Nothing Then lbDetalle.Attributes.Add("onclick", "pFichas.PerformCallback('Editar;" + lbDetalle.CommandArgument + "');return false;")
            End If
            If Me.PermitirSeleccionar Then
                Dim lbSeleccionar As LinkButton
                lbSeleccionar = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnSeleccionar")
                If lbSeleccionar IsNot Nothing Then
                    lbSeleccionar.Visible = True
                    lbSeleccionar.Text = Me.TextoSeleccionar
                    lbSeleccionar.CommandName = Me.ComandoSeleccionar
                    If lbSeleccionar.CommandName = "Check" Then
                        lbSeleccionar.Visible = False
                    End If
                End If
            End If
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaFICHA_PATI
        Dim mLista As New listaFICHA_PATI
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("NUME_FICH")
            Dim lEntidad As New FICHA_PATI
            lEntidad.NUME_FICH = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As FICHA_PATI = CType(Me.dxgvLista.GetRow(e.VisibleIndex), FICHA_PATI)

            If Me.mComponente.EliminarFICHA_PATI(lEntidad.NUME_FICH) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            e.Text = "<img src='imagenes/Eliminar.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
        End If
        If e.ButtonID = "btnAprobar" Then
            'Mostrar botón de Aprobar Inscripción solo si el participante no se encuentra inscrito en otro curso
            If e.CellType = DevExpress.Web.ASPxGridView.GridViewTableCommandCellType.Data Then
                Dim lEntidad As FICHA_PATI = CType(Me.dxgvLista.GetRow(e.VisibleIndex), FICHA_PATI)
                If lEntidad IsNot Nothing AndAlso lEntidad.ID_PARTICIPANTE <> -1 Then
                    If Me.dxgvLista.GetRowValues(e.VisibleIndex, "NUM_CONVENIO") IsNot Nothing Then
                        e.Visible = DevExpress.Utils.DefaultBoolean.True
                    Else
                        e.Visible = DevExpress.Utils.DefaultBoolean.False
                    End If
                ElseIf Me.dxgvLista.GetRowValues(e.VisibleIndex, "NUM_CONVENIO") IsNot Nothing Then
                    e.Visible = DevExpress.Utils.DefaultBoolean.True
                Else
                    e.Visible = DevExpress.Utils.DefaultBoolean.False
                End If
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "departamento" AndAlso e.GetListSourceFieldValue("DEPARTAMENTO_RESIDENCIA") IsNot Nothing Then
            Dim lDepartamento As SGAFP.EL.DEPARTAMENTO
            lDepartamento = (New SGAFP.BL.cDEPARTAMENTO).ObtenerDEPARTAMENTO(e.GetListSourceFieldValue("DEPARTAMENTO_RESIDENCIA").ToString())
            e.Value = lDepartamento.NOMBRE
        End If

        If e.Column.FieldName = "municipio" AndAlso e.GetListSourceFieldValue("DEPARTAMENTO_RESIDENCIA") IsNot Nothing Then
            Dim lMunicipio As SGAFP.EL.MUNICIPIO
            lMunicipio = (New SGAFP.BL.cMUNICIPIO).ObtenerMUNICIPIO(e.GetListSourceFieldValue("DEPARTAMENTO_RESIDENCIA").ToString(), e.GetListSourceFieldValue("MUNICIPIO_RESIDENCIA").ToString())
            e.Value = lMunicipio.NOMBRE
        End If

        If e.Column.FieldName = "NUM_CONVENIO" AndAlso e.GetListSourceFieldValue("NUME_FICH").ToString() IsNot Nothing Then
            Dim lListaDetaFami As PATI.EL.listaDETA_FAMI
            Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(Me.ID_ACCION_FORMATIVA)

            If lAccionDetalle IsNot Nothing Then
                Dim lCriterios As New List(Of Criteria)
                lCriterios.Add(New Criteria("ID_FUENTE", "=", lAccionDetalle.ID_FUENTE.ToString, "AND"))
                lCriterios.Add(New Criteria("NO_CONVOCATORIA", "=", lAccionDetalle.NO_CONVOCATORIA.ToString, "AND"))
                lCriterios.Add(New Criteria("NUME_FICH_PATI", "=", e.GetListSourceFieldValue("NUME_FICH").ToString, "AND"))
                lCriterios.Add(New Criteria("ESTA", "=", "A", ""))
                lListaDetaFami = (New cDETA_FAMI).ObtenerListaPorBusqueda(New DETA_FAMI, lCriterios.ToArray)

                If lListaDetaFami IsNot Nothing AndAlso lListaDetaFami.Count > 0 Then
                    e.Value = lListaDetaFami(0).NUME_FAMI
                End If
            End If
        End If

        If e.Column.FieldName = "NOMBRE_PROYECTO" AndAlso e.GetListSourceFieldValue("CODIGO_PROYECTO") IsNot Nothing AndAlso e.GetListSourceFieldValue("CODIGO_PROYECTO") <> "" Then
            Dim lProyecto As PATI.EL.PROY_FISDL
            lProyecto = (New PATI.BL.cPROY_FISDL).ObtenerPROY_FISDL(e.GetListSourceFieldValue("CODIGO_PROYECTO").ToString())
            e.Value = lProyecto.NOMB_PROY
        End If

        If e.Column.FieldName = "descripcion_sexo" AndAlso e.GetListSourceFieldValue("SEXO") IsNot Nothing Then
            Dim lsexo As Int32
            lsexo = e.GetListSourceFieldValue("SEXO")
            If lsexo = 1 Then
                e.Value = "MASCULINO"
            Else
                e.Value = "FEMENINO"
            End If
        End If

        If e.Column.FieldName = "APELLIDOS" Then
            e.Value = Trim(e.GetListSourceFieldValue("PRIMER_APELLIDO").ToString + " " + e.GetListSourceFieldValue("SEGUNDO_APELLIDO").ToString)
            If e.GetListSourceFieldValue("TERCER_APELLIDO").ToString <> "" Then
                e.Value += " DE " + e.GetListSourceFieldValue("TERCER_APELLIDO").ToString
            End If
        End If
        If e.Column.FieldName = "NOMBRES" Then
            e.Value = Trim(e.GetListSourceFieldValue("PRIMER_NOMBRE").ToString + " " + e.GetListSourceFieldValue("SEGUNDO_NOMBRE").ToString + " " + e.GetListSourceFieldValue("TERCER_NOMBRE").ToString)
        End If
    End Sub
    
    Public Sub CargarDatosPorCallback(ByVal opcion As String, ByVal parametros() As String)
        If opcion = "BuscarDatos" Then
            If hf.Contains("BuscarDatos") Then hf("BuscarDatos") = parametros(0) Else hf.Add("BuscarDatos", parametros(0))
            For i As Integer = 1 To parametros.Length - 1
                If hf.Contains("param" + (i).ToString) Then hf.Remove("param" + (i).ToString)
            Next
            For i As Integer = 1 To parametros.Length - 1
                hf.Add("param" + (i).ToString, parametros(i))
            Next
            Me.ActualizarCargarDatosCallback()
        End If
    End Sub

    Public Sub ActualizarCargarDatosCallback()
        If hf.Contains("BuscarDatos") Then
            If hf("BuscarDatos") = "BuscarFichasPATI" Then Me.CargarDatosPorCriterios(hf("param1"), hf("param2"), hf("param3"), hf("param4"), hf("param5"), hf("param6"))
        End If
    End Sub

    Public Sub DataBindGridView()
        Me.dxgvLista.DataBind()
    End Sub
End Class
