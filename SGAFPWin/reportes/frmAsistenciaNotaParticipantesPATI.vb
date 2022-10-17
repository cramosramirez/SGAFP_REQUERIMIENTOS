Imports DevExpress.XtraPivotGrid
Imports SQLMembershipProvider.BL
Imports System.Web.Security.Membership

Public Class frmAsistenciaNotaParticipantesPATI
    Private nombreArchivo As String = ""
    Dim _mp As cmembershipProvider
    Dim lRoles As New List(Of String)

    Public Enum formatoExportacion As Integer
        Excel = 1
        PDF = 2
        Word = 3
        CSV = 4
        HTML = 5
    End Enum

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


        _mp = CType(Provider, cmembershipProvider)
        lRoles = _mp.ObtenerRoles(EL.configuracion.usuarioActualiza)

        If lRoles.Contains(Enumeradores.RolDeUsuario.AuditorExterno) Then
            Me.CbxPROGRAMA_FORMACION1.SelectedValue = Enumeradores.ProgramasFormacion.PATI_BM
            Me.CbxPROGRAMA_FORMACION1.Enabled = False
            Me.Text = "PATI - Participantes"
            LayoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlItem10.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            LayoutControlItem11.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never

            For Each campoPivot As PivotGridField In Me.PivotGridControl1.Fields
                campoPivot.Visible = False
                campoPivot.Options.ShowInCustomizationForm = False
                campoPivot.Options.ShowInPrefilter = False
            Next
            Me.fieldPROVEEDOR1.Visible = True
            Me.fieldNUMEFAMI1.Visible = True
            Me.fieldNUMEFICH.Visible = True
            Me.fieldAPELLIDOS1.Visible = True
            Me.fieldNOMBRES1.Visible = True
            Me.fieldNOMBREACCIONFORMATIVA1.Visible = True
            Me.fieldCODIGOGRUPO1.Visible = True
            Me.fieldDEPARTAMENTORESIDENCIA1.Visible = True
            Me.fieldMUNICIPIORESIDENCIA1.Visible = True
            Me.fieldPROVEEDOR1.Options.ShowInPrefilter = True
            Me.fieldNUMEFAMI1.Options.ShowInPrefilter = True
            Me.fieldNUMEFICH.Options.ShowInPrefilter = True
            Me.fieldAPELLIDOS1.Options.ShowInPrefilter = True
            Me.fieldNOMBRES1.Options.ShowInPrefilter = True
            Me.fieldNOMBREACCIONFORMATIVA1.Options.ShowInPrefilter = True
            Me.fieldCODIGOGRUPO1.Options.ShowInPrefilter = True
            Me.fieldDEPARTAMENTORESIDENCIA1.Options.ShowInPrefilter = True
            Me.fieldMUNICIPIORESIDENCIA1.Options.ShowInPrefilter = True
            Me.fieldFECHAINICIOREAL1.Options.ShowInPrefilter = True
            Me.fieldFECHAINICIOREAL1.Visible = True
            Me.fieldFECHAFINREAL1.Options.ShowInPrefilter = True
            Me.fieldFECHAFINREAL1.Visible = True
            Me.fieldRANGOINICIADOS.Options.ShowInPrefilter = True
            Me.fieldRANGOINICIADOS.Visible = True
            Me.fieldRANGOINSCRITOS.Options.ShowInPrefilter = True
            Me.fieldRANGOINSCRITOS.Visible = True
            Me.fieldNIVELACADEMICO.Options.ShowInPrefilter = True
            Me.fieldNIVELACADEMICO.Visible = True
            Me.fieldIDACCIONFORMATIVA1.Options.ShowInPrefilter = True
            Me.fieldIDACCIONFORMATIVA1.Visible = True
        Else
            Me.PivotGridControl1.Prefilter.CriteriaString = "[PORC_ASISTENCIA] >= 80"
        End If

        If lRoles.Contains(Enumeradores.RolDeUsuario.Administrador) OrElse lRoles.Contains(Enumeradores.RolDeUsuario.CoordinadorPATI) OrElse _
           lRoles.Contains(Enumeradores.RolDeUsuario.AuditorExterno) Then
            Me.fieldRANGOINSCRITOS.Visible = True
            Me.fieldRANGOINSCRITOS.Options.ShowInPrefilter = True
            Me.fieldRANGOINSCRITOS.Options.ShowInCustomizationForm = True

            If lRoles.Contains(Enumeradores.RolDeUsuario.Administrador) OrElse lRoles.Contains(Enumeradores.RolDeUsuario.CoordinadorPATI) Then
                Me.fieldRANGOINICIADOS.Visible = True
                Me.fieldRANGOINICIADOS.Options.ShowInPrefilter = True
                Me.fieldRANGOINICIADOS.Options.ShowInCustomizationForm = True
            End If
        Else
            Me.fieldRANGOINSCRITOS.Visible = False
            Me.fieldRANGOINSCRITOS.Options.ShowInPrefilter = False
            Me.fieldRANGOINSCRITOS.Options.ShowInCustomizationForm = False

            Me.fieldRANGOINICIADOS.Visible = False
            Me.fieldRANGOINICIADOS.Options.ShowInPrefilter = False
            Me.fieldRANGOINICIADOS.Options.ShowInCustomizationForm = False
        End If
    End Sub

    Private Sub SetearConvocatoria()
        Dim listaConvocatorias As List(Of Integer) = (New cFUENTE_FINANCIAMIENTO).ObtenerListaConvocatoriasPorProgramaFormacion(Me.CbxPROGRAMA_FORMACION1.SelectedValue)
        If listaConvocatorias IsNot Nothing AndAlso listaConvocatorias.Count > 0 Then
            Me.txtNO_CONVOCATORIA.Text = listaConvocatorias(listaConvocatorias.Count - 1)
        Else
            Me.txtNO_CONVOCATORIA.Text = ""
        End If
    End Sub

    Private Sub InicializarVariables()
        Me.CbxPROGRAMA_FORMACION1.RecuperarListaPATI()
        Me.txtCODIGO_GRUPO.Text = ""
        Me.SetearConvocatoria()
        nombreArchivo = Me.CbxPROGRAMA_FORMACION1.Text + " Asistencia y Nota "
    End Sub

    Private Sub frmCursosProgramaPATI_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inicializar()
    End Sub
   
    Private Sub CbxDEPARTAMENTO1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxDEPARTAMENTO1.SelectedIndexChanged
        Me.CbxMUNICIPIO1.RecuperarListaPorDepartamentoProgramaFormacion(Me.CbxPROGRAMA_FORMACION1.SelectedValue, Me.CbxDEPARTAMENTO1.SelectedValue, True, False)
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

        Dim lIdProgramaFormacion As Decimal = -1
        Dim lNoConvocatoria As Decimal = -1
        Dim lIdProveedorAF As Decimal = -1
        Dim lCodigoGrupo As String = ""
        Dim lCodigoDepartamento As String = ""
        Dim lCodigoMunicipio As String = ""

        If Me.CbxPROGRAMA_FORMACION1.SelectedValue IsNot Nothing Then
            lIdProgramaFormacion = Me.CbxPROGRAMA_FORMACION1.SelectedValue
        End If
        If Me.txtNO_CONVOCATORIA.Text <> "" Then
            lNoConvocatoria = Me.txtNO_CONVOCATORIA.Text
        End If
        If Me.CbxPROVEEDOR_AF1.SelectedValue IsNot Nothing Then
            lIdProveedorAF = Me.CbxPROVEEDOR_AF1.SelectedValue
        End If
        If Me.CbxDEPARTAMENTO1.SelectedValue IsNot Nothing Then
            lCodigoDepartamento = Me.CbxDEPARTAMENTO1.SelectedValue
        End If
        If Me.CbxMUNICIPIO1.SelectedValue IsNot Nothing Then
            lCodigoMunicipio = Me.CbxMUNICIPIO1.SelectedValue
        End If
        lCodigoGrupo = Me.txtCODIGO_GRUPO.Text

        If lRoles.Contains(Enumeradores.RolDeUsuario.AuditorExterno) Then
            Me.PatiParticipantesAsistenciaNotasTableAdapter1.FillPorCursosProgramados(DS_DL1.PATIParticipantesAsistenciaNotas, lCodigoDepartamento, lCodigoMunicipio, lCodigoGrupo, lNoConvocatoria, lIdProgramaFormacion, lIdProveedorAF)
        Else
            Me.PatiParticipantesAsistenciaNotasTableAdapter1.FillPorCriterios(DS_DL1.PATIParticipantesAsistenciaNotas, lCodigoDepartamento, lCodigoMunicipio, lCodigoGrupo, lNoConvocatoria, lIdProgramaFormacion, lIdProveedorAF)
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub CbxPROGRAMA_FORMACION1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxPROGRAMA_FORMACION1.SelectedIndexChanged
        Me.CbxPROVEEDOR_AF1.RecuperarPorPROGRAMA_FORMACION(Me.CbxPROGRAMA_FORMACION1.SelectedValue, False, True)
        Me.CbxDEPARTAMENTO1.RecuperarListaPorProgramaFormacion(Me.CbxPROGRAMA_FORMACION1.SelectedValue, True, False)
        Me.CbxMUNICIPIO1.RecuperarListaPorDepartamentoProgramaFormacion(Me.CbxPROGRAMA_FORMACION1.SelectedValue, Me.CbxDEPARTAMENTO1.SelectedValue, True, False)
        Me.SetearConvocatoria()
        nombreArchivo = Me.CbxPROGRAMA_FORMACION1.Text + " Asistencia y Nota "
    End Sub

    Private Sub PivotGridControl1_CustomSummary(sender As Object, e As DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs) Handles PivotGridControl1.CustomSummary
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
        End If
    End Sub
End Class