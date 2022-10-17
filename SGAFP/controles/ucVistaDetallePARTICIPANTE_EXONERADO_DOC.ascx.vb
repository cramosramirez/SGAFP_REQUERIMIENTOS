Imports SGAFP.BL
Imports SGAFP.EL
Imports DevExpress.Web.ASPxEditors

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetallePARTICIPANTE_EXONERADO_DOC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PARTICIPANTE_EXONERADO_DOC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/11/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePARTICIPANTE_EXONERADO_DOC
    Inherits ucBase
    Public Event Modificando(ByVal sender As Object, ByVal e As System.EventArgs)

#Region "Propiedades"

    Public Property ID_PARTICIPANTE_EXONERADO() As Decimal
        Get
            If Me.ViewState("ID_PARTICIPANTE_EXONERADO") Is Nothing Then Return 0 Else Return Me.ViewState("ID_PARTICIPANTE_EXONERADO")
        End Get
        Set(ByVal Value As Decimal)
            Me.ViewState("ID_PARTICIPANTE_EXONERADO") = Value
            If Value > 0 Then
                Me.CargarDatos()
            Else
                Me.Nuevo()
            End If
        End Set
    End Property

    Private _ID_PARTICIPANTE As Decimal
    Public Property ID_PARTICIPANTE() As Decimal
        Get
            Return Me._ID_PARTICIPANTE
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_PARTICIPANTE = Value
        End Set
    End Property

    Public Property GENERO() As String
        Get
            Return Me.cbxGENERO.Value
        End Get
        Set(ByVal value As String)
            Me.cbxGENERO.Value = value
        End Set
    End Property

    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return Me.cbxDEPARTAMENTO_RESIDENCIA.Value
        End Get
        Set(ByVal value As String)
            Me.cbxDEPARTAMENTO_RESIDENCIA.Value = value
        End Set
    End Property

    Public Property CODIGO_MUNICIPIO() As String
        Get
            Return Me.cbxMUNICIPIO_RESIDENCIA.Value
        End Get
        Set(ByVal value As String)
            Me.cbxMUNICIPIO_RESIDENCIA.Value = value
        End Set
    End Property

    Public Property DEPARTAMENTO_NAC() As String
        Get
            Return Me.cbxDEPARTAMENTO_NACIMIENTO.Value
        End Get
        Set(ByVal value As String)
            Me.cbxDEPARTAMENTO_NACIMIENTO.Value = value
        End Set
    End Property

    Public Property CON_DISCAPACIDAD() As String
        Get
            Return Me.rblDiscapacidad.Value
        End Get
        Set(ByVal value As String)
            Me.rblDiscapacidad.Value = value
        End Set
    End Property

    Public Property ID_NIVEL_ACADEMICO() As String
        Get
            Return Me.cbxNIVEL_ACADEMICO.Value
        End Get
        Set(ByVal value As String)
            Me.cbxNIVEL_ACADEMICO.Value = value
        End Set
    End Property

    Public Property ID_PAIS() As String
        Get
            Return Me.cbxPAIS.Value
        End Get
        Set(ByVal value As String)
            Me.cbxPAIS.Value = value
        End Set
    End Property

    Public Property ID_ESTADO_CIVIL() As String
        Get
            Return Me.cbxESTADO_CIVIL.Value
        End Get
        Set(ByVal value As String)
            Me.cbxESTADO_CIVIL.Value = value
        End Set
    End Property

    Public Property MUNICIPIO_NAC() As String
        Get
            Return Me.cbxMUNICIPIO_NACIMIENTO.Value
        End Get
        Set(ByVal value As String)
            Me.cbxMUNICIPIO_RESIDENCIA.Value = value
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

    Public Property ID_PROVEEDOR_AF() As Decimal
        Get
            Return Me.cbxPROVEEDOR_AF.Value
        End Get
        Set(ByVal value As Decimal)
            If Not Me.cbxPROVEEDOR_AF.Items.FindByValue(value) Is Nothing Then
                Me.cbxPROVEEDOR_AF.Value = CInt(value)
            End If
        End Set
    End Property

    Public Property ID_SITIO_CAPACITACION() As Decimal
        Get
            Return Me.cbxSITIO_CAPACITACION.Value
        End Get
        Set(ByVal value As Decimal)
            If Not Me.cbxSITIO_CAPACITACION.Items.FindByValue(value) Is Nothing Then
                Me.cbxSITIO_CAPACITACION.Value = CInt(value)
            End If
        End Set
    End Property

    Public Property NOMBRES() As String
        Get
            Return Utilerias.ReemplazarAcentos(Me.txtNOMBRES.Text.Trim.ToUpper)
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRES.Text = Utilerias.ReemplazarAcentos(value.Trim.ToUpper)
        End Set
    End Property

    Public Property APELLIDOS() As String
        Get
            Return Utilerias.ReemplazarAcentos(Me.txtAPELLIDOS.Text.Trim.ToUpper)
        End Get
        Set(ByVal value As String)
            Me.txtAPELLIDOS.Text = Utilerias.ReemplazarAcentos(value.Trim.ToUpper)
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

    Public Property FECHA_INGRESO() As DateTime
        Get
            Return Me.deFECHA_INGRESO.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_INGRESO.Value = value
        End Set
    End Property

    Public Property USUARIO_EVALUA() As String
        Get
            Return Me.txtUSUARIO_EVALUA.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSUARIO_EVALUA.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_EVALUA() As DateTime
        Get
            Return Me.deFECHA_EVALUA.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_EVALUA.Value = value
        End Set
    End Property

    Public Property ESTADO() As Decimal
        Get
            If Me.cbxEvaluacion.Value Is Nothing Then Return 0
            Return Me.cbxEvaluacion.Value
        End Get
        Set(ByVal value As Decimal)
            Me.cbxEvaluacion.Value = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cPARTICIPANTE_EXONERADO_DOC
    Private mEntidad As PARTICIPANTE_EXONERADO_DOC
    Public Event ErrorEvent(ByVal errorMessage As String)

    Public ReadOnly Property sError() As String
        Get
            Return _sError
        End Get
    End Property

    Public Property VerID_PARTICIPANTE_EXONERADO() As Boolean
        Get
            Return trID_PARTICIPANTE_EXONERADO.Visible
        End Get
        Set(ByVal value As Boolean)
            trID_PARTICIPANTE_EXONERADO.Visible = value
        End Set
    End Property
    Public Property VerID_PARTICIPANTE() As Boolean
        Get
            Return trID_PARTICIPANTE.Visible
        End Get
        Set(ByVal value As Boolean)
            trID_PARTICIPANTE.Visible = value
        End Set
    End Property
    Public Property VerUSERID() As Boolean
        Get
            Return trUSERID.Visible
        End Get
        Set(ByVal value As Boolean)
            trUSERID.Visible = value
        End Set
    End Property
    Public Property VerLASTUPDATE() As Boolean
        Get
            Return trLASTUPDATE.Visible
        End Get
        Set(ByVal value As Boolean)
            trLASTUPDATE.Visible = value
        End Set
    End Property
    Public Property VerFECHA_INGRESO() As Boolean
        Get
            Return trFECHA_INGRESO.Visible
        End Get
        Set(ByVal value As Boolean)
            trFECHA_INGRESO.Visible = value
        End Set
    End Property
    Public Property VerUSUARIO_EVALUA() As Boolean
        Get
            Return trUSUARIO_EVALUA.Visible
        End Get
        Set(ByVal value As Boolean)
            trUSUARIO_EVALUA.Visible = value
        End Set
    End Property
    Public Property VerFECHA_EVALUA() As Boolean
        Get
            Return trFECHA_EVALUA.Visible
        End Get
        Set(ByVal value As Boolean)
            trFECHA_EVALUA.Visible = value
        End Set
    End Property
