Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantMUNICIPIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla MUNICIPIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantMUNICIPIO
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla MUNICIPIO
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
        Me.ucListaMUNICIPIO1.Visible = True
        Me.UcVistaDetalleMUNICIPIO1.Visible = False
        Me.lblCODIGO_REGION.Visible = True
        Me.ddlREGION1.Visible = True
        Me.lblCODIGO_DEPARTAMENTO.Visible = True
        Me.ddlDEPARTAMENTO1.Visible = True
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla MUNICIPIO
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
        Me.ucListaMUNICIPIO1.Visible = False
        Me.UcVistaDetalleMUNICIPIO1.Visible = True
        Me.lblCODIGO_REGION.Visible = False
        Me.ddlREGION1.Visible = False
        Me.lblCODIGO_DEPARTAMENTO.Visible = False
        Me.ddlDEPARTAMENTO1.Visible = False
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla MUNICIPIO
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Me.ddlDEPARTAMENTO1.Recuperar()
            Return Me.CargarMUNICIPIO()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarMUNICIPIO() As Integer
        Me.ucListaMUNICIPIO1.CODIGO_REGION = IIf(Me.ddlREGION1.SelectedValue = "", 0, Me.ddlREGION1.SelectedValue)
        Me.ucListaMUNICIPIO1.CODIGO_DEPARTAMENTO = IIf(Me.ddlDEPARTAMENTO1.SelectedValue = "", 0, Me.ddlDEPARTAMENTO1.SelectedValue)
        If Me.ucListaMUNICIPIO1.CargarDatos() <> 1 Then Return -1
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
        Me.UcVistaDetalleMUNICIPIO1.LimpiarControles()
        Me.ucVistaDetalleMUNICIPIO1.CODIGO_REGION = Me.ddlREGION1.SelectedValue
        Me.ucVistaDetalleMUNICIPIO1.CODIGO_DEPARTAMENTO = Me.ddlDEPARTAMENTO1.SelectedValue
        Me.ucVistaDetalleMUNICIPIO1.CODIGO_MUNICIPIO = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetalleMUNICIPIO1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaMUNICIPIO1_Editando(ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String) Handles ucListaMUNICIPIO1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetalleMUNICIPIO1.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
        Me.UcVistaDetalleMUNICIPIO1.CODIGO_REGION = CODIGO_REGION
        Me.UcVistaDetalleMUNICIPIO1.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
    End Sub

    Private Sub ucVistaDetalleMUNICIPIO1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleMUNICIPIO1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub
 

    Protected Sub ddlDEPARTAMENTO1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlDEPARTAMENTO1.SelectedIndexChanged
        Me.CargarMUNICIPIO()
    End Sub

End Class
