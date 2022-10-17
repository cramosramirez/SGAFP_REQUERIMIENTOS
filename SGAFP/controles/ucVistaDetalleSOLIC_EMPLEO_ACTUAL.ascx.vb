Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleSOLIC_EMPLEO_ACTUAL
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SOLIC_EMPLEO_ACTUAL
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSOLIC_EMPLEO_ACTUAL
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_EMPLEO_ACTUAL As Decimal
    Public Property ID_EMPLEO_ACTUAL() As Decimal
        Get
            Return Me.txtID_EMPLEO_ACTUAL.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_EMPLEO_ACTUAL = Value
            Me.txtID_EMPLEO_ACTUAL.Text = CStr(Value)
            If Me._ID_EMPLEO_ACTUAL > 0 Then
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

    Public Property NOMBRE_EMPRESA() As String
        Get
            Return Me.txtNOMBRE_EMPRESA.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_EMPRESA.Text = value.ToString()
        End Set
    End Property

    Public Property DIRECCION() As String
        Get
            Return Me.txtDIRECCION.Text
        End Get
        Set(ByVal value As String)
            Me.txtDIRECCION.Text = value.ToString()
        End Set
    End Property

    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Items.FindByValue(value) Is Nothing Then
                Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property CODIGO_MUNICIPIO() As String
        Get
            Return Me.ddlMUNICIPIOCODIGO_MUNICIPIO.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Items.FindByValue(value) Is Nothing Then
                Me.ddlMUNICIPIOCODIGO_MUNICIPIO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property TELEFONOS() As String
        Get
            Return Me.txtTELEFONOS.Text
        End Get
        Set(ByVal value As String)
            Me.txtTELEFONOS.Text = value.ToString()
        End Set
    End Property

    Public Property TIEMPO_TRABAJO() As Decimal
        Get
            If Me.txtTIEMPO_TRABAJO.Value Is Nothing Then Return -1
            Return Me.txtTIEMPO_TRABAJO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTIEMPO_TRABAJO.Value = value
        End Set
    End Property

    Public Property AREA_TRABAJO() As Decimal
        Get
            If Me.txtAREA_TRABAJO.Value Is Nothing Then Return -1
            Return Me.txtAREA_TRABAJO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtAREA_TRABAJO.Value = value
        End Set
    End Property

    Public Property AREA_OTRO() As String
        Get
            Return Me.txtAREA_OTRO.Text
        End Get
        Set(ByVal value As String)
            Me.txtAREA_OTRO.Text = value.ToString()
        End Set
    End Property

    Public Property VerID_EMPLEO_ACTUAL() As Boolean
        Get
            Return Me.trID_EMPLEO_ACTUAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_EMPLEO_ACTUAL.Visible = value
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

    Public Property VerNOMBRE_EMPRESA() As Boolean
        Get
            Return Me.trNOMBRE_EMPRESA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_EMPRESA.Visible = value
        End Set
    End Property

    Public Property VerDIRECCION() As Boolean
        Get
            Return Me.trDIRECCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDIRECCION.Visible = value
        End Set
    End Property

    Public Property VerCODIGO_DEPARTAMENTO() As Boolean
        Get
            Return Me.trCODIGO_DEPARTAMENTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_DEPARTAMENTO.Visible = value
        End Set
    End Property

    Public Property VerCODIGO_MUNICIPIO() As Boolean
        Get
            Return Me.trCODIGO_MUNICIPIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_MUNICIPIO.Visible = value
        End Set
    End Property

    Public Property VerTELEFONOS() As Boolean
        Get
            Return Me.trTELEFONOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTELEFONOS.Visible = value
        End Set
    End Property

    Public Property VerTIEMPO_TRABAJO() As Boolean
        Get
            Return Me.trTIEMPO_TRABAJO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIEMPO_TRABAJO.Visible = value
        End Set
    End Property

    Public Property VerAREA_TRABAJO() As Boolean
        Get
            Return Me.trAREA_TRABAJO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAREA_TRABAJO.Visible = value
        End Set
    End Property

    Public Property VerAREA_OTRO() As Boolean
        Get
            Return Me.trAREA_OTRO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAREA_OTRO.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cSOLIC_EMPLEO_ACTUAL
    Private mEntidad As SOLIC_EMPLEO_ACTUAL
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
        If Not Me.ViewState("ID_EMPLEO_ACTUAL") Is Nothing Then Me._ID_EMPLEO_ACTUAL = Me.ViewState("ID_EMPLEO_ACTUAL")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla SOLIC_EMPLEO_ACTUAL
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
        mEntidad = New SOLIC_EMPLEO_ACTUAL
        mEntidad.ID_EMPLEO_ACTUAL = ID_EMPLEO_ACTUAL
 
        If mComponente.ObtenerSOLIC_EMPLEO_ACTUAL(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_EMPLEO_ACTUAL.Text = mEntidad.ID_EMPLEO_ACTUAL.ToString()
        Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.Recuperar()
        Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.SelectedValue = mEntidad.ID_SOLICITUD
        Me.txtNOMBRE_EMPRESA.Text = mEntidad.NOMBRE_EMPRESA
        Me.txtDIRECCION.Text = mEntidad.DIRECCION
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Recuperar()
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue = mEntidad.CODIGO_DEPARTAMENTO
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Recuperar(Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue)
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.SelectedValue = mEntidad.CODIGO_MUNICIPIO
        Me.txtTELEFONOS.Text = mEntidad.TELEFONOS
        Me.txtTIEMPO_TRABAJO.Value = mEntidad.TIEMPO_TRABAJO
        Me.txtAREA_TRABAJO.Value = mEntidad.AREA_TRABAJO
        Me.txtAREA_OTRO.Text = mEntidad.AREA_OTRO
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
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Enabled = edicion
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Enabled = edicion
        Me.txtNOMBRE_EMPRESA.Enabled = edicion
        Me.txtDIRECCION.Enabled = edicion
        Me.txtTELEFONOS.Enabled = edicion
        Me.txtTIEMPO_TRABAJO.Enabled = edicion
        Me.txtAREA_TRABAJO.Enabled = edicion
        Me.txtAREA_OTRO.Enabled = edicion
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
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Recuperar()
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Recuperar(Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue)
        Me.txtNOMBRE_EMPRESA.Text = ""
        Me.txtDIRECCION.Text = ""
        Me.txtTELEFONOS.Text = ""
        Me.txtTIEMPO_TRABAJO.Value = Nothing
        Me.txtAREA_TRABAJO.Value = Nothing
        Me.txtAREA_OTRO.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla SOLIC_EMPLEO_ACTUAL
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
        mEntidad = New SOLIC_EMPLEO_ACTUAL
        If Me._nuevo Then
            mEntidad.ID_EMPLEO_ACTUAL = 0
        Else
            mEntidad.ID_EMPLEO_ACTUAL = CInt(Me.txtID_EMPLEO_ACTUAL.Text)
        End If
        mEntidad.ID_SOLICITUD = Me.ddlSOLICITUD_INSCRIPCION_AFID_SOLICITUD.SelectedValue
        mEntidad.NOMBRE_EMPRESA = Me.txtNOMBRE_EMPRESA.Text
        mEntidad.DIRECCION = Me.txtDIRECCION.Text
        mEntidad.CODIGO_DEPARTAMENTO = Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue
        mEntidad.CODIGO_MUNICIPIO = Me.ddlMUNICIPIOCODIGO_MUNICIPIO.SelectedValue
        mEntidad.TELEFONOS = Me.txtTELEFONOS.Text
        mEntidad.TIEMPO_TRABAJO = Me.txtTIEMPO_TRABAJO.Value
        mEntidad.AREA_TRABAJO = Me.txtAREA_TRABAJO.Value
        mEntidad.AREA_OTRO = Me.txtAREA_OTRO.Text

        If mComponente.ActualizarSOLIC_EMPLEO_ACTUAL(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_EMPLEO_ACTUAL.Text = mEntidad.ID_EMPLEO_ACTUAL.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
