Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils
Imports DevExpress.XtraCharts

Public Class frmSolicitudesReport

    Private nombreArchivo As String = "SolicsPorProveedorCentroCursoEnPeriodo"
    Private graficoActivado As Boolean = False

    Private Sub XtraForm1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'TODO: esta línea de código carga datos en la tabla 'SolicitudesDataSet.VSOLIC_INGRESADAS' Puede moverla o quitarla según sea necesario.
        'Me.VSOLIC_INGRESADASTableAdapter.Fill(Me.SolicitudesDataSet.VSOLIC_INGRESADAS)
        'RecuperarDatos()
        Me.CbxPROVEEDOR_AF1.Recuperar(False, True)
        'Me.CbxPROVEEDOR_AF1.SelectedValue = -1
        Me.CbxSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.CbxPROVEEDOR_AF1.SelectedValue, True)
        'Me.CbxSITIO_CAPACITACION1.SelectedValue = -1
        Me.CbxAREA_FORMACION1.Recuperar(True)
        'Me.CbxAREA_FORMACION1.SelectedValue = -1
        Me.CbxEJERCICIO1.Recuperar(True)
        Me.CbxESTADO_ACCION_FORMATIVA1.Recuperar(True)
        'Me.CbxESTADO_ACCION_FORMATIVA1.SelectedValue = ""
        Me.CbxESTADO_SOLICITUD1.Recuperar(True)

        Me.AgregarOpcion("Ver Reporte", "Recargar", My.Resources.DB, True)
        Me.AgregarOpcion("Imprimir", "Imprimir", My.Resources.print, True)
        Me.AgregarOpcion("VistaPrevia", "Vista Previa", My.Resources.print_preview, True)
        Me.AgregarOpcion("ExportarExcel", "Exportar a Excel", My.Resources.excel, True)
        Me.AgregarOpcion("ExportarPDF", "Exportar a PDF", My.Resources.pdf, True)
        Me.AgregarOpcion("ExportarWord", "Exportar a Word", My.Resources.word, True)
    End Sub

    Private Sub CbxPROVEEDOR_AF1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxPROVEEDOR_AF1.SelectedIndexChanged
        Me.CbxSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.CbxPROVEEDOR_AF1.SelectedValue, True)
    End Sub

    Public Overrides Sub EjecutarOpcion(ByVal asComando As String)
        If asComando = "Ver Reporte" Then
            Me.RecuperarDatos()
        End If
        If asComando = "Imprimir" Then
            Me.Imprimir()
        End If
        If asComando = "VistaPrevia" Then
            Me.VistaPrevia()
        End If
        If asComando = "ExportarExcel" Then
            Me.Exportar(formatoExportacion.Excel)
        End If
        If asComando = "ExportarPDF" Then
            Me.Exportar(formatoExportacion.PDF)
        End If
        If asComando = "ExportarWord" Then
            Me.Exportar(formatoExportacion.Word)
        End If
    End Sub

    Public Sub Imprimir()
        If Me.graficoActivado Then
            Me.ChartControl1.Print()
        Else
            Me.PivotGridControl1.Print()
        End If

    End Sub

    Public Sub VistaPrevia()
        If Me.graficoActivado Then
            Me.ChartControl1.ShowPrintPreview()
        Else
            Me.PivotGridControl1.ShowPrintPreview()
        End If
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
        If graficoActivado Then
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
        Else
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
        End If
    End Sub

    Public Sub RecuperarDatos()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'Me.PivotGridControl1.DataSource = cReportes.ObtenerSOLIC_INGRESADAS().Tables("VSOLIC_INGRESADAS")
        Me.PivotGridControl1.DataSource = cReportes.ObtenerSOLIC_INGRESADASOPorCriterios(Me.CbxEJERCICIO1.SelectedValue, CbxPROVEEDOR_AF1.SelectedValue, Me.CbxAREA_FORMACION1.SelectedValue, "-1", Me.CbxESTADO_ACCION_FORMATIVA1.SelectedValue, Me.CbxESTADO_SOLICITUD1.SelectedValue).Tables("VSOLIC_INGRESADAS")
        Me.PivotGridControl1.RefreshData()

        'Me.VsoliC_INGRESADASTableAdapter1.Fill(Me.DS_DL1.VSOLIC_INGRESADAS)

        'Me.ChartControl1.Series(0).DataSource = cReportes.ObtenerSOLIC_INGRESADAS().Tables("VSOLIC_INGRESADAS")

        'Me.ChartControl1.DataSource = cReportes.ObtenerSOLIC_INGRESADAS().Tables("VSOLIC_INGRESADAS")
        'Dim diagram As XYDiagram = TryCast(Me.ChartControl1.Diagram, XYDiagram)
        'If Not diagram Is Nothing Then
        '    diagram.AxisY.GridLines.MinorVisible = True
        '    diagram.AxisY.Title.Text = "# de Solicitudes"
        '    diagram.AxisY.Title.Visible = True
        '    diagram.AxisX.Label.Antialiasing = True
        '    diagram.AxisX.Title.Text = "Proveedores"
        '    'diagram.AxisX.Label.Angle = -30
        'End If
        'StackedBar3DSeriesLabel2()
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
        Me.PivotGridControl1.OptionsChartDataSource.ChartDataVertical = Not Me.CheckEdit1.Checked
    End Sub

    Private Sub txtTituloGrafico_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTituloGrafico.EditValueChanged
        If Me.ChartControl1.Titles.Count > 0 Then
            Me.ChartControl1.Titles(0).Text = Me.txtTituloGrafico.Text
        End If
    End Sub

    Private Sub tabDatosGrafico_SelectedPageChanging(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangingEventArgs) Handles tabDatosGrafico.SelectedPageChanging
        Me.graficoActivado = (e.Page.Text = "Grafico")
        If Me.graficoActivado Then
            Me.DeshabilitarOpcion("ExportarWord")
        Else
            Me.HabilitarOpcion("ExportarWord")
        End If
    End Sub
End Class

Public Enum formatoExportacion As Integer
    Excel = 1
    PDF = 2
    Word = 3
    CSV = 4
    HTML = 5
End Enum