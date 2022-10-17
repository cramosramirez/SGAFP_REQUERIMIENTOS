Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleCONTROL_DOCUMENTOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla CONTROL_DOCUMENTOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleCONTROL_DOCUMENTOS
    Inherits ucBase
 
#Region"Propiedades"

    Private _NUMERO_DOCUMENTO As Decimal
    Public Property NUMERO_DOCUMENTO() As Decimal
        Get
            Return Me.txtNUMERO_DOCUMENTO.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._NUMERO_DOCUMENTO = Value
            Me.txtNUMERO_DOCUMENTO.Text = CStr(Value)
            If Me._NUMERO_DOCUMENTO > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerNUMERO_DOCUMENTO() As Boolean
        Get
            Return Me.trNUMERO_DOCUMENTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNUMERO_DOCUMENTO.Visible = value
        End Set
    End Property

    Public Property VerNUMERO_PATRONAL() As Boolean
        Get
            Return Me.trNUMERO_PATRONAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNUMERO_PATRONAL.Visible = value
        End Set
    End Property

    Public Property VerNUMERO_FOLIO() As Boolean
        Get
            Return Me.trNUMERO_FOLIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNUMERO_FOLIO.Visible = value
        End Set
    End Property

    Public Property VerID_TIPO_SOLICITUD() As Boolean
        Get
            Return Me.trID_TIPO_SOLICITUD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIPO_SOLICITUD.Visible = value
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

    Public Property VerNIT() As Boolean
        Get
            Return Me.trNIT.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNIT.Visible = value
        End Set
    End Property

    Public Property VerPRESENTADO_POR() As Boolean
        Get
            Return Me.trPRESENTADO_POR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPRESENTADO_POR.Visible = value
        End Set
    End Property

    Public Property VerFECHA_RECEPCION() As Boolean
        Get
            Return Me.trFECHA_RECEPCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_RECEPCION.Visible = value
        End Set
    End Property

    Public Property VerRESPONSABLE_ACTUAL() As Boolean
        Get
            Return Me.trRESPONSABLE_ACTUAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trRESPONSABLE_ACTUAL.Visible = value
        End Set
    End Property

    Public Property VerRESPONSABLE_ANTERIOR() As Boolean
        Get
            Return Me.trRESPONSABLE_ANTERIOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trRESPONSABLE_ANTERIOR.Visible = value
        End Set
    End Property

    Public Property VerPRIORIDAD() As Boolean
        Get
            Return Me.trPRIORIDAD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPRIORIDAD.Visible = value
        End Set
    End Property

    Public Property VerNO_DOCUMENTO_ORIGEN() As Boolean
        Get
            Return Me.trNO_DOCUMENTO_ORIGEN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNO_DOCUMENTO_ORIGEN.Visible = value
        End Set
    End Property

    Public Property VerNO_DOCUMENTO_PADRE() As Boolean
        Get
            Return Me.trNO_DOCUMENTO_PADRE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNO_DOCUMENTO_PADRE.Visible = value
        End Set
    End Property

    Public Property VerFECHA_REQUERIDA_FIN() As Boolean
        Get
            Return Me.trFECHA_REQUERIDA_FIN.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_REQUERIDA_FIN.Visible = value
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
    Private mComponente As New cCONTROL_DOCUMENTOS
    Private mEntidad As CONTROL_DOCUMENTOS
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
        If Not Me.ViewState("NUMERO_DOCUMENTO") Is Nothing Then Me._NUMERO_DOCUMENTO = Me.ViewState("NUMERO_DOCUMENTO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla CONTROL_DOCUMENTOS
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
        mEntidad = New CONTROL_DOCUMENTOS
        mEntidad.NUMERO_DOCUMENTO = NUMERO_DOCUMENTO
 
        If mComponente.ObtenerCONTROL_DOCUMENTOS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtNUMERO_DOCUMENTO.Text = mEntidad.NUMERO_DOCUMENTO.ToString()
        Me.txtNUMERO_PATRONAL.Text = mEntidad.NUMERO_PATRONAL
        Me.txtNUMERO_FOLIO.Text = mEntidad.NUMERO_FOLIO
        Me.ddlTIPO_SOLICITUD1.Recuperar()
        Me.ddlTIPO_SOLICITUD1.SelectedValue = mEntidad.ID_TIPO_SOLICITUD
        Me.ddlETAPA1.Recuperar(Me.ddlPROCESO1.SelectedValue)
        Me.ddlETAPA1.SelectedValue = mEntidad.CODIGO_ETAPA
        Me.ddlPROCESO1.Recuperar()
        Me.ddlPROCESO1.SelectedValue = mEntidad.CODIGO_PROCESO
        Me.ddlESTADO_SOLICITUD1.Recuperar()
        Me.ddlESTADO_SOLICITUD1.SelectedValue = mEntidad.ID_ESTADO_SOLICITUD
        Me.txtNIT.Text = mEntidad.NIT
        Me.txtPRESENTADO_POR.Text = mEntidad.PRESENTADO_POR
        Me.txtFECHA_RECEPCION.Text = IIf(Not mEntidad.FECHA_RECEPCION = Nothing, Format(mEntidad.FECHA_RECEPCION, "dd/MM/yyyy"), "")
        Me.txtRESPONSABLE_ACTUAL.Text = mEntidad.RESPONSABLE_ACTUAL
        Me.txtRESPONSABLE_ANTERIOR.Text = mEntidad.RESPONSABLE_ANTERIOR
        Me.txtPRIORIDAD.Text = mEntidad.PRIORIDAD
        Me.txtNO_DOCUMENTO_ORIGEN.Text = mEntidad.NO_DOCUMENTO_ORIGEN
        Me.txtNO_DOCUMENTO_PADRE.Text = mEntidad.NO_DOCUMENTO_PADRE
        Me.txtFECHA_REQUERIDA_FIN.Text = IIf(Not mEntidad.FECHA_REQUERIDA_FIN = Nothing, Format(mEntidad.FECHA_REQUERIDA_FIN, "dd/MM/yyyy"), "")
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
        Me.ddlTIPO_SOLICITUD1.Enabled = edicion
        Me.ddlETAPA1.Enabled = edicion
        Me.ddlPROCESO1.Enabled = edicion
        Me.ddlESTADO_SOLICITUD1.Enabled = edicion
        Me.txtNUMERO_PATRONAL.Enabled = edicion
        Me.txtNUMERO_FOLIO.Enabled = edicion
        Me.txtNIT.Enabled = edicion
        Me.txtPRESENTADO_POR.Enabled = edicion
        Me.txtFECHA_RECEPCION.Enabled = edicion
        Me.txtRESPONSABLE_ACTUAL.Enabled = edicion
        Me.txtRESPONSABLE_ANTERIOR.Enabled = edicion
        Me.txtPRIORIDAD.Enabled = edicion
        Me.txtNO_DOCUMENTO_ORIGEN.Enabled = edicion
        Me.txtNO_DOCUMENTO_PADRE.Enabled = edicion
        Me.txtFECHA_REQUERIDA_FIN.Enabled = edicion
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
        Me.ddlTIPO_SOLICITUD1.Recuperar()
        Me.ddlETAPA1.Recuperar(Me.ddlPROCESO1.SelectedValue)
        Me.ddlPROCESO1.Recuperar()
        Me.ddlESTADO_SOLICITUD1.Recuperar()
        Me.txtNUMERO_PATRONAL.Text = ""
        Me.txtNUMERO_FOLIO.Text = ""
        Me.txtNIT.Text = ""
        Me.txtPRESENTADO_POR.Text = ""
        Me.txtFECHA_RECEPCION.Text = ""
        Me.txtRESPONSABLE_ACTUAL.Text = ""
        Me.txtRESPONSABLE_ANTERIOR.Text = ""
        Me.txtPRIORIDAD.Text = ""
        Me.txtNO_DOCUMENTO_ORIGEN.Text = ""
        Me.txtNO_DOCUMENTO_PADRE.Text = ""
        Me.txtFECHA_REQUERIDA_FIN.Text = ""
        Me.txtNOTAS.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.txtLASTUPDATE.Text = Now.ToString("dd/MM/yyyy")
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla CONTROL_DOCUMENTOS
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
        mEntidad = New CONTROL_DOCUMENTOS
        If Me._nuevo Then
            mEntidad.NUMERO_DOCUMENTO = 0
        Else
            mEntidad.NUMERO_DOCUMENTO = CInt(Me.txtNUMERO_DOCUMENTO.Text)
        End If
        mEntidad.NUMERO_PATRONAL = Me.txtNUMERO_PATRONAL.Text
        mEntidad.NUMERO_FOLIO = Me.txtNUMERO_FOLIO.Text
        mEntidad.ID_TIPO_SOLICITUD = Me.ddlTIPO_SOLICITUD1.SelectedValue
        mEntidad.CODIGO_ETAPA = Me.ddlETAPA1.SelectedValue
        mEntidad.CODIGO_PROCESO = Me.ddlPROCESO1.SelectedValue
        mEntidad.ID_ESTADO_SOLICITUD = Me.ddlESTADO_SOLICITUD1.SelectedValue
        mEntidad.NIT = Me.txtNIT.Text
        mEntidad.PRESENTADO_POR = Me.txtPRESENTADO_POR.Text
        If Me.txtFECHA_RECEPCION.Text <> "" Then mEntidad.FECHA_RECEPCION = System.DateTime.Parse(Me.txtFECHA_RECEPCION.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.RESPONSABLE_ACTUAL = Me.txtRESPONSABLE_ACTUAL.Text
        mEntidad.RESPONSABLE_ANTERIOR = Me.txtRESPONSABLE_ANTERIOR.Text
        mEntidad.PRIORIDAD = Me.txtPRIORIDAD.Text
        mEntidad.NO_DOCUMENTO_ORIGEN = Val(Me.txtNO_DOCUMENTO_ORIGEN.Text)
        mEntidad.NO_DOCUMENTO_PADRE = Val(Me.txtNO_DOCUMENTO_PADRE.Text)
        If Me.txtFECHA_REQUERIDA_FIN.Text <> "" Then mEntidad.FECHA_REQUERIDA_FIN = System.DateTime.Parse(Me.txtFECHA_REQUERIDA_FIN.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.NOTAS = Me.txtNOTAS.Text
        mEntidad.USERID = Me.ObtenerUsuario()
        If Me.txtLASTUPDATE.Text <> "" Then mEntidad.LASTUPDATE = System.DateTime.Parse(Me.txtLASTUPDATE.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)

        If mComponente.ActualizarCONTROL_DOCUMENTOS(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtNUMERO_DOCUMENTO.Text = mEntidad.NUMERO_DOCUMENTO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
