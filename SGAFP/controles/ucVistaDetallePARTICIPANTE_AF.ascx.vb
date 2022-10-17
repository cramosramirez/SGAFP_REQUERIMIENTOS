Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetallePARTICIPANTE_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla PARTICIPANTE_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetallePARTICIPANTE_AF
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_PARTICIPANTE As Decimal
    Public Property ID_PARTICIPANTE() As Decimal
        Get
            Return Me._ID_PARTICIPANTE
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_PARTICIPANTE = Value
            If Me._ID_PARTICIPANTE > 0 Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Private _ID_ACCION_FORMATIVA As Decimal
    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            Return _ID_ACCION_FORMATIVA
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_ACCION_FORMATIVA = Value
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

    Public Property VerID_ACCION_FORMATIVA() As Boolean
        Get
            Return Me.trID_ACCION_FORMATIVA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_ACCION_FORMATIVA.Visible = value
        End Set
    End Property

    Public Property VerID_SOLICITUD() As Boolean
        Get
            Return Me.trID_SOLICITUD.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_SOLICITUD.Visible = value
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

    Public Property VerFECHA_INSCRIPCION() As Boolean
        Get
            Return Me.trFECHA_INSCRIPCION.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trFECHA_INSCRIPCION.Visible = value
        End Set
    End Property

    Public Property VerNOTA_FINAL() As Boolean
        Get
            Return Me.trNOTA_FINAL.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trNOTA_FINAL.Visible = value
        End Set
    End Property

    Public Property VerPORC_ASISTENCIA() As Boolean
        Get
            Return Me.trPORC_ASISTENCIA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trPORC_ASISTENCIA.Visible = value
        End Set
    End Property

    Public Property VerENTREGA_DIPLOMA() As Boolean
        Get
            Return Me.trENTREGA_DIPLOMA.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trENTREGA_DIPLOMA.Visible = value
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
    Private mComponente As New cPARTICIPANTE_AF
    Private mEntidad As PARTICIPANTE_AF
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
        If Not Me.ViewState("ID_PARTICIPANTE") Is Nothing Then Me._ID_PARTICIPANTE = Me.ViewState("ID_PARTICIPANTE")
        If Not Me.ViewState("ID_ACCION_FORMATIVA") Is Nothing Then Me._ID_ACCION_FORMATIVA = Me.ViewState("ID_ACCION_FORMATIVA")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla PARTICIPANTE_AF
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
        mEntidad = New PARTICIPANTE_AF
        mEntidad.ID_PARTICIPANTE = ID_PARTICIPANTE
        mEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
 
        If mComponente.ObtenerPARTICIPANTE_AF(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.ddlPARTICIPANTE1.Recuperar()
        Me.ddlPARTICIPANTE1.SelectedValue = mEntidad.ID_PARTICIPANTE
        Me.ddlACCION_FORMATIVA1.Recuperar()
        Me.ddlACCION_FORMATIVA1.SelectedValue = mEntidad.ID_ACCION_FORMATIVA
        Me.ddlSOLICITUD_INSCRIPCION_AF1.Recuperar()
        Me.ddlSOLICITUD_INSCRIPCION_AF1.SelectedValue = mEntidad.ID_SOLICITUD
        Me.txtESTADO.Text = mEntidad.ESTADO
        Me.txtFECHA_INSCRIPCION.Text = IIf(Not mEntidad.FECHA_INSCRIPCION = Nothing, Format(mEntidad.FECHA_INSCRIPCION, "dd/MM/yyyy"), "")
        Me.txtNOTA_FINAL.Text = mEntidad.NOTA_FINAL
        Me.txtPORC_ASISTENCIA.Text = mEntidad.PORC_ASISTENCIA
        Me.txtENTREGA_DIPLOMA.Text = mEntidad.ENTREGA_DIPLOMA
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
        Me.ddlSOLICITUD_INSCRIPCION_AF1.Enabled = edicion
        Me.txtESTADO.Enabled = edicion
        Me.txtFECHA_INSCRIPCION.Enabled = edicion
        Me.txtNOTA_FINAL.Enabled = edicion
        Me.txtPORC_ASISTENCIA.Enabled = edicion
        Me.txtENTREGA_DIPLOMA.Enabled = edicion
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
        Me.ddlACCION_FORMATIVA1.Recuperar()
        Me.ddlACCION_FORMATIVA1.SelectedValue = Me.ID_ACCION_FORMATIVA.ToString()
        Me.ddlSOLICITUD_INSCRIPCION_AF1.Recuperar()
        Me.txtESTADO.Text = ""
        Me.txtFECHA_INSCRIPCION.Text = ""
        Me.txtNOTA_FINAL.Text = ""
        Me.txtPORC_ASISTENCIA.Text = ""
        Me.txtENTREGA_DIPLOMA.Text = ""
        Me.txtNOTAS.Text = ""
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla PARTICIPANTE_AF
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
        mEntidad = New PARTICIPANTE_AF
        mEntidad.ID_PARTICIPANTE = Me.ddlPARTICIPANTE1.SelectedValue
        mEntidad.ID_ACCION_FORMATIVA = Me.ddlACCION_FORMATIVA1.SelectedValue
        mEntidad.ID_SOLICITUD = Me.ddlSOLICITUD_INSCRIPCION_AF1.SelectedValue
        mEntidad.ESTADO = Me.txtESTADO.Text
        If Me.txtFECHA_INSCRIPCION.Text <> "" Then mEntidad.FECHA_INSCRIPCION = System.DateTime.Parse(Me.txtFECHA_INSCRIPCION.Text, New System.Globalization.CultureInfo("fr-FR", True),  _
                System.Globalization.DateTimeStyles.NoCurrentDateDefault)
        mEntidad.NOTA_FINAL = Val(Me.txtNOTA_FINAL.Text)
        mEntidad.PORC_ASISTENCIA = Val(Me.txtPORC_ASISTENCIA.Text)
        mEntidad.ENTREGA_DIPLOMA = Me.txtENTREGA_DIPLOMA.Text
        mEntidad.NOTAS = Me.txtNOTAS.Text

        If Me._nuevo Then
            If mComponente.AgregarPARTICIPANTE_AF(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
         Else
            If mComponente.ActualizarPARTICIPANTE_AF(mEntidad) <> 1 Then
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
