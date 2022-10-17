Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleEJERCICIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla EJERCICIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleEJERCICIO
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_EJERCICIO As String
    Public Property ID_EJERCICIO() As String
        Get
            Return Me.txtID_EJERCICIO.Text
        End Get
        Set(ByVal Value As String)
            Me._ID_EJERCICIO = Value
            Me.txtID_EJERCICIO.Text = Value
            If Me._ID_EJERCICIO <> "" Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_EJERCICIO() As Boolean
        Get
            Return Me.trID_EJERCICIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_EJERCICIO.Visible = value
        End Set
    End Property

    Public Property VerETIQUETA() As Boolean
        Get
            Return Me.trETIQUETA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trETIQUETA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_INICIO() As Boolean
        Get
            Return Me.trFECHA_INICIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_INICIO.Visible = value
        End Set
    End Property

    Public Property VerFECHA_FIN() As Boolean
        Get
            Return Me.trFECHA_FIN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_FIN.Visible = value
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
    Private mComponente As New cEJERCICIO
    Private mEntidad As EJERCICIO
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
        If Not Me.ViewState("ID_EJERCICIO") Is Nothing Then Me._ID_EJERCICIO = Me.ViewState("ID_EJERCICIO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla EJERCICIO
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
        mEntidad = New EJERCICIO
        mEntidad.ID_EJERCICIO = ID_EJERCICIO
 
        If mComponente.ObtenerEJERCICIO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_EJERCICIO.Text = mEntidad.ID_EJERCICIO
        Me.txtETIQUETA.Text = mEntidad.ETIQUETA
        Me.txtFECHA_INICIO.Text = IIf(Not mEntidad.FECHA_INICIO = Nothing, Format(mEntidad.FECHA_INICIO, "dd/MM/yyyy"), "")
        Me.txtFECHA_FIN.Text = IIf(Not mEntidad.FECHA_FIN = Nothing, Format(mEntidad.FECHA_FIN, "dd/MM/yyyy"), "")
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
        Me.txtETIQUETA.Enabled = edicion
        Me.txtFECHA_INICIO.Enabled = edicion
        Me.txtFECHA_FIN.Enabled = edicion
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
        Me.txtETIQUETA.Text = ""
        Me.txtFECHA_INICIO.Text = ""
        Me.txtFECHA_FIN.Text = ""
        Me.txtNOTAS.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla EJERCICIO
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
        mEntidad = New EJERCICIO
        If Me.txtID_EJERCICIO.Text = "0" Then
            Me.AsignarMensaje("Asigne un valor al Id ejercicio que sea valido", True, True)
            Return "Error"
        End If
            mEntidad.ID_EJERCICIO = Me.txtID_EJERCICIO.Text
        mEntidad.ETIQUETA = Me.txtETIQUETA.Text
        If Me.txtFECHA_INICIO.Text <> "" Then mEntidad.FECHA_INICIO = System.DateTime.Parse(Me.txtFECHA_INICIO.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        If Me.txtFECHA_FIN.Text <> "" Then mEntidad.FECHA_FIN = System.DateTime.Parse(Me.txtFECHA_FIN.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.NOTAS = Me.txtNOTAS.Text

        If Me._nuevo Then
            If mComponente.AgregarEJERCICIO(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
         Else
            If mComponente.ActualizarEJERCICIO(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If
        Me.txtID_EJERCICIO.Text = mEntidad.ID_EJERCICIO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
