''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cMUNICIPIO_LIQUIDACION
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla MUNICIPIO_LIQUIDACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/09/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cMUNICIPIO_LIQUIDACION
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbMUNICIPIO_LIQUIDACION()
    Private mEntidad as New MUNICIPIO_LIQUIDACION
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaMUNICIPIO_LIQUIDACION
        Try
            Dim mListaMUNICIPIO_LIQUIDACION As New ListaMUNICIPIO_LIQUIDACION
            mListaMUNICIPIO_LIQUIDACION = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaMUNICIPIO_LIQUIDACION Is Nothing And recuperarForaneas Then
                For Each lEntidad As MUNICIPIO_LIQUIDACION in  mListaMUNICIPIO_LIQUIDACION
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMUNICIPIO_LIQUIDACION
            If Not mListaMUNICIPIO_LIQUIDACION Is Nothing Then
                For Each lEntidad As MUNICIPIO_LIQUIDACION in  mListaMUNICIPIO_LIQUIDACION
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaMUNICIPIO_LIQUIDACION
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
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerMUNICIPIO_LIQUIDACION(ByRef aEntidad As MUNICIPIO_LIQUIDACION, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla MUNICIPIO_LIQUIDACION.
    ''' </summary>
    ''' <param name="ID_LIQUIDACION"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerMUNICIPIO_LIQUIDACION(ByVal ID_LIQUIDACION As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As MUNICIPIO_LIQUIDACION
        Try
            Dim lEntidad As New MUNICIPIO_LIQUIDACION
            lEntidad.ID_LIQUIDACION = ID_LIQUIDACION
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
    ''' <param name="aMUNICIPIO_CONVOCATORIA">Recuperar registro foraneo de la Entidad MUNICIPIO_CONVOCATORIA.</param>
    ''' <param name="aDEPARTAMENTO">Recuperar registro foraneo de la Entidad DEPARTAMENTO.</param>
    ''' <param name="aMUNICIPIO">Recuperar registro foraneo de la Entidad MUNICIPIO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerMUNICIPIO_LIQUIDACIONConForaneas(ByVal aEntidad As MUNICIPIO_LIQUIDACION, Optional ByVal aMUNICIPIO_CONVOCATORIA As Boolean = False, Optional ByVal aDEPARTAMENTO As Boolean = False, Optional ByVal aMUNICIPIO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aMUNICIPIO_CONVOCATORIA, aDEPARTAMENTO, aMUNICIPIO)
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
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarMUNICIPIO_LIQUIDACION(ByVal ID_LIQUIDACION As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal NO_LIQUIDACION As Decimal, ByVal FECHA_ELABORACION As DateTime, ByVal MONTO_LIQUIDADO As Decimal, ByVal ASESOR_MUNICIPAL As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal ID_FUENTE As Decimal) As Integer
        Try
            Dim lEntidad As New MUNICIPIO_LIQUIDACION
            lEntidad.ID_LIQUIDACION = ID_LIQUIDACION
            lEntidad.NO_CONVOCATORIA = NO_CONVOCATORIA
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.NO_LIQUIDACION = NO_LIQUIDACION
            lEntidad.FECHA_ELABORACION = FECHA_ELABORACION
            lEntidad.MONTO_LIQUIDADO = MONTO_LIQUIDADO
            lEntidad.ASESOR_MUNICIPAL = ASESOR_MUNICIPAL
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.ID_FUENTE = ID_FUENTE
            Return Me.ActualizarMUNICIPIO_LIQUIDACION(lEntidad)
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
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarMUNICIPIO_LIQUIDACION(ByVal aEntidad As MUNICIPIO_LIQUIDACION) As Integer
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
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarMUNICIPIO_LIQUIDACION(ByVal aEntidad As MUNICIPIO_LIQUIDACION, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarMUNICIPIO_LIQUIDACION(ByVal ID_LIQUIDACION As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal NO_LIQUIDACION As Decimal, ByVal FECHA_ELABORACION As DateTime, ByVal MONTO_LIQUIDADO As Decimal, ByVal ASESOR_MUNICIPAL As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal ID_FUENTE As Decimal) As Integer
        Try
            Dim lEntidad As New MUNICIPIO_LIQUIDACION
            lEntidad.ID_LIQUIDACION = ID_LIQUIDACION
            lEntidad.NO_CONVOCATORIA = NO_CONVOCATORIA
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.NO_LIQUIDACION = NO_LIQUIDACION
            lEntidad.FECHA_ELABORACION = FECHA_ELABORACION
            lEntidad.MONTO_LIQUIDADO = MONTO_LIQUIDADO
            lEntidad.ASESOR_MUNICIPAL = ASESOR_MUNICIPAL
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.ID_FUENTE = ID_FUENTE
            Return Me.ActualizarMUNICIPIO_LIQUIDACION(lEntidad)
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
    ''' 	[GenApp]	10/09/2011	Created
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
    ''' 	[GenApp]	10/09/2011	Created
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
    ''' la Tabla MUNICIPIO_CONVOCATORIA .
    ''' </summary>
    ''' <param name="NO_CONVOCATORIA"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMUNICIPIO_CONVOCATORIA(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaMUNICIPIO_LIQUIDACION
        Try
            Dim mListaMUNICIPIO_LIQUIDACION As New listaMUNICIPIO_LIQUIDACION
            mListaMUNICIPIO_LIQUIDACION = mDb.ObtenerListaPorMUNICIPIO_CONVOCATORIA(ID_FUENTE, NO_CONVOCATORIA, CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, asColumnaOrden, asTipoOrden)
            If Not mListaMUNICIPIO_LIQUIDACION Is Nothing And recuperarForaneas Then
                For Each lEntidad As MUNICIPIO_LIQUIDACION In mListaMUNICIPIO_LIQUIDACION
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMUNICIPIO_LIQUIDACION
            If Not mListaMUNICIPIO_LIQUIDACION Is Nothing Then
                For Each lEntidad As MUNICIPIO_LIQUIDACION In mListaMUNICIPIO_LIQUIDACION
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaMUNICIPIO_LIQUIDACION
        Catch ex As Exception
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
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaMUNICIPIO_LIQUIDACION
        Try
            Dim mListaMUNICIPIO_LIQUIDACION As New ListaMUNICIPIO_LIQUIDACION
            mListaMUNICIPIO_LIQUIDACION = mDb.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO, asColumnaOrden, asTipoOrden)
            If Not mListaMUNICIPIO_LIQUIDACION Is Nothing And recuperarForaneas Then
                For Each lEntidad As MUNICIPIO_LIQUIDACION in  mListaMUNICIPIO_LIQUIDACION
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMUNICIPIO_LIQUIDACION
            If Not mListaMUNICIPIO_LIQUIDACION Is Nothing Then
                For Each lEntidad As MUNICIPIO_LIQUIDACION in  mListaMUNICIPIO_LIQUIDACION
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaMUNICIPIO_LIQUIDACION
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
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaMUNICIPIO_LIQUIDACION
        Try
            Dim mListaMUNICIPIO_LIQUIDACION As New ListaMUNICIPIO_LIQUIDACION
            mListaMUNICIPIO_LIQUIDACION = mDb.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, asColumnaOrden, asTipoOrden)
            If Not mListaMUNICIPIO_LIQUIDACION Is Nothing And recuperarForaneas Then
                For Each lEntidad As MUNICIPIO_LIQUIDACION in  mListaMUNICIPIO_LIQUIDACION
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaMUNICIPIO_LIQUIDACION
            If Not mListaMUNICIPIO_LIQUIDACION Is Nothing Then
                For Each lEntidad As MUNICIPIO_LIQUIDACION in  mListaMUNICIPIO_LIQUIDACION
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaMUNICIPIO_LIQUIDACION
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
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As MUNICIPIO_LIQUIDACION )
        aEntidad.fkNO_CONVOCATORIA = (New cMUNICIPIO_CONVOCATORIA).ObtenerMUNICIPIO_CONVOCATORIA(aEntidad.ID_FUENTE, aEntidad.NO_CONVOCATORIA, aEntidad.CODIGO_DEPARTAMENTO, aEntidad.CODIGO_MUNICIPIO)
        aEntidad.fkCODIGO_DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(aEntidad.CODIGO_DEPARTAMENTO)
        aEntidad.fkCODIGO_MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(aEntidad.CODIGO_DEPARTAMENTO, aEntidad.CODIGO_MUNICIPIO)
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
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As MUNICIPIO_LIQUIDACION )
    End Sub

#End Region

End Class
