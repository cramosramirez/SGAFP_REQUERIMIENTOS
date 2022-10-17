Partial Public Class cMUNICIPIO_CONVOCATORIA

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros
    ''' </summary>
    ''' <param name="ID_FUENTE"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <param name="CODIGO_MUNICIPIO"></param>
    ''' <param name="NO_CONVOCATORIA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	12/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_FUENTE As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String, ByVal NO_CONVOCATORIA As Decimal) As listaMUNICIPIO_CONVOCATORIA
        Try
            Dim mListaMUNICIPIO_CONVOCATORIA As New listaMUNICIPIO_CONVOCATORIA
            mListaMUNICIPIO_CONVOCATORIA = mDb.ObtenerListaPorCriterios(ID_FUENTE, CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO, NO_CONVOCATORIA)
            Return mListaMUNICIPIO_CONVOCATORIA

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
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
    ''' 	[GenApp]	10/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerDataSetPorCriterios(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, ByVal CODIGO_MUNICIPIO As String) As DataSet
        Try
            Return mDb.ObtenerDataSetPorCriterios(ID_FUENTE, NO_CONVOCATORIA, CODIGO_DEPARTAMENTO, CODIGO_MUNICIPIO)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	27/09/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorFUENTE_CONVOCATORIA(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal) As listaMUNICIPIO_CONVOCATORIA
        Try
            Return mDb.ObtenerListaPorFUENTE_CONVOCATORIA(ID_FUENTE, NO_CONVOCATORIA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    '''' -----------------------------------------------------------------------------
    '''' <summary>
    '''' Función que Devuelve las Fechas de Elaboración de la Liquidación filtrada por los parámetros siguientes
    '''' </summary>
    '''' <param name="ID_FUENTE"></param>
    '''' <param name="NO_CONVOCATORIA"></param>
    '''' <remarks>
    '''' </remarks>
    '''' <history>
    '''' 	[cramos]	27/09/2011	Created
    '''' </history>
    '''' -----------------------------------------------------------------------------
    Public Function ObtenerFechasLiquidacionPorFUENTE_CONVOCATORIA(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal) As DataSet
        Try
            Return mDb.ObtenerFechasLiquidacionPorFUENTE_CONVOCATORIA(ID_FUENTE, NO_CONVOCATORIA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
