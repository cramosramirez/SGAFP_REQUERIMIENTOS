''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cCONTROL_DOCUMENTOS
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla CONTROL_DOCUMENTOS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cCONTROL_DOCUMENTOS
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbCONTROL_DOCUMENTOS()
    Private mEntidad as New CONTROL_DOCUMENTOS
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTROL_DOCUMENTOS
        Try
            Dim mListaCONTROL_DOCUMENTOS As New ListaCONTROL_DOCUMENTOS
            mListaCONTROL_DOCUMENTOS = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaCONTROL_DOCUMENTOS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTROL_DOCUMENTOS in  mListaCONTROL_DOCUMENTOS
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTROL_DOCUMENTOS
            If Not mListaCONTROL_DOCUMENTOS Is Nothing Then
                For Each lEntidad As CONTROL_DOCUMENTOS in  mListaCONTROL_DOCUMENTOS
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTROL_DOCUMENTOS
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
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerCONTROL_DOCUMENTOS(ByRef aEntidad As CONTROL_DOCUMENTOS, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla CONTROL_DOCUMENTOS.
    ''' </summary>
    ''' <param name="NUMERO_DOCUMENTO"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerCONTROL_DOCUMENTOS(ByVal NUMERO_DOCUMENTO As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As CONTROL_DOCUMENTOS
        Try
            Dim lEntidad As New CONTROL_DOCUMENTOS
            lEntidad.NUMERO_DOCUMENTO = NUMERO_DOCUMENTO
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
    ''' Función que Elimina un Registro de la Tabla CONTROL_DOCUMENTOS que se le envía como parámetro.
    ''' </summary>
    ''' <param name="NUMERO_DOCUMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTROL_DOCUMENTOS(ByVal NUMERO_DOCUMENTO As Decimal) As Integer
        Try
            mEntidad.NUMERO_DOCUMENTO = NUMERO_DOCUMENTO
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTROL_DOCUMENTOS que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTROL_DOCUMENTOS(ByVal aEntidad As CONTROL_DOCUMENTOS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarCONTROL_DOCUMENTOS(ByVal NUMERO_DOCUMENTO As Decimal, ByVal NUMERO_PATRONAL As String, ByVal NUMERO_FOLIO As String, ByVal ID_TIPO_SOLICITUD As Decimal, ByVal CODIGO_ETAPA As String, ByVal CODIGO_PROCESO As String, ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal NIT As String, ByVal PRESENTADO_POR As String, ByVal FECHA_RECEPCION As DateTime, ByVal RESPONSABLE_ACTUAL As String, ByVal RESPONSABLE_ANTERIOR As String, ByVal PRIORIDAD As String, ByVal NO_DOCUMENTO_ORIGEN As Decimal, ByVal NO_DOCUMENTO_PADRE As Decimal, ByVal FECHA_REQUERIDA_FIN As DateTime, ByVal NOTAS As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime) As Integer
        Try
            Dim lEntidad As New CONTROL_DOCUMENTOS
            lEntidad.NUMERO_DOCUMENTO = NUMERO_DOCUMENTO
            lEntidad.NUMERO_PATRONAL = NUMERO_PATRONAL
            lEntidad.NUMERO_FOLIO = NUMERO_FOLIO
            lEntidad.ID_TIPO_SOLICITUD = ID_TIPO_SOLICITUD
            lEntidad.CODIGO_ETAPA = CODIGO_ETAPA
            lEntidad.CODIGO_PROCESO = CODIGO_PROCESO
            lEntidad.ID_ESTADO_SOLICITUD = ID_ESTADO_SOLICITUD
            lEntidad.NIT = NIT
            lEntidad.PRESENTADO_POR = PRESENTADO_POR
            lEntidad.FECHA_RECEPCION = FECHA_RECEPCION
            lEntidad.RESPONSABLE_ACTUAL = RESPONSABLE_ACTUAL
            lEntidad.RESPONSABLE_ANTERIOR = RESPONSABLE_ANTERIOR
            lEntidad.PRIORIDAD = PRIORIDAD
            lEntidad.NO_DOCUMENTO_ORIGEN = NO_DOCUMENTO_ORIGEN
            lEntidad.NO_DOCUMENTO_PADRE = NO_DOCUMENTO_PADRE
            lEntidad.FECHA_REQUERIDA_FIN = FECHA_REQUERIDA_FIN
            lEntidad.NOTAS = NOTAS
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            Return Me.ActualizarCONTROL_DOCUMENTOS(lEntidad)
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
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTROL_DOCUMENTOS(ByVal aEntidad As CONTROL_DOCUMENTOS) As Integer
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
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTROL_DOCUMENTOS(ByVal aEntidad As CONTROL_DOCUMENTOS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTROL_DOCUMENTOS(ByVal NUMERO_DOCUMENTO As Decimal, ByVal NUMERO_PATRONAL As String, ByVal NUMERO_FOLIO As String, ByVal ID_TIPO_SOLICITUD As Decimal, ByVal CODIGO_ETAPA As String, ByVal CODIGO_PROCESO As String, ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal NIT As String, ByVal PRESENTADO_POR As String, ByVal FECHA_RECEPCION As DateTime, ByVal RESPONSABLE_ACTUAL As String, ByVal RESPONSABLE_ANTERIOR As String, ByVal PRIORIDAD As String, ByVal NO_DOCUMENTO_ORIGEN As Decimal, ByVal NO_DOCUMENTO_PADRE As Decimal, ByVal FECHA_REQUERIDA_FIN As DateTime, ByVal NOTAS As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime) As Integer
        Try
            Dim lEntidad As New CONTROL_DOCUMENTOS
            lEntidad.NUMERO_DOCUMENTO = NUMERO_DOCUMENTO
            lEntidad.NUMERO_PATRONAL = NUMERO_PATRONAL
            lEntidad.NUMERO_FOLIO = NUMERO_FOLIO
            lEntidad.ID_TIPO_SOLICITUD = ID_TIPO_SOLICITUD
            lEntidad.CODIGO_ETAPA = CODIGO_ETAPA
            lEntidad.CODIGO_PROCESO = CODIGO_PROCESO
            lEntidad.ID_ESTADO_SOLICITUD = ID_ESTADO_SOLICITUD
            lEntidad.NIT = NIT
            lEntidad.PRESENTADO_POR = PRESENTADO_POR
            lEntidad.FECHA_RECEPCION = FECHA_RECEPCION
            lEntidad.RESPONSABLE_ACTUAL = RESPONSABLE_ACTUAL
            lEntidad.RESPONSABLE_ANTERIOR = RESPONSABLE_ANTERIOR
            lEntidad.PRIORIDAD = PRIORIDAD
            lEntidad.NO_DOCUMENTO_ORIGEN = NO_DOCUMENTO_ORIGEN
            lEntidad.NO_DOCUMENTO_PADRE = NO_DOCUMENTO_PADRE
            lEntidad.FECHA_REQUERIDA_FIN = FECHA_REQUERIDA_FIN
            lEntidad.NOTAS = NOTAS
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            Return Me.ActualizarCONTROL_DOCUMENTOS(lEntidad)
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
    ''' 	[GenApp]	03/02/2010	Created
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
    ''' 	[GenApp]	03/02/2010	Created
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
    ''' la Tabla TIPO_SOLICITUD .
    ''' </summary>
    ''' <param name="ID_TIPO_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_SOLICITUD(ByVal ID_TIPO_SOLICITUD As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTROL_DOCUMENTOS
        Try
            Dim mListaCONTROL_DOCUMENTOS As New ListaCONTROL_DOCUMENTOS
            mListaCONTROL_DOCUMENTOS = mDb.ObtenerListaPorTIPO_SOLICITUD(ID_TIPO_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaCONTROL_DOCUMENTOS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTROL_DOCUMENTOS in  mListaCONTROL_DOCUMENTOS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTROL_DOCUMENTOS
            If Not mListaCONTROL_DOCUMENTOS Is Nothing Then
                For Each lEntidad As CONTROL_DOCUMENTOS in  mListaCONTROL_DOCUMENTOS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTROL_DOCUMENTOS
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ETAPA .
    ''' </summary>
    ''' <param name="CODIGO_ETAPA"></param>
    ''' <param name="CODIGO_PROCESO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorETAPA(ByVal CODIGO_ETAPA As String, ByVal CODIGO_PROCESO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTROL_DOCUMENTOS
        Try
            Dim mListaCONTROL_DOCUMENTOS As New ListaCONTROL_DOCUMENTOS
            mListaCONTROL_DOCUMENTOS = mDb.ObtenerListaPorETAPA(CODIGO_ETAPA, CODIGO_PROCESO, asColumnaOrden, asTipoOrden)
            If Not mListaCONTROL_DOCUMENTOS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTROL_DOCUMENTOS in  mListaCONTROL_DOCUMENTOS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTROL_DOCUMENTOS
            If Not mListaCONTROL_DOCUMENTOS Is Nothing Then
                For Each lEntidad As CONTROL_DOCUMENTOS in  mListaCONTROL_DOCUMENTOS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTROL_DOCUMENTOS
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PROCESO .
    ''' </summary>
    ''' <param name="CODIGO_PROCESO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROCESO(ByVal CODIGO_PROCESO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTROL_DOCUMENTOS
        Try
            Dim mListaCONTROL_DOCUMENTOS As New ListaCONTROL_DOCUMENTOS
            mListaCONTROL_DOCUMENTOS = mDb.ObtenerListaPorPROCESO(CODIGO_PROCESO, asColumnaOrden, asTipoOrden)
            If Not mListaCONTROL_DOCUMENTOS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTROL_DOCUMENTOS in  mListaCONTROL_DOCUMENTOS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTROL_DOCUMENTOS
            If Not mListaCONTROL_DOCUMENTOS Is Nothing Then
                For Each lEntidad As CONTROL_DOCUMENTOS in  mListaCONTROL_DOCUMENTOS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTROL_DOCUMENTOS
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
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorESTADO_SOLICITUD(ByVal ID_ESTADO_SOLICITUD As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTROL_DOCUMENTOS
        Try
            Dim mListaCONTROL_DOCUMENTOS As New ListaCONTROL_DOCUMENTOS
            mListaCONTROL_DOCUMENTOS = mDb.ObtenerListaPorESTADO_SOLICITUD(ID_ESTADO_SOLICITUD, asColumnaOrden, asTipoOrden)
            If Not mListaCONTROL_DOCUMENTOS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTROL_DOCUMENTOS in  mListaCONTROL_DOCUMENTOS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTROL_DOCUMENTOS
            If Not mListaCONTROL_DOCUMENTOS Is Nothing Then
                For Each lEntidad As CONTROL_DOCUMENTOS in  mListaCONTROL_DOCUMENTOS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTROL_DOCUMENTOS
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
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As CONTROL_DOCUMENTOS )
        aEntidad.fkID_TIPO_SOLICITUD = (New cTIPO_SOLICITUD).ObtenerTIPO_SOLICITUD(aEntidad.ID_TIPO_SOLICITUD)
        aEntidad.fkCODIGO_ETAPA = (New cETAPA).ObtenerETAPA(aEntidad.CODIGO_ETAPA, aEntidad.CODIGO_PROCESO)
        aEntidad.fkCODIGO_PROCESO = (New cPROCESO).ObtenerPROCESO(aEntidad.CODIGO_PROCESO)
        aEntidad.fkID_ESTADO_SOLICITUD = (New cESTADO_SOLICITUD).ObtenerESTADO_SOLICITUD(aEntidad.ID_ESTADO_SOLICITUD)
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
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As CONTROL_DOCUMENTOS )
    End Sub

#End Region

End Class
