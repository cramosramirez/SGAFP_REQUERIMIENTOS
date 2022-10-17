Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleFASE_ESTADO_INFORME
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla FASE_ESTADO_INFORME
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/07/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleFASE_ESTADO_INFORME
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_FASE_ESTADO As Decimal
    Public Property ID_FASE_ESTADO() As Decimal
        Get
            Return Me.txtID_FASE_ESTADO.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_FASE_ESTADO = Value
            Me.txtID_FASE_ESTADO.Text = CStr(Value)
            If Me._ID_FASE_ESTADO > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NOMBRE_FASE_ESTADO() As String
        Get
            Return Me.txtNOMBRE_FASE_ESTADO.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_FASE_ESTADO.Text = value.ToString()
        End Set
    End Property

    Public Property USERID() As String
        Get
            Return Me.txtUSERID.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSERID.Text = value.ToString()
        End Set
    End Property

    Public Property LASTUPDATE() As DateTime
        Get
            Return Me.deLASTUPDATE.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deLASTUPDATE.Value = value
        End Set
    End Property

    Public Property VerID_FASE_ESTADO() As Boolean
        Get
            Return Me.trID_FASE_ESTADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_FASE_ESTADO.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_FASE_ESTADO() As Boolean
        Get
            Return Me.trNOMBRE_FASE_ESTADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_FASE_ESTADO.Visible = value
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
    Private mComponente As New cFASE_ESTADO_INFORME
    Private mEntidad As FASE_ESTADO_INFORME
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
        If Not Me.ViewState("ID_FASE_ESTADO") Is Nothing Then Me._ID_FASE_ESTADO = Me.ViewState("ID_FASE_ESTADO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla FASE_ESTADO_INFORME
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New FASE_ESTADO_INFORME
        mEntidad.ID_FASE_ESTADO = ID_FASE_ESTADO
 
        If mComponente.ObtenerFASE_ESTADO_INFORME(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_FASE_ESTADO.Text = mEntidad.ID_FASE_ESTADO.ToString()
        Me.txtNOMBRE_FASE_ESTADO.Text = mEntidad.NOMBRE_FASE_ESTADO
        Me.txtUSERID.Text = mEntidad.USERID
        Me.deLASTUPDATE.Value = mEntidad.LASTUPDATE
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtNOMBRE_FASE_ESTADO.Enabled = edicion
        Me.txtUSERID.Enabled = False
        Me.deLASTUPDATE.Enabled = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.txtNOMBRE_FASE_ESTADO.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.deLASTUPDATE.Value = Now
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla FASE_ESTADO_INFORME
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New FASE_ESTADO_INFORME
        If Me._nuevo Then
            mEntidad.ID_FASE_ESTADO = 0
        Else
            mEntidad.ID_FASE_ESTADO = CInt(Me.txtID_FASE_ESTADO.Text)
        End If
        mEntidad.NOMBRE_FASE_ESTADO = Me.txtNOMBRE_FASE_ESTADO.Text
        mEntidad.USERID = Me.ObtenerUsuario()
        mEntidad.LASTUPDATE = Me.deLASTUPDATE.Value

        If mComponente.ActualizarFASE_ESTADO_INFORME(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_FASE_ESTADO.Text = mEntidad.ID_FASE_ESTADO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
