Public Class cReportes

    Public Shared Function ObtenerSOLIC_INGRESADAS() As DataSet
        Dim ds As New DL.DS_DL
        Dim da As New DL.DS_DLTableAdapters.VSOLIC_INGRESADASTableAdapter
        da.Fill(ds.VSOLIC_INGRESADAS)
        Return ds
    End Function

    Public Shared Function ObtenerSOLIC_INGRESADASOPorCriterios(ByVal ID_EJERCICIO As String, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_AREA_FORMACION As Decimal, ByVal CODIGO_GRUPO As String, ByVal CODIGO_ESTADO_AF As String, ByVal ID_ESTADO_SOLICITUD As Decimal) As DataSet
        Dim ds As New DL.DS_DL
        Dim da As New DL.DS_DLTableAdapters.VSOLIC_INGRESADASTableAdapter
        da.FillByCriterios(ds.VSOLIC_INGRESADAS, ID_PROVEEDOR_AF, ID_EJERCICIO, ID_AREA_FORMACION, CODIGO_GRUPO, ID_ESTADO_SOLICITUD, CODIGO_ESTADO_AF)
        Return ds
    End Function

End Class
