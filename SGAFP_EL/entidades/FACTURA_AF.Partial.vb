Partial Public Class FACTURA_AF
#Region " Relaciones "
    Private _FACTURA_AFACCION_FORMATIVA As listaACCION_FORMATIVA
    <DataMember()> _
    Public Property FACTURA_AFACCION_FORMATIVA() As listaACCION_FORMATIVA
        Get
            Return _FACTURA_AFACCION_FORMATIVA
        End Get
        Set(ByVal Value As listaACCION_FORMATIVA)
            _FACTURA_AFACCION_FORMATIVA = Value
        End Set
    End Property

    Private _FACTURA_AF_INFORME_FINAL_AF As listaINFORME_FINAL_AF
    <DataMember()> _
    Public Property FACTURA_AF_INFORME_FINAL_AF() As listaINFORME_FINAL_AF
        Get
            Return _FACTURA_AF_INFORME_FINAL_AF
        End Get
        Set(ByVal Value As listaINFORME_FINAL_AF)
            _FACTURA_AF_INFORME_FINAL_AF = Value
        End Set
    End Property

#End Region
End Class
