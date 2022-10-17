''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cSOLICITUD_INSCRIPCION_AF
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SOLICITUD_INSCRIPCION_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/02/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSOLICITUD_INSCRIPCION_AF
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSOLICITUD_INSCRIPCION_AF()
    Private mEntidad as New SOLICITUD_INSCRIPCION_AF
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF As New ListaSOLICITUD_INSCRIPCION_AF
            mListaSOLICITUD_INSCRIPCION_AF = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_INSCRIPCION_AF
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSOLICITUD_INSCRIPCION_AF(ByRef aEntidad As SOLICITUD_INSCRIPCION_AF, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SOLICITUD_INSCRIPCION_AF.
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSOLICITUD_INSCRIPCION_AF(ByVal ID_SOLICITUD As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As SOLICITUD_INSCRIPCION_AF
        Try
            Dim lEntidad As New SOLICITUD_INSCRIPCION_AF
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(lEntidad)
                Catch ex As Exception
                End Try
            End If
            If Not recuperarHijas Then Return lEntidad
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
    ''' <param name="aACCION_FORMATIVA">Recuperar registro foraneo de la Entidad ACCION_FORMATIVA.</param>
    ''' <param name="aESTADO_SOLICITUD">Recuperar registro foraneo de la Entidad ESTADO_SOLICITUD.</param>
    ''' <param name="aTIPO_SOLICITUD">Recuperar registro foraneo de la Entidad TIPO_SOLICITUD.</param>
    ''' <param name="aPAIS">Recuperar registro foraneo de la Entidad PAIS.</param>
    ''' <param name="aESTADO_CIVIL">Recuperar registro foraneo de la Entidad ESTADO_CIVIL.</param>
    ''' <param name="aEDUC_LEE_ESCRIBE">Recuperar registro foraneo de la Entidad EDUC_LEE_ESCRIBE.</param>
    ''' <param name="aNIVEL_ACADEMICO">Recuperar registro foraneo de la Entidad NIVEL_ACADEMICO.</param>
    ''' <param name="aTIEMPO_DEJO_ESTUDIAR">Recuperar registro foraneo de la Entidad TIEMPO_DEJO_ESTUDIAR.</param>
    ''' <param name="aTIPO_EMPLEO">Recuperar registro foraneo de la Entidad TIPO_EMPLEO.</param>
    ''' <param name="aREFERENCIA">Recuperar registro foraneo de la Entidad REFERENCIA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSOLICITUD_INSCRIPCION_AFConForaneas(ByVal aEntidad As SOLICITUD_INSCRIPCION_AF, Optional ByVal aPARTICIPANTE As Boolean = False, Optional ByVal aACCION_FORMATIVA As Boolean = False, Optional ByVal aESTADO_SOLICITUD As Boolean = False, Optional ByVal aTIPO_SOLICITUD As Boolean = False, Optional ByVal aPAIS As Boolean = False, Optional ByVal aESTADO_CIVIL As Boolean = False, Optional ByVal aEDUC_LEE_ESCRIBE As Boolean = False, Optional ByVal aNIVEL_ACADEMICO As Boolean = False, Optional ByVal aTIEMPO_DEJO_ESTUDIAR As Boolean = False, Optional ByVal aTIPO_EMPLEO As Boolean = False, Optional ByVal aREFERENCIA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aPARTICIPANTE, aACCION_FORMATIVA, aESTADO_SOLICITUD, aTIPO_SOLICITUD, aPAIS, aESTADO_CIVIL, aEDUC_LEE_ESCRIBE, aNIVEL_ACADEMICO, aTIEMPO_DEJO_ESTUDIAR, aTIPO_EMPLEO, aREFERENCIA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_INSCRIPCION_AF que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLICITUD_INSCRIPCION_AF(ByVal ID_SOLICITUD As Decimal) As Integer
        Try
            mEntidad.ID_SOLICITUD = ID_SOLICITUD
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_INSCRIPCION_AF que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLICITUD_INSCRIPCION_AF(ByVal aEntidad As SOLICITUD_INSCRIPCION_AF, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSOLICITUD_INSCRIPCION_AF(ByVal ID_SOLICITUD As Decimal, ByVal FECHA_PRESENTACION As DateTime, ByVal ID_PARTICIPANTE As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal DUI As String, ByVal TIPO_DOCTO As Decimal, ByVal NUM_DOCTO As String, ByVal NIT As String, ByVal ISSS As String, ByVal ID_TIPO_SOLICITUD As Decimal, ByVal ID_PAIS As Decimal, ByVal DEPARTAMENTO_NAC As String, ByVal MUNICIPIO_NAC As String, ByVal FECHA_NACIMIENTO As DateTime, ByVal GENERO As String, ByVal EDAD As Decimal, ByVal MIEMBROS_GRUPO_FAMILIAR As Decimal, ByVal ID_ESTADO_CIVIL As Decimal, ByVal ES_JEFE_HOGAR As Decimal, ByVal TIENE_HIJOS As Decimal, ByVal NO_DE_HIJOS As Decimal, ByVal SE_DEDICA_ALGUNA_PROFESION As Decimal, ByVal PROFESION_OFICIO As String, ByVal DIRECCION As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal TELEFONO As String, ByVal MOVIL As String, ByVal EMAIL As String, ByVal CON_DISCAPACIDAD As Decimal, ByVal DISC_OTRA As String, ByVal ID_LEE_ESCRIBE As Decimal, ByVal ID_NIVEL_ACADEMICO As Decimal, ByVal OTRA_EDUCACION_FORMAL As String, ByVal TITULO_CERTIFICADO_OBTENIDO As String, ByVal ESTUDIA_ACTUALMENTE As Decimal, ByVal ID_TIEMPO_DEJO_ESTUDIAR As Decimal, ByVal RECIBIO_CURSO_ANTERIOR As String, ByVal BENEF_PROM_EMP_ACT As Decimal, ByVal BENEF_OBT_EMPLEO As Decimal, ByVal BENEF_OBT_ING_EXTRA As Decimal, ByVal BENEF_CAMB_EMP_X_CURSO As Decimal, ByVal BENEF_TRAB_CTA_PROPIA As Decimal, ByVal BENEF_OTRO As String, ByVal RAZON_NO_BENEFICIO As String, ByVal OCUACT_TRABAJA As Decimal, ByVal OCUACT_ESTUDIA As Decimal, ByVal OCUACT_DESOCUPADO As Decimal, ByVal OCUACT_OFICIO_HOGAR As Decimal, ByVal OCUACT_BUSCA_TRABAJO As Decimal, ByVal OCUACT_OTRA As String, ByVal ID_TIPO_EMPLEO As Decimal, ByVal TIPO_EMPLEO_OTRO As String, ByVal SECTOR_EMPLEO As Decimal, ByVal TRABAJO_ANTERIOR As String, ByVal RECIBE_INGRESOS As Decimal, ByVal MANERA_OBT_ING_TRABAJO As Decimal, ByVal MANERA_OBT_ING_AYUDA_FAM As Decimal, ByVal MANERA_OBT_ING_REMESA As Decimal, ByVal MANERA_OBT_ING_PENSION As Decimal, ByVal MANERA_OBT_ING_OTRO As String, ByVal EXPFOR_PROMOCION_EMPLEO As Decimal, ByVal EXPFOR_CAMBIAR_EMPLEO As Decimal, ByVal EXPFOR_OBTENER_EMPLEO As Decimal, ByVal EXPFOR_TRABAJAR_CTA_PROPIA As Decimal, ByVal EXPFOR_INGRESOS_EXTRAS As Decimal, ByVal EXPFOR_NINGUNO As Decimal, ByVal EXPFOR_OTRO As String, ByVal CURSO_REL_TRAB_ACTUAL As Decimal, ByVal CURSO_REL_TRAB_NUEVO As Decimal, ByVal NOMBRE_REFERENCIA As String, ByVal ID_REFERENCIA As Decimal, ByVal DIRECCION_REFERENCIA As String, ByVal DEPARTAMENTO_REFERENCIA As String, ByVal MUNICIPIO_REFERENCIA As String, ByVal TELEFONO_REFERENCIA As String, ByVal MOVIL_REFERENCIA As String, ByVal EMAIL_REFERENCIA As String, ByVal SUGERENCIAS As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime) As Integer
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
            lEntidad.TIPO_EMPLEO_OTRO = TIPO_EMPLEO_OTRO
            lEntidad.SECTOR_EMPLEO = SECTOR_EMPLEO
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
            Return Me.ActualizarSOLICITUD_INSCRIPCION_AF(lEntidad)
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_INSCRIPCION_AF(ByVal aEntidad As SOLICITUD_INSCRIPCION_AF) As Integer
        Try
            Return mDb.Actualizar(aEntidad)
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_INSCRIPCION_AF(ByVal ID_SOLICITUD As Decimal, ByVal FECHA_PRESENTACION As DateTime, ByVal ID_PARTICIPANTE As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal DUI As String, ByVal TIPO_DOCTO As Decimal, ByVal NUM_DOCTO As String, ByVal NIT As String, ByVal ISSS As String, ByVal ID_TIPO_SOLICITUD As Decimal, ByVal ID_PAIS As Decimal, ByVal DEPARTAMENTO_NAC As String, ByVal MUNICIPIO_NAC As String, ByVal FECHA_NACIMIENTO As DateTime, ByVal GENERO As String, ByVal EDAD As Decimal, ByVal MIEMBROS_GRUPO_FAMILIAR As Decimal, ByVal ID_ESTADO_CIVIL As Decimal, ByVal ES_JEFE_HOGAR As Decimal, ByVal TIENE_HIJOS As Decimal, ByVal NO_DE_HIJOS As Decimal, ByVal SE_DEDICA_ALGUNA_PROFESION As Decimal, ByVal PROFESION_OFICIO As String, ByVal DIRECCION As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal TELEFONO As String, ByVal MOVIL As String, ByVal EMAIL As String, ByVal CON_DISCAPACIDAD As Decimal, ByVal DISC_OTRA As String, ByVal ID_LEE_ESCRIBE As Decimal, ByVal ID_NIVEL_ACADEMICO As Decimal, ByVal OTRA_EDUCACION_FORMAL As String, ByVal TITULO_CERTIFICADO_OBTENIDO As String, ByVal ESTUDIA_ACTUALMENTE As Decimal, ByVal ID_TIEMPO_DEJO_ESTUDIAR As Decimal, ByVal RECIBIO_CURSO_ANTERIOR As String, ByVal BENEF_PROM_EMP_ACT As Decimal, ByVal BENEF_OBT_EMPLEO As Decimal, ByVal BENEF_OBT_ING_EXTRA As Decimal, ByVal BENEF_CAMB_EMP_X_CURSO As Decimal, ByVal BENEF_TRAB_CTA_PROPIA As Decimal, ByVal BENEF_OTRO As String, ByVal RAZON_NO_BENEFICIO As String, ByVal OCUACT_TRABAJA As Decimal, ByVal OCUACT_ESTUDIA As Decimal, ByVal OCUACT_DESOCUPADO As Decimal, ByVal OCUACT_OFICIO_HOGAR As Decimal, ByVal OCUACT_BUSCA_TRABAJO As Decimal, ByVal OCUACT_OTRA As String, ByVal ID_TIPO_EMPLEO As Decimal, ByVal TIPO_EMPLEO_OTRO As String, ByVal SECTOR_EMPLEO As Decimal, ByVal TRABAJO_ANTERIOR As String, ByVal RECIBE_INGRESOS As Decimal, ByVal MANERA_OBT_ING_TRABAJO As Decimal, ByVal MANERA_OBT_ING_AYUDA_FAM As Decimal, ByVal MANERA_OBT_ING_REMESA As Decimal, ByVal MANERA_OBT_ING_PENSION As Decimal, ByVal MANERA_OBT_ING_OTRO As String, ByVal EXPFOR_PROMOCION_EMPLEO As Decimal, ByVal EXPFOR_CAMBIAR_EMPLEO As Decimal, ByVal EXPFOR_OBTENER_EMPLEO As Decimal, ByVal EXPFOR_TRABAJAR_CTA_PROPIA As Decimal, ByVal EXPFOR_INGRESOS_EXTRAS As Decimal, ByVal EXPFOR_NINGUNO As Decimal, ByVal EXPFOR_OTRO As String, ByVal CURSO_REL_TRAB_ACTUAL As Decimal, ByVal CURSO_REL_TRAB_NUEVO As Decimal, ByVal NOMBRE_REFERENCIA As String, ByVal ID_REFERENCIA As Decimal, ByVal DIRECCION_REFERENCIA As String, ByVal DEPARTAMENTO_REFERENCIA As String, ByVal MUNICIPIO_REFERENCIA As String, ByVal TELEFONO_REFERENCIA As String, ByVal MOVIL_REFERENCIA As String, ByVal EMAIL_REFERENCIA As String, ByVal SUGERENCIAS As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime) As Integer
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
            lEntidad.TIPO_EMPLEO_OTRO = TIPO_EMPLEO_OTRO
            lEntidad.SECTOR_EMPLEO = SECTOR_EMPLEO
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
            Return Me.ActualizarSOLICITUD_INSCRIPCION_AF(lEntidad)
        Catch ex As Exception
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
    ''' 	[GenApp]	14/02/2011	Created
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
    ''' 	[GenApp]	14/02/2011	Created
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
    ''' Función que devuelve una Colección de Entidades de la Tabla DISCA_POR_SOLICITUD
    ''' filtrada por la Llave Primaria de la Tabla SOLICITUD_INSCRIPCION_AF.
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaDISCA_POR_SOLICITUD(ByVal ID_SOLICITUD As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDISCA_POR_SOLICITUD
        Try
            Dim mCDISCA_POR_SOLICITUD As New cDISCA_POR_SOLICITUD
            Dim mListaDISCA_POR_SOLICITUD As New ListaDISCA_POR_SOLICITUD
            Return mCDISCA_POR_SOLICITUD.ObtenerListaPorSOLICITUD_INSCRIPCION_AF(ID_SOLICITUD, recuperarForaneas, asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF As New ListaSOLICITUD_INSCRIPCION_AF
            mListaSOLICITUD_INSCRIPCION_AF = mDb.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_INSCRIPCION_AF
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ACCION_FORMATIVA .
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF As New ListaSOLICITUD_INSCRIPCION_AF
            mListaSOLICITUD_INSCRIPCION_AF = mDb.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_INSCRIPCION_AF
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorESTADO_SOLICITUD(ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF As New ListaSOLICITUD_INSCRIPCION_AF
            mListaSOLICITUD_INSCRIPCION_AF = mDb.ObtenerListaPorESTADO_SOLICITUD(ID_ESTADO_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_INSCRIPCION_AF
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPO_SOLICITUD .
    ''' </summary>
    ''' <param name="ID_TIPO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_SOLICITUD(ByVal ID_TIPO_SOLICITUD As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF As New ListaSOLICITUD_INSCRIPCION_AF
            mListaSOLICITUD_INSCRIPCION_AF = mDb.ObtenerListaPorTIPO_SOLICITUD(ID_TIPO_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_INSCRIPCION_AF
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPAIS(ByVal ID_PAIS As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF As New ListaSOLICITUD_INSCRIPCION_AF
            mListaSOLICITUD_INSCRIPCION_AF = mDb.ObtenerListaPorPAIS(ID_PAIS, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_INSCRIPCION_AF
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorESTADO_CIVIL(ByVal ID_ESTADO_CIVIL As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF As New ListaSOLICITUD_INSCRIPCION_AF
            mListaSOLICITUD_INSCRIPCION_AF = mDb.ObtenerListaPorESTADO_CIVIL(ID_ESTADO_CIVIL, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_INSCRIPCION_AF
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla EDUC_LEE_ESCRIBE .
    ''' </summary>
    ''' <param name="ID_LEE_ESCRIBE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorEDUC_LEE_ESCRIBE(ByVal ID_LEE_ESCRIBE As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF As New ListaSOLICITUD_INSCRIPCION_AF
            mListaSOLICITUD_INSCRIPCION_AF = mDb.ObtenerListaPorEDUC_LEE_ESCRIBE(ID_LEE_ESCRIBE, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_INSCRIPCION_AF
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorNIVEL_ACADEMICO(ByVal ID_NIVEL_ACADEMICO As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF As New ListaSOLICITUD_INSCRIPCION_AF
            mListaSOLICITUD_INSCRIPCION_AF = mDb.ObtenerListaPorNIVEL_ACADEMICO(ID_NIVEL_ACADEMICO, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_INSCRIPCION_AF
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIEMPO_DEJO_ESTUDIAR(ByVal ID_TIEMPO_DEJO_ESTUDIAR As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF As New ListaSOLICITUD_INSCRIPCION_AF
            mListaSOLICITUD_INSCRIPCION_AF = mDb.ObtenerListaPorTIEMPO_DEJO_ESTUDIAR(ID_TIEMPO_DEJO_ESTUDIAR, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_INSCRIPCION_AF
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPO_EMPLEO .
    ''' </summary>
    ''' <param name="ID_TIPO_EMPLEO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_EMPLEO(ByVal ID_TIPO_EMPLEO As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF As New ListaSOLICITUD_INSCRIPCION_AF
            mListaSOLICITUD_INSCRIPCION_AF = mDb.ObtenerListaPorTIPO_EMPLEO(ID_TIPO_EMPLEO, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_INSCRIPCION_AF
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorREFERENCIA(ByVal ID_REFERENCIA As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF As New ListaSOLICITUD_INSCRIPCION_AF
            mListaSOLICITUD_INSCRIPCION_AF = mDb.ObtenerListaPorREFERENCIA(ID_REFERENCIA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSOLICITUD_INSCRIPCION_AF
            If Not mListaSOLICITUD_INSCRIPCION_AF Is Nothing Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF in  mListaSOLICITUD_INSCRIPCION_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SOLICITUD_INSCRIPCION_AF )
        aEntidad.fkID_PARTICIPANTE = (New cPARTICIPANTE).ObtenerPARTICIPANTE(aEntidad.ID_PARTICIPANTE)
        aEntidad.fkID_ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
        aEntidad.fkID_ESTADO_SOLICITUD = (New cESTADO_SOLICITUD).ObtenerESTADO_SOLICITUD(aEntidad.ID_ESTADO_SOLICITUD)
        aEntidad.fkID_TIPO_SOLICITUD = (New cTIPO_SOLICITUD).ObtenerTIPO_SOLICITUD(aEntidad.ID_TIPO_SOLICITUD)
        aEntidad.fkID_PAIS = (New cPAIS).ObtenerPAIS(aEntidad.ID_PAIS)
        aEntidad.fkID_ESTADO_CIVIL = (New cESTADO_CIVIL).ObtenerESTADO_CIVIL(aEntidad.ID_ESTADO_CIVIL)
        aEntidad.fkID_LEE_ESCRIBE = (New cEDUC_LEE_ESCRIBE).ObtenerEDUC_LEE_ESCRIBE(aEntidad.ID_LEE_ESCRIBE)
        aEntidad.fkID_NIVEL_ACADEMICO = (New cNIVEL_ACADEMICO).ObtenerNIVEL_ACADEMICO(aEntidad.ID_NIVEL_ACADEMICO)
        aEntidad.fkID_TIEMPO_DEJO_ESTUDIAR = (New cTIEMPO_DEJO_ESTUDIAR).ObtenerTIEMPO_DEJO_ESTUDIAR(aEntidad.ID_TIEMPO_DEJO_ESTUDIAR)
        aEntidad.fkID_REFERENCIA = (New cREFERENCIA).ObtenerREFERENCIA(aEntidad.ID_REFERENCIA)
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SOLICITUD_INSCRIPCION_AF )
        aEntidad.DISCA_POR_SOLICITUDSOLICITUD_INSCRIPCION_AF = Me.ObtenerListaDISCA_POR_SOLICITUD(aEntidad.ID_SOLICITUD)
    End Sub

#End Region

End Class
