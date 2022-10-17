Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetallePROGRAMA_FORMACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PROGRAMA_FORMACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePROGRAMA_FORMACION
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_PROGRAMA_FORMACION As Decimal
    Public Property ID_PROGRAMA_FORMACION() As Decimal
        Get
            Return Me.txtID_PROGRAMA_FORMACION.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_PROGRAMA_FORMACION = Value
            Me.txtID_PROGRAMA_FORMACION.Text = CStr(Value)
            If Me._ID_PROGRAMA_FORMACION > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NOMBRE_PROGRAMA_FORMACION() As String
        Get
            Return Me.txtNOMBRE_PROGRAMA_FORMACION.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_PROGRAMA_FORMACION.Text = value.ToString()
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

    Public Property PORC_ASISTENCIA_MINIMA() As Decimal
        Get
            If Me.txtPORC_ASISTENCIA_MINIMA.Value Is Nothing Then Return -1
            Return Me.txtPORC_ASISTENCIA_MINIMA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtPORC_ASISTENCIA_MINIMA.Value = value
        End Set
    End Property

    Public Property NOTA_MINIMA() As Decimal
        Get
            If Me.txtNOTA_MINIMA.Value Is Nothing Then Return -1
            Return Me.txtNOTA_MINIMA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtNOTA_MINIMA.Value = value
        End Set
    End Property

    Public Property ID_TIPO_PAGO() As Decimal
        Get
            Return Me.cbxPROGRAMA_FORMACION_TIPOPAGOID_TIPO_PAGO.Value
        End Get
        Set(ByVal value As Decimal)
            If Not Me.cbxPROGRAMA_FORMACION_TIPOPAGOID_TIPO_PAGO.Items.FindByValue(value) Is Nothing Then
                Me.cbxPROGRAMA_FORMACION_TIPOPAGOID_TIPO_PAGO.Value = CInt(value)
            End If
        End Set
    End Property

    Public Property VerID_PROGRAMA_FORMACION() As Boolean
        Get
            Return Me.trID_PROGRAMA_FORMACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PROGRAMA_FORMACION.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_PROGRAMA_FORMACION() As Boolean
        Get
            Return Me.trNOMBRE_PROGRAMA_FORMACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_PROGRAMA_FORMACION.Visible = value
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

    Public Property VerPORC_ASISTENCIA_MINIMA() As Boolean
        Get
            Return Me.trPORC_ASISTENCIA_MINIMA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPORC_ASISTENCIA_MINIMA.Visible = value
        End Set
    End Property

    Public Property VerNOTA_MINIMA() As Boolean
        Get
            Return Me.trNOTA_MINIMA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOTA_MINIMA.Visible = value
        End Set
    End Property

    Public Property VerID_TIPO_PAGO() As Boolean
        Get
            Return Me.trID_TIPO_PAGO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIPO_PAGO.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cPROGRAMA_FORMACION
    Private mEntidad As PROGRAMA_FORMACION
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
        If Not Me.ViewState("ID_PROGRAMA_FORMACION") Is Nothing Then Me._ID_PROGRAMA_FORMACION = Me.ViewState("ID_PROGRAMA_FORMACION")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla PROGRAMA_FORMACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PROGRAMA_FORMACION
        mEntidad.ID_PROGRAMA_FORMACION = ID_PROGRAMA_FORMACION
 
        If mComponente.ObtenerPROGRAMA_FORMACION(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_PROGRAMA_FORMACION.Text = mEntidad.ID_PROGRAMA_FORMACION.ToString()
        Me.txtNOMBRE_PROGRAMA_FORMACION.Text = mEntidad.NOMBRE_PROGRAMA_FORMACION
        Me.txtUSERID.Text = mEntidad.USERID
        Me.deLASTUPDATE.Value = mEntidad.LASTUPDATE
        Me.txtPORC_ASISTENCIA_MINIMA.Value = mEntidad.PORC_ASISTENCIA_MINIMA
        Me.txtNOTA_MINIMA.Value = mEntidad.NOTA_MINIMA
        Me.cbxPROGRAMA_FORMACION_TIPOPAGOID_TIPO_PAGO.DataBind()
        Me.cbxPROGRAMA_FORMACION_TIPOPAGOID_TIPO_PAGO.Value = CInt(mEntidad.ID_TIPO_PAGO)
        Me.speMONTO_APOYO_PARTI.Value = mEntidad.MONTO_APOYO_PARTI
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxPROGRAMA_FORMACION_TIPOPAGOID_TIPO_PAGO.Enabled = edicion
        Me.txtNOMBRE_PROGRAMA_FORMACION.Enabled = edicion AndAlso Me._nuevo
        Me.txtUSERID.Enabled = False
        Me.deLASTUPDATE.Enabled = False
        Me.txtPORC_ASISTENCIA_MINIMA.Enabled = edicion
        Me.txtNOTA_MINIMA.Enabled = edicion
        Me.speMONTO_APOYO_PARTI.ClientEnabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.cbxPROGRAMA_FORMACION_TIPOPAGOID_TIPO_PAGO.DataBind()
        Me.txtNOMBRE_PROGRAMA_FORMACION.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.deLASTUPDATE.Value = Now
        Me.txtPORC_ASISTENCIA_MINIMA.Value = Nothing
        Me.txtNOTA_MINIMA.Value = Nothing
        Me.speMONTO_APOYO_PARTI.Value = 0
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla PROGRAMA_FORMACION
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New PROGRAMA_FORMACION
        If Me._nuevo Then
            mEntidad.ID_PROGRAMA_FORMACION = 0
        Else
            mEntidad.ID_PROGRAMA_FORMACION = CInt(Me.txtID_PROGRAMA_FORMACION.Text)
        End If
        mEntidad.NOMBRE_PROGRAMA_FORMACION = Me.txtNOMBRE_PROGRAMA_FORMACION.Text
        mEntidad.USERID = Me.ObtenerUsuario()
        mEntidad.LASTUPDATE = Me.deLASTUPDATE.Value
        mEntidad.PORC_ASISTENCIA_MINIMA = Me.txtPORC_ASISTENCIA_MINIMA.Value
        mEntidad.NOTA_MINIMA = Me.txtNOTA_MINIMA.Value
        mEntidad.ID_TIPO_PAGO = Me.cbxPROGRAMA_FORMACION_TIPOPAGOID_TIPO_PAGO.Value
        mEntidad.MONTO_APOYO_PARTI = Decimal.Parse(Me.speMONTO_APOYO_PARTI.Value)

        If mComponente.ActualizarPROGRAMA_FORMACION(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_PROGRAMA_FORMACION.Text = mEntidad.ID_PROGRAMA_FORMACION.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
