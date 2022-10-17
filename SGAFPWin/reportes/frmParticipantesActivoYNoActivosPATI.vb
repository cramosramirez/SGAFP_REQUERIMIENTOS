Imports SQLMembershipProvider.BL
Imports System.Web.Security.Membership
Imports DevExpress.XtraCharts

Public Class frmParticipantesActivoYNoActivosPATI

    Private nombreArchivo As String = "ParticipantesPATI"

    Public Enum formatoExportacion As Integer
        Excel = 1
        PDF = 2
        Word = 3
        CSV = 4
        HTML = 5
    End Enum

    Private Sub frmParticipantesActivoYNoActivosPATI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CargarDatos()
    End Sub

    Private Sub CargarDatos()
        InicializarVariables()
        Me.AgregarOpcion("Recargar", "Ver Reporte", My.Resources.DB, True)
        Me.AgregarOpcion("Imprimir", "Imprimir", My.Resources.print, True)
        Me.AgregarOpcion("VistaPrevia", "Vista Previa", My.Resources.print_preview, True)
        Me.AgregarOpcion("ExportarExcel", "Exportar a Excel", My.Resources.excel, True)
        Me.AgregarOpcion("ExportarPDF", "Exportar a PDF", My.Resources.pdf, True)
        Me.AgregarOpcion("ExportarWord", "Exportar a Word", My.Resources.word, True)
        Me.AgregarOpcion("LimpiarVariables", "Limpiar Variables", My.Resources.undofilter, True)
    End Sub

    Private Sub InicializarVariables()
        Me.CbxPROGRAMA_FORMACION1.RecuperarListaPATI()
        Me.SpinEdit1.Value = 1
        nombreArchivo = Me.CbxPROGRAMA_FORMACION1.Text + " Asistencia y Nota "
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
            Case "LimpiarVariables"
                LimpiarVariables()
        End Select
    End Sub

    Private Sub LimpiarVariables()
        Me.InicializarVariables()
    End Sub

    Public Sub Imprimir()
        Select Case Me.XtraTabControl1.SelectedTabPage.Name
            Case "tabDetalle"
                Me.GridControl1.Print()
            Case "tabAnalisis"
                Me.PivotGridControl1.Print()
            Case "tabGrafico"
                Me.ChartControl1.Print()
        End Select
    End Sub

    Public Sub VistaPrevia()
        Select Case Me.XtraTabControl1.SelectedTabPage.Name
            Case "tabDetalle"
                Me.GridControl1.ShowPrintPreview()
            Case "tabAnalisis"
                Me.PivotGridControl1.ShowPrintPreview()
            Case "tabGrafico"
                Me.ChartControl1.ShowPrintPreview()
        End Select
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


        Select Case Me.XtraTabControl1.SelectedTabPage.Name
            Case "tabDetalle"
                Select Case formato
                    Case formatoExportacion.Excel
                        Me.GridControl1.ExportToXls(lsFile)
                    Case formatoExportacion.Word
                        Me.GridControl1.ExportToRtf(lsFile)
                    Case formatoExportacion.PDF
                        Me.GridControl1.ExportToPdf(lsFile)
                    Case formatoExportacion.HTML
                        Me.GridControl1.ExportToHtml(lsFile)
                    Case Else
                        Return
                End Select
            Case "tabAnalisis"
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
            Case "tabGrafico"
                Select Case formato
                    Case formatoExportacion.Excel
                        Me.ChartControl1.ExportToXls(lsFile)
                        'Case formatoExportacion.Word
                        '    Me.ChartControl1.ExportToRtf(lsFile)
                    Case formatoExportacion.PDF
                        Me.ChartControl1.ExportToPdf(lsFile)
                        'Case formatoExportacion.CSV
                        '    Me.ChartControl1.ExportToCsv(lsFile)
                    Case formatoExportacion.HTML
                        Me.ChartControl1.ExportToHtml(lsFile)
                    Case Else
                        Return
                End Select
        End Select

    End Sub

    Public Sub RecuperarDatos()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim lIdFuente As Decimal = -1
        Dim lNoConvocatoria As Decimal = -1

        If Me.CbxPROGRAMA_FORMACION1.SelectedValue IsNot Nothing Then
            lIdFuente = Utilerias.ObtenerFuentePorProgramaFormacion(CInt(Me.CbxPROGRAMA_FORMACION1.SelectedValue))
        End If

        DS_DL1.PATIParticipantesActivosYNoActivos.Rows.Clear()

        lNoConvocatoria = Me.SpinEdit1.Value
        Dim lcEjecucionReporte As New cEjecucionReporte
        If lcEjecucionReporte.RecuperarParticipantesActivos(lNoConvocatoria, lIdFuente, DS_DL1) < 1 Then
            Me.AsignarMensaje("Error : " + lcEjecucionReporte.sError, True)
        End If

        'Me.PatiParticipantesActivosYNoActivosTableAdapter1.Fill(DS_DL1.PATIParticipantesActivosYNoActivos, lNoConvocatoria, lIdFuente)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub PivotGridControl1_CustomUnboundFieldData(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.CustomFieldDataEventArgs) Handles PivotGridControl1.CustomUnboundFieldData
        If e.Field.UnboundFieldName = "AsistioNoFinalizo" Then
            If e.GetListSourceColumnValue("ASISTIO_CAPACITACION") Is DBNull.Value Or e.GetListSourceColumnValue("ASISTIO_CAPACITACION") Is DBNull.Value Then
                e.Value = 0
            Else
                If e.GetListSourceColumnValue("ASISTIO_CAPACITACION") = "X" _
                    And e.GetListSourceColumnValue("FINALIZO_CAPACITACION") = "" Then
                    e.Value = 1
                Else
                    e.Value = 0
                End If
            End If
            'Iif( [ASISTIO_CAPACITACION] = 'X'  And [Finalizo] = '' , 1 , 0 )
        End If

        If e.Field.UnboundFieldName = "Entrevistado" Then
            If e.GetListSourceColumnValue("ENTREVISTO_INSAFORP") = 1 _
                    Or e.GetListSourceColumnValue("ENTREVISTO_PROVEEDOR") = 1 Then
                e.Value = 1
            Else
                e.Value = 0
            End If
        End If
        If e.Field.UnboundFieldName = "Asistio" Then
            If Not e.GetListSourceColumnValue("FINALIZO_CAPACITACION") Is DBNull.Value _
                AndAlso e.GetListSourceColumnValue("FINALIZO_CAPACITACION") = "X" Then
                e.Value = 1
            ElseIf Not e.GetListSourceColumnValue("ASISTIO_CAPACITACION") Is DBNull.Value _
                AndAlso e.GetListSourceColumnValue("ASISTIO_CAPACITACION") = "X" Then
                e.Value = 1
            Else
                e.Value = 0
            End If
        End If
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged
        Select Case Me.ComboBoxEdit1.SelectedText
            Case "Barras tipo Manhatan"
                Me.ChartControl1.SeriesTemplate.ChangeView(ViewType.ManhattanBar)
            Case "Barras 3D"
                Me.ChartControl1.SeriesTemplate.ChangeView(ViewType.Bar3D)
            Case "Barras en Pila 3D"
                Me.ChartControl1.SeriesTemplate.ChangeView(ViewType.StackedBar3D)
            Case "Barras 2D"
                Me.ChartControl1.SeriesTemplate.ChangeView(ViewType.Bar)
            Case "Barras en Pila 2D"
                Me.ChartControl1.SeriesTemplate.ChangeView(ViewType.StackedBar)
            Case "Pastel 3D"
                Me.ChartControl1.SeriesTemplate.ChangeView(ViewType.Pie3D)
            Case "Pastel 2D"
                Me.ChartControl1.SeriesTemplate.ChangeView(ViewType.Pie)
            Case Else
                Me.ChartControl1.SeriesTemplate.ChangeView(ViewType.ManhattanBar)
        End Select

    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        Me.PivotGridControl1.OptionsChartDataSource.ChartDataVertical = Not Me.CheckEdit1.Checked
    End Sub

    Private Sub txtTituloGrafico_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTituloGrafico.EditValueChanged
        If Me.ChartControl1.Titles.Count > 0 Then
            Me.ChartControl1.Titles(0).Text = Me.txtTituloGrafico.Text
            nombreArchivo = Me.txtTituloGrafico.Text.Replace(" ", "")
        End If
    End Sub

    Private Sub GridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridView1.CustomUnboundColumnData
        If e.Column.FieldName = "colENTREVISTO_PROVEEDOR" Then
            Dim dr As DataRow = GridView1.GetDataRow(e.RowHandle)
            If Not dr Is Nothing AndAlso dr("ENTREVISTO_PROVEEDOR") = 0 Then
                e.Value = ""
            Else
                e.Value = "X"
            End If
        End If
        If e.Column.FieldName = "colENTREVISTO_INSAFORP" Then
            Dim dr As DataRow = GridView1.GetDataRow(e.RowHandle)
            If Not dr Is Nothing AndAlso dr("ENTREVISTO_INSAFORP") = 0 Then
                e.Value = ""
            Else
                e.Value = "X"
            End If
        End If
        If e.Column.FieldName = "colENTREVISTADO" Then
            Dim dr As DataRow = GridView1.GetDataRow(e.RowHandle)
            If Not dr Is Nothing AndAlso dr("ENTREVISTO_PROVEEDOR") = 1 Or GridView1.GetDataRow(e.RowHandle)("ENTREVISTO_INSAFORP") = 1 Then
                e.Value = "X"
            Else
                e.Value = ""
            End If
        End If
    End Sub

End Class