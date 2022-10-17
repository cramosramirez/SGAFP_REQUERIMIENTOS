
Partial Class controles_ucDesembolsoPATI
    Inherits ucBase

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Inicializa la Lista de Datos y Configura las Acciones para el 
    ''' Mantenimiento de la tabla SOLICITUD_INSCRIPCION_AF
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[cramos]	27/04/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub InicializarLista()
        Me.ucBarraNavegacion1.LimpiarOpciones()
        Me.ucBarraNavegacion1.Navegacion = False
        Me.ucBarraNavegacion1.PermitirAgregar = False
        Me.ucBarraNavegacion1.PermitirEditar = False
        Me.ucBarraNavegacion1.PermitirGuardar = False
        Me.ucBarraNavegacion1.HabilitarEdicion(False)

        Me.UcBarraNavegacion1.CrearOpcion("BuscarDesembolsos", "Buscar", False, "~/imagenes/ButtonSearch.png")
        Me.UcBarraNavegacion1.CrearOpcion("Cancelar", "Cancelar", False, "~/imagenes/cancelar.gif")
        Me.UcBarraNavegacion1.CrearOpcion("AgregarLiquidaciones", "Agregar Liquidaciones", False, "~/imagenes/agregar.gif", "onclick", "e.processOnServer=false;AgregarLiquidaciones();")
        Me.UcBarraNavegacion1.CrearOpcion("GuardarAplicacion", "Guardar", False, "~/imagenes/ButtonSave.png")
        Me.UcBarraNavegacion1.CargarOpciones()
        Me.UcBarraNavegacion1.VerOpcion("Cancelar", False)
        Me.UcBarraNavegacion1.VerOpcion("AgregarLiquidaciones", False)
        Me.UcBarraNavegacion1.VerOpcion("GuardarAplicacion", False)

        Me.ucCriteriosMunicipiosPATI1.Visible = True
        Me.ucListaDESEMBOLSO1.Visible = True
        Me.ucDesembolsoPATI_Aplicacion1.Visible = False
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            InicializarLista()
        End If
    End Sub

    Protected Sub cMantDESEMBOLSO_Callback(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxClasses.CallbackEventArgsBase) Handles cMantDESEMBOLSO.Callback
        Dim p() As String = e.Parameter.Split(";")
        cMantDESEMBOLSO.JSProperties.Clear()
        cMantDESEMBOLSO.JSProperties.Add("cpResultCallback", "")

        If p(0) = "CargarDesembolsos" Then
            Me.ucListaDESEMBOLSO1.CargarDatosPorFUENTE_FINANCIAMIENTO_NO_CONVOCATORIACallback("BuscarDatos", New String() {"CargarDatosPorFuenteConvocatoria", p(1), p(2)})
        End If
    End Sub

    Protected Sub ucListaDESEMBOLSO1_Seleccionado(ByVal ID_DESEMBOLSO As Decimal) Handles ucListaDESEMBOLSO1.Seleccionado
        Me.ucCriteriosMunicipiosPATI1.Visible = False
        Me.ucListaDESEMBOLSO1.Visible = False

        Me.ucDesembolsoPATI_Aplicacion1.Visible = True
        Me.ucDesembolsoPATI_Aplicacion1.ID_DESEMBOLSO = ID_DESEMBOLSO
        Me.ucDesembolsoPATI_Aplicacion1.CargarDatosPorIdDesembolso(ID_DESEMBOLSO)
        Me.UcBarraNavegacion1.VerOpcion("AgregarLiquidaciones", True)
        Me.UcBarraNavegacion1.VerOpcion("GuardarAplicacion", True)
        Me.UcBarraNavegacion1.VerOpcion("BuscarDesembolsos", False)
        Me.UcBarraNavegacion1.VerOpcion("Cancelar", True)
    End Sub

    Protected Sub UcBarraNavegacion1_OpcionSeleccionada(ByVal CommandName As String) Handles UcBarraNavegacion1.OpcionSeleccionada
        If CommandName = "BuscarDesembolsos" Then
            Me.ucListaDESEMBOLSO1.CargarDatosPorFUENTE_FINANCIAMIENTO_NO_CONVOCATORIA(Me.ucCriteriosMunicipiosPATI1.IdFuente, Me.ucCriteriosMunicipiosPATI1.NoConvocatoria)
        End If
        If CommandName = "GuardarAplicacion" Then
            Dim lRet As String
            lRet = Me.ucDesembolsoPATI_Aplicacion1.Actualizar()
            If lRet = String.Empty Then
                Me.ucListaDESEMBOLSO1.DataBind()
                Me.InicializarLista()
            End If
        End If
        If CommandName = "Cancelar" Then
            Me.ucListaDESEMBOLSO1.DataBind()
            Me.InicializarLista()
        End If
    End Sub
End Class
