Imports DevExpress.Web

Partial Class controles_ucCriteriosSolicitudes
    Inherits ucBase

    <System.ComponentModel.DefaultValue(True)> _
    Public Property VerEstadoSolicitud() As Boolean
        Get
            Return Me.trEstadoSolicitud.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEstadoSolicitud.Visible = value
        End Set
    End Property

    <System.ComponentModel.DefaultValue(True)> _
    Public Property VerIDSolicitud() As Boolean
        Get
            Return Me.trIDSolicitud.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trIDSolicitud.Visible = value
        End Set
    End Property

    Public ReadOnly Property idSolicitud() As Decimal
        Get
            Dim _idSolicitud As Decimal = -1
            If Me.txtID_SOLICITUD.Text <> "" Then _idSolicitud = Convert.ToDecimal(Me.txtID_SOLICITUD.Text)
            Return _idSolicitud
        End Get
    End Property

    Public ReadOnly Property idProveedor() As Decimal
        Get
            If Me.cbxPROVEEDOR_AF.Value Is Nothing Then Return -1
            Return Convert.ToDecimal(Me.cbxPROVEEDOR_AF.Value)
        End Get
    End Property

    Public ReadOnly Property idSitioCapacitacion() As Decimal
        Get
            If Me.cbxSITIO_CAPACITACION.Value Is Nothing Then Return -1
            Return Convert.ToDecimal(Me.cbxSITIO_CAPACITACION.Value)
        End Get
    End Property


    Public ReadOnly Property idEstadoSolicitud() As Enumeradores.EstadoSolicitud
        Get
            If Me.cbxESTADO_SOLICITUD.Value Is Nothing Then Return -1
            Return Convert.ToInt32(Me.cbxESTADO_SOLICITUD.Value)
        End Get
    End Property

    Public ReadOnly Property nombreAccionFormativa() As String
        Get
            Return Me.txtNOMBRE_ACCION_FORMATIVA.Text
        End Get
    End Property

    Public ReadOnly Property codigoGrupo() As String
        Get
            Return Me.txtCODIGO_GRUPO.Text
        End Get
    End Property

    Public ReadOnly Property nombresSolicitante() As String
        Get
            Return Me.txtNOMBRES_SOLICITANTE.Text
        End Get
    End Property

    Public ReadOnly Property apellidosSolicitante() As String
        Get
            Return Me.txtAPELLIDOS_SOLICITANTE.Text
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    Private Sub CargarProveedores()
        Me.cbxPROVEEDOR_AF.DataBind()
    End Sub

    Private Sub CargarSitiosCapacitacion(ByVal ID_PROVEEDOR_AF As Decimal)
        Me.odsSitioCapacitacion.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF
        Me.cbxSITIO_CAPACITACION.DataBind()
    End Sub

    Private Sub CargarEstadoSolicitud()
        'Me.cbxESTADO_SOLICITUD.DataBind()
        Me.cbxESTADO_SOLICITUD.Items.Clear()
        Me.cbxESTADO_SOLICITUD.Items.Add(New ASPxEditors.ListEditItem("AUTORIZACION PARA INSCRIPCION", "1"))
        Me.cbxESTADO_SOLICITUD.Items.Add(New ASPxEditors.ListEditItem("SOLICITUD EN ESPERA DE APROBACION", "2"))
        Me.cbxESTADO_SOLICITUD.Items.Add(New ASPxEditors.ListEditItem("SOLICITUD APROBADA", "3"))
        Me.cbxESTADO_SOLICITUD.Items.Add(New ASPxEditors.ListEditItem("FINALIZADA", "4"))
        Me.cbxESTADO_SOLICITUD.Items.Add(New ASPxEditors.ListEditItem("RECHAZADA", "5"))
        Me.cbxESTADO_SOLICITUD.Items.Add(New ASPxEditors.ListEditItem("EN ESPERA DE CUPO", "6"))
        Me.cbxESTADO_SOLICITUD.Items.Add(New ASPxEditors.ListEditItem("ANULADA", "7"))
        If Me.EstaEnRol(RolDeUsuario.ProveedorPATI) Then
            Me.cbxESTADO_SOLICITUD.Items.Add(New ASPxEditors.ListEditItem("CAMBIO DE CURSO", "8"))
        End If
        Me.cbxESTADO_SOLICITUD.Items.Insert(0, New ASPxEditors.ListEditItem("[Todos]", "-1"))

        ''''
    End Sub

    Private Sub CargarEjercicio()
        Dim eEjercicioActual As EJERCICIO = (New cEJERCICIO).ObtenerEJERCICIOActual()

        Me.cbxEJERCICIO.DataBind()
        If eEjercicioActual IsNot Nothing Then
            If Me.cbxEJERCICIO.Items.FindByValue(eEjercicioActual.ID_EJERCICIO) IsNot Nothing Then
                Me.cbxEJERCICIO.Items.FindByValue(eEjercicioActual.ID_EJERCICIO).Selected = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' Configura el Control dependiendo del Rol del Usuario Conectado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos()
        CargarEstadoSolicitud()
        CargarEjercicio()

        Me.cbxESTADO_SOLICITUD.SelectedIndex = 0
        If Not Me.EstaEnRol(RolDeUsuario.Administrador) Then
            If Me.EstaEnRol(RolDeUsuario.Proveedor) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPATI) OrElse _
                Me.EstaEnRol(RolDeUsuario.ProveedorPROYESPECIAL) OrElse _
                 Me.EstaEnRol(RolDeUsuario.ProveedorFacturacionPROYESPECIAL) Then
                CargarProveedores()
                If cbxPROVEEDOR_AF.Items.FindByValue(Me.ObtenerIdProveedorAF().ToString) IsNot Nothing Then cbxPROVEEDOR_AF.Items.FindByValue(Me.ObtenerIdProveedorAF().ToString).Selected = True
                CargarSitiosCapacitacion(Me.cbxPROVEEDOR_AF.Value)
                Me.cbxSITIO_CAPACITACION.Items.Insert(0, New ASPxEditors.ListEditItem("[Todos]", "-1"))
                Me.cbxSITIO_CAPACITACION.SelectedIndex = 0

                Me.lblProveedor.ClientVisible = False
                Me.cbxPROVEEDOR_AF.ClientVisible = False
                Me.lblCentro.ClientVisible = Not ((Me.EstaEnRol(RolDeUsuario.ProveedorPATI) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPROYESPECIAL)) AndAlso Not Me.EstaEnRol(RolDeUsuario.Proveedor))
                Me.cbxSITIO_CAPACITACION.ClientVisible = Me.lblCentro.ClientVisible

                cbxPROVEEDOR_AF.ClientEnabled = False
            End If
            If Me.EstaEnRol(RolDeUsuario.CentroCapacitador) Then
                CargarProveedores()
                If cbxPROVEEDOR_AF.Items.FindByValue(Me.ObtenerIdProveedorAF().ToString) IsNot Nothing Then cbxPROVEEDOR_AF.Items.FindByValue(Me.ObtenerIdProveedorAF().ToString).Selected = True
                CargarSitiosCapacitacion(Me.cbxPROVEEDOR_AF.Value)
                If cbxSITIO_CAPACITACION.Items.FindByValue(Me.ObtenerIdSitioCapacitacion().ToString) IsNot Nothing Then cbxSITIO_CAPACITACION.Items.FindByValue(Me.ObtenerIdSitioCapacitacion().ToString).Selected = True

                Me.lblProveedor.ClientVisible = False
                Me.cbxPROVEEDOR_AF.ClientVisible = False
                Me.lblCentro.ClientVisible = False
                Me.cbxSITIO_CAPACITACION.ClientVisible = False
                Return
            End If
            If Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP) OrElse Me.EstaEnRol(RolDeUsuario.JefeHTP) OrElse Me.EstaEnRol(RolDeUsuario.AsistenteGFI) OrElse Me.EstaEnRol(RolDeUsuario.GerenteGFI) Then
                CargarProveedores()
                Me.cbxPROVEEDOR_AF.Items.Insert(0, New ASPxEditors.ListEditItem("[Todos]", "-1"))
                Me.cbxPROVEEDOR_AF.SelectedIndex = 0

                CargarSitiosCapacitacion(Me.cbxPROVEEDOR_AF.Value)
                Me.cbxSITIO_CAPACITACION.Items.Insert(0, New ASPxEditors.ListEditItem("[Todos]", "-1"))
                Me.cbxSITIO_CAPACITACION.SelectedIndex = 0
                Return
            End If
            Return
        End If

        CargarProveedores()
        Me.cbxPROVEEDOR_AF.Items.Insert(0, New ASPxEditors.ListEditItem("[Todos]", "-1"))
        Me.cbxPROVEEDOR_AF.SelectedIndex = 0
        CargarSitiosCapacitacion(Me.cbxPROVEEDOR_AF.Value)
        Me.cbxSITIO_CAPACITACION.Items.Insert(0, New ASPxEditors.ListEditItem("[Todos]", "-1"))
        Me.cbxSITIO_CAPACITACION.SelectedIndex = 0
    End Sub

    Protected Sub cbxSITIO_CAPACITACION_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cbxSITIO_CAPACITACION.Callback
        CargarSitiosCapacitacion(e.Parameter)
    End Sub
End Class
