Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleEMPRESAS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla EMPRESAS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleEMPRESAS
    Inherits ucBase
 
#Region"Propiedades"

    Private _NUMERO_PATRONAL As String
    Public Property NUMERO_PATRONAL() As String
        Get
            Return Me.txtNUMERO_PATRONAL.Text
        End Get
        Set(ByVal Value As String)
            Me._NUMERO_PATRONAL = Value
            Me.txtNUMERO_PATRONAL.Text = Value
            If Me._NUMERO_PATRONAL <> "" Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
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

    Public Property VerNIT_EMPRESA() As Boolean
        Get
            Return Me.trNIT_EMPRESA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNIT_EMPRESA.Visible = value
        End Set
    End Property

    Public Property VerCIUU() As Boolean
        Get
            Return Me.trCIUU.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCIUU.Visible = value
        End Set
    End Property

    Public Property VerSECTOR_PRODUCTIVO() As Boolean
        Get
            Return Me.trSECTOR_PRODUCTIVO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSECTOR_PRODUCTIVO.Visible = value
        End Set
    End Property

    Public Property VerCODIGO_ASESOR() As Boolean
        Get
            Return Me.trCODIGO_ASESOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_ASESOR.Visible = value
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

    Public Property VerCODIGO_REGION() As Boolean
        Get
            Return Me.trCODIGO_REGION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_REGION.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_EMPRESA() As Boolean
        Get
            Return Me.trNOMBRE_EMPRESA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_EMPRESA.Visible = value
        End Set
    End Property

    Public Property VerTIPO_EMPRESA() As Boolean
        Get
            Return Me.trTIPO_EMPRESA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_EMPRESA.Visible = value
        End Set
    End Property

    Public Property VerCONTACTO_EMPRESA() As Boolean
        Get
            Return Me.trCONTACTO_EMPRESA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCONTACTO_EMPRESA.Visible = value
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

    Public Property VerCARGO_CONTACTO() As Boolean
        Get
            Return Me.trCARGO_CONTACTO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCARGO_CONTACTO.Visible = value
        End Set
    End Property

    Public Property VerDIRECCION_EMPRESA() As Boolean
        Get
            Return Me.trDIRECCION_EMPRESA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trDIRECCION_EMPRESA.Visible = value
        End Set
    End Property

    Public Property VerTELEFONO_EMPRESA() As Boolean
        Get
            Return Me.trTELEFONO_EMPRESA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTELEFONO_EMPRESA.Visible = value
        End Set
    End Property

    Public Property VerFAX_EMPRESA() As Boolean
        Get
            Return Me.trFAX_EMPRESA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFAX_EMPRESA.Visible = value
        End Set
    End Property

    Public Property VerEMAIL_EMPRESA() As Boolean
        Get
            Return Me.trEMAIL_EMPRESA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEMAIL_EMPRESA.Visible = value
        End Set
    End Property

    Public Property VerESPECIALIDAD_EMPRESA() As Boolean
        Get
            Return Me.trESPECIALIDAD_EMPRESA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trESPECIALIDAD_EMPRESA.Visible = value
        End Set
    End Property

    Public Property VerTOTAL_PERSONA() As Boolean
        Get
            Return Me.trTOTAL_PERSONA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTOTAL_PERSONA.Visible = value
        End Set
    End Property

    Public Property VerTOTAL_PLANILLA() As Boolean
        Get
            Return Me.trTOTAL_PLANILLA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTOTAL_PLANILLA.Visible = value
        End Set
    End Property

    Public Property VerREPRESENTANTE_LEGAL() As Boolean
        Get
            Return Me.trREPRESENTANTE_LEGAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trREPRESENTANTE_LEGAL.Visible = value
        End Set
    End Property

    Public Property VerFECHA_REGISTRO() As Boolean
        Get
            Return Me.trFECHA_REGISTRO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_REGISTRO.Visible = value
        End Set
    End Property

    Public Property VerTOTAL_TRABAJADORES() As Boolean
        Get
            Return Me.trTOTAL_TRABAJADORES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTOTAL_TRABAJADORES.Visible = value
        End Set
    End Property

    Public Property VerFEMENINOS() As Boolean
        Get
            Return Me.trFEMENINOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFEMENINOS.Visible = value
        End Set
    End Property

    Public Property VerMASCULINOS() As Boolean
        Get
            Return Me.trMASCULINOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMASCULINOS.Visible = value
        End Set
    End Property

    Public Property VerTAMANO_EMPRESA() As Boolean
        Get
            Return Me.trTAMANO_EMPRESA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTAMANO_EMPRESA.Visible = value
        End Set
    End Property

    Public Property VerCON_MANDO() As Boolean
        Get
            Return Me.trCON_MANDO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCON_MANDO.Visible = value
        End Set
    End Property

    Public Property VerSIN_MANDO() As Boolean
        Get
            Return Me.trSIN_MANDO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSIN_MANDO.Visible = value
        End Set
    End Property

    Public Property VerADMINISTRATIVOS() As Boolean
        Get
            Return Me.trADMINISTRATIVOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trADMINISTRATIVOS.Visible = value
        End Set
    End Property

    Public Property VerMANDOS_MEDIOS() As Boolean
        Get
            Return Me.trMANDOS_MEDIOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trMANDOS_MEDIOS.Visible = value
        End Set
    End Property

    Public Property VerOPERATIVOS() As Boolean
        Get
            Return Me.trOPERATIVOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOPERATIVOS.Visible = value
        End Set
    End Property

    Public Property VerGERENCIAL() As Boolean
        Get
            Return Me.trGERENCIAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trGERENCIAL.Visible = value
        End Set
    End Property

    Public Property VerSIGLAS() As Boolean
        Get
            Return Me.trSIGLAS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trSIGLAS.Visible = value
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

    Public Property VerOBSERVACION() As Boolean
        Get
            Return Me.trOBSERVACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trOBSERVACION.Visible = value
        End Set
    End Property

    Public Property VerNUM_PAT_ISSS() As Boolean
        Get
            Return Me.trNUM_PAT_ISSS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNUM_PAT_ISSS.Visible = value
        End Set
    End Property

    Public Property VerTIPOPERSON() As Boolean
        Get
            Return Me.trTIPOPERSON.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPOPERSON.Visible = value
        End Set
    End Property

    Public Property VerNUM() As Boolean
        Get
            Return Me.trNUM.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNUM.Visible = value
        End Set
    End Property

    Public Property VerREPRESENTANTE_PROFESION() As Boolean
        Get
            Return Me.trREPRESENTANTE_PROFESION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trREPRESENTANTE_PROFESION.Visible = value
        End Set
    End Property

    Public Property VerCONTACTO_EMAIL() As Boolean
        Get
            Return Me.trCONTACTO_EMAIL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCONTACTO_EMAIL.Visible = value
        End Set
    End Property

    Public Property VerAPORTE_INSAFORP() As Boolean
        Get
            Return Me.trAPORTE_INSAFORP.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAPORTE_INSAFORP.Visible = value
        End Set
    End Property

    Public Property VerZONA() As Boolean
        Get
            Return Me.trZONA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trZONA.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cEMPRESAS
    Private mEntidad As EMPRESAS
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
        If Not Me.ViewState("NUMERO_PATRONAL") Is Nothing Then Me._NUMERO_PATRONAL = Me.ViewState("NUMERO_PATRONAL")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla EMPRESAS
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
        mEntidad = New EMPRESAS
        mEntidad.NUMERO_PATRONAL = NUMERO_PATRONAL
 
        If mComponente.ObtenerEMPRESAS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtNUMERO_PATRONAL.Text = mEntidad.NUMERO_PATRONAL
        Me.txtNIT_EMPRESA.Text = mEntidad.NIT_EMPRESA
        Me.txtCIUU.Text = mEntidad.CIUU
        Me.txtSECTOR_PRODUCTIVO.Text = mEntidad.SECTOR_PRODUCTIVO
        Me.txtCODIGO_ASESOR.Text = mEntidad.CODIGO_ASESOR
        Me.txtCODIGO_MUNICIPIO.Text = mEntidad.CODIGO_MUNICIPIO
        Me.txtCODIGO_DEPARTAMENTO.Text = mEntidad.CODIGO_DEPARTAMENTO
        Me.txtCODIGO_REGION.Text = mEntidad.CODIGO_REGION
        Me.txtNOMBRE_EMPRESA.Text = mEntidad.NOMBRE_EMPRESA
        Me.txtTIPO_EMPRESA.Text = mEntidad.TIPO_EMPRESA
        Me.txtCONTACTO_EMPRESA.Text = mEntidad.CONTACTO_EMPRESA
        Me.txtTELEFONO_CONTACTO.Text = mEntidad.TELEFONO_CONTACTO
        Me.txtCARGO_CONTACTO.Text = mEntidad.CARGO_CONTACTO
        Me.txtDIRECCION_EMPRESA.Text = mEntidad.DIRECCION_EMPRESA
        Me.txtTELEFONO_EMPRESA.Text = mEntidad.TELEFONO_EMPRESA
        Me.txtFAX_EMPRESA.Text = mEntidad.FAX_EMPRESA
        Me.txtEMAIL_EMPRESA.Text = mEntidad.EMAIL_EMPRESA
        Me.txtESPECIALIDAD_EMPRESA.Text = mEntidad.ESPECIALIDAD_EMPRESA
        Me.txtTOTAL_PERSONA.Text = mEntidad.TOTAL_PERSONA
        Me.txtTOTAL_PLANILLA.Text = mEntidad.TOTAL_PLANILLA
        Me.txtREPRESENTANTE_LEGAL.Text = mEntidad.REPRESENTANTE_LEGAL
        Me.txtFECHA_REGISTRO.Text = IIf(Not mEntidad.FECHA_REGISTRO = Nothing, Format(mEntidad.FECHA_REGISTRO, "dd/MM/yyyy"), "")
        Me.txtTOTAL_TRABAJADORES.Text = mEntidad.TOTAL_TRABAJADORES
        Me.txtFEMENINOS.Text = mEntidad.FEMENINOS
        Me.txtMASCULINOS.Text = mEntidad.MASCULINOS
        Me.txtTAMANO_EMPRESA.Text = mEntidad.TAMANO_EMPRESA
        Me.txtCON_MANDO.Text = mEntidad.CON_MANDO
        Me.txtSIN_MANDO.Text = mEntidad.SIN_MANDO
        Me.txtADMINISTRATIVOS.Text = mEntidad.ADMINISTRATIVOS
        Me.txtMANDOS_MEDIOS.Text = mEntidad.MANDOS_MEDIOS
        Me.txtOPERATIVOS.Text = mEntidad.OPERATIVOS
        Me.txtGERENCIAL.Text = mEntidad.GERENCIAL
        Me.txtSIGLAS.Text = mEntidad.SIGLAS
        Me.txtUSERID.Text = mEntidad.USERID
        Me.txtLASTUPDATE.Text = IIf(Not mEntidad.LASTUPDATE = Nothing, Format(mEntidad.LASTUPDATE, "dd/MM/yyyy"), "")
        Me.txtOBSERVACION.Text = mEntidad.OBSERVACION
        Me.txtNUM_PAT_ISSS.Text = mEntidad.NUM_PAT_ISSS
        Me.txtTIPOPERSON.Text = mEntidad.TIPOPERSON
        Me.txtNUM.Text = mEntidad.NUM
        Me.txtREPRESENTANTE_PROFESION.Text = mEntidad.REPRESENTANTE_PROFESION
        Me.txtCONTACTO_EMAIL.Text = mEntidad.CONTACTO_EMAIL
        Me.txtAPORTE_INSAFORP.Text = mEntidad.APORTE_INSAFORP
        Me.txtZONA.Text = mEntidad.ZONA
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
        Me.txtNIT_EMPRESA.Enabled = edicion
        Me.txtCIUU.Enabled = edicion
        Me.txtSECTOR_PRODUCTIVO.Enabled = edicion
        Me.txtCODIGO_ASESOR.Enabled = edicion
        Me.txtCODIGO_MUNICIPIO.Enabled = edicion
        Me.txtCODIGO_DEPARTAMENTO.Enabled = edicion
        Me.txtCODIGO_REGION.Enabled = edicion
        Me.txtNOMBRE_EMPRESA.Enabled = edicion
        Me.txtTIPO_EMPRESA.Enabled = edicion
        Me.txtCONTACTO_EMPRESA.Enabled = edicion
        Me.txtTELEFONO_CONTACTO.Enabled = edicion
        Me.txtCARGO_CONTACTO.Enabled = edicion
        Me.txtDIRECCION_EMPRESA.Enabled = edicion
        Me.txtTELEFONO_EMPRESA.Enabled = edicion
        Me.txtFAX_EMPRESA.Enabled = edicion
        Me.txtEMAIL_EMPRESA.Enabled = edicion
        Me.txtESPECIALIDAD_EMPRESA.Enabled = edicion
        Me.txtTOTAL_PERSONA.Enabled = edicion
        Me.txtTOTAL_PLANILLA.Enabled = edicion
        Me.txtREPRESENTANTE_LEGAL.Enabled = edicion
        Me.txtFECHA_REGISTRO.Enabled = edicion
        Me.txtTOTAL_TRABAJADORES.Enabled = edicion
        Me.txtFEMENINOS.Enabled = edicion
        Me.txtMASCULINOS.Enabled = edicion
        Me.txtTAMANO_EMPRESA.Enabled = edicion
        Me.txtCON_MANDO.Enabled = edicion
        Me.txtSIN_MANDO.Enabled = edicion
        Me.txtADMINISTRATIVOS.Enabled = edicion
        Me.txtMANDOS_MEDIOS.Enabled = edicion
        Me.txtOPERATIVOS.Enabled = edicion
        Me.txtGERENCIAL.Enabled = edicion
        Me.txtSIGLAS.Enabled = edicion
        Me.txtUSERID.Enabled = False
        Me.txtLASTUPDATE.Enabled = False
        Me.txtOBSERVACION.Enabled = edicion
        Me.txtNUM_PAT_ISSS.Enabled = edicion
        Me.txtTIPOPERSON.Enabled = edicion
        Me.txtNUM.Enabled = edicion
        Me.txtREPRESENTANTE_PROFESION.Enabled = edicion
        Me.txtCONTACTO_EMAIL.Enabled = edicion
        Me.txtAPORTE_INSAFORP.Enabled = edicion
        Me.txtZONA.Enabled = edicion
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
        Me.txtNIT_EMPRESA.Text = ""
        Me.txtCIUU.Text = ""
        Me.txtSECTOR_PRODUCTIVO.Text = ""
        Me.txtCODIGO_ASESOR.Text = ""
        Me.txtCODIGO_MUNICIPIO.Text = ""
        Me.txtCODIGO_DEPARTAMENTO.Text = ""
        Me.txtCODIGO_REGION.Text = ""
        Me.txtNOMBRE_EMPRESA.Text = ""
        Me.txtTIPO_EMPRESA.Text = ""
        Me.txtCONTACTO_EMPRESA.Text = ""
        Me.txtTELEFONO_CONTACTO.Text = ""
        Me.txtCARGO_CONTACTO.Text = ""
        Me.txtDIRECCION_EMPRESA.Text = ""
        Me.txtTELEFONO_EMPRESA.Text = ""
        Me.txtFAX_EMPRESA.Text = ""
        Me.txtEMAIL_EMPRESA.Text = ""
        Me.txtESPECIALIDAD_EMPRESA.Text = ""
        Me.txtTOTAL_PERSONA.Text = ""
        Me.txtTOTAL_PLANILLA.Text = ""
        Me.txtREPRESENTANTE_LEGAL.Text = ""
        Me.txtFECHA_REGISTRO.Text = ""
        Me.txtTOTAL_TRABAJADORES.Text = ""
        Me.txtFEMENINOS.Text = ""
        Me.txtMASCULINOS.Text = ""
        Me.txtTAMANO_EMPRESA.Text = ""
        Me.txtCON_MANDO.Text = ""
        Me.txtSIN_MANDO.Text = ""
        Me.txtADMINISTRATIVOS.Text = ""
        Me.txtMANDOS_MEDIOS.Text = ""
        Me.txtOPERATIVOS.Text = ""
        Me.txtGERENCIAL.Text = ""
        Me.txtSIGLAS.Text = ""
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.txtLASTUPDATE.Text = Now.ToString("dd/MM/yyyy")
        Me.txtOBSERVACION.Text = ""
        Me.txtNUM_PAT_ISSS.Text = ""
        Me.txtTIPOPERSON.Text = ""
        Me.txtNUM.Text = ""
        Me.txtREPRESENTANTE_PROFESION.Text = ""
        Me.txtCONTACTO_EMAIL.Text = ""
        Me.txtAPORTE_INSAFORP.Text = ""
        Me.txtZONA.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla EMPRESAS
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
        mEntidad = New EMPRESAS
        If Me.txtNUMERO_PATRONAL.Text = "0" Then
            Me.AsignarMensaje("Asigne un valor al Numero patronal que sea valido", True, True)
            Return "Error"
        End If
            mEntidad.NUMERO_PATRONAL = Me.txtNUMERO_PATRONAL.Text
        mEntidad.NIT_EMPRESA = Me.txtNIT_EMPRESA.Text
        mEntidad.CIUU = Me.txtCIUU.Text
        mEntidad.SECTOR_PRODUCTIVO = Me.txtSECTOR_PRODUCTIVO.Text
        mEntidad.CODIGO_ASESOR = Me.txtCODIGO_ASESOR.Text
        mEntidad.CODIGO_MUNICIPIO = Me.txtCODIGO_MUNICIPIO.Text
        mEntidad.CODIGO_DEPARTAMENTO = Me.txtCODIGO_DEPARTAMENTO.Text
        mEntidad.CODIGO_REGION = Me.txtCODIGO_REGION.Text
        mEntidad.NOMBRE_EMPRESA = Me.txtNOMBRE_EMPRESA.Text
        mEntidad.TIPO_EMPRESA = Me.txtTIPO_EMPRESA.Text
        mEntidad.CONTACTO_EMPRESA = Me.txtCONTACTO_EMPRESA.Text
        mEntidad.TELEFONO_CONTACTO = Me.txtTELEFONO_CONTACTO.Text
        mEntidad.CARGO_CONTACTO = Me.txtCARGO_CONTACTO.Text
        mEntidad.DIRECCION_EMPRESA = Me.txtDIRECCION_EMPRESA.Text
        mEntidad.TELEFONO_EMPRESA = Me.txtTELEFONO_EMPRESA.Text
        mEntidad.FAX_EMPRESA = Me.txtFAX_EMPRESA.Text
        mEntidad.EMAIL_EMPRESA = Me.txtEMAIL_EMPRESA.Text
        mEntidad.ESPECIALIDAD_EMPRESA = Me.txtESPECIALIDAD_EMPRESA.Text
        mEntidad.TOTAL_PERSONA = Val(Me.txtTOTAL_PERSONA.Text)
        mEntidad.TOTAL_PLANILLA = Val(Me.txtTOTAL_PLANILLA.Text)
        mEntidad.REPRESENTANTE_LEGAL = Me.txtREPRESENTANTE_LEGAL.Text
        If Me.txtFECHA_REGISTRO.Text <> "" Then mEntidad.FECHA_REGISTRO = System.DateTime.Parse(Me.txtFECHA_REGISTRO.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.TOTAL_TRABAJADORES = Val(Me.txtTOTAL_TRABAJADORES.Text)
        mEntidad.FEMENINOS = Val(Me.txtFEMENINOS.Text)
        mEntidad.MASCULINOS = Val(Me.txtMASCULINOS.Text)
        mEntidad.TAMANO_EMPRESA = Me.txtTAMANO_EMPRESA.Text
        mEntidad.CON_MANDO = Val(Me.txtCON_MANDO.Text)
        mEntidad.SIN_MANDO = Val(Me.txtSIN_MANDO.Text)
        mEntidad.ADMINISTRATIVOS = Val(Me.txtADMINISTRATIVOS.Text)
        mEntidad.MANDOS_MEDIOS = Val(Me.txtMANDOS_MEDIOS.Text)
        mEntidad.OPERATIVOS = Val(Me.txtOPERATIVOS.Text)
        mEntidad.GERENCIAL = Val(Me.txtGERENCIAL.Text)
        mEntidad.SIGLAS = Me.txtSIGLAS.Text
        mEntidad.USERID = Me.ObtenerUsuario()
        If Me.txtLASTUPDATE.Text <> "" Then mEntidad.LASTUPDATE = System.DateTime.Parse(Me.txtLASTUPDATE.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.OBSERVACION = Me.txtOBSERVACION.Text
        mEntidad.NUM_PAT_ISSS = Me.txtNUM_PAT_ISSS.Text
        mEntidad.TIPOPERSON = Me.txtTIPOPERSON.Text
        mEntidad.NUM = Val(Me.txtNUM.Text)
        mEntidad.REPRESENTANTE_PROFESION = Me.txtREPRESENTANTE_PROFESION.Text
        mEntidad.CONTACTO_EMAIL = Me.txtCONTACTO_EMAIL.Text
        mEntidad.APORTE_INSAFORP = Val(Me.txtAPORTE_INSAFORP.Text)
        mEntidad.ZONA = Val(Me.txtZONA.Text)

        If Me._nuevo Then
            If mComponente.AgregarEMPRESAS(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
         Else
            If mComponente.ActualizarEMPRESAS(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If
        Me.txtNUMERO_PATRONAL.Text = mEntidad.NUMERO_PATRONAL.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
