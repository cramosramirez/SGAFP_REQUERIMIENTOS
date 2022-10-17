''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cACCION_PROGRA_RETRO
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla ACCION_PROGRA_RETRO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/02/2017	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cACCION_PROGRA_RETRO
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbACCION_PROGRA_RETRO()
    Private mEntidad as New ACCION_PROGRA_RETRO
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaACCION_PROGRA_RETRO
        Try
            Dim mListaACCION_PROGRA_RETRO As New ListaACCION_PROGRA_RETRO
            mListaACCION_PROGRA_RETRO = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaACCION_PROGRA_RETRO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ACCION_PROGRA_RETRO in  mListaACCION_PROGRA_RETRO
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaACCION_PROGRA_RETRO
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
    ''' 	[GenApp]	10/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerACCION_PROGRA_RETRO(ByRef aEntidad As ACCION_PROGRA_RETRO, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla ACCION_PROGRA_RETRO.
    ''' </summary>
    ''' <param name="ID_ACCION_PROGRA_RETRO"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerACCION_PROGRA_RETRO(ByVal ID_ACCION_PROGRA_RETRO As Decimal, ByVal Optional recuperarForaneas As Boolean = False) As ACCION_PROGRA_RETRO
        Try
            Dim lEntidad As New ACCION_PROGRA_RETRO
            lEntidad.ID_ACCION_PROGRA_RETRO = ID_ACCION_PROGRA_RETRO
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
    ''' <param name="aPROVEEDOR_AF">Recuperar registro foraneo de la Entidad PROVEEDOR_AF.</param>
    ''' <param name="aEJERCICIO">Recuperar registro foraneo de la Entidad EJERCICIO.</param>
    ''' <param name="aACCION_FORMATIVA">Recuperar registro foraneo de la Entidad ACCION_FORMATIVA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerACCION_PROGRA_RETROConForaneas(ByVal aEntidad As ACCION_PROGRA_RETRO, Optional ByVal aPROVEEDOR_AF As Boolean = False, Optional ByVal aEJERCICIO As Boolean = False, Optional ByVal aACCION_FORMATIVA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aPROVEEDOR_AF, aEJERCICIO, aACCION_FORMATIVA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ACCION_PROGRA_RETRO que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ACCION_PROGRA_RETRO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarACCION_PROGRA_RETRO(ByVal ID_ACCION_PROGRA_RETRO As Decimal) As Integer
        Try
            mEntidad.ID_ACCION_PROGRA_RETRO = ID_ACCION_PROGRA_RETRO
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ACCION_PROGRA_RETRO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarACCION_PROGRA_RETRO(ByVal aEntidad As ACCION_PROGRA_RETRO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	10/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarACCION_PROGRA_RETRO(ByVal ID_ACCION_PROGRA_RETRO As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_EJERCICIO As String, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal NOMBRE_ACCION_FORMATIVA As String, ByVal CODIGO_GRUPO As String, ByVal FECHA_EXPIRA As DateTime, ByVal MOTIVO As String, ByVal ACTIVO As Decimal, ByVal USUARIO_CREACION As String, ByVal FECHA_CREACION As DateTime, ByVal USUARIO_PROGRAMO As String, ByVal FECHA_PROGRAMO As DateTime, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal CODIGO_ESTADO_AF_PROP As String) As Integer
        Try
            Dim lEntidad As New ACCION_PROGRA_RETRO
            lEntidad.ID_ACCION_PROGRA_RETRO = ID_ACCION_PROGRA_RETRO
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.ID_EJERCICIO = ID_EJERCICIO
            lEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            lEntidad.NOMBRE_ACCION_FORMATIVA = NOMBRE_ACCION_FORMATIVA
            lEntidad.CODIGO_GRUPO = CODIGO_GRUPO
            lEntidad.FECHA_EXPIRA = FECHA_EXPIRA
            lEntidad.MOTIVO = MOTIVO
            lEntidad.ACTIVO = ACTIVO
            lEntidad.USUARIO_CREACION = USUARIO_CREACION
            lEntidad.FECHA_CREACION = FECHA_CREACION
            lEntidad.USUARIO_PROGRAMO = USUARIO_PROGRAMO
            lEntidad.FECHA_PROGRAMO = FECHA_PROGRAMO
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.CODIGO_ESTADO_AF_PROP = CODIGO_ESTADO_AF_PROP
            Return Me.ActualizarACCION_PROGRA_RETRO(lEntidad)
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
    ''' 	[GenApp]	10/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_PROGRA_RETRO(ByVal ID_ACCION_PROGRA_RETRO As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_EJERCICIO As String, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal NOMBRE_ACCION_FORMATIVA As String, ByVal CODIGO_GRUPO As String, ByVal FECHA_EXPIRA As DateTime, ByVal MOTIVO As String, ByVal ACTIVO As Decimal, ByVal USUARIO_CREACION As String, ByVal FECHA_CREACION As DateTime, ByVal USUARIO_PROGRAMO As String, ByVal FECHA_PROGRAMO As DateTime, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal CODIGO_ESTADO_AF_PROP As String) As Integer
        Try
            Dim lEntidad As New ACCION_PROGRA_RETRO
            lEntidad.ID_ACCION_PROGRA_RETRO = ID_ACCION_PROGRA_RETRO
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.ID_EJERCICIO = ID_EJERCICIO
            lEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            lEntidad.NOMBRE_ACCION_FORMATIVA = NOMBRE_ACCION_FORMATIVA
            lEntidad.CODIGO_GRUPO = CODIGO_GRUPO
            lEntidad.FECHA_EXPIRA = FECHA_EXPIRA
            lEntidad.MOTIVO = MOTIVO
            lEntidad.ACTIVO = ACTIVO
            lEntidad.USUARIO_CREACION = USUARIO_CREACION
            lEntidad.FECHA_CREACION = FECHA_CREACION
            lEntidad.USUARIO_PROGRAMO = USUARIO_PROGRAMO
            lEntidad.FECHA_PROGRAMO = FECHA_PROGRAMO
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.CODIGO_ESTADO_AF_PROP = CODIGO_ESTADO_AF_PROP
            Return Me.ActualizarACCION_PROGRA_RETRO(lEntidad)
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
    ''' 	[GenApp]	10/02/2017	Created
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
    ''' 	[GenApp]	10/02/2017	Created
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
    ''' la Tabla PROVEEDOR_AF .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaACCION_PROGRA_RETRO
        Try
            Dim mListaACCION_PROGRA_RETRO As New ListaACCION_PROGRA_RETRO
            mListaACCION_PROGRA_RETRO = mDb.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF, asColumnaOrden, asTipoOrden)
            If Not mListaACCION_PROGRA_RETRO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ACCION_PROGRA_RETRO in  mListaACCION_PROGRA_RETRO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaACCION_PROGRA_RETRO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla EJERCICIO .
    ''' </summary>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorEJERCICIO(ByVal ID_EJERCICIO As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaACCION_PROGRA_RETRO
        Try
            Dim mListaACCION_PROGRA_RETRO As New ListaACCION_PROGRA_RETRO
            mListaACCION_PROGRA_RETRO = mDb.ObtenerListaPorEJERCICIO(ID_EJERCICIO, asColumnaOrden, asTipoOrden)
            If Not mListaACCION_PROGRA_RETRO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ACCION_PROGRA_RETRO in  mListaACCION_PROGRA_RETRO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaACCION_PROGRA_RETRO
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
    ''' 	[GenApp]	10/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaACCION_PROGRA_RETRO
        Try
            Dim mListaACCION_PROGRA_RETRO As New ListaACCION_PROGRA_RETRO
            mListaACCION_PROGRA_RETRO = mDb.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA, asColumnaOrden, asTipoOrden)
            If Not mListaACCION_PROGRA_RETRO Is Nothing And recuperarForaneas Then
                For Each lEntidad As ACCION_PROGRA_RETRO in  mListaACCION_PROGRA_RETRO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaACCION_PROGRA_RETRO
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
    ''' 	[GenApp]	10/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As ACCION_PROGRA_RETRO )
        aEntidad.fkID_PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF)
        aEntidad.fkID_EJERCICIO = (New cEJERCICIO).ObtenerEJERCICIO(aEntidad.ID_EJERCICIO)
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
    ''' 	[GenApp]	10/02/2017	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As ACCION_PROGRA_RETRO )
    End Sub

#End Region

End Class
