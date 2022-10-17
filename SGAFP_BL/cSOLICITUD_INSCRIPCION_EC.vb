''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cSOLICITUD_INSCRIPCION_EC
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SOLICITUD_INSCRIPCION_EC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	23/07/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSOLICITUD_INSCRIPCION_EC
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSOLICITUD_INSCRIPCION_EC()
    Private mEntidad as New SOLICITUD_INSCRIPCION_EC
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_EC
        Try
            Dim mListaSOLICITUD_INSCRIPCION_EC As New ListaSOLICITUD_INSCRIPCION_EC
            mListaSOLICITUD_INSCRIPCION_EC = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_EC in  mListaSOLICITUD_INSCRIPCION_EC
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_EC
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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSOLICITUD_INSCRIPCION_EC(ByRef aEntidad As SOLICITUD_INSCRIPCION_EC, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SOLICITUD_INSCRIPCION_EC.
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSOLICITUD_INSCRIPCION_EC(ByVal ID_SOLICITUD As Decimal, ByVal Optional recuperarForaneas As Boolean = False) As SOLICITUD_INSCRIPCION_EC
        Try
            Dim lEntidad As New SOLICITUD_INSCRIPCION_EC
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
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
    ''' <param name="aSOLICITUD_INSCRIPCION_AF">Recuperar registro foraneo de la Entidad SOLICITUD_INSCRIPCION_AF.</param>
    ''' <param name="aSOLICITUD_PRESELECCION_EC">Recuperar registro foraneo de la Entidad SOLICITUD_PRESELECCION_EC.</param>
    ''' <param name="aACTI_ECONOMICA">Recuperar registro foraneo de la Entidad ACTI_ECONOMICA.</param>
    ''' <param name="aAREA_EMPRESA">Recuperar registro foraneo de la Entidad AREA_EMPRESA.</param>
    ''' <param name="aGRUPO_SELECCION">Recuperar registro foraneo de la Entidad GRUPO_SELECCION.</param>
    ''' <param name="aINGRESO_MES">Recuperar registro foraneo de la Entidad INGRESO_MES.</param>
    ''' <param name="aMOTIVO_DEJO_ESTU">Recuperar registro foraneo de la Entidad MOTIVO_DEJO_ESTU.</param>
    ''' <param name="aMOTIVO_DEJO_TRAB">Recuperar registro foraneo de la Entidad MOTIVO_DEJO_TRAB.</param>
    ''' <param name="aTIEMPO_NOTRAB">Recuperar registro foraneo de la Entidad TIEMPO_NOTRAB.</param>
    ''' <param name="aTIPO_SELECC">Recuperar registro foraneo de la Entidad TIPO_SELECC.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSOLICITUD_INSCRIPCION_ECConForaneas(ByVal aEntidad As SOLICITUD_INSCRIPCION_EC, Optional ByVal aSOLICITUD_INSCRIPCION_AF As Boolean = False, Optional ByVal aSOLICITUD_PRESELECCION_EC As Boolean = False, Optional ByVal aACTI_ECONOMICA As Boolean = False, Optional ByVal aAREA_EMPRESA As Boolean = False, Optional ByVal aGRUPO_SELECCION As Boolean = False, Optional ByVal aINGRESO_MES As Boolean = False, Optional ByVal aMOTIVO_DEJO_ESTU As Boolean = False, Optional ByVal aMOTIVO_DEJO_TRAB As Boolean = False, Optional ByVal aTIEMPO_NOTRAB As Boolean = False, Optional ByVal aTIPO_SELECC As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aSOLICITUD_INSCRIPCION_AF, aSOLICITUD_PRESELECCION_EC, aACTI_ECONOMICA, aAREA_EMPRESA, aGRUPO_SELECCION, aINGRESO_MES, aMOTIVO_DEJO_ESTU, aMOTIVO_DEJO_TRAB, aTIEMPO_NOTRAB, aTIPO_SELECC)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_INSCRIPCION_EC que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLICITUD_INSCRIPCION_EC(ByVal ID_SOLICITUD As Decimal) As Integer
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
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_INSCRIPCION_EC que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLICITUD_INSCRIPCION_EC(ByVal aEntidad As SOLICITUD_INSCRIPCION_EC, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSOLICITUD_INSCRIPCION_EC(ByVal ID_SOLICITUD As Decimal, ByVal ID_SOLIC_PRESELEC As Decimal, ByVal ID_ACTI_ECONOMICA As Decimal, ByVal ID_AREA_EMPRESA As Decimal, ByVal ID_GRUPO_SELEC As Decimal, ByVal ID_INGRESO_MES As Decimal, ByVal ID_MOTIVO_DEJO_ESTU As Decimal, ByVal ID_MOTIVO_DEJO_TRAB As Decimal, ByVal ID_TIEMPO_NOTRAB As Decimal, ByVal ID_TIPO_SELECC As Decimal, ByVal ID_ULT_SALARIO_MES As Decimal, ByVal MANERA_OBT_ING_BECA As String, ByVal MOTIVO_ELIGIO_CARRERA As String, ByVal OCUACT_ESTU_TRAB As Decimal, ByVal OTRO_MOTIVO_DEJO_ESTU As String, ByVal USUARIO_CREA As String, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal FECHA_CREACION As DateTime) As Integer
        Try
            Dim lEntidad As New SOLICITUD_INSCRIPCION_EC
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_SOLIC_PRESELEC = ID_SOLIC_PRESELEC
            lEntidad.ID_ACTI_ECONOMICA = ID_ACTI_ECONOMICA
            lEntidad.ID_AREA_EMPRESA = ID_AREA_EMPRESA
            lEntidad.ID_GRUPO_SELEC = ID_GRUPO_SELEC
            lEntidad.ID_INGRESO_MES = ID_INGRESO_MES
            lEntidad.ID_MOTIVO_DEJO_ESTU = ID_MOTIVO_DEJO_ESTU
            lEntidad.ID_MOTIVO_DEJO_TRAB = ID_MOTIVO_DEJO_TRAB
            lEntidad.ID_TIEMPO_NOTRAB = ID_TIEMPO_NOTRAB
            lEntidad.ID_TIPO_SELECC = ID_TIPO_SELECC
            lEntidad.ID_ULT_SALARIO_MES = ID_ULT_SALARIO_MES
            lEntidad.MANERA_OBT_ING_BECA = MANERA_OBT_ING_BECA
            lEntidad.MOTIVO_ELIGIO_CARRERA = MOTIVO_ELIGIO_CARRERA
            lEntidad.OCUACT_ESTU_TRAB = OCUACT_ESTU_TRAB
            lEntidad.OTRO_MOTIVO_DEJO_ESTU = OTRO_MOTIVO_DEJO_ESTU
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.FECHA_CREACION = FECHA_CREACION
            Return Me.AgregarSOLICITUD_INSCRIPCION_EC(lEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Ingresa un registro de la Entidad que recibe como parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados al menos los
    ''' valores de la Llave Primaria, para su inserción.</remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSOLICITUD_INSCRIPCION_EC(ByVal aEntidad As SOLICITUD_INSCRIPCION_EC) As Integer
        Try
            Return mDb.Agregar(aEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro de la Entidad que recibe de parámetro.
    ''' </summary>
    ''' <param name="aEntidad">Entidad que contiene los datos a Actualizar o Ingresar.</param>
    ''' <remarks>La entidad ya debe estar inicializada. Si es una tabla de Muchos a Muchos
    ''' este método unicamente actualiza el registro. Si no es una tabla de Muchos a Muchos
    ''' puede Actualizar o insertar un registro, dependiendo si la llave única trae un valor
    ''' de Cero(0) para ser autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_INSCRIPCION_EC(ByVal aEntidad As SOLICITUD_INSCRIPCION_EC) As Integer
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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_INSCRIPCION_EC(ByVal aEntidad As SOLICITUD_INSCRIPCION_EC, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Actualiza un registro que recibe de parámetro.
    ''' </summary>
    ''' <remarks>Si es una tabla de Muchos a Muchos este método unicamente actualiza el 
    ''' registro. Si no es una tabla de Muchos a Muchos puede Actualizar o insertar un 
    ''' registro, dependiendo si la llave única trae un valor de Cero(0) para ser 
    ''' autoincrementada por el método de la Clase de Acceso a Datos.</remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_INSCRIPCION_EC(ByVal ID_SOLICITUD As Decimal, ByVal ID_SOLIC_PRESELEC As Decimal, ByVal ID_ACTI_ECONOMICA As Decimal, ByVal ID_AREA_EMPRESA As Decimal, ByVal ID_GRUPO_SELEC As Decimal, ByVal ID_INGRESO_MES As Decimal, ByVal ID_MOTIVO_DEJO_ESTU As Decimal, ByVal ID_MOTIVO_DEJO_TRAB As Decimal, ByVal ID_TIEMPO_NOTRAB As Decimal, ByVal ID_TIPO_SELECC As Decimal, ByVal ID_ULT_SALARIO_MES As Decimal, ByVal MANERA_OBT_ING_BECA As String, ByVal MOTIVO_ELIGIO_CARRERA As String, ByVal OCUACT_ESTU_TRAB As Decimal, ByVal OTRO_MOTIVO_DEJO_ESTU As String, ByVal USUARIO_CREA As String, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime, ByVal FECHA_CREACION As DateTime) As Integer
        Try
            Dim lEntidad As New SOLICITUD_INSCRIPCION_EC
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_SOLIC_PRESELEC = ID_SOLIC_PRESELEC
            lEntidad.ID_ACTI_ECONOMICA = ID_ACTI_ECONOMICA
            lEntidad.ID_AREA_EMPRESA = ID_AREA_EMPRESA
            lEntidad.ID_GRUPO_SELEC = ID_GRUPO_SELEC
            lEntidad.ID_INGRESO_MES = ID_INGRESO_MES
            lEntidad.ID_MOTIVO_DEJO_ESTU = ID_MOTIVO_DEJO_ESTU
            lEntidad.ID_MOTIVO_DEJO_TRAB = ID_MOTIVO_DEJO_TRAB
            lEntidad.ID_TIEMPO_NOTRAB = ID_TIEMPO_NOTRAB
            lEntidad.ID_TIPO_SELECC = ID_TIPO_SELECC
            lEntidad.ID_ULT_SALARIO_MES = ID_ULT_SALARIO_MES
            lEntidad.MANERA_OBT_ING_BECA = MANERA_OBT_ING_BECA
            lEntidad.MOTIVO_ELIGIO_CARRERA = MOTIVO_ELIGIO_CARRERA
            lEntidad.OCUACT_ESTU_TRAB = OCUACT_ESTU_TRAB
            lEntidad.OTRO_MOTIVO_DEJO_ESTU = OTRO_MOTIVO_DEJO_ESTU
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            lEntidad.FECHA_CREACION = FECHA_CREACION
            Return Me.ActualizarSOLICITUD_INSCRIPCION_EC(lEntidad)
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
    ''' 	[GenApp]	23/07/2019	Created
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
    ''' 	[GenApp]	23/07/2019	Created
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
    ''' la Tabla SOLICITUD_INSCRIPCION_AF .
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSOLICITUD_INSCRIPCION_AF(ByVal ID_SOLICITUD As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_EC
        Try
            Dim mListaSOLICITUD_INSCRIPCION_EC As New ListaSOLICITUD_INSCRIPCION_EC
            mListaSOLICITUD_INSCRIPCION_EC = mDb.ObtenerListaPorSOLICITUD_INSCRIPCION_AF(ID_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_EC in  mListaSOLICITUD_INSCRIPCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SOLICITUD_PRESELECCION_EC .
    ''' </summary>
    ''' <param name="ID_SOLIC_PRESELEC"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSOLICITUD_PRESELECCION_EC(ByVal ID_SOLIC_PRESELEC As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_EC
        Try
            Dim mListaSOLICITUD_INSCRIPCION_EC As New ListaSOLICITUD_INSCRIPCION_EC
            mListaSOLICITUD_INSCRIPCION_EC = mDb.ObtenerListaPorSOLICITUD_PRESELECCION_EC(ID_SOLIC_PRESELEC, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_EC in  mListaSOLICITUD_INSCRIPCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_EC
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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorACTI_ECONOMICA(ByVal ID_ACTI_ECONOMICA As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_EC
        Try
            Dim mListaSOLICITUD_INSCRIPCION_EC As New ListaSOLICITUD_INSCRIPCION_EC
            mListaSOLICITUD_INSCRIPCION_EC = mDb.ObtenerListaPorACTI_ECONOMICA(ID_ACTI_ECONOMICA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_EC in  mListaSOLICITUD_INSCRIPCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_EC
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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorAREA_EMPRESA(ByVal ID_AREA_EMPRESA As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_EC
        Try
            Dim mListaSOLICITUD_INSCRIPCION_EC As New ListaSOLICITUD_INSCRIPCION_EC
            mListaSOLICITUD_INSCRIPCION_EC = mDb.ObtenerListaPorAREA_EMPRESA(ID_AREA_EMPRESA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_EC in  mListaSOLICITUD_INSCRIPCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_EC
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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorGRUPO_SELECCION(ByVal ID_GRUPO_SELEC As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_EC
        Try
            Dim mListaSOLICITUD_INSCRIPCION_EC As New ListaSOLICITUD_INSCRIPCION_EC
            mListaSOLICITUD_INSCRIPCION_EC = mDb.ObtenerListaPorGRUPO_SELECCION(ID_GRUPO_SELEC, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_EC in  mListaSOLICITUD_INSCRIPCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_EC
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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorINGRESO_MES(ByVal ID_INGRESO_MES As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_EC
        Try
            Dim mListaSOLICITUD_INSCRIPCION_EC As New ListaSOLICITUD_INSCRIPCION_EC
            mListaSOLICITUD_INSCRIPCION_EC = mDb.ObtenerListaPorINGRESO_MES(ID_INGRESO_MES, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_EC in  mListaSOLICITUD_INSCRIPCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_EC
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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMOTIVO_DEJO_ESTU(ByVal ID_MOTIVO_DEJO_ESTU As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_EC
        Try
            Dim mListaSOLICITUD_INSCRIPCION_EC As New ListaSOLICITUD_INSCRIPCION_EC
            mListaSOLICITUD_INSCRIPCION_EC = mDb.ObtenerListaPorMOTIVO_DEJO_ESTU(ID_MOTIVO_DEJO_ESTU, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_EC in  mListaSOLICITUD_INSCRIPCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_EC
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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMOTIVO_DEJO_TRAB(ByVal ID_MOTIVO_DEJO_TRAB As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_EC
        Try
            Dim mListaSOLICITUD_INSCRIPCION_EC As New ListaSOLICITUD_INSCRIPCION_EC
            mListaSOLICITUD_INSCRIPCION_EC = mDb.ObtenerListaPorMOTIVO_DEJO_TRAB(ID_MOTIVO_DEJO_TRAB, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_EC in  mListaSOLICITUD_INSCRIPCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_EC
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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIEMPO_NOTRAB(ByVal ID_TIEMPO_NOTRAB As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_EC
        Try
            Dim mListaSOLICITUD_INSCRIPCION_EC As New ListaSOLICITUD_INSCRIPCION_EC
            mListaSOLICITUD_INSCRIPCION_EC = mDb.ObtenerListaPorTIEMPO_NOTRAB(ID_TIEMPO_NOTRAB, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_EC in  mListaSOLICITUD_INSCRIPCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_EC
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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_SELECC(ByVal ID_TIPO_SELECC As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_INSCRIPCION_EC
        Try
            Dim mListaSOLICITUD_INSCRIPCION_EC As New ListaSOLICITUD_INSCRIPCION_EC
            mListaSOLICITUD_INSCRIPCION_EC = mDb.ObtenerListaPorTIPO_SELECC(ID_TIPO_SELECC, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_INSCRIPCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_INSCRIPCION_EC in  mListaSOLICITUD_INSCRIPCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_INSCRIPCION_EC
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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SOLICITUD_INSCRIPCION_EC )
        aEntidad.fkID_SOLIC_PRESELEC = (New cSOLICITUD_PRESELECCION_EC).ObtenerSOLICITUD_PRESELECCION_EC(aEntidad.ID_SOLIC_PRESELEC)
        aEntidad.fkID_ACTI_ECONOMICA = (New cACTI_ECONOMICA).ObtenerACTI_ECONOMICA(aEntidad.ID_ACTI_ECONOMICA)
        aEntidad.fkID_AREA_EMPRESA = (New cAREA_EMPRESA).ObtenerAREA_EMPRESA(aEntidad.ID_AREA_EMPRESA)
        aEntidad.fkID_GRUPO_SELEC = (New cGRUPO_SELECCION).ObtenerGRUPO_SELECCION(aEntidad.ID_GRUPO_SELEC)
        aEntidad.fkID_INGRESO_MES = (New cINGRESO_MES).ObtenerINGRESO_MES(aEntidad.ID_INGRESO_MES)
        aEntidad.fkID_MOTIVO_DEJO_ESTU = (New cMOTIVO_DEJO_ESTU).ObtenerMOTIVO_DEJO_ESTU(aEntidad.ID_MOTIVO_DEJO_ESTU)
        aEntidad.fkID_MOTIVO_DEJO_TRAB = (New cMOTIVO_DEJO_TRAB).ObtenerMOTIVO_DEJO_TRAB(aEntidad.ID_MOTIVO_DEJO_TRAB)
        aEntidad.fkID_TIEMPO_NOTRAB = (New cTIEMPO_NOTRAB).ObtenerTIEMPO_NOTRAB(aEntidad.ID_TIEMPO_NOTRAB)
        aEntidad.fkID_TIPO_SELECC = (New cTIPO_SELECC).ObtenerTIPO_SELECC(aEntidad.ID_TIPO_SELECC)
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
    ''' 	[GenApp]	23/07/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SOLICITUD_INSCRIPCION_EC )
    End Sub

#End Region

End Class
