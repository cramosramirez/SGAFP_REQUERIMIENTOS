Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleUSUARIO
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla USUARIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleUSUARIO
    Inherits ucBase
 
#Region"Propiedades"

    Private _USUARIO As String
    Public Property USUARIO() As String
        Get
            Return Me.txtUSUARIO.Text
        End Get
        Set(ByVal Value As String)
            Me._USUARIO = Value
            Me.txtUSUARIO.Text = Value
            If Me._USUARIO <> "" Then
                Me.CargarDatos()
            Else
                Me.LimpiarControles()
                Me.Nuevo()
            End If
            Me.HabilitarEdicion(Me._Enabled)
        End Set
    End Property

    Public Property VerUSUARIO() As Boolean
        Get
            Return Me.trUSUARIO.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trUSUARIO.Visible = value
        End Set
    End Property

    Public Property VerID_PROVEEDOR_AF() As Boolean
        Get
            Return Me.trID_PROVEEDOR_AF.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PROVEEDOR_AF.Visible = value
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

    Public Property VerID_PARTICIPANTE() As Boolean
        Get
            Return Me.trID_PARTICIPANTE.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trID_PARTICIPANTE.Visible = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cUSUARIO
    Private mEntidad As USUARIO
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
        If Not Me.ViewState("USUARIO") Is Nothing Then Me._USUARIO = Me.ViewState("USUARIO")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información del registro de la tabla USUARIO
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
        mEntidad = New USUARIO
        mEntidad.USUARIO = USUARIO
 
        If mComponente.ObtenerUSUARIO(mEntidad) <> 1 Then
            RaiseEvent ErrorEvent("Error al obtener Registro.")
            Return
        End If
        Me.txtUSUARIO.Text = mEntidad.USUARIO
        Me.ddlPROVEEDOR_AF1.Recuperar()
        Me.ddlPROVEEDOR_AF1.AgregarVacioNumerico()
        Me.ddlPROVEEDOR_AF1.SelectedValue = mEntidad.ID_PROVEEDOR_AF
        Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
        Me.ddlSITIO_CAPACITACION1.AgregarVacioNumerico()
        Me.ddlSITIO_CAPACITACION1.SelectedValue = mEntidad.ID_SITIO_CAPACITACION
        Me.ddlPARTICIPANTE1.Recuperar()
        Me.ddlPARTICIPANTE1.AgregarVacioNumerico()
        Me.ddlPARTICIPANTE1.SelectedValue = mEntidad.ID_PARTICIPANTE
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
        Me.ddlPROVEEDOR_AF1.Enabled = edicion
        Me.ddlSITIO_CAPACITACION1.Enabled = edicion
        Me.ddlPARTICIPANTE1.Enabled = edicion
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
        Me.ddlPROVEEDOR_AF1.Recuperar()
        Me.ddlPROVEEDOR_AF1.AgregarVacioNumerico()
        Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
        Me.ddlSITIO_CAPACITACION1.AgregarVacioNumerico()
        Me.ddlPARTICIPANTE1.Recuperar()
        Me.ddlPARTICIPANTE1.AgregarVacioNumerico()
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Guarda la información del registro en la tabla USUARIO
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
        mEntidad = New USUARIO
        If Me.txtUSUARIO.Text = "0" Then
            Me.AsignarMensaje("Asigne un valor al Usuario que sea valido", True, True)
            Return "Error"
        End If
            mEntidad.USUARIO = Me.txtUSUARIO.Text
        mEntidad.ID_PROVEEDOR_AF = Me.ddlPROVEEDOR_AF1.SelectedValue
        mEntidad.ID_SITIO_CAPACITACION = Me.ddlSITIO_CAPACITACION1.SelectedValue
        mEntidad.ID_PARTICIPANTE = Me.ddlPARTICIPANTE1.SelectedValue

        If Me._nuevo Then
            If mComponente.AgregarUSUARIO(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
         Else
            If mComponente.ActualizarUSUARIO(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If
        Me.txtUSUARIO.Text = mEntidad.USUARIO.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function

    Protected Sub ddlPROVEEDOR_AF1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlPROVEEDOR_AF1.SelectedIndexChanged
        Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
        Me.ddlSITIO_CAPACITACION1.AgregarVacioNumerico()
    End Sub

    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick
        Me.MultiView1.ActiveViewIndex = Menu1.SelectedValue
    End Sub

End Class
