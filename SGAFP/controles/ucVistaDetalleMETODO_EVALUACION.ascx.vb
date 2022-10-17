Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleMETODO_EVALUACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla METODO_EVALUACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleMETODO_EVALUACION
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_METODO_EVALUACION As Decimal
    Public Property ID_METODO_EVALUACION() As Decimal
        Get
            Return Me.txtID_METODO_EVALUACION.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_METODO_EVALUACION = Value
            Me.txtID_METODO_EVALUACION.Text = CStr(Value)
            If Me._ID_METODO_EVALUACION > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_METODO_EVALUACION() As Boolean
        Get
            Return Me.trID_METODO_EVALUACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_METODO_EVALUACION.Visible = value
        End Set
    End Property

    Public Property VerMETODO_EVALUACION() As Boolean
        Get
            Return Me.trMETODO_EVALUACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMETODO_EVALUACION.Visible = value
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
    Private mComponente As New cMETODO_EVALUACION
    Private mEntidad As METODO_EVALUACION
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
        If Not Me.ViewState("ID_METODO_EVALUACION") Is Nothing Then Me._ID_METODO_EVALUACION = Me.ViewState("ID_METODO_EVALUACION")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla METODO_EVALUACION
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
        mEntidad = New METODO_EVALUACION
        mEntidad.ID_METODO_EVALUACION = ID_METODO_EVALUACION
 
        If mComponente.ObtenerMETODO_EVALUACION(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_METODO_EVALUACION.Text = mEntidad.ID_METODO_EVALUACION.ToString()
        Me.txtMETODO_EVALUACION.Text = mEntidad.METODO_EVALUACION
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
        Me.txtMETODO_EVALUACION.Enabled = edicion
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
        Me.txtMETODO_EVALUACION.Text = ""
        Me.txtNOTAS.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla METODO_EVALUACION
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
        mEntidad = New METODO_EVALUACION
        If Me._nuevo Then
            mEntidad.ID_METODO_EVALUACION = 0
        Else
            mEntidad.ID_METODO_EVALUACION = CInt(Me.txtID_METODO_EVALUACION.Text)
        End If
        mEntidad.METODO_EVALUACION = Me.txtMETODO_EVALUACION.Text
        mEntidad.NOTAS = Me.txtNOTAS.Text

        If mComponente.ActualizarMETODO_EVALUACION(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_METODO_EVALUACION.Text = mEntidad.ID_METODO_EVALUACION.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
