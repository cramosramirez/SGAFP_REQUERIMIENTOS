Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantDESEMBOLSO_MUNI_LIQUI_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla DESEMBOLSO_MUNI_LIQUI_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/04/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantDESEMBOLSO_MUNI_LIQUI_DET
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla DESEMBOLSO_MUNI_LIQUI_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = True
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucListaDESEMBOLSO_MUNI_LIQUI_DET1.Visible = True
        Me.UcVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET1.Visible = False
        If Me.CargarDatos() <> 1 Then
            Me.AsignarMensaje("Error al Recuperar Lista", True, True)
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla DESEMBOLSO_MUNI_LIQUI_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucListaDESEMBOLSO_MUNI_LIQUI_DET1.Visible = False
        Me.UcVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla DESEMBOLSO_MUNI_LIQUI_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Return Me.CargarDESEMBOLSO_MUNI_LIQUI_DET()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarDESEMBOLSO_MUNI_LIQUI_DET() As Integer
        If Me.ucListaDESEMBOLSO_MUNI_LIQUI_DET1.CargarDatos() <> 1 Then Return -1
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
        Me.UcVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET1.LimpiarControles()
        Me.ucVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET1.ID_DESEMBOLSO_MUNI = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaDESEMBOLSO_MUNI_LIQUI_DET1_Editando(ByVal ID_DESEMBOLSO_MUNI As Decimal) Handles ucListaDESEMBOLSO_MUNI_LIQUI_DET1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET1.ID_DESEMBOLSO_MUNI = ID_DESEMBOLSO_MUNI
    End Sub

    Private Sub ucVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

End Class
