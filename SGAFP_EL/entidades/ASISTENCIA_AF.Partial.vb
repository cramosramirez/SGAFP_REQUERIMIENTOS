''' <summary>
''' Clase Partial que implementa la Asistencia por Horas
''' </summary>
''' <remarks>
''' [cramos] 23/09/2010
''' </remarks>
Partial Public Class ASISTENCIA_AF

    Private _CANTIDAD_HORAS As Decimal
    <Column(Name:="Cantidad horas", Storage:="CANTIDAD_HORAS", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property CANTIDAD_HORAS() As Decimal
        Get
            Return _CANTIDAD_HORAS
        End Get
        Set(ByVal Value As Decimal)
            _CANTIDAD_HORAS = Value
        End Set
    End Property

End Class
