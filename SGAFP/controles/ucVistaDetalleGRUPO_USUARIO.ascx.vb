Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleGRUPO_USUARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla GRUPO_USUARIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleGRUPO_USUARIO
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_GRUPO_USUARIO As Decimal
    Public Property ID_GRUPO_USUARIO() As Decimal
        Get
            Return Me.txtID_GRUPO_USUARIO.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_GRUPO_USUARIO = Value
            Me.txtID_GRUPO_USUARIO.Text = CStr(Value)
            If Me._ID_GRUPO_USUARIO > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_GRUPO_USUARIO() As Boolean
        Get
            Return Me.trID_GRUPO_USUARIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_GRUPO_USUARIO.Visible = value
        End Set
    End Property

    Public Property VerROL_USUARIO() As Boolean
        Get
            Return Me.trROL_USUARIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trROL_USUARIO.Visible = value
        End Set
    End Property

    Public Property VerNIVEL() As Boolean
        Get
            Return Me.trNIVEL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNIVEL.Visible = value
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
    Private mComponente As New cGRUPO_USUARIO
    Private mEntidad As GRUPO_USUARIO
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
        If Not Me.ViewState("ID_GRUPO_USUARIO") Is Nothing Then Me._ID_GRUPO_USUARIO = Me.ViewState("ID_GRUPO_USUARIO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla GRUPO_USUARIO
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
        mEntidad = New GRUPO_USUARIO
        mEntidad.ID_GRUPO_USUARIO = ID_GRUPO_USUARIO
 
        If mComponente.ObtenerGRUPO_USUARIO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_GRUPO_USUARIO.Text = mEntidad.ID_GRUPO_USUARIO.ToString()
        Me.txtROL_USUARIO.Text = mEntidad.ROL_USUARIO
        Me.txtNIVEL.Text = mEntidad.NIVEL
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
        Me.txtROL_USUARIO.Enabled = edicion
        Me.txtNIVEL.Enabled = edicion
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
        Me.txtROL_USUARIO.Text = ""
        Me.txtNIVEL.Text = ""
        Me.txtNOTAS.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla GRUPO_USUARIO
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
        mEntidad = New GRUPO_USUARIO
        If Me._nuevo Then
            mEntidad.ID_GRUPO_USUARIO = 0
        Else
            mEntidad.ID_GRUPO_USUARIO = CInt(Me.txtID_GRUPO_USUARIO.Text)
        End If
        mEntidad.ROL_USUARIO = Me.txtROL_USUARIO.Text
        mEntidad.NIVEL = Val(Me.txtNIVEL.Text)
        mEntidad.NOTAS = Me.txtNOTAS.Text

        If mComponente.ActualizarGRUPO_USUARIO(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_GRUPO_USUARIO.Text = mEntidad.ID_GRUPO_USUARIO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
