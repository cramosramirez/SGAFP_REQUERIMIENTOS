Partial Public Class DESEMBOLSO
    Dim _MONTO_APLICADO As Decimal
    Public Property MONTO_APLICADO() As Decimal
        Get
            Return _MONTO_APLICADO
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_APLICADO = Value
        End Set
    End Property

    Dim _MONTO_DIFERENCIA As Decimal
    Public Property MONTO_DIFERENCIA() As Decimal
        Get
            Return _MONTO_DIFERENCIA
        End Get
        Set(ByVal Value As Decimal)
            _MONTO_DIFERENCIA = Value
        End Set
    End Property
End Class
