Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantSOLICITUD_CAPACITACION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMantSOLICITUD_CAPACITACION))
        Me.UcDetalleSOLICITUD_CAPACITACION1 = New SGAFP.ucDetalleSOLICITUD_CAPACITACION
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.ToolStripMantto = New System.Windows.Forms.ToolStrip
        Me.ToolStripButtonBuscar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonAgregar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonEditar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonGuardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonCancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonEliminar = New System.Windows.Forms.ToolStripButton
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl
        Me.UcListaSOLICITUD_CAPACITACION1 = New SGAFP.ucListaSOLICITUD_CAPACITACION
        Me.ToolStripButtonAgregarGrupo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButtonEliminarGrupo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        Me.ToolStripMantto.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcDetalleSOLICITUD_CAPACITACION1
        '
        Me.UcDetalleSOLICITUD_CAPACITACION1.AutoScroll = True
        Me.UcDetalleSOLICITUD_CAPACITACION1.EsNuevo = False
        Me.UcDetalleSOLICITUD_CAPACITACION1.Location = New System.Drawing.Point(3, 4)
        Me.UcDetalleSOLICITUD_CAPACITACION1.Name = "UcDetalleSOLICITUD_CAPACITACION1"
        Me.UcDetalleSOLICITUD_CAPACITACION1.Size = New System.Drawing.Size(1024, 344)
        Me.UcDetalleSOLICITUD_CAPACITACION1.SOLICITUD_CAPACITACION = CType(resources.GetObject("UcDetalleSOLICITUD_CAPACITACION1.SOLICITUD_CAPACITACION"), SGAFP.EL.SOLICITUD_CAPACITACION)
        Me.UcDetalleSOLICITUD_CAPACITACION1.TabIndex = 0
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.ToolStripMantto)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainerControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1024, 600)
        Me.SplitContainerControl1.SplitterPosition = 26
        Me.SplitContainerControl1.TabIndex = 2
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'ToolStripMantto
        '
        Me.ToolStripMantto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonBuscar, Me.ToolStripButtonAgregar, Me.ToolStripButtonEditar, Me.ToolStripButtonGuardar, Me.ToolStripButtonCancelar, Me.ToolStripButtonEliminar, Me.ToolStripSeparator1, Me.ToolStripButtonAgregarGrupo, Me.ToolStripButtonEliminarGrupo})
        Me.ToolStripMantto.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripMantto.Name = "ToolStripMantto"
        Me.ToolStripMantto.Size = New System.Drawing.Size(1024, 25)
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
        Me.ToolStripButtonEliminar.Size = New System.Drawing.Size(119, 22)
        Me.ToolStripButtonEliminar.Text = "Eliminar Solicitud"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.UcListaSOLICITUD_CAPACITACION1)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.UcDetalleSOLICITUD_CAPACITACION1)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(1024, 569)
        Me.SplitContainerControl2.SplitterPosition = 210
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'UcListaSOLICITUD_CAPACITACION1
        '
        Me.UcListaSOLICITUD_CAPACITACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaSOLICITUD_CAPACITACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcListaSOLICITUD_CAPACITACION1.Name = "UcListaSOLICITUD_CAPACITACION1"
        Me.UcListaSOLICITUD_CAPACITACION1.PermitirBuscarEntityType = GetType(SGAFP.EL.SOLICITUD_CAPACITACION)
        Me.UcListaSOLICITUD_CAPACITACION1.PreguntaEliminar = "¿Esta seguro de eliminar el registro?"
        Me.UcListaSOLICITUD_CAPACITACION1.sError = Nothing
        Me.UcListaSOLICITUD_CAPACITACION1.Size = New System.Drawing.Size(1024, 210)
        Me.UcListaSOLICITUD_CAPACITACION1.TabIndex = 1
        '
        'ToolStripButtonAgregarGrupo
        '
        Me.ToolStripButtonAgregarGrupo.Image = Global.SGAFP.My.Resources.Resources.aprobar
        Me.ToolStripButtonAgregarGrupo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAgregarGrupo.Name = "ToolStripButtonAgregarGrupo"
        Me.ToolStripButtonAgregarGrupo.Size = New System.Drawing.Size(105, 22)
        Me.ToolStripButtonAgregarGrupo.Text = "Agregar Grupo"
        '
        'ToolStripButtonEliminarGrupo
        '
        Me.ToolStripButtonEliminarGrupo.Image = Global.SGAFP.My.Resources.Resources.Remove
        Me.ToolStripButtonEliminarGrupo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEliminarGrupo.Name = "ToolStripButtonEliminarGrupo"
        Me.ToolStripButtonEliminarGrupo.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripButtonEliminarGrupo.Text = "Eliminar Grupo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ucMantSOLICITUD_CAPACITACION
        '
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Name = "ucMantSOLICITUD_CAPACITACION"
        Me.Size = New System.Drawing.Size(1024, 600)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        Me.ToolStripMantto.ResumeLayout(False)
        Me.ToolStripMantto.PerformLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UcDetalleSOLICITUD_CAPACITACION1 As SGAFP.ucDetalleSOLICITUD_CAPACITACION
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents ToolStripMantto As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButtonBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaSOLICITUD_CAPACITACION1 As SGAFP.ucListaSOLICITUD_CAPACITACION
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButtonAgregarGrupo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButtonEliminarGrupo As System.Windows.Forms.ToolStripButton

End Class
