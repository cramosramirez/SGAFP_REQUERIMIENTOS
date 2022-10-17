Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaSUPERVISION_AF_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla SUPERVISION_AF_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaSUPERVISION_AF_DET
    Inherits ucBase
 
    Private mComponente As New cSUPERVISION_AF_DET
    Public Event Seleccionado(ByVal ID_SUPERVISION_DET As Decimal) 
    Public Event Editando(ByVal ID_SUPERVISION_DET As Decimal) 

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

    Public Property VerID_SUPERVISION_DET() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerID_LISTA_SUPERVISION() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerID_SUPERVISION_AF() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerCOMENTARIOS() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property HeaderID_SUPERVISION_DET() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_LISTA_SUPERVISION() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_SUPERVISION_AF() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCOMENTARIOS() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SUPERVISION_AF_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lSUPERVISION_AF_DET As listaSUPERVISION_AF_DET
        lSUPERVISION_AF_DET = Me.mComponente.ObtenerLista()
        If lSUPERVISION_AF_DET is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lSUPERVISION_AF_DET
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SUPERVISION_AF_DET
    ''' filtrado por la tabla LISTA_SUPERVISION_AF
    ''' </summary>
    ''' <param name="ID_LISTA_SUPERVISION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorLISTA_SUPERVISION_AF(ByVal ID_LISTA_SUPERVISION As Decimal) As Integer
        Dim lSUPERVISION_AF_DET As listaSUPERVISION_AF_DET
        lSUPERVISION_AF_DET = Me.mComponente.ObtenerListaPorLISTA_SUPERVISION_AF(ID_LISTA_SUPERVISION)
        If lSUPERVISION_AF_DET is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorLISTA_SUPERVISION_AF") = True
        Me.ViewState("ID_LISTA_SUPERVISION") = ID_LISTA_SUPERVISION
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lSUPERVISION_AF_DET
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SUPERVISION_AF_DET
    ''' filtrado por la tabla SUPERVISION_AF
    ''' </summary>
    ''' <param name="ID_SUPERVISION_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSUPERVISION_AF(ByVal ID_SUPERVISION_AF As Decimal) As Integer
        Dim lSUPERVISION_AF_DET As listaSUPERVISION_AF_DET
        lSUPERVISION_AF_DET = Me.mComponente.ObtenerListaPorSUPERVISION_AF(ID_SUPERVISION_AF)
        If lSUPERVISION_AF_DET is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorSUPERVISION_AF") = True
        Me.ViewState("ID_SUPERVISION_AF") = ID_SUPERVISION_AF
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lSUPERVISION_AF_DET
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
    End Sub

    Private lDdlLISTA_SUPERVISION_AF As SGAFP.WebUC.ddlLISTA_SUPERVISION_AF
    Private lDdlSUPERVISION_AF As SGAFP.WebUC.ddlSUPERVISION_AF

    Protected Sub gvLista_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLista.RowCommand
        If e.CommandName = "Editar" Then
            RaiseEvent Editando(CInt(e.CommandArgument))
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
            Dim mLabelID_SUPERVISION_DET As Label
            mLabelID_SUPERVISION_DET = e.Row.FindControl("Label_ID_SUPERVISION_DET")
            mLabelID_SUPERVISION_DET.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
            If Me.VerID_LISTA_SUPERVISION Then
                Dim mDdlLISTA_SUPERVISION_AF As SGAFP.WebUC.ddlLISTA_SUPERVISION_AF
                mDdlLISTA_SUPERVISION_AF = e.Row.FindControl("DdlLISTA_SUPERVISION_AF1")
                If lDdlLISTA_SUPERVISION_AF Is Nothing Then
                    lDdlLISTA_SUPERVISION_AF = New SGAFP.WebUC.ddlLISTA_SUPERVISION_AF
                    lDdlLISTA_SUPERVISION_AF.Recuperar()
                End If
                Dim mLISTA_SUPERVISION_AF As String
                mLISTA_SUPERVISION_AF = CType(e.Row.FindControl("Label_ID_LISTA_SUPERVISION1"), Label).Text
                Dim lItem As ListItem = lDdlLISTA_SUPERVISION_AF.Items.FindByValue(mLISTA_SUPERVISION_AF)
                If mLISTA_SUPERVISION_AF <> "" And Not lItem Is Nothing Then
                    mDdlLISTA_SUPERVISION_AF.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlLISTA_SUPERVISION_AF.SelectedValue = mLISTA_SUPERVISION_AF
                End If
            End If
            If Me.VerID_SUPERVISION_AF Then
                Dim mDdlSUPERVISION_AF As SGAFP.WebUC.ddlSUPERVISION_AF
                mDdlSUPERVISION_AF = e.Row.FindControl("DdlSUPERVISION_AF1")
                If lDdlSUPERVISION_AF Is Nothing Then
                    lDdlSUPERVISION_AF = New SGAFP.WebUC.ddlSUPERVISION_AF
                    lDdlSUPERVISION_AF.Recuperar()
                End If
                Dim mSUPERVISION_AF As String
                mSUPERVISION_AF = CType(e.Row.FindControl("Label_ID_SUPERVISION_AF1"), Label).Text
                Dim lItem As ListItem = lDdlSUPERVISION_AF.Items.FindByValue(mSUPERVISION_AF)
                If mSUPERVISION_AF <> "" And Not lItem Is Nothing Then
                    mDdlSUPERVISION_AF.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlSUPERVISION_AF.SelectedValue = mSUPERVISION_AF
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
        If Me.mComponente.EliminarSUPERVISION_AF_DET(CDec(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
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
        RaiseEvent Seleccionado(CDec(CType(Me.gvLista.Rows(e.NewSelectedIndex).FindControl("LinkButton1"), LinkButton).ToolTip))
    End Sub

    Protected Sub gvLista_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvLista.PageIndexChanging
        Me.gvLista.PageIndex = e.NewPageIndex
        If Me.ViewState("PorLISTA_SUPERVISION_AF") Then
            Me.CargarDatosPorLISTA_SUPERVISION_AF(Me.ViewState("ID_LISTA_SUPERVISION"))
            Return
        End If
        If Me.ViewState("PorSUPERVISION_AF") Then
            Me.CargarDatosPorSUPERVISION_AF(Me.ViewState("ID_SUPERVISION_AF"))
            Return
        End If
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As listaSUPERVISION_AF_DET
        Dim mLista As New listaSUPERVISION_AF_DET
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New SUPERVISION_AF_DET
                mEntidad.ID_SUPERVISION_DET = CInt(CType(mRow.FindControl("Label_ID_SUPERVISION_DET"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
