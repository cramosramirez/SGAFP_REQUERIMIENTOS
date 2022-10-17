Partial Class PARTICIPANTE

    Public ReadOnly Property NombresApellidos() As String
        Get
            Return Me.NOMBRES + ", " + Me.APELLIDOS
        End Get
    End Property

    Public ReadOnly Property ApellidosNombres() As String
        Get
            Return Me.APELLIDOS + ", " + Me.NOMBRES
        End Get
    End Property

End Class
