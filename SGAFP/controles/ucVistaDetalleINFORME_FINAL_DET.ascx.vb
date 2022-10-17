Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleINFORME_FINAL_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla INFORME_FINAL_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	17/05/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleINFORME_FINAL_DET
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_INFORME_FINAL_DET As Decimal
    Public Property ID_INFORME_FINAL_DET() As Decimal
        Get
            Return Me.txtID_INFORME_FINAL_DET.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_INFORME_FINAL_DET = Value
            Me.txtID_INFORME_FINAL_DET.Text = CStr(Value)
            If Me._ID_INFORME_FINAL_DET > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_INFORME_FINAL_DET() As Boolean
        Get
            Return Me.trID_INFORME_FINAL_DET.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_INFORME_FINAL_DET.Visible = value
        End Set
    End Property

    Public Property VerID_INFORME_FINAL() As Boolean
        Get
            Return Me.trID_INFORME_FINAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_INFORME_FINAL.Visible = value
        End Set
    End Property

    Public Property VerID_PARTICIPANTE() As Boolean
        Get
            Return Me.trID_PARTICIPANTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PARTICIPANTE.Visible = value
        End Set
    End Property

    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me.trID_ACCION_FORMATIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Public Property VerNOTA_OBTENIDA() As Boolean
        Get
            Return Me.trNOTA_OBTENIDA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOTA_OBTENIDA.Visible = value
        End Set
    End Property

    Public Property VerPORC_ASISTENCIA() As Boolean
        Get
            Return Me.trPORC_ASISTENCIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPORC_ASISTENCIA.Visible = value
        End Set
    End Property

    Public Property VerMONTO_SOLICITADO() As Boolean
        Get
            Return Me.trMONTO_SOLICITADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMONTO_SOLICITADO.Visible = value
        End Set
    End Property

    Public Property VerMONTO_APROBADO() As Boolean
        Get
            Return Me.trMONTO_APROBADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMONTO_APROBADO.Visible = value
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
    Private mComponente As New cINFORME_FINAL_DET
    Private mEntidad As INFORME_FINAL_DET
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
        If Not Me.ViewState("ID_INFORME_FINAL_DET") Is Nothing Then Me._ID_INFORME_FINAL_DET = Me.ViewState("ID_INFORME_FINAL_DET")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla INFORME_FINAL_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New INFORME_FINAL_DET
        mEntidad.ID_INFORME_FINAL_DET = ID_INFORME_FINAL_DET
 
        If mComponente.ObtenerINFORME_FINAL_DET(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_INFORME_FINAL_DET.Text = mEntidad.ID_INFORME_FINAL_DET.ToString()
        Me.ddlINFORME_FINAL_AF1.Recuperar()
        Me.ddlINFORME_FINAL_AF1.SelectedValue = mEntidad.ID_INFORME_FINAL
        Me.ddlPARTICIPANTE1.Recuperar()
        Me.ddlPARTICIPANTE1.SelectedValue = mEntidad.ID_PARTICIPANTE
        Me.ddlACCION_FORMATIVA1.Recuperar()
        Me.ddlACCION_FORMATIVA1.SelectedValue = mEntidad.ID_ACCION_FORMATIVA
        Me.txtNOTA_OBTENIDA.Text = mEntidad.NOTA_OBTENIDA
        Me.txtPORC_ASISTENCIA.Text = mEntidad.PORC_ASISTENCIA
        Me.txtMONTO_SOLICITADO.Text = mEntidad.MONTO_SOLICITADO
        Me.txtMONTO_APROBADO.Text = mEntidad.MONTO_APROBADO
        Me.txtESTADO.Text = mEntidad.ESTADO
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
    ''' 	[GenApp]	17/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlINFORME_FINAL_AF1.Enabled = edicion
        Me.ddlPARTICIPANTE1.Enabled = edicion
        Me.ddlACCION_FORMATIVA1.Enabled = edicion
        Me.txtNOTA_OBTENIDA.Enabled = edicion
        Me.txtPORC_ASISTENCIA.Enabled = edicion
        Me.txtMONTO_SOLICITADO.Enabled = edicion
        Me.txtMONTO_APROBADO.Enabled = edicion
        Me.txtESTADO.Enabled = edicion
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
    ''' 	[GenApp]	17/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlINFORME_FINAL_AF1.Recuperar()
        Me.ddlPARTICIPANTE1.Recuperar()
        Me.ddlACCION_FORMATIVA1.Recuperar()
        Me.txtNOTA_OBTENIDA.Text = ""
        Me.txtPORC_ASISTENCIA.Text = ""
        Me.txtMONTO_SOLICITADO.Text = ""
        Me.txtMONTO_APROBADO.Text = ""
        Me.txtESTADO.Text = ""
        Me.txtNOTAS.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.txtLASTUPDATE.Text = Now.ToString("dd/MM/yyyy")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla INFORME_FINAL_DET
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	17/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New INFORME_FINAL_DET
        If Me._nuevo Then
            mEntidad.ID_INFORME_FINAL_DET = 0
        Else
            mEntidad.ID_INFORME_FINAL_DET = CInt(Me.txtID_INFORME_FINAL_DET.Text)
        End If
        mEntidad.ID_INFORME_FINAL = Me.ddlINFORME_FINAL_AF1.SelectedValue
        mEntidad.ID_PARTICIPANTE = Me.ddlPARTICIPANTE1.SelectedValue
        mEntidad.ID_ACCION_FORMATIVA = Me.ddlACCION_FORMATIVA1.SelectedValue
        mEntidad.NOTA_OBTENIDA = Val(Me.txtNOTA_OBTENIDA.Text)
        mEntidad.PORC_ASISTENCIA = Val(Me.txtPORC_ASISTENCIA.Text)
        mEntidad.MONTO_SOLICITADO = Val(Me.txtMONTO_SOLICITADO.Text)
        mEntidad.MONTO_APROBADO = Val(Me.txtMONTO_APROBADO.Text)
        mEntidad.ESTADO = Me.txtESTADO.Text
        mEntidad.NOTAS = Me.txtNOTAS.Text
        mEntidad.USERID = Me.ObtenerUsuario()
        If Me.txtLASTUPDATE.Text <> "" Then mEntidad.LASTUPDATE = System.DateTime.Parse(Me.txtLASTUPDATE.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If mComponente.ActualizarINFORME_FINAL_DET(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_INFORME_FINAL_DET.Text = mEntidad.ID_INFORME_FINAL_DET.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
