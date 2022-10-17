Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleESTADO_ACCION_FORMATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ESTADO_ACCION_FORMATIVA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleESTADO_ACCION_FORMATIVA
    Inherits ucBase
 
#Region"Propiedades"

    Private _CODIGO_ESTADO_AF As String
    Public Property CODIGO_ESTADO_AF() As String
        Get
            Return Me.txtCODIGO_ESTADO_AF.Text
        End Get
        Set(ByVal Value As String)
            Me._CODIGO_ESTADO_AF = Value
            Me.txtCODIGO_ESTADO_AF.Text = Value
            If Me._CODIGO_ESTADO_AF <> "" Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerCODIGO_ESTADO_AF() As Boolean
        Get
            Return Me.trCODIGO_ESTADO_AF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCODIGO_ESTADO_AF.Visible = value
        End Set
    End Property

    Public Property VerNOMBRE_ESTADO_AF() As Boolean
        Get
            Return Me.trNOMBRE_ESTADO_AF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOMBRE_ESTADO_AF.Visible = value
        End Set
    End Property

    Public Property VerESTADO_INICIAL() As Boolean
        Get
            Return Me.trESTADO_INICIAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trESTADO_INICIAL.Visible = value
        End Set
    End Property

    Public Property VerPERMITE_INSCRIPCION() As Boolean
        Get
            Return Me.trPERMITE_INSCRIPCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPERMITE_INSCRIPCION.Visible = value
        End Set
    End Property

    Public Property VerESTADO_FINAL() As Boolean
        Get
            Return Me.trESTADO_FINAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trESTADO_FINAL.Visible = value
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
    Private mComponente As New cESTADO_ACCION_FORMATIVA
    Private mEntidad As ESTADO_ACCION_FORMATIVA
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
        If Not Me.ViewState("CODIGO_ESTADO_AF") Is Nothing Then Me._CODIGO_ESTADO_AF = Me.ViewState("CODIGO_ESTADO_AF")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla ESTADO_ACCION_FORMATIVA
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
        mEntidad = New ESTADO_ACCION_FORMATIVA
        mEntidad.CODIGO_ESTADO_AF = CODIGO_ESTADO_AF
 
        If mComponente.ObtenerESTADO_ACCION_FORMATIVA(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtCODIGO_ESTADO_AF.Text = mEntidad.CODIGO_ESTADO_AF
        Me.txtNOMBRE_ESTADO_AF.Text = mEntidad.NOMBRE_ESTADO_AF
        Me.txtESTADO_INICIAL.Text = mEntidad.ESTADO_INICIAL
        Me.txtPERMITE_INSCRIPCION.Text = mEntidad.PERMITE_INSCRIPCION
        Me.txtESTADO_FINAL.Text = mEntidad.ESTADO_FINAL
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
        Me.txtNOMBRE_ESTADO_AF.Enabled = edicion
        Me.txtESTADO_INICIAL.Enabled = edicion
        Me.txtPERMITE_INSCRIPCION.Enabled = edicion
        Me.txtESTADO_FINAL.Enabled = edicion
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
        Me.txtNOMBRE_ESTADO_AF.Text = ""
        Me.txtESTADO_INICIAL.Text = ""
        Me.txtPERMITE_INSCRIPCION.Text = ""
        Me.txtESTADO_FINAL.Text = ""
        Me.txtNOTAS.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla ESTADO_ACCION_FORMATIVA
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
        mEntidad = New ESTADO_ACCION_FORMATIVA
        If Me.txtCODIGO_ESTADO_AF.Text = "0" Then
            Me.AsignarMensaje("Asigne un valor al Codigo estado af que sea valido", True, True)
            Return "Error"
        End If
            mEntidad.CODIGO_ESTADO_AF = Me.txtCODIGO_ESTADO_AF.Text
        mEntidad.NOMBRE_ESTADO_AF = Me.txtNOMBRE_ESTADO_AF.Text
        mEntidad.ESTADO_INICIAL = Val(Me.txtESTADO_INICIAL.Text)
        mEntidad.PERMITE_INSCRIPCION = Val(Me.txtPERMITE_INSCRIPCION.Text)
        mEntidad.ESTADO_FINAL = Val(Me.txtESTADO_FINAL.Text)
        mEntidad.NOTAS = Me.txtNOTAS.Text

        If Me._nuevo Then
            If mComponente.AgregarESTADO_ACCION_FORMATIVA(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
         Else
            If mComponente.ActualizarESTADO_ACCION_FORMATIVA(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If
        Me.txtCODIGO_ESTADO_AF.Text = mEntidad.CODIGO_ESTADO_AF.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
