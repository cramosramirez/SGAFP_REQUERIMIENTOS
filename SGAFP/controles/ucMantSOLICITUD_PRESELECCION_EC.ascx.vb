Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantSOLICITUD_PRESELECCION_EC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla SOLICITUD_PRESELECCION_EC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	09/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantSOLICITUD_PRESELECCION_EC
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLICITUD_PRESELECCION_EC
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, "~/imagenes/ButtonSearch.png")
        Me.ucBarraNavegacion1.CrearOpcion("Asignar", "Asignar aspirantes a otro grupo", False, "~/imagenes/Users-Change-User-icon.png")
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", False, "~/imagenes/ButtonSave.png")
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, "~/imagenes/Undo-icon.png")
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Asignar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.trCriterios.Visible = True
        Me.ucListaSOLICITUD_PRESELECCION_EC1.Visible = True
        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLICITUD_PRESELECCION_EC
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Asignar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.trCriterios.Visible = False
        Me.ucListaSOLICITUD_PRESELECCION_EC1.Visible = False
        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_PRESELECCION_EC
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	09/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Dim idProveedor As Integer = -1
            Dim idProgramaForma As Integer = Enumeradores.ProgramasFormacion.EMPRESA_CENTRO
            Dim sContrato As String = ""
            Dim NoGrupo As Decimal = -1

            idProveedor = Me.ddlPROVEEDOR_AF1.SelectedValue
            sContrato = Me.txtNUM_CONTRATO.Text
            NoGrupo = If(Me.txtNO_GRUPO.Text <> "", CDec(Me.txtNO_GRUPO.Text), -1)
            Me.ucListaSOLICITUD_PRESELECCION_EC1.CargarDatosPorCriterios(idProveedor, idProgramaForma, sContrato, "", NoGrupo, "APELLIDOS")

        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarSOLICITUD_PRESELECCION_EC() As Integer
        If Me.ucListaSOLICITUD_PRESELECCION_EC1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.ddlPROVEEDOR_AF1.Recuperar()
            Me.ddlPROVEEDOR_AF1.AgregarTodosNumerico()
            Me.ddlPROVEEDOR_AF1.SelectedValue = -1
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Buscar" Then
            Me.CargarDatos()

        ElseIf CommandName = "Guardar" Then
            Dim sError As String = ""
            sError = Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1.Actualizar

            If sError <> "" Then
                MostrarMensajeInfo(sError)
                Return
            End If

            Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1.ID_SOLIC_PRESELEC = 0
            Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1.LimpiarControles()
            Me.InicializarLista()
            Me.ucListaSOLICITUD_PRESELECCION_EC1.DataBind()
        ElseIf CommandName = "Asignar" Then
            Dim lista As listaSOLICITUD_PRESELECCION_EC = Me.ucListaSOLICITUD_PRESELECCION_EC1.DevolverSeleccionados

            If lista Is Nothing OrElse lista.Count = 0 Then
                Me.MostrarMensajeInfo("Seleccione los aspirantes que asignara")
                Return
            End If

            Me.txtNUM_CONTRATOpopup.Text = ""
            Me.ucListaGRUPO_SELECCION1.CargarDatosPorACCION_CONTRATADA(-100)
            popupAsignacion.ShowOnPageLoad = True

        ElseIf CommandName = "Cancelar" Then
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucListaSOLICITUD_PRESELECCION_EC1_Editando(ID_SOLIC_PRESELEC As Decimal) Handles ucListaSOLICITUD_PRESELECCION_EC1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1.ID_SOLIC_PRESELEC = ID_SOLIC_PRESELEC
    End Sub

    Protected Sub btnBuscarPopup_Click(sender As Object, e As EventArgs) Handles btnBuscarPopup.Click
        If Me.txtNUM_CONTRATOpopup.Text.Trim <> "" Then Me.ucListaGRUPO_SELECCION1.CargarDatosPorCriterios(-1, -1, Me.txtNUM_CONTRATOpopup.Text, "NO_GRUPO")
    End Sub

    Protected Sub btnCancelarPopup_Click(sender As Object, e As EventArgs) Handles btnCancelarPopup.Click
        Me.popupAsignacion.ShowOnPageLoad = False
    End Sub

    Protected Sub btnAceptarPopup_Click(sender As Object, e As EventArgs) Handles btnAceptarPopup.Click
        Dim lista As listaGRUPO_SELECCION = Me.ucListaGRUPO_SELECCION1.DevolverSeleccionados

        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            Dim listaAsp As listaSOLICITUD_PRESELECCION_EC = Me.ucListaSOLICITUD_PRESELECCION_EC1.DevolverSeleccionados
            Dim bSolic As New cSOLICITUD_PRESELECCION_EC

            If listaAsp IsNot Nothing AndAlso listaAsp.Count > 0 Then
                For i As Integer = 0 To listaAsp.Count - 1
                    listaAsp(i).ID_GRUPO_SELEC = lista(0).ID_GRUPO_SELEC
                    listaAsp(i).USUARIO_ACT = Me.ObtenerUsuario
                    listaAsp(i).FECHA_ACT = Now

                    bSolic.ActualizarSOLICITUD_PRESELECCION_EC(listaAsp(i))
                Next
            End If
            Me.popupAsignacion.ShowOnPageLoad = False
            Me.ucListaSOLICITUD_PRESELECCION_EC1.DataBind()
            Me.MostrarMensajeInfo("La asignacion se ha realizado!")
        Else
            Me.MostrarMensajeInfo("Seleccione un grupo")
        End If
    End Sub

    Private Sub MostrarMensajeInfo(ByVal msj As String)
        Literal1.Text = msj
        popupError.ShowOnPageLoad = True
    End Sub

    Protected Sub ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1_ErrorEvent(errorMessage As String) Handles ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1.ErrorEvent
        Literal1.Text = errorMessage
        popupError.ShowOnPageLoad = True
    End Sub
End Class
