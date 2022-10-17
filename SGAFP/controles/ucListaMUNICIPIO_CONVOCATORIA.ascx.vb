Imports SGAFP.BL
Imports SGAFP.EL
Imports DevExpress.Web.ASPxGridView
Imports DevExpress.Web.ASPxEditors

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaMUNICIPIO_CONVOCATORIA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla MUNICIPIO_CONVOCATORIA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/09/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaMUNICIPIO_CONVOCATORIA
    Inherits ucListaBase
 
    Private mComponente As New cMUNICIPIO_CONVOCATORIA
    Public Event Seleccionado(ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String)
    Public Event Editando(ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String)

#Region "Propiedades"

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

    Private _CODIGO_DEPARTAMENTO As String
    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return _CODIGO_DEPARTAMENTO
        End Get
        Set(ByVal Value As String)
            _CODIGO_DEPARTAMENTO = Value
            If Not Me.ViewState("CODIGO_DEPARTAMENTO") Is Nothing Then Me.ViewState.Remove("CODIGO_DEPARTAMENTO")
            Me.ViewState.Add("CODIGO_DEPARTAMENTO", Value)
        End Set
    End Property

    Private _CODIGO_MUNICIPIO As String
    Public Property CODIGO_MUNICIPIO() As String
        Get
            Return _CODIGO_MUNICIPIO
        End Get
        Set(ByVal Value As String)
            _CODIGO_MUNICIPIO = Value
            If Not Me.ViewState("CODIGO_MUNICIPIO") Is Nothing Then Me.ViewState.Remove("CODIGO_MUNICIPIO")
            Me.ViewState.Add("CODIGO_MUNICIPIO", Value)
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

    Public Property VerAPORTE_FISDL() As Boolean
        Get
            Return Me.dxgvLista.Columns("APORTE_FISDL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("APORTE_FISDL").Visible = Value
        End Set
    End Property

    Public Property VerMONTO_LIQUIDADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MONTO_LIQUIDADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MONTO_LIQUIDADO").Visible = Value
        End Set
    End Property

    Public Property VerASESOR_MUNICIPAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("ASESOR_MUNICIPAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ASESOR_MUNICIPAL").Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_PROYECTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("CODIGO_PROYECTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("CODIGO_PROYECTO").Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_PROYECTO() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOMBRE_PROYECTO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOMBRE_PROYECTO").Visible = Value
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

    Public Property HeaderNO_CONVOCATORIA() As String
        Get
            Return Me.dxgvLista.Columns("NO_CONVOCATORIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NO_CONVOCATORIA").Caption = Value
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

    Public Property HeaderAPORTE_FISDL() As String
        Get
            Return Me.dxgvLista.Columns("APORTE_FISDL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("APORTE_FISDL").Caption = Value
        End Set
    End Property

    Public Property HeaderMONTO_LIQUIDADO() As String
        Get
            Return Me.dxgvLista.Columns("MONTO_LIQUIDADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MONTO_LIQUIDADO").Caption = Value
        End Set
    End Property

    Public Property HeaderASESOR_MUNICIPAL() As String
        Get
            Return Me.dxgvLista.Columns("ASESOR_MUNICIPAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ASESOR_MUNICIPAL").Caption = Value
        End Set
    End Property

    Public Property HeaderCODIGO_PROYECTO() As String
        Get
            Return Me.dxgvLista.Columns("CODIGO_PROYECTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("CODIGO_PROYECTO").Caption = Value
        End Set
    End Property

    Public Property HeaderNOMBRE_PROYECTO() As String
        Get
            Return Me.dxgvLista.Columns("NOMBRE_PROYECTO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOMBRE_PROYECTO").Caption = Value
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

#Region "Eventos Grid Detalle"
    Protected Sub detailGrid_DataSelect(ByVal sender As Object, ByVal e As EventArgs)
        Dim grid As ASPxGridView = TryCast(sender, ASPxGridView)
        Dim lClave() As String = grid.GetMasterRowKeyValue().ToString.Split("-")
        Session("ID_FUENTE") = lClave(0)
        Session("NO_CONVOCATORIA") = lClave(1)
        Session("CODIGO_DEPARTAMENTO") = lClave(2)
        Session("CODIGO_MUNICIPIO") = lClave(3)
    End Sub

    Protected Sub detailGrid_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewClientJSPropertiesEventArgs)
        Dim grid As ASPxGridView = TryCast(sender, DevExpress.Web.ASPxGridView.ASPxGridView)
        Dim keyValues(grid.VisibleRowCount - 1) As Object
        For i As Integer = 0 To grid.VisibleRowCount - 1
            keyValues(i) = grid.GetRowValues(i, "ID_LIQUIDACION")
        Next i
        e.Properties("cpKeyValues") = keyValues
    End Sub

    Protected Sub detailGrid_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs)
        Dim grid As ASPxGridView = TryCast(sender, DevExpress.Web.ASPxGridView.ASPxGridView)
        If e.ButtonID = "btnEliminar" AndAlso grid.GetRowValues(e.VisibleIndex, "ID_LIQUIDACION") IsNot Nothing Then
            'Habilitar botón de eliminar si es la última Liquidación Generada
            Dim lbMunicipioLiquidacion As New cMUNICIPIO_LIQUIDACION
            Dim lEntidad As MUNICIPIO_LIQUIDACION = TryCast(grid.GetRow(e.VisibleIndex), MUNICIPIO_LIQUIDACION)

            If lEntidad IsNot Nothing Then
                If grid.GetMasterRowFieldValues("NUM_LIQUIDACIONES") = lEntidad.NO_LIQUIDACION Then
                    e.Visible = DevExpress.Utils.DefaultBoolean.True
                    Return
                End If
            End If
            e.Visible = DevExpress.Utils.DefaultBoolean.False
        End If
    End Sub

    Private Function MontoAnteriorLiquidado(ByVal NO_LIQUIDACION As Decimal) As Decimal
        Dim lMonto As Decimal = 0
        Dim lbMunicipioLiq As New cMUNICIPIO_LIQUIDACION
        Dim lListaLiquidaciones As listaMUNICIPIO_LIQUIDACION = lbMunicipioLiq.ObtenerListaPorMUNICIPIO_CONVOCATORIA(CDec(Session("ID_FUENTE")), CDec(Session("NO_CONVOCATORIA")), Session("CODIGO_DEPARTAMENTO"), Session("CODIGO_MUNICIPIO"), False, False, "NO_LIQUIDACION")
        For Each _Liquidacion As MUNICIPIO_LIQUIDACION In lListaLiquidaciones
            If _Liquidacion.NO_LIQUIDACION < NO_LIQUIDACION Then lMonto += _Liquidacion.MONTO_LIQUIDADO Else Exit For
        Next
        Return lMonto
    End Function

    Private Function MontoAporte() As Decimal
        Dim lbMunicipioConv As New cMUNICIPIO_CONVOCATORIA
        Dim lEntidad As MUNICIPIO_CONVOCATORIA = lbMunicipioConv.ObtenerMUNICIPIO_CONVOCATORIA(CDec(Session("ID_FUENTE")), CDec(Session("NO_CONVOCATORIA")), Session("CODIGO_DEPARTAMENTO"), Session("CODIGO_MUNICIPIO"))
        If lEntidad IsNot Nothing Then
            Return lEntidad.APORTE_FISDL
        End If
        Return 0
    End Function

    Protected Sub detailGrid_UnboundColumn(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs)
        If e.Column.FieldName = "ANTERIOR_LIQUIDADO" Then
            'Obtener el "Total de Liquidaciones anteriores" a la actual
            e.Value = MontoAnteriorLiquidado(CDec(e.GetListSourceFieldValue("NO_LIQUIDACION")))
        End If
        If e.Column.FieldName = "POR_LIQUIDAR" Then
            'Obtener la diferencia entre el "Aporte" y el "Total de Liquidaciones anteriores" a la actual
            e.Value = MontoAporte() - MontoAnteriorLiquidado(CDec(e.GetListSourceFieldValue("NO_LIQUIDACION")))
        End If
        If e.Column.FieldName = "SALDO_PENDIENTE" Then
            'Obtener la diferencia entre el "Monto Por Liquidar" y el "Total de esta Liquidacion" 
            e.Value = MontoAporte() - MontoAnteriorLiquidado(CDec(e.GetListSourceFieldValue("NO_LIQUIDACION"))) - e.GetListSourceFieldValue("MONTO_LIQUIDADO")
        End If
    End Sub
#End Region

#Region " Criterios de Búsqueda Adicionales "
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla MUNICIPIO_CONVOCATORIA
    ''' filtrado por los siguientes parámetros
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <param name="NO_CONVOCATORIA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriterios(ByVal ID_FUENTE As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal NO_CONVOCATORIA As Decimal) As Integer
        Me.odsListaPorCriterios.SelectParameters("ID_FUENTE").DefaultValue = ID_FUENTE
        Me.odsListaPorCriterios.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = CODIGO_DEPARTAMENTO
        Me.odsListaPorCriterios.SelectParameters("CODIGO_MUNICIPIO").DefaultValue = CODIGO_MUNICIPIO
        Me.odsListaPorCriterios.SelectParameters("NO_CONVOCATORIA").DefaultValue = NO_CONVOCATORIA
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    Public Sub CargarDatosPorCriteriosCallback(ByVal opcion As String, ByVal parametros() As String)
        If opcion = "BuscarDatos" Then
            Me.dxgvLista.Selection.UnselectAll()
            If hfdxgv.Contains("BuscarDatos") Then hfdxgv("BuscarDatos") = parametros(0) Else hfdxgv.Add("BuscarDatos", parametros(0))
            For i As Integer = 1 To parametros.Length - 1
                If hfdxgv.Contains("param" + (i).ToString) Then hfdxgv.Remove("param" + (i).ToString)
            Next
            For i As Integer = 1 To parametros.Length - 1
                hfdxgv.Add("param" + (i).ToString, parametros(i))
            Next
            Me.ActualizarCargarDatosCallback()
        End If
    End Sub

    Public Sub ActualizarCargarDatosCallback()
        If Me.hfdxgv.Contains("BuscarDatos") Then
            If hfdxgv("BuscarDatos") = "CargarDatosPorCriterios" Then Me.CargarDatosPorCriterios(hfdxgv("param1"), hfdxgv("param2"), hfdxgv("param3"), hfdxgv("param4"))
        End If
    End Sub

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla MUNICIPIO_CONVOCATORIA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/09/2011	Created
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
    ''' Función que Carga la información de los registros de la tabla MUNICIPIO_CONVOCATORIA
    ''' filtrado por la tabla DEPARTAMENTO
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/09/2011	Created
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
    ''' Función que Carga la información de los registros de la tabla MUNICIPIO_CONVOCATORIA
    ''' filtrado por la tabla MUNICIPIO
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/09/2011	Created
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
        'Actualización de Datos Cargados vía Callback
        ActualizarCargarDatosCallback()

        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
        If Not Me.ViewState("CODIGO_DEPARTAMENTO") Is Nothing Then Me._CODIGO_DEPARTAMENTO = Me.ViewState("CODIGO_DEPARTAMENTO")
        If Not Me.ViewState("CODIGO_MUNICIPIO") Is Nothing Then Me._CODIGO_MUNICIPIO = Me.ViewState("CODIGO_MUNICIPIO")
    End Sub


    Protected Sub dxgvLista_CustomJSProperties(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewClientJSPropertiesEventArgs) Handles dxgvLista.CustomJSProperties
        Dim grid As DevExpress.Web.ASPxGridView.ASPxGridView = CType(sender, DevExpress.Web.ASPxGridView.ASPxGridView)
        Dim keyNames(grid.VisibleRowCount - 1) As Object
        Dim keyValues(grid.VisibleRowCount - 1) As Object
        For i As Integer = 0 To grid.VisibleRowCount - 1
            keyValues(i) = grid.GetRowValues(i, "ID_FUENTE").ToString + ";" + grid.GetRowValues(i, "NO_CONVOCATORIA").ToString + ";" + grid.GetRowValues(i, "CODIGO_DEPARTAMENTO") _
                + ";" + grid.GetRowValues(i, "CODIGO_MUNICIPIO")
            keyNames(i) = grid.GetRowValues(i, "APORTE_FISDL")
        Next i
        e.Properties("cpKeyValues") = keyValues
        e.Properties("cpKeyNames") = keyNames
        e.Properties("cpNombreComboCliente") = Me.NombreComboCliente
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
            RaiseEvent Seleccionado(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, e.CommandArgs.CommandArgument)
        End If
        If e.CommandArgs.CommandName = "Editar" Then
            RaiseEvent Editando(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, e.CommandArgs.CommandArgument)
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

    Public Function DevolverSeleccionados() As listaMUNICIPIO_CONVOCATORIA
        Dim mLista As New listaMUNICIPIO_CONVOCATORIA
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("NO_CONVOCATORIA")
            Dim lEntidad As New MUNICIPIO_CONVOCATORIA
            lEntidad.NO_CONVOCATORIA = llave
            lEntidad.CODIGO_DEPARTAMENTO = Me.CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_MUNICIPIO = Me.CODIGO_MUNICIPIO
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lIdFuente As Decimal = CDec(dxgvLista.GetRowValues(e.VisibleIndex, "ID_FUENTE"))
            Dim lNumConvocatoria As Decimal = CDec(dxgvLista.GetRowValues(e.VisibleIndex, "NO_CONVOCATORIA"))
            Dim lCodigoDepto As String = dxgvLista.GetRowValues(e.VisibleIndex, "CODIGO_DEPARTAMENTO")
            Dim lCodigoMuni As String = dxgvLista.GetRowValues(e.VisibleIndex, "CODIGO_MUNICIPIO")

            If Me.mComponente.EliminarMUNICIPIO_CONVOCATORIA(lIdFuente, lNumConvocatoria, lCodigoDepto, lCodigoMuni) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" AndAlso dxgvLista.GetRowValues(e.VisibleIndex, "NO_CONVOCATORIA") IsNot Nothing Then
            Dim lIdFuente As Decimal = CDec(dxgvLista.GetRowValues(e.VisibleIndex, "ID_FUENTE"))
            Dim lNoConvocatoria As Decimal = CDec(dxgvLista.GetRowValues(e.VisibleIndex, "NO_CONVOCATORIA"))
            Dim lCodigoDepartamento As String = dxgvLista.GetRowValues(e.VisibleIndex, "CODIGO_DEPARTAMENTO")
            Dim lCodigoMunicipio As String = dxgvLista.GetRowValues(e.VisibleIndex, "CODIGO_MUNICIPIO")
            Dim lListaLiquidaciones As listaMUNICIPIO_LIQUIDACION = (New cMUNICIPIO_LIQUIDACION).ObtenerListaPorMUNICIPIO_CONVOCATORIA(lIdFuente, lNoConvocatoria, lCodigoDepartamento, lCodigoMunicipio)
            If lListaLiquidaciones IsNot Nothing AndAlso lListaLiquidaciones.Count > 0 Then
                e.Visible = DevExpress.Utils.DefaultBoolean.False
            Else
                e.Text = "<img src='../imagenes/eliminar.png' style='border-style:none;border-width:0px;height:16px;width:16px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar la Convocatoria del Municipio?"")){return false;}'/>"
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        If e.Column.FieldName = "CORRELATIVO" Then
            e.Value = e.ListSourceRowIndex + 1
        End If
    End Sub

    Protected Function ObtenerIdFuente(ByVal ID_LIQUIDACION As Decimal) As Decimal
        Dim lRet As Integer = 0
        Dim eMunicipiol As MUNICIPIO_LIQUIDACION = (New cMUNICIPIO_LIQUIDACION).ObtenerMUNICIPIO_LIQUIDACION(ID_LIQUIDACION)
        If eMunicipiol IsNot Nothing Then
            lRet = eMunicipiol.ID_FUENTE
        End If
        Return lRet
    End Function


    Protected Sub dxgvLista_DetailRowExpandedChanged(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewDetailRowEventArgs) Handles dxgvLista.DetailRowExpandedChanged
        If e.Expanded Then
            Dim lblProximaLiquidacion As ASPxLabel = TryCast(Me.dxgvLista.FindDetailRowTemplateControl(e.VisibleIndex, "lblProximaLiquidacion"), ASPxLabel)
            If lblProximaLiquidacion IsNot Nothing Then
                Dim lCodigoDepartamento As String = dxgvLista.GetRowValues(e.VisibleIndex, "CODIGO_DEPARTAMENTO")
                Dim lCodigoMunicipio As String = dxgvLista.GetRowValues(e.VisibleIndex, "CODIGO_MUNICIPIO")
                Dim lListaFaseMunicipios As listaFASE_MUNICIPIOS = (New cFASE_MUNICIPIOS).ObtenerListaPorMUNICIPIO(lCodigoDepartamento, lCodigoMunicipio)
                Dim MontoLiquidar As Decimal = (New cFACTURA_DET).ObtenerMontoParaLiquidacion( _
                    lListaFaseMunicipios(0).ID_FUENTE, CDec(dxgvLista.GetRowValues(e.VisibleIndex, "NO_CONVOCATORIA")), lCodigoDepartamento, lCodigoMunicipio)
                lblProximaLiquidacion.Text = MontoLiquidar.ToString("#,###,##0.00")
            End If
        End If
    End Sub
End Class
