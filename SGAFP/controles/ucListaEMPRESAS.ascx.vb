Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaEMPRESAS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla EMPRESAS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaEMPRESAS
    Inherits ucBase
 
    Private mComponente As New cEMPRESAS
    Public Event Seleccionado(ByVal NUMERO_PATRONAL As String) 
    Public Event Editando(ByVal NUMERO_PATRONAL As String) 

#Region"Propiedades"

    Public Property MostrarFooter() As Boolean
        Get
            Return Me.gvLista.ShowFooter
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.ShowFooter = Value
        End Set
    End Property

    Public Property PermitirPaginacion() As Boolean
        Get
            Return Me.gvLista.AllowPaging
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.AllowPaging = Value
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
            Me.gvLista.Columns(0).Visible = Value
            If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me.ViewState.Remove("PermitirSeleccionar")
            Me.ViewState.Add("PermitirSeleccionar", Value)
        End Set
    End Property

    Private _PermitirEliminar As Boolean = True
    Public Property PermitirEliminar() As Boolean
        Get
            Return _PermitirEliminar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirEliminar = Value
            Me.gvLista.Columns(Me.gvLista.Columns.Count - 1).Visible = Value
            If Not Me.ViewState("PermitirEliminar") Is Nothing Then Me.ViewState.Remove("PermitirEliminar")
            Me.ViewState.Add("PermitirEliminar", Value)
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
            Return Me.gvLista.Columns(0).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(0).HeaderText = Value
        End Set
    End Property

    Public Property VerNUMERO_PATRONAL() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerNIT_EMPRESA() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerCIUU() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerSECTOR_PRODUCTIVO() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_ASESOR() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_MUNICIPIO() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_DEPARTAMENTO() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_REGION() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_EMPRESA() As Boolean
        Get
            Return Me.gvLista.Columns(9).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(9).Visible = Value
        End Set
    End Property

    Public Property VerTIPO_EMPRESA() As Boolean
        Get
            Return Me.gvLista.Columns(10).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(10).Visible = Value
        End Set
    End Property

    Public Property VerCONTACTO_EMPRESA() As Boolean
        Get
            Return Me.gvLista.Columns(11).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(11).Visible = Value
        End Set
    End Property

    Public Property VerTELEFONO_CONTACTO() As Boolean
        Get
            Return Me.gvLista.Columns(12).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(12).Visible = Value
        End Set
    End Property

    Public Property VerCARGO_CONTACTO() As Boolean
        Get
            Return Me.gvLista.Columns(13).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(13).Visible = Value
        End Set
    End Property

    Public Property VerDIRECCION_EMPRESA() As Boolean
        Get
            Return Me.gvLista.Columns(14).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(14).Visible = Value
        End Set
    End Property

    Public Property VerTELEFONO_EMPRESA() As Boolean
        Get
            Return Me.gvLista.Columns(15).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(15).Visible = Value
        End Set
    End Property

    Public Property VerFAX_EMPRESA() As Boolean
        Get
            Return Me.gvLista.Columns(16).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(16).Visible = Value
        End Set
    End Property

    Public Property VerEMAIL_EMPRESA() As Boolean
        Get
            Return Me.gvLista.Columns(17).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(17).Visible = Value
        End Set
    End Property

    Public Property VerESPECIALIDAD_EMPRESA() As Boolean
        Get
            Return Me.gvLista.Columns(18).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(18).Visible = Value
        End Set
    End Property

    Public Property VerTOTAL_PERSONA() As Boolean
        Get
            Return Me.gvLista.Columns(19).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(19).Visible = Value
        End Set
    End Property

    Public Property VerTOTAL_PLANILLA() As Boolean
        Get
            Return Me.gvLista.Columns(20).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(20).Visible = Value
        End Set
    End Property

    Public Property VerREPRESENTANTE_LEGAL() As Boolean
        Get
            Return Me.gvLista.Columns(21).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(21).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_REGISTRO() As Boolean
        Get
            Return Me.gvLista.Columns(22).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(22).Visible = Value
        End Set
    End Property

    Public Property VerTOTAL_TRABAJADORES() As Boolean
        Get
            Return Me.gvLista.Columns(23).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(23).Visible = Value
        End Set
    End Property

    Public Property VerFEMENINOS() As Boolean
        Get
            Return Me.gvLista.Columns(24).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(24).Visible = Value
        End Set
    End Property

    Public Property VerMASCULINOS() As Boolean
        Get
            Return Me.gvLista.Columns(25).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(25).Visible = Value
        End Set
    End Property

    Public Property VerTAMANO_EMPRESA() As Boolean
        Get
            Return Me.gvLista.Columns(26).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(26).Visible = Value
        End Set
    End Property

    Public Property VerCON_MANDO() As Boolean
        Get
            Return Me.gvLista.Columns(27).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(27).Visible = Value
        End Set
    End Property

    Public Property VerSIN_MANDO() As Boolean
        Get
            Return Me.gvLista.Columns(28).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(28).Visible = Value
        End Set
    End Property

    Public Property VerADMINISTRATIVOS() As Boolean
        Get
            Return Me.gvLista.Columns(29).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(29).Visible = Value
        End Set
    End Property

    Public Property VerMANDOS_MEDIOS() As Boolean
        Get
            Return Me.gvLista.Columns(30).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(30).Visible = Value
        End Set
    End Property

    Public Property VerOPERATIVOS() As Boolean
        Get
            Return Me.gvLista.Columns(31).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(31).Visible = Value
        End Set
    End Property

    Public Property VerGERENCIAL() As Boolean
        Get
            Return Me.gvLista.Columns(32).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(32).Visible = Value
        End Set
    End Property

    Public Property VerSIGLAS() As Boolean
        Get
            Return Me.gvLista.Columns(33).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(33).Visible = Value
        End Set
    End Property

    Public Property VerUSERID() As Boolean
        Get
            Return Me.gvLista.Columns(34).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(34).Visible = Value
        End Set
    End Property

    Public Property VerLASTUPDATE() As Boolean
        Get
            Return Me.gvLista.Columns(35).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(35).Visible = Value
        End Set
    End Property

    Public Property VerOBSERVACION() As Boolean
        Get
            Return Me.gvLista.Columns(36).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(36).Visible = Value
        End Set
    End Property

    Public Property VerNUM_PAT_ISSS() As Boolean
        Get
            Return Me.gvLista.Columns(37).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(37).Visible = Value
        End Set
    End Property

    Public Property VerTIPOPERSON() As Boolean
        Get
            Return Me.gvLista.Columns(38).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(38).Visible = Value
        End Set
    End Property

    Public Property VerNUM() As Boolean
        Get
            Return Me.gvLista.Columns(39).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(39).Visible = Value
        End Set
    End Property

    Public Property VerREPRESENTANTE_PROFESION() As Boolean
        Get
            Return Me.gvLista.Columns(40).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(40).Visible = Value
        End Set
    End Property

    Public Property VerCONTACTO_EMAIL() As Boolean
        Get
            Return Me.gvLista.Columns(41).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(41).Visible = Value
        End Set
    End Property

    Public Property VerAPORTE_INSAFORP() As Boolean
        Get
            Return Me.gvLista.Columns(42).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(42).Visible = Value
        End Set
    End Property

    Public Property VerZONA() As Boolean
        Get
            Return Me.gvLista.Columns(43).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(43).Visible = Value
        End Set
    End Property

    Public Property HeaderNUMERO_PATRONAL() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNIT_EMPRESA() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCIUU() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderSECTOR_PRODUCTIVO() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODIGO_ASESOR() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODIGO_MUNICIPIO() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODIGO_DEPARTAMENTO() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODIGO_REGION() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOMBRE_EMPRESA() As String
        Get
            Return Me.gvLista.Columns(9).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(9).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTIPO_EMPRESA() As String
        Get
            Return Me.gvLista.Columns(10).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(10).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCONTACTO_EMPRESA() As String
        Get
            Return Me.gvLista.Columns(11).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(11).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTELEFONO_CONTACTO() As String
        Get
            Return Me.gvLista.Columns(12).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(12).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCARGO_CONTACTO() As String
        Get
            Return Me.gvLista.Columns(13).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(13).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDIRECCION_EMPRESA() As String
        Get
            Return Me.gvLista.Columns(14).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(14).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTELEFONO_EMPRESA() As String
        Get
            Return Me.gvLista.Columns(15).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(15).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFAX_EMPRESA() As String
        Get
            Return Me.gvLista.Columns(16).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(16).HeaderText = Value
        End Set
    End Property

    Public Property HeaderEMAIL_EMPRESA() As String
        Get
            Return Me.gvLista.Columns(17).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(17).HeaderText = Value
        End Set
    End Property

    Public Property HeaderESPECIALIDAD_EMPRESA() As String
        Get
            Return Me.gvLista.Columns(18).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(18).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTOTAL_PERSONA() As String
        Get
            Return Me.gvLista.Columns(19).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(19).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTOTAL_PLANILLA() As String
        Get
            Return Me.gvLista.Columns(20).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(20).HeaderText = Value
        End Set
    End Property

    Public Property HeaderREPRESENTANTE_LEGAL() As String
        Get
            Return Me.gvLista.Columns(21).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(21).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_REGISTRO() As String
        Get
            Return Me.gvLista.Columns(22).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(22).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTOTAL_TRABAJADORES() As String
        Get
            Return Me.gvLista.Columns(23).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(23).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFEMENINOS() As String
        Get
            Return Me.gvLista.Columns(24).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(24).HeaderText = Value
        End Set
    End Property

    Public Property HeaderMASCULINOS() As String
        Get
            Return Me.gvLista.Columns(25).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(25).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTAMANO_EMPRESA() As String
        Get
            Return Me.gvLista.Columns(26).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(26).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCON_MANDO() As String
        Get
            Return Me.gvLista.Columns(27).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(27).HeaderText = Value
        End Set
    End Property

    Public Property HeaderSIN_MANDO() As String
        Get
            Return Me.gvLista.Columns(28).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(28).HeaderText = Value
        End Set
    End Property

    Public Property HeaderADMINISTRATIVOS() As String
        Get
            Return Me.gvLista.Columns(29).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(29).HeaderText = Value
        End Set
    End Property

    Public Property HeaderMANDOS_MEDIOS() As String
        Get
            Return Me.gvLista.Columns(30).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(30).HeaderText = Value
        End Set
    End Property

    Public Property HeaderOPERATIVOS() As String
        Get
            Return Me.gvLista.Columns(31).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(31).HeaderText = Value
        End Set
    End Property

    Public Property HeaderGERENCIAL() As String
        Get
            Return Me.gvLista.Columns(32).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(32).HeaderText = Value
        End Set
    End Property

    Public Property HeaderSIGLAS() As String
        Get
            Return Me.gvLista.Columns(33).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(33).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSERID() As String
        Get
            Return Me.gvLista.Columns(34).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(34).HeaderText = Value
        End Set
    End Property

    Public Property HeaderLASTUPDATE() As String
        Get
            Return Me.gvLista.Columns(35).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(35).HeaderText = Value
        End Set
    End Property

    Public Property HeaderOBSERVACION() As String
        Get
            Return Me.gvLista.Columns(36).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(36).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNUM_PAT_ISSS() As String
        Get
            Return Me.gvLista.Columns(37).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(37).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTIPOPERSON() As String
        Get
            Return Me.gvLista.Columns(38).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(38).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNUM() As String
        Get
            Return Me.gvLista.Columns(39).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(39).HeaderText = Value
        End Set
    End Property

    Public Property HeaderREPRESENTANTE_PROFESION() As String
        Get
            Return Me.gvLista.Columns(40).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(40).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCONTACTO_EMAIL() As String
        Get
            Return Me.gvLista.Columns(41).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(41).HeaderText = Value
        End Set
    End Property

    Public Property HeaderAPORTE_INSAFORP() As String
        Get
            Return Me.gvLista.Columns(42).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(42).HeaderText = Value
        End Set
    End Property

    Public Property HeaderZONA() As String
        Get
            Return Me.gvLista.Columns(43).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(43).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla EMPRESAS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lEMPRESAS As listaEMPRESAS
        lEMPRESAS = Me.mComponente.ObtenerLista()
        If lEMPRESAS is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lEMPRESAS
        Me.gvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("PermitirEliminar") Is Nothing Then Me._PermitirEliminar = Me.ViewState("PermitirEliminar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub


    Protected Sub gvLista_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLista.RowCommand
        If e.CommandName = "Editar" Then
            RaiseEvent Editando(e.CommandArgument)
        End If
    End Sub

    Protected Sub gvLista_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvLista.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            If Me.PermitirEliminar Then 
                Dim a As LinkButton = CType(e.Row.FindControl("LinkButton1"), LinkButton)
                a.Attributes.Add("onclick", "if(!window.confirm('¿Esta seguro de Eliminar el Registro?')){return false;}")
            End If
            Dim lbDetalle As LinkButton 
            lbDetalle = e.Row.FindControl("LinkButtonDetalle") 
            Dim mLabelNUMERO_PATRONAL As Label
            mLabelNUMERO_PATRONAL = e.Row.FindControl("Label_NUMERO_PATRONAL")
            mLabelNUMERO_PATRONAL.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
            If Me.PermitirSeleccionar Then
                Dim a As LinkButton = CType(e.Row.FindControl("LinkButton_Seleccionar"), LinkButton)
                a.Text = Me.TextoSeleccionar
                a.CommandName = Me.ComandoSeleccionar
                If a.CommandName = "Check" Then
                    CType(e.Row.FindControl("CheckBox_Seleccionar"), CheckBox).Visible = True
                    a.Visible = False
                End If
            End If

        End If
    End Sub
 
    Private Sub gvLista_RowDeleting(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles gvLista.RowDeleting
        If Me.mComponente.EliminarEMPRESAS(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip) <> 1 Then
            'Si se cometio un error
            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            e.Cancel = True
        Else
            If Me.CargarDatos() <> 1 Then
                Me.AsignarMensaje("Error al Recuperar Lista", True, True)
            End If
        End If
    End Sub
 
    Private Sub gvLista_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles gvLista.SelectedIndexChanging
        RaiseEvent Seleccionado(CType(Me.gvLista.Rows(e.NewSelectedIndex).FindControl("LinkButton1"), LinkButton).ToolTip)
    End Sub

    Protected Sub gvLista_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvLista.PageIndexChanging
        Me.gvLista.PageIndex = e.NewPageIndex
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As listaEMPRESAS
        Dim mLista As New listaEMPRESAS
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New EMPRESAS
                mEntidad.NUMERO_PATRONAL = CInt(CType(mRow.FindControl("Label_NUMERO_PATRONAL"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
