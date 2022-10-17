Partial Public Class cINFORME_FINAL_DET

    Public Function ObtenerListaPorInformeIdParticipante(ByVal ID_INFORME_FINAL As Decimal, _
                                            ByVal ID_PARTICIPANTE As Decimal, _
                                            Optional ByVal asColumnaOrden As String = "", _
                                            Optional ByVal asTipoOrden As String = "ASC") As listaINFORME_FINAL_DET
        Try
            Return mDb.ObtenerListaPorInformeIdParticipante(ID_INFORME_FINAL, ID_PARTICIPANTE, asColumnaOrden, asTipoOrden)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
