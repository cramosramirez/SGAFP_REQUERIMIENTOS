Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucVistaDetalleACCION_FORMATIVA_SEGUI
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para mostrar en tiempo de edicion un registro
''' de la tabla ACCION_FORMATIVA_SEGUI
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, CarÃ­as y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/02/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucVistaDetalleACCION_FORMATIVA_SEGUI
    Inherits ucBase
 
#Region"Propiedades"

    Private _ID_ACCION_FORMATIVA_SEGUI As Decimal
    Public Property ID_ACCION_FORMATIVA_SEGUI() As Decimal
        Get
            Return Me.txtID_ACCION_FORMATIVA_SEGUI.Text
        End Get
        Set(ByVal Value As Decimal)
            Me._ID_ACCION_FORMATIVA_SEGUI = Value
            Me.txtID_ACCION_FORMATIVA_SEGUI.Text = CStr(Value)
            If Me._ID_ACCION_FORMATIVA_SEGUI > 0 Then
                Me.CargarDatos()
            End If
        End Set
    End Property

    Public Property ID_ACCION_FORMATIVA() As Decimal
        Get
            If Me.ViewState("ID_ACCION_FORMATIVA") IsNot Nothing Then
                Return CDec(Me.ViewState("ID_ACCION_FORMATIVA"))
            Else
                Return -1
            End If
        End Get
        Set(ByVal value As Decimal)
            Me.txtID_ACCION_FORMATIVA.Text = value
            Me.ViewState("ID_ACCION_FORMATIVA") = value
            Me.CargarDatosCurso()
        End Set
    End Property

    Private Property Nuevo As Boolean
        Get
            If Me.ViewState("Nuevo") Is Nothing Then
                Return True
            Else
                Return CBool(Me.ViewState("Nuevo"))
            End If
        End Get
        Set(value As Boolean)
            Me.ViewState("Nuevo") = value
        End Set
    End Property

    Private _Enabled As Boolean = True
    Private _sError As String
    Private _nuevo As Boolean = False
    Private mComponente As New cACCION_FORMATIVA_SEGUI
    Private mEntidad As ACCION_FORMATIVA_SEGUI
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
        'Introducir aquÃ­ el cÃ³digo de usuario para inicializar la pÃ¡gina
        If Not Me.ViewState("nuevo") Is Nothing Then Me._nuevo = Me.ViewState("nuevo")
        If Not Me.ViewState("ID_ACCION_FORMATIVA_SEGUI") Is Nothing Then Me._ID_ACCION_FORMATIVA_SEGUI = Me.ViewState("ID_ACCION_FORMATIVA_SEGUI")

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Carga la informaciÃ³n del registro de la tabla ACCION_FORMATIVA_SEGUI
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub CargarDatosCurso()
        Dim lProveedor As PROVEEDOR_AF
        Dim lUsuario As USUARIO = (New cUSUARIO).ObtenerUSUARIO(Me.ObtenerUsuario)
        Dim lAccion As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(Me.ID_ACCION_FORMATIVA)

        Me.Nuevo = True

        Me.txtID_ACCION_FORMATIVA_SEGUI.Text = ""
        Me.deFECHA_VISITA.Value = Nothing
        Me.txtOBSERVACION.Text = ""
        Me.txtCOMENTARIO_ADMIN_PROGRA.Text = ""

        If lAccion IsNot Nothing Then
            lProveedor = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lAccion.ID_PROVEEDOR_AF)

            Me.txtPROVEEDOR_AF.Text = lProveedor.NOMBRE_PROVEEDOR
            Me.txtNOMBRE_ACCION_FORMATIVA.Text = lAccion.NOMBRE_ACCION_FORMATIVA
            Me.txtCODIGO_GRUPO.Text = lAccion.CODIGO_GRUPO
        End If
        If lUsuario IsNot Nothing Then
            Me.txtUSUARIO_CREACION.Text = lUsuario.NOMBRE
        End If
        Me.HabilitarEdicion(True)
        Me.deFECHA_CREACION.Date = Now
    End Sub

    Private Sub CargarDatos()
        Dim lSeguimiento As ACCION_FORMATIVA_SEGUI = (New cACCION_FORMATIVA_SEGUI).ObtenerACCION_FORMATIVA_SEGUI(CInt(Me.txtID_ACCION_FORMATIVA_SEGUI.Text))

        Me.Nuevo = False
        If lSeguimiento IsNot Nothing Then
            Dim lAccion As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lSeguimiento.ID_ACCION_FORMATIVA)
            Dim lProveedor As PROVEEDOR_AF
            Dim lUsuario As USUARIO = (New cUSUARIO).ObtenerUSUARIO(lSeguimiento.USUARIO_CREACION)

            Me.txtID_ACCION_FORMATIVA.Text = lSeguimiento.ID_ACCION_FORMATIVA
            If lAccion IsNot Nothing Then
                lProveedor = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lAccion.ID_PROVEEDOR_AF)
                If lProveedor IsNot Nothing Then Me.txtPROVEEDOR_AF.Text = lProveedor.NOMBRE_PROVEEDOR
                Me.txtNOMBRE_ACCION_FORMATIVA.Text = lAccion.NOMBRE_ACCION_FORMATIVA
                Me.txtCODIGO_GRUPO.Text = lAccion.CODIGO_GRUPO
            End If
            Me.deFECHA_VISITA.Date = lSeguimiento.FECHA_VISITA
            Me.txtOBSERVACION.Text = lSeguimiento.OBSERVACION
            Me.txtCOMENTARIO_ADMIN_PROGRA.Text = lSeguimiento.COMENTARIO_ADMIN_PROGRA
            If lUsuario IsNot Nothing Then Me.txtUSUARIO_CREACION.Text = lUsuario.NOMBRE
            Me.deFECHA_CREACION.Date = lSeguimiento.FECHA_CREACION
        End If
        Me.HabilitarEdicion(False)
        If Me.EstaEnRol(RolDeUsuario.GerenteGFI) OrElse Me.EstaEnRol(RolDeUsuario.CoordinadorGFI) OrElse Me.EstaEnRol(RolDeUsuario.CoordinadorECentro) Then
            Me.txtCOMENTARIO_ADMIN_PROGRA.ClientEnabled = True
        End If
    End Sub
 
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que permite Habilitar/Deshabilitar el uso de los controles contenidos
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub HabilitarEdicion(ByVal edicion As Boolean)
        Me.txtPROVEEDOR_AF.ClientEnabled = False
        Me.txtID_ACCION_FORMATIVA_SEGUI.ClientEnabled = False
        Me.txtID_ACCION_FORMATIVA.ClientEnabled = False
        Me.txtNOMBRE_ACCION_FORMATIVA.ClientEnabled = False
        Me.txtCODIGO_GRUPO.ClientEnabled = False
        Me.ddlUNIDAD_ORGANIZATIVAID_UNIDAD_ORGANIZATIVA.Enabled = edicion
        Me.deFECHA_VISITA.ClientEnabled = edicion
        Me.txtOBSERVACION.ClientEnabled = edicion
        Me.txtCOMENTARIO_ADMIN_PROGRA.ClientEnabled = False
        Me.txtUSUARIO_CREACION.ClientEnabled = False
        Me.deFECHA_CREACION.ClientEnabled = False
    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' FunciÃ³n que Guarda la informaciÃ³n del registro en la tabla ACCION_FORMATIVA_SEGUI
    ''' </summary>
    ''' <returns>
    ''' ""                              : Si no existe error
    ''' "Error al Guardar registro."    : Si existe error al momento de Guardar el 
    '''                                   Registro en la base de datos
    ''' </returns>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function Actualizar() As String
        Dim sError As New String("")
        Dim alDatos As New ArrayList
        mEntidad = New ACCION_FORMATIVA_SEGUI
        If Me.Nuevo Then
            mEntidad.ID_ACCION_FORMATIVA_SEGUI = 0
        Else
            mEntidad = (New cACCION_FORMATIVA_SEGUI).ObtenerACCION_FORMATIVA_SEGUI(CInt(Me.txtID_ACCION_FORMATIVA_SEGUI.Text))
        End If

        If Me.deFECHA_VISITA.Value Is Nothing Then
            Return "Ingrese la fecha de la visita"
        End If

        If Me.deFECHA_VISITA.Date > Today Then
            Return "La fecha de la visita no puede ser mayor que la fecha actual"
        End If

        If Me.txtOBSERVACION.Text.Trim = "" Then
            Return "Ingrese la observacion de la visita"
        End If

        mEntidad.ID_ACCION_FORMATIVA = Me.ID_ACCION_FORMATIVA
        mEntidad.FECHA_VISITA = Me.deFECHA_VISITA.Value
        mEntidad.OBSERVACION = Strings.Left(Me.txtOBSERVACION.Text.Trim.ToUpper, 1000)
        mEntidad.COMENTARIO_ADMIN_PROGRA = Strings.Left(Me.txtCOMENTARIO_ADMIN_PROGRA.Text.Trim.ToUpper, 1000)
        mEntidad.ID_UNIDAD_ORGANIZATIVA = -1
        mEntidad.USUARIO_CREACION = Me.ObtenerUsuario
        mEntidad.FECHA_CREACION = Now


        If Me.Nuevo OrElse _
            (Not Me.Nuevo AndAlso (Me.EstaEnRol(RolDeUsuario.GerenteGFI) OrElse Me.EstaEnRol(RolDeUsuario.CoordinadorGFI) OrElse Me.EstaEnRol(RolDeUsuario.CoordinadorECentro))) Then
            If mComponente.ActualizarACCION_FORMATIVA_SEGUI(mEntidad) <> 1 Then
                Me.AsignarMensaje("Error al Guardar registro.", True, True)
                Return "Error al Guardar registro."
            End If
        End If

        Me.txtID_ACCION_FORMATIVA_SEGUI.Text = mEntidad.ID_ACCION_FORMATIVA_SEGUI.ToString()
        Me._nuevo = False
        If Not Me.ViewState("nuevo") Is Nothing Then Me.ViewState.Remove("nuevo")
        Me.ViewState.Add("nuevo", Me._nuevo)
        Return ""
    End Function
End Class
