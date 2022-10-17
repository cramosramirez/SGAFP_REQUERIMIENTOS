Imports System.Collections.Generic

Partial Class controles_ucVisitaSeguimientoEC
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ACCION_CONTRATADA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/03/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, "~/imagenes/ButtonSearch.png")
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", False, "~/imagenes/ButtonSave.png")
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, "~/imagenes/Undo-icon.png")
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucCriteriosAccionFormativa1.Visible = True
        Me.ucListaACCION_FORMATIVA1.Visible = True
    End Sub

#End Region

    Public Property ID_ACCION_FORMATIVA As Integer 
        Get
            If Me.ViewState("ID_ACCION_FORMATIVA") IsNot Nothing Then
                Return Me.ViewState("ID_ACCION_FORMATIVA")
            Else
                Return -1
            End If
        End Get
        Set(value As Integer)
            Me.ViewState("ID_ACCION_FORMATIVA") = value
        End Set
    End Property

    Public Function CargarDatos() As Integer
        Try
            Dim c As SQLMembershipProvider.BL.cmembershipProvider
            Dim listaRoles As New List(Of String)
            Dim listaCodigoEstados As New List(Of String)
            Dim sbRoles As New StringBuilder
            Dim sbCodigoEstados As New StringBuilder

            c = CType(System.Web.Security.Membership.Provider, SQLMembershipProvider.BL.cmembershipProvider)
            listaRoles = c.ObtenerRoles(Me.ObtenerUsuario)
            listaCodigoEstados.Add(Me.ucCriteriosAccionFormativa1.idEstadoAccion)

            For i As Integer = 0 To listaRoles.Count - 1
                sbRoles.Append(listaRoles(i))
                If i < listaRoles.Count - 1 Then sbRoles.Append(";")
            Next

            If Me.ucListaACCION_FORMATIVA1.CargarDatosPorCriteriosRoles( _
                    Me.ucCriteriosAccionFormativa1.idProveedor, _
                    Me.ucCriteriosAccionFormativa1.idSitioCapacitacion, _
                    Me.ucCriteriosAccionFormativa1.idAreaFormacion, _
                    Me.ucCriteriosAccionFormativa1.nombreAccionFormativa, _
                    Me.ucCriteriosAccionFormativa1.codigoGrupo, _
                    Me.ucCriteriosAccionFormativa1.idEjercicio, _
                    sbRoles.ToString, sbCodigoEstados.ToString, _
                    Me.ucCriteriosAccionFormativa1.tdr) <> 1 Then
                Return -1
            End If
            Return 1

        Catch ex As Exception
            Return -1
        End Try
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Buscar" Then
            If Me.ucCriteriosAccionFormativa1.tdr = "" AndAlso _
                Me.ucCriteriosAccionFormativa1.codigoGrupo = "" Then
                Me.AsignarMensaje("Ingrese un contrato o un codigo grupo", False, True)
                Exit Sub
            End If

            Me.CargarDatos()
        End If
    End Sub

    Protected Sub ucListaACCION_FORMATIVA1_IngresoVisitasSegui(ID_ACCION_FORMATIVA As Decimal) Handles ucListaACCION_FORMATIVA1.IngresoVisitasSegui
        Me.ID_ACCION_FORMATIVA = ID_ACCION_FORMATIVA
        popupNoVisitasSeguimiento.ShowOnPageLoad = True
    End Sub

    Protected Sub btnAceptarPopup_Click(sender As Object, e As EventArgs) Handles btnAceptarPopup.Click
        If Me.ID_ACCION_FORMATIVA > -1 Then
            If speNO_VISITASpopup.Value Is Nothing OrElse speNO_VISITASpopup.Value <= 0 Then
                AsignarMensaje("Ingrese el No. de Visitas", False, True)
                Return
            End If
            Dim lAccionVisita As New ACCION_VISITAS_SEGUI
            Dim bAccionVisita As New cACCION_VISITAS_SEGUI
            Dim lstAccionVisita As listaACCION_VISITAS_SEGUI = (New cACCION_VISITAS_SEGUI).ObtenerListaPorACCION_FORMATIVA(Me.ID_ACCION_FORMATIVA)

            If lstAccionVisita IsNot Nothing AndAlso lstAccionVisita.Count > 0 Then
                lAccionVisita = lstAccionVisita(0)
            Else
                lAccionVisita = New ACCION_VISITAS_SEGUI
                lAccionVisita.ID_ACCION_VISITA = 0
                lAccionVisita.ID_ACCION_FORMATIVA = Me.ID_ACCION_FORMATIVA
                lAccionVisita.USUARIO_CREA = Me.ObtenerUsuario
                lAccionVisita.FECHA_CREA = Now
            End If
            lAccionVisita.NO_VISITAS = Me.speNO_VISITASpopup.Value
            lAccionVisita.USUARIO_ACT = Me.ObtenerUsuario
            lAccionVisita.FECHA_ACT = Now

            bAccionVisita.ActualizarACCION_VISITAS_SEGUI(lAccionVisita)
            popupNoVisitasSeguimiento.ShowOnPageLoad = False

            Me.ucListaACCION_FORMATIVA1.DataBind()
        End If
    End Sub
End Class
