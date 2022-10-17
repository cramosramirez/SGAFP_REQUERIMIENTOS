Imports SQLMembershipProvider.BL
Imports System.Web.Security
Imports System.Linq
Imports System
Imports SGAFP.EL
Imports SGAFP.EL.Enumeradores
Imports SGAFP.BL
Imports SGAFP.DL
Imports System.Text
Partial Class cINFORME_FINAL_AF




    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	13/08/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCONTRATO_COMPRA(ByVal ID_CONTRATO_COMPRA As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF
        Try
            Return mDb.ObtenerListaPorCONTRATO_COMPRA(ID_CONTRATO_COMPRA, asColumnaOrden, asTipoOrden)
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
    ''' 	[cramos]	13/08/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaINFORMES_PARCIALES(ByVal ID_ACCION_FORMATIVA As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF
        Try
            Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(ID_ACCION_FORMATIVA)
            Dim lstInformes As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA, False, False, asColumnaOrden, asTipoOrden)
            Dim lstResultado As New listaINFORME_FINAL_AF

            If lAccionFormativa IsNot Nothing Then
                For i As Integer = 0 To lstInformes.Count - 1
                    If lstInformes(i).FECHA_FINAL < lAccionFormativa.FECHA_FIN_REAL AndAlso lstInformes(i).HORAS_DESARROLLADAS < lAccionFormativa.DURACION_HORAS Then
                        lstResultado.Add(lstInformes(i))
                    End If
                Next
            End If

            Return lstResultado

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un Informe de Ejecución en un Perídodo determinado a partir de una Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	08/01/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    ''' 

    Public Function EsPeriodoValido(ByVal idAccionFormativa As Decimal, ByVal fechaInicioPeriodo As Date, ByVal fechaFinPeriodo As Date, ByVal EsInformeFinal As Boolean) As String
        Dim fechaInicial As Date
        Dim listaAsistenciaAF As listaASISTENCIA_AF
        Dim listaInformes As listaINFORME_FINAL_AF
        Dim evaluacionesDelPeriodo As listaEVALUACION_AF
        Dim lAccionFormativa As ACCION_FORMATIVA

        lAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(idAccionFormativa)
        listaAsistenciaAF = (New cASISTENCIA_AF).ObtenerListaPorACCION_FORMATIVA(idAccionFormativa, False, False, "FECHA", "ASC")
        listaInformes = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(idAccionFormativa, False, False, "FECHA_FINAL", "DESC")

        'Validando que el Período de Ejecución sea consistente
        If listaAsistenciaAF IsNot Nothing AndAlso listaAsistenciaAF.Count > 0 Then
            If listaInformes IsNot Nothing AndAlso listaInformes.Count > 0 Then
                For i As Integer = 0 To listaAsistenciaAF.Count - 1
                    If listaAsistenciaAF(i).FECHA > listaInformes(0).FECHA_FINAL Then
                        fechaInicial = listaAsistenciaAF(i).FECHA
                        Exit For
                    End If
                Next
            Else
                fechaInicial = listaAsistenciaAF(0).FECHA
            End If
        End If

        If fechaInicial <> fechaInicioPeriodo Then
            Return "La fecha inicial del Informe es incorrecta"
        End If

        If listaAsistenciaAF.FindByColum("FECHA", fechaFinPeriodo) < 0 Then
            Return "La fecha final del Informe debe ser una fecha de la programación del Curso"
        End If
        'If fechaFinPeriodo <= fechaInicioPeriodo Then
        '    Return "La fecha final del Informe es igual a la fecha inicial"
        'End If
        If fechaFinPeriodo > DateTime.Today Then
            Return "La fecha final del Informe no debe ser mayor a la fecha actual"
        End If
        If fechaFinPeriodo > lAccionFormativa.FECHA_FIN_REAL Then
            Return "La fecha final del Informe no debe ser mayor a la fecha de finalización del Curso"
        End If
        If fechaFinPeriodo = lAccionFormativa.FECHA_FIN_REAL AndAlso Not EsInformeFinal Then
            Return "No puede generar un Informe Parcial que incluya la fecha de finalización del Curso. Finalice el curso y genere un Informe Final"
        End If

        'Validar que exista al menos 1 evaluacion práctica
        evaluacionesDelPeriodo = (New cEVALUACION_AF).ObtenerListaPorACCION_FORMATIVAPeriodo(idAccionFormativa, fechaInicioPeriodo, fechaFinPeriodo)
        If evaluacionesDelPeriodo Is Nothing OrElse evaluacionesDelPeriodo.Count = 0 AndAlso EsInformeFinal Then
            Return "No se han registrado Evaluaciones dentro de la fecha inicial y final del Informe"
        End If
        Return String.Empty
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un Informe de Ejecución en un Perídodo determinado a partir de una Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	26/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function GenerarInformePorPeriodoEjecucion(ByVal idAccionFormativa As Decimal, ByVal fechaInicioPeriodo As Date, ByVal fechaFinPeriodo As Date, ByVal CrearInforme As Boolean, Optional ByVal EsInformeFinal As Boolean = False) As INFORME_FINAL_AF
        Try
            Dim lEntidad As New INFORME_FINAL_AF
            Dim lResultado As String

            lResultado = Me.EsPeriodoValido(idAccionFormativa, fechaInicioPeriodo, fechaFinPeriodo, EsInformeFinal)
            If lResultado = String.Empty Then
                lEntidad = Me.GenerarInformeParcial(idAccionFormativa, fechaInicioPeriodo, fechaFinPeriodo, CrearInforme)
            Else
                Me.sError = lResultado
                Return Nothing
            End If

            Return lEntidad

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function EsInformeBolpros(ByVal ID_INFORME_FINAL As Decimal) As Boolean

        Try
            Return mDb.EsInformeBolpros(ID_INFORME_FINAL)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return False
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Genera un Informe Parcial de Ejecución en un Perídodo determinado a partir de una Accion Formativa
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	26/07/2012	Created
    '''  	[cramos]	28/02/2013	Modificado: 
    ''' Se agrega validación para considerar activo un participante dentro del programa Hábil Técnico Permanente
    ''' si tiene como mínimo 60% de asistencia si el curso dura 100 horas o más
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function GenerarInformeParcial(ByVal idAccionFormativa As Decimal, ByVal fechaInicioPeriodo As Date, ByVal fechaFinPeriodo As Date, ByVal CrearInforme As Boolean) As INFORME_FINAL_AF
        Try
            Dim lEntidad As New INFORME_FINAL_AF
            Dim listaInformes As listaINFORME_FINAL_AF
            Dim lAccionFormativa As ACCION_FORMATIVA
            Dim lProveedor As PROVEEDOR_AF
            Dim lAccionFormativaDet As ACCION_FORMATIVA_DETALLE
            Dim bAccionFormativa As New cACCION_FORMATIVA
            Dim listaAsistenciaAF As listaASISTENCIA_AF
            Dim lHorasDesarrolladas As Decimal
            Dim lActivos As Decimal = 0
            Dim lParticipantes As Decimal = 0
            Dim porcAsistencia As Decimal = 0

            Dim listaInscritos As listaPARTICIPANTE_AF
            Dim listaDetalleInforme As New listaINFORME_FINAL_DET
            Dim lProgramaFormacion As PROGRAMA_FORMACION
            Dim lMontoPagar As Decimal = 0
            Dim lMontoPagado As Decimal = 0
            Dim lMontoAdjudicado As Decimal = 0
            Dim lValorPenalizacion As Decimal = 0
            Dim lCosto_x_Hora As Decimal = -1
            Dim lCosto_x_Participante As Decimal = 0
            Dim lTotalPorcAsistencia As Decimal = 0
            Dim lTotalNotasFinales As Decimal = 0
            Dim idTipoPago As Decimal
            Dim esCursoBolsa As Boolean = False
            Dim numOfertaCompra As String = ""
            Dim baseParticipante As Decimal = 0
            Dim baseParaPago As CompraBasePago
            Dim cantBaseParti As Decimal = 0
            Dim esInformeParcial As Boolean = False
            Dim dSumaPagosParciales As Decimal = 0
            Dim lPorcAsistenciaAcumuladoAnterioresInformes As Decimal = 0
            Dim sEjercicioContratacion As String = ""

            Dim listaAutorizacion As listaACCION_PROGRA_RETRO


            lAccionFormativa = bAccionFormativa.ObtenerACCION_FORMATIVA(idAccionFormativa)
            lProveedor = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lAccionFormativa.ID_PROVEEDOR_AF)
            lAccionFormativaDet = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(idAccionFormativa)
            lProgramaFormacion = (New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(lAccionFormativaDet.ID_PROGRAMA_FORMACION)
            listaInformes = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(idAccionFormativa, False, False, "FECHA_FINAL", "DESC")
            listaAsistenciaAF = (New cASISTENCIA_AF).ObtenerListaPorACCION_FORMATIVA(idAccionFormativa, False, False, "FECHA", "ASC")

            'Determinar si es cursos de bolsa
            Dim listaGrupoAC As listaGRUPO_ACCION_CONTRATADA = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)
            If listaGrupoAC IsNot Nothing AndAlso listaGrupoAC.Count > 0 Then esCursoBolsa = True

            'Estableciendo el Porcentaje de Asistencia
            porcAsistencia = lProgramaFormacion.PORC_ASISTENCIA_MINIMA

            'Obtener horas desarrolladas
            For i As Integer = 0 To listaAsistenciaAF.Count - 1
                If fechaInicioPeriodo <= listaAsistenciaAF(i).FECHA AndAlso listaAsistenciaAF(i).FECHA <= fechaFinPeriodo Then
                    lHorasDesarrolladas += listaAsistenciaAF(i).CANTIDAD_HORAS
                End If
            Next
            lHorasDesarrolladas = Decimal.Divide(lHorasDesarrolladas, 60)

            If lAccionFormativa.FECHA_FIN_REAL > fechaFinPeriodo Then
                esInformeParcial = True
            End If

            'Obtener participantes a reportar en el Informe  
            listaInscritos = (New cACCION_FORMATIVA).ObtenerListaPARTICIPANTE_AF(idAccionFormativa)
            For i As Integer = 0 To listaInscritos.Count - 1
                Dim lParticipante As PARTICIPANTE_AF = listaInscritos(i)
                Dim lParticipanteInforme As New INFORME_FINAL_DET

                If lParticipante.ESTADO = EstadoParticipanteEnCurso.Inscrito OrElse _
                    lParticipante.ESTADO = EstadoParticipanteEnCurso.Evaluado OrElse _
                    lParticipante.ESTADO = EstadoParticipanteEnCurso.CambioDeCurso OrElse _
                    lParticipante.ESTADO = EstadoParticipanteEnCurso.CambioDeCursoPorSistema Then

                    lParticipanteInforme.ESTADO = "I"
                    lParticipanteInforme.ID_ACCION_FORMATIVA = idAccionFormativa
                    lParticipanteInforme.ID_INFORME_FINAL = 0
                    lParticipanteInforme.ID_PARTICIPANTE = lParticipante.ID_PARTICIPANTE
                    lParticipanteInforme.NOTA_PRACTICA = bAccionFormativa.ObtenerNotaPromedioPeriodo(idAccionFormativa, lParticipante.ID_PARTICIPANTE, False, fechaInicioPeriodo, fechaFinPeriodo)
                    If bAccionFormativa.ObtenerCantidadEvaluacionesTeoricasPeriodo(idAccionFormativa, fechaInicioPeriodo, fechaFinPeriodo) = 0 Then
                        lParticipanteInforme.NOTA_TEORICA = -1
                        lParticipanteInforme.NOTA_OBTENIDA = lParticipanteInforme.NOTA_PRACTICA
                    Else
                        lParticipanteInforme.NOTA_TEORICA = bAccionFormativa.ObtenerNotaPromedioPeriodo(idAccionFormativa, lParticipante.ID_PARTICIPANTE, True, fechaInicioPeriodo, fechaFinPeriodo)
                        lParticipanteInforme.NOTA_OBTENIDA = Decimal.Round(CDec((lParticipanteInforme.NOTA_PRACTICA * 0.8) + (lParticipanteInforme.NOTA_TEORICA * 0.2)), 2)
                    End If

                    'Porcentaje de asistencia específica para Ofertas de compra
                    'Dim lUnidadOrg As UNIDAD_ORGANIZATIVA = (New cUNIDAD_ORGANIZATIVA).ObtenerUNIDAD_ORGANIZATIVAPorAccionFormativa(lAccionFormativa.ID_ACCION_FORMATIVA)
                    Dim lContratoBolproes As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROSPorID_ACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)
                    If lContratoBolproes IsNot Nothing Then
                        Dim lOfertaCompra As CONTRATO_COMPRA = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRA(lContratoBolproes.ID_CONTRATO_COMPRA)

                        If lOfertaCompra IsNot Nothing Then
                            numOfertaCompra = lOfertaCompra.NO_CONTRATO_COMPRA
                            porcAsistencia = lOfertaCompra.PORC_ASISTENCIA_MIN
                            baseParaPago = lOfertaCompra.PAGO_POR_PARTICIPACION
                            cantBaseParti = IIf(lOfertaCompra.BASE_PARTI = -1, 0, lOfertaCompra.BASE_PARTI)
                        End If
                    End If

                    If lParticipante.ESTADO <> EstadoParticipanteEnCurso.CambioDeCurso Then
                        If Not esInformeParcial Then
                            lParticipanteInforme.PORC_ASISTENCIA = bAccionFormativa.ObtenerPorcentajeAsistenciaPromedio(idAccionFormativa, lParticipante.ID_PARTICIPANTE, lAccionFormativa.FECHA_INICIO_REAL, fechaFinPeriodo)

                            'Activos en base a % Mínimo de Asistencia
                            If lParticipanteInforme.PORC_ASISTENCIA >= porcAsistencia Then
                                lParticipanteInforme.MONTO_APROBADO = lAccionFormativa.COSTO_X_PARTICIPANTE
                                lParticipanteInforme.MONTO_SOLICITADO = lAccionFormativa.COSTO_X_PARTICIPANTE

                                lParticipanteInforme.PORC_ASISTENCIA_ACUMULADO = bAccionFormativa.ObtenerPorcentajeAsistenciaPartiAcumuladoInformes(idAccionFormativa, lParticipante.ID_PARTICIPANTE, fechaInicioPeriodo)
                                lParticipanteInforme.ACTIVO = True
                                lActivos += 1
                            End If

                            lParticipantes += 1
                            lTotalNotasFinales += lParticipanteInforme.NOTA_OBTENIDA
                            lTotalPorcAsistencia += lParticipanteInforme.PORC_ASISTENCIA
                        Else
                            lParticipanteInforme.MONTO_APROBADO = 0
                            lParticipanteInforme.MONTO_SOLICITADO = 0

                            Dim diccAsistencia As Dictionary(Of String, Decimal)
                            diccAsistencia = (New cACCION_FORMATIVA).ObtenerInfoAsistenciaReal(idAccionFormativa, lParticipante.ID_PARTICIPANTE, fechaInicioPeriodo, fechaFinPeriodo)
                            If diccAsistencia IsNot Nothing Then
                                lParticipanteInforme.PORC_ASISTENCIA = diccAsistencia("PORCENTAJE_ASISTENCIA")
                                lParticipanteInforme.MINUTOS_ASISTIDOS = diccAsistencia("MINUTOS_ASISTENCIA")
                            End If

                            'Activos en base a % Mínimo de Asistencia
                            If lParticipanteInforme.PORC_ASISTENCIA >= 50 Then
                                lActivos += 1
                            End If

                            lParticipantes += 1
                            lTotalNotasFinales += lParticipanteInforme.NOTA_OBTENIDA
                            lTotalPorcAsistencia += lParticipanteInforme.PORC_ASISTENCIA
                        End If

                    Else
                        lParticipanteInforme.MONTO_APROBADO = -1
                        lParticipanteInforme.MONTO_SOLICITADO = -1
                        lParticipanteInforme.PORC_ASISTENCIA = -1
                        lParticipanteInforme.NOTA_PRACTICA = -1
                        lParticipanteInforme.NOTA_TEORICA = -1
                        lParticipanteInforme.NOTA_OBTENIDA = -1
                    End If

                    'Aprobados
                    If Not esInformeParcial Then
                        If listaInscritos(i).ESTADO = Enumeradores.EstadoParticipanteEnCurso.CambioDeCurso OrElse _
                        listaInscritos(i).ESTADO = Enumeradores.EstadoParticipanteEnCurso.CambioDeCursoPorSistema Then
                            lParticipanteInforme.NOTAS = "CAMBIO DE CURSO"
                        Else
                            If lParticipanteInforme.NOTA_OBTENIDA >= lProgramaFormacion.NOTA_MINIMA AndAlso lParticipanteInforme.PORC_ASISTENCIA >= porcAsistencia Then
                                lParticipanteInforme.ESTADO = "A"
                                lParticipanteInforme.NOTAS = "APROBADO"
                            Else
                                lParticipanteInforme.ESTADO = "R"
                                lParticipanteInforme.NOTAS = "REPROBADO"
                            End If
                        End If
                    Else
                        If listaInscritos(i).ESTADO = Enumeradores.EstadoParticipanteEnCurso.CambioDeCurso OrElse _
                       listaInscritos(i).ESTADO = Enumeradores.EstadoParticipanteEnCurso.CambioDeCursoPorSistema Then
                            lParticipanteInforme.NOTAS = "CAMBIO DE CURSO"
                        ElseIf listaInscritos(i).ESTADO = Enumeradores.EstadoParticipanteEnCurso.Desertado Then
                            lParticipanteInforme.NOTAS = "CAMBIO DE CURSO"
                        Else
                            If lParticipanteInforme.PORC_ASISTENCIA >= 50 Then
                                lParticipanteInforme.ESTADO = "A"
                                lParticipanteInforme.NOTAS = "APROBADO PARA PAGO"
                            Else
                                lParticipanteInforme.ESTADO = ""
                                lParticipanteInforme.NOTAS = ""
                            End If
                        End If
                    End If
                    lParticipanteInforme.PORC_PAGO = -1
                    listaDetalleInforme.Add(lParticipanteInforme)
                End If
            Next

            'Forma de Pago del Programa
            lCosto_x_Participante = lAccionFormativa.COSTO_X_PARTICIPANTE

            'Obtener el monto de los informes anteriores pagados en esta accion formativa
            Dim lInformes As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)
            lMontoPagado = 0
            For Each lInforme As INFORME_FINAL_AF In lInformes
                If lInforme.FECHA_FINAL < fechaInicioPeriodo Then
                    lMontoPagado += lInforme.MONTO_FACTURA
                End If
            Next
            idTipoPago = lProgramaFormacion.ID_TIPO_PAGO
            If idTipoPago = TipoPagoPrograma.Por_Horas_Desarrolladas Then
                'Si el referente es Código 12 entonces cambiar a la forma de pago Costo Participante Variable
                Dim lTermino As TERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(lAccionFormativa.ID_ACCION_FORMATIVA)
                Dim conContratoBolpros As Boolean = bAccionFormativa.EsAccionFormativaBolpros(lAccionFormativa.ID_ACCION_FORMATIVA)

                If lTermino IsNot Nothing AndAlso Not conContratoBolpros Then
                    Dim lCriteria As New List(Of Criteria)
                    Dim lGrupo As New GRUPO_SOLICITUD
                    lCriteria.Add(New Criteria("TDR", "=", lTermino.TDR, "AND"))
                    lCriteria.Add(New Criteria("CORRELATIVO_GRUPO", "=", lTermino.CORRELATIVO_GRUPO.ToString, ""))
                    lGrupo.TDR = lTermino.TDR
                    lGrupo.CORRELATIVO_GRUPO = lTermino.CORRELATIVO_GRUPO
                    Dim listaGrupos As listaGRUPO_SOLICITUD = (New cGRUPO_SOLICITUD).ObtenerListaPorBusqueda(lGrupo, lCriteria.ToArray)

                    If listaGrupos IsNot Nothing AndAlso listaGrupos.Count > 0 Then
                        Dim lSolic As SOLICITUD_CAPACITACION = (New cSOLICITUD_CAPACITACION).ObtenerSOLICITUD_CAPACITACION(listaGrupos(0).ID_SOLICITUD)
                        If lSolic.ID_REFERENTE = 12 Then
                            idTipoPago = TipoPagoPrograma.Por_Participacion_CostoParticipanteVariable
                        End If
                    End If
                End If

                If numOfertaCompra = "06/2017" Then
                    idTipoPago = TipoPagoPrograma.Por_Participacion_CostoParticipanteVariable
                End If

                If numOfertaCompra = "53" Then
                    idTipoPago = TipoPagoPrograma.Por_Participacion_CostoParticipanteFijo
                End If
            End If

            'PENALIZACIONES DE CURSOS
            Dim dPorcPena As Decimal = 0
            Dim listaPenalizaciones As listaACCION_FORMATIVA_PENA = (New cACCION_FORMATIVA_PENA).ObtenerListaPorACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)

            If listaPenalizaciones IsNot Nothing AndAlso listaPenalizaciones.Count > 0 Then
                For i As Int32 = 0 To listaPenalizaciones.Count - 1
                    dPorcPena += listaPenalizaciones(i).PORC_PENALIZACION / 100
                Next
            End If

            'INFORME PARCIAL
            If esInformeParcial Then
                Dim lAccionContratada As ACCION_CONTRATADA
                Dim lTerminoRef As TERMINO_REFERENCIA_AF
                Dim lGrupoAccion As listaGRUPO_ACCION_CONTRATADA = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)
                Dim lOfertaCompra As CONTRATO_COMPRA
                lCosto_x_Participante = 0

                lOfertaCompra = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRAPorID_ACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)

                If lOfertaCompra IsNot Nothing AndAlso lOfertaCompra.PAGO_POR_PARTICIPACION = 0 And lOfertaCompra.ID_UNIDAD_ORGANIZATIVA = Enumeradores.GerenciaUnidad.CENTRO_FORMACION_SAN_BARTOLO Then
                    ' Este procedimiento aplica solo a CFPSB y es cuando se paga por curso independiente de capacitados
                    If lGrupoAccion IsNot Nothing AndAlso lGrupoAccion.Count > 0 Then
                        Dim lDicc As Dictionary(Of String, Decimal)
                        lDicc = (New cACCION_FORMATIVA).ObtenerPorcentajeAvancePorAccionFormativa(lAccionFormativa.ID_ACCION_FORMATIVA, fechaFinPeriodo)
                        If lDicc IsNot Nothing AndAlso lDicc.Count > 0 Then
                            lMontoPagar = lGrupoAccion(0).MONTO * (lDicc("PORCENTAJE_EJECUCION") / 100)
                            lCosto_x_Participante = lGrupoAccion(0).MONTO / lActivos
                            lCosto_x_Hora = lGrupoAccion(0).MONTO / lAccionFormativa.DURACION_HORAS

                            lValorPenalizacion = Math.Round(lMontoPagar * dPorcPena, 2)
                            lMontoPagar = lMontoPagar - lValorPenalizacion

                            lAccionFormativa.COSTO_X_PARTICIPANTE = lCosto_x_Participante
                            bAccionFormativa.ActualizarACCION_FORMATIVA(lAccionFormativa, TipoConcurrencia.Pesimistica, False, False, False)

                            If listaDetalleInforme IsNot Nothing AndAlso listaDetalleInforme.Count > 0 Then
                                lCosto_x_Participante = lMontoPagar / lActivos
                                For i As Integer = 0 To listaDetalleInforme.Count - 1
                                    If listaDetalleInforme(i).PORC_ASISTENCIA >= 50 Then
                                        listaDetalleInforme(i).MONTO_SOLICITADO = lCosto_x_Participante
                                        listaDetalleInforme(i).MONTO_APROBADO = lCosto_x_Participante
                                    End If
                                Next
                            End If
                        End If
                    End If
                Else
                    If lGrupoAccion IsNot Nothing AndAlso lGrupoAccion.Count > 0 Then
                        lAccionContratada = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(lGrupoAccion(0).ID_ACCION_CONTRATADA)
                        If lAccionContratada.COSTO_PARTICIPANTE > 0 Then
                            lCosto_x_Participante = lAccionContratada.COSTO_PARTICIPANTE
                        Else
                            lCosto_x_Participante = lAccionFormativa.COSTO_X_PARTICIPANTE
                        End If
                    Else
                        'Obtener costo x participante Libre Gestión
                        lTerminoRef = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(lAccionFormativa.ID_ACCION_FORMATIVA)
                        If lTerminoRef IsNot Nothing Then
                            lCosto_x_Participante = lTerminoRef.MONTO_ADJUDICADO / 20
                        End If
                    End If
                    lAccionFormativa.COSTO_X_PARTICIPANTE = lCosto_x_Participante
                    bAccionFormativa.ActualizarACCION_FORMATIVA(lAccionFormativa, TipoConcurrencia.Pesimistica, False, False, False)

                    lMontoPagar = 0
                    If listaDetalleInforme IsNot Nothing AndAlso listaDetalleInforme.Count > 0 Then
                        For i As Integer = 0 To listaDetalleInforme.Count - 1
                            If listaDetalleInforme(i).PORC_ASISTENCIA >= 50 Then
                                listaDetalleInforme(i).MONTO_SOLICITADO = Math.Round((lCosto_x_Participante / (lAccionFormativa.DURACION_HORAS * 60)) * listaDetalleInforme(i).MINUTOS_ASISTIDOS, 2)
                                listaDetalleInforme(i).MONTO_APROBADO = Math.Round((lCosto_x_Participante / (lAccionFormativa.DURACION_HORAS * 60)) * listaDetalleInforme(i).MINUTOS_ASISTIDOS, 2)

                                lMontoPagar += listaDetalleInforme(i).MONTO_APROBADO
                            End If
                        Next
                    End If
                    lCosto_x_Hora = lCosto_x_Participante / lAccionFormativa.DURACION_HORAS
                    lValorPenalizacion = Math.Round(lMontoPagar * dPorcPena, 2)
                    lMontoPagar = lMontoPagar - lValorPenalizacion
                End If
               
            Else
                ' Verificar si es un informe final de un curso con informe parcial
                dSumaPagosParciales = 0
                Dim lstInformes As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)
                If lstInformes IsNot Nothing AndAlso lstInformes.Count > 0 Then
                    For i As Integer = 0 To lstInformes.Count - 1
                        If lstInformes(i).FECHA_INICIAL < #3/11/2020# AndAlso lstInformes(i).FECHA_FINAL <= #3/11/2020# AndAlso lAccionFormativa.FECHA_FIN_REAL > #3/11/2020# Then
                            dSumaPagosParciales += lstInformes(0).MONTO_APROBADO
                            idTipoPago = -90
                        End If
                    Next
                End If

                'Verificar si es un informe con contratación para 2022 en adelante
                ' ****************************************************************
                If lAccionFormativa.FECHA_INICIO_REAL.Year >= 2022 AndAlso idTipoPago <> -90 Then
                    Dim lOfeC As CONTRATO_COMPRA
                    Dim lContratoBolpros As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROSPorID_ACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)
                    Dim lTerminoRef As TERMINO_REFERENCIA_AF

                    If lContratoBolpros IsNot Nothing Then
                        lOfeC = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRA(lContratoBolpros.ID_CONTRATO_COMPRA)
                        If lContratoBolpros.FECHA_INI_EJEC.Year >= 2022 Then
                            idTipoPago = -91
                            sEjercicioContratacion = lContratoBolpros.FECHA_INI_EJEC.Year.ToString
                        End If
                    Else 'Contratacion por tdr
                        lTerminoRef = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(lAccionFormativa.ID_ACCION_FORMATIVA)
                        If lTerminoRef IsNot Nothing AndAlso CInt(Right(lTerminoRef.TDR.Trim, 4)) >= 2022 Then
                            idTipoPago = -91
                            sEjercicioContratacion = Right(lTerminoRef.TDR.Trim, 4)
                        End If
                    End If
                End If
                ' ***************************************************************

                'Verificar si informe esta en tabla COMPRA_EX_PAGO_ASISTE (esta condicion invalida las anteriores)
                ' ****************************************************************
                Dim glstCompraExcluida As listaCOMPRA_EX_PAGO_ASISTE
                Dim glTerminoRef As TERMINO_REFERENCIA_AF
                glTerminoRef = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(lAccionFormativa.ID_ACCION_FORMATIVA)
                If glTerminoRef IsNot Nothing Then
                    glstCompraExcluida = (New cCOMPRA_EX_PAGO_ASISTE).ObtenerCOMPRA_EX_PAGO_ASISTE_PorCriterios(glTerminoRef.TDR.Trim, TipoContratacion.TERMINO_DE_REFERENCIA)
                    If glstCompraExcluida IsNot Nothing AndAlso glstCompraExcluida.Count > 0 Then
                        idTipoPago = -92
                    End If
                End If


                Select Case idTipoPago
                    Case TipoPagoPrograma.Por_Horas_Desarrolladas
                        Dim lSolicitud As SOLICITUD_CAPACITACION = (New cSOLICITUD_CAPACITACION).ObtenerPorACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)
                        Dim lContrato As CONTRATO_BOLPROS
                        Dim lTermino As TERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(lAccionFormativa.ID_ACCION_FORMATIVA)

                        If lTermino IsNot Nothing Then
                            lMontoAdjudicado = lTermino.MONTO_ADJUDICADO
                            lValorPenalizacion = Math.Round(lTermino.MONTO_ADJUDICADO * dPorcPena, 2)
                        End If

                        'Si el curso es contratado bajo bolsa y la unidad organizativa es San Bartolo
                        'Dim lUnidadOrg As UNIDAD_ORGANIZATIVA = (New cUNIDAD_ORGANIZATIVA).ObtenerUNIDAD_ORGANIZATIVAPorAccionFormativa(lAccionFormativa.ID_ACCION_FORMATIVA)
                        If numOfertaCompra <> "" AndAlso baseParaPago <> CompraBasePago.PagoCursoIndependienteCapacitados Then
                            lContrato = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROSPorID_ACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)

                            'Calculo de pago por participación
                            Dim cantMaxPartiCurso As Int32 = 0
                            Dim cantPartiInscritos As Int32 = 0
                            If baseParaPago = CompraBasePago.PagoBaseDefinida Then
                                cantMaxPartiCurso = cantBaseParti
                            ElseIf baseParaPago = CompraBasePago.PagoBaseInscritos Then
                                cantMaxPartiCurso = 20
                                cantPartiInscritos = (New cACCION_FORMATIVA).ObtenerCantidadParticipantesInscritos(lAccionFormativa.ID_ACCION_FORMATIVA)
                            End If

                            lCosto_x_Participante = 0
                            Dim lEntidadGrupoContratada As listaGRUPO_ACCION_CONTRATADA = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)
                            If lEntidadGrupoContratada IsNot Nothing AndAlso lEntidadGrupoContratada.Count > 0 Then
                                Dim lAccionContratada As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(lEntidadGrupoContratada(0).ID_ACCION_CONTRATADA)
                                If lAccionContratada IsNot Nothing AndAlso lAccionContratada.COSTO_PARTICIPANTE > 0 Then
                                    lCosto_x_Participante = lAccionContratada.COSTO_PARTICIPANTE
                                End If
                            End If

                            'Reactualizar monto adjudicado y penalización para cursos Online
                            If lContrato IsNot Nothing Then
                                If lTermino IsNot Nothing Then
                                    Dim bTerminoRef As New cTERMINO_REFERENCIA_AF
                                    If lContrato.ID_TIPO_ADJ = TipoAdjudicacionBolpros.AdjudicacionPorCurso_CostoParticipante_Online Then
                                        lTermino.MONTO_ADJUDICADO = lActivos * lCosto_x_Participante
                                        bTerminoRef.ActualizarTERMINO_REFERENCIA_AF(lTermino)
                                        lMontoAdjudicado = lTermino.MONTO_ADJUDICADO
                                    End If
                                End If
                            End If

                            If lCosto_x_Participante = 0 Then lCosto_x_Participante = Utilerias.Truncar(lMontoAdjudicado / cantMaxPartiCurso, 6)
                            If baseParaPago = CompraBasePago.PagoBaseInscritos Then
                                Dim dActivosBase20 As Decimal = 0
                                If cantPartiInscritos > 20 Then cantPartiInscritos = 20
                                If lActivos > 20 Then dActivosBase20 = 20 Else dActivosBase20 = lActivos
                                lMontoPagar = lMontoAdjudicado - ((cantPartiInscritos - dActivosBase20) * lCosto_x_Participante)
                            Else
                                lMontoPagar = Math.Round(lActivos * lCosto_x_Participante, 2)
                            End If

                            If lMontoPagar > lMontoAdjudicado Then
                                lMontoPagar = lMontoAdjudicado
                                lCosto_x_Participante = Utilerias.Truncar(lMontoAdjudicado / lActivos, 6)
                            End If
                            '******* Recalculo por penalización sobre el  monto a pagar *******
                            lValorPenalizacion = Math.Round(lMontoPagar * dPorcPena, 2)
                            lMontoPagar = lMontoPagar - lValorPenalizacion
                            '******************************************************************
                            lCosto_x_Hora = lMontoPagar / lAccionFormativa.DURACION_HORAS
                            lAccionFormativa.COSTO_X_PARTICIPANTE = lCosto_x_Participante
                            bAccionFormativa.ActualizarACCION_FORMATIVA(lAccionFormativa, TipoConcurrencia.Pesimistica, False, False, False)
                        Else
                            'Calculo normal de pago (Libre gestión)
                            Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lAccionFormativa.ID_ACCION_FORMATIVA)
                            If lAccionDetalle IsNot Nothing AndAlso lAccionDetalle.ID_MODALIDAD_FORMACION = ModalidadFormacion.CursoConHerramientasTecnologicas Then
                                ' Pago de participantes que tengan el 80% de asistencia
                                ' Obtener base de pago
                                Dim lTDR As TERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(lAccionFormativa.ID_ACCION_FORMATIVA)

                                If lTDR IsNot Nothing Then
                                    Dim lstGrupoSoli As listaGRUPO_SOLICITUD = (New cGRUPO_SOLICITUD).ObtenerListaPorCriterios(-1, lTDR.TDR, lTDR.CORRELATIVO_GRUPO)
                                    Dim baseParti As Decimal = 0

                                    If lstGrupoSoli IsNot Nothing AndAlso lstGrupoSoli.Count > 0 Then
                                        baseParti = lstGrupoSoli(0).NUM_PARTICIPANTES

                                        lCosto_x_Participante = lMontoAdjudicado / baseParti

                                        If lActivos >= baseParti Then
                                            lMontoPagar = lMontoAdjudicado
                                        Else
                                            lMontoPagar = Math.Round(lCosto_x_Participante * lActivos, 2)
                                        End If

                                        lValorPenalizacion = Math.Round(lMontoPagar * dPorcPena, 2)
                                        lMontoPagar = lMontoPagar - lValorPenalizacion
                                        lCosto_x_Hora = lMontoAdjudicado / lAccionFormativa.DURACION_HORAS
                                        lAccionFormativa.COSTO_X_PARTICIPANTE = lCosto_x_Participante
                                    End If
                                End If
                            Else
                                lCosto_x_Hora = lMontoAdjudicado / lAccionFormativa.DURACION_HORAS
                                lMontoPagar = Math.Round(lCosto_x_Hora * lHorasDesarrolladas, 2)
                                If (fechaFinPeriodo = lAccionFormativa.FECHA_FIN_REAL) OrElse _
                                    ((lMontoPagado + lMontoPagar) > lMontoAdjudicado) Then
                                    lMontoPagar = lMontoAdjudicado - lMontoPagado
                                End If
                                lValorPenalizacion = Math.Round(lMontoPagar * dPorcPena, 2)
                                lMontoPagar = lMontoPagar - lValorPenalizacion
                                lCosto_x_Participante = Utilerias.Truncar(lMontoPagar / lActivos, 6)
                                lCosto_x_Hora = Utilerias.Truncar(lCosto_x_Hora, 4)
                                lAccionFormativa.COSTO_X_PARTICIPANTE = lCosto_x_Participante
                            End If


                            bAccionFormativa.ActualizarACCION_FORMATIVA(lAccionFormativa, TipoConcurrencia.Pesimistica, False, False, False)
                        End If

                    Case TipoPagoPrograma.Por_Participacion_CostoParticipanteFijo
                        'Comprobar si la contratación ha sido por bolsa
                        Dim lEntidadGrupoContratada As listaGRUPO_ACCION_CONTRATADA = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)
                        If lEntidadGrupoContratada IsNot Nothing AndAlso lEntidadGrupoContratada.Count > 0 AndAlso lAccionFormativaDet.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE Then
                            'Contratación por Bolsa
                            Dim lTermino As TERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(lAccionFormativa.ID_ACCION_FORMATIVA)
                            If lTermino IsNot Nothing Then
                                lMontoAdjudicado = lTermino.MONTO_ADJUDICADO

                                Dim cantMaxPartiCurso As Int32 = 0
                                If baseParaPago = CompraBasePago.PagoCursoIndependienteCapacitados Then
                                    cantMaxPartiCurso = lActivos
                                    lCosto_x_Participante = Utilerias.Truncar(lMontoAdjudicado / cantMaxPartiCurso, 6)
                                    listaAutorizacion = (New cACCION_PROGRA_RETRO).ObtenerACCION_PROGRA_RETRO_PorCriterios(lAccionFormativa.ID_PROVEEDOR_AF, _
                                                                                                lAccionFormativa.ID_EJERCICIO, _
                                                                                                lAccionFormativa.CODIGO_GRUPO, _
                                                                                                AutorizacionExcepcion.AplicarMontoLiquidacionContrato, _
                                                                                                1)
                                    If listaAutorizacion IsNot Nothing AndAlso listaAutorizacion.Count > 0 Then
                                        lCosto_x_Participante = lAccionFormativa.COSTO_X_PARTICIPANTE
                                    End If
                                ElseIf baseParaPago = CompraBasePago.PagoBaseDefinida Then
                                    cantMaxPartiCurso = cantBaseParti
                                    lCosto_x_Participante = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(lEntidadGrupoContratada(0).ID_ACCION_CONTRATADA).COSTO_PARTICIPANTE
                                    listaAutorizacion = (New cACCION_PROGRA_RETRO).ObtenerACCION_PROGRA_RETRO_PorCriterios(lAccionFormativa.ID_PROVEEDOR_AF, _
                                                                                                lAccionFormativa.ID_EJERCICIO, _
                                                                                                lAccionFormativa.CODIGO_GRUPO, _
                                                                                                AutorizacionExcepcion.AplicarMontoLiquidacionContrato, _
                                                                                                1)
                                    If listaAutorizacion IsNot Nothing AndAlso listaAutorizacion.Count > 0 Then
                                        lCosto_x_Participante = lAccionFormativa.COSTO_X_PARTICIPANTE
                                    End If
                                ElseIf baseParaPago = CompraBasePago.PagoBaseInscritos Then
                                    cantMaxPartiCurso = (New cACCION_FORMATIVA).ObtenerCantidadParticipantesInscritos(lAccionFormativa.ID_ACCION_FORMATIVA)
                                    lCosto_x_Participante = Utilerias.Truncar(lMontoAdjudicado / cantMaxPartiCurso, 6)
                                    listaAutorizacion = (New cACCION_PROGRA_RETRO).ObtenerACCION_PROGRA_RETRO_PorCriterios(lAccionFormativa.ID_PROVEEDOR_AF, _
                                                                                                lAccionFormativa.ID_EJERCICIO, _
                                                                                                lAccionFormativa.CODIGO_GRUPO, _
                                                                                                AutorizacionExcepcion.AplicarMontoLiquidacionContrato, _
                                                                                                1)
                                    If listaAutorizacion IsNot Nothing AndAlso listaAutorizacion.Count > 0 Then
                                        lCosto_x_Participante = lAccionFormativa.COSTO_X_PARTICIPANTE
                                    End If
                                End If

                                lMontoPagar = Math.Round(lActivos * lCosto_x_Participante, 2)

                                '******* Recalculo por penalización sobre el  monto a pagar *******
                                lValorPenalizacion = Math.Round(lMontoPagar * dPorcPena, 2)
                                lMontoPagar = lMontoPagar - lValorPenalizacion
                                '******************************************************************
                                If lMontoPagar > lMontoAdjudicado Then
                                    lMontoPagar = lMontoAdjudicado
                                    lCosto_x_Participante = Utilerias.Truncar(lMontoAdjudicado / lActivos, 6)
                                End If
                                lCosto_x_Hora = Utilerias.Truncar(lCosto_x_Participante / lAccionFormativa.DURACION_HORAS, 6)
                                lAccionFormativa.COSTO_X_PARTICIPANTE = lCosto_x_Participante
                                bAccionFormativa.ActualizarACCION_FORMATIVA(lAccionFormativa, TipoConcurrencia.Pesimistica, False, False, False)
                            End If
                        Else
                            If lMontoPagado > 0 AndAlso lAccionFormativa.FECHA_FIN_REAL = fechaFinPeriodo AndAlso ((lCosto_x_Participante * lActivos) - lMontoPagado) > 0 Then
                                'Ultimo informe parcial
                                lMontoPagar = (lCosto_x_Participante * lActivos) - lMontoPagado
                                lMontoPagar = lMontoPagar - Math.Round(lMontoPagar * dPorcPena, 2)
                                lValorPenalizacion = Math.Round(lMontoPagar * dPorcPena, 2)
                                lMontoPagar = lMontoPagar - lValorPenalizacion
                                lCosto_x_Hora = Utilerias.Truncar((lMontoPagar / lActivos) / lHorasDesarrolladas, 6)
                            Else
                                lCosto_x_Hora = Utilerias.Truncar(lCosto_x_Participante / lAccionFormativa.DURACION_HORAS, 6)
                                If lAccionFormativa.DURACION_HORAS >= 100 AndAlso (lAccionFormativa.FECHA_INICIO_REAL <> fechaInicioPeriodo OrElse lAccionFormativa.FECHA_FIN_REAL <> fechaFinPeriodo) Then
                                    lMontoPagar = Math.Round(lCosto_x_Hora * lHorasDesarrolladas * lActivos, 2)
                                Else
                                    lMontoPagar = lCosto_x_Participante * lActivos
                                End If
                                lValorPenalizacion = Math.Round(lMontoPagar * dPorcPena, 2)
                                lMontoPagar = lMontoPagar - lValorPenalizacion
                            End If
                        End If

                    Case TipoPagoPrograma.Por_Participacion_CostoParticipanteVariable 'PATI
                        Dim lTermino As TERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(lAccionFormativa.ID_ACCION_FORMATIVA)
                        If lTermino IsNot Nothing Then
                            lMontoAdjudicado = lTermino.MONTO_ADJUDICADO - Math.Round(lTermino.MONTO_ADJUDICADO * dPorcPena, 2)
                            lValorPenalizacion = Math.Round(lTermino.MONTO_ADJUDICADO * dPorcPena, 2)
                        End If
                        lCosto_x_Participante = lMontoAdjudicado / lActivos
                        If lActivos > lAccionFormativa.NUMERO_PARTICIPANTES Then
                            lCosto_x_Participante = Utilerias.Truncar(lMontoAdjudicado / lActivos, 6)
                        Else
                            lCosto_x_Participante = Utilerias.Truncar(lMontoAdjudicado / lAccionFormativa.NUMERO_PARTICIPANTES, 6)
                        End If
                        lCosto_x_Hora = Utilerias.Truncar(lCosto_x_Participante / lHorasDesarrolladas, 6)
                        lMontoPagar = Math.Round(lActivos * lCosto_x_Participante, 2)
                        lAccionFormativa.COSTO_X_PARTICIPANTE = lCosto_x_Participante
                        bAccionFormativa.ActualizarACCION_FORMATIVA(lAccionFormativa, TipoConcurrencia.Pesimistica, False, False, False)

                    Case -90 ' Complemento de informe COVID-19
                        Dim lAccionContratada As ACCION_CONTRATADA
                        Dim lTerminoRef As TERMINO_REFERENCIA_AF
                        Dim lGrupoAccion As listaGRUPO_ACCION_CONTRATADA = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)
                        Dim lOfertaCompra As CONTRATO_COMPRA
                        Dim dMontoAdjudicado As Decimal = 0
                        Dim dValorComplemento As Decimal = 0
                        lCosto_x_Participante = 0

                        lOfertaCompra = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRAPorID_ACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)

                        If lGrupoAccion IsNot Nothing AndAlso lGrupoAccion.Count > 0 Then
                            dMontoAdjudicado = lGrupoAccion(0).MONTO
                            lAccionContratada = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(lGrupoAccion(0).ID_ACCION_CONTRATADA)
                            If lAccionContratada.COSTO_PARTICIPANTE > 0 Then
                                lCosto_x_Participante = lAccionContratada.COSTO_PARTICIPANTE
                            Else
                                lCosto_x_Participante = lAccionFormativa.COSTO_X_PARTICIPANTE
                            End If

                            lMontoPagar = 0
                            If listaDetalleInforme IsNot Nothing AndAlso listaDetalleInforme.Count > 0 Then
                                For i As Integer = 0 To listaDetalleInforme.Count - 1
                                    If listaDetalleInforme(i).ACTIVO Then
                                        lMontoPagar += lCosto_x_Participante - (lCosto_x_Participante * (listaDetalleInforme(i).PORC_ASISTENCIA_ACUMULADO / 100))
                                    End If
                                Next
                            End If
                        Else
                            'Obtener costo x participante Libre Gestión
                            lTerminoRef = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(lAccionFormativa.ID_ACCION_FORMATIVA)
                            If lTerminoRef IsNot Nothing Then
                                dMontoAdjudicado = lTerminoRef.MONTO_ADJUDICADO
                                lCosto_x_Participante = lTerminoRef.MONTO_ADJUDICADO / 20
                            End If

                            dValorComplemento = lCosto_x_Participante * If(lAccionFormativa.PARTICIPANTES_INSCRITOS > 20, 20, lAccionFormativa.PARTICIPANTES_INSCRITOS) - dSumaPagosParciales
                            lMontoPagar = Math.Round(dValorComplemento / If(lAccionFormativa.PARTICIPANTES_INSCRITOS > 20, 20, lAccionFormativa.PARTICIPANTES_INSCRITOS) * lActivos, 2)
                        End If
                        If dMontoAdjudicado < (dSumaPagosParciales + lMontoPagar) Then
                            lMontoPagar = dMontoAdjudicado - dSumaPagosParciales
                        End If
                        lCosto_x_Hora = Utilerias.Truncar(lCosto_x_Participante / lAccionFormativa.DURACION_HORAS, 6)

                    Case -91
                        Dim lAccionContratada As ACCION_CONTRATADA
                        Dim lTerminoRef As TERMINO_REFERENCIA_AF
                        Dim lGrupoAccion As listaGRUPO_ACCION_CONTRATADA = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)
                        Dim lOfertaCompra As CONTRATO_COMPRA
                        Dim dMontoAdjudicado As Decimal = 0
                        Dim dValorComplemento As Decimal = 0
                        Dim lAsistePagoDet As ASISTENCIA_PAGO_DET
                        Dim bAsistePagoDet As New cASISTENCIA_PAGO_DET
                        Dim bInformeDet As New cINFORME_FINAL_DET

                        lCosto_x_Participante = 0
                        lActivos = 0
                        lOfertaCompra = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRAPorID_ACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)

                        If lGrupoAccion IsNot Nothing AndAlso lGrupoAccion.Count > 0 Then
                            dMontoAdjudicado = lGrupoAccion(0).MONTO
                            lAccionContratada = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(lGrupoAccion(0).ID_ACCION_CONTRATADA)
                            If lAccionContratada.COSTO_PARTICIPANTE > 0 Then
                                lCosto_x_Participante = lAccionContratada.COSTO_PARTICIPANTE
                            Else
                                lCosto_x_Participante = lAccionFormativa.COSTO_X_PARTICIPANTE
                            End If

                            lMontoPagar = 0
                            If listaDetalleInforme IsNot Nothing AndAlso listaDetalleInforme.Count > 0 Then
                                For i As Integer = 0 To listaDetalleInforme.Count - 1
                                    'Asignar % de pago según % asistencia para cada participante
                                    lAsistePagoDet = bAsistePagoDet.ObtenerPORC_PAGO_POR_PORC_ASISTENCIA(sEjercicioContratacion, lAccionFormativaDet.ID_MODALIDAD_FORMACION, listaDetalleInforme(i).PORC_ASISTENCIA)
                                    If lAsistePagoDet IsNot Nothing Then
                                        listaDetalleInforme(i).PORC_PAGO = lAsistePagoDet.PORC_PAGO_COSTO_PARTI
                                        listaDetalleInforme(i).MONTO_SOLICITADO = lCosto_x_Participante
                                        listaDetalleInforme(i).MONTO_APROBADO = lCosto_x_Participante * lAsistePagoDet.PORC_PAGO_COSTO_PARTI / 100
                                        lMontoPagar += listaDetalleInforme(i).MONTO_APROBADO
                                        If lAsistePagoDet.PORC_PAGO_COSTO_PARTI > 0 Then lActivos += 1
                                    End If
                                Next
                            End If
                        Else
                            'Obtener costo x participante Libre Gestión
                            lTerminoRef = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(lAccionFormativa.ID_ACCION_FORMATIVA)
                            If lTerminoRef IsNot Nothing Then
                                dMontoAdjudicado = lTerminoRef.MONTO_ADJUDICADO
                                lCosto_x_Participante = lTerminoRef.MONTO_ADJUDICADO / 20
                            End If

                            lMontoPagar = 0
                            If listaDetalleInforme IsNot Nothing AndAlso listaDetalleInforme.Count > 0 Then
                                For i As Integer = 0 To listaDetalleInforme.Count - 1
                                    'Asignar % de pago según % asistencia para cada participante
                                    lAsistePagoDet = bAsistePagoDet.ObtenerPORC_PAGO_POR_PORC_ASISTENCIA(sEjercicioContratacion, lAccionFormativaDet.ID_MODALIDAD_FORMACION, listaDetalleInforme(i).PORC_ASISTENCIA)
                                    If lAsistePagoDet IsNot Nothing Then
                                        listaDetalleInforme(i).PORC_PAGO = lAsistePagoDet.PORC_PAGO_COSTO_PARTI
                                        listaDetalleInforme(i).MONTO_SOLICITADO = lCosto_x_Participante
                                        listaDetalleInforme(i).MONTO_APROBADO = lCosto_x_Participante * lAsistePagoDet.PORC_PAGO_COSTO_PARTI / 100
                                        lMontoPagar += listaDetalleInforme(i).MONTO_APROBADO
                                        If lAsistePagoDet.PORC_PAGO_COSTO_PARTI > 0 Then lActivos += 1
                                    End If
                                Next
                            End If
                        End If
                        If dMontoAdjudicado < lMontoPagar Then
                            lMontoPagar = dMontoAdjudicado
                        End If
                        lValorPenalizacion = Math.Round(lMontoPagar * dPorcPena, 2)
                        lMontoPagar = lMontoPagar - lValorPenalizacion
                        lCosto_x_Hora = Utilerias.Truncar(lCosto_x_Participante / lAccionFormativa.DURACION_HORAS, 6)


                    Case -92
                        Dim lTermino As TERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(lAccionFormativa.ID_ACCION_FORMATIVA)

                        If lTermino IsNot Nothing Then
                            lMontoAdjudicado = lTermino.MONTO_ADJUDICADO
                            lCosto_x_Hora = lMontoAdjudicado / lAccionFormativa.DURACION_HORAS
                            lValorPenalizacion = Math.Round(lTermino.MONTO_ADJUDICADO * dPorcPena, 2)

                            lMontoPagar = lMontoAdjudicado - lValorPenalizacion
                            lCosto_x_Participante = Utilerias.Truncar(lMontoPagar / lActivos, 6)
                            lCosto_x_Hora = Utilerias.Truncar(lCosto_x_Hora, 4)
                            lAccionFormativa.COSTO_X_PARTICIPANTE = lCosto_x_Participante

                            bAccionFormativa.ActualizarACCION_FORMATIVA(lAccionFormativa, TipoConcurrencia.Pesimistica, False, False, False)
                        End If
                End Select
            End If

            With lEntidad
                .ID_INFORME_FINAL = 0
                .ID_ACCION_FORMATIVA = lAccionFormativa.ID_ACCION_FORMATIVA
                .ID_PROVEEDOR_AF = lAccionFormativa.ID_PROVEEDOR_AF
                .FECHA_INFORME = fechaFinPeriodo
                .ELABORADO_POR = Utilerias.ObtenerUsuario
                .MONTO_FACTURA = lMontoPagar
                .MONTO_APROBADO = lMontoPagar
                .MONTO_PAGO_INICIAL = lMontoPagar + lValorPenalizacion
                .PARTICIPANTES_INSCRITOS = (New cACCION_FORMATIVA).ObtenerCantidadParticipantesInscritos(lAccionFormativa.ID_ACCION_FORMATIVA)
                Dim lDetalleAccion As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lAccionFormativa.ID_ACCION_FORMATIVA)
                If lDetalleAccion IsNot Nothing Then
                    If lDetalleAccion.ID_FUENTE = Enumeradores.FuenteFinanciamientoPATI.PATI_USAID AndAlso _
                       lDetalleAccion.NO_CONVOCATORIA >= 4 Then
                        .PARTICIPANTES_INSCRITOS = lAccionFormativa.NUMERO_PARTICIPANTES
                    End If
                End If
                .PARTICIPANTES_FINALES = lActivos
                .PORC_PROM_ASISTENCIA = Math.Round(lTotalNotasFinales / lParticipantes, 2)
                .NOTA_PROMEDIO = Math.Round(lTotalNotasFinales / lParticipantes, 2)
                .ID_ESTADO_INFORME = EstadoInformeFinal.Emitido
                .HORAS_DESARROLLADAS = lHorasDesarrolladas
                .FECHA_INICIAL = fechaInicioPeriodo
                .FECHA_FINAL = fechaFinPeriodo
                .HORARIO = bAccionFormativa.ObtenerHorarioPorPeriodo(idAccionFormativa, fechaInicioPeriodo, fechaFinPeriodo)
                .COSTO_X_HORA = lCosto_x_Hora
                .INFORME_FINAL_DET_INFORME_FINAL = listaDetalleInforme
                .USERID = Utilerias.ObtenerUsuario
                .LASTUPDATE = Now
            End With
            If CrearInforme Then
                'Crear Encabezado de Informe de Ejecución
                Dim bInformeDet As New cINFORME_FINAL_DET
                Dim esNuevo As Boolean = (lEntidad.ID_INFORME_FINAL = 0)
                If mDb.Actualizar(lEntidad) <> 1 Then
                    Return Nothing
                End If
                If esNuevo Then
                    'Generar registro histórico
                    Dim bInformeHist As New cINFORME_FINAL_AF_HIS
                    Dim lInformeHist As New INFORME_FINAL_AF_HIS

                    With lInformeHist
                        .ID_INFORME_FINAL_HIS = 0
                        .ID_INFORME_FINAL = lEntidad.ID_INFORME_FINAL
                        .ID_ACCION_FORMATIVA = lEntidad.ID_ACCION_FORMATIVA
                        .ID_PROVEEDOR_AF = lEntidad.ID_PROVEEDOR_AF
                        .FECHA_INFORME = lEntidad.FECHA_INFORME
                        .NUMERO_FACTURA = lEntidad.NUMERO_FACTURA
                        .ELABORADO_POR = lEntidad.ELABORADO_POR
                        .MONTO_FACTURA = lEntidad.MONTO_FACTURA
                        .MONTO_APROBADO = lEntidad.MONTO_APROBADO
                        .MONTO_PAGO_INICIAL = lEntidad.MONTO_PAGO_INICIAL
                        .PARTICIPANTES_INSCRITOS = lEntidad.PARTICIPANTES_INSCRITOS
                        .PARTICIPANTES_FINALES = lEntidad.PARTICIPANTES_FINALES
                        .PORC_PROM_ASISTENCIA = lEntidad.PORC_PROM_ASISTENCIA
                        .NOTA_PROMEDIO = lEntidad.NOTA_PROMEDIO
                        .COMENTARIOS = lEntidad.COMENTARIOS
                        .USUARIO_APROBACION = lEntidad.USUARIO_APROBACION
                        .LASTUPDATE = lEntidad.LASTUPDATE
                        .USERID = lEntidad.USERID
                        .ID_ESTADO_INFORME = lEntidad.ID_ESTADO_INFORME
                        .HORAS_DESARROLLADAS = lEntidad.HORAS_DESARROLLADAS
                        .FECHA_INICIAL = lEntidad.FECHA_INICIAL
                        .FECHA_FINAL = lEntidad.FECHA_FINAL
                        .HORARIO = lEntidad.HORARIO
                        .COSTO_X_HORA = lEntidad.COSTO_X_HORA
                        .LASTUPDATE = lEntidad.LASTUPDATE
                        .USUARIO_ASIGNADO = lEntidad.USUARIO_ASIGNADO
                    End With
                    bInformeHist.ActualizarINFORME_FINAL_AF_HIS(lInformeHist)
                End If

                'Crear Detalle de Informe de Ejecución
                For Each lDetalleInforme As INFORME_FINAL_DET In listaDetalleInforme
                    lDetalleInforme.ID_INFORME_FINAL = lEntidad.ID_INFORME_FINAL
                    bInformeDet.ActualizarINFORME_FINAL_DET(lDetalleInforme)
                Next
            End If

            'Verificar que los participantes estén incorporados en el informe, de lo contrario agregarlos
            If Not CrearInforme Then
                Dim lstInforme As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(idAccionFormativa)
                If lstInforme IsNot Nothing AndAlso lstInforme.Count > 0 Then
                    For i As Int32 = 0 To lstInforme.Count - 1
                        Dim lPartiInforme As listaINFORME_FINAL_DET = (New cINFORME_FINAL_DET).ObtenerListaPorINFORME_FINAL_AF(lstInforme(i).ID_INFORME_FINAL)
                        Dim listaIdParti As New List(Of Integer)
                        Dim bInformeDet As New cINFORME_FINAL_DET

                        If lPartiInforme IsNot Nothing AndAlso lPartiInforme.Count > 0 Then
                            For j As Integer = 0 To lPartiInforme.Count - 1
                                listaIdParti.Add(lPartiInforme(j).ID_PARTICIPANTE)
                            Next
                        End If

                        For Each lDetalleInforme As INFORME_FINAL_DET In listaDetalleInforme
                            If Not listaIdParti.Contains(lDetalleInforme.ID_PARTICIPANTE) Then
                                lDetalleInforme.ID_INFORME_FINAL = lstInforme(i).ID_INFORME_FINAL
                                lDetalleInforme.ID_INFORME_FINAL_DET = 0
                                bInformeDet.ActualizarINFORME_FINAL_DET(lDetalleInforme)
                            Else
                                Dim lstInformeDet As listaINFORME_FINAL_DET = bInformeDet.ObtenerListaPorInformeIdParticipante(lstInforme(i).ID_INFORME_FINAL, lDetalleInforme.ID_PARTICIPANTE)
                                If lstInformeDet IsNot Nothing AndAlso lstInformeDet.Count = 1 Then
                                    lDetalleInforme.ID_INFORME_FINAL = lstInformeDet(i).ID_INFORME_FINAL
                                    lDetalleInforme.ID_INFORME_FINAL_DET = lstInformeDet(i).ID_INFORME_FINAL_DET
                                    bInformeDet.ActualizarINFORME_FINAL_DET(lDetalleInforme)
                                End If
                            End If
                        Next
                    Next
                End If
            End If


            Return lEntidad

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function GenerarPenalizacionPorEntregaTardia(ByVal lInforme As INFORME_FINAL_AF, Optional GenerarPenalizacion As Boolean = True) As ACCION_FORMATIVA_PENA
        '   *****************************************************************************
        '   Proceso para aplicación de Penalización por Entrega extemporánea de informe
        '   *****************************************************************************
        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA)
        Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROSPorID_ACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA)
        Dim sCodiLici As String = ""
        Dim sOfertaCompra As String = ""
        Dim existePena As Boolean = False
        Dim lOferta As OFERTA_FORMATIVA = (New cOFERTA_FORMATIVA).ObtenerOFERTA_FORMATIVA(lAccionFormativa.ID_OFERTA_FORMATIVA)
        Dim lRet As ACCION_FORMATIVA_PENA = Nothing
        Dim lIdPrograma As Decimal = 0
        Dim lDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lInforme.ID_ACCION_FORMATIVA)

        If lContrato IsNot Nothing Then
            Dim lContratoCompra As CONTRATO_COMPRA = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRA(lContrato.ID_CONTRATO_COMPRA)
            If lContratoCompra IsNot Nothing Then sOfertaCompra = lContratoCompra.NO_CONTRATO_COMPRA
            lIdPrograma = lContrato.ID_PROGRAMA_FORMACION
        End If
        If lOferta IsNot Nothing AndAlso lOferta.ID_CONTRATO > 0 Then
            Dim lContraLici As CONTRATO_PROVEEDOR_AF = (New cCONTRATO_PROVEEDOR_AF).ObtenerCONTRATO_PROVEEDOR_AF(lOferta.ID_CONTRATO)
            If lContraLici IsNot Nothing Then
                sCodiLici = lContraLici.NUM_LICITACION
            End If
            If lDetalle IsNot Nothing Then lIdPrograma = lDetalle.ID_PROGRAMA_FORMACION
        End If


        If lContrato IsNot Nothing OrElse (sCodiLici = "9/2018" OrElse sOfertaCompra = "187/2018" OrElse sOfertaCompra = "08/2018") Then
            'Si existe historico de entrega de informe entonces no penalizar
            Dim lInfoHisto As listaINFORME_FINAL_AF_HIS = (New cINFORME_FINAL_AF_HIS).ObtenerListaPorINFORME_FINAL_AF(lInforme.ID_INFORME_FINAL)
            Dim informeFueEntregadoDiasAtras As Boolean = False

            If lInfoHisto IsNot Nothing AndAlso lInfoHisto.Count > 0 Then
                For i As Integer = 0 To lInfoHisto.Count - 1
                    If lInfoHisto(i).ID_ESTADO_INFORME = EstadoInformeFinal.InformeRecibido Then
                        informeFueEntregadoDiasAtras = True
                        Exit For
                    End If
                Next
            End If

            If Not informeFueEntregadoDiasAtras Then
                Dim lDiasDespuesEntrega As Integer = Math.Abs(DateDiff(DateInterval.Day, Today, lAccionFormativa.FECHA_FIN_REAL))
                Dim lRgoPena As CONTRATO_COMPRA_PENALIZACION = (New cCONTRATO_COMPRA_PENALIZACION).ObtenerRANGO_PORC_PENA_PorDIAS(lContrato.ID_CONTRATO_COMPRA, lDiasDespuesEntrega, TipoPenalizacion.EntregaExtemporaneaInforme)
                If lRgoPena IsNot Nothing AndAlso lRgoPena.PORC_PENA > 0 Then
                    Dim lPena As New ACCION_FORMATIVA_PENA
                    Dim bPena As New cACCION_FORMATIVA_PENA

                    lPena.ID_ACCION_FORMATIVA_PENA = 0

                    'Verificar si ya existe penalización de este tipo
                    Dim lstPena As listaACCION_FORMATIVA_PENA = (New cACCION_FORMATIVA_PENA).ObtenerListaPorACCION_FORMATIVA(lAccionFormativa.ID_ACCION_FORMATIVA)
                    If lstPena IsNot Nothing AndAlso lstPena.Count > 0 Then
                        For j As Int32 = 0 To lstPena.Count - 1
                            If lstPena(j).ID_TIPO_PENA = TipoPenalizacion.EntregaExtemporaneaInforme Then
                                lPena = lstPena(j)
                                existePena = True
                            End If
                        Next
                    End If

                    If Not existePena Then
                        'Aplicar penalización                                    
                        lPena.ID_ACCION_FORMATIVA = lInforme.ID_ACCION_FORMATIVA
                        lPena.PORC_PENALIZACION = lRgoPena.PORC_PENA
                        lPena.MOTIVO = "PENALIZACION POR ENTREGA TARDIA DE INFORME. DIAS TRANSCURRIDOS DESDE QUE FINALIZO EL CURSO HASTA LA ENTREGA DEL INFORME:" + lDiasDespuesEntrega.ToString + " DIA(S),  PORCENTAJE DE PENALIZACION: " + lRgoPena.PORC_PENA.ToString + "%"
                        lPena.USUARIO_CREACION = lInforme.USERID
                        lPena.FECHA_CREACION = Now
                        lPena.ID_TIPO_PENA = TipoPenalizacion.FinalizacionExtemporaneaCurso
                        If GenerarPenalizacion Then bPena.ActualizarACCION_FORMATIVA_PENA(lPena)
                        lRet = lPena
                    End If
                End If
                '   *****************************************************************************
            End If
        End If

        Return lRet
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro de la Entidad que recibe de 
    ''' parámetro; en el caso de que sea actualizar toma en cuenta el Tipo de 
    ''' Concurrencia recibida de parametro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia del Registro a Actualizar</param>
    ''' <history>
    ''' 	[cramos]	30/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------   
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarINFORME_FINAL_AF(ByVal aEntidad As INFORME_FINAL_AF, _
                                               ByVal aTipoConcurrencia As TipoConcurrencia, _
                                               Optional ByVal RegenerarInforme As Boolean = False, _
                                               Optional ByVal GenerarHistorico As Boolean = False, _
                                               Optional ByVal NotificarPorCorreo As Boolean = False) As Integer
        Try
            Dim lEntidad As INFORME_FINAL_AF
            Dim bInformeDet As New cINFORME_FINAL_DET
            Dim listaInformeDet As listaINFORME_FINAL_DET
            Dim lRet As Integer
            Dim lEntidadAntesAct As INFORME_FINAL_AF
            Dim esNuevo As Boolean = (aEntidad.ID_INFORME_FINAL = 0)

            'Definiendo una variable de Usuario y Fecha/Hora de Actualización para que registro actual e histórico sean consistentes
            Dim usuario As String = Utilerias.ObtenerUsuario
            Dim fechaHoraACTUALIZACION As Date = Now

            If aEntidad.ID_INFORME_FINAL = 0 Then
                Me.sError = "Genere un Informe antes de Actualizar"
                Return -1
            Else
                'Obtener la Entidad antes de Actualizarla
                lEntidadAntesAct = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(aEntidad.ID_INFORME_FINAL)

                If RegenerarInforme Then
                    If aEntidad.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.Emitido OrElse _
                        aEntidad.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones OrElse _
                        aEntidad.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeConObservacionesSolventadas Then
                        'Regenerarlo antes de actualizarlo
                        lEntidad = Me.GenerarInformeParcial(aEntidad.ID_ACCION_FORMATIVA, aEntidad.FECHA_INICIAL, aEntidad.FECHA_FINAL, False)
                        If lEntidad Is Nothing Then Return -1
                        lEntidad.ID_INFORME_FINAL = aEntidad.ID_INFORME_FINAL
                        lEntidad.ID_ESTADO_INFORME = aEntidad.ID_ESTADO_INFORME
                    Else
                        Me.sError = "El Informe se encuentra en un estado que no puede Regenerarse"
                        Return -1
                    End If
                Else
                    'Mantener la información del Informe
                    lEntidad = aEntidad
                End If

                'Generar penalización si aplica
                If aEntidad.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeRecibido Then
                    Dim lAccionPena As ACCION_FORMATIVA_PENA = Me.GenerarPenalizacionPorEntregaTardia(aEntidad)
                    If lAccionPena IsNot Nothing Then
                        lEntidad = Me.GenerarInformeParcial(aEntidad.ID_ACCION_FORMATIVA, aEntidad.FECHA_INICIAL, aEntidad.FECHA_FINAL, False)
                        lEntidad.ID_INFORME_FINAL = aEntidad.ID_INFORME_FINAL
                        lEntidad.ID_ESTADO_INFORME = aEntidad.ID_ESTADO_INFORME
                    End If
                End If

                If GenerarHistorico AndAlso (lEntidadAntesAct.ID_ESTADO_INFORME <> lEntidad.ID_ESTADO_INFORME) Then
                    'Generar registro histórico
                    Dim bInformeHist As New cINFORME_FINAL_AF_HIS
                    Dim lInformeHist As New INFORME_FINAL_AF_HIS

                    With lInformeHist
                        .ID_INFORME_FINAL_HIS = 0
                        .ID_INFORME_FINAL = aEntidad.ID_INFORME_FINAL
                        .ID_ACCION_FORMATIVA = aEntidad.ID_ACCION_FORMATIVA
                        .ID_PROVEEDOR_AF = aEntidad.ID_PROVEEDOR_AF
                        .FECHA_INFORME = aEntidad.FECHA_INFORME
                        .NUMERO_FACTURA = aEntidad.NUMERO_FACTURA
                        .ELABORADO_POR = aEntidad.ELABORADO_POR
                        .MONTO_FACTURA = aEntidad.MONTO_FACTURA
                        .MONTO_APROBADO = aEntidad.MONTO_APROBADO
                        .PARTICIPANTES_INSCRITOS = aEntidad.PARTICIPANTES_INSCRITOS
                        .PARTICIPANTES_FINALES = aEntidad.PARTICIPANTES_FINALES
                        .PORC_PROM_ASISTENCIA = aEntidad.PORC_PROM_ASISTENCIA
                        .NOTA_PROMEDIO = aEntidad.NOTA_PROMEDIO
                        .COMENTARIOS = aEntidad.COMENTARIOS
                        .USUARIO_APROBACION = aEntidad.USUARIO_APROBACION
                        .LASTUPDATE = aEntidad.LASTUPDATE
                        .USERID = aEntidad.USERID
                        .ID_ESTADO_INFORME = aEntidad.ID_ESTADO_INFORME
                        .HORAS_DESARROLLADAS = aEntidad.HORAS_DESARROLLADAS
                        .FECHA_INICIAL = aEntidad.FECHA_INICIAL
                        .FECHA_FINAL = aEntidad.FECHA_FINAL
                        .HORARIO = aEntidad.HORARIO
                        .USERID = aEntidad.USERID
                        .LASTUPDATE = aEntidad.LASTUPDATE
                        .COSTO_X_HORA = aEntidad.COSTO_X_HORA
                        .MONTO_PAGO_INICIAL = aEntidad.MONTO_PAGO_INICIAL
                    End With
                    If bInformeHist.ActualizarINFORME_FINAL_AF_HIS(lInformeHist) <> 1 Then
                        Me.sError = bInformeHist.sError
                        Return -1
                    End If
                End If
            End If

            lEntidad.USERID = usuario
            lEntidad.LASTUPDATE = fechaHoraACTUALIZACION
            lRet = mDb.Actualizar(lEntidad, TipoConcurrencia.Pesimistica)

            'Enviar correo de notificación
            If Not esNuevo AndAlso NotificarPorCorreo AndAlso lRet > 0 Then
                If lEntidad.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeEnProcesoBolpros Then
                    If Me.EnviarObservacionesInformeFinalPorCorreo(aEntidad, Me.ObtenerCuerpoCorreoInformeProcesoBolpros(aEntidad)) <> 1 Then
                        Me.sError = "No se logro enviar notificación del cambio de estado por correo"
                        lRet = -2
                    End If
                End If
                If lEntidad.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.SeguimientoGFI Then
                    If Me.EnviarObservacionesInformeFinalPorCorreo(aEntidad, Me.ObtenerCuerpoCorreoInformeSeguimientoGFI(aEntidad)) <> 1 Then
                        Me.sError = "No se logro enviar notificación del cambio de estado por correo"
                        lRet = -2
                    End If
                End If
                If lEntidad.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoaCA Then
                    If Me.EnviarObservacionesInformeFinalPorCorreo(aEntidad, Me.ObtenerCuerpoCorreoInformeDevueltoCA(aEntidad)) <> 1 Then
                        Me.sError = "No se logro enviar notificación del cambio de estado por correo"
                        lRet = -2
                    End If
                End If
                If lEntidad.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.OrdenEntregaValidada Then
                    If Me.EnviarObservacionesInformeFinalPorCorreo(aEntidad, Me.ObtenerCuerpoCorreoOrdenValidada(aEntidad)) <> 1 Then
                        Me.sError = "No se logro enviar notificación del cambio de estado por correo"
                        lRet = -2
                    End If
                End If
                If lEntidad.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.OrdenEntregaObservada Then
                    If Me.EnviarObservacionesInformeFinalPorCorreo(aEntidad, Me.ObtenerCuerpoCorreoOrdenEntregaObservada(aEntidad)) <> 1 Then
                        Me.sError = "No se logro enviar notificación del cambio de estado por correo"
                        lRet = -2
                    End If
                End If
                If lEntidad.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.FacturaObservada Then
                    If Me.EnviarObservacionesInformeFinalPorCorreo(aEntidad, Me.ObtenerCuerpoCorreoFacturaObservada(aEntidad)) <> 1 Then
                        Me.sError = "No se logro enviar notificación del cambio de estado por correo"
                        lRet = -2
                    End If
                End If




                If lEntidad.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeConObservacionesSolventadas Then
                    If Me.EnviarNotificacionObservacionesSolvPorCorreo(aEntidad, Me.ObtenerCuerpoCorreoObservacionesSolvInformeFinal(aEntidad)) <> 1 Then
                        Me.sError = "El Tecnico de INSAFORP no pudo ser notificado por correo de las Observaciones Solventadas del Informe Final"
                        lRet = -2
                    End If
                End If

                If lEntidad.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones Then
                    If Me.EnviarObservacionesInformeFinalPorCorreo(aEntidad, Me.ObtenerCuerpoCorreoDevolucionInformeFinal(aEntidad)) <> 1 Then
                        Me.sError = "El Proveedor no pudo ser notificado por correo de las Observaciones del Informe Final"
                        lRet = -2
                    End If
                End If

                If lEntidad.ID_ESTADO_INFORME = EstadoInformeFinal.FacturaSolicitadaProveedor Then
                    If Me.EnviarSolicitudFacturaProveedor(aEntidad, Me.ObtenerCuerpoCorreoSolicitudFactura(aEntidad), Utilerias.ObtenerUsuario) <> 1 Then
                        Me.sError = "El Proveedor no pudo ser notificado por correo del Envio de la Factura para Pago"
                        lRet = -2
                    End If
                End If
            End If

            If RegenerarInforme Then
                'Actualizar detalle del informe
                listaInformeDet = bInformeDet.ObtenerListaPorINFORME_FINAL_AF(lEntidad.ID_INFORME_FINAL)
                For Each lDetalleInforme As INFORME_FINAL_DET In lEntidad.INFORME_FINAL_DET_INFORME_FINAL
                    If listaInformeDet IsNot Nothing Then
                        Dim lPartiFinal As INFORME_FINAL_DET = listaInformeDet.BuscarPorInformeParticipante(lEntidad.ID_INFORME_FINAL, lDetalleInforme.ID_PARTICIPANTE)
                        If lPartiFinal IsNot Nothing Then
                            lDetalleInforme.ID_INFORME_FINAL_DET = lPartiFinal.ID_INFORME_FINAL_DET
                        End If
                    End If
                    lDetalleInforme.ID_INFORME_FINAL = lEntidad.ID_INFORME_FINAL
                    lDetalleInforme.USERID = usuario
                    lDetalleInforme.LASTUPDATE = fechaHoraACTUALIZACION
                    bInformeDet.ActualizarINFORME_FINAL_DET(lDetalleInforme)
                Next

                'Eliminar el detalle no generado
                If listaInformeDet IsNot Nothing Then
                    For Each lDetalleInforme As INFORME_FINAL_DET In listaInformeDet
                        If lEntidad.INFORME_FINAL_DET_INFORME_FINAL.BuscarPorInformeParticipante(lEntidad.ID_INFORME_FINAL, lDetalleInforme.ID_PARTICIPANTE) Is Nothing Then
                            bInformeDet.EliminarINFORME_FINAL_DET(lDetalleInforme.ID_INFORME_FINAL_DET)
                        End If
                    Next
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
    ''' Función que devuelve el Cuerpo de un Correo de Devolución de Informe Final
    ''' </summary>
    ''' <param name="aEntidad"></param>    
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/12/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCuerpoCorreoSolicitudFactura(ByVal aEntidad As INFORME_FINAL_AF) As String
        Dim lListaInforme As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
        Dim Cuerpo As New StringBuilder
        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
        Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(aEntidad.ID_ACCION_FORMATIVA)
        Dim lIdPrograma As Decimal = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(aEntidad.ID_ACCION_FORMATIVA)

        Dim listaTerminoRef As listaTERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerListaPorACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
        Dim lDeptosMunicipios As Dictionary(Of String, String) = (New cACCION_FORMATIVA).ObtenerDeptoMunicipio(aEntidad.ID_ACCION_FORMATIVA)


        Select Case lIdPrograma
            Case ProgramasFormacion.HABIL_TECNICO_PERMANENTE
                Dim lInforme As INFORME_FINAL_AF
                Dim lEntidadOfertaFormativa As OFERTA_FORMATIVA
                Dim lEntidadContratoProveedor As CONTRATO_PROVEEDOR_AF
                Cuerpo.Append("<html>")
                Cuerpo.Append("<body>")
                Cuerpo.Append("<br/><br/>")
                Cuerpo.Append("Se&ntilde;ores<br/>")
                Cuerpo.Append((New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF).NOMBRE_PROVEEDOR + "<br/>")
                Cuerpo.Append("Presente<br/><br/><br/>")
                Cuerpo.Append("Por este medio se les solicita presentar factura para visto bueno correspondiente al Programa H&aacute;bil T&eacute;cnico Permanente. ")
                Cuerpo.Append("La informaci&oacute;n m&iacute;nima que debe contener la factura es la siguiente:<br/><br/>")
                Cuerpo.Append("CLIENTE:<br/>")
                Cuerpo.Append("DUI O NIT:<br/>")
                Cuerpo.Append("FECHA:<br/>")
                Cuerpo.Append("DIRECCIÓN:<br/><br/>")
                Cuerpo.Append("Y en descripción por favor detallar lo siguiente:<br/><br/>")
                Cuerpo.Append("NOMBRE DEL CURSO: ") : Cuerpo.Append(lAccionFormativa.NOMBRE_ACCION_FORMATIVA) : Cuerpo.Append("<br/>")
                Cuerpo.Append("CODIGO: ") : Cuerpo.Append(lAccionFormativa.CODIGO_GRUPO) : Cuerpo.Append("<br/>")
                Cuerpo.Append("FECHA DE INICIO: ") : Cuerpo.Append(aEntidad.FECHA_INICIAL.ToString("dd/MM/yyyy")) : Cuerpo.Append("<br/>")
                Cuerpo.Append("FECHA DE FINALIZACION: ") : Cuerpo.Append(aEntidad.FECHA_FINAL.ToString("dd/MM/yyyy")) : Cuerpo.Append("<br/>")
                lEntidadOfertaFormativa = (New cOFERTA_FORMATIVA).ObtenerOFERTA_FORMATIVA(lAccionFormativa.ID_OFERTA_FORMATIVA)
                lEntidadContratoProveedor = (New cCONTRATO_PROVEEDOR_AF).ObtenerCONTRATO_PROVEEDOR_AF(lEntidadOfertaFormativa.ID_CONTRATO)
                Cuerpo.Append("No. DE CONTRATO: ") : Cuerpo.Append(lEntidadContratoProveedor.NUM_CONTRATO) : Cuerpo.Append("<br/>")
                lInforme = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(aEntidad.ID_INFORME_FINAL)
                If lInforme IsNot Nothing Then
                    Cuerpo.Append("POR EL MONTO DE: ") : Cuerpo.Append(lInforme.MONTO_FACTURA.ToString("$ #,##0.00"))
                End If
                Cuerpo.Append("</body>")
                Cuerpo.Append("</html>")


            Case ProgramasFormacion.PROYECTO_ESPECIAL
                Dim lInforme As INFORME_FINAL_AF
                Cuerpo.Append("<html>")
                Cuerpo.Append("<body>")
                Cuerpo.Append("<br/><br/>")
                Cuerpo.Append("Se&ntilde;ores<br/>")
                Cuerpo.Append((New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF).NOMBRE_PROVEEDOR + "<br/>")
                Cuerpo.Append("Presente<br/><br/><br/>")
                Cuerpo.Append("Por este medio se les solicita presentar factura para visto bueno. ")
                Cuerpo.Append("La informaci&oacute;n m&iacute;nima que debe contener la factura es la siguiente:<br/><br/>")
                Cuerpo.Append("CLIENTE:<br/>")
                Cuerpo.Append("DUI O NIT:<br/>")
                Cuerpo.Append("FECHA:<br/>")
                Cuerpo.Append("DIRECCIÓN:<br/><br/>")
                Cuerpo.Append("Y en descripción por favor detallar lo siguiente:<br/><br/>")
                Cuerpo.Append("NOMBRE DEL CURSO: ") : Cuerpo.Append(lAccionFormativa.NOMBRE_ACCION_FORMATIVA) : Cuerpo.Append("<br/>")
                Cuerpo.Append("CODIGO: ") : Cuerpo.Append(lAccionFormativa.CODIGO_GRUPO) : Cuerpo.Append("<br/>")
                Cuerpo.Append("FECHA DE INICIO: ") : Cuerpo.Append(aEntidad.FECHA_INICIAL.ToString("dd/MM/yyyy")) : Cuerpo.Append("<br/>")
                Cuerpo.Append("FECHA DE FINALIZACION: ") : Cuerpo.Append(aEntidad.FECHA_FINAL.ToString("dd/MM/yyyy")) : Cuerpo.Append("<br/>")

                lInforme = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(aEntidad.ID_INFORME_FINAL)
                If lInforme IsNot Nothing Then
                    Cuerpo.Append("POR EL MONTO DE: ") : Cuerpo.Append(lInforme.MONTO_FACTURA.ToString("$ #,##0.00"))
                End If
                Cuerpo.Append("</body>")
                Cuerpo.Append("</html>")


            Case ProgramasFormacion.PATI_USAID, ProgramasFormacion.PATI_BM, ProgramasFormacion.PATI_2
                Cuerpo.Append("<html>")
                Cuerpo.Append("<body>")
                Cuerpo.Append("<br/><br/>")
                Cuerpo.Append("Se&ntilde;ores<br/>")
                Cuerpo.Append((New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF).NOMBRE_PROVEEDOR + "<br/>")
                Cuerpo.Append("Presente<br/><br/><br/>")
                Cuerpo.Append("Por este medio les informo que pueden enviar factura para visto bueno del siguiente curso:<br/><br/>")
                Cuerpo.Append("<table cellpadding=""5"" border=""1"" style=""font-family:Arial;font-size:small;border-style:solid""> ")
                Cuerpo.Append(" <tr style=""font-weight:bold;text-align:center;""> ")
                Cuerpo.Append("   <td>  ")
                Cuerpo.Append("   N° Orden de Compra")
                Cuerpo.Append("   </td> ")
                Cuerpo.Append("   <td>  ")
                Cuerpo.Append("   Curso Ejecutado")
                Cuerpo.Append("   </td> ")
                Cuerpo.Append("   <td>  ")
                Cuerpo.Append("   C&oacute;digo de Curso")
                Cuerpo.Append("   </td> ")
                Cuerpo.Append("   <td>  ")
                Cuerpo.Append("   Municipio, Departamento")
                Cuerpo.Append("   </td> ")
                Cuerpo.Append("   <td>  ")
                Cuerpo.Append("   Participantes Activos")
                Cuerpo.Append("   </td> ")
                Cuerpo.Append("   <td>  ")
                Cuerpo.Append("   Valor")
                Cuerpo.Append("   </td> ")
                Cuerpo.Append(" </tr> ")

                Cuerpo.Append(" <tr> ")
                Cuerpo.Append("   <td>  ")
                If listaTerminoRef IsNot Nothing AndAlso listaTerminoRef.Count > 0 Then Cuerpo.Append(listaTerminoRef(0).RESOLUCION)
                Cuerpo.Append("   </td> ")
                Cuerpo.Append("   <td>  ")
                Cuerpo.Append(lAccionFormativa.NOMBRE_ACCION_FORMATIVA)
                Cuerpo.Append("   </td> ")
                Cuerpo.Append("   <td>  ")
                Cuerpo.Append(lAccionFormativa.CODIGO_GRUPO)
                Cuerpo.Append("   </td> ")
                Cuerpo.Append("   <td>  ")
                Cuerpo.Append((New cMUNICIPIO).ObtenerMUNICIPIO(lAccionDetalle.CODIGO_DEPARTAMENTO, lAccionDetalle.CODIGO_MUNICIPIO).NOMBRE)
                Cuerpo.Append(", ")
                Cuerpo.Append((New cDEPARTAMENTO).ObtenerDEPARTAMENTO(lAccionDetalle.CODIGO_DEPARTAMENTO).NOMBRE)
                Cuerpo.Append("   </td> ")
                Cuerpo.Append("   <td  align=""center"">  ")
                Cuerpo.Append(lListaInforme(0).PARTICIPANTES_FINALES.ToString)
                Cuerpo.Append("   </td>  ")
                Cuerpo.Append("   <td>  ")
                Cuerpo.Append(lListaInforme(0).MONTO_FACTURA.ToString("$ #,##0.00"))
                Cuerpo.Append("   </td> ")
                Cuerpo.Append(" </tr> ")
                Cuerpo.Append("</table> ")
                Cuerpo.Append("<br/><br/>")

                Cuerpo.Append("<b>NOTA:</b><br/>")
                Dim lFuenteMunicipio As FUENTE_MUNICIPIO = _
                    (New cFUENTE_MUNICIPIO).ObtenerPorFUENTE_FINANCIAMIENTO_CONV_DEPARTAMENTO(lAccionDetalle.ID_FUENTE, lAccionDetalle.NO_CONVOCATORIA, lAccionDetalle.CODIGO_DEPARTAMENTO, lAccionDetalle.CODIGO_MUNICIPIO)
                If lFuenteMunicipio IsNot Nothing Then
                    Dim lPrograma As PROGRAMA_FORMACION = (New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(lAccionDetalle.ID_PROGRAMA_FORMACION)
                    If lPrograma IsNot Nothing Then Cuerpo.Append("Se&ntilde;or Proveedor para el proceso de pago del Programa " & lPrograma.NOMBRE_PROGRAMA_FORMACION & " favor tomar en cuenta los siguientes aspectos:<br/><br/>")
                    Cuerpo.Append("<b> &nbsp;&nbsp;1. La factura deber&aacute; emitirla a nombre de:</b><br/><br/>")
                    Cuerpo.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;")
                    If lPrograma IsNot Nothing Then Cuerpo.Append("- " & lPrograma.NOMBRE_PROGRAMA_FORMACION & ": ")
                    Cuerpo.Append("<b>" & lFuenteMunicipio.CODIGO_FINANCIAMIENTO & "</b><br/><br/>")
                    Cuerpo.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;")
                Else
                    Cuerpo.Append("Se&ntilde;or Proveedor para el proceso de pago del Programa PATI BANCO MUNDIAL, PATI AID Y PATI FASE II, favor tomar en cuenta los siguientes aspectos:<br/><br/>")
                    Cuerpo.Append("<b> &nbsp;&nbsp;1. La factura deber&aacute; emitirla a nombre de cada programa as&iacute;:</b><br/><br/>")
                    Cuerpo.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;")
                    Cuerpo.Append("- PATI BANCO MUNDIAL: <b>FISDL/PATI-BIRF/INSAFORP 7811-SV</b><br/><br/>")
                    Cuerpo.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;")
                    Cuerpo.Append("- PATI AID: <b>FISDL/PATI-USAID/INSAFORP 0462</b><br/><br/>")
                    Cuerpo.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;")
                    Cuerpo.Append("- PATI FASE II: <b>PROGRAMA DE APOYO TEMPORAL AL INGRESO PATI-FASE II-PACSES-FISDL/INSAFORP</b><br/><br/>")
                    Cuerpo.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;")
                End If
                Cuerpo.Append("<b>2. Emitir factura por Municipio y Curso que contenga al menos la siguiente descripci&oacute;n:</b><br/><br/>")
                Cuerpo.Append("Servicio de Capacitaci&oacute;n denominado _____________________, que se realiz&oacute; en el municipio de _____________,<br/> ")
                Cuerpo.Append("del Departamento de ______________ a ___ participantes, seg&uacute;n orden de compra N° _____________<br/><br/>")
                Cuerpo.Append("<b> &nbsp;&nbsp;3. Se recuerda adem&aacute;s lo siguiente:</b><br/><br/>")
                Cuerpo.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;")
                Cuerpo.Append("1. Deber&aacute; presentar el duplicado/cliente de la factura en el mes que se extiende, sin escritura original.<br/>")
                Cuerpo.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;")
                Cuerpo.Append("Caso contrario, el proveedor debe adjuntar fotocopia de la factura original/emisor.<br/><br/>")
                Cuerpo.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;")
                Cuerpo.Append("2. Consignar el valor de retención del 1% de IVA.<br/><br/>")
                Cuerpo.Append("Estas disposiciones serán de cumplimiento para recibir los documentos de cobro para emitir el quedan correspondiente.")
                Cuerpo.Append("</body>")
                Cuerpo.Append("</html>")
        End Select

        Return Cuerpo.ToString
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que envía un correo de Solicitud de Factura para Pago del Informe Final
    ''' </summary>
    ''' <param name="eINFORME_FINAL"></param>    
    ''' <param name="CUERPO"></param>    
    ''' <param name="USUARIO_REMITENTE"></param> 
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/12/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function EnviarSolicitudFacturaProveedor(ByVal eINFORME_FINAL As INFORME_FINAL_AF, ByVal CUERPO As String, ByVal USUARIO_REMITENTE As String, Optional ByVal ASUNTO As String = "INSAFORP - Solicitud de Factura") As Integer
        Dim lCorreosDestinatarios As New List(Of String)
        Dim CorreoUsuarioActual As String
        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(eINFORME_FINAL.ID_ACCION_FORMATIVA)
        Dim lIdPrograma As Decimal = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(eINFORME_FINAL.ID_ACCION_FORMATIVA)

        Try
            'Referencia al MembershipProvider personalizado
            Dim _mp As New cmembershipProvider
            _mp = CType(Membership.Provider, cmembershipProvider)

            'Obtener el correo electrónico del técnico asignado
            CorreoUsuarioActual = _mp.ObtenerEmailPorNombreUsuario(Utilerias.ObtenerUsuario)

            'Obtener los Roles Asoiados al Programa
            Dim listaRolesAsocPrograma As listaROL_PROGRAMA = (New cROL_PROGRAMA).ObtenerListaPorPROGRAMA_FORMACION(lIdPrograma)
            Dim lRolesAsocPrograma As New List(Of String)
            For Each lRol As ROL_PROGRAMA In listaRolesAsocPrograma
                lRolesAsocPrograma.Add(lRol.ROL_USUARIO)
            Next

            'Obtener los Usuarios Asociados al Proveedor / Centro Formación
            Dim listaUsuariosCFP As listaUSUARIO
            listaUsuariosCFP = (New cUSUARIO).ObtenerListaPorPROVEEDOR_AF(lAccionFormativa.ID_PROVEEDOR_AF)

            'Obtener los Correos de los Usuarios Asociados al Proveedor / Centro Formación y a los Roles del Programa de Formación
            If listaUsuariosCFP IsNot Nothing Then
                Dim lRolesDelUsuario As List(Of String)
                For i As Integer = 0 To listaUsuariosCFP.Count - 1
                    lRolesDelUsuario = _mp.ObtenerRoles(listaUsuariosCFP(i).USUARIO)
                    For j As Integer = 0 To lRolesDelUsuario.Count - 1
                        If lRolesAsocPrograma.Contains(lRolesDelUsuario(j)) Then
                            'Validar si en los Roles del Usuario está el Rol de Proveedor Factura
                            If lRolesDelUsuario.Exists(AddressOf EmpiezaConProveedorFacturacion) Then
                                Dim usuarioProv As cmembershipUser = _mp.ObtenerUsuario(listaUsuariosCFP(i).USUARIO)
                                If usuarioProv.IsApproved Then
                                    lCorreosDestinatarios.Add(usuarioProv.Email)
                                    If usuarioProv.EmailsAdicionales.Count > 0 Then
                                        For k As Integer = 0 To usuarioProv.EmailsAdicionales.Count - 1
                                            If Not lCorreosDestinatarios.Contains(usuarioProv.EmailsAdicionales(k)) Then
                                                lCorreosDestinatarios.Add(usuarioProv.EmailsAdicionales(k))
                                            End If
                                        Next
                                    End If
                                End If
                            End If
                            Exit For
                        End If
                    Next
                Next
            End If

            If lCorreosDestinatarios.Count > 0 Then
                Dim lCCO As New List(Of String)
                lCCO.Add(CorreoUsuarioActual)
                Return _mp.EnviarCorreo(CorreoUsuarioActual, lCorreosDestinatarios, ASUNTO, CUERPO, , lCCO, True)
            Else
                Return -1
            End If

        Catch ex As Exception
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
    ''' 	[cramos]	19/12/2012	Creado
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCuerpoCorreoDevolucionInformeFinal(ByVal aEntidad As INFORME_FINAL_AF) As String
        Dim Cuerpo As New StringBuilder
        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
        Dim lIdPrograma As Decimal = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(aEntidad.ID_ACCION_FORMATIVA)
        Dim lEntidadPrograma As PROGRAMA_FORMACION

        Cuerpo.AppendLine("INSAFORP - GERENCIA DE FORMACION INICIAL ")
        lIdPrograma = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(aEntidad.ID_ACCION_FORMATIVA)
        lEntidadPrograma = (New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(lIdPrograma)
        Cuerpo.Append(lEntidadPrograma.NOMBRE_PROGRAMA_FORMACION)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("Por este medio se le comunica que el Informe de Ejecución para el curso ")
        Cuerpo.Append("ID: ")
        Cuerpo.AppendLine(lAccionFormativa.ID_ACCION_FORMATIVA.ToString)
        Cuerpo.Append("NOMBRE: ")
        Cuerpo.AppendLine(lAccionFormativa.NOMBRE_ACCION_FORMATIVA)
        Cuerpo.Append("CODIGO: ")
        Cuerpo.AppendLine(lAccionFormativa.CODIGO_GRUPO)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("ha sido devuelto con la siguiente observacion:.")
        Cuerpo.Append(aEntidad.COMENTARIOS)

        Return Cuerpo.ToString
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que envía un correo para una Solicitud de Reprogramación
    ''' </summary>
    ''' <param name="eINFORME_FINAL"></param>    
    ''' <param name="CUERPO"></param> 
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	18/12/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function EnviarNotificacionObservacionesSolvPorCorreo(ByVal eINFORME_FINAL As INFORME_FINAL_AF, ByVal CUERPO As String) As Integer
        Try
            Dim lCorreosDestinatarios As New List(Of String)
            Dim CorreoUsuarioActual As String
            Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(eINFORME_FINAL.ID_ACCION_FORMATIVA)
            Dim lIdPrograma As Decimal = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(eINFORME_FINAL.ID_ACCION_FORMATIVA)

            'Referencia al MembershipProvider personalizado
            Dim _mp As New cmembershipProvider
            _mp = CType(Membership.Provider, cmembershipProvider)


            If lIdPrograma = ProgramasFormacion.HABIL_TECNICO_PERMANENTE Then
                'Obtener usuario asignado al Centro de Formación
                Dim usuarioAsignado As String = (New cSITIO_CAPACITACION).ObtenerTECNICO_ASIGNADO(lAccionFormativa.ID_SITIO_CAPACITACION)
                lCorreosDestinatarios.Add(_mp.ObtenerEmailPorNombreUsuario(usuarioAsignado, True))
            Else
                'Obtener usuarios asociados al Centro 
                Dim lRolesAsocPrograma As New List(Of String)
                Dim lTecnicos As List(Of cmembershipUser)

                Select Case lIdPrograma
                    Case ProgramasFormacion.PATI_BM, ProgramasFormacion.PATI_USAID, ProgramasFormacion.PATI_2
                        lRolesAsocPrograma.Add(RolDeUsuario.TecnicoGFIPATI)
                    Case ProgramasFormacion.PROYECTO_ESPECIAL
                        lRolesAsocPrograma.Add(RolDeUsuario.TecnicoPROYESPECIAL)
                End Select
                lTecnicos = _mp.ObtenerLista(lRolesAsocPrograma)
                For Each mUsuarioTecnico As cmembershipUser In lTecnicos
                    If mUsuarioTecnico.IsApproved Then
                        lCorreosDestinatarios.Add(mUsuarioTecnico.Email)
                    End If
                Next
            End If

            If lCorreosDestinatarios.Count > 0 Then
                Dim lCCO As New List(Of String)

                'Obtener el correo electrónico del usuario actual
                CorreoUsuarioActual = _mp.ObtenerEmailPorNombreUsuario(Utilerias.ObtenerUsuario)
                lCCO.Add(CorreoUsuarioActual)
                Return _mp.EnviarCorreo(CorreoUsuarioActual, lCorreosDestinatarios, _
                                        (New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(lIdPrograma).NOMBRE_PROGRAMA_FORMACION + " - Observaciones Solventadas", CUERPO, , lCCO)

            Else
                Return -1
            End If

        Catch ex As Exception
            Return -1
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que envía un correo de Observaciones para una Devolución de Informe Final
    ''' </summary>
    ''' <param name="eINFORME_FINAL"></param>    
    ''' <param name="CUERPO"></param>    
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	18/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function EnviarObservacionesInformeFinalPorCorreo(ByVal eINFORME_FINAL As INFORME_FINAL_AF, ByVal CUERPO As String, Optional ByVal ASUNTO As String = "INSAFORP - Proceso de revisión y validación de Informes de Ejecución") As Integer
        Try
            Dim lCorreosDestinatarios As New List(Of String)
            Dim CorreoUsuarioActual As String
            Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(eINFORME_FINAL.ID_ACCION_FORMATIVA)
            Dim lAccionDeta As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(eINFORME_FINAL.ID_ACCION_FORMATIVA)
            Dim lIdPrograma As Decimal = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(eINFORME_FINAL.ID_ACCION_FORMATIVA)
            Dim listaUsuariosCFP As New listaUSUARIO
            Dim lRolesAsocPrograma As New List(Of String)
            Dim lUsuarios As New List(Of cmembershipUser)

            'Referencia al MembershipProvider personalizado
            Dim _mp As New cmembershipProvider
            _mp = CType(Membership.Provider, cmembershipProvider)

            'Obtener el correo electrónico del técnico asignado
            CorreoUsuarioActual = _mp.ObtenerEmailPorNombreUsuario(Utilerias.ObtenerUsuario)

            If eINFORME_FINAL.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.SeguimientoGFI Then
                'Obtener los correos de los centros de formacion
                If lAccionDeta IsNot Nothing Then
                    Select Case lAccionDeta.ID_PROGRAMA_FORMACION
                        Case Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE
                            If lAccionFormativa.ID_SITIO_CAPACITACION = -1 Then
                                listaUsuariosCFP = (New cUSUARIO).ObtenerListaPorPROVEEDOR_AF(lAccionFormativa.ID_PROVEEDOR_AF)
                                lRolesAsocPrograma.Add(RolDeUsuario.Proveedor)
                                lRolesAsocPrograma.Add(RolDeUsuario.CentroCapacitador)
                                lRolesAsocPrograma.Add(RolDeUsuario.ProveedorPROYESPECIAL)
                            Else
                                listaUsuariosCFP = (New cUSUARIO).ObtenerListaPorSITIO_CAPACITACION(lAccionFormativa.ID_SITIO_CAPACITACION)
                                lRolesAsocPrograma.Add(RolDeUsuario.CentroCapacitador)
                            End If
                        Case Enumeradores.ProgramasFormacion.PATI_2, Enumeradores.ProgramasFormacion.PATI_BM, Enumeradores.ProgramasFormacion.PATI_USAID
                            listaUsuariosCFP = (New cUSUARIO).ObtenerListaPorPROVEEDOR_AF(lAccionFormativa.ID_PROVEEDOR_AF)
                            lRolesAsocPrograma.Add(RolDeUsuario.ProveedorPATI)
                        Case Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL
                            listaUsuariosCFP = (New cUSUARIO).ObtenerListaPorPROVEEDOR_AF(lAccionFormativa.ID_PROVEEDOR_AF)
                            lRolesAsocPrograma.Add(RolDeUsuario.ProveedorPROYESPECIAL)
                    End Select

                    If listaUsuariosCFP IsNot Nothing Then
                        Dim lRolesDelUsuario As List(Of String)
                        For i As Integer = 0 To listaUsuariosCFP.Count - 1
                            lRolesDelUsuario = _mp.ObtenerRoles(listaUsuariosCFP(i).USUARIO)
                            For j As Integer = 0 To lRolesDelUsuario.Count - 1
                                If lRolesAsocPrograma.Contains(lRolesDelUsuario(j)) Then
                                    If Not (lRolesDelUsuario.Exists(AddressOf EmpiezaConProveedorFacturacion) AndAlso lRolesDelUsuario.Count = 1) Then
                                        Dim usuarioProv As cmembershipUser = _mp.ObtenerUsuario(listaUsuariosCFP(i).USUARIO)
                                        If usuarioProv.IsApproved Then
                                            lCorreosDestinatarios.Add(usuarioProv.Email)
                                            If usuarioProv.EmailsAdicionales.Count > 0 Then
                                                For k As Integer = 0 To usuarioProv.EmailsAdicionales.Count - 1
                                                    If Not lCorreosDestinatarios.Contains(usuarioProv.EmailsAdicionales(k)) Then
                                                        lCorreosDestinatarios.Add(usuarioProv.EmailsAdicionales(k))
                                                    End If
                                                Next
                                            End If
                                        End If
                                    End If
                                    Exit For
                                End If
                            Next
                        Next
                    End If
                End If

                'Obtener los correos de los usuarios activos con rol SoporteGFI
                lRolesAsocPrograma = New List(Of String)
                lRolesAsocPrograma.Add(RolDeUsuario.SoporteGFI)
                lUsuarios = _mp.ObtenerLista(lRolesAsocPrograma)
                If lUsuarios IsNot Nothing AndAlso lUsuarios.Count > 0 Then
                    For Each mUsuario As cmembershipUser In lUsuarios
                        If mUsuario.IsApproved Then
                            lCorreosDestinatarios.Add(mUsuario.Email)
                        End If
                    Next
                End If
            ElseIf eINFORME_FINAL.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoaCA Then
                'Obtener los correos de los usuarios activos con rol CA Gestion
                lRolesAsocPrograma.Add(RolDeUsuario.CAGestion)
                lUsuarios = _mp.ObtenerLista(lRolesAsocPrograma)
                If lUsuarios IsNot Nothing AndAlso lUsuarios.Count > 0 Then
                    For Each mUsuario As cmembershipUser In lUsuarios
                        If mUsuario.IsApproved Then
                            lCorreosDestinatarios.Add(mUsuario.Email)
                        End If
                    Next
                End If
            Else
                'Obtener los correos de los usuarios activos por proveedor o centro de formación 
                If lAccionDeta IsNot Nothing Then
                    Select Case lAccionDeta.ID_PROGRAMA_FORMACION
                        Case Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE
                            If lAccionFormativa.ID_SITIO_CAPACITACION = -1 Then
                                listaUsuariosCFP = (New cUSUARIO).ObtenerListaPorPROVEEDOR_AF(lAccionFormativa.ID_PROVEEDOR_AF)
                                lRolesAsocPrograma.Add(RolDeUsuario.Proveedor)
                                lRolesAsocPrograma.Add(RolDeUsuario.CentroCapacitador)
                                lRolesAsocPrograma.Add(RolDeUsuario.ProveedorPROYESPECIAL)
                            Else
                                listaUsuariosCFP = (New cUSUARIO).ObtenerListaPorSITIO_CAPACITACION(lAccionFormativa.ID_SITIO_CAPACITACION)
                                lRolesAsocPrograma.Add(RolDeUsuario.CentroCapacitador)
                            End If
                        Case Enumeradores.ProgramasFormacion.PATI_2, Enumeradores.ProgramasFormacion.PATI_BM, Enumeradores.ProgramasFormacion.PATI_USAID
                            listaUsuariosCFP = (New cUSUARIO).ObtenerListaPorPROVEEDOR_AF(lAccionFormativa.ID_PROVEEDOR_AF)
                            lRolesAsocPrograma.Add(RolDeUsuario.ProveedorPATI)
                        Case Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL
                            listaUsuariosCFP = (New cUSUARIO).ObtenerListaPorPROVEEDOR_AF(lAccionFormativa.ID_PROVEEDOR_AF)
                            lRolesAsocPrograma.Add(RolDeUsuario.ProveedorPROYESPECIAL)
                    End Select

                    If listaUsuariosCFP IsNot Nothing Then
                        Dim lRolesDelUsuario As List(Of String)
                        For i As Integer = 0 To listaUsuariosCFP.Count - 1
                            lRolesDelUsuario = _mp.ObtenerRoles(listaUsuariosCFP(i).USUARIO)
                            If lRolesDelUsuario IsNot Nothing AndAlso lRolesDelUsuario.Count > 0 Then
                                For j As Integer = 0 To lRolesDelUsuario.Count - 1
                                    If lRolesAsocPrograma.Contains(lRolesDelUsuario(j)) Then
                                        If Not (lRolesDelUsuario.Exists(AddressOf EmpiezaConProveedorFacturacion) AndAlso lRolesDelUsuario.Count = 1) Then
                                            Dim usuarioProv As cmembershipUser = _mp.ObtenerUsuario(listaUsuariosCFP(i).USUARIO)
                                            If usuarioProv IsNot Nothing AndAlso usuarioProv.IsApproved Then
                                                lCorreosDestinatarios.Add(usuarioProv.Email)
                                                If usuarioProv.EmailsAdicionales.Count > 0 Then
                                                    For k As Integer = 0 To usuarioProv.EmailsAdicionales.Count - 1
                                                        If Not lCorreosDestinatarios.Contains(usuarioProv.EmailsAdicionales(k)) Then
                                                            lCorreosDestinatarios.Add(usuarioProv.EmailsAdicionales(k))
                                                        End If
                                                    Next
                                                End If
                                            End If
                                        End If
                                        Exit For
                                    End If
                                Next
                            End If
                        Next
                    End If
                End If
            End If

            If lCorreosDestinatarios.Count > 0 Then
                Dim lCCO As New List(Of String)
                lCCO.Add(CorreoUsuarioActual)
                Return _mp.EnviarCorreo(CorreoUsuarioActual, lCorreosDestinatarios, ASUNTO, CUERPO, , lCCO, True)
            Else
                Return -1
            End If

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
    ''' 	[cramos]	18/12/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCuerpoCorreoObservacionesSolvInformeFinal(ByVal aEntidad As INFORME_FINAL_AF) As String
        Dim Cuerpo As New StringBuilder
        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
        Dim lIdPrograma As Decimal = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(aEntidad.ID_ACCION_FORMATIVA)

        Cuerpo.AppendLine((New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF).NOMBRE_PROVEEDOR)
        If lAccionFormativa.ID_SITIO_CAPACITACION > -1 Then
            Cuerpo.AppendLine((New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(lAccionFormativa.ID_SITIO_CAPACITACION).NOMBRE_SITIO)
        End If
        Cuerpo.Append((New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(lIdPrograma).NOMBRE_PROGRAMA_FORMACION)
        Cuerpo.Append(" ")
        Cuerpo.AppendLine(lAccionFormativa.ID_EJERCICIO)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("Por este medio se le comunica que las Observaciones hechas al Informe para el curso ")
        Cuerpo.Append("ID: ")
        Cuerpo.AppendLine(aEntidad.ID_ACCION_FORMATIVA.ToString)
        Cuerpo.Append("NOMBRE: ")
        Cuerpo.AppendLine(lAccionFormativa.NOMBRE_ACCION_FORMATIVA)
        Cuerpo.Append("CODIGO: ")
        Cuerpo.AppendLine(lAccionFormativa.CODIGO_GRUPO)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("han sido solventadas.")

        Return Cuerpo.ToString
    End Function

    Public Function ObtenerCuerpoCorreoInformeProcesoBolpros(ByVal aEntidad As INFORME_FINAL_AF) As String
        Dim Cuerpo As New StringBuilder
        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
        Dim lIdPrograma As Decimal = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(aEntidad.ID_ACCION_FORMATIVA)

        Cuerpo.AppendLine((New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF).NOMBRE_PROVEEDOR)
        If lAccionFormativa.ID_SITIO_CAPACITACION > -1 Then
            Cuerpo.AppendLine((New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(lAccionFormativa.ID_SITIO_CAPACITACION).NOMBRE_SITIO)
        End If
        Cuerpo.Append((New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(lIdPrograma).NOMBRE_PROGRAMA_FORMACION)
        Cuerpo.Append(" ")
        Cuerpo.AppendLine(lAccionFormativa.ID_EJERCICIO)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("Por este medio se le comunica que el informe para el curso ")
        Cuerpo.Append("ID: ")
        Cuerpo.AppendLine(aEntidad.ID_ACCION_FORMATIVA.ToString)
        Cuerpo.Append("NOMBRE: ")
        Cuerpo.AppendLine(lAccionFormativa.NOMBRE_ACCION_FORMATIVA)
        Cuerpo.Append("CODIGO: ")
        Cuerpo.AppendLine(lAccionFormativa.CODIGO_GRUPO)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("ha sido validado y se encuentra en Proceso relacionado a Bolpros. Por favor presentar Orden de Entrega.")

        Return Cuerpo.ToString
    End Function

    Public Function ObtenerCuerpoCorreoInformeDevueltoCA(ByVal aEntidad As INFORME_FINAL_AF) As String
        Dim Cuerpo As New StringBuilder
        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
        Dim lIdPrograma As Decimal = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(aEntidad.ID_ACCION_FORMATIVA)

        Cuerpo.AppendLine((New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF).NOMBRE_PROVEEDOR)
        If lAccionFormativa.ID_SITIO_CAPACITACION > -1 Then
            Cuerpo.AppendLine((New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(lAccionFormativa.ID_SITIO_CAPACITACION).NOMBRE_SITIO)
        End If
        Cuerpo.Append((New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(lIdPrograma).NOMBRE_PROGRAMA_FORMACION)
        Cuerpo.Append(" ")
        Cuerpo.AppendLine(lAccionFormativa.ID_EJERCICIO)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("Por este medio se le comunica que el informe para el curso ")
        Cuerpo.Append("ID: ")
        Cuerpo.AppendLine(aEntidad.ID_ACCION_FORMATIVA.ToString)
        Cuerpo.Append("NOMBRE: ")
        Cuerpo.AppendLine(lAccionFormativa.NOMBRE_ACCION_FORMATIVA)
        Cuerpo.Append("CODIGO: ")
        Cuerpo.AppendLine(lAccionFormativa.CODIGO_GRUPO)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("se ha devuelto al Centro de Atencion para su revision.")

        Return Cuerpo.ToString
    End Function

    Public Function ObtenerCuerpoCorreoInformeSeguimientoGFI(ByVal aEntidad As INFORME_FINAL_AF) As String
        Dim Cuerpo As New StringBuilder
        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
        Dim lIdPrograma As Decimal = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(aEntidad.ID_ACCION_FORMATIVA)

        Cuerpo.AppendLine((New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF).NOMBRE_PROVEEDOR)
        If lAccionFormativa.ID_SITIO_CAPACITACION > -1 Then
            Cuerpo.AppendLine((New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(lAccionFormativa.ID_SITIO_CAPACITACION).NOMBRE_SITIO)
        End If
        Cuerpo.Append((New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(lIdPrograma).NOMBRE_PROGRAMA_FORMACION)
        Cuerpo.Append(" ")
        Cuerpo.AppendLine(lAccionFormativa.ID_EJERCICIO)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("Por este medio se le comunica que el informe para el curso ")
        Cuerpo.Append("ID: ")
        Cuerpo.AppendLine(aEntidad.ID_ACCION_FORMATIVA.ToString)
        Cuerpo.Append("NOMBRE: ")
        Cuerpo.AppendLine(lAccionFormativa.NOMBRE_ACCION_FORMATIVA)
        Cuerpo.Append("CODIGO: ")
        Cuerpo.AppendLine(lAccionFormativa.CODIGO_GRUPO)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("ha sido enviado para seguimiento en la Gerencia de Formación Inicial con la observación siguiente:")
        Cuerpo.AppendLine(aEntidad.COMENTARIOS)

        Return Cuerpo.ToString
    End Function

    Public Function ObtenerCuerpoCorreoOrdenValidada(ByVal aEntidad As INFORME_FINAL_AF) As String
        Dim Cuerpo As New StringBuilder
        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
        Dim lIdPrograma As Decimal = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(aEntidad.ID_ACCION_FORMATIVA)

        Cuerpo.AppendLine((New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF).NOMBRE_PROVEEDOR)
        If lAccionFormativa.ID_SITIO_CAPACITACION > -1 Then
            Cuerpo.AppendLine((New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(lAccionFormativa.ID_SITIO_CAPACITACION).NOMBRE_SITIO)
        End If
        Cuerpo.Append((New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(lIdPrograma).NOMBRE_PROGRAMA_FORMACION)
        Cuerpo.Append(" ")
        Cuerpo.AppendLine(lAccionFormativa.ID_EJERCICIO)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("Por este medio se le comunica que la Orden de entrega de mercado bursatil para el curso ")
        Cuerpo.Append("ID: ")
        Cuerpo.AppendLine(aEntidad.ID_ACCION_FORMATIVA.ToString)
        Cuerpo.Append("NOMBRE: ")
        Cuerpo.AppendLine(lAccionFormativa.NOMBRE_ACCION_FORMATIVA)
        Cuerpo.Append("CODIGO: ")
        Cuerpo.AppendLine(lAccionFormativa.CODIGO_GRUPO)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("ha sido validada y se requiere que gestione la factura.")

        Return Cuerpo.ToString
    End Function

    Public Function ObtenerCuerpoCorreoOrdenEntregaObservada(ByVal aEntidad As INFORME_FINAL_AF) As String
        Dim Cuerpo As New StringBuilder
        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
        Dim lIdPrograma As Decimal = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(aEntidad.ID_ACCION_FORMATIVA)

        Cuerpo.AppendLine((New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF).NOMBRE_PROVEEDOR)
        If lAccionFormativa.ID_SITIO_CAPACITACION > -1 Then
            Cuerpo.AppendLine((New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(lAccionFormativa.ID_SITIO_CAPACITACION).NOMBRE_SITIO)
        End If
        Cuerpo.Append((New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(lIdPrograma).NOMBRE_PROGRAMA_FORMACION)
        Cuerpo.Append(" ")
        Cuerpo.AppendLine(lAccionFormativa.ID_EJERCICIO)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("Por este medio se le comunica que la Orden de entrega de mercado bursatil para el curso ")
        Cuerpo.Append("ID: ")
        Cuerpo.AppendLine(aEntidad.ID_ACCION_FORMATIVA.ToString)
        Cuerpo.Append("NOMBRE: ")
        Cuerpo.AppendLine(lAccionFormativa.NOMBRE_ACCION_FORMATIVA)
        Cuerpo.Append("CODIGO: ")
        Cuerpo.AppendLine(lAccionFormativa.CODIGO_GRUPO)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("ha sido observada.")

        Return Cuerpo.ToString
    End Function

    Public Function ObtenerCuerpoCorreoFacturaObservada(ByVal aEntidad As INFORME_FINAL_AF) As String
        Dim Cuerpo As New StringBuilder
        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
        Dim lIdPrograma As Decimal = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(aEntidad.ID_ACCION_FORMATIVA)

        Cuerpo.AppendLine((New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF).NOMBRE_PROVEEDOR)
        If lAccionFormativa.ID_SITIO_CAPACITACION > -1 Then
            Cuerpo.AppendLine((New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(lAccionFormativa.ID_SITIO_CAPACITACION).NOMBRE_SITIO)
        End If
        Cuerpo.Append((New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(lIdPrograma).NOMBRE_PROGRAMA_FORMACION)
        Cuerpo.Append(" ")
        Cuerpo.AppendLine(lAccionFormativa.ID_EJERCICIO)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("Por este medio se le comunica que la Factura de mercado bursatil para el curso ")
        Cuerpo.Append("ID: ")
        Cuerpo.AppendLine(aEntidad.ID_ACCION_FORMATIVA.ToString)
        Cuerpo.Append("NOMBRE: ")
        Cuerpo.AppendLine(lAccionFormativa.NOMBRE_ACCION_FORMATIVA)
        Cuerpo.Append("CODIGO: ")
        Cuerpo.AppendLine(lAccionFormativa.CODIGO_GRUPO)
        Cuerpo.AppendLine("")
        Cuerpo.AppendLine("ha sido observada.")

        Return Cuerpo.ToString
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla INFORME_FINAL_AF.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMARTIVA">Indica la Acción Formativa a la que pertenece el Informe</param>
    ''' <param name="FECHA_REPORTADA">Indica la fecha que se encuentra en el período reportado del Informe</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	30/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerINFORME_FINAL_AFPorAccionFormativaFecha(ByVal ID_ACCION_FORMARTIVA As Decimal, ByVal FECHA_REPORTADA As Date) As INFORME_FINAL_AF
        Try
            Dim lEntidad As INFORME_FINAL_AF
            lEntidad = mDb.ObtenerINFORME_FINAL_AFPorAccionFormativaFecha(ID_ACCION_FORMARTIVA, FECHA_REPORTADA)
            Return lEntidad
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
    ''' 	[cramos]	13/08/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal CODIGO_GRUPO As String, ByVal ID_EJERCICIO As String, ByVal listaID_ESTADO_INFORME As List(Of Decimal), ByVal listaID_PROGRAMA_FORMACION As List(Of Decimal), ByVal ID_CONTRATO As Decimal, ByVal NUM_LICITACION As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF
        Try
            Return mDb.ObtenerListaPorCriteriosPeriodo(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, CODIGO_GRUPO, ID_EJERCICIO, listaID_ESTADO_INFORME, listaID_PROGRAMA_FORMACION, ID_CONTRATO, NUM_LICITACION, asColumnaOrden, asTipoOrden)
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
    ''' 	[cramos]	17/12/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriteriosRoles(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal CODIGO_GRUPO As String, ByVal ID_EJERCICIO As String, ByVal listaROLES As List(Of String), ByVal listaID_ESTADO_INFORME As List(Of Decimal), Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF
        Try
            Dim lListaInformes As listaINFORME_FINAL_AF
            Dim lListaResultado As New listaINFORME_FINAL_AF
            Dim lUsuario As USUARIO = (New cUSUARIO).ObtenerUSUARIO(Utilerias.ObtenerUsuario)
            Dim listaID_PROGRAMA_FORMACION As New List(Of Decimal)
            Dim listaProgramasPorRol As New listaPROGRAMA_FORMACION

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
                listaID_PROGRAMA_FORMACION = Nothing
            Else
                listaProgramasPorRol = (New cPROGRAMA_FORMACION).ObtenerListaPorROLES(listaROLES)
                If listaProgramasPorRol IsNot Nothing AndAlso listaProgramasPorRol.Count > 0 Then
                    For i As Integer = 0 To listaProgramasPorRol.Count - 1
                        listaID_PROGRAMA_FORMACION.Add(listaProgramasPorRol(i).ID_PROGRAMA_FORMACION)
                    Next
                End If
            End If


            'Obtener Lista de Informes por Proveedor, Programa de Formación
            lListaInformes = mDb.ObtenerListaPorCriteriosPeriodo(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, CODIGO_GRUPO, ID_EJERCICIO, listaID_ESTADO_INFORME, listaID_PROGRAMA_FORMACION, -1, "", asColumnaOrden, asTipoOrden)

            If lListaInformes IsNot Nothing AndAlso lListaInformes.Count > 0 Then
                For i As Integer = 0 To lListaInformes.Count - 1
                    Dim lAccionFormativa As ACCION_FORMATIVA = _
                        (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lListaInformes(i).ID_ACCION_FORMATIVA)
                    Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = _
                        (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lListaInformes(i).ID_ACCION_FORMATIVA)

                    If lAccionDetalle.ID_PROGRAMA_FORMACION = ProgramasFormacion.HABIL_TECNICO_PERMANENTE Then
                        Select Case lListaInformes(i).ID_ESTADO_INFORME
                            Case EstadoInformeFinal.FacturaSolicitadaProveedor AndAlso listaROLES.Contains(RolDeUsuario.ProveedorFacturacionHTP)
                                lListaResultado.Add(lListaInformes(i))
                            Case Else
                                Select Case True
                                    Case listaROLES.Contains(RolDeUsuario.Proveedor) AndAlso lUsuario.ID_PROVEEDOR_AF = lAccionFormativa.ID_PROVEEDOR_AF
                                        lListaResultado.Add(lListaInformes(i))
                                    Case listaROLES.Contains(RolDeUsuario.CentroCapacitador) AndAlso (lUsuario.ID_SITIO_CAPACITACION = lAccionFormativa.ID_SITIO_CAPACITACION OrElse lAccionFormativa.ID_SITIO_CAPACITACION = -1)
                                        lListaResultado.Add(lListaInformes(i))
                                    Case listaROLES.Contains(RolDeUsuario.Administrador), _
                                        listaROLES.Contains(RolDeUsuario.GerenteGFI), _
                                        listaROLES.Contains(RolDeUsuario.CoordinadorGFI), _
                                        listaROLES.Contains(RolDeUsuario.SoporteGFI), _
                                        listaROLES.Contains(RolDeUsuario.TecnicoGFI), _
                                        listaROLES.Contains(RolDeUsuario.AsistenteGFI), _
                                        listaROLES.Contains(RolDeUsuario.CAGestion), _
                                        listaROLES.Contains(RolDeUsuario.CARevision), _
                                        listaROLES.Contains(RolDeUsuario.CARecepcion)
                                        lListaResultado.Add(lListaInformes(i))
                                End Select
                        End Select
                    Else
                        Select Case lListaInformes(i).ID_ESTADO_INFORME
                            Case EstadoInformeFinal.FacturaSolicitadaProveedor AndAlso listaROLES.Exists(AddressOf EmpiezaConProveedorFacturacion)
                                lListaResultado.Add(lListaInformes(i))
                            Case Else
                                lListaResultado.Add(lListaInformes(i))
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

    Private Shared Function EmpiezaConProveedorFacturacion(ByVal s As String) As Boolean
        Return s.StartsWith("ProveedorFacturacion")
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	06/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorInformeFacturar(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF
        Try
            Return mDb.ObtenerListaPorInformeFacturar(ID_PROGRAMA_FORMACION, ID_PROVEEDOR_AF, asColumnaOrden, asTipoOrden)
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
    ''' 	[cramos]	29/05/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaFacturarContratoItemBolpros(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal ID_CONTRATO As Decimal, ByVal NUM_ITEM As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF
        Try
            Return mDb.ObtenerListaFacturarContratoItemBolpros(ID_PROGRAMA_FORMACION, ID_CONTRATO, NUM_ITEM, asColumnaOrden, asTipoOrden)
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
    ''' 	[cramos]	07/09/2012	Created
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
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros ID_ACCION_FORMATIVA y ID_ESTADO_INFORME.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <param name="ID_ESTADO_INFORME"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/12/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorACCION_FORMATIVA_ESTADO_INFORME(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_ESTADO_INFORME As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaINFORME_FINAL_AF
        Try
            Return mDb.ObtenerListaPorACCION_FORMATIVA_ESTADO_INFORME(ID_ACCION_FORMATIVA, ID_ESTADO_INFORME, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla INFORME_FINAL_AF que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_INFORME_FINAL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarINFORME_FINAL_AF(ByVal ID_INFORME_FINAL As Decimal) As Integer
        Try
            mEntidad.ID_INFORME_FINAL = ID_INFORME_FINAL
            Return Me.EliminarINFORME_FINAL_AF(mEntidad, TipoConcurrencia.Pesimistica)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla INFORME_FINAL_AF que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarINFORME_FINAL_AF(ByVal aEntidad As INFORME_FINAL_AF, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            'Eliminar si el informe esta emitido
            Dim lEntidad As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(aEntidad.ID_INFORME_FINAL)
            If lEntidad IsNot Nothing Then
                If lEntidad.ID_ESTADO_INFORME = EstadoInformeFinal.Emitido Then
                    Dim lDetalleInforme As listaINFORME_FINAL_DET = (New cINFORME_FINAL_DET).ObtenerListaPorINFORME_FINAL_AF(lEntidad.ID_INFORME_FINAL)
                    Dim lInformesHistorico As listaINFORME_FINAL_AF_HIS = (New cINFORME_FINAL_AF_HIS).ObtenerListaPorINFORME_FINAL_AF(lEntidad.ID_INFORME_FINAL)
                    Dim bInformeDet As New cINFORME_FINAL_DET
                    Dim bInformeHist As New cINFORME_FINAL_AF_HIS

                    If lDetalleInforme IsNot Nothing Then
                        For i As Integer = 0 To lDetalleInforme.Count - 1
                            bInformeDet.EliminarINFORME_FINAL_DET(lDetalleInforme(i).ID_INFORME_FINAL_DET)
                        Next
                    End If
                    If lInformesHistorico IsNot Nothing Then
                        For i As Integer = 0 To lInformesHistorico.Count - 1
                            bInformeHist.EliminarINFORME_FINAL_AF_HIS(lInformesHistorico(i).ID_INFORME_FINAL_HIS)
                        Next
                    End If
                Else
                    sError = "Informe debe estar Emitido para eliminarse"
                    Return -1
                End If
            Else
                sError = "Informe no existe en el sistema"
                Return -1
            End If

            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class



