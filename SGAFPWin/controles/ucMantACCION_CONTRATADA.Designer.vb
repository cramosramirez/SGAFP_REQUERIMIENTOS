Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantACCION_CONTRATADA
    Inherits SGAFP.ucBaseMant

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMantACCION_CONTRATADA))
        Me.SplitContainer2 = New DevExpress.XtraEditors.SplitContainerControl
        Me.UcListaACCION_CONTRATADA1 = New SGAFP.ucListaACCION_CONTRATADA
        Me.UcDetalleACCION_CONTRATADA1 = New SGAFP.ucDetalleACCION_CONTRATADA
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.ToolStripMantto = New System.Windows.Forms.ToolStrip
        Me.ToolStripButtonBuscar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonAgregar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonEditar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonCopiar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonAsociarGrupos = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonDesasociarGrupos = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButtonHabilitarGrupos = New System.Windows.Forms.ToolStripButton
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.ToolStripMantto.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FireScrollEventOnMouseWheel = True
        Me.SplitContainer2.Horizontal = False
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Panel1.Controls.Add(Me.UcListaACCION_CONTRATADA1)
        Me.SplitContainer2.Panel1.Text = "Panel1"
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.UcDetalleACCION_CONTRATADA1)
        Me.SplitContainer2.Size = New System.Drawing.Size(841, 592)
        Me.SplitContainer2.SplitterPosition = 251
        Me.SplitContainer2.TabIndex = 1
        Me.SplitContainer2.Text = "SplitContainer1"
        '
        'UcListaACCION_CONTRATADA1
        '
        Me.UcListaACCION_CONTRATADA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaACCION_CONTRATADA1.ID_PROGRAMA_FORMACION = Nothing
        Me.UcListaACCION_CONTRATADA1.ID_PROVEEDOR_AF = Nothing
        Me.UcListaACCION_CONTRATADA1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaACCION_CONTRATADA1.Name = "UcListaACCION_CONTRATADA1"
        Me.UcListaACCION_CONTRATADA1.NUM_CONTRATO = ""
        Me.UcListaACCION_CONTRATADA1.PermitirBuscarEntityType = GetType(SGAFP.EL.ACCION_CONTRATADA)
        Me.UcListaACCION_CONTRATADA1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaACCION_CONTRATADA1.sError = Nothing
        Me.UcListaACCION_CONTRATADA1.Size = New System.Drawing.Size(841, 251)
        Me.UcListaACCION_CONTRATADA1.TabIndex = 1
        '
        'UcDetalleACCION_CONTRATADA1
        '
        Me.UcDetalleACCION_CONTRATADA1.ACCION_CONTRATADA = CType(resources.GetObject("UcDetalleACCION_CONTRATADA1.ACCION_CONTRATADA"), SGAFP.EL.ACCION_CONTRATADA)
        Me.UcDetalleACCION_CONTRATADA1.AutoScroll = True
        Me.UcDetalleACCION_CONTRATADA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleACCION_CONTRATADA1.EsNuevo = False
        Me.UcDetalleACCION_CONTRATADA1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleACCION_CONTRATADA1.Name = "UcDetalleACCION_CONTRATADA1"
        Me.UcDetalleACCION_CONTRATADA1.Size = New System.Drawing.Size(841, 336)
        Me.UcDetalleACCION_CONTRATADA1.TabIndex = 0
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ToolStripMantto)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(841, 621)
        Me.SplitContainerControl1.SplitterPosition = 24
        Me.SplitContainerControl1.TabIndex = 2
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'ToolStripMantto
        '
        Me.ToolStripMantto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonBuscar, Me.ToolStripButtonAgregar, Me.ToolStripButtonEditar, Me.ToolStripButtonGuardar, Me.ToolStripButtonCancelar, Me.ToolStripButtonEliminar, Me.ToolStripButtonCopiar, Me.ToolStripButtonAsociarGrupos, Me.ToolStripButtonDesasociarGrupos, Me.ToolStripSeparator2, Me.ToolStripButtonHabilitarGrupos})
        Me.ToolStripMantto.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripMantto.Name = "ToolStripMantto"
        Me.ToolStripMantto.Size = New System.Drawing.Size(841, 25)
        Me.ToolStripMantto.TabIndex = 6
        Me.ToolStripMantto.Text = "ToolStrip1"
        '
        'ToolStripButtonBuscar
        '
        Me.ToolStripButtonBuscar.Image = Global.SGAFP.PrintRibbonControllerResources.RibbonPrintPreview_Find
        Me.ToolStripButtonBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonBuscar.Name = "ToolStripButtonBuscar"
        Me.ToolStripButtonBuscar.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButtonBuscar.Text = "Buscar"
        '
        'ToolStripButtonAgregar
        '
        Me.ToolStripButtonAgregar.Image = Global.SGAFP.My.Resources.Resources.add
        Me.ToolStripButtonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAgregar.Name = "ToolStripButtonAgregar"
        Me.ToolStripButtonAgregar.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripButtonAgregar.Text = "Agregar"
        '
        'ToolStripButtonEditar
        '
        Me.ToolStripButtonEditar.Image = Global.SGAFP.My.Resources.Resources.ButtonEdit
        Me.ToolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEditar.Name = "ToolStripButtonEditar"
        Me.ToolStripButtonEditar.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripButtonEditar.Text = "Editar"
        '
        'ToolStripButtonGuardar
        '
        Me.ToolStripButtonGuardar.Image = Global.SGAFP.PrintRibbonControllerResources.RibbonPrintPreview_Save
        Me.ToolStripButtonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonGuardar.Name = "ToolStripButtonGuardar"
        Me.ToolStripButtonGuardar.Size = New System.Drawing.Size(69, 22)
        Me.ToolStripButtonGuardar.Text = "Guardar"
        '
        'ToolStripButtonCancelar
        '
        Me.ToolStripButtonCancelar.Image = Global.SGAFP.My.Resources.Resources.rechazar
        Me.ToolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCancelar.Name = "ToolStripButtonCancelar"
        Me.ToolStripButtonCancelar.Size = New System.Drawing.Size(73, 22)
        Me.ToolStripButtonCancelar.Text = "Cancelar"
        '
        'ToolStripButtonEliminar
        '
        Me.ToolStripButtonEliminar.Image = Global.SGAFP.My.Resources.Resources.Anular
        Me.ToolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEliminar.Name = "ToolStripButtonEliminar"
        Me.ToolStripButtonEliminar.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripButtonEliminar.Text = "Eliminar"
        '
        'ToolStripButtonCopiar
        '
        Me.ToolStripButtonCopiar.Image = Global.SGAFP.My.Resources.Resources.copy
        Me.ToolStripButtonCopiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCopiar.Name = "ToolStripButtonCopiar"
        Me.ToolStripButtonCopiar.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButtonCopiar.Text = "Copiar"
        '
        'ToolStripButtonAsociarGrupos
        '
        Me.ToolStripButtonAsociarGrupos.Image = Global.SGAFP.My.Resources.Resources.arrow_join
        Me.ToolStripButtonAsociarGrupos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAsociarGrupos.Name = "ToolStripButtonAsociarGrupos"
        Me.ToolStripButtonAsociarGrupos.Size = New System.Drawing.Size(116, 22)
        Me.ToolStripButtonAsociarGrupos.Text = "Asociar a Grupos"
        '
        'ToolStripButtonDesasociarGrupos
        '
        Me.ToolStripButtonDesasociarGrupos.Image = CType(resources.GetObject("ToolStripButtonDesasociarGrupos.Image"), System.Drawing.Image)
        Me.ToolStripButtonDesasociarGrupos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDesasociarGrupos.Name = "ToolStripButtonDesasociarGrupos"
        Me.ToolStripButtonDesasociarGrupos.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripButtonDesasociarGrupos.Text = "Desasociar Grupos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButtonHabilitarGrupos
        '
        Me.ToolStripButtonHabilitarGrupos.Image = Global.SGAFP.My.Resources.Resources.aprobar
        Me.ToolStripButtonHabilitarGrupos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonHabilitarGrupos.Name = "ToolStripButtonHabilitarGrupos"
        Me.ToolStripButtonHabilitarGrupos.Size = New System.Drawing.Size(113, 20)
        Me.ToolStripButtonHabilitarGrupos.Text = "Habilitar Grupos"
        '
        'ucMantACCION_CONTRATADA
        '
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "ucMantACCION_CONTRATADA"
        Me.Size = New System.Drawing.Size(841, 621)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.ToolStripMantto.ResumeLayout(False)
        Me.ToolStripMantto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaACCION_CONTRATADA1 As SGAFP.ucListaACCION_CONTRATADA
    Friend WithEvents UcDetalleACCION_CONTRATADA1 As SGAFP.ucDetalleACCION_CONTRATADA
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ToolStripMantto As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonAsociarGrupos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonHabilitarGrupos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonCopiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonDesasociarGrupos As System.Windows.Forms.ToolStripButton

End Class
