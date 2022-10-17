Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleCATCURSO_2
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CATCURSO_2
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCATCURSO_2
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CURSO As Decimal
    Public Property ID_CURSO() As Decimal
        Get
            Return Me.txtID_CURSO.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_CURSO = Value
            Me.txtID_CURSO.Text = CStr(Value)
            If Me._ID_CURSO > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_CURSO() As Boolean
        Get
            Return Me.trID_CURSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CURSO.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE() As Boolean
        Get
            Return Me.trNOMBRE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE.Visible = value
        End Set
    End Property

    Public Property VerDURACION() As Boolean
        Get
            Return Me.trDURACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDURACION.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cCATCURSO_2
    Private mEntidad As CATCURSO_2
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
        If Not Me.ViewState("ID_CURSO") Is Nothing Then Me._ID_CURSO = Me.ViewState("ID_CURSO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla CATCURSO_2
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
        mEntidad = New CATCURSO_2
        mEntidad.ID_CURSO = ID_CURSO
 
        If mComponente.ObtenerCATCURSO_2(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CURSO.Text = mEntidad.ID_CURSO.ToString()
        Me.txtNOMBRE.Text = mEntidad.NOMBRE
        Me.txtDURACION.Text = mEntidad.DURACION
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
        Me.txtNOMBRE.Enabled = edicion
        Me.txtDURACION.Enabled = edicion
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
        Me.txtNOMBRE.Text = ""
        Me.txtDURACION.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla CATCURSO_2
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
        mEntidad = New CATCURSO_2
        If Me._nuevo Then
            mEntidad.ID_CURSO = 0
        Else
            mEntidad.ID_CURSO = CInt(Me.txtID_CURSO.Text)
        End If
        mEntidad.NOMBRE = Me.txtNOMBRE.Text
        mEntidad.DURACION = Val(Me.txtDURACION.Text)

        If mComponente.ActualizarCATCURSO_2(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CURSO.Text = mEntidad.ID_CURSO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
