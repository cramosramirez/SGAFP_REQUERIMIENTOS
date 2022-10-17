Imports SGAFP.BL
Imports SGAFP.EL

Partial Class controles_ucMantACCION_FORMATIVA_PENA
    Inherits ucBase


#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ACCION_FORMATIVA_SEGUI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.VerOpcion("Agregar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)

        Me.ucListaACCION_FORMATIVA_PENA1.Visible = True
        Me.ucVistaDetalleACCION_FORMATIVA_PENA1.Visible = False
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    Public Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False

        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Ingresar nueva penalización", False, "~/imagenes/nuevo.png")
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", False, "~/imagenes/ButtonSave.png")
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, "~/imagenes/Undo-icon.png")
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.InicializarLista()
    End Sub

    Public Property ID_ACCION_FORMATIVA As Int32
        Set(value As Int32)
            Me.ViewState("ID_ACCION_FORMATIVA") = value
        End Set
        Get
            If Me.ViewState("ID_ACCION_FORMATIVA") IsNot Nothing Then
                Return CInt(Me.ViewState("ID_ACCION_FORMATIVA"))
            Else
                Return -1
            End If
        End Get
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ACCION_FORMATIVA_SEGUI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucListaACCION_FORMATIVA_PENA1.Visible = False
        Me.ucVistaDetalleACCION_FORMATIVA_PENA1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n de los registros de la tabla ACCION_FORMATIVA_SEGUI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarACCION_FORMATIVA_PENA()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarACCION_FORMATIVA_PENA() As Integer
        Me.ucListaACCION_FORMATIVA_PENA1.CargarDatosPorACCION_FORMATIVA(Me.ID_ACCION_FORMATIVA)
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not IsPostBack Then
            If Me.Request.QueryString("idc") IsNot Nothing Then
                Me.ID_ACCION_FORMATIVA = CInt(Me.Request.QueryString("idc"))
            End If
            Me.Inicializar()
        End If
    End Sub

    Protected Sub ucListaACCION_FORMATIVA_PENA1_Editando(ByVal ID_ACCION_FORMATIVA_PENA As Decimal) Handles ucListaACCION_FORMATIVA_PENA1.Editando
        Me.ucVistaDetalleACCION_FORMATIVA_PENA1.ID_ACCION_FORMATIVA_PENA = ID_ACCION_FORMATIVA_PENA
        Me.InicializarDetalle()
    End Sub

    Private Sub ucVistaDetalleACCION_FORMATIVA_SEGUI1_ErrorEvent(ByVal errorMessage As String) Handles ucVistaDetalleACCION_FORMATIVA_PENA1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "Agregar"
                Me.ucVistaDetalleACCION_FORMATIVA_PENA1.LimpiarControles()
                Me.ucVistaDetalleACCION_FORMATIVA_PENA1.ID_ACCION_FORMATIVA = Me.ID_ACCION_FORMATIVA
                Me.InicializarDetalle()

            Case "Guardar"
                Dim sError As String
                sError = Me.ucVistaDetalleACCION_FORMATIVA_PENA1.Actualizar()
                If sError <> "" Then
                    Me.AsignarMensaje(sError, False, True)
                    Return
                End If
                Me.InicializarLista()

            Case "Cancelar"
                Me.InicializarLista()
        End Select
    End Sub
End Class
