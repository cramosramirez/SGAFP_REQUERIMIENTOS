Imports SQLMembershipProvider.BL
Imports System.Web.Security
Imports System.Text
Imports SGAFP.EL.Enumeradores


Partial Class cACCION_FORMATIVA


    Public Function ObtenerPorcentajeAvancePorAccionFormativa(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA As Date) As Dictionary(Of String, Decimal)

        Try
            Return mDb.ObtenerPorcentajeAvancePorAccionFormativa(ID_ACCION_FORMATIVA, FECHA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerCorrelativoCodigoEC(ByVal CODIGO_GRUPO As String) As Decimal

        Try
            Return mDb.ObtenerCorrelativoCodigoEC(CODIGO_GRUPO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function EsAccionFormativaOnline(ByVal ID_ACCION_FORMATIVA As Decimal) As Boolean

        Try
            Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROSPorID_ACCION_FORMATIVA(ID_ACCION_FORMATIVA)
            If lContrato IsNot Nothing Then
                If lContrato.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorCurso_CostoParticipante_Online Then
                    Return True
                End If
            End If
            Return False

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return False
        End Try
    End Function

    Public Function ObtenerInfoContratacion(ByVal ID_ACCION_FORMATIVA As Decimal) As String

        Try
            Return mDb.ObtenerInfoContratacion(ID_ACCION_FORMATIVA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return ""
        End Try
    End Function

    Public Function ObtenerMontoCapacitacionHTP(ByVal ID_PARTICIPANTE As Decimal, ByVal ID_EJERCICIO As String) As Dictionary(Of String, Decimal)

        Try
            Return mDb.ObtenerMontoCapacitacionHTP(ID_PARTICIPANTE, ID_EJERCICIO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function EsAccionFormativaBolpros(ByVal ID_ACCION_FORMATIVA As Decimal) As Boolean

        Try
            Return mDb.EsAccionFormativaBolpros(ID_ACCION_FORMATIVA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return False
        End Try
    End Function

    Public Function EsAccionFormativaPorSolicitudCapacitacion(ByVal ID_ACCION_FORMATIVA As Decimal) As Boolean

        Try
            Return mDb.EsAccionFormativaPorSolicitudCapacitacion(ID_ACCION_FORMATIVA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return False
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	05/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal NOMBRE_ACCION_FORMATIVA As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA
        Try
            Return mDb.ObtenerListaPorCriterios(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, NOMBRE_ACCION_FORMATIVA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	17/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_AREA_FORMACION As Decimal, ByVal NOMBRE_ACCION_FORMATIVA As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA
        Try
            Return mDb.ObtenerListaPorCriterios(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_AREA_FORMACION, NOMBRE_ACCION_FORMATIVA, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	22/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                    ByVal CODIGO_GRUPO As String, _
                                                    ByVal ID_EJERCICIO As String, _
                                                    ByVal CODIGO_ESTADO_AF As String, _
                                                    ByVal NUM_LICITACION As String) As listaACCION_FORMATIVA
        Try
            Return mDb.ObtenerListaPorCriterios(ID_PROVEEDOR_AF, CODIGO_GRUPO, ID_EJERCICIO, CODIGO_ESTADO_AF, NUM_LICITACION)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriteriosPeriodo(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_AREA_FORMACION As Decimal, ByVal NOMBRE_ACCION_FORMATIVA As String, ByVal CODIGO_GRUPO As String, ByVal ID_EJERCICIO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA
        Try
            Return mDb.ObtenerListaPorCriteriosPeriodo(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_AREA_FORMACION, NOMBRE_ACCION_FORMATIVA, CODIGO_GRUPO, ID_EJERCICIO, "", "", asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/03/2010	Created
    ''' 	[ecarias]	18/03/2010	Se agrego parametro de TDR
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriteriosPeriodoEstado(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_AREA_FORMACION As Decimal, ByVal NOMBRE_ACCION_FORMATIVA As String, ByVal CODIGO_GRUPO As String, ByVal CODIGO_ESTADO_AF As String, ByVal ID_EJERCICIO As String, ByVal TDR As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA
        Try
            Return mDb.ObtenerListaPorCriteriosPeriodo(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_AREA_FORMACION, NOMBRE_ACCION_FORMATIVA, CODIGO_GRUPO, ID_EJERCICIO, TDR, CODIGO_ESTADO_AF)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriteriosPeriodoMatriculaIniciado(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_AREA_FORMACION As Decimal, ByVal NOMBRE_ACCION_FORMATIVA As String, ByVal CODIGO_GRUPO As String, ByVal ID_EJERCICIO As String, ByVal listaROLES As String, ByVal TDR As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA
        Try
            Dim ListaCursos As New listaACCION_FORMATIVA
            Dim ListaCursosDisponibilidad As New listaACCION_FORMATIVA
            Dim ESTADOS_AF As New List(Of String)
            Dim alistaROLES As New List(Of String)
            Dim alistaCODIGO_ESTADO_AF As New List(Of String)
            Dim lsRoles As String() = listaROLES.Split(";")
            Dim listaProgramasPorRol As New listaPROGRAMA_FORMACION
            Dim listaID_PROGRAMA_FORMACION As New List(Of Decimal)
            Dim bUnidadOrganizativa As New cUNIDAD_ORGANIZATIVA

            For i As Integer = 0 To lsRoles.Length - 1
                alistaROLES.Add(lsRoles(i))
            Next
            'Obtener Lista de Programas de Formación de acuerdo a los Roles 
            listaProgramasPorRol = (New cPROGRAMA_FORMACION).ObtenerListaPorROLES(alistaROLES)
            If listaProgramasPorRol IsNot Nothing AndAlso listaProgramasPorRol.Count > 0 Then
                For i As Integer = 0 To listaProgramasPorRol.Count - 1
                    listaID_PROGRAMA_FORMACION.Add(listaProgramasPorRol(i).ID_PROGRAMA_FORMACION)
                Next
            End If

            ESTADOS_AF.Add(Enumeradores.EstadoAccionFormativa.EnMatricula)
            ESTADOS_AF.Add(Enumeradores.EstadoAccionFormativa.Iniciada)
            ESTADOS_AF.Add(Enumeradores.EstadoAccionFormativa.Finalizada)
            ListaCursos = mDb.ObtenerListaPorCriteriosRoles(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_AREA_FORMACION, NOMBRE_ACCION_FORMATIVA, CODIGO_GRUPO, ID_EJERCICIO, ESTADOS_AF, listaID_PROGRAMA_FORMACION, TDR, asColumnaOrden, asTipoOrden)

            'Validar que los cursos en estado iniciados no hayan sobrepasado el 20% de asistencia
            For Each curso As ACCION_FORMATIVA In ListaCursos
                Dim lProgramaFormacion As Integer = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(curso.ID_ACCION_FORMATIVA)
                Dim lInformes As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA_ESTADO_INFORME(curso.ID_ACCION_FORMATIVA, EstadoInformeFinal.InformeDevueltoConObservaciones)
                If curso.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.EnMatricula OrElse curso.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Iniciada Then
                    Dim lAsistenciaAF As listaASISTENCIA_AF
                    lAsistenciaAF = (New cASISTENCIA_AF).ObtenerListaPorACCION_FORMATIVA(curso.ID_ACCION_FORMATIVA, False, False, "FECHA")
                    If lAsistenciaAF.Count > 0 AndAlso (lProgramaFormacion = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE OrElse lProgramaFormacion = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL) Then
                        Dim veintePorc As Integer = CInt(curso.DURACION_HORAS * 60 * 0.2)
                        Dim acumMinutos As Integer = 0
                        Dim fechaLimite As Object = Nothing

                        For Each eAsistencia As ASISTENCIA_AF In lAsistenciaAF
                            acumMinutos += eAsistencia.CANTIDAD_HORAS
                            If acumMinutos > veintePorc Then
                                fechaLimite = eAsistencia.FECHA
                                Exit For
                            End If
                        Next

                        If fechaLimite IsNot Nothing AndAlso CDate(fechaLimite) >= Today Then
                            ListaCursosDisponibilidad.Add(curso)
                        ElseIf fechaLimite IsNot Nothing Then
                            Dim listaInscripcionExtempo As listaACCION_PROGRA_RETRO
                            listaInscripcionExtempo = (New cACCION_PROGRA_RETRO).ObtenerACCION_PROGRA_RETRO_PorCriterios(curso.ID_PROVEEDOR_AF, _
                                                                                               curso.ID_EJERCICIO, _
                                                                                               curso.CODIGO_GRUPO, _
                                                                                               EstadoAccionFormativa.EnMatricula, _
                                                                                               1)
                            If listaInscripcionExtempo IsNot Nothing AndAlso listaInscripcionExtempo.Count > 0 AndAlso listaInscripcionExtempo(0).FECHA_EXPIRA >= Today Then
                                ListaCursosDisponibilidad.Add(curso)
                            End If
                        End If
                    Else
                        If (lProgramaFormacion = Enumeradores.ProgramasFormacion.PATI_USAID OrElse _
                            lProgramaFormacion = Enumeradores.ProgramasFormacion.PATI_BM OrElse _
                            lProgramaFormacion = Enumeradores.ProgramasFormacion.PATI_2 OrElse _
                            lProgramaFormacion = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL OrElse _
                            lProgramaFormacion = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE) Then
                            ListaCursosDisponibilidad.Add(curso)
                        End If
                    End If
                ElseIf curso.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Finalizada Then
                    If (lProgramaFormacion = Enumeradores.ProgramasFormacion.PATI_USAID OrElse _
                        lProgramaFormacion = Enumeradores.ProgramasFormacion.PATI_BM OrElse _
                        lProgramaFormacion = Enumeradores.ProgramasFormacion.PATI_2) OrElse _
                       (lInformes IsNot Nothing AndAlso lInformes.Count > 0 AndAlso lProgramaFormacion = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL) Then
                        ListaCursosDisponibilidad.Add(curso)
                    End If
                Else
                    ListaCursosDisponibilidad.Add(curso)
                End If
            Next
            Return ListaCursosDisponibilidad

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve la cantidad de participantes inscritos para la Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	15/03/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCantidadParticipantesInscritos(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Try
            Return mDb.ObtenerCantidadParticipantesInscritos(ID_ACCION_FORMATIVA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve la cantidad de participantes por los cuales se pagará para la Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	23/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCantidadParticipantesParaPago(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Try
            Return mDb.ObtenerCantidadParticipantesParaPago(ID_ACCION_FORMATIVA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerCantidadParticipantesParaPagoPorES_CAPACITADO(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Try
            Return mDb.ObtenerCantidadParticipantesParaPagoPorES_CAPACITADO(ID_ACCION_FORMATIVA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_FORMATIVA(ByVal aEntidad As ACCION_FORMATIVA) As Integer
        Try
            Return Me.ActualizarACCION_FORMATIVA(aEntidad, TipoConcurrencia.Pesimistica)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_FORMATIVA_SIN_VALIDACION(ByVal aEntidad As ACCION_FORMATIVA, ByVal comentario As String) As Integer
        Try
            Dim lRet As Int32 = 0
            lRet = mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)

            Dim mComponente As New cACCION_FORMATIVA_HIST
            If mComponente.AgregarACCION_FORMATIVA_HIST(0, aEntidad.ID_ACCION_FORMATIVA, _
                    aEntidad.ID_OFERTA_FORMATIVA, aEntidad.ID_SITIO_CAPACITACION, aEntidad.ID_PROVEEDOR_AF, _
                    aEntidad.ID_TEMA_CURSO, aEntidad.ID_EJERCICIO, aEntidad.NOMBRE_ACCION_FORMATIVA, _
                    aEntidad.CODIGO_GRUPO, aEntidad.NUMERO_PARTICIPANTES, aEntidad.PARTICIPANTES_INSCRITOS, _
                    aEntidad.HORARIO, aEntidad.NOTAS, aEntidad.CODIGO_ESTADO_AF, aEntidad.DURACION_HORAS, _
                    aEntidad.COSTO_X_PARTICIPANTE, aEntidad.LASTUPDATE, aEntidad.USERID, _
                    aEntidad.FECHA_INICIO_REAL, aEntidad.FECHA_FIN_REAL, comentario, aEntidad.ID_ACCION_CONTRATADA, aEntidad.CODI_FORMADOR, aEntidad.NOMBRE_FORMADOR) <> 1 Then
                Me.sError = mComponente.sError
                Return -1
            End If

            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ActualizarACCION_FORMATIVA_SIN_VALIDACION2(ByVal aEntidad As ACCION_FORMATIVA) As Integer
        Try
            Dim lRet As Int32 = 0
            lRet = mDb.Actualizar(aEntidad, TipoConcurrencia.Pesimistica)

            Return lRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' 	[ecarias]	07/05/2010	Se agrego Logica para Finalizar Solicitudes al momento de Finalizar un Curso
    '''     [cramos]    24/01/2012  Se agrego Logica para Validar que el curso no sobrepase el monto adjudicado en la SubAreaFormativa
    '''     [cramos]    02/05/2012  Se agrego Logica para Validar que el curso no sobrepase las participaciones adjudicadas en la SubAreaFormativa
    '''     [cramos]    08/07/2016  Se agrego Logica para Validar que las fechas de ejecución de un curso por solicitud de capacitación este dentro del período de validez del contrato
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_FORMATIVA(ByVal aEntidad As ACCION_FORMATIVA, ByVal aTipoConcurrencia As TipoConcurrencia, Optional ByVal GenHistorico As Boolean = True, Optional ByVal ConCambioEstado As Boolean = True, Optional ByVal ConNotificacion As Boolean = True, Optional EsAprobacionReprog As Boolean = False) As Integer
        Try
            Dim bPrograRetro As New cACCION_PROGRA_RETRO
            Dim listaPrograRetro As listaACCION_PROGRA_RETRO
            Dim listaAutoFinalizacion As listaACCION_PROGRA_RETRO
            Dim esNuevo As Boolean = True
            Dim aListaAccionFormativa As listaACCION_FORMATIVA
            Dim lRet As Integer
            Dim aEntidadOld As New ACCION_FORMATIVA
            Dim lTerminoRef As TERMINO_REFERENCIA_AF
            Dim lFechaInicial As Date
            Dim bUnidadOrganizativa As New cUNIDAD_ORGANIZATIVA

            If aEntidad.ID_ACCION_FORMATIVA > 0 Then
                esNuevo = False
                aEntidadOld = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
            End If

            Dim accionCriterio As New ACCION_FORMATIVA
            Dim criterios As New List(Of Criteria)

            criterios.Add(New Criteria("CODIGO_GRUPO", "=", aEntidad.CODIGO_GRUPO, "AND"))
            criterios.Add(New Criteria("ID_EJERCICIO", "=", aEntidad.ID_EJERCICIO, ""))
            accionCriterio.CODIGO_GRUPO = aEntidad.CODIGO_GRUPO
            accionCriterio.ID_EJERCICIO = aEntidad.ID_EJERCICIO
            aListaAccionFormativa = (New cACCION_FORMATIVA).ObtenerListaPorBusqueda(accionCriterio, criterios.ToArray)

            If esNuevo Then
                'Verificar si ya existe un código de grupo asignado en el ejercicio para una accion formativa 
                If aListaAccionFormativa IsNot Nothing AndAlso aListaAccionFormativa.Count > 0 Then
                    Me.sError = "Codigo de grupo ya esta asignado para el Ejercicio " + aEntidad.ID_EJERCICIO
                    Return -1
                End If
            Else
                If aListaAccionFormativa IsNot Nothing AndAlso aListaAccionFormativa.Count > 0 Then
                    For Each cEntidadCurso As ACCION_FORMATIVA In aListaAccionFormativa
                        If cEntidadCurso.ID_ACCION_FORMATIVA <> aEntidad.ID_ACCION_FORMATIVA Then
                            Me.sError = "Codigo de grupo ya esta asignado"
                            Return -1
                        End If
                    Next
                End If
                If aEntidad.NOTAS <> Nothing AndAlso aEntidad.NOTAS.Trim.Length < 8 Then
                    Me.sError = "El nombre del instructor es muy corto"
                    Return -1
                End If
            End If

            'El cupo no debe ser mayor a 22 participantes
            If aEntidad.NUMERO_PARTICIPANTES > 22 AndAlso aEntidad.ID_SITIO_CAPACITACION <> -1 Then
                Me.sError = "Cupo no puede ser mayor de 22 participantes"
                Return -1
            End If

            'Validar que la Fecha Inicial no sea menor que la Fecha Final
            If aEntidad.FECHA_INICIO_REAL > aEntidad.FECHA_FIN_REAL Then
                Me.sError = "La Fecha de Inicio no puede ser mayor que la Fecha de Finalizacion del Curso"
                Return -1
            End If

            lTerminoRef = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(aEntidad.ID_ACCION_FORMATIVA)
            If aEntidad.ID_OFERTA_FORMATIVA > 0 AndAlso aEntidad.ID_SITIO_CAPACITACION > 0 Then
                'Validar que las fechas de la Accion Formativa se encuentren en el Rango de Fechas de la Oferta Formativa
                Dim lEntidadOferta As OFERTA_FORMATIVA = (New cOFERTA_FORMATIVA).ObtenerOFERTA_FORMATIVA(aEntidad.ID_OFERTA_FORMATIVA)

                If lEntidadOferta IsNot Nothing AndAlso Not (aEntidad.FECHA_INICIO_REAL >= lEntidadOferta.FECHA_INICIO AndAlso aEntidad.FECHA_FIN_REAL <= lEntidadOferta.FECHA_FIN) Then
                    Me.sError = "La Fechas de Inicio / Finalizacion del Curso deben estar comprendidas entre el " + _
                        lEntidadOferta.FECHA_INICIO.ToString("dd/MM/yyyy") + " al " + lEntidadOferta.FECHA_FIN.ToString("dd/MM/yyyy")
                    Return -1
                End If
            End If


            Dim lAccionDetalle01 As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(aEntidad.ID_ACCION_FORMATIVA)
            Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROSPorID_ACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
            Dim sOfertaCompra As String = ""

            If lContrato IsNot Nothing Then
                Dim lContratoCompra As CONTRATO_COMPRA = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRA(lContrato.ID_CONTRATO_COMPRA)
                If lContratoCompra IsNot Nothing Then sOfertaCompra = lContratoCompra.NO_CONTRATO_COMPRA
            End If

            'Validar que la fecha de inicio del curso no se mayor a la fecha limite de inicio de curso de calendarización de la Oferta de compra
            If lContrato IsNot Nothing Then
                Dim lOfertaCompra As CONTRATO_COMPRA = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRA(lContrato.ID_CONTRATO_COMPRA)
                If lOfertaCompra IsNot Nothing AndAlso lOfertaCompra.ULTFECHA_CALENDARIZA <> #12:00:00 AM# AndAlso lOfertaCompra.ULTFECHA_CALENDARIZA <> Nothing Then
                    If aEntidad.FECHA_INICIO_REAL > lOfertaCompra.ULTFECHA_CALENDARIZA Then

                        listaPrograRetro = bPrograRetro.ObtenerACCION_PROGRA_RETRO_PorCriterios(aEntidad.ID_PROVEEDOR_AF, _
                                                                                           aEntidad.ID_EJERCICIO, _
                                                                                           aEntidad.CODIGO_GRUPO, _
                                                                                           AutorizacionExcepcion.InicioCursoPosteriorUltimaFechaInicioOferta, _
                                                                                           1)
                        If listaPrograRetro Is Nothing OrElse listaPrograRetro.Count = 0 Then
                            Me.sError = "La fecha de inicio del curso no puede ser mayor a la fecha limite de inicio establecida en la oferta de Compra. La fecha limite para iniciar cursos es el: " + lOfertaCompra.ULTFECHA_CALENDARIZA.ToString("dd/MM/yyyy")
                            Return -1
                        End If
                    End If
                End If
            End If

            'Validar que la fecha de inicio real del curso no sea menor a la fecha actual
            If Not bUnidadOrganizativa.EsDeUnidaOrganizativa(aEntidad.ID_ACCION_FORMATIVA, Enumeradores.UnidadOrganizativa.CentroFormacionSanBartolo) Then
                If Not EsAprobacionReprog AndAlso ((esNuevo AndAlso aEntidad.FECHA_INICIO_REAL < Today) OrElse (Not esNuevo AndAlso aEntidad.FECHA_INICIO_REAL <> aEntidadOld.FECHA_INICIO_REAL AndAlso aEntidad.FECHA_INICIO_REAL < Today)) Then
                    'Verificar si hay una autorización de programación retroactiva activa
                    listaPrograRetro = bPrograRetro.ObtenerACCION_PROGRA_RETRO_PorCriterios(aEntidad.ID_PROVEEDOR_AF, _
                                                                                            aEntidad.ID_EJERCICIO, _
                                                                                            aEntidad.CODIGO_GRUPO, _
                                                                                            AutorizacionExcepcion.ProgramacionRetroactiva, _
                                                                                            1)
                    If listaPrograRetro IsNot Nothing AndAlso listaPrograRetro.Count > 0 AndAlso listaPrograRetro(0).FECHA_EXPIRA >= Today Then
                        listaPrograRetro(0).ID_ACCION_FORMATIVA = aEntidad.ID_ACCION_FORMATIVA
                        listaPrograRetro(0).USUARIO_PROGRAMO = aEntidad.USERID
                        listaPrograRetro(0).FECHA_PROGRAMO = Now
                        listaPrograRetro(0).ACTIVO = 0
                        listaPrograRetro(0).USERID = aEntidad.USERID
                        listaPrograRetro(0).LASTUPDATE = Now
                    Else
                        Me.sError = "La Fecha de Inicio del Curso no puede ser menor a la fecha actual ni menor que la primera Fecha de Inicio que se ingreso"
                        Return -1
                    End If
                End If
            End If

            If esNuevo AndAlso (lAccionDetalle01 Is Nothing OrElse lAccionDetalle01.ID_ACCION_FORMATIVA = 0) Then
                If Not EsAprobacionReprog AndAlso ((esNuevo AndAlso aEntidad.FECHA_INICIO_REAL < Today) OrElse (Not esNuevo AndAlso aEntidad.FECHA_INICIO_REAL <> aEntidadOld.FECHA_INICIO_REAL AndAlso aEntidad.FECHA_INICIO_REAL < Today)) Then
                    'Verificar si hay una autorización de programación retroactiva activa
                    listaPrograRetro = bPrograRetro.ObtenerACCION_PROGRA_RETRO_PorCriterios(aEntidad.ID_PROVEEDOR_AF, _
                                                                                            aEntidad.ID_EJERCICIO, _
                                                                                            aEntidad.CODIGO_GRUPO, _
                                                                                            AutorizacionExcepcion.ProgramacionRetroactiva, _
                                                                                            1)
                    If listaPrograRetro IsNot Nothing AndAlso listaPrograRetro.Count > 0 AndAlso listaPrograRetro(0).FECHA_EXPIRA >= Today Then
                        listaPrograRetro(0).ID_ACCION_FORMATIVA = aEntidad.ID_ACCION_FORMATIVA
                        listaPrograRetro(0).USUARIO_PROGRAMO = aEntidad.USERID
                        listaPrograRetro(0).FECHA_PROGRAMO = Now
                        listaPrograRetro(0).ACTIVO = 0
                        listaPrograRetro(0).USERID = aEntidad.USERID
                        listaPrograRetro(0).LASTUPDATE = Now
                    Else
                        Me.sError = "La Fecha de Inicio del Curso no puede ser menor a la fecha actual ni menor que la primera Fecha de Inicio que se ingreso"
                        Return -1
                    End If
                End If
            End If

            'Verificar que no exista conflicto de horario del formador
            If Not EsAprobacionReprog AndAlso Not esNuevo AndAlso aEntidad.CODI_FORMADOR <> "" AndAlso (sOfertaCompra <> "109/2017" AndAlso sOfertaCompra <> "140/2017") AndAlso _
                lAccionDetalle01.ID_PROGRAMA_FORMACION <> ProgramasFormacion.EMPRESA_CENTRO Then
                Dim bAccionFormativa As New cACCION_FORMATIVA
                Dim ds As DataSet

                'Validar conflicto de horario con otro curso
                ds = bAccionFormativa.ObtenerAccionFormativa_Horario_enConflictoFormador(aEntidad.CODI_FORMADOR, aEntidad.ID_ACCION_FORMATIVA)
                If ds IsNot Nothing AndAlso ds.Tables(0).Rows.Count > 0 Then

                    listaPrograRetro = bPrograRetro.ObtenerACCION_PROGRA_RETRO_PorCriterios(aEntidad.ID_PROVEEDOR_AF, _
                                                                                        aEntidad.ID_EJERCICIO, _
                                                                                        aEntidad.CODIGO_GRUPO, _
                                                                                        AutorizacionExcepcion.HorarioSimultaneoInstructor, _
                                                                                        1)
                    If listaPrograRetro IsNot Nothing AndAlso listaPrograRetro.Count > 0 Then
                        If listaPrograRetro(0).FECHA_PROGRAMO = #12:00:00 AM# Then
                            listaPrograRetro(0).ID_ACCION_FORMATIVA = aEntidad.ID_ACCION_FORMATIVA
                            listaPrograRetro(0).USUARIO_PROGRAMO = aEntidad.USERID
                            listaPrograRetro(0).FECHA_PROGRAMO = Now
                            listaPrograRetro(0).USERID = aEntidad.USERID
                            listaPrograRetro(0).LASTUPDATE = Now
                        End If
                    Else
                        If IsDate(ds.Tables(0).Rows(0)("INICIO")) Then
                            Me.sError = "El formador imparte el curso " + ds.Tables(0).Rows(0)("NOMBRE_ACCION_FORMATIVA") + " " + ds.Tables(0).Rows(0)("CODIGO_GRUPO") + " que posee un horario simultaneo con el curso actual en la fecha " + _
                            CDate(ds.Tables(0).Rows(0)("INICIO")).ToShortDateString + " y horario de " + Format(ds.Tables(0).Rows(0)("INICIO"), "hh:mm tt") + " a " + Format(ds.Tables(0).Rows(0)("FIN"), "hh:mm tt")
                        Else
                            Me.sError = "El formador imparte el curso " + ds.Tables(0).Rows(0)("NOMBRE_ACCION_FORMATIVA") + " " + ds.Tables(0).Rows(0)("CODIGO_GRUPO") + " que posee un horario simultaneo con el curso actual"
                        End If
                        Return -1
                    End If
                End If
            End If


            'Verificar el período de validez de un curso 
            If Not esNuevo AndAlso aEntidad.HORARIO <> "PENDIENTE DE DEFINIR" AndAlso Me.EsAccionFormativaPorSolicitudCapacitacion(aEntidad.ID_ACCION_FORMATIVA) Then
                If lContrato IsNot Nothing Then
                    If aEntidad.FECHA_INICIO_REAL < lContrato.FECHA_INI_EJEC Then
                        Me.sError = "La Fecha de Inicio del Curso no puede ser menor a la fecha inicial del periodo de validez del contrato: " + lContrato.NUM_CONTRATO
                        Return -1
                    End If
                    If aEntidad.FECHA_FIN_REAL > lContrato.FECHA_FIN_EJEC Then
                        Me.sError = "La Fecha de finalizacion del Curso no puede ser mayor a la fecha final del periodo de validez del contrato: " + lContrato.NUM_CONTRATO
                        Return -1
                    End If
                End If
            End If

            'Validar la Generación del Informe Final antes de Finalizar el Curso
            If (Not esNuevo) AndAlso aEntidadOld.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Iniciada And aEntidad.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Finalizada Then
                Dim bInforme As New cINFORME_FINAL_AF
                Dim lResultado As String
                Dim lcINFORME_FINAL_AF As New cINFORME_FINAL_AF
                Dim lInformesGenerados As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
                lFechaInicial = aEntidadOld.FECHA_INICIO_REAL
                If lInformesGenerados IsNot Nothing AndAlso lInformesGenerados.Count > 0 Then
                    Dim listaAsistencia As listaASISTENCIA_AF = (New cASISTENCIA_AF).ObtenerListaPorACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA, False, False, "FECHA")
                    lInformesGenerados.SortByColum("FECHA_FINAL", ComponentModel.ListSortDirection.Descending)
                    lFechaInicial = lInformesGenerados(0).FECHA_FINAL
                    For Each lAsistencia As ASISTENCIA_AF In listaAsistencia
                        If lAsistencia.FECHA > lFechaInicial Then
                            lFechaInicial = lAsistencia.FECHA
                            Exit For
                        End If
                    Next
                End If

                lResultado = bInforme.EsPeriodoValido(aEntidad.ID_ACCION_FORMATIVA, lFechaInicial, aEntidad.FECHA_FIN_REAL, True)
                If lResultado <> String.Empty Then
                    Me.sError = lResultado
                    Return -1
                End If
            End If

            If (Not esNuevo) AndAlso aEntidad.CODIGO_ESTADO_AF <> aEntidadOld.CODIGO_ESTADO_AF AndAlso GenHistorico Then

                If ((aEntidadOld.CODIGO_ESTADO_AF = EstadoAccionFormativa.Ingresada AndAlso aEntidad.CODIGO_ESTADO_AF = EstadoAccionFormativa.EnMatricula) OrElse _
                    (aEntidadOld.CODIGO_ESTADO_AF = EstadoAccionFormativa.EnMatricula AndAlso aEntidad.CODIGO_ESTADO_AF = EstadoAccionFormativa.Iniciada)) _
                    AndAlso aEntidad.CODI_FORMADOR = "" AndAlso _
                    Not Me.EsAccionFormativaOnline(aEntidad.ID_ACCION_FORMATIVA) Then

                    Me.sError = " Edite el curso y asigne el NIT del Formador antes de cambiar de estado el curso"
                    Return -1
                End If

                Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(aEntidad.ID_ACCION_FORMATIVA)

                'Validar la cuota de capacitacion de cada participante
                If lAccionDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE Then
                    Dim listaInscritos As listaSOLICITUD_INSCRIPCION_AF = (New cSOLICITUD_INSCRIPCION_AF).ObtenerListaPorACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
                    Dim sWarning As New StringBuilder
                    Dim montoCapacitacion As New Dictionary(Of String, Decimal)
                    Dim montoApoyoAnual As Decimal = (New cPROGRAMA_FORMACION).ObtenerMontoApoyoParticipantePorPrograma(lAccionDetalle.ID_PROGRAMA_FORMACION)
                    Dim lParticipante As PARTICIPANTE

                    If listaInscritos IsNot Nothing AndAlso listaInscritos.Count > 0 Then
                        For Each lSol As SOLICITUD_INSCRIPCION_AF In listaInscritos
                            montoCapacitacion = Me.ObtenerMontoCapacitacionHTP(lSol.ID_PARTICIPANTE, aEntidad.ID_EJERCICIO)
                            If montoCapacitacion Is Nothing Then
                                Me.sError = " No se logro obtener el monto de capacitacion para el participante "
                                Return -1
                            ElseIf montoCapacitacion.Count > 0 AndAlso montoCapacitacion("MONTO") > montoApoyoAnual AndAlso montoCapacitacion("CANTIDAD") > CDec(1) AndAlso _
                                    (lSol.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Aprobada OrElse lSol.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Finalizada) Then
                                lParticipante = (New cPARTICIPANTE).ObtenerPARTICIPANTE(lSol.ID_PARTICIPANTE)
                                sWarning.Append(lParticipante.NOMBRES)
                                sWarning.Append(" ")
                                sWarning.Append(lParticipante.APELLIDOS)
                                sWarning.AppendLine("; ")
                            End If
                        Next
                    End If

                    If sWarning.ToString <> "" Then
                        Me.sError = "Los participantes siguientes han soprepasado su cuota de capacitacion: " + vbCrLf + _
                                    sWarning.ToString + " debe anular estas participaciones"
                        Return -1
                    End If
                End If

                'Se agrego Logica para Validar que el curso no sobrepase el monto adjudicado en la SubAreaFormativa
                If aEntidad.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Finalizada Then
                    'Validar la cantidad de horas de la calendarización


                    If lContrato IsNot Nothing AndAlso lContrato.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorCurso_CostoParticipante_Online Then
                        Dim dMontoEjecutado As Decimal = (New cCONTRATO_BOLPROS).ObtenerMontoEjecutadoPorContrato(lContrato.ID_CONTRATO)
                        Dim esteCurso As Decimal = Math.Round(aEntidad.COSTO_X_PARTICIPANTE * Me.ObtenerCantidadParticipantesParaPagoPorES_CAPACITADO(aEntidad.ID_ACCION_FORMATIVA), 2)
                        dMontoEjecutado += esteCurso

                        If dMontoEjecutado > lContrato.MONTO Then
                            listaAutoFinalizacion = bPrograRetro.ObtenerACCION_PROGRA_RETRO_PorCriterios(aEntidad.ID_PROVEEDOR_AF, _
                                                                                            aEntidad.ID_EJERCICIO, _
                                                                                            aEntidad.CODIGO_GRUPO, _
                                                                                            AutorizacionExcepcion.AplicarMontoLiquidacionContrato, _
                                                                                            1)
                            If listaAutoFinalizacion Is Nothing OrElse (listaAutoFinalizacion IsNot Nothing AndAlso listaAutoFinalizacion.Count = 0) Then
                                Me.sError = " Se ha sobrepasado el Monto Adjudicado del Contrato: " + lContrato.NUM_CONTRATO + vbCrLf + _
                                " Adjudicado: " + lContrato.MONTO.ToString("$ #,##0.00") + vbCrLf + _
                                " Ejecutado (este curso inclusive): " + dMontoEjecutado.ToString("$ #,##0.00") + vbCrLf + _
                                " Excedente: " + (dMontoEjecutado - lContrato.MONTO).ToString("$ #,##0.00")
                                Return -1
                            Else
                                aEntidad.COSTO_X_PARTICIPANTE = (lContrato.MONTO - (dMontoEjecutado - esteCurso)) / Math.Round(Me.ObtenerCantidadParticipantesParaPagoPorES_CAPACITADO(aEntidad.ID_ACCION_FORMATIVA), 2)
                            End If
                        End If
                    End If

                    If lContrato IsNot Nothing AndAlso lContrato.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorParticipaciones_CostoParticipante Then
                        Dim dMontoEjecutado As Decimal = (New cCONTRATO_BOLPROS).ObtenerMontoEjecutadoPorContrato(lContrato.ID_CONTRATO)
                        Dim dPartiEjecutado As Decimal = (New cCONTRATO_BOLPROS).ObtenerParticipacionesEjecutadasPorContrato(lContrato.ID_CONTRATO)
                        Dim esteCurso As Decimal = Math.Round(aEntidad.COSTO_X_PARTICIPANTE * Me.ObtenerCantidadParticipantesParaPagoPorES_CAPACITADO(aEntidad.ID_ACCION_FORMATIVA), 2)

                        Dim lContratoCompra As CONTRATO_COMPRA = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRA(lContrato.ID_CONTRATO_COMPRA)
                        If lContratoCompra IsNot Nothing AndAlso lContratoCompra.PAGO_POR_PARTICIPACION = CompraBasePago.PagoBaseInscritos Then
                            Dim lstGrupo As listaGRUPO_ACCION_CONTRATADA = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
                            Dim lAccionContratada As ACCION_CONTRATADA

                            If lstGrupo IsNot Nothing AndAlso lstGrupo.Count > 0 Then
                                lAccionContratada = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(lstGrupo(0).ID_ACCION_CONTRATADA)
                                If lAccionContratada IsNot Nothing AndAlso lAccionContratada.COSTO_PARTICIPANTE > 0 Then
                                    esteCurso = lAccionContratada.MONTO
                                End If
                            End If
                        End If

                        dMontoEjecutado += esteCurso
                        dPartiEjecutado += Me.ObtenerCantidadParticipantesParaPagoPorES_CAPACITADO(aEntidad.ID_ACCION_FORMATIVA)

                        If dMontoEjecutado > lContrato.MONTO Then
                            listaAutoFinalizacion = bPrograRetro.ObtenerACCION_PROGRA_RETRO_PorCriterios(aEntidad.ID_PROVEEDOR_AF, _
                                                                                            aEntidad.ID_EJERCICIO, _
                                                                                            aEntidad.CODIGO_GRUPO, _
                                                                                            AutorizacionExcepcion.AplicarMontoLiquidacionContrato, _
                                                                                            1)
                            If listaAutoFinalizacion Is Nothing OrElse (listaAutoFinalizacion IsNot Nothing AndAlso listaAutoFinalizacion.Count = 0) Then
                                Me.sError = " Se ha sobrepasado el Monto Adjudicado del Contrato: " + lContrato.NUM_CONTRATO + vbCrLf + _
                                " Adjudicado: " + lContrato.MONTO.ToString("$ #,##0.00") + vbCrLf + _
                                " Ejecutado (este curso inclusive): " + dMontoEjecutado.ToString("$ #,##0.00") + vbCrLf + _
                                " Excedente: " + (dMontoEjecutado - lContrato.MONTO).ToString("$ #,##0.00")
                                Return -1
                            Else
                                aEntidad.COSTO_X_PARTICIPANTE = (lContrato.MONTO - (dMontoEjecutado - esteCurso)) / Math.Round(Me.ObtenerCantidadParticipantesParaPagoPorES_CAPACITADO(aEntidad.ID_ACCION_FORMATIVA), 2)
                            End If
                        End If

                        Dim lInfParciales As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaINFORMES_PARCIALES(aEntidad.ID_ACCION_FORMATIVA)
                        If dPartiEjecutado > lContrato.PARTICIPACIONES AndAlso Not (lContratoCompra IsNot Nothing AndAlso lContratoCompra.NO_CONTRATO_COMPRA = "28-2020") _
                            AndAlso lInfParciales IsNot Nothing AndAlso lInfParciales.Count = 0 Then
                            Me.sError = " Se ha sobrepasado las Participaciones Adjudicadas del Contrato: " + lContrato.NUM_CONTRATO + vbCrLf + _
                                " Adjudicado: " + lContrato.PARTICIPACIONES.ToString("#,##0.00") + vbCrLf + _
                                " Ejecutado (este curso inclusive): " + dPartiEjecutado.ToString("#,##0.00") + vbCrLf + _
                                " Excedente: " + (lContrato.PARTICIPACIONES - dPartiEjecutado).ToString("$ #,##0.00")
                            Return -1
                        End If
                    End If

                    If lAccionDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE AndAlso aEntidad.ID_OFERTA_FORMATIVA = -1 AndAlso _
                        lAccionDetalle.ID_CONTRATO > 0 AndAlso lAccionDetalle.ID_MODALIDAD_FORMACION = 2 Then
                        'Acciones móviles contratadas por licitación
                        Dim lTermino As TERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(aEntidad.ID_ACCION_FORMATIVA)
                        If lTermino IsNot Nothing Then
                            Dim participantesActivos As Int32 = mDb.ObtenerCantidadParticipantesParaPago(aEntidad.ID_ACCION_FORMATIVA)

                            Dim lInfParciales As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaINFORMES_PARCIALES(aEntidad.ID_ACCION_FORMATIVA)
                            If participantesActivos > aEntidad.NUMERO_PARTICIPANTES _
                                AndAlso lInfParciales IsNot Nothing AndAlso lInfParciales.Count = 0 Then
                                Me.sError = " Se ha sobrepasado las participaciones adjudicadas en el curso " + aEntidad.NOMBRE_ACCION_FORMATIVA.ToUpper + vbCrLf + _
                                        " Adjudicado: " + aEntidad.NUMERO_PARTICIPANTES.ToString("#,##0") + vbCrLf + _
                                        " Ejecutado: " + participantesActivos.ToString("#,##0") + vbCrLf + _
                                        " Excedente: " + (participantesActivos - aEntidad.NUMERO_PARTICIPANTES).ToString("#,##0")
                                Return -1
                            End If
                        End If
                    End If
                    If lAccionDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE AndAlso aEntidad.ID_OFERTA_FORMATIVA <> -1 Then
                        Dim lAreaFormativa As AREA_FORMACION
                        Dim lAreaContratada As AREA_FORMACION_CONTRA = (New cAREA_FORMACION_CONTRA).ObtenerAREA_FORMACION_CONTRAPorACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
                        Dim montoEjecutado As Decimal = 0
                        Dim partiEjecutado As Decimal = 0

                        If lAreaContratada IsNot Nothing Then
                            lAreaFormativa = (New cAREA_FORMACION).ObtenerAREA_FORMACION(lAreaContratada.ID_AREA_FORMACION)

                            'Sumar las participaciones de este curso a finalizar
                            montoEjecutado = (New cAREA_FORMACION_CONTRA).ObtenerMontoEjecutadoPorAreaContratada(lAreaContratada.ID_AREA_CONTRA)
                            partiEjecutado = (New cAREA_FORMACION_CONTRA).ObtenerParticipacionesEjecutadasPorAreaContratada(lAreaContratada.ID_AREA_CONTRA)
                            montoEjecutado += aEntidad.COSTO_X_PARTICIPANTE * (New cACCION_FORMATIVA).ObtenerCantidadParticipantesParaPagoPorES_CAPACITADO(aEntidad.ID_ACCION_FORMATIVA)
                            partiEjecutado += (New cACCION_FORMATIVA).ObtenerCantidadParticipantesParaPagoPorES_CAPACITADO(aEntidad.ID_ACCION_FORMATIVA)

                            If montoEjecutado > lAreaContratada.MONTO Then
                                Me.sError = " Se ha sobrepasado el Monto Adjudicado en la Categoria Formativa " + lAreaFormativa.AREA_FORMACION + vbCrLf + _
                                    " Adjudicado: " + lAreaContratada.MONTO.ToString("$ #,##0.00") + vbCrLf + _
                                    " Ejecutado: " + montoEjecutado.ToString("$ #,##0.00") + vbCrLf + _
                                    " Excedente: " + (montoEjecutado - lAreaContratada.MONTO).ToString("$ #,##0.00")
                                Return -1
                            End If
                            If partiEjecutado > lAreaContratada.PARTICIPACION Then
                                Me.sError = " Se ha sobrepasado las Participaciones Adjudicadas en la Categoria Formativa " + lAreaFormativa.AREA_FORMACION + vbCrLf + _
                                    " Adjudicado: " + lAreaContratada.PARTICIPACION.ToString("#,##0") + vbCrLf + _
                                    " Ejecutado: " + partiEjecutado.ToString("#,##0") + vbCrLf + _
                                    " Excedente: " + (partiEjecutado - lAreaContratada.PARTICIPACION).ToString("#,##0")
                                Return -1
                            End If
                        End If

                    End If


                End If
            End If

            'Verificar que todos los participantes tengan asignados notas
            Dim evaluacionesEnCurso As listaEVALUACION_AF = (New cEVALUACION_AF).ObtenerListaPorACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
            If evaluacionesEnCurso IsNot Nothing AndAlso evaluacionesEnCurso.Count > 0 Then
                For x As Int32 = 0 To evaluacionesEnCurso.Count - 1
                    Dim lnotas As listaEVALUACIONES_AF_DET = (New cEVALUACIONES_AF_DET).ObtenerListaPorEVALUACION_AF(evaluacionesEnCurso(x).ID_EVALUACION_AF)
                    If lnotas IsNot Nothing AndAlso lnotas.Count > 0 Then
                        For y As Int32 = 0 To lnotas.Count - 1
                            If lnotas(y).NOTA_OBTENIDA = -1 Then
                                Me.sError = "La evaluación " + evaluacionesEnCurso(x).TEMA_EVALUACION + " no tiene completas las notas de los participantes, si los participantes no tienen nota asigneles cero"
                                Return -1
                            End If
                        Next
                    End If
                Next
            End If

            If (Not esNuevo AndAlso aEntidad.CODIGO_ESTADO_AF <> aEntidadOld.CODIGO_ESTADO_AF AndAlso aEntidad.CODIGO_ESTADO_AF = EstadoAccionFormativa.Finalizada) Then

                If lAccionDetalle01 IsNot Nothing AndAlso _
               ( _
                   lAccionDetalle01.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE OrElse _
                    (lAccionDetalle01.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL AndAlso Not bUnidadOrganizativa.EsDeUnidaOrganizativa(aEntidad.ID_ACCION_FORMATIVA, Enumeradores.UnidadOrganizativa.CentroFormacionSanBartolo)) _
                ) Then
                    'Validar que no hayan transcurrido más de 10 días calendario a partir de la fecha de finalización programada
                    If Math.Abs(DateDiff(DateInterval.Day, aEntidad.FECHA_FIN_REAL, Today)) > 10 Then
                        'Verificar si hay autorización para finalizar curso después de los diez días

                        listaAutoFinalizacion = bPrograRetro.ObtenerACCION_PROGRA_RETRO_PorCriterios(aEntidad.ID_PROVEEDOR_AF, _
                                                                                            aEntidad.ID_EJERCICIO, _
                                                                                            aEntidad.CODIGO_GRUPO, _
                                                                                            EstadoAccionFormativa.Finalizada, _
                                                                                            1)
                        If listaAutoFinalizacion IsNot Nothing AndAlso listaAutoFinalizacion.Count > 0 AndAlso listaAutoFinalizacion(0).FECHA_EXPIRA >= Today Then
                            listaAutoFinalizacion(0).ID_ACCION_FORMATIVA = aEntidad.ID_ACCION_FORMATIVA
                            listaAutoFinalizacion(0).USUARIO_PROGRAMO = aEntidad.USERID
                            listaAutoFinalizacion(0).FECHA_PROGRAMO = Now
                            listaAutoFinalizacion(0).ACTIVO = 0
                            listaAutoFinalizacion(0).USERID = aEntidad.USERID
                            listaAutoFinalizacion(0).LASTUPDATE = Now
                        Else

                            '   *****************************************************************************
                            '   Proceso para aplicación de Penalización por Finalización extemporánea de curso
                            '   *****************************************************************************
                            Dim sCodiLici As String = ""
                            Dim existePena As Boolean = False
                            Dim lOferta As OFERTA_FORMATIVA = (New cOFERTA_FORMATIVA).ObtenerOFERTA_FORMATIVA(aEntidad.ID_OFERTA_FORMATIVA)
                            If lOferta IsNot Nothing AndAlso lOferta.ID_CONTRATO > 0 Then
                                Dim lContraLici As CONTRATO_PROVEEDOR_AF = (New cCONTRATO_PROVEEDOR_AF).ObtenerCONTRATO_PROVEEDOR_AF(lOferta.ID_CONTRATO)
                                If lContraLici IsNot Nothing Then
                                    sCodiLici = lContraLici.NUM_LICITACION
                                End If
                            End If

                            If lContrato IsNot Nothing OrElse (sCodiLici = "9/2018" OrElse sOfertaCompra = "187/2018" OrElse sOfertaCompra = "08/2018") Then
                                Dim lDiasDespuesFinalizacion As Integer = Math.Abs(DateDiff(DateInterval.Day, Today, aEntidad.FECHA_FIN_REAL))
                                Dim lRgoPena As CONTRATO_COMPRA_PENALIZACION = (New cCONTRATO_COMPRA_PENALIZACION).ObtenerRANGO_PORC_PENA_PorDIAS(lContrato.ID_CONTRATO_COMPRA, lDiasDespuesFinalizacion, TipoPenalizacion.FinalizacionExtemporaneaCurso)
                                If lRgoPena IsNot Nothing AndAlso lRgoPena.PORC_PENA > 0 Then
                                    Dim lPena As New ACCION_FORMATIVA_PENA
                                    Dim bPena As New cACCION_FORMATIVA_PENA

                                    lPena.ID_ACCION_FORMATIVA_PENA = 0

                                    'Verificar si ya existe penalización de este tipo
                                    Dim lstPena As listaACCION_FORMATIVA_PENA = (New cACCION_FORMATIVA_PENA).ObtenerListaPorACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
                                    If lstPena IsNot Nothing AndAlso lstPena.Count > 0 Then
                                        For j As Int32 = 0 To lstPena.Count - 1
                                            If lstPena(j).ID_TIPO_PENA = TipoPenalizacion.FinalizacionExtemporaneaCurso Then
                                                lPena = lstPena(j)
                                                existePena = True
                                                Exit For
                                            End If
                                        Next
                                    End If

                                    If Not existePena Then
                                        'Aplicar penalización                                    
                                        lPena.ID_ACCION_FORMATIVA = aEntidad.ID_ACCION_FORMATIVA
                                        lPena.PORC_PENALIZACION = lRgoPena.PORC_PENA
                                        lPena.MOTIVO = "PENALIZACION POR FINALIZACION TARDIA DE CURSO. DIAS TRANSCURRIDOS DESDE QUE FINALIZO EL CURSO HASTA LA GENERACION DEL INFORME:" + lDiasDespuesFinalizacion.ToString + " DIA(S),  PORCENTAJE DE PENALIZACION: " + lRgoPena.PORC_PENA.ToString + "%"
                                        lPena.USUARIO_CREACION = aEntidad.USERID
                                        lPena.FECHA_CREACION = Now
                                        lPena.ID_TIPO_PENA = TipoPenalizacion.FinalizacionExtemporaneaCurso
                                        bPena.ActualizarACCION_FORMATIVA_PENA(lPena)
                                    End If
                                Else
                                    Me.sError = "No se puede finalizar un curso si ya transcurrieron mas de 10 dias de la fecha de finalizacion del curso calendarizada en el sistema"
                                    Return -1
                                End If
                                '   *****************************************************************************

                            Else
                                'If Not (lContrato IsNot Nothing AndAlso lContrato.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorCurso_CostoParticipante_Online) Then
                                '    Me.sError = "No se puede finalizar un curso si ya transcurrieron mas de 10 dias de la fecha de finalizacion del curso calendarizada en el sistema"
                                '    Return -1
                                'End If
                                Me.sError = "No se puede finalizar un curso si ya transcurrieron mas de 10 dias de la fecha de finalizacion del curso calendarizada en el sistema"
                                Return -1
                            End If

                        End If
                    End If
                End If

            End If


            lRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)

            If esNuevo AndAlso aEntidad.ID_ACCION_CONTRATADA > 0 Then
                Dim listaGrupoAccion As listaGRUPO_ACCION_CONTRATADA
                Dim lGrupoAccion As New GRUPO_ACCION_CONTRATADA
                Dim bGrupoAccion As New cGRUPO_ACCION_CONTRATADA
                Dim lAccionContra As New ACCION_CONTRATADA
                Dim bAccionContra As New cACCION_CONTRATADA
                Dim lTermino As New TERMINO_REFERENCIA_AF
                Dim bTermino As New cTERMINO_REFERENCIA_AF
                Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE
                Dim bAccionDetalle As New cACCION_FORMATIVA_DETALLE
                Dim lContratoBolpro As CONTRATO_BOLPROS
                Dim lContratoCompra As CONTRATO_COMPRA

                lAccionContra = bAccionContra.ObtenerACCION_CONTRATADA(aEntidad.ID_ACCION_CONTRATADA)

                If lAccionContra IsNot Nothing Then
                    lContratoBolpro = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lAccionContra.ID_CONTRATO)
                    lContratoCompra = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRA(lContratoBolpro.ID_CONTRATO_COMPRA)

                    'Generar GRUPO_ACCION_CONTRATADA
                    lGrupoAccion.ID_GRUPO_ACCION = 0
                    lGrupoAccion.ID_ACCION_CONTRATADA = lAccionContra.ID_ACCION_CONTRATADA
                    lGrupoAccion.ID_GRUPO_AF = -1
                    lGrupoAccion.ID_ACCION_FORMATIVA = aEntidad.ID_ACCION_FORMATIVA
                    lGrupoAccion.USUARIO_CREACION = aEntidad.USERID
                    lGrupoAccion.FECHA_CREACION = Now
                    lGrupoAccion.USERID = aEntidad.USERID
                    lGrupoAccion.LASTUPDATE = Now
                    If lContratoCompra IsNot Nothing AndAlso lContratoCompra.PAGO_POR_PARTICIPACION = Enumeradores.CompraBasePago.PagoBaseDefinida AndAlso lAccionContra.COSTO_PARTICIPANTE > 0 Then
                        lGrupoAccion.MONTO = Math.Round(lAccionContra.COSTO_PARTICIPANTE * lContratoCompra.BASE_PARTI, 2)
                    Else
                        lGrupoAccion.MONTO = aEntidad.COSTO_X_PARTICIPANTE * aEntidad.NUMERO_PARTICIPANTES
                    End If
                    lGrupoAccion.HABILITADO = 1
                    bGrupoAccion.ActualizarGRUPO_ACCION_CONTRATADA(lGrupoAccion)

                    'Generar TERMINO_REFERENCIA_AF
                    lTermino.ID_ACCION_FORMATIVA = aEntidad.ID_ACCION_FORMATIVA
                    lTermino.RESOLUCION = "C" + lContratoBolpro.NUM_CONTRATO + " I" + lAccionContra.NUM_ITEM.ToString
                    lTermino.TDR = lContratoBolpro.NUM_CONTRATO + "-" + lAccionContra.NUM_ITEM.ToString
                    lTermino.MONTO_ADJUDICADO = lGrupoAccion.MONTO
                    lTermino.USERID = aEntidad.USERID
                    lTermino.LASTUPDATE = Now
                    lTermino.CORRELATIVO_GRUPO = -1
                    lTermino.ID_SOLICITUD = -1
                    bTermino.AgregarTERMINO_REFERENCIA_AF(lTermino)

                    'Generar ACCION_FORMATIVA_DETALLE
                    lAccionDetalle = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(aEntidad.ID_ACCION_FORMATIVA)
                    If lAccionDetalle Is Nothing Then
                        lAccionDetalle = New ACCION_FORMATIVA_DETALLE
                        lAccionDetalle.ID_ACCION_FORMATIVA = aEntidad.ID_ACCION_FORMATIVA
                        lAccionDetalle.ID_PROGRAMA_FORMACION = lContratoBolpro.ID_PROGRAMA_FORMACION
                        lAccionDetalle.ID_MODALIDAD_FORMACION = 1
                        lAccionDetalle.ID_CONTRATO = -1
                        lAccionDetalle.ID_FUENTE = -1
                        lAccionDetalle.NO_CONVOCATORIA = -1
                        lAccionDetalle.CODIGO_DEPARTAMENTO = lAccionContra.CODIGO_DEPARTAMENTO
                        lAccionDetalle.CODIGO_MUNICIPIO = lAccionContra.CODIGO_MUNICIPIO
                        lAccionDetalle.LUGAR_EJECUCION = ""
                        lAccionDetalle.TELEFONO = ""
                        lAccionDetalle.CONTACTO = ""
                        lAccionDetalle.USERID = aEntidad.USERID
                        lAccionDetalle.LASTUPDATE = Now
                        lAccionDetalle.ID_UNIDAD_ORGANIZATIVA = lContratoCompra.ID_UNIDAD_ORGANIZATIVA
                        bAccionDetalle.AgregarACCION_FORMATIVA_DETALLE(lAccionDetalle)
                    Else
                        lAccionDetalle.ID_UNIDAD_ORGANIZATIVA = lContratoCompra.ID_UNIDAD_ORGANIZATIVA
                        bAccionDetalle.ActualizarACCION_FORMATIVA_DETALLE(lAccionDetalle)
                    End If

                    'Actualizar ACCION_CONTRATADA
                    listaGrupoAccion = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_CONTRATADA(lAccionContra.ID_ACCION_CONTRATADA)
                    If listaGrupoAccion IsNot Nothing Then
                        lAccionContra.CANT_CURSOS = listaGrupoAccion.Count
                        bAccionContra.ActualizarACCION_CONTRATADA(lAccionContra)
                    End If
                End If
            End If

            'Actualizar autorizaciones  
            If listaPrograRetro IsNot Nothing AndAlso listaPrograRetro.Count > 0 AndAlso listaPrograRetro(0).FECHA_EXPIRA >= Today Then
                bPrograRetro.ActualizarACCION_PROGRA_RETRO(listaPrograRetro(0))
            End If
            If listaAutoFinalizacion IsNot Nothing AndAlso listaAutoFinalizacion.Count > 0 AndAlso listaAutoFinalizacion(0).FECHA_EXPIRA >= Today Then
                bPrograRetro.ActualizarACCION_PROGRA_RETRO(listaAutoFinalizacion(0))
            End If

            'Generar histórico de la Entidad que se crea o actualiza con su Nuevo Estado
            If esNuevo OrElse (Not esNuevo AndAlso aEntidad.CODIGO_ESTADO_AF <> aEntidadOld.CODIGO_ESTADO_AF AndAlso GenHistorico) Then
                Dim mComponente As New cACCION_FORMATIVA_HIST
                If mComponente.AgregarACCION_FORMATIVA_HIST(0, aEntidad.ID_ACCION_FORMATIVA, _
                        aEntidad.ID_OFERTA_FORMATIVA, aEntidad.ID_SITIO_CAPACITACION, aEntidad.ID_PROVEEDOR_AF, _
                        aEntidad.ID_TEMA_CURSO, aEntidad.ID_EJERCICIO, aEntidad.NOMBRE_ACCION_FORMATIVA, _
                        aEntidad.CODIGO_GRUPO, aEntidad.NUMERO_PARTICIPANTES, aEntidad.PARTICIPANTES_INSCRITOS, _
                        aEntidad.HORARIO, aEntidad.NOTAS, aEntidad.CODIGO_ESTADO_AF, aEntidad.DURACION_HORAS, _
                        aEntidad.COSTO_X_PARTICIPANTE, aEntidad.LASTUPDATE, aEntidad.USERID, _
                        aEntidad.FECHA_INICIO_REAL, aEntidad.FECHA_FIN_REAL, aEntidad.OBSERVACIONES, aEntidad.ID_ACCION_CONTRATADA, aEntidad.CODI_FORMADOR, aEntidad.NOMBRE_FORMADOR) <> 1 Then
                    Me.sError = mComponente.sError
                    Return -1
                End If
            End If

            If lRet = 1 Then
                If aEntidadOld.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Iniciada And aEntidad.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Finalizada Then
                    'Cambio de Estado de Solicitudes Asociadas al Curso a Finalizadas
                    Dim lcSOLICITUD_INSCRIPCION_AF As New cSOLICITUD_INSCRIPCION_AF
                    Dim lShouldReturn As Boolean
                    Dim lResult As Integer = lcSOLICITUD_INSCRIPCION_AF.FinalizarSolicitudesDeAccionFormativa(aEntidad.ID_ACCION_FORMATIVA, lShouldReturn)
                    If lShouldReturn Then
                        Me.sError = lcSOLICITUD_INSCRIPCION_AF.sError
                        Me.sErrorTecnico = lcSOLICITUD_INSCRIPCION_AF.sErrorTecnico
                        Return lResult
                    End If

                    'Creacion de Informe Final
                    Dim lcINFORME_FINAL_AF As New cINFORME_FINAL_AF
                    Dim lResu1t As INFORME_FINAL_AF = lcINFORME_FINAL_AF.GenerarInformePorPeriodoEjecucion(aEntidadOld.ID_ACCION_FORMATIVA, lFechaInicial, aEntidadOld.FECHA_FIN_REAL, True, True)
                    If lResu1t Is Nothing Then
                        Me.sError = lcINFORME_FINAL_AF.sError
                        Me.sErrorTecnico = lcINFORME_FINAL_AF.sErrorTecnico
                        Return -1
                    End If
                End If
            End If

            Return lRet


        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Calcula el Porcentaje de Asistencia Promedio a una Accion Formativa de un Participante.
    ''' </summary>
    ''' <history>
    ''' 	[ecarias]	14/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerPorcentajeAsistenciaPromedio(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_PARTICIPANTE As Decimal, Optional ByVal FECHA_INICIO_ASISTENCIA As Date = #12:00:00 AM#, Optional ByVal FECHA_FIN_ASISTENCIA As Date = #12:00:00 AM#) As Decimal
        Try
            Return mDb.ObtenerPorcentajeAsistenciaPromedio(ID_ACCION_FORMATIVA, ID_PARTICIPANTE, FECHA_INICIO_ASISTENCIA, FECHA_FIN_ASISTENCIA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    Public Function ObtenerPorcentajeAsistenciaPartiAcumuladoInformes(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_PARTICIPANTE As Decimal, ByVal FECHA_LIMITE As Date) As Decimal
        Try
            Return mDb.ObtenerPorcentajeAsistenciaPartiAcumuladoInformes(ID_ACCION_FORMATIVA, ID_PARTICIPANTE, FECHA_LIMITE)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    Public Function ObtenerInfoAsistenciaReal(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_PARTICIPANTE As Decimal, Optional ByVal FECHA_INICIO_ASISTENCIA As Date = #12:00:00 AM#, Optional ByVal FECHA_FIN_ASISTENCIA As Date = #12:00:00 AM#) As Dictionary(Of String, Decimal)
        Try
            Return mDb.ObtenerInfoAsistenciaReal(ID_ACCION_FORMATIVA, ID_PARTICIPANTE, FECHA_INICIO_ASISTENCIA, FECHA_FIN_ASISTENCIA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Calcula la Nota Promedio en una Accion Formativa de un Participante.
    ''' </summary>
    ''' <history>
    ''' 	[ecarias]	14/05/2010	Created
    ''' 	[ecarias]	01/06/2010	Se agrego el Tipo de Evaluacion(Teorica o Practica)
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerNotaPromedio(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_PARTICIPANTE As Decimal, ByVal EsTeorica As Boolean) As Decimal
        Try
            Dim lEvaluaciones As listaEVALUACION_AF
            lEvaluaciones = (New cEVALUACION_AF).ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
            Dim notaPromedio As Decimal = 0
            Dim porcPorEvaluacion As Decimal '= (100 / lEvaluaciones.Count)
            Dim numeroEvaluaciones As Decimal = 0

            If EsTeorica Then
                numeroEvaluaciones = lEvaluaciones.CountPorTipoEvaluacion("T")
            Else
                numeroEvaluaciones = lEvaluaciones.CountPorTipoEvaluacion("P")
            End If

            If numeroEvaluaciones > 0 Then
                porcPorEvaluacion = 100 / numeroEvaluaciones
            Else
                porcPorEvaluacion = 0
            End If

            For Each lEvaluacion As EVALUACION_AF In lEvaluaciones
                If EsTeorica And lEvaluacion.TIPO_EVALUACION = "T" Then
                    Dim lDetalleEvaluaciones As listaEVALUACIONES_AF_DET
                    Dim lCriterios As New List(Of Criteria)
                    lCriterios.Add(New Criteria("ID_EVALUACION_AF", "=", lEvaluacion.ID_EVALUACION_AF.ToString(), "AND"))
                    lCriterios.Add(New Criteria("ID_PARTICIPANTE", "=", ID_PARTICIPANTE.ToString(), "AND"))
                    lDetalleEvaluaciones = (New cEVALUACIONES_AF_DET).ObtenerListaPorBusqueda(New EVALUACIONES_AF_DET, lCriterios.ToArray())
                    notaPromedio += (IIf(lDetalleEvaluaciones(0).NOTA_OBTENIDA = -1, 0, lDetalleEvaluaciones(0).NOTA_OBTENIDA) * porcPorEvaluacion / 100)
                End If
                If (Not EsTeorica) And lEvaluacion.TIPO_EVALUACION = "P" Then
                    Dim lDetalleEvaluaciones As listaEVALUACIONES_AF_DET
                    Dim lCriterios As New List(Of Criteria)
                    lCriterios.Add(New Criteria("ID_EVALUACION_AF", "=", lEvaluacion.ID_EVALUACION_AF.ToString(), "AND"))
                    lCriterios.Add(New Criteria("ID_PARTICIPANTE", "=", ID_PARTICIPANTE.ToString(), "AND"))
                    lDetalleEvaluaciones = (New cEVALUACIONES_AF_DET).ObtenerListaPorBusqueda(New EVALUACIONES_AF_DET, lCriterios.ToArray())
                    notaPromedio += (IIf(lDetalleEvaluaciones(0).NOTA_OBTENIDA = -1, 0, lDetalleEvaluaciones(0).NOTA_OBTENIDA) * porcPorEvaluacion / 100)
                End If
            Next

            Return Decimal.Round(notaPromedio, 2)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Calcula la Nota Promedio en una Accion Formativa de un Participante en un período determinado
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	14/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerNotaPromedioPeriodo(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_PARTICIPANTE As Decimal, ByVal EsTeorica As Boolean, ByVal FECHA_INICIO_EVALUACION As Date, ByVal FECHA_FIN_EVALUACION As Date) As Decimal
        Try
            Dim lEvaluaciones As listaEVALUACION_AF
            lEvaluaciones = (New cEVALUACION_AF).ObtenerListaPorACCION_FORMATIVAPeriodo(ID_ACCION_FORMATIVA, FECHA_INICIO_EVALUACION, FECHA_FIN_EVALUACION)

            Dim notaPromedio As Decimal = 0
            Dim porcPorEvaluacion As Decimal '= (100 / lEvaluaciones.Count)
            Dim numeroEvaluaciones As Decimal = 0

            If EsTeorica Then
                numeroEvaluaciones = lEvaluaciones.CountPorTipoEvaluacion("T")
            Else
                numeroEvaluaciones = lEvaluaciones.CountPorTipoEvaluacion("P")
            End If

            If numeroEvaluaciones > 0 Then
                porcPorEvaluacion = 100 / numeroEvaluaciones
            Else
                porcPorEvaluacion = 0
            End If

            For Each lEvaluacion As EVALUACION_AF In lEvaluaciones
                If EsTeorica And lEvaluacion.TIPO_EVALUACION = "T" Then
                    Dim lDetalleEvaluaciones As listaEVALUACIONES_AF_DET
                    Dim lCriterios As New List(Of Criteria)
                    lCriterios.Add(New Criteria("ID_EVALUACION_AF", "=", lEvaluacion.ID_EVALUACION_AF.ToString(), "AND"))
                    lCriterios.Add(New Criteria("ID_PARTICIPANTE", "=", ID_PARTICIPANTE.ToString(), "AND"))
                    lDetalleEvaluaciones = (New cEVALUACIONES_AF_DET).ObtenerListaPorBusqueda(New EVALUACIONES_AF_DET, lCriterios.ToArray())
                    notaPromedio += (IIf(lDetalleEvaluaciones(0).NOTA_OBTENIDA = -1, 0, lDetalleEvaluaciones(0).NOTA_OBTENIDA) * porcPorEvaluacion / 100)
                End If
                If (Not EsTeorica) And lEvaluacion.TIPO_EVALUACION = "P" Then
                    Dim lDetalleEvaluaciones As listaEVALUACIONES_AF_DET
                    Dim lCriterios As New List(Of Criteria)
                    lCriterios.Add(New Criteria("ID_EVALUACION_AF", "=", lEvaluacion.ID_EVALUACION_AF.ToString(), "AND"))
                    lCriterios.Add(New Criteria("ID_PARTICIPANTE", "=", ID_PARTICIPANTE.ToString(), "AND"))
                    lDetalleEvaluaciones = (New cEVALUACIONES_AF_DET).ObtenerListaPorBusqueda(New EVALUACIONES_AF_DET, lCriterios.ToArray())
                    notaPromedio += (IIf(lDetalleEvaluaciones(0).NOTA_OBTENIDA = -1, 0, lDetalleEvaluaciones(0).NOTA_OBTENIDA) * porcPorEvaluacion / 100)
                End If
            Next

            Return Decimal.Round(notaPromedio, 2)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Indica si hay evaluaciones Teoricas
    ''' </summary>
    ''' <history>
    ''' 	[ecarias]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCantidadEvaluacionesTeoricas(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Try
            Dim lEvaluaciones As listaEVALUACION_AF
            lEvaluaciones = (New cEVALUACION_AF).ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
            If lEvaluaciones Is Nothing Then
                Return 0
            End If
            Return lEvaluaciones.CountPorTipoEvaluacion("T")
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Indica si hay evaluaciones Teoricas
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	30/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCantidadEvaluacionesTeoricasPeriodo(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA_INICIO As Date, ByVal FECHA_FIN As Date) As Integer
        Try
            Dim lEvaluaciones As listaEVALUACION_AF
            lEvaluaciones = (New cEVALUACION_AF).ObtenerListaPorACCION_FORMATIVAPeriodo(ID_ACCION_FORMATIVA, FECHA_INICIO, FECHA_FIN)
            If lEvaluaciones Is Nothing Then
                Return 0
            End If
            Return lEvaluaciones.CountPorTipoEvaluacion("T")
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el Cuerpo de un Correo de Devolución de Informe Final
    ''' </summary>
    ''' <param name="aEntidad"></param>    
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	18/08/2010	Created
    ''' 	[cramos]	12/12/2012	Modificado: Se cambia lógica para hacer referncia al Programa de Formación al que pertenece el Curso
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCuerpoCorreoDevolucionInformeFinal(ByVal aEntidad As ACCION_FORMATIVA) As String
        Dim Cuerpo As New StringBuilder
        Dim idProgramaFormacion As Integer
        Dim lEntidadPrograma As PROGRAMA_FORMACION

        Cuerpo.AppendLine("INSAFORP - GERENCIA DE FORMACION INICIAL ")
        idProgramaFormacion = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(aEntidad.ID_ACCION_FORMATIVA)
        lEntidadPrograma = (New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(idProgramaFormacion)
        Cuerpo.Append(lEntidadPrograma.NOMBRE_PROGRAMA_FORMACION)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("Por este medio se le comunica que el Informe de Ejecución para el curso ")
        Cuerpo.Append("ID: ")
        Cuerpo.AppendLine(aEntidad.ID_ACCION_FORMATIVA.ToString)
        Cuerpo.Append("NOMBRE: ")
        Cuerpo.AppendLine(aEntidad.NOMBRE_ACCION_FORMATIVA)
        Cuerpo.Append("CODIGO: ")
        Cuerpo.AppendLine(aEntidad.CODIGO_GRUPO)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("ha sido devuelto con la siguiente observacion:.")
        Cuerpo.Append(aEntidad.OBSERVACIONES)

        Return Cuerpo.ToString
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que obtiene la Ejecucion de la Oferta Formativa de acuerdo a los parámetros especificados
    ''' </summary>
    ''' <history>
    ''' 	[cramos]	20/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerEjecucionOfertaFormativa(ByVal TIPO_CONSULTA As Integer, _
                                                ByVal ID_EJERCICIO As String, _
                                                ByVal ID_PROVEEDOR_AF As Decimal, _
                                                ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                ByVal CODIGO_GRUPO As String, _
                                                ByVal ID_TIPO_SOLICITUD As Decimal) As DataSet
        Try
            Return mDb.ObtenerEjecucionOfertaFormativa(TIPO_CONSULTA, ID_EJERCICIO, ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, CODIGO_GRUPO, ID_TIPO_SOLICITUD)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try

    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	21/10/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriteriosPeriodoEstadosTecnico(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_AREA_FORMACION As Decimal, ByVal NOMBRE_ACCION_FORMATIVA As String, ByVal CODIGO_GRUPO As String, ByVal CODIGO_ESTADO_AF As List(Of String), ByVal ID_EJERCICIO As String, ByVal USUARIO_TECNICO As String, ByVal TDR As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA
        Try
            Return mDb.ObtenerListaPorCriteriosPeriodoEstadosTecnico(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_AREA_FORMACION, NOMBRE_ACCION_FORMATIVA, CODIGO_GRUPO, ID_EJERCICIO, CODIGO_ESTADO_AF, USUARIO_TECNICO, TDR, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el Programa de Formación del Curso
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/12/2012	Created   
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerProgramaFormacionCurso(ByVal ID_ACCION_FORMATIVA As Decimal) As Decimal
        Try
            Return Me.mDb.ObtenerProgramaFormacionCurso(ID_ACCION_FORMATIVA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    Public Function ObtenerModalidadFormacionCurso(ByVal ID_ACCION_FORMATIVA As Decimal) As Decimal
        Try
            Return Me.mDb.ObtenerModalidadFormacionCurso(ID_ACCION_FORMATIVA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el Horario por Dia para una Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	14/04/2011	Created   
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerHorarioPorDia(ByVal ID_ACCION_FORMATIVA As Decimal) As String
        Try
            Return Me.mDb.ObtenerHorarioPorDia(ID_ACCION_FORMATIVA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve el Horario por Dia para una Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	27/07/2012	Created   
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerHorarioPorPeriodo(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA_INICIAL As Date, ByVal FECHA_FINAL As Date) As String
        Try
            Return Me.mDb.ObtenerHorarioPorPeriodo(ID_ACCION_FORMATIVA, FECHA_INICIAL, FECHA_FINAL)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ACCION_FORMATIVA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' 	[cramos]	28/03/2010	Se agrega una invocación método para eliminar la programación si el curso está en estado Ingresado
    ''' 	[cramos]	08/01/2013	Se agrega lógica para eliminar AccionFormativaDetalle
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Try
            EliminarProgramacionCursoIngresado(ID_ACCION_FORMATIVA)
            EliminarAccionFormativaDetalle(ID_ACCION_FORMATIVA)
            mEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarACCION_FORMATIVA_EN_CASCADA(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Try
            Return mDb.EliminarEnCascada(ID_ACCION_FORMATIVA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ACCION_FORMATIVA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    '''     [cramos]	28/03/2010	Se agrega una invocación método para eliminar la programación si el curso está en estado Ingresado
    ''' 	[cramos]	08/01/2013	Se agrega lógica para eliminar AccionFormativaDetalle
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarACCION_FORMATIVA(ByVal aEntidad As ACCION_FORMATIVA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            EliminarProgramacionCursoIngresado(aEntidad.ID_ACCION_FORMATIVA)
            EliminarAccionFormativaDetalle(aEntidad.ID_ACCION_FORMATIVA)
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina la Programación de una Acción Formativa
    ''' </summary>
    Private Sub EliminarProgramacionCursoIngresado(ByVal IdAccionFormativa As Decimal)
        Dim eAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(IdAccionFormativa)

        If eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Ingresada Then
            Dim bAsistencia As New cASISTENCIA_AF
            Dim Detalle As listaASISTENCIA_AF

            Detalle = (New cASISTENCIA_AF).ObtenerListaPorACCION_FORMATIVA(IdAccionFormativa)
            If Detalle IsNot Nothing Then
                For i As Integer = 0 To Detalle.Count - 1
                    bAsistencia.EliminarASISTENCIA_AF(Detalle(i).ID_ASISTENCIA_AF)
                Next
            End If
        End If

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina la Acción Formativa Detalle
    ''' </summary>
    Private Sub EliminarAccionFormativaDetalle(ByVal IdAccionFormativa As Decimal)
        Dim eAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(IdAccionFormativa)

        If eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Ingresada Then
            Dim bAccionDetalle As New cACCION_FORMATIVA_DETALLE
            bAccionDetalle.EliminarACCION_FORMATIVA_DETALLE(IdAccionFormativa)
        End If

    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve el Depto y Municipio de la Accion Formativa que recibe de parametro
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[ecarias]	12/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDeptoMunicipio(ByVal ID_ACCION_FORMATIVA As Decimal) As Dictionary(Of String, String)
        Try
            Return mDb.ObtenerDeptoMunicipio(ID_ACCION_FORMATIVA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerFechaMinimaMaximaEjecucionPorCONTRATO_BOLPROS(ByVal ID_CONTRATO As Decimal) As Dictionary(Of String, Date)
        Try
            Return mDb.ObtenerFechaMinimaMaximaEjecucionPorCONTRATO_BOLPROS(ID_CONTRATO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve el N° de Convocatoria de la Accion Formativa que recibe de parametro
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	16/11/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerNoConvocatoria(ByVal ID_ACCION_FORMATIVA As Decimal) As Decimal
        Try
            Return mDb.ObtenerNoConvocatoria(ID_ACCION_FORMATIVA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre devuelve todos los registros de la Entidad.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	26/08/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorResolucion(ByVal RESOLUCION As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorResolucion(RESOLUCION, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	26/08/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorAccionFormativaFacturar(ByVal ID_TIPO_SOLICITUD As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA
        Try
            Return mDb.ObtenerListaPorAccionFormativaFacturar(ID_TIPO_SOLICITUD, ID_PROVEEDOR_AF, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre devuelve todos los registros de la Entidad.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	26/08/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorFactura(ByVal ID_FACTURA_AF As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorFactura(ID_FACTURA_AF, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Strings de los Asentamientos Urbanos o 
    ''' Caserios de los Participantes de la Accion Formativa que recibe de parámetro.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	06/09/2011	Created    
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaAUPsPorAccionFormativa(ByVal ID_ACCION_FORMATIVA As Decimal) As String
        Try
            Dim strAsentamientos As New Text.StringBuilder
            Dim band As Boolean = False

            Dim listaAsentamientosPorAccion As List(Of String)
            listaAsentamientosPorAccion = mDb.ObtenerListaAUPsPorAccionFormativa(ID_ACCION_FORMATIVA)

            For Each lAsentamiento As String In listaAsentamientosPorAccion
                If band Then
                    strAsentamientos.Append(", ")
                End If
                strAsentamientos.Append(lAsentamiento)
                band = True
            Next

            Return strAsentamientos.ToString
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve una lista de Acciones Formativas filtrada por criterios.
    ''' </summary>
    ''' <param name="ID_CONTRATO">Id del Proveedor del registro seleccionado.</param>    
    ''' <param name="ID_SUBAREA_FORMACION">Id de la Sub Area a la que pertenece la Acción Formativa.</param>    
    ''' <param name="CODIGO_GRUPO">Código de Grupo de la Acción Formativa perteneciente al Contrato.</param>
    ''' <param name="ID_EJERCICIO">Id del Ejercicio de las Acciones Formativas pertenecientes al Contrato.</param>
    ''' <history>
    ''' 	[cramos]	09/03/2012	Created
    ''' 	[cramos]	12/12/2012	Modificado: Se cambia lógica para utilizar Estados del Informe de Ejecución
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriteriosContratoSubAreaFormativa(ByVal ID_CONTRATO As Decimal, ByVal ID_SUBAREA_FORMACION As Decimal, ByVal CODIGO_GRUPO As String, ByVal ID_EJERCICIO As String) As listaACCION_FORMATIVA
        Try
            Dim lista As New listaACCION_FORMATIVA
            Dim listaEstado As New List(Of Decimal)
            listaEstado.Add(Enumeradores.EstadoInformeFinal.InformeEnRevisionUACI)
            listaEstado.Add(Enumeradores.EstadoInformeFinal.FacturaSolicitadaProveedor)
            listaEstado.Add(Enumeradores.EstadoInformeFinal.EnTramiteDePago)
            listaEstado.Add(Enumeradores.EstadoInformeFinal.Pagado)
            lista = mDb.ObtenerListaPorCriteriosContratoSubAreaFormativa(ID_CONTRATO, ID_SUBAREA_FORMACION, CODIGO_GRUPO, ID_EJERCICIO, listaEstado)
            Return lista
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
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
                                                    ByVal listaCODIGO_ESTADO_AF As String, _
                                                    ByVal TDR As String, _
                                                    Optional ByVal asColumnaOrden As String = "", _
                                                    Optional ByVal asTipoOrden As String = "ASC") As listaACCION_FORMATIVA
        Try
            Dim lListaCursos As listaACCION_FORMATIVA
            Dim lListaResultado As New listaACCION_FORMATIVA
            Dim lUsuario As USUARIO = (New cUSUARIO).ObtenerUSUARIO(Utilerias.ObtenerUsuario)
            Dim listaID_PROGRAMA_FORMACION As New List(Of Decimal)
            Dim listaProgramasPorRol As New listaPROGRAMA_FORMACION
            Dim lsRoles As String() = listaROLES.Split(";")
            Dim lsCodigoEstado As String()
            Dim alistaROLES As New List(Of String)
            Dim alistaCODIGO_ESTADO_AF As New List(Of String)



            For i As Integer = 0 To lsRoles.Length - 1
                alistaROLES.Add(lsRoles(i))
            Next

            If listaCODIGO_ESTADO_AF IsNot Nothing Then
                lsCodigoEstado = listaCODIGO_ESTADO_AF.Split(";")

                For i As Integer = 0 To lsCodigoEstado.Length - 1
                    alistaCODIGO_ESTADO_AF.Add(lsCodigoEstado(i))
                Next
            End If

            'Obtener Lista de Programas de Formación de acuerdo a los Roles 
            If listaROLES.Contains(RolDeUsuario.Administrador) OrElse _
                                       listaROLES.Contains(RolDeUsuario.GerenteGFI) OrElse _
                                       listaROLES.Contains(RolDeUsuario.CoordinadorGFI) OrElse _
                                       listaROLES.Contains(RolDeUsuario.SoporteGFI) OrElse _
                                       listaROLES.Contains(RolDeUsuario.TecnicoGFI) OrElse _
                                       listaROLES.Contains(RolDeUsuario.AsistenteGFI) OrElse _
                                       listaROLES.Contains(RolDeUsuario.CAGestion) OrElse _
                                       listaROLES.Contains(RolDeUsuario.CARevision) OrElse _
                                       listaROLES.Contains(RolDeUsuario.CARecepcion) Then
                listaProgramasPorRol = (New cPROGRAMA_FORMACION).ObtenerLista
                If listaProgramasPorRol IsNot Nothing AndAlso listaProgramasPorRol.Count > 0 Then
                    For i As Integer = 0 To listaProgramasPorRol.Count - 1
                        listaID_PROGRAMA_FORMACION.Add(listaProgramasPorRol(i).ID_PROGRAMA_FORMACION)
                    Next
                End If
            Else
                listaProgramasPorRol = (New cPROGRAMA_FORMACION).ObtenerListaPorROLES(alistaROLES)
                If listaProgramasPorRol IsNot Nothing AndAlso listaProgramasPorRol.Count > 0 Then
                    For i As Integer = 0 To listaProgramasPorRol.Count - 1
                        listaID_PROGRAMA_FORMACION.Add(listaProgramasPorRol(i).ID_PROGRAMA_FORMACION)
                    Next
                End If
            End If
            'Obtener Lista de Cursos por Proveedor, Programa de Formación
            lListaCursos = mDb.ObtenerListaPorCriteriosRoles(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_AREA_FORMACION, NOMBRE_ACCION_FORMATIVA, CODIGO_GRUPO, ID_EJERCICIO, alistaCODIGO_ESTADO_AF, listaID_PROGRAMA_FORMACION, TDR, asColumnaOrden, asTipoOrden)

            If lListaCursos IsNot Nothing AndAlso lListaCursos.Count > 0 Then
                For i As Integer = 0 To lListaCursos.Count - 1
                    Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = _
                        (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lListaCursos(i).ID_ACCION_FORMATIVA)
                    If lAccionDetalle IsNot Nothing Then
                        If lAccionDetalle.ID_PROGRAMA_FORMACION = ProgramasFormacion.HABIL_TECNICO_PERMANENTE Then
                            Select Case True
                                Case alistaROLES.Contains(RolDeUsuario.Proveedor) AndAlso lUsuario.ID_PROVEEDOR_AF = lListaCursos(i).ID_PROVEEDOR_AF
                                    lListaResultado.Add(lListaCursos(i))
                                Case alistaROLES.Contains(RolDeUsuario.CentroCapacitador) AndAlso (lUsuario.ID_SITIO_CAPACITACION = lListaCursos(i).ID_SITIO_CAPACITACION OrElse lListaCursos(i).ID_SITIO_CAPACITACION = -1)
                                    lListaResultado.Add(lListaCursos(i))
                                Case Else
                                    lListaResultado.Add(lListaCursos(i))
                                    'Case listaROLES.Contains(RolDeUsuario.Administrador), _
                                    '            listaROLES.Contains(RolDeUsuario.GerenteGFI), _
                                    '            listaROLES.Contains(RolDeUsuario.CoordinadorGFI), _
                                    '            listaROLES.Contains(RolDeUsuario.SoporteGFI), _
                                    '            listaROLES.Contains(RolDeUsuario.TecnicoGFI), _
                                    '            listaROLES.Contains(RolDeUsuario.AsistenteGFI), _
                                    '            listaROLES.Contains(RolDeUsuario.CAGestion), _
                                    '            listaROLES.Contains(RolDeUsuario.CARevision), _
                                    '            listaROLES.Contains(RolDeUsuario.CARecepcion)
                                    '    lListaResultado.Add(lListaCursos(i))
                            End Select
                        Else
                            Select Case True
                                Case (alistaROLES.Contains(RolDeUsuario.Proveedor) OrElse alistaROLES.Contains(RolDeUsuario.ProveedorPATI) OrElse alistaROLES.Contains(RolDeUsuario.ProveedorPROYESPECIAL)) _
                                    AndAlso lUsuario.ID_PROVEEDOR_AF = lListaCursos(i).ID_PROVEEDOR_AF
                                    lListaResultado.Add(lListaCursos(i))
                                Case Else
                                    lListaResultado.Add(lListaCursos(i))
                            End Select
                        End If
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

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve la cantidad de participantes inscritos sin documentos de identidad.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	14/05/2013	Created    
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCantParticipantesSinDoctos(ByVal ID_ACCION_FORMATIVA As Decimal) As Decimal
        Try
            Dim dParticipantesSinDoctos As Decimal = 0
            Dim listaInscritos As listaSOLICITUD_INSCRIPCION_AF

            listaInscritos = (New cSOLICITUD_INSCRIPCION_AF).ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
            If listaInscritos IsNot Nothing AndAlso listaInscritos.Count > 0 Then
                For i As Integer = 0 To listaInscritos.Count - 1
                    If listaInscritos(i).DUI = "" AndAlso listaInscritos(i).NIT = "" Then
                        dParticipantesSinDoctos += 1
                    End If
                Next
            End If

            Return dParticipantesSinDoctos

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve la cantidad de participantes inscritos sin documentos de identidad.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	04/09/2014	Created    
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCantParticipantesMenoresEdad(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal EDAD_REFERENCIA As Decimal) As Decimal
        Try
            Dim dParticipantesMenoresEdad As Decimal = 0
            Dim listaInscritos As listaSOLICITUD_INSCRIPCION_AF

            listaInscritos = (New cSOLICITUD_INSCRIPCION_AF).ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
            If listaInscritos IsNot Nothing AndAlso listaInscritos.Count > 0 Then
                For i As Integer = 0 To listaInscritos.Count - 1
                    If listaInscritos(i).EDAD < EDAD_REFERENCIA Then
                        dParticipantesMenoresEdad += 1
                    End If
                Next
            End If

            Return dParticipantesMenoresEdad

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerAccionFormativa_Horario_enConflicto(ByVal ID_PARTICIPANTE As Int32, ByVal ID_ACCION_FORMATIVA_A_INSCRIBIR As Int32) As DataSet
        Try
            Return mDb.ObtenerAccionFormativa_Horario_enConflicto(ID_PARTICIPANTE, ID_ACCION_FORMATIVA_A_INSCRIBIR)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try

    End Function

    Public Function ObtenerAccionFormativa_Horario_enConflictoFormador(ByVal CODI_FORMADOR As String, ByVal ID_ACCION_FORMATIVA_A_INSCRIBIR As Int32) As DataSet
        Try
            Return mDb.ObtenerAccionFormativa_Horario_enConflictoFormador(CODI_FORMADOR, ID_ACCION_FORMATIVA_A_INSCRIBIR)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try

    End Function

    Public Function ObtenerAccionFormativa_Horario_enConflictoFormador(ByVal CODI_FORMADOR As String, ByVal ID_ACCION_FORMATIVA_A_INSCRIBIR As Int32, ByVal FECHA_HORA_INICIO As DateTime, ByVal FECHA_HORA_FIN As DateTime) As DataSet
        Try
            Return mDb.ObtenerAccionFormativa_Horario_enConflictoFormador(CODI_FORMADOR, ID_ACCION_FORMATIVA_A_INSCRIBIR, FECHA_HORA_INICIO, FECHA_HORA_FIN)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try

    End Function
End Class
