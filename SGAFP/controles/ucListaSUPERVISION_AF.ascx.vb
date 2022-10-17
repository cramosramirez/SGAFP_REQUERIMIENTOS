Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaSUPERVISION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla SUPERVISION_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaSUPERVISION_AF
    Inherits ucBase
 
    Private mComponente As New cSUPERVISION_AF
    Public Event Seleccionado(ByVal ID_SUPERVISION_AF As Decimal) 
    Public Event Editando(ByVal ID_SUPERVISION_AF As Decimal) 

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

    Public Property VerID_SUPERVISION_AF() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerID_MODALIDAD_FORMACION() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerFECHA() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_AF() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerCENTRO_FORMACION() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerOPCION() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerGRUPO() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property VerHORARIO() As Boolean
        Get
            Return Me.gvLista.Columns(9).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(9).Visible = Value
        End Set
    End Property

    Public Property VerCODIGO() As Boolean
        Get
            Return Me.gvLista.Columns(10).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(10).Visible = Value
        End Set
    End Property

    Public Property VerCOORDINADOR_CFP() As Boolean
        Get
            Return Me.gvLista.Columns(11).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(11).Visible = Value
        End Set
    End Property

    Public Property VerDIRECTOR_CFP() As Boolean
        Get
            Return Me.gvLista.Columns(12).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(12).Visible = Value
        End Set
    End Property

    Public Property VerPARTICIPANTES_PRESENTES() As Boolean
        Get
            Return Me.gvLista.Columns(13).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(13).Visible = Value
        End Set
    End Property

    Public Property VerPARTICIPANTES_AUSENTES() As Boolean
        Get
            Return Me.gvLista.Columns(14).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(14).Visible = Value
        End Set
    End Property

    Public Property VerPARTICIPANTES_INSCRITOS() As Boolean
        Get
            Return Me.gvLista.Columns(15).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(15).Visible = Value
        End Set
    End Property

    Public Property VerPARTICIPANTES_DESERTADOS() As Boolean
        Get
            Return Me.gvLista.Columns(16).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(16).Visible = Value
        End Set
    End Property

    Public Property VerPARTICIPANTES_SUPLENTES() As Boolean
        Get
            Return Me.gvLista.Columns(17).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(17).Visible = Value
        End Set
    End Property

    Public Property VerOBJETIVO_VISITA() As Boolean
        Get
            Return Me.gvLista.Columns(18).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(18).Visible = Value
        End Set
    End Property

    Public Property VerNOTAS() As Boolean
        Get
            Return Me.gvLista.Columns(19).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(19).Visible = Value
        End Set
    End Property

    Public Property VerDURACION_VISITA() As Boolean
        Get
            Return Me.gvLista.Columns(20).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(20).Visible = Value
        End Set
    End Property

    Public Property HeaderID_SUPERVISION_AF() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_MODALIDAD_FORMACION() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_ACCION_FORMATIVA() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOMBRE_AF() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCENTRO_FORMACION() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderOPCION() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderGRUPO() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

    Public Property HeaderHORARIO() As String
        Get
            Return Me.gvLista.Columns(9).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(9).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCODIGO() As String
        Get
            Return Me.gvLista.Columns(10).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(10).HeaderText = Value
        End Set
    End Property

    Public Property HeaderCOORDINADOR_CFP() As String
        Get
            Return Me.gvLista.Columns(11).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(11).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDIRECTOR_CFP() As String
        Get
            Return Me.gvLista.Columns(12).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(12).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPARTICIPANTES_PRESENTES() As String
        Get
            Return Me.gvLista.Columns(13).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(13).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPARTICIPANTES_AUSENTES() As String
        Get
            Return Me.gvLista.Columns(14).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(14).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPARTICIPANTES_INSCRITOS() As String
        Get
            Return Me.gvLista.Columns(15).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(15).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPARTICIPANTES_DESERTADOS() As String
        Get
            Return Me.gvLista.Columns(16).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(16).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPARTICIPANTES_SUPLENTES() As String
        Get
            Return Me.gvLista.Columns(17).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(17).HeaderText = Value
        End Set
    End Property

    Public Property HeaderOBJETIVO_VISITA() As String
        Get
            Return Me.gvLista.Columns(18).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(18).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOTAS() As String
        Get
            Return Me.gvLista.Columns(19).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(19).HeaderText = Value
        End Set
    End Property

    Public Property HeaderDURACION_VISITA() As String
        Get
            Return Me.gvLista.Columns(20).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(20).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SUPERVISION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lSUPERVISION_AF As listaSUPERVISION_AF
        lSUPERVISION_AF = Me.mComponente.ObtenerLista()
        If lSUPERVISION_AF is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lSUPERVISION_AF
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SUPERVISION_AF
    ''' filtrado por la tabla MODALIDAD_DE_FORMACION
    ''' </summary>
    ''' <param name="ID_MODALIDAD_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorMODALIDAD_DE_FORMACION(ByVal ID_MODALIDAD_FORMACION As Decimal) As Integer
        Dim lSUPERVISION_AF As listaSUPERVISION_AF
        lSUPERVISION_AF = Me.mComponente.ObtenerListaPorMODALIDAD_DE_FORMACION(ID_MODALIDAD_FORMACION)
        If lSUPERVISION_AF is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorMODALIDAD_DE_FORMACION") = True
        Me.ViewState("ID_MODALIDAD_FORMACION") = ID_MODALIDAD_FORMACION
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lSUPERVISION_AF
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SUPERVISION_AF
    ''' filtrado por la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Dim lSUPERVISION_AF As listaSUPERVISION_AF
        lSUPERVISION_AF = Me.mComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If lSUPERVISION_AF is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorACCION_FORMATIVA") = True
        Me.ViewState("ID_ACCION_FORMATIVA") = ID_ACCION_FORMATIVA
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lSUPERVISION_AF
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

    Private lDdlMODALIDAD_DE_FORMACION As SGAFP.WebUC.ddlMODALIDAD_DE_FORMACION
    Private lDdlACCION_FORMATIVA As SGAFP.WebUC.ddlACCION_FORMATIVA

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
            Dim mLabelID_SUPERVISION_AF As Label
            mLabelID_SUPERVISION_AF = e.Row.FindControl("Label_ID_SUPERVISION_AF")
            mLabelID_SUPERVISION_AF.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
            If Me.VerID_MODALIDAD_FORMACION Then
                Dim mDdlMODALIDAD_DE_FORMACION As SGAFP.WebUC.ddlMODALIDAD_DE_FORMACION
                mDdlMODALIDAD_DE_FORMACION = e.Row.FindControl("DdlMODALIDAD_DE_FORMACION1")
                If lDdlMODALIDAD_DE_FORMACION Is Nothing Then
                    lDdlMODALIDAD_DE_FORMACION = New SGAFP.WebUC.ddlMODALIDAD_DE_FORMACION
                    lDdlMODALIDAD_DE_FORMACION.Recuperar()
                End If
                Dim mMODALIDAD_DE_FORMACION As String
                mMODALIDAD_DE_FORMACION = CType(e.Row.FindControl("Label_ID_MODALIDAD_FORMACION1"), Label).Text
                Dim lItem As ListItem = lDdlMODALIDAD_DE_FORMACION.Items.FindByValue(mMODALIDAD_DE_FORMACION)
                If mMODALIDAD_DE_FORMACION <> "" And Not lItem Is Nothing Then
                    mDdlMODALIDAD_DE_FORMACION.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlMODALIDAD_DE_FORMACION.SelectedValue = mMODALIDAD_DE_FORMACION
                End If
            End If
            If Me.VerID_ACCION_FORMATIVA Then
                Dim mDdlACCION_FORMATIVA As SGAFP.WebUC.ddlACCION_FORMATIVA
                mDdlACCION_FORMATIVA = e.Row.FindControl("DdlACCION_FORMATIVA1")
                If lDdlACCION_FORMATIVA Is Nothing Then
                    lDdlACCION_FORMATIVA = New SGAFP.WebUC.ddlACCION_FORMATIVA
                    lDdlACCION_FORMATIVA.Recuperar()
                End If
                Dim mACCION_FORMATIVA As String
                mACCION_FORMATIVA = CType(e.Row.FindControl("Label_ID_ACCION_FORMATIVA1"), Label).Text
                Dim lItem As ListItem = lDdlACCION_FORMATIVA.Items.FindByValue(mACCION_FORMATIVA)
                If mACCION_FORMATIVA <> "" And Not lItem Is Nothing Then
                    mDdlACCION_FORMATIVA.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlACCION_FORMATIVA.SelectedValue = mACCION_FORMATIVA
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
        If Me.mComponente.EliminarSUPERVISION_AF(CDec(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
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
        If Me.ViewState("PorMODALIDAD_DE_FORMACION") Then
            Me.CargarDatosPorMODALIDAD_DE_FORMACION(Me.ViewState("ID_MODALIDAD_FORMACION"))
            Return
        End If
        If Me.ViewState("PorACCION_FORMATIVA") Then
            Me.CargarDatosPorACCION_FORMATIVA(Me.ViewState("ID_ACCION_FORMATIVA"))
            Return
        End If
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As listaSUPERVISION_AF
        Dim mLista As New listaSUPERVISION_AF
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New SUPERVISION_AF
                mEntidad.ID_SUPERVISION_AF = CInt(CType(mRow.FindControl("Label_ID_SUPERVISION_AF"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
