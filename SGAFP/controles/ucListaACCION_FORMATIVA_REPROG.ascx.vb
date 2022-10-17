Imports SGAFP.BL
Imports SGAFP.EL
Imports System.Collections.Generic
Imports DevExpress.Web
Imports DevExpress.Web.ASPxEditors
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaACCION_FORMATIVA_REPROG
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla ACCION_FORMATIVA_REPROG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/06/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaACCION_FORMATIVA_REPROG
    Inherits ucListaBase
 
    Private mComponente As New cACCION_FORMATIVA_REPROG
    Public Event Seleccionado(ByVal ID_ACCION_FORMATIVA_REPROG As Decimal) 
    Public Event Evaluando(ByVal ID_ACCION_FORMATIVA_REPROG As Decimal)

#Region"Propiedades"

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

    Private _PermitirEvaluar As Boolean = True
    Public Property PermitirEvaluar() As Boolean
        Get
            Return _PermitirEvaluar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirEvaluar = Value
            If Not Me.ViewState("PermitirEvaluar") Is Nothing Then Me.ViewState.Remove("PermitirEvaluar")
            Me.ViewState.Add("PermitirEvaluar", Value)
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

    Public Property VerID_ACCION_FORMATIVA_REPROG() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ACCION_FORMATIVA_REPROG").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ACCION_FORMATIVA_REPROG").Visible = Value
        End Set
    End Property

    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ACCION_FORMATIVA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ACCION_FORMATIVA").Visible = Value
        End Set
    End Property

    Public Property VerID_OFERTA_FORMATIVA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_OFERTA_FORMATIVA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_OFERTA_FORMATIVA").Visible = Value
        End Set
    End Property

    Public Property VerID_SITIO_CAPACITACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_SITIO_CAPACITACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_SITIO_CAPACITACION").Visible = Value
        End Set
    End Property

    Public Property VerID_PROVEEDOR_AF() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PROVEEDOR_AF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PROVEEDOR_AF").Visible = Value
        End Set
    End Property

    Public Property VerID_TEMA_CURSO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TEMA_CURSO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TEMA_CURSO").Visible = Value
        End Set
    End Property

    Public Property VerID_EJERCICIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_EJERCICIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_EJERCICIO").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_ACCION_FORMATIVA() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_ACCION_FORMATIVA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_ACCION_FORMATIVA").Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_GRUPO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIGO_GRUPO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIGO_GRUPO").Visible = Value
        End Set
    End Property

    Public Property VerNUMERO_PARTICIPANTES() As Boolean
        Get
            Return Me.dxgvLista.Columns("NUMERO_PARTICIPANTES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NUMERO_PARTICIPANTES").Visible = Value
        End Set
    End Property

    Public Property VerPARTICIPANTES_INSCRITOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("PARTICIPANTES_INSCRITOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PARTICIPANTES_INSCRITOS").Visible = Value
        End Set
    End Property

    Public Property VerHORARIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("HORARIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("HORARIO").Visible = Value
        End Set
    End Property

    Public Property VerNOTAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOTAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOTAS").Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_ESTADO_AF() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIGO_ESTADO_AF").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIGO_ESTADO_AF").Visible = Value
        End Set
    End Property

    Public Property VerID_ESTADO_REPROG() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ESTADO_REPROG").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ESTADO_REPROG").Visible = Value
        End Set
    End Property

    Public Property VerDURACION_HORAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("DURACION_HORAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DURACION_HORAS").Visible = Value
        End Set
    End Property

    Public Property VerCOSTO_X_PARTICIPANTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("COSTO_X_PARTICIPANTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("COSTO_X_PARTICIPANTE").Visible = Value
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

    Public Property VerUSERID() As Boolean
        Get
            Return Me.dxgvLista.Columns("USERID").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USERID").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_INICIO_REAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_INICIO_REAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_INICIO_REAL").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_FIN_REAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_FIN_REAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_FIN_REAL").Visible = Value
        End Set
    End Property

    Public Property VerMOTIVOREPROG() As String
        Get
            Return Me.dxgvLista.Columns("MOTIVOREPROG").Visible
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MOTIVOREPROG").Visible = Value
        End Set
    End Property

    Public Property VerMOTIVORECHAZO() As String
        Get
            Return Me.dxgvLista.Columns("MOTIVORECHAZO").Visible
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MOTIVORECHAZO").Visible = Value
        End Set
    End Property

    Public Property HeaderID_ACCION_FORMATIVA_REPROG() As String
        Get
            Return Me.dxgvLista.Columns("ID_ACCION_FORMATIVA_REPROG").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ACCION_FORMATIVA_REPROG").Caption = Value
        End Set
    End Property

    Public Property HeaderID_ESTADO_REPROG() As String
        Get
            Return Me.dxgvLista.Columns("ID_ESTADO_REPROG").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ESTADO_REPROG").Caption = Value
        End Set
    End Property

    Public Property HeaderID_ACCION_FORMATIVA() As String
        Get
            Return Me.dxgvLista.Columns("ID_ACCION_FORMATIVA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ACCION_FORMATIVA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_OFERTA_FORMATIVA() As String
        Get
            Return Me.dxgvLista.Columns("ID_OFERTA_FORMATIVA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_OFERTA_FORMATIVA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_SITIO_CAPACITACION() As String
        Get
            Return Me.dxgvLista.Columns("ID_SITIO_CAPACITACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_SITIO_CAPACITACION").Caption = Value
        End Set
    End Property

    Public Property HeaderID_PROVEEDOR_AF() As String
        Get
            Return Me.dxgvLista.Columns("ID_PROVEEDOR_AF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PROVEEDOR_AF").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TEMA_CURSO() As String
        Get
            Return Me.dxgvLista.Columns("ID_TEMA_CURSO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TEMA_CURSO").Caption = Value
        End Set
    End Property

    Public Property HeaderID_EJERCICIO() As String
        Get
            Return Me.dxgvLista.Columns("ID_EJERCICIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_EJERCICIO").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRE_ACCION_FORMATIVA() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRE_ACCION_FORMATIVA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRE_ACCION_FORMATIVA").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIGO_GRUPO() As String
        Get
            Return Me.dxgvLista.Columns("CODIGO_GRUPO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIGO_GRUPO").Caption = Value
        End Set
    End Property

    Public Property HeaderNUMERO_PARTICIPANTES() As String
        Get
            Return Me.dxgvLista.Columns("NUMERO_PARTICIPANTES").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NUMERO_PARTICIPANTES").Caption = Value
        End Set
    End Property

    Public Property HeaderPARTICIPANTES_INSCRITOS() As String
        Get
            Return Me.dxgvLista.Columns("PARTICIPANTES_INSCRITOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PARTICIPANTES_INSCRITOS").Caption = Value
        End Set
    End Property

    Public Property HeaderHORARIO() As String
        Get
            Return Me.dxgvLista.Columns("HORARIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("HORARIO").Caption = Value
        End Set
    End Property

    Public Property HeaderNOTAS() As String
        Get
            Return Me.dxgvLista.Columns("NOTAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOTAS").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIGO_ESTADO_AF() As String
        Get
            Return Me.dxgvLista.Columns("CODIGO_ESTADO_AF").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIGO_ESTADO_AF").Caption = Value
        End Set
    End Property

    Public Property HeaderDURACION_HORAS() As String
        Get
            Return Me.dxgvLista.Columns("DURACION_HORAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DURACION_HORAS").Caption = Value
        End Set
    End Property

    Public Property HeaderCOSTO_X_PARTICIPANTE() As String
        Get
            Return Me.dxgvLista.Columns("COSTO_X_PARTICIPANTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("COSTO_X_PARTICIPANTE").Caption = Value
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

    Public Property HeaderUSERID() As String
        Get
            Return Me.dxgvLista.Columns("USERID").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USERID").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_INICIO_REAL() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_INICIO_REAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_INICIO_REAL").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_FIN_REAL() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_FIN_REAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_FIN_REAL").Caption = Value
        End Set
    End Property

    Public Property HeaderMOTIVOREPROG() As String
        Get
            Return Me.dxgvLista.Columns("MOTIVOREPROG").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MOTIVOREPROG").Caption = Value
        End Set
    End Property

    Public Property HeaderMOTIVORECHAZO() As String
        Get
            Return Me.dxgvLista.Columns("MOTIVORECHAZO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MOTIVORECHAZO").Caption = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_REPROG
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("recuperarHijas").DefaultValue = "False"
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
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_REPROG
    ''' filtrado por la ACCION_FORMATIVA y ESTADO_REPROG
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <param name="ID_ESTADO_REPROG"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorACCION_FORMATIVA_REPROG_ESTADO(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_ESTADO_REPROG As Integer) As Integer
        Me.odsListaPorAccionFormativaReprogEstado.SelectParameters("ID_ACCION_FORMATIVA").DefaultValue = ID_ACCION_FORMATIVA.ToString()
        Me.odsListaPorAccionFormativaReprogEstado.SelectParameters("ID_ESTADO_REPROG").DefaultValue = ID_ESTADO_REPROG.ToString()
        Me.odsListaPorAccionFormativaReprogEstado.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorAccionFormativaReprogEstado"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_REPROG
    ''' filtrado por la tabla ESTADO_REPROG
    ''' </summary>
    ''' <param name="ID_ESTADO_REPROG"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorESTADO_REPROG(ByVal ID_ESTADO_REPROG As Decimal) As Integer
        Me.odsListaPorESTADO_ACCION_FORMATIVA.SelectParameters("ID_ESTADO_REPROG").DefaultValue = ID_ESTADO_REPROG.ToString()
        Me.odsListaPorESTADO_ACCION_FORMATIVA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorESTADO_REPROG"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_REPROG
    ''' filtrado por la tabla OFERTA_FORMATIVA
    ''' </summary>
    ''' <param name="ID_OFERTA_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorOFERTA_FORMATIVA(ByVal ID_OFERTA_FORMATIVA As Decimal) As Integer
        Me.odsListaPorOFERTA_FORMATIVA.SelectParameters("ID_OFERTA_FORMATIVA").DefaultValue = ID_OFERTA_FORMATIVA.ToString()
        Me.odsListaPorOFERTA_FORMATIVA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorOFERTA_FORMATIVA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_REPROG
    ''' filtrado por la tabla SITIO_CAPACITACION
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal) As Integer
        Me.odsListaPorSITIO_CAPACITACION.SelectParameters("ID_SITIO_CAPACITACION").DefaultValue = ID_SITIO_CAPACITACION.ToString()
        Me.odsListaPorSITIO_CAPACITACION.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorSITIO_CAPACITACION"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_REPROG
    ''' filtrado por la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal) As Integer
        Me.odsListaPorPROVEEDOR_AF.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString()
        Me.odsListaPorPROVEEDOR_AF.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPROVEEDOR_AF"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_REPROG
    ''' filtrado por la tabla ESTADO_ACCION_FORMATIVA
    ''' </summary>
    ''' <param name="CODIGO_ESTADO_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorESTADO_ACCION_FORMATIVA(ByVal CODIGO_ESTADO_AF As String) As Integer
        Me.odsListaPorESTADO_ACCION_FORMATIVA.SelectParameters("CODIGO_ESTADO_AF").DefaultValue = CODIGO_ESTADO_AF.ToString()
        Me.odsListaPorESTADO_ACCION_FORMATIVA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorESTADO_ACCION_FORMATIVA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("PermitirEvaluar") Is Nothing Then Me._PermitirEvaluar = Me.ViewState("PermitirEvaluar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub


    Protected Sub dxgvLista_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles dxgvLista.Init
        If Me.PermitirSeleccionar And Me.ComandoSeleccionar = "Check" Then
            Me.dxgvLista.Columns("Seleccionar").Visible = True
            CType(Me.dxgvLista.Columns("Seleccionar"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).ShowSelectCheckbox = True
        End If
    End Sub

    Protected Sub dxgvLista_RowCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Select" And ComandoSeleccionar <> "Check" Then
            Me.dxgvLista.Selection.UnselectAll()
            Me.dxgvLista.Selection.SelectRow(e.VisibleIndex)
            RaiseEvent Seleccionado(e.CommandArgs.CommandArgument)
        End If
        If e.CommandArgs.CommandName = "Evaluar" Then
            RaiseEvent Evaluando(e.CommandArgs.CommandArgument)
        End If
    End Sub

    Protected Sub dxgvLista_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowCreated
        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Data Then
            If Not Me.PermitirEvaluar Then
                Dim lbDetalle As LinkButton
                lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEvaluar")
                lbDetalle.Visible = False
            End If
            If Me.PermitirSeleccionar Then
                Dim lbSeleccionar As LinkButton
                lbSeleccionar = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnSeleccionar")
                lbSeleccionar.Visible = True
                lbSeleccionar.Text = Me.TextoSeleccionar
                lbSeleccionar.CommandName = Me.ComandoSeleccionar
                If lbSeleccionar.CommandName = "Check" Then
                    lbSeleccionar.Visible = False
                End If
            End If
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaACCION_FORMATIVA_REPROG
        Dim mLista As New listaACCION_FORMATIVA_REPROG
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_ACCION_FORMATIVA_REPROG")
            Dim lEntidad As New ACCION_FORMATIVA_REPROG
            lEntidad.ID_ACCION_FORMATIVA_REPROG = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As ACCION_FORMATIVA_REPROG = CType(Me.dxgvLista.GetRow(e.VisibleIndex), ACCION_FORMATIVA_REPROG)

            If Me.mComponente.EliminarACCION_FORMATIVA_REPROG(lEntidad.ID_ACCION_FORMATIVA_REPROG) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                If Me.CargarDatos() <> 1 Then
                    Me.AsignarMensaje("Error al Recuperar Lista", True, True)
                End If
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            e.Text = "<img src='imagenes/Eliminar.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_REPROG
    ''' filtrado por los criterios recibidos
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_AREA_FORMACION"></param>
    ''' <param name="NOMBRE_ACCION_FORMATIVA"></param>
    ''' <param name="ID_ESTADO_REPROG"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriteriosPeriodoEstado(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                ByVal ID_AREA_FORMACION As Decimal, _
                                                ByVal NOMBRE_ACCION_FORMATIVA As String, _
                                                ByVal CODIGO_GRUPO As String, _
                                                ByVal ID_ESTADO_REPROG As Decimal, _
                                                ByVal ID_EJERCICIO As String, _
                                                ByVal TDR As String) As Integer

        Me.odsPorCriteriosPeriodoEstado.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString()
        Me.odsPorCriteriosPeriodoEstado.SelectParameters("ID_SITIO_CAPACITACION").DefaultValue = ID_SITIO_CAPACITACION.ToString()
        Me.odsPorCriteriosPeriodoEstado.SelectParameters("ID_AREA_FORMACION").DefaultValue = ID_AREA_FORMACION.ToString()
        Me.odsPorCriteriosPeriodoEstado.SelectParameters("NOMBRE_ACCION_FORMATIVA").DefaultValue = NOMBRE_ACCION_FORMATIVA.ToString()
        Me.odsPorCriteriosPeriodoEstado.SelectParameters("CODIGO_GRUPO").DefaultValue = CODIGO_GRUPO.ToString()
        Me.odsPorCriteriosPeriodoEstado.SelectParameters("ID_ESTADO_REPROG").DefaultValue = ID_ESTADO_REPROG.ToString()
        Me.odsPorCriteriosPeriodoEstado.SelectParameters("ID_EJERCICIO").DefaultValue = ID_EJERCICIO.ToString()
        Me.odsPorCriteriosPeriodoEstado.SelectParameters("TDR").DefaultValue = TDR.ToString()
        Me.odsPorCriteriosPeriodoEstado.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsPorCriteriosPeriodoEstado.SelectParameters("asTipoOrden").DefaultValue = "ASC"
        Me.odsPorCriteriosPeriodoEstado.DataBind()
        Me.dxgvLista.DataSourceID = "odsPorCriteriosPeriodoEstado"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_REPROG
    ''' filtrado por los criterios recibidos
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_AREA_FORMACION"></param>
    ''' <param name="NOMBRE_ACCION_FORMATIVA"></param>
    ''' <param name="CODIGO_GRUPO"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <param name="listaROLES"></param>
    ''' <param name="ID_ESTADO_REPROG"></param>
    ''' <param name="TDR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	09/01/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriteriosRoles(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                    ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                    ByVal ID_AREA_FORMACION As Decimal, _
                                                    ByVal NOMBRE_ACCION_FORMATIVA As String, _
                                                    ByVal CODIGO_GRUPO As String, _
                                                    ByVal ID_EJERCICIO As String, _
                                                    ByVal listaROLES As String, _
                                                    ByVal ID_ESTADO_REPROG As Decimal, _
                                                    ByVal TDR As String) As Integer

        Me.odsPorCriteriosRoles.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString()
        Me.odsPorCriteriosRoles.SelectParameters("ID_SITIO_CAPACITACION").DefaultValue = ID_SITIO_CAPACITACION.ToString()
        Me.odsPorCriteriosRoles.SelectParameters("ID_AREA_FORMACION").DefaultValue = ID_AREA_FORMACION.ToString()
        Me.odsPorCriteriosRoles.SelectParameters("NOMBRE_ACCION_FORMATIVA").DefaultValue = NOMBRE_ACCION_FORMATIVA.ToString()
        Me.odsPorCriteriosRoles.SelectParameters("CODIGO_GRUPO").DefaultValue = CODIGO_GRUPO.ToString()
        Me.odsPorCriteriosRoles.SelectParameters("ID_EJERCICIO").DefaultValue = ID_EJERCICIO.ToString()
        Me.odsPorCriteriosRoles.SelectParameters("listaROLES").DefaultValue = listaROLES
        Me.odsPorCriteriosRoles.SelectParameters("ID_ESTADO_REPROG").DefaultValue = ID_ESTADO_REPROG.ToString()
        Me.odsPorCriteriosRoles.SelectParameters("TDR").DefaultValue = TDR.ToString()
        Me.odsPorCriteriosRoles.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsPorCriteriosRoles.SelectParameters("asTipoOrden").DefaultValue = "ASC"
        Me.odsPorCriteriosRoles.DataBind()
        Me.dxgvLista.DataSourceID = "odsPorCriteriosRoles"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function
End Class
