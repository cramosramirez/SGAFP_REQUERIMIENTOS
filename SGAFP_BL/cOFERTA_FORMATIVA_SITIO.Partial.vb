Partial Public Class cOFERTA_FORMATIVA_SITIO

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que devuelve la Participacion y el Monto Ejecutado por Oferta Formativa y Sitio de Capacitación  
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	13/03/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function ObtenerParticipacionMontoEjecutadoPorOfertaSitio(ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal, Optional ByVal ID_ACCION_FORMATIVA_NO_INCLUIR As Decimal = -1) As Dictionary(Of String, Decimal)
        Try
            Return mDb.ObtenerParticipacionMontoEjecutadoPorOfertaSitio(ID_OFERTA_FORMATIVA, ID_SITIO_CAPACITACION, ID_ACCION_FORMATIVA_NO_INCLUIR)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades filtrada por los parámetros de
    ''' la OFERTA_FORMATIVA y SITIO_CAPACITACION.
    ''' </summary>
    ''' <param name="ID_OFERTA_FORMATIVA"></param>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	13/03/2014	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPorOFERTA_FORMATIVA_SITIO_CAPACITACION(ByVal ID_OFERTA_FORMATIVA As Decimal, ByVal ID_SITIO_CAPACITACION As Decimal) As listaOFERTA_FORMATIVA_SITIO
        Try
            Dim mListaOFERTA_FORMATIVA_SITIO As New listaOFERTA_FORMATIVA_SITIO
            Dim lEntidad As New OFERTA_FORMATIVA_SITIO
            Dim Criterios As New List(Of Criteria)

            lEntidad.ID_OFERTA_FORMATIVA = ID_OFERTA_FORMATIVA
            lEntidad.ID_SITIO_CAPACITACION = ID_SITIO_CAPACITACION
            Criterios.Add(New Criteria("ID_OFERTA_FORMATIVA", "=", ID_OFERTA_FORMATIVA, "AND"))
            Criterios.Add(New Criteria("ID_SITIO_CAPACITACION", "=", ID_SITIO_CAPACITACION, ""))
            mListaOFERTA_FORMATIVA_SITIO = Me.ObtenerListaPorBusqueda(lEntidad, Criterios.ToArray)
            
            Return mListaOFERTA_FORMATIVA_SITIO
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
