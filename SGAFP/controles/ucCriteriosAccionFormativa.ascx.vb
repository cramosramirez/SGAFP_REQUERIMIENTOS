
Partial Class controles_ucCriteriosAccionFormativa
    Inherits ucBase

    <System.ComponentModel.DefaultValue(False)> _
    Public Property VerEjercicio() As Boolean
        Get
            Return Me.trEjercicio.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEjercicio.Visible = value
        End Set
    End Property

    <System.ComponentModel.DefaultValue(False)> _
    Public Property VerAreaFormacion() As Boolean
        Get
            Return Me.trAreaFormacion.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trAreaFormacion.Visible = value
        End Set
    End Property

    <System.ComponentModel.DefaultValue(True)> _
    Public Property EsConsulta() As Boolean
        Get
            If Me.ViewState("EsConsulta") Is Nothing Then Return True
            Return Me.ViewState("EsConsulta")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("EsConsulta") = value
        End Set
    End Property


    Public Property EsInforme() As Boolean
        Get
            If Me.ViewState("EsInforme") Is Nothing Then Return False
            Return Me.ViewState("EsInforme")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("EsInforme") = value
        End Set
    End Property


    Public ReadOnly Property idEjercicio() As String
        Get
            Return Me.ddlEJERCICIO1.SelectedValue
        End Get
    End Property

    Public ReadOnly Property idProveedor() As Decimal
        Get
            If Me.ddlPROVEEDOR_AF1.SelectedValue = "" Then Return -1
            Return Convert.ToDecimal(Me.ddlPROVEEDOR_AF1.SelectedValue)
        End Get
    End Property

    Public ReadOnly Property idSitioCapacitacion() As Decimal
        Get
            If Me.ddlSITIO_CAPACITACION1.SelectedValue = "" Then Return -1
            Return Convert.ToDecimal(Me.ddlSITIO_CAPACITACION1.SelectedValue)
        End Get
    End Property

    Public ReadOnly Property idAreaFormacion() As Decimal
        Get
            If Me.ddlAREA_FORMACION1.SelectedValue = "" Then Return -1
            Return Convert.ToDecimal(Me.ddlAREA_FORMACION1.SelectedValue)
        End Get
    End Property

    Public ReadOnly Property nombreAccionFormativa() As String
        Get
            Return NOMBRE_CURSOTextBox.Text
        End Get
    End Property

    Public ReadOnly Property codigoGrupo() As String
        Get
            Return CODIGO_GRUPOTextBox.Text
        End Get
    End Property

    Public ReadOnly Property tdr() As String
        Get
            Return TDRTextBox.Text
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    ''' <summary>
    ''' Configura el Control dependiendo del Rol del Usuario Conectado
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CargarDatos()
        Me.ddlAREA_FORMACION1.Recuperar()
        Me.ddlAREA_FORMACION1.AgregarTodosNumerico()
        Me.ddlAREA_FORMACION1.SelectedValue = -1

        Me.ddlEJERCICIO1.Recuperar()
        SeleccionarEjercicioActual()

        If Not Me.EstaEnRol(RolDeUsuario.Administrador) Then
            Me.Label_TDR.Visible = True
            Me.TDRTextBox.Visible = True

            If Me.EstaEnRol(RolDeUsuario.Auditor) OrElse Me.EstaEnRol(RolDeUsuario.AuditorUMEFP) OrElse Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP) OrElse Me.EstaEnRol(RolDeUsuario.TecnicoGFIPATI) OrElse Me.EstaEnRol(RolDeUsuario.TecnicoPROYESPECIAL) OrElse Me.EstaEnRol(RolDeUsuario.JefeHTP) OrElse Me.EstaEnRol(RolDeUsuario.AsistenteGFI) OrElse Me.EstaEnRol(RolDeUsuario.GerenteGFI) OrElse _
                Me.EstaEnRol(RolDeUsuario.CARecepcion) OrElse Me.EstaEnRol(RolDeUsuario.CAGestion) OrElse Me.EstaEnRol(RolDeUsuario.CARevision) OrElse Me.EstaEnRol(RolDeUsuario.SoporteGFI) OrElse Me.EstaEnRol(RolDeUsuario.GerenteGFI) OrElse Me.EstaEnRol(RolDeUsuario.CoordinadorGFI) Then
                Me.ddlPROVEEDOR_AF1.Recuperar()
                Me.ddlPROVEEDOR_AF1.AgregarTodosNumerico()
                Me.ddlPROVEEDOR_AF1.SelectedValue = -1
                Me.ddlSITIO_CAPACITACION1.AgregarTodosNumerico()
                Me.ddlSITIO_CAPACITACION1.SelectedValue = -1

                Me.ddlESTADO_ACCION_FORMATIVA1.RecuperarParaCalendarizacion()
                Me.ddlESTADO_ACCION_FORMATIVA1.SelectedValue = SGAFP.EL.Enumeradores.EstadoAccionFormativa.Ingresada

                If EsInforme Then
                    Me.ddlESTADO_INFORME_AF1.RecuperarEstadosPorRol()
                    Me.ddlESTADO_INFORME_AF1.SelectedValue = -1
                    Me.trEstadoInforme.Visible = True
                End If
                Return
            End If

            If Me.EstaEnRol(RolDeUsuario.Proveedor) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPATI) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPROYESPECIAL) Then
                Me.ddlPROVEEDOR_AF1.Recuperar()
                Me.ddlPROVEEDOR_AF1.SelectedValue = Me.ObtenerIdProveedorAF()
                If Not Me.EstaEnRol(RolDeUsuario.CentroCapacitador) Then
                    Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
                    Me.ddlSITIO_CAPACITACION1.AgregarTodosNumerico()
                    Me.ddlSITIO_CAPACITACION1.SelectedValue = -1
                End If
                Me.ddlESTADO_ACCION_FORMATIVA1.RecuperarParaCalendarizacion()
                Me.ddlESTADO_ACCION_FORMATIVA1.SelectedValue = SGAFP.EL.Enumeradores.EstadoAccionFormativa.Ingresada
                Me.trProveedor.Visible = False
                Me.trCentroFormacion.Visible = Not (Me.EstaEnRol(RolDeUsuario.ProveedorPATI) AndAlso Not Me.EstaEnRol(RolDeUsuario.Proveedor) AndAlso Not Me.EstaEnRol(RolDeUsuario.Administrador))
                Me.trEjercicio.Visible = True
            End If

            If Me.EstaEnRol(RolDeUsuario.CentroCapacitador) Then
                Dim idCentroFormacion As Decimal = Me.ObtenerIdSitioCapacitacion()
                Me.ddlPROVEEDOR_AF1.Recuperar()
                Me.ddlPROVEEDOR_AF1.SelectedValue = Me.ObtenerIdProveedorAF()

                If idCentroFormacion > 0 Then
                    Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
                    Me.ddlSITIO_CAPACITACION1.SelectedValue = Me.ObtenerIdSitioCapacitacion()
                End If
                Me.ddlESTADO_ACCION_FORMATIVA1.RecuperarParaCalendarizacion()
                Me.ddlESTADO_ACCION_FORMATIVA1.SelectedValue = SGAFP.EL.Enumeradores.EstadoAccionFormativa.Ingresada
                Me.trProveedor.Visible = False
                Me.trCentroFormacion.Visible = False
                Me.trEjercicio.Visible = True
            End If

            If Me.EstaEnRol(RolDeUsuario.ColaboradorUACIPATI) OrElse Me.EstaEnRol(RolDeUsuario.ColaboradorUACIPROYESPECIAL) Then
                Me.ddlPROVEEDOR_AF1.Recuperar()
                Me.ddlPROVEEDOR_AF1.SelectedValue = Me.ObtenerIdProveedorAF()
                Me.ddlESTADO_ACCION_FORMATIVA1.RecuperarParaCalendarizacion()
                Me.ddlESTADO_ACCION_FORMATIVA1.SelectedValue = SGAFP.EL.Enumeradores.EstadoAccionFormativa.Ingresada
                Me.trCentroFormacion.Visible = False
                Me.trAreaFormacion.Visible = False
                Me.ddlAREA_FORMACION1.Visible = False
                Me.NOMBRE_CURSOTextBox.Visible = False
            End If

            Return
        Else
            

            If EsInforme Then
                Me.ddlESTADO_INFORME_AF1.Recuperar()
                Me.ddlESTADO_INFORME_AF1.SelectedValue = -1
                Me.trEstadoInforme.Visible = True
            End If

        End If

        Me.ddlPROVEEDOR_AF1.Recuperar()
        Me.ddlPROVEEDOR_AF1.AgregarTodosNumerico()
        Me.ddlPROVEEDOR_AF1.SelectedValue = -1

        Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
        Me.ddlSITIO_CAPACITACION1.AgregarTodosNumerico()
        Me.ddlSITIO_CAPACITACION1.SelectedValue = -1

        Me.ddlEJERCICIO1.Recuperar()
        SeleccionarEjercicioActual()

        Me.ddlESTADO_ACCION_FORMATIVA1.RecuperarParaCalendarizacion()
        Me.ddlESTADO_ACCION_FORMATIVA1.SelectedValue = SGAFP.EL.Enumeradores.EstadoAccionFormativa.Ingresada

        Me.trProveedor.Visible = True
        Me.trCentroFormacion.Visible = Me.VerCentroFormacion

        Me.Label_TDR.Visible = Not VerSoloCodigoGrupo
        Me.TDRTextBox.Visible = Not VerSoloCodigoGrupo


    End Sub

    Protected Sub ddlPROVEEDOR_AF1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlPROVEEDOR_AF1.SelectedIndexChanged
        If Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP) And Me.FiltrarSitioPorTecnico Then
            Me.ddlSITIO_CAPACITACION1.RecuperarPorTECNICO(Me.ddlPROVEEDOR_AF1.SelectedValue, Me.ObtenerUsuario())
        Else
            Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
        End If
        Me.ddlSITIO_CAPACITACION1.AgregarTodosNumerico()
        Me.ddlSITIO_CAPACITACION1.SelectedValue = -1
    End Sub

