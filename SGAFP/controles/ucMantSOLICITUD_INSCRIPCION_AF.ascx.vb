Imports SGAFP.BL
Imports SGAFP.EL
Imports System.Transactions
Imports DevExpress.Web.ASPxClasses
Imports SGAFP.DL.DS_DL
Imports SGAFP.DL.DS_DLTableAdapters
Imports System.Collections.Generic

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantSOLICITUD_INSCRIPCION_AF
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla SOLICITUD_INSCRIPCION_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantSOLICITUD_INSCRIPCION_AF
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.LimpiarOpciones()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)

        Me.ucBarraNavegacion1.CrearOpcion("BuscarSolicitudes", "Buscar", False, "~/imagenes/ButtonSearch.png", "onclick", "e.processOnServer=false;CargarSolicitudes();")
        Me.ucBarraNavegacion1.CargarOpciones()

        Me.ucCriteriosSolicitudes1.Visible = True
        Me.ucListaSOLICITUD_INSCRIPCION_AF1.Visible = True
        Me.ucListaSOLICITUD_INSCRIPCION_AF1.PermitirRevertirEstado = Me.EstaEnRol(Enumeradores.RolDeUsuario.Administrador) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.CoordinadorGFI)
        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle(Optional ByVal ID_SOLICITUD As Decimal = 0)
        Me.ucBarraNavegacion1.LimpiarOpciones()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)

        If Not (Me.Request.QueryString("modoOp") = 1 Or Me.Request.QueryString("modoOp") = 2) Then
            Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, "~/imagenes/cancelar.gif", "onclick", "e.processOnServer=false;cMantSOLICITUDES.PerformCallback('Cancelar');")
        End If
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", True, "~/imagenes/ButtonSave.png", "onclick", "e.processOnServer=false;GuardarSolicitud('Guardar');")
        If Me.Request.QueryString("modoOp") = 1 Or Me.Request.QueryString("modoOp") = 2 Then
            Me.ucBarraNavegacion1.CrearOpcion("GuardarySeleccionar", "Guardar y Seleccionar otro Curso", True, "~/imagenes/ButtonSaveNew.png", "onclick", "e.processOnServer=false;GuardarSolicitud('GuardarSeleccionar');")
        End If
        Me.ucBarraNavegacion1.CargarOpciones()

        Me.ucCriteriosSolicitudes1.Visible = False
        Me.ucListaSOLICITUD_INSCRIPCION_AF1.Visible = False
        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.Visible = True

        If Me.Request.QueryString("modoOp") = 1 Or Me.Request.QueryString("modoOp") = 2 Then
            Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.ID_ACCION_FORMATIVA = Me.Request.QueryString("ID_ACCION_FORMATIVA")
        End If
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Return Me.CargarSOLICITUD_INSCRIPCION_AF()
        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Function CargarSOLICITUD_INSCRIPCION_AF() As Integer
        If Me.ucListaSOLICITUD_INSCRIPCION_AF1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InicializarPagina()
    End Sub

    Private Sub InicializarPagina()
        If Not hf.Contains("Modo") Then
            If Not Me.Request.QueryString("modoOp") Is Nothing Then
                Me.InicializarDetalle()
                hf.Add("Modo", "Detalle")
            Else
                Me.InicializarLista()
                hf.Add("Modo", "Lista")
            End If
        Else
            If CStr(hf("Modo")) = "Lista" Then
                Me.InicializarLista()
            Else
                Me.InicializarDetalle()
            End If
        End If
    End Sub

    Private Sub UcBarraNavegacion1_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Agregar
        Me.InicializarDetalle()
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        'Dim sError As String
        ''sError = Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF1.Actualizar()
        'If sError <> "" Then
        '    Return
        'End If
        'Me.InicializarLista()
    End Sub

    Protected Sub ucListaSOLICITUD_INSCRIPCION_AF1_Editando(ByVal ID_SOLICITUD As Decimal) Handles ucListaSOLICITUD_INSCRIPCION_AF1.Editando
        Me.InicializarDetalle()
        'Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF1.ID_SOLICITUD = ID_SOLICITUD
    End Sub

    'Private Sub ucVistaDetalleSOLICITUD_INSCRIPCION_AF1_ErrorEvent(ByVal errorMessage As String) Handles ucVistaDetalleSOLICITUD_INSCRIPCION_AF1.ErrorEvent
    '    'Mostrar mensaje de error contenido en errorMessage
    '    Me.AsignarMensaje(errorMessage, True, True)
    'End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        'If CommandName = "GuardarSolicitud" Then
        '    Me.GuardarSolicitud()
        'End If
        'If CommandName = "EnviarSolicitud" Then
        '    Me.EnviarSolicitud()
        'End If
        'If CommandName = "Volver" Then
        '    'Me.Volver()
        'End If
    End Sub

    Private Sub GuardarSolicitud()
        ''Using scope As New TransactionScope()
        'Dim sError As String
        'sError = Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF1.Actualizar()
        'If sError <> "" Then
        '    Return
        'End If
        'scope.Complete()
        'End Using
    End Sub

    Private Sub EnviarSolicitud()
        'Using scope As New TransactionScope()
        'Dim sError As String
        'sError = Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF1.Actualizar()
        'If sError <> "" Then
        '    Return
        'End If
        ''scope.Complete()
        ''End Using
        ''Me.AsignarMensaje("Su solicitud fue enviada satisfactoriamente. El # de Solicitud es el " + Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF1.ID_SOLICITUD.ToString() + ".", False, True, "wfSolicitudInscripcion.aspx")
        'Response.Redirect("~/CursosFormacion/wfSolicitudEnviadaCorrectamente.aspx?s=" + Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF1.ID_SOLICITUD.ToString() + "&af=" + Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF1.ID_ACCION_FORMATIVA.ToString() + "&p=" + Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF1.ID_PROVEEDOR.ToString())
    End Sub

    Protected Sub cMantSOLICITUDES_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cMantSOLICITUDES.Callback
        Dim parametros() As String = e.Parameter.Split(";"c)
        Dim sResult As String
        cMantSOLICITUDES.JSProperties("cpCodigoError") = ""
        cMantSOLICITUDES.JSProperties("cpResultCallback") = ""

        Select Case parametros(0)
            Case "CargarDatos"
                Me.CargarDatos()

            Case "CargarDatosParticipante"
                'Verificar si el monto de apoyo de capacitación del participante ha sobrepasado para el ejercicio actual
                Dim eAccionFormativa As ACCION_FORMATIVA
                Dim eAccionFormativaDeta As ACCION_FORMATIVA_DETALLE
                Dim eTermino As TERMINO_REFERENCIA_AF

                eAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.ID_ACCION_FORMATIVA)
                eAccionFormativaDeta = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(eAccionFormativa.ID_ACCION_FORMATIVA)
                eTermino = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(eAccionFormativa.ID_ACCION_FORMATIVA)

                If eAccionFormativa.ID_ACCION_FORMATIVA > 0 AndAlso eAccionFormativa.ID_PROVEEDOR_AF <> 35 AndAlso (Me.hf.Contains("EsReferido") AndAlso Not Me.hf("EsReferido")) AndAlso eAccionFormativaDeta.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE Then
                    Dim bProgramaFormacion As New cPROGRAMA_FORMACION
                    Dim bAccionFormativa As New cACCION_FORMATIVA
                    Dim inversionTotal As New Dictionary(Of String, Decimal)
                    Dim montoApoyo As Decimal = bProgramaFormacion.ObtenerMontoApoyoParticipantePorPrograma(eAccionFormativaDeta.ID_PROGRAMA_FORMACION)

                    inversionTotal = bAccionFormativa.ObtenerMontoCapacitacionHTP(Decimal.Parse(parametros(1)), eAccionFormativa.ID_EJERCICIO)
                    If inversionTotal IsNot Nothing AndAlso (inversionTotal("MONTO") + eAccionFormativa.COSTO_X_PARTICIPANTE) > montoApoyo AndAlso (inversionTotal("MONTO") > 0) Then
                        cMantSOLICITUDES.JSProperties("cpResultCallback") = "ParticipanteSobrepasaCuota"
                        cMantSOLICITUDES.JSProperties("cpIdParticipante") = parametros(1)
                        cMantSOLICITUDES.JSProperties("cpIdEjercicio") = eAccionFormativa.ID_EJERCICIO
                        Return
                    End If
                End If

                If (New SGAFP.DL.dbSOLICITUD_INSCRIPCION_AF).ObtenerCantidadPorCurso(Decimal.Parse(parametros(1)), eAccionFormativa.ID_ACCION_FORMATIVA) > 0 Then
                    cMantSOLICITUDES.JSProperties("cpResultCallback") = "El Participante ya posee una solicitud para este curso"
                    Return
                End If
                Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.ID_PARTICIPANTE = parametros(1)
                Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.CargarDatosParticipante()
                Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.Habilitar()
                cMantSOLICITUDES.JSProperties("cpResultCallback") = "ValidarCamposRequeridos"

            Case "BuscarPartipantes", "BuscarParticipanteReferido"
                Dim p(parametros.Length - 2) As String

                For i As Integer = 1 To parametros.Length - 1
                    p(i - 1) = parametros(i)
                Next
                Me.ucListaPARTICIPANTE1.CargarDatosPorCallback("BuscarDatos", p)
                cMantSOLICITUDES.JSProperties("cpResultCallback") = "MostrarBusquedaParticipantes"
                Me.popuplblMensaje2.Visible = True
                Me.lblMensajeGrid.Visible = False
                Me.btnConfirmacion.Visible = False
                If parametros(0) = "BuscarParticipanteReferido" Then
                    Me.hf("EsReferido") = True
                Else
                    Me.hf("EsReferido") = False
                End If

            Case "Editar"
                hf("Modo") = "Detalle"
                Me.InicializarDetalle()
                Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.ID_SOLICITUD = Decimal.Parse(parametros(1))

            Case "Cancelar"
                hf("Modo") = "Lista"
                InicializarLista()

            Case "GuardarConCoincidencias"  'Guardar registro e Inicializar 
                sResult = Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.Actualizar()
                cMantSOLICITUDES.JSProperties("cpResultCallback") = sResult
                If sResult = "" Then
                    If Me.Request.QueryString("modoOp") = 1 Or Me.Request.QueryString("modoOp") = 2 Then
                        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.ID_SOLICITUD = 0
                        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.Habilitar()
                    Else
                        hf("Modo") = "Lista"
                        InicializarLista()
                    End If
                Else
                    If Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.CODIGO_ERROR = -3 OrElse _
                        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.CODIGO_ERROR = -10 Then Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.Nuevo()
                End If

            Case "Guardar"  'Guardar registro e Inicializar  
                Dim mensaje As String = String.Empty
                If CoincidenciaParticipantes(mensaje) <> 0 Then
                    If mensaje <> String.Empty Then cMantSOLICITUDES.JSProperties("cpResultCallback") = mensaje
                    Return
                End If

                sResult = Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.Actualizar()
                cMantSOLICITUDES.JSProperties("cpResultCallback") = sResult
                If sResult = "" Then
                    If Me.Request.QueryString("modoOp") = 1 Or Me.Request.QueryString("modoOp") = 2 Then
                        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.ID_SOLICITUD = 0
                        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.Habilitar()
                    Else
                        hf("Modo") = "Lista"
                        InicializarLista()
                    End If
                Else
                    If Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.CODIGO_ERROR = -3 OrElse _
                        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.CODIGO_ERROR = -10 Then Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.Nuevo()
                End If

            Case "GuardarSeleccionar"  'Guardar registro y seleccionar otro curso
                Dim mensaje As String = String.Empty
                If CoincidenciaParticipantes(mensaje) <> 0 Then
                    If mensaje <> String.Empty Then cMantSOLICITUDES.JSProperties("cpResultCallback") = mensaje
                    Return
                End If

                sResult = Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.Actualizar()
                cMantSOLICITUDES.JSProperties("cpResultCallback") = sResult
                If sResult = "" Then
                    If Me.Request.QueryString("modoOp") = 1 Or Me.Request.QueryString("modoOp") = 2 Then
                        If sResult = "" Then ASPxWebControl.RedirectOnCallback("~/CursosFormacion/wfConsultarDisponibilidadCursos.aspx")
                    Else
                        hf("Modo") = "Lista"
                        InicializarLista()
                    End If
                Else
                    If Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.CODIGO_ERROR = -3 OrElse _
                        Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.CODIGO_ERROR = -10 Then Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.Nuevo()
                End If


            Case "MostrarCursosRecibidosPorParticipante"
                Me.odsCursosRecibidos.SelectParameters("ID_PARTICIPANTE").DefaultValue = Decimal.Parse(parametros(1))
                Me.odsCursosRecibidos.SelectParameters("ID_EJERCICIO").DefaultValue = parametros(2)
                Me.gridCursos.DataBind()

                Me.odsCursosRecibidosPorCentro.SelectParameters("ID_PARTICIPANTE").DefaultValue = Decimal.Parse(parametros(1))
                Me.odsCursosRecibidosPorCentro.SelectParameters("ID_EJERCICIO").DefaultValue = parametros(2)
                Me.gridCentroFormacion.DataBind()

                Me.CursosRecibidosMsjlbl.Text = "NOTIFICACION!!!" + vbCrLf + "Con la solicitud de inscripcion al curso, el Participante ha sobrepasado la cuota maxima de capacitacion " + _
                                "para el Ejercicio: " + parametros(2)
                Me.cMantSOLICITUDES.JSProperties("cpResultCallback") = "MostrarCursosDelParticipante"

            Case "CopiarDatosDomicilio"
                Me.ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.CopiarDatosDomicilioParticipante()
                cMantSOLICITUDES.JSProperties("cpResultCallback") = "DatosDomicilioCopiados"
        End Select

    End Sub

    '-1: Información incompleta
    '0: No existe ninguna coincidencia
    '1: Existe coincidencia exacta en NOMBRES, APELLIDOS y FECHA_NACIMIENTO
    '2: Existe coincidencia fonética en NOMBRES, APELLIDOS y coincidencia exacta en FECHA_NACIMIENTO
    Private Function CoincidenciaParticipantes(ByRef mensaje As String) As Integer
        Dim bParticipante As New cPARTICIPANTE
        Dim lEntidadParti As New PARTICIPANTE
        Dim listaCoincidencias As listaPARTICIPANTE
        Dim duplicadoPorFonetico As Integer = 0

        If ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.ID_PARTICIPANTE = 0 AndAlso _
            ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.DUI = "" AndAlso _
            ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.NIT = "" Then

            If ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.NOMBRES.TrimEnd = "" Then
                mensaje = "Ingrese los Nombres del participante"
                Return -1
            End If
            If ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.APELLIDOS.TrimEnd = "" Then
                mensaje = "Ingrese los Apellidos del participante"
                Return -1
            End If
            If Not IsDate(ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.FECHA_NACIMIENTO) OrElse ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.FECHA_NACIMIENTO = #12:00:00 AM# Then
                mensaje = "Ingrese la fecha de nacimiento"
                Return -1
            End If

            'Verificar que no se haya sobrepasado la cantidad de participantes sin documentos autorizados 
            Dim lEntidadAccionParti As listaACCION_PARTI_SINDOCTOS = (New cACCION_PARTI_SINDOCTOS).ObtenerListaPorACCION_FORMATIVA(ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.ID_ACCION_FORMATIVA)
            If lEntidadAccionParti IsNot Nothing AndAlso lEntidadAccionParti.Count > 0 Then
                Dim totalAutorizado As Decimal = 0
                Dim totalInscritos As Decimal = (New cACCION_FORMATIVA).ObtenerCantParticipantesSinDoctos(ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.ID_ACCION_FORMATIVA)
                For Each lEntidad As ACCION_PARTI_SINDOCTOS In lEntidadAccionParti
                    totalAutorizado += lEntidad.CANT_PARTICIPANTES
                Next
                'Para esta inscripción
                totalInscritos += 1
                If totalInscritos > totalAutorizado Then
                    mensaje = "La inscripción de este participante sin documentos sobrepasa la cantidad autorizada para el curso."
                    Return -1
                End If
            Else
                mensaje = "DUI o NIT son requeridos."
                Return -1
            End If

            listaCoincidencias = bParticipante.ObtenerListaPorNOMBRES_APELLIDOS_FECHANAC(ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.NOMBRES, _
                                    ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.APELLIDOS, ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.FECHA_NACIMIENTO)
            If listaCoincidencias IsNot Nothing AndAlso listaCoincidencias.Count > 0 Then
                mensaje = "Ya existe un participante con los mismos nombres, apellidos y fecha de nacimiento. Intente inscribirlo buscandolo por Nombres y Apellidos"
                Return 1
            Else
                lEntidadParti.NOMBRES = ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.NOMBRES
                lEntidadParti.APELLIDOS = ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.APELLIDOS
                lEntidadParti.FECHA_NACIMIENTO = ucVistaDetalleSOLICITUD_INSCRIPCION_AF2.FECHA_NACIMIENTO
                listaCoincidencias = bParticipante.ObtenerListaParticipantesSemejantes(lEntidadParti, duplicadoPorFonetico)
                If listaCoincidencias IsNot Nothing AndAlso listaCoincidencias.Count > 0 Then
                    'Mostrar popup con participantes semejantes                  
                    Me.ucListaPARTICIPANTE1.CargarDatosPorParticipantesSemejantes(lEntidadParti, duplicadoPorFonetico)
                    Me.popuplblMensaje2.Visible = False
                    Me.lblMensajeGrid.Visible = True
                    Me.btnConfirmacion.Visible = True
                    cMantSOLICITUDES.JSProperties("cpResultCallback") = "MostrarBusquedaParticipantes"
                    Return 2
                End If
            End If
        End If

        Return 0
    End Function
End Class
