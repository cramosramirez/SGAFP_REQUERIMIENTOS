Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleFACILITADOR_CAPACITADOR
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla FACILITADOR_CAPACITADOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/03/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleFACILITADOR_CAPACITADOR
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_FACILITADOR As Decimal
    Public Property ID_FACILITADOR() As Decimal
        Get
            Return Me.txtID_FACILITADOR.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_FACILITADOR = Value
            Me.txtID_FACILITADOR.Text = CStr(Value)
            If Me._ID_FACILITADOR > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
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

    Public Property ID_PROVEEDOR_AF() As Decimal
        Get
            Return Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.Items.FindByValue(value) Is Nothing Then
                Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.SelectedValue = value
            End If
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

    Public Property NOMBRE_FACILITADOR() As String
        Get
            Return Me.txtNOMBRE_FACILITADOR.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_FACILITADOR.Text = value.ToString()
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

    Public Property TELEFONO() As String
        Get
            Return Me.txtTELEFONO.Text
        End Get
        Set(ByVal value As String)
            Me.txtTELEFONO.Text = value.ToString()
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

    Public Property DIRECCION() As String
        Get
            Return Me.txtDIRECCION.Text
        End Get
        Set(ByVal value As String)
            Me.txtDIRECCION.Text = value.ToString()
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

    Public Property VerID_FACILITADOR() As Boolean
        Get
            Return Me.trID_FACILITADOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_FACILITADOR.Visible = value
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

    Public Property VerNOMBRE_FACILITADOR() As Boolean
        Get
            Return Me.trNOMBRE_FACILITADOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_FACILITADOR.Visible = value
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

    Public Property VerTELEFONO() As Boolean
        Get
            Return Me.trTELEFONO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTELEFONO.Visible = value
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

    Public Property VerDIRECCION() As Boolean
        Get
            Return Me.trDIRECCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDIRECCION.Visible = value
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
    Private mComponente As New cFACILITADOR_CAPACITADOR
    Private mEntidad As FACILITADOR_CAPACITADOR
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
        If Not Me.ViewState("ID_FACILITADOR") Is Nothing Then Me._ID_FACILITADOR = Me.ViewState("ID_FACILITADOR")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla FACILITADOR_CAPACITADOR
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
        mEntidad = New FACILITADOR_CAPACITADOR
        mEntidad.ID_FACILITADOR = ID_FACILITADOR
 
        If mComponente.ObtenerFACILITADOR_CAPACITADOR(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_FACILITADOR.Text = mEntidad.ID_FACILITADOR.ToString()
        Me.ddlTIPO_PERSONAID_TIPO_PERSONA.Recuperar()
        Me.ddlTIPO_PERSONAID_TIPO_PERSONA.SelectedValue = mEntidad.ID_TIPO_PERSONA
        Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.Recuperar()
        Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.SelectedValue = mEntidad.ID_PROVEEDOR_AF
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Recuperar(Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue)
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.SelectedValue = mEntidad.CODIGO_MUNICIPIO
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Recuperar()
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue = mEntidad.CODIGO_DEPARTAMENTO
        Me.txtNOMBRE_FACILITADOR.Text = mEntidad.NOMBRE_FACILITADOR
        Me.txtNIT.Text = mEntidad.NIT
        Me.txtDUI.Text = mEntidad.DUI
        Me.txtISSS.Text = mEntidad.ISSS
        Me.deFECHA_INGRESO.Value = mEntidad.FECHA_INGRESO
        Me.txtTELEFONO.Text = mEntidad.TELEFONO
        Me.txtEMAIL.Text = mEntidad.EMAIL
        Me.txtDIRECCION.Text = mEntidad.DIRECCION
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
        Me.ddlTIPO_PERSONAID_TIPO_PERSONA.Enabled = edicion
        Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.Enabled = edicion
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Enabled = edicion
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Enabled = edicion
        Me.txtNOMBRE_FACILITADOR.Enabled = edicion
        Me.txtNIT.Enabled = edicion
        Me.txtDUI.Enabled = edicion
        Me.txtISSS.Enabled = edicion
        Me.deFECHA_INGRESO.Enabled = edicion
        Me.txtTELEFONO.Enabled = edicion
        Me.txtEMAIL.Enabled = edicion
        Me.txtDIRECCION.Enabled = edicion
        Me.txtNOTAS.Enabled = edicion
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
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlTIPO_PERSONAID_TIPO_PERSONA.Recuperar()
        Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.Recuperar()
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Recuperar(Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue)
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Recuperar()
        Me.txtNOMBRE_FACILITADOR.Text = ""
        Me.txtNIT.Text = ""
        Me.txtDUI.Text = ""
        Me.txtISSS.Text = ""
        Me.deFECHA_INGRESO.Value = Nothing
        Me.txtTELEFONO.Text = ""
        Me.txtEMAIL.Text = ""
        Me.txtDIRECCION.Text = ""
        Me.txtNOTAS.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.deLASTUPDATE.Value = Now
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla FACILITADOR_CAPACITADOR
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
        mEntidad = New FACILITADOR_CAPACITADOR
        If Me._nuevo Then
            mEntidad.ID_FACILITADOR = 0
        Else
            mEntidad.ID_FACILITADOR = CInt(Me.txtID_FACILITADOR.Text)
        End If
        mEntidad.ID_TIPO_PERSONA = Me.ddlTIPO_PERSONAID_TIPO_PERSONA.SelectedValue
        mEntidad.ID_PROVEEDOR_AF = Me.ddlPROVEEDOR_AFID_PROVEEDOR_AF.SelectedValue
        mEntidad.CODIGO_MUNICIPIO = Me.ddlMUNICIPIOCODIGO_MUNICIPIO.SelectedValue
        mEntidad.CODIGO_DEPARTAMENTO = Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue
        mEntidad.NOMBRE_FACILITADOR = Me.txtNOMBRE_FACILITADOR.Text
        mEntidad.NIT = Me.txtNIT.Text
        mEntidad.DUI = Me.txtDUI.Text
        mEntidad.ISSS = Me.txtISSS.Text
        mEntidad.FECHA_INGRESO = Me.deFECHA_INGRESO.Value
        mEntidad.TELEFONO = Me.txtTELEFONO.Text
        mEntidad.EMAIL = Me.txtEMAIL.Text
        mEntidad.DIRECCION = Me.txtDIRECCION.Text
        mEntidad.NOTAS = Me.txtNOTAS.Text
        mEntidad.USERID = Me.ObtenerUsuario()
        mEntidad.LASTUPDATE = Me.deLASTUPDATE.Value

        If mComponente.ActualizarFACILITADOR_CAPACITADOR(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_FACILITADOR.Text = mEntidad.ID_FACILITADOR.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
