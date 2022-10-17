Partial Public Class cFASE_MUNICIPIOS



    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la Tabla FUENTE_FINANCIAMIENTO, FASE, DEPARTAMENTO .
    ''' </summary>
    ''' <param name="CODIGO_REGION"></param>
    ''' <param name="CODIGO_DEPARTAMENTO"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	08/07/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorFUENTE_FINANCIAMIENTO_FASE_DEPARTAMENTO(ByVal ID_FUENTE As Decimal, _
                                                            ByVal ID_FASE As Decimal, _
                                                            ByVal CODIGO_REGION As String, _
                                                            ByVal CODIGO_DEPARTAMENTO As String, _
                                                            Optional ByVal asColumnaOrden As String = "", _
                                                            Optional ByVal asTipoOrden As String = "ASC") As listaFASE_MUNICIPIOS
        Try
            Dim mListaFASE_MUNICIPIOS As New listaFASE_MUNICIPIOS
            mListaFASE_MUNICIPIOS = mDb.ObtenerListaPorFUENTE_FINANCIAMIENTO_FASE_DEPARTAMENTO(ID_FUENTE, ID_FASE, CODIGO_REGION, CODIGO_DEPARTAMENTO, asColumnaOrden, asTipoOrden)

            For Each lEntidad As FASE_MUNICIPIOS In mListaFASE_MUNICIPIOS
                Try
                    Me.RecuperarForaneas(lEntidad)
                Catch ex As Exception
                End Try
            Next

            Return mListaFASE_MUNICIPIOS
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
