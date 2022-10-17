Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleDESEMBOLSO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla DESEMBOLSO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/04/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleDESEMBOLSO
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_DESEMBOLSO As Decimal
    Public Property ID_DESEMBOLSO() As Decimal
        Get
            Return Me.txtID_DESEMBOLSO.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_DESEMBOLSO = Value
            Me.txtID_DESEMBOLSO.Text = CStr(Value)
            If Me._ID_DESEMBOLSO > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_FUENTE() As Decimal
        Get
            Return Me.ddlFUENTE_FINANCIAMIENTOID_FUENTE.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlFUENTE_FINANCIAMIENTOID_FUENTE.Items.FindByValue(value) Is Nothing Then
                Me.ddlFUENTE_FINANCIAMIENTOID_FUENTE.SelectedValue = value
            End If
        End Set
    End Property

    Public Property NO_CONVOCATORIA() As Decimal
        Get
            If Me.txtNO_CONVOCATORIA.Value Is Nothing Then Return -1
            Return Me.txtNO_CONVOCATORIA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtNO_CONVOCATORIA.Value = value
        End Set
    End Property

    Public Property NUM_DESEMBOLSO() As Decimal
        Get
            If Me.txtNUM_DESEMBOLSO.Value Is Nothing Then Return -1
            Return Me.txtNUM_DESEMBOLSO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtNUM_DESEMBOLSO.Value = value
        End Set
    End Property

    Public Property FECHA_DESEMBOLSO() As DateTime
        Get
            Return Me.deFECHA_DESEMBOLSO.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_DESEMBOLSO.Value = value
        End Set
    End Property

    Public Property MONTO_AUTORIZADO() As Decimal
        Get
            If Me.txtMONTO_AUTORIZADO.Value Is Nothing Then Return -1
            Return Me.txtMONTO_AUTORIZADO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtMONTO_AUTORIZADO.Value = value
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

    Public Property VerID_DESEMBOLSO() As Boolean
        Get
            Return Me.trID_DESEMBOLSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_DESEMBOLSO.Visible = value
        End Set
    End Property

    Public Property VerID_FUENTE() As Boolean
        Get
            Return Me.trID_FUENTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_FUENTE.Visible = value
        End Set
    End Property

    Public Property VerNO_CONVOCATORIA() As Boolean
        Get
            Return Me.trNO_CONVOCATORIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNO_CONVOCATORIA.Visible = value
        End Set
    End Property

    Public Property VerNUM_DESEMBOLSO() As Boolean
        Get
            Return Me.trNUM_DESEMBOLSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNUM_DESEMBOLSO.Visible = value
        End Set
    End Property

    Public Property VerFECHA_DESEMBOLSO() As Boolean
        Get
            Return Me.trFECHA_DESEMBOLSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_DESEMBOLSO.Visible = value
        End Set
    End Property

    Public Property VerMONTO_AUTORIZADO() As Boolean
        Get
            Return Me.trMONTO_AUTORIZADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMONTO_AUTORIZADO.Visible = value
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
    Private mComponente As New cDESEMBOLSO
    Private mEntidad As DESEMBOLSO
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
        If Not Me.ViewState("ID_DESEMBOLSO") Is Nothing Then Me._ID_DESEMBOLSO = Me.ViewState("ID_DESEMBOLSO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla DESEMBOLSO
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
        mEntidad = New DESEMBOLSO
        mEntidad.ID_DESEMBOLSO = ID_DESEMBOLSO
 
        If mComponente.ObtenerDESEMBOLSO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_DESEMBOLSO.Text = mEntidad.ID_DESEMBOLSO.ToString()
        Me.ddlFUENTE_FINANCIAMIENTOID_FUENTE.Recuperar()
        Me.ddlFUENTE_FINANCIAMIENTOID_FUENTE.SelectedValue = mEntidad.ID_FUENTE
        Me.txtNO_CONVOCATORIA.Value = mEntidad.NO_CONVOCATORIA
        Me.txtNUM_DESEMBOLSO.Value = mEntidad.NUM_DESEMBOLSO
        Me.deFECHA_DESEMBOLSO.Value = mEntidad.FECHA_DESEMBOLSO
        Me.txtMONTO_AUTORIZADO.Value = mEntidad.MONTO_AUTORIZADO
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
        Me.ddlFUENTE_FINANCIAMIENTOID_FUENTE.Enabled = edicion
        Me.txtNO_CONVOCATORIA.Enabled = edicion
        Me.txtNUM_DESEMBOLSO.Enabled = edicion
        Me.deFECHA_DESEMBOLSO.Enabled = edicion
        Me.txtMONTO_AUTORIZADO.Enabled = edicion
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
        Me.ddlFUENTE_FINANCIAMIENTOID_FUENTE.Recuperar()
        Me.txtNO_CONVOCATORIA.Value = Nothing
        Me.txtNUM_DESEMBOLSO.Value = Nothing
        Me.deFECHA_DESEMBOLSO.Value = Nothing
        Me.txtMONTO_AUTORIZADO.Value = Nothing
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.deLASTUPDATE.Value = Now
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla DESEMBOLSO
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
        mEntidad = New DESEMBOLSO
        If Me._nuevo Then
            mEntidad.ID_DESEMBOLSO = 0
        Else
            mEntidad.ID_DESEMBOLSO = CInt(Me.txtID_DESEMBOLSO.Text)
        End If
        mEntidad.ID_FUENTE = Me.ddlFUENTE_FINANCIAMIENTOID_FUENTE.SelectedValue
        mEntidad.NO_CONVOCATORIA = Me.txtNO_CONVOCATORIA.Value
        mEntidad.NUM_DESEMBOLSO = Me.txtNUM_DESEMBOLSO.Value
        mEntidad.FECHA_DESEMBOLSO = Me.deFECHA_DESEMBOLSO.Value
        mEntidad.MONTO_AUTORIZADO = Me.txtMONTO_AUTORIZADO.Value
        mEntidad.USERID = Me.ObtenerUsuario()
        mEntidad.LASTUPDATE = Me.deLASTUPDATE.Value

        If mComponente.ActualizarDESEMBOLSO(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_DESEMBOLSO.Text = mEntidad.ID_DESEMBOLSO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
