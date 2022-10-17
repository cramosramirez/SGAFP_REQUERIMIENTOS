Imports SGAFP.BL
Imports SGAFP.EL
Imports System.Collections.Generic

''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantPARTICIPANTE
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla PARTICIPANTE
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.5.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	02/02/2010	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantPARTICIPANTE
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PARTICIPANTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' 	[ecarias]	17/04/2010	Se agrego Busqueda de Participantes
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        Me.ucBarraNavegacion1.VerOpcion("BuscarParticipantes", True)
        Me.ucCriteriosParticipante1.Visible = True
        Me.ucListaPARTICIPANTE1.Visible = True
        Me.ucListaPARTICIPANTE1.PermitirEliminar = Me.EstaEnRol(RolUsuario.Administrador)
        Me.ucListaPARTICIPANTE1.PermitirEditarInline = Me.EstaEnRol(RolDeUsuario.Administrador) OrElse Me.EstaEnRol(RolDeUsuario.CoordinadorGFI) OrElse Me.EstaEnRol(RolDeUsuario.GerenteGFI)
        Me.ucVistaDetallePARTICIPANTE1.Visible = False
        Me.CargarDatos(-100)
    End Sub

    Public Property EsConsultaParticipante As Boolean 
        Get
            If Me.ViewState("EsConsultaParticipante") IsNot Nothing Then
                Return Me.ViewState("EsConsultaParticipante")
            Else
                Return False
            End If
        End Get
        Set(value As Boolean)
            Me.ViewState("EsConsultaParticipante") = value
        End Set
    End Property

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PARTICIPANTE
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	02/02/2010	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("BuscarParticipantes", False)
        Me.ucCriteriosParticipante1.Visible = False
        Me.ucListaPARTICIPANTE1.Visible = False
        Me.ucVistaDetallePARTICIPANTE1.Visible = True
    End Sub
#End Region


    Private Function CargarPARTICIPANTE() As Integer
        If Me.ucListaPARTICIPANTE1.CargarDatos() <> 1 Then Return -1
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Inicializar()
        Else
            If EsConsultaParticipante Then
                Me.CargarDatos()
            End If
        End If
    End Sub

    Private Sub Inicializar()
        Me.ucBarraNavegacion1.PermitirNavegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, "~/imagenes/Cancelar.gif", "", "")
        Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", False, "~/imagenes/ButtonSave.png", "", "")
        Me.ucBarraNavegacion1.CrearOpcion("BuscarParticipantes", "Buscar", False, "~/imagenes/ButtonSearch.png", "", "")
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.InicializarLista()
    End Sub

    Protected Sub ucListaPARTICIPANTE1_Editando(ByVal ID_PARTICIPANTE As Decimal) Handles ucListaPARTICIPANTE1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetallePARTICIPANTE1.ID_PARTICIPANTE = ID_PARTICIPANTE
    End Sub

    Private Sub ucVistaDetallePARTICIPANTE1_ErrorEvent(ByVal errorMessage As String) Handles ucVistaDetallePARTICIPANTE1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub UcBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "BuscarParticipantes" Then
            Me.CargarDatos()
        End If
        If CommandName = "Guardar" Then
            Dim sError As String
            sError = Me.ucVistaDetallePARTICIPANTE1.Actualizar()
            If sError <> "" Then
                Me.InicializarDetalle()
                Return
            End If
            Me.InicializarLista()
            Me.CargarDatos()
        End If
        If CommandName = "Cancelar" Then
            Me.InicializarLista()
            Me.CargarDatos()
        End If
    End Sub

    Private Sub CargarDatos(Optional ID_PARTICIPANTE As Int32 = -1)
        Dim sNombres As String = ""
        Dim sApellidos As String = ""
        Dim sFechaNacimiento As String = ""
        Dim idParticipante As Int32 = ID_PARTICIPANTE
        Dim sDui As String = ""
        Dim sNit As String = ""

        If Me.ucCriteriosParticipante1.nombresParticipante <> "" Then sNombres = Me.ucCriteriosParticipante1.nombresParticipante.ToUpper
        If Me.ucCriteriosParticipante1.apellidosParticipante <> "" Then sApellidos = Me.ucCriteriosParticipante1.apellidosParticipante.ToUpper
        If Me.ucCriteriosParticipante1.fechaNacimientoParticipante <> Nothing Then sFechaNacimiento = Me.ucCriteriosParticipante1.fechaNacimientoParticipante.ToString("dd/MM/yyyy")
        If Me.ucCriteriosParticipante1.idParticipante <> -1 Then idParticipante = Me.ucCriteriosParticipante1.idParticipante
        If Me.ucCriteriosParticipante1.duiParticipante <> "" Then sDui = Me.ucCriteriosParticipante1.duiParticipante
        If Me.ucCriteriosParticipante1.nitParticipante <> "" Then sNit = Me.ucCriteriosParticipante1.nitParticipante

        If sNombres = "" AndAlso sApellidos = "" AndAlso sFechaNacimiento = "" AndAlso idParticipante = -1 AndAlso sDui = "" AndAlso sNit = "" Then
            Me.AsignarMensaje("* Ingrese algun criterio de busqueda", True, True)
            Return
        End If
        Me.ucListaPARTICIPANTE1.CargarDatosPorCriterios(sNombres, sApellidos, sFechaNacimiento, idParticipante, sDui, sNit)
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
        If criterios.Count > 0 Then
            Me.ucListaPARTICIPANTE1.CargarDatosPorBusqueda(criterios.ToArray())
        Else
            criterios.Add(New Criteria("ID_PARTICIPANTE", "=", "-100", "AND"))
            Me.ucListaPARTICIPANTE1.CargarDatosPorBusqueda(criterios.ToArray())
        End If
    End Sub

    Protected Sub cMantPARTICIPANTES_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cMantPARTICIPANTES.Callback
        Dim parametros() As String = e.Parameter.Split(";"c)
        Dim sResult As String = ""

        cMantPARTICIPANTES.JSProperties("cpCodigoError") = ""
        cMantPARTICIPANTES.JSProperties("cpResultCallback") = ""

        Select Case parametros(0)

            Case "BuscarPartipantes"
                Dim p(7) As String

                p(0) = parametros(1)
                p(1) = parametros(2)
                p(2) = parametros(3)
                p(3) = parametros(4)
                p(4) = parametros(5)
                p(5) = parametros(6)
                p(6) = parametros(7)
                Me.ucListaPARTICIPANTE1.CargarDatosPorCallback("BuscarDatos", p)
                cMantPARTICIPANTES.JSProperties("cpResultCallback") = "MostrarBusquedaParticipantes"
        End Select
    End Sub
End Class
