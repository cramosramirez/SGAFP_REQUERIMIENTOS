Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleCIUO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CIUO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCIUO
    Inherits ucBase
 
#Region"Propiedades"

    Private _CIUO As String
    Public Property CIUO() As String
        Get
            Return Me.txtCIUO.Text
        End Get
        Set(ByVal Value As String)
            Me._CIUO = Value
            Me.txtCIUO.Text = Value
            If Me._CIUO <> "" Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerCIUO() As Boolean
        Get
            Return Me.trCIUO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCIUO.Visible = value
        End Set
    End Property

    Public Property VerDESCRIPCION() As Boolean
        Get
            Return Me.trDESCRIPCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESCRIPCION.Visible = value
        End Set
    End Property

    Public Property VerDESCRIPCION_NACIONAL() As Boolean
        Get
            Return Me.trDESCRIPCION_NACIONAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESCRIPCION_NACIONAL.Visible = value
        End Set
    End Property

    Public Property VerUSERID() As Boolean
        Get
            Return Me.trUSERID.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSERID.Visible = value
        End Set
    End Property

    Public Property VerLASTUPDATE() As Boolean
        Get
            Return Me.trLASTUPDATE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLASTUPDATE.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cCIUO
    Private mEntidad As CIUO
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
        If Not Me.ViewState("CIUO") Is Nothing Then Me._CIUO = Me.ViewState("CIUO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla CIUO
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
        mEntidad = New CIUO
        mEntidad.CIUO = CIUO
 
        If mComponente.ObtenerCIUO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtCIUO.Text = mEntidad.CIUO
        Me.txtDESCRIPCION.Text = mEntidad.DESCRIPCION
        Me.txtDESCRIPCION_NACIONAL.Text = mEntidad.DESCRIPCION_NACIONAL
        Me.txtUSERID.Text = mEntidad.USERID
        Me.txtLASTUPDATE.Text = IIf(Not mEntidad.LASTUPDATE = Nothing, Format(mEntidad.LASTUPDATE, "dd/MM/yyyy"), "")
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
        Me.txtDESCRIPCION.Enabled = edicion
        Me.txtDESCRIPCION_NACIONAL.Enabled = edicion
        Me.txtUSERID.Enabled = False
        Me.txtLASTUPDATE.Enabled = False
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
        Me.txtDESCRIPCION.Text = ""
        Me.txtDESCRIPCION_NACIONAL.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.txtLASTUPDATE.Text = Now.ToString("dd/MM/yyyy")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla CIUO
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
        mEntidad = New CIUO
        If Me.txtCIUO.Text = "0" Then
            Me.AsignarMensaje("Asigne un valor al Ciuo que sea valido", True, True)
            Return "Error"
        End If
            mEntidad.CIUO = Me.txtCIUO.Text
        mEntidad.DESCRIPCION = Me.txtDESCRIPCION.Text
        mEntidad.DESCRIPCION_NACIONAL = Me.txtDESCRIPCION_NACIONAL.Text
        mEntidad.USERID = Me.ObtenerUsuario()
        If Me.txtLASTUPDATE.Text <> "" Then mEntidad.LASTUPDATE = System.DateTime.Parse(Me.txtLASTUPDATE.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If Me._nuevo Then
            If mComponente.AgregarCIUO(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
         Else
            If mComponente.ActualizarCIUO(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If
        Me.txtCIUO.Text = mEntidad.CIUO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
