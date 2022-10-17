Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla DESEMBOLSO_MUNI_LIQUI_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/04/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleDESEMBOLSO_MUNI_LIQUI_DET
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_DESEMBOLSO_MUNI As Decimal
    Public Property ID_DESEMBOLSO_MUNI() As Decimal
        Get
            Return Me.txtID_DESEMBOLSO_MUNI.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_DESEMBOLSO_MUNI = Value
            Me.txtID_DESEMBOLSO_MUNI.Text = CStr(Value)
            If Me._ID_DESEMBOLSO_MUNI > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_DESEMBOLSO() As Decimal
        Get
            Return Me.ddlDESEMBOLSOID_DESEMBOLSO.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlDESEMBOLSOID_DESEMBOLSO.Items.FindByValue(value) Is Nothing Then
                Me.ddlDESEMBOLSOID_DESEMBOLSO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_LIQUIDACION_DET() As Decimal
        Get
            Return Me.ddlMUNICIPIO_LIQUIDACION_DETID_LIQUIDACION_DET.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlMUNICIPIO_LIQUIDACION_DETID_LIQUIDACION_DET.Items.FindByValue(value) Is Nothing Then
                Me.ddlMUNICIPIO_LIQUIDACION_DETID_LIQUIDACION_DET.SelectedValue = value
            End If
        End Set
    End Property

    Public Property MONTO_DESEMBOLSO() As Decimal
        Get
            If Me.txtMONTO_DESEMBOLSO.Value Is Nothing Then Return -1
            Return Me.txtMONTO_DESEMBOLSO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMONTO_DESEMBOLSO.Value = value
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

    Public Property VerID_DESEMBOLSO_MUNI() As Boolean
        Get
            Return Me.trID_DESEMBOLSO_MUNI.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_DESEMBOLSO_MUNI.Visible = value
        End Set
    End Property

    Public Property VerID_DESEMBOLSO() As Boolean
        Get
            Return Me.trID_DESEMBOLSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_DESEMBOLSO.Visible = value
        End Set
    End Property

    Public Property VerID_LIQUIDACION_DET() As Boolean
        Get
            Return Me.trID_LIQUIDACION_DET.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_LIQUIDACION_DET.Visible = value
        End Set
    End Property

    Public Property VerMONTO_DESEMBOLSO() As Boolean
        Get
            Return Me.trMONTO_DESEMBOLSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMONTO_DESEMBOLSO.Visible = value
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
    Private mComponente As New cDESEMBOLSO_MUNI_LIQUI_DET
    Private mEntidad As DESEMBOLSO_MUNI_LIQUI_DET
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
        If Not Me.ViewState("ID_DESEMBOLSO_MUNI") Is Nothing Then Me._ID_DESEMBOLSO_MUNI = Me.ViewState("ID_DESEMBOLSO_MUNI")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla DESEMBOLSO_MUNI_LIQUI_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New DESEMBOLSO_MUNI_LIQUI_DET
        mEntidad.ID_DESEMBOLSO_MUNI = ID_DESEMBOLSO_MUNI
 
        If mComponente.ObtenerDESEMBOLSO_MUNI_LIQUI_DET(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_DESEMBOLSO_MUNI.Text = mEntidad.ID_DESEMBOLSO_MUNI.ToString()
        Me.ddlDESEMBOLSOID_DESEMBOLSO.Recuperar()
        Me.ddlDESEMBOLSOID_DESEMBOLSO.SelectedValue = mEntidad.ID_DESEMBOLSO
        Me.ddlMUNICIPIO_LIQUIDACION_DETID_LIQUIDACION_DET.Recuperar()
        Me.ddlMUNICIPIO_LIQUIDACION_DETID_LIQUIDACION_DET.SelectedValue = mEntidad.ID_LIQUIDACION_DET
        Me.txtMONTO_DESEMBOLSO.Value = mEntidad.MONTO_DESEMBOLSO
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
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlDESEMBOLSOID_DESEMBOLSO.Enabled = edicion
        Me.ddlMUNICIPIO_LIQUIDACION_DETID_LIQUIDACION_DET.Enabled = edicion
        Me.txtMONTO_DESEMBOLSO.Enabled = edicion
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
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlDESEMBOLSOID_DESEMBOLSO.Recuperar()
        Me.ddlMUNICIPIO_LIQUIDACION_DETID_LIQUIDACION_DET.Recuperar()
        Me.txtMONTO_DESEMBOLSO.Value = Nothing
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.deLASTUPDATE.Value = Now
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla DESEMBOLSO_MUNI_LIQUI_DET
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New DESEMBOLSO_MUNI_LIQUI_DET
        If Me._nuevo Then
            mEntidad.ID_DESEMBOLSO_MUNI = 0
        Else
            mEntidad.ID_DESEMBOLSO_MUNI = CInt(Me.txtID_DESEMBOLSO_MUNI.Text)
        End If
        mEntidad.ID_DESEMBOLSO = Me.ddlDESEMBOLSOID_DESEMBOLSO.SelectedValue
        mEntidad.ID_LIQUIDACION_DET = Me.ddlMUNICIPIO_LIQUIDACION_DETID_LIQUIDACION_DET.SelectedValue
        mEntidad.MONTO_DESEMBOLSO = Me.txtMONTO_DESEMBOLSO.Value
        mEntidad.USERID = Me.ObtenerUsuario()
        mEntidad.LASTUPDATE = Me.deLASTUPDATE.Value

        If mComponente.ActualizarDESEMBOLSO_MUNI_LIQUI_DET(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_DESEMBOLSO_MUNI.Text = mEntidad.ID_DESEMBOLSO_MUNI.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
