Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantCONTRATO_COMPRA
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
        Me.SplitContainer2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.UcListaCONTRATO_COMPRA1 = New SGAFP.ucListaCONTRATO_COMPRA()
        Me.UcDetalleCONTRATO_COMPRA1 = New SGAFP.ucDetalleCONTRATO_COMPRA()
        Me.SplitContainer1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.ToolStripMantto = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCargarContratos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonCargarCursos = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.UcListaCONTRATO_COMPRA1)
        Me.SplitContainer2.Panel1.Text = "Panel1"
        Me.SplitContainer2.Panel2.AutoScroll = True
        Me.SplitContainer2.Panel2.Controls.Add(Me.UcDetalleCONTRATO_COMPRA1)
        Me.SplitContainer2.Size = New System.Drawing.Size(650, 411)
        Me.SplitContainer2.SplitterPosition = 170
        Me.SplitContainer2.TabIndex = 1
        Me.SplitContainer2.Text = "SplitContainer1"
        '
        'UcListaCONTRATO_COMPRA1
        '
        Me.UcListaCONTRATO_COMPRA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaCONTRATO_COMPRA1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaCONTRATO_COMPRA1.Name = "UcListaCONTRATO_COMPRA1"
        Me.UcListaCONTRATO_COMPRA1.PermitirBuscarEntityType = Nothing
        Me.UcListaCONTRATO_COMPRA1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaCONTRATO_COMPRA1.sError = Nothing
        Me.UcListaCONTRATO_COMPRA1.Size = New System.Drawing.Size(650, 170)
        Me.UcListaCONTRATO_COMPRA1.TabIndex = 0
        '
        'UcDetalleCONTRATO_COMPRA1
        '
        Me.UcDetalleCONTRATO_COMPRA1.AutoScroll = True
        Me.UcDetalleCONTRATO_COMPRA1.CONTRATO_COMPRA = Nothing
        Me.UcDetalleCONTRATO_COMPRA1.DataSource = Nothing
        Me.UcDetalleCONTRATO_COMPRA1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleCONTRATO_COMPRA1.EsNuevo = False
        Me.UcDetalleCONTRATO_COMPRA1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleCONTRATO_COMPRA1.Name = "UcDetalleCONTRATO_COMPRA1"
        Me.UcDetalleCONTRATO_COMPRA1.Size = New System.Drawing.Size(650, 236)
        Me.UcDetalleCONTRATO_COMPRA1.TabIndex = 0
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
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterPosition = 24
        Me.SplitContainer1.TabIndex = 3
        Me.SplitContainer1.Text = "SplitContainerControl1"
        '
        'ToolStripMantto
        '
        Me.ToolStripMantto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonBuscar, Me.ToolStripButtonAgregar, Me.ToolStripButtonEditar, Me.ToolStripButtonGuardar, Me.ToolStripButtonCancelar, Me.ToolStripButtonEliminar, Me.ToolStripButtonCargarContratos, Me.ToolStripButtonCargarCursos})
        Me.ToolStripMantto.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripMantto.Name = "ToolStripMantto"
        Me.ToolStripMantto.Size = New System.Drawing.Size(650, 25)
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
        'ToolStripButtonCargarContratos
        '
        Me.ToolStripButtonCargarContratos.Image = Global.SGAFP.My.Resources.Resources.excel
        Me.ToolStripButtonCargarContratos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCargarContratos.Name = "ToolStripButtonCargarContratos"
        Me.ToolStripButtonCargarContratos.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripButtonCargarContratos.Text = "Cargar contratos"
        '
        'ToolStripButtonCargarCursos
        '
        Me.ToolStripButtonCargarCursos.Image = Global.SGAFP.My.Resources.Resources.excel
        Me.ToolStripButtonCargarCursos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonCargarCursos.Name = "ToolStripButtonCargarCursos"
        Me.ToolStripButtonCargarCursos.Size = New System.Drawing.Size(99, 22)
        Me.ToolStripButtonCargarCursos.Text = "Cargar cursos"
        '
        'ucMantCONTRATO_COMPRA
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantCONTRATO_COMPRA"
        Me.Size = New System.Drawing.Size(650, 440)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStripMantto.ResumeLayout(False)
        Me.ToolStripMantto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcListaCONTRATO_COMPRA1 As SGAFP.ucListaCONTRATO_COMPRA
    Friend WithEvents UcDetalleCONTRATO_COMPRA1 As SGAFP.ucDetalleCONTRATO_COMPRA
    Friend WithEvents SplitContainer2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents SplitContainer1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ToolStripMantto As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonCargarContratos As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ToolStripButtonCargarCursos As System.Windows.Forms.ToolStripButton
End Class
