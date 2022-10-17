Imports DevExpress.Web.ASPxPivotGrid

Partial Class controles_ucConsultaEjecucionCursosPATI
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

    'Public Sub CargarPerfil()
    '    Me.pgLista.Fields("NOMBRE_PROVEEDOR").Visible = False
    '    Me.pgLista.Fields("NOMBRE_SITIO").Visible = False
    '    Me.pgLista.Fields("AREA_FORMACION").Visible = False
    '    Me.pgLista.Fields("ID").Visible = False
    '    Me.pgLista.Fields("NOMBRE_ACCION_FORMATIVA").Visible = False
    '    Me.pgLista.Fields("CODIGO_GRUPO").Visible = False
    '    Me.pgLista.Fields("HORARIO").Visible = False
    '    Me.pgLista.Fields("Inicio").Visible = False
    '    Me.pgLista.Fields("FECHA_FIN_REAL").Visible = False
    '    Me.pgLista.Fields("COSTO_X_PARTICIPANTE").Visible = False
    '    Me.pgLista.Fields("DURACION_HORAS").Visible = False
    '    Me.pgLista.Fields("DIRECCION").Visible = False
    '    Me.pgLista.Fields("ENCARGADO").Visible = False
    '    Me.pgLista.Fields("TELEFONO_ENCARGADO").Visible = False
    '    Me.pgLista.Fields("PORCENTAJEEJEC").Visible = False
    '    Me.pgLista.Fields("NOMBRE_ESTADO_AF").Visible = False
    '    Me.pgLista.Fields("NOTAS").Visible = False

    '    Me.pgLista.Fields("N° Cursos").Visible = False
    '    Me.pgLista.Fields("Inscritos").Visible = False
    '    Me.pgLista.Fields("Costo").Visible = False

    '    Me.pgLista.Fields("Ejercicio").Visible = False
    '    Me.pgLista.Fields("Genero").Visible = False
    'End Sub

    Private Sub InicializarParametros()

        Me.CrearOpcion("Recuperar", "Recuperar", False, "~/imagenes/buscar.gif", "onclick", "ucCECPATI_CP.PerformCallback(cbxFuenteFinanc.GetValue().toString() + ';' + seConvocatoria.GetValue().toString());e.processOnServer=false;")
        Me.CargarOpciones()
    End Sub

    Public Overrides Sub EjecutarOpcion(ByVal CommandName As String)
        If CommandName = "Recuperar" Then
            Me.RecuperarDatos()
        End If
    End Sub

    Private Sub RecuperarDatos()
        Dim noConvocatoria As Integer = Me.ucCriteriosConsultaEjecucionPATI1.noConvocatoria
        Dim idFuente As Integer = Me.ucCriteriosConsultaEjecucionPATI1.idFuente
        Select Case idFuente
            Case 1
                Me.odsEjecucionCursosPATI.SelectParameters("id_tipo_solicitud").DefaultValue = 3
            Case 2
                Me.odsEjecucionCursosPATI.SelectParameters("id_tipo_solicitud").DefaultValue = 2
            Case 3
                Me.odsEjecucionCursosPATI.SelectParameters("id_tipo_solicitud").DefaultValue = 5
        End Select
        Me.odsEjecucionCursosPATI.SelectParameters("no_convocatoria").DefaultValue = noConvocatoria
        Me.odsEjecucionCursosPATI.SelectParameters("fecha_inicio").DefaultValue = Now.AddDays(-10)
        Me.odsEjecucionCursosPATI.SelectParameters("fecha_fin").DefaultValue = Now.AddDays(10)
        Me.odsEjecucionCursosPATI.DataBind()
        Me.pgLista.DataBind()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            'Me.ucBarraNavegacion1.LimpiarOpciones()
            'Me.CargarPerfil()
            Me.InicializarParametros()
            'Me.Page.ClientScript.RegisterStartupScript(Me.Page.GetType(), "FuncionMostrarHistoricoAF", GenerarFuncionJSMostrarHistoricoAF, True)
        Else
            'Me.CargarEjecucionOfertaFormativa()
        End If
    End Sub

    Protected Sub CallbackPanel_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles CallbackPanel.Callback
        Dim sParametros() As String
        sParametros = e.Parameter.Split(";")

        Dim idFuente As Integer = sParametros(0)
        Select Case idFuente
            Case 1
                Me.odsEjecucionCursosPATI.SelectParameters("id_tipo_solicitud").DefaultValue = 3
            Case 2
                Me.odsEjecucionCursosPATI.SelectParameters("id_tipo_solicitud").DefaultValue = 2
            Case 3
                Me.odsEjecucionCursosPATI.SelectParameters("id_tipo_solicitud").DefaultValue = 5
        End Select

        Dim noConvocatoria As Integer = sParametros(1)
        Me.odsEjecucionCursosPATI.SelectParameters("no_convocatoria").DefaultValue = noConvocatoria
        Me.odsEjecucionCursosPATI.SelectParameters("fecha_inicio").DefaultValue = Now.AddDays(-30)
        Me.odsEjecucionCursosPATI.SelectParameters("fecha_fin").DefaultValue = Now.AddDays(30)
        Me.odsEjecucionCursosPATI.DataBind()
        Me.pgLista.DataBind()


        'Me.hfParametros("Actualizar") = True
        'Me.hfParametros("IdTipoSolicitud") = idTipoSolicitud

        'Me.CargarEjecucionOfertaFormativa()
    End Sub

    'Protected Sub pgLista_CustomUnboundFieldData(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxPivotGrid.CustomFieldDataEventArgs) Handles pgLista.CustomUnboundFieldData
    '    If Object.ReferenceEquals(e.Field, Me.pgLista.Fields("ID")) Then
    '        If e.GetListSourceColumnValue("ID_ACCION_FORMATIVA") IsNot Nothing Then
    '            e.Value = String.Format("<a href=""javascript:MostrarHistoricoAF('{0}');"">{0}</a>", e.GetListSourceColumnValue("ID_ACCION_FORMATIVA").ToString)
    '        End If
    '    End If
    '    If Object.ReferenceEquals(e.Field, Me.pgLista.Fields("fieldHORARIO_X_DIA")) Then
    '        If e.GetListSourceColumnValue("ID_ACCION_FORMATIVA") IsNot Nothing Then
    '            e.Value = String.Format("<a href=""javascript:MostrarHorarioPorDia('{0}');""><img src=""../imagenes/Calendar_scheduleHS.png"" border=""0""/></a>", e.GetListSourceColumnValue("ID_ACCION_FORMATIVA").ToString)
    '        End If
    '    End If
    'End Sub

    'Protected Function GenerarFuncionJSMostrarHistoricoAF() As String
    '    Dim script As New StringBuilder

    '    script.Append("var postponedCallbackValuePopup = null; ")
    '    script.Append("function MostrarHistoricoAF(IdAccionFormativaAF) { ")
    '    script.Append(" if(CallbackPanelPopup.InCallback()) {")
    '    script.Append("     postponedCallbackValuePopup = IdAccionFormativaAF; ")
    '    script.Append(" } ")
    '    script.Append(" else { ")
    '    script.Append("     parametros = IdAccionFormativaAF; ")
    '    script.Append("     hfucListaACCION_FORMATIVA_HIST.Set('IdAccionFormativa',IdAccionFormativaAF); ")
    '    script.Append("     CallbackPanelPopup.PerformCallback('MostrarHistoricoAF;' + parametros); ")
    '    script.Append(" } ")
    '    script.Append("} ")

    '    script.Append("function MostrarHorarioPorDia(IdAccionFormativaAF) { ")
    '    script.Append(" if(CallbackPanelPopup.InCallback()) {")
    '    script.Append("     postponedCallbackValuePopup = IdAccionFormativaAF; ")
    '    script.Append(" } ")
    '    script.Append(" else { ")
    '    script.Append("     parametros = IdAccionFormativaAF; ")
    '    script.Append("     hfucListaACCION_FORMATIVA_HIST.Set('IdAccionFormativa',IdAccionFormativaAF); ")
    '    script.Append("     CallbackPanelPopup.PerformCallback('MostrarHorarioPorDia;' + parametros); ")
    '    script.Append(" } ")
    '    script.Append("} ")

    '    Return script.ToString
    'End Function

    'Protected Sub CallbackPanelPopup_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles CallbackPanelPopup.Callback
    'Dim parametros() As String
    'parametros = e.Parameter.Split(";")
    'Me.CallbackPanelPopup.JSProperties.Add("cpResultCallback", "")
    'Select Case parametros(0)
    '    Case "MostrarHistoricoAF"
    '        Me.ucListaACCION_FORMATIVA_HIST1.CargarDatosPorID_ACCION_FORMATIVA(parametros(1))
    '        Me.CallbackPanelPopup.JSProperties("cpResultCallback") = "MostrarHistoricoAF"

    '    Case "MostrarHorarioPorDia"
    '        Dim lEntidad As ACCION_FORMATIVA
    '        Dim bEntidad As New cACCION_FORMATIVA

    '        lEntidad = bEntidad.ObtenerACCION_FORMATIVA(Decimal.Parse(parametros(1)))
    '        If lEntidad IsNot Nothing Then
    '            Me.lblID_ACCION_FORMATIVA.Text = lEntidad.ID_ACCION_FORMATIVA
    '            Me.lblNOMBRE_ACCION_FORMATIVA.Text = lEntidad.NOMBRE_ACCION_FORMATIVA
    '            Me.lblCODIGO_GRUPO.Text = lEntidad.CODIGO_GRUPO
    '            Me.lblHORARIO_POR_DIA.Text = bEntidad.ObtenerHorarioPorDia(lEntidad.ID_ACCION_FORMATIVA)
    '        End If
    '        Me.CallbackPanelPopup.JSProperties("cpResultCallback") = "MostrarHorarioPorDia"
    'End Select
    'End Sub

   
End Class
