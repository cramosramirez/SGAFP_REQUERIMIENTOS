Imports System.Collections.Generic

Partial Class controles_ucConsultarParticipantes
    Inherits ucBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarDatos()
        End If
    End Sub

    Private Sub CargarDatos()
        Me.UcBarraNavegacion1.CrearOpcion("BuscarParticipantes", "Buscar", False, "~/imagenes/ButtonSearch.png")
        Me.UcBarraNavegacion1.CargarOpciones()
    End Sub

    Protected Sub UcBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles UcBarraNavegacion1.OpcionSeleccionada
        If CommandName = "BuscarParticipantes" Then
            Me.BuscarParticipantes()
        End If
    End Sub

    Private Sub BuscarParticipantes()

        Dim criterios As New List(Of Criteria)

        If Me.ucCriteriosParticipante1.idParticipante <> -1 Then
            criterios.Add(New Criteria("ID_PARTICIPANTE", "=", Me.ucCriteriosParticipante1.idParticipante.ToString(), "AND"))
        End If

        If Me.ucCriteriosParticipante1.nombresParticipante <> "" Then
            criterios.Add(New Criteria("NOMBRES", "%*%", Me.ucCriteriosParticipante1.nombresParticipante.ToUpper(), "AND"))
        End If

        If Me.ucCriteriosParticipante1.apellidosParticipante <> "" Then
            criterios.Add(New Criteria("APELLIDOS", "%*%", Me.ucCriteriosParticipante1.apellidosParticipante.ToUpper(), "AND"))
        End If

        If Not Me.ucCriteriosParticipante1.fechaNacimientoParticipante = Nothing Then
            criterios.Add(New Criteria("FECHA_NACIMIENTO", "=", Me.ucCriteriosParticipante1.fechaNacimientoParticipante.ToString("dd/MM/yyyy"), "AND"))
        End If

        If Me.ucCriteriosParticipante1.duiParticipante <> "" Then
            criterios.Add(New Criteria("DUI", "=", Me.ucCriteriosParticipante1.duiParticipante, "AND"))
        End If

        If Me.ucCriteriosParticipante1.nitParticipante <> "" Then
            criterios.Add(New Criteria("NIT", "=", Me.ucCriteriosParticipante1.nitParticipante, "AND"))
        End If

        Dim listaParticipantes As New listaPARTICIPANTE
        listaParticipantes = (New cPARTICIPANTE).ObtenerListaPorBusqueda(New PARTICIPANTE, criterios.ToArray())
        Me.ucListaPARTICIPANTE1.CargarDatosPorBusqueda(criterios.ToArray())

    End Sub

End Class
