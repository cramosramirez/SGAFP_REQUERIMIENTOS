''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cSOLICITUD_PRESELECCION_EC
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SOLICITUD_PRESELECCION_EC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/08/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSOLICITUD_PRESELECCION_EC
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSOLICITUD_PRESELECCION_EC()
    Private mEntidad as New SOLICITUD_PRESELECCION_EC
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un registro y lo setea en la Entidad que recibe de
    ''' parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSOLICITUD_PRESELECCION_EC(ByRef aEntidad As SOLICITUD_PRESELECCION_EC, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(aEntidad)
                Catch ex As Exception
                End Try
            End If
            If Not recuperarHijas Then Return liRet
            If liRet > 0 Then
                Try
                    Me.RecuperarHijas(aEntidad)
                Catch ex as Exception
                End Try
            End If
            Return liRet
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SOLICITUD_PRESELECCION_EC.
    ''' </summary>
    ''' <param name="ID_SOLIC_PRESELEC"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSOLICITUD_PRESELECCION_EC(ByVal ID_SOLIC_PRESELEC As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As SOLICITUD_PRESELECCION_EC
        Try
            Dim lEntidad As New SOLICITUD_PRESELECCION_EC
            lEntidad.ID_SOLIC_PRESELEC = ID_SOLIC_PRESELEC
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(lEntidad)
                Catch ex As Exception
                End Try
            End If
            If Not recuperarHijas Then
                If liRet = 1 Then Return lEntidad
                Return Nothing
            End If
            If liRet > 0 Then
                Try
                    Me.RecuperarHijas(lEntidad)
                Catch ex as Exception
                End Try
            End If
            If liRet = 1 Then Return lEntidad
            Return Nothing
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que recupera un registro y lo setea en la Entidad que recibe de
    ''' parámetro, ademas de permitir agregar en la Entidad las Foraneas.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <param name="aPARTICIPANTE">Recuperar registro foraneo de la Entidad PARTICIPANTE.</param>
    ''' <param name="aESTADO_SOLICITUD">Recuperar registro foraneo de la Entidad ESTADO_SOLICITUD.</param>
    ''' <param name="aGRUPO_SELECCION">Recuperar registro foraneo de la Entidad GRUPO_SELECCION.</param>
    ''' <param name="aTIPO_SELECC">Recuperar registro foraneo de la Entidad TIPO_SELECC.</param>
    ''' <param name="aPAIS">Recuperar registro foraneo de la Entidad PAIS.</param>
    ''' <param name="aESTADO_CIVIL">Recuperar registro foraneo de la Entidad ESTADO_CIVIL.</param>
    ''' <param name="aDEPARTAMENTO">Recuperar registro foraneo de la Entidad DEPARTAMENTO.</param>
    ''' <param name="aMUNICIPIO">Recuperar registro foraneo de la Entidad MUNICIPIO.</param>
    ''' <param name="aNIVEL_ACADEMICO">Recuperar registro foraneo de la Entidad NIVEL_ACADEMICO.</param>
    ''' <param name="aTIEMPO_DEJO_ESTUDIAR">Recuperar registro foraneo de la Entidad TIEMPO_DEJO_ESTUDIAR.</param>
    ''' <param name="aMOTIVO_DEJO_ESTU">Recuperar registro foraneo de la Entidad MOTIVO_DEJO_ESTU.</param>
    ''' <param name="aINGRESO_MES">Recuperar registro foraneo de la Entidad INGRESO_MES.</param>
    ''' <param name="aTIEMPO_NOTRAB">Recuperar registro foraneo de la Entidad TIEMPO_NOTRAB.</param>
    ''' <param name="aACTI_ECONOMICA">Recuperar registro foraneo de la Entidad ACTI_ECONOMICA.</param>
    ''' <param name="aAREA_EMPRESA">Recuperar registro foraneo de la Entidad AREA_EMPRESA.</param>
    ''' <param name="aMOTIVO_DEJO_TRAB">Recuperar registro foraneo de la Entidad MOTIVO_DEJO_TRAB.</param>
    ''' <param name="aREFERENCIA">Recuperar registro foraneo de la Entidad REFERENCIA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSOLICITUD_PRESELECCION_ECConForaneas(ByVal aEntidad As SOLICITUD_PRESELECCION_EC, Optional ByVal aPARTICIPANTE As Boolean = False, Optional ByVal aESTADO_SOLICITUD As Boolean = False, Optional ByVal aGRUPO_SELECCION As Boolean = False, Optional ByVal aTIPO_SELECC As Boolean = False, Optional ByVal aPAIS As Boolean = False, Optional ByVal aESTADO_CIVIL As Boolean = False, Optional ByVal aDEPARTAMENTO As Boolean = False, Optional ByVal aMUNICIPIO As Boolean = False, Optional ByVal aNIVEL_ACADEMICO As Boolean = False, Optional ByVal aTIEMPO_DEJO_ESTUDIAR As Boolean = False, Optional ByVal aMOTIVO_DEJO_ESTU As Boolean = False, Optional ByVal aINGRESO_MES As Boolean = False, Optional ByVal aTIEMPO_NOTRAB As Boolean = False, Optional ByVal aACTI_ECONOMICA As Boolean = False, Optional ByVal aAREA_EMPRESA As Boolean = False, Optional ByVal aMOTIVO_DEJO_TRAB As Boolean = False, Optional ByVal aREFERENCIA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aPARTICIPANTE, aESTADO_SOLICITUD, aGRUPO_SELECCION, aTIPO_SELECC, aPAIS, aESTADO_CIVIL, aDEPARTAMENTO, aMUNICIPIO, aNIVEL_ACADEMICO, aTIEMPO_DEJO_ESTUDIAR, aMOTIVO_DEJO_ESTU, aINGRESO_MES, aTIEMPO_NOTRAB, aACTI_ECONOMICA, aAREA_EMPRESA, aMOTIVO_DEJO_TRAB, aREFERENCIA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

   

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro que recibe como parámetro.
    ''' </summary>
    ''' <remarks>Se reciben los parametros uno a uno para la entidad 
    ''' y son asignados a una entidad y se ejecuta el Metodo Actualizar
    ''' o Agregar mandando la entidad de parametro.</remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSOLICITUD_PRESELECCION_EC(ByVal ID_SOLIC_PRESELEC As Decimal, ByVal FECHA_PRESENTACION As DateTime, ByVal ID_PARTICIPANTE As Decimal, ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal ID_GRUPO_SELEC As Decimal, ByVal ID_TIPO_SELECC As Decimal, ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal DUI As String, ByVal TIPO_DOCTO As Decimal, ByVal NUM_DOCTO As String, ByVal NIT As String, ByVal ISSS As String, ByVal ID_PAIS As Decimal, ByVal DEPARTAMENTO_NAC As String, ByVal MUNICIPIO_NAC As String, ByVal FECHA_NACIMIENTO As DateTime, ByVal GENERO As String, ByVal EDAD As Decimal, ByVal MIEMBROS_GRUPO_FAMILIAR As Decimal, ByVal ID_ESTADO_CIVIL As Decimal, ByVal ES_JEFE_HOGAR As Decimal, ByVal TIENE_HIJOS As Decimal, ByVal NO_DE_HIJOS As Decimal, ByVal SE_DEDICA_ALGUNA_PROFESION As Decimal, ByVal PROFESION_OFICIO As String, ByVal DIRECCION As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal TELEFONO As String, ByVal MOVIL As String, ByVal EMAIL As String, ByVal CON_DISCAPACIDAD As Decimal, ByVal DISC_OTRA As String, ByVal ID_NIVEL_ACADEMICO As Decimal, ByVal OTRA_EDUCACION_FORMAL As String, ByVal TITULO_CERTIFICADO_OBTENIDO As String, ByVal ESTUDIA_ACTUALMENTE As Decimal, ByVal ID_TIEMPO_DEJO_ESTUDIAR As Decimal, ByVal ID_MOTIVO_DEJO_ESTU As Decimal, ByVal OTRO_MOTIVO_DEJO_ESTU As String, ByVal RECIBIO_CURSO_ANTERIOR As String, ByVal BENEF_PROM_EMP_ACT As Decimal, ByVal BENEF_OBT_EMPLEO As Decimal, ByVal BENEF_OBT_ING_EXTRA As Decimal, ByVal BENEF_CAMB_EMP_X_CURSO As Decimal, ByVal BENEF_TRAB_CTA_PROPIA As Decimal, ByVal BENEF_OTRO As String, ByVal RAZON_NO_BENEFICIO As String, ByVal OCUACT_TRABAJA As Decimal, ByVal OCUACT_ESTUDIA As Decimal, ByVal OCUACT_ESTU_TRAB As Decimal, ByVal OCUACT_OFICIO_HOGAR As Decimal, ByVal OCUACT_BUSCA_TRAB As Decimal, ByVal OCUACT_OTRA As String, ByVal RECIBE_INGRESOS As Decimal, ByVal MANERA_OBT_ING_TRABAJO As Decimal, ByVal MANERA_OBT_ING_BECA As Decimal, ByVal MANERA_OBT_ING_AYUDA_FAM As Decimal, ByVal MANERA_OBT_ING_REMESA As Decimal, ByVal MANERA_OBT_ING_OTRO As String, ByVal ID_INGRESO_MES As Decimal, ByVal ID_TIEMPO_NOTRAB As Decimal, ByVal ID_ACTI_ECONOMICA As Decimal, ByVal ID_AREA_EMPRESA As Decimal, ByVal ID_MOTIVO_DEJO_TRAB As Decimal, ByVal EXPFOR_OBTENER_EMPLEO As Decimal, ByVal EXPFOR_INGRESOS_EXTRAS As Decimal, ByVal EXPFOR_TRABAJAR_CTA_PROPIA As Decimal, ByVal EXPFOR_OTRO As String, ByVal MOTIVO_ELIGIO_CARRERA As String, ByVal NOMBRE_REFERENCIA As String, ByVal ID_REFERENCIA As Decimal, ByVal DIRECCION_REFERENCIA As String, ByVal DEPARTAMENTO_REFERENCIA As String, ByVal MUNICIPIO_REFERENCIA As String, ByVal TELEFONO_REFERENCIA As String, ByVal MOVIL_REFERENCIA As String, ByVal EMAIL_REFERENCIA As String, ByVal SUGERENCIAS As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREACION As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal TIPO_EMPLEO_OTRO As String, ByVal TRABAJO_ANTERIOR As String, ByVal PUESTO_DESEMPENO As String, ByVal ID_ULT_SALARIO_MES As Decimal, ByVal ES_RECLUTA_INICIAL As Decimal, ByVal ES_RECLUTA_EXTRA As Decimal, ByVal REQUI_AUTORIZACION As Decimal, ByVal OBSERVACION_AURIZACION As String, ByVal AUTORIZADO As Decimal, ByVal MOTIVO_AUTORIZADO As String, ByVal USUARIO_AUTORIZO As String, ByVal FECHA_AITORIZA As DateTime) As Integer
        Try
            Dim lEntidad As New SOLICITUD_PRESELECCION_EC
            lEntidad.ID_SOLIC_PRESELEC = ID_SOLIC_PRESELEC
            lEntidad.FECHA_PRESENTACION = FECHA_PRESENTACION
            lEntidad.ID_PARTICIPANTE = ID_PARTICIPANTE
            lEntidad.ID_ESTADO_SOLICITUD = ID_ESTADO_SOLICITUD
            lEntidad.ID_GRUPO_SELEC = ID_GRUPO_SELEC
            lEntidad.ID_TIPO_SELECC = ID_TIPO_SELECC
            lEntidad.NOMBRES = NOMBRES
            lEntidad.APELLIDOS = APELLIDOS
            lEntidad.DUI = DUI
            lEntidad.TIPO_DOCTO = TIPO_DOCTO
            lEntidad.NUM_DOCTO = NUM_DOCTO
            lEntidad.NIT = NIT
            lEntidad.ISSS = ISSS
            lEntidad.ID_PAIS = ID_PAIS
            lEntidad.DEPARTAMENTO_NAC = DEPARTAMENTO_NAC
            lEntidad.MUNICIPIO_NAC = MUNICIPIO_NAC
            lEntidad.FECHA_NACIMIENTO = FECHA_NACIMIENTO
            lEntidad.GENERO = GENERO
            lEntidad.EDAD = EDAD
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
            lEntidad.ID_NIVEL_ACADEMICO = ID_NIVEL_ACADEMICO
            lEntidad.OTRA_EDUCACION_FORMAL = OTRA_EDUCACION_FORMAL
            lEntidad.TITULO_CERTIFICADO_OBTENIDO = TITULO_CERTIFICADO_OBTENIDO
            lEntidad.ESTUDIA_ACTUALMENTE = ESTUDIA_ACTUALMENTE
            lEntidad.ID_TIEMPO_DEJO_ESTUDIAR = ID_TIEMPO_DEJO_ESTUDIAR
            lEntidad.ID_MOTIVO_DEJO_ESTU = ID_MOTIVO_DEJO_ESTU
            lEntidad.OTRO_MOTIVO_DEJO_ESTU = OTRO_MOTIVO_DEJO_ESTU
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
            lEntidad.OCUACT_ESTU_TRAB = OCUACT_ESTU_TRAB
            lEntidad.OCUACT_OFICIO_HOGAR = OCUACT_OFICIO_HOGAR
            lEntidad.OCUACT_BUSCA_TRAB = OCUACT_BUSCA_TRAB
            lEntidad.OCUACT_OTRA = OCUACT_OTRA
            lEntidad.RECIBE_INGRESOS = RECIBE_INGRESOS
            lEntidad.MANERA_OBT_ING_TRABAJO = MANERA_OBT_ING_TRABAJO
            lEntidad.MANERA_OBT_ING_BECA = MANERA_OBT_ING_BECA
            lEntidad.MANERA_OBT_ING_AYUDA_FAM = MANERA_OBT_ING_AYUDA_FAM
            lEntidad.MANERA_OBT_ING_REMESA = MANERA_OBT_ING_REMESA
            lEntidad.MANERA_OBT_ING_OTRO = MANERA_OBT_ING_OTRO
            lEntidad.ID_INGRESO_MES = ID_INGRESO_MES
            lEntidad.ID_TIEMPO_NOTRAB = ID_TIEMPO_NOTRAB
            lEntidad.ID_ACTI_ECONOMICA = ID_ACTI_ECONOMICA
            lEntidad.ID_AREA_EMPRESA = ID_AREA_EMPRESA
            lEntidad.ID_MOTIVO_DEJO_TRAB = ID_MOTIVO_DEJO_TRAB
            lEntidad.EXPFOR_OBTENER_EMPLEO = EXPFOR_OBTENER_EMPLEO
            lEntidad.EXPFOR_INGRESOS_EXTRAS = EXPFOR_INGRESOS_EXTRAS
            lEntidad.EXPFOR_TRABAJAR_CTA_PROPIA = EXPFOR_TRABAJAR_CTA_PROPIA
            lEntidad.EXPFOR_OTRO = EXPFOR_OTRO
            lEntidad.MOTIVO_ELIGIO_CARRERA = MOTIVO_ELIGIO_CARRERA
            lEntidad.NOMBRE_REFERENCIA = NOMBRE_REFERENCIA
            lEntidad.ID_REFERENCIA = ID_REFERENCIA
            lEntidad.DIRECCION_REFERENCIA = DIRECCION_REFERENCIA
            lEntidad.DEPARTAMENTO_REFERENCIA = DEPARTAMENTO_REFERENCIA
            lEntidad.MUNICIPIO_REFERENCIA = MUNICIPIO_REFERENCIA
            lEntidad.TELEFONO_REFERENCIA = TELEFONO_REFERENCIA
            lEntidad.MOVIL_REFERENCIA = MOVIL_REFERENCIA
            lEntidad.EMAIL_REFERENCIA = EMAIL_REFERENCIA
            lEntidad.SUGERENCIAS = SUGERENCIAS
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREACION = FECHA_CREACION
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.TIPO_EMPLEO_OTRO = TIPO_EMPLEO_OTRO
            lEntidad.TRABAJO_ANTERIOR = TRABAJO_ANTERIOR
            lEntidad.PUESTO_DESEMPENO = PUESTO_DESEMPENO
            lEntidad.ID_ULT_SALARIO_MES = ID_ULT_SALARIO_MES
            lEntidad.ES_RECLUTA_INICIAL = ES_RECLUTA_INICIAL
            lEntidad.ES_RECLUTA_EXTRA = ES_RECLUTA_EXTRA
            lEntidad.REQUI_AUTORIZACION = REQUI_AUTORIZACION
            lEntidad.OBSERVACION_AURIZACION = OBSERVACION_AURIZACION
            lEntidad.AUTORIZADO = AUTORIZADO
            lEntidad.MOTIVO_AUTORIZADO = MOTIVO_AUTORIZADO
            lEntidad.USUARIO_AUTORIZO = USUARIO_AUTORIZO
            lEntidad.FECHA_AITORIZA = FECHA_AITORIZA
            Return Me.ActualizarSOLICITUD_PRESELECCION_EC(lEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza o Ingresa un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_PRESELECCION_EC(ByVal ID_SOLIC_PRESELEC As Decimal, ByVal FECHA_PRESENTACION As DateTime, ByVal ID_PARTICIPANTE As Decimal, ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal ID_GRUPO_SELEC As Decimal, ByVal ID_TIPO_SELECC As Decimal, ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal DUI As String, ByVal TIPO_DOCTO As Decimal, ByVal NUM_DOCTO As String, ByVal NIT As String, ByVal ISSS As String, ByVal ID_PAIS As Decimal, ByVal DEPARTAMENTO_NAC As String, ByVal MUNICIPIO_NAC As String, ByVal FECHA_NACIMIENTO As DateTime, ByVal GENERO As String, ByVal EDAD As Decimal, ByVal MIEMBROS_GRUPO_FAMILIAR As Decimal, ByVal ID_ESTADO_CIVIL As Decimal, ByVal ES_JEFE_HOGAR As Decimal, ByVal TIENE_HIJOS As Decimal, ByVal NO_DE_HIJOS As Decimal, ByVal SE_DEDICA_ALGUNA_PROFESION As Decimal, ByVal PROFESION_OFICIO As String, ByVal DIRECCION As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal TELEFONO As String, ByVal MOVIL As String, ByVal EMAIL As String, ByVal CON_DISCAPACIDAD As Decimal, ByVal DISC_OTRA As String, ByVal ID_NIVEL_ACADEMICO As Decimal, ByVal OTRA_EDUCACION_FORMAL As String, ByVal TITULO_CERTIFICADO_OBTENIDO As String, ByVal ESTUDIA_ACTUALMENTE As Decimal, ByVal ID_TIEMPO_DEJO_ESTUDIAR As Decimal, ByVal ID_MOTIVO_DEJO_ESTU As Decimal, ByVal OTRO_MOTIVO_DEJO_ESTU As String, ByVal RECIBIO_CURSO_ANTERIOR As String, ByVal BENEF_PROM_EMP_ACT As Decimal, ByVal BENEF_OBT_EMPLEO As Decimal, ByVal BENEF_OBT_ING_EXTRA As Decimal, ByVal BENEF_CAMB_EMP_X_CURSO As Decimal, ByVal BENEF_TRAB_CTA_PROPIA As Decimal, ByVal BENEF_OTRO As String, ByVal RAZON_NO_BENEFICIO As String, ByVal OCUACT_TRABAJA As Decimal, ByVal OCUACT_ESTUDIA As Decimal, ByVal OCUACT_ESTU_TRAB As Decimal, ByVal OCUACT_OFICIO_HOGAR As Decimal, ByVal OCUACT_BUSCA_TRAB As Decimal, ByVal OCUACT_OTRA As String, ByVal RECIBE_INGRESOS As Decimal, ByVal MANERA_OBT_ING_TRABAJO As Decimal, ByVal MANERA_OBT_ING_BECA As Decimal, ByVal MANERA_OBT_ING_AYUDA_FAM As Decimal, ByVal MANERA_OBT_ING_REMESA As Decimal, ByVal MANERA_OBT_ING_OTRO As String, ByVal ID_INGRESO_MES As Decimal, ByVal ID_TIEMPO_NOTRAB As Decimal, ByVal ID_ACTI_ECONOMICA As Decimal, ByVal ID_AREA_EMPRESA As Decimal, ByVal ID_MOTIVO_DEJO_TRAB As Decimal, ByVal EXPFOR_OBTENER_EMPLEO As Decimal, ByVal EXPFOR_INGRESOS_EXTRAS As Decimal, ByVal EXPFOR_TRABAJAR_CTA_PROPIA As Decimal, ByVal EXPFOR_OTRO As String, ByVal MOTIVO_ELIGIO_CARRERA As String, ByVal NOMBRE_REFERENCIA As String, ByVal ID_REFERENCIA As Decimal, ByVal DIRECCION_REFERENCIA As String, ByVal DEPARTAMENTO_REFERENCIA As String, ByVal MUNICIPIO_REFERENCIA As String, ByVal TELEFONO_REFERENCIA As String, ByVal MOVIL_REFERENCIA As String, ByVal EMAIL_REFERENCIA As String, ByVal SUGERENCIAS As String, ByVal USUARIO_CREA As String, ByVal FECHA_CREACION As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal TIPO_EMPLEO_OTRO As String, ByVal TRABAJO_ANTERIOR As String, ByVal PUESTO_DESEMPENO As String, ByVal ID_ULT_SALARIO_MES As Decimal, ByVal ES_RECLUTA_INICIAL As Decimal, ByVal ES_RECLUTA_EXTRA As Decimal, ByVal REQUI_AUTORIZACION As Decimal, ByVal OBSERVACION_AURIZACION As String, ByVal AUTORIZADO As Decimal, ByVal MOTIVO_AUTORIZADO As String, ByVal USUARIO_AUTORIZO As String, ByVal FECHA_AITORIZA As DateTime) As Integer
        Try
            Dim lEntidad As New SOLICITUD_PRESELECCION_EC
            lEntidad.ID_SOLIC_PRESELEC = ID_SOLIC_PRESELEC
            lEntidad.FECHA_PRESENTACION = FECHA_PRESENTACION
            lEntidad.ID_PARTICIPANTE = ID_PARTICIPANTE
            lEntidad.ID_ESTADO_SOLICITUD = ID_ESTADO_SOLICITUD
            lEntidad.ID_GRUPO_SELEC = ID_GRUPO_SELEC
            lEntidad.ID_TIPO_SELECC = ID_TIPO_SELECC
            lEntidad.NOMBRES = NOMBRES
            lEntidad.APELLIDOS = APELLIDOS
            lEntidad.DUI = DUI
            lEntidad.TIPO_DOCTO = TIPO_DOCTO
            lEntidad.NUM_DOCTO = NUM_DOCTO
            lEntidad.NIT = NIT
            lEntidad.ISSS = ISSS
            lEntidad.ID_PAIS = ID_PAIS
            lEntidad.DEPARTAMENTO_NAC = DEPARTAMENTO_NAC
            lEntidad.MUNICIPIO_NAC = MUNICIPIO_NAC
            lEntidad.FECHA_NACIMIENTO = FECHA_NACIMIENTO
            lEntidad.GENERO = GENERO
            lEntidad.EDAD = EDAD
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
            lEntidad.ID_NIVEL_ACADEMICO = ID_NIVEL_ACADEMICO
            lEntidad.OTRA_EDUCACION_FORMAL = OTRA_EDUCACION_FORMAL
            lEntidad.TITULO_CERTIFICADO_OBTENIDO = TITULO_CERTIFICADO_OBTENIDO
            lEntidad.ESTUDIA_ACTUALMENTE = ESTUDIA_ACTUALMENTE
            lEntidad.ID_TIEMPO_DEJO_ESTUDIAR = ID_TIEMPO_DEJO_ESTUDIAR
            lEntidad.ID_MOTIVO_DEJO_ESTU = ID_MOTIVO_DEJO_ESTU
            lEntidad.OTRO_MOTIVO_DEJO_ESTU = OTRO_MOTIVO_DEJO_ESTU
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
            lEntidad.OCUACT_ESTU_TRAB = OCUACT_ESTU_TRAB
            lEntidad.OCUACT_OFICIO_HOGAR = OCUACT_OFICIO_HOGAR
            lEntidad.OCUACT_BUSCA_TRAB = OCUACT_BUSCA_TRAB
            lEntidad.OCUACT_OTRA = OCUACT_OTRA
            lEntidad.RECIBE_INGRESOS = RECIBE_INGRESOS
            lEntidad.MANERA_OBT_ING_TRABAJO = MANERA_OBT_ING_TRABAJO
            lEntidad.MANERA_OBT_ING_BECA = MANERA_OBT_ING_BECA
            lEntidad.MANERA_OBT_ING_AYUDA_FAM = MANERA_OBT_ING_AYUDA_FAM
            lEntidad.MANERA_OBT_ING_REMESA = MANERA_OBT_ING_REMESA
            lEntidad.MANERA_OBT_ING_OTRO = MANERA_OBT_ING_OTRO
            lEntidad.ID_INGRESO_MES = ID_INGRESO_MES
            lEntidad.ID_TIEMPO_NOTRAB = ID_TIEMPO_NOTRAB
            lEntidad.ID_ACTI_ECONOMICA = ID_ACTI_ECONOMICA
            lEntidad.ID_AREA_EMPRESA = ID_AREA_EMPRESA
            lEntidad.ID_MOTIVO_DEJO_TRAB = ID_MOTIVO_DEJO_TRAB
            lEntidad.EXPFOR_OBTENER_EMPLEO = EXPFOR_OBTENER_EMPLEO
            lEntidad.EXPFOR_INGRESOS_EXTRAS = EXPFOR_INGRESOS_EXTRAS
            lEntidad.EXPFOR_TRABAJAR_CTA_PROPIA = EXPFOR_TRABAJAR_CTA_PROPIA
            lEntidad.EXPFOR_OTRO = EXPFOR_OTRO
            lEntidad.MOTIVO_ELIGIO_CARRERA = MOTIVO_ELIGIO_CARRERA
            lEntidad.NOMBRE_REFERENCIA = NOMBRE_REFERENCIA
            lEntidad.ID_REFERENCIA = ID_REFERENCIA
            lEntidad.DIRECCION_REFERENCIA = DIRECCION_REFERENCIA
            lEntidad.DEPARTAMENTO_REFERENCIA = DEPARTAMENTO_REFERENCIA
            lEntidad.MUNICIPIO_REFERENCIA = MUNICIPIO_REFERENCIA
            lEntidad.TELEFONO_REFERENCIA = TELEFONO_REFERENCIA
            lEntidad.MOVIL_REFERENCIA = MOVIL_REFERENCIA
            lEntidad.EMAIL_REFERENCIA = EMAIL_REFERENCIA
            lEntidad.SUGERENCIAS = SUGERENCIAS
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREACION = FECHA_CREACION
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.TIPO_EMPLEO_OTRO = TIPO_EMPLEO_OTRO
            lEntidad.TRABAJO_ANTERIOR = TRABAJO_ANTERIOR
            lEntidad.PUESTO_DESEMPENO = PUESTO_DESEMPENO
            lEntidad.ID_ULT_SALARIO_MES = ID_ULT_SALARIO_MES
            lEntidad.ES_RECLUTA_INICIAL = ES_RECLUTA_INICIAL
            lEntidad.ES_RECLUTA_EXTRA = ES_RECLUTA_EXTRA
            lEntidad.REQUI_AUTORIZACION = REQUI_AUTORIZACION
            lEntidad.OBSERVACION_AURIZACION = OBSERVACION_AURIZACION
            lEntidad.AUTORIZADO = AUTORIZADO
            lEntidad.MOTIVO_AUTORIZADO = MOTIVO_AUTORIZADO
            lEntidad.USUARIO_AUTORIZO = USUARIO_AUTORIZO
            lEntidad.FECHA_AITORIZA = FECHA_AITORIZA
            Return Me.ActualizarSOLICITUD_PRESELECCION_EC(lEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
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
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorId(ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorID(asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que llena un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre llena con todos los registros de la Entidad.
    ''' </summary>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, False)> _
    Public Function ObtenerDataSetPorId(ByRef ds As DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer
        Try
            Return mDb.ObtenerDataSetPorID(ds, asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PARTICIPANTE .
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <param name="DUI"></param>
    ''' <param name="NIT"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal, ByVal DUI As String, ByVal NIT As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE, DUI, NIT, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ESTADO_SOLICITUD .
    ''' </summary>
    ''' <param name="ID_ESTADO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorESTADO_SOLICITUD(ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorESTADO_SOLICITUD(ID_ESTADO_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla GRUPO_SELECCION .
    ''' </summary>
    ''' <param name="ID_GRUPO_SELEC"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorGRUPO_SELECCION(ByVal ID_GRUPO_SELEC As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorGRUPO_SELECCION(ID_GRUPO_SELEC, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPO_SELECC .
    ''' </summary>
    ''' <param name="ID_TIPO_SELECC"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_SELECC(ByVal ID_TIPO_SELECC As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorTIPO_SELECC(ID_TIPO_SELECC, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PAIS .
    ''' </summary>
    ''' <param name="ID_PAIS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPAIS(ByVal ID_PAIS As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorPAIS(ID_PAIS, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ESTADO_CIVIL .
    ''' </summary>
    ''' <param name="ID_ESTADO_CIVIL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorESTADO_CIVIL(ByVal ID_ESTADO_CIVIL As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorESTADO_CIVIL(ID_ESTADO_CIVIL, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla DEPARTAMENTO .
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla MUNICIPIO .
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla NIVEL_ACADEMICO .
    ''' </summary>
    ''' <param name="ID_NIVEL_ACADEMICO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorNIVEL_ACADEMICO(ByVal ID_NIVEL_ACADEMICO As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorNIVEL_ACADEMICO(ID_NIVEL_ACADEMICO, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIEMPO_DEJO_ESTUDIAR .
    ''' </summary>
    ''' <param name="ID_TIEMPO_DEJO_ESTUDIAR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIEMPO_DEJO_ESTUDIAR(ByVal ID_TIEMPO_DEJO_ESTUDIAR As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorTIEMPO_DEJO_ESTUDIAR(ID_TIEMPO_DEJO_ESTUDIAR, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla MOTIVO_DEJO_ESTU .
    ''' </summary>
    ''' <param name="ID_MOTIVO_DEJO_ESTU"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMOTIVO_DEJO_ESTU(ByVal ID_MOTIVO_DEJO_ESTU As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorMOTIVO_DEJO_ESTU(ID_MOTIVO_DEJO_ESTU, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla INGRESO_MES .
    ''' </summary>
    ''' <param name="ID_INGRESO_MES"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorINGRESO_MES(ByVal ID_INGRESO_MES As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorINGRESO_MES(ID_INGRESO_MES, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIEMPO_NOTRAB .
    ''' </summary>
    ''' <param name="ID_TIEMPO_NOTRAB"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIEMPO_NOTRAB(ByVal ID_TIEMPO_NOTRAB As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorTIEMPO_NOTRAB(ID_TIEMPO_NOTRAB, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ACTI_ECONOMICA .
    ''' </summary>
    ''' <param name="ID_ACTI_ECONOMICA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorACTI_ECONOMICA(ByVal ID_ACTI_ECONOMICA As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorACTI_ECONOMICA(ID_ACTI_ECONOMICA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla AREA_EMPRESA .
    ''' </summary>
    ''' <param name="ID_AREA_EMPRESA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorAREA_EMPRESA(ByVal ID_AREA_EMPRESA As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorAREA_EMPRESA(ID_AREA_EMPRESA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla MOTIVO_DEJO_TRAB .
    ''' </summary>
    ''' <param name="ID_MOTIVO_DEJO_TRAB"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMOTIVO_DEJO_TRAB(ByVal ID_MOTIVO_DEJO_TRAB As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorMOTIVO_DEJO_TRAB(ID_MOTIVO_DEJO_TRAB, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla REFERENCIA .
    ''' </summary>
    ''' <param name="ID_REFERENCIA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorREFERENCIA(ByVal ID_REFERENCIA As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_PRESELECCION_EC
        Try
            Dim mListaSOLICITUD_PRESELECCION_EC As New ListaSOLICITUD_PRESELECCION_EC
            mListaSOLICITUD_PRESELECCION_EC = mDb.ObtenerListaPorREFERENCIA(ID_REFERENCIA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_PRESELECCION_EC
            If Not mListaSOLICITUD_PRESELECCION_EC Is Nothing Then
                For Each lEntidad As SOLICITUD_PRESELECCION_EC in  mListaSOLICITUD_PRESELECCION_EC
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera y Asigna los valores de la Tabla Foranea en la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SOLICITUD_PRESELECCION_EC )
        aEntidad.fkID_PARTICIPANTE = (New cPARTICIPANTE).ObtenerPARTICIPANTE(aEntidad.ID_PARTICIPANTE, aEntidad.DUI, aEntidad.ID_PARTICIPANTE)
        aEntidad.fkID_ESTADO_SOLICITUD = (New cESTADO_SOLICITUD).ObtenerESTADO_SOLICITUD(aEntidad.ID_ESTADO_SOLICITUD)
        aEntidad.fkID_GRUPO_SELEC = (New cGRUPO_SELECCION).ObtenerGRUPO_SELECCION(aEntidad.ID_GRUPO_SELEC)
        aEntidad.fkID_TIPO_SELECC = (New cTIPO_SELECC).ObtenerTIPO_SELECC(aEntidad.ID_TIPO_SELECC)
        aEntidad.fkID_PAIS = (New cPAIS).ObtenerPAIS(aEntidad.ID_PAIS)
        aEntidad.fkID_ESTADO_CIVIL = (New cESTADO_CIVIL).ObtenerESTADO_CIVIL(aEntidad.ID_ESTADO_CIVIL)
        aEntidad.fkCODIGO_DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(aEntidad.CODIGO_DEPARTAMENTO)
        aEntidad.fkCODIGO_MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(aEntidad.CODIGO_DEPARTAMENTO, aEntidad.CODIGO_MUNICIPIO)
        aEntidad.fkID_NIVEL_ACADEMICO = (New cNIVEL_ACADEMICO).ObtenerNIVEL_ACADEMICO(aEntidad.ID_NIVEL_ACADEMICO)
        aEntidad.fkID_TIEMPO_DEJO_ESTUDIAR = (New cTIEMPO_DEJO_ESTUDIAR).ObtenerTIEMPO_DEJO_ESTUDIAR(aEntidad.ID_TIEMPO_DEJO_ESTUDIAR)
        aEntidad.fkID_MOTIVO_DEJO_ESTU = (New cMOTIVO_DEJO_ESTU).ObtenerMOTIVO_DEJO_ESTU(aEntidad.ID_MOTIVO_DEJO_ESTU)
        aEntidad.fkID_INGRESO_MES = (New cINGRESO_MES).ObtenerINGRESO_MES(aEntidad.ID_INGRESO_MES)
        aEntidad.fkID_TIEMPO_NOTRAB = (New cTIEMPO_NOTRAB).ObtenerTIEMPO_NOTRAB(aEntidad.ID_TIEMPO_NOTRAB)
        aEntidad.fkID_ACTI_ECONOMICA = (New cACTI_ECONOMICA).ObtenerACTI_ECONOMICA(aEntidad.ID_ACTI_ECONOMICA)
        aEntidad.fkID_AREA_EMPRESA = (New cAREA_EMPRESA).ObtenerAREA_EMPRESA(aEntidad.ID_AREA_EMPRESA)
        aEntidad.fkID_MOTIVO_DEJO_TRAB = (New cMOTIVO_DEJO_TRAB).ObtenerMOTIVO_DEJO_TRAB(aEntidad.ID_MOTIVO_DEJO_TRAB)
        aEntidad.fkID_REFERENCIA = (New cREFERENCIA).ObtenerREFERENCIA(aEntidad.ID_REFERENCIA)
        aEntidad.fkID_ULT_SALARIO_MES = (New cINGRESO_MES).ObtenerINGRESO_MES(aEntidad.ID_INGRESO_MES)
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Recupera y Asigna los valores de las Tablas Hijas de la Entidad que
    ''' recibe de Parámetro.
    ''' </summary>
    ''' <param name="aEntidad"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SOLICITUD_PRESELECCION_EC )
    End Sub

#End Region

End Class
