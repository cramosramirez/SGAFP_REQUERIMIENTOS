Partial Public Class cAREA_FORMACION_CONTRA


    Public Function ObtenerAREA_FORMACION_CONTRAPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As AREA_FORMACION_CONTRA
        Try
            Return mDb.ObtenerAREA_FORMACION_CONTRAPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerMontoEjecutadoPorAreaContratada(ByVal ID_AREA_CONTRA As Decimal) As Decimal

        Try
            Return mDb.ObtenerMontoEjecutadoPorAreaContratada(ID_AREA_CONTRA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function ObtenerParticipacionesEjecutadasPorAreaContratada(ByVal ID_AREA_CONTRA As Decimal) As Decimal

        Try
            Return mDb.ObtenerParticipacionesEjecutadasPorAreaContratada(ID_AREA_CONTRA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
