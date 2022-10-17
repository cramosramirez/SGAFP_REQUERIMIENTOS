Imports DevExpress.Web.ASPxGridView

Imports System.Data

Partial Class controles_ucOrdenesCompra
    Inherits ucBase


#Region "   Eventos Grid Detalle    "
    Protected Sub detailGrid_DataSelect(ByVal sender As Object, ByVal e As EventArgs)
        Session("RESOLUCION") = CStr((TryCast(sender, ASPxGridView)).GetMasterRowKeyValue()).Trim
    End Sub

    Protected Sub detailGrid_UnboundColumn(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs)
        If e.Column.FieldName = "CORRELATIVO" Then
            e.Value = e.ListSourceRowIndex + 1
        End If
        If e.Column.FieldName = "COSTO_GRUPO" AndAlso CInt(e.GetListSourceFieldValue("CORRELATIVO_GRUPO")) > 0 Then
            Dim bControl_Contrato As New SIFP.BL.ccontrol_contrato
            Dim ds As DataSet = bControl_Contrato.ObtenerDataSetGrupoCapacitacion(CInt(e.GetListSourceFieldValue("CORRELATIVO_GRUPO")))
            If ds IsNot Nothing AndAlso ds.Tables(0).Rows.Count > 0 Then
                e.Value = CDec(ds.Tables(0).Rows(0)("costo_grupo"))
            End If
        End If
        If e.Column.FieldName = "ESTADO" AndAlso CInt(e.GetListSourceFieldValue("ID_ESTADO_INFORME")) > 0 Then
            Dim lEntidad As ESTADO_INFORME_AF
            lEntidad = (New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(CInt(e.GetListSourceFieldValue("ID_ESTADO_INFORME")))
            If lEntidad IsNot Nothing Then
                e.Value = lEntidad.NOMBRE_ESTADO_INFORME
            End If
        End If
        If e.Column.FieldName = "NUM_FACTURA" AndAlso CInt(e.GetListSourceFieldValue("ID_INFORME_FINAL")) > 0 Then
            Dim lDetaFactura As listaFACTURA_DET = (New cFACTURA_DET).ObtenerListaPorINFORME_FINAL_AF(CInt(e.GetListSourceFieldValue("ID_INFORME_FINAL")), True)
            If lDetaFactura IsNot Nothing AndAlso lDetaFactura.Count > 0 Then
                Dim lEncFactura As FACTURA_AF = (New cFACTURA_AF).ObtenerFACTURA_AF(lDetaFactura(0).ID_FACTURA_AF)
                e.Value = lDetaFactura(0).fkID_FACTURA_AF.NUMERO_DOCUMENTO
            End If
        End If
        If e.Column.FieldName = "NUM_QUEDAN" AndAlso CInt(e.GetListSourceFieldValue("ID_INFORME_FINAL")) > 0 Then
            Dim lDetaFactura As listaFACTURA_DET = (New cFACTURA_DET).ObtenerListaPorINFORME_FINAL_AF(CInt(e.GetListSourceFieldValue("ID_INFORME_FINAL")), True)
            If lDetaFactura IsNot Nothing AndAlso lDetaFactura.Count > 0 Then
                Dim lEncFactura As FACTURA_AF = (New cFACTURA_AF).ObtenerFACTURA_AF(lDetaFactura(0).ID_FACTURA_AF)
                e.Value = lDetaFactura(0).fkID_FACTURA_AF.NUMERO_QUEDAN
            End If
        End If
        If e.Column.FieldName = "NUM_CHEQUE" AndAlso CInt(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA")) > 0 Then
            Dim lDetaFactura As listaFACTURA_DET = (New cFACTURA_DET).ObtenerListaPorINFORME_FINAL_AF(CInt(e.GetListSourceFieldValue("ID_INFORME_FINAL")), True)
            If lDetaFactura IsNot Nothing AndAlso lDetaFactura.Count > 0 Then
                Dim lEncFactura As FACTURA_AF = (New cFACTURA_AF).ObtenerFACTURA_AF(lDetaFactura(0).ID_FACTURA_AF)
                e.Value = lDetaFactura(0).fkID_FACTURA_AF.NUMERO_CHEQUE
            End If
        End If
        If e.Column.FieldName = "AUP" AndAlso CInt(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA")) > 0 Then
            e.Value = (New cACCION_FORMATIVA).ObtenerListaAUPsPorAccionFormativa(CInt(e.GetListSourceFieldValue("ID_ACCION_FORMATIVA")))
        End If
    End Sub

    Protected Sub detailGrid_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs)
        If e.ButtonID = "btnEnviarSolicitarFactura" Then
            Dim lCodigoEstadoInforme As Decimal = Decimal.Parse(TryCast(sender, ASPxGridView).GetRowValues(e.VisibleIndex, "ID_ESTADO_INFORME"))

            If lCodigoEstadoInforme = Enumeradores.EstadoInformeFinal.InformeEnRevisionUACI Then
                e.Visible = DevExpress.Utils.DefaultBoolean.True
            Else
                e.Visible = DevExpress.Utils.DefaultBoolean.False
            End If
        End If

        If e.ButtonID = "btnReEnviarSolicitarFactura" Then
            Dim lCodigoEstadoAccion As Decimal = Decimal.Parse(TryCast(sender, ASPxGridView).GetRowValues(e.VisibleIndex, "ID_ESTADO_INFORME"))

            If lCodigoEstadoAccion = Enumeradores.EstadoInformeFinal.FacturaSolicitadaProveedor Then
                e.Visible = DevExpress.Utils.DefaultBoolean.True
            Else
                e.Visible = DevExpress.Utils.DefaultBoolean.False
            End If
        End If

        If e.ButtonID = "btnDevolverInforme" Then
            Dim lCodigoEstadoAccion As Decimal = Decimal.Parse(TryCast(sender, ASPxGridView).GetRowValues(e.VisibleIndex, "ID_ESTADO_INFORME"))

            If lCodigoEstadoAccion = Enumeradores.EstadoInformeFinal.InformeEnRevisionUACI Then
                e.Visible = DevExpress.Utils.DefaultBoolean.True
            Else
                e.Visible = DevExpress.Utils.DefaultBoolean.False
            End If
        End If
    End Sub

    Protected Sub detailGrid_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs)
        If e.ButtonID = "btnEnviarSolicitarFactura" OrElse e.ButtonID = "btnReEnviarSolicitarFactura" Then
            Dim idInforme As Decimal = CDec(TryCast(sender, ASPxGridView).GetRowValues(e.VisibleIndex, "ID_INFORME_FINAL"))
            Dim lEntidad As INFORME_FINAL_AF
            Dim lRet As Integer

            'Enviar correo al Proveedor notificándole que puede Enviar Factura por el Curso Seleccionado
            lEntidad = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(idInforme)
            lEntidad.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.FacturaSolicitadaProveedor
            lEntidad.COMENTARIOS = ""
            lEntidad.USERID = Me.ObtenerUsuario
            lEntidad.LASTUPDATE = Now
            lRet = (New cINFORME_FINAL_AF).ActualizarINFORME_FINAL_AF(lEntidad, TipoConcurrencia.Pesimistica, False, True, True)
            If lRet = -2 Then
                Me.AsignarMensaje("No fue posible notificar al Proveedor de la Solicitud de Factura", True, True)
                TryCast(sender, ASPxGridView).DataBind()
                Return
            ElseIf lRet < 1 Then
                Me.AsignarMensaje("Curso no se pudo cambiar a Factura Solicitada a Proveedor", True, True)
                TryCast(sender, ASPxGridView).DataBind()
                Return
            End If
            TryCast(sender, ASPxGridView).JSProperties.Clear()
            TryCast(sender, ASPxGridView).JSProperties.Add("cpResultCallback", "CorreoEnviado")
            TryCast(sender, ASPxGridView).DataBind()
        End If
    End Sub

#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack AndAlso Not Page.IsCallback Then
            Inicializar()
        End If
        CargarOrdenesCompra()
    End Sub

    Public Sub Inicializar()
        Me.AsignarTituloOpcion("Recepcion de Cursos PATI")
        Me.ucBarraNavegacion1.LimpiarOpciones()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)

        Me.ucBarraNavegacion1.CrearOpcion("BuscarOrdenes", "Buscar", False, "~/imagenes/view.gif", "onclick", "e.processOnServer=false;CargarOrdenes();")
        Me.ucBarraNavegacion1.CargarOpciones()

        hf.Add("IdProgramaFormacion", 0)
        hf.Add("IdProveedor", 0)
        hf.Add("Resolucion", "")
    End Sub

    Private Sub CargarOrdenesCompra()
        Me.odsListaPorCriterios.SelectParameters("ID_PROGRAMA_FORMACION").DefaultValue = hf("IdProgramaFormacion")
        Me.odsListaPorCriterios.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = hf("IdProveedor")
        Me.odsListaPorCriterios.SelectParameters("RESOLUCION").DefaultValue = hf("Resolucion")
        Me.odsListaPorCriterios.DataBind()
        Me.dgvOC.DataBind()
    End Sub

    Protected Sub cOrdenCompra_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cOrdenCompra.Callback
        Dim parametros() As String = e.Parameter.Split(";")

        Select Case parametros(0)
            Case "CargarOrdenes"
                hf("IdProgramaFormacion") = CInt(parametros(1))
                hf("IdProveedor") = CInt(parametros(2))
                hf("Resolucion") = parametros(3)
                CargarOrdenesCompra()

            Case "DevolverInforme"
                Dim idInforme As Decimal
                Dim lEntidad As New INFORME_FINAL_AF
                Dim bInforme As New cINFORME_FINAL_AF
                Dim lGridDetalle As New ASPxGridView

                lGridDetalle = TryCast(Me.dgvOC.FindDetailRowTemplateControl(CInt(parametros(1)), "dgvOC_AccionesFormativas"), ASPxGridView)

                If lGridDetalle IsNot Nothing Then
                    idInforme = lGridDetalle.GetRowValues(CInt(parametros(2)), "ID_INFORME_FINAL")
                    lEntidad = bInforme.ObtenerINFORME_FINAL_AF(idInforme)
                    lEntidad.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoPorUACI
                    lEntidad.COMENTARIOS = parametros(3).ToUpper.Trim
                    lEntidad.USERID = Me.ObtenerUsuario
                    lEntidad.LASTUPDATE = Now
                    If bInforme.ActualizarINFORME_FINAL_AF(lEntidad, TipoConcurrencia.Pesimistica, False, True) <> 1 Then
                        'Si se cometio un error
                        Me.AsignarMensaje("Error al Devolver Informe", True, True)
                    Else
                        lGridDetalle.DataBind()
                    End If
                Else
                    Me.AsignarMensaje("Error al Devolver Informe", True, True)
                End If
        End Select
    End Sub


    Protected Sub dgvOC_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles dgvOC.CustomUnboundColumnData
        If e.Column.FieldName = "PROGRAMA" AndAlso Not e.GetListSourceFieldValue("ID_PROGRAMA_FORMACION").ToString() Is Nothing Then
            Dim lPrograma As PROGRAMA_FORMACION
            lPrograma = (New cPROGRAMA_FORMACION).ObtenerPROGRAMA_FORMACION(CDec(e.GetListSourceFieldValue("ID_PROGRAMA_FORMACION")))
            If lPrograma IsNot Nothing Then
                e.Value = lPrograma.NOMBRE_PROGRAMA_FORMACION
            End If
        End If

        If e.Column.FieldName = "HORARIO" Then
            Dim bControl_Contrato As New SIFP.BL.ccontrol_contrato
            Dim ds As DataSet = bControl_Contrato.ObtenerDataSetPorResolucion(e.GetListSourceFieldValue("RESOLUCION").ToString.Trim)
            If ds IsNot Nothing AndAlso ds.Tables(0).Rows.Count > 0 Then
                e.Value = ds.Tables(0).Rows(0)("fec_ejecucion").ToString
            End If
        End If

        If e.Column.FieldName = "ADJUDICADO" Then
            Dim bControl_Contrato As New SIFP.BL.ccontrol_contrato
            Dim ds As DataSet = bControl_Contrato.ObtenerDataSetPorResolucion(e.GetListSourceFieldValue("RESOLUCION").ToString.Trim)
            If ds IsNot Nothing AndAlso ds.Tables(0).Rows.Count > 0 Then
                e.Value = CDec(ds.Tables(0).Rows(0)("valor"))
            End If
        End If
    End Sub
End Class
