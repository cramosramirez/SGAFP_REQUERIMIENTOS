Partial Public Class cCURSO_TEMA

    Public Function ObtenerListaPorCODIGO_PROGRAMA(ByVal CODIGO_PROGRAMA As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCURSO_TEMA
        Try

            Return mDb.ObtenerListaPorCODIGO_PROGRAMA(CODIGO_PROGRAMA, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function ObtenerListaPorTEMA_CURSO(ByVal TEMA_CURSO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCURSO_TEMA
        Try

            Return mDb.ObtenerListaPorTEMA_CURSO(TEMA_CURSO, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
