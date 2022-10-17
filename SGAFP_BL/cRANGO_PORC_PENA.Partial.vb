Partial Public Class cRANGO_PORC_PENA

    Public Function ObtenerRANGO_PORC_PENA_PorDIAS(ByVal DIAS_TRANSCURRIDOS As Integer, ByVal ID_TIPO_PENA As Decimal, ByVal ID_PROGRAMA_FORMACION As Decimal) As RANGO_PORC_PENA
        Try
            Return mDb.ObtenerRANGO_PORC_PENA_PorDIAS(DIAS_TRANSCURRIDOS, ID_TIPO_PENA, ID_PROGRAMA_FORMACION)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
    Public Function ObtenerListaPorPROGRAMA_FORMACION(ByVal ID_PROGRAMA_FORMACION As Decimal) As listaRANGO_PORC_PENA
        Try
            Return mDb.ObtenerListaPorPROGRAMA_FORMACION(ID_PROGRAMA_FORMACION)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
