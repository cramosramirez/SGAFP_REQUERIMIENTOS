Imports DevExpress.XtraPivotGrid

Public Class frmDesembolsosPATI

    Private nombreArchivo As String = ""

    Public Enum formatoExportacion As Integer
        Excel = 1
        PDF = 2
        Word = 3
        CSV = 4
        HTML = 5
    End Enum

    Private Sub SetearConvocatoria()
        Dim listaConvocatorias As List(Of Integer) = (New cFUENTE_FINANCIAMIENTO).ObtenerListaConvocatoriasPorProgramaFormacion(Me.CbxPROGRAMA_FORMACION1.SelectedValue)
        If listaConvocatorias IsNot Nothing AndAlso listaConvocatorias.Count > 0 Then
            Me.spnNO_CONVOCATORIA.Value = listaConvocatorias(listaConvocatorias.Count - 1)
        End If
    End Sub

    Private Sub Inicializar()
        Me.InicializarVariables()
        Me.AgregarOpcion("Recargar", "Ver Reporte", My.Resources.DB, True)
        Me.AgregarOpcion("Imprimir", "Imprimir", My.Resources.print, True)
        Me.AgregarOpcion("VistaPrevia", "Vista Previa", My.Resources.print_preview, True)
        Me.AgregarOpcion("ExportarExcel", "Exportar a Excel", My.Resources.excel, True)
        Me.AgregarOpcion("ExportarPDF", "Exportar a PDF", My.Resources.pdf, True)
        Me.AgregarOpcion("ExportarWord", "Exportar a Word", My.Resources.word, True)
        Me.AgregarOpcion("GuardarLayout", "Guardar Layout", My.Resources.todo, True)
        Me.AgregarOpcion("RecuperarLayout", "Recuperar Layout", My.Resources.todo, True)
        Me.AgregarOpcion("LimpiarVariables", "Limpiar Variables", My.Resources.undofilter, True)
    End Sub

    Private Sub InicializarVariables()
        Me.CbxPROGRAMA_FORMACION1.RecuperarListaPATI()
        Me.SetearConvocatoria()
        nombreArchivo = Me.CbxPROGRAMA_FORMACION1.Text + " Desembolso "
    End Sub

    Private Sub frmDesembolsosPATI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inicializar()
    End Sub

    Public Overrides Sub EjecutarOpcion(ByVal asComando As String)
        Select Case asComando
            Case "Recargar"
                RecuperarDatos()
            Case "Imprimir"
                Imprimir()
            Case "VistaPrevia"
                VistaPrevia()
            Case "ExportarExcel"
                Exportar(formatoExportacion.Excel)
            Case "ExportarPDF"
                Exportar(formatoExportacion.PDF)
            Case "ExportarWord"
                Exportar(formatoExportacion.Word)
            Case "GuardarLayout"
                GuardarLayout()
            Case "RecuperarLayout"
                RecuperarLayout()
            Case "LimpiarVariables"
                LimpiarVariables()
        End Select
    End Sub

    Private Sub LimpiarVariables()
        Me.InicializarVariables()
    End Sub

    Private Sub RecuperarLayout()
        Me.OpenFileDialog1.InitialDirectory = System.Environment.SpecialFolder.MyDocuments
        Me.OpenFileDialog1.Filter = "Archivo Layout |*.lay"
        If Not Me.OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Return
        End If
        Me.PivotGridControl1.RestoreLayoutFromXml(Me.OpenFileDialog1.FileName)
    End Sub

    Private Sub GuardarLayout()
        Me.SaveFileDialog1.FileName = Now.ToString("ddMMyyyyhhmmss") + ".lay"
        Me.SaveFileDialog1.InitialDirectory = System.Environment.SpecialFolder.MyDocuments
        Me.SaveFileDialog1.Filter = "Archivo Layout |*.lay"
        If Not Me.SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Return
        End If
        Me.PivotGridControl1.SaveLayoutToXml(Me.SaveFileDialog1.FileName)
    End Sub

    Public Sub Imprimir()
        Me.PivotGridControl1.Print()
    End Sub

    Public Sub VistaPrevia()
        Me.PivotGridControl1.ShowPrintPreview()
    End Sub

    Public Sub Exportar(ByVal formato As formatoExportacion)
        Dim lsFile As String
        Select Case formato
            Case formatoExportacion.Excel
                Me.SaveFileDialog1.FileName = Me.nombreArchivo + Now.ToString("ddMMyyyyhhmmss") + ".xls"
                Me.SaveFileDialog1.InitialDirectory = System.Environment.SpecialFolder.MyDocuments
                Me.SaveFileDialog1.Filter = "Archivo Excel |*.xls"
                If Not Me.SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Return
                End If
            Case formatoExportacion.PDF
                Me.SaveFileDialog1.FileName = Me.nombreArchivo + Now.ToString("ddMMyyyyhhmmss") + ".pdf"
                Me.SaveFileDialog1.InitialDirectory = System.Environment.SpecialFolder.MyDocuments
                Me.SaveFileDialog1.Filter = "Archivo PDF |*.pdf"
                If Not Me.SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Return
                End If
            Case formatoExportacion.Word
                Me.SaveFileDialog1.FileName = Me.nombreArchivo + Now.ToString("ddMMyyyyhhmmss") + ".doc"
                Me.SaveFileDialog1.InitialDirectory = System.Environment.SpecialFolder.MyDocuments
                Me.SaveFileDialog1.Filter = "Archivo Word |*.doc"
                If Not Me.SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Return
                End If
            Case Else
                Return
        End Select
        lsFile = Me.SaveFileDialog1.FileName

        Select Case formato
            Case formatoExportacion.Excel
                Me.PivotGridControl1.ExportToXls(lsFile)
            Case formatoExportacion.Word
                Me.PivotGridControl1.ExportToRtf(lsFile)
            Case formatoExportacion.PDF
                Me.PivotGridControl1.ExportToPdf(lsFile)
            Case formatoExportacion.CSV
                Me.PivotGridControl1.ExportToCsv(lsFile)
            Case formatoExportacion.HTML
                Me.PivotGridControl1.ExportToHtml(lsFile)
            Case Else
                Return
        End Select
    End Sub

    Public Sub RecuperarDatos()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim lIdFuente As Decimal = -1
        Dim lNoConvocatoria As Decimal = -1
        If Me.CbxPROGRAMA_FORMACION1.SelectedValue IsNot Nothing Then
            lIdFuente = Utilerias.ObtenerFuentePorProgramaFormacion(CInt(Me.CbxPROGRAMA_FORMACION1.SelectedValue))
        End If
        If Me.spnNO_CONVOCATORIA.Text <> "" Then
            If Me.spnNO_CONVOCATORIA.Text <> "0" Then
                lNoConvocatoria = Me.spnNO_CONVOCATORIA.Text
            End If
        End If

        Me.DesembolsoPATI_SolicitudDesembolsoTableAdapter1.FillPorFuenteConvocatoria(Me.DS_DL1.DesembolsoPATI_SolicitudDesembolso, lIdFuente, lNoConvocatoria)
        Me.DesembolsoPATI_AplicacionDesembolsoTableAdapter1.FillPorFuenteConvocatoria(Me.DS_DL1.DesembolsoPATI_AplicacionDesembolso, lIdFuente, lNoConvocatoria)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Function TotalAporteFISDL() As Decimal
        Dim ds As PivotSummaryDataSource = PivotGridControl1.CreateSummaryDataSource()
        Dim diccAportes As New List(Of String)
        Dim totalAportes As Decimal = 0
        For i = 0 To ds.RowCount - 1
            If Not diccAportes.Contains(ds.GetValue(i, fieldNOMBRE1)) Then
                diccAportes.Add(ds.GetValue(i, fieldNOMBRE1))
                totalAportes += ds.GetValue(i, fieldAPORTEFISDL1)
            End If
        Next
        Return totalAportes
    End Function

    Function TotalSolicitado() As Decimal
        Dim ds As PivotSummaryDataSource = PivotGridControl1.CreateSummaryDataSource()
        Dim diccAportes As New List(Of String)
        Dim totalAportes As Decimal = 0
        Dim montoSolicitado As Decimal = 0
        For i = 0 To ds.RowCount - 1
            montoSolicitado += ds.GetValue(i, fieldMONTOSOLICITADO1)
        Next
        Return montoSolicitado
    End Function

    Function TotalDesembolsoAplicado() As Decimal
        Dim ds As PivotSummaryDataSource = PivotGridControl2.CreateSummaryDataSource()
        Dim montoDesembolsos As Decimal = 0
        For i = 0 To ds.RowCount - 1
            montoDesembolsos += ds.GetValue(i, fieldMONTODESEMBOLSO2)
        Next
        Return montoDesembolsos
    End Function

    Function TotalPagadoProveedores() As Decimal
        Dim ds As PivotSummaryDataSource = PivotGridControl2.CreateSummaryDataSource()
        Dim montoPagado As Decimal = 0
        For i = 0 To ds.RowCount - 1
            montoPagado += ds.GetValue(i, fieldPAGOPROVEEDORES1)
        Next
        Return montoPagado
    End Function

    Private Sub PivotGridControl1_CustomCellDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs) Handles PivotGridControl1.CustomCellDisplayText
        If e.DataField Is fieldAPORTEFISDL1 Then
            If e.RowValueType = PivotGridValueType.GrandTotal Then
                e.DisplayText = TotalAporteFISDL().ToString("#,##0.00")
            End If
        ElseIf e.DataField Is fieldPENDIENTE_LIQUIDACION Then
            If e.RowValueType = PivotGridValueType.GrandTotal Then
                e.DisplayText = (TotalAporteFISDL() - TotalSolicitado()).ToString("#,##0.00")
            End If
        ElseIf e.DataField Is fieldPORC_EJECUCION Then
            If e.RowValueType = PivotGridValueType.GrandTotal Then
                Dim totalAporte As Decimal = TotalAporteFISDL()
                If totalAporte > 0 Then
                    e.DisplayText = (TotalSolicitado() / TotalAporteFISDL()).ToString("##0%")
                Else
                    e.DisplayText = "0%"
                End If
            End If
        End If
    End Sub

    Private Sub PivotGridControl1_CustomSummary(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs) Handles PivotGridControl1.CustomSummary
        If e.DataField Is fieldPENDIENTE_LIQUIDACION Then
            Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
            Dim i As Integer
            Dim municipio As String = ""
            Dim aporteFISDL As Decimal = 0
            Dim montoSolicitado As Decimal = 0
            For i = 0 To ds.RowCount - 1
                Dim row As PivotDrillDownDataRow = ds(i)
                If municipio <> row(fieldNOMBRE1) Then aporteFISDL += row(fieldAPORTEFISDL1)
                montoSolicitado += row(fieldMONTOSOLICITADO1)
                municipio = row(fieldNOMBRE1)
            Next
            If ds.RowCount > 0 Then
                e.CustomValue = aporteFISDL - montoSolicitado
            End If
        ElseIf e.DataField Is fieldAPORTEFISDL1 Then
            Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
            Dim i As Integer
            Dim municipio As String = ""
            Dim aporteFISDL As Decimal = 0
            For i = 0 To ds.RowCount - 1
                Dim row As PivotDrillDownDataRow = ds(i)
                If municipio <> row(fieldNOMBRE1) Then aporteFISDL += row(fieldAPORTEFISDL1)
                municipio = row(fieldNOMBRE1)
            Next
            If ds.RowCount > 0 Then
                e.CustomValue = aporteFISDL
            End If
        End If
    End Sub

    Private Sub PivotGridControl2_CustomCellDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellDisplayTextEventArgs) Handles PivotGridControl2.CustomCellDisplayText
        'If e.DataField Is field Then
        '    If e.RowValueType = PivotGridValueType.GrandTotal Then
        '        Dim monto As Decimal = TotalDesembolsoAplicado()
        '        If monto > 0 Then
        '            e.DisplayText = (TotalPagadoProveedores() / TotalDesembolsoAplicado()).ToString("##0.00%")
        '        Else
        '            e.DisplayText = "0.00%"
        '        End If
        '    End If
        'ElseIf e.DataField Is field1 Then
        '    If e.RowValueType = PivotGridValueType.GrandTotal Then
        '        Dim monto As Decimal = TotalDesembolsoAplicado()
        '        If monto > 0 Then
        '            e.DisplayText = (1 - TotalPagadoProveedores() / TotalDesembolsoAplicado()).ToString("##0.00%")
        '        Else
        '            e.DisplayText = "0.00%"
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub PivotGridControl2_CustomSummary(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs) Handles PivotGridControl2.CustomSummary
        If e.DataField Is fieldPorcPagadoProveedores Then
            Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
            Dim i As Integer
            Dim totalDesembolso As Decimal = 0
            Dim totalPagado As Decimal = 0
            Dim dicPagadoProveedor As New Dictionary(Of Decimal, List(Of Decimal))
            For i = 0 To ds.RowCount - 1
                Dim row As PivotDrillDownDataRow = ds(i)
                If dicPagadoProveedor.ContainsKey(row(fieldNUMDESEMBOLSO1)) Then
                    dicPagadoProveedor(row(fieldNUMDESEMBOLSO1))(0) += row(fieldMONTODESEMBOLSO2)
                    dicPagadoProveedor(row(fieldNUMDESEMBOLSO1))(1) += row(fieldMontoSinRetencion) + row(fieldIVARetenido)
                Else
                    Dim lValores As New List(Of Decimal)
                    lValores.Add(row(fieldMONTODESEMBOLSO2))
                    lValores.Add(row(fieldMontoSinRetencion) + row(fieldIVARetenido))
                    dicPagadoProveedor.Add(row(fieldNUMDESEMBOLSO1), lValores)
                End If
            Next
            totalDesembolso = 0
            totalPagado = 0
            For Each clave As Decimal In dicPagadoProveedor.Keys
                totalDesembolso += dicPagadoProveedor(clave)(0)
                totalPagado += dicPagadoProveedor(clave)(1)
            Next
            If ds.RowCount > 0 Then
                If totalDesembolso > 0 Then
                    e.CustomValue = totalPagado / totalDesembolso
                    Return
                End If
                e.CustomValue = 0
            End If
        ElseIf e.DataField Is fieldPorcFavorINSAFORP Then
            Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
            Dim i As Integer
            Dim totalDesembolso As Decimal = 0
            Dim totalPagado As Decimal = 0
            Dim dicPagadoProveedor As New Dictionary(Of Decimal, List(Of Decimal))
            For i = 0 To ds.RowCount - 1
                Dim row As PivotDrillDownDataRow = ds(i)
                If dicPagadoProveedor.ContainsKey(row(fieldNUMDESEMBOLSO1)) Then
                    dicPagadoProveedor(row(fieldNUMDESEMBOLSO1))(0) += row(fieldMONTODESEMBOLSO2)
                    dicPagadoProveedor(row(fieldNUMDESEMBOLSO1))(1) += row(fieldMontoSinRetencion) + row(fieldIVARetenido)
                Else
                    Dim lValores As New List(Of Decimal)
                    lValores.Add(row(fieldMONTODESEMBOLSO2))
                    lValores.Add(row(fieldMontoSinRetencion) + row(fieldIVARetenido))
                    dicPagadoProveedor.Add(row(fieldNUMDESEMBOLSO1), lValores)
                End If
            Next
            totalDesembolso = 0
            totalPagado = 0
            For Each clave As Decimal In dicPagadoProveedor.Keys
                totalDesembolso += dicPagadoProveedor(clave)(0)
                totalPagado += dicPagadoProveedor(clave)(1)
            Next
            If ds.RowCount > 0 Then
                If totalDesembolso > 0 Then
                    e.CustomValue = 1 - (totalPagado / totalDesembolso)
                    Return
                End If
                e.CustomValue = 0
            End If
        End If
    End Sub
    
    Private Sub PivotGridControl2_CustomUnboundFieldData(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.CustomFieldDataEventArgs) Handles PivotGridControl2.CustomUnboundFieldData
        If e.Field.Name = "fieldMontoSinRetencion" Then
            Dim lMontos As Dictionary(Of Decimal, Decimal) = (New cFACTURA_AF).ObtenerMonto_IVARetenido(e.GetListSourceColumnValue("ID_FACTURA_AF"))
            If lMontos IsNot Nothing AndAlso lMontos.Count > 0 Then
                e.Value = lMontos.Keys(0) - lMontos.Values(0)
            Else
                e.Value = 0
            End If
        ElseIf e.Field.Name = "fieldIVARetenido" Then
            Dim lMontos As Dictionary(Of Decimal, Decimal) = (New cFACTURA_AF).ObtenerMonto_IVARetenido(e.GetListSourceColumnValue("ID_FACTURA_AF"))
            If lMontos IsNot Nothing AndAlso lMontos.Count > 0 Then
                e.Value = lMontos.Values(0)
            Else
                e.Value = 0
            End If
        End If
    End Sub
End Class