Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaACCION_CONTRATADA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla ACCION_CONTRATADA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/03/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaACCION_CONTRATADA
    Inherits ucListaBase
 
    Private mComponente As New cACCION_CONTRATADA
    Public Event Seleccionado(ByVal ID_ACCION_CONTRATADA As Decimal) 
    Public Event Editando(ByVal ID_ACCION_CONTRATADA As Decimal)
    Public Event HabilitarGrupo(ByVal ID_ACCION_CONTRATADA As Decimal)

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

    Public Property VerID_ACCION_CONTRATADA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ACCION_CONTRATADA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ACCION_CONTRATADA").Visible = Value
        End Set
    End Property

    Public Property VerID_CONTRATO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_CONTRATO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_CONTRATO").Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_DEPARTAMENTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIGO_DEPARTAMENTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIGO_DEPARTAMENTO").Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_MUNICIPIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIGO_MUNICIPIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIGO_MUNICIPIO").Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_PROGRAMA() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIGO_PROGRAMA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIGO_PROGRAMA").Visible = Value
        End Set
    End Property

    Public Property VerDURACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("DURACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("DURACION").Visible = Value
        End Set
    End Property

    Public Property VerCANT_CURSOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("CANT_CURSOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CANT_CURSOS").Visible = Value
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

    Public Property VerNUM_ITEM() As Boolean
        Get
            Return Me.dxgvLista.Columns("NUM_ITEM").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NUM_ITEM").Visible = Value
        End Set
    End Property

    Public Property VerMONTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MONTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MONTO").Visible = Value
        End Set
    End Property

    Public Property VerNO_CONVOCATORIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_CONVOCATORIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_CONVOCATORIA").Visible = Value
        End Set
    End Property

    Public Property VerCOSTO_PARTICIPANTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("COSTO_PARTICIPANTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("COSTO_PARTICIPANTE").Visible = Value
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

    Public Property HeaderID_ACCION_CONTRATADA() As String
        Get
            Return Me.dxgvLista.Columns("ID_ACCION_CONTRATADA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ACCION_CONTRATADA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_CONTRATO() As String
        Get
            Return Me.dxgvLista.Columns("ID_CONTRATO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_CONTRATO").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIGO_DEPARTAMENTO() As String
        Get
            Return Me.dxgvLista.Columns("CODIGO_DEPARTAMENTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIGO_DEPARTAMENTO").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIGO_MUNICIPIO() As String
        Get
            Return Me.dxgvLista.Columns("CODIGO_MUNICIPIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIGO_MUNICIPIO").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIGO_PROGRAMA() As String
        Get
            Return Me.dxgvLista.Columns("CODIGO_PROGRAMA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIGO_PROGRAMA").Caption = Value
        End Set
    End Property

    Public Property HeaderDURACION() As String
        Get
            Return Me.dxgvLista.Columns("DURACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("DURACION").Caption = Value
        End Set
    End Property

    Public Property HeaderCANT_CURSOS() As String
        Get
            Return Me.dxgvLista.Columns("CANT_CURSOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CANT_CURSOS").Caption = Value
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

    Public Property HeaderNUM_ITEM() As String
        Get
            Return Me.dxgvLista.Columns("NUM_ITEM").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NUM_ITEM").Caption = Value
        End Set
    End Property

    Public Property HeaderMONTO() As String
        Get
            Return Me.dxgvLista.Columns("MONTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MONTO").Caption = Value
        End Set
    End Property

    Public Property HeaderNO_CONVOCATORIA() As String
        Get
            Return Me.dxgvLista.Columns("NO_CONVOCATORIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_CONVOCATORIA").Caption = Value
        End Set
    End Property

    Public Property HeaderCOSTO_PARTICIPANTE() As String
        Get
            Return Me.dxgvLista.Columns("COSTO_PARTICIPANTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("COSTO_PARTICIPANTE").Caption = Value
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

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_CONTRATADA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/03/2019	Created
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

    Public Function CargarDatosPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                            ByVal ID_PROGRAMA_FORMACION As Decimal, _
                                            ByVal NUM_CONTRATO As String, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As Integer
        Me.odsCriterios.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString
        Me.odsCriterios.SelectParameters("ID_PROGRAMA_FORMACION").DefaultValue = ID_PROGRAMA_FORMACION.ToString
        Me.odsCriterios.SelectParameters("NUM_CONTRATO").DefaultValue = NUM_CONTRATO
        Me.odsCriterios.SelectParameters("asColumnaOrden").DefaultValue = asColumnaOrden
        Me.odsCriterios.SelectParameters("asTipoOrden").DefaultValue = asTipoOrden
        Me.odsCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsCriterios"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_CONTRATADA
    ''' filtrado por la tabla CONTRATO_BOLPROS
    ''' </summary>
    ''' <param name="ID_CONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/03/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCONTRATO_BOLPROS(ByVal ID_CONTRATO As Decimal) As Integer
        Me.odsListaPorCONTRATO_BOLPROS.SelectParameters("ID_CONTRATO").DefaultValue = ID_CONTRATO.ToString()
        Me.odsListaPorCONTRATO_BOLPROS.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorCONTRATO_BOLPROS.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorCONTRATO_BOLPROS.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCONTRATO_BOLPROS.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCONTRATO_BOLPROS.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCONTRATO_BOLPROS"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_CONTRATADA
    ''' filtrado por la tabla DEPARTAMENTO
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/03/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String) As Integer
        Me.odsListaPorDEPARTAMENTO.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = CODIGO_DEPARTAMENTO.ToString()
        Me.odsListaPorDEPARTAMENTO.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorDEPARTAMENTO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorDEPARTAMENTO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorDEPARTAMENTO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorDEPARTAMENTO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorDEPARTAMENTO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_CONTRATADA
    ''' filtrado por la tabla MUNICIPIO
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/03/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As Integer
        Me.odsListaPorMUNICIPIO.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = CODIGO_DEPARTAMENTO.ToString()
        Me.odsListaPorMUNICIPIO.SelectParameters("CODIGO_MUNICIPIO").DefaultValue = CODIGO_MUNICIPIO.ToString()
        Me.odsListaPorMUNICIPIO.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorMUNICIPIO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorMUNICIPIO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorMUNICIPIO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorMUNICIPIO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorMUNICIPIO"
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
                keyValues(i) = grid.GetRowValues(i, "ID_ACCION_CONTRATADA")
                keyNames(i) = grid.GetRowValues(i, "ID_CONTRATO")
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
        'If Me.PermitirEditarInline Or Me.PermitirAgregarInline Or Me.PermitirEliminarInline Then
        '    Me.dxgvLista.Columns("Edicion").Visible = True
        '    CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).ShowNewButton = Me.PermitirAgregarInline
        '    CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).ShowEditButton = Me.PermitirEditarInline
        '    CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).ShowDeleteButton = Me.PermitirEliminarInline
        'End If
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
        If e.CommandArgs.CommandName = "HabilitarGrupo" Then
            RaiseEvent HabilitarGrupo(e.KeyValue)
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaACCION_CONTRATADA
        Dim mLista As New listaACCION_CONTRATADA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_ACCION_CONTRATADA")
            Dim lEntidad As New ACCION_CONTRATADA
            lEntidad.ID_ACCION_CONTRATADA = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As ACCION_CONTRATADA = CType(Me.dxgvLista.GetRow(e.VisibleIndex), ACCION_CONTRATADA)

            If Me.mComponente.EliminarACCION_CONTRATADA(lEntidad.ID_ACCION_CONTRATADA) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "NUM_CONTRATO" Then
            Dim lEntidad As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(e.GetListSourceFieldValue("ID_CONTRATO"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NUM_CONTRATO
            End If
        ElseIf e.Column.FieldName = "CURSO" Then
            Dim lEntidad As SIFP.EL.Programas = (New SIFP.BL.cProgramas).ObtenerProgramas(e.GetListSourceFieldValue("CODIGO_PROGRAMA"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.nombre_programa
            End If
        ElseIf e.Column.FieldName = "DEPARTAMENTO" Then
            Dim lEntidad As DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(e.GetListSourceFieldValue("CODIGO_DEPARTAMENTO"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE
            End If
        ElseIf e.Column.FieldName = "MUNICIPIO" Then
            Dim lEntidad As MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(e.GetListSourceFieldValue("CODIGO_DEPARTAMENTO"), e.GetListSourceFieldValue("CODIGO_MUNICIPIO"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE
            End If
        ElseIf e.Column.FieldName = "NOMBRE_PROVEEDOR" Then
            Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(e.GetListSourceFieldValue("ID_CONTRATO"))
            If lContrato IsNot Nothing Then
                Dim lEntidad As PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lContrato.ID_PROVEEDOR_AF)
                If lEntidad IsNot Nothing Then
                    e.Value = lEntidad.NOMBRE_PROVEEDOR
                End If
            End If
        ElseIf e.Column.FieldName = "NO_CONTRATO_COMPRA" Then
            Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(e.GetListSourceFieldValue("ID_CONTRATO"))
            If lContrato IsNot Nothing Then
                Dim lEntidad As CONTRATO_COMPRA = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRA(lContrato.ID_CONTRATO_COMPRA)
                If lEntidad IsNot Nothing Then
                    e.Value = lEntidad.NO_CONTRATO_COMPRA
                End If
            End If
        ElseIf e.Column.FieldName = "CANT_GRUPOS_GENERADOS" Then
            Dim listaG As listaGRUPO_SELECCION = (New cGRUPO_SELECCION).ObtenerListaPorACCION_CONTRATADA(e.GetListSourceFieldValue("ID_ACCION_CONTRATADA"))

            If listaG IsNot Nothing Then
                e.Value = listaG.Count
            Else
                e.Value = 0
            End If
        ElseIf e.Column.FieldName = "PERIODO_EJECUCION" Then
            Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(e.GetListSourceFieldValue("ID_CONTRATO"))
            If lContrato IsNot Nothing Then
                e.Value = lContrato.FECHA_INI_EJEC.ToString("dd/MM/yyyy") + " AL " + lContrato.FECHA_FIN_EJEC.ToString("dd/MM/yyyy")
            End If
        End If
    End Sub
End Class
