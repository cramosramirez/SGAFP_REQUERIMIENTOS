''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cSUPERVISION_AF
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SUPERVISION_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	03/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSUPERVISION_AF
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSUPERVISION_AF()
    Private mEntidad as New SUPERVISION_AF
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
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSUPERVISION_AF
        Try
            Dim mListaSUPERVISION_AF As New ListaSUPERVISION_AF
            mListaSUPERVISION_AF = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSUPERVISION_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As SUPERVISION_AF in  mListaSUPERVISION_AF
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSUPERVISION_AF
            If Not mListaSUPERVISION_AF Is Nothing Then
                For Each lEntidad As SUPERVISION_AF in  mListaSUPERVISION_AF
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSUPERVISION_AF
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
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSUPERVISION_AF(ByRef aEntidad As SUPERVISION_AF, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SUPERVISION_AF.
    ''' </summary>
    ''' <param name="ID_SUPERVISION_AF"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSUPERVISION_AF(ByVal ID_SUPERVISION_AF As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As SUPERVISION_AF
        Try
            Dim lEntidad As New SUPERVISION_AF
            lEntidad.ID_SUPERVISION_AF = ID_SUPERVISION_AF
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
    ''' Función que Elimina un Registro de la Tabla SUPERVISION_AF que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SUPERVISION_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSUPERVISION_AF(ByVal ID_SUPERVISION_AF As Decimal) As Integer
        Try
            mEntidad.ID_SUPERVISION_AF = ID_SUPERVISION_AF
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SUPERVISION_AF que se le envía como
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
    Public Function EliminarSUPERVISION_AF(ByVal aEntidad As SUPERVISION_AF, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    Public Function AgregarSUPERVISION_AF(ByVal ID_SUPERVISION_AF As Decimal, ByVal ID_MODALIDAD_FORMACION As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA As DateTime, ByVal NOMBRE_AF As String, ByVal CENTRO_FORMACION As String, ByVal OPCION As String, ByVal GRUPO As String, ByVal HORARIO As String, ByVal CODIGO As String, ByVal COORDINADOR_CFP As String, ByVal DIRECTOR_CFP As String, ByVal PARTICIPANTES_PRESENTES As Decimal, ByVal PARTICIPANTES_AUSENTES As Decimal, ByVal PARTICIPANTES_INSCRITOS As Decimal, ByVal PARTICIPANTES_DESERTADOS As Decimal, ByVal PARTICIPANTES_SUPLENTES As Decimal, ByVal OBJETIVO_VISITA As String, ByVal NOTAS As String, ByVal DURACION_VISITA As Decimal) As Integer
        Try
            Dim lEntidad As New SUPERVISION_AF
            lEntidad.ID_SUPERVISION_AF = ID_SUPERVISION_AF
            lEntidad.ID_MODALIDAD_FORMACION = ID_MODALIDAD_FORMACION
            lEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            lEntidad.FECHA = FECHA
            lEntidad.NOMBRE_AF = NOMBRE_AF
            lEntidad.CENTRO_FORMACION = CENTRO_FORMACION
            lEntidad.OPCION = OPCION
            lEntidad.GRUPO = GRUPO
            lEntidad.HORARIO = HORARIO
            lEntidad.CODIGO = CODIGO
            lEntidad.COORDINADOR_CFP = COORDINADOR_CFP
            lEntidad.DIRECTOR_CFP = DIRECTOR_CFP
            lEntidad.PARTICIPANTES_PRESENTES = PARTICIPANTES_PRESENTES
            lEntidad.PARTICIPANTES_AUSENTES = PARTICIPANTES_AUSENTES
            lEntidad.PARTICIPANTES_INSCRITOS = PARTICIPANTES_INSCRITOS
            lEntidad.PARTICIPANTES_DESERTADOS = PARTICIPANTES_DESERTADOS
            lEntidad.PARTICIPANTES_SUPLENTES = PARTICIPANTES_SUPLENTES
            lEntidad.OBJETIVO_VISITA = OBJETIVO_VISITA
            lEntidad.NOTAS = NOTAS
            lEntidad.DURACION_VISITA = DURACION_VISITA
            Return Me.ActualizarSUPERVISION_AF(lEntidad)
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
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSUPERVISION_AF(ByVal aEntidad As SUPERVISION_AF) As Integer
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
    Public Function ActualizarSUPERVISION_AF(ByVal aEntidad As SUPERVISION_AF, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSUPERVISION_AF(ByVal ID_SUPERVISION_AF As Decimal, ByVal ID_MODALIDAD_FORMACION As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal FECHA As DateTime, ByVal NOMBRE_AF As String, ByVal CENTRO_FORMACION As String, ByVal OPCION As String, ByVal GRUPO As String, ByVal HORARIO As String, ByVal CODIGO As String, ByVal COORDINADOR_CFP As String, ByVal DIRECTOR_CFP As String, ByVal PARTICIPANTES_PRESENTES As Decimal, ByVal PARTICIPANTES_AUSENTES As Decimal, ByVal PARTICIPANTES_INSCRITOS As Decimal, ByVal PARTICIPANTES_DESERTADOS As Decimal, ByVal PARTICIPANTES_SUPLENTES As Decimal, ByVal OBJETIVO_VISITA As String, ByVal NOTAS As String, ByVal DURACION_VISITA As Decimal) As Integer
        Try
            Dim lEntidad As New SUPERVISION_AF
            lEntidad.ID_SUPERVISION_AF = ID_SUPERVISION_AF
            lEntidad.ID_MODALIDAD_FORMACION = ID_MODALIDAD_FORMACION
            lEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            lEntidad.FECHA = FECHA
            lEntidad.NOMBRE_AF = NOMBRE_AF
            lEntidad.CENTRO_FORMACION = CENTRO_FORMACION
            lEntidad.OPCION = OPCION
            lEntidad.GRUPO = GRUPO
            lEntidad.HORARIO = HORARIO
            lEntidad.CODIGO = CODIGO
            lEntidad.COORDINADOR_CFP = COORDINADOR_CFP
            lEntidad.DIRECTOR_CFP = DIRECTOR_CFP
            lEntidad.PARTICIPANTES_PRESENTES = PARTICIPANTES_PRESENTES
            lEntidad.PARTICIPANTES_AUSENTES = PARTICIPANTES_AUSENTES
            lEntidad.PARTICIPANTES_INSCRITOS = PARTICIPANTES_INSCRITOS
            lEntidad.PARTICIPANTES_DESERTADOS = PARTICIPANTES_DESERTADOS
            lEntidad.PARTICIPANTES_SUPLENTES = PARTICIPANTES_SUPLENTES
            lEntidad.OBJETIVO_VISITA = OBJETIVO_VISITA
            lEntidad.NOTAS = NOTAS
            lEntidad.DURACION_VISITA = DURACION_VISITA
            Return Me.ActualizarSUPERVISION_AF(lEntidad)
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
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla MODALIDAD_DE_FORMACION .
    ''' </summary>
    ''' <param name="ID_MODALIDAD_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorMODALIDAD_DE_FORMACION(ByVal ID_MODALIDAD_FORMACION As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSUPERVISION_AF
        Try
            Dim mListaSUPERVISION_AF As New ListaSUPERVISION_AF
            mListaSUPERVISION_AF = mDb.ObtenerListaPorMODALIDAD_DE_FORMACION(ID_MODALIDAD_FORMACION, asColumnaOrden, asTipoOrden)
            If Not mListaSUPERVISION_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As SUPERVISION_AF in  mListaSUPERVISION_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSUPERVISION_AF
            If Not mListaSUPERVISION_AF Is Nothing Then
                For Each lEntidad As SUPERVISION_AF in  mListaSUPERVISION_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSUPERVISION_AF
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ACCION_FORMATIVA .
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSUPERVISION_AF
        Try
            Dim mListaSUPERVISION_AF As New ListaSUPERVISION_AF
            mListaSUPERVISION_AF = mDb.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA, asColumnaOrden, asTipoOrden)
            If Not mListaSUPERVISION_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As SUPERVISION_AF in  mListaSUPERVISION_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSUPERVISION_AF
            If Not mListaSUPERVISION_AF Is Nothing Then
                For Each lEntidad As SUPERVISION_AF in  mListaSUPERVISION_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaSUPERVISION_AF
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
    ''' 	[GenApp]	03/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SUPERVISION_AF )
        aEntidad.fkID_MODALIDAD_FORMACION = (New cMODALIDAD_DE_FORMACION).ObtenerMODALIDAD_DE_FORMACION(aEntidad.ID_MODALIDAD_FORMACION)
        aEntidad.fkID_ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
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
    Private Sub RecuperarHijas(ByRef aEntidad As SUPERVISION_AF )
    End Sub

#End Region

End Class
