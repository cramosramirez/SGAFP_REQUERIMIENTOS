Partial Public Class cASISTENCIA_PAGO_DET

    Public Function ObtenerPORC_PAGO_POR_PORC_ASISTENCIA(ByVal ID_EJERCICIO As String, ByVal ID_MODALIDAD_FORMACION As Decimal, ByVal PORC_ASISTENCIA As Decimal) As ASISTENCIA_PAGO_DET
        Try
            Return mDb.ObtenerPORC_PAGO_POR_PORC_ASISTENCIA(ID_EJERCICIO, ID_MODALIDAD_FORMACION, PORC_ASISTENCIA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function EliminarlistaASISTENCIA_PAGO_DET(ByVal ID_ASISTE_PAGO As Decimal) As Integer
        Try
            Return mDb.EliminarlistaASISTENCIA_PAGO_DET(ID_ASISTE_PAGO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return -1
        End Try
    End Function

End Class
