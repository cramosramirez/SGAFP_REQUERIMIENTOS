Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantPAQUETE_INFORME_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla PAQUETE_INFORME_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/08/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantPAQUETE_INFORME_DET
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PAQUETE_INFORME_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = True
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucListaPAQUETE_INFORME_DET1.Visible = True
        Me.UcVistaDetallePAQUETE_INFORME_DET1.Visible = False
        Me.lblID_PAQUETE.Visible = True
        Me.ddlPAQUETE_INFORME1.Visible = True
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PAQUETE_INFORME_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucListaPAQUETE_INFORME_DET1.Visible = False
        Me.UcVistaDetallePAQUETE_INFORME_DET1.Visible = True
        Me.lblID_PAQUETE.Visible = False
        Me.ddlPAQUETE_INFORME1.Visible = False
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PAQUETE_INFORME_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Me.ddlPAQUETE_INFORME1.Recuperar()
            Return Me.CargarPAQUETE_INFORME_DET()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarPAQUETE_INFORME_DET() As Integer
        Me.ucListaPAQUETE_INFORME_DET1.ID_PAQUETE = IIf(Me.ddlPAQUETE_INFORME1.SelectedValue = "", 0, Me.ddlPAQUETE_INFORME1.SelectedValue)
        'If Me.ucListaPAQUETE_INFORME_DET1.CargarDatos() <> 1 Then Return -1
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
        Me.UcVistaDetallePAQUETE_INFORME_DET1.LimpiarControles()
        Me.ucVistaDetallePAQUETE_INFORME_DET1.ID_PAQUETE = CDec(Me.ddlPAQUETE_INFORME1.SelectedValue)
        Me.ucVistaDetallePAQUETE_INFORME_DET1.ID_INFORME_FINAL = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetallePAQUETE_INFORME_DET1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaPAQUETE_INFORME_DET1_Editando(ByVal ID_PAQUETE As Decimal, ByVal ID_INFORME_FINAL As Decimal) Handles ucListaPAQUETE_INFORME_DET1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetallePAQUETE_INFORME_DET1.ID_PAQUETE = ID_PAQUETE
        Me.UcVistaDetallePAQUETE_INFORME_DET1.ID_INFORME_FINAL = ID_INFORME_FINAL
    End Sub

    Private Sub ucVistaDetallePAQUETE_INFORME_DET1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetallePAQUETE_INFORME_DET1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ddlPAQUETE_INFORME1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlPAQUETE_INFORME1.SelectedIndexChanged
        Me.CargarPAQUETE_INFORME_DET()
    End Sub


End Class
