Public Class frmFacturaCursos_EjecucionPresup 
    Private mInformeFinal As INFORME_FINAL_AF

    Public Sub CargarDatos(ByVal aIdFacturaAF As Decimal)
        Dim bFacturaAF As New cFACTURA_AF
        Dim lContrato As CONTRATO_PROVEEDOR_AF

        'Obtener la entidad contrato a la que está asociada la factura
        lContrato = bFacturaAF.ObtenerContratoProveedor(aIdFacturaAF)
        If lContrato IsNot Nothing Then


            Me.EjecucionPresupuestariaFacturaTableAdapter1.FillByContrato(DS_DL1.EjecucionPresupuestariaFactura, lContrato.ID_CONTRATO)

            'Obtener el informe que está asociado a la factura
            Dim listaFacturaDet As listaFACTURA_DET = (New cFACTURA_DET).ObtenerListaPorFACTURA_AF(aIdFacturaAF)
            If listaFacturaDet IsNot Nothing AndAlso listaFacturaDet.Count > 0 Then
                Dim lEntidadInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(listaFacturaDet(0).ID_INFORME_FINAL)
                Dim lAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lEntidadInforme.ID_ACCION_FORMATIVA)
                mInformeFinal = lEntidadInforme

                'Realizar la distribución sugerida del Monto de la Factura
                For Each dr As DL.DS_DL.EjecucionPresupuestariaFacturaRow In DS_DL1.EjecucionPresupuestariaFactura
                    Dim lAsistenciaAf As listaASISTENCIA_AF = (New cASISTENCIA_AF).ObtenerListaPorINFORME_FINAL_AF(lEntidadInforme.ID_INFORME_FINAL)
                    If lAsistenciaAf IsNot Nothing AndAlso lAsistenciaAf.Count > 0 Then
                        Dim iTotalMinutos As Integer = 0
                        For Each lEntidad As ASISTENCIA_AF In lAsistenciaAf
                            If dr.FECHA_INICIAL <= lEntidad.FECHA AndAlso lEntidad.FECHA <= dr.FECHA_FINAL Then
                                iTotalMinutos += lEntidad.CANTIDAD_HORAS
                            End If
                        Next
                        dr.BeginEdit()
                        dr.DISTRIBUCION = iTotalMinutos / (lAccionFormativa.DURACION_HORAS * 60) * lEntidadInforme.MONTO_FACTURA
                        If dr.MONTO_PROVISIONADO > 0 Then
                            dr.SALDO = dr.MONTO_PROVISIONADO - dr.MONTO_DEVENGADO - dr.DISTRIBUCION
                        Else
                            dr.SALDO = dr.MONTO_COMPROMETIDO - dr.MONTO_DEVENGADO - dr.DISTRIBUCION
                        End If
                        dr.EndEdit()
                    End If
                Next
            End If

            Me.DataTableEjecucionPresBindingSource1.DataSource = DS_DL1.EjecucionPresupuestariaFactura
        End If
    End Sub

    Private Sub SimpleButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButtonAceptar.Click
        'Validar Monto de la distribución y Saldos de Compromisos
        Dim dTotalDistribucion As Decimal = 0
        For Each dr As DL.DS_DL.EjecucionPresupuestariaFacturaRow In DS_DL1.EjecucionPresupuestariaFactura
            dTotalDistribucion += dr.DISTRIBUCION
        Next
        If dTotalDistribucion = mInformeFinal.MONTO_FACTURA Then
            For Each dr As DL.DS_DL.EjecucionPresupuestariaFacturaRow In DS_DL1.EjecucionPresupuestariaFactura
                If dr.DISTRIBUCION > 0 Then
                    Dim lCompromisoAF As New COMPROMISO_AF
                    Dim bCompromisoAF As New cCOMPROMISO_AF
                    lCompromisoAF.ID_COMPROMISO = dr.ID_COMPROMISO
                    lCompromisoAF.ID_INFORME_FINAL = mInformeFinal.ID_INFORME_FINAL
                    lCompromisoAF.MONTO_DEVENGADO = dr.DISTRIBUCION
                    lCompromisoAF.USERID = Utilerias.ObtenerUsuario
                    lCompromisoAF.LASTUPDATE = Now
                    bCompromisoAF.AgregarCOMPROMISO_AF(lCompromisoAF) 
                End If
            Next
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            AsignarMensaje("El Monto Total de la Distribución debe ser igual al Monto de la Factura", True)
        End If
    End Sub

    Private Sub GridEjecucionPres_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GridEjecucionPres.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
        e.WindowCaption = "Error en digitación"
        e.WindowCaption = "El Monto de la Distribución más el Monto Devengado sobrepasa el Monto Comprometido o Provisionado"
        GridEjecucionPres.HideEditor()
    End Sub

    Private Sub GridEjecucionPres_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridEjecucionPres.ValidateRow
        If GridEjecucionPres.FocusedColumn.Name <> "colDISTRIBUCION" Then Exit Sub
        Dim dr As DL.DS_DL.EjecucionPresupuestariaFacturaRow = CType(GridEjecucionPres.GetFocusedDataRow, DL.DS_DL.EjecucionPresupuestariaFacturaRow)
        dr.BeginEdit()
        If dr.MONTO_PROVISIONADO = 0 Then
            dr.SALDO = dr.MONTO_COMPROMETIDO - dr.MONTO_DEVENGADO - dr.DISTRIBUCION
        Else
            dr.SALDO = dr.MONTO_PROVISIONADO - dr.MONTO_DEVENGADO - dr.DISTRIBUCION
        End If
        dr.EndEdit()
    End Sub

    Private Sub GridEjecucionPres_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridEjecucionPres.ValidatingEditor
        If GridEjecucionPres.FocusedColumn.Name <> "colDISTRIBUCION" Then Exit Sub
        If Not IsNumeric(e.Value) Then
            e.Valid = False
            Return
        End If
        Dim dr As DL.DS_DL.EjecucionPresupuestariaFacturaRow = CType(GridEjecucionPres.GetFocusedDataRow, DL.DS_DL.EjecucionPresupuestariaFacturaRow)
        If dr.MONTO_PROVISIONADO = 0 Then
            If dr.MONTO_COMPROMETIDO - dr.MONTO_DEVENGADO - Convert.ToDecimal(e.Value) < 0 Then
                e.Valid = False
            End If
        Else
            If dr.MONTO_PROVISIONADO - dr.MONTO_DEVENGADO - Convert.ToDecimal(e.Value) < 0 Then
                e.Valid = False
            End If
        End If
    End Sub
End Class