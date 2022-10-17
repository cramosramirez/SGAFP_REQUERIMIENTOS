Public Class ucCalendarioDeCursos

    Private Sub ucCalendarioDeCursos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.DesignMode Then Return
        Me.CbxPROVEEDOR_AF1.Recuperar(False, True)
        Me.CbxSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.CbxPROVEEDOR_AF1.SelectedValue, True)
        Me.CbxAREA_FORMACION1.Recuperar(True)
        Me.CbxAREA_FORMACION1.SelectedValue = -1
        Me.CbxEJERCICIO1.Recuperar(True)
        Me.CbxESTADO_ACCION_FORMATIVA1.Recuperar(True)
        Me.AgregarOpcion("Recuperar", "Recuperar", My.Resources.DB, True)
    End Sub

    Public Overrides Sub EjecutarOpcion(ByVal asComando As String)
        If asComando = "Recuperar" Then
            Me.Recuperar()
        End If
    End Sub

    Private Sub Recuperar()
        Me.ACCIONFORMATIVABindingSource.DataSource = (New cACCION_FORMATIVA).ObtenerListaPorCriteriosPeriodoEstado(Me.CbxPROVEEDOR_AF1.SelectedValue, Me.CbxSITIO_CAPACITACION1.SelectedValue, Me.CbxAREA_FORMACION1.SelectedValue, "", "", Me.CbxESTADO_ACCION_FORMATIVA1.SelectedValue, Me.CbxEJERCICIO1.SelectedValue, "")
    End Sub

    Private Sub CbxPROVEEDOR_AF1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxPROVEEDOR_AF1.SelectedIndexChanged
        Me.CbxSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.CbxPROVEEDOR_AF1.SelectedValue, True)
    End Sub
End Class
