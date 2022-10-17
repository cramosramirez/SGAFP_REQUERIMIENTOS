Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantPAQUETE_INFORME
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla PAQUETE_INFORME
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/08/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantPAQUETE_INFORME
    Inherits ucBase



    Public Sub CargarDatos()
        Me.ucBarraNavegacion1.LimpiarOpciones()
        Me.ucBarraNavegacion1.CrearOpcion("AgregarPaquete", "Agregar", False, "~/imagenes/Nuevo.gif")
        Me.ucBarraNavegacion1.CrearOpcion("GuardarPaquete", "Guardar", False, "~/imagenes/ButtonSave.png")
        Me.ucBarraNavegacion1.CrearOpcion("BuscarPaquetes", "Buscar Paquetes", False, "~/imagenes/ButtonSearch.png")
        Me.ucBarraNavegacion1.CrearOpcion("AgregarInforme", "Agregar Informe", False, "~/imagenes/Agregar.gif")
        Me.ucBarraNavegacion1.CrearOpcion("EnVoBo", "Dar VoBo Informe", False, "~/imagenes/ButtonSearch.png")
        Me.ucBarraNavegacion1.CrearOpcion("AprobarInforme", "Aprobar Informe", False, "~/imagenes/SolicitudAprobada.gif")
        Me.ucBarraNavegacion1.CargarOpciones()

        Select Case True
            Case EstaEnRol(RolDeUsuario.TecnicoCentroHTP)
                Me.ucBarraNavegacion1.VerOpcion("AgregarPaquete", True)

            Case EstaEnRol(RolDeUsuario.JefeHTP), EstaEnRol(RolDeUsuario.GerenteGFI)
                Me.ucBarraNavegacion1.VerOpcion("AgregarPaquete", False)

        End Select
        Me.ucListaPAQUETE_INFORME1.PermitirEliminar = EstaEnRol(RolDeUsuario.TecnicoCentroHTP)

        Me.ucBarraNavegacion1.VerOpcion("GuardarPaquete", False)
        Me.ucBarraNavegacion1.VerOpcion("AgregarInforme", False)
        Me.ucBarraNavegacion1.VerOpcion("EnVoBo", False)
        Me.ucBarraNavegacion1.VerOpcion("AprobarInforme", False)
    End Sub

    Private ReadOnly Property IdPaquete() As Decimal
        Get
            If Me.ViewState("idPaquete") Is Nothing Then Return 0
            Return Me.ViewState("idPaquete")
        End Get
    End Property

    Private Function CargarPAQUETE_INFORME() As Integer
        If Me.ucListaPAQUETE_INFORME1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    Private Sub ucVistaDetallePAQUETE_INFORME1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetallePAQUETE_INFORME1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick
        Me.MultiView1.ActiveViewIndex = Int32.Parse(e.Item.Value)
        ConfigurarMenu(e.Item.Text)
    End Sub

    Private Sub ConfigurarMenu(ByVal nombreMenu As String)
        Me.ucBarraNavegacion1.VerOpcion("AgregarPaquete", False)
        Me.ucBarraNavegacion1.VerOpcion("GuardarPaquete", False)
        Me.ucBarraNavegacion1.VerOpcion("BuscarPaquetes", False)
        Me.ucBarraNavegacion1.VerOpcion("AgregarInforme", False)
        Me.ucBarraNavegacion1.VerOpcion("EnVoBo", False)
        Me.ucBarraNavegacion1.VerOpcion("AprobarInforme", False)

        If nombreMenu = "Nuevo Paquete" Then
            Me.ucBarraNavegacion1.VerOpcion("GuardarPaquete", True)
            Return
        End If

        If nombreMenu = "Informes" Then
            If Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP) Then
                If Me.IdPaquete > 0 Then
                    Me.ucBarraNavegacion1.VerOpcion("AgregarInforme", False)
                Else
                    Me.ucVistaDetallePAQUETE_INFORME1.LimpiarControles()
                    Me.ucVistaDetallePAQUETE_INFORME1.Visible = False
                    Me.ucBarraNavegacion1.VerOpcion("AgregarInforme", False)
                End If

            ElseIf Me.EstaEnRol(RolDeUsuario.JefeHTP) Then
                Me.ucBarraNavegacion1.VerOpcion("EnVoBo", True)

            ElseIf Me.EstaEnRol(RolDeUsuario.GerenteGFI) Then
                Me.ucBarraNavegacion1.VerOpcion("AprobarInforme", True)
            End If
            Return
        End If

        If nombreMenu = "Paquetes" Then
            Select Case True
                Case EstaEnRol(RolDeUsuario.TecnicoCentroHTP)
                    Me.ucBarraNavegacion1.VerOpcion("AgregarPaquete", True)
                Case EstaEnRol(RolDeUsuario.JefeHTP), EstaEnRol(RolDeUsuario.GerenteGFI)
                    Me.ucBarraNavegacion1.VerOpcion("AgregarPaquete", False)
            End Select
            Me.ucBarraNavegacion1.VerOpcion("BuscarPaquetes", True)
            Return
        End If
    End Sub

    Protected Sub ucListaPAQUETE_INFORME1_Seleccionado(ByVal ID_PAQUETE As Decimal) Handles ucListaPAQUETE_INFORME1.Seleccionado
        Me.ViewState("idPaquete") = ID_PAQUETE
        Me.ucVistaDetallePAQUETE_INFORME1.ID_PAQUETE = Me.IdPaquete
        Me.ucListaPAQUETE_INFORME_DET1.CargarDatosPorPAQUETE_INFORME(Me.IdPaquete)

        If EstaEnRol(RolDeUsuario.TecnicoCentroHTP) Then
            Me.ucListaPAQUETE_INFORME_DET1.PermitirMarcar = False

        ElseIf EstaEnRol(RolDeUsuario.JefeHTP) Then
            Me.ucListaPAQUETE_INFORME_DET1.PermitirMarcar = _
                ((New cPAQUETE_INFORME_DET).ObtenerListaPorID_PAQUETE_CODIGO_ESTADO_AF(ID_PAQUETE, EstadoInformeFinal.InformeValidadoTecnico).Count > 0)

        ElseIf EstaEnRol(RolDeUsuario.GerenteGFI) Then
            Me.ucListaPAQUETE_INFORME_DET1.PermitirMarcar = _
                ((New cPAQUETE_INFORME_DET).ObtenerListaPorID_PAQUETE_CODIGO_ESTADO_AF(ID_PAQUETE, EstadoInformeFinal.InformeValidadoCoordinador).Count > 0)
        Else
            Me.ucListaPAQUETE_INFORME_DET1.PermitirMarcar = False
        End If

        Me.ucListaPAQUETE_INFORME_DET1.Visible = True

        Me.Menu1.Items(1).Selected = True
        Me.MultiView1.ActiveViewIndex = 1
        ConfigurarMenu("Informes")
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "AgregarPaquete" Then
            Me.AgregarPaquete()
        End If
        If CommandName = "GuardarPaquete" Then
            Me.GuardarPaquete()
        End If
        If CommandName = "BuscarPaquetes" Then
            Me.BuscarPaquetes()
        End If
        If CommandName = "EnVoBo" Then
            Me.EnVoBoJefeHTP()
        End If
        If CommandName = "AprobarInforme" Then
            Me.AprobacionFomacionInicial()
        End If
    End Sub

    Private Sub BuscarPaquetes()
        Me.ucListaPAQUETE_INFORME1.CargarDatosPorCriterios(Me.ucCriteriosPaqueteInforme1.IdPaquete, Me.ucCriteriosPaqueteInforme1.FechaCreacion, Me.ucCriteriosPaqueteInforme1.IdTecnico)
    End Sub

    Private Sub AgregarPaquete()
        Me.ucListaPAQUETE_INFORME_DET1.Visible = False
        Me.ucVistaDetallePAQUETE_INFORME1.Visible = True
        Me.ucVistaDetallePAQUETE_INFORME1.LimpiarControles()
        Me.ucVistaDetallePAQUETE_INFORME1.ID_PAQUETE = 0
        Me.ViewState("idPaquete") = 0

        Me.Menu1.Items(1).Selected = True
        Me.MultiView1.ActiveViewIndex = 1
        ConfigurarMenu("Nuevo Paquete")
    End Sub

    Private Sub GuardarPaquete()
        Dim esNuevo As Boolean = False
        esNuevo = (Me.ucVistaDetallePAQUETE_INFORME1.ID_PAQUETE = 0)
        If Not esNuevo Then
            If Not Me.ucListaPAQUETE_INFORME_DET1.ExisteSeleccion Then
                Me.AsignarMensaje("Debe marcar al menos un Informe para incluir en el Paquete.")
                Return
            End If
            If Me.ucVistaDetallePAQUETE_INFORME1.Actualizar() = "" Then
                Me.ucListaPAQUETE_INFORME_DET1.Actualizar(Me.ucVistaDetallePAQUETE_INFORME1.ID_PAQUETE)
                Me.AsignarMensaje("Se guardo el Paquete satisfactoriamente.")

                Me.ViewState("idPaquete") = 0

                'Seleccionando el menu principal
                Me.Menu1.Items(0).Enabled = True
                Me.Menu1.Items(0).Selected = True
                Me.MultiView1.ActiveViewIndex = 0

                Me.ucListaPAQUETE_INFORME1.CargarDatosPorTecnico(Me.ucCriteriosPaqueteInforme1.IdTecnico)
                Me.ucVistaDetallePAQUETE_INFORME1.Visible = False
                Me.ucListaPAQUETE_INFORME_DET1.Visible = False
                Me.ConfigurarMenu("Paquetes")
            End If
        Else
            If Me.ucVistaDetallePAQUETE_INFORME1.Actualizar() = "" Then
                Me.AsignarMensaje("Se guardo el Paquete satisfactoriamente. Ahora marque los informes que desea incluir en el Paquete")
                Me.ucListaPAQUETE_INFORME_DET1.Visible = True
                Me.ucListaPAQUETE_INFORME_DET1.PermitirMarcar = True
                Me.ucListaPAQUETE_INFORME_DET1.CargarDatosPorESTADO_ACCION_FORMATIVA_USUARIO(EstadoInformeFinal.InformeValidadoTecnico, Me.ObtenerUsuario)
                Me.Menu1.Items(0).Enabled = False
            End If
        End If
    End Sub

    Private Sub EnVoBoJefeHTP()
        If Not Me.ucListaPAQUETE_INFORME_DET1.ExisteSeleccion Then
            Me.AsignarMensaje("Debe marcar al menos un Informe para cambiarlo a Visto Bueno.")
            Return
        End If

        Me.ucListaPAQUETE_INFORME_DET1.Actualizar(Me.ucVistaDetallePAQUETE_INFORME1.ID_PAQUETE)
        Actualizar_UserId_LastUpdate_Paquete(Me.ucVistaDetallePAQUETE_INFORME1.ID_PAQUETE)
        Me.AsignarMensaje("Se guardo el Paquete satisfactoriamente. Los Informes que no se marcaron se pasaron a Revision del Tecnico encargado")

        Me.ViewState("idPaquete") = 0

        'Seleccionando el menu principal
        Me.Menu1.Items(0).Enabled = True
        Me.Menu1.Items(0).Selected = True
        Me.MultiView1.ActiveViewIndex = 0

        Me.ucListaPAQUETE_INFORME1.CargarDatosPorTecnico(Me.ucCriteriosPaqueteInforme1.IdTecnico)
        Me.ucVistaDetallePAQUETE_INFORME1.Visible = False
        Me.ucListaPAQUETE_INFORME_DET1.Visible = False
        Me.ConfigurarMenu("Paquetes")
    End Sub

    Private Sub AprobacionFomacionInicial()
        If Not Me.ucListaPAQUETE_INFORME_DET1.ExisteSeleccion Then
            Me.AsignarMensaje("Debe marcar al menos un Informe para cambiarlo a Aprobado.")
            Return
        End If

        Me.ucListaPAQUETE_INFORME_DET1.Actualizar(Me.ucVistaDetallePAQUETE_INFORME1.ID_PAQUETE)
        Actualizar_UserId_LastUpdate_Paquete(Me.ucVistaDetallePAQUETE_INFORME1.ID_PAQUETE)
        Me.AsignarMensaje("Se guardo el Paquete satisfactoriamente. Los Informes que no se marcaron se pasaron a Revision del Tecnico encargado")

        Me.ViewState("idPaquete") = 0

        'Seleccionando el menu principal
        Me.Menu1.Items(0).Enabled = True
        Me.Menu1.Items(0).Selected = True
        Me.MultiView1.ActiveViewIndex = 0

        Me.ucListaPAQUETE_INFORME1.CargarDatosPorTecnico(Me.ucCriteriosPaqueteInforme1.IdTecnico)
        Me.ucVistaDetallePAQUETE_INFORME1.Visible = False
        Me.ucListaPAQUETE_INFORME_DET1.Visible = False
        Me.ConfigurarMenu("Paquetes")
    End Sub

    Private Sub Actualizar_UserId_LastUpdate_Paquete(ByVal ID_PAQUETE As Integer)
        Dim ePaquete As PAQUETE_INFORME
        Dim Paquete As New cPAQUETE_INFORME

        ePaquete = Paquete.ObtenerPAQUETE_INFORME(ID_PAQUETE)
        Paquete.ActualizarPAQUETE_INFORME(ePaquete)
    End Sub
End Class
