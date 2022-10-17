Partial Public Class cCOMPRA_EX_PAGO_ASISTE

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ObtenerCOMPRA_EX_PAGO_ASISTE_PorCriterios(ByVal REFERENCIA As String, _
                                                            ByVal ID_TIPO_CONTRA As Decimal) As listaCOMPRA_EX_PAGO_ASISTE
        Try
            Return mDb.ObtenerCOMPRA_EX_PAGO_ASISTE_PorCriterios(REFERENCIA, ID_TIPO_CONTRA)

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            Return Nothing
        End Try
    End Function
End Class
