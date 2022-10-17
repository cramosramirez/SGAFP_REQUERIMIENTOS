Partial Public Class cEVALUACIONES_AF_DET
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla EVALUACION_AF Y ID_PARTICIAPANTE
    ''' </summary>
    ''' <param name="ID_ACCION_FORMATIVA"></param>
    ''' <param name="ID_PARTICIPANTE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	01/12/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerlistaPorACCION_FORMATIVA_PorPARTICIPANTE(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_PARTICIPANTE As Decimal, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaEVALUACIONES_AF_DET
        Try
            Dim mListaEVALUACIONES_AF_DET As New listaEVALUACIONES_AF_DET
            mListaEVALUACIONES_AF_DET = mDb.ObtenerlistaPorACCION_FORMATIVA_PorPARTICIPANTE(ID_ACCION_FORMATIVA, ID_PARTICIPANTE, asColumnaOrden, asTipoOrden)
            Return mListaEVALUACIONES_AF_DET

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function ObtenerListaPorEVALUACION_AF_TODO(ByVal ID_EVALUACION_AF As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaEVALUACIONES_AF_DET
        Try
            Return mDb.ObtenerListaPorEVALUACION_AF_TODO(ID_EVALUACION_AF, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
