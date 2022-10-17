Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Collections.Generic
Imports Microsoft.ApplicationBlocks.ExceptionManagement
Imports SGAFP.BL
Imports System
Imports PATI.BL
Imports SGAFP.EL

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la siguiente línea.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://192.168.70.4/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class wsSGAFP
    Inherits System.Web.Services.WebService

    Dim usuario As String

    <WebMethod()> _
    Public Function ProcesarAsignacionGanador(ByVal codigoArea As String, ByVal codigoPrograma As String, ByVal nombrePrograma As String, ByVal duracionHoras As Decimal, ByVal nombreProveedor As String, ByVal nitProveedor As String, ByVal codigoDepartamento As String, ByVal codigoMunicipio As String, ByVal tipoPersona As Integer, ByVal noDui As String, ByVal noNrc As String, ByVal direccion As String, ByVal email As String, ByVal telefono As String, ByVal fax As String, ByVal numeroParticipantes As Integer, ByVal tdr As String, ByVal montoAdjudicado As Decimal, ByVal userid As String, ByVal correlativoGrupo As Decimal) As String

        usuario = userid
        Dim lsRet As String = ""

        Try

            Dim lc As New cProcesosPati
            Dim ID_ACCION_FORMATIVA As Decimal
            'Return lc.ProcesarAsignacionGanador(codigoArea, codigoPrograma, nombrePrograma, duracionHoras, nombreProveedor, nitProveedor, codigoDepartamento, codigoMunicipio, tipoPersona, noDui, noNrc, direccion, email, telefono, fax, numeroParticipantes, tdr, montoAdjudicado, userid, correlativoGrupo, ID_ACCION_FORMATIVA)
            lsRet = lc.ProcesarAsignacionGanador(codigoArea, codigoPrograma, nombrePrograma, duracionHoras, nombreProveedor, nitProveedor, codigoDepartamento, codigoMunicipio, tipoPersona, noDui, noNrc, direccion, email, telefono, fax, numeroParticipantes, tdr, montoAdjudicado, userid, correlativoGrupo, ID_ACCION_FORMATIVA)

            If lsRet = "" Then
                Return ProcesarInscripciones(correlativoGrupo, ID_ACCION_FORMATIVA)
            End If

            Return lsRet

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            If lsRet = "" Then
                Return "ERROR AL PROCESAR"
            Else
                Return lsRet
            End If
        End Try

    End Function

    <WebMethod()> _
    Public Function ProcesarCreacionOrdenCompra(ByVal tdr As String, ByVal nitProveedor As String, ByVal resolucion As String, ByVal userid As String) As String
        Dim lc As New cProcesosPati
        Return lc.ProcesarCreacionOrdenCompra(tdr, nitProveedor, resolucion, userid)
    End Function

    <WebMethod()> _
    Public Function ProcesarQuedanFactura(ByVal idFacturaAF As Decimal, ByVal numeroQuedan As Decimal, ByVal userid As String) As String
        Dim lc As New cProcesosPati
        Return lc.ProcesarQuedanFactura(idFacturaAF, numeroQuedan, userid)
    End Function

    <WebMethod()> _
    Public Function ProcesarChequeFactura(ByVal idFacturaAF As Decimal, ByVal numeroCheque As String, ByVal fechaEmision As Date, ByVal userid As String) As String
        Dim lc As New cProcesosPati
        Return lc.ProcesarChequeFactura(idFacturaAF, numeroCheque, fechaEmision, userid)
    End Function

