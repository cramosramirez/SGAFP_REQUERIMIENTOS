Imports DevExpress.XtraGrid.Views.Grid
Public Class frmAutorizacionPago

    Dim mID_CONTRATO As Decimal
    Dim mID_SUBAREA_FORMACION As Decimal

    Public ReadOnly Property Current() As ACCION_FORMATIVA
        Get
            Dim detViewSubArea As GridView = Me.GridViewContrato.GetDetailView(Me.GridViewContrato.FocusedRowHandle, 0)
            If detViewSubArea IsNot Nothing Then
                Dim detViewCurso As GridView = detViewSubArea.GetDetailView(detViewSubArea.FocusedRowHandle, 0)
                If detViewCurso IsNot Nothing Then
                    mID_CONTRATO = TryCast(detViewSubArea.GetFocusedRow(), CONTRATO_SUB_AREA_FORMACION).ID_CONTRATO
                    mID_SUBAREA_FORMACION = TryCast(detViewSubArea.GetFocusedRow(), CONTRATO_SUB_AREA_FORMACION).ID_SUBAREA_FORMACION
                    Dim lCurso As ACCION_FORMATIVA = TryCast(detViewCurso.GetFocusedRow(), ACCION_FORMATIVA)
                    Return lCurso
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Get
    End Property

    Private Sub Inicializar()
        Me.InicializarVariables()

        Me.AgregarOpcion("Buscar", "Buscar", My.Resources.view, True)
        Me.AgregarOpcion("SolicitarFactura", "Solicitar Factura", My.Resources.correo_proveedor, True)
        Me.AgregarOpcion("Devolver", "Devolver Informe", My.Resources.rechazar, True)
    End Sub

    Private Sub frmAutorizacionPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicializar()
    End Sub

    Private Sub InicializarVariables()
        Me.CbxPROVEEDOR_AF1.RecuperarPorPROGRAMA_FORMACION(1, False, True)
        Me.CbxEJERCICIO1.Recuperar(True)
    End Sub

    Public Overrides Sub EjecutarOpcion(ByVal asComando As String)
        Select Case asComando
            Case "Buscar"
                RecuperarDatos()
            Case "SolicitarFactura"
                SolicitarFactura()
            Case "Devolver"
                DevolverInforme()
        End Select
    End Sub

    Private Sub RecuperarDatos()
        Dim listaContratos As New listaCONTRATO_PROVEEDOR_AF
        Dim listaSubAreas As New listaCONTRATO_SUB_AREA_FORMACION
        Dim listaCursos As New listaACCION_FORMATIVA
        Dim bContratoProveedor As New cCONTRATO_PROVEEDOR_AF
        Dim bContratoSubArea As New cCONTRATO_SUB_AREA_FORMACION
        Dim bAccionFormativa As New cACCION_FORMATIVA
        Dim idProveedor As Decimal = -1
        Dim idEjercicio As String = ""
        Dim numLicitacion As String = ""

        If Me.txtNUM_LICITACION.Text <> "_/____" Then numLicitacion = Me.txtNUM_LICITACION.Text
        If CbxPROVEEDOR_AF1.SelectedValue IsNot Nothing Then idProveedor = CbxPROVEEDOR_AF1.SelectedValue
        If CbxEJERCICIO1.SelectedValue IsNot Nothing Then idEjercicio = CbxEJERCICIO1.SelectedValue

        'Obtener Contrato(s) del Proveedor
        listaContratos = bContratoProveedor.ObtenerListaPorCriterios(idProveedor, Me.txtNUM_CONTRATO.Text.Trim, numLicitacion, Me.txtCODIGO_GRUPO.Text.Trim, idEjercicio)

        'Obtener SubArea(s) del Contrato
        For Each lContrato As CONTRATO_PROVEEDOR_AF In listaContratos
            listaSubAreas = bContratoSubArea.ObtenerListaPorCriterios(lContrato.ID_CONTRATO, Me.txtCODIGO_GRUPO.Text.Trim, idEjercicio)

            'Obtener Acciones Formativas en Proceso de Pago por Sub Area
            For Each lSubArea As CONTRATO_SUB_AREA_FORMACION In listaSubAreas
                listaCursos = bAccionFormativa.ObtenerListaPorCriteriosContratoSubAreaFormativa(lSubArea.ID_CONTRATO, lSubArea.ID_SUBAREA_FORMACION, "", idEjercicio)
                lSubArea.CONTRATO_SUB_AREA_FORMACION_ACCION_FORMATIVA = listaCursos
            Next
            lContrato.CONTRATO_SUB_AREA_FORMACIONCONTRATO_PROVEEDOR_AF = listaSubAreas
        Next

        Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.DataSource = listaContratos
        If Me.txtCODIGO_GRUPO.Text.Trim <> "" Then
            Me.GridViewContrato.ExpandMasterRow(Me.GridViewContrato.GetSelectedRows(0))
        End If
    End Sub
    Private Sub SolicitarFactura()
        Dim lCurso As ACCION_FORMATIVA = Me.Current
        If lCurso IsNot Nothing Then
            If lCurso.CODIGO_ESTADO_AF = Enumeradores.EstadoInformeFinal.InformeEnRevisionUACI OrElse lCurso.CODIGO_ESTADO_AF = Enumeradores.EstadoInformeFinal.FacturaSolicitadaProveedor Then
                If Preguntar("¿Está seguro(a) de Solicitar Factura del Curso " + lCurso.NOMBRE_ACCION_FORMATIVA + " " + lCurso.CODIGO_GRUPO + "?", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then
                    Dim lRet As Integer
                    lCurso.CODIGO_ESTADO_AF = Enumeradores.EstadoInformeFinal.FacturaSolicitadaProveedor
                    lCurso.OBSERVACIONES = ""
                    lCurso.USERID = Me.usuarioActualizacion
                    lCurso.LASTUPDATE = Now
                    lRet = (New cACCION_FORMATIVA).ActualizarACCION_FORMATIVA(lCurso, TipoConcurrencia.Pesimistica, True, False)
                    If lRet = -2 Then
                        Me.AsignarMensaje("No fue posible notificar al Proveedor de la Solicitud de Factura", True)
                        Return
                    ElseIf lRet < 1 Then
                        Me.AsignarMensaje("Curso no se pudo cambiar a Factura Solicitada a Proveedor", True)
                        Return
                    End If

                    For Each lContrato As CONTRATO_PROVEEDOR_AF In Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.DataSource
                        If lContrato.ID_CONTRATO = mID_CONTRATO Then
                            For Each lContratoSubArea In lContrato.CONTRATO_SUB_AREA_FORMACIONCONTRATO_PROVEEDOR_AF
                                If lContratoSubArea.ID_CONTRATO = mID_CONTRATO AndAlso lContratoSubArea.ID_SUBAREA_FORMACION = mID_SUBAREA_FORMACION Then
                                    For Each lAccion As ACCION_FORMATIVA In lContratoSubArea.CONTRATO_SUB_AREA_FORMACION_ACCION_FORMATIVA
                                        If lAccion.ID_ACCION_FORMATIVA = lCurso.ID_ACCION_FORMATIVA Then
                                            lAccion = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lAccion.ID_ACCION_FORMATIVA)
                                            Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.EndEdit()
                                            Exit For
                                        End If
                                    Next
                                End If
                            Next
                        End If
                    Next
                    AsignarMensaje("Se ha solicitado la Factura al Proveedor")
                End If
            Else
                Dim strEstados As New System.Text.StringBuilder
                Dim bEstadoAccionFormativa As New cESTADO_ACCION_FORMATIVA
                strEstados.Append(bEstadoAccionFormativa.ObtenerESTADO_ACCION_FORMATIVA(Enumeradores.EstadoInformeFinal.InformeEnRevisionUACI).NOMBRE_ESTADO_AF)
                strEstados.Append(" y ")
                strEstados.Append(bEstadoAccionFormativa.ObtenerESTADO_ACCION_FORMATIVA(Enumeradores.EstadoInformeFinal.FacturaSolicitadaProveedor).NOMBRE_ESTADO_AF)
                AsignarMensaje("La Solicitud solo puede enviarse en los Estados: " + strEstados.ToString)
            End If
        Else
            AsignarMensaje("Seleccione un Curso", True)
        End If
    End Sub
    Private Sub DevolverInforme()
        Dim lCurso As ACCION_FORMATIVA = Me.Current
        If lCurso IsNot Nothing Then
            If lCurso.CODIGO_ESTADO_AF = Enumeradores.EstadoInformeFinal.InformeEnRevisionUACI Then
                If Preguntar("¿Está seguro(a) de Devolver el Curso " + lCurso.NOMBRE_ACCION_FORMATIVA + " " + lCurso.CODIGO_GRUPO + "?", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then
                    Dim lMotivoDevolucion As String = ""
                    If IngresarMotivo("Motivo de la Devolución", "Escriba el motivo de la devolución", lMotivoDevolucion) = Windows.Forms.DialogResult.OK Then
                        lCurso.CODIGO_ESTADO_AF = Enumeradores.EstadoInformeFinal.InformeDevueltoPorUACI
                        lCurso.OBSERVACIONES = lMotivoDevolucion
                        lCurso.USERID = Me.usuarioActualizacion
                        lCurso.LASTUPDATE = Now
                        If (New cACCION_FORMATIVA).ActualizarACCION_FORMATIVA(lCurso, TipoConcurrencia.Pesimistica, True, False) <> 1 Then
                            AsignarMensaje("Error al Devolver Informe", True)
                            Return
                        End If
                        For Each lContrato As CONTRATO_PROVEEDOR_AF In Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.DataSource
                            If lContrato.ID_CONTRATO = mID_CONTRATO Then
                                For Each lContratoSubArea In lContrato.CONTRATO_SUB_AREA_FORMACIONCONTRATO_PROVEEDOR_AF
                                    If lContratoSubArea.ID_CONTRATO = mID_CONTRATO AndAlso lContratoSubArea.ID_SUBAREA_FORMACION = mID_SUBAREA_FORMACION Then
                                        For Each lAccion As ACCION_FORMATIVA In lContratoSubArea.CONTRATO_SUB_AREA_FORMACION_ACCION_FORMATIVA
                                            If lAccion.ID_ACCION_FORMATIVA = lCurso.ID_ACCION_FORMATIVA Then
                                                lAccion = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lAccion.ID_ACCION_FORMATIVA)
                                                Me.ListaCONTRATO_PROVEEDOR_AFBindingSource.EndEdit()
                                                Exit For
                                            End If
                                        Next
                                    End If
                                Next
                            End If
                        Next
                        AsignarMensaje("El Informe se Devolvió con éxito!")
                    End If
                End If
            Else
                Dim strEstados As New System.Text.StringBuilder
                Dim bEstadoAccionFormativa As New cESTADO_ACCION_FORMATIVA
                strEstados.Append(bEstadoAccionFormativa.ObtenerESTADO_ACCION_FORMATIVA(Enumeradores.EstadoInformeFinal.InformeEnRevisionUACI).NOMBRE_ESTADO_AF)
                AsignarMensaje("El Curso solo puede Devolverse en el Estado: " + strEstados.ToString)
            End If
        Else
            AsignarMensaje("Seleccione un Curso", True)
        End If
    End Sub

    Private Sub GridViewContrato_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridViewContrato.CustomUnboundColumnData
        If e.IsGetData Then
            If e.Column.Name = "colNombreProveedor" Then
                Dim idProveedor As Decimal = CType(e.Row, CONTRATO_PROVEEDOR_AF).ID_PROVEEDOR_AF
                e.Value = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(idProveedor).NOMBRE_PROVEEDOR
            ElseIf e.Column.Name = "colEnDevengamiento" Then
                Dim lEntidad As CONTRATO_PROVEEDOR_AF = CType(e.Row, CONTRATO_PROVEEDOR_AF)
                Dim bEntidad As New cCONTRATO_PROVEEDOR_AF
                e.Value = bEntidad.ObtenerMontoEnDevengamiento(lEntidad.ID_CONTRATO)
            ElseIf e.Column.Name = "colDisponibilidad" Then
                Dim lEntidad As CONTRATO_PROVEEDOR_AF = CType(e.Row, CONTRATO_PROVEEDOR_AF)
                Dim bEntidad As New cCONTRATO_PROVEEDOR_AF
                Dim lMontoEnDevengamiento As Decimal = bEntidad.ObtenerMontoEnDevengamiento(lEntidad.ID_CONTRATO)
                e.Value = lEntidad.MONTO_ADJUDICADO - lMontoEnDevengamiento - lEntidad.MONTO_DEVENGADO
            End If
        End If
    End Sub

    Private Sub GridViewSubArea_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridViewSubArea.CustomUnboundColumnData
        If e.IsGetData Then
            If e.Column.Name = "colNombreSubArea" Then
                Dim idSubAreaFormativa As Decimal = CType(e.Row, CONTRATO_SUB_AREA_FORMACION).ID_SUBAREA_FORMACION
                e.Value = (New cSUB_AREA_FORMACION).ObtenerSUB_AREA_FORMACION(idSubAreaFormativa).NOMBRE_SUBAREA
            ElseIf e.Column.Name = "colSubAreaEnDevengamiento" Then
                Dim lEntidad As CONTRATO_SUB_AREA_FORMACION = CType(e.Row, CONTRATO_SUB_AREA_FORMACION)
                Dim bEntidad As New cCONTRATO_SUB_AREA_FORMACION
                e.Value = bEntidad.ObtenerMontoEnDevengamiento(lEntidad.ID_CONTRATO, lEntidad.ID_SUBAREA_FORMACION)
            ElseIf e.Column.Name = "colSubAreaDisponible" Then
                Dim lEntidad As CONTRATO_SUB_AREA_FORMACION = CType(e.Row, CONTRATO_SUB_AREA_FORMACION)
                Dim bEntidad As New cCONTRATO_SUB_AREA_FORMACION
                Dim lMontoEnDevengamiento As Decimal = bEntidad.ObtenerMontoEnDevengamiento(lEntidad.ID_CONTRATO, lEntidad.ID_SUBAREA_FORMACION)
                e.Value = lEntidad.MONTO_ADJUDICADO - lMontoEnDevengamiento - lEntidad.MONTO_DEVENGADO
            End If
        End If
    End Sub

    Private Sub GridViewCursos_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridViewCursos.CustomUnboundColumnData
        If e.IsGetData Then
            If e.Column.Name = "colActivos" Then
                Dim lEntidad As ACCION_FORMATIVA = CType(e.Row, ACCION_FORMATIVA)
                Dim listaInforme As New listaINFORME_FINAL_AF
                listaInforme = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA)
                If listaInforme IsNot Nothing AndAlso listaInforme.Count = 1 Then
                    e.Value = listaInforme(0).PARTICIPANTES_FINALES
                End If
            ElseIf e.Column.Name = "colTOTAL_PAGAR" Then
                Dim lEntidad As ACCION_FORMATIVA = CType(e.Row, ACCION_FORMATIVA)
                Dim listaInforme As New listaINFORME_FINAL_AF
                listaInforme = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA)
                If listaInforme IsNot Nothing AndAlso listaInforme.Count = 1 Then
                    e.Value = listaInforme(0).MONTO_FACTURA
                End If
            ElseIf e.Column.Name = "colNUMERO_QUEDAN" Then
                Dim lEntidad As ACCION_FORMATIVA = CType(e.Row, ACCION_FORMATIVA)
                Dim listaFacturaDetalle As New listaFACTURA_DET
                'listaFacturaDetalle = (New cFACTURA_DET).ObtenerListaPorACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA)
                For i As Integer = 0 To listaFacturaDetalle.Count - 1
                    Dim lEntidadFactura As FACTURA_AF
                    lEntidadFactura = (New cFACTURA_AF).ObtenerFACTURA_AF(listaFacturaDetalle(i).ID_FACTURA_AF)
                    If lEntidadFactura.ESTADO = Enumeradores.EstadoFactura.Aprobada AndAlso lEntidadFactura.NUMERO_QUEDAN <> -1 Then e.Value = lEntidadFactura.NUMERO_QUEDAN
                Next
            ElseIf e.Column.Name = "colFECHA_APROBACION" Then
                Dim lEntidad As ACCION_FORMATIVA = CType(e.Row, ACCION_FORMATIVA)
                Dim listaAccionHistorico As New listaACCION_FORMATIVA_HIST
                Dim lCriterios As New List(Of Criteria)
                lCriterios.Add(New Criteria("ID_ACCION_FORMATIVA", "=", 0, "AND"))
                lCriterios.Add(New Criteria("CODIGO_ESTADO_AF", "=", "'" + Enumeradores.EstadoInformeFinal.EnTramiteDePago + "'", ""))
                listaAccionHistorico = (New cACCION_FORMATIVA_HIST).ObtenerListaPorBusqueda(New ACCION_FORMATIVA_HIST, lCriterios.ToArray, "LASTUPDATE", "DESC")
                If listaAccionHistorico IsNot Nothing AndAlso listaAccionHistorico.Count > 0 Then
                    e.Value = listaAccionHistorico(0).LASTUPDATE
                End If

            ElseIf e.Column.Name = "colNUMERO_DOCUMENTO" Then
                Dim lEntidad As ACCION_FORMATIVA = CType(e.Row, ACCION_FORMATIVA)
                Dim listaFacturaDetalle As New listaFACTURA_DET
                'listaFacturaDetalle = (New cFACTURA_DET).ObtenerListaPorACCION_FORMATIVA(lEntidad.ID_ACCION_FORMATIVA)
                For i As Integer = 0 To listaFacturaDetalle.Count - 1
                    Dim lEntidadFactura As FACTURA_AF
                    lEntidadFactura = (New cFACTURA_AF).ObtenerFACTURA_AF(listaFacturaDetalle(i).ID_FACTURA_AF)
                    If lEntidadFactura.ESTADO = Enumeradores.EstadoFactura.Aprobada Then e.Value = lEntidadFactura.NUMERO_DOCUMENTO
                Next
            ElseIf e.Column.Name = "colNOMBRE_ESTADO_AF" Then
                Dim lEntidad As ACCION_FORMATIVA = CType(e.Row, ACCION_FORMATIVA)
                e.Value = (New cESTADO_ACCION_FORMATIVA).ObtenerESTADO_ACCION_FORMATIVA(lEntidad.CODIGO_ESTADO_AF).NOMBRE_ESTADO_AF
            End If
        End If
    End Sub
End Class