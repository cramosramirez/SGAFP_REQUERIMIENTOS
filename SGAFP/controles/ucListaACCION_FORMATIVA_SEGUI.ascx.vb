Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaACCION_FORMATIVA_SEGUI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla ACCION_FORMATIVA_SEGUI
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/02/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaACCION_FORMATIVA_SEGUI
    Inherits ucListaBase
 
    Private mComponente As New cACCION_FORMATIVA_SEGUI
    Public Event Seleccionado(ByVal ID_ACCION_FORMATIVA_SEGUI As Decimal) 
    Public Event Editando(ByVal ID_ACCION_FORMATIVA_SEGUI As Decimal) 

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

    Public Property VerID_ACCION_FORMATIVA_SEGUI() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_ACCION_FORMATIVA_SEGUI").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_ACCION_FORMATIVA_SEGUI").Visible = Value
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

    Public Property VerFECHA_VISITA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_VISITA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_VISITA").Visible = Value
        End Set
    End Property

    Public Property VerOBSERVACION() As Boolean
        Get
            Return Me.dxgvLista.Columns("OBSERVACION").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("OBSERVACION").Visible = Value
        End Set
    End Property

    Public Property VerCOMENTARIO_ADMIN_PROGRA() As Boolean
        Get
            Return Me.dxgvLista.Columns("COMENTARIO_ADMIN_PROGRA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("COMENTARIO_ADMIN_PROGRA").Visible = Value
        End Set
    End Property

    Public Property VerID_UNIDAD_ORGANIZATIVA() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_UNIDAD_ORGANIZATIVA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_UNIDAD_ORGANIZATIVA").Visible = Value
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

    Public Property HeaderID_ACCION_FORMATIVA_SEGUI() As String
        Get
            Return Me.dxgvLista.Columns("ID_ACCION_FORMATIVA_SEGUI").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_ACCION_FORMATIVA_SEGUI").Caption = Value
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

    Public Property HeaderFECHA_VISITA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_VISITA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_VISITA").Caption = Value
        End Set
    End Property

    Public Property HeaderOBSERVACION() As String
        Get
            Return Me.dxgvLista.Columns("OBSERVACION").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("OBSERVACION").Caption = Value
        End Set
    End Property

    Public Property HeaderCOMENTARIO_ADMIN_PROGRA() As String
        Get
            Return Me.dxgvLista.Columns("COMENTARIO_ADMIN_PROGRA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("COMENTARIO_ADMIN_PROGRA").Caption = Value
        End Set
    End Property

    Public Property HeaderID_UNIDAD_ORGANIZATIVA() As String
        Get
            Return Me.dxgvLista.Columns("ID_UNIDAD_ORGANIZATIVA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_UNIDAD_ORGANIZATIVA").Caption = Value
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

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ACCION_FORMATIVA_SEGUI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/02/2017	Created
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
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ACCION_FORMATIVA_SEGUI
    ''' filtrado por la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Me.odsListaPorACCION_FORMATIVA.SelectParameters("ID_ACCION_FORMATIVA").DefaultValue = ID_ACCION_FORMATIVA.ToString()
        Me.odsListaPorACCION_FORMATIVA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorACCION_FORMATIVA.SelectParameters("asColumnaOrden").DefaultValue = "FECHA_VISITA"
        Me.odsListaPorACCION_FORMATIVA.SelectParameters("asTipoOrden").DefaultValue = "DESC"
        Me.odsListaPorACCION_FORMATIVA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorACCION_FORMATIVA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ACCION_FORMATIVA_SEGUI
    ''' filtrado por la tabla UNIDAD_ORGANIZATIVA
    ''' </summary>
    ''' <param name="ID_UNIDAD_ORGANIZATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorUNIDAD_ORGANIZATIVA(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal) As Integer
        Me.odsListaPorUNIDAD_ORGANIZATIVA.SelectParameters("ID_UNIDAD_ORGANIZATIVA").DefaultValue = ID_UNIDAD_ORGANIZATIVA.ToString()
        Me.odsListaPorUNIDAD_ORGANIZATIVA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorUNIDAD_ORGANIZATIVA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorUNIDAD_ORGANIZATIVA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorUNIDAD_ORGANIZATIVA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorUNIDAD_ORGANIZATIVA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
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
                keyValues(i) = grid.GetRowValues(i, "ID_ACCION_FORMATIVA_SEGUI")
                keyNames(i) = grid.GetRowValues(i, "ID_ACCION_FORMATIVA")
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
        If Me.PermitirEditarInline Then
            Me.dxgvLista.Columns("Edicion").Visible = True
            'CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).NewButton.Visible = Me.PermitirAgregarInline
            'CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).EditButton.Visible = Me.PermitirEditarInline
            'CType(Me.dxgvLista.Columns("Edicion"), DevExpress.Web.ASPxGridView.GridViewCommandColumn).DeleteButton.Visible = Me.PermitirEliminarInline
        Else
            Me.dxgvLista.Columns("Edicion").Visible = False
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
        'If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.EditForm Then
        '    Dim btnGuardar As DevExpress.Web.ASPxEditors.ASPxButton
        '    Dim btnCancelar As DevExpress.Web.ASPxEditors.ASPxButton
        '    btnGuardar = Me.dxgvLista.FindEditFormTemplateControl("btnGuardar")
        '    btnCancelar = Me.dxgvLista.FindEditFormTemplateControl("btnCancelar")
        '    btnGuardar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        '    btnCancelar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        'End If
        'If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.EmptyDataRow Then
        '    Dim btnAgregar As DevExpress.Web.ASPxEditors.ASPxButton
        '    btnAgregar = Me.dxgvLista.FindEmptyDataRowTemplateControl("btnAgregar")
        '    btnAgregar.JSProperties.Add("cp_NombreClienteLista", Me.NombreGridCliente)
        '    btnAgregar.Visible = Me.PermitirAgregarInline
        '    Dim lblEmptyDataRow As DevExpress.Web.ASPxEditors.ASPxLabel
        '    lblEmptyDataRow = Me.dxgvLista.FindEmptyDataRowTemplateControl("lblEmptyDataRow")
        '    lblEmptyDataRow.Text = Me.dxgvLista.SettingsText.EmptyDataRow
        'End If
        'If e.RowType = DevExpress.Web.ASPxGridView.GridViewRowType.Data Then
        '    If Not Me.PermitirEditar Then
        '        Dim lbDetalle As LinkButton
        '        lbDetalle = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnEditar")
        '        lbDetalle.Visible = False
        '    End If
        '    If Me.PermitirSeleccionar Then
        '        Dim lbSeleccionar As LinkButton
        '        lbSeleccionar = Me.dxgvLista.FindRowCellTemplateControl(e.VisibleIndex, Nothing, "lbtnSeleccionar")
        '        lbSeleccionar.Visible = True
        '        lbSeleccionar.Text = Me.TextoSeleccionar
        '        lbSeleccionar.CommandName = Me.ComandoSeleccionar
        '        If lbSeleccionar.CommandName = "Check" Then
        '            lbSeleccionar.Visible = False
        '        End If
        '    End If
        'End If
    End Sub

    Public Function DevolverSeleccionados() As listaACCION_FORMATIVA_SEGUI
        Dim mLista As New listaACCION_FORMATIVA_SEGUI
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_ACCION_FORMATIVA_SEGUI")
            Dim lEntidad As New ACCION_FORMATIVA_SEGUI
            lEntidad.ID_ACCION_FORMATIVA_SEGUI = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As ACCION_FORMATIVA_SEGUI = CType(Me.dxgvLista.GetRow(e.VisibleIndex), ACCION_FORMATIVA_SEGUI)

            If Me.mComponente.EliminarACCION_FORMATIVA_SEGUI(lEntidad.ID_ACCION_FORMATIVA_SEGUI) <> 1 Then
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
      If e.Column.FieldName = "NOMBRE_PROVEEDOR" Then
            Dim lAccion As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA"))
            If lAccion IsNot Nothing Then
                Dim lProveedor As PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lAccion.ID_PROVEEDOR_AF)
                If lProveedor IsNot Nothing Then
                    e.Value = lProveedor.NOMBRE_PROVEEDOR
                End If
            End If
        ElseIf e.Column.FieldName = "NOMBRE_ACCION_FORMATIVA" Then
            Dim lAccion As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA"))
            If lAccion IsNot Nothing Then
                e.Value = lAccion.NOMBRE_ACCION_FORMATIVA
            End If
        ElseIf e.Column.FieldName = "CODIGO_GRUPO" Then
            Dim lAccion As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA"))
            If lAccion IsNot Nothing Then
                e.Value = lAccion.CODIGO_GRUPO
            End If
        ElseIf e.Column.FieldName = "OBSERVACION_BREVE" Then
            If e.GetListSourceFieldValue("OBSERVACION") IsNot Nothing Then
                If e.GetListSourceFieldValue("OBSERVACION").ToString.Length <= 2000 Then
                    e.Value = e.GetListSourceFieldValue("OBSERVACION")
                Else
                    e.Value = Strings.Left(e.GetListSourceFieldValue("OBSERVACION"), 2000) + "..."
                End If

            End If
        ElseIf e.Column.FieldName = "USUARIO" Then
            Dim lUsuario As USUARIO = (New cUSUARIO).ObtenerUSUARIO(e.GetListSourceFieldValue("USUARIO_CREACION"))
            If lUsuario IsNot Nothing Then
                e.Value = lUsuario.NOMBRE
            End If
        End If
    End Sub
End Class
