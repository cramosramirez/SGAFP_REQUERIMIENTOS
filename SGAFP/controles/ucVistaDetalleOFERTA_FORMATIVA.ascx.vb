Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleOFERTA_FORMATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla OFERTA_FORMATIVA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleOFERTA_FORMATIVA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_OFERTA_FORMATIVA As Decimal
    Public Property ID_OFERTA_FORMATIVA() As Decimal
        Get
            Return Me.txtID_OFERTA_FORMATIVA.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_OFERTA_FORMATIVA = Value
            Me.txtID_OFERTA_FORMATIVA.Text = CStr(Value)
            If Me._ID_OFERTA_FORMATIVA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_OFERTA_FORMATIVA() As Boolean
        Get
            Return Me.trID_OFERTA_FORMATIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_OFERTA_FORMATIVA.Visible = value
        End Set
    End Property

    Public Property VerID_EJERCICIO() As Boolean
        Get
            Return Me.trID_EJERCICIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_EJERCICIO.Visible = value
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

    Public Property VerID_PROVEEDOR_AF() As Boolean
        Get
            Return Me.trID_PROVEEDOR_AF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PROVEEDOR_AF.Visible = value
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

    Public Property VerCOSTO_X_PARTICIPANTE() As Boolean
        Get
            Return Me.trCOSTO_X_PARTICIPANTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCOSTO_X_PARTICIPANTE.Visible = value
        End Set
    End Property

    Public Property VerFECHA_INICIO() As Boolean
        Get
            Return Me.trFECHA_INICIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_INICIO.Visible = value
        End Set
    End Property

    Public Property VerFECHA_FIN() As Boolean
        Get
            Return Me.trFECHA_FIN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_FIN.Visible = value
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

    Public Property VerESTADO() As Boolean
        Get
            Return Me.trESTADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trESTADO.Visible = value
        End Set
    End Property

    Public Property VerFECHA_APROBACION() As Boolean
        Get
            Return Me.trFECHA_APROBACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_APROBACION.Visible = value
        End Set
    End Property

    Public Property VerUSUARIO_APROBACION() As Boolean
        Get
            Return Me.trUSUARIO_APROBACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO_APROBACION.Visible = value
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
    Private mComponente As New cOFERTA_FORMATIVA
    Private mEntidad As OFERTA_FORMATIVA
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
        If Not Me.ViewState("ID_OFERTA_FORMATIVA") Is Nothing Then Me._ID_OFERTA_FORMATIVA = Me.ViewState("ID_OFERTA_FORMATIVA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla OFERTA_FORMATIVA
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
        mEntidad = New OFERTA_FORMATIVA
        mEntidad.ID_OFERTA_FORMATIVA = ID_OFERTA_FORMATIVA
 
        If mComponente.ObtenerOFERTA_FORMATIVA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_OFERTA_FORMATIVA.Text = mEntidad.ID_OFERTA_FORMATIVA.ToString()
        Me.ddlEJERCICIO1.Recuperar()
        Me.ddlEJERCICIO1.SelectedValue = mEntidad.ID_EJERCICIO
        Me.ddlCURSO_TEMA1.Recuperar()
        Me.ddlCURSO_TEMA1.SelectedValue = mEntidad.ID_TEMA_CURSO
        Me.ddlPROVEEDOR_AF1.Recuperar()
        Me.ddlPROVEEDOR_AF1.SelectedValue = mEntidad.ID_PROVEEDOR_AF
        Me.txtDURACION_HORAS.Text = mEntidad.DURACION_HORAS
        Me.txtCOSTO_X_PARTICIPANTE.Text = mEntidad.COSTO_X_PARTICIPANTE
        Me.txtFECHA_INICIO.Text = IIf(Not mEntidad.FECHA_INICIO = Nothing, Format(mEntidad.FECHA_INICIO, "dd/MM/yyyy"), "")
        Me.txtFECHA_FIN.Text = IIf(Not mEntidad.FECHA_FIN = Nothing, Format(mEntidad.FECHA_FIN, "dd/MM/yyyy"), "")
        Me.txtNOTAS.Text = mEntidad.NOTAS
        Me.txtESTADO.Text = mEntidad.ESTADO
        Me.txtFECHA_APROBACION.Text = IIf(Not mEntidad.FECHA_APROBACION = Nothing, Format(mEntidad.FECHA_APROBACION, "dd/MM/yyyy"), "")
        Me.txtUSUARIO_APROBACION.Text = IIf(Not mEntidad.USUARIO_APROBACION = Nothing, Format(mEntidad.USUARIO_APROBACION, "dd/MM/yyyy"), "")
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
        Me.ddlEJERCICIO1.Enabled = edicion
        Me.ddlCURSO_TEMA1.Enabled = edicion
        Me.ddlPROVEEDOR_AF1.Enabled = edicion
        Me.txtDURACION_HORAS.Enabled = edicion
        Me.txtCOSTO_X_PARTICIPANTE.Enabled = edicion
        Me.txtFECHA_INICIO.Enabled = edicion
        Me.txtFECHA_FIN.Enabled = edicion
        Me.txtNOTAS.Enabled = edicion
        Me.txtESTADO.Enabled = edicion
        Me.txtFECHA_APROBACION.Enabled = edicion
        Me.txtUSUARIO_APROBACION.Enabled = edicion
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
        Me.ddlEJERCICIO1.Recuperar()
        Me.ddlCURSO_TEMA1.Recuperar()
        Me.ddlPROVEEDOR_AF1.Recuperar()
        Me.txtDURACION_HORAS.Text = ""
        Me.txtCOSTO_X_PARTICIPANTE.Text = ""
        Me.txtFECHA_INICIO.Text = ""
        Me.txtFECHA_FIN.Text = ""
        Me.txtNOTAS.Text = ""
        Me.txtESTADO.Text = ""
        Me.txtFECHA_APROBACION.Text = ""
        Me.txtUSUARIO_APROBACION.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.txtLASTUPDATE.Text = Now.ToString("dd/MM/yyyy")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla OFERTA_FORMATIVA
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
        mEntidad = New OFERTA_FORMATIVA
        If Me._nuevo Then
            mEntidad.ID_OFERTA_FORMATIVA = 0
        Else
            mEntidad.ID_OFERTA_FORMATIVA = CInt(Me.txtID_OFERTA_FORMATIVA.Text)
        End If
        mEntidad.ID_EJERCICIO = Me.ddlEJERCICIO1.SelectedValue
        mEntidad.ID_TEMA_CURSO = Me.ddlCURSO_TEMA1.SelectedValue
        mEntidad.ID_PROVEEDOR_AF = Me.ddlPROVEEDOR_AF1.SelectedValue
        mEntidad.DURACION_HORAS = Val(Me.txtDURACION_HORAS.Text)
        mEntidad.COSTO_X_PARTICIPANTE = Val(Me.txtCOSTO_X_PARTICIPANTE.Text)
        If Me.txtFECHA_INICIO.Text <> "" Then mEntidad.FECHA_INICIO = System.DateTime.Parse(Me.txtFECHA_INICIO.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        If Me.txtFECHA_FIN.Text <> "" Then mEntidad.FECHA_FIN = System.DateTime.Parse(Me.txtFECHA_FIN.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.NOTAS = Me.txtNOTAS.Text
        mEntidad.ESTADO = Me.txtESTADO.Text
        If Me.txtFECHA_APROBACION.Text <> "" Then mEntidad.FECHA_APROBACION = System.DateTime.Parse(Me.txtFECHA_APROBACION.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        If Me.txtUSUARIO_APROBACION.Text <> "" Then mEntidad.USUARIO_APROBACION = System.DateTime.Parse(Me.txtUSUARIO_APROBACION.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.USERID = Me.ObtenerUsuario()
        If Me.txtLASTUPDATE.Text <> "" Then mEntidad.LASTUPDATE = System.DateTime.Parse(Me.txtLASTUPDATE.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If mComponente.ActualizarOFERTA_FORMATIVA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_OFERTA_FORMATIVA.Text = mEntidad.ID_OFERTA_FORMATIVA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
