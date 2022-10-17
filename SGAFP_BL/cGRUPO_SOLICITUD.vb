''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cGRUPO_SOLICITUD
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla GRUPO_SOLICITUD
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cGRUPO_SOLICITUD
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbGRUPO_SOLICITUD()
    Private mEntidad As New GRUPO_SOLICITUD
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As ListaGRUPO_SOLICITUD
        Try
            Dim mListaGRUPO_SOLICITUD As New ListaGRUPO_SOLICITUD
            mListaGRUPO_SOLICITUD = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaGRUPO_SOLICITUD Is Nothing And recuperarForaneas Then
                For Each lEntidad As GRUPO_SOLICITUD In mListaGRUPO_SOLICITUD
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaGRUPO_SOLICITUD
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
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerGRUPO_SOLICITUD(ByRef aEntidad As GRUPO_SOLICITUD, Optional ByVal recuperarForaneas As Boolean = False) As Integer
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
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla GRUPO_SOLICITUD.
    ''' </summary>
    ''' <param name="ID_GRUPO_SOLICITUD"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerGRUPO_SOLICITUD(ByVal ID_GRUPO_SOLICITUD As Decimal, Optional ByVal recuperarForaneas As Boolean = False) As GRUPO_SOLICITUD
        Try
            Dim lEntidad As New GRUPO_SOLICITUD
            lEntidad.ID_GRUPO_SOLICITUD = ID_GRUPO_SOLICITUD
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
        Catch ex As Exception
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
    ''' <param name="aSOLICITUD_CAPACITACION">Recuperar registro foraneo de la Entidad SOLICITUD_CAPACITACION.</param>
    ''' <param name="aMODALIDAD_DE_FORMACION">Recuperar registro foraneo de la Entidad MODALIDAD_DE_FORMACION.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerGRUPO_SOLICITUDConForaneas(ByVal aEntidad As GRUPO_SOLICITUD, Optional ByVal aSOLICITUD_CAPACITACION As Boolean = False, Optional ByVal aMODALIDAD_DE_FORMACION As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aSOLICITUD_CAPACITACION, aMODALIDAD_DE_FORMACION)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla GRUPO_SOLICITUD que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_GRUPO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarGRUPO_SOLICITUD(ByVal ID_GRUPO_SOLICITUD As Decimal) As Integer
        Try
            mEntidad.ID_GRUPO_SOLICITUD = ID_GRUPO_SOLICITUD
            Return mDb.Eliminar(mEntidad)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla GRUPO_SOLICITUD que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarGRUPO_SOLICITUD(ByVal aEntidad As GRUPO_SOLICITUD, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarGRUPO_SOLICITUD(ByVal ID_GRUPO_SOLICITUD As Decimal, ByVal ID_SOLICITUD As Decimal, ByVal ID_MODALIDAD_FORMACION As Decimal, ByVal CODIGO_PROGRAMA As String, ByVal DURACION_HORAS As Decimal, ByVal NUM_PARTICIPANTES As Decimal, ByVal TDR As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal CORRELATIVO_GRUPO As Decimal, ByVal USUARIO_CREACION As String, ByVal FECHA_CREACION As DateTime, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal LUGAR_EJECUCION As String, ByVal NOMBRE_ACCION_FORMATIVA As String) As Integer
        Try
            Dim lEntidad As New GRUPO_SOLICITUD
            lEntidad.ID_GRUPO_SOLICITUD = ID_GRUPO_SOLICITUD
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_MODALIDAD_FORMACION = ID_MODALIDAD_FORMACION
            lEntidad.CODIGO_PROGRAMA = CODIGO_PROGRAMA
            lEntidad.DURACION_HORAS = DURACION_HORAS
            lEntidad.NUM_PARTICIPANTES = NUM_PARTICIPANTES
            lEntidad.TDR = TDR
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.CORRELATIVO_GRUPO = CORRELATIVO_GRUPO
            lEntidad.USUARIO_CREACION = USUARIO_CREACION
            lEntidad.FECHA_CREACION = FECHA_CREACION
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.LUGAR_EJECUCION = LUGAR_EJECUCION
            lEntidad.NOMBRE_ACCION_FORMATIVA = NOMBRE_ACCION_FORMATIVA
            Return Me.ActualizarGRUPO_SOLICITUD(lEntidad)
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarGRUPO_SOLICITUD(ByVal aEntidad As GRUPO_SOLICITUD) As Integer
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarGRUPO_SOLICITUD(ByVal aEntidad As GRUPO_SOLICITUD, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarGRUPO_SOLICITUD(ByVal ID_GRUPO_SOLICITUD As Decimal, ByVal ID_SOLICITUD As Decimal, ByVal ID_MODALIDAD_FORMACION As Decimal, ByVal CODIGO_PROGRAMA As String, ByVal DURACION_HORAS As Decimal, ByVal NUM_PARTICIPANTES As Decimal, ByVal TDR As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal CORRELATIVO_GRUPO As Decimal, ByVal USUARIO_CREACION As String, ByVal FECHA_CREACION As DateTime, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal LUGAR_EJECUCION As String, ByVal NOMBRE_ACCION_FORMATIVA As String) As Integer
        Try
            Dim lEntidad As New GRUPO_SOLICITUD
            lEntidad.ID_GRUPO_SOLICITUD = ID_GRUPO_SOLICITUD
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_MODALIDAD_FORMACION = ID_MODALIDAD_FORMACION
            lEntidad.CODIGO_PROGRAMA = CODIGO_PROGRAMA
            lEntidad.DURACION_HORAS = DURACION_HORAS
            lEntidad.NUM_PARTICIPANTES = NUM_PARTICIPANTES
            lEntidad.TDR = TDR
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.CORRELATIVO_GRUPO = CORRELATIVO_GRUPO
            lEntidad.USUARIO_CREACION = USUARIO_CREACION
            lEntidad.FECHA_CREACION = FECHA_CREACION
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.LUGAR_EJECUCION = LUGAR_EJECUCION
            lEntidad.NOMBRE_ACCION_FORMATIVA = NOMBRE_ACCION_FORMATIVA
            Return Me.ActualizarGRUPO_SOLICITUD(lEntidad)
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
    ''' 	[GenApp]	05/10/2012	Created
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
    ''' 	[GenApp]	05/10/2012	Created
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
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SOLICITUD_CAPACITACION .
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSOLICITUD_CAPACITACION(ByVal ID_SOLICITUD As Decimal, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As ListaGRUPO_SOLICITUD
        Try
            Dim mListaGRUPO_SOLICITUD As New ListaGRUPO_SOLICITUD
            mListaGRUPO_SOLICITUD = mDb.ObtenerListaPorSOLICITUD_CAPACITACION(ID_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaGRUPO_SOLICITUD Is Nothing And recuperarForaneas Then
                For Each lEntidad As GRUPO_SOLICITUD In mListaGRUPO_SOLICITUD
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaGRUPO_SOLICITUD
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla MODALIDAD_DE_FORMACION .
    ''' </summary>
    ''' <param name="ID_MODALIDAD_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMODALIDAD_DE_FORMACION(ByVal ID_MODALIDAD_FORMACION As Decimal, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As ListaGRUPO_SOLICITUD
        Try
            Dim mListaGRUPO_SOLICITUD As New ListaGRUPO_SOLICITUD
            mListaGRUPO_SOLICITUD = mDb.ObtenerListaPorMODALIDAD_DE_FORMACION(ID_MODALIDAD_FORMACION, asColumnaOrden, asTipoOrden)
            If Not mListaGRUPO_SOLICITUD Is Nothing And recuperarForaneas Then
                For Each lEntidad As GRUPO_SOLICITUD In mListaGRUPO_SOLICITUD
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaGRUPO_SOLICITUD
        Catch ex As Exception
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As GRUPO_SOLICITUD)
        aEntidad.fkID_SOLICITUD = (New cSOLICITUD_CAPACITACION).ObtenerSOLICITUD_CAPACITACION(aEntidad.ID_SOLICITUD)
        aEntidad.fkID_MODALIDAD_FORMACION = (New cMODALIDAD_DE_FORMACION).ObtenerMODALIDAD_DE_FORMACION(aEntidad.ID_MODALIDAD_FORMACION)
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As GRUPO_SOLICITUD)
    End Sub

#End Region

End Class
