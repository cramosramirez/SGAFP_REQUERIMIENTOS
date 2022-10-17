Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaACCION_PROGRA_RETRO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla ACCION_PROGRA_RETRO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/09/2016	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaACCION_PROGRA_RETRO
    Inherits ucListaBase

    Private mComponente As New cACCION_PROGRA_RETRO
    Public Event Seleccionado(ByVal ID_ACCION_PROGRA_RETRO As Decimal)
    Public Event Editando(ByVal ID_ACCION_PROGRA_RETRO As Decimal)

#Region "Propiedades"

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

    Public Property VerID_ACCION_PROGRA_RETRO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ACCION_PROGRA_RETRO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ACCION_PROGRA_RETRO").Visible = Value
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

    Public Property VerID_EJERCICIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_EJERCICIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_EJERCICIO").Visible = Value
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

    Public Property VerFECHA_EXPIRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_EXPIRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_EXPIRA").Visible = Value
        End Set
    End Property

    Public Property VerMOTIVO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MOTIVO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MOTIVO").Visible = Value
        End Set
    End Property

    Public Property VerACTIVO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ACTIVO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ACTIVO").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_CREACION").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CREACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_CREACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_CREACION").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_PROGRAMO() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_PROGRAMO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_PROGRAMO").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_PROGRAMO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_PROGRAMO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_PROGRAMO").Visible = Value
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

    Public Property HeaderID_ACCION_PROGRA_RETRO() As String
        Get
            Return Me.dxgvLista.Columns("ID_ACCION_PROGRA_RETRO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ACCION_PROGRA_RETRO").Caption = Value
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

    Public Property HeaderID_EJERCICIO() As String
        Get
            Return Me.dxgvLista.Columns("ID_EJERCICIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_EJERCICIO").Caption = Value
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

    Public Property HeaderFECHA_EXPIRA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_EXPIRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_EXPIRA").Caption = Value
        End Set
    End Property

    Public Property HeaderMOTIVO() As String
        Get
            Return Me.dxgvLista.Columns("MOTIVO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MOTIVO").Caption = Value
        End Set
    End Property

    Public Property HeaderACTIVO() As String
        Get
            Return Me.dxgvLista.Columns("ACTIVO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ACTIVO").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREACION() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_CREACION").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_CREACION() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_CREACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_CREACION").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_PROGRAMO() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_PROGRAMO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_PROGRAMO").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_PROGRAMO() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_PROGRAMO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_PROGRAMO").Caption = Value
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
    ''' Función que Carga la información de los registros de la tabla ACCION_PROGRA_RETRO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/09/2016	Created
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
    ''' Función que Carga la información de los registros de la tabla ACCION_PROGRA_RETRO
    ''' filtrado por la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/09/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                            ByVal ID_EJERCICIO As String, _
                                            ByVal CODIGO_GRUPO As String, _
                                            ByVal CODIGO_ESTADO_AF_PROP As String, _
                                            ByVal ACTIVO As Decimal) As Integer
        Me.odsCriterios.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString()
        Me.odsCriterios.SelectParameters("ID_EJERCICIO").DefaultValue = ID_EJERCICIO
        Me.odsCriterios.SelectParameters("CODIGO_GRUPO").DefaultValue = CODIGO_GRUPO
        Me.odsCriterios.SelectParameters("CODIGO_ESTADO_AF_PROP").DefaultValue = CODIGO_ESTADO_AF_PROP
        Me.odsCriterios.SelectParameters("ACTIVO").DefaultValue = ACTIVO.ToString
        Me.odsCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsCriterios"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function


    Public Function CargarDatosPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal) As Integer
        Me.odsListaPorPROVEEDOR_AF.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString()
        Me.odsListaPorPROVEEDOR_AF.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorPROVEEDOR_AF.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR_AF.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorPROVEEDOR_AF.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorPROVEEDOR_AF"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_PROGRA_RETRO
    ''' filtrado por la tabla EJERCICIO
    ''' </summary>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/09/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorEJERCICIO(ByVal ID_EJERCICIO As String) As Integer
        Me.odsListaPorEJERCICIO.SelectParameters("ID_EJERCICIO").DefaultValue = ID_EJERCICIO.ToString()
        Me.odsListaPorEJERCICIO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorEJERCICIO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorEJERCICIO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorEJERCICIO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorEJERCICIO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_PROGRA_RETRO
    ''' filtrado por la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/09/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Me.odsListaPorACCION_FORMATIVA.SelectParameters("ID_ACCION_FORMATIVA").DefaultValue = ID_ACCION_FORMATIVA.ToString()
        Me.odsListaPorACCION_FORMATIVA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorACCION_FORMATIVA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorACCION_FORMATIVA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorACCION_FORMATIVA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorACCION_FORMATIVA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub


    Protected Sub dxgvLista_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewClientJSPropertiesEventArgs) Handles dxgvLista.CustomJSProperties
        If Me.PermitirSeleccionParaCombo Then
            Dim grid As DevExpress.Web.ASPxGridView.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView.ASPxGridView)
            Dim keyNames(grid.VisibleRowCount - 1) As Object
            Dim keyValues(grid.VisibleRowCount - 1) As Object
            For i As Integer = 0 To grid.VisibleRowCount - 1
                keyValues(i) = grid.GetRowValues(i, "ID_ACCION_PROGRA_RETRO")
                keyNames(i) = grid.GetRowValues(i, "ID_PROVEEDOR_AF")
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
        End If
        If Me.PermitirEditarInline Or Me.PermitirAgregarInline Or Me.PermitirEliminarInline Then
            Me.dxgvLista.Columns("Edicion").Visible = True
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).EditButton.Visible = Me.PermitirEditarInline
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).DeleteButton.Visible = Me.PermitirEliminarInline
        End If
        If Me.NombreComboCliente = "" Then
            Me.dxgvLista.ClientSideEvents.RowClick = ""
        End If
    End Sub

    Protected Sub dxgvLista_RowCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewRowCommandEventArgs) Handles dxgvLista.RowCommand
        If e.CommandArgs.CommandName = "Select" And ComandoSeleccionar <> "Check" Then
            Me.dxgvLista.Selection.UnselectAll()
            Me.dxgvLista.Selection.SelectRow(e.VisibleIndex)
            RaiseEvent Seleccionado(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(e.KeyValue)
        End If
    End Sub

    Protected Sub dxgvLista_HtmlRowCreated(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewTableRowEventArgs) Handles dxgvLista.HtmlRowCreated
        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.EditForm Then
            'Dim btnGuardar As DevExpress.Web.ASPxEditors.ASPxButton
            'Dim btnCancelar As DevExpress.Web.ASPxEditors.ASPxButton
            'btnGuardar = Me.dxgvLista.FindEditFormTemplateControl("btnGuardar")
            'btnCancelar = Me.dxgvLista.FindEditFormTemplateControl("btnCancelar")
            'btnGuardar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            'btnCancelar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        End If
        If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.EmptyDataRow Then
            'Dim btnAgregar As DevExpress.Web.ASPxEditors.ASPxButton
            'btnAgregar = Me.dxgvLista.FindEmptyDataRowTemplateControl("btnAgregar")
            'btnAgregar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
            'btnAgregar.Visible = Me.PermitirAgregarInline
            'Dim lblEmptyDataRow As DevExpress.Web.ASPxEditors.ASPxLabel
            'lblEmptyDataRow = Me.dxgvLista.FindEmptyDataRowTemplateControl("lblEmptyDataRow")
            'lblEmptyDataRow.Text = Me.dxgvLista.SettingsText.EmptyDataRow
        End If
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

    Public Function DevolverSeleccionados() As listaACCION_PROGRA_RETRO
        Dim mLista As New listaACCION_PROGRA_RETRO
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_ACCION_PROGRA_RETRO")
            Dim lEntidad As New ACCION_PROGRA_RETRO
            lEntidad.ID_ACCION_PROGRA_RETRO = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As ACCION_PROGRA_RETRO = CType(Me.dxgvLista.GetRow(e.VisibleIndex), ACCION_PROGRA_RETRO)

            If Me.mComponente.EliminarACCION_PROGRA_RETRO(lEntidad.ID_ACCION_PROGRA_RETRO) <> 1 Then
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

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "ES_ACTIVO" Then
            If e.GetListSourceFieldValue("ACTIVO") = 1 Then
                e.Value = True
            Else
                e.Value = False
            End If
        ElseIf e.Column.FieldName = "NOMBRE_PROVEEDOR" Then
            Dim lEntidad As PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(e.GetListSourceFieldValue("ID_PROVEEDOR_AF"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE_PROVEEDOR
            End If
        ElseIf e.Column.FieldName = "NOMBRE_USUARIO_AUTORIZO" Then
            Dim lEntidad As USUARIO = (New cUSUARIO).ObtenerUSUARIO(e.GetListSourceFieldValue("USUARIO_CREACION"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE
            End If
        ElseIf e.Column.FieldName = "NOMBRE_USUARIO_PROGRAMO" Then
            Dim lEntidad As USUARIO = (New cUSUARIO).ObtenerUSUARIO(e.GetListSourceFieldValue("USUARIO_PROGRAMO"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE
            End If
        ElseIf e.Column.FieldName = "NOMBRE_ESTADO_INFORME" Then
            If e.GetListSourceFieldValue("CODIGO_ESTADO_AF_PROP") = Enumeradores.AutorizacionExcepcion.ProgramacionRetroactiva Then
                e.Value = "PROGRAMACION RETROACTIVA"
            ElseIf e.GetListSourceFieldValue("CODIGO_ESTADO_AF_PROP") = Enumeradores.AutorizacionExcepcion.FinalizacionExtemporaneaCurso Then
                e.Value = "FINALIZACION DE CURSO"
            ElseIf e.GetListSourceFieldValue("CODIGO_ESTADO_AF_PROP") = Enumeradores.AutorizacionExcepcion.InscripcionExtemporaneaParticipantes Then
                e.Value = "INSCRIPCION EXTEMPORANEA DE PARTICIPANTES"
            ElseIf e.GetListSourceFieldValue("CODIGO_ESTADO_AF_PROP") = Enumeradores.AutorizacionExcepcion.HorarioSimultaneoInstructor Then
                e.Value = "HORARIO SIMULTANEO IMPARTIDO POR INSTRUCTOR"
            ElseIf e.GetListSourceFieldValue("CODIGO_ESTADO_AF_PROP") = Enumeradores.AutorizacionExcepcion.HorarioSimultaneoParticipante Then
                e.Value = "HORARIO SIMULTANEO CURSO RECIBIDO POR PARTICIPANTE"
            ElseIf e.GetListSourceFieldValue("CODIGO_ESTADO_AF_PROP") = Enumeradores.AutorizacionExcepcion.AplicarMontoLiquidacionContrato Then
                e.Value = "LIQUIDACION DE MONTO DE CONTRATO CON ESTE CURSO"
            ElseIf e.GetListSourceFieldValue("CODIGO_ESTADO_AF_PROP") = Enumeradores.AutorizacionExcepcion.InicioCursoPosteriorUltimaFechaInicioOferta Then
                e.Value = "INICIAR CURSO POSTERIOR A LA ULTIMA FECHA INICIO EN OFERTA"
            ElseIf e.GetListSourceFieldValue("CODIGO_ESTADO_AF_PROP") = Enumeradores.AutorizacionExcepcion.EliminarAccionFormativa Then
                e.Value = "ELIMINACION DE ACCION FORMATIVA"
            End If
        ElseIf e.Column.FieldName = "FECHA_PROGRAMACION" Then
            If e.GetListSourceFieldValue("FECHA_PROGRAMO") <> #12:00:00 AM# Then
                e.Value = CDate(e.GetListSourceFieldValue("FECHA_PROGRAMO")).ToString("dd/MM/yyyy HH:mm")
            End If
        End If
    End Sub
End Class
