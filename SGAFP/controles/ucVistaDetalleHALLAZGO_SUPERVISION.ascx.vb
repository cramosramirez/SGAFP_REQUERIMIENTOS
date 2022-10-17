Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleHALLAZGO_SUPERVISION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla HALLAZGO_SUPERVISION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleHALLAZGO_SUPERVISION
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_HALLAZGO_SUPERVISION As Decimal
    Public Property ID_HALLAZGO_SUPERVISION() As Decimal
        Get
            Return Me.txtID_HALLAZGO_SUPERVISION.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_HALLAZGO_SUPERVISION = Value
            Me.txtID_HALLAZGO_SUPERVISION.Text = CStr(Value)
            If Me._ID_HALLAZGO_SUPERVISION > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_HALLAZGO_SUPERVISION() As Boolean
        Get
            Return Me.trID_HALLAZGO_SUPERVISION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_HALLAZGO_SUPERVISION.Visible = value
        End Set
    End Property

    Public Property VerID_AREA_SUPERVISION() As Boolean
        Get
            Return Me.trID_AREA_SUPERVISION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_AREA_SUPERVISION.Visible = value
        End Set
    End Property

    Public Property VerID_SUPERVISION_AF() As Boolean
        Get
            Return Me.trID_SUPERVISION_AF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_SUPERVISION_AF.Visible = value
        End Set
    End Property

    Public Property VerHALLAZGO_SUPERVISION() As Boolean
        Get
            Return Me.trHALLAZGO_SUPERVISION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trHALLAZGO_SUPERVISION.Visible = value
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

    Public Property VerTIPO_SANCION() As Boolean
        Get
            Return Me.trTIPO_SANCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_SANCION.Visible = value
        End Set
    End Property

    Public Property VerTIEMPO_SANCION() As Boolean
        Get
            Return Me.trTIEMPO_SANCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIEMPO_SANCION.Visible = value
        End Set
    End Property

    Public Property VerMONTO_SANCION() As Boolean
        Get
            Return Me.trMONTO_SANCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMONTO_SANCION.Visible = value
        End Set
    End Property

    Public Property VerTIEMPO_SUBSANACION() As Boolean
        Get
            Return Me.trTIEMPO_SUBSANACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIEMPO_SUBSANACION.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cHALLAZGO_SUPERVISION
    Private mEntidad As HALLAZGO_SUPERVISION
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
        If Not Me.ViewState("ID_HALLAZGO_SUPERVISION") Is Nothing Then Me._ID_HALLAZGO_SUPERVISION = Me.ViewState("ID_HALLAZGO_SUPERVISION")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla HALLAZGO_SUPERVISION
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
        mEntidad = New HALLAZGO_SUPERVISION
        mEntidad.ID_HALLAZGO_SUPERVISION = ID_HALLAZGO_SUPERVISION
 
        If mComponente.ObtenerHALLAZGO_SUPERVISION(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_HALLAZGO_SUPERVISION.Text = mEntidad.ID_HALLAZGO_SUPERVISION.ToString()
        Me.ddlAREA_SUPERVISION1.Recuperar()
        Me.ddlAREA_SUPERVISION1.SelectedValue = mEntidad.ID_AREA_SUPERVISION
        Me.ddlSUPERVISION_AF1.Recuperar()
        Me.ddlSUPERVISION_AF1.SelectedValue = mEntidad.ID_SUPERVISION_AF
        Me.txtHALLAZGO_SUPERVISION.Text = mEntidad.HALLAZGO_SUPERVISION
        Me.txtFECHA.Text = IIf(Not mEntidad.FECHA = Nothing, Format(mEntidad.FECHA, "dd/MM/yyyy"), "")
        Me.txtTIPO_SANCION.Text = mEntidad.TIPO_SANCION
        Me.txtTIEMPO_SANCION.Text = mEntidad.TIEMPO_SANCION
        Me.txtMONTO_SANCION.Text = mEntidad.MONTO_SANCION
        Me.txtTIEMPO_SUBSANACION.Text = mEntidad.TIEMPO_SUBSANACION
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
        Me.ddlAREA_SUPERVISION1.Enabled = edicion
        Me.ddlSUPERVISION_AF1.Enabled = edicion
        Me.txtHALLAZGO_SUPERVISION.Enabled = edicion
        Me.txtFECHA.Enabled = edicion
        Me.txtTIPO_SANCION.Enabled = edicion
        Me.txtTIEMPO_SANCION.Enabled = edicion
        Me.txtMONTO_SANCION.Enabled = edicion
        Me.txtTIEMPO_SUBSANACION.Enabled = edicion
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
        Me.ddlAREA_SUPERVISION1.Recuperar()
        Me.ddlSUPERVISION_AF1.Recuperar()
        Me.txtHALLAZGO_SUPERVISION.Text = ""
        Me.txtFECHA.Text = ""
        Me.txtTIPO_SANCION.Text = ""
        Me.txtTIEMPO_SANCION.Text = ""
        Me.txtMONTO_SANCION.Text = ""
        Me.txtTIEMPO_SUBSANACION.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla HALLAZGO_SUPERVISION
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
        mEntidad = New HALLAZGO_SUPERVISION
        If Me._nuevo Then
            mEntidad.ID_HALLAZGO_SUPERVISION = 0
        Else
            mEntidad.ID_HALLAZGO_SUPERVISION = CInt(Me.txtID_HALLAZGO_SUPERVISION.Text)
        End If
        mEntidad.ID_AREA_SUPERVISION = Me.ddlAREA_SUPERVISION1.SelectedValue
        mEntidad.ID_SUPERVISION_AF = Me.ddlSUPERVISION_AF1.SelectedValue
        mEntidad.HALLAZGO_SUPERVISION = Me.txtHALLAZGO_SUPERVISION.Text
        If Me.txtFECHA.Text <> "" Then mEntidad.FECHA = System.DateTime.Parse(Me.txtFECHA.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.TIPO_SANCION = Me.txtTIPO_SANCION.Text
        mEntidad.TIEMPO_SANCION = Val(Me.txtTIEMPO_SANCION.Text)
        mEntidad.MONTO_SANCION = Val(Me.txtMONTO_SANCION.Text)
        mEntidad.TIEMPO_SUBSANACION = Val(Me.txtTIEMPO_SUBSANACION.Text)

        If mComponente.ActualizarHALLAZGO_SUPERVISION(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_HALLAZGO_SUPERVISION.Text = mEntidad.ID_HALLAZGO_SUPERVISION.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
