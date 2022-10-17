Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantACCION_PROGRA_RETRO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla ACCION_PROGRA_RETRO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/09/2016	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantACCION_PROGRA_RETRO
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ACCION_PROGRA_RETRO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/09/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = True
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.lblProveedor.Visible = True
        Me.ddlPROVEEDOR_AF1.Visible = True
        Me.ucListaACCION_PROGRA_RETRO1.Visible = True
        Me.UcVistaDetalleACCION_PROGRA_RETRO1.Visible = False
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ACCION_PROGRA_RETRO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/09/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.lblProveedor.Visible = False
        Me.ddlPROVEEDOR_AF1.Visible = False
        Me.ucListaACCION_PROGRA_RETRO1.Visible = False
        Me.UcVistaDetalleACCION_PROGRA_RETRO1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_PROGRA_RETRO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/09/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Return Me.CargarACCION_PROGRA_RETRO()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarACCION_PROGRA_RETRO() As Integer
        Dim idProveedor As Int32 = IIf(Me.ddlPROVEEDOR_AF1.SelectedValue IsNot Nothing, Me.ddlPROVEEDOR_AF1.SelectedValue, 0)

        If idProveedor = -1 Then
            If Me.ucListaACCION_PROGRA_RETRO1.CargarDatos <> 1 Then Return -1
        Else
            If Me.ucListaACCION_PROGRA_RETRO1.CargarDatosPorPROVEEDOR_AF(idProveedor) <> 1 Then Return -1
        End If

        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Dim bAccionPrograRetro As New cACCION_PROGRA_RETRO
            bAccionPrograRetro.InhabilitarPorFechaExpiraACCION_PROGRA_RETRO()

            Me.ddlPROVEEDOR_AF1.Recuperar()
            Me.ddlPROVEEDOR_AF1.AgregarTodosNumerico()
            Me.ddlPROVEEDOR_AF1.SelectedValue = -1
            Me.InicializarLista()
        End If
    End Sub

    Private Sub UcBarraNavegacion1_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Agregar
        Me.InicializarDetalle()
        Me.UcVistaDetalleACCION_PROGRA_RETRO1.LimpiarControles()
        Me.ucVistaDetalleACCION_PROGRA_RETRO1.ID_ACCION_PROGRA_RETRO = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetalleACCION_PROGRA_RETRO1.Actualizar()
        If sError <> "" Then
            Me.AsignarMensaje(sError, False, True)
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaACCION_PROGRA_RETRO1_Editando(ByVal ID_ACCION_PROGRA_RETRO As Decimal) Handles ucListaACCION_PROGRA_RETRO1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetalleACCION_PROGRA_RETRO1.ID_ACCION_PROGRA_RETRO = ID_ACCION_PROGRA_RETRO
    End Sub

    Private Sub ucVistaDetalleACCION_PROGRA_RETRO1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleACCION_PROGRA_RETRO1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ddlPROVEEDOR_AF1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlPROVEEDOR_AF1.SelectedIndexChanged
        Me.CargarACCION_PROGRA_RETRO()
    End Sub
End Class
