Partial Public Class cDISCA_SOLIC_PRESELE

    Public Function EliminarPorSolicitud(ByVal ID_SOLIC_PRESELEC As Decimal) As Integer
        Dim lista As listaDISCA_SOLIC_PRESELE = Me.ObtenerListaPorSOLICITUD_PRESELECCION_EC(ID_SOLIC_PRESELEC)

        If lista IsNot Nothing AndAlso lista.Count > 0 Then
            For i As Integer = 0 To lista.Count - 1
                Me.EliminarDISCA_SOLIC_PRESELE(lista(i).ID_DISCA_SOLIC)
            Next
        End If

        Return 1
    End Function
End Class
