Public Class frmMantACCION_CONTRATADA

    Private Sub frmMantACCION_CONTRATADA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "Cursos Contratados en BOLPROS"
        Me.miMantenimiento = Me.UcMantACCION_CONTRATADA1
    End Sub

    Public Sub CargarAccionesPorContrato(ByVal ID_PROVEEDOR_AF As Decimal, ByVal ID_PROGRAMA_FORMACION As Decimal, ByVal NUM_CONTRATO As String)
        Me.UcMantACCION_CONTRATADA1.Inicializar()
        Me.UcMantACCION_CONTRATADA1.UcListaACCION_CONTRATADA1.CbxPROVEEDOR_AF1.SelectedValue = ID_PROVEEDOR_AF
        Me.UcMantACCION_CONTRATADA1.UcListaACCION_CONTRATADA1.CbxPROGRAMA_FORMACION1.SelectedValue = ID_PROGRAMA_FORMACION
        Me.UcMantACCION_CONTRATADA1.UcListaACCION_CONTRATADA1.TextEditNUM_CONTRATO.Text = NUM_CONTRATO
        Me.UcMantACCION_CONTRATADA1.UcListaACCION_CONTRATADA1.CargarDatosPorCriterios()
    End Sub

    Public Sub CargarAccionesPorContrato(ByVal ID_CONTRATO As Decimal)
        Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(ID_CONTRATO)

        Me.UcMantACCION_CONTRATADA1.Inicializar()
        If lContrato IsNot Nothing Then
            Me.UcMantACCION_CONTRATADA1.ID_CONTRATO = ID_CONTRATO
            Me.UcMantACCION_CONTRATADA1.UcListaACCION_CONTRATADA1.CargarDatosPorCONTRATO_BOLPROS(ID_CONTRATO)
        End If
    End Sub
End Class
