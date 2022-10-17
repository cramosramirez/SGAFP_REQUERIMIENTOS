Partial Public Class ACCION_FORMATIVA_DETALLE

    Public Sub New()
        _ID_GRUPO_SELEC = -1
        _ID_UNIDAD_ORGANIZATIVA = -1
    End Sub

    Private _ID_GRUPO_SELEC As Decimal
    <Column(Name:="Id grupo selec", Storage:="ID_GRUPO_SELEC", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_GRUPO_SELEC() As Decimal
        Get
            Return _ID_GRUPO_SELEC
        End Get
        Set(ByVal Value As Decimal)
            If Value = 0 Then
                _ID_GRUPO_SELEC = -1
            Else
                _ID_GRUPO_SELEC = Value
            End If
            OnPropertyChanged("ID_GRUPO_SELEC")
        End Set
    End Property

    Private _ID_GRUPO_SELECOld As Decimal
    Public Property ID_GRUPO_SELECOld() As Decimal
        Get
            Return _ID_GRUPO_SELECOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_GRUPO_SELECOld = Value
        End Set
    End Property

    Private _ID_UNIDAD_ORGANIZATIVA As Decimal
    <Column(Name:="ID_UNIDAD_ORGANIZATIVA", Storage:="ID_UNIDAD_ORGANIZATIVA", DbType:="NUMBER", Id:=False), _
     DataObjectField(False, False, True), Precision(Precision:=0, Scale:=0)> _
    Public Property ID_UNIDAD_ORGANIZATIVA() As Decimal
        Get
            Return _ID_UNIDAD_ORGANIZATIVA
        End Get
        Set(ByVal Value As Decimal)
            If Value = 0 Then
                _ID_UNIDAD_ORGANIZATIVA = -1
            Else
                _ID_UNIDAD_ORGANIZATIVA = Value
            End If
            OnPropertyChanged("ID_UNIDAD_ORGANIZATIVA")
        End Set
    End Property

    Private _ID_UNIDAD_ORGANIZATIVAOld As Decimal
    Public Property ID_UNIDAD_ORGANIZATIVAOld() As Decimal
        Get
            Return _ID_UNIDAD_ORGANIZATIVAOld
        End Get
        Set(ByVal Value As Decimal)
            _ID_UNIDAD_ORGANIZATIVAOld = Value
        End Set
    End Property

End Class
