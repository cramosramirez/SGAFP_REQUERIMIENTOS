''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cPROVEEDOR_AF
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla PROVEEDOR_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	10/03/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cPROVEEDOR_AF
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbPROVEEDOR_AF()
    Private mEntidad as New PROVEEDOR_AF
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
    Public Function ObtenerLista(Optional ByVal recuperarHijas As Boolean = False, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "NOMBRE_PROVEEDOR", Optional ByVal asTipoOrden As String = "ASC") As listaPROVEEDOR_AF
        Try
            Dim mListaPROVEEDOR_AF As New listaPROVEEDOR_AF
            mListaPROVEEDOR_AF = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaPROVEEDOR_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROVEEDOR_AF In mListaPROVEEDOR_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPROVEEDOR_AF
            If Not mListaPROVEEDOR_AF Is Nothing Then
                For Each lEntidad As PROVEEDOR_AF In mListaPROVEEDOR_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPROVEEDOR_AF
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
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerPROVEEDOR_AF(ByRef aEntidad As PROVEEDOR_AF, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla PROVEEDOR_AF.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As PROVEEDOR_AF
        Try
            Dim lEntidad As New PROVEEDOR_AF
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
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
    ''' Función que recupera un registro y lo setea en la Entidad que recibe de
    ''' parámetro, ademas de permitir agregar en la Entidad las Foraneas.
    ''' </summary>
    ''' <param name="aEntidad">Entidad donde se ingresara el registro seleccionado.</param>
    ''' <param name="aMUNICIPIO">Recuperar registro foraneo de la Entidad MUNICIPIO.</param>
    ''' <param name="aDEPARTAMENTO">Recuperar registro foraneo de la Entidad DEPARTAMENTO.</param>
    ''' <param name="aTIPO_PERSONA">Recuperar registro foraneo de la Entidad TIPO_PERSONA.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerPROVEEDOR_AFConForaneas(ByVal aEntidad As PROVEEDOR_AF, Optional ByVal aMUNICIPIO As Boolean = False, Optional ByVal aDEPARTAMENTO As Boolean = False, Optional ByVal aTIPO_PERSONA As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aMUNICIPIO, aDEPARTAMENTO, aTIPO_PERSONA)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PROVEEDOR_AF que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal) As Integer
        Try
            mEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PROVEEDOR_AF que se le envía como
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
    Public Function EliminarPROVEEDOR_AF(ByVal aEntidad As PROVEEDOR_AF, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    Public Function AgregarPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal ID_TIPO_PERSONA As Decimal, ByVal NOMBRE_PROVEEDOR As String, ByVal RAZON_SOCIAL As String, ByVal NIT As String, ByVal DUI As String, ByVal NRC As String, ByVal ISSS As String, ByVal FECHA_INGRESO As DateTime, ByVal FECHA_ACREDITACION As DateTime, ByVal DIRECCION As String, ByVal EMAIL As String, ByVal TELEFONO As String, ByVal FAX As String, ByVal URL As String, ByVal CONTACTO As String, ByVal TELEFONO_CONTACTO As String, ByVal EMAIL_CONTACTO As String, ByVal CARGO_CONTACTO As String, ByVal ESTADO As String, ByVal NOTAS As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal FECHA_CREACION As Date, ByVal USUARIO_CREACION As String) As Integer
        Try
            Dim lEntidad As New PROVEEDOR_AF
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.ID_TIPO_PERSONA = ID_TIPO_PERSONA
            lEntidad.NOMBRE_PROVEEDOR = NOMBRE_PROVEEDOR
            lEntidad.RAZON_SOCIAL = RAZON_SOCIAL
            lEntidad.NIT = NIT
            lEntidad.DUI = DUI
            lEntidad.NRC = NRC
            lEntidad.ISSS = ISSS
            lEntidad.FECHA_INGRESO = FECHA_INGRESO
            lEntidad.FECHA_ACREDITACION = FECHA_ACREDITACION
            lEntidad.DIRECCION = DIRECCION
            lEntidad.EMAIL = EMAIL
            lEntidad.TELEFONO = TELEFONO
            lEntidad.FAX = FAX
            lEntidad.URL = URL
            lEntidad.CONTACTO = CONTACTO
            lEntidad.TELEFONO_CONTACTO = TELEFONO_CONTACTO
            lEntidad.EMAIL_CONTACTO = EMAIL_CONTACTO
            lEntidad.CARGO_CONTACTO = CARGO_CONTACTO
            lEntidad.ESTADO = ESTADO
            lEntidad.NOTAS = NOTAS
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.FECHA_CREACION = FECHA_CREACION
            lEntidad.USUARIO_CREACION = USUARIO_CREACION
            Return Me.ActualizarPROVEEDOR_AF(lEntidad)
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
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal ID_TIPO_PERSONA As Decimal, ByVal NOMBRE_PROVEEDOR As String, ByVal RAZON_SOCIAL As String, ByVal NIT As String, ByVal DUI As String, ByVal NRC As String, ByVal ISSS As String, ByVal FECHA_INGRESO As DateTime, ByVal FECHA_ACREDITACION As DateTime, ByVal DIRECCION As String, ByVal EMAIL As String, ByVal TELEFONO As String, ByVal FAX As String, ByVal URL As String, ByVal CONTACTO As String, ByVal TELEFONO_CONTACTO As String, ByVal EMAIL_CONTACTO As String, ByVal CARGO_CONTACTO As String, ByVal ESTADO As String, ByVal NOTAS As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal FECHA_CREACION As Date, ByVal USUARIO_CREACION As String) As Integer
        Try
            Dim lEntidad As New PROVEEDOR_AF
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.ID_TIPO_PERSONA = ID_TIPO_PERSONA
            lEntidad.NOMBRE_PROVEEDOR = NOMBRE_PROVEEDOR
            lEntidad.RAZON_SOCIAL = RAZON_SOCIAL
            lEntidad.NIT = NIT
            lEntidad.DUI = DUI
            lEntidad.NRC = NRC
            lEntidad.ISSS = ISSS
            lEntidad.FECHA_INGRESO = FECHA_INGRESO
            lEntidad.FECHA_ACREDITACION = FECHA_ACREDITACION
            lEntidad.DIRECCION = DIRECCION
            lEntidad.EMAIL = EMAIL
            lEntidad.TELEFONO = TELEFONO
            lEntidad.FAX = FAX
            lEntidad.URL = URL
            lEntidad.CONTACTO = CONTACTO
            lEntidad.TELEFONO_CONTACTO = TELEFONO_CONTACTO
            lEntidad.EMAIL_CONTACTO = EMAIL_CONTACTO
            lEntidad.CARGO_CONTACTO = CARGO_CONTACTO
            lEntidad.ESTADO = ESTADO
            lEntidad.NOTAS = NOTAS
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.FECHA_CREACION = FECHA_CREACION
            lEntidad.USUARIO_CREACION = USUARIO_CREACION
            Return Me.ActualizarPROVEEDOR_AF(lEntidad)
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
    ''' Función que devuelve una Colección de Entidades de la Tabla CONTRATO_PROVEE_AF
    ''' filtrada por la Llave Primaria de la Tabla PROVEEDOR_AF.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    '''  	[cramos]	08/12/2011	Modificado, Se cambia nombre de la entidad CONTRATO_PROVEE_AF a: CONTRATO_PROVEEDOR_AF
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaCONTRATO_PROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCONTRATO_PROVEEDOR_AF
        Try
            Dim mCCONTRATO_PROVEEDOR_AF As New cCONTRATO_PROVEEDOR_AF
            Dim mListaCONTRATO_PROVEEDOR_AF As New listaCONTRATO_PROVEEDOR_AF
            Return mCCONTRATO_PROVEEDOR_AF.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF, recuperarForaneas, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    '''' -----------------------------------------------------------------------------
    '''' <summary>
    '''' Función que devuelve una Colección de Entidades de la Tabla OFERTA_FORMATIVA_SITIO
    '''' filtrada por la Llave Primaria de la Tabla PROVEEDOR_AF.
    '''' </summary>
    '''' <param name="ID_PROVEEDOR_AF"></param>
    '''' <remarks>
    '''' </remarks>
    '''' <history>
    '''' 	[GenApp]	10/03/2011	Created
    '''' </history>
    '''' -----------------------------------------------------------------------------
    '<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    'Public Function ObtenerListaOFERTA_FORMATIVA_SITIO(ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaOFERTA_FORMATIVA_SITIO
    '    Try
    '        Dim mCOFERTA_FORMATIVA_SITIO As New cOFERTA_FORMATIVA_SITIO
    '        Dim mListaOFERTA_FORMATIVA_SITIO As New ListaOFERTA_FORMATIVA_SITIO
    '        Return mCOFERTA_FORMATIVA_SITIO.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF, recuperarForaneas, asColumnaOrden, asTipoOrden)
    '    Catch ex as Exception
    '        ExceptionManager.Publish(ex)
    '        Return Nothing
    '    End Try
    'End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve una Colección de Entidades de la Tabla TECNICOS_SITIOS_ASIG
    ''' filtrada por la Llave Primaria de la Tabla PROVEEDOR_AF.
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	10/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaTECNICOS_SITIOS_ASIG(ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaTECNICOS_SITIOS_ASIG
        Try
            Dim mCTECNICOS_SITIOS_ASIG As New cTECNICOS_SITIOS_ASIG
            Dim mListaTECNICOS_SITIOS_ASIG As New ListaTECNICOS_SITIOS_ASIG
            Return mCTECNICOS_SITIOS_ASIG.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF, recuperarForaneas, asColumnaOrden, asTipoOrden)
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
    Public Function ObtenerListaPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPROVEEDOR_AF
        Try
            Dim mListaPROVEEDOR_AF As New ListaPROVEEDOR_AF
            mListaPROVEEDOR_AF = mDb.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, asColumnaOrden, asTipoOrden)
            If Not mListaPROVEEDOR_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROVEEDOR_AF in  mListaPROVEEDOR_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPROVEEDOR_AF
            If Not mListaPROVEEDOR_AF Is Nothing Then
                For Each lEntidad As PROVEEDOR_AF in  mListaPROVEEDOR_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPROVEEDOR_AF
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
    Public Function ObtenerListaPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPROVEEDOR_AF
        Try
            Dim mListaPROVEEDOR_AF As New ListaPROVEEDOR_AF
            mListaPROVEEDOR_AF = mDb.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO, asColumnaOrden, asTipoOrden)
            If Not mListaPROVEEDOR_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROVEEDOR_AF in  mListaPROVEEDOR_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPROVEEDOR_AF
            If Not mListaPROVEEDOR_AF Is Nothing Then
                For Each lEntidad As PROVEEDOR_AF in  mListaPROVEEDOR_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPROVEEDOR_AF
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
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
    Public Function ObtenerListaPorTIPO_PERSONA(ByVal ID_TIPO_PERSONA As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPROVEEDOR_AF
        Try
            Dim mListaPROVEEDOR_AF As New ListaPROVEEDOR_AF
            mListaPROVEEDOR_AF = mDb.ObtenerListaPorTIPO_PERSONA(ID_TIPO_PERSONA, asColumnaOrden, asTipoOrden)
            If Not mListaPROVEEDOR_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As PROVEEDOR_AF in  mListaPROVEEDOR_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPROVEEDOR_AF
            If Not mListaPROVEEDOR_AF Is Nothing Then
                For Each lEntidad As PROVEEDOR_AF in  mListaPROVEEDOR_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPROVEEDOR_AF
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
    Private Sub RecuperarForaneas(ByRef aEntidad As PROVEEDOR_AF )
        aEntidad.fkCODIGO_MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(aEntidad.CODIGO_DEPARTAMENTO, aEntidad.CODIGO_MUNICIPIO)
        aEntidad.fkCODIGO_DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(aEntidad.CODIGO_DEPARTAMENTO)
        aEntidad.fkID_TIPO_PERSONA = (New cTIPO_PERSONA).ObtenerTIPO_PERSONA(aEntidad.ID_TIPO_PERSONA)
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
    Private Sub RecuperarHijas(ByRef aEntidad As PROVEEDOR_AF)
        'aEntidad.OFERTA_FORMATIVA_SITIOPROVEEDOR_AF = Me.ObtenerListaOFERTA_FORMATIVA_SITIO(aEntidad.ID_PROVEEDOR_AF)
        aEntidad.TECNICOS_SITIOS_ASIGPROVEEDOR_AF = Me.ObtenerListaTECNICOS_SITIOS_ASIG(aEntidad.ID_PROVEEDOR_AF)
    End Sub

#End Region

End Class
