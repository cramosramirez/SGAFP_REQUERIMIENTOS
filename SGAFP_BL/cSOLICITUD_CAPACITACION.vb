''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cSOLICITUD_CAPACITACION
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla SOLICITUD_CAPACITACION
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/10/2016	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cSOLICITUD_CAPACITACION
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbSOLICITUD_CAPACITACION()
    Private mEntidad as New SOLICITUD_CAPACITACION
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_CAPACITACION
        Try
            Dim mListaSOLICITUD_CAPACITACION As New ListaSOLICITUD_CAPACITACION
            mListaSOLICITUD_CAPACITACION = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_CAPACITACION Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_CAPACITACION in  mListaSOLICITUD_CAPACITACION
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_CAPACITACION
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
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerSOLICITUD_CAPACITACION(ByRef aEntidad As SOLICITUD_CAPACITACION, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla SOLICITUD_CAPACITACION.
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerSOLICITUD_CAPACITACION(ByVal ID_SOLICITUD As Decimal, ByVal Optional recuperarForaneas As Boolean = False) As SOLICITUD_CAPACITACION
        Try
            Dim lEntidad As New SOLICITUD_CAPACITACION
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
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
    ''' <param name="aREFERENTE">Recuperar registro foraneo de la Entidad REFERENTE.</param>
    ''' <param name="aCENTRO_RESPONSABILIDAD">Recuperar registro foraneo de la Entidad CENTRO_RESPONSABILIDAD.</param>
    ''' <param name="aUNIDAD_ORGANIZATIVA">Recuperar registro foraneo de la Entidad UNIDAD_ORGANIZATIVA.</param>
    ''' <param name="aPROGRAMA_FORMACION">Recuperar registro foraneo de la Entidad PROGRAMA_FORMACION.</param>
    ''' <param name="aPROYECTO_FORMACION">Recuperar registro foraneo de la Entidad PROYECTO_FORMACION.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerSOLICITUD_CAPACITACIONConForaneas(ByVal aEntidad As SOLICITUD_CAPACITACION, Optional ByVal aREFERENTE As Boolean = False, Optional ByVal aCENTRO_RESPONSABILIDAD As Boolean = False, Optional ByVal aUNIDAD_ORGANIZATIVA As Boolean = False, Optional ByVal aPROGRAMA_FORMACION As Boolean = False, Optional ByVal aPROYECTO_FORMACION As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aREFERENTE, aCENTRO_RESPONSABILIDAD, aUNIDAD_ORGANIZATIVA, aPROGRAMA_FORMACION, aPROYECTO_FORMACION)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_CAPACITACION que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_SOLICITUD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLICITUD_CAPACITACION(ByVal ID_SOLICITUD As Decimal) As Integer
        Try
            mEntidad.ID_SOLICITUD = ID_SOLICITUD
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla SOLICITUD_CAPACITACION que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarSOLICITUD_CAPACITACION(ByVal aEntidad As SOLICITUD_CAPACITACION, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarSOLICITUD_CAPACITACION(ByVal ID_SOLICITUD As Decimal, ByVal ID_REFERENTE As Decimal, ByVal ID_CENTRO_RESPONSABILIDAD As Decimal, ByVal ID_UNIDAD_ORGANIZATIVA As Decimal, ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal ID_PROYECTO_FORMACION As Decimal, ByVal FECHA_SOLICITUD As DateTime, ByVal OBJETIVO_CAPACITACION As String, ByVal HORARIO As String, ByVal TELEF1 As String, ByVal TELEF2 As String, ByVal TELEF3 As String, ByVal TELEF_MOVIL As String, ByVal FAX As String, ByVal NOMBRES_CONTACTO As String, ByVal APELLIDOS_CONTACTO As String, ByVal EMAIL_CONTACTO As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal PORC_PAGO_INFORME1 As Decimal) As Integer
        Try
            Dim lEntidad As New SOLICITUD_CAPACITACION
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_REFERENTE = ID_REFERENTE
            lEntidad.ID_CENTRO_RESPONSABILIDAD = ID_CENTRO_RESPONSABILIDAD
            lEntidad.ID_UNIDAD_ORGANIZATIVA = ID_UNIDAD_ORGANIZATIVA
            lEntidad.ID_PROGRAMA_FORMACION = ID_PROGRAMA_FORMACION
            lEntidad.ID_PROYECTO_FORMACION = ID_PROYECTO_FORMACION
            lEntidad.FECHA_SOLICITUD = FECHA_SOLICITUD
            lEntidad.OBJETIVO_CAPACITACION = OBJETIVO_CAPACITACION
            lEntidad.HORARIO = HORARIO
            lEntidad.TELEF1 = TELEF1
            lEntidad.TELEF2 = TELEF2
            lEntidad.TELEF3 = TELEF3
            lEntidad.TELEF_MOVIL = TELEF_MOVIL
            lEntidad.FAX = FAX
            lEntidad.NOMBRES_CONTACTO = NOMBRES_CONTACTO
            lEntidad.APELLIDOS_CONTACTO = APELLIDOS_CONTACTO
            lEntidad.EMAIL_CONTACTO = EMAIL_CONTACTO
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.PORC_PAGO_INFORME1 = PORC_PAGO_INFORME1
            Return Me.ActualizarSOLICITUD_CAPACITACION(lEntidad)
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
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_CAPACITACION(ByVal aEntidad As SOLICITUD_CAPACITACION) As Integer
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
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_CAPACITACION(ByVal aEntidad As SOLICITUD_CAPACITACION, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarSOLICITUD_CAPACITACION(ByVal ID_SOLICITUD As Decimal, ByVal ID_REFERENTE As Decimal, ByVal ID_CENTRO_RESPONSABILIDAD As Decimal, ByVal ID_UNIDAD_ORGANIZATIVA As Decimal, ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal ID_PROYECTO_FORMACION As Decimal, ByVal FECHA_SOLICITUD As DateTime, ByVal OBJETIVO_CAPACITACION As String, ByVal HORARIO As String, ByVal TELEF1 As String, ByVal TELEF2 As String, ByVal TELEF3 As String, ByVal TELEF_MOVIL As String, ByVal FAX As String, ByVal NOMBRES_CONTACTO As String, ByVal APELLIDOS_CONTACTO As String, ByVal EMAIL_CONTACTO As String, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal PORC_PAGO_INFORME1 As Decimal) As Integer
        Try
            Dim lEntidad As New SOLICITUD_CAPACITACION
            lEntidad.ID_SOLICITUD = ID_SOLICITUD
            lEntidad.ID_REFERENTE = ID_REFERENTE
            lEntidad.ID_CENTRO_RESPONSABILIDAD = ID_CENTRO_RESPONSABILIDAD
            lEntidad.ID_UNIDAD_ORGANIZATIVA = ID_UNIDAD_ORGANIZATIVA
            lEntidad.ID_PROGRAMA_FORMACION = ID_PROGRAMA_FORMACION
            lEntidad.ID_PROYECTO_FORMACION = ID_PROYECTO_FORMACION
            lEntidad.FECHA_SOLICITUD = FECHA_SOLICITUD
            lEntidad.OBJETIVO_CAPACITACION = OBJETIVO_CAPACITACION
            lEntidad.HORARIO = HORARIO
            lEntidad.TELEF1 = TELEF1
            lEntidad.TELEF2 = TELEF2
            lEntidad.TELEF3 = TELEF3
            lEntidad.TELEF_MOVIL = TELEF_MOVIL
            lEntidad.FAX = FAX
            lEntidad.NOMBRES_CONTACTO = NOMBRES_CONTACTO
            lEntidad.APELLIDOS_CONTACTO = APELLIDOS_CONTACTO
            lEntidad.EMAIL_CONTACTO = EMAIL_CONTACTO
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.PORC_PAGO_INFORME1 = PORC_PAGO_INFORME1
            Return Me.ActualizarSOLICITUD_CAPACITACION(lEntidad)
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
    ''' 	[GenApp]	19/10/2016	Created
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
    ''' 	[GenApp]	19/10/2016	Created
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
    ''' la Tabla REFERENTE .
    ''' </summary>
    ''' <param name="ID_REFERENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorREFERENTE(ByVal ID_REFERENTE As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_CAPACITACION
        Try
            Dim mListaSOLICITUD_CAPACITACION As New ListaSOLICITUD_CAPACITACION
            mListaSOLICITUD_CAPACITACION = mDb.ObtenerListaPorREFERENTE(ID_REFERENTE, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_CAPACITACION Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_CAPACITACION in  mListaSOLICITUD_CAPACITACION
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_CAPACITACION
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CENTRO_RESPONSABILIDAD .
    ''' </summary>
    ''' <param name="ID_CENTRO_RESPONSABILIDAD"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCENTRO_RESPONSABILIDAD(ByVal ID_CENTRO_RESPONSABILIDAD As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_CAPACITACION
        Try
            Dim mListaSOLICITUD_CAPACITACION As New ListaSOLICITUD_CAPACITACION
            mListaSOLICITUD_CAPACITACION = mDb.ObtenerListaPorCENTRO_RESPONSABILIDAD(ID_CENTRO_RESPONSABILIDAD, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_CAPACITACION Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_CAPACITACION in  mListaSOLICITUD_CAPACITACION
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_CAPACITACION
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla UNIDAD_ORGANIZATIVA .
    ''' </summary>
    ''' <param name="ID_UNIDAD_ORGANIZATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorUNIDAD_ORGANIZATIVA(ByVal ID_UNIDAD_ORGANIZATIVA As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_CAPACITACION
        Try
            Dim mListaSOLICITUD_CAPACITACION As New ListaSOLICITUD_CAPACITACION
            mListaSOLICITUD_CAPACITACION = mDb.ObtenerListaPorUNIDAD_ORGANIZATIVA(ID_UNIDAD_ORGANIZATIVA, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_CAPACITACION Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_CAPACITACION in  mListaSOLICITUD_CAPACITACION
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_CAPACITACION
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PROGRAMA_FORMACION .
    ''' </summary>
    ''' <param name="ID_PROGRAMA_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROGRAMA_FORMACION(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_CAPACITACION
        Try
            Dim mListaSOLICITUD_CAPACITACION As New ListaSOLICITUD_CAPACITACION
            mListaSOLICITUD_CAPACITACION = mDb.ObtenerListaPorPROGRAMA_FORMACION(ID_PROGRAMA_FORMACION, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_CAPACITACION Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_CAPACITACION in  mListaSOLICITUD_CAPACITACION
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_CAPACITACION
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PROYECTO_FORMACION .
    ''' </summary>
    ''' <param name="ID_PROYECTO_FORMACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROYECTO_FORMACION(ByVal ID_PROYECTO_FORMACION As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaSOLICITUD_CAPACITACION
        Try
            Dim mListaSOLICITUD_CAPACITACION As New ListaSOLICITUD_CAPACITACION
            mListaSOLICITUD_CAPACITACION = mDb.ObtenerListaPorPROYECTO_FORMACION(ID_PROYECTO_FORMACION, asColumnaOrden, asTipoOrden)
            If Not mListaSOLICITUD_CAPACITACION Is Nothing And recuperarForaneas Then
                For Each lEntidad As SOLICITUD_CAPACITACION in  mListaSOLICITUD_CAPACITACION
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaSOLICITUD_CAPACITACION
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
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As SOLICITUD_CAPACITACION )
        aEntidad.fkID_REFERENTE = (New cREFERENTE).ObtenerREFERENTE(aEntidad.ID_REFERENTE)
        aEntidad.fkID_CENTRO_RESPONSABILIDAD = (New cCENTRO_RESPONSABILIDAD).ObtenerCENTRO_RESPONSABILIDAD(aEntidad.ID_CENTRO_RESPONSABILIDAD)
        aEntidad.fkID_UNIDAD_ORGANIZATIVA = (New cUNIDAD_ORGANIZATIVA).ObtenerUNIDAD_ORGANIZATIVA(aEntidad.ID_UNIDAD_ORGANIZATIVA)
        aEntidad.fkID_PROGRAMA_FORMACION = (New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(aEntidad.ID_PROGRAMA_FORMACION)
        aEntidad.fkID_PROYECTO_FORMACION = (New cPROYECTO_FORMACION).ObtenerPROYECTO_FORMACION(aEntidad.ID_PROYECTO_FORMACION)
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
    ''' 	[GenApp]	19/10/2016	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As SOLICITUD_CAPACITACION )
    End Sub

#End Region

End Class
