Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleASISTENCIA_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ASISTENCIA_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleASISTENCIA_AF
    Inherits ucBase
 
#Region"Propiedades"

    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            If Me.txtID_ACCION_FORMATIVA.Text = "" Then Return 0
            Return Convert.ToDecimal(Me.txtID_ACCION_FORMATIVA.Text)
        End Get
        Set(ByVal Value As Decimal)
            txtID_ACCION_FORMATIVA.Text = Value.ToString()
        End Set
    End Property

    Private _ID_ASISTENCIA_AF As Decimal
    Public Property ID_ASISTENCIA_AF() As Decimal
        Get
            Return Me.txtID_ASISTENCIA_AF.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_ASISTENCIA_AF = Value
            Me.txtID_ASISTENCIA_AF.Text = CStr(Value)
            If Me._ID_ASISTENCIA_AF > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_ASISTENCIA_AF() As Boolean
        Get
            Return Me.trID_ASISTENCIA_AF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ASISTENCIA_AF.Visible = value
        End Set
    End Property

    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me.trID_ACCION_FORMATIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Public Property VerFECHA() As Boolean
        Get
            Return Me.trFECHA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA.Visible = value
        End Set
    End Property

    Public Property VerINSTRUCTOR() As Boolean
        Get
            Return Me.trINSTRUCTOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trINSTRUCTOR.Visible = value
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
    Private mComponente As New cASISTENCIA_AF
    Private mEntidad As ASISTENCIA_AF
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
        If Not Me.ViewState("ID_ASISTENCIA_AF") Is Nothing Then Me._ID_ASISTENCIA_AF = Me.ViewState("ID_ASISTENCIA_AF")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla ASISTENCIA_AF
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
        mEntidad = New ASISTENCIA_AF
        mEntidad.ID_ASISTENCIA_AF = ID_ASISTENCIA_AF
 
        If mComponente.ObtenerASISTENCIA_AF(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ASISTENCIA_AF.Text = mEntidad.ID_ASISTENCIA_AF.ToString()
        Me.txtID_ACCION_FORMATIVA.Text = mEntidad.ID_ACCION_FORMATIVA.ToString()
        Me.txtFECHA.Text = IIf(Not mEntidad.FECHA = Nothing, Format(mEntidad.FECHA, "dd/MM/yyyy"), "")
        Me.txtINSTRUCTOR.Text = mEntidad.INSTRUCTOR
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
        Me.txtFECHA.Enabled = edicion
        Me.txtINSTRUCTOR.Enabled = edicion
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
        Me.txtFECHA.Text = ""
        Me.txtINSTRUCTOR.Text = ""
        Me.txtNOTAS.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla ASISTENCIA_AF
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
    ''' 	[ecarias]	21/04/2010	Se agrego que muestre el mensaje de Error devuelto
    '''                             en el componente de logica de negocios.
    ''' 	[ecarias]	21/04/2010	Se agrego que recupere el registro completo antes
    '''                             de actualizar un registro ya existente.
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New ASISTENCIA_AF
        If Me._nuevo Then
            mEntidad.ID_ASISTENCIA_AF = 0
        Else
            mEntidad.ID_ASISTENCIA_AF = CInt(Me.txtID_ASISTENCIA_AF.Text)
            mComponente.ObtenerASISTENCIA_AF(mEntidad)
        End If
        mEntidad.ID_ACCION_FORMATIVA = Me.ID_ACCION_FORMATIVA
        If Me.txtFECHA.Text <> "" Then mEntidad.FECHA = System.DateTime.Parse(Me.txtFECHA.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.INSTRUCTOR = Me.txtINSTRUCTOR.Text
        mEntidad.NOTAS = Me.txtNOTAS.Text

        If mComponente.ActualizarASISTENCIA_AF(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro." + mComponente.sError, True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_ASISTENCIA_AF.Text = mEntidad.ID_ASISTENCIA_AF.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

End Class
