Imports DevExpress.XtraCharts
Imports SQLMembershipProvider.BL
Imports System.Web.Security.Membership
Public Class frmTDRsAsociadosPATI

    Private nombreArchivo As String = "TDR_Asociados"

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

        Me.PivotGridControl1.SaveLayoutToXml(Me.SaveFileDialog1.FileName)
    End Sub

    Private Sub RecuperarLayout()
        Me.OpenFileDialog1.InitialDirectory = System.Environment.SpecialFolder.MyDocuments
        Me.OpenFileDialog1.Filter = "Archivo Layout |*.lay"
        If Not Me.OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Return
        End If

        Me.PivotGridControl1.RestoreLayoutFromXml(Me.OpenFileDialog1.FileName)
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

        If lIdFuente = -1 Or lNoConvocatoria = -1 Then
            Me.AsignarMensaje("Debe de Elegir una Fuente y una Convocatoria", True)
        Else
            'Oracle
            Me.ReportE_TDR_ASOCIADOSTableAdapter1.Fill(DS_DL1.REPORTE_TDR_ASOCIADOS, lIdFuente, lNoConvocatoria)

            'Anywhere
            Dim ds As New SIFP.DL.DS_DL
            Dim da As New SIFP.DL.DS_DLTableAdapters.ConsultaEstadoTDRsTableAdapter
            da.Fill(ds.ConsultaEstadosTDRs)

            Dim query = From estadosTDR In ds.ConsultaEstadosTDRs, tdrAsociados In DS_DL1.REPORTE_TDR_ASOCIADOS _
                  Where estadosTDR.id_solicitud = CInt(tdrAsociados.Field(Of Decimal)("ID_SOLICITUD")) _
                  And Not estadosTDR.Isid_solicitudNull() _
                  Select New With { _
                       .NOMBRE_MUNICIPIO = tdrAsociados.Field(Of String)("NOMBRE_MUNICIPIO"), _
                       .ESPECIALIDAD = tdrAsociados.Field(Of String)("ESPECIALIDAD"), _
                       .NO_PARTICIPANTES = tdrAsociados.Field(Of Decimal)("NO_PARTICIPANTES"), _
                       .TDR = estadosTDR.tdr, _
                       .CANT_GRUPOS = estadosTDR.cantidad_grupos, _
                       .PROVEEDOR = estadosTDR.apellido, _
                       .ID_SOLICITUD = estadosTDR.id_solicitud, _
                       .ID_GRUPO_AF = tdrAsociados.Field(Of Decimal)("ID_GRUPO_AF"), _
                       .ESTADO = estadosTDR.NOMBRE_ESTADO, _
                       .MONTO_ADJUDICADO = IIf(estadosTDR.costo_grupo = "", 0.0, CDec(estadosTDR.costo_grupo)), _
                       .TITULO_TDR = estadosTDR.titulo, _
                       .RESOLUCION = estadosTDR.resolucion _
                       }

            Me.GridControl1.DataMember = ""
            Me.GridControl1.DataSource = query.ToList

            Me.PivotGridControl1.DataSource = query.ToList

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
        If e.Page.Name <> "tabAnalisis" Then
            Me.DeshabilitarOpcion("Guardar Layout")
            Me.DeshabilitarOpcion("Recuperar Layout")
        Else
            Me.HabilitarOpcion("Guardar Layout")
            Me.HabilitarOpcion("Recuperar Layout")
        End If
    End Sub

    Private Sub PivotGridControl1_CustomSummary(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs) Handles PivotGridControl1.CustomSummary
        If e.DataField Is fieldCANTTDR Then
            Dim name As String = e.DataField.FieldName

            If e.DataField.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom Then
                Dim list As IList = e.CreateDrillDownDataSource()
                Dim ht As Hashtable = New Hashtable
                For i As Integer = 0 To list.Count - 1
                    Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = CType(list(i), DevExpress.XtraPivotGrid.PivotDrillDownDataRow)

                    Dim v As Object = row(name)

                    If Not IsNothing(v) AndAlso (Not v Is DBNull.Value) Then
                        ht(v) = v
                    End If
                Next
                e.CustomValue = ht.Count
            End If
        End If

        If e.DataField Is fieldIDGRUPOAF1 Then
            Dim name As String = e.DataField.FieldName

            If e.DataField.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom Then
                Dim list As IList = e.CreateDrillDownDataSource()
                Dim ht As Hashtable = New Hashtable
                For i As Integer = 0 To list.Count - 1
                    Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = CType(list(i), DevExpress.XtraPivotGrid.PivotDrillDownDataRow)

                    Dim v As Object = row(name)

                    If Not IsNothing(v) AndAlso (Not v Is DBNull.Value) Then
                        ht(v) = v
                    End If
                Next
                e.CustomValue = ht.Count
            End If
        End If

        If e.DataField Is fieldNOPARTICIPANTES Then
            Dim name As String = e.DataField.FieldName

            If e.DataField.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom Then
                Dim list As IList = e.CreateDrillDownDataSource()
                Dim ht As Hashtable = New Hashtable
                Dim htKeys As Hashtable = New Hashtable
                For i As Integer = 0 To list.Count - 1
                    Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = CType(list(i), DevExpress.XtraPivotGrid.PivotDrillDownDataRow)

                    Dim v As Object = row(name)

                    If Not IsNothing(v) AndAlso (Not v Is DBNull.Value) Then
                        ht(row("ID_GRUPO_AF")) = v
                    End If
                Next

                Dim suma As Decimal = 0
                For i As Integer = 0 To ht.Count - 1
                    suma += ht.Values(i)
                Next
                e.CustomValue = suma
            End If
        End If

        If e.DataField Is fieldMONTO_ADJUDICADO Then
            Dim name As String = e.DataField.FieldName

            If e.DataField.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom Then
                Dim list As IList = e.CreateDrillDownDataSource()
                Dim ht As Hashtable = New Hashtable
                Dim htKeys As Hashtable = New Hashtable
                For i As Integer = 0 To list.Count - 1
                    Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = CType(list(i), DevExpress.XtraPivotGrid.PivotDrillDownDataRow)

                    Dim v As Object = row(name)

                    If Not IsNothing(v) AndAlso (Not v Is DBNull.Value) Then
                        ht(row("ID_GRUPO_AF")) = v
                    End If
                Next

                Dim suma As Decimal = 0
                For i As Integer = 0 To ht.Count - 1
                    suma += ht.Values(i)
                Next
                e.CustomValue = suma
            End If
        End If

    End Sub
End Class
