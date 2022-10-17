Imports SGAFP.BL
Imports SGAFP.EL
Imports SGAFP.DL.DS_DL
Imports System.Collections.Generic


''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantACCION_FORMATIVA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla ACCION_FORMATIVA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantACCION_FORMATIVA
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub Inicializar()
        Me.lblTitulo.Text = "CALENDARIZACION DE CURSOS"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucBarraNavegacion1.LimpiarOpciones()
        Me.ucBarraNavegacion1.CrearOpcion("Agregar", "Agregar", False, "~/imagenes/nuevo.png")
        Me.ucBarraNavegacion1.CrearOpcion("NuevoBolpros", "Crear Curso Bolpros Online / Bolpros adjudicado por costo participante", False, "~/imagenes/bolpros.png")
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar Cursos", False, "~/imagenes/ButtonSearch.png")
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", False, "~/imagenes/ButtonSave.png")
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, "~/imagenes/Undo-icon.png")
        Me.ucBarraNavegacion1.CargarOpciones()

        Me.ucCriteriosAccionFormativa1.VerEstado = True
        Me.ucCriteriosAccionFormativa1.VerEjercicio = True
        Me.ucCriteriosAccionFormativa1.Visible = True
        Me.ucBarraNavegacion1.VerOpcion("Agregar", (Me.EstaEnRol(RolDeUsuario.Proveedor) OrElse Me.EstaEnRol(RolDeUsuario.CentroCapacitador) OrElse Me.EstaEnRol(RolDeUsuario.Administrador)))
        Me.ucBarraNavegacion1.VerOpcion("NuevoBolpros", (Me.EstaEnRol(RolDeUsuario.CentroCapacitador) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPROYESPECIAL) OrElse Me.EstaEnRol(RolDeUsuario.Administrador)))
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)

        Me.ucListaACCION_FORMATIVA1.Visible = True
        Me.ucVistaDetalleACCION_FORMATIVA1.Visible = False
        Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.Visible = False
        Me.ucVistaDetalleACCION_FORMATIVA_PENA1.Visible = False
        Me.ucGenerarInformeParcial1.Visible = False
        Me.ConfigurarAcciones()
    End Sub


    Private Sub InicializarLista()
        Me.lblTitulo.Text = "CALENDARIZACION DE CURSOS"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Agregar", (Me.EstaEnRol(RolDeUsuario.Proveedor) OrElse Me.EstaEnRol(RolDeUsuario.CentroCapacitador) OrElse Me.EstaEnRol(RolDeUsuario.Administrador)))
        Me.ucBarraNavegacion1.VerOpcion("NuevoBolpros", (Me.EstaEnRol(RolDeUsuario.CentroCapacitador) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPROYESPECIAL) OrElse Me.EstaEnRol(RolDeUsuario.Administrador)))
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucCriteriosAccionFormativa1.Visible = True
        Me.ucListaACCION_FORMATIVA1.Visible = True
        Me.ucVistaDetalleACCION_FORMATIVA1.Visible = False
        Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.Visible = False
        Me.ucVistaDetalleACCION_FORMATIVA_PENA1.Visible = False
        Me.ucGenerarInformeParcial1.Visible = False
        Me.ConfigurarAcciones()
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.lblTitulo.Text = "CALENDARIZACION DE CURSOS"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("NuevoBolpros", False)
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucCriteriosAccionFormativa1.Visible = False
        Me.ucListaACCION_FORMATIVA1.Visible = False
        Me.ucVistaDetalleACCION_FORMATIVA1.Visible = True
    End Sub

    Private Sub InicializarPenalizacion()
        Me.lblTitulo.Text = "PENALIZACION DE CURSOS"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("NuevoBolpros", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucCriteriosAccionFormativa1.Visible = False
        Me.ucListaACCION_FORMATIVA1.Visible = False
        Me.ucVistaDetalleACCION_FORMATIVA_PENA1.Visible = True
    End Sub


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ACCION_FORMATIVA_REPROG
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	02/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalleReprogramacion()
        Me.lblTitulo.Text = "REPROGRAMACION DE CURSO"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucCriteriosAccionFormativa1.Visible = False
        Me.ucListaACCION_FORMATIVA1.Visible = False
        Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.Visible = True
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Generación de Informe Parcial de Ejecución
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	25/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarInformeParcial()
        Me.lblTitulo.Text = "EMISION DE INFORME PARCIAL PARA PAGO"
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.VerOpcion("Agregar", False)
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("NuevoBolpros", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucCriteriosAccionFormativa1.Visible = False
        Me.ucListaACCION_FORMATIVA1.Visible = False
        Me.ucGenerarInformeParcial1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_FORMATIVA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 

        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function ConfigurarAcciones() As Integer
        Dim esRolAutorizado As Boolean = (Me.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPATI) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPROYESPECIAL) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.CentroCapacitador) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.Administrador))
        Me.ucListaACCION_FORMATIVA1.PermitirEditar = (Me.ucCriteriosAccionFormativa1.idEstadoAccion = Enumeradores.EstadoAccionFormativa.Ingresada OrElse _
                                                Me.ucCriteriosAccionFormativa1.idEstadoAccion = Enumeradores.EstadoAccionFormativa.EnMatricula) AndAlso _
                                                (Me.EstaEnRol(Enumeradores.RolDeUsuario.CentroCapacitador) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPATI) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.ProveedorPROYESPECIAL) OrElse _
                                                 Me.EstaEnRol(Enumeradores.RolDeUsuario.CoordinadorGFI) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.GerenteGFI) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.Administrador))
        Me.ucListaACCION_FORMATIVA1.PermitirEliminar = (Me.ucCriteriosAccionFormativa1.idEstadoAccion = Enumeradores.EstadoAccionFormativa.Ingresada)
        Me.ucListaACCION_FORMATIVA1.PermitirPenalizacion = Me.EstaEnRol(Enumeradores.RolDeUsuario.Administrador) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.GerenteGFI) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.CoordinadorGFI) OrElse _
                                                        Me.EstaEnRol(Enumeradores.RolDeUsuario.CoordinadorECentro)
        Me.ucListaACCION_FORMATIVA1.PermitirSeguimiento = Me.EstaEnRol(Enumeradores.RolDeUsuario.Administrador) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.GerenteGFI) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.CoordinadorGFI) OrElse _
                                                       Me.EstaEnRol(Enumeradores.RolDeUsuario.CoordinadorECentro) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.SoporteGFI) OrElse _
                                                       Me.EstaEnRol(Enumeradores.RolDeUsuario.Auditor) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.AuditorUMEFP)
        Select Case Me.ucCriteriosAccionFormativa1.idEstadoAccion
            Case Enumeradores.EstadoAccionFormativa.Ingresada
                Me.ucListaACCION_FORMATIVA1.VerCambiarAEnMatricula = esRolAutorizado
                Me.ucListaACCION_FORMATIVA1.PermitirCrearGruposCapacitacion = Me.EstaEnRol("ProveedorPATI")
                Me.ucListaACCION_FORMATIVA1.VerCambiarAIniciado = False
                Me.ucListaACCION_FORMATIVA1.VerCambiarAFinalizado = False
                Me.ucListaACCION_FORMATIVA1.VerColumnaReporte = True
                Me.ucListaACCION_FORMATIVA1.PermitirSolicitarReprogramacion = False
                Me.ucListaACCION_FORMATIVA1.PermitirEliminar = esRolAutorizado
                Me.ucListaACCION_FORMATIVA1.VerRevertir_aMatricula = False
            Case Enumeradores.EstadoAccionFormativa.EnMatricula
                Me.ucListaACCION_FORMATIVA1.VerCambiarAEnMatricula = False
                Me.ucListaACCION_FORMATIVA1.PermitirCrearGruposCapacitacion = False
                Me.ucListaACCION_FORMATIVA1.VerCambiarAIniciado = esRolAutorizado
                Me.ucListaACCION_FORMATIVA1.VerCambiarAFinalizado = False
                Me.ucListaACCION_FORMATIVA1.PermitirSolicitarReprogramacion = False
                Me.ucListaACCION_FORMATIVA1.PermitirEliminar = esRolAutorizado
                Me.ucListaACCION_FORMATIVA1.VerColumnaReporte = True
                Me.ucListaACCION_FORMATIVA1.VerRevertir_aMatricula = False
            Case Enumeradores.EstadoAccionFormativa.Iniciada
                Me.ucListaACCION_FORMATIVA1.VerCambiarAEnMatricula = False
                Me.ucListaACCION_FORMATIVA1.PermitirCrearGruposCapacitacion = False
                Me.ucListaACCION_FORMATIVA1.VerCambiarAIniciado = False
                Me.ucListaACCION_FORMATIVA1.VerCambiarAFinalizado = esRolAutorizado
                Me.ucListaACCION_FORMATIVA1.PermitirSolicitarReprogramacion = esRolAutorizado
                Me.ucListaACCION_FORMATIVA1.PermitirGenerarInforme = esRolAutorizado
                Me.ucListaACCION_FORMATIVA1.PermitirEliminar = esRolAutorizado
                Me.ucListaACCION_FORMATIVA1.VerColumnaReporte = True
                Me.ucListaACCION_FORMATIVA1.VerRevertir_aMatricula = EstaEnRol(RolDeUsuario.Administrador) OrElse EstaEnRol(RolDeUsuario.CoordinadorGFI)
            Case Enumeradores.EstadoAccionFormativa.Finalizada
                Me.ucListaACCION_FORMATIVA1.VerCambiarAEnMatricula = False
                Me.ucListaACCION_FORMATIVA1.PermitirCrearGruposCapacitacion = False
                Me.ucListaACCION_FORMATIVA1.VerCambiarAIniciado = False
                Me.ucListaACCION_FORMATIVA1.VerCambiarAFinalizado = False
                Me.ucListaACCION_FORMATIVA1.PermitirSolicitarReprogramacion = False
                Me.ucListaACCION_FORMATIVA1.PermitirEliminar = False
                Me.ucListaACCION_FORMATIVA1.VerColumnaReporte = True
                Me.ucListaACCION_FORMATIVA1.VerRevertir_aMatricula = EstaEnRol(RolDeUsuario.Administrador) OrElse EstaEnRol(RolDeUsuario.CoordinadorGFI)
            Case Else
                Me.ucListaACCION_FORMATIVA1.VerCambiarAEnMatricula = False
                Me.ucListaACCION_FORMATIVA1.PermitirCrearGruposCapacitacion = False
                Me.ucListaACCION_FORMATIVA1.VerCambiarAIniciado = False
                Me.ucListaACCION_FORMATIVA1.VerCambiarAFinalizado = False
                Me.ucListaACCION_FORMATIVA1.PermitirSolicitarReprogramacion = False
                Me.ucListaACCION_FORMATIVA1.PermitirEliminar = False
                Me.ucListaACCION_FORMATIVA1.VerColumnaReporte = False
        End Select

        If Me.ucCriteriosAccionFormativa1.idEstadoAccion <> Enumeradores.EstadoAccionFormativa.Ingresada Then
            Me.ucListaACCION_FORMATIVA1.AgregarHyperLinkField("ID_ACCION_FORMATIVA".Split(","), "~/Reportes/wfReporteParticipantesInscritos.aspx?ID_ACCION_FORMATIVA={0}", "<img src='../imagenes/Imprimir.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Imprimir inscripci&oacute;n' />", "_self")
        Else
            Me.ucListaACCION_FORMATIVA1.EliminarHyperLinkField("<img src='../imagenes/Imprimir.gif' style='border-style:none;border-width:0px;height:18px;width:18px;' alt='Imprimir inscripci&oacute;n' />")
        End If

        Return 1
    End Function

    Private Function CargarAcciones() As Int32
        Dim c As SQLMembershipProvider.BL.cmembershipProvider
        Dim listaRoles As New List(Of String)
        Dim listaCodigoEstados As New List(Of String)
        Dim sbRoles As New StringBuilder
        Dim sbCodigoEstados As New StringBuilder

        c = CType(System.Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)
        listaRoles = c.ObtenerRoles(Me.ObtenerUsuario)
        listaCodigoEstados.Add(Me.ucCriteriosAccionFormativa1.idEstadoAccion)

        For i As Integer = 0 To listaRoles.Count - 1
            sbRoles.Append(listaRoles(i))
            If i < listaRoles.Count - 1 Then sbRoles.Append(";")
        Next
        For i As Integer = 0 To listaCodigoEstados.Count - 1
            sbCodigoEstados.Append(listaCodigoEstados(i))
            If i < listaCodigoEstados.Count - 1 Then sbCodigoEstados.Append(";")
        Next

        If Me.ucListaACCION_FORMATIVA1.CargarDatosPorCriteriosRoles( _
                Me.ucCriteriosAccionFormativa1.idProveedor, _
                Me.ucCriteriosAccionFormativa1.idSitioCapacitacion, _
                Me.ucCriteriosAccionFormativa1.idAreaFormacion, _
                Me.ucCriteriosAccionFormativa1.nombreAccionFormativa, _
                Me.ucCriteriosAccionFormativa1.codigoGrupo, _
                Me.ucCriteriosAccionFormativa1.idEjercicio, _
                sbRoles.ToString, sbCodigoEstados.ToString, _
                Me.ucCriteriosAccionFormativa1.tdr) <> 1 Then
            Return -1
        End If
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.Inicializar()
        End If
    End Sub

    Private Sub UcBarraNavegacion1_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Agregar
        Me.InicializarDetalle()
        Me.UcVistaDetalleACCION_FORMATIVA1.LimpiarControles()
        Me.ucVistaDetalleACCION_FORMATIVA1.ID_ACCION_FORMATIVA = 0
    End Sub

    Protected Sub ucBarraNavegacion1_Cancelar(sender As Object, e As EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        Dim sError As String = ""
        If Me.ucVistaDetalleACCION_FORMATIVA1.Visible Then
            sError = Me.ucVistaDetalleACCION_FORMATIVA1.Actualizar()
        ElseIf Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.Visible Then
            sError = Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.Actualizar()
        ElseIf Me.ucGenerarInformeParcial1.Visible Then
            sError = Me.ucGenerarInformeParcial1.Actualizar()
        ElseIf Me.ucVistaDetalleACCION_FORMATIVA_PENA1.Visible Then
            sError = Me.ucVistaDetalleACCION_FORMATIVA_PENA1.Actualizar()
        End If
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
        Me.ConfigurarAcciones()
        Me.CargarAcciones()
    End Sub

    Protected Sub ucListaACCION_FORMATIVA1_Editando(ByVal ID_ACCION_FORMATIVA As Decimal) Handles ucListaACCION_FORMATIVA1.Editando
        Me.InicializarDetalle()
        Me.UcVistaDetalleACCION_FORMATIVA1.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
    End Sub

    Private Sub ucVistaDetalleACCION_FORMATIVA1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetalleACCION_FORMATIVA1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Agregar" Then
            Me.InicializarDetalle()
            Me.ucVistaDetalleACCION_FORMATIVA1.LimpiarControles()
            Me.ucVistaDetalleACCION_FORMATIVA1.ES_BOLPROS_A_DEMANDA = False
            Me.ucVistaDetalleACCION_FORMATIVA1.ID_ACCION_FORMATIVA = 0
        End If

        If CommandName = "Buscar" Then
            Me.ConfigurarAcciones()
            Me.CargarAcciones()
        End If

        If CommandName = "NuevoBolpros" Then
            Me.InicializarDetalle()
            Me.ucVistaDetalleACCION_FORMATIVA1.LimpiarControles()
            Me.ucVistaDetalleACCION_FORMATIVA1.ES_BOLPROS_A_DEMANDA = True
            Me.ucVistaDetalleACCION_FORMATIVA1.ID_ACCION_FORMATIVA = 0
        End If

        If CommandName = "Cancelar" Then
            Me.InicializarLista()
        End If

        If CommandName = "Guardar" Then
            Dim sError As String = ""
            If Me.ucVistaDetalleACCION_FORMATIVA1.Visible Then
                sError = Me.ucVistaDetalleACCION_FORMATIVA1.Actualizar()
            ElseIf Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.Visible Then
                sError = Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.Actualizar()
            ElseIf Me.ucVistaDetalleACCION_FORMATIVA_PENA1.Visible Then
                sError = Me.ucVistaDetalleACCION_FORMATIVA_PENA1.Actualizar()
            ElseIf Me.ucGenerarInformeParcial1.Visible Then
                sError = Me.ucGenerarInformeParcial1.Actualizar()
            End If
            If sError <> "" Then
                If Me.ucVistaDetalleACCION_FORMATIVA_PENA1.Visible Then Me.AsignarMensaje(sError, False, True)
                Return
            End If
            Me.InicializarLista()
            Me.ConfigurarAcciones()
            Me.CargarAcciones()

        End If
    End Sub

    Protected Sub ucListaACCION_FORMATIVA1_InformeParcial(ByVal ID_ACCION_FORMATIVA As Decimal) Handles ucListaACCION_FORMATIVA1.InformeParcial
        Me.InicializarInformeParcial()
        Me.ucGenerarInformeParcial1.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
    End Sub

    Protected Sub ucListaACCION_FORMATIVA1_Penalizar(ID_ACCION_FORMATIVA As Decimal) Handles ucListaACCION_FORMATIVA1.Penalizar
        Me.InicializarPenalizacion()
        Me.ucVistaDetalleACCION_FORMATIVA_PENA1.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
    End Sub

    Protected Sub ucListaACCION_FORMATIVA1_Reprogramando(ByVal ID_ACCION_FORMATIVA As Decimal) Handles ucListaACCION_FORMATIVA1.Reprogramando
        Me.InicializarDetalleReprogramacion()
        Me.ucVistaDetalleACCION_FORMATIVA_REPROG1.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
    End Sub
    
End Class
