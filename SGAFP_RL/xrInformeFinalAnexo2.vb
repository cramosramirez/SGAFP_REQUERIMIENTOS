Imports DevExpress.XtraReports.UI

Public Class xrInformeFinalAnexo2

    Public Sub CargarDatosPorInformeEjecucion(ByVal ID_INFORME_AF As Decimal)
        Dim lInforme As INFORME_FINAL_AF
        Dim lAccionFormativaDetalle As ACCION_FORMATIVA_DETALLE

        lInforme = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(ID_INFORME_AF)
        Me.DS_DL1.Clear()
        Me.InformeFinal2TableAdapter1.Fill(Me.DS_DL1.InformeFinal2, ID_INFORME_AF)

        If lInforme IsNot Nothing Then
            lAccionFormativaDetalle = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lInforme.ID_ACCION_FORMATIVA)

            If lAccionFormativaDetalle IsNot Nothing Then
                Select Case lAccionFormativaDetalle.ID_PROGRAMA_FORMACION
                    Case Enumeradores.ProgramasFormacion.EMPRESA_CENTRO
                        xrTitulo.Text = "PROGRAMA: EMPRESA CENTRO"
                    Case Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE
                        xrTitulo.Text = "PROGRAMA: HABILITACION PARA EL TRABAJO - HABIL TÉCNICO PERMANENTE"
                    Case Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL
                        xrTitulo.Text = "PROGRAMA: PROYECTO ESPECIAL"
                    Case Else
                        xrTitulo.Text = "PROGRAMA DE FORMACION PROFESIONAL"
                End Select
            End If
        End If
    End Sub

    Private Sub xrDUI_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles xrDUI.BeforePrint
        Dim celda As XRTableCell = CType(sender, XRTableCell)
        If Not IsDBNull(GetCurrentColumnValue("DUI")) Then
            celda.Text = Utilerias.FormatearDUI(GetCurrentColumnValue("DUI"))
        Else
            celda.Text = ""
        End If
    End Sub


    Private Sub xrNIT_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles xrNIT.BeforePrint
        Dim celda As XRTableCell = CType(sender, XRTableCell)
        If Not IsDBNull(GetCurrentColumnValue("NIT")) Then
            celda.Text = Utilerias.FormatearNIT(GetCurrentColumnValue("NIT"))
        Else
            celda.Text = ""
        End If
    End Sub
End Class