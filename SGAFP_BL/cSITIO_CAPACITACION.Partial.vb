Partial Class cSITIO_CAPACITACION
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por el parámetro de
    ''' usuario perteneciente al técnico .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="USUARIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTECNICO(ByVal ID_PROVEEDOR_AF As Decimal, ByVal USUARIO As String, Optional ByVal recuperarHijas As Boolean = False, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "SITIO_CAPACITACION.NOMBRE_SITIO", Optional ByVal asTipoOrden As String = "ASC") As listaSITIO_CAPACITACION
        Try
            Dim mListaSITIO_CAPACITACION As New listaSITIO_CAPACITACION
            mListaSITIO_CAPACITACION = mDb.ObtenerListaPorTECNICO(ID_PROVEEDOR_AF, USUARIO, asColumnaOrden, asTipoOrden)
            If Not mListaSITIO_CAPACITACION Is Nothing And recuperarForaneas Then
                For Each lEntidad As SITIO_CAPACITACION In mListaSITIO_CAPACITACION
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            If Not recuperarHijas Then Return mListaSITIO_CAPACITACION
            
            Return mListaSITIO_CAPACITACION
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por el parámetro de
    ''' usuario perteneciente al técnico .
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	26/07/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerTECNICO_ASIGNADO(ByVal ID_SITIO_CAPACITACION As Decimal) As String
        Try
            Return mDb.ObtenerTECNICO_ASIGNADO(ID_SITIO_CAPACITACION)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por el parámetro de
    ''' usuario perteneciente al técnico .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	01/06/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_AF_DEPARTAMENTO(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                        ByVal CODIGO_DEPARTAMENTO As String, _
                                                        Optional ByVal recuperarHijas As Boolean = False, _
                                                        Optional ByVal recuperarForaneas As Boolean = False, _
                                                        Optional ByVal asColumnaOrden As String = "SITIO_CAPACITACION.NOMBRE_SITIO", _
                                                        Optional ByVal asTipoOrden As String = "ASC") As listaSITIO_CAPACITACION
        Try
            Dim mListaSITIO_CAPACITACION As New listaSITIO_CAPACITACION
            mListaSITIO_CAPACITACION = mDb.ObtenerListaPorPROVEEDOR_AF_DEPARTAMENTO(ID_PROVEEDOR_AF, CODIGO_DEPARTAMENTO, asColumnaOrden, asTipoOrden)

            Return mListaSITIO_CAPACITACION

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por el parámetro de
    ''' usuario perteneciente al técnico .
    ''' </summary>
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	07/07/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorPROVEEDOR_AF_SITIO_CAPACITACION_DEPARTAMENTO(ByVal ID_PROVEEDOR_AF As Decimal, _
                                                        ByVal ID_SITIO_CAPACITACION As Decimal, _
                                                        ByVal CODIGO_DEPARTAMENTO As String, _
                                                        Optional ByVal recuperarHijas As Boolean = False, _
                                                        Optional ByVal recuperarForaneas As Boolean = False, _
                                                        Optional ByVal asColumnaOrden As String = "SITIO_CAPACITACION.NOMBRE_SITIO", _
                                                        Optional ByVal asTipoOrden As String = "ASC") As listaSITIO_CAPACITACION
        Try
            Dim mListaSITIO_CAPACITACION As New listaSITIO_CAPACITACION
            mListaSITIO_CAPACITACION = mDb.ObtenerListaPorPROVEEDOR_AF_SITIO_CAPACITACION_DEPARTAMENTO(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, CODIGO_DEPARTAMENTO, asColumnaOrden, asTipoOrden)

            Return mListaSITIO_CAPACITACION

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function



    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades de Sitios de Capacitación filtrada por los parámetros pasados
    ''' </summary>    
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	23/07/2010	Created
    ''' 	[cramos]	11/08/2010	Modificada
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorEJERCICIO(ByVal ID_PROVEEDOR_AF As Decimal, _
                                             ByVal ID_SITIO_CAPACITACION As Decimal, _
                                             ByVal CODIGO_DEPARTAMENTO As String, _
                                             ByVal ID_EJERCICIO As String) As listaSITIO_CAPACITACION
        Try
            Dim mListaSITIO_CAPACITACION As New listaSITIO_CAPACITACION
            mListaSITIO_CAPACITACION = mDb.ObtenerListaPorEJERCICIO(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, CODIGO_DEPARTAMENTO, ID_EJERCICIO)

            Return mListaSITIO_CAPACITACION

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet de Sitios de Capacitación filtrada por los parámetros pasados
    ''' </summary>    
    ''' <param name="ID_PROVEEDOR_AF"></param>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="ID_EJERCICIO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/08/2010	Creado
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorEJERCICIO(ByVal ID_PROVEEDOR_AF As Decimal, _
                                             ByVal ID_SITIO_CAPACITACION As Decimal, _
                                             ByVal CODIGO_DEPARTAMENTO As String, _
                                             ByVal ID_EJERCICIO As String) As DataSet
        Try
            Return mDb.ObtenerDataSetPorEJERCICIO(ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, CODIGO_DEPARTAMENTO, ID_EJERCICIO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla SITIO_CAPACITACION .
    ''' </summary>
    ''' <param name="ID_SITIO_CAPACITACION"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	14/02/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorSITIO_CAPACITACION(ByVal ID_SITIO_CAPACITACION As Decimal) As listaSITIO_CAPACITACION
        Try
            Return mDb.ObtenerListaPorSITIO_CAPACITACION(ID_SITIO_CAPACITACION)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
