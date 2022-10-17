Imports System.Collections.Generic
Partial Class controles_ucEvaluacionesAccionFormativa
    Inherits ucBase

    Public Property EsInformeFinal() As Boolean
        Get
            If Me.ViewState("EsInformeFinal") Is Nothing Then Return False
            Return Me.ViewState("EsInformeFinal")
        End Get
        Set(ByVal value As Boolean)
            Me.ViewState("EsInformeFinal") = value
        End Set
    End Property

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
        Me.CargarDatos()
    End Sub

    Public Sub CargarDatos()
        If idInformeFinal > 0 Then
            Me.UcBarraNavegacion1.LimpiarOpciones()
            Dim lInforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(idInformeFinal)
            Me.ucCriteriosAccionFormativa1.Visible = False
            Me.ConfigurarMenu("Evaluaciones")
            Me.MultiView1.ActiveViewIndex = 1
            Me.Menu1.Items(0).Enabled = False
            Me.Menu1.Items(0).Text = ""
            Me.Menu1.Items(1).Selected = True
            If (Me.EstaEnRol(RolDeUsuario.CentroCapacitador) Or Me.EstaEnRol(RolDeUsuario.Proveedor) Or Me.EstaEnRol(RolDeUsuario.ProveedorPATI) Or Me.EstaEnRol(RolDeUsuario.ProveedorPROYESPECIAL)) And (lInforme.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.Emitido Or lInforme.ID_ESTADO_INFORME = Enumeradores.EstadoInformeFinal.InformeDevueltoConObservaciones) Then
                Me.UcBarraNavegacion1.CrearOpcion("AgregarEvaluacion", "Agregar", False, "~/imagenes/Nuevo.gif")
                Me.UcBarraNavegacion1.CrearOpcion("GuardarEvaluacion", "Guardar", False, "~/imagenes/Almacenar.gif")
            Else
                Me.ucListaEVALUACION_AF1.PermitirEliminar = False
            End If
            Me.UcBarraNavegacion1.CargarOpciones()
            Me.UcBarraNavegacion1.VerOpcion("AgregarEvaluacion", True)
            Me.UcBarraNavegacion1.VerOpcion("GuardarEvaluacion", False)
            Me.ucListaEVALUACION_AF1.CargarDatosPorINFORME_FINAL_AF(idInformeFinal)
        Else
            Me.UcBarraNavegacion1.CrearOpcion("BuscarAccionFormativa", "Buscar", False, "~/imagenes/ButtonSearch.png")
            Me.UcBarraNavegacion1.CrearOpcion("AgregarEvaluacion", "Agregar", False, "~/imagenes/Nuevo.png")
            Me.UcBarraNavegacion1.CrearOpcion("GuardarEvaluacion", "Guardar", True, "~/imagenes/ButtonSave.png")
            Me.UcBarraNavegacion1.CargarOpciones()
            Me.UcBarraNavegacion1.VerOpcion("AgregarEvaluacion", False)
            Me.UcBarraNavegacion1.VerOpcion("GuardarEvaluacion", False)
        End If
    End Sub

    Protected Sub UcBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles UcBarraNavegacion1.OpcionSeleccionada
        If CommandName = "BuscarAccionFormativa" Then
            Me.BuscarAccionFormativa()
        End If
        If CommandName = "AgregarEvaluacion" Then
            Me.AgregarEvaluacion()
        End If
        If CommandName = "GuardarEvaluacion" Then
            Me.GuardarEvaluacion()
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

    Protected Sub Menu1_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick
        Me.MultiView1.ActiveViewIndex = Int32.Parse(e.Item.Value)
        ConfigurarMenu(e.Item.Text)
    End Sub

    Private Sub ConfigurarMenu(ByVal nombreMenu As String)
        Me.UcBarraNavegacion1.VerOpcion("BuscarAccionFormativa", True)
        Me.UcBarraNavegacion1.VerOpcion("AgregarEvaluacion", False)
        Me.UcBarraNavegacion1.VerOpcion("GuardarEvaluacion", False)

        If nombreMenu = "Evaluaciones" Then
            Me.UcBarraNavegacion1.VerOpcion("BuscarAccionFormativa", False)
            Me.UcBarraNavegacion1.VerOpcion("AgregarEvaluacion", True)
            Me.UcBarraNavegacion1.VerOpcion("GuardarEvaluacion", False)
        End If

        If nombreMenu = "Detalle Evaluacion" Then
            Me.UcBarraNavegacion1.VerOpcion("BuscarAccionFormativa", False)
            Me.UcBarraNavegacion1.VerOpcion("AgregarEvaluacion", False)
            Me.UcBarraNavegacion1.VerOpcion("GuardarEvaluacion", True)
        End If

    End Sub

    Protected Sub ucListaACCION_FORMATIVA1_Seleccionado(ByVal ID_ACCION_FORMATIVA As Decimal) Handles ucListaACCION_FORMATIVA1.Seleccionado
        Me.ViewState("idAccionFormativa") = ID_ACCION_FORMATIVA
        Me.ucListaEVALUACION_AF1.CargarDatosPorACCION_FORMATIVA(ID_ACCION_FORMATIVA)
        Me.ucVistaDetalleEVALUACION_AF1.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
        Me.ucListaEVALUACIONES_AF_DET1.CargarDatosPorEVALUACION_AF(Me.ucVistaDetalleEVALUACION_AF1.ID_EVALUACION_AF)
        Me.Menu1.Items(1).Selected = True
        Me.MultiView1.ActiveViewIndex = 1
        ConfigurarMenu("Evaluaciones")
    End Sub

    Private Sub AgregarEvaluacion()
        If Me.EsInformeFinal AndAlso Me.idInformeFinal > 0 Then
            Dim linforme As INFORME_FINAL_AF = (New cINFORME_FINAL_AF).ObtenerINFORME_FINAL_AF(Me.idInformeFinal)
            Me.ucVistaDetalleEVALUACION_AF1.ID_ACCION_FORMATIVA = linforme.ID_ACCION_FORMATIVA
        Else
            Me.ucVistaDetalleEVALUACION_AF1.ID_ACCION_FORMATIVA = Me.idAccionFormativa
        End If
        Me.ucVistaDetalleEVALUACION_AF1.ID_EVALUACION_AF = 0
        Me.ucListaEVALUACIONES_AF_DET1.Visible = False
        Me.Menu1.Items(2).Selected = True
        Me.MultiView1.ActiveViewIndex = 2
        ConfigurarMenu("Detalle Evaluacion")
    End Sub

    Private Sub GuardarEvaluacion()
        Dim esNuevo As Boolean = False
        Dim lRet As String
        esNuevo = (Me.ucVistaDetalleEVALUACION_AF1.ID_EVALUACION_AF = 0)
        lRet = Me.ucVistaDetalleEVALUACION_AF1.Actualizar()
        If lRet <> "" Then
            Me.AsignarMensaje(lRet)
            Return
        End If
        If Not esNuevo Then
            Me.ucListaEVALUACIONES_AF_DET1.Actualizar(Me.ucVistaDetalleEVALUACION_AF1.ID_EVALUACION_AF)
            Me.CalcularPromedioNotas(Me.ucVistaDetalleEVALUACION_AF1.ID_EVALUACION_AF)
            Me.AsignarMensaje("Se guardo la Evaluacion satisfactoriamente.")
        Else
            Me.AsignarMensaje("Se guardo la Evaluacion satisfactoriamente.")
            Me.ucListaEVALUACIONES_AF_DET1.Visible = True
        End If
        Me.ucListaEVALUACIONES_AF_DET1.CargarDatosPorEVALUACION_AF(Me.ucVistaDetalleEVALUACION_AF1.ID_EVALUACION_AF)
        If idInformeFinal > 0 Then
            Me.ucListaEVALUACION_AF1.CargarDatosPorINFORME_FINAL_AF(idInformeFinal)
        Else
            Me.ucListaEVALUACION_AF1.CargarDatosPorACCION_FORMATIVA(idAccionFormativa)
        End If
    End Sub

    Private Sub CalcularPromedioNotas(ByVal ID_EVALUACION_AF As Decimal)

        Dim lEvaluacion As EVALUACION_AF = (New cEVALUACION_AF).ObtenerEVALUACION_AF(ID_EVALUACION_AF)
        Dim listaEvaluacionDet As listaEVALUACIONES_AF_DET
        listaEvaluacionDet = (New cEVALUACIONES_AF_DET).ObtenerListaPorEVALUACION_AF(lEvaluacion.ID_EVALUACION_AF)
        Dim numAprobados, numReprobados As Integer
        numAprobados = 0
        numReprobados = 0

        For Each lEvaluacionDet As EVALUACIONES_AF_DET In listaEvaluacionDet
            If lEvaluacionDet.NOTA_OBTENIDA >= 7 Then
                numAprobados += 1
            Else
                numReprobados += 1
            End If
        Next

        lEvaluacion.PORC_APROBACION = numAprobados / (numAprobados + numReprobados) * 100
        lEvaluacion.PORC_REPROBADOS = numReprobados / (numAprobados + numReprobados) * 100
        If (New cEVALUACION_AF).ActualizarEVALUACION_AF(lEvaluacion) < 1 Then

        End If

        Me.ucVistaDetalleEVALUACION_AF1.ID_EVALUACION_AF = lEvaluacion.ID_EVALUACION_AF

    End Sub

    Protected Sub ucListaEVALUACION_AF1_Seleccionado(ByVal ID_EVALUACION_AF As Decimal) Handles ucListaEVALUACION_AF1.Seleccionado
        Me.ucVistaDetalleEVALUACION_AF1.ID_EVALUACION_AF = ID_EVALUACION_AF
        Me.ucListaEVALUACIONES_AF_DET1.CargarDatosPorEVALUACION_AF(ID_EVALUACION_AF)

        Me.ucListaEVALUACIONES_AF_DET1.Visible = True
        Me.Menu1.Items(2).Selected = True
        Me.MultiView1.ActiveViewIndex = 2
        ConfigurarMenu("Detalle Evaluacion")
    End Sub

End Class
