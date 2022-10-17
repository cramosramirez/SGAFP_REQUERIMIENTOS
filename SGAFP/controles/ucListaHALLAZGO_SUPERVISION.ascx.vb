Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaHALLAZGO_SUPERVISION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla HALLAZGO_SUPERVISION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaHALLAZGO_SUPERVISION
    Inherits ucBase
 
    Private mComponente As New cHALLAZGO_SUPERVISION
    Public Event Seleccionado(ByVal ID_HALLAZGO_SUPERVISION As Decimal) 
    Public Event Editando(ByVal ID_HALLAZGO_SUPERVISION As Decimal) 

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

    Public Property VerID_HALLAZGO_SUPERVISION() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerID_AREA_SUPERVISION() As Boolean
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

    Public Property VerHALLAZGO_SUPERVISION() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerFECHA() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerTIPO_SANCION() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerTIEMPO_SANCION() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerMONTO_SANCION() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property VerTIEMPO_SUBSANACION() As Boolean
        Get
            Return Me.gvLista.Columns(9).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(9).Visible = Value
        End Set
    End Property

    Public Property HeaderID_HALLAZGO_SUPERVISION() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_AREA_SUPERVISION() As String
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

    Public Property HeaderHALLAZGO_SUPERVISION() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTIPO_SANCION() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTIEMPO_SANCION() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderMONTO_SANCION() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTIEMPO_SUBSANACION() As String
        Get
            Return Me.gvLista.Columns(9).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(9).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla HALLAZGO_SUPERVISION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lHALLAZGO_SUPERVISION As listaHALLAZGO_SUPERVISION
        lHALLAZGO_SUPERVISION = Me.mComponente.ObtenerLista()
        If lHALLAZGO_SUPERVISION is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lHALLAZGO_SUPERVISION
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla HALLAZGO_SUPERVISION
    ''' filtrado por la tabla AREA_SUPERVISION
    ''' </summary>
    ''' <param name="ID_AREA_SUPERVISION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorAREA_SUPERVISION(ByVal ID_AREA_SUPERVISION As Decimal) As Integer
        Dim lHALLAZGO_SUPERVISION As listaHALLAZGO_SUPERVISION
        lHALLAZGO_SUPERVISION = Me.mComponente.ObtenerListaPorAREA_SUPERVISION(ID_AREA_SUPERVISION)
        If lHALLAZGO_SUPERVISION is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorAREA_SUPERVISION") = True
        Me.ViewState("ID_AREA_SUPERVISION") = ID_AREA_SUPERVISION
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lHALLAZGO_SUPERVISION
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla HALLAZGO_SUPERVISION
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
        Dim lHALLAZGO_SUPERVISION As listaHALLAZGO_SUPERVISION
        lHALLAZGO_SUPERVISION = Me.mComponente.ObtenerListaPorSUPERVISION_AF(ID_SUPERVISION_AF)
        If lHALLAZGO_SUPERVISION is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorSUPERVISION_AF") = True
        Me.ViewState("ID_SUPERVISION_AF") = ID_SUPERVISION_AF
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lHALLAZGO_SUPERVISION
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

    Private lDdlAREA_SUPERVISION As SGAFP.WebUC.ddlAREA_SUPERVISION
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
            Dim mLabelID_HALLAZGO_SUPERVISION As Label
            mLabelID_HALLAZGO_SUPERVISION = e.Row.FindControl("Label_ID_HALLAZGO_SUPERVISION")
            mLabelID_HALLAZGO_SUPERVISION.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
            If Me.VerID_AREA_SUPERVISION Then
                Dim mDdlAREA_SUPERVISION As SGAFP.WebUC.ddlAREA_SUPERVISION
                mDdlAREA_SUPERVISION = e.Row.FindControl("DdlAREA_SUPERVISION1")
                If lDdlAREA_SUPERVISION Is Nothing Then
                    lDdlAREA_SUPERVISION = New SGAFP.WebUC.ddlAREA_SUPERVISION
                    lDdlAREA_SUPERVISION.Recuperar()
                End If
                Dim mAREA_SUPERVISION As String
                mAREA_SUPERVISION = CType(e.Row.FindControl("Label_ID_AREA_SUPERVISION1"), Label).Text
                Dim lItem As ListItem = lDdlAREA_SUPERVISION.Items.FindByValue(mAREA_SUPERVISION)
                If mAREA_SUPERVISION <> "" And Not lItem Is Nothing Then
                    mDdlAREA_SUPERVISION.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlAREA_SUPERVISION.SelectedValue = mAREA_SUPERVISION
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
        If Me.mComponente.EliminarHALLAZGO_SUPERVISION(CDec(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
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
        If Me.ViewState("PorAREA_SUPERVISION") Then
            Me.CargarDatosPorAREA_SUPERVISION(Me.ViewState("ID_AREA_SUPERVISION"))
            Return
        End If
        If Me.ViewState("PorSUPERVISION_AF") Then
            Me.CargarDatosPorSUPERVISION_AF(Me.ViewState("ID_SUPERVISION_AF"))
            Return
        End If
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As listaHALLAZGO_SUPERVISION
        Dim mLista As New listaHALLAZGO_SUPERVISION
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New HALLAZGO_SUPERVISION
                mEntidad.ID_HALLAZGO_SUPERVISION = CInt(CType(mRow.FindControl("Label_ID_HALLAZGO_SUPERVISION"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
