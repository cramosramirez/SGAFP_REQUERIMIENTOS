

Partial Public Class SOLICITUD_INSCRIPCION_AF
    Private _NOMBRE_SITIO As String
    Public Property NOMBRE_SITIO() As String
        Get
            Return _NOMBRE_SITIO
        End Get
        Set(ByVal Value As String)
            _NOMBRE_SITIO = Value
        End Set
    End Property
End Class
