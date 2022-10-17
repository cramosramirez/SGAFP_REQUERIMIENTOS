Imports SGAFP.BL
Imports SGAFP.EL
''' -----------------------------------------------------------------------------
''' Project	 : SGAFP
''' Class	 : ucMantACCION_CONTRATADA
''' 
''' -----------------------------------------------------------------------------
''' <summary>
''' Clase del Control de Usuario para el Mantenimiento de la tabla ACCION_CONTRATADA
''' </summary>
''' <remarks>
''' Generado con GenApp V1.9.7.0, Carías y Asociados, (info@cariasyasociados.com)
''' </remarks>
''' <history>
''' 	[GenApp]	19/03/2019	Created
''' </history>
''' -----------------------------------------------------------------------------
Partial Class controles_ucMantACCION_CONTRATADA
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
        Me.ucListaACCION_CONTRATADA1.Visible = True
        Me.ucVistaDetalleGRUPO_SELECCION1.Visible = False
    End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa el Detalle de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla ACCION_CONTRATADA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/03/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Private Sub InicializarDetalle()
        Me.ucBarraNavegacion1.VerOpcion("Buscar", False)
        Me.ucBarraNavegacion1.VerOpcion("Guardar", True)
        Me.ucBarraNavegacion1.VerOpcion("Cancelar", True)
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(True)
        Me.ucCriteriosAccionFormativa1.Visible = False
        Me.ucListaACCION_CONTRATADA1.Visible = False
        Me.ucVistaDetalleGRUPO_SELECCION1.Visible = True
    End Sub
#End Region

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla ACCION_CONTRATADA
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	19/03/2019	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Function CargarDatos() As Integer
        Try
            Dim idProveedor As Integer = -1
            Dim idProgramaForma As Integer = Enumeradores.ProgramasFormacion.EMPRESA_CENTRO
            Dim sContrato As String = ""

            idProveedor = Me.ucCriteriosAccionFormativa1.idProveedor
            sContrato = Me.ucCriteriosAccionFormativa1.NumContrato
            Me.ucListaACCION_CONTRATADA1.CargarDatosPorCriterios(idProveedor, idProgramaForma, sContrato)

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
            Me.CargarDatos()

        ElseIf CommandName = "Guardar" Then
            Dim sError As String = Me.ucVistaDetalleGRUPO_SELECCION1.Actualizar
            If sError <> "" Then
                Me.AsignarMensaje(sError, False, True)
                Return
            End If

            Me.ucVistaDetalleGRUPO_SELECCION1.ID_GRUPO_SELEC = 0
            Me.ucVistaDetalleGRUPO_SELECCION1.LimpiarControles()
            Me.InicializarLista()
            Me.ucListaACCION_CONTRATADA1.DataBind()

        ElseIf CommandName = "Cancelar" Then
            Me.ucVistaDetalleGRUPO_SELECCION1.ID_GRUPO_SELEC = 0
            Me.ucVistaDetalleGRUPO_SELECCION1.LimpiarControles()
            Me.InicializarLista()
        End If
    End Sub

    Protected Sub ucListaACCION_CONTRATADA1_HabilitarGrupo(ID_ACCION_CONTRATADA As Decimal) Handles ucListaACCION_CONTRATADA1.HabilitarGrupo
        Dim lAccion As ACCION_CONTRATADA = (New cACCION_CONTRATADA).ObtenerACCION_CONTRATADA(ID_ACCION_CONTRATADA)
        Dim listaG As listaGRUPO_SELECCION = (New cGRUPO_SELECCION).ObtenerListaPorACCION_CONTRATADA(ID_ACCION_CONTRATADA)

        If listaG Is Nothing OrElse (listaG IsNot Nothing AndAlso (listaG.Count + 1) > lAccion.CANT_CURSOS) Then
            Me.AsignarMensaje("Todos los grupos han sido habilitados", False, True)
            Return
        End If
        Me.ucVistaDetalleGRUPO_SELECCION1.ID_ACCION_CONTRATADA = ID_ACCION_CONTRATADA
        Me.ucVistaDetalleGRUPO_SELECCION1.ID_GRUPO_SELEC = 0
        InicializarDetalle()
    End Sub
End Class
