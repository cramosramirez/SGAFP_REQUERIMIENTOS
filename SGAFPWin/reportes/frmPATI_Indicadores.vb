Imports DevExpress.XtraPivotGrid
Imports SQLMembershipProvider.BL
Imports System.Web.Security
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Public Class frmPATI_Indicadores

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
            Me.txtNO_CONVOCATORIA.Text = listaConvocatorias(listaConvocatorias.Count - 1)
        Else
            Me.txtNO_CONVOCATORIA.Text = ""
        End If
    End Sub

    Private Sub Inicializar()
        Me.InicializarVariables()
        Me.AgregarOpcion("Recargar", "Ver Reporte", My.Resources.DB, True)
        Me.AgregarOpcion("Imprimir", "Imprimir", My.Resources.print, True)
        Me.AgregarOpcion("VistaPrevia", "Vista Previa", My.Resources.print_preview, True)
        Me.AgregarOpcion("ExportarExcel", "Exportar resultados a Excel", My.Resources.excel, True)
        Me.AgregarOpcion("GuardarLayout", "Guardar Layout", My.Resources.todo, True)
        Me.AgregarOpcion("RecuperarLayout", "Recuperar Layout", My.Resources.todo, True)
        Me.AgregarOpcion("LimpiarVariables", "Limpiar Variables", My.Resources.undofilter, True)

    End Sub

    Private Sub InicializarVariables()
        Me.CbxPROGRAMA_FORMACION1.RecuperarListaPATI()
        Me.SetearConvocatoria()
        nombreArchivo = Me.CbxPROGRAMA_FORMACION1.Text + " Ejecucion "
    End Sub

    Private Sub frmCursosProgramaPATI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inicializar()
    End Sub

    Private Sub GenerarArchivoExcel()
        Dim bSIPUGeneracion As New cSIPU_GENERACION
        Dim bSIPUCapacitaciones As New cSIPU_CAPACITACIONES
        Dim bSIPUDetalle As New cSIPU_DETALLECAPACITADO
        Dim listageneracion As listaSIPU_GENERACION
        Dim lIdFuente As Decimal = -1
        Dim lNoConvocatoria As Decimal = -1
        Dim dsCapacitacion As DataSet
        Dim dsCapacitados As DataSet
        Dim nombreArchivo As String
        Dim lCriterios As New List(Of Criteria)

        If Me.CbxPROGRAMA_FORMACION1.SelectedValue Is Nothing Then
            AsignarMensaje("Seleccione el programa de formación", True)
            Return
        End If
        If Me.txtNO_CONVOCATORIA.Text = "" OrElse Me.txtNO_CONVOCATORIA.Text = 0 Then
            AsignarMensaje("Ingrese la convocatoria", True)
            Return
        End If
        lIdFuente = Utilerias.ObtenerFuentePorProgramaFormacion(CInt(Me.CbxPROGRAMA_FORMACION1.SelectedValue))
        lNoConvocatoria = Convert.ToDecimal(Me.txtNO_CONVOCATORIA.Text)

        lCriterios.Add(New Criteria("FUENTE", "=", lIdFuente.ToString, "AND"))
        lCriterios.Add(New Criteria("NUMERO_CONVOCATORIA", "=", lNoConvocatoria.ToString, ""))
        listageneracion = bSIPUGeneracion.ObtenerListaPorBusqueda(New SIPU_GENERACION, lCriterios.ToArray)
        If listageneracion IsNot Nothing AndAlso listageneracion.Count > 0 Then
            AsignarMensaje("La exportación de la Fuente y convocatoria fué realizada el " + listageneracion(0).FECHA.ToString("dd/MM/yyyy"), True)
            Return
        End If
        Me.SaveFileDialog1.InitialDirectory = System.Environment.SpecialFolder.MyDocuments
        Me.SaveFileDialog1.Filter = "Archivo Excel |*.xlsx"
        If Not Me.SaveFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Return
        End If
        nombreArchivo = Me.SaveFileDialog1.FileName
        If nombreArchivo.Trim = "" Then
            AsignarMensaje("Ingrese el nombre del archivo", True)
            Return
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        dsCapacitacion = bSIPUCapacitaciones.ObtenerDataSetSIPU_CAPACITACIONES(lIdFuente, Me.txtNO_CONVOCATORIA.Text)
        If dsCapacitacion IsNot Nothing Then
            dsCapacitados = bSIPUDetalle.ObtenerDataSetSIPU_DETALLECAPACITADO(lIdFuente, Me.txtNO_CONVOCATORIA.Text)
            If dsCapacitados IsNot Nothing Then
                If ExportarExcel(dsCapacitados.Tables(0), nombreArchivo, "SIPU_DetalleCapacitado", True) Then
                    If ExportarExcel(dsCapacitacion.Tables(0), nombreArchivo, "SIPU_Capacitaciones") Then
                        Dim lSIPUGeneracion As New SIPU_GENERACION
                        Dim lRet As Integer

                        lSIPUGeneracion.ID_GENERACION = 0
                        lSIPUGeneracion.FUENTE = lIdFuente
                        lSIPUGeneracion.NUMERO_CONVOCATORIA = lNoConvocatoria
                        lSIPUGeneracion.FECHA = Today
                        lSIPUGeneracion.NOMBRE_ARCHIVO = nombreArchivo
                        lSIPUGeneracion.USUARIO_CREACION = Me.usuarioActualizacion
                        lSIPUGeneracion.FECHA_CREACION = Now
                        lSIPUGeneracion.USERID = Me.usuarioActualizacion
                        lSIPUGeneracion.LASTUPDATE = Now

                        If bSIPUGeneracion.ActualizarSIPU_GENERACION(lSIPUGeneracion, TipoConcurrencia.Pesimistica) >= 1 Then
                            lRet = bSIPUCapacitaciones.AgregarLotePorFuenteConvocatoria(lIdFuente, lNoConvocatoria, lSIPUGeneracion.ID_GENERACION)
                            If lRet <= 0 Then
                                Me.Cursor = System.Windows.Forms.Cursors.Default
                                AsignarMensaje("Error al registrar los datos en el sistema: " + bSIPUCapacitaciones.sError, False)
                                Return
                            End If
                            lRet = bSIPUDetalle.AgregarLotePorFuenteConvocatoria(lIdFuente, lNoConvocatoria)
                            If lRet <= 0 Then
                                Me.Cursor = System.Windows.Forms.Cursors.Default
                                AsignarMensaje("Error al registrar los datos en el sistema: " + bSIPUCapacitaciones.sError, False)
                                Return
                            End If
                            AsignarMensaje("La exportación se realizó con éxito", False)
                        End If
                    End If
                End If
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Function ExportarExcel(ByVal DT As DataTable, ByVal nombreArchivo As String, ByVal nombreHoja As String, Optional ByVal eliminarHojas As Boolean = False) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Dim existeHoja As Boolean = False
        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exApp.DisplayAlerts = False
            If Not My.Computer.FileSystem.FileExists(nombreArchivo) Then
                exLibro = exApp.Workbooks.Add
                exLibro.SaveAs(nombreArchivo)
                exLibro = Nothing
            End If
            exLibro = exApp.Workbooks.Open(nombreArchivo)
            If eliminarHojas Then
                For Each obj As Object In exLibro.Worksheets
                    Dim hoja As Microsoft.Office.Interop.Excel.Worksheet = CType(obj, Microsoft.Office.Interop.Excel.Worksheet)
                    If hoja.Name.ToUpper.Trim = nombreHoja.ToUpper.Trim Then
                        hoja.ClearArrows()
                        exHoja = hoja
                        existeHoja = True
                    End If
                Next
                If Not existeHoja Then
                    exHoja = exLibro.Worksheets.Add()
                    exHoja.Name = nombreHoja
                End If
                For Each obj As Object In exLibro.Worksheets
                    Dim hoja As Microsoft.Office.Interop.Excel.Worksheet = CType(obj, Microsoft.Office.Interop.Excel.Worksheet)
                    If hoja.Name.ToUpper.Trim <> nombreHoja.ToUpper.Trim Then
                        hoja.Delete()
                    End If
                Next
            Else
                exHoja = exLibro.Worksheets.Add()
                exHoja.Name = nombreHoja
            End If
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DT.Columns.Count
            Dim NRow As Integer = DT.Rows.Count
            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DT.Columns(i - 1).ColumnName.ToString
                'exHoja.Cells.AutoFormat(vFormato)
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = DT.Rows(Fila).Item(Col).ToString()
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()

            'Aplicación visible
            'exApp.Application.Visible = True
            exLibro.Save()
            exLibro.Close()
            exApp.DisplayAlerts = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
            Return True

        Catch ex As Exception
            ExceptionManager.Publish(ex)
            exApp.DisplayAlerts = True
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return False
        End Try
        Return True
    End Function

    Public Overrides Sub EjecutarOpcion(ByVal asComando As String)
        Select Case asComando
            Case "Recargar"
                RecuperarDatos()
            Case "Imprimir"
                Imprimir()
            Case "VistaPrevia"
                VistaPrevia()
            Case "ExportarExcel"
                GenerarArchivoExcel()
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
        If Not Me.OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Return
        End If
        Me.PivotGridControl1.RestoreLayoutFromXml(Me.OpenFileDialog1.FileName)
    End Sub

    Private Sub GuardarLayout()
        Me.SaveFileDialog1.FileName = Now.ToString("ddMMyyyyhhmmss") + ".lay"
        Me.SaveFileDialog1.InitialDirectory = System.Environment.SpecialFolder.MyDocuments
        Me.SaveFileDialog1.Filter = "Archivo Layout |*.lay"
        If Not Me.SaveFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
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
                If Not Me.SaveFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                    Return
                End If
            Case Else
                Return
        End Select
        lsFile = Me.SaveFileDialog1.FileName

        Select Case formato
            Case formatoExportacion.Excel
                Me.PivotGridControl1.ExportToXls(lsFile)
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
        If Me.txtNO_CONVOCATORIA.Text <> "" Then
            If Me.txtNO_CONVOCATORIA.Text <> "0" Then
                lNoConvocatoria = Me.txtNO_CONVOCATORIA.Text
            End If
        End If

        Me.PatI_INDICADORESTableAdapter1.FillPorFuenteConvocatoria(Me.DS_DL1.PATI_INDICADORES, lIdFuente, lNoConvocatoria)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub CbxPROGRAMA_FORMACION1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxPROGRAMA_FORMACION1.SelectedIndexChanged
        Me.SetearConvocatoria()
        nombreArchivo = Me.CbxPROGRAMA_FORMACION1.Text + " Ejecucion "
    End Sub
End Class