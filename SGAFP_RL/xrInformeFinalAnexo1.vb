Public Class xrInformeFinalAnexo1

    Public Sub CargarDatosPorInformeEjecucion(ByVal ID_INFORME_AF As Decimal)
        Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(ID_INFORME_AF)
        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA)

        Me.DS_DL1.Clear()
        Me.InformeFinal1TableAdapter1.FillPorInforme(Me.DS_DL1.InformeFinal1, ID_INFORME_AF)
        If lAccionFormativa.DURACION_HORAS >= 100 AndAlso lInforme.HORAS_DESARROLLADAS < lAccionFormativa.DURACION_HORAS Then
            xrLabelCosto.Text = "Costo por Hora"
            xrTableCosto.Text = lInforme.COSTO_X_HORA.ToString("$#,##0.00")
        Else
            xrLabelCosto.Text = "Costo por Participación"
            xrTableCosto.Text = lAccionFormativa.COSTO_X_PARTICIPANTE.ToString("$#,##0.00")
        End If


        Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lAccionFormativa.ID_ACCION_FORMATIVA)
        If lAccionDetalle IsNot Nothing AndAlso lAccionDetalle.ID_CONTRATO <> -1 Then
            Dim lContrato As CONTRATO_PROVEEDOR_AF = (New cCONTRATO_PROVEEDOR_AF).ObtenerCONTRATO_PROVEEDOR_AF(lAccionDetalle.ID_CONTRATO)
            If lContrato IsNot Nothing Then
                Me.xrContrato.Text = "N° LICITACIÓN: " + lContrato.NUM_LICITACION + "   N° CONTRATO: " + lContrato.NUM_CONTRATO
                Exit Sub
            End If
        End If

        Dim lGrupoContratada As listaGRUPO_ACCION_CONTRATADA = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA)
        If lGrupoContratada IsNot Nothing AndAlso lGrupoContratada.Count > 0 Then
            Dim lAccionContratada As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(lGrupoContratada(0).ID_ACCION_CONTRATADA)
            Dim lContrato As CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(lAccionContratada.ID_CONTRATO)

            If lContrato.ID_TIPO_CONTRA = Enumeradores.TipoContratacion.BOLPROS Then
                Me.xrContrato.Text = "N° CONTRATO BOLSA: " + lContrato.NUM_CONTRATO
                If lAccionContratada.NUM_ITEM > 0 Then
                    Me.xrContrato.Text += "  ITEM: " + lAccionContratada.NUM_ITEM.ToString
                End If
                Exit Sub
            ElseIf lContrato.ID_TIPO_CONTRA = Enumeradores.TipoContratacion.LICITACION Then
                Me.xrContrato.Text = "N° CONTRATO DE LICITACIÓN: " + lContrato.NUM_CONTRATO
                Exit Sub
            End If
        End If

        Dim lTermino As TERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(lAccionFormativa.ID_ACCION_FORMATIVA)
        If lTermino IsNot Nothing Then
            Me.xrContrato.Text = "N° ORDEN DE COMPRA: " + lTermino.RESOLUCION
        End If
    End Sub

    
End Class