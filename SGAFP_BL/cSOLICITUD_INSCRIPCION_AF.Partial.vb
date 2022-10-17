Imports System
Imports SGAFP.EL
Imports SGAFP.BL
Imports SGAFP.DL
Imports System.Text
Imports SGAFP.EL.Enumeradores

Partial Class cSOLICITUD_INSCRIPCION_AF

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro que recibe como parámetro.
    ''' </summary>
    ''' <remarks>Se reciben los parametros uno a uno para la entidad 
    ''' y son asignados a una entidad y se ejecuta el Metodo Actualizar
    ''' o Agregar mandando la entidad de parametro.</remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function AgregarSOLICITUD_INSCRIPCION_AF(ByVal ID_SOLICITUD As Decimal, ByVal FECHA_PRESENTACION As DateTime, ByVal ID_PARTICIPANTE As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal DUI As String, ByVal TIPO_DOCTO As Decimal, ByVal NUM_DOCTO As String, ByVal NIT As String, ByVal ISSS As String, ByVal ID_TIPO_SOLICITUD As Decimal, ByVal ID_PAIS As Decimal, ByVal DEPARTAMENTO_NAC As String, ByVal MUNICIPIO_NAC As String, ByVal FECHA_NACIMIENTO As DateTime, ByVal GENERO As String, ByVal EDAD As Decimal, ByVal MIEMBROS_GRUPO_FAMILIAR As Decimal, ByVal ID_ESTADO_CIVIL As Decimal, ByVal ES_JEFE_HOGAR As Decimal, ByVal TIENE_HIJOS As Decimal, ByVal NO_DE_HIJOS As Decimal, ByVal SE_DEDICA_ALGUNA_PROFESION As Decimal, ByVal PROFESION_OFICIO As String, ByVal DIRECCION As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal TELEFONO As String, ByVal MOVIL As String, ByVal EMAIL As String, ByVal CON_DISCAPACIDAD As Decimal, ByVal DISC_OTRA As String, ByVal ID_LEE_ESCRIBE As Decimal, ByVal ID_NIVEL_ACADEMICO As Decimal, ByVal OTRA_EDUCACION_FORMAL As String, ByVal TITULO_CERTIFICADO_OBTENIDO As String, ByVal ESTUDIA_ACTUALMENTE As Decimal, ByVal ID_TIEMPO_DEJO_ESTUDIAR As Decimal, ByVal RECIBIO_CURSO_ANTERIOR As String, ByVal BENEF_PROM_EMP_ACT As Decimal, ByVal BENEF_OBT_EMPLEO As Decimal, ByVal BENEF_OBT_ING_EXTRA As Decimal, ByVal BENEF_CAMB_EMP_X_CURSO As Decimal, ByVal BENEF_TRAB_CTA_PROPIA As Decimal, ByVal BENEF_OTRO As String, ByVal RAZON_NO_BENEFICIO As String, ByVal OCUACT_TRABAJA As Decimal, ByVal OCUACT_ESTUDIA As Decimal, ByVal OCUACT_DESOCUPADO As Decimal, ByVal OCUACT_OFICIO_HOGAR As Decimal, ByVal OCUACT_BUSCA_TRABAJO As Decimal, ByVal OCUACT_OTRA As String, ByVal ID_TIPO_EMPLEO As Decimal, ByVal TRABAJO_ANTERIOR As String, ByVal RECIBE_INGRESOS As Decimal, ByVal MANERA_OBT_ING_TRABAJO As Decimal, ByVal MANERA_OBT_ING_AYUDA_FAM As Decimal, ByVal MANERA_OBT_ING_REMESA As Decimal, ByVal MANERA_OBT_ING_PENSION As Decimal, ByVal MANERA_OBT_ING_OTRO As String, ByVal EXPFOR_PROMOCION_EMPLEO As Decimal, ByVal EXPFOR_CAMBIAR_EMPLEO As Decimal, ByVal EXPFOR_OBTENER_EMPLEO As Decimal, ByVal EXPFOR_TRABAJAR_CTA_PROPIA As Decimal, ByVal EXPFOR_INGRESOS_EXTRAS As Decimal, ByVal EXPFOR_NINGUNO As Decimal, ByVal EXPFOR_OTRO As String, ByVal CURSO_REL_TRAB_ACTUAL As Decimal, ByVal CURSO_REL_TRAB_NUEVO As Decimal, ByVal NOMBRE_REFERENCIA As String, ByVal ID_REFERENCIA As Decimal, ByVal DIRECCION_REFERENCIA As String, ByVal DEPARTAMENTO_REFERENCIA As String, ByVal MUNICIPIO_REFERENCIA As String, ByVal TELEFONO_REFERENCIA As String, ByVal MOVIL_REFERENCIA As String, ByVal EMAIL_REFERENCIA As String, ByVal SUGERENCIAS As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime) As Integer
        Try
            Dim lEntidad As New SOLICITUD_INSCRIPCION_AF

            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.FECHA_PRESENTACION = FECHA_PRESENTACION
            lEntidad.ID_PARTICIPANTE = ID_PARTICIPANTE
            lEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            lEntidad.ID_ESTADO_SOLICITUD = ID_ESTADO_SOLICITUD
            lEntidad.NOMBRES = NOMBRES
            lEntidad.APELLIDOS = APELLIDOS
            lEntidad.DUI = DUI
            lEntidad.TIPO_DOCTO = TIPO_DOCTO
            lEntidad.NUM_DOCTO = NUM_DOCTO
            lEntidad.NIT = NIT
            lEntidad.ISSS = ISSS
            lEntidad.ID_TIPO_SOLICITUD = ID_TIPO_SOLICITUD
            lEntidad.ID_PAIS = ID_PAIS
            lEntidad.DEPARTAMENTO_NAC = DEPARTAMENTO_NAC
            lEntidad.MUNICIPIO_NAC = MUNICIPIO_NAC
            lEntidad.FECHA_NACIMIENTO = FECHA_NACIMIENTO
            lEntidad.GENERO = GENERO

            lEntidad.EDAD = Utilerias.CalcularEdad(FECHA_NACIMIENTO, Now)

            lEntidad.MIEMBROS_GRUPO_FAMILIAR = MIEMBROS_GRUPO_FAMILIAR
            lEntidad.ID_ESTADO_CIVIL = ID_ESTADO_CIVIL
            lEntidad.ES_JEFE_HOGAR = ES_JEFE_HOGAR
            lEntidad.TIENE_HIJOS = TIENE_HIJOS
            lEntidad.NO_DE_HIJOS = NO_DE_HIJOS
            lEntidad.SE_DEDICA_ALGUNA_PROFESION = SE_DEDICA_ALGUNA_PROFESION
            lEntidad.PROFESION_OFICIO = PROFESION_OFICIO
            lEntidad.DIRECCION = DIRECCION
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.TELEFONO = TELEFONO
            lEntidad.MOVIL = MOVIL
            lEntidad.EMAIL = EMAIL
            lEntidad.CON_DISCAPACIDAD = CON_DISCAPACIDAD
            lEntidad.DISC_OTRA = DISC_OTRA
            lEntidad.ID_LEE_ESCRIBE = ID_LEE_ESCRIBE
            lEntidad.ID_NIVEL_ACADEMICO = ID_NIVEL_ACADEMICO
            lEntidad.OTRA_EDUCACION_FORMAL = OTRA_EDUCACION_FORMAL
            lEntidad.TITULO_CERTIFICADO_OBTENIDO = TITULO_CERTIFICADO_OBTENIDO
            lEntidad.ESTUDIA_ACTUALMENTE = ESTUDIA_ACTUALMENTE
            lEntidad.ID_TIEMPO_DEJO_ESTUDIAR = ID_TIEMPO_DEJO_ESTUDIAR
            lEntidad.RECIBIO_CURSO_ANTERIOR = RECIBIO_CURSO_ANTERIOR
            lEntidad.BENEF_PROM_EMP_ACT = BENEF_PROM_EMP_ACT
            lEntidad.BENEF_OBT_EMPLEO = BENEF_OBT_EMPLEO
            lEntidad.BENEF_OBT_ING_EXTRA = BENEF_OBT_ING_EXTRA
            lEntidad.BENEF_CAMB_EMP_X_CURSO = BENEF_CAMB_EMP_X_CURSO
            lEntidad.BENEF_TRAB_CTA_PROPIA = BENEF_TRAB_CTA_PROPIA
            lEntidad.BENEF_OTRO = BENEF_OTRO
            lEntidad.RAZON_NO_BENEFICIO = RAZON_NO_BENEFICIO
            lEntidad.OCUACT_TRABAJA = OCUACT_TRABAJA
            lEntidad.OCUACT_ESTUDIA = OCUACT_ESTUDIA
            lEntidad.OCUACT_DESOCUPADO = OCUACT_DESOCUPADO
            lEntidad.OCUACT_OFICIO_HOGAR = OCUACT_OFICIO_HOGAR
            lEntidad.OCUACT_BUSCA_TRABAJO = OCUACT_BUSCA_TRABAJO
            lEntidad.OCUACT_OTRA = OCUACT_OTRA
            lEntidad.ID_TIPO_EMPLEO = ID_TIPO_EMPLEO
            lEntidad.TRABAJO_ANTERIOR = TRABAJO_ANTERIOR
            lEntidad.RECIBE_INGRESOS = RECIBE_INGRESOS
            lEntidad.MANERA_OBT_ING_TRABAJO = MANERA_OBT_ING_TRABAJO
            lEntidad.MANERA_OBT_ING_AYUDA_FAM = MANERA_OBT_ING_AYUDA_FAM
            lEntidad.MANERA_OBT_ING_REMESA = MANERA_OBT_ING_REMESA
            lEntidad.MANERA_OBT_ING_PENSION = MANERA_OBT_ING_PENSION
            lEntidad.MANERA_OBT_ING_OTRO = MANERA_OBT_ING_OTRO
            lEntidad.EXPFOR_PROMOCION_EMPLEO = EXPFOR_PROMOCION_EMPLEO
            lEntidad.EXPFOR_CAMBIAR_EMPLEO = EXPFOR_CAMBIAR_EMPLEO
            lEntidad.EXPFOR_OBTENER_EMPLEO = EXPFOR_OBTENER_EMPLEO
            lEntidad.EXPFOR_TRABAJAR_CTA_PROPIA = EXPFOR_TRABAJAR_CTA_PROPIA
            lEntidad.EXPFOR_INGRESOS_EXTRAS = EXPFOR_INGRESOS_EXTRAS
            lEntidad.EXPFOR_NINGUNO = EXPFOR_NINGUNO
            lEntidad.EXPFOR_OTRO = EXPFOR_OTRO
            lEntidad.CURSO_REL_TRAB_ACTUAL = CURSO_REL_TRAB_ACTUAL
            lEntidad.CURSO_REL_TRAB_NUEVO = CURSO_REL_TRAB_NUEVO
            lEntidad.NOMBRE_REFERENCIA = NOMBRE_REFERENCIA
            lEntidad.ID_REFERENCIA = ID_REFERENCIA
            lEntidad.DIRECCION_REFERENCIA = DIRECCION_REFERENCIA
            lEntidad.DEPARTAMENTO_REFERENCIA = DEPARTAMENTO_REFERENCIA
            lEntidad.MUNICIPIO_REFERENCIA = MUNICIPIO_REFERENCIA
            lEntidad.TELEFONO_REFERENCIA = TELEFONO_REFERENCIA
            lEntidad.MOVIL_REFERENCIA = MOVIL_REFERENCIA
            lEntidad.EMAIL_REFERENCIA = EMAIL_REFERENCIA
            lEntidad.SUGERENCIAS = SUGERENCIAS
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE

            Dim liRet As Integer = Me.ActualizarSOLICITUD_INSCRIPCION_AF(lEntidad)

            ID_SOLICITUD = lEntidad.ID_SOLICITUD
            Return (liRet = 1)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve el numero de Solicitudes pendientes de 
    ''' Aprobar/Rechazar/En Espera de un Curso Especifico
    ''' </summary>
    ''' <remarks></remarks>
    ''' <history>
    ''' 	[ecarias]	11/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCantidadPendienteAprobacionDenegacionPorCurso(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Try
            Return Me.mDb.ObtenerCantidadPendienteAprobacionDenegacionPorCurso(ID_ACCION_FORMATIVA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve la cantidad de cursos en los que aparece inscrito un Participante por su Tipo(s) de Solicitud
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/07/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCantidadCursosPorParticipanteInscrito(ByVal ID_PARTICIPANTE As Decimal, ByVal TIPO_SOLICITUDES As List(Of Integer)) As Integer
        Try
            Return Me.mDb.ObtenerCantidadCursosPorParticipanteInscrito(ID_PARTICIPANTE, TIPO_SOLICITUDES)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
    'TODO Barrer solo Informes Emitidos / Devueltos con Observaciones, de lo contrario se regenerarán hasta los que estén en otro estado
    Private Function RegenerarInforme(ByVal idAccionFormativa As Decimal) As Integer
        'Actualizar Informe Final si aplica
        Dim lbInformeFinal As New cINFORME_FINAL_AF
        Dim lInformes As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(idAccionFormativa)
        If lInformes IsNot Nothing AndAlso lInformes.Count > 0 Then
            For Each lEntidad As INFORME_FINAL_AF In lInformes
                If lEntidad.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.Emitido OrElse _
                    lEntidad.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones Then
                    lbInformeFinal.ActualizarINFORME_FINAL_AF(lEntidad, TipoConcurrencia.Optimistica, True, False, False)
                End If
            Next
            Return 1
        Else
            Return 1
        End If
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
    ''' <returns>
    '''   1 : Agregar o Actualizar realizado Satisfactoriamente
    '''  -2 : No se pudo Agregar el Nuevo Participante
    '''  -3 : No se pudo Actualizar el Participante
    '''  -4 : No se pudo Inscribir el Participante al cambiar de Estado la Solicitud a Aprobada
    '''  -5 : No se pudo Actualizar el # de Participantes Inscritos en la Accion Formativa 
    '''       al momento de cambiar de Estado la Solicitud a Aprobada
    '''  -6 : No se pudo Registrar el Comentario al cambiar de Estado la Solicitud a Rechazada
    '''  -7 : No se pudo Registrar el Comentario al cambiar de Estado la Solicitud a Anulada
    '''  -8 : No se pudo efectuar el cambio de estado ya que las Observaciones no puede exceder de 255 caracteres
    '''  -9 : No se pudo Registrar el Comentario al cambiar de Estado la Solicitud a En Espera de Cupo
    '''  -10: No se puede Agregar mas de una Solicitud para el mismo curso del mismo Participante
    '''  -11: No se pudo Actualizar el # de Participantes Inscritos en la Accion Formativa al momento de cambiar de Estado la Solicitud a Aprobada
    '''  -12: No se pudo Actualizar la fecha de presentación de la solicitud
    '''  -13: No se pudo Actualizar la edad del participante
    '''  -14: No se pudo Actualizar las discapacidades del participante
    '''  -15: No se pudo Registrar el Comentario al cambiar de Estado la Solicitud a Cambio de Grupo
    '''  -16: No se pudo Inscribir el Participante debido a que no cuenta con documentos de identidad en HTP y Proyecto Especial y no está autorizada su inscripción
    '''  -17: No se pudo Cambiar de Estado debido a que existe Informe entregado
    ''' </returns>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' 	[ecarias]	11/03/2010	Se agregó lógica de Agregar Nueva Solicitud
    ''' 	[ecarias]	15/03/2010	Cambio de Estado de Solicitud - Aprobada, Rechazada y En Espera
    ''' 	[ecarias]	26/03/2010	Validacion de que no se pueda ingresar mas de una solicitud al mismo
    '''                             Curso del mismo Participante.
    ''' 	[ecarias]	15/04/2010	Se agrego cambio a Estado en Espera de Cupo
    ''' 	[ecarias]	23/08/2010	Se cambio que la validación de Cantidad de Solicitudes para el mismo Curso
    '''                             para que lo realize solo para Participantes ya Existentes
    ''' 	[ecarias]	16/05/2011	Se agrego cambio a Estado Cambio de Grupo
    ''' 	[cramos]	12/12/2012	Se cambia lógica para que utilice Programa de Formación en lugar de Tipo de Solicitud
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_INSCRIPCION_AF(ByVal aEntidad As SOLICITUD_INSCRIPCION_AF, ByVal aTipoConcurrencia As TipoConcurrencia, Optional ByVal Observacion As String = "") As Integer
        Try
            Dim bPrograRetro As New cACCION_PROGRA_RETRO
            Dim listaPrograRetro As listaACCION_PROGRA_RETRO
            Dim esNuevo As Boolean = False
            Dim exoneradoDUI_NIT As Boolean = False
            Dim liRet As Integer
            Dim idProgramaFormacion As Decimal
            Dim EsRegeneracionInforme As Boolean = False
            Dim lEntidadActual As New SOLICITUD_INSCRIPCION_AF
            Dim bUnidadOrganizativa As New cUNIDAD_ORGANIZATIVA
            Dim edadNIT As Int32 = 0
            Dim lContratoCompra As CONTRATO_COMPRA
            Const edadMinima As Int32 = 16

            If aEntidad.ID_SOLICITUD = 0 Then
                esNuevo = True
            Else
                lEntidadActual = (New cSOLICITUD_INSCRIPCION_AF).ObtenerSOLICITUD_INSCRIPCION_AF(aEntidad.ID_SOLICITUD)
            End If

            'Obteniendo el Programa de Formación
            idProgramaFormacion = (New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(aEntidad.ID_ACCION_FORMATIVA)

            If Observacion.Length > 600 Then
                Me.sError = "No se pudo efectuar el cambio de estado ya que las Observaciones no puede exceder de 600 caracteres"
                Return -8
            End If

            'Validar la fecha de presentación de la solicitud
            Dim eAccionFormativa As New ACCION_FORMATIVA
            eAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
            If aEntidad.FECHA_PRESENTACION > eAccionFormativa.FECHA_FIN_REAL AndAlso _
                (idProgramaFormacion = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE OrElse idProgramaFormacion = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL) Then
                Me.sError = "La Fecha de Presentacion: " + aEntidad.FECHA_PRESENTACION.ToShortDateString + " no puede ser mayor a la fecha de finalización del Curso: " + eAccionFormativa.FECHA_FIN_REAL.ToShortDateString + ". Id Solicitud = " + aEntidad.ID_SOLICITUD.ToString()
                Return -12
            End If

            'Establecer la edad del participante *******************
            If (idProgramaFormacion = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE OrElse idProgramaFormacion = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL) AndAlso _
                aEntidad.NIT IsNot Nothing AndAlso aEntidad.NIT.Trim <> "" AndAlso Not Utilerias.EsNIT(aEntidad.NIT.Trim) Then

                Me.sError = "No se puede realizar la inscripción del Participante porque el Numero de NIT no es valido"
                Return -11
            End If
            aEntidad.EDAD = Utilerias.CalcularEdad(aEntidad.FECHA_NACIMIENTO, aEntidad.FECHA_PRESENTACION)
            If aEntidad.NIT IsNot Nothing AndAlso aEntidad.NIT.Trim <> "" Then
                Try
                    Dim fechaNacNIT As Date = New DateTime(Strings.Mid(aEntidad.NIT, 9, 2), Strings.Mid(aEntidad.NIT, 7, 2), Strings.Mid(aEntidad.NIT, 5, 2))
                    edadNIT = Utilerias.CalcularEdad(fechaNacNIT, aEntidad.FECHA_PRESENTACION)

                    If edadNIT > 1900 Then
                        fechaNacNIT = DateAdd(DateInterval.Year, 1900, fechaNacNIT)
                        edadNIT = edadNIT - 1900
                    End If
                    If edadNIT > 0 AndAlso edadNIT < edadMinima Then
                        aEntidad.EDAD = edadNIT
                        aEntidad.FECHA_NACIMIENTO = fechaNacNIT
                    End If

                Catch ex As Exception
                    edadNIT = 0
                End Try
            End If
            '*********************************************************


            If aEntidad.EDAD < 10 OrElse aEntidad.EDAD > 100 Then
                Me.sError = "La Fecha de Nacimiento " + aEntidad.FECHA_NACIMIENTO.ToShortDateString + " no es valida. Id Solicitud = " + aEntidad.ID_SOLICITUD.ToString() + ", Fecha solicitud = " + aEntidad.FECHA_PRESENTACION.ToShortDateString
                Return -13
            End If

            If esNuevo AndAlso eAccionFormativa.CODIGO_ESTADO_AF <> Enumeradores.EstadoAccionFormativa.Ingresada Then
                Dim bAccionFormativa As New cACCION_FORMATIVA
                Dim ds As DataSet
                Dim lAsistenciaAF As listaASISTENCIA_AF
                Dim porc20minutos As Int32


                'Validar conflicto de horario con otro curso
                lContratoCompra = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRAPorID_ACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
                ds = bAccionFormativa.ObtenerAccionFormativa_Horario_enConflicto(aEntidad.ID_PARTICIPANTE, aEntidad.ID_ACCION_FORMATIVA)
                If ds IsNot Nothing AndAlso ds.Tables(0).Rows.Count > 0 Then
                    If Not (lContratoCompra IsNot Nothing AndAlso lContratoCompra.NO_CONTRATO_COMPRA = "53") Then

                        listaPrograRetro = bPrograRetro.ObtenerACCION_PROGRA_RETRO_PorCriterios(eAccionFormativa.ID_PROVEEDOR_AF, _
                                                                                            eAccionFormativa.ID_EJERCICIO, _
                                                                                            eAccionFormativa.CODIGO_GRUPO, _
                                                                                            AutorizacionExcepcion.HorarioSimultaneoParticipante, _
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
                                Me.sError = "El participante esta inscrito en el curso " + ds.Tables(0).Rows(0)("NOMBRE_ACCION_FORMATIVA") + " " + ds.Tables(0).Rows(0)("CODIGO_GRUPO") + " que posee un horario simultaneo con el curso actual en la fecha " + _
                                CDate(ds.Tables(0).Rows(0)("INICIO")).ToShortDateString + " y horario de " + Format(ds.Tables(0).Rows(0)("INICIO"), "hh:mm tt") + " a " + Format(ds.Tables(0).Rows(0)("FIN"), "hh:mm tt")
                            Else
                                Me.sError = "El participante esta inscrito en el curso " + ds.Tables(0).Rows(0)("NOMBRE_ACCION_FORMATIVA") + " " + ds.Tables(0).Rows(0)("CODIGO_GRUPO") + " que posee un horario simultaneo con el curso actual"
                            End If
                            Return -14
                        End If

                    End If
                End If

                'Validar que no haya transcurrido el 20% de desarrollo del curso a partir de la fecha de inicio en la calendarización
                porc20minutos = CInt(eAccionFormativa.DURACION_HORAS * 60 * 0.2)
                lAsistenciaAF = (New cASISTENCIA_AF).ObtenerListaPorACCION_FORMATIVA(eAccionFormativa.ID_ACCION_FORMATIVA, False, False, "FECHA")
                If lAsistenciaAF IsNot Nothing AndAlso lAsistenciaAF.Count > 0 AndAlso _
                    (idProgramaFormacion = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE OrElse _
                        (idProgramaFormacion = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL AndAlso Not bUnidadOrganizativa.EsDeUnidaOrganizativa(aEntidad.ID_ACCION_FORMATIVA, Enumeradores.UnidadOrganizativa.CentroFormacionSanBartolo)) _
                    ) Then
                    Dim veintePorc As Integer = CInt(eAccionFormativa.DURACION_HORAS * 60 * 0.2)
                    Dim acumMinutos As Integer = 0
                    Dim fechaLimite As Object = Nothing

                    For Each eAsistencia As ASISTENCIA_AF In lAsistenciaAF
                        acumMinutos += eAsistencia.CANTIDAD_HORAS
                        If acumMinutos > veintePorc AndAlso eAsistencia.FECHA < Today Then

                            Dim listaInscripcionExtempo As listaACCION_PROGRA_RETRO
                            listaInscripcionExtempo = (New cACCION_PROGRA_RETRO).ObtenerACCION_PROGRA_RETRO_PorCriterios(eAccionFormativa.ID_PROVEEDOR_AF, _
                                                                                               eAccionFormativa.ID_EJERCICIO, _
                                                                                               eAccionFormativa.CODIGO_GRUPO, _
                                                                                               EstadoAccionFormativa.EnMatricula, _
                                                                                               1)
                            If listaInscripcionExtempo IsNot Nothing AndAlso listaInscripcionExtempo.Count > 0 AndAlso listaInscripcionExtempo(0).FECHA_EXPIRA >= Today Then
                            Else
                                Me.sError = "No se puede inscribir al participante debido a que se sobrepaso el 20% de ejecucion del curso"
                                Return -15
                            End If

                        End If
                    Next
                End If
            End If


            'Cambio de Estado
            If Not esNuevo AndAlso (lEntidadActual.ID_ESTADO_SOLICITUD > 0) And lEntidadActual.ID_ESTADO_SOLICITUD <> aEntidad.ID_ESTADO_SOLICITUD Then

                'Validar que si existe informe de ejecución éste se encuentre emitido
                If Not Utilerias.EsProgramaPATI(idProgramaFormacion) Then
                    Dim lInformes As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
                    Dim existeInformeEmitidoDevuelto As Boolean = False
                    If lInformes IsNot Nothing AndAlso lInformes.Count > 1 Then
                        For Each lInforme As INFORME_FINAL_AF In lInformes
                            If lInforme.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.Emitido OrElse _
                                lInforme.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones Then
                                existeInformeEmitidoDevuelto = True
                            End If
                        Next
                        If Not existeInformeEmitidoDevuelto Then
                            Me.sError = "No se pudo actualizar la solicitud debido a que no existen informes emitidos o devueltos con observaciones."
                            Return -17
                        End If
                    End If
                End If

                liRet = mDb.Actualizar(aEntidad, aTipoConcurrencia)
                If liRet = 1 Then

                    'Si cambio de Estado a Aprobada
                    If aEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Aprobada Then

                        ' Se Agrega el participante Inscrito
                        Dim lResultado As Integer
                        Dim esNuevoParticipanteAF As Boolean = True
                        Dim lParticipanteInscrito As New PARTICIPANTE_AF
                        lParticipanteInscrito = (New cPARTICIPANTE_AF).ObtenerPARTICIPANTE_AF(aEntidad.ID_PARTICIPANTE, aEntidad.ID_ACCION_FORMATIVA)
                        If lParticipanteInscrito IsNot Nothing AndAlso lParticipanteInscrito.ID_PARTICIPANTE > 0 Then
                            esNuevoParticipanteAF = False
                        Else
                            lParticipanteInscrito = New PARTICIPANTE_AF
                        End If
                        lParticipanteInscrito.ID_SOLICITUD = aEntidad.ID_SOLICITUD
                        lParticipanteInscrito.ID_ACCION_FORMATIVA = aEntidad.ID_ACCION_FORMATIVA
                        lParticipanteInscrito.ID_PARTICIPANTE = aEntidad.ID_PARTICIPANTE
                        If eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Finalizada Then
                            lParticipanteInscrito.ESTADO = Enumeradores.EstadoParticipanteEnCurso.Evaluado
                            aEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Finalizada
                            mDb.Actualizar(aEntidad, aTipoConcurrencia)
                        Else
                            lParticipanteInscrito.ESTADO = Enumeradores.EstadoParticipanteEnCurso.Inscrito
                        End If
                        lParticipanteInscrito.FECHA_INSCRIPCION = Now
                        lParticipanteInscrito.NOTA_FINAL = 0
                        lParticipanteInscrito.PORC_ASISTENCIA = 100
                        If Observacion <> "" Then
                            lParticipanteInscrito.NOTAS = Observacion
                        Else
                            lParticipanteInscrito.NOTAS = ""
                        End If
                        If esNuevoParticipanteAF Then
                            lResultado = (New cPARTICIPANTE_AF).AgregarPARTICIPANTE_AF(lParticipanteInscrito)
                        Else
                            lResultado = (New cPARTICIPANTE_AF).ActualizarPARTICIPANTE_AF(lParticipanteInscrito)
                        End If
                        If lResultado < 1 Then
                            Me.sError = "No se pudo Inscribir el Participante al cambiar de Estado la Solicitud a Aprobada"
                            Me.sErrorTecnico = "ID_PARTICIPANTE = " + aEntidad.ID_PARTICIPANTE.ToString() + "; ID_SOLICITUD = " + aEntidad.ID_SOLICITUD.ToString() + "; ID_ACCION_FORMATIVA = " + aEntidad.ID_ACCION_FORMATIVA.ToString()
                            Return -4
                        End If

                        If ActualizarCantParticipantesInscritosAccionFormativa(aEntidad.ID_ACCION_FORMATIVA) < 1 Then
                            Return -7
                        End If

                        'Para las solicitudes aprobadas en cursos que tengan creadas evaluaciones, agregar el participante en las evaluaciones 
                        'respectivas

                        Dim lEvaluaciones As New listaEVALUACION_AF

                        'Obtener la lista de Evaluaciones creadas
                        lEvaluaciones = (New cEVALUACION_AF).ObtenerListaPorACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)

                        For Each lEvaluacion As EVALUACION_AF In lEvaluaciones

                            'Obtener las notas de la evaluación actual
                            Dim listaNotasPorParticipante As New listaEVALUACIONES_AF_DET
                            Dim ExisteNotaParticipante As Boolean = False

                            listaNotasPorParticipante = (New cEVALUACIONES_AF_DET).ObtenerListaPorEVALUACION_AF(lEvaluacion.ID_EVALUACION_AF)
                            For Each eNota As EVALUACIONES_AF_DET In listaNotasPorParticipante
                                'Verificar si el participante posee nota en esta evaluación
                                If eNota.ID_PARTICIPANTE = aEntidad.ID_PARTICIPANTE Then
                                    ExisteNotaParticipante = True
                                    Exit For
                                End If
                            Next

                            If Not ExisteNotaParticipante Then
                                Dim Nota As New cEVALUACIONES_AF_DET
                                Nota.AgregarEVALUACIONES_AF_DET(0, aEntidad.ID_PARTICIPANTE, lEvaluacion.ID_EVALUACION_AF, 0, "")
                            End If
                        Next
                    End If

                    'Si cambio de Estado a Rechazada
                    If aEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Rechazada Then

                        ' Se Agrega el participante Inscrito
                        Dim lParticipanteInscrito As New PARTICIPANTE_AF
                        lParticipanteInscrito.ID_SOLICITUD = aEntidad.ID_SOLICITUD
                        lParticipanteInscrito.ID_ACCION_FORMATIVA = aEntidad.ID_ACCION_FORMATIVA
                        lParticipanteInscrito.ID_PARTICIPANTE = aEntidad.ID_PARTICIPANTE
                        lParticipanteInscrito.ESTADO = Enumeradores.EstadoParticipanteEnCurso.Rechazado
                        lParticipanteInscrito.FECHA_INSCRIPCION = Now
                        lParticipanteInscrito.NOTA_FINAL = 0
                        lParticipanteInscrito.PORC_ASISTENCIA = 0
                        lParticipanteInscrito.NOTAS = Observacion

                        If (New cPARTICIPANTE_AF).AgregarPARTICIPANTE_AF(lParticipanteInscrito) < 1 Then
                            Me.sError = "No se pudo Registrar el Comentario al cambiar de Estado la Solicitud a Rechazada"
                            Me.sErrorTecnico = "ID_PARTICIPANTE = " + aEntidad.ID_PARTICIPANTE.ToString() + "; ID_SOLICITUD = " + aEntidad.ID_SOLICITUD.ToString() + "; ID_ACCION_FORMATIVA = " + aEntidad.ID_ACCION_FORMATIVA.ToString()
                            Return -6
                        End If

                    End If

                    'Si cambio de Estado a En Espera de Cupo
                    If aEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.EnEsperaDeCupo Then

                        ' Se Agrega el participante en Espera de Cupo
                        Dim lParticipanteInscrito As New PARTICIPANTE_AF
                        lParticipanteInscrito.ID_SOLICITUD = aEntidad.ID_SOLICITUD
                        lParticipanteInscrito.ID_ACCION_FORMATIVA = aEntidad.ID_ACCION_FORMATIVA
                        lParticipanteInscrito.ID_PARTICIPANTE = aEntidad.ID_PARTICIPANTE
                        lParticipanteInscrito.ESTADO = Enumeradores.EstadoParticipanteEnCurso.EnEsperaDeCupo
                        lParticipanteInscrito.FECHA_INSCRIPCION = Now
                        lParticipanteInscrito.NOTA_FINAL = 0
                        lParticipanteInscrito.PORC_ASISTENCIA = 0
                        lParticipanteInscrito.NOTAS = Observacion

                        If (New cPARTICIPANTE_AF).AgregarPARTICIPANTE_AF(lParticipanteInscrito) < 1 Then
                            Me.sError = "No se pudo Registrar el Comentario al cambiar de Estado la Solicitud a En Espera de Cupo"
                            Me.sErrorTecnico = "ID_PARTICIPANTE = " + aEntidad.ID_PARTICIPANTE.ToString() + "; ID_SOLICITUD = " + aEntidad.ID_SOLICITUD.ToString() + "; ID_ACCION_FORMATIVA = " + aEntidad.ID_ACCION_FORMATIVA.ToString()
                            Return -9
                        End If

                    End If


                    'Si cambio de Estado a Desertada
                    If aEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Desercion Then

                        ' Verificar si el participante está aprobado
                        Dim lParticipante As New PARTICIPANTE_AF
                        lParticipante = (New cPARTICIPANTE_AF).ObtenerPARTICIPANTE_AF(aEntidad.ID_PARTICIPANTE, aEntidad.ID_ACCION_FORMATIVA)
                        If lParticipante.ESTADO = "" Or lParticipante.ESTADO Is Nothing Then
                            lParticipante = New PARTICIPANTE_AF
                            lParticipante.ID_SOLICITUD = aEntidad.ID_SOLICITUD
                            lParticipante.ID_ACCION_FORMATIVA = aEntidad.ID_ACCION_FORMATIVA
                            lParticipante.ID_PARTICIPANTE = aEntidad.ID_PARTICIPANTE
                            lParticipante.ESTADO = Enumeradores.EstadoParticipanteEnCurso.Desertado
                            lParticipante.FECHA_INSCRIPCION = Now
                            lParticipante.NOTA_FINAL = 0
                            lParticipante.PORC_ASISTENCIA = 0
                            lParticipante.NOTAS = Observacion
                            lParticipante.LASTUPDATE = Now

                            ' Se Agrega el participante con Inscripcion Anulada
                            If (New cPARTICIPANTE_AF).AgregarPARTICIPANTE_AF(lParticipante) < 1 Then
                                Me.sError = "No se pudo Registrar el Comentario al cambiar de Estado la Solicitud a Desertado"
                                Me.sErrorTecnico = "ID_PARTICIPANTE = " + aEntidad.ID_PARTICIPANTE.ToString() + "; ID_SOLICITUD = " + aEntidad.ID_SOLICITUD.ToString() + "; ID_ACCION_FORMATIVA = " + aEntidad.ID_ACCION_FORMATIVA.ToString()
                                Return -7
                            End If
                        Else
                            lParticipante.ESTADO = Enumeradores.EstadoParticipanteEnCurso.Desertado
                            lParticipante.NOTA_FINAL = 0
                            lParticipante.PORC_ASISTENCIA = 0
                            lParticipante.NOTAS = Observacion
                            lParticipante.LASTUPDATE = Now

                            ' Se Actualiza el participante
                            If (New cPARTICIPANTE_AF).ActualizarPARTICIPANTE_AF(lParticipante) < 1 Then
                                Me.sError = "No se pudo Registrar el Comentario al cambiar de Estado la Solicitud a Desertado. Id Solicitud=" + aEntidad.ID_SOLICITUD.ToString()
                                Me.sErrorTecnico = "ID_PARTICIPANTE = " + aEntidad.ID_PARTICIPANTE.ToString() + "; ID_SOLICITUD = " + aEntidad.ID_SOLICITUD.ToString() + "; ID_ACCION_FORMATIVA = " + aEntidad.ID_ACCION_FORMATIVA.ToString()
                                Return -7
                            End If

                            If ActualizarCantParticipantesInscritosAccionFormativa(aEntidad.ID_ACCION_FORMATIVA) < 1 Then
                                Return -11
                            End If

                        End If

                    End If


                    'Si cambio de Estado a Anulada
                    If aEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Anulada Then

                        ' Verificar si el participante está aprobado
                        Dim lParticipante As New PARTICIPANTE_AF
                        lParticipante = (New cPARTICIPANTE_AF).ObtenerPARTICIPANTE_AF(aEntidad.ID_PARTICIPANTE, aEntidad.ID_ACCION_FORMATIVA)
                        If lParticipante.ESTADO = "" Or lParticipante.ESTADO Is Nothing Then
                            lParticipante = New PARTICIPANTE_AF
                            lParticipante.ID_SOLICITUD = aEntidad.ID_SOLICITUD
                            lParticipante.ID_ACCION_FORMATIVA = aEntidad.ID_ACCION_FORMATIVA
                            lParticipante.ID_PARTICIPANTE = aEntidad.ID_PARTICIPANTE
                            lParticipante.ESTADO = Enumeradores.EstadoParticipanteEnCurso.SolicitudAnulada
                            lParticipante.FECHA_INSCRIPCION = Now
                            lParticipante.NOTA_FINAL = 0
                            lParticipante.PORC_ASISTENCIA = 0
                            lParticipante.NOTAS = Observacion
                            lParticipante.LASTUPDATE = Now

                            ' Se Agrega el participante con Inscripcion Anulada
                            If (New cPARTICIPANTE_AF).AgregarPARTICIPANTE_AF(lParticipante) < 1 Then
                                Me.sError = "No se pudo Registrar el Comentario al cambiar de Estado la Solicitud a Anulada"
                                Me.sErrorTecnico = "ID_PARTICIPANTE = " + aEntidad.ID_PARTICIPANTE.ToString() + "; ID_SOLICITUD = " + aEntidad.ID_SOLICITUD.ToString() + "; ID_ACCION_FORMATIVA = " + aEntidad.ID_ACCION_FORMATIVA.ToString()
                                Return -7
                            End If
                        Else
                            lParticipante.ESTADO = Enumeradores.EstadoParticipanteEnCurso.InscripcionAnulada
                            lParticipante.NOTA_FINAL = 0
                            lParticipante.PORC_ASISTENCIA = 0
                            lParticipante.NOTAS = Observacion
                            lParticipante.LASTUPDATE = Now

                            ' Se Actualiza el participante
                            If (New cPARTICIPANTE_AF).ActualizarPARTICIPANTE_AF(lParticipante) < 1 Then
                                Me.sError = "No se pudo Registrar el Comentario al cambiar de Estado la Solicitud a Anulada. Id Solicitud=" + aEntidad.ID_SOLICITUD.ToString()
                                Me.sErrorTecnico = "ID_PARTICIPANTE = " + aEntidad.ID_PARTICIPANTE.ToString() + "; ID_SOLICITUD = " + aEntidad.ID_SOLICITUD.ToString() + "; ID_ACCION_FORMATIVA = " + aEntidad.ID_ACCION_FORMATIVA.ToString()
                                Return -7
                            End If

                            If ActualizarCantParticipantesInscritosAccionFormativa(aEntidad.ID_ACCION_FORMATIVA) < 1 Then
                                Return -11
                            End If

                        End If

                    End If

                    'Si cambio de Estado a Cambio de Grupo
                    If aEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.CambioDeCurso Then

                        Dim lParticipante As New PARTICIPANTE_AF
                        lParticipante = (New cPARTICIPANTE_AF).ObtenerPARTICIPANTE_AF(aEntidad.ID_PARTICIPANTE, aEntidad.ID_ACCION_FORMATIVA)
                        lParticipante.ESTADO = Enumeradores.EstadoParticipanteEnCurso.CambioDeCurso
                        lParticipante.NOTAS = Observacion

                        If (New cPARTICIPANTE_AF).ActualizarPARTICIPANTE_AF(lParticipante) < 1 Then
                            Me.sError = "No se pudo Registrar el Comentario al cambiar de Estado la Solicitud a Cambio de Grupo"
                            Me.sErrorTecnico = "ID_PARTICIPANTE = " + aEntidad.ID_PARTICIPANTE.ToString() + "; ID_SOLICITUD = " + aEntidad.ID_SOLICITUD.ToString() + "; ID_ACCION_FORMATIVA = " + aEntidad.ID_ACCION_FORMATIVA.ToString()
                            Return -15
                        End If

                        If ActualizarCantParticipantesInscritosAccionFormativa(aEntidad.ID_ACCION_FORMATIVA) < 1 Then
                            Return -11
                        End If
                    End If

                    'Si cambio de Estado a Cambio de Grupo Automático
                    If aEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.CambioDeCursoPorSistema Then

                        Dim lParticipante As New PARTICIPANTE_AF
                        lParticipante = (New cPARTICIPANTE_AF).ObtenerPARTICIPANTE_AF(aEntidad.ID_PARTICIPANTE, aEntidad.ID_ACCION_FORMATIVA)
                        lParticipante.ESTADO = Enumeradores.EstadoParticipanteEnCurso.CambioDeCursoPorSistema
                        lParticipante.NOTAS = Observacion

                        If (New cPARTICIPANTE_AF).ActualizarPARTICIPANTE_AF(lParticipante) < 1 Then
                            Me.sError = "No se pudo Registrar el Comentario al cambiar de Estado la Solicitud a Cambio de Grupo"
                            Me.sErrorTecnico = "ID_PARTICIPANTE = " + aEntidad.ID_PARTICIPANTE.ToString() + "; ID_SOLICITUD = " + aEntidad.ID_SOLICITUD.ToString() + "; ID_ACCION_FORMATIVA = " + aEntidad.ID_ACCION_FORMATIVA.ToString()
                            Return -15
                        End If

                        If ActualizarCantParticipantesInscritosAccionFormativa(aEntidad.ID_ACCION_FORMATIVA) < 1 Then
                            Return -11
                        End If
                    End If

                    'Regenerar información del Informe Final si aplica
                    If eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Finalizada Then RegenerarInforme(aEntidad.ID_ACCION_FORMATIVA)

                End If
            Else 'Actualizacion o Nueva Solicitud
                Dim lEntidad As SOLICITUD_INSCRIPCION_AF = aEntidad

                Dim cPARTICIPANTE As cPARTICIPANTE = New cPARTICIPANTE()
                Dim Participante As PARTICIPANTE = New PARTICIPANTE()

                'Validacion nueva inscripción para participantes del programa Hábil Técnico Permanente y Proyectos Especiales
                If lEntidad.ID_SOLICITUD = 0 AndAlso lEntidad.DUI.Trim = "" AndAlso lEntidad.NIT.Trim = "" AndAlso _
                    (idProgramaFormacion = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE OrElse idProgramaFormacion = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL) Then
                    Dim lEntidadAccionParti As listaACCION_PARTI_SINDOCTOS = (New cACCION_PARTI_SINDOCTOS).ObtenerListaPorACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA)
                    If lEntidadAccionParti IsNot Nothing AndAlso lEntidadAccionParti.Count > 0 Then
                        Dim totalAutorizado As Decimal = 0
                        Dim totalInscritos As Decimal = (New cACCION_FORMATIVA).ObtenerCantParticipantesSinDoctos(lEntidad.ID_ACCION_FORMATIVA)
                        For Each lEntidadAccion As ACCION_PARTI_SINDOCTOS In lEntidadAccionParti
                            If lEntidadAccion.TIPO_AUTORIZACION = "S/D" AndAlso lEntidadAccion.ES_ACTIVA = 1 Then totalAutorizado += lEntidadAccion.CANT_PARTICIPANTES
                        Next
                        'Para esta inscripción
                        totalInscritos += 1
                        exoneradoDUI_NIT = True
                        If totalInscritos > totalAutorizado Then
                            Me.sError = "La inscripción del participante sin documentos sobrepasa la cantidad autorizada para el curso."
                            Return -11
                        End If
                    End If
                End If

                'Validación de DUI / NIT y EDAD para participantes del programa Hábil Técnico Permanente y Proyectos Especiales
                If (idProgramaFormacion = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE OrElse idProgramaFormacion = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL) Then
                    If idProgramaFormacion = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE Then
                        Select Case Convert.ToInt32(lEntidad.EDAD)
                            Case Is >= 18
                                If lEntidad.DUI.Trim = "" AndAlso Not exoneradoDUI_NIT Then
                                    Me.sError = "El numero de DUI es obligatorio para mayores de 18 años"
                                    Return -11
                                End If
                            Case edadMinima To 17
                                If lEntidad.NIT.Trim = "" AndAlso Not exoneradoDUI_NIT Then
                                    Me.sError = "El numero de NIT es obligatorio para menores de 18 años"
                                    Return -11
                                End If
                            Case Is < edadMinima
                                'Verificar si hay autorización para inscribir menor de 16 años
                                Dim lEntidadAccionParti As listaACCION_PARTI_SINDOCTOS = (New cACCION_PARTI_SINDOCTOS).ObtenerListaPorACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA)
                                If lEntidadAccionParti IsNot Nothing AndAlso lEntidadAccionParti.Count > 0 Then
                                    Dim totalAutorizado As Decimal = 0
                                    Dim totalInscritos As Decimal = (New cACCION_FORMATIVA).ObtenerCantParticipantesMenoresEdad(lEntidad.ID_ACCION_FORMATIVA, 16)
                                    For Each lEntidadAccion As ACCION_PARTI_SINDOCTOS In lEntidadAccionParti
                                        If lEntidadAccion.TIPO_AUTORIZACION = "M/E" AndAlso lEntidadAccion.ES_ACTIVA = 1 Then totalAutorizado += lEntidadAccion.CANT_PARTICIPANTES
                                    Next
                                    'Para esta inscripción
                                    totalInscritos += 1
                                    If totalInscritos > totalAutorizado Then
                                        Me.sError = "La inscripción del participante menor de " + edadMinima.ToString + " años sobrepasa la cantidad autorizada para el curso."
                                        Return -11
                                    End If
                                Else
                                    Me.sError = "No se pueden inscribir menores de " + edadMinima.ToString + " años"
                                    Return -11
                                End If
                        End Select
                    ElseIf idProgramaFormacion = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL Then
                        If lEntidad.EDAD < edadMinima Then
                            'Verificar si hay autorización para inscribir menor de 16 años
                            Dim lEntidadAccionParti As listaACCION_PARTI_SINDOCTOS = (New cACCION_PARTI_SINDOCTOS).ObtenerListaPorACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA)
                            If lEntidadAccionParti IsNot Nothing AndAlso lEntidadAccionParti.Count > 0 Then
                                Dim totalAutorizado As Decimal = 0
                                Dim totalInscritos As Decimal = (New cACCION_FORMATIVA).ObtenerCantParticipantesMenoresEdad(lEntidad.ID_ACCION_FORMATIVA, edadMinima)
                                For Each lEntidadAccion As ACCION_PARTI_SINDOCTOS In lEntidadAccionParti
                                    If lEntidadAccion.TIPO_AUTORIZACION = "M/E" AndAlso lEntidadAccion.ES_ACTIVA = 1 Then totalAutorizado += lEntidadAccion.CANT_PARTICIPANTES
                                Next
                                'Para esta inscripción
                                totalInscritos += 1
                                If totalInscritos > totalAutorizado Then
                                    Me.sError = "La inscripción del participante menor de 16 años sobrepasa la cantidad autorizada para el curso."
                                    Return -11
                                End If
                            Else
                                Me.sError = "No se pueden inscribir menores de " + edadMinima.ToString + " años"
                                Return -11
                            End If
                        End If
                    End If
                    If lEntidad.DUI IsNot Nothing AndAlso lEntidad.DUI.Trim <> "" AndAlso Not Utilerias.EsDUI(aEntidad.DUI.Trim) Then
                        Me.sError = "No se puede realizar la inscripción del Participante porque el Numero de DUI no es valido"
                        Return -11
                    End If

                    If lEntidad.NIT IsNot Nothing AndAlso lEntidad.NIT.Trim <> "" AndAlso Not Utilerias.EsNIT(aEntidad.NIT.Trim) Then
                        Me.sError = "No se puede realizar la inscripción del Participante porque el Numero de NIT no es valido"
                        Return -11
                    End If
                End If

                'Si es nuevo Participante crearlo, sino verificar si ha sido modificado y actualizarlo
                If lEntidad.ID_PARTICIPANTE = 0 Then
                    Participante.NOMBRES = lEntidad.NOMBRES
                    Participante.APELLIDOS = lEntidad.APELLIDOS
                    Participante.GENERO = lEntidad.GENERO
                    Participante.ID_PAIS = lEntidad.ID_PAIS
                    Participante.FECHA_NACIMIENTO = lEntidad.FECHA_NACIMIENTO
                    Participante.DIRECCION = lEntidad.DIRECCION
                    Participante.DUI = lEntidad.DUI
                    Participante.NIT = lEntidad.NIT
                    Participante.ISSS = lEntidad.ISSS
                    Participante.TIPO_DOCTO = lEntidad.TIPO_DOCTO
                    Participante.NUM_DOCTO = lEntidad.NUM_DOCTO
                    Participante.TELEFONO = lEntidad.TELEFONO
                    Participante.MOVIL = lEntidad.MOVIL
                    Participante.EMAIL = lEntidad.EMAIL
                    Participante.ID_ESTADO_CIVIL = lEntidad.ID_ESTADO_CIVIL
                    Participante.PROFESION_OFICIO = lEntidad.PROFESION_OFICIO
                    Participante.TITULO_CERTIFICADO_OBTENIDO = lEntidad.TITULO_CERTIFICADO_OBTENIDO
                    Participante.DEPARTAMENTO_NAC = lEntidad.DEPARTAMENTO_NAC
                    Participante.MUNICIPIO_NAC = lEntidad.MUNICIPIO_NAC
                    Participante.CODIGO_DEPARTAMENTO = lEntidad.CODIGO_DEPARTAMENTO
                    Participante.CODIGO_MUNICIPIO = lEntidad.CODIGO_MUNICIPIO
                    Participante.ID_NIVEL_ACADEMICO = lEntidad.ID_NIVEL_ACADEMICO
                    Participante.OTRA_EDUCACION_FORMAL = lEntidad.OTRA_EDUCACION_FORMAL
                    Participante.CON_DISCAPACIDAD = lEntidad.CON_DISCAPACIDAD
                    Participante.DISC_OTRA = lEntidad.DISC_OTRA
                    Participante.USERID = Utilerias.ObtenerUsuario()
                    Participante.LASTUPDATE = DateTime.Now

                    If (cPARTICIPANTE.ActualizarPARTICIPANTE(Participante) < 1) Then
                        Me.sError = "No se pudo Agregar el Nuevo Participante"
                        If cPARTICIPANTE.sError <> "" Then
                            Me.sError += vbCrLf + cPARTICIPANTE.sError
                        End If
                        Me.sErrorTecnico = "DUI = " + lEntidad.DUI + "; NIT = " + lEntidad.NIT
                        Return -2
                    End If

                    If Participante.CON_DISCAPACIDAD = 1 AndAlso lEntidad.DISCA_POR_SOLICITUDSOLICITUD_INSCRIPCION_AF IsNot Nothing Then
                        Dim bDiscapParticipante As New cDISCA_POR_PARTICIPANTE

                        For Each _discapSolic As DISCA_POR_SOLICITUD In lEntidad.DISCA_POR_SOLICITUDSOLICITUD_INSCRIPCION_AF
                            Dim _discapPart As New DISCA_POR_PARTICIPANTE
                            _discapPart.ID_PARTICIPANTE = Participante.ID_PARTICIPANTE
                            _discapPart.ID_DISCAPACIDAD = _discapSolic.ID_DISCAPACIDAD

                            bDiscapParticipante.AgregarDISCA_POR_PARTICIPANTE(_discapPart)
                        Next
                    End If

                    lEntidad.ID_PARTICIPANTE = Participante.ID_PARTICIPANTE
                Else

                    'Validar Cantidad de Solicitudes para el Mismo Curso
                    If lEntidad.ID_SOLICITUD = 0 Then
                        If mDb.ObtenerCantidadPorCurso(lEntidad.ID_PARTICIPANTE, lEntidad.ID_ACCION_FORMATIVA) > 0 Then
                            Me.sError = "No se puede Agregar mas de una Solicitud para el mismo curso del mismo Participante"
                            Me.sErrorTecnico = "ID_PARTICIPANTE = " + aEntidad.ID_PARTICIPANTE.ToString() + "; ID_SOLICITUD = " + aEntidad.ID_SOLICITUD.ToString() + "; ID_ACCION_FORMATIVA = " + aEntidad.ID_ACCION_FORMATIVA.ToString()
                            Return -10
                        End If
                    End If

                    Participante = cPARTICIPANTE.ObtenerPARTICIPANTE(lEntidad.ID_PARTICIPANTE, False, False)

                    If (Participante.NOMBRES <> lEntidad.NOMBRES Or _
                        Participante.APELLIDOS <> lEntidad.APELLIDOS Or _
                        Participante.GENERO <> lEntidad.GENERO Or _
                        Participante.ID_PAIS = lEntidad.ID_PAIS Or _
                        Participante.FECHA_NACIMIENTO <> lEntidad.FECHA_NACIMIENTO Or _
                        Participante.DIRECCION <> lEntidad.DIRECCION Or _
                        Participante.DUI <> lEntidad.DUI Or _
                        Participante.NIT <> lEntidad.NIT Or _
                        Participante.ISSS <> lEntidad.ISSS Or _
                        Participante.TIPO_DOCTO <> lEntidad.TIPO_DOCTO Or _
                        Participante.NUM_DOCTO <> lEntidad.NUM_DOCTO Or _
                        Participante.TELEFONO <> lEntidad.TELEFONO Or _
                        Participante.MOVIL <> lEntidad.MOVIL Or _
                        Participante.EMAIL <> lEntidad.EMAIL Or _
                        Participante.ID_ESTADO_CIVIL <> lEntidad.ID_ESTADO_CIVIL Or _
                        Participante.PROFESION_OFICIO <> lEntidad.PROFESION_OFICIO Or _
                        Participante.TITULO_CERTIFICADO_OBTENIDO <> lEntidad.TITULO_CERTIFICADO_OBTENIDO Or _
                        Participante.DEPARTAMENTO_NAC <> lEntidad.DEPARTAMENTO_NAC Or _
                        Participante.MUNICIPIO_NAC <> lEntidad.MUNICIPIO_NAC Or _
                        Participante.CODIGO_DEPARTAMENTO <> lEntidad.CODIGO_DEPARTAMENTO Or _
                        Participante.CODIGO_MUNICIPIO <> lEntidad.CODIGO_MUNICIPIO Or _
                        Participante.ID_NIVEL_ACADEMICO <> lEntidad.ID_NIVEL_ACADEMICO Or _
                        Participante.OTRA_EDUCACION_FORMAL <> lEntidad.OTRA_EDUCACION_FORMAL Or _
                        Participante.CON_DISCAPACIDAD <> lEntidad.CON_DISCAPACIDAD Or _
                        Participante.DISC_OTRA <> lEntidad.DISC_OTRA) Then

                        Participante.NOMBRES = lEntidad.NOMBRES
                        Participante.APELLIDOS = lEntidad.APELLIDOS
                        Participante.GENERO = lEntidad.GENERO
                        Participante.ID_PAIS = lEntidad.ID_PAIS
                        Participante.FECHA_NACIMIENTO = lEntidad.FECHA_NACIMIENTO
                        Participante.DIRECCION = lEntidad.DIRECCION
                        Participante.DUI = lEntidad.DUI
                        Participante.NIT = lEntidad.NIT
                        Participante.ISSS = lEntidad.ISSS
                        Participante.TIPO_DOCTO = lEntidad.TIPO_DOCTO
                        Participante.NUM_DOCTO = lEntidad.NUM_DOCTO
                        Participante.TELEFONO = lEntidad.TELEFONO
                        Participante.MOVIL = lEntidad.MOVIL
                        Participante.EMAIL = lEntidad.EMAIL
                        Participante.ID_ESTADO_CIVIL = lEntidad.ID_ESTADO_CIVIL
                        Participante.PROFESION_OFICIO = lEntidad.PROFESION_OFICIO
                        Participante.TITULO_CERTIFICADO_OBTENIDO = lEntidad.TITULO_CERTIFICADO_OBTENIDO
                        Participante.DEPARTAMENTO_NAC = lEntidad.DEPARTAMENTO_NAC
                        Participante.MUNICIPIO_NAC = lEntidad.MUNICIPIO_NAC
                        Participante.CODIGO_DEPARTAMENTO = lEntidad.CODIGO_DEPARTAMENTO
                        Participante.CODIGO_MUNICIPIO = lEntidad.CODIGO_MUNICIPIO
                        Participante.ID_NIVEL_ACADEMICO = lEntidad.ID_NIVEL_ACADEMICO
                        Participante.OTRA_EDUCACION_FORMAL = lEntidad.OTRA_EDUCACION_FORMAL
                        Participante.CON_DISCAPACIDAD = lEntidad.CON_DISCAPACIDAD
                        Participante.DISC_OTRA = lEntidad.DISC_OTRA
                        Participante.LASTUPDATE = DateTime.Now
                        Participante.USERID = Utilerias.ObtenerUsuario()

                        If (cPARTICIPANTE.ActualizarPARTICIPANTE(Participante) < 1) Then
                            Me.sError = "No se pudo Actualizar el Participante"
                            If cPARTICIPANTE.sError <> "" Then
                                Me.sError += vbCrLf + cPARTICIPANTE.sError
                            End If
                            Me.sErrorTecnico = "ID_PARTICIPANTE = " + lEntidad.ID_PARTICIPANTE.ToString()
                            Return -3
                        End If
                    End If
                End If

                'Actualizar discapacidades en participante
                If lEntidad.DISCA_POR_SOLICITUDSOLICITUD_INSCRIPCION_AF IsNot Nothing Then
                    Dim bDiscapacidadSolic As New cDISCA_POR_SOLICITUD
                    Dim bDiscapacidadPart As New cDISCA_POR_PARTICIPANTE

                    For Each _discapacidad As DISCAPACIDAD In (New cDISCAPACIDAD).ObtenerLista
                        Dim eDiscaPorSolic As New DISCA_POR_SOLICITUD
                        Dim eDiscaPorPartic As New DISCA_POR_PARTICIPANTE
                        eDiscaPorSolic = lEntidad.DISCA_POR_SOLICITUDSOLICITUD_INSCRIPCION_AF.BuscarPorId(_discapacidad.ID_DISCAPACIDAD, lEntidad.ID_SOLICITUD)

                        If eDiscaPorSolic IsNot Nothing Then
                            eDiscaPorPartic.ID_PARTICIPANTE = lEntidad.ID_PARTICIPANTE
                            eDiscaPorPartic.ID_DISCAPACIDAD = _discapacidad.ID_DISCAPACIDAD

                            If bDiscapacidadPart.ObtenerDISCA_POR_PARTICIPANTE(eDiscaPorPartic) <> 1 Then
                                If bDiscapacidadPart.AgregarDISCA_POR_PARTICIPANTE(eDiscaPorPartic) <> 1 Then
                                    Me.sError = "No se pudieron Actualizar las Discapacidades"
                                    Return -14
                                End If
                            Else
                                If bDiscapacidadPart.ActualizarDISCA_POR_PARTICIPANTE(eDiscaPorPartic) <> 1 Then
                                    Me.sError = "No se pudieron Actualizar las Discapacidades"
                                    Return -14
                                End If
                            End If
                        Else
                            bDiscapacidadPart.EliminarDISCA_POR_PARTICIPANTE(_discapacidad.ID_DISCAPACIDAD, lEntidad.ID_PARTICIPANTE)
                        End If
                    Next
                End If

                liRet = mDb.Actualizar(lEntidad, aTipoConcurrencia)
                aEntidad.ID_SOLICITUD = lEntidad.ID_SOLICITUD

            End If

            'Si el curso está iniciado y la solicitud está en ESPERA DE APROBACIÓN debemos aprobarla automáticamente 
            If aEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.EnEsperaDeAprobacion AndAlso _
               (idProgramaFormacion = Enumeradores.ProgramasFormacion.PATI_USAID OrElse idProgramaFormacion = Enumeradores.ProgramasFormacion.PATI_BM OrElse idProgramaFormacion = Enumeradores.ProgramasFormacion.PATI_2 OrElse (idProgramaFormacion = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL AndAlso eAccionFormativa.CODIGO_ESTADO_AF = Enumeradores.EstadoAccionFormativa.Finalizada)) Then
                aEntidad.ID_ESTADO_SOLICITUDOld = aEntidad.ID_ESTADO_SOLICITUD
                aEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Aprobada
                Me.ActualizarSOLICITUD_INSCRIPCION_AF(aEntidad, TipoConcurrencia.Pesimistica)
            End If
            Return liRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que actualiza la cantidad de participantes inscritos
    ''' en base a los parametros recibidos.
    ''' </summary>
    ''' <remarks></remarks>
    ''' <history>
    ''' 	[cramos]	16/04/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Function ActualizarCantParticipantesInscritosAccionFormativa(ByVal ID_ACCION_FORMATIVA As Decimal) As Integer
        Dim participantesInscritos As Integer
        Dim liRet As Integer

        participantesInscritos = (New cACCION_FORMATIVA).ObtenerCantidadParticipantesInscritos(ID_ACCION_FORMATIVA)
        Dim lAccion As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        lAccion.PARTICIPANTES_INSCRITOS = participantesInscritos
        liRet = (New cACCION_FORMATIVA).ActualizarACCION_FORMATIVA(lAccion, TipoConcurrencia.Pesimistica, False)
        If liRet < 1 Then
            Me.sError = "No se pudo Actualizar el # de Participantes Inscritos en la Accion Formativa al momento de cambiar de Estado la Solicitud a Aprobada"
            Me.sErrorTecnico = "Metodo: ActualizarCantParticipantesInscritosAccionFormativa ID_ACCION_FORMATIVA = " + ID_ACCION_FORMATIVA.ToString()
            Return -5
        Else
            Return liRet
        End If
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una lista de Registros de la tabla SOLICITUD_INSCRIPCION_AF
    ''' en base a los parametros recibidos.
    ''' </summary>
    ''' <remarks></remarks>
    ''' <history>
    ''' 	[ecarias]	16/03/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal idSolicitud As Decimal, ByVal idProveedor As Decimal, ByVal idSitioCapacitacion As Decimal, ByVal idEjercicio As String, ByVal idEstadoSolicitud As Enumeradores.EstadoSolicitud, ByVal nombreAccionFormativa As String, ByVal codigoGrupo As String, ByVal nombresSolicitante As String, ByVal apellidosSolicitante As String) As listaSOLICITUD_INSCRIPCION_AF
        Try
            Return Me.mDb.ObtenerListaPorCriterios(idSolicitud, idProveedor, idSitioCapacitacion, idEjercicio, idEstadoSolicitud, nombreAccionFormativa, codigoGrupo, nombresSolicitante, apellidosSolicitante)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Cambio de Estado de Solicitudes Asociadas a una Accion Formativa a Finalizadas.
    ''' </summary>
    ''' <remarks></remarks>
    ''' <history>
    ''' 	[ecarias]	14/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function FinalizarSolicitudesDeAccionFormativa(ByVal ID_ACCION_FORMATIVA As Decimal, ByRef shouldReturn As Boolean) As Integer
        shouldReturn = False
        Dim listaSolicitudes As listaSOLICITUD_INSCRIPCION_AF = ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        For Each lSolicitud As SOLICITUD_INSCRIPCION_AF In listaSolicitudes
            If lSolicitud.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Aprobada Then
                lSolicitud.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Finalizada
                If ActualizarSOLICITUD_INSCRIPCION_AF(lSolicitud) < 1 Then
                    shouldReturn = True : Return -2
                End If
            End If
        Next
        Return 0
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PARTICIPANTE .
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	23/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPARTICIPANTE_SOLIC_CURSOS_FINALIZADOS(ByVal ID_PARTICIPANTE As Decimal) As listaSOLICITUD_INSCRIPCION_AF
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF_CURSOS_FINALIZADOS As New listaSOLICITUD_INSCRIPCION_AF
            Dim mListaSOLICITUD_INSCRIPCION_AF As New listaSOLICITUD_INSCRIPCION_AF

            mListaSOLICITUD_INSCRIPCION_AF = mDb.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
            For Each lEntidad As SOLICITUD_INSCRIPCION_AF In mListaSOLICITUD_INSCRIPCION_AF
                If lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Aprobada OrElse _
                    lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Finalizada Then

                    Dim CODIGO_ESTADO_AF As String = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA).CODIGO_ESTADO_AF

                    If CODIGO_ESTADO_AF <> Enumeradores.EstadoAccionFormativa.Ingresada AndAlso _
                       CODIGO_ESTADO_AF <> Enumeradores.EstadoAccionFormativa.EnMatricula AndAlso _
                       CODIGO_ESTADO_AF <> Enumeradores.EstadoAccionFormativa.Iniciada Then

                        mListaSOLICITUD_INSCRIPCION_AF_CURSOS_FINALIZADOS.Add(lEntidad)
                    End If
                End If
            Next

            Return mListaSOLICITUD_INSCRIPCION_AF_CURSOS_FINALIZADOS

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SOLICITUD_INSCRIPCION_AF .
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	19/05/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPARTICIPANTE_INSCRITOS_TIPO_SOLICITUD(ByVal ID_PARTICIPANTE As Decimal, ByVal TIPOS_PROGRAMAS As List(Of Decimal)) As listaSOLICITUD_INSCRIPCION_AF
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF_CURSOS_FINALIZADOS As New listaSOLICITUD_INSCRIPCION_AF
            Dim mListaSOLICITUD_INSCRIPCION_AF As New listaSOLICITUD_INSCRIPCION_AF

            mListaSOLICITUD_INSCRIPCION_AF = mDb.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE)
            For Each lEntidad As SOLICITUD_INSCRIPCION_AF In mListaSOLICITUD_INSCRIPCION_AF
                Dim lAccionFormativaDeta As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lEntidad.ID_ACCION_FORMATIVA)
                If lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Aprobada OrElse _
                    lEntidad.ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.Finalizada Then

                    If TIPOS_PROGRAMAS.Contains(lAccionFormativaDeta.ID_PROGRAMA_FORMACION) Then
                        mListaSOLICITUD_INSCRIPCION_AF_CURSOS_FINALIZADOS.Add(lEntidad)
                    End If
                End If
            Next

            Return mListaSOLICITUD_INSCRIPCION_AF_CURSOS_FINALIZADOS

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
