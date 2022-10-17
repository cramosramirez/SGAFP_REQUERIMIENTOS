Imports DevExpress.XtraCharts

Public Class frmAnalisisEjecucionPATI

    Private nombreArchivo As String = "AnalisisEjecucionPATI"

    Public Enum formatoExportacion As Integer
        Excel = 1
        PDF = 2
        Word = 3
        CSV = 4
        HTML = 5
    End Enum

    Private Sub frmAnalisisEjecucionPATI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        Me.AgregarOpcion("GuardarLayout", "Guardar Layout", My.Resources.todo, True)
        Me.AgregarOpcion("RecuperarLayout", "Recuperar Layout", My.Resources.todo, True)
        Me.AgregarOpcion("LimpiarVariables", "Limpiar Variables", My.Resources.undofilter, True)
        Me.DeshabilitarOpcion("Guardar Layout")
        Me.DeshabilitarOpcion("Recuperar Layout")
    End Sub

    Private Sub GuardarLayout()
        Me.SaveFileDialog1.FileName = Now.ToString("ddMMyyyyhhmmss") + ".lay"
        Me.SaveFileDialog1.InitialDirectory = System.Environment.SpecialFolder.MyDocuments
        Me.SaveFileDialog1.Filter = "Archivo Layout |*.lay"
        If Not Me.SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Return
        End If

        Select Case Me.XtraTabControl1.SelectedTabPage.Name
            Case "tabDetalle"
                Me.GridView1.SaveLayoutToXml(Me.SaveFileDialog1.FileName)
            Case "tabAnalisis"
                Me.PivotGridControl1.SaveLayoutToXml(Me.SaveFileDialog1.FileName)
            Case Else

        End Select

       

    End Sub

    Private Sub RecuperarLayout()
        Me.OpenFileDialog1.InitialDirectory = System.Environment.SpecialFolder.MyDocuments
        Me.OpenFileDialog1.Filter = "Archivo Layout |*.lay"
        If Not Me.OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Return
        End If

        Select Case Me.XtraTabControl1.SelectedTabPage.Name
            Case "tabDetalle"
                Me.GridView1.RestoreLayoutFromXml(Me.OpenFileDialog1.FileName)
            Case "tabAnalisis"
                Me.PivotGridControl1.RestoreLayoutFromXml(Me.OpenFileDialog1.FileName)
            Case Else

        End Select

    End Sub

    Private Sub InicializarVariables()
        Me.CbxPROGRAMA_FORMACION1.RecuperarListaPATI()
        Me.SpinEdit1.Value = 0
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
            Case "GuardarLayout"
                Me.GuardarLayout()
            Case "RecuperarLayout"
                Me.RecuperarLayout()
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

        If Me.SpinEdit1.Value > 0 Then
            lNoConvocatoria = Me.SpinEdit1.Value
        End If

        DS_DL1.Clear()

        If lIdFuente = -1 And lNoConvocatoria = -1 Then
            Me.PatI_ANALISIS_EJECUCIONTableAdapter1.Fill(DS_DL1.PATI_ANALISIS_EJECUCION)
        Else
            Me.PatI_ANALISIS_EJECUCIONTableAdapter1.FillPorFuenteConvocatoria(DS_DL1.PATI_ANALISIS_EJECUCION, lIdFuente, lNoConvocatoria)
            Dim AUPsPorAF As New Dictionary(Of Integer, String)
            For Each lRow As SGAFP.DL.DS_DL.PATI_ANALISIS_EJECUCIONRow In DS_DL1.PATI_ANALISIS_EJECUCION
                If Not AUPsPorAF.ContainsKey(lRow.ID_ACCION_FORMATIVA) Then
                    AUPsPorAF.Add(lRow.ID_ACCION_FORMATIVA, (New cACCION_FORMATIVA).ObtenerListaAUPsPorAccionFormativa(lRow.ID_ACCION_FORMATIVA))
                End If
                lRow.AUP = AUPsPorAF(lRow.ID_ACCION_FORMATIVA)
            Next
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default

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
        Me.PivotGridControl1.OptionsChartDataSource.ProvideDataByColumns = Not Me.CheckEdit1.Checked
    End Sub

    Private Sub txtTituloGrafico_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTituloGrafico.EditValueChanged
        If Me.ChartControl1.Titles.Count > 0 Then
            Me.ChartControl1.Titles(0).Text = Me.txtTituloGrafico.Text
            nombreArchivo = Me.txtTituloGrafico.Text.Replace(" ", "")
        End If
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangingEventArgs) Handles XtraTabControl1.SelectedPageChanging
        If e.Page.Name = "tabDetalle" Or e.Page.Name = "tabAnalisis" Then
            Me.HabilitarOpcion("Guardar Layout")
            Me.HabilitarOpcion("Recuperar Layout")
        Else
            Me.DeshabilitarOpcion("Guardar Layout")
            Me.DeshabilitarOpcion("Recuperar Layout")
        End If
    End Sub

End Class
