Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetallePARTICIPANTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PARTICIPANTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePARTICIPANTE
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_PARTICIPANTE As Decimal
    Public Property ID_PARTICIPANTE() As Decimal
        Get
            Return Me.txtID_PARTICIPANTE.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_PARTICIPANTE = Value
            Me.txtID_PARTICIPANTE.Text = CStr(Value)
            If Me._ID_PARTICIPANTE > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NOMBRES() As String
        Get
            Return Me.txtNOMBRES.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRES.Text = value.ToString()
        End Set
    End Property

    Public Property APELLIDOS() As String
        Get
            Return Me.txtAPELLIDOS.Text
        End Get
        Set(ByVal value As String)
            Me.txtAPELLIDOS.Text = value.ToString()
        End Set
    End Property

    Public Property GENERO() As String
        Get
            Return Me.txtGENERO.Text
        End Get
        Set(ByVal value As String)
            Me.txtGENERO.Text = value.ToString()
        End Set
    End Property

    Public Property ID_PAIS() As Decimal
        Get
            Return Me.ddlPAISID_PAIS.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlPAISID_PAIS.Items.FindByValue(value) Is Nothing Then
                Me.ddlPAISID_PAIS.SelectedValue = value
            End If
        End Set
    End Property

    Public Property FECHA_NACIMIENTO() As DateTime
        Get
            Return Me.deFECHA_NACIMIENTO.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_NACIMIENTO.Value = value
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

    Public Property DUI() As String
        Get
            Return Me.txtDUI.Text
        End Get
        Set(ByVal value As String)
            Me.txtDUI.Text = value.ToString()
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

    Public Property ISSS() As String
        Get
            Return Me.txtISSS.Text
        End Get
        Set(ByVal value As String)
            Me.txtISSS.Text = value.ToString()
        End Set
    End Property

    Public Property TIPO_DOCTO() As Decimal
        Get
            If Me.txtTIPO_DOCTO.Value Is Nothing Then Return -1
            Return Me.txtTIPO_DOCTO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtTIPO_DOCTO.Value = value
        End Set
    End Property

    Public Property NUM_DOCTO() As String
        Get
            Return Me.txtNUM_DOCTO.Text
        End Get
        Set(ByVal value As String)
            Me.txtNUM_DOCTO.Text = value.ToString()
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

    Public Property MOVIL() As String
        Get
            Return Me.txtMOVIL.Text
        End Get
        Set(ByVal value As String)
            Me.txtMOVIL.Text = value.ToString()
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

    Public Property ID_ESTADO_CIVIL() As Decimal
        Get
            Return Me.ddlESTADO_CIVILID_ESTADO_CIVIL.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlESTADO_CIVILID_ESTADO_CIVIL.Items.FindByValue(value) Is Nothing Then
                Me.ddlESTADO_CIVILID_ESTADO_CIVIL.SelectedValue = value
            End If
        End Set
    End Property

    Public Property PROFESION_OFICIO() As String
        Get
            Return Me.txtPROFESION_OFICIO.Text
        End Get
        Set(ByVal value As String)
            Me.txtPROFESION_OFICIO.Text = value.ToString()
        End Set
    End Property

    Public Property OCUPACION_ACTUAL() As String
        Get
            Return Me.txtOCUPACION_ACTUAL.Text
        End Get
        Set(ByVal value As String)
            Me.txtOCUPACION_ACTUAL.Text = value.ToString()
        End Set
    End Property

    Public Property TITULO_CERTIFICADO_OBTENIDO() As String
        Get
            Return Me.txtTITULO_CERTIFICADO_OBTENIDO.Text
        End Get
        Set(ByVal value As String)
            Me.txtTITULO_CERTIFICADO_OBTENIDO.Text = value.ToString()
        End Set
    End Property

    Public Property DEPARTAMENTO_NAC() As String
        Get
            Return Me.ddlDEPARTAMENTO_NACIMIENTO1.SelectedValue
        End Get
        Set(ByVal value As String)
            Me.ddlDEPARTAMENTO_NACIMIENTO1.SelectedValue = value
        End Set
    End Property

    Public Property MUNICIPIO_NAC() As String
        Get
            Return Me.ddlMUNICIPIO_NACIMIENTO1.SelectedValue
        End Get
        Set(ByVal value As String)
            Me.ddlMUNICIPIO_NACIMIENTO1.SelectedValue = value
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

    Public Property ID_NIVEL_ACADEMICO() As Decimal
        Get
            Return Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.SelectedValue
        End Get
        Set(ByVal value As Decimal)
            If Not Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.Items.FindByValue(value) Is Nothing Then
                Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.SelectedValue = value
            End If
        End Set
    End Property

    Public Property OTRA_EDUCACION_FORMAL() As String
        Get
            Return Me.txtOTRA_EDUCACION_FORMAL.Text
        End Get
        Set(ByVal value As String)
            Me.txtOTRA_EDUCACION_FORMAL.Text = value.ToString()
        End Set
    End Property

    Public Property CON_DISCAPACIDAD() As Decimal
        Get
            If Me.txtCON_DISCAPACIDAD.Value Is Nothing Then Return -1
            Return Me.txtCON_DISCAPACIDAD.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtCON_DISCAPACIDAD.Value = value
        End Set
    End Property

    Public Property DISC_OTRA() As String
        Get
            Return Me.txtDISC_OTRA.Text
        End Get
        Set(ByVal value As String)
            Me.txtDISC_OTRA.Text = value.ToString()
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

    Public Property USERID() As String
        Get
            Return Me.txtUSERID.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSERID.Text = value.ToString()
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

    Public Property VerNOMBRES() As Boolean
        Get
            Return Me.trNOMBRES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRES.Visible = value
        End Set
    End Property

    Public Property VerAPELLIDOS() As Boolean
        Get
            Return Me.trAPELLIDOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAPELLIDOS.Visible = value
        End Set
    End Property

    Public Property VerGENERO() As Boolean
        Get
            Return Me.trGENERO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trGENERO.Visible = value
        End Set
    End Property

    Public Property VerID_PAIS() As Boolean
        Get
            Return Me.trID_PAIS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PAIS.Visible = value
        End Set
    End Property

    Public Property VerFECHA_NACIMIENTO() As Boolean
        Get
            Return Me.trFECHA_NACIMIENTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_NACIMIENTO.Visible = value
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

    Public Property VerDUI() As Boolean
        Get
            Return Me.trDUI.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDUI.Visible = value
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

    Public Property VerISSS() As Boolean
        Get
            Return Me.trISSS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trISSS.Visible = value
        End Set
    End Property

    Public Property VerTIPO_DOCTO() As Boolean
        Get
            Return Me.trTIPO_DOCTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_DOCTO.Visible = value
        End Set
    End Property

    Public Property VerNUM_DOCTO() As Boolean
        Get
            Return Me.trNUM_DOCTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNUM_DOCTO.Visible = value
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

    Public Property VerMOVIL() As Boolean
        Get
            Return Me.trMOVIL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMOVIL.Visible = value
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

    Public Property VerID_ESTADO_CIVIL() As Boolean
        Get
            Return Me.trID_ESTADO_CIVIL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ESTADO_CIVIL.Visible = value
        End Set
    End Property

    Public Property VerPROFESION_OFICIO() As Boolean
        Get
            Return Me.trPROFESION_OFICIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPROFESION_OFICIO.Visible = value
        End Set
    End Property

    Public Property VerOCUPACION_ACTUAL() As Boolean
        Get
            Return Me.trOCUPACION_ACTUAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOCUPACION_ACTUAL.Visible = value
        End Set
    End Property

    Public Property VerTITULO_CERTIFICADO_OBTENIDO() As Boolean
        Get
            Return Me.trTITULO_CERTIFICADO_OBTENIDO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTITULO_CERTIFICADO_OBTENIDO.Visible = value
        End Set
    End Property

    Public Property VerDEPARTAMENTO_NAC() As Boolean
        Get
            Return Me.trDEPARTAMENTO_NAC.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDEPARTAMENTO_NAC.Visible = value
        End Set
    End Property

    Public Property VerMUNICIPIO_NAC() As Boolean
        Get
            Return Me.trMUNICIPIO_NAC.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMUNICIPIO_NAC.Visible = value
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

    Public Property VerCODIGO_MUNICIPIO() As Boolean
        Get
            Return Me.trCODIGO_MUNICIPIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_MUNICIPIO.Visible = value
        End Set
    End Property

    Public Property VerID_NIVEL_ACADEMICO() As Boolean
        Get
            Return Me.trID_NIVEL_ACADEMICO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_NIVEL_ACADEMICO.Visible = value
        End Set
    End Property

    Public Property VerOTRA_EDUCACION_FORMAL() As Boolean
        Get
            Return Me.trOTRA_EDUCACION_FORMAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOTRA_EDUCACION_FORMAL.Visible = value
        End Set
    End Property

    Public Property VerCON_DISCAPACIDAD() As Boolean
        Get
            Return Me.trCON_DISCAPACIDAD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCON_DISCAPACIDAD.Visible = value
        End Set
    End Property

    Public Property VerDISC_OTRA() As Boolean
        Get
            Return Me.trDISC_OTRA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDISC_OTRA.Visible = value
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

    Public Property VerUSERID() As Boolean
        Get
            Return Me.trUSERID.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSERID.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cPARTICIPANTE
    Private mEntidad As PARTICIPANTE
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
        If Not Me.ViewState("ID_PARTICIPANTE") Is Nothing Then Me._ID_PARTICIPANTE = Me.ViewState("ID_PARTICIPANTE")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla PARTICIPANTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PARTICIPANTE
        mEntidad.ID_PARTICIPANTE = ID_PARTICIPANTE
 
        If mComponente.ObtenerPARTICIPANTE(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_PARTICIPANTE.Text = mEntidad.ID_PARTICIPANTE.ToString()
        Me.txtNOMBRES.Text = mEntidad.NOMBRES
        Me.txtAPELLIDOS.Text = mEntidad.APELLIDOS
        Me.txtGENERO.Text = mEntidad.GENERO
        Me.ddlPAISID_PAIS.Recuperar()
        Me.ddlPAISID_PAIS.SelectedValue = mEntidad.ID_PAIS
        Me.deFECHA_NACIMIENTO.Value = mEntidad.FECHA_NACIMIENTO
        Me.txtDIRECCION.Text = mEntidad.DIRECCION
        Me.txtDUI.Text = mEntidad.DUI
        Me.txtNIT.Text = mEntidad.NIT
        Me.txtISSS.Text = mEntidad.ISSS
        Me.txtTIPO_DOCTO.Value = mEntidad.TIPO_DOCTO
        Me.txtNUM_DOCTO.Text = mEntidad.NUM_DOCTO
        Me.txtTELEFONO.Text = mEntidad.TELEFONO
        Me.txtMOVIL.Text = mEntidad.MOVIL
        Me.txtEMAIL.Text = mEntidad.EMAIL
        Me.ddlESTADO_CIVILID_ESTADO_CIVIL.Recuperar()
        Me.ddlESTADO_CIVILID_ESTADO_CIVIL.SelectedValue = mEntidad.ID_ESTADO_CIVIL
        Me.txtPROFESION_OFICIO.Text = mEntidad.PROFESION_OFICIO
        Me.txtOCUPACION_ACTUAL.Text = mEntidad.OCUPACION_ACTUAL
        Me.txtTITULO_CERTIFICADO_OBTENIDO.Text = mEntidad.TITULO_CERTIFICADO_OBTENIDO
        Me.ddlDEPARTAMENTO_NACIMIENTO1.Recuperar()
        If mEntidad.DEPARTAMENTO_NAC <> "" Then
            Me.ddlDEPARTAMENTO_NACIMIENTO1.SelectedValue = mEntidad.DEPARTAMENTO_NAC
            Me.ddlMUNICIPIO_NACIMIENTO1.Recuperar(Me.ddlDEPARTAMENTO_NACIMIENTO1.SelectedValue)
        Else
            Me.ddlDEPARTAMENTO_NACIMIENTO1.SelectedIndex = -1
            Me.ddlMUNICIPIO_NACIMIENTO1.SelectedIndex = -1
        End If
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Recuperar()
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue = mEntidad.CODIGO_DEPARTAMENTO
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Recuperar(Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue)
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.SelectedValue = mEntidad.CODIGO_MUNICIPIO
        Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.Recuperar()
        If Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.Items.FindByValue(mEntidad.ID_NIVEL_ACADEMICO.ToString) IsNot Nothing Then
            Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.SelectedValue = mEntidad.ID_NIVEL_ACADEMICO
        End If
        Me.txtOTRA_EDUCACION_FORMAL.Text = mEntidad.OTRA_EDUCACION_FORMAL
        Me.txtCON_DISCAPACIDAD.Value = mEntidad.CON_DISCAPACIDAD
        Me.txtDISC_OTRA.Text = mEntidad.DISC_OTRA
        Me.deLASTUPDATE.Value = mEntidad.LASTUPDATE
        Me.txtUSERID.Text = mEntidad.USERID
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlPAISID_PAIS.Enabled = False
        Me.ddlESTADO_CIVILID_ESTADO_CIVIL.Enabled = False
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Enabled = False
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Enabled = False
        Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.Enabled = False
        Me.txtNOMBRES.Enabled = edicion
        Me.txtAPELLIDOS.Enabled = edicion
        Me.txtGENERO.Enabled = False
        Me.deFECHA_NACIMIENTO.Enabled = False
        Me.txtDIRECCION.Enabled = False
        Me.txtDUI.Enabled = edicion
        Me.txtNIT.Enabled = edicion
        Me.txtISSS.Enabled = False
        Me.txtTIPO_DOCTO.Enabled = False
        Me.txtNUM_DOCTO.Enabled = False
        Me.txtTELEFONO.Enabled = False
        Me.txtMOVIL.Enabled = False
        Me.txtEMAIL.Enabled = False
        Me.txtPROFESION_OFICIO.Enabled = False
        Me.txtOCUPACION_ACTUAL.Enabled = False
        Me.txtTITULO_CERTIFICADO_OBTENIDO.Enabled = False
        Me.ddlDEPARTAMENTO_NACIMIENTO1.Enabled = False
        Me.ddlMUNICIPIO_NACIMIENTO1.Enabled = False
        Me.txtOTRA_EDUCACION_FORMAL.Enabled = False
        Me.txtCON_DISCAPACIDAD.Enabled = False
        Me.txtDISC_OTRA.Enabled = False
        Me.deLASTUPDATE.Enabled = False
        Me.txtUSERID.Enabled = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlPAISID_PAIS.Recuperar()
        Me.ddlESTADO_CIVILID_ESTADO_CIVIL.Recuperar()
        Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.Recuperar()
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Recuperar(Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue)
        Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.Recuperar()
        Me.txtNOMBRES.Text = ""
        Me.txtAPELLIDOS.Text = ""
        Me.txtGENERO.Text = ""
        Me.deFECHA_NACIMIENTO.Value = Nothing
        Me.txtDIRECCION.Text = ""
        Me.txtDUI.Text = ""
        Me.txtNIT.Text = ""
        Me.txtISSS.Text = ""
        Me.txtTIPO_DOCTO.Value = Nothing
        Me.txtNUM_DOCTO.Text = ""
        Me.txtTELEFONO.Text = ""
        Me.txtMOVIL.Text = ""
        Me.txtEMAIL.Text = ""
        Me.txtPROFESION_OFICIO.Text = ""
        Me.txtOCUPACION_ACTUAL.Text = ""
        Me.txtTITULO_CERTIFICADO_OBTENIDO.Text = ""
        Me.ddlDEPARTAMENTO_NACIMIENTO1.Recuperar()
        Me.ddlMUNICIPIO_NACIMIENTO1.Recuperar(Me.ddlDEPARTAMENTO_NACIMIENTO1.SelectedValue)
        Me.txtOTRA_EDUCACION_FORMAL.Text = ""
        Me.txtCON_DISCAPACIDAD.Value = Nothing
        Me.txtDISC_OTRA.Text = ""
        Me.deLASTUPDATE.Value = Now
        Me.txtUSERID.Text = Me.ObtenerUsuario()
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla PARTICIPANTE
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New PARTICIPANTE
        If Me._nuevo Then
            mEntidad.ID_PARTICIPANTE = 0
        Else
            mEntidad = (New cPARTICIPANTE).ObtenerPARTICIPANTE(CInt(Me.txtID_PARTICIPANTE.Text))
        End If

        If Me.txtNOMBRES.Text.Trim = "" Or Me.txtAPELLIDOS.Text.Trim = "" Then
            Me.AsignarMensaje("* Nombres y Apellidos son requeridos.", True, True)
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
        If Me.txtNIT.Text.Length > 0 AndAlso Not Utilerias.EsNIT(Me.txtNIT.Text.Trim) Then
            Me.AsignarMensaje("* NIT no valido.", True, True)
            Return "Error al Guardar registro."
        End If

        mEntidad.NOMBRES = Me.txtNOMBRES.Text.ToUpper.Trim
        mEntidad.APELLIDOS = Me.txtAPELLIDOS.Text.ToUpper.Trim
        'mEntidad.GENERO = Me.txtGENERO.Text
        'mEntidad.ID_PAIS = Me.ddlPAISID_PAIS.SelectedValue
        'mEntidad.FECHA_NACIMIENTO = Me.deFECHA_NACIMIENTO.Value
        'mEntidad.DIRECCION = Me.txtDIRECCION.Text
        mEntidad.DUI = Me.txtDUI.Text
        mEntidad.NIT = Me.txtNIT.Text
        'mEntidad.ISSS = Me.txtISSS.Text
        'mEntidad.TIPO_DOCTO = Me.txtTIPO_DOCTO.Value
        'mEntidad.NUM_DOCTO = Me.txtNUM_DOCTO.Text
        'mEntidad.TELEFONO = Me.txtTELEFONO.Text
        'mEntidad.MOVIL = Me.txtMOVIL.Text
        'mEntidad.EMAIL = Me.txtEMAIL.Text
        'mEntidad.ID_ESTADO_CIVIL = Me.ddlESTADO_CIVILID_ESTADO_CIVIL.SelectedValue
        'mEntidad.PROFESION_OFICIO = Me.txtPROFESION_OFICIO.Text
        'mEntidad.OCUPACION_ACTUAL = Me.txtOCUPACION_ACTUAL.Text
        'mEntidad.TITULO_CERTIFICADO_OBTENIDO = Me.txtTITULO_CERTIFICADO_OBTENIDO.Text
        'mEntidad.DEPARTAMENTO_NAC = Me.ddlDEPARTAMENTO_NACIMIENTO1.SelectedValue
        'mEntidad.MUNICIPIO_NAC = Me.ddlMUNICIPIO_NACIMIENTO1.SelectedValue
        'mEntidad.CODIGO_DEPARTAMENTO = Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue
        'mEntidad.CODIGO_MUNICIPIO = Me.ddlMUNICIPIOCODIGO_MUNICIPIO.SelectedValue
        'mEntidad.ID_NIVEL_ACADEMICO = Me.ddlNIVEL_ACADEMICOID_NIVEL_ACADEMICO.SelectedValue
        'mEntidad.OTRA_EDUCACION_FORMAL = Me.txtOTRA_EDUCACION_FORMAL.Text
        'mEntidad.CON_DISCAPACIDAD = Me.txtCON_DISCAPACIDAD.Value
        'mEntidad.DISC_OTRA = Me.txtDISC_OTRA.Text
        mEntidad.LASTUPDATE = Me.deLASTUPDATE.Value
        mEntidad.USERID = Me.ObtenerUsuario()

        If mComponente.ActualizarPARTICIPANTE(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro." + mComponente.sError, True, True)
            Return "Error al Guardar registro."
        End If

        'Actualizar las solicitudes a las que hace referencia el id_participante
        Dim lSolicitudes As listaSOLICITUD_INSCRIPCION_AF = (New cSOLICITUD_INSCRIPCION_AF).ObtenerListaPorPARTICIPANTE(mEntidad.ID_PARTICIPANTE)
        Dim bSolicitudes As New cSOLICITUD_INSCRIPCION_AF

        If lSolicitudes IsNot Nothing AndAlso lSolicitudes.Count > 0 Then
            For i As Int32 = 0 To lSolicitudes.Count - 1
                Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lSolicitudes(i).ID_ACCION_FORMATIVA)
                If lAccionFormativa IsNot Nothing Then
                    lSolicitudes(i).NOMBRES = mEntidad.NOMBRES
                    lSolicitudes(i).APELLIDOS = mEntidad.APELLIDOS
                End If
                If mEntidad.DUI <> "" Then lSolicitudes(i).DUI = mEntidad.DUI
                If mEntidad.NIT <> "" Then lSolicitudes(i).NIT = mEntidad.NIT
                If mEntidad.DUI <> "" OrElse mEntidad.NIT <> "" Then
                    bSolicitudes.ActualizarSOLICITUD_INSCRIPCION_AF(lSolicitudes(i))
                End If
            Next
        End If

        Me.txtID_PARTICIPANTE.Text = mEntidad.ID_PARTICIPANTE.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub ddlDEPARTAMENTO_NACIMIENTO1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDEPARTAMENTO_NACIMIENTO1.SelectedIndexChanged
        Me.ddlMUNICIPIO_NACIMIENTO1.Recuperar(Me.ddlDEPARTAMENTO_NACIMIENTO1.SelectedValue)
    End Sub

    Protected Sub ddlDEPARTAMENTOCODIGO_DEPARTAMENTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedIndexChanged
        Me.ddlMUNICIPIOCODIGO_MUNICIPIO.Recuperar(Me.ddlDEPARTAMENTOCODIGO_DEPARTAMENTO.SelectedValue)
    End Sub
End Class
