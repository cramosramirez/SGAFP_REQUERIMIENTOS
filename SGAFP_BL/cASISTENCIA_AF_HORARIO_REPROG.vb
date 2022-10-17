''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cASISTENCIA_AF_HORARIO_REPROG
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla ASISTENCIA_AF_HORARIO_REPROG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	04/03/2011	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cASISTENCIA_AF_HORARIO_REPROG
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbASISTENCIA_AF_HORARIO_REPROG()
    Private mEntidad as New ASISTENCIA_AF_HORARIO_REPROG
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal ID_ASISTENCIA_AF As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaASISTENCIA_AF_HORARIO_REPROG
        Try
            Dim mListaASISTENCIA_AF_HORARIO_REPROG As New ListaASISTENCIA_AF_HORARIO_REPROG
            mListaASISTENCIA_AF_HORARIO_REPROG = mDb.ObtenerListaPorID(ID_ASISTENCIA_AF, asColumnaOrden, asTipoOrden)
            If Not mListaASISTENCIA_AF_HORARIO_REPROG Is Nothing And recuperarForaneas Then
                For Each lEntidad As ASISTENCIA_AF_HORARIO_REPROG in  mListaASISTENCIA_AF_HORARIO_REPROG
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaASISTENCIA_AF_HORARIO_REPROG
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
    ''' 	[GenApp]	04/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerASISTENCIA_AF_HORARIO_REPROG(ByRef aEntidad As ASISTENCIA_AF_HORARIO_REPROG, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla ASISTENCIA_AF_HORARIO_REPROG.
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF"></param>
    ''' <param name="ID_ASISTENCIA_AF_HORARIO"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerASISTENCIA_AF_HORARIO_REPROG(ByVal ID_ASISTENCIA_AF As Decimal, ByVal ID_ASISTENCIA_AF_HORARIO As Decimal, ByVal Optional recuperarForaneas As Boolean = False) As ASISTENCIA_AF_HORARIO_REPROG
        Try
            Dim lEntidad As New ASISTENCIA_AF_HORARIO_REPROG
            lEntidad.ID_ASISTENCIA_AF = ID_ASISTENCIA_AF
            lEntidad.ID_ASISTENCIA_AF_HORARIO = ID_ASISTENCIA_AF_HORARIO
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
    ''' <param name="aASISTENCIA_AF_REPROG">Recuperar registro foraneo de la Entidad ASISTENCIA_AF_REPROG.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	04/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerASISTENCIA_AF_HORARIO_REPROGConForaneas(ByVal aEntidad As ASISTENCIA_AF_HORARIO_REPROG, Optional ByVal aASISTENCIA_AF_REPROG As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aASISTENCIA_AF_REPROG)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ASISTENCIA_AF_HORARIO_REPROG que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF"></param>
    ''' <param name="ID_ASISTENCIA_AF_HORARIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarASISTENCIA_AF_HORARIO_REPROG(ByVal ID_ASISTENCIA_AF As Decimal, ByVal ID_ASISTENCIA_AF_HORARIO As Decimal) As Integer
        Try
            mEntidad.ID_ASISTENCIA_AF = ID_ASISTENCIA_AF
            mEntidad.ID_ASISTENCIA_AF_HORARIO = ID_ASISTENCIA_AF_HORARIO
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla ASISTENCIA_AF_HORARIO_REPROG que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarASISTENCIA_AF_HORARIO_REPROG(ByVal aEntidad As ASISTENCIA_AF_HORARIO_REPROG, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	04/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarASISTENCIA_AF_HORARIO_REPROG(ByVal ID_ASISTENCIA_AF As Decimal, ByVal ID_ASISTENCIA_AF_HORARIO As Decimal, ByVal HORA_INICIO As DateTime, ByVal HORA_FIN As DateTime, ByVal CANTIDAD_MINUTOS As Decimal) As Integer
        Try
            Dim lEntidad As New ASISTENCIA_AF_HORARIO_REPROG
            lEntidad.ID_ASISTENCIA_AF = ID_ASISTENCIA_AF
            lEntidad.ID_ASISTENCIA_AF_HORARIO = ID_ASISTENCIA_AF_HORARIO
            lEntidad.HORA_INICIO = HORA_INICIO
            lEntidad.HORA_FIN = HORA_FIN
            lEntidad.CANTIDAD_MINUTOS = CANTIDAD_MINUTOS
            Return Me.ActualizarASISTENCIA_AF_HORARIO_REPROG(lEntidad)
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
    ''' 	[GenApp]	04/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarASISTENCIA_AF_HORARIO_REPROG(ByVal aEntidad As ASISTENCIA_AF_HORARIO_REPROG) As Integer
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
    ''' 	[GenApp]	04/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarASISTENCIA_AF_HORARIO_REPROG(ByVal aEntidad As ASISTENCIA_AF_HORARIO_REPROG, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	04/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarASISTENCIA_AF_HORARIO_REPROG(ByVal ID_ASISTENCIA_AF As Decimal, ByVal ID_ASISTENCIA_AF_HORARIO As Decimal, ByVal HORA_INICIO As DateTime, ByVal HORA_FIN As DateTime, ByVal CANTIDAD_MINUTOS As Decimal) As Integer
        Try
            Dim lEntidad As New ASISTENCIA_AF_HORARIO_REPROG
            lEntidad.ID_ASISTENCIA_AF = ID_ASISTENCIA_AF
            lEntidad.ID_ASISTENCIA_AF_HORARIO = ID_ASISTENCIA_AF_HORARIO
            lEntidad.HORA_INICIO = HORA_INICIO
            lEntidad.HORA_FIN = HORA_FIN
            lEntidad.CANTIDAD_MINUTOS = CANTIDAD_MINUTOS
            Return Me.ActualizarASISTENCIA_AF_HORARIO_REPROG(lEntidad)
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
    ''' <param name="ID_ASISTENCIA_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorId(ByVal ID_ASISTENCIA_AF As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorID(ID_ASISTENCIA_AF, asColumnaOrden, asTipoOrden)
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
    ''' <param name="ID_ASISTENCIA_AF"></param>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, False)> _
    Public Function ObtenerDataSetPorId(ByVal ID_ASISTENCIA_AF As Decimal, ByRef ds As DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer
        Try
            Return mDb.ObtenerDataSetPorID(ID_ASISTENCIA_AF, ds, asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ASISTENCIA_AF_REPROG .
    ''' </summary>
    ''' <param name="ID_ASISTENCIA_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	04/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorASISTENCIA_AF_REPROG(ByVal ID_ASISTENCIA_AF As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaASISTENCIA_AF_HORARIO_REPROG
        Try
            Dim mListaASISTENCIA_AF_HORARIO_REPROG As New ListaASISTENCIA_AF_HORARIO_REPROG
            mListaASISTENCIA_AF_HORARIO_REPROG = mDb.ObtenerListaPorASISTENCIA_AF_REPROG(ID_ASISTENCIA_AF, asColumnaOrden, asTipoOrden)
            If Not mListaASISTENCIA_AF_HORARIO_REPROG Is Nothing And recuperarForaneas Then
                For Each lEntidad As ASISTENCIA_AF_HORARIO_REPROG in  mListaASISTENCIA_AF_HORARIO_REPROG
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaASISTENCIA_AF_HORARIO_REPROG
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
    ''' 	[GenApp]	04/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As ASISTENCIA_AF_HORARIO_REPROG )
        aEntidad.fkID_ASISTENCIA_AF = (New cASISTENCIA_AF_REPROG).ObtenerASISTENCIA_AF_REPROG(aEntidad.ID_ASISTENCIA_AF)
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
    ''' 	[GenApp]	04/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As ASISTENCIA_AF_HORARIO_REPROG )
    End Sub

#End Region

End Class
