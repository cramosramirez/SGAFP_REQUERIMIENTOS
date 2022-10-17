Imports SGAFP.EL
Public Class ucMantSOLICITUD_CAPACITACION

    Private mListaSOLICITUD_CAPACITACION As listaSOLICITUD_CAPACITACION

    Private _EsConsulta As Boolean = False
    <DefaultValue(False)> _
    Public Property EsConsulta() As Boolean
        Get
            Return Me._EsConsulta
        End Get
        Set(ByVal value As Boolean)
            Me._EsConsulta = value
            Me.UcListaSOLICITUD_CAPACITACION1.EsConsulta = value
            Me.UcDetalleSOLICITUD_CAPACITACION1.EsConsulta = value
        End Set
    End Property

    'Public Overrides ReadOnly Property EnEdicion() As Boolean
    '    Get
    '        If Me.UcListaSOLICITUD_CAPACITACION1.Current Is Nothing Then Return False
    '        Return Me.UcListaSOLICITUD_CAPACITACION1.Current.IsDirty
    '    End Get
    'End Property

    'Private Sub CargarSOLICITUD_CAPACITACION()
    '    Me.UcListaSOLICITUD_CAPACITACION1.CargarDatos()
    '    If Me.UcListaSOLICITUD_CAPACITACION1.Current Is Nothing Then
    '        Me.UcDetalleSOLICITUD_CAPACITACION1.DataSource.DataSource = (New SOLICITUD_CAPACITACION)
    '    Else
    '        Me.UcDetalleSOLICITUD_CAPACITACION1.DataSource.DataSource = Me.UcListaSOLICITUD_CAPACITACION1.Current
    '    End If
    'End Sub

    ''' -----------------------------------------------------------------------------
    ''' <summary>
    ''' Función que Carga la información de los registros de la tabla SOLICITUD_CAPACITACION
    ''' </summary>
    ''' <remarks>
    ''' </remarks>
    ''' <history>
    ''' 	[GenApp]	05/10/2012	Created
    ''' </history>
    ''' -----------------------------------------------------------------------------
    Public Sub CargarDatos()
        Try 
            Me.UcListaSOLICITUD_CAPACITACION1.CargarDatos()
        Catch ex As Exception 
            Me.AsignarMensaje("No se pudo recuperar los datos")
        End Try 
    End Sub

    'Public Overrides Function Guardar() As Integer
    '    Me.UcDetalleSOLICITUD_CAPACITACION1.DataSource.EndEdit()
    '    Dim liRet As Integer = Me.UcListaSOLICITUD_CAPACITACION1.Guardar()
    '    If liRet <> 1 Then
    '        Me.sError = Me.UcListaSOLICITUD_CAPACITACION1.sError
    '    Else
    '        Me.sError = ""
    '    End If
    '    Return liRet
    'End Function

    'Private Sub UcListaSOLICITUD_CAPACITACION1_CambioRegistro() Handles UcListaSOLICITUD_CAPACITACION1.CambioRegistro
    '    If Not Me.UcListaSOLICITUD_CAPACITACION1.Current Is Nothing Then
    '        Me.UcDetalleSOLICITUD_CAPACITACION1.EsConsulta = UcListaSOLICITUD_CAPACITACION1.TieneAsociadaTDR
    '        Me.UcDetalleSOLICITUD_CAPACITACION1.DataSource.DataSource = Me.UcListaSOLICITUD_CAPACITACION1.Current
    '    Else
    '        Me.UcDetalleSOLICITUD_CAPACITACION1.DataSource.DataSource = (New SOLICITUD_CAPACITACION)
    '    End If
    'End Sub

    Sub Inicializar()
        Me.UcListaSOLICITUD_CAPACITACION1.EsConsulta = True
        Me.SplitContainerControl2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
        Me.ConfigurarMenu("Iniciar")
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
                Me.ToolStripButtonAgregarGrupo.Visible = False
                Me.ToolStripButtonEliminarGrupo.Visible = False
            Case "Guardar", "Cancelar"
                Me.ToolStripButtonBuscar.Visible = True
                Me.ToolStripButtonAgregar.Visible = True
                Me.ToolStripButtonGuardar.Visible = False
                Me.ToolStripButtonCancelar.Visible = False
                Me.ToolStripButtonEliminar.Visible = True
                If Not Me.UcListaSOLICITUD_CAPACITACION1.Current Is Nothing Then
                    Me.ToolStripButtonEditar.Visible = True
                    Me.ToolStripButtonAgregarGrupo.Visible = True
                    Me.ToolStripButtonEliminarGrupo.Visible = True
                End If
            Case "Eliminar"
                If Not Me.UcListaSOLICITUD_CAPACITACION1.Current Is Nothing Then
                    Me.ToolStripButtonEditar.Visible = True
                End If
            Case Else
                Me.ToolStripButtonBuscar.Visible = True
                Me.ToolStripButtonAgregar.Visible = True
                Me.ToolStripButtonGuardar.Visible = False
                Me.ToolStripButtonCancelar.Visible = False
                Me.ToolStripButtonEliminar.Visible = True
                Me.ToolStripButtonAgregarGrupo.Visible = True
                Me.ToolStripButtonEliminarGrupo.Visible = True
        End Select
    End Sub

    Private Sub ucMantSOLICITUD_CAPACITACION_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Inicializar()
    End Sub

    Private Sub ToolStripMantto_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStripMantto.ItemClicked
        Select Case e.ClickedItem.Text
            Case "Agregar"
                Me.UcDetalleSOLICITUD_CAPACITACION1.SOLICITUD_CAPACITACION = New SOLICITUD_CAPACITACION
                Me.SplitContainerControl2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
            Case "Editar"
                If Me.UcListaSOLICITUD_CAPACITACION1.Current IsNot Nothing Then
                    Me.UcDetalleSOLICITUD_CAPACITACION1.SOLICITUD_CAPACITACION = Me.UcListaSOLICITUD_CAPACITACION1.Current
                    Me.SplitContainerControl2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel2
                Else
                    AsignarMensaje("Seleccione un registro", True)
                    Return
                End If
            Case "Buscar"
                Me.UcListaSOLICITUD_CAPACITACION1.CargarDatosPorCriterios()
            Case "Guardar"
                Dim bFiltrarSolicitud As Boolean = (Me.UcDetalleSOLICITUD_CAPACITACION1.SOLICITUD_CAPACITACION.ID_SOLICITUD = 0)
                If Me.UcDetalleSOLICITUD_CAPACITACION1.Actualizar() <> 1 Then Exit Sub
                If bFiltrarSolicitud Then
                    Me.UcListaSOLICITUD_CAPACITACION1.CargarDatosPorIdSolicitud(Me.UcDetalleSOLICITUD_CAPACITACION1.SOLICITUD_CAPACITACION.ID_SOLICITUD)
                Else
                    Me.UcListaSOLICITUD_CAPACITACION1.CargarDatosPorCriterios()
                End If
                Me.SplitContainerControl2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            Case "Cancelar"
                Me.SplitContainerControl2.PanelVisibility = DevExpress.XtraEditors.SplitPanelVisibility.Panel1
            Case "Eliminar Solicitud"
                If Preguntar("¿Está seguro(a) de Eliminar la Solicitud?") = DialogResult.Yes Then
                    Me.UcListaSOLICITUD_CAPACITACION1.Eliminar()
                    Me.UcListaSOLICITUD_CAPACITACION1.CargarDatosPorCriterios()
                End If
            Case "Agregar Grupo"
                Me.UcListaSOLICITUD_CAPACITACION1.AgregarGrupo()
            Case "Eliminar Grupo"
                Me.UcListaSOLICITUD_CAPACITACION1.EliminarGrupo()
        End Select
        ConfigurarMenu(e.ClickedItem.Text)
    End Sub
End Class

