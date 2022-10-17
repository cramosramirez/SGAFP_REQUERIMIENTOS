Imports SGAFP.BL
Imports SGAFP.EL
Imports Microsoft.ApplicationBlocks.ExceptionManagement

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleEVALUACION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla EVALUACION_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleEVALUACION_AF
    Inherits ucBase
 
#Region"Propiedades"

    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            If Me.txtID_ACCION_FORMATIVA.Text = "" Then Return 0
            Return Convert.ToDecimal(Me.txtID_ACCION_FORMATIVA.Text)
        End Get
        Set(ByVal Value As Decimal)
            txtID_ACCION_FORMATIVA.Text = Value.ToString()
        End Set
    End Property

    Private _ID_EVALUACION_AF As Decimal
    Public Property ID_EVALUACION_AF() As Decimal
        Get
            If Me.txtID_EVALUACION_AF.Text = "" Then Return -1
            Return CDec(Me.txtID_EVALUACION_AF.Text)
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_EVALUACION_AF = Value
            Me.txtID_EVALUACION_AF.Text = CStr(Value)
            If Me._ID_EVALUACION_AF > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
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

    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me.trID_ACCION_FORMATIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Public Property VerFECHA_EVALUACION() As Boolean
        Get
            Return Me.trFECHA_EVALUACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_EVALUACION.Visible = value
        End Set
    End Property

    Public Property VerTEMA_EVALUACION() As Boolean
        Get
            Return Me.trTEMA_EVALUACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTEMA_EVALUACION.Visible = value
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

    Public Property VerEVALUADOR() As Boolean
        Get
            Return Me.trEVALUADOR.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEVALUADOR.Visible = value
        End Set
    End Property

    Public Property VerTIPO_EVALUACION() As Boolean
        Get
            Return Me.trTIPO_EVALUACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trTIPO_EVALUACION.Visible = value
        End Set
    End Property

    Public Property VerPORC_APROBACION() As Boolean
        Get
            Return Me.trPORC_APROBACION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPORC_APROBACION.Visible = value
        End Set
    End Property

    Public Property VerPORC_REPROBADOS() As Boolean
        Get
            Return Me.trPORC_REPROBADOS.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPORC_REPROBADOS.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cEVALUACION_AF
    Private mEntidad As EVALUACION_AF
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
        If Not Me.ViewState("ID_EVALUACION_AF") Is Nothing Then Me._ID_EVALUACION_AF = Me.ViewState("ID_EVALUACION_AF")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla EVALUACION_AF
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
        mEntidad = New EVALUACION_AF
        mEntidad.ID_EVALUACION_AF = ID_EVALUACION_AF
 
        If mComponente.ObtenerEVALUACION_AF(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtID_EVALUACION_AF.Text = mEntidad.ID_EVALUACION_AF.ToString()
        Me.txtID_ACCION_FORMATIVA.Text = mEntidad.ID_ACCION_FORMATIVA.ToString()
        Me.txtFECHA_EVALUACION.Text = IIf(Not mEntidad.FECHA_EVALUACION = Nothing, Format(mEntidad.FECHA_EVALUACION, "dd/MM/yyyy"), "")
        Me.txtTEMA_EVALUACION.Text = mEntidad.TEMA_EVALUACION
        Me.txtNOTAS.Text = mEntidad.NOTAS
        Me.txtEVALUADOR.Text = mEntidad.EVALUADOR
        Me.ddlTipoEvaluacion1.SelectedValue = mEntidad.TIPO_EVALUACION
        Me.txtPORC_APROBACION.Text = mEntidad.PORC_APROBACION
        Me.txtPORC_REPROBADOS.Text = mEntidad.PORC_REPROBADOS
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
        Me.txtFECHA_EVALUACION.Enabled = edicion
        Me.txtTEMA_EVALUACION.Enabled = edicion
        Me.txtNOTAS.Enabled = edicion
        Me.txtEVALUADOR.Enabled = edicion
        Me.ddlTipoEvaluacion1.Enabled = edicion
        Me.txtPORC_APROBACION.Enabled = edicion
        Me.txtPORC_REPROBADOS.Enabled = edicion
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
        'Me.txtID_ACCION_FORMATIVA.Text = Me.ID_ACCION_FORMATIVA.ToString()
        Me.txtFECHA_EVALUACION.Text = Now.ToString("dd/MM/yyyy")
        Me.txtTEMA_EVALUACION.Text = ""
        Me.txtNOTAS.Text = ""
        Me.txtEVALUADOR.Text = ""
        Me.ddlTipoEvaluacion1.SelectedValue = "P"
        Me.txtPORC_APROBACION.Text = "0"
        Me.txtPORC_REPROBADOS.Text = "0"
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla EVALUACION_AF
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
        Try
            Dim sError As New String("")
            Dim alDatos As New ArrayList
            mEntidad = New EVALUACION_AF
            If Me._nuevo Then
                mEntidad.ID_EVALUACION_AF = 0
            Else
                mEntidad.ID_EVALUACION_AF = Decimal.Parse(Me.txtID_EVALUACION_AF.Text)
            End If
            mEntidad.ID_ACCION_FORMATIVA = Decimal.Parse(Me.txtID_ACCION_FORMATIVA.Text)
            If Me.txtFECHA_EVALUACION.Text <> "" Then mEntidad.FECHA_EVALUACION = System.DateTime.Parse(Me.txtFECHA_EVALUACION.Text, New System.Globalization.CultureInfo("fr-FR", True), _
                    System.Globalization.DateTimeStyles.NoCurrentDateDefault)
            mEntidad.TEMA_EVALUACION = Me.txtTEMA_EVALUACION.Text.ToUpper
            mEntidad.NOTAS = Me.txtNOTAS.Text.ToUpper
            mEntidad.EVALUADOR = Me.txtEVALUADOR.Text.ToUpper
            mEntidad.TIPO_EVALUACION = Me.ddlTipoEvaluacion1.SelectedValue
            mEntidad.PORC_APROBACION = Decimal.Parse(Me.txtPORC_APROBACION.Text)
            mEntidad.PORC_REPROBADOS = Decimal.Parse(Me.txtPORC_REPROBADOS.Text)

            If mComponente.ActualizarEVALUACION_AF(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro. " + mComponente.sError, True, True)
                Return "Error al Guardar registro. " + mComponente.sError
            End If
            Me.txtID_EVALUACION_AF.Text = mEntidad.ID_EVALUACION_AF.ToString()
            Me._nuevo = False
            If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
            Me.ViewState.Add("nuevo", Me._nuevo)
            Return ""

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return "Error al Guardar registro."
        End Try
    End Function
End Class
