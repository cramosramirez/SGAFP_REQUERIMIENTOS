Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleTIPO_SOLICITUD
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla TIPO_SOLICITUD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleTIPO_SOLICITUD
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_TIPO_SOLICITUD As Decimal
    Public Property ID_TIPO_SOLICITUD() As Decimal
        Get
            Return Me.txtID_TIPO_SOLICITUD.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_TIPO_SOLICITUD = Value
            Me.txtID_TIPO_SOLICITUD.Text = CStr(Value)
            If Me._ID_TIPO_SOLICITUD > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_TIPO_SOLICITUD() As Boolean
        Get
            Return Me.trID_TIPO_SOLICITUD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIPO_SOLICITUD.Visible = value
        End Set
    End Property

    Public Property VerCODIGO_PROCESO() As Boolean
        Get
            Return Me.trCODIGO_PROCESO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_PROCESO.Visible = value
        End Set
    End Property

    Public Property VerTIPO_SOLICITUD() As Boolean
        Get
            Return Me.trTIPO_SOLICITUD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_SOLICITUD.Visible = value
        End Set
    End Property

    Public Property VerTABLA_RELACIONAL() As Boolean
        Get
            Return Me.trTABLA_RELACIONAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTABLA_RELACIONAL.Visible = value
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
    Private mComponente As New cTIPO_SOLICITUD
    Private mEntidad As TIPO_SOLICITUD
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
        If Not Me.ViewState("ID_TIPO_SOLICITUD") Is Nothing Then Me._ID_TIPO_SOLICITUD = Me.ViewState("ID_TIPO_SOLICITUD")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla TIPO_SOLICITUD
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
        mEntidad = New TIPO_SOLICITUD
        mEntidad.ID_TIPO_SOLICITUD = ID_TIPO_SOLICITUD
 
        If mComponente.ObtenerTIPO_SOLICITUD(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_TIPO_SOLICITUD.Text = mEntidad.ID_TIPO_SOLICITUD.ToString()
        Me.ddlPROCESO1.Recuperar()
        Me.ddlPROCESO1.SelectedValue = mEntidad.CODIGO_PROCESO
        Me.txtTIPO_SOLICITUD.Text = mEntidad.TIPO_SOLICITUD
        Me.txtTABLA_RELACIONAL.Text = mEntidad.TABLA_RELACIONAL
        Me.txtNOTAS.Text = mEntidad.NOTAS
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
        Me.ddlPROCESO1.Enabled = edicion
        Me.txtTIPO_SOLICITUD.Enabled = edicion
        Me.txtTABLA_RELACIONAL.Enabled = edicion
        Me.txtNOTAS.Enabled = edicion
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
        Me.ddlPROCESO1.Recuperar()
        Me.txtTIPO_SOLICITUD.Text = ""
        Me.txtTABLA_RELACIONAL.Text = ""
        Me.txtNOTAS.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.txtLASTUPDATE.Text = Now.ToString("dd/MM/yyyy")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla TIPO_SOLICITUD
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
        mEntidad = New TIPO_SOLICITUD
        If Me._nuevo Then
            mEntidad.ID_TIPO_SOLICITUD = 0
        Else
            mEntidad.ID_TIPO_SOLICITUD = CInt(Me.txtID_TIPO_SOLICITUD.Text)
        End If
        mEntidad.CODIGO_PROCESO = Me.ddlPROCESO1.SelectedValue
        mEntidad.TIPO_SOLICITUD = Me.txtTIPO_SOLICITUD.Text
        mEntidad.TABLA_RELACIONAL = Me.txtTABLA_RELACIONAL.Text
        mEntidad.NOTAS = Me.txtNOTAS.Text
        mEntidad.USERID = Me.ObtenerUsuario()
        If Me.txtLASTUPDATE.Text <> "" Then mEntidad.LASTUPDATE = System.DateTime.Parse(Me.txtLASTUPDATE.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If mComponente.ActualizarTIPO_SOLICITUD(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_TIPO_SOLICITUD.Text = mEntidad.ID_TIPO_SOLICITUD.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
