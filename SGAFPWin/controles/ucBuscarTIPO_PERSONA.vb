Imports SGAFP.EL
Public Class ucBuscarTIPO_PERSONA

    Public Event Seleccionado(ByVal ID_TIPO_PERSONA As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaTIPO_PERSONA1 As New listaTIPO_PERSONA
        listaTIPO_PERSONA1 = CType((New cTIPO_PERSONA).ObtenerListaPorBusqueda(New TIPO_PERSONA, Me.CriteriaList.ToArray()), listaTIPO_PERSONA)
        Me.UcListaTIPO_PERSONA1.CargarDatosPorLista(listaTIPO_PERSONA1)
    End Sub

    Private Sub UcListaTIPO_PERSONA1_Seleccionado(ByVal ID_TIPO_PERSONA As Decimal) Handles UcListaTIPO_PERSONA1.Seleccionado
        RaiseEvent Seleccionado(ID_TIPO_PERSONA)
    End Sub

End Class
