''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cSOLICITUD_INSCRIPCION_AF_HIST
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SOLICITUD_INSCRIPCION_AF_HIST
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.6.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	21/09/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSOLICITUD_INSCRIPCION_AF_HIST
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSOLICITUD_INSCRIPCION_AF_HIST()
    Private mEntidad as New SOLICITUD_INSCRIPCION_AF_HIST
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF_HIST
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF_HIST As New ListaSOLICITUD_INSCRIPCION_AF_HIST
            mListaSOLICITUD_INSCRIPCION_AF_HIST = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF_HIST Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF_HIST in  mListaSOLICITUD_INSCRIPCION_AF_HIST
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF_HIST
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
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSOLICITUD_INSCRIPCION_AF_HIST(ByRef aEntidad As SOLICITUD_INSCRIPCION_AF_HIST, ByVal Optional recuperarForaneas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(aEntidad)
                Catch ex As Exception
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SOLICITUD_INSCRIPCION_AF_HIST.
    ''' </summary>
    ''' <param name="ID_SOLICITUD_HIST"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSOLICITUD_INSCRIPCION_AF_HIST(ByVal ID_SOLICITUD_HIST As Decimal, ByVal Optional recuperarForaneas As Boolean = False) As SOLICITUD_INSCRIPCION_AF_HIST
        Try
            Dim lEntidad As New SOLICITUD_INSCRIPCION_AF_HIST
            lEntidad.ID_SOLICITUD_HIST = ID_SOLICITUD_HIST
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(lEntidad)
                Catch ex As Exception
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
    ''' <param name="aCONTROL_DOCUMENTOS">Recuperar registro foraneo de la Entidad CONTROL_DOCUMENTOS.</param>
    ''' <param name="aTIPO_SOLICITUD">Recuperar registro foraneo de la Entidad TIPO_SOLICITUD.</param>
    ''' <param name="aEMPRESAS">Recuperar registro foraneo de la Entidad EMPRESAS.</param>
    ''' <param name="aMUNICIPIO">Recuperar registro foraneo de la Entidad MUNICIPIO.</param>
    ''' <param name="aDEPARTAMENTO">Recuperar registro foraneo de la Entidad DEPARTAMENTO.</param>
    ''' <param name="aREGION">Recuperar registro foraneo de la Entidad REGION.</param>
    ''' <param name="aCIUO">Recuperar registro foraneo de la Entidad CIUO.</param>
    ''' <param name="aNIVEL_ACADEMICO">Recuperar registro foraneo de la Entidad NIVEL_ACADEMICO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSOLICITUD_INSCRIPCION_AF_HISTConForaneas(ByVal aEntidad As SOLICITUD_INSCRIPCION_AF_HIST, Optional ByVal aPARTICIPANTE As Boolean = False, Optional ByVal aACCION_FORMATIVA As Boolean = False, Optional ByVal aESTADO_SOLICITUD As Boolean = False, Optional ByVal aCONTROL_DOCUMENTOS As Boolean = False, Optional ByVal aTIPO_SOLICITUD As Boolean = False, Optional ByVal aEMPRESAS As Boolean = False, Optional ByVal aMUNICIPIO As Boolean = False, Optional ByVal aDEPARTAMENTO As Boolean = False, Optional ByVal aREGION As Boolean = False, Optional ByVal aCIUO As Boolean = False, Optional ByVal aNIVEL_ACADEMICO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aPARTICIPANTE, aACCION_FORMATIVA, aESTADO_SOLICITUD, aCONTROL_DOCUMENTOS, aTIPO_SOLICITUD, aEMPRESAS, aMUNICIPIO, aDEPARTAMENTO, aREGION, aCIUO, aNIVEL_ACADEMICO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_INSCRIPCION_AF_HIST que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SOLICITUD_HIST"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLICITUD_INSCRIPCION_AF_HIST(ByVal ID_SOLICITUD_HIST As Decimal) As Integer
        Try
            mEntidad.ID_SOLICITUD_HIST = ID_SOLICITUD_HIST
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_INSCRIPCION_AF_HIST que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLICITUD_INSCRIPCION_AF_HIST(ByVal aEntidad As SOLICITUD_INSCRIPCION_AF_HIST, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSOLICITUD_INSCRIPCION_AF_HIST(ByVal ID_SOLICITUD_HIST As Decimal, ByVal ID_SOLICITUD As Decimal, ByVal FECHA_PRESENTACION As DateTime, ByVal ID_PARTICIPANTE As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal NUMERO_DOCUMENTO As Decimal, ByVal ID_TIPO_SOLICITUD As Decimal, ByVal NIT_EMPRESA As String, ByVal NOMBRE_EMPRESA As String, ByVal CARGO As String, ByVal NUMERO_PATRONAL As String, ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal LUGAR_NACIMIENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_REGION As String, ByVal ZONA As String, ByVal TELEFONO As String, ByVal MOVIL As String, ByVal FAX As String, ByVal EMAIL As String, ByVal NIT As String, ByVal ISSS As String, ByVal CIUO As String, ByVal EDAD As Decimal, ByVal DEPARTAMENTO_NAC As String, ByVal MUNICIPIO_NAC As String, ByVal FECHA_NACIMIENTO As DateTime, ByVal DUI As String, ByVal GENERO As String, ByVal DIRECCION As String, ByVal PROFESION_OFICIO As String, ByVal ESTADO_CIVIL As String, ByVal NOMBRE_FAMILIAR As String, ByVal PARENTESCO As String, ByVal DIRECCION_FAMILIAR As String, ByVal TELEFONO_FAMILIAR As String, ByVal OCUACT_TRABAJA As Decimal, ByVal OCUACT_ESTUDIA As Decimal, ByVal OCUACT_DESOCUPADO As Decimal, ByVal OCUACT_OFICIO_HOGAR As Decimal, ByVal TIPTRA_EMPLEADO_EMPRESA As Decimal, ByVal TIPTRA_EMPRESA_PROPIA As Decimal, ByVal TIPTRA_EVENTUAL As Decimal, ByVal TIPTRA_MEDIO_TIEMPO As Decimal, ByVal TIPTRA_INDEPENDIENTE As Decimal, ByVal RTC_OCUPACION_EMPRESA As Decimal, ByVal RTC_PROPIA_EMPRESA As Decimal, ByVal RTC_TRABAJO_EVENTUAL As Decimal, ByVal RTC_TRABAJO_MEDIO_TIEMPO As Decimal, ByVal RTC_INDEPENDIENTE As Decimal, ByVal RTC_NO_OCUPACION_EMPRESA As Decimal, ByVal RTC_NO_PROPIA_EMPRESA As Decimal, ByVal RTC_NO_TRABAJO_EVENTUAL As Decimal, ByVal RTC_NO_TRABAJO_MEDIO_TIEMPO As Decimal, ByVal RTC_NO_INDEPENDIENTE As Decimal, ByVal NIVEL_ACADEMICO As String, ByVal TITULO_CERTIFICADO_OBTENIDO As String, ByVal TIEMPO_DEJO_ESTUDIAR As String, ByVal RECIBIO_CURSO_ANTERIOR As String, ByVal OBTUVO_BENEFICIOS_CURSO As String, ByVal BENEF_PROM_EMP_ACT As Decimal, ByVal BENEF_OBT_EMPLEO As Decimal, ByVal BENEF_OBT_ING_EXTRA As Decimal, ByVal BENEF_CAMB_EMP_X_CURSO As Decimal, ByVal BENEF_TRAB_CTA_PROPIA As Decimal, ByVal BENEF_OTRO As String, ByVal RAZON_NO_BENEFICIO As String, ByVal TRABAJA_ACTUALMENTE As String, ByVal TRABAJO_ANTERIOR As String, ByVal EXPFOR_PROMOCION_EMPLEO As Decimal, ByVal EXPFOR_CAMBIAR_EMPLEO As Decimal, ByVal EXPFOR_OBTENER_EMPLEO As Decimal, ByVal EXPFOR_TRABAJAR_CTA_PROPIA As Decimal, ByVal EXPFOR_INGRESOS_EXTRAS As Decimal, ByVal EXPFOR_OTRO As String, ByVal INGRESO_MENSUAL_INDIVIDUAL As String, ByVal INGRESO_MENSUAL_FAMILIAR As String, ByVal MIEMBROS_GRUPO_FAMILIAR As Decimal, ByVal SUGERENCIAS As String, ByVal LUGAR_PRESENTACION As String, ByVal ID_PROVEEDOR_AF As Decimal, ByVal USERID_HIST As String, ByVal LASTUPDATE_HIST As DateTime, ByVal USERID As String, ByVal LASTUPDATE As DateTime) As Integer
        Try
            Dim lEntidad As New SOLICITUD_INSCRIPCION_AF_HIST
            lEntidad.ID_SOLICITUD_HIST = ID_SOLICITUD_HIST
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.FECHA_PRESENTACION = FECHA_PRESENTACION
            lEntidad.ID_PARTICIPANTE = ID_PARTICIPANTE
            lEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            lEntidad.ID_ESTADO_SOLICITUD = ID_ESTADO_SOLICITUD
            lEntidad.NUMERO_DOCUMENTO = NUMERO_DOCUMENTO
            lEntidad.ID_TIPO_SOLICITUD = ID_TIPO_SOLICITUD
            lEntidad.NIT_EMPRESA = NIT_EMPRESA
            lEntidad.NOMBRE_EMPRESA = NOMBRE_EMPRESA
            lEntidad.CARGO = CARGO
            lEntidad.NUMERO_PATRONAL = NUMERO_PATRONAL
            lEntidad.NOMBRES = NOMBRES
            lEntidad.APELLIDOS = APELLIDOS
            lEntidad.LUGAR_NACIMIENTO = LUGAR_NACIMIENTO
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_REGION = CODIGO_REGION
            lEntidad.ZONA = ZONA
            lEntidad.TELEFONO = TELEFONO
            lEntidad.MOVIL = MOVIL
            lEntidad.FAX = FAX
            lEntidad.EMAIL = EMAIL
            lEntidad.NIT = NIT
            lEntidad.ISSS = ISSS
            lEntidad.CIUO = CIUO
            lEntidad.EDAD = EDAD
            lEntidad.DEPARTAMENTO_NAC = DEPARTAMENTO_NAC
            lEntidad.MUNICIPIO_NAC = MUNICIPIO_NAC
            lEntidad.FECHA_NACIMIENTO = FECHA_NACIMIENTO
            lEntidad.DUI = DUI
            lEntidad.GENERO = GENERO
            lEntidad.DIRECCION = DIRECCION
            lEntidad.PROFESION_OFICIO = PROFESION_OFICIO
            lEntidad.ESTADO_CIVIL = ESTADO_CIVIL
            lEntidad.NOMBRE_FAMILIAR = NOMBRE_FAMILIAR
            lEntidad.PARENTESCO = PARENTESCO
            lEntidad.DIRECCION_FAMILIAR = DIRECCION_FAMILIAR
            lEntidad.TELEFONO_FAMILIAR = TELEFONO_FAMILIAR
            lEntidad.OCUACT_TRABAJA = OCUACT_TRABAJA
            lEntidad.OCUACT_ESTUDIA = OCUACT_ESTUDIA
            lEntidad.OCUACT_DESOCUPADO = OCUACT_DESOCUPADO
            lEntidad.OCUACT_OFICIO_HOGAR = OCUACT_OFICIO_HOGAR
            lEntidad.TIPTRA_EMPLEADO_EMPRESA = TIPTRA_EMPLEADO_EMPRESA
            lEntidad.TIPTRA_EMPRESA_PROPIA = TIPTRA_EMPRESA_PROPIA
            lEntidad.TIPTRA_EVENTUAL = TIPTRA_EVENTUAL
            lEntidad.TIPTRA_MEDIO_TIEMPO = TIPTRA_MEDIO_TIEMPO
            lEntidad.TIPTRA_INDEPENDIENTE = TIPTRA_INDEPENDIENTE
            lEntidad.RTC_OCUPACION_EMPRESA = RTC_OCUPACION_EMPRESA
            lEntidad.RTC_PROPIA_EMPRESA = RTC_PROPIA_EMPRESA
            lEntidad.RTC_TRABAJO_EVENTUAL = RTC_TRABAJO_EVENTUAL
            lEntidad.RTC_TRABAJO_MEDIO_TIEMPO = RTC_TRABAJO_MEDIO_TIEMPO
            lEntidad.RTC_INDEPENDIENTE = RTC_INDEPENDIENTE
            lEntidad.RTC_NO_OCUPACION_EMPRESA = RTC_NO_OCUPACION_EMPRESA
            lEntidad.RTC_NO_PROPIA_EMPRESA = RTC_NO_PROPIA_EMPRESA
            lEntidad.RTC_NO_TRABAJO_EVENTUAL = RTC_NO_TRABAJO_EVENTUAL
            lEntidad.RTC_NO_TRABAJO_MEDIO_TIEMPO = RTC_NO_TRABAJO_MEDIO_TIEMPO
            lEntidad.RTC_NO_INDEPENDIENTE = RTC_NO_INDEPENDIENTE
            lEntidad.NIVEL_ACADEMICO = NIVEL_ACADEMICO
            lEntidad.TITULO_CERTIFICADO_OBTENIDO = TITULO_CERTIFICADO_OBTENIDO
            lEntidad.TIEMPO_DEJO_ESTUDIAR = TIEMPO_DEJO_ESTUDIAR
            lEntidad.RECIBIO_CURSO_ANTERIOR = RECIBIO_CURSO_ANTERIOR
            lEntidad.OBTUVO_BENEFICIOS_CURSO = OBTUVO_BENEFICIOS_CURSO
            lEntidad.BENEF_PROM_EMP_ACT = BENEF_PROM_EMP_ACT
            lEntidad.BENEF_OBT_EMPLEO = BENEF_OBT_EMPLEO
            lEntidad.BENEF_OBT_ING_EXTRA = BENEF_OBT_ING_EXTRA
            lEntidad.BENEF_CAMB_EMP_X_CURSO = BENEF_CAMB_EMP_X_CURSO
            lEntidad.BENEF_TRAB_CTA_PROPIA = BENEF_TRAB_CTA_PROPIA
            lEntidad.BENEF_OTRO = BENEF_OTRO
            lEntidad.RAZON_NO_BENEFICIO = RAZON_NO_BENEFICIO
            lEntidad.TRABAJA_ACTUALMENTE = TRABAJA_ACTUALMENTE
            lEntidad.TRABAJO_ANTERIOR = TRABAJO_ANTERIOR
            lEntidad.EXPFOR_PROMOCION_EMPLEO = EXPFOR_PROMOCION_EMPLEO
            lEntidad.EXPFOR_CAMBIAR_EMPLEO = EXPFOR_CAMBIAR_EMPLEO
            lEntidad.EXPFOR_OBTENER_EMPLEO = EXPFOR_OBTENER_EMPLEO
            lEntidad.EXPFOR_TRABAJAR_CTA_PROPIA = EXPFOR_TRABAJAR_CTA_PROPIA
            lEntidad.EXPFOR_INGRESOS_EXTRAS = EXPFOR_INGRESOS_EXTRAS
            lEntidad.EXPFOR_OTRO = EXPFOR_OTRO
            lEntidad.INGRESO_MENSUAL_INDIVIDUAL = INGRESO_MENSUAL_INDIVIDUAL
            lEntidad.INGRESO_MENSUAL_FAMILIAR = INGRESO_MENSUAL_FAMILIAR
            lEntidad.MIEMBROS_GRUPO_FAMILIAR = MIEMBROS_GRUPO_FAMILIAR
            lEntidad.SUGERENCIAS = SUGERENCIAS
            lEntidad.LUGAR_PRESENTACION = LUGAR_PRESENTACION
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.USERID_HIST = USERID_HIST
            lEntidad.LASTUPDATE_HIST = LASTUPDATE_HIST
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            Return Me.ActualizarSOLICITUD_INSCRIPCION_AF_HIST(lEntidad)
        Catch ex as Exception
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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_INSCRIPCION_AF_HIST(ByVal aEntidad As SOLICITUD_INSCRIPCION_AF_HIST) As Integer
        Try
            Return mDb.Actualizar(aEntidad)
        Catch ex as Exception
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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_INSCRIPCION_AF_HIST(ByVal aEntidad As SOLICITUD_INSCRIPCION_AF_HIST, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_INSCRIPCION_AF_HIST(ByVal ID_SOLICITUD_HIST As Decimal, ByVal ID_SOLICITUD As Decimal, ByVal FECHA_PRESENTACION As DateTime, ByVal ID_PARTICIPANTE As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal NUMERO_DOCUMENTO As Decimal, ByVal ID_TIPO_SOLICITUD As Decimal, ByVal NIT_EMPRESA As String, ByVal NOMBRE_EMPRESA As String, ByVal CARGO As String, ByVal NUMERO_PATRONAL As String, ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal LUGAR_NACIMIENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_REGION As String, ByVal ZONA As String, ByVal TELEFONO As String, ByVal MOVIL As String, ByVal FAX As String, ByVal EMAIL As String, ByVal NIT As String, ByVal ISSS As String, ByVal CIUO As String, ByVal EDAD As Decimal, ByVal DEPARTAMENTO_NAC As String, ByVal MUNICIPIO_NAC As String, ByVal FECHA_NACIMIENTO As DateTime, ByVal DUI As String, ByVal GENERO As String, ByVal DIRECCION As String, ByVal PROFESION_OFICIO As String, ByVal ESTADO_CIVIL As String, ByVal NOMBRE_FAMILIAR As String, ByVal PARENTESCO As String, ByVal DIRECCION_FAMILIAR As String, ByVal TELEFONO_FAMILIAR As String, ByVal OCUACT_TRABAJA As Decimal, ByVal OCUACT_ESTUDIA As Decimal, ByVal OCUACT_DESOCUPADO As Decimal, ByVal OCUACT_OFICIO_HOGAR As Decimal, ByVal TIPTRA_EMPLEADO_EMPRESA As Decimal, ByVal TIPTRA_EMPRESA_PROPIA As Decimal, ByVal TIPTRA_EVENTUAL As Decimal, ByVal TIPTRA_MEDIO_TIEMPO As Decimal, ByVal TIPTRA_INDEPENDIENTE As Decimal, ByVal RTC_OCUPACION_EMPRESA As Decimal, ByVal RTC_PROPIA_EMPRESA As Decimal, ByVal RTC_TRABAJO_EVENTUAL As Decimal, ByVal RTC_TRABAJO_MEDIO_TIEMPO As Decimal, ByVal RTC_INDEPENDIENTE As Decimal, ByVal RTC_NO_OCUPACION_EMPRESA As Decimal, ByVal RTC_NO_PROPIA_EMPRESA As Decimal, ByVal RTC_NO_TRABAJO_EVENTUAL As Decimal, ByVal RTC_NO_TRABAJO_MEDIO_TIEMPO As Decimal, ByVal RTC_NO_INDEPENDIENTE As Decimal, ByVal NIVEL_ACADEMICO As String, ByVal TITULO_CERTIFICADO_OBTENIDO As String, ByVal TIEMPO_DEJO_ESTUDIAR As String, ByVal RECIBIO_CURSO_ANTERIOR As String, ByVal OBTUVO_BENEFICIOS_CURSO As String, ByVal BENEF_PROM_EMP_ACT As Decimal, ByVal BENEF_OBT_EMPLEO As Decimal, ByVal BENEF_OBT_ING_EXTRA As Decimal, ByVal BENEF_CAMB_EMP_X_CURSO As Decimal, ByVal BENEF_TRAB_CTA_PROPIA As Decimal, ByVal BENEF_OTRO As String, ByVal RAZON_NO_BENEFICIO As String, ByVal TRABAJA_ACTUALMENTE As String, ByVal TRABAJO_ANTERIOR As String, ByVal EXPFOR_PROMOCION_EMPLEO As Decimal, ByVal EXPFOR_CAMBIAR_EMPLEO As Decimal, ByVal EXPFOR_OBTENER_EMPLEO As Decimal, ByVal EXPFOR_TRABAJAR_CTA_PROPIA As Decimal, ByVal EXPFOR_INGRESOS_EXTRAS As Decimal, ByVal EXPFOR_OTRO As String, ByVal INGRESO_MENSUAL_INDIVIDUAL As String, ByVal INGRESO_MENSUAL_FAMILIAR As String, ByVal MIEMBROS_GRUPO_FAMILIAR As Decimal, ByVal SUGERENCIAS As String, ByVal LUGAR_PRESENTACION As String, ByVal ID_PROVEEDOR_AF As Decimal, ByVal USERID_HIST As String, ByVal LASTUPDATE_HIST As DateTime, ByVal USERID As String, ByVal LASTUPDATE As DateTime) As Integer
        Try
            Dim lEntidad As New SOLICITUD_INSCRIPCION_AF_HIST
            lEntidad.ID_SOLICITUD_HIST = ID_SOLICITUD_HIST
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.FECHA_PRESENTACION = FECHA_PRESENTACION
            lEntidad.ID_PARTICIPANTE = ID_PARTICIPANTE
            lEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            lEntidad.ID_ESTADO_SOLICITUD = ID_ESTADO_SOLICITUD
            lEntidad.NUMERO_DOCUMENTO = NUMERO_DOCUMENTO
            lEntidad.ID_TIPO_SOLICITUD = ID_TIPO_SOLICITUD
            lEntidad.NIT_EMPRESA = NIT_EMPRESA
            lEntidad.NOMBRE_EMPRESA = NOMBRE_EMPRESA
            lEntidad.CARGO = CARGO
            lEntidad.NUMERO_PATRONAL = NUMERO_PATRONAL
            lEntidad.NOMBRES = NOMBRES
            lEntidad.APELLIDOS = APELLIDOS
            lEntidad.LUGAR_NACIMIENTO = LUGAR_NACIMIENTO
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_REGION = CODIGO_REGION
            lEntidad.ZONA = ZONA
            lEntidad.TELEFONO = TELEFONO
            lEntidad.MOVIL = MOVIL
            lEntidad.FAX = FAX
            lEntidad.EMAIL = EMAIL
            lEntidad.NIT = NIT
            lEntidad.ISSS = ISSS
            lEntidad.CIUO = CIUO
            lEntidad.EDAD = EDAD
            lEntidad.DEPARTAMENTO_NAC = DEPARTAMENTO_NAC
            lEntidad.MUNICIPIO_NAC = MUNICIPIO_NAC
            lEntidad.FECHA_NACIMIENTO = FECHA_NACIMIENTO
            lEntidad.DUI = DUI
            lEntidad.GENERO = GENERO
            lEntidad.DIRECCION = DIRECCION
            lEntidad.PROFESION_OFICIO = PROFESION_OFICIO
            lEntidad.ESTADO_CIVIL = ESTADO_CIVIL
            lEntidad.NOMBRE_FAMILIAR = NOMBRE_FAMILIAR
            lEntidad.PARENTESCO = PARENTESCO
            lEntidad.DIRECCION_FAMILIAR = DIRECCION_FAMILIAR
            lEntidad.TELEFONO_FAMILIAR = TELEFONO_FAMILIAR
            lEntidad.OCUACT_TRABAJA = OCUACT_TRABAJA
            lEntidad.OCUACT_ESTUDIA = OCUACT_ESTUDIA
            lEntidad.OCUACT_DESOCUPADO = OCUACT_DESOCUPADO
            lEntidad.OCUACT_OFICIO_HOGAR = OCUACT_OFICIO_HOGAR
            lEntidad.TIPTRA_EMPLEADO_EMPRESA = TIPTRA_EMPLEADO_EMPRESA
            lEntidad.TIPTRA_EMPRESA_PROPIA = TIPTRA_EMPRESA_PROPIA
            lEntidad.TIPTRA_EVENTUAL = TIPTRA_EVENTUAL
            lEntidad.TIPTRA_MEDIO_TIEMPO = TIPTRA_MEDIO_TIEMPO
            lEntidad.TIPTRA_INDEPENDIENTE = TIPTRA_INDEPENDIENTE
            lEntidad.RTC_OCUPACION_EMPRESA = RTC_OCUPACION_EMPRESA
            lEntidad.RTC_PROPIA_EMPRESA = RTC_PROPIA_EMPRESA
            lEntidad.RTC_TRABAJO_EVENTUAL = RTC_TRABAJO_EVENTUAL
            lEntidad.RTC_TRABAJO_MEDIO_TIEMPO = RTC_TRABAJO_MEDIO_TIEMPO
            lEntidad.RTC_INDEPENDIENTE = RTC_INDEPENDIENTE
            lEntidad.RTC_NO_OCUPACION_EMPRESA = RTC_NO_OCUPACION_EMPRESA
            lEntidad.RTC_NO_PROPIA_EMPRESA = RTC_NO_PROPIA_EMPRESA
            lEntidad.RTC_NO_TRABAJO_EVENTUAL = RTC_NO_TRABAJO_EVENTUAL
            lEntidad.RTC_NO_TRABAJO_MEDIO_TIEMPO = RTC_NO_TRABAJO_MEDIO_TIEMPO
            lEntidad.RTC_NO_INDEPENDIENTE = RTC_NO_INDEPENDIENTE
            lEntidad.NIVEL_ACADEMICO = NIVEL_ACADEMICO
            lEntidad.TITULO_CERTIFICADO_OBTENIDO = TITULO_CERTIFICADO_OBTENIDO
            lEntidad.TIEMPO_DEJO_ESTUDIAR = TIEMPO_DEJO_ESTUDIAR
            lEntidad.RECIBIO_CURSO_ANTERIOR = RECIBIO_CURSO_ANTERIOR
            lEntidad.OBTUVO_BENEFICIOS_CURSO = OBTUVO_BENEFICIOS_CURSO
            lEntidad.BENEF_PROM_EMP_ACT = BENEF_PROM_EMP_ACT
            lEntidad.BENEF_OBT_EMPLEO = BENEF_OBT_EMPLEO
            lEntidad.BENEF_OBT_ING_EXTRA = BENEF_OBT_ING_EXTRA
            lEntidad.BENEF_CAMB_EMP_X_CURSO = BENEF_CAMB_EMP_X_CURSO
            lEntidad.BENEF_TRAB_CTA_PROPIA = BENEF_TRAB_CTA_PROPIA
            lEntidad.BENEF_OTRO = BENEF_OTRO
            lEntidad.RAZON_NO_BENEFICIO = RAZON_NO_BENEFICIO
            lEntidad.TRABAJA_ACTUALMENTE = TRABAJA_ACTUALMENTE
            lEntidad.TRABAJO_ANTERIOR = TRABAJO_ANTERIOR
            lEntidad.EXPFOR_PROMOCION_EMPLEO = EXPFOR_PROMOCION_EMPLEO
            lEntidad.EXPFOR_CAMBIAR_EMPLEO = EXPFOR_CAMBIAR_EMPLEO
            lEntidad.EXPFOR_OBTENER_EMPLEO = EXPFOR_OBTENER_EMPLEO
            lEntidad.EXPFOR_TRABAJAR_CTA_PROPIA = EXPFOR_TRABAJAR_CTA_PROPIA
            lEntidad.EXPFOR_INGRESOS_EXTRAS = EXPFOR_INGRESOS_EXTRAS
            lEntidad.EXPFOR_OTRO = EXPFOR_OTRO
            lEntidad.INGRESO_MENSUAL_INDIVIDUAL = INGRESO_MENSUAL_INDIVIDUAL
            lEntidad.INGRESO_MENSUAL_FAMILIAR = INGRESO_MENSUAL_FAMILIAR
            lEntidad.MIEMBROS_GRUPO_FAMILIAR = MIEMBROS_GRUPO_FAMILIAR
            lEntidad.SUGERENCIAS = SUGERENCIAS
            lEntidad.LUGAR_PRESENTACION = LUGAR_PRESENTACION
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.USERID_HIST = USERID_HIST
            lEntidad.LASTUPDATE_HIST = LASTUPDATE_HIST
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            Return Me.ActualizarSOLICITUD_INSCRIPCION_AF_HIST(lEntidad)
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
    ''' 	[GenApp]	21/09/2010	Created
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
    ''' 	[GenApp]	21/09/2010	Created
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
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF_HIST
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF_HIST As New ListaSOLICITUD_INSCRIPCION_AF_HIST
            mListaSOLICITUD_INSCRIPCION_AF_HIST = mDb.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF_HIST Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF_HIST in  mListaSOLICITUD_INSCRIPCION_AF_HIST
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF_HIST
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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF_HIST
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF_HIST As New ListaSOLICITUD_INSCRIPCION_AF_HIST
            mListaSOLICITUD_INSCRIPCION_AF_HIST = mDb.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF_HIST Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF_HIST in  mListaSOLICITUD_INSCRIPCION_AF_HIST
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF_HIST
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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorESTADO_SOLICITUD(ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF_HIST
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF_HIST As New ListaSOLICITUD_INSCRIPCION_AF_HIST
            mListaSOLICITUD_INSCRIPCION_AF_HIST = mDb.ObtenerListaPorESTADO_SOLICITUD(ID_ESTADO_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF_HIST Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF_HIST in  mListaSOLICITUD_INSCRIPCION_AF_HIST
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF_HIST
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CONTROL_DOCUMENTOS .
    ''' </summary>
    ''' <param name="NUMERO_DOCUMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCONTROL_DOCUMENTOS(ByVal NUMERO_DOCUMENTO As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF_HIST
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF_HIST As New ListaSOLICITUD_INSCRIPCION_AF_HIST
            mListaSOLICITUD_INSCRIPCION_AF_HIST = mDb.ObtenerListaPorCONTROL_DOCUMENTOS(NUMERO_DOCUMENTO, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF_HIST Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF_HIST in  mListaSOLICITUD_INSCRIPCION_AF_HIST
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF_HIST
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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_SOLICITUD(ByVal ID_TIPO_SOLICITUD As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF_HIST
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF_HIST As New ListaSOLICITUD_INSCRIPCION_AF_HIST
            mListaSOLICITUD_INSCRIPCION_AF_HIST = mDb.ObtenerListaPorTIPO_SOLICITUD(ID_TIPO_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF_HIST Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF_HIST in  mListaSOLICITUD_INSCRIPCION_AF_HIST
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF_HIST
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla EMPRESAS .
    ''' </summary>
    ''' <param name="NUMERO_PATRONAL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorEMPRESAS(ByVal NUMERO_PATRONAL As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF_HIST
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF_HIST As New ListaSOLICITUD_INSCRIPCION_AF_HIST
            mListaSOLICITUD_INSCRIPCION_AF_HIST = mDb.ObtenerListaPorEMPRESAS(NUMERO_PATRONAL, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF_HIST Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF_HIST in  mListaSOLICITUD_INSCRIPCION_AF_HIST
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF_HIST
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
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <param name="CODIGO_REGION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMUNICIPIO(ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF_HIST
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF_HIST As New ListaSOLICITUD_INSCRIPCION_AF_HIST
            mListaSOLICITUD_INSCRIPCION_AF_HIST = mDb.ObtenerListaPorMUNICIPIO(CODIGO_MUNICIPIO, CODIGO_REGION, CODIGO_DEPARTAMENTO, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF_HIST Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF_HIST in  mListaSOLICITUD_INSCRIPCION_AF_HIST
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF_HIST
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
    ''' <param name="CODIGO_REGION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorDEPARTAMENTO(ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF_HIST
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF_HIST As New ListaSOLICITUD_INSCRIPCION_AF_HIST
            mListaSOLICITUD_INSCRIPCION_AF_HIST = mDb.ObtenerListaPorDEPARTAMENTO(CODIGO_REGION, CODIGO_DEPARTAMENTO, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF_HIST Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF_HIST in  mListaSOLICITUD_INSCRIPCION_AF_HIST
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF_HIST
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla REGION .
    ''' </summary>
    ''' <param name="CODIGO_REGION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorREGION(ByVal CODIGO_REGION As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF_HIST
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF_HIST As New ListaSOLICITUD_INSCRIPCION_AF_HIST
            mListaSOLICITUD_INSCRIPCION_AF_HIST = mDb.ObtenerListaPorREGION(CODIGO_REGION, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF_HIST Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF_HIST in  mListaSOLICITUD_INSCRIPCION_AF_HIST
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF_HIST
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CIUO .
    ''' </summary>
    ''' <param name="CIUO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCIUO(ByVal CIUO As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF_HIST
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF_HIST As New ListaSOLICITUD_INSCRIPCION_AF_HIST
            mListaSOLICITUD_INSCRIPCION_AF_HIST = mDb.ObtenerListaPorCIUO(CIUO, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF_HIST Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF_HIST in  mListaSOLICITUD_INSCRIPCION_AF_HIST
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF_HIST
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
    ''' <param name="NIVEL_ACADEMICO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorNIVEL_ACADEMICO(ByVal NIVEL_ACADEMICO As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_AF_HIST
        Try
            Dim mListaSOLICITUD_INSCRIPCION_AF_HIST As New ListaSOLICITUD_INSCRIPCION_AF_HIST
            mListaSOLICITUD_INSCRIPCION_AF_HIST = mDb.ObtenerListaPorNIVEL_ACADEMICO(NIVEL_ACADEMICO, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_AF_HIST Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_AF_HIST in  mListaSOLICITUD_INSCRIPCION_AF_HIST
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_AF_HIST
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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SOLICITUD_INSCRIPCION_AF_HIST )
        aEntidad.fkID_PARTICIPANTE = (New cPARTICIPANTE).ObtenerPARTICIPANTE(aEntidad.ID_PARTICIPANTE)
        aEntidad.fkID_ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
        aEntidad.fkID_ESTADO_SOLICITUD = (New cESTADO_SOLICITUD).ObtenerESTADO_SOLICITUD(aEntidad.ID_ESTADO_SOLICITUD)
        aEntidad.fkNUMERO_DOCUMENTO = (New cCONTROL_DOCUMENTOS).ObtenerCONTROL_DOCUMENTOS(aEntidad.NUMERO_DOCUMENTO)
        aEntidad.fkID_TIPO_SOLICITUD = (New cTIPO_SOLICITUD).ObtenerTIPO_SOLICITUD(aEntidad.ID_TIPO_SOLICITUD)
        aEntidad.fkNUMERO_PATRONAL = (New cEMPRESAS).ObtenerEMPRESAS(aEntidad.NUMERO_PATRONAL)
        aEntidad.fkCODIGO_MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(aEntidad.CODIGO_MUNICIPIO, aEntidad.CODIGO_REGION, aEntidad.CODIGO_DEPARTAMENTO)
        aEntidad.fkCODIGO_DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(aEntidad.CODIGO_REGION, aEntidad.CODIGO_DEPARTAMENTO)
        aEntidad.fkCODIGO_REGION = (New cREGION).ObtenerREGION(aEntidad.CODIGO_REGION)
        aEntidad.fkCIUO = (New cCIUO).ObtenerCIUO(aEntidad.CIUO)
        aEntidad.fkNIVEL_ACADEMICO = (New cNIVEL_ACADEMICO).ObtenerNIVEL_ACADEMICO(aEntidad.NIVEL_ACADEMICO)
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
    ''' 	[GenApp]	21/09/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SOLICITUD_INSCRIPCION_AF_HIST )
    End Sub

#End Region

End Class
