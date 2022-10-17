Imports System.Collections.Generic

Partial Class controles_ucAsistenciaAccionFormativa
    Inherits ucBase

    Public Property idInformeFinal() As Decimal
        Get
            If Me.ViewState("idInformeFinal") Is Nothing Then Return 0
            Return Me.ViewState("idInformeFinal")
        End Get
        Set(ByVal value As Decimal)
            Me.ViewState("idInformeFinal") = value
        End Set
    End Property

    Public Property idAccionFormativa() As Decimal
        Get
            If Me.ViewState("idAccionFormativa") Is Nothing Then Return 0
            Return Me.ViewState("idAccionFormativa")
        End Get
        Set(ByVal value As Decimal)
            Me.ViewState("idAccionFormativa") = value
        End Set
    End Property

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    Public Sub CargarDatos()
        If idInformeFinal > 0 Then
            Me.UcBarraNavegacion1.LimpiarOpciones()
            Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(idInformeFinal)
            Me.ucCriteriosAccionFormativa1.Visible = False
            Me.ConfigurarMenu("Listados Asistencia")
            Me.ASPxPageControl1.ActiveTabIndex = 1
            Me.ASPxPageControl1.TabPages(0).ClientVisible = False
            Me.UcBarraNavegacion1.CrearOpcion("ReporteFormatoFirma", "Lista para Firma", False, "~/imagenes/pro.png")
            Me.UcBarraNavegacion1.CrearOpcion("ReporteAsistenciaReal", "Lista de Asistencia", False, "~/imagenes/pro.png")
            Me.UcBarraNavegacion1.CargarOpciones()
            Me.ucAsistenciaAccionFormativaHoras1.ID_INFORME_FINAL_AF = idInformeFinal
        Else
            Me.UcBarraNavegacion1.CrearOpcion("BuscarAccionFormativa", "Buscar", False, "~/imagenes/ButtonSearch.png")
            Me.UcBarraNavegacion1.CrearOpcion("ReporteFormatoFirma", "Lista para Firma", False, "~/imagenes/pro.png")
            Me.UcBarraNavegacion1.CrearOpcion("ReporteAsistenciaReal", "Lista de Asistencia", False, "~/imagenes/pro.png")
            Me.UcBarraNavegacion1.CargarOpciones()
            Me.UcBarraNavegacion1.VerOpcion("ReporteFormatoFirma", False)
            Me.UcBarraNavegacion1.VerOpcion("ReporteAsistenciaReal", False)
        End If
    End Sub

    Protected Sub UcBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles UcBarraNavegacion1.OpcionSeleccionada
        If CommandName = "BuscarAccionFormativa" Then
            Me.BuscarAccionFormativa()
        End If
        If CommandName = "ReporteFormatoFirma" Then
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "ReporteFormatoFirma", "window.open('../reportes/wfReporteFormatoAsistencia.aspx?af=" + Me.idAccionFormativa.ToString() + "','_blank','')", True)
        End If
        If CommandName = "ReporteAsistenciaReal" Then
            ScriptManager.RegisterStartupScript(Me.Page, Me.Page.GetType(), "ReporteAsistenciaReal", "window.open('../reportes/wfReporteFormatoAsistencia.aspx?af=" + Me.idAccionFormativa.ToString() + "&real=1','_blank','')", True)
        End If
    End Sub

    Private Sub BuscarAccionFormativa()
        Dim c As SQLMembershipProvider.BL.cmembershipProvider
        Dim listaRoles As New List(Of String)
        Dim listaCodigoEstados As New List(Of String)
        Dim sbRoles As New StringBuilder
        Dim sbCodigoEstados As New StringBuilder

        c = CType(System.Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)
        listaRoles = c.ObtenerRoles(Me.ObtenerUsuario)
        listaCodigoEstados.Add(Enumeradores.EstadoAccionFormativa.Iniciada)

        For i As Integer = 0 To listaRoles.Count - 1
            sbRoles.Append(listaRoles(i))
            If i < listaRoles.Count - 1 Then sbRoles.Append(";")
        Next
        For i As Integer = 0 To listaCodigoEstados.Count - 1
            sbCodigoEstados.Append(listaCodigoEstados(i))
            If i < listaCodigoEstados.Count - 1 Then sbCodigoEstados.Append(";")
        Next

        Me.ucListaACCION_FORMATIVA1.CargarDatosPorCriteriosRoles( _
                Me.ucCriteriosAccionFormativa1.idProveedor, _
                Me.ucCriteriosAccionFormativa1.idSitioCapacitacion, _
                Me.ucCriteriosAccionFormativa1.idAreaFormacion, _
                Me.ucCriteriosAccionFormativa1.nombreAccionFormativa, _
                Me.ucCriteriosAccionFormativa1.codigoGrupo, _
                Me.ucCriteriosAccionFormativa1.idEjercicio, _
                sbRoles.ToString, sbCodigoEstados.ToString, _
                Me.ucCriteriosAccionFormativa1.tdr)
    End Sub

    Private Sub ConfigurarMenu(ByVal nombreMenu As String)
        Me.UcBarraNavegacion1.VerOpcion("BuscarAccionFormativa", True)
        Me.UcBarraNavegacion1.VerOpcion("ReporteFormatoFirma", False)
        Me.UcBarraNavegacion1.VerOpcion("ReporteAsistenciaReal", False)
        If nombreMenu = "Listados Asistencia" Then
            Me.UcBarraNavegacion1.VerOpcion("BuscarAccionFormativa", False)
            Me.UcBarraNavegacion1.VerOpcion("ReporteFormatoFirma", True)
            Me.UcBarraNavegacion1.VerOpcion("ReporteAsistenciaReal", True)
        End If

        If nombreMenu = "Asistencia" Then
            Me.UcBarraNavegacion1.VerOpcion("BuscarAccionFormativa", False)
            Me.UcBarraNavegacion1.VerOpcion("ReporteFormatoFirma", True)
            Me.UcBarraNavegacion1.VerOpcion("ReporteAsistenciaReal", True)
        End If
    End Sub

    Protected Sub ucListaACCION_FORMATIVA1_Seleccionado(ByVal ID_ACCION_FORMATIVA As Decimal) Handles ucListaACCION_FORMATIVA1.Seleccionado
        Me.ViewState("idAccionFormativa") = ID_ACCION_FORMATIVA
        Me.ucAsistenciaAccionFormativaHoras1.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
        Me.ASPxPageControl1.ActiveTabIndex = 1
        ConfigurarMenu("Listados Asistencia")
    End Sub

    Protected Sub ASPxPageControl1_ActiveTabChanging(ByVal source As Object, ByVal e As DevExpress.Web.ASPxTabControl.TabControlCancelEventArgs) Handles ASPxPageControl1.ActiveTabChanging
        ConfigurarMenu(e.Tab.Text)
    End Sub

End Class

