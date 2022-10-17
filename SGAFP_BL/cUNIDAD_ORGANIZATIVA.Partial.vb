Partial Public Class cUNIDAD_ORGANIZATIVA


    Public Function ObtenerUNIDAD_ORGANIZATIVAPorAccionFormativa(ByVal ID_ACCION_FORMATIVA As Decimal) As UNIDAD_ORGANIZATIVA
        Try
            Return mDb.ObtenerUNIDAD_ORGANIZATIVAPorAccionFormativa(ID_ACCION_FORMATIVA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    Public Function EsDeUnidaOrganizativa(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal CODIGO_UNIDAD As String) As Boolean
        Try
            Dim lEntidad As UNIDAD_ORGANIZATIVA = mDb.ObtenerUNIDAD_ORGANIZATIVAPorAccionFormativa(ID_ACCION_FORMATIVA)
            If lEntidad IsNot Nothing Then
                If lEntidad.CODIGO_UNIDAD = CODIGO_UNIDAD Then Return True Else Return False
            End If
            Return False

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return False
        End Try
    End Function

    Public Function ObtenerListaPorActivas(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaUNIDAD_ORGANIZATIVA
        Try
            Return mDb.ObtenerListaPorActivas(asColumnaOrden, asTipoOrden)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
