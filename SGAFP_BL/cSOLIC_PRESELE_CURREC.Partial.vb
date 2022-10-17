Partial Public Class cSOLIC_PRESELE_CURREC

    Public Function EliminarPorSolicitud(ByVal ID_SOLIC_PRESELEC As Decimal) As Integer
        Dim lista As listaSOLIC_PRESELE_CURREC = Me.ObtenerListaPorSOLICITUD_PRESELECCION_EC(ID_SOLIC_PRESELEC)

        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For i As Integer = 0 To lista.Count - 1
                Me.EliminarSOLIC_PRESELE_CURREC(lista(i).ID_PRESELE_CURREC)
            Next
        End If

        Return 1
    End Function

End Class
