Imports DevExpress.Web.ASPxGridView
Imports System.Collections.Generic

Partial Class controles_ucFacturaAccionFormativa
    Inherits ucBase
    Dim mListaRoles As New List(Of String)

#Region "   Eventos Grid Detalle    "
    Protected Sub detailGrid_DataSelect(ByVal sender As Object, ByVal e As EventArgs)
        Session("ID_FACTURA_AF") = CDec((TryCast(sender, ASPxGridView)).GetMasterRowKeyValue())
    End Sub

    Protected Sub detailGrid_UnboundColumn(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs)
        If e.Column.FieldName = "CORRELATIVO" Then
            e.Value = e.ListSourceRowIndex + 1
        End If
    End Sub

#End Region

    Public Sub Inicializar()
        Me.ucBarraNavegacion1.LimpiarOpciones()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)

        Me.ucBarraNavegacion1.CrearOpcion("BuscarFacturas", "Buscar", False, "~/imagenes/ButtonSearch.png", "onclick", "e.processOnServer=false;CargarFacturas();")
        If EstaEnRol(RolDeUsuario.ProveedorFacturacionPATI) OrElse EstaEnRol(RolDeUsuario.ProveedorFacturacionHTP) OrElse EstaEnRol(RolDeUsuario.ProveedorFacturacionPROYESPECIAL) OrElse EstaEnRol(Enumeradores.RolDeUsuario.Bolproes) Then
            Me.ucCriteriosFacturaAccionFormativa1.VerProveedor = False
            If EstaEnRol(Enumeradores.RolDeUsuario.Bolproes) Then
                Me.ucBarraNavegacion1.CrearOpcion("RegistrarFactura", "Registrar Factura", False, "~/imagenes/nuevo.png", "onclick", "e.processOnServer=false;RegistrarFactura(1);")
            Else
                Me.ucBarraNavegacion1.CrearOpcion("RegistrarFactura", "Registrar Factura", False, "~/imagenes/nuevo.png", "onclick", "e.processOnServer=false;RegistrarFactura(0);")
            End If
        End If
        Me.ucBarraNavegacion1.CargarOpciones()
        If Me.EstaEnRol(RolDeUsuario.ColaboradorUACIPATI) OrElse Me.EstaEnRol(RolDeUsuario.ColaboradorUACIPROYESPECIAL) Then
            Me.dxgvFactura.Columns("NUMERO_QUEDAN").Visible = True
            Me.dxgvFactura.Columns("NUMERO_CHEQUE").Visible = True
        End If

        If Me.Request.QueryString("id") IsNot Nothing AndAlso IsNumeric(Me.Request.QueryString("id")) Then
            hf.Add("IdProgramaFormacion", -1)
            hf.Add("IdProveedor", -1)
            hf.Add("Nit", "")
            hf.Add("NumeroDocumento", "")
            hf.Add("FechaDocumento", "")
            hf.Add("Resolucion", "")
            hf.Add("CodigoGrupo", "")
            hf.Add("IdInforme", CDec(Me.Request.QueryString("id")))
        Else
            hf.Add("IdProgramaFormacion", 0)
            hf.Add("IdProveedor", 0)
            hf.Add("Nit", "")
            hf.Add("NumeroDocumento", "")
            hf.Add("FechaDocumento", "")
            hf.Add("Resolucion", "")
            hf.Add("CodigoGrupo", "")
            hf.Add("IdInforme", 0)
        End If
        Me.CargarProgramas()
    End Sub

    Private Sub CargarProgramas()
        Dim c As SQLMembershipProvider.BL.cmembershipProvider
        c = CType(System.Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)
        mListaRoles = c.ObtenerRoles(Me.ObtenerUsuario)

        Me.odsProgramaFormacion.DataBind()
        Me.cbxProgramaFormacionPopup.DataBind()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack AndAlso Not Page.IsCallback Then
            Inicializar()
        End If
        CargarFacturas()
    End Sub

    Private Sub CargarFacturas()
        Me.odsListaPorCriterios.SelectParameters("ID_PROGRAMA_FORMACION").DefaultValue = hf("IdProgramaFormacion")
        Me.odsListaPorCriterios.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = hf("IdProveedor")
        Me.odsListaPorCriterios.SelectParameters("NIT").DefaultValue = hf("Nit")
        Me.odsListaPorCriterios.SelectParameters("NUMERO_DOCUMENTO").DefaultValue = hf("NumeroDocumento")
        If hf("FechaDocumento") <> "" Then
            Me.odsListaPorCriterios.SelectParameters("FECHA_DOCUMENTO").DefaultValue = hf("FechaDocumento")
        Else
            Me.odsListaPorCriterios.SelectParameters("FECHA_DOCUMENTO").DefaultValue = Nothing
        End If
        Me.odsListaPorCriterios.SelectParameters("RESOLUCION").DefaultValue = hf("Resolucion")
        Me.odsListaPorCriterios.SelectParameters("CODIGO_GRUPO").DefaultValue = hf("CodigoGrupo")
        Me.odsListaPorCriterios.SelectParameters("ID_INFORME_FINAL").DefaultValue = hf("IdInforme")
        Me.odsListaPorCriterios.DataBind()
        Me.dxgvFactura.DataBind()

        If Me.dxgvFactura.VisibleRowCount = 1 Then
            Me.dxgvFactura.DetailRows.ExpandAllRows()
        End If
    End Sub

    Protected Sub cFactura_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cFactura.Callback
        Dim parametros() As String = e.Parameter.Split(";")
        cFactura.JSProperties.Clear()
        cFactura.JSProperties.Add("cpResultCallback", "")

        Select Case parametros(0)
            Case "CargarFacturas"
                hf("IdProgramaFormacion") = CDec(parametros(1))
                If Me.EstaEnRol(RolDeUsuario.ProveedorFacturacionPATI) OrElse _
                    Me.EstaEnRol(RolDeUsuario.ProveedorFacturacionHTP) OrElse _
                    Me.EstaEnRol(RolDeUsuario.ProveedorFacturacionPROYESPECIAL) OrElse _
                    Me.EstaEnRol(RolDeUsuario.Bolproes) Then
                    hf("IdProveedor") = Me.ObtenerIdProveedorAF
                Else
                    hf("IdProveedor") = CDec(parametros(2))
                End If
                hf("Nit") = parametros(3)
                hf("NumeroDocumento") = parametros(4)
                hf("FechaDocumento") = parametros(5)
                hf("Resolucion") = parametros(6)
                hf("CodigoGrupo") = parametros(7)
                hf("IdInforme") = CDec(parametros(8))
                CargarFacturas()

            Case "CargarCursosPorPrograma"
                Me.ucListaINFORME_FINAL_AF1.CargarDatosPorInformeFacturarCallback("BuscarDatos", New String() {"CargarDatosPorInformeFacturar", parametros(1), Me.ObtenerIdProveedorAF.ToString})

            Case "AnularFactura"
                Dim lIdFacturaAF As Decimal = CDec(Me.dxgvFactura.GetRowValues(Int32.Parse(parametros(1)), "ID_FACTURA_AF"))
                Dim lEntidad As FACTURA_AF
                Dim lEntidadNeg As New cFACTURA_AF
                Dim lbFacturaSIFP As New SIFP.BL.cFACTURA_AF
                Dim lRet As Integer = 1

                lEntidad = lEntidadNeg.ObtenerFACTURA_AF(lIdFacturaAF)
                lEntidad.ESTADO = Enumeradores.EstadoFactura.Anulada
                lEntidad.OBSERVACION = parametros(2).Trim.ToUpper
                lEntidad.USERID = Me.ObtenerUsuario
                lEntidad.LASTUPDATE = Now
                If lEntidadNeg.ActualizarFACTURA_AF(lEntidad) <> 1 Then
                    dxgvFactura.JSProperties("cpResultCallback") = "Error al Anular Factura"
                    Return
                End If
                Me.dxgvFactura.DataBind()
                dxgvFactura.JSProperties("cpResultCallback") = "La Factura se Anulo con exito!"

            Case "RegistrarFactura"
                'Cargando los Cursos a Facturar               
                Me.cbxProgramaFormacionPopup.SelectedIndex = -1
                Me.speRegNumeroDocumento.Value = 0
                Me.dteRegFechaEmision.Value = Nothing
                Me.ucListaINFORME_FINAL_AF1.CargarDatosPorInformeFacturarCallback("BuscarDatos", New String() {"CargarDatosPorInformeFacturar", 0, Me.ObtenerIdProveedorAF.ToString})
                cFactura.JSProperties("cpResultCallback") = "MostrarPopupRegistroFactura"

            Case "GuardarFactura"
                Select Case ucListaINFORME_FINAL_AF1.ObtenerNumeroFilasSeleccionadas
                    Case 0
                        cFactura.JSProperties("cpResultCallback") = "Seleccione un Curso."
                    Case Is > 1
                        cFactura.JSProperties("cpResultCallback") = "Ha seleccionado más de un Curso. Por favor verifique."
                    Case 1
                        Dim lFactura As New cFACTURA_AF
                        Dim lCriterios As New List(Of Criteria)
                        Dim lEntidadEnca As New FACTURA_AF
                        Dim lEntidadDeta As New FACTURA_DET

                        If Me.speRegNumeroDocumento.Value Is Nothing OrElse Not IsNumeric(Me.speRegNumeroDocumento.Value) Then
                            cFactura.JSProperties("cpResultCallback") = "N° de Documento inválido. Por favor verifique."
                            Return
                        End If
                        If Me.cbxRegTipoDocumento.Value Is Nothing Then
                            cFactura.JSProperties("cpResultCallback") = "Seleccione el Tipo de Documento."
                            Return
                        End If
                        If Me.dteRegFechaEmision.Value Is Nothing Then
                            cFactura.JSProperties("cpResultCallback") = "Digite la fecha del documento."
                            Return
                        End If

                        lEntidadEnca.ID_FACTURA_AF = 0
                        lEntidadEnca.ID_PROVEEDOR_AF = Me.ObtenerIdProveedorAF
                        lEntidadEnca.NUMERO_DOCUMENTO = Me.speRegNumeroDocumento.Value.ToString
                        lEntidadEnca.TIPO_DOCUMENTO = Me.cbxRegTipoDocumento.Value
                        lEntidadEnca.FECHA_DOCUMENTO = Me.dteRegFechaEmision.Date
                        lEntidadEnca.NUMERO_QUEDAN = -1
                        lEntidadEnca.ESTADO = Enumeradores.EstadoFactura.Emitida
                        lEntidadEnca.USERID = Me.ObtenerUsuario
                        lEntidadEnca.LASTUPDATE = Now
                        If lFactura.ActualizarFACTURA_AF(lEntidadEnca) = 1 Then
                            If (New cFACTURA_DET).AgregarFACTURA_DET(0, lEntidadEnca.ID_FACTURA_AF, CDec(ucListaINFORME_FINAL_AF1.ObtenerIdInformeSeleccionados(0)), Me.ObtenerUsuario, Now) = 1 Then
                                cFactura.JSProperties("cpResultCallback") = "Factura registrada con exito!"
                            Else
                                cFactura.JSProperties("cpResultCallback") = "No se pudo Registrar la Factura"
                            End If
                        Else
                            cFactura.JSProperties("cpResultCallback") = "No se pudo Registrar la Factura"
                        End If
                End Select

            Case "LimpiarDatosFactura"
                Me.speRegNumeroDocumento.Value = 0
                Me.cbxRegTipoDocumento.SelectedIndex = 0
                Me.dteRegFechaEmision.Value = Nothing
        End Select
    End Sub

    Protected Sub dxgvFactura_CustomButtonCallback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonCallbackEventArgs) Handles dxgvFactura.CustomButtonCallback
        dxgvFactura.JSProperties.Clear()
        dxgvFactura.JSProperties.Add("cpResultCallback", "")
        If e.ButtonID = "btnAprobarFactura" Then
            'Aprobar Factura para Pago

            Dim lIdFacturaAF As Decimal = CDec(Me.dxgvFactura.GetRowValues(e.VisibleIndex, "ID_FACTURA_AF"))
            Dim lEntidad As FACTURA_AF
            Dim lEntidadNeg As New cFACTURA_AF

            lEntidad = lEntidadNeg.ObtenerFACTURA_AF(lIdFacturaAF)

            If lEntidad IsNot Nothing Then
                'Verificar que el informe se encuentre en el estado FACTURA EN REVISION
                Dim lstFactDeta As listaFACTURA_DET = (New cFACTURA_DET).ObtenerListaPorFACTURA_AF(lEntidad.ID_FACTURA_AF)
                If lstFactDeta IsNot Nothing AndAlso lstFactDeta.Count > 0 Then
                    Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(lstFactDeta(0).ID_INFORME_FINAL)
                    If lInforme IsNot Nothing Then
                        If lInforme.ID_ESTADO_INFORME <> EstadoInformeFinal.FacturaRecibida Then
                            dxgvFactura.JSProperties("cpResultCallback") = "Para aprobar la Factura el Informe debe encontrarse en el estado FACTURA RECIBIDA"
                            Return
                        End If
                    End If
                End If
            End If

            lEntidad.ESTADO = Enumeradores.EstadoFactura.Aprobada
            lEntidad.OBSERVACION = ""
            lEntidad.USERID = Me.ObtenerUsuario
            lEntidad.LASTUPDATE = Now
            If lEntidadNeg.ActualizarFACTURA_AF(lEntidad) <> 1 Then
                dxgvFactura.JSProperties("cpResultCallback") = "Error al Aprobar Factura"
                Return
            End If
            Me.dxgvFactura.DataBind()
            dxgvFactura.JSProperties("cpResultCallback") = "La Factura se Aprobo con exito!"
        End If
    End Sub

    Protected Sub dxgvFactura_CustomButtonInitialize(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewCustomButtonEventArgs) Handles dxgvFactura.CustomButtonInitialize
        If e.ButtonID = "btnAprobarFactura" Then
            Dim lEstadoFactura As String = dxgvFactura.GetRowValues(e.VisibleIndex, "ESTADO").ToString

            If (Me.EstaEnRol(RolDeUsuario.Administrador) OrElse Me.EstaEnRol(RolDeUsuario.CARevision)) AndAlso lEstadoFactura = Enumeradores.EstadoFactura.Emitida Then
                e.Visible = DevExpress.Utils.DefaultBoolean.True
            Else
                e.Visible = DevExpress.Utils.DefaultBoolean.False
            End If
        End If

        If e.ButtonID = "btnAnularFactura" Then
            Dim lEstadoFactura As String = dxgvFactura.GetRowValues(e.VisibleIndex, "ESTADO").ToString
            Dim lNumeroQuedan As String = dxgvFactura.GetRowValues(e.VisibleIndex, "NUMERO_QUEDAN").ToString

            If (Me.EstaEnRol(RolDeUsuario.CARevision) OrElse Me.EstaEnRol(RolDeUsuario.CAGestion) OrElse EstaEnRol(RolDeUsuario.ProveedorFacturacionPATI) OrElse EstaEnRol(RolDeUsuario.ProveedorFacturacionPROYESPECIAL) OrElse EstaEnRol(RolDeUsuario.ProveedorFacturacionHTP)) AndAlso _
               (lEstadoFactura = Enumeradores.EstadoFactura.Emitida OrElse lEstadoFactura = Enumeradores.EstadoFactura.Aprobada) AndAlso _
               lNumeroQuedan = String.Empty Then
                e.Visible = DevExpress.Utils.DefaultBoolean.True
            Else
                e.Visible = DevExpress.Utils.DefaultBoolean.False
            End If
        End If
    End Sub
   
    Protected Sub odsProgramaFormacion_Selecting(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.ObjectDataSourceSelectingEventArgs) Handles odsProgramaFormacion.Selecting
        If e.InputParameters("listaRoles") Is Nothing Then e.InputParameters("listaRoles") = mListaRoles
    End Sub
End Class
