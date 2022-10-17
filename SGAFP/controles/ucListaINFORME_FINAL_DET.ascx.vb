Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaINFORME_FINAL_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla INFORME_FINAL_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/05/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaINFORME_FINAL_DET
    Inherits ucListaBase
 
    Private mComponente As New cINFORME_FINAL_DET
    Public Event Seleccionado(ByVal ID_INFORME_FINAL_DET As Decimal) 
    Public Event Editando(ByVal ID_INFORME_FINAL_DET As Decimal) 

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

    Public Property VerID_INFORME_FINAL_DET() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_INFORME_FINAL_DET").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_INFORME_FINAL_DET").Visible = Value
        End Set
    End Property

    Public Property VerID_INFORME_FINAL() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_INFORME_FINAL").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_INFORME_FINAL").Visible = Value
        End Set
    End Property

    Public Property VerID_PARTICIPANTE() As Boolean
        Get
            Return Me.dxgvLista.Columns("ID_PARTICIPANTE").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("ID_PARTICIPANTE").Visible = Value
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

    Public Property VerNOTA_OBTENIDA() As Boolean
        Get
            Return Me.dxgvLista.Columns("NOTA_OBTENIDA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("NOTA_OBTENIDA").Visible = Value
        End Set
    End Property

    Public Property VerPORC_ASISTENCIA() As Boolean
        Get
            Return Me.dxgvLista.Columns("PORC_ASISTENCIA").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("PORC_ASISTENCIA").Visible = Value
        End Set
    End Property

    Public Property VerMONTO_SOLICITADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MONTO_SOLICITADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MONTO_SOLICITADO").Visible = Value
        End Set
    End Property

    Public Property VerMONTO_APROBADO() As Boolean
        Get
            Return Me.dxgvLista.Columns("MONTO_APROBADO").Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.dxgvLista.Columns("MONTO_APROBADO").Visible = Value
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

    Public Property HeaderID_INFORME_FINAL_DET() As String
        Get
            Return Me.dxgvLista.Columns("ID_INFORME_FINAL_DET").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_INFORME_FINAL_DET").Caption = Value
        End Set
    End Property

    Public Property HeaderID_INFORME_FINAL() As String
        Get
            Return Me.dxgvLista.Columns("ID_INFORME_FINAL").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_INFORME_FINAL").Caption = Value
        End Set
    End Property

    Public Property HeaderID_PARTICIPANTE() As String
        Get
            Return Me.dxgvLista.Columns("ID_PARTICIPANTE").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ID_PARTICIPANTE").Caption = Value
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

    Public Property HeaderNOTA_OBTENIDA() As String
        Get
            Return Me.dxgvLista.Columns("NOTA_OBTENIDA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("NOTA_OBTENIDA").Caption = Value
        End Set
    End Property

    Public Property HeaderPORC_ASISTENCIA() As String
        Get
            Return Me.dxgvLista.Columns("PORC_ASISTENCIA").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("PORC_ASISTENCIA").Caption = Value
        End Set
    End Property

    Public Property HeaderMONTO_SOLICITADO() As String
        Get
            Return Me.dxgvLista.Columns("MONTO_SOLICITADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MONTO_SOLICITADO").Caption = Value
        End Set
    End Property

    Public Property HeaderMONTO_APROBADO() As String
        Get
            Return Me.dxgvLista.Columns("MONTO_APROBADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("MONTO_APROBADO").Caption = Value
        End Set
    End Property

    Public Property HeaderESTADO() As String
        Get
            Return Me.dxgvLista.Columns("ESTADO").Caption
        End Get
        Set(ByVal Value As String)
            Me.dxgvLista.Columns("ESTADO").Caption = Value
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
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Me.odsLista.SelectMethod = "ObtenerLista"
        Me.odsLista.SelectParameters.Clear()
        Me.odsLista.SelectParameters.Add(New Parameter("recuperarForaneas", TypeCode.Boolean, "False"))
        Me.odsLista.SelectParameters.Add(New Parameter("asColumnaOrden", TypeCode.String, ""))
        Me.odsLista.SelectParameters.Add(New Parameter("asTipoOrden", TypeCode.String, ""))
        Me.odsLista.DataBind()
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_DET
    ''' filtrado por la tabla INFORME_FINAL_AF
    ''' </summary>
    ''' <param name="ID_INFORME_FINAL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorINFORME_FINAL_AF(ByVal ID_INFORME_FINAL As Decimal) As Integer
        Me.odsLista.SelectMethod = "ObtenerListaPorINFORME_FINAL_AF"
        Me.odsLista.SelectParameters.Clear()
        Me.odsLista.SelectParameters.Add(New Parameter("ID_INFORME_FINAL", TypeCode.Decimal, ID_INFORME_FINAL.ToString()))
        Me.odsLista.DataBind()
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_DET
    ''' filtrado por la tabla PARTICIPANTE
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal) As Integer
        Me.odsLista.SelectMethod = "ObtenerListaPorPARTICIPANTE"
        Me.odsLista.SelectParameters.Clear()
        Me.odsLista.SelectParameters.Add(New Parameter("ID_PARTICIPANTE", TypeCode.Decimal, ID_PARTICIPANTE.ToString()))
        Me.odsLista.DataBind()
        Me.dxgvLista.Selection.UnselectAll()
        Me.dxgvLista.Visible = True
        Me.dxgvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla INFORME_FINAL_DET
    ''' filtrado por la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Me.odsLista.SelectMethod = "ObtenerListaPorACCION_FORMATIVA"
        Me.odsLista.SelectParameters.Clear()
        Me.odsLista.SelectParameters.Add(New Parameter("ID_ACCION_FORMATIVA", TypeCode.Decimal, ID_ACCION_FORMATIVA.ToString()))
        Me.odsLista.SelectParameters.Add(New Parameter("recuperarForaneas", TypeCode.Boolean, "False"))
        Me.odsLista.SelectParameters.Add(New Parameter("asColumnaOrden", TypeCode.String, ""))
        Me.odsLista.SelectParameters.Add(New Parameter("asTipoOrden", TypeCode.String, "ASC"))
        Me.odsLista.DataBind()
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

    Public Function DevolverSeleccionados() As listaINFORME_FINAL_DET
        Dim mLista As New listaINFORME_FINAL_DET
        For Each llave As Decimal In Me.dxgvLista.GetSelectedFieldValues("ID_INFORME_FINAL_DET")
            Dim lEntidad As New INFORME_FINAL_DET
            lEntidad.ID_INFORME_FINAL_DET = llave
            mLista.Add(lEntidad)
        Next
        Return mLista
    End Function

    Protected Sub dxgvLista_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvLista.CustomButtonCallback
        If e.ButtonID = "btnEliminar" Then
            Dim lEntidad As INFORME_FINAL_DET = CType(Me.dxgvLista.GetRow(e.VisibleIndex), INFORME_FINAL_DET)

            If Me.mComponente.EliminarINFORME_FINAL_DET(lEntidad.ID_INFORME_FINAL_DET) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            Else
                If Me.CargarDatos() <> 1 Then
                    Me.AsignarMensaje("Error al Recuperar Lista", True, True)
                End If
            End If
        End If
    End Sub

    Protected Sub dxgvLista_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs) Handles dxgvLista.CustomButtonInitialize
        If e.ButtonID = "btnEliminar" Then
            e.Text = "<img src='imagenes/Eliminar.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Eliminar' onclick='if(!window.confirm(" + """" + "Esta seguro de Eliminar el Registro?"")){return false;}'/>"
        End If
    End Sub

End Class
