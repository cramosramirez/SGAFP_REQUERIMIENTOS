Partial Public Class cTIPO_PENALIZA

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerListaPenalizacionAutomatica(Optional ByVal asColumnaOrden As String = "", Optional ByVal asTipoOrden As String = "ASC") As listaTIPO_PENALIZA
        Try
            Dim mListaTIPO_PENALIZA As New listaTIPO_PENALIZA
            Dim lEntidad As TIPO_PENALIZA

            lEntidad = Me.ObtenerTIPO_PENALIZA(CDec(1))
            mListaTIPO_PENALIZA.Add(lEntidad)

            lEntidad = Me.ObtenerTIPO_PENALIZA(CDec(2))
            mListaTIPO_PENALIZA.Add(lEntidad)

            Return mListaTIPO_PENALIZA
        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
