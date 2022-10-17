''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cOFERTA_FORMATIVA_SITIO
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla OFERTA_FORMATIVA_SITIO
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	25/09/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cOFERTA_FORMATIVA_SITIO
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbOFERTA_FORMATIVA_SITIO()
    Private mEntidad as New OFERTA_FORMATIVA_SITIO
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaOFERTA_FORMATIVA_SITIO
        Try
            Dim mListaOFERTA_FORMATIVA_SITIO As New ListaOFERTA_FORMATIVA_SITIO
            mListaOFERTA_FORMATIVA_SITIO = mDb.ObtenerListaPorID(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_EJERCICIO, asColumnaOrden, asTipoOrden)
            If Not mListaOFERTA_FORMATIVA_SITIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As OFERTA_FORMATIVA_SITIO in  mListaOFERTA_FORMATIVA_SITIO
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaOFERTA_FORMATIVA_SITIO
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
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerOFERTA_FORMATIVA_SITIO(ByRef aEntidad As OFERTA_FORMATIVA_SITIO, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla OFERTA_FORMATIVA_SITIO.
    ''' </summary>
    ''' <param name="ID_OFERTA_FORMATIVA"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerOFERTA_FORMATIVA_SITIO(ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String, ByVal Optional recuperarForaneas As Boolean = False) As OFERTA_FORMATIVA_SITIO
        Try
            Dim lEntidad As New OFERTA_FORMATIVA_SITIO
            lEntidad.ID_OFERTA_FORMATIVA = ID_OFERTA_FORMATIVA
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            lEntidad.ID_EJERCICIO = ID_EJERCICIO
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
    ''' <param name="aOFERTA_FORMATIVA">Recuperar registro foraneo de la Entidad OFERTA_FORMATIVA.</param>
    ''' <param name="aPROVEEDOR_AF">Recuperar registro foraneo de la Entidad PROVEEDOR_AF.</param>
    ''' <param name="aSITIO_CAPACITACION">Recuperar registro foraneo de la Entidad SITIO_CAPACITACION.</param>
    ''' <param name="aSITIO_CAPACITACION_EJERCICIO">Recuperar registro foraneo de la Entidad SITIO_CAPACITACION_EJERCICIO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerOFERTA_FORMATIVA_SITIOConForaneas(ByVal aEntidad As OFERTA_FORMATIVA_SITIO, Optional ByVal aOFERTA_FORMATIVA As Boolean = False, Optional ByVal aPROVEEDOR_AF As Boolean = False, Optional ByVal aSITIO_CAPACITACION As Boolean = False, Optional ByVal aSITIO_CAPACITACION_EJERCICIO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aOFERTA_FORMATIVA, aPROVEEDOR_AF, aSITIO_CAPACITACION, aSITIO_CAPACITACION_EJERCICIO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla OFERTA_FORMATIVA_SITIO que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_OFERTA_FORMATIVA"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarOFERTA_FORMATIVA_SITIO(ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String) As Integer
        Try
            mEntidad.ID_OFERTA_FORMATIVA = ID_OFERTA_FORMATIVA
            mEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            mEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            mEntidad.ID_EJERCICIO = ID_EJERCICIO
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla OFERTA_FORMATIVA_SITIO que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarOFERTA_FORMATIVA_SITIO(ByVal aEntidad As OFERTA_FORMATIVA_SITIO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarOFERTA_FORMATIVA_SITIO(ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String, ByVal DURACION_HORAS As Decimal, ByVal COSTO_X_PARTICIPANTE As Decimal, ByVal USER_ID As String, ByVal LASTUPDATE As DateTime, ByVal PARTICIPACION_ADJUDICADA As Decimal, ByVal MONTO_ADJUDICADO As Decimal) As Integer
        Try
            Dim lEntidad As New OFERTA_FORMATIVA_SITIO
            lEntidad.ID_OFERTA_FORMATIVA = ID_OFERTA_FORMATIVA
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            lEntidad.ID_EJERCICIO = ID_EJERCICIO
            lEntidad.DURACION_HORAS = DURACION_HORAS
            lEntidad.COSTO_X_PARTICIPANTE = COSTO_X_PARTICIPANTE
            lEntidad.USER_ID = USER_ID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.PARTICIPACION_ADJUDICADA = PARTICIPACION_ADJUDICADA
            lEntidad.MONTO_ADJUDICADO = MONTO_ADJUDICADO
            Return Me.AgregarOFERTA_FORMATIVA_SITIO(lEntidad)
        Catch ex As Exception
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
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarOFERTA_FORMATIVA_SITIO(ByVal aEntidad As OFERTA_FORMATIVA_SITIO) As Integer
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
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarOFERTA_FORMATIVA_SITIO(ByVal aEntidad As OFERTA_FORMATIVA_SITIO) As Integer
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
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarOFERTA_FORMATIVA_SITIO(ByVal aEntidad As OFERTA_FORMATIVA_SITIO, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarOFERTA_FORMATIVA_SITIO(ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String, ByVal DURACION_HORAS As Decimal, ByVal COSTO_X_PARTICIPANTE As Decimal, ByVal USER_ID As String, ByVal LASTUPDATE As DateTime, ByVal PARTICIPACION_ADJUDICADA As Decimal, ByVal MONTO_ADJUDICADO As Decimal) As Integer
        Try
            Dim lEntidad As New OFERTA_FORMATIVA_SITIO
            lEntidad.ID_OFERTA_FORMATIVA = ID_OFERTA_FORMATIVA
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            lEntidad.ID_EJERCICIO = ID_EJERCICIO
            lEntidad.DURACION_HORAS = DURACION_HORAS
            lEntidad.COSTO_X_PARTICIPANTE = COSTO_X_PARTICIPANTE
            lEntidad.USER_ID = USER_ID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.PARTICIPACION_ADJUDICADA = PARTICIPACION_ADJUDICADA
            lEntidad.MONTO_ADJUDICADO = MONTO_ADJUDICADO
            Return Me.ActualizarOFERTA_FORMATIVA_SITIO(lEntidad)
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
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorId(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorID(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_EJERCICIO, asColumnaOrden, asTipoOrden)
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
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, False)> _
    Public Function ObtenerDataSetPorId(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String, ByRef ds As DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer
        Try
            Return mDb.ObtenerDataSetPorID(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, ID_EJERCICIO, ds, asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla OFERTA_FORMATIVA .
    ''' </summary>
    ''' <param name="ID_OFERTA_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorOFERTA_FORMATIVA(ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaOFERTA_FORMATIVA_SITIO
        Try
            Dim mListaOFERTA_FORMATIVA_SITIO As New ListaOFERTA_FORMATIVA_SITIO
            mListaOFERTA_FORMATIVA_SITIO = mDb.ObtenerListaPorOFERTA_FORMATIVA(ID_OFERTA_FORMATIVA, asColumnaOrden, asTipoOrden)
            If Not mListaOFERTA_FORMATIVA_SITIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As OFERTA_FORMATIVA_SITIO in  mListaOFERTA_FORMATIVA_SITIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaOFERTA_FORMATIVA_SITIO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
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
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaOFERTA_FORMATIVA_SITIO
        Try
            Dim mListaOFERTA_FORMATIVA_SITIO As New ListaOFERTA_FORMATIVA_SITIO
            mListaOFERTA_FORMATIVA_SITIO = mDb.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF, asColumnaOrden, asTipoOrden)
            If Not mListaOFERTA_FORMATIVA_SITIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As OFERTA_FORMATIVA_SITIO in  mListaOFERTA_FORMATIVA_SITIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaOFERTA_FORMATIVA_SITIO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SITIO_CAPACITACION .
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaOFERTA_FORMATIVA_SITIO
        Try
            Dim mListaOFERTA_FORMATIVA_SITIO As New ListaOFERTA_FORMATIVA_SITIO
            mListaOFERTA_FORMATIVA_SITIO = mDb.ObtenerListaPorSITIO_CAPACITACION(ID_SITIO_CAPACITACION, asColumnaOrden, asTipoOrden)
            If Not mListaOFERTA_FORMATIVA_SITIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As OFERTA_FORMATIVA_SITIO in  mListaOFERTA_FORMATIVA_SITIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaOFERTA_FORMATIVA_SITIO
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SITIO_CAPACITACION_EJERCICIO .
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSITIO_CAPACITACION_EJERCICIO(ByVal ID_SITIO_CAPACITACION As Decimal, ByVal ID_EJERCICIO As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaOFERTA_FORMATIVA_SITIO
        Try
            Dim mListaOFERTA_FORMATIVA_SITIO As New ListaOFERTA_FORMATIVA_SITIO
            mListaOFERTA_FORMATIVA_SITIO = mDb.ObtenerListaPorSITIO_CAPACITACION_EJERCICIO(ID_SITIO_CAPACITACION, ID_EJERCICIO, asColumnaOrden, asTipoOrden)
            If Not mListaOFERTA_FORMATIVA_SITIO Is Nothing And recuperarForaneas Then
                For Each lEntidad As OFERTA_FORMATIVA_SITIO in  mListaOFERTA_FORMATIVA_SITIO
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaOFERTA_FORMATIVA_SITIO
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
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As OFERTA_FORMATIVA_SITIO )
        aEntidad.fkID_PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF)
        aEntidad.fkID_SITIO_CAPACITACION = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(aEntidad.ID_SITIO_CAPACITACION)
        aEntidad.fkID_EJERCICIO = (New cSITIO_CAPACITACION_EJERCICIO).ObtenerSITIO_CAPACITACION_EJERCICIO(aEntidad.ID_SITIO_CAPACITACION, aEntidad.ID_EJERCICIO)
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
    ''' 	[GenApp]	25/09/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As OFERTA_FORMATIVA_SITIO )
    End Sub

#End Region

End Class
