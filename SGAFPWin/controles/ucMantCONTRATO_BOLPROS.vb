Imports SGAFP.EL
Public Class ucMantCONTRATO_BOLPROS

    Private mListaCONTRATO_BOLPROS As listaCONTRATO_BOLPROS

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaCONTRATO_BOLPROS1.EsConsulta = value
            Me.UcDetalleCONTRATO_BOLPROS1.EsConsulta = value
        End Set
    End Property
   

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla CONTRATO_BOLPROS
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	12/04/2013	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try
            Me.UcListaCONTRATO_BOLPROS1.CargarDatos()
        Catch ex As Exception
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try
    End Sub

    Private Sub UcListaCONTRATO_BOLPROS1_CambioRegistro() Handles UcListaCONTRATO_BOLPROS1.CambioRegistro
        If Not Me.UcListaCONTRATO_BOLPROS1.Current Is Nothing Then
            Me.ToolStripButtonEditar.Visible = True
        End If
    End Sub

    Sub Inicializar()
        Me.UcListaCONTRATO_BOLPROS1.EsConsulta = True
        Me.SplitContainer2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.ConfigurarMenu("Iniciar")
    End Sub

    Private Sub ucMantCONTRATO_BOLPROS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inicializar()
    End Sub

    Private Sub ConfigurarMenu(ByVal opcion As String)
        Select Case opcion
            Case "Agregar", "Editar"
                Me.ToolStripButtonBuscar.Visible = False
                Me.ToolStripButtonAgregar.Visible = False
                Me.ToolStripButtonEditar.Visible = False
                Me.ToolStripButtonGuardar.Visible = True
                Me.ToolStripButtonCancelar.Visible = True
                Me.ToolStripButtonEliminar.Visible = False
                Me.ToolStripButtonVerCursos.Visible = False
            Case "Guardar", "Cancelar"
                Me.ToolStripButtonBuscar.Visible = True
                Me.ToolStripButtonAgregar.Visible = True
                Me.ToolStripButtonGuardar.Visible = False
                Me.ToolStripButtonCancelar.Visible = False
                Me.ToolStripButtonEliminar.Visible = True
                If Not Me.UcListaCONTRATO_BOLPROS1.Current Is Nothing Then
                    Me.ToolStripButtonEditar.Visible = True
                    Me.ToolStripButtonVerCursos.Visible = True
                End If
            Case "Eliminar"
                If Not Me.UcListaCONTRATO_BOLPROS1.Current Is Nothing Then
                    Me.ToolStripButtonEditar.Visible = True
                    Me.ToolStripButtonVerCursos.Visible = True
                End If
            Case Else
                Me.ToolStripButtonBuscar.Visible = True
                Me.ToolStripButtonAgregar.Visible = True
                Me.ToolStripButtonGuardar.Visible = False
                Me.ToolStripButtonCancelar.Visible = False
                Me.ToolStripButtonEliminar.Visible = True
        End Select
    End Sub

    Private Sub ToolStripMantto_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStripMantto.ItemClicked
        Select Case e.ClickedItem.Text
            Case "Agregar"
                Me.UcDetalleCONTRATO_BOLPROS1.CONTRATO_BOLPROS = New CONTRATO_BOLPROS
                Me.SplitContainer2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            Case "Editar"
                If Me.UcListaCONTRATO_BOLPROS1.Current IsNot Nothing Then
                    Me.UcDetalleCONTRATO_BOLPROS1.CONTRATO_BOLPROS = (New cCONTRATO_BOLPROS).ObtenerCONTRATO_BOLPROS(Me.UcListaCONTRATO_BOLPROS1.Current.ID_CONTRATO)
                    Me.SplitContainer2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
                Else
                    AsignarMensaje("Seleccione un registro", True)
                    Return
                End If
            Case "Buscar"
                Me.UcListaCONTRATO_BOLPROS1.CargarDatosPorCriterios()
            Case "Guardar"
                If Me.UcDetalleCONTRATO_BOLPROS1.Actualizar() <> 1 Then Exit Sub
                Me.UcListaCONTRATO_BOLPROS1.CargarDatosPorCriterios()
                Me.SplitContainer2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            Case "Cancelar"
                Me.SplitContainer2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            Case "Eliminar"
                Me.UcListaCONTRATO_BOLPROS1.Eliminar()
                Me.UcListaCONTRATO_BOLPROS1.CargarDatosPorCriterios()
            Case "Ver Cursos"
                If Me.UcListaCONTRATO_BOLPROS1.Current IsNot Nothing Then
                    Dim ChildForm As frmMantACCION_CONTRATADA = frmMain.AbrirFormulario(GetType(frmMantACCION_CONTRATADA), True, "Accion Contratada ACCION_CONTRATADA")
                    'ChildForm.CargarAccionesPorContrato(Me.UcListaCONTRATO_BOLPROS1.Current.ID_PROVEEDOR_AF, _
                    '                                        Me.UcListaCONTRATO_BOLPROS1.Current.ID_PROGRAMA_FORMACION, _
                    '                                        Me.UcListaCONTRATO_BOLPROS1.Current.NUM_CONTRATO)
                    ChildForm.CargarAccionesPorContrato(Me.UcListaCONTRATO_BOLPROS1.Current.ID_CONTRATO)
                End If
        End Select
        ConfigurarMenu(e.ClickedItem.Text)
    End Sub
End Class

