Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleESTADO_INFORME_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ESTADO_INFORME_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/07/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleESTADO_INFORME_AF
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_ESTADO_INFORME As Decimal
    Public Property ID_ESTADO_INFORME() As Decimal
        Get
            Return Me.txtID_ESTADO_INFORME.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_ESTADO_INFORME = Value
            Me.txtID_ESTADO_INFORME.Text = CStr(Value)
            If Me._ID_ESTADO_INFORME > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_FASE_ESTADO() As Decimal
        Get
            Return Me.cbxFASE_ESTADO_INFORMEID_FASE_ESTADO.Value
        End Get
        Set(ByVal value As Decimal)
            If Not Me.cbxFASE_ESTADO_INFORMEID_FASE_ESTADO.Items.FindByValue(value) Is Nothing Then
                Me.cbxFASE_ESTADO_INFORMEID_FASE_ESTADO.Value = CInt(value)
            End If
        End Set
    End Property

    Public Property NOMBRE_ESTADO_INFORME() As String
        Get
            Return Me.txtNOMBRE_ESTADO_INFORME.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_ESTADO_INFORME.Text = value.ToString()
        End Set
    End Property

    Public Property DESCRIPCION_ESTADO() As String
        Get
            Return Me.txtDESCRIPCION_ESTADO.Text
        End Get
        Set(ByVal value As String)
            Me.txtDESCRIPCION_ESTADO.Text = value.ToString()
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

    Public Property VerID_ESTADO_INFORME() As Boolean
        Get
            Return Me.trID_ESTADO_INFORME.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ESTADO_INFORME.Visible = value
        End Set
    End Property

    Public Property VerID_FASE_ESTADO() As Boolean
        Get
            Return Me.trID_FASE_ESTADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_FASE_ESTADO.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_ESTADO_INFORME() As Boolean
        Get
            Return Me.trNOMBRE_ESTADO_INFORME.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_ESTADO_INFORME.Visible = value
        End Set
    End Property

    Public Property VerDESCRIPCION_ESTADO() As Boolean
        Get
            Return Me.trDESCRIPCION_ESTADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDESCRIPCION_ESTADO.Visible = value
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
    Private mComponente As New cESTADO_INFORME_AF
    Private mEntidad As ESTADO_INFORME_AF
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
        If Not Me.ViewState("ID_ESTADO_INFORME") Is Nothing Then Me._ID_ESTADO_INFORME = Me.ViewState("ID_ESTADO_INFORME")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla ESTADO_INFORME_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New ESTADO_INFORME_AF
        mEntidad.ID_ESTADO_INFORME = ID_ESTADO_INFORME
 
        If mComponente.ObtenerESTADO_INFORME_AF(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ESTADO_INFORME.Text = mEntidad.ID_ESTADO_INFORME.ToString()
        Me.cbxFASE_ESTADO_INFORMEID_FASE_ESTADO.DataBind()
        Me.cbxFASE_ESTADO_INFORMEID_FASE_ESTADO.Value = CInt(mEntidad.ID_FASE_ESTADO)
        Me.txtNOMBRE_ESTADO_INFORME.Text = mEntidad.NOMBRE_ESTADO_INFORME
        Me.txtDESCRIPCION_ESTADO.Text = mEntidad.DESCRIPCION_ESTADO
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
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxFASE_ESTADO_INFORMEID_FASE_ESTADO.Enabled = edicion
        Me.txtNOMBRE_ESTADO_INFORME.Enabled = edicion
        Me.txtDESCRIPCION_ESTADO.Enabled = edicion
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
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.cbxFASE_ESTADO_INFORMEID_FASE_ESTADO.DataBind()
        Me.txtNOMBRE_ESTADO_INFORME.Text = ""
        Me.txtDESCRIPCION_ESTADO.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.deLASTUPDATE.Value = Now
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla ESTADO_INFORME_AF
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New ESTADO_INFORME_AF
        If Me._nuevo Then
            mEntidad.ID_ESTADO_INFORME = 0
        Else
            mEntidad.ID_ESTADO_INFORME = CInt(Me.txtID_ESTADO_INFORME.Text)
        End If
        mEntidad.ID_FASE_ESTADO = Me.cbxFASE_ESTADO_INFORMEID_FASE_ESTADO.Value
        mEntidad.NOMBRE_ESTADO_INFORME = Me.txtNOMBRE_ESTADO_INFORME.Text
        mEntidad.DESCRIPCION_ESTADO = Me.txtDESCRIPCION_ESTADO.Text
        mEntidad.USERID = Me.ObtenerUsuario()
        mEntidad.LASTUPDATE = Me.deLASTUPDATE.Value

        If mComponente.ActualizarESTADO_INFORME_AF(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_ESTADO_INFORME.Text = mEntidad.ID_ESTADO_INFORME.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
