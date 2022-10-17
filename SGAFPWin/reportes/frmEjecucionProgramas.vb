Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPrinting
Imports SQLMembershipProvider.BL
Imports System.Web.Security.Membership
Imports System.Text
Imports SGAFP.EL.Enumeradores

Public Class frmEjecucionProgramas
    Private nombreArchivo As String = ""

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

        If Me.EstaEnRol(Enumeradores.RolDeUsuario.Administrador) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.JefeHTP) _
            OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.TecnicoCentroHTP) Then
            Me.fieldNUMCONTRATO.Visible = True
            Me.fieldTOTALPAGO.Visible = True
            Me.fieldNOMBRESUBAREA.Visible = True
            Me.fieldADJUDICADOSUBAREA.Visible = True
            Me.fieldCOSTOXPARTICIPANTE.Visible = True
            Me.fieldNUMLICITACION.Visible = True
            Me.fieldEJERCICIOLICITACION.Visible = True
            Me.fieldNOMBRESUBAREA.Visible = True
            Me.fieldCOSTOXPARTICIPANTE.Visible = True
            Me.fieldNUMLICITACION.Visible = True
            Me.fieldNOMBREESTADOAF1.Visible = True
            Me.fieldTOTALPAGO.Visible = True
            Me.fieldTOTALPAGO.Visible = True
            Me.fieldTECNICO_ASIGNADO.Visible = True
            Me.fieldACTUALIZACION.Visible = True
            Me.fieldResolucion.Visible = False
            Me.fieldESTADOINFORME.Visible = True
            Me.fieldDESCRIPCIONESTADOINFORME.Visible = True
        End If
        If Me.EstaEnRol(Enumeradores.RolDeUsuario.Administrador) OrElse Me.EstaEnRol(Enumeradores.RolDeUsuario.Auditor) Then
            Me.fieldNOMBREESTADOAF1.Visible = True
            Me.tabParticipantes.PageVisible = True
            Me.fieldResolucion.Visible = True
        End If
    End Sub

    Private Sub InicializarVariables()
        Dim c As cmembershipProvider
        c = CType(Provider, cmembershipProvider)

        Me.CbxPROGRAMA_FORMACION1.RecuperarPorRoles(c.ObtenerRoles(Utilerias.ObtenerUsuario))
        Me.CbxPROVEEDOR_AF1.RecuperarPorPROGRAMA_FORMACION(Me.CbxPROGRAMA_FORMACION1.SelectedValue, False, True)
        Me.SpnNO_CONVOCATORIA.Value = 1
        Me.CbxEJERCICIO1.Recuperar(True, False)
        Select Case Me.CbxPROGRAMA_FORMACION1.SelectedValue
            Case ProgramasFormacion.PATI_BM, ProgramasFormacion.PATI_USAID
                Me.SpnNO_CONVOCATORIA.Enabled = True
                Me.CbxSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(-1, False, True)
                Me.CbxSITIO_CAPACITACION1.Enabled = False
            Case Else
                Me.SpnNO_CONVOCATORIA.Enabled = False
                Me.CbxSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.CbxPROVEEDOR_AF1.SelectedValue, True, False)
                Me.CbxSITIO_CAPACITACION1.Enabled = True
        End Select
        Me.CbxClasificacion.Items.Add("[Todos]")
        Me.CbxClasificacion.Items.Add("Por Iniciar")
        Me.CbxClasificacion.Items.Add("En Ejecución")
        Me.CbxClasificacion.Items.Add("Finalizados")
        Me.CbxClasificacion.SelectedIndex = 0
        Me.CbxEJERCICIO1.SelectedValue = Now.Year.ToString
        Me.TxtNUM_LICITACION.Text = ""
        Me.SpnID_EJERCICIO_LICITACION.Value = 0
        nombreArchivo = Me.CbxPROGRAMA_FORMACION1.Text + " Ejecucion "
    End Sub

    Private Sub frmEjecucionProgramas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

    Private Sub CbxPROVEEDOR_AF1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxPROVEEDOR_AF1.SelectedIndexChanged
        Me.CbxSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(CbxPROVEEDOR_AF1.SelectedValue, True, False)
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
                If Me.XtraTabControl1.SelectedTabPageIndex = 0 Then
                    Me.PivotGridControl1.ExportToXls(lsFile)
                Else
                    Me.GridParticipantes.ExportToXls(lsFile)
                End If
            Case formatoExportacion.Word
                If Me.XtraTabControl1.SelectedTabPageIndex = 0 Then
                    Me.PivotGridControl1.ExportToRtf(lsFile)
                Else
                    Me.GridParticipantes.ExportToRtf(lsFile)
                End If
            Case formatoExportacion.PDF
                If Me.XtraTabControl1.SelectedTabPageIndex = 0 Then
                    Me.PivotGridControl1.ExportToPdf(lsFile)
                Else
                    Me.GridParticipantes.ExportToPdf(lsFile)
                End If
            Case formatoExportacion.CSV
                If Me.XtraTabControl1.SelectedTabPageIndex = 0 Then
                    Me.PivotGridControl1.ExportToCsv(lsFile)
                Else
                    AsignarMensaje("Formato no disponible para esta consulta")
                End If
            Case formatoExportacion.HTML
                If Me.XtraTabControl1.SelectedTabPageIndex = 0 Then
                    Me.PivotGridControl1.ExportToHtml(lsFile)
                Else
                    Me.GridParticipantes.ExportToHtml(lsFile)
                End If
            Case Else
                Return
        End Select
    End Sub

    Public Sub RecuperarDatos()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim lIdProgramaFormacion As Decimal = -1
        Dim lNoConvocatoria As Decimal = -1
        Dim lIdProveedorAF As Decimal = -1
        Dim lIdSitioCapacitacion As Decimal = -1
        Dim lEjercicio As String = ""
        Dim lClasificacion As Decimal = -1
        Dim lEjercicioLicitacion As String = ""

        If Me.CbxPROGRAMA_FORMACION1.SelectedValue IsNot Nothing Then
            lIdProgramaFormacion = Me.CbxPROGRAMA_FORMACION1.SelectedValue
        End If
        If Me.SpnNO_CONVOCATORIA.Value > 0 AndAlso Me.SpnNO_CONVOCATORIA.Enabled Then
            lNoConvocatoria = Me.SpnNO_CONVOCATORIA.Value
        End If
        If Me.CbxPROVEEDOR_AF1.SelectedValue IsNot Nothing Then
            lIdProveedorAF = Me.CbxPROVEEDOR_AF1.SelectedValue
        End If
        If Me.CbxSITIO_CAPACITACION1.SelectedValue IsNot Nothing AndAlso Me.CbxSITIO_CAPACITACION1.Enabled Then
            lIdSitioCapacitacion = Me.CbxSITIO_CAPACITACION1.SelectedValue
        End If
        If Me.CbxEJERCICIO1.SelectedValue IsNot Nothing Then
            lEjercicio = Me.CbxEJERCICIO1.SelectedValue
        End If
        If Me.CbxEJERCICIO1.SelectedValue IsNot Nothing Then
            lEjercicio = Me.CbxEJERCICIO1.SelectedValue
        End If
        If SpnID_EJERCICIO_LICITACION.Value > 0 Then
            lEjercicioLicitacion = SpnID_EJERCICIO_LICITACION.Value.ToString
        End If
        Select Case Me.CbxClasificacion.Text
            Case "Por Iniciar"
                lClasificacion = 1
            Case "En Ejecución"
                lClasificacion = 2
            Case "Finalizados"
                lClasificacion = 3
        End Select
        PivotGridControl1.OptionsView.ShowRowTotals = False
        PivotGridControl1.OptionsView.ShowRowGrandTotals = False
        PivotGridControl1.OptionsView.ShowColumnTotals = False
        PivotGridControl1.OptionsView.ShowColumnGrandTotals = False
        Me.ProgramacionCursosFormacionTableAdapter1.FillByCriterios(Me.DS_DL1.ProgramacionCursosFormacion, lIdProgramaFormacion, lIdProveedorAF, lIdSitioCapacitacion, lEjercicio, "", TxtNUM_LICITACION.Text.Replace("_/____", ""), lEjercicioLicitacion, lClasificacion, lNoConvocatoria)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub PivotGridControl1_CustomSummary(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs) Handles PivotGridControl1.CustomSummary
        If e.DataField Is fieldIDCURSO1 Then
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
            'ElseIf e.DataField Is fieldTOTALPAGO Then
            '    Dim name As String = e.DataField.FieldName

            '    If e.DataField.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom Then
            '        Dim list As IList = e.CreateDrillDownDataSource()
            '        Dim monto As Decimal = 0
            '        If list IsNot Nothing AndAlso list.Count > 0 Then
            '            Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = CType(list(0), DevExpress.XtraPivotGrid.PivotDrillDownDataRow)

            '            Dim v As Object = row(name)

            '            If Not IsNothing(v) AndAlso (Not v Is DBNull.Value) Then
            '                monto += Convert.ToDecimal(v)
            '            End If
            '        End If
            '        e.CustomValue = monto
            '    End If
        Else

            Return
        End If
    End Sub

    Private Sub PivotGridControl1_CellDoubleClick(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCellEventArgs) Handles PivotGridControl1.CellDoubleClick
        If Me.tabParticipantes.PageVisible Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim list As IList = e.CreateDrillDownDataSource()
            Dim ht As Hashtable = New Hashtable
            For i As Integer = 0 To list.Count - 1
                Dim row As DevExpress.XtraPivotGrid.PivotDrillDownDataRow = CType(list(i), DevExpress.XtraPivotGrid.PivotDrillDownDataRow)

                Dim v As Object = row("ID_CURSO")

                If Not IsNothing(v) AndAlso (Not v Is DBNull.Value) Then
                    Me.AsistenciaRealAccionFormativaTableAdapter1.FillPorAccionFormativa(DS_DL1.AsistenciaRealAccionFormativa, CDec(v))
                    XtraTabControl1.SelectedTabPageIndex = 1
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            Next
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Function formatoMes(ByVal e As String) As String
        Dim valor As New StringBuilder(e)
        valor.Replace("01/", "ENE/")
        valor.Replace("02/", "FEB/")
        valor.Replace("03/", "MAR/")
        valor.Replace("04/", "ABR/")
        valor.Replace("05/", "MAY/")
        valor.Replace("06/", "JUN/")
        valor.Replace("07/", "JUL/")
        valor.Replace("08/", "AGO/")
        valor.Replace("09/", "SEP/")
        valor.Replace("10/", "OCT/")
        valor.Replace("11/", "NOV/")
        valor.Replace("12/", "DIC/")
        Return valor.ToString
    End Function

    Private Sub GridViewParticipantes_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridViewParticipantes.CustomUnboundColumnData
        If e.Column.FieldName = "HORAS_ASISTIDAS" Then
            Dim fila As DataRow = GridViewParticipantes.GetDataRow(e.ListSourceRowIndex)
            Dim valorEnMinutos As Decimal = CDec(fila("MINUTOS_ASISTIDOS"))
            Dim hrs As Integer
            hrs = valorEnMinutos \ 60
            e.Value = hrs.ToString("00") + ":" + (valorEnMinutos - (hrs * 60)).ToString("00")
        ElseIf e.Column.FieldName = "DIAS_ASISTIDOS_GEN" Then
            Dim fila As DataRow = GridViewParticipantes.GetDataRow(e.ListSourceRowIndex)
            Dim lDiasAsistidos As String = fila("DIAS_ASISTIDOS").ToString
            e.Value = formatoMes(lDiasAsistidos)
        End If
    End Sub

    Private Sub PivotGridControl1_CustomUnboundFieldData(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.CustomFieldDataEventArgs) Handles PivotGridControl1.CustomUnboundFieldData
        If e.Field Is fieldResolucion Then
            Dim idAccionFormativa As Decimal = e.GetListSourceColumnValue("ID_CURSO")
            Dim lEntidad As TERMINO_REFERENCIA_AF = (New cTERMINO_REFERENCIA_AF).ObtenerTERMINO_REFERENCIA_AF(idAccionFormativa)
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.RESOLUCION
            End If
        End If
    End Sub

    Private Sub CbxPROGRAMA_FORMACION1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxPROGRAMA_FORMACION1.SelectedIndexChanged
        Me.CbxPROVEEDOR_AF1.RecuperarPorPROGRAMA_FORMACION(Me.CbxPROGRAMA_FORMACION1.SelectedValue, False, True)
        Select Case Me.CbxPROGRAMA_FORMACION1.SelectedValue
            Case ProgramasFormacion.PATI_BM, ProgramasFormacion.PATI_USAID, ProgramasFormacion.PATI_2
                Me.SpnNO_CONVOCATORIA.Enabled = True
                Me.CbxSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(-1, False, True)
                Me.CbxSITIO_CAPACITACION1.Enabled = False
                Me.TxtNUM_LICITACION.Text = "_/____"
                Me.TxtNUM_LICITACION.Enabled = False
            Case Else
                Me.SpnNO_CONVOCATORIA.Enabled = False
                Me.CbxSITIO_CAPACITACION1.RecuperarPorPROVEEDOR_AF(Me.CbxPROVEEDOR_AF1.SelectedValue, True, False)
                Me.CbxSITIO_CAPACITACION1.Enabled = True
                Me.TxtNUM_LICITACION.Enabled = True
        End Select
    End Sub
End Class