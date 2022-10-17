Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantDEPARTAMENTO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla DEPARTAMENTO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantDEPARTAMENTO
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla DEPARTAMENTO
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
        Me.ucListaDEPARTAMENTO1.Visible = True
        Me.UcVistaDetalleDEPARTAMENTO1.Visible = False
        Me.lblCODIGO_REGION.Visible = True
        Me.ddlREGION1.Visible = True
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla DEPARTAMENTO
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
        Me.ucListaDEPARTAMENTO1.Visible = False
        Me.UcVistaDetalleDEPARTAMENTO1.Visible = True
        Me.lblCODIGO_REGION.Visible = False
        Me.ddlREGION1.Visible = False
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla DEPARTAMENTO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Me.ddlREGION1.Recuperar()
            Return Me.CargarDEPARTAMENTO()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarDEPARTAMENTO() As Integer
        Me.ucListaDEPARTAMENTO1.CODIGO_REGION = IIf(Me.ddlREGION1.SelectedValue = "", 0, Me.ddlREGION1.SelectedValue)
        If Me.ucListaDEPARTAMENTO1.CargarDatos() <> 1 Then Return -1
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
        Me.UcVistaDetalleDEPARTAMENTO1.LimpiarControles()
        Me.ucVistaDetalleDEPARTAMENTO1.CODIGO_REGION = Me.ddlREGION1.SelectedValue
        Me.ucVistaDetalleDEPARTAMENTO1.CODIGO_DEPARTAMENTO = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetalleDEPARTAMENTO1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaDEPARTAMENTO1_Editando(ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String) Handles ucListaDEPARTAMENTO1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetalleDEPARTAMENTO1.CODIGO_REGION = CODIGO_REGION
        Me.UcVistaDetalleDEPARTAMENTO1.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
    End Sub

    Private Sub ucVistaDetalleDEPARTAMENTO1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleDEPARTAMENTO1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ddlREGION1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlREGION1.SelectedIndexChanged
        Me.CargarDEPARTAMENTO()
    End Sub

End Class
