Partial Public Class ASISTENCIA_AF_DET

    Private _HORAS_ASISTENCIA As Decimal
    <Column(Name:="Id asistencia af", Storage:="HORAS_ASISTENCIA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=8, Scale:=0)> _
    Public Property HORAS_ASISTENCIA() As Decimal
        Get
            Return _HORAS_ASISTENCIA
        End Get
        Set(ByVal Value As Decimal)
            _HORAS_ASISTENCIA = Value
            OnPropertyChanged("HORAS_ASISTENCIA")
        End Set
    End Property
End Class
