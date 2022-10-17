Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleAREA_SUPERVISION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla AREA_SUPERVISION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleAREA_SUPERVISION
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_AREA_SUPERVISION As Decimal
    Public Property ID_AREA_SUPERVISION() As Decimal
        Get
            Return Me.txtID_AREA_SUPERVISION.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_AREA_SUPERVISION = Value
            Me.txtID_AREA_SUPERVISION.Text = CStr(Value)
            If Me._ID_AREA_SUPERVISION > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_AREA_SUPERVISION() As Boolean
        Get
            Return Me.trID_AREA_SUPERVISION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_AREA_SUPERVISION.Visible = value
        End Set
    End Property

    Public Property VerAREA_SUPERVISION() As Boolean
        Get
            Return Me.trAREA_SUPERVISION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAREA_SUPERVISION.Visible = value
        End Set
    End Property

    Public Property VerSANCIONATORIA() As Boolean
        Get
            Return Me.trSANCIONATORIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSANCIONATORIA.Visible = value
        End Set
    End Property

    Public Property VerMONTO_SANCION() As Boolean
        Get
            Return Me.trMONTO_SANCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMONTO_SANCION.Visible = value
        End Set
    End Property

    Public Property VerTIEMPO_SANCION() As Boolean
        Get
            Return Me.trTIEMPO_SANCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIEMPO_SANCION.Visible = value
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
    Private mComponente As New cAREA_SUPERVISION
    Private mEntidad As AREA_SUPERVISION
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
        If Not Me.ViewState("ID_AREA_SUPERVISION") Is Nothing Then Me._ID_AREA_SUPERVISION = Me.ViewState("ID_AREA_SUPERVISION")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla AREA_SUPERVISION
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
        mEntidad = New AREA_SUPERVISION
        mEntidad.ID_AREA_SUPERVISION = ID_AREA_SUPERVISION
 
        If mComponente.ObtenerAREA_SUPERVISION(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_AREA_SUPERVISION.Text = mEntidad.ID_AREA_SUPERVISION.ToString()
        Me.txtAREA_SUPERVISION.Text = mEntidad.AREA_SUPERVISION
        Me.txtSANCIONATORIA.Text = mEntidad.SANCIONATORIA
        Me.txtMONTO_SANCION.Text = mEntidad.MONTO_SANCION
        Me.txtTIEMPO_SANCION.Text = mEntidad.TIEMPO_SANCION
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
        Me.txtAREA_SUPERVISION.Enabled = edicion
        Me.txtSANCIONATORIA.Enabled = edicion
        Me.txtMONTO_SANCION.Enabled = edicion
        Me.txtTIEMPO_SANCION.Enabled = edicion
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
        Me.txtAREA_SUPERVISION.Text = ""
        Me.txtSANCIONATORIA.Text = ""
        Me.txtMONTO_SANCION.Text = ""
        Me.txtTIEMPO_SANCION.Text = ""
        Me.txtNOTAS.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla AREA_SUPERVISION
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
        mEntidad = New AREA_SUPERVISION
        If Me._nuevo Then
            mEntidad.ID_AREA_SUPERVISION = 0
        Else
            mEntidad.ID_AREA_SUPERVISION = CInt(Me.txtID_AREA_SUPERVISION.Text)
        End If
        mEntidad.AREA_SUPERVISION = Me.txtAREA_SUPERVISION.Text
        mEntidad.SANCIONATORIA = Me.txtSANCIONATORIA.Text
        mEntidad.MONTO_SANCION = Val(Me.txtMONTO_SANCION.Text)
        mEntidad.TIEMPO_SANCION = Val(Me.txtTIEMPO_SANCION.Text)
        mEntidad.NOTAS = Me.txtNOTAS.Text

        If mComponente.ActualizarAREA_SUPERVISION(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_AREA_SUPERVISION.Text = mEntidad.ID_AREA_SUPERVISION.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
