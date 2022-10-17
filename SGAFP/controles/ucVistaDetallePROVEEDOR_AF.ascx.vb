Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetallePROVEEDOR_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PROVEEDOR_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/03/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePROVEEDOR_AF
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_PROVEEDOR_AF As Decimal
    Public Property ID_PROVEEDOR_AF() As Decimal
        Get
            Return Me.txtID_PROVEEDOR_AF.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_PROVEEDOR_AF = Value
            Me.txtID_PROVEEDOR_AF.Text = CStr(Value)
            If Me._ID_PROVEEDOR_AF > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property CODIGO_MUNICIPIO() As String
        Get
            Return Me.ddlMUNICIPIOCODIGO_MUNICIPIO.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Items.FindByValue(value) Is Nothing Then
                Me.ddlMUNICIPIOCODIGO_MUNICIPIO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue
        End Get
        Set(ByVal value As String)
            If Not Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Items.FindByValue(value) Is Nothing Then
                Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property ID_TIPO_PERSONA() As Decimal
        Get
            Return Me.ddlTIPO_PERSONAID_TIPO_PERSONA.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlTIPO_PERSONAID_TIPO_PERSONA.Items.FindByValue(value) Is Nothing Then
                Me.ddlTIPO_PERSONAID_TIPO_PERSONA.SelectedValue = value
            End If
        End Set
    End Property

    Public Property NOMBRE_PROVEEDOR() As String
        Get
            Return Me.txtNOMBRE_PROVEEDOR.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_PROVEEDOR.Text = value.ToString()
        End Set
    End Property

    Public Property RAZON_SOCIAL() As String
        Get
            Return Me.txtRAZON_SOCIAL.Text
        End Get
        Set(ByVal value As String)
            Me.txtRAZON_SOCIAL.Text = value.ToString()
        End Set
    End Property

    Public Property NIT() As String
        Get
            Return Me.txtNIT.Text
        End Get
        Set(ByVal value As String)
            Me.txtNIT.Text = value.ToString()
        End Set
    End Property

    Public Property DUI() As String
        Get
            Return Me.txtDUI.Text
        End Get
        Set(ByVal value As String)
            Me.txtDUI.Text = value.ToString()
        End Set
    End Property

    Public Property NRC() As String
        Get
            Return Me.txtNRC.Text
        End Get
        Set(ByVal value As String)
            Me.txtNRC.Text = value.ToString()
        End Set
    End Property

    Public Property ISSS() As String
        Get
            Return Me.txtISSS.Text
        End Get
        Set(ByVal value As String)
            Me.txtISSS.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_INGRESO() As DateTime
        Get
            Return Me.deFECHA_INGRESO.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_INGRESO.Value = value
        End Set
    End Property

    Public Property FECHA_ACREDITACION() As DateTime
        Get
            Return Me.deFECHA_ACREDITACION.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_ACREDITACION.Value = value
        End Set
    End Property

    Public Property DIRECCION() As String
        Get
            Return Me.txtDIRECCION.Text
        End Get
        Set(ByVal value As String)
            Me.txtDIRECCION.Text = value.ToString()
        End Set
    End Property

    Public Property EMAIL() As String
        Get
            Return Me.txtEMAIL.Text
        End Get
        Set(ByVal value As String)
            Me.txtEMAIL.Text = value.ToString()
        End Set
    End Property

    Public Property TELEFONO() As String
        Get
            Return Me.txtTELEFONO.Text
        End Get
        Set(ByVal value As String)
            Me.txtTELEFONO.Text = value.ToString()
        End Set
    End Property

    Public Property FAX() As String
        Get
            Return Me.txtFAX.Text
        End Get
        Set(ByVal value As String)
            Me.txtFAX.Text = value.ToString()
        End Set
    End Property

    Public Property URL() As String
        Get
            Return Me.txtURL.Text
        End Get
        Set(ByVal value As String)
            Me.txtURL.Text = value.ToString()
        End Set
    End Property

    Public Property CONTACTO() As String
        Get
            Return Me.txtCONTACTO.Text
        End Get
        Set(ByVal value As String)
            Me.txtCONTACTO.Text = value.ToString()
        End Set
    End Property

    Public Property TELEFONO_CONTACTO() As String
        Get
            Return Me.txtTELEFONO_CONTACTO.Text
        End Get
        Set(ByVal value As String)
            Me.txtTELEFONO_CONTACTO.Text = value.ToString()
        End Set
    End Property

    Public Property EMAIL_CONTACTO() As String
        Get
            Return Me.txtEMAIL_CONTACTO.Text
        End Get
        Set(ByVal value As String)
            Me.txtEMAIL_CONTACTO.Text = value.ToString()
        End Set
    End Property

    Public Property CARGO_CONTACTO() As String
        Get
            Return Me.txtCARGO_CONTACTO.Text
        End Get
        Set(ByVal value As String)
            Me.txtCARGO_CONTACTO.Text = value.ToString()
        End Set
    End Property

    Public Property ESTADO() As String
        Get
            Return Me.txtESTADO.Text
        End Get
        Set(ByVal value As String)
            Me.txtESTADO.Text = value.ToString()
        End Set
    End Property

    Public Property NOTAS() As String
        Get
            Return Me.txtNOTAS.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOTAS.Text = value.ToString()
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

    Public Property VerID_PROVEEDOR_AF() As Boolean
        Get
            Return Me.trID_PROVEEDOR_AF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PROVEEDOR_AF.Visible = value
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

    Public Property VerCODIGO_DEPARTAMENTO() As Boolean
        Get
            Return Me.trCODIGO_DEPARTAMENTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_DEPARTAMENTO.Visible = value
        End Set
    End Property

    Public Property VerID_TIPO_PERSONA() As Boolean
        Get
            Return Me.trID_TIPO_PERSONA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_TIPO_PERSONA.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_PROVEEDOR() As Boolean
        Get
            Return Me.trNOMBRE_PROVEEDOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_PROVEEDOR.Visible = value
        End Set
    End Property

    Public Property VerRAZON_SOCIAL() As Boolean
        Get
            Return Me.trRAZON_SOCIAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trRAZON_SOCIAL.Visible = value
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

    Public Property VerDUI() As Boolean
        Get
            Return Me.trDUI.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDUI.Visible = value
        End Set
    End Property

    Public Property VerNRC() As Boolean
        Get
            Return Me.trNRC.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNRC.Visible = value
        End Set
    End Property

    Public Property VerISSS() As Boolean
        Get
            Return Me.trISSS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trISSS.Visible = value
        End Set
    End Property

    Public Property VerFECHA_INGRESO() As Boolean
        Get
            Return Me.trFECHA_INGRESO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_INGRESO.Visible = value
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

    Public Property VerDIRECCION() As Boolean
        Get
            Return Me.trDIRECCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDIRECCION.Visible = value
        End Set
    End Property

    Public Property VerEMAIL() As Boolean
        Get
            Return Me.trEMAIL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEMAIL.Visible = value
        End Set
    End Property

    Public Property VerTELEFONO() As Boolean
        Get
            Return Me.trTELEFONO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTELEFONO.Visible = value
        End Set
    End Property

    Public Property VerFAX() As Boolean
        Get
            Return Me.trFAX.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFAX.Visible = value
        End Set
    End Property

    Public Property VerURL() As Boolean
        Get
            Return Me.trURL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trURL.Visible = value
        End Set
    End Property

    Public Property VerCONTACTO() As Boolean
        Get
            Return Me.trCONTACTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCONTACTO.Visible = value
        End Set
    End Property

    Public Property VerTELEFONO_CONTACTO() As Boolean
        Get
            Return Me.trTELEFONO_CONTACTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTELEFONO_CONTACTO.Visible = value
        End Set
    End Property

    Public Property VerEMAIL_CONTACTO() As Boolean
        Get
            Return Me.trEMAIL_CONTACTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEMAIL_CONTACTO.Visible = value
        End Set
    End Property

    Public Property VerCARGO_CONTACTO() As Boolean
        Get
            Return Me.trCARGO_CONTACTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCARGO_CONTACTO.Visible = value
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
    Private mComponente As New cPROVEEDOR_AF
    Private mEntidad As PROVEEDOR_AF
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
        If Not Me.ViewState("ID_PROVEEDOR_AF") Is Nothing Then Me._ID_PROVEEDOR_AF = Me.ViewState("ID_PROVEEDOR_AF")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PROVEEDOR_AF
        mEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
 
        If mComponente.ObtenerPROVEEDOR_AF(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_PROVEEDOR_AF.Text = mEntidad.ID_PROVEEDOR_AF.ToString()
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Recuperar(Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue)
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.SelectedValue = mEntidad.CODIGO_MUNICIPIO
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Recuperar()
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue = mEntidad.CODIGO_DEPARTAMENTO
        Me.ddlTIPO_PERSONAID_TIPO_PERSONA.Recuperar()
        Me.ddlTIPO_PERSONAID_TIPO_PERSONA.SelectedValue = mEntidad.ID_TIPO_PERSONA
        Me.txtNOMBRE_PROVEEDOR.Text = mEntidad.NOMBRE_PROVEEDOR
        Me.txtRAZON_SOCIAL.Text = mEntidad.RAZON_SOCIAL
        Me.txtNIT.Text = mEntidad.NIT
        Me.txtDUI.Text = mEntidad.DUI
        Me.txtNRC.Text = mEntidad.NRC
        Me.txtISSS.Text = mEntidad.ISSS
        Me.deFECHA_INGRESO.Value = mEntidad.FECHA_INGRESO
        Me.deFECHA_ACREDITACION.Value = mEntidad.FECHA_ACREDITACION
        Me.txtDIRECCION.Text = mEntidad.DIRECCION
        Me.txtEMAIL.Text = mEntidad.EMAIL
        Me.txtTELEFONO.Text = mEntidad.TELEFONO
        Me.txtFAX.Text = mEntidad.FAX
        Me.txtURL.Text = mEntidad.URL
        Me.txtCONTACTO.Text = mEntidad.CONTACTO
        Me.txtTELEFONO_CONTACTO.Text = mEntidad.TELEFONO_CONTACTO
        Me.txtEMAIL_CONTACTO.Text = mEntidad.EMAIL_CONTACTO
        Me.txtCARGO_CONTACTO.Text = mEntidad.CARGO_CONTACTO
        Me.txtESTADO.Text = mEntidad.ESTADO
        Me.txtNOTAS.Text = mEntidad.NOTAS
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
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Enabled = edicion
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Enabled = edicion
        Me.ddlTIPO_PERSONAID_TIPO_PERSONA.Enabled = edicion
        Me.txtNOMBRE_PROVEEDOR.Enabled = edicion
        Me.txtRAZON_SOCIAL.Enabled = edicion
        Me.txtNIT.Enabled = edicion
        Me.txtDUI.Enabled = edicion
        Me.txtNRC.Enabled = edicion
        Me.txtISSS.Enabled = edicion
        Me.deFECHA_INGRESO.Enabled = False
        Me.deFECHA_ACREDITACION.Enabled = edicion
        Me.txtDIRECCION.Enabled = edicion
        Me.txtEMAIL.Enabled = edicion
        Me.txtTELEFONO.Enabled = edicion
        Me.txtFAX.Enabled = edicion
        Me.txtURL.Enabled = edicion
        Me.txtCONTACTO.Enabled = edicion
        Me.txtTELEFONO_CONTACTO.Enabled = edicion
        Me.txtEMAIL_CONTACTO.Enabled = edicion
        Me.txtCARGO_CONTACTO.Enabled = edicion
        Me.txtESTADO.Enabled = edicion
        Me.txtNOTAS.Enabled = edicion
        Me.txtUSERID.Enabled = False
        Me.deLASTUPDATE.Enabled = False

        Me.trESTADO.Visible = False
        Me.trNOTAS.Visible = False
        Me.trUSERID.Visible = False
        Me.trLASTUPDATE.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Recuperar()
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Recuperar(Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue)
        Me.ddlTIPO_PERSONAID_TIPO_PERSONA.Recuperar()
        Me.txtNOMBRE_PROVEEDOR.Text = ""
        Me.txtRAZON_SOCIAL.Text = ""
        Me.txtNIT.Text = ""
        Me.txtDUI.Text = ""
        Me.txtNRC.Text = ""
        Me.txtISSS.Text = ""
        Me.deFECHA_INGRESO.Date = Today
        Me.deFECHA_ACREDITACION.Value = Nothing
        Me.txtDIRECCION.Text = ""
        Me.txtEMAIL.Text = ""
        Me.txtTELEFONO.Text = ""
        Me.txtFAX.Text = ""
        Me.txtURL.Text = ""
        Me.txtCONTACTO.Text = ""
        Me.txtTELEFONO_CONTACTO.Text = ""
        Me.txtEMAIL_CONTACTO.Text = ""
        Me.txtCARGO_CONTACTO.Text = ""
        Me.txtESTADO.Text = ""
        Me.txtNOTAS.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.deLASTUPDATE.Value = Now
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla PROVEEDOR_AF
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New PROVEEDOR_AF
        If Me._nuevo Then
            mEntidad.ID_PROVEEDOR_AF = 0
            mEntidad.USUARIO_CREACION = Me.ObtenerUsuario()
            mEntidad.FECHA_CREACION = Now
        Else
            mEntidad = mComponente.ObtenerPROVEEDOR_AF(CInt(Me.txtID_PROVEEDOR_AF.Text))
        End If

        If Me.txtNOMBRE_PROVEEDOR.Text.Trim = "" Then
            Me.AsignarMensaje("* Nombre del Proveedor es requerido.", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.txtRAZON_SOCIAL.Text.Trim = "" Then
            Me.AsignarMensaje("* Razon Social es requerido.", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.txtNIT.Text.Trim = "" Then
            Me.AsignarMensaje("* NIT es requerido.", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.txtDUI.Text.Length > 0 AndAlso Me.txtDUI.Text.Length < 9 Then
            Me.AsignarMensaje("* DUI no valido.", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.txtNIT.Text.Length > 0 AndAlso Me.txtNIT.Text.Length < 14 Then
            Me.AsignarMensaje("* NIT no valido.", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.txtDUI.Text.Length > 0 AndAlso Not Utilerias.EsDUI(Me.txtDUI.Text.Trim) Then
            Me.AsignarMensaje("* DUI no valido.", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.txtDUI.Text = "" AndAlso Me.ddlTIPO_PERSONAID_TIPO_PERSONA.SelectedValue = 1 Then
            Me.AsignarMensaje("* DUI es obligatorio para persona natural.", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.txtNIT.Text.Length > 0 AndAlso Not Utilerias.EsNIT(Me.txtNIT.Text.Trim) Then
            Me.AsignarMensaje("* NIT no valido.", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.deFECHA_ACREDITACION.Value Is Nothing Then
            Me.AsignarMensaje("* Fecha de Acreditacion es requerida.", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.deFECHA_ACREDITACION.Date > Me.deFECHA_INGRESO.Date Then
            Me.AsignarMensaje("* La fecha de acreditacion no puede ser mayor que la fecha de ingreso del proveedor.", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.txtDIRECCION.Text.Trim = "" Then
            Me.AsignarMensaje("* Direccion es requerido.", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.txtTELEFONO.Text.Trim = "" OrElse Me.txtTELEFONO.Text.Length < 8 Then
            Me.AsignarMensaje("* Telefono es requerido.", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.txtFAX.Text.Trim <> "" AndAlso Me.txtFAX.Text.Length < 8 Then
            Me.AsignarMensaje("* Fax no valido.", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.txtCONTACTO.Text.Trim = "" Then
            Me.AsignarMensaje("* Contacto es requerido.", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.txtTELEFONO_CONTACTO.Text.Trim = "" OrElse Me.txtTELEFONO_CONTACTO.Text.Length < 8 Then
            Me.AsignarMensaje("* Telefono contacto es requerido.", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.txtCARGO_CONTACTO.Text.Trim = "" Then
            Me.AsignarMensaje("* Cargo del Contacto es requerido.", True, True)
            Return "Error al Guardar registro."
        End If

        mEntidad.CODIGO_MUNICIPIO = Me.ddlMUNICIPIOCODIGO_MUNICIPIO.SelectedValue
        mEntidad.CODIGO_DEPARTAMENTO = Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue
        mEntidad.ID_TIPO_PERSONA = Me.ddlTIPO_PERSONAID_TIPO_PERSONA.SelectedValue
        mEntidad.NOMBRE_PROVEEDOR = Me.txtNOMBRE_PROVEEDOR.Text.ToUpper.Trim
        mEntidad.RAZON_SOCIAL = Me.txtRAZON_SOCIAL.Text.ToUpper.Trim
        mEntidad.NIT = Me.txtNIT.Text
        mEntidad.DUI = Me.txtDUI.Text
        mEntidad.NRC = Me.txtNRC.Text
        mEntidad.ISSS = Me.txtISSS.Text
        mEntidad.FECHA_INGRESO = Me.deFECHA_INGRESO.Value
        mEntidad.FECHA_ACREDITACION = Me.deFECHA_ACREDITACION.Value
        mEntidad.DIRECCION = Me.txtDIRECCION.Text.ToUpper.Trim
        mEntidad.EMAIL = Me.txtEMAIL.Text
        mEntidad.TELEFONO = Me.txtTELEFONO.Text
        mEntidad.FAX = Me.txtFAX.Text
        mEntidad.URL = Me.txtURL.Text
        mEntidad.CONTACTO = Me.txtCONTACTO.Text.ToUpper.Trim
        mEntidad.TELEFONO_CONTACTO = Me.txtTELEFONO_CONTACTO.Text
        mEntidad.EMAIL_CONTACTO = Me.txtEMAIL_CONTACTO.Text.ToLower.Trim
        mEntidad.CARGO_CONTACTO = Me.txtCARGO_CONTACTO.Text.ToUpper.Trim
        mEntidad.ESTADO = Me.txtESTADO.Text
        mEntidad.NOTAS = Me.txtNOTAS.Text
        mEntidad.USERID = Me.ObtenerUsuario()
        mEntidad.LASTUPDATE = Now

        If mComponente.ActualizarPROVEEDOR_AF(mEntidad) <> 1 Then
            Me.AsignarMensaje("ALERTA: " + mComponente.sError, True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_PROVEEDOR_AF.Text = mEntidad.ID_PROVEEDOR_AF.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub ddlDEPARTAMENTOCODIGO_DEPARTAMENTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedIndexChanged
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Recuperar(Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue)
    End Sub
End Class
