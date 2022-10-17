Imports SGAFP.RL

Partial Class Reportes_wfReporteInformeFinalAnexo1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarDatosReporte
    End Sub

    Private Sub CargarDatosReporte()
        Dim IdInforme As Decimal = CDec(Me.Request.QueryString("inf"))
        Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(IdInforme)
        Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lInforme.ID_ACCION_FORMATIVA)
        Dim lListaGrupoAccionBolsa As listaGRUPO_ACCION_CONTRATADA = (New cGRUPO_ACCION_CONTRATADA).ObtenerListaPorACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA)
        Dim esCursoBOLSA As Boolean = (lListaGrupoAccionBolsa IsNot Nothing AndAlso lListaGrupoAccionBolsa.Count > 0)

        Select Case True
            Case lAccionDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.EMPRESA_CENTRO
                Select Case Me.Request.QueryString("a")
                    Case 1
                        Dim reporte As New xrInformeAvanceEC
                        reporte.CargarInforme(lInforme.ID_INFORME_FINAL)
                        reporte.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporte)
                    Case 11
                        Dim reporte As New xrInformeFinalAnexo1A
                        reporte.CargarDatosPorInformeEjecucion(lInforme.ID_INFORME_FINAL)
                        reporte.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporte)
                    Case 2
                        Dim reporte As New xrInformeFinalAnexo2
                        reporte.CargarDatosPorInformeEjecucion(lInforme.ID_INFORME_FINAL)
                        reporte.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporte)
                    Case 3
                        Dim reporte As New xrInformeProyEspecialAnexo1
                        reporte.CargarDatosPorInformeEjecucion(lInforme.ID_INFORME_FINAL)
                        reporte.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporte)
                End Select

            Case lAccionDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE And Not esCursoBOLSA
                Select Case Me.Request.QueryString("a")
                    Case 1
                        Dim reporte As New xrInformeFinalAnexo1
                        reporte.CargarDatosPorInformeEjecucion(lInforme.ID_INFORME_FINAL)
                        reporte.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporte)
                    Case 11
                        Dim reporte As New xrInformeFinalAnexo1A
                        reporte.CargarDatosPorInformeEjecucion(lInforme.ID_INFORME_FINAL)
                        reporte.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporte)
                    Case 2
                        Dim reporte As New xrInformeFinalAnexo2
                        reporte.CargarDatosPorInformeEjecucion(lInforme.ID_INFORME_FINAL)
                        reporte.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporte)
                    Case 3
                        Dim reporte As New xrInformeProyEspecialAnexo1
                        reporte.CargarDatosPorInformeEjecucion(lInforme.ID_INFORME_FINAL)
                        reporte.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporte)
                End Select
            Case Utilerias.EsProgramaPATI(lAccionDetalle.ID_PROGRAMA_FORMACION)
                Select Case Me.Request.QueryString("a")
                    Case 1
                        Dim reporte As New xrIFinalAnexoI_PATI
                        reporte.CargarDatosPorInformeEjecucion(lInforme.ID_INFORME_FINAL)
                        reporte.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporte)
                    Case 11
                        Dim reporte As New xrInformeFinalAnexo1A
                        reporte.CargarDatosPorInformeEjecucion(lInforme.ID_INFORME_FINAL)
                        reporte.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporte)
                    Case 2
                        Dim reporte As New xrIFinalAnexoII_PATI
                        reporte.CargarDatosPorInformeEjecucion(lInforme.ID_INFORME_FINAL)
                        reporte.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporte)
                    Case 3
                        Dim reporte As New xrIFinalAnexoIII_PATI
                        reporte.CargarDatosPorAccionFormativa(lAccionDetalle.ID_ACCION_FORMATIVA)
                        Me.ucReporte1.CargarDatos(reporte)
                End Select
            Case lAccionDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL OrElse _
                (lAccionDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE AndAlso esCursoBOLSA)
                Select Case Me.Request.QueryString("a")
                    Case 1
                        Dim reporte As New xrInformeProyEspecialAnexo1
                        reporte.CargarDatosPorInformeEjecucion(lInforme.ID_INFORME_FINAL)
                        reporte.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporte)
                    Case 11
                        Dim reporte As New xrInformeFinalAnexo1A
                        reporte.CargarDatosPorInformeEjecucion(lInforme.ID_INFORME_FINAL)
                        reporte.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporte)
                    Case 2
                        Dim reporte As New xrInformeProyEspecialAnexo2
                        reporte.CargarDatosPorInformeEjecucion(lInforme.ID_INFORME_FINAL)
                        reporte.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporte)
                    Case 3
                        Dim reporte As New xrInformeProyEspecialAnexo3
                        reporte.CargarDatosPorInformeEjecucion(lInforme.ID_INFORME_FINAL)
                        reporte.ResumeLayout()
                        Me.ucReporte1.CargarDatos(reporte)
                End Select
        End Select
        
    End Sub
End Class
