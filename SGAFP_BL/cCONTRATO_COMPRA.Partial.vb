Partial Public Class cCONTRATO_COMPRA


    Public Function ObtenerCONTRATO_COMPRAPorID_ACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As CONTRATO_COMPRA
        Try
            Return mDb.ObtenerCONTRATO_COMPRAPorID_ACCION_FORMATIVA(ID_ACCION_FORMATIVA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function


    Public Function ObtenerListaPorNO_CONTRATO_COMPRA(ByVal NO_CONTRATO_COMPRA As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaCONTRATO_COMPRA
        Try
            Return mDb.ObtenerListaPorNO_CONTRATO_COMPRA(NO_CONTRATO_COMPRA, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
