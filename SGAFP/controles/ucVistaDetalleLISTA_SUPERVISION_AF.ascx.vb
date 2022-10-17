Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleLISTA_SUPERVISION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla LISTA_SUPERVISION_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleLISTA_SUPERVISION_AF
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_LISTA_SUPERVISION As Decimal
    Public Property ID_LISTA_SUPERVISION() As Decimal
        Get
            Return Me.txtID_LISTA_SUPERVISION.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_LISTA_SUPERVISION = Value
            Me.txtID_LISTA_SUPERVISION.Text = CStr(Value)
            If Me._ID_LISTA_SUPERVISION > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_LISTA_SUPERVISION() As Boolean
        Get
            Return Me.trID_LISTA_SUPERVISION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_LISTA_SUPERVISION.Visible = value
        End Set
    End Property

    Public Property VerLISTA_SUPERVISION() As Boolean
        Get
            Return Me.trLISTA_SUPERVISION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLISTA_SUPERVISION.Visible = value
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
    Private mComponente As New cLISTA_SUPERVISION_AF
    Private mEntidad As LISTA_SUPERVISION_AF
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
        If Not Me.ViewState("ID_LISTA_SUPERVISION") Is Nothing Then Me._ID_LISTA_SUPERVISION = Me.ViewState("ID_LISTA_SUPERVISION")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla LISTA_SUPERVISION_AF
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
        mEntidad = New LISTA_SUPERVISION_AF
        mEntidad.ID_LISTA_SUPERVISION = ID_LISTA_SUPERVISION
 
        If mComponente.ObtenerLISTA_SUPERVISION_AF(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_LISTA_SUPERVISION.Text = mEntidad.ID_LISTA_SUPERVISION.ToString()
        Me.txtLISTA_SUPERVISION.Text = mEntidad.LISTA_SUPERVISION
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
        Me.txtLISTA_SUPERVISION.Enabled = edicion
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
        Me.txtLISTA_SUPERVISION.Text = ""
        Me.txtNOTAS.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla LISTA_SUPERVISION_AF
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
        mEntidad = New LISTA_SUPERVISION_AF
        If Me._nuevo Then
            mEntidad.ID_LISTA_SUPERVISION = 0
        Else
            mEntidad.ID_LISTA_SUPERVISION = CInt(Me.txtID_LISTA_SUPERVISION.Text)
        End If
        mEntidad.LISTA_SUPERVISION = Me.txtLISTA_SUPERVISION.Text
        mEntidad.NOTAS = Me.txtNOTAS.Text

        If mComponente.ActualizarLISTA_SUPERVISION_AF(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_LISTA_SUPERVISION.Text = mEntidad.ID_LISTA_SUPERVISION.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
