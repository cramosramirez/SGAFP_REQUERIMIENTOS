Imports SGAFP.EL
Public Class ucBuscarSUPERVISION_AF

    Public Event Seleccionado(ByVal ID_SUPERVISION_AF As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaSUPERVISION_AF1 As New listaSUPERVISION_AF
        listaSUPERVISION_AF1 = CType((New cSUPERVISION_AF).ObtenerListaPorBusqueda(New SUPERVISION_AF, Me.CriteriaList.ToArray()), listaSUPERVISION_AF)
        Me.UcListaSUPERVISION_AF1.CargarDatosPorLista(listaSUPERVISION_AF1)
    End Sub

    Private Sub UcListaSUPERVISION_AF1_Seleccionado(ByVal ID_SUPERVISION_AF As Decimal) Handles UcListaSUPERVISION_AF1.Seleccionado
        RaiseEvent Seleccionado(ID_SUPERVISION_AF)
    End Sub

End Class
