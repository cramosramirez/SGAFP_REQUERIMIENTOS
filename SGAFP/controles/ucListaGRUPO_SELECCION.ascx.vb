Imports SGAFP.BL
Imports SGAFP.EL
Imports DevExpress.Web.ASPxEditors
Imports DevExpress.Web.ASPxGridView

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaGRUPO_SELECCION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla GRUPO_SELECCION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/03/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaGRUPO_SELECCION
    Inherits ucListaBase

    Private mComponente As New cGRUPO_SELECCION
    Public Event Seleccionado(ByVal ID_GRUPO_SELEC As Decimal)
    Public Event Editando(ByVal ID_GRUPO_SELEC As Decimal)
    Public Event RegistrarParticipante(ByVal ID_GRUPO_SELEC As Decimal)
    Public Event CalendarizarGrupo(ByVal ID_GRUPO_SELEC As Decimal)
    Public Event Mensaje(ByVal mensaje As String)

#Region "Propiedades"

    Public Function GetCheckBoxVisible() As Boolean
        Return MostrarCheckTodos
    End Function

    Public Property MostrarCheckTodos() As Boolean
        Get
            If Not Me.ViewState("MostrarCheckTodos") Is Nothing Then
                Return Me.ViewState("MostrarCheckTodos")
            Else
                Return False
            End If
        End Get
        Set(ByVal Value As Boolean)
            If Not Me.ViewState("MostrarCheckTodos") Is Nothing Then Me.ViewState.Remove("MostrarCheckTodos")
            Me.ViewState.Add("MostrarCheckTodos", Value)
        End Set
    End Property
    Public Property MostrarCheckUnaSeleccion As Boolean
        Set(value As Boolean)
            dxgvLista.Columns("CheckSeleccionar").Visible = value
            dxgvLista.SettingsBehavior.AllowSelectSingleRowOnly = value
        End Set
        Get
            Return dxgvLista.SettingsBehavior.AllowSelectSingleRowOnly
        End Get
    End Property
    Public Property MostrarCheckVariaSeleccion As Boolean
        Set(value As Boolean)
            dxgvLista.Columns("CheckSeleccionar").Visible = value
        End Set
        Get
            Return dxgvLista.Columns("CheckSeleccionar").Visible
        End Get
    End Property
    Protected Sub chkTodo_Init(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim chkTodo As ASPxCheckBox = TryCast(sender, ASPxCheckBox)
        Dim grd As ASPxGridView = TryCast(chkTodo.NamingContainer, GridViewHeaderTemplateContainer).Grid
        chkTodo.Checked = (grd.Selection.Count = grd.VisibleRowCount) AndAlso grd.VisibleRowCount > 0
    End Sub

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


    Public Property PermitirEditar() As Boolean
        Get
            Return Me.dxgvLista.Columns("colEditar").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colEditar").Visible = Value
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

    Public Property PermitirRegistrarAspirante() As Boolean
        Get
            Return Me.dxgvLista.Columns("colRegistrarAspirante").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colRegistrarAspirante").Visible = Value
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

    Public Property VerID_GRUPO_SELEC() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_GRUPO_SELEC").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_GRUPO_SELEC").Visible = Value
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

    Public Property VerPROVEEDOR() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_PROVEEDOR").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_HABILITA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_HABILITA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_HABILITA").Visible = Value
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

    Public Property VerNO_GRUPO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NO_GRUPO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NO_GRUPO").Visible = Value
        End Set
    End Property

    Public Property VerCODIGO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIGO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIGO").Visible = Value
        End Set
    End Property

    Public Property PermitirCalendarizarGrupo() As Boolean
        Get
            Return Me.dxgvLista.Columns("colCalendarizarGrupo").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colCalendarizarGrupo").Visible = Value
        End Set
    End Property


    Public Property VerGenerarInforme() As Boolean
        Get
            Return Me.dxgvLista.Columns("colGenerarInforme").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colGenerarInforme").Visible = Value
        End Set
    End Property

    Public Property VerInformePreseleccion() As Boolean
        Get
            Return Me.dxgvLista.Columns("colInformeAvance").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colInformeAvance").Visible = Value
        End Set
    End Property

    Public Property VerAspirantesSeleccionados() As Boolean
        Get
            Return Me.dxgvLista.Columns("colAspirantesSeleccionados").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colAspirantesSeleccionados").Visible = Value
        End Set
    End Property

    Public Property VerReclutamientoExtraordinario() As Boolean
        Get
            Return Me.dxgvLista.Columns("colReclutamientoExtraordinario").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("colReclutamientoExtraordinario").Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_CREA() As Boolean
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("USUARIO_CREA").Visible = Value
        End Set
    End Property

    Public Property VerFECHA_CREA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA_CREA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA_CREA").Visible = Value
        End Set
    End Property

    Public Property HeaderID_GRUPO_SELEC() As String
        Get
            Return Me.dxgvLista.Columns("ID_GRUPO_SELEC").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_GRUPO_SELEC").Caption = Value
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

    Public Property HeaderFECHA_HABILITA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_HABILITA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_HABILITA").Caption = Value
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

    Public Property HeaderNO_GRUPO() As String
        Get
            Return Me.dxgvLista.Columns("NO_GRUPO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_GRUPO").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIGO() As String
        Get
            Return Me.dxgvLista.Columns("CODIGO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIGO").Caption = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_CREA() As String
        Get
            Return Me.dxgvLista.Columns("USUARIO_CREA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("USUARIO_CREA").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA_CREA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA_CREA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA_CREA").Caption = Value
        End Set
    End Property


    Public Property VerHORAS_TOTALES() As Boolean
        Get
            Return Me.dxgvLista.Columns("HORAS_TOTALES").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("HORAS_TOTALES").Visible = Value
        End Set
    End Property

    Public Property VerHORAS_CALENDARIZADAS() As Boolean
        Get
            Return Me.dxgvLista.Columns("HORAS_CALENDARIZADAS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("HORAS_CALENDARIZADAS").Visible = Value
        End Set
    End Property

    Public Property VerULT_PERIODO() As Boolean
        Get
            Return Me.dxgvLista.Columns("ULT_PERIODO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ULT_PERIODO").Visible = Value
        End Set
    End Property

#End Region


    Public Function CargarDatosPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                           ByVal ID_PROGRAMA_FORMACION As Decimal, _
                                           ByVal NUM_CONTRATO As String, _
                                           ByVal CON_INFORME_PRESELECCION As Integer, _
                                           Optional ByVal asColumnaOrden As String = "", _
                                           Optional ByVal asTipoOrden As String = "ASC") As Integer
        Me.odsCriterios.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF.ToString
        Me.odsCriterios.SelectParameters("ID_PROGRAMA_FORMACION").DefaultValue = ID_PROGRAMA_FORMACION.ToString
        Me.odsCriterios.SelectParameters("NUM_CONTRATO").DefaultValue = NUM_CONTRATO
        Me.odsCriterios.SelectParameters("CON_INFORME_PRESELECCION").DefaultValue = CON_INFORME_PRESELECCION
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
    ''' Función que Carga la información de los registros de la tabla GRUPO_SELECCION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/03/2019	Created
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
    ''' Función que Carga la información de los registros de la tabla GRUPO_SELECCION
    ''' filtrado por la tabla ACCION_CONTRATADA
    ''' </summary>
    ''' <param name="ID_ACCION_CONTRATADA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/03/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorACCION_CONTRATADA(ByVal ID_ACCION_CONTRATADA As Decimal) As Integer
        Me.odsListaPorACCION_CONTRATADA.SelectParameters("ID_ACCION_CONTRATADA").DefaultValue = ID_ACCION_CONTRATADA.ToString()
        Me.odsListaPorACCION_CONTRATADA.SelectParameters("recuperarForaneas").DefaultValue = "False"
        Me.odsListaPorACCION_CONTRATADA.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorACCION_CONTRATADA.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorACCION_CONTRATADA.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorACCION_CONTRATADA"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
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
                keyValues(i) = grid.GetRowValues(i, "ID_GRUPO_SELEC")
                keyNames(i) = grid.GetRowValues(i, "ID_ACCION_CONTRATADA")
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
        If e.CommandArgs.CommandName = "RegistrarAspirante" Then
            RaiseEvent RegistrarParticipante(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "AspirantesSeleccionados" Then
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "AspirantesSeleccionados", "window.open('../reportes/wfReportePECENTRO.aspx?n=1&id=" + e.KeyValue.ToString() + "','_blank','')", True)
        End If
        If e.CommandArgs.CommandName = "ReclutamientoExtraordinario" Then
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "ListadoAspirantes", "window.open('../reportes/wfReportePECENTRO.aspx?n=2&id=" + e.KeyValue.ToString() + "','_blank','')", True)
        End If
        If e.CommandArgs.CommandName = "CalendarizarGrupo" Then
            RaiseEvent CalendarizarGrupo(e.KeyValue)
        End If
        If e.CommandArgs.CommandName = "GenerarInformePreseleccion" Then
            Dim bInformePreselec As New cINFORME_PRESELECCION_EC
            Dim lRet As Integer


            lRet = bInformePreselec.GenerarInformePreseleccion(CInt(e.KeyValue))
            If lRet = 1 Then
                Me.AsignarMensaje("El informe de avance de preseleccion ha sido generado!", False, True)
            Else
                Me.AsignarMensaje(bInformePreselec.sError, False, True)
            End If
        End If
        If e.CommandArgs.CommandName = "InformeAvance" Then
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "AspirantesSeleccionados", "window.open('../reportes/wfReportePECENTRO.aspx?n=1&id=" + e.KeyValue.ToString() + "','_blank','')", True)
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "InformePreseleccion", "window.open('../reportes/wfReportePECENTRO.aspx?n=0&id=" + e.KeyValue.ToString() + "','_blank','')", True)
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaGRUPO_SELECCION
        Dim mLista As New listaGRUPO_SELECCION
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_GRUPO_SELEC")
            Dim lEntidad As New GRUPO_SELECCION
            lEntidad.ID_GRUPO_SELEC = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As GRUPO_SELECCION = CType(Me.dxgvLista.GetRow(e.VisibleIndex), GRUPO_SELECCION)

            If Me.mComponente.EliminarGRUPO_SELECCION(lEntidad.ID_GRUPO_SELEC) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(sender As Object, e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "NUM_CONTRATO" Then
            Dim lEntidad As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(e.GetListSourceFieldValue("ID_ACCION_CONTRATADA"))
            If lEntidad IsNot Nothing Then
                Dim lEntidadAux As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lEntidad.ID_CONTRATO)
                e.Value = lEntidadAux.NUM_CONTRATO
            End If
        ElseIf e.Column.FieldName = "CURSO" Then
            Dim lEntidad As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(e.GetListSourceFieldValue("ID_ACCION_CONTRATADA"))
            If lEntidad IsNot Nothing Then
                Dim lPrograma As SIFP.EL.Programas = (New SIFP.BL.cProgramas).ObtenerProgramas(lEntidad.CODIGO_PROGRAMA)
                If lPrograma IsNot Nothing Then
                    e.Value = lPrograma.nombre_programa
                End If
            End If
        ElseIf e.Column.FieldName = "NUM_ITEM" Then
            Dim lEntidad As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(e.GetListSourceFieldValue("ID_ACCION_CONTRATADA"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NUM_ITEM
            End If
        ElseIf e.Column.FieldName = "NOMBRE_PROVEEDOR" Then

            Dim lEntidad As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(e.GetListSourceFieldValue("ID_ACCION_CONTRATADA"))
            If lEntidad IsNot Nothing Then
                Dim lEntidadAux As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lEntidad.ID_CONTRATO)
                Dim lProvee As PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lEntidadAux.ID_PROVEEDOR_AF)
                If lProvee IsNot Nothing Then
                    e.Value = lProvee.NOMBRE_PROVEEDOR
                End If
            End If
        ElseIf e.Column.FieldName = "NO_CONTRATO_COMPRA" Then

            Dim lEntidad As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(e.GetListSourceFieldValue("ID_ACCION_CONTRATADA"))
            If lEntidad IsNot Nothing Then
                Dim lEntidadAux As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lEntidad.ID_CONTRATO)
                Dim lCompra As CONTRATO_COMPRA = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRA(lEntidadAux.ID_CONTRATO_COMPRA)
                If lCompra IsNot Nothing Then
                    e.Value = lCompra.NO_CONTRATO_COMPRA
                End If
            End If
        ElseIf e.Column.FieldName = "HORAS_TOTALES" Then
            Dim lEntidad As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(e.GetListSourceFieldValue("ID_ACCION_CONTRATADA"))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.DURACION
            End If

        ElseIf e.Column.FieldName = "HORAS_CALENDARIZADAS" Then
            Dim bGrupoSeleccion As New cGRUPO_SELECCION
            Dim i As Integer = bGrupoSeleccion.ObtenerTotalHorasCalendarizadas(e.GetListSourceFieldValue("ID_GRUPO_SELEC"))
            e.Value = i

        ElseIf e.Column.FieldName = "ULT_PERIODO" Then
            Dim lFecha As Date = (New cGRUPO_SELECCION).ObtenerUltimaFechaInicioCalendarizada(e.GetListSourceFieldValue("ID_GRUPO_SELEC"))
            If lFecha <> #12:00:00 AM# Then
                e.Value = lFecha.ToString("MMMM-yyyy").ToUpper
            End If
        ElseIf e.Column.FieldName = "DEPARTAMENTO" Then
            Dim lEntidad As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(e.GetListSourceFieldValue("ID_ACCION_CONTRATADA"))
            If lEntidad IsNot Nothing Then
                Dim lDepto As DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(lEntidad.CODIGO_DEPARTAMENTO)
                If lDepto IsNot Nothing Then e.Value = lDepto.NOMBRE
            End If
        ElseIf e.Column.FieldName = "MUNICIPIO" Then
            Dim lEntidad As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(e.GetListSourceFieldValue("ID_ACCION_CONTRATADA"))
            If lEntidad IsNot Nothing Then
                Dim lMuni As MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(lEntidad.CODIGO_DEPARTAMENTO, lEntidad.CODIGO_MUNICIPIO)
                If lMuni IsNot Nothing Then e.Value = lMuni.NOMBRE
            End If
        End If
    End Sub

   
End Class
