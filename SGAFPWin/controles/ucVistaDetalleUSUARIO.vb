Public Class ucVistaDetalleUSUARIO

    Private Sub ListaUSUARIOBindingSource_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _DataSource.CurrentChanged
        Dim lUsuario As USUARIO = sender.current
        'Me.ID_PARTICIPANTEcbxPARTICIPANTE.Items.Clear()
        Dim lParticipante As New PARTICIPANTE
        lParticipante = (New cPARTICIPANTE).ObtenerPARTICIPANTE(lUsuario.ID_PARTICIPANTE)
        If lParticipante Is Nothing OrElse lUsuario.ID_PARTICIPANTE = -1 Then
            lParticipante = New PARTICIPANTE
            lParticipante.ID_PARTICIPANTE = lUsuario.ID_PARTICIPANTE
            lParticipante.NOMBRES = "[Vacio]"
        End If
        Dim listaParticipante As New listaPARTICIPANTE
        listaParticipante.Add(lParticipante)
        Me.ListaPARTICIPANTEBindingSource.DataSource = listaParticipante
        Me.GridLookUpEdit1.EditValue = lUsuario.ID_PARTICIPANTE

        'Me.ID_PARTICIPANTEcbxPARTICIPANTE.CargarPorLista(listaParticipante, "NombresApellidos", "ID_PARTICIPANTE")
        'Me.ID_PARTICIPANTEcbxPARTICIPANTE.SelectedValue = lUsuario.ID_PARTICIPANTE

        'Me.ListaPARTICIPANTEBindingSource.DataSource = listaParticipante

        'Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.Recuperar(True)
        'Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedValue = lUsuario.ID_PROVEEDOR_AF

        'Me.ID_SITIO_CAPACITACIONcbxSITIO_CAPACITACION.RecuperarPorPROVEEDOR_AF(Me.ID_PROVEEDOR_AFcbxPROVEEDOR_AF.SelectedValue, False, True)
        'Me.ID_SITIO_CAPACITACIONcbxSITIO_CAPACITACION.SelectedValue = lUsuario.ID_SITIO_CAPACITACION

        Dim listaSitio As listaSITIO_CAPACITACION = (New cSITIO_CAPACITACION).ObtenerLista()
        Dim lSitio As New SITIO_CAPACITACION
        lSitio.ID_SITIO_CAPACITACION = -1
        lSitio.NOMBRE_SITIO = "[Vacio]"
        listaSitio.Add(lSitio)
        Me.ListaSITIOCAPACITACIONBindingSource.DataSource = listaSitio
        Me.GridLookUpEdit3.EditValue = lUsuario.ID_SITIO_CAPACITACION
    End Sub

End Class
