Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucListaEVALUACIONES_AF_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar un listado de la tabla EVALUACIONES_AF_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucListaEVALUACIONES_AF_DET
    Inherits ucBase
 
    Private mComponente As New cEVALUACIONES_AF_DET
    Public Event Seleccionado(ByVal ID_EVALUACION_DET As Decimal) 
    Public Event Editando(ByVal ID_EVALUACION_DET As Decimal) 

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

    Public Property VerID_EVALUACION_DET() As Boolean
        Get
            Return Me.gvLista.Columns(1).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(1).Visible = Value
        End Set
    End Property

    Public Property VerID_PARTICIPANTE() As Boolean
        Get
            Return Me.gvLista.Columns(2).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(2).Visible = Value
        End Set
    End Property

    Public Property VerID_EVALUACION_AF() As Boolean
        Get
            Return Me.gvLista.Columns(5).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(5).Visible = Value
        End Set
    End Property

    Public Property VerNOTA_OBTENIDA() As Boolean
        Get
            Return Me.gvLista.Columns(6).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(6).Visible = Value
        End Set
    End Property

    Public Property VerNOTAS() As Boolean
        Get
            Return Me.gvLista.Columns(7).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(7).Visible = Value
        End Set
    End Property

    Public Property VerNOTA_OBTENIDAEdicion() As Boolean
        Get
            Return Me.gvLista.Columns(8).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(8).Visible = Value
        End Set
    End Property

    Public Property VerNOTASEdicion() As Boolean
        Get
            Return Me.gvLista.Columns(9).Visible
        End Get
        Set(ByVal Value As Boolean)
            Me.gvLista.Columns(9).Visible = Value
        End Set
    End Property

    Public Property HeaderID_EVALUACION_DET() As String
        Get
            Return Me.gvLista.Columns(1).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(1).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_PARTICIPANTE() As String
        Get
            Return Me.gvLista.Columns(2).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(2).HeaderText = Value
        End Set
    End Property

    Public Property HeaderID_EVALUACION_AF() As String
        Get
            Return Me.gvLista.Columns(5).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(5).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOTA_OBTENIDA() As String
        Get
            Return Me.gvLista.Columns(6).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(6).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOTAS() As String
        Get
            Return Me.gvLista.Columns(7).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(7).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOTA_OBTENIDAEdicion() As String
        Get
            Return Me.gvLista.Columns(8).HeaderText
        End Get
        Set(ByVal Value As String)
            Me.gvLista.Columns(8).HeaderText = Value
        End Set
    End Property

    Public Property HeaderNOTASEdicion() As String
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
    ''' Función que Carga la información de los registros de la tabla EVALUACIONES_AF_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Dim lEVALUACIONES_AF_DET As listaEVALUACIONES_AF_DET
        lEVALUACIONES_AF_DET = Me.mComponente.ObtenerLista()
        If lEVALUACIONES_AF_DET is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lEVALUACIONES_AF_DET
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla EVALUACIONES_AF_DET
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
        Dim lEVALUACIONES_AF_DET As listaEVALUACIONES_AF_DET
        lEVALUACIONES_AF_DET = Me.mComponente.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
        If lEVALUACIONES_AF_DET is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorPARTICIPANTE") = True
        Me.ViewState("ID_PARTICIPANTE") = ID_PARTICIPANTE
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lEVALUACIONES_AF_DET
        Me.gvLista.DataBind()
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla EVALUACIONES_AF_DET
    ''' filtrado por la tabla EVALUACION_AF
    ''' </summary>
    ''' <param name="ID_EVALUACION_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatosPorEVALUACION_AF(ByVal ID_EVALUACION_AF As Decimal) As Integer
        Dim lEVALUACIONES_AF_DET As listaEVALUACIONES_AF_DET
        lEVALUACIONES_AF_DET = Me.mComponente.ObtenerListaPorEVALUACION_AF(ID_EVALUACION_AF)
        If lEVALUACIONES_AF_DET is Nothing Then
            Me.gvLista.Visible = False
            Return -1
        End If
        Me.ViewState("PorEVALUACION_AF") = True
        Me.ViewState("ID_EVALUACION_AF") = ID_EVALUACION_AF
        Me.gvLista.SelectedIndex = -1
        Me.gvLista.Visible = True
        Me.gvLista.DataSource = lEVALUACIONES_AF_DET
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
            Dim mLabelID_EVALUACION_DET As Label
            mLabelID_EVALUACION_DET = e.Row.FindControl("Label_ID_EVALUACION_DET")
            mLabelID_EVALUACION_DET.Visible = Not Me.PermitirEditar
            lbDetalle.Visible = Me.PermitirEditar
            If Me.VerID_PARTICIPANTE Then
                Dim mPARTICIPANTE As String
                mPARTICIPANTE = CType(e.Row.FindControl("Label_ID_PARTICIPANTE1"), Label).Text
                Dim lParticipante As PARTICIPANTE = (New cPARTICIPANTE).ObtenerPARTICIPANTE(mPARTICIPANTE)
                CType(e.Row.FindControl("Label_Nombres"), Label).Text = lParticipante.NOMBRES
                CType(e.Row.FindControl("Label_Apellidos"), Label).Text = lParticipante.APELLIDOS
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
            If Me.VerNOTA_OBTENIDAEdicion Then
                Dim mTextBox As TextBox
                mTextBox = e.Row.FindControl("TextBox_NotaObtenida")
                If mTextBox.Text = -1 Then
                    mTextBox.Text = ""
                End If
            End If

        End If
    End Sub
 
    Private Sub gvLista_RowDeleting(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.GridViewDeleteEventArgs) Handles gvLista.RowDeleting
        If Me.mComponente.EliminarEVALUACIONES_AF_DET(CDec(CType(Me.gvLista.Rows(e.RowIndex).FindControl("LinkButton1"), LinkButton).ToolTip)) <> 1 Then
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
        If Me.ViewState("PorPARTICIPANTE") Then
            Me.CargarDatosPorPARTICIPANTE(Me.ViewState("ID_PARTICIPANTE"))
            Return
        End If
        If Me.ViewState("PorEVALUACION_AF") Then
            Me.CargarDatosPorEVALUACION_AF(Me.ViewState("ID_EVALUACION_AF"))
            Return
        End If
        Me.CargarDatos()
    End Sub

    Public Function DevolverSeleccionados() As listaEVALUACIONES_AF_DET
        Dim mLista As New listaEVALUACIONES_AF_DET
        For Each mRow As GridViewRow In Me.gvLista.Rows
            If CType(mRow.FindControl("CheckBox_Seleccionar"), CheckBox).Checked Then
                Dim mEntidad As New EVALUACIONES_AF_DET
                mEntidad.ID_EVALUACION_DET = CInt(CType(mRow.FindControl("Label_ID_EVALUACION_DET"), Label).Text)
                mLista.Add(mEntidad)
            End If
        Next
        Return mLista
    End Function

    Public Sub Actualizar(ByVal ID_EVALUACION_AF As Decimal)
        'Verificar si la Evaluación está reportada en algún Informe de Ejecución
        Dim bEvaluacionAF As New cEVALUACION_AF
        Dim lEvaluacionAF As EVALUACION_AF = bEvaluacionAF.ObtenerEVALUACION_AF(ID_EVALUACION_AF)
        Dim bInformeEjecucion As New cINFORME_FINAL_AF
        Dim lInformeEjecucion As INFORME_FINAL_AF = bInformeEjecucion.ObtenerINFORME_FINAL_AFPorAccionFormativaFecha(lEvaluacionAF.ID_ACCION_FORMATIVA, lEvaluacionAF.FECHA_EVALUACION)
        If lInformeEjecucion IsNot Nothing AndAlso Not (lInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.Emitido OrElse _
             lInformeEjecucion.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones) Then
            Me.AsignarMensaje("Error al Actualizar Evaluación debido a que existe un Informe Final Entregado.", True)
            Exit Sub
        End If

        For Each grRow As GridViewRow In gvLista.Rows

            Dim mEntidad As New EVALUACIONES_AF_DET
            mEntidad.ID_EVALUACION_DET = CInt(CType(grRow.FindControl("Label_ID_EVALUACION_DET"), Label).Text)
            Dim strNotaObtenida As String = CType(grRow.FindControl("TextBox_NotaObtenida"), TextBox).Text

            If strNotaObtenida = "" Then
                mEntidad.NOTA_OBTENIDA = -1
            Else
                mEntidad.NOTA_OBTENIDA = Decimal.Parse(strNotaObtenida)
            End If

            mEntidad.NOTAS = CType(grRow.FindControl("TextBox_Notas"), TextBox).Text
            mEntidad.ID_EVALUACION_AF = ID_EVALUACION_AF
            mEntidad.ID_PARTICIPANTE = Int32.Parse(CType(grRow.FindControl("Label_ID_PARTICIPANTE1"), Label).Text)

            Dim cEvaluacionDet As New cEVALUACIONES_AF_DET
            cEvaluacionDet.ActualizarEVALUACIONES_AF_DET(mEntidad)

        Next

        If lInformeEjecucion IsNot Nothing Then bInformeEjecucion.ActualizarINFORME_FINAL_AF(lInformeEjecucion)
    End Sub

End Class
