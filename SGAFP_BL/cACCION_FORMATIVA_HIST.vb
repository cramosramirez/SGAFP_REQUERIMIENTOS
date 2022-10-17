''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cACCION_FORMATIVA_HIST
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla ACCION_FORMATIVA_HIST
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	13/05/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cACCION_FORMATIVA_HIST
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb As New dbACCION_FORMATIVA_HIST()
    Private mEntidad As New ACCION_FORMATIVA_HIST
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As ListaACCION_FORMATIVA_HIST
        Try
            Dim mListaACCION_FORMATIVA_HIST As New ListaACCION_FORMATIVA_HIST
            mListaACCION_FORMATIVA_HIST = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            Return mListaACCION_FORMATIVA_HIST
        Catch ex As Exception
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
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	13/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerACCION_FORMATIVA_HIST(ByRef aEntidad As ACCION_FORMATIVA_HIST) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
            Return liRet
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla ACCION_FORMATIVA_HIST.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA_HIST"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerACCION_FORMATIVA_HIST(ByVal ID_ACCION_FORMATIVA_HIST As Decimal) As ACCION_FORMATIVA_HIST
        Try
            Dim lEntidad As New ACCION_FORMATIVA_HIST
            lEntidad.ID_ACCION_FORMATIVA_HIST = ID_ACCION_FORMATIVA_HIST
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet = 1 Then Return lEntidad
            Return Nothing
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ACCION_FORMATIVA_HIST que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA_HIST"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarACCION_FORMATIVA_HIST(ByVal ID_ACCION_FORMATIVA_HIST As Decimal) As Integer
        Try
            mEntidad.ID_ACCION_FORMATIVA_HIST = ID_ACCION_FORMATIVA_HIST
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ACCION_FORMATIVA_HIST que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	13/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarACCION_FORMATIVA_HIST(ByVal aEntidad As ACCION_FORMATIVA_HIST, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Eliminar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
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
    ''' 	[GenApp]	13/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarACCION_FORMATIVA_HIST(ByVal ID_ACCION_FORMATIVA_HIST As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_TEMA_CURSO As Decimal, ByVal ID_EJERCICIO As String, ByVal NOMBRE_ACCION_FORMATIVA As String, ByVal CODIGO_GRUPO As String, ByVal NUMERO_PARTICIPANTES As Decimal, ByVal PARTICIPANTES_INSCRITOS As Decimal, ByVal HORARIO As String, ByVal NOTAS As String, ByVal CODIGO_ESTADO_AF As String, ByVal DURACION_HORAS As Decimal, ByVal COSTO_X_PARTICIPANTE As Decimal, ByVal LASTUPDATE As DateTime, ByVal USERID As String, ByVal FECHA_INICIO_REAL As DateTime, ByVal FECHA_FIN_REAL As DateTime, ByVal OBSERVACIONES As String, ByVal ID_ACCION_CONTRATADA As Decimal, ByVal CODI_FORMADOR As String, ByVal NOMBRE_FORMADOR As String) As Integer
        Try
            Dim lEntidad As New ACCION_FORMATIVA_HIST
            lEntidad.ID_ACCION_FORMATIVA_HIST = ID_ACCION_FORMATIVA_HIST
            lEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            lEntidad.ID_OFERTA_FORMATIVA = ID_OFERTA_FORMATIVA
            lEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.ID_TEMA_CURSO = ID_TEMA_CURSO
            lEntidad.ID_EJERCICIO = ID_EJERCICIO
            lEntidad.NOMBRE_ACCION_FORMATIVA = NOMBRE_ACCION_FORMATIVA
            lEntidad.CODIGO_GRUPO = CODIGO_GRUPO
            lEntidad.NUMERO_PARTICIPANTES = NUMERO_PARTICIPANTES
            lEntidad.PARTICIPANTES_INSCRITOS = PARTICIPANTES_INSCRITOS
            lEntidad.HORARIO = HORARIO
            lEntidad.NOTAS = NOTAS
            lEntidad.CODIGO_ESTADO_AF = CODIGO_ESTADO_AF
            lEntidad.DURACION_HORAS = DURACION_HORAS
            lEntidad.COSTO_X_PARTICIPANTE = COSTO_X_PARTICIPANTE
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.USERID = USERID
            lEntidad.FECHA_INICIO_REAL = FECHA_INICIO_REAL
            lEntidad.FECHA_FIN_REAL = FECHA_FIN_REAL
            lEntidad.OBSERVACIONES = OBSERVACIONES
            lEntidad.ID_ACCION_CONTRATADA = ID_ACCION_CONTRATADA
            lEntidad.CODI_FORMADOR = CODI_FORMADOR
            lEntidad.NOMBRE_FORMADOR = NOMBRE_FORMADOR
            Return Me.ActualizarACCION_FORMATIVA_HIST(lEntidad)
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
    ''' 	[GenApp]	13/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_FORMATIVA_HIST(ByVal aEntidad As ACCION_FORMATIVA_HIST) As Integer
        Try
            Return mDb.Actualizar(aEntidad)
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
    ''' 	[GenApp]	13/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_FORMATIVA_HIST(ByVal aEntidad As ACCION_FORMATIVA_HIST, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            Return mDb.Actualizar(aEntidad, aTipoConcurrencia)
        Catch ex As Exception
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
    ''' 	[GenApp]	13/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_FORMATIVA_HIST(ByVal ID_ACCION_FORMATIVA_HIST As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_TEMA_CURSO As Decimal, ByVal ID_EJERCICIO As String, ByVal NOMBRE_ACCION_FORMATIVA As String, ByVal CODIGO_GRUPO As String, ByVal NUMERO_PARTICIPANTES As Decimal, ByVal PARTICIPANTES_INSCRITOS As Decimal, ByVal HORARIO As String, ByVal NOTAS As String, ByVal CODIGO_ESTADO_AF As String, ByVal DURACION_HORAS As Decimal, ByVal COSTO_X_PARTICIPANTE As Decimal, ByVal LASTUPDATE As DateTime, ByVal USERID As String, ByVal FECHA_INICIO_REAL As DateTime, ByVal FECHA_FIN_REAL As DateTime, ByVal OBSERVACIONES As String, ByVal ID_ACCION_CONTRATADA As Decimal, ByVal CODI_FORMADOR As String, ByVal NOMBRE_FORMADOR As String) As Integer
        Try
            Dim lEntidad As New ACCION_FORMATIVA_HIST
            lEntidad.ID_ACCION_FORMATIVA_HIST = ID_ACCION_FORMATIVA_HIST
            lEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            lEntidad.ID_OFERTA_FORMATIVA = ID_OFERTA_FORMATIVA
            lEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.ID_TEMA_CURSO = ID_TEMA_CURSO
            lEntidad.ID_EJERCICIO = ID_EJERCICIO
            lEntidad.NOMBRE_ACCION_FORMATIVA = NOMBRE_ACCION_FORMATIVA
            lEntidad.CODIGO_GRUPO = CODIGO_GRUPO
            lEntidad.NUMERO_PARTICIPANTES = NUMERO_PARTICIPANTES
            lEntidad.PARTICIPANTES_INSCRITOS = PARTICIPANTES_INSCRITOS
            lEntidad.HORARIO = HORARIO
            lEntidad.NOTAS = NOTAS
            lEntidad.CODIGO_ESTADO_AF = CODIGO_ESTADO_AF
            lEntidad.DURACION_HORAS = DURACION_HORAS
            lEntidad.COSTO_X_PARTICIPANTE = COSTO_X_PARTICIPANTE
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.USERID = USERID
            lEntidad.FECHA_INICIO_REAL = FECHA_INICIO_REAL
            lEntidad.FECHA_FIN_REAL = FECHA_FIN_REAL
            lEntidad.OBSERVACIONES = OBSERVACIONES
            lEntidad.ID_ACCION_CONTRATADA = ID_ACCION_CONTRATADA
            lEntidad.CODI_FORMADOR = CODI_FORMADOR
            lEntidad.NOMBRE_FORMADOR = NOMBRE_FORMADOR
            Return Me.ActualizarACCION_FORMATIVA_HIST(lEntidad)
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
    ''' 	[GenApp]	13/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorId(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorID(asColumnaOrden, asTipoOrden)
        Catch ex As Exception
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
    ''' 	[GenApp]	13/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, False)> _
    Public Function ObtenerDataSetPorId(ByRef ds As DataSet, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As Integer
        Try
            Return mDb.ObtenerDataSetPorID(ds, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
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
    ''' 	[GenApp]	13/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As ACCION_FORMATIVA_HIST)
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
    ''' 	[GenApp]	13/05/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As ACCION_FORMATIVA_HIST)
    End Sub

#End Region

End Class