#End Region

    Private Sub CargarMunicipios(ByVal odsMunicipio As ObjectDataSource, ByVal cmbMunicipio As ASPxComboBox, ByVal CODIGO_DEPARTAMENTO As String)
        odsMunicipio.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = CODIGO_DEPARTAMENTO
        cmbMunicipio.DataBind()
    End Sub

    Private Sub CargarCentrosFormacion(ByVal ID_PROVEEDOR_AF As Decimal)
        odsSITIO_CAPACITACION.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF
        cbxSITIO_CAPACITACION.DataBind()
    End Sub

    Private Sub CargarProveedores()
        cbxPROVEEDOR_AF.DataBind()
    End Sub

    Private Sub CargarDepartamentos()
        cbxDEPARTAMENTO_RESIDENCIA.DataBind()
    End Sub

    Private Sub CargarPaises()
        Me.cbxPAIS.DataBind()
    End Sub

    Private Sub CargarNivelAcademico()
        cbxNIVEL_ACADEMICO.DataBind()
    End Sub

    Private Sub CargarEstadoCivil()
        cbxNIVEL_ACADEMICO.DataBind()
    End Sub

    Private Sub OcultarCamposEnCliente()
        lblIdParticipanteExonerado.ClientVisible = False
        txtID_PARTICIPANTE_EXONERADO.ClientVisible = False
        lblID_PARTICIPANTE.ClientVisible = False
        txtID_PARTICIPANTE.ClientVisible = False
        lblUSERID.ClientVisible = False
        txtUSERID.ClientVisible = False
        lblLASTUPDATE.ClientVisible = False
        deLASTUPDATE.ClientVisible = False

        lblFECHA_INGRESO.ClientVisible = False
        deFECHA_INGRESO.ClientVisible = False
        lblUSUARIO_EVALUA.ClientVisible = False
        txtUSUARIO_EVALUA.ClientVisible = False
        lblFECHA_EVALUA.ClientVisible = False
        deFECHA_EVALUA.ClientVisible = False
        lblEvaluacion.ClientVisible = False
        cbxEvaluacion.ClientVisible = False
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Page.IsCallback Then
            CargarPaises()
            CargarDepartamentos()
            CargarNivelAcademico()
            CargarEstadoCivil()
            CargarProveedores()
            Habilitar()
        End If
        OcultarCamposEnCliente()
    End Sub

    Public Sub Habilitar(Optional ByVal valor As Boolean = True)
        cbxPROVEEDOR_AF.ClientEnabled = False
        cbxSITIO_CAPACITACION.ClientEnabled = False
        txtNOMBRES.ClientEnabled = valor
        txtAPELLIDOS.ClientEnabled = valor
        deFECHA_NACIMIENTO.ClientEnabled = valor
        cbxGENERO.ClientEnabled = valor
        rblNacionalidad.ClientEnabled = valor
        cbxPAIS.ClientEnabled = (rblNacionalidad.Value = 2 AndAlso valor)
        cbxDEPARTAMENTO_NACIMIENTO.ClientEnabled = (rblNacionalidad.Value = 1 AndAlso valor)
        cbxMUNICIPIO_NACIMIENTO.ClientEnabled = (rblNacionalidad.Value = 1 AndAlso valor)
        cbxDEPARTAMENTO_RESIDENCIA.ClientEnabled = valor
        cbxMUNICIPIO_RESIDENCIA.ClientEnabled = valor
        txtDIRECCION.ClientEnabled = valor
        txtTELEFONO.ClientEnabled = valor
        txtMOVIL.ClientEnabled = valor
        txtEMAIL.ClientEnabled = valor
        cbxESTADO_CIVIL.ClientEnabled = valor
        cbxNIVEL_ACADEMICO.ClientEnabled = valor
        rblDiscapacidad.ClientEnabled = valor
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla PARTICIPANTE_EXONERADO_DOC
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PARTICIPANTE_EXONERADO_DOC
        mEntidad.ID_PARTICIPANTE_EXONERADO = ID_PARTICIPANTE_EXONERADO

        If mComponente.ObtenerPARTICIPANTE_EXONERADO_DOC(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.CargarPaises()
        Me.CargarDepartamentos()
        Me.CargarProveedores()
        Me.cbxPROVEEDOR_AF.Value = CInt(mEntidad.ID_PROVEEDOR_AF)
        Me.cbxPROVEEDOR_AF.ClientEnabled = False
        Me.CargarCentrosFormacion(mEntidad.ID_PROVEEDOR_AF)
        Me.cbxSITIO_CAPACITACION.Value = CInt(mEntidad.ID_SITIO_CAPACITACION)
        Me.cbxSITIO_CAPACITACION.ClientEnabled = False
        Me.txtNOMBRES.Text = mEntidad.NOMBRES
        Me.txtAPELLIDOS.Text = mEntidad.APELLIDOS
        Me.deFECHA_NACIMIENTO.Value = mEntidad.FECHA_NACIMIENTO
        Me.cbxGENERO.Value = mEntidad.GENERO
        If mEntidad.ID_PAIS = 57 Then
            Me.rblNacionalidad.Value = 1
            Me.cbxDEPARTAMENTO_NACIMIENTO.Value = mEntidad.DEPARTAMENTO_NAC
            CargarMunicipios(Me.odsMunicipioNacimiento, Me.cbxMUNICIPIO_NACIMIENTO, mEntidad.DEPARTAMENTO_NAC)
            Me.cbxMUNICIPIO_NACIMIENTO.Value = mEntidad.MUNICIPIO_NAC
            Me.cbxDEPARTAMENTO_NACIMIENTO.ClientEnabled = True
            Me.cbxMUNICIPIO_NACIMIENTO.ClientEnabled = True
        Else
            Me.rblNacionalidad.Value = 2
            Me.cbxDEPARTAMENTO_NACIMIENTO.ClientEnabled = False
            Me.cbxMUNICIPIO_NACIMIENTO.ClientEnabled = False
        End If
        Me.cbxPAIS.Value = CInt(mEntidad.ID_PAIS)
        Me.cbxDEPARTAMENTO_RESIDENCIA.Value = mEntidad.CODIGO_DEPARTAMENTO
        CargarMunicipios(Me.odsMunicipioResidencia, Me.cbxMUNICIPIO_RESIDENCIA, mEntidad.CODIGO_DEPARTAMENTO)
        Me.cbxMUNICIPIO_RESIDENCIA.Value = mEntidad.CODIGO_MUNICIPIO
        Me.txtDIRECCION.Text = mEntidad.DIRECCION
        Me.txtTELEFONO.Text = mEntidad.TELEFONO
        Me.txtMOVIL.Text = mEntidad.MOVIL
        Me.txtEMAIL.Text = mEntidad.EMAIL
        Me.CargarEstadoCivil()
        Me.cbxESTADO_CIVIL.Value = CInt(mEntidad.ID_ESTADO_CIVIL)
        Me.CargarNivelAcademico()
        Me.cbxNIVEL_ACADEMICO.Value = CInt(mEntidad.ID_NIVEL_ACADEMICO)
        Me.rblDiscapacidad.Value = CInt(mEntidad.CON_DISCAPACIDAD)

        Me.txtID_PARTICIPANTE_EXONERADO.Text = mEntidad.ID_PARTICIPANTE_EXONERADO
        Me.txtID_PARTICIPANTE.Text = mEntidad.ID_PARTICIPANTE
        Me.txtUSERID.Text = mEntidad.USERID
        Me.deLASTUPDATE.Value = mEntidad.LASTUPDATE
        Me.deFECHA_INGRESO.Value = mEntidad.FECHA_INGRESO
        Me.txtUSUARIO_EVALUA.Text = mEntidad.USUARIO_EVALUA
        Me.deFECHA_EVALUA.Value = mEntidad.FECHA_EVALUA
        Me.cbxEvaluacion.Value = CInt(mEntidad.ESTADO)

        Me.txtNOMBRES.ClientEnabled = False
        Me.txtAPELLIDOS.ClientEnabled = False
        Me.deFECHA_NACIMIENTO.ClientEnabled = False

        If (Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP) OrElse Me.EstaEnRol(RolDeUsuario.JefeHTP) OrElse Me.EstaEnRol(RolDeUsuario.Administrador)) AndAlso _
            mEntidad.ESTADO = 0 Then
            Me.Habilitar(False)
            Me.lblEvaluacion.ClientVisible = True
            Me.cbxEvaluacion.ClientVisible = True
            Me.cbxEvaluacion.ClientEnabled = True
        End If
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Nuevo()
        Me.cbxPROVEEDOR_AF.ClientEnabled = True
        Me.cbxSITIO_CAPACITACION.ClientEnabled = True
        If Me.ObtenerIdProveedorAF > 0 Then
            Me.CargarProveedores()
            Me.cbxPROVEEDOR_AF.Value = CInt(Me.ObtenerIdProveedorAF)
            Me.cbxPROVEEDOR_AF.ClientEnabled = False
            If Me.ObtenerIdSitioCapacitacion > 0 Then
                Me.CargarCentrosFormacion(Me.ObtenerIdProveedorAF)
                Me.cbxSITIO_CAPACITACION.Value = CInt(Me.ObtenerIdSitioCapacitacion)
                Me.cbxSITIO_CAPACITACION.ClientEnabled = False
            Else
                Me.cbxSITIO_CAPACITACION.SelectedIndex = -1
            End If
        End If
        txtNOMBRES.Text = ""
        txtAPELLIDOS.Text = ""
        deFECHA_NACIMIENTO.Text = ""
        cbxGENERO.SelectedIndex = -1
        ASPxEdit.ClearEditorsInContainer(rblNacionalidad)
        cbxPAIS.SelectedIndex = -1
        cbxDEPARTAMENTO_NACIMIENTO.SelectedIndex = -1
        cbxMUNICIPIO_NACIMIENTO.SelectedIndex = -1
        cbxDEPARTAMENTO_RESIDENCIA.SelectedIndex = -1
        cbxMUNICIPIO_RESIDENCIA.SelectedIndex = -1
        txtDIRECCION.Text = ""
        txtTELEFONO.Text = ""
        txtMOVIL.Text = ""
        txtEMAIL.Text = ""
        cbxESTADO_CIVIL.SelectedIndex = -1
        cbxNIVEL_ACADEMICO.SelectedIndex = -1
        ASPxEdit.ClearEditorsInContainer(rblDiscapacidad)

        txtID_PARTICIPANTE_EXONERADO.Text = ""
        txtID_PARTICIPANTE.Text = ""
        txtUSERID.Text = ""
        deLASTUPDATE.Text = ""
        deFECHA_INGRESO.Text = ""
        txtUSUARIO_EVALUA.Text = ""
        deFECHA_EVALUA.Text = ""
        cbxEvaluacion.SelectedIndex = -1
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla PARTICIPANTE_EXONERADO_DOC
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList

        If String.IsNullOrEmpty(txtNOMBRES.Value) Then
            sError = "Nombres son requeridos"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If String.IsNullOrEmpty(txtAPELLIDOS.Value) Then
            sError = "Apellidos son requeridos"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If String.IsNullOrEmpty(deFECHA_NACIMIENTO.Date) OrElse deFECHA_NACIMIENTO.Date = #12:00:00 AM# Then
            sError = "Fecha de Nacimiento es requerida"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If Utilerias.CalcularEdad(deFECHA_NACIMIENTO.Date, Now) >= 18 Then
            sError = "El Participante debe ser menor de 18 años"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If String.IsNullOrEmpty(cbxGENERO.Value) Then
            sError = "Genero es requerido"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If rblNacionalidad.Value Is Nothing Then
            sError = "Nacionalidad requerida"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If cbxPAIS.Value Is Nothing Then
            sError = "País es requerido"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If rblNacionalidad.Value = 1 AndAlso String.IsNullOrEmpty(cbxDEPARTAMENTO_NACIMIENTO.Value) Then
            sError = "Departamento de Nacimiento es requerido"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If rblNacionalidad.Value = 1 AndAlso String.IsNullOrEmpty(cbxMUNICIPIO_NACIMIENTO.Value) Then
            sError = "Municipio de Nacimiento es requerido"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If String.IsNullOrEmpty(cbxDEPARTAMENTO_RESIDENCIA.Value) Then
            sError = "Departamento de Residencia es requerido"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If String.IsNullOrEmpty(cbxMUNICIPIO_RESIDENCIA.Value) Then
            sError = "Municipio de Residencia es requerido"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If String.IsNullOrEmpty(txtDIRECCION.Value) Then
            sError = "Dirección es requerido"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If String.IsNullOrEmpty(txtTELEFONO.Value) AndAlso String.IsNullOrEmpty(txtMOVIL.Value) Then
            sError = "Teléfono Fijo o Móvil es requerido"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If Not String.IsNullOrEmpty(txtTELEFONO.Text) AndAlso txtTELEFONO.Text.Length <> 8 Then
            sError = "Teléfono Fijo no válido"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If Not String.IsNullOrEmpty(txtMOVIL.Text) AndAlso txtMOVIL.Text.Length <> 8 Then
            sError = "Teléfono Móvil no válido"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If cbxESTADO_CIVIL.Value Is Nothing Then
            sError = "Estado civil es requerido"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If cbxNIVEL_ACADEMICO.Value Is Nothing Then
            sError = "Nivel Académico es requerido"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If
        If rblDiscapacidad.Value Is Nothing Then
            sError = "Con discapacidad es requerido"
            Me.AsignarMensaje(sError, True, True)
            Return sError
        End If

        If String.IsNullOrEmpty(Me.txtID_PARTICIPANTE_EXONERADO.Text) Then
            mEntidad = New PARTICIPANTE_EXONERADO_DOC
        Else
            mEntidad = (New cPARTICIPANTE_EXONERADO_DOC).ObtenerPARTICIPANTE_EXONERADO_DOC(CDec(Me.txtID_PARTICIPANTE_EXONERADO.Text))
        End If

        mEntidad.USERID = Me.ObtenerUsuario()
        mEntidad.LASTUPDATE = Me.deLASTUPDATE.Value
        mEntidad.ID_PROVEEDOR_AF = Me.cbxPROVEEDOR_AF.Value
        mEntidad.ID_SITIO_CAPACITACION = Me.cbxSITIO_CAPACITACION.Value
        mEntidad.NOMBRES = Me.txtNOMBRES.Text
        mEntidad.APELLIDOS = Me.txtAPELLIDOS.Text
        mEntidad.FECHA_NACIMIENTO = Me.deFECHA_NACIMIENTO.Value
        mEntidad.GENERO = Me.cbxGENERO.Value
        mEntidad.CODIGO_DEPARTAMENTO = Me.cbxDEPARTAMENTO_RESIDENCIA.Value
        mEntidad.CODIGO_MUNICIPIO = Me.cbxMUNICIPIO_RESIDENCIA.Value
        mEntidad.DEPARTAMENTO_NAC = Me.cbxDEPARTAMENTO_NACIMIENTO.Value
        mEntidad.MUNICIPIO_NAC = Me.cbxMUNICIPIO_NACIMIENTO.Value
        mEntidad.DIRECCION = Me.txtDIRECCION.Text
        mEntidad.TELEFONO = Me.txtTELEFONO.Value
        mEntidad.MOVIL = Me.txtMOVIL.Value
        mEntidad.CON_DISCAPACIDAD = Me.rblDiscapacidad.Value
        mEntidad.EMAIL = Me.txtEMAIL.Text
        mEntidad.ID_NIVEL_ACADEMICO = Me.cbxNIVEL_ACADEMICO.Value
        mEntidad.ID_PAIS = Me.cbxPAIS.Value
        mEntidad.ID_ESTADO_CIVIL = Me.cbxESTADO_CIVIL.Value
        If String.IsNullOrEmpty(txtID_PARTICIPANTE.Text) OrElse CDec(txtID_PARTICIPANTE.Text) = 0 Then mEntidad.ID_PARTICIPANTE = -1 Else mEntidad.ID_PARTICIPANTE = CDec(txtID_PARTICIPANTE.Text)
        If mEntidad.ID_PARTICIPANTE_EXONERADO = 0 Then
            'Nuevo participante
            mEntidad.FECHA_INGRESO = Now
        Else
            mEntidad.FECHA_INGRESO = deFECHA_INGRESO.Date
            If cbxEvaluacion.Value IsNot Nothing AndAlso cbxEvaluacion.Value > 0 Then
                If mEntidad.ESTADO <> cbxEvaluacion.Value Then
                    mEntidad.ESTADO = cbxEvaluacion.Value
                    mEntidad.USUARIO_EVALUA = Me.ObtenerUsuario
                    mEntidad.FECHA_EVALUA = Now
                End If
            End If
        End If
        If mComponente.ActualizarPARTICIPANTE_EXONERADO_DOC(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub cbxSITIO_CAPACITACION_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cbxSITIO_CAPACITACION.Callback
        CargarCentrosFormacion(e.Parameter)
    End Sub

    Protected Sub cbxMUNICIPIO_NACIMIENTO_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cbxMUNICIPIO_NACIMIENTO.Callback
        CargarMunicipios(Me.odsMunicipioNacimiento, sender, e.Parameter)
    End Sub

    Protected Sub cbxMUNICIPIO_RESIDENCIA_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cbxMUNICIPIO_RESIDENCIA.Callback
        CargarMunicipios(Me.odsMunicipioResidencia, sender, e.Parameter)
    End Sub

    Protected Sub txtNOMBRES_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNOMBRES.PreRender

    End Sub

    Protected Sub ModificandoDatos(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNOMBRES.ValueChanged, txtAPELLIDOS.ValueChanged, deFECHA_NACIMIENTO.ValueChanged
        RaiseEvent Modificando(sender, e)
    End Sub
End Class
