Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleSITIO_CAPACITACION
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SITIO_CAPACITACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/02/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSITIO_CAPACITACION
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_SITIO_CAPACITACION As Decimal
    Public Property ID_SITIO_CAPACITACION() As Decimal
        Get
            Return Me.txtID_SITIO_CAPACITACION.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_SITIO_CAPACITACION = Value
            Me.txtID_SITIO_CAPACITACION.Text = CStr(Value)
            If Me._ID_SITIO_CAPACITACION > 0 Then
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
            Return Me.cbxMUNICIPIO.Value
        End Get
        Set(ByVal value As String)
            If Not Me.cbxMUNICIPIO.Items.FindByValue(value) Is Nothing Then
                Me.cbxMUNICIPIO.Items.FindByValue(value).Selected = True
            End If
        End Set
    End Property

    Public Property CODIGO_DEPARTAMENTO() As String
        Get
            Return Me.cbxDEPARTAMENTO.Value
        End Get
        Set(ByVal value As String)
            If Not Me.cbxDEPARTAMENTO.Items.FindByValue(value) Is Nothing Then
                Me.cbxDEPARTAMENTO.Items.FindByValue(value).Selected = True
            End If
        End Set
    End Property

    Public Property ID_PROVEEDOR_AF() As Decimal
        Get
            Return CDec(Me.cbxPROVEEDOR_AF.Value)
        End Get
        Set(ByVal value As Decimal)
            If Not Me.cbxPROVEEDOR_AF.Items.FindByValue(value) Is Nothing Then
                Me.cbxPROVEEDOR_AF.Items.FindByValue(value).Selected = True
            End If
        End Set
    End Property

    Public Property NOMBRE_SITIO() As String
        Get
            Return Me.cbxSITIO_CAPACITACION.Value
        End Get
        Set(ByVal value As String)
            If Not Me.cbxSITIO_CAPACITACION.Items.FindByValue(value) Is Nothing Then
                Me.cbxSITIO_CAPACITACION.Items.FindByValue(value).Selected = True
            End If
        End Set
    End Property

    Public Property FORMATO_CODIGO_CURSO() As String
        Get
            Return Me.txtFORMATO_CODIGO_CURSO.Text
        End Get
        Set(ByVal value As String)
            Me.txtFORMATO_CODIGO_CURSO.Text = value.ToString()
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

    Public Property FAX() As String
        Get
            Return Me.txtFAX.Text
        End Get
        Set(ByVal value As String)
            Me.txtFAX.Text = value.ToString()
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

    Public Property NUMERO_AULAS() As Decimal
        Get
            If Me.txtNUMERO_AULAS.Value Is Nothing Then Return -1
            Return Me.txtNUMERO_AULAS.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtNUMERO_AULAS.Value = value
        End Set
    End Property

    Public Property FECHA_REGISTRO() As DateTime
        Get
            Return Me.deFECHA_REGISTRO.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_REGISTRO.Value = value
        End Set
    End Property

    Public Property ENCARGADO() As String
        Get
            Return Me.txtENCARGADO.Text
        End Get
        Set(ByVal value As String)
            Me.txtENCARGADO.Text = value.ToString()
        End Set
    End Property

    Public Property TELEFONO_ENCARGADO() As String
        Get
            Return Me.txtTELEFONO_ENCARGADO.Text
        End Get
        Set(ByVal value As String)
            Me.txtTELEFONO_ENCARGADO.Text = value.ToString()
        End Set
    End Property

    Public Property EMAIL_ENCARGADO() As String
        Get
            Return Me.txtEMAIL_ENCARGADO.Text
        End Get
        Set(ByVal value As String)
            Me.txtEMAIL_ENCARGADO.Text = value.ToString()
        End Set
    End Property

    Public Property CARGO_ENCARGADO() As String
        Get
            Return Me.txtCARGO_ENCARGADO.Text
        End Get
        Set(ByVal value As String)
            Me.txtCARGO_ENCARGADO.Text = value.ToString()
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

    Public Property LATITUD() As Decimal
        Get
            If Me.txtLATITUD.Value Is Nothing Then Return -1
            Return Me.txtLATITUD.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtLATITUD.Value = value
        End Set
    End Property

    Public Property LONGITUD() As Decimal
        Get
            If Me.txtLONGITUD.Value Is Nothing Then Return -1
            Return Me.txtLONGITUD.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtLONGITUD.Value = value
        End Set
    End Property

    Public Property VerID_SITIO_CAPACITACION() As Boolean
        Get
            Return Me.trID_SITIO_CAPACITACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_SITIO_CAPACITACION.Visible = value
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

    Public Property VerID_PROVEEDOR_AF() As Boolean
        Get
            Return Me.lblID_PROVEEDOR_AF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblID_PROVEEDOR_AF.ClientVisible = value
            Me.cbxPROVEEDOR_AF.ClientVisible = value
        End Set
    End Property

    Public Property VerNOMBRE_SITIO() As Boolean
        Get
            Return Me.lblID_SITIO_CAPACITACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.lblID_SITIO_CAPACITACION.Visible = value
            Me.cbxSITIO_CAPACITACION.Visible = value
        End Set
    End Property

    Public Property VerFORMATO_CODIGO_CURSO() As Boolean
        Get
            Return Me.trFORMATO_CODIGO_CURSO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFORMATO_CODIGO_CURSO.Visible = value
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

    Public Property VerEMAIL() As Boolean
        Get
            Return Me.trEMAIL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEMAIL.Visible = value
        End Set
    End Property

    Public Property VerNUMERO_AULAS() As Boolean
        Get
            Return Me.trNUMERO_AULAS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNUMERO_AULAS.Visible = value
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

    Public Property VerENCARGADO() As Boolean
        Get
            Return Me.trENCARGADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trENCARGADO.Visible = value
        End Set
    End Property

    Public Property VerTELEFONO_ENCARGADO() As Boolean
        Get
            Return Me.trTELEFONO_ENCARGADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTELEFONO_ENCARGADO.Visible = value
        End Set
    End Property

    Public Property VerEMAIL_ENCARGADO() As Boolean
        Get
            Return Me.trEMAIL_ENCARGADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEMAIL_ENCARGADO.Visible = value
        End Set
    End Property

    Public Property VerCARGO_ENCARGADO() As Boolean
        Get
            Return Me.trCARGO_ENCARGADO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCARGO_ENCARGADO.Visible = value
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

    Public Property VerLATITUD() As Boolean
        Get
            Return Me.trLATITUD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLATITUD.Visible = value
        End Set
    End Property

    Public Property VerLONGITUD() As Boolean
        Get
            Return Me.trLONGITUD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trLONGITUD.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cSITIO_CAPACITACION
    Private mEntidad As SITIO_CAPACITACION
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

