
Partial Class controles_ucInformePreseleccion
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
        'Me.ucBarraNavegacion1.CrearOpcion("Guardar", "Guardar", False, "~/imagenes/ButtonSave.png")
        'Me.ucBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, "~/imagenes/Undo-icon.png")
        Me.ucBarraNavegacion1.CargarOpciones()
        Me.ucBarraNavegacion1.VerOpcion("Buscar", True)
        'Me.ucBarraNavegacion1.VerOpcion("Guardar", False)
        'Me.ucBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.ucCriteriosAccionFormativa1.Visible = True
        Me.ucListaGRUPO_SELECCION1.Visible = True
    End Sub

    
#End Region

    Public Function CargarDatos() As Integer
        Try
            Dim idProveedor As Integer = -1
            Dim idProgramaForma As Integer = Enumeradores.ProgramasFormacion.EMPRESA_CENTRO
            Dim sContrato As String = ""

            idProveedor = Me.ucCriteriosAccionFormativa1.idProveedor
            sContrato = Me.ucCriteriosAccionFormativa1.NumContrato
            Me.ucListaGRUPO_SELECCION1.CargarDatosPorCriterios(idProveedor, idProgramaForma, sContrato, 1)

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
       
        End If
    End Sub


End Class
