Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleEVALUACIONES_AF_DET
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla EVALUACIONES_AF_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleEVALUACIONES_AF_DET
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_EVALUACION_DET As Decimal
    Public Property ID_EVALUACION_DET() As Decimal
        Get
            Return Me.txtID_EVALUACION_DET.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_EVALUACION_DET = Value
            Me.txtID_EVALUACION_DET.Text = CStr(Value)
            If Me._ID_EVALUACION_DET > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerID_EVALUACION_DET() As Boolean
        Get
            Return Me.trID_EVALUACION_DET.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_EVALUACION_DET.Visible = value
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

    Public Property VerID_EVALUACION_AF() As Boolean
        Get
            Return Me.trID_EVALUACION_AF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_EVALUACION_AF.Visible = value
        End Set
    End Property

    Public Property VerNOTA_OBTENIDA() As Boolean
        Get
            Return Me.trNOTA_OBTENIDA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOTA_OBTENIDA.Visible = value
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

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cEVALUACIONES_AF_DET
    Private mEntidad As EVALUACIONES_AF_DET
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
        If Not Me.ViewState("ID_EVALUACION_DET") Is Nothing Then Me._ID_EVALUACION_DET = Me.ViewState("ID_EVALUACION_DET")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla EVALUACIONES_AF_DET
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
        mEntidad = New EVALUACIONES_AF_DET
        mEntidad.ID_EVALUACION_DET = ID_EVALUACION_DET
 
        If mComponente.ObtenerEVALUACIONES_AF_DET(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_EVALUACION_DET.Text = mEntidad.ID_EVALUACION_DET.ToString()
        Me.ddlPARTICIPANTE1.Recuperar()
        Me.ddlPARTICIPANTE1.SelectedValue = mEntidad.ID_PARTICIPANTE
        Me.ddlEVALUACION_AF1.Recuperar()
        Me.ddlEVALUACION_AF1.SelectedValue = mEntidad.ID_EVALUACION_AF
        Me.txtNOTA_OBTENIDA.Text = mEntidad.NOTA_OBTENIDA
        Me.txtNOTAS.Text = mEntidad.NOTAS
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
        Me.ddlPARTICIPANTE1.Enabled = edicion
        Me.ddlEVALUACION_AF1.Enabled = edicion
        Me.txtNOTA_OBTENIDA.Enabled = edicion
        Me.txtNOTAS.Enabled = edicion
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
        Me.ddlPARTICIPANTE1.Recuperar()
        Me.ddlEVALUACION_AF1.Recuperar()
        Me.txtNOTA_OBTENIDA.Text = ""
        Me.txtNOTAS.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla EVALUACIONES_AF_DET
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
        mEntidad = New EVALUACIONES_AF_DET
        If Me._nuevo Then
            mEntidad.ID_EVALUACION_DET = 0
        Else
            mEntidad.ID_EVALUACION_DET = CInt(Me.txtID_EVALUACION_DET.Text)
        End If
        mEntidad.ID_PARTICIPANTE = Me.ddlPARTICIPANTE1.SelectedValue
        mEntidad.ID_EVALUACION_AF = Me.ddlEVALUACION_AF1.SelectedValue
        mEntidad.NOTA_OBTENIDA = Val(Me.txtNOTA_OBTENIDA.Text)
        mEntidad.NOTAS = Me.txtNOTAS.Text

        If mComponente.ActualizarEVALUACIONES_AF_DET(mEntidad) <> 1 Then
            Me.AsignarMensaje("Error al Guardar registro.", True, True)
            Return "Error al Guardar registro."
        End If
        Me.txtID_EVALUACION_DET.Text = mEntidad.ID_EVALUACION_DET.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
