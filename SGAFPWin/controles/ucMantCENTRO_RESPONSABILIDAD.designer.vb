Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantCENTRO_RESPONSABILIDAD
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
        Me.UcListaCENTRO_RESPONSABILIDAD1 = New SGAFP.ucListaCENTRO_RESPONSABILIDAD
        Me.UcDetalleCENTRO_RESPONSABILIDAD1 = New SGAFP.ucDetalleCENTRO_RESPONSABILIDAD
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaCENTRO_RESPONSABILIDAD1)
        Me.SplitContainer1.Panel1.Text = "Panel1"
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleCENTRO_RESPONSABILIDAD1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterPosition = 251
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.Text = "SplitContainer1"
        '
        'UcListaCENTRO_RESPONSABILIDAD1
        '
        Me.UcListaCENTRO_RESPONSABILIDAD1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaCENTRO_RESPONSABILIDAD1.Location = New System.Drawing.Point(0,0)
        Me.UcListaCENTRO_RESPONSABILIDAD1.Name = "UcListaCENTRO_RESPONSABILIDAD1"
        Me.UcListaCENTRO_RESPONSABILIDAD1.PermitirBuscarEntityType = GetType(CENTRO_RESPONSABILIDAD)
        Me.UcListaCENTRO_RESPONSABILIDAD1.sError = Nothing
        Me.UcListaCENTRO_RESPONSABILIDAD1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaCENTRO_RESPONSABILIDAD1.TabIndex = 1
        '
        'UcDetalleCENTRO_RESPONSABILIDAD1
        '
        Me.UcDetalleCENTRO_RESPONSABILIDAD1.AutoScroll = True
        Me.UcDetalleCENTRO_RESPONSABILIDAD1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleCENTRO_RESPONSABILIDAD1.EsNuevo = False
        Me.UcDetalleCENTRO_RESPONSABILIDAD1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleCENTRO_RESPONSABILIDAD1.Name = "UcDetalleCENTRO_RESPONSABILIDAD1"
        Me.UcDetalleCENTRO_RESPONSABILIDAD1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleCENTRO_RESPONSABILIDAD1.TabIndex = 0
        '
        'ucMantCENTRO_RESPONSABILIDAD
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantCENTRO_RESPONSABILIDAD"
        Me.Size = New System.Drawing.Size(650, 440)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaCENTRO_RESPONSABILIDAD1 As SGAFP.ucListaCENTRO_RESPONSABILIDAD
    Friend WithEvents UcDetalleCENTRO_RESPONSABILIDAD1 As SGAFP.UcDetalleCENTRO_RESPONSABILIDAD

End Class
