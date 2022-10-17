Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaDESEMBOLSO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla DESEMBOLSO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/04/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaDESEMBOLSO
    Inherits ucListaBase
 
    Private mComponente As New cDESEMBOLSO
    Public Event Seleccionado(ByVal ID_DESEMBOLSO As Decimal) 
    Public Event Editando(ByVal ID_DESEMBOLSO As Decimal) 

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

    Public Property VerID_DESEMBOLSO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_DESEMBOLSO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_DESEMBOLSO").Visible = Value
        End Set
    End Property

    Public Property VerID_FUENTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_FUENTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_FUENTE").Visible = Value
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

    Public Property VerNUM_DESEMBOLSO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NUM_DESEMBOLSO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NUM_DESEMBOLSO").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_DESEMBOLSO() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_DESEMBOLSO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_DESEMBOLSO").Visible = Value
        End Set
    End Property

    Public Property VerMONTO_AUTORIZADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MONTO_AUTORIZADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MONTO_AUTORIZADO").Visible = Value
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

    Public Property HeaderID_DESEMBOLSO() As String
        Get
            Return Me.dxgvLista.Columns("ID_DESEMBOLSO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_DESEMBOLSO").Caption = Value
        End Set
    End Property

    Public Property HeaderID_FUENTE() As String
        Get
            Return Me.dxgvLista.Columns("ID_FUENTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_FUENTE").Caption = Value
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

    Public Property HeaderNUM_DESEMBOLSO() As String
        Get
            Return Me.dxgvLista.Columns("NUM_DESEMBOLSO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NUM_DESEMBOLSO").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_DESEMBOLSO() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_DESEMBOLSO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_DESEMBOLSO").Caption = Value
        End Set
    End Property

    Public Property HeaderMONTO_AUTORIZADO() As String
        Get
            Return Me.dxgvLista.Columns("MONTO_AUTORIZADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MONTO_AUTORIZADO").Caption = Value
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
    ''' Función que Carga la información de los registros de la tabla DESEMBOLSO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("recuperarForaneas").DefaultValue = False
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
    ''' Función que Carga la información de los registros de la tabla DESEMBOLSO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal) As Integer
        Me.odsLista.SelectParameters("ID_FUENTE").DefaultValue = ID_FUENTE
        Me.odsLista.SelectParameters("NO_CONVOCATORIA").DefaultValue = NO_CONVOCATORIA
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
    ''' Función que Carga la información de los registros de la tabla DESEMBOLSO
    ''' filtrado por la tabla FUENTE_FINANCIAMIENTO
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorFUENTE_FINANCIAMIENTO(ByVal ID_FUENTE As Decimal) As Integer
        Me.odsListaPorFUENTE_FINANCIAMIENTO.SelectParameters("ID_FUENTE").DefaultValue = ID_FUENTE.ToString()
        Me.odsListaPorFUENTE_FINANCIAMIENTO.SelectParameters("recuperarHijas").DefaultValue = "False"
        Me.odsListaPorFUENTE_FINANCIAMIENTO.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorFUENTE_FINANCIAMIENTO.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorFUENTE_FINANCIAMIENTO.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorFUENTE_FINANCIAMIENTO.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorFUENTE_FINANCIAMIENTO"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Actualización de Datos Cargados vía Callback
        'ActualizarCargarDatosPorFUENTE_FINANCIAMIENTO_NO_CONVOCATORIACallback()

        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
    End Sub


    Protected Sub dxgvLista_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewClientJSPropertiesEventArgs) Handles dxgvLista.CustomJSProperties
        'If Me.PermitirSeleccionParaCombo Then
        Dim grid As DevExpress.Web.ASPxGridView.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView.ASPxGridView)
        Dim keyNames(grid.VisibleRowCount - 1) As Object
        Dim keyValues(grid.VisibleRowCount - 1) As Object
        For i As Integer = 0 To grid.VisibleRowCount - 1
            keyValues(i) = grid.GetRowValues(i, "ID_DESEMBOLSO")
            keyNames(i) = grid.GetRowValues(i, "ID_FUENTE")
        Next i
        e.Properties("cpKeyValues") = keyValues
        e.Properties("cpKeyNames") = keyNames
        e.Properties("cpNombreComboCliente") = Me.NombreComboCliente
        'End If
    End Sub

    Protected Sub dxgvLista_Init(ByVal sender As Object, ByVal e As System.EventArgs) Handles dxgvLista.Init
        If Me.PermitirSeleccionar And Me.ComandoSeleccionar = "Check" Then
            Me.dxgvLista.Columns("Seleccionar").Visible = True
            CType(Me.dxgvLista.Columns("Seleccionar"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).ShowSelectCheckbox = True
        End If
        If Me.PermitirAgregarInline Then
            Me.dxgvLista.Columns("Adicion").Visible = True
            CType(Me.dxgvLista.Columns("Adicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregarInline
        End If
        If Me.PermitirEditarInline Then
            Me.dxgvLista.Columns("Edicion").Visible = True
            CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).EditButton.Visible = Me.PermitirEditarInline
        End If
        If Me.PermitirEliminarInline Then
            Me.dxgvLista.Columns("Eliminacion").Visible = True
            CType(Me.dxgvLista.Columns("Eliminacion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).DeleteButton.Visible = Me.PermitirEliminarInline
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

    Public Function DevolverSeleccionados() As listaDESEMBOLSO
        Dim mLista As New listaDESEMBOLSO
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_DESEMBOLSO")
            Dim lEntidad As New DESEMBOLSO
            lEntidad.ID_DESEMBOLSO = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As DESEMBOLSO = CType(Me.dxgvLista.GetRow(e.VisibleIndex), DESEMBOLSO)

            If Me.mComponente.EliminarDESEMBOLSO(lEntidad.ID_DESEMBOLSO) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            e.Text = "<img src='../imagenes/eliminar.png' style='border-style:none;border-width:0px;height:16px;width:16px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "FUENTE" AndAlso Me.dxgvLista.Columns("FUENTE").Visible Then
            e.Value = (New cFUENTE_FINANCIAMIENTO).ObtenerFUENTE_FINANCIAMIENTO(CDec(e.GetListSourceFieldValue("ID_FUENTE"))).NOMBRE_FUENTE
        End If
        'If e.Column.FieldName = "MONTO_APLICADO" Then
        '    Dim bDesembolsoMuni As New cDESEMBOLSO_MUNI_LIQUI_DET
        '    Dim listaDesembolsoMuni As listaDESEMBOLSO_MUNI_LIQUI_DET
        '    listaDesembolsoMuni = bDesembolsoMuni.ObtenerListaPorDESEMBOLSO(dxgvLista.GetRowValues(e.ListSourceRowIndex, "ID_DESEMBOLSO"))
        '    If listaDesembolsoMuni IsNot Nothing Then
        '        Dim totalAplicado As Decimal = 0
        '        For i As Integer = 0 To listaDesembolsoMuni.Count - 1
        '            totalAplicado += listaDesembolsoMuni(i).MONTO_DESEMBOLSO
        '        Next
        '        e.Value = totalAplicado
        '    Else
        '        e.Value = 0
        '    End If
        'End If
        'If e.Column.FieldName = "MONTO_DIFERENCIA" Then
        '    Dim bDesembolsoMuni As New cDESEMBOLSO_MUNI_LIQUI_DET
        '    Dim listaDesembolsoMuni As listaDESEMBOLSO_MUNI_LIQUI_DET
        '    listaDesembolsoMuni = bDesembolsoMuni.ObtenerListaPorDESEMBOLSO(dxgvLista.GetRowValues(e.ListSourceRowIndex, "ID_DESEMBOLSO"))
        '    If listaDesembolsoMuni IsNot Nothing Then
        '        Dim totalAplicado As Decimal = 0
        '        For i As Integer = 0 To listaDesembolsoMuni.Count - 1
        '            totalAplicado += listaDesembolsoMuni(i).MONTO_DESEMBOLSO
        '        Next
        '        e.Value = CDec(dxgvLista.GetRowValues(e.ListSourceRowIndex, "MONTO_AUTORIZADO")) - totalAplicado
        '    Else
        '        e.Value = dxgvLista.GetRowValues(e.ListSourceRowIndex, "MONTO_AUTORIZADO")
        '    End If
        'End If
    End Sub

#Region " Métodos de Carga Adicional "
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla DESEMBOLSO
    ''' filtrado por FUENTE_FINANCIAMIENTO Y N° DE CONVOCATORIA
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorFUENTE_FINANCIAMIENTO_NO_CONVOCATORIA(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal) As Integer
        Me.odsListaPorFuenteConvocatoria.SelectParameters("ID_FUENTE").DefaultValue = ID_FUENTE.ToString()
        Me.odsListaPorFuenteConvocatoria.SelectParameters("NO_CONVOCATORIA").DefaultValue = NO_CONVOCATORIA.ToString()
        Me.odsListaPorFuenteConvocatoria.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorFuenteConvocatoria.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorFuenteConvocatoria.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorFuenteConvocatoria"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Sub CargarDatosPorFUENTE_FINANCIAMIENTO_NO_CONVOCATORIACallback(ByVal opcion As String, ByVal parametros() As String)
        If opcion = "BuscarDatos" Then
            Me.dxgvLista.Selection.UnselectAll()
            If hfdxgv.Contains("BuscarDatos") Then hfdxgv("BuscarDatos") = parametros(0) Else hfdxgv.Add("BuscarDatos", parametros(0))
            For i As Integer = 1 To parametros.Length - 1
                If hfdxgv.Contains("param" + (i).ToString) Then hfdxgv.Remove("param" + (i).ToString)
            Next
            For i As Integer = 1 To parametros.Length - 1
                hfdxgv.Add("param" + (i).ToString, parametros(i))
            Next
            Me.ActualizarCargarDatosPorFUENTE_FINANCIAMIENTO_NO_CONVOCATORIACallback()
        End If
    End Sub

    Public Sub ActualizarCargarDatosPorFUENTE_FINANCIAMIENTO_NO_CONVOCATORIACallback()
        If Me.hfdxgv.Contains("BuscarDatos") Then
            If hfdxgv("BuscarDatos") = "CargarDatosPorFuenteConvocatoria" Then Me.CargarDatosPorFUENTE_FINANCIAMIENTO_NO_CONVOCATORIA(hfdxgv("param1"), hfdxgv("param2"))
        End If
    End Sub
#End Region
End Class
