Imports SQLMembershipProvider.BL
Imports System.Web.Security.Membership

Partial Class frmCursosProgramaPATI_Etapas
    Private nombreArchivo As String = ""

    Private Sub frmCursosProgramaPATI_Etapas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Inicializar()
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
    End Sub

    Public Sub RecuperarDatos()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim lIdFuente As Decimal = -1
        Dim lNoConvocatoria As Decimal = -1

        If Me.CbxPROGRAMA_FORMACION1.SelectedValue IsNot Nothing Then
           lIdFuente = Utilerias.ObtenerFuentePorProgramaFormacion(CInt(Me.CbxPROGRAMA_FORMACION1.SelectedValue))
        End If
        If Me.SpnNO_CONVOCATORIA.Value > 0 AndAlso Me.SpnNO_CONVOCATORIA.Enabled Then
            lNoConvocatoria = Me.SpnNO_CONVOCATORIA.Value
        End If
        Me.CursosPATI_EtapasTableAdapter1.Fill(DS_DL1.CursosPATI_Etapas_Duracion, lIdFuente, lNoConvocatoria)
        Me.Cursor = System.Windows.Forms.Cursors.Default
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
        Me.GridView1.Print()
    End Sub

    Public Sub VistaPrevia()
        Me.GridView1.ShowPrintPreview()
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
                Me.GridView1.ExportToXls(lsFile)

            Case formatoExportacion.Word
                Me.GridView1.ExportToRtf(lsFile)

            Case formatoExportacion.PDF
                Me.GridView1.ExportToPdf(lsFile)

            Case formatoExportacion.CSV
                AsignarMensaje("Formato no disponible para esta consulta")

            Case formatoExportacion.HTML
                Me.GridView1.ExportToHtml(lsFile)

            Case Else
                Return
        End Select
    End Sub
End Class