#Region "Metodos Procesar Inscripciones"

    Public Function ProcesarInscripciones(ByVal correlativoGrupo As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal) As String
        Dim lGrupoAccionFormativa As PATI.EL.GRUPO_ACCION_FORMATIVA

        Dim lCriterios As New List(Of PATI.EL.Criteria)
        lCriterios.Add(New PATI.EL.Criteria("CORRELATIVO_SIFP", "=", correlativoGrupo.ToString(), ""))

        Dim listaGrupoAccionFormativa As PATI.EL.listaGRUPO_ACCION_FORMATIVA
        listaGrupoAccionFormativa = (New cGRUPO_ACCION_FORMATIVA).ObtenerListaPorBusqueda(New PATI.EL.GRUPO_ACCION_FORMATIVA, lCriterios.ToArray)

        If Not listaGrupoAccionFormativa Is Nothing Then
            If listaGrupoAccionFormativa.Count > 0 Then
                lGrupoAccionFormativa = listaGrupoAccionFormativa(0)

                Dim listaParticipantes As PATI.EL.listaPARTICIPANTE_POR_AF
                listaParticipantes = (New cPARTICIPANTE_POR_AF).ObtenerListaPorGRUPO_ACCION_FORMATIVA(lGrupoAccionFormativa.ID_GRUPO_AF)

                For Each lParticipante As PATI.EL.PARTICIPANTE_POR_AF In listaParticipantes
                    InscribirParticipante(lParticipante.NUME_FICH, ID_ACCION_FORMATIVA)
                Next

                lGrupoAccionFormativa.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA

                If (New cGRUPO_ACCION_FORMATIVA).ActualizarGRUPO_ACCION_FORMATIVA(lGrupoAccionFormativa) < 0 Then

                End If

            End If
        End If

        Return ""
    End Function

    Private Sub InscribirParticipante(ByVal NUME_FICH As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal)

        Dim bAccionFormativaPATI As New cACCION_FORMATIVA_DETALLE
        Dim lAccionFormativaPATI As ACCION_FORMATIVA_DETALLE = bAccionFormativaPATI.ObtenerACCION_FORMATIVA_DETALLE(ID_ACCION_FORMATIVA)

        Dim lEntidad As PATI.EL.FICHA_PATI = (New PATI.BL.cFICHA_PATI).ObtenerFICHAporFuenteConvocatoria(NUME_FICH, lAccionFormativaPATI.ID_FUENTE, lAccionFormativaPATI.NO_CONVOCATORIA)

        If lEntidad IsNot Nothing Then
            '   Validar que el participante resida en el mismo municipio y sea de la misma convocatoria
            '   que los participantes del curso siempre y cuando no sea la primera inscripción
            Dim lNoConvocatoria As Decimal = 0
            If lAccionFormativaPATI IsNot Nothing Then
                lNoConvocatoria = lAccionFormativaPATI.NO_CONVOCATORIA
                If Not (lEntidad.DEPARTAMENTO_RESIDENCIA = lAccionFormativaPATI.CODIGO_DEPARTAMENTO _
                        And lEntidad.MUNICIPIO_RESIDENCIA = lAccionFormativaPATI.CODIGO_MUNICIPIO) Then
                    ExceptionManager.Publish(New Exception("PARTICIPANTE PERTENECE A OTRO MUNICIPIO" + vbCrLf + "El Participante de la Ficha PATI pertenece a un Municipio diferente de los demás participantes del curso."))
                    Return
                End If
            End If

            Dim lDetaFami As PATI.EL.DETA_FAMI = (New PATI.BL.cDETA_FAMI).ObtenerDETA_FAMIPorFichaFuenteConvocatoria(lEntidad.NUME_FICH, lAccionFormativaPATI.ID_FUENTE, lAccionFormativaPATI.NO_CONVOCATORIA)
            If lNoConvocatoria = 0 Then lNoConvocatoria = lDetaFami.NO_CONVOCATORIA
            If lNoConvocatoria <> lDetaFami.NO_CONVOCATORIA Then
                ExceptionManager.Publish(New Exception("PARTICIPANTE PERTENECE A OTRA CONVOCATORIA" + vbCrLf + "El Participante de la Ficha PATI pertenece a una Convocatoria diferente de los demás participantes del curso."))
                Return
            End If


            If lDetaFami.ESTA = "A" Then

            Else
                ExceptionManager.Publish(New Exception("CONVENIO NO FIRMADO POR PARTICIPANTE" + vbCrLf + "Verificar con el FISDL las Altas\Bajas. Por favor revise."))
                Return
            End If

            If lEntidad.ID_PARTICIPANTE <> -1 Then
                '   Comprobar si el participante esta inscrito en el curso
                If ObtenerCantidadParticipanteEnCurso(ID_ACCION_FORMATIVA, lEntidad.ID_PARTICIPANTE) > 0 Then
                    ExceptionManager.Publish(New Exception("PARTICIPANTE ESTA INSCRITO EN ESTE CURSO" + vbCrLf + "El Participante de la Ficha PATI ya se encuentra inscrito en este Grupo. Por favor revise."))
                    Return
                End If

                '   Evaluar al participante dentro del programa PATI
                Dim lRet As Integer = EvaluarParticipantePATI(lEntidad.ID_PARTICIPANTE, NUME_FICH, ID_ACCION_FORMATIVA)
                If lRet <> 1 Then
                    Return
                End If
            End If

            CrearSolicitudFichaPATI(NUME_FICH, ID_ACCION_FORMATIVA)

        End If
    End Sub

    Private Function CrearSolicitudFichaPATI(ByVal NUME_FICH As Integer, ByVal ID_ACCION_FORMATIVA As Decimal) As String
        Dim bFichaPATI As New cFICHA_PATI
        Dim eFichaPATI As PATI.EL.FICHA_PATI

        Dim bSolicitud As New cSOLICITUD_INSCRIPCION_AF
        Dim eSolicitud As New SOLICITUD_INSCRIPCION_AF
        Dim eParticipante As New PARTICIPANTE
        Dim eAccionFormativa As New ACCION_FORMATIVA
        Dim eAccionFormativaDetalle As New ACCION_FORMATIVA_DETALLE
        eAccionFormativaDetalle = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(ID_ACCION_FORMATIVA)

        eFichaPATI = bFichaPATI.ObtenerFICHAporFuenteConvocatoria(NUME_FICH, eAccionFormativaDetalle.ID_FUENTE, eAccionFormativaDetalle.NO_CONVOCATORIA)
        If eFichaPATI Is Nothing Then

            If bFichaPATI.AgregarFichaPatiDesdeFichaFISDL(eFichaPATI.NUME_FICH, eAccionFormativaDetalle.ID_FUENTE, eAccionFormativaDetalle.NO_CONVOCATORIA) <> 1 Then
                ExceptionManager.Publish(New Exception(bFichaPATI.sError + vbCrLf + bFichaPATI.sErrorTecnico))
                Return "Error al Agregar Ficha PATI. " + bSolicitud.sError
            End If
            eFichaPATI = bFichaPATI.ObtenerFICHAporFuenteConvocatoria(NUME_FICH, eAccionFormativaDetalle.ID_FUENTE, eAccionFormativaDetalle.NO_CONVOCATORIA)
        End If

        With eSolicitud
            .ID_SOLICITUD = 0
            eAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(ID_ACCION_FORMATIVA)
            .ID_TIPO_SOLICITUD = Utilerias.ObtenerTipoSolicitudPorProgramaFormacion(CInt((New cACCION_FORMATIVA).ObtenerProgramaFormacionCurso(ID_ACCION_FORMATIVA)))
            .FECHA_PRESENTACION = eAccionFormativa.FECHA_INICIO_REAL
            .ID_ESTADO_SOLICITUD = Enumeradores.EstadoSolicitud.EnEsperaDeAprobacion
            .ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            .ID_PARTICIPANTE = 0
            .NOMBRES = String.Concat(eFichaPATI.PRIMER_NOMBRE, " ", eFichaPATI.SEGUNDO_NOMBRE, " ", eFichaPATI.TERCER_NOMBRE).Trim
            .APELLIDOS = String.Concat(eFichaPATI.PRIMER_APELLIDO, " ", eFichaPATI.SEGUNDO_APELLIDO).Trim
            Select Case True
                Case eFichaPATI.ID_PARTICIPANTE <> -1
                    eParticipante = (New cPARTICIPANTE).ObtenerPARTICIPANTE(eFichaPATI.ID_PARTICIPANTE)
                    If eParticipante IsNot Nothing AndAlso eParticipante.ID_PARTICIPANTE > 0 Then
                        .ID_PARTICIPANTE = eParticipante.ID_PARTICIPANTE
                    End If

                Case eFichaPATI.DUI.Trim <> ""
                    Dim listaPart As listaPARTICIPANTE
                    listaPart = (New cPARTICIPANTE).ObtenerListaPorDUI(eFichaPATI.DUI.Trim)

                    If listaPart IsNot Nothing AndAlso listaPart.Count > 0 Then
                        If listaPart(0).NOMBRES.Trim <> .NOMBRES.Trim OrElse listaPart(0).APELLIDOS.Trim <> .APELLIDOS.Trim Then
                            Return "Ya existe un perfil de participante con el mismo DUI pero con diferente Nombre/Apellido"
                        End If
                        .ID_PARTICIPANTE = listaPart(0).ID_PARTICIPANTE
                    End If
            End Select

            If .ID_PARTICIPANTE > 0 Then
                Dim lRet As Integer = EvaluarParticipantePATI(.ID_PARTICIPANTE, NUME_FICH, .ID_ACCION_FORMATIVA)
                If lRet <> 1 Then
                    Return "Participante no aprueba Evaluacion"
                End If
            End If

            '   ***     SECCIÓN 1. DATOS DE IDENTIFICACIÓN          
            .DUI = Leer_Valor(eFichaPATI.DUI).Trim
            .NIT = ""
            .ISSS = ""
            If eFichaPATI.CARNET_MINORIDAD IsNot Nothing AndAlso eFichaPATI.CARNET_MINORIDAD.Trim <> "" Then
                .NUM_DOCTO = eFichaPATI.CARNET_MINORIDAD.Trim
                .TIPO_DOCTO = 1
            ElseIf eFichaPATI.PASAPORTE IsNot Nothing AndAlso eFichaPATI.PASAPORTE.Trim <> "" Then
                .NUM_DOCTO = eFichaPATI.PASAPORTE.Trim
                .TIPO_DOCTO = 2
            Else
                .NUM_DOCTO = ""
                .TIPO_DOCTO = -1
            End If
            .ID_PAIS = eFichaPATI.PAIS
            .DEPARTAMENTO_NAC = eFichaPATI.DEPARTAMENTO_NACIMIENTO
            .MUNICIPIO_NAC = eFichaPATI.MUNICIPIO_NACIMIENTO
            .FECHA_NACIMIENTO = eFichaPATI.FECHA_NACIMIENTO
            If eFichaPATI.SEXO = 1 Then
                .GENERO = "M"
            Else
                .GENERO = "F"
            End If
            .EDAD = eFichaPATI.EDAD
            .MIEMBROS_GRUPO_FAMILIAR = eFichaPATI.PERSONAS_GRUPO_FAMILIAR
            .ID_ESTADO_CIVIL = eFichaPATI.ESTADO_FAMILIAR
            Select Case eFichaPATI.ES_JEFE_DE_HOGAR
                Case 1 To 3
                    .ES_JEFE_HOGAR = eFichaPATI.ES_JEFE_DE_HOGAR
                Case Else
                    .ES_JEFE_HOGAR = -1
            End Select
            Select Case eFichaPATI.TIENE_HIJOS
                Case 1
                    .TIENE_HIJOS = 1
                    .NO_DE_HIJOS = eFichaPATI.NO_DE_HIJOS
                Case 2
                    .TIENE_HIJOS = 2
                    .NO_DE_HIJOS = -1
                Case Else
                    .TIENE_HIJOS = -1
                    .NO_DE_HIJOS = -1
            End Select
            Select Case eFichaPATI.SE_DEDICA_ALGUNA_PROFESION
                Case 1
                    .SE_DEDICA_ALGUNA_PROFESION = 1
                    .PROFESION_OFICIO = Leer_Valor(eFichaPATI.PROFESION_SE_DEDICA).Trim
                Case Else
                    .SE_DEDICA_ALGUNA_PROFESION = 2
                    .PROFESION_OFICIO = ""
            End Select
            .DIRECCION = eFichaPATI.DIRECCION
            .CODIGO_DEPARTAMENTO = Leer_Valor(eFichaPATI.DEPARTAMENTO_RESIDENCIA)
            .CODIGO_MUNICIPIO = Leer_Valor(eFichaPATI.MUNICIPIO_RESIDENCIA)
            .TELEFONO = Leer_Valor(eFichaPATI.TELEFONO_FIJO).Trim
            .MOVIL = Leer_Valor(eFichaPATI.TELEFONO_MOVIL).Trim
            .EMAIL = Leer_Valor(eFichaPATI.CORREO_ELECTRONICO).Trim

            If eFichaPATI.DISCAPACITADO_PERMANENTE = 1 AndAlso _
              (eFichaPATI.DISCAP_MOVERSE_CAMINAR = 1 OrElse eFichaPATI.DISCAP_USAR_BRAZOS = 1 OrElse _
                eFichaPATI.DISCAP_VER = 1 OrElse eFichaPATI.DISCAP_OIR OrElse eFichaPATI.DISCAP_HABLAR = 1 OrElse _
                eFichaPATI.DISCAP_RETRASO = 1 OrElse eFichaPATI.DISCAP_BANARSE = 1 OrElse Leer_Valor(eFichaPATI.DISCAP_EXPLIQUE).Trim <> "") Then
                .CON_DISCAPACIDAD = 1
                .DISC_OTRA = Leer_Valor(eFichaPATI.DISCAP_EXPLIQUE).Trim
                .DISCA_POR_SOLICITUDSOLICITUD_INSCRIPCION_AF = AsignarDiscapacidadesSeleccionadas(eFichaPATI)
            Else
                .CON_DISCAPACIDAD = 2
            End If

            '   ***     SECCIÓN 2. EDUCACIÓN FORMAL Y FORMACIÓN OCUPACIONAL
            If eFichaPATI.SABE_LEER_ESCRIBIR = 1 Then
                .ID_LEE_ESCRIBE = 1
            ElseIf eFichaPATI.SOLO_ESCRIBE = 1 AndAlso eFichaPATI.SOLO_FIRMA = 1 Then
                .ID_LEE_ESCRIBE = 6
            ElseIf eFichaPATI.SOLO_LEE = 1 AndAlso eFichaPATI.SOLO_FIRMA = 1 Then
                .ID_LEE_ESCRIBE = 5
            ElseIf eFichaPATI.SOLO_FIRMA = 1 Then
                .ID_LEE_ESCRIBE = 4
            ElseIf eFichaPATI.SOLO_ESCRIBE = 1 Then
                .ID_LEE_ESCRIBE = 3
            ElseIf eFichaPATI.SOLO_LEE = 1 Then
                .ID_LEE_ESCRIBE = 2
            Else
                .ID_LEE_ESCRIBE = 1
            End If

            If eFichaPATI.UNIVERSITARIA = 1 Then
                .ID_NIVEL_ACADEMICO = 23
            ElseIf eFichaPATI.UNIVERSITARIA = 2 Then
                .ID_NIVEL_ACADEMICO = 22
            ElseIf eFichaPATI.TECNOLOGICA = 1 Then
                .ID_NIVEL_ACADEMICO = 21
            ElseIf eFichaPATI.TECNOLOGICA = 2 Then
                .ID_NIVEL_ACADEMICO = 20
            ElseIf eFichaPATI.BACHILLERATO = 1 Then
                .ID_NIVEL_ACADEMICO = 19
            ElseIf eFichaPATI.BACHILLERATO = 2 Then
                .ID_NIVEL_ACADEMICO = 18
            ElseIf eFichaPATI.EDUCACION_BASICA >= 1 AndAlso eFichaPATI.EDUCACION_BASICA <= 10 Then
                .ID_NIVEL_ACADEMICO = eFichaPATI.EDUCACION_BASICA + 7
            Else
                .ID_NIVEL_ACADEMICO = 8
            End If

            .OTRA_EDUCACION_FORMAL = Leer_Valor(eFichaPATI.OTRA_EDUCACION_FORMAL).Trim
            .TITULO_CERTIFICADO_OBTENIDO = Leer_Valor(eFichaPATI.TITULO_OBTENIDO).Trim

            If eFichaPATI.HA_DEJADO_DE_ESTUDIAR = 1 Then
                .ESTUDIA_ACTUALMENTE = 2
                Select Case eFichaPATI.TIEMPO_DEJO_ESTUDIAR
                    Case 1
                        .ID_TIEMPO_DEJO_ESTUDIAR = 4
                    Case 2
                        .ID_TIEMPO_DEJO_ESTUDIAR = 5
                    Case 3
                        .ID_TIEMPO_DEJO_ESTUDIAR = 3
                    Case 4
                        .ID_TIEMPO_DEJO_ESTUDIAR = 6
                    Case Else
                        .ID_TIEMPO_DEJO_ESTUDIAR = 6
                End Select
            ElseIf eFichaPATI.HA_DEJADO_DE_ESTUDIAR = 2 Then
                .ESTUDIA_ACTUALMENTE = 1
                .ID_TIEMPO_DEJO_ESTUDIAR = -1
            Else
                .ESTUDIA_ACTUALMENTE = 1
                .ID_TIEMPO_DEJO_ESTUDIAR = -1
            End If

            If eFichaPATI.HA_RECIBIDO_CURSOS = 1 OrElse eFichaPATI.HA_RECIBIDO_CURSOS = 2 Then
                .RECIBIO_CURSO_ANTERIOR = eFichaPATI.HA_RECIBIDO_CURSOS
            Else
                .RECIBIO_CURSO_ANTERIOR = 2
            End If
            .BENEF_CAMB_EMP_X_CURSO = eFichaPATI.SIRVIO_CAPAC_CAMBIAR_EMPLEO
            .BENEF_OBT_EMPLEO = eFichaPATI.SIRVIO_CAPAC_OBTENER_EMPLEO
            .BENEF_OBT_ING_EXTRA = eFichaPATI.SIRVIO_CAPAC_OTROS_INGRESOS
            .BENEF_OTRO = eFichaPATI.SIRVIO_CAPAC_OTRO
            .BENEF_PROM_EMP_ACT = eFichaPATI.SIRVIO_CAPAC_PROMOCION
            .BENEF_TRAB_CTA_PROPIA = eFichaPATI.SIRVIO_CAPAC_TRAB_CTA_PROPIA
            .RAZON_NO_BENEFICIO = Leer_Valor(eFichaPATI.PORQUE_NO_RECIB_BENEFICIO).Trim

            '   ***     SECCIÓN 3. INFORMACIÓN SOBRE SU SITUACIÓN LABORAL
            .OCUACT_ESTUDIA = eFichaPATI.OTRA_ACTIVIDAD_ESTUDIA
            .OCUACT_OFICIO_HOGAR = eFichaPATI.OTRA_ACTIVIDAD_OFICIOS_HOGAR
            .OCUACT_TRABAJA = (eFichaPATI.MAN_OBTIENE_ING_TRAB_ACT = 1 OrElse eFichaPATI.MAN_OBTIENE_ING_TRAB_ACT_REM = 1)
            .OCUACT_BUSCA_TRABAJO = eFichaPATI.OTRA_ACTIVIDAD_BUSCA_TRABAJO
            .OCUACT_OTRA = Leer_Valor(eFichaPATI.OTRA_ACTIVIDAD_OTRA).Trim

            If eFichaPATI.TIPO_DE_EMPLEO_TIEMPO_COMP = 1 Then
                .ID_TIPO_EMPLEO = 1
            ElseIf eFichaPATI.TIPO_DE_EMPLEO_MEDIO_TIEMPO = 1 Or eFichaPATI.TIPO_DE_EMPLEO_POR_HORAS = 1 Then
                .ID_TIPO_EMPLEO = 2
            ElseIf eFichaPATI.TIPO_DE_EMPLEO_TEMPORAL = 1 Then
                .ID_TIPO_EMPLEO = 3
            ElseIf eFichaPATI.TIPO_DE_EMPLEO_NEG_FAMILIAR = 1 Then
                .ID_TIPO_EMPLEO = 4
            ElseIf eFichaPATI.TIPO_DE_EMPLEO_CTA_PROPIA = 1 Then
                .ID_TIPO_EMPLEO = 5
            ElseIf Leer_Valor(eFichaPATI.TIPO_DE_EMPLEO_OTRO).Trim <> "" Then
                .ID_TIPO_EMPLEO = 7
                .TIPO_EMPLEO_OTRO = Leer_Valor(eFichaPATI.TIPO_DE_EMPLEO_OTRO).Trim
            Else
                .ID_TIPO_EMPLEO = -1
            End If
            .SECTOR_EMPLEO = -1

            If eFichaPATI.HA_TRABAJADO_ANTES = 1 AndAlso eFichaPATI.TIEMPO_QUE_NO_TRABAJA <> -1 Then
                .TRABAJO_ANTERIOR = "S"
            Else
                .TRABAJO_ANTERIOR = "N"
            End If

            '   ***     SECCIÓN 4. INFORMACIÓN SOBRE LOS INGRESOS
            Select Case CInt(eFichaPATI.RECIBE_INGRESOS)
                Case 1, 2
                    .RECIBE_INGRESOS = eFichaPATI.RECIBE_INGRESOS
                Case Else
                    .RECIBE_INGRESOS = -1
            End Select
            .MANERA_OBT_ING_AYUDA_FAM = eFichaPATI.MAN_OBTIENE_ING_AYUDA_FAM
            .MANERA_OBT_ING_PENSION = eFichaPATI.MAN_OBTIENE_ING_PENSION
            .MANERA_OBT_ING_REMESA = eFichaPATI.MAN_OBTIENE_ING_REMESA
            .MANERA_OBT_ING_TRABAJO = eFichaPATI.MAN_OBTIENE_ING_TRAB_ACT
            .MANERA_OBT_ING_OTRO = Leer_Valor(eFichaPATI.MAN_OBTIENE_ING_OTRA).Trim

            '   ***     SECCIÓN 5. EXPECTATIVAS RESPECTO A LA FORMACIÓN - EXPECTATIVAS LABORALES
            .EXPFOR_OBTENER_EMPLEO = eFichaPATI.LOGROS_ESPERADOS_EMPLEO_FORMAL
            .EXPFOR_TRABAJAR_CTA_PROPIA = eFichaPATI.LOGROS_ESPERADOS_CUENTA_PROPIA
            .EXPFOR_OTRO = Leer_Valor(eFichaPATI.LOGROS_ESPERADOS_OTRO).Trim

            .CURSO_REL_TRAB_NUEVO = 1

            '   ***     SECCIÓN 6. SEGUIMIENTO
            .NOMBRE_REFERENCIA = eFichaPATI.NOMBRES_CONOCIDO
            Select Case eFichaPATI.PARENTESCO
                Case 1
                    .ID_REFERENCIA = 26
                Case 2
                    .ID_REFERENCIA = 2
                Case Else
                    .ID_REFERENCIA = 16
            End Select
            .DIRECCION_REFERENCIA = Leer_Valor(eFichaPATI.DIRECCION_CONOCIDO).Trim
            .DEPARTAMENTO_REFERENCIA = Leer_Valor(eFichaPATI.DEPARTAMENTO_CONOCIDO).Trim
            .MUNICIPIO_REFERENCIA = Leer_Valor(eFichaPATI.MUNICIPIO_CONOCIDO)
            .TELEFONO_REFERENCIA = Leer_Valor(eFichaPATI.TELEFONO_FIJO_CONOCIDO).Trim
            .MOVIL_REFERENCIA = Leer_Valor(eFichaPATI.TELEFONO_MOVIL).Trim
            .EMAIL_REFERENCIA = Leer_Valor(eFichaPATI.EMAIL_CONOCIDO).Trim
            .SUGERENCIAS = Leer_Valor(eFichaPATI.OBSERVACIONES_SUGERENCIAS).Trim
            .USERID = Me.usuario
            .LASTUPDATE = Now

            If bSolicitud.ActualizarSOLICITUD_INSCRIPCION_AF(eSolicitud, TipoConcurrencia.Pesimistica, .SUGERENCIAS) <> 1 Then
                ExceptionManager.Publish(New Exception(bSolicitud.sError + vbCrLf + bSolicitud.sErrorTecnico))
                Return "Error al Inscribir al Participante." + bSolicitud.sError
            Else
                eFichaPATI.ID_PARTICIPANTE = eSolicitud.ID_PARTICIPANTE
                eFichaPATI.USERID = Me.usuario
                eFichaPATI.LASTUPDATE = Now
                bFichaPATI.ActualizarFICHA_PATI(eFichaPATI)
            End If

            '       Cursos de capacitación recibidos
            GuardarCursoRecibidos(eSolicitud.ID_SOLICITUD, eFichaPATI)

            '       Empleo Anterior
            GuardarEmpleoAnterior(eSolicitud.ID_SOLICITUD, eFichaPATI)
        End With

        Return ""
    End Function

    Private Function ObtenerCantidadParticipanteEnCurso(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_PARTICIPANTE As Decimal) As Decimal
        Dim Detalle As listaSOLICITUD_INSCRIPCION_AF
        Dim criterios As New List(Of SGAFP.EL.Criteria)

        criterios.Add(New SGAFP.EL.Criteria("ID_ACCION_FORMATIVA", "=", ID_ACCION_FORMATIVA, " AND "))
        criterios.Add(New SGAFP.EL.Criteria("ID_PARTICIPANTE", "=", ID_PARTICIPANTE, ""))
        Detalle = (New cSOLICITUD_INSCRIPCION_AF).ObtenerListaPorBusqueda(New SOLICITUD_INSCRIPCION_AF, criterios.ToArray)

        If Detalle IsNot Nothing Then
            Return Detalle.Count
        End If
        Return 0
    End Function

    Private Function EvaluarParticipantePATI(ByVal ID_PARTICIPANTE As Decimal, ByVal NUME_FICH As Decimal, ByVal ID_ACCION_FORMATIVA_INSCRIBIRSE As Decimal) As Integer
        Dim lAccionInscribirse As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(ID_ACCION_FORMATIVA_INSCRIBIRSE)
        Dim sMensaje As New StringBuilder

        Select Case EstadoParticipanteProgramaPATI(ID_PARTICIPANTE)
            Case 1  '   En Informe Final (Asistencia >= 70%)
                If Me.AccionFormativaInscrito.ID_PROVEEDOR_AF = lAccionInscribirse.ID_PROVEEDOR_AF Then
                    sMensaje.AppendLine("PARTICIPANTE DEL PROGRAMA PATI HA SIDO CAPACITADO")
                    sMensaje.AppendLine("El Participante se ha reportado como capacitado en:")
                    sMensaje.AppendLine("Curso: " + AccionFormativaInscrito.NOMBRE_ACCION_FORMATIVA)
                    sMensaje.AppendLine("Codigo Grupo: " + AccionFormativaInscrito.CODIGO_GRUPO)
                    sMensaje.AppendLine("Inicio: " + AccionFormativaInscrito.FECHA_INICIO_REAL.ToString("dd/MM/yyyy"))
                    sMensaje.AppendLine("Finalizacion: " + AccionFormativaInscrito.FECHA_FIN_REAL.ToString("dd/MM/yyyy"))
                    ExceptionManager.Publish(New Exception(sMensaje.ToString()))
                    'cDispoCURSOS.JSProperties("cpResultCallback") = sMensaje.ToString
                    'cDispoCURSOS.JSProperties("cpAjustarAnchoPopup") = True
                Else
                    sMensaje.AppendLine("PARTICIPANTE DEL PROGRAMA PATI HA SIDO CAPACITADO")
                    sMensaje.AppendLine("El Participante se ha reportado como capacitado.")
                    ExceptionManager.Publish(New Exception(sMensaje.ToString()))
                    'cDispoCURSOS.JSProperties("cpResultCallback") = sMensaje.ToString
                End If
                Return -1

            Case 2  '   Inscrito, sin Informe Final
                If Me.AccionFormativaInscrito.ID_PROVEEDOR_AF = lAccionInscribirse.ID_PROVEEDOR_AF Then
                    sMensaje.AppendLine("PARTICIPANTE ESTA INSCRITO EN OTRO GRUPO")
                    sMensaje.AppendLine("El Participante de la Ficha PATI ya se encuentra inscrito en:")
                    sMensaje.AppendLine("Curso: " + AccionFormativaInscrito.NOMBRE_ACCION_FORMATIVA)
                    sMensaje.AppendLine("Codigo Grupo: " + AccionFormativaInscrito.CODIGO_GRUPO)
                    sMensaje.AppendLine("Inicio: " + AccionFormativaInscrito.FECHA_INICIO_REAL.ToString("dd/MM/yyyy"))
                    sMensaje.AppendLine("Finalizacion: " + AccionFormativaInscrito.FECHA_FIN_REAL.ToString("dd/MM/yyyy"))
                    sMensaje.AppendLine("Cambie de grupo al participante para poder inscribirlo.")
                    ExceptionManager.Publish(New Exception(sMensaje.ToString()))
                Else
                    sMensaje.AppendLine("PARTICIPANTE ESTA INSCRITO EN OTRO GRUPO")
                    sMensaje.AppendLine("El Participante de la Ficha PATI ya se encuentra inscrito en otro Grupo de Capacitacion.")
                    ExceptionManager.Publish(New Exception(sMensaje.ToString()))
                End If
                Return -1

            Case 3  '   En Informe Final (Asistencia < 70%)
                Dim lParticipanteAf As PARTICIPANTE_AF
                lParticipanteAf = (New cPARTICIPANTE_AF).ObtenerPARTICIPANTE_AF(ID_PARTICIPANTE, Me.AccionFormativaInscrito.ID_ACCION_FORMATIVA)

                Dim eAccionFormativaDetalle As New ACCION_FORMATIVA_DETALLE
                eAccionFormativaDetalle = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(Me.AccionFormativaInscrito.ID_ACCION_FORMATIVA)

                'Determinar la Convocatoria del Curso en la que se inscribió el participante y en la que se inscribirá                
                Dim lNo_ConvocatoriaInscribio As Decimal = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(Me.AccionFormativaInscrito.ID_ACCION_FORMATIVA).NO_CONVOCATORIA
                Dim lNo_ConvocatoriaInscribirse As Decimal = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(ID_ACCION_FORMATIVA_INSCRIBIRSE).NO_CONVOCATORIA

                If lParticipanteAf IsNot Nothing AndAlso lParticipanteAf.ID_SOLICITUD > 0 AndAlso lParticipanteAf.PORC_ASISTENCIA < 70 Then
                    If lNo_ConvocatoriaInscribio = lNo_ConvocatoriaInscribirse Then
                        Dim lbSolicitud As New cSOLICITUD_INSCRIPCION_AF
                        Dim lSolicitud As SOLICITUD_INSCRIPCION_AF = lbSolicitud.ObtenerSOLICITUD_INSCRIPCION_AF(lParticipanteAf.ID_SOLICITUD)
                        lSolicitud.ID_ESTADO_SOLICITUD = EstadoSolicitud.CambioDeCursoPorSistema
                        lSolicitud.LASTUPDATE = Now
                        lSolicitud.USERID = Me.usuario
                        If lbSolicitud.ActualizarSOLICITUD_INSCRIPCION_AF(lSolicitud, TipoConcurrencia.Pesimistica, "CAMBIO DE GRUPO GENERADO POR EL SISTEMA. PARTICIPANTE SE INSCRIBE EN CURSO: " + lAccionInscribirse.NOMBRE_ACCION_FORMATIVA + "  ID: " + lAccionInscribirse.ID_ACCION_FORMATIVA.ToString + "  CODIGO: " + lAccionInscribirse.CODIGO_GRUPO) <> 1 Then
                            sMensaje.AppendLine("Error al intentar Cambiar de Grupo al Participante Automaticamente.")
                            ExceptionManager.Publish(New Exception(sMensaje.ToString()))
                            'cDispoCURSOS.JSProperties("cpResultCallback") = sMensaje.ToString
                            Return -1
                        End If
                    End If
                End If
        End Select
        Return 1
    End Function

    Private Function Leer_Valor(ByVal valor As String) As String
        If valor Is Nothing Then
            valor = ""
        End If
        Return valor
    End Function

    'Devuelve el estado en el que se encuentra un participante en el Programa PATI
    '0: No capacitado
    '1: En Informe Final (Asistencia >= 70%)
    '2: Inscrito, sin Informe Final
    '3: En Informe Final (Asistencia < 70%)
    Private Function EstadoParticipanteProgramaPATI(ByVal ID_PARTICIPANTE As Decimal) As Integer
        Dim lResultados As New Dictionary(Of Integer, ACCION_FORMATIVA)
        Dim listaSolicitudes As listaSOLICITUD_INSCRIPCION_AF
        Dim lProgramas As New List(Of Decimal)
        lProgramas.Add(Enumeradores.ProgramasFormacion.PATI_USAID)
        lProgramas.Add(Enumeradores.ProgramasFormacion.PATI_BM)
        listaSolicitudes = (New cSOLICITUD_INSCRIPCION_AF).ObtenerListaPorPARTICIPANTE_INSCRITOS_TIPO_SOLICITUD(ID_PARTICIPANTE, lProgramas)

        If listaSolicitudes IsNot Nothing AndAlso listaSolicitudes.Count > 0 Then
            For Each _Solic As SOLICITUD_INSCRIPCION_AF In listaSolicitudes
                Dim lAccionFormativaInscrito As ACCION_FORMATIVA
                lAccionFormativaInscrito = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(_Solic.ID_ACCION_FORMATIVA)

                'Si el Curso no se encuentra INGRESADO, MATRICULA, INICIADO, FINALIZADO, EN SOLIC. REPROGRAMACION
                'entonces el Centro ha presentado Informe Final, verificar si el % de Asistencia es mayor o igual al 80%
                If Not (lAccionFormativaInscrito.CODIGO_ESTADO_AF = EstadoAccionFormativa.Ingresada OrElse _
                   lAccionFormativaInscrito.CODIGO_ESTADO_AF = EstadoAccionFormativa.EnMatricula OrElse _
                   lAccionFormativaInscrito.CODIGO_ESTADO_AF = EstadoAccionFormativa.Iniciada OrElse _
                   lAccionFormativaInscrito.CODIGO_ESTADO_AF = EstadoAccionFormativa.Finalizada OrElse _
                   lAccionFormativaInscrito.CODIGO_ESTADO_AF = EstadoAccionFormativa.EnSolicitudDeReprogramacion) Then

                    Dim lCriterios As New List(Of Criteria)
                    Dim lDetalleInformeFinal As listaINFORME_FINAL_DET

                    lCriterios.Add(New Criteria("ID_ACCION_FORMATIVA", "=", _Solic.ID_ACCION_FORMATIVA, "AND"))
                    lCriterios.Add(New Criteria("ID_PARTICIPANTE", "=", _Solic.ID_PARTICIPANTE, ""))
                    lDetalleInformeFinal = (New cINFORME_FINAL_DET).ObtenerListaPorBusqueda(New INFORME_FINAL_DET, lCriterios.ToArray)

                    If lDetalleInformeFinal IsNot Nothing AndAlso lDetalleInformeFinal.Count > 0 Then
                        For Each lDetaParticipante As INFORME_FINAL_DET In lDetalleInformeFinal
                            If lDetaParticipante.PORC_ASISTENCIA >= 70 Then
                                If Not lResultados.ContainsKey(1) Then lResultados.Add(1, lAccionFormativaInscrito)
                            Else
                                If Not lResultados.ContainsKey(3) Then lResultados.Add(3, lAccionFormativaInscrito)
                            End If
                        Next
                    End If
                Else
                    Dim lCriterios As New List(Of Criteria)
                    Dim lDetalleParticipante As listaPARTICIPANTE_AF

                    lCriterios.Add(New Criteria("ID_ACCION_FORMATIVA", "=", _Solic.ID_ACCION_FORMATIVA, "AND"))
                    lCriterios.Add(New Criteria("ID_PARTICIPANTE", "=", _Solic.ID_PARTICIPANTE, ""))
                    lDetalleParticipante = (New cPARTICIPANTE_AF).ObtenerListaPorBusqueda(New PARTICIPANTE_AF, lCriterios.ToArray)

                    If lDetalleParticipante IsNot Nothing AndAlso lDetalleParticipante.Count > 0 Then
                        If Not lResultados.ContainsKey(2) Then lResultados.Add(2, lAccionFormativaInscrito)
                    End If
                End If
            Next
        End If

        If lResultados.ContainsKey(1) Then
            Me.AccionFormativaInscrito = lResultados(1)
            Return 1
        ElseIf lResultados.ContainsKey(2) Then
            Me.AccionFormativaInscrito = lResultados(2)
            Return 2
        ElseIf lResultados.ContainsKey(3) Then
            Me.AccionFormativaInscrito = lResultados(3)
            Return 3
        Else
            Return 0
        End If
    End Function

    Dim _AccionFormativaInscrito As ACCION_FORMATIVA
    Private Property AccionFormativaInscrito() As ACCION_FORMATIVA
        Get
            Return _AccionFormativaInscrito
        End Get
        Set(ByVal value As ACCION_FORMATIVA)
            _AccionFormativaInscrito = value
        End Set
    End Property

    Private Function AsignarDiscapacidadesSeleccionadas(ByVal eFichaPATI As PATI.EL.FICHA_PATI) As listaDISCA_POR_SOLICITUD
        Dim listaDiscapacidades As New listaDISCA_POR_SOLICITUD
        Dim DiscSeleccionada As Boolean

        For IdDiscap As Integer = 1 To 8
            Select Case IdDiscap
                Case 1
                    DiscSeleccionada = (eFichaPATI.DISCAP_MOVERSE_CAMINAR = 1)
                Case 2
                    DiscSeleccionada = (eFichaPATI.DISCAP_USAR_BRAZOS = 1)
                Case 3
                    DiscSeleccionada = (eFichaPATI.DISCAP_VER = 1)
                Case 4
                    DiscSeleccionada = (eFichaPATI.DISCAP_OIR = 1)
                Case 5
                    DiscSeleccionada = (eFichaPATI.DISCAP_HABLAR = 1)
                Case 6
                    DiscSeleccionada = (eFichaPATI.DISCAP_RETRASO = 1)
                Case 7
                    DiscSeleccionada = (eFichaPATI.DISCAP_BANARSE = 1)
                Case 8
                    DiscSeleccionada = (eFichaPATI.DISCAP_EXPLIQUE.Trim <> "")
                Case Else
                    DiscSeleccionada = False
            End Select

            If DiscSeleccionada Then
                Dim DiscapSolic As New DISCA_POR_SOLICITUD
                DiscapSolic.ID_SOLICITUD = 0
                DiscapSolic.ID_DISCAPACIDAD = IdDiscap

                listaDiscapacidades.Add(DiscapSolic)
            End If
        Next

        Return listaDiscapacidades
    End Function

    Private Sub GuardarCursoRecibidos(ByVal ID_SOLICITUD As Decimal, ByVal eFichaPATI As PATI.EL.FICHA_PATI)
        Dim bCursos As New cSOLIC_CURSOS_RECIBIDOS
        Dim eCurso As SOLIC_CURSOS_RECIBIDOS

        If eFichaPATI.HA_RECIBIDO_CURSOS = 1 AndAlso (eFichaPATI.CURSO_1 <> "" OrElse eFichaPATI.CURSO_2 <> "" OrElse eFichaPATI.CURSO_3 <> "") Then
            If eFichaPATI.CURSO_1 <> "" AndAlso (eFichaPATI.IMPARTIO_INSAFORP_CURSO_1 = 1 Or eFichaPATI.IMPARTIO_INSAFORP_CURSO_1 = 2 Or eFichaPATI.IMPARTIO_INSAFORP_CURSO_1 = 2) AndAlso _
                eFichaPATI.ANO_CURSO_1 <> 0 AndAlso (eFichaPATI.CURSO_LE_DIO_BENEFICIOS_1 = 1 Or eFichaPATI.CURSO_LE_DIO_BENEFICIOS_1 = 2 Or eFichaPATI.CURSO_LE_DIO_BENEFICIOS_1 = 3) Then

                eCurso = New SOLIC_CURSOS_RECIBIDOS
                eCurso.ID_CURSO_RECIBIDO = 0
                eCurso.ID_SOLICITUD = ID_SOLICITUD
                eCurso.NOMBRE_CURSO = eFichaPATI.CURSO_1
                eCurso.APOYO_INSAFORP = eFichaPATI.IMPARTIO_INSAFORP_CURSO_1
                eCurso.ANIO = eFichaPATI.ANO_CURSO_1
                eCurso.BENEFICIO_CURSO = eFichaPATI.CURSO_LE_DIO_BENEFICIOS_1
                If bCursos.ActualizarSOLIC_CURSOS_RECIBIDOS(eCurso) <> 1 Then
                    ExceptionManager.Publish(New Exception(bCursos.sError + vbCrLf + bCursos.sErrorTecnico))
                    'Me.AsignarMensaje("Error al Guardar Curso Recibido. " + vbCrLf + bCursos.sError, True, True)
                End If
            End If

            If eFichaPATI.CURSO_2 <> "" AndAlso (eFichaPATI.IMPARTIO_INSAFORP_CURSO_2 = 1 Or eFichaPATI.IMPARTIO_INSAFORP_CURSO_2 = 2 Or eFichaPATI.IMPARTIO_INSAFORP_CURSO_2 = 2) AndAlso _
                eFichaPATI.ANO_CURSO_2 <> 0 AndAlso (eFichaPATI.CURSO_LE_DIO_BENEFICIOS_2 = 1 Or eFichaPATI.CURSO_LE_DIO_BENEFICIOS_2 = 2 Or eFichaPATI.CURSO_LE_DIO_BENEFICIOS_2 = 3) Then

                eCurso = New SOLIC_CURSOS_RECIBIDOS
                eCurso.ID_SOLICITUD = ID_SOLICITUD
                eCurso.NOMBRE_CURSO = eFichaPATI.CURSO_2
                eCurso.APOYO_INSAFORP = eFichaPATI.IMPARTIO_INSAFORP_CURSO_2
                eCurso.ANIO = eFichaPATI.ANO_CURSO_2
                eCurso.BENEFICIO_CURSO = eFichaPATI.CURSO_LE_DIO_BENEFICIOS_2
                If bCursos.ActualizarSOLIC_CURSOS_RECIBIDOS(eCurso) <> 1 Then
                    ExceptionManager.Publish(New Exception(bCursos.sError + vbCrLf + bCursos.sErrorTecnico))
                    'Me.AsignarMensaje("Error al Guardar Curso Recibido. " + vbCrLf + bCursos.sError, True, True)
                End If
            End If

            If eFichaPATI.CURSO_3 <> "" AndAlso (eFichaPATI.IMPARTIO_INSAFORP_CURSO_3 = 1 Or eFichaPATI.IMPARTIO_INSAFORP_CURSO_3 = 2 Or eFichaPATI.IMPARTIO_INSAFORP_CURSO_3 = 2) AndAlso _
                eFichaPATI.ANO_CURSO_3 <> 0 AndAlso (eFichaPATI.CURSO_LE_DIO_BENEFICIOS_3 = 1 Or eFichaPATI.CURSO_LE_DIO_BENEFICIOS_3 = 2 Or eFichaPATI.CURSO_LE_DIO_BENEFICIOS_3 = 3) Then

                eCurso = New SOLIC_CURSOS_RECIBIDOS
                eCurso.ID_SOLICITUD = ID_SOLICITUD
                eCurso.NOMBRE_CURSO = eFichaPATI.CURSO_3
                eCurso.APOYO_INSAFORP = eFichaPATI.IMPARTIO_INSAFORP_CURSO_3
                eCurso.ANIO = eFichaPATI.ANO_CURSO_3
                eCurso.BENEFICIO_CURSO = eFichaPATI.CURSO_LE_DIO_BENEFICIOS_3
                If bCursos.ActualizarSOLIC_CURSOS_RECIBIDOS(eCurso) <> 1 Then
                    ExceptionManager.Publish(New Exception(bCursos.sError + vbCrLf + bCursos.sErrorTecnico))
                    'Me.AsignarMensaje("Error al Guardar Curso Recibido. " + vbCrLf + bCursos.sError, True, True)
                End If
            End If
        End If
    End Sub

    Private Sub GuardarEmpleoAnterior(ByVal ID_SOLICITUD As Decimal, ByVal eFichaPATI As PATI.EL.FICHA_PATI)
        If eFichaPATI.TIEMPO_QUE_NO_TRABAJA <> -1 Then
            Dim bEmpleoAnterior As New cSOLIC_EMPLEO_ANTERIOR
            Dim eEmpleoAnterior As New SOLIC_EMPLEO_ANTERIOR

            eEmpleoAnterior.ID_SOLICITUD = ID_SOLICITUD
            eEmpleoAnterior.ID_EMPLEO_ANT = 0
            Select Case eFichaPATI.TIEMPO_QUE_NO_TRABAJA
                Case 1 To 4
                    eEmpleoAnterior.TIEMPO_NO_TRABAJA = eFichaPATI.TIEMPO_QUE_NO_TRABAJA
                Case Else
                    eEmpleoAnterior.TIEMPO_NO_TRABAJA = -1
            End Select

            If bEmpleoAnterior.ActualizarSOLIC_EMPLEO_ANTERIOR(eEmpleoAnterior) <> 1 Then
                ExceptionManager.Publish(New Exception(bEmpleoAnterior.sError + vbCrLf + bEmpleoAnterior.sErrorTecnico))
                'Me.AsignarMensaje("Error al Guardar Empleo Anterior. " + vbCrLf + bEmpleoAnterior.sError, True, True)
            End If
        End If
    End Sub

#End Region

End Class
