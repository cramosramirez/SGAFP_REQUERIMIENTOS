''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cINFORME_PRESELECCION_EC
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla INFORME_PRESELECCION_EC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	22/08/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cINFORME_PRESELECCION_EC
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbINFORME_PRESELECCION_EC()
    Private mEntidad as New INFORME_PRESELECCION_EC
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaINFORME_PRESELECCION_EC
        Try
            Dim mListaINFORME_PRESELECCION_EC As New ListaINFORME_PRESELECCION_EC
            mListaINFORME_PRESELECCION_EC = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaINFORME_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As INFORME_PRESELECCION_EC in  mListaINFORME_PRESELECCION_EC
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaINFORME_PRESELECCION_EC
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
    ''' 	[GenApp]	22/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerINFORME_PRESELECCION_EC(ByRef aEntidad As INFORME_PRESELECCION_EC, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla INFORME_PRESELECCION_EC.
    ''' </summary>
    ''' <param name="ID_INFORME_PRESE"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerINFORME_PRESELECCION_EC(ByVal ID_INFORME_PRESE As Decimal, ByVal Optional recuperarForaneas As Boolean = False) As INFORME_PRESELECCION_EC
        Try
            Dim lEntidad As New INFORME_PRESELECCION_EC
            lEntidad.ID_INFORME_PRESE = ID_INFORME_PRESE
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
    ''' <param name="aGRUPO_SELECCION">Recuperar registro foraneo de la Entidad GRUPO_SELECCION.</param>
    ''' <param name="aCONTRATO_BOLPROS">Recuperar registro foraneo de la Entidad CONTRATO_BOLPROS.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	22/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerINFORME_PRESELECCION_ECConForaneas(ByVal aEntidad As INFORME_PRESELECCION_EC, Optional ByVal aGRUPO_SELECCION As Boolean = False, Optional ByVal aCONTRATO_BOLPROS As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aGRUPO_SELECCION, aCONTRATO_BOLPROS)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla INFORME_PRESELECCION_EC que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_INFORME_PRESE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarINFORME_PRESELECCION_EC(ByVal ID_INFORME_PRESE As Decimal) As Integer
        Try
            mEntidad.ID_INFORME_PRESE = ID_INFORME_PRESE
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla INFORME_PRESELECCION_EC que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarINFORME_PRESELECCION_EC(ByVal aEntidad As INFORME_PRESELECCION_EC, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	22/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarINFORME_PRESELECCION_EC(ByVal ID_INFORME_PRESE As Decimal, ByVal ID_GRUPO_SELEC As Decimal, ByVal ID_CONTRATO As Decimal, ByVal FECHA_REPORTE As DateTime, ByVal FECHA_INICIO As DateTime, ByVal FECHA_FINALIZACION As DateTime, ByVal ELABORADO_POR As String, ByVal PARTI_EVALUADOS As Decimal, ByVal COSTO_X_PARTICIPANTE As Decimal, ByVal COSTO_X_HORA As Decimal, ByVal COSTO_X_VISITA As Decimal, ByVal TOTAL_PAGAR As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New INFORME_PRESELECCION_EC
            lEntidad.ID_INFORME_PRESE = ID_INFORME_PRESE
            lEntidad.ID_GRUPO_SELEC = ID_GRUPO_SELEC
            lEntidad.ID_CONTRATO = ID_CONTRATO
            lEntidad.FECHA_REPORTE = FECHA_REPORTE
            lEntidad.FECHA_INICIO = FECHA_INICIO
            lEntidad.FECHA_FINALIZACION = FECHA_FINALIZACION
            lEntidad.ELABORADO_POR = ELABORADO_POR
            lEntidad.PARTI_EVALUADOS = PARTI_EVALUADOS
            lEntidad.COSTO_X_PARTICIPANTE = COSTO_X_PARTICIPANTE
            lEntidad.COSTO_X_HORA = COSTO_X_HORA
            lEntidad.COSTO_X_VISITA = COSTO_X_VISITA
            lEntidad.TOTAL_PAGAR = TOTAL_PAGAR
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarINFORME_PRESELECCION_EC(lEntidad)
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
    ''' 	[GenApp]	22/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarINFORME_PRESELECCION_EC(ByVal aEntidad As INFORME_PRESELECCION_EC) As Integer
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
    ''' 	[GenApp]	22/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarINFORME_PRESELECCION_EC(ByVal aEntidad As INFORME_PRESELECCION_EC, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	22/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarINFORME_PRESELECCION_EC(ByVal ID_INFORME_PRESE As Decimal, ByVal ID_GRUPO_SELEC As Decimal, ByVal ID_CONTRATO As Decimal, ByVal FECHA_REPORTE As DateTime, ByVal FECHA_INICIO As DateTime, ByVal FECHA_FINALIZACION As DateTime, ByVal ELABORADO_POR As String, ByVal PARTI_EVALUADOS As Decimal, ByVal COSTO_X_PARTICIPANTE As Decimal, ByVal COSTO_X_HORA As Decimal, ByVal COSTO_X_VISITA As Decimal, ByVal TOTAL_PAGAR As Decimal, ByVal USUARIO_CREA As String, ByVal FECHA_CREA As DateTime, ByVal USUARIO_ACT As String, ByVal FECHA_ACT As DateTime) As Integer
        Try
            Dim lEntidad As New INFORME_PRESELECCION_EC
            lEntidad.ID_INFORME_PRESE = ID_INFORME_PRESE
            lEntidad.ID_GRUPO_SELEC = ID_GRUPO_SELEC
            lEntidad.ID_CONTRATO = ID_CONTRATO
            lEntidad.FECHA_REPORTE = FECHA_REPORTE
            lEntidad.FECHA_INICIO = FECHA_INICIO
            lEntidad.FECHA_FINALIZACION = FECHA_FINALIZACION
            lEntidad.ELABORADO_POR = ELABORADO_POR
            lEntidad.PARTI_EVALUADOS = PARTI_EVALUADOS
            lEntidad.COSTO_X_PARTICIPANTE = COSTO_X_PARTICIPANTE
            lEntidad.COSTO_X_HORA = COSTO_X_HORA
            lEntidad.COSTO_X_VISITA = COSTO_X_VISITA
            lEntidad.TOTAL_PAGAR = TOTAL_PAGAR
            lEntidad.USUARIO_CREA = USUARIO_CREA
            lEntidad.FECHA_CREA = FECHA_CREA
            lEntidad.USUARIO_ACT = USUARIO_ACT
            lEntidad.FECHA_ACT = FECHA_ACT
            Return Me.ActualizarINFORME_PRESELECCION_EC(lEntidad)
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
    ''' 	[GenApp]	22/08/2019	Created
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
    ''' 	[GenApp]	22/08/2019	Created
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
    ''' la Tabla GRUPO_SELECCION .
    ''' </summary>
    ''' <param name="ID_GRUPO_SELEC"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	22/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorGRUPO_SELECCION(ByVal ID_GRUPO_SELEC As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaINFORME_PRESELECCION_EC
        Try
            Dim mListaINFORME_PRESELECCION_EC As New ListaINFORME_PRESELECCION_EC
            mListaINFORME_PRESELECCION_EC = mDb.ObtenerListaPorGRUPO_SELECCION(ID_GRUPO_SELEC, asColumnaOrden, asTipoOrden)
            If Not mListaINFORME_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As INFORME_PRESELECCION_EC in  mListaINFORME_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaINFORME_PRESELECCION_EC
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
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
    ''' 	[GenApp]	22/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCONTRATO_BOLPROS(ByVal ID_CONTRATO As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaINFORME_PRESELECCION_EC
        Try
            Dim mListaINFORME_PRESELECCION_EC As New ListaINFORME_PRESELECCION_EC
            mListaINFORME_PRESELECCION_EC = mDb.ObtenerListaPorCONTRATO_BOLPROS(ID_CONTRATO, asColumnaOrden, asTipoOrden)
            If Not mListaINFORME_PRESELECCION_EC Is Nothing And recuperarForaneas Then
                For Each lEntidad As INFORME_PRESELECCION_EC in  mListaINFORME_PRESELECCION_EC
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaINFORME_PRESELECCION_EC
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
    ''' 	[GenApp]	22/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As INFORME_PRESELECCION_EC )
        aEntidad.fkID_GRUPO_SELEC = (New cGRUPO_SELECCION).ObtenerGRUPO_SELECCION(aEntidad.ID_GRUPO_SELEC)
        aEntidad.fkID_CONTRATO = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(aEntidad.ID_CONTRATO)
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
    ''' 	[GenApp]	22/08/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As INFORME_PRESELECCION_EC )
    End Sub

#End Region

End Class
