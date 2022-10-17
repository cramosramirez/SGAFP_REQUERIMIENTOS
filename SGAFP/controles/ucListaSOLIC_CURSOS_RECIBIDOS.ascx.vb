Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaSOLIC_CURSOS_RECIBIDOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla SOLIC_CURSOS_RECIBIDOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaSOLIC_CURSOS_RECIBIDOS
    Inherits ucBase
 
    Private mComponente As New cSOLIC_CURSOS_RECIBIDOS
    Public Event Seleccionado(ByVal ID_CURSO_RECIBIDO As Decimal) 
    Public Event Editando(ByVal ID_CURSO_RECIBIDO As Decimal) 
    Public Event Editar As EventHandler

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

    Public Property VerID_CURSO_RECIBIDO() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerID_SOLICITUD() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerNOMBRE_CURSO() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerINSTITUCION_CURSO() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerAPOYO_INSAFORP() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerANIO() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property HeaderID_CURSO_RECIBIDO() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_SOLICITUD() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOMBRE_CURSO() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderINSTITUCION_CURSO() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderAPOYO_INSAFORP() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderANIO() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLIC_CURSOS_RECIBIDOS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lSOLIC_CURSOS_RECIBIDOS As listaSOLIC_CURSOS_RECIBIDOS
        lSOLIC_CURSOS_RECIBIDOS = Me.mComponente.ObtenerLista()
        If lSOLIC_CURSOS_RECIBIDOS is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lSOLIC_CURSOS_RECIBIDOS
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLIC_CURSOS_RECIBIDOS
    ''' filtrado por la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorSOLICITUD_INSCRIPCION_AF(ByVal ID_SOLICITUD As Decimal) As Integer
        'Dim lSOLIC_CURSOS_RECIBIDOS As listaSOLIC_CURSOS_RECIBIDOS
        'lSOLIC_CURSOS_RECIBIDOS = Me.mComponente.ObtenerListaPorSOLICITUD_INSCRIPCION_AF(ID_SOLICITUD)
        'If lSOLIC_CURSOS_RECIBIDOS is Nothing Then
        '    Me.gvLista.Visible = False
        '    Return -1
        'End If
        Me.ViewState("PorSOLICITUD_INSCRIPCION_AF") = True
        Me.ViewState("ID_SOLICITUD") = ID_SOLICITUD
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        'Me.gvLista.DataSource = lSOLIC_CURSOS_RECIBIDOS
        'Me.gvLista.DataBind()

        Me.gvLista.DataSourceID = "odsListaPorSOLICITUD_INSCRIPCION_AF"
        'Me.gvLista.data
        Me.odsListaPorSOLICITUD_INSCRIPCION_AF.SelectParameters("ID_SOLICITUD").DefaultValue = ID_SOLICITUD
        Me.odsListaPorSOLICITUD_INSCRIPCION_AF.DataBind()
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

    Private lDdlSOLICITUD_INSCRIPCION_AF As SGAFP.WebUC.ddlSOLICITUD_INSCRIPCION_AF

    Protected Sub gvLista_RowCancelingEdit(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCancelEditEventArgs) Handles gvLista.RowCancelingEdit
        Me.gvLista.EditIndex = -1
        RaiseEvent Editar(gvLista, New System.EventArgs())
    End Sub

    Protected Sub gvLista_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvLista.RowCommand
        If e.CommandName = "Editar" Then
            RaiseEvent Editando(CInt(e.CommandArgument))
        End If
        If e.CommandName = "Agregar" Then
            Me.Agregar()
        End If
        If e.CommandName = "Eliminar" Then
            If Me.mComponente.EliminarSOLIC_CURSOS_RECIBIDOS(CDec(e.CommandArgument)) <> 1 Then
                'Si se cometio un error
                Me.AsignarMensaje("Error al Eliminar Registro", True, True)
                'e.Cancel = True
            Else
                If Me.ViewState("PorSOLICITUD_INSCRIPCION_AF") Then
                    Me.CargarDatosPorSOLICITUD_INSCRIPCION_AF(Me.ViewState("ID_SOLICITUD"))
                    Return
                End If
                If Me.CargarDatos() <> 1 Then
                    Me.AsignarMensaje("Error al Recuperar Lista", True, True)
                End If
            End If
        End If
    End Sub

    Protected Sub gvLista_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvLista.RowDataBound
        If Not LoadDataEmpty And e.Row.RowType = DataControlRowType.DataRow Then
            If Me.PermitirEliminar Then
                Dim a As LinkButton = CType(e.Row.FindControl("LinkButton1"), LinkButton)
                If Not a Is Nothing Then
                    a.Attributes.Add("onclick", "if(!window.confirm('¿Esta seguro de Eliminar el Registro?')){return false;}")
                End If
            End If
            Dim lbDetalle As LinkButton
            lbDetalle = e.Row.FindControl("LinkButtonDetalle")
            Dim mLabelID_CURSO_RECIBIDO As Label
            mLabelID_CURSO_RECIBIDO = e.Row.FindControl("Label_ID_CURSO_RECIBIDO")
            mLabelID_CURSO_RECIBIDO.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
            If Me.VerID_SOLICITUD Then
                Dim mDdlSOLICITUD_INSCRIPCION_AF As SGAFP.WebUC.ddlSOLICITUD_INSCRIPCION_AF
                mDdlSOLICITUD_INSCRIPCION_AF = e.Row.FindControl("DdlSOLICITUD_INSCRIPCION_AF1")
                If lDdlSOLICITUD_INSCRIPCION_AF Is Nothing Then
                    lDdlSOLICITUD_INSCRIPCION_AF = New SGAFP.WebUC.ddlSOLICITUD_INSCRIPCION_AF
                    lDdlSOLICITUD_INSCRIPCION_AF.Recuperar()
                End If
                Dim mSOLICITUD_INSCRIPCION_AF As String
                mSOLICITUD_INSCRIPCION_AF = CType(e.Row.FindControl("Label_ID_SOLICITUD1"), Label).Text
                Dim lItem As ListItem = lDdlSOLICITUD_INSCRIPCION_AF.Items.FindByValue(mSOLICITUD_INSCRIPCION_AF)
                If mSOLICITUD_INSCRIPCION_AF <> "" And Not lItem Is Nothing Then
                    mDdlSOLICITUD_INSCRIPCION_AF.Items.Add(New ListItem(lItem.Text, lItem.Value))
                    mDdlSOLICITUD_INSCRIPCION_AF.SelectedValue = mSOLICITUD_INSCRIPCION_AF
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
        If Me.mComponente.EliminarSOLIC_CURSOS_RECIBIDOS(CDec(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
            'Si se cometio un error
            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            e.Cancel = True
        Else
            If Me.ViewState("PorSOLICITUD_INSCRIPCION_AF") Then
                Me.CargarDatosPorSOLICITUD_INSCRIPCION_AF(Me.ViewState("ID_SOLICITUD"))
                Return
            End If
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
        If Me.ViewState("PorSOLICITUD_INSCRIPCION_AF") Then
            Me.CargarDatosPorSOLICITUD_INSCRIPCION_AF(Me.ViewState("ID_SOLICITUD"))
            Return
        End If
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As listaSOLIC_CURSOS_RECIBIDOS
        Dim mLista As New listaSOLIC_CURSOS_RECIBIDOS
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New SOLIC_CURSOS_RECIBIDOS
                mEntidad.ID_CURSO_RECIBIDO = CInt(CType(mRow.FindControl("Label_ID_CURSO_RECIBIDO"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

    Private Property LoadDataEmpty() As Boolean
        Get
            If ViewState("LoadDataEmpty") Is Nothing Then Return False
            Return ViewState("LoadDataEmpty")
        End Get
        Set(ByVal value As Boolean)
            ViewState("LoadDataEmpty") = value
        End Set
    End Property

    Protected Sub gvLista_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gvLista.RowCreated
        If LoadDataEmpty And e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Visible = False
            e.Row.Controls.Clear()
        End If
    End Sub

    Private Sub Agregar()
        Page.Validate("AgregarCursoRecibido")
        If Not Page.IsValid Then Return

        Dim NOMBRE_CURSO As String = CType(gvLista.FooterRow.FindControl("NOMBRE_CURSOTextBox"), TextBox).Text
        Dim INSTITUCION_CURSO As String = CType(gvLista.FooterRow.FindControl("INSTITUCION_CURSOTextBox"), TextBox).Text
        Dim ANIO As String = CType(gvLista.FooterRow.FindControl("ANIOTextBox"), TextBox).Text
        Dim APOYO_INSAFORP As String = CType(gvLista.FooterRow.FindControl("APOYO_INSAFORPDropDownList"), DropDownList).SelectedValue.ToString()

        If Me.ViewState("ID_SOLICITUD") <> 0 Then
            If (New cSOLIC_CURSOS_RECIBIDOS).AgregarSOLIC_CURSOS_RECIBIDOS(0, Me.ViewState("ID_SOLICITUD"), NOMBRE_CURSO, INSTITUCION_CURSO, ANIO, APOYO_INSAFORP) < 1 Then

            End If
        Else

        End If

        'ObjectDataSourceMain.InsertParameters["ID_SOLICITUD"].DefaultValue = this.IdSolicitud.ToString();
        'ObjectDataSourceMain.InsertParameters["ID_CURSO_RECIBIDO"].DefaultValue = 0.ToString();
        'ObjectDataSourceMain.InsertParameters["NOMBRE_CURSO"].DefaultValue = NOMBRE_CURSO;
        'ObjectDataSourceMain.InsertParameters["INSTITUCION_CURSO"].DefaultValue = INSTITUCION_CURSO;
        'ObjectDataSourceMain.InsertParameters["ANIO"].DefaultValue = ANIO;
        'ObjectDataSourceMain.InsertParameters["APOYO_INSAFORP"].DefaultValue = APOYO_INSAFORP;
        'ObjectDataSourceMain.Insert();
        If Me.ViewState("PorSOLICITUD_INSCRIPCION_AF") Then
            Me.CargarDatosPorSOLICITUD_INSCRIPCION_AF(Me.ViewState("ID_SOLICITUD"))
            Return
        End If
        Me.CargarDatos()

    End Sub

    Protected Sub gvLista_RowEditing(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewEditEventArgs) Handles gvLista.RowEditing
        Me.gvLista.EditIndex = e.NewEditIndex
        'RaiseEvent Editando(Me.gvLista.DataKeys(e.NewEditIndex).Value)
        RaiseEvent Editar(gvLista, New System.EventArgs())
    End Sub

    Protected Sub gvLista_RowUpdating(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewUpdateEventArgs) Handles gvLista.RowUpdating
        Dim a As Integer = 0
        'e.OldValues
        Me.gvLista.EditIndex = -1
        RaiseEvent Editar(gvLista, New System.EventArgs())
    End Sub

    Protected Sub odsListaPorSOLICITUD_INSCRIPCION_AF_Selected(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceStatusEventArgs) Handles odsListaPorSOLICITUD_INSCRIPCION_AF.Selected
        If Not e.Exception Is Nothing Then
            Throw e.Exception
        End If

        '//  get the DataTable from the ODS select mothod
        Dim dataTable As SGAFP.EL.listaSOLIC_CURSOS_RECIBIDOS = CType(e.ReturnValue, SGAFP.EL.listaSOLIC_CURSOS_RECIBIDOS)
        Dim dr As SGAFP.EL.SOLIC_CURSOS_RECIBIDOS
        '//  if rows=0 then add a dummy (null) row and set the LoadDataEmpty flag.
        If (dataTable.Count = 0) Then

            dr = New SGAFP.EL.SOLIC_CURSOS_RECIBIDOS()
            dr.ID_CURSO_RECIBIDO = 0
            dataTable.Add(dr)
            LoadDataEmpty = True

        Else

            LoadDataEmpty = False
        End If
    End Sub
End Class
