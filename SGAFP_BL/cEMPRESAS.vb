''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cEMPRESAS
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla EMPRESAS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cEMPRESAS
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbEMPRESAS()
    Private mEntidad as New EMPRESAS
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
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaEMPRESAS
        Try
            Dim mListaEMPRESAS As New ListaEMPRESAS
            mListaEMPRESAS = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not recuperarHijas Then Return mListaEMPRESAS
            If Not mListaEMPRESAS Is Nothing Then
                For Each lEntidad As EMPRESAS in  mListaEMPRESAS
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaEMPRESAS
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
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerEMPRESAS(ByRef aEntidad As EMPRESAS, ByVal Optional recuperarHijas As Boolean = False) As Integer
        Try
            Dim liRet As Integer
            liRet = mDb.Recuperar(aEntidad)
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla EMPRESAS.
    ''' </summary>
    ''' <param name="NUMERO_PATRONAL"></param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerEMPRESAS(ByVal NUMERO_PATRONAL As String, ByVal Optional recuperarHijas As Boolean = False) As EMPRESAS
        Try
            Dim lEntidad As New EMPRESAS
            lEntidad.NUMERO_PATRONAL = NUMERO_PATRONAL
            Dim liRet As Integer
            liRet = mDb.Recuperar(lEntidad)
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
    ''' Función que Elimina un Registro de la Tabla EMPRESAS que se le envía como parámetro.
    ''' </summary>
    ''' <param name="NUMERO_PATRONAL"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarEMPRESAS(ByVal NUMERO_PATRONAL As String) As Integer
        Try
            mEntidad.NUMERO_PATRONAL = NUMERO_PATRONAL
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla EMPRESAS que se le envía como
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
    Public Function EliminarEMPRESAS(ByVal aEntidad As EMPRESAS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    Public Function AgregarEMPRESAS(ByVal NUMERO_PATRONAL As String, ByVal NIT_EMPRESA As String, ByVal CIUU As String, ByVal SECTOR_PRODUCTIVO As String, ByVal CODIGO_ASESOR As String, ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_REGION As String, ByVal NOMBRE_EMPRESA As String, ByVal TIPO_EMPRESA As String, ByVal CONTACTO_EMPRESA As String, ByVal TELEFONO_CONTACTO As String, ByVal CARGO_CONTACTO As String, ByVal DIRECCION_EMPRESA As String, ByVal TELEFONO_EMPRESA As String, ByVal FAX_EMPRESA As String, ByVal EMAIL_EMPRESA As String, ByVal ESPECIALIDAD_EMPRESA As String, ByVal TOTAL_PERSONA As Decimal, ByVal TOTAL_PLANILLA As Decimal, ByVal REPRESENTANTE_LEGAL As String, ByVal FECHA_REGISTRO As DateTime, ByVal TOTAL_TRABAJADORES As Decimal, ByVal FEMENINOS As Decimal, ByVal MASCULINOS As Decimal, ByVal TAMANO_EMPRESA As String, ByVal CON_MANDO As Decimal, ByVal SIN_MANDO As Decimal, ByVal ADMINISTRATIVOS As Decimal, ByVal MANDOS_MEDIOS As Decimal, ByVal OPERATIVOS As Decimal, ByVal GERENCIAL As Decimal, ByVal SIGLAS As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal OBSERVACION As String, ByVal NUM_PAT_ISSS As String, ByVal TIPOPERSON As String, ByVal NUM As Decimal, ByVal REPRESENTANTE_PROFESION As String, ByVal CONTACTO_EMAIL As String, ByVal APORTE_INSAFORP As Decimal, ByVal ZONA As Decimal) As Integer
        Try
            Dim lEntidad As New EMPRESAS
            lEntidad.NUMERO_PATRONAL = NUMERO_PATRONAL
            lEntidad.NIT_EMPRESA = NIT_EMPRESA
            lEntidad.CIUU = CIUU
            lEntidad.SECTOR_PRODUCTIVO = SECTOR_PRODUCTIVO
            lEntidad.CODIGO_ASESOR = CODIGO_ASESOR
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_REGION = CODIGO_REGION
            lEntidad.NOMBRE_EMPRESA = NOMBRE_EMPRESA
            lEntidad.TIPO_EMPRESA = TIPO_EMPRESA
            lEntidad.CONTACTO_EMPRESA = CONTACTO_EMPRESA
            lEntidad.TELEFONO_CONTACTO = TELEFONO_CONTACTO
            lEntidad.CARGO_CONTACTO = CARGO_CONTACTO
            lEntidad.DIRECCION_EMPRESA = DIRECCION_EMPRESA
            lEntidad.TELEFONO_EMPRESA = TELEFONO_EMPRESA
            lEntidad.FAX_EMPRESA = FAX_EMPRESA
            lEntidad.EMAIL_EMPRESA = EMAIL_EMPRESA
            lEntidad.ESPECIALIDAD_EMPRESA = ESPECIALIDAD_EMPRESA
            lEntidad.TOTAL_PERSONA = TOTAL_PERSONA
            lEntidad.TOTAL_PLANILLA = TOTAL_PLANILLA
            lEntidad.REPRESENTANTE_LEGAL = REPRESENTANTE_LEGAL
            lEntidad.FECHA_REGISTRO = FECHA_REGISTRO
            lEntidad.TOTAL_TRABAJADORES = TOTAL_TRABAJADORES
            lEntidad.FEMENINOS = FEMENINOS
            lEntidad.MASCULINOS = MASCULINOS
            lEntidad.TAMANO_EMPRESA = TAMANO_EMPRESA
            lEntidad.CON_MANDO = CON_MANDO
            lEntidad.SIN_MANDO = SIN_MANDO
            lEntidad.ADMINISTRATIVOS = ADMINISTRATIVOS
            lEntidad.MANDOS_MEDIOS = MANDOS_MEDIOS
            lEntidad.OPERATIVOS = OPERATIVOS
            lEntidad.GERENCIAL = GERENCIAL
            lEntidad.SIGLAS = SIGLAS
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.OBSERVACION = OBSERVACION
            lEntidad.NUM_PAT_ISSS = NUM_PAT_ISSS
            lEntidad.TIPOPERSON = TIPOPERSON
            lEntidad.NUM = NUM
            lEntidad.REPRESENTANTE_PROFESION = REPRESENTANTE_PROFESION
            lEntidad.CONTACTO_EMAIL = CONTACTO_EMAIL
            lEntidad.APORTE_INSAFORP = APORTE_INSAFORP
            lEntidad.ZONA = ZONA
            Return Me.AgregarEMPRESAS(lEntidad)
        Catch ex as Exception
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
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarEMPRESAS(ByVal aEntidad As EMPRESAS) As Integer
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
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarEMPRESAS(ByVal aEntidad As EMPRESAS) As Integer
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
    Public Function ActualizarEMPRESAS(ByVal aEntidad As EMPRESAS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarEMPRESAS(ByVal NUMERO_PATRONAL As String, ByVal NIT_EMPRESA As String, ByVal CIUU As String, ByVal SECTOR_PRODUCTIVO As String, ByVal CODIGO_ASESOR As String, ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_REGION As String, ByVal NOMBRE_EMPRESA As String, ByVal TIPO_EMPRESA As String, ByVal CONTACTO_EMPRESA As String, ByVal TELEFONO_CONTACTO As String, ByVal CARGO_CONTACTO As String, ByVal DIRECCION_EMPRESA As String, ByVal TELEFONO_EMPRESA As String, ByVal FAX_EMPRESA As String, ByVal EMAIL_EMPRESA As String, ByVal ESPECIALIDAD_EMPRESA As String, ByVal TOTAL_PERSONA As Decimal, ByVal TOTAL_PLANILLA As Decimal, ByVal REPRESENTANTE_LEGAL As String, ByVal FECHA_REGISTRO As DateTime, ByVal TOTAL_TRABAJADORES As Decimal, ByVal FEMENINOS As Decimal, ByVal MASCULINOS As Decimal, ByVal TAMANO_EMPRESA As String, ByVal CON_MANDO As Decimal, ByVal SIN_MANDO As Decimal, ByVal ADMINISTRATIVOS As Decimal, ByVal MANDOS_MEDIOS As Decimal, ByVal OPERATIVOS As Decimal, ByVal GERENCIAL As Decimal, ByVal SIGLAS As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal OBSERVACION As String, ByVal NUM_PAT_ISSS As String, ByVal TIPOPERSON As String, ByVal NUM As Decimal, ByVal REPRESENTANTE_PROFESION As String, ByVal CONTACTO_EMAIL As String, ByVal APORTE_INSAFORP As Decimal, ByVal ZONA As Decimal) As Integer
        Try
            Dim lEntidad As New EMPRESAS
            lEntidad.NUMERO_PATRONAL = NUMERO_PATRONAL
            lEntidad.NIT_EMPRESA = NIT_EMPRESA
            lEntidad.CIUU = CIUU
            lEntidad.SECTOR_PRODUCTIVO = SECTOR_PRODUCTIVO
            lEntidad.CODIGO_ASESOR = CODIGO_ASESOR
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_REGION = CODIGO_REGION
            lEntidad.NOMBRE_EMPRESA = NOMBRE_EMPRESA
            lEntidad.TIPO_EMPRESA = TIPO_EMPRESA
            lEntidad.CONTACTO_EMPRESA = CONTACTO_EMPRESA
            lEntidad.TELEFONO_CONTACTO = TELEFONO_CONTACTO
            lEntidad.CARGO_CONTACTO = CARGO_CONTACTO
            lEntidad.DIRECCION_EMPRESA = DIRECCION_EMPRESA
            lEntidad.TELEFONO_EMPRESA = TELEFONO_EMPRESA
            lEntidad.FAX_EMPRESA = FAX_EMPRESA
            lEntidad.EMAIL_EMPRESA = EMAIL_EMPRESA
            lEntidad.ESPECIALIDAD_EMPRESA = ESPECIALIDAD_EMPRESA
            lEntidad.TOTAL_PERSONA = TOTAL_PERSONA
            lEntidad.TOTAL_PLANILLA = TOTAL_PLANILLA
            lEntidad.REPRESENTANTE_LEGAL = REPRESENTANTE_LEGAL
            lEntidad.FECHA_REGISTRO = FECHA_REGISTRO
            lEntidad.TOTAL_TRABAJADORES = TOTAL_TRABAJADORES
            lEntidad.FEMENINOS = FEMENINOS
            lEntidad.MASCULINOS = MASCULINOS
            lEntidad.TAMANO_EMPRESA = TAMANO_EMPRESA
            lEntidad.CON_MANDO = CON_MANDO
            lEntidad.SIN_MANDO = SIN_MANDO
            lEntidad.ADMINISTRATIVOS = ADMINISTRATIVOS
            lEntidad.MANDOS_MEDIOS = MANDOS_MEDIOS
            lEntidad.OPERATIVOS = OPERATIVOS
            lEntidad.GERENCIAL = GERENCIAL
            lEntidad.SIGLAS = SIGLAS
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.OBSERVACION = OBSERVACION
            lEntidad.NUM_PAT_ISSS = NUM_PAT_ISSS
            lEntidad.TIPOPERSON = TIPOPERSON
            lEntidad.NUM = NUM
            lEntidad.REPRESENTANTE_PROFESION = REPRESENTANTE_PROFESION
            lEntidad.CONTACTO_EMAIL = CONTACTO_EMAIL
            lEntidad.APORTE_INSAFORP = APORTE_INSAFORP
            lEntidad.ZONA = ZONA
            Return Me.ActualizarEMPRESAS(lEntidad)
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
    Private Sub RecuperarForaneas(ByRef aEntidad As EMPRESAS )
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
    Private Sub RecuperarHijas(ByRef aEntidad As EMPRESAS )
    End Sub

#End Region

End Class
