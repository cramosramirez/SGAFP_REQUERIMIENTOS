Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaETAPA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla ETAPA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaETAPA
    Inherits ucBase
 
    Private mComponente As New cETAPA
    Public Event Seleccionado(ByVal CODIGO_ETAPA As String, ByVal CODIGO_PROCESO As String) 
    Public Event Editando(ByVal CODIGO_ETAPA As String, ByVal CODIGO_PROCESO As String) 

#Region"Propiedades"

    Public Property MostrarFooter() As Boolean
        Get
            Return Me.gvLista.ShowFooter
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.ShowFooter = Value
        End Set
    End Property

    Public Property PermitirPaginacion() As Boolean
        Get
            Return Me.gvLista.AllowPaging
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.AllowPaging = Value
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
            Me.gvLista.Columns(0).Visible = Value
            If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me.ViewState.Remove("PermitirSeleccionar")
            Me.ViewState.Add("PermitirSeleccionar", Value)
        End Set
    End Property

    Private _PermitirEliminar As Boolean = True
    Public Property PermitirEliminar() As Boolean
        Get
            Return _PermitirEliminar
        End Get
        Set(ByVal Value As Boolean)
            _PermitirEliminar = Value
            Me.gvLista.Columns(Me.gvLista.Columns.Count - 1).Visible = Value
            If Not Me.ViewState("PermitirEliminar") Is Nothing Then Me.ViewState.Remove("PermitirEliminar")
            Me.ViewState.Add("PermitirEliminar", Value)
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
            Return Me.gvLista.Columns(0).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(0).HeaderText = Value
        End Set
    End Property

    Private _CODIGO_PROCESO As String
    Public Property CODIGO_PROCESO() As String
        Get
            Return _CODIGO_PROCESO
        End Get
        Set(ByVal Value As String)
            _CODIGO_PROCESO = Value 
            If Not Me.ViewState("CODIGO_PROCESO") Is Nothing Then Me.ViewState.Remove("CODIGO_PROCESO")
            Me.ViewState.Add("CODIGO_PROCESO", Value)
        End Set
    End Property

    Public Property VerCODIGO_ETAPA() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerCODIGO_PROCESO() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerID_ESTADO_SOLICITUD() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerUNIDAD_DE_TIEMPO() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_ETAPA() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerETAPA_ANT() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerETAPA_SIG() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerTIPO_ETAPA() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property VerDURACION() As Boolean
        Get
            Return Me.gvLista.Columns(9).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(9).Visible = Value
        End Set
    End Property

    Public Property VerORDEN_EJECUCION() As Boolean
        Get
            Return Me.gvLista.Columns(10).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(10).Visible = Value
        End Set
    End Property

    Public Property VerUSERID() As Boolean
        Get
            Return Me.gvLista.Columns(11).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(11).Visible = Value
        End Set
    End Property

    Public Property VerLASTUPDATE() As Boolean
        Get
            Return Me.gvLista.Columns(12).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(12).Visible = Value
        End Set
    End Property

    Public Property HeaderCODIGO_ETAPA() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODIGO_PROCESO() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_ESTADO_SOLICITUD() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUNIDAD_DE_TIEMPO() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOMBRE_ETAPA() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderETAPA_ANT() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderETAPA_SIG() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTIPO_ETAPA() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDURACION() As String
        Get
            Return Me.gvLista.Columns(9).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(9).HeaderText = Value
        End Set
    End Property

    Public Property HeaderORDEN_EJECUCION() As String
        Get
            Return Me.gvLista.Columns(10).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(10).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSERID() As String
        Get
            Return Me.gvLista.Columns(11).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(11).HeaderText = Value
        End Set
    End Property

    Public Property HeaderLASTUPDATE() As String
        Get
            Return Me.gvLista.Columns(12).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(12).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ETAPA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lETAPA As listaETAPA
        lETAPA = Me.mComponente.ObtenerLista(CODIGO_PROCESO)
        If lETAPA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lETAPA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ETAPA
    ''' filtrado por la tabla PROCESO
    ''' </summary>
    ''' <param name="CODIGO_PROCESO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROCESO(ByVal CODIGO_PROCESO As String) As Integer
        Dim lETAPA As listaETAPA
        lETAPA = Me.mComponente.ObtenerListaPorPROCESO(CODIGO_PROCESO)
        If lETAPA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorPROCESO") = True
        Me.ViewState("CODIGO_PROCESO") = CODIGO_PROCESO
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lETAPA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ETAPA
    ''' filtrado por la tabla ESTADO_SOLICITUD
    ''' </summary>
    ''' <param name="ID_ESTADO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorESTADO_SOLICITUD(ByVal ID_ESTADO_SOLICITUD As Decimal) As Integer
        Dim lETAPA As listaETAPA
        lETAPA = Me.mComponente.ObtenerListaPorESTADO_SOLICITUD(ID_ESTADO_SOLICITUD)
        If lETAPA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorESTADO_SOLICITUD") = True
        Me.ViewState("ID_ESTADO_SOLICITUD") = ID_ESTADO_SOLICITUD
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lETAPA
        Me.gvLista.DataBind()
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("PermitirEditar") Is Nothing Then Me._PermitirEditar = Me.ViewState("PermitirEditar")
        If Not Me.ViewState("PermitirSeleccionar") Is Nothing Then Me._PermitirSeleccionar = Me.ViewState("PermitirSeleccionar")
        If Not Me.ViewState("PermitirEliminar") Is Nothing Then Me._PermitirEliminar = Me.ViewState("PermitirEliminar")
        If Not Me.ViewState("TextoSeleccionar") Is Nothing Then Me._TextoSeleccionar = Me.ViewState("TextoSeleccionar")
        If Not Me.ViewState("ComandoSeleccionar") Is Nothing Then Me._ComandoSeleccionar = Me.ViewState("ComandoSeleccionar")
        If Not Me.ViewState("CODIGO_PROCESO") Is Nothing Then Me._CODIGO_PROCESO = Me.ViewState("CODIGO_PROCESO")
    End Sub

    Private lDdlESTADO_SOLICITUD As SGAFP.WebUC.ddlESTADO_SOLICITUD

    Protected Sub gvLista_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLista.RowCommand
        If e.CommandName = "Editar" Then
            RaiseEvent Editando(CODIGO_PROCESO, e.CommandArgument)
        End If
    End Sub

    Protected Sub gvLista_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvLista.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            If Me.PermitirEliminar Then 
                Dim a As LinkButton = CType(e.Row.FindControl("LinkButton1"), LinkButton)
                a.Attributes.Add("onclick", "if(!window.confirm('¿Esta seguro de Eliminar el Registro?')){return false;}")
            End If
            Dim lbDetalle As LinkButton 
            lbDetalle = e.Row.FindControl("LinkButtonDetalle") 
            Dim mLabelCODIGO_ETAPA As Label
            mLabelCODIGO_ETAPA = e.Row.FindControl("Label_CODIGO_ETAPA")
            mLabelCODIGO_ETAPA.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
            If Me.VerID_ESTADO_SOLICITUD Then
                Dim mDdlESTADO_SOLICITUD As SGAFP.WebUC.ddlESTADO_SOLICITUD
                mDdlESTADO_SOLICITUD = e.Row.FindControl("DdlESTADO_SOLICITUD1")
                If lDdlESTADO_SOLICITUD Is Nothing Then
                    lDdlESTADO_SOLICITUD = New SGAFP.WebUC.ddlESTADO_SOLICITUD
                    lDdlESTADO_SOLICITUD.Recuperar()
                End If
                Dim mESTADO_SOLICITUD As String
                mESTADO_SOLICITUD = CType(e.Row.FindControl("Label_ID_ESTADO_SOLICITUD1"), Label).Text
                Dim lItem As ListItem = lDdlESTADO_SOLICITUD.Items.FindByValue(mESTADO_SOLICITUD)
                If mESTADO_SOLICITUD <> "" And Not lItem Is Nothing Then
                    mDdlESTADO_SOLICITUD.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlESTADO_SOLICITUD.SelectedValue = mESTADO_SOLICITUD
                End If
            End If
            If Me.PermitirSeleccionar Then
                Dim a As LinkButton = CType(e.Row.FindControl("LinkButton_Seleccionar"), LinkButton)
                a.Text = Me.TextoSeleccionar
                a.CommandName = Me.ComandoSeleccionar
                If a.CommandName = "Check" Then
                    CType(e.Row.FindControl("CheckBox_Seleccionar"), CheckBox).Visible = True
                    a.Visible = False
                End If
            End If

        End If
    End Sub
 
    Private Sub gvLista_RowDeleting(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles gvLista.RowDeleting
        If Me.mComponente.EliminarETAPA(CODIGO_PROCESO, CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip) <> 1 Then
            'Si se cometio un error
            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            e.Cancel = True
        Else
            If Me.CargarDatos() <> 1 Then
                Me.AsignarMensaje("Error al Recuperar Lista", True, True)
            End If
        End If
    End Sub
 
    Private Sub gvLista_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles gvLista.SelectedIndexChanging
        RaiseEvent Seleccionado(CODIGO_PROCESO, CType(Me.gvLista.Rows(e.NewSelectedIndex).FindControl("LinkButton1"), LinkButton).ToolTip)
    End Sub

    Protected Sub gvLista_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvLista.PageIndexChanging
        Me.gvLista.PageIndex = e.NewPageIndex
        If Me.ViewState("PorPROCESO") Then
            Me.CargarDatosPorPROCESO(Me.ViewState("CODIGO_PROCESO"))
            Return
        End If
        If Me.ViewState("PorESTADO_SOLICITUD") Then
            Me.CargarDatosPorESTADO_SOLICITUD(Me.ViewState("ID_ESTADO_SOLICITUD"))
            Return
        End If
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As listaETAPA
        Dim mLista As New listaETAPA
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New ETAPA
                mEntidad.CODIGO_ETAPA = CInt(CType(mRow.FindControl("Label_CODIGO_ETAPA"), Label).Text)
                mEntidad.CODIGO_PROCESO = Me.CODIGO_PROCESO
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
