Partial Class OFERTA_FORMATIVA

    Private _TEMA_CURSO As String
    Public Property TEMA_CURSO() As String
        Get
            Return _TEMA_CURSO
        End Get
        Set(ByVal value As String)
            _TEMA_CURSO = value
        End Set
    End Property

    Private _ID_AREA_FORMACION As String
    Public Property ID_AREA_FORMACION() As String
        Get
            Return _ID_AREA_FORMACION
        End Get
        Set(ByVal value As String)
            _ID_AREA_FORMACION = value
        End Set
    End Property

    Private _NOMBRE_PROVEEDOR As String
    Public Property NOMBRE_PROVEEDOR() As String
        Get
            Return _NOMBRE_PROVEEDOR
        End Get
        Set(ByVal value As String)
            _NOMBRE_PROVEEDOR = value
        End Set
    End Property

    Private _NOMBRE_SITIO As String
    Public Property NOMBRE_SITIO() As String
        Get
            Return _NOMBRE_SITIO
        End Get
        Set(ByVal value As String)
            _NOMBRE_SITIO = value
        End Set
    End Property

    Private _NOMBRE_DEPARTAMENTO As String
    Public Property NOMBRE_DEPARTAMENTO() As String
        Get
            Return _NOMBRE_DEPARTAMENTO
        End Get
        Set(ByVal value As String)
            _NOMBRE_DEPARTAMENTO = value
        End Set
    End Property

    Private _NOMBRE_MUNICIPIO As String
    Public Property NOMBRE_MUNICIPIO() As String
        Get
            Return _NOMBRE_MUNICIPIO
        End Get
        Set(ByVal value As String)
            _NOMBRE_MUNICIPIO = value
        End Set
    End Property

End Class
