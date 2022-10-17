Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaFACILITADOR_CAPACITADOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla FACILITADOR_CAPACITADOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/03/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaFACILITADOR_CAPACITADOR
    Inherits ucListaBase
 
    Private mComponente As New cFACILITADOR_CAPACITADOR
    Public Event Seleccionado(ByVal ID_FACILITADOR As Decimal) 
    Public Event Editando(ByVal ID_FACILITADOR As Decimal) 

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

    Public Property VerID_FACILITADOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_FACILITADOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_FACILITADOR").Visible = Value
        End Set
    End Property

    Public Property VerID_TIPO_PERSONA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_PERSONA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_TIPO_PERSONA").Visible = Value
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

    Public Property VerCODIGO_MUNICIPIO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIGO_MUNICIPIO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIGO_MUNICIPIO").Visible = Value
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

    Public Property VerNOMBRE_FACILITADOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_FACILITADOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_FACILITADOR").Visible = Value
        End Set
    End Property

    Public Property VerNIT() As Boolean
        Get
            Return Me.dxgvLista.Columns("NIT").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NIT").Visible = Value
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

    Public Property VerISSS() As Boolean
        Get
            Return Me.dxgvLista.Columns("ISSS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ISSS").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_INGRESO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_INGRESO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_INGRESO").Visible = Value
        End Set
    End Property

    Public Property VerTELEFONO() As Boolean
        Get
            Return Me.dxgvLista.Columns("TELEFONO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("TELEFONO").Visible = Value
        End Set
    End Property

    Public Property VerEMAIL() As Boolean
        Get
            Return Me.dxgvLista.Columns("EMAIL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("EMAIL").Visible = Value
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

    Public Property VerNOTAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOTAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOTAS").Visible = Value
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

    Public Property HeaderID_FACILITADOR() As String
        Get
            Return Me.dxgvLista.Columns("ID_FACILITADOR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_FACILITADOR").Caption = Value
        End Set
    End Property

    Public Property HeaderID_TIPO_PERSONA() As String
        Get
            Return Me.dxgvLista.Columns("ID_TIPO_PERSONA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_TIPO_PERSONA").Caption = Value
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

    Public Property HeaderCODIGO_MUNICIPIO() As String
        Get
            Return Me.dxgvLista.Columns("CODIGO_MUNICIPIO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIGO_MUNICIPIO").Caption = Value
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

    Public Property HeaderNOMBRE_FACILITADOR() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRE_FACILITADOR").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRE_FACILITADOR").Caption = Value
        End Set
    End Property

    Public Property HeaderNIT() As String
        Get
            Return Me.dxgvLista.Columns("NIT").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NIT").Caption = Value
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

    Public Property HeaderISSS() As String
        Get
            Return Me.dxgvLista.Columns("ISSS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ISSS").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_INGRESO() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_INGRESO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_INGRESO").Caption = Value
        End Set
    End Property

    Public Property HeaderTELEFONO() As String
        Get
            Return Me.dxgvLista.Columns("TELEFONO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("TELEFONO").Caption = Value
        End Set
    End Property

    Public Property HeaderEMAIL() As String
        Get
            Return Me.dxgvLista.Columns("EMAIL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("EMAIL").Caption = Value
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

    Public Property HeaderNOTAS() As String
        Get
            Return Me.dxgvLista.Columns("NOTAS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOTAS").Caption = Value
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
    ''' Función que Carga la información de los registros de la tabla FACILITADOR_CAPACITADOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
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
    ''' Función que Carga la información de los registros de la tabla FACILITADOR_CAPACITADOR
    ''' filtrado por la tabla TIPO_PERSONA
    ''' </summary>
    ''' <param name="ID_TIPO_PERSONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTIPO_PERSONA(ByVal ID_TIPO_PERSONA As Decimal) As Integer
        Me.odsListaPorTIPO_PERSONA.SelectParameters("ID_TIPO_PERSONA").DefaultValue = ID_TIPO_PERSONA.ToString()
        Me.odsListaPorTIPO_PERSONA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorTIPO_PERSONA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTIPO_PERSONA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTIPO_PERSONA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTIPO_PERSONA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla FACILITADOR_CAPACITADOR
    ''' filtrado por la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
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
    ''' Función que Carga la información de los registros de la tabla FACILITADOR_CAPACITADOR
    ''' filtrado por la tabla MUNICIPIO
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As Integer
        Me.odsListaPorMUNICIPIO.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = CODIGO_DEPARTAMENTO.ToString()
        Me.odsListaPorMUNICIPIO.SelectParameters("CODIGO_MUNICIPIO").DefaultValue = CODIGO_MUNICIPIO.ToString()
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

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla FACILITADOR_CAPACITADOR
    ''' filtrado por la tabla DEPARTAMENTO
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String) As Integer
        Me.odsListaPorDEPARTAMENTO.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = CODIGO_DEPARTAMENTO.ToString()
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
                keyValues(i) = grid.GetRowValues(i, "ID_FACILITADOR")
                keyNames(i) = grid.GetRowValues(i, "ID_TIPO_PERSONA")
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

    Public Function DevolverSeleccionados() As listaFACILITADOR_CAPACITADOR
        Dim mLista As New listaFACILITADOR_CAPACITADOR
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_FACILITADOR")
            Dim lEntidad As New FACILITADOR_CAPACITADOR
            lEntidad.ID_FACILITADOR = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As FACILITADOR_CAPACITADOR = CType(Me.dxgvLista.GetRow(e.VisibleIndex), FACILITADOR_CAPACITADOR)

            If Me.mComponente.EliminarFACILITADOR_CAPACITADOR(lEntidad.ID_FACILITADOR) <> 1 Then
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

End Class
