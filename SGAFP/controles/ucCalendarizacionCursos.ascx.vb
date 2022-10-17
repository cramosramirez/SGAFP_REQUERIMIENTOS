
Partial Class controles_ucCalendarizacionCursos
    Inherits ucBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    Private Sub CargarDatos()
        'Me.UcBarraNavegacion1.PermitirExportarAExcel = True
        'Me.UcBarraNavegacion1.GridViewControlName = "dxgvLista"
        'Me.UcBarraNavegacion1.FileNameToExport = ""
        Me.UcBarraNavegacion1.CrearOpcion("Buscar Cursos", "Buscar Cursos", False, "~/imagenes/ButtonSearch.png")
        Me.UcBarraNavegacion1.CargarOpciones()
        Me.ucListaACCION_FORMATIVA1.PermitirFiltroPorFila = True
        Me.ucListaACCION_FORMATIVA1.AgregarHyperLinkField("ID_ACCION_FORMATIVA,ID_PROVEEDOR_AF,ID_TEMA_CURSO".Split(","), "~/CursosFormacion/wfSolicitudInscripcion.aspx?modoOp=1&ID_ACCION_FORMATIVA={0}&ID_PROVEEDOR_AF={1}&ID_TEMA_CURSO={2}", "Ingresar Solicitud", "_self")
    End Sub

    Protected Sub UcBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles UcBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Buscar Cursos" Then
            Me.BuscarCursos()
        End If
    End Sub

    Private Sub BuscarCursos()
        Me.ucListaACCION_FORMATIVA1.PermitirFiltroPorFila = True
        Me.ucListaACCION_FORMATIVA1.CargarDatosPorCriteriosPeriodoEstado(Me.ucCriteriosAccionFormativa1.idProveedor, _
                                                                   Me.ucCriteriosAccionFormativa1.idSitioCapacitacion, _
                                                                   Me.ucCriteriosAccionFormativa1.idAreaFormacion, _
                                                                   Me.ucCriteriosAccionFormativa1.nombreAccionFormativa, _
                                                                   Me.ucCriteriosAccionFormativa1.codigoGrupo, _
                                                                   Me.ucCriteriosAccionFormativa1.idEstadoAccion, _
                                                                   Me.ucCriteriosAccionFormativa1.idEjercicio, _
                                                                    Me.ucCriteriosAccionFormativa1.tdr)
    End Sub
End Class
