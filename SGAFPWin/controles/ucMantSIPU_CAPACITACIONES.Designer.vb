Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantSIPU_CAPACITACIONES
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
        Me.SplitContainer1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.UcListaSIPU_CAPACITACIONES1 = New SGAFP.ucListaSIPU_CAPACITACIONES
        Me.UcDetalleSIPU_CAPACITACIONES1 = New SGAFP.ucDetalleSIPU_CAPACITACIONES
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FireScrollEventOnMouseWheel = True
        Me.SplitContainer1.Horizontal = False
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaSIPU_CAPACITACIONES1)
        Me.SplitContainer1.Panel1.Text = "Panel1"
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleSIPU_CAPACITACIONES1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterPosition = 251
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.Text = "SplitContainer1"
        '
        'UcListaSIPU_CAPACITACIONES1
        '
        Me.UcListaSIPU_CAPACITACIONES1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaSIPU_CAPACITACIONES1.Location = New System.Drawing.Point(0,0)
        Me.UcListaSIPU_CAPACITACIONES1.Name = "UcListaSIPU_CAPACITACIONES1"
        Me.UcListaSIPU_CAPACITACIONES1.PermitirBuscarEntityType = GetType(SIPU_CAPACITACIONES)
        Me.UcListaSIPU_CAPACITACIONES1.sError = Nothing
        Me.UcListaSIPU_CAPACITACIONES1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaSIPU_CAPACITACIONES1.TabIndex = 1
        '
        'UcDetalleSIPU_CAPACITACIONES1
        '
        Me.UcDetalleSIPU_CAPACITACIONES1.AutoScroll = True
        Me.UcDetalleSIPU_CAPACITACIONES1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleSIPU_CAPACITACIONES1.EsNuevo = False
        Me.UcDetalleSIPU_CAPACITACIONES1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleSIPU_CAPACITACIONES1.Name = "UcDetalleSIPU_CAPACITACIONES1"
        Me.UcDetalleSIPU_CAPACITACIONES1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleSIPU_CAPACITACIONES1.TabIndex = 0
        '
        'ucMantSIPU_CAPACITACIONES
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantSIPU_CAPACITACIONES"
        Me.Size = New System.Drawing.Size(650, 440)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaSIPU_CAPACITACIONES1 As SGAFP.ucListaSIPU_CAPACITACIONES
    Friend WithEvents UcDetalleSIPU_CAPACITACIONES1 As SGAFP.UcDetalleSIPU_CAPACITACIONES

End Class
