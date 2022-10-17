Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantACCION_PARTI_SINDOCTOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla ACCION_PARTI_SINDOCTOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/05/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantACCION_PARTI_SINDOCTOS
    Inherits ucBase

    Private Property ID_ACCION_FORMATIVA() As Decimal
        Set(ByVal value As Decimal)
            Me.ViewState("ID_ACCION_FORMATIVA") = value
        End Set
        Get
            If Me.ViewState("ID_ACCION_FORMATIVA") Is Nothing Then Return 0
            Return Me.ViewState("ID_ACCION_FORMATIVA")
        End Get
    End Property

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ACCION_PARTI_SINDOCTOS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/05/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = True
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucListaACCION_PARTI_SINDOCTOS1.Visible = True
        Me.ucVistaDetalleACCION_PARTI_SINDOCTOS1.Visible = False
        If Me.Request.QueryString("idc") IsNot Nothing Then
            Me.ID_ACCION_FORMATIVA = CDec(CDec(Me.Request.QueryString("idc")))
            If Me.CargarDatos(Me.ID_ACCION_FORMATIVA) <> 1 Then
                Me.AsignarMensaje("Error al Recuperar Lista", True, True)
            End If
        Else
            If Me.CargarDatos() <> 1 Then
                Me.AsignarMensaje("Error al Recuperar Lista", True, True)
            End If
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ACCION_PARTI_SINDOCTOS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/05/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucListaACCION_PARTI_SINDOCTOS1.Visible = False
        Me.UcVistaDetalleACCION_PARTI_SINDOCTOS1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_PARTI_SINDOCTOS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/05/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarACCION_PARTI_SINDOCTOS()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_PARTI_SINDOCTOS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/05/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Try
            Return Me.CargarACCION_PARTI_SINDOCTOS(ID_ACCION_FORMATIVA)
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarACCION_PARTI_SINDOCTOS() As Integer
        If Me.ucListaACCION_PARTI_SINDOCTOS1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Function CargarACCION_PARTI_SINDOCTOS(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        If Me.ucListaACCION_PARTI_SINDOCTOS1.CargarDatosPorACCION_FORMATIVA(ID_ACCION_FORMATIVA) <> 1 Then Return -1
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
        Me.ucVistaDetalleACCION_PARTI_SINDOCTOS1.ID_ACCION_FORMATIVA = Me.ID_ACCION_FORMATIVA
        Me.ucVistaDetalleACCION_PARTI_SINDOCTOS1.ID_ACCION_PARTI = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String
        sError = Me.UcVistaDetalleACCION_PARTI_SINDOCTOS1.Actualizar()
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaACCION_PARTI_SINDOCTOS1_Editando(ByVal ID_ACCION_PARTI As Decimal) Handles ucListaACCION_PARTI_SINDOCTOS1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetalleACCION_PARTI_SINDOCTOS1.ID_ACCION_PARTI = ID_ACCION_PARTI
    End Sub

    Private Sub ucVistaDetalleACCION_PARTI_SINDOCTOS1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleACCION_PARTI_SINDOCTOS1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

End Class
