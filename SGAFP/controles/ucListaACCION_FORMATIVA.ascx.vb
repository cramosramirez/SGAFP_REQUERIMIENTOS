Imports SGAFP.BL
Imports SGAFP.EL
Imports System.Collections.Generic
Imports DevExpress.Web
Imports DevExpress.Web.ASPxEditors

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaACCION_FORMATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla ACCION_FORMATIVA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaACCION_FORMATIVA
    Inherits ucListaBase

    Private mComponente As New cACCION_FORMATIVA
    Public Event Seleccionado(ByVal ID_ACCION_FORMATIVA As Decimal)
    Public Event Editando(ByVal ID_ACCION_FORMATIVA As Decimal)
    Public Event Reprogramando(ByVal ID_ACCION_FORMATIVA As Decimal)
    Public Event InformeParcial(ByVal ID_ACCION_FORMATIVA As Decimal)
    Public Event Penalizar(ByVal ID_ACCION_FORMATIVA As Decimal)
    Public Event IngresoVisitasSegui(ByVal ID_ACCION_FORMATIVA As Decimal)
    Private listaCODIGO_ESTADO_AF As New List(Of String)
    Private listaROLES As New List(Of String)

#Region "Propiedades"

    Public Property PermitirMarcar() As Boolean
        Get
            Return Me.dxgvLista.Columns("#").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("#").Visible = Value
        End Set
    End Property

    Public Property PermitirAccesoAutorizacionParti() As Boolean
        Get
            Return Me.dxgvLista.Columns("SolicitudPartiExo").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("SolicitudPartiExo").Visible = Value
        End Set
    End Property

    Public Property PermitirIngresarVisitasSeguimientoEC() As Boolean
        Get
            Return Me.dxgvLista.Columns("colVisitasSeguimientoEC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colVisitasSeguimientoEC").Visible = Value
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

    Public Property TamanoPagina() As Decimal
        Get
            Return Me.dxgvLista.SettingsPager.PageSize
        End Get
        Set(ByVal value As Decimal)
            Me.dxgvLista.SettingsPager.PageSize = value
        End Set
    End Property

    Public Property NombreFuente() As String
        Get
            Return Me.dxgvLista.Font.Name
        End Get
        Set(ByVal value As String)
            Me.dxgvLista.Font.Name = value
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

    Private _PermitirSolicitarReprogramacion As Boolean = False
    Public Property PermitirSolicitarReprogramacion() As Boolean
        Get
            Return _PermitirSolicitarReprogramacion
        End Get
        Set(ByVal Value As Boolean)
            _PermitirSolicitarReprogramacion = Value
            If Not Me.ViewState("PermitirSolicitarReprogramacion") Is Nothing Then Me.ViewState.Remove("PermitirSolicitarReprogramacion")
            Me.ViewState.Add("PermitirSolicitarReprogramacion", Value)
        End Set
    End Property

    Private _PermitirGenerarInforme As Boolean = False
    Public Property PermitirGenerarInforme() As Boolean
        Get
            Return _PermitirGenerarInforme
        End Get
        Set(ByVal Value As Boolean)
            _PermitirGenerarInforme = Value
            If Not Me.ViewState("PermitirGenerarInforme") Is Nothing Then Me.ViewState.Remove("PermitirGenerarInforme")
            Me.ViewState.Add("PermitirGenerarInforme", Value)
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

    Public Property PermitirPenalizacion() As Boolean
        Get
            Return Me.dxgvLista.Columns("colPenalizacion").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colPenalizacion").Visible = Value
        End Set
    End Property

    Public Property PermitirSeguimiento() As Boolean
        Get
            Return Me.dxgvLista.Columns("colSeguimiento").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colSeguimiento").Visible = Value
        End Set
    End Property

    Private _PermitirCambiarEstado As Boolean = False
    Public Property PermitirCambiarEstado() As Boolean
        Get
            Return _PermitirCambiarEstado
        End Get
        Set(ByVal Value As Boolean)
            _PermitirCambiarEstado = Value
            Me.dxgvLista.Columns("CambiarAEnMatricula").Visible = False
            Me.dxgvLista.Columns("CambiarAIniciado").Visible = False
            Me.dxgvLista.Columns("CambiarAFinalizado").Visible = False
            If Not Me.ViewState("PermitirCambiarEstado") Is Nothing Then Me.ViewState.Remove("PermitirCambiarEstado")
            Me.ViewState.Add("PermitirCambiarEstado", Value)
        End Set
    End Property

    Public Property PermitirFiltroPorFila() As Boolean
        Get
            Return Me.dxgvLista.Settings.ShowFilterRow
        End Get
        Set(ByVal value As Boolean)
            Me.dxgvLista.Settings.ShowFilterRow = value
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

    Public Property VerINFO_CONTRATO() As Boolean
        Get
            Return Me.dxgvLista.Columns("INFO_CONTRATO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("INFO_CONTRATO").Visible = Value
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

    Public Property VerFECHA_INICIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_INICIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_INICIO").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_FIN() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_FIN").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_FIN").Visible = Value
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

    Public Property VerNOMBRE_SITIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_SITIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_SITIO").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_USUARIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO").Visible = Value
        End Set
    End Property

    Public Property VerLUGAR_EJECUCION() As Boolean
        Get
            Return Me.dxgvLista.Columns("LUGAR_EJECUCION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("LUGAR_EJECUCION").Visible = Value
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

    Public Property VerNOMBRE_PROVEEDOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Visible = Value
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

    Public Property VerNoVisitasSeguimiento() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_VISITAS_SEGUIMIENTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_VISITAS_SEGUIMIENTO").Visible = Value
        End Set
    End Property

    Public Property VerColumnaReporte() As Boolean
        Get
            Return Me.dxgvLista.Columns("Reportes").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("Reportes").Visible = Value
        End Set
    End Property

    Public Property VerCambiarAEnMatricula() As Boolean
        Get
            Return Me.dxgvLista.Columns("CambiarAEnMatricula").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CambiarAEnMatricula").Visible = Value
        End Set
    End Property

    Public Property VerCambiarAIniciado() As Boolean
        Get
            Return Me.dxgvLista.Columns("CambiarAIniciado").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CambiarAIniciado").Visible = Value
        End Set
    End Property

    Public Property VerCambiarAFinalizado() As Boolean
        Get
            Return Me.dxgvLista.Columns("CambiarAFinalizado").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CambiarAFinalizado").Visible = Value
        End Set
    End Property

    Public Property VerRevertir_aMatricula() As Boolean
        Get
            Return Me.dxgvLista.Columns("RevertirEstado").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("RevertirEstado").Visible = Value
        End Set
    End Property

    Public Property PermitirCrearGruposCapacitacion() As Boolean
        Get
            Return Me.dxgvLista.Columns("CrearGruposCapacitacion").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CrearGruposCapacitacion").Visible = Value
        End Set
    End Property


    Public Property VerParticipantesPago() As Boolean
        Get
            Return Me.dxgvLista.Columns("PARTICIPANTES_FINALES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PARTICIPANTES_FINALES").Visible = Value
        End Set
    End Property

    Public Property VerMontoFactura() As Boolean
        Get
            Return Me.dxgvLista.Columns("MONTO_FACTURA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MONTO_FACTURA").Visible = Value
        End Set
    End Property

    Public Property VerIngresoSolicitud() As Boolean
        Get
            Return Me.dxgvLista.Columns("IngresoSolicitud").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("IngresoSolicitud").Visible = Value
        End Set
    End Property

    Public Property VerOBSERVACIONES() As Boolean
        Get
            Return Me.dxgvLista.Columns("OBSERVACIONES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OBSERVACIONES").Visible = Value
        End Set
    End Property

    Public Property VerESTADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ESTADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ESTADO").Visible = Value
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

    Public Property HeaderFECHA_INICIO() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_INICIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_INICIO").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_FIN() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_FIN").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_FIN").Caption = Value
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

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/04/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        'Me.odsLista.SelectMethod = "ObtenerLista"
        'Me.odsLista.SelectParameters.Clear()
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
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' filtrado por la tabla OFERTA_FORMATIVA
    ''' </summary>
    ''' <param name="ID_OFERTA_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/04/2010	Created
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
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' filtrado por la tabla SITIO_CAPACITACION
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/04/2010	Created
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
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' filtrado por la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/04/2010	Created
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
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' filtrado por la tabla CURSO_TEMA
    ''' </summary>
    ''' <param name="ID_TEMA_CURSO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/04/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCURSO_TEMA(ByVal ID_TEMA_CURSO As Decimal) As Integer
        Me.odsListaPorCURSO_TEMA.SelectParameters("ID_TEMA_CURSO").DefaultValue = ID_TEMA_CURSO.ToString()
        Me.odsListaPorCURSO_TEMA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCURSO_TEMA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' filtrado por la tabla EJERCICIO
    ''' </summary>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/04/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorEJERCICIO(ByVal ID_EJERCICIO As String) As Integer
        Me.odsListaPorEJERCICIO.SelectParameters("ID_EJERCICIO").DefaultValue = ID_EJERCICIO.ToString()
        Me.odsListaPorEJERCICIO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorEJERCICIO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' filtrado por la tabla ESTADO_ACCION_FORMATIVA
    ''' </summary>
    ''' <param name="CODIGO_ESTADO_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	07/04/2010	Created
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
        'Actualización de Datos Cargados vía Callback
        ActualizarCargarDatosCallback()

        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
        If Not Me.ViewState("PermitirSolicitarReprogramacion") Is Nothing Then Me._PermitirSolicitarReprogramacion = Me.ViewState("PermitirSolicitarReprogramacion")
        If Not Me.ViewState("PermitirGenerarInforme") Is Nothing Then Me._PermitirGenerarInforme = Me.ViewState("PermitirGenerarInforme")
    End Sub

    Protected Sub dxgvLista_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewClientJSPropertiesEventArgs) Handles dxgvLista.CustomJSProperties
        Dim grid As DevExpress.Web.ASPxGridView.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView.ASPxGridView)
        Dim keyTipo(grid.VisibleRowCount - 1) As Object
        Dim keyEstado(grid.VisibleRowCount - 1) As Object
        Dim keyValues(grid.VisibleRowCount - 1) As Object
        For i As Integer = 0 To grid.VisibleRowCount - 1
            keyValues(i) = grid.GetRowValues(i, "ID_ACCION_FORMATIVA")

            Dim lAF As Decimal = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(keyValues(i))

            Select Case lAF
                Case Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE
                    keyTipo(i) = "HABIL"
                Case Enumeradores.ProgramasFormacion.PATI_USAID, Enumeradores.ProgramasFormacion.PATI_BM, Enumeradores.ProgramasFormacion.PATI_2
                    keyTipo(i) = "PATI"
                Case Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL
                    keyTipo(i) = "PROESP"
                Case Enumeradores.ProgramasFormacion.EMPRESA_CENTRO
                    keyTipo(i) = "EC"
                Case -1 'Error
                    keyTipo(i) = ""
            End Select

            keyEstado(i) = grid.GetRowValues(i, "CODIGO_ESTADO_AF")
        Next i
        e.Properties("cpKeyValues") = keyValues
        e.Properties("cpProgramaCurso") = keyTipo
        e.Properties("cpEstadoCurso") = keyEstado

    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "USUARIO" AndAlso Me.dxgvLista.Columns("USUARIO").Visible Then
            Dim eUSUARIO As USUARIO
            eUSUARIO = (New cUSUARIO).ObtenerUSUARIO(e.GetListSourceFieldValue("USERID").ToString)
            If eUSUARIO IsNot Nothing Then e.Value = eUSUARIO.NOMBRE
        End If
        If e.Column.FieldName = "NOMBRE_SITIO" AndAlso Me.dxgvLista.Columns("NOMBRE_SITIO").Visible Then
            Dim eSITIO_CAPACITACION As SITIO_CAPACITACION
            eSITIO_CAPACITACION = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(e.GetListSourceFieldValue("ID_SITIO_CAPACITACION").ToString)
            If eSITIO_CAPACITACION IsNot Nothing Then e.Value = eSITIO_CAPACITACION.NOMBRE_SITIO
        End If
        If e.Column.FieldName = "NOMBRE_PROVEEDOR" AndAlso Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Visible Then
            Dim lEntidad As PROVEEDOR_AF
            lEntidad = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(e.GetListSourceFieldValue("ID_PROVEEDOR_AF").ToString)
            If lEntidad IsNot Nothing Then e.Value = lEntidad.NOMBRE_PROVEEDOR
        End If
        If e.Column.FieldName = "ESTADO" AndAlso Me.dxgvLista.Columns("ESTADO").Visible Then
            Dim eESTADO_ACCION_FORMATIVA As ESTADO_ACCION_FORMATIVA

            eESTADO_ACCION_FORMATIVA = (New cESTADO_ACCION_FORMATIVA).ObtenerESTADO_ACCION_FORMATIVA(e.GetListSourceFieldValue("CODIGO_ESTADO_AF").ToString)
            If eESTADO_ACCION_FORMATIVA IsNot Nothing Then e.Value = eESTADO_ACCION_FORMATIVA.NOMBRE_ESTADO_AF
        End If
        If e.Column.FieldName = "MONTO_FACTURA" AndAlso Me.dxgvLista.Columns("MONTO_FACTURA").Visible Then
            Dim lListaInforme As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(CDec(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA")))
            If lListaInforme IsNot Nothing AndAlso lListaInforme.Count > 0 Then
                e.Value = lListaInforme(0).MONTO_FACTURA
            End If
        End If
        If e.Column.FieldName = "PARTICIPANTES_FINALES" AndAlso Me.dxgvLista.Columns("PARTICIPANTES_FINALES").Visible Then
            Dim lListaInforme As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(CDec(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA")))
            If lListaInforme IsNot Nothing AndAlso lListaInforme.Count > 0 Then
                e.Value = lListaInforme(0).PARTICIPANTES_FINALES
            End If
        End If
        If e.Column.FieldName = "DEPARTAMENTO" Then
            Dim lEntidad As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA"))
            If lEntidad IsNot Nothing Then
                Dim lDepto As DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(lEntidad.CODIGO_DEPARTAMENTO)
                If lDepto IsNot Nothing Then e.Value = lDepto.NOMBRE
            End If
        End If
        If e.Column.FieldName = "MUNICIPIO" Then
            Dim lEntidad As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA"))
            If lEntidad IsNot Nothing Then
                Dim lMuni As MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(lEntidad.CODIGO_DEPARTAMENTO, lEntidad.CODIGO_MUNICIPIO)
                If lMuni IsNot Nothing Then e.Value = lMuni.NOMBRE
            End If
        End If
        If e.Column.FieldName = "LUGAR_EJECUCION" AndAlso Me.dxgvLista.Columns("LUGAR_EJECUCION").Visible Then
            Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(CDec(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA")))
            If lAccionDetalle IsNot Nothing AndAlso lAccionDetalle.LUGAR_EJECUCION IsNot Nothing Then
                e.Value = lAccionDetalle.LUGAR_EJECUCION
            End If
        End If
        If e.Column.FieldName = "INFO_CONTRATO" AndAlso Me.dxgvLista.Columns("INFO_CONTRATO").Visible Then
            e.Value = (New cACCION_FORMATIVA).ObtenerInfoContratacion(CDec(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA")))
        End If
        If e.Column.FieldName = "NO_VISITAS_SEGUIMIENTO" AndAlso Me.dxgvLista.Columns("NO_VISITAS_SEGUIMIENTO").Visible Then
            Dim lstAccionVisitas As listaACCION_VISITAS_SEGUI

            lstAccionVisitas = (New cACCION_VISITAS_SEGUI).ObtenerListaPorACCION_FORMATIVA(CDec(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA")))
            If lstAccionVisitas IsNot Nothing AndAlso lstAccionVisitas.Count > 0 Then
                e.Value = lstAccionVisitas(0).NO_VISITAS
            End If
        End If
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
            RaiseEvent Seleccionado(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            Dim lEntidad As ACCION_FORMATIVA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), ACCION_FORMATIVA)
            If lEntidad IsNot Nothing AndAlso lEntidad.HORARIO = "" Then
                Me.dxgvLista.JSProperties("cpMensaje") = "Curso no se puede Editar"
                Me.AsignarMensaje("Curso no se puede Editar", False, True)
                Return
            End If
            RaiseEvent Editando(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "Reprogramar" Then
            Dim lEntidad As ACCION_FORMATIVA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), ACCION_FORMATIVA)
            Dim cantidadInformeFinalAF As Integer
            Dim cantidadInformeFinalAF_DET As Integer

            cantidadInformeFinalAF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA).Count
            cantidadInformeFinalAF_DET = (New cINFORME_FINAL_DET).ObtenerListaPorACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA).Count

            If lEntidad.CODIGO_ESTADO_AF = Enumeradores.EstadoSolicitud.Finalizada Then
                If cantidadInformeFinalAF = 1 AndAlso cantidadInformeFinalAF_DET = 0 Then
                    Me.AsignarMensaje("ADVERTENCIA!!!: Si el supervisor de INSAFORP aprueba la Reprogramacion que va a solicitar " & _
                    " el curso sera trasladado al estado de INICIADO. Por lo tanto para que usted pueda volver a FINALIZARLO tendra que ingresar las NOTAS OBTENIDAS por cada participante del curso y debera imprimir el INFORME FINAL.", False, True)
                End If
            End If
            RaiseEvent Reprogramando(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "InformeParcial" Then
            RaiseEvent InformeParcial(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "Penalizacion" Then
            RaiseEvent Penalizar(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "IngresoVisitasSeguimiento" Then
            RaiseEvent IngresoVisitasSegui(e.KeyValue)
        End If
    End Sub

    Protected Sub dxgvLista_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowCreated

        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Data Then
            Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(Convert.ToDecimal(e.GetValue("ID_ACCION_FORMATIVA")))

            If Not Me.PermitirEditar Then
                Dim lbDetalle As LinkButton
                lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                lbDetalle.Visible = False
            Else
                Dim lbDetalle As LinkButton
                lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
                If lbDetalle IsNot Nothing Then lbDetalle.Visible = (Me.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPATI) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPROYESPECIAL) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.CentroCapacitador) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.Administrador) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.CoordinadorGFI) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.GerenteGFI))
            End If

            Dim lbSolicitarReprog As LinkButton
            lbSolicitarReprog = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnSolicitarReprogramacion")
            lbSolicitarReprog.Visible = Me.PermitirSolicitarReprogramacion AndAlso (Me.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPATI) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPROYESPECIAL) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.CentroCapacitador) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.Administrador))

            Dim lbInformeParcial As LinkButton
            Dim lstInformParcial As listaINFORME_FINAL_AF
            lbInformeParcial = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnInformeParcial")

            lbInformeParcial.Visible = False
            If lAccionFormativa IsNot Nothing AndAlso _
                lAccionFormativa.FECHA_INICIO_REAL < New DateTime(2020, 3, 11) AndAlso lAccionFormativa.FECHA_FIN_REAL > New DateTime(2020, 3, 11) AndAlso _
                lAccionFormativa.CODIGO_ESTADO_AF = EstadoAccionFormativa.Iniciada AndAlso _
                lAccionFormativa.PARTICIPANTES_INSCRITOS > 0 Then
                lstInformParcial = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)

                Dim dicc As Dictionary(Of String, Decimal) = (New cACCION_FORMATIVA).ObtenerPorcentajeAvancePorAccionFormativa(lAccionFormativa.ID_ACCION_FORMATIVA, New DateTime(2020, 3, 11))
                If dicc IsNot Nothing AndAlso dicc("PORCENTAJE_EJECUCION") >= 50 AndAlso (lstInformParcial Is Nothing OrElse (lstInformParcial IsNot Nothing AndAlso lstInformParcial.Count = 0)) Then
                    lbInformeParcial.Visible = Me.PermitirGenerarInforme
                End If
            End If

            Dim ASPxImage1 As ASPxImage
            ASPxImage1 = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "ASPxImage1")
            If Not ASPxImage1 Is Nothing Then
                ASPxImage1.JSProperties("cpIndex") = e.VisibleIndex
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

    Public Function DevolverSeleccionados() As listaACCION_FORMATIVA
        Dim mLista As New listaACCION_FORMATIVA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_ACCION_FORMATIVA")
            Dim lEntidad As New ACCION_FORMATIVA
            lEntidad.ID_ACCION_FORMATIVA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        Me.dxgvLista.JSProperties("cpMensaje") = ""
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As ACCION_FORMATIVA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), ACCION_FORMATIVA)

            Dim bAutorizacion As New cACCION_PROGRA_RETRO
            Dim lstAutorizacion As listaACCION_PROGRA_RETRO
            Dim lstInformes As listaINFORME_FINAL_AF
            Dim informeEnCA As Boolean = False

            lstAutorizacion = (New cACCION_PROGRA_RETRO).ObtenerACCION_PROGRA_RETRO_PorCriterios(lEntidad.ID_PROVEEDOR_AF, _
                                                                               lEntidad.ID_EJERCICIO, _
                                                                               lEntidad.CODIGO_GRUPO, _
                                                                               AutorizacionExcepcion.EliminarAccionFormativa, _
                                                                               1)
            If lstAutorizacion IsNot Nothing AndAlso lstAutorizacion.Count > 0 AndAlso lstAutorizacion(0).FECHA_EXPIRA >= Today Then
                lstInformes = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA)
                If lstInformes IsNot Nothing AndAlso lstInformes.Count > 0 Then
                    For i As Integer = 0 To lstInformes.Count - 1
                        If lstInformes(i).ID_ESTADO_INFORME <> EstadoInformeFinal.Emitido Then
                            informeEnCA = True
                            Exit For
                        End If
                    Next
                    If informeEnCA Then
                        Me.dxgvLista.JSProperties("cpMensaje") = "No se puede eliminar el curso debido a que existe informe de ejecucion en revision"
                        Me.AsignarMensaje("No se puede eliminar el curso debido a que existe informe de ejecucion emitido", True, True)
                        Return
                    End If
                End If
                If Me.mComponente.EliminarACCION_FORMATIVA_EN_CASCADA(lEntidad.ID_ACCION_FORMATIVA) <> 1 Then
                    'Si se cometio un error
                    Me.dxgvLista.JSProperties("cpMensaje") = "Error al Eliminar Registro"
                    Me.AsignarMensaje("Error al Eliminar Registro", True, True)
                    Return
                Else
                    lstAutorizacion(0).ID_ACCION_FORMATIVA = lEntidad.ID_ACCION_FORMATIVA
                    lstAutorizacion(0).USUARIO_PROGRAMO = Me.ObtenerUsuario
                    lstAutorizacion(0).FECHA_PROGRAMO = Now
                    lstAutorizacion(0).USERID = Me.ObtenerUsuario
                    lstAutorizacion(0).LASTUPDATE = Now
                    lstAutorizacion(0).ACTIVO = 0
                    bAutorizacion.ActualizarACCION_PROGRA_RETRO(lstAutorizacion(0))

                    Me.dxgvLista.DataBind()
                End If
            Else
                Me.dxgvLista.JSProperties("cpMensaje") = "Solicite autorizacion para eliminar el curso"
                Me.AsignarMensaje("Solicite autorizacion para eliminar el curso", False, True)
                Return
            End If
            
        End If

        If e.ButtonID = "btnCambiarAEnMatricula" Then
            Dim lEntidad As ACCION_FORMATIVA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), ACCION_FORMATIVA)
            Dim programacion As listaASISTENCIA_AF
            lEntidad.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.EnMatricula
            lEntidad.USERID = Me.ObtenerUsuario
            lEntidad.LASTUPDATE = Now
            programacion = (New cASISTENCIA_AF).ObtenerListaPorACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA)
            If programacion Is Nothing OrElse programacion.Count = 0 Then
                Me.dxgvLista.JSProperties("cpMensaje") = "Curso no se pudo cambiar a Matricula, Ingrese la Programacion del Curso"
                Me.AsignarMensaje("Curso no se pudo cambiar a Matricula, Ingrese la Programacion del Curso", False, True)
                Return
            End If
            If Me.mComponente.ActualizarACCION_FORMATIVA(lEntidad) < 1 Then
                Me.dxgvLista.JSProperties("cpMensaje") = "Curso no se pudo cambiar a Matricula: " + mComponente.sError
                Me.AsignarMensaje("Curso no se pudo cambiar a Matricula: " + mComponente.sError, False, True)
                Return
            End If
            Me.dxgvLista.DataBind()
        End If

        If e.ButtonID = "btnCambiarAIniciado" Then
            Dim lEntidad As ACCION_FORMATIVA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), ACCION_FORMATIVA)
            Dim accionFormativa As New cACCION_FORMATIVA
            Dim eTDR As TERMINO_REFERENCIA_AF
            lEntidad.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Iniciada
            lEntidad.USERID = Me.ObtenerUsuario
            lEntidad.LASTUPDATE = Now

            eTDR = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(lEntidad.ID_ACCION_FORMATIVA)
            If eTDR Is Nothing Then
                If accionFormativa.ObtenerCantidadParticipantesInscritos(lEntidad.ID_ACCION_FORMATIVA) = 0 Then
                    Me.dxgvLista.JSProperties("cpMensaje") = "Curso no se pudo Iniciar porque no existen Participantes Inscritos. Por favor verifique."
                    Me.AsignarMensaje("Curso no se pudo Iniciar porque no existen Participantes Inscritos. Por favor verifique.", False, True)
                    Return
                End If

                If (New cSOLICITUD_INSCRIPCION_AF).ObtenerCantidadPendienteAprobacionDenegacionPorCurso(lEntidad.ID_ACCION_FORMATIVA) > 0 Then
                    Me.dxgvLista.JSProperties("cpMensaje") = "Curso no se pudo Iniciar porque existen Solicitudes en Espera de Aprobacion. Por favor verifique."
                    Me.AsignarMensaje("Curso no se pudo Iniciar porque existen Solicitudes en Espera de Aprobacion. Por favor verifique.", False, True)
                    Return
                End If
            Else
                If accionFormativa.ObtenerCantidadParticipantesInscritos(lEntidad.ID_ACCION_FORMATIVA) = 0 Then
                    Me.dxgvLista.JSProperties("cpMensaje") = "Curso no se pudo Iniciar porque no se ha inscrito ningun Participante del Programa PATI. Por favor verifique."
                    Me.AsignarMensaje("Curso no se pudo Iniciar porque no se ha inscrito ningun Participante del Programa PATI. Por favor verifique.", False, True)
                    Return
                End If
            End If
            If accionFormativa.ActualizarACCION_FORMATIVA(lEntidad) < 1 Then
                Me.dxgvLista.JSProperties("cpMensaje") = "Curso no se pudo cambiar a Iniciado: " + accionFormativa.sError
                Me.AsignarMensaje("Curso no se pudo cambiar a Iniciado " + accionFormativa.sError, False, True)
                Return
            End If
            Me.dxgvLista.DataBind()
        End If

        If e.ButtonID = "btnCambiarAFinalizado" Then
            Dim lEntidad As ACCION_FORMATIVA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), ACCION_FORMATIVA)
            Dim accionFormativa As New cACCION_FORMATIVA

            If (New cASISTENCIA_AF).ObtenerListaPorACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA).Count = 0 Then
                Me.dxgvLista.JSProperties("cpMensaje") = "Curso no se pudo cambiar a Finalizado porque no existe Ingreso de Asistencia al mismo. Por favor verifique."
                Me.AsignarMensaje("Curso no se pudo cambiar a Finalizado porque no existe Ingreso de Asistencia al mismo. Por favor verifique.", False, True)
                Return
            End If

            Dim ExisteEvalPractica As Boolean = False
            For Each lEvaluacion As EVALUACION_AF In (New cEVALUACION_AF).ObtenerListaPorACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA)
                If lEvaluacion.TIPO_EVALUACION = "P" Then
                    ExisteEvalPractica = True
                    Exit For
                End If
            Next
            If Not ExisteEvalPractica Then
                Me.dxgvLista.JSProperties("cpMensaje") = "Curso no se pudo cambiar a Finalizado porque no existe Ingreso de Notas de Evaluaci&oacute;n Pr&aacute;ctica. Por favor verifique."
                Me.AsignarMensaje("Curso no se pudo cambiar a Finalizado porque no existe Ingreso de Notas de Evaluación Práctica. Por favor verifique.", False, True)
                Return
            End If

            Dim lidProgramaFormacion As Decimal = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(lEntidad.ID_ACCION_FORMATIVA)
            If lidProgramaFormacion = Enumeradores.ProgramasFormacion.PATI_BM OrElse lidProgramaFormacion = Enumeradores.ProgramasFormacion.PATI_USAID OrElse lidProgramaFormacion = Enumeradores.ProgramasFormacion.PATI_2 OrElse _
               lidProgramaFormacion = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL Then
                Dim lTerminoReferencia As TERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(lEntidad.ID_ACCION_FORMATIVA)
                If lTerminoReferencia IsNot Nothing AndAlso lTerminoReferencia.RESOLUCION = "" Then
                    Me.dxgvLista.JSProperties("cpMensaje") = "Curso no se pudo cambiar a Finalizado porque no existe Orden de Compra asignada. Por Favor Notifique a la UACI que este Curso con TDR: " + lTerminoReferencia.TDR + " no tiene asignado Orden de Compra."
                    Me.AsignarMensaje("Curso no se pudo cambiar a Finalizado porque no existe Orden de Compra asignada. Por Favor Notifique a la UACI que este Curso con TDR: " + lTerminoReferencia.TDR + " no tiene asignado Orden de Compra.", False, True)
                    Return
                End If
            End If

            lEntidad.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Finalizada
            lEntidad.USERID = Me.ObtenerUsuario
            lEntidad.LASTUPDATE = Now
            lEntidad.OBSERVACIONES = ""

            If accionFormativa.ActualizarACCION_FORMATIVA(lEntidad) < 1 Then
                Me.dxgvLista.JSProperties("cpMensaje") = "Curso no se pudo cambiar a Finalizado:" + accionFormativa.sError
                Me.AsignarMensaje("Curso no se pudo cambiar a Finalizado: " + accionFormativa.sError, False, True)
                Return
            End If

            'Alertar si el curso ha generado penalización



            Me.dxgvLista.DataBind()
        End If

        If e.ButtonID = "btnRevertirEstado" Then
            Dim bAccionFormativa As New cACCION_FORMATIVA
            Dim aEntidad As ACCION_FORMATIVA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), ACCION_FORMATIVA)
            aEntidad = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
            If aEntidad IsNot Nothing Then
                Select Case aEntidad.CODIGO_ESTADO_AF
                    Case Enumeradores.EstadoAccionFormativa.Iniciada
                        aEntidad.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.EnMatricula
                        aEntidad.USERID = Me.ObtenerUsuario
                        aEntidad.LASTUPDATE = Now
                        aEntidad.OBSERVACIONES = "CURSO SE PASA A MATRICULA POR EL USUARIO: " + Me.ObtenerUsuario
                        If bAccionFormativa.ActualizarACCION_FORMATIVA(aEntidad) < 1 Then
                            Me.dxgvLista.JSProperties("cpMensaje") = "Curso no se pudo cambiar a Matricula:" + bAccionFormativa.sError
                            Me.AsignarMensaje("Curso no se pudo cambiar a Matricula: " + bAccionFormativa.sError, False, True)
                            Return
                        End If
                        Me.dxgvLista.DataBind()

                    Case Enumeradores.EstadoAccionFormativa.Finalizada
                        'Verificar si algun informe se encuentra en otro estado que no sea Emitido
                        Dim listaInformeEjecucion As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
                        Dim bInforme As New cINFORME_FINAL_AF
                        If listaInformeEjecucion IsNot Nothing Then
                            For Each lInforme As INFORME_FINAL_AF In listaInformeEjecucion
                                If lInforme.ID_ESTADO_INFORME <> Enumeradores.EstadoInformeFinal.Emitido Then
                                    Me.dxgvLista.JSProperties("cpMensaje") = "Curso no se pudo cambiar a Matricula debido a que posee Informes Entregados"
                                    Me.AsignarMensaje("Curso no se pudo cambiar a Matricula debido a que posee Informes Entregados", False, True)
                                    Return
                                End If
                            Next
                        End If
                        For Each lInforme As INFORME_FINAL_AF In listaInformeEjecucion
                            bInforme.EliminarINFORME_FINAL_AF(lInforme.ID_INFORME_FINAL)
                        Next
                        aEntidad.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.EnMatricula
                        aEntidad.USERID = Me.ObtenerUsuario
                        aEntidad.LASTUPDATE = Now
                        aEntidad.OBSERVACIONES = "CURSO SE PASA A MATRICULA POR EL USUARIO: " + Me.ObtenerUsuario
                        If bAccionFormativa.ActualizarACCION_FORMATIVA(aEntidad) < 1 Then
                            Me.dxgvLista.JSProperties("cpMensaje") = "Curso no se pudo cambiar a Matricula:" + bAccionFormativa.sError
                            Me.AsignarMensaje("Curso no se pudo cambiar a Matricula: " + bAccionFormativa.sError, False, True)
                            Return
                        End If
                        Me.dxgvLista.DataBind()
                End Select
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            e.Text = "<img src='../imagenes/Eliminar.png' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
        End If
        If e.ButtonID = "btnSolicitudPartiExo" AndAlso e.CellType = ASPxGridView.GridViewTableCommandCellType.Data Then
            Dim lAccionFormativa As ACCION_FORMATIVA
            lAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(dxgvLista.GetRowValues(e.VisibleIndex, "ID_ACCION_FORMATIVA"))
            If (EstaEnRol(Enumeradores.RolDeUsuario.AutorizarParticipantesSinDoctos) OrElse EstaEnRol(Enumeradores.RolDeUsuario.Administrador)) AndAlso _
                (lAccionFormativa.CODIGO_ESTADO_AF = EstadoAccionFormativa.EnMatricula OrElse _
                 lAccionFormativa.CODIGO_ESTADO_AF = EstadoAccionFormativa.Iniciada OrElse _
                 lAccionFormativa.CODIGO_ESTADO_AF = EstadoAccionFormativa.Finalizada) Then
                Dim sUrl As New StringBuilder
                sUrl.Append("window.open('../CursosFormacion/wfSolicitudParticipantesSinDoctos.aspx?idc=")
                sUrl.Append(lAccionFormativa.ID_ACCION_FORMATIVA.ToString)
                sUrl.Append("','_blank','')")
                e.Text = "<img src=""../imagenes/participante.gif"" alt=""Autorizar ingreso participantes sin documentos"" onclick=""" + sUrl.ToString + """ />"
                e.Visible = DevExpress.Utils.DefaultBoolean.True
            Else
                e.Visible = DevExpress.Utils.DefaultBoolean.False
            End If
        End If
        If e.ButtonID = "btnPenalizacion" AndAlso e.CellType = ASPxGridView.GridViewTableCommandCellType.Data Then
            Dim lAccionFormativa As ACCION_FORMATIVA
            lAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(dxgvLista.GetRowValues(e.VisibleIndex, "ID_ACCION_FORMATIVA"))
            If (EstaEnRol(Enumeradores.RolDeUsuario.Auditor) OrElse _
                EstaEnRol(Enumeradores.RolDeUsuario.AuditorUMEFP) OrElse _
                EstaEnRol(Enumeradores.RolDeUsuario.GerenteGFI) OrElse _
                EstaEnRol(Enumeradores.RolDeUsuario.CoordinadorGFI) OrElse _
                EstaEnRol(Enumeradores.RolDeUsuario.CoordinadorECentro) OrElse _
                EstaEnRol(Enumeradores.RolDeUsuario.SoporteGFI) OrElse _
                EstaEnRol(Enumeradores.RolDeUsuario.Administrador)) Then
                Dim sUrl As New StringBuilder
                sUrl.Append("window.open('../GFI/wfMantACCION_FORMATIVA_PENA.aspx?idc=")
                sUrl.Append(lAccionFormativa.ID_ACCION_FORMATIVA.ToString)
                sUrl.Append("','_blank','')")
                e.Text = "<img src=""../imagenes/Finance-Banknotes-icon.png"" alt=""Penalizaciones del curso"" onclick=""" + sUrl.ToString + """ />"
                e.Visible = DevExpress.Utils.DefaultBoolean.True
            Else
                e.Visible = DevExpress.Utils.DefaultBoolean.False
            End If
        End If
        If e.ButtonID = "btnSeguimiento" AndAlso e.CellType = ASPxGridView.GridViewTableCommandCellType.Data Then
            Dim lAccionFormativa As ACCION_FORMATIVA
            lAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(dxgvLista.GetRowValues(e.VisibleIndex, "ID_ACCION_FORMATIVA"))
            If (EstaEnRol(Enumeradores.RolDeUsuario.Auditor) OrElse _
                EstaEnRol(Enumeradores.RolDeUsuario.AuditorUMEFP) OrElse _
                EstaEnRol(Enumeradores.RolDeUsuario.GerenteGFI) OrElse _
                EstaEnRol(Enumeradores.RolDeUsuario.CoordinadorGFI) OrElse _
                EstaEnRol(Enumeradores.RolDeUsuario.CoordinadorECentro) OrElse _
                EstaEnRol(Enumeradores.RolDeUsuario.SoporteGFI) OrElse _
                EstaEnRol(Enumeradores.RolDeUsuario.Administrador)) Then
                Dim sUrl As New StringBuilder
                sUrl.Append("window.open('../GFI/wfMantACCION_FORMATIVA_SEGUI.aspx?idc=")
                sUrl.Append(lAccionFormativa.ID_ACCION_FORMATIVA.ToString)
                sUrl.Append("','_blank','')")
                e.Text = "<img src=""../imagenes/ButtonEdit.png"" alt=""Visitas de seguimiento"" onclick=""" + sUrl.ToString + """ />"
                e.Visible = DevExpress.Utils.DefaultBoolean.True
            Else
                e.Visible = DevExpress.Utils.DefaultBoolean.False
            End If
        End If
        If e.ButtonID = "btnCrearGrupos" AndAlso e.CellType = ASPxGridView.GridViewTableCommandCellType.Data Then
            Dim lAccionFormativa As ACCION_FORMATIVA
            lAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(dxgvLista.GetRowValues(e.VisibleIndex, "ID_ACCION_FORMATIVA"))
            If lAccionFormativa.HORARIO IsNot Nothing OrElse lAccionFormativa.HORARIO <> "" Then
                e.Visible = DevExpress.Utils.DefaultBoolean.False
            End If
        End If
        If e.ButtonID = "btnCambiarAEnMatricula" AndAlso e.CellType = ASPxGridView.GridViewTableCommandCellType.Data Then
            Dim lAsistencia As listaASISTENCIA_AF
            lAsistencia = (New cASISTENCIA_AF).ObtenerListaPorACCION_FORMATIVA(dxgvLista.GetRowValues(e.VisibleIndex, "ID_ACCION_FORMATIVA"))
            If lAsistencia Is Nothing OrElse lAsistencia.Count = 0 Then
                e.Visible = DevExpress.Utils.DefaultBoolean.False
            End If
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' filtrado por los criterios recibidos
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_AREA_FORMACION"></param>
    ''' <param name="NOMBRE_ACCION_FORMATIVA"></param>
    ''' <param name="CODIGO_ESTADO_AF"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/03/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriteriosPeriodoEstado(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                ByVal ID_AREA_FORMACION As Decimal, _
                                                ByVal NOMBRE_ACCION_FORMATIVA As String, _
                                                ByVal CODIGO_GRUPO As String, _
                                                ByVal CODIGO_ESTADO_AF As String, _
                                                ByVal ID_EJERCICIO As String, _
                                                ByVal TDR As String) As Integer

        Me.odsPorCriteriosPeriodoEstado.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString()
        Me.odsPorCriteriosPeriodoEstado.SelectParameters("ID_SITIO_CAPACITACION").DefaultValue = ID_SITIO_CAPACITACION.ToString()
        Me.odsPorCriteriosPeriodoEstado.SelectParameters("ID_AREA_FORMACION").DefaultValue = ID_AREA_FORMACION.ToString()
        Me.odsPorCriteriosPeriodoEstado.SelectParameters("NOMBRE_ACCION_FORMATIVA").DefaultValue = NOMBRE_ACCION_FORMATIVA.ToString()
        Me.odsPorCriteriosPeriodoEstado.SelectParameters("CODIGO_GRUPO").DefaultValue = CODIGO_GRUPO.ToString()
        Me.odsPorCriteriosPeriodoEstado.SelectParameters("CODIGO_ESTADO_AF").DefaultValue = CODIGO_ESTADO_AF.ToString()
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
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' filtrado por los criterios recibidos
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_AREA_FORMACION"></param>
    ''' <param name="NOMBRE_ACCION_FORMATIVA"></param>
    ''' <param name="CODIGO_ESTADO_AF"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	21/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriteriosPeriodoEstadosTecnico(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                ByVal ID_AREA_FORMACION As Decimal, _
                                                ByVal NOMBRE_ACCION_FORMATIVA As String, _
                                                ByVal CODIGO_GRUPO As String, _
                                                ByVal CODIGO_ESTADO_AF As List(Of String), _
                                                ByVal ID_EJERCICIO As String, _
                                                ByVal USUARIO_TECNICO As String, _
                                                ByVal TDR As String) As Integer

        Me.odsPorCriteriosPeriodoEstadosTecnico.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString()
        Me.odsPorCriteriosPeriodoEstadosTecnico.SelectParameters("ID_SITIO_CAPACITACION").DefaultValue = ID_SITIO_CAPACITACION.ToString()
        Me.odsPorCriteriosPeriodoEstadosTecnico.SelectParameters("ID_AREA_FORMACION").DefaultValue = ID_AREA_FORMACION.ToString()
        Me.odsPorCriteriosPeriodoEstadosTecnico.SelectParameters("NOMBRE_ACCION_FORMATIVA").DefaultValue = NOMBRE_ACCION_FORMATIVA.ToString()
        Me.odsPorCriteriosPeriodoEstadosTecnico.SelectParameters("CODIGO_GRUPO").DefaultValue = CODIGO_GRUPO.ToString()
        Me.listaCODIGO_ESTADO_AF = CODIGO_ESTADO_AF
        Me.odsPorCriteriosPeriodoEstadosTecnico.SelectParameters("ID_EJERCICIO").DefaultValue = ID_EJERCICIO.ToString()
        Me.odsPorCriteriosPeriodoEstadosTecnico.SelectParameters("USUARIO_TECNICO").DefaultValue = USUARIO_TECNICO.ToString()
        Me.odsPorCriteriosPeriodoEstadosTecnico.SelectParameters("TDR").DefaultValue = TDR.ToString()
        Me.odsPorCriteriosPeriodoEstadosTecnico.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsPorCriteriosPeriodoEstadosTecnico.SelectParameters("asTipoOrden").DefaultValue = "ASC"
        Me.odsPorCriteriosPeriodoEstadosTecnico.DataBind()
        Me.dxgvLista.DataSourceID = "odsPorCriteriosPeriodoEstadosTecnico"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1

    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Metodo que muestra el estado al cual se podrá cambiar el curso
    ''' </summary>
    ''' <param name="CODIGO_ESTADO_AF"></param> 
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	26/03/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarCambioEstado(ByVal CODIGO_ESTADO_AF As String)
        Select Case CODIGO_ESTADO_AF
            Case Enumeradores.EstadoAccionFormativa.Ingresada
                Me.dxgvLista.Columns("CambiarAEnMatricula").Visible = (Me.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPATI) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPROYESPECIAL) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.CentroCapacitador) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.Administrador))
                Me.dxgvLista.Columns("CambiarAIniciado").Visible = False
                Me.dxgvLista.Columns("CambiarAFinalizado").Visible = False
            Case Enumeradores.EstadoAccionFormativa.EnMatricula
                Me.dxgvLista.Columns("CambiarAEnMatricula").Visible = False
                Me.dxgvLista.Columns("CambiarAIniciado").Visible = (Me.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPATI) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPROYESPECIAL) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.CentroCapacitador) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.Administrador))
                Me.dxgvLista.Columns("CambiarAFinalizado").Visible = False
            Case Enumeradores.EstadoAccionFormativa.Iniciada
                Me.dxgvLista.Columns("CambiarAEnMatricula").Visible = False
                Me.dxgvLista.Columns("CambiarAIniciado").Visible = False
                Me.dxgvLista.Columns("CambiarAFinalizado").Visible = (Me.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPATI) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPROYESPECIAL) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.CentroCapacitador) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.Administrador))
            Case Else
                Me.dxgvLista.Columns("CambiarAEnMatricula").Visible = False
                Me.dxgvLista.Columns("CambiarAIniciado").Visible = False
                Me.dxgvLista.Columns("CambiarAFinalizado").Visible = False
        End Select
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' filtrado por los criterios recibidos
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_AREA_FORMACION"></param>
    ''' <param name="NOMBRE_ACCION_FORMATIVA"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	08/03/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriteriosPeriodo(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_AREA_FORMACION As Decimal, ByVal NOMBRE_ACCION_FORMATIVA As String, ByVal CODIGO_GRUPO As String, ByVal ID_EJERCICIO As String, ByVal listaROLES As String, ByVal TDR As String) As Integer
        Me.odsListaPorCriteriosPeriodoCursosMatriculaIniciados.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString()
        Me.odsListaPorCriteriosPeriodoCursosMatriculaIniciados.SelectParameters("ID_SITIO_CAPACITACION").DefaultValue = ID_SITIO_CAPACITACION.ToString()
        Me.odsListaPorCriteriosPeriodoCursosMatriculaIniciados.SelectParameters("ID_AREA_FORMACION").DefaultValue = ID_AREA_FORMACION.ToString()
        Me.odsListaPorCriteriosPeriodoCursosMatriculaIniciados.SelectParameters("NOMBRE_ACCION_FORMATIVA").DefaultValue = NOMBRE_ACCION_FORMATIVA.ToString()
        Me.odsListaPorCriteriosPeriodoCursosMatriculaIniciados.SelectParameters("CODIGO_GRUPO").DefaultValue = CODIGO_GRUPO.ToString()
        Me.odsListaPorCriteriosPeriodoCursosMatriculaIniciados.SelectParameters("ID_EJERCICIO").DefaultValue = ID_EJERCICIO.ToString()
        Me.odsListaPorCriteriosPeriodoCursosMatriculaIniciados.SelectParameters("listaROLES").DefaultValue = listaROLES
        Me.odsListaPorCriteriosPeriodoCursosMatriculaIniciados.SelectParameters("TDR").DefaultValue = TDR.ToString()
        Me.odsListaPorCriteriosPeriodoCursosMatriculaIniciados.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCriteriosPeriodoCursosMatriculaIniciados.SelectParameters("asTipoOrden").DefaultValue = "ASC"
        Me.odsListaPorCriteriosPeriodoCursosMatriculaIniciados.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriteriosPeriodoCursosMatriculaIniciados"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' filtrado por los criterios recibidos
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_AREA_FORMACION"></param>
    ''' <param name="NOMBRE_ACCION_FORMATIVA"></param>
    ''' <param name="CODIGO_GRUPO"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <param name="TDR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	04/04/2013	Created
    ''' </history>
    ''' ----------------------------------------------------------------------------- 
    Public Function CargarDatosPorCriteriosRoles(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                    ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                    ByVal ID_AREA_FORMACION As Decimal, _
                                                    ByVal NOMBRE_ACCION_FORMATIVA As String, _
                                                    ByVal CODIGO_GRUPO As String, _
                                                    ByVal ID_EJERCICIO As String, _
                                                    ByVal plistaROLES As String, _
                                                    ByVal plistaCODIGO_ESTADO_AF As String, _
                                                    ByVal TDR As String) As Integer
        'listaROLES = plistaROLES
        'listaCODIGO_ESTADO_AF = plistaCODIGO_ESTADO_AF

        Me.odsListaPorCriteriosRoles.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString()
        Me.odsListaPorCriteriosRoles.SelectParameters("ID_SITIO_CAPACITACION").DefaultValue = ID_SITIO_CAPACITACION.ToString()
        Me.odsListaPorCriteriosRoles.SelectParameters("ID_AREA_FORMACION").DefaultValue = ID_AREA_FORMACION.ToString()
        Me.odsListaPorCriteriosRoles.SelectParameters("NOMBRE_ACCION_FORMATIVA").DefaultValue = NOMBRE_ACCION_FORMATIVA.ToString()
        Me.odsListaPorCriteriosRoles.SelectParameters("CODIGO_GRUPO").DefaultValue = CODIGO_GRUPO.ToString()
        Me.odsListaPorCriteriosRoles.SelectParameters("ID_EJERCICIO").DefaultValue = ID_EJERCICIO.ToString()
        Me.odsListaPorCriteriosRoles.SelectParameters("listaROLES").DefaultValue = plistaROLES
        Me.odsListaPorCriteriosRoles.SelectParameters("listaCODIGO_ESTADO_AF").DefaultValue = plistaCODIGO_ESTADO_AF
        Me.odsListaPorCriteriosRoles.SelectParameters("TDR").DefaultValue = TDR.ToString()
        Me.odsListaPorCriteriosRoles.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCriteriosRoles.SelectParameters("asTipoOrden").DefaultValue = "ASC"
        Me.odsListaPorCriteriosRoles.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriteriosRoles"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' filtrado por los criterios recibidos
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>   
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	26/08/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorAccionFormativaFacturar(ByVal ID_TIPO_SOLICITUD As Decimal, ByVal ID_PROVEEDOR_AF As Decimal) As Integer
        Me.odsListaPorAccionFormativaFacturar.SelectParameters("ID_TIPO_SOLICITUD").DefaultValue = ID_TIPO_SOLICITUD.ToString()
        Me.odsListaPorAccionFormativaFacturar.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString()
        Me.odsListaPorAccionFormativaFacturar.SelectParameters("asColumnaOrden").DefaultValue = "CODIGO_GRUPO"
        Me.odsListaPorAccionFormativaFacturar.SelectParameters("asTipoOrden").DefaultValue = "ASC"
        Me.odsListaPorAccionFormativaFacturar.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorAccionFormativaFacturar"
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Sub CargarDatosPorAccionFormativaFacturarCallback(ByVal opcion As String, ByVal parametros() As String)
        If opcion = "BuscarDatos" Then
            Me.dxgvLista.Selection.UnselectAll()
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
            If hf("BuscarDatos") = "CargarDatosPorAccionFormativaFacturar" Then Me.CargarDatosPorAccionFormativaFacturar(CDec(hf("param1")), CDec(hf("param2")))
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' filtrado por Oferta Formativa del ID_ACCION_FORMATIVA que se recibe de parametro
    ''' y que este en estado En Matricula
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	17/03/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorAccionFormativaEnMatricula(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer

        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(ID_ACCION_FORMATIVA)

        'Obtener Accion Formativa de la misma Oferta Formativa que este En Matricula
        Dim listaAccionFormativa As listaACCION_FORMATIVA
        Dim criterios As New List(Of Criteria)
        criterios.Add(New Criteria("ID_OFERTA_FORMATIVA", "=", lAccionFormativa.ID_OFERTA_FORMATIVA, "AND"))
        criterios.Add(New Criteria("CODIGO_ESTADO_AF", "=", Enumeradores.EstadoAccionFormativa.EnMatricula, "AND"))

        Me.dxgvLista.DataSourceID = Nothing
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True

        listaAccionFormativa = (New cACCION_FORMATIVA).ObtenerListaPorBusqueda(New ACCION_FORMATIVA, criterios.ToArray())
        If listaAccionFormativa Is Nothing OrElse listaAccionFormativa.Count = 0 Then
            If listaAccionFormativa Is Nothing Then listaAccionFormativa = New listaACCION_FORMATIVA
            listaAccionFormativa.Add(lAccionFormativa)
        End If

        Me.ViewState("PorAccionFormativaEnMatricula") = True
        Me.ViewState("ID_ACCION_FORMATIVA") = ID_ACCION_FORMATIVA

        Me.PermitirPaginacion = False
        Me.dxgvLista.Settings.ShowFilterRow = False
        Me.dxgvLista.DataSource = listaAccionFormativa
        Me.dxgvLista.DataBind()

        Me.dxgvLista.Selection.SelectRow(Me.dxgvLista.FindVisibleIndexByKeyValue(ID_ACCION_FORMATIVA))
        Return 1
    End Function

    Public ReadOnly Property ObtenerNumeroFilasSeleccionadas() As Integer
        Get
            Return dxgvLista.GetSelectedFieldValues("ID_ACCION_FORMATIVA").Count
        End Get
    End Property

    Public ReadOnly Property ObtenerIdAccionFormativaSeleccionados() As List(Of Object)
        Get
            Return dxgvLista.GetSelectedFieldValues("ID_ACCION_FORMATIVA")
        End Get
    End Property

    Protected Sub dxgvLista_RowUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs) Handles dxgvLista.RowUpdating
        If e.OldValues("CODIGO_ESTADO_AF") = Enumeradores.EstadoAccionFormativa.EnMatricula Then
            e.NewValues("CODIGO_ESTADO_AF") = Enumeradores.EstadoAccionFormativa.Iniciada
        End If
    End Sub

    Protected Sub dxgvLista_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatedEventArgs) Handles dxgvLista.RowUpdated
        If Not e.Exception Is Nothing Then
            Me.dxgvLista.JSProperties("cpMensaje") = e.Exception.Message
            Me.AsignarMensaje(e.Exception.Message, False, True)
        End If
        Me.dxgvLista.DataBind()
    End Sub

    Protected Sub odsPorCriteriosPeriodoEstadosTecnico_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles odsPorCriteriosPeriodoEstadosTecnico.Selecting
        e.InputParameters("CODIGO_ESTADO_AF") = Me.listaCODIGO_ESTADO_AF
    End Sub

    Protected Sub odsListaPorCriteriosRoles_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles odsListaPorCriteriosRoles.Selecting
        'If e.InputParameters.Contains("listaROLES") Then e.InputParameters("listaROLES") = listaROLES
        'If e.InputParameters.Contains("listaCODIGO_ESTADO_AF") Then e.InputParameters("listaCODIGO_ESTADO_AF") = listaCODIGO_ESTADO_AF
    End Sub

End Class