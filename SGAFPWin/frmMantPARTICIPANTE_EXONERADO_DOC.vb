Public Class frmMantPARTICIPANTE_EXONERADO_DOC

    Private Sub frmMantPARTICIPANTE_EXONERADO_DOC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text += " Participantes Exonerados de Documentos de Identificación"
        Me.miMantenimiento = Me.UcMantPARTICIPANTE_EXONERADO_DOC1
        Me.UcMantPARTICIPANTE_EXONERADO_DOC1.CargarDatosPorExoneradoDocumentos()
    End Sub

End Class
