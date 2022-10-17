Public Class frmMotivoCambio

    Private Sub SimpleButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButtonAceptar.Click
        If Me.MemoEditMotivo.Text.Trim = "" Then
            AsignarMensaje("Escriba el Motivo", True)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
End Class