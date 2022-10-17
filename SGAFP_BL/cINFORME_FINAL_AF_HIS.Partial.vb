Partial Public Class cINFORME_FINAL_AF_HIS

    Public Function ObtenerUltimoRegistroEstado(ByVal ID_INFORME_FINAL As Decimal, ByVal ID_ESTADO_INFORME As Decimal) As INFORME_FINAL_AF_HIS
        Try
            Return mDb.ObtenerUltimoRegistroEstado(ID_INFORME_FINAL, ID_ESTADO_INFORME)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
