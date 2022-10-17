Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantSOLIC_EMPLEO_ANTERIOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla SOLIC_EMPLEO_ANTERIOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantSOLIC_EMPLEO_ANTERIOR
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLIC_EMPLEO_ANTERIOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = True
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucListaSOLIC_EMPLEO_ANTERIOR1.Visible = True
        Me.UcVistaDetalleSOLIC_EMPLEO_ANTERIOR1.Visible = False
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLIC_EMPLEO_ANTERIOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucListaSOLIC_EMPLEO_ANTERIOR1.Visible = False
        Me.UcVistaDetalleSOLIC_EMPLEO_ANTERIOR1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLIC_EMPLEO_ANTERIOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Return Me.CargarSOLIC_EMPLEO_ANTERIOR()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarSOLIC_EMPLEO_ANTERIOR() As Integer
        If Me.ucListaSOLIC_EMPLEO_ANTERIOR1.CargarDatos() <> 1 Then Return -1
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
        Me.UcVistaDetalleSOLIC_EMPLEO_ANTERIOR1.LimpiarControles()
        Me.ucVistaDetalleSOLIC_EMPLEO_ANTERIOR1.ID_EMPLEO_ANT = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetalleSOLIC_EMPLEO_ANTERIOR1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaSOLIC_EMPLEO_ANTERIOR1_Editando(ByVal ID_EMPLEO_ANT As Decimal) Handles ucListaSOLIC_EMPLEO_ANTERIOR1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetalleSOLIC_EMPLEO_ANTERIOR1.ID_EMPLEO_ANT = ID_EMPLEO_ANT
    End Sub

    Private Sub ucVistaDetalleSOLIC_EMPLEO_ANTERIOR1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleSOLIC_EMPLEO_ANTERIOR1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

End Class
