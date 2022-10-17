<Serializable()> Public Class ListaCONTRATO_COMPRA_PENALIZACION
    Inherits listaBase(Of CONTRATO_COMPRA_PENALIZACION)
    Public Function BuscarPorId(ByVal ID_CONTRA_PENA As Decimal) As CONTRATO_COMPRA_PENALIZACION
        Dim i As Integer = 0
        While i < Me.Count
            Dim s As CONTRATO_COMPRA_PENALIZACION = Me(i)
            If s.ID_CONTRA_PENA = ID_CONTRA_PENA Then
                Return s
            End If
            i += 1
        End While
        Return Nothing
    End Function
End Class
