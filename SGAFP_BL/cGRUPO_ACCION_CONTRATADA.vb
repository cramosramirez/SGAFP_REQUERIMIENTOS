''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cGRUPO_ACCION_CONTRATADA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla GRUPO_ACCION_CONTRATADA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	12/04/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cGRUPO_ACCION_CONTRATADA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbGRUPO_ACCION_CONTRATADA()
    Private mEntidad as New GRUPO_ACCION_CONTRATADA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaGRUPO_ACCION_CONTRATADA
        Try
            Dim mListaGRUPO_ACCION_CONTRATADA As New ListaGRUPO_ACCION_CONTRATADA
            mListaGRUPO_ACCION_CONTRATADA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaGRUPO_ACCION_CONTRATADA Is Nothing And recuperarForaneas Then
                For Each lEntidad As GRUPO_ACCION_CONTRATADA in  mListaGRUPO_ACCION_CONTRATADA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaGRUPO_ACCION_CONTRATADA
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
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerGRUPO_ACCION_CONTRATADA(ByRef aEntidad As GRUPO_ACCION_CONTRATADA, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla GRUPO_ACCION_CONTRATADA.
    ''' </summary>
    ''' <param name="ID_GRUPO_ACCION"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerGRUPO_ACCION_CONTRATADA(ByVal ID_GRUPO_ACCION As Decimal, ByVal Optional recuperarForaneas As Boolean = False) As GRUPO_ACCION_CONTRATADA
        Try
            Dim lEntidad As New GRUPO_ACCION_CONTRATADA
            lEntidad.ID_GRUPO_ACCION = ID_GRUPO_ACCION
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
    ''' <param name="aACCION_CONTRATADA">Recuperar registro foraneo de la Entidad ACCION_CONTRATADA.</param>
    ''' <param name="aACCION_FORMATIVA">Recuperar registro foraneo de la Entidad ACCION_FORMATIVA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerGRUPO_ACCION_CONTRATADAConForaneas(ByVal aEntidad As GRUPO_ACCION_CONTRATADA, Optional ByVal aACCION_CONTRATADA As Boolean = False, Optional ByVal aACCION_FORMATIVA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aACCION_CONTRATADA, aACCION_FORMATIVA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla GRUPO_ACCION_CONTRATADA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_GRUPO_ACCION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarGRUPO_ACCION_CONTRATADA(ByVal ID_GRUPO_ACCION As Decimal) As Integer
        Try
            mEntidad.ID_GRUPO_ACCION = ID_GRUPO_ACCION
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla GRUPO_ACCION_CONTRATADA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarGRUPO_ACCION_CONTRATADA(ByVal aEntidad As GRUPO_ACCION_CONTRATADA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarGRUPO_ACCION_CONTRATADA(ByVal ID_GRUPO_ACCION As Decimal, ByVal ID_ACCION_CONTRATADA As Decimal, ByVal ID_GRUPO_AF As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal USUARIO_CREACION As String, ByVal FECHA_CREACION As DateTime, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal MONTO As Decimal, ByVal HABILITADO As Decimal) As Integer
        Try
            Dim lEntidad As New GRUPO_ACCION_CONTRATADA
            lEntidad.ID_GRUPO_ACCION = ID_GRUPO_ACCION
            lEntidad.ID_ACCION_CONTRATADA = ID_ACCION_CONTRATADA
            lEntidad.ID_GRUPO_AF = ID_GRUPO_AF
            lEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            lEntidad.USUARIO_CREACION = USUARIO_CREACION
            lEntidad.FECHA_CREACION = FECHA_CREACION
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.MONTO = MONTO
            lEntidad.HABILITADO = HABILITADO
            Return Me.ActualizarGRUPO_ACCION_CONTRATADA(lEntidad)
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
    ''' 	[GenApp]	12/04/2013	Created
    ''' 	[cramos]	10/07/2013	Modificado: Se cambia la invocación al método actualizar
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarGRUPO_ACCION_CONTRATADA(ByVal aEntidad As GRUPO_ACCION_CONTRATADA) As Integer
        Try
            Return Me.ActualizarGRUPO_ACCION_CONTRATADA(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarGRUPO_ACCION_CONTRATADA(ByVal ID_GRUPO_ACCION As Decimal, ByVal ID_ACCION_CONTRATADA As Decimal, ByVal ID_GRUPO_AF As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal USUARIO_CREACION As String, ByVal FECHA_CREACION As DateTime, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal MONTO As Decimal, ByVal HABILITADO As Decimal) As Integer
        Try
            Dim lEntidad As New GRUPO_ACCION_CONTRATADA
            lEntidad.ID_GRUPO_ACCION = ID_GRUPO_ACCION
            lEntidad.ID_ACCION_CONTRATADA = ID_ACCION_CONTRATADA
            lEntidad.ID_GRUPO_AF = ID_GRUPO_AF
            lEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            lEntidad.USUARIO_CREACION = USUARIO_CREACION
            lEntidad.FECHA_CREACION = FECHA_CREACION
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.MONTO = MONTO
            lEntidad.HABILITADO = HABILITADO
            Return Me.ActualizarGRUPO_ACCION_CONTRATADA(lEntidad)
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
    ''' 	[GenApp]	12/04/2013	Created
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
    ''' 	[GenApp]	12/04/2013	Created
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
    ''' la Tabla ACCION_CONTRATADA .
    ''' </summary>
    ''' <param name="ID_ACCION_CONTRATADA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorACCION_CONTRATADA(ByVal ID_ACCION_CONTRATADA As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaGRUPO_ACCION_CONTRATADA
        Try
            Dim mListaGRUPO_ACCION_CONTRATADA As New ListaGRUPO_ACCION_CONTRATADA
            mListaGRUPO_ACCION_CONTRATADA = mDb.ObtenerListaPorACCION_CONTRATADA(ID_ACCION_CONTRATADA, asColumnaOrden, asTipoOrden)
            If Not mListaGRUPO_ACCION_CONTRATADA Is Nothing And recuperarForaneas Then
                For Each lEntidad As GRUPO_ACCION_CONTRATADA in  mListaGRUPO_ACCION_CONTRATADA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaGRUPO_ACCION_CONTRATADA
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
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaGRUPO_ACCION_CONTRATADA
        Try
            Dim mListaGRUPO_ACCION_CONTRATADA As New ListaGRUPO_ACCION_CONTRATADA
            mListaGRUPO_ACCION_CONTRATADA = mDb.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA, asColumnaOrden, asTipoOrden)
            If Not mListaGRUPO_ACCION_CONTRATADA Is Nothing And recuperarForaneas Then
                For Each lEntidad As GRUPO_ACCION_CONTRATADA in  mListaGRUPO_ACCION_CONTRATADA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaGRUPO_ACCION_CONTRATADA
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
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As GRUPO_ACCION_CONTRATADA )
        aEntidad.fkID_ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(aEntidad.ID_ACCION_CONTRATADA)
        aEntidad.fkID_ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
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
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As GRUPO_ACCION_CONTRATADA )
    End Sub

#End Region

End Class
