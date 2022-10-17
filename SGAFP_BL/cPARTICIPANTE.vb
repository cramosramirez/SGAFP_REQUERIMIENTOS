''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cPARTICIPANTE
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla PARTICIPANTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/01/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cPARTICIPANTE
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbPARTICIPANTE()
    Private mEntidad as New PARTICIPANTE
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPARTICIPANTE
        Try
            Dim mListaPARTICIPANTE As New ListaPARTICIPANTE
            mListaPARTICIPANTE = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaPARTICIPANTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As PARTICIPANTE in  mListaPARTICIPANTE
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPARTICIPANTE
            If Not mListaPARTICIPANTE Is Nothing Then
                For Each lEntidad As PARTICIPANTE in  mListaPARTICIPANTE
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPARTICIPANTE
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
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerPARTICIPANTE(ByRef aEntidad As PARTICIPANTE, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla PARTICIPANTE.
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As PARTICIPANTE
        Try
            Dim lEntidad As New PARTICIPANTE
            lEntidad.ID_PARTICIPANTE = ID_PARTICIPANTE
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
    ''' <param name="aPAIS">Recuperar registro foraneo de la Entidad PAIS.</param>
    ''' <param name="aESTADO_CIVIL">Recuperar registro foraneo de la Entidad ESTADO_CIVIL.</param>
    ''' <param name="aDEPARTAMENTO">Recuperar registro foraneo de la Entidad DEPARTAMENTO.</param>
    ''' <param name="aMUNICIPIO">Recuperar registro foraneo de la Entidad MUNICIPIO.</param>
    ''' <param name="aNIVEL_ACADEMICO">Recuperar registro foraneo de la Entidad NIVEL_ACADEMICO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerPARTICIPANTEConForaneas(ByVal aEntidad As PARTICIPANTE, Optional ByVal aPAIS As Boolean = False, Optional ByVal aESTADO_CIVIL As Boolean = False, Optional ByVal aDEPARTAMENTO As Boolean = False, Optional ByVal aMUNICIPIO As Boolean = False, Optional ByVal aNIVEL_ACADEMICO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aPAIS, aESTADO_CIVIL, aDEPARTAMENTO, aMUNICIPIO, aNIVEL_ACADEMICO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PARTICIPANTE que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal) As Integer
        Try
            mEntidad.ID_PARTICIPANTE = ID_PARTICIPANTE
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla PARTICIPANTE que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarPARTICIPANTE(ByVal aEntidad As PARTICIPANTE, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal, ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal GENERO As String, ByVal ID_PAIS As Decimal, ByVal FECHA_NACIMIENTO As DateTime, ByVal DIRECCION As String, ByVal DUI As String, ByVal NIT As String, ByVal ISSS As String, ByVal TIPO_DOCTO As Decimal, ByVal NUM_DOCTO As String, ByVal TELEFONO As String, ByVal MOVIL As String, ByVal EMAIL As String, ByVal ID_ESTADO_CIVIL As Decimal, ByVal PROFESION_OFICIO As String, ByVal OCUPACION_ACTUAL As String, ByVal TITULO_CERTIFICADO_OBTENIDO As String, ByVal DEPARTAMENTO_NAC As String, ByVal MUNICIPIO_NAC As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal ID_NIVEL_ACADEMICO As Decimal, ByVal OTRA_EDUCACION_FORMAL As String, ByVal CON_DISCAPACIDAD As Decimal, ByVal DISC_OTRA As String, ByVal LASTUPDATE As DateTime, ByVal USERID As String) As Integer
        Try
            Dim lEntidad As New PARTICIPANTE
            lEntidad.ID_PARTICIPANTE = ID_PARTICIPANTE
            lEntidad.NOMBRES = NOMBRES
            lEntidad.APELLIDOS = APELLIDOS
            lEntidad.GENERO = GENERO
            lEntidad.ID_PAIS = ID_PAIS
            lEntidad.FECHA_NACIMIENTO = FECHA_NACIMIENTO
            lEntidad.DIRECCION = DIRECCION
            lEntidad.DUI = DUI
            lEntidad.NIT = NIT
            lEntidad.ISSS = ISSS
            lEntidad.TIPO_DOCTO = TIPO_DOCTO
            lEntidad.NUM_DOCTO = NUM_DOCTO
            lEntidad.TELEFONO = TELEFONO
            lEntidad.MOVIL = MOVIL
            lEntidad.EMAIL = EMAIL
            lEntidad.ID_ESTADO_CIVIL = ID_ESTADO_CIVIL
            lEntidad.PROFESION_OFICIO = PROFESION_OFICIO
            lEntidad.OCUPACION_ACTUAL = OCUPACION_ACTUAL
            lEntidad.TITULO_CERTIFICADO_OBTENIDO = TITULO_CERTIFICADO_OBTENIDO
            lEntidad.DEPARTAMENTO_NAC = DEPARTAMENTO_NAC
            lEntidad.MUNICIPIO_NAC = MUNICIPIO_NAC
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.ID_NIVEL_ACADEMICO = ID_NIVEL_ACADEMICO
            lEntidad.OTRA_EDUCACION_FORMAL = OTRA_EDUCACION_FORMAL
            lEntidad.CON_DISCAPACIDAD = CON_DISCAPACIDAD
            lEntidad.DISC_OTRA = DISC_OTRA
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.USERID = USERID
            Return Me.ActualizarPARTICIPANTE(lEntidad)
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
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarPARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal, ByVal NOMBRES As String, ByVal APELLIDOS As String, ByVal GENERO As String, ByVal ID_PAIS As Decimal, ByVal FECHA_NACIMIENTO As DateTime, ByVal DIRECCION As String, ByVal DUI As String, ByVal NIT As String, ByVal ISSS As String, ByVal TIPO_DOCTO As Decimal, ByVal NUM_DOCTO As String, ByVal TELEFONO As String, ByVal MOVIL As String, ByVal EMAIL As String, ByVal ID_ESTADO_CIVIL As Decimal, ByVal PROFESION_OFICIO As String, ByVal OCUPACION_ACTUAL As String, ByVal TITULO_CERTIFICADO_OBTENIDO As String, ByVal DEPARTAMENTO_NAC As String, ByVal MUNICIPIO_NAC As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal ID_NIVEL_ACADEMICO As Decimal, ByVal OTRA_EDUCACION_FORMAL As String, ByVal CON_DISCAPACIDAD As Decimal, ByVal DISC_OTRA As String, ByVal LASTUPDATE As DateTime, ByVal USERID As String) As Integer
        Try
            Dim lEntidad As New PARTICIPANTE
            lEntidad.ID_PARTICIPANTE = ID_PARTICIPANTE
            lEntidad.NOMBRES = NOMBRES
            lEntidad.APELLIDOS = APELLIDOS
            lEntidad.GENERO = GENERO
            lEntidad.ID_PAIS = ID_PAIS
            lEntidad.FECHA_NACIMIENTO = FECHA_NACIMIENTO
            lEntidad.DIRECCION = DIRECCION
            lEntidad.DUI = DUI
            lEntidad.NIT = NIT
            lEntidad.ISSS = ISSS
            lEntidad.TIPO_DOCTO = TIPO_DOCTO
            lEntidad.NUM_DOCTO = NUM_DOCTO
            lEntidad.TELEFONO = TELEFONO
            lEntidad.MOVIL = MOVIL
            lEntidad.EMAIL = EMAIL
            lEntidad.ID_ESTADO_CIVIL = ID_ESTADO_CIVIL
            lEntidad.PROFESION_OFICIO = PROFESION_OFICIO
            lEntidad.OCUPACION_ACTUAL = OCUPACION_ACTUAL
            lEntidad.TITULO_CERTIFICADO_OBTENIDO = TITULO_CERTIFICADO_OBTENIDO
            lEntidad.DEPARTAMENTO_NAC = DEPARTAMENTO_NAC
            lEntidad.MUNICIPIO_NAC = MUNICIPIO_NAC
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.ID_NIVEL_ACADEMICO = ID_NIVEL_ACADEMICO
            lEntidad.OTRA_EDUCACION_FORMAL = OTRA_EDUCACION_FORMAL
            lEntidad.CON_DISCAPACIDAD = CON_DISCAPACIDAD
            lEntidad.DISC_OTRA = DISC_OTRA
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.USERID = USERID
            Return Me.ActualizarPARTICIPANTE(lEntidad)
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
    ''' 	[GenApp]	19/01/2011	Created
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
    ''' 	[GenApp]	19/01/2011	Created
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
    ''' Función que devuelve una Colección de Entidades de la Tabla PARTICIPANTE_AF
    ''' filtrada por la Llave Primaria de la Tabla PARTICIPANTE.
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPARTICIPANTE_AF(ByVal ID_PARTICIPANTE As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPARTICIPANTE_AF
        Try
            Dim mCPARTICIPANTE_AF As New cPARTICIPANTE_AF
            Dim mListaPARTICIPANTE_AF As New ListaPARTICIPANTE_AF
            Return mCPARTICIPANTE_AF.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE, recuperarHijas, recuperarForaneas, asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve una Colección de Entidades de la Tabla DISCA_POR_PARTICIPANTE
    ''' filtrada por la Llave Primaria de la Tabla PARTICIPANTE.
    ''' </summary>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaDISCA_POR_PARTICIPANTE(ByVal ID_PARTICIPANTE As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaDISCA_POR_PARTICIPANTE
        Try
            Dim mCDISCA_POR_PARTICIPANTE As New cDISCA_POR_PARTICIPANTE
            Dim mListaDISCA_POR_PARTICIPANTE As New ListaDISCA_POR_PARTICIPANTE
            Return mCDISCA_POR_PARTICIPANTE.ObtenerListaPorPARTICIPANTE(ID_PARTICIPANTE, recuperarForaneas, asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PAIS .
    ''' </summary>
    ''' <param name="ID_PAIS"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPAIS(ByVal ID_PAIS As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPARTICIPANTE
        Try
            Dim mListaPARTICIPANTE As New ListaPARTICIPANTE
            mListaPARTICIPANTE = mDb.ObtenerListaPorPAIS(ID_PAIS, asColumnaOrden, asTipoOrden)
            If Not mListaPARTICIPANTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As PARTICIPANTE in  mListaPARTICIPANTE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPARTICIPANTE
            If Not mListaPARTICIPANTE Is Nothing Then
                For Each lEntidad As PARTICIPANTE in  mListaPARTICIPANTE
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPARTICIPANTE
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ESTADO_CIVIL .
    ''' </summary>
    ''' <param name="ID_ESTADO_CIVIL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorESTADO_CIVIL(ByVal ID_ESTADO_CIVIL As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPARTICIPANTE
        Try
            Dim mListaPARTICIPANTE As New ListaPARTICIPANTE
            mListaPARTICIPANTE = mDb.ObtenerListaPorESTADO_CIVIL(ID_ESTADO_CIVIL, asColumnaOrden, asTipoOrden)
            If Not mListaPARTICIPANTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As PARTICIPANTE in  mListaPARTICIPANTE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPARTICIPANTE
            If Not mListaPARTICIPANTE Is Nothing Then
                For Each lEntidad As PARTICIPANTE in  mListaPARTICIPANTE
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPARTICIPANTE
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
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPARTICIPANTE
        Try
            Dim mListaPARTICIPANTE As New ListaPARTICIPANTE
            mListaPARTICIPANTE = mDb.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO, asColumnaOrden, asTipoOrden)
            If Not mListaPARTICIPANTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As PARTICIPANTE in  mListaPARTICIPANTE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPARTICIPANTE
            If Not mListaPARTICIPANTE Is Nothing Then
                For Each lEntidad As PARTICIPANTE in  mListaPARTICIPANTE
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPARTICIPANTE
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
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPARTICIPANTE
        Try
            Dim mListaPARTICIPANTE As New ListaPARTICIPANTE
            mListaPARTICIPANTE = mDb.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, asColumnaOrden, asTipoOrden)
            If Not mListaPARTICIPANTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As PARTICIPANTE in  mListaPARTICIPANTE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPARTICIPANTE
            If Not mListaPARTICIPANTE Is Nothing Then
                For Each lEntidad As PARTICIPANTE in  mListaPARTICIPANTE
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPARTICIPANTE
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla NIVEL_ACADEMICO .
    ''' </summary>
    ''' <param name="ID_NIVEL_ACADEMICO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorNIVEL_ACADEMICO(ByVal ID_NIVEL_ACADEMICO As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaPARTICIPANTE
        Try
            Dim mListaPARTICIPANTE As New ListaPARTICIPANTE
            mListaPARTICIPANTE = mDb.ObtenerListaPorNIVEL_ACADEMICO(ID_NIVEL_ACADEMICO, asColumnaOrden, asTipoOrden)
            If Not mListaPARTICIPANTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As PARTICIPANTE in  mListaPARTICIPANTE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaPARTICIPANTE
            If Not mListaPARTICIPANTE Is Nothing Then
                For Each lEntidad As PARTICIPANTE in  mListaPARTICIPANTE
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaPARTICIPANTE
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
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As PARTICIPANTE )
        aEntidad.fkID_PAIS = (New cPAIS).ObtenerPAIS(aEntidad.ID_PAIS)
        aEntidad.fkID_ESTADO_CIVIL = (New cESTADO_CIVIL).ObtenerESTADO_CIVIL(aEntidad.ID_ESTADO_CIVIL)
        aEntidad.fkCODIGO_DEPARTAMENTO = (New cDEPARTAMENTO).ObtenerDEPARTAMENTO(aEntidad.CODIGO_DEPARTAMENTO)
        aEntidad.fkCODIGO_MUNICIPIO = (New cMUNICIPIO).ObtenerMUNICIPIO(aEntidad.CODIGO_DEPARTAMENTO, aEntidad.CODIGO_MUNICIPIO)
        aEntidad.fkID_NIVEL_ACADEMICO = (New cNIVEL_ACADEMICO).ObtenerNIVEL_ACADEMICO(aEntidad.ID_NIVEL_ACADEMICO)
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
    ''' 	[GenApp]	19/01/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As PARTICIPANTE )
        aEntidad.PARTICIPANTE_AFPARTICIPANTE = Me.ObtenerListaPARTICIPANTE_AF(aEntidad.ID_PARTICIPANTE)
        aEntidad.DISCA_POR_PARTICIPANTEPARTICIPANTE = Me.ObtenerListaDISCA_POR_PARTICIPANTE(aEntidad.ID_PARTICIPANTE)
    End Sub

#End Region

End Class
