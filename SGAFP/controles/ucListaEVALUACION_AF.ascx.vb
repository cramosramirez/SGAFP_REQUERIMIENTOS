Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaEVALUACION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla EVALUACION_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaEVALUACION_AF
    Inherits ucBase
 
    Private mComponente As New cEVALUACION_AF
    Public Event Seleccionado(ByVal ID_EVALUACION_AF As Decimal) 
    Public Event Editando(ByVal ID_EVALUACION_AF As Decimal) 

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

    Public Property VerID_EVALUACION_AF() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerFECHA_EVALUACION() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerTEMA_EVALUACION() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerNOTAS() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerEVALUADOR() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerTIPO_EVALUACION() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerPORC_APROBACION() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property VerPORC_REPROBADOS() As Boolean
        Get
            Return Me.gvLista.Columns(9).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(9).Visible = Value
        End Set
    End Property

    Public Property HeaderID_EVALUACION_AF() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_ACCION_FORMATIVA() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderFECHA_EVALUACION() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTEMA_EVALUACION() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOTAS() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderEVALUADOR() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderTIPO_EVALUACION() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPORC_APROBACION() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPORC_REPROBADOS() As String
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
    ''' Función que Carga la información de los registros de la tabla EVALUACION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lEVALUACION_AF As listaEVALUACION_AF
        lEVALUACION_AF = Me.mComponente.ObtenerLista()
        If lEVALUACION_AF is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lEVALUACION_AF
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla EVALUACION_AF
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
        Dim lEVALUACION_AF As listaEVALUACION_AF
        lEVALUACION_AF = Me.mComponente.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA, False, False, "FECHA_EVALUACION")
        If lEVALUACION_AF is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorACCION_FORMATIVA") = True
        Me.ViewState("ID_ACCION_FORMATIVA") = ID_ACCION_FORMATIVA
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lEVALUACION_AF
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla EVALUACION_AF
    ''' filtrado por la tabla INFORME_FINAL_AF
    ''' </summary>
    ''' <param name="ID_INFORME_FINAL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	14/08/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorINFORME_FINAL_AF(ByVal ID_INFORME_FINAL As Decimal) As Integer
        Dim lEntidadInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(ID_INFORME_FINAL)
        Dim lEVALUACION_AF As listaEVALUACION_AF
        lEVALUACION_AF = Me.mComponente.ObtenerListaPorACCION_FORMATIVAPeriodo(lEntidadInforme.ID_ACCION_FORMATIVA, lEntidadInforme.FECHA_INICIAL, lEntidadInforme.FECHA_FINAL, "FECHA_EVALUACION")
        If lEVALUACION_AF Is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorINFORME_FINAL_AF") = True
        Me.ViewState("ID_INFORME_FINAL") = ID_INFORME_FINAL
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lEVALUACION_AF
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
            Dim mLabelID_EVALUACION_AF As Label
            mLabelID_EVALUACION_AF = e.Row.FindControl("Label_ID_EVALUACION_AF")
            mLabelID_EVALUACION_AF.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
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
            If Me.VerTIPO_EVALUACION Then
                Dim Label_tipo_evaluacion As Label = e.Row.FindControl("Label_tipo_evaluacion")
                Select Case Label_tipo_evaluacion.Text
                    Case "P"
                        Label_tipo_evaluacion.Text = "PRACTICA"
                    Case Else
                        Label_tipo_evaluacion.Text = "TEORICA"
                End Select
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
        If Me.mComponente.EliminarEVALUACION_AF(CDec(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
            'Si se cometio un error
            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            e.Cancel = True
        Else
            If Me.ViewState("PorACCION_FORMATIVA") Then
                Me.CargarDatosPorACCION_FORMATIVA(Me.ViewState("ID_ACCION_FORMATIVA"))
                Return
            ElseIf Me.ViewState("PorINFORME_FINAL_AF") IsNot Nothing AndAlso CBool(Me.ViewState("PorINFORME_FINAL_AF")) Then
                Me.CargarDatosPorINFORME_FINAL_AF(Me.ViewState("ID_INFORME_FINAL"))
                Return
            End If
        End If
    End Sub
 
    Private Sub gvLista_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles gvLista.SelectedIndexChanging
        RaiseEvent Seleccionado(CDec(CType(Me.gvLista.Rows(e.NewSelectedIndex).FindControl("LinkButton1"), LinkButton).ToolTip))
    End Sub

    Protected Sub gvLista_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvLista.PageIndexChanging
        Me.gvLista.PageIndex = e.NewPageIndex
        If Me.ViewState("PorACCION_FORMATIVA") Then
            Me.CargarDatosPorACCION_FORMATIVA(Me.ViewState("ID_ACCION_FORMATIVA"))
            Return
        ElseIf Me.ViewState("PorINFORME_FINAL_AF") Then
            Me.CargarDatosPorINFORME_FINAL_AF(Me.ViewState("ID_INFORME_FINAL"))
            Return
        Else
            Me.CargarDatos()
        End If
    End Sub

    Public Function DevolverSeleccionados() As listaEVALUACION_AF
        Dim mLista As New listaEVALUACION_AF
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New EVALUACION_AF
                mEntidad.ID_EVALUACION_AF = CInt(CType(mRow.FindControl("Label_ID_EVALUACION_AF"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

End Class
