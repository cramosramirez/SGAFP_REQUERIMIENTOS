Imports System.Collections.Generic

Partial Class controles_ucConsultarOfertaFormativa
    Inherits ucBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    Private Sub CargarDatos()
        Me.UcBarraNavegacion1.CrearOpcion("BuscarOfertaFormativa", "Buscar", False, "~/imagenes/ButtonSearch.png")
        Me.UcBarraNavegacion1.CargarOpciones()
    End Sub

    Protected Sub UcBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles UcBarraNavegacion1.OpcionSeleccionada
        If CommandName = "BuscarOfertaFormativa" Then
            Me.BuscarOfertaFormativa()
        End If
    End Sub

    Private Sub BuscarOfertaFormativa()

        Dim criterios As New List(Of Criteria)

        If Me.ucCriteriosOfertaFormativa1.idProveedor <> -1 Then
            criterios.Add(New Criteria("ID_PROVEEDOR_AF", "F", "=", Me.ucCriteriosOfertaFormativa1.idProveedor.ToString(), "AND"))
        End If

        If Me.ucCriteriosOfertaFormativa1.idEjercicio <> "" Then
            criterios.Add(New Criteria("ID_EJERCICIO", "=", Me.ucCriteriosOfertaFormativa1.idEjercicio, "AND"))
        End If

        If Me.ucCriteriosOfertaFormativa1.idAreaFormacion <> -1 Then
            criterios.Add(New Criteria("ID_AREA_FORMACION", "=", Me.ucCriteriosOfertaFormativa1.idAreaFormacion.ToString(), "AND"))
        End If

        If Me.ucCriteriosOfertaFormativa1.nombreAccionFormativa <> "" Then
            criterios.Add(New Criteria("TEMA_CURSO", "%*%", Me.ucCriteriosOfertaFormativa1.nombreAccionFormativa.ToUpper(), "AND"))
        End If

        'If Not Me.ucCriteriosParticipante1.fechaNacimientoParticipante = Nothing Then
        '    criterios.Add(New Criteria("FECHA_NACIMIENTO", "=", Me.ucCriteriosParticipante1.fechaNacimientoParticipante.ToString("dd/MM/yyyy"), "AND"))
        'End If

        'If Me.ucCriteriosParticipante1.duiParticipante <> "" Then
        '    criterios.Add(New Criteria("DUI", "=", Me.ucCriteriosParticipante1.duiParticipante, "AND"))
        'End If

        'If Me.ucCriteriosParticipante1.nitParticipante <> "" Then
        '    criterios.Add(New Criteria("NIT", "=", Me.ucCriteriosParticipante1.nitParticipante, "AND"))
        'End If

        'Dim listaOfertaFormativa As New listaOFERTA_FORMATIVA
        'listaOfertaFormativa = (New cOFERTA_FORMATIVA).ObtenerOfertaFormativaPorCriterios(criterios.ToArray())
        'Me.ucListaOFERTA_FORMATIVA1.CargarDatosPorLista(listaOfertaFormativa)
        Me.ucListaOFERTA_FORMATIVA1.CargarDatosPorCriterios(criterios.ToArray())

    End Sub

End Class
