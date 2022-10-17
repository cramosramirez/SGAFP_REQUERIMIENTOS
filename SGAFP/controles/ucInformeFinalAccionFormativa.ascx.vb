Imports SGAFP.RL
Imports System.Collections.Generic

Partial Class controles_ucInformeFinalAccionFormativa
    Inherits ucBase

    Private ReadOnly Property idAccionFormativa() As Decimal
        Get
            If Me.ViewState("idAccionFormativa") Is Nothing Then Return 0
            Return Me.ViewState("idAccionFormativa")
        End Get
    End Property

    Private ReadOnly Property idInformeFinal() As Decimal
        Get
            If Me.ViewState("idInformeFinal") Is Nothing Then Return 0
            Return Me.ViewState("idInformeFinal")
        End Get
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        Else
            Me.BuscarAccionFormativa()
        End If
    End Sub

    Private Sub CargarDatos()
        Me.UcBarraNavegacion1.CrearOpcion("BuscarAccionFormativa", "BUSCAR", False, "~/imagenes/Zoom-icon2.png")
        Me.UcBarraNavegacion1.CrearOpcion("InformeFinalAnexo1", "ANEXO 1", False, "~/imagenes/imprimir.gif")
        Me.UcBarraNavegacion1.CrearOpcion("InformeFinalAnexo1A", "ANEXO 1A", False, "~/imagenes/imprimir.gif")
        Me.UcBarraNavegacion1.CrearOpcion("InformeFinalAnexo2", "ANEXO 2", False, "~/imagenes/imprimir.gif")
        Me.UcBarraNavegacion1.CrearOpcion("InformeFinalAnexo3", "ANEXO 3", False, "~/imagenes/imprimir.gif")
        Me.UcBarraNavegacion1.CrearOpcion("InformeFinalAnexo1PATI", "ANEXO 1-PATI", False, "~/imagenes/imprimir.gif")
        Me.UcBarraNavegacion1.CrearOpcion("InformeFinalAnexo1APATI", "ANEXO 1A-PATI", False, "~/imagenes/imprimir.gif")
        Me.UcBarraNavegacion1.CrearOpcion("InformeFinalAnexo2PATI", "ANEXO 2-PATI", False, "~/imagenes/imprimir.gif")
        Me.UcBarraNavegacion1.CrearOpcion("InformeFinalAnexo3PATI", "ANEXO 3-PATI", False, "~/imagenes/imprimir.gif")


        Me.UcBarraNavegacion1.CrearOpcion("InformeRecibido", "INFORME RECIBIDO", False, "~/imagenes/mailbox-message-received-2-icon.png")
        Me.UcBarraNavegacion1.CrearOpcion("InformeRevision", "INFORME EN REVISION", False, "~/imagenes/Files-icon.png")
        Me.UcBarraNavegacion1.CrearOpcion("InformeValidado", "INFORME VALIDADO", False, "~/imagenes/Status-security-high-icon.png")
        Me.UcBarraNavegacion1.CrearOpcion("InformeProcBolpros", "INFORME EN PROCESO BOLPROS", False, "~/imagenes/Alarm-clock-icon.png")

        Me.UcBarraNavegacion1.CrearOpcion("InformeSolventado", "INFORME CON OBSERVACION SOLVENTADA", False, "~/imagenes/ok-icon.png")
        Me.UcBarraNavegacion1.CrearOpcion("InformeRecepcionObservacion", "RECEPCION DE OBSERVACIONES SOLVENTADAS", False, "~/imagenes/mailbox-message-received-2-icon.png")

        Me.UcBarraNavegacion1.CrearOpcion("InformeObservado", "INFORME OBSERVADO", False, "~/imagenes/Close-2-icon.png")

        Me.UcBarraNavegacion1.CrearOpcion("OrdenRecibida", "ORDEN DE ENTREGA RECIBIDA", False, "~/imagenes/mailbox-message-received-2-icon.png")
        Me.UcBarraNavegacion1.CrearOpcion("OrdenRevision", "ORDEN DE ENTREGA EN REVISION", False, "~/imagenes/Files-icon.png")
        Me.UcBarraNavegacion1.CrearOpcion("OrdenValidada", "ORDEN DE ENTREGA VALIDADA", False, "~/imagenes/Status-security-high-icon.png")
        Me.UcBarraNavegacion1.CrearOpcion("OrdenObservada", "ORDEN DE ENTREGA OBSERVADA", False, "~/imagenes/Close-2-icon.png")


        Me.UcBarraNavegacion1.CrearOpcion("FacturaSolicitada", "FACTURA SOLICITADA A PROVEEDOR", False, "~/imagenes/Email-Reply-icon.png")
        Me.UcBarraNavegacion1.CrearOpcion("FacturaRecibida", "FACTURA RECIBIDA", False, "~/imagenes/mailbox-message-received-2-icon.png")
        Me.UcBarraNavegacion1.CrearOpcion("FacturaValidada", "FACTURA VALIDADA", False, "~/imagenes/Status-security-high-icon.png")
        Me.UcBarraNavegacion1.CrearOpcion("FacturaObservada", "FACTURA OBSERVADA", False, "~/imagenes/Close-2-icon.png")

        Me.UcBarraNavegacion1.CrearOpcion("RevertirEstado", "REVERTIR AL ESTADO ANTERIOR", False, "~/imagenes/Undo-icon.png")
        Me.UcBarraNavegacion1.CrearOpcion("RecalcularPago", "RECALCULAR PAGO", False, "~/imagenes/Apps-calc-icon.png")


        Me.UcBarraNavegacion1.CargarOpciones()
        Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo1", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo1A", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo2", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo3", False)

        Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo1PATI", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo1APATI", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo2PATI", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo3PATI", False)

        Me.UcBarraNavegacion1.VerOpcion("InformeRecibido", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeRevision", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeValidado", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeObservado", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeRecepcionObservacion", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeProcBolpros", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeSolventado", False)

        Me.UcBarraNavegacion1.VerOpcion("OrdenRecibida", False)
        Me.UcBarraNavegacion1.VerOpcion("OrdenRevision", False)
        Me.UcBarraNavegacion1.VerOpcion("OrdenObservada", False)
        Me.UcBarraNavegacion1.VerOpcion("OrdenValidada", False)

        Me.UcBarraNavegacion1.VerOpcion("FacturaSolicitada", False)
        Me.UcBarraNavegacion1.VerOpcion("FacturaRecibida", False)
        Me.UcBarraNavegacion1.VerOpcion("FacturaObservada", False)
        Me.UcBarraNavegacion1.VerOpcion("FacturaValidada", False)

        Me.UcBarraNavegacion1.VerOpcion("RevertirEstado", False)
        Me.UcBarraNavegacion1.VerOpcion("RecalcularPago", False)
    End Sub

    Protected Sub UcBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles UcBarraNavegacion1.OpcionSeleccionada
        Select Case CommandName
            Case "BuscarAccionFormativa"
                Me.BuscarAccionFormativa()
            Case "InformeFinalAnexo1"
                Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(Me.idInformeFinal)
                If lInforme IsNot Nothing Then
                    Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(lInforme.ID_ACCION_FORMATIVA)

                    If lAccionDetalle.ID_PROGRAMA_FORMACION = ProgramasFormacion.EMPRESA_CENTRO Then
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "ReporteAnexo1", "window.open('../reportes/wfReporteInformeFinalAnexo1.aspx?a=1&inf=" + Me.idInformeFinal.ToString() + "','_blank','')", True)
                    Else
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "ReporteAnexo1", "window.open('../reportes/wfReporteInformeFinalAnexo1.aspx?a=1&inf=" + Me.idInformeFinal.ToString() + "','_blank','')", True)
                    End If
                End If
            Case "InformeFinalAnexo1A"
                Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(Me.idInformeFinal)
                If lInforme IsNot Nothing Then
                    If Not (New cACCION_FORMATIVA).EsAccionFormativaOnline(lInforme.ID_ACCION_FORMATIVA) Then
                        ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "ReporteAnexo1A", "window.open('../reportes/wfReporteInformeFinalAnexo1.aspx?a=11&inf=" + Me.idInformeFinal.ToString() + "','_blank','')", True)
                    Else
                        Me.AsignarMensaje("Este anexo no esta habilitado para cursos en linea", False, True)
                    End If
                End If
            Case "InformeFinalAnexo2"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "ReporteAnexo2", "window.open('../reportes/wfReporteInformeFinalAnexo1.aspx?a=2&inf=" + Me.idInformeFinal.ToString() + "','_blank','')", True)
            Case "InformeFinalAnexo3"
                ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "ReporteAnexo3", "window.open('../reportes/wfReporteInformeFinalAnexo1.aspx?a=3&inf=" + Me.idInformeFinal.ToString() + "','_blank','')", True)
            Case "InformeRecibido"
                Me.CambiarEstado(EstadoInformeFinal.InformeRecibido)
            Case "InformeRevision"
                Me.NUEVO_ESTADO = EstadoInformeFinal.InformeEnRevision
                Me.AsignarTecnico()
                'Me.CambiarEstado(EstadoInformeFinal.InformeEnRevision)
            Case "InformeValidado"
                Me.CambiarEstado(EstadoInformeFinal.InformeValidadoTecnico)
            Case "InformeObservado"
                Me.NUEVO_ESTADO = EstadoInformeFinal.InformeDevueltoConObservaciones
                Me.IngresarComentario(Me.NUEVO_ESTADO)
            Case "InformeRecepcionObservacion"
                Me.CambiarEstado(EstadoInformeFinal.InformeRecepcionObservaciones)
            Case "InformeProcBolpros"
                Me.CambiarEstado(EstadoInformeFinal.InformeEnProcesoBolpros, "", True)
            Case "InformeSolventado"
                Me.CambiarEstado(EstadoInformeFinal.InformeConObservacionesSolventadas)
            Case "OrdenRecibida"
                Me.CambiarEstado(EstadoInformeFinal.OrdenEntregaRecibida)
            Case "OrdenRevision"
                Me.CambiarEstado(EstadoInformeFinal.OrdenEntregaEnRevision)
            Case "OrdenObservada"
                Me.NUEVO_ESTADO = EstadoInformeFinal.OrdenEntregaObservada
                Me.IngresarComentario(Me.NUEVO_ESTADO)
            Case "OrdenValidada"
                Me.CambiarEstado(EstadoInformeFinal.OrdenEntregaValidada, "")
            Case "FacturaSolicitada"
                Me.CambiarEstado(EstadoInformeFinal.FacturaSolicitadaProveedor, "", True)
            Case "FacturaRecibida"
                Me.CambiarEstado(EstadoInformeFinal.FacturaRecibida)
            Case "FacturaObservada"
                Me.NUEVO_ESTADO = EstadoInformeFinal.FacturaObservada
                Me.IngresarComentario(Me.NUEVO_ESTADO)
            Case "FacturaValidada"
                Dim bInformeFinal As New cINFORME_FINAL_AF
                If bInformeFinal.EsInformeBolpros(Me.idInformeFinal) Then
                    Me.CambiarEstado(EstadoInformeFinal.FacturaValidada)
                Else
                    ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "fFacturaRecibida", "window.open('../PagoAccionesFormativas/wfFacturaAccionFormativa.aspx?id=" + Me.idInformeFinal.ToString() + "','_blank','')", True)
                End If
            Case "RevertirEstado"
                Dim bInformeFinal As New cINFORME_FINAL_AF
                Dim lInformeFinal As INFORME_FINAL_AF = bInformeFinal.ObtenerINFORME_FINAL_AF(Me.idInformeFinal)

                If lInformeFinal IsNot Nothing Then
                    Select Case lInformeFinal.ID_ESTADO_INFORME
                        Case EstadoInformeFinal.FacturaValidada, EstadoInformeFinal.FacturaObservada
                            Me.NUEVO_ESTADO = EstadoInformeFinal.FacturaEnRevision

                        Case EstadoInformeFinal.OrdenEntregaValidada, EstadoInformeFinal.OrdenEntregaObservada
                            Me.NUEVO_ESTADO = EstadoInformeFinal.OrdenEntregaRecibida

                        Case EstadoInformeFinal.InformeRecibido
                            Me.NUEVO_ESTADO = EstadoInformeFinal.Emitido
                        Case EstadoInformeFinal.OrdenEntregaRecibida
                            Me.NUEVO_ESTADO = EstadoInformeFinal.InformeEnProcesoBolpros
                        Case EstadoInformeFinal.FacturaRecibida
                            Me.NUEVO_ESTADO = EstadoInformeFinal.OrdenEntregaValidada
                        Case EstadoInformeFinal.InformeRecepcionObservaciones
                            Me.NUEVO_ESTADO = EstadoInformeFinal.InformeEnRevision

                        Case EstadoInformeFinal.InformeDevueltoConObservaciones, EstadoInformeFinal.InformeConObservacionesSolventadas, EstadoInformeFinal.InformeRecepcionObservaciones, EstadoInformeFinal.FacturaSolicitadaProveedor, EstadoInformeFinal.InformeEnProcesoBolpros, EstadoInformeFinal.InformeValidadoCoordinador, EstadoInformeFinal.InformeValidadoTecnico
                            Me.NUEVO_ESTADO = EstadoInformeFinal.InformeEnRevision

                        Case EstadoInformeFinal.InformeEnRevision
                            Me.NUEVO_ESTADO = EstadoInformeFinal.InformeRecibido
                        Case EstadoInformeFinal.OrdenEntregaEnRevision
                            Me.NUEVO_ESTADO = EstadoInformeFinal.OrdenEntregaRecibida
                        Case EstadoInformeFinal.FacturaEnRevision
                            Me.NUEVO_ESTADO = EstadoInformeFinal.FacturaRecibida
                        Case EstadoInformeFinal.OrdenEntregaObservada, EstadoInformeFinal.OrdenEntregaValidada
                            Me.NUEVO_ESTADO = EstadoInformeFinal.OrdenEntregaEnRevision
                        Case EstadoInformeFinal.EnTramiteDePago
                            Me.NUEVO_ESTADO = EstadoInformeFinal.InformeValidadoTecnico
                    End Select

                    Me.IngresarComentario(Me.NUEVO_ESTADO)
                End If
            Case "RecalcularPago"
                Me.RecalcularPago()
        End Select
    End Sub

    Private Sub RecalcularPago()
        Dim bInformeFinal As New cINFORME_FINAL_AF
        Dim bInformeFinalHis As New cINFORME_FINAL_AF_HIS
        Dim lEntidadOld As INFORME_FINAL_AF = bInformeFinal.ObtenerINFORME_FINAL_AF(Me.idInformeFinal)
        Dim lEntidad As INFORME_FINAL_AF = bInformeFinal.ObtenerINFORME_FINAL_AF(Me.idInformeFinal)

        If lEntidad IsNot Nothing Then
            Dim lInformeHis As INFORME_FINAL_AF_HIS
            lEntidad = bInformeFinal.GenerarInformeParcial(lEntidad.ID_ACCION_FORMATIVA, lEntidad.FECHA_INICIAL, lEntidad.FECHA_FINAL, False)
            If lEntidad IsNot Nothing Then
                lEntidad.ID_INFORME_FINAL = Me.idInformeFinal
                lEntidad.ID_ESTADO_INFORME = lEntidadOld.ID_ESTADO_INFORME
                lEntidad.ELABORADO_POR = lEntidadOld.ELABORADO_POR
                lEntidad.USERID = Me.ObtenerUsuario
                lEntidad.LASTUPDATE = Now
                bInformeFinal.ActualizarINFORME_FINAL_AF(lEntidad, TipoConcurrencia.Pesimistica, False, False, False)

                lInformeHis = New INFORME_FINAL_AF_HIS
                With lInformeHis
                    .ID_INFORME_FINAL_HIS = 0
                    .ID_INFORME_FINAL = lEntidad.ID_INFORME_FINAL
                    .ID_ACCION_FORMATIVA = lEntidad.ID_ACCION_FORMATIVA
                    .ID_PROVEEDOR_AF = lEntidad.ID_PROVEEDOR_AF
                    .FECHA_INFORME = lEntidad.FECHA_INFORME
                    .NUMERO_FACTURA = lEntidad.NUMERO_FACTURA
                    .ELABORADO_POR = lEntidad.ELABORADO_POR
                    .MONTO_FACTURA = lEntidad.MONTO_FACTURA
                    .MONTO_APROBADO = lEntidad.MONTO_APROBADO
                    .MONTO_PAGO_INICIAL = lEntidad.MONTO_PAGO_INICIAL
                    .PARTICIPANTES_INSCRITOS = lEntidad.PARTICIPANTES_INSCRITOS
                    .PARTICIPANTES_FINALES = lEntidad.PARTICIPANTES_FINALES
                    .PORC_PROM_ASISTENCIA = lEntidad.PORC_PROM_ASISTENCIA
                    .NOTA_PROMEDIO = lEntidad.NOTA_PROMEDIO
                    .COMENTARIOS = "RECALCULO DE MONTO A PAGAR"
                    .USUARIO_APROBACION = lEntidad.USUARIO_APROBACION
                    .LASTUPDATE = Now
                    .USERID = Me.ObtenerUsuario
                    .ID_ESTADO_INFORME = EstadoInformeFinal.RecalculoMontoPagar
                    .HORAS_DESARROLLADAS = lEntidad.HORAS_DESARROLLADAS
                    .FECHA_INICIAL = lEntidad.FECHA_INICIAL
                    .FECHA_FINAL = lEntidad.FECHA_FINAL
                    .HORARIO = lEntidad.HORARIO
                    .COSTO_X_HORA = lEntidad.COSTO_X_HORA
                    .USERID = Me.ObtenerUsuario
                    .LASTUPDATE = Now
                    .USUARIO_ASIGNADO = lEntidad.USUARIO_ASIGNADO
                End With
                bInformeFinalHis.ActualizarINFORME_FINAL_AF_HIS(lInformeHis)
            End If
        Else
            Me.AsignarMensaje("Referencia a Informe no se logro establecer", False, True)
            Return
        End If

        Me.AsignarMensaje("Monto a pagar por Informe se ha recalculado", False, True)
        Me.BuscarAccionFormativa()
        Me.Menu1.Items(0).Selected = True
        Me.MultiView1.ActiveViewIndex = 0
        Me.ConfigurarMenu("Lista de Informes")
        Me.ViewState("idAccionFormativa") = Nothing
        Me.ViewState("idInformeFinal") = Nothing
    End Sub

    Private Sub BuscarAccionFormativa()
        Dim c As SQLMembershipProvider.BL.cmembershipProvider
        Dim listaRoles As New List(Of String)
        Dim listaEstados As New List(Of Decimal)

        c = CType(System.Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)
        listaRoles = c.ObtenerRoles(Me.ObtenerUsuario)

        If Me.ucCriteriosAccionFormativa1.VerEstadoInforme AndAlso Me.ucCriteriosAccionFormativa1.idEstadoInformeFinal <> -1 Then
            listaEstados.Add(Me.ucCriteriosAccionFormativa1.idEstadoInformeFinal)
        Else
            listaEstados = Nothing
        End If

        Me.ucListaINFORME_FINAL_AF1.CargarListaPorCriteriosRoles(Me.ucCriteriosAccionFormativa1.idProveedor, _
                                                                    Me.ucCriteriosAccionFormativa1.idSitioCapacitacion, _
                                                                    ucCriteriosAccionFormativa1.codigoGrupo, _
                                                                    ucCriteriosAccionFormativa1.idEjercicio, _
                                                                    listaRoles, listaEstados)
    End Sub

    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick
        Me.MultiView1.ActiveViewIndex = Int32.Parse(e.Item.Value)
        ConfigurarMenu(e.Item.Text)
        If e.Item.Text = "Lista de Informes" Then
            Me.Menu1.Items(1).Enabled = False
            Me.Menu1.Items(2).Enabled = False
            Me.Menu1.Items(3).Enabled = False
            Me.Menu1.Items(4).Enabled = False
            Me.Menu1.Items(5).Enabled = False
            Me.Menu1.Items(6).Enabled = False
            Me.Menu1.Items(7).Enabled = False
            Me.Menu1.Items(8).Enabled = False
        End If
        If e.Item.Text = "Informe" Then
            Me.ucListaINFORME_FINAL_AF1_Seleccionado(Me.ViewState("idInformeFinal"))
        End If
        If e.Item.Text = "Asistencia" Then
            Me.CargarAsistencia(Me.ViewState("idInformeFinal"))
        End If
        If e.Item.Text = "Notas" Then
            Me.CargarNotas(Me.ViewState("idInformeFinal"))
        End If
        If e.Item.Text = "Lista de Informes" Then
            Me.BuscarAccionFormativa()
        End If
        If e.Item.Text = "Reprogramaciones" Then
            Me.CargarReprogramaciones(Me.ViewState("idAccionFormativa"))
        End If
        If e.Item.Text = "Programacion" Then
            Me.CargarProgramacion(Me.ViewState("idAccionFormativa"))
        End If
        If e.Item.Text = "Historico" Then
            Me.CargarHistorico(Me.ViewState("idAccionFormativa"), (Me.ViewState("idInformeFinal")))
        End If
        If e.Item.Text = "Penalizaciones" Then
            Me.CargarPenalizaciones(Me.ViewState("idAccionFormativa"))
        End If
        If e.Item.Text = "Autorizaciones" Then
            Me.CargarAutorizaciones(Me.ViewState("idAccionFormativa"))
        End If
    End Sub

    Private Sub ConfigurarMenu(ByVal nombreMenu As String)
        Me.UcBarraNavegacion1.VerOpcion("InformeRecibido", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeRevision", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeValidado", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeObservado", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeProcBolpros", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeSolventado", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeRecepcionObservacion", False)
        Me.UcBarraNavegacion1.VerOpcion("OrdenRecibida", False)
        Me.UcBarraNavegacion1.VerOpcion("OrdenRevision", False)
        Me.UcBarraNavegacion1.VerOpcion("OrdenObservada", False)
        Me.UcBarraNavegacion1.VerOpcion("OrdenValidada", False)
        Me.UcBarraNavegacion1.VerOpcion("FacturaSolicitada", False)
        Me.UcBarraNavegacion1.VerOpcion("FacturaRecibida", False)
        Me.UcBarraNavegacion1.VerOpcion("FacturaObservada", False)
        Me.UcBarraNavegacion1.VerOpcion("FacturaValidada", False)
        Me.UcBarraNavegacion1.VerOpcion("RevertirEstado", False)
        Me.UcBarraNavegacion1.VerOpcion("RecalcularPago", False)

        Me.UcBarraNavegacion1.VerOpcion("BuscarAccionFormativa", True)
        Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo1", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo1A", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo2", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo3", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo1PATI", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo1APATI", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo2PATI", False)
        Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo3PATI", False)

        If nombreMenu = "Informe Final" Then
            Me.UcBarraNavegacion1.VerOpcion("BuscarAccionFormativa", False)

            Dim bInformeEjecucion As New cINFORME_FINAL_AF
            Dim lInformeEjecucion As New INFORME_FINAL_AF
            Dim lAccionFormativaDeta As ACCION_FORMATIVA_DETALLE

            lAccionFormativaDeta = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(Me.idAccionFormativa)
            Select Case lAccionFormativaDeta.ID_PROGRAMA_FORMACION
                Case Enumeradores.ProgramasFormacion.HABIL_TECNICO_PERMANENTE
                    Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo1", True)
                    Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo1A", True)
                    Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo2", True)
                    Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo3", True)

                Case Enumeradores.ProgramasFormacion.PATI_BM, Enumeradores.ProgramasFormacion.PATI_USAID, Enumeradores.ProgramasFormacion.PATI_2
                    Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo1", True)
                    Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo1A", True)
                    Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo2", True)
                    Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo3", True)
                Case Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL
                    Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo1", True)
                    Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo1A", True)
                    Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo2", True)
                    Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo3", True)
                Case Enumeradores.ProgramasFormacion.EMPRESA_CENTRO
                    Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo1", True)
                    Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo1A", True)
                    Me.UcBarraNavegacion1.VerOpcion("InformeFinalAnexo2", True)
            End Select

            lInformeEjecucion = bInformeEjecucion.ObtenerINFORME_FINAL_AF(Me.idInformeFinal)

            '****** ROL: PROVEEDOR
            If Me.EstaEnRol(RolDeUsuario.Administrador) OrElse Me.EstaEnRol(RolDeUsuario.Proveedor) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPATI) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPROYESPECIAL) OrElse _
                Me.EstaEnRol(RolDeUsuario.CentroCapacitador) Then
                If lInformeEjecucion.ID_ESTADO_INFORME = EstadoInformeFinal.InformeDevueltoConObservaciones  Then
                    Me.UcBarraNavegacion1.VerOpcion("InformeSolventado", True)
                End If
            End If

            '****** ROL: ADMINISTRADOR
            If Me.EstaEnRol(RolDeUsuario.Administrador) OrElse Me.EstaEnRol(RolDeUsuario.CAGestion) Then
                If lInformeEjecucion.ID_ESTADO_INFORME <> EstadoInformeFinal.Emitido Then
                    Me.UcBarraNavegacion1.VerOpcion("RevertirEstado", True)
                End If
            End If

            '****** ROL: CA RECEPCION
            If Me.EstaEnRol(RolDeUsuario.Administrador) OrElse Me.EstaEnRol(RolDeUsuario.CARecepcion) Then
                Select Case lInformeEjecucion.ID_ESTADO_INFORME
                    Case EstadoInformeFinal.Emitido
                        Me.UcBarraNavegacion1.VerOpcion("InformeRecibido", True)
                    Case EstadoInformeFinal.InformeEnProcesoBolpros
                        Me.UcBarraNavegacion1.VerOpcion("OrdenRecibida", True)
                    Case EstadoInformeFinal.OrdenEntregaValidada
                        Me.UcBarraNavegacion1.VerOpcion("FacturaRecibida", True)
                    Case EstadoInformeFinal.OrdenEntregaObservada
                        Me.UcBarraNavegacion1.VerOpcion("OrdenRecibida", True)
                    Case EstadoInformeFinal.FacturaSolicitadaProveedor
                        Me.UcBarraNavegacion1.VerOpcion("FacturaRecibida", True)
                    Case EstadoInformeFinal.FacturaObservada
                        Me.UcBarraNavegacion1.VerOpcion("FacturaRecibida", True)
                    Case EstadoInformeFinal.InformeConObservacionesSolventadas
                        Me.UcBarraNavegacion1.VerOpcion("InformeRecepcionObservacion", True)
                End Select
            End If

            '****** ROL: CA GESTION
            If Me.EstaEnRol(RolDeUsuario.Administrador) OrElse Me.EstaEnRol(RolDeUsuario.CAGestion) Then
                Select Case lInformeEjecucion.ID_ESTADO_INFORME
                    Case EstadoInformeFinal.InformeRecibido
                        Me.UcBarraNavegacion1.VerOpcion("InformeRevision", True)
                End Select
            End If

            '****** ROL: CA REVISION
            If Me.EstaEnRol(RolDeUsuario.Administrador) OrElse Me.EstaEnRol(RolDeUsuario.CARevision) Then
                Select Case lInformeEjecucion.ID_ESTADO_INFORME
                    Case EstadoInformeFinal.InformeEnRevision, EstadoInformeFinal.InformeRecepcionObservaciones
                        Me.UcBarraNavegacion1.VerOpcion("InformeValidado", True)
                        Me.UcBarraNavegacion1.VerOpcion("InformeObservado", True)
                    Case EstadoInformeFinal.InformeValidadoTecnico, EstadoInformeFinal.InformeValidadoCoordinador
                        'Evaluar si el informe es de bolpros
                        If bInformeEjecucion.EsInformeBolpros(lInformeEjecucion.ID_INFORME_FINAL) Then
                            Me.UcBarraNavegacion1.VerOpcion("InformeProcBolpros", True)

                            Dim lOfertaCompra As CONTRATO_COMPRA = (New cCONTRATO_COMPRA).ObtenerCONTRATO_COMPRAPorID_ACCION_FORMATIVA(lInformeEjecucion.ID_ACCION_FORMATIVA)
                            If lOfertaCompra IsNot Nothing AndAlso (lOfertaCompra.NO_CONTRATO_COMPRA = "53" OrElse lOfertaCompra.NO_CONTRATO_COMPRA = "23") Then
                                Me.UcBarraNavegacion1.VerOpcion("InformeProcBolpros", False)
                                Me.UcBarraNavegacion1.VerOpcion("FacturaSolicitada", True)
                            End If
                        Else
                            Me.UcBarraNavegacion1.VerOpcion("FacturaSolicitada", True)
                        End If
                    Case EstadoInformeFinal.FacturaSolicitadaProveedor
                        Me.UcBarraNavegacion1.VerOpcion("FacturaSolicitada", True)
                    Case EstadoInformeFinal.OrdenEntregaRecibida, EstadoInformeFinal.OrdenEntregaEnRevision
                        Me.UcBarraNavegacion1.VerOpcion("OrdenValidada", True)
                        Me.UcBarraNavegacion1.VerOpcion("OrdenObservada", True)
                    Case EstadoInformeFinal.FacturaRecibida
                        Me.UcBarraNavegacion1.VerOpcion("FacturaValidada", True)
                        Me.UcBarraNavegacion1.VerOpcion("FacturaObservada", True)
                    Case EstadoInformeFinal.InformeRecepcionObservaciones
                        Me.UcBarraNavegacion1.VerOpcion("InformeValidado", True)
                        Me.UcBarraNavegacion1.VerOpcion("InformeObservado", True)
                End Select
            End If

            '****** ROL: ADMINISTRADOR / RECALCULO
            If Me.EstaEnRol(RolUsuario.AplicarRecalculoMontoPagarInforme) Then
                Me.UcBarraNavegacion1.VerOpcion("RecalcularPago", True)
            End If
        End If
        If nombreMenu = "Asistencia" OrElse nombreMenu = "Notas" OrElse nombreMenu = "Reprogramaciones" OrElse nombreMenu = "Programacion" OrElse nombreMenu = "Historico" Then
            Me.UcBarraNavegacion1.VerOpcion("BuscarAccionFormativa", False)
            Return
        End If
    End Sub

    Private Function InformeAutoGenerado() As Boolean
        If Me.idAccionFormativa > 0 Then
            Return (New cEVALUACION_AF).ObtenerListaPorACCION_FORMATIVA(Me.idAccionFormativa).Count = 0
        Else
            Return False
        End If
    End Function

    Private Sub CargarAsistencia(ByVal ID_INFORME_FINAL_AF As Decimal)
        Me.ucAsistenciaAccionFormativa1.idInformeFinal = ID_INFORME_FINAL_AF
        Me.ucAsistenciaAccionFormativa1.idAccionFormativa = Me.idAccionFormativa
        Me.ucAsistenciaAccionFormativa1.CargarDatos()
    End Sub

    Private Sub CargarReprogramaciones(ByVal ID_ACCION_FORMATIVA As Decimal)
        Me.ucListaACCION_FORMATIVA_REPROG1.CargarDatosPorACCION_FORMATIVA_REPROG_ESTADO(ID_ACCION_FORMATIVA, Enumeradores.EstadoReprogramaciones.Aprobada)
    End Sub

    Private Sub CargarProgramacion(ByVal ID_ACCION_FORMATIVA As Decimal)
        Dim lEntidad As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(idInformeFinal)
        Me.ucBarraNavegacion2.LimpiarOpciones()
        If (lEntidad.ID_ESTADO_INFORME = EstadoInformeFinal.Emitido OrElse lEntidad.ID_ESTADO_INFORME = EstadoInformeFinal.InformeDevueltoConObservaciones) AndAlso _
            (Me.EstaEnRol(RolDeUsuario.CentroCapacitador) OrElse Me.EstaEnRol(RolDeUsuario.Proveedor) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPATI) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPROYESPECIAL)) Then
            Me.ucBarraNavegacion2.CrearOpcion("GuardarReprogramacion", "Guardar", True, "~/imagenes/Almacenar.gif")
            Me.ucBarraNavegacion2.CargarOpciones()
        End If

        Me.ucVistaDetalleACCION_FORMATIVA1.Visible = True
        Me.ucVistaDetalleACCION_FORMATIVA1.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
    End Sub

    Private Sub CargarHistorico(ByVal ID_ACCION_FORMATIVA As Decimal, ByVal ID_INFORME_FINAL_AF As Decimal)
        Me.ucListaACCION_FORMATIVA_HIST1.CargarDatosPorID_ACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        Me.ucListaINFORME_FINAL_AF_HIS1.CargarDatosPorINFORME_FINAL_AF(ID_INFORME_FINAL_AF)
    End Sub

    Private Sub CargarPenalizaciones(ByVal ID_ACCION_FORMATIVA As Decimal)
        Me.ucListaACCION_FORMATIVA_PENA1.CargarDatosPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
    End Sub

    Private Sub CargarAutorizaciones(ByVal ID_ACCION_FORMATIVA As Decimal)
        Dim lAccion As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        If lAccion IsNot Nothing Then
            Me.ucListaACCION_PROGRA_RETRO1.CargarDatosPorCriterios(lAccion.ID_PROVEEDOR_AF, lAccion.ID_EJERCICIO, lAccion.CODIGO_GRUPO, "", -1)
        End If

    End Sub

    Private Sub CargarNotas(ByVal ID_INFORME_FINAL_AF As Decimal)
        Me.ucEvaluacionesAccionFormativa1.idInformeFinal = ID_INFORME_FINAL_AF
        Me.ucEvaluacionesAccionFormativa1.CargarDatos()
    End Sub

    Private Sub CambiarEstado(ByVal NuevoEstado As Decimal, Optional Comentarios As String = "", Optional NotificarPorCorreo As Boolean = False)
        Dim bInformeFinal As New cINFORME_FINAL_AF
        Dim lEntidad As INFORME_FINAL_AF = bInformeFinal.ObtenerINFORME_FINAL_AF(Me.idInformeFinal)
        Dim lEstado As ESTADO_INFORME_AF
        Dim GenerarHistorico As Boolean = True

        lEstado = (New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(NuevoEstado)

        If lEntidad.ID_ESTADO_INFORME = EstadoInformeFinal.FacturaSolicitadaProveedor AndAlso lEstado.ID_ESTADO_INFORME = EstadoInformeFinal.FacturaSolicitadaProveedor Then
            GenerarHistorico = False
        End If
        If Not bInformeFinal.EsInformeBolpros(Me.idInformeFinal) AndAlso (NuevoEstado = EstadoInformeFinal.FacturaRecibida OrElse NuevoEstado = EstadoInformeFinal.FacturaEnRevision) Then
            'Verificar que se ha registrado la factura en el sistema
            Dim conFacturaEmitida As Boolean = False
            Dim listafacturaDet As listaFACTURA_DET = (New cFACTURA_DET).ObtenerListaPorINFORME_FINAL_AF(Me.idInformeFinal)
            If listafacturaDet IsNot Nothing AndAlso listafacturaDet.Count > 0 Then
                For i = 0 To listafacturaDet.Count - 1
                    Dim lFacturaEnca As FACTURA_AF = (New cFACTURA_AF).ObtenerFACTURA_AF(listafacturaDet(i).ID_FACTURA_AF)
                    If lFacturaEnca IsNot Nothing AndAlso lFacturaEnca.ESTADO = "E" Then
                        conFacturaEmitida = True
                        Exit For
                    End If
                Next
            End If

            If Not conFacturaEmitida Then
                Me.AsignarMensaje("No se logro cambiar de estado el documento. No se ha registrado factura para este curso.", True, True)
                Return
            End If
        End If
        If lEntidad.ID_ESTADO_INFORME = EstadoInformeFinal.EnTramiteDePago AndAlso NuevoEstado = EstadoInformeFinal.InformeValidadoTecnico Then
            'Anular las facturas que se registraron
            Dim lstDetaFactu As listaFACTURA_DET = (New cFACTURA_DET).ObtenerListaPorINFORME_FINAL_AF(lEntidad.ID_INFORME_FINAL)
            Dim lEncaFactu As New FACTURA_AF
            Dim bFacturaEnca As New cFACTURA_AF

            If lstDetaFactu IsNot Nothing AndAlso lstDetaFactu.Count > 0 Then
                For i As Integer = 0 To lstDetaFactu.Count - 1
                    lEncaFactu = bFacturaEnca.ObtenerFACTURA_AF(lstDetaFactu(i).ID_FACTURA_AF)
                    If lEncaFactu IsNot Nothing Then
                        lEncaFactu.ESTADO = "A"
                        lEncaFactu.LASTUPDATE = Now
                        lEncaFactu.USERID = Me.ObtenerUsuario
                        bFacturaEnca.ActualizarFACTURA_AF(lEncaFactu)
                    End If
                Next
            End If
        End If
        lEntidad.ID_ESTADO_INFORME = lEstado.ID_ESTADO_INFORME
        If NuevoEstado = EstadoInformeFinal.InformeEnRevision Then lEntidad.USUARIO_ASIGNADO = Me.ddlUSUARIO1.SelectedValue
        lEntidad.COMENTARIOS = Comentarios
        lEntidad.USERID = Me.ObtenerUsuario
        lEntidad.LASTUPDATE = Now
        If bInformeFinal.ActualizarINFORME_FINAL_AF(lEntidad, TipoConcurrencia.Pesimistica, False, GenerarHistorico, NotificarPorCorreo) < 1 Then
            Me.AsignarMensaje("No se logro cambiar de estado el documento. " + bInformeFinal.sError, True, True)
            Return
        End If
        Me.AsignarMensaje("Documento se ha cambiado al estado: " + lEstado.NOMBRE_ESTADO_INFORME, False, True)
        Me.txtObservacion.Text = ""

        Me.BuscarAccionFormativa()
        Me.Menu1.Items(0).Selected = True
        Me.MultiView1.ActiveViewIndex = 0
        Me.ConfigurarMenu("Lista de Informes")
        Me.ViewState("idAccionFormativa") = Nothing
        Me.ViewState("idInformeFinal") = Nothing
    End Sub

    Private Sub IngresarComentario(ByVal NuevoEstado As Decimal)
        Dim lEstado As ESTADO_INFORME_AF = (New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(Me.NUEVO_ESTADO)
        If lEstado IsNot Nothing Then Me.lblDescripEstado.Text = "El documento se cambiara a: " + lEstado.NOMBRE_ESTADO_INFORME
        Me.trlbl_ESTADO_INFORME.Visible = True
        Me.txtObservacion.Text = ""
        Me.mpObservacionEvaluacion.Show()
    End Sub

    Private Sub AsignarTecnico()
        Me.ddlUSUARIO1.RecuperarPorROL(RolDeUsuario.CARevision)
        Me.ddlUSUARIO1.SelectedIndex = -1
        Me.mpAsignarTecnico.Show()
    End Sub

    Public Property NUEVO_ESTADO As Decimal
        Get
            If Me.ViewState("NuevoEstado") Is Nothing Then
                Return CDec(-1)
            Else
                Return CDec(Me.ViewState("NuevoEstado"))
            End If
        End Get
        Set(value As Decimal)
            Me.ViewState("NuevoEstado") = value
        End Set
    End Property

    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.txtObservacion.Text.Trim.Length > 999 Then
            Me.AsignarMensaje("La Observación sobrepasa el tamaño permitido, por favor resuma en lo posible el texto de la Observación", True, True)
            Return
        End If
        If Me.txtObservacion.Text.Trim = "" Then
            Me.AsignarMensaje("Ingrese en observaciones el motivo del cambio de estado", True, True)
            Return
        End If
        Me.CambiarEstado(Me.NUEVO_ESTADO, Me.txtObservacion.Text.Trim.ToUpper, True)
    End Sub

    Protected Sub ASPxGridView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles ASPxGridView1.CustomUnboundColumnData
        If e.Column.FieldName = "CORRELATIVO" Then
            e.Value = e.ListSourceRowIndex + 1
        ElseIf e.Column.FieldName = "COMENTARIO" Then
            Dim eParticipanteAF As PARTICIPANTE_AF
            eParticipanteAF = (New cPARTICIPANTE_AF).ObtenerPARTICIPANTE_AF(e.GetListSourceFieldValue("ID_PARTICIPANTE"), Me.idAccionFormativa)
            If eParticipanteAF IsNot Nothing AndAlso eParticipanteAF.ESTADO = Enumeradores.EstadoParticipanteEnCurso.CambioDeCursoPorSistema Then
                e.Value = eParticipanteAF.NOTAS
            End If
        End If
    End Sub

    Protected Sub ucBarraNavegacion2_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion2.OpcionSeleccionada
        If CommandName = "GuardarReprogramacion" Then
            Dim bInformeFinal As New cINFORME_FINAL_AF
            Dim sError As String

            sError = Me.ucVistaDetalleACCION_FORMATIVA1.Actualizar()
            If sError <> "" Then
                AsignarMensaje(sError, True, True)
                Return
            End If

            Me.AsignarMensaje("Si ha modificado las Fechas de Programación del Curso debe Revisar y Verficar que la Asistencia de los Participantes no haya cambiado.", False, True)

            Me.CargarAsistencia(Me.idInformeFinal)
            Me.ObjectDataSource1.SelectParameters("ID_INFORME_FINAL").DefaultValue = Me.idInformeFinal.ToString()
            Me.ObjectDataSource1.DataBind()
            Me.ObjectDataSource2.SelectParameters("ID_INFORME_FINAL").DefaultValue = Me.idInformeFinal.ToString()
            Me.ObjectDataSource2.DataBind()
            Me.ASPxGridView1.DataBind()
            Me.ASPxGridView2.DataBind()

            Me.Menu1.Items(1).Selected = True
            Me.MultiView1.ActiveViewIndex = 1
        End If
    End Sub

    Private Function ObtenerDiasTransRecepcionInforme(ByVal ID_INFORME_FINAL As Int32) As Integer
        Dim dias As Integer = 0
        Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(ID_INFORME_FINAL)

        If lInforme IsNot Nothing Then
            Dim lAccion As ACCION_FORMATIVA = (New cACCION_FORMATIVA).ObtenerACCION_FORMATIVA(lInforme.ID_ACCION_FORMATIVA)
            Dim lInformeHist As INFORME_FINAL_AF_HIS = (New cINFORME_FINAL_AF_HIS).ObtenerUltimoRegistroEstado(ID_INFORME_FINAL, EstadoInformeFinal.InformeRecibido)

            If lInformeHist IsNot Nothing Then
                dias = DateDiff(DateInterval.Day, lAccion.FECHA_FIN_REAL, New DateTime(lInformeHist.LASTUPDATE.Year, lInformeHist.LASTUPDATE.Month, lInformeHist.LASTUPDATE.Day))
            Else
                dias = DateDiff(DateInterval.Day, lAccion.FECHA_FIN_REAL, Today)
            End If
            If dias < 0 Then dias = 0
        End If

        Return dias
    End Function

    Protected Sub ucListaINFORME_FINAL_AF1_Seleccionado(ByVal ID_INFORME_FINAL As Decimal) Handles ucListaINFORME_FINAL_AF1.Seleccionado
        Dim lEntidad As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(ID_INFORME_FINAL)
        Dim lInformeHist As INFORME_FINAL_AF_HIS
        Dim ID_ACCION_FORMATIVA As Decimal = lEntidad.ID_ACCION_FORMATIVA
        Me.ViewState("idInformeFinal") = ID_INFORME_FINAL
        Me.ViewState("idAccionFormativa") = lEntidad.ID_ACCION_FORMATIVA


        If lEntidad IsNot Nothing Then
            Dim lEstadoInforme As ESTADO_INFORME_AF = (New cESTADO_INFORME_AF).ObtenerESTADO_INFORME_AF(lEntidad.ID_ESTADO_INFORME)
            Dim lFaseInforme As FASE_ESTADO_INFORME = (New cFASE_ESTADO_INFORME).ObtenerFASE_ESTADO_INFORME(lEstadoInforme.ID_FASE_ESTADO)
            Dim lTecnicoAsignado As USUARIO = (New cUSUARIO).ObtenerUSUARIO(lEntidad.USUARIO_ASIGNADO)

            Me.dxlblFase.Text = lFaseInforme.NOMBRE_FASE_ESTADO + " (" + lEstadoInforme.NOMBRE_ESTADO_INFORME + ")"
            Me.dxlblEstado.Text = lEstadoInforme.DESCRIPCION_ESTADO
            Me.dxlblDiasTransRecepcion.Text = Me.ObtenerDiasTransRecepcionInforme(ID_INFORME_FINAL).ToString
            Me.dxlblNombreUsuario.Text = ""
            lblTecnicoAsignado.Text = ""

            If lTecnicoAsignado IsNot Nothing Then
                lblTecnicoAsignado.Text = lTecnicoAsignado.NOMBRE
            End If

            lInformeHist = (New cINFORME_FINAL_AF_HIS).ObtenerUltimoRegistroEstado(ID_INFORME_FINAL, lEntidad.ID_ESTADO_INFORME)
            If lInformeHist IsNot Nothing Then
                Dim lUsuario As USUARIO = (New cUSUARIO).ObtenerUSUARIO(lInformeHist.USERID)
                If lUsuario IsNot Nothing Then Me.dxlblNombreUsuario.Text = lUsuario.NOMBRE
            End If

            Me.CargarAsistencia(Me.idInformeFinal)
            Me.CargarNotas(Me.idInformeFinal)
            Me.CargarProgramacion(ID_ACCION_FORMATIVA)

            'Habilitar/Deshabilitar opción de Programación para el curso 
            Dim esInformeDevuelto As Boolean = (lEntidad.ID_ESTADO_INFORME = EstadoInformeFinal.InformeDevueltoConObservaciones OrElse lEntidad.ID_ESTADO_INFORME = EstadoInformeFinal.Emitido) AndAlso ((Me.EstaEnRol(RolDeUsuario.CentroCapacitador) OrElse Me.EstaEnRol(RolDeUsuario.Proveedor) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPATI) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPROYESPECIAL)))
            Dim esProveedorCentro As Boolean = (Me.EstaEnRol(RolDeUsuario.CentroCapacitador) OrElse Me.EstaEnRol(RolDeUsuario.Proveedor) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPATI) OrElse Me.EstaEnRol(RolDeUsuario.ProveedorPROYESPECIAL))
            If esInformeDevuelto Then
                Me.Menu1.Items(5).Enabled = True
            Else
                Me.Menu1.Items(5).Enabled = False
            End If

            'Habilitar/Deshabilitar opción de Histórico para el curso 
            If esProveedorCentro Then
                Me.Menu1.Items(4).Enabled = False
                Me.Menu1.Items(6).Enabled = False
            Else
                Me.Menu1.Items(4).Enabled = True
                Me.Menu1.Items(6).Enabled = True
            End If

            Me.ObjectDataSource1.SelectParameters("ID_INFORME_FINAL").DefaultValue = ID_INFORME_FINAL.ToString
            Me.ObjectDataSource1.DataBind()
            Me.ObjectDataSource2.SelectParameters("ID_INFORME_FINAL").DefaultValue = ID_INFORME_FINAL.ToString()
            Me.ObjectDataSource2.DataBind()
            Me.ASPxGridView1.DataBind()
            Me.ASPxGridView2.DataBind()

            Me.Menu1.Items(1).Enabled = True
            Me.Menu1.Items(2).Enabled = True
            Me.Menu1.Items(3).Enabled = True
            Me.Menu1.Items(7).Enabled = True
            Me.Menu1.Items(8).Enabled = True
            Me.Menu1.Items(1).Selected = True

            Me.MultiView1.ActiveViewIndex = 1
            ConfigurarMenu("Informe Final")

            Dim lAccionDetalle As ACCION_FORMATIVA_DETALLE = (New cACCION_FORMATIVA_DETALLE).ObtenerACCION_FORMATIVA_DETALLE(ID_ACCION_FORMATIVA)
            If lAccionDetalle IsNot Nothing Then
                Me.ASPxGridView2.Columns("HORAS_DESARROLLADAS").Visible = (lAccionDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL)
                Me.ASPxGridView2.Columns("HORAS_ACUMULADAS").Visible = (lAccionDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL)
                Me.ASPxGridView2.Columns("COSTO_X_HORA").Visible = (lAccionDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL)
                Me.ASPxGridView2.Columns("COSTO_X_PARTICIPANTE").Visible = Not (lAccionDetalle.ID_PROGRAMA_FORMACION = Enumeradores.ProgramasFormacion.PROYECTO_ESPECIAL)
            End If

            If InformeAutoGenerado() Then
                Me.AsignarMensaje("Este Informe Final fue generado en INSAFORP y no posee ANEXO II ya que no se solicitaban NOTAS en el momento que se Finalizo el curso.", False, True)
            End If

            Me.trALERTA.Visible = False
            Me.dxlblALERTA.Text = ""
            If lEntidad.ID_ESTADO_INFORME = EstadoInformeFinal.Emitido Then
                Dim lAccionPena As ACCION_FORMATIVA_PENA = (New cINFORME_FINAL_AF).GenerarPenalizacionPorEntregaTardia(lEntidad, False)
                If lAccionPena IsNot Nothing Then
                    Me.trALERTA.Visible = True
                    Me.dxlblALERTA.Text = "ESTE CURSO APLICA A PENALIZACION. MOTIVO: " + lAccionPena.MOTIVO
                End If
            End If

            Me.ResumenPago(ID_ACCION_FORMATIVA, ID_INFORME_FINAL)
        End If
    End Sub

    Private Sub ResumenPago(ByVal idAccionFormativa As Decimal, ByVal idInformeFinal As Decimal)
        Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(idInformeFinal)
        Dim lPenalizaciones As listaACCION_FORMATIVA_PENA = (New cACCION_FORMATIVA_PENA).ObtenerListaPorACCION_FORMATIVA(idAccionFormativa)
        Dim porcTotalPena As Decimal = 0

        If lPenalizaciones IsNot Nothing AndAlso lPenalizaciones.Count > 0 Then
            For i As Integer = 0 To lPenalizaciones.Count - 1
                porcTotalPena += lPenalizaciones(i).PORC_PENALIZACION
            Next
        End If
        lblMontoEjecutado.Text = Format(lInforme.MONTO_PAGO_INICIAL, "$ #,##0.00")
        lblMsjPenalizacion2.Text = "Menos " & Format(porcTotalPena, "#,##0.##") & "% de penalización sobre contrato:"
        lblMontoPena.Text = Format(lInforme.MONTO_PAGO_INICIAL - lInforme.MONTO_FACTURA, "$ #,##0.00")
        lblMontoPagar.Text = Format(lInforme.MONTO_FACTURA, "$ #,##0.00")
    End Sub

    Protected Sub ASPxGridView2_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxGridView.ASPxGridViewColumnDataEventArgs) Handles ASPxGridView2.CustomUnboundColumnData
        Dim lInforme As INFORME_FINAL_AF
        lInforme = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(Me.idInformeFinal)

        If e.Column.FieldName = "HORAS_ACUMULADAS" Then
            Dim listaInformes As listaINFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerListaPorACCION_FORMATIVA(Me.idAccionFormativa)
            Dim horasAcumuladas As Decimal = 0
            If listaInformes IsNot Nothing AndAlso listaInformes.Count > 0 Then
                For i As Integer = 0 To listaInformes.Count - 1
                    If listaInformes(i).FECHA_INICIAL <= lInforme.FECHA_INICIAL Then
                        horasAcumuladas += listaInformes(i).HORAS_DESARROLLADAS
                    End If
                Next
            End If
            e.Value = horasAcumuladas
        ElseIf e.Column.FieldName = "COSTO_X_HORA" Then
            e.Value = lInforme.COSTO_X_HORA
        End If
    End Sub

    Protected Sub btnAsignarTecnico_Click(sender As Object, e As EventArgs) Handles btnAsignarTecnico.Click
        If Me.ddlUSUARIO1.SelectedValue <> "" Then
            Me.CambiarEstado(Me.NUEVO_ESTADO)
        Else
            Me.AsignarMensaje("Debe asignar un técnico", True, True)
            Return
        End If
    End Sub
End Class
