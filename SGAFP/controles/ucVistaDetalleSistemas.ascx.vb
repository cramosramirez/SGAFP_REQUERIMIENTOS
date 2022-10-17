Imports SQLMembershipProvider.BL
Imports SQLMembershipProvider.EL
''' -----------------------------------------------------------------------------
''' Project	 : SQLMembershipProvider
''' Class	 : ucVistaDetalleSistemas
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla Sistemas
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	28/03/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSistemas
    Inherits ucBase
 
#Region"Propiedades"

    Private _IdSistema As Int32
    Public Property IdSistema1() As Int32
        Get
            Return Me.txtIdSistema.Text
        End Get
        Set(ByVal Value As Int32)
            Me._IdSistema = Value
            Me.txtIdSistema.Text = CStr(Value)
            If Me._IdSistema > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NombreSistema() As String
        Get
            Return Me.txtNombreSistema.Text
        End Get
        Set(ByVal value As String)
            Me.txtNombreSistema.Text = value.ToString()
        End Set
    End Property

    Public Property VerIdSistema() As Boolean
        Get
            Return Me.trIdSistema.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trIdSistema.Visible = value
        End Set
    End Property

    Public Property VerNombreSistema() As Boolean
        Get
            Return Me.trNombreSistema.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNombreSistema.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cSistemas
    Private mEntidad As Sistemas
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property
 
    Public Property Enabled() As Boolean
        Get
            Return Me._Enabled
        End Get
        Set(ByVal Value As Boolean)
            Me._Enabled = Value
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("IdSistema") Is Nothing Then Me._IdSistema = Me.ViewState("IdSistema")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla Sistemas
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/03/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New Sistemas
        mEntidad.IdSistema = IdSistema1
 
        If mComponente.ObtenerSistemas(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtIdSistema.Text = mEntidad.IdSistema.ToString()
        Me.txtNombreSistema.Text = mEntidad.NombreSistema
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/03/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtNombreSistema.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/03/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtNombreSistema.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla Sistemas
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	28/03/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New Sistemas
        If Me._nuevo Then
            mEntidad.IdSistema = 0
        Else
            mEntidad.IdSistema = CInt(Me.txtIdSistema.Text)
        End If
        mEntidad.NombreSistema = Me.txtNombreSistema.Text

        If mComponente.ActualizarSistemas(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtIdSistema.Text = mEntidad.IdSistema.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
