Public Class cEjecucionReporte
    Inherits controladorBase

    Public Function RecuperarParticipantesActivos(ByVal NO_CONVOCATORIA As Decimal, ByVal ID_FUENTE As Decimal, ByVal ds As DS_DL) As Integer
        Try
            Dim db As New dbEjecucionReporte
            Return db.RecuperarParticipantesActivos(NO_CONVOCATORIA, ID_FUENTE, ds)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Me.sError = ex.Message
        End Try
        Return -1
    End Function

End Class
