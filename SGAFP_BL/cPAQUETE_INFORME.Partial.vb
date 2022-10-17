Partial Public Class cPAQUETE_INFORME

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	31/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorTecnico(ByVal USUARIO_TECNICO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPAQUETE_INFORME
        Try
            Dim mListaPAQUETE_INFORME As New listaPAQUETE_INFORME
            mListaPAQUETE_INFORME = mDb.ObtenerListaPorTecnico(USUARIO_TECNICO, asColumnaOrden, asTipoOrden)
            Return mListaPAQUETE_INFORME

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla Padre, si no tiene una tabla Padre devuelve todos los registros.
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	15/06/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerListaPorCriterios(ByVal ID_PAQUETE As Decimal, ByVal FECHA As Object, ByVal USUARIO_TECNICO As String, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPAQUETE_INFORME
        Try
            Dim mListaPAQUETE_INFORME As New listaPAQUETE_INFORME
            mListaPAQUETE_INFORME = mDb.ObtenerListaPorCriterios(ID_PAQUETE, FECHA, USUARIO_TECNICO, asColumnaOrden, asTipoOrden)
            Return mListaPAQUETE_INFORME

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
