Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleUNIDAD_ORGANIZATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla UNIDAD_ORGANIZATIVA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleUNIDAD_ORGANIZATIVA
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_UNIDAD_ORGANIZATIVA As Decimal
    Public Property ID_UNIDAD_ORGANIZATIVA() As Decimal
        Get
            Return Me.txtID_UNIDAD_ORGANIZATIVA.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_UNIDAD_ORGANIZATIVA = Value
            Me.txtID_UNIDAD_ORGANIZATIVA.Text = CStr(Value)
            If Me._ID_UNIDAD_ORGANIZATIVA > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property NOMBRE_UNIDAD() As String
        Get
            Return Me.txtNOMBRE_UNIDAD.Text
        End Get
        Set(ByVal value As String)
            Me.txtNOMBRE_UNIDAD.Text = value.ToString()
        End Set
    End Property

    Public Property CODIGO_UNIDAD() As String
        Get
            Return Me.txtCODIGO_UNIDAD.Text
        End Get
        Set(ByVal value As String)
            Me.txtCODIGO_UNIDAD.Text = value.ToString()
        End Set
    End Property

    Public Property ID_UNIDAD_PADRE() As Decimal
        Get
            Return Me.cbxUNIDAD_ORGANIZATIVAID_UNIDAD_PADRE.Value
        End Get
        Set(ByVal value As Decimal)
            If Not Me.cbxUNIDAD_ORGANIZATIVAID_UNIDAD_PADRE.Items.FindByValue(value) Is Nothing Then
                Me.cbxUNIDAD_ORGANIZATIVAID_UNIDAD_PADRE.Value = CInt(value)
            End If
        End Set
    End Property

    Public Property ESTADO() As Decimal
        Get
            If Me.txtESTADO.Value Is Nothing Then Return -1
            Return Me.txtESTADO.Value
        End Get
        Set(ByVal value As Decimal)
            Me.txtESTADO.Value = value
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

    Public Property VerID_UNIDAD_ORGANIZATIVA() As Boolean
        Get
            Return Me.trID_UNIDAD_ORGANIZATIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_UNIDAD_ORGANIZATIVA.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_UNIDAD() As Boolean
        Get
            Return Me.trNOMBRE_UNIDAD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_UNIDAD.Visible = value
        End Set
    End Property

    Public Property VerCODIGO_UNIDAD() As Boolean
        Get
            Return Me.trCODIGO_UNIDAD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_UNIDAD.Visible = value
        End Set
    End Property

    Public Property VerID_UNIDAD_PADRE() As Boolean
        Get
            Return Me.trID_UNIDAD_PADRE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_UNIDAD_PADRE.Visible = value
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
    Private mComponente As New cUNIDAD_ORGANIZATIVA
    Private mEntidad As UNIDAD_ORGANIZATIVA
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
        If Not Me.ViewState("ID_UNIDAD_ORGANIZATIVA") Is Nothing Then Me._ID_UNIDAD_ORGANIZATIVA = Me.ViewState("ID_UNIDAD_ORGANIZATIVA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla UNIDAD_ORGANIZATIVA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New UNIDAD_ORGANIZATIVA
        mEntidad.ID_UNIDAD_ORGANIZATIVA = ID_UNIDAD_ORGANIZATIVA
 
        If mComponente.ObtenerUNIDAD_ORGANIZATIVA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_UNIDAD_ORGANIZATIVA.Text = mEntidad.ID_UNIDAD_ORGANIZATIVA.ToString()
        Me.txtNOMBRE_UNIDAD.Text = mEntidad.NOMBRE_UNIDAD
        Me.txtCODIGO_UNIDAD.Text = mEntidad.CODIGO_UNIDAD
        Me.cbxUNIDAD_ORGANIZATIVAID_UNIDAD_PADRE.DataBind()
        Me.cbxUNIDAD_ORGANIZATIVAID_UNIDAD_PADRE.Value = CInt(mEntidad.ID_UNIDAD_PADRE)
        Me.txtESTADO.Value = mEntidad.ESTADO
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.cbxUNIDAD_ORGANIZATIVAID_UNIDAD_PADRE.Enabled = edicion
        Me.txtNOMBRE_UNIDAD.Enabled = edicion
        Me.txtCODIGO_UNIDAD.Enabled = edicion
        Me.txtESTADO.Enabled = edicion
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.cbxUNIDAD_ORGANIZATIVAID_UNIDAD_PADRE.DataBind()
        Me.txtNOMBRE_UNIDAD.Text = ""
        Me.txtCODIGO_UNIDAD.Text = ""
        Me.txtESTADO.Value = Nothing
        Me.txtUSERID.Text = Me.ObtenerUsuario()
        Me.deLASTUPDATE.Value = Now
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla UNIDAD_ORGANIZATIVA
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New UNIDAD_ORGANIZATIVA
        If Me._nuevo Then
            mEntidad.ID_UNIDAD_ORGANIZATIVA = 0
        Else
            mEntidad.ID_UNIDAD_ORGANIZATIVA = CInt(Me.txtID_UNIDAD_ORGANIZATIVA.Text)
        End If
        mEntidad.NOMBRE_UNIDAD = Me.txtNOMBRE_UNIDAD.Text
        mEntidad.CODIGO_UNIDAD = Me.txtCODIGO_UNIDAD.Text
        mEntidad.ID_UNIDAD_PADRE = Me.cbxUNIDAD_ORGANIZATIVAID_UNIDAD_PADRE.Value
        mEntidad.ESTADO = Me.txtESTADO.Value
        mEntidad.USERID = Me.ObtenerUsuario()
        mEntidad.LASTUPDATE = Me.deLASTUPDATE.Value

        If mComponente.ActualizarUNIDAD_ORGANIZATIVA(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_UNIDAD_ORGANIZATIVA.Text = mEntidad.ID_UNIDAD_ORGANIZATIVA.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
