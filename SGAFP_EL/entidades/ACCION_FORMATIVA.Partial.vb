Partial Class ACCION_FORMATIVA
    Public ReadOnly Property NOMBRE_SITIO() As String
        Get
            If Me.fkID_SITIO_CAPACITACION Is Nothing Then Return ""
            Return Me.fkID_SITIO_CAPACITACION.NOMBRE_SITIO
        End Get
    End Property
End Class
