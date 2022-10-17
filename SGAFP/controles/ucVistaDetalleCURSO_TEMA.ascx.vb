Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleCURSO_TEMA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CURSO_TEMA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCURSO_TEMA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_TEMA_CURSO As Decimal
    Public Property ID_TEMA_CURSO() As Decimal
        Get
            Return Me.txtID_TEMA_CURSO.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_TEMA_CURSO = Value
            Me.txtID_TEMA_CURSO.Text = CStr(Value)
            If Me._ID_TEMA_CURSO > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_TEMA_CURSO() As Boolean
        Get
            Return Me.trID_TEMA_CURSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TEMA_CURSO.Visible = value
        End Set
    End Property

    Public Property VerID_AREA_FORMACION() As Boolean
        Get
            Return Me.trID_AREA_FORMACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_AREA_FORMACION.Visible = value
        End Set
    End Property

    Public Property VerTEMA_CURSO() As Boolean
        Get
            Return Me.trTEMA_CURSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTEMA_CURSO.Visible = value
        End Set
    End Property

    Public Property VerDURACION_HORAS() As Boolean
        Get
            Return Me.trDURACION_HORAS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDURACION_HORAS.Visible = value
        End Set
    End Property

    Public Property VerFECHA_ACREDITACION() As Boolean
        Get
            Return Me.trFECHA_ACREDITACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_ACREDITACION.Visible = value
        End Set
    End Property

    Public Property VerNOTAS() As Boolean
        Get
            Return Me.trNOTAS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOTAS.Visible = value
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
    Private mComponente As New cCURSO_TEMA
    Private mEntidad As CURSO_TEMA
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
        If Not Me.ViewState("ID_TEMA_CURSO") Is Nothing Then Me._ID_TEMA_CURSO = Me.ViewState("ID_TEMA_CURSO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla CURSO_TEMA
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
        mEntidad = New CURSO_TEMA
        mEntidad.ID_TEMA_CURSO = ID_TEMA_CURSO
 
        If mComponente.ObtenerCURSO_TEMA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_TEMA_CURSO.Text = mEntidad.ID_TEMA_CURSO.ToString()
        Me.ddlAREA_FORMACION1.Recuperar()
        Me.ddlAREA_FORMACION1.SelectedValue = mEntidad.ID_AREA_FORMACION
        Me.txtTEMA_CURSO.Text = mEntidad.TEMA_CURSO
        Me.txtDURACION_HORAS.Text = mEntidad.DURACION_HORAS
        Me.txtFECHA_ACREDITACION.Text = IIf(Not mEntidad.FECHA_ACREDITACION = Nothing, Format(mEntidad.FECHA_ACREDITACION, "dd/MM/yyyy"), "")
        Me.txtNOTAS.Text = mEntidad.NOTAS
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
        Me.ddlAREA_FORMACION1.Enabled = edicion
        Me.txtTEMA_CURSO.Enabled = edicion
        Me.txtDURACION_HORAS.Enabled = edicion
        Me.txtFECHA_ACREDITACION.Enabled = edicion
        Me.txtNOTAS.Enabled = edicion
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
        Me.ddlAREA_FORMACION1.Recuperar()
        Me.txtTEMA_CURSO.Text = ""
        Me.txtDURACION_HORAS.Text = ""
        Me.txtFECHA_ACREDITACION.Text = ""
        Me.txtNOTAS.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.txtLASTUPDATE.Text = Now.ToString("dd/MM/yyyy")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla CURSO_TEMA
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
        mEntidad = New CURSO_TEMA
        If Me._nuevo Then
            mEntidad.ID_TEMA_CURSO = 0
        Else
            mEntidad.ID_TEMA_CURSO = CInt(Me.txtID_TEMA_CURSO.Text)
        End If
        mEntidad.ID_AREA_FORMACION = Me.ddlAREA_FORMACION1.SelectedValue
        mEntidad.TEMA_CURSO = Me.txtTEMA_CURSO.Text
        mEntidad.DURACION_HORAS = Val(Me.txtDURACION_HORAS.Text)
        If Me.txtFECHA_ACREDITACION.Text <> "" Then mEntidad.FECHA_ACREDITACION = System.DateTime.Parse(Me.txtFECHA_ACREDITACION.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.NOTAS = Me.txtNOTAS.Text
        mEntidad.USERID = Me.ObtenerUsuario()
        If Me.txtLASTUPDATE.Text <> "" Then mEntidad.LASTUPDATE = System.DateTime.Parse(Me.txtLASTUPDATE.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If mComponente.ActualizarCURSO_TEMA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_TEMA_CURSO.Text = mEntidad.ID_TEMA_CURSO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
