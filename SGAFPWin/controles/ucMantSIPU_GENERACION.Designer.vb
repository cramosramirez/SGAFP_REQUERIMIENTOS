Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantSIPU_GENERACION
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
        Me.UcListaSIPU_GENERACION1 = New SGAFP.ucListaSIPU_GENERACION
        Me.UcDetalleSIPU_GENERACION1 = New SGAFP.ucDetalleSIPU_GENERACION
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaSIPU_GENERACION1)
        Me.SplitContainer1.Panel1.Text = "Panel1"
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleSIPU_GENERACION1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterPosition = 251
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.Text = "SplitContainer1"
        '
        'UcListaSIPU_GENERACION1
        '
        Me.UcListaSIPU_GENERACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaSIPU_GENERACION1.Location = New System.Drawing.Point(0,0)
        Me.UcListaSIPU_GENERACION1.Name = "UcListaSIPU_GENERACION1"
        Me.UcListaSIPU_GENERACION1.PermitirBuscarEntityType = GetType(SIPU_GENERACION)
        Me.UcListaSIPU_GENERACION1.sError = Nothing
        Me.UcListaSIPU_GENERACION1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaSIPU_GENERACION1.TabIndex = 1
        '
        'UcDetalleSIPU_GENERACION1
        '
        Me.UcDetalleSIPU_GENERACION1.AutoScroll = True
        Me.UcDetalleSIPU_GENERACION1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleSIPU_GENERACION1.EsNuevo = False
        Me.UcDetalleSIPU_GENERACION1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleSIPU_GENERACION1.Name = "UcDetalleSIPU_GENERACION1"
        Me.UcDetalleSIPU_GENERACION1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleSIPU_GENERACION1.TabIndex = 0
        '
        'ucMantSIPU_GENERACION
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantSIPU_GENERACION"
        Me.Size = New System.Drawing.Size(650, 440)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaSIPU_GENERACION1 As SGAFP.ucListaSIPU_GENERACION
    Friend WithEvents UcDetalleSIPU_GENERACION1 As SGAFP.UcDetalleSIPU_GENERACION

End Class