#Region "Implementacion DevExpress"
    Private Sub CargarProveedores()
        Me.cbxPROVEEDOR_AF.DataBind()
    End Sub

    Private Sub CargarSitiosCapacitacion(ByVal ID_PROVEEDOR_AF As Decimal)
        Me.odsSitioCapacitacion.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF
        Me.cbxSITIO_CAPACITACION.DataBind()
    End Sub

    Private Sub CargarDepartamentos()
        Me.cbxDEPARTAMENTO.DataBind()
    End Sub

    Private Sub CargarMunicipios(ByVal CODIGO_DEPARTAMENTO As String)
        Me.odsMunicipio.SelectParameters("CODIGO_DEPARTAMENTO").DefaultValue = CODIGO_DEPARTAMENTO
        Me.cbxMUNICIPIO.DataBind()
    End Sub
    
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_SITIO_CAPACITACION") Is Nothing Then Me._ID_SITIO_CAPACITACION = Me.ViewState("ID_SITIO_CAPACITACION")
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla SITIO_CAPACITACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New SITIO_CAPACITACION
        mEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION

        If mComponente.ObtenerSITIO_CAPACITACION(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_SITIO_CAPACITACION.Text = mEntidad.ID_SITIO_CAPACITACION.ToString()
        Me.CargarProveedores()
        If cbxPROVEEDOR_AF.Items.FindByValue(mEntidad.ID_PROVEEDOR_AF.ToString) IsNot Nothing Then cbxPROVEEDOR_AF.Items.FindByValue(mEntidad.ID_PROVEEDOR_AF.ToString).Selected = True
        If Me.EstaEnRol(RolDeUsuario.Proveedor) Or Me.EstaEnRol(RolDeUsuario.CentroCapacitador) Then
            Me.VerID_PROVEEDOR_AF = False
        Else
            Me.cbxPROVEEDOR_AF.ClientEnabled = False
        End If
        Me.CargarSitiosCapacitacion(Me.cbxPROVEEDOR_AF.Value)
        If cbxSITIO_CAPACITACION.Items.FindByValue(mEntidad.ID_SITIO_CAPACITACION.ToString) IsNot Nothing Then cbxSITIO_CAPACITACION.Items.FindByValue(mEntidad.ID_SITIO_CAPACITACION.ToString).Selected = True
        Me.cbxSITIO_CAPACITACION.ClientEnabled = False
        Me.CargarDepartamentos()
        If cbxDEPARTAMENTO.Items.FindByValue(mEntidad.CODIGO_DEPARTAMENTO) IsNot Nothing Then cbxDEPARTAMENTO.Items.FindByValue(mEntidad.CODIGO_DEPARTAMENTO).Selected = True
        Me.CargarMunicipios(cbxDEPARTAMENTO.Value)
        If cbxMUNICIPIO.Items.FindByValue(mEntidad.CODIGO_MUNICIPIO) IsNot Nothing Then cbxMUNICIPIO.Items.FindByValue(mEntidad.CODIGO_MUNICIPIO).Selected = True
        Me.txtFORMATO_CODIGO_CURSO.Text = mEntidad.FORMATO_CODIGO_CURSO
        Me.txtDIRECCION.Text = mEntidad.DIRECCION
        Me.txtTELEFONO.Text = mEntidad.TELEFONO
        Me.txtFAX.Text = mEntidad.FAX
        Me.txtEMAIL.Text = mEntidad.EMAIL
        Me.txtNUMERO_AULAS.Value = mEntidad.NUMERO_AULAS
        Me.deFECHA_REGISTRO.Value = mEntidad.FECHA_REGISTRO
        Me.txtENCARGADO.Text = mEntidad.ENCARGADO
        Me.txtTELEFONO_ENCARGADO.Text = mEntidad.TELEFONO_ENCARGADO
        Me.txtEMAIL_ENCARGADO.Text = mEntidad.EMAIL_ENCARGADO
        Me.txtCARGO_ENCARGADO.Text = mEntidad.CARGO_ENCARGADO
        Me.txtUSERID.Text = mEntidad.USERID
        Me.deLASTUPDATE.Value = mEntidad.LASTUPDATE
        Me.txtLATITUD.Value = mEntidad.LATITUD
        Me.txtLONGITUD.Value = mEntidad.LONGITUD

        Me.cbxPROVEEDOR_AF.ClientEnabled = False
        Me.cbxSITIO_CAPACITACION.ClientEnabled = False
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxPROVEEDOR_AF.Enabled = edicion
        Me.cbxMUNICIPIO.Enabled = edicion
        Me.cbxDEPARTAMENTO.Enabled = edicion
        Me.cbxMUNICIPIO.Enabled = edicion
        Me.txtFORMATO_CODIGO_CURSO.Enabled = edicion
        Me.txtDIRECCION.Enabled = edicion
        Me.txtTELEFONO.Enabled = edicion
        Me.txtFAX.Enabled = edicion
        Me.txtEMAIL.Enabled = edicion
        Me.txtNUMERO_AULAS.Enabled = edicion
        Me.deFECHA_REGISTRO.Enabled = edicion
        Me.txtENCARGADO.Enabled = edicion
        Me.txtTELEFONO_ENCARGADO.Enabled = edicion
        Me.txtEMAIL_ENCARGADO.Enabled = edicion
        Me.txtCARGO_ENCARGADO.Enabled = edicion
        Me.txtUSERID.Enabled = edicion
        Me.deLASTUPDATE.Enabled = edicion
        Me.txtLATITUD.Enabled = edicion
        Me.txtLONGITUD.Enabled = edicion
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.CargarProveedores()
        Me.CargarDepartamentos()
        Me.txtFORMATO_CODIGO_CURSO.Text = ""
        Me.txtDIRECCION.Text = ""
        Me.txtTELEFONO.Text = ""
        Me.txtFAX.Text = ""
        Me.txtEMAIL.Text = ""
        Me.txtNUMERO_AULAS.Value = Nothing
        Me.deFECHA_REGISTRO.Value = Nothing
        Me.txtENCARGADO.Text = ""
        Me.txtTELEFONO_ENCARGADO.Text = ""
        Me.txtEMAIL_ENCARGADO.Text = ""
        Me.txtCARGO_ENCARGADO.Text = ""
        Me.txtUSERID.Text = ""
        Me.deLASTUPDATE.Value = Nothing
        Me.txtLATITUD.Value = Nothing
        Me.txtLONGITUD.Value = Nothing
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla SITIO_CAPACITACION
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New SITIO_CAPACITACION
        If Me._nuevo Then
            mEntidad.ID_SITIO_CAPACITACION = 0
        Else
            mEntidad.ID_SITIO_CAPACITACION = CInt(Me.txtID_SITIO_CAPACITACION.Text)
        End If
        If Me.cbxSITIO_CAPACITACION.Text.Trim = "" Then
            Me.AsignarMensaje("Error al Guardar registro. " & vbCrLf & "Nombre de Sitio es requerido", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.cbxDEPARTAMENTO.Value = "" Then
            Me.AsignarMensaje("Error al Guardar registro. " & vbCrLf & "Departamento es requerido", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.cbxMUNICIPIO.Value = "" Then
            Me.AsignarMensaje("Error al Guardar registro. " & vbCrLf & "Municipio es requerido", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.txtDIRECCION.Text.Trim = "" Then
            Me.AsignarMensaje("Error al Guardar registro. " & vbCrLf & "Direccion del Centro es requerida", True, True)
            Return "Error al Guardar registro."
        End If
        If Not Me.txtTELEFONO.IsValid Or Me.txtTELEFONO.Text.Trim = "" Then
            Me.AsignarMensaje("Error al Guardar registro. " & vbCrLf & "Telefono del Centro es requerido", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.txtENCARGADO.Text.Trim = "" Then
            Me.AsignarMensaje("Error al Guardar registro. " & vbCrLf & "Encargado del Centro es requerido", True, True)
            Return "Error al Guardar registro."
        End If
        If Me.txtCARGO_ENCARGADO.Text.Trim = "" Then
            Me.AsignarMensaje("Error al Guardar registro. " & vbCrLf & "Cargo del Encargado del Centro es requerido", True, True)
            Return "Error al Guardar registro."
        End If
        If Not Me.txtTELEFONO_ENCARGADO.IsValid Or Me.txtTELEFONO_ENCARGADO.Text.Trim = "" Then
            Me.AsignarMensaje("Error al Guardar registro. " & vbCrLf & "Telefono del Encargado del Centro es requerido", True, True)
            Return "Error al Guardar registro."
        End If
        

        mEntidad.CODIGO_MUNICIPIO = Me.cbxMUNICIPIO.Value
        mEntidad.CODIGO_DEPARTAMENTO = Me.cbxDEPARTAMENTO.Value
        mEntidad.ID_PROVEEDOR_AF = Me.cbxPROVEEDOR_AF.Value
        mEntidad.NOMBRE_SITIO = Me.cbxSITIO_CAPACITACION.Text
        mEntidad.FORMATO_CODIGO_CURSO = Me.txtFORMATO_CODIGO_CURSO.Text
        mEntidad.DIRECCION = Me.txtDIRECCION.Text
        mEntidad.TELEFONO = Me.txtTELEFONO.Text
        mEntidad.FAX = Me.txtFAX.Text
        mEntidad.EMAIL = Me.txtEMAIL.Text.ToLower
        mEntidad.NUMERO_AULAS = Me.txtNUMERO_AULAS.Value
        mEntidad.FECHA_REGISTRO = Me.deFECHA_REGISTRO.Value
        mEntidad.ENCARGADO = Me.txtENCARGADO.Text
        mEntidad.TELEFONO_ENCARGADO = Me.txtTELEFONO_ENCARGADO.Text
        mEntidad.EMAIL_ENCARGADO = Me.txtEMAIL_ENCARGADO.Text.ToLower
        mEntidad.CARGO_ENCARGADO = Me.txtCARGO_ENCARGADO.Text
        mEntidad.USERID = Me.txtUSERID.Text
        mEntidad.LASTUPDATE = Me.deLASTUPDATE.Value
        mEntidad.LATITUD = Me.txtLATITUD.Value
        mEntidad.LONGITUD = Me.txtLONGITUD.Value
        mEntidad.USERID = Me.ObtenerUsuario
        mEntidad.LASTUPDATE = Now

        If mComponente.ActualizarSITIO_CAPACITACION(mEntidad, TipoConcurrencia.Pesimistica) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_SITIO_CAPACITACION.Text = mEntidad.ID_SITIO_CAPACITACION.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