#Region "ImplementacionAdicional"
    <System.ComponentModel.DefaultValue(False), _
    System.ComponentModel.Description("Permite Ver/Ocultar el Estado de la Acción Formativa")> _
    Public Property VerEstado() As Boolean
        Get
            Return Me.trEstado.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEstado.Visible = value
        End Set
    End Property

    <System.ComponentModel.DefaultValue(False), _
   System.ComponentModel.Description("Permite Ver/Ocultar el Estado del Informe de Ejecución")> _
    Public Property VerEstadoInforme() As Boolean
        Get
            Return Me.trEstadoInforme.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEstadoInforme.Visible = value
        End Set
    End Property

    <System.ComponentModel.DefaultValue(False), _
  System.ComponentModel.Description("Permite Ver/Ocultar el Contrato / Licitación")> _
    Public Property VerContratoLicitacion() As Boolean
        Get
            Return Me.trContratoLici.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trContratoLici.Visible = value
        End Set
    End Property


    <System.ComponentModel.DefaultValue(False), _
  System.ComponentModel.Description("Permite Ver/Ocultar el Centro de Formación")> _
    Public Property VerCentroFormacion() As Boolean
        Get
            If Me.ViewState("VerCentroFormacion") IsNot Nothing Then
                Return Me.ViewState("VerCentroFormacion")
            Else
                Return False
            End If
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("VerCentroFormacion") = value
            Me.trCentroFormacion.Visible = value
        End Set
    End Property


    <System.ComponentModel.DefaultValue(True), _
    System.ComponentModel.Description("Permite Ver/Ocultar el Código de Grupo de la Acción Formativa")> _
    Public Property VerCodigoGrupo() As Boolean
        Get
            Return Me.trCodigoGrupo.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCodigoGrupo.Visible = value
        End Set
    End Property

    <System.ComponentModel.DefaultValue(True), _
    System.ComponentModel.Description("Permite Ver/Ocultar el Código de Grupo de la Acción Formativa")> _
    Public Property VerSoloCodigoGrupo() As Boolean
        Get
            If Me.ViewState("VerSoloCodigoGrupo") IsNot Nothing Then
                Return Me.ViewState("VerSoloCodigoGrupo")
            Else
                Return False
            End If

        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("VerSoloCodigoGrupo") = value
            Me.trCodigoGrupo.Visible = value
            Label_TDR.Visible = Not value
            TDRTextBox.Visible = Not value
        End Set
    End Property

    Public ReadOnly Property idEstadoAccion() As String
        Get
            Return Me.ddlESTADO_ACCION_FORMATIVA1.SelectedValue
        End Get
    End Property

    Public ReadOnly Property NumContrato() As String
        Get
            Return Me.txtNUM_CONTRATO.Text.Trim
        End Get
    End Property

    Public ReadOnly Property idEstadoInformeFinal() As Decimal
        Get
            Return CDec(Me.ddlESTADO_INFORME_AF1.SelectedValue)
        End Get
    End Property

    <System.ComponentModel.DefaultValue(False), _
    System.ComponentModel.Description("Permite que se aplique un filtro a los Sitios de Capacitacion Asignados al Tecnico conectado")> _
    Public Property FiltrarSitioPorTecnico() As Boolean
        Get
            If Me.ViewState("FiltrarSitioPorTecnico") Is Nothing Then Return False
            Return Me.ViewState("FiltrarSitioPorTecnico")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("FiltrarSitioPorTecnico") = value
        End Set
    End Property

    Sub SeleccionarEjercicioActual()
        Dim eEjercicioActual As EJERCICIO = (New cEJERCICIO).ObtenerEJERCICIOActual()
        If eEjercicioActual IsNot Nothing AndAlso Me.ddlEJERCICIO1.Items.FindByValue(eEjercicioActual.ID_EJERCICIO) IsNot Nothing Then
            Me.ddlEJERCICIO1.SelectedValue = eEjercicioActual.ID_EJERCICIO
        End If
    End Sub

#End Region


End Class
