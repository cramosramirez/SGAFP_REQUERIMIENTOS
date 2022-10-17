Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleSUPERVISION_AF_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla SUPERVISION_AF_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleSUPERVISION_AF_DET
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_SUPERVISION_DET As Decimal
    Public Property ID_SUPERVISION_DET() As Decimal
        Get
            Return Me.txtID_SUPERVISION_DET.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_SUPERVISION_DET = Value
            Me.txtID_SUPERVISION_DET.Text = CStr(Value)
            If Me._ID_SUPERVISION_DET > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_SUPERVISION_DET() As Boolean
        Get
            Return Me.trID_SUPERVISION_DET.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_SUPERVISION_DET.Visible = value
        End Set
    End Property

    Public Property VerID_LISTA_SUPERVISION() As Boolean
        Get
            Return Me.trID_LISTA_SUPERVISION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_LISTA_SUPERVISION.Visible = value
        End Set
    End Property

    Public Property VerID_SUPERVISION_AF() As Boolean
        Get
            Return Me.trID_SUPERVISION_AF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_SUPERVISION_AF.Visible = value
        End Set
    End Property

    Public Property VerCOMENTARIOS() As Boolean
        Get
            Return Me.trCOMENTARIOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCOMENTARIOS.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cSUPERVISION_AF_DET
    Private mEntidad As SUPERVISION_AF_DET
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
        If Not Me.ViewState("ID_SUPERVISION_DET") Is Nothing Then Me._ID_SUPERVISION_DET = Me.ViewState("ID_SUPERVISION_DET")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla SUPERVISION_AF_DET
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
        mEntidad = New SUPERVISION_AF_DET
        mEntidad.ID_SUPERVISION_DET = ID_SUPERVISION_DET
 
        If mComponente.ObtenerSUPERVISION_AF_DET(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_SUPERVISION_DET.Text = mEntidad.ID_SUPERVISION_DET.ToString()
        Me.ddlLISTA_SUPERVISION_AF1.Recuperar()
        Me.ddlLISTA_SUPERVISION_AF1.SelectedValue = mEntidad.ID_LISTA_SUPERVISION
        Me.ddlSUPERVISION_AF1.Recuperar()
        Me.ddlSUPERVISION_AF1.SelectedValue = mEntidad.ID_SUPERVISION_AF
        Me.txtCOMENTARIOS.Text = mEntidad.COMENTARIOS
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
        Me.ddlLISTA_SUPERVISION_AF1.Enabled = edicion
        Me.ddlSUPERVISION_AF1.Enabled = edicion
        Me.txtCOMENTARIOS.Enabled = edicion
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
        Me.ddlLISTA_SUPERVISION_AF1.Recuperar()
        Me.ddlSUPERVISION_AF1.Recuperar()
        Me.txtCOMENTARIOS.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla SUPERVISION_AF_DET
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
        mEntidad = New SUPERVISION_AF_DET
        If Me._nuevo Then
            mEntidad.ID_SUPERVISION_DET = 0
        Else
            mEntidad.ID_SUPERVISION_DET = CInt(Me.txtID_SUPERVISION_DET.Text)
        End If
        mEntidad.ID_LISTA_SUPERVISION = Me.ddlLISTA_SUPERVISION_AF1.SelectedValue
        mEntidad.ID_SUPERVISION_AF = Me.ddlSUPERVISION_AF1.SelectedValue
        mEntidad.COMENTARIOS = Me.txtCOMENTARIOS.Text

        If mComponente.ActualizarSUPERVISION_AF_DET(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_SUPERVISION_DET.Text = mEntidad.ID_SUPERVISION_DET.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
