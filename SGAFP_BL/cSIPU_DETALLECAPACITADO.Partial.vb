Partial Public Class cSIPU_DETALLECAPACITADO
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve un DataSet filtrado por los parámetros de la Tabla Padre,
    ''' si no tiene una tabla Padre devuelve todos los registros de la Entidad.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	31/10/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerDataSetSIPU_DETALLECAPACITADO(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal) As DataSet
        Try
            Return mDb.ObtenerDataSetSIPU_DETALLECAPACITADO(ID_FUENTE, NO_CONVOCATORIA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function AgregarLotePorFuenteConvocatoria(ByVal ID_FUENTE As Decimal, ByVal NO_CONVOCATORIA As Decimal) As Integer
        Try
            Return mDb.AgregarLotePorFuenteConvocatoria(ID_FUENTE, NO_CONVOCATORIA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
