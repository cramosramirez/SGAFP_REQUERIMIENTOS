Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Utils
Imports DevExpress.XtraCharts


Public Class frmConsultarProyEsp

    Private nombreArchivo As String = "SolicsPorProveedorCentroCursoEnPeriodo"
    Private graficoActivado As Boolean = False

    Private Sub XtraForm1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'RecuperarDatos()
        Me.CbxPROGRAMA_FORMACION1.Recuperar(False, False)
        Me.CbxUNIDAD_ORGANIZATIVA1.Recuperar()
        Me.CbxUNIDAD_ORGANIZATIVA1.SelectedValue = 9
        Me.CbxPROVEEDOR_AF1.Recuperar(False, True)
        Me.CbxREFERENTE1.Recuperar(True)

        Me.AgregarOpcion("Ver Reporte", "Recargar", My.Resources.DB, True)
        Me.AgregarOpcion("Imprimir", "Imprimir", My.Resources.print, True)
        Me.AgregarOpcion("VistaPrevia", "Vista Previa", My.Resources.print_preview, True)
        Me.AgregarOpcion("ExportarExcel", "Exportar a Excel", My.Resources.excel, True)
        Me.AgregarOpcion("ExportarPDF", "Exportar a PDF", My.Resources.pdf, True)
        Me.AgregarOpcion("ExportarWord", "Exportar a Word", My.Resources.word, True)
    End Sub

    'Private Sub CbxPROVEEDOR_AF1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxPROVEEDOR_AF1.SelectedIndexChanged
    '    Me.CbxSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.CbxPROVEEDOR_AF1.SelectedValue, True)
    'End Sub

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
        Dim idReferente, idProveedor, idUnidadOrganizativa, idProgramaFormacion As Integer
        Dim noItem, noOfertaCompra, noContrato As String

        If Me.txtNoContrato.EditValue Is Nothing Or Me.txtNoContrato.EditValue = "" Then
            noContrato = " "
        Else
            noContrato = Me.txtNoContrato.EditValue
        End If
        If Me.txtNoOfertaCompra.Text.Trim = "" Then
            noOfertaCompra = " "
        Else
            noOfertaCompra = Me.txtNoOfertaCompra.Text.Trim
        End If

        If Me.txtItem.EditValue Is Nothing Or Me.txtItem.EditValue = "" Then
            noItem = " "
        Else
            noItem = Me.txtItem.EditValue
        End If

        If Me.CbxPROVEEDOR_AF1.SelectedValue Is Nothing Or Me.CbxPROVEEDOR_AF1.SelectedValue = -1 Then
            idProveedor = -1
        Else
            idProveedor = Me.CbxPROVEEDOR_AF1.SelectedValue
        End If

        If Me.CbxPROGRAMA_FORMACION1.SelectedValue Is Nothing Or Me.CbxPROGRAMA_FORMACION1.SelectedValue = -1 Then
            idProgramaFormacion = -1
        Else
            idProgramaFormacion = Me.CbxPROGRAMA_FORMACION1.SelectedValue
        End If

        If Me.CbxUNIDAD_ORGANIZATIVA1.SelectedValue Is Nothing Or Me.CbxUNIDAD_ORGANIZATIVA1.SelectedValue = -1 Then
            idUnidadOrganizativa = -1
        Else
            idUnidadOrganizativa = Me.CbxUNIDAD_ORGANIZATIVA1.SelectedValue
        End If

        If Me.CbxREFERENTE1.SelectedValue Is Nothing Or Me.CbxREFERENTE1.SelectedValue = -1 Then
            idReferente = -1
        Else
            idReferente = Me.CbxREFERENTE1.SelectedValue
        End If

        Me.ProyectosEspecialesTableAdapter1.FillByParametros(Me.DS_DL1.ProyectosEspeciales, idProveedor, idReferente, idUnidadOrganizativa, noContrato, noItem, idProgramaFormacion, noOfertaCompra)

        Me.PivotGridControl1.RefreshData()

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

    'Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
    '    Me.PivotGridControl1.OptionsChartDataSource.ChartDataVertical = Not Me.CheckEdit1.Checked
    'End Sub

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

