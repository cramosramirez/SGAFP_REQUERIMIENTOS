''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cACCION_CONTRATADA
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla ACCION_CONTRATADA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	16/02/2022	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cACCION_CONTRATADA
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbACCION_CONTRATADA()
    Private mEntidad as New ACCION_CONTRATADA
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaACCION_CONTRATADA
        Try
            Dim mListaACCION_CONTRATADA As New ListaACCION_CONTRATADA
            mListaACCION_CONTRATADA = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaACCION_CONTRATADA Is Nothing And recuperarForaneas Then
                For Each lEntidad As ACCION_CONTRATADA in  mListaACCION_CONTRATADA
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaACCION_CONTRATADA
            If Not mListaACCION_CONTRATADA Is Nothing Then
                For Each lEntidad As ACCION_CONTRATADA in  mListaACCION_CONTRATADA
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaACCION_CONTRATADA
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
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerACCION_CONTRATADA(ByRef aEntidad As ACCION_CONTRATADA, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla ACCION_CONTRATADA.
    ''' </summary>
    ''' <param name="ID_ACCION_CONTRATADA"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerACCION_CONTRATADA(ByVal ID_ACCION_CONTRATADA As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As ACCION_CONTRATADA
        Try
            Dim lEntidad As New ACCION_CONTRATADA
            lEntidad.ID_ACCION_CONTRATADA = ID_ACCION_CONTRATADA
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
    ''' <param name="aCONTRATO_BOLPROS">Recuperar registro foraneo de la Entidad CONTRATO_BOLPROS.</param>
    ''' <param name="aDEPARTAMENTO">Recuperar registro foraneo de la Entidad DEPARTAMENTO.</param>
    ''' <param name="aMUNICIPIO">Recuperar registro foraneo de la Entidad MUNICIPIO.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerACCION_CONTRATADAConForaneas(ByVal aEntidad As ACCION_CONTRATADA, Optional ByVal aCONTRATO_BOLPROS As Boolean = False, Optional ByVal aDEPARTAMENTO As Boolean = False, Optional ByVal aMUNICIPIO As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aCONTRATO_BOLPROS, aDEPARTAMENTO, aMUNICIPIO)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ACCION_CONTRATADA que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ACCION_CONTRATADA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarACCION_CONTRATADA(ByVal ID_ACCION_CONTRATADA As Decimal) As Integer
        Try
            mEntidad.ID_ACCION_CONTRATADA = ID_ACCION_CONTRATADA
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ACCION_CONTRATADA que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarACCION_CONTRATADA(ByVal aEntidad As ACCION_CONTRATADA, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarACCION_CONTRATADA(ByVal ID_ACCION_CONTRATADA As Decimal, ByVal ID_CONTRATO As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_PROGRAMA As String, ByVal DURACION As Decimal, ByVal CANT_CURSOS As Decimal, ByVal USUARIO_CREACION As String, ByVal FECHA_CREACION As DateTime, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal NUM_ITEM As Decimal, ByVal MONTO As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal COSTO_PARTICIPANTE As Decimal, ByVal NOMBRE_ACCION_FORMATIVA As String, ByVal COSTO_HORA As Decimal, ByVal COSTO_VISITA As Decimal, ByVal CODIGO_CATEG As String, ByVal NOMBRE_CATEG As String) As Integer
        Try
            Dim lEntidad As New ACCION_CONTRATADA
            lEntidad.ID_ACCION_CONTRATADA = ID_ACCION_CONTRATADA
            lEntidad.ID_CONTRATO = ID_CONTRATO
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.CODIGO_PROGRAMA = CODIGO_PROGRAMA
            lEntidad.DURACION = DURACION
            lEntidad.CANT_CURSOS = CANT_CURSOS
            lEntidad.USUARIO_CREACION = USUARIO_CREACION
            lEntidad.FECHA_CREACION = FECHA_CREACION
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.NUM_ITEM = NUM_ITEM
            lEntidad.MONTO = MONTO
            lEntidad.NO_CONVOCATORIA = NO_CONVOCATORIA
            lEntidad.COSTO_PARTICIPANTE = COSTO_PARTICIPANTE
            lEntidad.NOMBRE_ACCION_FORMATIVA = NOMBRE_ACCION_FORMATIVA
            lEntidad.COSTO_HORA = COSTO_HORA
            lEntidad.COSTO_VISITA = COSTO_VISITA
            lEntidad.CODIGO_CATEG = CODIGO_CATEG
            lEntidad.NOMBRE_CATEG = NOMBRE_CATEG
            Return Me.ActualizarACCION_CONTRATADA(lEntidad)
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
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarACCION_CONTRATADA(ByVal ID_ACCION_CONTRATADA As Decimal, ByVal ID_CONTRATO As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_PROGRAMA As String, ByVal DURACION As Decimal, ByVal CANT_CURSOS As Decimal, ByVal USUARIO_CREACION As String, ByVal FECHA_CREACION As DateTime, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal NUM_ITEM As Decimal, ByVal MONTO As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal COSTO_PARTICIPANTE As Decimal, ByVal NOMBRE_ACCION_FORMATIVA As String, ByVal COSTO_HORA As Decimal, ByVal COSTO_VISITA As Decimal, ByVal CODIGO_CATEG As String, ByVal NOMBRE_CATEG As String) As Integer
        Try
            Dim lEntidad As New ACCION_CONTRATADA
            lEntidad.ID_ACCION_CONTRATADA = ID_ACCION_CONTRATADA
            lEntidad.ID_CONTRATO = ID_CONTRATO
            lEntidad.CODIGO_DEPARTAMENTO = CODIGO_DEPARTAMENTO
            lEntidad.CODIGO_MUNICIPIO = CODIGO_MUNICIPIO
            lEntidad.CODIGO_PROGRAMA = CODIGO_PROGRAMA
            lEntidad.DURACION = DURACION
            lEntidad.CANT_CURSOS = CANT_CURSOS
            lEntidad.USUARIO_CREACION = USUARIO_CREACION
            lEntidad.FECHA_CREACION = FECHA_CREACION
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.NUM_ITEM = NUM_ITEM
            lEntidad.MONTO = MONTO
            lEntidad.NO_CONVOCATORIA = NO_CONVOCATORIA
            lEntidad.COSTO_PARTICIPANTE = COSTO_PARTICIPANTE
            lEntidad.NOMBRE_ACCION_FORMATIVA = NOMBRE_ACCION_FORMATIVA
            lEntidad.COSTO_HORA = COSTO_HORA
            lEntidad.COSTO_VISITA = COSTO_VISITA
            lEntidad.CODIGO_CATEG = CODIGO_CATEG
            lEntidad.NOMBRE_CATEG = NOMBRE_CATEG
            Return Me.ActualizarACCION_CONTRATADA(lEntidad)
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
    ''' 	[GenApp]	16/02/2022	Created
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
    ''' 	[GenApp]	16/02/2022	Created
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
    ''' la Tabla CONTRATO_BOLPROS .
    ''' </summary>
    ''' <param name="ID_CONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCONTRATO_BOLPROS(ByVal ID_CONTRATO As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaACCION_CONTRATADA
        Try
            Dim mListaACCION_CONTRATADA As New ListaACCION_CONTRATADA
            mListaACCION_CONTRATADA = mDb.ObtenerListaPorCONTRATO_BOLPROS(ID_CONTRATO, asColumnaOrden, asTipoOrden)
            If Not mListaACCION_CONTRATADA Is Nothing And recuperarForaneas Then
                For Each lEntidad As ACCION_CONTRATADA in  mListaACCION_CONTRATADA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaACCION_CONTRATADA
            If Not mListaACCION_CONTRATADA Is Nothing Then
                For Each lEntidad As ACCION_CONTRATADA in  mListaACCION_CONTRATADA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaACCION_CONTRATADA
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
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorDEPARTAMENTO(ByVal CODIGO_DEPARTAMENTO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaACCION_CONTRATADA
        Try
            Dim mListaACCION_CONTRATADA As New ListaACCION_CONTRATADA
            mListaACCION_CONTRATADA = mDb.ObtenerListaPorDEPARTAMENTO(CODIGO_DEPARTAMENTO, asColumnaOrden, asTipoOrden)
            If Not mListaACCION_CONTRATADA Is Nothing And recuperarForaneas Then
                For Each lEntidad As ACCION_CONTRATADA in  mListaACCION_CONTRATADA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaACCION_CONTRATADA
            If Not mListaACCION_CONTRATADA Is Nothing Then
                For Each lEntidad As ACCION_CONTRATADA in  mListaACCION_CONTRATADA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaACCION_CONTRATADA
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
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMUNICIPIO(ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaACCION_CONTRATADA
        Try
            Dim mListaACCION_CONTRATADA As New ListaACCION_CONTRATADA
            mListaACCION_CONTRATADA = mDb.ObtenerListaPorMUNICIPIO(CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, asColumnaOrden, asTipoOrden)
            If Not mListaACCION_CONTRATADA Is Nothing And recuperarForaneas Then
                For Each lEntidad As ACCION_CONTRATADA in  mListaACCION_CONTRATADA
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaACCION_CONTRATADA
            If Not mListaACCION_CONTRATADA Is Nothing Then
                For Each lEntidad As ACCION_CONTRATADA in  mListaACCION_CONTRATADA
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaACCION_CONTRATADA
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
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As ACCION_CONTRATADA )
        aEntidad.fkID_CONTRATO = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(aEntidad.ID_CONTRATO)
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
    ''' 	[GenApp]	16/02/2022	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As ACCION_CONTRATADA )
    End Sub

#End Region

End Class
