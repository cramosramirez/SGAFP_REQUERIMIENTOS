''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cFACILITADOR_CAPACITADOR
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla FACILITADOR_CAPACITADOR
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/03/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cFACILITADOR_CAPACITADOR
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbFACILITADOR_CAPACITADOR()
    Private mEntidad as New FACILITADOR_CAPACITADOR
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaFACILITADOR_CAPACITADOR
        Try
            Dim mListaFACILITADOR_CAPACITADOR As New ListaFACILITADOR_CAPACITADOR
            mListaFACILITADOR_CAPACITADOR = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaFACILITADOR_CAPACITADOR Is Nothing And recuperarForaneas Then
                For Each lEntidad As FACILITADOR_CAPACITADOR in  mListaFACILITADOR_CAPACITADOR
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaFACILITADOR_CAPACITADOR
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
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerFACILITADOR_CAPACITADOR(ByRef aEntidad As FACILITADOR_CAPACITADOR, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla FACILITADOR_CAPACITADOR.
    ''' </summary>
    ''' <param name="ID_FACILITADOR"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerFACILITADOR_CAPACITADOR(ByVal ID_FACILITADOR As Decimal, ByVal Optional recuperarForaneas As Boolean = False) As FACILITADOR_CAPACITADOR
        Try
            Dim lEntidad As New FACILITADOR_CAPACITADOR
            lEntidad.ID_FACILITADOR = ID_FACILITADOR
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
    ''' <param name="aTIPO_PERSONA">Recuperar registro foraneo de la Entidad TIPO_PERSONA.</param>
    ''' <param name="aPROVEEDOR_AF">Recuperar registro foraneo de la Entidad PROVEEDOR_AF.</param>
    ''' <param name="aMUNICIPIO">Recuperar registro foraneo de la Entidad MUNICIPIO.</param>
    ''' <param name="aDEPARTAMENTO">Recuperar registro foraneo de la Entidad DEPARTAMENTO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerFACILITADOR_CAPACITADORConForaneas(ByVal aEntidad As FACILITADOR_CAPACITADOR, Optional ByVal aTIPO_PERSONA As Boolean = False, Optional ByVal aPROVEEDOR_AF As Boolean = False, Optional ByVal aMUNICIPIO As Boolean = False, Optional ByVal aDEPARTAMENTO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aTIPO_PERSONA, aPROVEEDOR_AF, aMUNICIPIO, aDEPARTAMENTO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla FACILITADOR_CAPACITADOR que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_FACILITADOR"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarFACILITADOR_CAPACITADOR(ByVal ID_FACILITADOR As Decimal) As Integer
        Try
            mEntidad.ID_FACILITADOR = ID_FACILITADOR
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla FACILITADOR_CAPACITADOR que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarFACILITADOR_CAPACITADOR(ByVal aEntidad As FACILITADOR_CAPACITADOR, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarFACILITADOR_CAPACITADOR(ByVal ID_FACILITADOR As Decimal, ByVal ID_TIPO_PERSONA As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal NOMBRE_FACILITADOR As String, ByVal NIT As String, ByVal DUI As String, ByVal ISSS As String, ByVal FECHA_INGRESO As DateTime, ByVal TELEFONO As String, ByVal EMAIL As String, ByVal DIRECCION As String, ByVal NOTAS As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime) As Integer
        Try
            Dim lEntidad As New FACILITADOR_CAPACITADOR
            lEntidad.ID_FACILITADOR = ID_FACILITADOR
            lEntidad.ID_TIPO_PERSONA = ID_TIPO_PERSONA
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.NOMBRE_FACILITADOR = NOMBRE_FACILITADOR
            lEntidad.NIT = NIT
            lEntidad.DUI = DUI
            lEntidad.ISSS = ISSS
            lEntidad.FECHA_INGRESO = FECHA_INGRESO
            lEntidad.TELEFONO = TELEFONO
            lEntidad.EMAIL = EMAIL
            lEntidad.DIRECCION = DIRECCION
            lEntidad.NOTAS = NOTAS
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            Return Me.ActualizarFACILITADOR_CAPACITADOR(lEntidad)
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
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarFACILITADOR_CAPACITADOR(ByVal aEntidad As FACILITADOR_CAPACITADOR) As Integer
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
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarFACILITADOR_CAPACITADOR(ByVal aEntidad As FACILITADOR_CAPACITADOR, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarFACILITADOR_CAPACITADOR(ByVal ID_FACILITADOR As Decimal, ByVal ID_TIPO_PERSONA As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal NOMBRE_FACILITADOR As String, ByVal NIT As String, ByVal DUI As String, ByVal ISSS As String, ByVal FECHA_INGRESO As DateTime, ByVal TELEFONO As String, ByVal EMAIL As String, ByVal DIRECCION As String, ByVal NOTAS As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime) As Integer
        Try
            Dim lEntidad As New FACILITADOR_CAPACITADOR
            lEntidad.ID_FACILITADOR = ID_FACILITADOR
            lEntidad.ID_TIPO_PERSONA = ID_TIPO_PERSONA
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.NOMBRE_FACILITADOR = NOMBRE_FACILITADOR
            lEntidad.NIT = NIT
            lEntidad.DUI = DUI
            lEntidad.ISSS = ISSS
            lEntidad.FECHA_INGRESO = FECHA_INGRESO
            lEntidad.TELEFONO = TELEFONO
            lEntidad.EMAIL = EMAIL
            lEntidad.DIRECCION = DIRECCION
            lEntidad.NOTAS = NOTAS
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            Return Me.ActualizarFACILITADOR_CAPACITADOR(lEntidad)
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
    ''' 	[GenApp]	10/03/2011	Created
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
    ''' 	[GenApp]	10/03/2011	Created
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
    ''' la Tabla TIPO_PERSONA .
    ''' </summary>
    ''' <param name="ID_TIPO_PERSONA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_PERSONA(ByVal ID_TIPO_PERSONA As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaFACILITADOR_CAPACITADOR
        Try
            Dim mListaFACILITADOR_CAPACITADOR As New ListaFACILITADOR_CAPACITADOR
            mListaFACILITADOR_CAPACITADOR = mDb.ObtenerListaPorTIPO_PERSONA(ID_TIPO_PERSONA, asColumnaOrden, asTipoOrden)
            If Not mListaFACILITADOR_CAPACITADOR Is Nothing And recuperarForaneas Then
                For Each lEntidad As FACILITADOR_CAPACITADOR in  mListaFACILITADOR_CAPACITADOR
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaFACILITADOR_CAPACITADOR
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
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaFACILITADOR_CAPACITADOR
        Try
            Dim mListaFACILITADOR_CAPACITADOR As New ListaFACILITADOR_CAPACITADOR
            mListaFACILITADOR_CAPACITADOR = mDb.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF, asColumnaOrden, asTipoOrden)
            If Not mListaFACILITADOR_CAPACITADOR Is Nothing And recuperarForaneas Then
                For Each lEntidad As FACILITADOR_CAPACITADOR in  mListaFACILITADOR_CAPACITADOR
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaFACILITADOR_CAPACITADOR
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
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaFACILITADOR_CAPACITADOR
        Try
            Dim mListaFACILITADOR_CAPACITADOR As New ListaFACILITADOR_CAPACITADOR
            mListaFACILITADOR_CAPACITADOR = mDb.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, asColumnaOrden, asTipoOrden)
            If Not mListaFACILITADOR_CAPACITADOR Is Nothing And recuperarForaneas Then
                For Each lEntidad As FACILITADOR_CAPACITADOR in  mListaFACILITADOR_CAPACITADOR
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaFACILITADOR_CAPACITADOR
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
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaFACILITADOR_CAPACITADOR
        Try
            Dim mListaFACILITADOR_CAPACITADOR As New ListaFACILITADOR_CAPACITADOR
            mListaFACILITADOR_CAPACITADOR = mDb.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO, asColumnaOrden, asTipoOrden)
            If Not mListaFACILITADOR_CAPACITADOR Is Nothing And recuperarForaneas Then
                For Each lEntidad As FACILITADOR_CAPACITADOR in  mListaFACILITADOR_CAPACITADOR
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaFACILITADOR_CAPACITADOR
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
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As FACILITADOR_CAPACITADOR )
        aEntidad.fkID_TIPO_PERSONA = (New cTIPO_PERSONA).ObtenerTIPO_PERSONA(aEntidad.ID_TIPO_PERSONA)
        aEntidad.fkID_PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF)
        aEntidad.fkCODIGO_MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(aEntidad.CODIGO_DEPARTAMENTO, aEntidad.CODIGO_MUNICIPIO)
        aEntidad.fkCODIGO_DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(aEntidad.CODIGO_DEPARTAMENTO)
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
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As FACILITADOR_CAPACITADOR )
    End Sub

#End Region

End Class
