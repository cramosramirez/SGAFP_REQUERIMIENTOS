''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cSIPU_CAPACITACIONES
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SIPU_CAPACITACIONES
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	29/10/2013	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSIPU_CAPACITACIONES
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSIPU_CAPACITACIONES()
    Private mEntidad as New SIPU_CAPACITACIONES
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSIPU_CAPACITACIONES
        Try
            Dim mListaSIPU_CAPACITACIONES As New ListaSIPU_CAPACITACIONES
            mListaSIPU_CAPACITACIONES = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSIPU_CAPACITACIONES Is Nothing And recuperarForaneas Then
                For Each lEntidad As SIPU_CAPACITACIONES in  mListaSIPU_CAPACITACIONES
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSIPU_CAPACITACIONES
            If Not mListaSIPU_CAPACITACIONES Is Nothing Then
                For Each lEntidad As SIPU_CAPACITACIONES in  mListaSIPU_CAPACITACIONES
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSIPU_CAPACITACIONES
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
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSIPU_CAPACITACIONES(ByRef aEntidad As SIPU_CAPACITACIONES, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SIPU_CAPACITACIONES.
    ''' </summary>
    ''' <param name="IDCAPACITACION"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSIPU_CAPACITACIONES(ByVal IDCAPACITACION As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As SIPU_CAPACITACIONES
        Try
            Dim lEntidad As New SIPU_CAPACITACIONES
            lEntidad.IDCAPACITACION = IDCAPACITACION
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
    ''' <param name="aSIPU_TIPOCAPACITACIONES">Recuperar registro foraneo de la Entidad SIPU_TIPOCAPACITACIONES.</param>
    ''' <param name="aSIPU_MUNICIPIO">Recuperar registro foraneo de la Entidad SIPU_MUNICIPIO.</param>
    ''' <param name="aSIPU_GENERACION">Recuperar registro foraneo de la Entidad SIPU_GENERACION.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSIPU_CAPACITACIONESConForaneas(ByVal aEntidad As SIPU_CAPACITACIONES, Optional ByVal aSIPU_TIPOCAPACITACIONES As Boolean = False, Optional ByVal aSIPU_MUNICIPIO As Boolean = False, Optional ByVal aSIPU_GENERACION As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aSIPU_TIPOCAPACITACIONES, aSIPU_MUNICIPIO, aSIPU_GENERACION)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SIPU_CAPACITACIONES que se le envía como parámetro.
    ''' </summary>
    ''' <param name="IDCAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSIPU_CAPACITACIONES(ByVal IDCAPACITACION As Decimal) As Integer
        Try
            mEntidad.IDCAPACITACION = IDCAPACITACION
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SIPU_CAPACITACIONES que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSIPU_CAPACITACIONES(ByVal aEntidad As SIPU_CAPACITACIONES, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSIPU_CAPACITACIONES(ByVal IDCAPACITACION As Decimal, ByVal DESCRIPCION As String, ByVal IDTIPOCAPACITACION As Decimal, ByVal IDESTADO As Decimal, ByVal FECHAINICIO As DateTime, ByVal FECHAFIN As DateTime, ByVal IDMUNICIPIO As Decimal, ByVal ID_GENERACION As Decimal) As Integer
        Try
            Dim lEntidad As New SIPU_CAPACITACIONES
            lEntidad.IDCAPACITACION = IDCAPACITACION
            lEntidad.DESCRIPCION = DESCRIPCION
            lEntidad.IDTIPOCAPACITACION = IDTIPOCAPACITACION
            lEntidad.IDESTADO = IDESTADO
            lEntidad.FECHAINICIO = FECHAINICIO
            lEntidad.FECHAFIN = FECHAFIN
            lEntidad.IDMUNICIPIO = IDMUNICIPIO
            lEntidad.ID_GENERACION = ID_GENERACION
            Return Me.ActualizarSIPU_CAPACITACIONES(lEntidad)
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
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSIPU_CAPACITACIONES(ByVal aEntidad As SIPU_CAPACITACIONES) As Integer
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
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSIPU_CAPACITACIONES(ByVal aEntidad As SIPU_CAPACITACIONES, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSIPU_CAPACITACIONES(ByVal IDCAPACITACION As Decimal, ByVal DESCRIPCION As String, ByVal IDTIPOCAPACITACION As Decimal, ByVal IDESTADO As Decimal, ByVal FECHAINICIO As DateTime, ByVal FECHAFIN As DateTime, ByVal IDMUNICIPIO As Decimal, ByVal ID_GENERACION As Decimal) As Integer
        Try
            Dim lEntidad As New SIPU_CAPACITACIONES
            lEntidad.IDCAPACITACION = IDCAPACITACION
            lEntidad.DESCRIPCION = DESCRIPCION
            lEntidad.IDTIPOCAPACITACION = IDTIPOCAPACITACION
            lEntidad.IDESTADO = IDESTADO
            lEntidad.FECHAINICIO = FECHAINICIO
            lEntidad.FECHAFIN = FECHAFIN
            lEntidad.IDMUNICIPIO = IDMUNICIPIO
            lEntidad.ID_GENERACION = ID_GENERACION
            Return Me.ActualizarSIPU_CAPACITACIONES(lEntidad)
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
    ''' 	[GenApp]	29/10/2013	Created
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
    ''' 	[GenApp]	29/10/2013	Created
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
    ''' la Tabla SIPU_TIPOCAPACITACIONES .
    ''' </summary>
    ''' <param name="IDTIPOCAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSIPU_TIPOCAPACITACIONES(ByVal IDTIPOCAPACITACION As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSIPU_CAPACITACIONES
        Try
            Dim mListaSIPU_CAPACITACIONES As New ListaSIPU_CAPACITACIONES
            mListaSIPU_CAPACITACIONES = mDb.ObtenerListaPorSIPU_TIPOCAPACITACIONES(IDTIPOCAPACITACION, asColumnaOrden, asTipoOrden)
            If Not mListaSIPU_CAPACITACIONES Is Nothing And recuperarForaneas Then
                For Each lEntidad As SIPU_CAPACITACIONES in  mListaSIPU_CAPACITACIONES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSIPU_CAPACITACIONES
            If Not mListaSIPU_CAPACITACIONES Is Nothing Then
                For Each lEntidad As SIPU_CAPACITACIONES in  mListaSIPU_CAPACITACIONES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSIPU_CAPACITACIONES
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SIPU_MUNICIPIO .
    ''' </summary>
    ''' <param name="IDMUNICIPIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSIPU_MUNICIPIO(ByVal IDMUNICIPIO As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSIPU_CAPACITACIONES
        Try
            Dim mListaSIPU_CAPACITACIONES As New ListaSIPU_CAPACITACIONES
            mListaSIPU_CAPACITACIONES = mDb.ObtenerListaPorSIPU_MUNICIPIO(IDMUNICIPIO, asColumnaOrden, asTipoOrden)
            If Not mListaSIPU_CAPACITACIONES Is Nothing And recuperarForaneas Then
                For Each lEntidad As SIPU_CAPACITACIONES in  mListaSIPU_CAPACITACIONES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSIPU_CAPACITACIONES
            If Not mListaSIPU_CAPACITACIONES Is Nothing Then
                For Each lEntidad As SIPU_CAPACITACIONES in  mListaSIPU_CAPACITACIONES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSIPU_CAPACITACIONES
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SIPU_GENERACION .
    ''' </summary>
    ''' <param name="ID_GENERACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSIPU_GENERACION(ByVal ID_GENERACION As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSIPU_CAPACITACIONES
        Try
            Dim mListaSIPU_CAPACITACIONES As New ListaSIPU_CAPACITACIONES
            mListaSIPU_CAPACITACIONES = mDb.ObtenerListaPorSIPU_GENERACION(ID_GENERACION, asColumnaOrden, asTipoOrden)
            If Not mListaSIPU_CAPACITACIONES Is Nothing And recuperarForaneas Then
                For Each lEntidad As SIPU_CAPACITACIONES in  mListaSIPU_CAPACITACIONES
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSIPU_CAPACITACIONES
            If Not mListaSIPU_CAPACITACIONES Is Nothing Then
                For Each lEntidad As SIPU_CAPACITACIONES in  mListaSIPU_CAPACITACIONES
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSIPU_CAPACITACIONES
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
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SIPU_CAPACITACIONES )
        aEntidad.fkIDTIPOCAPACITACION = (New cSIPU_TIPOCAPACITACIONES).ObtenerSIPU_TIPOCAPACITACIONES(aEntidad.IDTIPOCAPACITACION)
        aEntidad.fkIDMUNICIPIO = (New cSIPU_MUNICIPIO).ObtenerSIPU_MUNICIPIO(aEntidad.IDMUNICIPIO)
        aEntidad.fkID_GENERACION = (New cSIPU_GENERACION).ObtenerSIPU_GENERACION(aEntidad.ID_GENERACION)
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
    ''' 	[GenApp]	29/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SIPU_CAPACITACIONES )
    End Sub

#End Region

End Class
