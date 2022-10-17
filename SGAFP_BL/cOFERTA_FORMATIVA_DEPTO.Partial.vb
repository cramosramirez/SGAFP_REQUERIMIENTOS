Partial Public Class cOFERTA_FORMATIVA_DEPTO
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve la Participacion y el Monto Adjudicado por Oferta Formativa y Departamento
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	24/01/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerParticipacionMontoAdjudicadoPorOfertaDepartamento(ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal CODIGO_DEPARTAMENTO As String) As Dictionary(Of String, Decimal)
        Try
            Return mDb.ObtenerParticipacionMontoAdjudicadoPorOfertaDepartamento(ID_OFERTA_FORMATIVA, CODIGO_DEPARTAMENTO)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve la Participacion y el Monto Ejecutado por Oferta Formativa y Departamento  
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	04/12/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerParticipacionMontoEjecutadoPorOfertaDepartamento(ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal CODIGO_DEPARTAMENTO As String, Optional ByVal ID_ACCION_FORMATIVA_NO_INCLUIR As Decimal = -1) As Dictionary(Of String, Decimal)
        Try
            Return mDb.ObtenerParticipacionMontoEjecutadoPorOfertaDepartamento(ID_OFERTA_FORMATIVA, CODIGO_DEPARTAMENTO, ID_ACCION_FORMATIVA_NO_INCLUIR)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

End Class
