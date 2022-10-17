Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleASISTENCIA_AF_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ASISTENCIA_AF_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleASISTENCIA_AF_DET
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_ASISTENCIA_DET As Decimal
    Public Property ID_ASISTENCIA_DET() As Decimal
        Get
            Return Me.txtID_ASISTENCIA_DET.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_ASISTENCIA_DET = Value
            Me.txtID_ASISTENCIA_DET.Text = CStr(Value)
            If Me._ID_ASISTENCIA_DET > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_ASISTENCIA_DET() As Boolean
        Get
            Return Me.trID_ASISTENCIA_DET.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ASISTENCIA_DET.Visible = value
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

    Public Property VerID_PARTICIPANTE() As Boolean
        Get
            Return Me.trID_PARTICIPANTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PARTICIPANTE.Visible = value
        End Set
    End Property

    Public Property VerASISTIO() As Boolean
        Get
            Return Me.trASISTIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trASISTIO.Visible = value
        End Set
    End Property

    Public Property VerPRESENTA_JUSTIFICACION() As Boolean
        Get
            Return Me.trPRESENTA_JUSTIFICACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPRESENTA_JUSTIFICACION.Visible = value
        End Set
    End Property

    Public Property VerJUSTIFICACION() As Boolean
        Get
            Return Me.trJUSTIFICACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trJUSTIFICACION.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cASISTENCIA_AF_DET
    Private mEntidad As ASISTENCIA_AF_DET
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
        If Not Me.ViewState("ID_ASISTENCIA_DET") Is Nothing Then Me._ID_ASISTENCIA_DET = Me.ViewState("ID_ASISTENCIA_DET")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla ASISTENCIA_AF_DET
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
        mEntidad = New ASISTENCIA_AF_DET
        mEntidad.ID_ASISTENCIA_DET = ID_ASISTENCIA_DET
 
        If mComponente.ObtenerASISTENCIA_AF_DET(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ASISTENCIA_DET.Text = mEntidad.ID_ASISTENCIA_DET.ToString()
        Me.ddlASISTENCIA_AF1.Recuperar()
        Me.ddlASISTENCIA_AF1.SelectedValue = mEntidad.ID_ASISTENCIA_AF
        Me.ddlPARTICIPANTE1.Recuperar()
        Me.ddlPARTICIPANTE1.SelectedValue = mEntidad.ID_PARTICIPANTE
        Me.txtASISTIO.Text = mEntidad.ASISTIO
        Me.txtPRESENTA_JUSTIFICACION.Text = mEntidad.PRESENTA_JUSTIFICACION
        Me.txtJUSTIFICACION.Text = mEntidad.JUSTIFICACION
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
        Me.ddlASISTENCIA_AF1.Enabled = edicion
        Me.ddlPARTICIPANTE1.Enabled = edicion
        Me.txtASISTIO.Enabled = edicion
        Me.txtPRESENTA_JUSTIFICACION.Enabled = edicion
        Me.txtJUSTIFICACION.Enabled = edicion
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
        Me.ddlASISTENCIA_AF1.Recuperar()
        Me.ddlPARTICIPANTE1.Recuperar()
        Me.txtASISTIO.Text = ""
        Me.txtPRESENTA_JUSTIFICACION.Text = ""
        Me.txtJUSTIFICACION.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla ASISTENCIA_AF_DET
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
        mEntidad = New ASISTENCIA_AF_DET
        If Me._nuevo Then
            mEntidad.ID_ASISTENCIA_DET = 0
        Else
            mEntidad.ID_ASISTENCIA_DET = CInt(Me.txtID_ASISTENCIA_DET.Text)
        End If
        mEntidad.ID_ASISTENCIA_AF = Me.ddlASISTENCIA_AF1.SelectedValue
        mEntidad.ID_PARTICIPANTE = Me.ddlPARTICIPANTE1.SelectedValue
        mEntidad.ASISTIO = Me.txtASISTIO.Text
        mEntidad.PRESENTA_JUSTIFICACION = Me.txtPRESENTA_JUSTIFICACION.Text
        mEntidad.JUSTIFICACION = Me.txtJUSTIFICACION.Text

        If mComponente.ActualizarASISTENCIA_AF_DET(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_ASISTENCIA_DET.Text = mEntidad.ID_ASISTENCIA_DET.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
