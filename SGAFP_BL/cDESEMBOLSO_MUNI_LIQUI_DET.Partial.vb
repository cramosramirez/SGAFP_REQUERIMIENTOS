Partial Public Class cDESEMBOLSO_MUNI_LIQUI_DET
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Foranea, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <param name="ID_DESEMBOLSO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	11/05/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorDESEMBOLSO_LIQUIDACION_DET(ByVal ID_DESEMBOLSO As Decimal, ByVal ID_LIQUIDACION_DET As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaDESEMBOLSO_MUNI_LIQUI_DET
        Try
            Dim mListaDESEMBOLSO_MUNI_LIQUI_DET As New listaDESEMBOLSO_MUNI_LIQUI_DET
            mListaDESEMBOLSO_MUNI_LIQUI_DET = mDb.ObtenerListaPorDESEMBOLSO_LIQUIDACION_DET(ID_DESEMBOLSO, ID_LIQUIDACION_DET, asColumnaOrden, asTipoOrden)
            Return mListaDESEMBOLSO_MUNI_LIQUI_DET
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
