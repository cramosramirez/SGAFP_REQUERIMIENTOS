Public Class frmOfertaFormativaPorSitio

    Private nombreArchivo As String = "OfertaFormativaPorProveedorCentroEnPeriodo"

    Private Sub frmOfertaFormativaPorSitio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.CbxPROVEEDOR_AF1.Recuperar(False, True)
        'Me.CbxPROVEEDOR_AF1.SelectedValue = -1
        Me.CbxSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.CbxPROVEEDOR_AF1.SelectedValue, True)
        'Me.CbxSITIO_CAPACITACION1.SelectedValue = -1
        'Me.CbxAREA_FORMACION1.SelectedValue = -1
        Me.CbxEJERCICIO1.Recuperar()
        Me.CbxAREA_FORMACION1.RecuperarPorProveedorEjercicio(Me.CbxPROVEEDOR_AF1.SelectedValue, Me.CbxEJERCICIO1.SelectedValue, True)
        Me.CbxDEPARTAMENTO1.Recuperar("01", True)
        Me.CbxMUNICIPIO1.Recuperar("01", Me.CbxDEPARTAMENTO1.SelectedValue, True)
        Me.AgregarOpcion("RecuperarOferta", "Cargar Oferta", My.Resources.DB, True)
        Me.AgregarOpcion("VistaPrevia", "Vista Previa", My.Resources.print_preview, True)
        Me.AgregarOpcion("ExportarExcel", "Exportar a Excel", My.Resources.excel, True)
        Me.AgregarOpcion("ExportarPDF", "Exportar a PDF", My.Resources.pdf, True)
        Me.AgregarOpcion("ExportarWord", "Exportar a Word", My.Resources.word, True)
    End Sub

    Private Sub CbxPROVEEDOR_AF1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxPROVEEDOR_AF1.SelectedIndexChanged
        CargarSitios()
        CargarAreas()
    End Sub

    Private Sub CargarSitios()
        Me.CbxSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.CbxPROVEEDOR_AF1.SelectedValue, True)
    End Sub

    Private Sub CargarAreas()
        If Me.CbxSITIO_CAPACITACION1.SelectedValue <> -1 Then
            Me.CbxAREA_FORMACION1.RecuperarPorProveedorSitioEjercicio(Me.CbxPROVEEDOR_AF1.SelectedValue, Me.CbxSITIO_CAPACITACION1.SelectedValue, Me.CbxEJERCICIO1.SelectedValue, True)
        Else
            Me.CbxAREA_FORMACION1.RecuperarPorProveedorEjercicio(Me.CbxPROVEEDOR_AF1.SelectedValue, Me.CbxEJERCICIO1.SelectedValue, True)
        End If
    End Sub

    Public Overrides Sub EjecutarOpcion(ByVal asComando As String)
        If asComando = "RecuperarOferta" Then
            RecuperarOferta()
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

    Public Sub VistaPrevia()
        Me.GridControl1.ShowPrintPreview()
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

    End Sub

    Private Sub RecuperarOferta()

        Dim criterios As New List(Of Criteria)

        If Me.CbxPROVEEDOR_AF1.SelectedValue <> -1 Then
            criterios.Add(New Criteria("ID_PROVEEDOR_AF", "F", "=", Me.CbxPROVEEDOR_AF1.SelectedValue.ToString(), "AND"))
        End If

        criterios.Add(New Criteria("ID_EJERCICIO", "F", "=", Me.CbxEJERCICIO1.SelectedValue.ToString(), "AND"))

        If Me.CbxAREA_FORMACION1.SelectedValue <> -1 Then
            criterios.Add(New Criteria("ID_AREA_FORMACION", "=", Me.CbxAREA_FORMACION1.SelectedValue.ToString(), "AND"))
        End If

        If Me.CbxSITIO_CAPACITACION1.SelectedValue <> "-1" Then
            criterios.Add(New Criteria("ID_SITIO_CAPACITACION", "OS", "=", Me.CbxSITIO_CAPACITACION1.SelectedValue.ToString(), "AND"))
        End If

        If Me.CbxDEPARTAMENTO1.SelectedValue <> "" Then
            criterios.Add(New Criteria("CODIGO_DEPARTAMENTO", "S", "=", Me.CbxDEPARTAMENTO1.SelectedValue.ToString(), "AND"))
            If Me.CbxMUNICIPIO1.SelectedValue <> "" Then
                criterios.Add(New Criteria("CODIGO_MUNICIPIO", "S", "=", Me.CbxMUNICIPIO1.SelectedValue.ToString(), "AND"))
            End If
        End If

        Dim listaOferta As New listaOFERTA_FORMATIVA

        listaOferta = (New cOFERTA_FORMATIVA).ObtenerOfertaFormativaPorCriterios(criterios.ToArray(), True)

        Me.ListaOFERTAFORMATIVABindingSource.DataSource = listaOferta

    End Sub

    Private Sub CbxDEPARTAMENTO1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxDEPARTAMENTO1.SelectedIndexChanged
        Me.CbxMUNICIPIO1.Recuperar("01", Me.CbxDEPARTAMENTO1.SelectedValue, True)
    End Sub

End Class
