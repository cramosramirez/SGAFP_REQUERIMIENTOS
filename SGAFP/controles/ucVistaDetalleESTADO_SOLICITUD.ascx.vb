Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleESTADO_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ESTADO_SOLICITUD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleESTADO_SOLICITUD
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_ESTADO_SOLICITUD As Decimal
    Public Property ID_ESTADO_SOLICITUD() As Decimal
        Get
            Return Me.txtID_ESTADO_SOLICITUD.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_ESTADO_SOLICITUD = Value
            Me.txtID_ESTADO_SOLICITUD.Text = CStr(Value)
            If Me._ID_ESTADO_SOLICITUD > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_ESTADO_SOLICITUD() As Boolean
        Get
            Return Me.trID_ESTADO_SOLICITUD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ESTADO_SOLICITUD.Visible = value
        End Set
    End Property

    Public Property VerESTADO_SOLICITUD() As Boolean
        Get
            Return Me.trESTADO_SOLICITUD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trESTADO_SOLICITUD.Visible = value
        End Set
    End Property

    Public Property VerNOTAS() As Boolean
        Get
            Return Me.trNOTAS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOTAS.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cESTADO_SOLICITUD
    Private mEntidad As ESTADO_SOLICITUD
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
        If Not Me.ViewState("ID_ESTADO_SOLICITUD") Is Nothing Then Me._ID_ESTADO_SOLICITUD = Me.ViewState("ID_ESTADO_SOLICITUD")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla ESTADO_SOLICITUD
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New ESTADO_SOLICITUD
        mEntidad.ID_ESTADO_SOLICITUD = ID_ESTADO_SOLICITUD
 
        If mComponente.ObtenerESTADO_SOLICITUD(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ESTADO_SOLICITUD.Text = mEntidad.ID_ESTADO_SOLICITUD.ToString()
        Me.txtESTADO_SOLICITUD.Text = mEntidad.ESTADO_SOLICITUD
        Me.txtNOTAS.Text = mEntidad.NOTAS
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtESTADO_SOLICITUD.Enabled = edicion
        Me.txtNOTAS.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtESTADO_SOLICITUD.Text = ""
        Me.txtNOTAS.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla ESTADO_SOLICITUD
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New ESTADO_SOLICITUD
        If Me._nuevo Then
            mEntidad.ID_ESTADO_SOLICITUD = 0
        Else
            mEntidad.ID_ESTADO_SOLICITUD = CInt(Me.txtID_ESTADO_SOLICITUD.Text)
        End If
        mEntidad.ESTADO_SOLICITUD = Me.txtESTADO_SOLICITUD.Text
        mEntidad.NOTAS = Me.txtNOTAS.Text

        If mComponente.ActualizarESTADO_SOLICITUD(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_ESTADO_SOLICITUD.Text = mEntidad.ID_ESTADO_SOLICITUD.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
