Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleETAPA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ETAPA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleETAPA
    Inherits ucBase
 
#Region"Propiedades"

    Private _CODIGO_ETAPA As String
    Public Property CODIGO_ETAPA() As String
        Get
            Return Me.txtCODIGO_ETAPA.Text
        End Get
        Set(ByVal Value As String)
            Me._CODIGO_ETAPA = Value
            Me.txtCODIGO_ETAPA.Text = Value
            If Me._CODIGO_ETAPA <> "" Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Private _CODIGO_PROCESO As String
    Public Property CODIGO_PROCESO() As String
        Get
            Return _CODIGO_PROCESO
        End Get
        Set(ByVal Value As String)
            Me._CODIGO_PROCESO = Value
        End Set
    End Property

    Public Property VerCODIGO_ETAPA() As Boolean
        Get
            Return Me.trCODIGO_ETAPA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_ETAPA.Visible = value
        End Set
    End Property

    Public Property VerCODIGO_PROCESO() As Boolean
        Get
            Return Me.trCODIGO_PROCESO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_PROCESO.Visible = value
        End Set
    End Property

    Public Property VerID_ESTADO_SOLICITUD() As Boolean
        Get
            Return Me.trID_ESTADO_SOLICITUD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ESTADO_SOLICITUD.Visible = value
        End Set
    End Property

    Public Property VerUNIDAD_DE_TIEMPO() As Boolean
        Get
            Return Me.trUNIDAD_DE_TIEMPO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUNIDAD_DE_TIEMPO.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_ETAPA() As Boolean
        Get
            Return Me.trNOMBRE_ETAPA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_ETAPA.Visible = value
        End Set
    End Property

    Public Property VerETAPA_ANT() As Boolean
        Get
            Return Me.trETAPA_ANT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trETAPA_ANT.Visible = value
        End Set
    End Property

    Public Property VerETAPA_SIG() As Boolean
        Get
            Return Me.trETAPA_SIG.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trETAPA_SIG.Visible = value
        End Set
    End Property

    Public Property VerTIPO_ETAPA() As Boolean
        Get
            Return Me.trTIPO_ETAPA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_ETAPA.Visible = value
        End Set
    End Property

    Public Property VerDURACION() As Boolean
        Get
            Return Me.trDURACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDURACION.Visible = value
        End Set
    End Property

    Public Property VerORDEN_EJECUCION() As Boolean
        Get
            Return Me.trORDEN_EJECUCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trORDEN_EJECUCION.Visible = value
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
    Private mComponente As New cETAPA
    Private mEntidad As ETAPA
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
        If Not Me.ViewState("CODIGO_ETAPA") Is Nothing Then Me._CODIGO_ETAPA = Me.ViewState("CODIGO_ETAPA")
        If Not Me.ViewState("CODIGO_PROCESO") Is Nothing Then Me._CODIGO_PROCESO = Me.ViewState("CODIGO_PROCESO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla ETAPA
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
        mEntidad = New ETAPA
        mEntidad.CODIGO_ETAPA = CODIGO_ETAPA
        mEntidad.CODIGO_PROCESO = CODIGO_PROCESO
 
        If mComponente.ObtenerETAPA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.ddlPROCESO1.Recuperar()
        Me.ddlPROCESO1.SelectedValue = mEntidad.CODIGO_PROCESO
        Me.txtCODIGO_ETAPA.Text = mEntidad.CODIGO_ETAPA
        Me.ddlESTADO_SOLICITUD1.Recuperar()
        Me.ddlESTADO_SOLICITUD1.SelectedValue = mEntidad.ID_ESTADO_SOLICITUD
        Me.txtUNIDAD_DE_TIEMPO.Text = mEntidad.UNIDAD_DE_TIEMPO
        Me.txtNOMBRE_ETAPA.Text = mEntidad.NOMBRE_ETAPA
        Me.txtETAPA_ANT.Text = mEntidad.ETAPA_ANT
        Me.txtETAPA_SIG.Text = mEntidad.ETAPA_SIG
        Me.txtTIPO_ETAPA.Text = mEntidad.TIPO_ETAPA
        Me.txtDURACION.Text = mEntidad.DURACION
        Me.txtORDEN_EJECUCION.Text = mEntidad.ORDEN_EJECUCION
        Me.txtUSERID.Text = mEntidad.USERID
        Me.txtLASTUPDATE.Text = IIf(Not mEntidad.LASTUPDATE = Nothing, Format(mEntidad.LASTUPDATE, "dd/MM/yyyy"), "")
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
        Me.ddlESTADO_SOLICITUD1.Enabled = edicion
        Me.txtUNIDAD_DE_TIEMPO.Enabled = edicion
        Me.txtNOMBRE_ETAPA.Enabled = edicion
        Me.txtETAPA_ANT.Enabled = edicion
        Me.txtETAPA_SIG.Enabled = edicion
        Me.txtTIPO_ETAPA.Enabled = edicion
        Me.txtDURACION.Enabled = edicion
        Me.txtORDEN_EJECUCION.Enabled = edicion
        Me.txtUSERID.Enabled = False
        Me.txtLASTUPDATE.Enabled = False
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
        Me.ddlPROCESO1.Recuperar()
        Me.ddlPROCESO1.SelectedValue = Me.CODIGO_PROCESO
        Me.ddlESTADO_SOLICITUD1.Recuperar()
        Me.txtUNIDAD_DE_TIEMPO.Text = ""
        Me.txtNOMBRE_ETAPA.Text = ""
        Me.txtETAPA_ANT.Text = ""
        Me.txtETAPA_SIG.Text = ""
        Me.txtTIPO_ETAPA.Text = ""
        Me.txtDURACION.Text = ""
        Me.txtORDEN_EJECUCION.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.txtLASTUPDATE.Text = Now.ToString("dd/MM/yyyy")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla ETAPA
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
        mEntidad = New ETAPA
        If Me.txtCODIGO_ETAPA.Text = "0" Then
            Me.AsignarMensaje("Asigne un valor al Codigo etapa que sea valido", True, True)
            Return "Error"
        End If
        mEntidad.CODIGO_PROCESO = Me.ddlPROCESO1.SelectedValue
            mEntidad.CODIGO_ETAPA = Me.txtCODIGO_ETAPA.Text
        mEntidad.ID_ESTADO_SOLICITUD = Me.ddlESTADO_SOLICITUD1.SelectedValue
        mEntidad.UNIDAD_DE_TIEMPO = Me.txtUNIDAD_DE_TIEMPO.Text
        mEntidad.NOMBRE_ETAPA = Me.txtNOMBRE_ETAPA.Text
        mEntidad.ETAPA_ANT = Me.txtETAPA_ANT.Text
        mEntidad.ETAPA_SIG = Me.txtETAPA_SIG.Text
        mEntidad.TIPO_ETAPA = Me.txtTIPO_ETAPA.Text
        mEntidad.DURACION = Val(Me.txtDURACION.Text)
        mEntidad.ORDEN_EJECUCION = Val(Me.txtORDEN_EJECUCION.Text)
        mEntidad.USERID = Me.ObtenerUsuario()
        If Me.txtLASTUPDATE.Text <> "" Then mEntidad.LASTUPDATE = System.DateTime.Parse(Me.txtLASTUPDATE.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If Me._nuevo Then
            If mComponente.AgregarETAPA(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
         Else
            If mComponente.ActualizarETAPA(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If
        Me.txtCODIGO_ETAPA.Text = mEntidad.CODIGO_ETAPA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
