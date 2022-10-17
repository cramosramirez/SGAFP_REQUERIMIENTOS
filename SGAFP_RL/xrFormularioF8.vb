Public Class xrFormularioF8

    Public Sub CargarDatos(ByVal TDR As String)
        Me.DS_DL1.Clear()
        Me.FormularioF8TableAdapter1.Fill(Me.DS_DL1.FormularioF8, TDR)
    End Sub

    'Private Sub xrReporteF8_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint
    '    Me.FormularioF8TableAdapter1.Fill(Me.DS_DL1.FormularioF8, "01052003333         ")
    'End Sub

End Class