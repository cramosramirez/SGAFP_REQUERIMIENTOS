Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaPAQUETE_INFORME
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla PAQUETE_INFORME
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/08/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaPAQUETE_INFORME
    Inherits ucListaBase
 
    Private mComponente As New cPAQUETE_INFORME
    Public Event Seleccionado(ByVal ID_PAQUETE As Decimal) 
    Public Event Editando(ByVal ID_PAQUETE As Decimal) 

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

    Public Property VerID_PAQUETE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PAQUETE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PAQUETE").Visible = Value
        End Set
    End Property

    Public Property VerFECHA() As Boolean
        Get
            Return Me.dxgvLista.Columns("FECHA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("FECHA").Visible = Value
        End Set
    End Property

    Public Property VerCOMENTARIOS() As Boolean
        Get
            Return Me.dxgvLista.Columns("COMENTARIOS").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("COMENTARIOS").Visible = Value
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

    Public Property HeaderID_PAQUETE() As String
        Get
            Return Me.dxgvLista.Columns("ID_PAQUETE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PAQUETE").Caption = Value
        End Set
    End Property

    Public Property HeaderFECHA() As String
        Get
            Return Me.dxgvLista.Columns("FECHA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("FECHA").Caption = Value
        End Set
    End Property

    Public Property HeaderCOMENTARIOS() As String
        Get
            Return Me.dxgvLista.Columns("COMENTARIOS").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("COMENTARIOS").Caption = Value
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
    ''' Función que Carga la información de los registros de la tabla PAQUETE_INFORME
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectParameters("recuperarHijas").DefaultValue = "False"
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
    ''' Función que Carga la información de los registros de la tabla PAQUETE_INFORME
    ''' filtrada por el usuario Técnico
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	31/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorTecnico(ByVal USUARIO_TECNICO As String) As Integer
        Me.odsListaPorTecnico.SelectParameters("USUARIO_TECNICO").DefaultValue = USUARIO_TECNICO
        Me.odsListaPorTecnico.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorTecnico.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorTecnico.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorTecnico"
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PAQUETE_INFORME
    ''' filtrada por criterios
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	15/06/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriterios(ByVal ID_PAQUETE As Decimal, ByVal FECHA As Object, ByVal USUARIO_TECNICO As String) As Integer
        Me.odsListaPorCriterios.SelectParameters("ID_PAQUETE").DefaultValue = ID_PAQUETE
        Me.odsListaPorCriterios.SelectParameters("FECHA").DefaultValue = FECHA
        Me.odsListaPorCriterios.SelectParameters("USUARIO_TECNICO").DefaultValue = USUARIO_TECNICO
        Me.odsListaPorCriterios.SelectParameters("asColumnaOrden").DefaultValue = ""
        Me.odsListaPorCriterios.SelectParameters("asTipoOrden").DefaultValue = ""
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvLista.DataSourceID = "odsListaPorCriterios"
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

    Protected Sub dxgvLista_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dxgvLista.CustomUnboundColumnData
        e.Value = (New cPAQUETE_INFORME_DET).ObtenerLista(Convert.ToInt32(e.GetListSourceFieldValue("ID_PAQUETE"))).Count
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
            RaiseEvent Editando(e.KeyValue)
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

    Public Function DevolverSeleccionados() As listaPAQUETE_INFORME
        Dim mLista As New listaPAQUETE_INFORME
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_PAQUETE")
            Dim lEntidad As New PAQUETE_INFORME
            lEntidad.ID_PAQUETE = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As PAQUETE_INFORME = CType(Me.dxgvLista.GetRow(e.VisibleIndex), PAQUETE_INFORME)

            Dim listaPaqueteInformeDet As listaPAQUETE_INFORME_DET
            listaPaqueteInformeDet = (New cPAQUETE_INFORME_DET).ObtenerLista(lEntidad.ID_PAQUETE)

            For Each ePaqueteInformeDet As PAQUETE_INFORME_DET In listaPaqueteInformeDet
                Dim lInformeFinal As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(ePaqueteInformeDet.ID_INFORME_FINAL)

                If lInformeFinal.ID_ESTADO_INFORME <> EstadoInformeFinal.InformeValidadoTecnico Then
                    Me.AsignarMensaje("Error al Eliminar Registro: Existen Informes del Paquete en Proceso de Aprobación", True, True)
                    Return
                End If
            Next

            If Me.mComponente.EliminarPAQUETE_INFORME(lEntidad.ID_PAQUETE) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje(mComponente.sError, True, True)
            Else
                Me.dxgvLista.DataBind()
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            e.Text = "<img src='../imagenes/Eliminar.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
        End If

        'If e.ButtonID = "btnImprimir" Then
        '    Dim IdPaquete As Decimal = Convert.ToDecimal(Me.dxgvLista.GetRowValues(e.VisibleIndex, "ID_PAQUETE"))
        '    e.Text = "<img src='../imagenes/imprimir.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Imprimir' onclick='window.open('~/Reportes/wfReportePaquetesInformes.aspx?IDP=" + IdPaquete.ToString + "')';/>"
        'End If
    End Sub

End Class
