Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPrinting
Imports SQLMembershipProvider.BL
Imports System.Web.Security.Membership
Imports System.Text
Imports SGAFP.EL.Enumeradores
Imports Microsoft.ApplicationBlocks.ExceptionManagement

Public Class frmGenerarReporteExcelBolrpros
    Private nombreArchivo As String = ""

    Private Sub Inicializar()
        Me.InicializarVariables()
        Me.AgregarOpcion("Generar", "Generar archivo en excel", My.Resources.DB, True)
        Me.AgregarOpcion("LimpiarVariables", "Limpiar Variables", My.Resources.undofilter, True)
    End Sub

    Private Sub InicializarVariables()
        Dim c As cmembershipProvider
        c = CType(Provider, cmembershipProvider)
        Me.LimpiarCampos()
    End Sub

    Private Sub LimpiarCampos()
        Me.CbxCONTRATO_COMPRA1.Recuperar(False, True)
        Me.txtNUM_CONTRATO.Text = ""
        Me.txtNUM_ITEM.Text = ""
        Me.CbxPROVEEDOR_AF1.Recuperar(False, True)
        Me.txtNOMBRE_ACCION_FORMATIVA.Text = ""
        Me.txtID_SOLICITUD.Text = ""
        Me.CbxCENTRO_RESPONSABILIDAD1.Recuperar()
        Me.CbxCENTRO_RESPONSABILIDAD1.SelectedIndex = -1
        Me.txtNOMBRE_REFERENTE.Text = ""
        Me.CbxAREA_FORMACION1.Recuperar(True)
        Me.CbxDEPARTAMENTO1.Recuperar(True)
        Me.CbxMUNICIPIO1.RecuperarPorDEPARTAMENTO(Me.CbxDEPARTAMENTO1.SelectedValue)
    End Sub

    Private Sub frmEjecucionProgramas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inicializar()
    End Sub

    Public Overrides Sub EjecutarOpcion(ByVal asComando As String)
        Select Case asComando
            Case "Generar"
                Me.GenerarArchivo()

            Case "LimpiarVariables"
                Me.LimpiarCampos()
        End Select
    End Sub

    Private Sub LimpiarVariables()
        Me.InicializarVariables()
    End Sub

    Public Sub GenerarArchivo()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim lIdContratoCompra As Decimal = -1
        Dim lNumContrato As String = ""
        Dim lNumItem As Decimal = -1
        Dim lIdProveedor As Decimal = -1
        Dim lNombreAccionFormativa As String = ""
        Dim lIdSolicitud As Decimal = -1
        Dim lIdCentroResponsabilidad As Decimal = -1
        Dim lNombreReferente As String = ""
        Dim lIdAreaFormacion As Int32 = -1
        Dim lCodiDepartamento As String = ""
        Dim lCodiMunicipio As String = ""
        Dim lLugarEjecucion As String = ""


        If Me.CbxCONTRATO_COMPRA1.SelectedValue IsNot Nothing Then
            lIdContratoCompra = Me.CbxCONTRATO_COMPRA1.SelectedValue
        End If
        If Me.txtNUM_CONTRATO.Text.Trim <> "" Then
            lNumContrato = Me.txtNUM_CONTRATO.Text.Trim
        End If
        If Me.txtNUM_ITEM.Text.Trim <> "" AndAlso Not IsNumeric(Me.txtNUM_ITEM.Text.Trim) Then
            Me.AsignarMensaje("El número de item debe ser un número entero")
        End If
        If Me.txtNUM_ITEM.Text.Trim <> "" Then
            lNumItem = CInt(Me.txtNUM_ITEM.Text.Trim)
        End If
        If Me.CbxPROVEEDOR_AF1.SelectedValue IsNot Nothing Then
            lIdProveedor = Me.CbxPROVEEDOR_AF1.SelectedValue
        End If
        If Me.txtNOMBRE_ACCION_FORMATIVA.Text.Trim <> "" Then
            lNombreAccionFormativa = "%" + Replace(Me.txtNOMBRE_ACCION_FORMATIVA.Text.Trim, " ", "%") + "%"
        End If
        If Me.txtID_SOLICITUD.Text.Trim <> "" AndAlso Not IsNumeric(Me.txtID_SOLICITUD.Text.Trim) Then
            Me.AsignarMensaje("El número de solicitud debe ser un número entero")
        End If
        If Me.txtID_SOLICITUD.Text.Trim <> "" Then
            lIdSolicitud = CInt(Me.txtID_SOLICITUD.Text.Trim)
        End If
        If Me.CbxCENTRO_RESPONSABILIDAD1.SelectedValue IsNot Nothing Then
            lIdCentroResponsabilidad = Me.CbxCENTRO_RESPONSABILIDAD1.SelectedValue
        End If
        If Me.txtNOMBRE_REFERENTE.Text.Trim <> "" Then
            lNombreReferente = "%" + Replace(Me.txtNOMBRE_REFERENTE.Text.Trim, " ", "%") + "%"
        End If
        If Me.CbxAREA_FORMACION1.SelectedValue IsNot Nothing Then
            lIdAreaFormacion = Me.CbxAREA_FORMACION1.SelectedValue
        End If
        If Me.CbxDEPARTAMENTO1.SelectedValue IsNot Nothing Then
            lCodiDepartamento = Me.CbxDEPARTAMENTO1.SelectedValue
        End If
        If Me.CbxMUNICIPIO1.SelectedValue IsNot Nothing Then
            lCodiMunicipio = Me.CbxMUNICIPIO1.SelectedValue
        End If
        If Me.txtLUGAR_EJECUCION.Text.Trim <> "" Then
            lLugarEjecucion = "%" + Replace(Me.txtLUGAR_EJECUCION.Text.Trim, " ", "%") + "%"
        End If

        Me.SaveFileDialog1.FileName = "OfertaCompraMercadoBursatil " + Now.ToString("yyyy-MM-dd HH.mm.ss") + ".xlsx"
        Me.SaveFileDialog1.InitialDirectory = System.Environment.SpecialFolder.MyDocuments
        Me.SaveFileDialog1.Filter = "Archivo Excel |*.xlsx"
        If Not Me.SaveFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Return
        End If

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Me.ConsultA_BOLPROS_EXCELTableAdapter1.FillPorCriterios(Me.DS_DL1.CONSULTA_BOLPROS_EXCEL, lIdContratoCompra, lNumContrato, lNumItem, lIdProveedor, lNombreAccionFormativa, lIdSolicitud, lIdCentroResponsabilidad, lNombreReferente, lIdAreaFormacion, lCodiDepartamento, lCodiMunicipio, lLugarEjecucion)
        If Me.ExportarExcel(Me.DS_DL1.CONSULTA_BOLPROS_EXCEL, Me.SaveFileDialog1.FileName, "Consulta") Then
            Me.Cursor = System.Windows.Forms.Cursors.Default
            MsgBox("EL archivo se generó con éxito", vbInformation, Application.ProductName)
        Else
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub CbxDEPARTAMENTO1_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbxDEPARTAMENTO1.SelectedValueChanged
        If CbxDEPARTAMENTO1.SelectedValue Is Nothing Then
            Me.CbxMUNICIPIO1.Recuperar("")
            Me.CbxMUNICIPIO1.SelectedIndex = -1
        Else
            Me.CbxMUNICIPIO1.Recuperar(Me.CbxDEPARTAMENTO1.SelectedValue, True, False)
        End If
    End Sub

    Function ExportarExcel(ByVal DT As DataTable, ByVal nombreArchivo As String, ByVal nombreHoja As String) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Dim existeHoja As Boolean = False
        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exApp.DisplayAlerts = False
            If My.Computer.FileSystem.FileExists(nombreArchivo) Then
                My.Computer.FileSystem.DeleteFile(nombreArchivo)
            End If
            exLibro = exApp.Workbooks.Add
            exLibro.SaveAs(nombreArchivo)
            exLibro = Nothing
            exLibro = exApp.Workbooks.Open(nombreArchivo)
            exHoja = exLibro.Worksheets.Add()
            exHoja.Name = nombreHoja

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DT.Columns.Count
            Dim NRow As Integer = DT.Rows.Count
            Dim contador As Int32 = 1
            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                If DT.Columns(i - 1).ColumnName <> "ID_CONTRATO_COMPRA" AndAlso _
                    DT.Columns(i - 1).ColumnName <> "ID_PROVEEDOR_AF" AndAlso _
                    DT.Columns(i - 1).ColumnName <> "ID_AREA_FORMACION" AndAlso _
                    DT.Columns(i - 1).ColumnName <> "CODIGO_DEPARTAMENTO" AndAlso _
                    DT.Columns(i - 1).ColumnName <> "CODIGO_MUNICIPIO" AndAlso _
                    DT.Columns(i - 1).ColumnName <> "ID_CENTRO_RESPONSABILIDAD" Then

                    If DT.Columns(i - 1).ColumnName = "FECHA_SOLICITUD" Then
                        exHoja.Cells.Item(1, contador) = "Fecha Recepción de solicitud"
                    Else
                        exHoja.Cells.Item(1, contador) = DT.Columns(i - 1).Caption
                    End If

                    contador += 1
                End If
            Next

            For Fila As Integer = 0 To NRow - 1
                contador = 1
                For Col As Integer = 0 To NCol - 1
                    If DT.Columns(Col).ColumnName <> "ID_CONTRATO_COMPRA" AndAlso _
                        DT.Columns(Col).ColumnName <> "ID_PROVEEDOR_AF" AndAlso _
                        DT.Columns(Col).ColumnName <> "ID_AREA_FORMACION" AndAlso _
                        DT.Columns(Col).ColumnName <> "CODIGO_DEPARTAMENTO" AndAlso _
                        DT.Columns(Col).ColumnName <> "CODIGO_MUNICIPIO" AndAlso _
                        DT.Columns(Col).ColumnName <> "ID_CENTRO_RESPONSABILIDAD" Then

                        If DT.Columns(Col).ColumnName = "MONTO_CONTRATO" OrElse _
                            DT.Columns(Col).ColumnName = "MONTO_X_CURSO" Then
                            exHoja.Cells.Item(Fila + 2, contador).NumberFormat = "#,###,##0.00"
                            exHoja.Cells.Item(Fila + 2, contador) = DT.Rows(Fila).Item(Col).ToString
                        ElseIf DT.Columns(Col).ColumnName = "CANT_CURSOS_X_ITEM" OrElse _
                            DT.Columns(Col).ColumnName = "DURACION_HORAS" OrElse _
                             DT.Columns(Col).ColumnName = "CANT_PARTI_SOLICITUD" OrElse _
                             DT.Columns(Col).ColumnName = "GRUPOS_ASOCIADOS_X_ITEM" Then
                            exHoja.Cells.Item(Fila + 2, contador).NumberFormat = "#,###,##0"
                            exHoja.Cells.Item(Fila + 2, contador) = DT.Rows(Fila).Item(Col).ToString
                        ElseIf DT.Columns(Col).ColumnName = "ID_SOLICITUD" Then
                            exHoja.Cells.Item(Fila + 2, contador).NumberFormat = "###"
                            exHoja.Cells.Item(Fila + 2, contador) = DT.Rows(Fila).Item(Col).ToString
                        ElseIf DT.Columns(Col).ColumnName = "FECHA_SOLICITUD" Then
                            exHoja.Cells.Item(Fila + 2, contador).NumberFormat = "dd/MM/yyyy"
                            exHoja.Cells.Item(Fila + 2, contador) = DT.Rows(Fila).Item(Col).ToString()
                        Else
                            exHoja.Cells.Item(Fila + 2, contador).NumberFormat = "@"
                            exHoja.Cells.Item(Fila + 2, contador) = DT.Rows(Fila).Item(Col).ToString()
                        End If
                        contador += 1
                    End If
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
            MsgBox(ex.Message, vbCritical, Application.ProductName)
            exApp.DisplayAlerts = True
            If exLibro IsNot Nothing Then
                exLibro.Save()
                exLibro.Close()
                exApp.DisplayAlerts = True
                exHoja = Nothing
                exLibro = Nothing
                exApp = Nothing
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return False
        End Try
        Return True
    End Function
End Class