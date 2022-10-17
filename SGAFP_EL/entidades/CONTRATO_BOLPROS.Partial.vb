Partial Public Class CONTRATO_BOLPROS

    Private _DESCRIPCION_CONTRATO As String
    Public Property DESCRIPCION_CONTRATO() As String
        Get
            Return _DESCRIPCION_CONTRATO
        End Get
        Set(ByVal Value As String)
            _DESCRIPCION_CONTRATO = Value
        End Set
    End Property

End Class
