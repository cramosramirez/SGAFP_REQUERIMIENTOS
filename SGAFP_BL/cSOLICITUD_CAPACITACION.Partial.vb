Partial Public Class cSOLICITUD_CAPACITACION
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	15/02/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorCriterios(ByVal ID_REFERENTE As Decimal, ByVal ID_PROYECTO_FORMACION As Decimal, _
                                             ByVal FECHA_SOLICITUD As System.Nullable(Of Date), ByVal TDR As String, _
                                             Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaSOLICITUD_CAPACITACION
        Try
            Return mDb.ObtenerListaPorCriterios(ID_REFERENTE, ID_PROYECTO_FORMACION, FECHA_SOLICITUD, TDR)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que permite buscar por los parametros recibidos.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	15/02/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
   Public Function ObtenerPorACCION_FORMATIVA(ByVal ID_ACCION_FORMATIVA As Decimal) As SOLICITUD_CAPACITACION
        Try
            Return mDb.ObtenerPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
