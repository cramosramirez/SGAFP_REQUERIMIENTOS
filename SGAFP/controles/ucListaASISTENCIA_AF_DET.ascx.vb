Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaASISTENCIA_AF_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla ASISTENCIA_AF_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaASISTENCIA_AF_DET
    Inherits ucListaBase
 
    Private mComponente As New cASISTENCIA_AF_DET
    Public Event Seleccionado(ByVal ID_ASISTENCIA_DET As Decimal) 
    Public Event Editando(ByVal ID_ASISTENCIA_DET As Decimal) 

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

    Public Property VerID_ASISTENCIA_DET() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerID_ASISTENCIA_AF() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerID_PARTICIPANTE() As Boolean
        Get
            Return Me.gvLista.Columns(3).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(3).Visible = Value
        End Set
    End Property

    Public Property VerNOMBRES() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerAPELLIDOS() As Boolean
        Get
            Return Me.gvLista.Columns(4).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(4).Visible = Value
        End Set
    End Property

    Public Property VerASISTIO() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerPRESENTA_JUSTIFICACION() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerJUSTIFICACION() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property HeaderID_ASISTENCIA_DET() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_ASISTENCIA_AF() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_PARTICIPANTE() As String
        Get
            Return Me.gvLista.Columns(3).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(3).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOMBRES() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderAPELLIDOS() As String
        Get
            Return Me.gvLista.Columns(4).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(4).HeaderText = Value
        End Set
    End Property

    Public Property HeaderASISTIO() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderPRESENTA_JUSTIFICACION() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderJUSTIFICACION() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ASISTENCIA_AF_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lASISTENCIA_AF_DET As listaASISTENCIA_AF_DET
        lASISTENCIA_AF_DET = Me.mComponente.ObtenerLista()
        If lASISTENCIA_AF_DET is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lASISTENCIA_AF_DET
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ASISTENCIA_AF_DET
    ''' filtrado por la tabla ASISTENCIA_AF
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorASISTENCIA_AF(ByVal ID_ASISTENCIA_AF As Decimal) As Integer
        Dim lASISTENCIA_AF_DET As listaASISTENCIA_AF_DET
        lASISTENCIA_AF_DET = Me.mComponente.ObtenerListaPorASISTENCIA_AF(ID_ASISTENCIA_AF)
        If lASISTENCIA_AF_DET is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorASISTENCIA_AF") = True
        Me.ViewState("ID_ASISTENCIA_AF") = ID_ASISTENCIA_AF
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lASISTENCIA_AF_DET
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ASISTENCIA_AF_DET
    ''' filtrado por la tabla PARTICIPANTE
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal) As Integer
        Dim lASISTENCIA_AF_DET As listaASISTENCIA_AF_DET
        lASISTENCIA_AF_DET = Me.mComponente.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
        If lASISTENCIA_AF_DET is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorPARTICIPANTE") = True
        Me.ViewState("ID_PARTICIPANTE") = ID_PARTICIPANTE
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lASISTENCIA_AF_DET
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

    Private lDdlASISTENCIA_AF As SGAFP.WebUC.ddlASISTENCIA_AF
    Private lDdlPARTICIPANTE As SGAFP.WebUC.ddlPARTICIPANTE

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
            'Dim lbDetalle As LinkButton 
            'lbDetalle = e.Row.FindControl("LinkButtonDetalle") 
            'Dim mLabelID_ASISTENCIA_DET As Label
            'mLabelID_ASISTENCIA_DET = e.Row.FindControl("Label_ID_ASISTENCIA_DET")
            'mLabelID_ASISTENCIA_DET.Visible = Not Me.PermitirEditar
            'lbDetalle.Visible = Me.PermitirEditar
            'If Me.VerID_ASISTENCIA_AF Then
            '    Dim mDdlASISTENCIA_AF As SGAFP.WebUC.ddlASISTENCIA_AF
            '    mDdlASISTENCIA_AF = e.Row.FindControl("DdlASISTENCIA_AF1")
            '    If lDdlASISTENCIA_AF Is Nothing Then
            '        lDdlASISTENCIA_AF = New SGAFP.WebUC.ddlASISTENCIA_AF
            '        lDdlASISTENCIA_AF.Recuperar()
            '    End If
            '    Dim mASISTENCIA_AF As String
            '    mASISTENCIA_AF = CType(e.Row.FindControl("Label_ID_ASISTENCIA_AF1"), Label).Text
            '    Dim lItem As ListItem = lDdlASISTENCIA_AF.Items.FindByValue(mASISTENCIA_AF)
            '    If mASISTENCIA_AF <> "" And Not lItem Is Nothing Then
            '        mDdlASISTENCIA_AF.Items.Add(New ListItem(lItem.Text, lItem.Value))
            '        mDdlASISTENCIA_AF.SelectedValue = mASISTENCIA_AF
            '    End If
            'End If
            'If Me.VerID_PARTICIPANTE And e.Row.RowState = DataControlRowState.Edit Then
            '    Dim mDdlPARTICIPANTE As SGAFP.WebUC.ddlPARTICIPANTE
            '    mDdlPARTICIPANTE = e.Row.FindControl("DdlPARTICIPANTE1")
            '    If lDdlPARTICIPANTE Is Nothing Then
            '        lDdlPARTICIPANTE = New SGAFP.WebUC.ddlPARTICIPANTE
            '        lDdlPARTICIPANTE.Recuperar()
            '    End If
            '    Dim mPARTICIPANTE As String
            '    mPARTICIPANTE = CType(e.Row.FindControl("Label_ID_PARTICIPANTE1"), Label).Text
            '    Dim lItem As ListItem = lDdlPARTICIPANTE.Items.FindByValue(mPARTICIPANTE)
            '    If mPARTICIPANTE <> "" And Not lItem Is Nothing Then
            '        mDdlPARTICIPANTE.Items.Add(New ListItem(lItem.Text, lItem.Value))
            '        mDdlPARTICIPANTE.SelectedValue = mPARTICIPANTE
            '    End If
            'End If
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
        If Me.mComponente.EliminarASISTENCIA_AF_DET(CDec(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
            'Si se cometio un error
            Me.AsignarMensaje("Error al Eliminar Registro", True, True)
            e.Cancel = True
        Else
            Me.ReCargarLista()
        End If
    End Sub
 
    Private Sub gvLista_SelectedIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewSelectEventArgs) Handles gvLista.SelectedIndexChanging
        RaiseEvent Seleccionado(CDec(CType(Me.gvLista.Rows(e.NewSelectedIndex).FindControl("LinkButton1"), LinkButton).ToolTip))
    End Sub

    Protected Sub gvLista_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvLista.PageIndexChanging
        Me.gvLista.PageIndex = e.NewPageIndex
        Me.ReCargarLista()
    End Sub

    Public Function DevolverSeleccionados() As listaASISTENCIA_AF_DET
        Dim mLista As New listaASISTENCIA_AF_DET
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New ASISTENCIA_AF_DET
                mEntidad.ID_ASISTENCIA_DET = CInt(CType(mRow.FindControl("Label_ID_ASISTENCIA_DET"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

    Private Sub ReCargarLista()
        If Me.ViewState("PorASISTENCIA_AF") Then
            Me.CargarDatosPorASISTENCIA_AF(Me.ViewState("ID_ASISTENCIA_AF"))
            Return
        End If
        If Me.ViewState("PorPARTICIPANTE") Then
            Me.CargarDatosPorPARTICIPANTE(Me.ViewState("ID_PARTICIPANTE"))
            Return
        End If
        If Me.ViewState("PorLista") Then Return
        If Me.ViewState("PorDataSet") Then Return
        Me.CargarDatos()
    End Sub

    Protected Sub CheckBox_PRESENTA_JUSTIFICACION_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim CheckBox_PRESENTA_JUSTIFICACION As CheckBox = CType(sender, CheckBox)

        Dim TextBox_JUSTIFICACION As TextBox = CheckBox_PRESENTA_JUSTIFICACION.Parent.Parent.FindControl("TextBox_JUSTIFICACION")
        TextBox_JUSTIFICACION.Enabled = CheckBox_PRESENTA_JUSTIFICACION.Checked

        If CheckBox_PRESENTA_JUSTIFICACION.Checked Then
            Dim CheckBox_ASISTIO As CheckBox = CheckBox_PRESENTA_JUSTIFICACION.Parent.Parent.FindControl("CheckBox_ASISTIO")
            CheckBox_ASISTIO.Checked = False
            TextBox_JUSTIFICACION.Focus()
        End If

    End Sub

    Public Sub Actualizar(ByVal ID_ASISTENCIA_AF As Decimal)

        For Each grRow As GridViewRow In gvLista.Rows
            Dim asistio As Integer = Convert.ToInt32(CType(grRow.FindControl("CheckBox_ASISTIO"), CheckBox).Checked)
            Dim presentaJustificacion As Integer = Convert.ToInt32(CType(grRow.FindControl("CheckBox_PRESENTA_JUSTIFICACION"), CheckBox).Checked)
            Dim justificacion As String = CType(grRow.FindControl("TextBox_JUSTIFICACION"), TextBox).Text

            Dim idAsistenciaDet As Decimal = Int32.Parse(CType(grRow.FindControl("Label_ID_ASISTENCIA_DET"), Label).Text)
            Dim idParticipante As Decimal = Int32.Parse(CType(grRow.FindControl("Label_ID_PARTICIPANTE1"), Label).Text)

            Dim cAsistenciaDet As New cASISTENCIA_AF_DET
            If asistio = 0 Or idAsistenciaDet > 0 Then
                If asistio = 1 And presentaJustificacion = 1 Then
                    Me.AsignarMensaje("Revise los datos de " + grRow.Cells(4).Text + " " + grRow.Cells(5).Text + ", ya que no se puede presentar Justificacion y asistir. Por favor verifique los datos ingresados.", True)
                    Return
                End If

                If idAsistenciaDet > 0 And asistio = 1 Then
                    If cAsistenciaDet.EliminarASISTENCIA_AF_DET(idAsistenciaDet) <> 1 Then
                        Me.AsignarMensaje("Error al Eliminar Asistencia", True, True)
                        Return
                    End If
                Else
                    If cAsistenciaDet.ActualizarASISTENCIA_AF_DET(idAsistenciaDet, ID_ASISTENCIA_AF, idParticipante, asistio.ToString(), presentaJustificacion.ToString(), justificacion, 0) <> 1 Then
                        Me.AsignarMensaje("Error al Actualizar Asistencia", True, True)
                        Return
                    End If
                End If
            End If
        Next
    End Sub
End Class
