''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cCONTRATO_BOLPROS
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla CONTRATO_BOLPROS
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/04/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cCONTRATO_BOLPROS
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbCONTRATO_BOLPROS()
    Private mEntidad as New CONTRATO_BOLPROS
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_BOLPROS
        Try
            Dim mListaCONTRATO_BOLPROS As New ListaCONTRATO_BOLPROS
            mListaCONTRATO_BOLPROS = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_BOLPROS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_BOLPROS in  mListaCONTRATO_BOLPROS
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTRATO_BOLPROS
            If Not mListaCONTRATO_BOLPROS Is Nothing Then
                For Each lEntidad As CONTRATO_BOLPROS in  mListaCONTRATO_BOLPROS
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_BOLPROS
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
    ''' 	[GenApp]	02/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerCONTRATO_BOLPROS(ByRef aEntidad As CONTRATO_BOLPROS, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla CONTRATO_BOLPROS.
    ''' </summary>
    ''' <param name="ID_CONTRATO"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerCONTRATO_BOLPROS(ByVal ID_CONTRATO As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As CONTRATO_BOLPROS
        Try
            Dim lEntidad As New CONTRATO_BOLPROS
            lEntidad.ID_CONTRATO = ID_CONTRATO
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
    ''' <param name="aPROVEEDOR_AF">Recuperar registro foraneo de la Entidad PROVEEDOR_AF.</param>
    ''' <param name="aPROGRAMA_FORMACION">Recuperar registro foraneo de la Entidad PROGRAMA_FORMACION.</param>
    ''' <param name="aFUENTE_FINANCIAMIENTO">Recuperar registro foraneo de la Entidad FUENTE_FINANCIAMIENTO.</param>
    ''' <param name="aTIPO_CONTRATACION">Recuperar registro foraneo de la Entidad TIPO_CONTRATACION.</param>
    ''' <param name="aCONTRATO_COMPRA">Recuperar registro foraneo de la Entidad CONTRATO_COMPRA.</param>
    ''' <param name="aTIPO_ADJUDICACION">Recuperar registro foraneo de la Entidad TIPO_ADJUDICACION.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerCONTRATO_BOLPROSConForaneas(ByVal aEntidad As CONTRATO_BOLPROS, Optional ByVal aPROVEEDOR_AF As Boolean = False, Optional ByVal aPROGRAMA_FORMACION As Boolean = False, Optional ByVal aFUENTE_FINANCIAMIENTO As Boolean = False, Optional ByVal aTIPO_CONTRATACION As Boolean = False, Optional ByVal aCONTRATO_COMPRA As Boolean = False, Optional ByVal aTIPO_ADJUDICACION As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aPROVEEDOR_AF, aPROGRAMA_FORMACION, aFUENTE_FINANCIAMIENTO, aTIPO_CONTRATACION, aCONTRATO_COMPRA, aTIPO_ADJUDICACION)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTRATO_BOLPROS que se le envía como parámetro.
    ''' </summary>
    ''' <param name="ID_CONTRATO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTRATO_BOLPROS(ByVal ID_CONTRATO As Decimal) As Integer
        Try
            mEntidad.ID_CONTRATO = ID_CONTRATO
            Return mDb.Eliminar(mEntidad)
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Elimina un Registro de la Tabla CONTRATO_BOLPROS que se le envía como
    ''' parámetro y ademas utiliza de parametro el Tipo de Concurrencia.
    ''' </summary>
    ''' <param name="aEntidad">Instancia de la Entidad a Eliminar en la Base de Datos.</param>
    ''' <param name="aTipoConcurrencia">Tipo de Concurrencia a utilizar al eliminar el
    ''' registro.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, False)> _
    Public Function EliminarCONTRATO_BOLPROS(ByVal aEntidad As CONTRATO_BOLPROS, ByVal aTipoConcurrencia As TipoConcurrencia) As Integer
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
    ''' 	[GenApp]	02/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarCONTRATO_BOLPROS(ByVal ID_CONTRATO As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal ID_FUENTE As Decimal, ByVal NUM_CONTRATO As String, ByVal MONTO As Decimal, ByVal LOTE As String, ByVal SUB_LOTE As String, ByVal USUARIO_CREACION As String, ByVal FECHA_CREACION As DateTime, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal ID_TIPO_CONTRA As Decimal, ByVal ID_OFERTA_COMPRA As Decimal, ByVal ID_CONTRATO_COMPRA As Decimal, ByVal FECHA_INI_EJEC As DateTime, ByVal FECHA_FIN_EJEC As DateTime, ByVal ES_PAGO_PARTICIPANTE As Decimal, ByVal ID_TIPO_ADJ As Decimal, ByVal COSTO_X_PARTICIPANTE As Decimal, ByVal PARTICIPACIONES As Decimal, ByVal ES_INCREMENTO As Decimal, ByVal NO_PRODUCTO As Decimal) As Integer
        Try
            Dim lEntidad As New CONTRATO_BOLPROS
            lEntidad.ID_CONTRATO = ID_CONTRATO
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.ID_PROGRAMA_FORMACION = ID_PROGRAMA_FORMACION
            lEntidad.ID_FUENTE = ID_FUENTE
            lEntidad.NUM_CONTRATO = NUM_CONTRATO
            lEntidad.MONTO = MONTO
            lEntidad.LOTE = LOTE
            lEntidad.SUB_LOTE = SUB_LOTE
            lEntidad.USUARIO_CREACION = USUARIO_CREACION
            lEntidad.FECHA_CREACION = FECHA_CREACION
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.ID_TIPO_CONTRA = ID_TIPO_CONTRA
            lEntidad.ID_OFERTA_COMPRA = ID_OFERTA_COMPRA
            lEntidad.ID_CONTRATO_COMPRA = ID_CONTRATO_COMPRA
            lEntidad.FECHA_INI_EJEC = FECHA_INI_EJEC
            lEntidad.FECHA_FIN_EJEC = FECHA_FIN_EJEC
            lEntidad.ES_PAGO_PARTICIPANTE = ES_PAGO_PARTICIPANTE
            lEntidad.ID_TIPO_ADJ = ID_TIPO_ADJ
            lEntidad.COSTO_X_PARTICIPANTE = COSTO_X_PARTICIPANTE
            lEntidad.PARTICIPACIONES = PARTICIPACIONES
            lEntidad.ES_INCREMENTO = ES_INCREMENTO
            lEntidad.NO_PRODUCTO = NO_PRODUCTO
            Return Me.ActualizarCONTRATO_BOLPROS(lEntidad)
        Catch ex As Exception
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
    ''' 	[GenApp]	02/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarCONTRATO_BOLPROS(ByVal ID_CONTRATO As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal ID_FUENTE As Decimal, ByVal NUM_CONTRATO As String, ByVal MONTO As Decimal, ByVal LOTE As String, ByVal SUB_LOTE As String, ByVal USUARIO_CREACION As String, ByVal FECHA_CREACION As DateTime, ByVal USERID As String, ByVal LASTUPDATE As DateTime, ByVal ID_TIPO_CONTRA As Decimal, ByVal ID_OFERTA_COMPRA As Decimal, ByVal ID_CONTRATO_COMPRA As Decimal, ByVal FECHA_INI_EJEC As DateTime, ByVal FECHA_FIN_EJEC As DateTime, ByVal ES_PAGO_PARTICIPANTE As Decimal, ByVal ID_TIPO_ADJ As Decimal, ByVal COSTO_X_PARTICIPANTE As Decimal, ByVal PARTICIPACIONES As Decimal, ByVal ES_INCREMENTO As Decimal, ByVal NO_PRODUCTO As Decimal) As Integer
        Try
            Dim lEntidad As New CONTRATO_BOLPROS
            lEntidad.ID_CONTRATO = ID_CONTRATO
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.ID_PROGRAMA_FORMACION = ID_PROGRAMA_FORMACION
            lEntidad.ID_FUENTE = ID_FUENTE
            lEntidad.NUM_CONTRATO = NUM_CONTRATO
            lEntidad.MONTO = MONTO
            lEntidad.LOTE = LOTE
            lEntidad.SUB_LOTE = SUB_LOTE
            lEntidad.USUARIO_CREACION = USUARIO_CREACION
            lEntidad.FECHA_CREACION = FECHA_CREACION
            lEntidad.USERID = USERID
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.ID_TIPO_CONTRA = ID_TIPO_CONTRA
            lEntidad.ID_OFERTA_COMPRA = ID_OFERTA_COMPRA
            lEntidad.ID_CONTRATO_COMPRA = ID_CONTRATO_COMPRA
            lEntidad.FECHA_INI_EJEC = FECHA_INI_EJEC
            lEntidad.FECHA_FIN_EJEC = FECHA_FIN_EJEC
            lEntidad.ES_PAGO_PARTICIPANTE = ES_PAGO_PARTICIPANTE
            lEntidad.ID_TIPO_ADJ = ID_TIPO_ADJ
            lEntidad.COSTO_X_PARTICIPANTE = COSTO_X_PARTICIPANTE
            lEntidad.PARTICIPACIONES = PARTICIPACIONES
            lEntidad.ES_INCREMENTO = ES_INCREMENTO
            lEntidad.NO_PRODUCTO = NO_PRODUCTO
            Return Me.ActualizarCONTRATO_BOLPROS(lEntidad)
        Catch ex As Exception
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
    ''' 	[GenApp]	02/04/2019	Created
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
    ''' 	[GenApp]	02/04/2019	Created
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
    ''' la Tabla PROVEEDOR_AF .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_BOLPROS
        Try
            Dim mListaCONTRATO_BOLPROS As New ListaCONTRATO_BOLPROS
            mListaCONTRATO_BOLPROS = mDb.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF, asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_BOLPROS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_BOLPROS in  mListaCONTRATO_BOLPROS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTRATO_BOLPROS
            If Not mListaCONTRATO_BOLPROS Is Nothing Then
                For Each lEntidad As CONTRATO_BOLPROS in  mListaCONTRATO_BOLPROS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_BOLPROS
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
    ''' 	[GenApp]	02/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROGRAMA_FORMACION(ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_BOLPROS
        Try
            Dim mListaCONTRATO_BOLPROS As New ListaCONTRATO_BOLPROS
            mListaCONTRATO_BOLPROS = mDb.ObtenerListaPorPROGRAMA_FORMACION(ID_PROGRAMA_FORMACION, asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_BOLPROS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_BOLPROS in  mListaCONTRATO_BOLPROS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTRATO_BOLPROS
            If Not mListaCONTRATO_BOLPROS Is Nothing Then
                For Each lEntidad As CONTRATO_BOLPROS in  mListaCONTRATO_BOLPROS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_BOLPROS
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla FUENTE_FINANCIAMIENTO .
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorFUENTE_FINANCIAMIENTO(ByVal ID_FUENTE As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_BOLPROS
        Try
            Dim mListaCONTRATO_BOLPROS As New ListaCONTRATO_BOLPROS
            mListaCONTRATO_BOLPROS = mDb.ObtenerListaPorFUENTE_FINANCIAMIENTO(ID_FUENTE, asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_BOLPROS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_BOLPROS in  mListaCONTRATO_BOLPROS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTRATO_BOLPROS
            If Not mListaCONTRATO_BOLPROS Is Nothing Then
                For Each lEntidad As CONTRATO_BOLPROS in  mListaCONTRATO_BOLPROS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_BOLPROS
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPO_CONTRATACION .
    ''' </summary>
    ''' <param name="ID_TIPO_CONTRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_CONTRATACION(ByVal ID_TIPO_CONTRA As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_BOLPROS
        Try
            Dim mListaCONTRATO_BOLPROS As New ListaCONTRATO_BOLPROS
            mListaCONTRATO_BOLPROS = mDb.ObtenerListaPorTIPO_CONTRATACION(ID_TIPO_CONTRA, asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_BOLPROS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_BOLPROS in  mListaCONTRATO_BOLPROS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTRATO_BOLPROS
            If Not mListaCONTRATO_BOLPROS Is Nothing Then
                For Each lEntidad As CONTRATO_BOLPROS in  mListaCONTRATO_BOLPROS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_BOLPROS
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla CONTRATO_COMPRA .
    ''' </summary>
    ''' <param name="ID_CONTRATO_COMPRA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCONTRATO_COMPRA(ByVal ID_CONTRATO_COMPRA As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_BOLPROS
        Try
            Dim mListaCONTRATO_BOLPROS As New ListaCONTRATO_BOLPROS
            mListaCONTRATO_BOLPROS = mDb.ObtenerListaPorCONTRATO_COMPRA(ID_CONTRATO_COMPRA, asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_BOLPROS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_BOLPROS in  mListaCONTRATO_BOLPROS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTRATO_BOLPROS
            If Not mListaCONTRATO_BOLPROS Is Nothing Then
                For Each lEntidad As CONTRATO_BOLPROS in  mListaCONTRATO_BOLPROS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_BOLPROS
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla TIPO_ADJUDICACION .
    ''' </summary>
    ''' <param name="ID_TIPO_ADJ"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTIPO_ADJUDICACION(ByVal ID_TIPO_ADJ As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaCONTRATO_BOLPROS
        Try
            Dim mListaCONTRATO_BOLPROS As New ListaCONTRATO_BOLPROS
            mListaCONTRATO_BOLPROS = mDb.ObtenerListaPorTIPO_ADJUDICACION(ID_TIPO_ADJ, asColumnaOrden, asTipoOrden)
            If Not mListaCONTRATO_BOLPROS Is Nothing And recuperarForaneas Then
                For Each lEntidad As CONTRATO_BOLPROS in  mListaCONTRATO_BOLPROS
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaCONTRATO_BOLPROS
            If Not mListaCONTRATO_BOLPROS Is Nothing Then
                For Each lEntidad As CONTRATO_BOLPROS in  mListaCONTRATO_BOLPROS
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaCONTRATO_BOLPROS
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
    ''' 	[GenApp]	02/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As CONTRATO_BOLPROS )
        aEntidad.fkID_PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF)
        aEntidad.fkID_PROGRAMA_FORMACION = (New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(aEntidad.ID_PROGRAMA_FORMACION)
        aEntidad.fkID_FUENTE = (New cFUENTE_FINANCIAMIENTO).ObtenerFUENTE_FINANCIAMIENTO(aEntidad.ID_FUENTE)
        aEntidad.fkID_TIPO_CONTRA = (New cTIPO_CONTRATACION).ObtenerTIPO_CONTRATACION(aEntidad.ID_TIPO_CONTRA)
        aEntidad.fkID_CONTRATO_COMPRA = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRA(aEntidad.ID_CONTRATO_COMPRA)
        aEntidad.fkID_TIPO_ADJ = (New cTIPO_ADJUDICACION).ObtenerTIPO_ADJUDICACION(aEntidad.ID_TIPO_ADJ)
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
    ''' 	[GenApp]	02/04/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As CONTRATO_BOLPROS )
    End Sub

#End Region

End Class
