Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleOPCION_MENU
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla OPCION_MENU
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleOPCION_MENU
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_OPCION_MENU As Decimal
    Public Property ID_OPCION_MENU() As Decimal
        Get
            Return Me.txtID_OPCION_MENU.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_OPCION_MENU = Value
            Me.txtID_OPCION_MENU.Text = CStr(Value)
            If Me._ID_OPCION_MENU > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_OPCION_MENU() As Boolean
        Get
            Return Me.trID_OPCION_MENU.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_OPCION_MENU.Visible = value
        End Set
    End Property

    Public Property VerOPCION_MENU() As Boolean
        Get
            Return Me.trOPCION_MENU.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOPCION_MENU.Visible = value
        End Set
    End Property

    Public Property VerOPCION_SISTEMA() As Boolean
        Get
            Return Me.trOPCION_SISTEMA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOPCION_SISTEMA.Visible = value
        End Set
    End Property

    Public Property VerURL() As Boolean
        Get
            Return Me.trURL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trURL.Visible = value
        End Set
    End Property

    Public Property VerPAGINA_HTML() As Boolean
        Get
            Return Me.trPAGINA_HTML.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPAGINA_HTML.Visible = value
        End Set
    End Property

    Public Property VerOBJETO_USUARIO() As Boolean
        Get
            Return Me.trOBJETO_USUARIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOBJETO_USUARIO.Visible = value
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
    Private mComponente As New cOPCION_MENU
    Private mEntidad As OPCION_MENU
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
        If Not Me.ViewState("ID_OPCION_MENU") Is Nothing Then Me._ID_OPCION_MENU = Me.ViewState("ID_OPCION_MENU")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla OPCION_MENU
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
        mEntidad = New OPCION_MENU
        mEntidad.ID_OPCION_MENU = ID_OPCION_MENU
 
        If mComponente.ObtenerOPCION_MENU(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_OPCION_MENU.Text = mEntidad.ID_OPCION_MENU.ToString()
        Me.txtOPCION_MENU.Text = mEntidad.OPCION_MENU
        Me.txtOPCION_SISTEMA.Text = mEntidad.OPCION_SISTEMA
        Me.txtURL.Text = mEntidad.URL
        Me.txtPAGINA_HTML.Text = mEntidad.PAGINA_HTML
        Me.txtOBJETO_USUARIO.Text = mEntidad.OBJETO_USUARIO
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
        Me.txtOPCION_MENU.Enabled = edicion
        Me.txtOPCION_SISTEMA.Enabled = edicion
        Me.txtURL.Enabled = edicion
        Me.txtPAGINA_HTML.Enabled = edicion
        Me.txtOBJETO_USUARIO.Enabled = edicion
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
        Me.txtOPCION_MENU.Text = ""
        Me.txtOPCION_SISTEMA.Text = ""
        Me.txtURL.Text = ""
        Me.txtPAGINA_HTML.Text = ""
        Me.txtOBJETO_USUARIO.Text = ""
        Me.txtNOTAS.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla OPCION_MENU
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
        mEntidad = New OPCION_MENU
        If Me._nuevo Then
            mEntidad.ID_OPCION_MENU = 0
        Else
            mEntidad.ID_OPCION_MENU = CInt(Me.txtID_OPCION_MENU.Text)
        End If
        mEntidad.OPCION_MENU = Me.txtOPCION_MENU.Text
        mEntidad.OPCION_SISTEMA = Me.txtOPCION_SISTEMA.Text
        mEntidad.URL = Me.txtURL.Text
        mEntidad.PAGINA_HTML = Me.txtPAGINA_HTML.Text
        mEntidad.OBJETO_USUARIO = Me.txtOBJETO_USUARIO.Text
        mEntidad.NOTAS = Me.txtNOTAS.Text

        If mComponente.ActualizarOPCION_MENU(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_OPCION_MENU.Text = mEntidad.ID_OPCION_MENU.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
