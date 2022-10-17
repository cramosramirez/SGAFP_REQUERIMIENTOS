Partial Public Class cPAIS

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros 
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	10/06/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorEjercicioProveedorSitio(ByVal ID_EJERCICIO As String, ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPAIS
        Try
            Dim mListaPAIS As New listaPAIS
            mListaPAIS = mDb.ObtenerListaPorEjercicioProveedorSitio(ID_EJERCICIO, ID_PROVEEDOR_AF, ID_SITIO_CAPACITACION, asColumnaOrden, asTipoOrden)

            Return mListaPAIS
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
