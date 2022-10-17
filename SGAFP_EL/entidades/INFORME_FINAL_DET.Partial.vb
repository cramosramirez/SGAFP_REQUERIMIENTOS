Partial Public Class INFORME_FINAL_DET

    Private _MINUTOS_ASISTIDOS As Decimal
    Public Property MINUTOS_ASISTIDOS() As Decimal
        Get
            Return _MINUTOS_ASISTIDOS
        End Get
        Set(ByVal Value As Decimal)
            _MINUTOS_ASISTIDOS = Value
        End Set
    End Property

    Private _PORC_ASISTENCIA_ACUMULADO As Decimal
    Public Property PORC_ASISTENCIA_ACUMULADO() As Decimal
        Get
            Return _PORC_ASISTENCIA_ACUMULADO
        End Get
        Set(ByVal Value As Decimal)
            _PORC_ASISTENCIA_ACUMULADO = Value
        End Set
    End Property

    Private _ACTIVO As Boolean
    Public Property ACTIVO() As Boolean
        Get
            Return _ACTIVO
        End Get
        Set(ByVal Value As Boolean)
            _ACTIVO = Value
        End Set
    End Property

End Class
