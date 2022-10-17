Imports System.Text
Imports SQLMembershipProvider.BL
Imports System.Web.Security
Imports SGAFP.EL.Enumeradores

Partial Public Class cACCION_FORMATIVA_REPROG




    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	01/06/2010	Created
    ''' 	[ecarias]	12/05/2011	Se agrego parametro de busqueda TDR
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriteriosPeriodoEstado(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_AREA_FORMACION As Decimal, ByVal NOMBRE_ACCION_FORMATIVA As String, ByVal CODIGO_GRUPO As String, ByVal ID_ESTADO_REPROG As Decimal, ByVal ID_EJERCICIO As String, ByVal TDR As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA_REPROG
        Try
            Return mDb.ObtenerListaPorCriteriosPeriodo(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_AREA_FORMACION, NOMBRE_ACCION_FORMATIVA, CODIGO_GRUPO, ID_EJERCICIO, TDR, ID_ESTADO_REPROG, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla ACCION_FORMATIVA_REPROG.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>    
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerACCION_FORMATIVA_REPROG_POR_ESTADO(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_ESTADO_REPROG As Integer) As ACCION_FORMATIVA_REPROG
        Try
            Return mDb.ObtenerACCION_FORMATIVA_REPROG_POR_ESTADO(ID_ACCION_FORMATIVA, ID_ESTADO_REPROG)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el Cuerpo de un Correo para Solicitar Reprogramación de un Curso
    ''' </summary>
    ''' <param name="aEntidad"></param>    
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/08/2010	Created
    ''' 	[cramos]	04/04/2013	Modificado: Se modifica la lógica del método para que permita retornar un cuerpo de correo para una accion formativa
    '''                                         de cualquier programa de formación
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerCuerpoCorreoSolicReprog(ByVal aEntidad As ACCION_FORMATIVA, ByVal aEntidadReprog As ACCION_FORMATIVA_REPROG) As String
        Dim Cuerpo As New StringBuilder
        Dim lEntidadProveedor As PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF)
        Dim lEntidadCentro As SITIO_CAPACITACION = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(aEntidad.ID_SITIO_CAPACITACION)
        Dim lEntidadAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(aEntidad.ID_ACCION_FORMATIVA)
        Dim lEntidadPrograma As PROGRAMA_FORMACION = (New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(lEntidadAccionDetalle.ID_PROGRAMA_FORMACION)
        Dim lEntidadTerminoRef As TERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(aEntidad.ID_ACCION_FORMATIVA)
        Dim lNombreProyecto As String = ""
        Dim lNombreReferente As String = ""

        If lEntidadTerminoRef IsNot Nothing AndAlso lEntidadTerminoRef.ID_SOLICITUD > 0 Then
            Dim lEntidadSolicitudCap As SOLICITUD_CAPACITACION = (New cSOLICITUD_CAPACITACION).ObtenerSOLICITUD_CAPACITACION(lEntidadTerminoRef.ID_SOLICITUD)
            If lEntidadSolicitudCap IsNot Nothing Then
                Dim lEntidadReferente As REFERENTE = (New cREFERENTE).ObtenerREFERENTE(lEntidadSolicitudCap.ID_REFERENTE)
                Dim lEntidadProyecto As PROYECTO_FORMACION = (New cPROYECTO_FORMACION).ObtenerPROYECTO_FORMACION(lEntidadSolicitudCap.ID_PROYECTO_FORMACION)
                lNombreReferente = lEntidadReferente.NOMBRE_REFERENTE
                lNombreProyecto = lEntidadProyecto.NOMBRE_PROYECTO_FORMACION
            End If
        End If

        Dim FechaSolic As String = Format(DateTime.Today, "dd/MM/yyyy")
        Dim HoraSolic As String = Format(DateTime.Now, "hh:mm tt")

        Cuerpo.Append("PROGRAMA: ")
        Cuerpo.AppendLine(lEntidadPrograma.NOMBRE_PROGRAMA_FORMACION)
        If lNombreProyecto <> "" Then
            Cuerpo.Append("PROYECTO: ")
            Cuerpo.AppendLine(lNombreProyecto)
        End If
        If lNombreReferente <> "" Then
            Cuerpo.Append("REFERENTE: ")
            Cuerpo.AppendLine(lNombreReferente)
        End If
        Cuerpo.Append("PROVEEDOR: ")
        Cuerpo.AppendLine(lEntidadProveedor.NOMBRE_PROVEEDOR)
        If lEntidadCentro IsNot Nothing Then
            Cuerpo.Append("CENTRO DE FORMACION: ")
            Cuerpo.AppendLine(lEntidadCentro.NOMBRE_SITIO)
        End If
        Cuerpo.AppendLine("SOLICITUD DE REPROGRAMACION DE CURSO")
        Cuerpo.AppendLine("")
        Cuerpo.Append("FECHA DE LA SOLICITUD: ")
        Cuerpo.Append(FechaSolic)
        Cuerpo.Append(" ")
        Cuerpo.AppendLine(HoraSolic)
        Cuerpo.Append("ID CURSO: ")
        Cuerpo.AppendLine(aEntidad.ID_ACCION_FORMATIVA.ToString)
        Cuerpo.Append("NOMBRE DEL CURSO: ")
        Cuerpo.AppendLine(aEntidad.NOMBRE_ACCION_FORMATIVA)
        Cuerpo.Append("CODIGO DE GRUPO: ")
        Cuerpo.AppendLine(aEntidad.CODIGO_GRUPO)
        Cuerpo.Append("MUNICIPIO: ")
        Cuerpo.AppendLine((New cMUNICIPIO).ObtenerMUNICIPIO(lEntidadAccionDetalle.CODIGO_DEPARTAMENTO, lEntidadAccionDetalle.CODIGO_MUNICIPIO).NOMBRE)
        Cuerpo.Append("LUGAR DE EJECUCIÓN: ")
        Cuerpo.AppendLine(lEntidadAccionDetalle.LUGAR_EJECUCION)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("Cambios solicitados:")
        Cuerpo.AppendLine("")
        If aEntidad.CODIGO_GRUPO.ToUpper.Trim <> aEntidadReprog.CODIGO_GRUPO.ToUpper.Trim Then
            Cuerpo.AppendLine("Codigo de Grupo " + aEntidad.CODIGO_GRUPO.ToUpper.Trim + " Por " + aEntidadReprog.CODIGO_GRUPO.ToUpper.Trim)
        End If
        If aEntidad.NUMERO_PARTICIPANTES <> aEntidadReprog.NUMERO_PARTICIPANTES Then
            Cuerpo.AppendLine("Cupo actual " + aEntidad.NUMERO_PARTICIPANTES.ToString + " cambiar a " + aEntidadReprog.NUMERO_PARTICIPANTES.ToString)
        End If
        If Format(aEntidad.FECHA_INICIO_REAL, "dd/MM/yyyy") <> Format(aEntidadReprog.FECHA_INICIO_REAL, "dd/MM/yyyy") Then
            Cuerpo.AppendLine("Fecha de Inicio actual " + Format(aEntidad.FECHA_INICIO_REAL, "dd/MM/yyyy") + " cambiar a " + Format(aEntidadReprog.FECHA_INICIO_REAL, "dd/MM/yyyy"))
        End If
        If Format(aEntidad.FECHA_FIN_REAL, "dd/MM/yyyy") <> Format(aEntidadReprog.FECHA_FIN_REAL, "dd/MM/yyyy") Then
            Cuerpo.AppendLine("Fecha de Finalizacion actual " + Format(aEntidad.FECHA_FIN_REAL, "dd/MM/yyyy") + " cambiar a " + Format(aEntidadReprog.FECHA_FIN_REAL, "dd/MM/yyyy"))
        End If
        If aEntidad.HORARIO.ToUpper.Trim <> aEntidadReprog.HORARIO.ToUpper.Trim Then
            Cuerpo.AppendLine("Horario " + aEntidad.HORARIO.ToUpper.Trim + " cambiar a " + aEntidadReprog.HORARIO.ToUpper.Trim)
        End If
        If aEntidad.NOTAS.ToUpper.Trim <> aEntidadReprog.NOTAS.ToUpper.Trim Then
            Cuerpo.AppendLine("Instructor/Comentarios " + aEntidad.NOTAS.ToUpper.Trim + " cambiar a " + aEntidadReprog.NOTAS.ToUpper.Trim)
        End If
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("El motivo para efectuar este(os) cambio(s) es el siguiente:")
        Cuerpo.AppendLine(aEntidadReprog.MOTIVOREPROG)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("NOTA IMPORTANTE: Si usted no esta gestionando este curso por favor hacer caso omiso de esta reprogramación")
        Return Cuerpo.ToString
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el Cuerpo de un Correo de Evaluación de Reprogramación de un Curso
    ''' </summary>
    ''' <param name="aEntidad"></param>    
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/08/2010	Created
    ''' 	[ecarias]	12/05/2010	Se agrego que tambien considere si es AF del PATI
    ''' 	[cramos]	12/12/2012	Se modifica lógica para utilizar Programa de Formación en lugar de Tipo de Solicitud
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCuerpoCorreoEvaluacionReprog(ByVal aEntidad As ACCION_FORMATIVA_REPROG) As String
        Dim Cuerpo As New StringBuilder

        Cuerpo.AppendLine("INSAFORP - GERENCIA DE FORMACION INICIAL ")

        Dim idProgramaFormacion As Decimal
        Dim lEntidadPrograma As PROGRAMA_FORMACION
        idProgramaFormacion = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(aEntidad.ID_ACCION_FORMATIVA)
        lEntidadPrograma = (New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(idProgramaFormacion)
        Cuerpo.Append(lEntidadPrograma.NOMBRE_PROGRAMA_FORMACION)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("Por este medio se le comunica que la solicitud de reprogramación para el curso ")
        Cuerpo.Append("ID: ")
        Cuerpo.AppendLine(aEntidad.ID_ACCION_FORMATIVA.ToString)
        Cuerpo.Append("NOMBRE: ")
        Cuerpo.AppendLine(aEntidad.NOMBRE_ACCION_FORMATIVA)
        Cuerpo.Append("CODIGO: ")
        Cuerpo.AppendLine(aEntidad.CODIGO_GRUPO)
        Cuerpo.AppendLine("")
        If aEntidad.MOTIVORECHAZO = "" Then
            Cuerpo.AppendLine("ha sido aprobada.")
        Else
            Cuerpo.AppendLine("ha sido rechazada debido a:")
            Cuerpo.Append(aEntidad.MOTIVORECHAZO)
        End If

        Return Cuerpo.ToString
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que envía un correo para una Solicitud de Reprogramación
    ''' </summary>
    ''' <param name="aEntidad"></param>    
    ''' <param name="CUERPO"></param> 
    ''' <param name="USUARIO_REMITENTE"></param> 
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/08/2010	Created
    ''' 	[cramos]	04/04/2013	Modificado
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function EnviarSolicitudPorCorreo(ByVal aEntidad As ACCION_FORMATIVA, ByVal CUERPO As String, ByVal USUARIO_REMITENTE As String) As Integer
        Try
            Dim lEntidadAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(aEntidad.ID_ACCION_FORMATIVA)
            Dim lProveedor As PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF)
            Dim lEntidadPrograma As PROGRAMA_FORMACION = (New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(lEntidadAccionDetalle.ID_PROGRAMA_FORMACION)
            Dim listaDestinatarios As New List(Of String)
            Dim lTecnico As String
            Dim lCorreo As String

            Dim _mp As New cmembershipProvider
            _mp = CType(Membership.Provider, cmembershipProvider)

            Select Case lEntidadPrograma.ID_PROGRAMA_FORMACION
                Case Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE
                    'Obtener el usuario del técnico que tiene asignado el centro de formación
                    listaDestinatarios = _mp.ObtenerEmailsPorRol(Enumeradores.RolDeUsuario.TecnicoGFI, True)

                Case Enumeradores.ProgramasFormacion.PATI_BM, Enumeradores.ProgramasFormacion.PATI_USAID, Enumeradores.ProgramasFormacion.PATI_2
                    'Obtener los usuarios con Rol TecnicoGFIPATI
                    listaDestinatarios = _mp.ObtenerEmailsPorRol(Enumeradores.RolDeUsuario.TecnicoGFI, True)

                Case Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL
                    'Obtener los usuarios con Rol TecnicoPROYESPECIAL
                    listaDestinatarios = _mp.ObtenerEmailsPorRol(Enumeradores.RolDeUsuario.TecnicoGFI, True)
            End Select

            If listaDestinatarios IsNot Nothing AndAlso listaDestinatarios.Count > 0 Then
                'Obtener el correo electrónico del usuario actual
                lCorreo = _mp.ObtenerEmailPorNombreUsuario(USUARIO_REMITENTE)
                Return _mp.EnviarCorreo(lCorreo, _
                                        New List(Of String), _
                                        "Solicitud de Reprogramacion de: " + lProveedor.NOMBRE_PROVEEDOR, CUERPO, Nothing, listaDestinatarios)
            Else
                Return -1
            End If

        Catch ex As Exception
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que envía un correo de Resultado para una Solicitud de Reprogramación
    ''' </summary>
    ''' <param name="CUERPO"></param>    
    ''' <param name="USUARIO_REMITENTE"></param> 
    ''' <param name="USUARIO_DESTINATARIO"></param> 
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function EnviarResultadoEvaluacionPorCorreo(ByVal CUERPO As String, ByVal USUARIO_REMITENTE As String, ByVal USUARIO_DESTINATARIO As String) As Integer
        Try
            Dim CorreoTecnico As String
            Dim CorreoCentro As String
            Dim listaGerenteGFI As New List(Of String)
            Dim listaCoordinadorGFI As New List(Of String)
            Dim listaSoporteGFI As New List(Of String)
            Dim listaCCO As New List(Of String)

            'Referencia al MembershipProvider personalizado
            Dim _mp As New cmembershipProvider
            _mp = CType(Membership.Provider, cmembershipProvider)

            'Obtener el correo electrónico del técnico asignado
            CorreoTecnico = _mp.ObtenerEmailPorNombreUsuario(USUARIO_REMITENTE)

            'Obtener los correo de los destinatarios
            listaCCO = (New cListasDeDistribucionCorreo).ListaCorreosParaAutorizaciones
            CorreoCentro = _mp.ObtenerEmailPorNombreUsuario(USUARIO_DESTINATARIO)

            If CorreoTecnico <> "" AndAlso CorreoCentro <> "" AndAlso listaCCO.Count > 0 Then
                If Not listaCCO.Contains(CorreoTecnico) Then listaCCO.Add(CorreoTecnico)

                Return _mp.EnviarCorreo(CorreoTecnico, CorreoCentro, "INSAFORP - Evaluacion de Solicitud de Reprogramacion", CUERPO, Nothing, listaCCO)
            Else
                Return -1
            End If

        Catch ex As Exception
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	09/01/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriteriosRoles(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                    ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                    ByVal ID_AREA_FORMACION As Decimal, _
                                                    ByVal NOMBRE_ACCION_FORMATIVA As String, _
                                                    ByVal CODIGO_GRUPO As String, _
                                                    ByVal ID_EJERCICIO As String, _
                                                    ByVal listaROLES As String, _
                                                    ByVal ID_ESTADO_REPROG As Decimal, _
                                                    ByVal TDR As String, _
                                                    Optional ByVal asColumnaOrden As String = "", _
                                                    Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA_REPROG
        Try
            Dim lListaCursos As listaACCION_FORMATIVA_REPROG
            Dim lListaResultado As New listaACCION_FORMATIVA_REPROG
            Dim lUsuario As USUARIO = (New cUSUARIO).ObtenerUSUARIO(Utilerias.ObtenerUsuario)
            Dim listaID_PROGRAMA_FORMACION As New List(Of Decimal)
            Dim listaProgramasPorRol As New listaPROGRAMA_FORMACION
            Dim alistaROLES As New List(Of String)
            Dim lsRoles As String() = listaROLES.Split(";")

            For i As Integer = 0 To lsRoles.Length - 1
                alistaROLES.Add(lsRoles(i))
            Next

            If listaROLES.Contains(RolDeUsuario.Administrador) OrElse _
                                      listaROLES.Contains(RolDeUsuario.GerenteGFI) OrElse _
                                      listaROLES.Contains(RolDeUsuario.CoordinadorGFI) OrElse _
                                      listaROLES.Contains(RolDeUsuario.SoporteGFI) OrElse _
                                      listaROLES.Contains(RolDeUsuario.TecnicoGFI) OrElse _
                                      listaROLES.Contains(RolDeUsuario.AsistenteGFI) OrElse _
                                      listaROLES.Contains(RolDeUsuario.CAGestion) OrElse _
                                      listaROLES.Contains(RolDeUsuario.CARevision) OrElse _
                                      listaROLES.Contains(RolDeUsuario.CARecepcion) Then
                listaID_PROGRAMA_FORMACION = Nothing
            Else

                'Obtener Lista de Programas de Formación de acuerdo a los Roles 
                listaProgramasPorRol = (New cPROGRAMA_FORMACION).ObtenerListaPorROLES(alistaROLES)
                If listaProgramasPorRol IsNot Nothing AndAlso listaProgramasPorRol.Count > 0 Then
                    For i As Integer = 0 To listaProgramasPorRol.Count - 1
                        listaID_PROGRAMA_FORMACION.Add(listaProgramasPorRol(i).ID_PROGRAMA_FORMACION)
                    Next
                End If
            End If

            'Obtener Lista de Cursos Reprogramados por Proveedor, Programa de Formación
            lListaCursos = mDb.ObtenerListaPorCriteriosRoles(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_AREA_FORMACION, NOMBRE_ACCION_FORMATIVA, CODIGO_GRUPO, ID_EJERCICIO, ID_ESTADO_REPROG, listaID_PROGRAMA_FORMACION, TDR, asColumnaOrden, asTipoOrden)

            If lListaCursos IsNot Nothing AndAlso lListaCursos.Count > 0 Then
                For i As Integer = 0 To lListaCursos.Count - 1
                    Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = _
                        (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lListaCursos(i).ID_ACCION_FORMATIVA)

                    If lAccionDetalle.ID_PROGRAMA_FORMACION = ProgramasFormacion.HABIL_TECNICO_PERMANENTE Then
                        Select Case True
                            Case listaROLES.Contains(RolDeUsuario.Proveedor) AndAlso lUsuario.ID_PROVEEDOR_AF = lListaCursos(i).ID_PROVEEDOR_AF
                                lListaResultado.Add(lListaCursos(i))
                            Case listaROLES.Contains(RolDeUsuario.CentroCapacitador) AndAlso (lUsuario.ID_SITIO_CAPACITACION = lListaCursos(i).ID_SITIO_CAPACITACION OrElse lListaCursos(i).ID_SITIO_CAPACITACION = -1)
                                lListaResultado.Add(lListaCursos(i))
                            Case listaROLES.Contains(RolDeUsuario.Administrador), _
                                       listaROLES.Contains(RolDeUsuario.GerenteGFI), _
                                       listaROLES.Contains(RolDeUsuario.CoordinadorGFI), _
                                       listaROLES.Contains(RolDeUsuario.SoporteGFI), _
                                       listaROLES.Contains(RolDeUsuario.TecnicoGFI), _
                                       listaROLES.Contains(RolDeUsuario.AsistenteGFI), _
                                       listaROLES.Contains(RolDeUsuario.CAGestion), _
                                       listaROLES.Contains(RolDeUsuario.CARevision), _
                                       listaROLES.Contains(RolDeUsuario.CARecepcion)
                                lListaResultado.Add(lListaCursos(i))
                        End Select
                    Else
                        Select Case True
                            Case alistaROLES.Exists(AddressOf EmpiezaConProveedor) AndAlso lUsuario.ID_PROVEEDOR_AF = lListaCursos(i).ID_PROVEEDOR_AF
                                lListaResultado.Add(lListaCursos(i))
                            Case Else
                                lListaResultado.Add(lListaCursos(i))
                        End Select
                    End If
                Next
            End If
            Return lListaResultado

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Private Shared Function EmpiezaConProveedor(ByVal s As String) As Boolean
        Return s.StartsWith("Proveedor")
    End Function
End Class








