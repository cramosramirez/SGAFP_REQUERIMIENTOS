Imports SGAFP.EL
Public Class ucBuscarTIPO_CONTRATACION

    Public Event Seleccionado(ByVal ID_TIPO_CONTRA As Decimal) 

    Protected Overrides Sub Buscar()
        Dim listaTIPO_CONTRATACION1 As New listaTIPO_CONTRATACION
        listaTIPO_CONTRATACION1 = CType((New cTIPO_CONTRATACION).ObtenerListaPorBusqueda(New TIPO_CONTRATACION, Me.CriteriaList.ToArray()), listaTIPO_CONTRATACION)
        Me.UcListaTIPO_CONTRATACION1.CargarDatosPorLista(listaTIPO_CONTRATACION1)
    End Sub

    Private Sub UcListaTIPO_CONTRATACION1_Seleccionado(ByVal ID_TIPO_CONTRA As Decimal) Handles UcListaTIPO_CONTRATACION1.Seleccionado
        RaiseEvent Seleccionado(ID_TIPO_CONTRA)
    End Sub

End Class
