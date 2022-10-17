Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetallePAQUETE_INFORME_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PAQUETE_INFORME_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/08/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePAQUETE_INFORME_DET
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_PAQUETE As Decimal
    Public Property ID_PAQUETE() As Decimal
        Get
            Return _ID_PAQUETE
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_PAQUETE = Value
        End Set
    End Property

    Private _ID_INFORME_FINAL As Decimal
    Public Property ID_INFORME_FINAL() As Decimal
        Get
            Return Me._ID_INFORME_FINAL
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_INFORME_FINAL = Value
            If Me._ID_INFORME_FINAL > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_PAQUETE() As Boolean
        Get
            Return Me.trID_PAQUETE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PAQUETE.Visible = value
        End Set
    End Property

    Public Property VerID_INFORME_FINAL() As Boolean
        Get
            Return Me.trID_INFORME_FINAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_INFORME_FINAL.Visible = value
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
    Private mComponente As New cPAQUETE_INFORME_DET
    Private mEntidad As PAQUETE_INFORME_DET
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
        If Not Me.ViewState("ID_PAQUETE") Is Nothing Then Me._ID_PAQUETE = Me.ViewState("ID_PAQUETE")
        If Not Me.ViewState("ID_INFORME_FINAL") Is Nothing Then Me._ID_INFORME_FINAL = Me.ViewState("ID_INFORME_FINAL")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla PAQUETE_INFORME_DET
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatos()

        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)

        Dim sError As New String("")
        mEntidad = New PAQUETE_INFORME_DET
        mEntidad.ID_PAQUETE = ID_PAQUETE
        mEntidad.ID_INFORME_FINAL = ID_INFORME_FINAL
 
        If mComponente.ObtenerPAQUETE_INFORME_DET(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.ddlPAQUETE_INFORME1.Recuperar()
        Me.ddlPAQUETE_INFORME1.SelectedValue = mEntidad.ID_PAQUETE
        Me.ddlINFORME_FINAL_AF1.Recuperar()
        Me.ddlINFORME_FINAL_AF1.SelectedValue = mEntidad.ID_INFORME_FINAL
        Me.txtLASTUPDATE.Text = IIf(Not mEntidad.LASTUPDATE = Nothing, Format(mEntidad.LASTUPDATE, "dd/MM/yyyy"), "")
        Me.txtUSERID.Text = mEntidad.USERID
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.ddlINFORME_FINAL_AF1.Enabled = edicion
        Me.txtLASTUPDATE.Enabled = False
        Me.txtUSERID.Enabled = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Configura si es un registro nuevo el cargado
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub Nuevo()
        Me._nuevo = True
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Me.ddlPAQUETE_INFORME1.Recuperar()
        Me.ddlPAQUETE_INFORME1.SelectedValue = Me.ID_PAQUETE.ToString()
        Me.ddlINFORME_FINAL_AF1.Recuperar()
        Me.txtLASTUPDATE.Text = Now.ToString("dd/MM/yyyy")
        Me.txtUSERID.Text = Me.ObtenerUsuario()
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla PAQUETE_INFORME_DET
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New PAQUETE_INFORME_DET
        mEntidad.ID_PAQUETE = Me.ddlPAQUETE_INFORME1.SelectedValue
        mEntidad.ID_INFORME_FINAL = Me.ddlINFORME_FINAL_AF1.SelectedValue
        If Me.txtLASTUPDATE.Text <> "" Then mEntidad.LASTUPDATE = System.DateTime.Parse(Me.txtLASTUPDATE.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.USERID = Me.ObtenerUsuario()

        If Me._nuevo Then
            If mComponente.AgregarPAQUETE_INFORME_DET(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
         Else
            If mComponente.ActualizarPAQUETE_INFORME_DET(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
