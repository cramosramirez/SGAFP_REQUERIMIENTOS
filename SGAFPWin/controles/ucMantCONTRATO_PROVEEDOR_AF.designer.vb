Imports SGAFP.EL
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucMantCONTRATO_PROVEEDOR_AF
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
        Me.UcListaCONTRATO_PROVEEDOR_AF1 = New SGAFP.ucListaCONTRATO_PROVEEDOR_AF
        Me.UcDetalleCONTRATO_PROVEEDOR_AF1 = New SGAFP.ucDetalleCONTRATO_PROVEEDOR_AF
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.UcListaCONTRATO_PROVEEDOR_AF1)
        Me.SplitContainer1.Panel1.Text = "Panel1"
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.UcDetalleCONTRATO_PROVEEDOR_AF1)
        Me.SplitContainer1.Size = New System.Drawing.Size(650, 440)
        Me.SplitContainer1.SplitterPosition = 251
        Me.SplitContainer1.TabIndex = 1
        Me.SplitContainer1.Text = "SplitContainer1"
        '
        'UcListaCONTRATO_PROVEEDOR_AF1
        '
        Me.UcListaCONTRATO_PROVEEDOR_AF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcListaCONTRATO_PROVEEDOR_AF1.Location = New System.Drawing.Point(0,0)
        Me.UcListaCONTRATO_PROVEEDOR_AF1.Name = "UcListaCONTRATO_PROVEEDOR_AF1"
        Me.UcListaCONTRATO_PROVEEDOR_AF1.PermitirBuscarEntityType = GetType(CONTRATO_PROVEEDOR_AF)
        Me.UcListaCONTRATO_PROVEEDOR_AF1.sError = Nothing
        Me.UcListaCONTRATO_PROVEEDOR_AF1.Size = New System.Drawing.Size(650, 251)
        Me.UcListaCONTRATO_PROVEEDOR_AF1.TabIndex = 1
        '
        'UcDetalleCONTRATO_PROVEEDOR_AF1
        '
        Me.UcDetalleCONTRATO_PROVEEDOR_AF1.AutoScroll = True
        Me.UcDetalleCONTRATO_PROVEEDOR_AF1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UcDetalleCONTRATO_PROVEEDOR_AF1.EsNuevo = False
        Me.UcDetalleCONTRATO_PROVEEDOR_AF1.Location = New System.Drawing.Point(0, 0)
        Me.UcDetalleCONTRATO_PROVEEDOR_AF1.Name = "UcDetalleCONTRATO_PROVEEDOR_AF1"
        Me.UcDetalleCONTRATO_PROVEEDOR_AF1.Size = New System.Drawing.Size(650, 185)
        Me.UcDetalleCONTRATO_PROVEEDOR_AF1.TabIndex = 0
        '
        'ucMantCONTRATO_PROVEEDOR_AF
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ucMantCONTRATO_PROVEEDOR_AF"
        Me.Size = New System.Drawing.Size(650, 440)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents UcListaCONTRATO_PROVEEDOR_AF1 As SGAFP.ucListaCONTRATO_PROVEEDOR_AF
    Friend WithEvents UcDetalleCONTRATO_PROVEEDOR_AF1 As SGAFP.UcDetalleCONTRATO_PROVEEDOR_AF

End Class
