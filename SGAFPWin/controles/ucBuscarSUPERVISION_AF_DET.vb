Imports SGAFP.EL
Public Class ucBuscarSUPERVISION_AF_DET

    Public Event Seleccionado(ByVal ID_SUPERVISION_DET As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaSUPERVISION_AF_DET1 As New listaSUPERVISION_AF_DET
        listaSUPERVISION_AF_DET1 = CType((New cSUPERVISION_AF_DET).ObtenerListaPorBusqueda(New SUPERVISION_AF_DET, Me.CriteriaList.ToArray()), listaSUPERVISION_AF_DET)
        Me.UcListaSUPERVISION_AF_DET1.CargarDatosPorLista(listaSUPERVISION_AF_DET1)
    End Sub

    Private Sub UcListaSUPERVISION_AF_DET1_Seleccionado(ByVal ID_SUPERVISION_DET As Decimal) Handles UcListaSUPERVISION_AF_DET1.Seleccionado
        RaiseEvent Seleccionado(ID_SUPERVISION_DET)
    End Sub

End Class
