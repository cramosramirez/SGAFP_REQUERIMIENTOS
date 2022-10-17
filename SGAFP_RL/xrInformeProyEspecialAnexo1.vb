Public Class xrInformeProyEspecialAnexo1
    Dim meses As New List(Of String)
    Dim IdInforme As Decimal

    Public Sub CargarDatosPorInformeEjecucion(ByVal ID_INFORME_AF As Decimal)
        Me.DS_DL1.Clear()
        Me.InformeEjecucionProyEspecialTableAdapter1.FillPorInforme(Me.DS_DL1.InformeEjecucionProyEspecial, ID_INFORME_AF)

        IdInforme = ID_INFORME_AF
        Dim listaAsistencia As listaASISTENCIA_AF = (New cASISTENCIA_AF).ObtenerListaPorINFORME_FINAL_AF(ID_INFORME_AF, "FECHA", "ASC")
        If listaAsistencia IsNot Nothing AndAlso listaAsistencia.Count > 0 Then
            Dim periodo As String = ""
            For i As Integer = 0 To listaAsistencia.Count - 1
                periodo = Format(listaAsistencia(i).FECHA, "MMMM yyyy").ToUpper
                If Not meses.Contains(periodo) Then
                    meses.Add(periodo)
                End If
            Next
            For i As Integer = 0 To meses.Count - 1
                If i < meses.Count - 1 Then
                    xrPeriodoReportado.Text += meses(i) + ", "
                Else
                    xrPeriodoReportado.Text += meses(i)
                End If
            Next
        End If

        Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(ID_INFORME_AF)
        Dim lAccionFormativa As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA)

        If (New cACCION_FORMATIVA).EsAccionFormativaOnline(lAccionFormativa.ID_ACCION_FORMATIVA) Then
            Me.xrHorarioEnca.Visible = False
            Me.xrHorarioDeta.Visible = False

            Me.xrLugarEjecucionEnca.WidthF = 256.29
            Me.xrLugarEjecucionDeta.WidthF = 262.29
        End If

        If lInforme IsNot Nothing Then
            Dim lAccionDetalle1 As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lInforme.ID_ACCION_FORMATIVA)
            If lAccionDetalle1 IsNot Nothing AndAlso lAccionDetalle1.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE Then
                Me.xrlPrograma.Text = "PROGRAMA: HABIL TECNICO PERMANENTE"
                Me.xrlModalidad.Text = "ACCION MOVIL"
                Me.xrlNoAnexo.Text = ""
            End If
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

    Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(IdInforme)
        Dim lInformes As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA)
        Dim lHorasAcumuladas As Decimal = 0
        For Each lEntidad As INFORME_FINAL_AF In lInformes
            If lEntidad.FECHA_INICIAL <= lInforme.FECHA_INICIAL Then
                lHorasAcumuladas += lEntidad.HORAS_DESARROLLADAS
            End If
        Next
        xrtHorasAcumuladas.Text = lHorasAcumuladas.ToString
    End Sub
End Class