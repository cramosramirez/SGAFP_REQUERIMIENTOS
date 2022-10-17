Imports SGAFP.BL
Imports SGAFP.EL
Imports SGAFP.EL.Utilerias
Imports System.Collections.Generic
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantPARTICIPANTE_EXONERADO_DOC
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla PARTICIPANTE_EXONERADO_DOC
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.8.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/11/2012	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantPARTICIPANTE_EXONERADO_DOC
    Inherits ucBase

#Region "Inicializaciones Mantenimiento"
    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PARTICIPANTE_EXONERADO_DOC
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = Me.EstaEnRol(RolDeUsuario.JefeHTP) OrElse Me.EstaEnRol(RolDeUsuario.Administrador)
        'Me.ucBarraNavegacion1.PermitirAgregar = (Me.EstaEnRol(RolDeUsuario.JefeHTP) OrElse Me.EstaEnRol(RolDeUsuario.Proveedor) OrElse Me.EstaEnRol(RolDeUsuario.CentroCapacitador) OrElse Me.EstaEnRol(RolDeUsuario.Administrador))
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)
        Me.ucBarraNavegacion1.LimpiarOpciones()
        Me.ucBarraNavegacion1.CrearOpcion("Buscar", "Buscar", False, "~/imagenes/ButtonSearch.png")
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.ucCriteriosParticipanteExoneradoDoc1.Visible = True
        Me.ucListaPARTICIPANTE_EXONERADO_DOC1.Visible = True
        Me.ucVistaDetallePARTICIPANTE_EXONERADO_DOC1.Visible = False
        Me.ucListaPARTICIPANTE_EXONERADO_DOC2.VerMensajeGrid = False
        Me.ucListaPARTICIPANTE_EXONERADO_DOC2.Visible = False
        Me.ucListaPARTICIPANTE1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla PARTICIPANTE_EXONERADO_DOC
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.LimpiarOpciones()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = True
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucCriteriosParticipanteExoneradoDoc1.Visible = False
        Me.ucListaPARTICIPANTE_EXONERADO_DOC1.Visible = False
        Me.ucVistaDetallePARTICIPANTE_EXONERADO_DOC1.Visible = True
    End Sub

    Private Enum TipoValidacion
        Ninguna = 0
        CoincidenciaExacta = 1
        SemejanzaParticipanteExonerado = 2
        SemejanzaParticipante = 3
    End Enum

    Private Property ValidacionEjecutada() As TipoValidacion
        Get
            If Me.ViewState("ValidacionEjecutada") IsNot Nothing Then Return CInt(Me.ViewState("ValidacionEjecutada")) Else Return TipoValidacion.Ninguna
        End Get
        Set(ByVal value As TipoValidacion)
            Me.ViewState("ValidacionEjecutada") = value
        End Set
    End Property
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla PARTICIPANTE_EXONERADO_DOC
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/11/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try 
            Return Me.CargarPARTICIPANTE_EXONERADO_DOC()
        Catch ex As Exception 
            Return -1 
        End Try 
        Return 1
    End Function

    Private Function CargarPARTICIPANTE_EXONERADO_DOC() As Integer
        Return 1
    End Function

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Introducir aquí el código de usuario para inicializar la página
        If Not IsPostBack Then
            Me.InicializarLista()
        End If
    End Sub

    Private Sub UcBarraNavegacion1_Agregar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Agregar
        Me.InicializarDetalle()
        Me.UcVistaDetallePARTICIPANTE_EXONERADO_DOC1.LimpiarControles()
        Me.ucVistaDetallePARTICIPANTE_EXONERADO_DOC1.ID_PARTICIPANTE_EXONERADO = 0
    End Sub

    Private Sub ucBarraNavegacion1_Cancelar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Cancelar
        Me.InicializarLista()
    End Sub

    Private Sub ucBarraNavegacion1_Guardar(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucBarraNavegacion1.Guardar
        If ucVistaDetallePARTICIPANTE_EXONERADO_DOC1.ID_PARTICIPANTE_EXONERADO = 0 Then
            Dim lEntidadPartiExo As New PARTICIPANTE_EXONERADO_DOC
            Dim lEntidadParti As New PARTICIPANTE
            Dim listaCoincidencias As listaPARTICIPANTE_EXONERADO_DOC
            Dim listaCoincidenciasParticipante As listaPARTICIPANTE
            Dim duplicadoPorFonetico As Integer = 0

            'Validar que no exista coincidencia en nombres, apellidos y fecha de nacimiento
            listaCoincidencias = (New cPARTICIPANTE_EXONERADO_DOC).ObtenerListaPorCriterios(-1, -1, -1, _
                                                        ucVistaDetallePARTICIPANTE_EXONERADO_DOC1.FECHA_NACIMIENTO, _
                                                        ucVistaDetallePARTICIPANTE_EXONERADO_DOC1.NOMBRES, _
                                                        ucVistaDetallePARTICIPANTE_EXONERADO_DOC1.APELLIDOS)

            If listaCoincidencias IsNot Nothing AndAlso listaCoincidencias.Count > 0 AndAlso ValidacionEjecutada < TipoValidacion.CoincidenciaExacta Then
                ValidacionEjecutada = TipoValidacion.CoincidenciaExacta
                If listaCoincidencias(0).ID_PARTICIPANTE > 0 Then
                    AsignarMensaje("Ya existe un participante con los mismos nombres, apellidos y fecha de nacimiento. Intente inscribirlo en el curso mediante buscarlo por nombres y apellidos", True, True)
                Else
                    AsignarMensaje("Ya existe un participante con documentos exonerados con los mismos nombres, apellidos y fecha de nacimiento", True, True)
                End If
                Return
            End If

            'Validar que no existan coincidencias foneticas en Participantes Exonerados de Documentos
            lEntidadPartiExo.NOMBRES = ucVistaDetallePARTICIPANTE_EXONERADO_DOC1.NOMBRES
            lEntidadPartiExo.APELLIDOS = ucVistaDetallePARTICIPANTE_EXONERADO_DOC1.APELLIDOS
            lEntidadPartiExo.FECHA_NACIMIENTO = ucVistaDetallePARTICIPANTE_EXONERADO_DOC1.FECHA_NACIMIENTO
            listaCoincidencias = (New cPARTICIPANTE_EXONERADO_DOC).ObtenerListaParticipantesSemejantes(lEntidadPartiExo, duplicadoPorFonetico)
            If duplicadoPorFonetico > 0 AndAlso ValidacionEjecutada < TipoValidacion.SemejanzaParticipanteExonerado Then
                duplicadoPorFonetico = 0
                ucListaPARTICIPANTE_EXONERADO_DOC2.CargarDatosPorParticipantesSemejantes(lEntidadPartiExo, duplicadoPorFonetico)
                ucListaPARTICIPANTE_EXONERADO_DOC2.VerMensajeGrid = True
                ucListaPARTICIPANTE_EXONERADO_DOC2.Visible = True
                ValidacionEjecutada = TipoValidacion.SemejanzaParticipanteExonerado
                Return
            End If

            'Mostrar coincidencias foneticas en Participantes
            lEntidadParti.NOMBRES = ucVistaDetallePARTICIPANTE_EXONERADO_DOC1.NOMBRES
            lEntidadParti.APELLIDOS = ucVistaDetallePARTICIPANTE_EXONERADO_DOC1.APELLIDOS
            lEntidadParti.FECHA_NACIMIENTO = ucVistaDetallePARTICIPANTE_EXONERADO_DOC1.FECHA_NACIMIENTO
            duplicadoPorFonetico = 0
            listaCoincidenciasParticipante = (New cPARTICIPANTE).ObtenerListaParticipantesSemejantes(lEntidadParti, duplicadoPorFonetico)
            If duplicadoPorFonetico > 0 AndAlso ValidacionEjecutada < TipoValidacion.SemejanzaParticipante Then
                duplicadoPorFonetico = 0
                ucListaPARTICIPANTE1.CargarDatosPorParticipantesSemejantes(lEntidadParti, duplicadoPorFonetico)
                ucListaPARTICIPANTE1.VerMensajeGrid = True
                ucListaPARTICIPANTE1.Visible = True
                ValidacionEjecutada = TipoValidacion.SemejanzaParticipante
                Return
            End If
        End If

        Dim sError As String
        sError = Me.ucVistaDetallePARTICIPANTE_EXONERADO_DOC1.Actualizar()
        ValidacionEjecutada = TipoValidacion.Ninguna
        If sError <> "" Then
            Return
        End If
        Me.InicializarLista()
        Me.ucListaPARTICIPANTE_EXONERADO_DOC1.DataBind()
    End Sub

    Protected Sub ucListaPARTICIPANTE_EXONERADO_DOC1_Editando(ByVal ID_PARTICIPANTE_EXONERADO As Decimal) Handles ucListaPARTICIPANTE_EXONERADO_DOC1.Editando
        Me.InicializarDetalle()
        Me.ucVistaDetallePARTICIPANTE_EXONERADO_DOC1.ID_PARTICIPANTE_EXONERADO = ID_PARTICIPANTE_EXONERADO
    End Sub

    Private Sub ucVistaDetallePARTICIPANTE_EXONERADO_DOC1_ErrorEvent(ByVal errorMessage As String) Handles UcVistaDetallePARTICIPANTE_EXONERADO_DOC1.ErrorEvent
        'Mostrar mensaje de error contenido en errorMessage
        Me.AsignarMensaje(errorMessage, True, True)
    End Sub

    Protected Sub ucBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles ucBarraNavegacion1.OpcionSeleccionada
        If CommandName = "Buscar" Then
            If Me.ucListaPARTICIPANTE_EXONERADO_DOC1.CargarDatosPorCriterios(Me.ucCriteriosParticipanteExoneradoDoc1.idProveedor, _
                                                                            Me.ucCriteriosParticipanteExoneradoDoc1.idSitioCapacitacion, _
                                                                            Me.ucCriteriosParticipanteExoneradoDoc1.estado, Nothing, "", "") <> 1 Then
                Me.AsignarMensaje("Error al Recuperar Lista", True, True)
            End If
        End If
    End Sub

    Protected Sub ucVistaDetallePARTICIPANTE_EXONERADO_DOC1_Modificando(ByVal sender As Object, ByVal e As System.EventArgs) Handles ucVistaDetallePARTICIPANTE_EXONERADO_DOC1.Modificando
        ValidacionEjecutada = TipoValidacion.Ninguna
    End Sub
End Class
