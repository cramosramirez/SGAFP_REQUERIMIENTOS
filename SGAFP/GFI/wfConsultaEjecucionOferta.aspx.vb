Imports DevExpress.Web.ASPxCallback
Imports DevExpress.Web

Partial Class GFI_wfConsultaEjecucionOferta
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarProveedores()
            Me.CargarCentros(-1)
            Me.SetearCampos()

            Me.cbxEjercicio1.Value = Today.ToString("yyyy")
            Me.cbxEjercicio2.Value = Today.ToString("yyyy")
        End If
    End Sub

    Private Sub CargarProveedores()
        Me.cbxProveedor.DataBind()
        Me.cbxProveedor.Items.Add(New ASPxEditors.ListEditItem("[Todos]", "-1"))
    End Sub

    Private Sub CargarCentros(ByVal ID_PROVEEDOR_AF As Decimal)
        Me.odsCentroFormacion.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = ID_PROVEEDOR_AF
        Me.cbxCentroFormacion.DataBind()
        Me.cbxCentroFormacion.Items.Add(New ASPxEditors.ListEditItem("[Todos]", "-1"))
    End Sub

    Public Sub btnExportar_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim NombreArchivo As String = ""

        Select Case Me.TabReportes.ActiveTabIndex
            Case 0
                Me.ASPxPivotGridExporter1.ASPxPivotGridID = "pgLista"
                Select Case Me.cbxEjecucion.SelectedIndex
                    Case 0
                        NombreArchivo = Me.cbxEjercicio1.Text
                    Case 1
                        NombreArchivo = "Cursos por Iniciar " + Me.cbxEjercicio1.Text
                    Case 2
                        NombreArchivo = "Cursos en Ejecucion " + Me.cbxEjercicio1.Text
                    Case 3
                        NombreArchivo = "Cursos Finalizados " + Me.cbxEjercicio1.Text
                End Select

            Case 1
                NombreArchivo = "Recursos Asignados " + Me.cbxEjercicio2.Text
                Me.ASPxPivotGridExporter1.ASPxPivotGridID = "pgRecursos"
                Me.ucConsultaRecursosAsignados1.CargarDatosPorEjercicio(Me.cbxEjercicio2.Text)
        End Select

        Select Case Me.cbxExportar.SelectedIndex
            Case 0
                Me.ASPxPivotGridExporter1.ExportXlsToResponse(NombreArchivo, True)
            Case 1
                Me.ASPxPivotGridExporter1.ExportPdfToResponse(NombreArchivo, True)
        End Select
    End Sub

    Private Sub SetearCampos()
        Me.cbxProveedor.Text = "[Todos]"
        Me.cbxCentroFormacion.Text = "[Todos]"
    End Sub

    Protected Sub cbxCentroFormacion_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cbxCentroFormacion.Callback
        Me.CargarCentros(e.Parameter)
    End Sub
    
End Class
