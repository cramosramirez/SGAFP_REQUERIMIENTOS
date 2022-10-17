Imports SGAFP.EL
Public Class ucBuscarMUNICIPIO

    Public Event Seleccionado(ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String) 

    Protected Overrides Sub Buscar()
        Dim listaMUNICIPIO1 As New listaMUNICIPIO
        listaMUNICIPIO1 = CType((New cMUNICIPIO).ObtenerListaPorBusqueda(New MUNICIPIO, Me.CriteriaList.ToArray()), listaMUNICIPIO)
        Me.UcListaMUNICIPIO1.CargarDatosPorLista(listaMUNICIPIO1)
    End Sub

    Private Sub UcListaMUNICIPIO1_Seleccionado(ByVal CODIGO_MUNICIPIO As String, ByVal CODIGO_REGION As String, ByVal CODIGO_DEPARTAMENTO As String) Handles UcListaMUNICIPIO1.Seleccionado
        RaiseEvent Seleccionado(CODIGO_MUNICIPIO, CODIGO_REGION, CODIGO_DEPARTAMENTO)
    End Sub

End Class
