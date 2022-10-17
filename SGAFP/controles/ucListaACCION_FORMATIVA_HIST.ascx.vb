Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaACCION_FORMATIVA_HIST
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla ACCION_FORMATIVA_HIST
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	18/08/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaACCION_FORMATIVA_HIST
    Inherits ucListaBase
 
    Private mComponente As New cACCION_FORMATIVA_HIST
    Public Event Seleccionado(ByVal ID_ACCION_FORMATIVA_HIST As Decimal) 
    Public Event Editando(ByVal ID_ACCION_FORMATIVA_HIST As Decimal) 

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

    Public Property VerID_ACCION_FORMATIVA_HIST() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ACCION_FORMATIVA_HIST").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ACCION_FORMATIVA_HIST").Visible = Value
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

    Public Property VerOBSERVACIONES() As Boolean
        Get
            Return Me.dxgvLista.Columns("OBSERVACIONES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OBSERVACIONES").Visible = Value
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

    Public Property HeaderID_ACCION_FORMATIVA_HIST() As String
        Get
            Return Me.dxgvLista.Columns("ID_ACCION_FORMATIVA_HIST").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ACCION_FORMATIVA_HIST").Caption = Value
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

#End Region
  
    Private Sub InicializarVarCallback()
        Me.hfucListaACCION_FORMATIVA_HIST.Add("IdAccionFormativa", -1)
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")

        If Not IsPostBack Then InicializarVarCallback()
        If Me.hfucListaACCION_FORMATIVA_HIST.Contains("IdAccionFormativa") AndAlso Me.hfucListaACCION_FORMATIVA_HIST("IdAccionFormativa") <> -1 Then
            Me.CargarDatosPorID_ACCION_FORMATIVA(Me.hfucListaACCION_FORMATIVA_HIST("IdAccionFormativa"))
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        Select Case e.Column.FieldName
            Case "USUARIO"
                If Me.dxgvLista.Columns("USUARIO").Visible Then
                    Dim eUSUARIO As USUARIO
                    eUSUARIO = (New cUSUARIO).ObtenerUSUARIO(e.GetListSourceFieldValue("USERID").ToString)
                    If eUSUARIO IsNot Nothing Then e.Value = eUSUARIO.NOMBRE
                End If

            Case "NOMBRE_ESTADO"
                If Me.dxgvLista.Columns("NOMBRE_ESTADO").Visible Then
                    Dim eESTADO_AF As ESTADO_ACCION_FORMATIVA
                    eESTADO_AF = (New cESTADO_ACCION_FORMATIVA).ObtenerESTADO_ACCION_FORMATIVA(e.GetListSourceFieldValue("CODIGO_ESTADO_AF").ToString)
                    If eESTADO_AF IsNot Nothing Then e.Value = eESTADO_AF.NOMBRE_ESTADO_AF
                End If
        End Select
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
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.CommandArgs.CommandArgument)
        End If
    End Sub

    Protected Sub dxgvLista_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowCreated

        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Data Then
            If Not Me.PermitirEditar Then
                Dim lbDetalle As LinkButton
                lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
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

    Public Function DevolverSeleccionados() As listaACCION_FORMATIVA_HIST
        Dim mLista As New listaACCION_FORMATIVA_HIST
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_ACCION_FORMATIVA_HIST")
            Dim lEntidad As New ACCION_FORMATIVA_HIST
            lEntidad.ID_ACCION_FORMATIVA_HIST = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As ACCION_FORMATIVA_HIST = CType(Me.dxgvLista.GetRow(e.VisibleIndex), ACCION_FORMATIVA_HIST)

            If Me.mComponente.EliminarACCION_FORMATIVA_HIST(lEntidad.ID_ACCION_FORMATIVA_HIST) <> 1 Then
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
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA_HIST
    ''' filtrado por ID_ACCION_FORMATIVA
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorID_ACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Me.odsPorCriterioAccionFormativa.SelectParameters("ID_ACCION_FORMATIVA").DefaultValue = ID_ACCION_FORMATIVA.ToString()
        Me.odsPorCriterioAccionFormativa.DataBind()
        Me.dxgvLista.DataSourceID = "odsPorCriterioAccionFormativa"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

End Class
