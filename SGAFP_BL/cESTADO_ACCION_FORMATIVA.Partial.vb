Partial Public Class cESTADO_ACCION_FORMATIVA

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Devuelve una Colección de Entidades para el proceso de Calendarización
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	14/03/2011	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaParaCalenzarizacion() As listaESTADO_ACCION_FORMATIVA
        Try
            Dim mLista As New listaESTADO_ACCION_FORMATIVA

            mLista.Add(New ESTADO_ACCION_FORMATIVA(Enumeradores.EstadoAccionFormativa.Ingresada, "INGRESADO", 0, 0, 0, ""))
            mLista.Add(New ESTADO_ACCION_FORMATIVA(Enumeradores.EstadoAccionFormativa.EnMatricula, "EN MATRICULA", 0, 0, 0, ""))
            mLista.Add(New ESTADO_ACCION_FORMATIVA(Enumeradores.EstadoAccionFormativa.Iniciada, "INICIADO", 0, 0, 0, ""))
            mLista.Add(New ESTADO_ACCION_FORMATIVA(Enumeradores.EstadoAccionFormativa.EnSolicitudDeReprogramacion, "EN SOLICITUD DE REPROGRAMACION", 0, 0, 0, ""))
            mLista.Add(New ESTADO_ACCION_FORMATIVA(Enumeradores.EstadoAccionFormativa.Finalizada, "FINALIZADO", 0, 0, 0, ""))
            Return mLista

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
