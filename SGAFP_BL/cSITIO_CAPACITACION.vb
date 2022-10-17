''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cSITIO_CAPACITACION
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SITIO_CAPACITACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	14/02/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSITIO_CAPACITACION
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSITIO_CAPACITACION()
    Private mEntidad as New SITIO_CAPACITACION
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSITIO_CAPACITACION
        Try
            Dim mListaSITIO_CAPACITACION As New ListaSITIO_CAPACITACION
            mListaSITIO_CAPACITACION = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSITIO_CAPACITACION Is Nothing And recuperarForaneas Then
                For Each lEntidad As SITIO_CAPACITACION in  mListaSITIO_CAPACITACION
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSITIO_CAPACITACION
            
            Return mListaSITIO_CAPACITACION
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSITIO_CAPACITACION(ByRef aEntidad As SITIO_CAPACITACION, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
            Return liRet
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SITIO_CAPACITACION.
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As SITIO_CAPACITACION
        Try
            Dim lEntidad As New SITIO_CAPACITACION
            lEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
            If liRet > 0 And recuperarForaneas Then
                Try
                    Me.RecuperarForaneas(lEntidad)
                Catch ex As Exception
                End Try
            End If
            If Not recuperarHijas Then Return lEntidad
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
    ''' <param name="aMUNICIPIO">Recuperar registro foraneo de la Entidad MUNICIPIO.</param>
    ''' <param name="aDEPARTAMENTO">Recuperar registro foraneo de la Entidad DEPARTAMENTO.</param>
    ''' <param name="aPROVEEDOR_AF">Recuperar registro foraneo de la Entidad PROVEEDOR_AF.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSITIO_CAPACITACIONConForaneas(ByVal aEntidad As SITIO_CAPACITACION, Optional ByVal aMUNICIPIO As Boolean = False, Optional ByVal aDEPARTAMENTO As Boolean = False, Optional ByVal aPROVEEDOR_AF As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aMUNICIPIO, aDEPARTAMENTO, aPROVEEDOR_AF)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SITIO_CAPACITACION que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal) As Integer
        Try
            mEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SITIO_CAPACITACION que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSITIO_CAPACITACION(ByVal aEntidad As SITIO_CAPACITACION, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal, ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal ID_PROVEEDOR_AF As Decimal, ByVal NOMBRE_SITIO As String, ByVal FORMATO_CODIGO_CURSO As String, ByVal DIRECCION As String, ByVal TELEFONO As String, ByVal FAX As String, ByVal EMAIL As String, ByVal NUMERO_AULAS As Decimal, ByVal FECHA_REGISTRO As DateTime, ByVal ENCARGADO As String, ByVal TELEFONO_ENCARGADO As String, ByVal EMAIL_ENCARGADO As String, ByVal CARGO_ENCARGADO As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal LATITUD As String, ByVal LONGITUD As String) As Integer
        Try
            Dim lEntidad As New SITIO_CAPACITACION
            lEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.NOMBRE_SITIO = NOMBRE_SITIO
            lEntidad.FORMATO_CODIGO_CURSO = FORMATO_CODIGO_CURSO
            lEntidad.DIRECCION = DIRECCION
            lEntidad.TELEFONO = TELEFONO
            lEntidad.FAX = FAX
            lEntidad.EMAIL = EMAIL
            lEntidad.NUMERO_AULAS = NUMERO_AULAS
            lEntidad.FECHA_REGISTRO = FECHA_REGISTRO
            lEntidad.ENCARGADO = ENCARGADO
            lEntidad.TELEFONO_ENCARGADO = TELEFONO_ENCARGADO
            lEntidad.EMAIL_ENCARGADO = EMAIL_ENCARGADO
            lEntidad.CARGO_ENCARGADO = CARGO_ENCARGADO
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.LATITUD = LATITUD
            lEntidad.LONGITUD = LONGITUD
            Return Me.ActualizarSITIO_CAPACITACION(lEntidad)
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSITIO_CAPACITACION(ByVal aEntidad As SITIO_CAPACITACION) As Integer
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
    ''' <returns>
    '''  -3 : No se pudo Actualizar el Participante
    ''' </returns>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSITIO_CAPACITACION(ByVal aEntidad As SITIO_CAPACITACION, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
        Try
            If aEntidad.NOMBRE_SITIO.Trim = "" Then
                Me.sError = "Nombre de Sitio es requerido"
                Me.sErrorTecnico = "ID_PROVEEDOR = " + aEntidad.ID_PROVEEDOR_AF.ToString() + "; ID_SITIO_CAPACITACION = " + aEntidad.ID_SITIO_CAPACITACION.ToString()
                Return -3
            End If
            If aEntidad.CODIGO_DEPARTAMENTO = "" Then
                Me.sError = "Departamento es requerido"
                Me.sErrorTecnico = "ID_PROVEEDOR = " + aEntidad.ID_PROVEEDOR_AF.ToString() + "; ID_SITIO_CAPACITACION = " + aEntidad.ID_SITIO_CAPACITACION.ToString()
                Return -3
            End If
            If aEntidad.CODIGO_MUNICIPIO = "" Then
                Me.sError = "Municipio es requerido"
                Me.sErrorTecnico = "ID_PROVEEDOR = " + aEntidad.ID_PROVEEDOR_AF.ToString() + "; ID_SITIO_CAPACITACION = " + aEntidad.ID_SITIO_CAPACITACION.ToString()
                Return -3
            End If
            If aEntidad.TELEFONO.Trim = "" Then
                Me.sError = "Telefono del Centro es requerido"
                Me.sErrorTecnico = "ID_PROVEEDOR = " + aEntidad.ID_PROVEEDOR_AF.ToString() + "; ID_SITIO_CAPACITACION = " + aEntidad.ID_SITIO_CAPACITACION.ToString()
                Return -3
            End If
            If aEntidad.TELEFONO_ENCARGADO.Trim = "" Then
                Me.sError = "Telefono del Encargado del Centro es requerido"
                Me.sErrorTecnico = "ID_PROVEEDOR = " + aEntidad.ID_PROVEEDOR_AF.ToString() + "; ID_SITIO_CAPACITACION = " + aEntidad.ID_SITIO_CAPACITACION.ToString()
                Return -3
            End If
            If aEntidad.ENCARGADO.Trim = "" Then
                Me.sError = "Encargado del Centro es requerido"
                Me.sErrorTecnico = "ID_PROVEEDOR = " + aEntidad.ID_PROVEEDOR_AF.ToString() + "; ID_SITIO_CAPACITACION = " + aEntidad.ID_SITIO_CAPACITACION.ToString()
                Return -3
            End If
            If aEntidad.DIRECCION.Trim = "" Then
                Me.sError = "Dirección del Centro es requerida"
                Me.sErrorTecnico = "ID_PROVEEDOR = " + aEntidad.ID_PROVEEDOR_AF.ToString() + "; ID_SITIO_CAPACITACION = " + aEntidad.ID_SITIO_CAPACITACION.ToString()
                Return -3
            End If

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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal, ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal ID_PROVEEDOR_AF As Decimal, ByVal NOMBRE_SITIO As String, ByVal FORMATO_CODIGO_CURSO As String, ByVal DIRECCION As String, ByVal TELEFONO As String, ByVal FAX As String, ByVal EMAIL As String, ByVal NUMERO_AULAS As Decimal, ByVal FECHA_REGISTRO As DateTime, ByVal ENCARGADO As String, ByVal TELEFONO_ENCARGADO As String, ByVal EMAIL_ENCARGADO As String, ByVal CARGO_ENCARGADO As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal LATITUD As String, ByVal LONGITUD As String) As Integer
        Try
            Dim lEntidad As New SITIO_CAPACITACION
            lEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.NOMBRE_SITIO = NOMBRE_SITIO
            lEntidad.FORMATO_CODIGO_CURSO = FORMATO_CODIGO_CURSO
            lEntidad.DIRECCION = DIRECCION
            lEntidad.TELEFONO = TELEFONO
            lEntidad.FAX = FAX
            lEntidad.EMAIL = EMAIL
            lEntidad.NUMERO_AULAS = NUMERO_AULAS
            lEntidad.FECHA_REGISTRO = FECHA_REGISTRO
            lEntidad.ENCARGADO = ENCARGADO
            lEntidad.TELEFONO_ENCARGADO = TELEFONO_ENCARGADO
            lEntidad.EMAIL_ENCARGADO = EMAIL_ENCARGADO
            lEntidad.CARGO_ENCARGADO = CARGO_ENCARGADO
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.LATITUD = LATITUD
            lEntidad.LONGITUD = LONGITUD
            Return Me.ActualizarSITIO_CAPACITACION(lEntidad)
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
    ''' 	[GenApp]	14/02/2011	Created
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
    ''' 	[GenApp]	14/02/2011	Created
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
    ''' la Tabla MUNICIPIO .
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSITIO_CAPACITACION
        Try
            Dim mListaSITIO_CAPACITACION As New ListaSITIO_CAPACITACION
            mListaSITIO_CAPACITACION = mDb.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, asColumnaOrden, asTipoOrden)
            If Not mListaSITIO_CAPACITACION Is Nothing And recuperarForaneas Then
                For Each lEntidad As SITIO_CAPACITACION in  mListaSITIO_CAPACITACION
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSITIO_CAPACITACION
            
            Return mListaSITIO_CAPACITACION
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
    ''' <param name="CODIGO_REGION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_REGION As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSITIO_CAPACITACION
        Try
            Dim mListaSITIO_CAPACITACION As New ListaSITIO_CAPACITACION
            mListaSITIO_CAPACITACION = mDb.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO, CODIGO_REGION, asColumnaOrden, asTipoOrden)
            If Not mListaSITIO_CAPACITACION Is Nothing And recuperarForaneas Then
                For Each lEntidad As SITIO_CAPACITACION in  mListaSITIO_CAPACITACION
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSITIO_CAPACITACION
            
            Return mListaSITIO_CAPACITACION
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSITIO_CAPACITACION
        Try
            Dim mListaSITIO_CAPACITACION As New ListaSITIO_CAPACITACION
            mListaSITIO_CAPACITACION = mDb.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF, asColumnaOrden, asTipoOrden)
            If Not mListaSITIO_CAPACITACION Is Nothing And recuperarForaneas Then
                For Each lEntidad As SITIO_CAPACITACION in  mListaSITIO_CAPACITACION
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSITIO_CAPACITACION
            Return mListaSITIO_CAPACITACION
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
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SITIO_CAPACITACION )
        aEntidad.fkCODIGO_MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(aEntidad.CODIGO_DEPARTAMENTO, aEntidad.CODIGO_MUNICIPIO)
        aEntidad.fkCODIGO_DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(aEntidad.CODIGO_DEPARTAMENTO)
        aEntidad.fkID_PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF)
    End Sub


#End Region

End Class
