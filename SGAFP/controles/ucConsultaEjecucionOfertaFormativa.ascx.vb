Imports DevExpress.Web.ASPxPivotGrid

Partial Class controles_ucConsultaEjecucionOfertaFormativa
    Inherits ucBase

    Private Sub MostrarCampoEnColumnArea(ByRef campo As PivotGridField)
        campo.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        campo.Visible = True
    End Sub

    Private Sub MostrarCampoEnDataArea(ByRef campo As PivotGridField)
        campo.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        campo.Visible = True
    End Sub

    Private Sub MostrarCampoEnRowArea(ByRef campo As PivotGridField)
        campo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        campo.Visible = True
    End Sub

    Private Sub MostrarCampoEnFilterArea(ByRef campo As PivotGridField)
        campo.Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea
        campo.Visible = True
    End Sub

    Public Sub CargarPerfil()
        Me.pgLista.Fields("NOMBRE_PROVEEDOR").Visible = False
        Me.pgLista.Fields("NOMBRE_SITIO").Visible = False
        Me.pgLista.Fields("AREA_FORMACION").Visible = False
        Me.pgLista.Fields("ID").Visible = False
        Me.pgLista.Fields("NOMBRE_ACCION_FORMATIVA").Visible = False
        Me.pgLista.Fields("CODIGO_GRUPO").Visible = False
        Me.pgLista.Fields("HORARIO").Visible = False
        Me.pgLista.Fields("Inicio").Visible = False
        Me.pgLista.Fields("FECHA_FIN_REAL").Visible = False
        Me.pgLista.Fields("COSTO_X_PARTICIPANTE").Visible = False
        Me.pgLista.Fields("DURACION_HORAS").Visible = False
        Me.pgLista.Fields("DIRECCION").Visible = False
        Me.pgLista.Fields("ENCARGADO").Visible = False
        Me.pgLista.Fields("TELEFONO_ENCARGADO").Visible = False
        Me.pgLista.Fields("PORCENTAJEEJEC").Visible = False
        Me.pgLista.Fields("NOMBRE_ESTADO_AF").Visible = False
        Me.pgLista.Fields("NOTAS").Visible = False

        Me.pgLista.Fields("N° Cursos").Visible = False
        Me.pgLista.Fields("Inscritos").Visible = False
        Me.pgLista.Fields("Costo").Visible = False

        Me.pgLista.Fields("Ejercicio").Visible = False
        Me.pgLista.Fields("Genero").Visible = False

        Select Case True
            Case Me.EstaEnRol(RolDeUsuario.CentroCapacitador), Me.EstaEnRol(RolDeUsuario.Proveedor)
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_PROVEEDOR"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_SITIO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_ACCION_FORMATIVA"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("CODIGO_GRUPO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("HORARIO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("Inicio"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("FECHA_FIN_REAL"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_ESTADO_AF"))

                Me.MostrarCampoEnColumnArea(Me.pgLista.Fields("Ejercicio"))

                Me.MostrarCampoEnDataArea(Me.pgLista.Fields("Inscritos"))
                Me.MostrarCampoEnDataArea(Me.pgLista.Fields("Costo"))

                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("AREA_FORMACION"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("COSTO_X_PARTICIPANTE"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("DURACION_HORAS"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("NOTAS"))


            Case Me.EstaEnRol(RolDeUsuario.Administrador)
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_PROVEEDOR"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("AREA_FORMACION"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_ACCION_FORMATIVA"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("CODIGO_GRUPO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("HORARIO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("Inicio"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("FECHA_FIN_REAL"))

                Me.MostrarCampoEnColumnArea(Me.pgLista.Fields("Ejercicio"))
                Me.MostrarCampoEnColumnArea(Me.pgLista.Fields("Genero"))

                Me.MostrarCampoEnDataArea(Me.pgLista.Fields("Inscritos"))

                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("COSTO_X_PARTICIPANTE"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("DURACION_HORAS"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("DIRECCION"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("ENCARGADO"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("TELEFONO_ENCARGADO"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("NOTAS"))

            Case Me.EstaEnRol(RolDeUsuario.TecnicoCentroHTP), Me.EstaEnRol(RolDeUsuario.JefeHTP), _
                    Me.EstaEnRol(RolDeUsuario.GerenteGFI)
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_PROVEEDOR"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_SITIO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("ID"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_ACCION_FORMATIVA"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("CODIGO_GRUPO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("HORARIO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("Inicio"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("FECHA_FIN_REAL"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_ESTADO_AF"))

                Me.MostrarCampoEnColumnArea(Me.pgLista.Fields("Ejercicio"))
                Me.MostrarCampoEnColumnArea(Me.pgLista.Fields("Genero"))

                Me.MostrarCampoEnDataArea(Me.pgLista.Fields("Inscritos"))
                Me.MostrarCampoEnDataArea(Me.pgLista.Fields("Costo"))

                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("AREA_FORMACION"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("COSTO_X_PARTICIPANTE"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("DURACION_HORAS"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("DIRECCION"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("ENCARGADO"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("TELEFONO_ENCARGADO"))
                Me.MostrarCampoEnFilterArea(Me.pgLista.Fields("NOTAS"))

            Case Me.EstaEnRol(RolDeUsuario.Auditor)
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_PROVEEDOR"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_SITIO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("ENCARGADO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("TELEFONO_ENCARGADO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("DIRECCION"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOTAS"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("NOMBRE_ACCION_FORMATIVA"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("DURACION_HORAS"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("Inicio"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("FECHA_FIN_REAL"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("HORARIO"))
                Me.MostrarCampoEnRowArea(Me.pgLista.Fields("fieldHORARIO_X_DIA"))
                Me.MostrarCampoEnColumnArea(Me.pgLista.Fields("Ejercicio"))
                Me.MostrarCampoEnDataArea(Me.pgLista.Fields("Inscritos"))
        End Select
    End Sub

    Public Function CargarEjecucionOfertaFormativa() As Integer
        If Decimal.Parse(Me.hfParametros("IdEjecucion")) <> -1 AndAlso CBool(Me.hfParametros("Actualizar")) Then
            Me.odsEjecucionOfertaFormativa.SelectParameters("TIPO_CONSULTA").DefaultValue = CInt(Me.hfParametros("IdEjecucion"))
            Me.odsEjecucionOfertaFormativa.SelectParameters("ID_EJERCICIO").DefaultValue = CStr(Me.hfParametros("IdEjercicio"))
            Me.odsEjecucionOfertaFormativa.SelectParameters("ID_PROVEEDOR_AF").DefaultValue = Decimal.Parse(Me.hfParametros("IdProveedor"))
            Me.odsEjecucionOfertaFormativa.SelectParameters("ID_SITIO_CAPACITACION").DefaultValue = Decimal.Parse(Me.hfParametros("IdCentroFormacion"))
            If Me.hfParametros("CodigoGrupo") IsNot Nothing Then
                Me.odsEjecucionOfertaFormativa.SelectParameters("CODIGO_GRUPO").DefaultValue = Me.hfParametros("CodigoGrupo")
            Else
                Me.odsEjecucionOfertaFormativa.SelectParameters("CODIGO_GRUPO").DefaultValue = ""
            End If
            Me.odsEjecucionOfertaFormativa.SelectParameters("ID_TIPO_SOLICITUD").DefaultValue = Decimal.Parse(Me.hfParametros("IdTipoSolicitud"))

            Me.pgLista.DataSourceID = "odsEjecucionOfertaFormativa"
            Me.pgLista.DataBind()
        End If
        Return 1
    End Function

    Private Sub InicializarParametros()
        Me.hfParametros.Clear()
        Me.hfParametros.Add("Actualizar", False)
        Me.hfParametros.Add("IdEjecucion", -1)
        Me.hfParametros.Add("IdEjercicio", "")
        Me.hfParametros.Add("IdProveedor", -1)
        Me.hfParametros.Add("IdCentroFormacion", -1)
        Me.hfParametros.Add("CodigoGrupo", "")
        Me.hfParametros.Add("IdTipoSolicitud", -1)
        Me.hfParametros.SyncWithServer = True
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.ucBarraNavegacion1.LimpiarOpciones()
            Me.CargarPerfil()
            Me.InicializarParametros()
            Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType(), "FuncionMostrarHistoricoAF", GenerarFuncionJSMostrarHistoricoAF, True)
        Else
            Me.CargarEjecucionOfertaFormativa()
        End If
    End Sub

    Protected Sub CallbackPanel_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles CallbackPanel.Callback
        Dim sParametros() As String
        sParametros = e.Parameter.Split(";")

        Me.hfParametros("Actualizar") = True
        Me.hfParametros("IdTipoSolicitud") = Decimal.Parse(sParametros(0))
        Me.hfParametros("IdProveedor") = Decimal.Parse(sParametros(1))
        Me.hfParametros("IdCentroFormacion") = Decimal.Parse(sParametros(2))
        Me.hfParametros("IdEjercicio") = sParametros(3)
        If sParametros(4) <> "null" Then
            Me.hfParametros("CodigoGrupo") = sParametros(4).Trim.ToUpper
        Else
            Me.hfParametros("CodigoGrupo") = ""
        End If
        Me.hfParametros("IdEjecucion") = Decimal.Parse(sParametros(5))

        Me.CargarEjecucionOfertaFormativa()
    End Sub

    Protected Sub pgLista_CustomUnboundFieldData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxPivotGrid.CustomFieldDataEventArgs) Handles pgLista.CustomUnboundFieldData
        If Object.ReferenceEquals(e.Field, Me.pgLista.Fields("ID")) Then
            If e.GetListSourceColumnValue("ID_ACCION_FORMATIVA") IsNot Nothing Then
                e.Value = String.Format("<a href=""javascript:MostrarHistoricoAF('{0}');"">{0}</a>", e.GetListSourceColumnValue("ID_ACCION_FORMATIVA").ToString)
            End If
        End If
        If Object.ReferenceEquals(e.Field, Me.pgLista.Fields("fieldHORARIO_X_DIA")) Then
            If e.GetListSourceColumnValue("ID_ACCION_FORMATIVA") IsNot Nothing Then
                e.Value = String.Format("<a href=""javascript:MostrarHorarioPorDia('{0}');""><img src=""../imagenes/Calendar_scheduleHS.png"" border=""0""/></a>", e.GetListSourceColumnValue("ID_ACCION_FORMATIVA").ToString)
            End If
        End If
    End Sub

    Protected Function GenerarFuncionJSMostrarHistoricoAF() As String
        Dim script As New StringBuilder

        script.Append("var postponedCallbackValuePopup = null; ")
        script.Append("function MostrarHistoricoAF(IdAccionFormativaAF) { ")
        script.Append(" if(CallbackPanelPopup.InCallback()) {")
        script.Append("     postponedCallbackValuePopup = IdAccionFormativaAF; ")
        script.Append(" } ")
        script.Append(" else { ")
        script.Append("     parametros = IdAccionFormativaAF; ")
        script.Append("     hfucListaACCION_FORMATIVA_HIST.Set('IdAccionFormativa',IdAccionFormativaAF); ")
        script.Append("     CallbackPanelPopup.PerformCallback('MostrarHistoricoAF;' + parametros); ")
        script.Append(" } ")
        script.Append("} ")

        script.Append("function MostrarHorarioPorDia(IdAccionFormativaAF) { ")
        script.Append(" if(CallbackPanelPopup.InCallback()) {")
        script.Append("     postponedCallbackValuePopup = IdAccionFormativaAF; ")
        script.Append(" } ")
        script.Append(" else { ")
        script.Append("     parametros = IdAccionFormativaAF; ")
        script.Append("     hfucListaACCION_FORMATIVA_HIST.Set('IdAccionFormativa',IdAccionFormativaAF); ")
        script.Append("     CallbackPanelPopup.PerformCallback('MostrarHorarioPorDia;' + parametros); ")
        script.Append(" } ")
        script.Append("} ")

        Return script.ToString
    End Function

    Protected Sub CallbackPanelPopup_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles CallbackPanelPopup.Callback
        Dim parametros() As String
        parametros = e.Parameter.Split(";")
        Me.CallbackPanelPopup.JSProperties.Add("cpResultCallback", "")
        Select Case parametros(0)
            Case "MostrarHistoricoAF"
                Me.ucListaACCION_FORMATIVA_HIST1.CargarDatosPorID_ACCION_FORMATIVA(parametros(1))
                Me.CallbackPanelPopup.JSProperties("cpResultCallback") = "MostrarHistoricoAF"

            Case "MostrarHorarioPorDia"
                Dim lEntidad As ACCION_FORMATIVA
                Dim bEntidad As New cACCION_FORMATIVA

                lEntidad = bEntidad.ObtenerACCION_FORMATIVA(Decimal.Parse(parametros(1)))
                If lEntidad IsNot Nothing Then
                    Me.lblID_ACCION_FORMATIVA.Text = lEntidad.ID_ACCION_FORMATIVA
                    Me.lblNOMBRE_ACCION_FORMATIVA.Text = lEntidad.NOMBRE_ACCION_FORMATIVA
                    Me.lblCODIGO_GRUPO.Text = lEntidad.CODIGO_GRUPO
                    Me.lblHORARIO_POR_DIA.Text = bEntidad.ObtenerHorarioPorDia(lEntidad.ID_ACCION_FORMATIVA)
                End If
                Me.CallbackPanelPopup.JSProperties("cpResultCallback") = "MostrarHorarioPorDia"
        End Select
    End Sub

    Protected Sub btnExportar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim NombreArchivo As New StringBuilder

        NombreArchivo.Append("HTP ")
        If hfParametros.Contains("IdEjercicio") AndAlso hfParametros("IdEjercicio") <> "" Then
            NombreArchivo.Append(hfParametros("IdEjercicio") + " EJECUCION ")
        End If
        If hfParametros.Contains("IdProveedor") AndAlso hfParametros("IdProveedor") <> -1 Then
            Dim ProveedorAF As PROVEEDOR_AF = (New cPROVEEDOR_AF).ObtenerPROVEEDOR_AF(CDec(hfParametros("IdProveedor")))
            If ProveedorAF IsNot Nothing Then NombreArchivo.Append(ProveedorAF.NOMBRE_PROVEEDOR + " - ")
        End If
        If hfParametros.Contains("IdCentroFormacion") AndAlso hfParametros("IdCentroFormacion") <> -1 Then
            Dim SitioCapacitacion As SITIO_CAPACITACION = (New cSITIO_CAPACITACION).ObtenerSITIO_CAPACITACION(CDec(hfParametros("IdCentroFormacion")))
            If SitioCapacitacion IsNot Nothing Then NombreArchivo.Append(SitioCapacitacion.NOMBRE_SITIO + " - ")
        End If
        If hfParametros.Contains("IdEjecucion") AndAlso hfParametros("IdEjecucion") <> -1 Then
            Select Case hfParametros("IdEjecucion")
                Case 0
                    NombreArchivo.Append("Cursos a Iniciar ")
                Case 1
                    NombreArchivo.Append("Cursos en Ejecución ")
                Case 2
                    NombreArchivo.Append("Cursos Finalizados ")
            End Select
        End If
        If hfParametros.Contains("CodigoGrupo") AndAlso hfParametros("CodigoGrupo") <> "" Then
            NombreArchivo.Append(hfParametros("CodigoGrupo"))
        End If

        Select Case Me.cbxExportar.SelectedIndex
            Case 0
                Me.ASPxPivotGridExporter1.ExportXlsToResponse(NombreArchivo.ToString.Trim, True)
            Case 1
                Me.ASPxPivotGridExporter1.ExportPdfToResponse(NombreArchivo.ToString.Trim, True)
        End Select
    End Sub
End Class
