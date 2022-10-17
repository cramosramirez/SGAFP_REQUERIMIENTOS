''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cTECNICOS_SITIOS_ASIG
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla TECNICOS_SITIOS_ASIG
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	01/06/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cTECNICOS_SITIOS_ASIG
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbTECNICOS_SITIOS_ASIG()
    Private mEntidad as New TECNICOS_SITIOS_ASIG
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal USUARIO As String, ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaTECNICOS_SITIOS_ASIG
        Try
            Dim mListaTECNICOS_SITIOS_ASIG As New ListaTECNICOS_SITIOS_ASIG
            mListaTECNICOS_SITIOS_ASIG = mDb.ObtenerListaPorID(USUARIO, ID_PROVEEDOR_AF, asColumnaOrden, asTipoOrden)
            If Not mListaTECNICOS_SITIOS_ASIG Is Nothing And recuperarForaneas Then
                For Each lEntidad As TECNICOS_SITIOS_ASIG in  mListaTECNICOS_SITIOS_ASIG
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaTECNICOS_SITIOS_ASIG
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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerTECNICOS_SITIOS_ASIG(ByRef aEntidad As TECNICOS_SITIOS_ASIG, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla TECNICOS_SITIOS_ASIG.
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerTECNICOS_SITIOS_ASIG(ByVal USUARIO As String, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal Optional recuperarForaneas As Boolean = False) As TECNICOS_SITIOS_ASIG
        Try
            Dim lEntidad As New TECNICOS_SITIOS_ASIG
            lEntidad.USUARIO = USUARIO
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
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
    ''' Función que Elimina un Registro de la Tabla TECNICOS_SITIOS_ASIG que se le envía como parámetro.
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarTECNICOS_SITIOS_ASIG(ByVal USUARIO As String, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal) As Integer
        Try
            mEntidad.USUARIO = USUARIO
            mEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            mEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla TECNICOS_SITIOS_ASIG que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarTECNICOS_SITIOS_ASIG(ByVal aEntidad As TECNICOS_SITIOS_ASIG, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarTECNICOS_SITIOS_ASIG(ByVal USUARIO As String, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal USERID As String, ByVal LASTUPDATE As DateTime) As Integer
        Try
            Dim lEntidad As New TECNICOS_SITIOS_ASIG
            lEntidad.USUARIO = USUARIO
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            Return Me.ActualizarTECNICOS_SITIOS_ASIG(lEntidad)
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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarTECNICOS_SITIOS_ASIG(ByVal aEntidad As TECNICOS_SITIOS_ASIG) As Integer
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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarTECNICOS_SITIOS_ASIG(ByVal aEntidad As TECNICOS_SITIOS_ASIG, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarTECNICOS_SITIOS_ASIG(ByVal USUARIO As String, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, ByVal USERID As String, ByVal LASTUPDATE As DateTime) As Integer
        Try
            Dim lEntidad As New TECNICOS_SITIOS_ASIG
            lEntidad.USUARIO = USUARIO
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            Return Me.ActualizarTECNICOS_SITIOS_ASIG(lEntidad)
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
    ''' <param name="USUARIO"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorId(ByVal USUARIO As String, ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As DataSet
        Try
            Return mDb.ObtenerDataSetPorID(USUARIO, ID_PROVEEDOR_AF, asColumnaOrden, asTipoOrden)
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
    ''' <param name="USUARIO"></param>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ds"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Fill, False)> _
    Public Function ObtenerDataSetPorId(ByVal USUARIO As String, ByVal ID_PROVEEDOR_AF As Decimal, ByRef ds As DataSet, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As Integer
        Try
            Return mDb.ObtenerDataSetPorID(USUARIO, ID_PROVEEDOR_AF, ds, asColumnaOrden, asTipoOrden)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla USUARIO .
    ''' </summary>
    ''' <param name="USUARIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorUSUARIO(ByVal USUARIO As String, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaTECNICOS_SITIOS_ASIG
        Try
            Dim mListaTECNICOS_SITIOS_ASIG As New ListaTECNICOS_SITIOS_ASIG
            mListaTECNICOS_SITIOS_ASIG = mDb.ObtenerListaPorUSUARIO(USUARIO, asColumnaOrden, asTipoOrden)
            If Not mListaTECNICOS_SITIOS_ASIG Is Nothing And recuperarForaneas Then
                For Each lEntidad As TECNICOS_SITIOS_ASIG in  mListaTECNICOS_SITIOS_ASIG
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaTECNICOS_SITIOS_ASIG
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PROVEEDOR_AF .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaTECNICOS_SITIOS_ASIG
        Try
            Dim mListaTECNICOS_SITIOS_ASIG As New ListaTECNICOS_SITIOS_ASIG
            mListaTECNICOS_SITIOS_ASIG = mDb.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF, asColumnaOrden, asTipoOrden)
            If Not mListaTECNICOS_SITIOS_ASIG Is Nothing And recuperarForaneas Then
                For Each lEntidad As TECNICOS_SITIOS_ASIG in  mListaTECNICOS_SITIOS_ASIG
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaTECNICOS_SITIOS_ASIG
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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As TECNICOS_SITIOS_ASIG )
        aEntidad.fkUSUARIO = (New cUSUARIO).ObtenerUSUARIO(aEntidad.USUARIO)
        aEntidad.fkID_PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF)
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
    ''' 	[GenApp]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As TECNICOS_SITIOS_ASIG )
    End Sub

#End Region

End Class
