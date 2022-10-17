
Partial Class controles_ucCriteriosAccionFormativaReprog
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

    <System.ComponentModel.DefaultValue(False)> _
    Public Property VerTDR() As Boolean
        Get
            Return Me.TDRTextBox.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.TDRTextBox.Visible = value
            Me.Label_TDR.Visible = value
        End Set
    End Property

    Public ReadOnly Property tdr() As String
        Get
            Return TDRTextBox.Text
        End Get
    End Property

    'Public Property VerCentroFormacion() As Boolean
    '    Get
    '        Return Me.trCentroFormacion.Visible
    '    End Get
    '    Set(ByVal value As Boolean)
    '        Me.trCentroFormacion.Visible = value
    '    End Set
    'End Property

    '<System.ComponentModel.DefaultValue(True), _
    'System.ComponentModel.Description("Permite Ver/Ocultar el Criterio de Estado")> _
    'Public Property VerSitioCapacitacion() As Boolean
    '    Get
    '        Return Me.trSitioCapacitacion.Visible
    '    End Get
    '    Set(ByVal value As Boolean)
    '        Me.trSitioCapacitacion.Visible = value
    '    End Set
    'End Property

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

        If Not Me.EstaEnRol("Administrador") Then

            If Me.EstaEnRol(RolDeUsuario.GerenteGFI) OrElse Me.EstaEnRol(RolDeUsuario.CoordinadorGFI) OrElse Me.EstaEnRol(RolDeUsuario.SoporteGFI) OrElse Me.EstaEnRol(RolDeUsuario.TecnicoGFIPATI) Then
                Me.ddlPROVEEDOR_AF1.Recuperar()
                Me.ddlPROVEEDOR_AF1.AgregarTodosNumerico()
                Me.ddlPROVEEDOR_AF1.SelectedValue = -1
                Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
                Me.ddlSITIO_CAPACITACION1.AgregarTodosNumerico()
                Me.ddlSITIO_CAPACITACION1.SelectedValue = -1
                Me.ddlESTADO_REPROG1.Recuperar()
                Me.ddlESTADO_REPROG1.SelectedValue = SGAFP.EL.Enumeradores.EstadoReprogramaciones.Solicitada

                If Me.EstaEnRol(RolDeUsuario.TecnicoGFIPATI) Then
                    Me.VerTDR = True
                Else
                    Me.VerTDR = False
                End If
                Return
            End If

        End If

        Me.ddlPROVEEDOR_AF1.Recuperar()
        Me.ddlPROVEEDOR_AF1.AgregarTodosNumerico()
        Me.ddlPROVEEDOR_AF1.SelectedValue = -1

        Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
        Me.ddlSITIO_CAPACITACION1.AgregarTodosNumerico()
        Me.ddlSITIO_CAPACITACION1.SelectedValue = -1

        Me.ddlEJERCICIO1.Recuperar()
        Me.ddlEJERCICIO1.AgregarTodosCadena()
        Me.ddlEJERCICIO1.SelectedValue = ""

        Me.ddlESTADO_REPROG1.Recuperar()
        Me.ddlESTADO_REPROG1.SelectedValue = SGAFP.EL.Enumeradores.EstadoAccionFormativa.Ingresada

        Me.trCentroFormacion.Visible = True
        Me.trSitioCapacitacion.Visible = True
        Me.trEjercicio.Visible = True
    End Sub

    Protected Sub ddlPROVEEDOR_AF1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ddlPROVEEDOR_AF1.SelectedIndexChanged
        If Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP) Then
            Me.ddlSITIO_CAPACITACION1.RecuperarPorTECNICO(Me.ddlPROVEEDOR_AF1.SelectedValue, Me.ObtenerUsuario())
            Me.ddlSITIO_CAPACITACION1.AgregarTodosNumerico()
            Me.ddlSITIO_CAPACITACION1.SelectedValue = -1
        Else
            Me.ddlSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.ddlPROVEEDOR_AF1.SelectedValue)
            Me.ddlSITIO_CAPACITACION1.AgregarTodosNumerico()
            Me.ddlSITIO_CAPACITACION1.SelectedValue = -1
        End If
    End Sub

    ''' <summary>
    ''' Setea el Ejercicio Actual en DropDowList Ejercicio
    ''' </summary>
    ''' <remarks></remarks>
    Sub SeleccionarEjercicioActual()
        Dim eEjercicioActual As EJERCICIO = (New cEJERCICIO).ObtenerEJERCICIOActual()
        If eEjercicioActual IsNot Nothing AndAlso Me.ddlEJERCICIO1.Items.FindByValue(eEjercicioActual.ID_EJERCICIO) IsNot Nothing Then
            Me.ddlEJERCICIO1.SelectedValue = eEjercicioActual.ID_EJERCICIO
        End If
    End Sub

#Region "ImplementacionAdicional"
    <System.ComponentModel.DefaultValue(False), _
    System.ComponentModel.Description("Permite Ver/Ocultar el Estado de la Acción Formativa Reprogramada")> _
    Public Property VerEstado() As Boolean
        Get
            Return Me.trEstado.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trEstado.Visible = value
        End Set
    End Property

    <System.ComponentModel.DefaultValue(True), _
    System.ComponentModel.Description("Permite Ver/Ocultar el Código de Grupo de la Acción Formativa Reprogramada")> _
    Public Property VerCodigoGrupo() As Boolean
        Get
            Return Me.trCodigoGrupo.Visible
        End Get
        Set(ByVal value As Boolean)
            Me.trCodigoGrupo.Visible = value
        End Set
    End Property

    Public ReadOnly Property idEstadoAccionReprog() As Decimal
        Get
            If Me.ddlESTADO_REPROG1.SelectedValue = "" Then Return -1
            Return Convert.ToDecimal(Me.ddlESTADO_REPROG1.SelectedValue)
        End Get
    End Property

#End Region

End Class
