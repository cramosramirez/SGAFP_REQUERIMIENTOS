Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantSITIO_CAPACITACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla SITIO_CAPACITACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/02/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantSITIO_CAPACITACION
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SITIO_CAPACITACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucListaSITIO_CAPACITACION1.Visible = True
        Me.ucVistaDetalleSITIO_CAPACITACION1.Visible = False
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SITIO_CAPACITACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucListaSITIO_CAPACITACION1.Visible = False
        Me.UcVistaDetalleSITIO_CAPACITACION1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SITIO_CAPACITACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Return Me.CargarSITIO_CAPACITACION()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarSITIO_CAPACITACION() As Integer
        Select Case True
            Case EstaEnRol(RolDeUsuario.Administrador)
                If Me.ucListaSITIO_CAPACITACION1.CargarDatos() <> 1 Then Return -1
            Case EstaEnRol(RolDeUsuario.Proveedor)
                If Me.ucListaSITIO_CAPACITACION1.CargarDatosPorPROVEEDOR_AF(Me.ObtenerIdProveedorAF) <> 1 Then Return -1
            Case EstaEnRol(RolDeUsuario.CentroCapacitador)
                If Me.ucListaSITIO_CAPACITACION1.CargarDatosPorSITIO_CAPACITACION(Me.ObtenerIdSitioCapacitacion) <> 1 Then Return -1
        End Select
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
        Me.UcVistaDetalleSITIO_CAPACITACION1.LimpiarControles()
        Me.ucVistaDetalleSITIO_CAPACITACION1.ID_SITIO_CAPACITACION = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetalleSITIO_CAPACITACION1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaSITIO_CAPACITACION1_Editando(ByVal ID_SITIO_CAPACITACION As Decimal) Handles ucListaSITIO_CAPACITACION1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetalleSITIO_CAPACITACION1.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
    End Sub

    Private Sub ucVistaDetalleSITIO_CAPACITACION1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleSITIO_CAPACITACION1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

End Class
