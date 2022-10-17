Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleMUNICIPIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla MUNICIPIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleMUNICIPIO
    Inherits ucBase
 
#Region"Propiedades"

    Private _CODIGO_MUNICIPIO As String
    Public Property CODIGO_MUNICIPIO() As String
        Get
            Return Me.txtCODIGO_MUNICIPIO.Text
        End Get
        Set(ByVal Value As String)
            Me._CODIGO_MUNICIPIO = Value
            Me.txtCODIGO_MUNICIPIO.Text = Value
            If Me._CODIGO_MUNICIPIO <> "" Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Private _CODIGO_REGION As String
    Public Property CODIGO_REGION() As String
        Get
            Return _CODIGO_REGION
        End Get
        Set(ByVal Value As String)
            Me._CODIGO_REGION = Value
        End Set
    End Property

    Private _CODIGO_DEPARTAMENTO As String
    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return _CODIGO_DEPARTAMENTO
        End Get
        Set(ByVal Value As String)
            Me._CODIGO_DEPARTAMENTO = Value
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

    Public Property VerCODIGO_REGION() As Boolean
        Get
            Return Me.trCODIGO_REGION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_REGION.Visible = value
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

    Public Property VerNOMBRE() As Boolean
        Get
            Return Me.trNOMBRE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE.Visible = value
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
    Private mComponente As New cMUNICIPIO
    Private mEntidad As MUNICIPIO
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
        If Not Me.ViewState("CODIGO_MUNICIPIO") Is Nothing Then Me._CODIGO_MUNICIPIO = Me.ViewState("CODIGO_MUNICIPIO")
        If Not Me.ViewState("CODIGO_REGION") Is Nothing Then Me._CODIGO_REGION = Me.ViewState("CODIGO_REGION")
        If Not Me.ViewState("CODIGO_DEPARTAMENTO") Is Nothing Then Me._CODIGO_DEPARTAMENTO = Me.ViewState("CODIGO_DEPARTAMENTO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla MUNICIPIO
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
        mEntidad = New MUNICIPIO
        mEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
        'mEntidad.CODIGO_REGION = CODIGO_REGION
        mEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
 
        If mComponente.ObtenerMUNICIPIO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        'Me.ddlREGION1.Recuperar()
        'Me.ddlREGION1.SelectedValue = mEntidad.CODIGO_REGION
        Me.ddlDEPARTAMENTO1.Recuperar()
        Me.ddlDEPARTAMENTO1.SelectedValue = mEntidad.CODIGO_DEPARTAMENTO
        Me.txtCODIGO_MUNICIPIO.Text = mEntidad.CODIGO_MUNICIPIO
        Me.txtNOMBRE.Text = mEntidad.NOMBRE
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
        Me.txtNOMBRE.Enabled = edicion
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
        'Me.ddlREGION1.Recuperar()
        'Me.ddlREGION1.SelectedValue = Me.CODIGO_REGION
        Me.ddlDEPARTAMENTO1.Recuperar()
        Me.ddlDEPARTAMENTO1.SelectedValue = Me.CODIGO_DEPARTAMENTO
        Me.txtNOMBRE.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.txtLASTUPDATE.Text = Now.ToString("dd/MM/yyyy")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla MUNICIPIO
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
        mEntidad = New MUNICIPIO
        If Me.txtCODIGO_MUNICIPIO.Text = "0" Then
            Me.AsignarMensaje("Asigne un valor al Codigo municipio que sea valido", True, True)
            Return "Error"
        End If
        'mEntidad.CODIGO_REGION = Me.ddlREGION1.SelectedValue
        mEntidad.CODIGO_DEPARTAMENTO = Me.ddlDEPARTAMENTO1.SelectedValue
            mEntidad.CODIGO_MUNICIPIO = Me.txtCODIGO_MUNICIPIO.Text
        mEntidad.NOMBRE = Me.txtNOMBRE.Text
        mEntidad.USERID = Me.ObtenerUsuario()
        If Me.txtLASTUPDATE.Text <> "" Then mEntidad.LASTUPDATE = System.DateTime.Parse(Me.txtLASTUPDATE.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If Me._nuevo Then
            If mComponente.AgregarMUNICIPIO(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
         Else
            If mComponente.ActualizarMUNICIPIO(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If
        Me.txtCODIGO_MUNICIPIO.Text = mEntidad.CODIGO_MUNICIPIO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
