Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleOPCION_GRUPO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla OPCION_GRUPO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleOPCION_GRUPO
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_OPCION_GRUPO As Decimal
    Public Property ID_OPCION_GRUPO() As Decimal
        Get
            Return Me.txtID_OPCION_GRUPO.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_OPCION_GRUPO = Value
            Me.txtID_OPCION_GRUPO.Text = CStr(Value)
            If Me._ID_OPCION_GRUPO > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_OPCION_GRUPO() As Boolean
        Get
            Return Me.trID_OPCION_GRUPO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_OPCION_GRUPO.Visible = value
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

    Public Property VerID_GRUPO_USUARIO() As Boolean
        Get
            Return Me.trID_GRUPO_USUARIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_GRUPO_USUARIO.Visible = value
        End Set
    End Property

    Public Property VerFECHA_INGRESO() As Boolean
        Get
            Return Me.trFECHA_INGRESO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_INGRESO.Visible = value
        End Set
    End Property

    Public Property VerESTADO() As Boolean
        Get
            Return Me.trESTADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trESTADO.Visible = value
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
    Private mComponente As New cOPCION_GRUPO
    Private mEntidad As OPCION_GRUPO
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
        If Not Me.ViewState("ID_OPCION_GRUPO") Is Nothing Then Me._ID_OPCION_GRUPO = Me.ViewState("ID_OPCION_GRUPO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla OPCION_GRUPO
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
        mEntidad = New OPCION_GRUPO
        mEntidad.ID_OPCION_GRUPO = ID_OPCION_GRUPO
 
        If mComponente.ObtenerOPCION_GRUPO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_OPCION_GRUPO.Text = mEntidad.ID_OPCION_GRUPO.ToString()
        Me.ddlOPCION_MENU1.Recuperar()
        Me.ddlOPCION_MENU1.SelectedValue = mEntidad.ID_OPCION_MENU
        Me.ddlGRUPO_USUARIO1.Recuperar()
        Me.ddlGRUPO_USUARIO1.SelectedValue = mEntidad.ID_GRUPO_USUARIO
        Me.txtFECHA_INGRESO.Text = IIf(Not mEntidad.FECHA_INGRESO = Nothing, Format(mEntidad.FECHA_INGRESO, "dd/MM/yyyy"), "")
        Me.txtESTADO.Text = mEntidad.ESTADO
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
        Me.ddlOPCION_MENU1.Enabled = edicion
        Me.ddlGRUPO_USUARIO1.Enabled = edicion
        Me.txtFECHA_INGRESO.Enabled = edicion
        Me.txtESTADO.Enabled = edicion
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
        Me.ddlOPCION_MENU1.Recuperar()
        Me.ddlGRUPO_USUARIO1.Recuperar()
        Me.txtFECHA_INGRESO.Text = ""
        Me.txtESTADO.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.txtLASTUPDATE.Text = Now.ToString("dd/MM/yyyy")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla OPCION_GRUPO
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
        mEntidad = New OPCION_GRUPO
        If Me._nuevo Then
            mEntidad.ID_OPCION_GRUPO = 0
        Else
            mEntidad.ID_OPCION_GRUPO = CInt(Me.txtID_OPCION_GRUPO.Text)
        End If
        mEntidad.ID_OPCION_MENU = Me.ddlOPCION_MENU1.SelectedValue
        mEntidad.ID_GRUPO_USUARIO = Me.ddlGRUPO_USUARIO1.SelectedValue
        If Me.txtFECHA_INGRESO.Text <> "" Then mEntidad.FECHA_INGRESO = System.DateTime.Parse(Me.txtFECHA_INGRESO.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.ESTADO = Me.txtESTADO.Text
        mEntidad.USERID = Me.ObtenerUsuario()
        If Me.txtLASTUPDATE.Text <> "" Then mEntidad.LASTUPDATE = System.DateTime.Parse(Me.txtLASTUPDATE.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If mComponente.ActualizarOPCION_GRUPO(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_OPCION_GRUPO.Text = mEntidad.ID_OPCION_GRUPO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
