Partial Public Class cGRUPO_SOLICITUD


    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_SOLICITUD As Decimal, ByVal TDR As String, ByVal CORRELATIVO_GRUPO As Decimal, _
                                             Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaGRUPO_SOLICITUD
        Try
            Return mDb.ObtenerListaPorCriterios(ID_SOLICITUD, TDR, CORRELATIVO_GRUPO, asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
