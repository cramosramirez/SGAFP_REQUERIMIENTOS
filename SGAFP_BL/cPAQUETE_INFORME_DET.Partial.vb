Partial Public Class cPAQUETE_INFORME_DET

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla PAQUETE_INFORME .
    ''' </summary>
    ''' <param name="ID_PAQUETE"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	26/08/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorID_PAQUETE_CODIGO_ESTADO_AF(ByVal ID_PAQUETE As Decimal, ByVal ID_ESTADO_INFORME As Decimal, Optional ByVal recuperarForaneas As Boolean = False, Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaPAQUETE_INFORME_DET
        Try

            Dim mListaPAQUETE_INFORME_DET As New listaPAQUETE_INFORME_DET
            mListaPAQUETE_INFORME_DET = mDb.ObtenerListaPorID_PAQUETE_CODIGO_ESTADO_AF(ID_PAQUETE, ID_ESTADO_INFORME, asColumnaOrden, asTipoOrden)
            If Not mListaPAQUETE_INFORME_DET Is Nothing And recuperarForaneas Then
                For Each lEntidad As PAQUETE_INFORME_DET In mListaPAQUETE_INFORME_DET
                    Try
                        Me.RecuperarForaneas(lEntidad)
                    Catch ex As Exception
                    End Try
                Next
            End If
            Return mListaPAQUETE_INFORME_DET
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
