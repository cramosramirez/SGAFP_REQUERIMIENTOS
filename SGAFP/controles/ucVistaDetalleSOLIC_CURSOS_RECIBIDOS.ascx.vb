Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleSOLIC_CURSOS_RECIBIDOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SOLIC_CURSOS_RECIBIDOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSOLIC_CURSOS_RECIBIDOS
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_CURSO_RECIBIDO As Decimal
    Public Property ID_CURSO_RECIBIDO() As Decimal
        Get
            Return Me.txtID_CURSO_RECIBIDO.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_CURSO_RECIBIDO = Value
            Me.txtID_CURSO_RECIBIDO.Text = CStr(Value)
            If Me._ID_CURSO_RECIBIDO > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_CURSO_RECIBIDO() As Boolean
        Get
            Return Me.trID_CURSO_RECIBIDO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_CURSO_RECIBIDO.Visible = value
        End Set
    End Property

    Public Property VerID_SOLICITUD() As Boolean
        Get
            Return Me.trID_SOLICITUD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_SOLICITUD.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_CURSO() As Boolean
        Get
            Return Me.trNOMBRE_CURSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_CURSO.Visible = value
        End Set
    End Property

    Public Property VerINSTITUCION_CURSO() As Boolean
        Get
            Return Me.trINSTITUCION_CURSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trINSTITUCION_CURSO.Visible = value
        End Set
    End Property

    Public Property VerAPOYO_INSAFORP() As Boolean
        Get
            Return Me.trAPOYO_INSAFORP.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAPOYO_INSAFORP.Visible = value
        End Set
    End Property

    Public Property VerANIO() As Boolean
        Get
            Return Me.trANIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trANIO.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cSOLIC_CURSOS_RECIBIDOS
    Private mEntidad As SOLIC_CURSOS_RECIBIDOS
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
        If Not Me.ViewState("ID_CURSO_RECIBIDO") Is Nothing Then Me._ID_CURSO_RECIBIDO = Me.ViewState("ID_CURSO_RECIBIDO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla SOLIC_CURSOS_RECIBIDOS
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
        mEntidad = New SOLIC_CURSOS_RECIBIDOS
        mEntidad.ID_CURSO_RECIBIDO = ID_CURSO_RECIBIDO
 
        If mComponente.ObtenerSOLIC_CURSOS_RECIBIDOS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_CURSO_RECIBIDO.Text = mEntidad.ID_CURSO_RECIBIDO.ToString()
        Me.ddlSOLICITUD_INSCRIPCION_AF1.Recuperar()
        Me.ddlSOLICITUD_INSCRIPCION_AF1.SelectedValue = mEntidad.ID_SOLICITUD
        Me.txtNOMBRE_CURSO.Text = mEntidad.NOMBRE_CURSO
        Me.txtAPOYO_INSAFORP.Text = mEntidad.APOYO_INSAFORP
        Me.txtANIO.Text = mEntidad.ANIO
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
        Me.ddlSOLICITUD_INSCRIPCION_AF1.Enabled = edicion
        Me.txtNOMBRE_CURSO.Enabled = edicion
        Me.txtINSTITUCION_CURSO.Enabled = edicion
        Me.txtAPOYO_INSAFORP.Enabled = edicion
        Me.txtANIO.Enabled = edicion
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
        Me.ddlSOLICITUD_INSCRIPCION_AF1.Recuperar()
        Me.txtNOMBRE_CURSO.Text = ""
        Me.txtINSTITUCION_CURSO.Text = ""
        Me.txtAPOYO_INSAFORP.Text = ""
        Me.txtANIO.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla SOLIC_CURSOS_RECIBIDOS
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
        mEntidad = New SOLIC_CURSOS_RECIBIDOS
        If Me._nuevo Then
            mEntidad.ID_CURSO_RECIBIDO = 0
        Else
            mEntidad.ID_CURSO_RECIBIDO = CInt(Me.txtID_CURSO_RECIBIDO.Text)
        End If
        mEntidad.ID_SOLICITUD = Me.ddlSOLICITUD_INSCRIPCION_AF1.SelectedValue
        mEntidad.NOMBRE_CURSO = Me.txtNOMBRE_CURSO.Text
 
        mEntidad.APOYO_INSAFORP = Val(Me.txtAPOYO_INSAFORP.Text)
        mEntidad.ANIO = Val(Me.txtANIO.Text)
        If mComponente.ActualizarSOLIC_CURSOS_RECIBIDOS(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_CURSO_RECIBIDO.Text = mEntidad.ID_CURSO_RECIBIDO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
