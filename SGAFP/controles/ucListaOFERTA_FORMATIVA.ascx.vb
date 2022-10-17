Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaOFERTA_FORMATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla OFERTA_FORMATIVA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaOFERTA_FORMATIVA
    Inherits ucListaBase
 
    Private mComponente As New cOFERTA_FORMATIVA
    Public Event Seleccionado(ByVal ID_OFERTA_FORMATIVA As Decimal) 
    Public Event Editando(ByVal ID_OFERTA_FORMATIVA As Decimal) 

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

    Public Property VerID_OFERTA_FORMATIVA() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerID_EJERCICIO() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerID_TEMA_CURSO() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerID_PROVEEDOR_AF() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerDURACION_HORAS() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerCOSTO_X_PARTICIPANTE() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_INICIO() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_FIN() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property VerNOTAS() As Boolean
        Get
            Return Me.gvLista.Columns(9).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(9).Visible = Value
        End Set
    End Property

    Public Property VerESTADO() As Boolean
        Get
            Return Me.gvLista.Columns(10).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(10).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_APROBACION() As Boolean
        Get
            Return Me.gvLista.Columns(11).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(11).Visible = Value
        End Set
    End Property

    Public Property VerUSUARIO_APROBACION() As Boolean
        Get
            Return Me.gvLista.Columns(12).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(12).Visible = Value
        End Set
    End Property

    Public Property VerUSERID() As Boolean
        Get
            Return Me.gvLista.Columns(13).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(13).Visible = Value
        End Set
    End Property

    Public Property VerLASTUPDATE() As Boolean
        Get
            Return Me.gvLista.Columns(14).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(14).Visible = Value
        End Set
    End Property

    Public Property HeaderID_OFERTA_FORMATIVA() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_EJERCICIO() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_TEMA_CURSO() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_PROVEEDOR_AF() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDURACION_HORAS() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCOSTO_X_PARTICIPANTE() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_INICIO() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_FIN() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOTAS() As String
        Get
            Return Me.gvLista.Columns(9).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(9).HeaderText = Value
        End Set
    End Property

    Public Property HeaderESTADO() As String
        Get
            Return Me.gvLista.Columns(10).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(10).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_APROBACION() As String
        Get
            Return Me.gvLista.Columns(11).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(11).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSUARIO_APROBACION() As String
        Get
            Return Me.gvLista.Columns(12).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(12).HeaderText = Value
        End Set
    End Property

    Public Property HeaderUSERID() As String
        Get
            Return Me.gvLista.Columns(13).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(13).HeaderText = Value
        End Set
    End Property

    Public Property HeaderLASTUPDATE() As String
        Get
            Return Me.gvLista.Columns(14).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(14).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla OFERTA_FORMATIVA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lOFERTA_FORMATIVA As listaOFERTA_FORMATIVA
        lOFERTA_FORMATIVA = Me.mComponente.ObtenerLista()
        If lOFERTA_FORMATIVA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lOFERTA_FORMATIVA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla OFERTA_FORMATIVA
    ''' filtrado por la tabla EJERCICIO
    ''' </summary>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorEJERCICIO(ByVal ID_EJERCICIO As String) As Integer
        Dim lOFERTA_FORMATIVA As listaOFERTA_FORMATIVA
        lOFERTA_FORMATIVA = Me.mComponente.ObtenerListaPorEJERCICIO(ID_EJERCICIO)
        If lOFERTA_FORMATIVA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorEJERCICIO") = True
        Me.ViewState("ID_EJERCICIO") = ID_EJERCICIO
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lOFERTA_FORMATIVA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla OFERTA_FORMATIVA
    ''' filtrado por la tabla CURSO_TEMA
    ''' </summary>
    ''' <param name="ID_TEMA_CURSO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCURSO_TEMA(ByVal ID_TEMA_CURSO As Decimal) As Integer
        Dim lOFERTA_FORMATIVA As listaOFERTA_FORMATIVA
        lOFERTA_FORMATIVA = Me.mComponente.ObtenerListaPorCURSO_TEMA(ID_TEMA_CURSO)
        If lOFERTA_FORMATIVA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorCURSO_TEMA") = True
        Me.ViewState("ID_TEMA_CURSO") = ID_TEMA_CURSO
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lOFERTA_FORMATIVA
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla OFERTA_FORMATIVA
    ''' filtrado por la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal) As Integer
        Dim lOFERTA_FORMATIVA As listaOFERTA_FORMATIVA
        lOFERTA_FORMATIVA = Me.mComponente.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF)
        If lOFERTA_FORMATIVA is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorPROVEEDOR_AF") = True
        Me.ViewState("ID_PROVEEDOR_AF") = ID_PROVEEDOR_AF
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lOFERTA_FORMATIVA
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

    Private lDdlEJERCICIO As SGAFP.WebUC.ddlEJERCICIO
    Private lDdlCURSO_TEMA As SGAFP.WebUC.ddlCURSO_TEMA
    Private lDdlPROVEEDOR_AF As SGAFP.WebUC.ddlPROVEEDOR_AF

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
            Dim mLabelID_OFERTA_FORMATIVA As Label
            mLabelID_OFERTA_FORMATIVA = e.Row.FindControl("Label_ID_OFERTA_FORMATIVA")
            mLabelID_OFERTA_FORMATIVA.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
            If Me.VerID_EJERCICIO Then
                Dim mDdlEJERCICIO As SGAFP.WebUC.ddlEJERCICIO
                mDdlEJERCICIO = e.Row.FindControl("DdlEJERCICIO1")
                If lDdlEJERCICIO Is Nothing Then
                    lDdlEJERCICIO = New SGAFP.WebUC.ddlEJERCICIO
                    lDdlEJERCICIO.Recuperar()
                End If
                Dim mEJERCICIO As String
                mEJERCICIO = CType(e.Row.FindControl("Label_ID_EJERCICIO1"), Label).Text
                Dim lItem As ListItem = lDdlEJERCICIO.Items.FindByValue(mEJERCICIO)
                If mEJERCICIO <> "" And Not lItem Is Nothing Then
                    mDdlEJERCICIO.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlEJERCICIO.SelectedValue = mEJERCICIO
                End If
            End If
            If Me.VerID_TEMA_CURSO Then
                Dim mDdlCURSO_TEMA As SGAFP.WebUC.ddlCURSO_TEMA
                If e.Row.RowState = DataControlRowState.Edit Then
                    mDdlCURSO_TEMA = e.Row.FindControl("DdlCURSO_TEMA1")
                    If lDdlCURSO_TEMA Is Nothing Then
                        lDdlCURSO_TEMA = New SGAFP.WebUC.ddlCURSO_TEMA
                        lDdlCURSO_TEMA.Recuperar()
                    End If
                End If
                Dim mCURSO_TEMA As String
                mCURSO_TEMA = CType(e.Row.FindControl("Label_ID_TEMA_CURSO1"), Label).Text
                If e.Row.RowState = DataControlRowState.Edit Then
                    Dim lItem As ListItem = lDdlCURSO_TEMA.Items.FindByValue(mCURSO_TEMA)
                    If mCURSO_TEMA <> "" And Not lItem Is Nothing Then
                        mDdlCURSO_TEMA.Items.Add(New ListItem(lItem.Text, lItem.Value))
                        mDdlCURSO_TEMA.SelectedValue = mCURSO_TEMA
                    End If
                End If
            End If
            If Me.VerID_PROVEEDOR_AF Then
                Dim mDdlPROVEEDOR_AF As SGAFP.WebUC.ddlPROVEEDOR_AF
                If e.Row.RowState = DataControlRowState.Edit Then
                    mDdlPROVEEDOR_AF = e.Row.FindControl("DdlPROVEEDOR_AF1")
                    If lDdlPROVEEDOR_AF Is Nothing Then
                        lDdlPROVEEDOR_AF = New SGAFP.WebUC.ddlPROVEEDOR_AF
                        lDdlPROVEEDOR_AF.Recuperar()
                    End If
                End If
                Dim mPROVEEDOR_AF As String
                mPROVEEDOR_AF = CType(e.Row.FindControl("Label_ID_PROVEEDOR_AF1"), Label).Text
                If e.Row.RowState = DataControlRowState.Edit Then
                    Dim lItem As ListItem = lDdlPROVEEDOR_AF.Items.FindByValue(mPROVEEDOR_AF)
                    If mPROVEEDOR_AF <> "" And Not lItem Is Nothing Then
                        mDdlPROVEEDOR_AF.Items.Add(New ListItem(lItem.Text, lItem.Value))
                        mDdlPROVEEDOR_AF.SelectedValue = mPROVEEDOR_AF
                    End If
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
        If Me.mComponente.EliminarOFERTA_FORMATIVA(CDec(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
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
        If Me.ViewState("PorEJERCICIO") Then
            Me.CargarDatosPorEJERCICIO(Me.ViewState("ID_EJERCICIO"))
            Return
        End If
        If Me.ViewState("PorCURSO_TEMA") Then
            Me.CargarDatosPorCURSO_TEMA(Me.ViewState("ID_TEMA_CURSO"))
            Return
        End If
        If Me.ViewState("PorPROVEEDOR_AF") Then
            Me.CargarDatosPorPROVEEDOR_AF(Me.ViewState("ID_PROVEEDOR_AF"))
            Return
        End If
        If Me.ViewState("PorCriterios") Then
            Me.CargarDatosPorCriterios(Me.ViewState("aCriterios"))
            Return
        End If
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As listaOFERTA_FORMATIVA
        Dim mLista As New listaOFERTA_FORMATIVA
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New OFERTA_FORMATIVA
                mEntidad.ID_OFERTA_FORMATIVA = CInt(CType(mRow.FindControl("Label_ID_OFERTA_FORMATIVA"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla OFERTA_FORMATIVA
    ''' filtrado por los Criterios de Busqueda Recibidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	17/03/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorCriterios(ByVal aCriterios() As Criteria) As Integer
        Dim lOFERTA_FORMATIVA As listaOFERTA_FORMATIVA
        lOFERTA_FORMATIVA = Me.mComponente.ObtenerOfertaFormativaPorCriterios(aCriterios)
        If lOFERTA_FORMATIVA Is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorCriterios") = True
        Me.ViewState("aCriterios") = aCriterios
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lOFERTA_FORMATIVA
        Me.gvLista.DataBind()
        Return 1
    End Function

End Class
