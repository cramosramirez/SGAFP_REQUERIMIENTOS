Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantGRUPO_SELECCION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla GRUPO_SELECCION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantGRUPO_SELECCION
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ACCION_CONTRATADA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/03/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, "~/imagenes/ButtonSearch.png")
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", False, "~/imagenes/ButtonSave.png")
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, "~/imagenes/Undo-icon.png")
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucCriteriosAccionFormativa1.Visible = True
        Me.ucListaGRUPO_SELECCION1.Visible = True
        Me.ucVistaDetalleGRUPO_SELECCION1.Visible = False
        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ACCION_CONTRATADA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/03/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucCriteriosAccionFormativa1.Visible = False
        Me.ucListaGRUPO_SELECCION1.Visible = False
        Me.ucVistaDetalleGRUPO_SELECCION1.Visible = True
        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1.Visible = False
    End Sub

    Private Sub IniciarRegistro(Optional ID_GRUPO_PRESELEC As Integer = 0)
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucCriteriosAccionFormativa1.Visible = False
        Me.ucListaGRUPO_SELECCION1.Visible = False
        Me.ucVistaDetalleGRUPO_SELECCION1.Visible = False
        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1.Visible = True
        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1.ID_GRUPO_SELEC = ID_GRUPO_PRESELEC
        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1.ID_SOLIC_PRESELEC = 0
    End Sub
#End Region

    Public Function CargarDatos() As Integer
        Try
            Dim idProveedor As Integer = -1
            Dim idProgramaForma As Integer = Enumeradores.ProgramasFormacion.EMPRESA_CENTRO
            Dim sContrato As String = ""

            idProveedor = Me.ucCriteriosAccionFormativa1.idProveedor
            sContrato = Me.ucCriteriosAccionFormativa1.NumContrato
            Me.ucListaGRUPO_SELECCION1.CargarDatosPorCriterios(idProveedor, idProgramaForma, sContrato, -1)

        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.InicializarLista()
        End If
    End Sub

    Private Sub UcBarraNavegacion1_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Agregar
        Me.InicializarDetalle()
        Me.UcVistaDetalleGRUPO_SELECCION1.LimpiarControles()
        Me.ucVistaDetalleGRUPO_SELECCION1.ID_GRUPO_SELEC = 0
    End Sub

    Protected Sub ucListaGRUPO_SELECCION1_Editando(ByVal ID_GRUPO_SELEC As Decimal) Handles ucListaGRUPO_SELECCION1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetalleGRUPO_SELECCION1.ID_GRUPO_SELEC = ID_GRUPO_SELEC
    End Sub

    Private Sub ucVistaDetalleGRUPO_SELECCION1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleGRUPO_SELECCION1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Buscar" Then
            Me.CargarDatos()

        ElseIf CommandName = "Guardar" Then
            Dim sError As String = ""

            If Me.ucVistaDetalleGRUPO_SELECCION1.Visible Then
                sError = Me.ucVistaDetalleGRUPO_SELECCION1.Actualizar
            ElseIf Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1.Visible Then
                sError = Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1.Actualizar
            End If

            If sError <> "" Then
                Literal1.Text = sError
                popupError.ShowOnPageLoad = True
                Return
            End If

            Me.ucVistaDetalleGRUPO_SELECCION1.ID_GRUPO_SELEC = 0
            Me.ucVistaDetalleGRUPO_SELECCION1.LimpiarControles()
            Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1.ID_SOLIC_PRESELEC = 0
            Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AFecentro1.LimpiarControles()
            Me.InicializarLista()
            Me.ucListaGRUPO_SELECCION1.DataBind()

        ElseIf CommandName = "Cancelar" Then
            Me.ucVistaDetalleGRUPO_SELECCION1.ID_GRUPO_SELEC = 0
            Me.ucVistaDetalleGRUPO_SELECCION1.LimpiarControles()
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucListaGRUPO_SELECCION1_RegistrarParticipante(ID_GRUPO_SELEC As Decimal) Handles ucListaGRUPO_SELECCION1.RegistrarParticipante
        'Verificar si ya existe informe mensual de ejecución


        Me.IniciarRegistro(ID_GRUPO_SELEC)
    End Sub
End Class
