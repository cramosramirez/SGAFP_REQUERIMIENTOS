''' -----------------------------------------------------------------------------
''' Project	 : SGAFP_BL
''' Class	 : BL.cINFORME_FINAL_AF
'''
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase de Lógica de Negocios que utiliza la capa de Acceso a Datos y provee
''' las funciones CRUD(Create, Read, Update y Delete) de la tabla INFORME_FINAL_AF
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	20/07/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
<System.ComponentModel.DataObject()> _
Public Class cINFORME_FINAL_AF
    Inherits controladorBase

#Region " Metodos Generador "

#Region " Privadas "
    Private mDb as New dbINFORME_FINAL_AF()
    Private mEntidad as New INFORME_FINAL_AF
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerLista(ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaINFORME_FINAL_AF
        Try
            Dim mListaINFORME_FINAL_AF As New ListaINFORME_FINAL_AF
            mListaINFORME_FINAL_AF = mDb.ObtenerListaPorID(asColumnaOrden, asTipoOrden)
            If Not mListaINFORME_FINAL_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As INFORME_FINAL_AF in  mListaINFORME_FINAL_AF
                    Try
                    Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaINFORME_FINAL_AF
            If Not mListaINFORME_FINAL_AF Is Nothing Then
                For Each lEntidad As INFORME_FINAL_AF in  mListaINFORME_FINAL_AF
                    Try
                    Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaINFORME_FINAL_AF
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
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerINFORME_FINAL_AF(ByRef aEntidad As INFORME_FINAL_AF, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As Integer
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
    ''' Función que selecciona un Registro y lo Devuelve en una Entidad de la Tabla INFORME_FINAL_AF.
    ''' </summary>
    ''' <param name="ID_INFORME_FINAL"></param>
    ''' <param name="recuperarForaneas">Indica si se recuperaran los datos de las
    ''' Tablas Foraneas, por defecto no se recuperan las Foraneas.</param>
    ''' <param name="recuperarHijas">Indica si se recuperaran los datos de las
    ''' Tablas Hijas, por defecto no se recuperan las hijas.</param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function ObtenerINFORME_FINAL_AF(ByVal ID_INFORME_FINAL As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False) As INFORME_FINAL_AF
        Try
            Dim lEntidad As New INFORME_FINAL_AF
            lEntidad.ID_INFORME_FINAL = ID_INFORME_FINAL
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
    ''' <param name="aACCION_FORMATIVA">Recuperar registro foraneo de la Entidad ACCION_FORMATIVA.</param>
    ''' <param name="aPROVEEDOR_AF">Recuperar registro foraneo de la Entidad PROVEEDOR_AF.</param>
    ''' <param name="aESTADO_INFORME_AF">Recuperar registro foraneo de la Entidad ESTADO_INFORME_AF.</param>
    ''' <remarks>La entidad ya debe estar inicializada y tener asignados los valores
    ''' de la Llave Primaria, para su recuperación.</remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerINFORME_FINAL_AFConForaneas(ByVal aEntidad As INFORME_FINAL_AF, Optional ByVal aACCION_FORMATIVA As Boolean = False, Optional ByVal aPROVEEDOR_AF As Boolean = False, Optional ByVal aESTADO_INFORME_AF As Boolean = False) As Integer
        Try
            Return mDb.RecuperarConForaneas(aEntidad, aACCION_FORMATIVA, aPROVEEDOR_AF, aESTADO_INFORME_AF)
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
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, False)> _
    Public Function AgregarINFORME_FINAL_AF(ByVal ID_INFORME_FINAL As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal FECHA_INFORME As DateTime, ByVal NUMERO_FACTURA As String, ByVal ELABORADO_POR As String, ByVal MONTO_FACTURA As Decimal, ByVal MONTO_APROBADO As Decimal, ByVal PARTICIPANTES_INSCRITOS As Decimal, ByVal PARTICIPANTES_FINALES As Decimal, ByVal PORC_PROM_ASISTENCIA As Decimal, ByVal NOTA_PROMEDIO As Decimal, ByVal COMENTARIOS As String, ByVal USUARIO_APROBACION As String, ByVal LASTUPDATE As DateTime, ByVal USERID As String, ByVal ID_ESTADO_INFORME As Decimal, ByVal HORAS_DESARROLLADAS As Decimal, ByVal FECHA_INICIAL As DateTime, ByVal FECHA_FINAL As DateTime, ByVal HORARIO As String, ByVal COSTO_X_HORA As Decimal, ByVal MONTO_PAGO_INICIAL As Decimal, ByVal USUARIO_ASIGNADO As String) As Integer
        Try
            Dim lEntidad As New INFORME_FINAL_AF
            lEntidad.ID_INFORME_FINAL = ID_INFORME_FINAL
            lEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.FECHA_INFORME = FECHA_INFORME
            lEntidad.NUMERO_FACTURA = NUMERO_FACTURA
            lEntidad.ELABORADO_POR = ELABORADO_POR
            lEntidad.MONTO_FACTURA = MONTO_FACTURA
            lEntidad.MONTO_APROBADO = MONTO_APROBADO
            lEntidad.PARTICIPANTES_INSCRITOS = PARTICIPANTES_INSCRITOS
            lEntidad.PARTICIPANTES_FINALES = PARTICIPANTES_FINALES
            lEntidad.PORC_PROM_ASISTENCIA = PORC_PROM_ASISTENCIA
            lEntidad.NOTA_PROMEDIO = NOTA_PROMEDIO
            lEntidad.COMENTARIOS = COMENTARIOS
            lEntidad.USUARIO_APROBACION = USUARIO_APROBACION
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.USERID = USERID
            lEntidad.ID_ESTADO_INFORME = ID_ESTADO_INFORME
            lEntidad.HORAS_DESARROLLADAS = HORAS_DESARROLLADAS
            lEntidad.FECHA_INICIAL = FECHA_INICIAL
            lEntidad.FECHA_FINAL = FECHA_FINAL
            lEntidad.HORARIO = HORARIO
            lEntidad.COSTO_X_HORA = COSTO_X_HORA
            lEntidad.MONTO_PAGO_INICIAL = MONTO_PAGO_INICIAL
            lEntidad.USUARIO_ASIGNADO = USUARIO_ASIGNADO
            Return Me.ActualizarINFORME_FINAL_AF(lEntidad)
        Catch ex As Exception
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
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarINFORME_FINAL_AF(ByVal aEntidad As INFORME_FINAL_AF) As Integer
        Try
            Return Me.ActualizarINFORME_FINAL_AF(aEntidad, TipoConcurrencia.Pesimistica)
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
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, False)> _
    Public Function ActualizarINFORME_FINAL_AF(ByVal ID_INFORME_FINAL As Decimal, ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_PROVEEDOR_AF As Decimal, ByVal FECHA_INFORME As DateTime, ByVal NUMERO_FACTURA As String, ByVal ELABORADO_POR As String, ByVal MONTO_FACTURA As Decimal, ByVal MONTO_APROBADO As Decimal, ByVal PARTICIPANTES_INSCRITOS As Decimal, ByVal PARTICIPANTES_FINALES As Decimal, ByVal PORC_PROM_ASISTENCIA As Decimal, ByVal NOTA_PROMEDIO As Decimal, ByVal COMENTARIOS As String, ByVal USUARIO_APROBACION As String, ByVal LASTUPDATE As DateTime, ByVal USERID As String, ByVal ID_ESTADO_INFORME As Decimal, ByVal HORAS_DESARROLLADAS As Decimal, ByVal FECHA_INICIAL As DateTime, ByVal FECHA_FINAL As DateTime, ByVal HORARIO As String, ByVal COSTO_X_HORA As Decimal, ByVal MONTO_PAGO_INICIAL As Decimal, ByVal USUARIO_ASIGNADO As String) As Integer
        Try
            Dim lEntidad As New INFORME_FINAL_AF
            lEntidad.ID_INFORME_FINAL = ID_INFORME_FINAL
            lEntidad.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
            lEntidad.ID_PROVEEDOR_AF = ID_PROVEEDOR_AF
            lEntidad.FECHA_INFORME = FECHA_INFORME
            lEntidad.NUMERO_FACTURA = NUMERO_FACTURA
            lEntidad.ELABORADO_POR = ELABORADO_POR
            lEntidad.MONTO_FACTURA = MONTO_FACTURA
            lEntidad.MONTO_APROBADO = MONTO_APROBADO
            lEntidad.PARTICIPANTES_INSCRITOS = PARTICIPANTES_INSCRITOS
            lEntidad.PARTICIPANTES_FINALES = PARTICIPANTES_FINALES
            lEntidad.PORC_PROM_ASISTENCIA = PORC_PROM_ASISTENCIA
            lEntidad.NOTA_PROMEDIO = NOTA_PROMEDIO
            lEntidad.COMENTARIOS = COMENTARIOS
            lEntidad.USUARIO_APROBACION = USUARIO_APROBACION
            lEntidad.LASTUPDATE = LASTUPDATE
            lEntidad.USERID = USERID
            lEntidad.ID_ESTADO_INFORME = ID_ESTADO_INFORME
            lEntidad.HORAS_DESARROLLADAS = HORAS_DESARROLLADAS
            lEntidad.FECHA_INICIAL = FECHA_INICIAL
            lEntidad.FECHA_FINAL = FECHA_FINAL
            lEntidad.HORARIO = HORARIO
            lEntidad.COSTO_X_HORA = COSTO_X_HORA
            lEntidad.MONTO_PAGO_INICIAL = MONTO_PAGO_INICIAL
            lEntidad.USUARIO_ASIGNADO = USUARIO_ASIGNADO
            Return Me.ActualizarINFORME_FINAL_AF(lEntidad)
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
    ''' 	[GenApp]	20/07/2012	Created
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
    ''' 	[GenApp]	20/07/2012	Created
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
    ''' la Tabla ACCION_FORMATIVA .
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaINFORME_FINAL_AF
        Try
            Dim mListaINFORME_FINAL_AF As New ListaINFORME_FINAL_AF
            mListaINFORME_FINAL_AF = mDb.ObtenerListaPorACCION_FORMATIVA(ID_ACCION_FORMATIVA, asColumnaOrden, asTipoOrden)
            If Not mListaINFORME_FINAL_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As INFORME_FINAL_AF in  mListaINFORME_FINAL_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaINFORME_FINAL_AF
            If Not mListaINFORME_FINAL_AF Is Nothing Then
                For Each lEntidad As INFORME_FINAL_AF in  mListaINFORME_FINAL_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaINFORME_FINAL_AF
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
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_AF(ByVal ID_PROVEEDOR_AF As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaINFORME_FINAL_AF
        Try
            Dim mListaINFORME_FINAL_AF As New ListaINFORME_FINAL_AF
            mListaINFORME_FINAL_AF = mDb.ObtenerListaPorPROVEEDOR_AF(ID_PROVEEDOR_AF, asColumnaOrden, asTipoOrden)
            If Not mListaINFORME_FINAL_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As INFORME_FINAL_AF in  mListaINFORME_FINAL_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaINFORME_FINAL_AF
            If Not mListaINFORME_FINAL_AF Is Nothing Then
                For Each lEntidad As INFORME_FINAL_AF in  mListaINFORME_FINAL_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaINFORME_FINAL_AF
        Catch ex as Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla ESTADO_INFORME_AF .
    ''' </summary>
    ''' <param name="ID_ESTADO_INFORME"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorESTADO_INFORME_AF(ByVal ID_ESTADO_INFORME As Decimal, ByVal Optional recuperarHijas As Boolean = False, ByVal Optional recuperarForaneas As Boolean = False, ByVal Optional asColumnaOrden As String = "", ByVal Optional asTipoOrden As String = "ASC") As ListaINFORME_FINAL_AF
        Try
            Dim mListaINFORME_FINAL_AF As New ListaINFORME_FINAL_AF
            mListaINFORME_FINAL_AF = mDb.ObtenerListaPorESTADO_INFORME_AF(ID_ESTADO_INFORME, asColumnaOrden, asTipoOrden)
            If Not mListaINFORME_FINAL_AF Is Nothing And recuperarForaneas Then
                For Each lEntidad As INFORME_FINAL_AF in  mListaINFORME_FINAL_AF
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaINFORME_FINAL_AF
            If Not mListaINFORME_FINAL_AF Is Nothing Then
                For Each lEntidad As INFORME_FINAL_AF in  mListaINFORME_FINAL_AF
                    Try
                        Me.RecuperarHijas(lEntidad)
                    Catch ex as Exception
                    End Try
                Next
            End If
            Return mListaINFORME_FINAL_AF
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
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarForaneas(ByRef aEntidad As INFORME_FINAL_AF )
        aEntidad.fkID_ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(aEntidad.ID_ACCION_FORMATIVA)
        aEntidad.fkID_PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(aEntidad.ID_PROVEEDOR_AF)
        aEntidad.fkID_ESTADO_INFORME = (New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(aEntidad.ID_ESTADO_INFORME)
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
    ''' 	[GenApp]	20/07/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub RecuperarHijas(ByRef aEntidad As INFORME_FINAL_AF )
    End Sub

#End Region

End Class
