''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cDESEMBOLSO_MUNI_LIQUI_DET
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla DESEMBOLSO_MUNI_LIQUI_DET
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	26/04/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cDESEMBOLSO_MUNI_LIQUI_DET
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbDESEMBOLSO_MUNI_LIQUI_DET()
    Private mEntidad as New DESEMBOLSO_MUNI_LIQUI_DET
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDESEMBOLSO_MUNI_LIQUI_DET
        Try
            Dim mListaDESEMBOLSO_MUNI_LIQUI_DET As New ListaDESEMBOLSO_MUNI_LIQUI_DET
            mListaDESEMBOLSO_MUNI_LIQUI_DET = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaDESEMBOLSO_MUNI_LIQUI_DET Is Nothing And recuperarForaneas Then
                For Each lEntidad As DESEMBOLSO_MUNI_LIQUI_DET in  mListaDESEMBOLSO_MUNI_LIQUI_DET
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaDESEMBOLSO_MUNI_LIQUI_DET
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
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDESEMBOLSO_MUNI_LIQUI_DET(ByRef aEntidad As DESEMBOLSO_MUNI_LIQUI_DET, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla DESEMBOLSO_MUNI_LIQUI_DET.
    ''' </summary>
    ''' <param name="ID_DESEMBOLSO_MUNI"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerDESEMBOLSO_MUNI_LIQUI_DET(ByVal ID_DESEMBOLSO_MUNI As Decimal, ByVal Optional recuperarForaneas As Boolean = False) As DESEMBOLSO_MUNI_LIQUI_DET
        Try
            Dim lEntidad As New DESEMBOLSO_MUNI_LIQUI_DET
            lEntidad.ID_DESEMBOLSO_MUNI = ID_DESEMBOLSO_MUNI
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
    ''' <param name="aDESEMBOLSO">Recuperar registro foraneo de la Entidad DESEMBOLSO.</param>
    ''' <param name="aMUNICIPIO_LIQUIDACION_DET">Recuperar registro foraneo de la Entidad MUNICIPIO_LIQUIDACION_DET.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDESEMBOLSO_MUNI_LIQUI_DETConForaneas(ByVal aEntidad As DESEMBOLSO_MUNI_LIQUI_DET, Optional ByVal aDESEMBOLSO As Boolean = False, Optional ByVal aMUNICIPIO_LIQUIDACION_DET As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aDESEMBOLSO, aMUNICIPIO_LIQUIDACION_DET)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla DESEMBOLSO_MUNI_LIQUI_DET que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_DESEMBOLSO_MUNI"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarDESEMBOLSO_MUNI_LIQUI_DET(ByVal ID_DESEMBOLSO_MUNI As Decimal) As Integer
        Try
            mEntidad.ID_DESEMBOLSO_MUNI = ID_DESEMBOLSO_MUNI
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla DESEMBOLSO_MUNI_LIQUI_DET que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarDESEMBOLSO_MUNI_LIQUI_DET(ByVal aEntidad As DESEMBOLSO_MUNI_LIQUI_DET, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarDESEMBOLSO_MUNI_LIQUI_DET(ByVal ID_DESEMBOLSO_MUNI As Decimal, ByVal ID_DESEMBOLSO As Decimal, ByVal ID_LIQUIDACION_DET As Decimal, ByVal MONTO_DESEMBOLSO As Decimal, ByVal USERID As String, ByVal LASTUPDATE As DateTime) As Integer
        Try
            Dim lEntidad As New DESEMBOLSO_MUNI_LIQUI_DET
            lEntidad.ID_DESEMBOLSO_MUNI = ID_DESEMBOLSO_MUNI
            lEntidad.ID_DESEMBOLSO = ID_DESEMBOLSO
            lEntidad.ID_LIQUIDACION_DET = ID_LIQUIDACION_DET
            lEntidad.MONTO_DESEMBOLSO = MONTO_DESEMBOLSO
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            Return Me.ActualizarDESEMBOLSO_MUNI_LIQUI_DET(lEntidad)
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
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarDESEMBOLSO_MUNI_LIQUI_DET(ByVal aEntidad As DESEMBOLSO_MUNI_LIQUI_DET) As Integer
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
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarDESEMBOLSO_MUNI_LIQUI_DET(ByVal aEntidad As DESEMBOLSO_MUNI_LIQUI_DET, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarDESEMBOLSO_MUNI_LIQUI_DET(ByVal ID_DESEMBOLSO_MUNI As Decimal, ByVal ID_DESEMBOLSO As Decimal, ByVal ID_LIQUIDACION_DET As Decimal, ByVal MONTO_DESEMBOLSO As Decimal, ByVal USERID As String, ByVal LASTUPDATE As DateTime) As Integer
        Try
            Dim lEntidad As New DESEMBOLSO_MUNI_LIQUI_DET
            lEntidad.ID_DESEMBOLSO_MUNI = ID_DESEMBOLSO_MUNI
            lEntidad.ID_DESEMBOLSO = ID_DESEMBOLSO
            lEntidad.ID_LIQUIDACION_DET = ID_LIQUIDACION_DET
            lEntidad.MONTO_DESEMBOLSO = MONTO_DESEMBOLSO
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            Return Me.ActualizarDESEMBOLSO_MUNI_LIQUI_DET(lEntidad)
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
    ''' 	[GenApp]	26/04/2012	Created
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
    ''' 	[GenApp]	26/04/2012	Created
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
    ''' la Tabla DESEMBOLSO .
    ''' </summary>
    ''' <param name="ID_DESEMBOLSO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorDESEMBOLSO(ByVal ID_DESEMBOLSO As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDESEMBOLSO_MUNI_LIQUI_DET
        Try
            Dim mListaDESEMBOLSO_MUNI_LIQUI_DET As New ListaDESEMBOLSO_MUNI_LIQUI_DET
            mListaDESEMBOLSO_MUNI_LIQUI_DET = mDb.ObtenerListaPorDESEMBOLSO(ID_DESEMBOLSO, asColumnaOrden, asTipoOrden)
            If Not mListaDESEMBOLSO_MUNI_LIQUI_DET Is Nothing And recuperarForaneas Then
                For Each lEntidad As DESEMBOLSO_MUNI_LIQUI_DET in  mListaDESEMBOLSO_MUNI_LIQUI_DET
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaDESEMBOLSO_MUNI_LIQUI_DET
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla MUNICIPIO_LIQUIDACION_DET .
    ''' </summary>
    ''' <param name="ID_LIQUIDACION_DET"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMUNICIPIO_LIQUIDACION_DET(ByVal ID_LIQUIDACION_DET As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDESEMBOLSO_MUNI_LIQUI_DET
        Try
            Dim mListaDESEMBOLSO_MUNI_LIQUI_DET As New ListaDESEMBOLSO_MUNI_LIQUI_DET
            mListaDESEMBOLSO_MUNI_LIQUI_DET = mDb.ObtenerListaPorMUNICIPIO_LIQUIDACION_DET(ID_LIQUIDACION_DET, asColumnaOrden, asTipoOrden)
            If Not mListaDESEMBOLSO_MUNI_LIQUI_DET Is Nothing And recuperarForaneas Then
                For Each lEntidad As DESEMBOLSO_MUNI_LIQUI_DET in  mListaDESEMBOLSO_MUNI_LIQUI_DET
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaDESEMBOLSO_MUNI_LIQUI_DET
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
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As DESEMBOLSO_MUNI_LIQUI_DET )
        aEntidad.fkID_DESEMBOLSO = (New cDESEMBOLSO).ObtenerDESEMBOLSO(aEntidad.ID_DESEMBOLSO)
        aEntidad.fkID_LIQUIDACION_DET = (New cMUNICIPIO_LIQUIDACION_DET).ObtenerMUNICIPIO_LIQUIDACION_DET(aEntidad.ID_LIQUIDACION_DET)
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
    ''' 	[GenApp]	26/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As DESEMBOLSO_MUNI_LIQUI_DET )
    End Sub

#End Region

End Class
