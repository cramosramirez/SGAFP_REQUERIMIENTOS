Imports SQLMembershipProvider.BL
Imports SQLMembershipProvider.EL
''' -----------------------------------------------------------------------------
''' Project	 : SQLMembershipProvider
''' Class	 : ucMantSistemas
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla Sistemas
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/03/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantSistemas
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla Sistemas
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/03/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()

        Me.AsignarTituloOpcion("Gestionar Sistemas", "~/imagenes/pro.png")

        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = True
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucBarraNavegacion1.LimpiarOpciones()
        Me.ucBarraNavegacion1.CrearOpcion("Sincronizar", "Sincronizar", False, "~/imagenes/exportar.gif")
        Me.ucBarraNavegacion1.CargarOpciones()

        Me.ucListaSistemas1.Visible = True
        Me.ucVistaDetalleSistemas1.Visible = False
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla Sistemas
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/03/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucListaSistemas1.Visible = False
        Me.UcVistaDetalleSistemas1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla Sistemas
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/03/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Return Me.CargarSistemas()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarSistemas() As Integer
        If Me.ucListaSistemas1.CargarDatos() <> 1 Then Return -1
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
        Me.UcVistaDetalleSistemas1.LimpiarControles()
        Me.ucVistaDetalleSistemas1.IdSistema1 = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetalleSistemas1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaSistemas1_Editando(ByVal IdSistema As Int32) Handles ucListaSistemas1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetalleSistemas1.IdSistema1 = IdSistema
    End Sub

    Private Sub ucVistaDetalleSistemas1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleSistemas1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Sincronizar" Then
            Sincronizar()
        End If
    End Sub

    Private Sub Sincronizar()
        Dim listaSist As listaSistemas
        listaSist = Me.ucListaSistemas1.DevolverSeleccionados()
        'If Not listaSist Is Nothing AndAlso listaSist.Count > 0 Then
        '    Dim cSistemasDesa As New cSistemas
        '    Dim cSistemasProd As New cSistemas("LocalSqlServerProd")

        '    For Each lSistema As Sistemas In listaSist

        '        lSistema = cSistemasDesa.ObtenerSistemas(lSistema.IdSistema)

        '        Dim lSistemaProd As Sistemas = cSistemasProd.ObtenerSistemas(lSistema.IdSistema)
        '        If lSistemaProd Is Nothing Then
        '            If cSistemasProd.AgregarSistemas(lSistema) < 0 Then

        '            End If
        '        Else
        '            If cSistemasProd.ActualizarSistemas(lSistema) < 0 Then

        '            End If
        '        End If

        '    Next
        'Else
        '    Me.AsignarMensaje("Debe de Seleccionar al Menos un Sistema.")
        'End If

    End Sub

End Class
