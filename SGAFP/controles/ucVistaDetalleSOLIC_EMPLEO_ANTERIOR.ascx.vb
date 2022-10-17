Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleSOLIC_EMPLEO_ANTERIOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SOLIC_EMPLEO_ANTERIOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSOLIC_EMPLEO_ANTERIOR
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_EMPLEO_ANT As Decimal
    Public Property ID_EMPLEO_ANT() As Decimal
        Get
            Return Me.txtID_EMPLEO_ANT.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_EMPLEO_ANT = Value
            Me.txtID_EMPLEO_ANT.Text = CStr(Value)
            If Me._ID_EMPLEO_ANT > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_SOLICITUD() As Decimal
        Get
            Return Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.Items.FindByValue(value) Is Nothing Then
                Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.SelectedValue = value
            End If
        End Set
    End Property

    Public Property TIEMPO_NO_TRABAJA() As Decimal
        Get
            If Me.txtTIEMPO_NO_TRABAJA.Value Is Nothing Then Return -1
            Return Me.txtTIEMPO_NO_TRABAJA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTIEMPO_NO_TRABAJA.Value = value
        End Set
    End Property

    Public Property VerID_EMPLEO_ANT() As Boolean
        Get
            Return Me.trID_EMPLEO_ANT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_EMPLEO_ANT.Visible = value
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

    Public Property VerTIEMPO_NO_TRABAJA() As Boolean
        Get
            Return Me.trTIEMPO_NO_TRABAJA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIEMPO_NO_TRABAJA.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cSOLIC_EMPLEO_ANTERIOR
    Private mEntidad As SOLIC_EMPLEO_ANTERIOR
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
        If Not Me.ViewState("ID_EMPLEO_ANT") Is Nothing Then Me._ID_EMPLEO_ANT = Me.ViewState("ID_EMPLEO_ANT")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla SOLIC_EMPLEO_ANTERIOR
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New SOLIC_EMPLEO_ANTERIOR
        mEntidad.ID_EMPLEO_ANT = ID_EMPLEO_ANT
 
        If mComponente.ObtenerSOLIC_EMPLEO_ANTERIOR(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_EMPLEO_ANT.Text = mEntidad.ID_EMPLEO_ANT.ToString()
        Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.Recuperar()
        Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.SelectedValue = mEntidad.ID_SOLICITUD
        Me.txtTIEMPO_NO_TRABAJA.Value = mEntidad.TIEMPO_NO_TRABAJA
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.Enabled = edicion
        Me.txtTIEMPO_NO_TRABAJA.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.Recuperar()
        Me.txtTIEMPO_NO_TRABAJA.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla SOLIC_EMPLEO_ANTERIOR
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New SOLIC_EMPLEO_ANTERIOR
        If Me._nuevo Then
            mEntidad.ID_EMPLEO_ANT = 0
        Else
            mEntidad.ID_EMPLEO_ANT = CInt(Me.txtID_EMPLEO_ANT.Text)
        End If
        mEntidad.ID_SOLICITUD = Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.SelectedValue
        mEntidad.TIEMPO_NO_TRABAJA = Me.txtTIEMPO_NO_TRABAJA.Value

        If mComponente.ActualizarSOLIC_EMPLEO_ANTERIOR(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_EMPLEO_ANT.Text = mEntidad.ID_EMPLEO_ANT.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
