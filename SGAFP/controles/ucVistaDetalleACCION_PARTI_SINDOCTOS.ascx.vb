Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleACCION_PARTI_SINDOCTOS
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ACCION_PARTI_SINDOCTOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	06/05/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleACCION_PARTI_SINDOCTOS
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_ACCION_PARTI As Decimal
    Public Property ID_ACCION_PARTI() As Decimal
        Get
            Return Me.txtID_ACCION_PARTI.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_ACCION_PARTI = Value
            Me.txtID_ACCION_PARTI.Text = CStr(Value)
            If Me._ID_ACCION_PARTI > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            Return Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.Value
        End Get
        Set(ByVal value As Decimal)
            CargarAccionFormativa(value)
            If Not Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.Items.FindByValue(value) Is Nothing Then
                Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.Value = CDec(value)
            End If
        End Set
    End Property

    Public Property CANT_PARTICIPANTES() As Decimal
        Get
            If Me.txtCANT_PARTICIPANTES.Value Is Nothing Then Return -1
            Return Me.txtCANT_PARTICIPANTES.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtCANT_PARTICIPANTES.Value = value
        End Set
    End Property

    Public Property ES_ACTIVA() As Decimal
        Get
            If Me.txtES_ACTIVA.Value Is Nothing Then Return -1
            Return Me.txtES_ACTIVA.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtES_ACTIVA.Value = value
        End Set
    End Property

    Public Property USUARIO_CREACION() As String
        Get
            Return Me.txtUSUARIO_CREACION.Text
        End Get
        Set(ByVal value As String)
            Me.txtUSUARIO_CREACION.Text = value.ToString()
        End Set
    End Property

    Public Property FECHA_CREACION() As DateTime
        Get
            Return Me.deFECHA_CREACION.Value
        End Get
        Set(ByVal value As DateTime)
            Me.deFECHA_CREACION.Value = value
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

    Public Property VerID_ACCION_PARTI() As Boolean
        Get
            Return Me.trID_ACCION_PARTI.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ACCION_PARTI.Visible = value
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

    Public Property VerCANT_PARTICIPANTES() As Boolean
        Get
            Return Me.trCANT_PARTICIPANTES.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCANT_PARTICIPANTES.Visible = value
        End Set
    End Property

    Public Property VerES_ACTIVA() As Boolean
        Get
            Return Me.trES_ACTIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trES_ACTIVA.Visible = value
        End Set
    End Property

    Public Property VerUSUARIO_CREACION() As Boolean
        Get
            Return Me.trUSUARIO_CREACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO_CREACION.Visible = value
        End Set
    End Property

    Public Property VerFECHA_CREACION() As Boolean
        Get
            Return Me.trFECHA_CREACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_CREACION.Visible = value
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
    Private mComponente As New cACCION_PARTI_SINDOCTOS
    Private mEntidad As ACCION_PARTI_SINDOCTOS
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
        If Not Me.ViewState("ID_ACCION_PARTI") Is Nothing Then Me._ID_ACCION_PARTI = Me.ViewState("ID_ACCION_PARTI")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla ACCION_PARTI_SINDOCTOS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/05/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New ACCION_PARTI_SINDOCTOS
        mEntidad.ID_ACCION_PARTI = ID_ACCION_PARTI
 
        If mComponente.ObtenerACCION_PARTI_SINDOCTOS(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_ACCION_PARTI.Text = mEntidad.ID_ACCION_PARTI.ToString()
        Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.DataBind()
        Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.Value = CInt(mEntidad.ID_ACCION_FORMATIVA)
        Me.txtCANT_PARTICIPANTES.Value = mEntidad.CANT_PARTICIPANTES
        Me.txtES_ACTIVA.Value = mEntidad.ES_ACTIVA
        Me.cbxTIPO_AUTORIZACION.Value = mEntidad.TIPO_AUTORIZACION
        Me.txtUSUARIO_CREACION.Text = mEntidad.USUARIO_CREACION
        Me.deFECHA_CREACION.Value = mEntidad.FECHA_CREACION
        Me.txtUSERID.Text = mEntidad.USERID
        Me.deLASTUPDATE.Value = mEntidad.LASTUPDATE
    End Sub

    Private Function CargarAccionFormativa(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Me.odsACCION_FORMATIVA.SelectParameters("ID_ACCION_FORMATIVA").DefaultValue = ID_ACCION_FORMATIVA.ToString()
        Me.odsACCION_FORMATIVA.SelectParameters("recuperarHijas").DefaultValue = False
        Me.odsACCION_FORMATIVA.SelectParameters("recuperarForaneas").DefaultValue = False
        Me.odsACCION_FORMATIVA.DataBind()
        Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.DataBind()
        Return 1
    End Function
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/05/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.Enabled = edicion
        Me.txtCANT_PARTICIPANTES.Enabled = edicion
        Me.txtES_ACTIVA.Enabled = edicion
        Me.txtUSUARIO_CREACION.Enabled = edicion
        Me.deFECHA_CREACION.Enabled = edicion
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
    ''' 	[GenApp]	06/05/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.DataBind()
        Me.txtCANT_PARTICIPANTES.Value = Nothing
        Me.txtES_ACTIVA.Value = Nothing
        Me.txtUSUARIO_CREACION.Text = ""
        Me.deFECHA_CREACION.Value = Nothing
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.deLASTUPDATE.Value = Now
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla ACCION_PARTI_SINDOCTOS
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	06/05/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New ACCION_PARTI_SINDOCTOS
        If cbxACCION_FORMATIVAID_ACCION_FORMATIVA.Value Is Nothing Then
            Me.AsignarMensaje("Seleccione la Accion Formativa.", True, True)
            Return "Error al Guardar registro."
        End If
        If cbxACCION_FORMATIVAID_ACCION_FORMATIVA.Value Is Nothing OrElse Me.txtCANT_PARTICIPANTES.Value <= 0 Then
            Me.AsignarMensaje("Ingrese la cantidad de participantes exonerados de documentos.", True, True)
            Return "Error al Guardar registro."
        End If
        If cbxTIPO_AUTORIZACION.Value Is Nothing OrElse Me.cbxTIPO_AUTORIZACION.Value = "" Then
            Me.AsignarMensaje("Seleccione el Tipo de Autorizacion.", True, True)
            Return "Error al Guardar registro."
        End If
        If Me._nuevo Then
            mEntidad.ID_ACCION_PARTI = 0
            mEntidad.USUARIO_CREACION = Me.ObtenerUsuario
            mEntidad.FECHA_CREACION = Now
            mEntidad.ES_ACTIVA = 1
        Else
            mEntidad.ID_ACCION_PARTI = CInt(Me.txtID_ACCION_PARTI.Text)
            mEntidad.USUARIO_CREACION = Me.txtUSUARIO_CREACION.Text
            mEntidad.FECHA_CREACION = Me.deFECHA_CREACION.Value
            mEntidad.ES_ACTIVA = Me.txtES_ACTIVA.Value
        End If
        mEntidad.ID_ACCION_FORMATIVA = Me.cbxACCION_FORMATIVAID_ACCION_FORMATIVA.Value
        mEntidad.CANT_PARTICIPANTES = Me.txtCANT_PARTICIPANTES.Value
        mEntidad.TIPO_AUTORIZACION = Me.cbxTIPO_AUTORIZACION.Value
        mEntidad.USERID = Me.ObtenerUsuario()
        mEntidad.LASTUPDATE = Me.deLASTUPDATE.Value
        If mComponente.ActualizarACCION_PARTI_SINDOCTOS(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_ACCION_PARTI.Text = mEntidad.ID_ACCION_PARTI.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
