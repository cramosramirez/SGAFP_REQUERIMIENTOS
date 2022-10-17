Imports DevExpress.XtraGrid.Views.Grid
Imports SQLMembershipProvider.BL
Imports System.Web.Security.Membership
Imports SGAFP.EL.Enumeradores

Public Class frmInformeFinal
    Dim mListaEstado As New listaESTADO_INFORME_AF
    Dim lAccionFormativa As New ACCION_FORMATIVA
    Dim lEntidadProveedor As New PROVEEDOR_AF
    Dim lEntidadCentro As New SITIO_CAPACITACION

    Public ReadOnly Property Current() As INFORME_FINAL_AF
        Get
            GridViewInforme.GetSelectedRows()
            Dim lInforme As INFORME_FINAL_AF = TryCast(GridViewInforme.GetFocusedRow(), INFORME_FINAL_AF)
            If lInforme IsNot Nothing Then
                Return lInforme
            Else
                Return Nothing
            End If
        End Get
    End Property

    Private Sub Inicializar()
        Me.AgregarOpcion("Buscar", "Buscar", My.Resources.view, True)
        Dim lista As New List(Of Int32)
        Dim listaOp As New List(Of String)


        If Me.EstaEnRol(RolDeUsuario.Administrador) Then
            Me.AgregarOpcion("VtoBo", "Visto Bueno", My.Resources.aprobar, True) : listaOp.Add("VtoBo")
            Me.AgregarOpcion("EnRevisionTecnico", "Devolver a Técnico", My.Resources.rechazar, True) : listaOp.Add("EnRevisionTecnico")
            Me.AgregarOpcion("EnProcesoBolpros", "En Proceso Bolpros", My.Resources.aprobar, True) : listaOp.Add("EnProcesoBolpros")
            Me.AgregarOpcion("EnviarUACI", "Enviar a revisión de UACI", My.Resources.aprobar, True) : listaOp.Add("EnviarUACI")
            Me.AgregarOpcion("SolicitarFactura", "Solicitar Factura", My.Resources.aprobar, True) : listaOp.Add("SolicitarFactura")
            Me.AgregarOpcion("Devolver", "Devolver Informe", My.Resources.rechazar, True) : listaOp.Add("Devolver")

            mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeValidadoTecnico)) : lista.Add(EstadoInformeFinal.InformeValidadoTecnico)
            mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeDevueltoPorUACI)) : lista.Add(EstadoInformeFinal.InformeDevueltoPorUACI)
            mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeValidadoCoordinador)) : lista.Add(EstadoInformeFinal.InformeValidadoCoordinador)
            mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeEnProcesoBolpros)) : lista.Add(EstadoInformeFinal.InformeEnProcesoBolpros)
            mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeEnRevisionUACI)) : lista.Add(EstadoInformeFinal.InformeEnRevisionUACI)
            mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.FacturaSolicitadaProveedor)) : lista.Add(EstadoInformeFinal.FacturaSolicitadaProveedor)
            mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.EnTramiteDePago)) : lista.Add(EstadoInformeFinal.EnTramiteDePago)
        End If

        If Me.EstaEnRol(RolDeUsuario.SoporteGFI) Then
            If Not listaOp.Contains("EnRevisionTecnico") Then Me.AgregarOpcion("EnRevisionTecnico", "Devolver a Técnico", My.Resources.rechazar, True) : listaOp.Add("EnRevisionTecnico")
            If Not listaOp.Contains("EnviarUACI") Then Me.AgregarOpcion("EnviarUACI", "Enviar a revisión de UACI", My.Resources.aprobar, True) : listaOp.Add("EnviarUACI")
            If Not lista.Contains(EstadoInformeFinal.InformeValidadoTecnico) Then mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeValidadoTecnico)) : lista.Add(EstadoInformeFinal.InformeValidadoTecnico)
            If Not lista.Contains(EstadoInformeFinal.InformeValidadoCoordinador) Then mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeValidadoCoordinador)) : lista.Add(EstadoInformeFinal.InformeValidadoCoordinador)
            If Not lista.Contains(EstadoInformeFinal.InformeEnProcesoBolpros) Then mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeEnProcesoBolpros)) : lista.Add(EstadoInformeFinal.InformeEnProcesoBolpros)
            If Not lista.Contains(EstadoInformeFinal.InformeEnRevision) Then mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeEnRevision)) : lista.Add(EstadoInformeFinal.InformeEnRevision)
            If Not lista.Contains(EstadoInformeFinal.InformeDevueltoPorUACI) Then mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeDevueltoPorUACI)) : lista.Add(EstadoInformeFinal.InformeDevueltoPorUACI)
        End If
        If Me.EstaEnRol(RolDeUsuario.CoordinadorGFI) Then
            If Not listaOp.Contains("VtoBo") Then Me.AgregarOpcion("VtoBo", "Visto Bueno", My.Resources.aprobar, True) : listaOp.Add("VtoBo")
            If Not listaOp.Contains("EnRevisionTecnico") Then Me.AgregarOpcion("EnRevisionTecnico", "Devolver a Técnico", My.Resources.rechazar, True) : listaOp.Add("EnRevisionTecnico")
            If Not listaOp.Contains("EnProcesoBolpros") Then Me.AgregarOpcion("EnProcesoBolpros", "En Proceso Bolpros", My.Resources.aprobar, True) : listaOp.Add("EnProcesoBolpros")
            If Not listaOp.Contains("EnviarUACI") Then Me.AgregarOpcion("EnviarUACI", "Enviar a revisión de UACI", My.Resources.aprobar, True) : listaOp.Add("EnviarUACI")
            If Not lista.Contains(EstadoInformeFinal.InformeValidadoTecnico) Then mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeValidadoTecnico)) : lista.Add(EstadoInformeFinal.InformeValidadoTecnico)
            If Not lista.Contains(EstadoInformeFinal.InformeValidadoCoordinador) Then mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeValidadoCoordinador)) : lista.Add(EstadoInformeFinal.InformeValidadoCoordinador)
            If Not lista.Contains(EstadoInformeFinal.InformeEnProcesoBolpros) Then mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeEnProcesoBolpros)) : lista.Add(EstadoInformeFinal.InformeEnProcesoBolpros)
            If Not lista.Contains(EstadoInformeFinal.InformeEnRevision) Then mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeEnRevision)) : lista.Add(EstadoInformeFinal.InformeEnRevision)
            If Not lista.Contains(EstadoInformeFinal.InformeEnRevision) Then mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeEnRevision)) : lista.Add(EstadoInformeFinal.InformeEnRevision)
        End If
        If Me.EstaEnRol(RolDeUsuario.ColaboradorUACIHTP) Or Me.EstaEnRol(RolDeUsuario.ColaboradorUACIPATI) Then
            If Not listaOp.Contains("SolicitarFactura") Then Me.AgregarOpcion("SolicitarFactura", "Solicitar Factura", My.Resources.aprobar, True) : listaOp.Add("SolicitarFactura")
            If Not listaOp.Contains("Devolver") Then Me.AgregarOpcion("Devolver", "Devolver Informe", My.Resources.rechazar, True) : listaOp.Add("Devolver")
            If Not lista.Contains(EstadoInformeFinal.InformeEnRevisionUACI) Then mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.InformeEnRevisionUACI)) : lista.Add(EstadoInformeFinal.InformeEnRevisionUACI)
            If Not lista.Contains(EstadoInformeFinal.FacturaSolicitadaProveedor) Then mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.FacturaSolicitadaProveedor)) : lista.Add(EstadoInformeFinal.FacturaSolicitadaProveedor)
            If Not lista.Contains(EstadoInformeFinal.EnTramiteDePago) Then mListaEstado.Add((New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(EstadoInformeFinal.EnTramiteDePago)) : lista.Add(EstadoInformeFinal.EnTramiteDePago)
        End If
        Me.AgregarOpcion("LimpiarVariables", "Limpiar Variables", My.Resources.undofilter, True)
        Me.txtNUM_LICITACION.Text = ""
        Me.txtCODIGO_GRUPO.Text = ""

        Me.InicializarVariables()
    End Sub

    Private Sub InicializarVariables()
        Dim c As cmembershipProvider
        c = CType(Provider, cmembershipProvider)

        Me.CbxPROGRAMA_FORMACION1.RecuperarPorRoles(c.ObtenerRoles(Utilerias.ObtenerUsuario))
        Me.CbxEJERCICIO1.Recuperar(True, False)
        Me.CbxPROVEEDOR_AF1.Recuperar(False, True)
        Me.bslistaESTADO_INFORME_FINAL.DataSource = mListaEstado
    End Sub

    Private Sub frmInformeFinal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inicializar()
    End Sub

    Public Overrides Sub EjecutarOpcion(ByVal asComando As String)
        Select Case asComando
            Case "Buscar"
                RecuperarDatos()
            Case "VtoBo"
                CambiarEstado(EstadoInformeFinal.InformeValidadoCoordinador)
            Case "EnProcesoBolpros"
                CambiarEstado(EstadoInformeFinal.InformeEnProcesoBolpros)
            Case "EnRevisionTecnico"
                CambiarEstado(EstadoInformeFinal.InformeEnRevision)
            Case "EnviarUACI"
                CambiarEstado(EstadoInformeFinal.InformeEnRevisionUACI)
            Case "SolicitarFactura"
                CambiarEstado(EstadoInformeFinal.FacturaSolicitadaProveedor)
            Case "Devolver"
                CambiarEstado(EstadoInformeFinal.InformeDevueltoPorUACI)
            Case "LimpiarVariables"
                Limpiar()
        End Select
    End Sub

    Private Sub Limpiar()
        Inicializar()
    End Sub

    Private Sub RecuperarDatos()
        Dim listaInformes As New listaINFORME_FINAL_AF
        Dim idContrato As Decimal = -1
        Dim idProveedor As Decimal = -1
        Dim listaEstadoInforme As New List(Of Decimal)
        Dim listaProgramas As New List(Of Decimal)

        If CbxPROVEEDOR_AF1.SelectedValue IsNot Nothing Then idProveedor = CbxPROVEEDOR_AF1.SelectedValue
        If Me.txtNUM_CONTRATO.Text <> "" Then
            Dim listaContrato As listaCONTRATO_PROVEEDOR_AF
            listaContrato = (New cCONTRATO_PROVEEDOR_AF).ObtenerListaPorCriterios(-1, Me.txtNUM_CONTRATO.Text, "", "", "")
            If listaContrato IsNot Nothing AndAlso listaContrato.Count > 0 Then
                idContrato = listaContrato(0).ID_CONTRATO
            End If
        End If
        If Me.cbxESTADO_INFORME_AF.SelectedValue IsNot Nothing Then
            listaEstadoInforme.Add(Me.cbxESTADO_INFORME_AF.SelectedValue)
        End If
        If Me.CbxPROGRAMA_FORMACION1.SelectedValue IsNot Nothing Then
            listaProgramas.Add(Me.CbxPROGRAMA_FORMACION1.SelectedValue)
        End If
        listaInformes = (New cINFORME_FINAL_AF).ObtenerListaPorCriterios(idProveedor, -1, Me.txtCODIGO_GRUPO.Text, CbxEJERCICIO1.SelectedValue, listaEstadoInforme, listaProgramas, idContrato, Me.txtNUM_LICITACION.Text.Replace("_/____", ""))
        Me.bsListaINFORME.DataSource = listaInformes
    End Sub



    Private Sub CambiarEstado(ByVal nvoEstado As Decimal)
        Dim lInforme As INFORME_FINAL_AF = Me.Current
        Dim lAccionFormativa As ACCION_FORMATIVA
        Dim bNotificarPorCorreo As Boolean = False
        Dim bContratoBolpros As New cCONTRATO_BOLPROS
        Dim bGenerarHistorico As Boolean = True
        If lInforme IsNot Nothing Then
            Dim lEntidadActual As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(lInforme.ID_INFORME_FINAL)
            If lEntidadActual IsNot Nothing Then
                Dim lEstado As String = ""
                Select Case nvoEstado
                    Case EstadoInformeFinal.InformeValidadoCoordinador
                        If lInforme.ID_ESTADO_INFORME <> EstadoInformeFinal.InformeValidadoTecnico Then
                            AsignarMensaje("Informe de estar Validado Por Técnico", False)
                            Return
                        End If
                        lEstado = "Dar Visto Bueno al"

                    Case EstadoInformeFinal.InformeEnProcesoBolpros
                        'Verificar si el informe proviene de una adjudicación en bolpros
                        'solo si proviene de una adjudicación en Bolpros puede asignarsele este estado
                        If Not bContratoBolpros.EsContratacionBolpros(lEntidadActual.ID_INFORME_FINAL) Then
                            AsignarMensaje("Informe debe pertenecer a una Compra en Bolpros para asignar este estado", False)
                            Return
                        End If
                        If (lInforme.ID_ESTADO_INFORME <> EstadoInformeFinal.InformeValidadoCoordinador) Then
                            AsignarMensaje("Informe de estar Validado por Coordinador", False)
                            Return
                        End If
                        lEstado = "Asignar en Proceso Bolpros el"

                    Case EstadoInformeFinal.InformeEnRevisionUACI
                        'Verificar si el informe proviene de una adjudicación en bolpros
                        'si proviene de una adjudicación en Bolpros entonces validar que se encuentre en el estado: EnProcesoBolpros
                        If bContratoBolpros.EsContratacionBolpros(lEntidadActual.ID_INFORME_FINAL) Then
                            If lEntidadActual.ID_ESTADO_INFORME <> EstadoInformeFinal.InformeEnProcesoBolpros Then
                                AsignarMensaje("Informe debe poseer el estado ""en Proceso Bolpros"" para asignar el estado de Revisión UACI", False)
                                Return
                            End If
                        End If
                        If lInforme.ID_ESTADO_INFORME <> EstadoInformeFinal.InformeValidadoCoordinador Then
                            AsignarMensaje("Informe debe estar Validado Por el Coordinador del Programa", False)
                            Return
                        End If
                        lEstado = "Enviar a Revisión a UACI el"

                    Case EstadoInformeFinal.InformeEnRevision
                        If lInforme.ID_ESTADO_INFORME <> EstadoInformeFinal.InformeValidadoTecnico Then
                            AsignarMensaje("Informe debe estar Validado por el Técnico", False)
                            Return
                        End If
                        lEstado = "Devolver al Técnico el"

                    Case EstadoInformeFinal.FacturaSolicitadaProveedor
                        If lInforme.ID_ESTADO_INFORME = EstadoInformeFinal.InformeEnRevisionUACI Then
                            bNotificarPorCorreo = True
                        ElseIf lInforme.ID_ESTADO_INFORME = EstadoInformeFinal.FacturaSolicitadaProveedor Then
                            bNotificarPorCorreo = True
                            bGenerarHistorico = False
                        Else
                            AsignarMensaje("Informe de estar en Revisión de UACI o debe haberse solicitado Factura", False)
                            Return
                        End If
                        lEstado = "Solicitar Factura del"

                    Case EstadoInformeFinal.InformeDevueltoPorUACI
                        If lInforme.ID_ESTADO_INFORME <> EstadoInformeFinal.InformeEnRevisionUACI Then
                            AsignarMensaje("Informe debe estar en Revisión de UACI", False)
                            Return
                        End If
                        lEstado = "Devolver a Revisión el"
                End Select
                lAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA)
                If Preguntar("¿Está seguro(a) de " + lEstado + " Informe correspondiente al curso " + lAccionFormativa.NOMBRE_ACCION_FORMATIVA + " " + lAccionFormativa.CODIGO_GRUPO + "?", MessageBoxButtons.YesNoCancel) = Windows.Forms.DialogResult.Yes Then
                    Dim lRet As Integer
                    lInforme.ID_ESTADO_INFORME = nvoEstado
                    lInforme.COMENTARIOS = ""
                    lInforme.USERID = Me.usuarioActualizacion
                    lInforme.LASTUPDATE = Now
                    lRet = (New cINFORME_FINAL_AF).ActualizarINFORME_FINAL_AF(lInforme, TipoConcurrencia.Pesimistica, False, bGenerarHistorico, bNotificarPorCorreo)
                    If nvoEstado = EstadoInformeFinal.FacturaSolicitadaProveedor Then
                        If lRet = -2 Then
                            Me.AsignarMensaje("No fue posible notificar al Proveedor de la Solicitud de Factura", True)
                            Return
                        End If
                    Else
                        If lRet <> 1 Then
                            Me.AsignarMensaje("No fue posible aplicar cambio de estado", True)
                            Return
                        End If
                    End If

                    Select Case nvoEstado
                        Case EstadoInformeFinal.InformeValidadoCoordinador
                            Me.AsignarMensaje("El Informe ha sido Validado por el Coordinador!")
                        Case EstadoInformeFinal.InformeEnProcesoBolpros
                            Me.AsignarMensaje("El Informe ha sido enviado a Proceso de Bolpros!")
                        Case EstadoInformeFinal.InformeEnRevisionUACI
                            Me.AsignarMensaje("El Informe ha sido enviado a Revisión en UACI!")
                        Case EstadoInformeFinal.InformeEnRevision
                            Me.AsignarMensaje("El Informe se ha remitido al Técnico!")
                        Case EstadoInformeFinal.FacturaSolicitadaProveedor
                            Me.AsignarMensaje("La Factura se ha solicitado con éxito!")
                        Case EstadoInformeFinal.InformeDevueltoPorUACI
                            Me.AsignarMensaje("El Informe se ha devuelto con éxito!")
                    End Select
                    Me.RecuperarDatos()
                End If
            End If
        Else
            AsignarMensaje("Seleccione un Informe", True)
        End If
    End Sub

    Private Sub GridViewAccionFormativa_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles GridViewInforme.CustomUnboundColumnData
        Dim lInforme As INFORME_FINAL_AF = CType(e.Row, INFORME_FINAL_AF)

        If lInforme.ID_ACCION_FORMATIVA <> lAccionFormativa.ID_ACCION_FORMATIVA Then
            lAccionFormativa = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(CType(e.Row, INFORME_FINAL_AF).ID_ACCION_FORMATIVA)
            lEntidadProveedor = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(lAccionFormativa.ID_PROVEEDOR_AF)
            lEntidadCentro = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(lAccionFormativa.ID_SITIO_CAPACITACION)
        End If
        If lAccionFormativa IsNot Nothing Then
            If e.Column.FieldName = "fieldProveedor" Then
                e.Value = lEntidadProveedor.NOMBRE_PROVEEDOR
            ElseIf e.Column.FieldName = "fieldCentroFormacion" Then
                If lEntidadCentro IsNot Nothing Then
                    e.Value = lEntidadCentro.NOMBRE_SITIO
                End If
            ElseIf e.Column.FieldName = "fieldCurso" Then
                e.Value = lAccionFormativa.NOMBRE_ACCION_FORMATIVA
            ElseIf e.Column.FieldName = "fieldDuracion" Then
                e.Value = lAccionFormativa.DURACION_HORAS
            ElseIf e.Column.FieldName = "fieldCodigoGrupo" Then
                e.Value = lAccionFormativa.CODIGO_GRUPO
            ElseIf e.Column.FieldName = "fieldCostoxParticipante" Then
                e.Value = lAccionFormativa.COSTO_X_PARTICIPANTE
            End If
        End If
    End Sub
End Class