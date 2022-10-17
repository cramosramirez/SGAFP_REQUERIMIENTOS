Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantCONTRATO_BOLPROS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMantCONTRATO_BOLPROS))
        Me.SplitContainer2 = New DevExpress.XtraEditors.SplitContainerControl
        Me.UcListaCONTRATO_BOLPROS1 = New SGAFP.ucListaCONTRATO_BOLPROS
        Me.UcDetalleCONTRATO_BOLPROS1 = New SGAFP.ucDetalleCONTRATO_BOLPROS
        Me.SplitContainer1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.ToolStripMantto = New System.Windows.Forms.ToolStrip
        Me.ToolStripButtonBuscar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonAgregar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonEditar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonEliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonVerCursos = New System.Windows.Forms.ToolStripButton
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.UcListaCONTRATO_BOLPROS1)
        Me.SplitContainer2.Panel1.Text = "Panel1"
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.UcDetalleCONTRATO_BOLPROS1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1205, 574)
        Me.SplitContainer2.SplitterPosition = 291
        Me.SplitContainer2.TabIndex = 1
        Me.SplitContainer2.Text = "SplitContainer1"
        '
        'UcListaCONTRATO_BOLPROS1
        '
        Me.UcListaCONTRATO_BOLPROS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaCONTRATO_BOLPROS1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaCONTRATO_BOLPROS1.Name = "UcListaCONTRATO_BOLPROS1"
        Me.UcListaCONTRATO_BOLPROS1.PermitirBuscarEntityType = GetType(SGAFP.EL.CONTRATO_BOLPROS)
        Me.UcListaCONTRATO_BOLPROS1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaCONTRATO_BOLPROS1.sError = Nothing
        Me.UcListaCONTRATO_BOLPROS1.Size = New System.Drawing.Size(1205, 291)
        Me.UcListaCONTRATO_BOLPROS1.TabIndex = 1
        '
        'UcDetalleCONTRATO_BOLPROS1
        '
        Me.UcDetalleCONTRATO_BOLPROS1.AutoScroll = True
        Me.UcDetalleCONTRATO_BOLPROS1.CONTRATO_BOLPROS = CType(resources.GetObject("UcDetalleCONTRATO_BOLPROS1.CONTRATO_BOLPROS"), SGAFP.EL.CONTRATO_BOLPROS)
        Me.UcDetalleCONTRATO_BOLPROS1.DataSource = Nothing
        Me.UcDetalleCONTRATO_BOLPROS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleCONTRATO_BOLPROS1.EsNuevo = False
        Me.UcDetalleCONTRATO_BOLPROS1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleCONTRATO_BOLPROS1.Name = "UcDetalleCONTRATO_BOLPROS1"
        Me.UcDetalleCONTRATO_BOLPROS1.Size = New System.Drawing.Size(1205, 278)
        Me.UcDetalleCONTRATO_BOLPROS1.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Horizontal = False
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStripMantto)
        Me.SplitContainer1.Panel1.Text = "Panel1"
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Text = "Panel2"
        Me.SplitContainer1.Size = New System.Drawing.Size(1205, 603)
        Me.SplitContainer1.SplitterPosition = 24
        Me.SplitContainer1.TabIndex = 2
        Me.SplitContainer1.Text = "SplitContainerControl1"
        '
        'ToolStripMantto
        '
        Me.ToolStripMantto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonBuscar, Me.ToolStripButtonAgregar, Me.ToolStripButtonEditar, Me.ToolStripButtonGuardar, Me.ToolStripButtonCancelar, Me.ToolStripButtonEliminar, Me.ToolStripButtonVerCursos})
        Me.ToolStripMantto.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripMantto.Name = "ToolStripMantto"
        Me.ToolStripMantto.Size = New System.Drawing.Size(1205, 25)
        Me.ToolStripMantto.TabIndex = 5
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
        'ToolStripButtonVerCursos
        '
        Me.ToolStripButtonVerCursos.Image = Global.SGAFP.PrintRibbonControllerResources.RibbonPrintPreview_MultiplePagesLarge
        Me.ToolStripButtonVerCursos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonVerCursos.Name = "ToolStripButtonVerCursos"
        Me.ToolStripButtonVerCursos.Size = New System.Drawing.Size(83, 22)
        Me.ToolStripButtonVerCursos.Text = "Ver Cursos"
        '
        'ucMantCONTRATO_BOLPROS
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantCONTRATO_BOLPROS"
        Me.Size = New System.Drawing.Size(1205, 603)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStripMantto.ResumeLayout(False)
        Me.ToolStripMantto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaCONTRATO_BOLPROS1 As SGAFP.ucListaCONTRATO_BOLPROS
    Friend WithEvents UcDetalleCONTRATO_BOLPROS1 As SGAFP.UcDetalleCONTRATO_BOLPROS
    Friend WithEvents SplitContainer1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ToolStripMantto As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonVerCursos As System.Windows.Forms.ToolStripButton

End Class
