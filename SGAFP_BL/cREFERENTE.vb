''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cREFERENTE
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla REFERENTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	05/10/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cREFERENTE
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbREFERENTE()
    Private mEntidad as New REFERENTE
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaREFERENTE
        Try
            Dim mListaREFERENTE As New ListaREFERENTE
            mListaREFERENTE = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaREFERENTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As REFERENTE in  mListaREFERENTE
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaREFERENTE
            If Not mListaREFERENTE Is Nothing Then
                For Each lEntidad As REFERENTE in  mListaREFERENTE
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaREFERENTE
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerREFERENTE(ByRef aEntidad As REFERENTE, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla REFERENTE.
    ''' </summary>
    ''' <param name="ID_REFERENTE"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerREFERENTE(ByVal ID_REFERENTE As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As REFERENTE
        Try
            Dim lEntidad As New REFERENTE
            lEntidad.ID_REFERENTE = ID_REFERENTE
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
    ''' <param name="aDEPARTAMENTO">Recuperar registro foraneo de la Entidad DEPARTAMENTO.</param>
    ''' <param name="aMUNICIPIO">Recuperar registro foraneo de la Entidad MUNICIPIO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerREFERENTEConForaneas(ByVal aEntidad As REFERENTE, Optional ByVal aDEPARTAMENTO As Boolean = False, Optional ByVal aMUNICIPIO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aDEPARTAMENTO, aMUNICIPIO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla REFERENTE que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_REFERENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarREFERENTE(ByVal ID_REFERENTE As Decimal) As Integer
        Try
            mEntidad.ID_REFERENTE = ID_REFERENTE
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla REFERENTE que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarREFERENTE(ByVal aEntidad As REFERENTE, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarREFERENTE(ByVal ID_REFERENTE As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal NOMBRE_REFERENTE As String, ByVal DIRECCION_REFERENTE As String, ByVal TELEF1 As String, ByVal TELEF2 As String, ByVal TELEF3 As String, ByVal TELEF_MOVIL As String, ByVal FAX As String, ByVal NOMBRE_CONTACTO As String, ByVal APELLIDOS_CONTACTO As String, ByVal EMAIL_CONTACTO As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime) As Integer
        Try
            Dim lEntidad As New REFERENTE
            lEntidad.ID_REFERENTE = ID_REFERENTE
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.NOMBRE_REFERENTE = NOMBRE_REFERENTE
            lEntidad.DIRECCION_REFERENTE = DIRECCION_REFERENTE
            lEntidad.TELEF1 = TELEF1
            lEntidad.TELEF2 = TELEF2
            lEntidad.TELEF3 = TELEF3
            lEntidad.TELEF_MOVIL = TELEF_MOVIL
            lEntidad.FAX = FAX
            lEntidad.NOMBRE_CONTACTO = NOMBRE_CONTACTO
            lEntidad.APELLIDOS_CONTACTO = APELLIDOS_CONTACTO
            lEntidad.EMAIL_CONTACTO = EMAIL_CONTACTO
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            Return Me.ActualizarREFERENTE(lEntidad)
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarREFERENTE(ByVal ID_REFERENTE As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal NOMBRE_REFERENTE As String, ByVal DIRECCION_REFERENTE As String, ByVal TELEF1 As String, ByVal TELEF2 As String, ByVal TELEF3 As String, ByVal TELEF_MOVIL As String, ByVal FAX As String, ByVal NOMBRE_CONTACTO As String, ByVal APELLIDOS_CONTACTO As String, ByVal EMAIL_CONTACTO As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime) As Integer
        Try
            Dim lEntidad As New REFERENTE
            lEntidad.ID_REFERENTE = ID_REFERENTE
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.NOMBRE_REFERENTE = NOMBRE_REFERENTE
            lEntidad.DIRECCION_REFERENTE = DIRECCION_REFERENTE
            lEntidad.TELEF1 = TELEF1
            lEntidad.TELEF2 = TELEF2
            lEntidad.TELEF3 = TELEF3
            lEntidad.TELEF_MOVIL = TELEF_MOVIL
            lEntidad.FAX = FAX
            lEntidad.NOMBRE_CONTACTO = NOMBRE_CONTACTO
            lEntidad.APELLIDOS_CONTACTO = APELLIDOS_CONTACTO
            lEntidad.EMAIL_CONTACTO = EMAIL_CONTACTO
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            Return Me.ActualizarREFERENTE(lEntidad)
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
    ''' 	[GenApp]	05/10/2012	Created
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
    ''' 	[GenApp]	05/10/2012	Created
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
    ''' la Tabla DEPARTAMENTO .
    ''' </summary>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaREFERENTE
        Try
            Dim mListaREFERENTE As New ListaREFERENTE
            mListaREFERENTE = mDb.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO, asColumnaOrden, asTipoOrden)
            If Not mListaREFERENTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As REFERENTE in  mListaREFERENTE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaREFERENTE
            If Not mListaREFERENTE Is Nothing Then
                For Each lEntidad As REFERENTE in  mListaREFERENTE
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaREFERENTE
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaREFERENTE
        Try
            Dim mListaREFERENTE As New ListaREFERENTE
            mListaREFERENTE = mDb.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, asColumnaOrden, asTipoOrden)
            If Not mListaREFERENTE Is Nothing And recuperarForaneas Then
                For Each lEntidad As REFERENTE in  mListaREFERENTE
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaREFERENTE
            If Not mListaREFERENTE Is Nothing Then
                For Each lEntidad As REFERENTE in  mListaREFERENTE
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaREFERENTE
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As REFERENTE )
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
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As REFERENTE )
    End Sub

#End Region

End Class
