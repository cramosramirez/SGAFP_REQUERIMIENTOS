Imports DevExpress.XtraPivotGrid
Imports SQLMembershipProvider.BL
Imports System.Web.Security

Public Class frmCursosProgramaPATI

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
        Me.AgregarOpcion("ExportarExcel", "Exportar a Excel", My.Resources.excel, True)
        Me.AgregarOpcion("ExportarPDF", "Exportar a PDF", My.Resources.pdf, True)
        Me.AgregarOpcion("ExportarWord", "Exportar a Word", My.Resources.word, True)
        Me.AgregarOpcion("GuardarLayout", "Guardar Layout", My.Resources.todo, True)
        Me.AgregarOpcion("RecuperarLayout", "Recuperar Layout", My.Resources.todo, True)
        Me.AgregarOpcion("LimpiarVariables", "Limpiar Variables", My.Resources.undofilter, True)

        Dim _mp As cmembershipProvider
        _mp = CType(Membership.Provider, cmembershipProvider)
        Dim lRoles As New List(Of String)
        lRoles = _mp.ObtenerRoles(EL.configuracion.usuarioActualiza)

        If Not (lRoles.Contains(Enumeradores.RolDeUsuario.Administrador) OrElse lRoles.Contains(Enumeradores.RolDeUsuario.GerenteUFI)) Then
            Me.PivotGridControl1.Fields("NUMERO_CHEQUE").Visible = False
            Me.PivotGridControl1.Fields("NUMERO_CHEQUE").Options.ShowInCustomizationForm = False
            Me.PivotGridControl1.Fields("NUMERO_CHEQUE").Options.ShowInPrefilter = False
            Me.PivotGridControl1.Fields("FECHA_CHEQUE").Visible = False
            Me.PivotGridControl1.Fields("FECHA_CHEQUE").Options.ShowInCustomizationForm = False
            Me.PivotGridControl1.Fields("FECHA_CHEQUE").Options.ShowInPrefilter = False
            Me.PivotGridControl1.Fields("MONTO_FUENTE").Visible = False
            Me.PivotGridControl1.Fields("MONTO_FUENTE").Options.ShowInCustomizationForm = False
            Me.PivotGridControl1.Fields("MONTO_FUENTE").Options.ShowInPrefilter = False
            Me.PivotGridControl1.Fields("FECHA_ELABORACION").Visible = False
            Me.PivotGridControl1.Fields("FECHA_ELABORACION").Options.ShowInCustomizationForm = False
            Me.PivotGridControl1.Fields("FECHA_ELABORACION").Options.ShowInPrefilter = False
            Me.PivotGridControl1.Fields("NO_LIQUIDACION").Visible = False
            Me.PivotGridControl1.Fields("NO_LIQUIDACION").Options.ShowInCustomizationForm = False
            Me.PivotGridControl1.Fields("NO_LIQUIDACION").Options.ShowInPrefilter = False
        End If
        If Not (lRoles.Contains(Enumeradores.RolDeUsuario.Administrador) OrElse lRoles.Contains(Enumeradores.RolDeUsuario.TecnicoGFIPATI)) Then
            Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.Visible = False
            Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.Options.ShowInCustomizationForm = False
            Me.fieldCOSTO_X_PARTICIPANTE_PROMEDIO.Options.ShowInPrefilter = False
            Me.fieldINSCRITOS.Visible = False
            Me.fieldINSCRITOS.Options.ShowInCustomizationForm = False
            Me.fieldINSCRITOS.Options.ShowInPrefilter = False
            Me.fieldINICIADOS.Visible = False
            Me.fieldINICIADOS.Options.ShowInCustomizationForm = False
            Me.fieldINICIADOS.Options.ShowInPrefilter = False
            Me.fieldSOLICITADOS.Visible = False
            Me.fieldSOLICITADOS.Options.ShowInCustomizationForm = False
            Me.fieldSOLICITADOS.Options.ShowInPrefilter = False
            Me.fieldRANGO_INICIADOS.Visible = False
            Me.fieldRANGO_INICIADOS.Options.ShowInCustomizationForm = False
            Me.fieldRANGO_INICIADOS.Options.ShowInPrefilter = False
            Me.fieldRANGO_INSCRITOS.Visible = False
            Me.fieldRANGO_INSCRITOS.Options.ShowInCustomizationForm = False
            Me.fieldRANGO_INSCRITOS.Options.ShowInPrefilter = False
        End If

        If lRoles.Contains(Enumeradores.RolDeUsuario.AuditorExterno) Then
            Me.CbxPROGRAMA_FORMACION1.SelectedValue = Enumeradores.ProgramasFormacion.PATI_BM
            Me.CbxPROGRAMA_FORMACION1.Enabled = False
            LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            For Each campoPivot As PivotGridField In Me.PivotGridControl1.Fields
                campoPivot.Visible = False
                campoPivot.Options.ShowInCustomizationForm = False
                campoPivot.Options.ShowInPrefilter = False
            Next
            If Me.Text = "PATI - Pagos" Then
                Me.fieldNOMBREDEPARTAMENTO1.Visible = True
                Me.fieldNOMBREMUNICIPIO1.Visible = True
                Me.fieldPROVEEDOR1.Visible = True
                Me.fieldNOMBREACCIONFORMATIVA1.Visible = True
                Me.fieldCODIGOGRUPO1.Visible = True
                Me.fieldIDACCIONFORMATIVA1.Visible = True
                Me.fieldNUMERODOCUMENTO1.Visible = True
                Me.fieldNUMEROQUEDAN1.Visible = True
                Me.fieldFECHAQUEDAN1.Visible = True
                Me.fieldNUMEROCHEQUE1.Visible = True
                Me.fieldFECHACHEQUE1.Visible = True
                Me.fieldMONTO1.Visible = True
                Me.fieldFECHAINICIOREAL1.Visible = True
                Me.fieldFECHAFINREAL1.Visible = True
                Me.fieldFECHARECEPCION.Visible = True
                Me.fieldNOMBREDEPARTAMENTO1.Options.ShowInPrefilter = True
                Me.fieldNOMBREMUNICIPIO1.Options.ShowInPrefilter = True
                Me.fieldPROVEEDOR1.Options.ShowInPrefilter = True
                Me.fieldFECHAINICIOREAL1.Options.ShowInPrefilter = True
                Me.fieldFECHAFINREAL1.Options.ShowInPrefilter = True
                Me.fieldNOMBREACCIONFORMATIVA1.Options.ShowInPrefilter = True
                Me.fieldCODIGOGRUPO1.Options.ShowInPrefilter = True
                Me.fieldIDACCIONFORMATIVA1.Options.ShowInPrefilter = True
                Me.fieldNUMERODOCUMENTO1.Options.ShowInPrefilter = True
                Me.fieldNUMEROQUEDAN1.Options.ShowInPrefilter = True
                Me.fieldFECHAQUEDAN1.Options.ShowInPrefilter = True
                Me.fieldNUMEROCHEQUE1.Options.ShowInPrefilter = True
                Me.fieldFECHACHEQUE1.Options.ShowInPrefilter = True
                Me.fieldMONTO1.Options.ShowInPrefilter = True
                Me.fieldFECHARECEPCION.Options.ShowInPrefilter = True
            Else
                Me.fieldNOMBREDEPARTAMENTO1.Visible = True
                Me.fieldNOMBREMUNICIPIO1.Visible = True
                Me.fieldPROVEEDOR1.Visible = True
                Me.fieldNOMBREACCIONFORMATIVA1.Visible = True
                Me.fieldCODIGOGRUPO1.Visible = True
                Me.fieldFECHAINICIOREAL1.Visible = True
                Me.fieldFECHAFINREAL1.Visible = True
                Me.fieldNOMBREESTADOAF.Visible = True
                Me.fieldIDACCIONFORMATIVA1.Visible = True
                Me.fieldNOMBREDEPARTAMENTO1.Options.ShowInPrefilter = True
                Me.fieldNOMBREMUNICIPIO1.Options.ShowInPrefilter = True
                Me.fieldPROVEEDOR1.Options.ShowInPrefilter = True
                Me.fieldNOMBREACCIONFORMATIVA1.Options.ShowInPrefilter = True
                Me.fieldCODIGOGRUPO1.Options.ShowInPrefilter = True
                Me.fieldFECHAINICIOREAL1.Options.ShowInPrefilter = True
                Me.fieldFECHAFINREAL1.Options.ShowInPrefilter = True
                Me.fieldNOMBREESTADOAF.Options.ShowInPrefilter = True
                Me.fieldIDACCIONFORMATIVA1.Options.ShowInPrefilter = True
            End If
        End If
    End Sub

    Private Sub InicializarVariables()
        Me.CbxPROGRAMA_FORMACION1.RecuperarListaPATI()
        Me.CbxESTADO_ACCION_FORMATIVA1.Recuperar(True)
        Me.CbxPROVEEDOR_AF1.RecuperarPorPROGRAMA_FORMACION(Me.CbxPROGRAMA_FORMACION1.SelectedValue, False, True)
        Me.SetearConvocatoria()
        nombreArchivo = Me.CbxPROGRAMA_FORMACION1.Text + " Ejecucion "
    End Sub

    Private Sub frmCursosProgramaPATI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        Me.txtOrdenCompra.Text = ""
        Me.txtTDR.Text = ""
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
        Dim lIdProveedorAF As Decimal = -1
        Dim lTdr As String = ""
        Dim lResolucion As String = ""
        Dim lCodigoEstadoAF As String = ""

        If Me.CbxPROGRAMA_FORMACION1.SelectedValue IsNot Nothing Then
            lIdFuente = Utilerias.ObtenerFuentePorProgramaFormacion(CInt(Me.CbxPROGRAMA_FORMACION1.SelectedValue))
        End If
        If Me.txtNO_CONVOCATORIA.Text <> "" Then
            If Me.txtNO_CONVOCATORIA.Text <> "0" Then
                lNoConvocatoria = Me.txtNO_CONVOCATORIA.Text
            End If
        End If
        If Me.CbxPROVEEDOR_AF1.SelectedValue IsNot Nothing Then
            lIdProveedorAF = Me.CbxPROVEEDOR_AF1.SelectedValue
        End If
        lTdr = Me.txtTDR.Text
        lResolucion = Me.txtOrdenCompra.Text
        If Me.CbxESTADO_ACCION_FORMATIVA1.SelectedValue IsNot Nothing Then
            lCodigoEstadoAF = Me.CbxESTADO_ACCION_FORMATIVA1.SelectedValue
        End If

        If EstaEnRol(Enumeradores.RolDeUsuario.AuditorExterno) Then
            If Me.Text = "PATI - Pagos" Then
                Me.PatiEjecucionTableAdapter1.FillPorCursosConQuedan(Me.DS_DL1.PATIEjecucion, lIdFuente, lIdProveedorAF, lNoConvocatoria, lCodigoEstadoAF, lTdr, lResolucion)
            Else
                Me.PatiEjecucionTableAdapter1.FillPorCursosProgramados(Me.DS_DL1.PATIEjecucion, lIdFuente, lIdProveedorAF, lNoConvocatoria, lTdr, lResolucion)
            End If
        Else
            Me.PatiEjecucionTableAdapter1.Fill(Me.DS_DL1.PATIEjecucion, lIdFuente, lIdProveedorAF, lNoConvocatoria, lCodigoEstadoAF, lTdr, lResolucion)
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub PivotGridControl1_CustomSummary(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs) Handles PivotGridControl1.CustomSummary
        If e.DataField Is fieldIDACCIONFORMATIVA1 Then
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

        ElseIf e.DataField Is fieldCOSTO_X_PARTICIPANTE_PROMEDIO Then
            Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
            Dim i As Integer
            Dim TotalCostoCurso As Decimal = 0
            Dim TotalParticipantes As Integer = 0
            For i = 0 To ds.RowCount - 1
                Dim row As PivotDrillDownDataRow = ds(i)
                TotalCostoCurso += row(fieldMONTO1)
                TotalParticipantes += row(fieldACTIVOS1)
            Next
            If TotalParticipantes > 0 Then e.CustomValue = Utilerias.Truncar(TotalCostoCurso / TotalParticipantes, 4).ToString("#,##0.####") Else e.CustomValue = 0
        Else
            Return
        End If

    End Sub

    Private Sub PivotGridControl1_CustomUnboundFieldData(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.CustomFieldDataEventArgs) Handles PivotGridControl1.CustomUnboundFieldData
        If e.Field.FieldName = "fieldAUP" Then
            Dim strAup As String = (New cACCION_FORMATIVA).ObtenerListaAUPsPorAccionFormativa( _
                Convert.ToDecimal(e.GetListSourceColumnValue("ID_ACCION_FORMATIVA")))
            e.Value = strAup

        ElseIf e.Field.Name = "fieldRANGO_INSCRITOS" Then
            Dim lInscritos As Decimal = Convert.ToDecimal(e.GetListSourceColumnValue("INSCRITOS"))
            If lInscritos < 15 Then
                e.Value = " Menor de 15"
            ElseIf lInscritos >= 15 AndAlso lInscritos <= 20 Then
                e.Value = "Entre 15 y 20"
            Else
                e.Value = "Mayor de 20"
            End If

        ElseIf e.Field.Name = "fieldRANGO_INICIADOS" Then
            Dim lIniciados As Decimal = Convert.ToDecimal(e.GetListSourceColumnValue("INICIADOS"))
            If lIniciados < 15 Then
                e.Value = " Menor de 15"
            ElseIf lIniciados >= 15 AndAlso lIniciados <= 20 Then
                e.Value = "Entre 15 y 20"
            Else
                e.Value = "Mayor de 20"
            End If
        End If
    End Sub

    Private Sub CbxPROGRAMA_FORMACION1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxPROGRAMA_FORMACION1.SelectedIndexChanged
        Me.CbxPROVEEDOR_AF1.RecuperarPorPROGRAMA_FORMACION(Me.CbxPROGRAMA_FORMACION1.SelectedValue, False, True)
        Me.SetearConvocatoria()
        nombreArchivo = Me.CbxPROGRAMA_FORMACION1.Text + " Ejecucion "
    End Sub
End Class