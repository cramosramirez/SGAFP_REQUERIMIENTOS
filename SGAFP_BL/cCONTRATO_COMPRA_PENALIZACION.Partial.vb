Partial Public Class cCONTRATO_COMPRA_PENALIZACION

    Public Function ObtenerRANGO_PORC_PENA_PorDIAS(ByVal ID_CONTRATO_COMPRA As Decimal, ByVal DIAS_TRANSCURRIDOS As Integer, ByVal ID_TIPO_PENA As Decimal) As CONTRATO_COMPRA_PENALIZACION
        Try
            Return mDb.ObtenerRANGO_PORC_PENA_PorDIAS(ID_CONTRATO_COMPRA, DIAS_TRANSCURRIDOS, ID_TIPO_PENA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function EliminarlistaCONTRATO_COMPRA_PENALIZACION(ByVal ID_CONTRATO_COMPRA As Decimal) As Integer
        Try
            Return mDb.EliminarlistaCONTRATO_COMPRA_PENALIZACION(ID_CONTRATO_COMPRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function
End Class
